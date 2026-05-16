module rec Cloudflare =
    module rec DynamicWorkflows =
        module rec CloudEdgeNodeModulesCloudflareDynamicWorkflowsDistBinding =
            module rec UnwrapParams =
                type _Lit2 =
                    abstract params: 'T with get, set
                    abstract metadata: CloudEdgeNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata with get, set

            [<Import("@cloudflare/dynamic-workflows.CloudEdge/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                     "WrapWorkflowBindingOptions")>]
            type WrapWorkflowBindingOptions =
                abstract bindingName: option<string> with get, set

            [<Import("@cloudflare/dynamic-workflows.CloudEdge/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                     "DynamicWorkflowBinding");
              AbstractClass;
              AllowNullLiteral>]
            type DynamicWorkflowBinding private () =
                inherit option<obj<DynamicWorkflowBinding, DynamicWorkflowBindingProps>>()
                abstract impl: option<obj> with get, set
                abstract get: id: string -> Promise<option<obj>>
                abstract createBatch: batch: ResizeArray<option<obj>> -> Promise<Types.Node.Array<option<obj>>>
                abstract create: ?options: obj -> Promise<option<obj>>

            [<Import("@cloudflare/dynamic-workflows.CloudEdge/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                     "DynamicWorkflowBindingProps")>]
            type DynamicWorkflowBindingProps =
                abstract metadata: CloudEdgeNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata with get, set
                abstract bindingName: string with get, set

            type ICloudEdgeNodeModulesCloudflareDynamicWorkflowsDistBinding =
                [<Import("@cloudflare/dynamic-workflows.CloudEdge/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                         "_dispatcherBindingImpl")>]
                static member _dispatcherBindingImpl
                    (
                        getBinding: unit -> option<obj>,
                        metadata: CloudEdgeNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata
                    ) : option<obj> =
                    JS.undefined

                [<Import("@cloudflare/dynamic-workflows.CloudEdge/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                         "unwrapParams")>]
                static member unwrapParams<'T>(payload: option<obj>) : option<UnwrapParams._Lit2> = JS.undefined

                [<Import("@cloudflare/dynamic-workflows.CloudEdge/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                         "wrapWorkflowBinding")>]
                static member wrapWorkflowBinding
                    (
                        metadata: CloudEdgeNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata,
                        ?options: WrapWorkflowBindingOptions
                    ) : option<obj> =
                    JS.undefined

                [<Import("@cloudflare/dynamic-workflows.CloudEdge/node_modules/@cloudflare/dynamic-workflows/dist/binding",
                         "wrapParams")>]
                static member wrapParams<'T>
                    (params: 'T, metadata: CloudEdgeNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherMetadata)
                    : CloudEdgeNodeModulesCloudflareDynamicWorkflowsDistTypes.DispatcherEnvelope<'T> =
                    JS.undefined

        module rec CloudEdgeNodeModulesCloudflareDynamicWorkflowsDistEntrypoint =
            module rec CreateDynamicWorkflowEntrypoint =
                type Invoke =
                    abstract run:
                        event: CloudEdgeNodeModulesCloudflareDynamicWorkflowsDistTypes.WorkflowEventLike<'T> *
                        step: WorkflowStepLike ->
                            Promise<'R>

            module rec DispatchWorkflow =
                type _Lit1 =
                    abstract ctx: option<obj> with get, set
                    abstract env: 'Env with get, set

            [<Import("@cloudflare/dynamic-workflows.CloudEdge/node_modules/@cloudflare/dynamic-workflows/dist/entrypoint",
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
                    event: CloudEdgeNodeModulesCloudflareDynamicWorkflowsDistTypes.WorkflowEventLike<option<obj>> *
                    step: WorkflowStepLike *
                    loadRunner:
                        CloudEdgeNodeModulesCloudflareDynamicWorkflowsDistTypes.LoadWorkflowRunnerContext<'Env>
                            -> U2<DispatchWorkflow.Invoke.LoadRunner, Promise<DispatchWorkflow.Invoke.LoadRunner>> ->
                        Promise<'Result>

            type ICloudEdgeNodeModulesCloudflareDynamicWorkflowsDistEntrypoint =
                [<Import("@cloudflare/dynamic-workflows.CloudEdge/node_modules/@cloudflare/dynamic-workflows/dist/entrypoint",
                         "dispatchWorkflow")>]
                static member dispatchWorkflow<'Env, 'Params, 'Result>
                    (
                        context: DispatchWorkflow._Lit1,
                        event: CloudEdgeNodeModulesCloudflareDynamicWorkflowsDistTypes.WorkflowEventLike<option<obj>>,
                        step: WorkflowStepLike,
                        loadRunner:
                            CloudEdgeNodeModulesCloudflareDynamicWorkflowsDistTypes.LoadWorkflowRunnerContext<'Env>
                                -> U2<DispatchWorkflow.LoadRunner, Promise<DispatchWorkflow.LoadRunner>>
                    ) : Promise<'Result> =
                    JS.undefined

                [<Import("@cloudflare/dynamic-workflows.CloudEdge/node_modules/@cloudflare/dynamic-workflows/dist/entrypoint",
                         "createDynamicWorkflowEntrypoint")>]
                static member createDynamicWorkflowEntrypoint<'Env, 'Params, 'Result>
                    (
                        loadRunner:
                            CloudEdgeNodeModulesCloudflareDynamicWorkflowsDistTypes.LoadWorkflowRunnerContext<'Env>
                                -> U2<
                                    CreateDynamicWorkflowEntrypoint.LoadRunner,
                                    Promise<CreateDynamicWorkflowEntrypoint.LoadRunner>
                                 >
                    ) : option<obj> =
                    JS.undefined

        module rec CloudEdgeNodeModulesCloudflareDynamicWorkflowsDistTypes =
            module rec DispatcherEnvelope =
                type _Lit1 =
                    abstract Item: key: string -> option<obj>

            module rec LoadWorkflowRunner =
                type Invoke =
                    abstract run: event: WorkflowEventLike<'T> * step: WorkflowStepLike -> Promise<'R>

            [<Import("@cloudflare/dynamic-workflows.CloudEdge/node_modules/@cloudflare/dynamic-workflows/dist/types",
                     "WorkflowEventLike")>]
            type WorkflowEventLike<'T> =
                abstract instanceId: string with get, set
                abstract timestamp: Date with get, set
                abstract payload: 'T with get, set

            [<Import("@cloudflare/dynamic-workflows.CloudEdge/node_modules/@cloudflare/dynamic-workflows/dist/types",
                     "LoadWorkflowRunnerContext")>]
            type LoadWorkflowRunnerContext<'Env> =
                abstract ctx: option<obj> with get, set
                abstract env: 'Env with get, set
                abstract metadata: DispatcherMetadata with get, set

            [<Import("@cloudflare/dynamic-workflows.CloudEdge/node_modules/@cloudflare/dynamic-workflows/dist/types",
                     "LoadWorkflowRunner")>]
            type LoadWorkflowRunner<'Env, 'T, 'R> =
                abstract Invoke:
                    context: LoadWorkflowRunnerContext<'Env> ->
                        U2<Promise<LoadWorkflowRunner.Invoke>, LoadWorkflowRunner.Invoke>

            [<Import("@cloudflare/dynamic-workflows.CloudEdge/node_modules/@cloudflare/dynamic-workflows/dist/types",
                     "WorkflowRunner")>]
            type WorkflowRunner<'T, 'R> =
                abstract run: event: WorkflowEventLike<'T> * step: WorkflowStepLike -> Promise<'R>

            [<Import("@cloudflare/dynamic-workflows.CloudEdge/node_modules/@cloudflare/dynamic-workflows/dist/types",
                     "DispatcherEnvelope")>]
            type DispatcherEnvelope<'T> =
                abstract params: 'T with get, set

                [<EmitProperty("__dispatcherMetadata")>]
                abstract _dispatcherMetadata: DispatcherMetadata with get, set

            type DispatcherMetadata = obj

        type WorkflowStepLike = obj

module rec Types =
    module rec Node =
        module rec Array =
            module rec Flat =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type D = | [<CompiledValue(1)>] ``1``

            module rec _Lit8 =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Recur = | [<CompiledName("done")>] Done

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit40 =
                | [<CompiledName("short")>] Short
                | [<CompiledName("long")>] Long
                | [<CompiledName("shortOffset")>] ShortOffset
                | [<CompiledName("longOffset")>] LongOffset
                | [<CompiledName("shortGeneric")>] ShortGeneric
                | [<CompiledName("longGeneric")>] LongGeneric

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit38 =
                | [<CompiledName("numeric")>] Numeric
                | [<CompiledName("2-digit")>] ``2Digit``

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit37 =
                | [<CompiledName("h11")>] H11
                | [<CompiledName("h12")>] H12
                | [<CompiledName("h23")>] H23
                | [<CompiledName("h24")>] H24

            type _Lit36 =
                | ``1`` = 1
                | ``2`` = 2
                | ``3`` = 3

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit35 =
                | [<CompiledName("short")>] Short
                | [<CompiledName("long")>] Long
                | [<CompiledName("full")>] Full
                | [<CompiledName("medium")>] Medium

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit34 =
                | [<CompiledName("basic")>] Basic
                | [<CompiledName("best fit")>] Bestfit

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit31 =
                | [<CompiledValue(false)>] False
                | [<CompiledValue(true)>] True
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("always")>] Always
                | [<CompiledName("min2")>] Min2
                | [<CompiledName("true")>] True
                | [<CompiledName("false")>] False

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit29 =
                | [<CompiledName("symbol")>] Symbol
                | [<CompiledName("code")>] Code
                | [<CompiledName("name")>] Name
                | [<CompiledName("narrowSymbol")>] NarrowSymbol

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit27 =
                | [<CompiledName("decimal")>] Decimal
                | [<CompiledName("percent")>] Percent
                | [<CompiledName("currency")>] Currency
                | [<CompiledName("unit")>] Unit

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit26 =
                | [<CompiledName("best fit")>] Bestfit
                | [<CompiledName("lookup")>] Lookup

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit25 =
                | [<CompiledName("standard")>] Standard
                | [<CompiledName("accounting")>] Accounting

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit24 =
                | [<CompiledName("narrow")>] Narrow
                | [<CompiledName("short")>] Short
                | [<CompiledName("long")>] Long

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit22 =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("never")>] Never
                | [<CompiledName("always")>] Always
                | [<CompiledName("exceptZero")>] ExceptZero
                | [<CompiledName("negative")>] Negative

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit21 =
                | [<CompiledName("standard")>] Standard
                | [<CompiledName("scientific")>] Scientific
                | [<CompiledName("engineering")>] Engineering
                | [<CompiledName("compact")>] Compact

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit39 =
                | [<CompiledName("narrow")>] Narrow
                | [<CompiledName("short")>] Short
                | [<CompiledName("long")>] Long
                | [<CompiledName("numeric")>] Numeric
                | [<CompiledName("2-digit")>] ``2Digit``

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit41 =
                | [<CompiledName("basic")>] Basic
                | [<CompiledName("best fit")>] Bestfit

            type _Lit51 =
                abstract Invoke: value: 'T * index: float * array: ResizeArray<'T> -> unit

            type _Lit6 =
                abstract Invoke: value: 'T * index: float * array: ReadonlyArray -> bool

            type _Lit7 =
                abstract Invoke: value: 'T * index: float * array: ReadonlyArray -> option<obj>

            type _Lit4 =
                abstract Invoke:
                    this: 'This * value: 'T * index: float * array: ResizeArray<'T> -> U2<ReadonlyArray<'U>, 'U>

            type _Lit9 =
                [<EmitProperty("__@unscopables@210")>]
                abstract _unscopables210: option<_Lit10> with get, set

                [<EmitProperty("__@iterator@208")>]
                abstract _iterator208: option<_Lit10> with get, set

                [<EmitProperty("with")>]
                abstract ``with``: option<_Lit10> with get, set

                abstract toSpliced: option<_Lit10> with get, set
                abstract toSorted: option<_Lit10> with get, set
                abstract toReversed: option<_Lit10> with get, set
                abstract findLastIndex: option<_Lit10> with get, set
                abstract findLast: option<_Lit10> with get, set
                abstract at: option<_Lit10> with get, set
                abstract flat: option<_Lit10> with get, set
                abstract flatMap: option<_Lit10> with get, set
                abstract includes: option<_Lit10> with get, set
                abstract values: option<_Lit10> with get, set
                abstract keys: option<_Lit10> with get, set
                abstract entries: option<_Lit10> with get, set
                abstract findIndex: option<_Lit10> with get, set
                abstract find: option<_Lit10> with get, set
                abstract reduceRight: option<_Lit10> with get, set
                abstract reduce: option<_Lit10> with get, set
                abstract filter: option<_Lit10> with get, set
                abstract map: option<_Lit10> with get, set
                abstract forEach: option<_Lit10> with get, set
                abstract some: option<_Lit10> with get, set
                abstract every: option<_Lit10> with get, set
                abstract lastIndexOf: option<_Lit10> with get, set
                abstract indexOf: option<_Lit10> with get, set
                abstract slice: option<_Lit10> with get, set
                abstract join: option<_Lit10> with get, set
                abstract concat: option<_Lit10> with get, set
                abstract toLocaleString: option<_Lit10> with get, set
                abstract toString: option<_Lit10> with get, set
                abstract length: option<_Lit10> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit10 =
                | [<CompiledValue(false)>] False
                | [<CompiledValue(true)>] True

            type _Lit11 =
                abstract Invoke: value: 'T * index: float * obj: ReadonlyArray -> bool

            type _Lit12 =
                abstract Invoke: value: 'T * index: float * obj: ReadonlyArray -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit15 =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("morePrecision")>] MorePrecision
                | [<CompiledName("lessPrecision")>] LessPrecision

            type _Lit16 =
                | ``1`` = 1
                | ``2`` = 2
                | ``5`` = 5
                | ``10`` = 10
                | ``20`` = 20
                | ``25`` = 25
                | ``50`` = 50
                | ``100`` = 100
                | ``200`` = 200
                | ``250`` = 250
                | ``500`` = 500
                | ``1000`` = 1000
                | ``2000`` = 2000
                | ``2500`` = 2500
                | ``5000`` = 5000

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit17 =
                | [<CompiledName("ceil")>] Ceil
                | [<CompiledName("floor")>] Floor
                | [<CompiledName("expand")>] Expand
                | [<CompiledName("trunc")>] Trunc
                | [<CompiledName("halfCeil")>] HalfCeil
                | [<CompiledName("halfFloor")>] HalfFloor
                | [<CompiledName("halfExpand")>] HalfExpand
                | [<CompiledName("halfTrunc")>] HalfTrunc
                | [<CompiledName("halfEven")>] HalfEven

            type _Lit54 =
                abstract Invoke:
                    previousValue: 'U * currentValue: 'T * currentIndex: float * array: ResizeArray<'T> -> 'U

            type _Lit53 =
                abstract Invoke:
                    previousValue: 'T * currentValue: 'T * currentIndex: float * array: ResizeArray<'T> -> 'T

            type _Lit52 =
                abstract Invoke: value: 'T * index: float * array: ResizeArray<'T> -> 'U

            type _Lit14 =
                abstract timeZone: option<string> with get, set
                abstract hour12: option<bool> with get, set
                abstract formatMatcher: option<_Lit41> with get, set
                abstract timeZoneName: option<_Lit40> with get, set
                abstract second: option<_Lit38> with get, set
                abstract minute: option<_Lit38> with get, set
                abstract hour: option<_Lit38> with get, set
                abstract day: option<_Lit38> with get, set
                abstract month: option<_Lit39> with get, set
                abstract year: option<_Lit38> with get, set
                abstract era: option<_Lit24> with get, set
                abstract weekday: option<_Lit24> with get, set
                abstract localeMatcher: option<_Lit26> with get, set
                abstract hourCycle: option<_Lit37> with get, set
                abstract timeStyle: option<_Lit35> with get, set
                abstract dateStyle: option<_Lit35> with get, set
                abstract numberingSystem: option<string> with get, set
                abstract dayPeriod: option<_Lit24> with get, set
                abstract calendar: option<string> with get, set
                abstract fractionalSecondDigits: option<_Lit36> with get, set
                abstract dayPeriod: option<_Lit24> with get, set
                abstract timeStyle: option<_Lit35> with get, set
                abstract dateStyle: option<_Lit35> with get, set
                abstract formatMatcher: option<_Lit34> with get, set
                abstract maximumSignificantDigits: option<float> with get, set
                abstract minimumSignificantDigits: option<float> with get, set
                abstract maximumFractionDigits: option<float> with get, set
                abstract minimumFractionDigits: option<float> with get, set
                abstract minimumIntegerDigits: option<float> with get, set
                abstract useGrouping: option<_Lit31> with get, set
                abstract currencyDisplay: option<_Lit29> with get, set
                abstract currency: option<string> with get, set
                abstract style: option<_Lit27> with get, set
                abstract localeMatcher: option<_Lit26> with get, set
                abstract currencySign: option<_Lit25> with get, set
                abstract unitDisplay: option<_Lit24> with get, set
                abstract unit: option<string> with get, set
                abstract signDisplay: option<_Lit22> with get, set
                abstract notation: option<_Lit21> with get, set
                abstract compactDisplay: option<_Lit20> with get, set
                abstract numberingSystem: option<string> with get, set
                abstract trailingZeroDisplay: option<_Lit18> with get, set
                abstract roundingMode: option<_Lit17> with get, set
                abstract roundingIncrement: option<_Lit16> with get, set
                abstract roundingPriority: option<_Lit15> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit18 =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("stripIfInteger")>] StripIfInteger

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit20 =
                | [<CompiledName("short")>] Short
                | [<CompiledName("long")>] Long

            type _Lit47 =
                abstract Invoke: previousValue: 'U * currentValue: 'T * currentIndex: float * array: ReadonlyArray -> 'U

            type _Lit46 =
                abstract Invoke: previousValue: 'T * currentValue: 'T * currentIndex: float * array: ReadonlyArray -> 'T

            type _Lit45 =
                abstract Invoke: value: 'T * index: float * array: ReadonlyArray -> 'U

            type _Lit44 =
                abstract Invoke: value: 'T * index: float * array: ReadonlyArray -> unit

            type _Lit50 =
                abstract Invoke: value: 'T * index: float * obj: ResizeArray<'T> -> option<obj>

            type _Lit49 =
                abstract Invoke: value: 'T * index: float * obj: ResizeArray<'T> -> bool

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Flat = | [<CompiledName("done")>] Done

            type _Lit48 =
                [<EmitProperty("__@unscopables@210")>]
                abstract _unscopables210: option<_Lit10> with get, set

                [<EmitProperty("__@iterator@208")>]
                abstract _iterator208: option<_Lit10> with get, set

                [<EmitProperty("with")>]
                abstract ``with``: option<_Lit10> with get, set

                abstract toSpliced: option<_Lit10> with get, set
                abstract toSorted: option<_Lit10> with get, set
                abstract toReversed: option<_Lit10> with get, set
                abstract findLastIndex: option<_Lit10> with get, set
                abstract findLast: option<_Lit10> with get, set
                abstract at: option<_Lit10> with get, set
                abstract flat: option<_Lit10> with get, set
                abstract flatMap: option<_Lit10> with get, set
                abstract includes: option<_Lit10> with get, set
                abstract values: option<_Lit10> with get, set
                abstract keys: option<_Lit10> with get, set
                abstract entries: option<_Lit10> with get, set
                abstract copyWithin: option<_Lit10> with get, set
                abstract fill: option<_Lit10> with get, set
                abstract findIndex: option<_Lit10> with get, set
                abstract find: option<_Lit10> with get, set
                abstract reduceRight: option<_Lit10> with get, set
                abstract reduce: option<_Lit10> with get, set
                abstract filter: option<_Lit10> with get, set
                abstract map: option<_Lit10> with get, set
                abstract forEach: option<_Lit10> with get, set
                abstract some: option<_Lit10> with get, set
                abstract every: option<_Lit10> with get, set
                abstract lastIndexOf: option<_Lit10> with get, set
                abstract indexOf: option<_Lit10> with get, set
                abstract unshift: option<_Lit10> with get, set
                abstract splice: option<_Lit10> with get, set
                abstract sort: option<_Lit10> with get, set
                abstract slice: option<_Lit10> with get, set
                abstract shift: option<_Lit10> with get, set
                abstract reverse: option<_Lit10> with get, set
                abstract join: option<_Lit10> with get, set
                abstract concat: option<_Lit10> with get, set
                abstract push: option<_Lit10> with get, set
                abstract pop: option<_Lit10> with get, set
                abstract toLocaleString: option<_Lit10> with get, set
                abstract toString: option<_Lit10> with get, set
                abstract length: option<_Lit10> with get, set

            type _Lit8 =
                abstract recur: U2<proptypekey<_Lit8, U2<_Lit8.Recur, _Lit8.Recur>>, 'Arr> with get, set

                [<EmitProperty("done")>]
                abstract ``done``: 'Arr with get, set

            type _Lit1 =
                abstract Invoke: value: 'T * index: float * array: ResizeArray<'T> -> bool

            type _Lit2 =
                abstract Invoke: value: 'T * index: float * array: ResizeArray<'T> -> option<obj>

        module rec NodeJS =
            [<Import("@types/node.NodeJS", "CallSite")>]
            type CallSite =
                abstract isToplevel: unit -> bool
                abstract isPromiseAll: unit -> bool
                abstract isNative: unit -> bool
                abstract isEval: unit -> bool
                abstract isConstructor: unit -> bool
                abstract isAsync: unit -> bool
                abstract getTypeName: unit -> option<string>
                abstract getThis: unit -> option<obj>
                abstract getScriptNameOrSourceURL: unit -> option<string>
                abstract getScriptHash: unit -> string
                abstract getPromiseIndex: unit -> option<float>
                abstract getPosition: unit -> float
                abstract getMethodName: unit -> option<string>
                abstract getLineNumber: unit -> option<float>
                abstract getFunctionName: unit -> option<string>
                abstract getFunction: unit -> option<Function>
                abstract getFileName: unit -> option<string>
                abstract getEvalOrigin: unit -> option<string>
                abstract getEnclosingLineNumber: unit -> option<float>
                abstract getEnclosingColumnNumber: unit -> option<float>
                abstract getColumnNumber: unit -> option<float>

        module rec ReadonlyArray =
            module rec Flat =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type D = | [<CompiledValue(1)>] ``1``

        [<Import("@types/node", "Array")>]
        type Array<'T> =
            inherit RelativeIndexable<'T>
            abstract length: float with get, set

            [<EmitProperty("[Symbol.unscopables]")>]
            abstract symbolUnscopables: Array._Lit48 with get

            abstract Item: n: float -> 'T
            abstract reduceRight<'U> : callbackfn: Array._Lit54 * initialValue: 'U -> 'U
            abstract reduceRight: callbackfn: Array._Lit53 * initialValue: 'T -> 'T
            abstract reduceRight: callbackfn: Array._Lit53 -> 'T
            abstract reduce<'U> : callbackfn: Array._Lit54 * initialValue: 'U -> 'U
            abstract reduce: callbackfn: Array._Lit53 * initialValue: 'T -> 'T
            abstract reduce: callbackfn: Array._Lit53 -> 'T
            abstract filter: predicate: Array._Lit2 * ?thisArg: obj -> ResizeArray<'T>
            abstract filter<'S when 'S :> 'T> : predicate: Array._Lit1 * ?thisArg: obj -> ResizeArray<'S>
            abstract map<'U> : callbackfn: Array._Lit52 * ?thisArg: obj -> ResizeArray<'U>
            abstract forEach: callbackfn: Array._Lit51 * ?thisArg: obj -> unit
            abstract some: predicate: Array._Lit2 * ?thisArg: obj -> bool
            abstract every: predicate: Array._Lit2 * ?thisArg: obj -> bool
            abstract every<'S when 'S :> 'T> : predicate: Array._Lit1 * ?thisArg: obj -> bool
            abstract lastIndexOf: searchElement: 'T * ?fromIndex: float -> float
            abstract indexOf: searchElement: 'T * ?fromIndex: float -> float
            abstract unshift: [<ParamArray>] items: ResizeArray<'T> -> float

            abstract splice:
                start: float * deleteCount: float * [<ParamArray>] items: ResizeArray<'T> -> ResizeArray<'T>

            abstract splice: start: float * ?deleteCount: float -> ResizeArray<'T>
            abstract sort: ?compareFn: 'T -> 'T -> float -> 'Array
            abstract slice: ?start: float * ?``end``: float -> ResizeArray<'T>
            abstract shift: unit -> option<'T>
            abstract reverse: unit -> ResizeArray<'T>
            abstract join: ?separator: string -> string

            abstract concat:
                [<ParamArray>] items: ResizeArray<U2<System.Collections.Generic.IReadOnlyList<'T>, 'T>> ->
                    ResizeArray<'T>

            abstract concat:
                [<ParamArray>] items: ResizeArray<System.Collections.Generic.IReadOnlyList<'T>> -> ResizeArray<'T>

            abstract push: [<ParamArray>] items: ResizeArray<'T> -> float
            abstract pop: unit -> option<'T>
            abstract toLocaleString: unit -> string
            abstract toString: unit -> string
            abstract toLocaleString: locales: U2<ResizeArray<string>, string> * ?options: Array._Lit14 -> string
            abstract copyWithin: target: float * start: float * ?``end``: float -> 'Array
            abstract fill: value: 'T * ?start: float * ?``end``: float -> 'Array
            abstract findIndex: predicate: Array._Lit50 * ?thisArg: obj -> float
            abstract find: predicate: Array._Lit50 * ?thisArg: obj -> option<'T>
            abstract find<'S when 'S :> 'T> : predicate: Array._Lit49 * ?thisArg: obj -> option<'S>
            abstract values: unit -> System.Collections.Generic.IEnumerator<'T>
            abstract keys: unit -> System.Collections.Generic.IEnumerator<float>
            abstract entries: unit -> System.Collections.Generic.IEnumerator<float * 'T>
            abstract symbolIterator: unit -> System.Collections.Generic.IEnumerator<'T>
            abstract includes: searchElement: 'T * ?fromIndex: float -> bool

            abstract flat<'A, 'D> :
                this: 'A * ?depth: 'D -> ResizeArray<proptypekey<Array._Lit8, U2<Array.Flat, Array.Flat>>>

            abstract flatMap<'U, 'This> : callback: Array._Lit4 * ?thisArg: 'This -> ResizeArray<'U>
            abstract at: index: float -> option<'T>
            abstract ``with``: index: float * value: 'T -> ResizeArray<'T>
            abstract toSpliced: start: float * ?deleteCount: float -> ResizeArray<'T>

            abstract toSpliced:
                start: float * deleteCount: float * [<ParamArray>] items: ResizeArray<'T> -> ResizeArray<'T>

            abstract toSorted: ?compareFn: 'T -> 'T -> float -> ResizeArray<'T>
            abstract toReversed: unit -> ResizeArray<'T>
            abstract findLastIndex: predicate: Array._Lit2 * ?thisArg: obj -> float
            abstract findLast: predicate: Array._Lit2 * ?thisArg: obj -> option<'T>
            abstract findLast<'S when 'S :> 'T> : predicate: Array._Lit1 * ?thisArg: obj -> option<'S>

        [<Import("@types/node", "Disposable")>]
        type Disposable =
            abstract symbolDispose: unit -> unit
            abstract symbolDispose: unit -> unit

        [<Import("@types/node", "RelativeIndexable")>]
        type RelativeIndexable<'T> =
            abstract at: index: float -> option<'T>

        [<Import("@types/node", "ErrorConstructor")>]
        type ErrorConstructor =
            abstract prototype: exn with get
            abstract stackTraceLimit: float with get, set
            abstract Invoke: ?message: string -> exn
            abstract Create: ?message: string -> exn
            abstract Invoke: ?message: string * ?options: ErrorOptions -> exn
            abstract Create: ?message: string * ?options: ErrorOptions -> exn
            abstract isError: ?error: obj -> bool
            abstract prepareStackTrace: err: exn * stackTraces: ResizeArray<NodeJS.CallSite> -> option<obj>

            abstract captureStackTrace:
                targetObject: Cloudflare.DynamicWorkflows.WorkflowStepLike * ?constructorOpt: Function -> unit

        [<Import("@types/node", "ReadonlyArray")>]
        type ReadonlyArray<'T> =
            inherit RelativeIndexable<'T>
            abstract length: float with get

            [<EmitProperty("[Symbol.unscopables]")>]
            abstract symbolUnscopables: Array._Lit9 with get

            abstract Item: n: float -> 'T
            abstract reduceRight<'U> : callbackfn: Array._Lit47 * initialValue: 'U -> 'U
            abstract reduceRight: callbackfn: Array._Lit46 * initialValue: 'T -> 'T
            abstract reduceRight: callbackfn: Array._Lit46 -> 'T
            abstract reduce<'U> : callbackfn: Array._Lit47 * initialValue: 'U -> 'U
            abstract reduce: callbackfn: Array._Lit46 * initialValue: 'T -> 'T
            abstract reduce: callbackfn: Array._Lit46 -> 'T
            abstract filter: predicate: Array._Lit7 * ?thisArg: obj -> ResizeArray<'T>
            abstract filter<'S when 'S :> 'T> : predicate: Array._Lit6 * ?thisArg: obj -> ResizeArray<'S>
            abstract map<'U> : callbackfn: Array._Lit45 * ?thisArg: obj -> ResizeArray<'U>
            abstract forEach: callbackfn: Array._Lit44 * ?thisArg: obj -> unit
            abstract some: predicate: Array._Lit7 * ?thisArg: obj -> bool
            abstract every: predicate: Array._Lit7 * ?thisArg: obj -> bool
            abstract every<'S when 'S :> 'T> : predicate: Array._Lit6 * ?thisArg: obj -> bool
            abstract lastIndexOf: searchElement: 'T * ?fromIndex: float -> float
            abstract indexOf: searchElement: 'T * ?fromIndex: float -> float
            abstract slice: ?start: float * ?``end``: float -> ResizeArray<'T>
            abstract join: ?separator: string -> string

            abstract concat:
                [<ParamArray>] items: ResizeArray<U2<System.Collections.Generic.IReadOnlyList<'T>, 'T>> ->
                    ResizeArray<'T>

            abstract concat:
                [<ParamArray>] items: ResizeArray<System.Collections.Generic.IReadOnlyList<'T>> -> ResizeArray<'T>

            abstract toLocaleString: unit -> string
            abstract toString: unit -> string
            abstract toLocaleString: locales: U2<ResizeArray<string>, string> * ?options: Array._Lit14 -> string
            abstract findIndex: predicate: Array._Lit12 * ?thisArg: obj -> float
            abstract find: predicate: Array._Lit12 * ?thisArg: obj -> option<'T>
            abstract find<'S when 'S :> 'T> : predicate: Array._Lit11 * ?thisArg: obj -> option<'S>
            abstract values: unit -> System.Collections.Generic.IEnumerator<'T>
            abstract keys: unit -> System.Collections.Generic.IEnumerator<float>
            abstract entries: unit -> System.Collections.Generic.IEnumerator<float * 'T>
            abstract symbolIterator: unit -> System.Collections.Generic.IEnumerator<'T>
            abstract includes: searchElement: 'T * ?fromIndex: float -> bool

            abstract flat<'A, 'D> :
                this: 'A * ?depth: 'D ->
                    ResizeArray<proptypekey<Array._Lit8, U2<ReadonlyArray.Flat, ReadonlyArray.Flat>>>

            abstract flatMap<'U, 'This> : callback: Array._Lit4 * ?thisArg: 'This -> ResizeArray<'U>
            abstract at: index: float -> option<'T>
            abstract ``with``: index: float * value: 'T -> ResizeArray<'T>
            abstract toSpliced: start: float * ?deleteCount: float -> ResizeArray<'T>

            abstract toSpliced:
                start: float * deleteCount: float * [<ParamArray>] items: ResizeArray<'T> -> ResizeArray<'T>

            abstract toSorted: ?compareFn: 'T -> 'T -> float -> ResizeArray<'T>
            abstract toReversed: unit -> ResizeArray<'T>
            abstract findLastIndex: predicate: Array._Lit7 * ?thisArg: obj -> float
            abstract findLast: predicate: Array._Lit7 * ?thisArg: obj -> option<'T>
            abstract findLast<'S when 'S :> 'T> : predicate: Array._Lit6 * ?thisArg: obj -> option<'S>
