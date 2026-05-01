# Fidelity.CloudEdge Actor Model: Agents Overlay Design

> Part of the [Actor Model Design](08a_actor_model_overview.md) series.

**SpeakEZ Technologies | Fidelity Framework**
**May 2026 | Pre-Generation Design Document**

This document frames how Cloudflare's Agents framework and Dynamic Workflows package compose with the existing Fidelity.CloudEdge surface, *before* binding generation begins. The objective is design-time coherence: when the F# bindings are produced, an application author should see one unified Cloudflare-on-F# surface that hangs together rather than a stack of independently-generated layers that the author has to reconcile.

The decision to split the new content into `Fidelity.CloudEdge.Agents` (and likely `Fidelity.CloudEdge.Workflows`) keeps each layer's identity clear without fragmenting the developer experience. This document specifies the surface conventions that make that work.

**The foundational context** is the `MailboxProcessor → Durable Object` mapping documented in [08c_mailbox_intercept.md](./08c_mailbox_intercept.md). `Olivier<'Msg>` is F#'s `MailboxProcessor` reincarnated on Cloudflare's Durable Objects, with full API surface mapped (`Post → Tell`, `PostAndAsyncReply → Ask`, `Receive → Handle`, etc.). This is the substrate-level "flex" that makes Cloudflare a viable target for actor-shaped agentic workloads at all. The agents overlay rides on this substrate; everything below builds on the assumption that the actor model is already present, working, and substrate-transparent (native or DO with the same source-level API).

## What's Being Wrapped

This document scopes a subset of the broader Fidelity.CloudEdge coverage gaps catalogued in [03_gap_analysis.md](03_gap_analysis.md) — specifically the agentic-workload binding surface. The 0.3.0 release closes additional gaps documented there (workers-types refresh, Workflows V2 OpenAPI refresh) that aren't unique to the agentic story. This document focuses on the binding considerations that are unique to the Agents framework and Dynamic Workflows.

Three distinct npm packages produce the surface this overlay covers:

- **`@cloudflare/agents`** (the `Think<Env>` framework with lifecycle hooks). The core agentic abstraction. Lives in `cloudflare/agents` repo, separate from `workerd`. Tracked as gap G3 in [03_gap_analysis.md](03_gap_analysis.md).
- **`@cloudflare/dynamic-workflows`** (~300 lines, published May 1, 2026). Multi-tenant workflow dispatch routing. Built on Workflows V2. Tracked as gap G4 in [03_gap_analysis.md](03_gap_analysis.md).
- **`@cloudflare/workers-types`** Workflows V2 runtime types (in the latest version of the existing types package). Tracked as gap G1.

Plus the platform-level changes that the OpenAPI side will pick up:
- **Workflows V2 management endpoints** (concurrency limits, instance scaling). Tracked as gap G2.
- **Dynamic Workers management endpoints** (if exposed in OpenAPI). Tracked as gap G5.

The Agents framework is the most architecturally consequential of these. It is, in the user's framing, "kinda the entire reason to be excited about Cloudflare as a delivery platform for agentic workloads." Getting its F# expression right is what this document is about.

Tooling considerations specific to generating F# bindings from these TypeScript packages are documented in [06_tool_status.md](06_tool_status.md). The 0.3.0 release shipped these bindings as hand-curated `Types.fs` files because Glutinum crashed on the surface; per [00 Decision 7](00_architecture_decisions.md), Fidelity.CloudEdge has standardized on **Xantham** as the runtime binding generator going forward. Xantham handles the agents-sdk surface cleanly (where Glutinum did not). The hand-curated bindings will be replaced by Xantham-generated output once the renderer issues documented in [06](06_tool_status.md) are resolved. This document focuses on the F# author-facing API design; that one focuses on the binding generator's mechanics.

## The Composition Layers

```
Application code (F# today, Clef in the Composer-via-JSIR future)
    │
    ▼
Fidelity.CloudEdge.Agents               ← Think<'Env>, lifecycle hooks, tools, sessions
    │
    ▼
Fidelity.CloudEdge.Workflows            ← Dynamic Workflows, V2 dispatch, durable steps
    │
    ▼
Fidelity.CloudEdge (existing)           ← Worker, DO, KV, R2, D1, Queues, services
    │
    ▼
@cloudflare/agents + dynamic-workflows + workers-types  ← npm packages
```

Each layer uses the layer below it. None of them duplicate one another. An agent uses a workflow when it needs durable execution; a workflow uses a DO when it needs persistence; a DO uses KV/R2/D1 when it needs storage. The layering matches Cloudflare's own product architecture.

The split between packages is not arbitrary. Each layer has a different generation pipeline:

- `Fidelity.CloudEdge` (existing): Hawaii-from-OpenAPI for Management, Xantham-from-`.d.ts` for Runtime (Glutinum-generated for the legacy `Worker.Context` and `AI` bindings until they migrate).
- `Fidelity.CloudEdge.DynamicWorkflows`: Xantham-from-`@cloudflare/dynamic-workflows` for the runtime surface; Hawaii-from-OpenAPI for any Management endpoints exposed for Workflows V2.
- `Fidelity.CloudEdge.Agents`: Xantham-from-`agents-sdk` for the Agent / Think classes and lifecycle hooks, plus authored F# helpers that aren't 1:1 with the underlying TypeScript.

## The Lifecycle Hooks: F# Surface Mapping

The Cloudflare `Think<Env>` class exposes ten lifecycle hooks. Each is a TypeScript method with a context parameter and an optional return type. The async/sync polymorphism (`T | Promise<T>`) is normalized in the F# binding to `Async<'T>` for consistency with F# conventions; sync hooks become `Async.singleton`-wrapped where needed.

### Hooks as Virtual Methods

The natural F# expression is a base class with virtual methods that the application overrides:

```fsharp
type ChatAgent<'Env>() =
    inherit Think<'Env>()

    override this.ConfigureSession(session: Session) : Async<Session> = async {
        // configure context blocks, memory
        return session
    }

    override this.BeforeTurn(ctx: TurnContext) : Async<TurnConfig option> = async {
        // override model, system prompt, tools per-turn
        return Some { TurnConfig.empty with Model = Some myModel }
    }

    override this.BeforeToolCall(ctx: ToolCallContext) : Async<ToolCallDecision> = async {
        match ctx.ToolName with
        | "delete_user_account" when not (isAuthorized ctx) ->
            return ToolCallDecision.Block "unauthorized"
        | _ ->
            return ToolCallDecision.Allow
    }

    override this.OnChunk(ctx: ChunkContext) : Async<unit> = async {
        // streaming token handling
        do! emitToWebSocket ctx.Chunk
    }
```

Hooks not overridden inherit no-op defaults from the base class. This matches how F# developers expect optional behavior to work and keeps applications declarative — only the hooks the application actually cares about appear in the source.

### Async/Sync Normalization

TypeScript's `T | Promise<T>` becomes F# `Async<'T>` uniformly. The cost of wrapping a sync result in `Async.singleton` at the binding boundary is negligible compared to the consistency benefit. F# developers expect side-effecting work to compose through `async { ... }` regardless of whether each step happens to be synchronous.

### `void` Returns

TypeScript `void` returns map to F# `unit`. TypeScript `void | T` (where the hook can return either nothing or a config) becomes F# `Option<'T>`:

```fsharp
override this.BeforeTurn(ctx: TurnContext) : Async<TurnConfig option>
//                                                     ^^^^^^^
//                                              None to use defaults; Some to override
```

This is more F#-idiomatic than mirroring the TypeScript void/T union.

## Discriminated Unions

The TypeScript surface contains several string-literal-tagged unions that map directly to F# discriminated unions. These are the highest-value mappings — pattern matching on these is where F#'s ergonomics shine versus TypeScript's `if (x.action === "allow")` patterns.

### `ToolCallDecision`

TypeScript:
```typescript
| void
| { action: "allow" }
| { action: "allow"; input: unknown }
| { action: "block"; reason?: string }
| { action: "substitute"; output: unknown; input?: unknown }
```

F#:
```fsharp
type ToolCallDecision<'Input, 'Output> =
    | Allow
    | AllowWithInput of input: 'Input
    | Block of reason: string option
    | Substitute of output: 'Output * input: 'Input option
```

The `unknown` typed inputs/outputs become generic parameters (`'Input`, `'Output`) when the binding can carry them; for fully untyped use, the application can reach for `JsValue` (the typed-DU representation of JavaScript's value space documented in the [javascript-targeting docs](../../Composer/docs/javascript-targeting/06_obj_and_null_at_the_boundary.md)) but the typed shape is preferred and should be the default the binding generator emits.

### `ChatResponseResult.status`

TypeScript: `status: "completed" | "error" | "aborted"`

F#:
```fsharp
type ChatStatus =
    | Completed
    | Error of message: string
    | Aborted
```

The `error?: string` field gets folded into the `Error` case rather than being a separate optional field, since it's only meaningful when status is `error`.

### Stream Chunk Types

TypeScript: `Extract<TextStreamPart<TOOLS>, { type: "text-delta" | "reasoning-delta" | ... }>`

F#:
```fsharp
type StreamChunk<'ToolInput, 'ToolOutput> =
    | TextDelta of text: string
    | ReasoningDelta of text: string
    | Source of url: string * title: string option
    | ToolCall of id: string * name: string * input: 'ToolInput
    | ToolInputStart of id: string * name: string
    | ToolInputDelta of id: string * delta: string
    | ToolResult of id: string * output: 'ToolOutput
    | Raw of value: JsValue
```

The `Raw` case provides the escape hatch for chunk types not yet modeled or framework-specific extensions, using `JsValue` (the schema-directed narrowing approach) so the application can pattern-match on whatever shape it is.

## Tool Definitions

Tools are central to the agentic loop and are where typed F# pays its largest dividends. The TypeScript `ToolSet` is essentially a record of named tool definitions, each with a typed input schema (often Zod), output type, and execution function.

The F# binding should express a tool as a typed record:

```fsharp
type Tool<'Input, 'Output> = {
    Name: string
    Description: string
    InputSchema: JsonSchema<'Input>
    Execute: 'Input -> Async<'Output>
}
```

A tool set is then a heterogeneous collection. Two reasonable F# encodings:

**Option A: Record of typed fields (when tool set is fixed at compile time):**
```fsharp
type MyTools = {
    Search: Tool<SearchInput, SearchOutput>
    SendEmail: Tool<EmailInput, EmailOutput>
    LookupUser: Tool<UserId, User>
}
```

**Option B: Heterogeneous map (when tool set is dynamic):**
```fsharp
type ToolSet = Map<string, ToolBox>
and ToolBox = abstract Execute : JsValue -> Async<JsValue>
```

The first option is the F# idiom and should be the default. The second is the escape hatch for plug-in scenarios where the tool set is supplied dynamically (which the Dynamic Workflows pattern enables explicitly).

The schema for a tool's input becomes a `JsonSchema<'Input>` record that Composer's binding generator derives from the F# type definition. This is the schema-directed narrowing pattern from the JavaScript-targeting docs applied to tool inputs: the F# type declares the expected shape; the validator runs at the runtime boundary; bad input becomes a typed error before `Execute` is called.

## Sessions and Memory

`configureSession` returns a `Session` that the agent uses for context blocks and memory across turns. The Session type isn't fully specified in the docs we have, but the integration question is clear: where does Session state live, and how does it compose with Fidelity.CloudEdge's existing storage bindings?

The natural answer:

```fsharp
type Session = {
    ContextBlocks: ContextBlock list
    Memory: Memory
}

and Memory =
    | InMemory of state: 'State                    // ephemeral, per-isolate
    | DurableObject of stub: DurableObjectStub<'State>  // persistent, per-DO
    | KvBacked of namespace: KVNamespace * key: string  // persistent, distributed
```

This makes the persistence story explicit: the application chooses where memory lives, and the Memory variant determines which existing Fidelity.CloudEdge binding handles persistence. An InMemory session is local to one isolate; a DurableObject-backed session uses our existing `DurableObjectStub<'T>` typing; a Kv-backed session uses our existing KVNamespace bindings. The Agents overlay does not duplicate storage — it composes with what's already in the core package.

## Composition with Workflows

A Think agent can dispatch durable work to a Workflow. The connection point is the agent invoking a Workflow binding from within a hook (typically `beforeStep` or as part of a tool's execution).

Workflows V2's runtime surface is largely the same as V1 from the binding perspective: a `WorkflowBinding<'Event, 'Result>` with `create`, `get`, and instance management methods. The breaking-change concern is on the management API side (the OpenAPI regen will pick up the V2 endpoints).

Dynamic Workflows adds a dispatch dimension: rather than calling a fixed `env.MY_WORKFLOW.create()`, the agent can route to per-tenant workflow code via a `DynamicWorkflowBinding`. The F# binding for this:

```fsharp
type DynamicWorkflowBinding<'Event, 'Result> = {
    Dispatch: tenantId: string -> event: 'Event -> Async<WorkflowInstance<'Result>>
    Wrap: tenantMetadata: TenantMetadata -> WorkflowBinding<'Event, 'Result>
}
```

The `Dispatch` method routes to the named tenant's workflow code; `Wrap` produces a per-tenant binding stub that an agent can hold onto and use as if it were a fixed binding. From the F# code's perspective, once you've wrapped the binding with the tenant identity, downstream calls look the same as a fixed-binding call. This matches the way Cloudflare's TypeScript API hides the routing detail behind `wrapWorkflowBinding`.

## The Actor Substrate: MailboxProcessor → Durable Object

Before discussing how Think composes with the rest of the framework, this layer needs naming explicitly because it is the foundational "flex" that makes Cloudflare a viable substrate for agentic workloads in the first place.

**`Olivier<'Msg>` is F#'s `MailboxProcessor<'Msg>` reincarnated as a Durable Object.** This is documented in detail in [08c_mailbox_intercept.md](./08c_mailbox_intercept.md). The full API surface of `MailboxProcessor` maps onto `Olivier`: `Post(msg)` becomes `actorRef.Tell(msg)`; `PostAndAsyncReply(f)` becomes `actorRef.Ask(msg)`; `Receive()` becomes the overridden `Handle(msg)` dispatch; `Start(body)` becomes implicit DO activation; the `Error` event becomes the `OnError(exn)` virtual method. Existing F# code using `MailboxProcessor` migrates to `Olivier` mechanically — the conversion is largely a name change at the call sites and a class restructuring at the actor definition. The application logic does not change.

This matters because it means **Cloudflare's Durable Objects become the deployment target for the F# actor model already in production**. Fable's compilation of `MailboxProcessor` to JavaScript is fragile — Fable's internal queue management loses coherence after several hundred messages because JavaScript's cooperative scheduling violates the MBP's sequential-processing assumption. Fidelity.CloudEdge's intercept sidesteps this entirely: the actor's sequential-processing guarantee comes from Cloudflare's runtime scheduler (infrastructure-enforced single-concurrency on the DO), not from Fable's user-space queue manipulation. The result is an actor model where the F# semantics hold rigorously, on a substrate that scales horizontally across Cloudflare's edge network.

**This is the either/or for agentic workloads.** A Fidelity application that wants actor-shaped agentic execution has two first-class substrate choices:

- **Native Clef path.** Composer compiles Clef actors to native binaries. The actor substrate is delimited continuations (or LLVM coroutines as the interim) running on OS threads, with IPC for inter-actor communication.
- **Cloudflare DO path.** F# `MailboxProcessor` (today) or Clef actors (post-JSIR) compile to Durable Objects via the Olivier intercept. The actor substrate is Cloudflare's DO runtime; communication is WebSocket-framed BAREWire.

Both paths expose the same actor semantics. An `ActorRef<'Msg>` resolves to a local in-process actor on native, a DO stub on Cloudflare, or a remote endpoint when the two substrates communicate. The application code does not change between substrates. The deployment topology decides where each actor runs; the actor model is the bridge that makes the topology decision orthogonal to the application logic.

This is what the user-facing "flex" looks like in practice: the same F# (or eventually Clef) actor code runs on bare metal as a native process, on Cloudflare as a Durable Object, or on a hybrid where some actors live native and others live edge. BAREWire ensures byte-identical message layout across substrates. The substrate transparency principle is what [08a_actor_model_overview.md](./08a_actor_model_overview.md) calls "cross-substrate coherence," and it is what makes the agents overlay tractable: the agentic layer doesn't have to solve the actor problem because the actor problem is already solved.

## How Olivier Layers on Agent: The Collapsed Architecture

Earlier drafts of this design moved through two unsatisfactory framings before landing here. The first framing — "Think runs *inside* an Olivier actor" — was wrong because Cloudflare's `Agent<Env, State>` is itself a Durable Object subclass; you can't host a DO inside another DO. The second framing — "Olivier and Agent are sibling DO classes that interoperate as peers" — was correct as far as it went, but missed the more useful collapse: since Agent already provides everything Olivier-as-its-own-DO-subclass would have to implement (hibernation, state, WebSocket lifecycle, RPC), Olivier should rebase onto Agent rather than parallel it.

**The right architecture is Olivier as an F# source-level facade over Cloudflare's `Agent` class on the edge side, and over native concurrency primitives on the native side.** The MailboxProcessor migration story stays at the F# source level; the DO implementation it produces extends `Agent`.

### What Cloudflare's Hierarchy Actually Looks Like

```
DurableObject               (workerd runtime base)
    └── Agent<Env, State>   (Cloudflare Agents framework: stateful DO with sync, RPC, WebSocket, hibernation)
            └── Think<Env>  (chat-specific subclass: agentic loop, tools, streaming)
                    └── ChatAgent  (application code)
```

The canonical TypeScript example shows the pattern directly:

```typescript
export class CounterAgent extends Agent<Env, { count: number }> {
  initialState = { count: 0 };

  @callable()
  increment() {
    this.setState({ count: this.state.count + 1 });
    return this.state.count;
  }
}
```

And the wrangler binding:

```json
"durable_objects": {
  "bindings": [{ "name": "CounterAgent", "class_name": "CounterAgent" }]
}
```

Agent provides the substrate work that Olivier-as-its-own-DO-subclass would have had to implement: hibernation across requests, persistent state via `setState`/`initialState`, WebSocket lifecycle (`onConnect`/`onMessage`/`onClose`), RPC over WebSocket via `@callable()`, automatic state sync to clients connected via the `useAgent` hook. Re-implementing any of this in Fidelity is engineering effort that competes with Cloudflare's ongoing investment and falls behind every time they ship a new feature.

### What Olivier Becomes

Olivier is preserved at two levels:

1. **As an F# source-level API.** Application authors still write `inherit Olivier<'Msg>`, define `Handle(msg)` overrides, and call `actorRef.Tell(msg)` / `actorRef.Ask(msg)`. The MailboxProcessor migration story documented in [08c](./08c_mailbox_intercept.md) is unchanged. F# developers see `Tell`, `Ask`, `Handle`, `Reply`, `OnError`, supervision — the actor-shaped semantics they expect.

2. **As an F# binding generator that emits Agent-extending classes for Cloudflare deployment.** When the F# code is compiled for the Cloudflare target, the Olivier base class lowers to a generated F# class that extends `Agent<Env, State>`. Tell/Ask/Handle are F# methods implemented over Agent's primitives:
   - `Tell(msg)` writes a BAREWire-encoded frame via `connection.send` over Agent's WebSocket, no correlation ID.
   - `Ask(msg)` writes a frame with a correlation ID, awaits a matching response frame.
   - `Handle(msg)` is the F# override that the binding routes to from Agent's `onMessage` (after BAREWire decoding) for raw frames, and from `@callable` decorated methods (when applications choose RPC-shaped invocations).
   - State is persisted through Agent's `setState` for state-sync-to-clients use cases or directly through `state.storage` for per-actor invisible storage; `PersistentOlivier`'s journal still uses `state.storage` as the underlying transactional store.
   - Supervision lifecycle (Prospero) talks to Olivier-as-Agent-extending-DOs the same way it would talk to any DO; the supervisor doesn't care that the supervised class extends Agent rather than DurableObject directly.

On the native side, the same `inherit Olivier<'Msg>` source compiles via Composer (post-JSIR) or via Fable (today) to a native concurrency primitive (native MailboxProcessor today, native delimited continuations once Composer's DCont dialect is in production). Cross-substrate transparency at the source level is preserved.

### What Each Layer Is Responsible For

| Layer | Responsibilities | Implementation |
|:------|:-----------------|:---------------|
| F# application code | Define actor messages (DUs), override `Handle`, set up supervision | Author's F# source |
| F# Olivier facade | Provide Tell/Ask/Handle/Reply/OnError surface; map to substrate primitives | Generated F# helpers + binding generator |
| Cloudflare side | Hibernation, state, WebSocket, RPC, `setState` sync, `@callable` ergonomics | `extends Agent<Env, State>` (Cloudflare's framework) |
| Native side | OS-thread or coroutine concurrency, IPC, supervised lifecycle | Native MailboxProcessor / Composer DCont |
| Wire format | Cross-actor and cross-substrate communication | BAREWire frames over WebSocket, MoQ, IPC |

**Olivier is no longer its own DO subclass.** It is a F# convention layer that sits on top of either Cloudflare's Agent (when targeting Cloudflare) or native concurrency (when targeting native). The framework code that previously implemented hibernation, state, and WebSocket lifecycle for Olivier-as-DO is replaced by binding-generator code that emits an `extends Agent<Env, State>` class with F# methods that delegate to Agent's primitives.

### Two Authoring Styles, One Substrate

Within the Cloudflare side, application authors have two F# authoring styles, both producing classes that extend Agent under the hood:

**Style A: Olivier-shaped F# (MailboxProcessor migration target).**
The application writes `inherit Olivier<'Msg>` at the F# source level. The binding generator emits an Agent-extending class. Tell/Ask/Handle semantics are exposed; BAREWire is the default wire format; supervision via Prospero applies. This is what existing F# MailboxProcessor code migrates to, mechanically.

```fsharp
type CounterMsg =
    | Increment
    | Add of int
    | GetCount

type CounterActor() =
    inherit Olivier<CounterMsg>()

    let mutable count = 0

    override this.Handle(msg) = async {
        match msg with
        | Increment -> count <- count + 1
        | Add n -> count <- count + n
        | GetCount -> this.Reply count
    }
```

The generator emits a Cloudflare DO class that `extends Agent<Env, { count: number }>` with `onMessage` decoding BAREWire frames, `Handle` dispatching them, and `setState` updating the count in a way that hibernates correctly. The author's F# never references Agent directly; the substrate is invisible.

**Style B: Cloudflare-native F# (typed wrapper over Agent/Think).**
The application writes `inherit Agent<Env, State>` (or `inherit Think<Env, State>`) directly, using the F# bindings generated for Cloudflare's framework. State is managed via `SetState`/`InitialState`; methods marked `[<Callable>]` are exposed as RPC; lifecycle hooks (`OnConnect`, `OnMessage`, `OnRequest`, plus Think's chat-specific hooks) are F# overrides. This is what F# developers writing Cloudflare-native AI agents use.

```fsharp
type ChatState = { History: ChatMessage list; Preferences: Preferences }

[<DurableObjectClass>]
type ChatAgent() =
    inherit Think<Env, ChatState>()

    override this.InitialState = { History = []; Preferences = Preferences.defaults }

    override this.ConfigureSession(session) = async {
        return { session with Tools = SearchTools.standardSet }
    }

    override this.OnChunk(ctx) = async {
        do! Telemetry.recordChunk ctx.Chunk
    }

    [<Callable>]
    member this.Increment() =
        this.SetState { this.State with History = increment :: this.State.History }
```

Both styles compile to `extends Agent<Env, State>` underneath. The F# author chooses based on which surface fits the application: Olivier-shaped for actor-style code (especially migrating from MailboxProcessor), Cloudflare-native for net-new agentic code that wants framework conveniences (state sync, useAgent hook, lifecycle hooks for streaming) directly.

The two styles are interoperable. An Olivier and a Think can communicate as peers (BAREWire frames over WebSocket between two DOs is symmetric whether one extends the F# Olivier facade and the other extends F# Think directly), but the more interesting fact is that they produce structurally similar JavaScript artifacts because both ultimately compile to Agent-extending DO classes. The typed-actor and Cloudflare-native idioms ride on the same substrate, with style being an authoring preference rather than an architectural commitment.

### What's Preserved, Lost, and Gained

**Preserved:**
- Source-level MailboxProcessor migration story (Olivier-shaped F# API). [08c](./08c_mailbox_intercept.md) remains valid.
- Substrate transparency at the source level: same Olivier F# source runs native or edge.
- BAREWire as the wire format convention. Cross-substrate byte-identity property is unchanged.
- Prospero supervision as an F#-level pattern. Supervisors talk to supervised DOs through their lifecycle endpoints; the substrate beneath the supervised DOs is irrelevant.
- Tell-first semantics on the wire. Implemented over Agent's `onMessage` raw transport, not over `@callable` (which is RPC-shaped).
- The Akka.NET interop angle (BAREWire serializer plugin + stateless gateway Worker).

**Lost:**
- A separate DO subclass hierarchy. `Olivier-as-its-own-DO-class` disappears as a structural concept; it becomes an F# convention layer over Agent.
- Self-implemented hibernation, state, WebSocket lifecycle plumbing. Cloudflare's framework provides it.
- Implementation freedom on Cloudflare-specific lifecycle details (the F# facade has to fit Agent's lifecycle semantics, e.g., the `onConnect`/`onMessage`/`onClose` ordering).

**Gained:**
- Every Cloudflare investment in Agent shows up as binding work, not framework work. State sync, the `useAgent` hook, hibernation refinements, scaling improvements, future Agent features arrive in F# bindings with minimal effort.
- Less framework code to maintain. `Fidelity.CloudEdge.Actor` becomes a thinner library — primarily F# helpers, the BAREWire convention, and the binding generator that emits Agent-extending classes.
- Cleaner story for the Cloudflare-native authoring style — applications that want Think directly use F# bindings for it, no friction.
- Convergence with Cloudflare's evolving primitives rather than divergence.

### One Genuine Asterisk: Tell-First on Agent's Transport

Cloudflare's Agent emphasizes RPC via `@callable()` and state-sync via `setState`. Tell-first messaging (BAREWire-typed binary frames over WebSocket without correlation IDs) is supported but isn't the convention Agent's documentation foregrounds. The Olivier facade preserves tell-first by routing through Agent's `onMessage` raw WebSocket handler, decoding BAREWire frames, and dispatching to `Handle`. This works — Agent's `onMessage` is general — but it means the Olivier facade owns the BAREWire decode/dispatch logic itself rather than getting it for free from the framework. The implementation cost is small (a few hundred lines of F# in the binding generator), but it is non-zero.

This is the load-bearing part of Olivier's continued existence: tell-first BAREWire-typed messaging is what differentiates the F# actor-shaped style from the Cloudflare-native RPC-shaped style. Without it, there'd be no reason for the Olivier facade — applications would just use F# bindings on Agent directly. With it, F# applications get to choose actor-shaped or RPC-shaped per actor while sharing the substrate.

## The Three Reference Scenarios

To validate that the framing produces a coherent design-time experience, here are three scenarios that span the surface. Each scenario should be expressible in idiomatic F# without the developer having to wire layers together by hand.

### Scenario 1: Single-Tenant Chat Agent (Cloudflare-native authoring style)

The straightforward Cloudflare-native case. F# bindings on `Think<Env, State>` directly. The author writes Cloudflare-style code in F#: `InitialState`, `SetState`, lifecycle hook overrides, `[<Callable>]` for RPC methods.

```fsharp
type ChatState = {
    History: ChatMessage list
    UserPreferences: Preferences
}

[<DurableObjectClass>]
type ChatAgent() =
    inherit Think<Env, ChatState>()

    let tools = {
        Search = SearchTools.webSearch
        LookupUser = SearchTools.userLookup
    }

    override this.InitialState =
        { History = []; UserPreferences = Preferences.defaults }

    override this.ConfigureSession(session: Session) : Async<Session> = async {
        return { session with Tools = tools }
    }

    override this.BeforeToolCall(ctx: ToolCallContext) : Async<ToolCallDecision> = async {
        return ToolCallDecision.Allow
    }

    override this.OnChunk(ctx: ChunkContext) : Async<unit> = async {
        // Think framework handles WebSocket streaming; we observe for telemetry
        do! Telemetry.recordChunk ctx.Chunk
    }

    override this.OnChatResponse(result: ChatResponseResult) : Async<unit> = async {
        let updated = { this.State with History = result.Message :: this.State.History }
        this.SetState(updated)
    }
```

What this style buys:
- Direct access to Cloudflare's framework conventions: `setState` auto-sync to React clients, `useAgent` hook on the client side, framework-provided streaming via `OnChunk`, automatic hibernation, RPC ergonomics via `[<Callable>]`.
- Idiomatic for net-new Cloudflare-native AI agents.
- F# binding generator wraps `@cloudflare/agents` directly with no Olivier facade interposed.
- This style is **Cloudflare-only**. The class extends Cloudflare's framework and has no native equivalent.

### Scenario 1b: Single-Tenant Chat (Olivier authoring style)

The same workload, expressed in Olivier's actor-shaped F# vocabulary. Same substrate underneath — the binding generator emits an Agent-extending class — but the author works in MailboxProcessor-shaped semantics.

```fsharp
type ChatMessage =
    | UserTurn of input: string
    | StreamConnect of socket: WebSocket
    | Hibernate

type ChatActor() =
    inherit Olivier<ChatMessage>()

    let mutable history : ChatMessage list = []
    let mutable activeStreams : WebSocket list = []

    override this.OnActivate() = async {
        let! stored = this.Storage.Get<ChatMessage list> "history"
        history <- stored |> Option.defaultValue []
    }

    override this.Handle(msg: ChatMessage) : Async<unit> = async {
        match msg with
        | UserTurn input ->
            let! response = LlmClient.complete this.Env input
            history <- response :: history
            do! this.Storage.Put "history" history
            // Stream as BAREWire frames over the actor's WebSocket
            for socket in activeStreams do
                do! socket.Send(BareWire.encode (ChunkFrame response))
            this.Reply response
        | StreamConnect socket ->
            activeStreams <- socket :: activeStreams
        | Hibernate ->
            ()
    }
```

What this style buys:
- Standard `MailboxProcessor` semantics — `Tell`/`Ask`/`Handle`/`Reply`. The migration target for existing F# actor code.
- BAREWire frames for cross-actor and cross-substrate messaging. Tell-first by default.
- **Substrate transparency at the source level**: the same `inherit Olivier<'Msg>` source compiles to a native MailboxProcessor on bare metal or to an Agent-extending DO on Cloudflare. Application code is unchanged across substrates.
- Supervision via Prospero applies.
- Underneath, the Cloudflare-side compile produces a class extending `Agent<Env, _>` — Cloudflare's framework provides hibernation, transactional storage, WebSocket lifecycle. The Olivier facade decodes BAREWire frames from `onMessage` and dispatches to `Handle`.

**The choice between Style A (Cloudflare-native) and Style B (Olivier-shaped) is per-actor authoring preference.** Both compile to Agent-extending DO classes; both run on the same Cloudflare substrate. Some actors in an application benefit from the Cloudflare-native idioms (framework-provided streaming, automatic state sync to web clients, RPC via `@callable`); others benefit from the Olivier idioms (typed actor messages, BAREWire wire format, MailboxProcessor migration path, substrate transparency for native-edge hybrid deployments). Both styles coexist in the same deployment, communicate naturally over BAREWire-framed WebSocket because both ultimately have access to Agent's `onMessage` raw transport.

### Scenario 2: Multi-Tenant Agent Platform

Different tenants run different agent code. Dynamic Workflows routes per tenant.

```fsharp
[<DynamicWorkerEntry>]
module PlatformDispatcher =
    let resolveTenant (req: Request) : Async<TenantMetadata> = async {
        let tenantId = req.Headers.GetRequired "X-Tenant-Id"
        let! metadata = env.TenantRegistry.Lookup tenantId
        return metadata
    }

    let entryPoint = createDynamicWorkflowEntrypoint {
        ResolveTenant = resolveTenant
        DispatchTo = fun metadata -> 
            // Cloudflare's Worker Loader routes to per-tenant code
            // F# binding presents this as typed dispatch
            env.WorkerLoader.LoadTenant metadata
    }
```

What the framing buys: tenant resolution as a typed F# function, the dispatch as a typed binding, the per-tenant code as just-another-Worker that the platform hosts. The Agents overlay and the Dynamic Workflows package compose at the dispatch layer without the application author having to reconcile their separate APIs.

### Scenario 3: Long-Running Agentic Workflow

An agent kicks off a workflow that may run for hours, hibernating and resuming. Each step is durable; the agent's role is to orchestrate steps, not to hold state across hibernations.

```fsharp
[<WorkflowEntry>]
type ReportGenerationWorkflow() =
    inherit WorkflowEntrypoint<ReportRequest, Report>()

    override this.Run(event: ReportRequest, step: WorkflowStep) = async {
        let! data = step.Do "fetch-data" (fun () -> async {
            return! DataSource.fetch event.Source
        })

        let! analysis = step.Do "analyze-with-agent" (fun () -> async {
            let agent = ReportAgent(env)
            return! agent.Analyze data
        })

        do! step.Sleep "review-window" (TimeSpan.FromHours 24.0)

        let! finalReport = step.Do "compose-report" (fun () -> async {
            return! ReportComposer.compose analysis
        })

        return finalReport
    }
```

What the framing buys: agent invocation inside a `step.Do` block participates in the workflow's durability story. If the workflow hibernates, the agent's intermediate state is what `step.Do` cached. The agent doesn't need to know it's running inside a workflow; the workflow doesn't need to know that one of its steps invoked an agent. The composition is clean because both layers are typed F# bindings over typed Cloudflare runtime concepts.

## Type Discipline at the JS/F# Boundary

Every value crossing the Cloudflare/F# boundary in the Agents overlay should follow the patterns established in the [obj/null doc](../../Composer/docs/javascript-targeting/06_obj_and_null_at_the_boundary.md):

- **`null` is `Option<T>`**: never seen in F# source. The TypeScript `model?: LanguageModel` becomes F# `Model: LanguageModel option`.
- **`unknown` is either generic or `JsValue`**: the binding generator picks generic when the call site can resolve it (typed tool inputs/outputs), `JsValue` when it cannot. Generic is preferred.
- **`Record<string, unknown>` is `Map<string, JsValue>` by default** but can be a typed record when the consumer declares one.
- **Schema-directed narrowing at each boundary**: `Result<T, DeserializationError>` for any value parsed from the runtime against an F# target type. The agent's `body` field, the chunk payloads, the tool inputs all go through this pattern.
- **`AbortSignal` as `CancellationToken`**: maps to F# cancellation; agents use `Async.WithCancellation`.

## Open Questions for Generation Time

These are decisions the binding generation process should resolve, named here so they don't surface as ad-hoc choices when work begins:

**1. Naming conventions.** TypeScript's `beforeToolCall`, F#'s `BeforeToolCall`. The PascalCase translation is straightforward, but `onChunk` vs `OnChunk` vs `HandleChunk` raises questions about whether F# bindings should mirror naming exactly or follow F# convention more aggressively. Recommendation: mirror exactly with PascalCase translation. F# developers reading Cloudflare docs should find the same names.

**2. Hook return type uniformity.** Every hook returns `Async<'T>` even when TypeScript allows sync. Recommendation: yes, normalize. F# developers expect this.

**3. Generic parameters on Think.** TypeScript has `Think<Env>`. Should F# also expose generics over the TOOLS type, or thread that separately? Recommendation: explicit `Think<'Env, 'Tools>` where `'Tools` defaults to a record of standard tools when not specified. This makes tool-typed contexts work without forcing every application to manage two type parameters.

**4. Stream chunk specialization.** The `chunk` type's TypeScript form is a complex Extract; the F# DU above flattens it. Recommendation: ship the flat DU as the primary representation; provide a `JsValue.toStreamChunk` helper for cases where applications want to peek at the raw form.

**5. Error transformation in `onChatError`.** TypeScript: `(error: unknown): unknown`. F#: `Error -> Async<Error>` or `exn -> Async<Result<unit, DomainError>>`? Recommendation: `exn -> Async<exn>` for the literal mirror, with a documented pattern for transforming exn-to-domain-error inside the override. Don't over-design F# error semantics into the binding.

**6. Olivier-Agent peer interop conventions.** Since Olivier and Agent are sibling DO classes, applications that mix them need a clear story for cross-DO messaging. Recommendation: provide a typed `AgentRef<'Agent>` analogous to `ActorRef<'Msg>` so an Olivier can send typed messages to an Agent (and vice versa) without dropping into raw `fetch`/WebSocket calls at the application level. The underlying transport is the standard Cloudflare DO-to-DO mechanism; the F# binding adds the typed surface.

**7. Memory backend conventions.** The `Memory` DU above is a sketch. The exact set of memory backends and their typed APIs needs decision. Recommendation: ship `InMemory`, `DurableObject`, `Kv`, `D1` as the initial set; let community/application code add custom backends via an interface.

## What This Framing Buys

The split into three packages (`Fidelity.CloudEdge`, `Fidelity.CloudEdge.Workflows`, `Fidelity.CloudEdge.Agents`) is not just for organization — it allows each package to have its own generation pipeline, its own release cadence, and its own dependency story. An application that uses only Workers and KV doesn't pull the agents package; an application that uses agents pulls all three transitively.

The shared conventions documented here ensure that despite the package split, the F# developer's experience is unified:

- The same `Option<T>` for nullability everywhere.
- The same `Async<'T>` for asynchrony everywhere.
- The same schema-directed narrowing for runtime values everywhere.
- The same naming convention (PascalCase mirror of TypeScript) everywhere.
- The same composition story (Olivier and Agent are sibling DO classes that interoperate as peers; both compose with Workflows; all sit on the existing Worker/DO/storage bindings).

When generation work begins, the concrete bindings produced will have these properties by construction. The framing here is what makes that possible.

## Cross-References

- [10_jsir_strategic_assessment.md](./10_jsir_strategic_assessment.md) — the JSIR strategic context that establishes how these JavaScript-targeting bindings will eventually be consumable from Clef as well as F#
- [00_architecture_decisions.md](./00_architecture_decisions.md) — the three-tier package architecture (Runtime/Management/Tenancy) that the new packages extend
- [08a_actor_model_overview.md](./08a_actor_model_overview.md) — the actor model, library layering, tell-first semantics, cross-substrate coherence
- [08b_actor_core.md](./08b_actor_core.md) — Olivier/Prospero/ActorRef core types and BAREWire trust argument
- [08c_mailbox_intercept.md](./08c_mailbox_intercept.md) — **the foundational MailboxProcessor → Durable Object mapping** that this document's agentic layer builds on
- [08d_persistence_observability.md](./08d_persistence_observability.md) — event sourcing, journals, snapshots, recovery; relevant for agent session persistence
- [08e_management_infrastructure.md](./08e_management_infrastructure.md) — supervisor topology, deployment, scaling
- [Composer/docs/javascript-targeting/06_obj_and_null_at_the_boundary.md](../../Composer/docs/javascript-targeting/06_obj_and_null_at_the_boundary.md) — the obj/null discipline that the bindings will follow
- [Cloudflare Agents lifecycle-hooks](https://github.com/cloudflare/agents/blob/main/docs/think/lifecycle-hooks.md) — the source TypeScript surface
- [Dynamic Workflows announcement](https://blog.cloudflare.com/dynamic-workflows) — the multi-tenant dispatch primitive
- [Workflows V2 architecture](https://blog.cloudflare.com/workflows-v2/) — the rearchitected control plane
