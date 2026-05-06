module rec Cloudflare =
    module rec DynamicWorkflows =
        module rec Decoder =
            module rec TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistBinding =
                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                         "DynamicWorkflowBinding");
                  AbstractClass;
                  AllowNullLiteral>]
                type DynamicWorkflowBinding private () =
                    inherit
                        option<
                            obj<
                                DynamicWorkflowBinding,
                                ``.``.BindingJs.Decoder.TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistBinding.DynamicWorkflowBindingProps
                             >
                         >()

                    abstract impl: option<obj> with get, set
                    abstract get: id: string -> Promise<option<obj>>
                    abstract createBatch: batch: ResizeArray<option<obj>> -> Promise<ResizeArray<option<obj>>>
                    abstract create: ?options: obj -> Promise<option<obj>>

                type ITestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistBinding =
                    [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                             "_dispatcherBindingImpl")>]
                    static member _dispatcherBindingImpl
                        (
                            getBinding: unit -> option<obj>,
                            metadata:
                                ``.``.TypesJs.Decoder.TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata
                        ) : option<obj> =
                        JS.undefined

                    [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                             "wrapWorkflowBinding")>]
                    static member wrapWorkflowBinding
                        (
                            metadata:
                                ``.``.TypesJs.Decoder.TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata,
                            ?options:
                                ``.``.BindingJs.Decoder.TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistBinding.WrapWorkflowBindingOptions
                        ) : option<obj> =
                        JS.undefined

            module rec TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistEntrypoint =
                module rec DispatchWorkflow =
                    type _Lit3 =
                        abstract Item: key: string -> option<obj>

                    type Invoke =
                        abstract run:
                            event:
                                ``.``.TypesJs.Decoder.TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.WorkflowEventLike<
                                    'T
                                 > *
                            step: obj ->
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
                            ``.``.TypesJs.Decoder.TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.WorkflowEventLike<
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

                    [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/entrypoint",
                             "dispatchWorkflow")>]
                    static member dispatchWorkflow<'Result, 'Params, 'Env>
                        (
                            context: DispatchWorkflow._Lit1,
                            event:
                                ``.``.TypesJs.Decoder.TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.WorkflowEventLike<
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

            module rec TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes =
                module rec LoadWorkflowRunner =
                    type Invoke =
                        abstract run:
                            event:
                                ``.``.TypesJs.Decoder.TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.WorkflowEventLike<
                                    'T
                                 > *
                            step: obj ->
                                Promise<'R>

                [<Import("@cloudflare/dynamic-workflows.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/types",
                         "WorkflowRunner")>]
                type WorkflowRunner<'R, 'T> =
                    abstract run:
                        event:
                            ``.``.TypesJs.Decoder.TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.WorkflowEventLike<
                                'T
                             > *
                        step: obj ->
                            Promise<'R>

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

                    abstract metadata:
                        ``.``.TypesJs.Decoder.TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata with get, set

module rec ``.`` =
    module rec BindingJs =
        module rec Decoder =
            module rec TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistBinding =
                [<Import("./binding.js.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                         "DynamicWorkflowBindingProps")>]
                type DynamicWorkflowBindingProps =
                    abstract metadata:
                        TypesJs.Decoder.TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata with get, set

                    abstract bindingName: string with get, set

                [<Import("./binding.js.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                         "WrapWorkflowBindingOptions")>]
                type WrapWorkflowBindingOptions =
                    abstract bindingName: option<string> with get, set

    module rec TypesJs =
        module rec Decoder =
            module rec TestsFixturesDynamicWorkflowsNodeModulesCloudflareDynamicWorkflowsDistTypes =
                type DispatcherMetadata = obj

                [<Import("./types.js.Decoder.Tests/fixtures/dynamic-workflows/node_modules/@cloudflare/dynamic-workflows/dist/types",
                         "WorkflowEventLike")>]
                type WorkflowEventLike<'T> =
                    abstract instanceId: string with get, set
                    abstract timestamp: Date with get, set
                    abstract payload: 'T with get, set
