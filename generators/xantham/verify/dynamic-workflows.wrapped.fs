module rec CloudflareDynamicWorkflows

open System
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop

module rec Cloudflare =
    module rec DynamicWorkflows =
        module rec Decoder =
            module rec TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistBinding =
                module rec UnwrapParams =
                    type _Lit2 =
                        abstract params: 'T with get, set

                        abstract metadata:
                            TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata with get, set

                type DynamicWorkflowBinding =
                    abstract Item: key: string -> option<obj>

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                         "WrapWorkflowBindingOptions")>]
                type WrapWorkflowBindingOptions =
                    abstract bindingName: option<string> with get, set

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                         "DynamicWorkflowBindingProps")>]
                type DynamicWorkflowBindingProps =
                    abstract metadata:
                        TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata with get, set

                    abstract bindingName: string with get, set

                type ITestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistBinding =
                    [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                             "wrapWorkflowBinding")>]
                    static member wrapWorkflowBinding
                        (
                            metadata:
                                TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata,
                            ?options: WrapWorkflowBindingOptions
                        ) : option<obj> =
                        JS.undefined

                    [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                             "wrapParams")>]
                    static member wrapParams<'T>
                        (
                            params: 'T,
                            metadata:
                                TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata
                        ) : TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherEnvelope<
                                'T
                             >
                        =
                        JS.undefined

                    [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                             "_dispatcherBindingImpl")>]
                    static member _dispatcherBindingImpl
                        (
                            getBinding: unit -> option<obj>,
                            metadata:
                                TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata
                        ) : option<obj> =
                        JS.undefined

                    [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                             "unwrapParams")>]
                    static member unwrapParams<'T>(payload: option<obj>) : option<UnwrapParams._Lit2> = JS.undefined

            module rec TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistEntrypoint =
                module rec DispatchWorkflow =
                    type _Lit1 =
                        abstract ctx: option<obj> with get, set
                        abstract env: 'Env with get, set

                type DispatchWorkflow =
                    abstract Invoke:
                        context: DispatchWorkflow._Lit1 *
                        event:
                            TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.WorkflowEventLike<
                                option<obj>
                             > *
                        step: WorkflowStepLike *
                        loadRunner:
                            TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.LoadWorkflowRunnerContext<
                                'Env
                             >
                                -> U2<Typescript.Promise._Lit16, Promise<Typescript.Promise._Lit16>> ->
                            Promise<'Result>

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/entrypoint",
                         "MissingDispatcherMetadataError");
                  AbstractClass;
                  AllowNullLiteral>]
                type MissingDispatcherMetadataError private () =
                    inherit exn()

                    [<EmitConstructor>]
                    abstract Create: unit -> MissingDispatcherMetadataError

                type ITestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistEntrypoint =
                    [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/entrypoint",
                             "createDynamicWorkflowEntrypoint")>]
                    static member createDynamicWorkflowEntrypoint<'Env, 'Params, 'Result>
                        (
                            loadRunner:
                                TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.LoadWorkflowRunnerContext<
                                    'Env
                                 >
                                    -> U2<Typescript.Promise._Lit16, Promise<Typescript.Promise._Lit16>>
                        ) : option<obj> =
                        JS.undefined

                    [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/entrypoint",
                             "dispatchWorkflow")>]
                    static member dispatchWorkflow<'Env, 'Params, 'Result>
                        (
                            context: DispatchWorkflow._Lit1,
                            event:
                                TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.WorkflowEventLike<
                                    option<obj>
                                 >,
                            step: WorkflowStepLike,
                            loadRunner:
                                TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.LoadWorkflowRunnerContext<
                                    'Env
                                 >
                                    -> U2<Typescript.Promise._Lit16, Promise<Typescript.Promise._Lit16>>
                        ) : Promise<'Result> =
                        JS.undefined

            module rec TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes =
                module rec DispatcherEnvelope =
                    type _Lit1 =
                        abstract Item: key: string -> option<obj>

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/types",
                         "WorkflowRunner")>]
                type WorkflowRunner<'T, 'R> =
                    abstract run: event: WorkflowEventLike<'T> * step: WorkflowStepLike -> Promise<'R>

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/types",
                         "WorkflowEventLike")>]
                type WorkflowEventLike<'T> =
                    abstract instanceId: string with get, set
                    abstract timestamp: Date with get, set
                    abstract payload: 'T with get, set

                type DispatcherMetadata = obj

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/types",
                         "LoadWorkflowRunner")>]
                type LoadWorkflowRunner<'Env, 'T, 'R> =
                    abstract Invoke:
                        context: LoadWorkflowRunnerContext<'Env> ->
                            U2<Promise<Typescript.Promise._Lit16>, Typescript.Promise._Lit16>

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/types",
                         "LoadWorkflowRunnerContext")>]
                type LoadWorkflowRunnerContext<'Env> =
                    abstract ctx: option<obj> with get, set
                    abstract env: 'Env with get, set
                    abstract metadata: DispatcherMetadata with get, set

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/types",
                         "DispatcherEnvelope")>]
                type DispatcherEnvelope<'T> =
                    abstract params: 'T with get, set

                    [<EmitProperty("__dispatcherMetadata")>]
                    abstract _dispatcherMetadata: DispatcherMetadata with get, set

        type WorkflowStepLike = obj

module rec Typescript =
    module rec Promise =
        type _Lit16 =
            abstract run:
                event:
                    Cloudflare.DynamicWorkflows.Decoder.TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.WorkflowEventLike<
                        'T
                     > *
                step: Cloudflare.DynamicWorkflows.WorkflowStepLike ->
                    Promise<'R>
