module rec CloudflareDynamicWorkflows

open System
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop

module rec Cloudflare =
    module rec DynamicWorkflows =
        module rec DispatchWorkflow =
            module rec LoadRunner =
                module rec LoadRunner =
                    type Invoke =
                        abstract run: event: Dist.Types.WorkflowEventLike<'T> * step: obj -> Promise<'R>

            type Context =
                abstract ctx: option<obj> with get, set
                abstract env: 'Env with get, set

        module rec Dist =
            module rec Binding =
                module rec DynamicWorkflowBindingProps =
                    type Metadata =
                        abstract Item: key: string -> option<obj>

                [<Import("./binding.js", "WrapWorkflowBindingOptions")>]
                type WrapWorkflowBindingOptions =
                    abstract bindingName: option<string> with get, set

                [<Import("./binding.js", "DynamicWorkflowBindingProps")>]
                type DynamicWorkflowBindingProps =
                    abstract metadata: Types.DispatcherMetadata with get, set
                    abstract bindingName: string with get, set

            module rec Types =
                module rec DispatcherMetadata =
                    type Metadata =
                        abstract Item: key: string -> option<obj>

                [<Import("./types.js", "WorkflowEventLike")>]
                type WorkflowEventLike<'T> =
                    abstract instanceId: string with get, set
                    abstract timestamp: Date with get, set
                    abstract payload: 'T with get, set

                type DispatcherMetadata = obj

        module rec LoadWorkflowRunner =
            type Invoke =
                abstract run: event: Dist.Types.WorkflowEventLike<'T> * step: obj -> Promise<'R>

        module rec LoadWorkflowRunnerContext =
            module rec Metadata =
                module rec Metadata =
                    type Metadata =
                        abstract Item: key: string -> option<obj>

        module rec WrapWorkflowBinding =
            type Metadata =
                abstract Item: key: string -> option<obj>

        module rec _dispatcherBindingImpl =
            type Metadata =
                abstract Item: key: string -> option<obj>

        [<Import("@cloudflare/dynamic-workflows", "MissingDispatcherMetadataError"); AbstractClass; AllowNullLiteral>]
        type MissingDispatcherMetadataError private () =
            inherit exn()

            [<EmitConstructor>]
            abstract Create: unit -> MissingDispatcherMetadataError

        type DispatchWorkflow =
            abstract Invoke:
                context: DispatchWorkflow.Invoke.Context.Invoke.Context.Context *
                event: Dist.Types.WorkflowEventLike<option<obj>> *
                step: obj *
                loadRunner:
                    LoadWorkflowRunnerContext<'Env>
                        -> U2<
                            DispatchWorkflow.Invoke.LoadRunner.LoadRunner.Invoke,
                            Promise<DispatchWorkflow.Invoke.LoadRunner>
                         > ->
                    Promise<'Result>

        [<Import("@cloudflare/dynamic-workflows", "LoadWorkflowRunnerContext")>]
        type LoadWorkflowRunnerContext<'Env> =
            abstract ctx: option<obj> with get, set
            abstract env: 'Env with get, set
            abstract metadata: Dist.Types.DispatcherMetadata with get, set

        type DynamicWorkflowBinding =
            abstract Item: key: string -> option<obj>

        [<Import("@cloudflare/dynamic-workflows", "LoadWorkflowRunner")>]
        type LoadWorkflowRunner<'R, 'T, 'Env> =
            abstract Invoke:
                context: LoadWorkflowRunnerContext<'Env> ->
                    U2<Promise<LoadWorkflowRunner.Invoke>, LoadWorkflowRunner.Invoke.Invoke.Invoke>

        [<Import("@cloudflare/dynamic-workflows", "WorkflowRunner")>]
        type WorkflowRunner<'R, 'T> =
            abstract run: event: Dist.Types.WorkflowEventLike<'T> * step: obj -> Promise<'R>

        type IDynamicWorkflows =
            [<Import("@cloudflare/dynamic-workflows", "dispatchWorkflow")>]
            static member dispatchWorkflow
                (
                    context: DispatchWorkflow.Context,
                    event: Dist.Types.WorkflowEventLike<option<obj>>,
                    step: obj,
                    loadRunner:
                        LoadWorkflowRunnerContext<'Env>
                            -> U2<DispatchWorkflow.LoadRunner.LoadRunner.Invoke, Promise<DispatchWorkflow.LoadRunner>>
                ) : Promise<'Result> =
                JS.undefined

            [<Import("@cloudflare/dynamic-workflows", "_dispatcherBindingImpl")>]
            static member _dispatcherBindingImpl
                (getBinding: unit -> option<obj>, metadata: Dist.Types.DispatcherMetadata)
                : option<obj> =
                JS.undefined

            [<Import("@cloudflare/dynamic-workflows", "wrapWorkflowBinding")>]
            static member wrapWorkflowBinding
                (metadata: Dist.Types.DispatcherMetadata, ?options: Dist.Binding.WrapWorkflowBindingOptions)
                : option<obj> =
                JS.undefined

            [<Import("@cloudflare/dynamic-workflows", "createDynamicWorkflowEntrypoint")>]
            static member createDynamicWorkflowEntrypoint
                (
                    loadRunner:
                        LoadWorkflowRunnerContext<'Env>
                            -> U2<
                                CreateDynamicWorkflowEntrypoint.LoadRunner.LoadRunner.Invoke,
                                Promise<CreateDynamicWorkflowEntrypoint.LoadRunner>
                             >
                ) : option<obj> =
                JS.undefined
