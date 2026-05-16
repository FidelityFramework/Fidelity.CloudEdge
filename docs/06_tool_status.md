# Fidelity.CloudEdge Tool Status & Known Limitations

**Last Updated**: May 2026

This document tracks the binding generation tools used by Fidelity.CloudEdge.

> **Strategic direction (per [00 Decision 7](00_architecture_decisions.md)):** Fidelity.CloudEdge has standardized its TypeScript→F# binding generation on **Xantham**. **Glutinum is being phased out** for runtime bindings; the migration is incremental and tracked in [03_gap_analysis.md](03_gap_analysis.md). The Glutinum-specific limitations and mitigations documented in this file are **legacy concerns** — they will be retired as each runtime binding migrates to Xantham. New runtime bindings target Xantham directly. Hawaii (for Management/Tenancy OpenAPI bindings) is unaffected and continues as the standard path for those tiers.

For the original detailed analysis (Glutinum v0.12.0, Hawaii v0.66.0), see `_archived/06_tool_improvement_analysis_v1.md`.

## Tool Versions

| Tool | Version | Role | Status |
|------|---------|------|--------|
| **Xantham CLI** | npm `xantham` (extractor) + .NET `Xantham.Generator` (renderer) | TypeScript `.d.ts` → F# binding generation (forward-going) | **Standard** for new runtime bindings; migration target for existing |
| Hawaii | 0.66.0 | OpenAPI → F# client generation | Standard for Management/Tenancy tiers; unaffected by the Glutinum→Xantham migration |
| Glutinum CLI | 0.13.0 (npx) | TypeScript `.d.ts` → F# binding generation (legacy) | **Deprecated path**; retained for existing `Worker.Context` and `AI` bindings until they migrate to Xantham |

## Binding Inputs

The generation pipeline consumes Cloudflare specifications across two tracks — OpenAPI for the Management/Tenancy tiers, and the Cloudflare intelligent-edge npm SDK suite for the Runtime tier. The npm suite is the substantive AI/agentic scope of Fidelity.CloudEdge and is on par with the workers-types foundation, not a side surface.

| Input | Source | Current Tool | Migration Target | Output |
|-------|--------|--------------|------------------|--------|
| Cloudflare OpenAPI | `https://github.com/cloudflare/api-schemas` | Hawaii | Hawaii (no change) | 40 Management + 2 Tenancy services |
| `@cloudflare/workers-types` | npm; `cloudflare/workerd` | Glutinum | **Xantham** (migration pending) | Worker.Context, AI, DurableObjects |
| `agents` (formerly `@cloudflare/agents` / `agents-sdk`) | npm; `cloudflare/agents` monorepo | hand-curated `Types.fs` (Glutinum crashes on this surface) | **Xantham** | Agent base class, lifecycle hooks, Schedule, Callable attribute |
| `@cloudflare/ai-chat` | npm; `cloudflare/agents` monorepo (sibling) | not yet ingested | **Xantham** | Persistent chat, resumable streaming, tool execution (React-coupled exports filtered) |
| `@cloudflare/voice` | npm; `cloudflare/agents` monorepo (sibling) | not yet ingested | **Xantham** | STT/TTS/VAD/SFU, `VoiceClient`, server mixins (React hooks filtered) |
| `@cloudflare/think` | npm; `cloudflare/agents` monorepo (sibling) | not yet ingested | **Xantham** | Opinionated agentic loop, stream resumption, `submitMessages()` |
| `@cloudflare/codemode` | npm; `cloudflare/agents` monorepo (sibling) | not yet ingested | **Xantham** | LLM-generated TypeScript orchestrating tool calls in a sandbox |
| `@cloudflare/shell` | npm; `cloudflare/agents` monorepo (sibling) | not yet ingested | **Xantham** | Sandboxed JS execution, virtual filesystem, git ops |
| `@cloudflare/worker-bundler` | npm; `cloudflare/agents` monorepo (sibling) | not yet ingested | **Xantham** | Runtime Worker bundling for Worker Loader binding |
| `@cloudflare/dynamic-workflows` | npm; `cloudflare/dynamic-workflows` | hand-curated `Types.fs` | **Xantham** | DynamicWorkflowBinding, dispatchWorkflow, wrapWorkflowBinding |
| `@cloudflare/containers` | npm; `cloudflare/containers` | not yet ingested | **Xantham** | Container-enabled DO helper |
| `@cloudflare/sandbox` | npm; `cloudflare/sandbox-sdk` | not yet ingested | **Xantham** | Sandboxed command execution |
| `@cloudflare/puppeteer` | npm; `cloudflare/puppeteer` | not yet ingested | **Xantham** | Puppeteer-API-compatible control over the Workers Browser-Rendering binding — fetch JS-driven pages, capture DOM snapshots, take screenshots, and extract content as tool calls from an agent. Load-bearing for agentic info-gathering on the open web |

Two packages from Cloudflare's npm landscape are deliberately **excluded** from xantham ingestion:

- **`cloudflare` (unscoped)** — Cloudflare's official TypeScript control-plane API client. It covers the same REST endpoints (`api.cloudflare.com`) that Hawaii already binds from the OpenAPI spec into `Fidelity.CloudEdge.Management.*`. Carrying it as a duplicate xantham target would double the maintenance surface for zero new capability. If TS-client-style ergonomics over the Management bindings ever become desirable, that's a thin hand-curated layer atop Hawaii output — not a parallel ingestion.
- **`hono-agents`** — Fidelity provides its own F#-native web framework occupying the same conceptual slot as Hono, so the Hono-specific integration layer carries no value into the F# surface.

The npm SDK ingestion gates are governed by the per-publisher provenance policy in [13_supply_chain_audit.md](13_supply_chain_audit.md). Eleven of the twelve direct dependencies in the suite carry the supply-chain embargo lift on the strength of SLSA v1 provenance from Cloudflare's GitHub org (`314135`). `@cloudflare/puppeteer` is the one Cloudflare-published direct dependency whose publisher hasn't enabled npm trusted-publishing yet, so its ingestion stays under the default 72-hour audit policy on every bump — that's an audit treatment, not a scope decision; its substantive role in the agentic surface is on par with the rest. (Total = 12: `workers-types` + 7 from the agents monorepo + `dynamic-workflows` + `containers` + `sandbox` + `puppeteer`.)

## Xantham: Capabilities, Architecture, and Tracked Issues

Xantham is a hard fork of Glutinum that decomposes the TypeScript→F# pipeline into three phases:

1. **Extract** (`xantham` npm package, Fable-compiled). Crawls the TypeScript Compiler API across the entire reachable type graph (multi-file, recursive) and produces a JSON schema describing every type, with a `TypeKey` indirection system for cycle handling.
2. **Decode** (`Xantham.Decoder` .NET library). Deserializes the JSON schema into a richer F# graph (`ResolvedType`, lazy containers, arena interner) for downstream consumption.
3. **Generate** (`Xantham.Generator` .NET project). Renders F# bindings via Fabulous.AST + Fantomas SyntaxOak. Runs on .NET (not Fable), with full F# AST control.

The decoder is reusable independently — any consumer can take a dependency on `Xantham.Decoder` and bypass the standard generator if framework-specific output is wanted. This is the architectural property that makes Xantham a long-term standard rather than a like-for-like Glutinum replacement.

### Capabilities Xantham Has That Glutinum Does Not

| Capability | Glutinum | Xantham |
|:-----------|:---------|:--------|
| `[<CompiledName>]` attributes for reserved keywords | Backtick-escaped identifiers (degraded ergonomics) | Native attribute emission |
| Cyclic type references | Stack overflow / partial output | TypeKey indirection at the schema layer; visit-set guards in renderer (post-fix) |
| Multi-file type graphs | Single `.d.ts` entry only | Recursively crawls all referenced files |
| Generated `import` statements | Not emitted; wired by hand | Generated automatically with full provenance tracking |
| Module nesting from package structure | Flat output | Hierarchical module tree from the type graph |
| Output customization | Built-in single format | User-defined strategy (string concat, Fabulous.AST, etc.) |
| TypeScript compiler swap-ability | Coupled to Fable.TypeScript | Encoder is replaceable (e.g., TSGO migration); decoders/generators unchanged |

### Known Issues (as of May 3, 2026)

> **Three of the five bugs below were closed on `speakez-xantham` master by Shayan Habibi on May 3, 2026.** The Bug 3 fix matches the [docs/12 §9.4](12_xantham_glutinum_replacement_assessment.md) prescription line-for-line, confirming the Fabulous.AST analysis (no fork required). Bugs 2 and 4 remain open with concrete fix paths and test specifications in [docs/12 §9.7 and §9.8](12_xantham_glutinum_replacement_assessment.md).

**1. `collectAllRecursively` stack overflow on cyclic graphs (CLOSED on master)**

Closed via `a4ee905` "fix: prevent infinite recursion in collect all members" — `HashSet<ResolvedType>` guard in `Render.Member.fs`. Functionally equivalent to the visited-set fix that Fidelity.CloudEdge developed locally on a `fix-collect-all-recursively-stack-overflow` branch (which keyed on `TypeKey` rather than `ResolvedType`). The local branch is now redundant.

Test gap: no dedicated cyclic-fixture regression test landed alongside the fix. A `tests/Xantham.Fable.Tests/TypeFiles/cyclic-interfaces.d.ts` fixture would lock the protection in place against future refactors.

**2. Empty interface emission (OPEN)**

`type IPartyserver =` with no body. F# requires `interface end` or members. Xantham emits the type header without a body marker for some empty top-level types. Fix path with test fixture and assertions in [docs/12 §9.7](12_xantham_glutinum_replacement_assessment.md). Lives in `renderInterface` dispatch in `TypeRender.Render.fs:547-575`.

**3. Generic constraint syntax (CLOSED on master)**

Closed via `2e3433e` "fix: type parameters render using Ast.TyparDecl & Ast.SubtypeOf and Ast.PostfixList instead of Ast.TyparDecl into Ast.PostfixList directly". The implementation matches the [docs/12 §9.4](12_xantham_glutinum_replacement_assessment.md) prescription line-for-line: same `(TyparDecl, TypeConstraint voption)` restructure, same `Ast.PostfixList(decls, constraints)` composition applied to the three call sites in `renderInterface`, `renderClass`, `renderTypeAlias`. Adds a `renderTypeWithConstraint` helper for type signatures.

Test gap: no explicit generator-side regression test landed alongside the fix. A small assertion checking `<'T when 'T :> Foo>` output for a constrained type parameter would lock the prescription in place.

**4. Doubled generic brackets in `inherit` clauses (OPEN)**

```fsharp
inherit Partyserver.Server<'Env, 'Agent><'Env>
```

Heritage rendering double-applies type arguments. Should be `inherit Partyserver.Server<'Env, 'Agent>`. Fix path with test fixture and assertions in [docs/12 §9.8](12_xantham_glutinum_replacement_assessment.md). Likely lives in `TypeRefRender.Render.fs` `renderMolecule.Prefix` or in the heritage extraction layer that produces the `TypeRefRender` passed to `renderInheritance`.

**5. Brand-symbol type substitution (CLOSED on master)**

Closed via `45cb34d` "fix: literal typenode provides typekey for literal token node resolution". Modifies `LiteralTokenNode.fs` and `TypeNode.fs`. The fix matches Shayan's "literal node vs literal typenode for TypeKey extraction" description — getting the typekey from the literal typenode (correct) instead of the literal token node (the syntactic node, wrong). Shipped with a 963-line three.js test fixture at `tests/Xantham.Fable.Tests/TypeFiles/packages/three/constants.d.ts` — three.js was the original surface where the bug was identified. Test coverage is tight; further `__*_BRAND` patterns from workers-types could be added during Phase D if regressions are observed.

### Bugs 2 and 4 are localized renderer bugs

Each of the two open bugs lives in a specific render module (`TypeRender.Render.fs` and `TypeRefRender.Render.fs`) and is materially smaller than the compensations Glutinum requires. Each has a concrete fix path with a test fixture proposed in [docs/12 §9.7-§9.8](12_xantham_glutinum_replacement_assessment.md).

### Migration Status

| Target | Current State | Migration Target | Blocker (May 3, 2026) |
|:-------|:--------------|:-----------------|:----------------------|
| `Fidelity.CloudEdge.Worker.Context` | Glutinum + hand-curated `Types.fs` | Xantham + retained `Types.fs` | Bug 4 (doubled inheritance brackets) — exercised by workers-types deep class hierarchies. Bug 2 (empty interface) — likely also in workers-types surface. Bugs 1/3/5 closed on master. |
| `Fidelity.CloudEdge.AI` | Glutinum | Xantham | Same as Worker.Context (workers-types-adjacent surface) |
| `Fidelity.CloudEdge.Agents` | Hand-curated only (Glutinum crashed) | Xantham | Bug 4 (Agent extends DurableObject<Env> exercises the heritage doubling shape). Bug 3 closed on master removes the original blocker. |
| `Fidelity.CloudEdge.DynamicWorkflows` | Hand-curated only | Xantham | No known blockers. Phase B validation candidate — small clean surface to confirm Bugs 1/3/5 fixes hold up end-to-end. |

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

## Glutinum: Known Limitations & Mitigations (Legacy — Migration to Xantham in Progress)

> The Glutinum-specific issues below are documented for the existing `Worker.Context` and `AI` runtime bindings that have not yet migrated to Xantham. Per [00 Decision 7](00_architecture_decisions.md), these compensations are not extended to new runtime bindings; new bindings target Xantham. The cyclic-interface preprocessor, the post-processor sed fixes, and the missing `[<CompiledName>]` attributes documented here all become unnecessary once a binding migrates to Xantham. **Do not invest further work in these mitigations.** Issues encountered with Glutinum during the remaining lifetime of these bindings should be resolved by accelerating the migration of the affected target rather than by patching Glutinum behavior.

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

## Glutinum: Anticipated Considerations for Agents Binding (Obsoleted by Xantham Migration)

> **Obsoleted as of [00 Decision 7](00_architecture_decisions.md).** This section was written before the standardization on Xantham. The five anticipated Glutinum considerations below — TypeScript decorator handling, generic class declarations, tagged-union-to-DU mapping, lifecycle hook abstract methods, `unknown`/`JsValue` convention — are all addressed structurally by Xantham's architecture or are localized renderer concerns rather than fundamental tooling limitations. The 0.3.0 release shipped `Fidelity.CloudEdge.Agents` and `Fidelity.CloudEdge.DynamicWorkflows` as hand-curated `Types.fs` files (Glutinum crashed on the agents-sdk and dynamic-workflows surfaces) and these will be replaced by Xantham-generated output once the renderer issues 2-5 above are resolved. The text below is retained for reference but should not drive new work.

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

### Hawaii (active investments)

1. **Hawaii**: Cumulative type name sanitization (hyphen + underscore handling)
2. **Hawaii**: Null-safe schema access in `createResponseType`
3. **Hawaii**: Native discriminator schema support (would eliminate the `discriminators.fsx` post-processor)

### Xantham (active investments — replacing Glutinum)

4. **Xantham**: `collectAllRecursively` stack overflow on cyclic graphs — fix prepared, PR pending
5. **Xantham**: Empty interface emission (`type X =` with no body marker)
6. **Xantham**: Generic constraint syntax for type parameter constraints (`<'T Constraint>` → `<'T when 'T :> Constraint>`)
7. **Xantham**: Doubled generic brackets in `inherit` clauses
8. **Xantham**: Brand-symbol substitution in workers-types

### Glutinum (no longer pursued)

The Glutinum upstream improvements previously listed (`[<CompiledName>]` attribute emission, record-vs-interface for pure data, decorator metadata, tagged-union-to-DU, `unknown` mapping) are no longer Fidelity.CloudEdge investment areas. These are all addressed structurally by Xantham's architecture; the migration delivers them without upstream contributions to Glutinum.
