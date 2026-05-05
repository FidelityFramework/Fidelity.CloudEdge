module rec CloudflareWorkersTypes

open System
open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop

module rec Cloudflare =
    module rec WorkersTypes =
        module rec AIGatewayHeaders =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Item =
                | [<CompiledValue(false)>] False
                | [<CompiledValue(true)>] True

        module rec AddEventListener =
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

        module rec Ai =
            type _Lit49 =
                [<EmitProperty("total_count")>]
                abstract totalCount: float with get, set

                [<EmitProperty("per_page")>]
                abstract perPage: float with get, set

                abstract page: float with get, set
                abstract count: float with get, set

            type _Lit37 =
                abstract metadata: option<WebAssembly.ModuleImports> with get, set

                [<EmitProperty("sync_interval")>]
                abstract syncInterval: option<_Lit36> with get, set

                [<EmitProperty("custom_metadata")>]
                abstract customMetadata: option<ResizeArray<_Lit34>> with get, set

                [<EmitProperty("cache_threshold")>]
                abstract cacheThreshold: option<_Lit12> with get, set

                abstract cache: option<bool> with get, set

                [<EmitProperty("max_num_results")>]
                abstract maxNumResults: option<float> with get, set

                [<EmitProperty("score_threshold")>]
                abstract scoreThreshold: option<float> with get, set

                [<EmitProperty("chunk_overlap")>]
                abstract chunkOverlap: option<float> with get, set

                [<EmitProperty("chunk_size")>]
                abstract chunkSize: option<float> with get, set

                abstract chunk: option<bool> with get, set

                [<EmitProperty("retrieval_options")>]
                abstract retrievalOptions: option<_Lit33> with get, set

                [<EmitProperty("indexing_options")>]
                abstract indexingOptions: option<_Lit30> with get, set

                [<EmitProperty("fusion_method")>]
                abstract fusionMethod: option<_Lit6> with get, set

                [<EmitProperty("index_method")>]
                abstract indexMethod: option<_Lit28> with get, set

                /// <deprecated>
                /// Use index_method instead.
                /// </deprecated>
                [<EmitProperty("hybrid_search_enabled")>]
                abstract hybridSearchEnabled: option<bool> with get, set

                [<EmitProperty("reranking_model")>]
                abstract rerankingModel: option<D1SessionBookmark> with get, set

                [<EmitProperty("rewrite_model")>]
                abstract rewriteModel: option<D1SessionBookmark> with get, set

                [<EmitProperty("ai_search_model")>]
                abstract aiSearchModel: option<D1SessionBookmark> with get, set

                [<EmitProperty("embedding_model")>]
                abstract embeddingModel: option<D1SessionBookmark> with get, set

                abstract reranking: option<bool> with get, set

                [<EmitProperty("rewrite_query")>]
                abstract rewriteQuery: option<bool> with get, set

                [<EmitProperty("ai_gateway_id")>]
                abstract aiGatewayId: option<D1SessionBookmark> with get, set

                [<EmitProperty("token_id")>]
                abstract tokenId: option<D1SessionBookmark> with get, set

                [<EmitProperty("modified_at")>]
                abstract modifiedAt: option<D1SessionBookmark> with get, set

                [<EmitProperty("created_at")>]
                abstract createdAt: option<D1SessionBookmark> with get, set

                [<EmitProperty("namespace")>]
                abstract ``namespace``: option<D1SessionBookmark> with get, set

                abstract status: option<D1SessionBookmark> with get, set
                abstract paused: option<bool> with get, set

                [<EmitProperty("source_params")>]
                abstract sourceParams: option<obj> with get, set

                abstract source: option<D1SessionBookmark> with get, set

                [<EmitProperty("type")>]
                abstract ``type``: option<U2<_Lit37.Type, string>> with get, set

                abstract id: D1SessionBookmark with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit6 =
                | [<CompiledName("max")>] Max
                | [<CompiledName("rrf")>] Rrf

            type _Lit96 = interface end

            type _Lit36 =
                | ``3600`` = 3600
                | ``7200`` = 7200
                | ``14400`` = 14400
                | ``21600`` = 21600
                | ``43200`` = 43200
                | ``86400`` = 86400

            type _Lit88 =
                abstract signal: option<AbortSignal> with get, set
                abstract extraHeaders: option<obj> with get, set
                abstract prefix: option<D1SessionBookmark> with get, set
                abstract returnRawResponse: option<bool> with get, set
                abstract gateway: option<GatewayOptions> with get, set
                abstract tags: option<ResizeArray<D1SessionBookmark>> with get, set
                abstract websocket: option<bool> with get, set
                abstract queueRequest: option<bool> with get, set

            type _Lit28 =
                abstract keyword: option<bool> with get, set
                abstract vector: option<bool> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit12 =
                | [<CompiledName("super_strict_match")>] SuperStrictMatch
                | [<CompiledName("close_enough")>] CloseEnough
                | [<CompiledName("flexible_friend")>] FlexibleFriend
                | [<CompiledName("anything_goes")>] AnythingGoes

            type _Lit18 =
                abstract metadata: option<WebAssembly.ModuleImports> with get, set
                abstract key: D1SessionBookmark with get, set
                abstract timestamp: option<float> with get, set

            type _Lit9 =
                [<EmitProperty("rewrite_prompt")>]
                abstract rewritePrompt: option<D1SessionBookmark> with get, set

                abstract model: option<D1SessionBookmark> with get, set
                abstract enabled: option<bool> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

            type _Lit4 =
                [<EmitProperty("boost_by")>]
                abstract boostBy: option<ResizeArray<_Lit7>> with get, set

                [<EmitProperty("return_on_failure")>]
                abstract returnOnFailure: option<bool> with get, set

                [<EmitProperty("metadata_only")>]
                abstract metadataOnly: option<bool> with get, set

                [<EmitProperty("context_expansion")>]
                abstract contextExpansion: option<float> with get, set

                abstract filters: option<VectorizeVectorMetadataFilter> with get, set

                [<EmitProperty("max_num_results")>]
                abstract maxNumResults: option<float> with get, set

                [<EmitProperty("match_threshold")>]
                abstract matchThreshold: option<float> with get, set

                [<EmitProperty("keyword_match_mode")>]
                abstract keywordMatchMode: option<AutoRAG._Lit5> with get, set

                [<EmitProperty("fusion_method")>]
                abstract fusionMethod: option<_Lit6> with get, set

                [<EmitProperty("retrieval_type")>]
                abstract retrievalType: option<_Lit5> with get, set

                abstract Item: key: D1SessionBookmark -> option<obj>

            type _Lit11 =
                [<EmitProperty("cache_threshold")>]
                abstract cacheThreshold: option<_Lit12> with get, set

                abstract enabled: option<bool> with get, set

            type _Lit30 =
                [<EmitProperty("keyword_tokenizer")>]
                abstract keywordTokenizer: option<_Lit31> with get, set

            type _Lit46 =
                abstract metadata: option<WebAssembly.ModuleImports> with get, set

                [<EmitProperty("created_at")>]
                abstract createdAt: option<D1SessionBookmark> with get, set

                [<EmitProperty("last_seen_at")>]
                abstract lastSeenAt: option<D1SessionBookmark> with get, set

                [<EmitProperty("source_id")>]
                abstract sourceId: option<string> with get, set

                [<EmitProperty("file_size")>]
                abstract fileSize: option<float> with get, set

                [<EmitProperty("chunks_count")>]
                abstract chunksCount: option<float> with get, set

                [<EmitProperty("namespace")>]
                abstract ``namespace``: option<D1SessionBookmark> with get, set

                abstract checksum: option<D1SessionBookmark> with get, set
                abstract error: option<D1SessionBookmark> with get, set

                [<EmitProperty("next_action")>]
                abstract nextAction: option<_Lit48> with get, set

                abstract status: _Lit47 with get, set
                abstract key: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit65 =
                | [<CompiledName("user")>] User
                | [<CompiledName("schedule")>] Schedule

            type _Lit33 =
                [<EmitProperty("boost_by")>]
                abstract boostBy: option<ResizeArray<_Lit7>> with get, set

                [<EmitProperty("keyword_match_mode")>]
                abstract keywordMatchMode: option<AutoRAG._Lit5> with get, set

            type _Lit64 =
                [<EmitProperty("end_reason")>]
                abstract endReason: option<D1SessionBookmark> with get, set

                [<EmitProperty("ended_at")>]
                abstract endedAt: option<D1SessionBookmark> with get, set

                [<EmitProperty("started_at")>]
                abstract startedAt: option<D1SessionBookmark> with get, set

                [<EmitProperty("last_seen_at")>]
                abstract lastSeenAt: option<D1SessionBookmark> with get, set

                abstract description: option<D1SessionBookmark> with get, set
                abstract source: _Lit65 with get, set
                abstract id: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit48 =
                | INDEX
                | DELETE

            type AiModelList =
                abstract Item: key: D1SessionBookmark -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit47 =
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("error")>] Error
                | [<CompiledName("skipped")>] Skipped
                | [<CompiledName("queued")>] Queued
                | [<CompiledName("running")>] Running
                | [<CompiledName("outdated")>] Outdated

            type _Lit10 =
                [<EmitProperty("match_threshold")>]
                abstract matchThreshold: option<float> with get, set

                abstract model: option<D1SessionBookmark> with get, set
                abstract enabled: option<bool> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec AiGateway =
            module rec GetUrl =
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

            module rec _Lit6 =
                module rec Headers =
                    module rec Headers =
                        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                        type CfAigSkipCache =
                            | [<CompiledValue(false)>] False
                            | [<CompiledValue(true)>] True

                type Headers =
                    [<EmitProperty("Content-Type")>]
                    abstract contentType: option<string> with get, set

                    [<EmitProperty("Authorization")>]
                    abstract authorization: option<string> with get, set

                    [<EmitProperty("cf-aig-collect-log")>]
                    abstract cfAigCollectLog: option<U2<Headers.CfAigCollectLog, string>> with get, set

                    [<EmitProperty("cf-aig-backoff")>]
                    abstract cfAigBackoff: option<string> with get, set

                    [<EmitProperty("cf-aig-retry-delay")>]
                    abstract cfAigRetryDelay: option<U2<string, float>> with get, set

                    [<EmitProperty("cf-aig-max-attempts")>]
                    abstract cfAigMaxAttempts: option<U2<string, float>> with get, set

                    [<EmitProperty("cf-aig-request-timeout")>]
                    abstract cfAigRequestTimeout: option<U2<string, float>> with get, set

                    [<EmitProperty("cf-aig-event-id")>]
                    abstract cfAigEventId: option<string> with get, set

                    [<EmitProperty("cf-aig-cache-key")>]
                    abstract cfAigCacheKey: option<string> with get, set

                    [<EmitProperty("cf-aig-skip-cache")>]
                    abstract cfAigSkipCache: option<U2<Headers.CfAigSkipCache, string>> with get, set

                    [<EmitProperty("cf-aig-cache-ttl")>]
                    abstract cfAigCacheTtl: option<U2<string, float>> with get, set

                    [<EmitProperty("cf-aig-custom-cost")>]
                    abstract cfAigCustomCost: option<U3<_Lit12, _Lit13, string>> with get, set

                    [<EmitProperty("cf-aig-metadata")>]
                    abstract cfAigMetadata: option<U2<Typescript.CSSViewTransitionRule._Lit44, string>> with get, set

            type _Lit12 =
                [<EmitProperty("per_token_out")>]
                abstract perTokenOut: option<float> with get, set

                [<EmitProperty("per_token_in")>]
                abstract perTokenIn: option<float> with get, set

            type _Lit13 =
                [<EmitProperty("total_cost")>]
                abstract totalCost: option<float> with get, set

            type _Lit6 =
                abstract query: option<obj> with get, set
                abstract headers: _Lit6.Headers with get, set
                abstract endpoint: D1SessionBookmark with get, set
                abstract provider: U2<_Lit6.Provider, string> with get, set

        module rec AiModelListType =
            type AiModelList =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec AiModels =
            type _Lit184 =
                abstract name: D1SessionBookmark with get, set

            type _Lit37 =
                abstract requests: ResizeArray<_Lit35> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit80 =
                | [<CompiledName("json_object")>] JsonObject
                | [<CompiledName("json_schema")>] JsonSchema

            type _Lit276 =
                [<EmitProperty("service_tier")>]
                abstract serviceTier: option<_Lit147> with get, set

                [<EmitProperty("system_fingerprint")>]
                abstract systemFingerprint: option<string> with get, set

                abstract usage: option<CompletionUsage> with get, set
                abstract choices: ResizeArray<ChatCompletionChoice> with get, set
                abstract model: D1SessionBookmark with get, set
                abstract created: float with get, set
                abstract object: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set

            type _Lit39 =
                abstract pooling: option<_Lit36> with get, set
                abstract data: option<ResizeArray<AiSentenceSimilarityOutput>> with get, set
                abstract shape: option<AiSentenceSimilarityOutput> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit252 =
                | [<CompiledName("in_progress")>] InProgress
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("incomplete")>] Incomplete

            type _Lit87 =
                [<EmitProperty("total_tokens")>]
                abstract totalTokens: option<float> with get, set

                [<EmitProperty("completion_tokens")>]
                abstract completionTokens: option<float> with get, set

                [<EmitProperty("prompt_tokens")>]
                abstract promptTokens: option<float> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit36 =
                | [<CompiledName("mean")>] Mean
                | [<CompiledName("cls")>] Cls

            type _Lit57 =
                abstract contentType: option<D1SessionBookmark> with get, set
                abstract body: option<obj> with get, set

            type _Lit172 =
                abstract content: U2<ResizeArray<ChatCompletionContentPartText>, string> with get, set

                [<EmitProperty("type")>]
                abstract ``type``: _Lit172.Type with get, set

            type _Lit2 =
                abstract label: option<D1SessionBookmark> with get, set
                abstract score: option<float> with get, set

            type _Lit35 =
                abstract pooling: option<_Lit36> with get, set
                abstract text: U2<ResizeArray<D1SessionBookmark>, string> with get, set

            type _Lit271 =
                [<EmitProperty("type")>]
                abstract ``type``: _Lit271.Type with get, set

                abstract text: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit147 =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("default")>] Default
                | [<CompiledName("flex")>] Flex
                | [<CompiledName("scale")>] Scale
                | [<CompiledName("priority")>] Priority

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit161 =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("disabled")>] Disabled

            type _Lit41 =
                abstract audio: AiSentenceSimilarityOutput with get, set

            type _Lit191 =
                abstract strict: option<bool> with get, set
                abstract parameters: option<WebAssembly.ModuleImports> with get, set
                abstract description: option<D1SessionBookmark> with get, set
                abstract name: D1SessionBookmark with get, set

            type _Lit47 =
                [<EmitProperty("translated_text")>]
                abstract translatedText: option<D1SessionBookmark> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit251 = | [<CompiledName("refusal")>] Refusal

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit253 = | [<CompiledName("function_call")>] FunctionCall

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit146 =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("concise")>] Concise
                | [<CompiledName("detailed")>] Detailed

            type _Lit28 =
                abstract arguments: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set

            type _Lit86 =
                [<EmitProperty("tool_calls")>]
                abstract toolCalls: option<ResizeArray<_Lit78>> with get, set

                abstract usage: option<_Lit87> with get, set
                abstract response: D1SessionBookmark with get, set

            type _Lit150 =
                abstract verbosity: option<_Lit156> with get, set
                abstract format: option<ResponseFormatTextConfig> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit156 =
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium")>] Medium
                | [<CompiledName("high")>] High

            type _Lit166 =
                abstract format: _Lit168 with get, set
                abstract voice: U2<_Lit138, string> with get, set

            type _Lit53 =
                [<EmitProperty("max_tokens")>]
                abstract maxTokens: option<float> with get, set

                abstract image: U2<ResizeArray<float>, Ai._Lit96> with get, set

                [<EmitProperty("presence_penalty")>]
                abstract presencePenalty: option<float> with get, set

                [<EmitProperty("frequency_penalty")>]
                abstract frequencyPenalty: option<float> with get, set

                [<EmitProperty("repetition_penalty")>]
                abstract repetitionPenalty: option<float> with get, set

                abstract seed: option<float> with get, set

                [<EmitProperty("top_k")>]
                abstract topK: option<float> with get, set

                [<EmitProperty("top_p")>]
                abstract topP: option<float> with get, set

                abstract raw: option<bool> with get, set
                abstract prompt: option<D1SessionBookmark> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit168 =
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("aac")>] Aac
                | [<CompiledName("mp3")>] Mp3
                | [<CompiledName("flac")>] Flac
                | [<CompiledName("opus")>] Opus
                | [<CompiledName("pcm16")>] Pcm16

            type _Lit272 =
                [<EmitProperty("image_url")>]
                abstract imageUrl: option<string> with get, set

                [<EmitProperty("type")>]
                abstract ``type``: _Lit272.Type with get, set

                abstract detail: _Lit273 with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit273 =
                | [<CompiledName("low")>] Low
                | [<CompiledName("high")>] High
                | [<CompiledName("auto")>] Auto

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit140 =
                | [<CompiledName("message.input_image.image_url")>] MessageInputImageImageUrl
                | [<CompiledName("message.output_text.logprobs")>] MessageOutputTextLogprobs

            type _Lit138 =
                abstract id: D1SessionBookmark with get, set

            type _Lit248 =
                abstract logprobs: option<ResizeArray<Logprob>> with get, set

                [<EmitProperty("type")>]
                abstract ``type``: _Lit248.Type with get, set

                abstract text: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit274 =
                | [<CompiledName("queued")>] Queued
                | [<CompiledName("failed")>] Failed
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("in_progress")>] InProgress
                | [<CompiledName("cancelled")>] Cancelled
                | [<CompiledName("incomplete")>] Incomplete

            type _Lit275 =
                [<EmitProperty("total_tokens")>]
                abstract totalTokens: float with get, set

                [<EmitProperty("output_tokens")>]
                abstract outputTokens: float with get, set

                [<EmitProperty("input_tokens")>]
                abstract inputTokens: float with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit246 =
                | [<CompiledName("message")>] Message
                | [<CompiledName("assistant")>] Assistant

            type _Lit202 =
                abstract timezone: option<D1SessionBookmark> with get, set
                abstract region: option<D1SessionBookmark> with get, set
                abstract country: option<D1SessionBookmark> with get, set
                abstract city: option<D1SessionBookmark> with get, set

            type _Lit199 =
                [<EmitProperty("user_location")>]
                abstract userLocation: option<WebSearchUserLocation> with get, set

                [<EmitProperty("search_context_size")>]
                abstract searchContextSize: option<_Lit200> with get, set

            type _Lit181 =
                [<EmitProperty("include_obfuscation")>]
                abstract includeObfuscation: option<bool> with get, set

                [<EmitProperty("include_usage")>]
                abstract includeUsage: option<bool> with get, set

            type _Lit174 =
                [<EmitProperty("clear_thinking")>]
                abstract clearThinking: option<bool> with get, set

                [<EmitProperty("enable_thinking")>]
                abstract enableThinking: option<bool> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit295 =
                | [<CompiledName("none")>] None
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("ogg")>] Ogg

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit294 =
                | [<CompiledName("linear16")>] Linear16
                | [<CompiledName("flac")>] Flac
                | [<CompiledName("mulaw")>] Mulaw
                | [<CompiledName("alaw")>] Alaw
                | [<CompiledName("mp3")>] Mp3
                | [<CompiledName("opus")>] Opus
                | [<CompiledName("aac")>] Aac

            type _Lit201 =
                abstract approximate: _Lit202 with get, set

                [<EmitProperty("type")>]
                abstract ``type``: _Lit201.Type with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit261 =
                | [<CompiledName("user")>] User
                | [<CompiledName("system")>] System
                | [<CompiledName("developer")>] Developer

            type _Lit290 =
                [<EmitProperty("completion_tokens_details")>]
                abstract completionTokensDetails: option<CompletionTokensDetails> with get, set

                [<EmitProperty("prompt_tokens_details")>]
                abstract promptTokensDetails: option<PromptTokensDetails> with get, set

                [<EmitProperty("total_tokens")>]
                abstract totalTokens: float with get, set

                [<EmitProperty("completion_tokens")>]
                abstract completionTokens: float with get, set

                [<EmitProperty("prompt_tokens")>]
                abstract promptTokens: float with get, set

            type _Lit154 =
                abstract Item: key: D1SessionBookmark -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit254 = | [<CompiledName("reasoning")>] Reasoning

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit117 =
                | [<CompiledName("extended")>] Extended
                | [<CompiledName("strict")>] Strict

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit200 =
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium")>] Medium
                | [<CompiledName("high")>] High

            type _Lit186 =
                [<EmitProperty("allowed_tools")>]
                abstract allowedTools: _Lit187 with get, set

                [<EmitProperty("type")>]
                abstract ``type``: _Lit186.Type with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit259 =
                | [<CompiledName("user")>] User
                | [<CompiledName("assistant")>] Assistant
                | [<CompiledName("system")>] System
                | [<CompiledName("developer")>] Developer

            type _Lit257 =
                [<EmitProperty("type")>]
                abstract ``type``: option<_Lit257.Type> with get, set

                abstract role: _Lit259 with get, set
                abstract content: U2<ResizeArray<'T>, string> with get, set

            type _Lit292 =
                [<EmitProperty("rejected_prediction_tokens")>]
                abstract rejectedPredictionTokens: option<float> with get, set

                [<EmitProperty("accepted_prediction_tokens")>]
                abstract acceptedPredictionTokens: option<float> with get, set

                [<EmitProperty("audio_tokens")>]
                abstract audioTokens: option<float> with get, set

                [<EmitProperty("reasoning_tokens")>]
                abstract reasoningTokens: option<float> with get, set

            type _Lit183 =
                [<EmitProperty("function")>]
                abstract ``function``: _Lit184 with get, set

                [<EmitProperty("type")>]
                abstract ``type``: _Lit183.Type with get, set

            type _Lit185 =
                abstract custom: _Lit184 with get, set

                [<EmitProperty("type")>]
                abstract ``type``: _Lit185.Type with get, set

            type _Lit291 =
                [<EmitProperty("audio_tokens")>]
                abstract audioTokens: option<float> with get, set

                [<EmitProperty("cached_tokens")>]
                abstract cachedTokens: option<float> with get, set

            type _Lit219 =
                abstract filename: option<D1SessionBookmark> with get, set

                [<EmitProperty("file_id")>]
                abstract fileId: option<D1SessionBookmark> with get, set

                [<EmitProperty("file_data")>]
                abstract fileData: option<D1SessionBookmark> with get, set

            type _Lit260 =
                [<EmitProperty("type")>]
                abstract ``type``: option<_Lit260.Type> with get, set

                abstract status: option<_Lit252> with get, set
                abstract role: _Lit261 with get, set
                abstract content: ResponseInputMessageContentList with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit264 =
                | [<CompiledName("in_progress")>] InProgress
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("incomplete")>] Incomplete

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit262 = | [<CompiledName("function_call_output")>] FunctionCallOutput

            type _Lit187 =
                abstract tools: ResizeArray<WebAssembly.ModuleImports> with get, set
                abstract mode: _Lit188 with get, set

        module rec AiSearchConfig =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Type =
                | [<CompiledName("r2")>] R2
                | [<CompiledName("web-crawler")>] WebCrawler

        module rec AiSearchInstance =
            module rec Update =
                module rec Config =
                    module rec Update =
                        module rec Config =
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

                type Config =
                    abstract metadata: option<Typescript.CSSViewTransitionRule._Lit44> with get, set

                    [<EmitProperty("sync_interval")>]
                    abstract syncInterval: option<Config.SyncInterval> with get, set

                    [<EmitProperty("namespace")>]
                    abstract ``namespace``: option<string> with get, set

                    [<EmitProperty("custom_metadata")>]
                    abstract customMetadata: option<ResizeArray<Ai._Lit34>> with get, set

                    [<EmitProperty("cache_threshold")>]
                    abstract cacheThreshold: option<Config.CacheThreshold> with get, set

                    abstract cache: option<Typescript.CSSViewTransitionRule._Lit30> with get, set

                    [<EmitProperty("max_num_results")>]
                    abstract maxNumResults: option<float> with get, set

                    [<EmitProperty("score_threshold")>]
                    abstract scoreThreshold: option<float> with get, set

                    [<EmitProperty("chunk_overlap")>]
                    abstract chunkOverlap: option<float> with get, set

                    [<EmitProperty("chunk_size")>]
                    abstract chunkSize: option<float> with get, set

                    abstract chunk: option<Typescript.CSSViewTransitionRule._Lit30> with get, set

                    [<EmitProperty("retrieval_options")>]
                    abstract retrievalOptions: option<Ai._Lit33> with get, set

                    [<EmitProperty("indexing_options")>]
                    abstract indexingOptions: option<Ai._Lit30> with get, set

                    [<EmitProperty("fusion_method")>]
                    abstract fusionMethod: option<Config.FusionMethod> with get, set

                    [<EmitProperty("index_method")>]
                    abstract indexMethod: option<Ai._Lit28> with get, set

                    [<EmitProperty("hybrid_search_enabled")>]
                    abstract hybridSearchEnabled: option<Typescript.CSSViewTransitionRule._Lit30> with get, set

                    [<EmitProperty("reranking_model")>]
                    abstract rerankingModel: option<string> with get, set

                    [<EmitProperty("rewrite_model")>]
                    abstract rewriteModel: option<string> with get, set

                    [<EmitProperty("ai_search_model")>]
                    abstract aiSearchModel: option<string> with get, set

                    [<EmitProperty("embedding_model")>]
                    abstract embeddingModel: option<string> with get, set

                    abstract reranking: option<Typescript.CSSViewTransitionRule._Lit30> with get, set

                    [<EmitProperty("rewrite_query")>]
                    abstract rewriteQuery: option<Typescript.CSSViewTransitionRule._Lit30> with get, set

                    [<EmitProperty("ai_gateway_id")>]
                    abstract aiGatewayId: option<string> with get, set

                    [<EmitProperty("token_id")>]
                    abstract tokenId: option<string> with get, set

                    [<EmitProperty("source_params")>]
                    abstract sourceParams: option<obj> with get, set

                    abstract source: option<string> with get, set

                    [<EmitProperty("type")>]
                    abstract ``type``: option<string> with get, set

                    abstract id: option<string> with get, set

        module rec Artifacts =
            type _Lit10 =
                abstract cursor: option<D1SessionBookmark> with get, set
                abstract limit: option<float> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit3 =
                | [<CompiledName("read")>] Read
                | [<CompiledName("write")>] Write

        module rec ArtifactsRepoListResult =
            type Repos =
                abstract readOnly: bool with get, set
                abstract lastPushAt: option<string> with get, set
                abstract updatedAt: D1SessionBookmark with get, set
                abstract createdAt: D1SessionBookmark with get, set
                abstract defaultBranch: D1SessionBookmark with get, set
                abstract description: option<string> with get, set
                abstract source: option<string> with get, set
                abstract name: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set

        module rec AutoRAG =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit7 =
                | [<CompiledName("eq")>] Eq
                | [<CompiledName("ne")>] Ne
                | [<CompiledName("gt")>] Gt
                | [<CompiledName("gte")>] Gte
                | [<CompiledName("lt")>] Lt
                | [<CompiledName("lte")>] Lte

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit5 =
                | [<CompiledName("and")>] And
                | [<CompiledName("or")>] Or

            type _Lit20 =
                [<EmitProperty("system_prompt")>]
                abstract systemPrompt: option<D1SessionBookmark> with get, set

                abstract stream: option<bool> with get, set

                [<EmitProperty("rewrite_query")>]
                abstract rewriteQuery: option<bool> with get, set

                abstract reranking: option<_Lit9> with get, set

                [<EmitProperty("ranking_options")>]
                abstract rankingOptions: option<_Lit8> with get, set

                [<EmitProperty("max_num_results")>]
                abstract maxNumResults: option<float> with get, set

                abstract filters: option<U2<_Lit4, _Lit6>> with get, set
                abstract query: D1SessionBookmark with get, set

            type _Lit22 =
                abstract response: D1SessionBookmark with get, set

                [<EmitProperty("next_page")>]
                abstract nextPage: option<string> with get, set

                [<EmitProperty("has_more")>]
                abstract hasMore: bool with get, set

                abstract data: ResizeArray<_Lit11> with get, set

                [<EmitProperty("search_query")>]
                abstract searchQuery: D1SessionBookmark with get, set

                abstract object: _Lit22.Object with get, set

            type _Lit9 =
                abstract model: option<D1SessionBookmark> with get, set
                abstract enabled: option<bool> with get, set

            type _Lit13 =
                abstract text: D1SessionBookmark with get, set

                [<EmitProperty("type")>]
                abstract ``type``: _Lit13.Type with get, set

            type _Lit8 =
                [<EmitProperty("score_threshold")>]
                abstract scoreThreshold: option<float> with get, set

                abstract ranker: option<D1SessionBookmark> with get, set

            type _Lit6 =
                abstract value: U3<string, float, bool> with get, set

                [<EmitProperty("type")>]
                abstract ``type``: _Lit7 with get, set

                abstract key: D1SessionBookmark with get, set

            type _Lit4 =
                abstract filters: ResizeArray<ComparisonFilter> with get, set

                [<EmitProperty("type")>]
                abstract ``type``: _Lit5 with get, set

        module rec BaseAiCfOpenaiGptOss20B =
            type Inputs =
                abstract requests: option<unit> with get, set
                abstract functions: option<unit> with get, set

                [<EmitProperty("function_call")>]
                abstract functionCall: option<unit> with get, set

                [<EmitProperty("web_search_options")>]
                abstract webSearchOptions: option<unit> with get, set

                abstract user: option<unit> with get, set
                abstract store: option<unit> with get, set
                abstract seed: option<unit> with get, set

                [<EmitProperty("response_format")>]
                abstract responseFormat: option<unit> with get, set

                [<EmitProperty("chat_template_kwargs")>]
                abstract chatTemplateKwargs: option<unit> with get, set

                [<EmitProperty("reasoning_effort")>]
                abstract reasoningEffort: option<unit> with get, set

                [<EmitProperty("presence_penalty")>]
                abstract presencePenalty: option<unit> with get, set

                abstract prediction: option<unit> with get, set
                abstract n: option<unit> with get, set
                abstract modalities: option<unit> with get, set

                [<EmitProperty("max_completion_tokens")>]
                abstract maxCompletionTokens: option<unit> with get, set

                [<EmitProperty("max_tokens")>]
                abstract maxTokens: option<unit> with get, set

                [<EmitProperty("top_logprobs")>]
                abstract topLogprobs: option<unit> with get, set

                abstract logprobs: option<unit> with get, set

                [<EmitProperty("logit_bias")>]
                abstract logitBias: option<unit> with get, set

                [<EmitProperty("frequency_penalty")>]
                abstract frequencyPenalty: option<unit> with get, set

                abstract model: option<unit> with get, set
                abstract messages: option<unit> with get, set
                abstract prompt: option<unit> with get, set
                abstract stop: option<unit> with get, set
                abstract metadata: option<unit> with get, set
                abstract audio: option<unit> with get, set
                abstract truncation: option<AiModels._Lit161> with get, set

                [<EmitProperty("top_p")>]
                abstract topP: option<float> with get, set

                abstract tools: option<ResizeArray<Tool>> with get, set

                [<EmitProperty("tool_choice")>]
                abstract toolChoice: option<U2<Inputs.ToolChoice, AiModels._Lit158>> with get, set

                abstract text: option<ResponseTextConfig> with get, set
                abstract temperature: option<float> with get, set

                [<EmitProperty("stream_options")>]
                abstract streamOptions: option<AiModels._Lit149> with get, set

                abstract stream: option<bool> with get, set

                [<EmitProperty("service_tier")>]
                abstract serviceTier: option<AiModels._Lit147> with get, set

                [<EmitProperty("safety_identifier")>]
                abstract safetyIdentifier: option<D1SessionBookmark> with get, set

                abstract reasoning: option<AiModels._Lit143> with get, set

                [<EmitProperty("prompt_cache_key")>]
                abstract promptCacheKey: option<D1SessionBookmark> with get, set

                [<EmitProperty("previous_response_id")>]
                abstract previousResponseId: option<string> with get, set

                [<EmitProperty("parallel_tool_calls")>]
                abstract parallelToolCalls: option<bool> with get, set

                [<EmitProperty("max_output_tokens")>]
                abstract maxOutputTokens: option<float> with get, set

                abstract instructions: option<string> with get, set
                abstract input: option<U2<ResizeArray<'T>, string>> with get, set
                abstract include: option<ResizeArray<ResponseIncludable>> with get, set
                abstract conversation: option<U2<AiModels._Lit138, string>> with get, set
                abstract background: option<bool> with get, set

                [<EmitProperty("prompt_cache_key")>]
                abstract promptCacheKey: option<unit> with get, set

                abstract conversation: option<unit> with get, set
                abstract background: option<unit> with get, set
                abstract truncation: option<unit> with get, set

                [<EmitProperty("safety_identifier")>]
                abstract safetyIdentifier: option<unit> with get, set

                abstract reasoning: option<unit> with get, set

                [<EmitProperty("previous_response_id")>]
                abstract previousResponseId: option<unit> with get, set

                [<EmitProperty("max_output_tokens")>]
                abstract maxOutputTokens: option<unit> with get, set

                abstract instructions: option<unit> with get, set
                abstract text: option<unit> with get, set
                abstract input: option<unit> with get, set
                abstract include: option<unit> with get, set
                abstract functions: option<ResizeArray<FunctionDefinition>> with get, set

                [<EmitProperty("function_call")>]
                abstract functionCall: option<U2<Inputs.FunctionCall, AiModels._Lit184>> with get, set

                [<EmitProperty("web_search_options")>]
                abstract webSearchOptions: option<WebSearchOptions> with get, set

                abstract user: option<D1SessionBookmark> with get, set
                abstract tools: option<ResizeArray<ChatCompletionTool>> with get, set

                [<EmitProperty("tool_choice")>]
                abstract toolChoice: option<ChatCompletionToolChoiceOption> with get, set

                [<EmitProperty("stream_options")>]
                abstract streamOptions: option<ChatCompletionsStreamOptions> with get, set

                abstract store: option<bool> with get, set
                abstract stop: option<U2<ResizeArray<D1SessionBookmark>, string>> with get, set
                abstract seed: option<float> with get, set

                [<EmitProperty("response_format")>]
                abstract responseFormat: option<ResponseFormat> with get, set

                [<EmitProperty("chat_template_kwargs")>]
                abstract chatTemplateKwargs: option<ChatTemplateKwargs> with get, set

                [<EmitProperty("reasoning_effort")>]
                abstract reasoningEffort: option<AiModels._Lit156> with get, set

                [<EmitProperty("presence_penalty")>]
                abstract presencePenalty: option<float> with get, set

                abstract prediction: option<PredictionContent> with get, set

                [<EmitProperty("parallel_tool_calls")>]
                abstract parallelToolCalls: option<bool> with get, set

                abstract n: option<float> with get, set
                abstract modalities: option<ResizeArray<Inputs.Modalities>> with get, set
                abstract metadata: option<Typescript.CSSViewTransitionRule._Lit44> with get, set

                [<EmitProperty("max_completion_tokens")>]
                abstract maxCompletionTokens: option<float> with get, set

                [<EmitProperty("max_tokens")>]
                abstract maxTokens: option<float> with get, set

                [<EmitProperty("top_logprobs")>]
                abstract topLogprobs: option<float> with get, set

                abstract logprobs: option<bool> with get, set

                [<EmitProperty("logit_bias")>]
                abstract logitBias: option<Typescript.CSSViewTransitionRule._Lit44> with get, set

                [<EmitProperty("frequency_penalty")>]
                abstract frequencyPenalty: option<float> with get, set

                abstract audio: option<AudioParams> with get, set
                abstract model: option<D1SessionBookmark> with get, set
                abstract messages: ResizeArray<ChatCompletionMessageParam> with get, set
                abstract prompt: D1SessionBookmark with get, set

                [<EmitProperty("top_p")>]
                abstract topP: option<unit> with get, set

                abstract tools: option<unit> with get, set

                [<EmitProperty("tool_choice")>]
                abstract toolChoice: option<unit> with get, set

                abstract temperature: option<unit> with get, set

                [<EmitProperty("stream_options")>]
                abstract streamOptions: option<unit> with get, set

                [<EmitProperty("service_tier")>]
                abstract serviceTier: option<unit> with get, set

                [<EmitProperty("parallel_tool_calls")>]
                abstract parallelToolCalls: option<unit> with get, set

                abstract stream: option<unit> with get, set
                abstract requests: ResizeArray<ChatCompletionsBase> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type PostProcessedOutputs = | [<CompiledName("response")>] Response

        module rec BaseAiMultimodalEmbeddings =
            type _Lit2 =
                abstract description: D1SessionBookmark with get, set

            type _Lit1 =
                abstract messages: option<ResizeArray<RoleScopedChatInput>> with get, set
                abstract raw: option<bool> with get, set

                [<EmitProperty("presence_penalty")>]
                abstract presencePenalty: option<float> with get, set

                [<EmitProperty("frequency_penalty")>]
                abstract frequencyPenalty: option<float> with get, set

                [<EmitProperty("repetition_penalty")>]
                abstract repetitionPenalty: option<float> with get, set

                abstract seed: option<float> with get, set

                [<EmitProperty("top_k")>]
                abstract topK: option<float> with get, set

                [<EmitProperty("top_p")>]
                abstract topP: option<float> with get, set

                [<EmitProperty("ignore_eos")>]
                abstract ignoreEos: option<bool> with get, set

                abstract temperature: option<float> with get, set

                [<EmitProperty("max_tokens")>]
                abstract maxTokens: option<float> with get, set

                abstract prompt: option<D1SessionBookmark> with get, set
                abstract image: D1SessionBookmark with get, set

        module rec BasicImageTransformations =
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

        module rec ChatCompletionsCommonOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type FunctionCall =
                | [<CompiledName("none")>] None
                | [<CompiledName("auto")>] Auto

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Modalities =
                | [<CompiledName("audio")>] Audio
                | [<CompiledName("text")>] Text

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ToolChoice =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("none")>] None
                | [<CompiledName("required")>] Required

        module rec Cloudflare =
            module rec Exports =
                type _Lit1 =
                    abstract Item: key: D1SessionBookmark -> option<obj>

            [<Import("@cloudflare/workers-types.Cloudflare", "Env")>]
            type Env = interface end

            [<Import("@cloudflare/workers-types.Cloudflare", "Exports")>]
            type Exports =
                abstract Item: key: D1SessionBookmark -> option<obj>

            [<Import("@cloudflare/workers-types.Cloudflare", "GlobalProps")>]
            type GlobalProps = interface end

            type GlobalProp<'Default, 'K when 'K :> D1SessionBookmark> = U2<proptypekey<GlobalProps, 'K>, 'Default>

            type ICloudflare =
                [<Erase>]
                member env: Env = JS.undefined

                [<Erase>]
                member exports: Exports = JS.undefined

        module rec CloudflareWorkersModule =
            module rec RollbackContext =
                type Output = interface end

            module rec WorkflowEntrypoint =
                module rec Run =
                    type Event =
                        abstract instanceId: D1SessionBookmark with get, set
                        abstract timestamp: Date with get, set
                        abstract payload: WebAssembly.ModuleImports with get, set

                type TemplateLiteral =
                    abstract Value: string
                    abstract Create: v0: float -> TemplateLiteral

                type _Lit7 =
                    abstract backoff: option<WorkflowBackoff> with get, set

                    abstract delay:
                        U15<
                            _Lit7.Delay,
                            _Lit7.Delay,
                            _Lit7.Delay,
                            _Lit7.Delay,
                            _Lit7.Delay,
                            _Lit7.Delay,
                            _Lit7.Delay,
                            _Lit7.Delay,
                            _Lit7.Delay,
                            _Lit7.Delay,
                            _Lit7.Delay,
                            _Lit7.Delay,
                            _Lit7.Delay,
                            _Lit7.Delay,
                            float
                         > with get, set

                    abstract limit: float with get, set

                type _Lit6 =
                    abstract timeout:
                        option<
                            U15<
                                _Lit6.Timeout,
                                _Lit6.Timeout,
                                _Lit6.Timeout,
                                _Lit6.Timeout,
                                _Lit6.Timeout,
                                _Lit6.Timeout,
                                _Lit6.Timeout,
                                _Lit6.Timeout,
                                _Lit6.Timeout,
                                _Lit6.Timeout,
                                _Lit6.Timeout,
                                _Lit6.Timeout,
                                _Lit6.Timeout,
                                _Lit6.Timeout,
                                float
                             >
                         > with get, set

                    abstract retries: option<_Lit7> with get, set

                type _Lit5 =
                    abstract count: float with get, set
                    abstract name: D1SessionBookmark with get, set

                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type T =
                    | [<CompiledValue(false)>] False
                    | [<CompiledValue(true)>] True

                type _Lit19 =
                    abstract timeout:
                        option<
                            U15<
                                _Lit19.Timeout,
                                _Lit19.Timeout,
                                _Lit19.Timeout,
                                _Lit19.Timeout,
                                _Lit19.Timeout,
                                _Lit19.Timeout,
                                _Lit19.Timeout,
                                _Lit19.Timeout,
                                _Lit19.Timeout,
                                _Lit19.Timeout,
                                _Lit19.Timeout,
                                _Lit19.Timeout,
                                _Lit19.Timeout,
                                _Lit19.Timeout,
                                float
                             >
                         > with get, set

                    [<EmitProperty("type")>]
                    abstract ``type``: D1SessionBookmark with get, set

                type _Lit4 =
                    abstract config: WorkflowStepConfig with get, set
                    abstract attempt: float with get, set
                    abstract step: _Lit5 with get, set

            type WithEnvAndExports =
                abstract Invoke: ?newEnv: obj * ?newExports: obj * fn: unit -> option<obj> -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type WorkflowDurationLabel =
                | [<CompiledName("second")>] Second
                | [<CompiledName("minute")>] Minute
                | [<CompiledName("hour")>] Hour
                | [<CompiledName("day")>] Day
                | [<CompiledName("week")>] Week
                | [<CompiledName("month")>] Month
                | [<CompiledName("year")>] Year

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

                abstract retries: option<WorkflowEntrypoint._Lit7> with get, set

            type WorkflowDelayDuration = obj
            type RpcStub<'T when 'T :> Rpc.Stubable> = obj

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "StepPromise")>]
            type StepPromise<'T> =
                inherit Promise<'T>
                abstract rollback: config: WorkflowStepConfig * fn: RollbackContext<'T> -> Promise<unit> -> StepPromise
                abstract rollback: fn: RollbackContext<'T> -> Promise<unit> -> StepPromise

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "DurableObject");
              AbstractClass;
              AllowNullLiteral>]
            type DurableObject<'Props, 'Env> private () =
                inherit Rpc.DurableObjectBranded()

                [<EmitConstructor>]
                abstract Create: ctx: DurableObjectState<option<obj>> * env: 'Env -> DurableObject

                abstract env: 'Env with get, set
                abstract ctx: DurableObjectState<'Props> with get, set

                [<EmitProperty("[Rpc.__DURABLE_OBJECT_BRAND]")>]
                abstract rpc_DURABLEOBJECTBRAND: unit with get, set

                abstract webSocketError: ws: Global.WebSocket * ?error: obj -> option<Promise<unit>>

                abstract webSocketClose:
                    ws: Global.WebSocket * code: float * reason: D1SessionBookmark * wasClean: bool ->
                        option<Promise<unit>>

                abstract webSocketMessage:
                    ws: Global.WebSocket * message: U2<ArrayBuffer, string> -> option<Promise<unit>>

                abstract connect: socket: Socket -> option<Promise<unit>>
                abstract fetch: request: Request -> U2<Global.Response, Promise<Global.Response>>
                abstract alarm: ?alarmInfo: AlarmInvocationInfo -> option<Promise<unit>>

            type TemplateLiteral =
                abstract Value: string
                abstract Create: v0: float -> TemplateLiteral

            type WorkflowSleepDuration = obj

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type WorkflowBackoff =
                | [<CompiledName("constant")>] Constant
                | [<CompiledName("linear")>] Linear
                | [<CompiledName("exponential")>] Exponential

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkflowStep");
              AbstractClass;
              AllowNullLiteral>]
            type WorkflowStep private () =
                abstract waitForEvent:
                    name: D1SessionBookmark * options: WorkflowEntrypoint._Lit19 ->
                        StepPromise<WorkflowEntrypoint._Lit14>

                abstract sleepUntil: name: D1SessionBookmark * timestamp: U2<Date, float> -> Promise<unit>
                abstract sleep: name: D1SessionBookmark * duration: WorkflowSleepDuration -> Promise<unit>

                abstract ``do``:
                    name: D1SessionBookmark * config: WorkflowStepConfig * callback: WorkflowStepContext -> Promise<'T> ->
                        StepPromise<'T>

                abstract ``do``:
                    name: D1SessionBookmark * callback: WorkflowStepContext -> Promise<'T> -> StepPromise<'T>

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "RpcTarget"); AbstractClass; AllowNullLiteral>]
            type RpcTarget private () =
                inherit Rpc.RpcTargetBranded()

                [<EmitProperty("[Rpc.__RPC_TARGET_BRAND]")>]
                abstract rpc_RPCTARGETBRAND: unit with get, set

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "RollbackContext")>]
            type RollbackContext<'T> =
                abstract stepName: D1SessionBookmark with get, set
                abstract output: option<RollbackContext.Output> with get, set
                abstract error: exn with get, set

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkerEntrypoint");
              AbstractClass;
              AllowNullLiteral>]
            type WorkerEntrypoint<'Props, 'Env> private () =
                inherit Rpc.WorkerEntrypointBranded()

                [<EmitConstructor>]
                abstract Create: ctx: ExecutionContext<option<obj>> * env: 'Env -> WorkerEntrypoint

                abstract env: 'Env with get, set
                abstract ctx: ExecutionContext<'Props> with get, set

                [<EmitProperty("[Rpc.__WORKER_ENTRYPOINT_BRAND]")>]
                abstract rpc_WORKERENTRYPOINTBRAND: unit with get, set

                abstract trace: traces: ResizeArray<TraceItem> -> option<Promise<unit>>
                abstract test: controller: TestController -> option<Promise<unit>>

                abstract tailStream:
                    event: TailStream.TailEvent<TailStream.Onset> ->
                        U3<
                            TailStream.TailEvent<'Event> -> option<Promise<unit>>,
                            TailStream.TailEventHandlerObject._Lit1,
                            Promise<TailStream.TailEventHandlerType>
                         >

                abstract tail: events: ResizeArray<TraceItem> -> option<Promise<unit>>
                abstract scheduled: controller: ScheduledController -> option<Promise<unit>>
                abstract queue: batch: MessageBatch<option<obj>> -> option<Promise<unit>>
                abstract connect: socket: Socket -> option<Promise<unit>>
                abstract fetch: request: Request -> U2<Global.Response, Promise<Global.Response>>
                abstract email: message: ForwardableEmailMessage -> option<Promise<unit>>

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkflowEvent")>]
            type WorkflowEvent<'T> =
                abstract instanceId: D1SessionBookmark with get, set
                abstract timestamp: Date with get, set
                abstract payload: WebAssembly.ModuleImports with get, set

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

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkflowEntrypoint");
              AbstractClass;
              AllowNullLiteral>]
            type WorkflowEntrypoint<'T, 'Env
                when 'T :> U32<
                    WorkflowEntrypoint,
                    RegExp,
                    exn,
                    Global.Response,
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
                    Request,
                    Rpc.RpcTargetBranded,
                    Typescript.CSSViewTransitionRule._Lit10,
                    Map<
                        U2<
                            option<
                                U31<
                                    WorkflowEntrypoint,
                                    RegExp,
                                    exn,
                                    Global.Response,
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
                                    Request,
                                    Rpc.RpcTargetBranded,
                                    Typescript.CSSViewTransitionRule._Lit10,
                                    WorkflowEntrypoint,
                                    Map<
                                        U2<
                                            option<
                                                U31<
                                                    WorkflowEntrypoint,
                                                    RegExp,
                                                    exn,
                                                    Global.Response,
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
                                                    Request,
                                                    Rpc.RpcTargetBranded,
                                                    Typescript.CSSViewTransitionRule._Lit10,
                                                    WorkflowEntrypoint,
                                                    Map<U2<option<obj>, unit>, U2<option<obj>, unit>>,
                                                    Set<U2<option<obj>, unit>>,
                                                    System.Collections.Generic.IReadOnlyList<U2<option<obj>, unit>>,
                                                    Typescript.CSSViewTransitionRule._Lit44,
                                                    string,
                                                    float
                                                 >
                                             >,
                                            unit
                                         >,
                                        U2<option<obj>, unit>
                                     >,
                                    Set<U2<option<obj>, unit>>,
                                    System.Collections.Generic.IReadOnlyList<U2<option<obj>, unit>>,
                                    Typescript.CSSViewTransitionRule._Lit44,
                                    string,
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
                                    exn,
                                    Global.Response,
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
                                    Request,
                                    Rpc.RpcTargetBranded,
                                    Typescript.CSSViewTransitionRule._Lit10,
                                    WorkflowEntrypoint,
                                    Map<
                                        U2<
                                            option<
                                                U31<
                                                    WorkflowEntrypoint,
                                                    RegExp,
                                                    exn,
                                                    Global.Response,
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
                                                    Request,
                                                    Rpc.RpcTargetBranded,
                                                    Typescript.CSSViewTransitionRule._Lit10,
                                                    WorkflowEntrypoint,
                                                    Map<U2<option<obj>, unit>, U2<option<obj>, unit>>,
                                                    Set<U2<option<obj>, unit>>,
                                                    System.Collections.Generic.IReadOnlyList<U2<option<obj>, unit>>,
                                                    Typescript.CSSViewTransitionRule._Lit44,
                                                    string,
                                                    float
                                                 >
                                             >,
                                            unit
                                         >,
                                        U2<option<obj>, unit>
                                     >,
                                    Set<U2<option<obj>, unit>>,
                                    System.Collections.Generic.IReadOnlyList<U2<option<obj>, unit>>,
                                    Typescript.CSSViewTransitionRule._Lit44,
                                    string,
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
                                    exn,
                                    Global.Response,
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
                                    Request,
                                    Rpc.RpcTargetBranded,
                                    Typescript.CSSViewTransitionRule._Lit10,
                                    WorkflowEntrypoint,
                                    Map<
                                        U2<
                                            option<
                                                U31<
                                                    WorkflowEntrypoint,
                                                    RegExp,
                                                    exn,
                                                    Global.Response,
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
                                                    Request,
                                                    Rpc.RpcTargetBranded,
                                                    Typescript.CSSViewTransitionRule._Lit10,
                                                    WorkflowEntrypoint,
                                                    Map<U2<option<obj>, unit>, U2<option<obj>, unit>>,
                                                    Set<U2<option<obj>, unit>>,
                                                    System.Collections.Generic.IReadOnlyList<U2<option<obj>, unit>>,
                                                    Typescript.CSSViewTransitionRule._Lit44,
                                                    string,
                                                    float
                                                 >
                                             >,
                                            unit
                                         >,
                                        U2<option<obj>, unit>
                                     >,
                                    Set<U2<option<obj>, unit>>,
                                    System.Collections.Generic.IReadOnlyList<U2<option<obj>, unit>>,
                                    Typescript.CSSViewTransitionRule._Lit44,
                                    string,
                                    float
                                 >
                             >,
                            unit
                         >
                     >,
                    System.Collections.Generic.IReadOnlyList<
                        U2<
                            option<
                                U31<
                                    WorkflowEntrypoint,
                                    RegExp,
                                    exn,
                                    Global.Response,
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
                                    Request,
                                    Rpc.RpcTargetBranded,
                                    Typescript.CSSViewTransitionRule._Lit10,
                                    WorkflowEntrypoint,
                                    Map<
                                        U2<
                                            option<
                                                U31<
                                                    WorkflowEntrypoint,
                                                    RegExp,
                                                    exn,
                                                    Global.Response,
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
                                                    Request,
                                                    Rpc.RpcTargetBranded,
                                                    Typescript.CSSViewTransitionRule._Lit10,
                                                    WorkflowEntrypoint,
                                                    Map<U2<option<obj>, unit>, U2<option<obj>, unit>>,
                                                    Set<U2<option<obj>, unit>>,
                                                    System.Collections.Generic.IReadOnlyList<U2<option<obj>, unit>>,
                                                    Typescript.CSSViewTransitionRule._Lit44,
                                                    string,
                                                    float
                                                 >
                                             >,
                                            unit
                                         >,
                                        U2<option<obj>, unit>
                                     >,
                                    Set<U2<option<obj>, unit>>,
                                    System.Collections.Generic.IReadOnlyList<U2<option<obj>, unit>>,
                                    Typescript.CSSViewTransitionRule._Lit44,
                                    string,
                                    float
                                 >
                             >,
                            unit
                         >
                     >,
                    Typescript.CSSViewTransitionRule._Lit44,
                    WorkflowEntrypoint,
                    string,
                    float,
                    obj
                 >> private () =
                inherit Rpc.WorkflowEntrypointBranded()

                [<EmitConstructor>]
                abstract Create: ctx: ExecutionContext<option<obj>> * env: 'Env -> WorkflowEntrypoint

                abstract env: 'Env with get, set
                abstract ctx: ExecutionContext<option<obj>> with get, set

                [<EmitProperty("[Rpc.__WORKFLOW_ENTRYPOINT_BRAND]")>]
                abstract rpc_WORKFLOWENTRYPOINTBRAND: unit with get, set

                abstract run: event: WorkflowEntrypoint.Run.Event * step: WorkflowStep -> Promise<option<obj>>

            type WorkflowRetentionDuration = obj
            type WorkflowTimeoutDuration = obj

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkflowStepContext")>]
            type WorkflowStepContext =
                abstract config: WorkflowStepConfig with get, set
                abstract attempt: float with get, set
                abstract step: WorkflowEntrypoint._Lit5 with get, set

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkflowStepEvent")>]
            type WorkflowStepEvent<'T> =
                [<EmitProperty("type")>]
                abstract ``type``: D1SessionBookmark with get, set

                abstract timestamp: Date with get, set
                abstract payload: WebAssembly.ModuleImports with get, set

            type ICloudflareWorkersModule =
                [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "withEnv")>]
                static member withEnv(newEnv: option<obj>, fn: unit -> option<obj>) : option<obj> = JS.undefined

                [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "withExports")>]
                static member withExports(newExports: option<obj>, fn: unit -> option<obj>) : option<obj> = JS.undefined

                [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "waitUntil")>]
                static member waitUntil(promise: Promise<option<obj>>) : unit = JS.undefined

                [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "withEnvAndExports")>]
                static member withEnvAndExports
                    (newEnv: option<obj>, newExports: option<obj>, fn: unit -> option<obj>)
                    : option<obj> =
                    JS.undefined

        module rec CompressionStream =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Format =
                | [<CompiledName("gzip")>] Gzip
                | [<CompiledName("deflate")>] Deflate
                | [<CompiledName("deflate-raw")>] DeflateRaw

        module rec D1Database =
            module rec WithSession =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type ConstraintOrBookmark =
                    | [<CompiledName("first-primary")>] FirstPrimary
                    | [<CompiledName("first-unconstrained")>] FirstUnconstrained

        module rec D1DatabaseSession =
            type Run =
                abstract results: ResizeArray<'T> with get, set
                abstract error: option<unit> with get, set
                abstract meta: D1PreparedStatement._Lit4 with get, set
                abstract success: Run.Success with get, set

        module rec D1PreparedStatement =
            type _Lit5 =
                [<EmitProperty("sql_duration_ms")>]
                abstract sqlDurationMs: float with get, set

            type _Lit4 =
                [<EmitProperty("total_attempts")>]
                abstract totalAttempts: option<float> with get, set

                abstract timings: option<_Lit5> with get, set

                [<EmitProperty("served_by_primary")>]
                abstract servedByPrimary: option<bool> with get, set

                [<EmitProperty("served_by_colo")>]
                abstract servedByColo: option<D1SessionBookmark> with get, set

                [<EmitProperty("served_by_region")>]
                abstract servedByRegion: option<D1SessionBookmark> with get, set

                abstract changes: float with get, set

                [<EmitProperty("changed_db")>]
                abstract changedDb: bool with get, set

                [<EmitProperty("last_row_id")>]
                abstract lastRowId: float with get, set

                [<EmitProperty("rows_written")>]
                abstract rowsWritten: float with get, set

                [<EmitProperty("rows_read")>]
                abstract rowsRead: float with get, set

                [<EmitProperty("size_after")>]
                abstract sizeAfter: float with get, set

                abstract duration: float with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Run = | [<CompiledValue(true)>] True

        module rec DecompressionStream =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Format =
                | [<CompiledName("gzip")>] Gzip
                | [<CompiledName("deflate")>] Deflate
                | [<CompiledName("deflate-raw")>] DeflateRaw

        module rec DurableObjectFacets =
            type Get =
                abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket
                abstract fetch: input: U3<Request, URL, string> * ?init: RequestInit -> Promise<Global.Response>
                abstract Item: key: D1SessionBookmark -> option<obj>
                abstract catch: ?onrejected: option<obj> -> U2<'TResult, Promise<'TResult>> -> Promise<U2<'T, 'TResult>>

                abstract ``then``:
                    ?onfulfilled: 'T -> U2<'TResult1, Promise<'TResult1>> *
                    ?onrejected: option<obj> -> U2<'TResult2, Promise<'TResult2>> ->
                        Promise<U2<'TResult1, 'TResult2>>

                abstract Invoke:
                    [<ParamArray>] args: Get.Invoke.Args ->
                        U2<Typescript.CSSViewTransitionRule._Lit31, U2<Typescript.CSSViewTransitionRule._Lit3576, unit>>

        module rec DurableObjectNamespace =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit2 =
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
            type _Lit1 =
                | [<CompiledName("eu")>] Eu
                | [<CompiledName("fedramp")>] Fedramp
                | [<CompiledName("fedramp-high")>] FedrampHigh

            type Get =
                abstract name: option<D1SessionBookmark> with get
                abstract id: DurableObjectId with get
                abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket
                abstract fetch: input: U3<Request, URL, string> * ?init: RequestInit -> Promise<Global.Response>
                abstract Item: key: D1SessionBookmark -> option<obj>
                abstract catch: ?onrejected: option<obj> -> U2<'TResult, Promise<'TResult>> -> Promise<U2<'T, 'TResult>>

                abstract ``then``:
                    ?onfulfilled: 'T -> U2<'TResult1, Promise<'TResult1>> *
                    ?onrejected: option<obj> -> U2<'TResult2, Promise<'TResult2>> ->
                        Promise<U2<'TResult1, 'TResult2>>

                abstract Invoke:
                    [<ParamArray>] args: Get.Invoke.Args ->
                        U2<Typescript.CSSViewTransitionRule._Lit31, U2<Typescript.CSSViewTransitionRule._Lit3576, unit>>

        module rec EmailMessage =
            type _Lit1 =
                abstract prototype: EmailMessage with get, set

                abstract Create:
                    from: D1SessionBookmark * ``to``: D1SessionBookmark * raw: U2<ReadableStream<option<obj>>, string> ->
                        EmailMessage

        module rec ExportedHandler =
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

            type TailStream =
                abstract Invoke:
                    event: TailStream.TailEvent<TailStream.Onset> * env: 'Env * ctx: ExecutionContext<'Props> ->
                        U3<
                            TailStream.TailEvent<'Event> -> option<Promise<unit>>,
                            TailStream.TailEventHandlerObject._Lit1,
                            Promise<TailStream.TailEventHandlerType>
                         >

            type Trace =
                abstract Invoke:
                    traces: ResizeArray<TraceItem> * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

            type Tail =
                abstract Invoke:
                    events: ResizeArray<TraceItem> * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

            type Connect =
                abstract Invoke: socket: Socket * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

            type Fetch =
                abstract Invoke:
                    request: Request * env: 'Env * ctx: ExecutionContext<'Props> ->
                        U2<Global.Response, Promise<Global.Response>>

            type Scheduled =
                abstract Invoke:
                    controller: ScheduledController * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        module rec Flagship =
            type _Lit1 =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec ImageTransform =
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

        module rec ImagesBinding =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit8 =
                | [<CompiledName("asc")>] Asc
                | [<CompiledName("desc")>] Desc

            type _Lit1 =
                abstract encoding: option<_Lit1.Encoding> with get, set

        module rec IncomingRequestCfPropertiesTLSClientAuth =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type CertVerified =
                | SUCCESS
                | [<CompiledName("FAILED:self signed certificate")>] ``FAILED:selfsignedcertificate``
                | [<CompiledName("FAILED:unable to verify the first certificate")>] ``FAILED:unabletoverifythefirstcertificate``
                | [<CompiledName("FAILED:certificate is not yet valid")>] ``FAILED:certificateisnotyetvalid``
                | [<CompiledName("FAILED:certificate has expired")>] ``FAILED:certificatehasexpired``
                | FAILED

        module rec KVNamespace =
            module rec Get =
                type Options =
                    abstract cacheTtl: option<float> with get, set

                    [<EmitProperty("type")>]
                    abstract ``type``: option<unit> with get, set

            type _Lit5 =
                abstract cacheStatus: option<string> with get, set
                abstract keys: ResizeArray<KVNamespaceListKey<'Metadata, 'Key>> with get, set

                [<EmitProperty("list_complete")>]
                abstract listComplete: _Lit5.ListComplete with get, set

            type _Lit4 =
                abstract cacheStatus: option<string> with get, set
                abstract cursor: D1SessionBookmark with get, set
                abstract keys: ResizeArray<KVNamespaceListKey<'Metadata, 'Key>> with get, set

                [<EmitProperty("list_complete")>]
                abstract listComplete: _Lit4.ListComplete with get, set

        module rec LoopbackForExport =
            type T =
                abstract Create: [<ParamArray>] args: ResizeArray<option<obj>> -> Rpc.EntrypointBranded

            type _Lit9 =
                abstract props: option<'Props> with get, set

            type _Lit11 =
                abstract props: option<obj> with get, set

            type Invoke =
                abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket
                abstract fetch: input: U3<Request, URL, string> * ?init: RequestInit -> Promise<Global.Response>
                abstract Item: key: D1SessionBookmark -> option<obj>
                abstract catch: ?onrejected: option<obj> -> U2<'TResult, Promise<'TResult>> -> Promise<U2<'T, 'TResult>>

                abstract ``then``:
                    ?onfulfilled: 'T -> U2<'TResult1, Promise<'TResult1>> *
                    ?onrejected: option<obj> -> U2<'TResult2, Promise<'TResult2>> ->
                        Promise<U2<'TResult1, 'TResult2>>

                abstract Invoke:
                    [<ParamArray>] args: Invoke.Invoke.Args ->
                        U2<Typescript.CSSViewTransitionRule._Lit31, U2<Typescript.CSSViewTransitionRule._Lit3576, unit>>

        module rec MediaTransformationOutputOptions =
            type _Lit1 =
                abstract format: option<_Lit3> with get, set
                abstract imageCount: option<float> with get, set
                abstract duration: option<D1SessionBookmark> with get, set
                abstract time: option<D1SessionBookmark> with get, set
                abstract audio: option<bool> with get, set
                abstract mode: option<_Lit2> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit2 =
                | [<CompiledName("video")>] Video
                | [<CompiledName("spritesheet")>] Spritesheet
                | [<CompiledName("frame")>] Frame
                | [<CompiledName("audio")>] Audio

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit3 =
                | [<CompiledName("jpg")>] Jpg
                | [<CompiledName("png")>] Png
                | [<CompiledName("m4a")>] M4a

        module rec MessageSendRequest =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit1 =
                | [<CompiledName("text")>] Text
                | [<CompiledName("json")>] Json
                | [<CompiledName("bytes")>] Bytes
                | [<CompiledName("v8")>] V8

        module rec PagesFunction =
            type _Lit6 =
                abstract ASSETS: _Lit8 with get, set

        module rec PagesPluginFunction =
            module rec Invoke =
                type Context =
                    abstract pluginArgs: 'PluginArgs with get, set
                    abstract data: 'Data with get, set
                    abstract params: WebAssembly.ModuleImports with get, set
                    abstract env: PagesFunction._Lit6 with get, set
                    abstract functionPath: D1SessionBookmark with get, set
                    abstract request: Request with get, set
                    abstract next: ?input: RequestInfo * ?init: RequestInit -> Promise<Global.Response>
                    abstract passThroughOnException: unit -> unit
                    abstract waitUntil: promise: Promise<option<obj>> -> unit

        module rec R2Objects =
            type _Lit5 =
                abstract length: option<float> with get, set
                abstract offset: float with get, set

            type _Lit6 =
                abstract length: float with get, set
                abstract offset: option<float> with get, set

            type _Lit7 =
                abstract suffix: float with get, set

        module rec RemoveEventListener =
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

        module rec RequestInfo =
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
                abstract country: option<Typescript.CSSViewTransitionRule._Lit3568> with get, set
                abstract hostMetadata: option<'HostMetadata> with get, set
                /// <deprecated />
                abstract clientTrustScore: float with get, set
                abstract botManagement: IncomingRequestCfPropertiesBotManagementBase with get, set
                abstract botManagement: Typescript.CSSViewTransitionRule._Lit3566 with get, set
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
                abstract edgeRequestKeepAliveStatus: IncomingRequestCfPropertiesEdgeRequestKeepAliveStatus with get, set
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

        module rec RequestInitCfPropertiesImage =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Quality =
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium-low")>] MediumLow
                | [<CompiledName("medium-high")>] MediumHigh
                | [<CompiledName("high")>] High

        module rec RoleScopedChatInput =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Role =
                | [<CompiledName("user")>] User
                | [<CompiledName("assistant")>] Assistant
                | [<CompiledName("system")>] System
                | [<CompiledName("tool")>] Tool

        module rec Rpc =
            module rec Serializable =
                type T =
                    [<EmitProperty("[__RPC_STUB_BRAND]")>]
                    abstract __RPC_STUB_BRAND: 'T with get, set

                    abstract symbolDispose: unit -> unit
                    abstract dup: unit -> 'StubBase
                    abstract Item: key: D1SessionBookmark -> option<obj>

            type MaybeProvider =
                abstract Item: key: D1SessionBookmark -> option<obj>
                abstract catch: ?onrejected: option<obj> -> U2<'TResult, Promise<'TResult>> -> Promise<U2<'T, 'TResult>>

                abstract ``then``:
                    ?onfulfilled: 'T -> U2<'TResult1, Promise<'TResult1>> *
                    ?onrejected: option<obj> -> U2<'TResult2, Promise<'TResult2>> ->
                        Promise<U2<'TResult1, 'TResult2>>

                abstract Invoke:
                    [<ParamArray>] args: MaybeProvider.Invoke.Args ->
                        U2<Typescript.CSSViewTransitionRule._Lit31, U2<Typescript.CSSViewTransitionRule._Lit3576, unit>>

            [<Import("@cloudflare/workers-types.Rpc", "WorkflowEntrypointBranded")>]
            type WorkflowEntrypointBranded =
                [<EmitProperty("[__WORKFLOW_ENTRYPOINT_BRAND]")>]
                abstract __WORKFLOW_ENTRYPOINT_BRAND: unit with get, set

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
                        exn,
                        RegExp,
                        ReadableStream<Uint8Array<ArrayBufferLike>>,
                        WritableStream<Uint8Array<ArrayBufferLike>>,
                        Request,
                        Global.Response,
                        Headers,
                        bool,
                        float,
                        string
                     >
                 >

            type MaybeDisposable<'T> = obj
            type Stubify<'T> = obj
            type Stubable = obj

            [<Import("@cloudflare/workers-types.Rpc", "UnstubifyAll")>]
            type UnstubifyAll<'A when 'A :> ResizeArray<option<obj>>> =
                [<EmitProperty("[Symbol.unscopables]")>]
                abstract symbolUnscopables: Typescript.CSSViewTransitionRule._Lit29 with get

                abstract length: float with get, set
                abstract symbolIterator: unit -> System.Collections.Generic.IEnumerator<'T>
                abstract ``with``: index: float * value: 'T -> ResizeArray
                abstract toSpliced: start: float * deleteCount: float * [<ParamArray>] items: ResizeArray -> ResizeArray
                abstract toSorted: ?compareFn: 'T -> 'T -> float -> ResizeArray
                abstract toReversed: unit -> ResizeArray
                abstract findLastIndex: predicate: Typescript.CSSViewTransitionRule._Lit18 * ?thisArg: obj -> float
                abstract findLast: predicate: Typescript.CSSViewTransitionRule._Lit17 * ?thisArg: obj -> option<'S>
                abstract at: index: float -> option<'T>

                abstract flat:
                    this: 'A * ?depth: 'D ->
                        ResizeArray<
                            proptypekey<
                                Typescript.CSSViewTransitionRule._Lit28,
                                U2<UnstubifyAll.Flat, UnstubifyAll.Flat>
                             >
                         >

                abstract flatMap: callback: Typescript.CSSViewTransitionRule._Lit26 * ?thisArg: 'This -> ResizeArray<'U>
                abstract includes: searchElement: 'T * ?fromIndex: float -> bool
                abstract values: unit -> System.Collections.Generic.IEnumerator<'T>
                abstract keys: unit -> System.Collections.Generic.IEnumerator<float>
                abstract entries: unit -> System.Collections.Generic.IEnumerator<float * 'T>
                abstract copyWithin: target: float * start: float * ?``end``: float -> 'Array
                abstract fill: value: 'T * ?start: float * ?``end``: float -> 'Array
                abstract findIndex: predicate: Typescript.CSSViewTransitionRule._Lit25 * ?thisArg: obj -> float
                abstract find: predicate: Typescript.CSSViewTransitionRule._Lit23 * ?thisArg: obj -> option<'S>
                abstract reduceRight: callbackfn: Typescript.CSSViewTransitionRule._Lit21 -> 'T
                abstract reduce: callbackfn: Typescript.CSSViewTransitionRule._Lit21 -> 'T
                abstract filter: predicate: Typescript.CSSViewTransitionRule._Lit17 * ?thisArg: obj -> ResizeArray<'S>
                abstract map: callbackfn: Typescript.CSSViewTransitionRule._Lit20 * ?thisArg: obj -> ResizeArray<'U>
                abstract forEach: callbackfn: Typescript.CSSViewTransitionRule._Lit19 * ?thisArg: obj -> unit
                abstract some: predicate: Typescript.CSSViewTransitionRule._Lit18 * ?thisArg: obj -> bool
                abstract every: predicate: Typescript.CSSViewTransitionRule._Lit17 * ?thisArg: obj -> bool
                abstract lastIndexOf: searchElement: 'T * ?fromIndex: float -> float
                abstract indexOf: searchElement: 'T * ?fromIndex: float -> float
                abstract unshift: [<ParamArray>] items: ResizeArray -> float
                abstract splice: start: float * ?deleteCount: float -> ResizeArray
                abstract sort: ?compareFn: 'T -> 'T -> float -> 'Array
                abstract slice: ?start: float * ?``end``: float -> ResizeArray
                abstract shift: unit -> option<'T>
                abstract reverse: unit -> ResizeArray
                abstract join: ?separator: D1SessionBookmark -> D1SessionBookmark
                abstract concat: [<ParamArray>] items: ResizeArray<ConcatArray<'T>> -> ResizeArray
                abstract push: [<ParamArray>] items: ResizeArray -> float
                abstract pop: unit -> option<'T>
                abstract toLocaleString: unit -> D1SessionBookmark
                abstract toString: unit -> D1SessionBookmark

            type Unstubify<'T> =
                U2<
                    'V,
                    U2<
                        Map<
                            U2<
                                'V,
                                U2<
                                    option<obj>,
                                    U2<
                                        Set<U2<'V, U2<option<obj>, option<obj>>>>,
                                        U2<
                                            ResizeArray<U2<'V, U2<option<obj>, option<obj>>>>,
                                            U2<
                                                System.Collections.Generic.IReadOnlyList<
                                                    U2<'V, U2<option<obj>, option<obj>>>
                                                 >,
                                                U2<'T, U2<WebAssembly.ModuleImports, 'T>>
                                             >
                                         >
                                     >
                                 >
                             >,
                            U2<'V, U2<option<obj>, option<obj>>>
                         >,
                        U2<
                            Set<U2<'V, U2<option<obj>, option<obj>>>>,
                            U2<
                                ResizeArray<U2<'V, U2<option<obj>, option<obj>>>>,
                                U2<
                                    System.Collections.Generic.IReadOnlyList<U2<'V, U2<option<obj>, option<obj>>>>,
                                    U2<'T, U2<WebAssembly.ModuleImports, 'T>>
                                 >
                             >
                         >
                     >
                 >

            type MaybeCallableProvider<'T> = obj
            type MethodOrProperty<'V> = obj

            [<Import("@cloudflare/workers-types.Rpc", "Stub")>]
            type Stub<'T when 'T :> Stubable> =
                [<EmitProperty("[__RPC_STUB_BRAND]")>]
                abstract __RPC_STUB_BRAND: 'T with get, set

                abstract symbolDispose: unit -> unit
                abstract dup: unit -> 'StubBase
                abstract Item: key: D1SessionBookmark -> option<obj>
                abstract catch: ?onrejected: option<obj> -> U2<'TResult, Promise<'TResult>> -> Promise<U2<'T, 'TResult>>

                abstract ``then``:
                    ?onfulfilled: 'T -> U2<'TResult1, Promise<'TResult1>> *
                    ?onrejected: option<obj> -> U2<'TResult2, Promise<'TResult2>> ->
                        Promise<U2<'TResult1, 'TResult2>>

                abstract Invoke:
                    [<ParamArray>] args: Stub.Invoke.Args ->
                        U2<Typescript.CSSViewTransitionRule._Lit31, U2<Typescript.CSSViewTransitionRule._Lit3576, unit>>

            [<Import("@cloudflare/workers-types.Rpc", "StubBase")>]
            type StubBase<'T when 'T :> Stubable> =
                inherit Disposable

                [<EmitProperty("[__RPC_STUB_BRAND]")>]
                abstract __RPC_STUB_BRAND: 'T with get, set

                abstract dup: unit -> 'StubBase

            type Result<'R> =
                U2<Typescript.CSSViewTransitionRule._Lit31, U2<Typescript.CSSViewTransitionRule._Lit3576, unit>>

            type Serializable<'T> =
                option<
                    U31<
                        Serializable,
                        RegExp,
                        exn,
                        Global.Response,
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
                        Request,
                        Map<
                            U2<
                                option<
                                    U31<
                                        Serializable,
                                        RegExp,
                                        exn,
                                        Global.Response,
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
                                        Request,
                                        RpcTargetBranded,
                                        Typescript.CSSViewTransitionRule._Lit10,
                                        Serializable,
                                        Map<
                                            U2<
                                                option<
                                                    U31<
                                                        Serializable,
                                                        RegExp,
                                                        exn,
                                                        Global.Response,
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
                                                        Request,
                                                        RpcTargetBranded,
                                                        Typescript.CSSViewTransitionRule._Lit10,
                                                        Serializable,
                                                        Map<U2<option<obj>, unit>, U2<option<obj>, unit>>,
                                                        Set<U2<option<obj>, unit>>,
                                                        System.Collections.Generic.IReadOnlyList<U2<option<obj>, unit>>,
                                                        Typescript.CSSViewTransitionRule._Lit44,
                                                        string,
                                                        float
                                                     >
                                                 >,
                                                unit
                                             >,
                                            U2<option<obj>, unit>
                                         >,
                                        Set<U2<option<obj>, unit>>,
                                        System.Collections.Generic.IReadOnlyList<U2<option<obj>, unit>>,
                                        Typescript.CSSViewTransitionRule._Lit44,
                                        string,
                                        float
                                     >
                                 >,
                                unit
                             >,
                            U2<
                                option<
                                    U31<
                                        Serializable,
                                        RegExp,
                                        exn,
                                        Global.Response,
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
                                        Request,
                                        RpcTargetBranded,
                                        Typescript.CSSViewTransitionRule._Lit10,
                                        Serializable,
                                        Map<
                                            U2<
                                                option<
                                                    U31<
                                                        Serializable,
                                                        RegExp,
                                                        exn,
                                                        Global.Response,
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
                                                        Request,
                                                        RpcTargetBranded,
                                                        Typescript.CSSViewTransitionRule._Lit10,
                                                        Serializable,
                                                        Map<U2<option<obj>, unit>, U2<option<obj>, unit>>,
                                                        Set<U2<option<obj>, unit>>,
                                                        System.Collections.Generic.IReadOnlyList<U2<option<obj>, unit>>,
                                                        Typescript.CSSViewTransitionRule._Lit44,
                                                        string,
                                                        float
                                                     >
                                                 >,
                                                unit
                                             >,
                                            U2<option<obj>, unit>
                                         >,
                                        Set<U2<option<obj>, unit>>,
                                        System.Collections.Generic.IReadOnlyList<U2<option<obj>, unit>>,
                                        Typescript.CSSViewTransitionRule._Lit44,
                                        string,
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
                                        Serializable,
                                        RegExp,
                                        exn,
                                        Global.Response,
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
                                        Request,
                                        RpcTargetBranded,
                                        Typescript.CSSViewTransitionRule._Lit10,
                                        Serializable,
                                        Map<
                                            U2<
                                                option<
                                                    U31<
                                                        Serializable,
                                                        RegExp,
                                                        exn,
                                                        Global.Response,
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
                                                        Request,
                                                        RpcTargetBranded,
                                                        Typescript.CSSViewTransitionRule._Lit10,
                                                        Serializable,
                                                        Map<U2<option<obj>, unit>, U2<option<obj>, unit>>,
                                                        Set<U2<option<obj>, unit>>,
                                                        System.Collections.Generic.IReadOnlyList<U2<option<obj>, unit>>,
                                                        Typescript.CSSViewTransitionRule._Lit44,
                                                        string,
                                                        float
                                                     >
                                                 >,
                                                unit
                                             >,
                                            U2<option<obj>, unit>
                                         >,
                                        Set<U2<option<obj>, unit>>,
                                        System.Collections.Generic.IReadOnlyList<U2<option<obj>, unit>>,
                                        Typescript.CSSViewTransitionRule._Lit44,
                                        string,
                                        float
                                     >
                                 >,
                                unit
                             >
                         >,
                        System.Collections.Generic.IReadOnlyList<
                            U2<
                                option<
                                    U31<
                                        Serializable,
                                        RegExp,
                                        exn,
                                        Global.Response,
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
                                        Request,
                                        RpcTargetBranded,
                                        Typescript.CSSViewTransitionRule._Lit10,
                                        Serializable,
                                        Map<
                                            U2<
                                                option<
                                                    U31<
                                                        Serializable,
                                                        RegExp,
                                                        exn,
                                                        Global.Response,
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
                                                        Request,
                                                        RpcTargetBranded,
                                                        Typescript.CSSViewTransitionRule._Lit10,
                                                        Serializable,
                                                        Map<U2<option<obj>, unit>, U2<option<obj>, unit>>,
                                                        Set<U2<option<obj>, unit>>,
                                                        System.Collections.Generic.IReadOnlyList<U2<option<obj>, unit>>,
                                                        Typescript.CSSViewTransitionRule._Lit44,
                                                        string,
                                                        float
                                                     >
                                                 >,
                                                unit
                                             >,
                                            U2<option<obj>, unit>
                                         >,
                                        Set<U2<option<obj>, unit>>,
                                        System.Collections.Generic.IReadOnlyList<U2<option<obj>, unit>>,
                                        Typescript.CSSViewTransitionRule._Lit44,
                                        string,
                                        float
                                     >
                                 >,
                                unit
                             >
                         >,
                        Typescript.CSSViewTransitionRule._Lit44,
                        Serializable,
                        RpcTargetBranded,
                        Typescript.CSSViewTransitionRule._Lit10,
                        string,
                        float
                     >
                 >

            [<Import("@cloudflare/workers-types.Rpc", "Provider")>]
            type Provider<'Reserved, 'T when 'Reserved :> D1SessionBookmark and 'T :> obj> =
                abstract Item: key: D1SessionBookmark -> option<obj>
                abstract catch: ?onrejected: option<obj> -> U2<'TResult, Promise<'TResult>> -> Promise<U2<'T, 'TResult>>

                abstract ``then``:
                    ?onfulfilled: 'T -> U2<'TResult1, Promise<'TResult1>> *
                    ?onrejected: option<obj> -> U2<'TResult2, Promise<'TResult2>> ->
                        Promise<U2<'TResult1, 'TResult2>>

                abstract Invoke:
                    [<ParamArray>] args: Provider.Invoke.Args ->
                        U2<Typescript.CSSViewTransitionRule._Lit31, U2<Typescript.CSSViewTransitionRule._Lit3576, unit>>

            [<Import("@cloudflare/workers-types.Rpc", "DurableObjectBranded")>]
            type DurableObjectBranded =
                [<EmitProperty("[__DURABLE_OBJECT_BRAND]")>]
                abstract __DURABLE_OBJECT_BRAND: unit with get, set

            [<Import("@cloudflare/workers-types.Rpc", "WorkerEntrypointBranded")>]
            type WorkerEntrypointBranded =
                [<EmitProperty("[__WORKER_ENTRYPOINT_BRAND]")>]
                abstract __WORKER_ENTRYPOINT_BRAND: unit with get, set

            [<Import("@cloudflare/workers-types.Rpc", "RpcTargetBranded")>]
            type RpcTargetBranded =
                [<EmitProperty("[__RPC_TARGET_BRAND]")>]
                abstract __RPC_TARGET_BRAND: unit with get, set

            type EntrypointBranded = obj

        module rec RpcStub =
            module rec _Lit1 =
                module rec Create =
                    module rec Invoke =
                        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                        type Args =
                            | [<CompiledName("done")>] Done
                            | [<CompiledName("recur")>] Recur

                type Create =
                    [<EmitProperty("[__RPC_STUB_BRAND]")>]
                    abstract __RPC_STUB_BRAND: 'T with get, set

                    abstract symbolDispose: unit -> unit
                    abstract dup: unit -> 'StubBase
                    abstract Item: key: D1SessionBookmark -> option<obj>

                    abstract catch:
                        ?onrejected: option<obj> -> U2<'TResult, Promise<'TResult>> -> Promise<U2<'T, 'TResult>>

                    abstract ``then``:
                        ?onfulfilled: 'T -> U2<'TResult1, Promise<'TResult1>> *
                        ?onrejected: option<obj> -> U2<'TResult2, Promise<'TResult2>> ->
                            Promise<U2<'TResult1, 'TResult2>>

                    abstract Invoke:
                        [<ParamArray>] args: Create.Invoke.Args ->
                            U2<
                                Typescript.CSSViewTransitionRule._Lit31,
                                U2<Typescript.CSSViewTransitionRule._Lit3576, unit>
                             >

            type _Lit1 =
                abstract Create: value: 'T -> CloudflareWorkersModule.RpcStub

        module rec ServiceWorkerGlobalScope =
            type _Lit2 =
                abstract Invoke: [<ParamArray>] args: ResizeArray<option<obj>> -> unit

            type _Lit3 =
                abstract Invoke: [<ParamArray>] args: 'Args -> unit

        module rec StreamCaption =
            type _Lit1 =
                abstract status: option<StreamDownloadStatus> with get, set
                abstract language: D1SessionBookmark with get, set
                abstract label: D1SessionBookmark with get, set
                abstract generated: option<bool> with get, set

        module rec StreamDownloadGetResponse =
            type _Lit2 =
                abstract url: option<D1SessionBookmark> with get, set
                abstract status: StreamDownloadStatus with get, set
                abstract percentComplete: float with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit3 =
                | [<CompiledName("error")>] Error
                | [<CompiledName("ready")>] Ready
                | [<CompiledName("inprogress")>] Inprogress

        module rec StreamDownloadStatus =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit1 =
                | [<CompiledName("ready")>] Ready
                | [<CompiledName("inprogress")>] Inprogress
                | [<CompiledName("error")>] Error

        module rec StreamDownloadType =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit1 =
                | [<CompiledName("default")>] Default
                | [<CompiledName("audio")>] Audio

        module rec StreamPaginationComparison =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit1 =
                | [<CompiledName("eq")>] Eq
                | [<CompiledName("gt")>] Gt
                | [<CompiledName("gte")>] Gte
                | [<CompiledName("lt")>] Lt
                | [<CompiledName("lte")>] Lte

        module rec StreamWatermark =
            type _Lit1 =
                abstract position: StreamWatermarkPosition with get, set
                abstract scale: float with get, set
                abstract padding: float with get, set
                abstract opacity: float with get, set
                abstract name: D1SessionBookmark with get, set
                abstract downloadedFrom: option<string> with get, set
                abstract created: D1SessionBookmark with get, set
                abstract width: float with get, set
                abstract height: float with get, set
                abstract size: float with get, set
                abstract id: D1SessionBookmark with get, set

        module rec StreamWatermarkCreateParams =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit2 =
                | [<CompiledName("upperRight")>] UpperRight
                | [<CompiledName("upperLeft")>] UpperLeft
                | [<CompiledName("lowerLeft")>] LowerLeft
                | [<CompiledName("lowerRight")>] LowerRight
                | [<CompiledName("center")>] Center

            type _Lit1 =
                abstract position: option<StreamWatermarkPosition> with get, set
                abstract scale: option<float> with get, set
                abstract padding: option<float> with get, set
                abstract opacity: option<float> with get, set
                abstract name: option<D1SessionBookmark> with get, set

        module rec TailStream =
            module rec EventOutcome =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type _Lit1 =
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

            module rec Log =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type _Lit1 =
                    | [<CompiledName("debug")>] Debug
                    | [<CompiledName("error")>] Error
                    | [<CompiledName("info")>] Info
                    | [<CompiledName("log")>] Log
                    | [<CompiledName("warn")>] Warn

            module rec Outcome =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type _Lit1 =
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

            module rec TailEventHandlerObject =
                type _Lit1 =
                    abstract attributes: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

                    [<EmitProperty("return")>]
                    abstract ``return``: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

                    abstract log: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

                    [<EmitProperty("exception")>]
                    abstract ``exception``: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

                    abstract diagnosticChannel: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set
                    abstract spanClose: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set
                    abstract spanOpen: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set
                    abstract outcome: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type EmailEventInfo = | [<CompiledName("email")>] Email

            [<Import("@cloudflare/workers-types.TailStream", "HibernatableWebSocketEventInfo")>]
            type HibernatableWebSocketEventInfo =
                abstract info:
                    U3<
                        HibernatableWebSocketEventInfoClose,
                        HibernatableWebSocketEventInfoError,
                        HibernatableWebSocketEventInfoMessage
                     > with get

                [<EmitProperty("type")>]
                abstract ``type``: HibernatableWebSocketEventInfo.Type with get

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type HibernatableWebSocketEventInfoMessage = | [<CompiledName("message")>] Message

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Log = | [<CompiledName("log")>] Log

            [<Import("@cloudflare/workers-types.TailStream", "TracePreviewInfo")>]
            type TracePreviewInfo =
                abstract name: D1SessionBookmark with get
                abstract slug: D1SessionBookmark with get
                abstract id: D1SessionBookmark with get

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type CustomEventInfo = | [<CompiledName("custom")>] Custom

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type FetchResponseInfo = | [<CompiledName("fetch")>] Fetch

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type FetchEventInfo = | [<CompiledName("fetch")>] Fetch

            [<Import("@cloudflare/workers-types.TailStream", "ScheduledEventInfo")>]
            type ScheduledEventInfo =
                abstract cron: D1SessionBookmark with get
                abstract scheduledTime: Date with get

                [<EmitProperty("type")>]
                abstract ``type``: ScheduledEventInfo.Type with get

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type DroppedEventsDiagnostic = | [<CompiledName("droppedEvents")>] DroppedEvents

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

            [<Import("@cloudflare/workers-types.TailStream", "DiagnosticChannelEvent")>]
            type DiagnosticChannelEvent =
                abstract message: option<obj> with get
                abstract channel: D1SessionBookmark with get

                [<EmitProperty("type")>]
                abstract ``type``: DiagnosticChannelEvent.Type with get

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
                abstract scriptTags: option<ResizeArray<D1SessionBookmark>> with get
                abstract scriptName: option<D1SessionBookmark> with get
                abstract executionModel: D1SessionBookmark with get
                abstract entrypoint: option<D1SessionBookmark> with get
                abstract dispatchNamespace: option<D1SessionBookmark> with get
                abstract spanId: D1SessionBookmark with get
                abstract attributes: ResizeArray<Attribute> with get

                [<EmitProperty("type")>]
                abstract ``type``: Onset.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "TailEvent")>]
            type TailEvent<'Event when 'Event :> EventType> =
                abstract event: 'Event with get
                abstract sequence: float with get
                abstract timestamp: Date with get
                abstract spanContext: SpanContext with get
                abstract invocationId: D1SessionBookmark with get

            [<Import("@cloudflare/workers-types.TailStream", "ScriptVersion")>]
            type ScriptVersion =
                abstract message: option<D1SessionBookmark> with get
                abstract tag: option<D1SessionBookmark> with get
                abstract id: D1SessionBookmark with get

            [<Import("@cloudflare/workers-types.TailStream", "TailEventHandler")>]
            type TailEventHandler<'Event when 'Event :> EventType> =
                abstract Invoke: event: TailEvent<'Event> -> option<Promise<unit>>

            [<Import("@cloudflare/workers-types.TailStream", "Attribute")>]
            type Attribute =
                abstract value:
                    U6<ResizeArray<D1SessionBookmark>, ResizeArray<bool>, ResizeArray<float>, string, bool, float> with get

                abstract name: D1SessionBookmark with get

            type TailEventHandlerType = U2<TailEvent<'Event> -> option<Promise<unit>>, TailEventHandlerObject._Lit1>

            [<Import("@cloudflare/workers-types.TailStream", "QueueEventInfo")>]
            type QueueEventInfo =
                abstract batchSize: float with get
                abstract queueName: D1SessionBookmark with get

                [<EmitProperty("type")>]
                abstract ``type``: QueueEventInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "TraceEventInfo")>]
            type TraceEventInfo =
                abstract traces: ResizeArray<option<string>> with get

                [<EmitProperty("type")>]
                abstract ``type``: TraceEventInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "ConnectEventInfo")>]
            type ConnectEventInfo =
                [<EmitProperty("type")>]
                abstract ``type``: ConnectEventInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "Attributes")>]
            type Attributes =
                abstract info: ResizeArray<Attribute> with get

                [<EmitProperty("type")>]
                abstract ``type``: Attributes.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "HibernatableWebSocketEventInfoError")>]
            type HibernatableWebSocketEventInfoError =
                [<EmitProperty("type")>]
                abstract ``type``: HibernatableWebSocketEventInfoError.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "AlarmEventInfo")>]
            type AlarmEventInfo =
                abstract scheduledTime: Date with get

                [<EmitProperty("type")>]
                abstract ``type``: AlarmEventInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "SpanContext")>]
            type SpanContext =
                abstract spanId: option<D1SessionBookmark> with get
                abstract traceId: D1SessionBookmark with get

            [<Import("@cloudflare/workers-types.TailStream", "SpanOpen")>]
            type SpanOpen =
                abstract info: option<U3<FetchEventInfo, JsRpcEventInfo, Attributes>> with get
                abstract spanId: D1SessionBookmark with get
                abstract name: D1SessionBookmark with get

                [<EmitProperty("type")>]
                abstract ``type``: SpanOpen.Type with get

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Return = | [<CompiledName("return")>] Return

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type StreamDiagnostic = | [<CompiledName("streamDiagnostic")>] StreamDiagnostic

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type SpanClose = | [<CompiledName("spanClose")>] SpanClose

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Outcome = | [<CompiledName("outcome")>] Outcome

            [<Import("@cloudflare/workers-types.TailStream", "HibernatableWebSocketEventInfoClose")>]
            type HibernatableWebSocketEventInfoClose =
                abstract wasClean: bool with get
                abstract code: float with get

                [<EmitProperty("type")>]
                abstract ``type``: HibernatableWebSocketEventInfoClose.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "Header")>]
            type Header =
                abstract value: D1SessionBookmark with get
                abstract name: D1SessionBookmark with get

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Exception = | [<CompiledName("exception")>] Exception

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type JsRpcEventInfo = | [<CompiledName("jsrpc")>] Jsrpc

            [<Import("@cloudflare/workers-types.TailStream", "TailEventHandlerObject")>]
            type TailEventHandlerObject =
                abstract attributes: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

                [<EmitProperty("return")>]
                abstract ``return``: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

                abstract log: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

                [<EmitProperty("exception")>]
                abstract ``exception``: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

                abstract diagnosticChannel: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract spanClose: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract spanOpen: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract outcome: option<TailEvent<'Event> -> option<Promise<unit>>> with get, set

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

        module rec ToMarkdownService =
            type _Lit2 =
                abstract conversionOptions: option<ConversionOptions> with get, set
                abstract extraHeaders: option<obj> with get, set
                abstract gateway: option<GatewayOptions> with get, set

            type _Lit5 =
                abstract backoff: option<CloudflareWorkersModule.WorkflowBackoff> with get, set
                abstract retryDelayMs: option<float> with get, set
                abstract maxAttempts: option<_Lit6> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit12 =
                | [<CompiledName("en")>] En
                | [<CompiledName("es")>] Es
                | [<CompiledName("fr")>] Fr
                | [<CompiledName("it")>] It
                | [<CompiledName("pt")>] Pt
                | [<CompiledName("de")>] De

            type _Lit11 =
                abstract descriptionLanguage: option<_Lit12> with get, set

            type _Lit6 =
                | ``1`` = 1
                | ``2`` = 2
                | ``3`` = 3
                | ``4`` = 4
                | ``5`` = 5

            type _Lit17 =
                abstract metadata: option<bool> with get, set
                abstract images: option<EmbeddedImageConversionOptions> with get, set

            type _Lit16 =
                abstract maxConvertedImages: option<float> with get, set
                abstract convert: option<bool> with get, set
                abstract descriptionLanguage: option<_Lit12> with get, set

            type _Lit1 =
                abstract blob: Blob with get, set
                abstract name: D1SessionBookmark with get, set

            type _Lit15 =
                abstract images: option<EmbeddedImageConversionOptions> with get, set

            type _Lit3 =
                abstract retries: option<GatewayRetries> with get, set
                abstract requestTimeoutMs: option<float> with get, set
                abstract eventId: option<D1SessionBookmark> with get, set
                abstract collectLog: option<bool> with get, set
                abstract metadata: option<WebAssembly.ModuleImports> with get, set
                abstract skipCache: option<bool> with get, set
                abstract cacheTtl: option<float> with get, set
                abstract cacheKey: option<D1SessionBookmark> with get, set
                abstract id: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit7 =
                | [<CompiledName("constant")>] Constant
                | [<CompiledName("linear")>] Linear
                | [<CompiledName("exponential")>] Exponential

            type _Lit8 =
                abstract pdf: option<_Lit17> with get, set
                abstract image: option<ImageConversionOptions> with get, set
                abstract docx: option<_Lit15> with get, set
                abstract html: option<_Lit9> with get, set

            type _Lit9 =
                abstract cssSelector: option<D1SessionBookmark> with get, set
                abstract hostname: option<D1SessionBookmark> with get, set
                abstract images: option<_Lit10> with get, set

        module rec Vectorize =
            type _Lit5 =
                abstract Item: key: D1SessionBookmark -> option<U5<_Lit5.Item, _Lit7, _Lit9, string, float>>

        module rec VectorizeQueryOptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ReturnMetadata =
                | [<CompiledName("all")>] All
                | [<CompiledName("indexed")>] Indexed
                | [<CompiledName("none")>] None

        module rec VectorizeVectorMetadataFilter =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Item =
                | [<CompiledValue(false)>] False
                | [<CompiledValue(true)>] True

        module rec WebAssembly =
            [<Import("@cloudflare/workers-types.WebAssembly", "Table"); AbstractClass; AllowNullLiteral>]
            type Table private () =
                [<EmitConstructor>]
                abstract Create: descriptor: WebAssembly.TableDescriptor * ?value: obj -> Table

                abstract length: float with get
                abstract set: index: float * ?value: obj -> unit
                abstract grow: delta: float * ?value: obj -> float
                abstract get: index: float -> option<obj>

            [<Import("@cloudflare/workers-types.WebAssembly", "CompileError"); AbstractClass; AllowNullLiteral>]
            type CompileError private () =
                inherit exn()

                [<EmitConstructor>]
                abstract Create: ?message: D1SessionBookmark -> CompileError

            [<Import("@cloudflare/workers-types.WebAssembly", "RuntimeError"); AbstractClass; AllowNullLiteral>]
            type RuntimeError private () =
                inherit exn()

                [<EmitConstructor>]
                abstract Create: ?message: D1SessionBookmark -> RuntimeError

            type Exports =
                abstract Item: key: D1SessionBookmark -> option<obj>

            [<Import("@cloudflare/workers-types.WebAssembly", "Global"); AbstractClass; AllowNullLiteral>]
            type Global private () =
                [<EmitConstructor>]
                abstract Create: descriptor: GlobalDescriptor<ValueType> * ?value: obj -> Global

                abstract value: option<obj> with get, set
                abstract valueOf: unit -> option<obj>

            [<Import("@cloudflare/workers-types.WebAssembly", "Instance"); AbstractClass; AllowNullLiteral>]
            type Instance private () =
                [<EmitConstructor>]
                abstract Create: ``module``: WebAssembly.Module * ?imports: WebAssembly.Imports -> Instance

                abstract exports: WebAssembly.Exports with get

            type ImportValue = U5<Function, WebAssembly.Table, WebAssembly.Memory, WebAssembly.Global<ValueType>, float>

            type Instantiate =
                abstract Invoke:
                    ``module``: WebAssembly.Module * ?imports: WebAssembly.Imports -> Promise<WebAssembly.Instance>

                abstract Invoke:
                    moduleObject: WebAssembly.Module * ?importObject: WebAssembly.Imports ->
                        Promise<WebAssembly.Instance>

                abstract Invoke:
                    bytes: BufferSource * ?importObject: WebAssembly.Imports ->
                        Promise<WebAssembly.WebAssemblyInstantiatedSource>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type TableKind =
                | [<CompiledName("anyfunc")>] Anyfunc
                | [<CompiledName("externref")>] Externref

            type ExportValue = U4<Function, WebAssembly.Global<ValueType>, WebAssembly.Memory, WebAssembly.Table>

            [<Import("@cloudflare/workers-types.WebAssembly", "Module"); AbstractClass; AllowNullLiteral>]
            type Module private () =
                abstract imports: ``module``: WebAssembly.Module -> ResizeArray<WebAssembly.ModuleImportDescriptor>
                abstract exports: ``module``: WebAssembly.Module -> ResizeArray<WebAssembly.ModuleExportDescriptor>

                abstract customSections:
                    ``module``: WebAssembly.Module * sectionName: D1SessionBookmark -> ResizeArray<ArrayBuffer>

            [<Import("@cloudflare/workers-types.WebAssembly", "Memory"); AbstractClass; AllowNullLiteral>]
            type Memory private () =
                [<EmitConstructor>]
                abstract Create: descriptor: WebAssembly.MemoryDescriptor -> Memory

                abstract buffer: ArrayBuffer with get
                abstract grow: delta: float -> float

            type Validate =
                abstract Invoke: bytes: BufferSource -> bool
                abstract Invoke: bytes: BufferSource -> bool

            type Imports = Imports
            type ModuleImports = obj

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ValueType =
                | [<CompiledName("anyfunc")>] Anyfunc
                | [<CompiledName("externref")>] Externref
                | [<CompiledName("f32")>] F32
                | [<CompiledName("f64")>] F64
                | [<CompiledName("i32")>] I32
                | [<CompiledName("i64")>] I64
                | [<CompiledName("v128")>] V128

            [<Import("@cloudflare/workers-types.WebAssembly", "GlobalDescriptor")>]
            type GlobalDescriptor<'T when 'T :> ValueType> =
                [<EmitProperty("mutable")>]
                abstract ``mutable``: option<bool> with get, set

                abstract value: ValueType with get, set
                abstract value: 'T with get, set

                [<EmitProperty("mutable")>]
                abstract ``mutable``: option<bool> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ImportExportKind =
                | [<CompiledName("function")>] Function
                | [<CompiledName("global")>] Global
                | [<CompiledName("memory")>] Memory
                | [<CompiledName("table")>] Table

            type IWebAssembly =
                [<Import("@cloudflare/workers-types.WebAssembly", "validate")>]
                static member validate(bytes: BufferSource) : bool = JS.undefined

                [<Import("@cloudflare/workers-types.WebAssembly", "validate")>]
                static member validate(bytes: BufferSource) : bool = JS.undefined

                [<Import("@cloudflare/workers-types.WebAssembly", "instantiate")>]
                static member instantiate
                    (``module``: WebAssembly.Module, ?imports: WebAssembly.Imports)
                    : Promise<WebAssembly.Instance> =
                    JS.undefined

                [<Import("@cloudflare/workers-types.WebAssembly", "instantiate")>]
                static member instantiate
                    (moduleObject: WebAssembly.Module, ?importObject: WebAssembly.Imports)
                    : Promise<WebAssembly.Instance> =
                    JS.undefined

                [<Import("@cloudflare/workers-types.WebAssembly", "instantiate")>]
                static member instantiate
                    (bytes: BufferSource, ?importObject: WebAssembly.Imports)
                    : Promise<WebAssembly.WebAssemblyInstantiatedSource> =
                    JS.undefined

        module rec WorkerStub =
            type GetEntrypoint =
                abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket
                abstract fetch: input: U3<Request, URL, string> * ?init: RequestInit -> Promise<Global.Response>
                abstract Item: key: D1SessionBookmark -> option<obj>
                abstract catch: ?onrejected: option<obj> -> U2<'TResult, Promise<'TResult>> -> Promise<U2<'T, 'TResult>>

                abstract ``then``:
                    ?onfulfilled: 'T -> U2<'TResult1, Promise<'TResult1>> *
                    ?onrejected: option<obj> -> U2<'TResult2, Promise<'TResult2>> ->
                        Promise<U2<'TResult1, 'TResult2>>

                abstract Invoke:
                    [<ParamArray>] args: GetEntrypoint.Invoke.Args ->
                        U2<Typescript.CSSViewTransitionRule._Lit31, U2<Typescript.CSSViewTransitionRule._Lit3576, unit>>

        module rec WorkflowDurationLabel =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type _Lit1 =
                | [<CompiledName("second")>] Second
                | [<CompiledName("minute")>] Minute
                | [<CompiledName("hour")>] Hour
                | [<CompiledName("day")>] Day
                | [<CompiledName("week")>] Week
                | [<CompiledName("month")>] Month
                | [<CompiledName("year")>] Year

        module rec ``Cloudflare:node`` =
            module rec HttpServerHandler =
                type _Lit1 =
                    abstract port: float with get, set

                type _Lit2 =
                    abstract port: option<float> with get, set

            type HttpServerHandler =
                abstract Invoke:
                    server: NodeStyleServer -> ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>>

                abstract Invoke:
                    options: HttpServerHandler._Lit1 ->
                        ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>>

                abstract Invoke: port: float -> ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>>

            [<Import("@cloudflare/workers-types.cloudflare:node", "NodeStyleServer")>]
            type NodeStyleServer =
                abstract address: unit -> HttpServerHandler._Lit2
                abstract listen: [<ParamArray>] args: ResizeArray<option<obj>> -> 'NodeStyleServer

            type ``Cloudflare:node`` =
                [<Import("@cloudflare/workers-types.cloudflare:node", "httpServerHandler")>]
                static member httpServerHandler
                    (options: HttpServerHandler._Lit1)
                    : ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>> =
                    JS.undefined

                [<Import("@cloudflare/workers-types.cloudflare:node", "httpServerHandler")>]
                static member httpServerHandler
                    (server: NodeStyleServer)
                    : ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>> =
                    JS.undefined

                [<Import("@cloudflare/workers-types.cloudflare:node", "httpServerHandler")>]
                static member httpServerHandler
                    (port: float)
                    : ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>> =
                    JS.undefined

        module rec ``Cloudflare:pipelines`` =
            module rec Pipeline =
                type I =
                    abstract Item: key: D1SessionBookmark -> option<obj>

            module rec PipelineBatchMetadata =
                type _Lit1 =
                    abstract pipelineName: D1SessionBookmark with get, set
                    abstract pipelineId: D1SessionBookmark with get, set

            module rec PipelineRecord =
                type I =
                    abstract Item: key: D1SessionBookmark -> option<obj>

            module rec PipelineTransformationEntrypoint =
                type I =
                    abstract Item: key: D1SessionBookmark -> option<obj>

            [<Import("@cloudflare/workers-types.cloudflare:pipelines", "PipelineBatchMetadata")>]
            type PipelineBatchMetadata =
                abstract pipelineName: D1SessionBookmark with get, set
                abstract pipelineId: D1SessionBookmark with get, set

            type PipelineRecord = obj

            [<Import("@cloudflare/workers-types.cloudflare:pipelines", "PipelineTransformationEntrypoint");
              AbstractClass;
              AllowNullLiteral>]
            type PipelineTransformationEntrypoint<'O, 'I, 'Env when 'O :> PipelineRecord and 'I :> PipelineRecord>
                private () =
                [<EmitConstructor>]
                abstract Create: ctx: ExecutionContext<option<obj>> * env: 'Env -> PipelineTransformationEntrypoint

                abstract ctx: ExecutionContext<option<obj>> with get, set
                abstract env: 'Env with get, set
                abstract run: records: ResizeArray<'I> * metadata: PipelineBatchMetadata -> Promise<ResizeArray<'O>>

            [<Import("@cloudflare/workers-types.cloudflare:pipelines", "Pipeline")>]
            type Pipeline<'T when 'T :> PipelineRecord> =
                abstract send: records: ResizeArray<'T> -> Promise<unit>

        module rec ``Cloudflare:workflows`` =
            [<Import("@cloudflare/workers-types.cloudflare:workflows", "NonRetryableError");
              AbstractClass;
              AllowNullLiteral>]
            type NonRetryableError private () =
                inherit exn()

                [<EmitConstructor>]
                abstract Create: message: D1SessionBookmark * ?name: D1SessionBookmark -> NonRetryableError

        [<Import("@cloudflare/workers-types", "AiSearchListItemsResponse")>]
        type AiSearchListItemsResponse =
            [<EmitProperty("result_info")>]
            abstract resultInfo: option<Ai._Lit49> with get, set

            abstract result: ResizeArray<AiSearchItemInfo> with get, set

        type AiCfAisingaporeGemmaSeaLionV427BItOutput =
            U4<
                AiCfAisingaporeGemmaSeaLionV427BItChatCompletionResponse,
                AiCfAisingaporeGemmaSeaLionV427BItTextCompletionResponse,
                AiCfAisingaporeGemmaSeaLionV427BItAsyncResponse,
                string
             >

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type StreamPaginationComparison =
            | [<CompiledName("eq")>] Eq
            | [<CompiledName("gt")>] Gt
            | [<CompiledName("gte")>] Gte
            | [<CompiledName("lt")>] Lt
            | [<CompiledName("lte")>] Lte

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

        type AiTextToSpeechOutput = obj

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseInputItemFunctionCallOutput = | [<CompiledName("function_call_output")>] FunctionCallOutput

        [<Import("@cloudflare/workers-types", "ScheduledController")>]
        type ScheduledController =
            abstract cron: D1SessionBookmark with get
            abstract scheduledTime: float with get
            abstract noRetry: unit -> unit

        [<Import("@cloudflare/workers-types", "MediaBinding")>]
        type MediaBinding =
            abstract input: media: ReadableStream<Uint8Array<ArrayBufferLike>> -> MediaTransformer

        type ResponseInputItem =
            U6<
                AiModels._Lit257,
                AiModels._Lit260,
                AiModels._Lit246,
                AiModels._Lit253,
                AiModels._Lit262,
                AiModels._Lit254
             >

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Meta_M2M100_1_2B"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfMetaM2M10012B private () =
            abstract postProcessedOutputs: AiCfMetaM2M10012BOutput with get, set
            abstract inputs: AiCfMetaM2M10012BInput with get, set

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesCloudflareForSaaSEnterprise")>]
        type IncomingRequestCfPropertiesCloudflareForSaaSEnterprise<'HostMetadata> =
            abstract hostMetadata: option<'HostMetadata> with get, set

        [<Import("@cloudflare/workers-types", "ImageUpdateOptions")>]
        type ImageUpdateOptions =
            abstract creator: option<D1SessionBookmark> with get, set
            abstract metadata: option<WebAssembly.ModuleImports> with get, set
            abstract requireSignedURLs: option<bool> with get, set

        type ChatCompletionMessageToolCall = obj

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseOutputRefusal = | [<CompiledName("refusal")>] Refusal

        [<Import("@cloudflare/workers-types", "RoleScopedChatInput")>]
        type RoleScopedChatInput =
            abstract name: option<D1SessionBookmark> with get, set
            abstract content: D1SessionBookmark with get, set
            abstract role: U2<RoleScopedChatInput.Role, Ai._Lit96> with get, set

        [<Import("@cloudflare/workers-types", "VectorizeVectorMutation")>]
        type VectorizeVectorMutation =
            abstract count: float with get, set
            abstract ids: ResizeArray<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "URLPattern"); AbstractClass; AllowNullLiteral>]
        type URLPattern private () =
            [<EmitConstructor>]
            abstract Create:
                ?input: U2<URLPatternInit, string> *
                ?baseURL: U2<URLPatternOptions, string> *
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
            abstract exec: ?input: U2<URLPatternInit, string> * ?baseURL: D1SessionBookmark -> option<URLPatternResult>
            abstract test: ?input: U2<URLPatternInit, string> * ?baseURL: D1SessionBookmark -> bool

        [<Import("@cloudflare/workers-types", "URLPatternOptions")>]
        type URLPatternOptions =
            abstract ignoreCase: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_AsyncResponse")>]
        type AiCfQwenQwen330BA3BFp8AsyncResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        type ClearInterval =
            abstract Invoke: ?timeoutId: float -> unit
            abstract Invoke: ?id: float -> unit

        type ClearTimeout =
            abstract Invoke: ?timeoutId: float -> unit
            abstract Invoke: ?id: float -> unit

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

        [<Import("@cloudflare/workers-types", "ResponseUsage")>]
        type ResponseUsage =
            [<EmitProperty("total_tokens")>]
            abstract totalTokens: float with get, set

            [<EmitProperty("output_tokens")>]
            abstract outputTokens: float with get, set

            [<EmitProperty("input_tokens")>]
            abstract inputTokens: float with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseFormatTextJSONSchemaConfig = | [<CompiledName("json_schema")>] JsonSchema

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type __WORKFLOW_ENTRYPOINT_BRAND = | __WORKFLOW_ENTRYPOINT_BRAND

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Prompt")>]
        type AiCfQwenQwen25Coder32BInstructPrompt =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfQwenQwen25Coder32BInstructJSONMode> with get, set

            abstract lora: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseReasoningTextDoneEvent =
            | [<CompiledName("response.reasoning_text.done")>] ResponseReasoningTextDone

        [<Import("@cloudflare/workers-types", "Ai_Cf_Deepgram_Aura_2_Es_Input")>]
        type AiCfDeepgramAura2EsInput =
            [<EmitProperty("bit_rate")>]
            abstract bitRate: option<float> with get, set

            [<EmitProperty("sample_rate")>]
            abstract sampleRate: option<float> with get, set

            abstract text: D1SessionBookmark with get, set
            abstract container: option<AiModels._Lit295> with get, set
            abstract encoding: option<AiModels._Lit294> with get, set
            abstract speaker: option<AiModels._Lit304> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ToolMessage = | [<CompiledName("tool")>] Tool

        type AiTextToImageOutput = obj

        [<Import("@cloudflare/workers-types", "AiTextToSpeechInput")>]
        type AiTextToSpeechInput =
            abstract lang: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Black_Forest_Labs_Flux_2_Klein_4B");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfBlackForestLabsFlux2Klein4B private () =
            abstract postProcessedOutputs: AiCfBlackForestLabsFlux2Klein4BOutput with get, set
            abstract inputs: AiCfBlackForestLabsFlux2Klein4BInput with get, set

        [<Import("@cloudflare/workers-types", "R2ObjectBody"); AbstractClass; AllowNullLiteral>]
        type R2ObjectBody private () =
            inherit R2Object()
            abstract bodyUsed: bool with get
            abstract body: AiTextToImageOutput with get
            abstract blob: unit -> Promise<Blob>
            abstract json: unit -> Promise<'T>
            abstract text: unit -> Promise<D1SessionBookmark>
            abstract bytes: unit -> Promise<Uint8Array<ArrayBufferLike>>
            abstract arrayBuffer: unit -> Promise<ArrayBuffer>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages")>]
        type AiCfMetaLlama3370BInstructFp8FastMessages =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfMetaLlama3370BInstructFp8FastJSONMode1> with get, set

            abstract tools: option<ResizeArray<U2<AiModels._Lit72, AiModels._Lit76>>> with get, set
            abstract functions: option<ResizeArray<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: ResizeArray<AiModels._Lit81> with get, set

        [<Import("@cloudflare/workers-types", "CryptoKeyRsaKeyAlgorithm")>]
        type CryptoKeyRsaKeyAlgorithm =
            abstract hash: option<CryptoKeyKeyAlgorithm> with get, set
            abstract publicExponent: BufferSource with get, set
            abstract modulusLength: float with get, set
            abstract name: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type DurableObjectNamespaceGetDurableObjectOptions = | [<CompiledName("primary-only")>] PrimaryOnly

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfMetaLlama3370BInstructFp8Fast private () =
            abstract postProcessedOutputs: AiCfMetaLlama3370BInstructFp8FastOutput with get, set
            abstract inputs: AiCfMetaLlama3370BInstructFp8FastInput with get, set

        [<Import("@cloudflare/workers-types", "Fetcher")>]
        type Fetcher<'Reserved, 'T
            when 'Reserved :> D1SessionBookmark
            and 'T :> U3<Rpc.WorkerEntrypointBranded, Rpc.DurableObjectBranded, Rpc.WorkflowEntrypointBranded>> =
            abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket
            abstract fetch: input: U3<Request, URL, string> * ?init: RequestInit -> Promise<Global.Response>
            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, Promise<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, Promise<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, Promise<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke:
                [<ParamArray>] args: Fetcher.Invoke.Args ->
                    U2<Typescript.CSSViewTransitionRule._Lit31, U2<Typescript.CSSViewTransitionRule._Lit3576, unit>>

        [<Import("@cloudflare/workers-types", "BaseAiImageTextToText"); AbstractClass; AllowNullLiteral>]
        type BaseAiImageTextToText private () =
            abstract postProcessedOutputs: AiImageTextToTextOutput with get, set
            abstract inputs: AiImageTextToTextInput with get, set

        type KVNamespaceListResult<'Key, 'Metadata when 'Key :> D1SessionBookmark> =
            U2<KVNamespace._Lit4, KVNamespace._Lit5>

        [<Import("@cloudflare/workers-types", "ExportedHandlerTraceHandler")>]
        type ExportedHandlerTraceHandler<'Props, 'Env> =
            abstract Invoke:
                traces: ResizeArray<TraceItem> * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "TransformStream"); AbstractClass; AllowNullLiteral>]
        type TransformStream<'O, 'I> private () =
            [<EmitConstructor>]
            abstract Create:
                ?transformer: Transformer<'I, 'O> *
                ?writableStrategy: QueuingStrategy<'I> *
                ?readableStrategy: QueuingStrategy<'O> ->
                    TransformStream

            abstract writable: WritableStream<'I> with get
            abstract readable: ReadableStream<'O> with get

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type __RPC_TARGET_BRAND = | __RPC_TARGET_BRAND

        [<Import("@cloudflare/workers-types", "AiSentenceSimilarityInput")>]
        type AiSentenceSimilarityInput =
            abstract sentences: ResizeArray<D1SessionBookmark> with get, set
            abstract source: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages")>]
        type AiCfMistralaiMistralSmall3124BInstructMessages =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            abstract tools: option<ResizeArray<U2<AiModels._Lit72, AiModels._Lit76>>> with get, set
            abstract functions: option<ResizeArray<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: ResizeArray<AiModels._Lit67> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type __RPC_STUB_BRAND = | __RPC_STUB_BRAND

        type AiCfBaaiBgeBaseEnV15Output = obj

        [<Import("@cloudflare/workers-types", "Without")>]
        type Without<'U, 'T> =
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "AiGatewayInternalError"); AbstractClass; AllowNullLiteral>]
        type AiGatewayInternalError private () =
            inherit exn()

        [<Import("@cloudflare/workers-types", "ImageTransformer")>]
        type ImageTransformer =
            abstract output: options: ImageOutputOptions -> Promise<ImageTransformationResult>

            abstract draw:
                image: U2<ReadableStream<Uint8Array<ArrayBufferLike>>, ImageTransformer> * ?options: ImageDrawOptions ->
                    ImageTransformer

            abstract transform: transform: ImageTransform -> ImageTransformer

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Baai_Bge_Small_En_V1_5"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfBaaiBgeSmallEnV15 private () =
            abstract postProcessedOutputs: AiCfBaaiBgeSmallEnV15Output with get, set
            abstract inputs: AiCfBaaiBgeSmallEnV15Input with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1")>]
        type AiCfAisingaporeGemmaSeaLionV427BItMessages1 =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfAisingaporeGemmaSeaLionV427BItJSONMode3> with get, set

            abstract tools: option<ResizeArray<U2<AiModels._Lit72, AiModels._Lit76>>> with get, set
            abstract functions: option<ResizeArray<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: ResizeArray<AiModels._Lit81> with get, set

        [<Import("@cloudflare/workers-types", "MediaTransformationGenerator")>]
        type MediaTransformationGenerator =
            abstract output: ?output: MediaTransformationOutputOptions -> MediaTransformationResult

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Output")>]
        type AiCfMetaLlama4Scout17B16EInstructOutput =
            [<EmitProperty("tool_calls")>]
            abstract toolCalls: option<ResizeArray<AiModels._Lit107>> with get, set

            abstract usage: option<AiModels._Lit87> with get, set
            abstract response: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfQwenQwen330BA3BFp8 private () =
            abstract postProcessedOutputs: AiCfQwenQwen330BA3BFp8Output with get, set
            abstract inputs: AiCfQwenQwen330BA3BFp8Input with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Async_Batch")>]
        type AiCfMetaLlama3370BInstructFp8FastAsyncBatch =
            abstract requests: option<ResizeArray<AiModels._Lit84>> with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionContentPartImage")>]
        type ChatCompletionContentPartImage =
            [<EmitProperty("image_url")>]
            abstract imageUrl: ChatCompletionContentPartImage._Lit2 with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ChatCompletionContentPartImage.Type with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type UnderlyingSource =
            | [<CompiledName("")>] Empty
            | [<CompiledName("bytes")>] Bytes

        [<Import("@cloudflare/workers-types", "Hyperdrive")>]
        type Hyperdrive =
            abstract database: D1SessionBookmark with get
            abstract password: D1SessionBookmark with get
            abstract user: D1SessionBookmark with get
            abstract port: float with get
            abstract host: D1SessionBookmark with get
            abstract connectionString: D1SessionBookmark with get
            abstract connect: unit -> Socket

        type ResponseFunctionCallOutputItem =
            U2<ResponseFunctionCallOutputItemList._Lit2, ResponseFunctionCallOutputItemList._Lit3>

        [<Import("@cloudflare/workers-types", "ChatCompletionsOutput")>]
        type ChatCompletionsOutput =
            [<EmitProperty("service_tier")>]
            abstract serviceTier: option<AiModels._Lit147> with get, set

            [<EmitProperty("system_fingerprint")>]
            abstract systemFingerprint: option<string> with get, set

            abstract usage: option<CompletionUsage> with get, set
            abstract choices: ResizeArray<ChatCompletionChoice> with get, set
            abstract model: D1SessionBookmark with get, set
            abstract created: float with get, set
            abstract object: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "StreamDirectUploadWatermark")>]
        type StreamDirectUploadWatermark =
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ResponseTextConfig")>]
        type ResponseTextConfig =
            abstract verbosity: option<AiModels._Lit156> with get, set
            abstract format: option<ResponseFormatTextConfig> with get, set

        [<Import("@cloudflare/workers-types", "KVNamespaceGetWithMetadataResult")>]
        type KVNamespaceGetWithMetadataResult<'Metadata, 'Value> =
            abstract cacheStatus: option<string> with get, set
            abstract metadata: option<'Metadata> with get, set
            abstract value: option<'Value> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Leonardo_Phoenix_1_0_Input")>]
        type AiCfLeonardoPhoenix10Input =
            [<EmitProperty("negative_prompt")>]
            abstract negativePrompt: option<D1SessionBookmark> with get, set

            [<EmitProperty("num_steps")>]
            abstract numSteps: option<float> with get, set

            abstract width: option<float> with get, set
            abstract height: option<float> with get, set
            abstract seed: option<float> with get, set
            abstract guidance: option<float> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ResponseConversationParam")>]
        type ResponseConversationParam =
            abstract id: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type QueueContentType =
            | [<CompiledName("text")>] Text
            | [<CompiledName("bytes")>] Bytes
            | [<CompiledName("json")>] Json
            | [<CompiledName("v8")>] V8

        [<Import("@cloudflare/workers-types", "CachePurgeError")>]
        type CachePurgeError =
            abstract message: D1SessionBookmark with get, set
            abstract code: float with get, set

        [<Import("@cloudflare/workers-types", "VectorizeMatch")>]
        type VectorizeMatch =
            abstract score: float with get, set
            abstract metadata: option<Typescript.CSSViewTransitionRule._Lit44> with get, set

            [<EmitProperty("namespace")>]
            abstract ``namespace``: option<string> with get, set

            abstract id: D1SessionBookmark with get, set

            abstract values:
                option<U3<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>, ResizeArray<float>>> with get, set

        [<Import("@cloudflare/workers-types", "EventTarget"); AbstractClass; AllowNullLiteral>]
        type EventTarget<'EventMap when 'EventMap :> WebAssembly.ModuleImports> private () =
            [<EmitConstructor>]
            abstract Create: unit -> EventTarget

            abstract dispatchEvent: event: proptypekey<'EventMap, keyof<'EventMap>> -> bool

            abstract removeEventListener:
                ``type``: 'Type * handler: Body * ?options: U2<EventTargetEventListenerOptions, bool> -> unit

            abstract addEventListener:
                ``type``: 'Type * handler: Body * ?options: U2<EventTargetAddEventListenerOptions, bool> -> unit

        [<Import("@cloudflare/workers-types", "R2MultipartUpload")>]
        type R2MultipartUpload =
            abstract uploadId: D1SessionBookmark with get
            abstract key: D1SessionBookmark with get
            abstract complete: uploadedParts: ResizeArray<R2UploadedPart> -> Promise<R2Object>
            abstract abort: unit -> Promise<unit>

            abstract uploadPart:
                partNumber: float *
                value: U5<ReadableStream<option<obj>>, ArrayBuffer, ArrayBufferView<ArrayBufferLike>, Blob, string> *
                ?options: R2UploadPartOptions ->
                    Promise<R2UploadedPart>

        [<Import("@cloudflare/workers-types", "StreamVideo")>]
        type StreamVideo =
            abstract publicDetails: option<StreamVideos._Lit5> with get, set
            abstract clippedFromId: option<string> with get, set
            abstract liveInputId: option<string> with get, set
            abstract watermark: option<StreamWatermark._Lit1> with get, set
            abstract dashPlaybackUrl: D1SessionBookmark with get, set
            abstract hlsPlaybackUrl: D1SessionBookmark with get, set
            abstract input: StreamVideoInput with get, set
            abstract duration: float with get, set
            abstract maxDurationSeconds: option<float> with get, set
            abstract maxSizeBytes: option<float> with get, set
            abstract uploadExpiry: option<string> with get, set
            abstract uploaded: option<string> with get, set
            abstract requireSignedURLs: option<bool> with get, set
            abstract allowedOrigins: ResizeArray<D1SessionBookmark> with get, set
            abstract preview: option<D1SessionBookmark> with get, set
            abstract size: float with get, set
            abstract scheduledDeletion: option<string> with get, set
            abstract modified: D1SessionBookmark with get, set
            abstract created: D1SessionBookmark with get, set
            abstract meta: WebAssembly.ModuleImports with get, set
            abstract status: StreamVideoStatus with get, set
            abstract readyToStreamAt: option<string> with get, set
            abstract readyToStream: bool with get, set
            abstract thumbnailTimestampPct: float with get, set
            abstract thumbnail: D1SessionBookmark with get, set
            abstract creator: option<string> with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ResponseFunctionCallArgumentsDoneEvent")>]
        type ResponseFunctionCallArgumentsDoneEvent =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseFunctionCallArgumentsDoneEvent.Type with get, set

            [<EmitProperty("sequence_number")>]
            abstract sequenceNumber: float with get, set

            [<EmitProperty("output_index")>]
            abstract outputIndex: float with get, set

            abstract name: D1SessionBookmark with get, set

            [<EmitProperty("item_id")>]
            abstract itemId: D1SessionBookmark with get, set

            abstract arguments: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Pfnet_Plamo_Embedding_1B"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfPfnetPlamoEmbedding1B private () =
            abstract postProcessedOutputs: AiCfPfnetPlamoEmbedding1BOutput with get, set
            abstract inputs: AiCfPfnetPlamoEmbedding1BInput with get, set

        [<Import("@cloudflare/workers-types", "D1Response")>]
        type D1Response =
            abstract error: option<unit> with get, set
            abstract meta: D1PreparedStatement._Lit4 with get, set
            abstract success: D1Response.Success with get, set

        [<Import("@cloudflare/workers-types", "ReadableStreamValuesOptions")>]
        type ReadableStreamValuesOptions =
            abstract preventCancel: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "MessageBatchMetadata")>]
        type MessageBatchMetadata =
            abstract metrics: MessageBatchMetrics with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwq_32B_Messages")>]
        type AiCfQwenQwq32BMessages =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            abstract tools: option<ResizeArray<U2<AiModels._Lit72, AiModels._Lit76>>> with get, set
            abstract functions: option<ResizeArray<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: ResizeArray<AiModels._Lit67> with get, set

        [<Import("@cloudflare/workers-types", "TraceItemQueueEventInfo")>]
        type TraceItemQueueEventInfo =
            abstract batchSize: float with get
            abstract queue: D1SessionBookmark with get

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseIncompleteEvent = | [<CompiledName("response.incomplete")>] ResponseIncomplete

        type ResponseStreamEvent =
            U15<
                ResponseCompletedEvent._Lit1,
                ResponseCreatedEvent._Lit1,
                ResponseErrorEvent._Lit1,
                ResponseFunctionCallArgumentsDeltaEvent._Lit1,
                ResponseFunctionCallArgumentsDoneEvent._Lit1,
                ResponseFailedEvent._Lit1,
                ResponseIncompleteEvent._Lit1,
                ResponseOutputItemAddedEvent._Lit1,
                ResponseOutputItemDoneEvent._Lit1,
                ResponseReasoningTextDeltaEvent._Lit1,
                ResponseReasoningTextDoneEvent._Lit1,
                ResponseRefusalDeltaEvent._Lit1,
                ResponseRefusalDoneEvent._Lit1,
                ResponseTextDeltaEvent._Lit1,
                ResponseTextDoneEvent._Lit1
             >

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_1_Schnell_Output")>]
        type AiCfBlackForestLabsFlux1SchnellOutput =
            abstract image: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Input_QueryAnd_Contexts_1")>]
        type AiCfBaaiBgeM3InputQueryAndContexts1 =
            [<EmitProperty("truncate_inputs")>]
            abstract truncateInputs: option<bool> with get, set

            abstract contexts: ResizeArray<AiModels._Lit61> with get, set
            abstract query: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Async_Batch")>]
        type AiCfAisingaporeGemmaSeaLionV427BItAsyncBatch =
            abstract requests:
                ResizeArray<U2<AiCfAisingaporeGemmaSeaLionV427BItPrompt1, AiCfAisingaporeGemmaSeaLionV427BItMessages1>> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Unum_Uform_Gen2_Qwen_500M"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfUnumUformGen2Qwen500M private () =
            abstract postProcessedOutputs: AiCfUnumUformGen2Qwen500MOutput with get, set
            abstract inputs: AiCfUnumUformGen2Qwen500MInput with get, set

        [<Import("@cloudflare/workers-types", "WorkflowInstance"); AbstractClass; AllowNullLiteral>]
        type WorkflowInstance private () =
            abstract id: D1SessionBookmark with get, set
            abstract sendEvent: typepayload: Typescript.CSSViewTransitionRule._Lit517 -> Promise<unit>
            abstract status: unit -> Promise<InstanceStatus>
            abstract restart: unit -> Promise<unit>
            abstract terminate: unit -> Promise<unit>
            abstract resume: unit -> Promise<unit>
            abstract pause: unit -> Promise<unit>

        [<Import("@cloudflare/workers-types", "TestController")>]
        type TestController = interface end

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Pipecat_Ai_Smart_Turn_V2"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfPipecatAiSmartTurnV2 private () =
            abstract postProcessedOutputs: AiCfPipecatAiSmartTurnV2Output with get, set
            abstract inputs: AiCfPipecatAiSmartTurnV2Input with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Klein_9B_Input")>]
        type AiCfBlackForestLabsFlux2Klein9BInput =
            abstract multipart: AiModels._Lit57 with get, set

        [<Import("@cloudflare/workers-types", "QueueMetrics")>]
        type QueueMetrics =
            abstract oldestMessageTimestamp: option<Date> with get, set
            abstract backlogBytes: float with get, set
            abstract backlogCount: float with get, set

        [<Import("@cloudflare/workers-types", "ExportedHandlerTailHandler")>]
        type ExportedHandlerTailHandler<'Props, 'Env> =
            abstract Invoke:
                events: ResizeArray<TraceItem> * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        type ChatCompletionTool = obj

        [<Import("@cloudflare/workers-types", "PredictionContent")>]
        type PredictionContent =
            abstract content: U2<ResizeArray<ChatCompletionContentPartText>, string> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: PredictionContent.Type with get, set

        [<Import("@cloudflare/workers-types", "ContentOptions")>]
        type ContentOptions =
            abstract html: option<bool> with get, set

        type AiCfOpenaiWhisperTinyEnInput = U2<AiModels._Lit41, string>

        [<Import("@cloudflare/workers-types", "DurableObjectSetAlarmOptions")>]
        type DurableObjectSetAlarmOptions =
            abstract allowUnconfirmed: option<bool> with get, set
            abstract allowConcurrency: option<bool> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfDeepgramFluxInput = | [<CompiledName("linear16")>] Linear16

        [<Import("@cloudflare/workers-types", "HTMLRewriterElementContentHandlers")>]
        type HTMLRewriterElementContentHandlers =
            abstract text: element: Text -> option<Promise<unit>>
            abstract comments: comment: Global.Comment -> option<Promise<unit>>
            abstract element: element: Element -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Openai_Whisper_Large_V3_Turbo");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfOpenaiWhisperLargeV3Turbo private () =
            abstract postProcessedOutputs: AiCfOpenaiWhisperLargeV3TurboOutput with get, set
            abstract inputs: AiCfOpenaiWhisperLargeV3TurboInput with get, set

        [<Import("@cloudflare/workers-types", "DecompressionStream"); AbstractClass; AllowNullLiteral>]
        type DecompressionStream private () =
            inherit TransformStream<BufferSource, Uint8Array<ArrayBufferLike>>()

            [<EmitConstructor>]
            abstract Create: format: DecompressionStream.Format -> DecompressionStream

        [<Import("@cloudflare/workers-types", "Reasoning")>]
        type Reasoning =
            abstract summary: option<AiModels._Lit146> with get, set

            [<EmitProperty("generate_summary")>]
            abstract generateSummary: option<AiModels._Lit146> with get, set

            abstract effort: option<AiModels._Lit144> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Input_QueryAnd_Contexts")>]
        type AiCfBaaiBgeM3InputQueryAndContexts =
            [<EmitProperty("truncate_inputs")>]
            abstract truncateInputs: option<bool> with get, set

            abstract contexts: ResizeArray<AiModels._Lit61> with get, set
            abstract query: option<D1SessionBookmark> with get, set

        type ConversionResponse = obj

        [<Import("@cloudflare/workers-types", "Transformer")>]
        type Transformer<'O, 'I> =
            abstract expectedLength: option<float> with get, set
            abstract writableType: option<D1SessionBookmark> with get, set
            abstract readableType: option<D1SessionBookmark> with get, set
            abstract writableType: option<unit> with get, set
            abstract transform: option<TransformerTransformCallback<'I, 'O>> with get, set
            abstract start: option<TransformerStartCallback<'O>> with get, set
            abstract readableType: option<unit> with get, set
            abstract flush: option<TransformerFlushCallback<'O>> with get, set
            abstract cancel: ?reason: obj -> option<Promise<unit>>
            abstract flush: controller: TransformStreamDefaultController<'O> -> option<Promise<unit>>
            abstract transform: chunk: 'I * controller: TransformStreamDefaultController<'O> -> option<Promise<unit>>
            abstract start: controller: TransformStreamDefaultController<'O> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "AudioParams")>]
        type AudioParams =
            abstract format: AiModels._Lit168 with get, set
            abstract voice: U2<AiModels._Lit138, string> with get, set

        type HeadersInit =
            U3<
                Headers,
                seq<seq<D1SessionBookmark, option<obj>, option<obj>>, option<obj>, option<obj>>,
                Typescript.CSSViewTransitionRule._Lit44
             >

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionToolChoiceFunction = | [<CompiledName("function")>] Function

        [<Import("@cloudflare/workers-types", "FormData"); AbstractClass; AllowNullLiteral>]
        type FormData private () =
            [<EmitConstructor>]
            abstract Create: unit -> FormData

            abstract symbolIterator:
                unit ->
                    System.Collections.Generic.IEnumerator<
                        D1SessionBookmark * D1SessionBookmark,
                        option<obj>,
                        option<obj>
                     >

            abstract forEach: callback: FormData._Lit2 * ?thisArg: 'This -> unit
            abstract values: unit -> System.Collections.Generic.IEnumerator<U2<File, string>, option<obj>, option<obj>>
            abstract keys: unit -> System.Collections.Generic.IEnumerator<D1SessionBookmark, option<obj>, option<obj>>

            abstract entries:
                unit ->
                    System.Collections.Generic.IEnumerator<
                        D1SessionBookmark * D1SessionBookmark,
                        option<obj>,
                        option<obj>
                     >

            abstract set: name: D1SessionBookmark * value: Blob * ?filename: D1SessionBookmark -> unit
            abstract set: name: D1SessionBookmark * value: D1SessionBookmark -> unit
            abstract set: name: D1SessionBookmark * value: U2<Blob, string> -> unit
            abstract has: name: D1SessionBookmark -> bool
            abstract getAll: name: D1SessionBookmark -> ResizeArray<D1SessionBookmark>
            abstract get: name: D1SessionBookmark -> option<string>
            abstract delete: name: D1SessionBookmark -> unit
            abstract append: name: D1SessionBookmark * value: Blob * ?filename: D1SessionBookmark -> unit
            abstract append: name: D1SessionBookmark * value: D1SessionBookmark -> unit
            abstract append: name: D1SessionBookmark * value: U2<Blob, string> -> unit

        [<Import("@cloudflare/workers-types", "DispatchNamespace")>]
        type DispatchNamespace =
            abstract get:
                name: D1SessionBookmark * ?args: WebAssembly.ModuleImports * ?options: DynamicDispatchOptions ->
                    Typescript.CSSViewTransitionRule._Lit3543

        type RemoveEventListener =
            abstract Invoke:
                ``type``: 'Type * handler: Body * ?options: U2<EventTargetEventListenerOptions, bool> -> unit

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

        [<Import("@cloudflare/workers-types", "ContainerSnapshotOptions")>]
        type ContainerSnapshotOptions =
            abstract name: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ExportedHandlerTailStreamHandler")>]
        type ExportedHandlerTailStreamHandler<'Props, 'Env> =
            abstract Invoke:
                event: TailStream.TailEvent<TailStream.Onset> * env: 'Env * ctx: ExecutionContext<'Props> ->
                    U3<
                        TailStream.TailEvent<'Event> -> option<Promise<unit>>,
                        TailStream.TailEventHandlerObject._Lit1,
                        Promise<TailStream.TailEventHandlerType>
                     >

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseContentReasoningText = | [<CompiledName("reasoning_text")>] ReasoningText

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseCustomToolCallOutput = | [<CompiledName("custom_tool_call_output")>] CustomToolCallOutput

        [<Import("@cloudflare/workers-types", "CryptoKey"); AbstractClass; AllowNullLiteral>]
        type CryptoKey private () =
            abstract usages: ResizeArray<D1SessionBookmark> with get

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

            [<EmitProperty("type")>]
            abstract ``type``: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "QueueSendBatchResponse")>]
        type QueueSendBatchResponse =
            abstract metadata: QueueSendBatchMetadata with get, set

        type ChatCompletionContentPart =
            U4<
                AutoRAG._Lit13,
                ChatCompletionContentPartImage._Lit1,
                ChatCompletionContentPartInputAudio._Lit1,
                ChatCompletionContentPartFile._Lit1
             >

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_3")>]
        type AiCfQwenQwen330BA3BFp8JSONMode3 =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiModels._Lit80> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionMessageFunctionToolCall = | [<CompiledName("function")>] Function

        [<Import("@cloudflare/workers-types", "ChatCompletionChoice")>]
        type ChatCompletionChoice =
            abstract logprobs: option<AiModels._Lit285> with get, set

            [<EmitProperty("finish_reason")>]
            abstract finishReason: AiModels._Lit283 with get, set

            abstract message: ChatCompletionResponseMessage with get, set
            abstract index: float with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type IncomingRequestCfProperties = | [<CompiledName("1")>] ``1``

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseIncludable =
            | [<CompiledName("message.input_image.image_url")>] MessageInputImageImageUrl
            | [<CompiledName("message.output_text.logprobs")>] MessageOutputTextLogprobs

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Zai_Org_Glm_4_7_Flash"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfZaiOrgGlm47Flash private () =
            abstract postProcessedOutputs: ChatCompletionsOutput with get, set
            abstract inputs: ChatCompletionsInput with get, set

        [<Import("@cloudflare/workers-types", "DynamicDispatchLimits")>]
        type DynamicDispatchLimits =
            abstract subRequests: option<float> with get, set
            abstract cpuMs: option<float> with get, set

        [<Import("@cloudflare/workers-types", "Socket")>]
        type Socket =
            abstract secureTransport: Typescript.CSSViewTransitionRule._Lit3575 with get
            abstract upgraded: bool with get
            abstract opened: Promise<SocketInfo> with get
            abstract closed: Promise<unit> with get
            abstract writable: WritableStream<option<obj>> with get
            abstract readable: AiTextToImageOutput with get
            abstract startTls: ?options: TlsOptions -> Socket
            abstract close: unit -> Promise<unit>

        [<Import("@cloudflare/workers-types", "RequestInit")>]
        type RequestInit =
            abstract encodeResponseBody: option<Typescript.CSSViewTransitionRule._Lit3549> with get, set
            abstract signal: option<AbortSignal> with get, set
            abstract integrity: option<D1SessionBookmark> with get, set
            abstract cf: option<'Cf> with get, set
            abstract fetcher: option<Typescript.CSSViewTransitionRule._Lit3543> with get, set
            abstract redirect: option<D1SessionBookmark> with get, set

            abstract body:
                option<
                    U7<
                        FormData,
                        Blob,
                        ArrayBuffer,
                        ReadableStream<option<obj>>,
                        ArrayBufferView<ArrayBuffer>,
                        URLSearchParams,
                        string
                     >
                 > with get, set

            abstract headers: option<HeadersInit> with get, set
            abstract method: option<D1SessionBookmark> with get, set
            abstract window: option<RequestInit.Window> with get, set
            abstract signal: option<AbortSignal> with get, set
            abstract referrerPolicy: option<ReferrerPolicy> with get, set
            abstract referrer: option<D1SessionBookmark> with get, set
            abstract redirect: option<RequestRedirect> with get, set
            abstract priority: option<RequestPriority> with get, set
            abstract mode: option<RequestMode> with get, set
            abstract method: option<D1SessionBookmark> with get, set
            abstract keepalive: option<bool> with get, set
            abstract integrity: option<D1SessionBookmark> with get, set
            abstract headers: option<HeadersInit> with get, set
            abstract credentials: option<RequestCredentials> with get, set
            abstract cache: option<RequestCache> with get, set

            abstract body:
                option<
                    U7<
                        FormData,
                        Blob,
                        ArrayBuffer,
                        ReadableStream<option<obj>>,
                        ArrayBufferView<ArrayBuffer>,
                        URLSearchParams,
                        string
                     >
                 > with get, set

        [<Import("@cloudflare/workers-types", "AiSearchJobs"); AbstractClass; AllowNullLiteral>]
        type AiSearchJobs private () =
            abstract get: jobId: D1SessionBookmark -> AiSearchJob
            abstract create: ?params: AiSearchCreateJobParams -> Promise<AiSearchJobInfo>
            abstract list: ?params: AiSearchListJobsParams -> Promise<AiSearchListJobsResponse>

        [<Import("@cloudflare/workers-types", "Container")>]
        type Container =
            abstract running: bool with get

            abstract interceptOutboundHttps:
                addr: D1SessionBookmark * binding: Typescript.CSSViewTransitionRule._Lit3543 -> Promise<unit>

            abstract snapshotContainer: options: ContainerSnapshotOptions -> Promise<ContainerSnapshot>

            abstract snapshotDirectory:
                options: ContainerDirectorySnapshotOptions -> Promise<ContainerDirectorySnapshot>

            abstract interceptAllOutboundHttp: binding: Typescript.CSSViewTransitionRule._Lit3543 -> Promise<unit>

            abstract interceptOutboundHttp:
                addr: D1SessionBookmark * binding: Typescript.CSSViewTransitionRule._Lit3543 -> Promise<unit>

            abstract setInactivityTimeout: durationMs: float -> Promise<unit>
            abstract getTcpPort: port: float -> Typescript.CSSViewTransitionRule._Lit3543
            abstract signal: signo: float -> unit
            abstract destroy: ?error: obj -> Promise<unit>
            abstract monitor: unit -> Promise<unit>
            abstract start: ?options: ContainerStartupOptions -> unit

        [<Import("@cloudflare/workers-types", "StreamDirectUpload")>]
        type StreamDirectUpload =
            abstract scheduledDeletion: option<string> with get, set
            abstract watermark: option<StreamWatermark._Lit1> with get, set
            abstract id: D1SessionBookmark with get, set
            abstract uploadURL: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "BaseAiMultimodalEmbeddings"); AbstractClass; AllowNullLiteral>]
        type BaseAiMultimodalEmbeddings private () =
            abstract postProcessedOutputs: AiImageTextToTextOutput with get, set
            abstract inputs: AiImageTextToTextInput with get, set

        [<Import("@cloudflare/workers-types", "TraceDiagnosticChannelEvent")>]
        type TraceDiagnosticChannelEvent =
            abstract message: option<obj> with get
            abstract channel: D1SessionBookmark with get
            abstract timestamp: float with get

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ReasoningEffort =
            | [<CompiledName("minimal")>] Minimal
            | [<CompiledName("low")>] Low
            | [<CompiledName("medium")>] Medium
            | [<CompiledName("high")>] High

        [<Import("@cloudflare/workers-types", "AiSearchItemChunksParams")>]
        type AiSearchItemChunksParams =
            abstract offset: option<float> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B_Input")>]
        type AiCfAi4BharatIndictrans2EnIndic1BInput =
            [<EmitProperty("target_language")>]
            abstract targetLanguage: AiModels._Lit296 with get, set

            abstract text: U2<ResizeArray<D1SessionBookmark>, string> with get, set

        [<Import("@cloudflare/workers-types", "ErrorEventErrorEventInit")>]
        type ErrorEventErrorEventInit =
            abstract error: option<obj> with get, set
            abstract colno: option<float> with get, set
            abstract lineno: option<float> with get, set
            abstract filename: option<D1SessionBookmark> with get, set
            abstract message: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "CompoundFilter")>]
        type CompoundFilter =
            abstract filters: ResizeArray<ComparisonFilter> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: AutoRAG._Lit5 with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ToolChoiceOptions = | [<CompiledName("none")>] ToolChoiceOptions

        [<Import("@cloudflare/workers-types", "QueueSendBatchMetrics")>]
        type QueueSendBatchMetrics =
            abstract oldestMessageTimestamp: option<Date> with get, set
            abstract backlogBytes: float with get, set
            abstract backlogCount: float with get, set

        [<Import("@cloudflare/workers-types", "AiSummarizationOutput")>]
        type AiSummarizationOutput =
            abstract summary: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiSearchMessage")>]
        type AiSearchMessage =
            abstract content: option<string> with get, set
            abstract role: Ai._Lit15 with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AlreadyUploadedError = | AlreadyUploadedError

        [<Import("@cloudflare/workers-types", "QueueSendResponse")>]
        type QueueSendResponse =
            abstract metadata: QueueSendMetadata with get, set

        [<Import("@cloudflare/workers-types", "EasyInputMessage")>]
        type EasyInputMessage =
            [<EmitProperty("type")>]
            abstract ``type``: option<EasyInputMessage.Type> with get, set

            abstract role: AiModels._Lit259 with get, set
            abstract content: U2<ResizeArray<'T>, string> with get, set

        [<Import("@cloudflare/workers-types", "MessageEvent"); AbstractClass; AllowNullLiteral>]
        type MessageEvent private () =
            inherit Event()

            [<EmitConstructor>]
            abstract Create: ``type``: D1SessionBookmark * initializer: MessageEventInit<option<obj>> -> MessageEvent

            abstract ports: ResizeArray<MessagePort> with get
            abstract source: option<MessagePort> with get
            abstract lastEventId: D1SessionBookmark with get
            abstract origin: option<string> with get
            abstract data: option<obj> with get

        type AiCfQwenQwen330BA3BFp8Input = obj

        [<Import("@cloudflare/workers-types", "AiSearchSearchResponse")>]
        type AiSearchSearchResponse =
            abstract chunks: ResizeArray<Ai._Lit17> with get, set

            [<EmitProperty("search_query")>]
            abstract searchQuery: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "UnsafeTraceMetrics")>]
        type UnsafeTraceMetrics =
            abstract fromTrace: item: TraceItem -> TraceMetrics

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type __DURABLE_OBJECT_BRAND = | __DURABLE_OBJECT_BRAND

        [<Import("@cloudflare/workers-types", "R2GetOptions")>]
        type R2GetOptions =
            abstract ssecKey: option<U2<ArrayBuffer, string>> with get, set
            abstract range: option<U4<R2Objects._Lit5, R2Objects._Lit6, R2Objects._Lit7, Headers>> with get, set
            abstract onlyIf: option<U2<R2Conditional, Headers>> with get, set

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesBotManagementEnterprise")>]
        type IncomingRequestCfPropertiesBotManagementEnterprise =
            inherit IncomingRequestCfPropertiesBotManagement
            abstract botManagement: Typescript.CSSViewTransitionRule._Lit3566 with get, set

        type AiSearchSearchRequest = obj

        [<Import("@cloudflare/workers-types", "AiSearchJobInfo")>]
        type AiSearchJobInfo =
            [<EmitProperty("end_reason")>]
            abstract endReason: option<D1SessionBookmark> with get, set

            [<EmitProperty("ended_at")>]
            abstract endedAt: option<D1SessionBookmark> with get, set

            [<EmitProperty("started_at")>]
            abstract startedAt: option<D1SessionBookmark> with get, set

            [<EmitProperty("last_seen_at")>]
            abstract lastSeenAt: option<D1SessionBookmark> with get, set

            abstract description: option<D1SessionBookmark> with get, set
            abstract source: Ai._Lit65 with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Baai_Bge_Base_En_V1_5"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfBaaiBgeBaseEnV15 private () =
            abstract postProcessedOutputs: AiCfBaaiBgeBaseEnV15Output with get, set
            abstract inputs: AiCfBaaiBgeBaseEnV15Input with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_AsyncResponse")>]
        type AiCfMetaLlama3370BInstructFp8FastAsyncResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "GatewayOptions")>]
        type GatewayOptions =
            abstract retries: option<GatewayRetries> with get, set
            abstract requestTimeoutMs: option<float> with get, set
            abstract eventId: option<D1SessionBookmark> with get, set
            abstract collectLog: option<bool> with get, set
            abstract metadata: option<WebAssembly.ModuleImports> with get, set
            abstract skipCache: option<bool> with get, set
            abstract cacheTtl: option<float> with get, set
            abstract cacheKey: option<D1SessionBookmark> with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "MediaTransformationInputOptions")>]
        type MediaTransformationInputOptions =
            abstract height: option<float> with get, set
            abstract width: option<float> with get, set
            abstract fit: option<MediaTransformationInputOptions._Lit2> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode_1")>]
        type AiCfMetaLlama3370BInstructFp8FastJSONMode1 =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiModels._Lit80> with get, set

        type ResponseInputContent = obj

        [<Import("@cloudflare/workers-types", "StreamWatermark")>]
        type StreamWatermark =
            abstract position: StreamWatermarkPosition with get, set
            abstract scale: float with get, set
            abstract padding: float with get, set
            abstract opacity: float with get, set
            abstract name: D1SessionBookmark with get, set
            abstract downloadedFrom: option<string> with get, set
            abstract created: D1SessionBookmark with get, set
            abstract width: float with get, set
            abstract height: float with get, set
            abstract size: float with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "CryptoKeyPair")>]
        type CryptoKeyPair =
            abstract privateKey: CryptoKey with get, set
            abstract publicKey: CryptoKey with get, set
            abstract publicKey: CryptoKey with get, set
            abstract privateKey: CryptoKey with get, set

        [<Import("@cloudflare/workers-types", "TextDecoderStreamTextDecoderStreamInit")>]
        type TextDecoderStreamTextDecoderStreamInit =
            abstract ignoreBOM: option<bool> with get, set
            abstract fatal: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Baai_Bge_Large_En_V1_5"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfBaaiBgeLargeEnV15 private () =
            abstract postProcessedOutputs: AiCfBaaiBgeLargeEnV15Output with get, set
            abstract inputs: AiCfBaaiBgeLargeEnV15Input with get, set

        [<Import("@cloudflare/workers-types", "IdentityTransformStreamQueuingStrategy")>]
        type IdentityTransformStreamQueuingStrategy =
            abstract highWaterMark: option<float> with get, set

        [<Import("@cloudflare/workers-types", "SchedulerWaitOptions")>]
        type SchedulerWaitOptions =
            abstract signal: option<AbortSignal> with get, set

        [<Import("@cloudflare/workers-types", "R2Bucket")>]
        type R2Bucket =
            abstract list: ?options: R2ListOptions -> Promise<R2Objects>
            abstract delete: keys: U2<ResizeArray<D1SessionBookmark>, string> -> Promise<unit>
            abstract resumeMultipartUpload: key: D1SessionBookmark * uploadId: D1SessionBookmark -> R2MultipartUpload

            abstract createMultipartUpload:
                key: D1SessionBookmark * ?options: R2MultipartOptions -> Promise<R2MultipartUpload>

            abstract put:
                key: D1SessionBookmark *
                ?value: U5<ReadableStream<option<obj>>, ArrayBuffer, ArrayBufferView<ArrayBufferLike>, Blob, string> *
                ?options: R2PutOptions ->
                    Promise<R2Object>

            abstract put:
                key: D1SessionBookmark *
                ?value: U5<ReadableStream<option<obj>>, ArrayBuffer, ArrayBufferView<ArrayBufferLike>, Blob, string> *
                ?options: R2Bucket._Lit7 ->
                    Promise<option<R2Object>>

            abstract get: key: D1SessionBookmark * ?options: R2GetOptions -> Promise<option<R2ObjectBody>>

            abstract get:
                key: D1SessionBookmark * options: R2Bucket._Lit2 -> Promise<option<U2<R2Object, R2ObjectBody>>>

            abstract head: key: D1SessionBookmark -> Promise<option<R2Object>>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type MaxFileSizeError = | MaxFileSizeError

        [<Import("@cloudflare/workers-types", "ResponsePrompt")>]
        type ResponsePrompt =
            abstract version: option<string> with get, set
            abstract variables: option<AiModels._Lit269> with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Leonardo_Lucid_Origin"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfLeonardoLucidOrigin private () =
            abstract postProcessedOutputs: AiCfLeonardoLucidOriginOutput with get, set
            abstract inputs: AiCfLeonardoLucidOriginInput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages")>]
        type AiCfMetaLlama3211BVisionInstructMessages =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract tools: option<ResizeArray<U2<AiModels._Lit72, AiModels._Lit76>>> with get, set
            abstract functions: option<ResizeArray<AiTextGenerationFunctionsInput>> with get, set
            abstract image: option<U2<ResizeArray<float>, Ai._Lit96>> with get, set
            abstract messages: ResizeArray<AiModels._Lit67> with get, set

        [<Import("@cloudflare/workers-types", "CustomEvent"); AbstractClass; AllowNullLiteral>]
        type CustomEvent<'T> private () =
            inherit Event()

            [<EmitConstructor>]
            abstract Create: ``type``: D1SessionBookmark * ?init: CustomEventCustomEventInit -> CustomEvent

            abstract detail: 'T with get

        [<Import("@cloudflare/workers-types", "ReadableStreamBYOBReaderReadableStreamBYOBReaderReadOptions")>]
        type ReadableStreamBYOBReaderReadableStreamBYOBReaderReadOptions =
            abstract min: option<float> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItemContentResult")>]
        type AiSearchItemContentResult =
            abstract size: float with get, set
            abstract filename: D1SessionBookmark with get, set
            abstract contentType: D1SessionBookmark with get, set
            abstract body: AiTextToImageOutput with get, set

        [<Import("@cloudflare/workers-types", "Tracing")>]
        type Tracing =
            [<EmitProperty("Span")>]
            abstract span: Tracing._Lit3 with get, set

            abstract enterSpan: name: D1SessionBookmark * callback: Tracing._Lit1 * [<ParamArray>] args: 'A -> 'T

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionToolChoiceOption =
            | [<CompiledName("none")>] None
            | [<CompiledName("auto")>] Auto
            | [<CompiledName("required")>] Required

        [<Import("@cloudflare/workers-types", "AiImageToTextOutput")>]
        type AiImageToTextOutput =
            abstract description: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiGateway"); AbstractClass; AllowNullLiteral>]
        type AiGateway private () =
            abstract getUrl: ?provider: U2<AiGateway.GetUrl.Provider, string> -> Promise<D1SessionBookmark>

            abstract run:
                data: U2<AiGateway._Lit6, ResizeArray<AIGatewayUniversalRequest>> * ?options: AiGateway._Lit16 ->
                    Promise<Global.Response>

            abstract getLog: logId: D1SessionBookmark -> Promise<AiGatewayLog>
            abstract patchLog: logId: D1SessionBookmark * data: AiGatewayPatchLog -> Promise<unit>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Moonshotai_Kimi_K2_5"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfMoonshotaiKimiK25 private () =
            abstract postProcessedOutputs: ChatCompletionsOutput with get, set
            abstract inputs: ChatCompletionsInput with get, set

        [<Import("@cloudflare/workers-types", "AssistantMessageContentPart")>]
        type AssistantMessageContentPart =
            abstract refusal: option<D1SessionBookmark> with get, set
            abstract text: option<D1SessionBookmark> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: AiModels._Lit223 with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Output")>]
        type AiCfMetaLlama3211BVisionInstructOutput =
            [<EmitProperty("tool_calls")>]
            abstract toolCalls: option<ResizeArray<AiModels._Lit78>> with get, set

            abstract response: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Output")>]
        type AiCfQwenQwen25Coder32BInstructOutput =
            [<EmitProperty("tool_calls")>]
            abstract toolCalls: option<ResizeArray<AiModels._Lit78>> with get, set

            abstract usage: option<AiModels._Lit87> with get, set
            abstract response: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectFacets")>]
        type DurableObjectFacets =
            abstract delete: name: D1SessionBookmark -> unit
            abstract abort: name: D1SessionBookmark * ?reason: obj -> unit

            abstract get:
                name: D1SessionBookmark *
                getStartupOptions: unit -> U2<FacetStartupOptions<'T>, Promise<FacetStartupOptions<'T>>> ->
                    DurableObjectFacets.Get

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        type AutoRagListResponse = obj

        type VectorizeVectorMetadata =
            U5<
                VectorizeVectorMetadata,
                ResizeArray<D1SessionBookmark>,
                Typescript.CSSViewTransitionRule._Lit44,
                string,
                float
             >

        [<Import("@cloudflare/workers-types", "SubtleCryptoEncryptAlgorithm")>]
        type SubtleCryptoEncryptAlgorithm =
            abstract label: option<BufferSource> with get, set
            abstract length: option<float> with get, set
            abstract counter: option<BufferSource> with get, set
            abstract tagLength: option<float> with get, set
            abstract additionalData: option<BufferSource> with get, set
            abstract iv: option<BufferSource> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "File"); AbstractClass; AllowNullLiteral>]
        type File private () =
            inherit Blob()

            [<EmitConstructor>]
            abstract Create:
                ?bits: ResizeArray<U4<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, Blob, string>> *
                name: D1SessionBookmark *
                ?options: FileOptions ->
                    File

            abstract lastModified: float with get
            abstract name: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "ResponseRefusalDeltaEvent")>]
        type ResponseRefusalDeltaEvent =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseRefusalDeltaEvent.Type with get, set

            [<EmitProperty("sequence_number")>]
            abstract sequenceNumber: float with get, set

            [<EmitProperty("output_index")>]
            abstract outputIndex: float with get, set

            [<EmitProperty("item_id")>]
            abstract itemId: D1SessionBookmark with get, set

            abstract delta: D1SessionBookmark with get, set

            [<EmitProperty("content_index")>]
            abstract contentIndex: float with get, set

        type ResponseFormat = obj

        [<Import("@cloudflare/workers-types", "StreamUpdateVideoParams")>]
        type StreamUpdateVideoParams =
            abstract thumbnailTimestampPct: option<float> with get, set
            abstract scheduledDeletion: option<string> with get, set
            abstract requireSignedURLs: option<bool> with get, set
            abstract meta: option<WebAssembly.ModuleImports> with get, set
            abstract maxDurationSeconds: option<float> with get, set
            abstract creator: option<D1SessionBookmark> with get, set
            abstract allowedOrigins: option<ResizeArray<D1SessionBookmark>> with get, set

        type AiCfMetaLlama3370BInstructFp8FastOutput =
            U3<AiModels._Lit86, AiCfMetaLlama3370BInstructFp8FastAsyncResponse, string>

        [<Import("@cloudflare/workers-types", "AiAutomaticSpeechRecognitionInput")>]
        type AiAutomaticSpeechRecognitionInput =
            abstract audio: AiSentenceSimilarityOutput with get, set

        [<Import("@cloudflare/workers-types", "InferenceUpstreamError"); AbstractClass; AllowNullLiteral>]
        type InferenceUpstreamError private () =
            inherit exn()

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Baai_Bge_M3"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfBaaiBgeM3 private () =
            abstract postProcessedOutputs: AiCfBaaiBgeM3Output with get, set
            abstract inputs: AiCfBaaiBgeM3Input with get, set

        [<Import("@cloudflare/workers-types", "EventTargetEventListenerOptions")>]
        type EventTargetEventListenerOptions =
            abstract capture: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_Small_En_V1_5_AsyncResponse")>]
        type AiCfBaaiBgeSmallEnV15AsyncResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Prompt")>]
        type AiCfMetaLlama4Scout17B16EInstructPrompt =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfMetaLlama4Scout17B16EInstructJSONMode> with get, set

            [<EmitProperty("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "SubtleCrypto"); AbstractClass; AllowNullLiteral>]
        type SubtleCrypto private () =
            abstract timingSafeEqual: a: BufferSource * b: BufferSource -> bool

            abstract unwrapKey:
                format: D1SessionBookmark *
                wrappedKey: BufferSource *
                unwrappingKey: CryptoKey *
                unwrapAlgorithm: U2<SubtleCryptoEncryptAlgorithm, string> *
                unwrappedKeyAlgorithm: U2<SubtleCryptoImportKeyAlgorithm, string> *
                extractable: bool *
                keyUsages: ResizeArray<D1SessionBookmark> ->
                    Promise<CryptoKey>

            abstract wrapKey:
                format: D1SessionBookmark *
                key: CryptoKey *
                wrappingKey: CryptoKey *
                wrapAlgorithm: U2<SubtleCryptoEncryptAlgorithm, string> ->
                    Promise<ArrayBuffer>

            abstract exportKey:
                format: D1SessionBookmark * key: CryptoKey -> Promise<U2<ArrayBuffer, Global.JsonWebKey>>

            abstract importKey:
                format: D1SessionBookmark *
                keyData: U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, Global.JsonWebKey> *
                algorithm: U2<SubtleCryptoImportKeyAlgorithm, string> *
                extractable: bool *
                keyUsages: ResizeArray<D1SessionBookmark> ->
                    Promise<CryptoKey>

            abstract deriveBits:
                algorithm: U2<SubtleCryptoDeriveKeyAlgorithm, string> * baseKey: CryptoKey * ?length: float ->
                    Promise<ArrayBuffer>

            abstract deriveKey:
                algorithm: U2<SubtleCryptoDeriveKeyAlgorithm, string> *
                baseKey: CryptoKey *
                derivedKeyAlgorithm: U2<SubtleCryptoImportKeyAlgorithm, string> *
                extractable: bool *
                keyUsages: ResizeArray<D1SessionBookmark> ->
                    Promise<CryptoKey>

            abstract generateKey:
                algorithm: U2<SubtleCryptoGenerateKeyAlgorithm, string> *
                extractable: bool *
                keyUsages: ResizeArray<D1SessionBookmark> ->
                    Promise<U2<CryptoKey, CryptoKeyPair>>

            abstract digest:
                algorithm: U2<SubtleCryptoHashAlgorithm, string> * data: BufferSource -> Promise<ArrayBuffer>

            abstract verify:
                algorithm: U2<SubtleCryptoSignAlgorithm, string> *
                key: CryptoKey *
                signature: BufferSource *
                data: BufferSource ->
                    Promise<bool>

            abstract sign:
                algorithm: U2<SubtleCryptoSignAlgorithm, string> * key: CryptoKey * data: BufferSource ->
                    Promise<ArrayBuffer>

            abstract decrypt:
                algorithm: U2<SubtleCryptoEncryptAlgorithm, string> * key: CryptoKey * cipherText: BufferSource ->
                    Promise<ArrayBuffer>

            abstract encrypt:
                algorithm: U2<SubtleCryptoEncryptAlgorithm, string> * key: CryptoKey * plainText: BufferSource ->
                    Promise<ArrayBuffer>

        type ResponseContent =
            U5<
                AiModels._Lit271,
                AiModels._Lit272,
                AiModels._Lit248,
                AiModels._Lit251,
                ResponseContentReasoningText._Lit1
             >

        [<Import("@cloudflare/workers-types", "ArtifactsTokenListResult")>]
        type ArtifactsTokenListResult =
            abstract total: float with get, set
            abstract tokens: ResizeArray<ArtifactsTokenInfo> with get, set

        type AiCfMetaM2M10012BOutput = obj

        [<Import("@cloudflare/workers-types", "Ai_Cf_Openai_Whisper_Tiny_En_Output")>]
        type AiCfOpenaiWhisperTinyEnOutput =
            abstract vtt: option<D1SessionBookmark> with get, set
            abstract words: option<ResizeArray<AiModels._Lit42>> with get, set

            [<EmitProperty("word_count")>]
            abstract wordCount: option<float> with get, set

            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "WebSocketAcceptOptions")>]
        type WebSocketAcceptOptions =
            abstract allowHalfOpen: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "MessageBatchMetrics")>]
        type MessageBatchMetrics =
            abstract oldestMessageTimestamp: option<Date> with get, set
            abstract backlogBytes: float with get, set
            abstract backlogCount: float with get, set

        [<Import("@cloudflare/workers-types", "Artifacts")>]
        type Artifacts =
            abstract delete: name: D1SessionBookmark -> Promise<bool>
            abstract list: ?opts: AiSearchItemLogsParams -> Promise<ArtifactsRepoListResult>
            abstract import: params: Artifacts._Lit6 -> Promise<ArtifactsCreateRepoResult>
            abstract get: name: D1SessionBookmark -> Promise<ArtifactsRepo>
            abstract create: name: D1SessionBookmark * ?opts: Artifacts._Lit1 -> Promise<ArtifactsCreateRepoResult>

        type AiModelListType = obj
        type AiCfAisingaporeGemmaSeaLionV427BItInput = obj

        [<Import("@cloudflare/workers-types", "AiObjectDetectionInput")>]
        type AiObjectDetectionInput =
            abstract image: AiSentenceSimilarityOutput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Output")>]
        type AiCfMistralaiMistralSmall3124BInstructOutput =
            [<EmitProperty("tool_calls")>]
            abstract toolCalls: option<ResizeArray<AiModels._Lit78>> with get, set

            abstract usage: option<AiModels._Lit87> with get, set
            abstract response: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "TextEncoder"); AbstractClass; AllowNullLiteral>]
        type TextEncoder private () =
            [<EmitConstructor>]
            abstract Create: unit -> TextEncoder

            abstract encoding: D1SessionBookmark with get

            abstract encodeInto:
                input: D1SessionBookmark * buffer: Uint8Array<ArrayBufferLike> -> Global.TextEncoderEncodeIntoResult

            abstract encode: ?input: D1SessionBookmark -> Uint8Array<ArrayBufferLike>

        [<Import("@cloudflare/workers-types", "AiSearchStatsResponse")>]
        type AiSearchStatsResponse =
            abstract engine: option<Ai._Lit39> with get, set

            [<EmitProperty("last_activity")>]
            abstract lastActivity: option<D1SessionBookmark> with get, set

            abstract outdated: option<float> with get, set
            abstract skipped: option<float> with get, set
            abstract error: option<float> with get, set
            abstract completed: option<float> with get, set
            abstract running: option<float> with get, set
            abstract queued: option<float> with get, set

        [<Import("@cloudflare/workers-types", "ServiceWorkerGlobalScope"); AbstractClass; AllowNullLiteral>]
        type ServiceWorkerGlobalScope private () =
            inherit WorkerGlobalScope()

            [<EmitProperty("HTMLRewriter")>]
            abstract hTMLRewriter: ServiceWorkerGlobalScope._Lit21 with get, set

            [<EmitProperty("IdentityTransformStream")>]
            abstract identityTransformStream: ServiceWorkerGlobalScope._Lit20 with get, set

            [<EmitProperty("FixedLengthStream")>]
            abstract fixedLengthStream: ServiceWorkerGlobalScope._Lit19 with get, set

            [<EmitProperty("Cache")>]
            abstract cache: Typescript.Cache._Lit1 with get, set

            [<EmitProperty("CacheStorage")>]
            abstract cacheStorage: Typescript.CacheStorage._Lit1 with get, set

            [<EmitProperty("CryptoKey")>]
            abstract cryptoKey: Typescript.CryptoKey._Lit1 with get, set

            [<EmitProperty("SubtleCrypto")>]
            abstract subtleCrypto: Typescript.SubtleCrypto._Lit1 with get, set

            [<EmitProperty("Crypto")>]
            abstract crypto: Typescript.Crypto._Lit1 with get, set

            [<EmitProperty("FormData")>]
            abstract formData: Typescript.FormData._Lit1 with get, set

            [<EmitProperty("File")>]
            abstract file: Typescript.File._Lit1 with get, set

            [<EmitProperty("Blob")>]
            abstract blob: ServiceWorkerGlobalScope._Lit17 with get, set

            [<EmitProperty("URLPattern")>]
            abstract uRLPattern: ServiceWorkerGlobalScope._Lit15 with get, set

            [<EmitProperty("URLSearchParams")>]
            abstract uRLSearchParams: Typescript.URLSearchParams._Lit1 with get, set

            abstract URL: Typescript.URL._Lit1 with get, set

            [<EmitProperty("TextEncoder")>]
            abstract textEncoder: Typescript.TextEncoder._Lit1 with get, set

            [<EmitProperty("TextDecoder")>]
            abstract textDecoder: Typescript.TextDecoder._Lit1 with get, set

            [<EmitProperty("AbortSignal")>]
            abstract abortSignal: ServiceWorkerGlobalScope._Lit14 with get, set

            [<EmitProperty("AbortController")>]
            abstract abortController: ServiceWorkerGlobalScope._Lit13 with get, set

            [<EmitProperty("WebSocketRequestResponsePair")>]
            abstract webSocketRequestResponsePair: ServiceWorkerGlobalScope._Lit12 with get, set

            [<EmitProperty("WebSocketPair")>]
            abstract webSocketPair: ServiceWorkerGlobalScope._Lit10 with get, set

            [<EmitProperty("WebSocket")>]
            abstract webSocket: Typescript.WebSocket._Lit1 with get, set

            [<EmitProperty("Response")>]
            abstract response: Typescript.Response._Lit1 with get, set

            [<EmitProperty("Request")>]
            abstract request: Typescript.Request._Lit1 with get, set

            [<EmitProperty("Body")>]
            abstract body: ServiceWorkerGlobalScope._Lit9 with get, set

            [<EmitProperty("Headers")>]
            abstract headers: Typescript.Headers._Lit1 with get, set

            [<EmitProperty("TextDecoderStream")>]
            abstract textDecoderStream: Typescript.TextDecoderStream._Lit1 with get, set

            [<EmitProperty("TextEncoderStream")>]
            abstract textEncoderStream: Typescript.TextEncoderStream._Lit1 with get, set

            [<EmitProperty("DecompressionStream")>]
            abstract decompressionStream: Typescript.DecompressionStream._Lit1 with get, set

            [<EmitProperty("CompressionStream")>]
            abstract compressionStream: Typescript.CompressionStream._Lit1 with get, set

            [<EmitProperty("EventSource")>]
            abstract eventSource: Typescript.EventSource._Lit1 with get, set

            [<EmitProperty("ErrorEvent")>]
            abstract errorEvent: Typescript.ErrorEvent._Lit1 with get, set

            [<EmitProperty("CountQueuingStrategy")>]
            abstract countQueuingStrategy: Typescript.CountQueuingStrategy._Lit1 with get, set

            [<EmitProperty("ByteLengthQueuingStrategy")>]
            abstract byteLengthQueuingStrategy: ServiceWorkerGlobalScope._Lit8 with get, set

            [<EmitProperty("TransformStream")>]
            abstract transformStream: Typescript.TransformStream._Lit1 with get, set

            [<EmitProperty("WritableStreamDefaultWriter")>]
            abstract writableStreamDefaultWriter: Typescript.WritableStreamDefaultWriter._Lit1 with get, set

            [<EmitProperty("WritableStream")>]
            abstract writableStream: Typescript.WritableStream._Lit1 with get, set

            [<EmitProperty("ReadableStream")>]
            abstract readableStream: Typescript.ReadableStream._Lit1 with get, set

            [<EmitProperty("ReadableStreamBYOBReader")>]
            abstract readableStreamBYOBReader: Typescript.ReadableStreamBYOBReader._Lit1 with get, set

            [<EmitProperty("ReadableStreamDefaultReader")>]
            abstract readableStreamDefaultReader: Typescript.ReadableStreamDefaultReader._Lit1 with get, set

            [<EmitProperty("CloseEvent")>]
            abstract closeEvent: Typescript.CloseEvent._Lit1 with get, set

            [<EmitProperty("MessageEvent")>]
            abstract messageEvent: Typescript.MessageEvent._Lit1 with get, set

            [<EmitProperty("ScheduledEvent")>]
            abstract scheduledEvent: ServiceWorkerGlobalScope._Lit7 with get, set

            [<EmitProperty("TraceEvent")>]
            abstract traceEvent: ServiceWorkerGlobalScope._Lit6 with get, set

            [<EmitProperty("TailEvent")>]
            abstract tailEvent: ServiceWorkerGlobalScope._Lit6 with get, set

            [<EmitProperty("FetchEvent")>]
            abstract fetchEvent: ServiceWorkerGlobalScope._Lit5 with get, set

            [<EmitProperty("PromiseRejectionEvent")>]
            abstract promiseRejectionEvent: Typescript.PromiseRejectionEvent._Lit1 with get, set

            [<EmitProperty("CustomEvent")>]
            abstract customEvent: Typescript.CustomEvent._Lit1 with get, set

            [<EmitProperty("ExtendableEvent")>]
            abstract extendableEvent: ServiceWorkerGlobalScope._Lit4 with get, set

            [<EmitProperty("Event")>]
            abstract event: Typescript.Event._Lit1 with get, set

            abstract origin: D1SessionBookmark with get

            [<EmitProperty("Cloudflare")>]
            abstract cloudflare: Cloudflare with get, set

            abstract performance: Performance with get, set
            abstract scheduler: Scheduler with get, set
            abstract caches: CacheStorage with get, set
            abstract crypto: Crypto with get, set
            abstract self: ServiceWorkerGlobalScope with get, set

            [<EmitProperty("WorkerGlobalScope")>]
            abstract workerGlobalScope: ServiceWorkerGlobalScope._Lit1 with get, set

            [<EmitProperty("DOMException")>]
            abstract dOMException: Typescript.DOMException._Lit1 with get, set

            abstract fetch: input: U3<Request, URL, string> * ?init: RequestInit -> Promise<Global.Response>
            abstract reportError: ?error: obj -> unit
            abstract structuredClone: value: 'T * ?options: Global.StructuredSerializeOptions -> 'T
            abstract queueMicrotask: task: Function -> unit
            abstract clearInterval: ?timeoutId: float -> unit

            abstract setInterval:
                callback: ServiceWorkerGlobalScope._Lit3 * ?msDelay: float * [<ParamArray>] args: 'Args -> float

            abstract setInterval: callback: ServiceWorkerGlobalScope._Lit2 * ?msDelay: float -> float
            abstract clearTimeout: ?timeoutId: float -> unit

            abstract setTimeout:
                callback: ServiceWorkerGlobalScope._Lit3 * ?msDelay: float * [<ParamArray>] args: 'Args -> float

            abstract setTimeout: callback: ServiceWorkerGlobalScope._Lit2 * ?msDelay: float -> float
            abstract atob: data: D1SessionBookmark -> D1SessionBookmark
            abstract btoa: data: D1SessionBookmark -> D1SessionBookmark

        [<Import("@cloudflare/workers-types", "ExtendableEvent"); AbstractClass; AllowNullLiteral>]
        type ExtendableEvent private () =
            inherit Event()
            abstract waitUntil: promise: Promise<option<obj>> -> unit

        [<Import("@cloudflare/workers-types", "HostedImagesBinding")>]
        type HostedImagesBinding =
            abstract list: ?options: ImageListOptions -> Promise<ImageList>

            abstract upload:
                image: U2<ReadableStream<Uint8Array<ArrayBufferLike>>, ArrayBuffer> * ?options: ImageUploadOptions ->
                    Promise<ImageMetadata>

            abstract image: imageId: D1SessionBookmark -> ImageHandle

        [<Import("@cloudflare/workers-types", "AiSearchNotFoundError"); AbstractClass; AllowNullLiteral>]
        type AiSearchNotFoundError private () =
            inherit exn()

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Baai_Bge_Reranker_Base"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfBaaiBgeRerankerBase private () =
            abstract postProcessedOutputs: AiCfBaaiBgeRerankerBaseOutput with get, set
            abstract inputs: AiCfBaaiBgeRerankerBaseInput with get, set

        [<Import("@cloudflare/workers-types", "Disposable")>]
        type Disposable =
            abstract symbolDispose: unit -> unit

        [<Import("@cloudflare/workers-types", "ForwardableEmailMessage")>]
        type ForwardableEmailMessage =
            inherit EmailMessage
            abstract rawSize: float with get
            abstract headers: Headers with get
            abstract raw: ReadableStream<Uint8Array<ArrayBufferLike>> with get
            abstract reply: message: EmailMessage -> Promise<EmailSendResult>
            abstract forward: rcptTo: D1SessionBookmark * ?headers: Headers -> Promise<EmailSendResult>
            abstract setReject: reason: D1SessionBookmark -> unit

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Openai_Whisper"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfOpenaiWhisper private () =
            abstract postProcessedOutputs: AiCfOpenaiWhisperOutput with get, set
            abstract inputs: AiCfOpenaiWhisperInput with get, set

        [<Import("@cloudflare/workers-types", "AiSearchNamespace"); AbstractClass; AllowNullLiteral>]
        type AiSearchNamespace private () =
            abstract chatCompletions:
                params: AiSearchMultiChatCompletionsRequest -> Promise<AiSearchMultiChatCompletionsResponse>

            abstract chatCompletions: params: Ai._Lit81 -> Promise<AiTextToImageOutput>
            abstract search: params: AiSearchMultiSearchRequest -> Promise<AiSearchMultiSearchResponse>
            abstract delete: name: D1SessionBookmark -> Promise<unit>
            abstract create: config: AiSearchConfig -> Promise<AiSearchInstance>
            abstract list: ?params: AiSearchListInstancesParams -> Promise<AiSearchListResponse>
            abstract get: name: D1SessionBookmark -> AiSearchInstance

        [<Import("@cloudflare/workers-types", "QueueSendMetadata")>]
        type QueueSendMetadata =
            abstract metrics: QueueSendMetrics with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type D1Result = | [<CompiledValue(true)>] True

        type AiCfBaaiBgeBaseEnV15Input = obj

        [<Import("@cloudflare/workers-types", "BaseAiTextGeneration"); AbstractClass; AllowNullLiteral>]
        type BaseAiTextGeneration private () =
            abstract postProcessedOutputs: AiTextGenerationOutput with get, set
            abstract inputs: AiTextGenerationInput with get, set

        [<Import("@cloudflare/workers-types", "TraceMetrics")>]
        type TraceMetrics =
            abstract wallTime: float with get
            abstract cpuTime: float with get

        type ReportError =
            abstract Invoke: ?error: obj -> unit
            abstract Invoke: ?e: obj -> unit

        [<Import("@cloudflare/workers-types", "CachePurgeOptions")>]
        type CachePurgeOptions =
            abstract purgeEverything: option<bool> with get, set
            abstract pathPrefixes: option<ResizeArray<D1SessionBookmark>> with get, set
            abstract tags: option<ResizeArray<D1SessionBookmark>> with get, set

        [<Import("@cloudflare/workers-types", "AiAsyncBatchResponse")>]
        type AiAsyncBatchResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ReadableByteStreamController")>]
        type ReadableByteStreamController =
            abstract desiredSize: option<float> with get
            abstract byobRequest: option<Global.ReadableStreamBYOBRequest> with get
            abstract desiredSize: option<float> with get
            abstract byobRequest: option<Global.ReadableStreamBYOBRequest> with get
            abstract error: ?reason: obj -> unit
            abstract enqueue: chunk: BufferSource -> unit
            abstract close: unit -> unit
            abstract error: ?e: obj -> unit
            abstract enqueue: chunk: ArrayBufferView<ArrayBuffer> -> unit
            abstract close: unit -> unit

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AutoRagSearchResponse = | [<CompiledName("vector_store.search_results.page")>] VectorStoreSearchResultsPage

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Leonardo_Phoenix_1_0"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfLeonardoPhoenix10 private () =
            abstract postProcessedOutputs: D1SessionBookmark with get, set
            abstract inputs: AiCfLeonardoPhoenix10Input with get, set

        [<Import("@cloudflare/workers-types", "ResponseFormatJSONSchema")>]
        type ResponseFormatJSONSchema =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: AiModels._Lit179 with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ResponseFormatJSONSchema.Type with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type Ai =
            | [<CompiledName("postProcessedOutputs")>] PostProcessedOutputs
            | [<CompiledName("inputs")>] Inputs

        [<Import("@cloudflare/workers-types", "ResponseIncompleteDetails")>]
        type ResponseIncompleteDetails =
            abstract reason: option<AiModels._Lit243> with get, set

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesCloudflareAccessOrApiShield")>]
        type IncomingRequestCfPropertiesCloudflareAccessOrApiShield =
            abstract tlsClientAuth:
                U2<IncomingRequestCfPropertiesTLSClientAuth, IncomingRequestCfPropertiesTLSClientAuthPlaceholder> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type StreamDownloadStatus =
            | [<CompiledName("ready")>] Ready
            | [<CompiledName("inprogress")>] Inprogress
            | [<CompiledName("error")>] Error

        [<Import("@cloudflare/workers-types", "TraceItemScheduledEventInfo")>]
        type TraceItemScheduledEventInfo =
            abstract cron: D1SessionBookmark with get
            abstract scheduledTime: float with get

        [<Import("@cloudflare/workers-types", "Ai_Cf_Deepgram_Aura_2_En_Input")>]
        type AiCfDeepgramAura2EnInput =
            [<EmitProperty("bit_rate")>]
            abstract bitRate: option<float> with get, set

            [<EmitProperty("sample_rate")>]
            abstract sampleRate: option<float> with get, set

            abstract text: D1SessionBookmark with get, set
            abstract container: option<AiModels._Lit295> with get, set
            abstract encoding: option<AiModels._Lit294> with get, set
            abstract speaker: option<AiModels._Lit303> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Prompt")>]
        type AiCfAisingaporeGemmaSeaLionV427BItPrompt =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfAisingaporeGemmaSeaLionV427BItJSONMode> with get, set

            abstract lora: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItemInfo")>]
        type AiSearchItemInfo =
            abstract metadata: option<WebAssembly.ModuleImports> with get, set

            [<EmitProperty("created_at")>]
            abstract createdAt: option<D1SessionBookmark> with get, set

            [<EmitProperty("last_seen_at")>]
            abstract lastSeenAt: option<D1SessionBookmark> with get, set

            [<EmitProperty("source_id")>]
            abstract sourceId: option<string> with get, set

            [<EmitProperty("file_size")>]
            abstract fileSize: option<float> with get, set

            [<EmitProperty("chunks_count")>]
            abstract chunksCount: option<float> with get, set

            [<EmitProperty("namespace")>]
            abstract ``namespace``: option<D1SessionBookmark> with get, set

            abstract checksum: option<D1SessionBookmark> with get, set
            abstract error: option<D1SessionBookmark> with get, set

            [<EmitProperty("next_action")>]
            abstract nextAction: option<Ai._Lit48> with get, set

            abstract status: Ai._Lit47 with get, set
            abstract key: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "ContainerDirectorySnapshot")>]
        type ContainerDirectorySnapshot =
            abstract name: option<D1SessionBookmark> with get, set
            abstract dir: D1SessionBookmark with get, set
            abstract size: float with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ReadableStreamDefaultReader"); AbstractClass; AllowNullLiteral>]
        type ReadableStreamDefaultReader<'R> private () =
            [<EmitConstructor>]
            abstract Create: stream: AiTextToImageOutput -> ReadableStreamDefaultReader

            abstract closed: Promise<unit> with get
            abstract releaseLock: unit -> unit
            abstract read: unit -> Promise<U2<ReadableStreamReadValueResult<'R>, ReadableStreamReadDoneResult<'R>>>
            abstract cancel: ?reason: obj -> Promise<unit>

        [<Import("@cloudflare/workers-types", "KVNamespaceListKey")>]
        type KVNamespaceListKey<'Key, 'Metadata when 'Key :> D1SessionBookmark> =
            abstract metadata: option<'Metadata> with get, set
            abstract expiration: option<float> with get, set
            abstract name: 'Key with get, set

        [<Import("@cloudflare/workers-types", "ExecutionContext")>]
        type ExecutionContext<'Props> =
            abstract tracing: option<Tracing> with get, set
            abstract cache: option<CacheContext> with get, set
            abstract props: 'Props with get
            abstract passThroughOnException: unit -> unit
            abstract waitUntil: promise: Promise<option<obj>> -> unit

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_Large_En_V1_5_AsyncResponse")>]
        type AiCfBaaiBgeLargeEnV15AsyncResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type UserMessage = | [<CompiledName("user")>] User

        [<Import("@cloudflare/workers-types", "JsonWebKeyWithKid")>]
        type JsonWebKeyWithKid =
            inherit Global.JsonWebKey
            abstract kid: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "CryptoKeyHmacKeyAlgorithm")>]
        type CryptoKeyHmacKeyAlgorithm =
            abstract length: float with get, set
            abstract hash: CryptoKeyKeyAlgorithm with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Deepgram_Flux"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfDeepgramFlux private () =
            abstract postProcessedOutputs: AiCfDeepgramFluxOutput with get, set
            abstract inputs: AiCfDeepgramFluxInput with get, set

        [<Import("@cloudflare/workers-types", "MessagePortPostMessageOptions")>]
        type MessagePortPostMessageOptions =
            abstract transfer: option<ResizeArray<option<obj>>> with get, set

        [<Import("@cloudflare/workers-types", "StreamWatermarks")>]
        type StreamWatermarks =
            abstract delete: watermarkId: D1SessionBookmark -> Promise<unit>
            abstract get: watermarkId: D1SessionBookmark -> Promise<StreamWatermark>
            abstract list: unit -> Promise<ResizeArray<StreamWatermark>>
            abstract generate: url: D1SessionBookmark * params: StreamWatermarkCreateParams -> Promise<StreamWatermark>

            abstract generate:
                input: AiTextToImageOutput * params: StreamWatermarkCreateParams -> Promise<StreamWatermark>

        type ResponseInputMessageContentList = obj

        [<Import("@cloudflare/workers-types", "R2UploadPartOptions")>]
        type R2UploadPartOptions =
            abstract ssecKey: option<U2<ArrayBuffer, string>> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_Reranker_Base_Input")>]
        type AiCfBaaiBgeRerankerBaseInput =
            abstract contexts: ResizeArray<AiModels._Lit61> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

        [<Import("@cloudflare/workers-types", "ReadableStreamBYOBReader"); AbstractClass; AllowNullLiteral>]
        type ReadableStreamBYOBReader private () =
            [<EmitConstructor>]
            abstract Create: stream: AiTextToImageOutput -> ReadableStreamBYOBReader

            abstract closed: Promise<unit> with get

            abstract readAtLeast:
                minElements: float * view: 'T ->
                    Promise<U2<ReadableStreamReadValueResult<'T>, ReadableStreamReadDoneResult<'T>>>

            abstract releaseLock: unit -> unit
            abstract read: view: 'T -> Promise<U2<ReadableStreamReadValueResult<'T>, ReadableStreamReadDoneResult<'T>>>
            abstract cancel: ?reason: obj -> Promise<unit>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseReasoningContentItem = | [<CompiledName("reasoning_text")>] ReasoningText

        [<Import("@cloudflare/workers-types", "ExportedHandlerTestHandler")>]
        type ExportedHandlerTestHandler<'Props, 'Env> =
            abstract Invoke:
                controller: TestController * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages")>]
        type AiCfAisingaporeGemmaSeaLionV427BItMessages =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfAisingaporeGemmaSeaLionV427BItJSONMode1> with get, set

            abstract tools: option<ResizeArray<U2<AiModels._Lit72, AiModels._Lit76>>> with get, set
            abstract functions: option<ResizeArray<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: ResizeArray<AiModels._Lit81> with get, set

        type SetInterval =
            abstract Invoke:
                callback: ServiceWorkerGlobalScope._Lit3 * ?msDelay: float * [<ParamArray>] args: 'Args -> float

            abstract Invoke: callback: ServiceWorkerGlobalScope._Lit2 * ?msDelay: float -> float

            abstract Invoke:
                handler: TimerHandler * ?timeout: float * [<ParamArray>] arguments: ResizeArray<option<obj>> -> float

        [<Import("@cloudflare/workers-types", "ResponseError")>]
        type ResponseError =
            abstract message: D1SessionBookmark with get, set
            abstract code: AiModels._Lit240 with get, set

        [<Import("@cloudflare/workers-types", "AiSearchInstanceInfo")>]
        type AiSearchInstanceInfo =
            abstract metadata: option<WebAssembly.ModuleImports> with get, set

            [<EmitProperty("sync_interval")>]
            abstract syncInterval: option<Ai._Lit36> with get, set

            [<EmitProperty("custom_metadata")>]
            abstract customMetadata: option<ResizeArray<Ai._Lit34>> with get, set

            [<EmitProperty("cache_threshold")>]
            abstract cacheThreshold: option<Ai._Lit12> with get, set

            abstract cache: option<bool> with get, set

            [<EmitProperty("max_num_results")>]
            abstract maxNumResults: option<float> with get, set

            [<EmitProperty("score_threshold")>]
            abstract scoreThreshold: option<float> with get, set

            [<EmitProperty("chunk_overlap")>]
            abstract chunkOverlap: option<float> with get, set

            [<EmitProperty("chunk_size")>]
            abstract chunkSize: option<float> with get, set

            abstract chunk: option<bool> with get, set

            [<EmitProperty("retrieval_options")>]
            abstract retrievalOptions: option<Ai._Lit33> with get, set

            [<EmitProperty("indexing_options")>]
            abstract indexingOptions: option<Ai._Lit30> with get, set

            [<EmitProperty("fusion_method")>]
            abstract fusionMethod: option<Ai._Lit6> with get, set

            [<EmitProperty("index_method")>]
            abstract indexMethod: option<Ai._Lit28> with get, set

            /// <deprecated>
            /// Use index_method instead.
            /// </deprecated>
            [<EmitProperty("hybrid_search_enabled")>]
            abstract hybridSearchEnabled: option<bool> with get, set

            [<EmitProperty("reranking_model")>]
            abstract rerankingModel: option<D1SessionBookmark> with get, set

            [<EmitProperty("rewrite_model")>]
            abstract rewriteModel: option<D1SessionBookmark> with get, set

            [<EmitProperty("ai_search_model")>]
            abstract aiSearchModel: option<D1SessionBookmark> with get, set

            [<EmitProperty("embedding_model")>]
            abstract embeddingModel: option<D1SessionBookmark> with get, set

            abstract reranking: option<bool> with get, set

            [<EmitProperty("rewrite_query")>]
            abstract rewriteQuery: option<bool> with get, set

            [<EmitProperty("ai_gateway_id")>]
            abstract aiGatewayId: option<D1SessionBookmark> with get, set

            [<EmitProperty("token_id")>]
            abstract tokenId: option<D1SessionBookmark> with get, set

            [<EmitProperty("modified_at")>]
            abstract modifiedAt: option<D1SessionBookmark> with get, set

            [<EmitProperty("created_at")>]
            abstract createdAt: option<D1SessionBookmark> with get, set

            [<EmitProperty("namespace")>]
            abstract ``namespace``: option<D1SessionBookmark> with get, set

            abstract status: option<D1SessionBookmark> with get, set
            abstract paused: option<bool> with get, set

            [<EmitProperty("source_params")>]
            abstract sourceParams: option<obj> with get, set

            abstract source: option<D1SessionBookmark> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<U2<AiSearchInstanceInfo.Type, string>> with get, set

            abstract id: D1SessionBookmark with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "TooManyWatermarksError")>]
        type TooManyWatermarksError =
            inherit StreamError
            abstract name: TooManyWatermarksError.Name with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectGetOptions")>]
        type DurableObjectGetOptions =
            abstract noCache: option<bool> with get, set
            abstract allowConcurrency: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "TlsOptions")>]
        type TlsOptions =
            abstract expectedServerHostname: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Prompt_1")>]
        type AiCfAisingaporeGemmaSeaLionV427BItPrompt1 =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfAisingaporeGemmaSeaLionV427BItJSONMode2> with get, set

            abstract lora: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_1")>]
        type AiCfQwenQwen330BA3BFp8JSONMode1 =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiModels._Lit80> with get, set

        [<Import("@cloudflare/workers-types", "TraceLog")>]
        type TraceLog =
            abstract message: option<obj> with get
            abstract level: D1SessionBookmark with get
            abstract timestamp: float with get

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_1")>]
        type AiCfAisingaporeGemmaSeaLionV427BItJSONMode1 =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiModels._Lit80> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseStatus =
            | [<CompiledName("completed")>] Completed
            | [<CompiledName("failed")>] Failed
            | [<CompiledName("in_progress")>] InProgress
            | [<CompiledName("cancelled")>] Cancelled
            | [<CompiledName("queued")>] Queued
            | [<CompiledName("incomplete")>] Incomplete

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfMetaLlama3211BVisionInstruct private () =
            abstract postProcessedOutputs: AiCfMetaLlama3211BVisionInstructOutput with get, set
            abstract inputs: AiCfMetaLlama3211BVisionInstructInput with get, set

        [<Import("@cloudflare/workers-types", "AiSearchChatCompletionsResponse")>]
        type AiSearchChatCompletionsResponse =
            abstract chunks: ResizeArray<Ai._Lit17> with get, set
            abstract choices: ResizeArray<Ai._Lit24> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract object: option<D1SessionBookmark> with get, set
            abstract id: option<D1SessionBookmark> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "AiGatewayLogNotFound"); AbstractClass; AllowNullLiteral>]
        type AiGatewayLogNotFound private () =
            inherit exn()

        type FlagshipEvaluationContext = obj

        [<Import("@cloudflare/workers-types", "ArtifactsTokenInfo")>]
        type ArtifactsTokenInfo =
            abstract expiresAt: D1SessionBookmark with get, set
            abstract createdAt: D1SessionBookmark with get, set
            abstract state: Artifacts._Lit4 with get, set
            abstract scope: Artifacts._Lit3 with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionsPromptInput")>]
        type ChatCompletionsPromptInput =
            abstract functions: option<ResizeArray<FunctionDefinition>> with get, set

            [<EmitProperty("function_call")>]
            abstract functionCall: option<U2<ChatCompletionsPromptInput.FunctionCall, AiModels._Lit184>> with get, set

            [<EmitProperty("web_search_options")>]
            abstract webSearchOptions: option<WebSearchOptions> with get, set

            abstract user: option<D1SessionBookmark> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract tools: option<ResizeArray<ChatCompletionTool>> with get, set

            [<EmitProperty("tool_choice")>]
            abstract toolChoice: option<ChatCompletionToolChoiceOption> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("stream_options")>]
            abstract streamOptions: option<ChatCompletionsStreamOptions> with get, set

            abstract stream: option<bool> with get, set
            abstract store: option<bool> with get, set
            abstract stop: option<U2<ResizeArray<D1SessionBookmark>, string>> with get, set

            [<EmitProperty("service_tier")>]
            abstract serviceTier: option<AiModels._Lit147> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<ResponseFormat> with get, set

            [<EmitProperty("chat_template_kwargs")>]
            abstract chatTemplateKwargs: option<ChatTemplateKwargs> with get, set

            [<EmitProperty("reasoning_effort")>]
            abstract reasoningEffort: option<AiModels._Lit156> with get, set

            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            abstract prediction: option<PredictionContent> with get, set

            [<EmitProperty("parallel_tool_calls")>]
            abstract parallelToolCalls: option<bool> with get, set

            abstract n: option<float> with get, set
            abstract modalities: option<ResizeArray<ChatCompletionsPromptInput.Modalities>> with get, set
            abstract metadata: option<Typescript.CSSViewTransitionRule._Lit44> with get, set

            [<EmitProperty("max_completion_tokens")>]
            abstract maxCompletionTokens: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            [<EmitProperty("top_logprobs")>]
            abstract topLogprobs: option<float> with get, set

            abstract logprobs: option<bool> with get, set

            [<EmitProperty("logit_bias")>]
            abstract logitBias: option<Typescript.CSSViewTransitionRule._Lit44> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            abstract audio: option<AudioParams> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfQwenQwen25Coder32BInstruct private () =
            abstract postProcessedOutputs: AiCfQwenQwen25Coder32BInstructOutput with get, set
            abstract inputs: AiCfQwenQwen25Coder32BInstructInput with get, set

        [<Import("@cloudflare/workers-types", "AiSummarizationInput")>]
        type AiSummarizationInput =
            [<EmitProperty("max_length")>]
            abstract maxLength: option<float> with get, set

            [<EmitProperty("input_text")>]
            abstract inputText: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ColoLocalActorNamespace"); AbstractClass; AllowNullLiteral>]
        type ColoLocalActorNamespace private () =
            abstract get: actorId: D1SessionBookmark -> Typescript.CSSViewTransitionRule._Lit3543

        [<Import("@cloudflare/workers-types", "BaseAiSentenceSimilarity"); AbstractClass; AllowNullLiteral>]
        type BaseAiSentenceSimilarity private () =
            abstract postProcessedOutputs: AiSentenceSimilarityOutput with get, set
            abstract inputs: AiSentenceSimilarityInput with get, set

        [<Import("@cloudflare/workers-types", "AiTextClassificationInput")>]
        type AiTextClassificationInput =
            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "SubtleCryptoGenerateKeyAlgorithm")>]
        type SubtleCryptoGenerateKeyAlgorithm =
            abstract namedCurve: option<D1SessionBookmark> with get, set
            abstract length: option<float> with get, set
            abstract publicExponent: option<BufferSource> with get, set
            abstract modulusLength: option<float> with get, set
            abstract hash: option<U2<SubtleCryptoHashAlgorithm, string>> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "TextDecoderConstructorOptions")>]
        type TextDecoderConstructorOptions =
            abstract ignoreBOM: bool with get, set
            abstract fatal: bool with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionMessageCustomToolCall = | [<CompiledName("custom")>] Custom

        type EmailAttachment = U2<SendEmail._Lit4, SendEmail._Lit6>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseRefusalDoneEvent = | [<CompiledName("response.refusal.done")>] ResponseRefusalDone

        [<Import("@cloudflare/workers-types", "Request")>]
        type Request =
            inherit Body
            abstract keepalive: bool with get
            abstract integrity: D1SessionBookmark with get
            abstract cf: option<'Cf> with get
            abstract signal: AbortSignal with get
            abstract fetcher: option<Typescript.CSSViewTransitionRule._Lit3543> with get
            abstract redirect: D1SessionBookmark with get
            abstract headers: Headers with get
            abstract url: D1SessionBookmark with get
            abstract method: D1SessionBookmark with get
            abstract url: D1SessionBookmark with get
            abstract signal: AbortSignal with get
            abstract referrerPolicy: ReferrerPolicy with get
            abstract referrer: D1SessionBookmark with get
            abstract redirect: RequestRedirect with get
            abstract mode: RequestMode with get
            abstract method: D1SessionBookmark with get
            abstract keepalive: bool with get
            abstract integrity: D1SessionBookmark with get
            abstract headers: Headers with get
            abstract destination: RequestDestination with get
            abstract credentials: RequestCredentials with get
            abstract cache: RequestCache with get
            abstract clone: unit -> Request
            abstract clone: unit -> Request

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Klein_9B_Output")>]
        type AiCfBlackForestLabsFlux2Klein9BOutput =
            abstract image: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "LoopbackColoLocalActorNamespace"); AbstractClass; AllowNullLiteral>]
        type LoopbackColoLocalActorNamespace private () =
            inherit ColoLocalActorNamespace()

        [<Import("@cloudflare/workers-types", "Ai_Cf_Deepgram_Nova_3_Output")>]
        type AiCfDeepgramNova3Output =
            abstract results: option<AiModels._Lit120> with get, set

        [<Import("@cloudflare/workers-types", "WritableStream"); AbstractClass; AllowNullLiteral>]
        type WritableStream<'W> private () =
            [<EmitConstructor>]
            abstract Create:
                ?underlyingSink: UnderlyingSink<option<obj>> * ?queuingStrategy: QueuingStrategy<option<obj>> ->
                    WritableStream

            abstract locked: bool with get
            abstract getWriter: unit -> WritableStreamDefaultWriter<'W>
            abstract close: unit -> Promise<unit>
            abstract abort: ?reason: obj -> Promise<unit>

        [<Import("@cloudflare/workers-types", "RateLimitOutcome")>]
        type RateLimitOutcome =
            abstract success: bool with get, set

        [<Import("@cloudflare/workers-types", "TraceItemFetchEventInfo")>]
        type TraceItemFetchEventInfo =
            abstract request: TraceItemFetchEventInfoRequest with get
            abstract response: option<TraceItemFetchEventInfoResponse> with get

        [<Import("@cloudflare/workers-types", "FetchEvent"); AbstractClass; AllowNullLiteral>]
        type FetchEvent private () =
            inherit ExtendableEvent()
            abstract request: Request with get
            abstract passThroughOnException: unit -> unit
            abstract respondWith: promise: U2<Global.Response, Promise<Global.Response>> -> unit

        [<Import("@cloudflare/workers-types", "CacheContext")>]
        type CacheContext =
            abstract purge: options: CachePurgeOptions -> Promise<CachePurgeResult>

        [<Import("@cloudflare/workers-types", "AiOptions")>]
        type AiOptions =
            abstract signal: option<AbortSignal> with get, set
            abstract extraHeaders: option<obj> with get, set
            abstract prefix: option<D1SessionBookmark> with get, set
            abstract returnRawResponse: option<bool> with get, set
            abstract gateway: option<GatewayOptions> with get, set
            abstract tags: option<ResizeArray<D1SessionBookmark>> with get, set
            abstract websocket: option<bool> with get, set
            abstract queueRequest: option<bool> with get, set

        type SetTimeout =
            abstract Invoke:
                callback: ServiceWorkerGlobalScope._Lit3 * ?msDelay: float * [<ParamArray>] args: 'Args -> float

            abstract Invoke: callback: ServiceWorkerGlobalScope._Lit2 * ?msDelay: float -> float

            abstract Invoke:
                handler: TimerHandler * ?timeout: float * [<ParamArray>] arguments: ResizeArray<option<obj>> -> float

        [<Import("@cloudflare/workers-types", "DurableObjectTransaction")>]
        type DurableObjectTransaction =
            abstract deleteAlarm: ?options: DurableObjectSetAlarmOptions -> Promise<unit>
            abstract setAlarm: scheduledTime: U2<Date, float> * ?options: DurableObjectSetAlarmOptions -> Promise<unit>
            abstract getAlarm: ?options: DurableObjectGetAlarmOptions -> Promise<option<float>>
            abstract rollback: unit -> unit
            abstract delete: keys: ResizeArray<D1SessionBookmark> * ?options: DurableObjectPutOptions -> Promise<float>
            abstract delete: key: D1SessionBookmark * ?options: DurableObjectPutOptions -> Promise<bool>
            abstract put: entries: WebAssembly.ModuleImports * ?options: DurableObjectPutOptions -> Promise<unit>
            abstract put: key: D1SessionBookmark * value: 'T * ?options: DurableObjectPutOptions -> Promise<unit>
            abstract list: ?options: DurableObjectListOptions -> Promise<Map<D1SessionBookmark, 'T>>

            abstract get:
                keys: ResizeArray<D1SessionBookmark> * ?options: DurableObjectGetOptions ->
                    Promise<Map<D1SessionBookmark, 'T>>

            abstract get: key: D1SessionBookmark * ?options: DurableObjectGetOptions -> Promise<option<'T>>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type __WORKER_ENTRYPOINT_BRAND = | __WORKER_ENTRYPOINT_BRAND

        [<Import("@cloudflare/workers-types", "TraceException")>]
        type TraceException =
            abstract stack: option<D1SessionBookmark> with get
            abstract name: D1SessionBookmark with get
            abstract message: D1SessionBookmark with get
            abstract timestamp: float with get

        [<Import("@cloudflare/workers-types", "FlagshipEvaluationDetails")>]
        type FlagshipEvaluationDetails<'T> =
            abstract errorMessage: option<string> with get, set
            abstract errorCode: option<string> with get, set
            abstract reason: option<string> with get, set
            abstract variant: option<string> with get, set
            abstract value: 'T with get, set
            abstract flagKey: D1SessionBookmark with get, set

        type AiSentenceSimilarityOutput = obj

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_3")>]
        type AiCfAisingaporeGemmaSeaLionV427BItJSONMode3 =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiModels._Lit80> with get, set

        type QueueMicrotask =
            abstract Invoke: task: Function -> unit
            abstract Invoke: callback: VoidFunction -> unit

        [<Import("@cloudflare/workers-types", "EventInit")>]
        type EventInit =
            abstract composed: option<bool> with get, set
            abstract cancelable: option<bool> with get, set
            abstract bubbles: option<bool> with get, set
            abstract composed: option<bool> with get, set
            abstract cancelable: option<bool> with get, set
            abstract bubbles: option<bool> with get, set

        type OnRequest =
            abstract data: 'Data with get, set
            abstract params: WebAssembly.ModuleImports with get, set
            abstract env: PagesFunction._Lit6 with get, set
            abstract functionPath: D1SessionBookmark with get, set
            abstract request: Request with get, set
            abstract next: ?input: RequestInfo * ?init: RequestInit -> Promise<Global.Response>
            abstract passThroughOnException: unit -> unit
            abstract waitUntil: promise: Promise<option<obj>> -> unit

        [<Import("@cloudflare/workers-types", "WorkerLoaderWorkerCode")>]
        type WorkerLoaderWorkerCode =
            abstract streamingTails: option<ResizeArray<Typescript.CSSViewTransitionRule._Lit3543>> with get, set
            abstract tails: option<ResizeArray<Typescript.CSSViewTransitionRule._Lit3543>> with get, set
            abstract globalOutbound: option<Typescript.CSSViewTransitionRule._Lit3543> with get, set
            abstract env: option<obj> with get, set
            abstract modules: WebAssembly.ModuleImports with get, set
            abstract mainModule: D1SessionBookmark with get, set
            abstract limits: option<WorkerdResourceLimits> with get, set
            abstract allowExperimental: option<bool> with get, set
            abstract compatibilityFlags: option<ResizeArray<D1SessionBookmark>> with get, set
            abstract compatibilityDate: D1SessionBookmark with get, set

        type AiCfGoogleGemma312BItInput = obj

        [<Import("@cloudflare/workers-types", "RequestInitCfProperties")>]
        type RequestInitCfProperties =
            inherit WebAssembly.ModuleImports
            abstract resolveOverride: option<D1SessionBookmark> with get, set
            abstract r2: option<RequestInitCfPropertiesR2> with get, set
            abstract polish: option<Typescript.CSSViewTransitionRule._Lit3563> with get, set
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
            abstract cacheTtlByStatus: option<WebAssembly.ModuleImports> with get, set
            abstract cacheTtl: option<float> with get, set
            abstract cacheTags: option<ResizeArray<D1SessionBookmark>> with get, set
            abstract cacheKey: option<D1SessionBookmark> with get, set
            abstract cacheEverything: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Black_Forest_Labs_Flux_1_Schnell");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfBlackForestLabsFlux1Schnell private () =
            abstract postProcessedOutputs: AiCfBlackForestLabsFlux1SchnellOutput with get, set
            abstract inputs: AiCfBlackForestLabsFlux1SchnellInput with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type CfProperties = | [<CompiledName("1")>] ``1``

        type AiCfBaaiBgeLargeEnV15Input = obj

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionCustomToolTextFormat = | [<CompiledName("text")>] Text

        [<Import("@cloudflare/workers-types", "CountQueuingStrategy"); AbstractClass; AllowNullLiteral>]
        type CountQueuingStrategy private () =
            inherit QueuingStrategy<option<obj>>()

            [<EmitConstructor>]
            abstract Create: init: Global.QueuingStrategyInit -> CountQueuingStrategy

            abstract highWaterMark: float with get
            abstract size: ?chunk: obj -> float

        [<Import("@cloudflare/workers-types", "Ai_Cf_Google_Gemma_3_12B_It_Prompt")>]
        type AiCfGoogleGemma312BItPrompt =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiImageClassificationInput")>]
        type AiImageClassificationInput =
            abstract image: AiSentenceSimilarityOutput with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseReasoningItem = | [<CompiledName("reasoning")>] Reasoning

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
            abstract delete: keys: ResizeArray<D1SessionBookmark> * ?options: DurableObjectPutOptions -> Promise<float>
            abstract delete: key: D1SessionBookmark * ?options: DurableObjectPutOptions -> Promise<bool>
            abstract put: entries: WebAssembly.ModuleImports * ?options: DurableObjectPutOptions -> Promise<unit>
            abstract put: key: D1SessionBookmark * value: 'T * ?options: DurableObjectPutOptions -> Promise<unit>
            abstract list: ?options: DurableObjectListOptions -> Promise<Map<D1SessionBookmark, 'T>>

            abstract get:
                keys: ResizeArray<D1SessionBookmark> * ?options: DurableObjectGetOptions ->
                    Promise<Map<D1SessionBookmark, 'T>>

            abstract get: key: D1SessionBookmark * ?options: DurableObjectGetOptions -> Promise<option<'T>>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionContentPartFile = | [<CompiledName("file")>] File

        [<Import("@cloudflare/workers-types", "WorkerLoaderModule")>]
        type WorkerLoaderModule =
            abstract wasm: option<ArrayBuffer> with get, set
            abstract py: option<D1SessionBookmark> with get, set
            abstract json: option<obj> with get, set
            abstract data: option<ArrayBuffer> with get, set
            abstract text: option<D1SessionBookmark> with get, set
            abstract cjs: option<D1SessionBookmark> with get, set
            abstract js: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "VectorizeMatches")>]
        type VectorizeMatches =
            abstract count: float with get, set
            abstract matches: ResizeArray<VectorizeMatch> with get, set

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRagSearchRequest")>]
        type AutoRagSearchRequest =
            [<EmitProperty("rewrite_query")>]
            abstract rewriteQuery: option<bool> with get, set

            abstract reranking: option<AutoRAG._Lit9> with get, set

            [<EmitProperty("ranking_options")>]
            abstract rankingOptions: option<AutoRAG._Lit8> with get, set

            [<EmitProperty("max_num_results")>]
            abstract maxNumResults: option<float> with get, set

            abstract filters: option<U2<AutoRAG._Lit4, AutoRAG._Lit6>> with get, set
            abstract query: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AssistantMessage = | [<CompiledName("assistant")>] Assistant

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionUrlCitation = | [<CompiledName("url_citation")>] UrlCitation

        [<Import("@cloudflare/workers-types", "SubtleCryptoHashAlgorithm")>]
        type SubtleCryptoHashAlgorithm =
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "D1ExecResult")>]
        type D1ExecResult =
            abstract duration: float with get, set
            abstract count: float with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectId")>]
        type DurableObjectId =
            abstract jurisdiction: option<D1SessionBookmark> with get
            abstract name: option<D1SessionBookmark> with get
            abstract equals: other: DurableObjectId -> bool
            abstract toString: unit -> D1SessionBookmark

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type Tool = | [<CompiledName("function")>] Function

        [<Import("@cloudflare/workers-types", "AiTextGenerationFunctionsInput")>]
        type AiTextGenerationFunctionsInput =
            abstract code: D1SessionBookmark with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "StreamPublicDetails")>]
        type StreamPublicDetails =
            abstract logo: option<string> with get, set

            [<EmitProperty("channel_link")>]
            abstract channelLink: option<string> with get, set

            [<EmitProperty("share_link")>]
            abstract shareLink: option<string> with get, set

            abstract title: option<string> with get, set

        [<Import("@cloudflare/workers-types", "StreamVideosListParams")>]
        type StreamVideosListParams =
            abstract afterComp: option<StreamPaginationComparison> with get, set
            abstract after: option<D1SessionBookmark> with get, set
            abstract beforeComp: option<StreamPaginationComparison> with get, set
            abstract before: option<D1SessionBookmark> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "ResponseFunctionToolCallItem")>]
        type ResponseFunctionToolCallItem =
            inherit ResponseFunctionToolCall
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiTextGenerationToolLegacyInput")>]
        type AiTextGenerationToolLegacyInput =
            abstract parameters: option<AiModels._Lit18> with get, set
            abstract description: D1SessionBookmark with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "SubtleCryptoImportKeyAlgorithm")>]
        type SubtleCryptoImportKeyAlgorithm =
            abstract compressed: option<bool> with get, set
            abstract namedCurve: option<D1SessionBookmark> with get, set
            abstract length: option<float> with get, set
            abstract hash: option<U2<SubtleCryptoHashAlgorithm, string>> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "R2ListOptions")>]
        type R2ListOptions =
            abstract startAfter: option<D1SessionBookmark> with get, set
            abstract delimiter: option<D1SessionBookmark> with get, set
            abstract cursor: option<D1SessionBookmark> with get, set
            abstract prefix: option<D1SessionBookmark> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Klein_4B_Input")>]
        type AiCfBlackForestLabsFlux2Klein4BInput =
            abstract multipart: AiModels._Lit57 with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseOutputItemAddedEvent = | [<CompiledName("response.output_item.added")>] ResponseOutputItemAdded

        [<Import("@cloudflare/workers-types", "ChatCompletionTokenLogprob")>]
        type ChatCompletionTokenLogprob =
            [<EmitProperty("top_logprobs")>]
            abstract topLogprobs: ResizeArray<ChatCompletionTopLogprob> with get, set

            abstract bytes: option<ResizeArray<float>> with get, set
            abstract logprob: float with get, set
            abstract token: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ImageTransformationOutputOptions = | [<CompiledName("base64")>] Base64

        [<Import("@cloudflare/workers-types", "BlobOptions")>]
        type BlobOptions =
            [<EmitProperty("type")>]
            abstract ``type``: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "TraceItemHibernatableWebSocketEventInfoClose")>]
        type TraceItemHibernatableWebSocketEventInfoClose =
            abstract wasClean: bool with get
            abstract code: float with get
            abstract webSocketEventType: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "URLPatternComponentResult")>]
        type URLPatternComponentResult =
            abstract groups: WebAssembly.ModuleImports with get, set
            abstract input: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Scheduler")>]
        type Scheduler =
            abstract wait: delay: float * ?maybeOptions: SchedulerWaitOptions -> Promise<unit>

        [<Import("@cloudflare/workers-types", "DurableObject")>]
        type DurableObject =
            abstract webSocketError: ws: Global.WebSocket * ?error: obj -> option<Promise<unit>>

            abstract webSocketClose:
                ws: Global.WebSocket * code: float * reason: D1SessionBookmark * wasClean: bool -> option<Promise<unit>>

            abstract webSocketMessage: ws: Global.WebSocket * message: U2<ArrayBuffer, string> -> option<Promise<unit>>
            abstract alarm: ?alarmInfo: AlarmInvocationInfo -> option<Promise<unit>>
            abstract connect: socket: Socket -> option<Promise<unit>>
            abstract fetch: request: Request -> U2<Global.Response, Promise<Global.Response>>

        [<Import("@cloudflare/workers-types", "AiSearchUploadItemOptions")>]
        type AiSearchUploadItemOptions =
            abstract metadata: option<WebAssembly.ModuleImports> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_Base_En_V1_5_AsyncResponse")>]
        type AiCfBaaiBgeBaseEnV15AsyncResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "BaseAiAutomaticSpeechRecognition"); AbstractClass; AllowNullLiteral>]
        type BaseAiAutomaticSpeechRecognition private () =
            abstract postProcessedOutputs: AiAutomaticSpeechRecognitionOutput with get, set
            abstract inputs: AiAutomaticSpeechRecognitionInput with get, set

        [<Import("@cloudflare/workers-types", "AiSearchListJobsParams")>]
        type AiSearchListJobsParams =
            [<EmitProperty("per_page")>]
            abstract perPage: option<float> with get, set

            abstract page: option<float> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItemLogsParams")>]
        type AiSearchItemLogsParams =
            abstract cursor: option<D1SessionBookmark> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages")>]
        type AiCfMetaLlama4Scout17B16EInstructMessages =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfMetaLlama4Scout17B16EInstructJSONMode> with get, set

            abstract tools: option<ResizeArray<U2<AiModels._Lit72, AiModels._Lit76>>> with get, set
            abstract functions: option<ResizeArray<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: ResizeArray<AiModels._Lit67> with get, set

        [<Import("@cloudflare/workers-types", "StreamScopedCaptions")>]
        type StreamScopedCaptions =
            abstract delete: language: D1SessionBookmark -> Promise<unit>
            abstract list: ?language: D1SessionBookmark -> Promise<ResizeArray<StreamCaption>>
            abstract generate: language: D1SessionBookmark -> Promise<StreamCaption>
            abstract upload: language: D1SessionBookmark * input: AiTextToImageOutput -> Promise<StreamCaption>

        [<Import("@cloudflare/workers-types", "StreamVideoInput")>]
        type StreamVideoInput =
            abstract height: float with get, set
            abstract width: float with get, set

        [<Import("@cloudflare/workers-types", "ContainerStartupOptions")>]
        type ContainerStartupOptions =
            abstract containerSnapshot: option<ContainerSnapshot> with get, set
            abstract directorySnapshots: option<ResizeArray<ContainerDirectorySnapshotRestoreParams>> with get, set
            abstract labels: option<WebAssembly.ModuleImports> with get, set
            abstract env: option<WebAssembly.ModuleImports> with get, set
            abstract enableInternet: bool with get, set
            abstract entrypoint: option<ResizeArray<D1SessionBookmark>> with get, set

        type AiCfMetaLlama3211BVisionInstructInput = obj

        [<Import("@cloudflare/workers-types", "VectorizeVector")>]
        type VectorizeVector =
            abstract metadata: option<WebAssembly.ModuleImports> with get, set

            [<EmitProperty("namespace")>]
            abstract ``namespace``: option<D1SessionBookmark> with get, set

            abstract values: U3<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>, ResizeArray<float>> with get, set
            abstract id: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseOutputItemDoneEvent = | [<CompiledName("response.output_item.done")>] ResponseOutputItemDone

        [<Import("@cloudflare/workers-types", "MediaTransformationOutputOptions")>]
        type MediaTransformationOutputOptions =
            abstract format: option<MediaTransformationOutputOptions._Lit3> with get, set
            abstract imageCount: option<float> with get, set
            abstract duration: option<D1SessionBookmark> with get, set
            abstract time: option<D1SessionBookmark> with get, set
            abstract audio: option<bool> with get, set
            abstract mode: option<MediaTransformationOutputOptions._Lit2> with get, set

        [<Import("@cloudflare/workers-types", "BaseAiTextClassification"); AbstractClass; AllowNullLiteral>]
        type BaseAiTextClassification private () =
            abstract postProcessedOutputs: AiTextClassificationOutput with get, set
            abstract inputs: AiTextClassificationInput with get, set

        type BufferSource = U2<ArrayBufferView<ArrayBufferLike>, ArrayBuffer>

        [<Import("@cloudflare/workers-types", "StreamVideos")>]
        type StreamVideos =
            abstract list: ?params: StreamVideosListParams -> Promise<ResizeArray<StreamVideo>>

        [<Import("@cloudflare/workers-types", "ChatCompletionTopLogprob")>]
        type ChatCompletionTopLogprob =
            abstract bytes: option<ResizeArray<float>> with get, set
            abstract logprob: float with get, set
            abstract token: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Flagship"); AbstractClass; AllowNullLiteral>]
        type Flagship private () =
            abstract getObjectDetails:
                flagKey: D1SessionBookmark * defaultValue: 'T * ?context: FlagshipEvaluationContext ->
                    Promise<FlagshipEvaluationDetails<'T>>

            abstract getNumberDetails:
                flagKey: D1SessionBookmark * defaultValue: float * ?context: FlagshipEvaluationContext ->
                    Promise<FlagshipEvaluationDetails<float>>

            abstract getStringDetails:
                flagKey: D1SessionBookmark * defaultValue: D1SessionBookmark * ?context: FlagshipEvaluationContext ->
                    Promise<FlagshipEvaluationDetails<D1SessionBookmark>>

            abstract getBooleanDetails:
                flagKey: D1SessionBookmark * defaultValue: bool * ?context: FlagshipEvaluationContext ->
                    Promise<FlagshipEvaluationDetails<bool>>

            abstract getObjectValue:
                flagKey: D1SessionBookmark * defaultValue: 'T * ?context: FlagshipEvaluationContext -> Promise<'T>

            abstract getNumberValue:
                flagKey: D1SessionBookmark * defaultValue: float * ?context: FlagshipEvaluationContext -> Promise<float>

            abstract getStringValue:
                flagKey: D1SessionBookmark * defaultValue: D1SessionBookmark * ?context: FlagshipEvaluationContext ->
                    Promise<D1SessionBookmark>

            abstract getBooleanValue:
                flagKey: D1SessionBookmark * defaultValue: bool * ?context: FlagshipEvaluationContext -> Promise<bool>

            abstract get:
                flagKey: D1SessionBookmark * ?defaultValue: obj * ?context: FlagshipEvaluationContext ->
                    Promise<option<obj>>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfAi4BharatIndictrans2EnIndic1B private () =
            abstract postProcessedOutputs: AiCfAi4BharatIndictrans2EnIndic1BOutput with get, set
            abstract inputs: AiCfAi4BharatIndictrans2EnIndic1BInput with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type D1SessionConstraint =
            | [<CompiledName("first-primary")>] FirstPrimary
            | [<CompiledName("first-unconstrained")>] FirstUnconstrained

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Openai_Whisper_Tiny_En"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfOpenaiWhisperTinyEn private () =
            abstract postProcessedOutputs: AiCfOpenaiWhisperTinyEnOutput with get, set
            abstract inputs: AiCfOpenaiWhisperTinyEnInput with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectGetAlarmOptions")>]
        type DurableObjectGetAlarmOptions =
            abstract allowConcurrency: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchJob"); AbstractClass; AllowNullLiteral>]
        type AiSearchJob private () =
            abstract cancel: unit -> Promise<AiSearchJobInfo>
            abstract logs: ?params: AiSearchJobLogsParams -> Promise<AiSearchJobLogsResponse>
            abstract info: unit -> Promise<AiSearchJobInfo>

        [<Import("@cloudflare/workers-types", "ArtifactsRepo")>]
        type ArtifactsRepo =
            inherit ArtifactsRepoInfo
            abstract fork: name: D1SessionBookmark * ?opts: Artifacts._Lit5 -> Promise<ArtifactsCreateRepoResult>
            abstract revokeToken: tokenOrId: D1SessionBookmark -> Promise<bool>
            abstract listTokens: unit -> Promise<ArtifactsTokenListResult>
            abstract createToken: ?scope: Artifacts._Lit2 * ?ttl: float -> Promise<ArtifactsCreateTokenResult>

        [<Import("@cloudflare/workers-types", "EventPluginContext")>]
        type EventPluginContext<'PluginArgs, 'Data, 'P, 'Env when 'P :> D1SessionBookmark> =
            abstract pluginArgs: 'PluginArgs with get, set
            abstract data: 'Data with get, set
            abstract params: WebAssembly.ModuleImports with get, set
            abstract env: PagesFunction._Lit6 with get, set
            abstract functionPath: D1SessionBookmark with get, set
            abstract request: Request with get, set
            abstract next: ?input: RequestInfo * ?init: RequestInit -> Promise<Global.Response>
            abstract passThroughOnException: unit -> unit
            abstract waitUntil: promise: Promise<option<obj>> -> unit

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRAGNameNotSetError"); AbstractClass; AllowNullLiteral>]
        type AutoRAGNameNotSetError private () =
            inherit exn()

        [<Import("@cloudflare/workers-types", "ImageOutputOptions")>]
        type ImageOutputOptions =
            abstract anim: option<bool> with get, set
            abstract background: option<D1SessionBookmark> with get, set
            abstract quality: option<float> with get, set
            abstract format: ImageTransformer._Lit14 with get, set

        [<Import("@cloudflare/workers-types", "ReadableStreamDefaultController")>]
        type ReadableStreamDefaultController<'R> =
            abstract desiredSize: option<float> with get
            abstract desiredSize: option<float> with get
            abstract error: ?reason: obj -> unit
            abstract enqueue: ?chunk: 'R -> unit
            abstract close: unit -> unit
            abstract error: ?e: obj -> unit
            abstract enqueue: ?chunk: 'R -> unit
            abstract close: unit -> unit

        [<Import("@cloudflare/workers-types", "Workflow"); AbstractClass; AllowNullLiteral>]
        type Workflow<'PARAMS> private () =
            abstract createBatch:
                batch: ResizeArray<WorkflowInstanceCreateOptions<'PARAMS>> -> Promise<ResizeArray<WorkflowInstance>>

            abstract create: ?options: WorkflowInstanceCreateOptions<'PARAMS> -> Promise<WorkflowInstance>
            abstract get: id: D1SessionBookmark -> Promise<WorkflowInstance>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Openai_Whisper_Large_V3_Turbo_Output")>]
        type AiCfOpenaiWhisperLargeV3TurboOutput =
            abstract vtt: option<D1SessionBookmark> with get, set
            abstract segments: option<ResizeArray<AiModels._Lit59>> with get, set

            [<EmitProperty("word_count")>]
            abstract wordCount: option<float> with get, set

            abstract text: D1SessionBookmark with get, set

            [<EmitProperty("transcription_info")>]
            abstract transcriptionInfo: option<AiModels._Lit58> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Async_Batch")>]
        type AiCfMetaLlama4Scout17B16EInstructAsyncBatch =
            abstract requests:
                ResizeArray<
                    U2<AiCfMetaLlama4Scout17B16EInstructPromptInner, AiCfMetaLlama4Scout17B16EInstructMessagesInner>
                 > with get, set

        type AiCfQwenQwq32BInput = obj
        type AiCfMetaM2M10012BInput = obj

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseCompletedEvent = | [<CompiledName("response.completed")>] ResponseCompleted

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type DurableObjectRoutingMode = | [<CompiledName("primary-only")>] DurableObjectRoutingMode

        [<Import("@cloudflare/workers-types", "AiSearchMultiSearchChunk")>]
        type AiSearchMultiSearchChunk =
            [<EmitProperty("instance_id")>]
            abstract instanceId: D1SessionBookmark with get, set

            [<EmitProperty("scoring_details")>]
            abstract scoringDetails: option<Ai._Lit19> with get, set

            abstract item: Ai._Lit18 with get, set
            abstract text: D1SessionBookmark with get, set
            abstract score: float with get, set

            [<EmitProperty("type")>]
            abstract ``type``: D1SessionBookmark with get, set

            abstract id: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type Element =
            | [<CompiledName("http://www.w3.org/1998/Math/MathML")>] ``Http:/wwwW3Org1998MathMathML``
            | [<CompiledName("http://www.w3.org/2000/svg")>] ``Http:/wwwW3Org2000Svg``
            | [<CompiledName("http://www.w3.org/1999/xhtml")>] ``Http:/wwwW3Org1999Xhtml``

        [<Import("@cloudflare/workers-types", "SqlStorageCursor"); AbstractClass; AllowNullLiteral>]
        type SqlStorageCursor<'T when 'T :> WebAssembly.ModuleImports> private () =
            abstract rowsWritten: float with get
            abstract rowsRead: float with get
            abstract columnNames: ResizeArray<D1SessionBookmark> with get, set
            abstract symbolIterator: unit -> System.Collections.Generic.IEnumerator<'T, option<obj>, option<obj>>
            abstract raw: unit -> System.Collections.Generic.IEnumerator<'U, option<obj>, option<obj>>
            abstract one: unit -> 'T
            abstract toArray: unit -> ResizeArray<'T>
            abstract next: unit -> U2<LoopbackForExport._Lit20, LoopbackForExport._Lit21>

        [<Import("@cloudflare/workers-types", "SecretsStoreSecret")>]
        type SecretsStoreSecret =
            abstract get: unit -> Promise<D1SessionBookmark>

        [<Import("@cloudflare/workers-types", "ImagesError"); AbstractClass; AllowNullLiteral>]
        type ImagesError private () =
            inherit exn()
            abstract stack: option<D1SessionBookmark> with get
            abstract message: D1SessionBookmark with get
            abstract code: float with get

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages")>]
        type AiCfQwenQwen330BA3BFp8Messages =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfQwenQwen330BA3BFp8JSONMode1> with get, set

            abstract tools: option<ResizeArray<U2<AiModels._Lit72, AiModels._Lit76>>> with get, set
            abstract functions: option<ResizeArray<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: ResizeArray<AiModels._Lit81> with get, set

        [<Import("@cloudflare/workers-types", "ComparisonFilter")>]
        type ComparisonFilter =
            abstract value: U3<string, float, bool> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: AutoRAG._Lit7 with get, set

            abstract key: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type VectorizeMetadataRetrievalLevel =
            | [<CompiledName("all")>] All
            | [<CompiledName("indexed")>] Indexed
            | [<CompiledName("none")>] None

        [<Import("@cloudflare/workers-types", "ResponseFunctionToolCall")>]
        type ResponseFunctionToolCall =
            abstract status: option<AiModels._Lit252> with get, set
            abstract id: option<D1SessionBookmark> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ResponseFunctionToolCall.Type with get, set

            abstract name: D1SessionBookmark with get, set

            [<EmitProperty("call_id")>]
            abstract callId: D1SessionBookmark with get, set

            abstract arguments: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ResponseInputText")>]
        type ResponseInputText =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseInputText.Type with get, set

            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiSearchJobLogsParams")>]
        type AiSearchJobLogsParams =
            [<EmitProperty("per_page")>]
            abstract perPage: option<float> with get, set

            abstract page: option<float> with get, set

        [<Import("@cloudflare/workers-types", "EventListener")>]
        type EventListener<'EventType when 'EventType :> Event> =
            abstract Invoke: event: 'EventType -> unit

        type Service =
            abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket
            abstract fetch: input: U3<Request, URL, string> * ?init: RequestInit -> Promise<Global.Response>
            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, Promise<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, Promise<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, Promise<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke:
                [<ParamArray>] args: Service.Invoke.Args ->
                    U2<Typescript.CSSViewTransitionRule._Lit31, U2<Typescript.CSSViewTransitionRule._Lit3576, unit>>

        [<Import("@cloudflare/workers-types", "TraceItemHibernatableWebSocketEventInfoError")>]
        type TraceItemHibernatableWebSocketEventInfoError =
            abstract webSocketEventType: D1SessionBookmark with get

        type AiCfOpenaiWhisperInput = obj

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseFormatJSONObject = | [<CompiledName("json_object")>] JsonObject

        type AiCfBaaiBgeSmallEnV15Input = obj

        [<Import("@cloudflare/workers-types", "AiSearchMultiSearchOptions")>]
        type AiSearchMultiSearchOptions =
            [<EmitProperty("instance_ids")>]
            abstract instanceIds: ResizeArray<D1SessionBookmark> with get, set

            abstract cache: option<Ai._Lit11> with get, set
            abstract reranking: option<Ai._Lit10> with get, set

            [<EmitProperty("query_rewrite")>]
            abstract queryRewrite: option<Ai._Lit9> with get, set

            abstract retrieval: option<Ai._Lit4> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "DurableObjectListOptions")>]
        type DurableObjectListOptions =
            abstract noCache: option<bool> with get, set
            abstract allowConcurrency: option<bool> with get, set
            abstract limit: option<float> with get, set
            abstract reverse: option<bool> with get, set
            abstract prefix: option<D1SessionBookmark> with get, set

            [<EmitProperty("end")>]
            abstract ``end``: option<D1SessionBookmark> with get, set

            abstract startAfter: option<D1SessionBookmark> with get, set
            abstract start: option<D1SessionBookmark> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type BadRequestError = | BadRequestError

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesBotManagement")>]
        type IncomingRequestCfPropertiesBotManagement =
            /// <deprecated />
            abstract clientTrustScore: float with get, set
            abstract botManagement: IncomingRequestCfPropertiesBotManagementBase with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Pfnet_Plamo_Embedding_1B_Output")>]
        type AiCfPfnetPlamoEmbedding1BOutput =
            abstract shape: float * float with get, set
            abstract data: ResizeArray<AiSentenceSimilarityOutput> with get, set

        [<Import("@cloudflare/workers-types", "ArtifactsCreateTokenResult")>]
        type ArtifactsCreateTokenResult =
            abstract expiresAt: D1SessionBookmark with get, set
            abstract scope: Artifacts._Lit3 with get, set
            abstract plaintext: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_Guard_3_8B_Input")>]
        type AiCfMetaLlamaGuard38BInput =
            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiModels._Lit90> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract messages: ResizeArray<AiModels._Lit88> with get, set

        [<Import("@cloudflare/workers-types", "WorkerStub")>]
        type WorkerStub =
            abstract getDurableObjectClass:
                ?name: D1SessionBookmark * ?options: WorkerStubEntrypointOptions -> DurableObjectClass<'T>

            abstract getEntrypoint:
                ?name: D1SessionBookmark * ?options: WorkerStubEntrypointOptions -> WorkerStub.GetEntrypoint

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type NotFoundError = | NotFoundError

        type AddEventListener =
            abstract Invoke:
                ``type``: 'Type * handler: Body * ?options: U2<EventTargetAddEventListenerOptions, bool> -> unit

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

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseOutputMessage =
            | [<CompiledName("message")>] Message
            | [<CompiledName("assistant")>] Assistant

        [<Import("@cloudflare/workers-types", "StreamDirectUploadCreateParams")>]
        type StreamDirectUploadCreateParams =
            abstract watermark: option<StreamDirectUploadWatermark> with get, set
            abstract scheduledDeletion: option<string> with get, set
            abstract thumbnailTimestampPct: option<float> with get, set
            abstract requireSignedURLs: option<bool> with get, set
            abstract allowedOrigins: option<ResizeArray<D1SessionBookmark>> with get, set
            abstract meta: option<WebAssembly.ModuleImports> with get, set
            abstract creator: option<D1SessionBookmark> with get, set
            abstract expiry: option<D1SessionBookmark> with get, set
            abstract maxDurationSeconds: float with get, set

        [<Import("@cloudflare/workers-types", "TracePreviewInfo")>]
        type TracePreviewInfo =
            abstract name: D1SessionBookmark with get, set
            abstract slug: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_Embedding_0_6B_Input")>]
        type AiCfQwenQwen3Embedding06BInput =
            abstract text: option<U2<ResizeArray<D1SessionBookmark>, string>> with get, set
            abstract documents: option<U2<ResizeArray<D1SessionBookmark>, string>> with get, set
            abstract instruction: option<D1SessionBookmark> with get, set
            abstract queries: option<U2<ResizeArray<D1SessionBookmark>, string>> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfAisingaporeGemmaSeaLionV427BItChatCompletionResponse =
            | [<CompiledName("chat.completion")>] ChatCompletion

        [<Import("@cloudflare/workers-types", "AiSearchMultiChatCompletionsResponse")>]
        type AiSearchMultiChatCompletionsResponse =
            abstract errors: option<ResizeArray<AiSearchMultiSearchError>> with get, set
            abstract chunks: ResizeArray<AiSearchMultiSearchChunk> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "EventTargetHandlerObject")>]
        type EventTargetHandlerObject =
            abstract handleEvent: event: Event -> option<obj>

        [<Import("@cloudflare/workers-types", "D1DatabaseSession"); AbstractClass; AllowNullLiteral>]
        type D1DatabaseSession private () =
            abstract getBookmark: unit -> option<string>

            abstract batch:
                statements: ResizeArray<D1PreparedStatement> -> Promise<ResizeArray<D1DatabaseSession.Batch>>

            abstract prepare: query: D1SessionBookmark -> D1PreparedStatement

        [<Import("@cloudflare/workers-types", "FixedLengthStream"); AbstractClass; AllowNullLiteral>]
        type FixedLengthStream private () =
            inherit IdentityTransformStream()

            [<EmitConstructor>]
            abstract Create:
                expectedLength: float * ?queuingStrategy: IdentityTransformStreamQueuingStrategy -> FixedLengthStream

        [<Import("@cloudflare/workers-types", "ResponsesInput")>]
        type ResponsesInput =
            abstract truncation: option<AiModels._Lit161> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract tools: option<ResizeArray<Tool>> with get, set

            [<EmitProperty("tool_choice")>]
            abstract toolChoice: option<U2<ResponsesInput.ToolChoice, AiModels._Lit158>> with get, set

            abstract text: option<ResponseTextConfig> with get, set
            abstract temperature: option<float> with get, set

            [<EmitProperty("stream_options")>]
            abstract streamOptions: option<AiModels._Lit149> with get, set

            abstract stream: option<bool> with get, set

            [<EmitProperty("service_tier")>]
            abstract serviceTier: option<AiModels._Lit147> with get, set

            [<EmitProperty("safety_identifier")>]
            abstract safetyIdentifier: option<D1SessionBookmark> with get, set

            abstract reasoning: option<AiModels._Lit143> with get, set

            [<EmitProperty("prompt_cache_key")>]
            abstract promptCacheKey: option<D1SessionBookmark> with get, set

            [<EmitProperty("previous_response_id")>]
            abstract previousResponseId: option<string> with get, set

            [<EmitProperty("parallel_tool_calls")>]
            abstract parallelToolCalls: option<bool> with get, set

            [<EmitProperty("max_output_tokens")>]
            abstract maxOutputTokens: option<float> with get, set

            abstract instructions: option<string> with get, set
            abstract input: option<U2<ResizeArray<'T>, string>> with get, set
            abstract include: option<ResizeArray<ResponseIncludable>> with get, set
            abstract conversation: option<U2<AiModels._Lit138, string>> with get, set
            abstract background: option<bool> with get, set

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
            abstract inputs: ResizeArray<U2<URLPatternInit, string>> with get, set

        [<Import("@cloudflare/workers-types", "VectorizeIndex"); AbstractClass; AllowNullLiteral>]
        type VectorizeIndex private () =
            abstract getByIds: ids: ResizeArray<D1SessionBookmark> -> Promise<ResizeArray<VectorizeVector>>
            abstract deleteByIds: ids: ResizeArray<D1SessionBookmark> -> Promise<VectorizeVectorMutation>
            abstract upsert: vectors: ResizeArray<VectorizeVector> -> Promise<VectorizeVectorMutation>
            abstract insert: vectors: ResizeArray<VectorizeVector> -> Promise<VectorizeVectorMutation>

            abstract query:
                vector: U3<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>, ResizeArray<float>> *
                ?options: VectorizeQueryOptions ->
                    Promise<VectorizeMatches>

            abstract describe: unit -> Promise<VectorizeIndexDetails>

        [<Import("@cloudflare/workers-types", "MediaTransformer")>]
        type MediaTransformer =
            abstract output: ?output: MediaTransformationOutputOptions -> MediaTransformationResult
            abstract transform: ?transform: MediaTransformationInputOptions -> MediaTransformationGenerator

        [<Import("@cloudflare/workers-types", "AiTextGenerationToolLegacyOutput")>]
        type AiTextGenerationToolLegacyOutput =
            abstract arguments: option<obj> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "DOMException"); AbstractClass; AllowNullLiteral>]
        type DOMException private () =
            inherit exn()

            [<EmitConstructor>]
            abstract Create: ?message: D1SessionBookmark * ?name: D1SessionBookmark -> DOMException

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

        [<Import("@cloudflare/workers-types", "TextDecoderStream"); AbstractClass; AllowNullLiteral>]
        type TextDecoderStream private () =
            inherit TransformStream<BufferSource, D1SessionBookmark>()

            [<EmitConstructor>]
            abstract Create:
                ?label: D1SessionBookmark * ?options: TextDecoderStreamTextDecoderStreamInit -> TextDecoderStream

            abstract ignoreBOM: bool with get
            abstract fatal: bool with get
            abstract encoding: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "MarkdownDocument")>]
        type MarkdownDocument =
            abstract blob: Blob with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiSearchConfig")>]
        type AiSearchConfig =
            abstract metadata: option<WebAssembly.ModuleImports> with get, set

            [<EmitProperty("sync_interval")>]
            abstract syncInterval: option<Ai._Lit36> with get, set

            [<EmitProperty("namespace")>]
            abstract ``namespace``: option<D1SessionBookmark> with get, set

            [<EmitProperty("custom_metadata")>]
            abstract customMetadata: option<ResizeArray<Ai._Lit34>> with get, set

            [<EmitProperty("cache_threshold")>]
            abstract cacheThreshold: option<Ai._Lit12> with get, set

            abstract cache: option<bool> with get, set

            [<EmitProperty("max_num_results")>]
            abstract maxNumResults: option<float> with get, set

            [<EmitProperty("score_threshold")>]
            abstract scoreThreshold: option<float> with get, set

            [<EmitProperty("chunk_overlap")>]
            abstract chunkOverlap: option<float> with get, set

            [<EmitProperty("chunk_size")>]
            abstract chunkSize: option<float> with get, set

            abstract chunk: option<bool> with get, set

            [<EmitProperty("retrieval_options")>]
            abstract retrievalOptions: option<Ai._Lit33> with get, set

            [<EmitProperty("indexing_options")>]
            abstract indexingOptions: option<Ai._Lit30> with get, set

            [<EmitProperty("fusion_method")>]
            abstract fusionMethod: option<Ai._Lit6> with get, set

            [<EmitProperty("index_method")>]
            abstract indexMethod: option<Ai._Lit28> with get, set

            /// <deprecated>
            /// Use index_method instead.
            /// </deprecated>
            [<EmitProperty("hybrid_search_enabled")>]
            abstract hybridSearchEnabled: option<bool> with get, set

            [<EmitProperty("reranking_model")>]
            abstract rerankingModel: option<D1SessionBookmark> with get, set

            [<EmitProperty("rewrite_model")>]
            abstract rewriteModel: option<D1SessionBookmark> with get, set

            [<EmitProperty("ai_search_model")>]
            abstract aiSearchModel: option<D1SessionBookmark> with get, set

            [<EmitProperty("embedding_model")>]
            abstract embeddingModel: option<D1SessionBookmark> with get, set

            abstract reranking: option<bool> with get, set

            [<EmitProperty("rewrite_query")>]
            abstract rewriteQuery: option<bool> with get, set

            [<EmitProperty("ai_gateway_id")>]
            abstract aiGatewayId: option<D1SessionBookmark> with get, set

            [<EmitProperty("token_id")>]
            abstract tokenId: option<D1SessionBookmark> with get, set

            [<EmitProperty("source_params")>]
            abstract sourceParams: option<obj> with get, set

            abstract source: option<D1SessionBookmark> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<U2<AiSearchConfig.Type, string>> with get, set

            abstract id: D1SessionBookmark with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "IdentityTransformStream"); AbstractClass; AllowNullLiteral>]
        type IdentityTransformStream private () =
            inherit TransformStream<BufferSource, Uint8Array<ArrayBufferLike>>()

            [<EmitConstructor>]
            abstract Create: ?queuingStrategy: IdentityTransformStreamQueuingStrategy -> IdentityTransformStream

        [<Import("@cloudflare/workers-types", "ChatCompletionsStreamOptions")>]
        type ChatCompletionsStreamOptions =
            [<EmitProperty("include_obfuscation")>]
            abstract includeObfuscation: option<bool> with get, set

            [<EmitProperty("include_usage")>]
            abstract includeUsage: option<bool> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionResponseMessage = | [<CompiledName("assistant")>] Assistant

        [<Import("@cloudflare/workers-types", "DocumentEnd")>]
        type DocumentEnd =
            abstract append: content: D1SessionBookmark * ?options: ContentOptions -> DocumentEnd

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Deepgram_Aura_1"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfDeepgramAura1 private () =
            abstract postProcessedOutputs: D1SessionBookmark with get, set
            abstract inputs: AiCfDeepgramAura1Input with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwq_32B_Output")>]
        type AiCfQwenQwq32BOutput =
            [<EmitProperty("tool_calls")>]
            abstract toolCalls: option<ResizeArray<AiModels._Lit78>> with get, set

            abstract usage: option<AiModels._Lit87> with get, set
            abstract response: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Headers"); AbstractClass; AllowNullLiteral>]
        type Headers private () =
            [<EmitConstructor>]
            abstract Create: ?init: HeadersInit -> Headers

            abstract symbolIterator:
                unit ->
                    System.Collections.Generic.IEnumerator<
                        D1SessionBookmark * D1SessionBookmark,
                        option<obj>,
                        option<obj>
                     >

            abstract values: unit -> System.Collections.Generic.IEnumerator<D1SessionBookmark, option<obj>, option<obj>>
            abstract keys: unit -> System.Collections.Generic.IEnumerator<D1SessionBookmark, option<obj>, option<obj>>

            abstract entries:
                unit ->
                    System.Collections.Generic.IEnumerator<
                        D1SessionBookmark * D1SessionBookmark,
                        option<obj>,
                        option<obj>
                     >

            abstract forEach: callback: Headers._Lit1 * ?thisArg: 'This -> unit
            abstract delete: name: D1SessionBookmark -> unit
            abstract append: name: D1SessionBookmark * value: D1SessionBookmark -> unit
            abstract set: name: D1SessionBookmark * value: D1SessionBookmark -> unit
            abstract has: name: D1SessionBookmark -> bool
            abstract getAll: name: D1SessionBookmark -> ResizeArray<D1SessionBookmark>
            abstract get: name: D1SessionBookmark -> option<string>

        [<Import("@cloudflare/workers-types", "Message")>]
        type Message<'Body> =
            abstract attempts: float with get
            abstract body: 'Body with get
            abstract timestamp: Date with get
            abstract id: D1SessionBookmark with get
            abstract ack: unit -> unit
            abstract retry: ?options: QueueRetryOptions -> unit

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_2")>]
        type AiCfQwenQwen330BA3BFp8JSONMode2 =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiModels._Lit80> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type DeveloperMessage = | [<CompiledName("developer")>] Developer

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages")>]
        type AiCfQwenQwen25Coder32BInstructMessages =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfQwenQwen25Coder32BInstructJSONMode1> with get, set

            abstract tools: option<ResizeArray<U2<AiModels._Lit72, AiModels._Lit76>>> with get, set
            abstract functions: option<ResizeArray<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: ResizeArray<AiModels._Lit94> with get, set

        [<Import("@cloudflare/workers-types", "CloseEvent"); AbstractClass; AllowNullLiteral>]
        type CloseEvent private () =
            inherit Event()

            [<EmitConstructor>]
            abstract Create: ``type``: D1SessionBookmark * ?initializer: Global.CloseEventInit -> CloseEvent

            abstract wasClean: bool with get
            abstract reason: D1SessionBookmark with get
            abstract code: float with get

        [<Import("@cloudflare/workers-types", "TraceItemCustomEventInfo")>]
        type TraceItemCustomEventInfo = interface end

        [<Import("@cloudflare/workers-types", "SyncKvStorage")>]
        type SyncKvStorage =
            abstract delete: key: D1SessionBookmark -> bool
            abstract put: key: D1SessionBookmark * value: 'T -> unit
            abstract list: ?options: SyncKvListOptions -> seq<D1SessionBookmark * 'T, option<obj>, option<obj>>
            abstract get: key: D1SessionBookmark -> option<'T>

        [<Import("@cloudflare/workers-types", "AiAutomaticSpeechRecognitionOutput")>]
        type AiAutomaticSpeechRecognitionOutput =
            abstract vtt: option<D1SessionBookmark> with get, set
            abstract words: option<ResizeArray<BaseAiAutomaticSpeechRecognition._Lit2>> with get, set
            abstract text: option<D1SessionBookmark> with get, set

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRAGUnauthorizedError"); AbstractClass; AllowNullLiteral>]
        type AutoRAGUnauthorizedError private () =
            inherit exn()

        [<Import("@cloudflare/workers-types", "TraceItemJsRpcEventInfo")>]
        type TraceItemJsRpcEventInfo =
            abstract rpcMethod: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "AiSearchItemChunksResponse")>]
        type AiSearchItemChunksResponse =
            [<EmitProperty("result_info")>]
            abstract resultInfo: Ai._Lit61 with get, set

            abstract result: ResizeArray<AiSearchItemChunk> with get, set

        [<Import("@cloudflare/workers-types", "QueuingStrategy")>]
        type QueuingStrategy<'T> =
            abstract highWaterMark: option<float> with get, set
            abstract size: option<QueuingStrategySize<'T>> with get, set
            abstract highWaterMark: option<float> with get, set
            abstract size: chunk: 'T -> float

        [<Import("@cloudflare/workers-types", "MessageEventInit")>]
        type MessageEventInit<'T> =
            inherit EventInit
            abstract data: U2<ArrayBuffer, string> with get, set
            abstract source: option<U3<MessagePort, Window, ServiceWorker>> with get, set
            abstract ports: option<ResizeArray<MessagePort>> with get, set
            abstract origin: option<D1SessionBookmark> with get, set
            abstract lastEventId: option<D1SessionBookmark> with get, set
            abstract data: option<'T> with get, set

        [<Import("@cloudflare/workers-types", "BaseAiTextToSpeech"); AbstractClass; AllowNullLiteral>]
        type BaseAiTextToSpeech private () =
            abstract postProcessedOutputs: AiTextToSpeechOutput with get, set
            abstract inputs: AiTextToSpeechInput with get, set

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

        [<Import("@cloudflare/workers-types", "Blob"); AbstractClass; AllowNullLiteral>]
        type Blob private () =
            [<EmitConstructor>]
            abstract Create:
                ?``type``: ResizeArray<U4<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, Blob, string>> *
                ?options: BlobOptions ->
                    Blob

            [<EmitProperty("type")>]
            abstract ``type``: D1SessionBookmark with get

            abstract size: float with get
            abstract stream: unit -> AiTextToImageOutput
            abstract text: unit -> Promise<D1SessionBookmark>
            abstract bytes: unit -> Promise<Uint8Array<ArrayBufferLike>>
            abstract arrayBuffer: unit -> Promise<ArrayBuffer>
            abstract slice: ?start: float * ?``end``: float * ?``type``: D1SessionBookmark -> Blob

        [<Import("@cloudflare/workers-types", "DurableObjectState")>]
        type DurableObjectState<'Props> =
            abstract facets: DurableObjectFacets with get, set
            abstract container: option<Container> with get, set
            abstract storage: DurableObjectStorage with get
            abstract id: DurableObjectId with get
            abstract props: 'Props with get
            abstract abort: ?reason: D1SessionBookmark -> unit
            abstract getTags: ws: Global.WebSocket -> ResizeArray<D1SessionBookmark>
            abstract getHibernatableWebSocketEventTimeout: unit -> option<float>
            abstract setHibernatableWebSocketEventTimeout: ?timeoutMs: float -> unit
            abstract getWebSocketAutoResponseTimestamp: ws: Global.WebSocket -> option<Date>
            abstract getWebSocketAutoResponse: unit -> option<WebSocketRequestResponsePair>
            abstract setWebSocketAutoResponse: ?maybeReqResp: WebSocketRequestResponsePair -> unit
            abstract getWebSockets: ?tag: D1SessionBookmark -> ResizeArray<Global.WebSocket>
            abstract acceptWebSocket: ws: Global.WebSocket * ?tags: ResizeArray<D1SessionBookmark> -> unit
            abstract blockConcurrencyWhile: callback: unit -> Promise<'T> -> Promise<'T>
            abstract waitUntil: promise: Promise<option<obj>> -> unit

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Deepgram_Aura_2_Es"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfDeepgramAura2Es private () =
            abstract postProcessedOutputs: D1SessionBookmark with get, set
            abstract inputs: AiCfDeepgramAura2EsInput with get, set

        [<Import("@cloudflare/workers-types", "StreamError"); AbstractClass; AllowNullLiteral>]
        type StreamError private () =
            inherit exn()
            abstract stack: option<D1SessionBookmark> with get
            abstract message: D1SessionBookmark with get
            abstract statusCode: float with get
            abstract code: float with get

        [<Import("@cloudflare/workers-types", "AIGatewayUniversalRequest")>]
        type AIGatewayUniversalRequest =
            abstract query: option<obj> with get, set
            abstract headers: AIGatewayUniversalRequest.Headers with get, set
            abstract endpoint: D1SessionBookmark with get, set
            abstract provider: U2<AIGatewayUniversalRequest.Provider, string> with get, set

        [<Import("@cloudflare/workers-types", "CompletionTokensDetails")>]
        type CompletionTokensDetails =
            [<EmitProperty("rejected_prediction_tokens")>]
            abstract rejectedPredictionTokens: option<float> with get, set

            [<EmitProperty("accepted_prediction_tokens")>]
            abstract acceptedPredictionTokens: option<float> with get, set

            [<EmitProperty("audio_tokens")>]
            abstract audioTokens: option<float> with get, set

            [<EmitProperty("reasoning_tokens")>]
            abstract reasoningTokens: option<float> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type SystemMessage = | [<CompiledName("system")>] System

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Prompt")>]
        type AiCfQwenQwen330BA3BFp8Prompt =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfQwenQwen330BA3BFp8JSONMode> with get, set

            abstract lora: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ExportedHandlerFetchHandler")>]
        type ExportedHandlerFetchHandler<'Props, 'CfHostMetadata, 'Env> =
            abstract Invoke:
                request: Request * env: 'Env * ctx: ExecutionContext<'Props> ->
                    U2<Global.Response, Promise<Global.Response>>

        [<Import("@cloudflare/workers-types", "ImageConversionOptions")>]
        type ImageConversionOptions =
            abstract descriptionLanguage: option<ToMarkdownService._Lit12> with get, set

        type Atob =
            abstract Invoke: data: D1SessionBookmark -> D1SessionBookmark
            abstract Invoke: data: D1SessionBookmark -> D1SessionBookmark

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseInputTextContent = | [<CompiledName("input_text")>] InputText

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseReasoningTextDeltaEvent =
            | [<CompiledName("response.reasoning_text.delta")>] ResponseReasoningTextDelta

        [<Import("@cloudflare/workers-types", "ImagesBinding")>]
        type ImagesBinding =
            abstract hosted: HostedImagesBinding with get

            abstract input:
                stream: ReadableStream<Uint8Array<ArrayBufferLike>> * ?options: ImageInputOptions -> ImageTransformer

            abstract info:
                stream: ReadableStream<Uint8Array<ArrayBufferLike>> * ?options: ImageInputOptions ->
                    Promise<ImageInfoResponse>

        [<Import("@cloudflare/workers-types", "AiSearchItemLogsResponse")>]
        type AiSearchItemLogsResponse =
            [<EmitProperty("result_info")>]
            abstract resultInfo: Ai._Lit57 with get, set

            abstract result: ResizeArray<AiSearchItemLog> with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectNamespace"); AbstractClass; AllowNullLiteral>]
        type DurableObjectNamespace<'T when 'T :> Rpc.DurableObjectBranded> private () =
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

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseTextDoneEvent = | [<CompiledName("response.output_text.done")>] ResponseOutputTextDone

        [<Import("@cloudflare/workers-types", "DynamicDispatchOptions")>]
        type DynamicDispatchOptions =
            abstract outbound: option<WebAssembly.ModuleImports> with get, set
            abstract limits: option<DynamicDispatchLimits> with get, set

        [<Import("@cloudflare/workers-types", "D1Meta")>]
        type D1Meta =
            [<EmitProperty("total_attempts")>]
            abstract totalAttempts: option<float> with get, set

            abstract timings: option<D1PreparedStatement._Lit5> with get, set

            [<EmitProperty("served_by_primary")>]
            abstract servedByPrimary: option<bool> with get, set

            [<EmitProperty("served_by_colo")>]
            abstract servedByColo: option<D1SessionBookmark> with get, set

            [<EmitProperty("served_by_region")>]
            abstract servedByRegion: option<D1SessionBookmark> with get, set

            abstract changes: float with get, set

            [<EmitProperty("changed_db")>]
            abstract changedDb: bool with get, set

            [<EmitProperty("last_row_id")>]
            abstract lastRowId: float with get, set

            [<EmitProperty("rows_written")>]
            abstract rowsWritten: float with get, set

            [<EmitProperty("rows_read")>]
            abstract rowsRead: float with get, set

            [<EmitProperty("size_after")>]
            abstract sizeAfter: float with get, set

            abstract duration: float with get, set

        type ResponseOutputItem = obj

        [<Import("@cloudflare/workers-types", "ReadableWritablePair")>]
        type ReadableWritablePair<'W, 'R> =
            abstract writable: WritableStream<'W> with get, set
            abstract readable: ReadableStream<'R> with get, set
            abstract writable: WritableStream<'W> with get, set
            abstract readable: ReadableStream<'R> with get, set

        type AiCfQwenQwen330BA3BFp8Output =
            U4<
                AiCfQwenQwen330BA3BFp8ChatCompletionResponse,
                AiCfQwenQwen330BA3BFp8TextCompletionResponse,
                AiCfQwenQwen330BA3BFp8AsyncResponse,
                string
             >

        [<Import("@cloudflare/workers-types", "VectorizeQueryOptions")>]
        type VectorizeQueryOptions =
            abstract filter: option<VectorizeVectorMetadataFilter> with get, set
            abstract returnMetadata: option<U2<VectorizeQueryOptions.ReturnMetadata, bool>> with get, set
            abstract returnValues: option<bool> with get, set

            [<EmitProperty("namespace")>]
            abstract ``namespace``: option<D1SessionBookmark> with get, set

            abstract topK: option<float> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchInternalError"); AbstractClass; AllowNullLiteral>]
        type AiSearchInternalError private () =
            inherit exn()

        [<Import("@cloudflare/workers-types", "Text")>]
        type Text =
            inherit CharacterData
            abstract removed: bool with get
            abstract lastInTextNode: bool with get
            abstract text: D1SessionBookmark with get
            abstract wholeText: D1SessionBookmark with get
            abstract remove: unit -> Text

            abstract replace:
                content: U3<ReadableStream<option<obj>>, Global.Response, string> * ?options: ContentOptions -> Text

            abstract after:
                content: U3<ReadableStream<option<obj>>, Global.Response, string> * ?options: ContentOptions -> Text

            abstract before:
                content: U3<ReadableStream<option<obj>>, Global.Response, string> * ?options: ContentOptions -> Text

            abstract splitText: offset: float -> Text

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_AsyncResponse")>]
        type AiCfBaaiBgeM3AsyncResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "workerdResourceLimits")>]
        type WorkerdResourceLimits =
            abstract subRequests: option<float> with get, set
            abstract cpuMs: option<float> with get, set

        [<Import("@cloudflare/workers-types", "ImageMetadata")>]
        type ImageMetadata =
            abstract creator: option<D1SessionBookmark> with get, set
            abstract draft: option<bool> with get, set
            abstract variants: ResizeArray<D1SessionBookmark> with get, set
            abstract meta: option<WebAssembly.ModuleImports> with get, set
            abstract requireSignedURLs: bool with get, set
            abstract uploaded: option<D1SessionBookmark> with get, set
            abstract filename: option<D1SessionBookmark> with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "HelloWorldBinding")>]
        type HelloWorldBinding =
            abstract set: value: D1SessionBookmark -> Promise<unit>
            abstract get: unit -> Promise<HelloWorldBinding._Lit1>

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesBase")>]
        type IncomingRequestCfPropertiesBase =
            inherit WebAssembly.ModuleImports
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
            abstract edgeRequestKeepAliveStatus: IncomingRequestCfPropertiesEdgeRequestKeepAliveStatus with get, set
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

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type KVNamespace =
            | [<CompiledName("json")>] Json
            | [<CompiledName("text")>] Text
            | [<CompiledName("arrayBuffer")>] ArrayBuffer
            | [<CompiledName("stream")>] Stream

        [<Import("@cloudflare/workers-types", "AiSearchItem"); AbstractClass; AllowNullLiteral>]
        type AiSearchItem private () =
            abstract chunks: ?params: AiSearchItemChunksParams -> Promise<AiSearchItemChunksResponse>
            abstract logs: ?params: AiSearchItemLogsParams -> Promise<AiSearchItemLogsResponse>
            abstract sync: unit -> Promise<AiSearchItemInfo>
            abstract download: unit -> Promise<AiSearchItemContentResult>
            abstract info: unit -> Promise<AiSearchItemInfo>

        [<Import("@cloudflare/workers-types", "StreamCaption")>]
        type StreamCaption =
            abstract status: option<StreamDownloadStatus> with get, set
            abstract language: D1SessionBookmark with get, set
            abstract label: D1SessionBookmark with get, set
            abstract generated: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "AiModelsSearchParams")>]
        type AiModelsSearchParams =
            abstract task: option<D1SessionBookmark> with get, set
            abstract source: option<float> with get, set
            abstract search: option<D1SessionBookmark> with get, set

            [<EmitProperty("per_page")>]
            abstract perPage: option<float> with get, set

            abstract page: option<float> with get, set

            [<EmitProperty("hide_experimental")>]
            abstract hideExperimental: option<bool> with get, set

            abstract author: option<D1SessionBookmark> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfQwenQwen330BA3BFp8ChatCompletionResponse = | [<CompiledName("chat.completion")>] ChatCompletion

        type ChatCompletionMessageParam = obj

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Google_Gemma_3_12B_It"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfGoogleGemma312BIt private () =
            abstract postProcessedOutputs: AiCfGoogleGemma312BItOutput with get, set
            abstract inputs: AiCfGoogleGemma312BItInput with get, set

        [<Import("@cloudflare/workers-types", "ByteLengthQueuingStrategy"); AbstractClass; AllowNullLiteral>]
        type ByteLengthQueuingStrategy private () =
            inherit QueuingStrategy<ArrayBufferView<ArrayBufferLike>>()

            [<EmitConstructor>]
            abstract Create: init: Global.QueuingStrategyInit -> ByteLengthQueuingStrategy

            abstract highWaterMark: float with get
            abstract size: ?chunk: obj -> float

        [<Import("@cloudflare/workers-types", "DigestStream"); AbstractClass; AllowNullLiteral>]
        type DigestStream private () =
            inherit WritableStream<BufferSource>()

            [<EmitConstructor>]
            abstract Create: algorithm: U2<SubtleCryptoHashAlgorithm, string> -> DigestStream

            abstract bytesWritten: float with get
            abstract digest: Promise<ArrayBuffer> with get

        [<Import("@cloudflare/workers-types", "SupportedFileFormat")>]
        type SupportedFileFormat =
            abstract extension: D1SessionBookmark with get, set
            abstract mimeType: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "BaseAiImageClassification"); AbstractClass; AllowNullLiteral>]
        type BaseAiImageClassification private () =
            abstract postProcessedOutputs: AiImageClassificationOutput with get, set
            abstract inputs: AiImageClassificationInput with get, set

        [<Import("@cloudflare/workers-types", "PromiseRejectionEvent"); AbstractClass; AllowNullLiteral>]
        type PromiseRejectionEvent private () =
            inherit Event()
            abstract reason: option<obj> with get
            abstract promise: Promise<option<obj>> with get

        [<Import("@cloudflare/workers-types", "SendEmail")>]
        type SendEmail =
            abstract send: builder: SendEmail._Lit1 -> Promise<EmailSendResult>
            abstract send: message: EmailMessage -> Promise<EmailSendResult>

        [<Import("@cloudflare/workers-types", "VectorizeIndexInfo")>]
        type VectorizeIndexInfo =
            abstract processedUpToMutation: float with get, set
            abstract processedUpToDatetime: float with get, set
            abstract dimensions: float with get, set
            abstract vectorCount: float with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Deepgram_Aura_1_Input")>]
        type AiCfDeepgramAura1Input =
            [<EmitProperty("bit_rate")>]
            abstract bitRate: option<float> with get, set

            [<EmitProperty("sample_rate")>]
            abstract sampleRate: option<float> with get, set

            abstract text: D1SessionBookmark with get, set
            abstract container: option<AiModels._Lit295> with get, set
            abstract encoding: option<AiModels._Lit294> with get, set
            abstract speaker: option<AiModels._Lit293> with get, set

        [<Import("@cloudflare/workers-types", "ToolChoiceFunction")>]
        type ToolChoiceFunction =
            [<EmitProperty("type")>]
            abstract ``type``: ToolChoiceFunction.Type with get, set

            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "LoopbackServiceStub")>]
        type LoopbackServiceStub<'T when 'T :> Rpc.WorkerEntrypointBranded> =
            abstract Invoke: opts: LoopbackForExport._Lit11 -> LoopbackServiceStub.Invoke
            abstract Invoke: opts: LoopbackForExport._Lit9 -> LoopbackServiceStub.Invoke
            abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket
            abstract fetch: input: U3<Request, URL, string> * ?init: RequestInit -> Promise<Global.Response>
            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, Promise<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, Promise<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, Promise<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke:
                [<ParamArray>] args: LoopbackServiceStub.Invoke.Args ->
                    U2<Typescript.CSSViewTransitionRule._Lit31, U2<Typescript.CSSViewTransitionRule._Lit3576, unit>>

        [<Import("@cloudflare/workers-types", "Crypto"); AbstractClass; AllowNullLiteral>]
        type Crypto private () =
            [<EmitProperty("DigestStream")>]
            abstract digestStream: Crypto._Lit1 with get, set

            abstract subtle: SubtleCrypto with get
            abstract randomUUID: unit -> D1SessionBookmark
            abstract getRandomValues: buffer: 'T -> 'T

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Output_Query")>]
        type AiCfBaaiBgeM3OutputQuery =
            abstract response: option<ResizeArray<AiModels._Lit65>> with get, set

        [<Import("@cloudflare/workers-types", "AiIMultimodalEmbeddingsOutput")>]
        type AiIMultimodalEmbeddingsOutput =
            abstract shape: AiSentenceSimilarityOutput with get, set
            abstract data: ResizeArray<AiSentenceSimilarityOutput> with get, set

        type AiCfQwenQwen25Coder32BInstructInput = obj

        [<Import("@cloudflare/workers-types", "CryptoKeyAesKeyAlgorithm")>]
        type CryptoKeyAesKeyAlgorithm =
            abstract length: float with get, set
            abstract name: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseFunctionToolCallOutputItem = | [<CompiledName("function_call_output")>] FunctionCallOutput

        type ImageInfoResponse = obj

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseFunctionCallArgumentsDeltaEvent =
            | [<CompiledName("response.function_call_arguments.delta")>] ResponseFunctionCallArgumentsDelta

        type AiCfBaaiBgeSmallEnV15Output = obj

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Input_Embedding")>]
        type AiCfBaaiBgeM3InputEmbedding =
            [<EmitProperty("truncate_inputs")>]
            abstract truncateInputs: option<bool> with get, set

            abstract text: U2<ResizeArray<D1SessionBookmark>, string> with get, set

        [<Import("@cloudflare/workers-types", "BaseAiTextEmbeddings"); AbstractClass; AllowNullLiteral>]
        type BaseAiTextEmbeddings private () =
            abstract postProcessedOutputs: AiTextEmbeddingsOutput with get, set
            abstract inputs: AiTextEmbeddingsInput with get, set

        [<Import("@cloudflare/workers-types", "StreamScopedDownloads")>]
        type StreamScopedDownloads =
            abstract delete: ?downloadType: StreamDownloadType -> Promise<unit>
            abstract get: unit -> Promise<StreamDownloadGetResponse>
            abstract generate: ?downloadType: StreamDownloadType -> Promise<StreamDownloadGetResponse>

        [<Import("@cloudflare/workers-types", "ConversionRequestOptions")>]
        type ConversionRequestOptions =
            abstract conversionOptions: option<ConversionOptions> with get, set
            abstract extraHeaders: option<obj> with get, set
            abstract gateway: option<GatewayOptions> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Google_Gemma_4_26B_A4B_IT"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfGoogleGemma426BA4BIT private () =
            abstract postProcessedOutputs: ChatCompletionsOutput with get, set
            abstract inputs: ChatCompletionsInput with get, set

        [<Import("@cloudflare/workers-types", "BasicImageTransformations")>]
        type BasicImageTransformations =
            abstract rotate: option<BasicImageTransformations._Lit3> with get, set
            abstract background: option<D1SessionBookmark> with get, set
            abstract gravity: option<U2<BasicImageTransformations.Gravity, BasicImageTransformationsGravityCoordinates>> with get, set
            abstract segment: option<BasicImageTransformations.Segment> with get, set
            abstract fit: option<BasicImageTransformations._Lit1> with get, set
            abstract height: option<float> with get, set
            abstract width: option<float> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type VectorizeVectorMetadataFilterOp =
            | [<CompiledName("$eq")>] Eq
            | [<CompiledName("$ne")>] Ne
            | [<CompiledName("$lt")>] Lt
            | [<CompiledName("$lte")>] Lte
            | [<CompiledName("$gt")>] Gt
            | [<CompiledName("$gte")>] Gte

        type AiCfBaaiBgeM3Input = obj

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionFunctionTool = | [<CompiledName("function")>] Function

        [<Import("@cloudflare/workers-types", "HTMLRewriterDocumentContentHandlers")>]
        type HTMLRewriterDocumentContentHandlers =
            abstract ``end``: ``end``: DocumentEnd -> option<Promise<unit>>
            abstract text: text: Text -> option<Promise<unit>>
            abstract comments: comment: Global.Comment -> option<Promise<unit>>
            abstract doctype: doctype: Doctype -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "TraceItem")>]
        type TraceItem =
            abstract wallTime: float with get
            abstract cpuTime: float with get
            abstract truncated: bool with get
            abstract executionModel: D1SessionBookmark with get
            abstract outcome: D1SessionBookmark with get
            abstract durableObjectId: option<D1SessionBookmark> with get
            abstract preview: option<TracePreviewInfo> with get
            abstract tailAttributes: option<WebAssembly.ModuleImports> with get
            abstract scriptTags: option<ResizeArray<D1SessionBookmark>> with get
            abstract dispatchNamespace: option<D1SessionBookmark> with get
            abstract scriptVersion: option<ScriptVersion> with get
            abstract entrypoint: option<D1SessionBookmark> with get
            abstract scriptName: option<string> with get
            abstract diagnosticsChannelEvents: ResizeArray<TraceDiagnosticChannelEvent> with get
            abstract exceptions: ResizeArray<TraceException> with get
            abstract logs: ResizeArray<TraceLog> with get
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

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Prompt_Inner")>]
        type AiCfMetaLlama4Scout17B16EInstructPromptInner =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfMetaLlama4Scout17B16EInstructJSONMode> with get, set

            [<EmitProperty("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiImageTextToTextInput")>]
        type AiImageTextToTextInput =
            abstract messages: option<ResizeArray<RoleScopedChatInput>> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            [<EmitProperty("ignore_eos")>]
            abstract ignoreEos: option<bool> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract prompt: option<D1SessionBookmark> with get, set
            abstract image: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type IncomingRequestCfPropertiesTLSClientAuth = | [<CompiledName("1")>] ``1``

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRAGInternalError"); AbstractClass; AllowNullLiteral>]
        type AutoRAGInternalError private () =
            inherit exn()

        [<Import("@cloudflare/workers-types", "MessageSendRequest")>]
        type MessageSendRequest<'Body> =
            abstract delaySeconds: option<float> with get, set
            abstract contentType: option<QueueContentType> with get, set
            abstract body: 'Body with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionsResponseFormatJSONObject = | [<CompiledName("json_object")>] JsonObject

        [<Import("@cloudflare/workers-types", "TraceItemFetchEventInfoRequest")>]
        type TraceItemFetchEventInfoRequest =
            abstract url: D1SessionBookmark with get
            abstract method: D1SessionBookmark with get
            abstract headers: WebAssembly.ModuleImports with get
            abstract cf: option<obj> with get
            abstract getUnredacted: unit -> TraceItemFetchEventInfoRequest

        type AiCfUnumUformGen2Qwen500MInput = U2<AiModels._Lit53, string>

        [<Import("@cloudflare/workers-types", "FacetStartupOptions")>]
        type FacetStartupOptions<'T when 'T :> Rpc.DurableObjectBranded> =
            [<EmitProperty("class")>]
            abstract ``class``: DurableObjectClass<'T> with get, set

            abstract id: option<U2<DurableObjectId, string>> with get, set

        [<Import("@cloudflare/workers-types", "ContainerDirectorySnapshotOptions")>]
        type ContainerDirectorySnapshotOptions =
            abstract name: option<D1SessionBookmark> with get, set
            abstract dir: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "EmailEvent"); AbstractClass; AllowNullLiteral>]
        type EmailEvent private () =
            inherit ExtendableEvent()
            abstract message: ForwardableEmailMessage with get

        [<Import("@cloudflare/workers-types", "CompressionStream"); AbstractClass; AllowNullLiteral>]
        type CompressionStream private () =
            inherit TransformStream<BufferSource, Uint8Array<ArrayBufferLike>>()

            [<EmitConstructor>]
            abstract Create: format: CompressionStream.Format -> CompressionStream

        [<Import("@cloudflare/workers-types", "AiSearchListInstancesParams")>]
        type AiSearchListInstancesParams =
            [<EmitProperty("order_by_direction")>]
            abstract orderByDirection: option<ImagesBinding._Lit8> with get, set

            [<EmitProperty("order_by")>]
            abstract orderBy: option<AiSearchListInstancesParams.OrderBy> with get, set

            abstract search: option<D1SessionBookmark> with get, set

            [<EmitProperty("per_page")>]
            abstract perPage: option<float> with get, set

            abstract page: option<float> with get, set

        [<Import("@cloudflare/workers-types", "StreamDownload")>]
        type StreamDownload =
            abstract url: option<D1SessionBookmark> with get, set
            abstract status: StreamDownloadStatus with get, set
            abstract percentComplete: float with get, set

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

        [<Import("@cloudflare/workers-types", "EventSourceEventSourceInit")>]
        type EventSourceEventSourceInit =
            abstract fetcher: option<Typescript.CSSViewTransitionRule._Lit3543> with get, set
            abstract withCredentials: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Nvidia_Nemotron_3_120B_A12B"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfNvidiaNemotron3120BA12B private () =
            abstract postProcessedOutputs: ChatCompletionsOutput with get, set
            abstract inputs: ChatCompletionsInput with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionsResponseFormatText = | [<CompiledName("text")>] Text

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Dev_Output")>]
        type AiCfBlackForestLabsFlux2DevOutput =
            abstract image: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "CacheStorage"); AbstractClass; AllowNullLiteral>]
        type CacheStorage private () =
            [<EmitProperty("default")>]
            abstract ``default``: Cache with get

            abstract ``open``: cacheName: D1SessionBookmark -> Promise<Cache>

        [<Import("@cloudflare/workers-types", "WorkerVersionMetadata")>]
        type WorkerVersionMetadata =
            abstract timestamp: D1SessionBookmark with get, set
            abstract tag: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        type AiImageClassificationOutput = obj
        type ReadableStreamReadResult<'R> = U2<ReadableStreamReadResult._Lit2, ReadableStreamReadResult._Lit3>
        type ChatCompletionCustomToolFormat = U2<AiModels._Lit195, AiModels._Lit196>

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRagAiSearchRequest")>]
        type AutoRagAiSearchRequest =
            [<EmitProperty("system_prompt")>]
            abstract systemPrompt: option<D1SessionBookmark> with get, set

            abstract stream: option<bool> with get, set

            [<EmitProperty("rewrite_query")>]
            abstract rewriteQuery: option<bool> with get, set

            abstract reranking: option<AutoRAG._Lit9> with get, set

            [<EmitProperty("ranking_options")>]
            abstract rankingOptions: option<AutoRAG._Lit8> with get, set

            [<EmitProperty("max_num_results")>]
            abstract maxNumResults: option<float> with get, set

            abstract filters: option<U2<AutoRAG._Lit4, AutoRAG._Lit6>> with get, set
            abstract query: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Cache"); AbstractClass; AllowNullLiteral>]
        type Cache private () =
            abstract put: request: U3<Request, URL, string> * response: Global.Response -> Promise<unit>

            abstract ``match``:
                request: U3<Request, URL, string> * ?options: Global.CacheQueryOptions ->
                    Promise<option<Global.Response>>

            abstract delete: request: U3<Request, URL, string> * ?options: Global.CacheQueryOptions -> Promise<bool>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode_2")>]
        type AiCfMetaLlama3370BInstructFp8FastJSONMode2 =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiModels._Lit80> with get, set

        [<Import("@cloudflare/workers-types", "FileOptions")>]
        type FileOptions =
            abstract lastModified: option<float> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "VectorizeAsyncMutation")>]
        type VectorizeAsyncMutation =
            abstract mutationId: D1SessionBookmark with get, set

        type XOR<'U, 'T> = U2<AiModels._Lit133, AiModels._Lit135>

        [<Import("@cloudflare/workers-types", "URLSearchParams"); AbstractClass; AllowNullLiteral>]
        type URLSearchParams private () =
            [<EmitConstructor>]
            abstract Create:
                ?init:
                    U4<
                        URLSearchParams,
                        Typescript.CSSViewTransitionRule._Lit44,
                        ResizeArray<D1SessionBookmark * D1SessionBookmark>,
                        string
                     > ->
                    URLSearchParams

            abstract size: float with get

            abstract symbolIterator:
                unit ->
                    System.Collections.Generic.IEnumerator<
                        D1SessionBookmark * D1SessionBookmark,
                        option<obj>,
                        option<obj>
                     >

            abstract toString: unit -> D1SessionBookmark
            abstract forEach: callback: URLSearchParams._Lit1 * ?thisArg: 'This -> unit
            abstract values: unit -> System.Collections.Generic.IEnumerator<D1SessionBookmark, option<obj>, option<obj>>
            abstract keys: unit -> System.Collections.Generic.IEnumerator<D1SessionBookmark, option<obj>, option<obj>>

            abstract entries:
                unit ->
                    System.Collections.Generic.IEnumerator<
                        D1SessionBookmark * D1SessionBookmark,
                        option<obj>,
                        option<obj>
                     >

            abstract sort: unit -> unit
            abstract set: name: D1SessionBookmark * value: D1SessionBookmark -> unit
            abstract has: name: D1SessionBookmark -> bool
            abstract getAll: name: D1SessionBookmark -> ResizeArray<D1SessionBookmark>
            abstract get: name: D1SessionBookmark -> option<string>
            abstract delete: name: D1SessionBookmark -> unit
            abstract append: name: D1SessionBookmark * value: D1SessionBookmark -> unit

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfQwenQwen330BA3BFp8TextCompletionResponse = | [<CompiledName("text_completion")>] TextCompletion

        [<Import("@cloudflare/workers-types", "WebSearchOptions")>]
        type WebSearchOptions =
            [<EmitProperty("user_location")>]
            abstract userLocation: option<WebSearchUserLocation> with get, set

            [<EmitProperty("search_context_size")>]
            abstract searchContextSize: option<AiModels._Lit200> with get, set

        type ResponseFormatTextConfig = obj

        [<Import("@cloudflare/workers-types", "EventContext")>]
        type EventContext<'Data, 'P, 'Env when 'P :> D1SessionBookmark> =
            abstract data: 'Data with get, set
            abstract params: WebAssembly.ModuleImports with get, set
            abstract env: PagesFunction._Lit6 with get, set
            abstract functionPath: D1SessionBookmark with get, set
            abstract request: Request with get, set
            abstract next: ?input: RequestInfo * ?init: RequestInit -> Promise<Global.Response>
            abstract passThroughOnException: unit -> unit
            abstract waitUntil: promise: Promise<option<obj>> -> unit

        [<Import("@cloudflare/workers-types", "InstanceStatus")>]
        type InstanceStatus =
            abstract output: option<obj> with get, set
            abstract error: option<Typescript.CSSViewTransitionRule._Lit516> with get, set
            abstract status: CloudflareWorkersModule.WorkflowInstanceStatus with get, set

        type MainModule = option<obj>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ForbiddenError = | ForbiddenError

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionCustomTool = | [<CompiledName("custom")>] Custom

        type StructuredClone =
            abstract Invoke: value: 'T * ?options: Global.StructuredSerializeOptions -> 'T
            abstract Invoke: value: 'T * ?options: Global.StructuredSerializeOptions -> 'T

        [<Import("@cloudflare/workers-types", "StreamWatermarkCreateParams")>]
        type StreamWatermarkCreateParams =
            abstract position: option<StreamWatermarkPosition> with get, set
            abstract scale: option<float> with get, set
            abstract padding: option<float> with get, set
            abstract opacity: option<float> with get, set
            abstract name: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_JSON_Mode")>]
        type AiCfQwenQwen25Coder32BInstructJSONMode =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiModels._Lit80> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItemChunk")>]
        type AiSearchItemChunk =
            abstract item: option<Ai._Lit18> with get, set

            [<EmitProperty("end_byte")>]
            abstract endByte: float with get, set

            [<EmitProperty("start_byte")>]
            abstract startByte: float with get, set

            abstract text: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type VectorizeVectorMetadataFilterCollectionOp =
            | [<CompiledName("$in")>] In
            | [<CompiledName("$nin")>] Nin

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_1_Schnell_Input")>]
        type AiCfBlackForestLabsFlux1SchnellInput =
            abstract steps: option<float> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "TraceItemConnectEventInfo")>]
        type TraceItemConnectEventInfo = interface end

        [<Import("@cloudflare/workers-types", "PromptTokensDetails")>]
        type PromptTokensDetails =
            [<EmitProperty("audio_tokens")>]
            abstract audioTokens: option<float> with get, set

            [<EmitProperty("cached_tokens")>]
            abstract cachedTokens: option<float> with get, set

        [<Import("@cloudflare/workers-types", "AnalyticsEngineDataPoint")>]
        type AnalyticsEngineDataPoint =
            abstract blobs: option<ResizeArray<option<U2<ArrayBuffer, string>>>> with get, set
            abstract doubles: option<AiSentenceSimilarityOutput> with get, set
            abstract indexes: option<ResizeArray<option<U2<ArrayBuffer, string>>>> with get, set

        [<Import("@cloudflare/workers-types", "ResponseFormatText")>]
        type ResponseFormatText =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseFormatText.Type with get, set

        type VectorFloatArray = U2<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>>

        [<Import("@cloudflare/workers-types", "DurableObjectClass")>]
        type DurableObjectClass<'_T when '_T :> Rpc.DurableObjectBranded> = interface end

        [<Import("@cloudflare/workers-types", "KVNamespaceGetOptions")>]
        type KVNamespaceGetOptions<'Type> =
            abstract cacheTtl: option<float> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: 'Type with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Prompt")>]
        type AiCfMetaLlama3370BInstructFp8FastPrompt =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfMetaLlama3370BInstructFp8FastJSONMode> with get, set

            abstract lora: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "WebSocketEventMap")>]
        type WebSocketEventMap =
            abstract error: ErrorEvent with get, set

            [<EmitProperty("open")>]
            abstract ``open``: Event with get, set

            abstract message: MessageEvent<option<obj>> with get, set
            abstract close: CloseEvent with get, set

        [<Import("@cloudflare/workers-types", "AbortSignal"); AbstractClass; AllowNullLiteral>]
        type AbortSignal private () =
            inherit EventTarget()
            abstract onabort: option<obj> with set
            abstract onabort: option<obj> with get
            abstract reason: option<obj> with get
            abstract aborted: bool with get
            abstract throwIfAborted: unit -> unit
            abstract any: signals: ResizeArray<AbortSignal> -> AbortSignal
            abstract timeout: delay: float -> AbortSignal
            abstract abort: ?reason: obj -> AbortSignal

        [<Import("@cloudflare/workers-types", "Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B_Output")>]
        type AiCfAi4BharatIndictrans2EnIndic1BOutput =
            abstract translations: ResizeArray<D1SessionBookmark> with get, set

        type SqlStorageValue = option<U3<ArrayBuffer, string, float>>

        [<Import("@cloudflare/workers-types", "TraceItemTailEventInfo")>]
        type TraceItemTailEventInfo =
            abstract consumedEvents: ResizeArray<TraceItemTailEventInfoTailItem> with get

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRagAiSearchRequestStreaming")>]
        type AutoRagAiSearchRequestStreaming =
            abstract stream: AutoRagAiSearchRequestStreaming.Stream with get, set

            [<EmitProperty("system_prompt")>]
            abstract systemPrompt: option<string> with get, set

            [<EmitProperty("rewrite_query")>]
            abstract rewriteQuery: option<Typescript.CSSViewTransitionRule._Lit30> with get, set

            abstract reranking: option<AutoRAG._Lit9> with get, set

            [<EmitProperty("ranking_options")>]
            abstract rankingOptions: option<AutoRAG._Lit8> with get, set

            [<EmitProperty("max_num_results")>]
            abstract maxNumResults: option<float> with get, set

            abstract filters: option<U2<AutoRAG._Lit4, AutoRAG._Lit6>> with get, set
            abstract query: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "R2UploadedPart")>]
        type R2UploadedPart =
            abstract etag: D1SessionBookmark with get, set
            abstract partNumber: float with get, set

        [<Import("@cloudflare/workers-types", "StreamVideoHandle")>]
        type StreamVideoHandle =
            abstract captions: StreamScopedCaptions with get, set
            abstract downloads: StreamScopedDownloads with get, set
            abstract id: D1SessionBookmark with get, set
            abstract generateToken: unit -> Promise<D1SessionBookmark>
            abstract delete: unit -> Promise<unit>
            abstract update: params: StreamUpdateVideoParams -> Promise<StreamVideo>
            abstract details: unit -> Promise<StreamVideo>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Output_Embedding")>]
        type AiCfBaaiBgeM3OutputEmbedding =
            abstract pooling: option<AiModels._Lit36> with get, set
            abstract data: option<ResizeArray<AiSentenceSimilarityOutput>> with get, set
            abstract shape: option<AiSentenceSimilarityOutput> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Leonardo_Lucid_Origin_Output")>]
        type AiCfLeonardoLucidOriginOutput =
            abstract image: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_Guard_3_8B_Output")>]
        type AiCfMetaLlamaGuard38BOutput =
            abstract usage: option<AiModels._Lit87> with get, set
            abstract response: option<U2<AiModels._Lit92, string>> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchMultiSearchError")>]
        type AiSearchMultiSearchError =
            abstract message: D1SessionBookmark with get, set

            [<EmitProperty("instance_id")>]
            abstract instanceId: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiTextGenerationOutput")>]
        type AiTextGenerationOutput =
            abstract usage: option<UsageTags> with get, set

            [<EmitProperty("tool_calls")>]
            abstract toolCalls: option<AiModels._Lit25> with get, set

            abstract response: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "AiTextEmbeddingsInput")>]
        type AiTextEmbeddingsInput =
            abstract text: U2<ResizeArray<D1SessionBookmark>, string> with get, set

        [<Import("@cloudflare/workers-types", "WorkerStubEntrypointOptions")>]
        type WorkerStubEntrypointOptions =
            abstract limits: option<WorkerdResourceLimits> with get, set
            abstract props: option<obj> with get, set

        type RequestInfo<'Cf, 'CfHostMetadata> = U2<Request, string>

        [<Import("@cloudflare/workers-types", "AiGatewayPatchLog")>]
        type AiGatewayPatchLog =
            abstract metadata: option<Typescript.CSSViewTransitionRule._Lit44> with get, set
            abstract feedback: option<AiGateway._Lit2> with get, set
            abstract score: option<float> with get, set

        [<Import("@cloudflare/workers-types", "CachePurgeResult")>]
        type CachePurgeResult =
            abstract errors: ResizeArray<CachePurgeError> with get, set
            abstract success: bool with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionsCommonOptions")>]
        type ChatCompletionsCommonOptions =
            abstract functions: option<ResizeArray<FunctionDefinition>> with get, set

            [<EmitProperty("function_call")>]
            abstract functionCall: option<U2<ChatCompletionsCommonOptions.FunctionCall, AiModels._Lit184>> with get, set

            [<EmitProperty("web_search_options")>]
            abstract webSearchOptions: option<WebSearchOptions> with get, set

            abstract user: option<D1SessionBookmark> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract tools: option<ResizeArray<ChatCompletionTool>> with get, set

            [<EmitProperty("tool_choice")>]
            abstract toolChoice: option<ChatCompletionToolChoiceOption> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("stream_options")>]
            abstract streamOptions: option<ChatCompletionsStreamOptions> with get, set

            abstract stream: option<bool> with get, set
            abstract store: option<bool> with get, set
            abstract stop: option<U2<ResizeArray<D1SessionBookmark>, string>> with get, set

            [<EmitProperty("service_tier")>]
            abstract serviceTier: option<AiModels._Lit147> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<ResponseFormat> with get, set

            [<EmitProperty("chat_template_kwargs")>]
            abstract chatTemplateKwargs: option<ChatTemplateKwargs> with get, set

            [<EmitProperty("reasoning_effort")>]
            abstract reasoningEffort: option<AiModels._Lit156> with get, set

            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            abstract prediction: option<PredictionContent> with get, set

            [<EmitProperty("parallel_tool_calls")>]
            abstract parallelToolCalls: option<bool> with get, set

            abstract n: option<float> with get, set
            abstract modalities: option<ResizeArray<ChatCompletionsCommonOptions.Modalities>> with get, set
            abstract metadata: option<Typescript.CSSViewTransitionRule._Lit44> with get, set

            [<EmitProperty("max_completion_tokens")>]
            abstract maxCompletionTokens: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            [<EmitProperty("top_logprobs")>]
            abstract topLogprobs: option<float> with get, set

            abstract logprobs: option<bool> with get, set

            [<EmitProperty("logit_bias")>]
            abstract logitBias: option<Typescript.CSSViewTransitionRule._Lit44> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            abstract audio: option<AudioParams> with get, set
            abstract model: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "LoopbackDurableObjectClass")>]
        type LoopbackDurableObjectClass<'T when 'T :> Rpc.DurableObjectBranded> =
            abstract Invoke: opts: LoopbackForExport._Lit11 -> DurableObjectClass<'T>
            abstract Invoke: opts: LoopbackForExport._Lit9 -> DurableObjectClass<'T>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type RequestInitCfPropertiesImage =
            | [<CompiledName("fast")>] Fast
            | [<CompiledName("share-publicly")>] SharePublicly

        [<Import("@cloudflare/workers-types", "Ai_Cf_Openai_Whisper_Large_V3_Turbo_Input")>]
        type AiCfOpenaiWhisperLargeV3TurboInput =
            [<EmitProperty("hallucination_silence_threshold")>]
            abstract hallucinationSilenceThreshold: option<float> with get, set

            [<EmitProperty("log_prob_threshold")>]
            abstract logProbThreshold: option<float> with get, set

            [<EmitProperty("compression_ratio_threshold")>]
            abstract compressionRatioThreshold: option<float> with get, set

            [<EmitProperty("no_speech_threshold")>]
            abstract noSpeechThreshold: option<float> with get, set

            [<EmitProperty("condition_on_previous_text")>]
            abstract conditionOnPreviousText: option<bool> with get, set

            [<EmitProperty("beam_size")>]
            abstract beamSize: option<float> with get, set

            abstract prefix: option<D1SessionBookmark> with get, set

            [<EmitProperty("initial_prompt")>]
            abstract initialPrompt: option<D1SessionBookmark> with get, set

            [<EmitProperty("vad_filter")>]
            abstract vadFilter: option<bool> with get, set

            abstract language: option<D1SessionBookmark> with get, set
            abstract task: option<D1SessionBookmark> with get, set
            abstract audio: U2<AiModels._Lit57, string> with get, set

        type AiSearchMultiSearchRequest = obj

        [<Import("@cloudflare/workers-types", "AIGatewayHeaders")>]
        type AIGatewayHeaders =
            [<EmitProperty("Content-Type")>]
            abstract contentType: D1SessionBookmark with get, set

            [<EmitProperty("Authorization")>]
            abstract authorization: D1SessionBookmark with get, set

            [<EmitProperty("cf-aig-collect-log")>]
            abstract cfAigCollectLog: U2<bool, string> with get, set

            [<EmitProperty("cf-aig-backoff")>]
            abstract cfAigBackoff: D1SessionBookmark with get, set

            [<EmitProperty("cf-aig-retry-delay")>]
            abstract cfAigRetryDelay: U2<float, string> with get, set

            [<EmitProperty("cf-aig-max-attempts")>]
            abstract cfAigMaxAttempts: U2<float, string> with get, set

            [<EmitProperty("cf-aig-request-timeout")>]
            abstract cfAigRequestTimeout: U2<float, string> with get, set

            [<EmitProperty("cf-aig-event-id")>]
            abstract cfAigEventId: D1SessionBookmark with get, set

            [<EmitProperty("cf-aig-cache-key")>]
            abstract cfAigCacheKey: D1SessionBookmark with get, set

            [<EmitProperty("cf-aig-skip-cache")>]
            abstract cfAigSkipCache: U2<bool, string> with get, set

            [<EmitProperty("cf-aig-cache-ttl")>]
            abstract cfAigCacheTtl: U2<float, string> with get, set

            [<EmitProperty("cf-aig-custom-cost")>]
            abstract cfAigCustomCost: U3<AiGateway._Lit12, AiGateway._Lit13, string> with get, set

            [<EmitProperty("cf-aig-metadata")>]
            abstract cfAigMetadata: U2<Typescript.CSSViewTransitionRule._Lit44, string> with get, set

            abstract Item: key: D1SessionBookmark -> U4<AIGatewayHeaders.Item, string, float, obj>

        [<Import("@cloudflare/workers-types", "R2Object"); AbstractClass; AllowNullLiteral>]
        type R2Object private () =
            abstract ssecKeyMd5: option<D1SessionBookmark> with get
            abstract storageClass: D1SessionBookmark with get
            abstract range: option<R2Range> with get
            abstract customMetadata: option<WebAssembly.ModuleImports> with get
            abstract httpMetadata: option<R2HTTPMetadata> with get
            abstract uploaded: Date with get
            abstract checksums: R2Checksums with get
            abstract httpEtag: D1SessionBookmark with get
            abstract etag: D1SessionBookmark with get
            abstract size: float with get
            abstract version: D1SessionBookmark with get
            abstract key: D1SessionBookmark with get
            abstract writeHttpMetadata: headers: Headers -> unit

        [<Import("@cloudflare/workers-types", "ImageDrawOptions")>]
        type ImageDrawOptions =
            abstract right: option<float> with get, set
            abstract bottom: option<float> with get, set
            abstract left: option<float> with get, set
            abstract top: option<float> with get, set
            abstract repeat: option<U2<bool, string>> with get, set
            abstract opacity: option<float> with get, set

        [<Import("@cloudflare/workers-types", "ResponseFailedEvent")>]
        type ResponseFailedEvent =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseFailedEvent.Type with get, set

            [<EmitProperty("sequence_number")>]
            abstract sequenceNumber: float with get, set

            abstract response: Global.Response with get, set

        [<Import("@cloudflare/workers-types", "ExportedHandlerConnectHandler")>]
        type ExportedHandlerConnectHandler<'Props, 'Env> =
            abstract Invoke: socket: Socket * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "QuotaReachedError")>]
        type QuotaReachedError =
            inherit StreamError
            abstract name: QuotaReachedError.Name with get, set

        [<Import("@cloudflare/workers-types", "EmbeddedImageConversionOptions")>]
        type EmbeddedImageConversionOptions =
            abstract maxConvertedImages: option<float> with get, set
            abstract convert: option<bool> with get, set
            abstract descriptionLanguage: option<ToMarkdownService._Lit12> with get, set

        [<Import("@cloudflare/workers-types", "ErrorEvent"); AbstractClass; AllowNullLiteral>]
        type ErrorEvent private () =
            inherit Event()

            [<EmitConstructor>]
            abstract Create: ``type``: D1SessionBookmark * ?init: ErrorEventErrorEventInit -> ErrorEvent

            abstract error: option<obj> with get
            abstract colno: float with get
            abstract lineno: float with get
            abstract message: D1SessionBookmark with get
            abstract filename: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "TraceItemHibernatableWebSocketEventInfoMessage")>]
        type TraceItemHibernatableWebSocketEventInfoMessage =
            abstract webSocketEventType: D1SessionBookmark with get

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRAGNotFoundError"); AbstractClass; AllowNullLiteral>]
        type AutoRAGNotFoundError private () =
            inherit exn()

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ImageInputOptions = | [<CompiledName("base64")>] Base64

        [<Import("@cloudflare/workers-types", "HTMLRewriter"); AbstractClass; AllowNullLiteral>]
        type HTMLRewriter private () =
            [<EmitConstructor>]
            abstract Create: unit -> HTMLRewriter

            abstract transform: response: Global.Response -> Global.Response
            abstract onDocument: handlers: HTMLRewriterDocumentContentHandlers -> HTMLRewriter
            abstract on: selector: D1SessionBookmark * handlers: HTMLRewriterElementContentHandlers -> HTMLRewriter

        [<Import("@cloudflare/workers-types", "RequestInitCfPropertiesImageMinify")>]
        type RequestInitCfPropertiesImageMinify =
            abstract html: option<bool> with get, set
            abstract css: option<bool> with get, set
            abstract javascript: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "EventListenerObject")>]
        type EventListenerObject =
            abstract handleEvent: event: 'EventType -> unit
            abstract handleEvent: object: Event -> unit

        [<Import("@cloudflare/workers-types", "ImageHandle")>]
        type ImageHandle =
            abstract delete: unit -> Promise<bool>
            abstract update: options: ImageUpdateOptions -> Promise<ImageMetadata>
            abstract bytes: unit -> Promise<option<ReadableStream<Uint8Array<ArrayBufferLike>>>>
            abstract details: unit -> Promise<option<ImageMetadata>>

        [<Import("@cloudflare/workers-types", "ResponseErrorEvent")>]
        type ResponseErrorEvent =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseErrorEvent.Type with get, set

            [<EmitProperty("sequence_number")>]
            abstract sequenceNumber: float with get, set

            abstract param: option<string> with get, set
            abstract message: D1SessionBookmark with get, set
            abstract code: option<string> with get, set

        [<Import("@cloudflare/workers-types", "AiModels")>]
        type AiModels =
            [<EmitProperty("@cf/nvidia/nemotron-3-120b-a12b")>]
            abstract cfNvidiaNemotron3120bA12b: BaseAiCfNvidiaNemotron3120BA12B with get, set

            [<EmitProperty("@cf/moonshotai/kimi-k2.5")>]
            abstract cfMoonshotaiKimiK25: BaseAiCfMoonshotaiKimiK25 with get, set

            [<EmitProperty("@cf/zai-org/glm-4.7-flash")>]
            abstract cfZaiOrgGlm47Flash: BaseAiCfZaiOrgGlm47Flash with get, set

            [<EmitProperty("@cf/black-forest-labs/flux-2-klein-9b")>]
            abstract cfBlackForestLabsFlux2Klein9b: BaseAiCfBlackForestLabsFlux2Klein9B with get, set

            [<EmitProperty("@cf/black-forest-labs/flux-2-klein-4b")>]
            abstract cfBlackForestLabsFlux2Klein4b: BaseAiCfBlackForestLabsFlux2Klein4B with get, set

            [<EmitProperty("@cf/black-forest-labs/flux-2-dev")>]
            abstract cfBlackForestLabsFlux2Dev: BaseAiCfBlackForestLabsFlux2Dev with get, set

            [<EmitProperty("@cf/deepgram/aura-2-es")>]
            abstract cfDeepgramAura2Es: BaseAiCfDeepgramAura2Es with get, set

            [<EmitProperty("@cf/deepgram/aura-2-en")>]
            abstract cfDeepgramAura2En: BaseAiCfDeepgramAura2En with get, set

            [<EmitProperty("@cf/deepgram/flux")>]
            abstract cfDeepgramFlux: BaseAiCfDeepgramFlux with get, set

            [<EmitProperty("@cf/pfnet/plamo-embedding-1b")>]
            abstract cfPfnetPlamoEmbedding1b: BaseAiCfPfnetPlamoEmbedding1B with get, set

            [<EmitProperty("@cf/aisingapore/gemma-sea-lion-v4-27b-it")>]
            abstract cfAisingaporeGemmaSeaLionV427bIt: BaseAiCfAisingaporeGemmaSeaLionV427BIt with get, set

            [<EmitProperty("@cf/ai4bharat/indictrans2-en-indic-1B")>]
            abstract cfAi4bharatIndictrans2EnIndic1B: BaseAiCfAi4BharatIndictrans2EnIndic1B with get, set

            [<EmitProperty("@cf/deepgram/aura-1")>]
            abstract cfDeepgramAura1: BaseAiCfDeepgramAura1 with get, set

            [<EmitProperty("@cf/leonardo/lucid-origin")>]
            abstract cfLeonardoLucidOrigin: BaseAiCfLeonardoLucidOrigin with get, set

            [<EmitProperty("@cf/leonardo/phoenix-1.0")>]
            abstract cfLeonardoPhoenix10: BaseAiCfLeonardoPhoenix10 with get, set

            [<EmitProperty("@cf/openai/gpt-oss-20b")>]
            abstract cfOpenaiGptOss20b: BaseAiCfOpenaiGptOss20B with get, set

            [<EmitProperty("@cf/openai/gpt-oss-120b")>]
            abstract cfOpenaiGptOss120b: BaseAiCfOpenaiGptOss120B with get, set

            [<EmitProperty("@cf/pipecat-ai/smart-turn-v2")>]
            abstract cfPipecatAiSmartTurnV2: BaseAiCfPipecatAiSmartTurnV2 with get, set

            [<EmitProperty("@cf/qwen/qwen3-embedding-0.6b")>]
            abstract cfQwenQwen3Embedding06b: BaseAiCfQwenQwen3Embedding06B with get, set

            [<EmitProperty("@cf/deepgram/nova-3")>]
            abstract cfDeepgramNova3: BaseAiCfDeepgramNova3 with get, set

            [<EmitProperty("@cf/qwen/qwen3-30b-a3b-fp8")>]
            abstract cfQwenQwen330bA3bFp8: BaseAiCfQwenQwen330BA3BFp8 with get, set

            [<EmitProperty("@cf/meta/llama-4-scout-17b-16e-instruct")>]
            abstract cfMetaLlama4Scout17b16eInstruct: BaseAiCfMetaLlama4Scout17B16EInstruct with get, set

            [<EmitProperty("@cf/google/gemma-3-12b-it")>]
            abstract cfGoogleGemma312bIt: BaseAiCfGoogleGemma312BIt with get, set

            [<EmitProperty("@cf/mistralai/mistral-small-3.1-24b-instruct")>]
            abstract cfMistralaiMistralSmall3124bInstruct: BaseAiCfMistralaiMistralSmall3124BInstruct with get, set

            [<EmitProperty("@cf/qwen/qwq-32b")>]
            abstract cfQwenQwq32b: BaseAiCfQwenQwq32B with get, set

            [<EmitProperty("@cf/qwen/qwen2.5-coder-32b-instruct")>]
            abstract cfQwenQwen25Coder32bInstruct: BaseAiCfQwenQwen25Coder32BInstruct with get, set

            [<EmitProperty("@cf/baai/bge-reranker-base")>]
            abstract cfBaaiBgeRerankerBase: BaseAiCfBaaiBgeRerankerBase with get, set

            [<EmitProperty("@cf/meta/llama-guard-3-8b")>]
            abstract cfMetaLlamaGuard38b: BaseAiCfMetaLlamaGuard38B with get, set

            [<EmitProperty("@cf/meta/llama-3.3-70b-instruct-fp8-fast")>]
            abstract cfMetaLlama3370bInstructFp8Fast: BaseAiCfMetaLlama3370BInstructFp8Fast with get, set

            [<EmitProperty("@cf/meta/llama-3.2-11b-vision-instruct")>]
            abstract cfMetaLlama3211bVisionInstruct: BaseAiCfMetaLlama3211BVisionInstruct with get, set

            [<EmitProperty("@cf/black-forest-labs/flux-1-schnell")>]
            abstract cfBlackForestLabsFlux1Schnell: BaseAiCfBlackForestLabsFlux1Schnell with get, set

            [<EmitProperty("@cf/baai/bge-m3")>]
            abstract cfBaaiBgeM3: BaseAiCfBaaiBgeM3 with get, set

            [<EmitProperty("@cf/openai/whisper-large-v3-turbo")>]
            abstract cfOpenaiWhisperLargeV3Turbo: BaseAiCfOpenaiWhisperLargeV3Turbo with get, set

            [<EmitProperty("@cf/openai/whisper-tiny-en")>]
            abstract cfOpenaiWhisperTinyEn: BaseAiCfOpenaiWhisperTinyEn with get, set

            [<EmitProperty("@cf/unum/uform-gen2-qwen-500m")>]
            abstract cfUnumUformGen2Qwen500m: BaseAiCfUnumUformGen2Qwen500M with get, set

            [<EmitProperty("@cf/baai/bge-large-en-v1.5")>]
            abstract cfBaaiBgeLargeEnV15: BaseAiCfBaaiBgeLargeEnV15 with get, set

            [<EmitProperty("@cf/baai/bge-small-en-v1.5")>]
            abstract cfBaaiBgeSmallEnV15: BaseAiCfBaaiBgeSmallEnV15 with get, set

            [<EmitProperty("@cf/meta/m2m100-1.2b")>]
            abstract cfMetaM2m10012b: BaseAiCfMetaM2M10012B with get, set

            [<EmitProperty("@cf/openai/whisper")>]
            abstract cfOpenaiWhisper: BaseAiCfOpenaiWhisper with get, set

            [<EmitProperty("@cf/baai/bge-base-en-v1.5")>]
            abstract cfBaaiBgeBaseEnV15: BaseAiCfBaaiBgeBaseEnV15 with get, set

            [<EmitProperty("@cf/llava-hf/llava-1.5-7b-hf")>]
            abstract cfLlavaHfLlava157bHf: BaseAiImageToText with get, set

            [<EmitProperty("@cf/facebook/bart-large-cnn")>]
            abstract cfFacebookBartLargeCnn: BaseAiSummarization with get, set

            [<EmitProperty("@cf/ibm-granite/granite-4.0-h-micro")>]
            abstract cfIbmGraniteGranite40HMicro: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/deepseek-ai/deepseek-r1-distill-qwen-32b")>]
            abstract cfDeepseekAiDeepseekR1DistillQwen32b: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/meta/llama-3.2-1b-instruct")>]
            abstract cfMetaLlama321bInstruct: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/meta/llama-3.2-3b-instruct")>]
            abstract cfMetaLlama323bInstruct: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/meta/llama-3.1-8b-instruct-awq")>]
            abstract cfMetaLlama318bInstructAwq: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/meta/llama-3.1-8b-instruct-fp8")>]
            abstract cfMetaLlama318bInstructFp8: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/meta/llama-3-8b-instruct-awq")>]
            abstract cfMetaLlama38bInstructAwq: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/fblgit/una-cybertron-7b-v2-bf16")>]
            abstract cfFblgitUnaCybertron7bV2Bf16: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/meta/llama-3-8b-instruct")>]
            abstract cfMetaLlama38bInstruct: BaseAiTextGeneration with get, set

            [<EmitProperty("@hf/mistral/mistral-7b-instruct-v0.2")>]
            abstract hfMistralMistral7bInstructV02: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/google/gemma-7b-it-lora")>]
            abstract cfGoogleGemma7bItLora: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/google/gemma-2b-it-lora")>]
            abstract cfGoogleGemma2bItLora: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/meta-llama/llama-2-7b-chat-hf-lora")>]
            abstract cfMetaLlamaLlama27bChatHfLora: BaseAiTextGeneration with get, set

            [<EmitProperty("@hf/google/gemma-7b-it")>]
            abstract hfGoogleGemma7bIt: BaseAiTextGeneration with get, set

            [<EmitProperty("@hf/nexusflow/starling-lm-7b-beta")>]
            abstract hfNexusflowStarlingLm7bBeta: BaseAiTextGeneration with get, set

            [<EmitProperty("@hf/nousresearch/hermes-2-pro-mistral-7b")>]
            abstract hfNousresearchHermes2ProMistral7b: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/mistral/mistral-7b-instruct-v0.2-lora")>]
            abstract cfMistralMistral7bInstructV02Lora: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/qwen/qwen1.5-1.8b-chat")>]
            abstract cfQwenQwen1518bChat: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/microsoft/phi-2")>]
            abstract cfMicrosoftPhi2: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/tinyllama/tinyllama-1.1b-chat-v1.0")>]
            abstract cfTinyllamaTinyllama11bChatV10: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/qwen/qwen1.5-14b-chat-awq")>]
            abstract cfQwenQwen1514bChatAwq: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/qwen/qwen1.5-7b-chat-awq")>]
            abstract cfQwenQwen157bChatAwq: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/qwen/qwen1.5-0.5b-chat")>]
            abstract cfQwenQwen1505bChat: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/thebloke/discolm-german-7b-v1-awq")>]
            abstract cfTheblokeDiscolmGerman7bV1Awq: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/tiiuae/falcon-7b-instruct")>]
            abstract cfTiiuaeFalcon7bInstruct: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/openchat/openchat-3.5-0106")>]
            abstract cfOpenchatOpenchat350106: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/defog/sqlcoder-7b-2")>]
            abstract cfDefogSqlcoder7b2: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/deepseek-ai/deepseek-math-7b-instruct")>]
            abstract cfDeepseekAiDeepseekMath7bInstruct: BaseAiTextGeneration with get, set

            [<EmitProperty("@hf/thebloke/deepseek-coder-6.7b-instruct-awq")>]
            abstract hfTheblokeDeepseekCoder67bInstructAwq: BaseAiTextGeneration with get, set

            [<EmitProperty("@hf/thebloke/deepseek-coder-6.7b-base-awq")>]
            abstract hfTheblokeDeepseekCoder67bBaseAwq: BaseAiTextGeneration with get, set

            [<EmitProperty("@hf/thebloke/neural-chat-7b-v3-1-awq")>]
            abstract hfTheblokeNeuralChat7bV31Awq: BaseAiTextGeneration with get, set

            [<EmitProperty("@hf/thebloke/openhermes-2.5-mistral-7b-awq")>]
            abstract hfTheblokeOpenhermes25Mistral7bAwq: BaseAiTextGeneration with get, set

            [<EmitProperty("@hf/thebloke/zephyr-7b-beta-awq")>]
            abstract hfTheblokeZephyr7bBetaAwq: BaseAiTextGeneration with get, set

            [<EmitProperty("@hf/thebloke/mistral-7b-instruct-v0.1-awq")>]
            abstract hfTheblokeMistral7bInstructV01Awq: BaseAiTextGeneration with get, set

            [<EmitProperty("@hf/thebloke/llama-2-13b-chat-awq")>]
            abstract hfTheblokeLlama213bChatAwq: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/meta/llama-2-7b-chat-fp16")>]
            abstract cfMetaLlama27bChatFp16: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/mistral/mistral-7b-instruct-v0.1")>]
            abstract cfMistralMistral7bInstructV01: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/meta/llama-2-7b-chat-int8")>]
            abstract cfMetaLlama27bChatInt8: BaseAiTextGeneration with get, set

            [<EmitProperty("@cf/microsoft/resnet-50")>]
            abstract cfMicrosoftResnet50: BaseAiImageClassification with get, set

            [<EmitProperty("@cf/google/embeddinggemma-300m")>]
            abstract cfGoogleEmbeddinggemma300m: BaseAiTextEmbeddings with get, set

            [<EmitProperty("@cf/myshell-ai/melotts")>]
            abstract cfMyshellAiMelotts: BaseAiTextToSpeech with get, set

            [<EmitProperty("@cf/bytedance/stable-diffusion-xl-lightning")>]
            abstract cfBytedanceStableDiffusionXlLightning: BaseAiTextToImage with get, set

            [<EmitProperty("@cf/lykon/dreamshaper-8-lcm")>]
            abstract cfLykonDreamshaper8Lcm: BaseAiTextToImage with get, set

            [<EmitProperty("@cf/runwayml/stable-diffusion-v1-5-img2img")>]
            abstract cfRunwaymlStableDiffusionV15Img2img: BaseAiTextToImage with get, set

            [<EmitProperty("@cf/runwayml/stable-diffusion-v1-5-inpainting")>]
            abstract cfRunwaymlStableDiffusionV15Inpainting: BaseAiTextToImage with get, set

            [<EmitProperty("@cf/stabilityai/stable-diffusion-xl-base-1.0")>]
            abstract cfStabilityaiStableDiffusionXlBase10: BaseAiTextToImage with get, set

            [<EmitProperty("@cf/huggingface/distilbert-sst-2-int8")>]
            abstract cfHuggingfaceDistilbertSst2Int8: BaseAiTextClassification with get, set

        [<Import("@cloudflare/workers-types", "WorkflowError")>]
        type WorkflowError =
            abstract message: D1SessionBookmark with get, set
            abstract code: option<float> with get, set

        [<Import("@cloudflare/workers-types", "TraceItemHibernatableWebSocketEventInfo")>]
        type TraceItemHibernatableWebSocketEventInfo =
            abstract getWebSocketEvent:
                U3<
                    TraceItemHibernatableWebSocketEventInfoMessage,
                    TraceItemHibernatableWebSocketEventInfoClose,
                    TraceItemHibernatableWebSocketEventInfoError
                 > with get

        [<Import("@cloudflare/workers-types", "CryptoKeyKeyAlgorithm")>]
        type CryptoKeyKeyAlgorithm =
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "QueueSendBatchMetadata")>]
        type QueueSendBatchMetadata =
            abstract metrics: QueueSendBatchMetrics with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionCustomToolGrammarFormat")>]
        type ChatCompletionCustomToolGrammarFormat =
            abstract grammar: AiModels._Lit197 with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ChatCompletionCustomToolGrammarFormat.Type with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type IncomingRequestCfPropertiesTLSClientAuthPlaceholder =
            | [<CompiledName("0")>] ``0``
            | NONE
            | [<CompiledName("")>] Empty

        [<Import("@cloudflare/workers-types", "AiInternalError"); AbstractClass; AllowNullLiteral>]
        type AiInternalError private () =
            inherit exn()

        [<Import("@cloudflare/workers-types", "AiTextEmbeddingsOutput")>]
        type AiTextEmbeddingsOutput =
            abstract data: ResizeArray<AiSentenceSimilarityOutput> with get, set
            abstract shape: AiSentenceSimilarityOutput with get, set

        [<Import("@cloudflare/workers-types", "AnalyticsEngineDataset")>]
        type AnalyticsEngineDataset =
            abstract writeDataPoint: ?event: AnalyticsEngineDataPoint -> unit

        [<Import("@cloudflare/workers-types", "TraceItemEmailEventInfo")>]
        type TraceItemEmailEventInfo =
            abstract rawSize: float with get
            abstract rcptTo: D1SessionBookmark with get
            abstract mailFrom: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "CompletionUsage")>]
        type CompletionUsage =
            [<EmitProperty("completion_tokens_details")>]
            abstract completionTokensDetails: option<CompletionTokensDetails> with get, set

            [<EmitProperty("prompt_tokens_details")>]
            abstract promptTokensDetails: option<PromptTokensDetails> with get, set

            [<EmitProperty("total_tokens")>]
            abstract totalTokens: float with get, set

            [<EmitProperty("completion_tokens")>]
            abstract completionTokens: float with get, set

            [<EmitProperty("prompt_tokens")>]
            abstract promptTokens: float with get, set

        [<Import("@cloudflare/workers-types", "AiImageTextToTextOutput")>]
        type AiImageTextToTextOutput =
            abstract description: D1SessionBookmark with get, set

        type AiObjectDetectionOutput = obj

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfMistralaiMistralSmall3124BInstruct private () =
            abstract postProcessedOutputs: AiCfMistralaiMistralSmall3124BInstructOutput with get, set
            abstract inputs: AiCfMistralaiMistralSmall3124BInstructInput with get, set

        [<Import("@cloudflare/workers-types", "SocketAddress")>]
        type SocketAddress =
            abstract port: float with get, set
            abstract hostname: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Deepgram_Nova_3"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfDeepgramNova3 private () =
            abstract postProcessedOutputs: AiCfDeepgramNova3Output with get, set
            abstract inputs: AiCfDeepgramNova3Input with get, set

        [<Import("@cloudflare/workers-types", "QueueSendOptions")>]
        type QueueSendOptions =
            abstract delaySeconds: option<float> with get, set
            abstract contentType: option<QueueContentType> with get, set

        [<Import("@cloudflare/workers-types", "TraceItemTailEventInfoTailItem")>]
        type TraceItemTailEventInfoTailItem =
            abstract scriptName: option<string> with get

        [<Import("@cloudflare/workers-types", "AiGatewayLog")>]
        type AiGatewayLog =
            [<EmitProperty("created_at")>]
            abstract createdAt: Date with get, set

            [<EmitProperty("response_head_complete")>]
            abstract responseHeadComplete: bool with get, set

            [<EmitProperty("response_head")>]
            abstract responseHead: option<D1SessionBookmark> with get, set

            [<EmitProperty("response_size")>]
            abstract responseSize: float with get, set

            [<EmitProperty("request_head_complete")>]
            abstract requestHeadComplete: bool with get, set

            [<EmitProperty("request_head")>]
            abstract requestHead: option<D1SessionBookmark> with get, set

            [<EmitProperty("request_size")>]
            abstract requestSize: float with get, set

            [<EmitProperty("custom_cost")>]
            abstract customCost: option<bool> with get, set

            abstract cost: option<float> with get, set
            abstract step: option<float> with get, set
            abstract metadata: option<WebAssembly.ModuleImports> with get, set

            [<EmitProperty("tokens_out")>]
            abstract tokensOut: option<float> with get, set

            [<EmitProperty("tokens_in")>]
            abstract tokensIn: option<float> with get, set

            abstract cached: bool with get, set
            abstract success: bool with get, set

            [<EmitProperty("response_content_type")>]
            abstract responseContentType: option<D1SessionBookmark> with get, set

            [<EmitProperty("status_code")>]
            abstract statusCode: float with get, set

            [<EmitProperty("request_content_type")>]
            abstract requestContentType: option<D1SessionBookmark> with get, set

            [<EmitProperty("request_type")>]
            abstract requestType: option<D1SessionBookmark> with get, set

            abstract duration: float with get, set
            abstract path: D1SessionBookmark with get, set

            [<EmitProperty("model_type")>]
            abstract modelType: option<D1SessionBookmark> with get, set

            abstract model: D1SessionBookmark with get, set
            abstract provider: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiModelsSearchObject")>]
        type AiModelsSearchObject =
            abstract properties: ResizeArray<Ai._Lit100> with get, set
            abstract tags: ResizeArray<D1SessionBookmark> with get, set
            abstract task: Ai._Lit99 with get, set
            abstract description: D1SessionBookmark with get, set
            abstract name: D1SessionBookmark with get, set
            abstract source: float with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ContainerDirectorySnapshotRestoreParams")>]
        type ContainerDirectorySnapshotRestoreParams =
            abstract mountPoint: option<D1SessionBookmark> with get, set
            abstract snapshot: ContainerDirectorySnapshot with get, set

        [<Import("@cloudflare/workers-types", "EventTargetAddEventListenerOptions")>]
        type EventTargetAddEventListenerOptions =
            abstract signal: option<AbortSignal> with get, set
            abstract once: option<bool> with get, set
            abstract passive: option<bool> with get, set
            abstract capture: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "RateLimitedError")>]
        type RateLimitedError =
            inherit StreamError
            abstract name: RateLimitedError.Name with get, set

        [<Import("@cloudflare/workers-types", "D1Database"); AbstractClass; AllowNullLiteral>]
        type D1Database private () =
            abstract dump: unit -> Promise<ArrayBuffer>

            abstract withSession:
                ?constraintOrBookmark: U2<D1Database.WithSession.ConstraintOrBookmark, string> -> D1DatabaseSession

            abstract exec: query: D1SessionBookmark -> Promise<D1ExecResult>
            abstract batch: statements: ResizeArray<D1PreparedStatement> -> Promise<ResizeArray<D1Database.Batch>>
            abstract prepare: query: D1SessionBookmark -> D1PreparedStatement

        type BodyInit =
            U7<
                ReadableStream<Uint8Array<ArrayBufferLike>>,
                ArrayBuffer,
                ArrayBufferView<ArrayBufferLike>,
                Blob,
                URLSearchParams,
                FormData,
                string
             >

        type ResponseFunctionCallOutputItemList = obj

        [<Import("@cloudflare/workers-types", "ResponseInputMessageItem")>]
        type ResponseInputMessageItem =
            [<EmitProperty("type")>]
            abstract ``type``: option<ResponseInputMessageItem.Type> with get, set

            abstract status: option<AiModels._Lit252> with get, set
            abstract role: AiModels._Lit261 with get, set
            abstract content: ResponseInputMessageContentList with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "SyncKvListOptions")>]
        type SyncKvListOptions =
            abstract limit: option<float> with get, set
            abstract reverse: option<bool> with get, set
            abstract prefix: option<D1SessionBookmark> with get, set

            [<EmitProperty("end")>]
            abstract ``end``: option<D1SessionBookmark> with get, set

            abstract startAfter: option<D1SessionBookmark> with get, set
            abstract start: option<D1SessionBookmark> with get, set

        type AiCfBaaiBgeM3Output = obj

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_AsyncResponse")>]
        type AiCfAisingaporeGemmaSeaLionV427BItAsyncResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "FlagshipEvaluationError"); AbstractClass; AllowNullLiteral>]
        type FlagshipEvaluationError private () =
            inherit exn()

        type AiTextClassificationOutput = obj

        type ResponseItem =
            U4<
                ResponseInputMessageItem._Lit1,
                AiModels._Lit246,
                ResponseFunctionToolCallItem,
                ResponseFunctionToolCallOutputItem._Lit1
             >

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type CertVerificationStatus =
            | SUCCESS
            | NONE
            | [<CompiledName("FAILED:self signed certificate")>] ``FAILED:selfsignedcertificate``
            | [<CompiledName("FAILED:unable to verify the first certificate")>] ``FAILED:unabletoverifythefirstcertificate``
            | [<CompiledName("FAILED:certificate is not yet valid")>] ``FAILED:certificateisnotyetvalid``
            | [<CompiledName("FAILED:certificate has expired")>] ``FAILED:certificatehasexpired``
            | FAILED

        [<Import("@cloudflare/workers-types", "AiSearchChatCompletionsRequest")>]
        type AiSearchChatCompletionsRequest =
            [<EmitProperty("ai_search_options")>]
            abstract aiSearchOptions: option<AiSearchOptions> with get, set

            abstract stream: option<bool> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract messages: ResizeArray<AiSearchMessage> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "AiSearchMultiChatCompletionsRequest")>]
        type AiSearchMultiChatCompletionsRequest =
            [<EmitProperty("ai_search_options")>]
            abstract aiSearchOptions: AiSearchMultiSearchOptions with get, set

            abstract Item: key: D1SessionBookmark -> option<obj>

        type DispatchEvent =
            abstract Invoke:
                event: U4<PromiseRejectionEvent, QueueEvent<option<obj>>, ScheduledEvent, FetchEvent> -> bool

            abstract Invoke: event: Event -> bool

        type AiCfPipecatAiSmartTurnV2Input = obj
        type R2Range = obj

        [<Import("@cloudflare/workers-types", "RequestInitCfPropertiesR2")>]
        type RequestInitCfPropertiesR2 =
            abstract bucketColoId: option<float> with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionContentPartText")>]
        type ChatCompletionContentPartText =
            abstract text: D1SessionBookmark with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ChatCompletionContentPartText.Type with get, set

        [<Import("@cloudflare/workers-types", "EmailExportedHandler")>]
        type EmailExportedHandler<'Props, 'Env> =
            abstract Invoke:
                message: ForwardableEmailMessage * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Black_Forest_Labs_Flux_2_Dev");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfBlackForestLabsFlux2Dev private () =
            abstract postProcessedOutputs: AiCfBlackForestLabsFlux2DevOutput with get, set
            abstract inputs: AiCfBlackForestLabsFlux2DevInput with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type StreamWatermarkPosition =
            | [<CompiledName("upperRight")>] UpperRight
            | [<CompiledName("upperLeft")>] UpperLeft
            | [<CompiledName("lowerLeft")>] LowerLeft
            | [<CompiledName("lowerRight")>] LowerRight
            | [<CompiledName("center")>] Center

        [<Import("@cloudflare/workers-types", "ScheduledEvent"); AbstractClass; AllowNullLiteral>]
        type ScheduledEvent private () =
            inherit ExtendableEvent()
            abstract cron: D1SessionBookmark with get
            abstract scheduledTime: float with get
            abstract noRetry: unit -> unit

        [<Import("@cloudflare/workers-types", "WorkerGlobalScope"); AbstractClass; AllowNullLiteral>]
        type WorkerGlobalScope private () =
            inherit Body()

            [<EmitProperty("EventTarget")>]
            abstract eventTarget: Typescript.EventTarget._Lit1 with get, set

        [<Import("@cloudflare/workers-types", "ImageList")>]
        type ImageList =
            abstract listComplete: bool with get, set
            abstract cursor: option<D1SessionBookmark> with get, set
            abstract images: ResizeArray<ImageMetadata> with get, set

        [<Import("@cloudflare/workers-types", "ImageTransformationResult")>]
        type ImageTransformationResult =
            abstract image: ?options: ImageTransformationOutputOptions -> ReadableStream<Uint8Array<ArrayBufferLike>>
            abstract contentType: unit -> D1SessionBookmark
            abstract response: unit -> Global.Response

        [<Import("@cloudflare/workers-types", "UnderlyingSink")>]
        type UnderlyingSink<'W> =
            [<EmitProperty("type")>]
            abstract ``type``: option<D1SessionBookmark> with get, set

            abstract write: option<UnderlyingSinkWriteCallback<'W>> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<unit> with get, set

            abstract start: option<UnderlyingSinkStartCallback> with get, set
            abstract close: option<UnderlyingSinkCloseCallback> with get, set
            abstract abort: option<UnderlyingSinkAbortCallback> with get, set
            abstract close: unit -> option<Promise<unit>>
            abstract abort: ?reason: obj -> option<Promise<unit>>
            abstract write: chunk: 'W * controller: Global.WritableStreamDefaultController -> option<Promise<unit>>
            abstract start: controller: Global.WritableStreamDefaultController -> option<Promise<unit>>

        type ResponseInput = obj
        type AiCfMistralaiMistralSmall3124BInstructInput = obj

        [<Import("@cloudflare/workers-types", "ChatTemplateKwargs")>]
        type ChatTemplateKwargs =
            [<EmitProperty("clear_thinking")>]
            abstract clearThinking: option<bool> with get, set

            [<EmitProperty("enable_thinking")>]
            abstract enableThinking: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner")>]
        type AiCfMetaLlama4Scout17B16EInstructMessagesInner =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfMetaLlama4Scout17B16EInstructJSONMode> with get, set

            abstract tools: option<ResizeArray<U2<AiModels._Lit72, AiModels._Lit76>>> with get, set
            abstract functions: option<ResizeArray<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: ResizeArray<AiModels._Lit67> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type InternalError = | InternalError

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type VectorizeDistanceMetric =
            | [<CompiledName("euclidean")>] Euclidean
            | [<CompiledName("cosine")>] Cosine
            | [<CompiledName("dot-product")>] DotProduct

        [<Import("@cloudflare/workers-types", "Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Prompt")>]
        type AiCfMistralaiMistralSmall3124BInstructPrompt =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "BasicImageTransformationsGravityCoordinates")>]
        type BasicImageTransformationsGravityCoordinates =
            abstract mode: option<ImageTransformer._Lit8> with get, set
            abstract y: option<float> with get, set
            abstract x: option<float> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponsesOutput = | [<CompiledName("response")>] Response

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Deepgram_Aura_2_En"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfDeepgramAura2En private () =
            abstract postProcessedOutputs: D1SessionBookmark with get, set
            abstract inputs: AiCfDeepgramAura2EnInput with get, set

        [<Import("@cloudflare/workers-types", "AiTextGenerationInput")>]
        type AiTextGenerationInput =
            abstract functions: option<ResizeArray<AiTextGenerationFunctionsInput>> with get, set

            abstract tools:
                option<U3<ResizeArray<AiTextGenerationToolInput>, ResizeArray<AiTextGenerationToolLegacyInput>, obj>> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiTextGenerationResponseFormat> with get, set

            abstract messages: option<ResizeArray<RoleScopedChatInput>> with get, set

            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set
            abstract prompt: option<D1SessionBookmark> with get, set

        type ChatCompletionsInput = ChatCompletionsInput

        [<Import("@cloudflare/workers-types", "URL"); AbstractClass; AllowNullLiteral>]
        type URL private () =
            [<EmitConstructor>]
            abstract Create: url: U2<URL, string> * ?``base``: U2<URL, string> -> URL

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

        [<Import("@cloudflare/workers-types", "TopLogprob")>]
        type TopLogprob =
            abstract logprob: option<float> with get, set
            abstract token: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "UsageTags")>]
        type UsageTags =
            [<EmitProperty("total_tokens")>]
            abstract totalTokens: float with get, set

            [<EmitProperty("completion_tokens")>]
            abstract completionTokens: float with get, set

            [<EmitProperty("prompt_tokens")>]
            abstract promptTokens: float with get, set

        [<Import("@cloudflare/workers-types", "Performance"); AbstractClass; AllowNullLiteral>]
        type Performance private () =
            abstract timeOrigin: float with get
            abstract toJSON: unit -> obj
            abstract now: unit -> float

        [<Import("@cloudflare/workers-types", "KVNamespaceListOptions")>]
        type KVNamespaceListOptions =
            abstract cursor: option<string> with get, set
            abstract prefix: option<string> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "QueueSendBatchOptions")>]
        type QueueSendBatchOptions =
            abstract delaySeconds: option<float> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Prompt_1")>]
        type AiCfQwenQwen330BA3BFp8Prompt1 =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfQwenQwen330BA3BFp8JSONMode2> with get, set

            abstract lora: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiTranslationInput")>]
        type AiTranslationInput =
            [<EmitProperty("source_lang")>]
            abstract sourceLang: option<D1SessionBookmark> with get, set

            [<EmitProperty("target_lang")>]
            abstract targetLang: D1SessionBookmark with get, set

            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Queue")>]
        type Queue<'Body> =
            abstract sendBatch:
                messages: seq<MessageSendRequest<'Body>, option<obj>, option<obj>> * ?options: QueueSendBatchOptions ->
                    Promise<QueueSendBatchResponse>

            abstract send: message: 'Body * ?options: QueueSendOptions -> Promise<QueueSendResponse>
            abstract metrics: unit -> Promise<QueueMetrics>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Meta_Llama_Guard_3_8B"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfMetaLlamaGuard38B private () =
            abstract postProcessedOutputs: AiCfMetaLlamaGuard38BOutput with get, set
            abstract inputs: AiCfMetaLlamaGuard38BInput with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Qwen_Qwen3_Embedding_0_6B"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfQwenQwen3Embedding06B private () =
            abstract postProcessedOutputs: AiCfQwenQwen3Embedding06BOutput with get, set
            abstract inputs: AiCfQwenQwen3Embedding06BInput with get, set

        [<Import("@cloudflare/workers-types", "SqlStorageStatement"); AbstractClass; AllowNullLiteral>]
        type SqlStorageStatement private () = class end

        [<Import("@cloudflare/workers-types", "LoopbackDurableObjectNamespace"); AbstractClass; AllowNullLiteral>]
        type LoopbackDurableObjectNamespace private () =
            inherit DurableObjectNamespace<unit>()

        [<Import("@cloudflare/workers-types", "Doctype")>]
        type Doctype =
            abstract systemId: option<string> with get
            abstract publicId: option<string> with get
            abstract name: option<string> with get

        [<Import("@cloudflare/workers-types", "QueueSendMetrics")>]
        type QueueSendMetrics =
            abstract oldestMessageTimestamp: option<Date> with get, set
            abstract backlogBytes: float with get, set
            abstract backlogCount: float with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type FunctionMessage = | [<CompiledName("function")>] Function

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_Reranker_Base_Output")>]
        type AiCfBaaiBgeRerankerBaseOutput =
            abstract response: option<ResizeArray<AiModels._Lit65>> with get, set

        [<Import("@cloudflare/workers-types", "ResponseCreatedEvent")>]
        type ResponseCreatedEvent =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseCreatedEvent.Type with get, set

            [<EmitProperty("sequence_number")>]
            abstract sequenceNumber: float with get, set

            abstract response: Global.Response with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Output_EmbeddingFor_Contexts")>]
        type AiCfBaaiBgeM3OutputEmbeddingForContexts =
            abstract pooling: option<AiModels._Lit36> with get, set
            abstract shape: option<AiSentenceSimilarityOutput> with get, set
            abstract response: option<ResizeArray<AiSentenceSimilarityOutput>> with get, set

        [<Import("@cloudflare/workers-types", "BaseAiTranslation"); AbstractClass; AllowNullLiteral>]
        type BaseAiTranslation private () =
            abstract postProcessedOutputs: AiTranslationOutput with get, set
            abstract inputs: AiTranslationInput with get, set

        [<Import("@cloudflare/workers-types", "AiSearchOptions")>]
        type AiSearchOptions =
            abstract cache: option<Ai._Lit11> with get, set
            abstract reranking: option<Ai._Lit10> with get, set

            [<EmitProperty("query_rewrite")>]
            abstract queryRewrite: option<Ai._Lit9> with get, set

            abstract retrieval: option<Ai._Lit4> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "SocketOptions")>]
        type SocketOptions =
            abstract highWaterMark: option<float> with get, set
            abstract allowHalfOpen: bool with get, set
            abstract secureTransport: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ArtifactsRepoListResult")>]
        type ArtifactsRepoListResult =
            abstract cursor: option<D1SessionBookmark> with get, set
            abstract total: float with get, set
            abstract repos: ResizeArray<ArtifactsRepoListResult.Repos> with get, set

        [<Import("@cloudflare/workers-types", "R2StringChecksums")>]
        type R2StringChecksums =
            abstract sha512: option<D1SessionBookmark> with get, set
            abstract sha384: option<D1SessionBookmark> with get, set
            abstract sha256: option<D1SessionBookmark> with get, set
            abstract sha1: option<D1SessionBookmark> with get, set
            abstract md5: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_JSON_Mode_1")>]
        type AiCfQwenQwen25Coder32BInstructJSONMode1 =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiModels._Lit80> with get, set

        [<Import("@cloudflare/workers-types", "VectorizeError")>]
        type VectorizeError =
            abstract error: D1SessionBookmark with get, set
            abstract code: option<float> with get, set

        [<Import("@cloudflare/workers-types", "WorkerLoader")>]
        type WorkerLoader =
            abstract load: code: WorkerLoaderWorkerCode -> WorkerStub

            abstract get:
                ?name: string * getCode: unit -> U2<WorkerLoaderWorkerCode, Promise<WorkerLoaderWorkerCode>> ->
                    WorkerStub

        [<Import("@cloudflare/workers-types", "TailEvent"); AbstractClass; AllowNullLiteral>]
        type TailEvent private () =
            inherit ExtendableEvent()
            abstract traces: ResizeArray<TraceItem> with get
            abstract events: ResizeArray<TraceItem> with get

        [<Import("@cloudflare/workers-types", "WorkerGlobalScopeEventMap")>]
        type WorkerGlobalScopeEventMap =
            abstract rejectionhandled: PromiseRejectionEvent with get, set
            abstract unhandledrejection: PromiseRejectionEvent with get, set
            abstract queue: QueueEvent<option<obj>> with get, set
            abstract scheduled: ScheduledEvent with get, set
            abstract fetch: FetchEvent with get, set

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

        type TemplateLiteral =
            abstract Value: string
            abstract Create: v0: float -> TemplateLiteral

        [<Import("@cloudflare/workers-types", "R2MultipartOptions")>]
        type R2MultipartOptions =
            abstract ssecKey: option<U2<ArrayBuffer, string>> with get, set
            abstract storageClass: option<D1SessionBookmark> with get, set
            abstract customMetadata: option<WebAssembly.ModuleImports> with get, set
            abstract httpMetadata: option<U2<R2HTTPMetadata, Headers>> with get, set

        [<Import("@cloudflare/workers-types", "WorkflowInstanceCreateOptions")>]
        type WorkflowInstanceCreateOptions<'PARAMS> =
            abstract retention: option<WorkflowInstanceCreateOptions._Lit1> with get, set
            abstract params: option<'PARAMS> with get, set
            abstract id: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "D1PreparedStatement"); AbstractClass; AllowNullLiteral>]
        type D1PreparedStatement private () =
            abstract raw: ?options: D1PreparedStatement._Lit8 -> Promise<ResizeArray<'T>>

            abstract raw:
                options: D1PreparedStatement._Lit7 -> Promise<ResizeArray<D1SessionBookmark> * ResizeArray<'T>>

            abstract all: unit -> Promise<D1PreparedStatement.All>
            abstract run: unit -> Promise<D1PreparedStatement.Run>
            abstract first: unit -> Promise<option<'T>>
            abstract first: colName: D1SessionBookmark -> Promise<option<'T>>
            abstract bind: [<ParamArray>] values: ResizeArray<option<obj>> -> D1PreparedStatement

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionContentPartRefusal = | [<CompiledName("refusal")>] Refusal

        [<Import("@cloudflare/workers-types", "MediaTransformationResult")>]
        type MediaTransformationResult =
            abstract contentType: unit -> Promise<D1SessionBookmark>
            abstract response: unit -> Promise<Global.Response>
            abstract media: unit -> Promise<ReadableStream<Uint8Array<ArrayBufferLike>>>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_JSON_Mode")>]
        type AiCfMetaLlama4Scout17B16EInstructJSONMode =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiModels._Lit80> with get, set

        [<Import("@cloudflare/workers-types", "CryptoKeyEllipticKeyAlgorithm")>]
        type CryptoKeyEllipticKeyAlgorithm =
            abstract namedCurve: D1SessionBookmark with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ResponseInputImage")>]
        type ResponseInputImage =
            [<EmitProperty("image_url")>]
            abstract imageUrl: option<string> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ResponseInputImage.Type with get, set

            abstract detail: AiModels._Lit273 with get, set

        [<Import("@cloudflare/workers-types", "QueueEvent"); AbstractClass; AllowNullLiteral>]
        type QueueEvent<'Body> private () =
            inherit ExtendableEvent()
            abstract metadata: MessageBatchMetadata with get
            abstract queue: D1SessionBookmark with get
            abstract messages: System.Collections.Generic.IReadOnlyList<Message<'Body>> with get
            abstract ackAll: unit -> unit
            abstract retryAll: ?options: QueueRetryOptions -> unit

        [<Import("@cloudflare/workers-types", "KVNamespacePutOptions")>]
        type KVNamespacePutOptions =
            abstract metadata: option<obj> with get, set
            abstract expirationTtl: option<float> with get, set
            abstract expiration: option<float> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchJobLogsResponse")>]
        type AiSearchJobLogsResponse =
            [<EmitProperty("result_info")>]
            abstract resultInfo: option<Ai._Lit49> with get, set

            abstract result: ResizeArray<AiSearchJobLog> with get, set

        type AiCfMetaLlama3370BInstructFp8FastInput = obj

        [<Import("@cloudflare/workers-types", "R2Checksums")>]
        type R2Checksums =
            abstract sha512: option<ArrayBuffer> with get
            abstract sha384: option<ArrayBuffer> with get
            abstract sha256: option<ArrayBuffer> with get
            abstract sha1: option<ArrayBuffer> with get
            abstract md5: option<ArrayBuffer> with get
            abstract toJSON: unit -> R2StringChecksums

        [<Import("@cloudflare/workers-types", "DurableObjectPutOptions")>]
        type DurableObjectPutOptions =
            abstract noCache: option<bool> with get, set
            abstract allowUnconfirmed: option<bool> with get, set
            abstract allowConcurrency: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItems"); AbstractClass; AllowNullLiteral>]
        type AiSearchItems private () =
            abstract delete: itemId: D1SessionBookmark -> Promise<unit>
            abstract get: itemId: D1SessionBookmark -> AiSearchItem

            abstract uploadAndPoll:
                name: D1SessionBookmark * content: U3<ReadableStream<option<obj>>, Blob, string> * ?options: Ai._Lit52 ->
                    Promise<AiSearchItemInfo>

            abstract upload:
                name: D1SessionBookmark *
                content: U3<ReadableStream<option<obj>>, Blob, string> *
                ?options: AiSearchUploadItemOptions ->
                    Promise<AiSearchItemInfo>

            abstract list: ?params: AiSearchListItemsParams -> Promise<AiSearchListItemsResponse>

        [<Import("@cloudflare/workers-types", "WebSocketRequestResponsePair"); AbstractClass; AllowNullLiteral>]
        type WebSocketRequestResponsePair private () =
            [<EmitConstructor>]
            abstract Create: request: D1SessionBookmark * response: D1SessionBookmark -> WebSocketRequestResponsePair

            abstract response: D1SessionBookmark with get
            abstract request: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "AiTranslationOutput")>]
        type AiTranslationOutput =
            [<EmitProperty("translated_text")>]
            abstract translatedText: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionToolChoiceCustom")>]
        type ChatCompletionToolChoiceCustom =
            abstract custom: AiModels._Lit184 with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ChatCompletionToolChoiceCustom.Type with get, set

        [<Import("@cloudflare/workers-types", "PagesPluginFunction")>]
        type PagesPluginFunction<'PluginArgs, 'Data, 'Params, 'Env
            when 'Data :> WebAssembly.ModuleImports and 'Params :> D1SessionBookmark> =
            abstract Invoke:
                context: PagesPluginFunction.Invoke.Context -> U2<Global.Response, Promise<Global.Response>>

        [<Import("@cloudflare/workers-types", "Span"); AbstractClass; AllowNullLiteral>]
        type Span private () =
            abstract isTraced: bool with get
            abstract setAttribute: key: D1SessionBookmark * ?value: U3<bool, float, string> -> unit

        [<Import("@cloudflare/workers-types", "AiMultimodalEmbeddingsInput")>]
        type AiMultimodalEmbeddingsInput =
            abstract text: ResizeArray<D1SessionBookmark> with get, set
            abstract image: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "TextDecoder"); AbstractClass; AllowNullLiteral>]
        type TextDecoder private () =
            [<EmitConstructor>]
            abstract Create: ?label: D1SessionBookmark * ?options: TextDecoderConstructorOptions -> TextDecoder

            abstract ignoreBOM: bool with get
            abstract fatal: bool with get
            abstract encoding: D1SessionBookmark with get
            abstract decode: ?input: BufferSource * ?options: TextDecoderDecodeOptions -> D1SessionBookmark

        [<Import("@cloudflare/workers-types", "MessageBatch")>]
        type MessageBatch<'Body> =
            abstract metadata: MessageBatchMetadata with get
            abstract queue: D1SessionBookmark with get
            abstract messages: System.Collections.Generic.IReadOnlyList<Message<'Body>> with get
            abstract ackAll: unit -> unit
            abstract retryAll: ?options: QueueRetryOptions -> unit

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode")>]
        type AiCfAisingaporeGemmaSeaLionV427BItJSONMode =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiModels._Lit80> with get, set

        [<Import("@cloudflare/workers-types", "ContainerSnapshot")>]
        type ContainerSnapshot =
            abstract name: option<D1SessionBookmark> with get, set
            abstract size: float with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectNamespaceNewUniqueIdOptions")>]
        type DurableObjectNamespaceNewUniqueIdOptions =
            abstract jurisdiction: option<DurableObjectJurisdiction> with get, set

        [<Import("@cloudflare/workers-types", "FetcherPutOptions")>]
        type FetcherPutOptions =
            abstract expirationTtl: option<float> with get, set
            abstract expiration: option<float> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Klein_4B_Output")>]
        type AiCfBlackForestLabsFlux2Klein4BOutput =
            abstract image: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Google_Gemma_3_12B_It_Output")>]
        type AiCfGoogleGemma312BItOutput =
            [<EmitProperty("tool_calls")>]
            abstract toolCalls: option<ResizeArray<AiModels._Lit78>> with get, set

            abstract usage: option<AiModels._Lit87> with get, set
            abstract response: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseOutputText = | [<CompiledName("output_text")>] OutputText

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseTextDeltaEvent = | [<CompiledName("response.output_text.delta")>] ResponseOutputTextDelta

        [<Import("@cloudflare/workers-types", "AiImageToTextInput")>]
        type AiImageToTextInput =
            abstract messages: option<ResizeArray<RoleScopedChatInput>> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract prompt: option<D1SessionBookmark> with get, set
            abstract image: AiSentenceSimilarityOutput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Leonardo_Lucid_Origin_Input")>]
        type AiCfLeonardoLucidOriginInput =
            abstract steps: option<float> with get, set

            [<EmitProperty("num_steps")>]
            abstract numSteps: option<float> with get, set

            abstract width: option<float> with get, set
            abstract height: option<float> with get, set
            abstract seed: option<float> with get, set
            abstract guidance: option<float> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "StreamOptions")>]
        type StreamOptions =
            [<EmitProperty("include_obfuscation")>]
            abstract includeObfuscation: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItemLog")>]
        type AiSearchItemLog =
            abstract errorType: option<D1SessionBookmark> with get, set
            abstract processingTimeMs: option<float> with get, set
            abstract chunkCount: option<float> with get, set
            abstract fileKey: option<D1SessionBookmark> with get, set
            abstract message: D1SessionBookmark with get, set
            abstract action: D1SessionBookmark with get, set
            abstract timestamp: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "PubSubMessage")>]
        type PubSubMessage =
            abstract payload: U2<Uint8Array<ArrayBufferLike>, string> with get, set
            abstract payloadFormatIndicator: float with get
            abstract contentType: D1SessionBookmark with get
            abstract receivedAt: float with get
            abstract jti: option<D1SessionBookmark> with get
            abstract clientId: D1SessionBookmark with get
            abstract topic: D1SessionBookmark with get
            abstract broker: D1SessionBookmark with get
            abstract mid: float with get

        [<Import("@cloudflare/workers-types", "R2HTTPMetadata")>]
        type R2HTTPMetadata =
            abstract cacheExpiry: option<Date> with get, set
            abstract cacheControl: option<D1SessionBookmark> with get, set
            abstract contentEncoding: option<D1SessionBookmark> with get, set
            abstract contentDisposition: option<D1SessionBookmark> with get, set
            abstract contentLanguage: option<D1SessionBookmark> with get, set
            abstract contentType: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "AiTextGenerationToolInput")>]
        type AiTextGenerationToolInput =
            [<EmitProperty("function")>]
            abstract ``function``: AiModels._Lit17 with get, set

            [<EmitProperty("type")>]
            abstract ``type``: U2<AiTextGenerationToolInput.Type, Ai._Lit96> with get, set

        [<Import("@cloudflare/workers-types", "ExportedHandlerQueueHandler")>]
        type ExportedHandlerQueueHandler<'Props, 'Message, 'Env> =
            abstract Invoke:
                batch: MessageBatch<'Message> * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "BaseAiObjectDetection"); AbstractClass; AllowNullLiteral>]
        type BaseAiObjectDetection private () =
            abstract postProcessedOutputs: AiObjectDetectionOutput with get, set
            abstract inputs: AiObjectDetectionInput with get, set

        [<Import("@cloudflare/workers-types", "ResponseInputItemMessage")>]
        type ResponseInputItemMessage =
            [<EmitProperty("type")>]
            abstract ``type``: option<ResponseInputItemMessage.Type> with get, set

            abstract status: option<AiModels._Lit252> with get, set
            abstract role: AiModels._Lit261 with get, set
            abstract content: ResponseInputMessageContentList with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ContinentCode =
            | AF
            | AN
            | AS
            | EU
            | NA
            | OC
            | SA

        [<Import("@cloudflare/workers-types", "EmailMessage")>]
        type EmailMessage =
            [<EmitProperty("to")>]
            abstract ``to``: D1SessionBookmark with get

            abstract from: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "AiTextToImageInput")>]
        type AiTextToImageInput =
            abstract seed: option<float> with get, set
            abstract guidance: option<float> with get, set
            abstract strength: option<float> with get, set

            [<EmitProperty("num_steps")>]
            abstract numSteps: option<float> with get, set

            abstract mask: option<AiSentenceSimilarityOutput> with get, set

            [<EmitProperty("image_b64")>]
            abstract imageB64: option<D1SessionBookmark> with get, set

            abstract image: option<AiSentenceSimilarityOutput> with get, set
            abstract width: option<float> with get, set
            abstract height: option<float> with get, set

            [<EmitProperty("negative_prompt")>]
            abstract negativePrompt: option<D1SessionBookmark> with get, set

            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "RateLimitOptions")>]
        type RateLimitOptions =
            abstract key: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "BaseAiImageToText"); AbstractClass; AllowNullLiteral>]
        type BaseAiImageToText private () =
            abstract postProcessedOutputs: AiImageToTextOutput with get, set
            abstract inputs: AiImageToTextInput with get, set

        [<Import("@cloudflare/workers-types", "PagesFunction")>]
        type PagesFunction<'Data, 'Params, 'Env when 'Data :> WebAssembly.ModuleImports and 'Params :> D1SessionBookmark>
            =
            abstract Invoke: context: PagesFunction.Invoke.Context -> U2<Global.Response, Promise<Global.Response>>

        [<Import("@cloudflare/workers-types", "StreamVideoStatus")>]
        type StreamVideoStatus =
            abstract errorReasonText: D1SessionBookmark with get, set
            abstract errorReasonCode: D1SessionBookmark with get, set
            abstract pctComplete: option<D1SessionBookmark> with get, set
            abstract step: option<D1SessionBookmark> with get, set
            abstract state: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "SocketInfo")>]
        type SocketInfo =
            abstract localAddress: option<D1SessionBookmark> with get, set
            abstract remoteAddress: option<D1SessionBookmark> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseReasoningSummaryItem = | [<CompiledName("summary_text")>] SummaryText

        [<Import("@cloudflare/workers-types", "Ai_Cf_Google_Gemma_3_12B_It_Messages")>]
        type AiCfGoogleGemma312BItMessages =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            abstract tools: option<ResizeArray<U2<AiModels._Lit72, AiModels._Lit76>>> with get, set
            abstract functions: option<ResizeArray<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: ResizeArray<AiModels._Lit101> with get, set

        [<Import("@cloudflare/workers-types", "VectorizeIndexDetails")>]
        type VectorizeIndexDetails =
            abstract vectorsCount: float with get, set
            abstract config: VectorizeIndexConfig with get, set
            abstract description: option<D1SessionBookmark> with get, set
            abstract name: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "EndTag")>]
        type EndTag =
            abstract name: D1SessionBookmark with get, set
            abstract remove: unit -> EndTag

            abstract after:
                content: U3<ReadableStream<option<obj>>, Global.Response, string> * ?options: ContentOptions -> EndTag

            abstract before:
                content: U3<ReadableStream<option<obj>>, Global.Response, string> * ?options: ContentOptions -> EndTag

        [<Import("@cloudflare/workers-types", "MessagePort"); AbstractClass; AllowNullLiteral>]
        type MessagePort private () =
            inherit EventTarget()
            abstract onmessage: option<obj> with set
            abstract onmessage: option<obj> with get
            abstract start: unit -> unit
            abstract close: unit -> unit

            abstract postMessage:
                ?data: obj * ?options: U2<ResizeArray<option<obj>>, MessagePortPostMessageOptions> -> unit

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Black_Forest_Labs_Flux_2_Klein_9B");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfBlackForestLabsFlux2Klein9B private () =
            abstract postProcessedOutputs: AiCfBlackForestLabsFlux2Klein9BOutput with get, set
            abstract inputs: AiCfBlackForestLabsFlux2Klein9BInput with get, set

        type R2Objects = U2<R2Objects._Lit2, R2Objects._Lit9>

        [<Import("@cloudflare/workers-types", "Vectorize"); AbstractClass; AllowNullLiteral>]
        type Vectorize private () =
            abstract getByIds: ids: ResizeArray<D1SessionBookmark> -> Promise<ResizeArray<VectorizeVector>>
            abstract deleteByIds: ids: ResizeArray<D1SessionBookmark> -> Promise<VectorizeAsyncMutation>
            abstract upsert: vectors: ResizeArray<VectorizeVector> -> Promise<VectorizeAsyncMutation>
            abstract insert: vectors: ResizeArray<VectorizeVector> -> Promise<VectorizeAsyncMutation>

            abstract queryById:
                vectorId: D1SessionBookmark * ?options: VectorizeQueryOptions -> Promise<VectorizeMatches>

            abstract query:
                vector: U3<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>, ResizeArray<float>> *
                ?options: VectorizeQueryOptions ->
                    Promise<VectorizeMatches>

            abstract describe: unit -> Promise<VectorizeIndexInfo>

        [<Import("@cloudflare/workers-types", "ConversionOptions")>]
        type ConversionOptions =
            abstract pdf: option<ToMarkdownService._Lit17> with get, set
            abstract image: option<ImageConversionOptions> with get, set
            abstract docx: option<ToMarkdownService._Lit15> with get, set
            abstract html: option<ToMarkdownService._Lit9> with get, set

        [<Import("@cloudflare/workers-types", "BaseAiTextToImage"); AbstractClass; AllowNullLiteral>]
        type BaseAiTextToImage private () =
            abstract postProcessedOutputs: AiTextToImageOutput with get, set
            abstract inputs: AiTextToImageInput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Unum_Uform_Gen2_Qwen_500M_Output")>]
        type AiCfUnumUformGen2Qwen500MOutput =
            abstract description: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Prompt")>]
        type AiCfMetaLlama3211BVisionInstructPrompt =
            abstract lora: option<D1SessionBookmark> with get, set

            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set
            abstract image: option<U2<ResizeArray<float>, Ai._Lit96>> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwq_32B_Prompt")>]
        type AiCfQwenQwq32BPrompt =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("guided_json")>]
            abstract guidedJson: option<obj> with get, set

            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "StreamUrlUploadParams")>]
        type StreamUrlUploadParams =
            abstract watermarkId: option<D1SessionBookmark> with get, set
            abstract thumbnailTimestampPct: option<float> with get, set
            abstract scheduledDeletion: option<string> with get, set
            abstract requireSignedURLs: option<bool> with get, set
            abstract meta: option<WebAssembly.ModuleImports> with get, set
            abstract creator: option<D1SessionBookmark> with get, set
            abstract allowedOrigins: option<ResizeArray<D1SessionBookmark>> with get, set

        [<Import("@cloudflare/workers-types", "ImageListOptions")>]
        type ImageListOptions =
            abstract creator: option<D1SessionBookmark> with get, set
            abstract sortOrder: option<ImagesBinding._Lit8> with get, set
            abstract cursor: option<D1SessionBookmark> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "ScriptVersion")>]
        type ScriptVersion =
            abstract message: option<D1SessionBookmark> with get, set
            abstract tag: option<D1SessionBookmark> with get, set
            abstract id: option<D1SessionBookmark> with get, set

        type Btoa =
            abstract Invoke: data: D1SessionBookmark -> D1SessionBookmark
            abstract Invoke: data: D1SessionBookmark -> D1SessionBookmark

        [<Import("@cloudflare/workers-types", "GatewayRetries")>]
        type GatewayRetries =
            abstract backoff: option<CloudflareWorkersModule.WorkflowBackoff> with get, set
            abstract retryDelayMs: option<float> with get, set
            abstract maxAttempts: option<ToMarkdownService._Lit6> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchCreateJobParams")>]
        type AiSearchCreateJobParams =
            abstract description: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ExportedHandlerScheduledHandler")>]
        type ExportedHandlerScheduledHandler<'Props, 'Env> =
            abstract Invoke:
                controller: ScheduledController * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfAisingaporeGemmaSeaLionV427BIt private () =
            abstract postProcessedOutputs: AiCfAisingaporeGemmaSeaLionV427BItOutput with get, set
            abstract inputs: AiCfAisingaporeGemmaSeaLionV427BItInput with get, set

        [<Import("@cloudflare/workers-types", "RequestInitCfPropertiesImageDraw")>]
        type RequestInitCfPropertiesImageDraw =
            inherit BasicImageTransformations
            abstract right: option<float> with get, set
            abstract bottom: option<float> with get, set
            abstract left: option<float> with get, set
            abstract top: option<float> with get, set
            abstract repeat: option<Typescript.CSSViewTransitionRule._Lit3558> with get, set
            abstract opacity: option<float> with get, set
            abstract url: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiSearchMultiSearchResponse")>]
        type AiSearchMultiSearchResponse =
            abstract errors: option<ResizeArray<AiSearchMultiSearchError>> with get, set
            abstract chunks: ResizeArray<AiSearchMultiSearchChunk> with get, set

            [<EmitProperty("search_query")>]
            abstract searchQuery: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Input_Embedding_1")>]
        type AiCfBaaiBgeM3InputEmbedding1 =
            [<EmitProperty("truncate_inputs")>]
            abstract truncateInputs: option<bool> with get, set

            abstract text: U2<ResizeArray<D1SessionBookmark>, string> with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectStub")>]
        type DurableObjectStub<'T when 'T :> Rpc.DurableObjectBranded> =
            abstract name: option<D1SessionBookmark> with get
            abstract id: DurableObjectId with get
            abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket
            abstract fetch: input: U3<Request, URL, string> * ?init: RequestInit -> Promise<Global.Response>
            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, Promise<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, Promise<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, Promise<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke:
                [<ParamArray>] args: DurableObjectStub.Invoke.Args ->
                    U2<Typescript.CSSViewTransitionRule._Lit31, U2<Typescript.CSSViewTransitionRule._Lit3576, unit>>

        [<Import("@cloudflare/workers-types", "AiSearchListJobsResponse")>]
        type AiSearchListJobsResponse =
            [<EmitProperty("result_info")>]
            abstract resultInfo: option<Ai._Lit49> with get, set

            abstract result: ResizeArray<AiSearchJobInfo> with get, set

        [<Import("@cloudflare/workers-types", "SubtleCryptoSignAlgorithm")>]
        type SubtleCryptoSignAlgorithm =
            abstract saltLength: option<float> with get, set
            abstract dataLength: option<float> with get, set
            abstract hash: option<U2<SubtleCryptoHashAlgorithm, string>> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AutoRAG"); AbstractClass; AllowNullLiteral>]
        type AutoRAG private () =
            abstract aiSearch: params: AutoRagAiSearchRequest -> Promise<U2<Global.Response, AutoRAG._Lit22>>
            abstract aiSearch: params: AutoRagAiSearchRequest -> Promise<AutoRagAiSearchResponse>
            abstract aiSearch: params: AutoRagAiSearchRequestStreaming -> Promise<Global.Response>
            abstract search: params: AutoRagSearchRequest -> Promise<AutoRagSearchResponse>
            abstract list: unit -> Promise<AutoRagListResponse>

        [<Import("@cloudflare/workers-types", "StreamDownloadGetResponse")>]
        type StreamDownloadGetResponse =
            [<EmitProperty("default")>]
            abstract ``default``: option<StreamDownload> with get, set

            abstract audio: option<StreamDownload> with get, set

        [<Import("@cloudflare/workers-types", "ArtifactsCreateRepoResult")>]
        type ArtifactsCreateRepoResult =
            abstract tokenExpiresAt: D1SessionBookmark with get, set
            abstract token: D1SessionBookmark with get, set
            abstract remote: D1SessionBookmark with get, set
            abstract defaultBranch: D1SessionBookmark with get, set
            abstract description: option<string> with get, set
            abstract name: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfMetaLlama4Scout17B16EInstruct private () =
            abstract postProcessedOutputs: AiCfMetaLlama4Scout17B16EInstructOutput with get, set
            abstract inputs: AiCfMetaLlama4Scout17B16EInstructInput with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionToolChoiceAllowedTools = | [<CompiledName("allowed_tools")>] AllowedTools

        [<Import("@cloudflare/workers-types", "AiSearchInstance"); AbstractClass; AllowNullLiteral>]
        type AiSearchInstance private () =
            abstract jobs: AiSearchJobs with get
            abstract items: AiSearchItems with get
            abstract stats: unit -> Promise<AiSearchStatsResponse>
            abstract info: unit -> Promise<AiSearchInstanceInfo>
            abstract update: config: AiSearchInstance.Update.Config -> Promise<AiSearchInstanceInfo>
            abstract chatCompletions: params: AiSearchChatCompletionsRequest -> Promise<AiSearchChatCompletionsResponse>
            abstract chatCompletions: params: Ai._Lit21 -> Promise<AiTextToImageOutput>
            abstract search: params: AiSearchSearchRequest -> Promise<AiSearchSearchResponse>

        [<Import("@cloudflare/workers-types", "Logprob")>]
        type Logprob =
            [<EmitProperty("top_logprobs")>]
            abstract topLogprobs: option<ResizeArray<TopLogprob>> with get, set

            abstract logprob: float with get, set
            abstract token: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Openai_Gpt_Oss_20B"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfOpenaiGptOss20B private () =
            abstract postProcessedOutputs:
                U2<BaseAiCfOpenaiGptOss20B.PostProcessedOutputs, BaseAiCfOpenaiGptOss20B.PostProcessedOutputs> with get, set

            abstract inputs:
                U4<
                    BaseAiCfOpenaiGptOss20B.Inputs,
                    BaseAiCfOpenaiGptOss20B.Inputs,
                    BaseAiCfOpenaiGptOss20B.Inputs,
                    BaseAiCfOpenaiGptOss20B.Inputs
                 > with get, set

        type IncomingRequestCfPropertiesEdgeRequestKeepAliveStatus =
            | ``0`` = 0
            | ``1`` = 1
            | ``2`` = 2
            | ``3`` = 3
            | ``4`` = 4
            | ``5`` = 5

        [<Import("@cloudflare/workers-types", "ChatCompletionLogprobs")>]
        type ChatCompletionLogprobs =
            abstract refusal: option<ResizeArray<ChatCompletionTokenLogprob>> with get, set
            abstract content: option<ResizeArray<ChatCompletionTokenLogprob>> with get, set

        [<Import("@cloudflare/workers-types", "UniversalGatewayOptions")>]
        type UniversalGatewayOptions =
            /// <deprecated />
            abstract id: option<D1SessionBookmark> with get, set
            abstract retries: option<GatewayRetries> with get, set
            abstract requestTimeoutMs: option<float> with get, set
            abstract eventId: option<D1SessionBookmark> with get, set
            abstract collectLog: option<bool> with get, set
            abstract metadata: option<WebAssembly.ModuleImports> with get, set
            abstract skipCache: option<bool> with get, set
            abstract cacheTtl: option<float> with get, set
            abstract cacheKey: option<D1SessionBookmark> with get, set
            abstract id: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type DurableObjectJurisdiction =
            | [<CompiledName("eu")>] Eu
            | [<CompiledName("fedramp")>] Fedramp
            | [<CompiledName("fedramp-high")>] FedrampHigh

        [<Import("@cloudflare/workers-types", "StreamBinding")>]
        type StreamBinding =
            abstract watermarks: StreamWatermarks with get, set
            abstract videos: StreamVideos with get, set
            abstract createDirectUpload: params: StreamDirectUploadCreateParams -> Promise<StreamDirectUpload>
            abstract upload: url: D1SessionBookmark * ?params: StreamUrlUploadParams -> Promise<StreamVideo>
            abstract video: id: D1SessionBookmark -> StreamVideoHandle

        [<Import("@cloudflare/workers-types", "ResponseInputImageContent")>]
        type ResponseInputImageContent =
            [<EmitProperty("image_url")>]
            abstract imageUrl: option<string> with get, set

            abstract detail: option<ResponseFunctionCallOutputItemList._Lit4> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ResponseInputImageContent.Type with get, set

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

        [<Import("@cloudflare/workers-types", "Ai_Cf_Deepgram_Flux_Output")>]
        type AiCfDeepgramFluxOutput =
            [<EmitProperty("end_of_turn_confidence")>]
            abstract endOfTurnConfidence: option<float> with get, set

            abstract words: option<ResizeArray<AiModels._Lit302>> with get, set
            abstract transcript: option<D1SessionBookmark> with get, set

            [<EmitProperty("audio_window_end")>]
            abstract audioWindowEnd: option<float> with get, set

            [<EmitProperty("audio_window_start")>]
            abstract audioWindowStart: option<float> with get, set

            [<EmitProperty("turn_index")>]
            abstract turnIndex: option<float> with get, set

            abstract event: option<AiModels._Lit301> with get, set

            [<EmitProperty("sequence_id")>]
            abstract sequenceId: option<float> with get, set

            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Openai_Whisper_Output")>]
        type AiCfOpenaiWhisperOutput =
            abstract vtt: option<D1SessionBookmark> with get, set
            abstract words: option<ResizeArray<AiModels._Lit42>> with get, set

            [<EmitProperty("word_count")>]
            abstract wordCount: option<float> with get, set

            abstract text: D1SessionBookmark with get, set

        type LoopbackForExport =
            abstract Invoke: opts: LoopbackForExport._Lit11 -> Typescript.CSSViewTransitionRule._Lit3543
            abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket
            abstract fetch: input: U3<Request, URL, string> * ?init: RequestInit -> Promise<Global.Response>
            abstract Invoke: opts: LoopbackForExport._Lit11 -> DurableObjectClass<'T>
            abstract Invoke: opts: LoopbackForExport._Lit9 -> DurableObjectClass<'T>
            abstract Invoke: opts: LoopbackForExport._Lit11 -> LoopbackForExport.Invoke
            abstract Invoke: opts: LoopbackForExport._Lit9 -> LoopbackForExport.Invoke
            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, Promise<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, Promise<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, Promise<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke:
                [<ParamArray>] args: LoopbackForExport.Invoke.Args ->
                    U2<Typescript.CSSViewTransitionRule._Lit31, U2<Typescript.CSSViewTransitionRule._Lit3576, unit>>

        [<Import("@cloudflare/workers-types", "ChatCompletionAudio")>]
        type ChatCompletionAudio =
            abstract transcript: D1SessionBookmark with get, set

            [<EmitProperty("expires_at")>]
            abstract expiresAt: float with get, set

            abstract data: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ReadableStream")>]
        type ReadableStream<'R> =
            abstract locked: bool with get

            abstract symbolAsyncIterator:
                ?options: ReadableStreamValuesOptions ->
                    System.Collections.Generic.IAsyncEnumerator<'R, option<obj>, option<obj>>

            abstract values:
                ?options: ReadableStreamValuesOptions ->
                    System.Collections.Generic.IAsyncEnumerator<'R, option<obj>, option<obj>>

            abstract tee: unit -> ReadableStream<'R> * ReadableStream<'R>
            abstract pipeTo: destination: WritableStream<'R> * ?options: Global.StreamPipeOptions -> Promise<unit>

            abstract pipeThrough:
                transform: ReadableWritablePair<'T, 'R> * ?options: Global.StreamPipeOptions -> ReadableStream<'T>

            abstract getReader: options: Global.ReadableStreamGetReaderOptions -> ReadableStreamBYOBReader
            abstract getReader: unit -> ReadableStreamDefaultReader<'R>
            abstract cancel: ?reason: obj -> Promise<unit>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Pfnet_Plamo_Embedding_1B_Input")>]
        type AiCfPfnetPlamoEmbedding1BInput =
            abstract text: U2<ResizeArray<D1SessionBookmark>, string> with get, set

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
            abstract country: option<Typescript.CSSViewTransitionRule._Lit3568> with get, set

        [<Import("@cloudflare/workers-types", "R2PutOptions")>]
        type R2PutOptions =
            abstract ssecKey: option<U2<ArrayBuffer, string>> with get, set
            abstract storageClass: option<D1SessionBookmark> with get, set
            abstract sha512: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, string>> with get, set
            abstract sha384: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, string>> with get, set
            abstract sha256: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, string>> with get, set
            abstract sha1: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, string>> with get, set
            abstract md5: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, string>> with get, set
            abstract customMetadata: option<WebAssembly.ModuleImports> with get, set
            abstract httpMetadata: option<U2<R2HTTPMetadata, Headers>> with get, set
            abstract onlyIf: option<U2<R2Conditional, Headers>> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type StreamDownloadType =
            | [<CompiledName("default")>] Default
            | [<CompiledName("audio")>] Audio

        [<Import("@cloudflare/workers-types", "WebSearchUserLocation")>]
        type WebSearchUserLocation =
            abstract approximate: AiModels._Lit202 with get, set

            [<EmitProperty("type")>]
            abstract ``type``: WebSearchUserLocation.Type with get, set

        [<Import("@cloudflare/workers-types", "RateLimit")>]
        type RateLimit =
            abstract limit: options: RateLimitOptions -> Promise<RateLimitOutcome>

        [<Import("@cloudflare/workers-types", "AiTextGenerationResponseFormat")>]
        type AiTextGenerationResponseFormat =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "SqlStorage")>]
        type SqlStorage =
            [<EmitProperty("Statement")>]
            abstract statement: LoopbackForExport._Lit22 with get, set

            [<EmitProperty("Cursor")>]
            abstract cursor: LoopbackForExport._Lit18 with get, set

            abstract databaseSize: float with get

            abstract exec:
                query: D1SessionBookmark * [<ParamArray>] bindings: ResizeArray<option<obj>> -> SqlStorageCursor<'T>

        [<Import("@cloudflare/workers-types", "ToMarkdownService"); AbstractClass; AllowNullLiteral>]
        type ToMarkdownService private () =
            abstract supported: unit -> Promise<ResizeArray<SupportedFileFormat>>

            abstract transform:
                files: MarkdownDocument * ?options: ConversionRequestOptions -> Promise<ConversionResponse>

            abstract transform:
                files: ResizeArray<MarkdownDocument> * ?options: ConversionRequestOptions ->
                    Promise<ResizeArray<ConversionResponse>>

        [<Import("@cloudflare/workers-types", "Event"); AbstractClass; AllowNullLiteral>]
        type Event private () =
            [<EmitConstructor>]
            abstract Create: ``type``: D1SessionBookmark * ?init: EventInit -> Event

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

            [<EmitProperty("type")>]
            abstract ``type``: D1SessionBookmark with get

            abstract composedPath: unit -> ResizeArray<EventTarget>
            abstract stopPropagation: unit -> unit
            abstract preventDefault: unit -> unit
            abstract stopImmediatePropagation: unit -> unit

        [<Import("@cloudflare/workers-types", "CryptoKeyArbitraryKeyAlgorithm")>]
        type CryptoKeyArbitraryKeyAlgorithm =
            abstract length: option<float> with get, set
            abstract namedCurve: option<D1SessionBookmark> with get, set
            abstract hash: option<CryptoKeyKeyAlgorithm> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Async_Batch")>]
        type AiCfQwenQwen330BA3BFp8AsyncBatch =
            abstract requests: ResizeArray<U2<AiCfQwenQwen330BA3BFp8Prompt1, AiCfQwenQwen330BA3BFp8Messages1>> with get, set

        [<Import("@cloudflare/workers-types", "EventSource"); AbstractClass; AllowNullLiteral>]
        type EventSource private () =
            inherit EventTarget()

            [<EmitConstructor>]
            abstract Create: url: D1SessionBookmark * ?init: EventSourceEventSourceInit -> EventSource

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
            abstract from: stream: AiTextToImageOutput -> EventSource
            abstract close: unit -> unit

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ImageTransform =
            | [<CompiledName("foreground")>] Foreground
            | [<CompiledName("border")>] Border

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Dev_Input")>]
        type AiCfBlackForestLabsFlux2DevInput =
            abstract multipart: AiModels._Lit57 with get, set

        [<Import("@cloudflare/workers-types", "TransformStreamDefaultController")>]
        type TransformStreamDefaultController<'O> =
            abstract desiredSize: option<float> with get
            abstract desiredSize: option<float> with get
            abstract terminate: unit -> unit
            abstract error: ?reason: obj -> unit
            abstract enqueue: ?chunk: 'O -> unit
            abstract terminate: unit -> unit
            abstract error: ?reason: obj -> unit
            abstract enqueue: ?chunk: 'O -> unit

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Text_Completion_Response")>]
        type AiCfAisingaporeGemmaSeaLionV427BItTextCompletionResponse =
            abstract usage: option<AiModels._Lit87> with get, set
            abstract choices: option<ResizeArray<AiModels._Lit115>> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract created: option<float> with get, set
            abstract object: option<AiCfAisingaporeGemmaSeaLionV427BItTextCompletionResponse.Object> with get, set
            abstract id: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "AlarmInvocationInfo")>]
        type AlarmInvocationInfo =
            abstract scheduledTime: float with get
            abstract retryCount: float with get
            abstract isRetry: bool with get

        [<Import("@cloudflare/workers-types", "SubtleCryptoDeriveKeyAlgorithm")>]
        type SubtleCryptoDeriveKeyAlgorithm =
            abstract info: option<BufferSource> with get, set

            [<EmitProperty("$public")>]
            abstract ``public``: option<CryptoKey> with get, set

            abstract hash: option<U2<SubtleCryptoHashAlgorithm, string>> with get, set
            abstract iterations: option<float> with get, set
            abstract salt: option<BufferSource> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "TextDecoderDecodeOptions")>]
        type TextDecoderDecodeOptions =
            abstract stream: bool with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionContentPartInputAudio")>]
        type ChatCompletionContentPartInputAudio =
            [<EmitProperty("input_audio")>]
            abstract inputAudio: ChatCompletionContentPartInputAudio._Lit2 with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ChatCompletionContentPartInputAudio.Type with get, set

        [<Import("@cloudflare/workers-types", "UserMessageContentPart")>]
        type UserMessageContentPart =
            abstract file: option<AiModels._Lit219> with get, set

            [<EmitProperty("input_audio")>]
            abstract inputAudio: option<AiModels._Lit217> with get, set

            [<EmitProperty("image_url")>]
            abstract imageUrl: option<AiModels._Lit215> with get, set

            abstract text: option<D1SessionBookmark> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: AiModels._Lit214 with get, set

        [<Import("@cloudflare/workers-types", "EmailSendResult")>]
        type EmailSendResult =
            abstract messageId: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiSearchListItemsParams")>]
        type AiSearchListItemsParams =
            [<EmitProperty("metadata_filter")>]
            abstract metadataFilter: option<D1SessionBookmark> with get, set

            abstract source: option<D1SessionBookmark> with get, set
            abstract status: option<Ai._Lit44> with get, set

            [<EmitProperty("sort_by")>]
            abstract sortBy: option<Ai._Lit43> with get, set

            abstract search: option<D1SessionBookmark> with get, set

            [<EmitProperty("per_page")>]
            abstract perPage: option<float> with get, set

            abstract page: option<float> with get, set

        [<Import("@cloudflare/workers-types", "ImageUploadOptions")>]
        type ImageUploadOptions =
            abstract encoding: option<ImageUploadOptions.Encoding> with get, set
            abstract creator: option<D1SessionBookmark> with get, set
            abstract metadata: option<WebAssembly.ModuleImports> with get, set
            abstract requireSignedURLs: option<bool> with get, set
            abstract filename: option<D1SessionBookmark> with get, set
            abstract id: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "CustomEventCustomEventInit")>]
        type CustomEventCustomEventInit =
            abstract detail: option<obj> with get, set
            abstract composed: option<bool> with get, set
            abstract cancelable: option<bool> with get, set
            abstract bubbles: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "AbortController"); AbstractClass; AllowNullLiteral>]
        type AbortController private () =
            [<EmitConstructor>]
            abstract Create: unit -> AbortController

            abstract signal: AbortSignal with get
            abstract abort: ?reason: obj -> unit

        [<Import("@cloudflare/workers-types", "AiSearchListResponse")>]
        type AiSearchListResponse =
            [<EmitProperty("result_info")>]
            abstract resultInfo: option<Ai._Lit49> with get, set

            abstract result: ResizeArray<AiSearchInstanceInfo> with get, set

        [<Import("@cloudflare/workers-types", "R2Conditional")>]
        type R2Conditional =
            abstract secondsGranularity: option<bool> with get, set
            abstract uploadedAfter: option<Date> with get, set
            abstract uploadedBefore: option<Date> with get, set
            abstract etagDoesNotMatch: option<D1SessionBookmark> with get, set
            abstract etagMatches: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "VectorizeVectorMetadataFilter")>]
        type VectorizeVectorMetadataFilter =
            abstract Item:
                key: D1SessionBookmark ->
                    option<U5<VectorizeVectorMetadataFilter.Item, Vectorize._Lit7, Vectorize._Lit9, string, float>>

        type ChatCompletionsBase = ChatCompletionsBase
        type VectorizeVectorMetadataValue = U4<ResizeArray<D1SessionBookmark>, string, float, bool>

        [<Import("@cloudflare/workers-types", "TextEncoderStream"); AbstractClass; AllowNullLiteral>]
        type TextEncoderStream private () =
            inherit TransformStream<D1SessionBookmark, Uint8Array<ArrayBufferLike>>()

            [<EmitConstructor>]
            abstract Create: unit -> TextEncoderStream

            abstract encoding: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode")>]
        type AiCfMetaLlama3370BInstructFp8FastJSONMode =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiModels._Lit80> with get, set

        type Params<'P when 'P :> D1SessionBookmark> = Params

        [<Import("@cloudflare/workers-types", "AiSearchJobLog")>]
        type AiSearchJobLog =
            [<EmitProperty("created_at")>]
            abstract createdAt: float with get, set

            [<EmitProperty("message_type")>]
            abstract messageType: float with get, set

            abstract message: D1SessionBookmark with get, set
            abstract id: float with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AutoRagAiSearchResponse =
            | [<CompiledName("vector_store.search_results.page")>] VectorStoreSearchResultsPage

        [<Import("@cloudflare/workers-types", "BaseAiSummarization"); AbstractClass; AllowNullLiteral>]
        type BaseAiSummarization private () =
            abstract postProcessedOutputs: AiSummarizationOutput with get, set
            abstract inputs: AiSummarizationInput with get, set

        [<Import("@cloudflare/workers-types", "R2Error"); AbstractClass; AllowNullLiteral>]
        type R2Error private () =
            inherit exn()
            abstract stack: option<obj> with get
            abstract action: D1SessionBookmark with get
            abstract message: D1SessionBookmark with get
            abstract code: float with get
            abstract name: D1SessionBookmark with get

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type WorkflowDurationLabel =
            | [<CompiledName("second")>] Second
            | [<CompiledName("minute")>] Minute
            | [<CompiledName("hour")>] Hour
            | [<CompiledName("day")>] Day
            | [<CompiledName("week")>] Week
            | [<CompiledName("month")>] Month
            | [<CompiledName("year")>] Year

        type D1SessionBookmark = obj

        [<Import("@cloudflare/workers-types", "FunctionDefinition")>]
        type FunctionDefinition =
            abstract strict: option<bool> with get, set
            abstract parameters: option<WebAssembly.ModuleImports> with get, set
            abstract description: option<D1SessionBookmark> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "QueueRetryOptions")>]
        type QueueRetryOptions =
            abstract delaySeconds: option<float> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Openai_Gpt_Oss_120B"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfOpenaiGptOss120B private () =
            abstract postProcessedOutputs:
                U2<BaseAiCfOpenaiGptOss120B.PostProcessedOutputs, BaseAiCfOpenaiGptOss120B.PostProcessedOutputs> with get, set

            abstract inputs:
                U4<
                    BaseAiCfOpenaiGptOss120B.Inputs,
                    BaseAiCfOpenaiGptOss120B.Inputs,
                    BaseAiCfOpenaiGptOss120B.Inputs,
                    BaseAiCfOpenaiGptOss120B.Inputs
                 > with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Deepgram_Nova_3_Input")>]
        type AiCfDeepgramNova3Input =
            [<EmitProperty("utterance_end_ms")>]
            abstract utteranceEndMs: option<bool> with get, set

            [<EmitProperty("vad_events")>]
            abstract vadEvents: option<bool> with get, set

            abstract endpointing: option<D1SessionBookmark> with get, set

            [<EmitProperty("interim_results")>]
            abstract interimResults: option<bool> with get, set

            abstract channels: option<float> with get, set

            [<EmitProperty("utt_split")>]
            abstract uttSplit: option<float> with get, set

            abstract utterances: option<bool> with get, set
            abstract topics: option<bool> with get, set

            [<EmitProperty("smart_format")>]
            abstract smartFormat: option<bool> with get, set

            abstract sentiment: option<bool> with get, set
            abstract search: option<D1SessionBookmark> with get, set
            abstract replace: option<D1SessionBookmark> with get, set
            abstract redact: option<D1SessionBookmark> with get, set
            abstract punctuate: option<bool> with get, set

            [<EmitProperty("profanity_filter")>]
            abstract profanityFilter: option<bool> with get, set

            abstract paragraphs: option<bool> with get, set
            abstract numerals: option<bool> with get, set
            abstract multichannel: option<bool> with get, set
            abstract mode: option<AiModels._Lit119> with get, set

            [<EmitProperty("mip_opt_out")>]
            abstract mipOptOut: option<bool> with get, set

            abstract measurements: option<bool> with get, set
            abstract language: option<D1SessionBookmark> with get, set
            abstract keywords: option<D1SessionBookmark> with get, set
            abstract keyterm: option<D1SessionBookmark> with get, set

            [<EmitProperty("filler_words")>]
            abstract fillerWords: option<bool> with get, set

            abstract extra: option<D1SessionBookmark> with get, set
            abstract encoding: option<AiModels._Lit118> with get, set
            abstract dictation: option<bool> with get, set
            abstract diarize: option<bool> with get, set

            [<EmitProperty("detect_language")>]
            abstract detectLanguage: option<bool> with get, set

            [<EmitProperty("detect_entities")>]
            abstract detectEntities: option<bool> with get, set

            [<EmitProperty("custom_intent")>]
            abstract customIntent: option<D1SessionBookmark> with get, set

            [<EmitProperty("custom_intent_mode")>]
            abstract customIntentMode: option<AiModels._Lit117> with get, set

            [<EmitProperty("custom_topic")>]
            abstract customTopic: option<D1SessionBookmark> with get, set

            [<EmitProperty("custom_topic_mode")>]
            abstract customTopicMode: option<AiModels._Lit117> with get, set

            abstract audio: AiModels._Lit116 with get, set

        [<Import("@cloudflare/workers-types", "WritableStreamDefaultWriter"); AbstractClass; AllowNullLiteral>]
        type WritableStreamDefaultWriter<'W> private () =
            [<EmitConstructor>]
            abstract Create: stream: WritableStream<option<obj>> -> WritableStreamDefaultWriter

            abstract desiredSize: option<float> with get
            abstract ready: Promise<unit> with get
            abstract closed: Promise<unit> with get
            abstract releaseLock: unit -> unit
            abstract write: ?chunk: 'W -> Promise<unit>
            abstract close: unit -> Promise<unit>
            abstract abort: ?reason: obj -> Promise<unit>

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

        type VectorizeIndexConfig = obj

        [<Import("@cloudflare/workers-types", "ChatCompletionsMessagesInput")>]
        type ChatCompletionsMessagesInput =
            abstract functions: option<ResizeArray<FunctionDefinition>> with get, set

            [<EmitProperty("function_call")>]
            abstract functionCall: option<U2<ChatCompletionsMessagesInput.FunctionCall, AiModels._Lit184>> with get, set

            [<EmitProperty("web_search_options")>]
            abstract webSearchOptions: option<WebSearchOptions> with get, set

            abstract user: option<D1SessionBookmark> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract tools: option<ResizeArray<ChatCompletionTool>> with get, set

            [<EmitProperty("tool_choice")>]
            abstract toolChoice: option<ChatCompletionToolChoiceOption> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("stream_options")>]
            abstract streamOptions: option<ChatCompletionsStreamOptions> with get, set

            abstract stream: option<bool> with get, set
            abstract store: option<bool> with get, set
            abstract stop: option<U2<ResizeArray<D1SessionBookmark>, string>> with get, set

            [<EmitProperty("service_tier")>]
            abstract serviceTier: option<AiModels._Lit147> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<ResponseFormat> with get, set

            [<EmitProperty("chat_template_kwargs")>]
            abstract chatTemplateKwargs: option<ChatTemplateKwargs> with get, set

            [<EmitProperty("reasoning_effort")>]
            abstract reasoningEffort: option<AiModels._Lit156> with get, set

            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            abstract prediction: option<PredictionContent> with get, set

            [<EmitProperty("parallel_tool_calls")>]
            abstract parallelToolCalls: option<bool> with get, set

            abstract n: option<float> with get, set
            abstract modalities: option<ResizeArray<ChatCompletionsMessagesInput.Modalities>> with get, set
            abstract metadata: option<Typescript.CSSViewTransitionRule._Lit44> with get, set

            [<EmitProperty("max_completion_tokens")>]
            abstract maxCompletionTokens: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            [<EmitProperty("top_logprobs")>]
            abstract topLogprobs: option<float> with get, set

            abstract logprobs: option<bool> with get, set

            [<EmitProperty("logit_bias")>]
            abstract logitBias: option<Typescript.CSSViewTransitionRule._Lit44> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            abstract audio: option<AudioParams> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract messages: ResizeArray<ChatCompletionMessageParam> with get, set

        [<Import("@cloudflare/workers-types", "TraceItemFetchEventInfoResponse")>]
        type TraceItemFetchEventInfoResponse =
            abstract status: float with get

        [<Import("@cloudflare/workers-types", "InvalidURLError")>]
        type InvalidURLError =
            inherit StreamError
            abstract name: InvalidURLError.Name with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Qwen_Qwq_32B"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfQwenQwq32B private () =
            abstract postProcessedOutputs: AiCfQwenQwq32BOutput with get, set
            abstract inputs: AiCfQwenQwq32BInput with get, set

        [<Import("@cloudflare/workers-types", "ArtifactsRepoInfo")>]
        type ArtifactsRepoInfo =
            abstract remote: D1SessionBookmark with get, set
            abstract readOnly: bool with get, set
            abstract source: option<string> with get, set
            abstract lastPushAt: option<string> with get, set
            abstract updatedAt: D1SessionBookmark with get, set
            abstract createdAt: D1SessionBookmark with get, set
            abstract defaultBranch: D1SessionBookmark with get, set
            abstract description: option<string> with get, set
            abstract name: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Pipecat_Ai_Smart_Turn_V2_Output")>]
        type AiCfPipecatAiSmartTurnV2Output =
            abstract probability: option<float> with get, set

            [<EmitProperty("is_complete")>]
            abstract isComplete: option<bool> with get, set

        type AiCfMetaLlama4Scout17B16EInstructInput = obj

        [<Import("@cloudflare/workers-types", "AiTextGenerationToolOutput")>]
        type AiTextGenerationToolOutput =
            [<EmitProperty("function")>]
            abstract ``function``: AiModels._Lit28 with get, set

            [<EmitProperty("type")>]
            abstract ``type``: AiTextGenerationToolOutput.Type with get, set

            abstract id: D1SessionBookmark with get, set

        type AiCfBaaiBgeLargeEnV15Output = obj

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1")>]
        type AiCfQwenQwen330BA3BFp8Messages1 =
            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            [<EmitProperty("repetition_penalty")>]
            abstract repetitionPenalty: option<float> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract stream: option<bool> with get, set
            abstract raw: option<bool> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfQwenQwen330BA3BFp8JSONMode3> with get, set

            abstract tools: option<ResizeArray<U2<AiModels._Lit72, AiModels._Lit76>>> with get, set
            abstract functions: option<ResizeArray<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: ResizeArray<AiModels._Lit81> with get, set

        [<Import("@cloudflare/workers-types", "TraceItemAlarmEventInfo")>]
        type TraceItemAlarmEventInfo =
            abstract scheduledTime: Date with get

        [<Import("@cloudflare/workers-types", "EmailAddress")>]
        type EmailAddress =
            abstract email: D1SessionBookmark with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode")>]
        type AiCfQwenQwen330BA3BFp8JSONMode =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiModels._Lit80> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_Embedding_0_6B_Output")>]
        type AiCfQwenQwen3Embedding06BOutput =
            abstract shape: option<AiSentenceSimilarityOutput> with get, set
            abstract data: option<ResizeArray<AiSentenceSimilarityOutput>> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_M2M100_1_2B_AsyncResponse")>]
        type AiCfMetaM2M10012BAsyncResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_2")>]
        type AiCfAisingaporeGemmaSeaLionV427BItJSONMode2 =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiModels._Lit80> with get, set

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

        type IWorkersTypes =
            [<CompiledName("RpcStub")>]
            member rpcStub: RpcStub._Lit1 = JS.undefined

            [<Import("@cloudflare/workers-types", "removeEventListener")>]
            static member removeEventListener
                (``type``: 'Type, handler: Body, ?options: U2<EventTargetEventListenerOptions, bool>)
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

            [<Import("@cloudflare/workers-types", "connect")>]
            static member connect(address: U2<SocketAddress, string>, ?options: SocketOptions) : Socket = JS.undefined

            [<Erase>]
            member __WORKER_ENTRYPOINT_BRAND: __WORKER_ENTRYPOINT_BRAND = JS.undefined

            [<Erase>]
            member tracing: Tracing = JS.undefined

            [<Erase>]
            member __RPC_TARGET_BRAND: __RPC_TARGET_BRAND = JS.undefined

            [<Import("@cloudflare/workers-types", "setTimeout")>]
            static member setTimeout
                (callback: ServiceWorkerGlobalScope._Lit3, ?msDelay: float, [<ParamArray>] args: 'Args)
                : float =
                JS.undefined

            [<Import("@cloudflare/workers-types", "setTimeout")>]
            static member setTimeout(callback: ServiceWorkerGlobalScope._Lit2, ?msDelay: float) : float = JS.undefined

            [<Import("@cloudflare/workers-types", "setTimeout")>]
            static member setTimeout
                (handler: TimerHandler, ?timeout: float, [<ParamArray>] arguments: ResizeArray<option<obj>>)
                : float =
                JS.undefined

            [<Import("@cloudflare/workers-types", "connect")>]
            static member _connect(address: U2<SocketAddress, string>, ?options: SocketOptions) : Socket = JS.undefined

            [<Erase>]
            member cache: CacheContext = JS.undefined

            [<Import("@cloudflare/workers-types", "reportError")>]
            static member reportError(error: option<obj>) : unit = JS.undefined

            [<Import("@cloudflare/workers-types", "reportError")>]
            static member reportError(e: option<obj>) : unit = JS.undefined

            [<Erase>]
            member __DURABLE_OBJECT_BRAND: __DURABLE_OBJECT_BRAND = JS.undefined

            [<Erase>]
            member onRequest: OnRequest -> U2<Global.Response, Promise<Global.Response>> =
                JS.undefined

            [<CompiledName("Cloudflare")>]
            member cloudflare: Cloudflare = JS.undefined

            [<CompiledName("_EmailMessage")>]
            member _emailMessage: EmailMessage._Lit1 = JS.undefined

            [<Erase>]
            member __RPC_STUB_BRAND: __RPC_STUB_BRAND = JS.undefined

            [<Import("@cloudflare/workers-types", "clearInterval")>]
            static member clearInterval(timeoutId: option<float>) : unit = JS.undefined

            [<Import("@cloudflare/workers-types", "clearInterval")>]
            static member clearInterval(id: option<float>) : unit = JS.undefined

            [<Import("@cloudflare/workers-types", "atob")>]
            static member atob(data: D1SessionBookmark) : D1SessionBookmark = JS.undefined

            [<Import("@cloudflare/workers-types", "atob")>]
            static member atob(data: D1SessionBookmark) : D1SessionBookmark = JS.undefined

            [<Erase>]
            member __WORKFLOW_ENTRYPOINT_BRAND: __WORKFLOW_ENTRYPOINT_BRAND = JS.undefined

            [<Import("@cloudflare/workers-types", "structuredClone")>]
            static member structuredClone(value: 'T, ?options: Global.StructuredSerializeOptions) : 'T = JS.undefined

            [<Import("@cloudflare/workers-types", "structuredClone")>]
            static member structuredClone(value: 'T, ?options: Global.StructuredSerializeOptions) : 'T = JS.undefined

            [<Import("@cloudflare/workers-types", "setInterval")>]
            static member setInterval
                (callback: ServiceWorkerGlobalScope._Lit3, ?msDelay: float, [<ParamArray>] args: 'Args)
                : float =
                JS.undefined

            [<Import("@cloudflare/workers-types", "setInterval")>]
            static member setInterval(callback: ServiceWorkerGlobalScope._Lit2, ?msDelay: float) : float = JS.undefined

            [<Import("@cloudflare/workers-types", "setInterval")>]
            static member setInterval
                (handler: TimerHandler, ?timeout: float, [<ParamArray>] arguments: ResizeArray<option<obj>>)
                : float =
                JS.undefined

            [<CompiledName("EmailMessage")>]
            member emailMessage: EmailMessage._Lit1 = JS.undefined

            [<Import("@cloudflare/workers-types", "clearTimeout")>]
            static member clearTimeout(timeoutId: option<float>) : unit = JS.undefined

            [<Import("@cloudflare/workers-types", "clearTimeout")>]
            static member clearTimeout(id: option<float>) : unit = JS.undefined

            [<Import("@cloudflare/workers-types", "queueMicrotask")>]
            static member queueMicrotask(task: Function) : unit = JS.undefined

            [<Import("@cloudflare/workers-types", "queueMicrotask")>]
            static member queueMicrotask(callback: VoidFunction) : unit = JS.undefined

            [<Import("@cloudflare/workers-types", "fetch")>]
            static member fetch(input: U3<Request, URL, string>, ?init: RequestInit) : Promise<Global.Response> =
                JS.undefined

            [<Import("@cloudflare/workers-types", "fetch")>]
            static member fetch(input: U3<Request, URL, string>, ?init: RequestInit) : Promise<Global.Response> =
                JS.undefined

            [<Import("@cloudflare/workers-types", "addEventListener")>]
            static member addEventListener
                (``type``: 'Type, handler: Body, ?options: U2<EventTargetAddEventListenerOptions, bool>)
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

            [<Import("@cloudflare/workers-types", "dispatchEvent")>]
            static member dispatchEvent
                (event: U4<PromiseRejectionEvent, QueueEvent<option<obj>>, ScheduledEvent, FetchEvent>)
                : bool =
                JS.undefined

            [<Import("@cloudflare/workers-types", "dispatchEvent")>]
            static member dispatchEvent(event: Event) : bool = JS.undefined

            [<Import("@cloudflare/workers-types", "btoa")>]
            static member btoa(data: D1SessionBookmark) : D1SessionBookmark = JS.undefined

            [<Import("@cloudflare/workers-types", "btoa")>]
            static member btoa(data: D1SessionBookmark) : D1SessionBookmark = JS.undefined

module rec Global =
    [<Import("", "ReadableStreamBYOBRequest")>]
    type ReadableStreamBYOBRequest =
        abstract atLeast: option<float> with get
        abstract view: option<Uint8Array<ArrayBufferLike>> with get
        abstract view: option<ArrayBufferView<ArrayBuffer>> with get
        abstract respondWithNewView: view: Cloudflare.WorkersTypes.BufferSource -> unit
        abstract respond: bytesWritten: float -> unit
        abstract respondWithNewView: view: ArrayBufferView<ArrayBuffer> -> unit
        abstract respond: bytesWritten: float -> unit

    [<Import("", "Console")>]
    type Console =
        abstract warn: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract trace: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract timeStamp: ?label: Cloudflare.WorkersTypes.D1SessionBookmark -> unit

        abstract timeLog:
            ?label: Cloudflare.WorkersTypes.D1SessionBookmark * [<ParamArray>] data: ResizeArray<option<obj>> -> unit

        abstract timeEnd: ?label: Cloudflare.WorkersTypes.D1SessionBookmark -> unit
        abstract time: ?label: Cloudflare.WorkersTypes.D1SessionBookmark -> unit
        abstract table: ?tabularData: obj * ?properties: ResizeArray<Cloudflare.WorkersTypes.D1SessionBookmark> -> unit
        abstract log: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract info: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract groupEnd: unit -> unit
        abstract groupCollapsed: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract group: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract error: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract dirxml: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract dir: ?item: obj * ?options: obj -> unit
        abstract debug: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract countReset: ?label: Cloudflare.WorkersTypes.D1SessionBookmark -> unit
        abstract count: ?label: Cloudflare.WorkersTypes.D1SessionBookmark -> unit
        abstract clear: unit -> unit
        abstract ``assert``: ?condition: bool * [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract warn: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract trace: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract timeStamp: ?label: Cloudflare.WorkersTypes.D1SessionBookmark -> unit

        abstract timeLog:
            ?label: Cloudflare.WorkersTypes.D1SessionBookmark * [<ParamArray>] data: ResizeArray<option<obj>> -> unit

        abstract timeEnd: ?label: Cloudflare.WorkersTypes.D1SessionBookmark -> unit
        abstract time: ?label: Cloudflare.WorkersTypes.D1SessionBookmark -> unit
        abstract table: ?tabularData: obj * ?properties: ResizeArray<Cloudflare.WorkersTypes.D1SessionBookmark> -> unit
        abstract log: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract info: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract groupEnd: unit -> unit
        abstract groupCollapsed: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract group: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract error: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract dirxml: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract dir: ?item: obj * ?options: obj -> unit
        abstract debug: [<ParamArray>] data: ResizeArray<option<obj>> -> unit
        abstract countReset: ?label: Cloudflare.WorkersTypes.D1SessionBookmark -> unit
        abstract count: ?label: Cloudflare.WorkersTypes.D1SessionBookmark -> unit
        abstract clear: unit -> unit
        abstract ``assert``: ?condition: bool * [<ParamArray>] data: ResizeArray<option<obj>> -> unit

    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
    type WebSocket =
        | [<CompiledValue(2)>] ``2``
        | [<CompiledValue(1)>] ``1``
        | [<CompiledValue(0)>] ``0``
        | [<CompiledValue(3)>] ``3``

    [<Import("", "ResponseInit")>]
    type ResponseInit =
        abstract encodeBody: option<Typescript.CSSViewTransitionRule._Lit3549> with get, set
        abstract webSocket: option<WebSocket> with get, set
        abstract cf: option<obj> with get, set
        abstract headers: option<HeadersInit> with get, set
        abstract statusText: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract status: option<float> with get, set
        abstract statusText: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract status: option<float> with get, set
        abstract headers: option<HeadersInit> with get, set

    [<Import("", "JsonWebKey")>]
    type JsonWebKey =
        abstract k: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract oth: option<ResizeArray<RsaOtherPrimesInfo>> with get, set
        abstract qi: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract dq: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract dp: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract q: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract p: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract e: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract n: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract d: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract y: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract x: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract crv: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract ext: option<bool> with get, set
        abstract alg: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set

        [<EmitProperty("key_ops")>]
        abstract keyOps: option<ResizeArray<Cloudflare.WorkersTypes.D1SessionBookmark>> with get, set

        [<EmitProperty("use")>]
        abstract ``use``: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set

        abstract kty: Cloudflare.WorkersTypes.D1SessionBookmark with get, set
        abstract y: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract x: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set

        [<EmitProperty("use")>]
        abstract ``use``: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set

        abstract qi: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract q: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract p: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract oth: option<ResizeArray<RsaOtherPrimesInfo>> with get, set
        abstract n: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract kty: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set

        [<EmitProperty("key_ops")>]
        abstract keyOps: option<ResizeArray<Cloudflare.WorkersTypes.D1SessionBookmark>> with get, set

        abstract k: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract ext: option<bool> with get, set
        abstract e: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract dq: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract dp: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract d: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract crv: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract alg: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set

    [<Import("", "CloseEventInit")>]
    type CloseEventInit =
        inherit Cloudflare.WorkersTypes.EventInit
        abstract wasClean: option<bool> with get, set
        abstract reason: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract code: option<float> with get, set
        abstract wasClean: option<bool> with get, set
        abstract reason: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract code: option<float> with get, set

    [<Import("", "CacheQueryOptions")>]
    type CacheQueryOptions =
        abstract ignoreMethod: option<bool> with get, set
        abstract ignoreVary: option<bool> with get, set
        abstract ignoreSearch: option<bool> with get, set
        abstract ignoreMethod: option<bool> with get, set

    [<Import("", "RsaOtherPrimesInfo")>]
    type RsaOtherPrimesInfo =
        abstract t: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract d: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract r: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract t: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract r: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set
        abstract d: option<Cloudflare.WorkersTypes.D1SessionBookmark> with get, set

    [<Import("", "Comment")>]
    type Comment =
        inherit CharacterData
        abstract removed: bool with get
        abstract text: Cloudflare.WorkersTypes.D1SessionBookmark with get, set
        abstract remove: unit -> Comment

        abstract replace:
            content: Cloudflare.WorkersTypes.D1SessionBookmark * ?options: Cloudflare.WorkersTypes.ContentOptions ->
                Comment

        abstract after:
            content: Cloudflare.WorkersTypes.D1SessionBookmark * ?options: Cloudflare.WorkersTypes.ContentOptions ->
                Comment

        abstract before:
            content: Cloudflare.WorkersTypes.D1SessionBookmark * ?options: Cloudflare.WorkersTypes.ContentOptions ->
                Comment

    [<Import("", "TextEncoderEncodeIntoResult")>]
    type TextEncoderEncodeIntoResult =
        abstract written: float with get, set
        abstract read: float with get, set
        abstract written: float with get, set
        abstract read: float with get, set

    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
    type MediaError =
        | [<CompiledValue(4)>] ``4``
        | [<CompiledValue(3)>] ``3``
        | [<CompiledValue(1)>] ``1``
        | [<CompiledValue(2)>] ``2``

    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
    type UnderlyingByteSource = | [<CompiledName("bytes")>] Bytes

    [<Import("", "QueuingStrategyInit")>]
    type QueuingStrategyInit =
        abstract highWaterMark: float with get, set
        abstract highWaterMark: float with get, set

    [<Import("", "Response")>]
    type Response =
        inherit Body

        [<EmitProperty("type")>]
        abstract ``type``: Typescript.CSSViewTransitionRule._Lit395 with get, set

        abstract cf: option<obj> with get
        abstract webSocket: option<WebSocket> with get
        abstract url: Cloudflare.WorkersTypes.D1SessionBookmark with get
        abstract redirected: bool with get
        abstract ok: bool with get
        abstract headers: Headers with get
        abstract statusText: Cloudflare.WorkersTypes.D1SessionBookmark with get
        abstract status: float with get
        abstract url: Cloudflare.WorkersTypes.D1SessionBookmark with get

        [<EmitProperty("type")>]
        abstract ``type``: ResponseType with get

        abstract statusText: Cloudflare.WorkersTypes.D1SessionBookmark with get
        abstract status: float with get
        abstract redirected: bool with get
        abstract ok: bool with get
        abstract headers: Headers with get
        abstract clone: unit -> Response
        abstract clone: unit -> Response

    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
    type ReadableStreamGetReaderOptions = | [<CompiledName("byob")>] Byob

    [<Import("", "StructuredSerializeOptions")>]
    type StructuredSerializeOptions =
        abstract transfer: option<ResizeArray<option<obj>>> with get, set
        abstract transfer: option<ResizeArray<Transferable>> with get, set

    [<Import("", "StreamPipeOptions")>]
    type StreamPipeOptions =
        abstract signal: option<AbortSignal> with get, set
        abstract preventClose: option<bool> with get, set
        abstract preventCancel: option<bool> with get, set
        abstract preventAbort: option<bool> with get, set
        abstract signal: option<AbortSignal> with get, set
        abstract preventClose: option<bool> with get, set
        abstract preventCancel: option<bool> with get, set
        abstract preventAbort: option<bool> with get, set

    [<Import("", "WritableStreamDefaultController")>]
    type WritableStreamDefaultController =
        abstract signal: AbortSignal with get
        abstract signal: AbortSignal with get
        abstract error: ?reason: obj -> unit
        abstract error: ?e: obj -> unit

module rec Typescript =
    module rec CSSViewTransitionRule =
        type _Lit44 =
            abstract Item: key: Cloudflare.WorkersTypes.D1SessionBookmark -> option<obj>

        type _Lit3565 =
            | ``0`` = 0
            | ``2`` = 2
            | ``3`` = 3
            | ``1`` = 1
            | ``4`` = 4
            | ``5`` = 5

        type _Lit3566 =
            abstract ja3Hash: Cloudflare.WorkersTypes.D1SessionBookmark with get, set
            abstract detectionIds: Cloudflare.WorkersTypes.AiSentenceSimilarityOutput with get, set
            abstract staticResource: bool with get, set
            abstract corporateProxy: bool with get, set
            abstract verifiedBot: bool with get, set
            /// <example>
            /// 54
            /// </example>
            abstract score: float with get, set

        type _Lit17 =
            abstract Invoke: value: 'T * index: float * array: ResizeArray -> bool

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type _Lit389 =
            | [<CompiledName("afterbegin")>] Afterbegin
            | [<CompiledName("afterend")>] Afterend
            | [<CompiledName("beforebegin")>] Beforebegin
            | [<CompiledName("beforeend")>] Beforeend

        type _Lit21 =
            abstract Invoke: previousValue: 'T * currentValue: 'T * currentIndex: float * array: ResizeArray -> 'T

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type _Lit3568 =
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

        type _Lit13 =
            abstract Invoke: [<ParamArray>] args: _Lit13.Invoke.Args -> U2<_Lit31, U2<_Lit3576, unit>>

        type _Lit26 =
            abstract Invoke:
                this: 'This * value: 'T * index: float * array: ResizeArray ->
                    U2<'U, System.Collections.Generic.IReadOnlyList<'U>>

        type _Lit25 =
            abstract Invoke: value: 'T * index: float * obj: ResizeArray -> option<obj>

        type _Lit3543 =
            abstract connect:
                address: U2<Cloudflare.WorkersTypes.SocketAddress, string> *
                ?options: Cloudflare.WorkersTypes.SocketOptions ->
                    Cloudflare.WorkersTypes.Socket

            abstract fetch:
                input: U3<Cloudflare.WorkersTypes.Request, URL, string> * ?init: Cloudflare.WorkersTypes.RequestInit ->
                    Promise<Global.Response>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type _Lit515 =
            | [<CompiledName("queued")>] Queued
            | [<CompiledName("running")>] Running
            | [<CompiledName("paused")>] Paused
            | [<CompiledName("errored")>] Errored
            | [<CompiledName("terminated")>] Terminated
            | [<CompiledName("complete")>] Complete
            | [<CompiledName("waiting")>] Waiting
            | [<CompiledName("waitingForPause")>] WaitingForPause
            | [<CompiledName("unknown")>] Unknown

        type _Lit23 =
            abstract Invoke: value: 'T * index: float * obj: ResizeArray -> bool

        type _Lit20 =
            abstract Invoke: value: 'T * index: float * array: ResizeArray -> 'U

        type _Lit19 =
            abstract Invoke: value: 'T * index: float * array: ResizeArray -> unit

        type _Lit18 =
            abstract Invoke: value: 'T * index: float * array: ResizeArray -> option<obj>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type _Lit3570 =
            | AF
            | AN
            | AS
            | EU
            | NA
            | OC
            | SA

        type _Lit10 =
            abstract Invoke: [<ParamArray>] args: ResizeArray<option<obj>> -> option<obj>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type _Lit3562 =
            | [<CompiledName("h")>] H
            | [<CompiledName("v")>] V
            | [<CompiledName("hv")>] Hv

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type _Lit3549 =
            | [<CompiledName("automatic")>] Automatic
            | [<CompiledName("manual")>] Manual

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type _Lit30 =
            | [<CompiledValue(false)>] False
            | [<CompiledValue(true)>] True

        type _Lit31 =
            abstract Item: key: Cloudflare.WorkersTypes.D1SessionBookmark -> option<obj>
            abstract Invoke: [<ParamArray>] args: _Lit31.Invoke.Args -> U2<_Lit31, U2<_Lit3576, unit>>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, Promise<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, Promise<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, Promise<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type _Lit3541 =
            | [<CompiledName("error")>] Error
            | [<CompiledName("follow")>] Follow
            | [<CompiledName("manual")>] Manual

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type _Lit2982 =
            | [<CompiledName("")>] Empty
            | [<CompiledName("no-referrer")>] NoReferrer
            | [<CompiledName("no-referrer-when-downgrade")>] NoReferrerWhenDowngrade
            | [<CompiledName("origin")>] Origin
            | [<CompiledName("origin-when-cross-origin")>] OriginWhenCrossOrigin
            | [<CompiledName("same-origin")>] SameOrigin
            | [<CompiledName("strict-origin")>] StrictOrigin
            | [<CompiledName("strict-origin-when-cross-origin")>] StrictOriginWhenCrossOrigin
            | [<CompiledName("unsafe-url")>] UnsafeUrl

        type _Lit29 =
            [<EmitProperty("__@unscopables@355")>]
            abstract _unscopables355: option<_Lit30> with get, set

            [<EmitProperty("__@iterator@353")>]
            abstract _iterator353: option<_Lit30> with get, set

            [<EmitProperty("with")>]
            abstract ``with``: option<_Lit30> with get, set

            abstract toSpliced: option<_Lit30> with get, set
            abstract toSorted: option<_Lit30> with get, set
            abstract toReversed: option<_Lit30> with get, set
            abstract findLastIndex: option<_Lit30> with get, set
            abstract findLast: option<_Lit30> with get, set
            abstract at: option<_Lit30> with get, set
            abstract flat: option<_Lit30> with get, set
            abstract flatMap: option<_Lit30> with get, set
            abstract includes: option<_Lit30> with get, set
            abstract values: option<_Lit30> with get, set
            abstract keys: option<_Lit30> with get, set
            abstract entries: option<_Lit30> with get, set
            abstract copyWithin: option<_Lit30> with get, set
            abstract fill: option<_Lit30> with get, set
            abstract findIndex: option<_Lit30> with get, set
            abstract find: option<_Lit30> with get, set
            abstract reduceRight: option<_Lit30> with get, set
            abstract reduce: option<_Lit30> with get, set
            abstract filter: option<_Lit30> with get, set
            abstract map: option<_Lit30> with get, set
            abstract forEach: option<_Lit30> with get, set
            abstract some: option<_Lit30> with get, set
            abstract every: option<_Lit30> with get, set
            abstract lastIndexOf: option<_Lit30> with get, set
            abstract indexOf: option<_Lit30> with get, set
            abstract unshift: option<_Lit30> with get, set
            abstract splice: option<_Lit30> with get, set
            abstract sort: option<_Lit30> with get, set
            abstract slice: option<_Lit30> with get, set
            abstract shift: option<_Lit30> with get, set
            abstract reverse: option<_Lit30> with get, set
            abstract join: option<_Lit30> with get, set
            abstract concat: option<_Lit30> with get, set
            abstract push: option<_Lit30> with get, set
            abstract pop: option<_Lit30> with get, set
            abstract toLocaleString: option<_Lit30> with get, set
            abstract toString: option<_Lit30> with get, set
            abstract length: option<_Lit30> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type _Lit3540 =
            | [<CompiledName("cors")>] Cors
            | [<CompiledName("same-origin")>] SameOrigin
            | [<CompiledName("navigate")>] Navigate
            | [<CompiledName("no-cors")>] NoCors

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type _Lit3538 =
            | [<CompiledName("same-origin")>] SameOrigin
            | [<CompiledName("include")>] Include
            | [<CompiledName("omit")>] Omit

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type _Lit3537 =
            | [<CompiledName("default")>] Default
            | [<CompiledName("force-cache")>] ForceCache
            | [<CompiledName("no-cache")>] NoCache
            | [<CompiledName("no-store")>] NoStore
            | [<CompiledName("only-if-cached")>] OnlyIfCached
            | [<CompiledName("reload")>] Reload

    module rec Global =
        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type _Lit2 =
            | [<CompiledName("f32")>] F32
            | [<CompiledName("anyfunc")>] Anyfunc
            | [<CompiledName("externref")>] Externref
            | [<CompiledName("f64")>] F64
            | [<CompiledName("i32")>] I32
            | [<CompiledName("i64")>] I64
            | [<CompiledName("v128")>] V128

    module rec Instance =
        type _Lit3 =
            abstract Item: key: Cloudflare.WorkersTypes.D1SessionBookmark -> option<obj>

    module rec Module =
        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type _Lit2 =
            | [<CompiledName("function")>] Function
            | [<CompiledName("table")>] Table
            | [<CompiledName("global")>] Global
            | [<CompiledName("memory")>] Memory

    module rec Table =
        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type _Lit2 =
            | [<CompiledName("anyfunc")>] Anyfunc
            | [<CompiledName("externref")>] Externref

module rec WebAssembly =
    [<Import("WebAssembly", "TableDescriptor")>]
    type TableDescriptor =
        abstract maximum: option<float> with get, set
        abstract initial: float with get, set
        abstract element: TableKind with get, set
        abstract maximum: option<float> with get, set
        abstract initial: float with get, set
        abstract element: TableKind with get, set

    [<Import("WebAssembly", "MemoryDescriptor")>]
    type MemoryDescriptor =
        abstract shared: option<bool> with get, set
        abstract maximum: option<float> with get, set
        abstract initial: float with get, set
        abstract shared: option<bool> with get, set
        abstract maximum: option<float> with get, set
        abstract initial: float with get, set

    [<Import("WebAssembly", "ModuleExportDescriptor")>]
    type ModuleExportDescriptor =
        abstract name: Cloudflare.WorkersTypes.D1SessionBookmark with get, set
        abstract kind: ImportExportKind with get, set
        abstract name: Cloudflare.WorkersTypes.D1SessionBookmark with get, set
        abstract kind: ImportExportKind with get, set

    [<Import("WebAssembly", "ModuleImportDescriptor")>]
    type ModuleImportDescriptor =
        abstract name: Cloudflare.WorkersTypes.D1SessionBookmark with get, set

        [<EmitProperty("module")>]
        abstract ``module``: Cloudflare.WorkersTypes.D1SessionBookmark with get, set

        abstract kind: ImportExportKind with get, set
        abstract name: Cloudflare.WorkersTypes.D1SessionBookmark with get, set

        [<EmitProperty("module")>]
        abstract ``module``: Cloudflare.WorkersTypes.D1SessionBookmark with get, set

        abstract kind: ImportExportKind with get, set
