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

## Implementation Pipeline

### Runtime API Generation (Glutinum)
```bash
# TypeScript definitions → F# bindings
npx @glutinum/cli generate
    ./node_modules/@cloudflare/workers-types/index.d.ts \
    --output ./src/Runtime/Fidelity.CloudEdge.Worker.Context/Generated.fs
```

### Management API Generation (Hawaii)
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