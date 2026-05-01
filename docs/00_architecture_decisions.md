# Fidelity.CloudEdge Architecture Decisions

## Executive Summary

Fidelity.CloudEdge implements a **dual-layer architecture** that separates Runtime APIs (in-Worker JavaScript interop) from Management APIs (external REST operations), providing complete type-safe F# coverage of the Cloudflare platform.

## Current Implementation Status

### ✅ Completed Runtime Bindings (Layer 1)
- **Fidelity.CloudEdge.Worker.Context**: Core Worker types (Request, Response, Headers)
- **Fidelity.CloudEdge.KV**: Key-Value storage operations
- **Fidelity.CloudEdge.R2**: Object storage operations
- **Fidelity.CloudEdge.D1**: Database query operations
- **Fidelity.CloudEdge.AI**: Workers AI service bindings

### ✅ Completed Management APIs (Layer 2)
- **Fidelity.CloudEdge.Management.Workers**: Worker deployment and configuration (Hawaii-generated with post-processing)
- **Fidelity.CloudEdge.Management.R2**: R2 bucket management (Hawaii-generated)
- **Fidelity.CloudEdge.Management.D1**: D1 database management (Hawaii-generated)
- **Fidelity.CloudEdge.Management.Analytics**: Analytics API (Hawaii-generated)
- **Fidelity.CloudEdge.Management.Queues**: Queue management (Hawaii-generated)
- **Fidelity.CloudEdge.Management.Vectorize**: Vector index management V2 (Hawaii-generated)
- **Fidelity.CloudEdge.Management.Hyperdrive**: Connection config management (Hawaii-generated)
- **Fidelity.CloudEdge.Management.DurableObjects**: Namespace management (Hawaii-generated)

### ✅ Also Completed
- **Fidelity.CloudEdge.Management.KV**: KV namespace management (Hawaii NullRef resolved via OpenAPI preprocessing)
- **Fidelity.CloudEdge.Management.Logs**: Logs API
- **Fidelity.CloudEdge.Management.Pages**: Pages deployment management

## The Two-Layer Architecture

### Layer 1: Runtime APIs (JavaScript Interop)

**Purpose**: In-Worker APIs that execute inside the V8 isolate
**Source**: TypeScript definitions from `@cloudflare/workers-types`
**Generation**: Glutinum (TypeScript → F#) or manual bindings
**Location**: `src/Runtime/`

```fsharp
// Runs INSIDE a Worker
type D1Database =
    abstract member prepare: query: string -> D1PreparedStatement
    abstract member batch: statements: ResizeArray<D1PreparedStatement> -> JS.Promise<ResizeArray<D1Result>>
```

### Layer 2: Management APIs (REST/HTTP)

**Purpose**: External APIs for infrastructure provisioning and management
**Source**: Cloudflare OpenAPI specifications
**Generation**: Hawaii (OpenAPI → F#)
**Location**: `src/Management/`

```fsharp
// Runs OUTSIDE Workers (any platform: browser, native, or .NET)
type D1ManagementClient =
    member this.CreateDatabase: accountId: string * name: string ->
        Async<Result<D1Database, ApiError>>
    member this.ListDatabases: accountId: string ->
        Async<Result<D1DatabaseList, ApiError>>
```

## Key Architectural Decisions

### Decision 1: Three-Tier Package Architecture ✅

**Rationale**: The Cloudflare API has three structurally distinct path scopes that correspond to three distinct audiences. Each tier gets its own top-level package so consumers install only what their use case requires.

| Tier | Path scope | Audience | Package |
|------|-----------|----------|---------|
| **Runtime** | In-Worker JavaScript interop (no path) | Worker developers | `Fidelity.CloudEdge.Runtime` |
| **Management** | `/accounts/{account_id}/*` — account-scoped | Developers operating their own Cloudflare account | `Fidelity.CloudEdge.Management` |
| **Tenancy** | `/tenants/{tenant_id}/*`, `/organizations/*`, `/user/organizations` — above-account | MSPs, platform teams, multi-account operators | `Fidelity.CloudEdge.Tenancy` |

The three tiers differ in execution context, protocol, authentication, and audience:

| Aspect | Runtime | Management | Tenancy |
|--------|---------|------------|---------|
| Execution Context | Inside Worker (V8) | External (any platform) | External (any platform) |
| Protocol | JavaScript interop | HTTP/REST | HTTP/REST |
| Authentication | Worker bindings | Account-scoped API token | Tenant/org-scoped API token |
| Latency | Microseconds | Network RTT | Network RTT |
| Use Case | In-Worker data operations | Account resource management | Cross-account tenant management |
| Typical consumer | Individual developer | Individual or team | Managed service provider (MSP), platform team |
| Compilation | Fable only | Fable, Fidelity, or .NET | Fable, Fidelity, or .NET |

**Why Tenancy is a separate package, not a Management namespace**: An individual developer shipping a Worker has no reason to install tenant management code. An MSP managing 50 customer accounts has tenant management as their primary surface. Keeping these concerns in separate NuGet packages makes the dependency graph reflect the actual usage pattern — and keeps the Management package's install footprint unchanged for the common case.

**Why three tiers, not more**: The `Fidelity.CloudEdge.Runtime` / `Management` / `Tenancy` split reflects the actual structural boundaries in the Cloudflare API. Further subdivision (e.g., splitting Management by domain — Storage, Networking, AI, etc.) would be organizational taste, not a reflection of API structure. The framework keeps the package boundaries aligned with API-level distinctions.

### Decision 2: Use Hawaii for OpenAPI Generation ✅

**Rationale**: Hawaii provides idiomatic F# client generation from OpenAPI specs.

**Implementation**:
1. Segment the Cloudflare OpenAPI spec (~8.3MB) into service-specific chunks
2. Generate F# clients using Hawaii
3. Organize in parallel structure to Runtime APIs

### Decision 3: Project Organization by Service ✅

**Rationale**: Each Cloudflare service gets its own project for better modularity. Projects are grouped into three top-level folders matching the three-tier architecture.

```
Fidelity.CloudEdge/
├── src/
│   ├── Runtime/                    # In-Worker APIs
│   │   ├── CloudEdge.Worker.Context/
│   │   ├── CloudEdge.D1/
│   │   ├── CloudEdge.R2/
│   │   ├── CloudEdge.KV/
│   │   ├── CloudEdge.DurableObjects/
│   │   └── CloudEdge.AI/
│   │
│   ├── Management/                 # Account-scoped REST APIs
│   │   ├── CloudEdge.Management.D1/
│   │   ├── CloudEdge.Management.R2/
│   │   ├── CloudEdge.Management.KV/
│   │   ├── CloudEdge.Management.MoQ/
│   │   ├── CloudEdge.Management.Mesh/
│   │   └── ...
│   │
│   └── Tenancy/                    # Cross-account / tenant-level REST APIs
│       ├── CloudEdge.Tenancy.Tenants/
│       └── CloudEdge.Tenancy.Organizations/
```

The folder structure mirrors the NuGet package structure. Each tier ships as an independent NuGet package so a consumer's dependency graph reflects which tiers their code actually uses.

### Decision 4: Pure F# Portability for Management APIs ✅

**Rationale**: Management APIs must be compilable via multiple F# toolchains for maximum portability.

**Principle**: Use only F#-native constructs to enable:
- **Fable**: Compile to JavaScript (browser-based management tools)
- **Fidelity**: Compile to native via MLIR/LLVM (zero runtime dependencies)
- **.NET**: Traditional compilation as fallback option

**Implementation Requirements**:
- Use `async { }` computational expressions, NOT `Task<T>`
- Return `Async<Result<'T, 'Error>>` for all operations
- No System.Net.Http or other .NET-specific types
- Pure functional error handling (Result/Option types)
- Immutable records and discriminated unions only

```fsharp
// ✅ CORRECT: Pure F# that compiles everywhere
type D1ManagementClient =
    member this.CreateDatabase: accountId: string * name: string ->
        Async<Result<D1Database, ApiError>>

// ❌ WRONG: .NET-specific, won't compile with Fable/Fidelity
type D1ManagementClient =
    member this.CreateDatabase: accountId: string * name: string ->
        Task<CloudFlareResult<D1Database>>  // Uses Task and custom .NET types
```

**Contrast with Other Libraries**:
- CloudFlare.Client (C#) uses `Task<T>` - locked to .NET only
- Fidelity.CloudEdge uses `async { }` - portable to any target

### Decision 5: OpenAPI Segmentation Pipeline ✅

**Problem**: Cloudflare's OpenAPI spec is ~8.3MB, causing tool failures when processed as a whole.

**Solution**: `jq`-based extraction (`extract-service.sh`) driven by `services.json` path patterns that:
1. Parses the full OpenAPI spec
2. Extracts service-specific paths and schemas
3. Creates focused specs (45KB - 217KB each)
4. Preserves all dependencies and references

### Decision 6: Library Extension via PSG Codata ✅

**Commitment**: Library contributions to compilation flow through the PSG codata channel. Libraries attach annotations to nodes, the middle-end interprets those annotations during elaboration, and target back-ends consume the annotated IR at synthesis.

**Rationale**: Composer's verification chain (DTS dimensional types, DMM coeffect classification, PHG grade inference) is decidable-by-construction because every property that informs compilation is represented as codata attached to PSG nodes. Dimensional annotations, coeffect classifications, and escape annotations already ride this channel. Library-contributed pattern declarations and synthesis schemas ride the same channel with the same structural properties. The framework's central thesis ([decidable-by-construction](../arxiv/2603.25414)) rests on the codata channel being the uniform extension surface for compilation-relevant information.

**Mechanism**: Codata has five structural properties that make it a sound extension surface:

- Codata attaches to nodes, preserving graph structure
- Codata is consumed by passes, leaving pass definitions in compiler control
- Codata is structure-preserving under transformation
- Codata composition is accumulation — multiple sources merge by union
- Codata constraints (decidable, structure-preserving, finite) preserve the verification chain across library contributions

**Layer 3 library contributions**: A Layer 3 library (e.g., a future `Fidelity.Platform.Edge.Cloudflare`) contributes:

- **Pattern signature declarations** — markers like `[<RecognizedPattern("Actor")>]` that the compiler recognizes during elaboration
- **Synthesis schemas** — declarative templates for infrastructure artifacts emitted per pattern per target
- **Type definitions for standard patterns** — base classes, marker interfaces, attribute conventions
- **Default implementations** — inheritable or composable by target code
- **BAREWire schema bundles** — shared types across substrates

These contributions are source code whose compilation-facing role is declarative. The compiler reads what the library declares; the library itself executes as user code, not as compiler internals.

**Where the boundary sits**: Pass implementations, verification rules, IR manipulation, and code generation are compiler-owned. This is where the decidability guarantees are established and enforced. Library contributions end at declaration; transformation begins at the compiler.

**Operational consequences**:

- High-frequency churn — Cloudflare service additions, OpenAPI schema evolution — lands as data updates to `services.json` and the spec. The compiler's Cloudflare back-end consumes the updated data on the next build.
- Medium-frequency evolution — new library-defined patterns within existing categories (e.g., `FacetActor` as another shape of actor) — lands as Layer 3 library updates. The compiler's existing pattern-category machinery handles new instances without modification.
- Low-frequency architectural evolution — new pattern categories requiring new verification logic — lands as compiler updates. New categories bring their own decidability proofs into the middle-end.
- Multi-target back-end variation (Cloudflare wing, browser wing, native wing) is build-time composition. Each wing is a combination of dialects, lowering passes, and synthesis backends assembled from shared kit pieces.

**Boundary statement**: A Layer 3 library is a bundle of source code whose primary contribution to compilation is codata attached to the types, modules, and patterns it exports. The compiler consumes that codata during PSG elaboration, propagates it through the refinement chain, and interprets it at synthesis.

See [10: JSIR Strategic Assessment §8.10](10_jsir_strategic_assessment.md) for how this commitment shapes JSIR-targeted compilation specifically.

### Decision 7: Standardize Runtime TypeScript→F# Generation on Xantham ✅

**Commitment**: Fidelity.CloudEdge standardizes its TypeScript-to-F# binding generation pipeline on [Xantham](https://github.com/shayanhabibi/Xantham). Glutinum is being phased out as the runtime binding tool; the migration retires the compensatory pre/post-processing infrastructure built around Glutinum's structural limitations and aligns the project with a tool whose architecture absorbs those concerns natively.

**Why**: Glutinum's monolithic Fable-side pipeline forced Fidelity.CloudEdge to maintain ~330 lines of preprocessing JavaScript, post-processing bash, and hand-curated F# patches to compensate for known limitations: cyclic interface references requiring DFS detection and `any`-replacement, complex intersection truncation, manual `[<CompiledName>]` attribute handling for reserved keywords, partial/crashing output on cycles, missing namespace declarations, and inability to generate import statements. The 0.3.0 work confirmed these compensations as ongoing rather than one-time costs — Glutinum crashed on `agents-sdk` (forcing hand-curated bindings) and produced partial output on the workers-types refresh that required additional post-processors per regen.

Xantham is a hard fork of Glutinum that decomposes the pipeline into three phases — extract (Fable), encode/decode (JSON schema boundary), and generate (.NET) — so each compensation Fidelity.CloudEdge maintains is replaced by a structural property of the architecture. Cyclic references are tracked by the `TypeKey` indirection system at the schema layer. Namespaces and imports are generated automatically from the type graph. `[<CompiledName>]` attributes are emitted natively for reserved keywords. The decoder is reusable across consumers without coupling to extraction. The generator runs in .NET with full F# AST control via Fabulous.AST + Fantomas SyntaxOak.

**Status as of May 2026**: Xantham is actively maintained (commits within hours of this decision), Fidelity.CloudEdge contributed an upstream fix for a `collectAllRecursively` stack-overflow on cyclic graphs, and the post-fix output already produces 18,573 lines of F# from `@cloudflare/workers-types` (vs. Glutinum's partial 17,876 with 32 compile errors) and 507 clean lines from `agents-sdk` (vs. Glutinum's crash). Three localized renderer bugs remain in the Xantham output (empty interface emission, generic constraint syntax, doubled inheritance brackets) — each is a small upstream fix or a thin post-processor, and is materially less work than the Glutinum compensations they replace.

**How to apply**: New runtime bindings (G3 `Fidelity.CloudEdge.Agents`, G4 `Fidelity.CloudEdge.DynamicWorkflows`, future packages) target Xantham as the binding generator. The existing `Fidelity.CloudEdge.Worker.Context` and `Fidelity.CloudEdge.AI` runtime targets continue on Glutinum until the Xantham migration is rolled in (incremental, per-target). The hand-curated Worker.Context/Types.fs and DurableObjects/Types.fs additions remain as the source of truth at the runtime API surface — Xantham migration replaces the *generated* layer underneath, not the hand-curated Fidelity-specific types layered on top.

**Migration sequencing** (tracked in [03_gap_analysis.md](03_gap_analysis.md)):

1. Land the upstream `collectAllRecursively` fix in Xantham proper (PR in flight as of May 2026).
2. Address the three remaining Xantham renderer bugs (locally or upstream) so workers-types generates compilable F# end-to-end.
3. Replace `Fidelity.CloudEdge.Agents/Types.fs` and `Fidelity.CloudEdge.DynamicWorkflows/Types.fs` (currently hand-curated due to Glutinum crash) with Xantham-generated output. This validates the Xantham pipeline against the same surface the application code already depends on.
4. Migrate `Fidelity.CloudEdge.Worker.Context/Generated.fs` from Glutinum to Xantham. Retire `preprocess-typescript.js` (212 lines), `postprocess-runtime.sh` (69 lines), and the Glutinum-specific entries in `06_tool_status.md`.
5. Migrate `Fidelity.CloudEdge.AI/Generated.fs` similarly.
6. Remove the `@glutinum/cli` dependency and the `Glutinum.Types` NuGet package reference. Document the cutover in [03_gap_analysis.md](03_gap_analysis.md).

The Hawaii pipeline for Management API generation is **unaffected** by this migration — Hawaii handles OpenAPI specifications, Xantham handles TypeScript definitions, and the two are orthogonal. Hawaii continues as the Management-tier binding generator. Xantham's role is the runtime-tier replacement for Glutinum specifically.

## Implementation Pipeline

### Runtime API Generation (Glutinum — being phased out per Decision 7)

> **Status**: Glutinum remains operational for the existing Worker.Context and AI bindings while the Xantham migration progresses. New runtime bindings target Xantham. See Decision 7 above for the migration plan.

```bash
# TypeScript definitions → F# bindings (legacy path)
npx @glutinum/cli generate \
    ./node_modules/@cloudflare/workers-types/index.d.ts \
    --output ./src/Runtime/Fidelity.CloudEdge.Worker.Context/Generated.fs
```

### Runtime API Generation (Xantham — standard path going forward)

```bash
# Phase 1: extract TypeScript → JSON schema (Fable-compiled extractor)
cd ../Xantham
node ./index.js \
    /home/hhh/repos/Fidelity.CloudEdge/node_modules/@cloudflare/workers-types/index.d.ts
# Produces output.json (~14 MB for workers-types-shaped inputs)

# Phase 2: decode + generate F# from JSON schema (.NET generator)
cp output.json src/Xantham.Fable/output.json
dotnet run --project src/Xantham.Generator/Xantham.Generator.fsproj \
    > /path/to/Fidelity.CloudEdge/src/Runtime/CloudEdge.Worker.Context/Generated.fs
```

The three phases are deliberately separated so the encoder (TypeScript Compiler API or future TSGO migration) can be replaced without touching downstream consumers, and so a Fidelity-specific generator can be substituted if framework-specific output conventions warrant it.

### Management API Generation (Hawaii — unaffected by Xantham migration)
```bash
cd generators

# Generate all active services (extract, preprocess, generate, post-process, deploy, validate)
bash scripts/generate-management.sh --active-only

# Generate a single service
bash scripts/generate-management.sh --service d1
# Output: src/Management/CloudEdge.Management.D1/
```

## Usage Patterns

### Complete Workflow Example

```fsharp
// 1. Infrastructure Setup (Management API)
let provisionInfrastructure (accountId: string) = async {
    let client = D1ManagementClient()
    let! result = client.CreateDatabase(accountId, "app-db", Some "wnam")
    match result with
    | Ok database -> return database.uuid
    | Error err -> return failwith $"Failed: {err}"
}

// 2. Configure Bindings (wrangler.toml)
[[d1_databases]]
binding = "DATABASE"
database_id = "generated-uuid-here"

// 3. Runtime Operations (Runtime API)
[<Export>]
let fetch (request: Request) (env: Env) =
    async {
        let db = env.DATABASE // D1Database from Runtime API
        let! result = db.prepare("SELECT * FROM users").all()
        return Response.json(result)
    }
```

## Future Architectural Considerations

### Fidelity.CloudEdge CLI Tool (`cfs`)

Will leverage both API layers:
```fsharp
// Deploy command uses both APIs
let deploy (config: DeployConfig) = async {
    // Management API: Create resources
    let! database = ensureDatabase config.database
    let! kvNamespace = ensureKVNamespace config.kv

    // Management API: Deploy Worker
    let! worker = deployWorkerScript config.script

    // Could validate via Runtime API invocation
    return DeploymentResult.Success
}
```

### Firetower Monitoring Tool

Desktop/web monitoring application:
- **Management APIs**: Query metrics, logs, usage
- **Runtime APIs**: Direct Worker invocation for health checks
- **Real-time**: WebSocket connections for live data

## Lessons Learned

1. **Hawaii Limitations**: Some OpenAPI structures cause null reference exceptions; resolved via `preprocess-openapi.sh` which ensures all content-type entries have schema fields
2. **OpenAPI Size**: Large specs need segmentation for tooling compatibility
3. **Namespace Standardization**: Consistent `Fidelity.CloudEdge.Management.*` naming eliminates confusion and improves discoverability
4. **Post-Processing Pipeline**: Automated discriminated union generation and serialization fixes are essential for production-ready clients
5. **Dual Benefits**: Separation enables both infrastructure-as-code AND runtime operations in F#
6. **Portability Matters**: Avoiding .NET-specific patterns (Task, HttpClient) enables compilation via Fable and Fidelity
7. **F# Native Patterns**: Using async workflows and Result types maintains compatibility across all F# toolchains
8. **Discriminator Support**: Hawaii doesn't natively support OpenAPI discriminator schemas; post-processing successfully bridges this gap

## Next Steps

1. **Automate Post-Generation Patches**: Encode the 5-service compilation fixes as post-processors
2. **Build CLI Tool**: Implement `cfs` leveraging both API layers
3. **Create Firetower**: Monitoring tool using Management APIs
4. **Tool Contributions**: Submit preprocessing fixes and post-processing patterns upstream to Hawaii

## Conclusion

The dual-layer architecture successfully provides:
- **Complete Coverage**: Both runtime operations and infrastructure management
- **Type Safety**: Full F# typing across all Cloudflare services
- **Clear Separation**: No confusion between runtime and management concerns
- **Future Flexibility**: Foundation for CLI tools, monitoring, and automation

This architecture positions Fidelity.CloudEdge as the comprehensive F# solution for the entire Cloudflare platform.