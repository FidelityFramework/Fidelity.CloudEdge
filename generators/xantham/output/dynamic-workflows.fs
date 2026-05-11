module rec Cloudflare =
    module rec DynamicWorkflows =
        module rec Decoder =
            module rec TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistBinding =
                module rec _dispatcherBindingImpl =
                    type _Lit2 =
                        abstract Item: key: string -> option<obj>

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                         "DynamicWorkflowBindingProps")>]
                type DynamicWorkflowBindingProps =
                    abstract metadata:
                        TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata with get, set

                    abstract bindingName: string with get, set

                type DynamicWorkflowBinding =
                    abstract Item: key: string -> option<obj>

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                         "WrapWorkflowBindingOptions")>]
                type WrapWorkflowBindingOptions =
                    abstract bindingName: option<string> with get, set

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
                             "_dispatcherBindingImpl")>]
                    static member _dispatcherBindingImpl
                        (
                            getBinding: unit -> option<obj>,
                            metadata:
                                TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata
                        ) : option<obj> =
                        JS.undefined

            module rec TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistEntrypoint =
                module rec CreateDynamicWorkflowEntrypoint =
                    type Invoke =
                        abstract run:
                            event:
                                TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.WorkflowEventLike<
                                    'T
                                 > *
                            step: obj ->
                                Promise<'R>

                module rec DispatchWorkflow =
                    type _Lit1 =
                        abstract ctx: option<obj> with get, set
                        abstract env: 'Env with get, set

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/entrypoint",
                         "MissingDispatcherMetadataError");
                  AbstractClass;
                  AllowNullLiteral>]
                type MissingDispatcherMetadataError private () =
                    inherit exn()

                    [<EmitConstructor>]
                    abstract Create: unit -> MissingDispatcherMetadataError

                type DispatchWorkflow =
                    abstract Invoke:
                        context: DispatchWorkflow._Lit1 *
                        event:
                            TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.WorkflowEventLike<
                                option<obj>
                             > *
                        step: obj *
                        loadRunner:
                            TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.LoadWorkflowRunnerContext<
                                'Env
                             >
                                -> U2<DispatchWorkflow.Invoke.LoadRunner, Promise<DispatchWorkflow.Invoke.LoadRunner>> ->
                            Promise<'Result>

                type ITestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistEntrypoint =
                    [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/entrypoint",
                             "dispatchWorkflow")>]
                    static member dispatchWorkflow<'Result, 'Params, 'Env>
                        (
                            context: DispatchWorkflow._Lit1,
                            event:
                                TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.WorkflowEventLike<
                                    option<obj>
                                 >,
                            step: obj,
                            loadRunner:
                                TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.LoadWorkflowRunnerContext<
                                    'Env
                                 >
                                    -> U2<DispatchWorkflow.LoadRunner, Promise<DispatchWorkflow.LoadRunner>>
                        ) : Promise<'Result> =
                        JS.undefined

                    [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/entrypoint",
                             "createDynamicWorkflowEntrypoint")>]
                    static member createDynamicWorkflowEntrypoint<'Result, 'Params, 'Env>
                        (
                            loadRunner:
                                TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.LoadWorkflowRunnerContext<
                                    'Env
                                 >
                                    -> U2<
                                        CreateDynamicWorkflowEntrypoint.LoadRunner,
                                        Promise<CreateDynamicWorkflowEntrypoint.LoadRunner>
                                     >
                        ) : option<obj> =
                        JS.undefined

            module rec TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes =
                module rec LoadWorkflowRunner =
                    type Invoke =
                        abstract run: event: WorkflowEventLike<'T> * step: obj -> Promise<'R>

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/types",
                         "WorkflowEventLike")>]
                type WorkflowEventLike<'T> =
                    abstract instanceId: string with get, set
                    abstract timestamp: Date with get, set
                    abstract payload: 'T with get, set

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/types",
                         "WorkflowRunner")>]
                type WorkflowRunner<'R, 'T> =
                    abstract run: event: WorkflowEventLike<'T> * step: obj -> Promise<'R>

                type DispatcherMetadata = obj

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/types",
                         "LoadWorkflowRunner")>]
                type LoadWorkflowRunner<'R, 'T, 'Env> =
                    abstract Invoke:
                        context: LoadWorkflowRunnerContext<'Env> ->
                            U2<Promise<LoadWorkflowRunner.Invoke>, LoadWorkflowRunner.Invoke>

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/types",
                         "LoadWorkflowRunnerContext")>]
                type LoadWorkflowRunnerContext<'Env> =
                    abstract ctx: option<obj> with get, set
                    abstract env: 'Env with get, set
                    abstract metadata: DispatcherMetadata with get, set
