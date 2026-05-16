# Fidelity.CloudEdge

[![Fidelity.CloudEdge.Runtime](https://img.shields.io/nuget/v/Fidelity.CloudEdge.Runtime?label=Runtime)](https://www.nuget.org/packages/Fidelity.CloudEdge.Runtime)
[![Fidelity.CloudEdge.Management](https://img.shields.io/nuget/v/Fidelity.CloudEdge.Management?label=Management)](https://www.nuget.org/packages/Fidelity.CloudEdge.Management)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE-MIT)
[![License: Apache 2.0](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](LICENSE-APACHE)
[![Powered by Cloudflare](https://img.shields.io/badge/Powered%20by-Cloudflare-orange?logo=cloudflare&logoColor=white)](https://www.cloudflare.com)

**Fidelity.CloudEdge** is the F# binding suite for Cloudflare's intelligent edge — the AI-agent, voice, sandbox, code-mode, browser-rendering, container, and dynamic-workflow surface that defines the platform's modern value proposition — composed on a substrate-agnostic actor model that extends the [Fidelity Framework](https://github.com/FidelityFramework) across bare metal and edge computing environments. Built on F# and Fable, it gives F# code first-class access to the same AI/agentic primitives Cloudflare ships to TypeScript developers, while enabling seamless actor migration between execution contexts and preserving semantic guarantees across substrates.

## Overview

Fidelity.CloudEdge is a **framework extension**, not a standalone tool. It represents the edge computing layer of the broader Fidelity Framework architecture, which provides substrate-transparent actor model abstractions:

- **Bare Metal**: Actors compiled via MLIR through Fidelity.Firefly
- **Edge Computing**: Actors compiled to JavaScript via Fable for Cloudflare Workers
- **Architectural Fidelity**: Same `MailboxProcessor` code, different execution contexts

This dual-substrate approach enables:
- **Actor Migration**: Move actors between bare metal and edge without code changes
- **Hybrid Deployments**: Latency-sensitive operations at the edge, compute-intensive work on bare metal
- **Unified Semantics**: Sequential processing guarantees preserved across contexts

## Architecture

### Three-Tier Package Model

Fidelity.CloudEdge mirrors the three structural path scopes in Cloudflare's API, shipping each as an independent NuGet package. Consumers install only the tiers their use case requires.

| Tier | Path scope | Audience | Package |
|------|-----------|----------|---------|
| **Runtime** | In-Worker (no path) | Worker developers | `Fidelity.CloudEdge.Runtime` |
| **Management** | `/accounts/{account_id}/*` | Individual developers, teams | `Fidelity.CloudEdge.Management` |
| **Tenancy** | `/tenants/{tenant_id}/*`, `/organizations/*` | MSPs, platform teams | `Fidelity.CloudEdge.Tenancy` |

#### Runtime Layer (In-Worker)
- **Purpose**: Operations inside Cloudflare Workers, including the full AI-agent / intelligent-edge surface
- **Source**: TypeScript definitions from the Cloudflare npm SDK suite, ingested via **Xantham** (the forward-going TS→F# generator; Glutinum is being phased out per [Decision 7](docs/00_architecture_decisions.md))
- **Scope**: `@cloudflare/workers-types` (740+ Worker platform types), the `cloudflare/agents` monorepo family (`agents`, `@cloudflare/ai-chat`, `@cloudflare/voice`, `@cloudflare/think`, `@cloudflare/codemode`, `@cloudflare/shell`, `@cloudflare/worker-bundler`), and the adjacent runtime SDKs `@cloudflare/dynamic-workflows`, `@cloudflare/containers`, `@cloudflare/sandbox`, and `@cloudflare/puppeteer`
- **Usage**: Direct platform access with microsecond latency
- **Actor Context**: Provides sequential execution guarantees for actor message processing
- **Note**: The control-plane surface (`api.cloudflare.com`) is **not** in scope here — that's Hawaii's responsibility (see Management Layer below). The unscoped `cloudflare` npm TypeScript client covers the same REST endpoints Hawaii already binds from OpenAPI, so it isn't carried as a duplicate ingestion target.

#### Management Layer (Account-Scoped)
- **Purpose**: Infrastructure provisioning, monitoring, and orchestration within a single Cloudflare account
- **Source**: OpenAPI specifications via [Hawaii](https://github.com/Zaid-Ajaj/Hawaii)
- **Scope**: 39+ service clients covering account-scoped Cloudflare APIs (`/accounts/{account_id}/*`)
- **Usage**: REST API clients for deployment tools and scripts operating on a developer's own account
- **Framework Role**: Enables dynamic resource allocation for actor migrations

#### Tenancy Layer (Cross-Account)
- **Purpose**: Multi-tenant operations above the account boundary — organizations, tenants, and cross-account administration
- **Source**: OpenAPI specifications via [Hawaii](https://github.com/Zaid-Ajaj/Hawaii)
- **Scope**: Tenant and organization management APIs (`/tenants/{tenant_id}/*`, `/organizations/*`, `/user/organizations`)
- **Audience**: Managed Service Providers (MSPs), enterprise platform teams, any tooling that operates across multiple Cloudflare accounts
- **Independence**: Ships as a separate package; individual developers and teams operating a single account do not need to install it

## Service Coverage

### Runtime Bindings (740+ types)

The runtime surface is distributed across focused packages. `Worker.Context` provides the core Worker API and generated Glutinum bindings; each additional service ships as a separate package with its own `Types` and `Helpers` modules.

| Package | Category | Key Types |
|---------|----------|-----------|
| `Worker.Context` | Core Worker APIs | Request, Response, Headers, FetchEvent, ExecutionContext, Fetch, Socket, URL, URLPattern, URLSearchParams |
| `Worker.Context` | Streams | ReadableStream, WritableStream, TransformStream, FixedLengthStream, CompressionStream, DecompressionStream |
| `Worker.Context` | Crypto | SubtleCrypto, CryptoKey, CryptoKeyPair, DigestStream |
| `Worker.Context` | Cache | Cache, CacheStorage, CacheQueryOptions |
| `Worker.Context` | HTMLRewriter | HTMLRewriter, Element, Comment, Text, DocumentEnd |
| `Worker.Context` | Networking | WebSocket (with hibernation), Encoding streams, FormData, Blob |
| `Worker.Context` | Media | Images (transform, draw, upload), Media Transforms, Markdown conversion |
| `Worker.Context` | Email | EmailMessage, EmailEvent, ForwardableEmailMessage, SendEmail |
| `Worker.Context` | Compute | Workflows, Cron Triggers, Worker Loader (globalOutbound, streamingTails) |
| `Worker.Context` | Observability | Tail, Trace, TraceLog, TraceMetrics, diagnostic channels |
| `D1` | SQL Database | D1Database, D1PreparedStatement, D1Result\<'T\>, D1ExecResult |
| `KV` | Key-Value Store | KVNamespace, KVPutOptions, KVListOptions, KVListResult, KVKey |
| `R2` | Object Storage | R2Bucket, R2Object, R2ObjectBody, R2PutOptions, R2HTTPMetadata |
| `DurableObjects` | Stateful Actors | DurableObjectId, DurableObjectStub, DurableObjectNamespace, DurableObjectFacets, Container, ContainerStartupOptions, ServiceBinding |
| `Queues` | Messaging | Queue\<'Body\>, Message\<'Body\>, MessageBatch\<'Body\>, QueueSendOptions |
| `AI` | AI/ML Inference | Workers AI (per-model typed I/O), AI Gateway, AI Search, AutoRAG |
| `Vectorize` | Vector Search | VectorizeVector, VectorizeMatches, VectorMatch, VectorizeQueryOptions |
| `Hyperdrive` | Database Proxy | Hyperdrive, connection pooling, PostgreSQL/MySQL URL builders |

### Intelligent-Edge SDKs (Xantham-Generated from the `cloudflare/agents` monorepo and adjacent npm packages)

This is the AI/agentic surface that Cloudflare has staked the platform on since Agents Week (March–April 2026). It is the substantive scope of Fidelity.CloudEdge as much as the runtime-bindings layer above — the actor-model substrate is what *lets* F# participate, but these SDKs are *what* F# participates in.

| Package | Category | Surface |
|---------|----------|---------|
| `Agents` | Agent framework core | `Agent<'Env, 'State>`, lifecycle hooks (`onConnect`, `onMessage`, `onRequest`), routing, state, scheduling, MCP, email, workflows, x402, browser-agents, `@callable()` RPC |
| `Agents.AiChat` | Persistent chat layer | Resumable streaming, tool execution, persistent message store. Framework-agnostic core only — React-coupled exports are filtered (signals/SolidJS is the project's reactivity model) |
| `Agents.Voice` | Voice pipeline | STT, TTS, VAD, real-time streaming, SFU utilities, `VoiceClient`. React hooks filtered |
| `Agents.Think` | Opinionated agent loop | Agentic loop, stream resumption, client tools, workspace tools, `submitMessages()` durable programmatic submission |
| `Agents.CodeMode` | LLM code-mode tools | LLM-generated TypeScript that orchestrates tool calls inside a sandbox, instead of one-tool-call-at-a-time |
| `Agents.Shell` | Sandbox + virtual FS | Sandboxed JS execution, virtual filesystem (`Workspace`), structured file I/O, transactional pattern replacement, git operations |
| `Agents.WorkerBundler` | Runtime Worker bundling | Build/bundle Workers at runtime for the Worker Loader binding (esbuild-wasm-driven) |
| `DynamicWorkflows` | Multi-tenant workflow dispatch | `createDynamicWorkflowEntrypoint`, `wrapWorkflowBinding`, `dispatchWorkflow`, `DynamicWorkflowBinding` |
| `Containers` | Container-enabled DOs | Helper class for container-enabled Durable Objects (DO + Container composition) |
| `Sandbox` | Sandboxed command execution | Containerized command-execution environment for safely running arbitrary operations |
| `Puppeteer` | Agentic browser rendering | Puppeteer-API-compatible control over the Workers Browser-Rendering binding — fetch JS-driven pages, capture DOM snapshots, take screenshots, and extract content as tool calls inside an agentic workflow. The same capability class Cloudflare uses in their site-crawler topology; load-bearing for agents that need to gather information from the open web |

### Management Clients (40 services)

| Category | Services |
|----------|----------|
| **Compute and Storage** | Workers, Pages, Durable Objects, Containers, KV, R2, R2 Catalog, D1, Queues, Hyperdrive, Secrets Store |
| **AI and ML** | AI, AI Gateway, AI Search, AutoRAG, Vectorize |
| **Orchestration** | Workflows, Pipelines |
| **Media** | Stream, Images, Browser Rendering, Calls |
| **Networking and Security** | Access, Gateway, Tunnels, Mesh (WARP Connector), Load Balancers, Waiting Rooms, Magic Transit, Email |
| **Observability and Platform** | Analytics, Logs, Builds |

## Installation

### Runtime Package (For Workers)
```bash
dotnet add package Fidelity.CloudEdge.Runtime
```

### Management Package (For Tools/Scripts)
```bash
dotnet add package Fidelity.CloudEdge.Management
```

## Usage Examples

### Actor Model Example: Sequential Processing

```fsharp
open Fidelity.CloudEdge.Worker.Context
open Fidelity.CloudEdge.DurableObjects
open Fidelity.CloudEdge.D1

// Traditional actor pattern - works identically on bare metal or edge
type CounterMsg =
    | Increment
    | GetCount of AsyncReplyChannel<int>

type Counter() =
    let agent = MailboxProcessor<CounterMsg>.Start(fun inbox ->
        let rec loop count = async {
            let! msg = inbox.Receive()
            match msg with
            | Increment -> return! loop (count + 1)
            | GetCount reply ->
                reply.Reply(count)
                return! loop count
        }
        loop 0)

    member _.Increment() = agent.Post(Increment)
    member _.GetCount() = agent.PostAndReply(GetCount)

// On edge: Durable Object provides sequential execution context
[<DurableObject>]
type CounterDO(state: DurableObjectState, env: Env) =
    let mutable count = 0

    member this.fetch(request: Request) = async {
        // Guaranteed sequential processing - no race conditions
        match request.method with
        | "POST" ->
            count <- count + 1
            return Response.json({| count = count |})
        | "GET" ->
            return Response.json({| count = count |})
        | _ ->
            return Response.methodNotAllowed()
    }
```

### Complete Workflow: Infrastructure + Runtime

```fsharp
// 1. Infrastructure Setup (Management API - runs on your machine)
open Fidelity.CloudEdge.Management.D1
open System.Net.Http

let setupInfrastructure (accountId: string) (apiToken: string) = async {
    let httpClient = new HttpClient()
    httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiToken}")

    let d1Client = D1Client(httpClient)
    let! database = d1Client.CreateDatabase(
        accountId = accountId,
        name = "production-db",
        primaryLocationHint = Some "wnam"
    )

    printfn $"Created database: {database.uuid}"
    return database.uuid
}

// 2. Runtime Operations (Runtime API - runs in Worker)
open Fidelity.CloudEdge.D1
open Fidelity.CloudEdge.Worker.Context

[<Export>]
let fetch (request: Request) (env: Env) (ctx: ExecutionContext) =
    async {
        let db = env.DATABASE

        match request.method with
        | "GET" ->
            let! users = db.prepare("SELECT * FROM users").all<User>()
            return Response.json(users)

        | "POST" ->
            let! body = request.json<User>()
            let! result =
                db.prepare("INSERT INTO users (name, email) VALUES (?, ?)")
                  .bind(body.name, body.email)
                  .run()
            return Response.json({| success = result.success |})

        | _ -> return Response.methodNotAllowed()
    }
```

## Sample Projects

### HelloWorker
Basic Worker with KV storage:
```bash
cd samples/HelloWorker
dotnet fable . --outDir dist
npx wrangler dev
```

### SecureChat
Production-ready chat API featuring:
- User authentication via Cloudflare Secrets
- D1 database for message persistence
- PowerShell user management scripts
- Separate React UI with Tailwind CSS

```bash
cd samples/SecureChat
.\scripts\add-user.ps1 -Username alice -Password "Pass123!"
dotnet fable . --outDir dist
npx wrangler dev
```

## Generation Pipeline

All layers are generated from official Cloudflare specifications:

- **Runtime** (`@cloudflare/workers-types`) and **Intelligent-Edge SDKs** (the eleven npm packages enumerated above): TypeScript definitions ingested by [Xantham](https://github.com/shayanhabibi/Xantham), the forward-going TS→F# binding generator standardized in [Decision 7](docs/00_architecture_decisions.md). Glutinum remains as a legacy path for the original `Worker.Context` and `AI` bindings until they migrate.
- **Management**: [Cloudflare OpenAPI spec](https://github.com/cloudflare/api-schemas) processed by [Hawaii](https://github.com/Zaid-Ajaj/Hawaii), producing 40 service clients. The official `cloudflare` (unscoped) npm TypeScript client covers the same REST endpoints; it is intentionally **not** ingested as a duplicate binding because Hawaii already produces canonical F# clients for the same surface.

Supply-chain hygiene for the ingested npm packages is governed by [docs/13_supply_chain_audit.md](docs/13_supply_chain_audit.md). Cloudflare-published direct dependencies in the suite are verified by SLSA v1 provenance attestations bound to Cloudflare's GitHub org (`314135`) wherever the publisher uses npm trusted-publishing; `@cloudflare/puppeteer` is the one current Cloudflare-published SDK in the suite without published provenance, so its ingestion stays under the default 72-hour audit policy on every bump — that's an audit treatment, not a scope decision. Transitives are always audited under the default 72-hour quarantine.

The generation pipeline includes automated preprocessing (`preprocess-openapi.sh`) to handle Hawaii compatibility issues, type sanitization for underscore variants, and query parameter overload resolution. All 40 management services compile cleanly with the current pipeline.

See [generators/README.md](generators/README.md) for pipeline details and [docs/03_gap_analysis.md](docs/03_gap_analysis.md) for service-level status.

## Test Coverage

The test suite validates the full surface area:

- **686 tests** across structural validation, client construction, serialization, and infrastructure checks
- All 40 management assemblies verified via reflection-based data-driven tests
- JSON round-trip serialization with `Fable.Remoting.Json` + `Newtonsoft.Json`
- OpenApiHttp infrastructure consistency across all services

## Vision and Roadmap

### Framework-Level Integration

Fidelity.CloudEdge is evolving toward deeper integration with the broader Fidelity Framework:

#### Actor Migration
- **Dynamic Substrate Selection**: Framework-level orchestration to move actors between bare metal and edge
- **Latency-Aware Placement**: Actors automatically placed based on geographic and computational requirements
- **Seamless State Transfer**: Unified state management across execution contexts

#### Deployment Orchestration
The planned `cfs` CLI will provide type-safe, F#-first deployment with Framework integration:

```fsharp
// deploy.fsx - Framework-aware deployment
#r "nuget: Fidelity.CloudEdge"
open Fidelity.CloudEdge.Deployment

let deploy env = cloudflare {
    account (getAccountId env)

    worker $"api-service-{env}" {
        actors [
            actor<UserService> (durable "user-service")
            actor<RAGAgent> (durable "rag-agent")
        ]

        kv "CACHE" (ensureOrCreate "cache-namespace")
        d1 "DATABASE" (ensureOrCreate "app-database" {
            migrations = "./migrations"
            location = "wnam"
        })

        route $"api-{env}.example.com/*"
    }
}
```

## Documentation

### Core Architecture
- [Architecture Decisions](docs/00_architecture_decisions.md) - Key design choices and roadmap
- [Dual Layer Architecture](docs/01_dual_layer_architecture.md) - Runtime vs Management APIs
- [Code-First Deployment](docs/02_code_first_deployment.md) - Code-driven deployment strategies

### Generation and Status
- [Gap Analysis](docs/03_gap_analysis.md) - Service maturity and remaining gaps
- [Tool Status](docs/06_tool_status.md) - Glutinum/Hawaii limitations and mitigations
- [Generators](generators/README.md) - Generation pipeline usage and configuration

### Concepts and Future
- Actor Model Design - Durable Object actor model with tell/ask semantics
  - [Overview](docs/08a_actor_model_overview.md) - Architecture summary, layering, phases
  - [Actor Core](docs/08b_actor_core.md) - DO substrate, WebSocket, BAREWire, lifecycle, supervision
  - [MailboxProcessor Intercept](docs/08c_mailbox_intercept.md) - API surface, push model, migration
  - [Persistence & Observability](docs/08d_persistence_observability.md) - Event sourcing, journals, instrumentation
  - [Management Infrastructure](docs/08e_management_infrastructure.md) - Control plane provisioning, deployment orchestration
- [Firetower Concept](docs/04_firetower_concept.md) - Monitoring tool design
- [Pulumi Insights](docs/05_pulumi_insights.md) - Lessons from Pulumi's approach
- [Pages Direct Upload](docs/07_pages_direct_upload.md) - Pages upload implementation

### Examples
- [Samples](samples/) - Working examples demonstrating framework capabilities

## Contributing

We welcome contributions! See [CONTRIBUTING.md](CONTRIBUTING.md) for guidelines.

## Support

- **Issues**: [GitHub Issues](https://github.com/FidelityFramework/Fidelity.CloudEdge/issues)
- **Discussions**: [GitHub Discussions](https://github.com/FidelityFramework/Fidelity.CloudEdge/discussions)

## License

Licensed under either of

* Apache License, Version 2.0 ([LICENSE-APACHE](LICENSE-APACHE) or http://www.apache.org/licenses/LICENSE-2.0)
* MIT license ([LICENSE-MIT](LICENSE-MIT) or http://opensource.org/licenses/MIT)

at your option.

### Contribution

Unless you explicitly state otherwise, any contribution intentionally submitted for inclusion in the work by you shall be dual licensed as above, without any additional terms or conditions.

---

## Acknowledgments

Fidelity.CloudEdge stands on the shoulders of giants:

- **[Fable](https://fable.io/)** - The magnificent F# to JavaScript compiler enabling substrate-agnostic actors at the edge. Special thanks to Alfonso Garcia-Caro, Maxime Mangel, and all maintainers/contributors.

- **[Glutinum](https://github.com/glutinum-org)** - TypeScript to F# binding generator. Thanks to Maxime Mangel for this invaluable tool that makes Worker bindings possible.

- **[Hawaii](https://github.com/Zaid-Ajaj/Hawaii)** - OpenAPI to F# client generator. Thanks to Zaid Ajaj for creating this and pioneering F# on Cloudflare Workers.

- **[Cloudflare](https://cloudflare.com)** - For building an incredible edge platform with Durable Objects, providing the sequential execution context necessary for actor guarantees at the edge.

This project is SpeakEZ's contribution to the F#, Fable, and Cloudflare communities, and a key component of the broader Fidelity Framework vision.
