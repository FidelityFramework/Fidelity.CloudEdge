type ICloudflare =


module Cloudflare =
    type IWorkersTypes =
        [<Erase>]
        member cache: CacheContext = JS.undefined

        [<Erase>]
        member tracing: Tracing = JS.undefined

        [<Erase>]
        member __RPC_TARGET_BRAND: __RPC_TARGET_BRAND = JS.undefined

        [<CompiledName("_EmailMessage")>]
        member _emailMessage: _EmailMessage = JS.undefined

        [<Erase>]
        member __RPC_STUB_BRAND: __RPC_STUB_BRAND = JS.undefined

        [<Import("@cloudflare/workers-types", "_connect")>]
        static member _connect(address: U2<SocketAddress, D1SessionBookmark>, ?options: SocketOptions) : Socket =
            JS.undefined

        [<Import("@cloudflare/workers-types", "atob")>]
        static member atob(data: D1SessionBookmark) : D1SessionBookmark = JS.undefined

        [<Import("@cloudflare/workers-types", "atob")>]
        static member atob(data: D1SessionBookmark) : D1SessionBookmark = JS.undefined

        [<Import("@cloudflare/workers-types", "btoa")>]
        static member btoa(data: D1SessionBookmark) : D1SessionBookmark = JS.undefined

        [<Import("@cloudflare/workers-types", "btoa")>]
        static member btoa(data: D1SessionBookmark) : D1SessionBookmark = JS.undefined

        [<Erase>]
        member __WORKER_ENTRYPOINT_BRAND: __WORKER_ENTRYPOINT_BRAND = JS.undefined

        [<Import("@cloudflare/workers-types", "reportError")>]
        static member reportError(error: option<obj>) : unit = JS.undefined

        [<Import("@cloudflare/workers-types", "reportError")>]
        static member reportError(e: option<obj>) : unit = JS.undefined

        [<CompiledName("RpcStub")>]
        member rpcStub: RpcStub = JS.undefined

        [<Erase>]
        member onRequest: OnRequest -> U2<Typescript.Response, Promise<Typescript.Response>> =
            JS.undefined

        [<Import("@cloudflare/workers-types", "setInterval")>]
        static member setInterval(callback: SetInterval.Callback, ?msDelay: float, [<ParamArray>] args: 'Args) : float =
            JS.undefined

        [<Import("@cloudflare/workers-types", "setInterval")>]
        static member setInterval(callback: SetInterval.Callback, ?msDelay: float) : float = JS.undefined

        [<Import("@cloudflare/workers-types", "setInterval")>]
        static member setInterval
            (handler: U2<Function, D1SessionBookmark>, ?timeout: float, [<ParamArray>] arguments: Array<option<obj>>)
            : float =
            JS.undefined

        [<Import("@cloudflare/workers-types", "queueMicrotask")>]
        static member queueMicrotask(task: Function) : unit = JS.undefined

        [<Import("@cloudflare/workers-types", "queueMicrotask")>]
        static member queueMicrotask(callback: VoidFunction) : unit = JS.undefined

        [<Import("@cloudflare/workers-types", "setTimeout")>]
        static member setTimeout(callback: SetTimeout.Callback, ?msDelay: float, [<ParamArray>] args: 'Args) : float =
            JS.undefined

        [<Import("@cloudflare/workers-types", "setTimeout")>]
        static member setTimeout(callback: SetTimeout.Callback, ?msDelay: float) : float = JS.undefined

        [<Import("@cloudflare/workers-types", "setTimeout")>]
        static member setTimeout
            (handler: U2<Function, D1SessionBookmark>, ?timeout: float, [<ParamArray>] arguments: Array<option<obj>>)
            : float =
            JS.undefined

        [<Erase>]
        member __DURABLE_OBJECT_BRAND: __DURABLE_OBJECT_BRAND = JS.undefined

        [<Import("@cloudflare/workers-types", "clearInterval")>]
        static member clearInterval(timeoutId: option<float>) : unit = JS.undefined

        [<Import("@cloudflare/workers-types", "clearInterval")>]
        static member clearInterval(id: option<float>) : unit = JS.undefined

        [<Erase>]
        member __WORKFLOW_ENTRYPOINT_BRAND: __WORKFLOW_ENTRYPOINT_BRAND = JS.undefined

        [<Import("@cloudflare/workers-types", "clearTimeout")>]
        static member clearTimeout(timeoutId: option<float>) : unit = JS.undefined

        [<Import("@cloudflare/workers-types", "clearTimeout")>]
        static member clearTimeout(id: option<float>) : unit = JS.undefined

        [<Import("@cloudflare/workers-types", "dispatchEvent")>]
        static member dispatchEvent
            (event: U4<PromiseRejectionEvent, QueueEvent<option<obj>>, ScheduledEvent, FetchEvent>)
            : bool =
            JS.undefined

        [<Import("@cloudflare/workers-types", "dispatchEvent")>]
        static member dispatchEvent(event: Event) : bool = JS.undefined

        [<Import("@cloudflare/workers-types", "structuredClone")>]
        static member structuredClone(value: 'T, ?options: Typescript.StructuredSerializeOptions) : 'T = JS.undefined

        [<Import("@cloudflare/workers-types", "structuredClone")>]
        static member structuredClone(value: 'T, ?options: Typescript.StructuredSerializeOptions) : 'T = JS.undefined

        [<CompiledName("Cloudflare")>]
        member cloudflare: Cloudflare = JS.undefined

        [<Import("@cloudflare/workers-types", "addEventListener")>]
        static member addEventListener
            (``type``: 'Type, handler: Typescript.Body, ?options: U2<EventTargetAddEventListenerOptions, bool>)
            : unit =
            JS.undefined

        [<Import("@cloudflare/workers-types", "addEventListener")>]
        static member addEventListener
            (
                ``type``: 'K,
                listener: Window -> proptypekey<WindowEventMap, 'K> -> option<obj>,
                ?options: U2<AddEventListenerOptions, bool>
            ) : unit =
            JS.undefined

        [<Import("@cloudflare/workers-types", "fetch")>]
        static member fetch
            (
                input:
                    U3<Typescript.Request<option<obj>, U2<RequestInitCfProperties, Fetch.Input>>, URL, D1SessionBookmark>,
                ?init: Typescript.RequestInit<RequestInitCfProperties>
            ) : Promise<Typescript.Response> =
            JS.undefined

        [<Import("@cloudflare/workers-types", "fetch")>]
        static member fetch
            (
                input:
                    U3<Typescript.Request<option<obj>, U2<RequestInitCfProperties, Fetch.Input>>, URL, D1SessionBookmark>,
                ?init: Typescript.RequestInit<U2<RequestInitCfProperties, Fetch.Init>>
            ) : Promise<Typescript.Response> =
            JS.undefined

        [<Import("@cloudflare/workers-types", "removeEventListener")>]
        static member removeEventListener
            (``type``: 'Type, handler: Typescript.Body, ?options: U2<EventTargetEventListenerOptions, bool>)
            : unit =
            JS.undefined

        [<Import("@cloudflare/workers-types", "removeEventListener")>]
        static member removeEventListener
            (
                ``type``: 'K,
                listener: Window -> proptypekey<WindowEventMap, 'K> -> option<obj>,
                ?options: U2<EventListenerOptions, bool>
            ) : unit =
            JS.undefined

    module WorkersTypes =
        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseStreamEvent =
            | [<CompiledName("response.refusal.delta")>] ``Response.refusal.delta``
            | [<CompiledName("response.reasoning_text.done")>] ``Response.reasoningText.done``
            | [<CompiledName("response.reasoning_text.delta")>] ``Response.reasoningText.delta``
            | [<CompiledName("response.output_item.done")>] ``Response.outputItem.done``
            | [<CompiledName("response.output_item.added")>] ``Response.outputItem.added``
            | [<CompiledName("response.incomplete")>] ``Response.incomplete``
            | [<CompiledName("response.failed")>] ``Response.failed``
            | [<CompiledName("response.function_call_arguments.done")>] ``Response.functionCallArguments.done``
            | [<CompiledName("response.function_call_arguments.delta")>] ``Response.functionCallArguments.delta``
            | [<CompiledName("error")>] Error
            | [<CompiledName("response.created")>] ``Response.created``
            | [<CompiledName("response.refusal.done")>] ``Response.refusal.done``
            | [<CompiledName("response.output_text.delta")>] ``Response.outputText.delta``
            | [<CompiledName("response.output_text.done")>] ``Response.outputText.done``
            | [<CompiledName("response.completed")>] ``Response.completed``

        type RpcStub =
            [<CompiledName("[__RPC_STUB_BRAND]")>]
            abstract ``[_rPCSTUBBRAND]``: 'T with get, set

            [<CompiledName("[Symbol.unscopables]")>]
            abstract ``[symbol.unscopables]``: RpcStub.``[Symbol.unscopables]`` with get

            abstract length: float with get, set

            [<CompiledName("__@unscopables@355")>]
            abstract ``_@unscopables@355``: option<RpcStub.``_@unscopables@355``> with get, set

            [<CompiledName("__@iterator@353")>]
            abstract ``_@iterator@353``: option<RpcStub.``_@iterator@353``> with get, set

            [<CompiledName("with")>]
            abstract ``with``: option<RpcStub.With> with get, set

            abstract toSpliced: option<RpcStub.ToSpliced> with get, set
            abstract toSorted: option<RpcStub.ToSorted> with get, set
            abstract toReversed: option<RpcStub.ToReversed> with get, set
            abstract findLastIndex: option<RpcStub.FindLastIndex> with get, set
            abstract findLast: option<RpcStub.FindLast> with get, set
            abstract at: option<RpcStub.At> with get, set
            abstract flat: option<RpcStub.Flat> with get, set
            abstract flatMap: option<RpcStub.FlatMap> with get, set
            abstract includes: option<RpcStub.Includes> with get, set
            abstract values: option<RpcStub.Values> with get, set
            abstract keys: option<RpcStub.Keys> with get, set
            abstract entries: option<RpcStub.Entries> with get, set
            abstract copyWithin: option<RpcStub.CopyWithin> with get, set
            abstract fill: option<RpcStub.Fill> with get, set
            abstract findIndex: option<RpcStub.FindIndex> with get, set
            abstract find: option<RpcStub.Find> with get, set
            abstract reduceRight: option<RpcStub.ReduceRight> with get, set
            abstract reduce: option<RpcStub.Reduce> with get, set
            abstract filter: option<RpcStub.Filter> with get, set
            abstract map: option<RpcStub.Map> with get, set
            abstract forEach: option<RpcStub.ForEach> with get, set
            abstract some: option<RpcStub.Some> with get, set
            abstract every: option<RpcStub.Every> with get, set
            abstract lastIndexOf: option<RpcStub.LastIndexOf> with get, set
            abstract indexOf: option<RpcStub.IndexOf> with get, set
            abstract unshift: option<RpcStub.Unshift> with get, set
            abstract splice: option<RpcStub.Splice> with get, set
            abstract sort: option<RpcStub.Sort> with get, set
            abstract slice: option<RpcStub.Slice> with get, set
            abstract shift: option<RpcStub.Shift> with get, set
            abstract reverse: option<RpcStub.Reverse> with get, set
            abstract join: option<RpcStub.Join> with get, set
            abstract concat: option<RpcStub.Concat> with get, set
            abstract push: option<RpcStub.Push> with get, set
            abstract pop: option<RpcStub.Pop> with get, set
            abstract toLocaleString: option<RpcStub.ToLocaleString> with get, set
            abstract toString: option<RpcStub.ToString> with get, set
            abstract length: option<RpcStub.Length> with get, set
            abstract recur: U2<proptypekey<RpcStub.Recur, U2<RpcStub.Recur, RpcStub.Recur>>, 'Arr> with get, set

            [<CompiledName("done")>]
            abstract ``done``: 'Arr with get, set

            abstract Create: value: 'T -> CloudflareWorkersModule.RpcStub
            abstract ``[symbol.dispose]``: unit -> unit
            abstract dup: unit -> 'StubBase
            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke: [<ParamArray>] args: RpcStub.RpcStub.Args -> U2<RpcStub.RpcStub, U2<RpcStub.RpcStub, unit>>
            abstract ``[symbol.iterator]``: unit -> ArrayIterator<'T>
            abstract ``with``: index: float * value: 'T -> Array
            abstract toSpliced: start: float * deleteCount: float * [<ParamArray>] items: Array -> Array
            abstract toSorted: ?compareFn: 'T -> 'T -> float -> Array
            abstract toReversed: unit -> Array
            abstract findLastIndex: predicate: RpcStub.FindLastIndex.Predicate * ?thisArg: obj -> float
            abstract findLast: predicate: RpcStub.FindLast.Predicate * ?thisArg: obj -> option<'S>
            abstract at: index: float -> option<'T>
            abstract flat: this: 'A * ?depth: 'D -> Array<proptypekey<RpcStub.Flat, U2<RpcStub.Flat, RpcStub.Flat>>>
            abstract flatMap: callback: RpcStub.FlatMap.Callback * ?thisArg: 'This -> Array<'U>
            abstract includes: searchElement: 'T * ?fromIndex: float -> bool
            abstract values: unit -> ArrayIterator<'T>
            abstract keys: unit -> ArrayIterator<float>
            abstract entries: unit -> ArrayIterator<float * 'T>
            abstract copyWithin: target: float * start: float * ?``end``: float -> 'Array
            abstract fill: value: 'T * ?start: float * ?``end``: float -> 'Array
            abstract findIndex: predicate: RpcStub.FindIndex.Predicate * ?thisArg: obj -> float
            abstract find: predicate: RpcStub.Find.Predicate * ?thisArg: obj -> option<'S>
            abstract reduceRight: callbackfn: RpcStub.ReduceRight.Callbackfn -> 'T
            abstract reduce: callbackfn: RpcStub.Reduce.Callbackfn -> 'T
            abstract filter: predicate: RpcStub.Filter.Predicate * ?thisArg: obj -> Array<'S>
            abstract map: callbackfn: RpcStub.Map.Callbackfn * ?thisArg: obj -> Array<'U>
            abstract forEach: callbackfn: RpcStub.ForEach.Callbackfn * ?thisArg: obj -> unit
            abstract some: predicate: RpcStub.Some.Predicate * ?thisArg: obj -> bool
            abstract every: predicate: RpcStub.Every.Predicate * ?thisArg: obj -> bool
            abstract lastIndexOf: searchElement: 'T * ?fromIndex: float -> float
            abstract indexOf: searchElement: 'T * ?fromIndex: float -> float
            abstract unshift: [<ParamArray>] items: Array -> float
            abstract splice: start: float * ?deleteCount: float -> Array
            abstract sort: ?compareFn: 'T -> 'T -> float -> 'Array
            abstract slice: ?start: float * ?``end``: float -> Array
            abstract shift: unit -> option<'T>
            abstract reverse: unit -> Array
            abstract join: ?separator: D1SessionBookmark -> D1SessionBookmark
            abstract concat: [<ParamArray>] items: Array<ConcatArray<'T>> -> Array
            abstract push: [<ParamArray>] items: Array -> float
            abstract pop: unit -> option<'T>
            abstract toLocaleString: unit -> D1SessionBookmark
            abstract toString: unit -> D1SessionBookmark
            abstract Invoke: value: 'T * index: float * array: Array -> bool
            abstract Invoke: value: 'T * index: float * array: Array -> option<obj>
            abstract Invoke: this: 'This * value: 'T * index: float * array: Array -> U2<'U, ReadonlyArray<'U>>
            abstract Invoke: value: 'T * index: float * obj: Array -> option<obj>
            abstract Invoke: value: 'T * index: float * obj: Array -> bool
            abstract Invoke: previousValue: 'T * currentValue: 'T * currentIndex: float * array: Array -> 'T
            abstract Invoke: value: 'T * index: float * array: Array -> 'U
            abstract Invoke: value: 'T * index: float * array: Array -> unit

        type AiTextToSpeechOutput = U2<Uint8Array<ArrayBufferLike>, AiTextToSpeechOutput>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Deepgram_Aura_2_Es")>]
        type BaseAiCfDeepgramAura2Es =
            abstract postProcessedOutputs: D1SessionBookmark with get, set
            abstract inputs: AiCfDeepgramAura2EsInput with get, set

        [<Import("@cloudflare/workers-types", "ConversionOptions")>]
        type ConversionOptions =
            abstract pdf: option<ConversionOptions.Pdf> with get, set
            abstract image: option<ImageConversionOptions> with get, set
            abstract docx: option<ConversionOptions.Docx> with get, set
            abstract html: option<ConversionOptions.Html> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Output_EmbeddingFor_Contexts")>]
        type AiCfBaaiBgeM3OutputEmbeddingForContexts =
            abstract pooling: option<AiCfBaaiBgeM3OutputEmbeddingForContexts.Pooling> with get, set
            abstract shape: option<AiSentenceSimilarityOutput> with get, set
            abstract response: option<Array<AiSentenceSimilarityOutput>> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_Embedding_0_6B_Input")>]
        type AiCfQwenQwen3Embedding06BInput =
            abstract text: option<U2<Array<D1SessionBookmark>, D1SessionBookmark>> with get, set
            abstract documents: option<U2<Array<D1SessionBookmark>, D1SessionBookmark>> with get, set
            abstract instruction: option<D1SessionBookmark> with get, set
            abstract queries: option<U2<Array<D1SessionBookmark>, D1SessionBookmark>> with get, set

        [<Import("@cloudflare/workers-types", "ArtifactsCreateRepoResult")>]
        type ArtifactsCreateRepoResult =
            abstract tokenExpiresAt: D1SessionBookmark with get, set
            abstract token: D1SessionBookmark with get, set
            abstract remote: D1SessionBookmark with get, set
            abstract defaultBranch: D1SessionBookmark with get, set
            abstract description: option<D1SessionBookmark> with get, set
            abstract name: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "RequestInitCfPropertiesR2")>]
        type RequestInitCfPropertiesR2 =
            abstract bucketColoId: option<float> with get, set

        [<Import("@cloudflare/workers-types", "ImageMetadata")>]
        type ImageMetadata =
            abstract creator: option<D1SessionBookmark> with get, set
            abstract draft: option<bool> with get, set
            abstract variants: Array<D1SessionBookmark> with get, set
            abstract meta: option<ImageMetadata.Meta> with get, set
            abstract requireSignedURLs: bool with get, set
            abstract uploaded: option<D1SessionBookmark> with get, set
            abstract filename: option<D1SessionBookmark> with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ResponseReasoningTextDeltaEvent")>]
        type ResponseReasoningTextDeltaEvent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseReasoningTextDeltaEvent.Type with get, set

            [<CompiledName("sequence_number")>]
            abstract sequenceNumber: float with get, set

            [<CompiledName("output_index")>]
            abstract outputIndex: float with get, set

            [<CompiledName("item_id")>]
            abstract itemId: D1SessionBookmark with get, set

            abstract delta: D1SessionBookmark with get, set

            [<CompiledName("content_index")>]
            abstract contentIndex: float with get, set

        type AiCfBaaiBgeSmallEnV15Output = U2<AiCfBaaiBgeSmallEnV15Output, AiCfBaaiBgeSmallEnV15AsyncResponse>

        [<Import("@cloudflare/workers-types", "KVNamespaceGetOptions")>]
        type KVNamespaceGetOptions<'Type> =
            abstract cacheTtl: option<float> with get, set

            [<CompiledName("type")>]
            abstract ``type``: 'Type with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type VectorizeVectorMetadataFilterOp =
            | [<CompiledName("$eq")>] ``$eq``
            | [<CompiledName("$ne")>] ``$ne``
            | [<CompiledName("$lt")>] ``$lt``
            | [<CompiledName("$lte")>] ``$lte``
            | [<CompiledName("$gt")>] ``$gt``
            | [<CompiledName("$gte")>] ``$gte``

        [<Import("@cloudflare/workers-types", "ImageConversionOptions")>]
        type ImageConversionOptions =
            abstract descriptionLanguage: option<ImageConversionOptions.DescriptionLanguage> with get, set

        [<Import("@cloudflare/workers-types", "KVNamespaceGetWithMetadataResult")>]
        type KVNamespaceGetWithMetadataResult<'Metadata, 'Value> =
            abstract cacheStatus: option<D1SessionBookmark> with get, set
            abstract metadata: option<'Metadata> with get, set
            abstract value: option<'Value> with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectPutOptions")>]
        type DurableObjectPutOptions =
            abstract noCache: option<bool> with get, set
            abstract allowUnconfirmed: option<bool> with get, set
            abstract allowConcurrency: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "ResponseFormatJSONSchema")>]
        type ResponseFormatJSONSchema =
            [<CompiledName("json_schema")>]
            abstract jsonSchema: ResponseFormatJSONSchema.JsonSchema with get, set

            [<CompiledName("type")>]
            abstract ``type``: ResponseFormatJSONSchema.Type with get, set

        [<Import("@cloudflare/workers-types", "R2ListOptions")>]
        type R2ListOptions =
            abstract startAfter: option<D1SessionBookmark> with get, set
            abstract delimiter: option<D1SessionBookmark> with get, set
            abstract cursor: option<D1SessionBookmark> with get, set
            abstract prefix: option<D1SessionBookmark> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "ImageTransformer")>]
        type ImageTransformer =
            abstract output: options: ImageOutputOptions -> Promise<ImageTransformationResult>

            abstract draw:
                image: U2<ReadableStream<Uint8Array<ArrayBufferLike>>, ImageTransformer> * ?options: ImageDrawOptions ->
                    ImageTransformer

            abstract transform: transform: ImageTransform -> ImageTransformer

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type Iso3166Alpha2Code =
            | AD
            | AE
            | AF
            | AG
            | AI
            | AL
            | AM
            | AO
            | AQ
            | AR
            | AS
            | AT
            | AU
            | AW
            | AX
            | AZ
            | BA
            | BB
            | BD
            | BE
            | BF
            | BG
            | BH
            | BI
            | BJ
            | BL
            | BM
            | BN
            | BO
            | BQ
            | BR
            | BS
            | BT
            | BV
            | BW
            | BY
            | BZ
            | CA
            | CC
            | CD
            | CF
            | CG
            | CH
            | CI
            | CK
            | CL
            | CM
            | CN
            | CO
            | CR
            | CU
            | CV
            | CW
            | CX
            | CY
            | CZ
            | DE
            | DJ
            | DK
            | DM
            | DO
            | DZ
            | EC
            | EE
            | EG
            | EH
            | ER
            | ES
            | ET
            | FI
            | FJ
            | FK
            | FM
            | FO
            | FR
            | GA
            | GB
            | GD
            | GE
            | GF
            | GG
            | GH
            | GI
            | GL
            | GM
            | GN
            | GP
            | GQ
            | GR
            | GS
            | GT
            | GU
            | GW
            | GY
            | HK
            | HM
            | HN
            | HR
            | HT
            | HU
            | ID
            | IE
            | IL
            | IM
            | IN
            | IO
            | IQ
            | IR
            | IS
            | IT
            | JE
            | JM
            | JO
            | JP
            | KE
            | KG
            | KH
            | KI
            | KM
            | KN
            | KP
            | KR
            | KW
            | KY
            | KZ
            | LA
            | LB
            | LC
            | LI
            | LK
            | LR
            | LS
            | LT
            | LU
            | LV
            | LY
            | MA
            | MC
            | MD
            | ME
            | MF
            | MG
            | MH
            | MK
            | ML
            | MM
            | MN
            | MO
            | MP
            | MQ
            | MR
            | MS
            | MT
            | MU
            | MV
            | MW
            | MX
            | MY
            | MZ
            | NA
            | NC
            | NE
            | NF
            | NG
            | NI
            | NL
            | NO
            | NP
            | NR
            | NU
            | NZ
            | OM
            | PA
            | PE
            | PF
            | PG
            | PH
            | PK
            | PL
            | PM
            | PN
            | PR
            | PS
            | PT
            | PW
            | PY
            | QA
            | RE
            | RO
            | RS
            | RU
            | RW
            | SA
            | SB
            | SC
            | SD
            | SE
            | SG
            | SH
            | SI
            | SJ
            | SK
            | SL
            | SM
            | SN
            | SO
            | SR
            | SS
            | ST
            | SV
            | SX
            | SY
            | SZ
            | TC
            | TD
            | TF
            | TG
            | TH
            | TJ
            | TK
            | TL
            | TM
            | TN
            | TO
            | TR
            | TT
            | TV
            | TW
            | TZ
            | UA
            | UG
            | UM
            | US
            | UY
            | UZ
            | VA
            | VC
            | VE
            | VG
            | VI
            | VN
            | VU
            | WF
            | WS
            | YE
            | YT
            | ZA
            | ZM
            | ZW

        type AiCfQwenQwen330BA3BFp8Output =
            U4<
                AiCfQwenQwen330BA3BFp8ChatCompletionResponse,
                AiCfQwenQwen330BA3BFp8TextCompletionResponse,
                AiCfQwenQwen330BA3BFp8AsyncResponse,
                D1SessionBookmark
             >

        [<Import("@cloudflare/workers-types", "ChatCompletionTokenLogprob")>]
        type ChatCompletionTokenLogprob =
            [<CompiledName("top_logprobs")>]
            abstract topLogprobs: Array<ChatCompletionTopLogprob> with get, set

            abstract bytes: option<AiSentenceSimilarityOutput> with get, set
            abstract logprob: float with get, set
            abstract token: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ByteLengthQueuingStrategy")>]
        type ByteLengthQueuingStrategy =
            [<EmitConstructor>]
            abstract Create: init: Typescript.QueuingStrategyInit -> ByteLengthQueuingStrategy

            inherit Typescript.QueuingStrategy<ArrayBufferView<ArrayBufferLike>, 'ByteLengthQueuingStrategy><
                ArrayBufferView<ArrayBufferLike>
             >

            abstract highWaterMark: float with get
            abstract size: ?chunk: obj -> float

        type ResponseFormatTextConfig =
            U3<ResponseFormatText, ResponseFormatTextJSONSchemaConfig, ResponseFormatJSONObject>

        [<Import("@cloudflare/workers-types", "AiGateway")>]
        type AiGateway =
            abstract getUrl: ?provider: U2<AiGateway.GetUrl.Provider, D1SessionBookmark> -> Promise<D1SessionBookmark>

            abstract run:
                data: U2<AIGatewayUniversalRequest, Array<AIGatewayUniversalRequest>> * ?options: AiGateway.Run.Options ->
                    Promise<Typescript.Response>

            abstract getLog: logId: D1SessionBookmark -> Promise<AiGatewayLog>
            abstract patchLog: logId: D1SessionBookmark * data: AiGatewayPatchLog -> Promise<unit>

        [<Import("@cloudflare/workers-types", "Container")>]
        type Container =
            abstract running: bool with get

            abstract interceptOutboundHttps:
                addr: D1SessionBookmark * binding: Container.InterceptOutboundHttps.Binding -> Promise<unit>

            abstract snapshotContainer: options: ContainerSnapshotOptions -> Promise<ContainerSnapshot>

            abstract snapshotDirectory:
                options: ContainerDirectorySnapshotOptions -> Promise<ContainerDirectorySnapshot>

            abstract interceptAllOutboundHttp: binding: Container.InterceptAllOutboundHttp.Binding -> Promise<unit>

            abstract interceptOutboundHttp:
                addr: D1SessionBookmark * binding: Container.InterceptOutboundHttp.Binding -> Promise<unit>

            abstract setInactivityTimeout: durationMs: float -> Promise<unit>
            abstract getTcpPort: port: float -> Container.GetTcpPort
            abstract signal: signo: float -> unit
            abstract destroy: ?error: obj -> Promise<unit>
            abstract monitor: unit -> Promise<unit>
            abstract start: ?options: ContainerStartupOptions -> unit

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type DurableObjectLocationHint =
            | [<CompiledName("wnam")>] Wnam
            | [<CompiledName("enam")>] Enam
            | [<CompiledName("sam")>] Sam
            | [<CompiledName("weur")>] Weur
            | [<CompiledName("eeur")>] Eeur
            | [<CompiledName("apac")>] Apac
            | [<CompiledName("oc")>] Oc
            | [<CompiledName("afr")>] Afr
            | [<CompiledName("me")>] Me

        [<Import("@cloudflare/workers-types", "Ai_Cf_Google_Gemma_3_12B_It_Messages")>]
        type AiCfGoogleGemma312BItMessages =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            abstract tools: option<Array<U2<AiCfGoogleGemma312BItMessages.Tools, AiCfGoogleGemma312BItMessages.Tools>>> with get, set
            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: Array<AiCfGoogleGemma312BItMessages.Messages> with get, set

        [<Import("@cloudflare/workers-types", "ContainerSnapshotOptions")>]
        type ContainerSnapshotOptions =
            abstract name: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "StreamWatermark")>]
        type StreamWatermark =
            abstract position: StreamWatermarkPosition with get, set
            abstract scale: float with get, set
            abstract padding: float with get, set
            abstract opacity: float with get, set
            abstract name: D1SessionBookmark with get, set
            abstract downloadedFrom: option<D1SessionBookmark> with get, set
            abstract created: D1SessionBookmark with get, set
            abstract width: float with get, set
            abstract height: float with get, set
            abstract size: float with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Doctype")>]
        type Doctype =
            abstract systemId: option<D1SessionBookmark> with get
            abstract publicId: option<D1SessionBookmark> with get
            abstract name: option<D1SessionBookmark> with get

        [<Import("@cloudflare/workers-types", "AiSearchJobLogsResponse")>]
        type AiSearchJobLogsResponse =
            [<CompiledName("result_info")>]
            abstract resultInfo: option<AiSearchJobLogsResponse.ResultInfo> with get, set

            abstract result: Array<AiSearchJobLog> with get, set

        [<Import("@cloudflare/workers-types", "AiTextGenerationResponseFormat")>]
        type AiTextGenerationResponseFormat =
            [<CompiledName("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<CompiledName("type")>]
            abstract ``type``: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Dev_Input")>]
        type AiCfBlackForestLabsFlux2DevInput =
            abstract multipart: AiCfBlackForestLabsFlux2DevInput.Multipart with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode")>]
        type AiCfQwenQwen330BA3BFp8JSONMode =
            [<CompiledName("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<AiCfQwenQwen330BA3BFp8JSONMode.Type> with get, set

        [<Import("@cloudflare/workers-types", "TraceItem")>]
        type TraceItem =
            abstract wallTime: float with get
            abstract cpuTime: float with get
            abstract truncated: bool with get
            abstract executionModel: D1SessionBookmark with get
            abstract outcome: D1SessionBookmark with get
            abstract durableObjectId: option<D1SessionBookmark> with get
            abstract preview: option<TracePreviewInfo> with get
            abstract tailAttributes: option<TraceItem.TailAttributes> with get
            abstract scriptTags: option<Array<D1SessionBookmark>> with get
            abstract dispatchNamespace: option<D1SessionBookmark> with get
            abstract scriptVersion: option<ScriptVersion> with get
            abstract entrypoint: option<D1SessionBookmark> with get
            abstract scriptName: option<D1SessionBookmark> with get
            abstract diagnosticsChannelEvents: Array<TraceDiagnosticChannelEvent> with get
            abstract exceptions: Array<TraceException> with get
            abstract logs: Array<TraceLog> with get
            abstract eventTimestamp: option<float> with get

            abstract event:
                option<
                    U10<
                        TraceItemFetchEventInfo,
                        TraceItemJsRpcEventInfo,
                        TraceItemConnectEventInfo,
                        TraceItemScheduledEventInfo,
                        TraceItemAlarmEventInfo,
                        TraceItemQueueEventInfo,
                        TraceItemEmailEventInfo,
                        TraceItemTailEventInfo,
                        TraceItemCustomEventInfo,
                        TraceItemHibernatableWebSocketEventInfo
                     >
                 > with get

        [<Import("@cloudflare/workers-types", "HelloWorldBinding")>]
        type HelloWorldBinding =
            abstract set: value: D1SessionBookmark -> Promise<unit>
            abstract get: unit -> Promise<HelloWorldBinding.Get>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct")>]
        type BaseAiCfQwenQwen25Coder32BInstruct =
            abstract postProcessedOutputs: AiCfQwenQwen25Coder32BInstructOutput with get, set
            abstract inputs: AiCfQwenQwen25Coder32BInstructInput with get, set

        type AiCfMetaLlama3370BInstructFp8FastOutput =
            [<CompiledName("total_tokens")>]
            abstract totalTokens: option<float> with get, set

            [<CompiledName("completion_tokens")>]
            abstract completionTokens: option<float> with get, set

            [<CompiledName("prompt_tokens")>]
            abstract promptTokens: option<float> with get, set

            [<CompiledName("tool_calls")>]
            abstract toolCalls: option<Array<AiCfMetaLlama3370BInstructFp8FastOutput.ToolCalls>> with get, set

            abstract usage: option<AiCfMetaLlama3370BInstructFp8FastOutput.Usage> with get, set
            abstract response: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "TextDecoderDecodeOptions")>]
        type TextDecoderDecodeOptions =
            abstract stream: bool with get, set

        [<Import("@cloudflare/workers-types", "D1Database")>]
        type D1Database =
            abstract dump: unit -> Promise<ArrayBuffer>

            abstract withSession:
                ?constraintOrBookmark: U2<D1Database.WithSession.ConstraintOrBookmark, D1SessionBookmark> ->
                    D1DatabaseSession

            abstract exec: query: D1SessionBookmark -> Promise<D1ExecResult>
            abstract batch: statements: Array<D1PreparedStatement> -> Promise<Array<D1Database.Batch>>
            abstract prepare: query: D1SessionBookmark -> D1PreparedStatement

        [<Import("@cloudflare/workers-types", "ResponseInputText")>]
        type ResponseInputText =
            [<CompiledName("type")>]
            abstract ``type``: ResponseInputText.Type with get, set

            abstract text: D1SessionBookmark with get, set

        type RemoveEventListener =
            abstract Invoke:
                ``type``: 'Type * handler: Typescript.Body * ?options: U2<EventTargetEventListenerOptions, bool> -> unit

            abstract Invoke:
                ``type``: D1SessionBookmark *
                listener: EventListenerOrEventListenerObject *
                ?options: U2<EventListenerOptions, bool> ->
                    unit

            abstract Invoke:
                ``type``: 'K *
                listener: Window -> proptypekey<WindowEventMap, 'K> -> option<obj> *
                ?options: U2<EventListenerOptions, bool> ->
                    unit

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast")>]
        type BaseAiCfMetaLlama3370BInstructFp8Fast =
            abstract postProcessedOutputs:
                U3<
                    BaseAiCfMetaLlama3370BInstructFp8Fast.PostProcessedOutputs,
                    AiCfMetaLlama3370BInstructFp8FastAsyncResponse,
                    D1SessionBookmark
                 > with get, set

            abstract inputs: AiCfMetaLlama3370BInstructFp8FastInput with get, set

        [<Import("@cloudflare/workers-types", "AiSearchCreateJobParams")>]
        type AiSearchCreateJobParams =
            abstract description: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Klein_4B_Output")>]
        type AiCfBlackForestLabsFlux2Klein4BOutput =
            abstract image: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ImageTransformationOutputOptions")>]
        type ImageTransformationOutputOptions =
            abstract encoding: option<ImageTransformationOutputOptions.Encoding> with get, set

        type ResponseContent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseContent.Type with get, set

            abstract text: D1SessionBookmark with get, set
            abstract refusal: D1SessionBookmark with get, set
            abstract logprobs: option<Array<Logprob>> with get, set

            [<CompiledName("image_url")>]
            abstract imageUrl: option<D1SessionBookmark> with get, set

            abstract detail: ResponseContent.Detail with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectSetAlarmOptions")>]
        type DurableObjectSetAlarmOptions =
            abstract allowUnconfirmed: option<bool> with get, set
            abstract allowConcurrency: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "FacetStartupOptions")>]
        type FacetStartupOptions<'T when 'T :> Rpc.DurableObjectBranded> =
            [<CompiledName("class")>]
            abstract ``class``: DurableObjectClass<'T> with get, set

            abstract id: option<U2<DurableObjectId, D1SessionBookmark>> with get, set

        [<Import("@cloudflare/workers-types", "EasyInputMessage")>]
        type EasyInputMessage =
            [<CompiledName("type")>]
            abstract ``type``: option<EasyInputMessage.Type> with get, set

            abstract role: EasyInputMessage.Role with get, set
            abstract content: U2<Array<U2<ResponseInputText, ResponseInputImage>>, D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "DigestStream")>]
        type DigestStream =
            [<EmitConstructor>]
            abstract Create: algorithm: U2<SubtleCryptoHashAlgorithm, D1SessionBookmark> -> DigestStream

            inherit WritableStream<U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>, 'DigestStream><
                U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>
             >

            abstract bytesWritten: float with get
            abstract digest: Promise<ArrayBuffer> with get

        [<Import("@cloudflare/workers-types", "ExportedHandlerQueueHandler")>]
        type ExportedHandlerQueueHandler<'Props, 'Message, 'Env> =
            abstract Invoke:
                batch: MessageBatch<'Message> * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages")>]
        type AiCfMetaLlama4Scout17B16EInstructMessages =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfMetaLlama4Scout17B16EInstructJSONMode> with get, set

            abstract tools:
                option<
                    Array<
                        U2<
                            AiCfMetaLlama4Scout17B16EInstructMessages.Tools,
                            AiCfMetaLlama4Scout17B16EInstructMessages.Tools
                         >
                     >
                 > with get, set

            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: Array<AiCfMetaLlama4Scout17B16EInstructMessages.Messages> with get, set

        [<Import("@cloudflare/workers-types", "ComparisonFilter")>]
        type ComparisonFilter =
            abstract value: U3<D1SessionBookmark, float, bool> with get, set

            [<CompiledName("type")>]
            abstract ``type``: ComparisonFilter.Type with get, set

            abstract key: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "CachePurgeOptions")>]
        type CachePurgeOptions =
            abstract purgeEverything: option<bool> with get, set
            abstract pathPrefixes: option<Array<D1SessionBookmark>> with get, set
            abstract tags: option<Array<D1SessionBookmark>> with get, set

        [<Import("@cloudflare/workers-types", "AiAutomaticSpeechRecognitionOutput")>]
        type AiAutomaticSpeechRecognitionOutput =
            abstract vtt: option<D1SessionBookmark> with get, set
            abstract words: option<Array<AiAutomaticSpeechRecognitionOutput.Words>> with get, set
            abstract text: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "R2Error")>]
        type R2Error =
            inherit Error
            abstract stack: option<obj> with get
            abstract action: D1SessionBookmark with get
            abstract message: D1SessionBookmark with get
            abstract code: float with get
            abstract name: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "ChatCompletionContentPartFile")>]
        type ChatCompletionContentPartFile =
            abstract file: ChatCompletionContentPartFile.File with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionContentPartFile.Type with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages")>]
        type AiCfQwenQwen25Coder32BInstructMessages =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfQwenQwen25Coder32BInstructJSONMode1> with get, set

            abstract tools:
                option<
                    Array<U2<AiCfQwenQwen25Coder32BInstructMessages.Tools, AiCfQwenQwen25Coder32BInstructMessages.Tools>>
                 > with get, set

            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: Array<AiCfQwenQwen25Coder32BInstructMessages.Messages> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct")>]
        type BaseAiCfMetaLlama3211BVisionInstruct =
            abstract postProcessedOutputs: AiCfMetaLlama3211BVisionInstructOutput with get, set
            abstract inputs: AiCfMetaLlama3211BVisionInstructInput with get, set

        [<Import("@cloudflare/workers-types", "ContainerDirectorySnapshotRestoreParams")>]
        type ContainerDirectorySnapshotRestoreParams =
            abstract mountPoint: option<D1SessionBookmark> with get, set
            abstract snapshot: ContainerDirectorySnapshot with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Openai_Whisper_Output")>]
        type AiCfOpenaiWhisperOutput =
            abstract vtt: option<D1SessionBookmark> with get, set
            abstract words: option<Array<AiCfOpenaiWhisperOutput.Words>> with get, set

            [<CompiledName("word_count")>]
            abstract wordCount: option<float> with get, set

            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectListOptions")>]
        type DurableObjectListOptions =
            abstract noCache: option<bool> with get, set
            abstract allowConcurrency: option<bool> with get, set
            abstract limit: option<float> with get, set
            abstract reverse: option<bool> with get, set
            abstract prefix: option<D1SessionBookmark> with get, set

            [<CompiledName("end")>]
            abstract ``end``: option<D1SessionBookmark> with get, set

            abstract startAfter: option<D1SessionBookmark> with get, set
            abstract start: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ImagesBinding")>]
        type ImagesBinding =
            abstract hosted: HostedImagesBinding with get

            abstract input:
                stream: ReadableStream<Uint8Array<ArrayBufferLike>> * ?options: ImageInputOptions -> ImageTransformer

            abstract info:
                stream: ReadableStream<Uint8Array<ArrayBufferLike>> * ?options: ImageInputOptions ->
                    Promise<ImageInfoResponse>

        type AiCfBaaiBgeSmallEnV15Input = U2<AiCfBaaiBgeSmallEnV15Input, AiCfBaaiBgeSmallEnV15Input>

        [<Import("@cloudflare/workers-types", "ResponseFunctionToolCallOutputItem")>]
        type ResponseFunctionToolCallOutputItem =
            abstract status: option<ResponseFunctionToolCallOutputItem.Status> with get, set

            [<CompiledName("type")>]
            abstract ``type``: ResponseFunctionToolCallOutputItem.Type with get, set

            abstract output: U2<Array<ResponseInputContent>, D1SessionBookmark> with get, set

            [<CompiledName("call_id")>]
            abstract callId: D1SessionBookmark with get, set

            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ResponseRefusalDeltaEvent")>]
        type ResponseRefusalDeltaEvent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseRefusalDeltaEvent.Type with get, set

            [<CompiledName("sequence_number")>]
            abstract sequenceNumber: float with get, set

            [<CompiledName("output_index")>]
            abstract outputIndex: float with get, set

            [<CompiledName("item_id")>]
            abstract itemId: D1SessionBookmark with get, set

            abstract delta: D1SessionBookmark with get, set

            [<CompiledName("content_index")>]
            abstract contentIndex: float with get, set

        type Fetch =
            abstract Invoke:
                input:
                    U3<
                        Typescript.Request<option<obj>, U2<RequestInitCfProperties, Fetch.Fetch.Input>>,
                        URL,
                        D1SessionBookmark
                     > *
                ?init: Typescript.RequestInit<RequestInitCfProperties> ->
                    Promise<Typescript.Response>

            abstract Invoke:
                input:
                    U3<
                        Typescript.Request<option<obj>, U2<RequestInitCfProperties, Fetch.Fetch.Input>>,
                        URL,
                        D1SessionBookmark
                     > *
                ?init: Typescript.RequestInit<U2<RequestInitCfProperties, Fetch.Fetch.Init>> ->
                    Promise<Typescript.Response>

        [<Import("@cloudflare/workers-types", "ErrorEvent")>]
        type ErrorEvent =
            [<EmitConstructor>]
            abstract Create: ``type``: D1SessionBookmark * ?init: ErrorEventErrorEventInit -> ErrorEvent

            inherit Event
            abstract error: option<obj> with get
            abstract colno: float with get
            abstract lineno: float with get
            abstract message: D1SessionBookmark with get
            abstract filename: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "ToMarkdownService")>]
        type ToMarkdownService =
            abstract supported: unit -> Promise<Array<SupportedFileFormat>>

            abstract transform:
                files: MarkdownDocument * ?options: ConversionRequestOptions -> Promise<ConversionResponse>

            abstract transform:
                files: Array<MarkdownDocument> * ?options: ConversionRequestOptions ->
                    Promise<Array<ConversionResponse>>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Klein_4B_Input")>]
        type AiCfBlackForestLabsFlux2Klein4BInput =
            abstract multipart: AiCfBlackForestLabsFlux2Klein4BInput.Multipart with get, set

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesBotManagementBase")>]
        type IncomingRequestCfPropertiesBotManagementBase =
            abstract detectionIds: AiSentenceSimilarityOutput with get, set
            abstract staticResource: bool with get, set
            abstract corporateProxy: bool with get, set
            abstract verifiedBot: bool with get, set
            /// <example>
            /// 54
            /// </example>
            abstract score: float with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItemInfo")>]
        type AiSearchItemInfo =
            abstract metadata: option<AiSearchItemInfo.Metadata> with get, set

            [<CompiledName("created_at")>]
            abstract createdAt: option<D1SessionBookmark> with get, set

            [<CompiledName("last_seen_at")>]
            abstract lastSeenAt: option<D1SessionBookmark> with get, set

            [<CompiledName("source_id")>]
            abstract sourceId: option<D1SessionBookmark> with get, set

            [<CompiledName("file_size")>]
            abstract fileSize: option<float> with get, set

            [<CompiledName("chunks_count")>]
            abstract chunksCount: option<float> with get, set

            [<CompiledName("namespace")>]
            abstract ``namespace``: option<D1SessionBookmark> with get, set

            abstract checksum: option<D1SessionBookmark> with get, set
            abstract error: option<D1SessionBookmark> with get, set

            [<CompiledName("next_action")>]
            abstract nextAction: option<AiSearchItemInfo.NextAction> with get, set

            abstract status: AiSearchItemInfo.Status with get, set
            abstract key: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "TransformStream")>]
        type TransformStream<'O, 'I> =
            [<EmitConstructor>]
            abstract Create:
                ?transformer: Typescript.Transformer<'I, 'O> *
                ?writableStrategy: Typescript.QueuingStrategy<'I> *
                ?readableStrategy: Typescript.QueuingStrategy<'O> ->
                    TransformStream

            abstract writable: WritableStream<'I> with get
            abstract readable: ReadableStream<'O> with get

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_2")>]
        type AiCfQwenQwen330BA3BFp8JSONMode2 =
            [<CompiledName("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<AiCfQwenQwen330BA3BFp8JSONMode2.Type> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type __WORKER_ENTRYPOINT_BRAND = | __WORKER_ENTRYPOINT_BRAND

        [<Import("@cloudflare/workers-types", "TraceItemFetchEventInfoResponse")>]
        type TraceItemFetchEventInfoResponse =
            abstract status: float with get

        [<Import("@cloudflare/workers-types", "AiSearchJob")>]
        type AiSearchJob =
            abstract cancel: unit -> Promise<AiSearchJobInfo>
            abstract logs: ?params: AiSearchJobLogsParams -> Promise<AiSearchJobLogsResponse>
            abstract info: unit -> Promise<AiSearchJobInfo>

        [<Import("@cloudflare/workers-types", "VectorizeIndex")>]
        type VectorizeIndex =
            abstract getByIds: ids: Array<D1SessionBookmark> -> Promise<Array<VectorizeVector>>
            abstract deleteByIds: ids: Array<D1SessionBookmark> -> Promise<VectorizeVectorMutation>
            abstract upsert: vectors: Array<VectorizeVector> -> Promise<VectorizeVectorMutation>
            abstract insert: vectors: Array<VectorizeVector> -> Promise<VectorizeVectorMutation>

            abstract query:
                vector: U3<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>, AiSentenceSimilarityOutput> *
                ?options: VectorizeQueryOptions ->
                    Promise<VectorizeMatches>

            abstract describe: unit -> Promise<VectorizeIndexDetails>

        type IncomingRequestCfPropertiesEdgeRequestKeepAliveStatus =
            | ``0`` = 0
            | ``1`` = 1
            | ``2`` = 2
            | ``3`` = 3
            | ``4`` = 4
            | ``5`` = 5

        [<Import("@cloudflare/workers-types", "Blob")>]
        type Blob =
            [<EmitConstructor>]
            abstract Create:
                ?``type``: Array<U4<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, Blob, D1SessionBookmark>> *
                ?options: BlobOptions ->
                    Blob

            [<CompiledName("type")>]
            abstract ``type``: D1SessionBookmark with get

            abstract size: float with get
            abstract stream: unit -> ReadableStream<option<obj>>
            abstract text: unit -> Promise<D1SessionBookmark>
            abstract bytes: unit -> Promise<Uint8Array<ArrayBufferLike>>
            abstract arrayBuffer: unit -> Promise<ArrayBuffer>
            abstract slice: ?start: float * ?``end``: float * ?``type``: D1SessionBookmark -> Blob

        [<Import("@cloudflare/workers-types", "SubtleCryptoGenerateKeyAlgorithm")>]
        type SubtleCryptoGenerateKeyAlgorithm =
            abstract namedCurve: option<D1SessionBookmark> with get, set
            abstract length: option<float> with get, set
            abstract publicExponent: option<U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>> with get, set
            abstract modulusLength: option<float> with get, set
            abstract hash: option<U2<SubtleCryptoHashAlgorithm, D1SessionBookmark>> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "LoopbackColoLocalActorNamespace")>]
        type LoopbackColoLocalActorNamespace =
            interface
                inherit ColoLocalActorNamespace
            end

        type AiCfGoogleGemma312BItInput = U2<AiCfGoogleGemma312BItPrompt, AiCfGoogleGemma312BItMessages>

        [<Import("@cloudflare/workers-types", "ResponseFunctionCallArgumentsDeltaEvent")>]
        type ResponseFunctionCallArgumentsDeltaEvent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseFunctionCallArgumentsDeltaEvent.Type with get, set

            [<CompiledName("sequence_number")>]
            abstract sequenceNumber: float with get, set

            [<CompiledName("output_index")>]
            abstract outputIndex: float with get, set

            [<CompiledName("item_id")>]
            abstract itemId: D1SessionBookmark with get, set

            abstract delta: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ResponseFailedEvent")>]
        type ResponseFailedEvent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseFailedEvent.Type with get, set

            [<CompiledName("sequence_number")>]
            abstract sequenceNumber: float with get, set

            abstract response: Typescript.Response with get, set

        [<Import("@cloudflare/workers-types", "QueueRetryOptions")>]
        type QueueRetryOptions =
            abstract delaySeconds: option<float> with get, set

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesTLSClientAuthPlaceholder")>]
        type IncomingRequestCfPropertiesTLSClientAuthPlaceholder =
            abstract certNotAfter: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertNotAfter with get, set
            abstract certNotBefore: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertNotBefore with get, set
            abstract certFingerprintSHA256: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertFingerprintSHA256 with get, set
            abstract certFingerprintSHA1: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertFingerprintSHA1 with get, set
            abstract certIssuerSKI: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertIssuerSKI with get, set
            abstract certSKI: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertSKI with get, set
            abstract certIssuerSerial: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertIssuerSerial with get, set
            abstract certSerial: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertSerial with get, set
            abstract certSubjectDNLegacy: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertSubjectDNLegacy with get, set
            abstract certIssuerDNLegacy: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertIssuerDNLegacy with get, set
            abstract certSubjectDNRFC2253: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertSubjectDNRFC2253 with get, set
            abstract certIssuerDNRFC2253: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertIssuerDNRFC2253 with get, set
            abstract certSubjectDN: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertSubjectDN with get, set
            abstract certIssuerDN: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertIssuerDN with get, set
            abstract certRevoked: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertRevoked with get, set
            abstract certVerified: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertVerified with get, set
            abstract certPresented: IncomingRequestCfPropertiesTLSClientAuthPlaceholder.CertPresented with get, set

        [<Import("@cloudflare/workers-types", "WorkflowInstanceCreateOptions")>]
        type WorkflowInstanceCreateOptions<'PARAMS> =
            abstract retention: option<WorkflowInstanceCreateOptions.Retention> with get, set
            abstract params: option<'PARAMS> with get, set
            abstract id: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "EventTargetEventListenerOptions")>]
        type EventTargetEventListenerOptions =
            abstract capture: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "ExportedHandlerTailStreamHandler")>]
        type ExportedHandlerTailStreamHandler<'Props, 'Env> =
            abstract Invoke:
                event: TailStream.TailEvent<TailStream.Onset> * env: 'Env * ctx: ExecutionContext<'Props> ->
                    U3<
                        TailStream.TailEvent<'Event> -> option<Promise<unit>>,
                        TailStream.TailEventHandlerObject,
                        Promise<TailStream.TailEventHandlerType>
                     >

        [<Import("@cloudflare/workers-types", "Ai_Cf_Pfnet_Plamo_Embedding_1B_Input")>]
        type AiCfPfnetPlamoEmbedding1BInput =
            abstract text: U2<Array<D1SessionBookmark>, D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ResponsesOutput")>]
        type ResponsesOutput =
            abstract usage: option<ResponseUsage> with get, set
            abstract truncation: option<ResponsesOutput.Truncation> with get, set
            abstract text: option<ResponseTextConfig> with get, set
            abstract status: option<ResponsesOutput.Status> with get, set

            [<CompiledName("service_tier")>]
            abstract serviceTier: option<ResponsesOutput.ServiceTier> with get, set

            [<CompiledName("safety_identifier")>]
            abstract safetyIdentifier: option<D1SessionBookmark> with get, set

            abstract reasoning: option<Reasoning> with get, set
            abstract prompt: option<ResponsePrompt> with get, set

            [<CompiledName("previous_response_id")>]
            abstract previousResponseId: option<D1SessionBookmark> with get, set

            [<CompiledName("max_output_tokens")>]
            abstract maxOutputTokens: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract tools: option<Array<Tool>> with get, set

            [<CompiledName("tool_choice")>]
            abstract toolChoice: option<U2<ToolChoiceOptions, ToolChoiceFunction>> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("parallel_tool_calls")>]
            abstract parallelToolCalls: option<bool> with get, set

            abstract output: option<Array<ResponseOutputItem>> with get, set
            abstract object: option<ResponsesOutput.Object> with get, set

            abstract instructions:
                option<
                    U2<
                        Array<
                            U6<
                                ResponseOutputMessage,
                                ResponseFunctionToolCall,
                                ResponseReasoningItem,
                                EasyInputMessage,
                                ResponseInputItemMessage,
                                ResponseInputItemFunctionCallOutput
                             >
                         >,
                        D1SessionBookmark
                     >
                 > with get, set

            [<CompiledName("incomplete_details")>]
            abstract incompleteDetails: option<ResponseIncompleteDetails> with get, set

            abstract error: option<ResponseError> with get, set

            [<CompiledName("output_text")>]
            abstract outputText: option<D1SessionBookmark> with get, set

            [<CompiledName("created_at")>]
            abstract createdAt: option<float> with get, set

            abstract id: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "AssistantMessage")>]
        type AssistantMessage =
            [<CompiledName("function_call")>]
            abstract functionCall: option<AssistantMessage.FunctionCall> with get, set

            [<CompiledName("tool_calls")>]
            abstract toolCalls: option<Array<ChatCompletionMessageToolCall>> with get, set

            abstract audio: option<ResponseConversationParam> with get, set
            abstract name: option<D1SessionBookmark> with get, set
            abstract refusal: option<D1SessionBookmark> with get, set
            abstract content: option<U2<Array<AssistantMessageContentPart>, D1SessionBookmark>> with get, set
            abstract role: AssistantMessage.Role with get, set

        type HeadersInit =
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "VectorizeVectorMetadataFilter")>]
        type VectorizeVectorMetadataFilter =
            abstract Item:
                key: D1SessionBookmark ->
                    option<
                        U5<
                            VectorizeVectorMetadataFilter.VectorizeVectorMetadataFilter,
                            VectorizeVectorMetadataFilter.VectorizeVectorMetadataFilter,
                            VectorizeVectorMetadataFilter.VectorizeVectorMetadataFilter,
                            D1SessionBookmark,
                            float
                         >
                     >

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Prompt")>]
        type AiCfMetaLlama3370BInstructFp8FastPrompt =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfMetaLlama3370BInstructFp8FastJSONMode> with get, set

            abstract lora: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseFunctionToolCallItem =
            | [<CompiledName("in_progress")>] InProgress
            | [<CompiledName("completed")>] Completed
            | [<CompiledName("incomplete")>] Incomplete
            | [<CompiledName("function_call")>] FunctionCall

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Async_Batch")>]
        type AiCfQwenQwen330BA3BFp8AsyncBatch =
            abstract requests: Array<U2<AiCfQwenQwen330BA3BFp8Prompt1, AiCfQwenQwen330BA3BFp8Messages1>> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_1")>]
        type AiCfAisingaporeGemmaSeaLionV427BItJSONMode1 =
            [<CompiledName("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<AiCfAisingaporeGemmaSeaLionV427BItJSONMode1.Type> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type StreamWatermarkPosition =
            | [<CompiledName("upperRight")>] UpperRight
            | [<CompiledName("upperLeft")>] UpperLeft
            | [<CompiledName("lowerLeft")>] LowerLeft
            | [<CompiledName("lowerRight")>] LowerRight
            | [<CompiledName("center")>] Center

        [<Import("@cloudflare/workers-types", "ResponseInputMessageItem")>]
        type ResponseInputMessageItem =
            [<CompiledName("type")>]
            abstract ``type``: option<ResponseInputMessageItem.Type> with get, set

            abstract status: option<ResponseInputMessageItem.Status> with get, set
            abstract role: ResponseInputMessageItem.Role with get, set
            abstract content: Array<U2<ResponseInputText, ResponseInputImage>> with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Openai_Whisper_Tiny_En")>]
        type BaseAiCfOpenaiWhisperTinyEn =
            abstract postProcessedOutputs: AiCfOpenaiWhisperTinyEnOutput with get, set
            abstract inputs: U2<AiAutomaticSpeechRecognitionInput, D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchMultiSearchOptions")>]
        type AiSearchMultiSearchOptions =
            [<CompiledName("instance_ids")>]
            abstract instanceIds: Array<D1SessionBookmark> with get, set

            abstract cache: option<AiSearchMultiSearchOptions.Cache> with get, set
            abstract reranking: option<AiSearchMultiSearchOptions.Reranking> with get, set

            [<CompiledName("query_rewrite")>]
            abstract queryRewrite: option<AiSearchMultiSearchOptions.QueryRewrite> with get, set

            abstract retrieval: option<AiSearchMultiSearchOptions.Retrieval> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "VectorizeAsyncMutation")>]
        type VectorizeAsyncMutation =
            abstract mutationId: D1SessionBookmark with get, set

        type _EmailMessage =
            abstract prototype: EmailMessage with get, set

            abstract Create:
                from: D1SessionBookmark *
                ``to``: D1SessionBookmark *
                raw: U2<ReadableStream<option<obj>>, D1SessionBookmark> ->
                    EmailMessage

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Moonshotai_Kimi_K2_5")>]
        type BaseAiCfMoonshotaiKimiK25 =
            abstract postProcessedOutputs: ChatCompletionsOutput with get, set

            abstract inputs:
                U3<BaseAiCfMoonshotaiKimiK25.Inputs, BaseAiCfMoonshotaiKimiK25.Inputs, BaseAiCfMoonshotaiKimiK25.Inputs> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItems")>]
        type AiSearchItems =
            abstract delete: itemId: D1SessionBookmark -> Promise<unit>
            abstract get: itemId: D1SessionBookmark -> AiSearchItem

            abstract uploadAndPoll:
                name: D1SessionBookmark *
                content: U3<ReadableStream<option<obj>>, Blob, D1SessionBookmark> *
                ?options: AiSearchItems.UploadAndPoll.Options ->
                    Promise<AiSearchItemInfo>

            abstract upload:
                name: D1SessionBookmark *
                content: U3<ReadableStream<option<obj>>, Blob, D1SessionBookmark> *
                ?options: AiSearchUploadItemOptions ->
                    Promise<AiSearchItemInfo>

            abstract list: ?params: AiSearchListItemsParams -> Promise<AiSearchListItemsResponse>

        [<Import("@cloudflare/workers-types", "UserMessageContentPart")>]
        type UserMessageContentPart =
            abstract file: option<UserMessageContentPart.File> with get, set

            [<CompiledName("input_audio")>]
            abstract inputAudio: option<UserMessageContentPart.InputAudio> with get, set

            [<CompiledName("image_url")>]
            abstract imageUrl: option<UserMessageContentPart.ImageUrl> with get, set

            abstract text: option<D1SessionBookmark> with get, set

            [<CompiledName("type")>]
            abstract ``type``: UserMessageContentPart.Type with get, set

        type ChatCompletionsBase =
            abstract id: D1SessionBookmark with get, set
            abstract format: ChatCompletionsBase.Format with get, set
            abstract voice: U2<ResponseConversationParam, D1SessionBookmark> with get, set
            abstract messages: option<unit> with get, set
            abstract functions: option<Array<FunctionDefinition>> with get, set

            [<CompiledName("function_call")>]
            abstract functionCall: option<U2<ChatCompletionsBase.FunctionCall, ChatCompletionsBase.FunctionCall>> with get, set

            [<CompiledName("web_search_options")>]
            abstract webSearchOptions: option<WebSearchOptions> with get, set

            abstract user: option<D1SessionBookmark> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract tools: option<Array<ChatCompletionTool>> with get, set

            [<CompiledName("tool_choice")>]
            abstract toolChoice:
                option<
                    U4<
                        ChatCompletionsBase.ToolChoice,
                        ChatCompletionToolChoiceFunction,
                        ChatCompletionToolChoiceCustom,
                        ChatCompletionToolChoiceAllowedTools
                     >
                 > with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("stream_options")>]
            abstract streamOptions: option<ChatCompletionsStreamOptions> with get, set

            abstract stream: option<bool> with get, set
            abstract store: option<bool> with get, set
            abstract stop: option<U2<Array<D1SessionBookmark>, D1SessionBookmark>> with get, set

            [<CompiledName("service_tier")>]
            abstract serviceTier: option<ChatCompletionsBase.ServiceTier> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<ResponseFormat> with get, set

            [<CompiledName("chat_template_kwargs")>]
            abstract chatTemplateKwargs: option<ChatTemplateKwargs> with get, set

            [<CompiledName("reasoning_effort")>]
            abstract reasoningEffort: option<ChatCompletionsBase.ReasoningEffort> with get, set

            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            abstract prediction: option<PredictionContent> with get, set

            [<CompiledName("parallel_tool_calls")>]
            abstract parallelToolCalls: option<bool> with get, set

            abstract n: option<float> with get, set
            abstract modalities: option<Array<ChatCompletionsBase.Modalities>> with get, set
            abstract metadata: option<ChatCompletionsBase.Metadata> with get, set

            [<CompiledName("max_completion_tokens")>]
            abstract maxCompletionTokens: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            [<CompiledName("top_logprobs")>]
            abstract topLogprobs: option<float> with get, set

            abstract logprobs: option<bool> with get, set

            [<CompiledName("logit_bias")>]
            abstract logitBias: option<ChatCompletionsBase.LogitBias> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            abstract audio: option<AudioParams> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set
            abstract content: U2<Array<ChatCompletionContentPartText>, D1SessionBookmark> with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionsBase.Type with get, set

            abstract text: D1SessionBookmark with get, set
            abstract timezone: option<D1SessionBookmark> with get, set
            abstract region: option<D1SessionBookmark> with get, set
            abstract country: option<D1SessionBookmark> with get, set
            abstract city: option<D1SessionBookmark> with get, set
            abstract approximate: ChatCompletionsBase.Approximate with get, set

            [<CompiledName("user_location")>]
            abstract userLocation: option<WebSearchUserLocation> with get, set

            [<CompiledName("search_context_size")>]
            abstract searchContextSize: option<ChatCompletionsBase.SearchContextSize> with get, set

            [<CompiledName("include_obfuscation")>]
            abstract includeObfuscation: option<bool> with get, set

            [<CompiledName("include_usage")>]
            abstract includeUsage: option<bool> with get, set

            [<CompiledName("clear_thinking")>]
            abstract clearThinking: option<bool> with get, set

            [<CompiledName("enable_thinking")>]
            abstract enableThinking: option<bool> with get, set

            abstract prompt: option<unit> with get, set
            abstract messages: Array<ChatCompletionMessageParam> with get, set

        [<Import("@cloudflare/workers-types", "TailEvent")>]
        type TailEvent =
            inherit ExtendableEvent<'TailEvent>
            abstract traces: Array<TraceItem> with get
            abstract events: Array<TraceItem> with get

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type __RPC_STUB_BRAND = | __RPC_STUB_BRAND

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_Reranker_Base_Input")>]
        type AiCfBaaiBgeRerankerBaseInput =
            abstract contexts: Array<AiCfBaaiBgeRerankerBaseInput.Contexts> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

        [<Import("@cloudflare/workers-types", "AbortController")>]
        type AbortController =
            [<EmitConstructor>]
            abstract Create: unit -> AbortController

            abstract signal: AbortSignal with get
            abstract abort: ?reason: obj -> unit

        [<Import("@cloudflare/workers-types", "BaseAiObjectDetection")>]
        type BaseAiObjectDetection =
            abstract postProcessedOutputs: AiObjectDetectionOutput with get, set
            abstract inputs: AiObjectDetectionInput with get, set

        [<Import("@cloudflare/workers-types", "Cache")>]
        type Cache =
            abstract put:
                request:
                    U3<
                        Typescript.Request<option<obj>, U2<RequestInitCfProperties, Cache.Put.Request>>,
                        URL,
                        D1SessionBookmark
                     > *
                response: Typescript.Response ->
                    Promise<unit>

            abstract ``match``:
                request:
                    U3<
                        Typescript.Request<option<obj>, U2<RequestInitCfProperties, Cache.Match.Request>>,
                        URL,
                        D1SessionBookmark
                     > *
                ?options: Typescript.CacheQueryOptions ->
                    Promise<option<Typescript.Response>>

            abstract delete:
                request:
                    U3<
                        Typescript.Request<option<obj>, U2<RequestInitCfProperties, Cache.Delete.Request>>,
                        URL,
                        D1SessionBookmark
                     > *
                ?options: Typescript.CacheQueryOptions ->
                    Promise<bool>

        [<Import("@cloudflare/workers-types", "AiSearchMultiSearchChunk")>]
        type AiSearchMultiSearchChunk =
            [<CompiledName("instance_id")>]
            abstract instanceId: D1SessionBookmark with get, set

            [<CompiledName("scoring_details")>]
            abstract scoringDetails: option<AiSearchMultiSearchChunk.ScoringDetails> with get, set

            abstract item: AiSearchMultiSearchChunk.Item with get, set
            abstract text: D1SessionBookmark with get, set
            abstract score: float with get, set

            [<CompiledName("type")>]
            abstract ``type``: D1SessionBookmark with get, set

            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionMessageCustomToolCall")>]
        type ChatCompletionMessageCustomToolCall =
            abstract custom: ChatCompletionMessageCustomToolCall.Custom with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionMessageCustomToolCall.Type with get, set

            abstract id: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type VectorizeVectorMetadataFilterCollectionOp =
            | [<CompiledName("$in")>] ``$in``
            | [<CompiledName("$nin")>] ``$nin``

        [<Import("@cloudflare/workers-types", "BaseAiTextToSpeech")>]
        type BaseAiTextToSpeech =
            abstract postProcessedOutputs: AiTextToSpeechOutput with get, set
            abstract inputs: AiTextToSpeechInput with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type CertVerificationStatus =
            | SUCCESS
            | NONE
            | [<CompiledName("FAILED:self signed certificate")>] ``FAILED:self signed certificate``
            | [<CompiledName("FAILED:unable to verify the first certificate")>] ``FAILED:unable to verify the first certificate``
            | [<CompiledName("FAILED:certificate is not yet valid")>] ``FAILED:certificate is not yet valid``
            | [<CompiledName("FAILED:certificate has expired")>] ``FAILED:certificate has expired``
            | FAILED

        type ConversionResponse = U2<ConversionResponse, ConversionResponse>

        [<Import("@cloudflare/workers-types", "DurableObjectGetAlarmOptions")>]
        type DurableObjectGetAlarmOptions =
            abstract allowConcurrency: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchChatCompletionsRequest")>]
        type AiSearchChatCompletionsRequest =
            [<CompiledName("ai_search_options")>]
            abstract aiSearchOptions: option<AiSearchOptions> with get, set

            abstract stream: option<bool> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract messages: Array<AiSearchMessage> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "EventSource")>]
        type EventSource =
            [<EmitConstructor>]
            abstract Create: url: D1SessionBookmark * ?init: EventSourceEventSourceInit -> EventSource

            inherit EventTarget
            abstract CLOSED: float with get
            abstract OPEN: float with get
            abstract CONNECTING: float with get
            abstract onerror: option<obj> with set
            abstract onerror: option<obj> with get
            abstract onmessage: option<obj> with set
            abstract onmessage: option<obj> with get
            abstract onopen: option<obj> with set
            abstract onopen: option<obj> with get
            abstract readyState: float with get
            abstract withCredentials: bool with get
            abstract url: D1SessionBookmark with get
            abstract from: stream: ReadableStream<option<obj>> -> EventSource
            abstract close: unit -> unit

        [<Import("@cloudflare/workers-types", "BaseAiImageClassification")>]
        type BaseAiImageClassification =
            abstract postProcessedOutputs: AiImageClassificationOutput with get, set
            abstract inputs: AiImageClassificationInput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_1")>]
        type AiCfQwenQwen330BA3BFp8JSONMode1 =
            [<CompiledName("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<AiCfQwenQwen330BA3BFp8JSONMode1.Type> with get, set

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRAGNotFoundError")>]
        type AutoRAGNotFoundError =
            interface
                inherit Error
            end

        type EmailAttachment = U2<EmailAttachment, EmailAttachment>

        [<Import("@cloudflare/workers-types", "LoopbackDurableObjectClass")>]
        type LoopbackDurableObjectClass<'T when 'T :> Rpc.DurableObjectBranded> =
            abstract Invoke: opts: LoopbackDurableObjectClass.LoopbackDurableObjectClass.Opts -> DurableObjectClass<'T>
            abstract Invoke: opts: LoopbackDurableObjectClass.LoopbackDurableObjectClass.Opts -> DurableObjectClass<'T>

        [<Import("@cloudflare/workers-types", "QueueSendOptions")>]
        type QueueSendOptions =
            abstract delaySeconds: option<float> with get, set
            abstract contentType: option<QueueSendOptions.ContentType> with get, set

        [<Import("@cloudflare/workers-types", "workerdResourceLimits")>]
        type WorkerdResourceLimits =
            abstract subRequests: option<float> with get, set
            abstract cpuMs: option<float> with get, set

        [<Import("@cloudflare/workers-types", "LoopbackDurableObjectNamespace")>]
        type LoopbackDurableObjectNamespace =
            interface
                inherit DurableObjectNamespace<unit>
            end

        type AiCfQwenQwen25Coder32BInstructInput =
            U2<AiCfQwenQwen25Coder32BInstructPrompt, AiCfQwenQwen25Coder32BInstructMessages>

        [<Import("@cloudflare/workers-types", "ResponseTextConfig")>]
        type ResponseTextConfig =
            abstract verbosity: option<ResponseTextConfig.Verbosity> with get, set
            abstract format: option<ResponseFormatTextConfig> with get, set

        [<Import("@cloudflare/workers-types", "ForwardableEmailMessage")>]
        type ForwardableEmailMessage =
            inherit EmailMessage
            abstract rawSize: float with get
            abstract headers: Headers with get
            abstract raw: ReadableStream<Uint8Array<ArrayBufferLike>> with get
            abstract reply: message: EmailMessage -> Promise<EmailSendResult>
            abstract forward: rcptTo: D1SessionBookmark * ?headers: Headers -> Promise<EmailSendResult>
            abstract setReject: reason: D1SessionBookmark -> unit

        [<Import("@cloudflare/workers-types", "StreamDirectUploadWatermark")>]
        type StreamDirectUploadWatermark =
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It")>]
        type BaseAiCfAisingaporeGemmaSeaLionV427BIt =
            abstract postProcessedOutputs:
                U4<
                    AiCfAisingaporeGemmaSeaLionV427BItChatCompletionResponse,
                    AiCfAisingaporeGemmaSeaLionV427BItTextCompletionResponse,
                    AiCfAisingaporeGemmaSeaLionV427BItAsyncResponse,
                    D1SessionBookmark
                 > with get, set

            abstract inputs: AiCfAisingaporeGemmaSeaLionV427BItInput with get, set

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesCloudflareAccessOrApiShield")>]
        type IncomingRequestCfPropertiesCloudflareAccessOrApiShield =
            abstract tlsClientAuth:
                U2<IncomingRequestCfPropertiesTLSClientAuth, IncomingRequestCfPropertiesTLSClientAuthPlaceholder> with get, set

        [<Import("@cloudflare/workers-types", "AiObjectDetectionInput")>]
        type AiObjectDetectionInput =
            abstract image: AiSentenceSimilarityOutput with get, set

        [<Import("@cloudflare/workers-types", "URLPatternComponentResult")>]
        type URLPatternComponentResult =
            abstract groups: URLPatternComponentResult.Groups with get, set
            abstract input: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiTextGenerationOutput")>]
        type AiTextGenerationOutput =
            abstract usage: option<UsageTags> with get, set

            [<CompiledName("tool_calls")>]
            abstract toolCalls: option<AiTextGenerationOutput.ToolCalls> with get, set

            abstract response: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "KVNamespaceListKey")>]
        type KVNamespaceListKey<'Key, 'Metadata when 'Key :> D1SessionBookmark> =
            abstract metadata: option<'Metadata> with get, set
            abstract expiration: option<float> with get, set
            abstract name: 'Key with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionCustomToolTextFormat")>]
        type ChatCompletionCustomToolTextFormat =
            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionCustomToolTextFormat.Type with get, set

        [<Import("@cloudflare/workers-types", "VectorizeQueryOptions")>]
        type VectorizeQueryOptions =
            abstract filter: option<VectorizeVectorMetadataFilter> with get, set
            abstract returnMetadata: option<U2<VectorizeQueryOptions.ReturnMetadata, bool>> with get, set
            abstract returnValues: option<bool> with get, set

            [<CompiledName("namespace")>]
            abstract ``namespace``: option<D1SessionBookmark> with get, set

            abstract topK: option<float> with get, set

        [<Import("@cloudflare/workers-types", "BaseAiTextGeneration")>]
        type BaseAiTextGeneration =
            abstract postProcessedOutputs: AiTextGenerationOutput with get, set
            abstract inputs: AiTextGenerationInput with get, set

        type VectorizeVectorMetadata =
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "EmailMessage")>]
        type EmailMessage =
            [<CompiledName("to")>]
            abstract ``to``: D1SessionBookmark with get

            abstract from: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "R2MultipartUpload")>]
        type R2MultipartUpload =
            abstract uploadId: D1SessionBookmark with get
            abstract key: D1SessionBookmark with get
            abstract complete: uploadedParts: Array<R2UploadedPart> -> Promise<R2Object>
            abstract abort: unit -> Promise<unit>

            abstract uploadPart:
                partNumber: float *
                value:
                    U5<
                        ReadableStream<option<obj>>,
                        ArrayBuffer,
                        ArrayBufferView<ArrayBufferLike>,
                        Blob,
                        D1SessionBookmark
                     > *
                ?options: R2UploadPartOptions ->
                    Promise<R2UploadedPart>

        type AiImageClassificationOutput = Array<AiImageClassificationOutput>

        [<Import("@cloudflare/workers-types", "AlreadyUploadedError")>]
        type AlreadyUploadedError =
            inherit StreamError
            abstract name: AlreadyUploadedError.Name with get, set

        [<Import("@cloudflare/workers-types", "URLPatternOptions")>]
        type URLPatternOptions =
            abstract ignoreCase: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_1_Schnell_Input")>]
        type AiCfBlackForestLabsFlux1SchnellInput =
            abstract steps: option<float> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ResponseContentReasoningText")>]
        type ResponseContentReasoningText =
            [<CompiledName("type")>]
            abstract ``type``: ResponseContentReasoningText.Type with get, set

            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ImageList")>]
        type ImageList =
            abstract listComplete: bool with get, set
            abstract cursor: option<D1SessionBookmark> with get, set
            abstract images: Array<ImageMetadata> with get, set

        [<Import("@cloudflare/workers-types", "ImageOutputOptions")>]
        type ImageOutputOptions =
            abstract anim: option<bool> with get, set
            abstract background: option<D1SessionBookmark> with get, set
            abstract quality: option<float> with get, set
            abstract format: ImageOutputOptions.Format with get, set

        [<Import("@cloudflare/workers-types", "HTMLRewriterElementContentHandlers")>]
        type HTMLRewriterElementContentHandlers =
            abstract text: element: Typescript.Text -> option<Promise<unit>>
            abstract comments: comment: Typescript.Comment -> option<Promise<unit>>
            abstract element: element: Typescript.Element -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "ImageTransform")>]
        type ImageTransform =
            abstract trim: option<U2<ImageTransform.Trim, ImageTransform.Trim>> with get, set
            abstract sharpen: option<float> with get, set
            abstract saturation: option<float> with get, set
            abstract rotate: option<ImageTransform.Rotate> with get, set
            abstract gravity: option<U2<ImageTransform.Gravity, ImageTransform.Gravity>> with get, set
            abstract segment: option<ImageTransform.Segment> with get, set
            abstract gamma: option<float> with get, set
            abstract flip: option<ImageTransform.Flip> with get, set
            abstract fit: option<ImageTransform.Fit> with get, set
            abstract contrast: option<float> with get, set
            abstract brightness: option<float> with get, set
            abstract border: option<U2<ImageTransform.Border, ImageTransform.Border>> with get, set
            abstract blur: option<float> with get, set
            abstract background: option<D1SessionBookmark> with get, set
            abstract height: option<float> with get, set
            abstract width: option<float> with get, set

        [<Import("@cloudflare/workers-types", "AiTextToImageInput")>]
        type AiTextToImageInput =
            abstract seed: option<float> with get, set
            abstract guidance: option<float> with get, set
            abstract strength: option<float> with get, set

            [<CompiledName("num_steps")>]
            abstract numSteps: option<float> with get, set

            abstract mask: option<AiSentenceSimilarityOutput> with get, set

            [<CompiledName("image_b64")>]
            abstract imageB64: option<D1SessionBookmark> with get, set

            abstract image: option<AiSentenceSimilarityOutput> with get, set
            abstract width: option<float> with get, set
            abstract height: option<float> with get, set

            [<CompiledName("negative_prompt")>]
            abstract negativePrompt: option<D1SessionBookmark> with get, set

            abstract prompt: D1SessionBookmark with get, set

        type SetInterval =
            abstract Invoke: [<ParamArray>] args: 'Args -> unit
            abstract Invoke: [<ParamArray>] args: Array<option<obj>> -> unit

            abstract Invoke:
                callback: SetInterval.SetInterval.Callback * ?msDelay: float * [<ParamArray>] args: 'Args -> float

            abstract Invoke: callback: SetInterval.SetInterval.Callback * ?msDelay: float -> float

            abstract Invoke:
                handler: U2<Function, D1SessionBookmark> *
                ?timeout: float *
                [<ParamArray>] arguments: Array<option<obj>> ->
                    float

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Prompt")>]
        type AiCfQwenQwen25Coder32BInstructPrompt =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfQwenQwen25Coder32BInstructJSONMode> with get, set

            abstract lora: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "HTMLRewriter")>]
        type HTMLRewriter =
            [<EmitConstructor>]
            abstract Create: unit -> HTMLRewriter

            abstract transform: response: Typescript.Response -> Typescript.Response
            abstract onDocument: handlers: HTMLRewriterDocumentContentHandlers -> HTMLRewriter
            abstract on: selector: D1SessionBookmark * handlers: HTMLRewriterElementContentHandlers -> HTMLRewriter

        [<Import("@cloudflare/workers-types", "FlagshipEvaluationDetails")>]
        type FlagshipEvaluationDetails<'T> =
            abstract errorMessage: option<D1SessionBookmark> with get, set
            abstract errorCode: option<D1SessionBookmark> with get, set
            abstract reason: option<D1SessionBookmark> with get, set
            abstract variant: option<D1SessionBookmark> with get, set
            abstract value: 'T with get, set
            abstract flagKey: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectFacets")>]
        type DurableObjectFacets =
            abstract delete: name: D1SessionBookmark -> unit
            abstract abort: name: D1SessionBookmark * ?reason: obj -> unit

            abstract get:
                name: D1SessionBookmark *
                getStartupOptions: unit -> U2<FacetStartupOptions<'T>, Promise<FacetStartupOptions<'T>>> ->
                    DurableObjectFacets.Get

        [<Import("@cloudflare/workers-types", "ChatCompletionLogprobs")>]
        type ChatCompletionLogprobs =
            abstract refusal: option<Array<ChatCompletionTokenLogprob>> with get, set
            abstract content: option<Array<ChatCompletionTokenLogprob>> with get, set

        type AiSearchMultiSearchRequest = U2<AiSearchMultiSearchRequest, AiSearchMultiSearchRequest>

        [<Import("@cloudflare/workers-types", "NotFoundError")>]
        type NotFoundError =
            inherit StreamError
            abstract name: NotFoundError.Name with get, set

        [<Import("@cloudflare/workers-types", "Reasoning")>]
        type Reasoning =
            abstract summary: option<Reasoning.Summary> with get, set

            [<CompiledName("generate_summary")>]
            abstract generateSummary: option<Reasoning.GenerateSummary> with get, set

            abstract effort: option<Reasoning.Effort> with get, set

        [<Import("@cloudflare/workers-types", "SchedulerWaitOptions")>]
        type SchedulerWaitOptions =
            abstract signal: option<AbortSignal> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_AsyncResponse")>]
        type AiCfAisingaporeGemmaSeaLionV427BItAsyncResponse =
            [<CompiledName("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Meta_Llama_Guard_3_8B")>]
        type BaseAiCfMetaLlamaGuard38B =
            abstract postProcessedOutputs: AiCfMetaLlamaGuard38BOutput with get, set
            abstract inputs: AiCfMetaLlamaGuard38BInput with get, set

        [<Import("@cloudflare/workers-types", "UnsafeTraceMetrics")>]
        type UnsafeTraceMetrics =
            abstract fromTrace: item: TraceItem -> TraceMetrics

        [<Import("@cloudflare/workers-types", "AiSearchJobLogsParams")>]
        type AiSearchJobLogsParams =
            [<CompiledName("per_page")>]
            abstract perPage: option<float> with get, set

            abstract page: option<float> with get, set

        [<Import("@cloudflare/workers-types", "AiTextGenerationToolLegacyOutput")>]
        type AiTextGenerationToolLegacyOutput =
            abstract arguments: option<obj> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "R2HTTPMetadata")>]
        type R2HTTPMetadata =
            abstract cacheExpiry: option<Date> with get, set
            abstract cacheControl: option<D1SessionBookmark> with get, set
            abstract contentEncoding: option<D1SessionBookmark> with get, set
            abstract contentDisposition: option<D1SessionBookmark> with get, set
            abstract contentLanguage: option<D1SessionBookmark> with get, set
            abstract contentType: option<D1SessionBookmark> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ContinentCode =
            | AF
            | AN
            | AS
            | EU
            | NA
            | OC
            | SA

        [<Import("@cloudflare/workers-types", "Ai_Cf_Leonardo_Lucid_Origin_Input")>]
        type AiCfLeonardoLucidOriginInput =
            abstract steps: option<float> with get, set

            [<CompiledName("num_steps")>]
            abstract numSteps: option<float> with get, set

            abstract width: option<float> with get, set
            abstract height: option<float> with get, set
            abstract seed: option<float> with get, set
            abstract guidance: option<float> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "PagesFunction")>]
        type PagesFunction<'Data, 'Params, 'Env when 'Data :> PagesFunction and 'Params :> D1SessionBookmark> =
            abstract Invoke:
                context: PagesFunction.PagesFunction.Context -> U2<Typescript.Response, Promise<Typescript.Response>>

        [<Import("@cloudflare/workers-types", "WorkerLoader")>]
        type WorkerLoader =
            abstract load: code: WorkerLoaderWorkerCode -> WorkerStub

            abstract get:
                ?name: D1SessionBookmark * getCode: unit -> U2<WorkerLoaderWorkerCode, Promise<WorkerLoaderWorkerCode>> ->
                    WorkerStub

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_JSON_Mode_1")>]
        type AiCfQwenQwen25Coder32BInstructJSONMode1 =
            [<CompiledName("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<AiCfQwenQwen25Coder32BInstructJSONMode1.Type> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Async_Batch")>]
        type AiCfMetaLlama3370BInstructFp8FastAsyncBatch =
            abstract requests: option<Array<AiCfMetaLlama3370BInstructFp8FastAsyncBatch.Requests>> with get, set

        [<Import("@cloudflare/workers-types", "ResponseOutputMessage")>]
        type ResponseOutputMessage =
            [<CompiledName("type")>]
            abstract ``type``: ResponseOutputMessage.Type with get, set

            abstract status: ResponseOutputMessage.Status with get, set
            abstract role: ResponseOutputMessage.Role with get, set
            abstract content: Array<U2<ResponseOutputText, ResponseOutputRefusal>> with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_Guard_3_8B_Output")>]
        type AiCfMetaLlamaGuard38BOutput =
            abstract usage: option<AiCfMetaLlamaGuard38BOutput.Usage> with get, set
            abstract response: option<U2<AiCfMetaLlamaGuard38BOutput.Response, D1SessionBookmark>> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Deepgram_Nova_3")>]
        type BaseAiCfDeepgramNova3 =
            abstract postProcessedOutputs: AiCfDeepgramNova3Output with get, set
            abstract inputs: AiCfDeepgramNova3Input with get, set

        [<Import("@cloudflare/workers-types", "AiInternalError")>]
        type AiInternalError =
            interface
                inherit Error
            end

        [<Import("@cloudflare/workers-types", "URLPattern")>]
        type URLPattern =
            [<EmitConstructor>]
            abstract Create:
                ?input: U2<URLPatternInit, D1SessionBookmark> *
                ?baseURL: U2<URLPatternOptions, D1SessionBookmark> *
                ?patternOptions: URLPatternOptions ->
                    URLPattern

            abstract hash: D1SessionBookmark with get
            abstract search: D1SessionBookmark with get
            abstract pathname: D1SessionBookmark with get
            abstract port: D1SessionBookmark with get
            abstract hostname: D1SessionBookmark with get
            abstract password: D1SessionBookmark with get
            abstract username: D1SessionBookmark with get
            abstract protocol: D1SessionBookmark with get

            abstract exec:
                ?input: U2<URLPatternInit, D1SessionBookmark> * ?baseURL: D1SessionBookmark -> option<URLPatternResult>

            abstract test: ?input: U2<URLPatternInit, D1SessionBookmark> * ?baseURL: D1SessionBookmark -> bool

        [<Import("@cloudflare/workers-types", "ResponseCreatedEvent")>]
        type ResponseCreatedEvent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseCreatedEvent.Type with get, set

            [<CompiledName("sequence_number")>]
            abstract sequenceNumber: float with get, set

            abstract response: Typescript.Response with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Qwen_Qwq_32B")>]
        type BaseAiCfQwenQwq32B =
            abstract postProcessedOutputs: AiCfQwenQwq32BOutput with get, set
            abstract inputs: AiCfQwenQwq32BInput with get, set

        [<Import("@cloudflare/workers-types", "AiTranslationInput")>]
        type AiTranslationInput =
            [<CompiledName("source_lang")>]
            abstract sourceLang: option<D1SessionBookmark> with get, set

            [<CompiledName("target_lang")>]
            abstract targetLang: D1SessionBookmark with get, set

            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ImageUpdateOptions")>]
        type ImageUpdateOptions =
            abstract creator: option<D1SessionBookmark> with get, set
            abstract metadata: option<ImageUpdateOptions.Metadata> with get, set
            abstract requireSignedURLs: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "MessageBatchMetrics")>]
        type MessageBatchMetrics =
            abstract oldestMessageTimestamp: option<Date> with get, set
            abstract backlogBytes: float with get, set
            abstract backlogCount: float with get, set

        type WorkerGlobalScope =
            abstract rejectionhandled: PromiseRejectionEvent with get, set
            abstract unhandledrejection: PromiseRejectionEvent with get, set
            abstract queue: QueueEvent<option<obj>> with get, set
            abstract scheduled: ScheduledEvent with get, set
            abstract fetch: FetchEvent with get, set

        type ResponseOutputItem = U3<ResponseOutputMessage, ResponseFunctionToolCall, ResponseReasoningItem>

        [<Import("@cloudflare/workers-types", "R2UploadPartOptions")>]
        type R2UploadPartOptions =
            abstract ssecKey: option<U2<ArrayBuffer, D1SessionBookmark>> with get, set

        [<Import("@cloudflare/workers-types", "DynamicDispatchOptions")>]
        type DynamicDispatchOptions =
            abstract outbound: option<DynamicDispatchOptions.Outbound> with get, set
            abstract limits: option<DynamicDispatchLimits> with get, set

        [<Import("@cloudflare/workers-types", "RequestInitCfPropertiesImageDraw")>]
        type RequestInitCfPropertiesImageDraw =
            inherit BasicImageTransformations
            abstract right: option<float> with get, set
            abstract bottom: option<float> with get, set
            abstract left: option<float> with get, set
            abstract top: option<float> with get, set
            abstract repeat: option<RequestInitCfPropertiesImageDraw.Repeat> with get, set
            abstract opacity: option<float> with get, set
            abstract url: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "VectorizeIndexDetails")>]
        type VectorizeIndexDetails =
            abstract vectorsCount: float with get, set
            abstract config: VectorizeIndexConfig with get, set
            abstract description: option<D1SessionBookmark> with get, set
            abstract name: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get

        type BodyInit =
            U7<
                ReadableStream<Uint8Array<ArrayBufferLike>>,
                ArrayBuffer,
                ArrayBufferView<ArrayBufferLike>,
                Blob,
                URLSearchParams,
                FormData,
                D1SessionBookmark
             >

        [<Import("@cloudflare/workers-types", "R2Conditional")>]
        type R2Conditional =
            abstract secondsGranularity: option<bool> with get, set
            abstract uploadedAfter: option<Date> with get, set
            abstract uploadedBefore: option<Date> with get, set
            abstract etagDoesNotMatch: option<D1SessionBookmark> with get, set
            abstract etagMatches: option<D1SessionBookmark> with get, set

        type ResponseFunctionCallOutputItemList = Array<ResponseFunctionCallOutputItem>

        [<Import("@cloudflare/workers-types", "ChatCompletionCustomToolGrammarFormat")>]
        type ChatCompletionCustomToolGrammarFormat =
            abstract grammar: ChatCompletionCustomToolGrammarFormat.Grammar with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionCustomToolGrammarFormat.Type with get, set

        [<Import("@cloudflare/workers-types", "AiSummarizationOutput")>]
        type AiSummarizationOutput =
            abstract summary: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiTranslationOutput")>]
        type AiTranslationOutput =
            [<CompiledName("translated_text")>]
            abstract translatedText: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Input_Embedding")>]
        type AiCfBaaiBgeM3InputEmbedding =
            [<CompiledName("truncate_inputs")>]
            abstract truncateInputs: option<bool> with get, set

            abstract text: U2<Array<D1SessionBookmark>, D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "BaseAiTextClassification")>]
        type BaseAiTextClassification =
            abstract postProcessedOutputs: AiTextClassificationOutput with get, set
            abstract inputs: AiTextClassificationInput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwq_32B_Messages")>]
        type AiCfQwenQwq32BMessages =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            abstract tools: option<Array<U2<AiCfQwenQwq32BMessages.Tools, AiCfQwenQwq32BMessages.Tools>>> with get, set
            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: Array<AiCfQwenQwq32BMessages.Messages> with get, set

        [<Import("@cloudflare/workers-types", "ResponseError")>]
        type ResponseError =
            abstract message: D1SessionBookmark with get, set
            abstract code: ResponseError.Code with get, set

        [<Import("@cloudflare/workers-types", "ForbiddenError")>]
        type ForbiddenError =
            inherit StreamError
            abstract name: ForbiddenError.Name with get, set

        [<Import("@cloudflare/workers-types", "ImageTransformationResult")>]
        type ImageTransformationResult =
            abstract image: ?options: ImageTransformationOutputOptions -> ReadableStream<Uint8Array<ArrayBufferLike>>
            abstract contentType: unit -> D1SessionBookmark
            abstract response: unit -> Typescript.Response

        [<Import("@cloudflare/workers-types", "TraceItemHibernatableWebSocketEventInfo")>]
        type TraceItemHibernatableWebSocketEventInfo =
            abstract getWebSocketEvent:
                U3<
                    TraceItemHibernatableWebSocketEventInfoMessage,
                    TraceItemHibernatableWebSocketEventInfoClose,
                    TraceItemHibernatableWebSocketEventInfoError
                 > with get

        [<Import("@cloudflare/workers-types", "Performance")>]
        type Performance =
            abstract timeOrigin: float with get
            abstract toJSON: unit -> obj
            abstract now: unit -> float

        [<Import("@cloudflare/workers-types", "VectorizeMatches")>]
        type VectorizeMatches =
            abstract count: float with get, set
            abstract matches: Array<VectorizeMatch> with get, set

        [<Import("@cloudflare/workers-types", "StreamScopedCaptions")>]
        type StreamScopedCaptions =
            abstract delete: language: D1SessionBookmark -> Promise<unit>
            abstract list: ?language: D1SessionBookmark -> Promise<Array<StreamCaption>>
            abstract generate: language: D1SessionBookmark -> Promise<StreamCaption>
            abstract upload: language: D1SessionBookmark * input: ReadableStream<option<obj>> -> Promise<StreamCaption>

        [<Import("@cloudflare/workers-types", "AiImageTextToTextInput")>]
        type AiImageTextToTextInput =
            abstract messages: option<Array<RoleScopedChatInput>> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            [<CompiledName("ignore_eos")>]
            abstract ignoreEos: option<bool> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract prompt: option<D1SessionBookmark> with get, set
            abstract image: D1SessionBookmark with get, set

        type QueueMicrotask =
            abstract Invoke: task: Function -> unit
            abstract Invoke: callback: VoidFunction -> unit

        type RequestInfo<'Cf, 'CfHostMetadata> = U2<Typescript.Request<'CfHostMetadata, 'Cf>, D1SessionBookmark>

        [<Import("@cloudflare/workers-types", "StreamVideoStatus")>]
        type StreamVideoStatus =
            abstract errorReasonText: D1SessionBookmark with get, set
            abstract errorReasonCode: D1SessionBookmark with get, set
            abstract pctComplete: option<D1SessionBookmark> with get, set
            abstract step: option<D1SessionBookmark> with get, set
            abstract state: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type __RPC_TARGET_BRAND = | __RPC_TARGET_BRAND

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_Large_En_V1_5_AsyncResponse")>]
        type AiCfBaaiBgeLargeEnV15AsyncResponse =
            [<CompiledName("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "SubtleCryptoDeriveKeyAlgorithm")>]
        type SubtleCryptoDeriveKeyAlgorithm =
            abstract info: option<U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>> with get, set

            [<CompiledName("$public")>]
            abstract ``$public``: option<CryptoKey> with get, set

            abstract hash: option<U2<SubtleCryptoHashAlgorithm, D1SessionBookmark>> with get, set
            abstract iterations: option<float> with get, set
            abstract salt: option<U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ExtendableEvent")>]
        type ExtendableEvent =
            inherit Event
            abstract waitUntil: promise: Promise<option<obj>> -> unit

        [<Import("@cloudflare/workers-types", "AiMultimodalEmbeddingsInput")>]
        type AiMultimodalEmbeddingsInput =
            abstract text: Array<D1SessionBookmark> with get, set
            abstract image: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Output")>]
        type AiCfQwenQwen25Coder32BInstructOutput =
            [<CompiledName("tool_calls")>]
            abstract toolCalls: option<Array<AiCfQwenQwen25Coder32BInstructOutput.ToolCalls>> with get, set

            abstract usage: option<AiCfQwenQwen25Coder32BInstructOutput.Usage> with get, set
            abstract response: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "CryptoKeyKeyAlgorithm")>]
        type CryptoKeyKeyAlgorithm =
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Headers")>]
        type Headers =
            [<EmitConstructor>]
            abstract Create: ?init: U3<Headers, Array<D1SessionBookmark * D1SessionBookmark>, Headers.Init> -> Headers

            abstract ``[symbol.iterator]``:
                unit -> IterableIterator<D1SessionBookmark * D1SessionBookmark, option<obj>, option<obj>>

            abstract values: unit -> IterableIterator<D1SessionBookmark, option<obj>, option<obj>>
            abstract keys: unit -> IterableIterator<D1SessionBookmark, option<obj>, option<obj>>
            abstract entries: unit -> IterableIterator<D1SessionBookmark * D1SessionBookmark, option<obj>, option<obj>>
            abstract forEach: callback: Headers.ForEach.Callback * ?thisArg: 'This -> unit
            abstract delete: name: D1SessionBookmark -> unit
            abstract append: name: D1SessionBookmark * value: D1SessionBookmark -> unit
            abstract set: name: D1SessionBookmark * value: D1SessionBookmark -> unit
            abstract has: name: D1SessionBookmark -> bool
            abstract getAll: name: D1SessionBookmark -> Array<D1SessionBookmark>
            abstract get: name: D1SessionBookmark -> option<D1SessionBookmark>

        type ImageInfoResponse = U2<ImageInfoResponse, ImageInfoResponse>

        [<Import("@cloudflare/workers-types", "CompressionStream")>]
        type CompressionStream =
            interface
                [<EmitConstructor>]
                abstract Create: format: CompressionStream.Format -> CompressionStream

                inherit TransformStream<
                    U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>,
                    Uint8Array<ArrayBufferLike>,
                    'CompressionStream
                 ><U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>, Uint8Array<ArrayBufferLike>>
            end

        [<Import("@cloudflare/workers-types", "ConversionRequestOptions")>]
        type ConversionRequestOptions =
            abstract conversionOptions: option<ConversionOptions> with get, set
            abstract extraHeaders: option<obj> with get, set
            abstract gateway: option<GatewayOptions> with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionContentPartImage")>]
        type ChatCompletionContentPartImage =
            [<CompiledName("image_url")>]
            abstract imageUrl: ChatCompletionContentPartImage.ImageUrl with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionContentPartImage.Type with get, set

        [<Import("@cloudflare/workers-types", "StreamDownloadGetResponse")>]
        type StreamDownloadGetResponse =
            [<CompiledName("default")>]
            abstract ``default``: option<StreamDownload> with get, set

            abstract audio: option<StreamDownload> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode")>]
        type AiCfAisingaporeGemmaSeaLionV427BItJSONMode =
            [<CompiledName("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<AiCfAisingaporeGemmaSeaLionV427BItJSONMode.Type> with get, set

        [<Import("@cloudflare/workers-types", "ColoLocalActorNamespace")>]
        type ColoLocalActorNamespace =
            abstract get: actorId: D1SessionBookmark -> ColoLocalActorNamespace.Get

        [<Import("@cloudflare/workers-types", "ArtifactsTokenListResult")>]
        type ArtifactsTokenListResult =
            abstract total: float with get, set
            abstract tokens: Array<ArtifactsTokenInfo> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Deepgram_Aura_1")>]
        type BaseAiCfDeepgramAura1 =
            abstract postProcessedOutputs: D1SessionBookmark with get, set
            abstract inputs: AiCfDeepgramAura1Input with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Async_Batch")>]
        type AiCfAisingaporeGemmaSeaLionV427BItAsyncBatch =
            abstract requests:
                Array<U2<AiCfAisingaporeGemmaSeaLionV427BItPrompt1, AiCfAisingaporeGemmaSeaLionV427BItMessages1>> with get, set

        [<Import("@cloudflare/workers-types", "WritableStreamDefaultWriter")>]
        type WritableStreamDefaultWriter<'W> =
            [<EmitConstructor>]
            abstract Create: stream: WritableStream<option<obj>> -> WritableStreamDefaultWriter

            abstract desiredSize: option<float> with get
            abstract ready: Promise<unit> with get
            abstract closed: Promise<unit> with get
            abstract releaseLock: unit -> unit
            abstract write: ?chunk: 'W -> Promise<unit>
            abstract close: unit -> Promise<unit>
            abstract abort: ?reason: obj -> Promise<unit>

        [<Import("@cloudflare/workers-types", "FetcherPutOptions")>]
        type FetcherPutOptions =
            abstract expirationTtl: option<float> with get, set
            abstract expiration: option<float> with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionsResponseFormatText")>]
        type ChatCompletionsResponseFormatText =
            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionsResponseFormatText.Type with get, set

        [<Import("@cloudflare/workers-types", "ImageDrawOptions")>]
        type ImageDrawOptions =
            abstract right: option<float> with get, set
            abstract bottom: option<float> with get, set
            abstract left: option<float> with get, set
            abstract top: option<float> with get, set
            abstract repeat: option<U2<bool, D1SessionBookmark>> with get, set
            abstract opacity: option<float> with get, set

        type OnRequest =
            abstract fetch: OnRequest.Fetch with get, set
            abstract ASSETS: OnRequest.ASSETS with get, set
            abstract ja3Hash: D1SessionBookmark with get, set
            abstract detectionIds: AiSentenceSimilarityOutput with get, set
            abstract staticResource: bool with get, set
            abstract corporateProxy: bool with get, set
            abstract verifiedBot: bool with get, set
            /// <example>
            /// 54
            /// </example>
            abstract score: float with get, set

            abstract tlsClientAuth:
                U2<IncomingRequestCfPropertiesTLSClientAuth, IncomingRequestCfPropertiesTLSClientAuthPlaceholder> with get, set

            /// <example>
            /// "635"
            /// </example>
            abstract metroCode: option<D1SessionBookmark> with get, set
            /// <example>
            /// "TX"
            /// </example>
            abstract regionCode: option<D1SessionBookmark> with get, set
            /// <example>
            /// "Texas"
            /// </example>
            abstract region: option<D1SessionBookmark> with get, set
            /// <example>
            /// "America/Chicago"
            /// </example>
            abstract timezone: option<D1SessionBookmark> with get, set
            /// <example>
            /// "-97.74260"
            /// </example>
            abstract longitude: option<D1SessionBookmark> with get, set
            /// <example>
            /// "30.27130"
            /// </example>
            abstract latitude: option<D1SessionBookmark> with get, set
            /// <example>
            /// "78701"
            /// </example>
            abstract postalCode: option<D1SessionBookmark> with get, set
            /// <example>
            /// "Austin"
            /// </example>
            abstract city: option<D1SessionBookmark> with get, set
            /// <example>
            /// "AN"
            /// </example>
            abstract continent: option<ContinentCode> with get, set
            /// <example>
            /// "1"
            /// </example>
            abstract isEUCountry: option<OnRequest.IsEUCountry> with get, set
            /// <example>
            /// "GB"
            /// </example>
            abstract country: option<OnRequest.Country> with get, set
            abstract hostMetadata: option<'HostMetadata> with get, set
            /// <deprecated />
            abstract clientTrustScore: float with get, set
            abstract botManagement: IncomingRequestCfPropertiesBotManagementBase with get, set
            abstract botManagement: OnRequest.BotManagement with get, set
            abstract tlsExportedAuthenticator: option<IncomingRequestCfPropertiesExportedAuthenticatorMetadata> with get, set
            /// <example>
            /// "AEAD-AES128-GCM-SHA256"
            /// </example>
            abstract tlsCipher: D1SessionBookmark with get, set
            /// <example>
            /// "TLSv1.3"
            /// </example>
            abstract tlsVersion: D1SessionBookmark with get, set
            /// <example>
            /// "weight=192;exclusive=0;group=3;group-weight=127"
            /// </example>
            abstract requestPriority: D1SessionBookmark with get, set
            /// <example>
            /// "HTTP/2"
            /// </example>
            abstract httpProtocol: D1SessionBookmark with get, set
            /// <example>
            /// 3
            /// </example>
            abstract edgeRequestKeepAliveStatus: OnRequest.EdgeRequestKeepAliveStatus with get, set
            /// <example>
            /// "DFW"
            /// </example>
            abstract colo: D1SessionBookmark with get, set
            /// <example>
            /// 22
            /// </example>
            abstract clientTcpRtt: option<float> with get, set
            /// <example>
            /// "gzip, deflate, br"
            /// </example>
            abstract clientAcceptEncoding: option<D1SessionBookmark> with get, set
            /// <example>
            /// "Google Cloud"
            /// </example>
            abstract asOrganization: option<D1SessionBookmark> with get, set
            /// <example>
            /// 395747
            /// </example>
            abstract asn: option<float> with get, set
            abstract data: 'Data with get, set
            abstract params: OnRequest.Params with get, set
            abstract env: OnRequest.Env with get, set
            abstract functionPath: D1SessionBookmark with get, set
            abstract request: Typescript.Request<option<obj>, OnRequest.Request> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

            abstract Invoke:
                input:
                    U3<
                        Typescript.Request<option<obj>, U2<RequestInitCfProperties, OnRequest.OnRequest.Input>>,
                        URL,
                        D1SessionBookmark
                     > *
                ?init: Typescript.RequestInit<RequestInitCfProperties> ->
                    Promise<Typescript.Response>

            abstract Invoke:
                input:
                    U3<
                        Typescript.Request<option<obj>, U2<RequestInitCfProperties, OnRequest.OnRequest.Input>>,
                        URL,
                        D1SessionBookmark
                     > *
                ?init: Typescript.RequestInit<U2<RequestInitCfProperties, OnRequest.OnRequest.Init>> ->
                    Promise<Typescript.Response>

            abstract next:
                ?input: RequestInfo * ?init: Typescript.RequestInit<U2<RequestInitCfProperties, OnRequest.Next.Init>> ->
                    Promise<Typescript.Response>

            abstract passThroughOnException: unit -> unit
            abstract waitUntil: promise: Promise<option<obj>> -> unit

        [<Import("@cloudflare/workers-types", "Socket")>]
        type Socket =
            abstract secureTransport: Socket.SecureTransport with get
            abstract upgraded: bool with get
            abstract opened: Promise<SocketInfo> with get
            abstract closed: Promise<unit> with get
            abstract writable: WritableStream<option<obj>> with get
            abstract readable: ReadableStream<option<obj>> with get
            abstract startTls: ?options: TlsOptions -> Socket
            abstract close: unit -> Promise<unit>

        type AddEventListener =
            abstract Invoke:
                ``type``: 'Type * handler: Typescript.Body * ?options: U2<EventTargetAddEventListenerOptions, bool> ->
                    unit

            abstract Invoke:
                ``type``: D1SessionBookmark *
                listener: EventListenerOrEventListenerObject *
                ?options: U2<AddEventListenerOptions, bool> ->
                    unit

            abstract Invoke:
                ``type``: 'K *
                listener: Window -> proptypekey<WindowEventMap, 'K> -> option<obj> *
                ?options: U2<AddEventListenerOptions, bool> ->
                    unit

        [<Import("@cloudflare/workers-types", "ChatCompletionsPromptInput")>]
        type ChatCompletionsPromptInput =
            abstract functions: option<Array<FunctionDefinition>> with get, set

            [<CompiledName("function_call")>]
            abstract functionCall:
                option<U2<ChatCompletionsPromptInput.FunctionCall, ChatCompletionsPromptInput.FunctionCall>> with get, set

            [<CompiledName("web_search_options")>]
            abstract webSearchOptions: option<WebSearchOptions> with get, set

            abstract user: option<D1SessionBookmark> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract tools: option<Array<ChatCompletionTool>> with get, set

            [<CompiledName("tool_choice")>]
            abstract toolChoice:
                option<
                    U4<
                        ChatCompletionsPromptInput.ToolChoice,
                        ChatCompletionToolChoiceFunction,
                        ChatCompletionToolChoiceCustom,
                        ChatCompletionToolChoiceAllowedTools
                     >
                 > with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("stream_options")>]
            abstract streamOptions: option<ChatCompletionsStreamOptions> with get, set

            abstract stream: option<bool> with get, set
            abstract store: option<bool> with get, set
            abstract stop: option<U2<Array<D1SessionBookmark>, D1SessionBookmark>> with get, set

            [<CompiledName("service_tier")>]
            abstract serviceTier: option<ChatCompletionsPromptInput.ServiceTier> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<ResponseFormat> with get, set

            [<CompiledName("chat_template_kwargs")>]
            abstract chatTemplateKwargs: option<ChatTemplateKwargs> with get, set

            [<CompiledName("reasoning_effort")>]
            abstract reasoningEffort: option<ChatCompletionsPromptInput.ReasoningEffort> with get, set

            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            abstract prediction: option<PredictionContent> with get, set

            [<CompiledName("parallel_tool_calls")>]
            abstract parallelToolCalls: option<bool> with get, set

            abstract n: option<float> with get, set
            abstract modalities: option<Array<ChatCompletionsPromptInput.Modalities>> with get, set
            abstract metadata: option<ChatCompletionsPromptInput.Metadata> with get, set

            [<CompiledName("max_completion_tokens")>]
            abstract maxCompletionTokens: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            [<CompiledName("top_logprobs")>]
            abstract topLogprobs: option<float> with get, set

            abstract logprobs: option<bool> with get, set

            [<CompiledName("logit_bias")>]
            abstract logitBias: option<ChatCompletionsPromptInput.LogitBias> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            abstract audio: option<AudioParams> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "QueueEvent")>]
        type QueueEvent<'Body> =
            inherit ExtendableEvent
            abstract metadata: MessageBatchMetadata with get
            abstract queue: D1SessionBookmark with get
            abstract messages: ReadonlyArray<Message<'Body>> with get
            abstract ackAll: unit -> unit
            abstract retryAll: ?options: QueueRetryOptions -> unit

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Leonardo_Phoenix_1_0")>]
        type BaseAiCfLeonardoPhoenix10 =
            abstract postProcessedOutputs: D1SessionBookmark with get, set
            abstract inputs: AiCfLeonardoPhoenix10Input with get, set

        [<Import("@cloudflare/workers-types", "RequestInitCfProperties")>]
        type RequestInitCfProperties =
            inherit RequestInitCfProperties
            abstract resolveOverride: option<D1SessionBookmark> with get, set
            abstract r2: option<RequestInitCfPropertiesR2> with get, set
            abstract polish: option<RequestInitCfProperties.Polish> with get, set
            abstract mirage: option<bool> with get, set
            abstract minify: option<RequestInitCfPropertiesImageMinify> with get, set
            abstract image: option<RequestInitCfPropertiesImage> with get, set
            abstract apps: option<bool> with get, set
            abstract scrapeShield: option<bool> with get, set
            abstract cacheReserveMinimumFileSize: option<float> with get, set
            abstract cacheDeceptionArmor: option<bool> with get, set
            abstract stripLastModified: option<bool> with get, set
            abstract stripEtags: option<bool> with get, set
            abstract respectStrongEtag: option<bool> with get, set
            abstract cacheReserveEligible: option<bool> with get, set
            abstract cacheControl: option<D1SessionBookmark> with get, set
            abstract cacheTtlByStatus: option<RequestInitCfProperties.CacheTtlByStatus> with get, set
            abstract cacheTtl: option<float> with get, set
            abstract cacheTags: option<Array<D1SessionBookmark>> with get, set
            abstract cacheKey: option<D1SessionBookmark> with get, set
            abstract cacheEverything: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "AIGatewayUniversalRequest")>]
        type AIGatewayUniversalRequest =
            abstract query: option<obj> with get, set
            abstract headers: AIGatewayUniversalRequest.Headers with get, set
            abstract endpoint: D1SessionBookmark with get, set
            abstract provider: U2<AIGatewayUniversalRequest.Provider, D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Input_QueryAnd_Contexts_1")>]
        type AiCfBaaiBgeM3InputQueryAndContexts1 =
            [<CompiledName("truncate_inputs")>]
            abstract truncateInputs: option<bool> with get, set

            abstract contexts: Array<AiCfBaaiBgeM3InputQueryAndContexts1.Contexts> with get, set
            abstract query: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "AbortSignal")>]
        type AbortSignal =
            inherit EventTarget
            abstract onabort: option<obj> with set
            abstract onabort: option<obj> with get
            abstract reason: option<obj> with get
            abstract aborted: bool with get
            abstract throwIfAborted: unit -> unit
            abstract any: signals: Array<AbortSignal> -> AbortSignal
            abstract timeout: delay: float -> AbortSignal
            abstract abort: ?reason: obj -> AbortSignal

        [<Import("@cloudflare/workers-types", "ExportedHandlerFetchHandler")>]
        type ExportedHandlerFetchHandler<'Props, 'CfHostMetadata, 'Env> =
            abstract Invoke:
                request:
                    Typescript.Request<'CfHostMetadata, ExportedHandlerFetchHandler.ExportedHandlerFetchHandler.Request> *
                env: 'Env *
                ctx: ExecutionContext<'Props> ->
                    U2<Typescript.Response, Promise<Typescript.Response>>

        [<Import("@cloudflare/workers-types", "PagesPluginFunction")>]
        type PagesPluginFunction<'PluginArgs, 'Data, 'Params, 'Env
            when 'Data :> PagesPluginFunction and 'Params :> D1SessionBookmark> =
            abstract Invoke:
                context: PagesPluginFunction.PagesPluginFunction.Context ->
                    U2<Typescript.Response, Promise<Typescript.Response>>

        [<Import("@cloudflare/workers-types", "MaxFileSizeError")>]
        type MaxFileSizeError =
            inherit StreamError
            abstract name: MaxFileSizeError.Name with get, set

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesBotManagementEnterprise")>]
        type IncomingRequestCfPropertiesBotManagementEnterprise =
            inherit IncomingRequestCfPropertiesBotManagement
            abstract botManagement: IncomingRequestCfPropertiesBotManagementEnterprise.BotManagement with get, set

        [<Import("@cloudflare/workers-types", "PromptTokensDetails")>]
        type PromptTokensDetails =
            [<CompiledName("audio_tokens")>]
            abstract audioTokens: option<float> with get, set

            [<CompiledName("cached_tokens")>]
            abstract cachedTokens: option<float> with get, set

        [<Import("@cloudflare/workers-types", "ReadableStream")>]
        type ReadableStream<'R> =
            abstract locked: bool with get

            abstract ``[symbol.asyncIterator]``:
                ?options: ReadableStreamValuesOptions -> AsyncIterableIterator<'R, option<obj>, option<obj>>

            abstract values:
                ?options: ReadableStreamValuesOptions -> AsyncIterableIterator<'R, option<obj>, option<obj>>

            abstract tee: unit -> ReadableStream<'R> * ReadableStream<'R>
            abstract pipeTo: destination: WritableStream<'R> * ?options: Typescript.StreamPipeOptions -> Promise<unit>

            abstract pipeThrough:
                transform: Typescript.ReadableWritablePair<'T, 'R> * ?options: Typescript.StreamPipeOptions ->
                    ReadableStream<'T>

            abstract getReader: options: Typescript.ReadableStreamGetReaderOptions -> ReadableStreamBYOBReader
            abstract getReader: unit -> ReadableStreamDefaultReader<'R>
            abstract cancel: ?reason: obj -> Promise<unit>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode_2")>]
        type AiCfMetaLlama3370BInstructFp8FastJSONMode2 =
            [<CompiledName("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<AiCfMetaLlama3370BInstructFp8FastJSONMode2.Type> with get, set

        [<Import("@cloudflare/workers-types", "ImagesError")>]
        type ImagesError =
            inherit Error
            abstract stack: option<D1SessionBookmark> with get
            abstract message: D1SessionBookmark with get
            abstract code: float with get

        [<Import("@cloudflare/workers-types", "ArtifactsRepo")>]
        type ArtifactsRepo =
            inherit ArtifactsRepoInfo

            abstract fork:
                name: D1SessionBookmark * ?opts: ArtifactsRepo.Fork.Opts -> Promise<ArtifactsCreateRepoResult>

            abstract revokeToken: tokenOrId: D1SessionBookmark -> Promise<bool>
            abstract listTokens: unit -> Promise<ArtifactsTokenListResult>

            abstract createToken:
                ?scope: ArtifactsRepo.CreateToken.Scope * ?ttl: float -> Promise<ArtifactsCreateTokenResult>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseIncludable =
            | [<CompiledName("message.input_image.image_url")>] ``Message.inputImage.imageUrl``
            | [<CompiledName("message.output_text.logprobs")>] ``Message.outputText.logprobs``

        [<Import("@cloudflare/workers-types", "MessagePortPostMessageOptions")>]
        type MessagePortPostMessageOptions =
            abstract transfer: option<Array<option<obj>>> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Output_Query")>]
        type AiCfBaaiBgeM3OutputQuery =
            abstract response: option<Array<AiCfBaaiBgeM3OutputQuery.Response>> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Black_Forest_Labs_Flux_2_Klein_9B")>]
        type BaseAiCfBlackForestLabsFlux2Klein9B =
            abstract postProcessedOutputs: AiCfBlackForestLabsFlux2Klein9BOutput with get, set
            abstract inputs: AiCfBlackForestLabsFlux2Klein9BInput with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItemContentResult")>]
        type AiSearchItemContentResult =
            abstract size: float with get, set
            abstract filename: D1SessionBookmark with get, set
            abstract contentType: D1SessionBookmark with get, set
            abstract body: ReadableStream<option<obj>> with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionContentPartInputAudio")>]
        type ChatCompletionContentPartInputAudio =
            [<CompiledName("input_audio")>]
            abstract inputAudio: ChatCompletionContentPartInputAudio.InputAudio with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionContentPartInputAudio.Type with get, set

        [<Import("@cloudflare/workers-types", "WorkerVersionMetadata")>]
        type WorkerVersionMetadata =
            abstract timestamp: D1SessionBookmark with get, set
            abstract tag: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiGatewayLogNotFound")>]
        type AiGatewayLogNotFound =
            interface
                inherit Error
            end

        [<Import("@cloudflare/workers-types", "AiTextGenerationFunctionsInput")>]
        type AiTextGenerationFunctionsInput =
            abstract code: D1SessionBookmark with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AnalyticsEngineDataset")>]
        type AnalyticsEngineDataset =
            abstract writeDataPoint: ?event: AnalyticsEngineDataPoint -> unit

        [<Import("@cloudflare/workers-types", "MessageEvent")>]
        type MessageEvent =
            [<EmitConstructor>]
            abstract Create:
                ``type``: D1SessionBookmark * initializer: Typescript.MessageEventInit<option<obj>> -> MessageEvent

            inherit Event
            abstract ports: Array<MessagePort> with get
            abstract source: option<MessagePort> with get
            abstract lastEventId: D1SessionBookmark with get
            abstract origin: option<D1SessionBookmark> with get
            abstract data: option<obj> with get

        [<Import("@cloudflare/workers-types", "D1PreparedStatement")>]
        type D1PreparedStatement =
            abstract raw: ?options: D1PreparedStatement.Raw.Options -> Promise<Array<'T>>
            abstract raw: options: D1PreparedStatement.Raw.Options -> Promise<Array<D1SessionBookmark> * Array<'T>>
            abstract all: unit -> Promise<D1PreparedStatement.All>
            abstract run: unit -> Promise<D1PreparedStatement.Run>
            abstract first: unit -> Promise<option<'T>>
            abstract first: colName: D1SessionBookmark -> Promise<option<'T>>
            abstract bind: [<ParamArray>] values: Array<option<obj>> -> D1PreparedStatement

        [<Import("@cloudflare/workers-types", "SyncKvListOptions")>]
        type SyncKvListOptions =
            abstract limit: option<float> with get, set
            abstract reverse: option<bool> with get, set
            abstract prefix: option<D1SessionBookmark> with get, set

            [<CompiledName("end")>]
            abstract ``end``: option<D1SessionBookmark> with get, set

            abstract startAfter: option<D1SessionBookmark> with get, set
            abstract start: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Output_Embedding")>]
        type AiCfBaaiBgeM3OutputEmbedding =
            abstract pooling: option<AiCfBaaiBgeM3OutputEmbedding.Pooling> with get, set
            abstract data: option<Array<AiSentenceSimilarityOutput>> with get, set
            abstract shape: option<AiSentenceSimilarityOutput> with get, set

        [<Import("@cloudflare/workers-types", "ImageListOptions")>]
        type ImageListOptions =
            abstract creator: option<D1SessionBookmark> with get, set
            abstract sortOrder: option<ImageListOptions.SortOrder> with get, set
            abstract cursor: option<D1SessionBookmark> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Openai_Whisper_Tiny_En_Output")>]
        type AiCfOpenaiWhisperTinyEnOutput =
            abstract vtt: option<D1SessionBookmark> with get, set
            abstract words: option<Array<AiCfOpenaiWhisperTinyEnOutput.Words>> with get, set

            [<CompiledName("word_count")>]
            abstract wordCount: option<float> with get, set

            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Text_Completion_Response")>]
        type AiCfQwenQwen330BA3BFp8TextCompletionResponse =
            abstract usage: option<AiCfQwenQwen330BA3BFp8TextCompletionResponse.Usage> with get, set
            abstract choices: option<Array<AiCfQwenQwen330BA3BFp8TextCompletionResponse.Choices>> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract created: option<float> with get, set
            abstract object: option<AiCfQwenQwen330BA3BFp8TextCompletionResponse.Object> with get, set
            abstract id: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Logprob")>]
        type Logprob =
            [<CompiledName("top_logprobs")>]
            abstract topLogprobs: option<Array<TopLogprob>> with get, set

            abstract logprob: float with get, set
            abstract token: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiSearchSearchResponse")>]
        type AiSearchSearchResponse =
            abstract chunks: Array<AiSearchSearchResponse.Chunks> with get, set

            [<CompiledName("search_query")>]
            abstract searchQuery: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Event")>]
        type Event =
            [<EmitConstructor>]
            abstract Create: ``type``: D1SessionBookmark * ?init: Typescript.EventInit -> Event

            abstract BUBBLING_PHASE: float with get
            abstract AT_TARGET: float with get
            abstract CAPTURING_PHASE: float with get
            abstract NONE: float with get
            /// <deprecated>
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/cancelBubble)
            /// </deprecated>
            abstract cancelBubble: bool with get, set
            abstract isTrusted: bool with get
            abstract timeStamp: float with get
            /// <deprecated>
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/srcElement)
            /// </deprecated>
            abstract srcElement: option<EventTarget> with get
            abstract target: option<EventTarget> with get
            abstract currentTarget: option<EventTarget> with get
            /// <deprecated>
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/returnValue)
            /// </deprecated>
            abstract returnValue: bool with get
            abstract defaultPrevented: bool with get
            abstract cancelable: bool with get
            abstract bubbles: bool with get
            abstract composed: bool with get
            abstract eventPhase: float with get

            [<CompiledName("type")>]
            abstract ``type``: D1SessionBookmark with get

            abstract composedPath: unit -> Array<EventTarget>
            abstract stopPropagation: unit -> unit
            abstract preventDefault: unit -> unit
            abstract stopImmediatePropagation: unit -> unit

        [<Import("@cloudflare/workers-types", "DurableObject")>]
        type DurableObject =
            abstract webSocketError: ws: Typescript.WebSocket * ?error: obj -> option<Promise<unit>>

            abstract webSocketClose:
                ws: Typescript.WebSocket * code: float * reason: D1SessionBookmark * wasClean: bool ->
                    option<Promise<unit>>

            abstract webSocketMessage:
                ws: Typescript.WebSocket * message: U2<ArrayBuffer, D1SessionBookmark> -> option<Promise<unit>>

            abstract alarm: ?alarmInfo: AlarmInvocationInfo -> option<Promise<unit>>
            abstract connect: socket: Socket -> option<Promise<unit>>

            abstract fetch:
                request: Typescript.Request<option<obj>, U2<RequestInitCfProperties, DurableObject.Fetch.Request>> ->
                    U2<Typescript.Response, Promise<Typescript.Response>>

        type Service =
            abstract connect: address: U2<SocketAddress, D1SessionBookmark> * ?options: SocketOptions -> Socket

            abstract fetch:
                input:
                    U3<
                        Typescript.Request<option<obj>, U2<RequestInitCfProperties, Service.Fetch.Input>>,
                        URL,
                        D1SessionBookmark
                     > *
                ?init: Typescript.RequestInit<U2<RequestInitCfProperties, Service.Fetch.Init>> ->
                    Promise<Typescript.Response>

            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke: [<ParamArray>] args: Service.Service.Args -> U2<Service.Service, U2<Service.Service, unit>>

        [<Import("@cloudflare/workers-types", "URL")>]
        type URL =
            [<EmitConstructor>]
            abstract Create: url: U2<URL, D1SessionBookmark> * ?``base``: U2<URL, D1SessionBookmark> -> URL

            abstract hash: D1SessionBookmark with get, set
            abstract searchParams: URLSearchParams with get
            abstract search: D1SessionBookmark with get, set
            abstract pathname: D1SessionBookmark with get, set
            abstract port: D1SessionBookmark with get, set
            abstract hostname: D1SessionBookmark with get, set
            abstract host: D1SessionBookmark with get, set
            abstract password: D1SessionBookmark with get, set
            abstract username: D1SessionBookmark with get, set
            abstract protocol: D1SessionBookmark with get, set
            abstract origin: D1SessionBookmark with get
            abstract href: D1SessionBookmark with get, set
            abstract toJSON: unit -> D1SessionBookmark
            abstract toString: unit -> D1SessionBookmark

        [<Import("@cloudflare/workers-types", "RateLimitOptions")>]
        type RateLimitOptions =
            abstract key: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "StreamPublicDetails")>]
        type StreamPublicDetails =
            abstract logo: option<D1SessionBookmark> with get, set

            [<CompiledName("channel_link")>]
            abstract channelLink: option<D1SessionBookmark> with get, set

            [<CompiledName("share_link")>]
            abstract shareLink: option<D1SessionBookmark> with get, set

            abstract title: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionsMessagesInput")>]
        type ChatCompletionsMessagesInput =
            abstract functions: option<Array<FunctionDefinition>> with get, set

            [<CompiledName("function_call")>]
            abstract functionCall:
                option<U2<ChatCompletionsMessagesInput.FunctionCall, ChatCompletionsMessagesInput.FunctionCall>> with get, set

            [<CompiledName("web_search_options")>]
            abstract webSearchOptions: option<WebSearchOptions> with get, set

            abstract user: option<D1SessionBookmark> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract tools: option<Array<ChatCompletionTool>> with get, set

            [<CompiledName("tool_choice")>]
            abstract toolChoice:
                option<
                    U4<
                        ChatCompletionsMessagesInput.ToolChoice,
                        ChatCompletionToolChoiceFunction,
                        ChatCompletionToolChoiceCustom,
                        ChatCompletionToolChoiceAllowedTools
                     >
                 > with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("stream_options")>]
            abstract streamOptions: option<ChatCompletionsStreamOptions> with get, set

            abstract stream: option<bool> with get, set
            abstract store: option<bool> with get, set
            abstract stop: option<U2<Array<D1SessionBookmark>, D1SessionBookmark>> with get, set

            [<CompiledName("service_tier")>]
            abstract serviceTier: option<ChatCompletionsMessagesInput.ServiceTier> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<ResponseFormat> with get, set

            [<CompiledName("chat_template_kwargs")>]
            abstract chatTemplateKwargs: option<ChatTemplateKwargs> with get, set

            [<CompiledName("reasoning_effort")>]
            abstract reasoningEffort: option<ChatCompletionsMessagesInput.ReasoningEffort> with get, set

            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            abstract prediction: option<PredictionContent> with get, set

            [<CompiledName("parallel_tool_calls")>]
            abstract parallelToolCalls: option<bool> with get, set

            abstract n: option<float> with get, set
            abstract modalities: option<Array<ChatCompletionsMessagesInput.Modalities>> with get, set
            abstract metadata: option<ChatCompletionsMessagesInput.Metadata> with get, set

            [<CompiledName("max_completion_tokens")>]
            abstract maxCompletionTokens: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            [<CompiledName("top_logprobs")>]
            abstract topLogprobs: option<float> with get, set

            abstract logprobs: option<bool> with get, set

            [<CompiledName("logit_bias")>]
            abstract logitBias: option<ChatCompletionsMessagesInput.LogitBias> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            abstract audio: option<AudioParams> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract messages: Array<ChatCompletionMessageParam> with get, set

        [<Import("@cloudflare/workers-types", "BaseAiTranslation")>]
        type BaseAiTranslation =
            abstract postProcessedOutputs: AiTranslationOutput with get, set
            abstract inputs: AiTranslationInput with get, set

        [<Import("@cloudflare/workers-types", "AiSearchUploadItemOptions")>]
        type AiSearchUploadItemOptions =
            abstract metadata: option<AiSearchUploadItemOptions.Metadata> with get, set

        [<Import("@cloudflare/workers-types", "Tracing")>]
        type Tracing =
            [<CompiledName("Span")>]
            abstract span: Tracing.Span with get, set

            abstract enterSpan:
                name: D1SessionBookmark * callback: Tracing.EnterSpan.Callback * [<ParamArray>] args: 'A -> 'T

        [<Import("@cloudflare/workers-types", "TraceException")>]
        type TraceException =
            abstract stack: option<D1SessionBookmark> with get
            abstract name: D1SessionBookmark with get
            abstract message: D1SessionBookmark with get
            abstract timestamp: float with get

        type ResponseInput =
            Array<
                U6<
                    ResponseOutputMessage,
                    ResponseFunctionToolCall,
                    ResponseReasoningItem,
                    EasyInputMessage,
                    ResponseInputItemMessage,
                    ResponseInputItemFunctionCallOutput
                 >
             >

        [<Import("@cloudflare/workers-types", "TextDecoderConstructorOptions")>]
        type TextDecoderConstructorOptions =
            abstract ignoreBOM: bool with get, set
            abstract fatal: bool with get, set

        [<Import("@cloudflare/workers-types", "DynamicDispatchLimits")>]
        type DynamicDispatchLimits =
            abstract subRequests: option<float> with get, set
            abstract cpuMs: option<float> with get, set

        [<Import("@cloudflare/workers-types", "IdentityTransformStreamQueuingStrategy")>]
        type IdentityTransformStreamQueuingStrategy =
            abstract highWaterMark: option<float> with get, set

        [<Import("@cloudflare/workers-types", "WebSocketAcceptOptions")>]
        type WebSocketAcceptOptions =
            abstract allowHalfOpen: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "D1ExecResult")>]
        type D1ExecResult =
            abstract duration: float with get, set
            abstract count: float with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type StreamDownloadType =
            | [<CompiledName("default")>] Default
            | [<CompiledName("audio")>] Audio

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwq_32B_Output")>]
        type AiCfQwenQwq32BOutput =
            [<CompiledName("tool_calls")>]
            abstract toolCalls: option<Array<AiCfQwenQwq32BOutput.ToolCalls>> with get, set

            abstract usage: option<AiCfQwenQwq32BOutput.Usage> with get, set
            abstract response: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "MediaTransformationResult")>]
        type MediaTransformationResult =
            abstract contentType: unit -> Promise<D1SessionBookmark>
            abstract response: unit -> Promise<Typescript.Response>
            abstract media: unit -> Promise<ReadableStream<Uint8Array<ArrayBufferLike>>>

        [<Import("@cloudflare/workers-types", "AiTextEmbeddingsOutput")>]
        type AiTextEmbeddingsOutput =
            abstract data: Array<AiSentenceSimilarityOutput> with get, set
            abstract shape: AiSentenceSimilarityOutput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_Guard_3_8B_Input")>]
        type AiCfMetaLlamaGuard38BInput =
            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfMetaLlamaGuard38BInput.ResponseFormat> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract messages: Array<AiCfMetaLlamaGuard38BInput.Messages> with get, set

        type AiCfBaaiBgeBaseEnV15Input = U2<AiCfBaaiBgeBaseEnV15Input, AiCfBaaiBgeBaseEnV15Input>

        [<Import("@cloudflare/workers-types", "ErrorEventErrorEventInit")>]
        type ErrorEventErrorEventInit =
            abstract error: option<obj> with get, set
            abstract colno: option<float> with get, set
            abstract lineno: option<float> with get, set
            abstract filename: option<D1SessionBookmark> with get, set
            abstract message: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchConfig")>]
        type AiSearchConfig =
            abstract metadata: option<AiSearchConfig.Metadata> with get, set

            [<CompiledName("sync_interval")>]
            abstract syncInterval: option<AiSearchConfig.SyncInterval> with get, set

            [<CompiledName("namespace")>]
            abstract ``namespace``: option<D1SessionBookmark> with get, set

            [<CompiledName("custom_metadata")>]
            abstract customMetadata: option<Array<AiSearchConfig.CustomMetadata>> with get, set

            [<CompiledName("cache_threshold")>]
            abstract cacheThreshold: option<AiSearchConfig.CacheThreshold> with get, set

            abstract cache: option<bool> with get, set

            [<CompiledName("max_num_results")>]
            abstract maxNumResults: option<float> with get, set

            [<CompiledName("score_threshold")>]
            abstract scoreThreshold: option<float> with get, set

            [<CompiledName("chunk_overlap")>]
            abstract chunkOverlap: option<float> with get, set

            [<CompiledName("chunk_size")>]
            abstract chunkSize: option<float> with get, set

            abstract chunk: option<bool> with get, set

            [<CompiledName("retrieval_options")>]
            abstract retrievalOptions: option<AiSearchConfig.RetrievalOptions> with get, set

            [<CompiledName("indexing_options")>]
            abstract indexingOptions: option<AiSearchConfig.IndexingOptions> with get, set

            [<CompiledName("fusion_method")>]
            abstract fusionMethod: option<AiSearchConfig.FusionMethod> with get, set

            [<CompiledName("index_method")>]
            abstract indexMethod: option<AiSearchConfig.IndexMethod> with get, set

            /// <deprecated>
            /// Use index_method instead.
            /// </deprecated>
            [<CompiledName("hybrid_search_enabled")>]
            abstract hybridSearchEnabled: option<bool> with get, set

            [<CompiledName("reranking_model")>]
            abstract rerankingModel: option<D1SessionBookmark> with get, set

            [<CompiledName("rewrite_model")>]
            abstract rewriteModel: option<D1SessionBookmark> with get, set

            [<CompiledName("ai_search_model")>]
            abstract aiSearchModel: option<D1SessionBookmark> with get, set

            [<CompiledName("embedding_model")>]
            abstract embeddingModel: option<D1SessionBookmark> with get, set

            abstract reranking: option<bool> with get, set

            [<CompiledName("rewrite_query")>]
            abstract rewriteQuery: option<bool> with get, set

            [<CompiledName("ai_gateway_id")>]
            abstract aiGatewayId: option<D1SessionBookmark> with get, set

            [<CompiledName("token_id")>]
            abstract tokenId: option<D1SessionBookmark> with get, set

            [<CompiledName("source_params")>]
            abstract sourceParams: option<obj> with get, set

            abstract source: option<D1SessionBookmark> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<U2<AiSearchConfig.Type, D1SessionBookmark>> with get, set

            abstract id: D1SessionBookmark with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "MediaBinding")>]
        type MediaBinding =
            abstract input: media: ReadableStream<Uint8Array<ArrayBufferLike>> -> MediaTransformer

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Baai_Bge_M3")>]
        type BaseAiCfBaaiBgeM3 =
            abstract postProcessedOutputs: AiCfBaaiBgeM3Output with get, set
            abstract inputs: AiCfBaaiBgeM3Input with get, set

        [<Import("@cloudflare/workers-types", "RateLimit")>]
        type RateLimit =
            abstract limit: options: RateLimitOptions -> Promise<RateLimitOutcome>

        [<Import("@cloudflare/workers-types", "ResponseOutputItemAddedEvent")>]
        type ResponseOutputItemAddedEvent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseOutputItemAddedEvent.Type with get, set

            [<CompiledName("sequence_number")>]
            abstract sequenceNumber: float with get, set

            [<CompiledName("output_index")>]
            abstract outputIndex: float with get, set

            abstract item: ResponseOutputItem with get, set

        [<Import("@cloudflare/workers-types", "ExportedHandlerTestHandler")>]
        type ExportedHandlerTestHandler<'Props, 'Env> =
            abstract Invoke:
                controller: TestController * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "CacheStorage")>]
        type CacheStorage =
            [<CompiledName("default")>]
            abstract ``default``: Cache with get

            abstract ``open``: cacheName: D1SessionBookmark -> Promise<Cache>

        [<Import("@cloudflare/workers-types", "WorkerGlobalScopeEventMap")>]
        type WorkerGlobalScopeEventMap =
            abstract rejectionhandled: PromiseRejectionEvent with get, set
            abstract unhandledrejection: PromiseRejectionEvent with get, set
            abstract queue: QueueEvent<option<obj>> with get, set
            abstract scheduled: ScheduledEvent with get, set
            abstract fetch: FetchEvent with get, set

        [<Import("@cloudflare/workers-types", "TooManyWatermarksError")>]
        type TooManyWatermarksError =
            inherit StreamError
            abstract name: TooManyWatermarksError.Name with get, set

        [<Import("@cloudflare/workers-types", "TraceItemFetchEventInfoRequest")>]
        type TraceItemFetchEventInfoRequest =
            abstract url: D1SessionBookmark with get
            abstract method: D1SessionBookmark with get
            abstract headers: TraceItemFetchEventInfoRequest.Headers with get
            abstract cf: option<obj> with get
            abstract getUnredacted: unit -> TraceItemFetchEventInfoRequest

        type VectorizeIndexConfig = U2<VectorizeIndexConfig, VectorizeIndexConfig>

        [<Import("@cloudflare/workers-types", "ArtifactsTokenInfo")>]
        type ArtifactsTokenInfo =
            abstract expiresAt: D1SessionBookmark with get, set
            abstract createdAt: D1SessionBookmark with get, set
            abstract state: ArtifactsTokenInfo.State with get, set
            abstract scope: ArtifactsTokenInfo.Scope with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Qwen_Qwen3_Embedding_0_6B")>]
        type BaseAiCfQwenQwen3Embedding06B =
            abstract postProcessedOutputs: AiCfQwenQwen3Embedding06BOutput with get, set
            abstract inputs: AiCfQwenQwen3Embedding06BInput with get, set

        [<Import("@cloudflare/workers-types", "QueueSendResponse")>]
        type QueueSendResponse =
            abstract metadata: QueueSendMetadata with get, set

        [<Import("@cloudflare/workers-types", "R2StringChecksums")>]
        type R2StringChecksums =
            abstract sha512: option<D1SessionBookmark> with get, set
            abstract sha384: option<D1SessionBookmark> with get, set
            abstract sha256: option<D1SessionBookmark> with get, set
            abstract sha1: option<D1SessionBookmark> with get, set
            abstract md5: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "WebSearchOptions")>]
        type WebSearchOptions =
            [<CompiledName("user_location")>]
            abstract userLocation: option<WebSearchUserLocation> with get, set

            [<CompiledName("search_context_size")>]
            abstract searchContextSize: option<WebSearchOptions.SearchContextSize> with get, set

        [<Import("@cloudflare/workers-types", "QueueSendBatchMetrics")>]
        type QueueSendBatchMetrics =
            abstract oldestMessageTimestamp: option<Date> with get, set
            abstract backlogBytes: float with get, set
            abstract backlogCount: float with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Openai_Whisper_Large_V3_Turbo_Output")>]
        type AiCfOpenaiWhisperLargeV3TurboOutput =
            abstract vtt: option<D1SessionBookmark> with get, set
            abstract segments: option<Array<AiCfOpenaiWhisperLargeV3TurboOutput.Segments>> with get, set

            [<CompiledName("word_count")>]
            abstract wordCount: option<float> with get, set

            abstract text: D1SessionBookmark with get, set

            [<CompiledName("transcription_info")>]
            abstract transcriptionInfo: option<AiCfOpenaiWhisperLargeV3TurboOutput.TranscriptionInfo> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Openai_Whisper")>]
        type BaseAiCfOpenaiWhisper =
            abstract postProcessedOutputs: AiCfOpenaiWhisperOutput with get, set
            abstract inputs: U2<AiAutomaticSpeechRecognitionInput, D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "AiSentenceSimilarityInput")>]
        type AiSentenceSimilarityInput =
            abstract sentences: Array<D1SessionBookmark> with get, set
            abstract source: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "StreamWatermarkCreateParams")>]
        type StreamWatermarkCreateParams =
            abstract position: option<StreamWatermarkPosition> with get, set
            abstract scale: option<float> with get, set
            abstract padding: option<float> with get, set
            abstract opacity: option<float> with get, set
            abstract name: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ExportedHandler")>]
        type ExportedHandler<'Props, 'CfHostMetadata, 'QueueHandlerMessage, 'Env> =
            abstract queue: option<ExportedHandler.Queue> with get, set
            abstract email: option<ExportedHandler.Email> with get, set
            abstract test: option<ExportedHandler.Test> with get, set
            abstract scheduled: option<ExportedHandler.Scheduled> with get, set
            abstract tailStream: option<ExportedHandler.TailStream> with get, set
            abstract trace: option<ExportedHandler.Trace> with get, set
            abstract tail: option<ExportedHandler.Tail> with get, set
            abstract connect: option<ExportedHandler.Connect> with get, set
            abstract fetch: option<ExportedHandler.Fetch> with get, set

        type ChatCompletionTool = U2<ChatCompletionFunctionTool, ChatCompletionCustomTool>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8")>]
        type BaseAiCfQwenQwen330BA3BFp8 =
            abstract postProcessedOutputs:
                U4<
                    AiCfQwenQwen330BA3BFp8ChatCompletionResponse,
                    AiCfQwenQwen330BA3BFp8TextCompletionResponse,
                    AiCfQwenQwen330BA3BFp8AsyncResponse,
                    D1SessionBookmark
                 > with get, set

            abstract inputs: AiCfQwenQwen330BA3BFp8Input with get, set

        [<Import("@cloudflare/workers-types", "RoleScopedChatInput")>]
        type RoleScopedChatInput =
            abstract name: option<D1SessionBookmark> with get, set
            abstract content: D1SessionBookmark with get, set
            abstract role: U2<RoleScopedChatInput.Role, RoleScopedChatInput.Role> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItemLogsResponse")>]
        type AiSearchItemLogsResponse =
            [<CompiledName("result_info")>]
            abstract resultInfo: AiSearchItemLogsResponse.ResultInfo with get, set

            abstract result: Array<AiSearchItemLog> with get, set

        [<Import("@cloudflare/workers-types", "BaseAiTextEmbeddings")>]
        type BaseAiTextEmbeddings =
            abstract postProcessedOutputs: AiTextEmbeddingsOutput with get, set
            abstract inputs: AiTextEmbeddingsInput with get, set

        type ResponseFormat =
            U3<ChatCompletionsResponseFormatText, ChatCompletionsResponseFormatJSONObject, ResponseFormatJSONSchema>

        [<Import("@cloudflare/workers-types", "AiSearchListJobsParams")>]
        type AiSearchListJobsParams =
            [<CompiledName("per_page")>]
            abstract perPage: option<float> with get, set

            abstract page: option<float> with get, set

        [<Import("@cloudflare/workers-types", "URLSearchParams")>]
        type URLSearchParams =
            [<EmitConstructor>]
            abstract Create:
                ?init:
                    U4<
                        URLSearchParams,
                        URLSearchParams.Init,
                        Array<D1SessionBookmark * D1SessionBookmark>,
                        D1SessionBookmark
                     > ->
                    URLSearchParams

            abstract size: float with get

            abstract ``[symbol.iterator]``:
                unit -> IterableIterator<D1SessionBookmark * D1SessionBookmark, option<obj>, option<obj>>

            abstract toString: unit -> D1SessionBookmark
            abstract forEach: callback: URLSearchParams.ForEach.Callback * ?thisArg: 'This -> unit
            abstract values: unit -> IterableIterator<D1SessionBookmark, option<obj>, option<obj>>
            abstract keys: unit -> IterableIterator<D1SessionBookmark, option<obj>, option<obj>>
            abstract entries: unit -> IterableIterator<D1SessionBookmark * D1SessionBookmark, option<obj>, option<obj>>
            abstract sort: unit -> unit
            abstract set: name: D1SessionBookmark * value: D1SessionBookmark -> unit
            abstract has: name: D1SessionBookmark -> bool
            abstract getAll: name: D1SessionBookmark -> Array<D1SessionBookmark>
            abstract get: name: D1SessionBookmark -> option<D1SessionBookmark>
            abstract delete: name: D1SessionBookmark -> unit
            abstract append: name: D1SessionBookmark * value: D1SessionBookmark -> unit

        [<Import("@cloudflare/workers-types", "R2Object")>]
        type R2Object =
            abstract ssecKeyMd5: option<D1SessionBookmark> with get
            abstract storageClass: D1SessionBookmark with get
            abstract range: option<R2Range> with get
            abstract customMetadata: option<R2Object.CustomMetadata> with get
            abstract httpMetadata: option<R2HTTPMetadata> with get
            abstract uploaded: Date with get
            abstract checksums: R2Checksums with get
            abstract httpEtag: D1SessionBookmark with get
            abstract etag: D1SessionBookmark with get
            abstract size: float with get
            abstract version: D1SessionBookmark with get
            abstract key: D1SessionBookmark with get
            abstract writeHttpMetadata: headers: Headers -> unit

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Baai_Bge_Base_En_V1_5")>]
        type BaseAiCfBaaiBgeBaseEnV15 =
            abstract postProcessedOutputs: AiCfBaaiBgeBaseEnV15Output with get, set
            abstract inputs: AiCfBaaiBgeBaseEnV15Input with get, set

        type MainModule = option<obj>

        [<Import("@cloudflare/workers-types", "D1Meta")>]
        type D1Meta =
            [<CompiledName("total_attempts")>]
            abstract totalAttempts: option<float> with get, set

            abstract timings: option<D1Meta.Timings> with get, set

            [<CompiledName("served_by_primary")>]
            abstract servedByPrimary: option<bool> with get, set

            [<CompiledName("served_by_colo")>]
            abstract servedByColo: option<D1SessionBookmark> with get, set

            [<CompiledName("served_by_region")>]
            abstract servedByRegion: option<D1SessionBookmark> with get, set

            abstract changes: float with get, set

            [<CompiledName("changed_db")>]
            abstract changedDb: bool with get, set

            [<CompiledName("last_row_id")>]
            abstract lastRowId: float with get, set

            [<CompiledName("rows_written")>]
            abstract rowsWritten: float with get, set

            [<CompiledName("rows_read")>]
            abstract rowsRead: float with get, set

            [<CompiledName("size_after")>]
            abstract sizeAfter: float with get, set

            abstract duration: float with get, set

        [<Import("@cloudflare/workers-types", "GatewayRetries")>]
        type GatewayRetries =
            abstract backoff: option<CloudflareWorkersModule.WorkflowBackoff> with get, set
            abstract retryDelayMs: option<float> with get, set
            abstract maxAttempts: option<GatewayRetries.MaxAttempts> with get, set

        [<Import("@cloudflare/workers-types", "FunctionMessage")>]
        type FunctionMessage =
            abstract name: D1SessionBookmark with get, set
            abstract content: D1SessionBookmark with get, set
            abstract role: FunctionMessage.Role with get, set

        [<Import("@cloudflare/workers-types", "StreamVideosListParams")>]
        type StreamVideosListParams =
            abstract afterComp: option<StreamPaginationComparison> with get, set
            abstract after: option<D1SessionBookmark> with get, set
            abstract beforeComp: option<StreamPaginationComparison> with get, set
            abstract before: option<D1SessionBookmark> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "FixedLengthStream")>]
        type FixedLengthStream =
            interface
                [<EmitConstructor>]
                abstract Create:
                    expectedLength: float * ?queuingStrategy: IdentityTransformStreamQueuingStrategy ->
                        FixedLengthStream

                inherit IdentityTransformStream<'FixedLengthStream>
            end

        [<Import("@cloudflare/workers-types", "ReadableStreamBYOBReaderReadableStreamBYOBReaderReadOptions")>]
        type ReadableStreamBYOBReaderReadableStreamBYOBReaderReadOptions =
            abstract min: option<float> with get, set

        [<Import("@cloudflare/workers-types", "Crypto")>]
        type Crypto =
            [<CompiledName("DigestStream")>]
            abstract digestStream: Crypto.DigestStream with get, set

            abstract subtle: SubtleCrypto with get
            abstract randomUUID: unit -> D1SessionBookmark
            abstract getRandomValues: buffer: 'T -> 'T

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_AsyncResponse")>]
        type AiCfMetaLlama3370BInstructFp8FastAsyncResponse =
            [<CompiledName("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "CryptoKeyAesKeyAlgorithm")>]
        type CryptoKeyAesKeyAlgorithm =
            abstract length: float with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItemChunksResponse")>]
        type AiSearchItemChunksResponse =
            [<CompiledName("result_info")>]
            abstract resultInfo: AiSearchItemChunksResponse.ResultInfo with get, set

            abstract result: Array<AiSearchItemChunk> with get, set

        [<Import("@cloudflare/workers-types", "FlagshipEvaluationError")>]
        type FlagshipEvaluationError =
            interface
                inherit Error
            end

        [<Import("@cloudflare/workers-types", "SyncKvStorage")>]
        type SyncKvStorage =
            abstract delete: key: D1SessionBookmark -> bool
            abstract put: key: D1SessionBookmark * value: 'T -> unit
            abstract list: ?options: SyncKvListOptions -> Iterable<D1SessionBookmark * 'T, option<obj>, option<obj>>
            abstract get: key: D1SessionBookmark -> option<'T>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B_Output")>]
        type AiCfAi4BharatIndictrans2EnIndic1BOutput =
            abstract translations: Array<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode")>]
        type AiCfMetaLlama3370BInstructFp8FastJSONMode =
            [<CompiledName("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<AiCfMetaLlama3370BInstructFp8FastJSONMode.Type> with get, set

        [<Import("@cloudflare/workers-types", "R2Bucket")>]
        type R2Bucket =
            abstract list: ?options: R2ListOptions -> Promise<R2Objects>
            abstract delete: keys: U2<Array<D1SessionBookmark>, D1SessionBookmark> -> Promise<unit>
            abstract resumeMultipartUpload: key: D1SessionBookmark * uploadId: D1SessionBookmark -> R2MultipartUpload

            abstract createMultipartUpload:
                key: D1SessionBookmark * ?options: R2MultipartOptions -> Promise<R2MultipartUpload>

            abstract put:
                key: D1SessionBookmark *
                ?value:
                    U5<
                        ReadableStream<option<obj>>,
                        ArrayBuffer,
                        ArrayBufferView<ArrayBufferLike>,
                        Blob,
                        D1SessionBookmark
                     > *
                ?options: R2PutOptions ->
                    Promise<R2Object>

            abstract put:
                key: D1SessionBookmark *
                ?value:
                    U5<
                        ReadableStream<option<obj>>,
                        ArrayBuffer,
                        ArrayBufferView<ArrayBufferLike>,
                        Blob,
                        D1SessionBookmark
                     > *
                ?options: R2Bucket.Put.Options ->
                    Promise<option<R2Object>>

            abstract get: key: D1SessionBookmark * ?options: R2GetOptions -> Promise<option<R2ObjectBody>>

            abstract get:
                key: D1SessionBookmark * options: R2Bucket.Get.Options -> Promise<option<U2<R2Object, R2ObjectBody>>>

            abstract head: key: D1SessionBookmark -> Promise<option<R2Object>>

        [<Import("@cloudflare/workers-types", "AiModelsSearchObject")>]
        type AiModelsSearchObject =
            abstract properties: Array<AiModelsSearchObject.Properties> with get, set
            abstract tags: Array<D1SessionBookmark> with get, set
            abstract task: AiModelsSearchObject.Task with get, set
            abstract description: D1SessionBookmark with get, set
            abstract name: D1SessionBookmark with get, set
            abstract source: float with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "D1Result")>]
        type D1Result<'T> =
            abstract results: Array<'T> with get, set
            abstract error: option<unit> with get, set
            abstract meta: D1Result.Meta with get, set
            abstract success: D1Result.Success with get, set

        [<Import("@cloudflare/workers-types", "ResponseReasoningItem")>]
        type ResponseReasoningItem =
            abstract status: option<ResponseReasoningItem.Status> with get, set

            [<CompiledName("encrypted_content")>]
            abstract encryptedContent: option<D1SessionBookmark> with get, set

            abstract content: option<Array<ResponseReasoningContentItem>> with get, set

            [<CompiledName("type")>]
            abstract ``type``: ResponseReasoningItem.Type with get, set

            abstract summary: Array<ResponseReasoningSummaryItem> with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ContentOptions")>]
        type ContentOptions =
            abstract html: option<bool> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type VectorizeMetadataRetrievalLevel =
            | [<CompiledName("all")>] All
            | [<CompiledName("indexed")>] Indexed
            | [<CompiledName("none")>] None

        [<Import("@cloudflare/workers-types", "Ai_Cf_Deepgram_Flux_Output")>]
        type AiCfDeepgramFluxOutput =
            [<CompiledName("end_of_turn_confidence")>]
            abstract endOfTurnConfidence: option<float> with get, set

            abstract words: option<Array<AiCfDeepgramFluxOutput.Words>> with get, set
            abstract transcript: option<D1SessionBookmark> with get, set

            [<CompiledName("audio_window_end")>]
            abstract audioWindowEnd: option<float> with get, set

            [<CompiledName("audio_window_start")>]
            abstract audioWindowStart: option<float> with get, set

            [<CompiledName("turn_index")>]
            abstract turnIndex: option<float> with get, set

            abstract event: option<AiCfDeepgramFluxOutput.Event> with get, set

            [<CompiledName("sequence_id")>]
            abstract sequenceId: option<float> with get, set

            [<CompiledName("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwq_32B_Prompt")>]
        type AiCfQwenQwq32BPrompt =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "CachePurgeError")>]
        type CachePurgeError =
            abstract message: D1SessionBookmark with get, set
            abstract code: float with get, set

        [<Import("@cloudflare/workers-types", "SqlStorageStatement")>]
        type SqlStorageStatement = interface end

        [<Import("@cloudflare/workers-types", "AIGatewayHeaders")>]
        type AIGatewayHeaders =
            [<CompiledName("Content-Type")>]
            abstract contentType: D1SessionBookmark with get, set

            [<CompiledName("Authorization")>]
            abstract authorization: D1SessionBookmark with get, set

            [<CompiledName("cf-aig-collect-log")>]
            abstract cfAigCollectLog: U2<bool, D1SessionBookmark> with get, set

            [<CompiledName("cf-aig-backoff")>]
            abstract cfAigBackoff: D1SessionBookmark with get, set

            [<CompiledName("cf-aig-retry-delay")>]
            abstract cfAigRetryDelay: U2<float, D1SessionBookmark> with get, set

            [<CompiledName("cf-aig-max-attempts")>]
            abstract cfAigMaxAttempts: U2<float, D1SessionBookmark> with get, set

            [<CompiledName("cf-aig-request-timeout")>]
            abstract cfAigRequestTimeout: U2<float, D1SessionBookmark> with get, set

            [<CompiledName("cf-aig-event-id")>]
            abstract cfAigEventId: D1SessionBookmark with get, set

            [<CompiledName("cf-aig-cache-key")>]
            abstract cfAigCacheKey: D1SessionBookmark with get, set

            [<CompiledName("cf-aig-skip-cache")>]
            abstract cfAigSkipCache: U2<bool, D1SessionBookmark> with get, set

            [<CompiledName("cf-aig-cache-ttl")>]
            abstract cfAigCacheTtl: U2<float, D1SessionBookmark> with get, set

            [<CompiledName("cf-aig-custom-cost")>]
            abstract cfAigCustomCost:
                U3<AIGatewayHeaders.CfAigCustomCost, AIGatewayHeaders.CfAigCustomCost, D1SessionBookmark> with get, set

            [<CompiledName("cf-aig-metadata")>]
            abstract cfAigMetadata: U2<AIGatewayHeaders.CfAigMetadata, D1SessionBookmark> with get, set

            abstract Item:
                key: D1SessionBookmark -> U4<AIGatewayHeaders.AIGatewayHeaders, D1SessionBookmark, float, obj>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type DurableObjectJurisdiction =
            | [<CompiledName("eu")>] Eu
            | [<CompiledName("fedramp")>] Fedramp
            | [<CompiledName("fedramp-high")>] FedrampHigh

        type AiCfBaaiBgeBaseEnV15Output = U2<AiCfBaaiBgeBaseEnV15Output, AiCfBaaiBgeBaseEnV15AsyncResponse>

        type LoopbackForExport =
            abstract props: option<obj> with get, set
            abstract props: option<'Props> with get, set
            abstract connect: address: U2<SocketAddress, D1SessionBookmark> * ?options: SocketOptions -> Socket

            abstract fetch:
                input:
                    U3<
                        Typescript.Request<option<obj>, U2<RequestInitCfProperties, LoopbackForExport.Fetch.Input>>,
                        URL,
                        D1SessionBookmark
                     > *
                ?init: Typescript.RequestInit<U2<RequestInitCfProperties, LoopbackForExport.Fetch.Init>> ->
                    Promise<Typescript.Response>

            abstract Invoke: opts: LoopbackForExport.LoopbackForExport.Opts -> LoopbackForExport.LoopbackForExport
            abstract Invoke: opts: LoopbackForExport.LoopbackForExport.Opts -> DurableObjectClass<'T>
            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke:
                [<ParamArray>] args: LoopbackForExport.LoopbackForExport.Args ->
                    U2<LoopbackForExport.LoopbackForExport, U2<LoopbackForExport.LoopbackForExport, unit>>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_M2M100_1_2B_AsyncResponse")>]
        type AiCfMetaM2M10012BAsyncResponse =
            [<CompiledName("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        type SqlStorageValue = option<U3<ArrayBuffer, D1SessionBookmark, float>>

        [<Import("@cloudflare/workers-types", "AiTextGenerationInput")>]
        type AiTextGenerationInput =
            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract tools: option<U3<Array<AiTextGenerationToolInput>, Array<AiTextGenerationToolLegacyInput>, obj>> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiTextGenerationResponseFormat> with get, set

            abstract messages: option<Array<RoleScopedChatInput>> with get, set

            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set
            abstract prompt: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "CustomEvent")>]
        type CustomEvent<'T> =
            [<EmitConstructor>]
            abstract Create: ``type``: D1SessionBookmark * ?init: CustomEventCustomEventInit -> CustomEvent

            inherit Event
            abstract detail: 'T with get

        [<Import("@cloudflare/workers-types", "CryptoKeyArbitraryKeyAlgorithm")>]
        type CryptoKeyArbitraryKeyAlgorithm =
            abstract length: option<float> with get, set
            abstract namedCurve: option<D1SessionBookmark> with get, set
            abstract hash: option<CryptoKeyKeyAlgorithm> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectNamespace")>]
        type DurableObjectNamespace<'T when 'T :> Rpc.DurableObjectBranded> =
            abstract jurisdiction: jurisdiction: DurableObjectJurisdiction -> DurableObjectNamespace

            abstract getByName:
                name: D1SessionBookmark * ?options: DurableObjectNamespaceGetDurableObjectOptions ->
                    DurableObjectNamespace.GetByName

            abstract get:
                id: DurableObjectId * ?options: DurableObjectNamespaceGetDurableObjectOptions ->
                    DurableObjectNamespace.Get

            abstract idFromString: id: D1SessionBookmark -> DurableObjectId
            abstract idFromName: name: D1SessionBookmark -> DurableObjectId
            abstract newUniqueId: ?options: DurableObjectNamespaceNewUniqueIdOptions -> DurableObjectId

        type BufferSource = U2<ArrayBufferView<ArrayBufferLike>, ArrayBuffer>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Zai_Org_Glm_4_7_Flash")>]
        type BaseAiCfZaiOrgGlm47Flash =
            abstract postProcessedOutputs: ChatCompletionsOutput with get, set

            abstract inputs:
                U3<BaseAiCfZaiOrgGlm47Flash.Inputs, BaseAiCfZaiOrgGlm47Flash.Inputs, BaseAiCfZaiOrgGlm47Flash.Inputs> with get, set

        type TypedArray =
            U11<
                Int8Array<ArrayBufferLike>,
                Uint8Array<ArrayBufferLike>,
                Uint8ClampedArray<ArrayBufferLike>,
                Int16Array<ArrayBufferLike>,
                Uint16Array<ArrayBufferLike>,
                Int32Array<ArrayBufferLike>,
                Uint32Array<ArrayBufferLike>,
                Float32Array<ArrayBufferLike>,
                Float64Array<ArrayBufferLike>,
                BigInt64Array<ArrayBufferLike>,
                BigUint64Array<ArrayBufferLike>
             >

        [<Import("@cloudflare/workers-types", "ResponseFormatTextJSONSchemaConfig")>]
        type ResponseFormatTextJSONSchemaConfig =
            abstract strict: option<bool> with get, set
            abstract description: option<D1SessionBookmark> with get, set

            [<CompiledName("type")>]
            abstract ``type``: ResponseFormatTextJSONSchemaConfig.Type with get, set

            abstract schema: ResponseFormatTextJSONSchemaConfig.Schema with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "WritableStream")>]
        type WritableStream<'W> =
            [<EmitConstructor>]
            abstract Create:
                ?underlyingSink: Typescript.UnderlyingSink<option<obj>> *
                ?queuingStrategy: Typescript.QueuingStrategy<option<obj>> ->
                    WritableStream

            abstract locked: bool with get
            abstract getWriter: unit -> WritableStreamDefaultWriter<'W>
            abstract close: unit -> Promise<unit>
            abstract abort: ?reason: obj -> Promise<unit>

        [<Import("@cloudflare/workers-types", "AiGatewayInternalError")>]
        type AiGatewayInternalError =
            interface
                inherit Error
            end

        [<Import("@cloudflare/workers-types", "AiModelsSearchParams")>]
        type AiModelsSearchParams =
            abstract task: option<D1SessionBookmark> with get, set
            abstract source: option<float> with get, set
            abstract search: option<D1SessionBookmark> with get, set

            [<CompiledName("per_page")>]
            abstract perPage: option<float> with get, set

            abstract page: option<float> with get, set

            [<CompiledName("hide_experimental")>]
            abstract hideExperimental: option<bool> with get, set

            abstract author: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode_1")>]
        type AiCfMetaLlama3370BInstructFp8FastJSONMode1 =
            [<CompiledName("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<AiCfMetaLlama3370BInstructFp8FastJSONMode1.Type> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct")>]
        type BaseAiCfMistralaiMistralSmall3124BInstruct =
            abstract postProcessedOutputs: AiCfMistralaiMistralSmall3124BInstructOutput with get, set
            abstract inputs: AiCfMistralaiMistralSmall3124BInstructInput with get, set

        [<Import("@cloudflare/workers-types", "AiSearchListInstancesParams")>]
        type AiSearchListInstancesParams =
            [<CompiledName("order_by_direction")>]
            abstract orderByDirection: option<AiSearchListInstancesParams.OrderByDirection> with get, set

            [<CompiledName("order_by")>]
            abstract orderBy: option<AiSearchListInstancesParams.OrderBy> with get, set

            abstract search: option<D1SessionBookmark> with get, set

            [<CompiledName("per_page")>]
            abstract perPage: option<float> with get, set

            abstract page: option<float> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchNotFoundError")>]
        type AiSearchNotFoundError =
            interface
                inherit Error
            end

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_3")>]
        type AiCfQwenQwen330BA3BFp8JSONMode3 =
            [<CompiledName("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<AiCfQwenQwen330BA3BFp8JSONMode3.Type> with get, set

        [<Import("@cloudflare/workers-types", "ResponseIncompleteDetails")>]
        type ResponseIncompleteDetails =
            abstract reason: option<ResponseIncompleteDetails.Reason> with get, set

        [<Import("@cloudflare/workers-types", "ResponseIncompleteEvent")>]
        type ResponseIncompleteEvent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseIncompleteEvent.Type with get, set

            [<CompiledName("sequence_number")>]
            abstract sequenceNumber: float with get, set

            abstract response: Typescript.Response with get, set

        [<Import("@cloudflare/workers-types", "VectorizeError")>]
        type VectorizeError =
            abstract error: D1SessionBookmark with get, set
            abstract code: option<float> with get, set

        type AiCfBaaiBgeLargeEnV15Input = U2<AiCfBaaiBgeLargeEnV15Input, AiCfBaaiBgeLargeEnV15Input>

        [<Import("@cloudflare/workers-types", "ToolChoiceFunction")>]
        type ToolChoiceFunction =
            [<CompiledName("type")>]
            abstract ``type``: ToolChoiceFunction.Type with get, set

            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "MediaTransformationOutputOptions")>]
        type MediaTransformationOutputOptions =
            abstract format: option<MediaTransformationOutputOptions.Format> with get, set
            abstract imageCount: option<float> with get, set
            abstract duration: option<D1SessionBookmark> with get, set
            abstract time: option<D1SessionBookmark> with get, set
            abstract audio: option<bool> with get, set
            abstract mode: option<MediaTransformationOutputOptions.Mode> with get, set

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesBotManagement")>]
        type IncomingRequestCfPropertiesBotManagement =
            /// <deprecated />
            abstract clientTrustScore: float with get, set
            abstract botManagement: IncomingRequestCfPropertiesBotManagementBase with get, set

        [<Import("@cloudflare/workers-types", "ExportedHandlerConnectHandler")>]
        type ExportedHandlerConnectHandler<'Props, 'Env> =
            abstract Invoke: socket: Socket * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "TraceItemScheduledEventInfo")>]
        type TraceItemScheduledEventInfo =
            abstract cron: D1SessionBookmark with get
            abstract scheduledTime: float with get

        [<Import("@cloudflare/workers-types", "AiSearchInstance")>]
        type AiSearchInstance =
            abstract jobs: AiSearchJobs with get
            abstract items: AiSearchItems with get
            abstract stats: unit -> Promise<AiSearchStatsResponse>
            abstract info: unit -> Promise<AiSearchInstanceInfo>
            abstract update: config: AiSearchInstance.Update.Config -> Promise<AiSearchInstanceInfo>
            abstract chatCompletions: params: AiSearchChatCompletionsRequest -> Promise<AiSearchChatCompletionsResponse>

            abstract chatCompletions:
                params: AiSearchInstance.ChatCompletions.Params -> Promise<ReadableStream<option<obj>>>

            abstract search: params: AiSearchSearchRequest -> Promise<AiSearchSearchResponse>

        [<Import("@cloudflare/workers-types", "ChatCompletionChoice")>]
        type ChatCompletionChoice =
            abstract logprobs: option<ChatCompletionLogprobs> with get, set

            [<CompiledName("finish_reason")>]
            abstract finishReason: ChatCompletionChoice.FinishReason with get, set

            abstract message: ChatCompletionResponseMessage with get, set
            abstract index: float with get, set

        [<Import("@cloudflare/workers-types", "StreamScopedDownloads")>]
        type StreamScopedDownloads =
            abstract delete: ?downloadType: StreamDownloadType -> Promise<unit>
            abstract get: unit -> Promise<StreamDownloadGetResponse>
            abstract generate: ?downloadType: StreamDownloadType -> Promise<StreamDownloadGetResponse>

        [<Import("@cloudflare/workers-types", "SubtleCrypto")>]
        type SubtleCrypto =
            abstract timingSafeEqual:
                a: U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>> *
                b: U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>> ->
                    bool

            abstract unwrapKey:
                format: D1SessionBookmark *
                wrappedKey: U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>> *
                unwrappingKey: CryptoKey *
                unwrapAlgorithm: U2<SubtleCryptoEncryptAlgorithm, D1SessionBookmark> *
                unwrappedKeyAlgorithm: U2<SubtleCryptoImportKeyAlgorithm, D1SessionBookmark> *
                extractable: bool *
                keyUsages: Array<D1SessionBookmark> ->
                    Promise<CryptoKey>

            abstract wrapKey:
                format: D1SessionBookmark *
                key: CryptoKey *
                wrappingKey: CryptoKey *
                wrapAlgorithm: U2<SubtleCryptoEncryptAlgorithm, D1SessionBookmark> ->
                    Promise<ArrayBuffer>

            abstract exportKey:
                format: D1SessionBookmark * key: CryptoKey -> Promise<U2<ArrayBuffer, Typescript.JsonWebKey>>

            abstract importKey:
                format: D1SessionBookmark *
                keyData: U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, Typescript.JsonWebKey> *
                algorithm: U2<SubtleCryptoImportKeyAlgorithm, D1SessionBookmark> *
                extractable: bool *
                keyUsages: Array<D1SessionBookmark> ->
                    Promise<CryptoKey>

            abstract deriveBits:
                algorithm: U2<SubtleCryptoDeriveKeyAlgorithm, D1SessionBookmark> * baseKey: CryptoKey * ?length: float ->
                    Promise<ArrayBuffer>

            abstract deriveKey:
                algorithm: U2<SubtleCryptoDeriveKeyAlgorithm, D1SessionBookmark> *
                baseKey: CryptoKey *
                derivedKeyAlgorithm: U2<SubtleCryptoImportKeyAlgorithm, D1SessionBookmark> *
                extractable: bool *
                keyUsages: Array<D1SessionBookmark> ->
                    Promise<CryptoKey>

            abstract generateKey:
                algorithm: U2<SubtleCryptoGenerateKeyAlgorithm, D1SessionBookmark> *
                extractable: bool *
                keyUsages: Array<D1SessionBookmark> ->
                    Promise<U2<CryptoKey, Typescript.CryptoKeyPair>>

            abstract digest:
                algorithm: U2<SubtleCryptoHashAlgorithm, D1SessionBookmark> *
                data: U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>> ->
                    Promise<ArrayBuffer>

            abstract verify:
                algorithm: U2<SubtleCryptoSignAlgorithm, D1SessionBookmark> *
                key: CryptoKey *
                signature: U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>> *
                data: U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>> ->
                    Promise<bool>

            abstract sign:
                algorithm: U2<SubtleCryptoSignAlgorithm, D1SessionBookmark> *
                key: CryptoKey *
                data: U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>> ->
                    Promise<ArrayBuffer>

            abstract decrypt:
                algorithm: U2<SubtleCryptoEncryptAlgorithm, D1SessionBookmark> *
                key: CryptoKey *
                cipherText: U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>> ->
                    Promise<ArrayBuffer>

            abstract encrypt:
                algorithm: U2<SubtleCryptoEncryptAlgorithm, D1SessionBookmark> *
                key: CryptoKey *
                plainText: U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>> ->
                    Promise<ArrayBuffer>

        [<Import("@cloudflare/workers-types", "Queue")>]
        type Queue<'Body> =
            abstract sendBatch:
                messages: Iterable<MessageSendRequest<'Body>, option<obj>, option<obj>> *
                ?options: QueueSendBatchOptions ->
                    Promise<QueueSendBatchResponse>

            abstract send: message: 'Body * ?options: QueueSendOptions -> Promise<QueueSendResponse>
            abstract metrics: unit -> Promise<QueueMetrics>

        [<Import("@cloudflare/workers-types", "ChatCompletionToolChoiceCustom")>]
        type ChatCompletionToolChoiceCustom =
            abstract custom: ChatCompletionToolChoiceCustom.Custom with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionToolChoiceCustom.Type with get, set

        type Atob =
            abstract Invoke: data: D1SessionBookmark -> D1SessionBookmark
            abstract Invoke: data: D1SessionBookmark -> D1SessionBookmark

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Prompt")>]
        type AiCfQwenQwen330BA3BFp8Prompt =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfQwenQwen330BA3BFp8JSONMode> with get, set

            abstract lora: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "SqlStorage")>]
        type SqlStorage =
            [<CompiledName("Statement")>]
            abstract statement: SqlStorage.Statement with get, set

            [<CompiledName("Cursor")>]
            abstract cursor: SqlStorage.Cursor with get, set

            abstract databaseSize: float with get

            abstract exec:
                query: D1SessionBookmark * [<ParamArray>] bindings: Array<option<obj>> -> SqlStorageCursor<'T>

        [<Import("@cloudflare/workers-types", "ResponseErrorEvent")>]
        type ResponseErrorEvent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseErrorEvent.Type with get, set

            [<CompiledName("sequence_number")>]
            abstract sequenceNumber: float with get, set

            abstract param: option<D1SessionBookmark> with get, set
            abstract message: D1SessionBookmark with get, set
            abstract code: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ReadableStreamBYOBReader")>]
        type ReadableStreamBYOBReader =
            [<EmitConstructor>]
            abstract Create: stream: ReadableStream<option<obj>> -> ReadableStreamBYOBReader

            abstract closed: Promise<unit> with get

            abstract readAtLeast:
                minElements: float * view: 'T ->
                    Promise<U2<ReadableStreamReadValueResult<'T>, ReadableStreamReadDoneResult<'T>>>

            abstract releaseLock: unit -> unit
            abstract read: view: 'T -> Promise<U2<ReadableStreamReadValueResult<'T>, ReadableStreamReadDoneResult<'T>>>
            abstract cancel: ?reason: obj -> Promise<unit>

        [<Import("@cloudflare/workers-types", "ResponseFunctionToolCall")>]
        type ResponseFunctionToolCall =
            abstract status: option<ResponseFunctionToolCall.Status> with get, set
            abstract id: option<D1SessionBookmark> with get, set

            [<CompiledName("type")>]
            abstract ``type``: ResponseFunctionToolCall.Type with get, set

            abstract name: D1SessionBookmark with get, set

            [<CompiledName("call_id")>]
            abstract callId: D1SessionBookmark with get, set

            abstract arguments: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiSummarizationInput")>]
        type AiSummarizationInput =
            [<CompiledName("max_length")>]
            abstract maxLength: option<float> with get, set

            [<CompiledName("input_text")>]
            abstract inputText: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_AsyncResponse")>]
        type AiCfBaaiBgeM3AsyncResponse =
            [<CompiledName("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        type CfProperties<'HostMetadata> = U2<CfProperties, RequestInitCfProperties>

        [<Import("@cloudflare/workers-types", "WorkerStub")>]
        type WorkerStub =
            abstract getDurableObjectClass:
                ?name: D1SessionBookmark * ?options: WorkerStubEntrypointOptions -> DurableObjectClass<'T>

            abstract getEntrypoint:
                ?name: D1SessionBookmark * ?options: WorkerStubEntrypointOptions -> WorkerStub.GetEntrypoint

        [<Import("@cloudflare/workers-types", "Ai_Cf_Google_Gemma_3_12B_It_Prompt")>]
        type AiCfGoogleGemma312BItPrompt =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "TextDecoder")>]
        type TextDecoder =
            [<EmitConstructor>]
            abstract Create: ?label: D1SessionBookmark * ?options: TextDecoderConstructorOptions -> TextDecoder

            abstract ignoreBOM: bool with get
            abstract fatal: bool with get
            abstract encoding: D1SessionBookmark with get

            abstract decode:
                ?input: U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>> * ?options: TextDecoderDecodeOptions ->
                    D1SessionBookmark

        [<Import("@cloudflare/workers-types", "QueueSendBatchResponse")>]
        type QueueSendBatchResponse =
            abstract metadata: QueueSendBatchMetadata with get, set

        [<Import("@cloudflare/workers-types", "ArtifactsRepoListResult")>]
        type ArtifactsRepoListResult =
            abstract cursor: option<D1SessionBookmark> with get, set
            abstract total: float with get, set
            abstract repos: Array<ArtifactsRepoListResult.Repos> with get, set

        [<Import("@cloudflare/workers-types", "ScheduledController")>]
        type ScheduledController =
            abstract cron: D1SessionBookmark with get
            abstract scheduledTime: float with get
            abstract noRetry: unit -> unit

        [<Import("@cloudflare/workers-types", "AiSearchStatsResponse")>]
        type AiSearchStatsResponse =
            abstract engine: option<AiSearchStatsResponse.Engine> with get, set

            [<CompiledName("last_activity")>]
            abstract lastActivity: option<D1SessionBookmark> with get, set

            abstract outdated: option<float> with get, set
            abstract skipped: option<float> with get, set
            abstract error: option<float> with get, set
            abstract completed: option<float> with get, set
            abstract running: option<float> with get, set
            abstract queued: option<float> with get, set

        [<Import("@cloudflare/workers-types", "StreamOptions")>]
        type StreamOptions =
            [<CompiledName("include_obfuscation")>]
            abstract includeObfuscation: option<bool> with get, set

        type ChatCompletionContentPart =
            abstract filename: option<D1SessionBookmark> with get, set

            [<CompiledName("file_id")>]
            abstract fileId: option<D1SessionBookmark> with get, set

            [<CompiledName("file_data")>]
            abstract fileData: option<D1SessionBookmark> with get, set

            abstract file: ChatCompletionContentPart.File with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionContentPart.Type with get, set

            abstract format: ChatCompletionContentPart.Format with get, set
            abstract data: D1SessionBookmark with get, set

            [<CompiledName("input_audio")>]
            abstract inputAudio: ChatCompletionContentPart.InputAudio with get, set

            abstract detail: option<ChatCompletionContentPart.Detail> with get, set
            abstract url: D1SessionBookmark with get, set

            [<CompiledName("image_url")>]
            abstract imageUrl: ChatCompletionContentPart.ImageUrl with get, set

            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionMessageFunctionToolCall")>]
        type ChatCompletionMessageFunctionToolCall =
            [<CompiledName("function")>]
            abstract ``function``: ChatCompletionMessageFunctionToolCall.Function with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionMessageFunctionToolCall.Type with get, set

            abstract id: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type D1SessionConstraint =
            | [<CompiledName("first-primary")>] FirstPrimary
            | [<CompiledName("first-unconstrained")>] FirstUnconstrained

        [<Import("@cloudflare/workers-types", "Message")>]
        type Message<'Body> =
            abstract attempts: float with get
            abstract body: 'Body with get
            abstract timestamp: Date with get
            abstract id: D1SessionBookmark with get
            abstract ack: unit -> unit
            abstract retry: ?options: QueueRetryOptions -> unit

        type AiCfAisingaporeGemmaSeaLionV427BItOutput =
            U4<
                AiCfAisingaporeGemmaSeaLionV427BItChatCompletionResponse,
                AiCfAisingaporeGemmaSeaLionV427BItTextCompletionResponse,
                AiCfAisingaporeGemmaSeaLionV427BItAsyncResponse,
                D1SessionBookmark
             >

        [<Import("@cloudflare/workers-types", "AiIMultimodalEmbeddingsOutput")>]
        type AiIMultimodalEmbeddingsOutput =
            abstract shape: AiSentenceSimilarityOutput with get, set
            abstract data: Array<AiSentenceSimilarityOutput> with get, set

        [<Import("@cloudflare/workers-types", "FormData")>]
        type FormData =
            [<EmitConstructor>]
            abstract Create: unit -> FormData

            abstract ``[symbol.iterator]``:
                unit -> IterableIterator<D1SessionBookmark * D1SessionBookmark, option<obj>, option<obj>>

            abstract forEach: callback: FormData.ForEach.Callback * ?thisArg: 'This -> unit
            abstract values: unit -> IterableIterator<U2<File, D1SessionBookmark>, option<obj>, option<obj>>
            abstract keys: unit -> IterableIterator<D1SessionBookmark, option<obj>, option<obj>>
            abstract entries: unit -> IterableIterator<D1SessionBookmark * D1SessionBookmark, option<obj>, option<obj>>
            abstract set: name: D1SessionBookmark * value: Blob * ?filename: D1SessionBookmark -> unit
            abstract set: name: D1SessionBookmark * value: D1SessionBookmark -> unit
            abstract set: name: D1SessionBookmark * value: U2<Blob, D1SessionBookmark> -> unit
            abstract has: name: D1SessionBookmark -> bool
            abstract getAll: name: D1SessionBookmark -> Array<D1SessionBookmark>
            abstract get: name: D1SessionBookmark -> option<D1SessionBookmark>
            abstract delete: name: D1SessionBookmark -> unit
            abstract append: name: D1SessionBookmark * value: Blob * ?filename: D1SessionBookmark -> unit
            abstract append: name: D1SessionBookmark * value: D1SessionBookmark -> unit
            abstract append: name: D1SessionBookmark * value: U2<Blob, D1SessionBookmark> -> unit

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B")>]
        type BaseAiCfAi4BharatIndictrans2EnIndic1B =
            abstract postProcessedOutputs: AiCfAi4BharatIndictrans2EnIndic1BOutput with get, set
            abstract inputs: AiCfAi4BharatIndictrans2EnIndic1BInput with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Deepgram_Flux")>]
        type BaseAiCfDeepgramFlux =
            abstract postProcessedOutputs: AiCfDeepgramFluxOutput with get, set
            abstract inputs: AiCfDeepgramFluxInput with get, set

        [<Import("@cloudflare/workers-types", "ResponseOutputRefusal")>]
        type ResponseOutputRefusal =
            [<CompiledName("type")>]
            abstract ``type``: ResponseOutputRefusal.Type with get, set

            abstract refusal: D1SessionBookmark with get, set

        type AiModelListType =
            abstract Item: key: D1SessionBookmark -> option<obj>

        type ChatCompletionToolChoiceOption =
            abstract tools: Array<ChatCompletionToolChoiceOption.Tools> with get, set
            abstract mode: ChatCompletionToolChoiceOption.Mode with get, set

            [<CompiledName("allowed_tools")>]
            abstract allowedTools: ChatCompletionToolChoiceOption.AllowedTools with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionToolChoiceOption.Type with get, set

            abstract custom: ChatCompletionToolChoiceOption.Custom with get, set
            abstract name: D1SessionBookmark with get, set

            [<CompiledName("function")>]
            abstract ``function``: ChatCompletionToolChoiceOption.Function with get, set

            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "DurableObjectStub")>]
        type DurableObjectStub<'T when 'T :> Rpc.DurableObjectBranded> =
            abstract name: option<D1SessionBookmark> with get
            abstract id: DurableObjectId with get
            abstract connect: address: U2<SocketAddress, D1SessionBookmark> * ?options: SocketOptions -> Socket

            abstract fetch:
                input:
                    U3<
                        Typescript.Request<option<obj>, U2<RequestInitCfProperties, DurableObjectStub.Fetch.Input>>,
                        URL,
                        D1SessionBookmark
                     > *
                ?init: Typescript.RequestInit<U2<RequestInitCfProperties, DurableObjectStub.Fetch.Init>> ->
                    Promise<Typescript.Response>

            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke:
                [<ParamArray>] args: DurableObjectStub.DurableObjectStub.Args ->
                    U2<DurableObjectStub.DurableObjectStub, U2<DurableObjectStub.DurableObjectStub, unit>>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Black_Forest_Labs_Flux_2_Dev")>]
        type BaseAiCfBlackForestLabsFlux2Dev =
            abstract postProcessedOutputs: AiCfBlackForestLabsFlux2DevOutput with get, set
            abstract inputs: AiCfBlackForestLabsFlux2DevInput with get, set

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesCloudflareForSaaSEnterprise")>]
        type IncomingRequestCfPropertiesCloudflareForSaaSEnterprise<'HostMetadata> =
            abstract hostMetadata: option<'HostMetadata> with get, set

        [<Import("@cloudflare/workers-types", "StreamUpdateVideoParams")>]
        type StreamUpdateVideoParams =
            abstract thumbnailTimestampPct: option<float> with get, set
            abstract scheduledDeletion: option<D1SessionBookmark> with get, set
            abstract requireSignedURLs: option<bool> with get, set
            abstract meta: option<StreamUpdateVideoParams.Meta> with get, set
            abstract maxDurationSeconds: option<float> with get, set
            abstract creator: option<D1SessionBookmark> with get, set
            abstract allowedOrigins: option<Array<D1SessionBookmark>> with get, set

        [<Import("@cloudflare/workers-types", "JsonWebKeyWithKid")>]
        type JsonWebKeyWithKid =
            inherit Typescript.JsonWebKey
            abstract kid: D1SessionBookmark with get

        type AiCfQwenQwen330BA3BFp8Input =
            U3<AiCfQwenQwen330BA3BFp8Prompt, AiCfQwenQwen330BA3BFp8Messages, AiCfQwenQwen330BA3BFp8AsyncBatch>

        [<Import("@cloudflare/workers-types", "SystemMessage")>]
        type SystemMessage =
            abstract name: option<D1SessionBookmark> with get, set
            abstract content: U2<Array<ChatCompletionContentPartText>, D1SessionBookmark> with get, set
            abstract role: SystemMessage.Role with get, set

        [<Import("@cloudflare/workers-types", "ResponseUsage")>]
        type ResponseUsage =
            [<CompiledName("total_tokens")>]
            abstract totalTokens: float with get, set

            [<CompiledName("output_tokens")>]
            abstract outputTokens: float with get, set

            [<CompiledName("input_tokens")>]
            abstract inputTokens: float with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Openai_Gpt_Oss_20B")>]
        type BaseAiCfOpenaiGptOss20B =
            abstract postProcessedOutputs:
                U2<BaseAiCfOpenaiGptOss20B.PostProcessedOutputs, BaseAiCfOpenaiGptOss20B.PostProcessedOutputs> with get, set

            abstract inputs:
                U4<
                    BaseAiCfOpenaiGptOss20B.Inputs,
                    BaseAiCfOpenaiGptOss20B.Inputs,
                    BaseAiCfOpenaiGptOss20B.Inputs,
                    BaseAiCfOpenaiGptOss20B.Inputs
                 > with get, set

        [<Import("@cloudflare/workers-types", "SubtleCryptoImportKeyAlgorithm")>]
        type SubtleCryptoImportKeyAlgorithm =
            abstract compressed: option<bool> with get, set
            abstract namedCurve: option<D1SessionBookmark> with get, set
            abstract length: option<float> with get, set
            abstract hash: option<U2<SubtleCryptoHashAlgorithm, D1SessionBookmark>> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "StreamDirectUploadCreateParams")>]
        type StreamDirectUploadCreateParams =
            abstract watermark: option<StreamDirectUploadWatermark> with get, set
            abstract scheduledDeletion: option<D1SessionBookmark> with get, set
            abstract thumbnailTimestampPct: option<float> with get, set
            abstract requireSignedURLs: option<bool> with get, set
            abstract allowedOrigins: option<Array<D1SessionBookmark>> with get, set
            abstract meta: option<StreamDirectUploadCreateParams.Meta> with get, set
            abstract creator: option<D1SessionBookmark> with get, set
            abstract expiry: option<D1SessionBookmark> with get, set
            abstract maxDurationSeconds: float with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Google_Gemma_3_12B_It")>]
        type BaseAiCfGoogleGemma312BIt =
            abstract postProcessedOutputs: AiCfGoogleGemma312BItOutput with get, set
            abstract inputs: AiCfGoogleGemma312BItInput with get, set

        [<Import("@cloudflare/workers-types", "MessageBatchMetadata")>]
        type MessageBatchMetadata =
            abstract metrics: MessageBatchMetrics with get, set

        [<Import("@cloudflare/workers-types", "R2UploadedPart")>]
        type R2UploadedPart =
            abstract etag: D1SessionBookmark with get, set
            abstract partNumber: float with get, set

        [<Import("@cloudflare/workers-types", "EventPluginContext")>]
        type EventPluginContext<'PluginArgs, 'Data, 'P, 'Env when 'P :> D1SessionBookmark> =
            abstract pluginArgs: 'PluginArgs with get, set
            abstract data: 'Data with get, set
            abstract params: EventPluginContext.Params with get, set
            abstract env: EventPluginContext.Env with get, set
            abstract functionPath: D1SessionBookmark with get, set
            abstract request: Typescript.Request<option<obj>, EventPluginContext.Request> with get, set

            abstract next:
                ?input: RequestInfo *
                ?init: Typescript.RequestInit<U2<RequestInitCfProperties, EventPluginContext.Next.Init>> ->
                    Promise<Typescript.Response>

            abstract passThroughOnException: unit -> unit
            abstract waitUntil: promise: Promise<option<obj>> -> unit

        [<Import("@cloudflare/workers-types", "AiSearchInternalError")>]
        type AiSearchInternalError =
            interface
                inherit Error
            end

        [<Import("@cloudflare/workers-types", "AiSearchJobs")>]
        type AiSearchJobs =
            abstract get: jobId: D1SessionBookmark -> AiSearchJob
            abstract create: ?params: AiSearchCreateJobParams -> Promise<AiSearchJobInfo>
            abstract list: ?params: AiSearchListJobsParams -> Promise<AiSearchListJobsResponse>

        [<Import("@cloudflare/workers-types", "AiTextGenerationToolInput")>]
        type AiTextGenerationToolInput =
            [<CompiledName("function")>]
            abstract ``function``: AiTextGenerationToolInput.Function with get, set

            [<CompiledName("type")>]
            abstract ``type``: U2<AiTextGenerationToolInput.Type, AiTextGenerationToolInput.Type> with get, set

        [<Import("@cloudflare/workers-types", "StreamVideo")>]
        type StreamVideo =
            abstract publicDetails: option<StreamPublicDetails> with get, set
            abstract clippedFromId: option<D1SessionBookmark> with get, set
            abstract liveInputId: option<D1SessionBookmark> with get, set
            abstract watermark: option<StreamWatermark> with get, set
            abstract dashPlaybackUrl: D1SessionBookmark with get, set
            abstract hlsPlaybackUrl: D1SessionBookmark with get, set
            abstract input: StreamVideoInput with get, set
            abstract duration: float with get, set
            abstract maxDurationSeconds: option<float> with get, set
            abstract maxSizeBytes: option<float> with get, set
            abstract uploadExpiry: option<D1SessionBookmark> with get, set
            abstract uploaded: option<D1SessionBookmark> with get, set
            abstract requireSignedURLs: option<bool> with get, set
            abstract allowedOrigins: Array<D1SessionBookmark> with get, set
            abstract preview: option<D1SessionBookmark> with get, set
            abstract size: float with get, set
            abstract scheduledDeletion: option<D1SessionBookmark> with get, set
            abstract modified: D1SessionBookmark with get, set
            abstract created: D1SessionBookmark with get, set
            abstract meta: StreamVideo.Meta with get, set
            abstract status: StreamVideoStatus with get, set
            abstract readyToStreamAt: option<D1SessionBookmark> with get, set
            abstract readyToStream: bool with get, set
            abstract thumbnailTimestampPct: float with get, set
            abstract thumbnail: D1SessionBookmark with get, set
            abstract creator: option<D1SessionBookmark> with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectGetOptions")>]
        type DurableObjectGetOptions =
            abstract noCache: option<bool> with get, set
            abstract allowConcurrency: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages")>]
        type AiCfMistralaiMistralSmall3124BInstructMessages =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            abstract tools:
                option<
                    Array<
                        U2<
                            AiCfMistralaiMistralSmall3124BInstructMessages.Tools,
                            AiCfMistralaiMistralSmall3124BInstructMessages.Tools
                         >
                     >
                 > with get, set

            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: Array<AiCfMistralaiMistralSmall3124BInstructMessages.Messages> with get, set

        [<Import("@cloudflare/workers-types", "StreamVideoHandle")>]
        type StreamVideoHandle =
            abstract captions: StreamScopedCaptions with get, set
            abstract downloads: StreamScopedDownloads with get, set
            abstract id: D1SessionBookmark with get, set
            abstract generateToken: unit -> Promise<D1SessionBookmark>
            abstract delete: unit -> Promise<unit>
            abstract update: params: StreamUpdateVideoParams -> Promise<StreamVideo>
            abstract details: unit -> Promise<StreamVideo>

        [<Import("@cloudflare/workers-types", "AiGatewayLog")>]
        type AiGatewayLog =
            [<CompiledName("created_at")>]
            abstract createdAt: Date with get, set

            [<CompiledName("response_head_complete")>]
            abstract responseHeadComplete: bool with get, set

            [<CompiledName("response_head")>]
            abstract responseHead: option<D1SessionBookmark> with get, set

            [<CompiledName("response_size")>]
            abstract responseSize: float with get, set

            [<CompiledName("request_head_complete")>]
            abstract requestHeadComplete: bool with get, set

            [<CompiledName("request_head")>]
            abstract requestHead: option<D1SessionBookmark> with get, set

            [<CompiledName("request_size")>]
            abstract requestSize: float with get, set

            [<CompiledName("custom_cost")>]
            abstract customCost: option<bool> with get, set

            abstract cost: option<float> with get, set
            abstract step: option<float> with get, set
            abstract metadata: option<AiGatewayLog.Metadata> with get, set

            [<CompiledName("tokens_out")>]
            abstract tokensOut: option<float> with get, set

            [<CompiledName("tokens_in")>]
            abstract tokensIn: option<float> with get, set

            abstract cached: bool with get, set
            abstract success: bool with get, set

            [<CompiledName("response_content_type")>]
            abstract responseContentType: option<D1SessionBookmark> with get, set

            [<CompiledName("status_code")>]
            abstract statusCode: float with get, set

            [<CompiledName("request_content_type")>]
            abstract requestContentType: option<D1SessionBookmark> with get, set

            [<CompiledName("request_type")>]
            abstract requestType: option<D1SessionBookmark> with get, set

            abstract duration: float with get, set
            abstract path: D1SessionBookmark with get, set

            [<CompiledName("model_type")>]
            abstract modelType: option<D1SessionBookmark> with get, set

            abstract model: D1SessionBookmark with get, set
            abstract provider: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiSearchListItemsResponse")>]
        type AiSearchListItemsResponse =
            [<CompiledName("result_info")>]
            abstract resultInfo: option<AiSearchListItemsResponse.ResultInfo> with get, set

            abstract result: Array<AiSearchItemInfo> with get, set

        [<Import("@cloudflare/workers-types", "ContainerSnapshot")>]
        type ContainerSnapshot =
            abstract name: option<D1SessionBookmark> with get, set
            abstract size: float with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "MarkdownDocument")>]
        type MarkdownDocument =
            abstract blob: Blob with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "InternalError")>]
        type InternalError =
            inherit StreamError
            abstract name: InternalError.Name with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Output")>]
        type AiCfMetaLlama4Scout17B16EInstructOutput =
            [<CompiledName("tool_calls")>]
            abstract toolCalls: option<Array<AiCfMetaLlama4Scout17B16EInstructOutput.ToolCalls>> with get, set

            abstract usage: option<AiCfMetaLlama4Scout17B16EInstructOutput.Usage> with get, set
            abstract response: D1SessionBookmark with get, set

        type AiCfAisingaporeGemmaSeaLionV427BItInput =
            U3<
                AiCfAisingaporeGemmaSeaLionV427BItPrompt,
                AiCfAisingaporeGemmaSeaLionV427BItMessages,
                AiCfAisingaporeGemmaSeaLionV427BItAsyncBatch
             >

        type AiTextClassificationOutput = Array<AiTextClassificationOutput>

        [<Import("@cloudflare/workers-types", "QueueMetrics")>]
        type QueueMetrics =
            abstract oldestMessageTimestamp: option<Date> with get, set
            abstract backlogBytes: float with get, set
            abstract backlogCount: float with get, set

        [<Import("@cloudflare/workers-types", "CryptoKey")>]
        type CryptoKey =
            abstract usages: Array<D1SessionBookmark> with get

            abstract algorithm:
                U6<
                    CryptoKeyKeyAlgorithm,
                    CryptoKeyAesKeyAlgorithm,
                    CryptoKeyHmacKeyAlgorithm,
                    CryptoKeyRsaKeyAlgorithm,
                    CryptoKeyEllipticKeyAlgorithm,
                    CryptoKeyArbitraryKeyAlgorithm
                 > with get

            abstract extractable: bool with get

            [<CompiledName("type")>]
            abstract ``type``: D1SessionBookmark with get

        type AiObjectDetectionOutput = Array<AiObjectDetectionOutput>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Deepgram_Aura_2_En")>]
        type BaseAiCfDeepgramAura2En =
            abstract postProcessedOutputs: D1SessionBookmark with get, set
            abstract inputs: AiCfDeepgramAura2EnInput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_2")>]
        type AiCfAisingaporeGemmaSeaLionV427BItJSONMode2 =
            [<CompiledName("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<AiCfAisingaporeGemmaSeaLionV427BItJSONMode2.Type> with get, set

        type AiCfMistralaiMistralSmall3124BInstructInput =
            U2<AiCfMistralaiMistralSmall3124BInstructPrompt, AiCfMistralaiMistralSmall3124BInstructMessages>

        [<Import("@cloudflare/workers-types", "GatewayOptions")>]
        type GatewayOptions =
            abstract retries: option<GatewayRetries> with get, set
            abstract requestTimeoutMs: option<float> with get, set
            abstract eventId: option<D1SessionBookmark> with get, set
            abstract collectLog: option<bool> with get, set
            abstract metadata: option<GatewayOptions.Metadata> with get, set
            abstract skipCache: option<bool> with get, set
            abstract cacheTtl: option<float> with get, set
            abstract cacheKey: option<D1SessionBookmark> with get, set
            abstract id: D1SessionBookmark with get, set

        type AiCfMetaLlama3370BInstructFp8FastInput =
            U3<
                AiCfMetaLlama3370BInstructFp8FastPrompt,
                AiCfMetaLlama3370BInstructFp8FastMessages,
                AiCfMetaLlama3370BInstructFp8FastAsyncBatch
             >

        type FlagshipEvaluationContext = FlagshipEvaluationContext

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Prompt_1")>]
        type AiCfAisingaporeGemmaSeaLionV427BItPrompt1 =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfAisingaporeGemmaSeaLionV427BItJSONMode2> with get, set

            abstract lora: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionContentPartText")>]
        type ChatCompletionContentPartText =
            abstract text: D1SessionBookmark with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionContentPartText.Type with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionsOutput")>]
        type ChatCompletionsOutput =
            [<CompiledName("service_tier")>]
            abstract serviceTier: option<ChatCompletionsOutput.ServiceTier> with get, set

            [<CompiledName("system_fingerprint")>]
            abstract systemFingerprint: option<D1SessionBookmark> with get, set

            abstract usage: option<CompletionUsage> with get, set
            abstract choices: Array<ChatCompletionChoice> with get, set
            abstract model: D1SessionBookmark with get, set
            abstract created: float with get, set
            abstract object: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItemChunksParams")>]
        type AiSearchItemChunksParams =
            abstract offset: option<float> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "ExportedHandlerTraceHandler")>]
        type ExportedHandlerTraceHandler<'Props, 'Env> =
            abstract Invoke:
                traces: Array<TraceItem> * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "AiSearchMessage")>]
        type AiSearchMessage =
            abstract content: option<D1SessionBookmark> with get, set
            abstract role: AiSearchMessage.Role with get, set

        [<Import("@cloudflare/workers-types", "Fetcher")>]
        type Fetcher<'Reserved, 'T
            when 'Reserved :> D1SessionBookmark
            and 'T :> U3<Rpc.WorkerEntrypointBranded, Rpc.DurableObjectBranded, Rpc.WorkflowEntrypointBranded>> =
            abstract connect: address: U2<SocketAddress, D1SessionBookmark> * ?options: SocketOptions -> Socket

            abstract fetch:
                input:
                    U3<
                        Typescript.Request<option<obj>, U2<RequestInitCfProperties, Fetcher.Fetch.Input>>,
                        URL,
                        D1SessionBookmark
                     > *
                ?init: Typescript.RequestInit<U2<RequestInitCfProperties, Fetcher.Fetch.Init>> ->
                    Promise<Typescript.Response>

            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke: [<ParamArray>] args: Fetcher.Fetcher.Args -> U2<Fetcher.Fetcher, U2<Fetcher.Fetcher, unit>>

        [<Import("@cloudflare/workers-types", "FileOptions")>]
        type FileOptions =
            abstract lastModified: option<float> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "TraceItemCustomEventInfo")>]
        type TraceItemCustomEventInfo = interface end

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type __DURABLE_OBJECT_BRAND = | __DURABLE_OBJECT_BRAND

        [<Import("@cloudflare/workers-types", "Ai_Cf_Deepgram_Aura_2_En_Input")>]
        type AiCfDeepgramAura2EnInput =
            [<CompiledName("bit_rate")>]
            abstract bitRate: option<float> with get, set

            [<CompiledName("sample_rate")>]
            abstract sampleRate: option<float> with get, set

            abstract text: D1SessionBookmark with get, set
            abstract container: option<AiCfDeepgramAura2EnInput.Container> with get, set
            abstract encoding: option<AiCfDeepgramAura2EnInput.Encoding> with get, set
            abstract speaker: option<AiCfDeepgramAura2EnInput.Speaker> with get, set

        [<Import("@cloudflare/workers-types", "Vectorize")>]
        type Vectorize =
            abstract getByIds: ids: Array<D1SessionBookmark> -> Promise<Array<VectorizeVector>>
            abstract deleteByIds: ids: Array<D1SessionBookmark> -> Promise<VectorizeAsyncMutation>
            abstract upsert: vectors: Array<VectorizeVector> -> Promise<VectorizeAsyncMutation>
            abstract insert: vectors: Array<VectorizeVector> -> Promise<VectorizeAsyncMutation>

            abstract queryById:
                vectorId: D1SessionBookmark * ?options: VectorizeQueryOptions -> Promise<VectorizeMatches>

            abstract query:
                vector: U3<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>, AiSentenceSimilarityOutput> *
                ?options: VectorizeQueryOptions ->
                    Promise<VectorizeMatches>

            abstract describe: unit -> Promise<VectorizeIndexInfo>

        [<Import("@cloudflare/workers-types", "WebSearchUserLocation")>]
        type WebSearchUserLocation =
            abstract approximate: WebSearchUserLocation.Approximate with get, set

            [<CompiledName("type")>]
            abstract ``type``: WebSearchUserLocation.Type with get, set

        [<Import("@cloudflare/workers-types", "AiImageClassificationInput")>]
        type AiImageClassificationInput =
            abstract image: AiSentenceSimilarityOutput with get, set

        [<Import("@cloudflare/workers-types", "InferenceUpstreamError")>]
        type InferenceUpstreamError =
            interface
                inherit Error
            end

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ReadableStreamReadResult =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False

        [<Import("@cloudflare/workers-types", "CryptoKeyEllipticKeyAlgorithm")>]
        type CryptoKeyEllipticKeyAlgorithm =
            abstract namedCurve: D1SessionBookmark with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Without")>]
        type Without<'U, 'T> =
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_JSON_Mode")>]
        type AiCfQwenQwen25Coder32BInstructJSONMode =
            [<CompiledName("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<AiCfQwenQwen25Coder32BInstructJSONMode.Type> with get, set

        [<Import("@cloudflare/workers-types", "CryptoKeyRsaKeyAlgorithm")>]
        type CryptoKeyRsaKeyAlgorithm =
            abstract hash: option<CryptoKeyKeyAlgorithm> with get, set
            abstract publicExponent: U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>> with get, set
            abstract modulusLength: float with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "MessageBatch")>]
        type MessageBatch<'Body> =
            abstract metadata: MessageBatchMetadata with get
            abstract queue: D1SessionBookmark with get
            abstract messages: ReadonlyArray<Message<'Body>> with get
            abstract ackAll: unit -> unit
            abstract retryAll: ?options: QueueRetryOptions -> unit

        [<Import("@cloudflare/workers-types", "URLPatternResult")>]
        type URLPatternResult =
            abstract hash: URLPatternComponentResult with get, set
            abstract search: URLPatternComponentResult with get, set
            abstract pathname: URLPatternComponentResult with get, set
            abstract port: URLPatternComponentResult with get, set
            abstract hostname: URLPatternComponentResult with get, set
            abstract password: URLPatternComponentResult with get, set
            abstract username: URLPatternComponentResult with get, set
            abstract protocol: URLPatternComponentResult with get, set
            abstract inputs: Array<U2<URLPatternInit, D1SessionBookmark>> with get, set

        [<Import("@cloudflare/workers-types", "BaseAiSentenceSimilarity")>]
        type BaseAiSentenceSimilarity =
            abstract postProcessedOutputs: AiSentenceSimilarityOutput with get, set
            abstract inputs: AiSentenceSimilarityInput with get, set

        [<Import("@cloudflare/workers-types", "ResponseRefusalDoneEvent")>]
        type ResponseRefusalDoneEvent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseRefusalDoneEvent.Type with get, set

            [<CompiledName("sequence_number")>]
            abstract sequenceNumber: float with get, set

            abstract refusal: D1SessionBookmark with get, set

            [<CompiledName("output_index")>]
            abstract outputIndex: float with get, set

            [<CompiledName("item_id")>]
            abstract itemId: D1SessionBookmark with get, set

            [<CompiledName("content_index")>]
            abstract contentIndex: float with get, set

        type ChatCompletionMessageToolCall =
            U2<ChatCompletionMessageFunctionToolCall, ChatCompletionMessageCustomToolCall>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_Embedding_0_6B_Output")>]
        type AiCfQwenQwen3Embedding06BOutput =
            abstract shape: option<AiSentenceSimilarityOutput> with get, set
            abstract data: option<Array<AiSentenceSimilarityOutput>> with get, set

        type R2Range = U3<R2Range, R2Range, R2Range>

        [<Import("@cloudflare/workers-types", "ChatCompletionUrlCitation")>]
        type ChatCompletionUrlCitation =
            [<CompiledName("url_citation")>]
            abstract urlCitation: ChatCompletionUrlCitation.UrlCitation with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionUrlCitation.Type with get, set

        [<Import("@cloudflare/workers-types", "AiTextGenerationToolOutput")>]
        type AiTextGenerationToolOutput =
            [<CompiledName("function")>]
            abstract ``function``: AiTextGenerationToolOutput.Function with get, set

            [<CompiledName("type")>]
            abstract ``type``: AiTextGenerationToolOutput.Type with get, set

            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesExportedAuthenticatorMetadata")>]
        type IncomingRequestCfPropertiesExportedAuthenticatorMetadata =
            /// <example>
            /// "084ee802fe1348f688220e2a6040a05b2199a761f33cf753abb1b006792d3f8b"
            /// </example>
            abstract serverFinished: D1SessionBookmark with get, set
            /// <example>
            /// "084ee802fe1348f688220e2a6040a05b2199a761f33cf753abb1b006792d3f8b"
            /// </example>
            abstract clientFinished: D1SessionBookmark with get, set
            /// <example>
            /// "44372ba35fa1270921d318f34c12f155dc87b682cf36a790cfaa3ba8737a1b5d"
            /// </example>
            abstract serverHandshake: D1SessionBookmark with get, set
            /// <example>
            /// "44372ba35fa1270921d318f34c12f155dc87b682cf36a790cfaa3ba8737a1b5d"
            /// </example>
            abstract clientHandshake: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages")>]
        type AiCfMetaLlama3370BInstructFp8FastMessages =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfMetaLlama3370BInstructFp8FastJSONMode1> with get, set

            abstract tools:
                option<
                    Array<
                        U2<
                            AiCfMetaLlama3370BInstructFp8FastMessages.Tools,
                            AiCfMetaLlama3370BInstructFp8FastMessages.Tools
                         >
                     >
                 > with get, set

            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: Array<AiCfMetaLlama3370BInstructFp8FastMessages.Messages> with get, set

        [<Import("@cloudflare/workers-types", "AiModels")>]
        type AiModels =
            [<CompiledName("@cf/nvidia/nemotron-3-120b-a12b")>]
            abstract ``@cf/nvidia/nemotron3120bA12b``: BaseAiCfNvidiaNemotron3120BA12B with get, set

            [<CompiledName("@cf/moonshotai/kimi-k2.5")>]
            abstract ``@cf/moonshotai/kimiK2.5``: BaseAiCfMoonshotaiKimiK25 with get, set

            [<CompiledName("@cf/zai-org/glm-4.7-flash")>]
            abstract ``@cf/zaiOrg/glm4.7Flash``: BaseAiCfZaiOrgGlm47Flash with get, set

            [<CompiledName("@cf/black-forest-labs/flux-2-klein-9b")>]
            abstract ``@cf/blackForestLabs/flux2Klein9b``: BaseAiCfBlackForestLabsFlux2Klein9B with get, set

            [<CompiledName("@cf/black-forest-labs/flux-2-klein-4b")>]
            abstract ``@cf/blackForestLabs/flux2Klein4b``: BaseAiCfBlackForestLabsFlux2Klein4B with get, set

            [<CompiledName("@cf/black-forest-labs/flux-2-dev")>]
            abstract ``@cf/blackForestLabs/flux2Dev``: BaseAiCfBlackForestLabsFlux2Dev with get, set

            [<CompiledName("@cf/deepgram/aura-2-es")>]
            abstract ``@cf/deepgram/aura2Es``: BaseAiCfDeepgramAura2Es with get, set

            [<CompiledName("@cf/deepgram/aura-2-en")>]
            abstract ``@cf/deepgram/aura2En``: BaseAiCfDeepgramAura2En with get, set

            [<CompiledName("@cf/deepgram/flux")>]
            abstract ``@cf/deepgram/flux``: BaseAiCfDeepgramFlux with get, set

            [<CompiledName("@cf/pfnet/plamo-embedding-1b")>]
            abstract ``@cf/pfnet/plamoEmbedding1b``: BaseAiCfPfnetPlamoEmbedding1B with get, set

            [<CompiledName("@cf/aisingapore/gemma-sea-lion-v4-27b-it")>]
            abstract ``@cf/aisingapore/gemmaSeaLionV427bIt``: BaseAiCfAisingaporeGemmaSeaLionV427BIt with get, set

            [<CompiledName("@cf/ai4bharat/indictrans2-en-indic-1B")>]
            abstract ``@cf/ai4bharat/indictrans2EnIndic1B``: BaseAiCfAi4BharatIndictrans2EnIndic1B with get, set

            [<CompiledName("@cf/deepgram/aura-1")>]
            abstract ``@cf/deepgram/aura1``: BaseAiCfDeepgramAura1 with get, set

            [<CompiledName("@cf/leonardo/lucid-origin")>]
            abstract ``@cf/leonardo/lucidOrigin``: BaseAiCfLeonardoLucidOrigin with get, set

            [<CompiledName("@cf/leonardo/phoenix-1.0")>]
            abstract ``@cf/leonardo/phoenix1.0``: BaseAiCfLeonardoPhoenix10 with get, set

            [<CompiledName("@cf/openai/gpt-oss-20b")>]
            abstract ``@cf/openai/gptOss20b``: BaseAiCfOpenaiGptOss20B with get, set

            [<CompiledName("@cf/openai/gpt-oss-120b")>]
            abstract ``@cf/openai/gptOss120b``: BaseAiCfOpenaiGptOss120B with get, set

            [<CompiledName("@cf/pipecat-ai/smart-turn-v2")>]
            abstract ``@cf/pipecatAi/smartTurnV2``: BaseAiCfPipecatAiSmartTurnV2 with get, set

            [<CompiledName("@cf/qwen/qwen3-embedding-0.6b")>]
            abstract ``@cf/qwen/qwen3Embedding0.6b``: BaseAiCfQwenQwen3Embedding06B with get, set

            [<CompiledName("@cf/deepgram/nova-3")>]
            abstract ``@cf/deepgram/nova3``: BaseAiCfDeepgramNova3 with get, set

            [<CompiledName("@cf/qwen/qwen3-30b-a3b-fp8")>]
            abstract ``@cf/qwen/qwen330bA3bFp8``: BaseAiCfQwenQwen330BA3BFp8 with get, set

            [<CompiledName("@cf/meta/llama-4-scout-17b-16e-instruct")>]
            abstract ``@cf/meta/llama4Scout17b16eInstruct``: BaseAiCfMetaLlama4Scout17B16EInstruct with get, set

            [<CompiledName("@cf/google/gemma-3-12b-it")>]
            abstract ``@cf/google/gemma312bIt``: BaseAiCfGoogleGemma312BIt with get, set

            [<CompiledName("@cf/mistralai/mistral-small-3.1-24b-instruct")>]
            abstract ``@cf/mistralai/mistralSmall3.124bInstruct``: BaseAiCfMistralaiMistralSmall3124BInstruct with get, set

            [<CompiledName("@cf/qwen/qwq-32b")>]
            abstract ``@cf/qwen/qwq32b``: BaseAiCfQwenQwq32B with get, set

            [<CompiledName("@cf/qwen/qwen2.5-coder-32b-instruct")>]
            abstract ``@cf/qwen/qwen2.5Coder32bInstruct``: BaseAiCfQwenQwen25Coder32BInstruct with get, set

            [<CompiledName("@cf/baai/bge-reranker-base")>]
            abstract ``@cf/baai/bgeRerankerBase``: BaseAiCfBaaiBgeRerankerBase with get, set

            [<CompiledName("@cf/meta/llama-guard-3-8b")>]
            abstract ``@cf/meta/llamaGuard38b``: BaseAiCfMetaLlamaGuard38B with get, set

            [<CompiledName("@cf/meta/llama-3.3-70b-instruct-fp8-fast")>]
            abstract ``@cf/meta/llama3.370bInstructFp8Fast``: BaseAiCfMetaLlama3370BInstructFp8Fast with get, set

            [<CompiledName("@cf/meta/llama-3.2-11b-vision-instruct")>]
            abstract ``@cf/meta/llama3.211bVisionInstruct``: BaseAiCfMetaLlama3211BVisionInstruct with get, set

            [<CompiledName("@cf/black-forest-labs/flux-1-schnell")>]
            abstract ``@cf/blackForestLabs/flux1Schnell``: BaseAiCfBlackForestLabsFlux1Schnell with get, set

            [<CompiledName("@cf/baai/bge-m3")>]
            abstract ``@cf/baai/bgeM3``: BaseAiCfBaaiBgeM3 with get, set

            [<CompiledName("@cf/openai/whisper-large-v3-turbo")>]
            abstract ``@cf/openai/whisperLargeV3Turbo``: BaseAiCfOpenaiWhisperLargeV3Turbo with get, set

            [<CompiledName("@cf/openai/whisper-tiny-en")>]
            abstract ``@cf/openai/whisperTinyEn``: BaseAiCfOpenaiWhisperTinyEn with get, set

            [<CompiledName("@cf/unum/uform-gen2-qwen-500m")>]
            abstract ``@cf/unum/uformGen2Qwen500m``: BaseAiCfUnumUformGen2Qwen500M with get, set

            [<CompiledName("@cf/baai/bge-large-en-v1.5")>]
            abstract ``@cf/baai/bgeLargeEnV1.5``: BaseAiCfBaaiBgeLargeEnV15 with get, set

            [<CompiledName("@cf/baai/bge-small-en-v1.5")>]
            abstract ``@cf/baai/bgeSmallEnV1.5``: BaseAiCfBaaiBgeSmallEnV15 with get, set

            [<CompiledName("@cf/meta/m2m100-1.2b")>]
            abstract ``@cf/meta/m2m1001.2b``: BaseAiCfMetaM2M10012B with get, set

            [<CompiledName("@cf/openai/whisper")>]
            abstract ``@cf/openai/whisper``: BaseAiCfOpenaiWhisper with get, set

            [<CompiledName("@cf/baai/bge-base-en-v1.5")>]
            abstract ``@cf/baai/bgeBaseEnV1.5``: BaseAiCfBaaiBgeBaseEnV15 with get, set

            [<CompiledName("@cf/llava-hf/llava-1.5-7b-hf")>]
            abstract ``@cf/llavaHf/llava1.57bHf``: BaseAiImageToText with get, set

            [<CompiledName("@cf/facebook/bart-large-cnn")>]
            abstract ``@cf/facebook/bartLargeCnn``: BaseAiSummarization with get, set

            [<CompiledName("@cf/ibm-granite/granite-4.0-h-micro")>]
            abstract ``@cf/ibmGranite/granite4.0HMicro``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/deepseek-ai/deepseek-r1-distill-qwen-32b")>]
            abstract ``@cf/deepseekAi/deepseekR1DistillQwen32b``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/meta/llama-3.2-1b-instruct")>]
            abstract ``@cf/meta/llama3.21bInstruct``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/meta/llama-3.2-3b-instruct")>]
            abstract ``@cf/meta/llama3.23bInstruct``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/meta/llama-3.1-8b-instruct-awq")>]
            abstract ``@cf/meta/llama3.18bInstructAwq``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/meta/llama-3.1-8b-instruct-fp8")>]
            abstract ``@cf/meta/llama3.18bInstructFp8``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/meta/llama-3-8b-instruct-awq")>]
            abstract ``@cf/meta/llama38bInstructAwq``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/fblgit/una-cybertron-7b-v2-bf16")>]
            abstract ``@cf/fblgit/unaCybertron7bV2Bf16``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/meta/llama-3-8b-instruct")>]
            abstract ``@cf/meta/llama38bInstruct``: BaseAiTextGeneration with get, set

            [<CompiledName("@hf/mistral/mistral-7b-instruct-v0.2")>]
            abstract ``@hf/mistral/mistral7bInstructV0.2``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/google/gemma-7b-it-lora")>]
            abstract ``@cf/google/gemma7bItLora``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/google/gemma-2b-it-lora")>]
            abstract ``@cf/google/gemma2bItLora``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/meta-llama/llama-2-7b-chat-hf-lora")>]
            abstract ``@cf/metaLlama/llama27bChatHfLora``: BaseAiTextGeneration with get, set

            [<CompiledName("@hf/google/gemma-7b-it")>]
            abstract ``@hf/google/gemma7bIt``: BaseAiTextGeneration with get, set

            [<CompiledName("@hf/nexusflow/starling-lm-7b-beta")>]
            abstract ``@hf/nexusflow/starlingLm7bBeta``: BaseAiTextGeneration with get, set

            [<CompiledName("@hf/nousresearch/hermes-2-pro-mistral-7b")>]
            abstract ``@hf/nousresearch/hermes2ProMistral7b``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/mistral/mistral-7b-instruct-v0.2-lora")>]
            abstract ``@cf/mistral/mistral7bInstructV0.2Lora``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/qwen/qwen1.5-1.8b-chat")>]
            abstract ``@cf/qwen/qwen1.51.8bChat``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/microsoft/phi-2")>]
            abstract ``@cf/microsoft/phi2``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/tinyllama/tinyllama-1.1b-chat-v1.0")>]
            abstract ``@cf/tinyllama/tinyllama1.1bChatV1.0``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/qwen/qwen1.5-14b-chat-awq")>]
            abstract ``@cf/qwen/qwen1.514bChatAwq``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/qwen/qwen1.5-7b-chat-awq")>]
            abstract ``@cf/qwen/qwen1.57bChatAwq``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/qwen/qwen1.5-0.5b-chat")>]
            abstract ``@cf/qwen/qwen1.50.5bChat``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/thebloke/discolm-german-7b-v1-awq")>]
            abstract ``@cf/thebloke/discolmGerman7bV1Awq``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/tiiuae/falcon-7b-instruct")>]
            abstract ``@cf/tiiuae/falcon7bInstruct``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/openchat/openchat-3.5-0106")>]
            abstract ``@cf/openchat/openchat3.50106``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/defog/sqlcoder-7b-2")>]
            abstract ``@cf/defog/sqlcoder7b2``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/deepseek-ai/deepseek-math-7b-instruct")>]
            abstract ``@cf/deepseekAi/deepseekMath7bInstruct``: BaseAiTextGeneration with get, set

            [<CompiledName("@hf/thebloke/deepseek-coder-6.7b-instruct-awq")>]
            abstract ``@hf/thebloke/deepseekCoder6.7bInstructAwq``: BaseAiTextGeneration with get, set

            [<CompiledName("@hf/thebloke/deepseek-coder-6.7b-base-awq")>]
            abstract ``@hf/thebloke/deepseekCoder6.7bBaseAwq``: BaseAiTextGeneration with get, set

            [<CompiledName("@hf/thebloke/neural-chat-7b-v3-1-awq")>]
            abstract ``@hf/thebloke/neuralChat7bV31Awq``: BaseAiTextGeneration with get, set

            [<CompiledName("@hf/thebloke/openhermes-2.5-mistral-7b-awq")>]
            abstract ``@hf/thebloke/openhermes2.5Mistral7bAwq``: BaseAiTextGeneration with get, set

            [<CompiledName("@hf/thebloke/zephyr-7b-beta-awq")>]
            abstract ``@hf/thebloke/zephyr7bBetaAwq``: BaseAiTextGeneration with get, set

            [<CompiledName("@hf/thebloke/mistral-7b-instruct-v0.1-awq")>]
            abstract ``@hf/thebloke/mistral7bInstructV0.1Awq``: BaseAiTextGeneration with get, set

            [<CompiledName("@hf/thebloke/llama-2-13b-chat-awq")>]
            abstract ``@hf/thebloke/llama213bChatAwq``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/meta/llama-2-7b-chat-fp16")>]
            abstract ``@cf/meta/llama27bChatFp16``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/mistral/mistral-7b-instruct-v0.1")>]
            abstract ``@cf/mistral/mistral7bInstructV0.1``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/meta/llama-2-7b-chat-int8")>]
            abstract ``@cf/meta/llama27bChatInt8``: BaseAiTextGeneration with get, set

            [<CompiledName("@cf/microsoft/resnet-50")>]
            abstract ``@cf/microsoft/resnet50``: BaseAiImageClassification with get, set

            [<CompiledName("@cf/google/embeddinggemma-300m")>]
            abstract ``@cf/google/embeddinggemma300m``: BaseAiTextEmbeddings with get, set

            [<CompiledName("@cf/myshell-ai/melotts")>]
            abstract ``@cf/myshellAi/melotts``: BaseAiTextToSpeech with get, set

            [<CompiledName("@cf/bytedance/stable-diffusion-xl-lightning")>]
            abstract ``@cf/bytedance/stableDiffusionXlLightning``: BaseAiTextToImage with get, set

            [<CompiledName("@cf/lykon/dreamshaper-8-lcm")>]
            abstract ``@cf/lykon/dreamshaper8Lcm``: BaseAiTextToImage with get, set

            [<CompiledName("@cf/runwayml/stable-diffusion-v1-5-img2img")>]
            abstract ``@cf/runwayml/stableDiffusionV15Img2img``: BaseAiTextToImage with get, set

            [<CompiledName("@cf/runwayml/stable-diffusion-v1-5-inpainting")>]
            abstract ``@cf/runwayml/stableDiffusionV15Inpainting``: BaseAiTextToImage with get, set

            [<CompiledName("@cf/stabilityai/stable-diffusion-xl-base-1.0")>]
            abstract ``@cf/stabilityai/stableDiffusionXlBase1.0``: BaseAiTextToImage with get, set

            [<CompiledName("@cf/huggingface/distilbert-sst-2-int8")>]
            abstract ``@cf/huggingface/distilbertSst2Int8``: BaseAiTextClassification with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Meta_M2M100_1_2B")>]
        type BaseAiCfMetaM2M10012B =
            abstract postProcessedOutputs: AiCfMetaM2M10012BOutput with get, set
            abstract inputs: AiCfMetaM2M10012BInput with get, set

        [<Import("@cloudflare/workers-types", "PubSubMessage")>]
        type PubSubMessage =
            abstract payload: U2<Uint8Array<ArrayBufferLike>, D1SessionBookmark> with get, set
            abstract payloadFormatIndicator: float with get
            abstract contentType: D1SessionBookmark with get
            abstract receivedAt: float with get
            abstract jti: option<D1SessionBookmark> with get
            abstract clientId: D1SessionBookmark with get
            abstract topic: D1SessionBookmark with get
            abstract broker: D1SessionBookmark with get
            abstract mid: float with get

        [<Import("@cloudflare/workers-types", "RequestInitCfPropertiesImageMinify")>]
        type RequestInitCfPropertiesImageMinify =
            abstract html: option<bool> with get, set
            abstract css: option<bool> with get, set
            abstract javascript: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Baai_Bge_Reranker_Base")>]
        type BaseAiCfBaaiBgeRerankerBase =
            abstract postProcessedOutputs: AiCfBaaiBgeRerankerBaseOutput with get, set
            abstract inputs: AiCfBaaiBgeRerankerBaseInput with get, set

        [<Import("@cloudflare/workers-types", "BaseAiImageTextToText")>]
        type BaseAiImageTextToText =
            abstract postProcessedOutputs: AiImageTextToTextOutput with get, set
            abstract inputs: AiImageTextToTextInput with get, set

        [<Import("@cloudflare/workers-types", "ResponseTextDeltaEvent")>]
        type ResponseTextDeltaEvent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseTextDeltaEvent.Type with get, set

            [<CompiledName("sequence_number")>]
            abstract sequenceNumber: float with get, set

            [<CompiledName("output_index")>]
            abstract outputIndex: float with get, set

            abstract logprobs: Array<Logprob> with get, set

            [<CompiledName("item_id")>]
            abstract itemId: D1SessionBookmark with get, set

            abstract delta: D1SessionBookmark with get, set

            [<CompiledName("content_index")>]
            abstract contentIndex: float with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Leonardo_Lucid_Origin")>]
        type BaseAiCfLeonardoLucidOrigin =
            abstract postProcessedOutputs: AiCfLeonardoLucidOriginOutput with get, set
            abstract inputs: AiCfLeonardoLucidOriginInput with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseStatus =
            | [<CompiledName("completed")>] Completed
            | [<CompiledName("failed")>] Failed
            | [<CompiledName("in_progress")>] InProgress
            | [<CompiledName("cancelled")>] Cancelled
            | [<CompiledName("queued")>] Queued
            | [<CompiledName("incomplete")>] Incomplete

        [<Import("@cloudflare/workers-types", "DispatchNamespace")>]
        type DispatchNamespace =
            abstract get:
                name: D1SessionBookmark * ?args: DispatchNamespace.Get.Args * ?options: DynamicDispatchOptions ->
                    DispatchNamespace.Get

        [<Import("@cloudflare/workers-types", "ChatCompletionAudio")>]
        type ChatCompletionAudio =
            abstract transcript: D1SessionBookmark with get, set

            [<CompiledName("expires_at")>]
            abstract expiresAt: float with get, set

            abstract data: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "R2PutOptions")>]
        type R2PutOptions =
            abstract ssecKey: option<U2<ArrayBuffer, D1SessionBookmark>> with get, set
            abstract storageClass: option<D1SessionBookmark> with get, set
            abstract sha512: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, D1SessionBookmark>> with get, set
            abstract sha384: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, D1SessionBookmark>> with get, set
            abstract sha256: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, D1SessionBookmark>> with get, set
            abstract sha1: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, D1SessionBookmark>> with get, set
            abstract md5: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, D1SessionBookmark>> with get, set
            abstract customMetadata: option<R2PutOptions.CustomMetadata> with get, set
            abstract httpMetadata: option<U2<R2HTTPMetadata, Headers>> with get, set
            abstract onlyIf: option<U2<R2Conditional, Headers>> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ReasoningEffort =
            | [<CompiledName("minimal")>] Minimal
            | [<CompiledName("low")>] Low
            | [<CompiledName("medium")>] Medium
            | [<CompiledName("high")>] High

        [<Import("@cloudflare/workers-types", "TextEncoderStream")>]
        type TextEncoderStream =
            [<EmitConstructor>]
            abstract Create: unit -> TextEncoderStream

            inherit TransformStream<D1SessionBookmark, Uint8Array<ArrayBufferLike>, 'TextEncoderStream><
                D1SessionBookmark,
                Uint8Array<ArrayBufferLike>
             >

            abstract encoding: D1SessionBookmark with get

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseInputItem =
            | [<CompiledName("assistant")>] Assistant
            | [<CompiledName("in_progress")>] InProgress
            | [<CompiledName("completed")>] Completed
            | [<CompiledName("incomplete")>] Incomplete
            | [<CompiledName("user")>] User
            | [<CompiledName("system")>] System
            | [<CompiledName("developer")>] Developer
            | [<CompiledName("message")>] Message
            | [<CompiledName("function_call")>] FunctionCall
            | [<CompiledName("function_call_output")>] FunctionCallOutput
            | [<CompiledName("reasoning")>] Reasoning

        [<Import("@cloudflare/workers-types", "SupportedFileFormat")>]
        type SupportedFileFormat =
            abstract extension: D1SessionBookmark with get, set
            abstract mimeType: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "BasicImageTransformations")>]
        type BasicImageTransformations =
            abstract rotate: option<BasicImageTransformations.Rotate> with get, set
            abstract background: option<D1SessionBookmark> with get, set
            abstract gravity: option<U2<BasicImageTransformations.Gravity, BasicImageTransformationsGravityCoordinates>> with get, set
            abstract segment: option<BasicImageTransformations.Segment> with get, set
            abstract fit: option<BasicImageTransformations.Fit> with get, set
            abstract height: option<float> with get, set
            abstract width: option<float> with get, set

        [<Import("@cloudflare/workers-types", "FunctionDefinition")>]
        type FunctionDefinition =
            abstract strict: option<bool> with get, set
            abstract parameters: option<FunctionDefinition.Parameters> with get, set
            abstract description: option<D1SessionBookmark> with get, set
            abstract name: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseInputContent =
            | [<CompiledName("input_image")>] InputImage
            | [<CompiledName("low")>] Low
            | [<CompiledName("high")>] High
            | [<CompiledName("auto")>] Auto
            | [<CompiledName("input_text")>] InputText

        [<Import("@cloudflare/workers-types", "CompletionUsage")>]
        type CompletionUsage =
            [<CompiledName("completion_tokens_details")>]
            abstract completionTokensDetails: option<CompletionTokensDetails> with get, set

            [<CompiledName("prompt_tokens_details")>]
            abstract promptTokensDetails: option<PromptTokensDetails> with get, set

            [<CompiledName("total_tokens")>]
            abstract totalTokens: float with get, set

            [<CompiledName("completion_tokens")>]
            abstract completionTokens: float with get, set

            [<CompiledName("prompt_tokens")>]
            abstract promptTokens: float with get, set

        type AiCfMetaLlama3211BVisionInstructInput =
            U2<AiCfMetaLlama3211BVisionInstructPrompt, AiCfMetaLlama3211BVisionInstructMessages>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Openai_Whisper_Large_V3_Turbo")>]
        type BaseAiCfOpenaiWhisperLargeV3Turbo =
            abstract postProcessedOutputs: AiCfOpenaiWhisperLargeV3TurboOutput with get, set
            abstract inputs: AiCfOpenaiWhisperLargeV3TurboInput with get, set

        [<Import("@cloudflare/workers-types", "File")>]
        type File =
            [<EmitConstructor>]
            abstract Create:
                ?bits: Array<U4<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, Blob, D1SessionBookmark>> *
                name: D1SessionBookmark *
                ?options: FileOptions ->
                    File

            inherit Blob
            abstract lastModified: float with get
            abstract name: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_Base_En_V1_5_AsyncResponse")>]
        type AiCfBaaiBgeBaseEnV15AsyncResponse =
            [<CompiledName("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "TraceItemConnectEventInfo")>]
        type TraceItemConnectEventInfo = interface end

        [<Import("@cloudflare/workers-types", "SendEmail")>]
        type SendEmail =
            abstract send: builder: SendEmail.Send.Builder -> Promise<EmailSendResult>
            abstract send: message: EmailMessage -> Promise<EmailSendResult>

        [<Import("@cloudflare/workers-types", "TraceItemFetchEventInfo")>]
        type TraceItemFetchEventInfo =
            abstract request: TraceItemFetchEventInfoRequest with get
            abstract response: option<TraceItemFetchEventInfoResponse> with get

        [<Import("@cloudflare/workers-types", "TraceItemEmailEventInfo")>]
        type TraceItemEmailEventInfo =
            abstract rawSize: float with get
            abstract rcptTo: D1SessionBookmark with get
            abstract mailFrom: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Google_Gemma_4_26B_A4B_IT")>]
        type BaseAiCfGoogleGemma426BA4BIT =
            abstract postProcessedOutputs: ChatCompletionsOutput with get, set

            abstract inputs:
                U3<
                    BaseAiCfGoogleGemma426BA4BIT.Inputs,
                    BaseAiCfGoogleGemma426BA4BIT.Inputs,
                    BaseAiCfGoogleGemma426BA4BIT.Inputs
                 > with get, set

        [<Import("@cloudflare/workers-types", "D1Response")>]
        type D1Response =
            abstract error: option<unit> with get, set
            abstract meta: D1Response.Meta with get, set
            abstract success: D1Response.Success with get, set

        [<Import("@cloudflare/workers-types", "DocumentEnd")>]
        type DocumentEnd =
            abstract append: content: D1SessionBookmark * ?options: ContentOptions -> DocumentEnd

        [<Import("@cloudflare/workers-types", "UniversalGatewayOptions")>]
        type UniversalGatewayOptions =
            /// <deprecated />
            abstract id: option<D1SessionBookmark> with get, set
            abstract retries: option<GatewayRetries> with get, set
            abstract requestTimeoutMs: option<float> with get, set
            abstract eventId: option<D1SessionBookmark> with get, set
            abstract collectLog: option<bool> with get, set
            abstract metadata: option<UniversalGatewayOptions.Metadata> with get, set
            abstract skipCache: option<bool> with get, set
            abstract cacheTtl: option<float> with get, set
            abstract cacheKey: option<D1SessionBookmark> with get, set
            abstract id: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ToolChoiceOptions = | [<CompiledName("none")>] ToolChoiceOptions

        [<Import("@cloudflare/workers-types", "ChatCompletionFunctionTool")>]
        type ChatCompletionFunctionTool =
            [<CompiledName("function")>]
            abstract ``function``: FunctionDefinition with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionFunctionTool.Type with get, set

        [<Import("@cloudflare/workers-types", "VectorizeVector")>]
        type VectorizeVector =
            abstract metadata: option<VectorizeVector.Metadata> with get, set

            [<CompiledName("namespace")>]
            abstract ``namespace``: option<D1SessionBookmark> with get, set

            abstract values:
                U3<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>, AiSentenceSimilarityOutput> with get, set

            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Output")>]
        type AiCfMistralaiMistralSmall3124BInstructOutput =
            [<CompiledName("tool_calls")>]
            abstract toolCalls: option<Array<AiCfMistralaiMistralSmall3124BInstructOutput.ToolCalls>> with get, set

            abstract usage: option<AiCfMistralaiMistralSmall3124BInstructOutput.Usage> with get, set
            abstract response: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "InstanceStatus")>]
        type InstanceStatus =
            abstract output: option<obj> with get, set
            abstract error: option<InstanceStatus.Error> with get, set
            abstract status: CloudflareWorkersModule.WorkflowInstanceStatus with get, set

        [<Import("@cloudflare/workers-types", "ResponseFunctionCallArgumentsDoneEvent")>]
        type ResponseFunctionCallArgumentsDoneEvent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseFunctionCallArgumentsDoneEvent.Type with get, set

            [<CompiledName("sequence_number")>]
            abstract sequenceNumber: float with get, set

            [<CompiledName("output_index")>]
            abstract outputIndex: float with get, set

            abstract name: D1SessionBookmark with get, set

            [<CompiledName("item_id")>]
            abstract itemId: D1SessionBookmark with get, set

            abstract arguments: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "TlsOptions")>]
        type TlsOptions =
            abstract expectedServerHostname: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "DeveloperMessage")>]
        type DeveloperMessage =
            abstract name: option<D1SessionBookmark> with get, set
            abstract content: U2<Array<ChatCompletionContentPartText>, D1SessionBookmark> with get, set
            abstract role: DeveloperMessage.Role with get, set

        [<Import("@cloudflare/workers-types", "QueueSendMetrics")>]
        type QueueSendMetrics =
            abstract oldestMessageTimestamp: option<Date> with get, set
            abstract backlogBytes: float with get, set
            abstract backlogCount: float with get, set

        [<Import("@cloudflare/workers-types", "AiTextEmbeddingsInput")>]
        type AiTextEmbeddingsInput =
            abstract text: U2<Array<D1SessionBookmark>, D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Async_Batch")>]
        type AiCfMetaLlama4Scout17B16EInstructAsyncBatch =
            abstract requests:
                Array<U2<AiCfMetaLlama4Scout17B16EInstructPromptInner, AiCfMetaLlama4Scout17B16EInstructMessagesInner>> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Openai_Whisper_Large_V3_Turbo_Input")>]
        type AiCfOpenaiWhisperLargeV3TurboInput =
            [<CompiledName("hallucination_silence_threshold")>]
            abstract hallucinationSilenceThreshold: option<float> with get, set

            [<CompiledName("log_prob_threshold")>]
            abstract logProbThreshold: option<float> with get, set

            [<CompiledName("compression_ratio_threshold")>]
            abstract compressionRatioThreshold: option<float> with get, set

            [<CompiledName("no_speech_threshold")>]
            abstract noSpeechThreshold: option<float> with get, set

            [<CompiledName("condition_on_previous_text")>]
            abstract conditionOnPreviousText: option<bool> with get, set

            [<CompiledName("beam_size")>]
            abstract beamSize: option<float> with get, set

            abstract prefix: option<D1SessionBookmark> with get, set

            [<CompiledName("initial_prompt")>]
            abstract initialPrompt: option<D1SessionBookmark> with get, set

            [<CompiledName("vad_filter")>]
            abstract vadFilter: option<bool> with get, set

            abstract language: option<D1SessionBookmark> with get, set
            abstract task: option<D1SessionBookmark> with get, set
            abstract audio: U2<AiCfOpenaiWhisperLargeV3TurboInput.Audio, D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "AiTextClassificationInput")>]
        type AiTextClassificationInput =
            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Deepgram_Nova_3_Input")>]
        type AiCfDeepgramNova3Input =
            [<CompiledName("utterance_end_ms")>]
            abstract utteranceEndMs: option<bool> with get, set

            [<CompiledName("vad_events")>]
            abstract vadEvents: option<bool> with get, set

            abstract endpointing: option<D1SessionBookmark> with get, set

            [<CompiledName("interim_results")>]
            abstract interimResults: option<bool> with get, set

            abstract channels: option<float> with get, set

            [<CompiledName("utt_split")>]
            abstract uttSplit: option<float> with get, set

            abstract utterances: option<bool> with get, set
            abstract topics: option<bool> with get, set

            [<CompiledName("smart_format")>]
            abstract smartFormat: option<bool> with get, set

            abstract sentiment: option<bool> with get, set
            abstract search: option<D1SessionBookmark> with get, set
            abstract replace: option<D1SessionBookmark> with get, set
            abstract redact: option<D1SessionBookmark> with get, set
            abstract punctuate: option<bool> with get, set

            [<CompiledName("profanity_filter")>]
            abstract profanityFilter: option<bool> with get, set

            abstract paragraphs: option<bool> with get, set
            abstract numerals: option<bool> with get, set
            abstract multichannel: option<bool> with get, set
            abstract mode: option<AiCfDeepgramNova3Input.Mode> with get, set

            [<CompiledName("mip_opt_out")>]
            abstract mipOptOut: option<bool> with get, set

            abstract measurements: option<bool> with get, set
            abstract language: option<D1SessionBookmark> with get, set
            abstract keywords: option<D1SessionBookmark> with get, set
            abstract keyterm: option<D1SessionBookmark> with get, set

            [<CompiledName("filler_words")>]
            abstract fillerWords: option<bool> with get, set

            abstract extra: option<D1SessionBookmark> with get, set
            abstract encoding: option<AiCfDeepgramNova3Input.Encoding> with get, set
            abstract dictation: option<bool> with get, set
            abstract diarize: option<bool> with get, set

            [<CompiledName("detect_language")>]
            abstract detectLanguage: option<bool> with get, set

            [<CompiledName("detect_entities")>]
            abstract detectEntities: option<bool> with get, set

            [<CompiledName("custom_intent")>]
            abstract customIntent: option<D1SessionBookmark> with get, set

            [<CompiledName("custom_intent_mode")>]
            abstract customIntentMode: option<AiCfDeepgramNova3Input.CustomIntentMode> with get, set

            [<CompiledName("custom_topic")>]
            abstract customTopic: option<D1SessionBookmark> with get, set

            [<CompiledName("custom_topic_mode")>]
            abstract customTopicMode: option<AiCfDeepgramNova3Input.CustomTopicMode> with get, set

            abstract audio: AiCfDeepgramNova3Input.Audio with get, set

        type DispatchEvent =
            abstract Invoke:
                event: U4<PromiseRejectionEvent, QueueEvent<option<obj>>, ScheduledEvent, FetchEvent> -> bool

            abstract Invoke: event: Event -> bool

        [<Import("@cloudflare/workers-types", "AiAsyncBatchResponse")>]
        type AiAsyncBatchResponse =
            [<CompiledName("request_id")>]
            abstract requestId: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "MessageSendRequest")>]
        type MessageSendRequest<'Body> =
            abstract delaySeconds: option<float> with get, set
            abstract contentType: option<MessageSendRequest.ContentType> with get, set
            abstract body: 'Body with get, set

        [<Import("@cloudflare/workers-types", "SubtleCryptoHashAlgorithm")>]
        type SubtleCryptoHashAlgorithm =
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Deepgram_Aura_2_Es_Input")>]
        type AiCfDeepgramAura2EsInput =
            [<CompiledName("bit_rate")>]
            abstract bitRate: option<float> with get, set

            [<CompiledName("sample_rate")>]
            abstract sampleRate: option<float> with get, set

            abstract text: D1SessionBookmark with get, set
            abstract container: option<AiCfDeepgramAura2EsInput.Container> with get, set
            abstract encoding: option<AiCfDeepgramAura2EsInput.Encoding> with get, set
            abstract speaker: option<AiCfDeepgramAura2EsInput.Speaker> with get, set

        [<Import("@cloudflare/workers-types", "CacheContext")>]
        type CacheContext =
            abstract purge: options: CachePurgeOptions -> Promise<CachePurgeResult>

        [<Import("@cloudflare/workers-types", "AiSearchMultiSearchResponse")>]
        type AiSearchMultiSearchResponse =
            abstract errors: option<Array<AiSearchMultiSearchError>> with get, set
            abstract chunks: Array<AiSearchMultiSearchChunk> with get, set

            [<CompiledName("search_query")>]
            abstract searchQuery: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Leonardo_Phoenix_1_0_Input")>]
        type AiCfLeonardoPhoenix10Input =
            [<CompiledName("negative_prompt")>]
            abstract negativePrompt: option<D1SessionBookmark> with get, set

            [<CompiledName("num_steps")>]
            abstract numSteps: option<float> with get, set

            abstract width: option<float> with get, set
            abstract height: option<float> with get, set
            abstract seed: option<float> with get, set
            abstract guidance: option<float> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionTopLogprob")>]
        type ChatCompletionTopLogprob =
            abstract bytes: option<AiSentenceSimilarityOutput> with get, set
            abstract logprob: float with get, set
            abstract token: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Klein_9B_Output")>]
        type AiCfBlackForestLabsFlux2Klein9BOutput =
            abstract image: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Prompt_1")>]
        type AiCfQwenQwen330BA3BFp8Prompt1 =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfQwenQwen330BA3BFp8JSONMode2> with get, set

            abstract lora: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "EmailExportedHandler")>]
        type EmailExportedHandler<'Props, 'Env> =
            abstract Invoke:
                message: ForwardableEmailMessage * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "TraceItemTailEventInfo")>]
        type TraceItemTailEventInfo =
            abstract consumedEvents: Array<TraceItemTailEventInfoTailItem> with get

        [<Import("@cloudflare/workers-types", "ResponseConversationParam")>]
        type ResponseConversationParam =
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ResponseReasoningSummaryItem")>]
        type ResponseReasoningSummaryItem =
            [<CompiledName("type")>]
            abstract ``type``: ResponseReasoningSummaryItem.Type with get, set

            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ContainerStartupOptions")>]
        type ContainerStartupOptions =
            abstract containerSnapshot: option<ContainerSnapshot> with get, set
            abstract directorySnapshots: option<Array<ContainerDirectorySnapshotRestoreParams>> with get, set
            abstract labels: option<ContainerStartupOptions.Labels> with get, set
            abstract env: option<ContainerStartupOptions.Env> with get, set
            abstract enableInternet: bool with get, set
            abstract entrypoint: option<Array<D1SessionBookmark>> with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionResponseMessage")>]
        type ChatCompletionResponseMessage =
            [<CompiledName("function_call")>]
            abstract functionCall: option<ChatCompletionResponseMessage.FunctionCall> with get, set

            [<CompiledName("tool_calls")>]
            abstract toolCalls: option<Array<ChatCompletionMessageToolCall>> with get, set

            abstract audio: option<ChatCompletionAudio> with get, set
            abstract annotations: option<Array<ChatCompletionUrlCitation>> with get, set
            abstract refusal: option<D1SessionBookmark> with get, set
            abstract content: option<D1SessionBookmark> with get, set
            abstract role: ChatCompletionResponseMessage.Role with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_Small_En_V1_5_AsyncResponse")>]
        type AiCfBaaiBgeSmallEnV15AsyncResponse =
            [<CompiledName("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRagAiSearchRequestStreaming")>]
        type AutoRagAiSearchRequestStreaming =
            abstract stream: AutoRagAiSearchRequestStreaming.Stream with get, set

            [<CompiledName("system_prompt")>]
            abstract systemPrompt: option<D1SessionBookmark> with get, set

            [<CompiledName("rewrite_query")>]
            abstract rewriteQuery: option<AutoRagAiSearchRequestStreaming.RewriteQuery> with get, set

            abstract reranking: option<AutoRagAiSearchRequestStreaming.Reranking> with get, set

            [<CompiledName("ranking_options")>]
            abstract rankingOptions: option<AutoRagAiSearchRequestStreaming.RankingOptions> with get, set

            [<CompiledName("max_num_results")>]
            abstract maxNumResults: option<float> with get, set

            abstract filters: option<U2<CompoundFilter, ComparisonFilter>> with get, set
            abstract query: D1SessionBookmark with get, set

        type VectorFloatArray = U2<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>>

        [<Import("@cloudflare/workers-types", "TracePreviewInfo")>]
        type TracePreviewInfo =
            abstract name: D1SessionBookmark with get, set
            abstract slug: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Flagship")>]
        type Flagship =
            abstract getObjectDetails:
                flagKey: D1SessionBookmark * defaultValue: 'T * ?context: Flagship.GetObjectDetails.Context ->
                    Promise<FlagshipEvaluationDetails<'T>>

            abstract getNumberDetails:
                flagKey: D1SessionBookmark * defaultValue: float * ?context: Flagship.GetNumberDetails.Context ->
                    Promise<FlagshipEvaluationDetails<float>>

            abstract getStringDetails:
                flagKey: D1SessionBookmark *
                defaultValue: D1SessionBookmark *
                ?context: Flagship.GetStringDetails.Context ->
                    Promise<FlagshipEvaluationDetails<D1SessionBookmark>>

            abstract getBooleanDetails:
                flagKey: D1SessionBookmark * defaultValue: bool * ?context: Flagship.GetBooleanDetails.Context ->
                    Promise<FlagshipEvaluationDetails<bool>>

            abstract getObjectValue:
                flagKey: D1SessionBookmark * defaultValue: 'T * ?context: Flagship.GetObjectValue.Context -> Promise<'T>

            abstract getNumberValue:
                flagKey: D1SessionBookmark * defaultValue: float * ?context: Flagship.GetNumberValue.Context ->
                    Promise<float>

            abstract getStringValue:
                flagKey: D1SessionBookmark * defaultValue: D1SessionBookmark * ?context: Flagship.GetStringValue.Context ->
                    Promise<D1SessionBookmark>

            abstract getBooleanValue:
                flagKey: D1SessionBookmark * defaultValue: bool * ?context: Flagship.GetBooleanValue.Context ->
                    Promise<bool>

            abstract get:
                flagKey: D1SessionBookmark * ?defaultValue: obj * ?context: Flagship.Get.Context -> Promise<option<obj>>

        [<Import("@cloudflare/workers-types", "ResponseReasoningContentItem")>]
        type ResponseReasoningContentItem =
            [<CompiledName("type")>]
            abstract ``type``: ResponseReasoningContentItem.Type with get, set

            abstract text: D1SessionBookmark with get, set

        type AiCfBaaiBgeM3Output =
            U4<
                AiCfBaaiBgeM3OutputQuery,
                AiCfBaaiBgeM3OutputEmbeddingForContexts,
                AiCfBaaiBgeM3OutputEmbedding,
                AiCfBaaiBgeM3AsyncResponse
             >

        [<Import("@cloudflare/workers-types", "EmbeddedImageConversionOptions")>]
        type EmbeddedImageConversionOptions =
            abstract maxConvertedImages: option<float> with get, set
            abstract convert: option<bool> with get, set
            abstract descriptionLanguage: option<EmbeddedImageConversionOptions.DescriptionLanguage> with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectClass")>]
        type DurableObjectClass<'_T when '_T :> Rpc.DurableObjectBranded> = interface end

        [<Import("@cloudflare/workers-types", "DurableObjectStorage")>]
        type DurableObjectStorage =
            abstract kv: SyncKvStorage with get, set
            abstract sql: SqlStorage with get, set
            abstract onNextSessionRestoreBookmark: bookmark: D1SessionBookmark -> Promise<D1SessionBookmark>
            abstract getBookmarkForTime: timestamp: U2<Date, float> -> Promise<D1SessionBookmark>
            abstract getCurrentBookmark: unit -> Promise<D1SessionBookmark>
            abstract transactionSync: closure: unit -> 'T -> 'T
            abstract sync: unit -> Promise<unit>
            abstract deleteAlarm: ?options: DurableObjectSetAlarmOptions -> Promise<unit>
            abstract setAlarm: scheduledTime: U2<Date, float> * ?options: DurableObjectSetAlarmOptions -> Promise<unit>
            abstract getAlarm: ?options: DurableObjectGetAlarmOptions -> Promise<option<float>>
            abstract transaction: closure: DurableObjectTransaction -> Promise<'T> -> Promise<'T>
            abstract deleteAll: ?options: DurableObjectPutOptions -> Promise<unit>
            abstract delete: keys: Array<D1SessionBookmark> * ?options: DurableObjectPutOptions -> Promise<float>
            abstract delete: key: D1SessionBookmark * ?options: DurableObjectPutOptions -> Promise<bool>
            abstract put: entries: DurableObjectStorage.Put.Entries * ?options: DurableObjectPutOptions -> Promise<unit>
            abstract put: key: D1SessionBookmark * value: 'T * ?options: DurableObjectPutOptions -> Promise<unit>
            abstract list: ?options: DurableObjectListOptions -> Promise<Map<D1SessionBookmark, 'T>>

            abstract get:
                keys: Array<D1SessionBookmark> * ?options: DurableObjectGetOptions ->
                    Promise<Map<D1SessionBookmark, 'T>>

            abstract get: key: D1SessionBookmark * ?options: DurableObjectGetOptions -> Promise<option<'T>>

        type Btoa =
            abstract Invoke: data: D1SessionBookmark -> D1SessionBookmark
            abstract Invoke: data: D1SessionBookmark -> D1SessionBookmark

        [<Import("@cloudflare/workers-types", "ImageInputOptions")>]
        type ImageInputOptions =
            abstract encoding: option<ImageInputOptions.Encoding> with get, set

        [<Import("@cloudflare/workers-types", "ArtifactsRepoInfo")>]
        type ArtifactsRepoInfo =
            abstract remote: D1SessionBookmark with get, set
            abstract readOnly: bool with get, set
            abstract source: option<D1SessionBookmark> with get, set
            abstract lastPushAt: option<D1SessionBookmark> with get, set
            abstract updatedAt: D1SessionBookmark with get, set
            abstract createdAt: D1SessionBookmark with get, set
            abstract defaultBranch: D1SessionBookmark with get, set
            abstract description: option<D1SessionBookmark> with get, set
            abstract name: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "CompoundFilter")>]
        type CompoundFilter =
            abstract filters: Array<ComparisonFilter> with get, set

            [<CompiledName("type")>]
            abstract ``type``: CompoundFilter.Type with get, set

        [<Import("@cloudflare/workers-types", "AiSearchNamespace")>]
        type AiSearchNamespace =
            abstract chatCompletions:
                params: AiSearchMultiChatCompletionsRequest -> Promise<AiSearchMultiChatCompletionsResponse>

            abstract chatCompletions:
                params: AiSearchNamespace.ChatCompletions.Params -> Promise<ReadableStream<option<obj>>>

            abstract search: params: AiSearchMultiSearchRequest -> Promise<AiSearchMultiSearchResponse>
            abstract delete: name: D1SessionBookmark -> Promise<unit>
            abstract create: config: AiSearchConfig -> Promise<AiSearchInstance>
            abstract list: ?params: AiSearchListInstancesParams -> Promise<AiSearchListResponse>
            abstract get: name: D1SessionBookmark -> AiSearchInstance

        type AiCfOpenaiWhisperInput = U2<AiAutomaticSpeechRecognitionInput, D1SessionBookmark>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Input_QueryAnd_Contexts")>]
        type AiCfBaaiBgeM3InputQueryAndContexts =
            [<CompiledName("truncate_inputs")>]
            abstract truncateInputs: option<bool> with get, set

            abstract contexts: Array<AiCfBaaiBgeM3InputQueryAndContexts.Contexts> with get, set
            abstract query: option<D1SessionBookmark> with get, set

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRAGNameNotSetError")>]
        type AutoRAGNameNotSetError =
            interface
                inherit Error
            end

        type ResponseItem =
            abstract status: option<ResponseItem.Status> with get, set

            [<CompiledName("type")>]
            abstract ``type``: ResponseItem.Type with get, set

            abstract output: U2<Array<ResponseInputContent>, D1SessionBookmark> with get, set

            [<CompiledName("call_id")>]
            abstract callId: D1SessionBookmark with get, set

            abstract id: D1SessionBookmark with get, set
            abstract status: ResponseItem.Status with get, set
            abstract role: ResponseItem.Role with get, set
            abstract content: Array<U2<ResponseOutputText, ResponseOutputRefusal>> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<ResponseItem.Type> with get, set

            abstract content: Array<U2<ResponseInputText, ResponseInputImage>> with get, set

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRagAiSearchRequest")>]
        type AutoRagAiSearchRequest =
            [<CompiledName("system_prompt")>]
            abstract systemPrompt: option<D1SessionBookmark> with get, set

            abstract stream: option<bool> with get, set

            [<CompiledName("rewrite_query")>]
            abstract rewriteQuery: option<bool> with get, set

            abstract reranking: option<AutoRagAiSearchRequest.Reranking> with get, set

            [<CompiledName("ranking_options")>]
            abstract rankingOptions: option<AutoRagAiSearchRequest.RankingOptions> with get, set

            [<CompiledName("max_num_results")>]
            abstract maxNumResults: option<float> with get, set

            abstract filters: option<U2<CompoundFilter, ComparisonFilter>> with get, set
            abstract query: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Prompt")>]
        type AiCfAisingaporeGemmaSeaLionV427BItPrompt =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfAisingaporeGemmaSeaLionV427BItJSONMode> with get, set

            abstract lora: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        type WorkflowRetentionDuration =
            U15<
                WorkflowRetentionDuration,
                WorkflowRetentionDuration,
                WorkflowRetentionDuration,
                WorkflowRetentionDuration,
                WorkflowRetentionDuration,
                WorkflowRetentionDuration,
                WorkflowRetentionDuration,
                WorkflowRetentionDuration,
                WorkflowRetentionDuration,
                WorkflowRetentionDuration,
                WorkflowRetentionDuration,
                WorkflowRetentionDuration,
                WorkflowRetentionDuration,
                WorkflowRetentionDuration,
                float
             >

        [<Import("@cloudflare/workers-types", "TraceMetrics")>]
        type TraceMetrics =
            abstract wallTime: float with get
            abstract cpuTime: float with get

        [<Import("@cloudflare/workers-types", "EmailAddress")>]
        type EmailAddress =
            abstract email: D1SessionBookmark with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Black_Forest_Labs_Flux_1_Schnell")>]
        type BaseAiCfBlackForestLabsFlux1Schnell =
            abstract postProcessedOutputs: AiCfBlackForestLabsFlux1SchnellOutput with get, set
            abstract inputs: AiCfBlackForestLabsFlux1SchnellInput with get, set

        [<Import("@cloudflare/workers-types", "Scheduler")>]
        type Scheduler =
            abstract wait: delay: float * ?maybeOptions: SchedulerWaitOptions -> Promise<unit>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_1_Schnell_Output")>]
        type AiCfBlackForestLabsFlux1SchnellOutput =
            abstract image: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Prompt_Inner")>]
        type AiCfMetaLlama4Scout17B16EInstructPromptInner =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfMetaLlama4Scout17B16EInstructJSONMode> with get, set

            [<CompiledName("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "StreamError")>]
        type StreamError =
            inherit Error
            abstract stack: option<D1SessionBookmark> with get
            abstract message: D1SessionBookmark with get
            abstract statusCode: float with get
            abstract code: float with get

        [<Import("@cloudflare/workers-types", "BaseAiTextToImage")>]
        type BaseAiTextToImage =
            abstract postProcessedOutputs: ReadableStream<Uint8Array<ArrayBufferLike>> with get, set
            abstract inputs: AiTextToImageInput with get, set

        [<Import("@cloudflare/workers-types", "WorkflowError")>]
        type WorkflowError =
            abstract message: D1SessionBookmark with get, set
            abstract code: option<float> with get, set

        [<Import("@cloudflare/workers-types", "TraceItemTailEventInfoTailItem")>]
        type TraceItemTailEventInfoTailItem =
            abstract scriptName: option<D1SessionBookmark> with get

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Dev_Output")>]
        type AiCfBlackForestLabsFlux2DevOutput =
            abstract image: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Artifacts")>]
        type Artifacts =
            abstract delete: name: D1SessionBookmark -> Promise<bool>
            abstract list: ?opts: AiSearchItemLogsParams -> Promise<ArtifactsRepoListResult>
            abstract import: params: Artifacts.Import.Params -> Promise<ArtifactsCreateRepoResult>
            abstract get: name: D1SessionBookmark -> Promise<ArtifactsRepo>

            abstract create:
                name: D1SessionBookmark * ?opts: Artifacts.Create.Opts -> Promise<ArtifactsCreateRepoResult>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Output")>]
        type AiCfMetaLlama3211BVisionInstructOutput =
            [<CompiledName("tool_calls")>]
            abstract toolCalls: option<Array<AiCfMetaLlama3211BVisionInstructOutput.ToolCalls>> with get, set

            abstract response: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ResponseInputTextContent")>]
        type ResponseInputTextContent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseInputTextContent.Type with get, set

            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "CachePurgeResult")>]
        type CachePurgeResult =
            abstract errors: Array<CachePurgeError> with get, set
            abstract success: bool with get, set

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRagAiSearchResponse")>]
        type AutoRagAiSearchResponse =
            abstract response: D1SessionBookmark with get, set

            [<CompiledName("next_page")>]
            abstract nextPage: option<D1SessionBookmark> with get, set

            [<CompiledName("has_more")>]
            abstract hasMore: bool with get, set

            abstract data: Array<AutoRagAiSearchResponse.Data> with get, set

            [<CompiledName("search_query")>]
            abstract searchQuery: D1SessionBookmark with get, set

            abstract object: AutoRagAiSearchResponse.Object with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Pfnet_Plamo_Embedding_1B")>]
        type BaseAiCfPfnetPlamoEmbedding1B =
            abstract postProcessedOutputs: AiCfPfnetPlamoEmbedding1BOutput with get, set
            abstract inputs: AiCfPfnetPlamoEmbedding1BInput with get, set

        [<Import("@cloudflare/workers-types", "ContainerDirectorySnapshot")>]
        type ContainerDirectorySnapshot =
            abstract name: option<D1SessionBookmark> with get, set
            abstract dir: D1SessionBookmark with get, set
            abstract size: float with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "PromiseRejectionEvent")>]
        type PromiseRejectionEvent =
            inherit Event
            abstract reason: option<obj> with get
            abstract promise: Promise<option<obj>> with get

        type VectorizeVectorMetadataValue = U4<Array<D1SessionBookmark>, D1SessionBookmark, float, bool>

        [<Import("@cloudflare/workers-types", "MessagePort")>]
        type MessagePort =
            inherit EventTarget
            abstract onmessage: option<obj> with set
            abstract onmessage: option<obj> with get
            abstract start: unit -> unit
            abstract close: unit -> unit
            abstract postMessage: ?data: obj * ?options: U2<Array<option<obj>>, MessagePortPostMessageOptions> -> unit

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Baai_Bge_Large_En_V1_5")>]
        type BaseAiCfBaaiBgeLargeEnV15 =
            abstract postProcessedOutputs: AiCfBaaiBgeLargeEnV15Output with get, set
            abstract inputs: AiCfBaaiBgeLargeEnV15Input with get, set

        [<Import("@cloudflare/workers-types", "ResponseCompletedEvent")>]
        type ResponseCompletedEvent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseCompletedEvent.Type with get, set

            [<CompiledName("sequence_number")>]
            abstract sequenceNumber: float with get, set

            abstract response: Typescript.Response with get, set

        type AiCfBaaiBgeLargeEnV15Output = U2<AiCfBaaiBgeLargeEnV15Output, AiCfBaaiBgeLargeEnV15AsyncResponse>

        type ChatCompletionCustomToolFormat =
            U2<ChatCompletionCustomToolTextFormat, ChatCompletionCustomToolGrammarFormat>

        type ReportError =
            abstract Invoke: ?error: obj -> unit
            abstract Invoke: ?e: obj -> unit

        type ResponseInputMessageContentList = Array<U2<ResponseInputText, ResponseInputImage>>

        [<Import("@cloudflare/workers-types", "ResponseOutputItemDoneEvent")>]
        type ResponseOutputItemDoneEvent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseOutputItemDoneEvent.Type with get, set

            [<CompiledName("sequence_number")>]
            abstract sequenceNumber: float with get, set

            [<CompiledName("output_index")>]
            abstract outputIndex: float with get, set

            abstract item: ResponseOutputItem with get, set

        [<Import("@cloudflare/workers-types", "Span")>]
        type Span =
            abstract isTraced: bool with get
            abstract setAttribute: key: D1SessionBookmark * ?value: U3<bool, float, D1SessionBookmark> -> unit

        type StructuredClone =
            abstract Invoke: value: 'T * ?options: Typescript.StructuredSerializeOptions -> 'T
            abstract Invoke: value: 'T * ?options: Typescript.StructuredSerializeOptions -> 'T

        [<Import("@cloudflare/workers-types", "SubtleCryptoEncryptAlgorithm")>]
        type SubtleCryptoEncryptAlgorithm =
            abstract label: option<U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>> with get, set
            abstract length: option<float> with get, set
            abstract counter: option<U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>> with get, set
            abstract tagLength: option<float> with get, set
            abstract additionalData: option<U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>> with get, set
            abstract iv: option<U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "MediaTransformationGenerator")>]
        type MediaTransformationGenerator =
            abstract output: ?output: MediaTransformationOutputOptions -> MediaTransformationResult

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Pipecat_Ai_Smart_Turn_V2")>]
        type BaseAiCfPipecatAiSmartTurnV2 =
            abstract postProcessedOutputs: AiCfPipecatAiSmartTurnV2Output with get, set
            abstract inputs: AiCfPipecatAiSmartTurnV2Input with get, set

        [<Import("@cloudflare/workers-types", "MediaTransformer")>]
        type MediaTransformer =
            abstract output: ?output: MediaTransformationOutputOptions -> MediaTransformationResult
            abstract transform: ?transform: MediaTransformationInputOptions -> MediaTransformationGenerator

        [<Import("@cloudflare/workers-types", "ResponseInputImageContent")>]
        type ResponseInputImageContent =
            [<CompiledName("image_url")>]
            abstract imageUrl: option<D1SessionBookmark> with get, set

            abstract detail: option<ResponseInputImageContent.Detail> with get, set

            [<CompiledName("type")>]
            abstract ``type``: ResponseInputImageContent.Type with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionContentPartRefusal")>]
        type ChatCompletionContentPartRefusal =
            abstract refusal: D1SessionBookmark with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionContentPartRefusal.Type with get, set

        [<Import("@cloudflare/workers-types", "LoopbackServiceStub")>]
        type LoopbackServiceStub<'T when 'T :> Rpc.WorkerEntrypointBranded> =
            abstract Invoke:
                opts: LoopbackServiceStub.LoopbackServiceStub.Opts -> LoopbackServiceStub.LoopbackServiceStub

            abstract Invoke:
                opts: LoopbackServiceStub.LoopbackServiceStub.Opts -> LoopbackServiceStub.LoopbackServiceStub

            abstract connect: address: U2<SocketAddress, D1SessionBookmark> * ?options: SocketOptions -> Socket

            abstract fetch:
                input:
                    U3<
                        Typescript.Request<option<obj>, U2<RequestInitCfProperties, LoopbackServiceStub.Fetch.Input>>,
                        URL,
                        D1SessionBookmark
                     > *
                ?init: Typescript.RequestInit<U2<RequestInitCfProperties, LoopbackServiceStub.Fetch.Init>> ->
                    Promise<Typescript.Response>

            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke:
                [<ParamArray>] args: LoopbackServiceStub.LoopbackServiceStub.Args ->
                    U2<LoopbackServiceStub.LoopbackServiceStub, U2<LoopbackServiceStub.LoopbackServiceStub, unit>>

        [<Import("@cloudflare/workers-types", "MediaTransformationInputOptions")>]
        type MediaTransformationInputOptions =
            abstract height: option<float> with get, set
            abstract width: option<float> with get, set
            abstract fit: option<MediaTransformationInputOptions.Fit> with get, set

        [<Import("@cloudflare/workers-types", "AutoRAG")>]
        type AutoRAG =
            abstract aiSearch:
                params: AutoRagAiSearchRequest -> Promise<U2<Typescript.Response, AutoRagAiSearchResponse>>

            abstract aiSearch: params: AutoRagAiSearchRequest -> Promise<AutoRagAiSearchResponse>
            abstract aiSearch: params: AutoRagAiSearchRequestStreaming -> Promise<Typescript.Response>
            abstract search: params: AutoRagSearchRequest -> Promise<AutoRagSearchResponse>
            abstract list: unit -> Promise<AutoRagListResponse>

        [<Import("@cloudflare/workers-types", "TraceLog")>]
        type TraceLog =
            abstract message: option<obj> with get
            abstract level: D1SessionBookmark with get
            abstract timestamp: float with get

        [<Import("@cloudflare/workers-types", "VectorizeVectorMutation")>]
        type VectorizeVectorMutation =
            abstract count: float with get, set
            abstract ids: Array<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages")>]
        type AiCfMetaLlama3211BVisionInstructMessages =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set

            abstract tools:
                option<
                    Array<
                        U2<
                            AiCfMetaLlama3211BVisionInstructMessages.Tools,
                            AiCfMetaLlama3211BVisionInstructMessages.Tools
                         >
                     >
                 > with get, set

            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract image: option<U2<AiSentenceSimilarityOutput, AiCfMetaLlama3211BVisionInstructMessages.Image>> with get, set
            abstract messages: Array<AiCfMetaLlama3211BVisionInstructMessages.Messages> with get, set

        [<Import("@cloudflare/workers-types", "TraceItemQueueEventInfo")>]
        type TraceItemQueueEventInfo =
            abstract batchSize: float with get
            abstract queue: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "ToolMessage")>]
        type ToolMessage =
            [<CompiledName("tool_call_id")>]
            abstract toolCallId: D1SessionBookmark with get, set

            abstract content: U2<Array<ChatCompletionContentPartText>, D1SessionBookmark> with get, set
            abstract role: ToolMessage.Role with get, set

        [<Import("@cloudflare/workers-types", "SubtleCryptoSignAlgorithm")>]
        type SubtleCryptoSignAlgorithm =
            abstract saltLength: option<float> with get, set
            abstract dataLength: option<float> with get, set
            abstract hash: option<U2<SubtleCryptoHashAlgorithm, D1SessionBookmark>> with get, set
            abstract name: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type DurableObjectRoutingMode = | [<CompiledName("primary-only")>] DurableObjectRoutingMode

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        type AutoRagListResponse = Array<AutoRagListResponse>

        [<Import("@cloudflare/workers-types", "ChatCompletionToolChoiceAllowedTools")>]
        type ChatCompletionToolChoiceAllowedTools =
            [<CompiledName("allowed_tools")>]
            abstract allowedTools: ChatCompletionToolChoiceAllowedTools.AllowedTools with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionToolChoiceAllowedTools.Type with get, set

        [<Import("@cloudflare/workers-types", "URLPatternInit")>]
        type URLPatternInit =
            abstract baseURL: option<D1SessionBookmark> with get, set
            abstract hash: option<D1SessionBookmark> with get, set
            abstract search: option<D1SessionBookmark> with get, set
            abstract pathname: option<D1SessionBookmark> with get, set
            abstract port: option<D1SessionBookmark> with get, set
            abstract hostname: option<D1SessionBookmark> with get, set
            abstract password: option<D1SessionBookmark> with get, set
            abstract username: option<D1SessionBookmark> with get, set
            abstract protocol: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItemLog")>]
        type AiSearchItemLog =
            abstract errorType: option<D1SessionBookmark> with get, set
            abstract processingTimeMs: option<float> with get, set
            abstract chunkCount: option<float> with get, set
            abstract fileKey: option<D1SessionBookmark> with get, set
            abstract message: D1SessionBookmark with get, set
            abstract action: D1SessionBookmark with get, set
            abstract timestamp: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ResponseOutputText")>]
        type ResponseOutputText =
            abstract logprobs: option<Array<Logprob>> with get, set

            [<CompiledName("type")>]
            abstract ``type``: ResponseOutputText.Type with get, set

            abstract text: D1SessionBookmark with get, set

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRAGInternalError")>]
        type AutoRAGInternalError =
            interface
                inherit Error
            end

        [<Import("@cloudflare/workers-types", "WebSocketRequestResponsePair")>]
        type WebSocketRequestResponsePair =
            [<EmitConstructor>]
            abstract Create: request: D1SessionBookmark * response: D1SessionBookmark -> WebSocketRequestResponsePair

            abstract response: D1SessionBookmark with get
            abstract request: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "DurableObjectNamespaceNewUniqueIdOptions")>]
        type DurableObjectNamespaceNewUniqueIdOptions =
            abstract jurisdiction: option<DurableObjectJurisdiction> with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectTransaction")>]
        type DurableObjectTransaction =
            abstract deleteAlarm: ?options: DurableObjectSetAlarmOptions -> Promise<unit>
            abstract setAlarm: scheduledTime: U2<Date, float> * ?options: DurableObjectSetAlarmOptions -> Promise<unit>
            abstract getAlarm: ?options: DurableObjectGetAlarmOptions -> Promise<option<float>>
            abstract rollback: unit -> unit
            abstract delete: keys: Array<D1SessionBookmark> * ?options: DurableObjectPutOptions -> Promise<float>
            abstract delete: key: D1SessionBookmark * ?options: DurableObjectPutOptions -> Promise<bool>

            abstract put:
                entries: DurableObjectTransaction.Put.Entries * ?options: DurableObjectPutOptions -> Promise<unit>

            abstract put: key: D1SessionBookmark * value: 'T * ?options: DurableObjectPutOptions -> Promise<unit>
            abstract list: ?options: DurableObjectListOptions -> Promise<Map<D1SessionBookmark, 'T>>

            abstract get:
                keys: Array<D1SessionBookmark> * ?options: DurableObjectGetOptions ->
                    Promise<Map<D1SessionBookmark, 'T>>

            abstract get: key: D1SessionBookmark * ?options: DurableObjectGetOptions -> Promise<option<'T>>

        [<Import("@cloudflare/workers-types", "ResponseCustomToolCallOutput")>]
        type ResponseCustomToolCallOutput =
            abstract id: option<D1SessionBookmark> with get, set

            [<CompiledName("type")>]
            abstract ``type``: ResponseCustomToolCallOutput.Type with get, set

            abstract output: U2<Array<ResponseInputContent>, D1SessionBookmark> with get, set

            [<CompiledName("call_id")>]
            abstract callId: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Hyperdrive")>]
        type Hyperdrive =
            abstract database: D1SessionBookmark with get
            abstract password: D1SessionBookmark with get
            abstract user: D1SessionBookmark with get
            abstract port: float with get
            abstract host: D1SessionBookmark with get
            abstract connectionString: D1SessionBookmark with get
            abstract connect: unit -> Socket

        [<Import("@cloudflare/workers-types", "TextDecoderStreamTextDecoderStreamInit")>]
        type TextDecoderStreamTextDecoderStreamInit =
            abstract ignoreBOM: option<bool> with get, set
            abstract fatal: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "BadRequestError")>]
        type BadRequestError =
            inherit StreamError
            abstract name: BadRequestError.Name with get, set

        [<Import("@cloudflare/workers-types", "BlobOptions")>]
        type BlobOptions =
            [<CompiledName("type")>]
            abstract ``type``: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "TestController")>]
        type TestController = interface end

        [<Import("@cloudflare/workers-types", "ResponseInputImage")>]
        type ResponseInputImage =
            [<CompiledName("image_url")>]
            abstract imageUrl: option<D1SessionBookmark> with get, set

            [<CompiledName("type")>]
            abstract ``type``: ResponseInputImage.Type with get, set

            abstract detail: ResponseInputImage.Detail with get, set

        type AiSentenceSimilarityOutput = Array<float>

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesBase")>]
        type IncomingRequestCfPropertiesBase =
            inherit IncomingRequestCfPropertiesBase
            abstract tlsExportedAuthenticator: option<IncomingRequestCfPropertiesExportedAuthenticatorMetadata> with get, set
            /// <example>
            /// "AEAD-AES128-GCM-SHA256"
            /// </example>
            abstract tlsCipher: D1SessionBookmark with get, set
            /// <example>
            /// "TLSv1.3"
            /// </example>
            abstract tlsVersion: D1SessionBookmark with get, set
            /// <example>
            /// "weight=192;exclusive=0;group=3;group-weight=127"
            /// </example>
            abstract requestPriority: D1SessionBookmark with get, set
            /// <example>
            /// "HTTP/2"
            /// </example>
            abstract httpProtocol: D1SessionBookmark with get, set
            /// <example>
            /// 3
            /// </example>
            abstract edgeRequestKeepAliveStatus: IncomingRequestCfPropertiesBase.EdgeRequestKeepAliveStatus with get, set
            /// <example>
            /// "DFW"
            /// </example>
            abstract colo: D1SessionBookmark with get, set
            /// <example>
            /// 22
            /// </example>
            abstract clientTcpRtt: option<float> with get, set
            /// <example>
            /// "gzip, deflate, br"
            /// </example>
            abstract clientAcceptEncoding: option<D1SessionBookmark> with get, set
            /// <example>
            /// "Google Cloud"
            /// </example>
            abstract asOrganization: option<D1SessionBookmark> with get, set
            /// <example>
            /// 395747
            /// </example>
            abstract asn: option<float> with get, set

        [<Import("@cloudflare/workers-types", "R2MultipartOptions")>]
        type R2MultipartOptions =
            abstract ssecKey: option<U2<ArrayBuffer, D1SessionBookmark>> with get, set
            abstract storageClass: option<D1SessionBookmark> with get, set
            abstract customMetadata: option<R2MultipartOptions.CustomMetadata> with get, set
            abstract httpMetadata: option<U2<R2HTTPMetadata, Headers>> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchListJobsResponse")>]
        type AiSearchListJobsResponse =
            [<CompiledName("result_info")>]
            abstract resultInfo: option<AiSearchListJobsResponse.ResultInfo> with get, set

            abstract result: Array<AiSearchJobInfo> with get, set

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesGeographicInformation")>]
        type IncomingRequestCfPropertiesGeographicInformation =
            /// <example>
            /// "635"
            /// </example>
            abstract metroCode: option<D1SessionBookmark> with get, set
            /// <example>
            /// "TX"
            /// </example>
            abstract regionCode: option<D1SessionBookmark> with get, set
            /// <example>
            /// "Texas"
            /// </example>
            abstract region: option<D1SessionBookmark> with get, set
            /// <example>
            /// "America/Chicago"
            /// </example>
            abstract timezone: option<D1SessionBookmark> with get, set
            /// <example>
            /// "-97.74260"
            /// </example>
            abstract longitude: option<D1SessionBookmark> with get, set
            /// <example>
            /// "30.27130"
            /// </example>
            abstract latitude: option<D1SessionBookmark> with get, set
            /// <example>
            /// "78701"
            /// </example>
            abstract postalCode: option<D1SessionBookmark> with get, set
            /// <example>
            /// "Austin"
            /// </example>
            abstract city: option<D1SessionBookmark> with get, set
            /// <example>
            /// "AN"
            /// </example>
            abstract continent: option<ContinentCode> with get, set
            /// <example>
            /// "1"
            /// </example>
            abstract isEUCountry: option<IncomingRequestCfPropertiesGeographicInformation.IsEUCountry> with get, set
            /// <example>
            /// "GB"
            /// </example>
            abstract country: option<IncomingRequestCfPropertiesGeographicInformation.Country> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Baai_Bge_Small_En_V1_5")>]
        type BaseAiCfBaaiBgeSmallEnV15 =
            abstract postProcessedOutputs: AiCfBaaiBgeSmallEnV15Output with get, set
            abstract inputs: AiCfBaaiBgeSmallEnV15Input with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type StreamPaginationComparison =
            | [<CompiledName("eq")>] Eq
            | [<CompiledName("gt")>] Gt
            | [<CompiledName("gte")>] Gte
            | [<CompiledName("lt")>] Lt
            | [<CompiledName("lte")>] Lte

        [<Import("@cloudflare/workers-types", "DurableObjectId")>]
        type DurableObjectId =
            abstract jurisdiction: option<D1SessionBookmark> with get
            abstract name: option<D1SessionBookmark> with get
            abstract equals: other: DurableObjectId -> bool
            abstract toString: unit -> D1SessionBookmark

        [<Import("@cloudflare/workers-types", "WebSocketEventMap")>]
        type WebSocketEventMap =
            abstract error: ErrorEvent with get, set

            [<CompiledName("open")>]
            abstract ``open``: Event with get, set

            abstract message: MessageEvent<option<obj>> with get, set
            abstract close: CloseEvent with get, set

        [<Import("@cloudflare/workers-types", "RateLimitOutcome")>]
        type RateLimitOutcome =
            abstract success: bool with get, set

        [<Import("@cloudflare/workers-types", "EventTargetAddEventListenerOptions")>]
        type EventTargetAddEventListenerOptions =
            abstract signal: option<AbortSignal> with get, set
            abstract once: option<bool> with get, set
            abstract passive: option<bool> with get, set
            abstract capture: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "ContainerDirectorySnapshotOptions")>]
        type ContainerDirectorySnapshotOptions =
            abstract name: option<D1SessionBookmark> with get, set
            abstract dir: D1SessionBookmark with get, set

        type R2Objects = U2<R2Objects, R2Objects>

        [<Import("@cloudflare/workers-types", "SocketOptions")>]
        type SocketOptions =
            abstract highWaterMark: option<float> with get, set
            abstract allowHalfOpen: bool with get, set
            abstract secureTransport: option<D1SessionBookmark> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type __WORKFLOW_ENTRYPOINT_BRAND = | __WORKFLOW_ENTRYPOINT_BRAND

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages")>]
        type AiCfAisingaporeGemmaSeaLionV427BItMessages =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfAisingaporeGemmaSeaLionV427BItJSONMode1> with get, set

            abstract tools:
                option<
                    Array<
                        U2<
                            AiCfAisingaporeGemmaSeaLionV427BItMessages.Tools,
                            AiCfAisingaporeGemmaSeaLionV427BItMessages.Tools
                         >
                     >
                 > with get, set

            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: Array<AiCfAisingaporeGemmaSeaLionV427BItMessages.Messages> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Deepgram_Nova_3_Output")>]
        type AiCfDeepgramNova3Output =
            abstract results: option<AiCfDeepgramNova3Output.Results> with get, set

        [<Import("@cloudflare/workers-types", "WorkerStubEntrypointOptions")>]
        type WorkerStubEntrypointOptions =
            abstract limits: option<WorkerdResourceLimits> with get, set
            abstract props: option<obj> with get, set

        [<Import("@cloudflare/workers-types", "KVNamespaceListOptions")>]
        type KVNamespaceListOptions =
            abstract cursor: option<D1SessionBookmark> with get, set
            abstract prefix: option<D1SessionBookmark> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "R2ObjectBody")>]
        type R2ObjectBody =
            inherit R2Object
            abstract bodyUsed: bool with get
            abstract body: ReadableStream<option<obj>> with get
            abstract blob: unit -> Promise<Blob>
            abstract json: unit -> Promise<'T>
            abstract text: unit -> Promise<D1SessionBookmark>
            abstract bytes: unit -> Promise<Uint8Array<ArrayBufferLike>>
            abstract arrayBuffer: unit -> Promise<ArrayBuffer>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Text_Completion_Response")>]
        type AiCfAisingaporeGemmaSeaLionV427BItTextCompletionResponse =
            abstract usage: option<AiCfAisingaporeGemmaSeaLionV427BItTextCompletionResponse.Usage> with get, set
            abstract choices: option<Array<AiCfAisingaporeGemmaSeaLionV427BItTextCompletionResponse.Choices>> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract created: option<float> with get, set
            abstract object: option<AiCfAisingaporeGemmaSeaLionV427BItTextCompletionResponse.Object> with get, set
            abstract id: option<D1SessionBookmark> with get, set

        type AiCfUnumUformGen2Qwen500MInput =
            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract image: U2<AiSentenceSimilarityOutput, AiCfUnumUformGen2Qwen500MInput.Image> with get, set

            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract raw: option<bool> with get, set
            abstract prompt: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "EventTarget")>]
        type EventTarget<'EventMap when 'EventMap :> EventTarget> =
            [<EmitConstructor>]
            abstract Create: unit -> EventTarget

            abstract dispatchEvent: event: proptypekey<'EventMap, keyof<'EventMap>> -> bool

            abstract removeEventListener:
                ``type``: 'Type * handler: Typescript.Body * ?options: U2<EventTargetEventListenerOptions, bool> -> unit

            abstract addEventListener:
                ``type``: 'Type * handler: Typescript.Body * ?options: U2<EventTargetAddEventListenerOptions, bool> ->
                    unit

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type QueueContentType =
            | [<CompiledName("text")>] Text
            | [<CompiledName("bytes")>] Bytes
            | [<CompiledName("json")>] Json
            | [<CompiledName("v8")>] V8

        type AiSearchSearchRequest = U2<AiSearchSearchRequest, AiSearchSearchRequest>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Prompt")>]
        type AiCfMetaLlama3211BVisionInstructPrompt =
            abstract lora: option<D1SessionBookmark> with get, set

            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set
            abstract image: option<U2<AiSentenceSimilarityOutput, AiCfMetaLlama3211BVisionInstructPrompt.Image>> with get, set
            abstract prompt: D1SessionBookmark with get, set

        type AiCfOpenaiWhisperTinyEnInput =
            abstract audio: AiSentenceSimilarityOutput with get, set

        [<Import("@cloudflare/workers-types", "ResponsePrompt")>]
        type ResponsePrompt =
            abstract version: option<D1SessionBookmark> with get, set
            abstract variables: option<ResponsePrompt.Variables> with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiOptions")>]
        type AiOptions =
            abstract signal: option<AbortSignal> with get, set
            abstract extraHeaders: option<obj> with get, set
            abstract prefix: option<D1SessionBookmark> with get, set
            abstract returnRawResponse: option<bool> with get, set
            abstract gateway: option<GatewayOptions> with get, set
            abstract tags: option<Array<D1SessionBookmark>> with get, set
            abstract websocket: option<bool> with get, set
            abstract queueRequest: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "KVNamespacePutOptions")>]
        type KVNamespacePutOptions =
            abstract metadata: option<obj> with get, set
            abstract expirationTtl: option<float> with get, set
            abstract expiration: option<float> with get, set

        type ChatCompletionsInput = U3<ChatCompletionsInput, ChatCompletionsInput, ChatCompletionsInput>

        [<Import("@cloudflare/workers-types", "AiGatewayPatchLog")>]
        type AiGatewayPatchLog =
            abstract metadata: option<AiGatewayPatchLog.Metadata> with get, set
            abstract feedback: option<AiGatewayPatchLog.Feedback> with get, set
            abstract score: option<float> with get, set

        [<Import("@cloudflare/workers-types", "EndTag")>]
        type EndTag =
            abstract name: D1SessionBookmark with get, set
            abstract remove: unit -> EndTag

            abstract after:
                content: U3<ReadableStream<option<obj>>, Typescript.Response, D1SessionBookmark> *
                ?options: ContentOptions ->
                    EndTag

            abstract before:
                content: U3<ReadableStream<option<obj>>, Typescript.Response, D1SessionBookmark> *
                ?options: ContentOptions ->
                    EndTag

        [<Import("@cloudflare/workers-types", "InvalidURLError")>]
        type InvalidURLError =
            inherit StreamError
            abstract name: InvalidURLError.Name with get, set

        [<Import("@cloudflare/workers-types", "TraceItemHibernatableWebSocketEventInfoError")>]
        type TraceItemHibernatableWebSocketEventInfoError =
            abstract webSocketEventType: D1SessionBookmark with get

        type ClearTimeout =
            abstract Invoke: ?timeoutId: float -> unit
            abstract Invoke: ?id: float -> unit

        [<Import("@cloudflare/workers-types", "ExportedHandlerScheduledHandler")>]
        type ExportedHandlerScheduledHandler<'Props, 'Env> =
            abstract Invoke:
                controller: ScheduledController * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        type AiCfBaaiBgeM3Input =
            U3<AiCfBaaiBgeM3InputQueryAndContexts, AiCfBaaiBgeM3InputEmbedding, AiCfBaaiBgeM3Input>

        [<Import("@cloudflare/workers-types", "EventListener")>]
        type EventListener<'EventType when 'EventType :> Event> =
            abstract Invoke: event: 'EventType -> unit

        [<Import("@cloudflare/workers-types", "AiSearchMultiChatCompletionsResponse")>]
        type AiSearchMultiChatCompletionsResponse =
            abstract errors: option<Array<AiSearchMultiSearchError>> with get, set
            abstract chunks: Array<AiSearchMultiSearchChunk> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "IdentityTransformStream")>]
        type IdentityTransformStream =
            interface
                [<EmitConstructor>]
                abstract Create: ?queuingStrategy: IdentityTransformStreamQueuingStrategy -> IdentityTransformStream

                inherit TransformStream<
                    U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>,
                    Uint8Array<ArrayBufferLike>,
                    'IdentityTransformStream
                 ><U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>, Uint8Array<ArrayBufferLike>>
            end

        [<Import("@cloudflare/workers-types", "TraceItemHibernatableWebSocketEventInfoClose")>]
        type TraceItemHibernatableWebSocketEventInfoClose =
            abstract wasClean: bool with get
            abstract code: float with get
            abstract webSocketEventType: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "EventContext")>]
        type EventContext<'Data, 'P, 'Env when 'P :> D1SessionBookmark> =
            abstract data: 'Data with get, set
            abstract params: EventContext.Params with get, set
            abstract env: EventContext.Env with get, set
            abstract functionPath: D1SessionBookmark with get, set
            abstract request: Typescript.Request<option<obj>, EventContext.Request> with get, set

            abstract next:
                ?input: RequestInfo * ?init: Typescript.RequestInit<U2<RequestInitCfProperties, EventContext.Next.Init>> ->
                    Promise<Typescript.Response>

            abstract passThroughOnException: unit -> unit
            abstract waitUntil: promise: Promise<option<obj>> -> unit

        [<Import("@cloudflare/workers-types", "TextEncoder")>]
        type TextEncoder =
            [<EmitConstructor>]
            abstract Create: unit -> TextEncoder

            abstract encoding: D1SessionBookmark with get

            abstract encodeInto:
                input: D1SessionBookmark * buffer: Uint8Array<ArrayBufferLike> -> Typescript.TextEncoderEncodeIntoResult

            abstract encode: ?input: D1SessionBookmark -> Uint8Array<ArrayBufferLike>

        type AiCfQwenQwq32BInput = U2<AiCfQwenQwq32BPrompt, AiCfQwenQwq32BMessages>

        [<Import("@cloudflare/workers-types", "BasicImageTransformationsGravityCoordinates")>]
        type BasicImageTransformationsGravityCoordinates =
            abstract mode: option<BasicImageTransformationsGravityCoordinates.Mode> with get, set
            abstract y: option<float> with get, set
            abstract x: option<float> with get, set

        [<Import("@cloudflare/workers-types", "UsageTags")>]
        type UsageTags =
            [<CompiledName("total_tokens")>]
            abstract totalTokens: float with get, set

            [<CompiledName("completion_tokens")>]
            abstract completionTokens: float with get, set

            [<CompiledName("prompt_tokens")>]
            abstract promptTokens: float with get, set

        [<Import("@cloudflare/workers-types", "QueueSendBatchOptions")>]
        type QueueSendBatchOptions =
            abstract delaySeconds: option<float> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchChatCompletionsResponse")>]
        type AiSearchChatCompletionsResponse =
            abstract chunks: Array<AiSearchChatCompletionsResponse.Chunks> with get, set
            abstract choices: Array<AiSearchChatCompletionsResponse.Choices> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract object: option<D1SessionBookmark> with get, set
            abstract id: option<D1SessionBookmark> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "UserMessage")>]
        type UserMessage =
            abstract name: option<D1SessionBookmark> with get, set
            abstract content: U2<Array<UserMessageContentPart>, D1SessionBookmark> with get, set
            abstract role: UserMessage.Role with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionsCommonOptions")>]
        type ChatCompletionsCommonOptions =
            abstract functions: option<Array<FunctionDefinition>> with get, set

            [<CompiledName("function_call")>]
            abstract functionCall:
                option<U2<ChatCompletionsCommonOptions.FunctionCall, ChatCompletionsCommonOptions.FunctionCall>> with get, set

            [<CompiledName("web_search_options")>]
            abstract webSearchOptions: option<WebSearchOptions> with get, set

            abstract user: option<D1SessionBookmark> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract tools: option<Array<ChatCompletionTool>> with get, set

            [<CompiledName("tool_choice")>]
            abstract toolChoice:
                option<
                    U4<
                        ChatCompletionsCommonOptions.ToolChoice,
                        ChatCompletionToolChoiceFunction,
                        ChatCompletionToolChoiceCustom,
                        ChatCompletionToolChoiceAllowedTools
                     >
                 > with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("stream_options")>]
            abstract streamOptions: option<ChatCompletionsStreamOptions> with get, set

            abstract stream: option<bool> with get, set
            abstract store: option<bool> with get, set
            abstract stop: option<U2<Array<D1SessionBookmark>, D1SessionBookmark>> with get, set

            [<CompiledName("service_tier")>]
            abstract serviceTier: option<ChatCompletionsCommonOptions.ServiceTier> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<ResponseFormat> with get, set

            [<CompiledName("chat_template_kwargs")>]
            abstract chatTemplateKwargs: option<ChatTemplateKwargs> with get, set

            [<CompiledName("reasoning_effort")>]
            abstract reasoningEffort: option<ChatCompletionsCommonOptions.ReasoningEffort> with get, set

            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            abstract prediction: option<PredictionContent> with get, set

            [<CompiledName("parallel_tool_calls")>]
            abstract parallelToolCalls: option<bool> with get, set

            abstract n: option<float> with get, set
            abstract modalities: option<Array<ChatCompletionsCommonOptions.Modalities>> with get, set
            abstract metadata: option<ChatCompletionsCommonOptions.Metadata> with get, set

            [<CompiledName("max_completion_tokens")>]
            abstract maxCompletionTokens: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            [<CompiledName("top_logprobs")>]
            abstract topLogprobs: option<float> with get, set

            abstract logprobs: option<bool> with get, set

            [<CompiledName("logit_bias")>]
            abstract logitBias: option<ChatCompletionsCommonOptions.LogitBias> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            abstract audio: option<AudioParams> with get, set
            abstract model: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesTLSClientAuth")>]
        type IncomingRequestCfPropertiesTLSClientAuth =
            /// <example>
            /// "Dec 22 19:39:00 2018 GMT"
            /// </example>
            abstract certNotAfter: D1SessionBookmark with get, set
            /// <example>
            /// "Dec 22 19:39:00 2018 GMT"
            /// </example>
            abstract certNotBefore: D1SessionBookmark with get, set
            /// <example>
            /// "acf77cf37b4156a2708e34c4eb755f9b5dbbe5ebb55adfec8f11493438d19e6ad3f157f81fa3b98278453d5652b0c1fd1d71e5695ae4d709803a4d3f39de9dea"
            /// </example>
            abstract certFingerprintSHA256: D1SessionBookmark with get, set
            /// <example>
            /// "6b9109f323999e52259cda7373ff0b4d26bd232e"
            /// </example>
            abstract certFingerprintSHA1: D1SessionBookmark with get, set
            /// <example>
            /// "BB:AF:7E:02:3D:FA:A6:F1:3C:84:8E:AD:EE:38:98:EC:D9:32:32:D4"
            /// </example>
            abstract certIssuerSKI: D1SessionBookmark with get, set
            /// <example>
            /// "BB:AF:7E:02:3D:FA:A6:F1:3C:84:8E:AD:EE:38:98:EC:D9:32:32:D4"
            /// </example>
            abstract certSKI: D1SessionBookmark with get, set
            /// <example>
            /// "2489002934BDFEA34"
            /// </example>
            abstract certIssuerSerial: D1SessionBookmark with get, set
            /// <example>
            /// "00936EACBE07F201DF"
            /// </example>
            abstract certSerial: D1SessionBookmark with get, set
            abstract certSubjectDNLegacy: D1SessionBookmark with get, set
            abstract certIssuerDNLegacy: D1SessionBookmark with get, set
            /// <example>
            /// "CN=*.cloudflareaccess.com, C=US, ST=Texas, L=Austin, O=Cloudflare"
            /// </example>
            abstract certSubjectDNRFC2253: D1SessionBookmark with get, set
            /// <example>
            /// "CN=cloudflareaccess.com, C=US, ST=Texas, L=Austin, O=Cloudflare"
            /// </example>
            abstract certIssuerDNRFC2253: D1SessionBookmark with get, set
            /// <example>
            /// "CN=*.cloudflareaccess.com, C=US, ST=Texas, L=Austin, O=Cloudflare"
            /// </example>
            abstract certSubjectDN: D1SessionBookmark with get, set
            /// <example>
            /// "CN=cloudflareaccess.com, C=US, ST=Texas, L=Austin, O=Cloudflare"
            /// </example>
            abstract certIssuerDN: D1SessionBookmark with get, set
            abstract certRevoked: IncomingRequestCfPropertiesTLSClientAuth.CertRevoked with get, set
            /// <example>
            /// "FAILED:self signed certificate"
            /// </example>
            abstract certVerified: IncomingRequestCfPropertiesTLSClientAuth.CertVerified with get, set
            abstract certPresented: IncomingRequestCfPropertiesTLSClientAuth.CertPresented with get, set

        [<Import("@cloudflare/workers-types", "StreamUrlUploadParams")>]
        type StreamUrlUploadParams =
            abstract watermarkId: option<D1SessionBookmark> with get, set
            abstract thumbnailTimestampPct: option<float> with get, set
            abstract scheduledDeletion: option<D1SessionBookmark> with get, set
            abstract requireSignedURLs: option<bool> with get, set
            abstract meta: option<StreamUrlUploadParams.Meta> with get, set
            abstract creator: option<D1SessionBookmark> with get, set
            abstract allowedOrigins: option<Array<D1SessionBookmark>> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type VectorizeDistanceMetric =
            | [<CompiledName("euclidean")>] Euclidean
            | [<CompiledName("cosine")>] Cosine
            | [<CompiledName("dot-product")>] DotProduct

        [<Import("@cloudflare/workers-types", "EventTargetHandlerObject")>]
        type EventTargetHandlerObject =
            abstract handleEvent: event: Event -> option<obj>

        [<Import("@cloudflare/workers-types", "StreamVideos")>]
        type StreamVideos =
            abstract list: ?params: StreamVideosListParams -> Promise<Array<StreamVideo>>

        [<Import("@cloudflare/workers-types", "WorkflowInstance")>]
        type WorkflowInstance =
            abstract id: D1SessionBookmark with get, set

            abstract sendEvent:
                ``{
    type,
    payload,
  }``:
                    WorkflowInstance.SendEvent.``{
    type,
    payload,
  }`` ->
                    Promise<unit>

            abstract status: unit -> Promise<InstanceStatus>
            abstract restart: unit -> Promise<unit>
            abstract terminate: unit -> Promise<unit>
            abstract resume: unit -> Promise<unit>
            abstract pause: unit -> Promise<unit>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type StreamDownloadStatus =
            | [<CompiledName("ready")>] Ready
            | [<CompiledName("inprogress")>] Inprogress
            | [<CompiledName("error")>] Error

        [<Import("@cloudflare/workers-types", "AiTextGenerationToolLegacyInput")>]
        type AiTextGenerationToolLegacyInput =
            abstract parameters: option<AiTextGenerationToolLegacyInput.Parameters> with get, set
            abstract description: D1SessionBookmark with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionCustomTool")>]
        type ChatCompletionCustomTool =
            abstract custom: ChatCompletionCustomTool.Custom with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionCustomTool.Type with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Pipecat_Ai_Smart_Turn_V2_Output")>]
        type AiCfPipecatAiSmartTurnV2Output =
            abstract probability: option<float> with get, set

            [<CompiledName("is_complete")>]
            abstract isComplete: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "CompletionTokensDetails")>]
        type CompletionTokensDetails =
            [<CompiledName("rejected_prediction_tokens")>]
            abstract rejectedPredictionTokens: option<float> with get, set

            [<CompiledName("accepted_prediction_tokens")>]
            abstract acceptedPredictionTokens: option<float> with get, set

            [<CompiledName("audio_tokens")>]
            abstract audioTokens: option<float> with get, set

            [<CompiledName("reasoning_tokens")>]
            abstract reasoningTokens: option<float> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AIGatewayProviders =
            | [<CompiledName("workers-ai")>] WorkersAi
            | [<CompiledName("anthropic")>] Anthropic
            | [<CompiledName("aws-bedrock")>] AwsBedrock
            | [<CompiledName("azure-openai")>] AzureOpenai
            | [<CompiledName("google-vertex-ai")>] GoogleVertexAi
            | [<CompiledName("huggingface")>] Huggingface
            | [<CompiledName("openai")>] Openai
            | [<CompiledName("perplexity-ai")>] PerplexityAi
            | [<CompiledName("replicate")>] Replicate
            | [<CompiledName("groq")>] Groq
            | [<CompiledName("cohere")>] Cohere
            | [<CompiledName("google-ai-studio")>] GoogleAiStudio
            | [<CompiledName("mistral")>] Mistral
            | [<CompiledName("grok")>] Grok
            | [<CompiledName("openrouter")>] Openrouter
            | [<CompiledName("deepseek")>] Deepseek
            | [<CompiledName("cerebras")>] Cerebras
            | [<CompiledName("cartesia")>] Cartesia
            | [<CompiledName("elevenlabs")>] Elevenlabs
            | [<CompiledName("adobe-firefly")>] AdobeFirefly

        [<Import("@cloudflare/workers-types", "EmailSendResult")>]
        type EmailSendResult =
            abstract messageId: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectNamespaceGetDurableObjectOptions")>]
        type DurableObjectNamespaceGetDurableObjectOptions =
            abstract routingMode: option<DurableObjectRoutingMode> with get, set
            abstract locationHint: option<DurableObjectLocationHint> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1")>]
        type AiCfQwenQwen330BA3BFp8Messages1 =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfQwenQwen330BA3BFp8JSONMode3> with get, set

            abstract tools:
                option<Array<U2<AiCfQwenQwen330BA3BFp8Messages1.Tools, AiCfQwenQwen330BA3BFp8Messages1.Tools>>> with get, set

            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: Array<AiCfQwenQwen330BA3BFp8Messages1.Messages> with get, set

        [<Import("@cloudflare/workers-types", "BaseAiSummarization")>]
        type BaseAiSummarization =
            abstract postProcessedOutputs: AiSummarizationOutput with get, set
            abstract inputs: AiSummarizationInput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner")>]
        type AiCfMetaLlama4Scout17B16EInstructMessagesInner =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfMetaLlama4Scout17B16EInstructJSONMode> with get, set

            abstract tools:
                option<
                    Array<
                        U2<
                            AiCfMetaLlama4Scout17B16EInstructMessagesInner.Tools,
                            AiCfMetaLlama4Scout17B16EInstructMessagesInner.Tools
                         >
                     >
                 > with get, set

            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: Array<AiCfMetaLlama4Scout17B16EInstructMessagesInner.Messages> with get, set

        [<Import("@cloudflare/workers-types", "BaseAiImageToText")>]
        type BaseAiImageToText =
            abstract postProcessedOutputs: AiImageToTextOutput with get, set
            abstract inputs: AiImageToTextInput with get, set

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRAGUnauthorizedError")>]
        type AutoRAGUnauthorizedError =
            interface
                inherit Error
            end

        [<Import("@cloudflare/workers-types", "ResponseFormatText")>]
        type ResponseFormatText =
            [<CompiledName("type")>]
            abstract ``type``: ResponseFormatText.Type with get, set

        [<Import("@cloudflare/workers-types", "ServiceWorkerGlobalScope")>]
        type ServiceWorkerGlobalScope =
            inherit WorkerGlobalScope

            [<CompiledName("HTMLRewriter")>]
            abstract hTMLRewriter: ServiceWorkerGlobalScope.HTMLRewriter with get, set

            [<CompiledName("IdentityTransformStream")>]
            abstract identityTransformStream: ServiceWorkerGlobalScope.IdentityTransformStream with get, set

            [<CompiledName("FixedLengthStream")>]
            abstract fixedLengthStream: ServiceWorkerGlobalScope.FixedLengthStream with get, set

            [<CompiledName("Cache")>]
            abstract cache: ServiceWorkerGlobalScope.Cache with get, set

            [<CompiledName("CacheStorage")>]
            abstract cacheStorage: ServiceWorkerGlobalScope.CacheStorage with get, set

            [<CompiledName("CryptoKey")>]
            abstract cryptoKey: ServiceWorkerGlobalScope.CryptoKey with get, set

            [<CompiledName("SubtleCrypto")>]
            abstract subtleCrypto: ServiceWorkerGlobalScope.SubtleCrypto with get, set

            [<CompiledName("Crypto")>]
            abstract crypto: ServiceWorkerGlobalScope.Crypto with get, set

            [<CompiledName("FormData")>]
            abstract formData: ServiceWorkerGlobalScope.FormData with get, set

            [<CompiledName("File")>]
            abstract file: ServiceWorkerGlobalScope.File with get, set

            [<CompiledName("Blob")>]
            abstract blob: ServiceWorkerGlobalScope.Blob with get, set

            [<CompiledName("URLPattern")>]
            abstract uRLPattern: ServiceWorkerGlobalScope.URLPattern with get, set

            [<CompiledName("URLSearchParams")>]
            abstract uRLSearchParams: ServiceWorkerGlobalScope.URLSearchParams with get, set

            abstract URL: ServiceWorkerGlobalScope.URL with get, set

            [<CompiledName("TextEncoder")>]
            abstract textEncoder: ServiceWorkerGlobalScope.TextEncoder with get, set

            [<CompiledName("TextDecoder")>]
            abstract textDecoder: ServiceWorkerGlobalScope.TextDecoder with get, set

            [<CompiledName("AbortSignal")>]
            abstract abortSignal: ServiceWorkerGlobalScope.AbortSignal with get, set

            [<CompiledName("AbortController")>]
            abstract abortController: ServiceWorkerGlobalScope.AbortController with get, set

            [<CompiledName("WebSocketRequestResponsePair")>]
            abstract webSocketRequestResponsePair: ServiceWorkerGlobalScope.WebSocketRequestResponsePair with get, set

            [<CompiledName("WebSocketPair")>]
            abstract webSocketPair: ServiceWorkerGlobalScope.WebSocketPair with get, set

            [<CompiledName("WebSocket")>]
            abstract webSocket: ServiceWorkerGlobalScope.WebSocket with get, set

            [<CompiledName("Response")>]
            abstract response: ServiceWorkerGlobalScope.Response with get, set

            [<CompiledName("Request")>]
            abstract request: ServiceWorkerGlobalScope.Request with get, set

            [<CompiledName("Body")>]
            abstract body: ServiceWorkerGlobalScope.Body with get, set

            [<CompiledName("Headers")>]
            abstract headers: ServiceWorkerGlobalScope.Headers with get, set

            [<CompiledName("TextDecoderStream")>]
            abstract textDecoderStream: ServiceWorkerGlobalScope.TextDecoderStream with get, set

            [<CompiledName("TextEncoderStream")>]
            abstract textEncoderStream: ServiceWorkerGlobalScope.TextEncoderStream with get, set

            [<CompiledName("DecompressionStream")>]
            abstract decompressionStream: ServiceWorkerGlobalScope.DecompressionStream with get, set

            [<CompiledName("CompressionStream")>]
            abstract compressionStream: ServiceWorkerGlobalScope.CompressionStream with get, set

            [<CompiledName("EventSource")>]
            abstract eventSource: ServiceWorkerGlobalScope.EventSource with get, set

            [<CompiledName("ErrorEvent")>]
            abstract errorEvent: ServiceWorkerGlobalScope.ErrorEvent with get, set

            [<CompiledName("CountQueuingStrategy")>]
            abstract countQueuingStrategy: ServiceWorkerGlobalScope.CountQueuingStrategy with get, set

            [<CompiledName("ByteLengthQueuingStrategy")>]
            abstract byteLengthQueuingStrategy: ServiceWorkerGlobalScope.ByteLengthQueuingStrategy with get, set

            [<CompiledName("TransformStream")>]
            abstract transformStream: ServiceWorkerGlobalScope.TransformStream with get, set

            [<CompiledName("WritableStreamDefaultWriter")>]
            abstract writableStreamDefaultWriter: ServiceWorkerGlobalScope.WritableStreamDefaultWriter with get, set

            [<CompiledName("WritableStream")>]
            abstract writableStream: ServiceWorkerGlobalScope.WritableStream with get, set

            [<CompiledName("ReadableStream")>]
            abstract readableStream: ServiceWorkerGlobalScope.ReadableStream with get, set

            [<CompiledName("ReadableStreamBYOBReader")>]
            abstract readableStreamBYOBReader: ServiceWorkerGlobalScope.ReadableStreamBYOBReader with get, set

            [<CompiledName("ReadableStreamDefaultReader")>]
            abstract readableStreamDefaultReader: ServiceWorkerGlobalScope.ReadableStreamDefaultReader with get, set

            [<CompiledName("CloseEvent")>]
            abstract closeEvent: ServiceWorkerGlobalScope.CloseEvent with get, set

            [<CompiledName("MessageEvent")>]
            abstract messageEvent: ServiceWorkerGlobalScope.MessageEvent with get, set

            [<CompiledName("ScheduledEvent")>]
            abstract scheduledEvent: ServiceWorkerGlobalScope.ScheduledEvent with get, set

            [<CompiledName("TraceEvent")>]
            abstract traceEvent: ServiceWorkerGlobalScope.TraceEvent with get, set

            [<CompiledName("TailEvent")>]
            abstract tailEvent: ServiceWorkerGlobalScope.TailEvent with get, set

            [<CompiledName("FetchEvent")>]
            abstract fetchEvent: ServiceWorkerGlobalScope.FetchEvent with get, set

            [<CompiledName("PromiseRejectionEvent")>]
            abstract promiseRejectionEvent: ServiceWorkerGlobalScope.PromiseRejectionEvent with get, set

            [<CompiledName("CustomEvent")>]
            abstract customEvent: ServiceWorkerGlobalScope.CustomEvent with get, set

            [<CompiledName("ExtendableEvent")>]
            abstract extendableEvent: ServiceWorkerGlobalScope.ExtendableEvent with get, set

            [<CompiledName("Event")>]
            abstract event: ServiceWorkerGlobalScope.Event with get, set

            abstract origin: D1SessionBookmark with get

            [<CompiledName("Cloudflare")>]
            abstract cloudflare: Cloudflare with get, set

            abstract performance: Performance with get, set
            abstract scheduler: Scheduler with get, set
            abstract caches: CacheStorage with get, set
            abstract crypto: Crypto with get, set
            abstract self: ServiceWorkerGlobalScope with get, set

            [<CompiledName("WorkerGlobalScope")>]
            abstract workerGlobalScope: ServiceWorkerGlobalScope.WorkerGlobalScope with get, set

            [<CompiledName("DOMException")>]
            abstract dOMException: ServiceWorkerGlobalScope.DOMException with get, set

            abstract fetch:
                input:
                    U3<
                        Typescript.Request<
                            option<obj>,
                            U2<RequestInitCfProperties, ServiceWorkerGlobalScope.Fetch.Input>
                         >,
                        URL,
                        D1SessionBookmark
                     > *
                ?init: Typescript.RequestInit<RequestInitCfProperties> ->
                    Promise<Typescript.Response>

            abstract reportError: ?error: obj -> unit
            abstract structuredClone: value: 'T * ?options: Typescript.StructuredSerializeOptions -> 'T
            abstract queueMicrotask: task: Function -> unit
            abstract clearInterval: ?timeoutId: float -> unit

            abstract setInterval:
                callback: ServiceWorkerGlobalScope.SetInterval.Callback * ?msDelay: float * [<ParamArray>] args: 'Args ->
                    float

            abstract setInterval: callback: ServiceWorkerGlobalScope.SetInterval.Callback * ?msDelay: float -> float
            abstract clearTimeout: ?timeoutId: float -> unit

            abstract setTimeout:
                callback: ServiceWorkerGlobalScope.SetTimeout.Callback * ?msDelay: float * [<ParamArray>] args: 'Args ->
                    float

            abstract setTimeout: callback: ServiceWorkerGlobalScope.SetTimeout.Callback * ?msDelay: float -> float
            abstract atob: data: D1SessionBookmark -> D1SessionBookmark
            abstract btoa: data: D1SessionBookmark -> D1SessionBookmark

        [<Import("@cloudflare/workers-types", "ChatTemplateKwargs")>]
        type ChatTemplateKwargs =
            [<CompiledName("clear_thinking")>]
            abstract clearThinking: option<bool> with get, set

            [<CompiledName("enable_thinking")>]
            abstract enableThinking: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "StreamCaption")>]
        type StreamCaption =
            abstract status: option<StreamDownloadStatus> with get, set
            abstract language: D1SessionBookmark with get, set
            abstract label: D1SessionBookmark with get, set
            abstract generated: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "ResponsesFunctionTool")>]
        type Tool =
            abstract description: option<D1SessionBookmark> with get, set

            [<CompiledName("type")>]
            abstract ``type``: Tool.Type with get, set

            abstract strict: option<bool> with get, set
            abstract parameters: option<Tool.Parameters> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Deepgram_Aura_1_Input")>]
        type AiCfDeepgramAura1Input =
            [<CompiledName("bit_rate")>]
            abstract bitRate: option<float> with get, set

            [<CompiledName("sample_rate")>]
            abstract sampleRate: option<float> with get, set

            abstract text: D1SessionBookmark with get, set
            abstract container: option<AiCfDeepgramAura1Input.Container> with get, set
            abstract encoding: option<AiCfDeepgramAura1Input.Encoding> with get, set
            abstract speaker: option<AiCfDeepgramAura1Input.Speaker> with get, set

        [<Import("@cloudflare/workers-types", "QueueSendMetadata")>]
        type QueueSendMetadata =
            abstract metrics: QueueSendMetrics with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type WorkflowDurationLabel =
            | [<CompiledName("second")>] Second
            | [<CompiledName("minute")>] Minute
            | [<CompiledName("hour")>] Hour
            | [<CompiledName("day")>] Day
            | [<CompiledName("week")>] Week
            | [<CompiledName("month")>] Month
            | [<CompiledName("year")>] Year

        [<Import("@cloudflare/workers-types", "VectorizeMatch")>]
        type VectorizeMatch =
            abstract score: float with get, set
            abstract metadata: option<VectorizeMatch.Metadata> with get, set

            [<CompiledName("namespace")>]
            abstract ``namespace``: option<D1SessionBookmark> with get, set

            abstract id: D1SessionBookmark with get, set

            abstract values:
                option<U3<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>, AiSentenceSimilarityOutput>> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Black_Forest_Labs_Flux_2_Klein_4B")>]
        type BaseAiCfBlackForestLabsFlux2Klein4B =
            abstract postProcessedOutputs: AiCfBlackForestLabsFlux2Klein4BOutput with get, set
            abstract inputs: AiCfBlackForestLabsFlux2Klein4BInput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_3")>]
        type AiCfAisingaporeGemmaSeaLionV427BItJSONMode3 =
            [<CompiledName("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<AiCfAisingaporeGemmaSeaLionV427BItJSONMode3.Type> with get, set

        [<Import("@cloudflare/workers-types", "ExportedHandlerTailHandler")>]
        type ExportedHandlerTailHandler<'Props, 'Env> =
            abstract Invoke:
                events: Array<TraceItem> * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "ResponsesInput")>]
        type ResponsesInput =
            abstract truncation: option<ResponsesInput.Truncation> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract tools: option<Array<Tool>> with get, set

            [<CompiledName("tool_choice")>]
            abstract toolChoice: option<U2<ToolChoiceOptions, ToolChoiceFunction>> with get, set

            abstract text: option<ResponseTextConfig> with get, set
            abstract temperature: option<float> with get, set

            [<CompiledName("stream_options")>]
            abstract streamOptions: option<StreamOptions> with get, set

            abstract stream: option<bool> with get, set

            [<CompiledName("service_tier")>]
            abstract serviceTier: option<ResponsesInput.ServiceTier> with get, set

            [<CompiledName("safety_identifier")>]
            abstract safetyIdentifier: option<D1SessionBookmark> with get, set

            abstract reasoning: option<Reasoning> with get, set

            [<CompiledName("prompt_cache_key")>]
            abstract promptCacheKey: option<D1SessionBookmark> with get, set

            [<CompiledName("previous_response_id")>]
            abstract previousResponseId: option<D1SessionBookmark> with get, set

            [<CompiledName("parallel_tool_calls")>]
            abstract parallelToolCalls: option<bool> with get, set

            [<CompiledName("max_output_tokens")>]
            abstract maxOutputTokens: option<float> with get, set

            abstract instructions: option<D1SessionBookmark> with get, set

            abstract input:
                option<
                    U2<
                        Array<
                            U6<
                                ResponseOutputMessage,
                                ResponseFunctionToolCall,
                                ResponseReasoningItem,
                                EasyInputMessage,
                                ResponseInputItemMessage,
                                ResponseInputItemFunctionCallOutput
                             >
                         >,
                        D1SessionBookmark
                     >
                 > with get, set

            abstract include: option<Array<ResponseIncludable>> with get, set
            abstract conversation: option<U2<ResponseConversationParam, D1SessionBookmark>> with get, set
            abstract background: option<bool> with get, set

        type Params<'P when 'P :> D1SessionBookmark> = Params

        [<Import("@cloudflare/workers-types", "ScriptVersion")>]
        type ScriptVersion =
            abstract message: option<D1SessionBookmark> with get, set
            abstract tag: option<D1SessionBookmark> with get, set
            abstract id: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages")>]
        type AiCfQwenQwen330BA3BFp8Messages =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfQwenQwen330BA3BFp8JSONMode1> with get, set

            abstract tools:
                option<Array<U2<AiCfQwenQwen330BA3BFp8Messages.Tools, AiCfQwenQwen330BA3BFp8Messages.Tools>>> with get, set

            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: Array<AiCfQwenQwen330BA3BFp8Messages.Messages> with get, set

        [<Import("@cloudflare/workers-types", "CloseEvent")>]
        type CloseEvent =
            [<EmitConstructor>]
            abstract Create: ``type``: D1SessionBookmark * ?initializer: Typescript.CloseEventInit -> CloseEvent

            inherit Event
            abstract wasClean: bool with get
            abstract reason: D1SessionBookmark with get
            abstract code: float with get

        [<Import("@cloudflare/workers-types", "RequestInitCfPropertiesImage")>]
        type RequestInitCfPropertiesImage =
            inherit BasicImageTransformations
            abstract compression: option<RequestInitCfPropertiesImage.Compression> with get, set
            abstract flip: option<RequestInitCfPropertiesImage.Flip> with get, set
            abstract saturation: option<float> with get, set
            abstract gamma: option<float> with get, set
            abstract contrast: option<float> with get, set
            abstract brightness: option<float> with get, set
            abstract border: option<U2<RequestInitCfPropertiesImage.Border, RequestInitCfPropertiesImage.Border>> with get, set

            [<CompiledName("origin-auth")>]
            abstract originAuth: option<RequestInitCfPropertiesImage.OriginAuth> with get, set

            abstract draw: option<Array<RequestInitCfPropertiesImageDraw>> with get, set
            abstract blur: option<float> with get, set
            abstract sharpen: option<float> with get, set
            abstract metadata: option<RequestInitCfPropertiesImage.Metadata> with get, set
            abstract anim: option<bool> with get, set
            abstract format: option<RequestInitCfPropertiesImage.Format> with get, set
            abstract quality: option<U2<RequestInitCfPropertiesImage.Quality, float>> with get, set
            abstract trim: option<U2<RequestInitCfPropertiesImage.Trim, RequestInitCfPropertiesImage.Trim>> with get, set
            abstract dpr: option<float> with get, set

        [<Import("@cloudflare/workers-types", "ImageHandle")>]
        type ImageHandle =
            abstract delete: unit -> Promise<bool>
            abstract update: options: ImageUpdateOptions -> Promise<ImageMetadata>
            abstract bytes: unit -> Promise<option<ReadableStream<Uint8Array<ArrayBufferLike>>>>
            abstract details: unit -> Promise<option<ImageMetadata>>

        [<Import("@cloudflare/workers-types", "WorkerLoaderModule")>]
        type WorkerLoaderModule =
            abstract wasm: option<ArrayBuffer> with get, set
            abstract py: option<D1SessionBookmark> with get, set
            abstract json: option<obj> with get, set
            abstract data: option<ArrayBuffer> with get, set
            abstract text: option<D1SessionBookmark> with get, set
            abstract cjs: option<D1SessionBookmark> with get, set
            abstract js: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchListItemsParams")>]
        type AiSearchListItemsParams =
            [<CompiledName("metadata_filter")>]
            abstract metadataFilter: option<D1SessionBookmark> with get, set

            abstract source: option<D1SessionBookmark> with get, set
            abstract status: option<AiSearchListItemsParams.Status> with get, set

            [<CompiledName("sort_by")>]
            abstract sortBy: option<AiSearchListItemsParams.SortBy> with get, set

            abstract search: option<D1SessionBookmark> with get, set

            [<CompiledName("per_page")>]
            abstract perPage: option<float> with get, set

            abstract page: option<float> with get, set

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRagSearchResponse")>]
        type AutoRagSearchResponse =
            [<CompiledName("next_page")>]
            abstract nextPage: option<D1SessionBookmark> with get, set

            [<CompiledName("has_more")>]
            abstract hasMore: bool with get, set

            abstract data: Array<AutoRagSearchResponse.Data> with get, set

            [<CompiledName("search_query")>]
            abstract searchQuery: D1SessionBookmark with get, set

            abstract object: AutoRagSearchResponse.Object with get, set

        [<Import("@cloudflare/workers-types", "ResponseInputItemMessage")>]
        type ResponseInputItemMessage =
            [<CompiledName("type")>]
            abstract ``type``: option<ResponseInputItemMessage.Type> with get, set

            abstract status: option<ResponseInputItemMessage.Status> with get, set
            abstract role: ResponseInputItemMessage.Role with get, set
            abstract content: Array<U2<ResponseInputText, ResponseInputImage>> with get, set

        [<Import("@cloudflare/workers-types", "TopLogprob")>]
        type TopLogprob =
            abstract logprob: option<float> with get, set
            abstract token: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ImageUploadOptions")>]
        type ImageUploadOptions =
            abstract encoding: option<ImageUploadOptions.Encoding> with get, set
            abstract creator: option<D1SessionBookmark> with get, set
            abstract metadata: option<ImageUploadOptions.Metadata> with get, set
            abstract requireSignedURLs: option<bool> with get, set
            abstract filename: option<D1SessionBookmark> with get, set
            abstract id: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Google_Gemma_3_12B_It_Output")>]
        type AiCfGoogleGemma312BItOutput =
            [<CompiledName("tool_calls")>]
            abstract toolCalls: option<Array<AiCfGoogleGemma312BItOutput.ToolCalls>> with get, set

            abstract usage: option<AiCfGoogleGemma312BItOutput.Usage> with get, set
            abstract response: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Nvidia_Nemotron_3_120B_A12B")>]
        type BaseAiCfNvidiaNemotron3120BA12B =
            abstract postProcessedOutputs: ChatCompletionsOutput with get, set

            abstract inputs:
                U3<
                    BaseAiCfNvidiaNemotron3120BA12B.Inputs,
                    BaseAiCfNvidiaNemotron3120BA12B.Inputs,
                    BaseAiCfNvidiaNemotron3120BA12B.Inputs
                 > with get, set

        [<Import("@cloudflare/workers-types", "AiImageTextToTextOutput")>]
        type AiImageTextToTextOutput =
            abstract description: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1")>]
        type AiCfAisingaporeGemmaSeaLionV427BItMessages1 =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfAisingaporeGemmaSeaLionV427BItJSONMode3> with get, set

            abstract tools:
                option<
                    Array<
                        U2<
                            AiCfAisingaporeGemmaSeaLionV427BItMessages1.Tools,
                            AiCfAisingaporeGemmaSeaLionV427BItMessages1.Tools
                         >
                     >
                 > with get, set

            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: Array<AiCfAisingaporeGemmaSeaLionV427BItMessages1.Messages> with get, set

        [<Import("@cloudflare/workers-types", "TraceItemAlarmEventInfo")>]
        type TraceItemAlarmEventInfo =
            abstract scheduledTime: Date with get

        [<Import("@cloudflare/workers-types", "TraceDiagnosticChannelEvent")>]
        type TraceDiagnosticChannelEvent =
            abstract message: option<obj> with get
            abstract channel: D1SessionBookmark with get
            abstract timestamp: float with get

        [<Import("@cloudflare/workers-types", "ArtifactsCreateTokenResult")>]
        type ArtifactsCreateTokenResult =
            abstract expiresAt: D1SessionBookmark with get, set
            abstract scope: ArtifactsCreateTokenResult.Scope with get, set
            abstract plaintext: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_JSON_Mode")>]
        type AiCfMetaLlama4Scout17B16EInstructJSONMode =
            [<CompiledName("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<AiCfMetaLlama4Scout17B16EInstructJSONMode.Type> with get, set

        [<Import("@cloudflare/workers-types", "AiImageToTextInput")>]
        type AiImageToTextInput =
            abstract messages: option<Array<RoleScopedChatInput>> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract prompt: option<D1SessionBookmark> with get, set
            abstract image: AiSentenceSimilarityOutput with get, set

        [<Import("@cloudflare/workers-types", "HTMLRewriterDocumentContentHandlers")>]
        type HTMLRewriterDocumentContentHandlers =
            abstract ``end``: ``end``: DocumentEnd -> option<Promise<unit>>
            abstract text: text: Typescript.Text -> option<Promise<unit>>
            abstract comments: comment: Typescript.Comment -> option<Promise<unit>>
            abstract doctype: doctype: Doctype -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "AiTextToSpeechInput")>]
        type AiTextToSpeechInput =
            abstract lang: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Leonardo_Lucid_Origin_Output")>]
        type AiCfLeonardoLucidOriginOutput =
            abstract image: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Unum_Uform_Gen2_Qwen_500M")>]
        type BaseAiCfUnumUformGen2Qwen500M =
            abstract postProcessedOutputs: AiCfUnumUformGen2Qwen500MOutput with get, set
            abstract inputs: U2<BaseAiCfUnumUformGen2Qwen500M.Inputs, D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Workflow")>]
        type Workflow<'PARAMS> =
            abstract createBatch:
                batch: Array<WorkflowInstanceCreateOptions<'PARAMS>> -> Promise<Array<WorkflowInstance>>

            abstract create: ?options: WorkflowInstanceCreateOptions<'PARAMS> -> Promise<WorkflowInstance>
            abstract get: id: D1SessionBookmark -> Promise<WorkflowInstance>

        [<Import("@cloudflare/workers-types", "StreamVideoInput")>]
        type StreamVideoInput =
            abstract height: float with get, set
            abstract width: float with get, set

        [<Import("@cloudflare/workers-types", "ResponseFormatJSONObject")>]
        type ResponseFormatJSONObject =
            [<CompiledName("type")>]
            abstract ``type``: ResponseFormatJSONObject.Type with get, set

        [<Import("@cloudflare/workers-types", "KVNamespace")>]
        type KVNamespace<'Key when 'Key :> D1SessionBookmark> =
            abstract delete: key: 'Key -> Promise<unit>

            abstract getWithMetadata:
                key: Array<'Key> * ?options: KVNamespaceGetOptions<KVNamespace.GetWithMetadata.Options> ->
                    Promise<Map<D1SessionBookmark, KVNamespaceGetWithMetadataResult<'ExpectedValue, 'Metadata>>>

            abstract getWithMetadata:
                key: Array<'Key> * ?options: KVNamespaceGetOptions<KVNamespace.GetWithMetadata.Options> ->
                    Promise<Map<D1SessionBookmark, KVNamespaceGetWithMetadataResult<D1SessionBookmark, 'Metadata>>>

            abstract getWithMetadata:
                key: Array<'Key> * ?options: KVNamespace.GetWithMetadata.Options ->
                    Promise<Map<D1SessionBookmark, KVNamespaceGetWithMetadataResult<D1SessionBookmark, 'Metadata>>>

            abstract getWithMetadata:
                key: Array<'Key> * ``type``: KVNamespace.GetWithMetadata.Type ->
                    Promise<Map<D1SessionBookmark, KVNamespaceGetWithMetadataResult<'ExpectedValue, 'Metadata>>>

            abstract getWithMetadata:
                key: Array<'Key> * ``type``: KVNamespace.GetWithMetadata.Type ->
                    Promise<Map<D1SessionBookmark, KVNamespaceGetWithMetadataResult<D1SessionBookmark, 'Metadata>>>

            abstract getWithMetadata:
                key: 'Key * options: KVNamespaceGetOptions<KVNamespace.GetWithMetadata.Options> ->
                    Promise<KVNamespaceGetWithMetadataResult<ReadableStream<option<obj>>, 'Metadata>>

            abstract getWithMetadata:
                key: 'Key * options: KVNamespaceGetOptions<KVNamespace.GetWithMetadata.Options> ->
                    Promise<KVNamespaceGetWithMetadataResult<ArrayBuffer, 'Metadata>>

            abstract getWithMetadata:
                key: 'Key * options: KVNamespaceGetOptions<KVNamespace.GetWithMetadata.Options> ->
                    Promise<KVNamespaceGetWithMetadataResult<'ExpectedValue, 'Metadata>>

            abstract getWithMetadata:
                key: 'Key * options: KVNamespaceGetOptions<KVNamespace.GetWithMetadata.Options> ->
                    Promise<KVNamespaceGetWithMetadataResult<D1SessionBookmark, 'Metadata>>

            abstract getWithMetadata:
                key: 'Key * ``type``: KVNamespace.GetWithMetadata.Type ->
                    Promise<KVNamespaceGetWithMetadataResult<ReadableStream<option<obj>>, 'Metadata>>

            abstract getWithMetadata:
                key: 'Key * ``type``: KVNamespace.GetWithMetadata.Type ->
                    Promise<KVNamespaceGetWithMetadataResult<ArrayBuffer, 'Metadata>>

            abstract getWithMetadata:
                key: 'Key * ``type``: KVNamespace.GetWithMetadata.Type ->
                    Promise<KVNamespaceGetWithMetadataResult<'ExpectedValue, 'Metadata>>

            abstract getWithMetadata:
                key: 'Key * ``type``: KVNamespace.GetWithMetadata.Type ->
                    Promise<KVNamespaceGetWithMetadataResult<D1SessionBookmark, 'Metadata>>

            abstract getWithMetadata:
                key: 'Key * ?options: KVNamespace.GetWithMetadata.Options ->
                    Promise<KVNamespaceGetWithMetadataResult<D1SessionBookmark, 'Metadata>>

            abstract put:
                key: 'Key *
                value: U4<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, ReadableStream<option<obj>>, D1SessionBookmark> *
                ?options: KVNamespacePutOptions ->
                    Promise<unit>

            abstract list: ?options: KVNamespaceListOptions -> Promise<U2<KVNamespace.List, KVNamespace.List>>

            abstract get:
                key: Array<'Key> * ?options: KVNamespaceGetOptions<KVNamespace.Get.Options> ->
                    Promise<Map<D1SessionBookmark, option<'ExpectedValue>>>

            abstract get:
                key: Array<'Key> * ?options: KVNamespaceGetOptions<KVNamespace.Get.Options> ->
                    Promise<Map<D1SessionBookmark, option<D1SessionBookmark>>>

            abstract get:
                key: Array<'Key> * ?options: KVNamespace.Get.Options ->
                    Promise<Map<D1SessionBookmark, option<D1SessionBookmark>>>

            abstract get:
                key: Array<'Key> * ``type``: KVNamespace.Get.Type ->
                    Promise<Map<D1SessionBookmark, option<'ExpectedValue>>>

            abstract get:
                key: Array<'Key> * ``type``: KVNamespace.Get.Type ->
                    Promise<Map<D1SessionBookmark, option<D1SessionBookmark>>>

            abstract get:
                key: 'Key * ?options: KVNamespaceGetOptions<KVNamespace.Get.Options> ->
                    Promise<option<ReadableStream<option<obj>>>>

            abstract get:
                key: 'Key * ?options: KVNamespaceGetOptions<KVNamespace.Get.Options> -> Promise<option<ArrayBuffer>>

            abstract get:
                key: 'Key * ?options: KVNamespaceGetOptions<KVNamespace.Get.Options> -> Promise<option<'ExpectedValue>>

            abstract get:
                key: 'Key * ?options: KVNamespaceGetOptions<KVNamespace.Get.Options> ->
                    Promise<option<D1SessionBookmark>>

            abstract get: key: 'Key * ``type``: KVNamespace.Get.Type -> Promise<option<ReadableStream<option<obj>>>>
            abstract get: key: 'Key * ``type``: KVNamespace.Get.Type -> Promise<option<ArrayBuffer>>
            abstract get: key: 'Key * ``type``: KVNamespace.Get.Type -> Promise<option<'ExpectedValue>>
            abstract get: key: 'Key * ``type``: KVNamespace.Get.Type -> Promise<option<D1SessionBookmark>>
            abstract get: key: 'Key * ?options: KVNamespace.Get.Options -> Promise<option<D1SessionBookmark>>

        [<Import("@cloudflare/workers-types", "StreamBinding")>]
        type StreamBinding =
            abstract watermarks: StreamWatermarks with get, set
            abstract videos: StreamVideos with get, set
            abstract createDirectUpload: params: StreamDirectUploadCreateParams -> Promise<StreamDirectUpload>
            abstract upload: url: D1SessionBookmark * ?params: StreamUrlUploadParams -> Promise<StreamVideo>
            abstract video: id: D1SessionBookmark -> StreamVideoHandle

        [<Import("@cloudflare/workers-types", "AiSearchListResponse")>]
        type AiSearchListResponse =
            [<CompiledName("result_info")>]
            abstract resultInfo: option<AiSearchListResponse.ResultInfo> with get, set

            abstract result: Array<AiSearchInstanceInfo> with get, set

        [<Import("@cloudflare/workers-types", "ReadableStreamDefaultReader")>]
        type ReadableStreamDefaultReader<'R> =
            [<EmitConstructor>]
            abstract Create: stream: ReadableStream<option<obj>> -> ReadableStreamDefaultReader

            abstract closed: Promise<unit> with get
            abstract releaseLock: unit -> unit
            abstract read: unit -> Promise<U2<ReadableStreamReadValueResult<'R>, ReadableStreamReadDoneResult<'R>>>
            abstract cancel: ?reason: obj -> Promise<unit>

        [<Import("@cloudflare/workers-types", "EmailEvent")>]
        type EmailEvent =
            inherit ExtendableEvent<'EmailEvent>
            abstract message: ForwardableEmailMessage with get

        [<Import("@cloudflare/workers-types", "SocketAddress")>]
        type SocketAddress =
            abstract port: float with get, set
            abstract hostname: D1SessionBookmark with get, set

        type D1SessionBookmark = string

        [<Import("@cloudflare/workers-types", "AlarmInvocationInfo")>]
        type AlarmInvocationInfo =
            abstract scheduledTime: float with get
            abstract retryCount: float with get
            abstract isRetry: bool with get

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Chat_Completion_Response")>]
        type AiCfAisingaporeGemmaSeaLionV427BItChatCompletionResponse =
            [<CompiledName("prompt_logprobs")>]
            abstract promptLogprobs: option<obj> with get, set

            abstract usage: option<AiCfAisingaporeGemmaSeaLionV427BItChatCompletionResponse.Usage> with get, set
            abstract choices: option<Array<AiCfAisingaporeGemmaSeaLionV427BItChatCompletionResponse.Choices>> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract created: option<float> with get, set
            abstract object: option<AiCfAisingaporeGemmaSeaLionV427BItChatCompletionResponse.Object> with get, set
            abstract id: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItemChunk")>]
        type AiSearchItemChunk =
            abstract item: option<AiSearchItemChunk.Item> with get, set

            [<CompiledName("end_byte")>]
            abstract endByte: float with get, set

            [<CompiledName("start_byte")>]
            abstract startByte: float with get, set

            abstract text: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "StreamDownload")>]
        type StreamDownload =
            abstract url: option<D1SessionBookmark> with get, set
            abstract status: StreamDownload.Status with get, set
            abstract percentComplete: float with get, set

        [<Import("@cloudflare/workers-types", "AiSearchJobLog")>]
        type AiSearchJobLog =
            [<CompiledName("created_at")>]
            abstract createdAt: float with get, set

            [<CompiledName("message_type")>]
            abstract messageType: float with get, set

            abstract message: D1SessionBookmark with get, set
            abstract id: float with get, set

        type ResponseFunctionCallOutputItem = U2<ResponseInputTextContent, ResponseInputImageContent>

        [<Import("@cloudflare/workers-types", "WorkerLoaderWorkerCode")>]
        type WorkerLoaderWorkerCode =
            abstract streamingTails: option<Array<WorkerLoaderWorkerCode.StreamingTails>> with get, set
            abstract tails: option<Array<WorkerLoaderWorkerCode.Tails>> with get, set
            abstract globalOutbound: option<WorkerLoaderWorkerCode.GlobalOutbound> with get, set
            abstract env: option<obj> with get, set
            abstract modules: WorkerLoaderWorkerCode.Modules with get, set
            abstract mainModule: D1SessionBookmark with get, set
            abstract limits: option<WorkerdResourceLimits> with get, set
            abstract allowExperimental: option<bool> with get, set
            abstract compatibilityFlags: option<Array<D1SessionBookmark>> with get, set
            abstract compatibilityDate: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionsResponseFormatJSONObject")>]
        type ChatCompletionsResponseFormatJSONObject =
            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionsResponseFormatJSONObject.Type with get, set

        [<Import("@cloudflare/workers-types", "DecompressionStream")>]
        type DecompressionStream =
            interface
                [<EmitConstructor>]
                abstract Create: format: DecompressionStream.Format -> DecompressionStream

                inherit TransformStream<
                    U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>,
                    Uint8Array<ArrayBufferLike>,
                    'DecompressionStream
                 ><U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>, Uint8Array<ArrayBufferLike>>
            end

        type ClearInterval =
            abstract Invoke: ?timeoutId: float -> unit
            abstract Invoke: ?id: float -> unit

        [<Import("@cloudflare/workers-types", "AnalyticsEngineDataPoint")>]
        type AnalyticsEngineDataPoint =
            abstract blobs: option<Array<option<U2<ArrayBuffer, D1SessionBookmark>>>> with get, set
            abstract doubles: option<AiSentenceSimilarityOutput> with get, set
            abstract indexes: option<Array<option<U2<ArrayBuffer, D1SessionBookmark>>>> with get, set

        [<Import("@cloudflare/workers-types", "VectorizeIndexInfo")>]
        type VectorizeIndexInfo =
            abstract processedUpToMutation: float with get, set
            abstract processedUpToDatetime: float with get, set
            abstract dimensions: float with get, set
            abstract vectorCount: float with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItem")>]
        type AiSearchItem =
            abstract chunks: ?params: AiSearchItemChunksParams -> Promise<AiSearchItemChunksResponse>
            abstract logs: ?params: AiSearchItemLogsParams -> Promise<AiSearchItemLogsResponse>
            abstract sync: unit -> Promise<AiSearchItemInfo>
            abstract download: unit -> Promise<AiSearchItemContentResult>
            abstract info: unit -> Promise<AiSearchItemInfo>

        [<Import("@cloudflare/workers-types", "AiAutomaticSpeechRecognitionInput")>]
        type AiAutomaticSpeechRecognitionInput =
            abstract audio: AiSentenceSimilarityOutput with get, set

        [<Import("@cloudflare/workers-types", "ResponseInputItemFunctionCallOutput")>]
        type ResponseInputItemFunctionCallOutput =
            abstract status: option<ResponseInputItemFunctionCallOutput.Status> with get, set
            abstract id: option<D1SessionBookmark> with get, set

            [<CompiledName("type")>]
            abstract ``type``: ResponseInputItemFunctionCallOutput.Type with get, set

            abstract output: U2<Array<ResponseFunctionCallOutputItem>, D1SessionBookmark> with get, set

            [<CompiledName("call_id")>]
            abstract callId: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ExecutionContext")>]
        type ExecutionContext<'Props> =
            abstract tracing: option<Tracing> with get, set
            abstract cache: option<CacheContext> with get, set
            abstract props: 'Props with get
            abstract passThroughOnException: unit -> unit
            abstract waitUntil: promise: Promise<option<obj>> -> unit

        [<Import("@cloudflare/workers-types", "HostedImagesBinding")>]
        type HostedImagesBinding =
            abstract list: ?options: ImageListOptions -> Promise<ImageList>

            abstract upload:
                image: U2<ReadableStream<Uint8Array<ArrayBufferLike>>, ArrayBuffer> * ?options: ImageUploadOptions ->
                    Promise<ImageMetadata>

            abstract image: imageId: D1SessionBookmark -> ImageHandle

        [<Import("@cloudflare/workers-types", "ScheduledEvent")>]
        type ScheduledEvent =
            inherit ExtendableEvent<'ScheduledEvent>
            abstract cron: D1SessionBookmark with get
            abstract scheduledTime: float with get
            abstract noRetry: unit -> unit

        [<Import("@cloudflare/workers-types", "SocketInfo")>]
        type SocketInfo =
            abstract localAddress: option<D1SessionBookmark> with get, set
            abstract remoteAddress: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "TraceItemJsRpcEventInfo")>]
        type TraceItemJsRpcEventInfo =
            abstract rpcMethod: D1SessionBookmark with get

        type ChatCompletionMessageParam =
            U6<DeveloperMessage, SystemMessage, UserMessage, AssistantMessage, ToolMessage, FunctionMessage>

        [<Import("@cloudflare/workers-types", "AiSearchMultiSearchError")>]
        type AiSearchMultiSearchError =
            abstract message: D1SessionBookmark with get, set

            [<CompiledName("instance_id")>]
            abstract instanceId: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_Reranker_Base_Output")>]
        type AiCfBaaiBgeRerankerBaseOutput =
            abstract response: option<Array<AiCfBaaiBgeRerankerBaseOutput.Response>> with get, set

        [<Import("@cloudflare/workers-types", "CountQueuingStrategy")>]
        type CountQueuingStrategy =
            [<EmitConstructor>]
            abstract Create: init: Typescript.QueuingStrategyInit -> CountQueuingStrategy

            inherit Typescript.QueuingStrategy<option<obj>, 'CountQueuingStrategy>
            abstract highWaterMark: float with get
            abstract size: ?chunk: obj -> float

        [<Import("@cloudflare/workers-types", "AiSearchInstanceInfo")>]
        type AiSearchInstanceInfo =
            abstract metadata: option<AiSearchInstanceInfo.Metadata> with get, set

            [<CompiledName("sync_interval")>]
            abstract syncInterval: option<AiSearchInstanceInfo.SyncInterval> with get, set

            [<CompiledName("custom_metadata")>]
            abstract customMetadata: option<Array<AiSearchInstanceInfo.CustomMetadata>> with get, set

            [<CompiledName("cache_threshold")>]
            abstract cacheThreshold: option<AiSearchInstanceInfo.CacheThreshold> with get, set

            abstract cache: option<bool> with get, set

            [<CompiledName("max_num_results")>]
            abstract maxNumResults: option<float> with get, set

            [<CompiledName("score_threshold")>]
            abstract scoreThreshold: option<float> with get, set

            [<CompiledName("chunk_overlap")>]
            abstract chunkOverlap: option<float> with get, set

            [<CompiledName("chunk_size")>]
            abstract chunkSize: option<float> with get, set

            abstract chunk: option<bool> with get, set

            [<CompiledName("retrieval_options")>]
            abstract retrievalOptions: option<AiSearchInstanceInfo.RetrievalOptions> with get, set

            [<CompiledName("indexing_options")>]
            abstract indexingOptions: option<AiSearchInstanceInfo.IndexingOptions> with get, set

            [<CompiledName("fusion_method")>]
            abstract fusionMethod: option<AiSearchInstanceInfo.FusionMethod> with get, set

            [<CompiledName("index_method")>]
            abstract indexMethod: option<AiSearchInstanceInfo.IndexMethod> with get, set

            /// <deprecated>
            /// Use index_method instead.
            /// </deprecated>
            [<CompiledName("hybrid_search_enabled")>]
            abstract hybridSearchEnabled: option<bool> with get, set

            [<CompiledName("reranking_model")>]
            abstract rerankingModel: option<D1SessionBookmark> with get, set

            [<CompiledName("rewrite_model")>]
            abstract rewriteModel: option<D1SessionBookmark> with get, set

            [<CompiledName("ai_search_model")>]
            abstract aiSearchModel: option<D1SessionBookmark> with get, set

            [<CompiledName("embedding_model")>]
            abstract embeddingModel: option<D1SessionBookmark> with get, set

            abstract reranking: option<bool> with get, set

            [<CompiledName("rewrite_query")>]
            abstract rewriteQuery: option<bool> with get, set

            [<CompiledName("ai_gateway_id")>]
            abstract aiGatewayId: option<D1SessionBookmark> with get, set

            [<CompiledName("token_id")>]
            abstract tokenId: option<D1SessionBookmark> with get, set

            [<CompiledName("modified_at")>]
            abstract modifiedAt: option<D1SessionBookmark> with get, set

            [<CompiledName("created_at")>]
            abstract createdAt: option<D1SessionBookmark> with get, set

            [<CompiledName("namespace")>]
            abstract ``namespace``: option<D1SessionBookmark> with get, set

            abstract status: option<D1SessionBookmark> with get, set
            abstract paused: option<bool> with get, set

            [<CompiledName("source_params")>]
            abstract sourceParams: option<obj> with get, set

            abstract source: option<D1SessionBookmark> with get, set

            [<CompiledName("type")>]
            abstract ``type``: option<U2<AiSearchInstanceInfo.Type, D1SessionBookmark>> with get, set

            abstract id: D1SessionBookmark with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "ResponseReasoningTextDoneEvent")>]
        type ResponseReasoningTextDoneEvent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseReasoningTextDoneEvent.Type with get, set

            abstract text: D1SessionBookmark with get, set

            [<CompiledName("sequence_number")>]
            abstract sequenceNumber: float with get, set

            [<CompiledName("output_index")>]
            abstract outputIndex: float with get, set

            [<CompiledName("item_id")>]
            abstract itemId: D1SessionBookmark with get, set

            [<CompiledName("content_index")>]
            abstract contentIndex: float with get, set

        [<Import("@cloudflare/workers-types", "Ai")>]
        type Ai<'AiModelList when 'AiModelList :> Ai> =
            abstract aiGatewayLogId: option<D1SessionBookmark> with get, set

            abstract toMarkdown:
                files: MarkdownDocument * ?options: ConversionRequestOptions -> Promise<ConversionResponse>

            abstract toMarkdown:
                files: Array<MarkdownDocument> * ?options: ConversionRequestOptions ->
                    Promise<Array<ConversionResponse>>

            abstract toMarkdown: unit -> ToMarkdownService
            abstract models: ?params: AiModelsSearchParams -> Promise<Array<AiModelsSearchObject>>
            abstract run: model: Ai.Run.Model * inputs: Ai.Run.Inputs * ?options: AiOptions -> Promise<Ai.Run>

            abstract run:
                model: 'Name *
                inputs: proptypekey<proptypekey<'AiModelList, 'Name>, Ai.Run.Inputs> *
                ?options: AiOptions ->
                    Promise<proptypekey<proptypekey<'AiModelList, 'Name>, Ai.Run>>

            abstract run:
                model: 'Name * inputs: Ai.Run.Inputs * ?options: AiOptions -> Promise<ReadableStream<option<obj>>>

            abstract run:
                model: 'Name *
                inputs: proptypekey<proptypekey<'AiModelList, 'Name>, Ai.Run.Inputs> *
                options: Ai.Run.Options ->
                    Promise<Typescript.Response>

            abstract run:
                model: 'Name *
                inputs: proptypekey<proptypekey<'AiModelList, 'Name>, Ai.Run.Inputs> *
                options: Ai.Run.Options ->
                    Promise<Typescript.Response>

            abstract run:
                model: 'Name * inputs: Ai.Run.Inputs * options: Ai.Run.Options -> Promise<AiAsyncBatchResponse>

            abstract autorag: autoragId: D1SessionBookmark -> AutoRAG
            abstract aiSearch: unit -> AiSearchNamespace
            abstract gateway: gatewayId: D1SessionBookmark -> AiGateway

        [<Import("@cloudflare/workers-types", "CustomEventCustomEventInit")>]
        type CustomEventCustomEventInit =
            abstract detail: option<obj> with get, set
            abstract composed: option<bool> with get, set
            abstract cancelable: option<bool> with get, set
            abstract bubbles: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Openai_Gpt_Oss_120B")>]
        type BaseAiCfOpenaiGptOss120B =
            abstract postProcessedOutputs:
                U2<BaseAiCfOpenaiGptOss120B.PostProcessedOutputs, BaseAiCfOpenaiGptOss120B.PostProcessedOutputs> with get, set

            abstract inputs:
                U4<
                    BaseAiCfOpenaiGptOss120B.Inputs,
                    BaseAiCfOpenaiGptOss120B.Inputs,
                    BaseAiCfOpenaiGptOss120B.Inputs,
                    BaseAiCfOpenaiGptOss120B.Inputs
                 > with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Prompt")>]
        type AiCfMetaLlama4Scout17B16EInstructPrompt =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("response_format")>]
            abstract responseFormat: option<AiCfMetaLlama4Scout17B16EInstructJSONMode> with get, set

            [<CompiledName("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Prompt")>]
        type AiCfMistralaiMistralSmall3124BInstructPrompt =
            [<CompiledName("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<CompiledName("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<CompiledName("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<CompiledName("top_k")>]
            abstract topK: option<float> with get, set

            [<CompiledName("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<CompiledName("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<CompiledName("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "BaseAiMultimodalEmbeddings")>]
        type BaseAiMultimodalEmbeddings =
            abstract postProcessedOutputs: AiImageTextToTextOutput with get, set
            abstract inputs: AiImageTextToTextInput with get, set

        [<Import("@cloudflare/workers-types", "SecretsStoreSecret")>]
        type SecretsStoreSecret =
            abstract get: unit -> Promise<D1SessionBookmark>

        [<Import("@cloudflare/workers-types", "EventSourceEventSourceInit")>]
        type EventSourceEventSourceInit =
            abstract fetcher: option<EventSourceEventSourceInit.Fetcher> with get, set
            abstract withCredentials: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Pfnet_Plamo_Embedding_1B_Output")>]
        type AiCfPfnetPlamoEmbedding1BOutput =
            abstract shape: float * float with get, set
            abstract data: Array<AiSentenceSimilarityOutput> with get, set

        [<Import("@cloudflare/workers-types", "AiImageToTextOutput")>]
        type AiImageToTextOutput =
            abstract description: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "CryptoKeyHmacKeyAlgorithm")>]
        type CryptoKeyHmacKeyAlgorithm =
            abstract length: float with get, set
            abstract hash: CryptoKeyKeyAlgorithm with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectState")>]
        type DurableObjectState<'Props> =
            abstract facets: DurableObjectFacets with get, set
            abstract container: option<Container> with get, set
            abstract storage: DurableObjectStorage with get
            abstract id: DurableObjectId with get
            abstract props: 'Props with get
            abstract abort: ?reason: D1SessionBookmark -> unit
            abstract getTags: ws: Typescript.WebSocket -> Array<D1SessionBookmark>
            abstract getHibernatableWebSocketEventTimeout: unit -> option<float>
            abstract setHibernatableWebSocketEventTimeout: ?timeoutMs: float -> unit
            abstract getWebSocketAutoResponseTimestamp: ws: Typescript.WebSocket -> option<Date>
            abstract getWebSocketAutoResponse: unit -> option<WebSocketRequestResponsePair>
            abstract setWebSocketAutoResponse: ?maybeReqResp: WebSocketRequestResponsePair -> unit
            abstract getWebSockets: ?tag: D1SessionBookmark -> Array<Typescript.WebSocket>
            abstract acceptWebSocket: ws: Typescript.WebSocket * ?tags: Array<D1SessionBookmark> -> unit
            abstract blockConcurrencyWhile: callback: unit -> Promise<'T> -> Promise<'T>
            abstract waitUntil: promise: Promise<option<obj>> -> unit

        [<Import("@cloudflare/workers-types", "TextDecoderStream")>]
        type TextDecoderStream =
            [<EmitConstructor>]
            abstract Create:
                ?label: D1SessionBookmark * ?options: TextDecoderStreamTextDecoderStreamInit -> TextDecoderStream

            inherit TransformStream<
                U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>,
                D1SessionBookmark,
                'TextDecoderStream
             ><U2<ArrayBuffer, ArrayBufferView<ArrayBufferLike>>, D1SessionBookmark>

            abstract ignoreBOM: bool with get
            abstract fatal: bool with get
            abstract encoding: D1SessionBookmark with get

        type KVNamespaceListResult =
            abstract cacheStatus: option<D1SessionBookmark> with get, set
            abstract cursor: D1SessionBookmark with get, set
            abstract keys: Array<KVNamespaceListKey<'Metadata, 'Key>> with get, set

            [<CompiledName("list_complete")>]
            abstract listComplete: KVNamespaceListResult.ListComplete with get, set

        [<Import("@cloudflare/workers-types", "BaseAiAutomaticSpeechRecognition")>]
        type BaseAiAutomaticSpeechRecognition =
            abstract postProcessedOutputs: AiAutomaticSpeechRecognitionOutput with get, set
            abstract inputs: AiAutomaticSpeechRecognitionInput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Chat_Completion_Response")>]
        type AiCfQwenQwen330BA3BFp8ChatCompletionResponse =
            [<CompiledName("prompt_logprobs")>]
            abstract promptLogprobs: option<obj> with get, set

            abstract usage: option<AiCfQwenQwen330BA3BFp8ChatCompletionResponse.Usage> with get, set
            abstract choices: option<Array<AiCfQwenQwen330BA3BFp8ChatCompletionResponse.Choices>> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract created: option<float> with get, set
            abstract object: option<AiCfQwenQwen330BA3BFp8ChatCompletionResponse.Object> with get, set
            abstract id: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "R2GetOptions")>]
        type R2GetOptions =
            abstract ssecKey: option<U2<ArrayBuffer, D1SessionBookmark>> with get, set
            abstract range: option<U4<R2GetOptions.Range, R2GetOptions.Range, R2GetOptions.Range, Headers>> with get, set
            abstract onlyIf: option<U2<R2Conditional, Headers>> with get, set

        [<Import("@cloudflare/workers-types", "AssistantMessageContentPart")>]
        type AssistantMessageContentPart =
            abstract refusal: option<D1SessionBookmark> with get, set
            abstract text: option<D1SessionBookmark> with get, set

            [<CompiledName("type")>]
            abstract ``type``: AssistantMessageContentPart.Type with get, set

        [<Import("@cloudflare/workers-types", "FetchEvent")>]
        type FetchEvent =
            inherit ExtendableEvent<'FetchEvent>
            abstract request: Typescript.Request<option<obj>, U2<RequestInitCfProperties, FetchEvent.Request>> with get
            abstract passThroughOnException: unit -> unit
            abstract respondWith: promise: U2<Typescript.Response, Promise<Typescript.Response>> -> unit

        [<Import("@cloudflare/workers-types", "AudioParams")>]
        type AudioParams =
            abstract format: AudioParams.Format with get, set
            abstract voice: U2<ResponseConversationParam, D1SessionBookmark> with get, set

        type AiCfMetaM2M10012BOutput = U2<AiTranslationOutput, AiCfMetaM2M10012BAsyncResponse>

        type XOR =
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "RateLimitedError")>]
        type RateLimitedError =
            inherit StreamError
            abstract name: RateLimitedError.Name with get, set

        [<Import("@cloudflare/workers-types", "AiSearchJobInfo")>]
        type AiSearchJobInfo =
            [<CompiledName("end_reason")>]
            abstract endReason: option<D1SessionBookmark> with get, set

            [<CompiledName("ended_at")>]
            abstract endedAt: option<D1SessionBookmark> with get, set

            [<CompiledName("started_at")>]
            abstract startedAt: option<D1SessionBookmark> with get, set

            [<CompiledName("last_seen_at")>]
            abstract lastSeenAt: option<D1SessionBookmark> with get, set

            abstract description: option<D1SessionBookmark> with get, set
            abstract source: AiSearchJobInfo.Source with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "IncomingRequestCfProperties")>]
        type IncomingRequestCfProperties<'HostMetadata> =
            abstract tlsClientAuth:
                U2<IncomingRequestCfPropertiesTLSClientAuth, IncomingRequestCfPropertiesTLSClientAuthPlaceholder> with get, set

            /// <example>
            /// "635"
            /// </example>
            abstract metroCode: option<D1SessionBookmark> with get, set
            /// <example>
            /// "TX"
            /// </example>
            abstract regionCode: option<D1SessionBookmark> with get, set
            /// <example>
            /// "Texas"
            /// </example>
            abstract region: option<D1SessionBookmark> with get, set
            /// <example>
            /// "America/Chicago"
            /// </example>
            abstract timezone: option<D1SessionBookmark> with get, set
            /// <example>
            /// "-97.74260"
            /// </example>
            abstract longitude: option<D1SessionBookmark> with get, set
            /// <example>
            /// "30.27130"
            /// </example>
            abstract latitude: option<D1SessionBookmark> with get, set
            /// <example>
            /// "78701"
            /// </example>
            abstract postalCode: option<D1SessionBookmark> with get, set
            /// <example>
            /// "Austin"
            /// </example>
            abstract city: option<D1SessionBookmark> with get, set
            /// <example>
            /// "AN"
            /// </example>
            abstract continent: option<ContinentCode> with get, set
            /// <example>
            /// "1"
            /// </example>
            abstract isEUCountry: option<IncomingRequestCfProperties.IsEUCountry> with get, set
            /// <example>
            /// "GB"
            /// </example>
            abstract country: option<IncomingRequestCfProperties.Country> with get, set
            abstract hostMetadata: option<'HostMetadata> with get, set
            /// <deprecated />
            abstract clientTrustScore: float with get, set
            abstract botManagement: IncomingRequestCfPropertiesBotManagementBase with get, set
            abstract botManagement: IncomingRequestCfProperties.BotManagement with get, set
            abstract tlsExportedAuthenticator: option<IncomingRequestCfPropertiesExportedAuthenticatorMetadata> with get, set
            /// <example>
            /// "AEAD-AES128-GCM-SHA256"
            /// </example>
            abstract tlsCipher: D1SessionBookmark with get, set
            /// <example>
            /// "TLSv1.3"
            /// </example>
            abstract tlsVersion: D1SessionBookmark with get, set
            /// <example>
            /// "weight=192;exclusive=0;group=3;group-weight=127"
            /// </example>
            abstract requestPriority: D1SessionBookmark with get, set
            /// <example>
            /// "HTTP/2"
            /// </example>
            abstract httpProtocol: D1SessionBookmark with get, set
            /// <example>
            /// 3
            /// </example>
            abstract edgeRequestKeepAliveStatus: IncomingRequestCfProperties.EdgeRequestKeepAliveStatus with get, set
            /// <example>
            /// "DFW"
            /// </example>
            abstract colo: D1SessionBookmark with get, set
            /// <example>
            /// 22
            /// </example>
            abstract clientTcpRtt: option<float> with get, set
            /// <example>
            /// "gzip, deflate, br"
            /// </example>
            abstract clientAcceptEncoding: option<D1SessionBookmark> with get, set
            /// <example>
            /// "Google Cloud"
            /// </example>
            abstract asOrganization: option<D1SessionBookmark> with get, set
            /// <example>
            /// 395747
            /// </example>
            abstract asn: option<float> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        type AiCfMetaLlama4Scout17B16EInstructInput =
            U3<
                AiCfMetaLlama4Scout17B16EInstructPrompt,
                AiCfMetaLlama4Scout17B16EInstructMessages,
                AiCfMetaLlama4Scout17B16EInstructAsyncBatch
             >

        [<Import("@cloudflare/workers-types", "AiSearchMultiChatCompletionsRequest")>]
        type AiSearchMultiChatCompletionsRequest =
            [<CompiledName("ai_search_options")>]
            abstract aiSearchOptions: AiSearchMultiSearchOptions with get, set

            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "ReadableStreamValuesOptions")>]
        type ReadableStreamValuesOptions =
            abstract preventCancel: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "R2Checksums")>]
        type R2Checksums =
            abstract sha512: option<ArrayBuffer> with get
            abstract sha384: option<ArrayBuffer> with get
            abstract sha256: option<ArrayBuffer> with get
            abstract sha1: option<ArrayBuffer> with get
            abstract md5: option<ArrayBuffer> with get
            abstract toJSON: unit -> R2StringChecksums

        type AiCfPipecatAiSmartTurnV2Input = U2<AiCfPipecatAiSmartTurnV2Input, AiCfPipecatAiSmartTurnV2Input>

        [<Import("@cloudflare/workers-types", "ResponseTextDoneEvent")>]
        type ResponseTextDoneEvent =
            [<CompiledName("type")>]
            abstract ``type``: ResponseTextDoneEvent.Type with get, set

            abstract text: D1SessionBookmark with get, set

            [<CompiledName("sequence_number")>]
            abstract sequenceNumber: float with get, set

            [<CompiledName("output_index")>]
            abstract outputIndex: float with get, set

            abstract logprobs: Array<Logprob> with get, set

            [<CompiledName("item_id")>]
            abstract itemId: D1SessionBookmark with get, set

            [<CompiledName("content_index")>]
            abstract contentIndex: float with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Deepgram_Flux_Input")>]
        type AiCfDeepgramFluxInput =
            abstract tag: option<D1SessionBookmark> with get, set

            [<CompiledName("mip_opt_out")>]
            abstract mipOptOut: option<AiCfDeepgramFluxInput.MipOptOut> with get, set

            abstract keyterm: option<D1SessionBookmark> with get, set

            [<CompiledName("eot_timeout_ms")>]
            abstract eotTimeoutMs: option<D1SessionBookmark> with get, set

            [<CompiledName("eot_threshold")>]
            abstract eotThreshold: option<D1SessionBookmark> with get, set

            [<CompiledName("eager_eot_threshold")>]
            abstract eagerEotThreshold: option<D1SessionBookmark> with get, set

            [<CompiledName("sample_rate")>]
            abstract sampleRate: D1SessionBookmark with get, set

            abstract encoding: AiCfDeepgramFluxInput.Encoding with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_AsyncResponse")>]
        type AiCfQwenQwen330BA3BFp8AsyncResponse =
            [<CompiledName("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B_Input")>]
        type AiCfAi4BharatIndictrans2EnIndic1BInput =
            [<CompiledName("target_language")>]
            abstract targetLanguage: AiCfAi4BharatIndictrans2EnIndic1BInput.TargetLanguage with get, set

            abstract text: U2<Array<D1SessionBookmark>, D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Unum_Uform_Gen2_Qwen_500M_Output")>]
        type AiCfUnumUformGen2Qwen500MOutput =
            abstract description: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "QueueSendBatchMetadata")>]
        type QueueSendBatchMetadata =
            abstract metrics: QueueSendBatchMetrics with get, set

        [<Import("@cloudflare/workers-types", "SqlStorageCursor")>]
        type SqlStorageCursor<'T when 'T :> SqlStorageCursor> =
            abstract rowsWritten: float with get
            abstract rowsRead: float with get
            abstract columnNames: Array<D1SessionBookmark> with get, set
            abstract ``[symbol.iterator]``: unit -> IterableIterator<'T, option<obj>, option<obj>>
            abstract raw: unit -> IterableIterator<'U, option<obj>, option<obj>>
            abstract one: unit -> 'T
            abstract toArray: unit -> Array<'T>
            abstract next: unit -> U2<SqlStorageCursor.Next, SqlStorageCursor.Next>

        [<Import("@cloudflare/workers-types", "ChatCompletionToolChoiceFunction")>]
        type ChatCompletionToolChoiceFunction =
            [<CompiledName("function")>]
            abstract ``function``: ChatCompletionToolChoiceFunction.Function with get, set

            [<CompiledName("type")>]
            abstract ``type``: ChatCompletionToolChoiceFunction.Type with get, set

        [<Import("@cloudflare/workers-types", "QuotaReachedError")>]
        type QuotaReachedError =
            inherit StreamError
            abstract name: QuotaReachedError.Name with get, set

        type SetTimeout =
            abstract Invoke: [<ParamArray>] args: Array<option<obj>> -> unit

            abstract Invoke:
                callback: SetTimeout.SetTimeout.Callback * ?msDelay: float * [<ParamArray>] args: 'Args -> float

            abstract Invoke: callback: SetTimeout.SetTimeout.Callback * ?msDelay: float -> float

            abstract Invoke:
                handler: U2<Function, D1SessionBookmark> *
                ?timeout: float *
                [<ParamArray>] arguments: Array<option<obj>> ->
                    float

            abstract Invoke: [<ParamArray>] args: 'Args -> unit

        [<Import("@cloudflare/workers-types", "D1DatabaseSession")>]
        type D1DatabaseSession =
            abstract getBookmark: unit -> option<D1SessionBookmark>
            abstract batch: statements: Array<D1PreparedStatement> -> Promise<Array<D1DatabaseSession.Batch>>
            abstract prepare: query: D1SessionBookmark -> D1PreparedStatement

        type AiCfMetaM2M10012BInput = U2<AiCfMetaM2M10012BInput, AiCfMetaM2M10012BInput>

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRagSearchRequest")>]
        type AutoRagSearchRequest =
            [<CompiledName("rewrite_query")>]
            abstract rewriteQuery: option<bool> with get, set

            abstract reranking: option<AutoRagSearchRequest.Reranking> with get, set

            [<CompiledName("ranking_options")>]
            abstract rankingOptions: option<AutoRagSearchRequest.RankingOptions> with get, set

            [<CompiledName("max_num_results")>]
            abstract maxNumResults: option<float> with get, set

            abstract filters: option<U2<CompoundFilter, ComparisonFilter>> with get, set
            abstract query: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "StreamWatermarks")>]
        type StreamWatermarks =
            abstract delete: watermarkId: D1SessionBookmark -> Promise<unit>
            abstract get: watermarkId: D1SessionBookmark -> Promise<StreamWatermark>
            abstract list: unit -> Promise<Array<StreamWatermark>>
            abstract generate: url: D1SessionBookmark * params: StreamWatermarkCreateParams -> Promise<StreamWatermark>

            abstract generate:
                input: ReadableStream<option<obj>> * params: StreamWatermarkCreateParams -> Promise<StreamWatermark>

        [<Import("@cloudflare/workers-types", "AiSearchItemLogsParams")>]
        type AiSearchItemLogsParams =
            abstract cursor: option<D1SessionBookmark> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "StreamDirectUpload")>]
        type StreamDirectUpload =
            abstract scheduledDeletion: option<D1SessionBookmark> with get, set
            abstract watermark: option<StreamWatermark> with get, set
            abstract id: D1SessionBookmark with get, set
            abstract uploadURL: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct")>]
        type BaseAiCfMetaLlama4Scout17B16EInstruct =
            abstract postProcessedOutputs: AiCfMetaLlama4Scout17B16EInstructOutput with get, set
            abstract inputs: AiCfMetaLlama4Scout17B16EInstructInput with get, set

        [<Import("@cloudflare/workers-types", "PredictionContent")>]
        type PredictionContent =
            abstract content: U2<Array<ChatCompletionContentPartText>, D1SessionBookmark> with get, set

            [<CompiledName("type")>]
            abstract ``type``: PredictionContent.Type with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Klein_9B_Input")>]
        type AiCfBlackForestLabsFlux2Klein9BInput =
            abstract multipart: AiCfBlackForestLabsFlux2Klein9BInput.Multipart with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Input_Embedding_1")>]
        type AiCfBaaiBgeM3InputEmbedding1 =
            [<CompiledName("truncate_inputs")>]
            abstract truncateInputs: option<bool> with get, set

            abstract text: U2<Array<D1SessionBookmark>, D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionsStreamOptions")>]
        type ChatCompletionsStreamOptions =
            [<CompiledName("include_obfuscation")>]
            abstract includeObfuscation: option<bool> with get, set

            [<CompiledName("include_usage")>]
            abstract includeUsage: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "TraceItemHibernatableWebSocketEventInfoMessage")>]
        type TraceItemHibernatableWebSocketEventInfoMessage =
            abstract webSocketEventType: D1SessionBookmark with get

        type AiTextToImageOutput = ReadableStream<Uint8Array<ArrayBufferLike>>

        [<Import("@cloudflare/workers-types", "DOMException")>]
        type DOMException =
            [<EmitConstructor>]
            abstract Create: ?message: D1SessionBookmark * ?name: D1SessionBookmark -> DOMException

            inherit Error
            abstract stack: option<obj> with set
            abstract stack: option<obj> with get
            abstract DATA_CLONE_ERR: float with get
            abstract INVALID_NODE_TYPE_ERR: float with get
            abstract TIMEOUT_ERR: float with get
            abstract QUOTA_EXCEEDED_ERR: float with get
            abstract URL_MISMATCH_ERR: float with get
            abstract ABORT_ERR: float with get
            abstract NETWORK_ERR: float with get
            abstract SECURITY_ERR: float with get
            abstract TYPE_MISMATCH_ERR: float with get
            abstract VALIDATION_ERR: float with get
            abstract INVALID_ACCESS_ERR: float with get
            abstract NAMESPACE_ERR: float with get
            abstract INVALID_MODIFICATION_ERR: float with get
            abstract SYNTAX_ERR: float with get
            abstract INVALID_STATE_ERR: float with get
            abstract INUSE_ATTRIBUTE_ERR: float with get
            abstract NOT_SUPPORTED_ERR: float with get
            abstract NOT_FOUND_ERR: float with get
            abstract NO_MODIFICATION_ALLOWED_ERR: float with get
            abstract NO_DATA_ALLOWED_ERR: float with get
            abstract INVALID_CHARACTER_ERR: float with get
            abstract WRONG_DOCUMENT_ERR: float with get
            abstract HIERARCHY_REQUEST_ERR: float with get
            abstract DOMSTRING_SIZE_ERR: float with get
            abstract INDEX_SIZE_ERR: float with get
            /// <deprecated>
            /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/DOMException/code)
            /// </deprecated>
            abstract code: float with get
            abstract name: D1SessionBookmark with get
            abstract message: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "AiSearchOptions")>]
        type AiSearchOptions =
            abstract cache: option<AiSearchOptions.Cache> with get, set
            abstract reranking: option<AiSearchOptions.Reranking> with get, set

            [<CompiledName("query_rewrite")>]
            abstract queryRewrite: option<AiSearchOptions.QueryRewrite> with get, set

            abstract retrieval: option<AiSearchOptions.Retrieval> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        type ICloudflare =
            [<Erase>]
            member exports: Exports = JS.undefined

            [<Erase>]
            member env: Env = JS.undefined

        type ICloudflareWorkersModule =
            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "withEnv")>]
            static member withEnv(newEnv: option<obj>, fn: unit -> option<obj>) : option<obj> = JS.undefined

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "withExports")>]
            static member withExports(newExports: option<obj>, fn: unit -> option<obj>) : option<obj> = JS.undefined

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "withEnvAndExports")>]
            static member withEnvAndExports
                (newEnv: option<obj>, newExports: option<obj>, fn: unit -> option<obj>)
                : option<obj> =
                JS.undefined

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "waitUntil")>]
            static member waitUntil(promise: Promise<option<obj>>) : unit = JS.undefined

        type IWebAssembly =
            [<Import("@cloudflare/workers-types.WebAssembly", "instantiate")>]
            static member instantiate
                (``module``: WebAssembly.Module, ?imports: Instantiate.Imports)
                : Promise<WebAssembly.Instance> =
                JS.undefined

            [<Import("@cloudflare/workers-types.WebAssembly", "instantiate")>]
            static member instantiate
                (moduleObject: WebAssembly.Module, ?importObject: Instantiate.ImportObject)
                : Promise<WebAssembly.Instance> =
                JS.undefined

            [<Import("@cloudflare/workers-types.WebAssembly", "instantiate")>]
            static member instantiate
                (bytes: U2<ArrayBuffer, ArrayBufferView<ArrayBuffer>>, ?importObject: Instantiate.ImportObject)
                : Promise<WebAssembly.WebAssemblyInstantiatedSource> =
                JS.undefined

            [<Import("@cloudflare/workers-types.WebAssembly", "validate")>]
            static member validate(bytes: U2<ArrayBuffer, ArrayBufferView<ArrayBuffer>>) : bool = JS.undefined

            [<Import("@cloudflare/workers-types.WebAssembly", "validate")>]
            static member validate(bytes: U2<ArrayBuffer, ArrayBufferView<ArrayBuffer>>) : bool = JS.undefined

        type ``Cloudflare:node`` =
            [<Import("@cloudflare/workers-types.cloudflare:node", "httpServerHandler")>]
            static member httpServerHandler
                (options: HttpServerHandler.Options)
                : ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>> =
                JS.undefined

            [<Import("@cloudflare/workers-types.cloudflare:node", "httpServerHandler")>]
            static member httpServerHandler
                (port: float)
                : ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>> =
                JS.undefined

            [<Import("@cloudflare/workers-types.cloudflare:node", "httpServerHandler")>]
            static member httpServerHandler
                (server: NodeStyleServer)
                : ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>> =
                JS.undefined

        module AIGatewayHeaders =
            type CfAigCustomCost =
                [<CompiledName("total_cost")>]
                abstract totalCost: option<float> with get, set

                [<CompiledName("per_token_out")>]
                abstract perTokenOut: option<float> with get, set

                [<CompiledName("per_token_in")>]
                abstract perTokenIn: option<float> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Item =
                | [<CompiledValue(false)>] False
                | [<CompiledValue(true)>] True

            type CfAigMetadata =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module AddEventListener =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type K =
                | [<CompiledName("waiting")>] Waiting
                | [<CompiledName("abort")>] Abort
                | [<CompiledName("error")>] Error
                | [<CompiledName("close")>] Close
                | [<CompiledName("message")>] Message
                | [<CompiledName("messageerror")>] Messageerror
                | [<CompiledName("contextlost")>] Contextlost
                | [<CompiledName("contextrestored")>] Contextrestored
                | [<CompiledName("animationcancel")>] Animationcancel
                | [<CompiledName("animationend")>] Animationend
                | [<CompiledName("animationiteration")>] Animationiteration
                | [<CompiledName("animationstart")>] Animationstart
                | [<CompiledName("auxclick")>] Auxclick
                | [<CompiledName("beforeinput")>] Beforeinput
                | [<CompiledName("beforematch")>] Beforematch
                | [<CompiledName("beforetoggle")>] Beforetoggle
                | [<CompiledName("blur")>] Blur
                | [<CompiledName("cancel")>] Cancel
                | [<CompiledName("canplay")>] Canplay
                | [<CompiledName("canplaythrough")>] Canplaythrough
                | [<CompiledName("change")>] Change
                | [<CompiledName("click")>] Click
                | [<CompiledName("compositionend")>] Compositionend
                | [<CompiledName("compositionstart")>] Compositionstart
                | [<CompiledName("compositionupdate")>] Compositionupdate
                | [<CompiledName("contextmenu")>] Contextmenu
                | [<CompiledName("copy")>] Copy
                | [<CompiledName("cuechange")>] Cuechange
                | [<CompiledName("cut")>] Cut
                | [<CompiledName("dblclick")>] Dblclick
                | [<CompiledName("drag")>] Drag
                | [<CompiledName("dragend")>] Dragend
                | [<CompiledName("dragenter")>] Dragenter
                | [<CompiledName("dragleave")>] Dragleave
                | [<CompiledName("dragover")>] Dragover
                | [<CompiledName("dragstart")>] Dragstart
                | [<CompiledName("drop")>] Drop
                | [<CompiledName("durationchange")>] Durationchange
                | [<CompiledName("emptied")>] Emptied
                | [<CompiledName("ended")>] Ended
                | [<CompiledName("focus")>] Focus
                | [<CompiledName("focusin")>] Focusin
                | [<CompiledName("focusout")>] Focusout
                | [<CompiledName("formdata")>] Formdata
                | [<CompiledName("gotpointercapture")>] Gotpointercapture
                | [<CompiledName("input")>] Input
                | [<CompiledName("invalid")>] Invalid
                | [<CompiledName("keydown")>] Keydown
                | [<CompiledName("keypress")>] Keypress
                | [<CompiledName("keyup")>] Keyup
                | [<CompiledName("load")>] Load
                | [<CompiledName("loadeddata")>] Loadeddata
                | [<CompiledName("loadedmetadata")>] Loadedmetadata
                | [<CompiledName("loadstart")>] Loadstart
                | [<CompiledName("lostpointercapture")>] Lostpointercapture
                | [<CompiledName("mousedown")>] Mousedown
                | [<CompiledName("mouseenter")>] Mouseenter
                | [<CompiledName("mouseleave")>] Mouseleave
                | [<CompiledName("mousemove")>] Mousemove
                | [<CompiledName("mouseout")>] Mouseout
                | [<CompiledName("mouseover")>] Mouseover
                | [<CompiledName("mouseup")>] Mouseup
                | [<CompiledName("paste")>] Paste
                | [<CompiledName("pause")>] Pause
                | [<CompiledName("play")>] Play
                | [<CompiledName("playing")>] Playing
                | [<CompiledName("pointercancel")>] Pointercancel
                | [<CompiledName("pointerdown")>] Pointerdown
                | [<CompiledName("pointerenter")>] Pointerenter
                | [<CompiledName("pointerleave")>] Pointerleave
                | [<CompiledName("pointermove")>] Pointermove
                | [<CompiledName("pointerout")>] Pointerout
                | [<CompiledName("pointerover")>] Pointerover
                | [<CompiledName("pointerrawupdate")>] Pointerrawupdate
                | [<CompiledName("pointerup")>] Pointerup
                | [<CompiledName("progress")>] Progress
                | [<CompiledName("ratechange")>] Ratechange
                | [<CompiledName("reset")>] Reset
                | [<CompiledName("resize")>] Resize
                | [<CompiledName("scroll")>] Scroll
                | [<CompiledName("scrollend")>] Scrollend
                | [<CompiledName("securitypolicyviolation")>] Securitypolicyviolation
                | [<CompiledName("seeked")>] Seeked
                | [<CompiledName("seeking")>] Seeking
                | [<CompiledName("select")>] Select
                | [<CompiledName("selectionchange")>] Selectionchange
                | [<CompiledName("selectstart")>] Selectstart
                | [<CompiledName("slotchange")>] Slotchange
                | [<CompiledName("stalled")>] Stalled
                | [<CompiledName("submit")>] Submit
                | [<CompiledName("suspend")>] Suspend
                | [<CompiledName("timeupdate")>] Timeupdate
                | [<CompiledName("toggle")>] Toggle
                | [<CompiledName("touchcancel")>] Touchcancel
                | [<CompiledName("touchend")>] Touchend
                | [<CompiledName("touchmove")>] Touchmove
                | [<CompiledName("touchstart")>] Touchstart
                | [<CompiledName("transitioncancel")>] Transitioncancel
                | [<CompiledName("transitionend")>] Transitionend
                | [<CompiledName("transitionrun")>] Transitionrun
                | [<CompiledName("transitionstart")>] Transitionstart
                | [<CompiledName("volumechange")>] Volumechange
                | [<CompiledName("webkitanimationend")>] Webkitanimationend
                | [<CompiledName("webkitanimationiteration")>] Webkitanimationiteration
                | [<CompiledName("webkitanimationstart")>] Webkitanimationstart
                | [<CompiledName("webkittransitionend")>] Webkittransitionend
                | [<CompiledName("wheel")>] Wheel
                | [<CompiledName("afterprint")>] Afterprint
                | [<CompiledName("beforeprint")>] Beforeprint
                | [<CompiledName("beforeunload")>] Beforeunload
                | [<CompiledName("gamepadconnected")>] Gamepadconnected
                | [<CompiledName("gamepaddisconnected")>] Gamepaddisconnected
                | [<CompiledName("hashchange")>] Hashchange
                | [<CompiledName("languagechange")>] Languagechange
                | [<CompiledName("offline")>] Offline
                | [<CompiledName("online")>] Online
                | [<CompiledName("pagehide")>] Pagehide
                | [<CompiledName("pagereveal")>] Pagereveal
                | [<CompiledName("pageshow")>] Pageshow
                | [<CompiledName("pageswap")>] Pageswap
                | [<CompiledName("popstate")>] Popstate
                | [<CompiledName("rejectionhandled")>] Rejectionhandled
                | [<CompiledName("storage")>] Storage
                | [<CompiledName("unhandledrejection")>] Unhandledrejection
                | [<CompiledName("unload")>] Unload
                | DOMContentLoaded
                | [<CompiledName("devicemotion")>] Devicemotion
                | [<CompiledName("deviceorientation")>] Deviceorientation
                | [<CompiledName("deviceorientationabsolute")>] Deviceorientationabsolute
                | [<CompiledName("orientationchange")>] Orientationchange

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("fetch")>] Fetch
                | [<CompiledName("queue")>] Queue
                | [<CompiledName("scheduled")>] Scheduled
                | [<CompiledName("rejectionhandled")>] Rejectionhandled
                | [<CompiledName("unhandledrejection")>] Unhandledrejection

        module Ai =
            type Run =
                [<CompiledName("request_id")>]
                abstract requestId: D1SessionBookmark with get, set

            type AiModelList =
                abstract Item: key: D1SessionBookmark -> option<obj>

            type Models =
                abstract value: D1SessionBookmark with get, set

                [<CompiledName("property_id")>]
                abstract propertyId: D1SessionBookmark with get, set

                abstract description: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set
                abstract properties: Array<Models.Properties> with get, set
                abstract tags: Array<D1SessionBookmark> with get, set
                abstract task: Models.Task with get, set
                abstract source: float with get, set

            module Models =
                type Params =
                    abstract task: option<D1SessionBookmark> with get, set
                    abstract source: option<float> with get, set
                    abstract search: option<D1SessionBookmark> with get, set

                    [<CompiledName("per_page")>]
                    abstract perPage: option<float> with get, set

                    abstract page: option<float> with get, set

                    [<CompiledName("hide_experimental")>]
                    abstract hideExperimental: option<bool> with get, set

                    abstract author: option<D1SessionBookmark> with get, set

            module Run =
                type Options =
                    abstract returnRawResponse: Options.ReturnRawResponse with get, set
                    abstract signal: option<AbortSignal> with get, set
                    abstract extraHeaders: option<obj> with get, set
                    abstract prefix: option<D1SessionBookmark> with get, set
                    abstract returnRawResponse: option<bool> with get, set
                    abstract gateway: option<GatewayOptions> with get, set
                    abstract tags: option<Array<D1SessionBookmark>> with get, set
                    abstract websocket: option<bool> with get, set
                    abstract queueRequest: option<bool> with get, set
                    abstract websocket: Options.Websocket with get, set
                    abstract queueRequest: Options.QueueRequest with get, set
                    abstract backoff: option<CloudflareWorkersModule.WorkflowBackoff> with get, set
                    abstract retryDelayMs: option<float> with get, set
                    abstract maxAttempts: option<Options.MaxAttempts> with get, set
                    abstract retries: option<GatewayRetries> with get, set
                    abstract requestTimeoutMs: option<float> with get, set
                    abstract eventId: option<D1SessionBookmark> with get, set
                    abstract collectLog: option<bool> with get, set
                    abstract metadata: option<Options.Metadata> with get, set
                    abstract skipCache: option<bool> with get, set
                    abstract cacheTtl: option<float> with get, set
                    abstract cacheKey: option<D1SessionBookmark> with get, set
                    abstract id: D1SessionBookmark with get, set
                    abstract Item: key: D1SessionBookmark -> option<obj>

                type Inputs =
                    abstract stream: Inputs.Stream with get, set
                    abstract requests: Array<proptypekey<proptypekey<'AiModelList, 'Name>, Inputs.Requests>> with get, set

                type Model = interface end

            module ToMarkdown =
                type Options =
                    abstract cssSelector: option<D1SessionBookmark> with get, set
                    abstract hostname: option<D1SessionBookmark> with get, set
                    abstract images: option<Options.Images> with get, set
                    abstract maxConvertedImages: option<float> with get, set
                    abstract convert: option<bool> with get, set
                    abstract descriptionLanguage: option<Options.DescriptionLanguage> with get, set
                    abstract images: option<EmbeddedImageConversionOptions> with get, set
                    abstract pdf: option<Options.Pdf> with get, set
                    abstract image: option<ImageConversionOptions> with get, set
                    abstract docx: option<Options.Docx> with get, set
                    abstract html: option<Options.Html> with get, set
                    abstract metadata: option<bool> with get, set
                    abstract convertOGImage: option<bool> with get, set
                    abstract conversionOptions: option<ConversionOptions> with get, set
                    abstract extraHeaders: option<obj> with get, set
                    abstract gateway: option<GatewayOptions> with get, set

                type Files =
                    abstract blob: Blob with get, set
                    abstract name: D1SessionBookmark with get, set

        module AiCfAi4BharatIndictrans2EnIndic1BInput =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type TargetLanguage =
                | [<CompiledName("asm_Beng")>] AsmBeng
                | [<CompiledName("awa_Deva")>] AwaDeva
                | [<CompiledName("ben_Beng")>] BenBeng
                | [<CompiledName("bho_Deva")>] BhoDeva
                | [<CompiledName("brx_Deva")>] BrxDeva
                | [<CompiledName("doi_Deva")>] DoiDeva
                | [<CompiledName("eng_Latn")>] EngLatn
                | [<CompiledName("gom_Deva")>] GomDeva
                | [<CompiledName("gon_Deva")>] GonDeva
                | [<CompiledName("guj_Gujr")>] GujGujr
                | [<CompiledName("hin_Deva")>] HinDeva
                | [<CompiledName("hne_Deva")>] HneDeva
                | [<CompiledName("kan_Knda")>] KanKnda
                | [<CompiledName("kas_Arab")>] KasArab
                | [<CompiledName("kas_Deva")>] KasDeva
                | [<CompiledName("kha_Latn")>] KhaLatn
                | [<CompiledName("lus_Latn")>] LusLatn
                | [<CompiledName("mag_Deva")>] MagDeva
                | [<CompiledName("mai_Deva")>] MaiDeva
                | [<CompiledName("mal_Mlym")>] MalMlym
                | [<CompiledName("mar_Deva")>] MarDeva
                | [<CompiledName("mni_Beng")>] MniBeng
                | [<CompiledName("mni_Mtei")>] MniMtei
                | [<CompiledName("npi_Deva")>] NpiDeva
                | [<CompiledName("ory_Orya")>] OryOrya
                | [<CompiledName("pan_Guru")>] PanGuru
                | [<CompiledName("san_Deva")>] SanDeva
                | [<CompiledName("sat_Olck")>] SatOlck
                | [<CompiledName("snd_Arab")>] SndArab
                | [<CompiledName("snd_Deva")>] SndDeva
                | [<CompiledName("tam_Taml")>] TamTaml
                | [<CompiledName("tel_Telu")>] TelTelu
                | [<CompiledName("urd_Arab")>] UrdArab
                | [<CompiledName("unr_Deva")>] UnrDeva

        module AiCfAisingaporeGemmaSeaLionV427BItChatCompletionResponse =
            type Choices =
                abstract arguments: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set
                abstract logprobs: option<obj> with get, set

                [<CompiledName("stop_reason")>]
                abstract stopReason: option<D1SessionBookmark> with get, set

                [<CompiledName("finish_reason")>]
                abstract finishReason: option<D1SessionBookmark> with get, set

                abstract message: option<Choices.Message> with get, set
                abstract index: option<float> with get, set

                [<CompiledName("function")>]
                abstract ``function``: Choices.Function with get, set

                [<CompiledName("type")>]
                abstract ``type``: Choices.Type with get, set

                abstract id: D1SessionBookmark with get, set

                [<CompiledName("tool_calls")>]
                abstract toolCalls: option<Array<AiTextGenerationToolOutput>> with get, set

                [<CompiledName("reasoning_content")>]
                abstract reasoningContent: option<D1SessionBookmark> with get, set

                abstract content: D1SessionBookmark with get, set
                abstract role: D1SessionBookmark with get, set

            type Usage =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Object = | [<CompiledName("chat.completion")>] ``Chat.completion``

        module AiCfAisingaporeGemmaSeaLionV427BItJSONMode =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("json_schema")>] JsonSchema

        module AiCfAisingaporeGemmaSeaLionV427BItJSONMode1 =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("json_schema")>] JsonSchema

        module AiCfAisingaporeGemmaSeaLionV427BItJSONMode2 =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("json_schema")>] JsonSchema

        module AiCfAisingaporeGemmaSeaLionV427BItJSONMode3 =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("json_schema")>] JsonSchema

        module AiCfAisingaporeGemmaSeaLionV427BItMessages =
            type Messages =
                abstract content: U2<Array<Messages.Content>, D1SessionBookmark> with get, set
                abstract role: D1SessionBookmark with get, set
                abstract text: option<D1SessionBookmark> with get, set

                [<CompiledName("type")>]
                abstract ``type``: option<D1SessionBookmark> with get, set

            type Tools =
                abstract description: D1SessionBookmark with get, set

                [<CompiledName("type")>]
                abstract ``type``: D1SessionBookmark with get, set

                abstract properties: Tools.Properties with get, set
                abstract required: option<Array<D1SessionBookmark>> with get, set

                [<CompiledName("function")>]
                abstract ``function``: Tools.Function with get, set

                abstract parameters: Tools.Parameters with get, set
                abstract name: D1SessionBookmark with get, set
                abstract Item: k: D1SessionBookmark -> Tools.Tools

        module AiCfAisingaporeGemmaSeaLionV427BItTextCompletionResponse =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Object = | [<CompiledName("text_completion")>] TextCompletion

            type Choices =
                [<CompiledName("prompt_logprobs")>]
                abstract promptLogprobs: option<obj> with get, set

                abstract logprobs: option<obj> with get, set

                [<CompiledName("stop_reason")>]
                abstract stopReason: option<D1SessionBookmark> with get, set

                [<CompiledName("finish_reason")>]
                abstract finishReason: D1SessionBookmark with get, set

                abstract text: D1SessionBookmark with get, set
                abstract index: float with get, set

            type Usage =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

        module AiCfBaaiBgeM3OutputEmbedding =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Pooling =
                | [<CompiledName("mean")>] Mean
                | [<CompiledName("cls")>] Cls

        module AiCfBaaiBgeM3OutputEmbeddingForContexts =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Pooling =
                | [<CompiledName("mean")>] Mean
                | [<CompiledName("cls")>] Cls

        module AiCfBaaiBgeRerankerBaseInput =
            type Contexts =
                abstract text: option<D1SessionBookmark> with get, set

        module AiCfBaaiBgeRerankerBaseOutput =
            type Response =
                abstract score: option<float> with get, set
                abstract id: option<float> with get, set

        module AiCfBlackForestLabsFlux2DevInput =
            type Multipart =
                abstract contentType: option<D1SessionBookmark> with get, set
                abstract body: option<obj> with get, set

        module AiCfBlackForestLabsFlux2Klein4BInput =
            type Multipart =
                abstract contentType: option<D1SessionBookmark> with get, set
                abstract body: option<obj> with get, set

        module AiCfBlackForestLabsFlux2Klein9BInput =
            type Multipart =
                abstract contentType: option<D1SessionBookmark> with get, set
                abstract body: option<obj> with get, set

        module AiCfDeepgramAura1Input =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Speaker =
                | [<CompiledName("angus")>] Angus
                | [<CompiledName("asteria")>] Asteria
                | [<CompiledName("arcas")>] Arcas
                | [<CompiledName("orion")>] Orion
                | [<CompiledName("orpheus")>] Orpheus
                | [<CompiledName("athena")>] Athena
                | [<CompiledName("luna")>] Luna
                | [<CompiledName("zeus")>] Zeus
                | [<CompiledName("perseus")>] Perseus
                | [<CompiledName("helios")>] Helios
                | [<CompiledName("hera")>] Hera
                | [<CompiledName("stella")>] Stella

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Container =
                | [<CompiledName("none")>] None
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("ogg")>] Ogg

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Encoding =
                | [<CompiledName("linear16")>] Linear16
                | [<CompiledName("flac")>] Flac
                | [<CompiledName("mulaw")>] Mulaw
                | [<CompiledName("alaw")>] Alaw
                | [<CompiledName("mp3")>] Mp3
                | [<CompiledName("opus")>] Opus
                | [<CompiledName("aac")>] Aac

        module AiCfDeepgramAura2EnInput =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Encoding =
                | [<CompiledName("linear16")>] Linear16
                | [<CompiledName("flac")>] Flac
                | [<CompiledName("mulaw")>] Mulaw
                | [<CompiledName("alaw")>] Alaw
                | [<CompiledName("mp3")>] Mp3
                | [<CompiledName("opus")>] Opus
                | [<CompiledName("aac")>] Aac

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Speaker =
                | [<CompiledName("amalthea")>] Amalthea
                | [<CompiledName("andromeda")>] Andromeda
                | [<CompiledName("apollo")>] Apollo
                | [<CompiledName("arcas")>] Arcas
                | [<CompiledName("aries")>] Aries
                | [<CompiledName("asteria")>] Asteria
                | [<CompiledName("athena")>] Athena
                | [<CompiledName("atlas")>] Atlas
                | [<CompiledName("aurora")>] Aurora
                | [<CompiledName("callista")>] Callista
                | [<CompiledName("cora")>] Cora
                | [<CompiledName("cordelia")>] Cordelia
                | [<CompiledName("delia")>] Delia
                | [<CompiledName("draco")>] Draco
                | [<CompiledName("electra")>] Electra
                | [<CompiledName("harmonia")>] Harmonia
                | [<CompiledName("helena")>] Helena
                | [<CompiledName("hera")>] Hera
                | [<CompiledName("hermes")>] Hermes
                | [<CompiledName("hyperion")>] Hyperion
                | [<CompiledName("iris")>] Iris
                | [<CompiledName("janus")>] Janus
                | [<CompiledName("juno")>] Juno
                | [<CompiledName("jupiter")>] Jupiter
                | [<CompiledName("luna")>] Luna
                | [<CompiledName("mars")>] Mars
                | [<CompiledName("minerva")>] Minerva
                | [<CompiledName("neptune")>] Neptune
                | [<CompiledName("odysseus")>] Odysseus
                | [<CompiledName("ophelia")>] Ophelia
                | [<CompiledName("orion")>] Orion
                | [<CompiledName("orpheus")>] Orpheus
                | [<CompiledName("pandora")>] Pandora
                | [<CompiledName("phoebe")>] Phoebe
                | [<CompiledName("pluto")>] Pluto
                | [<CompiledName("saturn")>] Saturn
                | [<CompiledName("thalia")>] Thalia
                | [<CompiledName("theia")>] Theia
                | [<CompiledName("vesta")>] Vesta
                | [<CompiledName("zeus")>] Zeus

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Container =
                | [<CompiledName("none")>] None
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("ogg")>] Ogg

        module AiCfDeepgramAura2EsInput =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Container =
                | [<CompiledName("none")>] None
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("ogg")>] Ogg

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Speaker =
                | [<CompiledName("sirio")>] Sirio
                | [<CompiledName("nestor")>] Nestor
                | [<CompiledName("carina")>] Carina
                | [<CompiledName("celeste")>] Celeste
                | [<CompiledName("alvaro")>] Alvaro
                | [<CompiledName("diana")>] Diana
                | [<CompiledName("aquila")>] Aquila
                | [<CompiledName("selena")>] Selena
                | [<CompiledName("estrella")>] Estrella
                | [<CompiledName("javier")>] Javier

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Encoding =
                | [<CompiledName("linear16")>] Linear16
                | [<CompiledName("flac")>] Flac
                | [<CompiledName("mulaw")>] Mulaw
                | [<CompiledName("alaw")>] Alaw
                | [<CompiledName("mp3")>] Mp3
                | [<CompiledName("opus")>] Opus
                | [<CompiledName("aac")>] Aac

        module AiCfDeepgramFluxInput =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type MipOptOut =
                | [<CompiledName("true")>] True
                | [<CompiledName("false")>] False

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Encoding = | [<CompiledName("linear16")>] Linear16

        module AiCfDeepgramFluxOutput =
            type Words =
                abstract confidence: float with get, set
                abstract word: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Event =
                | Update
                | StartOfTurn
                | EagerEndOfTurn
                | TurnResumed
                | EndOfTurn

        module AiCfDeepgramNova3Input =
            type Audio =
                abstract contentType: D1SessionBookmark with get, set
                abstract body: obj with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type CustomTopicMode =
                | [<CompiledName("extended")>] Extended
                | [<CompiledName("strict")>] Strict

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Encoding =
                | [<CompiledName("linear16")>] Linear16
                | [<CompiledName("flac")>] Flac
                | [<CompiledName("mulaw")>] Mulaw
                | [<CompiledName("amr-nb")>] AmrNb
                | [<CompiledName("amr-wb")>] AmrWb
                | [<CompiledName("opus")>] Opus
                | [<CompiledName("speex")>] Speex
                | [<CompiledName("g729")>] G729

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Mode =
                | [<CompiledName("general")>] General
                | [<CompiledName("medical")>] Medical
                | [<CompiledName("finance")>] Finance

        module AiCfDeepgramNova3Output =
            type Results =
                abstract words: option<Array<Results.Words>> with get, set
                abstract transcript: option<D1SessionBookmark> with get, set
                abstract confidence: option<float> with get, set
                abstract alternatives: option<Array<Results.Alternatives>> with get, set
                abstract sentiments: option<Results.Sentiments> with get, set
                abstract summary: option<Results.Summary> with get, set
                abstract channels: option<Array<Results.Channels>> with get, set
                abstract short: option<D1SessionBookmark> with get, set
                abstract result: option<D1SessionBookmark> with get, set

                [<CompiledName("sentiment_score")>]
                abstract sentimentScore: option<float> with get, set

                abstract sentiment: option<D1SessionBookmark> with get, set
                abstract average: option<Results.Average> with get, set
                abstract segments: option<Array<Results.Segments>> with get, set
                abstract word: option<D1SessionBookmark> with get, set
                abstract start: option<float> with get, set

                [<CompiledName("end")>]
                abstract ``end``: option<float> with get, set

                [<CompiledName("end_word")>]
                abstract endWord: option<float> with get, set

                [<CompiledName("start_word")>]
                abstract startWord: option<float> with get, set

                abstract text: option<D1SessionBookmark> with get, set

        module AiCfGoogleGemma312BItMessages =
            type Messages =
                [<CompiledName("image_url")>]
                abstract imageUrl: option<Messages.ImageUrl> with get, set

                abstract text: option<D1SessionBookmark> with get, set

                [<CompiledName("type")>]
                abstract ``type``: option<D1SessionBookmark> with get, set

                abstract content: option<U2<Array<Messages.Content>, D1SessionBookmark>> with get, set
                abstract role: option<D1SessionBookmark> with get, set
                abstract url: option<D1SessionBookmark> with get, set

        module AiCfGoogleGemma312BItOutput =
            type Usage =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

        module AiCfMetaLlama3370BInstructFp8FastAsyncBatch =
            type Requests =
                [<CompiledName("response_format")>]
                abstract responseFormat: option<AiCfMetaLlama3370BInstructFp8FastJSONMode2> with get, set

                [<CompiledName("presence_penalty")>]
                abstract presencePenalty: option<float> with get, set

                [<CompiledName("frequency_penalty")>]
                abstract frequencyPenalty: option<float> with get, set

                [<CompiledName("repetition_penalty")>]
                abstract repetitionPenalty: option<float> with get, set

                abstract seed: option<float> with get, set

                [<CompiledName("top_p")>]
                abstract topP: option<float> with get, set

                abstract temperature: option<float> with get, set

                [<CompiledName("max_tokens")>]
                abstract maxTokens: option<float> with get, set

                abstract stream: option<bool> with get, set
                abstract prompt: option<D1SessionBookmark> with get, set

                [<CompiledName("external_reference")>]
                abstract externalReference: option<D1SessionBookmark> with get, set

        module AiCfMetaLlama3370BInstructFp8FastJSONMode =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("json_schema")>] JsonSchema

        module AiCfMetaLlama3370BInstructFp8FastJSONMode1 =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("json_schema")>] JsonSchema

        module AiCfMetaLlama3370BInstructFp8FastJSONMode2 =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("json_schema")>] JsonSchema

        module AiCfMetaLlama4Scout17B16EInstructJSONMode =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("json_schema")>] JsonSchema

        module AiCfMetaLlama4Scout17B16EInstructMessages =
            type Messages =
                abstract url: option<D1SessionBookmark> with get, set

                [<CompiledName("image_url")>]
                abstract imageUrl: option<Messages.ImageUrl> with get, set

                abstract text: option<D1SessionBookmark> with get, set

                [<CompiledName("type")>]
                abstract ``type``: option<D1SessionBookmark> with get, set

                abstract content: option<U3<Array<Messages.Content>, Messages.Content, D1SessionBookmark>> with get, set

                [<CompiledName("tool_call_id")>]
                abstract toolCallId: option<D1SessionBookmark> with get, set

                abstract role: option<D1SessionBookmark> with get, set

        module AiCfMetaLlama4Scout17B16EInstructOutput =
            type Usage =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

        module AiCfMetaLlamaGuard38BInput =
            type Messages =
                abstract content: D1SessionBookmark with get, set
                abstract role: Messages.Role with get, set

            type ResponseFormat =
                [<CompiledName("type")>]
                abstract ``type``: option<D1SessionBookmark> with get, set

        module AiCfMetaLlamaGuard38BOutput =
            type Usage =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

            type Response =
                abstract categories: option<Array<D1SessionBookmark>> with get, set
                abstract safe: option<bool> with get, set

        module AiCfMistralaiMistralSmall3124BInstructOutput =
            type Usage =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

        module AiCfOpenaiWhisperLargeV3TurboInput =
            type Audio =
                abstract contentType: option<D1SessionBookmark> with get, set
                abstract body: option<obj> with get, set

        module AiCfOpenaiWhisperLargeV3TurboOutput =
            type Segments =
                abstract words: option<Array<Segments.Words>> with get, set

                [<CompiledName("no_speech_prob")>]
                abstract noSpeechProb: option<float> with get, set

                [<CompiledName("compression_ratio")>]
                abstract compressionRatio: option<float> with get, set

                [<CompiledName("avg_logprob")>]
                abstract avgLogprob: option<float> with get, set

                abstract temperature: option<float> with get, set
                abstract text: option<D1SessionBookmark> with get, set

                [<CompiledName("end")>]
                abstract ``end``: option<float> with get, set

                abstract start: option<float> with get, set
                abstract word: option<D1SessionBookmark> with get, set

            type TranscriptionInfo =
                [<CompiledName("duration_after_vad")>]
                abstract durationAfterVad: option<float> with get, set

                abstract duration: option<float> with get, set

                [<CompiledName("language_probability")>]
                abstract languageProbability: option<float> with get, set

                abstract language: option<D1SessionBookmark> with get, set

        module AiCfQwenQwen25Coder32BInstructJSONMode =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("json_schema")>] JsonSchema

        module AiCfQwenQwen25Coder32BInstructJSONMode1 =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("json_schema")>] JsonSchema

        module AiCfQwenQwen25Coder32BInstructMessages =
            type Messages =
                abstract content: D1SessionBookmark with get, set
                abstract role: D1SessionBookmark with get, set

        module AiCfQwenQwen25Coder32BInstructOutput =
            type Usage =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

        module AiCfQwenQwen330BA3BFp8ChatCompletionResponse =
            type Usage =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Object = | [<CompiledName("chat.completion")>] ``Chat.completion``

        module AiCfQwenQwen330BA3BFp8JSONMode =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("json_schema")>] JsonSchema

        module AiCfQwenQwen330BA3BFp8JSONMode1 =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("json_schema")>] JsonSchema

        module AiCfQwenQwen330BA3BFp8JSONMode2 =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("json_schema")>] JsonSchema

        module AiCfQwenQwen330BA3BFp8JSONMode3 =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("json_schema")>] JsonSchema

        module AiCfQwenQwen330BA3BFp8TextCompletionResponse =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Object = | [<CompiledName("text_completion")>] TextCompletion

            type Usage =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

        module AiCfQwenQwq32BOutput =
            type Usage =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

        module AiGateway =
            type GetLog =
                [<CompiledName("created_at")>]
                abstract createdAt: Date with get, set

                [<CompiledName("response_head_complete")>]
                abstract responseHeadComplete: bool with get, set

                [<CompiledName("response_head")>]
                abstract responseHead: option<D1SessionBookmark> with get, set

                [<CompiledName("response_size")>]
                abstract responseSize: float with get, set

                [<CompiledName("request_head_complete")>]
                abstract requestHeadComplete: bool with get, set

                [<CompiledName("request_head")>]
                abstract requestHead: option<D1SessionBookmark> with get, set

                [<CompiledName("request_size")>]
                abstract requestSize: float with get, set

                [<CompiledName("custom_cost")>]
                abstract customCost: option<bool> with get, set

                abstract cost: option<float> with get, set
                abstract step: option<float> with get, set
                abstract metadata: option<GetLog.Metadata> with get, set

                [<CompiledName("tokens_out")>]
                abstract tokensOut: option<float> with get, set

                [<CompiledName("tokens_in")>]
                abstract tokensIn: option<float> with get, set

                abstract cached: bool with get, set
                abstract success: bool with get, set

                [<CompiledName("response_content_type")>]
                abstract responseContentType: option<D1SessionBookmark> with get, set

                [<CompiledName("status_code")>]
                abstract statusCode: float with get, set

                [<CompiledName("request_content_type")>]
                abstract requestContentType: option<D1SessionBookmark> with get, set

                [<CompiledName("request_type")>]
                abstract requestType: option<D1SessionBookmark> with get, set

                abstract duration: float with get, set
                abstract path: D1SessionBookmark with get, set

                [<CompiledName("model_type")>]
                abstract modelType: option<D1SessionBookmark> with get, set

                abstract model: D1SessionBookmark with get, set
                abstract provider: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set

            module GetUrl =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Provider =
                    | [<CompiledName("workers-ai")>] WorkersAi
                    | [<CompiledName("anthropic")>] Anthropic
                    | [<CompiledName("aws-bedrock")>] AwsBedrock
                    | [<CompiledName("azure-openai")>] AzureOpenai
                    | [<CompiledName("google-vertex-ai")>] GoogleVertexAi
                    | [<CompiledName("huggingface")>] Huggingface
                    | [<CompiledName("openai")>] Openai
                    | [<CompiledName("perplexity-ai")>] PerplexityAi
                    | [<CompiledName("replicate")>] Replicate
                    | [<CompiledName("groq")>] Groq
                    | [<CompiledName("cohere")>] Cohere
                    | [<CompiledName("google-ai-studio")>] GoogleAiStudio
                    | [<CompiledName("mistral")>] Mistral
                    | [<CompiledName("grok")>] Grok
                    | [<CompiledName("openrouter")>] Openrouter
                    | [<CompiledName("deepseek")>] Deepseek
                    | [<CompiledName("cerebras")>] Cerebras
                    | [<CompiledName("cartesia")>] Cartesia
                    | [<CompiledName("elevenlabs")>] Elevenlabs
                    | [<CompiledName("adobe-firefly")>] AdobeFirefly

            module PatchLog =
                type Data =
                    abstract metadata: option<Data.Metadata> with get, set
                    abstract feedback: option<Data.Feedback> with get, set
                    abstract score: option<float> with get, set
                    abstract Item: key: D1SessionBookmark -> option<obj>

            module Run =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Data =
                    | [<CompiledValue(false)>] False
                    | [<CompiledValue(true)>] True

                type Options =
                    /// <deprecated />
                    abstract id: option<D1SessionBookmark> with get, set
                    abstract retries: option<GatewayRetries> with get, set
                    abstract requestTimeoutMs: option<float> with get, set
                    abstract eventId: option<D1SessionBookmark> with get, set
                    abstract collectLog: option<bool> with get, set
                    abstract metadata: option<Options.Metadata> with get, set
                    abstract skipCache: option<bool> with get, set
                    abstract cacheTtl: option<float> with get, set
                    abstract cacheKey: option<D1SessionBookmark> with get, set
                    abstract id: D1SessionBookmark with get, set
                    abstract backoff: option<CloudflareWorkersModule.WorkflowBackoff> with get, set
                    abstract retryDelayMs: option<float> with get, set
                    abstract maxAttempts: option<Options.MaxAttempts> with get, set
                    abstract signal: option<AbortSignal> with get, set
                    abstract extraHeaders: option<obj> with get, set
                    abstract gateway: option<UniversalGatewayOptions> with get, set

        module AiGatewayPatchLog =
            type Feedback =
                | ``-1`` = -1
                | ``1`` = 1

        module AiModelsSearchObject =
            type Task =
                abstract description: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set

        module AiOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Gateway =
                | [<CompiledName("constant")>] Constant
                | [<CompiledName("linear")>] Linear
                | [<CompiledName("exponential")>] Exponential

        module AiSearchChatCompletionsRequest =
            type AiSearchOptions =
                abstract cache: option<AiSearchOptions.Cache> with get, set
                abstract reranking: option<AiSearchOptions.Reranking> with get, set

                [<CompiledName("query_rewrite")>]
                abstract queryRewrite: option<AiSearchOptions.QueryRewrite> with get, set

                abstract retrieval: option<AiSearchOptions.Retrieval> with get, set

                [<CompiledName("match_threshold")>]
                abstract matchThreshold: option<float> with get, set

                abstract model: option<D1SessionBookmark> with get, set
                abstract enabled: option<bool> with get, set

                [<CompiledName("rewrite_prompt")>]
                abstract rewritePrompt: option<D1SessionBookmark> with get, set

                [<CompiledName("$nin")>]
                abstract ``$nin``: option<Array<U3<AiSearchOptions.``$nin``, D1SessionBookmark, float>>> with get, set

                [<CompiledName("$in")>]
                abstract ``$in``: option<Array<U3<AiSearchOptions.``$in``, D1SessionBookmark, float>>> with get, set

                [<CompiledName("cache_threshold")>]
                abstract cacheThreshold: option<AiSearchOptions.CacheThreshold> with get, set

                [<CompiledName("$gte")>]
                abstract ``$gte``: option<U3<AiSearchOptions.``$gte``, D1SessionBookmark, float>> with get, set

                [<CompiledName("$gt")>]
                abstract ``$gt``: option<U3<AiSearchOptions.``$gt``, D1SessionBookmark, float>> with get, set

                [<CompiledName("$lte")>]
                abstract ``$lte``: option<U3<AiSearchOptions.``$lte``, D1SessionBookmark, float>> with get, set

                [<CompiledName("$lt")>]
                abstract ``$lt``: option<U3<AiSearchOptions.``$lt``, D1SessionBookmark, float>> with get, set

                [<CompiledName("$ne")>]
                abstract ``$ne``: option<U3<AiSearchOptions.``$ne``, D1SessionBookmark, float>> with get, set

                [<CompiledName("$eq")>]
                abstract ``$eq``: option<U3<AiSearchOptions.``$eq``, D1SessionBookmark, float>> with get, set

                [<CompiledName("boost_by")>]
                abstract boostBy: option<Array<AiSearchOptions.BoostBy>> with get, set

                [<CompiledName("return_on_failure")>]
                abstract returnOnFailure: option<bool> with get, set

                [<CompiledName("metadata_only")>]
                abstract metadataOnly: option<bool> with get, set

                [<CompiledName("context_expansion")>]
                abstract contextExpansion: option<float> with get, set

                abstract filters: option<VectorizeVectorMetadataFilter> with get, set

                [<CompiledName("max_num_results")>]
                abstract maxNumResults: option<float> with get, set

                [<CompiledName("keyword_match_mode")>]
                abstract keywordMatchMode: option<AiSearchOptions.KeywordMatchMode> with get, set

                [<CompiledName("fusion_method")>]
                abstract fusionMethod: option<AiSearchOptions.FusionMethod> with get, set

                [<CompiledName("retrieval_type")>]
                abstract retrievalType: option<AiSearchOptions.RetrievalType> with get, set

                abstract Item: key: D1SessionBookmark -> option<obj>

                abstract Item:
                    key: D1SessionBookmark ->
                        option<
                            U5<
                                AiSearchOptions.AiSearchOptions,
                                AiSearchOptions.AiSearchOptions,
                                AiSearchOptions.AiSearchOptions,
                                D1SessionBookmark,
                                float
                             >
                         >

        module AiSearchChatCompletionsResponse =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Choices =
                | [<CompiledName("system")>] System
                | [<CompiledName("developer")>] Developer
                | [<CompiledName("user")>] User
                | [<CompiledName("assistant")>] Assistant
                | [<CompiledName("tool")>] Tool

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Chunks =
                | [<CompiledName("rrf")>] Rrf
                | [<CompiledName("max")>] Max

        module AiSearchConfig =
            type IndexMethod =
                abstract keyword: option<bool> with get, set
                abstract vector: option<bool> with get, set

            type SyncInterval =
                | ``3600`` = 3600
                | ``7200`` = 7200
                | ``14400`` = 14400
                | ``21600`` = 21600
                | ``43200`` = 43200
                | ``86400`` = 86400

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type CacheThreshold =
                | [<CompiledName("super_strict_match")>] SuperStrictMatch
                | [<CompiledName("close_enough")>] CloseEnough
                | [<CompiledName("flexible_friend")>] FlexibleFriend
                | [<CompiledName("anything_goes")>] AnythingGoes

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type FusionMethod =
                | [<CompiledName("max")>] Max
                | [<CompiledName("rrf")>] Rrf

        module AiSearchInstance =
            type Stats =
                abstract dimensions: float with get, set
                abstract vectorsCount: float with get, set
                abstract r2: option<Stats.R2> with get, set
                abstract vectorize: option<Stats.Vectorize> with get, set
                abstract objectCount: float with get, set
                abstract metadataSizeBytes: float with get, set
                abstract payloadSizeBytes: float with get, set
                abstract engine: option<Stats.Engine> with get, set

                [<CompiledName("last_activity")>]
                abstract lastActivity: option<D1SessionBookmark> with get, set

                abstract outdated: option<float> with get, set
                abstract skipped: option<float> with get, set
                abstract error: option<float> with get, set
                abstract completed: option<float> with get, set
                abstract running: option<float> with get, set
                abstract queued: option<float> with get, set

            type Update =
                abstract metadata: option<Update.Metadata> with get, set

                [<CompiledName("sync_interval")>]
                abstract syncInterval: option<Update.SyncInterval> with get, set

                [<CompiledName("custom_metadata")>]
                abstract customMetadata: option<Array<Update.CustomMetadata>> with get, set

                [<CompiledName("cache_threshold")>]
                abstract cacheThreshold: option<Update.CacheThreshold> with get, set

                abstract cache: option<bool> with get, set

                [<CompiledName("max_num_results")>]
                abstract maxNumResults: option<float> with get, set

                [<CompiledName("score_threshold")>]
                abstract scoreThreshold: option<float> with get, set

                [<CompiledName("chunk_overlap")>]
                abstract chunkOverlap: option<float> with get, set

                [<CompiledName("chunk_size")>]
                abstract chunkSize: option<float> with get, set

                abstract chunk: option<bool> with get, set

                [<CompiledName("retrieval_options")>]
                abstract retrievalOptions: option<Update.RetrievalOptions> with get, set

                [<CompiledName("indexing_options")>]
                abstract indexingOptions: option<Update.IndexingOptions> with get, set

                [<CompiledName("fusion_method")>]
                abstract fusionMethod: option<Update.FusionMethod> with get, set

                [<CompiledName("index_method")>]
                abstract indexMethod: option<Update.IndexMethod> with get, set

                /// <deprecated>
                /// Use index_method instead.
                /// </deprecated>
                [<CompiledName("hybrid_search_enabled")>]
                abstract hybridSearchEnabled: option<bool> with get, set

                [<CompiledName("reranking_model")>]
                abstract rerankingModel: option<D1SessionBookmark> with get, set

                [<CompiledName("rewrite_model")>]
                abstract rewriteModel: option<D1SessionBookmark> with get, set

                [<CompiledName("ai_search_model")>]
                abstract aiSearchModel: option<D1SessionBookmark> with get, set

                [<CompiledName("embedding_model")>]
                abstract embeddingModel: option<D1SessionBookmark> with get, set

                abstract reranking: option<bool> with get, set

                [<CompiledName("rewrite_query")>]
                abstract rewriteQuery: option<bool> with get, set

                [<CompiledName("ai_gateway_id")>]
                abstract aiGatewayId: option<D1SessionBookmark> with get, set

                [<CompiledName("token_id")>]
                abstract tokenId: option<D1SessionBookmark> with get, set

                [<CompiledName("modified_at")>]
                abstract modifiedAt: option<D1SessionBookmark> with get, set

                [<CompiledName("created_at")>]
                abstract createdAt: option<D1SessionBookmark> with get, set

                [<CompiledName("namespace")>]
                abstract ``namespace``: option<D1SessionBookmark> with get, set

                abstract status: option<D1SessionBookmark> with get, set
                abstract paused: option<bool> with get, set

                [<CompiledName("source_params")>]
                abstract sourceParams: option<obj> with get, set

                abstract source: option<D1SessionBookmark> with get, set

                [<CompiledName("type")>]
                abstract ``type``: option<U2<Update.Type, D1SessionBookmark>> with get, set

                abstract id: D1SessionBookmark with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

            type ChatCompletions =
                abstract chunks: Array<ChatCompletions.Chunks> with get, set
                abstract choices: Array<ChatCompletions.Choices> with get, set
                abstract model: option<D1SessionBookmark> with get, set
                abstract object: option<D1SessionBookmark> with get, set
                abstract id: option<D1SessionBookmark> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

            type Search =
                abstract chunks: Array<Search.Chunks> with get, set

                [<CompiledName("search_query")>]
                abstract searchQuery: D1SessionBookmark with get, set

            module ChatCompletions =
                type Params =
                    abstract stream: Params.Stream with get, set

                    [<CompiledName("ai_search_options")>]
                    abstract aiSearchOptions: option<AiSearchOptions> with get, set

                    abstract stream: option<bool> with get, set
                    abstract model: option<D1SessionBookmark> with get, set
                    abstract messages: Array<AiSearchMessage> with get, set
                    abstract Item: key: D1SessionBookmark -> option<obj>

            module Search =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Params =
                    | [<CompiledValue(false)>] False
                    | [<CompiledValue(true)>] True
                    | [<CompiledName("super_strict_match")>] SuperStrictMatch
                    | [<CompiledName("close_enough")>] CloseEnough
                    | [<CompiledName("flexible_friend")>] FlexibleFriend
                    | [<CompiledName("anything_goes")>] AnythingGoes
                    | [<CompiledName("max")>] Max
                    | [<CompiledName("rrf")>] Rrf
                    | [<CompiledName("and")>] And
                    | [<CompiledName("or")>] Or
                    | [<CompiledName("vector")>] Vector
                    | [<CompiledName("keyword")>] Keyword
                    | [<CompiledName("hybrid")>] Hybrid

            module Update =
                type Config =
                    abstract metadata: option<Config.Metadata> with get, set

                    [<CompiledName("sync_interval")>]
                    abstract syncInterval: option<Config.SyncInterval> with get, set

                    [<CompiledName("namespace")>]
                    abstract ``namespace``: option<D1SessionBookmark> with get, set

                    [<CompiledName("custom_metadata")>]
                    abstract customMetadata: option<Array<Config.CustomMetadata>> with get, set

                    [<CompiledName("cache_threshold")>]
                    abstract cacheThreshold: option<Config.CacheThreshold> with get, set

                    abstract cache: option<Config.Cache> with get, set

                    [<CompiledName("max_num_results")>]
                    abstract maxNumResults: option<float> with get, set

                    [<CompiledName("score_threshold")>]
                    abstract scoreThreshold: option<float> with get, set

                    [<CompiledName("chunk_overlap")>]
                    abstract chunkOverlap: option<float> with get, set

                    [<CompiledName("chunk_size")>]
                    abstract chunkSize: option<float> with get, set

                    abstract chunk: option<Config.Chunk> with get, set

                    [<CompiledName("retrieval_options")>]
                    abstract retrievalOptions: option<Config.RetrievalOptions> with get, set

                    [<CompiledName("indexing_options")>]
                    abstract indexingOptions: option<Config.IndexingOptions> with get, set

                    [<CompiledName("fusion_method")>]
                    abstract fusionMethod: option<Config.FusionMethod> with get, set

                    [<CompiledName("index_method")>]
                    abstract indexMethod: option<Config.IndexMethod> with get, set

                    [<CompiledName("hybrid_search_enabled")>]
                    abstract hybridSearchEnabled: option<Config.HybridSearchEnabled> with get, set

                    [<CompiledName("reranking_model")>]
                    abstract rerankingModel: option<D1SessionBookmark> with get, set

                    [<CompiledName("rewrite_model")>]
                    abstract rewriteModel: option<D1SessionBookmark> with get, set

                    [<CompiledName("ai_search_model")>]
                    abstract aiSearchModel: option<D1SessionBookmark> with get, set

                    [<CompiledName("embedding_model")>]
                    abstract embeddingModel: option<D1SessionBookmark> with get, set

                    abstract reranking: option<Config.Reranking> with get, set

                    [<CompiledName("rewrite_query")>]
                    abstract rewriteQuery: option<Config.RewriteQuery> with get, set

                    [<CompiledName("ai_gateway_id")>]
                    abstract aiGatewayId: option<D1SessionBookmark> with get, set

                    [<CompiledName("token_id")>]
                    abstract tokenId: option<D1SessionBookmark> with get, set

                    [<CompiledName("source_params")>]
                    abstract sourceParams: option<obj> with get, set

                    abstract source: option<D1SessionBookmark> with get, set

                    [<CompiledName("type")>]
                    abstract ``type``: option<D1SessionBookmark> with get, set

                    abstract id: option<D1SessionBookmark> with get, set
                    abstract keyword: option<bool> with get, set
                    abstract vector: option<bool> with get, set

                    [<CompiledName("data_type")>]
                    abstract dataType: Config.DataType with get, set

                    [<CompiledName("field_name")>]
                    abstract fieldName: D1SessionBookmark with get, set

                    [<CompiledName("boost_by")>]
                    abstract boostBy: option<Array<Config.BoostBy>> with get, set

                    [<CompiledName("keyword_match_mode")>]
                    abstract keywordMatchMode: option<Config.KeywordMatchMode> with get, set

                    [<CompiledName("keyword_tokenizer")>]
                    abstract keywordTokenizer: option<Config.KeywordTokenizer> with get, set

        module AiSearchInstanceInfo =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type CacheThreshold =
                | [<CompiledName("super_strict_match")>] SuperStrictMatch
                | [<CompiledName("close_enough")>] CloseEnough
                | [<CompiledName("flexible_friend")>] FlexibleFriend
                | [<CompiledName("anything_goes")>] AnythingGoes

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type FusionMethod =
                | [<CompiledName("max")>] Max
                | [<CompiledName("rrf")>] Rrf

            type SyncInterval =
                | ``3600`` = 3600
                | ``7200`` = 7200
                | ``14400`` = 14400
                | ``21600`` = 21600
                | ``43200`` = 43200
                | ``86400`` = 86400

            type IndexMethod =
                abstract keyword: option<bool> with get, set
                abstract vector: option<bool> with get, set

        module AiSearchItem =
            type Logs =
                [<CompiledName("result_info")>]
                abstract resultInfo: Logs.ResultInfo with get, set

                abstract result: Array<AiSearchItemLog> with get, set
                abstract errorType: option<D1SessionBookmark> with get, set
                abstract processingTimeMs: option<float> with get, set
                abstract chunkCount: option<float> with get, set
                abstract fileKey: option<D1SessionBookmark> with get, set
                abstract message: D1SessionBookmark with get, set
                abstract action: D1SessionBookmark with get, set
                abstract timestamp: D1SessionBookmark with get, set
                abstract truncated: bool with get, set
                abstract cursor: option<D1SessionBookmark> with get, set

                [<CompiledName("per_page")>]
                abstract perPage: float with get, set

                abstract count: float with get, set

            type Download =
                abstract size: float with get, set
                abstract filename: D1SessionBookmark with get, set
                abstract contentType: D1SessionBookmark with get, set
                abstract body: ReadableStream<option<obj>> with get, set

            type Chunks =
                abstract offset: float with get, set
                abstract limit: float with get, set
                abstract total: float with get, set
                abstract count: float with get, set
                abstract metadata: option<Chunks.Metadata> with get, set
                abstract key: D1SessionBookmark with get, set
                abstract timestamp: option<float> with get, set
                abstract item: option<Chunks.Item> with get, set

                [<CompiledName("end_byte")>]
                abstract endByte: float with get, set

                [<CompiledName("start_byte")>]
                abstract startByte: float with get, set

                abstract text: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set

                [<CompiledName("result_info")>]
                abstract resultInfo: Chunks.ResultInfo with get, set

                abstract result: Array<AiSearchItemChunk> with get, set

            module Chunks =
                type Params =
                    abstract offset: option<float> with get, set
                    abstract limit: option<float> with get, set

            module Logs =
                type Params =
                    abstract cursor: option<D1SessionBookmark> with get, set
                    abstract limit: option<float> with get, set

        module AiSearchItemChunk =
            type Item =
                abstract metadata: option<Item.Metadata> with get, set
                abstract key: D1SessionBookmark with get, set
                abstract timestamp: option<float> with get, set

        module AiSearchItemChunksResponse =
            type ResultInfo =
                abstract offset: float with get, set
                abstract limit: float with get, set
                abstract total: float with get, set
                abstract count: float with get, set

        module AiSearchItemInfo =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Status =
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("error")>] Error
                | [<CompiledName("skipped")>] Skipped
                | [<CompiledName("queued")>] Queued
                | [<CompiledName("running")>] Running
                | [<CompiledName("outdated")>] Outdated

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type NextAction =
                | INDEX
                | DELETE

        module AiSearchItemLogsResponse =
            type ResultInfo =
                abstract truncated: bool with get, set
                abstract cursor: option<D1SessionBookmark> with get, set

                [<CompiledName("per_page")>]
                abstract perPage: float with get, set

                abstract count: float with get, set

        module AiSearchItems =
            type List =
                [<CompiledName("total_count")>]
                abstract totalCount: float with get, set

                [<CompiledName("per_page")>]
                abstract perPage: float with get, set

                abstract page: float with get, set
                abstract count: float with get, set
                abstract metadata: option<List.Metadata> with get, set

                [<CompiledName("created_at")>]
                abstract createdAt: option<D1SessionBookmark> with get, set

                [<CompiledName("last_seen_at")>]
                abstract lastSeenAt: option<D1SessionBookmark> with get, set

                [<CompiledName("source_id")>]
                abstract sourceId: option<D1SessionBookmark> with get, set

                [<CompiledName("file_size")>]
                abstract fileSize: option<float> with get, set

                [<CompiledName("chunks_count")>]
                abstract chunksCount: option<float> with get, set

                [<CompiledName("namespace")>]
                abstract ``namespace``: option<D1SessionBookmark> with get, set

                abstract checksum: option<D1SessionBookmark> with get, set
                abstract error: option<D1SessionBookmark> with get, set

                [<CompiledName("next_action")>]
                abstract nextAction: option<List.NextAction> with get, set

                abstract status: List.Status with get, set
                abstract key: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set

                [<CompiledName("result_info")>]
                abstract resultInfo: option<List.ResultInfo> with get, set

                abstract result: Array<AiSearchItemInfo> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

            module List =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Params =
                    | [<CompiledName("queued")>] Queued
                    | [<CompiledName("running")>] Running
                    | [<CompiledName("completed")>] Completed
                    | [<CompiledName("error")>] Error
                    | [<CompiledName("skipped")>] Skipped
                    | [<CompiledName("outdated")>] Outdated
                    | [<CompiledName("status")>] Status
                    | [<CompiledName("modified_at")>] ModifiedAt

            module Upload =
                type Options =
                    abstract metadata: option<Options.Metadata> with get, set

            module UploadAndPoll =
                type Options =
                    abstract timeoutMs: option<float> with get, set
                    abstract pollIntervalMs: option<float> with get, set
                    abstract metadata: option<Options.Metadata> with get, set

        module AiSearchJob =
            type Logs =
                [<CompiledName("result_info")>]
                abstract resultInfo: option<Logs.ResultInfo> with get, set

                abstract result: Array<AiSearchJobLog> with get, set

                [<CompiledName("total_count")>]
                abstract totalCount: float with get, set

                [<CompiledName("per_page")>]
                abstract perPage: float with get, set

                abstract page: float with get, set
                abstract count: float with get, set

                [<CompiledName("created_at")>]
                abstract createdAt: float with get, set

                [<CompiledName("message_type")>]
                abstract messageType: float with get, set

                abstract message: D1SessionBookmark with get, set
                abstract id: float with get, set

            module Logs =
                type Params =
                    [<CompiledName("per_page")>]
                    abstract perPage: option<float> with get, set

                    abstract page: option<float> with get, set

        module AiSearchJobInfo =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Source =
                | [<CompiledName("user")>] User
                | [<CompiledName("schedule")>] Schedule

        module AiSearchJobLogsResponse =
            type ResultInfo =
                [<CompiledName("total_count")>]
                abstract totalCount: float with get, set

                [<CompiledName("per_page")>]
                abstract perPage: float with get, set

                abstract page: float with get, set
                abstract count: float with get, set

        module AiSearchJobs =
            type List =
                [<CompiledName("total_count")>]
                abstract totalCount: float with get, set

                [<CompiledName("per_page")>]
                abstract perPage: float with get, set

                abstract page: float with get, set
                abstract count: float with get, set

                [<CompiledName("end_reason")>]
                abstract endReason: option<D1SessionBookmark> with get, set

                [<CompiledName("ended_at")>]
                abstract endedAt: option<D1SessionBookmark> with get, set

                [<CompiledName("started_at")>]
                abstract startedAt: option<D1SessionBookmark> with get, set

                [<CompiledName("last_seen_at")>]
                abstract lastSeenAt: option<D1SessionBookmark> with get, set

                abstract description: option<D1SessionBookmark> with get, set
                abstract source: List.Source with get, set
                abstract id: D1SessionBookmark with get, set

                [<CompiledName("result_info")>]
                abstract resultInfo: option<List.ResultInfo> with get, set

                abstract result: Array<AiSearchJobInfo> with get, set

            module Create =
                type Params =
                    abstract description: option<D1SessionBookmark> with get, set

            module List =
                type Params =
                    [<CompiledName("per_page")>]
                    abstract perPage: option<float> with get, set

                    abstract page: option<float> with get, set

        module AiSearchListInstancesParams =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type OrderByDirection =
                | [<CompiledName("asc")>] Asc
                | [<CompiledName("desc")>] Desc

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type OrderBy = | [<CompiledName("created_at")>] CreatedAt

        module AiSearchListItemsParams =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Status =
                | [<CompiledName("queued")>] Queued
                | [<CompiledName("running")>] Running
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("error")>] Error
                | [<CompiledName("skipped")>] Skipped
                | [<CompiledName("outdated")>] Outdated

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type SortBy =
                | [<CompiledName("status")>] Status
                | [<CompiledName("modified_at")>] ModifiedAt

        module AiSearchListItemsResponse =
            type ResultInfo =
                [<CompiledName("total_count")>]
                abstract totalCount: float with get, set

                [<CompiledName("per_page")>]
                abstract perPage: float with get, set

                abstract page: float with get, set
                abstract count: float with get, set

        module AiSearchListJobsResponse =
            type ResultInfo =
                [<CompiledName("total_count")>]
                abstract totalCount: float with get, set

                [<CompiledName("per_page")>]
                abstract perPage: float with get, set

                abstract page: float with get, set
                abstract count: float with get, set

        module AiSearchListResponse =
            type ResultInfo =
                [<CompiledName("total_count")>]
                abstract totalCount: float with get, set

                [<CompiledName("per_page")>]
                abstract perPage: float with get, set

                abstract page: float with get, set
                abstract count: float with get, set

        module AiSearchMessage =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Role =
                | [<CompiledName("system")>] System
                | [<CompiledName("developer")>] Developer
                | [<CompiledName("user")>] User
                | [<CompiledName("assistant")>] Assistant
                | [<CompiledName("tool")>] Tool

        module AiSearchMultiChatCompletionsRequest =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type AiSearchOptions =
                | [<CompiledValue(false)>] False
                | [<CompiledValue(true)>] True
                | [<CompiledName("and")>] And
                | [<CompiledName("or")>] Or
                | [<CompiledName("vector")>] Vector
                | [<CompiledName("keyword")>] Keyword
                | [<CompiledName("hybrid")>] Hybrid
                | [<CompiledName("super_strict_match")>] SuperStrictMatch
                | [<CompiledName("close_enough")>] CloseEnough
                | [<CompiledName("flexible_friend")>] FlexibleFriend
                | [<CompiledName("anything_goes")>] AnythingGoes
                | [<CompiledName("max")>] Max
                | [<CompiledName("rrf")>] Rrf

        module AiSearchMultiSearchChunk =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ScoringDetails =
                | [<CompiledName("rrf")>] Rrf
                | [<CompiledName("max")>] Max

            type Item =
                abstract metadata: option<Item.Metadata> with get, set
                abstract key: D1SessionBookmark with get, set
                abstract timestamp: option<float> with get, set

        module AiSearchMultiSearchOptions =
            type Cache =
                [<CompiledName("cache_threshold")>]
                abstract cacheThreshold: option<Cache.CacheThreshold> with get, set

                abstract enabled: option<bool> with get, set

            type QueryRewrite =
                [<CompiledName("rewrite_prompt")>]
                abstract rewritePrompt: option<D1SessionBookmark> with get, set

                abstract model: option<D1SessionBookmark> with get, set
                abstract enabled: option<bool> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Retrieval =
                | [<CompiledValue(false)>] False
                | [<CompiledValue(true)>] True
                | [<CompiledName("and")>] And
                | [<CompiledName("or")>] Or
                | [<CompiledName("max")>] Max
                | [<CompiledName("rrf")>] Rrf
                | [<CompiledName("vector")>] Vector
                | [<CompiledName("keyword")>] Keyword
                | [<CompiledName("hybrid")>] Hybrid

            type Reranking =
                [<CompiledName("match_threshold")>]
                abstract matchThreshold: option<float> with get, set

                abstract model: option<D1SessionBookmark> with get, set
                abstract enabled: option<bool> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

        module AiSearchNamespace =
            type List =
                | ``3600`` = 3600
                | ``7200`` = 7200
                | ``14400`` = 14400
                | ``21600`` = 21600
                | ``43200`` = 43200
                | ``86400`` = 86400

            type ChatCompletions =
                abstract errors: option<Array<AiSearchMultiSearchError>> with get, set
                abstract chunks: Array<AiSearchMultiSearchChunk> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

            type Search =
                abstract message: D1SessionBookmark with get, set

                [<CompiledName("instance_id")>]
                abstract instanceId: D1SessionBookmark with get, set

                abstract errors: option<Array<AiSearchMultiSearchError>> with get, set
                abstract chunks: Array<AiSearchMultiSearchChunk> with get, set

                [<CompiledName("search_query")>]
                abstract searchQuery: D1SessionBookmark with get, set

                [<CompiledName("scoring_details")>]
                abstract scoringDetails: option<Search.ScoringDetails> with get, set

                abstract item: Search.Item with get, set
                abstract text: D1SessionBookmark with get, set
                abstract score: float with get, set

                [<CompiledName("type")>]
                abstract ``type``: D1SessionBookmark with get, set

                abstract id: D1SessionBookmark with get, set
                abstract metadata: option<Search.Metadata> with get, set
                abstract key: D1SessionBookmark with get, set
                abstract timestamp: option<float> with get, set

                [<CompiledName("fusion_method")>]
                abstract fusionMethod: option<Search.FusionMethod> with get, set

                [<CompiledName("reranking_score")>]
                abstract rerankingScore: option<float> with get, set

                [<CompiledName("vector_rank")>]
                abstract vectorRank: option<float> with get, set

                [<CompiledName("keyword_rank")>]
                abstract keywordRank: option<float> with get, set

                [<CompiledName("vector_score")>]
                abstract vectorScore: option<float> with get, set

                [<CompiledName("keyword_score")>]
                abstract keywordScore: option<float> with get, set

                abstract Item: key: D1SessionBookmark -> option<obj>

            module ChatCompletions =
                type Params =
                    [<CompiledName("ai_search_options")>]
                    abstract aiSearchOptions: AiSearchMultiSearchOptions with get, set

                    abstract stream: Params.Stream with get, set
                    abstract Item: key: D1SessionBookmark -> option<obj>

            module Create =
                type Config =
                    abstract metadata: option<Config.Metadata> with get, set

                    [<CompiledName("sync_interval")>]
                    abstract syncInterval: option<Config.SyncInterval> with get, set

                    [<CompiledName("namespace")>]
                    abstract ``namespace``: option<D1SessionBookmark> with get, set

                    [<CompiledName("custom_metadata")>]
                    abstract customMetadata: option<Array<Config.CustomMetadata>> with get, set

                    [<CompiledName("cache_threshold")>]
                    abstract cacheThreshold: option<Config.CacheThreshold> with get, set

                    abstract cache: option<bool> with get, set

                    [<CompiledName("max_num_results")>]
                    abstract maxNumResults: option<float> with get, set

                    [<CompiledName("score_threshold")>]
                    abstract scoreThreshold: option<float> with get, set

                    [<CompiledName("chunk_overlap")>]
                    abstract chunkOverlap: option<float> with get, set

                    [<CompiledName("chunk_size")>]
                    abstract chunkSize: option<float> with get, set

                    abstract chunk: option<bool> with get, set

                    [<CompiledName("retrieval_options")>]
                    abstract retrievalOptions: option<Config.RetrievalOptions> with get, set

                    [<CompiledName("indexing_options")>]
                    abstract indexingOptions: option<Config.IndexingOptions> with get, set

                    [<CompiledName("fusion_method")>]
                    abstract fusionMethod: option<Config.FusionMethod> with get, set

                    [<CompiledName("index_method")>]
                    abstract indexMethod: option<Config.IndexMethod> with get, set

                    /// <deprecated>
                    /// Use index_method instead.
                    /// </deprecated>
                    [<CompiledName("hybrid_search_enabled")>]
                    abstract hybridSearchEnabled: option<bool> with get, set

                    [<CompiledName("reranking_model")>]
                    abstract rerankingModel: option<D1SessionBookmark> with get, set

                    [<CompiledName("rewrite_model")>]
                    abstract rewriteModel: option<D1SessionBookmark> with get, set

                    [<CompiledName("ai_search_model")>]
                    abstract aiSearchModel: option<D1SessionBookmark> with get, set

                    [<CompiledName("embedding_model")>]
                    abstract embeddingModel: option<D1SessionBookmark> with get, set

                    abstract reranking: option<bool> with get, set

                    [<CompiledName("rewrite_query")>]
                    abstract rewriteQuery: option<bool> with get, set

                    [<CompiledName("ai_gateway_id")>]
                    abstract aiGatewayId: option<D1SessionBookmark> with get, set

                    [<CompiledName("token_id")>]
                    abstract tokenId: option<D1SessionBookmark> with get, set

                    [<CompiledName("source_params")>]
                    abstract sourceParams: option<obj> with get, set

                    abstract source: option<D1SessionBookmark> with get, set

                    [<CompiledName("type")>]
                    abstract ``type``: option<U2<Config.Type, D1SessionBookmark>> with get, set

                    abstract id: D1SessionBookmark with get, set
                    abstract Item: key: D1SessionBookmark -> option<obj>

            module List =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Params =
                    | [<CompiledName("asc")>] Asc
                    | [<CompiledName("desc")>] Desc
                    | [<CompiledName("created_at")>] CreatedAt

            module Search =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Params =
                    | [<CompiledName("system")>] System
                    | [<CompiledName("developer")>] Developer
                    | [<CompiledName("user")>] User
                    | [<CompiledName("assistant")>] Assistant
                    | [<CompiledName("tool")>] Tool
                    | [<CompiledName("vector")>] Vector
                    | [<CompiledName("keyword")>] Keyword
                    | [<CompiledName("hybrid")>] Hybrid
                    | [<CompiledValue(false)>] False
                    | [<CompiledValue(true)>] True

        module AiSearchOptions =
            type Cache =
                [<CompiledName("cache_threshold")>]
                abstract cacheThreshold: option<Cache.CacheThreshold> with get, set

                abstract enabled: option<bool> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Retrieval =
                | [<CompiledName("vector")>] Vector
                | [<CompiledName("keyword")>] Keyword
                | [<CompiledName("hybrid")>] Hybrid
                | [<CompiledName("max")>] Max
                | [<CompiledName("rrf")>] Rrf
                | [<CompiledName("and")>] And
                | [<CompiledName("or")>] Or
                | [<CompiledValue(false)>] False
                | [<CompiledValue(true)>] True

            type QueryRewrite =
                [<CompiledName("rewrite_prompt")>]
                abstract rewritePrompt: option<D1SessionBookmark> with get, set

                abstract model: option<D1SessionBookmark> with get, set
                abstract enabled: option<bool> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

            type Reranking =
                [<CompiledName("match_threshold")>]
                abstract matchThreshold: option<float> with get, set

                abstract model: option<D1SessionBookmark> with get, set
                abstract enabled: option<bool> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

        module AiSearchSearchResponse =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Chunks =
                | [<CompiledName("rrf")>] Rrf
                | [<CompiledName("max")>] Max

        module AiSearchStatsResponse =
            type Engine =
                abstract objectCount: float with get, set
                abstract metadataSizeBytes: float with get, set
                abstract payloadSizeBytes: float with get, set
                abstract r2: option<Engine.R2> with get, set
                abstract vectorize: option<Engine.Vectorize> with get, set
                abstract dimensions: float with get, set
                abstract vectorsCount: float with get, set

        module AiTextGenerationInput =
            type ResponseFormat =
                [<CompiledName("json_schema")>]
                abstract jsonSchema: option<obj> with get, set

                [<CompiledName("type")>]
                abstract ``type``: D1SessionBookmark with get, set

        module AiTextGenerationOutput =
            type Usage =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: float with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: float with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: float with get, set

            type ToolCalls = interface end

        module AiTextGenerationToolInput =
            type Function =
                abstract description: option<D1SessionBookmark> with get, set

                [<CompiledName("type")>]
                abstract ``type``: D1SessionBookmark with get, set

                abstract required: Array<D1SessionBookmark> with get, set
                abstract properties: Function.Properties with get, set

                [<CompiledName("type")>]
                abstract ``type``: U2<Function.Type, Function.Type> with get, set

                abstract parameters: option<Function.Parameters> with get, set
                abstract description: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set
                abstract Item: key: D1SessionBookmark -> Function.Function

        module AiTextGenerationToolLegacyInput =
            type Parameters =
                abstract required: Array<D1SessionBookmark> with get, set
                abstract properties: Parameters.Properties with get, set

                [<CompiledName("type")>]
                abstract ``type``: U2<Parameters.Type, Parameters.Type> with get, set

                abstract description: option<D1SessionBookmark> with get, set

                [<CompiledName("type")>]
                abstract ``type``: D1SessionBookmark with get, set

                abstract Item: key: D1SessionBookmark -> Parameters.Parameters

        module AiTextGenerationToolOutput =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("function")>] Function

            type Function =
                abstract arguments: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set

        module AlreadyUploadedError =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Name = | AlreadyUploadedError

        module Artifacts =
            module Create =
                type Opts =
                    abstract setDefaultBranch: option<D1SessionBookmark> with get, set
                    abstract description: option<D1SessionBookmark> with get, set
                    abstract readOnly: option<bool> with get, set

            module Import =
                type Params =
                    abstract target: Params.Target with get, set
                    abstract source: Params.Source with get, set
                    abstract depth: option<float> with get, set
                    abstract branch: option<D1SessionBookmark> with get, set
                    abstract url: D1SessionBookmark with get, set
                    abstract readOnly: option<bool> with get, set
                    abstract description: option<D1SessionBookmark> with get, set
                    abstract opts: option<Params.Opts> with get, set
                    abstract name: D1SessionBookmark with get, set

            module List =
                type Opts =
                    abstract cursor: option<D1SessionBookmark> with get, set
                    abstract limit: option<float> with get, set

        module ArtifactsCreateTokenResult =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Scope =
                | [<CompiledName("read")>] Read
                | [<CompiledName("write")>] Write

        module ArtifactsRepo =
            module CreateToken =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Scope =
                    | [<CompiledName("write")>] Write
                    | [<CompiledName("read")>] Read

            module Fork =
                type Opts =
                    abstract defaultBranchOnly: option<bool> with get, set
                    abstract readOnly: option<bool> with get, set
                    abstract description: option<D1SessionBookmark> with get, set

        module ArtifactsRepoListResult =
            type Repos =
                abstract readOnly: bool with get, set
                abstract lastPushAt: option<D1SessionBookmark> with get, set
                abstract updatedAt: D1SessionBookmark with get, set
                abstract createdAt: D1SessionBookmark with get, set
                abstract defaultBranch: D1SessionBookmark with get, set
                abstract description: option<D1SessionBookmark> with get, set
                abstract source: option<D1SessionBookmark> with get, set
                abstract name: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set

        module ArtifactsTokenInfo =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Scope =
                | [<CompiledName("read")>] Read
                | [<CompiledName("write")>] Write

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type State =
                | [<CompiledName("active")>] Active
                | [<CompiledName("expired")>] Expired
                | [<CompiledName("revoked")>] Revoked

        module AssistantMessage =
            type Audio =
                abstract id: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Role = | [<CompiledName("assistant")>] Assistant

            type FunctionCall =
                abstract arguments: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set

        module AssistantMessageContentPart =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("text")>] Text
                | [<CompiledName("refusal")>] Refusal

        module AudioParams =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Format =
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("aac")>] Aac
                | [<CompiledName("mp3")>] Mp3
                | [<CompiledName("flac")>] Flac
                | [<CompiledName("opus")>] Opus
                | [<CompiledName("pcm16")>] Pcm16

        module AutoRAG =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Search =
                | [<CompiledName("vector_store.search_results.page")>] ``VectorStore.searchResults.page``
                | [<CompiledName("text")>] Text

            type AiSearch =
                abstract response: D1SessionBookmark with get, set

                [<CompiledName("next_page")>]
                abstract nextPage: option<D1SessionBookmark> with get, set

                [<CompiledName("has_more")>]
                abstract hasMore: bool with get, set

                abstract data: Array<AiSearch.Data> with get, set

                [<CompiledName("search_query")>]
                abstract searchQuery: D1SessionBookmark with get, set

                abstract object: AiSearch.Object with get, set

            type List =
                abstract status: D1SessionBookmark with get, set
                abstract paused: bool with get, set

                [<CompiledName("vectorize_name")>]
                abstract vectorizeName: D1SessionBookmark with get, set

                abstract source: D1SessionBookmark with get, set

                [<CompiledName("type")>]
                abstract ``type``: D1SessionBookmark with get, set

                abstract enable: bool with get, set
                abstract id: D1SessionBookmark with get, set

            module AiSearch =
                type Params =
                    [<CompiledName("system_prompt")>]
                    abstract systemPrompt: option<D1SessionBookmark> with get, set

                    abstract stream: option<bool> with get, set

                    [<CompiledName("rewrite_query")>]
                    abstract rewriteQuery: option<bool> with get, set

                    abstract reranking: option<Params.Reranking> with get, set

                    [<CompiledName("ranking_options")>]
                    abstract rankingOptions: option<Params.RankingOptions> with get, set

                    [<CompiledName("max_num_results")>]
                    abstract maxNumResults: option<float> with get, set

                    abstract filters: option<U2<CompoundFilter, ComparisonFilter>> with get, set
                    abstract query: D1SessionBookmark with get, set
                    abstract stream: Params.Stream with get, set

                    [<CompiledName("system_prompt")>]
                    abstract systemPrompt: option<D1SessionBookmark> with get, set

                    [<CompiledName("rewrite_query")>]
                    abstract rewriteQuery: option<Params.RewriteQuery> with get, set

                    abstract reranking: option<Params.Reranking> with get, set

                    [<CompiledName("ranking_options")>]
                    abstract rankingOptions: option<Params.RankingOptions> with get, set

                    [<CompiledName("max_num_results")>]
                    abstract maxNumResults: option<float> with get, set

                    abstract filters: option<U2<CompoundFilter, ComparisonFilter>> with get, set

            module Search =
                type Params =
                    [<CompiledName("score_threshold")>]
                    abstract scoreThreshold: option<float> with get, set

                    abstract ranker: option<D1SessionBookmark> with get, set
                    abstract model: option<D1SessionBookmark> with get, set
                    abstract enabled: option<bool> with get, set
                    abstract value: U3<D1SessionBookmark, float, bool> with get, set

                    [<CompiledName("type")>]
                    abstract ``type``: Params.Type with get, set

                    abstract key: D1SessionBookmark with get, set

                    [<CompiledName("rewrite_query")>]
                    abstract rewriteQuery: option<bool> with get, set

                    abstract reranking: option<Params.Reranking> with get, set

                    [<CompiledName("ranking_options")>]
                    abstract rankingOptions: option<Params.RankingOptions> with get, set

                    [<CompiledName("max_num_results")>]
                    abstract maxNumResults: option<float> with get, set

                    abstract filters: option<U2<CompoundFilter, ComparisonFilter>> with get, set
                    abstract query: D1SessionBookmark with get, set
                    abstract filters: Array<ComparisonFilter> with get, set

        module AutoRagAiSearchRequest =
            type Reranking =
                abstract model: option<D1SessionBookmark> with get, set
                abstract enabled: option<bool> with get, set

            type RankingOptions =
                [<CompiledName("score_threshold")>]
                abstract scoreThreshold: option<float> with get, set

                abstract ranker: option<D1SessionBookmark> with get, set

        module AutoRagAiSearchRequestStreaming =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Stream = | [<CompiledValue(true)>] True

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type RewriteQuery =
                | [<CompiledValue(false)>] False
                | [<CompiledValue(true)>] True

        module AutoRagAiSearchResponse =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Object = | [<CompiledName("vector_store.search_results.page")>] ``VectorStore.searchResults.page``

        module AutoRagSearchRequest =
            type RankingOptions =
                [<CompiledName("score_threshold")>]
                abstract scoreThreshold: option<float> with get, set

                abstract ranker: option<D1SessionBookmark> with get, set

            type Reranking =
                abstract model: option<D1SessionBookmark> with get, set
                abstract enabled: option<bool> with get, set

        module AutoRagSearchResponse =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Object = | [<CompiledName("vector_store.search_results.page")>] ``VectorStore.searchResults.page``

        module BadRequestError =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Name = | BadRequestError

        module BaseAiAutomaticSpeechRecognition =
            type PostProcessedOutputs =
                [<CompiledName("end")>]
                abstract ``end``: float with get, set

                abstract start: float with get, set
                abstract word: D1SessionBookmark with get, set
                abstract vtt: option<D1SessionBookmark> with get, set
                abstract words: option<Array<PostProcessedOutputs.Words>> with get, set
                abstract text: option<D1SessionBookmark> with get, set

            type Inputs =
                abstract audio: AiSentenceSimilarityOutput with get, set

        module BaseAiCfBaaiBgeBaseEnV15 =
            type Inputs =
                abstract pooling: option<Inputs.Pooling> with get, set
                abstract text: U2<Array<D1SessionBookmark>, D1SessionBookmark> with get, set
                abstract requests: Array<Inputs.Requests> with get, set

            type PostProcessedOutputs =
                abstract pooling: option<PostProcessedOutputs.Pooling> with get, set
                abstract data: option<Array<AiSentenceSimilarityOutput>> with get, set
                abstract shape: option<AiSentenceSimilarityOutput> with get, set

        module BaseAiCfBaaiBgeLargeEnV15 =
            type Inputs =
                abstract pooling: option<Inputs.Pooling> with get, set
                abstract text: U2<Array<D1SessionBookmark>, D1SessionBookmark> with get, set
                abstract requests: Array<Inputs.Requests> with get, set

            type PostProcessedOutputs =
                abstract pooling: option<PostProcessedOutputs.Pooling> with get, set
                abstract data: option<Array<AiSentenceSimilarityOutput>> with get, set
                abstract shape: option<AiSentenceSimilarityOutput> with get, set

        module BaseAiCfBaaiBgeM3 =
            type Inputs =
                abstract requests: Array<U2<AiCfBaaiBgeM3InputQueryAndContexts1, AiCfBaaiBgeM3InputEmbedding1>> with get, set

        module BaseAiCfBaaiBgeSmallEnV15 =
            type Inputs =
                abstract requests: Array<Inputs.Requests> with get, set
                abstract pooling: option<Inputs.Pooling> with get, set
                abstract text: U2<Array<D1SessionBookmark>, D1SessionBookmark> with get, set

            type PostProcessedOutputs =
                abstract pooling: option<PostProcessedOutputs.Pooling> with get, set
                abstract data: option<Array<AiSentenceSimilarityOutput>> with get, set
                abstract shape: option<AiSentenceSimilarityOutput> with get, set

        module BaseAiCfGoogleGemma312BIt =
            type PostProcessedOutputs =
                abstract name: option<D1SessionBookmark> with get, set
                abstract arguments: option<obj> with get, set

                [<CompiledName("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

                [<CompiledName("tool_calls")>]
                abstract toolCalls: option<Array<PostProcessedOutputs.ToolCalls>> with get, set

                abstract usage: option<PostProcessedOutputs.Usage> with get, set
                abstract response: D1SessionBookmark with get, set

        module BaseAiCfGoogleGemma426BA4BIT =
            type PostProcessedOutputs =
                [<CompiledName("service_tier")>]
                abstract serviceTier: option<PostProcessedOutputs.ServiceTier> with get, set

                [<CompiledName("system_fingerprint")>]
                abstract systemFingerprint: option<D1SessionBookmark> with get, set

                abstract usage: option<CompletionUsage> with get, set
                abstract choices: Array<ChatCompletionChoice> with get, set
                abstract model: D1SessionBookmark with get, set
                abstract created: float with get, set
                abstract object: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set

                [<CompiledName("function_call")>]
                abstract functionCall: option<PostProcessedOutputs.FunctionCall> with get, set

                [<CompiledName("tool_calls")>]
                abstract toolCalls: option<Array<ChatCompletionMessageToolCall>> with get, set

                abstract audio: option<ChatCompletionAudio> with get, set
                abstract annotations: option<Array<ChatCompletionUrlCitation>> with get, set
                abstract refusal: option<D1SessionBookmark> with get, set
                abstract content: option<D1SessionBookmark> with get, set
                abstract role: PostProcessedOutputs.Role with get, set

                [<CompiledName("url_citation")>]
                abstract urlCitation: PostProcessedOutputs.UrlCitation with get, set

                [<CompiledName("type")>]
                abstract ``type``: PostProcessedOutputs.Type with get, set

                abstract logprobs: option<ChatCompletionLogprobs> with get, set

                [<CompiledName("finish_reason")>]
                abstract finishReason: PostProcessedOutputs.FinishReason with get, set

                abstract message: ChatCompletionResponseMessage with get, set
                abstract index: float with get, set
                abstract transcript: D1SessionBookmark with get, set

                [<CompiledName("expires_at")>]
                abstract expiresAt: float with get, set

                abstract data: D1SessionBookmark with get, set

                [<CompiledName("end_index")>]
                abstract endIndex: float with get, set

                [<CompiledName("start_index")>]
                abstract startIndex: float with get, set

                abstract title: D1SessionBookmark with get, set
                abstract url: D1SessionBookmark with get, set

                [<CompiledName("rejected_prediction_tokens")>]
                abstract rejectedPredictionTokens: option<float> with get, set

                [<CompiledName("accepted_prediction_tokens")>]
                abstract acceptedPredictionTokens: option<float> with get, set

                [<CompiledName("audio_tokens")>]
                abstract audioTokens: option<float> with get, set

                [<CompiledName("reasoning_tokens")>]
                abstract reasoningTokens: option<float> with get, set

                [<CompiledName("cached_tokens")>]
                abstract cachedTokens: option<float> with get, set

                [<CompiledName("completion_tokens_details")>]
                abstract completionTokensDetails: option<CompletionTokensDetails> with get, set

                [<CompiledName("prompt_tokens_details")>]
                abstract promptTokensDetails: option<PromptTokensDetails> with get, set

                [<CompiledName("total_tokens")>]
                abstract totalTokens: float with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: float with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: float with get, set

                abstract bytes: option<AiSentenceSimilarityOutput> with get, set
                abstract logprob: float with get, set
                abstract token: D1SessionBookmark with get, set

                [<CompiledName("top_logprobs")>]
                abstract topLogprobs: Array<ChatCompletionTopLogprob> with get, set

                abstract refusal: option<Array<ChatCompletionTokenLogprob>> with get, set
                abstract content: option<Array<ChatCompletionTokenLogprob>> with get, set
                abstract arguments: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set

        module BaseAiCfMetaLlama3211BVisionInstruct =
            type PostProcessedOutputs =
                [<CompiledName("tool_calls")>]
                abstract toolCalls: option<Array<PostProcessedOutputs.ToolCalls>> with get, set

                abstract response: option<D1SessionBookmark> with get, set

        module BaseAiCfMetaLlama3370BInstructFp8Fast =
            type PostProcessedOutputs =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

                [<CompiledName("tool_calls")>]
                abstract toolCalls: option<Array<PostProcessedOutputs.ToolCalls>> with get, set

                abstract usage: option<PostProcessedOutputs.Usage> with get, set
                abstract response: D1SessionBookmark with get, set

        module BaseAiCfMetaLlama4Scout17B16EInstruct =
            type PostProcessedOutputs =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

                [<CompiledName("function")>]
                abstract ``function``: option<PostProcessedOutputs.Function> with get, set

                [<CompiledName("type")>]
                abstract ``type``: option<D1SessionBookmark> with get, set

                abstract id: option<D1SessionBookmark> with get, set
                abstract arguments: option<obj> with get, set
                abstract name: option<D1SessionBookmark> with get, set

                [<CompiledName("tool_calls")>]
                abstract toolCalls: option<Array<PostProcessedOutputs.ToolCalls>> with get, set

                abstract usage: option<PostProcessedOutputs.Usage> with get, set
                abstract response: D1SessionBookmark with get, set

        module BaseAiCfMetaM2M10012B =
            type Inputs =
                [<CompiledName("target_lang")>]
                abstract targetLang: D1SessionBookmark with get, set

                [<CompiledName("source_lang")>]
                abstract sourceLang: option<D1SessionBookmark> with get, set

                abstract text: D1SessionBookmark with get, set
                abstract requests: Array<Inputs.Requests> with get, set

            type PostProcessedOutputs =
                [<CompiledName("translated_text")>]
                abstract translatedText: option<D1SessionBookmark> with get, set

        module BaseAiCfMistralaiMistralSmall3124BInstruct =
            type PostProcessedOutputs =
                [<CompiledName("tool_calls")>]
                abstract toolCalls: option<Array<PostProcessedOutputs.ToolCalls>> with get, set

                abstract usage: option<PostProcessedOutputs.Usage> with get, set
                abstract response: D1SessionBookmark with get, set

                [<CompiledName("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

        module BaseAiCfMoonshotaiKimiK25 =
            type PostProcessedOutputs =
                abstract bytes: option<AiSentenceSimilarityOutput> with get, set
                abstract logprob: float with get, set
                abstract token: D1SessionBookmark with get, set

                [<CompiledName("service_tier")>]
                abstract serviceTier: option<PostProcessedOutputs.ServiceTier> with get, set

                [<CompiledName("system_fingerprint")>]
                abstract systemFingerprint: option<D1SessionBookmark> with get, set

                abstract usage: option<CompletionUsage> with get, set
                abstract choices: Array<ChatCompletionChoice> with get, set
                abstract model: D1SessionBookmark with get, set
                abstract created: float with get, set
                abstract object: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set
                abstract logprobs: option<ChatCompletionLogprobs> with get, set

                [<CompiledName("finish_reason")>]
                abstract finishReason: PostProcessedOutputs.FinishReason with get, set

                abstract message: ChatCompletionResponseMessage with get, set
                abstract index: float with get, set

                [<CompiledName("function_call")>]
                abstract functionCall: option<PostProcessedOutputs.FunctionCall> with get, set

                [<CompiledName("tool_calls")>]
                abstract toolCalls: option<Array<ChatCompletionMessageToolCall>> with get, set

                abstract audio: option<ChatCompletionAudio> with get, set
                abstract annotations: option<Array<ChatCompletionUrlCitation>> with get, set
                abstract refusal: option<D1SessionBookmark> with get, set
                abstract content: option<D1SessionBookmark> with get, set
                abstract role: PostProcessedOutputs.Role with get, set

                [<CompiledName("url_citation")>]
                abstract urlCitation: PostProcessedOutputs.UrlCitation with get, set

                [<CompiledName("type")>]
                abstract ``type``: PostProcessedOutputs.Type with get, set

                [<CompiledName("completion_tokens_details")>]
                abstract completionTokensDetails: option<CompletionTokensDetails> with get, set

                [<CompiledName("prompt_tokens_details")>]
                abstract promptTokensDetails: option<PromptTokensDetails> with get, set

                [<CompiledName("total_tokens")>]
                abstract totalTokens: float with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: float with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: float with get, set

                [<CompiledName("end_index")>]
                abstract endIndex: float with get, set

                [<CompiledName("start_index")>]
                abstract startIndex: float with get, set

                abstract title: D1SessionBookmark with get, set
                abstract url: D1SessionBookmark with get, set
                abstract arguments: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set
                abstract refusal: option<Array<ChatCompletionTokenLogprob>> with get, set
                abstract content: option<Array<ChatCompletionTokenLogprob>> with get, set

                [<CompiledName("top_logprobs")>]
                abstract topLogprobs: Array<ChatCompletionTopLogprob> with get, set

                [<CompiledName("rejected_prediction_tokens")>]
                abstract rejectedPredictionTokens: option<float> with get, set

                [<CompiledName("accepted_prediction_tokens")>]
                abstract acceptedPredictionTokens: option<float> with get, set

                [<CompiledName("audio_tokens")>]
                abstract audioTokens: option<float> with get, set

                [<CompiledName("reasoning_tokens")>]
                abstract reasoningTokens: option<float> with get, set

                [<CompiledName("cached_tokens")>]
                abstract cachedTokens: option<float> with get, set

                abstract transcript: D1SessionBookmark with get, set

                [<CompiledName("expires_at")>]
                abstract expiresAt: float with get, set

                abstract data: D1SessionBookmark with get, set

        module BaseAiCfNvidiaNemotron3120BA12B =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type PostProcessedOutputs =
                | [<CompiledName("stop")>] Stop
                | [<CompiledName("length")>] Length
                | [<CompiledName("tool_calls")>] ToolCalls
                | [<CompiledName("content_filter")>] ContentFilter
                | [<CompiledName("function_call")>] FunctionCall
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("default")>] Default
                | [<CompiledName("flex")>] Flex
                | [<CompiledName("scale")>] Scale
                | [<CompiledName("priority")>] Priority
                | [<CompiledName("url_citation")>] UrlCitation
                | [<CompiledName("assistant")>] Assistant

        module BaseAiCfOpenaiGptOss20B =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Inputs =
                | [<CompiledName("input_text")>] InputText
                | [<CompiledName("reasoning_text")>] ReasoningText
                | [<CompiledName("reasoning")>] Reasoning
                | [<CompiledName("summary_text")>] SummaryText
                | [<CompiledName("function_call")>] FunctionCall
                | [<CompiledName("message")>] Message
                | [<CompiledName("assistant")>] Assistant
                | [<CompiledName("refusal")>] Refusal
                | [<CompiledName("low")>] Low
                | [<CompiledName("high")>] High
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("output_text")>] OutputText
                | [<CompiledName("message.input_image.image_url")>] ``Message.inputImage.imageUrl``
                | [<CompiledName("message.output_text.logprobs")>] ``Message.outputText.logprobs``
                | [<CompiledName("input_image")>] InputImage
                | [<CompiledName("in_progress")>] InProgress
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("incomplete")>] Incomplete
                | [<CompiledName("function")>] Function
                | [<CompiledName("none")>] None
                | [<CompiledName("medium")>] Medium
                | [<CompiledName("disabled")>] Disabled
                | [<CompiledName("approximate")>] Approximate
                | [<CompiledName("user")>] User
                | [<CompiledName("system")>] System
                | [<CompiledName("developer")>] Developer
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("content")>] Content
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("aac")>] Aac
                | [<CompiledName("mp3")>] Mp3
                | [<CompiledName("flac")>] Flac
                | [<CompiledName("opus")>] Opus
                | [<CompiledName("pcm16")>] Pcm16
                | [<CompiledName("json_schema")>] JsonSchema
                | [<CompiledName("text")>] Text
                | [<CompiledName("minimal")>] Minimal
                | [<CompiledName("default")>] Default
                | [<CompiledName("flex")>] Flex
                | [<CompiledName("scale")>] Scale
                | [<CompiledName("priority")>] Priority
                | [<CompiledName("function_call_output")>] FunctionCallOutput
                | [<CompiledName("concise")>] Concise
                | [<CompiledName("detailed")>] Detailed

            type PostProcessedOutputs =
                [<CompiledName("system_fingerprint")>]
                abstract systemFingerprint: option<unit> with get, set

                abstract choices: option<unit> with get, set
                abstract created: option<unit> with get, set
                abstract model: option<unit> with get, set
                abstract usage: option<ResponseUsage> with get, set
                abstract truncation: option<PostProcessedOutputs.Truncation> with get, set
                abstract text: option<ResponseTextConfig> with get, set
                abstract status: option<PostProcessedOutputs.Status> with get, set

                [<CompiledName("service_tier")>]
                abstract serviceTier: option<PostProcessedOutputs.ServiceTier> with get, set

                [<CompiledName("safety_identifier")>]
                abstract safetyIdentifier: option<D1SessionBookmark> with get, set

                abstract reasoning: option<Reasoning> with get, set
                abstract prompt: option<ResponsePrompt> with get, set

                [<CompiledName("previous_response_id")>]
                abstract previousResponseId: option<D1SessionBookmark> with get, set

                [<CompiledName("max_output_tokens")>]
                abstract maxOutputTokens: option<float> with get, set

                [<CompiledName("top_p")>]
                abstract topP: option<float> with get, set

                abstract tools: option<Array<Tool>> with get, set

                [<CompiledName("tool_choice")>]
                abstract toolChoice: option<U2<ToolChoiceOptions, ToolChoiceFunction>> with get, set

                abstract temperature: option<float> with get, set

                [<CompiledName("parallel_tool_calls")>]
                abstract parallelToolCalls: option<bool> with get, set

                abstract output: option<Array<ResponseOutputItem>> with get, set
                abstract object: option<PostProcessedOutputs.Object> with get, set

                abstract instructions:
                    option<
                        U2<
                            Array<
                                U6<
                                    ResponseOutputMessage,
                                    ResponseFunctionToolCall,
                                    ResponseReasoningItem,
                                    EasyInputMessage,
                                    ResponseInputItemMessage,
                                    ResponseInputItemFunctionCallOutput
                                 >
                             >,
                            D1SessionBookmark
                         >
                     > with get, set

                [<CompiledName("incomplete_details")>]
                abstract incompleteDetails: option<ResponseIncompleteDetails> with get, set

                abstract error: option<ResponseError> with get, set

                [<CompiledName("output_text")>]
                abstract outputText: option<D1SessionBookmark> with get, set

                [<CompiledName("created_at")>]
                abstract createdAt: option<float> with get, set

                abstract id: option<D1SessionBookmark> with get, set
                abstract message: D1SessionBookmark with get, set
                abstract code: PostProcessedOutputs.Code with get, set
                abstract reason: option<PostProcessedOutputs.Reason> with get, set

                [<CompiledName("total_tokens")>]
                abstract totalTokens: float with get, set

                [<CompiledName("output_tokens")>]
                abstract outputTokens: float with get, set

                [<CompiledName("input_tokens")>]
                abstract inputTokens: float with get, set

                abstract truncation: option<unit> with get, set
                abstract status: option<unit> with get, set

                [<CompiledName("safety_identifier")>]
                abstract safetyIdentifier: option<unit> with get, set

                abstract reasoning: option<unit> with get, set

                [<CompiledName("previous_response_id")>]
                abstract previousResponseId: option<unit> with get, set

                [<CompiledName("max_output_tokens")>]
                abstract maxOutputTokens: option<unit> with get, set

                abstract instructions: option<unit> with get, set

                [<CompiledName("incomplete_details")>]
                abstract incompleteDetails: option<unit> with get, set

                [<CompiledName("output_text")>]
                abstract outputText: option<unit> with get, set

                [<CompiledName("created_at")>]
                abstract createdAt: option<unit> with get, set

                [<CompiledName("top_p")>]
                abstract topP: option<unit> with get, set

                abstract tools: option<unit> with get, set

                [<CompiledName("tool_choice")>]
                abstract toolChoice: option<unit> with get, set

                abstract temperature: option<unit> with get, set

                [<CompiledName("parallel_tool_calls")>]
                abstract parallelToolCalls: option<unit> with get, set

                abstract prompt: option<unit> with get, set
                abstract output: option<unit> with get, set
                abstract text: option<unit> with get, set
                abstract error: option<unit> with get, set

                [<CompiledName("system_fingerprint")>]
                abstract systemFingerprint: option<D1SessionBookmark> with get, set

                abstract usage: option<CompletionUsage> with get, set
                abstract choices: Array<ChatCompletionChoice> with get, set
                abstract model: D1SessionBookmark with get, set
                abstract created: float with get, set
                abstract object: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set

                [<CompiledName("completion_tokens_details")>]
                abstract completionTokensDetails: option<CompletionTokensDetails> with get, set

                [<CompiledName("prompt_tokens_details")>]
                abstract promptTokensDetails: option<PromptTokensDetails> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: float with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: float with get, set

                [<CompiledName("audio_tokens")>]
                abstract audioTokens: option<float> with get, set

                [<CompiledName("cached_tokens")>]
                abstract cachedTokens: option<float> with get, set

                [<CompiledName("rejected_prediction_tokens")>]
                abstract rejectedPredictionTokens: option<float> with get, set

                [<CompiledName("accepted_prediction_tokens")>]
                abstract acceptedPredictionTokens: option<float> with get, set

                [<CompiledName("reasoning_tokens")>]
                abstract reasoningTokens: option<float> with get, set

                abstract version: option<D1SessionBookmark> with get, set
                abstract variables: option<PostProcessedOutputs.Variables> with get, set
                abstract Item: key: D1SessionBookmark -> U3<ResponseInputText, ResponseInputImage, D1SessionBookmark>

        module BaseAiCfOpenaiWhisper =
            type Inputs =
                abstract audio: AiSentenceSimilarityOutput with get, set

        module BaseAiCfOpenaiWhisperTinyEn =
            type Inputs =
                abstract audio: AiSentenceSimilarityOutput with get, set

        module BaseAiCfPipecatAiSmartTurnV2 =
            type Inputs =
                abstract dtype: option<Inputs.Dtype> with get, set
                abstract audio: Inputs.Audio with get, set
                abstract audio: D1SessionBookmark with get, set
                abstract contentType: D1SessionBookmark with get, set
                abstract body: obj with get, set

        module BaseAiCfQwenQwen25Coder32BInstruct =
            type PostProcessedOutputs =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

                [<CompiledName("tool_calls")>]
                abstract toolCalls: option<Array<PostProcessedOutputs.ToolCalls>> with get, set

                abstract usage: option<PostProcessedOutputs.Usage> with get, set
                abstract response: D1SessionBookmark with get, set

        module BaseAiCfQwenQwq32B =
            type PostProcessedOutputs =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

                [<CompiledName("tool_calls")>]
                abstract toolCalls: option<Array<PostProcessedOutputs.ToolCalls>> with get, set

                abstract usage: option<PostProcessedOutputs.Usage> with get, set
                abstract response: D1SessionBookmark with get, set

        module BaseAiCfUnumUformGen2Qwen500M =
            type Inputs =
                [<CompiledName("max_tokens")>]
                abstract maxTokens: option<float> with get, set

                abstract image: U2<AiSentenceSimilarityOutput, Inputs.Image> with get, set

                [<CompiledName("presence_penalty")>]
                abstract presencePenalty: option<float> with get, set

                [<CompiledName("frequency_penalty")>]
                abstract frequencyPenalty: option<float> with get, set

                [<CompiledName("repetition_penalty")>]
                abstract repetitionPenalty: option<float> with get, set

                abstract seed: option<float> with get, set

                [<CompiledName("top_k")>]
                abstract topK: option<float> with get, set

                [<CompiledName("top_p")>]
                abstract topP: option<float> with get, set

                abstract raw: option<bool> with get, set
                abstract prompt: option<D1SessionBookmark> with get, set

        module BaseAiCfZaiOrgGlm47Flash =
            type PostProcessedOutputs =
                [<CompiledName("rejected_prediction_tokens")>]
                abstract rejectedPredictionTokens: option<float> with get, set

                [<CompiledName("accepted_prediction_tokens")>]
                abstract acceptedPredictionTokens: option<float> with get, set

                [<CompiledName("audio_tokens")>]
                abstract audioTokens: option<float> with get, set

                [<CompiledName("reasoning_tokens")>]
                abstract reasoningTokens: option<float> with get, set

                [<CompiledName("cached_tokens")>]
                abstract cachedTokens: option<float> with get, set

                abstract logprobs: option<ChatCompletionLogprobs> with get, set

                [<CompiledName("finish_reason")>]
                abstract finishReason: PostProcessedOutputs.FinishReason with get, set

                abstract message: ChatCompletionResponseMessage with get, set
                abstract index: float with get, set
                abstract bytes: option<AiSentenceSimilarityOutput> with get, set
                abstract logprob: float with get, set
                abstract token: D1SessionBookmark with get, set

                [<CompiledName("top_logprobs")>]
                abstract topLogprobs: Array<ChatCompletionTopLogprob> with get, set

                abstract refusal: option<Array<ChatCompletionTokenLogprob>> with get, set
                abstract content: option<Array<ChatCompletionTokenLogprob>> with get, set
                abstract arguments: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set
                abstract transcript: D1SessionBookmark with get, set

                [<CompiledName("expires_at")>]
                abstract expiresAt: float with get, set

                abstract data: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set

                [<CompiledName("end_index")>]
                abstract endIndex: float with get, set

                [<CompiledName("start_index")>]
                abstract startIndex: float with get, set

                abstract title: D1SessionBookmark with get, set
                abstract url: D1SessionBookmark with get, set

                [<CompiledName("url_citation")>]
                abstract urlCitation: PostProcessedOutputs.UrlCitation with get, set

                [<CompiledName("type")>]
                abstract ``type``: PostProcessedOutputs.Type with get, set

                [<CompiledName("function_call")>]
                abstract functionCall: option<PostProcessedOutputs.FunctionCall> with get, set

                [<CompiledName("tool_calls")>]
                abstract toolCalls: option<Array<ChatCompletionMessageToolCall>> with get, set

                abstract audio: option<ChatCompletionAudio> with get, set
                abstract annotations: option<Array<ChatCompletionUrlCitation>> with get, set
                abstract refusal: option<D1SessionBookmark> with get, set
                abstract content: option<D1SessionBookmark> with get, set
                abstract role: PostProcessedOutputs.Role with get, set

                [<CompiledName("completion_tokens_details")>]
                abstract completionTokensDetails: option<CompletionTokensDetails> with get, set

                [<CompiledName("prompt_tokens_details")>]
                abstract promptTokensDetails: option<PromptTokensDetails> with get, set

                [<CompiledName("total_tokens")>]
                abstract totalTokens: float with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: float with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: float with get, set

                [<CompiledName("service_tier")>]
                abstract serviceTier: option<PostProcessedOutputs.ServiceTier> with get, set

                [<CompiledName("system_fingerprint")>]
                abstract systemFingerprint: option<D1SessionBookmark> with get, set

                abstract usage: option<CompletionUsage> with get, set
                abstract choices: Array<ChatCompletionChoice> with get, set
                abstract model: D1SessionBookmark with get, set
                abstract created: float with get, set
                abstract object: D1SessionBookmark with get, set

        module BaseAiImageClassification =
            type PostProcessedOutputs =
                abstract label: option<D1SessionBookmark> with get, set
                abstract score: option<float> with get, set

            type Inputs =
                abstract image: AiSentenceSimilarityOutput with get, set

        module BaseAiImageTextToText =
            type Inputs =
                abstract messages: option<Array<RoleScopedChatInput>> with get, set
                abstract raw: option<bool> with get, set

                [<CompiledName("presence_penalty")>]
                abstract presencePenalty: option<float> with get, set

                [<CompiledName("frequency_penalty")>]
                abstract frequencyPenalty: option<float> with get, set

                [<CompiledName("repetition_penalty")>]
                abstract repetitionPenalty: option<float> with get, set

                abstract seed: option<float> with get, set

                [<CompiledName("top_k")>]
                abstract topK: option<float> with get, set

                [<CompiledName("top_p")>]
                abstract topP: option<float> with get, set

                [<CompiledName("ignore_eos")>]
                abstract ignoreEos: option<bool> with get, set

                abstract temperature: option<float> with get, set

                [<CompiledName("max_tokens")>]
                abstract maxTokens: option<float> with get, set

                abstract prompt: option<D1SessionBookmark> with get, set
                abstract image: D1SessionBookmark with get, set

            type PostProcessedOutputs =
                abstract description: D1SessionBookmark with get, set

        module BaseAiImageToText =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Inputs =
                | [<CompiledName("user")>] User
                | [<CompiledName("assistant")>] Assistant
                | [<CompiledName("system")>] System
                | [<CompiledName("tool")>] Tool

            type PostProcessedOutputs =
                abstract description: D1SessionBookmark with get, set

        module BaseAiMultimodalEmbeddings =
            type PostProcessedOutputs =
                abstract description: D1SessionBookmark with get, set

            type Inputs =
                abstract messages: option<Array<RoleScopedChatInput>> with get, set
                abstract raw: option<bool> with get, set

                [<CompiledName("presence_penalty")>]
                abstract presencePenalty: option<float> with get, set

                [<CompiledName("frequency_penalty")>]
                abstract frequencyPenalty: option<float> with get, set

                [<CompiledName("repetition_penalty")>]
                abstract repetitionPenalty: option<float> with get, set

                abstract seed: option<float> with get, set

                [<CompiledName("top_k")>]
                abstract topK: option<float> with get, set

                [<CompiledName("top_p")>]
                abstract topP: option<float> with get, set

                [<CompiledName("ignore_eos")>]
                abstract ignoreEos: option<bool> with get, set

                abstract temperature: option<float> with get, set

                [<CompiledName("max_tokens")>]
                abstract maxTokens: option<float> with get, set

                abstract prompt: option<D1SessionBookmark> with get, set
                abstract image: D1SessionBookmark with get, set

        module BaseAiObjectDetection =
            type PostProcessedOutputs =
                abstract label: option<D1SessionBookmark> with get, set
                abstract score: option<float> with get, set

            type Inputs =
                abstract image: AiSentenceSimilarityOutput with get, set

        module BaseAiSentenceSimilarity =
            type Inputs =
                abstract sentences: Array<D1SessionBookmark> with get, set
                abstract source: D1SessionBookmark with get, set

        module BaseAiSummarization =
            type Inputs =
                [<CompiledName("max_length")>]
                abstract maxLength: option<float> with get, set

                [<CompiledName("input_text")>]
                abstract inputText: D1SessionBookmark with get, set

            type PostProcessedOutputs =
                abstract summary: D1SessionBookmark with get, set

        module BaseAiTextClassification =
            type PostProcessedOutputs =
                abstract label: option<D1SessionBookmark> with get, set
                abstract score: option<float> with get, set

            type Inputs =
                abstract text: D1SessionBookmark with get, set

        module BaseAiTextEmbeddings =
            type Inputs =
                abstract text: U2<Array<D1SessionBookmark>, D1SessionBookmark> with get, set

            type PostProcessedOutputs =
                abstract data: Array<AiSentenceSimilarityOutput> with get, set
                abstract shape: AiSentenceSimilarityOutput with get, set

        module BaseAiTextGeneration =
            type Inputs =
                abstract parameters: option<Inputs.Parameters> with get, set
                abstract description: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set

                [<CompiledName("json_schema")>]
                abstract jsonSchema: option<obj> with get, set

                [<CompiledName("type")>]
                abstract ``type``: D1SessionBookmark with get, set

                abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set

                abstract tools:
                    option<U3<Array<AiTextGenerationToolInput>, Array<AiTextGenerationToolLegacyInput>, obj>> with get, set

                [<CompiledName("response_format")>]
                abstract responseFormat: option<AiTextGenerationResponseFormat> with get, set

                abstract messages: option<Array<RoleScopedChatInput>> with get, set

                [<CompiledName("presence_penalty")>]
                abstract presencePenalty: option<float> with get, set

                [<CompiledName("frequency_penalty")>]
                abstract frequencyPenalty: option<float> with get, set

                [<CompiledName("repetition_penalty")>]
                abstract repetitionPenalty: option<float> with get, set

                abstract seed: option<float> with get, set

                [<CompiledName("top_k")>]
                abstract topK: option<float> with get, set

                [<CompiledName("top_p")>]
                abstract topP: option<float> with get, set

                abstract temperature: option<float> with get, set

                [<CompiledName("max_tokens")>]
                abstract maxTokens: option<float> with get, set

                abstract stream: option<bool> with get, set
                abstract raw: option<bool> with get, set
                abstract prompt: option<D1SessionBookmark> with get, set
                abstract description: option<D1SessionBookmark> with get, set
                abstract code: D1SessionBookmark with get, set
                abstract required: Array<D1SessionBookmark> with get, set
                abstract properties: Inputs.Properties with get, set

                [<CompiledName("type")>]
                abstract ``type``: U2<Inputs.Type, Inputs.Type> with get, set

                [<CompiledName("function")>]
                abstract ``function``: Inputs.Function with get, set

                abstract Item: key: D1SessionBookmark -> Inputs.Inputs

            type PostProcessedOutputs =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: float with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: float with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: float with get, set

                abstract usage: option<UsageTags> with get, set

                [<CompiledName("tool_calls")>]
                abstract toolCalls: option<PostProcessedOutputs.ToolCalls> with get, set

                abstract response: option<D1SessionBookmark> with get, set

        module BaseAiTextToImage =
            type Inputs =
                abstract seed: option<float> with get, set
                abstract guidance: option<float> with get, set
                abstract strength: option<float> with get, set

                [<CompiledName("num_steps")>]
                abstract numSteps: option<float> with get, set

                abstract mask: option<AiSentenceSimilarityOutput> with get, set

                [<CompiledName("image_b64")>]
                abstract imageB64: option<D1SessionBookmark> with get, set

                abstract image: option<AiSentenceSimilarityOutput> with get, set
                abstract width: option<float> with get, set
                abstract height: option<float> with get, set

                [<CompiledName("negative_prompt")>]
                abstract negativePrompt: option<D1SessionBookmark> with get, set

                abstract prompt: D1SessionBookmark with get, set

        module BaseAiTextToSpeech =
            type PostProcessedOutputs =
                abstract audio: D1SessionBookmark with get, set

            type Inputs =
                abstract lang: option<D1SessionBookmark> with get, set
                abstract prompt: D1SessionBookmark with get, set

        module BaseAiTranslation =
            type Inputs =
                [<CompiledName("source_lang")>]
                abstract sourceLang: option<D1SessionBookmark> with get, set

                [<CompiledName("target_lang")>]
                abstract targetLang: D1SessionBookmark with get, set

                abstract text: D1SessionBookmark with get, set

            type PostProcessedOutputs =
                [<CompiledName("translated_text")>]
                abstract translatedText: option<D1SessionBookmark> with get, set

        module BasicImageTransformations =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Segment = | [<CompiledName("foreground")>] Foreground

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Fit =
                | [<CompiledName("scale-down")>] ScaleDown
                | [<CompiledName("contain")>] Contain
                | [<CompiledName("cover")>] Cover
                | [<CompiledName("crop")>] Crop
                | [<CompiledName("pad")>] Pad
                | [<CompiledName("squeeze")>] Squeeze

            type Rotate =
                | ``0`` = 0
                | ``90`` = 90
                | ``180`` = 180
                | ``270`` = 270
                | ``360`` = 360

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Gravity =
                | [<CompiledName("face")>] Face
                | [<CompiledName("left")>] Left
                | [<CompiledName("right")>] Right
                | [<CompiledName("top")>] Top
                | [<CompiledName("bottom")>] Bottom
                | [<CompiledName("center")>] Center
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("entropy")>] Entropy

        module BasicImageTransformationsGravityCoordinates =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Mode =
                | [<CompiledName("remainder")>] Remainder
                | [<CompiledName("box-center")>] BoxCenter

        module ChatCompletionChoice =
            type Message =
                abstract transcript: D1SessionBookmark with get, set

                [<CompiledName("expires_at")>]
                abstract expiresAt: float with get, set

                abstract data: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set

                [<CompiledName("end_index")>]
                abstract endIndex: float with get, set

                [<CompiledName("start_index")>]
                abstract startIndex: float with get, set

                abstract title: D1SessionBookmark with get, set
                abstract url: D1SessionBookmark with get, set

                [<CompiledName("url_citation")>]
                abstract urlCitation: Message.UrlCitation with get, set

                [<CompiledName("type")>]
                abstract ``type``: Message.Type with get, set

                [<CompiledName("function_call")>]
                abstract functionCall: option<Message.FunctionCall> with get, set

                [<CompiledName("tool_calls")>]
                abstract toolCalls: option<Array<ChatCompletionMessageToolCall>> with get, set

                abstract audio: option<ChatCompletionAudio> with get, set
                abstract annotations: option<Array<ChatCompletionUrlCitation>> with get, set
                abstract refusal: option<D1SessionBookmark> with get, set
                abstract content: option<D1SessionBookmark> with get, set
                abstract role: Message.Role with get, set
                abstract arguments: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type FinishReason =
                | [<CompiledName("stop")>] Stop
                | [<CompiledName("length")>] Length
                | [<CompiledName("tool_calls")>] ToolCalls
                | [<CompiledName("content_filter")>] ContentFilter
                | [<CompiledName("function_call")>] FunctionCall

        module ChatCompletionContentPartFile =
            type File =
                abstract filename: option<D1SessionBookmark> with get, set

                [<CompiledName("file_id")>]
                abstract fileId: option<D1SessionBookmark> with get, set

                [<CompiledName("file_data")>]
                abstract fileData: option<D1SessionBookmark> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("file")>] File

        module ChatCompletionContentPartImage =
            type ImageUrl =
                abstract detail: option<ImageUrl.Detail> with get, set
                abstract url: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("image_url")>] ImageUrl

        module ChatCompletionContentPartInputAudio =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("input_audio")>] InputAudio

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type InputAudio =
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("mp3")>] Mp3

        module ChatCompletionContentPartRefusal =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("refusal")>] Refusal

        module ChatCompletionContentPartText =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("text")>] Text

        module ChatCompletionCustomTool =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Custom =
                | [<CompiledName("grammar")>] Grammar
                | [<CompiledName("lark")>] Lark
                | [<CompiledName("regex")>] Regex
                | [<CompiledName("text")>] Text

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("custom")>] Custom

        module ChatCompletionCustomToolGrammarFormat =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("grammar")>] Grammar

            type Grammar =
                abstract syntax: Grammar.Syntax with get, set
                abstract definition: D1SessionBookmark with get, set

        module ChatCompletionCustomToolTextFormat =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("text")>] Text

        module ChatCompletionFunctionTool =
            type Function =
                abstract strict: option<bool> with get, set
                abstract parameters: option<Function.Parameters> with get, set
                abstract description: option<D1SessionBookmark> with get, set
                abstract name: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("function")>] Function

        module ChatCompletionMessageCustomToolCall =
            type Custom =
                abstract input: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("custom")>] Custom

        module ChatCompletionMessageFunctionToolCall =
            type Function =
                abstract arguments: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("function")>] Function

        module ChatCompletionResponseMessage =
            type Audio =
                abstract transcript: D1SessionBookmark with get, set

                [<CompiledName("expires_at")>]
                abstract expiresAt: float with get, set

                abstract data: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Role = | [<CompiledName("assistant")>] Assistant

        module ChatCompletionToolChoiceAllowedTools =
            type AllowedTools =
                abstract tools: Array<AllowedTools.Tools> with get, set
                abstract mode: AllowedTools.Mode with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("allowed_tools")>] AllowedTools

        module ChatCompletionToolChoiceCustom =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("custom")>] Custom

            type Custom =
                abstract name: D1SessionBookmark with get, set

        module ChatCompletionToolChoiceFunction =
            type Function =
                abstract name: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("function")>] Function

        module ChatCompletionUrlCitation =
            type UrlCitation =
                [<CompiledName("end_index")>]
                abstract endIndex: float with get, set

                [<CompiledName("start_index")>]
                abstract startIndex: float with get, set

                abstract title: D1SessionBookmark with get, set
                abstract url: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("url_citation")>] UrlCitation

        module ChatCompletionsCommonOptions =
            type Tools =
                abstract format: option<ChatCompletionCustomToolFormat> with get, set
                abstract description: option<D1SessionBookmark> with get, set
                abstract name: D1SessionBookmark with get, set
                abstract custom: Tools.Custom with get, set

                [<CompiledName("type")>]
                abstract ``type``: Tools.Type with get, set

                abstract grammar: Tools.Grammar with get, set
                abstract syntax: Tools.Syntax with get, set
                abstract definition: D1SessionBookmark with get, set

                [<CompiledName("function")>]
                abstract ``function``: FunctionDefinition with get, set

                abstract strict: option<bool> with get, set
                abstract parameters: option<Tools.Parameters> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ResponseFormat =
                | [<CompiledName("json_schema")>] JsonSchema
                | [<CompiledName("json_object")>] JsonObject

            type WebSearchOptions =
                abstract approximate: WebSearchOptions.Approximate with get, set

                [<CompiledName("type")>]
                abstract ``type``: WebSearchOptions.Type with get, set

                abstract timezone: option<D1SessionBookmark> with get, set
                abstract region: option<D1SessionBookmark> with get, set
                abstract country: option<D1SessionBookmark> with get, set
                abstract city: option<D1SessionBookmark> with get, set

                [<CompiledName("user_location")>]
                abstract userLocation: option<WebSearchUserLocation> with get, set

                [<CompiledName("search_context_size")>]
                abstract searchContextSize: option<WebSearchOptions.SearchContextSize> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ToolChoice =
                | [<CompiledName("allowed_tools")>] AllowedTools
                | [<CompiledName("custom")>] Custom
                | [<CompiledName("function")>] Function
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("none")>] None
                | [<CompiledName("required")>] Required

            type ChatTemplateKwargs =
                [<CompiledName("clear_thinking")>]
                abstract clearThinking: option<bool> with get, set

                [<CompiledName("enable_thinking")>]
                abstract enableThinking: option<bool> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type FunctionCall =
                | [<CompiledName("none")>] None
                | [<CompiledName("auto")>] Auto

            type StreamOptions =
                [<CompiledName("include_obfuscation")>]
                abstract includeObfuscation: option<bool> with get, set

                [<CompiledName("include_usage")>]
                abstract includeUsage: option<bool> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ServiceTier =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("default")>] Default
                | [<CompiledName("flex")>] Flex
                | [<CompiledName("scale")>] Scale
                | [<CompiledName("priority")>] Priority

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ReasoningEffort =
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium")>] Medium
                | [<CompiledName("high")>] High

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Prediction =
                | [<CompiledName("text")>] Text
                | [<CompiledName("content")>] Content

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Modalities =
                | [<CompiledName("audio")>] Audio
                | [<CompiledName("text")>] Text

            type LogitBias =
                abstract Item: key: D1SessionBookmark -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Audio =
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("aac")>] Aac
                | [<CompiledName("mp3")>] Mp3
                | [<CompiledName("flac")>] Flac
                | [<CompiledName("opus")>] Opus
                | [<CompiledName("pcm16")>] Pcm16

        module ChatCompletionsMessagesInput =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Messages =
                | [<CompiledName("function")>] Function
                | [<CompiledName("custom")>] Custom
                | [<CompiledName("text")>] Text
                | [<CompiledName("refusal")>] Refusal
                | [<CompiledName("assistant")>] Assistant
                | [<CompiledName("tool")>] Tool
                | [<CompiledName("system")>] System
                | [<CompiledName("developer")>] Developer
                | [<CompiledName("user")>] User
                | [<CompiledName("image_url")>] ImageUrl
                | [<CompiledName("input_audio")>] InputAudio
                | [<CompiledName("file")>] File
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("low")>] Low
                | [<CompiledName("high")>] High
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("mp3")>] Mp3

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type WebSearchOptions =
                | [<CompiledName("approximate")>] Approximate
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium")>] Medium
                | [<CompiledName("high")>] High

            type StreamOptions =
                [<CompiledName("include_obfuscation")>]
                abstract includeObfuscation: option<bool> with get, set

                [<CompiledName("include_usage")>]
                abstract includeUsage: option<bool> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ServiceTier =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("default")>] Default
                | [<CompiledName("flex")>] Flex
                | [<CompiledName("scale")>] Scale
                | [<CompiledName("priority")>] Priority

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ReasoningEffort =
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium")>] Medium
                | [<CompiledName("high")>] High

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Prediction =
                | [<CompiledName("text")>] Text
                | [<CompiledName("content")>] Content

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Audio =
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("aac")>] Aac
                | [<CompiledName("mp3")>] Mp3
                | [<CompiledName("flac")>] Flac
                | [<CompiledName("opus")>] Opus
                | [<CompiledName("pcm16")>] Pcm16

            type ChatTemplateKwargs =
                [<CompiledName("clear_thinking")>]
                abstract clearThinking: option<bool> with get, set

                [<CompiledName("enable_thinking")>]
                abstract enableThinking: option<bool> with get, set

        module ChatCompletionsOutput =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ServiceTier =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("default")>] Default
                | [<CompiledName("flex")>] Flex
                | [<CompiledName("scale")>] Scale
                | [<CompiledName("priority")>] Priority

            type Usage =
                [<CompiledName("rejected_prediction_tokens")>]
                abstract rejectedPredictionTokens: option<float> with get, set

                [<CompiledName("accepted_prediction_tokens")>]
                abstract acceptedPredictionTokens: option<float> with get, set

                [<CompiledName("audio_tokens")>]
                abstract audioTokens: option<float> with get, set

                [<CompiledName("reasoning_tokens")>]
                abstract reasoningTokens: option<float> with get, set

                [<CompiledName("cached_tokens")>]
                abstract cachedTokens: option<float> with get, set

                [<CompiledName("completion_tokens_details")>]
                abstract completionTokensDetails: option<CompletionTokensDetails> with get, set

                [<CompiledName("prompt_tokens_details")>]
                abstract promptTokensDetails: option<PromptTokensDetails> with get, set

                [<CompiledName("total_tokens")>]
                abstract totalTokens: float with get, set

                [<CompiledName("completion_tokens")>]
                abstract completionTokens: float with get, set

                [<CompiledName("prompt_tokens")>]
                abstract promptTokens: float with get, set

        module ChatCompletionsPromptInput =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Prediction =
                | [<CompiledName("text")>] Text
                | [<CompiledName("content")>] Content

            type Audio =
                abstract id: D1SessionBookmark with get, set
                abstract format: Audio.Format with get, set
                abstract voice: U2<ResponseConversationParam, D1SessionBookmark> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ReasoningEffort =
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium")>] Medium
                | [<CompiledName("high")>] High

            type WebSearchOptions =
                [<CompiledName("user_location")>]
                abstract userLocation: option<WebSearchUserLocation> with get, set

                [<CompiledName("search_context_size")>]
                abstract searchContextSize: option<WebSearchOptions.SearchContextSize> with get, set

                abstract approximate: WebSearchOptions.Approximate with get, set

                [<CompiledName("type")>]
                abstract ``type``: WebSearchOptions.Type with get, set

                abstract timezone: option<D1SessionBookmark> with get, set
                abstract region: option<D1SessionBookmark> with get, set
                abstract country: option<D1SessionBookmark> with get, set
                abstract city: option<D1SessionBookmark> with get, set

            type ChatTemplateKwargs =
                [<CompiledName("clear_thinking")>]
                abstract clearThinking: option<bool> with get, set

                [<CompiledName("enable_thinking")>]
                abstract enableThinking: option<bool> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ServiceTier =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("default")>] Default
                | [<CompiledName("flex")>] Flex
                | [<CompiledName("scale")>] Scale
                | [<CompiledName("priority")>] Priority

            type StreamOptions =
                [<CompiledName("include_obfuscation")>]
                abstract includeObfuscation: option<bool> with get, set

                [<CompiledName("include_usage")>]
                abstract includeUsage: option<bool> with get, set

        module ChatCompletionsResponseFormatJSONObject =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("json_object")>] JsonObject

        module ChatCompletionsResponseFormatText =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("text")>] Text

        module Cloudflare =
            [<Import("@cloudflare/workers-types.Cloudflare", "GlobalProps")>]
            type GlobalProps = interface end

            [<Import("@cloudflare/workers-types.Cloudflare", "Env")>]
            type Env = interface end

            type GlobalProp<'Default, 'K when 'K :> D1SessionBookmark> = U2<proptypekey<GlobalProps, 'K>, 'Default>

            type Exports =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module CloudflareWorkersModule =
            type WithEnvAndExports =
                abstract Invoke: ?newEnv: obj * ?newExports: obj * fn: unit -> option<obj> -> option<obj>

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkflowStepContext")>]
            type WorkflowStepContext =
                abstract config: WorkflowStepConfig with get, set
                abstract attempt: float with get, set
                abstract step: WorkflowStepContext.Step with get, set

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "RollbackContext")>]
            type RollbackContext<'T> =
                abstract stepName: D1SessionBookmark with get, set
                abstract output: option<RollbackContext.Output> with get, set
                abstract error: Error with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type WorkflowInstanceStatus =
                | [<CompiledName("queued")>] Queued
                | [<CompiledName("running")>] Running
                | [<CompiledName("paused")>] Paused
                | [<CompiledName("errored")>] Errored
                | [<CompiledName("terminated")>] Terminated
                | [<CompiledName("complete")>] Complete
                | [<CompiledName("waiting")>] Waiting
                | [<CompiledName("waitingForPause")>] WaitingForPause
                | [<CompiledName("unknown")>] Unknown

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkflowStep")>]
            type WorkflowStep =
                abstract waitForEvent:
                    name: D1SessionBookmark * options: WorkflowStep.WaitForEvent.Options ->
                        StepPromise<WorkflowStep.WaitForEvent>

                abstract sleepUntil: name: D1SessionBookmark * timestamp: U2<Date, float> -> Promise<unit>

                abstract sleep:
                    name: D1SessionBookmark *
                    duration:
                        U15<
                            WorkflowStep.Sleep.Duration,
                            WorkflowStep.Sleep.Duration,
                            WorkflowStep.Sleep.Duration,
                            WorkflowStep.Sleep.Duration,
                            WorkflowStep.Sleep.Duration,
                            WorkflowStep.Sleep.Duration,
                            WorkflowStep.Sleep.Duration,
                            WorkflowStep.Sleep.Duration,
                            WorkflowStep.Sleep.Duration,
                            WorkflowStep.Sleep.Duration,
                            WorkflowStep.Sleep.Duration,
                            WorkflowStep.Sleep.Duration,
                            WorkflowStep.Sleep.Duration,
                            WorkflowStep.Sleep.Duration,
                            float
                         > ->
                        Promise<unit>

                abstract ``do``:
                    name: D1SessionBookmark * config: WorkflowStepConfig * callback: WorkflowStepContext -> Promise<'T> ->
                        StepPromise<'T>

                abstract ``do``:
                    name: D1SessionBookmark * callback: WorkflowStepContext -> Promise<'T> -> StepPromise<'T>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type WorkflowDurationLabel =
                | [<CompiledName("second")>] Second
                | [<CompiledName("minute")>] Minute
                | [<CompiledName("hour")>] Hour
                | [<CompiledName("day")>] Day
                | [<CompiledName("week")>] Week
                | [<CompiledName("month")>] Month
                | [<CompiledName("year")>] Year

            type WorkflowTimeoutDuration =
                U15<
                    WorkflowTimeoutDuration,
                    WorkflowTimeoutDuration,
                    WorkflowTimeoutDuration,
                    WorkflowTimeoutDuration,
                    WorkflowTimeoutDuration,
                    WorkflowTimeoutDuration,
                    WorkflowTimeoutDuration,
                    WorkflowTimeoutDuration,
                    WorkflowTimeoutDuration,
                    WorkflowTimeoutDuration,
                    WorkflowTimeoutDuration,
                    WorkflowTimeoutDuration,
                    WorkflowTimeoutDuration,
                    WorkflowTimeoutDuration,
                    float
                 >

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "DurableObject")>]
            type DurableObject<'Props, 'Env> =
                [<EmitConstructor>]
                abstract Create: ctx: DurableObjectState<option<obj>> * env: 'Env -> DurableObject

                inherit Rpc.DurableObjectBranded
                abstract env: 'Env with get, set
                abstract ctx: DurableObjectState<'Props> with get, set

                [<CompiledName("[Rpc.__DURABLE_OBJECT_BRAND]")>]
                abstract ``[rpc._DURABLEOBJECTBRAND]``: unit with get, set

                abstract webSocketError: ws: Typescript.WebSocket * ?error: obj -> option<Promise<unit>>

                abstract webSocketClose:
                    ws: Typescript.WebSocket * code: float * reason: D1SessionBookmark * wasClean: bool ->
                        option<Promise<unit>>

                abstract webSocketMessage:
                    ws: Typescript.WebSocket * message: U2<ArrayBuffer, D1SessionBookmark> -> option<Promise<unit>>

                abstract connect: socket: Socket -> option<Promise<unit>>

                abstract fetch:
                    request: Typescript.Request<option<obj>, U2<RequestInitCfProperties, DurableObject.Fetch.Request>> ->
                        U2<Typescript.Response, Promise<Typescript.Response>>

                abstract alarm: ?alarmInfo: AlarmInvocationInfo -> option<Promise<unit>>

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkflowEvent")>]
            type WorkflowEvent<'T> =
                abstract instanceId: D1SessionBookmark with get, set
                abstract timestamp: Date with get, set
                abstract payload: WorkflowEvent.Payload with get, set

            type TemplateLiteral =
                abstract Value: string
                abstract Create: v0: float -> TemplateLiteral

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "StepPromise")>]
            type StepPromise<'T> =
                inherit Promise<'T>
                abstract rollback: config: WorkflowStepConfig * fn: RollbackContext<'T> -> Promise<unit> -> StepPromise
                abstract rollback: fn: RollbackContext<'T> -> Promise<unit> -> StepPromise

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkflowEntrypoint")>]
            type WorkflowEntrypoint<'T, 'Env
                when 'T :> U32<
                    WorkflowEntrypoint,
                    RegExp,
                    Error,
                    Typescript.Response,
                    ArrayBuffer,
                    Headers,
                    Date,
                    Int8Array<ArrayBufferLike>,
                    Uint8Array<ArrayBufferLike>,
                    Uint8ClampedArray<ArrayBufferLike>,
                    Int16Array<ArrayBufferLike>,
                    Uint16Array<ArrayBufferLike>,
                    Int32Array<ArrayBufferLike>,
                    Uint32Array<ArrayBufferLike>,
                    Float32Array<ArrayBufferLike>,
                    Float64Array<ArrayBufferLike>,
                    BigInt64Array<ArrayBufferLike>,
                    BigUint64Array<ArrayBufferLike>,
                    DataView<ArrayBufferLike>,
                    ReadableStream<Uint8Array<ArrayBufferLike>>,
                    WritableStream<Uint8Array<ArrayBufferLike>>,
                    Typescript.Request<option<obj>, U2<RequestInitCfProperties, WorkflowEntrypoint>>,
                    Rpc.RpcTargetBranded,
                    WorkflowEntrypoint,
                    Map<
                        U2<
                            option<
                                U31<
                                    WorkflowEntrypoint,
                                    RegExp,
                                    Error,
                                    Typescript.Response,
                                    ArrayBuffer,
                                    Headers,
                                    Date,
                                    Int8Array<ArrayBufferLike>,
                                    Uint8Array<ArrayBufferLike>,
                                    Uint8ClampedArray<ArrayBufferLike>,
                                    Int16Array<ArrayBufferLike>,
                                    Uint16Array<ArrayBufferLike>,
                                    Int32Array<ArrayBufferLike>,
                                    Uint32Array<ArrayBufferLike>,
                                    Float32Array<ArrayBufferLike>,
                                    Float64Array<ArrayBufferLike>,
                                    BigInt64Array<ArrayBufferLike>,
                                    BigUint64Array<ArrayBufferLike>,
                                    DataView<ArrayBufferLike>,
                                    ReadableStream<Uint8Array<ArrayBufferLike>>,
                                    WritableStream<Uint8Array<ArrayBufferLike>>,
                                    Typescript.Request<option<obj>, U2<RequestInitCfProperties, WorkflowEntrypoint>>,
                                    Rpc.RpcTargetBranded,
                                    WorkflowEntrypoint,
                                    WorkflowEntrypoint,
                                    Map<
                                        U2<
                                            option<
                                                U31<
                                                    WorkflowEntrypoint,
                                                    RegExp,
                                                    Error,
                                                    Typescript.Response,
                                                    ArrayBuffer,
                                                    Headers,
                                                    Date,
                                                    Int8Array<ArrayBufferLike>,
                                                    Uint8Array<ArrayBufferLike>,
                                                    Uint8ClampedArray<ArrayBufferLike>,
                                                    Int16Array<ArrayBufferLike>,
                                                    Uint16Array<ArrayBufferLike>,
                                                    Int32Array<ArrayBufferLike>,
                                                    Uint32Array<ArrayBufferLike>,
                                                    Float32Array<ArrayBufferLike>,
                                                    Float64Array<ArrayBufferLike>,
                                                    BigInt64Array<ArrayBufferLike>,
                                                    BigUint64Array<ArrayBufferLike>,
                                                    DataView<ArrayBufferLike>,
                                                    ReadableStream<Uint8Array<ArrayBufferLike>>,
                                                    WritableStream<Uint8Array<ArrayBufferLike>>,
                                                    Typescript.Request<
                                                        option<obj>,
                                                        U2<RequestInitCfProperties, WorkflowEntrypoint>
                                                     >,
                                                    Rpc.RpcTargetBranded,
                                                    WorkflowEntrypoint,
                                                    WorkflowEntrypoint,
                                                    Map<U2<option<obj>, unit>, U2<option<obj>, unit>>,
                                                    Set<U2<option<obj>, unit>>,
                                                    ReadonlyArray<U2<option<obj>, unit>>,
                                                    WorkflowEntrypoint,
                                                    D1SessionBookmark,
                                                    float
                                                 >
                                             >,
                                            unit
                                         >,
                                        U2<option<obj>, unit>
                                     >,
                                    Set<U2<option<obj>, unit>>,
                                    ReadonlyArray<U2<option<obj>, unit>>,
                                    WorkflowEntrypoint,
                                    D1SessionBookmark,
                                    float
                                 >
                             >,
                            unit
                         >,
                        U2<
                            option<
                                U31<
                                    WorkflowEntrypoint,
                                    RegExp,
                                    Error,
                                    Typescript.Response,
                                    ArrayBuffer,
                                    Headers,
                                    Date,
                                    Int8Array<ArrayBufferLike>,
                                    Uint8Array<ArrayBufferLike>,
                                    Uint8ClampedArray<ArrayBufferLike>,
                                    Int16Array<ArrayBufferLike>,
                                    Uint16Array<ArrayBufferLike>,
                                    Int32Array<ArrayBufferLike>,
                                    Uint32Array<ArrayBufferLike>,
                                    Float32Array<ArrayBufferLike>,
                                    Float64Array<ArrayBufferLike>,
                                    BigInt64Array<ArrayBufferLike>,
                                    BigUint64Array<ArrayBufferLike>,
                                    DataView<ArrayBufferLike>,
                                    ReadableStream<Uint8Array<ArrayBufferLike>>,
                                    WritableStream<Uint8Array<ArrayBufferLike>>,
                                    Typescript.Request<option<obj>, U2<RequestInitCfProperties, WorkflowEntrypoint>>,
                                    Rpc.RpcTargetBranded,
                                    WorkflowEntrypoint,
                                    WorkflowEntrypoint,
                                    Map<
                                        U2<
                                            option<
                                                U31<
                                                    WorkflowEntrypoint,
                                                    RegExp,
                                                    Error,
                                                    Typescript.Response,
                                                    ArrayBuffer,
                                                    Headers,
                                                    Date,
                                                    Int8Array<ArrayBufferLike>,
                                                    Uint8Array<ArrayBufferLike>,
                                                    Uint8ClampedArray<ArrayBufferLike>,
                                                    Int16Array<ArrayBufferLike>,
                                                    Uint16Array<ArrayBufferLike>,
                                                    Int32Array<ArrayBufferLike>,
                                                    Uint32Array<ArrayBufferLike>,
                                                    Float32Array<ArrayBufferLike>,
                                                    Float64Array<ArrayBufferLike>,
                                                    BigInt64Array<ArrayBufferLike>,
                                                    BigUint64Array<ArrayBufferLike>,
                                                    DataView<ArrayBufferLike>,
                                                    ReadableStream<Uint8Array<ArrayBufferLike>>,
                                                    WritableStream<Uint8Array<ArrayBufferLike>>,
                                                    Typescript.Request<
                                                        option<obj>,
                                                        U2<RequestInitCfProperties, WorkflowEntrypoint>
                                                     >,
                                                    Rpc.RpcTargetBranded,
                                                    WorkflowEntrypoint,
                                                    WorkflowEntrypoint,
                                                    Map<U2<option<obj>, unit>, U2<option<obj>, unit>>,
                                                    Set<U2<option<obj>, unit>>,
                                                    ReadonlyArray<U2<option<obj>, unit>>,
                                                    WorkflowEntrypoint,
                                                    D1SessionBookmark,
                                                    float
                                                 >
                                             >,
                                            unit
                                         >,
                                        U2<option<obj>, unit>
                                     >,
                                    Set<U2<option<obj>, unit>>,
                                    ReadonlyArray<U2<option<obj>, unit>>,
                                    WorkflowEntrypoint,
                                    D1SessionBookmark,
                                    float
                                 >
                             >,
                            unit
                         >
                     >,
                    Set<
                        U2<
                            option<
                                U31<
                                    WorkflowEntrypoint,
                                    RegExp,
                                    Error,
                                    Typescript.Response,
                                    ArrayBuffer,
                                    Headers,
                                    Date,
                                    Int8Array<ArrayBufferLike>,
                                    Uint8Array<ArrayBufferLike>,
                                    Uint8ClampedArray<ArrayBufferLike>,
                                    Int16Array<ArrayBufferLike>,
                                    Uint16Array<ArrayBufferLike>,
                                    Int32Array<ArrayBufferLike>,
                                    Uint32Array<ArrayBufferLike>,
                                    Float32Array<ArrayBufferLike>,
                                    Float64Array<ArrayBufferLike>,
                                    BigInt64Array<ArrayBufferLike>,
                                    BigUint64Array<ArrayBufferLike>,
                                    DataView<ArrayBufferLike>,
                                    ReadableStream<Uint8Array<ArrayBufferLike>>,
                                    WritableStream<Uint8Array<ArrayBufferLike>>,
                                    Typescript.Request<option<obj>, U2<RequestInitCfProperties, WorkflowEntrypoint>>,
                                    Rpc.RpcTargetBranded,
                                    WorkflowEntrypoint,
                                    WorkflowEntrypoint,
                                    Map<
                                        U2<
                                            option<
                                                U31<
                                                    WorkflowEntrypoint,
                                                    RegExp,
                                                    Error,
                                                    Typescript.Response,
                                                    ArrayBuffer,
                                                    Headers,
                                                    Date,
                                                    Int8Array<ArrayBufferLike>,
                                                    Uint8Array<ArrayBufferLike>,
                                                    Uint8ClampedArray<ArrayBufferLike>,
                                                    Int16Array<ArrayBufferLike>,
                                                    Uint16Array<ArrayBufferLike>,
                                                    Int32Array<ArrayBufferLike>,
                                                    Uint32Array<ArrayBufferLike>,
                                                    Float32Array<ArrayBufferLike>,
                                                    Float64Array<ArrayBufferLike>,
                                                    BigInt64Array<ArrayBufferLike>,
                                                    BigUint64Array<ArrayBufferLike>,
                                                    DataView<ArrayBufferLike>,
                                                    ReadableStream<Uint8Array<ArrayBufferLike>>,
                                                    WritableStream<Uint8Array<ArrayBufferLike>>,
                                                    Typescript.Request<
                                                        option<obj>,
                                                        U2<RequestInitCfProperties, WorkflowEntrypoint>
                                                     >,
                                                    Rpc.RpcTargetBranded,
                                                    WorkflowEntrypoint,
                                                    WorkflowEntrypoint,
                                                    Map<U2<option<obj>, unit>, U2<option<obj>, unit>>,
                                                    Set<U2<option<obj>, unit>>,
                                                    ReadonlyArray<U2<option<obj>, unit>>,
                                                    WorkflowEntrypoint,
                                                    D1SessionBookmark,
                                                    float
                                                 >
                                             >,
                                            unit
                                         >,
                                        U2<option<obj>, unit>
                                     >,
                                    Set<U2<option<obj>, unit>>,
                                    ReadonlyArray<U2<option<obj>, unit>>,
                                    WorkflowEntrypoint,
                                    D1SessionBookmark,
                                    float
                                 >
                             >,
                            unit
                         >
                     >,
                    ReadonlyArray<
                        U2<
                            option<
                                U31<
                                    WorkflowEntrypoint,
                                    RegExp,
                                    Error,
                                    Typescript.Response,
                                    ArrayBuffer,
                                    Headers,
                                    Date,
                                    Int8Array<ArrayBufferLike>,
                                    Uint8Array<ArrayBufferLike>,
                                    Uint8ClampedArray<ArrayBufferLike>,
                                    Int16Array<ArrayBufferLike>,
                                    Uint16Array<ArrayBufferLike>,
                                    Int32Array<ArrayBufferLike>,
                                    Uint32Array<ArrayBufferLike>,
                                    Float32Array<ArrayBufferLike>,
                                    Float64Array<ArrayBufferLike>,
                                    BigInt64Array<ArrayBufferLike>,
                                    BigUint64Array<ArrayBufferLike>,
                                    DataView<ArrayBufferLike>,
                                    ReadableStream<Uint8Array<ArrayBufferLike>>,
                                    WritableStream<Uint8Array<ArrayBufferLike>>,
                                    Typescript.Request<option<obj>, U2<RequestInitCfProperties, WorkflowEntrypoint>>,
                                    Rpc.RpcTargetBranded,
                                    WorkflowEntrypoint,
                                    WorkflowEntrypoint,
                                    Map<
                                        U2<
                                            option<
                                                U31<
                                                    WorkflowEntrypoint,
                                                    RegExp,
                                                    Error,
                                                    Typescript.Response,
                                                    ArrayBuffer,
                                                    Headers,
                                                    Date,
                                                    Int8Array<ArrayBufferLike>,
                                                    Uint8Array<ArrayBufferLike>,
                                                    Uint8ClampedArray<ArrayBufferLike>,
                                                    Int16Array<ArrayBufferLike>,
                                                    Uint16Array<ArrayBufferLike>,
                                                    Int32Array<ArrayBufferLike>,
                                                    Uint32Array<ArrayBufferLike>,
                                                    Float32Array<ArrayBufferLike>,
                                                    Float64Array<ArrayBufferLike>,
                                                    BigInt64Array<ArrayBufferLike>,
                                                    BigUint64Array<ArrayBufferLike>,
                                                    DataView<ArrayBufferLike>,
                                                    ReadableStream<Uint8Array<ArrayBufferLike>>,
                                                    WritableStream<Uint8Array<ArrayBufferLike>>,
                                                    Typescript.Request<
                                                        option<obj>,
                                                        U2<RequestInitCfProperties, WorkflowEntrypoint>
                                                     >,
                                                    Rpc.RpcTargetBranded,
                                                    WorkflowEntrypoint,
                                                    WorkflowEntrypoint,
                                                    Map<U2<option<obj>, unit>, U2<option<obj>, unit>>,
                                                    Set<U2<option<obj>, unit>>,
                                                    ReadonlyArray<U2<option<obj>, unit>>,
                                                    WorkflowEntrypoint,
                                                    D1SessionBookmark,
                                                    float
                                                 >
                                             >,
                                            unit
                                         >,
                                        U2<option<obj>, unit>
                                     >,
                                    Set<U2<option<obj>, unit>>,
                                    ReadonlyArray<U2<option<obj>, unit>>,
                                    WorkflowEntrypoint,
                                    D1SessionBookmark,
                                    float
                                 >
                             >,
                            unit
                         >
                     >,
                    WorkflowEntrypoint,
                    WorkflowEntrypoint,
                    D1SessionBookmark,
                    float,
                    obj
                 >> =
                [<EmitConstructor>]
                abstract Create: ctx: ExecutionContext<option<obj>> * env: 'Env -> WorkflowEntrypoint

                inherit Rpc.WorkflowEntrypointBranded
                abstract env: 'Env with get, set
                abstract ctx: ExecutionContext<option<obj>> with get, set

                [<CompiledName("[Rpc.__WORKFLOW_ENTRYPOINT_BRAND]")>]
                abstract ``[rpc._WORKFLOWENTRYPOINTBRAND]``: unit with get, set

                abstract run: event: WorkflowEntrypoint.Run.Event * step: WorkflowStep -> Promise<option<obj>>

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkflowStepConfig")>]
            type WorkflowStepConfig =
                abstract timeout:
                    option<
                        U15<
                            WorkflowStepConfig.Timeout,
                            WorkflowStepConfig.Timeout,
                            WorkflowStepConfig.Timeout,
                            WorkflowStepConfig.Timeout,
                            WorkflowStepConfig.Timeout,
                            WorkflowStepConfig.Timeout,
                            WorkflowStepConfig.Timeout,
                            WorkflowStepConfig.Timeout,
                            WorkflowStepConfig.Timeout,
                            WorkflowStepConfig.Timeout,
                            WorkflowStepConfig.Timeout,
                            WorkflowStepConfig.Timeout,
                            WorkflowStepConfig.Timeout,
                            WorkflowStepConfig.Timeout,
                            float
                         >
                     > with get, set

                abstract retries: option<WorkflowStepConfig.Retries> with get, set

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkflowStepEvent")>]
            type WorkflowStepEvent<'T> =
                [<CompiledName("type")>]
                abstract ``type``: D1SessionBookmark with get, set

                abstract timestamp: Date with get, set
                abstract payload: WorkflowStepEvent.Payload with get, set

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkerEntrypoint")>]
            type WorkerEntrypoint<'Props, 'Env> =
                [<EmitConstructor>]
                abstract Create: ctx: ExecutionContext<option<obj>> * env: 'Env -> WorkerEntrypoint

                inherit Rpc.WorkerEntrypointBranded
                abstract env: 'Env with get, set
                abstract ctx: ExecutionContext<'Props> with get, set

                [<CompiledName("[Rpc.__WORKER_ENTRYPOINT_BRAND]")>]
                abstract ``[rpc._WORKERENTRYPOINTBRAND]``: unit with get, set

                abstract trace: traces: Array<TraceItem> -> option<Promise<unit>>
                abstract test: controller: TestController -> option<Promise<unit>>

                abstract tailStream:
                    event: TailStream.TailEvent<TailStream.Onset> ->
                        U3<
                            TailStream.TailEvent<'Event> -> option<Promise<unit>>,
                            TailStream.TailEventHandlerObject,
                            Promise<TailStream.TailEventHandlerType>
                         >

                abstract tail: events: Array<TraceItem> -> option<Promise<unit>>
                abstract scheduled: controller: ScheduledController -> option<Promise<unit>>
                abstract queue: batch: MessageBatch<option<obj>> -> option<Promise<unit>>
                abstract connect: socket: Socket -> option<Promise<unit>>

                abstract fetch:
                    request:
                        Typescript.Request<option<obj>, U2<RequestInitCfProperties, WorkerEntrypoint.Fetch.Request>> ->
                        U2<Typescript.Response, Promise<Typescript.Response>>

                abstract email: message: ForwardableEmailMessage -> option<Promise<unit>>

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "RpcTarget")>]
            type RpcTarget =
                inherit Rpc.RpcTargetBranded

                [<CompiledName("[Rpc.__RPC_TARGET_BRAND]")>]
                abstract ``[rpc._RPCTARGETBRAND]``: unit with get, set

            type WorkflowRetentionDuration =
                U15<
                    WorkflowRetentionDuration,
                    WorkflowRetentionDuration,
                    WorkflowRetentionDuration,
                    WorkflowRetentionDuration,
                    WorkflowRetentionDuration,
                    WorkflowRetentionDuration,
                    WorkflowRetentionDuration,
                    WorkflowRetentionDuration,
                    WorkflowRetentionDuration,
                    WorkflowRetentionDuration,
                    WorkflowRetentionDuration,
                    WorkflowRetentionDuration,
                    WorkflowRetentionDuration,
                    WorkflowRetentionDuration,
                    float
                 >

            type WorkflowSleepDuration =
                U15<
                    WorkflowSleepDuration,
                    WorkflowSleepDuration,
                    WorkflowSleepDuration,
                    WorkflowSleepDuration,
                    WorkflowSleepDuration,
                    WorkflowSleepDuration,
                    WorkflowSleepDuration,
                    WorkflowSleepDuration,
                    WorkflowSleepDuration,
                    WorkflowSleepDuration,
                    WorkflowSleepDuration,
                    WorkflowSleepDuration,
                    WorkflowSleepDuration,
                    WorkflowSleepDuration,
                    float
                 >

            type WorkflowDelayDuration =
                U15<
                    WorkflowDelayDuration,
                    WorkflowDelayDuration,
                    WorkflowDelayDuration,
                    WorkflowDelayDuration,
                    WorkflowDelayDuration,
                    WorkflowDelayDuration,
                    WorkflowDelayDuration,
                    WorkflowDelayDuration,
                    WorkflowDelayDuration,
                    WorkflowDelayDuration,
                    WorkflowDelayDuration,
                    WorkflowDelayDuration,
                    WorkflowDelayDuration,
                    WorkflowDelayDuration,
                    float
                 >

            type RpcStub<'T when 'T :> Rpc.Stubable> = RpcStub

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type WorkflowBackoff =
                | [<CompiledName("constant")>] Constant
                | [<CompiledName("linear")>] Linear
                | [<CompiledName("exponential")>] Exponential

            module RollbackContext =
                type Output = interface end

            module StepPromise =
                module Rollback =
                    type Config =
                        abstract backoff: option<WorkflowBackoff> with get, set

                        abstract delay:
                            U15<
                                Config.Delay,
                                Config.Delay,
                                Config.Delay,
                                Config.Delay,
                                Config.Delay,
                                Config.Delay,
                                Config.Delay,
                                Config.Delay,
                                Config.Delay,
                                Config.Delay,
                                Config.Delay,
                                Config.Delay,
                                Config.Delay,
                                Config.Delay,
                                float
                             > with get, set

                        abstract limit: float with get, set

                        abstract timeout:
                            option<
                                U15<
                                    Config.Timeout,
                                    Config.Timeout,
                                    Config.Timeout,
                                    Config.Timeout,
                                    Config.Timeout,
                                    Config.Timeout,
                                    Config.Timeout,
                                    Config.Timeout,
                                    Config.Timeout,
                                    Config.Timeout,
                                    Config.Timeout,
                                    Config.Timeout,
                                    Config.Timeout,
                                    Config.Timeout,
                                    float
                                 >
                             > with get, set

                        abstract retries: option<Config.Retries> with get, set

            module WorkerEntrypoint =
                type TailStream =
                    abstract attributes: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                    [<CompiledName("return")>]
                    abstract ``return``: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                    abstract log: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                    [<CompiledName("exception")>]
                    abstract ``exception``: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                    abstract diagnosticChannel: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set
                    abstract spanClose: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set
                    abstract spanOpen: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set
                    abstract outcome: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

            module WorkflowEntrypoint =
                type T =
                    [<CompiledName("[__RPC_STUB_BRAND]")>]
                    abstract ``[_rPCSTUBBRAND]``: 'T with get, set

                    abstract ``[symbol.dispose]``: unit -> unit
                    abstract dup: unit -> 'StubBase
                    abstract Item: key: D1SessionBookmark -> option<obj>
                    abstract Invoke: [<ParamArray>] args: Array<option<obj>> -> option<obj>

                module Run =
                    type Event =
                        abstract instanceId: D1SessionBookmark with get, set
                        abstract timestamp: Date with get, set
                        abstract payload: Event.Payload with get, set
                        abstract Item: key: D1SessionBookmark -> option<obj>

            module WorkflowStep =
                type WaitForEvent =
                    [<CompiledName("type")>]
                    abstract ``type``: D1SessionBookmark with get, set

                    abstract timestamp: Date with get, set
                    abstract payload: WaitForEvent.Payload with get, set
                    abstract Item: key: D1SessionBookmark -> option<obj>

                module Do =
                    type TemplateLiteral =
                        abstract Value: string
                        abstract Create: v0: float -> TemplateLiteral

                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                    type Callback =
                        | [<CompiledName("constant")>] Constant
                        | [<CompiledName("linear")>] Linear
                        | [<CompiledName("exponential")>] Exponential

                module WaitForEvent =
                    type Options =
                        abstract timeout:
                            option<
                                U15<
                                    Options.Timeout,
                                    Options.Timeout,
                                    Options.Timeout,
                                    Options.Timeout,
                                    Options.Timeout,
                                    Options.Timeout,
                                    Options.Timeout,
                                    Options.Timeout,
                                    Options.Timeout,
                                    Options.Timeout,
                                    Options.Timeout,
                                    Options.Timeout,
                                    Options.Timeout,
                                    Options.Timeout,
                                    float
                                 >
                             > with get, set

                        [<CompiledName("type")>]
                        abstract ``type``: D1SessionBookmark with get, set

            module WorkflowStepConfig =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Retries =
                    | [<CompiledName("constant")>] Constant
                    | [<CompiledName("linear")>] Linear
                    | [<CompiledName("exponential")>] Exponential

            module WorkflowStepContext =
                type Step =
                    abstract count: float with get, set
                    abstract name: D1SessionBookmark with get, set

                type Config =
                    abstract timeout:
                        option<
                            U15<
                                Config.Timeout,
                                Config.Timeout,
                                Config.Timeout,
                                Config.Timeout,
                                Config.Timeout,
                                Config.Timeout,
                                Config.Timeout,
                                Config.Timeout,
                                Config.Timeout,
                                Config.Timeout,
                                Config.Timeout,
                                Config.Timeout,
                                Config.Timeout,
                                Config.Timeout,
                                float
                             >
                         > with get, set

                    abstract retries: option<Config.Retries> with get, set
                    abstract backoff: option<WorkflowBackoff> with get, set

                    abstract delay:
                        U15<
                            Config.Delay,
                            Config.Delay,
                            Config.Delay,
                            Config.Delay,
                            Config.Delay,
                            Config.Delay,
                            Config.Delay,
                            Config.Delay,
                            Config.Delay,
                            Config.Delay,
                            Config.Delay,
                            Config.Delay,
                            Config.Delay,
                            Config.Delay,
                            float
                         > with get, set

                    abstract limit: float with get, set

        module ColoLocalActorNamespace =
            type Get =
                abstract connect: address: U2<SocketAddress, D1SessionBookmark> * ?options: SocketOptions -> Socket

                abstract fetch:
                    input:
                        U3<
                            Typescript.Request<option<obj>, U2<RequestInitCfProperties, Get.Fetch.Input>>,
                            URL,
                            D1SessionBookmark
                         > *
                    ?init: Typescript.RequestInit<U2<RequestInitCfProperties, Get.Fetch.Init>> ->
                        Promise<Typescript.Response>

        module ComparisonFilter =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("eq")>] Eq
                | [<CompiledName("ne")>] Ne
                | [<CompiledName("gt")>] Gt
                | [<CompiledName("gte")>] Gte
                | [<CompiledName("lt")>] Lt
                | [<CompiledName("lte")>] Lte

        module CompletionUsage =
            type CompletionTokensDetails =
                [<CompiledName("rejected_prediction_tokens")>]
                abstract rejectedPredictionTokens: option<float> with get, set

                [<CompiledName("accepted_prediction_tokens")>]
                abstract acceptedPredictionTokens: option<float> with get, set

                [<CompiledName("audio_tokens")>]
                abstract audioTokens: option<float> with get, set

                [<CompiledName("reasoning_tokens")>]
                abstract reasoningTokens: option<float> with get, set

            type PromptTokensDetails =
                [<CompiledName("audio_tokens")>]
                abstract audioTokens: option<float> with get, set

                [<CompiledName("cached_tokens")>]
                abstract cachedTokens: option<float> with get, set

        module CompoundFilter =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("and")>] And
                | [<CompiledName("or")>] Or

        module CompressionStream =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Format =
                | [<CompiledName("gzip")>] Gzip
                | [<CompiledName("deflate")>] Deflate
                | [<CompiledName("deflate-raw")>] DeflateRaw

        module Container =
            type GetTcpPort =
                abstract connect: address: U2<SocketAddress, D1SessionBookmark> * ?options: SocketOptions -> Socket

                abstract fetch:
                    input:
                        U3<
                            Typescript.Request<option<obj>, U2<RequestInitCfProperties, GetTcpPort.Fetch.Input>>,
                            URL,
                            D1SessionBookmark
                         > *
                    ?init: Typescript.RequestInit<U2<RequestInitCfProperties, GetTcpPort.Fetch.Init>> ->
                        Promise<Typescript.Response>

        module ConversionOptions =
            type Html =
                abstract cssSelector: option<D1SessionBookmark> with get, set
                abstract hostname: option<D1SessionBookmark> with get, set
                abstract images: option<Html.Images> with get, set
                abstract convertOGImage: option<bool> with get, set
                abstract maxConvertedImages: option<float> with get, set
                abstract convert: option<bool> with get, set
                abstract descriptionLanguage: option<Html.DescriptionLanguage> with get, set

            type Docx =
                abstract maxConvertedImages: option<float> with get, set
                abstract convert: option<bool> with get, set
                abstract descriptionLanguage: option<Docx.DescriptionLanguage> with get, set
                abstract images: option<EmbeddedImageConversionOptions> with get, set

            type Pdf =
                abstract metadata: option<bool> with get, set
                abstract images: option<EmbeddedImageConversionOptions> with get, set

            type Image =
                abstract descriptionLanguage: option<Image.DescriptionLanguage> with get, set

        module ConversionRequestOptions =
            type ConversionOptions =
                abstract convertOGImage: option<bool> with get, set
                abstract maxConvertedImages: option<float> with get, set
                abstract convert: option<bool> with get, set
                abstract descriptionLanguage: option<ConversionOptions.DescriptionLanguage> with get, set
                abstract metadata: option<bool> with get, set
                abstract images: option<EmbeddedImageConversionOptions> with get, set
                abstract pdf: option<ConversionOptions.Pdf> with get, set
                abstract image: option<ImageConversionOptions> with get, set
                abstract docx: option<ConversionOptions.Docx> with get, set
                abstract html: option<ConversionOptions.Html> with get, set
                abstract cssSelector: option<D1SessionBookmark> with get, set
                abstract hostname: option<D1SessionBookmark> with get, set
                abstract images: option<ConversionOptions.Images> with get, set

            type Gateway =
                abstract retries: option<GatewayRetries> with get, set
                abstract requestTimeoutMs: option<float> with get, set
                abstract eventId: option<D1SessionBookmark> with get, set
                abstract collectLog: option<bool> with get, set
                abstract metadata: option<Gateway.Metadata> with get, set
                abstract skipCache: option<bool> with get, set
                abstract cacheTtl: option<float> with get, set
                abstract cacheKey: option<D1SessionBookmark> with get, set
                abstract id: D1SessionBookmark with get, set
                abstract backoff: option<CloudflareWorkersModule.WorkflowBackoff> with get, set
                abstract retryDelayMs: option<float> with get, set
                abstract maxAttempts: option<Gateway.MaxAttempts> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

        module Crypto =
            type DigestStream =
                abstract prototype: DigestStream with get, set
                abstract Create: algorithm: U2<SubtleCryptoHashAlgorithm, D1SessionBookmark> -> DigestStream

        module D1Database =
            module WithSession =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type ConstraintOrBookmark =
                    | [<CompiledName("first-primary")>] FirstPrimary
                    | [<CompiledName("first-unconstrained")>] FirstUnconstrained

        module D1DatabaseSession =
            type Batch =
                [<CompiledName("sql_duration_ms")>]
                abstract sqlDurationMs: float with get, set

                [<CompiledName("total_attempts")>]
                abstract totalAttempts: option<float> with get, set

                abstract timings: option<Batch.Timings> with get, set

                [<CompiledName("served_by_primary")>]
                abstract servedByPrimary: option<bool> with get, set

                [<CompiledName("served_by_colo")>]
                abstract servedByColo: option<D1SessionBookmark> with get, set

                [<CompiledName("served_by_region")>]
                abstract servedByRegion: option<D1SessionBookmark> with get, set

                abstract changes: float with get, set

                [<CompiledName("changed_db")>]
                abstract changedDb: bool with get, set

                [<CompiledName("last_row_id")>]
                abstract lastRowId: float with get, set

                [<CompiledName("rows_written")>]
                abstract rowsWritten: float with get, set

                [<CompiledName("rows_read")>]
                abstract rowsRead: float with get, set

                [<CompiledName("size_after")>]
                abstract sizeAfter: float with get, set

                abstract duration: float with get, set
                abstract results: Array<'T> with get, set
                abstract error: option<unit> with get, set
                abstract meta: Batch.Meta with get, set
                abstract success: Batch.Success with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

        module D1Meta =
            type Timings =
                [<CompiledName("sql_duration_ms")>]
                abstract sqlDurationMs: float with get, set

        module D1PreparedStatement =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Run = | [<CompiledValue(true)>] True

            module Raw =
                type Options =
                    abstract columnNames: Options.ColumnNames with get, set
                    abstract columnNames: option<Options.ColumnNames> with get, set

        module D1Response =
            type Meta =
                [<CompiledName("total_attempts")>]
                abstract totalAttempts: option<float> with get, set

                abstract timings: option<Meta.Timings> with get, set

                [<CompiledName("served_by_primary")>]
                abstract servedByPrimary: option<bool> with get, set

                [<CompiledName("served_by_colo")>]
                abstract servedByColo: option<D1SessionBookmark> with get, set

                [<CompiledName("served_by_region")>]
                abstract servedByRegion: option<D1SessionBookmark> with get, set

                abstract changes: float with get, set

                [<CompiledName("changed_db")>]
                abstract changedDb: bool with get, set

                [<CompiledName("last_row_id")>]
                abstract lastRowId: float with get, set

                [<CompiledName("rows_written")>]
                abstract rowsWritten: float with get, set

                [<CompiledName("rows_read")>]
                abstract rowsRead: float with get, set

                [<CompiledName("size_after")>]
                abstract sizeAfter: float with get, set

                abstract duration: float with get, set

                [<CompiledName("sql_duration_ms")>]
                abstract sqlDurationMs: float with get, set

                abstract Item: key: D1SessionBookmark -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Success = | [<CompiledValue(true)>] True

        module D1Result =
            type Meta =
                [<CompiledName("sql_duration_ms")>]
                abstract sqlDurationMs: float with get, set

                [<CompiledName("total_attempts")>]
                abstract totalAttempts: option<float> with get, set

                abstract timings: option<Meta.Timings> with get, set

                [<CompiledName("served_by_primary")>]
                abstract servedByPrimary: option<bool> with get, set

                [<CompiledName("served_by_colo")>]
                abstract servedByColo: option<D1SessionBookmark> with get, set

                [<CompiledName("served_by_region")>]
                abstract servedByRegion: option<D1SessionBookmark> with get, set

                abstract changes: float with get, set

                [<CompiledName("changed_db")>]
                abstract changedDb: bool with get, set

                [<CompiledName("last_row_id")>]
                abstract lastRowId: float with get, set

                [<CompiledName("rows_written")>]
                abstract rowsWritten: float with get, set

                [<CompiledName("rows_read")>]
                abstract rowsRead: float with get, set

                [<CompiledName("size_after")>]
                abstract sizeAfter: float with get, set

                abstract duration: float with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Success = | [<CompiledValue(true)>] True

        module DecompressionStream =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Format =
                | [<CompiledName("gzip")>] Gzip
                | [<CompiledName("deflate")>] Deflate
                | [<CompiledName("deflate-raw")>] DeflateRaw

        module DeveloperMessage =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Role = | [<CompiledName("developer")>] Developer

        module DispatchNamespace =
            type Get =
                abstract connect: address: U2<SocketAddress, D1SessionBookmark> * ?options: SocketOptions -> Socket

                abstract fetch:
                    input:
                        U3<
                            Typescript.Request<option<obj>, U2<RequestInitCfProperties, Get.Fetch.Input>>,
                            URL,
                            D1SessionBookmark
                         > *
                    ?init: Typescript.RequestInit<U2<RequestInitCfProperties, Get.Fetch.Init>> ->
                        Promise<Typescript.Response>

            module Get =
                type Args =
                    abstract Item: key: D1SessionBookmark -> option<obj>

        module DurableObjectFacets =
            type Get =
                abstract connect: address: U2<SocketAddress, D1SessionBookmark> * ?options: SocketOptions -> Socket

                abstract fetch:
                    input:
                        U3<
                            Typescript.Request<option<obj>, U2<RequestInitCfProperties, Get.Fetch.Input>>,
                            URL,
                            D1SessionBookmark
                         > *
                    ?init: Typescript.RequestInit<U2<RequestInitCfProperties, Get.Fetch.Init>> ->
                        Promise<Typescript.Response>

                abstract Item: key: D1SessionBookmark -> option<obj>

                abstract catch:
                    ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

                abstract ``then``:
                    ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                    ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                        Promise<U2<'TResult1, 'TResult2>>

                abstract Invoke: [<ParamArray>] args: Get.Get.Args -> U2<Get.Get, U2<Get.Get, unit>>

        module DurableObjectNamespace =
            type Get =
                abstract name: option<D1SessionBookmark> with get
                abstract id: DurableObjectId with get
                abstract connect: address: U2<SocketAddress, D1SessionBookmark> * ?options: SocketOptions -> Socket

                abstract fetch:
                    input:
                        U3<
                            Typescript.Request<option<obj>, U2<RequestInitCfProperties, Get.Fetch.Input>>,
                            URL,
                            D1SessionBookmark
                         > *
                    ?init: Typescript.RequestInit<U2<RequestInitCfProperties, Get.Fetch.Init>> ->
                        Promise<Typescript.Response>

                abstract Item: key: D1SessionBookmark -> option<obj>

                abstract catch:
                    ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

                abstract ``then``:
                    ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                    ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                        Promise<U2<'TResult1, 'TResult2>>

                abstract Invoke: [<ParamArray>] args: Get.Get.Args -> U2<Get.Get, U2<Get.Get, unit>>

            module Jurisdiction =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Jurisdiction =
                    | [<CompiledName("eu")>] Eu
                    | [<CompiledName("fedramp")>] Fedramp
                    | [<CompiledName("fedramp-high")>] FedrampHigh

        module DurableObjectNamespaceGetDurableObjectOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type LocationHint =
                | [<CompiledName("wnam")>] Wnam
                | [<CompiledName("enam")>] Enam
                | [<CompiledName("sam")>] Sam
                | [<CompiledName("weur")>] Weur
                | [<CompiledName("eeur")>] Eeur
                | [<CompiledName("apac")>] Apac
                | [<CompiledName("oc")>] Oc
                | [<CompiledName("afr")>] Afr
                | [<CompiledName("me")>] Me

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type RoutingMode = | [<CompiledName("primary-only")>] PrimaryOnly

        module DurableObjectNamespaceNewUniqueIdOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Jurisdiction =
                | [<CompiledName("eu")>] Eu
                | [<CompiledName("fedramp")>] Fedramp
                | [<CompiledName("fedramp-high")>] FedrampHigh

        module DurableObjectStorage =
            module Put =
                type Entries =
                    abstract Item: key: D1SessionBookmark -> option<obj>

        module DurableObjectTransaction =
            module Put =
                type Entries =
                    abstract Item: key: D1SessionBookmark -> option<obj>

        module DynamicDispatchOptions =
            type Outbound =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module EasyInputMessage =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Role =
                | [<CompiledName("user")>] User
                | [<CompiledName("assistant")>] Assistant
                | [<CompiledName("system")>] System
                | [<CompiledName("developer")>] Developer

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("message")>] Message

        module EmbeddedImageConversionOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type DescriptionLanguage =
                | [<CompiledName("en")>] En
                | [<CompiledName("es")>] Es
                | [<CompiledName("fr")>] Fr
                | [<CompiledName("it")>] It
                | [<CompiledName("pt")>] Pt
                | [<CompiledName("de")>] De

        module EventContext =
            type Env =
                abstract ASSETS: Env.ASSETS with get, set
                abstract fetch: Env.Fetch with get, set

                abstract Invoke:
                    input:
                        U3<
                            Typescript.Request<option<obj>, U2<RequestInitCfProperties, Env.Env.Input>>,
                            URL,
                            D1SessionBookmark
                         > *
                    ?init: Typescript.RequestInit<RequestInitCfProperties> ->
                        Promise<Typescript.Response>

                abstract Invoke:
                    input:
                        U3<
                            Typescript.Request<option<obj>, U2<RequestInitCfProperties, Env.Env.Input>>,
                            URL,
                            D1SessionBookmark
                         > *
                    ?init: Typescript.RequestInit<U2<RequestInitCfProperties, Env.Env.Init>> ->
                        Promise<Typescript.Response>

        module EventPluginContext =
            type Env =
                abstract ASSETS: Env.ASSETS with get, set
                abstract fetch: Env.Fetch with get, set

                abstract Invoke:
                    input:
                        U3<
                            Typescript.Request<option<obj>, U2<RequestInitCfProperties, Env.Env.Input>>,
                            URL,
                            D1SessionBookmark
                         > *
                    ?init: Typescript.RequestInit<RequestInitCfProperties> ->
                        Promise<Typescript.Response>

                abstract Invoke:
                    input:
                        U3<
                            Typescript.Request<option<obj>, U2<RequestInitCfProperties, Env.Env.Input>>,
                            URL,
                            D1SessionBookmark
                         > *
                    ?init: Typescript.RequestInit<U2<RequestInitCfProperties, Env.Env.Init>> ->
                        Promise<Typescript.Response>

        module EventSourceEventSourceInit =
            type Fetcher =
                abstract connect: address: U2<SocketAddress, D1SessionBookmark> * ?options: SocketOptions -> Socket

                abstract fetch:
                    input:
                        U3<
                            Typescript.Request<option<obj>, U2<RequestInitCfProperties, Fetcher.Fetch.Input>>,
                            URL,
                            D1SessionBookmark
                         > *
                    ?init: Typescript.RequestInit<U2<RequestInitCfProperties, Fetcher.Fetch.Init>> ->
                        Promise<Typescript.Response>

        module EventTarget =
            type EventMap =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module ExportedHandler =
            type Queue =
                abstract Invoke:
                    batch: MessageBatch<'Message> * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

            type Email =
                abstract Invoke:
                    message: ForwardableEmailMessage * env: 'Env * ctx: ExecutionContext<'Props> ->
                        option<Promise<unit>>

            type Test =
                abstract Invoke:
                    controller: TestController * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

            type Scheduled =
                abstract Invoke:
                    controller: ScheduledController * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

            type Fetch =
                abstract tlsClientAuth:
                    U2<IncomingRequestCfPropertiesTLSClientAuth, IncomingRequestCfPropertiesTLSClientAuthPlaceholder> with get, set

                /// <example>
                /// "635"
                /// </example>
                abstract metroCode: option<D1SessionBookmark> with get, set
                /// <example>
                /// "TX"
                /// </example>
                abstract regionCode: option<D1SessionBookmark> with get, set
                /// <example>
                /// "Texas"
                /// </example>
                abstract region: option<D1SessionBookmark> with get, set
                /// <example>
                /// "America/Chicago"
                /// </example>
                abstract timezone: option<D1SessionBookmark> with get, set
                /// <example>
                /// "-97.74260"
                /// </example>
                abstract longitude: option<D1SessionBookmark> with get, set
                /// <example>
                /// "30.27130"
                /// </example>
                abstract latitude: option<D1SessionBookmark> with get, set
                /// <example>
                /// "78701"
                /// </example>
                abstract postalCode: option<D1SessionBookmark> with get, set
                /// <example>
                /// "Austin"
                /// </example>
                abstract city: option<D1SessionBookmark> with get, set
                /// <example>
                /// "AN"
                /// </example>
                abstract continent: option<ContinentCode> with get, set
                /// <example>
                /// "1"
                /// </example>
                abstract isEUCountry: option<Fetch.IsEUCountry> with get, set
                /// <example>
                /// "GB"
                /// </example>
                abstract country: option<Fetch.Country> with get, set
                abstract hostMetadata: option<'HostMetadata> with get, set
                /// <deprecated />
                abstract clientTrustScore: float with get, set
                abstract botManagement: IncomingRequestCfPropertiesBotManagementBase with get, set
                abstract botManagement: Fetch.BotManagement with get, set
                abstract tlsExportedAuthenticator: option<IncomingRequestCfPropertiesExportedAuthenticatorMetadata> with get, set
                /// <example>
                /// "AEAD-AES128-GCM-SHA256"
                /// </example>
                abstract tlsCipher: D1SessionBookmark with get, set
                /// <example>
                /// "TLSv1.3"
                /// </example>
                abstract tlsVersion: D1SessionBookmark with get, set
                /// <example>
                /// "weight=192;exclusive=0;group=3;group-weight=127"
                /// </example>
                abstract requestPriority: D1SessionBookmark with get, set
                /// <example>
                /// "HTTP/2"
                /// </example>
                abstract httpProtocol: D1SessionBookmark with get, set
                /// <example>
                /// 3
                /// </example>
                abstract edgeRequestKeepAliveStatus: Fetch.EdgeRequestKeepAliveStatus with get, set
                /// <example>
                /// "DFW"
                /// </example>
                abstract colo: D1SessionBookmark with get, set
                /// <example>
                /// 22
                /// </example>
                abstract clientTcpRtt: option<float> with get, set
                /// <example>
                /// "gzip, deflate, br"
                /// </example>
                abstract clientAcceptEncoding: option<D1SessionBookmark> with get, set
                /// <example>
                /// "Google Cloud"
                /// </example>
                abstract asOrganization: option<D1SessionBookmark> with get, set
                /// <example>
                /// 395747
                /// </example>
                abstract asn: option<float> with get, set
                abstract ja3Hash: D1SessionBookmark with get, set
                abstract detectionIds: AiSentenceSimilarityOutput with get, set
                abstract staticResource: bool with get, set
                abstract corporateProxy: bool with get, set
                abstract verifiedBot: bool with get, set
                /// <example>
                /// 54
                /// </example>
                abstract score: float with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

                abstract Invoke:
                    request: Typescript.Request<'CfHostMetadata, Fetch.Fetch.Request> *
                    env: 'Env *
                    ctx: ExecutionContext<'Props> ->
                        U2<Typescript.Response, Promise<Typescript.Response>>

            type TailStream =
                abstract attributes: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                [<CompiledName("return")>]
                abstract ``return``: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                abstract log: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                [<CompiledName("exception")>]
                abstract ``exception``: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                abstract diagnosticChannel: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract spanClose: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract spanOpen: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract outcome: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                abstract Invoke:
                    event: TailStream.TailEvent<TailStream.Onset> * env: 'Env * ctx: ExecutionContext<'Props> ->
                        U3<
                            TailStream.TailEvent<'Event> -> option<Promise<unit>>,
                            TailStream.TailEventHandlerObject,
                            Promise<TailStream.TailEventHandlerType>
                         >

            type Trace =
                abstract Invoke:
                    traces: Array<TraceItem> * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

            type Tail =
                abstract Invoke:
                    events: Array<TraceItem> * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

            type Connect =
                abstract Invoke: socket: Socket * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        module ExportedHandlerTailStreamHandler =
            type Invoke =
                abstract attributes: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                [<CompiledName("return")>]
                abstract ``return``: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                abstract log: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                [<CompiledName("exception")>]
                abstract ``exception``: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                abstract diagnosticChannel: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract spanClose: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract spanOpen: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract outcome: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

        module Flagship =
            module Get =
                type Context =
                    abstract Item: key: D1SessionBookmark -> option<obj>

        module ForbiddenError =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Name = | ForbiddenError

        module FormData =
            module ForEach =
                type Callback =
                    abstract Invoke:
                        this: 'This * value: D1SessionBookmark * key: D1SessionBookmark * parent: FormData -> unit

        module FunctionMessage =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Role = | [<CompiledName("function")>] Function

        module GatewayOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Retries =
                | [<CompiledName("constant")>] Constant
                | [<CompiledName("linear")>] Linear
                | [<CompiledName("exponential")>] Exponential

        module GatewayRetries =
            type MaxAttempts =
                | ``1`` = 1
                | ``2`` = 2
                | ``3`` = 3
                | ``4`` = 4
                | ``5`` = 5

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Backoff =
                | [<CompiledName("constant")>] Constant
                | [<CompiledName("linear")>] Linear
                | [<CompiledName("exponential")>] Exponential

        module Headers =
            type Init =
                abstract Item: key: D1SessionBookmark -> option<obj>

            module ForEach =
                type Callback =
                    abstract Invoke:
                        this: 'This * value: D1SessionBookmark * key: D1SessionBookmark * parent: Headers -> unit

        module HelloWorldBinding =
            type Get =
                abstract ms: option<float> with get, set
                abstract value: D1SessionBookmark with get, set

        module ImageConversionOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type DescriptionLanguage =
                | [<CompiledName("en")>] En
                | [<CompiledName("es")>] Es
                | [<CompiledName("fr")>] Fr
                | [<CompiledName("it")>] It
                | [<CompiledName("pt")>] Pt
                | [<CompiledName("de")>] De

        module ImageInputOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Encoding = | [<CompiledName("base64")>] Base64

        module ImageListOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type SortOrder =
                | [<CompiledName("asc")>] Asc
                | [<CompiledName("desc")>] Desc

        module ImageOutputOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Format =
                | [<CompiledName("image/jpeg")>] ``Image/jpeg``
                | [<CompiledName("image/png")>] ``Image/png``
                | [<CompiledName("image/gif")>] ``Image/gif``
                | [<CompiledName("image/webp")>] ``Image/webp``
                | [<CompiledName("image/avif")>] ``Image/avif``
                | [<CompiledName("rgb")>] Rgb
                | [<CompiledName("rgba")>] Rgba

        module ImageTransform =
            type Rotate =
                | ``0`` = 0
                | ``90`` = 90
                | ``180`` = 180
                | ``270`` = 270

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Flip =
                | [<CompiledName("h")>] H
                | [<CompiledName("v")>] V
                | [<CompiledName("hv")>] Hv

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Fit =
                | [<CompiledName("scale-down")>] ScaleDown
                | [<CompiledName("contain")>] Contain
                | [<CompiledName("pad")>] Pad
                | [<CompiledName("squeeze")>] Squeeze
                | [<CompiledName("cover")>] Cover
                | [<CompiledName("crop")>] Crop

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Segment = | [<CompiledName("foreground")>] Foreground

        module ImageTransformationOutputOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Encoding = | [<CompiledName("base64")>] Base64

        module ImageTransformationResult =
            module Image =
                type Options =
                    abstract encoding: option<Options.Encoding> with get, set

        module ImageTransformer =
            module Draw =
                type Options =
                    abstract right: option<float> with get, set
                    abstract bottom: option<float> with get, set
                    abstract left: option<float> with get, set
                    abstract top: option<float> with get, set
                    abstract repeat: option<U2<bool, D1SessionBookmark>> with get, set
                    abstract opacity: option<float> with get, set

            module Output =
                type Options =
                    abstract anim: option<bool> with get, set
                    abstract background: option<D1SessionBookmark> with get, set
                    abstract quality: option<float> with get, set
                    abstract format: Options.Format with get, set

            module Transform =
                type Transform =
                    abstract keep: option<float> with get, set
                    abstract tolerance: option<float> with get, set
                    abstract color: option<D1SessionBookmark> with get, set
                    abstract right: option<float> with get, set
                    abstract left: option<float> with get, set
                    abstract bottom: option<float> with get, set
                    abstract top: option<float> with get, set
                    abstract width: option<float> with get, set
                    abstract trim: option<U2<Transform.Trim, Transform.Trim>> with get, set
                    abstract sharpen: option<float> with get, set
                    abstract saturation: option<float> with get, set
                    abstract rotate: option<Transform.Rotate> with get, set
                    abstract gravity: option<U2<Transform.Gravity, Transform.Gravity>> with get, set
                    abstract segment: option<Transform.Segment> with get, set
                    abstract gamma: option<float> with get, set
                    abstract flip: option<Transform.Flip> with get, set
                    abstract fit: option<Transform.Fit> with get, set
                    abstract contrast: option<float> with get, set
                    abstract brightness: option<float> with get, set
                    abstract border: option<U2<Transform.Border, Transform.Border>> with get, set
                    abstract blur: option<float> with get, set
                    abstract background: option<D1SessionBookmark> with get, set
                    abstract height: option<float> with get, set
                    abstract mode: Transform.Mode with get, set
                    abstract y: option<float> with get, set
                    abstract x: option<float> with get, set
                    abstract border: option<U2<Transform.Border, bool>> with get, set

        module ImageUploadOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Encoding = | [<CompiledName("base64")>] Base64

        module ImagesBinding =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Info = | [<CompiledName("image/svg+xml")>] ``Image/svg+xml``

            module Info =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Options = | [<CompiledName("base64")>] Base64

        module IncomingRequestCfProperties =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Continent =
                | AF
                | AN
                | AS
                | EU
                | NA
                | OC
                | SA

            type EdgeRequestKeepAliveStatus =
                | ``0`` = 0
                | ``2`` = 2
                | ``3`` = 3
                | ``1`` = 1
                | ``4`` = 4
                | ``5`` = 5

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type IsEUCountry = | [<CompiledName("1")>] ``1``

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Country =
                | ES
                | AF
                | AS
                | NA
                | SA
                | AD
                | AE
                | AG
                | AI
                | AL
                | AM
                | AO
                | AQ
                | AR
                | AT
                | AU
                | AW
                | AX
                | AZ
                | BA
                | BB
                | BD
                | BE
                | BF
                | BG
                | BH
                | BI
                | BJ
                | BL
                | BM
                | BN
                | BO
                | BQ
                | BR
                | BS
                | BT
                | BV
                | BW
                | BY
                | BZ
                | CA
                | CC
                | CD
                | CF
                | CG
                | CH
                | CI
                | CK
                | CL
                | CM
                | CN
                | CO
                | CR
                | CU
                | CV
                | CW
                | CX
                | CY
                | CZ
                | DE
                | DJ
                | DK
                | DM
                | DO
                | DZ
                | EC
                | EE
                | EG
                | EH
                | ER
                | ET
                | FI
                | FJ
                | FK
                | FM
                | FO
                | FR
                | GA
                | GB
                | GD
                | GE
                | GF
                | GG
                | GH
                | GI
                | GL
                | GM
                | GN
                | GP
                | GQ
                | GR
                | GS
                | GT
                | GU
                | GW
                | GY
                | HK
                | HM
                | HN
                | HR
                | HT
                | HU
                | ID
                | IE
                | IL
                | IM
                | IN
                | IO
                | IQ
                | IR
                | IS
                | IT
                | JE
                | JM
                | JO
                | JP
                | KE
                | KG
                | KH
                | KI
                | KM
                | KN
                | KP
                | KR
                | KW
                | KY
                | KZ
                | LA
                | LB
                | LC
                | LI
                | LK
                | LR
                | LS
                | LT
                | LU
                | LV
                | LY
                | MA
                | MC
                | MD
                | ME
                | MF
                | MG
                | MH
                | MK
                | ML
                | MM
                | MN
                | MO
                | MP
                | MQ
                | MR
                | MS
                | MT
                | MU
                | MV
                | MW
                | MX
                | MY
                | MZ
                | NC
                | NE
                | NF
                | NG
                | NI
                | NL
                | NO
                | NP
                | NR
                | NU
                | NZ
                | OM
                | PA
                | PE
                | PF
                | PG
                | PH
                | PK
                | PL
                | PM
                | PN
                | PR
                | PS
                | PT
                | PW
                | PY
                | QA
                | RE
                | RO
                | RS
                | RU
                | RW
                | SB
                | SC
                | SD
                | SE
                | SG
                | SH
                | SI
                | SJ
                | SK
                | SL
                | SM
                | SN
                | SO
                | SR
                | SS
                | ST
                | SV
                | SX
                | SY
                | SZ
                | TC
                | TD
                | TF
                | TG
                | TH
                | TJ
                | TK
                | TL
                | TM
                | TN
                | TO
                | TR
                | TT
                | TV
                | TW
                | TZ
                | UA
                | UG
                | UM
                | US
                | UY
                | UZ
                | VA
                | VC
                | VE
                | VG
                | VI
                | VN
                | VU
                | WF
                | WS
                | YE
                | YT
                | ZA
                | ZM
                | ZW
                | T1

            type BotManagement =
                abstract ja3Hash: D1SessionBookmark with get, set
                abstract detectionIds: AiSentenceSimilarityOutput with get, set
                abstract staticResource: bool with get, set
                abstract corporateProxy: bool with get, set
                abstract verifiedBot: bool with get, set
                /// <example>
                /// 54
                /// </example>
                abstract score: float with get, set

        module IncomingRequestCfPropertiesBase =
            type EdgeRequestKeepAliveStatus =
                | ``0`` = 0
                | ``2`` = 2
                | ``3`` = 3
                | ``1`` = 1
                | ``4`` = 4
                | ``5`` = 5

        module IncomingRequestCfPropertiesBotManagementEnterprise =
            type BotManagement =
                abstract ja3Hash: D1SessionBookmark with get, set
                abstract detectionIds: AiSentenceSimilarityOutput with get, set
                abstract staticResource: bool with get, set
                abstract corporateProxy: bool with get, set
                abstract verifiedBot: bool with get, set
                /// <example>
                /// 54
                /// </example>
                abstract score: float with get, set

        module IncomingRequestCfPropertiesGeographicInformation =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Continent =
                | AF
                | AN
                | AS
                | EU
                | NA
                | OC
                | SA

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Country =
                | ES
                | AF
                | AS
                | NA
                | SA
                | AD
                | AE
                | AG
                | AI
                | AL
                | AM
                | AO
                | AQ
                | AR
                | AT
                | AU
                | AW
                | AX
                | AZ
                | BA
                | BB
                | BD
                | BE
                | BF
                | BG
                | BH
                | BI
                | BJ
                | BL
                | BM
                | BN
                | BO
                | BQ
                | BR
                | BS
                | BT
                | BV
                | BW
                | BY
                | BZ
                | CA
                | CC
                | CD
                | CF
                | CG
                | CH
                | CI
                | CK
                | CL
                | CM
                | CN
                | CO
                | CR
                | CU
                | CV
                | CW
                | CX
                | CY
                | CZ
                | DE
                | DJ
                | DK
                | DM
                | DO
                | DZ
                | EC
                | EE
                | EG
                | EH
                | ER
                | ET
                | FI
                | FJ
                | FK
                | FM
                | FO
                | FR
                | GA
                | GB
                | GD
                | GE
                | GF
                | GG
                | GH
                | GI
                | GL
                | GM
                | GN
                | GP
                | GQ
                | GR
                | GS
                | GT
                | GU
                | GW
                | GY
                | HK
                | HM
                | HN
                | HR
                | HT
                | HU
                | ID
                | IE
                | IL
                | IM
                | IN
                | IO
                | IQ
                | IR
                | IS
                | IT
                | JE
                | JM
                | JO
                | JP
                | KE
                | KG
                | KH
                | KI
                | KM
                | KN
                | KP
                | KR
                | KW
                | KY
                | KZ
                | LA
                | LB
                | LC
                | LI
                | LK
                | LR
                | LS
                | LT
                | LU
                | LV
                | LY
                | MA
                | MC
                | MD
                | ME
                | MF
                | MG
                | MH
                | MK
                | ML
                | MM
                | MN
                | MO
                | MP
                | MQ
                | MR
                | MS
                | MT
                | MU
                | MV
                | MW
                | MX
                | MY
                | MZ
                | NC
                | NE
                | NF
                | NG
                | NI
                | NL
                | NO
                | NP
                | NR
                | NU
                | NZ
                | OM
                | PA
                | PE
                | PF
                | PG
                | PH
                | PK
                | PL
                | PM
                | PN
                | PR
                | PS
                | PT
                | PW
                | PY
                | QA
                | RE
                | RO
                | RS
                | RU
                | RW
                | SB
                | SC
                | SD
                | SE
                | SG
                | SH
                | SI
                | SJ
                | SK
                | SL
                | SM
                | SN
                | SO
                | SR
                | SS
                | ST
                | SV
                | SX
                | SY
                | SZ
                | TC
                | TD
                | TF
                | TG
                | TH
                | TJ
                | TK
                | TL
                | TM
                | TN
                | TO
                | TR
                | TT
                | TV
                | TW
                | TZ
                | UA
                | UG
                | UM
                | US
                | UY
                | UZ
                | VA
                | VC
                | VE
                | VG
                | VI
                | VN
                | VU
                | WF
                | WS
                | YE
                | YT
                | ZA
                | ZM
                | ZW
                | T1

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type IsEUCountry = | [<CompiledName("1")>] ``1``

        module IncomingRequestCfPropertiesTLSClientAuth =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type CertPresented = | [<CompiledName("1")>] ``1``

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type CertVerified =
                | SUCCESS
                | [<CompiledName("FAILED:self signed certificate")>] ``FAILED:self signed certificate``
                | [<CompiledName("FAILED:unable to verify the first certificate")>] ``FAILED:unable to verify the first certificate``
                | [<CompiledName("FAILED:certificate is not yet valid")>] ``FAILED:certificate is not yet valid``
                | [<CompiledName("FAILED:certificate has expired")>] ``FAILED:certificate has expired``
                | FAILED

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type CertRevoked =
                | [<CompiledName("1")>] ``1``
                | [<CompiledName("0")>] ``0``

        module IncomingRequestCfPropertiesTLSClientAuthPlaceholder =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type CertPresented = | [<CompiledName("0")>] ``0``

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type CertVerified = | NONE

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type CertIssuerDN = | [<CompiledName("")>] ````

        module InstanceStatus =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Status =
                | [<CompiledName("queued")>] Queued
                | [<CompiledName("running")>] Running
                | [<CompiledName("paused")>] Paused
                | [<CompiledName("errored")>] Errored
                | [<CompiledName("terminated")>] Terminated
                | [<CompiledName("complete")>] Complete
                | [<CompiledName("waiting")>] Waiting
                | [<CompiledName("waitingForPause")>] WaitingForPause
                | [<CompiledName("unknown")>] Unknown

            type Error =
                abstract message: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set

        module InternalError =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Name = | InternalError

        module InvalidURLError =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Name = | InvalidURLError

        module KVNamespace =
            type List =
                abstract cacheStatus: option<D1SessionBookmark> with get, set
                abstract cursor: D1SessionBookmark with get, set
                abstract keys: Array<KVNamespaceListKey<'Metadata, 'Key>> with get, set

                [<CompiledName("list_complete")>]
                abstract listComplete: List.ListComplete with get, set

            module Get =
                type Options =
                    abstract cacheTtl: option<float> with get, set

                    [<CompiledName("type")>]
                    abstract ``type``: option<unit> with get, set

                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type =
                    | [<CompiledName("text")>] Text
                    | [<CompiledName("json")>] Json
                    | [<CompiledName("arrayBuffer")>] ArrayBuffer
                    | [<CompiledName("stream")>] Stream

        module LoopbackDurableObjectClass =
            module Invoke =
                type Opts =
                    abstract props: option<obj> with get, set
                    abstract props: option<'Props> with get, set

        module LoopbackForExport =
            type T =
                abstract Create: [<ParamArray>] args: Array<option<obj>> -> Rpc.EntrypointBranded

        module LoopbackServiceStub =
            module Invoke =
                type Opts =
                    abstract props: option<obj> with get, set
                    abstract props: option<'Props> with get, set

        module MaxFileSizeError =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Name = | MaxFileSizeError

        module MediaTransformationGenerator =
            module Output =
                type Output =
                    abstract format: option<Output.Format> with get, set
                    abstract imageCount: option<float> with get, set
                    abstract duration: option<D1SessionBookmark> with get, set
                    abstract time: option<D1SessionBookmark> with get, set
                    abstract audio: option<bool> with get, set
                    abstract mode: option<Output.Mode> with get, set

        module MediaTransformationInputOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Fit =
                | [<CompiledName("contain")>] Contain
                | [<CompiledName("cover")>] Cover
                | [<CompiledName("scale-down")>] ScaleDown

        module MediaTransformationOutputOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Format =
                | [<CompiledName("jpg")>] Jpg
                | [<CompiledName("png")>] Png
                | [<CompiledName("m4a")>] M4a

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Mode =
                | [<CompiledName("video")>] Video
                | [<CompiledName("spritesheet")>] Spritesheet
                | [<CompiledName("frame")>] Frame
                | [<CompiledName("audio")>] Audio

        module MediaTransformer =
            module Output =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Output =
                    | [<CompiledName("video")>] Video
                    | [<CompiledName("spritesheet")>] Spritesheet
                    | [<CompiledName("frame")>] Frame
                    | [<CompiledName("audio")>] Audio
                    | [<CompiledName("jpg")>] Jpg
                    | [<CompiledName("png")>] Png
                    | [<CompiledName("m4a")>] M4a

            module Transform =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Transform =
                    | [<CompiledName("contain")>] Contain
                    | [<CompiledName("cover")>] Cover
                    | [<CompiledName("scale-down")>] ScaleDown

        module MessageSendRequest =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ContentType =
                | [<CompiledName("text")>] Text
                | [<CompiledName("json")>] Json
                | [<CompiledName("bytes")>] Bytes
                | [<CompiledName("v8")>] V8

        module NotFoundError =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Name = | NotFoundError

        module PagesFunction =
            type Data =
                abstract Item: key: D1SessionBookmark -> option<obj>

            module Invoke =
                type Context =
                    abstract tlsClientAuth:
                        U2<IncomingRequestCfPropertiesTLSClientAuth, IncomingRequestCfPropertiesTLSClientAuthPlaceholder> with get, set

                    /// <example>
                    /// "635"
                    /// </example>
                    abstract metroCode: option<D1SessionBookmark> with get, set
                    /// <example>
                    /// "TX"
                    /// </example>
                    abstract regionCode: option<D1SessionBookmark> with get, set
                    /// <example>
                    /// "Texas"
                    /// </example>
                    abstract region: option<D1SessionBookmark> with get, set
                    /// <example>
                    /// "America/Chicago"
                    /// </example>
                    abstract timezone: option<D1SessionBookmark> with get, set
                    /// <example>
                    /// "-97.74260"
                    /// </example>
                    abstract longitude: option<D1SessionBookmark> with get, set
                    /// <example>
                    /// "30.27130"
                    /// </example>
                    abstract latitude: option<D1SessionBookmark> with get, set
                    /// <example>
                    /// "78701"
                    /// </example>
                    abstract postalCode: option<D1SessionBookmark> with get, set
                    /// <example>
                    /// "Austin"
                    /// </example>
                    abstract city: option<D1SessionBookmark> with get, set
                    /// <example>
                    /// "AN"
                    /// </example>
                    abstract continent: option<ContinentCode> with get, set
                    /// <example>
                    /// "1"
                    /// </example>
                    abstract isEUCountry: option<Context.IsEUCountry> with get, set
                    /// <example>
                    /// "GB"
                    /// </example>
                    abstract country: option<Context.Country> with get, set
                    abstract hostMetadata: option<'HostMetadata> with get, set
                    /// <deprecated />
                    abstract clientTrustScore: float with get, set
                    abstract botManagement: IncomingRequestCfPropertiesBotManagementBase with get, set
                    abstract botManagement: Context.BotManagement with get, set
                    abstract tlsExportedAuthenticator: option<IncomingRequestCfPropertiesExportedAuthenticatorMetadata> with get, set
                    /// <example>
                    /// "AEAD-AES128-GCM-SHA256"
                    /// </example>
                    abstract tlsCipher: D1SessionBookmark with get, set
                    /// <example>
                    /// "TLSv1.3"
                    /// </example>
                    abstract tlsVersion: D1SessionBookmark with get, set
                    /// <example>
                    /// "weight=192;exclusive=0;group=3;group-weight=127"
                    /// </example>
                    abstract requestPriority: D1SessionBookmark with get, set
                    /// <example>
                    /// "HTTP/2"
                    /// </example>
                    abstract httpProtocol: D1SessionBookmark with get, set
                    /// <example>
                    /// 3
                    /// </example>
                    abstract edgeRequestKeepAliveStatus: Context.EdgeRequestKeepAliveStatus with get, set
                    /// <example>
                    /// "DFW"
                    /// </example>
                    abstract colo: D1SessionBookmark with get, set
                    /// <example>
                    /// 22
                    /// </example>
                    abstract clientTcpRtt: option<float> with get, set
                    /// <example>
                    /// "gzip, deflate, br"
                    /// </example>
                    abstract clientAcceptEncoding: option<D1SessionBookmark> with get, set
                    /// <example>
                    /// "Google Cloud"
                    /// </example>
                    abstract asOrganization: option<D1SessionBookmark> with get, set
                    /// <example>
                    /// 395747
                    /// </example>
                    abstract asn: option<float> with get, set
                    abstract data: 'Data with get, set
                    abstract params: Context.Params with get, set
                    abstract env: Context.Env with get, set
                    abstract functionPath: D1SessionBookmark with get, set
                    abstract request: Typescript.Request<option<obj>, Context.Request> with get, set
                    abstract ASSETS: Context.ASSETS with get, set
                    abstract fetch: Context.Fetch with get, set
                    abstract ja3Hash: D1SessionBookmark with get, set
                    abstract detectionIds: AiSentenceSimilarityOutput with get, set
                    abstract staticResource: bool with get, set
                    abstract corporateProxy: bool with get, set
                    abstract verifiedBot: bool with get, set
                    /// <example>
                    /// 54
                    /// </example>
                    abstract score: float with get, set
                    abstract Item: key: D1SessionBookmark -> option<obj>

                    abstract next:
                        ?input: RequestInfo *
                        ?init: Typescript.RequestInit<U2<RequestInitCfProperties, Context.Next.Init>> ->
                            Promise<Typescript.Response>

                    abstract passThroughOnException: unit -> unit
                    abstract waitUntil: promise: Promise<option<obj>> -> unit

                    abstract Invoke:
                        input:
                            U3<
                                Typescript.Request<option<obj>, U2<RequestInitCfProperties, Context.Context.Input>>,
                                URL,
                                D1SessionBookmark
                             > *
                        ?init: Typescript.RequestInit<RequestInitCfProperties> ->
                            Promise<Typescript.Response>

                    abstract Invoke:
                        input:
                            U3<
                                Typescript.Request<option<obj>, U2<RequestInitCfProperties, Context.Context.Input>>,
                                URL,
                                D1SessionBookmark
                             > *
                        ?init: Typescript.RequestInit<U2<RequestInitCfProperties, Context.Context.Init>> ->
                            Promise<Typescript.Response>

        module PagesPluginFunction =
            module Invoke =
                type Context =
                    abstract ASSETS: Context.ASSETS with get, set
                    abstract pluginArgs: 'PluginArgs with get, set
                    abstract data: 'Data with get, set
                    abstract params: Context.Params with get, set
                    abstract env: Context.Env with get, set
                    abstract functionPath: D1SessionBookmark with get, set
                    abstract request: Typescript.Request<option<obj>, Context.Request> with get, set
                    abstract fetch: Context.Fetch with get, set

                    abstract next:
                        ?input: RequestInfo *
                        ?init: Typescript.RequestInit<U2<RequestInitCfProperties, Context.Next.Init>> ->
                            Promise<Typescript.Response>

                    abstract passThroughOnException: unit -> unit
                    abstract waitUntil: promise: Promise<option<obj>> -> unit

                    abstract Invoke:
                        input:
                            U3<
                                Typescript.Request<option<obj>, U2<RequestInitCfProperties, Context.Context.Input>>,
                                URL,
                                D1SessionBookmark
                             > *
                        ?init: Typescript.RequestInit<RequestInitCfProperties> ->
                            Promise<Typescript.Response>

                    abstract Invoke:
                        input:
                            U3<
                                Typescript.Request<option<obj>, U2<RequestInitCfProperties, Context.Context.Input>>,
                                URL,
                                D1SessionBookmark
                             > *
                        ?init: Typescript.RequestInit<U2<RequestInitCfProperties, Context.Context.Init>> ->
                            Promise<Typescript.Response>

        module PredictionContent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("content")>] Content

        module QueueSendOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ContentType =
                | [<CompiledName("text")>] Text
                | [<CompiledName("json")>] Json
                | [<CompiledName("bytes")>] Bytes
                | [<CompiledName("v8")>] V8

        module QuotaReachedError =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Name = | QuotaReachedError

        module R2Bucket =
            type List =
                abstract truncated: List.Truncated with get, set
                abstract delimitedPrefixes: Array<D1SessionBookmark> with get, set
                abstract objects: Array<R2Object> with get, set
                abstract cursor: D1SessionBookmark with get, set

            module Get =
                type Options =
                    abstract onlyIf: U2<R2Conditional, Headers> with get, set
                    abstract ssecKey: option<U2<ArrayBuffer, D1SessionBookmark>> with get, set
                    abstract range: option<U4<Options.Range, Options.Range, Options.Range, Headers>> with get, set
                    abstract onlyIf: option<U2<R2Conditional, Headers>> with get, set

            module Put =
                type Options =
                    abstract onlyIf: U2<R2Conditional, Headers> with get, set
                    abstract ssecKey: option<U2<ArrayBuffer, D1SessionBookmark>> with get, set
                    abstract storageClass: option<D1SessionBookmark> with get, set
                    abstract sha512: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, D1SessionBookmark>> with get, set
                    abstract sha384: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, D1SessionBookmark>> with get, set
                    abstract sha256: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, D1SessionBookmark>> with get, set
                    abstract sha1: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, D1SessionBookmark>> with get, set
                    abstract md5: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, D1SessionBookmark>> with get, set
                    abstract customMetadata: option<Options.CustomMetadata> with get, set
                    abstract httpMetadata: option<U2<R2HTTPMetadata, Headers>> with get, set
                    abstract onlyIf: option<U2<R2Conditional, Headers>> with get, set

        module R2GetOptions =
            type Range =
                abstract length: option<float> with get, set
                abstract offset: float with get, set
                abstract suffix: float with get, set
                abstract length: float with get, set
                abstract offset: option<float> with get, set

        module R2Object =
            type Range =
                abstract length: option<float> with get, set
                abstract offset: float with get, set
                abstract length: float with get, set
                abstract offset: option<float> with get, set
                abstract suffix: float with get, set

        module RateLimitedError =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Name = | RateLimitedError

        module Reasoning =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type GenerateSummary =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("concise")>] Concise
                | [<CompiledName("detailed")>] Detailed

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Effort =
                | [<CompiledName("high")>] High
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium")>] Medium
                | [<CompiledName("minimal")>] Minimal

        module RemoveEventListener =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("fetch")>] Fetch
                | [<CompiledName("queue")>] Queue
                | [<CompiledName("scheduled")>] Scheduled
                | [<CompiledName("rejectionhandled")>] Rejectionhandled
                | [<CompiledName("unhandledrejection")>] Unhandledrejection

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type K =
                | [<CompiledName("waiting")>] Waiting
                | [<CompiledName("abort")>] Abort
                | [<CompiledName("error")>] Error
                | [<CompiledName("close")>] Close
                | [<CompiledName("message")>] Message
                | [<CompiledName("messageerror")>] Messageerror
                | [<CompiledName("contextlost")>] Contextlost
                | [<CompiledName("contextrestored")>] Contextrestored
                | [<CompiledName("animationcancel")>] Animationcancel
                | [<CompiledName("animationend")>] Animationend
                | [<CompiledName("animationiteration")>] Animationiteration
                | [<CompiledName("animationstart")>] Animationstart
                | [<CompiledName("auxclick")>] Auxclick
                | [<CompiledName("beforeinput")>] Beforeinput
                | [<CompiledName("beforematch")>] Beforematch
                | [<CompiledName("beforetoggle")>] Beforetoggle
                | [<CompiledName("blur")>] Blur
                | [<CompiledName("cancel")>] Cancel
                | [<CompiledName("canplay")>] Canplay
                | [<CompiledName("canplaythrough")>] Canplaythrough
                | [<CompiledName("change")>] Change
                | [<CompiledName("click")>] Click
                | [<CompiledName("compositionend")>] Compositionend
                | [<CompiledName("compositionstart")>] Compositionstart
                | [<CompiledName("compositionupdate")>] Compositionupdate
                | [<CompiledName("contextmenu")>] Contextmenu
                | [<CompiledName("copy")>] Copy
                | [<CompiledName("cuechange")>] Cuechange
                | [<CompiledName("cut")>] Cut
                | [<CompiledName("dblclick")>] Dblclick
                | [<CompiledName("drag")>] Drag
                | [<CompiledName("dragend")>] Dragend
                | [<CompiledName("dragenter")>] Dragenter
                | [<CompiledName("dragleave")>] Dragleave
                | [<CompiledName("dragover")>] Dragover
                | [<CompiledName("dragstart")>] Dragstart
                | [<CompiledName("drop")>] Drop
                | [<CompiledName("durationchange")>] Durationchange
                | [<CompiledName("emptied")>] Emptied
                | [<CompiledName("ended")>] Ended
                | [<CompiledName("focus")>] Focus
                | [<CompiledName("focusin")>] Focusin
                | [<CompiledName("focusout")>] Focusout
                | [<CompiledName("formdata")>] Formdata
                | [<CompiledName("gotpointercapture")>] Gotpointercapture
                | [<CompiledName("input")>] Input
                | [<CompiledName("invalid")>] Invalid
                | [<CompiledName("keydown")>] Keydown
                | [<CompiledName("keypress")>] Keypress
                | [<CompiledName("keyup")>] Keyup
                | [<CompiledName("load")>] Load
                | [<CompiledName("loadeddata")>] Loadeddata
                | [<CompiledName("loadedmetadata")>] Loadedmetadata
                | [<CompiledName("loadstart")>] Loadstart
                | [<CompiledName("lostpointercapture")>] Lostpointercapture
                | [<CompiledName("mousedown")>] Mousedown
                | [<CompiledName("mouseenter")>] Mouseenter
                | [<CompiledName("mouseleave")>] Mouseleave
                | [<CompiledName("mousemove")>] Mousemove
                | [<CompiledName("mouseout")>] Mouseout
                | [<CompiledName("mouseover")>] Mouseover
                | [<CompiledName("mouseup")>] Mouseup
                | [<CompiledName("paste")>] Paste
                | [<CompiledName("pause")>] Pause
                | [<CompiledName("play")>] Play
                | [<CompiledName("playing")>] Playing
                | [<CompiledName("pointercancel")>] Pointercancel
                | [<CompiledName("pointerdown")>] Pointerdown
                | [<CompiledName("pointerenter")>] Pointerenter
                | [<CompiledName("pointerleave")>] Pointerleave
                | [<CompiledName("pointermove")>] Pointermove
                | [<CompiledName("pointerout")>] Pointerout
                | [<CompiledName("pointerover")>] Pointerover
                | [<CompiledName("pointerrawupdate")>] Pointerrawupdate
                | [<CompiledName("pointerup")>] Pointerup
                | [<CompiledName("progress")>] Progress
                | [<CompiledName("ratechange")>] Ratechange
                | [<CompiledName("reset")>] Reset
                | [<CompiledName("resize")>] Resize
                | [<CompiledName("scroll")>] Scroll
                | [<CompiledName("scrollend")>] Scrollend
                | [<CompiledName("securitypolicyviolation")>] Securitypolicyviolation
                | [<CompiledName("seeked")>] Seeked
                | [<CompiledName("seeking")>] Seeking
                | [<CompiledName("select")>] Select
                | [<CompiledName("selectionchange")>] Selectionchange
                | [<CompiledName("selectstart")>] Selectstart
                | [<CompiledName("slotchange")>] Slotchange
                | [<CompiledName("stalled")>] Stalled
                | [<CompiledName("submit")>] Submit
                | [<CompiledName("suspend")>] Suspend
                | [<CompiledName("timeupdate")>] Timeupdate
                | [<CompiledName("toggle")>] Toggle
                | [<CompiledName("touchcancel")>] Touchcancel
                | [<CompiledName("touchend")>] Touchend
                | [<CompiledName("touchmove")>] Touchmove
                | [<CompiledName("touchstart")>] Touchstart
                | [<CompiledName("transitioncancel")>] Transitioncancel
                | [<CompiledName("transitionend")>] Transitionend
                | [<CompiledName("transitionrun")>] Transitionrun
                | [<CompiledName("transitionstart")>] Transitionstart
                | [<CompiledName("volumechange")>] Volumechange
                | [<CompiledName("webkitanimationend")>] Webkitanimationend
                | [<CompiledName("webkitanimationiteration")>] Webkitanimationiteration
                | [<CompiledName("webkitanimationstart")>] Webkitanimationstart
                | [<CompiledName("webkittransitionend")>] Webkittransitionend
                | [<CompiledName("wheel")>] Wheel
                | [<CompiledName("afterprint")>] Afterprint
                | [<CompiledName("beforeprint")>] Beforeprint
                | [<CompiledName("beforeunload")>] Beforeunload
                | [<CompiledName("gamepadconnected")>] Gamepadconnected
                | [<CompiledName("gamepaddisconnected")>] Gamepaddisconnected
                | [<CompiledName("hashchange")>] Hashchange
                | [<CompiledName("languagechange")>] Languagechange
                | [<CompiledName("offline")>] Offline
                | [<CompiledName("online")>] Online
                | [<CompiledName("pagehide")>] Pagehide
                | [<CompiledName("pagereveal")>] Pagereveal
                | [<CompiledName("pageshow")>] Pageshow
                | [<CompiledName("pageswap")>] Pageswap
                | [<CompiledName("popstate")>] Popstate
                | [<CompiledName("rejectionhandled")>] Rejectionhandled
                | [<CompiledName("storage")>] Storage
                | [<CompiledName("unhandledrejection")>] Unhandledrejection
                | [<CompiledName("unload")>] Unload
                | DOMContentLoaded
                | [<CompiledName("devicemotion")>] Devicemotion
                | [<CompiledName("deviceorientation")>] Deviceorientation
                | [<CompiledName("deviceorientationabsolute")>] Deviceorientationabsolute
                | [<CompiledName("orientationchange")>] Orientationchange

        module RequestInfo =
            type Cf =
                abstract tlsClientAuth:
                    U2<IncomingRequestCfPropertiesTLSClientAuth, IncomingRequestCfPropertiesTLSClientAuthPlaceholder> with get, set

                /// <example>
                /// "635"
                /// </example>
                abstract metroCode: option<D1SessionBookmark> with get, set
                /// <example>
                /// "TX"
                /// </example>
                abstract regionCode: option<D1SessionBookmark> with get, set
                /// <example>
                /// "Texas"
                /// </example>
                abstract region: option<D1SessionBookmark> with get, set
                /// <example>
                /// "America/Chicago"
                /// </example>
                abstract timezone: option<D1SessionBookmark> with get, set
                /// <example>
                /// "-97.74260"
                /// </example>
                abstract longitude: option<D1SessionBookmark> with get, set
                /// <example>
                /// "30.27130"
                /// </example>
                abstract latitude: option<D1SessionBookmark> with get, set
                /// <example>
                /// "78701"
                /// </example>
                abstract postalCode: option<D1SessionBookmark> with get, set
                /// <example>
                /// "Austin"
                /// </example>
                abstract city: option<D1SessionBookmark> with get, set
                /// <example>
                /// "AN"
                /// </example>
                abstract continent: option<ContinentCode> with get, set
                /// <example>
                /// "1"
                /// </example>
                abstract isEUCountry: option<Cf.IsEUCountry> with get, set
                /// <example>
                /// "GB"
                /// </example>
                abstract country: option<Cf.Country> with get, set
                abstract hostMetadata: option<'HostMetadata> with get, set
                /// <deprecated />
                abstract clientTrustScore: float with get, set
                abstract botManagement: IncomingRequestCfPropertiesBotManagementBase with get, set
                abstract botManagement: Cf.BotManagement with get, set
                abstract tlsExportedAuthenticator: option<IncomingRequestCfPropertiesExportedAuthenticatorMetadata> with get, set
                /// <example>
                /// "AEAD-AES128-GCM-SHA256"
                /// </example>
                abstract tlsCipher: D1SessionBookmark with get, set
                /// <example>
                /// "TLSv1.3"
                /// </example>
                abstract tlsVersion: D1SessionBookmark with get, set
                /// <example>
                /// "weight=192;exclusive=0;group=3;group-weight=127"
                /// </example>
                abstract requestPriority: D1SessionBookmark with get, set
                /// <example>
                /// "HTTP/2"
                /// </example>
                abstract httpProtocol: D1SessionBookmark with get, set
                /// <example>
                /// 3
                /// </example>
                abstract edgeRequestKeepAliveStatus: Cf.EdgeRequestKeepAliveStatus with get, set
                /// <example>
                /// "DFW"
                /// </example>
                abstract colo: D1SessionBookmark with get, set
                /// <example>
                /// 22
                /// </example>
                abstract clientTcpRtt: option<float> with get, set
                /// <example>
                /// "gzip, deflate, br"
                /// </example>
                abstract clientAcceptEncoding: option<D1SessionBookmark> with get, set
                /// <example>
                /// "Google Cloud"
                /// </example>
                abstract asOrganization: option<D1SessionBookmark> with get, set
                /// <example>
                /// 395747
                /// </example>
                abstract asn: option<float> with get, set
                abstract ja3Hash: D1SessionBookmark with get, set
                abstract detectionIds: AiSentenceSimilarityOutput with get, set
                abstract staticResource: bool with get, set
                abstract corporateProxy: bool with get, set
                abstract verifiedBot: bool with get, set
                /// <example>
                /// 54
                /// </example>
                abstract score: float with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

        module RequestInitCfProperties =
            type CacheTtlByStatus =
                abstract Item: key: D1SessionBookmark -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Polish =
                | [<CompiledName("lossy")>] Lossy
                | [<CompiledName("lossless")>] Lossless
                | [<CompiledName("off")>] Off

        module RequestInitCfPropertiesImage =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Flip =
                | [<CompiledName("h")>] H
                | [<CompiledName("v")>] V
                | [<CompiledName("hv")>] Hv

            type Border =
                abstract left: float with get, set
                abstract bottom: float with get, set
                abstract right: float with get, set
                abstract top: float with get, set
                abstract color: D1SessionBookmark with get, set
                abstract width: float with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Compression = | [<CompiledName("fast")>] Fast

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Format =
                | [<CompiledName("avif")>] Avif
                | [<CompiledName("webp")>] Webp
                | [<CompiledName("json")>] Json
                | [<CompiledName("jpeg")>] Jpeg
                | [<CompiledName("png")>] Png
                | [<CompiledName("baseline-jpeg")>] BaselineJpeg
                | [<CompiledName("png-force")>] PngForce
                | [<CompiledName("svg")>] Svg

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Metadata =
                | [<CompiledName("keep")>] Keep
                | [<CompiledName("copyright")>] Copyright
                | [<CompiledName("none")>] None

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Quality =
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium-low")>] MediumLow
                | [<CompiledName("medium-high")>] MediumHigh
                | [<CompiledName("high")>] High

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type OriginAuth = | [<CompiledName("share-publicly")>] SharePublicly

        module RequestInitCfPropertiesImageDraw =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Repeat =
                | [<CompiledValue(true)>] True
                | [<CompiledName("x")>] X
                | [<CompiledName("y")>] Y

        module ResponseCompletedEvent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("response.completed")>] ``Response.completed``

        module ResponseContentReasoningText =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("reasoning_text")>] ReasoningText

        module ResponseCreatedEvent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("response.created")>] ``Response.created``

        module ResponseCustomToolCallOutput =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("custom_tool_call_output")>] CustomToolCallOutput

        module ResponseError =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Code =
                | [<CompiledName("server_error")>] ServerError
                | [<CompiledName("rate_limit_exceeded")>] RateLimitExceeded
                | [<CompiledName("invalid_prompt")>] InvalidPrompt
                | [<CompiledName("vector_store_timeout")>] VectorStoreTimeout
                | [<CompiledName("invalid_image")>] InvalidImage
                | [<CompiledName("invalid_image_format")>] InvalidImageFormat
                | [<CompiledName("invalid_base64_image")>] InvalidBase64Image
                | [<CompiledName("invalid_image_url")>] InvalidImageUrl
                | [<CompiledName("image_too_large")>] ImageTooLarge
                | [<CompiledName("image_too_small")>] ImageTooSmall
                | [<CompiledName("image_parse_error")>] ImageParseError
                | [<CompiledName("image_content_policy_violation")>] ImageContentPolicyViolation
                | [<CompiledName("invalid_image_mode")>] InvalidImageMode
                | [<CompiledName("image_file_too_large")>] ImageFileTooLarge
                | [<CompiledName("unsupported_image_media_type")>] UnsupportedImageMediaType
                | [<CompiledName("empty_image_file")>] EmptyImageFile
                | [<CompiledName("failed_to_download_image")>] FailedToDownloadImage
                | [<CompiledName("image_file_not_found")>] ImageFileNotFound

        module ResponseErrorEvent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("error")>] Error

        module ResponseFailedEvent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("response.failed")>] ``Response.failed``

        module ResponseFormatJSONObject =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("json_object")>] JsonObject

        module ResponseFormatJSONSchema =
            type JsonSchema =
                abstract strict: option<bool> with get, set
                abstract schema: option<JsonSchema.Schema> with get, set
                abstract description: option<D1SessionBookmark> with get, set
                abstract name: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("json_schema")>] JsonSchema

        module ResponseFormatText =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("text")>] Text

        module ResponseFormatTextJSONSchemaConfig =
            type Schema =
                abstract Item: key: D1SessionBookmark -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("json_schema")>] JsonSchema

        module ResponseFunctionCallArgumentsDeltaEvent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("response.function_call_arguments.delta")>] ``Response.functionCallArguments.delta``

        module ResponseFunctionCallArgumentsDoneEvent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("response.function_call_arguments.done")>] ``Response.functionCallArguments.done``

        module ResponseFunctionToolCall =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("function_call")>] FunctionCall

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Status =
                | [<CompiledName("in_progress")>] InProgress
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("incomplete")>] Incomplete

        module ResponseFunctionToolCallOutputItem =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("function_call_output")>] FunctionCallOutput

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Status =
                | [<CompiledName("in_progress")>] InProgress
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("incomplete")>] Incomplete

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Output =
                | [<CompiledName("input_image")>] InputImage
                | [<CompiledName("low")>] Low
                | [<CompiledName("high")>] High
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("input_text")>] InputText

        module ResponseIncompleteDetails =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Reason =
                | [<CompiledName("max_output_tokens")>] MaxOutputTokens
                | [<CompiledName("content_filter")>] ContentFilter

        module ResponseIncompleteEvent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("response.incomplete")>] ``Response.incomplete``

        module ResponseInputImage =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Detail =
                | [<CompiledName("low")>] Low
                | [<CompiledName("high")>] High
                | [<CompiledName("auto")>] Auto

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("input_image")>] InputImage

        module ResponseInputImageContent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Detail =
                | [<CompiledName("low")>] Low
                | [<CompiledName("high")>] High
                | [<CompiledName("auto")>] Auto

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("input_image")>] InputImage

        module ResponseInputItemFunctionCallOutput =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Status =
                | [<CompiledName("in_progress")>] InProgress
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("incomplete")>] Incomplete

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("function_call_output")>] FunctionCallOutput

        module ResponseInputItemMessage =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("message")>] Message

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Status =
                | [<CompiledName("in_progress")>] InProgress
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("incomplete")>] Incomplete

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Role =
                | [<CompiledName("user")>] User
                | [<CompiledName("system")>] System
                | [<CompiledName("developer")>] Developer

        module ResponseInputMessageItem =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Role =
                | [<CompiledName("user")>] User
                | [<CompiledName("system")>] System
                | [<CompiledName("developer")>] Developer

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Status =
                | [<CompiledName("in_progress")>] InProgress
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("incomplete")>] Incomplete

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("message")>] Message

        module ResponseInputText =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("input_text")>] InputText

        module ResponseInputTextContent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("input_text")>] InputText

        module ResponseOutputItemAddedEvent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("response.output_item.added")>] ``Response.outputItem.added``

        module ResponseOutputItemDoneEvent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("response.output_item.done")>] ``Response.outputItem.done``

        module ResponseOutputMessage =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("message")>] Message

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Role = | [<CompiledName("assistant")>] Assistant

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Status =
                | [<CompiledName("in_progress")>] InProgress
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("incomplete")>] Incomplete

        module ResponseOutputRefusal =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("refusal")>] Refusal

        module ResponseOutputText =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("output_text")>] OutputText

        module ResponseReasoningContentItem =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("reasoning_text")>] ReasoningText

        module ResponseReasoningItem =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("reasoning")>] Reasoning

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Status =
                | [<CompiledName("in_progress")>] InProgress
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("incomplete")>] Incomplete

        module ResponseReasoningSummaryItem =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("summary_text")>] SummaryText

        module ResponseReasoningTextDeltaEvent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("response.reasoning_text.delta")>] ``Response.reasoningText.delta``

        module ResponseReasoningTextDoneEvent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("response.reasoning_text.done")>] ``Response.reasoningText.done``

        module ResponseRefusalDeltaEvent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("response.refusal.delta")>] ``Response.refusal.delta``

        module ResponseRefusalDoneEvent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("response.refusal.done")>] ``Response.refusal.done``

        module ResponseTextConfig =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Verbosity =
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium")>] Medium
                | [<CompiledName("high")>] High

        module ResponseTextDeltaEvent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("response.output_text.delta")>] ``Response.outputText.delta``

        module ResponseTextDoneEvent =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("response.output_text.done")>] ``Response.outputText.done``

        module ResponsesInput =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Truncation =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("disabled")>] Disabled

            type Text =
                [<CompiledName("type")>]
                abstract ``type``: Text.Type with get, set

                abstract verbosity: option<Text.Verbosity> with get, set
                abstract format: option<ResponseFormatTextConfig> with get, set
                abstract strict: option<bool> with get, set
                abstract description: option<D1SessionBookmark> with get, set
                abstract schema: Text.Schema with get, set
                abstract name: D1SessionBookmark with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ServiceTier =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("default")>] Default
                | [<CompiledName("flex")>] Flex
                | [<CompiledName("scale")>] Scale
                | [<CompiledName("priority")>] Priority

        module ResponsesOutput =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Text =
                | [<CompiledName("text")>] Text
                | [<CompiledName("json_schema")>] JsonSchema
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium")>] Medium
                | [<CompiledName("high")>] High

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ServiceTier =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("default")>] Default
                | [<CompiledName("flex")>] Flex
                | [<CompiledName("scale")>] Scale
                | [<CompiledName("priority")>] Priority

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Object = | [<CompiledName("response")>] Response

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Truncation =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("disabled")>] Disabled

            type Usage =
                [<CompiledName("total_tokens")>]
                abstract totalTokens: float with get, set

                [<CompiledName("output_tokens")>]
                abstract outputTokens: float with get, set

                [<CompiledName("input_tokens")>]
                abstract inputTokens: float with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Status =
                | [<CompiledName("queued")>] Queued
                | [<CompiledName("failed")>] Failed
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("in_progress")>] InProgress
                | [<CompiledName("cancelled")>] Cancelled
                | [<CompiledName("incomplete")>] Incomplete

        module Rpc =
            [<Import("@cloudflare/workers-types.Rpc", "WorkflowEntrypointBranded")>]
            type WorkflowEntrypointBranded =
                [<CompiledName("[__WORKFLOW_ENTRYPOINT_BRAND]")>]
                abstract ``[_wORKFLOWENTRYPOINTBRAND]``: unit with get, set

            type MaybeDisposable<'T> = U2<Typescript.Disposable, option<obj>>
            type MethodOrProperty<'V> = U2<MethodOrProperty, U2<MethodOrProperty, U2<MethodOrProperty, unit>>>
            type Stubable = U2<RpcTargetBranded, Stubable>
            type EntrypointBranded = U3<WorkerEntrypointBranded, DurableObjectBranded, WorkflowEntrypointBranded>

            [<Import("@cloudflare/workers-types.Rpc", "DurableObjectBranded")>]
            type DurableObjectBranded =
                [<CompiledName("[__DURABLE_OBJECT_BRAND]")>]
                abstract ``[_dURABLEOBJECTBRAND]``: unit with get, set

            [<Import("@cloudflare/workers-types.Rpc", "Stub")>]
            type Stub<'T when 'T :> Stubable> =
                [<CompiledName("[__RPC_STUB_BRAND]")>]
                abstract ``[_rPCSTUBBRAND]``: 'T with get, set

                abstract ``[symbol.dispose]``: unit -> unit
                abstract dup: unit -> 'StubBase
                abstract Item: key: D1SessionBookmark -> option<obj>

                abstract catch:
                    ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

                abstract ``then``:
                    ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                    ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                        Promise<U2<'TResult1, 'TResult2>>

                abstract Invoke: [<ParamArray>] args: Stub.Stub.Args -> U2<Stub.Stub, U2<Stub.Stub, unit>>

            type Result =
                abstract Item: key: D1SessionBookmark -> option<obj>
                abstract Invoke: [<ParamArray>] args: Result.Result.Args -> U2<Result.Result, U2<Result.Result, unit>>

                abstract catch:
                    ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

                abstract ``then``:
                    ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                    ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                        Promise<U2<'TResult1, 'TResult2>>

            type MaybeCallableProvider =
                abstract Item: key: D1SessionBookmark -> option<obj>

                abstract Invoke:
                    [<ParamArray>] args: MaybeCallableProvider.MaybeCallableProvider.Args ->
                        U2<
                            MaybeCallableProvider.MaybeCallableProvider,
                            U2<MaybeCallableProvider.MaybeCallableProvider, unit>
                         >

                abstract catch:
                    ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

                abstract ``then``:
                    ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                    ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                        Promise<U2<'TResult1, 'TResult2>>

            [<Import("@cloudflare/workers-types.Rpc", "RpcTargetBranded")>]
            type RpcTargetBranded =
                [<CompiledName("[__RPC_TARGET_BRAND]")>]
                abstract ``[_rPCTARGETBRAND]``: unit with get, set

            type BaseType =
                option<
                    U24<
                        Int8Array<ArrayBufferLike>,
                        Uint8Array<ArrayBufferLike>,
                        Uint8ClampedArray<ArrayBufferLike>,
                        Int16Array<ArrayBufferLike>,
                        Uint16Array<ArrayBufferLike>,
                        Int32Array<ArrayBufferLike>,
                        Uint32Array<ArrayBufferLike>,
                        Float32Array<ArrayBufferLike>,
                        Float64Array<ArrayBufferLike>,
                        BigInt64Array<ArrayBufferLike>,
                        BigUint64Array<ArrayBufferLike>,
                        ArrayBuffer,
                        DataView<ArrayBufferLike>,
                        Date,
                        Error,
                        RegExp,
                        ReadableStream<Uint8Array<ArrayBufferLike>>,
                        WritableStream<Uint8Array<ArrayBufferLike>>,
                        Typescript.Request<option<obj>, U2<RequestInitCfProperties, BaseType>>,
                        Typescript.Response,
                        Headers,
                        bool,
                        float,
                        D1SessionBookmark
                     >
                 >

            type Serializable =
                [<CompiledName("[__RPC_STUB_BRAND]")>]
                abstract ``[_rPCSTUBBRAND]``: 'T with get, set

                abstract Invoke: [<ParamArray>] args: Array<option<obj>> -> option<obj>
                abstract ``[symbol.dispose]``: unit -> unit
                abstract dup: unit -> 'StubBase
                abstract Item: key: D1SessionBookmark -> option<obj>

            type MaybeProvider<'T> = U2<MaybeProvider, option<obj>>

            [<Import("@cloudflare/workers-types.Rpc", "Provider")>]
            type Provider<'Reserved, 'T when 'Reserved :> D1SessionBookmark and 'T :> obj> =
                abstract Item: key: D1SessionBookmark -> option<obj>

                abstract catch:
                    ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

                abstract ``then``:
                    ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                    ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                        Promise<U2<'TResult1, 'TResult2>>

                abstract Invoke:
                    [<ParamArray>] args: Provider.Provider.Args -> U2<Provider.Provider, U2<Provider.Provider, unit>>

            type Stubify<'T> =
                U2<
                    Stubify,
                    U2<
                        Map<
                            U2<
                                Stubify,
                                U2<
                                    Map<
                                        U2<
                                            Stubify,
                                            U2<
                                                option<obj>,
                                                U2<
                                                    Set<
                                                        U2<
                                                            Stubify,
                                                            U2<
                                                                option<obj>,
                                                                U2<
                                                                    Set<U2<Stubify, option<obj>>>,
                                                                    U2<
                                                                        Array<U2<Stubify, option<obj>>>,
                                                                        U2<
                                                                            ReadonlyArray<U2<Stubify, option<obj>>>,
                                                                            U2<'T, U2<Stubify, 'T>>
                                                                         >
                                                                     >
                                                                 >
                                                             >
                                                         >
                                                     >,
                                                    U2<
                                                        Array<U2<Stubify, option<obj>>>,
                                                        U2<
                                                            ReadonlyArray<U2<Stubify, option<obj>>>,
                                                            U2<'T, U2<Stubify, 'T>>
                                                         >
                                                     >
                                                 >
                                             >
                                         >,
                                        U2<
                                            Stubify,
                                            U2<
                                                option<obj>,
                                                U2<
                                                    Set<
                                                        U2<
                                                            Stubify,
                                                            U2<
                                                                option<obj>,
                                                                U2<
                                                                    Set<U2<Stubify, option<obj>>>,
                                                                    U2<
                                                                        Array<U2<Stubify, option<obj>>>,
                                                                        U2<
                                                                            ReadonlyArray<U2<Stubify, option<obj>>>,
                                                                            U2<'T, U2<Stubify, 'T>>
                                                                         >
                                                                     >
                                                                 >
                                                             >
                                                         >
                                                     >,
                                                    U2<
                                                        Array<U2<Stubify, option<obj>>>,
                                                        U2<
                                                            ReadonlyArray<U2<Stubify, option<obj>>>,
                                                            U2<'T, U2<Stubify, 'T>>
                                                         >
                                                     >
                                                 >
                                             >
                                         >
                                     >,
                                    U2<
                                        Set<
                                            U2<
                                                Stubify,
                                                U2<
                                                    option<obj>,
                                                    U2<
                                                        Set<U2<Stubify, option<obj>>>,
                                                        U2<
                                                            Array<U2<Stubify, option<obj>>>,
                                                            U2<
                                                                ReadonlyArray<U2<Stubify, option<obj>>>,
                                                                U2<'T, U2<Stubify, 'T>>
                                                             >
                                                         >
                                                     >
                                                 >
                                             >
                                         >,
                                        U2<
                                            Array<U2<Stubify, option<obj>>>,
                                            U2<ReadonlyArray<U2<Stubify, option<obj>>>, U2<'T, U2<Stubify, 'T>>>
                                         >
                                     >
                                 >
                             >,
                            U2<
                                Stubify,
                                U2<
                                    option<obj>,
                                    U2<
                                        Set<
                                            U2<
                                                Stubify,
                                                U2<
                                                    option<obj>,
                                                    U2<
                                                        Set<U2<Stubify, option<obj>>>,
                                                        U2<
                                                            Array<U2<Stubify, option<obj>>>,
                                                            U2<
                                                                ReadonlyArray<U2<Stubify, option<obj>>>,
                                                                U2<'T, U2<Stubify, 'T>>
                                                             >
                                                         >
                                                     >
                                                 >
                                             >
                                         >,
                                        U2<
                                            Array<U2<Stubify, option<obj>>>,
                                            U2<ReadonlyArray<U2<Stubify, option<obj>>>, U2<'T, U2<Stubify, 'T>>>
                                         >
                                     >
                                 >
                             >
                         >,
                        U2<
                            Set<
                                U2<
                                    Stubify,
                                    U2<
                                        option<obj>,
                                        U2<
                                            Set<U2<Stubify, option<obj>>>,
                                            U2<
                                                Array<U2<Stubify, option<obj>>>,
                                                U2<ReadonlyArray<U2<Stubify, option<obj>>>, U2<'T, U2<Stubify, 'T>>>
                                             >
                                         >
                                     >
                                 >
                             >,
                            U2<
                                Array<U2<Stubify, option<obj>>>,
                                U2<ReadonlyArray<U2<Stubify, option<obj>>>, U2<'T, U2<Stubify, 'T>>>
                             >
                         >
                     >
                 >

            type Unstubify<'T> =
                U2<
                    'V,
                    U2<
                        Map<
                            U2<
                                'V,
                                U2<
                                    Map<
                                        U2<
                                            'V,
                                            U2<
                                                option<obj>,
                                                U2<
                                                    Set<
                                                        U2<
                                                            'V,
                                                            U2<
                                                                option<obj>,
                                                                U2<
                                                                    Set<U2<'V, option<obj>>>,
                                                                    U2<
                                                                        Array<U2<'V, option<obj>>>,
                                                                        U2<
                                                                            ReadonlyArray<U2<'V, option<obj>>>,
                                                                            U2<'T, U2<Unstubify, 'T>>
                                                                         >
                                                                     >
                                                                 >
                                                             >
                                                         >
                                                     >,
                                                    U2<
                                                        Array<U2<'V, option<obj>>>,
                                                        U2<ReadonlyArray<U2<'V, option<obj>>>, U2<'T, U2<Unstubify, 'T>>>
                                                     >
                                                 >
                                             >
                                         >,
                                        U2<
                                            'V,
                                            U2<
                                                option<obj>,
                                                U2<
                                                    Set<
                                                        U2<
                                                            'V,
                                                            U2<
                                                                option<obj>,
                                                                U2<
                                                                    Set<U2<'V, option<obj>>>,
                                                                    U2<
                                                                        Array<U2<'V, option<obj>>>,
                                                                        U2<
                                                                            ReadonlyArray<U2<'V, option<obj>>>,
                                                                            U2<'T, U2<Unstubify, 'T>>
                                                                         >
                                                                     >
                                                                 >
                                                             >
                                                         >
                                                     >,
                                                    U2<
                                                        Array<U2<'V, option<obj>>>,
                                                        U2<ReadonlyArray<U2<'V, option<obj>>>, U2<'T, U2<Unstubify, 'T>>>
                                                     >
                                                 >
                                             >
                                         >
                                     >,
                                    U2<
                                        Set<
                                            U2<
                                                'V,
                                                U2<
                                                    option<obj>,
                                                    U2<
                                                        Set<U2<'V, option<obj>>>,
                                                        U2<
                                                            Array<U2<'V, option<obj>>>,
                                                            U2<
                                                                ReadonlyArray<U2<'V, option<obj>>>,
                                                                U2<'T, U2<Unstubify, 'T>>
                                                             >
                                                         >
                                                     >
                                                 >
                                             >
                                         >,
                                        U2<
                                            Array<U2<'V, option<obj>>>,
                                            U2<ReadonlyArray<U2<'V, option<obj>>>, U2<'T, U2<Unstubify, 'T>>>
                                         >
                                     >
                                 >
                             >,
                            U2<
                                'V,
                                U2<
                                    option<obj>,
                                    U2<
                                        Set<
                                            U2<
                                                'V,
                                                U2<
                                                    option<obj>,
                                                    U2<
                                                        Set<U2<'V, option<obj>>>,
                                                        U2<
                                                            Array<U2<'V, option<obj>>>,
                                                            U2<
                                                                ReadonlyArray<U2<'V, option<obj>>>,
                                                                U2<'T, U2<Unstubify, 'T>>
                                                             >
                                                         >
                                                     >
                                                 >
                                             >
                                         >,
                                        U2<
                                            Array<U2<'V, option<obj>>>,
                                            U2<ReadonlyArray<U2<'V, option<obj>>>, U2<'T, U2<Unstubify, 'T>>>
                                         >
                                     >
                                 >
                             >
                         >,
                        U2<
                            Set<
                                U2<
                                    'V,
                                    U2<
                                        option<obj>,
                                        U2<
                                            Set<U2<'V, option<obj>>>,
                                            U2<
                                                Array<U2<'V, option<obj>>>,
                                                U2<ReadonlyArray<U2<'V, option<obj>>>, U2<'T, U2<Unstubify, 'T>>>
                                             >
                                         >
                                     >
                                 >
                             >,
                            U2<
                                Array<U2<'V, option<obj>>>,
                                U2<ReadonlyArray<U2<'V, option<obj>>>, U2<'T, U2<Unstubify, 'T>>>
                             >
                         >
                     >
                 >

            [<Import("@cloudflare/workers-types.Rpc", "WorkerEntrypointBranded")>]
            type WorkerEntrypointBranded =
                [<CompiledName("[__WORKER_ENTRYPOINT_BRAND]")>]
                abstract ``[_wORKERENTRYPOINTBRAND]``: unit with get, set

            [<Import("@cloudflare/workers-types.Rpc", "StubBase")>]
            type StubBase<'T when 'T :> Stubable> =
                inherit Typescript.Disposable

                [<CompiledName("[__RPC_STUB_BRAND]")>]
                abstract ``[_rPCSTUBBRAND]``: 'T with get, set

                abstract dup: unit -> 'StubBase

            [<Import("@cloudflare/workers-types.Rpc", "UnstubifyAll")>]
            type UnstubifyAll<'A when 'A :> Array<option<obj>>> =
                [<CompiledName("[Symbol.unscopables]")>]
                abstract ``[symbol.unscopables]``: UnstubifyAll.``[Symbol.unscopables]`` with get

                abstract length: float with get, set
                abstract ``[symbol.iterator]``: unit -> ArrayIterator<'T>
                abstract ``with``: index: float * value: 'T -> Array
                abstract toSpliced: start: float * deleteCount: float * [<ParamArray>] items: Array -> Array
                abstract toSorted: ?compareFn: 'T -> 'T -> float -> Array
                abstract toReversed: unit -> Array
                abstract findLastIndex: predicate: UnstubifyAll.FindLastIndex.Predicate * ?thisArg: obj -> float
                abstract findLast: predicate: UnstubifyAll.FindLast.Predicate * ?thisArg: obj -> option<'S>
                abstract at: index: float -> option<'T>

                abstract flat:
                    this: 'A * ?depth: 'D ->
                        Array<proptypekey<UnstubifyAll.Flat, U2<UnstubifyAll.Flat, UnstubifyAll.Flat>>>

                abstract flatMap: callback: UnstubifyAll.FlatMap.Callback * ?thisArg: 'This -> Array<'U>
                abstract includes: searchElement: 'T * ?fromIndex: float -> bool
                abstract values: unit -> ArrayIterator<'T>
                abstract keys: unit -> ArrayIterator<float>
                abstract entries: unit -> ArrayIterator<float * 'T>
                abstract copyWithin: target: float * start: float * ?``end``: float -> 'Array
                abstract fill: value: 'T * ?start: float * ?``end``: float -> 'Array
                abstract findIndex: predicate: UnstubifyAll.FindIndex.Predicate * ?thisArg: obj -> float
                abstract find: predicate: UnstubifyAll.Find.Predicate * ?thisArg: obj -> option<'S>
                abstract reduceRight: callbackfn: UnstubifyAll.ReduceRight.Callbackfn -> 'T
                abstract reduce: callbackfn: UnstubifyAll.Reduce.Callbackfn -> 'T
                abstract filter: predicate: UnstubifyAll.Filter.Predicate * ?thisArg: obj -> Array<'S>
                abstract map: callbackfn: UnstubifyAll.Map.Callbackfn * ?thisArg: obj -> Array<'U>
                abstract forEach: callbackfn: UnstubifyAll.ForEach.Callbackfn * ?thisArg: obj -> unit
                abstract some: predicate: UnstubifyAll.Some.Predicate * ?thisArg: obj -> bool
                abstract every: predicate: UnstubifyAll.Every.Predicate * ?thisArg: obj -> bool
                abstract lastIndexOf: searchElement: 'T * ?fromIndex: float -> float
                abstract indexOf: searchElement: 'T * ?fromIndex: float -> float
                abstract unshift: [<ParamArray>] items: Array -> float
                abstract splice: start: float * ?deleteCount: float -> Array
                abstract sort: ?compareFn: 'T -> 'T -> float -> 'Array
                abstract slice: ?start: float * ?``end``: float -> Array
                abstract shift: unit -> option<'T>
                abstract reverse: unit -> Array
                abstract join: ?separator: D1SessionBookmark -> D1SessionBookmark
                abstract concat: [<ParamArray>] items: Array<ConcatArray<'T>> -> Array
                abstract push: [<ParamArray>] items: Array -> float
                abstract pop: unit -> option<'T>
                abstract toLocaleString: unit -> D1SessionBookmark
                abstract toString: unit -> D1SessionBookmark

            module StubBase =
                type T =
                    abstract Invoke: [<ParamArray>] args: Array<option<obj>> -> option<obj>

            module UnstubifyAll =
                type ``[Symbol.unscopables]`` =
                    [<CompiledName("__@unscopables@355")>]
                    abstract ``_@unscopables@355``: option<``[Symbol.unscopables]``.``_@unscopables@355``> with get, set

                    [<CompiledName("__@iterator@353")>]
                    abstract ``_@iterator@353``: option<``[Symbol.unscopables]``.``_@iterator@353``> with get, set

                    [<CompiledName("with")>]
                    abstract ``with``: option<``[Symbol.unscopables]``.With> with get, set

                    abstract toSpliced: option<``[Symbol.unscopables]``.ToSpliced> with get, set
                    abstract toSorted: option<``[Symbol.unscopables]``.ToSorted> with get, set
                    abstract toReversed: option<``[Symbol.unscopables]``.ToReversed> with get, set
                    abstract findLastIndex: option<``[Symbol.unscopables]``.FindLastIndex> with get, set
                    abstract findLast: option<``[Symbol.unscopables]``.FindLast> with get, set
                    abstract at: option<``[Symbol.unscopables]``.At> with get, set
                    abstract flat: option<``[Symbol.unscopables]``.Flat> with get, set
                    abstract flatMap: option<``[Symbol.unscopables]``.FlatMap> with get, set
                    abstract includes: option<``[Symbol.unscopables]``.Includes> with get, set
                    abstract values: option<``[Symbol.unscopables]``.Values> with get, set
                    abstract keys: option<``[Symbol.unscopables]``.Keys> with get, set
                    abstract entries: option<``[Symbol.unscopables]``.Entries> with get, set
                    abstract copyWithin: option<``[Symbol.unscopables]``.CopyWithin> with get, set
                    abstract fill: option<``[Symbol.unscopables]``.Fill> with get, set
                    abstract findIndex: option<``[Symbol.unscopables]``.FindIndex> with get, set
                    abstract find: option<``[Symbol.unscopables]``.Find> with get, set
                    abstract reduceRight: option<``[Symbol.unscopables]``.ReduceRight> with get, set
                    abstract reduce: option<``[Symbol.unscopables]``.Reduce> with get, set
                    abstract filter: option<``[Symbol.unscopables]``.Filter> with get, set
                    abstract map: option<``[Symbol.unscopables]``.Map> with get, set
                    abstract forEach: option<``[Symbol.unscopables]``.ForEach> with get, set
                    abstract some: option<``[Symbol.unscopables]``.Some> with get, set
                    abstract every: option<``[Symbol.unscopables]``.Every> with get, set
                    abstract lastIndexOf: option<``[Symbol.unscopables]``.LastIndexOf> with get, set
                    abstract indexOf: option<``[Symbol.unscopables]``.IndexOf> with get, set
                    abstract unshift: option<``[Symbol.unscopables]``.Unshift> with get, set
                    abstract splice: option<``[Symbol.unscopables]``.Splice> with get, set
                    abstract sort: option<``[Symbol.unscopables]``.Sort> with get, set
                    abstract slice: option<``[Symbol.unscopables]``.Slice> with get, set
                    abstract shift: option<``[Symbol.unscopables]``.Shift> with get, set
                    abstract reverse: option<``[Symbol.unscopables]``.Reverse> with get, set
                    abstract join: option<``[Symbol.unscopables]``.Join> with get, set
                    abstract concat: option<``[Symbol.unscopables]``.Concat> with get, set
                    abstract push: option<``[Symbol.unscopables]``.Push> with get, set
                    abstract pop: option<``[Symbol.unscopables]``.Pop> with get, set
                    abstract toLocaleString: option<``[Symbol.unscopables]``.ToLocaleString> with get, set
                    abstract toString: option<``[Symbol.unscopables]``.ToString> with get, set
                    abstract length: option<``[Symbol.unscopables]``.Length> with get, set

                module Every =
                    type Predicate =
                        abstract Invoke: value: 'T * index: float * array: Array -> bool

                module Find =
                    type Predicate =
                        abstract Invoke: value: 'T * index: float * obj: Array -> bool

                module FindIndex =
                    type Predicate =
                        abstract Invoke: value: 'T * index: float * obj: Array -> option<obj>

                module FlatMap =
                    type Callback =
                        abstract Invoke:
                            this: 'This * value: 'T * index: float * array: Array -> U2<'U, ReadonlyArray<'U>>

                module ForEach =
                    type Callbackfn =
                        abstract Invoke: value: 'T * index: float * array: Array -> unit

                module Map =
                    type Callbackfn =
                        abstract Invoke: value: 'T * index: float * array: Array -> 'U

                module Reduce =
                    type Callbackfn =
                        abstract Invoke: previousValue: 'T * currentValue: 'T * currentIndex: float * array: Array -> 'T

                module Some =
                    type Predicate =
                        abstract Invoke: value: 'T * index: float * array: Array -> option<obj>

        module SendEmail =
            module Send =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Builder =
                    | [<CompiledName("inline")>] Inline
                    | [<CompiledName("attachment")>] Attachment

        module Service =
            type T =
                abstract Create: [<ParamArray>] args: Array<option<obj>> -> Rpc.WorkerEntrypointBranded

        module ServiceWorkerGlobalScope =
            type CustomEvent =
                abstract prototype: CustomEvent<option<obj>> with get, set
                abstract Create: ``type``: D1SessionBookmark * ?eventInitDict: CustomEventInit<'T> -> CustomEvent<'T>

            type FetchEvent =
                abstract BUBBLING_PHASE: FetchEvent.BUBBLING_PHASE with get
                abstract AT_TARGET: FetchEvent.AT_TARGET with get
                abstract CAPTURING_PHASE: FetchEvent.CAPTURING_PHASE with get
                abstract NONE: FetchEvent.NONE with get
                abstract prototype: FetchEvent with get, set
                abstract Create: ``type``: D1SessionBookmark * ?eventInitDict: Typescript.EventInit -> FetchEvent

            type PromiseRejectionEvent =
                abstract prototype: PromiseRejectionEvent with get, set

                abstract Create:
                    ``type``: D1SessionBookmark * eventInitDict: PromiseRejectionEventInit -> PromiseRejectionEvent

            type ScheduledEvent =
                abstract BUBBLING_PHASE: ScheduledEvent.BUBBLING_PHASE with get
                abstract AT_TARGET: ScheduledEvent.AT_TARGET with get
                abstract CAPTURING_PHASE: ScheduledEvent.CAPTURING_PHASE with get
                abstract NONE: ScheduledEvent.NONE with get
                abstract prototype: ScheduledEvent with get, set
                abstract Create: ``type``: D1SessionBookmark * ?eventInitDict: Typescript.EventInit -> ScheduledEvent

            type ExtendableEvent =
                abstract BUBBLING_PHASE: ExtendableEvent.BUBBLING_PHASE with get
                abstract AT_TARGET: ExtendableEvent.AT_TARGET with get
                abstract CAPTURING_PHASE: ExtendableEvent.CAPTURING_PHASE with get
                abstract NONE: ExtendableEvent.NONE with get
                abstract prototype: ExtendableEvent with get, set
                abstract Create: ``type``: D1SessionBookmark * ?eventInitDict: Typescript.EventInit -> ExtendableEvent

            type MessageEvent =
                abstract prototype: MessageEvent<option<obj>> with get, set

                abstract Create:
                    ``type``: D1SessionBookmark * ?eventInitDict: Typescript.MessageEventInit<'T> -> MessageEvent<'T>

            type CloseEvent =
                abstract prototype: CloseEvent with get, set
                abstract Create: ``type``: D1SessionBookmark * ?eventInitDict: Typescript.CloseEventInit -> CloseEvent

            type DOMException =
                abstract DATA_CLONE_ERR: DOMException.DATA_CLONE_ERR with get
                abstract INVALID_NODE_TYPE_ERR: DOMException.INVALID_NODE_TYPE_ERR with get
                abstract TIMEOUT_ERR: DOMException.TIMEOUT_ERR with get
                abstract QUOTA_EXCEEDED_ERR: DOMException.QUOTA_EXCEEDED_ERR with get
                abstract URL_MISMATCH_ERR: DOMException.URL_MISMATCH_ERR with get
                abstract ABORT_ERR: DOMException.ABORT_ERR with get
                abstract NETWORK_ERR: DOMException.NETWORK_ERR with get
                abstract SECURITY_ERR: DOMException.SECURITY_ERR with get
                abstract TYPE_MISMATCH_ERR: DOMException.TYPE_MISMATCH_ERR with get
                abstract VALIDATION_ERR: DOMException.VALIDATION_ERR with get
                abstract INVALID_ACCESS_ERR: DOMException.INVALID_ACCESS_ERR with get
                abstract NAMESPACE_ERR: DOMException.NAMESPACE_ERR with get
                abstract INVALID_MODIFICATION_ERR: DOMException.INVALID_MODIFICATION_ERR with get
                abstract SYNTAX_ERR: DOMException.SYNTAX_ERR with get
                abstract INVALID_STATE_ERR: DOMException.INVALID_STATE_ERR with get
                abstract INUSE_ATTRIBUTE_ERR: DOMException.INUSE_ATTRIBUTE_ERR with get
                abstract NOT_SUPPORTED_ERR: DOMException.NOT_SUPPORTED_ERR with get
                abstract NOT_FOUND_ERR: DOMException.NOT_FOUND_ERR with get
                abstract NO_MODIFICATION_ALLOWED_ERR: DOMException.NO_MODIFICATION_ALLOWED_ERR with get
                abstract NO_DATA_ALLOWED_ERR: DOMException.NO_DATA_ALLOWED_ERR with get
                abstract INVALID_CHARACTER_ERR: DOMException.INVALID_CHARACTER_ERR with get
                abstract WRONG_DOCUMENT_ERR: DOMException.WRONG_DOCUMENT_ERR with get
                abstract HIERARCHY_REQUEST_ERR: DOMException.HIERARCHY_REQUEST_ERR with get
                abstract DOMSTRING_SIZE_ERR: DOMException.DOMSTRING_SIZE_ERR with get
                abstract INDEX_SIZE_ERR: DOMException.INDEX_SIZE_ERR with get
                abstract prototype: DOMException with get, set
                abstract Create: ?message: D1SessionBookmark * ?name: D1SessionBookmark -> DOMException

            type ReadableStreamDefaultReader =
                abstract prototype: ReadableStreamDefaultReader<option<obj>> with get, set
                abstract Create: stream: ReadableStream<'R> -> ReadableStreamDefaultReader<'R>

            type ReadableStreamBYOBReader =
                abstract prototype: ReadableStreamBYOBReader with get, set
                abstract Create: stream: ReadableStream<Uint8Array<ArrayBuffer>> -> ReadableStreamBYOBReader

            type ReadableStream =
                abstract prototype: ReadableStream<option<obj>> with get, set
                abstract highWaterMark: option<float> with get, set

                abstract Create:
                    ?underlyingSource: Typescript.UnderlyingSource<'R> * ?strategy: Typescript.QueuingStrategy<'R> ->
                        ReadableStream<'R>

                abstract Create:
                    underlyingSource: UnderlyingDefaultSource<'R> * ?strategy: Typescript.QueuingStrategy<'R> ->
                        ReadableStream<'R>

                abstract Create:
                    underlyingSource: Typescript.UnderlyingByteSource *
                    ?strategy: ReadableStream.ReadableStream.Strategy ->
                        ReadableStream<Uint8Array<ArrayBuffer>>

            type WritableStream =
                abstract prototype: WritableStream<option<obj>> with get, set

                abstract Create:
                    ?underlyingSink: Typescript.UnderlyingSink<'W> * ?strategy: Typescript.QueuingStrategy<'W> ->
                        WritableStream<'W>

            type WritableStreamDefaultWriter =
                abstract prototype: WritableStreamDefaultWriter<option<obj>> with get, set
                abstract Create: stream: WritableStream<'W> -> WritableStreamDefaultWriter<'W>

            type TransformStream =
                abstract prototype: TransformStream<option<obj>, option<obj>> with get, set

                abstract Create:
                    ?transformer: Typescript.Transformer<'I, 'O> *
                    ?writableStrategy: Typescript.QueuingStrategy<'I> *
                    ?readableStrategy: Typescript.QueuingStrategy<'O> ->
                        TransformStream<'I, 'O>

            type ByteLengthQueuingStrategy =
                abstract prototype: ByteLengthQueuingStrategy with get, set
                abstract Create: init: Typescript.QueuingStrategyInit -> ByteLengthQueuingStrategy

            type TailEvent =
                abstract BUBBLING_PHASE: TailEvent.BUBBLING_PHASE with get
                abstract AT_TARGET: TailEvent.AT_TARGET with get
                abstract CAPTURING_PHASE: TailEvent.CAPTURING_PHASE with get
                abstract NONE: TailEvent.NONE with get
                abstract prototype: TailEvent with get, set
                abstract Create: ``type``: D1SessionBookmark * ?eventInitDict: Typescript.EventInit -> TailEvent

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Event = | [<CompiledValue(0)>] ``0``

            type WorkerGlobalScope =
                abstract prototype: WorkerGlobalScope with get, set

            type CountQueuingStrategy =
                abstract prototype: CountQueuingStrategy with get, set
                abstract Create: init: Typescript.QueuingStrategyInit -> CountQueuingStrategy

            type ErrorEvent =
                abstract prototype: ErrorEvent with get, set
                abstract Create: ``type``: D1SessionBookmark * ?eventInitDict: ErrorEventInit -> ErrorEvent

            type Headers =
                abstract prototype: Headers with get, set

                abstract Create:
                    ?init: U3<Headers, Array<D1SessionBookmark * D1SessionBookmark>, Headers.Headers.Init> -> Headers

                abstract Item: key: D1SessionBookmark -> option<obj>

            type CompressionStream =
                abstract prototype: CompressionStream with get, set
                abstract Create: format: CompressionStream.CompressionStream.Format -> CompressionStream

            type WebSocketPair =
                [<CompiledName("1")>]
                abstract ``1``: Typescript.WebSocket with get, set

                [<CompiledName("0")>]
                abstract ``0``: Typescript.WebSocket with get, set

                abstract Create: unit -> WebSocketPair.WebSocketPair

            type WebSocketRequestResponsePair =
                abstract prototype: WebSocketRequestResponsePair with get, set

                abstract Create:
                    request: D1SessionBookmark * response: D1SessionBookmark -> WebSocketRequestResponsePair

            type AbortController =
                abstract prototype: AbortController with get, set
                abstract Create: unit -> AbortController

            type AbortSignal =
                abstract prototype: AbortSignal with get, set
                abstract timeout: milliseconds: float -> AbortSignal
                abstract any: signals: Array<AbortSignal> -> AbortSignal
                abstract abort: ?reason: obj -> AbortSignal
                abstract Create: unit -> AbortSignal

            type TextDecoder =
                abstract prototype: TextDecoder with get, set
                abstract Create: ?label: D1SessionBookmark * ?options: TextDecoderOptions -> TextDecoder

            type TextEncoder =
                abstract prototype: TextEncoder with get, set
                abstract Create: unit -> TextEncoder

            type URL =
                abstract prototype: URL with get, set
                abstract revokeObjectURL: url: D1SessionBookmark -> unit
                abstract parse: url: U2<URL, D1SessionBookmark> * ?``base``: U2<URL, D1SessionBookmark> -> option<URL>
                abstract createObjectURL: obj: U2<Blob, MediaSource> -> D1SessionBookmark
                abstract canParse: url: U2<URL, D1SessionBookmark> * ?``base``: U2<URL, D1SessionBookmark> -> bool
                abstract Create: url: U2<URL, D1SessionBookmark> * ?``base``: U2<URL, D1SessionBookmark> -> URL

            type URLSearchParams =
                abstract prototype: URLSearchParams with get, set

                abstract Create:
                    ?init:
                        U4<
                            Array<Array<D1SessionBookmark>>,
                            URLSearchParams.URLSearchParams.Init,
                            URLSearchParams,
                            D1SessionBookmark
                         > ->
                        URLSearchParams

            type URLPattern =
                abstract prototype: URLPattern with get, set

                abstract Create:
                    ?input: U2<URLPatternInit, D1SessionBookmark> *
                    ?baseURL: U2<URLPatternOptions, D1SessionBookmark> *
                    ?patternOptions: URLPatternOptions ->
                        URLPattern

            type Blob =
                abstract prototype: Blob with get, set

                abstract Create:
                    ?blobParts: Array<U4<Blob, ArrayBuffer, ArrayBufferView<ArrayBuffer>, D1SessionBookmark>> *
                    ?options: BlobPropertyBag ->
                        Blob

            type File =
                abstract prototype: File with get, set

                abstract Create:
                    fileBits: Array<U4<Blob, ArrayBuffer, ArrayBufferView<ArrayBuffer>, D1SessionBookmark>> *
                    fileName: D1SessionBookmark *
                    ?options: FilePropertyBag ->
                        File

            type FormData =
                abstract prototype: FormData with get, set
                abstract Create: ?form: HTMLFormElement * ?submitter: HTMLElement -> FormData

            type Crypto =
                abstract prototype: Crypto with get, set
                abstract Create: unit -> Crypto

            type EventSource =
                abstract CLOSED: EventSource.CLOSED with get
                abstract OPEN: EventSource.OPEN with get
                abstract CONNECTING: EventSource.CONNECTING with get
                abstract prototype: EventSource with get, set
                abstract Create: url: U2<URL, D1SessionBookmark> * ?eventSourceInitDict: EventSourceInit -> EventSource

            type CryptoKey =
                abstract prototype: CryptoKey with get, set
                abstract Create: unit -> CryptoKey

            type CacheStorage =
                abstract prototype: CacheStorage with get, set
                abstract Create: unit -> CacheStorage

            type Cache =
                abstract prototype: Cache with get, set
                abstract Create: unit -> Cache

            type FixedLengthStream =
                abstract prototype: FixedLengthStream with get, set

                abstract Create:
                    expectedLength: float * ?queuingStrategy: IdentityTransformStreamQueuingStrategy ->
                        FixedLengthStream

            type IdentityTransformStream =
                abstract prototype: IdentityTransformStream with get, set
                abstract Create: ?queuingStrategy: IdentityTransformStreamQueuingStrategy -> IdentityTransformStream

            type HTMLRewriter =
                abstract prototype: HTMLRewriter with get, set
                abstract Create: unit -> HTMLRewriter

            type WebSocket =
                abstract CLOSED: WebSocket.CLOSED with get
                abstract CLOSING: WebSocket.CLOSING with get
                abstract OPEN: WebSocket.OPEN with get
                abstract CONNECTING: WebSocket.CONNECTING with get
                abstract prototype: Typescript.WebSocket with get, set

                abstract Create:
                    url: U2<URL, D1SessionBookmark> * ?protocols: U2<Array<D1SessionBookmark>, D1SessionBookmark> ->
                        Typescript.WebSocket

            type Response =
                abstract prototype: Typescript.Response with get, set
                abstract redirect: url: U2<URL, D1SessionBookmark> * ?status: float -> Typescript.Response
                abstract json: ?data: obj * ?init: Typescript.ResponseInit -> Typescript.Response
                abstract error: unit -> Typescript.Response

                abstract Create:
                    ?body:
                        U7<
                            FormData,
                            Blob,
                            ArrayBuffer,
                            ReadableStream<option<obj>>,
                            ArrayBufferView<ArrayBuffer>,
                            URLSearchParams,
                            D1SessionBookmark
                         > *
                    ?init: Typescript.ResponseInit ->
                        Typescript.Response

            type SubtleCrypto =
                abstract prototype: SubtleCrypto with get, set
                abstract Create: unit -> SubtleCrypto

            type Body =
                abstract prototype: Typescript.Body with get, set
                abstract Create: unit -> Typescript.Body

            type Request =
                abstract prototype: Typescript.Request<option<obj>, U2<RequestInitCfProperties, Request.Prototype>> with get, set

                abstract Create:
                    input:
                        U3<
                            Typescript.Request<option<obj>, U2<RequestInitCfProperties, Request.Request.Input>>,
                            URL,
                            D1SessionBookmark
                         > *
                    ?init: Typescript.RequestInit<U2<RequestInitCfProperties, Request.Request.Init>> ->
                        Typescript.Request<option<obj>, U2<RequestInitCfProperties, Request.Request>>

            type DecompressionStream =
                abstract prototype: DecompressionStream with get, set
                abstract Create: format: DecompressionStream.DecompressionStream.Format -> DecompressionStream

            type TextEncoderStream =
                abstract prototype: TextEncoderStream with get, set
                abstract Create: unit -> TextEncoderStream

            type TextDecoderStream =
                abstract prototype: TextDecoderStream with get, set
                abstract Create: ?label: D1SessionBookmark * ?options: TextDecoderOptions -> TextDecoderStream

            module SetTimeout =
                type Callback =
                    abstract Invoke: [<ParamArray>] args: 'Args -> unit
                    abstract Invoke: [<ParamArray>] args: Array<option<obj>> -> unit

        module Socket =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type SecureTransport =
                | [<CompiledName("on")>] On
                | [<CompiledName("off")>] Off
                | [<CompiledName("starttls")>] Starttls

        module SqlStorage =
            type Statement =
                abstract prototype: SqlStorageStatement with get, set
                abstract Create: unit -> SqlStorageStatement

            type Cursor =
                abstract prototype: SqlStorageCursor<option<obj>> with get, set
                abstract Create: unit -> SqlStorageCursor

        module SqlStorageCursor =
            type Next =
                abstract value: 'T with get, set

                [<CompiledName("done")>]
                abstract ``done``: option<Next.Done> with get, set

                abstract value: option<unit> with get, set

                [<CompiledName("done")>]
                abstract ``done``: Next.Done with get, set

            type T =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module StreamBinding =
            type CreateDirectUpload =
                abstract scheduledDeletion: option<D1SessionBookmark> with get, set
                abstract watermark: option<StreamWatermark> with get, set
                abstract id: D1SessionBookmark with get, set
                abstract uploadURL: D1SessionBookmark with get, set

            module CreateDirectUpload =
                type Params =
                    abstract watermark: option<StreamDirectUploadWatermark> with get, set
                    abstract scheduledDeletion: option<D1SessionBookmark> with get, set
                    abstract thumbnailTimestampPct: option<float> with get, set
                    abstract requireSignedURLs: option<bool> with get, set
                    abstract allowedOrigins: option<Array<D1SessionBookmark>> with get, set
                    abstract meta: option<Params.Meta> with get, set
                    abstract creator: option<D1SessionBookmark> with get, set
                    abstract expiry: option<D1SessionBookmark> with get, set
                    abstract maxDurationSeconds: float with get, set
                    abstract id: D1SessionBookmark with get, set

            module Upload =
                type Params =
                    abstract watermarkId: option<D1SessionBookmark> with get, set
                    abstract thumbnailTimestampPct: option<float> with get, set
                    abstract scheduledDeletion: option<D1SessionBookmark> with get, set
                    abstract requireSignedURLs: option<bool> with get, set
                    abstract meta: option<Params.Meta> with get, set
                    abstract creator: option<D1SessionBookmark> with get, set
                    abstract allowedOrigins: option<Array<D1SessionBookmark>> with get, set

        module StreamCaption =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Status =
                | [<CompiledName("ready")>] Ready
                | [<CompiledName("inprogress")>] Inprogress
                | [<CompiledName("error")>] Error

        module StreamDirectUploadCreateParams =
            type Watermark =
                abstract id: D1SessionBookmark with get, set

        module StreamDownload =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Status =
                | [<CompiledName("error")>] Error
                | [<CompiledName("ready")>] Ready
                | [<CompiledName("inprogress")>] Inprogress

        module StreamDownloadGetResponse =
            type Audio =
                abstract url: option<D1SessionBookmark> with get, set
                abstract status: Audio.Status with get, set
                abstract percentComplete: float with get, set

        module StreamScopedCaptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Upload =
                | [<CompiledName("ready")>] Ready
                | [<CompiledName("inprogress")>] Inprogress
                | [<CompiledName("error")>] Error

        module StreamScopedDownloads =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Generate =
                | [<CompiledName("error")>] Error
                | [<CompiledName("ready")>] Ready
                | [<CompiledName("inprogress")>] Inprogress

            module Generate =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type DownloadType =
                    | [<CompiledName("default")>] Default
                    | [<CompiledName("audio")>] Audio

        module StreamUpdateVideoParams =
            type Meta =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module StreamVideo =
            type Input =
                abstract height: float with get, set
                abstract width: float with get, set

            type PublicDetails =
                abstract logo: option<D1SessionBookmark> with get, set

                [<CompiledName("channel_link")>]
                abstract channelLink: option<D1SessionBookmark> with get, set

                [<CompiledName("share_link")>]
                abstract shareLink: option<D1SessionBookmark> with get, set

                abstract title: option<D1SessionBookmark> with get, set

            type Watermark =
                abstract position: StreamWatermarkPosition with get, set
                abstract scale: float with get, set
                abstract padding: float with get, set
                abstract opacity: float with get, set
                abstract name: D1SessionBookmark with get, set
                abstract downloadedFrom: option<D1SessionBookmark> with get, set
                abstract created: D1SessionBookmark with get, set
                abstract width: float with get, set
                abstract height: float with get, set
                abstract size: float with get, set
                abstract id: D1SessionBookmark with get, set

            type Status =
                abstract errorReasonText: D1SessionBookmark with get, set
                abstract errorReasonCode: D1SessionBookmark with get, set
                abstract pctComplete: option<D1SessionBookmark> with get, set
                abstract step: option<D1SessionBookmark> with get, set
                abstract state: D1SessionBookmark with get, set

        module StreamVideoHandle =
            module Update =
                type Params =
                    abstract thumbnailTimestampPct: option<float> with get, set
                    abstract scheduledDeletion: option<D1SessionBookmark> with get, set
                    abstract requireSignedURLs: option<bool> with get, set
                    abstract meta: option<Params.Meta> with get, set
                    abstract maxDurationSeconds: option<float> with get, set
                    abstract creator: option<D1SessionBookmark> with get, set
                    abstract allowedOrigins: option<Array<D1SessionBookmark>> with get, set

        module StreamVideos =
            module List =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Params =
                    | [<CompiledName("eq")>] Eq
                    | [<CompiledName("gt")>] Gt
                    | [<CompiledName("gte")>] Gte
                    | [<CompiledName("lt")>] Lt
                    | [<CompiledName("lte")>] Lte

        module StreamVideosListParams =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type BeforeComp =
                | [<CompiledName("eq")>] Eq
                | [<CompiledName("gt")>] Gt
                | [<CompiledName("gte")>] Gte
                | [<CompiledName("lt")>] Lt
                | [<CompiledName("lte")>] Lte

        module StreamWatermark =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Position =
                | [<CompiledName("upperRight")>] UpperRight
                | [<CompiledName("upperLeft")>] UpperLeft
                | [<CompiledName("lowerLeft")>] LowerLeft
                | [<CompiledName("lowerRight")>] LowerRight
                | [<CompiledName("center")>] Center

        module StreamWatermarkCreateParams =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Position =
                | [<CompiledName("upperRight")>] UpperRight
                | [<CompiledName("upperLeft")>] UpperLeft
                | [<CompiledName("lowerLeft")>] LowerLeft
                | [<CompiledName("lowerRight")>] LowerRight
                | [<CompiledName("center")>] Center

        module StreamWatermarks =
            type Generate =
                abstract position: StreamWatermarkPosition with get, set
                abstract scale: float with get, set
                abstract padding: float with get, set
                abstract opacity: float with get, set
                abstract name: D1SessionBookmark with get, set
                abstract downloadedFrom: option<D1SessionBookmark> with get, set
                abstract created: D1SessionBookmark with get, set
                abstract width: float with get, set
                abstract height: float with get, set
                abstract size: float with get, set
                abstract id: D1SessionBookmark with get, set

            module Generate =
                type Params =
                    abstract position: option<StreamWatermarkPosition> with get, set
                    abstract scale: option<float> with get, set
                    abstract padding: option<float> with get, set
                    abstract opacity: option<float> with get, set
                    abstract name: option<D1SessionBookmark> with get, set

        module SystemMessage =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Role = | [<CompiledName("system")>] System

        module TailStream =
            [<Import("@cloudflare/workers-types.TailStream", "StreamDiagnostic")>]
            type StreamDiagnostic =
                abstract diagnostic: DroppedEventsDiagnostic with get

                [<CompiledName("type")>]
                abstract ``type``: StreamDiagnostic.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "FetchResponseInfo")>]
            type FetchResponseInfo =
                abstract statusCode: float with get

                [<CompiledName("type")>]
                abstract ``type``: FetchResponseInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "Exception")>]
            type Exception =
                abstract stack: option<D1SessionBookmark> with get
                abstract message: D1SessionBookmark with get
                abstract name: D1SessionBookmark with get

                [<CompiledName("type")>]
                abstract ``type``: Exception.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "TailEventHandler")>]
            type TailEventHandler<'Event when 'Event :> EventType> =
                abstract Invoke: event: TailEvent<'Event> -> option<Promise<unit>>

            [<Import("@cloudflare/workers-types.TailStream", "QueueEventInfo")>]
            type QueueEventInfo =
                abstract batchSize: float with get
                abstract queueName: D1SessionBookmark with get

                [<CompiledName("type")>]
                abstract ``type``: QueueEventInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "HibernatableWebSocketEventInfoMessage")>]
            type HibernatableWebSocketEventInfoMessage =
                [<CompiledName("type")>]
                abstract ``type``: HibernatableWebSocketEventInfoMessage.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "DiagnosticChannelEvent")>]
            type DiagnosticChannelEvent =
                abstract message: option<obj> with get
                abstract channel: D1SessionBookmark with get

                [<CompiledName("type")>]
                abstract ``type``: DiagnosticChannelEvent.Type with get

            type TailEventHandlerType =
                abstract attributes: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

                [<CompiledName("return")>]
                abstract ``return``: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

                abstract log: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

                [<CompiledName("exception")>]
                abstract ``exception``: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

                abstract diagnosticChannel: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract spanClose: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract spanOpen: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract outcome: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

            [<Import("@cloudflare/workers-types.TailStream", "Onset")>]
            type Onset =
                abstract info:
                    U10<
                        FetchEventInfo,
                        ConnectEventInfo,
                        JsRpcEventInfo,
                        ScheduledEventInfo,
                        AlarmEventInfo,
                        QueueEventInfo,
                        EmailEventInfo,
                        TraceEventInfo,
                        HibernatableWebSocketEventInfo,
                        CustomEventInfo
                     > with get

                abstract preview: option<TracePreviewInfo> with get
                abstract scriptVersion: option<ScriptVersion> with get
                abstract scriptTags: option<Array<D1SessionBookmark>> with get
                abstract scriptName: option<D1SessionBookmark> with get
                abstract executionModel: D1SessionBookmark with get
                abstract entrypoint: option<D1SessionBookmark> with get
                abstract dispatchNamespace: option<D1SessionBookmark> with get
                abstract spanId: D1SessionBookmark with get
                abstract attributes: Array<Attribute> with get

                [<CompiledName("type")>]
                abstract ``type``: Onset.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "TailEvent")>]
            type TailEvent<'Event when 'Event :> EventType> =
                abstract event: 'Event with get
                abstract sequence: float with get
                abstract timestamp: Date with get
                abstract spanContext: SpanContext with get
                abstract invocationId: D1SessionBookmark with get

            [<Import("@cloudflare/workers-types.TailStream", "FetchEventInfo")>]
            type FetchEventInfo =
                abstract headers: Array<Header> with get
                abstract cfJson: option<obj> with get
                abstract url: D1SessionBookmark with get
                abstract method: D1SessionBookmark with get

                [<CompiledName("type")>]
                abstract ``type``: FetchEventInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "TailEventHandlerObject")>]
            type TailEventHandlerObject =
                abstract attributes: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

                [<CompiledName("return")>]
                abstract ``return``: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

                abstract log: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

                [<CompiledName("exception")>]
                abstract ``exception``: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

                abstract diagnosticChannel: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract spanClose: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract spanOpen: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract outcome: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

            [<Import("@cloudflare/workers-types.TailStream", "ScriptVersion")>]
            type ScriptVersion =
                abstract message: option<D1SessionBookmark> with get
                abstract tag: option<D1SessionBookmark> with get
                abstract id: D1SessionBookmark with get

            [<Import("@cloudflare/workers-types.TailStream", "ConnectEventInfo")>]
            type ConnectEventInfo =
                [<CompiledName("type")>]
                abstract ``type``: ConnectEventInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "Attributes")>]
            type Attributes =
                abstract info: Array<Attribute> with get

                [<CompiledName("type")>]
                abstract ``type``: Attributes.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "SpanContext")>]
            type SpanContext =
                abstract spanId: option<D1SessionBookmark> with get
                abstract traceId: D1SessionBookmark with get

            [<Import("@cloudflare/workers-types.TailStream", "DroppedEventsDiagnostic")>]
            type DroppedEventsDiagnostic =
                abstract count: float with get
                abstract diagnosticsType: DroppedEventsDiagnostic.DiagnosticsType with get

            [<Import("@cloudflare/workers-types.TailStream", "TraceEventInfo")>]
            type TraceEventInfo =
                abstract traces: Array<option<D1SessionBookmark>> with get

                [<CompiledName("type")>]
                abstract ``type``: TraceEventInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "HibernatableWebSocketEventInfoError")>]
            type HibernatableWebSocketEventInfoError =
                [<CompiledName("type")>]
                abstract ``type``: HibernatableWebSocketEventInfoError.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "AlarmEventInfo")>]
            type AlarmEventInfo =
                abstract scheduledTime: Date with get

                [<CompiledName("type")>]
                abstract ``type``: AlarmEventInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "EmailEventInfo")>]
            type EmailEventInfo =
                abstract rawSize: float with get
                abstract rcptTo: D1SessionBookmark with get
                abstract mailFrom: D1SessionBookmark with get

                [<CompiledName("type")>]
                abstract ``type``: EmailEventInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "CustomEventInfo")>]
            type CustomEventInfo =
                [<CompiledName("type")>]
                abstract ``type``: CustomEventInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "Log")>]
            type Log =
                abstract message: obj with get
                abstract level: Log.Level with get

                [<CompiledName("type")>]
                abstract ``type``: Log.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "Return")>]
            type Return =
                abstract info: option<FetchResponseInfo> with get

                [<CompiledName("type")>]
                abstract ``type``: Return.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "SpanOpen")>]
            type SpanOpen =
                abstract info: option<U3<FetchEventInfo, JsRpcEventInfo, Attributes>> with get
                abstract spanId: D1SessionBookmark with get
                abstract name: D1SessionBookmark with get

                [<CompiledName("type")>]
                abstract ``type``: SpanOpen.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "Outcome")>]
            type Outcome =
                abstract wallTime: float with get
                abstract cpuTime: float with get
                abstract outcome: Outcome.Outcome with get

                [<CompiledName("type")>]
                abstract ``type``: Outcome.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "HibernatableWebSocketEventInfoClose")>]
            type HibernatableWebSocketEventInfoClose =
                abstract wasClean: bool with get
                abstract code: float with get

                [<CompiledName("type")>]
                abstract ``type``: HibernatableWebSocketEventInfoClose.Type with get

            type EventType =
                U10<
                    Onset,
                    Outcome,
                    SpanOpen,
                    SpanClose,
                    DiagnosticChannelEvent,
                    Exception,
                    Log,
                    StreamDiagnostic,
                    Return,
                    Attributes
                 >

            [<Import("@cloudflare/workers-types.TailStream", "SpanClose")>]
            type SpanClose =
                abstract outcome: SpanClose.Outcome with get

                [<CompiledName("type")>]
                abstract ``type``: SpanClose.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "TracePreviewInfo")>]
            type TracePreviewInfo =
                abstract name: D1SessionBookmark with get
                abstract slug: D1SessionBookmark with get
                abstract id: D1SessionBookmark with get

            [<Import("@cloudflare/workers-types.TailStream", "Attribute")>]
            type Attribute =
                abstract value:
                    U6<Array<D1SessionBookmark>, Array<bool>, AiSentenceSimilarityOutput, D1SessionBookmark, bool, float> with get

                abstract name: D1SessionBookmark with get

            [<Import("@cloudflare/workers-types.TailStream", "HibernatableWebSocketEventInfo")>]
            type HibernatableWebSocketEventInfo =
                abstract info:
                    U3<
                        HibernatableWebSocketEventInfoClose,
                        HibernatableWebSocketEventInfoError,
                        HibernatableWebSocketEventInfoMessage
                     > with get

                [<CompiledName("type")>]
                abstract ``type``: HibernatableWebSocketEventInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "JsRpcEventInfo")>]
            type JsRpcEventInfo =
                [<CompiledName("type")>]
                abstract ``type``: JsRpcEventInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "ScheduledEventInfo")>]
            type ScheduledEventInfo =
                abstract cron: D1SessionBookmark with get
                abstract scheduledTime: Date with get

                [<CompiledName("type")>]
                abstract ``type``: ScheduledEventInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "Header")>]
            type Header =
                abstract value: D1SessionBookmark with get
                abstract name: D1SessionBookmark with get

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type EventOutcome =
                | [<CompiledName("ok")>] Ok
                | [<CompiledName("canceled")>] Canceled
                | [<CompiledName("exception")>] Exception
                | [<CompiledName("unknown")>] Unknown
                | [<CompiledName("killSwitch")>] KillSwitch
                | [<CompiledName("daemonDown")>] DaemonDown
                | [<CompiledName("exceededCpu")>] ExceededCpu
                | [<CompiledName("exceededMemory")>] ExceededMemory
                | [<CompiledName("loadShed")>] LoadShed
                | [<CompiledName("responseStreamDisconnected")>] ResponseStreamDisconnected
                | [<CompiledName("scriptNotFound")>] ScriptNotFound
                | [<CompiledName("internalError")>] InternalError

            module AlarmEventInfo =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("alarm")>] Alarm

            module Attributes =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("attributes")>] Attributes

            module ConnectEventInfo =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("connect")>] Connect

            module CustomEventInfo =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("custom")>] Custom

            module DiagnosticChannelEvent =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("diagnosticChannel")>] DiagnosticChannel

            module DroppedEventsDiagnostic =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type DiagnosticsType = | [<CompiledName("droppedEvents")>] DroppedEvents

            module EmailEventInfo =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("email")>] Email

            module Exception =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("exception")>] Exception

            module FetchEventInfo =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("fetch")>] Fetch

            module FetchResponseInfo =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("fetch")>] Fetch

            module HibernatableWebSocketEventInfo =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("hibernatableWebSocket")>] HibernatableWebSocket

            module HibernatableWebSocketEventInfoClose =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("close")>] Close

            module HibernatableWebSocketEventInfoError =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("error")>] Error

            module HibernatableWebSocketEventInfoMessage =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("message")>] Message

            module JsRpcEventInfo =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("jsrpc")>] Jsrpc

            module Log =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("log")>] Log

                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Level =
                    | [<CompiledName("debug")>] Debug
                    | [<CompiledName("error")>] Error
                    | [<CompiledName("info")>] Info
                    | [<CompiledName("log")>] Log
                    | [<CompiledName("warn")>] Warn

            module Onset =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("onset")>] Onset

            module Outcome =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Outcome =
                    | [<CompiledName("unknown")>] Unknown
                    | [<CompiledName("exception")>] Exception
                    | [<CompiledName("ok")>] Ok
                    | [<CompiledName("canceled")>] Canceled
                    | [<CompiledName("killSwitch")>] KillSwitch
                    | [<CompiledName("daemonDown")>] DaemonDown
                    | [<CompiledName("exceededCpu")>] ExceededCpu
                    | [<CompiledName("exceededMemory")>] ExceededMemory
                    | [<CompiledName("loadShed")>] LoadShed
                    | [<CompiledName("responseStreamDisconnected")>] ResponseStreamDisconnected
                    | [<CompiledName("scriptNotFound")>] ScriptNotFound
                    | [<CompiledName("internalError")>] InternalError

                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("outcome")>] Outcome

            module QueueEventInfo =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("queue")>] Queue

            module Return =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("return")>] Return

            module ScheduledEventInfo =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("scheduled")>] Scheduled

            module SpanClose =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Outcome =
                    | [<CompiledName("unknown")>] Unknown
                    | [<CompiledName("exception")>] Exception
                    | [<CompiledName("ok")>] Ok
                    | [<CompiledName("canceled")>] Canceled
                    | [<CompiledName("killSwitch")>] KillSwitch
                    | [<CompiledName("daemonDown")>] DaemonDown
                    | [<CompiledName("exceededCpu")>] ExceededCpu
                    | [<CompiledName("exceededMemory")>] ExceededMemory
                    | [<CompiledName("loadShed")>] LoadShed
                    | [<CompiledName("responseStreamDisconnected")>] ResponseStreamDisconnected
                    | [<CompiledName("scriptNotFound")>] ScriptNotFound
                    | [<CompiledName("internalError")>] InternalError

                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("spanClose")>] SpanClose

            module SpanOpen =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("spanOpen")>] SpanOpen

            module StreamDiagnostic =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("streamDiagnostic")>] StreamDiagnostic

            module TraceEventInfo =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Type = | [<CompiledName("trace")>] Trace

        module ToMarkdownService =
            type Supported =
                abstract extension: D1SessionBookmark with get, set
                abstract mimeType: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Transform =
                | [<CompiledName("error")>] Error
                | [<CompiledName("markdown")>] Markdown

            module Transform =
                type Options =
                    abstract cssSelector: option<D1SessionBookmark> with get, set
                    abstract hostname: option<D1SessionBookmark> with get, set
                    abstract images: option<Options.Images> with get, set
                    abstract pdf: option<Options.Pdf> with get, set
                    abstract image: option<ImageConversionOptions> with get, set
                    abstract docx: option<Options.Docx> with get, set
                    abstract html: option<Options.Html> with get, set
                    abstract backoff: option<CloudflareWorkersModule.WorkflowBackoff> with get, set
                    abstract retryDelayMs: option<float> with get, set
                    abstract maxAttempts: option<Options.MaxAttempts> with get, set
                    abstract convertOGImage: option<bool> with get, set
                    abstract maxConvertedImages: option<float> with get, set
                    abstract convert: option<bool> with get, set
                    abstract descriptionLanguage: option<Options.DescriptionLanguage> with get, set
                    abstract retries: option<GatewayRetries> with get, set
                    abstract requestTimeoutMs: option<float> with get, set
                    abstract eventId: option<D1SessionBookmark> with get, set
                    abstract collectLog: option<bool> with get, set
                    abstract metadata: option<Options.Metadata> with get, set
                    abstract skipCache: option<bool> with get, set
                    abstract cacheTtl: option<float> with get, set
                    abstract cacheKey: option<D1SessionBookmark> with get, set
                    abstract id: D1SessionBookmark with get, set
                    abstract conversionOptions: option<ConversionOptions> with get, set
                    abstract extraHeaders: option<obj> with get, set
                    abstract gateway: option<GatewayOptions> with get, set
                    abstract metadata: option<bool> with get, set
                    abstract images: option<EmbeddedImageConversionOptions> with get, set
                    abstract Item: key: D1SessionBookmark -> option<obj>

                type Files =
                    abstract blob: Blob with get, set
                    abstract name: D1SessionBookmark with get, set

        module TooManyWatermarksError =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Name = | TooManyWatermarksError

        module Tool =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("function")>] Function

        module ToolChoiceFunction =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("function")>] Function

        module ToolMessage =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Role = | [<CompiledName("tool")>] Tool

        module TraceItem =
            type TailAttributes =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module Tracing =
            type Span =
                abstract prototype: Span with get, set
                abstract Create: unit -> Span

            module EnterSpan =
                type Callback =
                    abstract Invoke: span: Span * [<ParamArray>] args: 'A -> 'T

        module URLSearchParams =
            type Init =
                abstract Item: key: D1SessionBookmark -> option<obj>

            module ForEach =
                type Callback =
                    abstract Invoke:
                        this: 'This * value: D1SessionBookmark * key: D1SessionBookmark * parent: URLSearchParams ->
                            unit

        module UniversalGatewayOptions =
            type Retries =
                abstract backoff: option<CloudflareWorkersModule.WorkflowBackoff> with get, set
                abstract retryDelayMs: option<float> with get, set
                abstract maxAttempts: option<Retries.MaxAttempts> with get, set

        module UserMessage =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Role = | [<CompiledName("user")>] User

        module UserMessageContentPart =
            type InputAudio =
                abstract format: option<InputAudio.Format> with get, set
                abstract data: option<D1SessionBookmark> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ImageUrl =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("low")>] Low
                | [<CompiledName("high")>] High

            type File =
                abstract filename: option<D1SessionBookmark> with get, set

                [<CompiledName("file_id")>]
                abstract fileId: option<D1SessionBookmark> with get, set

                [<CompiledName("file_data")>]
                abstract fileData: option<D1SessionBookmark> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("text")>] Text
                | [<CompiledName("image_url")>] ImageUrl
                | [<CompiledName("input_audio")>] InputAudio
                | [<CompiledName("file")>] File

        module VectorizeIndexDetails =
            type Config =
                abstract metric: VectorizeDistanceMetric with get, set
                abstract dimensions: float with get, set
                abstract preset: D1SessionBookmark with get, set

        module VectorizeMatches =
            type Matches =
                abstract score: float with get, set
                abstract metadata: option<Matches.Metadata> with get, set

                [<CompiledName("namespace")>]
                abstract ``namespace``: option<D1SessionBookmark> with get, set

                abstract id: D1SessionBookmark with get, set

                abstract values:
                    option<U3<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>, AiSentenceSimilarityOutput>> with get, set

                abstract Item: key: D1SessionBookmark -> option<obj>

        module VectorizeQueryOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Filter =
                | [<CompiledValue(false)>] False
                | [<CompiledValue(true)>] True

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ReturnMetadata =
                | [<CompiledName("all")>] All
                | [<CompiledName("indexed")>] Indexed
                | [<CompiledName("none")>] None

        module VectorizeVector =
            type Metadata =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module WebAssembly =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ValueType =
                | [<CompiledName("anyfunc")>] Anyfunc
                | [<CompiledName("externref")>] Externref
                | [<CompiledName("f32")>] F32
                | [<CompiledName("f64")>] F64
                | [<CompiledName("i32")>] I32
                | [<CompiledName("i64")>] I64
                | [<CompiledName("v128")>] V128

            type Instantiate =
                abstract Item: key: D1SessionBookmark -> option<obj>

                abstract Invoke:
                    ``module``: WebAssembly.Module * ?imports: Instantiate.Instantiate.Imports ->
                        Promise<WebAssembly.Instance>

                abstract Invoke:
                    moduleObject: WebAssembly.Module * ?importObject: Instantiate.Instantiate.ImportObject ->
                        Promise<WebAssembly.Instance>

                abstract Invoke:
                    bytes: U2<ArrayBuffer, ArrayBufferView<ArrayBuffer>> *
                    ?importObject: Instantiate.Instantiate.ImportObject ->
                        Promise<WebAssembly.WebAssemblyInstantiatedSource>

            [<Import("@cloudflare/workers-types.WebAssembly", "Global")>]
            type Global =
                [<EmitConstructor>]
                abstract Create: descriptor: Typescript.WebAssembly.GlobalDescriptor<ValueType> * ?value: obj -> Global

                abstract value: option<obj> with get, set
                abstract valueOf: unit -> option<obj>

            [<Import("@cloudflare/workers-types.WebAssembly", "Module")>]
            type Module =
                abstract imports: ``module``: WebAssembly.Module -> Array<Typescript.WebAssembly.ModuleImportDescriptor>
                abstract exports: ``module``: WebAssembly.Module -> Array<Typescript.WebAssembly.ModuleExportDescriptor>

                abstract customSections:
                    ``module``: WebAssembly.Module * sectionName: D1SessionBookmark -> Array<ArrayBuffer>

            type Imports = Imports

            type Validate =
                abstract Invoke: bytes: U2<ArrayBuffer, ArrayBufferView<ArrayBuffer>> -> bool
                abstract Invoke: bytes: U2<ArrayBuffer, ArrayBufferView<ArrayBuffer>> -> bool

            type Exports = Exports

            [<Import("@cloudflare/workers-types.WebAssembly", "Instance")>]
            type Instance =
                [<EmitConstructor>]
                abstract Create: ``module``: WebAssembly.Module * ?imports: Instance.Imports -> Instance

                abstract exports: Instance.Exports with get

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ImportExportKind =
                | [<CompiledName("function")>] Function
                | [<CompiledName("global")>] Global
                | [<CompiledName("memory")>] Memory
                | [<CompiledName("table")>] Table

            type ModuleImports = ModuleImports

            [<Import("@cloudflare/workers-types.WebAssembly", "Memory")>]
            type Memory =
                [<EmitConstructor>]
                abstract Create: descriptor: Typescript.WebAssembly.MemoryDescriptor -> Memory

                abstract buffer: ArrayBuffer with get
                abstract grow: delta: float -> float

            [<Import("@cloudflare/workers-types.WebAssembly", "RuntimeError")>]
            type RuntimeError =
                interface
                    [<EmitConstructor>]
                    abstract Create: ?message: D1SessionBookmark -> RuntimeError

                    inherit Error
                end

            [<Import("@cloudflare/workers-types.WebAssembly", "CompileError")>]
            type CompileError =
                interface
                    [<EmitConstructor>]
                    abstract Create: ?message: D1SessionBookmark -> CompileError

                    inherit Error
                end

            [<Import("@cloudflare/workers-types.WebAssembly", "Table")>]
            type Table =
                [<EmitConstructor>]
                abstract Create: descriptor: Typescript.WebAssembly.TableDescriptor * ?value: obj -> Table

                abstract length: float with get
                abstract set: index: float * ?value: obj -> unit
                abstract grow: delta: float * ?value: obj -> float
                abstract get: index: float -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type TableKind =
                | [<CompiledName("anyfunc")>] Anyfunc
                | [<CompiledName("externref")>] Externref

            type ImportValue = U5<Function, WebAssembly.Table, WebAssembly.Memory, WebAssembly.Global<ValueType>, float>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ExportValue =
                | [<CompiledName("f32")>] F32
                | [<CompiledName("anyfunc")>] Anyfunc
                | [<CompiledName("externref")>] Externref
                | [<CompiledName("f64")>] F64
                | [<CompiledName("i32")>] I32
                | [<CompiledName("i64")>] I64
                | [<CompiledName("v128")>] V128

            module Global =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Descriptor =
                    | [<CompiledName("f32")>] F32
                    | [<CompiledName("anyfunc")>] Anyfunc
                    | [<CompiledName("externref")>] Externref
                    | [<CompiledName("f64")>] F64
                    | [<CompiledName("i32")>] I32
                    | [<CompiledName("i64")>] I64
                    | [<CompiledName("v128")>] V128

            module Instance =
                type Exports =
                    abstract Item: key: D1SessionBookmark -> option<obj>

                type Imports =
                    abstract Item: key: D1SessionBookmark -> option<obj>

        module WebSearchOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type SearchContextSize =
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium")>] Medium
                | [<CompiledName("high")>] High

            type UserLocation =
                abstract timezone: option<D1SessionBookmark> with get, set
                abstract region: option<D1SessionBookmark> with get, set
                abstract country: option<D1SessionBookmark> with get, set
                abstract city: option<D1SessionBookmark> with get, set
                abstract approximate: UserLocation.Approximate with get, set

                [<CompiledName("type")>]
                abstract ``type``: UserLocation.Type with get, set

        module WebSearchUserLocation =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type = | [<CompiledName("approximate")>] Approximate

            type Approximate =
                abstract timezone: option<D1SessionBookmark> with get, set
                abstract region: option<D1SessionBookmark> with get, set
                abstract country: option<D1SessionBookmark> with get, set
                abstract city: option<D1SessionBookmark> with get, set

        module WorkerGlobalScope =
            type EventTarget =
                abstract prototype: EventTarget with get, set
                abstract Create: unit -> EventTarget

        module WorkerLoaderWorkerCode =
            type Modules =
                abstract Item: key: D1SessionBookmark -> option<obj>

            type GlobalOutbound =
                abstract connect: address: U2<SocketAddress, D1SessionBookmark> * ?options: SocketOptions -> Socket

                abstract fetch:
                    input:
                        U3<
                            Typescript.Request<option<obj>, U2<RequestInitCfProperties, GlobalOutbound.Fetch.Input>>,
                            URL,
                            D1SessionBookmark
                         > *
                    ?init: Typescript.RequestInit<U2<RequestInitCfProperties, GlobalOutbound.Fetch.Init>> ->
                        Promise<Typescript.Response>

        module WorkerStub =
            type GetEntrypoint =
                abstract connect: address: U2<SocketAddress, D1SessionBookmark> * ?options: SocketOptions -> Socket

                abstract fetch:
                    input:
                        U3<
                            Typescript.Request<option<obj>, U2<RequestInitCfProperties, GetEntrypoint.Fetch.Input>>,
                            URL,
                            D1SessionBookmark
                         > *
                    ?init: Typescript.RequestInit<U2<RequestInitCfProperties, GetEntrypoint.Fetch.Init>> ->
                        Promise<Typescript.Response>

                abstract Item: key: D1SessionBookmark -> option<obj>

                abstract catch:
                    ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

                abstract ``then``:
                    ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                    ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                        Promise<U2<'TResult1, 'TResult2>>

                abstract Invoke:
                    [<ParamArray>] args: GetEntrypoint.GetEntrypoint.Args ->
                        U2<GetEntrypoint.GetEntrypoint, U2<GetEntrypoint.GetEntrypoint, unit>>

        module WorkflowInstance =
            type Status =
                abstract message: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set
                abstract output: option<obj> with get, set
                abstract error: option<Status.Error> with get, set
                abstract status: CloudflareWorkersModule.WorkflowInstanceStatus with get, set

            module SendEvent =
                type ``{
    type,
    payload,
  }`` =
                    abstract payload: option<obj> with get, set

                    [<CompiledName("type")>]
                    abstract ``type``: D1SessionBookmark with get, set

        module WorkflowInstanceCreateOptions =
            type TemplateLiteral =
                abstract Value: string
                abstract Create: v0: float -> TemplateLiteral

            type Retention =
                abstract errorRetention: option<WorkflowRetentionDuration> with get, set
                abstract successRetention: option<WorkflowRetentionDuration> with get, set

        module ``Cloudflare:node`` =
            type HttpServerHandler =
                abstract port: float with get, set

                abstract Invoke:
                    server: NodeStyleServer -> ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>>

                abstract Invoke:
                    options: HttpServerHandler.HttpServerHandler.Options ->
                        ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>>

                abstract Invoke: port: float -> ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>>

            [<Import("@cloudflare/workers-types.cloudflare:node", "NodeStyleServer")>]
            type NodeStyleServer =
                abstract address: unit -> NodeStyleServer.Address
                abstract listen: [<ParamArray>] args: Array<option<obj>> -> 'NodeStyleServer

            module NodeStyleServer =
                type Address =
                    abstract port: option<float> with get, set

        module ``Cloudflare:pipelines`` =
            [<Import("@cloudflare/workers-types.cloudflare:pipelines", "PipelineBatchMetadata")>]
            type PipelineBatchMetadata =
                abstract pipelineName: D1SessionBookmark with get, set
                abstract pipelineId: D1SessionBookmark with get, set

            type PipelineRecord = PipelineRecord

            [<Import("@cloudflare/workers-types.cloudflare:pipelines", "PipelineTransformationEntrypoint")>]
            type PipelineTransformationEntrypoint<'O, 'I, 'Env
                when 'O :> PipelineTransformationEntrypoint and 'I :> PipelineTransformationEntrypoint> =
                [<EmitConstructor>]
                abstract Create: ctx: ExecutionContext<option<obj>> * env: 'Env -> PipelineTransformationEntrypoint

                abstract ctx: ExecutionContext<option<obj>> with get, set
                abstract env: 'Env with get, set
                abstract run: records: Array<'I> * metadata: PipelineBatchMetadata -> Promise<Array<'O>>

            [<Import("@cloudflare/workers-types.cloudflare:pipelines", "Pipeline")>]
            type Pipeline<'T when 'T :> Pipeline> =
                abstract send: records: Array<'T> -> Promise<unit>

            module Pipeline =
                type T =
                    abstract Item: key: D1SessionBookmark -> option<obj>

            module PipelineTransformationEntrypoint =
                type I =
                    abstract Item: key: D1SessionBookmark -> option<obj>

                module Run =
                    type Metadata =
                        abstract pipelineName: D1SessionBookmark with get, set
                        abstract pipelineId: D1SessionBookmark with get, set

        module ``Cloudflare:workflows`` =
            [<Import("@cloudflare/workers-types.cloudflare:workflows", "NonRetryableError")>]
            type NonRetryableError =
                interface
                    [<EmitConstructor>]
                    abstract Create: message: D1SessionBookmark * ?name: D1SessionBookmark -> NonRetryableError

                    inherit Error
                end
