type ICloudflare =


type ``@cloudflare`` =


module Cloudflare =
    type IDynamicWorkflows =
        [<Import("@cloudflare/dynamic-workflows", "dispatcherBindingImpl")>]
        static member dispatcherBindingImpl
            (getBinding: unit -> option<obj>, metadata: DispatcherBindingImpl.Metadata)
            : option<obj> =
            JS.undefined

        [<Import("@cloudflare/dynamic-workflows", "wrapWorkflowBinding")>]
        static member wrapWorkflowBinding
            (
                metadata: WrapWorkflowBinding.Metadata,
                ?options: ``@cloudflare``.DynamicWorkflows.Dist.Binding.WrapWorkflowBindingOptions
            ) : option<obj> =
            JS.undefined

        [<Import("@cloudflare/dynamic-workflows", "createDynamicWorkflowEntrypoint")>]
        static member createDynamicWorkflowEntrypoint
            (
                loadRunner:
                    LoadWorkflowRunnerContext<'Env>
                        -> U2<
                            CreateDynamicWorkflowEntrypoint.LoadRunner,
                            Promise<CreateDynamicWorkflowEntrypoint.LoadRunner>
                         >
            ) : option<obj> =
            JS.undefined

        [<Import("@cloudflare/dynamic-workflows", "dispatchWorkflow")>]
        static member dispatchWorkflow
            (
                context: DispatchWorkflow.Context,
                event: ``@cloudflare``.DynamicWorkflows.Dist.Types.WorkflowEventLike<option<obj>>,
                step: obj,
                loadRunner:
                    LoadWorkflowRunnerContext<'Env>
                        -> U2<DispatchWorkflow.LoadRunner, Promise<DispatchWorkflow.LoadRunner>>
            ) : Promise<'Result> =
            JS.undefined

    module DynamicWorkflows =
        type DynamicWorkflowBinding =
            abstract Item: key: string -> option<obj>

        [<Import("@cloudflare/dynamic-workflows", "MissingDispatcherMetadataError")>]
        type MissingDispatcherMetadataError =
            interface
                [<EmitConstructor>]
                abstract Create: unit -> MissingDispatcherMetadataError

                inherit Error
            end

        [<Import("@cloudflare/dynamic-workflows", "LoadWorkflowRunner")>]
        type LoadWorkflowRunner<'R, 'T, 'Env> =
            abstract Invoke:
                context: LoadWorkflowRunnerContext<'Env> ->
                    U2<Promise<LoadWorkflowRunner.LoadWorkflowRunner>, LoadWorkflowRunner.LoadWorkflowRunner>

        type DispatchWorkflow =
            abstract ctx: option<obj> with get, set
            abstract env: 'Env with get, set

            abstract Invoke:
                context: DispatchWorkflow.DispatchWorkflow.Context *
                event: ``@cloudflare``.DynamicWorkflows.Dist.Types.WorkflowEventLike<option<obj>> *
                step: obj *
                loadRunner:
                    LoadWorkflowRunnerContext<'Env>
                        -> U2<
                            DispatchWorkflow.DispatchWorkflow.LoadRunner,
                            Promise<DispatchWorkflow.DispatchWorkflow.LoadRunner>
                         > ->
                    Promise<'Result>

        type WrapWorkflowBinding =
            abstract Item: key: string -> option<obj>

        type DispatcherBindingImpl =
            abstract Item: key: string -> option<obj>

        [<Import("@cloudflare/dynamic-workflows", "LoadWorkflowRunnerContext")>]
        type LoadWorkflowRunnerContext<'Env> =
            abstract ctx: option<obj> with get, set
            abstract env: 'Env with get, set
            abstract metadata: LoadWorkflowRunnerContext.Metadata with get, set

        [<Import("@cloudflare/dynamic-workflows", "WorkflowRunner")>]
        type WorkflowRunner<'R, 'T> =
            abstract run:
                event: ``@cloudflare``.DynamicWorkflows.Dist.Types.WorkflowEventLike<'T> * step: obj -> Promise<'R>

        module DispatchWorkflow =
            type LoadRunner =
                abstract run:
                    event: ``@cloudflare``.DynamicWorkflows.Dist.Types.WorkflowEventLike<'T> * step: obj -> Promise<'R>

        module LoadWorkflowRunner =
            type Invoke =
                abstract run:
                    event: ``@cloudflare``.DynamicWorkflows.Dist.Types.WorkflowEventLike<'T> * step: obj -> Promise<'R>

        module LoadWorkflowRunnerContext =
            type Metadata =
                abstract Item: key: string -> option<obj>

module ``@cloudflare`` =
    module DynamicWorkflows =
        module Dist =
            module Binding =
                [<Import("./binding.js", "DynamicWorkflowBindingProps")>]
                type DynamicWorkflowBindingProps =
                    abstract metadata: DynamicWorkflowBindingProps.Metadata with get, set
                    abstract bindingName: string with get, set

                [<Import("./binding.js", "WrapWorkflowBindingOptions")>]
                type WrapWorkflowBindingOptions =
                    abstract bindingName: option<string> with get, set

                module DynamicWorkflowBindingProps =
                    type Metadata =
                        abstract Item: key: string -> option<obj>

            module Types =
                type DispatcherMetadata =
                    abstract Item: key: string -> option<obj>

                [<Import("./types.js", "WorkflowEventLike")>]
                type WorkflowEventLike<'T> =
                    abstract instanceId: string with get, set
                    abstract timestamp: Date with get, set
                    abstract payload: 'T with get, set
