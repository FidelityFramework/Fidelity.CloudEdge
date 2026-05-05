# [Xantham.Decoder] `KeyNotFoundException` during `compress` pass on `MISSREF` TypeKeys

## Summary

When the encoder emits a `TypeKey` for a referenced type that wasn't successfully bound (logged at extraction time as `[MISSREF]`), the decoder's compression pass throws `System.Collections.Generic.KeyNotFoundException` rather than handling the missing reference. This blocks all downstream consumption — neither the consumer generator nor any other downstream `Xantham.Decoder` user can read the JSON.

Encountered while running the encoder against `agents@0.12.3` (the renamed `agents-sdk` package).

## Reproduction

The artifact `output/agents.json` (17 MB) is included alongside this issue document. To reproduce against it:

```bash
# Build the .NET libraries from xantham-44
dotnet build src/Xantham.Decoder/Xantham.Decoder.fsproj -c Release

# Trigger the crash from any consumer driver
let tree = Xantham.Decoder.Runtime.create "output/agents.json"
// Throws KeyNotFoundException before returning
```

## What the encoder emitted

During extraction the encoder logged exactly one `MISSREF` diagnostic to stderr:

```
[MISSREF] - TypeKey -1550 - Missing type builder value -
file:////home/hhh/repos/speakez-xantham/node_modules/typescript/lib/lib.es5.d.ts:1680:1 (end 1680:29)
```

The encoder then wrote the JSON normally and exited 0. The JSON contains a reference to TypeKey `-1550` somewhere in the type graph, but no entry for `-1550` in the `TypeMap`.

## What the decoder does

The decoder reaches the missing key during compression and throws:

```
System.Collections.Generic.KeyNotFoundException: The given key '-1550' was not present in the dictionary.
   at System.Collections.Generic.Dictionary`2.get_Item(TKey key)
   at Xantham.Decoder.Utils.swapType@221 (Utils.fs:223)
   at Xantham.Decoder.Utils.compressWithMap@342 (Utils.fs:342)
   at Xantham.Decoder.Utils.compressResult (Utils.fs:389)
   at Xantham.Decoder.Utils.compress (Utils.fs:531)
   at Xantham.Decoder.Decoder.readWithSettings (Core.fs:123)
   at Xantham.Decoder.Decoder.read (Core.fs:145)
   at Xantham.Decoder.Runtime.XanthamTree..ctor (Runtime.fs:48)
```

## Comparison: workers-types

The `@cloudflare/workers-types@4.20260504.1` extraction also produced `MISSREF` diagnostics during encoding (TypeKeys `-387`, `-10203`, `-10224`, `-10413`) — but the decoder did *not* crash on those, and the JSON loaded successfully. The artifact `output/workers-types.json` (15 MB) is included for comparison.

I cannot tell from the output alone what differs between the agents `-1550` case (crashes) and the workers-types `MISSREF` cases (clean). Possibilities I'd consider equally likely:

- Agents' missing key sits in a shape that compression *must* look up (e.g., a TypeReference's resolved-type) while workers-types' missing keys sit in shapes compression can skip.
- Workers-types' compression happened to terminate before reaching the missing keys due to ordering.
- The keys in workers-types' case have stub entries somewhere I'm not seeing; agents' don't.

## What would help (consumer perspective)

A documented contract for what the consumer should expect. The crash itself isn't the issue; the absence of a contract is. Any of these would unblock us:

- **(a)** Encoder always emits a stub `TsType` (e.g., `Primitive Unknown` or a new `MissingReference` variant) for keys that hit `MISSREF` during walk. The decoder always finds something. Consumers can detect the stub and decide.
- **(b)** Decoder swallows missing keys, substitutes a sentinel, and exposes the unresolved key list as a property on `XanthamTree`. Consumers can choose to fail-fast or proceed.
- **(c)** Encoder validates and refuses to write a JSON with dangling references; raises during extraction; the JSON is never produced.

Any one of those is a defined contract. Currently the JSON is half-formed and the failure mode is implicit.

## Why this matters

`agents@0.12.3` is one of the SDK packages we want to bind. The crash means the surface is fully unreachable from any `Xantham.Decoder`-based consumer. The decoder is the layer you've said you want to maintain yourself, so we wanted to surface this here rather than route around it in our generator.

## What's *not* asked

- No fix prescription for `Utils.fs:223`. The right place to handle this might be there, might be at JSON-write time in the encoder, might be earlier in the walk — that's your call.
- No claim about which option (a)/(b)/(c) is correct.
- No criticism of the current behavior; just empirical evidence of how it manifests for a current-Cloudflare consumer.

## Artifacts

In `Fidelity.CloudEdge/generators/xantham/output/`:

- `agents.json` (17 MB) — the encoder JSON that triggers the crash
- `workers-types.json` (15 MB) — comparison case where the decoder didn't crash on `MISSREF` keys
- `observations.md` — full catalog this issue is drawn from (§3)
