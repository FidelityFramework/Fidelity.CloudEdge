# [Schema] Expose npm package boundaries on exports so consumer generators don't path-parse

## Summary

The current JSON schema includes raw filesystem `Source` paths for each type. Consumer generators end up parsing those paths to recover npm package identity — "this came from `@cloudflare/workers-types`, this came from `agents`, this came from `typescript/lib/lib.es5.d.ts`." Exposing the package boundary explicitly in the schema would let consumers produce clean module names, well-formed `[<Import>]` attributes, and correct cross-binding type identity without ad hoc path-parsing.

You mentioned in Discord that the module names in the reference generator are "barbaric, planning to clean up" — pushing the package-boundary information up to the schema layer means every consumer generator benefits from the cleanup, not just the reference one.

## What the consumer is doing today

When the encoder is given an absolute filesystem path as input (e.g., `/tmp/cf-sdk-latest/node_modules/agents/dist/index.d.ts`), the resulting JSON's `Source` field for each type is the absolute path. The consumer generator then has to:

1. Parse the path string.
2. Find the `node_modules/` segment.
3. Walk forward to find the package name (`@scope/name` or `name`).
4. Continue past `dist/` or `lib/` to recover the relative file path within the package.
5. Decide whether to fold the package's internal modules into one F# module or preserve their structure.

This is fragile and yields different results depending on whether the input path is absolute, relative, scoped (`@cloudflare/...`), or a `lib.es*` reference. The artifact `dynamic-workflows.fs` in this directory shows what works (the package name `@cloudflare/dynamic-workflows` survives into module names and `Import` attributes); earlier runs with absolute paths produced module names like `CloudEdge/nodeModules/@cloudflare/dynamicWorkflows/dist/binding`.

## What the encoder presumably already knows

While walking a `.d.ts`, the encoder must already distinguish:

- The npm package name and version (from the nearest `package.json`)
- The package entry point (from `package.json` `types` / `exports.types`)
- Whether a referenced type is "internal to this package" vs. "from another package" vs. "from `lib.es*`"

That information appears to be reduced to a flat `Source` path string by the time it reaches the JSON. Consumers reconstruct it imperfectly.

## What would help

Add explicit package-boundary information to the schema. Form-of-the-thing isn't critical; either of these would work:

- **Per-type fields**: add `Package: { Name, Version, Entry, IsExternal }` (or similar) on each type/export, alongside the existing `Source`. Consumers read it directly.
- **Top-level `PackageMap`**: a separate dictionary at the root of the JSON keyed by package, with the per-package metadata, and per-type entries reference into it by index.

The latter is probably more compact for large surfaces.

## Use cases this enables for consumers

- **Clean module names**: `module Cloudflare.Agents` rather than `module CloudEdge/nodeModules/agents/dist/index`.
- **Correct `[<Import>]` attributes**: `[<Import("@cloudflare/workers-types", "Request")>]` rather than `[<Import("./request.js.CloudEdge/...", "Request")>]`.
- **Cross-package type identity**: when our generator binds `agents` and that surface references `DurableObject` from `workers-types`, we can resolve the cross-package reference to a stable F# type name so both bindings line up. Today this requires path string-matching.
- **Distinguishing user code from `lib.es`**: see the separate lib.es policy issue.

## Why this matters from the consumer side

We want to bind the full Cloudflare SDK surface (`workers-types`, `agents`, `dynamic-workflows`, eventually Sandboxes when its API spec lands) from a single generator with consistent module structure. The `Source`-path-parsing approach makes this surprisingly path-dependent — the same package generates different output depending on whether it's invoked with an absolute or relative path. Pushing the package identity into the schema decouples consumer output from input-invocation details.

## What's *not* asked

- No specific schema shape proposed beyond the two sketches above.
- No claim about whether this is something to do in the encoder, the decoder, or as a derived view on top of `XanthamTree`.
- No timeline expectation — flagging as a consumer-side wish, not a blocker.

## Artifacts

In `Fidelity.CloudEdge/generators/xantham/output/`:

- `dynamic-workflows.fs` — successful case where the package name survives into module/import paths
- `dynamic-workflows.json` — corresponding encoder output
- `observations.md` — full catalog (§7 has the contrast example showing what clean module structure looks like when paths happen to parse well)
