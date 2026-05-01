namespace Fidelity.CloudEdge.Worker.Context

open Fable.Core
open Fable.Core.JsInterop
open System

[<AllowNullLiteral>]
[<Interface>]
type Headers =
    abstract member append: name: string * value: string -> unit
    abstract member delete: name: string -> unit
    abstract member get: name: string -> string option
    abstract member has: name: string -> bool
    abstract member set: name: string * value: string -> unit
    abstract member forEach: callback: (string -> string -> unit) -> unit

[<AllowNullLiteral>]
[<Interface>]
type Request =
    abstract member ``method``: string with get
    abstract member url: string with get
    abstract member headers: Headers with get
    abstract member clone: unit -> Request
    abstract member text: unit -> JS.Promise<string>
    abstract member json<'T> : unit -> JS.Promise<'T>
    abstract member arrayBuffer: unit -> JS.Promise<JS.ArrayBuffer>
    abstract member cf: obj option with get

[<AllowNullLiteral>]
[<Interface>]
type Response =
    abstract member status: float with get
    abstract member statusText: string with get
    abstract member ok: bool with get
    abstract member headers: Headers with get
    abstract member clone: unit -> Response
    abstract member text: unit -> JS.Promise<string>
    abstract member json<'T> : unit -> JS.Promise<'T>
    abstract member arrayBuffer: unit -> JS.Promise<JS.ArrayBuffer>

[<AllowNullLiteral>]
[<Interface>]
type ResponseInit =
    abstract member status: float option with get, set
    abstract member statusText: string option with get, set
    abstract member headers: U2<obj, Headers> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ExecutionContext =
    abstract member waitUntil: promise: JS.Promise<obj> -> unit
    abstract member passThroughOnException: unit -> unit

[<AllowNullLiteral>]
[<Interface>]
type Env =
    [<EmitIndexer>]
    abstract member Item: key: string -> obj with get, set

type FetchHandler = Request -> Env -> ExecutionContext -> U2<Response, JS.Promise<Response>>

// Constructors
[<Global>]
[<AllowNullLiteral>]
type HeadersConstructor =
    [<Emit("new $0($1...)")>]
    abstract Create: ?init: obj -> Headers

[<Global>]
[<AllowNullLiteral>]
type ResponseConstructor =
    [<Emit("new $0($1...)")>]
    abstract Create: ?body: U2<string, JS.ArrayBuffer> * ?init: ResponseInit -> Response
    abstract member json: obj * ?init: ResponseInit -> Response
    abstract member redirect: url: string * ?status: float -> Response

// ─── Workflows V2 (April 2026) ──────────────────────────────────
//
// Workflows V2 supports up to 50,000 concurrent instances per workflow,
// with the new SousChef + Gatekeeper distribution architecture in the
// control plane. The runtime types below cover the consumer-facing API
// surface for creating, retrieving, and managing workflow instances.
//
// Hand-curated from @cloudflare/workers-types index.d.ts (4.20260501.1+).
// Glutinum's auto-generated Generated.fs is reference material only;
// these are the compiled-into-assembly types.

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.LowerFirst)>]
type WorkflowDurationLabel =
    | Second
    | Minute
    | Hour
    | Day
    | Week
    | Month
    | Year

/// Sleep duration. Either a string template literal like "5 minutes" or a numeric milliseconds value.
/// At runtime this is a U2<string, float>; in F# we model it as a discriminated union for ergonomics.
type WorkflowSleepDuration = U2<string, float>

/// Retention duration uses the same shape as sleep duration.
type WorkflowRetentionDuration = WorkflowSleepDuration

[<AllowNullLiteral>]
[<Interface>]
type WorkflowInstanceRetention =
    abstract member successRetention: WorkflowRetentionDuration option with get, set
    abstract member errorRetention: WorkflowRetentionDuration option with get, set

[<AllowNullLiteral>]
[<Interface>]
type WorkflowInstanceCreateOptions<'PARAMS> =
    /// Optional id for the workflow instance; must be unique within the workflow.
    abstract member id: string option with get, set
    /// Optional event payload the workflow instance is triggered with.
    abstract member ``params``: 'PARAMS option with get, set
    /// Optional retention policy for the workflow instance.
    abstract member retention: WorkflowInstanceRetention option with get, set

[<AllowNullLiteral>]
[<Interface>]
type WorkflowError =
    abstract member code: float option with get, set
    abstract member message: string with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.LowerFirst)>]
type WorkflowInstanceStatusKind =
    | Queued
    | Running
    | Paused
    | Errored
    | Terminated
    | Complete
    | Waiting
    | WaitingForPause
    | Unknown

[<AllowNullLiteral>]
[<Interface>]
type WorkflowInstanceStatus =
    abstract member status: WorkflowInstanceStatusKind with get
    abstract member error: WorkflowError option with get
    abstract member output: obj option with get

[<AllowNullLiteral>]
[<Interface>]
type WorkflowEventPayload =
    abstract member ``type``: string with get, set
    abstract member payload: obj option with get, set

/// Handle to an existing workflow instance. Supports lifecycle control (pause/resume/terminate/restart),
/// status inspection, and event dispatch.
[<AllowNullLiteral>]
[<Interface>]
type WorkflowInstance =
    abstract member id: string with get
    abstract member pause: unit -> JS.Promise<unit>
    abstract member resume: unit -> JS.Promise<unit>
    abstract member terminate: unit -> JS.Promise<unit>
    abstract member restart: unit -> JS.Promise<unit>
    abstract member status: unit -> JS.Promise<WorkflowInstanceStatus>
    abstract member sendEvent: payload: WorkflowEventPayload -> JS.Promise<unit>

/// Workflow binding. Generic in the params type so applications can constrain the
/// payload shape that `create` and `createBatch` accept.
[<AllowNullLiteral>]
[<Interface>]
type Workflow<'PARAMS> =
    /// Get a handle to an existing instance of the workflow.
    abstract member get: id: string -> JS.Promise<WorkflowInstance>
    /// Create a new instance and return a handle to it. Throws if the provided id already exists.
    abstract member create: ?options: WorkflowInstanceCreateOptions<'PARAMS> -> JS.Promise<WorkflowInstance>
    /// Create a batch of instances. Limited to 100 instances or 1 MiB total payload per call.
    abstract member createBatch: batch: WorkflowInstanceCreateOptions<'PARAMS>[] -> JS.Promise<WorkflowInstance[]>

/// Untyped workflow binding alias (PARAMS = obj). Useful when the params shape is not statically known.
type Workflow = Workflow<obj>

/// Global constructors module
module Globals =
    [<Global>]
    let Headers: HeadersConstructor = jsNative

    [<Global>]
    let Response: ResponseConstructor = jsNative