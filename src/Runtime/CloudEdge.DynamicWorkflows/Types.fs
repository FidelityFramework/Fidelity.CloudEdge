namespace Fidelity.CloudEdge.DynamicWorkflows

open Fable.Core
open Fable.Core.JsInterop
open System
open Fidelity.CloudEdge.Worker.Context

// ────────────────────────────────────────────────────────────────────
// Fidelity.CloudEdge.DynamicWorkflows — F# binding for
// `@cloudflare/dynamic-workflows` (npm).
//
// Multi-tenant workflow dispatch: a single Worker (the "dispatcher")
// routes every Workflows.create() call to a different tenant's code,
// and the Workflows engine dispatches run(event, step) back to that
// same code when the workflow actually executes.
//
// Source: @cloudflare/dynamic-workflows@0.1.1 (~300 lines TS)
// Public surface (all exported from index.d.ts):
//   - DynamicWorkflowBinding (class extending WorkerEntrypoint)
//   - wrapWorkflowBinding (fn returning Workflow stub)
//   - createDynamicWorkflowEntrypoint (fn returning WorkflowEntrypoint subclass)
//   - dispatchWorkflow (fn for custom WorkflowEntrypoint subclasses)
//   - MissingDispatcherMetadataError (error class)
//   - Internal types via type-only re-exports: DispatcherMetadata,
//     LoadWorkflowRunner, LoadWorkflowRunnerContext, WorkflowRunner
// ────────────────────────────────────────────────────────────────────

// ─── Dispatcher Metadata ────────────────────────────────────────────

/// Opaque metadata that the dispatcher attaches to every workflow invocation.
/// Carried as a record/object with arbitrary serializable keys (tenant ids,
/// routing keys, worker names, etc.). The library treats it as opaque;
/// applications interpret the keys they themselves attached.
type DispatcherMetadata = obj

// ─── Workflow Event and Step (Structural) ──────────────────────────

/// Structural shape of a `WorkflowEvent` from cloudflare:workers.
/// Compatible with Cloudflare's real `WorkflowEvent<T>` by design;
/// declared here so the library doesn't depend on a specific
/// workers-types version.
[<AllowNullLiteral>]
[<Interface>]
type WorkflowEventLike<'T> =
    abstract member payload: 'T with get
    abstract member timestamp: System.DateTime with get
    abstract member instanceId: string with get

/// Structural placeholder for `WorkflowStep` from cloudflare:workers.
/// The library never inspects the step handle — it forwards it through
/// to the dynamic worker — so any object satisfies the requirement.
type WorkflowStepLike = obj

// ─── Workflow Runner ────────────────────────────────────────────────

/// A dynamic workflow runner — something with a run(event, step) method
/// that the wrapped WorkflowEntrypoint can delegate to.
///
/// The easiest way to satisfy this is to return stub.getEntrypoint('X')
/// from a Worker Loader, pointing at a class in the dynamic worker that
/// extends WorkflowEntrypoint.
[<AllowNullLiteral>]
[<Interface>]
type WorkflowRunner<'T, 'R> =
    abstract member run: event: WorkflowEventLike<'T> * step: WorkflowStepLike -> JS.Promise<'R>

// ─── Loader Context ─────────────────────────────────────────────────

/// Context passed to a LoadWorkflowRunner callback.
[<AllowNullLiteral>]
[<Interface>]
type LoadWorkflowRunnerContext<'Env> =
    /// Metadata attached by wrapWorkflowBinding at create-time.
    abstract member metadata: DispatcherMetadata with get
    /// The dispatcher's own env (whatever bindings its wrangler config declares —
    /// typically at least a WorkerLoader binding).
    abstract member env: 'Env with get
    /// The standard ExecutionContext.
    abstract member ctx: ExecutionContext with get

/// Callback the dispatcher provides for loading a tenant's dynamic workflow runner.
///
/// Receives the metadata that was attached at `create` time along with the
/// dispatcher's own env / ctx, so it can reach the WorkerLoader binding
/// (or any other binding) it needs.
type LoadWorkflowRunner<'Env, 'T, 'R> =
    LoadWorkflowRunnerContext<'Env> -> JS.Promise<WorkflowRunner<'T, 'R>>

// ─── Wrap Options ───────────────────────────────────────────────────

/// Options accepted by wrapWorkflowBinding.
[<AllowNullLiteral>]
[<Interface>]
type WrapWorkflowBindingOptions =
    /// Name of the Workflow binding declared in the dispatcher's wrangler.jsonc.
    /// The DynamicWorkflowBinding class will look it up on this.env[bindingName]
    /// to create workflow instances. Defaults to "WORKFLOWS".
    abstract member bindingName: string option with get, set

// ─── Errors ─────────────────────────────────────────────────────────

/// Thrown when the WorkflowEvent does not contain a dispatcher envelope.
/// Usually means the workflow was created against the raw binding instead
/// of one wrapped with wrapWorkflowBinding.
///
/// JS error types don't map cleanly to F#'s System.Exception when imported
/// for interop; modeled as an interface that exposes the standard Error
/// fields. Application code catches it via try/with and pattern-match on
/// the message field for identification.
[<AllowNullLiteral>]
[<Interface>]
type MissingDispatcherMetadataError =
    abstract member name: string with get
    abstract member message: string with get
    abstract member stack: string option with get

// ─── DynamicWorkflowBinding (RPC Stub Class) ───────────────────────

/// A WorkerEntrypoint-based implementation of the Workflow binding interface.
///
/// The dispatcher MUST re-export this class from its main module:
///
///     // dispatcher's index.ts
///     export { DynamicWorkflowBinding } from '@cloudflare/dynamic-workflows';
///
/// Cloudflare automatically registers it on ctx.exports / cloudflare:workers
/// exports, which is what wrapWorkflowBinding uses to create a specialised
/// RPC stub per tenant.
[<AllowNullLiteral>]
[<Interface>]
type DynamicWorkflowBinding =
    abstract member create: ?options: obj -> JS.Promise<obj>
    abstract member createBatch: batch: obj[] -> JS.Promise<obj[]>
    abstract member get: id: string -> JS.Promise<obj>

// ─── Public API ─────────────────────────────────────────────────────

/// Top-level functions imported from @cloudflare/dynamic-workflows.
/// Wrapped in a module since namespaces cannot host F# values directly.
module Api =

    /// Produce a Workflow-shaped RPC stub that, when .create() / .createBatch()
    /// is called on it, tags each new instance's params with the given dispatcher
    /// metadata.
    ///
    /// The returned stub is serialisable and can be passed as a binding to a
    /// Dynamic Worker loaded via the Worker Loader.
    ///
    /// Throws if the consumer forgot to re-export DynamicWorkflowBinding from
    /// their main module.
    [<Import("wrapWorkflowBinding", "@cloudflare/dynamic-workflows")>]
    let wrapWorkflowBinding (metadata: DispatcherMetadata) (options: WrapWorkflowBindingOptions option) : obj =
        jsNative

    /// Shared implementation of run() — exported so consumers who want to write
    /// their own WorkflowEntrypoint subclass (e.g. to add logging around run)
    /// can reuse the core unwrap-and-delegate logic.
    [<Import("dispatchWorkflow", "@cloudflare/dynamic-workflows")>]
    let dispatchWorkflow<'Env, 'Params, 'Result>
        (context: LoadWorkflowRunnerContext<'Env>)
        (event: WorkflowEventLike<obj>)
        (step: WorkflowStepLike)
        (loadRunner: LoadWorkflowRunner<'Env, 'Params, 'Result>)
        : JS.Promise<'Result> =
        jsNative

    /// Create a WorkflowEntrypoint subclass that delegates run to a
    /// dynamically-loaded worker. Register the returned class as the
    /// class_name of a [[workflows]] binding in your dispatcher's wrangler config.
    [<Import("createDynamicWorkflowEntrypoint", "@cloudflare/dynamic-workflows")>]
    let createDynamicWorkflowEntrypoint<'Env, 'Params, 'Result>
        (loadRunner: LoadWorkflowRunner<'Env, 'Params, 'Result>)
        : obj =
        jsNative
