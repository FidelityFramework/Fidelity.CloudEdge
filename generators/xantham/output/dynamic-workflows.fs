module rec Cloudflare =
    module rec DynamicWorkflows =
        module rec Decoder =
            module rec TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistBinding =
                module rec UnwrapParams =
                    type _Lit2 =
                        abstract params: 'T with get, set

                        abstract metadata:
                            TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata with get, set

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                         "DynamicWorkflowBinding");
                  AbstractClass;
                  AllowNullLiteral>]
                type DynamicWorkflowBinding private () =
                    inherit option<obj<DynamicWorkflowBinding, DynamicWorkflowBindingProps>>()
                    abstract impl: option<obj> with get, set
                    abstract get: id: string -> Promise<option<obj>>
                    abstract createBatch: batch: ResizeArray<option<obj>> -> Promise<ResizeArray<option<obj>>>
                    abstract create: ?options: obj -> Promise<option<obj>>

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                         "DynamicWorkflowBindingProps")>]
                type DynamicWorkflowBindingProps =
                    abstract metadata:
                        TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata with get, set

                    abstract bindingName: string with get, set

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                         "WrapWorkflowBindingOptions")>]
                type WrapWorkflowBindingOptions =
                    abstract bindingName: option<string> with get, set

                type ITestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistBinding =
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
                             "unwrapParams")>]
                    static member unwrapParams<'T>(payload: option<obj>) : option<UnwrapParams._Lit2> = JS.undefined

                    [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                             "wrapWorkflowBinding")>]
                    static member wrapWorkflowBinding
                        (
                            metadata:
                                TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata,
                            ?options: WrapWorkflowBindingOptions
                        ) : option<obj> =
                        JS.undefined

            module rec TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistEntrypoint =
                module rec DispatchWorkflow =
                    type _Lit15 =
                        abstract run:
                            event:
                                TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.WorkflowEventLike<
                                    'T
                                 > *
                            step: WorkflowStepLike ->
                                Promise<'R>

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
                        step: WorkflowStepLike *
                        loadRunner:
                            TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.LoadWorkflowRunnerContext<
                                'Env
                             >
                                -> U2<DispatchWorkflow._Lit15, Promise<DispatchWorkflow._Lit15>> ->
                            Promise<'Result>

                type ITestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistEntrypoint =
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
                                    -> U2<DispatchWorkflow._Lit15, Promise<DispatchWorkflow._Lit15>>
                        ) : Promise<'Result> =
                        JS.undefined

                    [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/entrypoint",
                             "createDynamicWorkflowEntrypoint")>]
                    static member createDynamicWorkflowEntrypoint<'Env, 'Params, 'Result>
                        (
                            loadRunner:
                                TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.LoadWorkflowRunnerContext<
                                    'Env
                                 >
                                    -> U2<DispatchWorkflow._Lit15, Promise<DispatchWorkflow._Lit15>>
                        ) : option<obj> =
                        JS.undefined

            module rec TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes =
                module rec DispatcherEnvelope =
                    type _Lit1 =
                        abstract Item: key: string -> option<obj>

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/types",
                         "DispatcherEnvelope")>]
                type DispatcherEnvelope<'T> =
                    abstract params: 'T with get, set

                    [<EmitProperty("__dispatcherMetadata")>]
                    abstract _dispatcherMetadata: DispatcherMetadata with get, set

                type DispatcherMetadata = obj

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

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/types",
                         "LoadWorkflowRunner")>]
                type LoadWorkflowRunner<'Env, 'T, 'R> =
                    abstract Invoke:
                        context: LoadWorkflowRunnerContext<'Env> ->
                            U2<
                                Promise<
                                    TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistEntrypoint.DispatchWorkflow._Lit15
                                 >,
                                TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistEntrypoint.DispatchWorkflow._Lit15
                             >

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/types",
                         "LoadWorkflowRunnerContext")>]
                type LoadWorkflowRunnerContext<'Env> =
                    abstract ctx: option<obj> with get, set
                    abstract env: 'Env with get, set
                    abstract metadata: DispatcherMetadata with get, set

        type WorkflowStepLike = obj
