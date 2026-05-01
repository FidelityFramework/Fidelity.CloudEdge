namespace Fidelity.CloudEdge.Agents

open Fable.Core
open Fable.Core.JsInterop
open System
open Fidelity.CloudEdge.Worker.Context
open Fidelity.CloudEdge.DurableObjects

// ────────────────────────────────────────────────────────────────────
// Fidelity.CloudEdge.Agents — F# binding for `agents-sdk` (npm)
//
// Wraps Cloudflare's Agent base class and supporting types for use as
// Durable-Object-backed AI agents. Per the design framing in
// 08f_agents_overlay_design.md, this is the Cloudflare-native authoring
// style; the Olivier authoring style continues to layer Tell/Ask/Handle
// semantics on top of Agent's substrate.
//
// Source: agents-sdk@0.0.36 (renamed from @cloudflare/agents per upstream).
//
// Hand-curated because Glutinum 0.13.0 currently fails to parse this
// .d.ts (crashes in readParameters on the `sql` template-strings method
// with rest-spread union types). The binding mirrors the TypeScript
// surface; types are kept structurally-faithful so future Glutinum
// improvements can replace this file with auto-generated output.
// ────────────────────────────────────────────────────────────────────

// ─── RPC and State-Update Wire Messages ─────────────────────────────

[<AllowNullLiteral>]
[<Interface>]
type RPCRequest =
    abstract member ``type``: string with get, set
    abstract member id: string with get, set
    abstract member method: string with get, set
    abstract member args: obj[] with get, set

[<AllowNullLiteral>]
[<Interface>]
type StateUpdateMessage =
    abstract member ``type``: string with get, set
    abstract member state: obj with get, set

[<AllowNullLiteral>]
[<Interface>]
type RPCResponseSuccess =
    abstract member ``type``: string with get, set
    abstract member id: string with get, set
    abstract member success: bool with get, set
    abstract member result: obj with get, set
    abstract member ``done``: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type RPCResponseError =
    abstract member ``type``: string with get, set
    abstract member id: string with get, set
    abstract member success: bool with get, set
    abstract member error: string with get, set

/// RPC response from Agent to client. The success/error split is modeled
/// at the F# level as a discriminated union; underlying JS uses a
/// tagged-shape union with `success: boolean`.
type RPCResponse =
    | Success of RPCResponseSuccess
    | Error of RPCResponseError

// ─── Callable Decorator Metadata ────────────────────────────────────

[<AllowNullLiteral>]
[<Interface>]
type CallableMetadata =
    /// Optional human-readable description of what the method does.
    abstract member description: string option with get, set
    /// Whether the method supports streaming responses (returns AsyncGenerator).
    abstract member streaming: bool option with get, set

/// F# attribute marking an Agent method as callable from clients.
/// At binding generation time, methods marked with this attribute are
/// emitted as `@unstable_callable()` decorated TypeScript methods on
/// the resulting JavaScript class. Optional metadata is read from
/// the attribute and passed through.
///
/// Note: agents-sdk 0.0.36 exposes the decorator as `unstable_callable`.
/// The `unstable_` prefix reflects Cloudflare's API stability marker;
/// the F# attribute name drops the prefix and the binding generator
/// applies the upstream name at emission. This decouples the application
/// from upstream renames.
[<AttributeUsage(AttributeTargets.Method)>]
type CallableAttribute(?description: string, ?streaming: bool) =
    inherit Attribute()
    member _.Description = defaultArg description null
    member _.Streaming = defaultArg streaming false

// ─── Schedule (Future Task Execution) ───────────────────────────────

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.LowerFirst)>]
type ScheduleKind =
    /// One-time execution at a specific time.
    | Scheduled
    /// Delayed execution after a duration.
    | Delayed
    /// Recurring execution per a cron expression.
    | Cron

[<AllowNullLiteral>]
[<Interface>]
type Schedule<'T> =
    /// Unique identifier for the schedule.
    abstract member id: string with get
    /// Name of the method to be called when the schedule fires.
    abstract member callback: string with get
    /// Data to be passed to the callback.
    abstract member payload: 'T with get
    /// Type of schedule (one-time, delayed, or recurring).
    abstract member ``type``: ScheduleKind with get
    /// Time the schedule will fire (Unix epoch in seconds, for scheduled/delayed)
    /// or cron expression (for cron).
    abstract member time: U2<float, string> option with get
    /// Optional human-readable description.
    abstract member description: string option with get

[<AllowNullLiteral>]
[<Interface>]
type ScheduleTimeRange =
    abstract member start: System.DateTime option with get, set
    abstract member ``end``: System.DateTime option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ScheduleCriteria =
    abstract member description: string option with get, set
    abstract member id: string option with get, set
    abstract member ``type``: ScheduleKind option with get, set
    abstract member timeRange: ScheduleTimeRange option with get, set

// ─── Agent Context and Options ──────────────────────────────────────

/// Agent's durable context — alias for Cloudflare's DurableObjectState.
/// The Agent's `state.storage` is the underlying transactional store
/// (per 08d persistence model on the post-collapsed-architecture path).
type AgentContext = obj  // DurableObjectState; modeled as obj because the
                          // generic constraint on DurableObjectState differs
                          // between workers-types versions.

[<AllowNullLiteral>]
[<Interface>]
type AgentOptions<'Env> =
    /// Whether to enable CORS for the Agent's HTTP surface.
    abstract member cors: U2<bool, obj> option with get, set
    // Additional fields inherited from PartyServerOptions (prefix, hibernate,
    // etc.) are accessed via dynamic indexer when needed; explicit binding
    // omitted here to keep the surface stable across PartyServer upgrades.

// ─── Streaming Response ─────────────────────────────────────────────

/// Streaming response wrapper for callable methods that return chunked output.
/// The Agent framework converts these to streaming RPC responses on the wire.
[<AllowNullLiteral>]
[<Interface>]
type StreamingResponse =
    abstract member send: chunk: obj -> unit
    abstract member close: unit -> unit

// ─── Workflow Entrypoint (re-export) ────────────────────────────────

/// Workflow entrypoint base class re-exported from `cloudflare:workers`.
/// Subclasses serve as the `class_name` for `[[workflows]]` bindings in
/// wrangler config. The agents-sdk re-exports this for consumer convenience.
[<AllowNullLiteral>]
[<Interface>]
type WorkflowEntrypoint =
    interface end

// ─── Agent Base Class ───────────────────────────────────────────────
//
// The Agent class is the foundational abstraction for Cloudflare-native
// AI agents. It extends Server (from partyserver) which itself extends
// DurableObject (workerd runtime). Subclasses override lifecycle hooks
// and mark methods as [<Callable>] for client-facing RPC.

/// Optional Agent base class options (static, applied via class-level configuration).
[<AllowNullLiteral>]
[<Interface>]
type AgentClassOptions =
    /// Whether the Agent should hibernate when inactive.
    abstract member hibernate: bool with get, set

/// Base class for creating Agent implementations. F# applications inherit from this
/// via Fable interop; `[<Callable>]`-marked methods are exposed as RPC entry points.
///
/// Modeled as an [<Interface>] for binding stability — Fable translates abstract
/// member declarations to TypeScript class members on the emitted side. When the
/// agents-sdk Glutinum binding is producible, this declaration can be replaced
/// with the auto-generated form without breaking application code.
///
/// Generic parameters:
///   'Env   — environment shape from wrangler bindings (KV, R2, D1, DO namespaces, etc.)
///   'State — the agent's persistent state shape
[<AllowNullLiteral>]
[<Interface>]
type Agent<'Env, 'State> =
    /// Initial state for the Agent. Override in subclasses to provide defaults.
    abstract member initialState: 'State with get, set

    /// Current state of the Agent. Read-only; use SetState to update.
    abstract member state: 'State with get

    /// Update the Agent's state. Triggers automatic sync to connected clients.
    abstract member setState: state: 'State -> unit

    /// Called when the Agent's state is updated (from server or client).
    abstract member onStateUpdate: state: 'State option * source: obj -> unit

    /// Called when the Agent receives an email (via Email Workers binding).
    abstract member onEmail: email: obj -> unit

    /// Render content. Not implemented in the base class; override in subclasses.
    abstract member render: unit -> unit

    /// Schedule a task to be executed in the future.
    /// `when` accepts a Date, seconds-delay number, or cron expression string.
    abstract member schedule<'T> : ``when``: U3<System.DateTime, string, float> * callback: string * ?payload: 'T -> JS.Promise<Schedule<'T>>

    /// Get a scheduled task by ID.
    abstract member getSchedule<'T> : id: string -> JS.Promise<Schedule<'T> option>

    /// Get scheduled tasks matching the given criteria.
    abstract member getSchedules<'T> : ?criteria: ScheduleCriteria -> Schedule<'T>[]

    /// Cancel a scheduled task. Returns true if cancelled, false if not found.
    abstract member cancelSchedule: id: string -> JS.Promise<bool>

    /// Method called when an alarm fires; runs scheduled tasks that are due.
    /// The Agent framework manages this internally; subclasses typically don't override.
    abstract member alarm: unit -> JS.Promise<unit>

    /// Destroy the Agent, removing all state and scheduled tasks.
    abstract member destroy: unit -> JS.Promise<unit>

// ─── Agent Namespace ────────────────────────────────────────────────

/// Namespace for creating Agent instances. In TypeScript this is
/// `DurableObjectNamespace<Agent<...>>`; F# models it as a non-generic alias
/// because the underlying DurableObjectNamespace's brand-constraint generic
/// parameter doesn't translate cleanly here without adding workers-types
/// version coupling. Wrangler binds this via `durable_objects.bindings`
/// with `class_name` pointing at the Agent subclass; F# code receives it
/// via env.AGENT_NAME.
type AgentNamespace = obj

// ─── Routing Helpers ────────────────────────────────────────────────

/// Top-level routing functions for dispatching HTTP requests, emails, and
/// direct agent lookups. The agents-sdk exposes these as plain function
/// imports; F# wraps them in a module since namespaces cannot host values.
module Routing =

    /// Top-level router that dispatches HTTP requests to the appropriate Agent.
    /// Returns the Agent's response or None if no route matched.
    [<Import("routeAgentRequest", "agents-sdk")>]
    let routeAgentRequest<'Env> (request: Request) (env: 'Env) (options: AgentOptions<'Env> option) : JS.Promise<Response option> =
        jsNative

    /// Route an inbound email to the appropriate Agent based on configuration.
    [<Import("routeAgentEmail", "agents-sdk")>]
    let routeAgentEmail<'Env> (email: obj) (env: 'Env) (options: AgentOptions<'Env> option) : JS.Promise<unit> =
        jsNative

    /// Get a specific Agent instance by name. Useful for direct agent invocation
    /// when not going through the routing layer.
    [<Import("getAgentByName", "agents-sdk")>]
    let getAgentByName<'Env, 'T> (env: 'Env) (agentNamespace: string) (name: string) : JS.Promise<'T> =
        jsNative
