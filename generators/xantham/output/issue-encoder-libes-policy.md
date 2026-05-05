# [Encoder] Define a stable policy for `lib.es*` type references

## Summary

When the extractor walks user TypeScript that references the standard library (`Promise`, `Array`, `Date`, `Error`, `ReadableStream`, `Map`, `Set`, etc.), the resulting JSON's handling of those references is inconsistent — they sometimes appear as inlined types in the TypeMap, sometimes as bare TypeKey references, and sometimes as unresolvable `MISSREF` references that crash the decoder downstream. A documented policy ("lib.es types are always X") would let consumer generators wire a single external resolver and stop trying to detect each case empirically.

This is related to the `MISSREF` decoder crash in a separate issue, but is the broader concern that drives it.

## What we observe

The `XanthamTree` runtime object exposes a `LibEsExports` set (11,208 entries when loaded against `workers-types`) and an `IsLibEsExport(key)` predicate, so the encoder is clearly distinguishing lib.es types in some way during walk. But the *consumer-facing behavior* of those references is mixed:

- **`dynamic-workflows.fs:170`** — `Promise<'R>` renders correctly: lib.es type referenced by F# name, no inlining, no missing key. Works as a consumer would want.
- **`agents.json`** — references `lib.es5.d.ts:1680:1` via TypeKey `-1550` with no `TypeMap` entry. Decoder crashes. (See `issue-decoder-missref.md`.)
- **`workers-types.json`** — has `LibEsExports` set with 11,208 entries, plus three additional `MISSREF` keys (`-387`, `-10203`, `-10224`, `-10413`) that pointed into the user surface, not lib.es. The decoder didn't crash on those.

So `lib.es` references that survive cleanly *do* render correctly as F# names; references that drop through the cracks become unresolvable. There's no signal in the JSON telling a consumer which of those two paths a given key took.

## What would help

A documented and predictable policy. Any one of these would let consumer generators wire deterministic handling. Listed in order of what I'd guess is least to most invasive on your side:

- **(a)** Always emit `lib.es` references by external name in the JSON (TypeKey + a `LibEsName: "Promise"` field, say). Never inline. Consumers maintain a small lib.es → F# resolver and use the name directly. The encoder may already be doing this for some references — the proposal is "always."

- **(b)** Always inline `lib.es` types into the TypeMap so they have full structural definitions. Consumers can choose to render them by F# name (preferred) or to use the structural definition. The cost is JSON size — a substantial fraction of the 14.8 MB `workers-types.json` is probably already lib.es definitions.

- **(c)** Per-reference flag indicating which path was taken: `{ TypeKey, IsLibEsExternal, LibEsName? }`. Consumers detect and route. Most flexible but the most surface area.

For our use case, (a) is the most useful. Lib.es types are well-known; consumer generators want to render them by name and let the F# / Fable side resolve them via existing bindings.

## Use case

Cloudflare's surface (`workers-types`, `agents`, `dynamic-workflows`) references hundreds of lib.es types — `Promise<T>`, `Array<T>`, `ReadableStream<T>`, `Map<K, V>`, `Date`, `Error`, `URL`, `URLSearchParams`, `Headers`, `Request`, `Response`, `Blob`, etc. We want all of those to render to their F# / Fable.Core equivalent names without duplicating a thousand lines of structural definitions for `Array.prototype.*` into our own bindings. Today we get *most* of them right (the majority survive as F# names), but a handful drop through into either inlined definitions or unresolvable keys, and we have to detect each case.

## Why this matters

Beyond the immediate `MISSREF`-causes-decoder-crash issue, this is the boundary condition between "user types we want to bind" and "TypeScript stdlib types we want to reference by name." The split needs to be machine-distinguishable in the JSON so consumer generators don't have to maintain a list of "known lib.es names" themselves. You already have the boundary information in the encoder (`LibEsExports`); the question is just whether it surfaces consistently for every reference.

## What's *not* asked

- No fix prescription. (a)/(b)/(c) are sketches of what *kinds* of contracts would be useful; they're not implementation proposals.
- No criticism of the current mixed behavior — most of the time the lib.es references render correctly.
- No request to bind lib.es types in the encoder itself; consumers handle that side.

## Artifacts

In `Fidelity.CloudEdge/generators/xantham/output/`:

- `dynamic-workflows.fs` — successful lib.es references (`Promise<'R>`, `Date`, `Error`)
- `agents.json` — references `lib.es5.d.ts:1680:1` via `MISSREF` TypeKey `-1550`
- `workers-types.json` — has `LibEsExports` set with 11,208 entries; comparison case
- `observations.md` — full catalog
- `issue-decoder-missref.md` — the directly-related crash issue this drives
