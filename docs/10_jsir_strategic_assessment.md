# JSIR: Strategic Assessment for Clef, Composer, and Fidelity.CloudEdge

> Cross-cutting strategic document. Touches [00: Architecture](00_architecture_decisions.md), [08a–08e: Actor Model](08a_actor_model_overview.md), and the generation pipeline ([06](06_tool_status.md), [09](09_type_resolution_rules.md)).

## Date: April 6, 2026

## Context

On April 6, 2026, Google published an RFC to upstream JSIR (JavaScript Intermediate Representation) into MLIR. JSIR is an MLIR dialect that represents JavaScript with full AST fidelity, supporting lossless round-trip conversion between JavaScript source, ESTree AST, and MLIR ops. Google has used JSIR in production internally for Hermes bytecode decompilation, JavaScript deobfuscation, and malicious code detection. The RFC was posted to the LLVM Discourse by Zhixun Tan of Google's compiler team.

Repository: https://github.com/google/jsira
RFC: https://discourse.llvm.org/t/rfc-jsir-a-high-level-ir-for-javascript/90456
License: Apache-2.0

---

## 1. What JSIR Is

JSIR is an out-of-tree MLIR dialect that maintains a nearly 1:1 mapping with ESTree AST nodes. It uses MLIR regions to model JavaScript control flow structures (if/while/logical short-circuit), distinguishes l-values (`jsir.identifier_ref`) from r-values (`jsir.identifier`), and achieves 99.9%+ fidelity on round-trip conversion (source to AST to JSIR and back) across billions of samples at Google.

### Core Design Properties

- **High-level, not low-level.** JSIR captures source-level semantics, not JIT-level or machine-level operations. It is designed to produce readable JavaScript on the return path.
- **Round-trippable.** Source <-> AST <-> JSIR is lossless. The IR lifts back to structurally faithful, readable JavaScript source.
- **MLIR-native.** Uses regions, SSA values, MLIR's pass infrastructure, and dataflow analysis frameworks. Proposed for inclusion alongside dialects like WasmSSA.
- **L-value/R-value distinction.** Explicit separation with potential future migration to `memref` for l-values and MLIR's built-in symbol table.
- **No type system.** JSIR has no type representation. It is structurally and syntactically faithful, not semantically typed. Type erasure is an explicit design boundary.

### Key Operations

- Literals: `jsir.numeric_literal`, `jsir.identifier`
- Expressions: `jsir.binary_expression`, `jsir.assignment_expression`, `jsir.call_expression`
- Statements: `jsir.expression_statement`
- Control flow: `jshir.if_statement`, `jshir.while_statement`, `jshir.logical_expression`
- Region terminators: `jsir.expr_region_end`, `jsir.exprs_region_end`

### Repository Structure

- 84.8% C++, 2.5% MLIR (dialect definitions in TableGen/ODS), 4.0% JavaScript (tests)
- Builds with Bazel against `@llvm-project`
- Docker build path available for quick evaluation
- Source lives under `maldoca/js/ir/` (Maldoca is Google's malicious document analysis framework)
- Key targets: `jsir_gen` (source -> AST -> JSIR pipeline), conversion tests under `maldoca/js/ir/conversion/`

---

## 2. Who Built It

The contributor list includes core MLIR infrastructure engineers:

- **Jacques Pienaar** (Google) -- Core MLIR contributor. In October 2022, on an RFC proposing an `emitjs` dialect for MLIR, Pienaar mentioned JavaScript-to-MLIR round-trip work that was "not yet fully open source." That work was JSIR.
- **Mehdi Amini** (now at NVIDIA) -- Core MLIR contributor. On the same 2022 RFC, Amini requested type system and operation specifications. He was simultaneously working on JSIR internally.
- **Jeff Niu** (now at OpenAI) -- Core MLIR contributor (IRDL and other infrastructure work). His involvement confirms JSIR was built with deep MLIR design knowledge, not as a side project.

Additional contributors include engineers from CMU, Penn State, UT Austin, UMD, and several Google security teams. This is a well-resourced, well-designed project built by people who understand MLIR's architecture and upstream governance processes.

---

## 3. Precedents and Prior Art

### EmitC (MLIR Core)

EmitC is an MLIR dialect already upstream in MLIR core, designed specifically for lowering MLIR to C source code. It establishes the pattern: an MLIR dialect can serve as a source language emission target, not just an analysis or optimization substrate. JSIR is structurally the same pattern applied to JavaScript.

### The 2022 `emitjs` RFC

In October 2022, an RFC on the LLVM Discourse proposed an `emitjs` dialect modeled on EmitC, with the pipeline: `ONNX model / C / DSL -> MLIR dialects -> MLIR js-Dialect -> JavaScript`. The community asked for prototypes and specifications. Four years later, JSIR delivers on that vision from the opposite direction (analysis-first, but with full round-trip capability enabling the emission use case).

### WAMI (WebAssembly through MLIR)

The WAMI project demonstrated compilation to WebAssembly through MLIR dialects (SsaWasm, Wasm) without going through LLVM IR. Their paper explicitly mentions future integration with a JavaScript MLIR dialect. This confirms that MLIR dialects as non-LLVM compilation targets is an active, validated research direction.

### js_of_ocaml and Fable

The ML-family-to-JavaScript compilation path is well-trodden. js_of_ocaml compiles OCaml bytecode to JavaScript. Fable compiles F# AST to JavaScript. The transformations required (pattern matching to switch/if chains, algebraic data types to object construction, tail calls, currying) are thoroughly understood. These serve as direct blueprints for writing MLIR lowering passes that target JSIR.

### Partas.Solid

Partas.Solid provides JSX bindings from F#, demonstrating that JSX is a source-level concern handled through typed DSL embeddings, not an IR-level concern. JSX desugars to function calls. The IR (JSIR) only needs to represent the desugared JavaScript.

---

## 4. Strategic Implications for Clef and Composer

### The Previous Plan

The original Clef-to-JavaScript plan was to use something analogous to Fable's Oak AST, going from Clef's PSG (in Compiler Services) directly to JavaScript. This path bypasses the Alex MiddleEnd entirely. JavaScript generation would be a side door, separate from the MLIR pipeline.

### What JSIR Changes

JSIR places JavaScript back inside the MLIR ecosystem. Instead of bypassing the Alex MiddleEnd entirely for JavaScript targets, the PSG enters Alex and JavaScript generation becomes part of the Composer compilation pipeline. JavaScript becomes a witness target in the Library of Alexandria.

**Previous architecture:**
```
Clef PSG -> (skip middle-end) -> Oak-like JS AST -> JavaScript source
```

**JSIR architecture (general form):**
```
Clef PSG -> Alex MiddleEnd (MLIR) -> JSIR Backend -> JavaScript source
```

The exact architectural placement of JSIR relative to Alex is an open design question (see §4.1).

### 4.1 Open Design Question: Middle-End Catalog vs. Backend Separation

The precise relationship between Alex's MLIR dialects and JSIR is not yet determined. The current leaning is toward a clean backend separation (CIRCT model), but the middle-end may need some JavaScript-target-specific dialect treatment. The investigation will resolve this.

**Target profiles, not fundamentally different domains.** Clef's type system uses dimensional types with inference. When targeting native via LLVM, the compiler resolves concrete widths (i32, f64, etc.) based on the target architecture. When targeting JavaScript via JSIR, the same inference mechanism applies with JavaScript's default widths (Number, BigInt, typed array backing). JavaScript is a CPU-based runtime; it is another target profile, not a separate computational domain. The type inference system handles target-specific width resolution the same way for JavaScript as for ARM, x86, or an FPGA.

This significantly narrows the design space. If JavaScript is just another target profile for the same type inference machinery, there is less reason for a separate JavaScript-specific dialect catalog in Alex. The middle-end works in Clef's own type system with target-agnostic semantics. Width defaults are resolved by the target profile, not by dialect specialization.

**The CIRCT analogy holds, with caveats.** The clean model is: Alex does its work in Clef-native dialects, then hands MLIR off to a JSIR backend that consumes it and produces JavaScript. The backend may use TableGen for its own op definitions and lowering rules. This parallels how CIRCT separates its middle-end dialects (`hw`, `comb`, `seq`) from its SystemVerilog emission backend.

However, the investigation should remain open to the possibility that certain JavaScript-targeted PSG nodes from CCS benefit from distinct middle-end representation. This is not because JavaScript is a fundamentally different domain, but because some target-specific semantics (e.g., async/await patterns specific to V8, Durable Object lifecycle hooks, WebSocket hibernation) may warrant their own dialect treatment in the middle-end, similar to how CIRCT has domain-specific dialects above the backend. The key principle: do not break the model by forcing artificial similarity where target-specific representation serves the compilation better, but also do not fragment the middle-end unnecessarily when the type system's target profile mechanism handles the difference cleanly.

This is what the investigation is for.

**What is settled:**

1. **JSIR eliminates the need for a separate JavaScript toolchain.** Whether it sits as a backend or participates in the middle-end, JavaScript generation is part of Composer, not a side process.

2. **Fable becomes optional.** Clef targets JSIR (directly or through an intermediate JS-specific catalog). The Fable bridge for Fidelity.CloudEdge becomes a design specification, not a permanent dependency.

3. **The PSG enters Alex for JavaScript targets.** The original plan to bypass the middle-end entirely is superseded.

### 4.2 Transpose and Binding Generation

The current Fidelity.CloudEdge pipeline uses external code generators to produce F# bindings from foreign type definitions:

- **Glutinum**: TypeScript (`@cloudflare/workers-types`) → F# interfaces (Runtime Layer, 740+ types)
- **Hawaii**: OpenAPI (Cloudflare API spec) → F# REST clients (Management Layer, 32 services)
- **Xantham**: Additional binding generation

In the Clef world, these tools are replaced by the **Transpose** feature in the Atelier IDE. Transpose is a one-time conversion: it reads foreign type definitions (TypeScript, OpenAPI, or other languages) and ports them into Clef. After conversion, the result is a Clef library, maintained as Clef. The foreign source is an input to the conversion, not a live dependency.

Transpose is distinct from **Transcribe**, which ports application code (not just type definitions) from other languages into Clef. Both are one-time operations; neither is a live bridge or hot read. The foreign code enters Clef once and becomes Clef.

This means the CloudEdge binding generation pipeline (extract OpenAPI spec → segment → preprocess → generate → post-process → deploy) disappears as a build concern. The Cloudflare TypeScript SDK and OpenAPI spec are transposed into Clef libraries once. Those libraries are then compiled through Composer like any other Clef code.

---

## 5. Implications for Fidelity.CloudEdge and Cloudflare Workers

### Durable Object Instrumentation

The mailbox processor instrumentation pattern in Fidelity.CloudEdge, where the F# `MailboxProcessor` is intercepted to map onto Cloudflare's Durable Object lifecycle (fetch/alarm/storage, WebSocket hibernation), is currently expressed at the Fable output level. With JSIR in Alex, that instrumentation becomes an MLIR lowering pass. The Clef concurrency primitive lowers through Alex, hits a Cloudflare-specific pass that restructures it into the Durable Object pattern, then lowers to JSIR, which lifts to Worker source.

### JSX and SolidJS

JSX is not an IR concern. It is a backend emission concern. Solid's reactive primitives (`createSignal`, `createEffect`, `createMemo`) are JavaScript function calls. A Clef-level reactive construct (signal, effect, memo) lowers through a Solid-aware Alex pass that emits the correct call patterns as JSIR ops. Partas.Solid already demonstrates this model at the source language level. An additional set of back-end transforms can produce JSX syntax in the final output if desired for readability.

---

## 6. Implications for BAREWire and the Actor Network

### Unified Actor Model

With both native (LLVM) and Worker (JSIR) backends compiling from the same Clef source through the same Alex middle-end, the actor model is unified:

- Clef actors are defined once in the source language
- Alex decides per actor which backend: LLVM (native process) or JSIR (Cloudflare Worker / Durable Object)
- The actor's behavior is defined once; its deployment topology is a lowering decision

### BAREWire Contract Verification

BAREWire contracts are defined once at the MLIR level as dialect ops or attributes that both lowering paths consume:

- The native path lowers BAREWire to memory-mapped structs and IPC primitives
- The Worker path lowers BAREWire to WebSocket message serialization
- Both paths are verified against the same contract specification before codegen
- The wire format is identical because the contract is identical; only the transport differs

### Complete Infrastructure

A Clef actor network where one stratum runs as native processes and the other runs as Cloudflare Workers, with BAREWire contracts governing communication between them, constitutes a complete hybrid native/edge deployment infrastructure. One language, one IR, one verification framework, one binary protocol. The native and edge strata differ only in their final lowering target.

---

## 7. Practical Next Steps

### Immediate (Research Validation)

1. **Clone google/jsir, build via Docker**, feed it JavaScript resembling Fable output for a simple Cloudflare Worker (`fetch` handler, `async/await`, `Response` construction). Inspect the MLIR that comes out. This validates whether the op set maps naturally to Worker-shaped JavaScript.

2. **Read the TableGen dialect definitions** under the MLIR portion of the repo. These define every op, region structure, SSA semantics, and l-value/r-value distinction. This is the API surface for any lowering pass.

### Short-term (Prototype)

3. **Extract the dialect definitions** (TableGen files and C++ op implementations) and integrate them into the Clef/Alex MLIR build. The dialect is build-system agnostic; the Bazel dependency is for Google's tooling (parser, front-end), not for the dialect itself.

4. **Write a single lowering pass** from an Alex dialect op to JSIR ops (e.g., a let-binding or function definition). Walk the resulting JSIR to emit JavaScript source. Compare against Fable's output for the equivalent F# construct.

### Medium-term (Pipeline Integration)

5. **Use Fidelity.CloudEdge patterns as lowering pass specifications.** Every Worker instrumentation pattern already built in F#/Fable becomes a test case for the Clef -> Alex -> JSIR pipeline.

6. **Prototype BAREWire contract verification** at the MLIR level, operating on the IR before the native/JSIR fork point.

### Dependencies and Risks

- **Upstream status:** The RFC was posted today. JSIR may remain out-of-tree for some time. This does not block prototyping but affects long-term maintenance posture.
- **Analysis-oriented design:** Google built JSIR for lifting JavaScript into MLIR, not for lowering into it. The emission direction is uncharted but structurally sound (EmitC proves the pattern; Fable/js_of_ocaml prove the transformations).
- **No type system in JSIR:** Type erasure must happen before lowering to JSIR. This is standard for dynamically-typed targets but requires a clear decision point in the Alex pipeline.

---

## 8. Impact Analysis: Fidelity.CloudEdge Roadmap

This section maps JSIR's implications against the specific architecture, patterns, and phased roadmap documented in `Fidelity.CloudEdge/docs/`.

### 8.1 The MailboxProcessor Intercept (08c) Becomes a Lowering Pass Specification

The CloudEdge actor model intercepts F#'s `MailboxProcessor` semantics and maps them onto Durable Objects. The intercept surface is fully documented:

- `Post(msg)` → `actorRef.Tell(msg)` via WebSocket tell (fire-and-forget)
- `PostAndAsyncReply(f)` → `actorRef.Ask(msg)` via WebSocket ask with correlation ID
- `Receive()` → `Handle(msg)` override on `Olivier<'Msg>`
- `Start(body)` → implicit DO activation on first message
- `AsyncReplyChannel` → correlation-ID-based promise resolution
- `Error` event → `OnError(exn)` virtual method, propagated to supervising Prospero

In the current architecture, this intercept is an F#-level source transformation that Fable compiles to JavaScript. In the JSIR architecture, each row of that mapping table becomes a lowering pass rule inside Alex. The Clef concurrency primitive (whatever replaces `MailboxProcessor`) lowers through the middle-end, and a Cloudflare-target pass rewrites it into the Olivier/DO pattern. The semantic mapping is identical; the implementation moves from source-level rewriting to IR-level transformation.

The documented decision to discourage `TryReceive` and reject `Scan`/`TryScan` (08c §2-3) carries forward directly. Those are design constraints on the source language's actor primitives, not on the IR. The push-based timeout pattern (DO alarms as messages in the discriminated union) becomes the canonical lowering for Clef timeout constructs targeting Cloudflare.

### 8.2 The Dual-Layer Architecture Splits Cleanly Along the JSIR Boundary

Fidelity.CloudEdge's dual-layer architecture (00, 01) separates:

- **Runtime Layer**: In-Worker JavaScript interop (740+ types from `@cloudflare/workers-types` via Glutinum). Runs inside V8 isolates. Zero-latency platform access.
- **Management Layer**: External REST clients (32 services from OpenAPI via Hawaii). Runs anywhere: browser, native, .NET.

JSIR affects the Runtime Layer exclusively. The Management Layer is Fidelity.CloudEdge's own API client implementation, a set of pure F# REST clients built from Cloudflare's OpenAPI specifications. These clients handle all infrastructure provisioning, deployment, and orchestration without relying on any third-party CLI tooling. The planned `cfs` CLI and the code-first deployment pipeline (02_code_first_deployment.md) use these clients directly. Management operations do not execute inside Workers; they provision infrastructure externally via Fidelity.CloudEdge's own API surface. JSIR has no bearing on how the Management Layer is compiled.

The Runtime Layer, however, is the direct JSIR target. Every runtime binding (`D1Database.prepare`, `KVNamespace.get`, `R2Bucket.put`, `DurableObjectState.storage`, `WebSocket.send`) is currently a Glutinum-generated F# interface that Fable compiles to JavaScript interop calls. In the Clef/JSIR pipeline, these become known external function signatures that the Alex lowering pass emits as `jsir.call_expression` ops targeting the correct Cloudflare API surface. The 740+ runtime types become the type environment for the Worker-targeting lowering pass.

This is a clean split. The Management Layer is compiled by its own appropriate toolchain (Fable today, Clef native eventually) and deploys Workers, provisions Queues, creates D1 databases, configures secrets, and orchestrates the full infrastructure lifecycle through Fidelity.CloudEdge's own REST clients, not through any external CLI. The Runtime Layer migrates from Fable/Glutinum to Clef/Alex/JSIR. The two layers never intersected at the compilation level; they share a namespace convention but not a compilation path.

### 8.3 BAREWire Serialization (08b §3) Gets IR-Level Verification

The BAREWire frame format documented in 08b is:

```
┌──────────────┬──────────────┬───────────────┬──────────────┐
│ Frame Header │ Message Tag  │ Correlation ID│ Payload      │
│ (4 bytes)    │ (varint)     │ (optional)    │ (variable)   │
└──────────────┴──────────────┴───────────────┴──────────────┘
```

Discriminated union cases map directly to BAREWire tagged unions. Currently, the serializer is generated at compile time via a Fable plugin or source generator. In the JSIR pipeline, BAREWire serialization becomes expressible as MLIR ops within a BAREWire dialect. The schema derivation from Clef's type system (discriminated unions, records) happens at the MLIR level, and both the native (LLVM) and Worker (JSIR) lowering paths consume the same BAREWire dialect ops.

The critical property: a message serialized by a native Fidelity actor must be byte-identical to the same message serialized by a CloudEdge actor. Today, this is verified by testing. With BAREWire as an MLIR dialect, it can be verified structurally: both lowering paths consume the same BAREWire ops, and the schema is defined once before the compilation path forks. The native path lowers to memory-mapped structs; the Worker path lowers to `DataView`/`ArrayBuffer` operations emitted as JSIR ops. The byte layout is provably identical because both paths derive from the same IR representation.

This is the MLIR-level strengthening of the trust argument developed in [08b §3.4](08b_actor_core.md). That section establishes that BAREWire's binary wire format functions as the runtime type system in a dynamically-typed JavaScript environment: the message tag identifies the discriminated union case, the fixed payload layout per tag constrains deserialization, and an unrecognized tag is rejected before actor dispatch. The type safety of the source language is preserved not in JavaScript's (absent) type metadata, but in the byte structure of the protocol. In the current Fable-based architecture, the trust that both the sender's serializer and the receiver's deserializer agree on the byte layout depends on both being compiled from the same F# source — an invariant maintained by the build system. JSIR strengthens this: both lowering paths consume the same BAREWire dialect ops in the shared MLIR middle-end. Agreement on the byte layout is a structural property of the IR, not an invariant that must be separately maintained.

### 8.4 Olivier/Prospero Supervision (08a, 08b §5) Maps to Target-Specific Lowering

The supervision tree structure:

```
Prospero: "session-supervisor"
├── Olivier: "session-user-alice"
├── Olivier: "session-user-bob"
└── Prospero: "chat-room-supervisor"
    ├── Olivier: "room-general"
    └── Olivier: "room-engineering"
```

Each node is a Durable Object. Each edge is a WebSocket. With JSIR in Alex, the supervision tree definition is a Clef-level construct. The lowering pass for the Cloudflare target emits:

- `Olivier<'Msg>` → Durable Object class with `webSocketMessage` handler, `OnActivate`/`OnStop` lifecycle hooks, and `Handle(msg)` dispatch
- `Prospero<'Msg>` → Durable Object class with child registry, WebSocket heartbeat monitoring, and supervision strategy dispatch
- `ActorRef<'Msg>` → routing logic that dispatches `Tell` to `ws.send(frame)` and `Ask` to correlation-ID promise resolution
- Supervision strategies (`OneForOne`, `OneForAll`, `RestForOne`) → WebSocket close/reconnect sequences against DO stubs

The native lowering pass for the same supervision tree definition emits OS-level process management, shared memory IPC, and signal-based lifecycle coordination. The developer writes the supervision tree once. The target determines the infrastructure.

### 8.5 Elastic Scaling (08a §Elastic Scaling) and Worker Loader

The elastic scaling pattern is supervision-level infrastructure:

1. Normal: Sender → WebSocket → single Olivier
2. Under load: Sender → Prospero → Queue → N replica Oliviers

The `ReplicaStrategy` distinguishes between `Isolate` (Worker Loader, lightweight, stateless, millisecond startup) and `DurableObject` (full DO, stateful, heavier).

In the current model, the Prospero's scaling logic loads the actor's Fable-compiled JavaScript module via `env.ACTOR_LOADER.get(...)`. In the JSIR model, the compiled JavaScript for each actor class is a JSIR lowering output. The Worker Loader binding loads the same artifact. The change is upstream: the artifact is produced by Clef/Alex/JSIR instead of F#/Fable.

The Queue pivot logic (redirect messages from WebSocket to Queue, spawn consumers, monitor depth, drain and converge) is pure Cloudflare runtime API usage. It lowers to `jsir.call_expression` ops against Queue bindings, the same way any other runtime API call does.

### 8.6 Event Sourcing and Persistence (08d) Are IR-Transparent

The `PersistentOlivier<'Msg, 'Event, 'State>` pattern (command/event separation, journal, snapshots, recovery) is an application-level concern built on top of the actor substrate. It does not interact with the compilation pipeline at the level JSIR operates. The journal writes BAREWire-encoded entries to DO transactional storage. The snapshot saves BAREWire-encoded state. Recovery replays the journal via `ApplyEvent`.

All of this compiles to JavaScript function calls against `state.storage.put`/`get`/`transaction`. Whether those calls are emitted by Fable or by a JSIR lowering pass is transparent to the persistence model. The BAREWire encoding is the only persistence-level concern that benefits from MLIR-level treatment (§8.3).

### 8.7 Management Infrastructure Provisioning (08e) Is Unaffected

The 11-step provisioning orchestration (Worker upload, DO namespace verification, Queue provisioning, KV namespaces, D1 databases, R2 buckets, Logpush jobs, secrets, Access policies, tunnels, cron triggers) operates entirely through Fidelity.CloudEdge's own Management Layer REST clients. These are Fidelity's API clients calling the Cloudflare Management API directly, no external CLI tooling is involved. The `cfs` CLI and the code-first deployment model (doc 02) are the deployment interface. JSIR does not affect this layer.

The `ActorSystemManifest` type (08e §9) that drives provisioning orchestration is a Clef-level construct in the JSIR world. The deployment module reads the manifest (actor classes, scaling policies, persistence requirements) and invokes the Management Layer's API clients. The manifest structure benefits from being defined in the same Clef type system that defines the actors, ensuring that the provisioning spec and the runtime code are type-checked against each other.

The JSIR backend's relationship to the Management Layer is analogous to how CIRCT relates to Vivado or MLIR-AIE relates to Vitis: the compiler emits the artifact (JavaScript via JSIR), and the framework's own deployment infrastructure (the Management Layer, the `cfs` CLI, the `ActorSystemManifest`-driven pipeline) handles the downstream deployment. The deployment tooling is Fidelity's, not a third-party concern.

### 8.8 Cross-Substrate Architecture (08a §Cross-Substrate, 08b §6.2)

The documented cross-substrate vision:

```
Native Fidelity Cluster                    Cloudflare Edge
┌─────────────────────┐                    ┌──────────────────┐
│  Prospero (native)  │◀──BAREWire/WS──▶  │  Worker (bridge)  │
│       │              │                    │       │           │
│  Olivier (native)   │                    │  Prospero (DO)    │
│  Olivier (native)   │                    │       │           │
└─────────────────────┘                    │  Olivier (DO)     │
                                           │  Olivier (DO)     │
                                           └──────────────────┘
```

This is the endgame that JSIR makes architecturally coherent. Both sides compile from Clef through Alex. The native cluster lowers through LLVM. The Cloudflare edge lowers through JSIR. The bridge Worker is a JSIR-compiled Clef module that holds a WebSocket to the native cluster and translates between transport mechanisms. BAREWire is the seam; it is defined once in the IR, verified once, and lowered to the appropriate serialization code on each side.

The `ActorRef<'Msg>` dispatch:

```fsharp
type ActorRef<'Msg> =
    | Local of MailboxProcessor<'Msg>           // Native (in-process)
    | Edge of actorId: string * transport: IActorTransport  // Cloudflare (WS to DO)
    | Remote of endpoint: Uri * actorId: string // Cross-substrate (WS or MoQ)
```

In the JSIR world, this discriminated union is defined in Clef and lowered differently per target. On the native side, `Local` is a direct function call; `Edge` and `Remote` lower to BAREWire-over-WebSocket/QUIC. On the Cloudflare side, `Edge` is a `DurableObjectStub.fetch()` or WebSocket frame; `Remote` is a WebSocket to the native cluster. The dispatch logic is written once. The communication primitives are target-specific lowerings.

### 8.9 Roadmap Phase Mapping

The documented implementation phases (08a) map to JSIR integration as follows:

| Phase | Current (Fable) | With JSIR in Alex |
|-------|-----------------|-------------------|
| **Phase 1: Foundation** (Olivier, ActorRef, BAREWire, lifecycle) | F# actor types compiled by Fable. BAREWire serializer generated by Fable plugin. | Clef actor types lowered through Alex. BAREWire ops in MLIR dialect. JSIR emits Worker JS. |
| **Phase 2: Supervision** (Prospero, strategies, heartbeat) | F# supervision logic compiled by Fable. WebSocket management in JS interop. | Same logic, lowered through Alex. WebSocket ops are `jsir.call_expression` against DO API. |
| **Phase 3: Persistence** (PersistentOlivier, journal, snapshots) | F# event sourcing compiled by Fable. Storage calls via Glutinum bindings. | Same model. Storage calls lower to JSIR ops. BAREWire encoding verified at IR level. |
| **Phase 4: Observability** (Analytics Engine, Diagnostics Channel) | F# instrumentation compiled by Fable. `writeDataPoint()` via JS interop. | Same instrumentation, lower to JSIR. No architectural change. |
| **Phase 5: Developer Experience** (migration guide, tooling) | MailboxProcessor migration from F# to CloudEdge F#. | Clef actor primitives; no migration needed. The actor model is native to the language. |
| **Phase 6: Cross-Substrate** (BAREWire bridge, unified ActorRef, MoQ) | Requires manual alignment between native and Fable-compiled serializers. | Single BAREWire dialect in MLIR. Structural verification before lowering fork. Byte-identical wire format guaranteed by construction. |

Phase 6 is where JSIR delivers the most value. Cross-substrate coherence is the hardest problem in the current architecture because it depends on two separate compilation paths (Fidelity native and Fable) producing byte-compatible BAREWire output. With both paths originating from the same MLIR representation, this compatibility becomes a property of the IR, not of testing.

---

## 9. Key Sources

- JSIR GitHub Repository: https://github.com/google/jsir
- JSIR RFC (LLVM Discourse): https://discourse.llvm.org/t/rfc-jsir-a-high-level-ir-for-javascript/90456
- JSIR Tech Talk Slides (LLVM Dev Meeting 2024): https://llvm.org/devmtg/2024-10/slides/techtalk/Tan-JSIR.pdf
- Phoronix Coverage: https://www.phoronix.com/news/Google-LLVM-JavaScript-IR-JSIR
- 2022 emitjs RFC (LLVM Discourse): https://discourse.llvm.org/t/rfc-mlir-web-related-dialect-proposal/65690
- WAMI Paper (WebAssembly through MLIR): https://arxiv.org/html/2506.16048v1
- EmitC Dialect (LLVM Source): https://codebrowser.dev/llvm/mlir/lib/Dialect/EmitC/
- MLIR ODS Documentation: https://mlir.llvm.org/docs/DefiningDialects/Operations/
