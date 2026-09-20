# Runtime vs Management APIs in Fidelity.CloudEdge

## Architecture Overview

Fidelity.CloudEdge implements a **dual-layer API architecture** that separates runtime operations from management operations, reflecting Cloudflare's own platform design.

```
Fidelity.CloudEdge/
└── src/
   ├── Runtime/           # In-Worker APIs (JavaScript interop)
   │   ├── Fidelity.CloudEdge.D1/
   │   ├── Fidelity.CloudEdge.R2/
   │   ├── Fidelity.CloudEdge.KV/
   │   └── Fidelity.CloudEdge.Worker.Context/
   │
   └── Management/        # REST APIs (HTTP clients)
       ├── Fidelity.CloudEdge.Management.Workers/
       ├── Fidelity.CloudEdge.Management.D1/
       ├── Fidelity.CloudEdge.Management.R2/
       ├── Fidelity.CloudEdge.Management.Analytics/
       └── Fidelity.CloudEdge.Management.Queues/
```

## Runtime APIs (In-Worker)

**Source**: TypeScript definitions from the Cloudflare intelligent-edge npm SDK suite — `@cloudflare/workers-types` as the platform-bindings foundation, plus the `cloudflare/agents` monorepo family (`agents`, `@cloudflare/ai-chat`, `@cloudflare/voice`, `@cloudflare/think`, `@cloudflare/codemode`, `@cloudflare/shell`, `@cloudflare/worker-bundler`) and the adjacent runtime SDKs `@cloudflare/dynamic-workflows`, `@cloudflare/containers`, `@cloudflare/sandbox`, and `@cloudflare/puppeteer`. The agentic surface is on par with workers-types in scope, not a side concern.
**Generation**: Xantham (TypeScript → F#) — standard going forward per [00 Decision 7](00_architecture_decisions.md). Glutinum is the legacy generator for existing Worker.Context and AI bindings until they migrate; new runtime bindings target Xantham. Supply-chain hygiene for ingested npm packages is governed by [13_supply_chain_audit.md](13_supply_chain_audit.md).
**Usage**: F# code running **inside** Cloudflare Workers
**Protocol**: Direct JavaScript interop
**Authentication**: Via Worker bindings in `wrangler.toml`

### Example: Runtime D1 Operations
```fsharp
// Inside a Worker - using Runtime API
open Fidelity.CloudEdge.D1

let handleRequest (request: Request) (env: Env) =
    async {
        // env.DATABASE is a D1Database binding from wrangler.toml
        let db = env.DATABASE
ar
        // Direct database operations via JavaScript interopy" e 
        let! result =
            db.prepare("SELECT * FROM users WHERE id = ?")
              .bind(userId)
              .first<User>()

        match result with
        | Some user -> return Response.json(user)
        | None -> return Response.error("User not found", 404)
    }
```

### Runtime API Characteristics:
- Zero-latency access to platform services
- No HTTP overhead
- Automatic authentication via bindings
- Limited to operations available in Worker context
- Cannot create/delete resources, only use them

## Management APIs (External)

**Source**: Cloudflare OpenAPI specifications
**Generation**: Hawaii (OpenAPI → F#). The official `cloudflare` (unscoped) npm TypeScript client covers the same REST endpoints and is intentionally not carried as a parallel xantham-ingested binding — duplicating Hawaii's surface area would double maintenance for no new capability
**Usage**: F# applications **outside** Workers (deployment tools, CLIs, management apps)
**Protocol**: HTTPS REST API
**Authentication**: API tokens/keys

### Example: Management D1 Operations
```fsharp
// External application - using Management API
open Fidelity.CloudEdge.Management.D1
open System.Net.Http

let provisionDatabase (accountId: string) (apiToken: string) =
    async {
        let httpClient = new HttpClient()
        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiToken}")

        let client = D1ManagementClient(httpClient)

        // Create a new D1 database via REST API
        let! database =
            client.CreateDatabase(
                accountId = accountId,
                name = "production-db",
                primaryLocationHint = Some "wnam"
            )

        printfn $"Created database: {database.uuid}"

        // List all databases
        let! databases = client.ListDatabases(accountId)
        return databases
    }
```

### Management API Characteristics:

- Full CRUD operations on resources
- Account-level administration
- Billing and usage information
- Cross-region configuration
- Requires API authentication

## Use Case Comparison

| Operation | Runtime API | Management API |
|-----------|-------------|----------------|
| Query D1 database | ✅ `db.prepare(...).all()` | ❌ Not available |
| Create D1 database | ❌ Not available | ✅ `client.CreateDatabase(...)` |
| Read KV value | ✅ `env.KV.get(key)` | ✅ `client.GetValue(...)` (slower) |
| Create KV namespace | ❌ Not available | ✅ `client.CreateNamespace(...)` |
| Stream R2 object | ✅ `env.BUCKET.get(key)` | ✅ `client.GetObject(...)` (different) |
| Create R2 bucket | ❌ Not available | ✅ `client.CreateBucket(...)` |
| Execute Worker | ✅ Direct invocation | ✅ Via HTTP trigger |
| Deploy Worker | ❌ Not available | ✅ `client.UpdateWorkerScript(...)` |

## Workflow Options

This process is still under review, but it's worth noting the "head space" that various approaches require as design moves toward implementation.

**Important**: Fidelity.CloudEdge's goal is to make F# .fsx configuration of solutions a first-class consideration. All infrastructure should be defined in code, not configuration files. While we may export wrangler.toml for compatibility with existing Cloudflare tooling, it is an express goal of this framework to operate code-first.

1. **Infrastructure Setup** (Management API)

   ```fsharp
   // CLI tool or deployment script - pure F# code
   let! database = managementClient.CreateDatabase(accountId, "app-db")
   let! kvNamespace = managementClient.CreateNamespace(accountId, "cache")
   let! r2Bucket = managementClient.CreateBucket(accountId, "assets")
   ```

2. **Configure Bindings** (F# code, NOT TOML)

   ```fsharp
   // Fidelity.CloudEdge code-first approach - bindings defined in F#
   let workerBindings = [
       D1Database("DATABASE", databaseId = "abc-123-def")
       KVNamespace("CACHE", namespaceId = "xyz-456-789")
       R2Bucket("ASSETS", bucketName = "assets")
   ]

   // Optional: Export to wrangler.toml for compatibility
   let exportToWranglerToml() =
       workerBindings |> WranglerCompat.exportBindings "wrangler.toml"
   ```

3. **Runtime Operations** (Runtime API)

   ```fsharp
   // Inside Worker
   let handleRequest (env: Env) =
       let! data = env.DATABASE.prepare("SELECT * FROM data").all()
       let! cached = env.CACHE.get("key")
       let! asset = env.ASSETS.get("logo.png")
       // ... process and respond
   ```

## Generation Pipeline

### Runtime APIs

> **Migration in progress** ([00 Decision 7](00_architecture_decisions.md)). The Runtime API generation pipeline is moving from Glutinum to Xantham. Both flows are documented below; new bindings target Xantham; existing `Worker.Context` and `AI` bindings remain on Glutinum until their migration is scheduled.

#### Xantham (forward-going)

Xantham is a single .NET process. It runs the TypeScript 7 compiler (the Go `tsc` shipped in the pinned `typescript` npm package) as `tsc --api`, speaks its msgpack protocol over stdio through `Xantham.TypeScript.Wire`, and asks the live checker for types, symbols, and signatures. There is no Fable-compiled extractor and no JSON intermediate; the earlier extractor → `output.json` → decoder design is retired to Xantham's `.archive/`.

```bash
# One command over a package directory; the package's own node_modules resolves its dependencies.
cd ../Xantham
dotnet run --project src/Xantham.Cli -- generate /home/hhh/repos/Fidelity.CloudEdge/node_modules/@cloudflare/workers-types \
    -o /path/to/Fidelity.CloudEdge/src/Runtime/Fidelity.CloudEdge.Worker.Context/Generated

# Emit the JSON Schema for xantham.json (also written by `build.fsx -- generate --only schema`).
dotnet run --project src/Xantham.Cli -- schema -o xantham.schema.json
```

Configuration is discovered from an `xantham.json` beside the package's `package.json` (`--config <path>` overrides the location). Its keys are `module` (the entry package's F# module name), `namespace` (the F# namespace a package family shares, so `@cloudflare/workers-types` and a dependent package read as `FSharp.CloudEdge` and `FSharp.CloudEdge.<Leaf>` from either side of a reference), `groups` (a disposition per dependency package: `ship` emits the dependency as its own module under `groups/`, `reference` templates its names against a run performed elsewhere, `map` redirects names to a hand-written binding such as `Fable.Core.JS.*` with the destination's arity, `widen` renders them as `obj` with a finding), and `lib` (the compiler lib option, spelled as `tsconfig.json` spells it).

A run writes one `.fs` per shipped group plus a `manifest.json` that grades every symbol `Exact`, `Ergonomic`, `Widened`, or `Escape` and attributes each loss to a coded finding (`TR006`, `HG001`, ...). The manifest is the review artifact: a regeneration is judged by the tier movement it causes, and the finding keys say which mapping decision each loss traces to. Generated bindings target Fable 5.x only, open `Fable.Core` plus the `Fable.Browser.*` family, and expect `Xantham.Fable.Core` for the erased `keyof`/brand helpers.

Xantham's own corpus pins `@cloudflare/workers-types` as a golden rung: every regeneration is diffed against the committed output, compiled as F# by a compile gate, and executed under Fable by a run gate. The September 20 source review at Xantham `c7e2fa0` found `cloudflare:workers` in the committed workers-types golden, including imported `DurableObject`, with `HG004` recording harvested exports. The earlier blanket `HG001` ambient-module blocker is therefore obsolete. Review the selected package graph's current `manifest.json` and `symbols.jsonl` for remaining losses; that upstream golden does not establish acceptance of this repository's full Agents graph.

The reviewed Xantham README records the `Xantham.Cli` dotnet tool at `0.1.0-alpha.1`. Use its [generator guide](../../Xantham/docs/generator-usage.md) for package installation and configuration, or the checkout invocation above when preserving a specific source revision.

#### Glutinum (legacy — deprecated)

```bash
# TypeScript → F# (legacy path, retained for existing Worker.Context and AI)
npx @glutinum/cli generate ./node_modules/@cloudflare/workers-types/index.d.ts \
    --output ./src/Runtime/Fidelity.CloudEdge.Worker.Context/Generated.fs \
    --namespace Fidelity.CloudEdge.Worker
```

### Management APIs (Hawaii)

```bash
# OpenAPI → F#
hawaii --config ./generators/hawaii/d1-hawaii.json
# Generates: src/Management/Fidelity.CloudEdge.Management.D1/
```

## Key Benefits

1. **Type Safety**: Both layers are fully typed in F#
2. **No Duplication**: Each API serves distinct purposes
3. **Complete Coverage**: Can manage infrastructure AND run applications
4. **Familiar Patterns**: Management follows REST conventions, Runtime follows platform conventions
5. **Tool Flexibility**: Can build CLIs, deployment tools, and Workers all in F#

## Future: The `cfs` CLI Tool

The Fidelity.CloudEdge CLI will leverage both API layers:

```fsharp
// cfs deploy command - uses both APIs
let deploy (config: DeployConfig) =
    async {
        // Management API: Ensure infrastructure exists
        let! database = ensureDatabase config.database
        let! kvNamespace = ensureKVNamespace config.kv

        // Management API: Deploy Worker code
        let! worker = deployWorkerScript config.script

        // Runtime API validation could happen here
        // by invoking the Worker and checking health

        return DeploymentResult.Success
    }
```

This dual-layer approach would provide the flexibility to build any Cloudflare tool or application entirely in F#.
