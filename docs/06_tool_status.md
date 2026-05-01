# Fidelity.CloudEdge Tool Status & Known Limitations

**Last Updated**: May 2026

This document tracks the current state of Glutinum and Hawaii as used by the CloudEdge generation pipeline, including known limitations and the mitigations in place.

For the original detailed analysis (Glutinum v0.12.0, Hawaii v0.66.0), see `_archived/06_tool_improvement_analysis_v1.md`.

## Tool Versions

| Tool | Version | Role |
|------|---------|------|
| Hawaii | 0.66.0 | OpenAPI → F# client generation |
| Glutinum CLI | Latest (npx) | TypeScript `.d.ts` → F# binding generation |

## Binding Inputs

The generation pipeline consumes the following sources:

| Input | Source | Tool | Output |
|-------|--------|------|--------|
| Cloudflare OpenAPI | `https://github.com/cloudflare/api-schemas` | Hawaii | 40 Management + 2 Tenancy services |
| `@cloudflare/workers-types` | npm package | Glutinum | Worker.Context, AI, DurableObjects |
| `@cloudflare/agents` | npm package (planned 0.3.0) | Glutinum | Agent, Think runtime types — see "Glutinum: Anticipated Considerations for Agents Binding" below |
| `@cloudflare/dynamic-workflows` | npm package (planned 0.3.0) | Glutinum | Multi-tenant workflow dispatch primitives |

## Hawaii: Known Limitations & Mitigations

### 1. NullReferenceException on Empty Schema Entries

**Symptom**: Hawaii crashes when an OpenAPI spec contains `"application/json": {}` with no `schema` field in `requestBody` or response content.

**Root Cause**: `createResponseType` at line 1348 dereferences `.schema` unconditionally.

**Mitigation**: `generators/scripts/preprocess-openapi.sh` ensures every content-type entry has a schema field before Hawaii processes it.

**Services Affected**: KV, Workers, Logs (all now generating cleanly after preprocessing).

### 2. No Native Discriminator Schema Support

**Symptom**: OpenAPI specs using `discriminator` with `oneOf`/`anyOf` produce flat type lists with no discriminated union.

**Mitigation**: The `discriminators.fsx` post-processor generates F# DUs from the binding types. Currently applied to Workers (29 binding type variants).

### 3. Type Name Sanitization Inconsistencies

**Symptom**: Type names containing hyphens, underscores, and `@` symbols are sanitized inconsistently, producing names that do not match between `Types.fs` and `Client.fs`.

**Mitigation**: Manual compilation patches for affected services. Five services (KV, Workers, Logs, Queues, Vectorize) required type name fixes after generation.

**Desired Improvement**: Cumulative sanitization in Hawaii's `sanitizeTypeName` function. A local fork with this fix existed previously; the fix should be upstreamed.

### 4. Missing Body Parameters

**Symptom**: Some endpoints that accept a JSON request body generate client methods with no body parameter.

**Mitigation**: The `missing-body-params.fsx` post-processor adds the missing parameter and `RequestPart.jsonContent` to the requestParts list. Currently applied to Workers' `WorkerPutScriptSecret` method.

### 5. JObject in Multipart Form Data

**Symptom**: Methods using `multipartFormData` pass field values without JSON serialization, causing runtime errors for complex types.

**Mitigation**: The `jobject-multipart.fsx` post-processor adds `.ToString(Newtonsoft.Json.Formatting.None)` conversion where needed.

### 6. Package Dependencies

Hawaii's generated `OpenApiHttp.fs` imports `Fable.Remoting.Json` and `Newtonsoft.Json`. All management `.fsproj` files must reference these packages, not `FSharp.SystemTextJson`.

## Glutinum: Known Limitations & Mitigations

### 1. Cyclic Interface References

**Symptom**: Stack overflow during generation when TypeScript interfaces form reference cycles.

**Mitigation**: `generators/scripts/preprocess-typescript.js` detects cycles and breaks them by replacing back-references with `obj`. The preprocessor detected 6 cyclic interfaces in the current `workers-types` and applied 12 cycle-breaking replacements.

### 2. Reserved Keyword Handling

**Symptom**: Properties like `namespace`, `type`, `end` generate as backtick-escaped identifiers, degrading developer experience.

**Current State**: Backtick escaping works but is ergonomically poor. The preferred approach is `[<CompiledName("namespace")>]` with PascalCase member names, enabling clean F# while preserving JavaScript interop.

**Status**: Not yet automated in Glutinum. Would require a PR to Glutinum's property emission logic.

### 3. Object Expression Syntax (FS3168)

**Symptom**: Glutinum generates `member val` inside object expressions, which F# does not allow.

**Mitigation**: Handled by `postprocess-runtime.sh`, which converts to getter/setter with backing fields.

### 4. Global Values in Namespaces (FS0201)

**Symptom**: Global values placed directly in namespaces produce compilation errors.

**Mitigation**: Handled by `postprocess-runtime.sh`, which wraps globals in a `Globals` module.

## Glutinum: Anticipated Considerations for Agents Binding

The 0.3.0 release adds Glutinum binding generation for `@cloudflare/agents` and `@cloudflare/dynamic-workflows`. These packages exercise corners of Glutinum that the existing `workers-types` and `@cloudflare/ai` bindings have not. The following considerations are flagged in advance so mitigations can be planned alongside the binding work, not discovered at generation time.

### 1. TypeScript Decorator Syntax (`@callable()`)

**Anticipated symptom**: Cloudflare's Agent class uses TypeScript decorators (most prominently `@callable()` to mark RPC entry points). Glutinum's handling of decorator metadata in `.d.ts` declarations is unverified for this case. The decorator carries semantic meaning (this method is exposed as RPC over WebSocket) that the F# binding needs to preserve.

**Approach options**:
- Map `@callable()` to an F# attribute (`[<Callable>]`) emitted on the bound method. The attribute would be a Fidelity-defined attribute that the deployment-time binding generator (the JS shim emitter) reads to decide which methods to expose via Cloudflare's RPC mechanism.
- If Glutinum cannot capture the decorator information from `.d.ts`, a post-processor can read the original TypeScript source and inject the F# attribute into the generated bindings.

**Status**: Investigation needed during 0.3.0 work. Likely resolved via a new post-processor (`callable-attribute.fsx` or similar).

### 2. Generic Class Declarations (`Agent<Env, State>`, `Think<Env, State>`)

**Anticipated symptom**: Glutinum's handling of TypeScript generic classes with multiple type parameters has not been exercised at this scale by existing bindings. `Agent<Env, State>` and `Think<Env, State>` are generic in both the environment shape (Cloudflare bindings) and the state shape. The F# binding needs to surface both as F# generic parameters.

**Approach**: Verify Glutinum produces correct F# generic class declarations. If not, a post-processor adjusts the generated class signatures to expose the generics.

**Status**: Investigation needed. Existing bindings (e.g., `KVNamespace`, `R2Bucket`) are non-generic at the class level; this may be the first multi-parameter generic class in the binding scope.

### 3. Discriminated-Union-Shaped TypeScript Types

**Anticipated symptom**: The Agents framework's lifecycle hook return types are tagged unions in TypeScript (e.g., `ToolCallDecision = void | { action: "allow" } | { action: "block"; reason?: string } | { action: "substitute"; output: unknown; input?: unknown }`). These are exactly what F# discriminated unions express, but Glutinum's default behavior generates them as `U2<...>` / `U3<...>` Fable interop types rather than F# DUs.

**Approach**: A new post-processor that recognizes string-literal-tagged union shapes in Glutinum output and rewrites them as F# DUs. The pattern is: `{ action: "allow" } | { action: "block"; reason?: string }` becomes:

```fsharp
type ToolCallDecision =
    | Allow
    | Block of reason: string option
    | Substitute of output: obj * input: obj option
```

This post-processor would also be useful for refactoring existing bindings where Glutinum's `U2<>`/`U3<>` output is awkward.

**Status**: New post-processor (`tagged-union-du.fsx` or similar) anticipated for 0.3.0.

### 4. Lifecycle Hook Method Overrides

**Anticipated symptom**: Cloudflare's Agent class exposes hooks as optional methods that subclasses override. The TypeScript `.d.ts` declares them as instance methods returning `T | Promise<T>`. F# binding ergonomics call for `abstract` methods on the base class with default no-op implementations, allowing F# subclasses to use `override` cleanly.

**Approach**: Verify Glutinum emits `abstract` methods with appropriate default implementations. If it does not, a post-processor adds the `abstract` keyword and provides default returns (`async { return None }` for `Async<TurnConfig option>` etc.).

**Status**: Investigation needed.

### 5. `unknown` and `Record<string, unknown>` Types

**Anticipated symptom**: Several Agent context types contain `unknown` typed fields (e.g., `body: Record<string, unknown>` in `TurnContext`). The schema-directed-narrowing approach documented in [Composer/docs/javascript-targeting/06_obj_and_null_at_the_boundary.md](../../Composer/docs/javascript-targeting/06_obj_and_null_at_the_boundary.md) prescribes mapping these to `JsValue` (the typed DU representation of JavaScript's value space) by default, with generic parameters where the binding can resolve them.

**Approach**: Glutinum's default for `unknown` is likely `obj`. A post-processor (or Glutinum configuration) maps `unknown` to `JsValue` and `Record<string, unknown>` to `Map<string, JsValue>` for these binding outputs specifically.

**Status**: New convention to apply during 0.3.0 binding work.

## Shared Challenges

### Reserved Keywords in Both Pipelines

Both tools face F# reserved keyword conflicts but resolve them through different mechanisms:

| Aspect | Glutinum (Runtime) | Hawaii (Management) |
|--------|-------------------|---------------------|
| Source truth | JavaScript property names | JSON property names |
| Ideal attribute | `[<CompiledName>]` | `[<JsonPropertyName>]` |
| Target compiler | Fable (JS interop) | Any (JSON serialization) |
| Current approach | Backtick escaping | Backtick escaping |

### Type Ordering Dependencies

F#'s top-down type system requires types to be declared before use. Both tools occasionally generate types in the wrong order. The runtime post-processor handles this for Glutinum output; Hawaii's output has not exhibited this issue with the current service set.

## Upstream Contribution Opportunities

1. **Hawaii**: Cumulative type name sanitization (hyphen + underscore handling)
2. **Hawaii**: Null-safe schema access in `createResponseType`
3. **Hawaii**: Native discriminator schema support (would eliminate the `discriminators.fsx` post-processor)
4. **Glutinum**: `[<CompiledName>]` attribute emission for reserved keywords
5. **Glutinum**: Record generation for pure data structures (currently generates interfaces)
6. **Glutinum**: TypeScript decorator metadata preservation in `.d.ts` parsing (would eliminate the anticipated `callable-attribute.fsx` post-processor for the Agents binding)
7. **Glutinum**: String-literal-tagged-union → F# discriminated union mapping (would eliminate the anticipated `tagged-union-du.fsx` post-processor)
8. **Glutinum**: Configurable `unknown` mapping (default to `JsValue` rather than `obj` for boundary types)
