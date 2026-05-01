# Fidelity.CloudEdge Gap Analysis & Service Maturity

**Last Updated**: May 2026

## Executive Summary

Fidelity.CloudEdge represents the F# binding surface for Cloudflare's Workers API and management plane. The 0.2.0 release (April 2026) shipped 40 account-scoped Management services and 2 cross-account Tenancy services generated from Cloudflare's OpenAPI spec via Hawaii, plus runtime binding targets (Worker.Context, AI, DurableObjects with Facets/Container/snapshots) generated from `@cloudflare/workers-types` via Glutinum. The framework ships as three NuGet packages (Runtime, Management, Tenancy) corresponding to three structural scopes in the Cloudflare API. The generation pipeline is config-driven through `services.json`, fully automated via bash scripts, and validated through structural tests (686 passing). A CI/CD workflow (`regenerate-bindings.yml`) handles weekly regeneration from upstream sources.

**This document is the coverage analysis** — it tracks how completely Fidelity.CloudEdge represents Cloudflare's primitive surface, where bindings are missing or stale, and what closes each gap. The framing is external (Cloudflare's API/management plane as the universe to cover) rather than internal (Fidelity's progress against a private roadmap). When Cloudflare ships a new primitive, this document records the gap; when Fidelity binds to it, the gap closes.

Following Cloudflare's Agents Week rollout (March–April 2026), the binding surface that Fidelity.CloudEdge needs to represent has expanded beyond OpenAPI Management services and `@cloudflare/workers-types`. Three additional npm packages now carry first-class Cloudflare value: `agents-sdk` (the Agent and Think classes, formerly `@cloudflare/agents`), `@cloudflare/dynamic-workflows` (multi-tenant workflow dispatch), and the Workflows V2 runtime additions to workers-types. These are tracked as new rows in the coverage matrix below. The 0.3.0 release scope is determined by what closes the highest-priority gaps in this matrix.

**Tooling pipeline change (May 2026):** Per [00 Decision 7](00_architecture_decisions.md), Fidelity.CloudEdge has standardized its TypeScript→F# binding generation on **Xantham**, replacing Glutinum as the runtime binding tool. This is tracked as gap **G6** below and sequences the closure of several existing concerns (the 9 service regressions in the Pipeline Improvements section, the hand-curated G3/G4 bindings, and the ~330 lines of compensatory pre/post-processing infrastructure documented in [06_tool_status.md](06_tool_status.md)). Hawaii (Management/Tenancy OpenAPI bindings) is unaffected.

## Service Maturity Status

### Generation Status Legend

- ✅ **Active**: Generating, compiling, and structurally validated
- 🔧 **Active + Post-Processing**: Generating with post-processor pipeline
- 🔄 **Active, refresh needed**: Generated but Cloudflare upstream has new endpoints/types since last regeneration
- 📋 **Planned**: Scaffolded in solution, Hawaii or Glutinum config exists, awaiting activation
- ❌ **Not Configured**: No generation infrastructure yet

### Management APIs (Hawaii-Generated)

| Service | Key | Status | Post-Processors | Notes |
|---------|-----|--------|-----------------|-------|
| D1 | `d1` | ✅ Active | None | |
| R2 | `r2` | ✅ Active | None | |
| KV | `kv` | ✅ Active | None | Previously blocked by Hawaii NullRef; resolved via `preprocess-openapi.sh` |
| Workers | `workers` | 🔧 Active | discriminators, jobject-multipart, missing-body-params | Most complex service; 29 binding type DU |
| Analytics | `analytics` | ✅ Active | None | |
| Logs | `logs` | ✅ Active | None | Required type alias patches for `logsharestart`/`logshareend` |
| Queues | `queues` | ✅ Active | None | Required DU type additions for `mqconsumer-response`, `mqproducer` |
| Vectorize | `vectorize` | ✅ Active | None | V2 API; required backtick escaping for `@`-prefixed DU patterns |
| Hyperdrive | `hyperdrive` | ✅ Active | None | |
| Durable Objects | `durable-objects` | ✅ Active | None | |
| Pages | `pages` | ✅ Active | None | Uses `pathPrefix` extraction |
| AI | `ai` | ✅ Active | None | |
| AI Gateway | `ai-gateway` | ✅ Active | None | |
| AI Search | `ai-search` | ✅ Active | None | |
| AutoRAG | `autorag` | ✅ Active | None | |
| Containers | `containers` | ✅ Active | None | |
| Workflows | `workflows` | 🔄 Active, refresh needed | None | V2 control plane shipped April 2026 (50k concurrent, SousChef/Gatekeeper); regenerate against current OpenAPI |
| Pipelines | `pipelines` | ✅ Active | None | |
| Browser Rendering | `browser-rendering` | ✅ Active | None | |
| Stream | `stream` | ✅ Active | None | |
| Images | `images` | ✅ Active | None | |
| R2 Catalog | `r2-catalog` | ✅ Active | None | |
| Secrets Store | `secrets-store` | ✅ Active | None | |
| Tunnels | `tunnels` | ✅ Active | None | |
| Access | `access` | ✅ Active | None | |
| Gateway | `gateway` | ✅ Active | None | |
| Email | `email` | ✅ Active | None | |
| Calls | `calls` | ✅ Active | None | |
| Builds | `builds` | ✅ Active | None | |
| Load Balancers | `load-balancers` | ✅ Active | None | |
| Waiting Rooms | `waiting-rooms` | ✅ Active | None | |
| Magic | `magic` | ✅ Active | None | |
| Mesh | `warp-connector` | ✅ Active | None | Cloudflare Mesh (formerly WARP Connector); namespace product-aligned, URL retains `warp_connector` |
| MoQ | `moq` | ✅ Active | None | Media over QUIC relays; operationId overrides applied for path-level duplicates |
| Security Center | `security-center` | ✅ Active | manual query param fix | Typed DU query params converted to string at boundary |
| Vuln Scanner | `vuln-scanner` | ✅ Active | spec preprocess (single-element oneOf flatten) | Hawaii crash on oneOf+discriminator with single element; preprocessed |
| Registrar | `registrar` | ✅ Active | None | |
| Resource Library | `resource-library` | ✅ Active | None | |
| Event Notifications | `event-notifications` | ✅ Active | None | R2-scoped event notifications |
| Event Subscriptions | `event-subscriptions` | ✅ Active | None | |

### Tenancy APIs (Hawaii-Generated, cross-account)

| Service | Key | Status | Post-Processors | Notes |
|---------|-----|--------|-----------------|-------|
| Tenants | `tenants` | ✅ Active | None | `/tenants/{tenant_id}/*` — above-account scope |
| Organizations | `organizations` | ✅ Active | None | `/organizations/*` and `/user/organizations` — cross-account administration |

### Runtime Bindings (Glutinum-Generated)

| Target | Source | Lines Generated | Status | Notes |
|--------|--------|----------------|--------|-------|
| Worker.Context | `@cloudflare/workers-types` (^4.20260417.1) | 17,876 | 🔄 Refresh needed | Latest is 4.20260429.1; refresh picks up Workflows V2 runtime types and any DO Facets refinements (e.g., per-Facet SQLite) |
| AI | `@cloudflare/ai` | ~1,200 | ✅ Active | |
| DurableObjects | `@cloudflare/workers-types` | (split from Worker.Context) | ✅ Active | Includes Facets, Container with egress interception, snapshot APIs from April 2026 Agents Week |

Existing runtime targets compile cleanly. The preprocessor detects and breaks cyclic interface references automatically.

### Higher-Level Cloudflare Packages (Glutinum-Generated)

These are first-class Cloudflare value carried in npm packages outside `workers-types`. They have first-class TypeScript surfaces that benefit from Glutinum binding generation just like the runtime types do. Coverage of these packages is part of representing Cloudflare's primitive surface in F#.

| Package | Source | Status | Notes |
|---------|--------|--------|-------|
| `@cloudflare/agents` | npm; Cloudflare's Agents framework | 📋 Planned (0.3.0 target) | `Agent<Env, State>` base class, `Think<Env>` chat agent subclass, lifecycle hooks (`onConnect`, `onMessage`, `onRequest`, plus Think's chat hooks `configureSession`, `beforeTurn`, `beforeStep`, `beforeToolCall`, etc.), `@callable()` RPC decorator, `setState`/`initialState`, `useAgent` client hook |
| `@cloudflare/dynamic-workflows` | npm; published May 1, 2026 | 📋 Planned (0.3.0 target) | `createDynamicWorkflowEntrypoint`, `wrapWorkflowBinding`, `dispatchWorkflow`, `DynamicWorkflowBinding` for multi-tenant workflow dispatch |

## Pipeline Infrastructure

| Component | Status | Notes |
|-----------|--------|-------|
| `services.json` registry | ✅ | 40 services configured |
| OpenAPI spec extraction | ✅ | `jq`-based, supports `pathPatterns` and `pathPrefix` |
| OpenAPI preprocessing | ✅ | Fixes Hawaii NullRef on empty schema entries |
| TypeScript preprocessing | ✅ | Cycle breaking, intersection simplification |
| Hawaii generation | ✅ | 40 services passing |
| Glutinum generation | ✅ | 2 targets passing |
| Post-processor framework | ✅ | 3 parameterized post-processors, config-driven |
| Project scaffolding | ✅ | Automated `.fsproj` creation and solution integration |
| Structural validation | ✅ | 686 tests passing (Expecto) |
| CI/CD regeneration | ✅ | Weekly schedule + manual dispatch, automated PR creation |

## Coverage Gaps

The gaps below are organized by impact on Cloudflare-surface representation. Each gap names a specific piece of Cloudflare's primitive set and the binding work that would close it. Internal tooling concerns (version pegging, post-generation patches, test coverage) appear in the second list as "Pipeline Improvements" and are tracked separately because they affect generation quality but not coverage breadth.

### Cloudflare-Surface Coverage Gaps (0.3.0 targets)

**G1. Workers-types refresh (workers-types 4.20260417.1 → 4.20260429.1)**

The pinned `@cloudflare/workers-types` version is 12 days behind upstream. The latest release contains Workflows V2 runtime types and likely refinements to DO Facets (per-Facet SQLite, etc.). Closing this gap is mechanical: bump the pin, regenerate Worker.Context and DurableObjects, validate.

**G2. Workflows V2 OpenAPI refresh**

The Workflows service binding was generated against pre-V2 OpenAPI. Cloudflare's V2 control plane (announced April 2026, supporting 50k concurrent instances per workflow with SousChef + Gatekeeper distribution) introduces new management endpoints and likely shape changes to existing ones. The Workers/Workers-for-Platforms secrets APIs are also now properly documented in the spec where they previously were not. Re-pulling the OpenAPI spec and regenerating the Workflows service (and any other services with newly documented endpoints) closes this gap.

**G3. `@cloudflare/agents` package binding**

The Agents framework (Agent base class, Think chat subclass, lifecycle hooks, `@callable()` RPC decorator, `setState`/`initialState` state-sync, `useAgent` client hook) is the centerpiece of Cloudflare's agentic-workload story. Currently unbound in F#. This is a Glutinum binding target with some unique requirements: TypeScript decorators (`@callable()`) need mapping to F# attributes; generic class declarations (`Agent<Env, State>`) need Glutinum support; the chat-specific Think hooks need typed F# discriminated unions for the decision types (`ToolCallDecision` etc., per [08f_agents_overlay_design.md](08f_agents_overlay_design.md)).

**G4. `@cloudflare/dynamic-workflows` package binding**

Multi-tenant workflow dispatch (`createDynamicWorkflowEntrypoint`, `wrapWorkflowBinding`, `dispatchWorkflow`, `DurableWorkflowBinding`). Roughly 300 lines of TypeScript on the Cloudflare side. Glutinum binding target. The use case is platforms that route workflow execution to per-tenant code at runtime — a pattern that previously had to be hand-rolled in any non-Cloudflare stack.

**G6. TypeScript→F# generation pipeline standardization on Xantham (cross-cutting)**

Per [00 Decision 7](00_architecture_decisions.md), Fidelity.CloudEdge is migrating its runtime TypeScript→F# binding generation from Glutinum to Xantham. The foundational analysis comparing the two tools and their architectural fit is in [12_xantham_glutinum_replacement_assessment.md](12_xantham_glutinum_replacement_assessment.md). This is a tooling-pipeline gap rather than a Cloudflare-surface gap, but it materially affects how every other runtime binding gap is closed and how prior compensations (~330 lines of pre/post-processing across 3 languages) are retired.

**Migration sequence (5 ordered steps):**

1. **Land upstream `collectAllRecursively` fix** in Xantham (PR in flight as of May 2026). Fix is local-validated; produces 18,573 lines of F# from `@cloudflare/workers-types` where unfixed Xantham stack-overflowed.
2. **Resolve renderer issues 2-5** ([06_tool_status.md §"Xantham: Capabilities, Architecture, and Tracked Issues"](06_tool_status.md)): empty interface emission, generic constraint syntax, doubled inheritance brackets, brand-symbol substitution. Each is localized to one render module; combined they unblock compilable workers-types output.
3. **Replace hand-curated `Fidelity.CloudEdge.Agents/Types.fs` and `Fidelity.CloudEdge.DynamicWorkflows/Types.fs`** with Xantham-generated output. These were hand-curated in 0.3.0 because Glutinum crashed on the agents-sdk and dynamic-workflows surfaces; Xantham handles both. This step validates the Xantham pipeline against application-consumed bindings.
4. **Migrate `Fidelity.CloudEdge.Worker.Context/Generated.fs` and `Fidelity.CloudEdge.AI/Generated.fs`** from Glutinum to Xantham. Retire `preprocess-typescript.js`, `postprocess-runtime.sh`, and the Glutinum-specific entries in [06_tool_status.md](06_tool_status.md).
5. **Remove Glutinum dependencies**: `@glutinum/cli` from npm, `Glutinum.Types` NuGet package from project files. Update CI/CD to use the Xantham extractor + generator pipeline.

**Status:** Step 1 in flight (PR pending). The other steps are sequenced; each unblocks the next.

**Why this matters:** The 9-service regression patterns documented in the Pipeline Improvements section below are dominated by Glutinum-side issues that Xantham addresses structurally (`[<CompiledName>]` attributes for reserved keywords, cycle handling without preprocessing, namespace and import generation). Closing G6 reduces the surface area for future regression patterns and retires compensatory infrastructure that's been growing rather than shrinking with each Cloudflare spec evolution.

---

**G5. Dynamic Workers management endpoints — NOT EXPOSED IN OPENAPI**

Investigation result (May 2026): a scan of the current Cloudflare OpenAPI spec (`https://raw.githubusercontent.com/cloudflare/api-schemas/main/openapi.json`, 1838 paths total) found no `dynamic-workers` paths and no isolate-management endpoints. The Dynamic Workers product (open beta on Workers Paid plan since March 24, 2026) is configured through wrangler.jsonc directives and the new `cf` unified CLI rather than through REST APIs. There is no management binding to add for this gap — the gap is intentionally outside the OpenAPI surface.

The closest related surface that *is* in OpenAPI is Workers-for-Platforms dispatch namespaces (`/accounts/{account_id}/workers/dispatch/namespaces/...`) — these are tenant-isolated Worker script management and were already covered by the existing Workers binding. The Workers script secrets endpoints (newly documented in the spec) are also covered by the Workers binding's regeneration in G2.

**Status:** G5 closed as "no new binding needed; existing Workers binding covers adjacent W4P and secrets surface."

### Pipeline Improvements (orthogonal to coverage)

These gaps affect generation quality but do not change which Cloudflare primitives Fidelity represents.

**P1. Test Coverage**

Structural tests verify that generated types and client methods exist. Missing: integration tests that exercise the generated clients against the Cloudflare API, serialization round-trip tests, and Fable compilation validation.

**P2. Version Pegging**

No mechanism currently locks generated output to specific upstream versions. The CI/CD workflow regenerates from latest, but there is no diff analysis or breaking change detection. A version manifest tracking the OpenAPI spec hash and `workers-types` version per generation run would close this gap.

**P3. Post-Generation Patches**

Five services (KV, Workers, Logs, Queues, Vectorize) required manual compilation fixes after Hawaii generation. These patches are applied once and persist, but will need reapplication if the services are regenerated. Encoding these as additional post-processors would make regeneration fully automated.

**P4. Fable Compilation Validation**

Management APIs are designed to compile via Fable for browser-based tooling. The current validation only runs `dotnet build`. Adding a Fable compilation step to the CI pipeline would catch portability regressions.

**P5. Browser Standard APIs (Runtime)**

Streams, Cache, and WebCrypto APIs are available in `workers-types` but do not have dedicated CloudEdge projects. These are covered by the monolithic `Worker.Context/Generated.fs` binding; dedicated typed wrappers would improve ergonomics.

**P6. Sample Application Coverage**

HelloWorker and SecureChat demonstrate basic usage. Additional samples targeting Queues, Vectorize, Hyperdrive, Durable Objects, Agents, and Dynamic Workflows would validate the generated bindings in realistic scenarios.

## Coverage Metrics

| Metric | Current (0.2.0) | 0.3.0 Target |
|--------|-----------------|--------------|
| Management services bound (OpenAPI) | 40 / 40 known | 40+ (Workflows V2 refresh; Dynamic Workers if exposed) |
| Tenancy services bound (OpenAPI, cross-account) | 2 / 2 known | 2 / 2 |
| Runtime binding targets (workers-types) | 2 active (Worker.Context, AI) + DurableObjects | 2 active (refreshed to 4.20260429.1+) + DurableObjects |
| Higher-level Cloudflare packages bound | 0 / 2 | 2 / 2 (`@cloudflare/agents`, `@cloudflare/dynamic-workflows`) |
| Workflows control plane | V1 (pre-April-2026) | V2 (April 2026 SousChef/Gatekeeper architecture) |
| DO Facets surface | Basic (per 0.2.0) | Refreshed (per-Facet SQLite refinements) |

## Pipeline Quality Metrics

| Metric | Current | Target |
|--------|---------|--------|
| Post-generation manual patches | 5 services | 0 (automated) |
| Structural test assertions | 686 passing | Expand per service |
| Integration tests | 0 | Per active service |
| CI/CD regeneration | Weekly | Weekly + on upstream release |
| Version pegging | None | Per-generation manifest |
