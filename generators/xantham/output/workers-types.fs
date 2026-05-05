module rec Cloudflare =
    module rec WorkersTypes =
        module rec AIGatewayHeaders =
            module rec Run =
                module rec Data =
                    module rec Headers =
                        type CfAigCustomCost =
                            [<EmitProperty("total_cost")>]
                            abstract totalCost: option<float> with get, set

                            [<EmitProperty("per_token_out")>]
                            abstract perTokenOut: option<float> with get, set

                            [<EmitProperty("per_token_in")>]
                            abstract perTokenIn: option<float> with get, set

            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec Ai =
            module rec Models =
                module rec Models =
                    type Properties =
                        abstract value: D1SessionBookmark with get, set

                        [<EmitProperty("property_id")>]
                        abstract propertyId: D1SessionBookmark with get, set

                    type Task =
                        abstract description: D1SessionBookmark with get, set
                        abstract name: D1SessionBookmark with get, set
                        abstract id: D1SessionBookmark with get, set

                type Params =
                    abstract task: option<D1SessionBookmark> with get, set
                    abstract source: option<float> with get, set
                    abstract search: option<D1SessionBookmark> with get, set

                    [<EmitProperty("per_page")>]
                    abstract perPage: option<float> with get, set

                    abstract page: option<float> with get, set

                    [<EmitProperty("hide_experimental")>]
                    abstract hideExperimental: option<bool> with get, set

                    abstract author: option<D1SessionBookmark> with get, set

            module rec Run =
                type Inputs =
                    abstract requests: Array<proptypekey<proptypekey<'AiModelList, 'Name>, Inputs.Requests>> with get, set

                type Options =
                    abstract signal: option<AbortSignal> with get, set
                    abstract extraHeaders: option<obj> with get, set
                    abstract prefix: option<D1SessionBookmark> with get, set
                    abstract returnRawResponse: option<bool> with get, set
                    abstract gateway: option<GatewayOptions> with get, set
                    abstract tags: option<Array<D1SessionBookmark>> with get, set
                    abstract websocket: option<bool> with get, set
                    abstract queueRequest: option<bool> with get, set

            module rec Transform =
                module rec Options =
                    module rec Gateway =
                        module rec Transform =
                            module rec Options =
                                module rec Gateway =
                                    type Retries =
                                        | ``1`` = 1
                                        | ``2`` = 2
                                        | ``3`` = 3
                                        | ``4`` = 4
                                        | ``5`` = 5

                        type Params =
                            abstract Item: key: D1SessionBookmark -> option<obj>

                    module rec Transform =
                        module rec Options =
                            module rec ConversionOptions =
                                module rec Transform =
                                    module rec Options =
                                        module rec ConversionOptions =
                                            type Docx =
                                                abstract maxConvertedImages: option<float> with get, set
                                                abstract convert: option<bool> with get, set
                                                abstract descriptionLanguage: option<Docx.DescriptionLanguage> with get, set
                                                abstract images: option<EmbeddedImageConversionOptions> with get, set

                                            type Image =
                                                abstract descriptionLanguage: option<Image.DescriptionLanguage> with get, set

                                            type Pdf =
                                                abstract metadata: option<bool> with get, set
                                                abstract images: option<EmbeddedImageConversionOptions> with get, set

                                            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                            type Html =
                                                | [<CompiledName("en")>] En
                                                | [<CompiledName("es")>] Es
                                                | [<CompiledName("fr")>] Fr
                                                | [<CompiledName("it")>] It
                                                | [<CompiledName("pt")>] Pt
                                                | [<CompiledName("de")>] De

                            type ConversionOptions =
                                abstract pdf: option<ConversionOptions.Pdf> with get, set
                                abstract image: option<ImageConversionOptions> with get, set
                                abstract docx: option<ConversionOptions.Docx> with get, set
                                abstract html: option<ConversionOptions.Html> with get, set

                    type Gateway =
                        abstract retries: option<GatewayRetries> with get, set
                        abstract requestTimeoutMs: option<float> with get, set
                        abstract eventId: option<D1SessionBookmark> with get, set
                        abstract collectLog: option<bool> with get, set
                        abstract metadata: option<WebAssembly.ModuleImports> with get, set
                        abstract skipCache: option<bool> with get, set
                        abstract cacheTtl: option<float> with get, set
                        abstract cacheKey: option<D1SessionBookmark> with get, set
                        abstract id: D1SessionBookmark with get, set

                type Options =
                    abstract conversionOptions: option<ConversionOptions> with get, set
                    abstract extraHeaders: option<obj> with get, set
                    abstract gateway: option<GatewayOptions> with get, set

                type Files =
                    abstract blob: Blob with get, set
                    abstract name: D1SessionBookmark with get, set

            type AiModelList =
                abstract Item: key: D1SessionBookmark -> option<obj>

            type Run =
                [<EmitProperty("request_id")>]
                abstract requestId: D1SessionBookmark with get, set

            type Models =
                abstract properties: Array<Models.Properties> with get, set
                abstract tags: Array<D1SessionBookmark> with get, set
                abstract task: Models.Task with get, set
                abstract description: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set
                abstract source: float with get, set
                abstract id: D1SessionBookmark with get, set

        module rec AiCfAisingaporeGemmaSeaLionV427BItChatCompletionResponse =
            module rec Choices =
                module rec Choices =
                    module rec Message =
                        module rec Choices =
                            module rec Message =
                                module rec ToolCalls =
                                    module rec Messages =
                                        type FunctionCall =
                                            abstract arguments: D1SessionBookmark with get, set
                                            abstract name: D1SessionBookmark with get, set

                                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                type ToolCalls = | [<CompiledName("function")>] Function

                    type Message =
                        [<EmitProperty("tool_calls")>]
                        abstract toolCalls: option<Array<AiTextGenerationToolOutput>> with get, set

                        [<EmitProperty("reasoning_content")>]
                        abstract reasoningContent: option<D1SessionBookmark> with get, set

                        abstract content: D1SessionBookmark with get, set
                        abstract role: D1SessionBookmark with get, set

            module rec PostProcessedOutputs =
                type Usage =
                    [<EmitProperty("total_tokens")>]
                    abstract totalTokens: option<float> with get, set

                    [<EmitProperty("completion_tokens")>]
                    abstract completionTokens: option<float> with get, set

                    [<EmitProperty("prompt_tokens")>]
                    abstract promptTokens: option<float> with get, set

            type Choices =
                abstract logprobs: option<obj> with get, set

                [<EmitProperty("stop_reason")>]
                abstract stopReason: option<string> with get, set

                [<EmitProperty("finish_reason")>]
                abstract finishReason: option<D1SessionBookmark> with get, set

                abstract message: option<Choices.Message> with get, set
                abstract index: option<float> with get, set

        module rec AiCfAisingaporeGemmaSeaLionV427BItMessages =
            module rec Messages =
                module rec Messages =
                    type Content =
                        abstract text: option<D1SessionBookmark> with get, set

                        [<EmitProperty("type")>]
                        abstract ``type``: option<D1SessionBookmark> with get, set

            module rec Tools =
                module rec Tools =
                    module rec Parameters =
                        module rec Tools =
                            module rec Parameters =
                                module rec Properties =
                                    module rec Tools =
                                        module rec Parameters =
                                            module rec Properties =
                                                type Item =
                                                    abstract description: D1SessionBookmark with get, set

                                                    [<EmitProperty("type")>]
                                                    abstract ``type``: D1SessionBookmark with get, set

                                type Properties =
                                    abstract Item: k: D1SessionBookmark -> Properties.Item

                    type Parameters =
                        abstract properties: Parameters.Properties with get, set
                        abstract required: option<Array<D1SessionBookmark>> with get, set

                        [<EmitProperty("type")>]
                        abstract ``type``: D1SessionBookmark with get, set

            type Tools =
                [<EmitProperty("function")>]
                abstract ``function``: Tools.Function with get, set

                [<EmitProperty("type")>]
                abstract ``type``: D1SessionBookmark with get, set

                abstract parameters: Tools.Parameters with get, set
                abstract description: D1SessionBookmark with get, set
                abstract name: D1SessionBookmark with get, set

            type Messages =
                abstract content: U2<Array<Messages.Content>, string> with get, set
                abstract role: D1SessionBookmark with get, set

        module rec AiCfAisingaporeGemmaSeaLionV427BItTextCompletionResponse =
            module rec PostProcessedOutputs =
                type Usage =
                    [<EmitProperty("total_tokens")>]
                    abstract totalTokens: option<float> with get, set

                    [<EmitProperty("completion_tokens")>]
                    abstract completionTokens: option<float> with get, set

                    [<EmitProperty("prompt_tokens")>]
                    abstract promptTokens: option<float> with get, set

            type Choices =
                [<EmitProperty("prompt_logprobs")>]
                abstract promptLogprobs: option<obj> with get, set

                abstract logprobs: option<obj> with get, set

                [<EmitProperty("stop_reason")>]
                abstract stopReason: option<string> with get, set

                [<EmitProperty("finish_reason")>]
                abstract finishReason: D1SessionBookmark with get, set

                abstract text: D1SessionBookmark with get, set
                abstract index: float with get, set

        module rec AiCfBaaiBgeRerankerBaseInput =
            type Contexts =
                abstract text: option<D1SessionBookmark> with get, set

        module rec AiCfBaaiBgeRerankerBaseOutput =
            type Response =
                abstract score: option<float> with get, set
                abstract id: option<float> with get, set

        module rec AiCfBlackForestLabsFlux2DevInput =
            type Multipart =
                abstract contentType: option<D1SessionBookmark> with get, set
                abstract body: option<obj> with get, set

        module rec AiCfBlackForestLabsFlux2Klein4BInput =
            type Multipart =
                abstract contentType: option<D1SessionBookmark> with get, set
                abstract body: option<obj> with get, set

        module rec AiCfBlackForestLabsFlux2Klein9BInput =
            type Multipart =
                abstract contentType: option<D1SessionBookmark> with get, set
                abstract body: option<obj> with get, set

        module rec AiCfDeepgramFluxOutput =
            type Words =
                abstract confidence: float with get, set
                abstract word: D1SessionBookmark with get, set

        module rec AiCfDeepgramNova3Input =
            module rec Inputs =
                type Audio =
                    abstract contentType: D1SessionBookmark with get, set
                    abstract body: obj with get, set

        module rec AiCfDeepgramNova3Output =
            module rec Results =
                module rec Results =
                    module rec Channels =
                        module rec Results =
                            module rec Channels =
                                module rec Alternatives =
                                    module rec Results =
                                        module rec Channels =
                                            module rec Alternatives =
                                                type Words =
                                                    abstract word: option<D1SessionBookmark> with get, set
                                                    abstract start: option<float> with get, set

                                                    [<EmitProperty("end")>]
                                                    abstract ``end``: option<float> with get, set

                                                    abstract confidence: option<float> with get, set

                                type Alternatives =
                                    abstract words: option<Array<Alternatives.Words>> with get, set
                                    abstract transcript: option<D1SessionBookmark> with get, set
                                    abstract confidence: option<float> with get, set

                    module rec Sentiments =
                        module rec Results =
                            module rec Sentiments =
                                type Average =
                                    [<EmitProperty("sentiment_score")>]
                                    abstract sentimentScore: option<float> with get, set

                                    abstract sentiment: option<D1SessionBookmark> with get, set

                                type Segments =
                                    [<EmitProperty("sentiment_score")>]
                                    abstract sentimentScore: option<float> with get, set

                                    abstract sentiment: option<D1SessionBookmark> with get, set

                                    [<EmitProperty("end_word")>]
                                    abstract endWord: option<float> with get, set

                                    [<EmitProperty("start_word")>]
                                    abstract startWord: option<float> with get, set

                                    abstract text: option<D1SessionBookmark> with get, set

                    type Channels =
                        abstract alternatives: option<Array<Channels.Alternatives>> with get, set

                    type Sentiments =
                        abstract average: option<Sentiments.Average> with get, set
                        abstract segments: option<Array<Sentiments.Segments>> with get, set

                    type Summary =
                        abstract short: option<D1SessionBookmark> with get, set
                        abstract result: option<D1SessionBookmark> with get, set

            type Results =
                abstract sentiments: option<Results.Sentiments> with get, set
                abstract summary: option<Results.Summary> with get, set
                abstract channels: option<Array<Results.Channels>> with get, set

        module rec AiCfGoogleGemma312BItMessages =
            type Messages =
                abstract content: option<U2<Array<Messages.Content>, string>> with get, set
                abstract role: option<D1SessionBookmark> with get, set

        module rec AiCfGoogleGemma312BItOutput =
            module rec PostProcessedOutputs =
                type Usage =
                    [<EmitProperty("total_tokens")>]
                    abstract totalTokens: option<float> with get, set

                    [<EmitProperty("completion_tokens")>]
                    abstract completionTokens: option<float> with get, set

                    [<EmitProperty("prompt_tokens")>]
                    abstract promptTokens: option<float> with get, set

        module rec AiCfMetaLlama3370BInstructFp8FastAsyncBatch =
            type Requests =
                [<EmitProperty("response_format")>]
                abstract responseFormat: option<AiCfMetaLlama3370BInstructFp8FastJSONMode2> with get, set

                [<EmitProperty("presence_penalty")>]
                abstract presencePenalty: option<float> with get, set

                [<EmitProperty("frequency_penalty")>]
                abstract frequencyPenalty: option<float> with get, set

                [<EmitProperty("repetition_penalty")>]
                abstract repetitionPenalty: option<float> with get, set

                abstract seed: option<float> with get, set

                [<EmitProperty("top_p")>]
                abstract topP: option<float> with get, set

                abstract temperature: option<float> with get, set

                [<EmitProperty("max_tokens")>]
                abstract maxTokens: option<float> with get, set

                abstract stream: option<bool> with get, set
                abstract prompt: option<D1SessionBookmark> with get, set

                [<EmitProperty("external_reference")>]
                abstract externalReference: option<D1SessionBookmark> with get, set

        module rec AiCfMetaLlama3370BInstructFp8FastOutput =
            module rec PostProcessedOutputs =
                module rec PostProcessedOutputs =
                    type Usage =
                        [<EmitProperty("total_tokens")>]
                        abstract totalTokens: option<float> with get, set

                        [<EmitProperty("completion_tokens")>]
                        abstract completionTokens: option<float> with get, set

                        [<EmitProperty("prompt_tokens")>]
                        abstract promptTokens: option<float> with get, set

            type PostProcessedOutputs =
                [<EmitProperty("tool_calls")>]
                abstract toolCalls: option<Array<PostProcessedOutputs.ToolCalls>> with get, set

                abstract usage: option<PostProcessedOutputs.Usage> with get, set
                abstract response: D1SessionBookmark with get, set

        module rec AiCfMetaLlama4Scout17B16EInstructMessages =
            module rec Messages =
                module rec Messages =
                    module rec Content =
                        module rec Messages =
                            module rec Content =
                                type ImageUrl =
                                    abstract url: option<D1SessionBookmark> with get, set

                    type Content =
                        [<EmitProperty("image_url")>]
                        abstract imageUrl: option<Content.ImageUrl> with get, set

                        abstract text: option<D1SessionBookmark> with get, set

                        [<EmitProperty("type")>]
                        abstract ``type``: option<D1SessionBookmark> with get, set

            type Messages =
                abstract content: option<U3<Array<Messages.Content>, Messages.Content, string>> with get, set

                [<EmitProperty("tool_call_id")>]
                abstract toolCallId: option<D1SessionBookmark> with get, set

                abstract role: option<D1SessionBookmark> with get, set

        module rec AiCfMetaLlama4Scout17B16EInstructOutput =
            module rec PostProcessedOutputs =
                type Usage =
                    [<EmitProperty("total_tokens")>]
                    abstract totalTokens: option<float> with get, set

                    [<EmitProperty("completion_tokens")>]
                    abstract completionTokens: option<float> with get, set

                    [<EmitProperty("prompt_tokens")>]
                    abstract promptTokens: option<float> with get, set

        module rec AiCfMetaLlamaGuard38BInput =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Messages =
                | [<CompiledName("user")>] User
                | [<CompiledName("assistant")>] Assistant

            type ResponseFormat =
                [<EmitProperty("type")>]
                abstract ``type``: option<D1SessionBookmark> with get, set

        module rec AiCfMetaLlamaGuard38BOutput =
            module rec PostProcessedOutputs =
                type Usage =
                    [<EmitProperty("total_tokens")>]
                    abstract totalTokens: option<float> with get, set

                    [<EmitProperty("completion_tokens")>]
                    abstract completionTokens: option<float> with get, set

                    [<EmitProperty("prompt_tokens")>]
                    abstract promptTokens: option<float> with get, set

            type Response =
                abstract categories: option<Array<D1SessionBookmark>> with get, set
                abstract safe: option<bool> with get, set

        module rec AiCfMistralaiMistralSmall3124BInstructOutput =
            module rec PostProcessedOutputs =
                type Usage =
                    [<EmitProperty("total_tokens")>]
                    abstract totalTokens: option<float> with get, set

                    [<EmitProperty("completion_tokens")>]
                    abstract completionTokens: option<float> with get, set

                    [<EmitProperty("prompt_tokens")>]
                    abstract promptTokens: option<float> with get, set

        module rec AiCfOpenaiWhisperLargeV3TurboInput =
            type Multipart =
                abstract contentType: option<D1SessionBookmark> with get, set
                abstract body: option<obj> with get, set

        module rec AiCfOpenaiWhisperLargeV3TurboOutput =
            module rec Segments =
                module rec Segments =
                    type Words =
                        [<EmitProperty("end")>]
                        abstract ``end``: option<float> with get, set

                        abstract start: option<float> with get, set
                        abstract word: option<D1SessionBookmark> with get, set

            type Segments =
                abstract words: option<Array<Segments.Words>> with get, set

                [<EmitProperty("no_speech_prob")>]
                abstract noSpeechProb: option<float> with get, set

                [<EmitProperty("compression_ratio")>]
                abstract compressionRatio: option<float> with get, set

                [<EmitProperty("avg_logprob")>]
                abstract avgLogprob: option<float> with get, set

                abstract temperature: option<float> with get, set
                abstract text: option<D1SessionBookmark> with get, set

                [<EmitProperty("end")>]
                abstract ``end``: option<float> with get, set

                abstract start: option<float> with get, set

            type TranscriptionInfo =
                [<EmitProperty("duration_after_vad")>]
                abstract durationAfterVad: option<float> with get, set

                abstract duration: option<float> with get, set

                [<EmitProperty("language_probability")>]
                abstract languageProbability: option<float> with get, set

                abstract language: option<D1SessionBookmark> with get, set

        module rec AiCfOpenaiWhisperTinyEnInput =
            type Inputs =
                abstract audio: AiSentenceSimilarityOutput with get, set

        module rec AiCfQwenQwen25Coder32BInstructMessages =
            type Messages =
                abstract content: D1SessionBookmark with get, set
                abstract role: D1SessionBookmark with get, set

        module rec AiCfQwenQwen25Coder32BInstructOutput =
            module rec PostProcessedOutputs =
                type Usage =
                    [<EmitProperty("total_tokens")>]
                    abstract totalTokens: option<float> with get, set

                    [<EmitProperty("completion_tokens")>]
                    abstract completionTokens: option<float> with get, set

                    [<EmitProperty("prompt_tokens")>]
                    abstract promptTokens: option<float> with get, set

        module rec AiCfQwenQwen330BA3BFp8ChatCompletionResponse =
            module rec PostProcessedOutputs =
                type Usage =
                    [<EmitProperty("total_tokens")>]
                    abstract totalTokens: option<float> with get, set

                    [<EmitProperty("completion_tokens")>]
                    abstract completionTokens: option<float> with get, set

                    [<EmitProperty("prompt_tokens")>]
                    abstract promptTokens: option<float> with get, set

        module rec AiCfQwenQwen330BA3BFp8TextCompletionResponse =
            module rec PostProcessedOutputs =
                type Usage =
                    [<EmitProperty("total_tokens")>]
                    abstract totalTokens: option<float> with get, set

                    [<EmitProperty("completion_tokens")>]
                    abstract completionTokens: option<float> with get, set

                    [<EmitProperty("prompt_tokens")>]
                    abstract promptTokens: option<float> with get, set

        module rec AiCfQwenQwq32BOutput =
            module rec PostProcessedOutputs =
                type Usage =
                    [<EmitProperty("total_tokens")>]
                    abstract totalTokens: option<float> with get, set

                    [<EmitProperty("completion_tokens")>]
                    abstract completionTokens: option<float> with get, set

                    [<EmitProperty("prompt_tokens")>]
                    abstract promptTokens: option<float> with get, set

        module rec AiCfUnumUformGen2Qwen500MInput =
            type Inputs =
                [<EmitProperty("max_tokens")>]
                abstract maxTokens: option<float> with get, set

                abstract image: U2<Array<float>, Inputs.Image> with get, set

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

        module rec AiGateway =
            module rec PatchLog =
                module rec Data =
                    type Params =
                        abstract Item: key: D1SessionBookmark -> option<obj>

                type Data =
                    abstract metadata: option<Data.Metadata> with get, set
                    abstract feedback: option<Data.Feedback> with get, set
                    abstract score: option<float> with get, set

            module rec Run =
                module rec Data =
                    module rec Run =
                        module rec Data =
                            module rec Headers =
                                module rec Run =
                                    module rec Data =
                                        module rec Headers =
                                            type CfAigCustomCost =
                                                [<EmitProperty("total_cost")>]
                                                abstract totalCost: option<float> with get, set

                                                [<EmitProperty("per_token_out")>]
                                                abstract perTokenOut: option<float> with get, set

                                                [<EmitProperty("per_token_in")>]
                                                abstract perTokenIn: option<float> with get, set

                            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                            type Headers =
                                | [<CompiledValue(false)>] False
                                | [<CompiledValue(true)>] True

                module rec Options =
                    module rec Transform =
                        module rec Options =
                            module rec Gateway =
                                type Retries =
                                    | ``1`` = 1
                                    | ``2`` = 2
                                    | ``3`` = 3
                                    | ``4`` = 4
                                    | ``5`` = 5

                type Options =
                    abstract signal: option<AbortSignal> with get, set
                    abstract extraHeaders: option<obj> with get, set
                    abstract gateway: option<UniversalGatewayOptions> with get, set
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

                type Data =
                    abstract query: option<obj> with get, set
                    abstract headers: Data.Headers with get, set
                    abstract endpoint: D1SessionBookmark with get, set
                    abstract provider: U2<Data.Provider, string> with get, set

            type GetLog =
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

        module rec AiModelListType =
            type AiModelList =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec AiModelsSearchObject =
            module rec Models =
                type Task =
                    abstract description: D1SessionBookmark with get, set
                    abstract name: D1SessionBookmark with get, set
                    abstract id: D1SessionBookmark with get, set

        module rec AiOptions =
            module rec Transform =
                module rec Options =
                    module rec Gateway =
                        module rec Transform =
                            module rec Options =
                                module rec Gateway =
                                    type Retries =
                                        | ``1`` = 1
                                        | ``2`` = 2
                                        | ``3`` = 3
                                        | ``4`` = 4
                                        | ``5`` = 5

                        type Params =
                            abstract Item: key: D1SessionBookmark -> option<obj>

                    type Gateway =
                        abstract retries: option<GatewayRetries> with get, set
                        abstract requestTimeoutMs: option<float> with get, set
                        abstract eventId: option<D1SessionBookmark> with get, set
                        abstract collectLog: option<bool> with get, set
                        abstract metadata: option<WebAssembly.ModuleImports> with get, set
                        abstract skipCache: option<bool> with get, set
                        abstract cacheTtl: option<float> with get, set
                        abstract cacheKey: option<D1SessionBookmark> with get, set
                        abstract id: D1SessionBookmark with get, set

        module rec AiSearchChatCompletionsRequest =
            module rec AiSearchOptions =
                module rec Retrieval =
                    module rec Filter =
                        module rec Filter =
                            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                            type Item =
                                | [<CompiledValue(false)>] False
                                | [<CompiledValue(true)>] True

                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                    type Filter =
                        | [<CompiledValue(false)>] False
                        | [<CompiledValue(true)>] True

                type QueryRewrite =
                    [<EmitProperty("rewrite_prompt")>]
                    abstract rewritePrompt: option<D1SessionBookmark> with get, set

                    abstract model: option<D1SessionBookmark> with get, set
                    abstract enabled: option<bool> with get, set
                    abstract Item: key: D1SessionBookmark -> option<obj>

                type Reranking =
                    [<EmitProperty("match_threshold")>]
                    abstract matchThreshold: option<float> with get, set

                    abstract model: option<D1SessionBookmark> with get, set
                    abstract enabled: option<bool> with get, set
                    abstract Item: key: D1SessionBookmark -> option<obj>

                type Cache =
                    [<EmitProperty("cache_threshold")>]
                    abstract cacheThreshold: option<Cache.CacheThreshold> with get, set

                    abstract enabled: option<bool> with get, set

                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Retrieval =
                    | [<CompiledName("and")>] And
                    | [<CompiledName("or")>] Or
                    | [<CompiledName("max")>] Max
                    | [<CompiledName("rrf")>] Rrf
                    | [<CompiledName("vector")>] Vector
                    | [<CompiledName("keyword")>] Keyword
                    | [<CompiledName("hybrid")>] Hybrid

            type AiSearchOptions =
                abstract cache: option<AiSearchOptions.Cache> with get, set
                abstract reranking: option<AiSearchOptions.Reranking> with get, set

                [<EmitProperty("query_rewrite")>]
                abstract queryRewrite: option<AiSearchOptions.QueryRewrite> with get, set

                abstract retrieval: option<AiSearchOptions.Retrieval> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec AiSearchChatCompletionsResponse =
            module rec Choices =
                module rec Choices =
                    type Message =
                        abstract content: option<string> with get, set
                        abstract role: Message.Role with get, set
                        abstract Item: key: D1SessionBookmark -> option<obj>

            module rec Chunks =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type ScoringDetails =
                    | [<CompiledName("rrf")>] Rrf
                    | [<CompiledName("max")>] Max

                type Item =
                    abstract metadata: option<WebAssembly.ModuleImports> with get, set
                    abstract key: D1SessionBookmark with get, set
                    abstract timestamp: option<float> with get, set

            type Chunks =
                [<EmitProperty("scoring_details")>]
                abstract scoringDetails: option<Chunks.ScoringDetails> with get, set

                abstract item: Chunks.Item with get, set
                abstract text: D1SessionBookmark with get, set
                abstract score: float with get, set

                [<EmitProperty("type")>]
                abstract ``type``: D1SessionBookmark with get, set

                abstract id: D1SessionBookmark with get, set

            type Choices =
                abstract message: Choices.Message with get, set
                abstract index: option<float> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec AiSearchConfig =
            module rec List =
                module rec Result =
                    type IndexMethod =
                        abstract keyword: option<bool> with get, set
                        abstract vector: option<bool> with get, set

        module rec AiSearchInstance =
            module rec ChatCompletions =
                type Params =
                    [<EmitProperty("ai_search_options")>]
                    abstract aiSearchOptions: option<AiSearchOptions> with get, set

                    abstract stream: option<bool> with get, set
                    abstract model: option<D1SessionBookmark> with get, set
                    abstract messages: Array<AiSearchMessage> with get, set
                    abstract Item: key: D1SessionBookmark -> option<obj>

            module rec List =
                module rec Result =
                    module rec List =
                        module rec Result =
                            type CustomMetadata =
                                [<EmitProperty("data_type")>]
                                abstract dataType: CustomMetadata.DataType with get, set

                                [<EmitProperty("field_name")>]
                                abstract fieldName: D1SessionBookmark with get, set

                type Result =
                    | ``3600`` = 3600
                    | ``7200`` = 7200
                    | ``14400`` = 14400
                    | ``21600`` = 21600
                    | ``43200`` = 43200
                    | ``86400`` = 86400

            module rec Search =
                module rec Params =
                    module rec AiSearchOptions =
                        module rec Retrieval =
                            module rec Filter =
                                module rec Filter =
                                    type Item =
                                        [<EmitProperty("$gte")>]
                                        abstract gte: option<U3<Item.Gte, string, float>> with get, set

                                        [<EmitProperty("$gt")>]
                                        abstract gt: option<U3<Item.Gt, string, float>> with get, set

                                        [<EmitProperty("$lte")>]
                                        abstract lte: option<U3<Item.Lte, string, float>> with get, set

                                        [<EmitProperty("$lt")>]
                                        abstract lt: option<U3<Item.Lt, string, float>> with get, set

                                        [<EmitProperty("$ne")>]
                                        abstract ne: option<U3<Item.Ne, string, float>> with get, set

                                        [<EmitProperty("$eq")>]
                                        abstract eq: option<U3<Item.Eq, string, float>> with get, set

                                        [<EmitProperty("$nin")>]
                                        abstract nin: option<Array<U3<Item.Nin, string, float>>> with get, set

                                        [<EmitProperty("$in")>]
                                        abstract ``in``: option<Array<U3<Item.In, string, float>>> with get, set

                            type Filter =
                                abstract Item:
                                    key: D1SessionBookmark ->
                                        option<U5<Filter.Item, Filter.Item, Filter.Item, string, float>>

                        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                        type Retrieval =
                            | [<CompiledName("max")>] Max
                            | [<CompiledName("rrf")>] Rrf
                            | [<CompiledName("vector")>] Vector
                            | [<CompiledName("keyword")>] Keyword
                            | [<CompiledName("hybrid")>] Hybrid
                            | [<CompiledName("and")>] And
                            | [<CompiledName("or")>] Or

                        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                        type Cache =
                            | [<CompiledName("super_strict_match")>] SuperStrictMatch
                            | [<CompiledName("close_enough")>] CloseEnough
                            | [<CompiledName("flexible_friend")>] FlexibleFriend
                            | [<CompiledName("anything_goes")>] AnythingGoes

                        type QueryRewrite =
                            [<EmitProperty("rewrite_prompt")>]
                            abstract rewritePrompt: option<D1SessionBookmark> with get, set

                            abstract model: option<D1SessionBookmark> with get, set
                            abstract enabled: option<bool> with get, set
                            abstract Item: key: D1SessionBookmark -> option<obj>

                        type Reranking =
                            [<EmitProperty("match_threshold")>]
                            abstract matchThreshold: option<float> with get, set

                            abstract model: option<D1SessionBookmark> with get, set
                            abstract enabled: option<bool> with get, set
                            abstract Item: key: D1SessionBookmark -> option<obj>

                    type AiSearchOptions =
                        abstract cache: option<AiSearchOptions.Cache> with get, set
                        abstract reranking: option<AiSearchOptions.Reranking> with get, set

                        [<EmitProperty("query_rewrite")>]
                        abstract queryRewrite: option<AiSearchOptions.QueryRewrite> with get, set

                        abstract retrieval: option<AiSearchOptions.Retrieval> with get, set
                        abstract Item: key: D1SessionBookmark -> option<obj>

                type Params =
                    [<EmitProperty("ai_search_options")>]
                    abstract aiSearchOptions: option<AiSearchOptions> with get, set

                    abstract messages: Array<AiSearchMessage> with get, set
                    abstract query: option<unit> with get, set
                    abstract messages: option<unit> with get, set
                    abstract query: D1SessionBookmark with get, set

            module rec Stats =
                module rec Stats =
                    module rec Engine =
                        module rec Stats =
                            module rec Engine =
                                type R2 =
                                    abstract objectCount: float with get, set
                                    abstract metadataSizeBytes: float with get, set
                                    abstract payloadSizeBytes: float with get, set

                                type Vectorize =
                                    abstract dimensions: float with get, set
                                    abstract vectorsCount: float with get, set

                    type Engine =
                        abstract r2: option<Engine.R2> with get, set
                        abstract vectorize: option<Engine.Vectorize> with get, set

            module rec Update =
                module rec Config =
                    module rec List =
                        module rec Result =
                            module rec RetrievalOptions =
                                module rec List =
                                    module rec Result =
                                        module rec RetrievalOptions =
                                            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                            type BoostBy =
                                                | [<CompiledName("asc")>] Asc
                                                | [<CompiledName("desc")>] Desc
                                                | [<CompiledName("exists")>] Exists
                                                | [<CompiledName("not_exists")>] NotExists

                            type IndexMethod =
                                abstract keyword: option<bool> with get, set
                                abstract vector: option<bool> with get, set

                            type IndexingOptions =
                                [<EmitProperty("keyword_tokenizer")>]
                                abstract keywordTokenizer: option<IndexingOptions.KeywordTokenizer> with get, set

                            type RetrievalOptions =
                                [<EmitProperty("boost_by")>]
                                abstract boostBy: option<Array<RetrievalOptions.BoostBy>> with get, set

                                [<EmitProperty("keyword_match_mode")>]
                                abstract keywordMatchMode: option<RetrievalOptions.KeywordMatchMode> with get, set

                type Config =
                    abstract metadata: option<Config.Metadata> with get, set

                    [<EmitProperty("sync_interval")>]
                    abstract syncInterval: option<Config.SyncInterval> with get, set

                    [<EmitProperty("namespace")>]
                    abstract ``namespace``: option<string> with get, set

                    [<EmitProperty("custom_metadata")>]
                    abstract customMetadata: option<Array<Config.CustomMetadata>> with get, set

                    [<EmitProperty("cache_threshold")>]
                    abstract cacheThreshold: option<Config.CacheThreshold> with get, set

                    abstract cache: option<Config.Cache> with get, set

                    [<EmitProperty("max_num_results")>]
                    abstract maxNumResults: option<float> with get, set

                    [<EmitProperty("score_threshold")>]
                    abstract scoreThreshold: option<float> with get, set

                    [<EmitProperty("chunk_overlap")>]
                    abstract chunkOverlap: option<float> with get, set

                    [<EmitProperty("chunk_size")>]
                    abstract chunkSize: option<float> with get, set

                    abstract chunk: option<Config.Chunk> with get, set

                    [<EmitProperty("retrieval_options")>]
                    abstract retrievalOptions: option<Config.RetrievalOptions> with get, set

                    [<EmitProperty("indexing_options")>]
                    abstract indexingOptions: option<Config.IndexingOptions> with get, set

                    [<EmitProperty("fusion_method")>]
                    abstract fusionMethod: option<Config.FusionMethod> with get, set

                    [<EmitProperty("index_method")>]
                    abstract indexMethod: option<Config.IndexMethod> with get, set

                    [<EmitProperty("hybrid_search_enabled")>]
                    abstract hybridSearchEnabled: option<Config.HybridSearchEnabled> with get, set

                    [<EmitProperty("reranking_model")>]
                    abstract rerankingModel: option<string> with get, set

                    [<EmitProperty("rewrite_model")>]
                    abstract rewriteModel: option<string> with get, set

                    [<EmitProperty("ai_search_model")>]
                    abstract aiSearchModel: option<string> with get, set

                    [<EmitProperty("embedding_model")>]
                    abstract embeddingModel: option<string> with get, set

                    abstract reranking: option<Config.Reranking> with get, set

                    [<EmitProperty("rewrite_query")>]
                    abstract rewriteQuery: option<Config.RewriteQuery> with get, set

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

            type Stats =
                abstract engine: option<Stats.Engine> with get, set

                [<EmitProperty("last_activity")>]
                abstract lastActivity: option<D1SessionBookmark> with get, set

                abstract outdated: option<float> with get, set
                abstract skipped: option<float> with get, set
                abstract error: option<float> with get, set
                abstract completed: option<float> with get, set
                abstract running: option<float> with get, set
                abstract queued: option<float> with get, set

            type Search =
                abstract chunks: Array<Search.Chunks> with get, set

                [<EmitProperty("search_query")>]
                abstract searchQuery: D1SessionBookmark with get, set

            type ChatCompletions =
                abstract chunks: Array<ChatCompletions.Chunks> with get, set
                abstract choices: Array<ChatCompletions.Choices> with get, set
                abstract model: option<D1SessionBookmark> with get, set
                abstract object: option<D1SessionBookmark> with get, set
                abstract id: option<D1SessionBookmark> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec AiSearchInstanceInfo =
            module rec List =
                module rec Result =
                    type IndexMethod =
                        abstract keyword: option<bool> with get, set
                        abstract vector: option<bool> with get, set

        module rec AiSearchItem =
            module rec Chunks =
                module rec Chunks =
                    module rec Result =
                        type Item =
                            abstract metadata: option<WebAssembly.ModuleImports> with get, set
                            abstract key: D1SessionBookmark with get, set
                            abstract timestamp: option<float> with get, set

                    type Result =
                        abstract item: option<Result.Item> with get, set

                        [<EmitProperty("end_byte")>]
                        abstract endByte: float with get, set

                        [<EmitProperty("start_byte")>]
                        abstract startByte: float with get, set

                        abstract text: D1SessionBookmark with get, set
                        abstract id: D1SessionBookmark with get, set

                    type ResultInfo =
                        abstract offset: float with get, set
                        abstract limit: float with get, set
                        abstract total: float with get, set
                        abstract count: float with get, set

                type Params =
                    abstract offset: option<float> with get, set
                    abstract limit: option<float> with get, set

            module rec List =
                type Opts =
                    abstract cursor: option<D1SessionBookmark> with get, set
                    abstract limit: option<float> with get, set

            module rec Logs =
                module rec Logs =
                    type ResultInfo =
                        abstract truncated: bool with get, set
                        abstract cursor: option<string> with get, set

                        [<EmitProperty("per_page")>]
                        abstract perPage: float with get, set

                        abstract count: float with get, set

                    type Result =
                        abstract errorType: option<D1SessionBookmark> with get, set
                        abstract processingTimeMs: option<float> with get, set
                        abstract chunkCount: option<float> with get, set
                        abstract fileKey: option<D1SessionBookmark> with get, set
                        abstract message: D1SessionBookmark with get, set
                        abstract action: D1SessionBookmark with get, set
                        abstract timestamp: D1SessionBookmark with get, set

            type Chunks =
                [<EmitProperty("result_info")>]
                abstract resultInfo: Chunks.ResultInfo with get, set

                abstract result: Array<AiSearchItemChunk> with get, set

            type Download =
                abstract size: float with get, set
                abstract filename: D1SessionBookmark with get, set
                abstract contentType: D1SessionBookmark with get, set
                abstract body: AiTextToImageOutput with get, set

            type Logs =
                [<EmitProperty("result_info")>]
                abstract resultInfo: Logs.ResultInfo with get, set

                abstract result: Array<AiSearchItemLog> with get, set

        module rec AiSearchItemChunk =
            type Item =
                abstract metadata: option<WebAssembly.ModuleImports> with get, set
                abstract key: D1SessionBookmark with get, set
                abstract timestamp: option<float> with get, set

        module rec AiSearchItemChunksResponse =
            module rec Chunks =
                type ResultInfo =
                    abstract offset: float with get, set
                    abstract limit: float with get, set
                    abstract total: float with get, set
                    abstract count: float with get, set

        module rec AiSearchItemLogsResponse =
            module rec Logs =
                type ResultInfo =
                    abstract truncated: bool with get, set
                    abstract cursor: option<string> with get, set

                    [<EmitProperty("per_page")>]
                    abstract perPage: float with get, set

                    abstract count: float with get, set

        module rec AiSearchItems =
            module rec List =
                module rec List =
                    type ResultInfo =
                        [<EmitProperty("total_count")>]
                        abstract totalCount: float with get, set

                        [<EmitProperty("per_page")>]
                        abstract perPage: float with get, set

                        abstract page: float with get, set
                        abstract count: float with get, set

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

                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Upload =
                    | [<CompiledName("completed")>] Completed
                    | [<CompiledName("error")>] Error
                    | [<CompiledName("skipped")>] Skipped
                    | [<CompiledName("queued")>] Queued
                    | [<CompiledName("running")>] Running
                    | [<CompiledName("outdated")>] Outdated
                    | INDEX
                    | DELETE

            module rec Upload =
                type Options =
                    abstract metadata: option<WebAssembly.ModuleImports> with get, set

            type List =
                [<EmitProperty("result_info")>]
                abstract resultInfo: option<List.ResultInfo> with get, set

                abstract result: Array<AiSearchItemInfo> with get, set

        module rec AiSearchJob =
            module rec Logs =
                module rec List =
                    type ResultInfo =
                        [<EmitProperty("total_count")>]
                        abstract totalCount: float with get, set

                        [<EmitProperty("per_page")>]
                        abstract perPage: float with get, set

                        abstract page: float with get, set
                        abstract count: float with get, set

                module rec Logs =
                    type Result =
                        [<EmitProperty("created_at")>]
                        abstract createdAt: float with get, set

                        [<EmitProperty("message_type")>]
                        abstract messageType: float with get, set

                        abstract message: D1SessionBookmark with get, set
                        abstract id: float with get, set

                type Params =
                    [<EmitProperty("per_page")>]
                    abstract perPage: option<float> with get, set

                    abstract page: option<float> with get, set

            type Logs =
                [<EmitProperty("result_info")>]
                abstract resultInfo: option<Logs.ResultInfo> with get, set

                abstract result: Array<AiSearchJobLog> with get, set

        module rec AiSearchJobLogsResponse =
            module rec List =
                type ResultInfo =
                    [<EmitProperty("total_count")>]
                    abstract totalCount: float with get, set

                    [<EmitProperty("per_page")>]
                    abstract perPage: float with get, set

                    abstract page: float with get, set
                    abstract count: float with get, set

        module rec AiSearchJobs =
            module rec Create =
                type Params =
                    abstract description: option<D1SessionBookmark> with get, set

            module rec List =
                module rec List =
                    type ResultInfo =
                        [<EmitProperty("total_count")>]
                        abstract totalCount: float with get, set

                        [<EmitProperty("per_page")>]
                        abstract perPage: float with get, set

                        abstract page: float with get, set
                        abstract count: float with get, set

                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Create =
                    | [<CompiledName("user")>] User
                    | [<CompiledName("schedule")>] Schedule

                type Params =
                    [<EmitProperty("per_page")>]
                    abstract perPage: option<float> with get, set

                    abstract page: option<float> with get, set

            type List =
                [<EmitProperty("result_info")>]
                abstract resultInfo: option<List.ResultInfo> with get, set

                abstract result: Array<AiSearchJobInfo> with get, set

        module rec AiSearchListItemsResponse =
            module rec List =
                type ResultInfo =
                    [<EmitProperty("total_count")>]
                    abstract totalCount: float with get, set

                    [<EmitProperty("per_page")>]
                    abstract perPage: float with get, set

                    abstract page: float with get, set
                    abstract count: float with get, set

        module rec AiSearchListJobsResponse =
            module rec List =
                type ResultInfo =
                    [<EmitProperty("total_count")>]
                    abstract totalCount: float with get, set

                    [<EmitProperty("per_page")>]
                    abstract perPage: float with get, set

                    abstract page: float with get, set
                    abstract count: float with get, set

        module rec AiSearchListResponse =
            module rec List =
                type ResultInfo =
                    [<EmitProperty("total_count")>]
                    abstract totalCount: float with get, set

                    [<EmitProperty("per_page")>]
                    abstract perPage: float with get, set

                    abstract page: float with get, set
                    abstract count: float with get, set

        module rec AiSearchMultiChatCompletionsRequest =
            module rec Retrieval =
                module rec Filter =
                    module rec Filter =
                        type Item =
                            [<EmitProperty("$nin")>]
                            abstract nin: option<Array<U3<Item.Nin, string, float>>> with get, set

                            [<EmitProperty("$in")>]
                            abstract ``in``: option<Array<U3<Item.In, string, float>>> with get, set

                            [<EmitProperty("$gte")>]
                            abstract gte: option<U3<Item.Gte, string, float>> with get, set

                            [<EmitProperty("$gt")>]
                            abstract gt: option<U3<Item.Gt, string, float>> with get, set

                            [<EmitProperty("$lte")>]
                            abstract lte: option<U3<Item.Lte, string, float>> with get, set

                            [<EmitProperty("$lt")>]
                            abstract lt: option<U3<Item.Lt, string, float>> with get, set

                            [<EmitProperty("$ne")>]
                            abstract ne: option<U3<Item.Ne, string, float>> with get, set

                            [<EmitProperty("$eq")>]
                            abstract eq: option<U3<Item.Eq, string, float>> with get, set

                type Filter =
                    abstract Item:
                        key: D1SessionBookmark -> option<U5<Filter.Item, Filter.Item, Filter.Item, string, float>>

            type Retrieval =
                [<EmitProperty("boost_by")>]
                abstract boostBy: option<Array<Retrieval.BoostBy>> with get, set

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
                abstract keywordMatchMode: option<Retrieval.KeywordMatchMode> with get, set

                [<EmitProperty("fusion_method")>]
                abstract fusionMethod: option<Retrieval.FusionMethod> with get, set

                [<EmitProperty("retrieval_type")>]
                abstract retrievalType: option<Retrieval.RetrievalType> with get, set

                abstract Item: key: D1SessionBookmark -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Cache =
                | [<CompiledName("super_strict_match")>] SuperStrictMatch
                | [<CompiledName("close_enough")>] CloseEnough
                | [<CompiledName("flexible_friend")>] FlexibleFriend
                | [<CompiledName("anything_goes")>] AnythingGoes

            type QueryRewrite =
                [<EmitProperty("rewrite_prompt")>]
                abstract rewritePrompt: option<D1SessionBookmark> with get, set

                abstract model: option<D1SessionBookmark> with get, set
                abstract enabled: option<bool> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

            type Reranking =
                [<EmitProperty("match_threshold")>]
                abstract matchThreshold: option<float> with get, set

                abstract model: option<D1SessionBookmark> with get, set
                abstract enabled: option<bool> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec AiSearchMultiSearchChunk =
            type Item =
                abstract metadata: option<WebAssembly.ModuleImports> with get, set
                abstract key: D1SessionBookmark with get, set
                abstract timestamp: option<float> with get, set

            type ScoringDetails =
                [<EmitProperty("fusion_method")>]
                abstract fusionMethod: option<ScoringDetails.FusionMethod> with get, set

                [<EmitProperty("reranking_score")>]
                abstract rerankingScore: option<float> with get, set

                [<EmitProperty("vector_rank")>]
                abstract vectorRank: option<float> with get, set

                [<EmitProperty("keyword_rank")>]
                abstract keywordRank: option<float> with get, set

                [<EmitProperty("vector_score")>]
                abstract vectorScore: option<float> with get, set

                [<EmitProperty("keyword_score")>]
                abstract keywordScore: option<float> with get, set

                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec AiSearchMultiSearchOptions =
            module rec Retrieval =
                module rec Filter =
                    module rec Filter =
                        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                        type Item =
                            | [<CompiledValue(false)>] False
                            | [<CompiledValue(true)>] True

                type Filter =
                    abstract Item:
                        key: D1SessionBookmark -> option<U5<Filter.Item, Filter.Item, Filter.Item, string, float>>

            type QueryRewrite =
                [<EmitProperty("rewrite_prompt")>]
                abstract rewritePrompt: option<D1SessionBookmark> with get, set

                abstract model: option<D1SessionBookmark> with get, set
                abstract enabled: option<bool> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

            type Retrieval =
                [<EmitProperty("boost_by")>]
                abstract boostBy: option<Array<Retrieval.BoostBy>> with get, set

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
                abstract keywordMatchMode: option<Retrieval.KeywordMatchMode> with get, set

                [<EmitProperty("fusion_method")>]
                abstract fusionMethod: option<Retrieval.FusionMethod> with get, set

                [<EmitProperty("retrieval_type")>]
                abstract retrievalType: option<Retrieval.RetrievalType> with get, set

                abstract Item: key: D1SessionBookmark -> option<obj>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Cache =
                | [<CompiledName("super_strict_match")>] SuperStrictMatch
                | [<CompiledName("close_enough")>] CloseEnough
                | [<CompiledName("flexible_friend")>] FlexibleFriend
                | [<CompiledName("anything_goes")>] AnythingGoes

            type Reranking =
                [<EmitProperty("match_threshold")>]
                abstract matchThreshold: option<float> with get, set

                abstract model: option<D1SessionBookmark> with get, set
                abstract enabled: option<bool> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec AiSearchNamespace =
            module rec Create =
                type Config =
                    abstract metadata: option<WebAssembly.ModuleImports> with get, set

                    [<EmitProperty("sync_interval")>]
                    abstract syncInterval: option<Config.SyncInterval> with get, set

                    [<EmitProperty("namespace")>]
                    abstract ``namespace``: option<D1SessionBookmark> with get, set

                    [<EmitProperty("custom_metadata")>]
                    abstract customMetadata: option<Array<Config.CustomMetadata>> with get, set

                    [<EmitProperty("cache_threshold")>]
                    abstract cacheThreshold: option<Config.CacheThreshold> with get, set

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
                    abstract retrievalOptions: option<Config.RetrievalOptions> with get, set

                    [<EmitProperty("indexing_options")>]
                    abstract indexingOptions: option<Config.IndexingOptions> with get, set

                    [<EmitProperty("fusion_method")>]
                    abstract fusionMethod: option<Config.FusionMethod> with get, set

                    [<EmitProperty("index_method")>]
                    abstract indexMethod: option<Config.IndexMethod> with get, set

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
                    abstract ``type``: option<U2<Config.Type, string>> with get, set

                    abstract id: D1SessionBookmark with get, set
                    abstract Item: key: D1SessionBookmark -> option<obj>

            module rec List =
                module rec List =
                    module rec Result =
                        module rec List =
                            module rec Result =
                                module rec RetrievalOptions =
                                    module rec List =
                                        module rec Result =
                                            module rec RetrievalOptions =
                                                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                                type BoostBy =
                                                    | [<CompiledName("asc")>] Asc
                                                    | [<CompiledName("desc")>] Desc
                                                    | [<CompiledName("exists")>] Exists
                                                    | [<CompiledName("not_exists")>] NotExists

                                type CustomMetadata =
                                    [<EmitProperty("data_type")>]
                                    abstract dataType: CustomMetadata.DataType with get, set

                                    [<EmitProperty("field_name")>]
                                    abstract fieldName: D1SessionBookmark with get, set

                                type IndexMethod =
                                    abstract keyword: option<bool> with get, set
                                    abstract vector: option<bool> with get, set

                                type IndexingOptions =
                                    [<EmitProperty("keyword_tokenizer")>]
                                    abstract keywordTokenizer: option<IndexingOptions.KeywordTokenizer> with get, set

                                type RetrievalOptions =
                                    [<EmitProperty("boost_by")>]
                                    abstract boostBy: option<Array<RetrievalOptions.BoostBy>> with get, set

                                    [<EmitProperty("keyword_match_mode")>]
                                    abstract keywordMatchMode: option<RetrievalOptions.KeywordMatchMode> with get, set

                    type Result =
                        abstract metadata: option<WebAssembly.ModuleImports> with get, set

                        [<EmitProperty("sync_interval")>]
                        abstract syncInterval: option<Result.SyncInterval> with get, set

                        [<EmitProperty("custom_metadata")>]
                        abstract customMetadata: option<Array<Result.CustomMetadata>> with get, set

                        [<EmitProperty("cache_threshold")>]
                        abstract cacheThreshold: option<Result.CacheThreshold> with get, set

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
                        abstract retrievalOptions: option<Result.RetrievalOptions> with get, set

                        [<EmitProperty("indexing_options")>]
                        abstract indexingOptions: option<Result.IndexingOptions> with get, set

                        [<EmitProperty("fusion_method")>]
                        abstract fusionMethod: option<Result.FusionMethod> with get, set

                        [<EmitProperty("index_method")>]
                        abstract indexMethod: option<Result.IndexMethod> with get, set

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
                        abstract ``type``: option<U2<Result.Type, string>> with get, set

                        abstract id: D1SessionBookmark with get, set
                        abstract Item: key: D1SessionBookmark -> option<obj>

                    type ResultInfo =
                        [<EmitProperty("total_count")>]
                        abstract totalCount: float with get, set

                        [<EmitProperty("per_page")>]
                        abstract perPage: float with get, set

                        abstract page: float with get, set
                        abstract count: float with get, set

                type Params =
                    [<EmitProperty("order_by_direction")>]
                    abstract orderByDirection: option<Params.OrderByDirection> with get, set

                    [<EmitProperty("order_by")>]
                    abstract orderBy: option<Params.OrderBy> with get, set

                    abstract search: option<D1SessionBookmark> with get, set

                    [<EmitProperty("per_page")>]
                    abstract perPage: option<float> with get, set

                    abstract page: option<float> with get, set

            module rec Search =
                module rec Params =
                    module rec Retrieval =
                        module rec Filter =
                            module rec Filter =
                                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                type Item =
                                    | [<CompiledValue(false)>] False
                                    | [<CompiledValue(true)>] True

                        type Filter =
                            abstract Item:
                                key: D1SessionBookmark ->
                                    option<U5<Filter.Item, Filter.Item, Filter.Item, string, float>>

                    module rec Search =
                        module rec Params =
                            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                            type Messages =
                                | [<CompiledName("system")>] System
                                | [<CompiledName("developer")>] Developer
                                | [<CompiledName("user")>] User
                                | [<CompiledName("assistant")>] Assistant
                                | [<CompiledName("tool")>] Tool

                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                    type Retrieval =
                        | [<CompiledName("vector")>] Vector
                        | [<CompiledName("keyword")>] Keyword
                        | [<CompiledName("hybrid")>] Hybrid

                    type Reranking =
                        [<EmitProperty("match_threshold")>]
                        abstract matchThreshold: option<float> with get, set

                        abstract model: option<D1SessionBookmark> with get, set
                        abstract enabled: option<bool> with get, set
                        abstract Item: key: D1SessionBookmark -> option<obj>

                    type QueryRewrite =
                        [<EmitProperty("rewrite_prompt")>]
                        abstract rewritePrompt: option<D1SessionBookmark> with get, set

                        abstract model: option<D1SessionBookmark> with get, set
                        abstract enabled: option<bool> with get, set
                        abstract Item: key: D1SessionBookmark -> option<obj>

                    type Cache =
                        [<EmitProperty("cache_threshold")>]
                        abstract cacheThreshold: option<Cache.CacheThreshold> with get, set

                        abstract enabled: option<bool> with get, set

                module rec Search =
                    type Errors =
                        abstract message: D1SessionBookmark with get, set

                        [<EmitProperty("instance_id")>]
                        abstract instanceId: D1SessionBookmark with get, set

                type Params =
                    [<EmitProperty("instance_ids")>]
                    abstract instanceIds: Array<D1SessionBookmark> with get, set

                    abstract cache: option<Params.Cache> with get, set
                    abstract reranking: option<Params.Reranking> with get, set

                    [<EmitProperty("query_rewrite")>]
                    abstract queryRewrite: option<Params.QueryRewrite> with get, set

                    abstract retrieval: option<Params.Retrieval> with get, set

                    [<EmitProperty("ai_search_options")>]
                    abstract aiSearchOptions: AiSearchMultiSearchOptions with get, set

                    abstract messages: Array<AiSearchMessage> with get, set
                    abstract query: option<unit> with get, set
                    abstract messages: option<unit> with get, set
                    abstract query: D1SessionBookmark with get, set
                    abstract Item: key: D1SessionBookmark -> option<obj>

                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type ScoringDetails =
                    | [<CompiledName("rrf")>] Rrf
                    | [<CompiledName("max")>] Max

                type Item =
                    abstract metadata: option<WebAssembly.ModuleImports> with get, set
                    abstract key: D1SessionBookmark with get, set
                    abstract timestamp: option<float> with get, set

            type Search =
                [<EmitProperty("instance_id")>]
                abstract instanceId: D1SessionBookmark with get, set

                [<EmitProperty("scoring_details")>]
                abstract scoringDetails: option<Search.ScoringDetails> with get, set

                abstract item: Search.Item with get, set
                abstract text: D1SessionBookmark with get, set
                abstract score: float with get, set

                [<EmitProperty("type")>]
                abstract ``type``: D1SessionBookmark with get, set

                abstract id: D1SessionBookmark with get, set
                abstract errors: option<Array<AiSearchMultiSearchError>> with get, set
                abstract chunks: Array<AiSearchMultiSearchChunk> with get, set

                [<EmitProperty("search_query")>]
                abstract searchQuery: D1SessionBookmark with get, set

            type List =
                [<EmitProperty("result_info")>]
                abstract resultInfo: option<List.ResultInfo> with get, set

                abstract result: Array<AiSearchInstanceInfo> with get, set

        module rec AiSearchOptions =
            module rec Retrieval =
                module rec Filter =
                    module rec Filter =
                        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                        type Item =
                            | [<CompiledValue(false)>] False
                            | [<CompiledValue(true)>] True

                type Filter =
                    abstract Item:
                        key: D1SessionBookmark -> option<U5<Filter.Item, Filter.Item, Filter.Item, string, float>>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Retrieval =
                | [<CompiledName("vector")>] Vector
                | [<CompiledName("keyword")>] Keyword
                | [<CompiledName("hybrid")>] Hybrid
                | [<CompiledName("and")>] And
                | [<CompiledName("or")>] Or
                | [<CompiledName("max")>] Max
                | [<CompiledName("rrf")>] Rrf

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Cache =
                | [<CompiledName("super_strict_match")>] SuperStrictMatch
                | [<CompiledName("close_enough")>] CloseEnough
                | [<CompiledName("flexible_friend")>] FlexibleFriend
                | [<CompiledName("anything_goes")>] AnythingGoes

            type QueryRewrite =
                [<EmitProperty("rewrite_prompt")>]
                abstract rewritePrompt: option<D1SessionBookmark> with get, set

                abstract model: option<D1SessionBookmark> with get, set
                abstract enabled: option<bool> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

            type Reranking =
                [<EmitProperty("match_threshold")>]
                abstract matchThreshold: option<float> with get, set

                abstract model: option<D1SessionBookmark> with get, set
                abstract enabled: option<bool> with get, set
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec AiSearchStatsResponse =
            module rec Stats =
                module rec Engine =
                    module rec Stats =
                        module rec Engine =
                            type R2 =
                                abstract objectCount: float with get, set
                                abstract metadataSizeBytes: float with get, set
                                abstract payloadSizeBytes: float with get, set

                            type Vectorize =
                                abstract dimensions: float with get, set
                                abstract vectorsCount: float with get, set

                type Engine =
                    abstract r2: option<Engine.R2> with get, set
                    abstract vectorize: option<Engine.Vectorize> with get, set

        module rec AiTextGenerationInput =
            module rec Inputs =
                type ResponseFormat =
                    [<EmitProperty("json_schema")>]
                    abstract jsonSchema: option<obj> with get, set

                    [<EmitProperty("type")>]
                    abstract ``type``: D1SessionBookmark with get, set

        module rec AiTextGenerationOutput =
            module rec PostProcessedOutputs =
                type Usage =
                    [<EmitProperty("total_tokens")>]
                    abstract totalTokens: float with get, set

                    [<EmitProperty("completion_tokens")>]
                    abstract completionTokens: float with get, set

                    [<EmitProperty("prompt_tokens")>]
                    abstract promptTokens: float with get, set

        module rec AiTextGenerationToolInput =
            module rec Inputs =
                module rec Tools =
                    module rec Function =
                        module rec Inputs =
                            module rec Tools =
                                module rec Function =
                                    module rec Parameters =
                                        module rec Inputs =
                                            module rec Tools =
                                                module rec Function =
                                                    module rec Parameters =
                                                        module rec Properties =
                                                            module rec Inputs =
                                                                module rec Tools =
                                                                    module rec Function =
                                                                        module rec Parameters =
                                                                            module rec Properties =
                                                                                type Item =
                                                                                    abstract description:
                                                                                        option<D1SessionBookmark> with get, set

                                                                                    [<EmitProperty("type")>]
                                                                                    abstract ``type``: D1SessionBookmark with get, set

                                                        type Properties =
                                                            abstract Item: key: D1SessionBookmark -> Properties.Item

                                    type Parameters =
                                        abstract required: Array<D1SessionBookmark> with get, set
                                        abstract properties: Parameters.Properties with get, set

                                        [<EmitProperty("type")>]
                                        abstract ``type``: U2<Parameters.Type, Parameters.Type> with get, set

                    type Function =
                        abstract parameters: option<Function.Parameters> with get, set
                        abstract description: D1SessionBookmark with get, set
                        abstract name: D1SessionBookmark with get, set

        module rec AiTextGenerationToolLegacyInput =
            module rec Inputs =
                module rec Tools =
                    module rec Function =
                        module rec Parameters =
                            module rec Inputs =
                                module rec Tools =
                                    module rec Function =
                                        module rec Parameters =
                                            module rec Properties =
                                                module rec Inputs =
                                                    module rec Tools =
                                                        module rec Function =
                                                            module rec Parameters =
                                                                module rec Properties =
                                                                    type Item =
                                                                        abstract description: option<D1SessionBookmark> with get, set

                                                                        [<EmitProperty("type")>]
                                                                        abstract ``type``: D1SessionBookmark with get, set

                                            type Properties =
                                                abstract Item: key: D1SessionBookmark -> Properties.Item

                        type Parameters =
                            abstract required: Array<D1SessionBookmark> with get, set
                            abstract properties: Parameters.Properties with get, set

                            [<EmitProperty("type")>]
                            abstract ``type``: U2<Parameters.Type, Parameters.Type> with get, set

        module rec AiTextGenerationToolOutput =
            module rec Messages =
                type FunctionCall =
                    abstract arguments: D1SessionBookmark with get, set
                    abstract name: D1SessionBookmark with get, set

        module rec Artifacts =
            module rec Create =
                type Opts =
                    abstract setDefaultBranch: option<D1SessionBookmark> with get, set
                    abstract description: option<D1SessionBookmark> with get, set
                    abstract readOnly: option<bool> with get, set

            module rec Import =
                module rec Params =
                    module rec Import =
                        module rec Params =
                            module rec Target =
                                module rec Import =
                                    module rec Params =
                                        module rec Target =
                                            type Opts =
                                                abstract readOnly: option<bool> with get, set
                                                abstract description: option<D1SessionBookmark> with get, set

                            type Source =
                                abstract depth: option<float> with get, set
                                abstract branch: option<D1SessionBookmark> with get, set
                                abstract url: D1SessionBookmark with get, set

                            type Target =
                                abstract opts: option<Target.Opts> with get, set
                                abstract name: D1SessionBookmark with get, set

                type Params =
                    abstract target: Params.Target with get, set
                    abstract source: Params.Source with get, set

            module rec List =
                type Opts =
                    abstract cursor: option<D1SessionBookmark> with get, set
                    abstract limit: option<float> with get, set

        module rec ArtifactsRepo =
            module rec Fork =
                type Opts =
                    abstract defaultBranchOnly: option<bool> with get, set
                    abstract readOnly: option<bool> with get, set
                    abstract description: option<D1SessionBookmark> with get, set

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

        module rec AssistantMessage =
            module rec Audio =
                type Voice =
                    abstract id: D1SessionBookmark with get, set

            module rec Messages =
                type FunctionCall =
                    abstract arguments: D1SessionBookmark with get, set
                    abstract name: D1SessionBookmark with get, set

        module rec AutoRAG =
            module rec Search =
                module rec Params =
                    module rec Search =
                        module rec Params =
                            module rec Filters =
                                module rec Search =
                                    module rec Params =
                                        type Filters =
                                            abstract value: U3<string, float, bool> with get, set

                                            [<EmitProperty("type")>]
                                            abstract ``type``: Filters.Type with get, set

                                            abstract key: D1SessionBookmark with get, set

                            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                            type Filters =
                                | [<CompiledName("and")>] And
                                | [<CompiledName("or")>] Or

                            type RankingOptions =
                                [<EmitProperty("score_threshold")>]
                                abstract scoreThreshold: option<float> with get, set

                                abstract ranker: option<D1SessionBookmark> with get, set

                            type Reranking =
                                abstract model: option<D1SessionBookmark> with get, set
                                abstract enabled: option<bool> with get, set

                module rec Search =
                    module rec Data =
                        module rec Search =
                            module rec Data =
                                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                type Content = | [<CompiledName("text")>] Text

                        type Params =
                            abstract Item: key: D1SessionBookmark -> option<obj>

                    type Data =
                        abstract content: Array<ChatCompletionContentPartText> with get, set
                        abstract attributes: WebAssembly.ModuleImports with get, set
                        abstract score: float with get, set
                        abstract filename: D1SessionBookmark with get, set

                        [<EmitProperty("file_id")>]
                        abstract fileId: D1SessionBookmark with get, set

                type Params =
                    [<EmitProperty("rewrite_query")>]
                    abstract rewriteQuery: option<bool> with get, set

                    abstract reranking: option<Params.Reranking> with get, set

                    [<EmitProperty("ranking_options")>]
                    abstract rankingOptions: option<Params.RankingOptions> with get, set

                    [<EmitProperty("max_num_results")>]
                    abstract maxNumResults: option<float> with get, set

                    abstract filters: option<U2<Params.Filters, Params.Filters>> with get, set
                    abstract query: D1SessionBookmark with get, set

            type List =
                abstract status: D1SessionBookmark with get, set
                abstract paused: bool with get, set

                [<EmitProperty("vectorize_name")>]
                abstract vectorizeName: D1SessionBookmark with get, set

                abstract source: D1SessionBookmark with get, set

                [<EmitProperty("type")>]
                abstract ``type``: D1SessionBookmark with get, set

                abstract enable: bool with get, set
                abstract id: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Search = | [<CompiledName("vector_store.search_results.page")>] VectorStoreSearchResultsPage

        module rec AutoRagAiSearchRequest =
            module rec Search =
                module rec Params =
                    type Reranking =
                        abstract model: option<D1SessionBookmark> with get, set
                        abstract enabled: option<bool> with get, set

                    type RankingOptions =
                        [<EmitProperty("score_threshold")>]
                        abstract scoreThreshold: option<float> with get, set

                        abstract ranker: option<D1SessionBookmark> with get, set

        module rec AutoRagSearchRequest =
            module rec Search =
                module rec Params =
                    type RankingOptions =
                        [<EmitProperty("score_threshold")>]
                        abstract scoreThreshold: option<float> with get, set

                        abstract ranker: option<D1SessionBookmark> with get, set

                    type Reranking =
                        abstract model: option<D1SessionBookmark> with get, set
                        abstract enabled: option<bool> with get, set

        module rec BaseAiAutomaticSpeechRecognition =
            module rec PostProcessedOutputs =
                module rec PostProcessedOutputs =
                    type Words =
                        [<EmitProperty("end")>]
                        abstract ``end``: float with get, set

                        abstract start: float with get, set
                        abstract word: D1SessionBookmark with get, set

            type Inputs =
                abstract audio: AiSentenceSimilarityOutput with get, set

            type PostProcessedOutputs =
                abstract vtt: option<D1SessionBookmark> with get, set
                abstract words: option<Array<PostProcessedOutputs.Words>> with get, set
                abstract text: option<D1SessionBookmark> with get, set

        module rec BaseAiCfBaaiBgeBaseEnV15 =
            type Inputs =
                abstract requests: Array<Inputs.Requests> with get, set
                abstract pooling: option<Inputs.Pooling> with get, set
                abstract text: U2<Array<D1SessionBookmark>, string> with get, set

            type PostProcessedOutputs =
                abstract pooling: option<PostProcessedOutputs.Pooling> with get, set
                abstract data: option<Array<AiSentenceSimilarityOutput>> with get, set
                abstract shape: option<AiSentenceSimilarityOutput> with get, set

        module rec BaseAiCfBaaiBgeLargeEnV15 =
            type PostProcessedOutputs =
                abstract pooling: option<PostProcessedOutputs.Pooling> with get, set
                abstract data: option<Array<AiSentenceSimilarityOutput>> with get, set
                abstract shape: option<AiSentenceSimilarityOutput> with get, set

            type Inputs =
                abstract pooling: option<Inputs.Pooling> with get, set
                abstract text: U2<Array<D1SessionBookmark>, string> with get, set
                abstract requests: Array<Inputs.Requests> with get, set

        module rec BaseAiCfBaaiBgeM3 =
            type Inputs =
                abstract requests: Array<U2<AiCfBaaiBgeM3InputQueryAndContexts1, AiCfBaaiBgeM3InputEmbedding1>> with get, set

        module rec BaseAiCfBaaiBgeSmallEnV15 =
            type Inputs =
                abstract pooling: option<Inputs.Pooling> with get, set
                abstract text: U2<Array<D1SessionBookmark>, string> with get, set
                abstract requests: Array<Inputs.Requests> with get, set

            type PostProcessedOutputs =
                abstract pooling: option<PostProcessedOutputs.Pooling> with get, set
                abstract data: option<Array<AiSentenceSimilarityOutput>> with get, set
                abstract shape: option<AiSentenceSimilarityOutput> with get, set

        module rec BaseAiCfGoogleGemma312BIt =
            module rec PostProcessedOutputs =
                module rec PostProcessedOutputs =
                    type ToolCalls =
                        abstract name: option<D1SessionBookmark> with get, set
                        abstract arguments: option<obj> with get, set

                    type Usage =
                        [<EmitProperty("total_tokens")>]
                        abstract totalTokens: option<float> with get, set

                        [<EmitProperty("completion_tokens")>]
                        abstract completionTokens: option<float> with get, set

                        [<EmitProperty("prompt_tokens")>]
                        abstract promptTokens: option<float> with get, set

            type PostProcessedOutputs =
                [<EmitProperty("tool_calls")>]
                abstract toolCalls: option<Array<PostProcessedOutputs.ToolCalls>> with get, set

                abstract usage: option<PostProcessedOutputs.Usage> with get, set
                abstract response: D1SessionBookmark with get, set

        module rec BaseAiCfGoogleGemma426BA4BIT =
            module rec PostProcessedOutputs =
                module rec PostProcessedOutputs =
                    module rec Choices =
                        module rec PostProcessedOutputs =
                            module rec Choices =
                                module rec Logprobs =
                                    module rec PostProcessedOutputs =
                                        module rec Choices =
                                            module rec Logprobs =
                                                module rec Content =
                                                    module rec PostProcessedOutputs =
                                                        module rec Choices =
                                                            module rec Logprobs =
                                                                module rec Content =
                                                                    type TopLogprobs =
                                                                        abstract bytes: option<Array<float>> with get, set
                                                                        abstract logprob: float with get, set
                                                                        abstract token: D1SessionBookmark with get, set

                                                type Content =
                                                    [<EmitProperty("top_logprobs")>]
                                                    abstract topLogprobs: Array<ChatCompletionTopLogprob> with get, set

                                                    abstract bytes: option<Array<float>> with get, set
                                                    abstract logprob: float with get, set
                                                    abstract token: D1SessionBookmark with get, set

                                module rec Message =
                                    module rec Messages =
                                        type FunctionCall =
                                            abstract arguments: D1SessionBookmark with get, set
                                            abstract name: D1SessionBookmark with get, set

                                    module rec PostProcessedOutputs =
                                        module rec Choices =
                                            module rec Message =
                                                module rec Annotations =
                                                    module rec PostProcessedOutputs =
                                                        module rec Choices =
                                                            module rec Message =
                                                                module rec Annotations =
                                                                    type UrlCitation =
                                                                        [<EmitProperty("end_index")>]
                                                                        abstract endIndex: float with get, set

                                                                        [<EmitProperty("start_index")>]
                                                                        abstract startIndex: float with get, set

                                                                        abstract title: D1SessionBookmark with get, set
                                                                        abstract url: D1SessionBookmark with get, set

                                                type Audio =
                                                    abstract transcript: D1SessionBookmark with get, set

                                                    [<EmitProperty("expires_at")>]
                                                    abstract expiresAt: float with get, set

                                                    abstract data: D1SessionBookmark with get, set
                                                    abstract id: D1SessionBookmark with get, set

                                                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                                type Annotations = | [<CompiledName("url_citation")>] UrlCitation

                                type Message =
                                    [<EmitProperty("function_call")>]
                                    abstract functionCall: option<Message.FunctionCall> with get, set

                                    [<EmitProperty("tool_calls")>]
                                    abstract toolCalls: option<Array<ChatCompletionMessageToolCall>> with get, set

                                    abstract audio: option<ChatCompletionAudio> with get, set
                                    abstract annotations: option<Array<ChatCompletionUrlCitation>> with get, set
                                    abstract refusal: option<string> with get, set
                                    abstract content: option<string> with get, set
                                    abstract role: Message.Role with get, set

                                type Logprobs =
                                    abstract refusal: option<Array<ChatCompletionTokenLogprob>> with get, set
                                    abstract content: option<Array<ChatCompletionTokenLogprob>> with get, set

                    module rec Usage =
                        module rec PostProcessedOutputs =
                            module rec Usage =
                                type PromptTokensDetails =
                                    [<EmitProperty("audio_tokens")>]
                                    abstract audioTokens: option<float> with get, set

                                    [<EmitProperty("cached_tokens")>]
                                    abstract cachedTokens: option<float> with get, set

                                type CompletionTokensDetails =
                                    [<EmitProperty("rejected_prediction_tokens")>]
                                    abstract rejectedPredictionTokens: option<float> with get, set

                                    [<EmitProperty("accepted_prediction_tokens")>]
                                    abstract acceptedPredictionTokens: option<float> with get, set

                                    [<EmitProperty("audio_tokens")>]
                                    abstract audioTokens: option<float> with get, set

                                    [<EmitProperty("reasoning_tokens")>]
                                    abstract reasoningTokens: option<float> with get, set

                    type Choices =
                        abstract logprobs: option<Choices.Logprobs> with get, set

                        [<EmitProperty("finish_reason")>]
                        abstract finishReason: Choices.FinishReason with get, set

                        abstract message: ChatCompletionResponseMessage with get, set
                        abstract index: float with get, set

                    type Usage =
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

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type PostProcessedOutputs =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("default")>] Default
                | [<CompiledName("flex")>] Flex
                | [<CompiledName("scale")>] Scale
                | [<CompiledName("priority")>] Priority

        module rec BaseAiCfMetaLlama3211BVisionInstruct =
            type PostProcessedOutputs =
                [<EmitProperty("tool_calls")>]
                abstract toolCalls: option<Array<PostProcessedOutputs.ToolCalls>> with get, set

                abstract response: option<D1SessionBookmark> with get, set

        module rec BaseAiCfMetaLlama3370BInstructFp8Fast =
            module rec PostProcessedOutputs =
                module rec PostProcessedOutputs =
                    type Usage =
                        [<EmitProperty("total_tokens")>]
                        abstract totalTokens: option<float> with get, set

                        [<EmitProperty("completion_tokens")>]
                        abstract completionTokens: option<float> with get, set

                        [<EmitProperty("prompt_tokens")>]
                        abstract promptTokens: option<float> with get, set

            type PostProcessedOutputs =
                [<EmitProperty("tool_calls")>]
                abstract toolCalls: option<Array<PostProcessedOutputs.ToolCalls>> with get, set

                abstract usage: option<PostProcessedOutputs.Usage> with get, set
                abstract response: D1SessionBookmark with get, set

        module rec BaseAiCfMetaLlama4Scout17B16EInstruct =
            module rec PostProcessedOutputs =
                module rec PostProcessedOutputs =
                    module rec ToolCalls =
                        module rec PostProcessedOutputs =
                            module rec ToolCalls =
                                type Function =
                                    abstract arguments: option<obj> with get, set
                                    abstract name: option<D1SessionBookmark> with get, set

                    type ToolCalls =
                        [<EmitProperty("function")>]
                        abstract ``function``: option<ToolCalls.Function> with get, set

                        [<EmitProperty("type")>]
                        abstract ``type``: option<D1SessionBookmark> with get, set

                        abstract id: option<D1SessionBookmark> with get, set

                    type Usage =
                        [<EmitProperty("total_tokens")>]
                        abstract totalTokens: option<float> with get, set

                        [<EmitProperty("completion_tokens")>]
                        abstract completionTokens: option<float> with get, set

                        [<EmitProperty("prompt_tokens")>]
                        abstract promptTokens: option<float> with get, set

            type PostProcessedOutputs =
                [<EmitProperty("tool_calls")>]
                abstract toolCalls: option<Array<PostProcessedOutputs.ToolCalls>> with get, set

                abstract usage: option<PostProcessedOutputs.Usage> with get, set
                abstract response: D1SessionBookmark with get, set

        module rec BaseAiCfMetaM2M10012B =
            type PostProcessedOutputs =
                [<EmitProperty("translated_text")>]
                abstract translatedText: option<D1SessionBookmark> with get, set

            type Inputs =
                abstract requests: Array<Inputs.Requests> with get, set

                [<EmitProperty("target_lang")>]
                abstract targetLang: D1SessionBookmark with get, set

                [<EmitProperty("source_lang")>]
                abstract sourceLang: option<D1SessionBookmark> with get, set

                abstract text: D1SessionBookmark with get, set

        module rec BaseAiCfMistralaiMistralSmall3124BInstruct =
            module rec PostProcessedOutputs =
                module rec PostProcessedOutputs =
                    type Usage =
                        [<EmitProperty("total_tokens")>]
                        abstract totalTokens: option<float> with get, set

                        [<EmitProperty("completion_tokens")>]
                        abstract completionTokens: option<float> with get, set

                        [<EmitProperty("prompt_tokens")>]
                        abstract promptTokens: option<float> with get, set

            type PostProcessedOutputs =
                [<EmitProperty("tool_calls")>]
                abstract toolCalls: option<Array<PostProcessedOutputs.ToolCalls>> with get, set

                abstract usage: option<PostProcessedOutputs.Usage> with get, set
                abstract response: D1SessionBookmark with get, set

        module rec BaseAiCfMoonshotaiKimiK25 =
            module rec PostProcessedOutputs =
                module rec PostProcessedOutputs =
                    module rec Choices =
                        module rec PostProcessedOutputs =
                            module rec Choices =
                                module rec Logprobs =
                                    module rec PostProcessedOutputs =
                                        module rec Choices =
                                            module rec Logprobs =
                                                module rec Content =
                                                    module rec PostProcessedOutputs =
                                                        module rec Choices =
                                                            module rec Logprobs =
                                                                module rec Content =
                                                                    type TopLogprobs =
                                                                        abstract bytes: option<Array<float>> with get, set
                                                                        abstract logprob: float with get, set
                                                                        abstract token: D1SessionBookmark with get, set

                                                type Content =
                                                    [<EmitProperty("top_logprobs")>]
                                                    abstract topLogprobs: Array<ChatCompletionTopLogprob> with get, set

                                                    abstract bytes: option<Array<float>> with get, set
                                                    abstract logprob: float with get, set
                                                    abstract token: D1SessionBookmark with get, set

                                module rec Message =
                                    module rec Messages =
                                        type FunctionCall =
                                            abstract arguments: D1SessionBookmark with get, set
                                            abstract name: D1SessionBookmark with get, set

                                    module rec PostProcessedOutputs =
                                        module rec Choices =
                                            module rec Message =
                                                module rec Annotations =
                                                    module rec PostProcessedOutputs =
                                                        module rec Choices =
                                                            module rec Message =
                                                                module rec Annotations =
                                                                    type UrlCitation =
                                                                        [<EmitProperty("end_index")>]
                                                                        abstract endIndex: float with get, set

                                                                        [<EmitProperty("start_index")>]
                                                                        abstract startIndex: float with get, set

                                                                        abstract title: D1SessionBookmark with get, set
                                                                        abstract url: D1SessionBookmark with get, set

                                                type Annotations =
                                                    [<EmitProperty("url_citation")>]
                                                    abstract urlCitation: Annotations.UrlCitation with get, set

                                                    [<EmitProperty("type")>]
                                                    abstract ``type``: Annotations.Type with get, set

                                                type Audio =
                                                    abstract transcript: D1SessionBookmark with get, set

                                                    [<EmitProperty("expires_at")>]
                                                    abstract expiresAt: float with get, set

                                                    abstract data: D1SessionBookmark with get, set
                                                    abstract id: D1SessionBookmark with get, set

                                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                type Message = | [<CompiledName("assistant")>] Assistant

                                type Logprobs =
                                    abstract refusal: option<Array<ChatCompletionTokenLogprob>> with get, set
                                    abstract content: option<Array<ChatCompletionTokenLogprob>> with get, set

                    module rec Usage =
                        module rec PostProcessedOutputs =
                            module rec Usage =
                                type PromptTokensDetails =
                                    [<EmitProperty("audio_tokens")>]
                                    abstract audioTokens: option<float> with get, set

                                    [<EmitProperty("cached_tokens")>]
                                    abstract cachedTokens: option<float> with get, set

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
                    type Choices =
                        | [<CompiledName("stop")>] Stop
                        | [<CompiledName("length")>] Length
                        | [<CompiledName("tool_calls")>] ToolCalls
                        | [<CompiledName("content_filter")>] ContentFilter
                        | [<CompiledName("function_call")>] FunctionCall

                    type Usage =
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

            type PostProcessedOutputs =
                [<EmitProperty("service_tier")>]
                abstract serviceTier: option<PostProcessedOutputs.ServiceTier> with get, set

                [<EmitProperty("system_fingerprint")>]
                abstract systemFingerprint: option<string> with get, set

                abstract usage: option<CompletionUsage> with get, set
                abstract choices: Array<ChatCompletionChoice> with get, set
                abstract model: D1SessionBookmark with get, set
                abstract created: float with get, set
                abstract object: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set

        module rec BaseAiCfNvidiaNemotron3120BA12B =
            module rec PostProcessedOutputs =
                module rec PostProcessedOutputs =
                    module rec Choices =
                        module rec PostProcessedOutputs =
                            module rec Choices =
                                module rec Logprobs =
                                    module rec PostProcessedOutputs =
                                        module rec Choices =
                                            module rec Logprobs =
                                                module rec Content =
                                                    module rec PostProcessedOutputs =
                                                        module rec Choices =
                                                            module rec Logprobs =
                                                                module rec Content =
                                                                    type TopLogprobs =
                                                                        abstract bytes: option<Array<float>> with get, set
                                                                        abstract logprob: float with get, set
                                                                        abstract token: D1SessionBookmark with get, set

                                                type Content =
                                                    [<EmitProperty("top_logprobs")>]
                                                    abstract topLogprobs: Array<ChatCompletionTopLogprob> with get, set

                                                    abstract bytes: option<Array<float>> with get, set
                                                    abstract logprob: float with get, set
                                                    abstract token: D1SessionBookmark with get, set

                                module rec Message =
                                    module rec Messages =
                                        type FunctionCall =
                                            abstract arguments: D1SessionBookmark with get, set
                                            abstract name: D1SessionBookmark with get, set

                                    module rec PostProcessedOutputs =
                                        module rec Choices =
                                            module rec Message =
                                                module rec Annotations =
                                                    module rec PostProcessedOutputs =
                                                        module rec Choices =
                                                            module rec Message =
                                                                module rec Annotations =
                                                                    type UrlCitation =
                                                                        [<EmitProperty("end_index")>]
                                                                        abstract endIndex: float with get, set

                                                                        [<EmitProperty("start_index")>]
                                                                        abstract startIndex: float with get, set

                                                                        abstract title: D1SessionBookmark with get, set
                                                                        abstract url: D1SessionBookmark with get, set

                                                type Annotations =
                                                    [<EmitProperty("url_citation")>]
                                                    abstract urlCitation: Annotations.UrlCitation with get, set

                                                    [<EmitProperty("type")>]
                                                    abstract ``type``: Annotations.Type with get, set

                                                type Audio =
                                                    abstract transcript: D1SessionBookmark with get, set

                                                    [<EmitProperty("expires_at")>]
                                                    abstract expiresAt: float with get, set

                                                    abstract data: D1SessionBookmark with get, set
                                                    abstract id: D1SessionBookmark with get, set

                                type Logprobs =
                                    abstract refusal: option<Array<ChatCompletionTokenLogprob>> with get, set
                                    abstract content: option<Array<ChatCompletionTokenLogprob>> with get, set

                                type Message =
                                    [<EmitProperty("function_call")>]
                                    abstract functionCall: option<Message.FunctionCall> with get, set

                                    [<EmitProperty("tool_calls")>]
                                    abstract toolCalls: option<Array<ChatCompletionMessageToolCall>> with get, set

                                    abstract audio: option<ChatCompletionAudio> with get, set
                                    abstract annotations: option<Array<ChatCompletionUrlCitation>> with get, set
                                    abstract refusal: option<string> with get, set
                                    abstract content: option<string> with get, set
                                    abstract role: Message.Role with get, set

                    module rec Usage =
                        module rec PostProcessedOutputs =
                            module rec Usage =
                                type PromptTokensDetails =
                                    [<EmitProperty("audio_tokens")>]
                                    abstract audioTokens: option<float> with get, set

                                    [<EmitProperty("cached_tokens")>]
                                    abstract cachedTokens: option<float> with get, set

                                type CompletionTokensDetails =
                                    [<EmitProperty("rejected_prediction_tokens")>]
                                    abstract rejectedPredictionTokens: option<float> with get, set

                                    [<EmitProperty("accepted_prediction_tokens")>]
                                    abstract acceptedPredictionTokens: option<float> with get, set

                                    [<EmitProperty("audio_tokens")>]
                                    abstract audioTokens: option<float> with get, set

                                    [<EmitProperty("reasoning_tokens")>]
                                    abstract reasoningTokens: option<float> with get, set

                    type Choices =
                        abstract logprobs: option<Choices.Logprobs> with get, set

                        [<EmitProperty("finish_reason")>]
                        abstract finishReason: Choices.FinishReason with get, set

                        abstract message: ChatCompletionResponseMessage with get, set
                        abstract index: float with get, set

                    type Usage =
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

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type PostProcessedOutputs =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("default")>] Default
                | [<CompiledName("flex")>] Flex
                | [<CompiledName("scale")>] Scale
                | [<CompiledName("priority")>] Priority

        module rec BaseAiCfOpenaiGptOss20B =
            module rec Audio =
                type Voice =
                    abstract id: D1SessionBookmark with get, set

            module rec Instructions =
                module rec Instructions =
                    module rec Content =
                        module rec Instructions =
                            module rec Content =
                                module rec Logprobs =
                                    module rec Instructions =
                                        module rec Content =
                                            module rec Logprobs =
                                                type TopLogprobs =
                                                    abstract logprob: option<float> with get, set
                                                    abstract token: option<D1SessionBookmark> with get, set

                                type Logprobs =
                                    [<EmitProperty("top_logprobs")>]
                                    abstract topLogprobs: option<Array<TopLogprob>> with get, set

                                    abstract logprob: float with get, set
                                    abstract token: D1SessionBookmark with get, set

                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                    type Content =
                        | [<CompiledName("reasoning_text")>] ReasoningText
                        | [<CompiledName("output_text")>] OutputText
                        | [<CompiledName("refusal")>] Refusal

                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                    type Summary = | [<CompiledName("summary_text")>] SummaryText

            module rec PostProcessedOutputs =
                module rec Usage =
                    module rec PostProcessedOutputs =
                        module rec Usage =
                            type PromptTokensDetails =
                                [<EmitProperty("audio_tokens")>]
                                abstract audioTokens: option<float> with get, set

                                [<EmitProperty("cached_tokens")>]
                                abstract cachedTokens: option<float> with get, set

                            type CompletionTokensDetails =
                                [<EmitProperty("rejected_prediction_tokens")>]
                                abstract rejectedPredictionTokens: option<float> with get, set

                                [<EmitProperty("accepted_prediction_tokens")>]
                                abstract acceptedPredictionTokens: option<float> with get, set

                                [<EmitProperty("audio_tokens")>]
                                abstract audioTokens: option<float> with get, set

                                [<EmitProperty("reasoning_tokens")>]
                                abstract reasoningTokens: option<float> with get, set

                type Usage =
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

            module rec Prediction =
                module rec Search =
                    module rec Data =
                        type Content =
                            abstract text: D1SessionBookmark with get, set

                            [<EmitProperty("type")>]
                            abstract ``type``: Content.Type with get, set

            module rec Prompt =
                module rec Prompt =
                    module rec Variables =
                        module rec Prompt =
                            module rec Variables =
                                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                type Item =
                                    | [<CompiledName("input_image")>] InputImage
                                    | [<CompiledName("low")>] Low
                                    | [<CompiledName("high")>] High
                                    | [<CompiledName("auto")>] Auto
                                    | [<CompiledName("input_text")>] InputText

                    type Variables =
                        abstract Item: key: D1SessionBookmark -> U3<Variables.Item, Variables.Item, string>

            module rec Text =
                module rec Text =
                    module rec Format =
                        module rec Text =
                            module rec Format =
                                type Schema =
                                    abstract Item: key: D1SessionBookmark -> option<obj>

                    type Format =
                        [<EmitProperty("type")>]
                        abstract ``type``: Format.Type with get, set

                        abstract strict: option<bool> with get, set
                        abstract description: option<D1SessionBookmark> with get, set
                        abstract schema: Format.Schema with get, set
                        abstract name: D1SessionBookmark with get, set

            module rec WebSearchOptions =
                module rec WebSearchOptions =
                    module rec UserLocation =
                        module rec WebSearchOptions =
                            module rec UserLocation =
                                type Approximate =
                                    abstract timezone: option<D1SessionBookmark> with get, set
                                    abstract region: option<D1SessionBookmark> with get, set
                                    abstract country: option<D1SessionBookmark> with get, set
                                    abstract city: option<D1SessionBookmark> with get, set

                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                    type UserLocation = | [<CompiledName("approximate")>] Approximate

            type ChatTemplateKwargs =
                [<EmitProperty("clear_thinking")>]
                abstract clearThinking: option<bool> with get, set

                [<EmitProperty("enable_thinking")>]
                abstract enableThinking: option<bool> with get, set

            type Prediction =
                abstract content: U2<Array<ChatCompletionContentPartText>, string> with get, set

                [<EmitProperty("type")>]
                abstract ``type``: Prediction.Type with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ToolChoice = | [<CompiledName("function")>] Function

            type Audio =
                abstract format: Audio.Format with get, set
                abstract voice: U2<Audio.Voice, string> with get, set

            type Prompt =
                abstract version: option<string> with get, set
                abstract variables: option<Prompt.Variables> with get, set
                abstract id: D1SessionBookmark with get, set

            type Tools =
                abstract description: option<string> with get, set

                [<EmitProperty("type")>]
                abstract ``type``: Tools.Type with get, set

                abstract strict: option<bool> with get, set
                abstract parameters: option<Tools.Parameters> with get, set
                abstract name: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Instructions =
                | [<CompiledName("in_progress")>] InProgress
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("incomplete")>] Incomplete
                | [<CompiledName("function_call_output")>] FunctionCallOutput
                | [<CompiledName("user")>] User
                | [<CompiledName("system")>] System
                | [<CompiledName("developer")>] Developer
                | [<CompiledName("assistant")>] Assistant
                | [<CompiledName("reasoning")>] Reasoning
                | [<CompiledName("function_call")>] FunctionCall
                | [<CompiledName("message")>] Message

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type IncompleteDetails =
                | [<CompiledName("max_output_tokens")>] MaxOutputTokens
                | [<CompiledName("content_filter")>] ContentFilter

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Error =
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

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type WebSearchOptions =
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium")>] Medium
                | [<CompiledName("high")>] High

            type StreamOptions =
                [<EmitProperty("include_obfuscation")>]
                abstract includeObfuscation: option<bool> with get, set

                [<EmitProperty("include_usage")>]
                abstract includeUsage: option<bool> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Text =
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium")>] Medium
                | [<CompiledName("high")>] High

            type Reasoning =
                abstract summary: option<Reasoning.Summary> with get, set

                [<EmitProperty("generate_summary")>]
                abstract generateSummary: option<Reasoning.GenerateSummary> with get, set

                abstract effort: option<Reasoning.Effort> with get, set

            type Usage =
                [<EmitProperty("total_tokens")>]
                abstract totalTokens: float with get, set

                [<EmitProperty("output_tokens")>]
                abstract outputTokens: float with get, set

                [<EmitProperty("input_tokens")>]
                abstract inputTokens: float with get, set

        module rec BaseAiCfOpenaiWhisper =
            type Inputs =
                abstract audio: AiSentenceSimilarityOutput with get, set

        module rec BaseAiCfOpenaiWhisperTinyEn =
            type Inputs =
                abstract audio: AiSentenceSimilarityOutput with get, set

        module rec BaseAiCfPipecatAiSmartTurnV2 =
            module rec Inputs =
                module rec Inputs =
                    type Audio =
                        abstract contentType: D1SessionBookmark with get, set
                        abstract body: obj with get, set

            type Inputs =
                abstract dtype: option<Inputs.Dtype> with get, set
                abstract audio: D1SessionBookmark with get, set
                abstract audio: Inputs.Audio with get, set

        module rec BaseAiCfQwenQwen25Coder32BInstruct =
            module rec PostProcessedOutputs =
                module rec PostProcessedOutputs =
                    type Usage =
                        [<EmitProperty("total_tokens")>]
                        abstract totalTokens: option<float> with get, set

                        [<EmitProperty("completion_tokens")>]
                        abstract completionTokens: option<float> with get, set

                        [<EmitProperty("prompt_tokens")>]
                        abstract promptTokens: option<float> with get, set

            type PostProcessedOutputs =
                [<EmitProperty("tool_calls")>]
                abstract toolCalls: option<Array<PostProcessedOutputs.ToolCalls>> with get, set

                abstract usage: option<PostProcessedOutputs.Usage> with get, set
                abstract response: D1SessionBookmark with get, set

        module rec BaseAiCfQwenQwq32B =
            module rec PostProcessedOutputs =
                module rec PostProcessedOutputs =
                    type Usage =
                        [<EmitProperty("total_tokens")>]
                        abstract totalTokens: option<float> with get, set

                        [<EmitProperty("completion_tokens")>]
                        abstract completionTokens: option<float> with get, set

                        [<EmitProperty("prompt_tokens")>]
                        abstract promptTokens: option<float> with get, set

            type PostProcessedOutputs =
                [<EmitProperty("tool_calls")>]
                abstract toolCalls: option<Array<PostProcessedOutputs.ToolCalls>> with get, set

                abstract usage: option<PostProcessedOutputs.Usage> with get, set
                abstract response: D1SessionBookmark with get, set

        module rec BaseAiCfUnumUformGen2Qwen500M =
            type Inputs =
                [<EmitProperty("max_tokens")>]
                abstract maxTokens: option<float> with get, set

                abstract image: U2<Array<float>, Inputs.Image> with get, set

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

        module rec BaseAiCfZaiOrgGlm47Flash =
            module rec PostProcessedOutputs =
                module rec PostProcessedOutputs =
                    module rec Choices =
                        module rec PostProcessedOutputs =
                            module rec Choices =
                                module rec Logprobs =
                                    module rec PostProcessedOutputs =
                                        module rec Choices =
                                            module rec Logprobs =
                                                module rec Content =
                                                    module rec PostProcessedOutputs =
                                                        module rec Choices =
                                                            module rec Logprobs =
                                                                module rec Content =
                                                                    type TopLogprobs =
                                                                        abstract bytes: option<Array<float>> with get, set
                                                                        abstract logprob: float with get, set
                                                                        abstract token: D1SessionBookmark with get, set

                                                type Content =
                                                    [<EmitProperty("top_logprobs")>]
                                                    abstract topLogprobs: Array<ChatCompletionTopLogprob> with get, set

                                                    abstract bytes: option<Array<float>> with get, set
                                                    abstract logprob: float with get, set
                                                    abstract token: D1SessionBookmark with get, set

                                module rec Message =
                                    module rec Messages =
                                        type FunctionCall =
                                            abstract arguments: D1SessionBookmark with get, set
                                            abstract name: D1SessionBookmark with get, set

                                    module rec PostProcessedOutputs =
                                        module rec Choices =
                                            module rec Message =
                                                module rec Annotations =
                                                    module rec PostProcessedOutputs =
                                                        module rec Choices =
                                                            module rec Message =
                                                                module rec Annotations =
                                                                    type UrlCitation =
                                                                        [<EmitProperty("end_index")>]
                                                                        abstract endIndex: float with get, set

                                                                        [<EmitProperty("start_index")>]
                                                                        abstract startIndex: float with get, set

                                                                        abstract title: D1SessionBookmark with get, set
                                                                        abstract url: D1SessionBookmark with get, set

                                                type Audio =
                                                    abstract transcript: D1SessionBookmark with get, set

                                                    [<EmitProperty("expires_at")>]
                                                    abstract expiresAt: float with get, set

                                                    abstract data: D1SessionBookmark with get, set
                                                    abstract id: D1SessionBookmark with get, set

                                                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                                type Annotations = | [<CompiledName("url_citation")>] UrlCitation

                                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                type Message = | [<CompiledName("assistant")>] Assistant

                                type Logprobs =
                                    abstract refusal: option<Array<ChatCompletionTokenLogprob>> with get, set
                                    abstract content: option<Array<ChatCompletionTokenLogprob>> with get, set

                    module rec Usage =
                        module rec PostProcessedOutputs =
                            module rec Usage =
                                type CompletionTokensDetails =
                                    [<EmitProperty("rejected_prediction_tokens")>]
                                    abstract rejectedPredictionTokens: option<float> with get, set

                                    [<EmitProperty("accepted_prediction_tokens")>]
                                    abstract acceptedPredictionTokens: option<float> with get, set

                                    [<EmitProperty("audio_tokens")>]
                                    abstract audioTokens: option<float> with get, set

                                    [<EmitProperty("reasoning_tokens")>]
                                    abstract reasoningTokens: option<float> with get, set

                                type PromptTokensDetails =
                                    [<EmitProperty("audio_tokens")>]
                                    abstract audioTokens: option<float> with get, set

                                    [<EmitProperty("cached_tokens")>]
                                    abstract cachedTokens: option<float> with get, set

                    type Choices =
                        abstract logprobs: option<Choices.Logprobs> with get, set

                        [<EmitProperty("finish_reason")>]
                        abstract finishReason: Choices.FinishReason with get, set

                        abstract message: ChatCompletionResponseMessage with get, set
                        abstract index: float with get, set

                    type Usage =
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

            type PostProcessedOutputs =
                [<EmitProperty("service_tier")>]
                abstract serviceTier: option<PostProcessedOutputs.ServiceTier> with get, set

                [<EmitProperty("system_fingerprint")>]
                abstract systemFingerprint: option<string> with get, set

                abstract usage: option<CompletionUsage> with get, set
                abstract choices: Array<ChatCompletionChoice> with get, set
                abstract model: D1SessionBookmark with get, set
                abstract created: float with get, set
                abstract object: D1SessionBookmark with get, set
                abstract id: D1SessionBookmark with get, set

        module rec BaseAiImageClassification =
            type PostProcessedOutputs =
                abstract label: option<D1SessionBookmark> with get, set
                abstract score: option<float> with get, set

            type Inputs =
                abstract image: AiSentenceSimilarityOutput with get, set

        module rec BaseAiImageTextToText =
            type Inputs =
                abstract messages: option<Array<RoleScopedChatInput>> with get, set
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

            type PostProcessedOutputs =
                abstract description: D1SessionBookmark with get, set

        module rec BaseAiImageToText =
            module rec Inputs =
                module rec Inputs =
                    type Messages =
                        abstract name: option<D1SessionBookmark> with get, set
                        abstract content: D1SessionBookmark with get, set
                        abstract role: U2<Messages.Role, Messages.Role> with get, set

            type PostProcessedOutputs =
                abstract description: D1SessionBookmark with get, set

            type Inputs =
                abstract messages: option<Array<RoleScopedChatInput>> with get, set
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

        module rec BaseAiMultimodalEmbeddings =
            type Inputs =
                abstract messages: option<Array<RoleScopedChatInput>> with get, set
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

            type PostProcessedOutputs =
                abstract description: D1SessionBookmark with get, set

        module rec BaseAiObjectDetection =
            type Inputs =
                abstract image: AiSentenceSimilarityOutput with get, set

            type PostProcessedOutputs =
                abstract label: option<D1SessionBookmark> with get, set
                abstract score: option<float> with get, set

        module rec BaseAiSentenceSimilarity =
            type Inputs =
                abstract sentences: Array<D1SessionBookmark> with get, set
                abstract source: D1SessionBookmark with get, set

        module rec BaseAiSummarization =
            type PostProcessedOutputs =
                abstract summary: D1SessionBookmark with get, set

            type Inputs =
                [<EmitProperty("max_length")>]
                abstract maxLength: option<float> with get, set

                [<EmitProperty("input_text")>]
                abstract inputText: D1SessionBookmark with get, set

        module rec BaseAiTextClassification =
            type PostProcessedOutputs =
                abstract label: option<D1SessionBookmark> with get, set
                abstract score: option<float> with get, set

            type Inputs =
                abstract text: D1SessionBookmark with get, set

        module rec BaseAiTextEmbeddings =
            type Inputs =
                abstract text: U2<Array<D1SessionBookmark>, string> with get, set

            type PostProcessedOutputs =
                abstract data: Array<AiSentenceSimilarityOutput> with get, set
                abstract shape: AiSentenceSimilarityOutput with get, set

        module rec BaseAiTextGeneration =
            module rec Inputs =
                module rec Inputs =
                    module rec Tools =
                        module rec Inputs =
                            module rec Tools =
                                module rec Function =
                                    module rec Inputs =
                                        module rec Tools =
                                            module rec Function =
                                                module rec Parameters =
                                                    module rec Inputs =
                                                        module rec Tools =
                                                            module rec Function =
                                                                module rec Parameters =
                                                                    module rec Properties =
                                                                        module rec Inputs =
                                                                            module rec Tools =
                                                                                module rec Function =
                                                                                    module rec Parameters =
                                                                                        module rec Properties =
                                                                                            type Item =
                                                                                                abstract description:
                                                                                                    option<
                                                                                                        D1SessionBookmark
                                                                                                     > with get, set

                                                                                                [<EmitProperty("type")>]
                                                                                                abstract ``type``:
                                                                                                    D1SessionBookmark with get, set

                                                                    type Properties =
                                                                        abstract Item:
                                                                            key: D1SessionBookmark -> Properties.Item

                                                type Parameters =
                                                    abstract required: Array<D1SessionBookmark> with get, set
                                                    abstract properties: Parameters.Properties with get, set

                                                    [<EmitProperty("type")>]
                                                    abstract ``type``: U2<Parameters.Type, Parameters.Type> with get, set

                                type Function =
                                    abstract parameters: option<Function.Parameters> with get, set
                                    abstract description: D1SessionBookmark with get, set
                                    abstract name: D1SessionBookmark with get, set

                    type Functions =
                        abstract code: D1SessionBookmark with get, set
                        abstract name: D1SessionBookmark with get, set

                    type ResponseFormat =
                        [<EmitProperty("json_schema")>]
                        abstract jsonSchema: option<obj> with get, set

                        [<EmitProperty("type")>]
                        abstract ``type``: D1SessionBookmark with get, set

                    type Tools =
                        abstract parameters: option<Tools.Parameters> with get, set
                        abstract description: D1SessionBookmark with get, set
                        abstract name: D1SessionBookmark with get, set

                        [<EmitProperty("function")>]
                        abstract ``function``: Tools.Function with get, set

                        [<EmitProperty("type")>]
                        abstract ``type``: U2<Tools.Type, Tools.Type> with get, set

            module rec PostProcessedOutputs =
                module rec PostProcessedOutputs =
                    type Usage =
                        [<EmitProperty("total_tokens")>]
                        abstract totalTokens: float with get, set

                        [<EmitProperty("completion_tokens")>]
                        abstract completionTokens: float with get, set

                        [<EmitProperty("prompt_tokens")>]
                        abstract promptTokens: float with get, set

            type PostProcessedOutputs =
                abstract usage: option<UsageTags> with get, set

                [<EmitProperty("tool_calls")>]
                abstract toolCalls: option<PostProcessedOutputs.ToolCalls> with get, set

                abstract response: option<D1SessionBookmark> with get, set

            type Inputs =
                abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set

                abstract tools:
                    option<U3<Array<AiTextGenerationToolInput>, Array<AiTextGenerationToolLegacyInput>, obj>> with get, set

                [<EmitProperty("response_format")>]
                abstract responseFormat: option<AiTextGenerationResponseFormat> with get, set

                abstract messages: option<Array<RoleScopedChatInput>> with get, set

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

        module rec BaseAiTextToImage =
            type Inputs =
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

        module rec BaseAiTextToSpeech =
            type Inputs =
                abstract lang: option<D1SessionBookmark> with get, set
                abstract prompt: D1SessionBookmark with get, set

            type PostProcessedOutputs =
                abstract audio: D1SessionBookmark with get, set

        module rec BaseAiTranslation =
            type Inputs =
                [<EmitProperty("source_lang")>]
                abstract sourceLang: option<D1SessionBookmark> with get, set

                [<EmitProperty("target_lang")>]
                abstract targetLang: D1SessionBookmark with get, set

                abstract text: D1SessionBookmark with get, set

            type PostProcessedOutputs =
                [<EmitProperty("translated_text")>]
                abstract translatedText: option<D1SessionBookmark> with get, set

        module rec ChatCompletionChoice =
            module rec PostProcessedOutputs =
                module rec Choices =
                    module rec Message =
                        module rec Messages =
                            type FunctionCall =
                                abstract arguments: D1SessionBookmark with get, set
                                abstract name: D1SessionBookmark with get, set

                        module rec PostProcessedOutputs =
                            module rec Choices =
                                module rec Message =
                                    module rec Annotations =
                                        module rec PostProcessedOutputs =
                                            module rec Choices =
                                                module rec Message =
                                                    module rec Annotations =
                                                        type UrlCitation =
                                                            [<EmitProperty("end_index")>]
                                                            abstract endIndex: float with get, set

                                                            [<EmitProperty("start_index")>]
                                                            abstract startIndex: float with get, set

                                                            abstract title: D1SessionBookmark with get, set
                                                            abstract url: D1SessionBookmark with get, set

                                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                    type Annotations = | [<CompiledName("url_citation")>] UrlCitation

                                    type Audio =
                                        abstract transcript: D1SessionBookmark with get, set

                                        [<EmitProperty("expires_at")>]
                                        abstract expiresAt: float with get, set

                                        abstract data: D1SessionBookmark with get, set
                                        abstract id: D1SessionBookmark with get, set

                    type Message =
                        [<EmitProperty("function_call")>]
                        abstract functionCall: option<Message.FunctionCall> with get, set

                        [<EmitProperty("tool_calls")>]
                        abstract toolCalls: option<Array<ChatCompletionMessageToolCall>> with get, set

                        abstract audio: option<ChatCompletionAudio> with get, set
                        abstract annotations: option<Array<ChatCompletionUrlCitation>> with get, set
                        abstract refusal: option<string> with get, set
                        abstract content: option<string> with get, set
                        abstract role: Message.Role with get, set

        module rec ChatCompletionContentPart =
            module rec Messages =
                module rec Content =
                    type File =
                        abstract filename: option<D1SessionBookmark> with get, set

                        [<EmitProperty("file_id")>]
                        abstract fileId: option<D1SessionBookmark> with get, set

                        [<EmitProperty("file_data")>]
                        abstract fileData: option<D1SessionBookmark> with get, set

            module rec Search =
                module rec Data =
                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                    type Content = | [<CompiledName("text")>] Text

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type InputAudio =
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("mp3")>] Mp3

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ImageUrl =
                | [<CompiledName("auto")>] Auto
                | [<CompiledName("low")>] Low
                | [<CompiledName("high")>] High

        module rec ChatCompletionContentPartFile =
            module rec Messages =
                module rec Content =
                    type File =
                        abstract filename: option<D1SessionBookmark> with get, set

                        [<EmitProperty("file_id")>]
                        abstract fileId: option<D1SessionBookmark> with get, set

                        [<EmitProperty("file_data")>]
                        abstract fileData: option<D1SessionBookmark> with get, set

        module rec ChatCompletionContentPartImage =
            type ImageUrl =
                abstract detail: option<ImageUrl.Detail> with get, set
                abstract url: D1SessionBookmark with get, set

        module rec ChatCompletionContentPartInputAudio =
            type InputAudio =
                abstract format: InputAudio.Format with get, set
                abstract data: D1SessionBookmark with get, set

        module rec ChatCompletionCustomTool =
            module rec Tools =
                module rec Custom =
                    module rec Tools =
                        module rec Custom =
                            module rec Format =
                                module rec Tools =
                                    module rec Custom =
                                        module rec Format =
                                            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                            type Grammar =
                                                | [<CompiledName("lark")>] Lark
                                                | [<CompiledName("regex")>] Regex

                            type Format =
                                [<EmitProperty("type")>]
                                abstract ``type``: Format.Type with get, set

                                abstract grammar: Format.Grammar with get, set

                type Custom =
                    abstract format: option<ChatCompletionCustomToolFormat> with get, set
                    abstract description: option<D1SessionBookmark> with get, set
                    abstract name: D1SessionBookmark with get, set

        module rec ChatCompletionCustomToolGrammarFormat =
            module rec Tools =
                module rec Custom =
                    module rec Format =
                        type Grammar =
                            abstract syntax: Grammar.Syntax with get, set
                            abstract definition: D1SessionBookmark with get, set

        module rec ChatCompletionFunctionTool =
            type Functions =
                abstract strict: option<bool> with get, set
                abstract parameters: option<WebAssembly.ModuleImports> with get, set
                abstract description: option<D1SessionBookmark> with get, set
                abstract name: D1SessionBookmark with get, set

        module rec ChatCompletionMessageCustomToolCall =
            module rec Messages =
                module rec ToolCalls =
                    type Custom =
                        abstract input: D1SessionBookmark with get, set
                        abstract name: D1SessionBookmark with get, set

        module rec ChatCompletionMessageFunctionToolCall =
            module rec Messages =
                type FunctionCall =
                    abstract arguments: D1SessionBookmark with get, set
                    abstract name: D1SessionBookmark with get, set

        module rec ChatCompletionResponseMessage =
            module rec PostProcessedOutputs =
                module rec Choices =
                    module rec Message =
                        type Audio =
                            abstract transcript: D1SessionBookmark with get, set

                            [<EmitProperty("expires_at")>]
                            abstract expiresAt: float with get, set

                            abstract data: D1SessionBookmark with get, set
                            abstract id: D1SessionBookmark with get, set

        module rec ChatCompletionToolChoiceAllowedTools =
            module rec ToolChoice =
                module rec AllowedTools =
                    type Params =
                        abstract Item: key: D1SessionBookmark -> option<obj>

                type AllowedTools =
                    abstract tools: Array<WebAssembly.ModuleImports> with get, set
                    abstract mode: AllowedTools.Mode with get, set

        module rec ChatCompletionToolChoiceCustom =
            type FunctionCall =
                abstract name: D1SessionBookmark with get, set

        module rec ChatCompletionToolChoiceFunction =
            type FunctionCall =
                abstract name: D1SessionBookmark with get, set

        module rec ChatCompletionToolChoiceOption =
            module rec ToolChoice =
                module rec ToolChoice =
                    module rec AllowedTools =
                        type Params =
                            abstract Item: key: D1SessionBookmark -> option<obj>

                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                    type AllowedTools =
                        | [<CompiledName("auto")>] Auto
                        | [<CompiledName("required")>] Required

                type FunctionCall =
                    abstract name: D1SessionBookmark with get, set

            type ToolChoice =
                [<EmitProperty("function")>]
                abstract ``function``: ToolChoice.Function with get, set

                [<EmitProperty("type")>]
                abstract ``type``: ToolChoice.Type with get, set

                [<EmitProperty("allowed_tools")>]
                abstract allowedTools: ToolChoice.AllowedTools with get, set

                abstract custom: ToolChoice.Custom with get, set

        module rec ChatCompletionUrlCitation =
            module rec PostProcessedOutputs =
                module rec Choices =
                    module rec Message =
                        module rec Annotations =
                            type UrlCitation =
                                [<EmitProperty("end_index")>]
                                abstract endIndex: float with get, set

                                [<EmitProperty("start_index")>]
                                abstract startIndex: float with get, set

                                abstract title: D1SessionBookmark with get, set
                                abstract url: D1SessionBookmark with get, set

        module rec ChatCompletionsBase =
            module rec Audio =
                module rec Audio =
                    type Voice =
                        abstract id: D1SessionBookmark with get, set

            module rec Prediction =
                module rec Search =
                    module rec Data =
                        type Content =
                            abstract text: D1SessionBookmark with get, set

                            [<EmitProperty("type")>]
                            abstract ``type``: Content.Type with get, set

            module rec WebSearchOptions =
                module rec WebSearchOptions =
                    module rec UserLocation =
                        module rec WebSearchOptions =
                            module rec UserLocation =
                                type Approximate =
                                    abstract timezone: option<D1SessionBookmark> with get, set
                                    abstract region: option<D1SessionBookmark> with get, set
                                    abstract country: option<D1SessionBookmark> with get, set
                                    abstract city: option<D1SessionBookmark> with get, set

                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                    type UserLocation = | [<CompiledName("approximate")>] Approximate

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type WebSearchOptions =
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium")>] Medium
                | [<CompiledName("high")>] High

            type StreamOptions =
                [<EmitProperty("include_obfuscation")>]
                abstract includeObfuscation: option<bool> with get, set

                [<EmitProperty("include_usage")>]
                abstract includeUsage: option<bool> with get, set

            type ChatTemplateKwargs =
                [<EmitProperty("clear_thinking")>]
                abstract clearThinking: option<bool> with get, set

                [<EmitProperty("enable_thinking")>]
                abstract enableThinking: option<bool> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Prediction = | [<CompiledName("content")>] Content

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Audio =
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("aac")>] Aac
                | [<CompiledName("mp3")>] Mp3
                | [<CompiledName("flac")>] Flac
                | [<CompiledName("opus")>] Opus
                | [<CompiledName("pcm16")>] Pcm16

        module rec ChatCompletionsCommonOptions =
            module rec Audio =
                module rec Audio =
                    type Voice =
                        abstract id: D1SessionBookmark with get, set

            module rec Prediction =
                module rec Search =
                    module rec Data =
                        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                        type Content = | [<CompiledName("text")>] Text

            module rec ResponseFormat =
                module rec ResponseFormat =
                    type JsonSchema =
                        abstract strict: option<bool> with get, set
                        abstract schema: option<WebAssembly.ModuleImports> with get, set
                        abstract description: option<D1SessionBookmark> with get, set
                        abstract name: D1SessionBookmark with get, set

            module rec ToolChoice =
                module rec ToolChoice =
                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                    type AllowedTools =
                        | [<CompiledName("auto")>] Auto
                        | [<CompiledName("required")>] Required

                type FunctionCall =
                    abstract name: D1SessionBookmark with get, set

            module rec Tools =
                module rec Tools =
                    module rec Custom =
                        module rec Tools =
                            module rec Custom =
                                module rec Format =
                                    module rec Tools =
                                        module rec Custom =
                                            module rec Format =
                                                type Grammar =
                                                    abstract syntax: Grammar.Syntax with get, set
                                                    abstract definition: D1SessionBookmark with get, set

                                type Format =
                                    [<EmitProperty("type")>]
                                    abstract ``type``: Format.Type with get, set

                                    abstract grammar: Format.Grammar with get, set

                    type Custom =
                        abstract format: option<ChatCompletionCustomToolFormat> with get, set
                        abstract description: option<D1SessionBookmark> with get, set
                        abstract name: D1SessionBookmark with get, set

                type Functions =
                    abstract strict: option<bool> with get, set
                    abstract parameters: option<WebAssembly.ModuleImports> with get, set
                    abstract description: option<D1SessionBookmark> with get, set
                    abstract name: D1SessionBookmark with get, set

            module rec WebSearchOptions =
                module rec WebSearchOptions =
                    module rec UserLocation =
                        module rec WebSearchOptions =
                            module rec UserLocation =
                                type Approximate =
                                    abstract timezone: option<D1SessionBookmark> with get, set
                                    abstract region: option<D1SessionBookmark> with get, set
                                    abstract country: option<D1SessionBookmark> with get, set
                                    abstract city: option<D1SessionBookmark> with get, set

                    type UserLocation =
                        abstract approximate: UserLocation.Approximate with get, set

                        [<EmitProperty("type")>]
                        abstract ``type``: UserLocation.Type with get, set

            type StreamOptions =
                [<EmitProperty("include_obfuscation")>]
                abstract includeObfuscation: option<bool> with get, set

                [<EmitProperty("include_usage")>]
                abstract includeUsage: option<bool> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ToolChoice =
                | [<CompiledName("custom")>] Custom
                | [<CompiledName("allowed_tools")>] AllowedTools
                | [<CompiledName("function")>] Function

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Prediction = | [<CompiledName("content")>] Content

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Audio =
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("aac")>] Aac
                | [<CompiledName("mp3")>] Mp3
                | [<CompiledName("flac")>] Flac
                | [<CompiledName("opus")>] Opus
                | [<CompiledName("pcm16")>] Pcm16

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ResponseFormat =
                | [<CompiledName("json_schema")>] JsonSchema
                | [<CompiledName("json_object")>] JsonObject

            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

            type WebSearchOptions =
                [<EmitProperty("user_location")>]
                abstract userLocation: option<WebSearchUserLocation> with get, set

                [<EmitProperty("search_context_size")>]
                abstract searchContextSize: option<WebSearchOptions.SearchContextSize> with get, set

            type Tools =
                [<EmitProperty("function")>]
                abstract ``function``: FunctionDefinition with get, set

                [<EmitProperty("type")>]
                abstract ``type``: Tools.Type with get, set

                abstract custom: Tools.Custom with get, set

            type ChatTemplateKwargs =
                [<EmitProperty("clear_thinking")>]
                abstract clearThinking: option<bool> with get, set

                [<EmitProperty("enable_thinking")>]
                abstract enableThinking: option<bool> with get, set

        module rec ChatCompletionsInput =
            module rec Audio =
                module rec Audio =
                    type Voice =
                        abstract id: D1SessionBookmark with get, set

            module rec Prediction =
                module rec Search =
                    module rec Data =
                        type Content =
                            abstract text: D1SessionBookmark with get, set

                            [<EmitProperty("type")>]
                            abstract ``type``: Content.Type with get, set

            module rec WebSearchOptions =
                module rec WebSearchOptions =
                    module rec UserLocation =
                        module rec WebSearchOptions =
                            module rec UserLocation =
                                type Approximate =
                                    abstract timezone: option<D1SessionBookmark> with get, set
                                    abstract region: option<D1SessionBookmark> with get, set
                                    abstract country: option<D1SessionBookmark> with get, set
                                    abstract city: option<D1SessionBookmark> with get, set

                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                    type UserLocation = | [<CompiledName("approximate")>] Approximate

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Prediction = | [<CompiledName("content")>] Content

            type WebSearchOptions =
                [<EmitProperty("user_location")>]
                abstract userLocation: option<WebSearchUserLocation> with get, set

                [<EmitProperty("search_context_size")>]
                abstract searchContextSize: option<WebSearchOptions.SearchContextSize> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Audio =
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("aac")>] Aac
                | [<CompiledName("mp3")>] Mp3
                | [<CompiledName("flac")>] Flac
                | [<CompiledName("opus")>] Opus
                | [<CompiledName("pcm16")>] Pcm16

            type ChatTemplateKwargs =
                [<EmitProperty("clear_thinking")>]
                abstract clearThinking: option<bool> with get, set

                [<EmitProperty("enable_thinking")>]
                abstract enableThinking: option<bool> with get, set

            type StreamOptions =
                [<EmitProperty("include_obfuscation")>]
                abstract includeObfuscation: option<bool> with get, set

                [<EmitProperty("include_usage")>]
                abstract includeUsage: option<bool> with get, set

        module rec ChatCompletionsMessagesInput =
            module rec Messages =
                module rec Audio =
                    type Voice =
                        abstract id: D1SessionBookmark with get, set

                module rec Messages =
                    module rec Content =
                        module rec Messages =
                            module rec Content =
                                type File =
                                    abstract filename: option<D1SessionBookmark> with get, set

                                    [<EmitProperty("file_id")>]
                                    abstract fileId: option<D1SessionBookmark> with get, set

                                    [<EmitProperty("file_data")>]
                                    abstract fileData: option<D1SessionBookmark> with get, set

                                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                type InputAudio =
                                    | [<CompiledName("wav")>] Wav
                                    | [<CompiledName("mp3")>] Mp3

                                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                type ImageUrl =
                                    | [<CompiledName("auto")>] Auto
                                    | [<CompiledName("low")>] Low
                                    | [<CompiledName("high")>] High

                    module rec ToolCalls =
                        module rec Messages =
                            module rec ToolCalls =
                                type Custom =
                                    abstract input: D1SessionBookmark with get, set
                                    abstract name: D1SessionBookmark with get, set

                            type FunctionCall =
                                abstract arguments: D1SessionBookmark with get, set
                                abstract name: D1SessionBookmark with get, set

                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                    type ToolCalls =
                        | [<CompiledName("custom")>] Custom
                        | [<CompiledName("function")>] Function

                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                    type Content =
                        | [<CompiledName("text")>] Text
                        | [<CompiledName("refusal")>] Refusal
                        | [<CompiledName("image_url")>] ImageUrl
                        | [<CompiledName("input_audio")>] InputAudio
                        | [<CompiledName("file")>] File

            module rec Prediction =
                module rec Search =
                    module rec Data =
                        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                        type Content = | [<CompiledName("text")>] Text

            module rec WebSearchOptions =
                module rec WebSearchOptions =
                    module rec UserLocation =
                        module rec WebSearchOptions =
                            module rec UserLocation =
                                type Approximate =
                                    abstract timezone: option<D1SessionBookmark> with get, set
                                    abstract region: option<D1SessionBookmark> with get, set
                                    abstract country: option<D1SessionBookmark> with get, set
                                    abstract city: option<D1SessionBookmark> with get, set

                    type UserLocation =
                        abstract approximate: UserLocation.Approximate with get, set

                        [<EmitProperty("type")>]
                        abstract ``type``: UserLocation.Type with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type WebSearchOptions =
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium")>] Medium
                | [<CompiledName("high")>] High

            type StreamOptions =
                [<EmitProperty("include_obfuscation")>]
                abstract includeObfuscation: option<bool> with get, set

                [<EmitProperty("include_usage")>]
                abstract includeUsage: option<bool> with get, set

            type ChatTemplateKwargs =
                [<EmitProperty("clear_thinking")>]
                abstract clearThinking: option<bool> with get, set

                [<EmitProperty("enable_thinking")>]
                abstract enableThinking: option<bool> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Messages =
                | [<CompiledName("system")>] System
                | [<CompiledName("developer")>] Developer
                | [<CompiledName("tool")>] Tool
                | [<CompiledName("assistant")>] Assistant
                | [<CompiledName("user")>] User

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Prediction = | [<CompiledName("content")>] Content

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Audio =
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("aac")>] Aac
                | [<CompiledName("mp3")>] Mp3
                | [<CompiledName("flac")>] Flac
                | [<CompiledName("opus")>] Opus
                | [<CompiledName("pcm16")>] Pcm16

        module rec ChatCompletionsOutput =
            module rec PostProcessedOutputs =
                module rec Usage =
                    module rec PostProcessedOutputs =
                        module rec Usage =
                            type CompletionTokensDetails =
                                [<EmitProperty("rejected_prediction_tokens")>]
                                abstract rejectedPredictionTokens: option<float> with get, set

                                [<EmitProperty("accepted_prediction_tokens")>]
                                abstract acceptedPredictionTokens: option<float> with get, set

                                [<EmitProperty("audio_tokens")>]
                                abstract audioTokens: option<float> with get, set

                                [<EmitProperty("reasoning_tokens")>]
                                abstract reasoningTokens: option<float> with get, set

                            type PromptTokensDetails =
                                [<EmitProperty("audio_tokens")>]
                                abstract audioTokens: option<float> with get, set

                                [<EmitProperty("cached_tokens")>]
                                abstract cachedTokens: option<float> with get, set

                type Usage =
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

        module rec ChatCompletionsPromptInput =
            module rec Audio =
                module rec Audio =
                    type Voice =
                        abstract id: D1SessionBookmark with get, set

            module rec Prediction =
                module rec Search =
                    module rec Data =
                        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                        type Content = | [<CompiledName("text")>] Text

            module rec WebSearchOptions =
                module rec WebSearchOptions =
                    module rec UserLocation =
                        module rec WebSearchOptions =
                            module rec UserLocation =
                                type Approximate =
                                    abstract timezone: option<D1SessionBookmark> with get, set
                                    abstract region: option<D1SessionBookmark> with get, set
                                    abstract country: option<D1SessionBookmark> with get, set
                                    abstract city: option<D1SessionBookmark> with get, set

                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                    type UserLocation = | [<CompiledName("approximate")>] Approximate

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type WebSearchOptions =
                | [<CompiledName("low")>] Low
                | [<CompiledName("medium")>] Medium
                | [<CompiledName("high")>] High

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Audio =
                | [<CompiledName("wav")>] Wav
                | [<CompiledName("aac")>] Aac
                | [<CompiledName("mp3")>] Mp3
                | [<CompiledName("flac")>] Flac
                | [<CompiledName("opus")>] Opus
                | [<CompiledName("pcm16")>] Pcm16

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Prediction = | [<CompiledName("content")>] Content

            type StreamOptions =
                [<EmitProperty("include_obfuscation")>]
                abstract includeObfuscation: option<bool> with get, set

                [<EmitProperty("include_usage")>]
                abstract includeUsage: option<bool> with get, set

            type ChatTemplateKwargs =
                [<EmitProperty("clear_thinking")>]
                abstract clearThinking: option<bool> with get, set

                [<EmitProperty("enable_thinking")>]
                abstract enableThinking: option<bool> with get, set

        module rec Cloudflare =
            [<Import("@cloudflare/workers-types.Cloudflare", "Exports")>]
            type Exports =
                abstract Item: key: D1SessionBookmark -> option<obj>

            [<Import("@cloudflare/workers-types.Cloudflare", "Env")>]
            type Env = interface end

            [<Import("@cloudflare/workers-types.Cloudflare", "GlobalProps")>]
            type GlobalProps = interface end

            type GlobalProp<'Default, 'K when 'K :> D1SessionBookmark> = obj

            type ICloudflare =
                [<Erase>]
                member exports: Exports = JS.undefined

                [<Erase>]
                member env: Env = JS.undefined

        module rec CloudflareWorkersModule =
            module rec StepPromise =
                module rec Do =
                    module rec Config =
                        module rec Do =
                            module rec Config =
                                type Retries =
                                    abstract backoff: option<WorkflowBackoff> with get, set

                                    abstract delay:
                                        U15<
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            float
                                         > with get, set

                                    abstract limit: float with get, set

                    type TemplateLiteral =
                        abstract Value: string
                        abstract Create: v0: float -> TemplateLiteral

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

            module rec WorkflowEntrypoint =
                module rec Run =
                    module rec Event =
                        type Params =
                            abstract Item: key: D1SessionBookmark -> option<obj>

                    type Event =
                        abstract instanceId: D1SessionBookmark with get, set
                        abstract timestamp: Date with get, set
                        abstract payload: WebAssembly.ModuleImports with get, set

                type T =
                    abstract Invoke: [<ParamArray>] args: Array<option<obj>> -> option<obj>

            module rec WorkflowStep =
                module rec Do =
                    module rec Callback =
                        module rec Do =
                            module rec Callback =
                                type Step =
                                    abstract count: float with get, set
                                    abstract name: D1SessionBookmark with get, set

                            module rec Config =
                                module rec Do =
                                    module rec Config =
                                        type Retries =
                                            abstract backoff: option<WorkflowBackoff> with get, set

                                            abstract delay:
                                                U15<
                                                    Retries.Delay,
                                                    Retries.Delay,
                                                    Retries.Delay,
                                                    Retries.Delay,
                                                    Retries.Delay,
                                                    Retries.Delay,
                                                    Retries.Delay,
                                                    Retries.Delay,
                                                    Retries.Delay,
                                                    Retries.Delay,
                                                    Retries.Delay,
                                                    Retries.Delay,
                                                    Retries.Delay,
                                                    Retries.Delay,
                                                    float
                                                 > with get, set

                                            abstract limit: float with get, set

                            type TemplateLiteral =
                                abstract Value: string
                                abstract Create: v0: float -> TemplateLiteral

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

                    module rec Config =
                        module rec Do =
                            module rec Config =
                                type Retries =
                                    abstract backoff: option<WorkflowBackoff> with get, set

                                    abstract delay:
                                        U15<
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            Retries.Delay,
                                            float
                                         > with get, set

                                    abstract limit: float with get, set

                    type Callback =
                        abstract config: WorkflowStepConfig with get, set
                        abstract attempt: float with get, set
                        abstract step: Callback.Step with get, set

                    type TemplateLiteral =
                        abstract Value: string
                        abstract Create: v0: float -> TemplateLiteral

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

                module rec WaitForEvent =
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

                        [<EmitProperty("type")>]
                        abstract ``type``: D1SessionBookmark with get, set

                    type Params =
                        abstract Item: key: D1SessionBookmark -> option<obj>

                type WaitForEvent =
                    [<EmitProperty("type")>]
                    abstract ``type``: D1SessionBookmark with get, set

                    abstract timestamp: Date with get, set
                    abstract payload: WebAssembly.ModuleImports with get, set

            module rec WorkflowStepConfig =
                module rec Do =
                    module rec Config =
                        type Retries =
                            abstract backoff: option<WorkflowBackoff> with get, set

                            abstract delay:
                                U15<
                                    Retries.Delay,
                                    Retries.Delay,
                                    Retries.Delay,
                                    Retries.Delay,
                                    Retries.Delay,
                                    Retries.Delay,
                                    Retries.Delay,
                                    Retries.Delay,
                                    Retries.Delay,
                                    Retries.Delay,
                                    Retries.Delay,
                                    Retries.Delay,
                                    Retries.Delay,
                                    Retries.Delay,
                                    float
                                 > with get, set

                            abstract limit: float with get, set

            module rec WorkflowStepContext =
                module rec Do =
                    module rec Callback =
                        type Step =
                            abstract count: float with get, set
                            abstract name: D1SessionBookmark with get, set

                    module rec Config =
                        module rec Do =
                            module rec Config =
                                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                type Retries =
                                    | [<CompiledName("constant")>] Constant
                                    | [<CompiledName("linear")>] Linear
                                    | [<CompiledName("exponential")>] Exponential

                    type TemplateLiteral =
                        abstract Value: string
                        abstract Create: v0: float -> TemplateLiteral

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

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "StepPromise")>]
            type StepPromise<'T> =
                inherit Promise<'T>
                abstract rollback: config: WorkflowStepConfig * fn: RollbackContext<'T> -> Promise<unit> -> StepPromise
                abstract rollback: fn: RollbackContext<'T> -> Promise<unit> -> StepPromise

            type RpcStub<'T when 'T :> Rpc.Stubable> = obj

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type WorkflowBackoff =
                | [<CompiledName("constant")>] Constant
                | [<CompiledName("linear")>] Linear
                | [<CompiledName("exponential")>] Exponential

            type TemplateLiteral =
                abstract Value: string
                abstract Create: v0: float -> TemplateLiteral

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

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkflowStep");
              AbstractClass;
              AllowNullLiteral>]
            type WorkflowStep private () =
                abstract waitForEvent:
                    name: D1SessionBookmark * options: WorkflowStep.WaitForEvent.Options ->
                        StepPromise<WorkflowStep.WaitForEvent>

                abstract sleepUntil: name: D1SessionBookmark * timestamp: U2<Date, float> -> Promise<unit>
                abstract sleep: name: D1SessionBookmark * duration: WorkflowSleepDuration -> Promise<unit>

                abstract ``do``:
                    name: D1SessionBookmark * config: WorkflowStepConfig * callback: WorkflowStepContext -> Promise<'T> ->
                        StepPromise<'T>

                abstract ``do``:
                    name: D1SessionBookmark * callback: WorkflowStepContext -> Promise<'T> -> StepPromise<'T>

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "RollbackContext")>]
            type RollbackContext<'T> =
                abstract stepName: D1SessionBookmark with get, set
                abstract output: option<RollbackContext.Output> with get, set
                abstract error: exn with get, set

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
                    Typescript.Request,
                    Rpc.RpcTargetBranded,
                    WorkflowEntrypoint,
                    Map<
                        U2<
                            option<
                                U31<
                                    WorkflowEntrypoint,
                                    RegExp,
                                    exn,
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
                                    Typescript.Request,
                                    Rpc.RpcTargetBranded,
                                    WorkflowEntrypoint,
                                    WorkflowEntrypoint,
                                    Map<
                                        U2<
                                            option<
                                                U31<
                                                    WorkflowEntrypoint,
                                                    RegExp,
                                                    exn,
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
                                                    Typescript.Request,
                                                    Rpc.RpcTargetBranded,
                                                    WorkflowEntrypoint,
                                                    WorkflowEntrypoint,
                                                    Map<U2<option<obj>, unit>, U2<option<obj>, unit>>,
                                                    Set<U2<option<obj>, unit>>,
                                                    ReadonlyArray<U2<option<obj>, unit>>,
                                                    WorkflowEntrypoint,
                                                    string,
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
                                    Typescript.Request,
                                    Rpc.RpcTargetBranded,
                                    WorkflowEntrypoint,
                                    WorkflowEntrypoint,
                                    Map<
                                        U2<
                                            option<
                                                U31<
                                                    WorkflowEntrypoint,
                                                    RegExp,
                                                    exn,
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
                                                    Typescript.Request,
                                                    Rpc.RpcTargetBranded,
                                                    WorkflowEntrypoint,
                                                    WorkflowEntrypoint,
                                                    Map<U2<option<obj>, unit>, U2<option<obj>, unit>>,
                                                    Set<U2<option<obj>, unit>>,
                                                    ReadonlyArray<U2<option<obj>, unit>>,
                                                    WorkflowEntrypoint,
                                                    string,
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
                                    Typescript.Request,
                                    Rpc.RpcTargetBranded,
                                    WorkflowEntrypoint,
                                    WorkflowEntrypoint,
                                    Map<
                                        U2<
                                            option<
                                                U31<
                                                    WorkflowEntrypoint,
                                                    RegExp,
                                                    exn,
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
                                                    Typescript.Request,
                                                    Rpc.RpcTargetBranded,
                                                    WorkflowEntrypoint,
                                                    WorkflowEntrypoint,
                                                    Map<U2<option<obj>, unit>, U2<option<obj>, unit>>,
                                                    Set<U2<option<obj>, unit>>,
                                                    ReadonlyArray<U2<option<obj>, unit>>,
                                                    WorkflowEntrypoint,
                                                    string,
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
                                    string,
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
                                    exn,
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
                                    Typescript.Request,
                                    Rpc.RpcTargetBranded,
                                    WorkflowEntrypoint,
                                    WorkflowEntrypoint,
                                    Map<
                                        U2<
                                            option<
                                                U31<
                                                    WorkflowEntrypoint,
                                                    RegExp,
                                                    exn,
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
                                                    Typescript.Request,
                                                    Rpc.RpcTargetBranded,
                                                    WorkflowEntrypoint,
                                                    WorkflowEntrypoint,
                                                    Map<U2<option<obj>, unit>, U2<option<obj>, unit>>,
                                                    Set<U2<option<obj>, unit>>,
                                                    ReadonlyArray<U2<option<obj>, unit>>,
                                                    WorkflowEntrypoint,
                                                    string,
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
                                    string,
                                    float
                                 >
                             >,
                            unit
                         >
                     >,
                    WorkflowEntrypoint,
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

            type WorkerEntrypoint =
                abstract attributes: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                [<EmitProperty("return")>]
                abstract ``return``: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                abstract log: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                [<EmitProperty("exception")>]
                abstract ``exception``: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                abstract diagnosticChannel: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract spanClose: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract spanOpen: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract outcome: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "RpcTarget"); AbstractClass; AllowNullLiteral>]
            type RpcTarget private () =
                inherit Rpc.RpcTargetBranded()

                [<EmitProperty("[Rpc.__RPC_TARGET_BRAND]")>]
                abstract rpc_RPCTARGETBRAND: unit with get, set

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkflowEvent")>]
            type WorkflowEvent<'T> =
                abstract instanceId: D1SessionBookmark with get, set
                abstract timestamp: Date with get, set
                abstract payload: WebAssembly.ModuleImports with get, set

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkflowStepEvent")>]
            type WorkflowStepEvent<'T> =
                [<EmitProperty("type")>]
                abstract ``type``: D1SessionBookmark with get, set

                abstract timestamp: Date with get, set
                abstract payload: WebAssembly.ModuleImports with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type WorkflowDurationLabel =
                | [<CompiledName("second")>] Second
                | [<CompiledName("minute")>] Minute
                | [<CompiledName("hour")>] Hour
                | [<CompiledName("day")>] Day
                | [<CompiledName("week")>] Week
                | [<CompiledName("month")>] Month
                | [<CompiledName("year")>] Year

            [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "WorkflowStepContext")>]
            type WorkflowStepContext =
                abstract config: WorkflowStepConfig with get, set
                abstract attempt: float with get, set
                abstract step: WorkflowStepContext.Step with get, set

            type WorkflowDelayDuration = obj

            type WithEnvAndExports =
                abstract Invoke: ?newEnv: obj * ?newExports: obj * fn: unit -> option<obj> -> option<obj>

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

            type WorkflowTimeoutDuration = obj

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

                abstract webSocketError: ws: Typescript.WebSocket * ?error: obj -> option<Promise<unit>>

                abstract webSocketClose:
                    ws: Typescript.WebSocket * code: float * reason: D1SessionBookmark * wasClean: bool ->
                        option<Promise<unit>>

                abstract webSocketMessage:
                    ws: Typescript.WebSocket * message: U2<ArrayBuffer, string> -> option<Promise<unit>>

                abstract connect: socket: Socket -> option<Promise<unit>>
                abstract fetch: request: Typescript.Request -> U2<Typescript.Response, Promise<Typescript.Response>>
                abstract alarm: ?alarmInfo: AlarmInvocationInfo -> option<Promise<unit>>

            type WorkflowRetentionDuration = obj

            type ICloudflareWorkersModule =
                [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "withExports")>]
                static member withExports(newExports: option<obj>, fn: unit -> option<obj>) : option<obj> = JS.undefined

                [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "withEnv")>]
                static member withEnv(newEnv: option<obj>, fn: unit -> option<obj>) : option<obj> = JS.undefined

                [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "withEnvAndExports")>]
                static member withEnvAndExports
                    (newEnv: option<obj>, newExports: option<obj>, fn: unit -> option<obj>)
                    : option<obj> =
                    JS.undefined

                [<Import("@cloudflare/workers-types.CloudflareWorkersModule", "waitUntil")>]
                static member waitUntil(promise: Promise<option<obj>>) : unit = JS.undefined

        module rec ColoLocalActorNamespace =
            type Get =
                abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

                abstract fetch:
                    input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                        Promise<Typescript.Response>

        module rec CompletionUsage =
            module rec PostProcessedOutputs =
                module rec Usage =
                    type CompletionTokensDetails =
                        [<EmitProperty("rejected_prediction_tokens")>]
                        abstract rejectedPredictionTokens: option<float> with get, set

                        [<EmitProperty("accepted_prediction_tokens")>]
                        abstract acceptedPredictionTokens: option<float> with get, set

                        [<EmitProperty("audio_tokens")>]
                        abstract audioTokens: option<float> with get, set

                        [<EmitProperty("reasoning_tokens")>]
                        abstract reasoningTokens: option<float> with get, set

                    type PromptTokensDetails =
                        [<EmitProperty("audio_tokens")>]
                        abstract audioTokens: option<float> with get, set

                        [<EmitProperty("cached_tokens")>]
                        abstract cachedTokens: option<float> with get, set

        module rec Container =
            type Get =
                abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

                abstract fetch:
                    input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                        Promise<Typescript.Response>

        module rec ConversionOptions =
            module rec Transform =
                module rec Options =
                    module rec ConversionOptions =
                        type Docx =
                            abstract images: option<EmbeddedImageConversionOptions> with get, set
                            abstract maxConvertedImages: option<float> with get, set
                            abstract convert: option<bool> with get, set
                            abstract descriptionLanguage: option<Docx.DescriptionLanguage> with get, set

                        type Pdf =
                            abstract metadata: option<bool> with get, set
                            abstract images: option<EmbeddedImageConversionOptions> with get, set

                        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                        type Html =
                            | [<CompiledName("en")>] En
                            | [<CompiledName("es")>] Es
                            | [<CompiledName("fr")>] Fr
                            | [<CompiledName("it")>] It
                            | [<CompiledName("pt")>] Pt
                            | [<CompiledName("de")>] De

                        type Image =
                            abstract descriptionLanguage: option<Image.DescriptionLanguage> with get, set

        module rec ConversionRequestOptions =
            module rec Transform =
                module rec Options =
                    module rec ConversionOptions =
                        module rec Transform =
                            module rec Options =
                                module rec ConversionOptions =
                                    type Pdf =
                                        abstract metadata: option<bool> with get, set
                                        abstract images: option<EmbeddedImageConversionOptions> with get, set

                                    type Image =
                                        abstract descriptionLanguage: option<Image.DescriptionLanguage> with get, set

                                    type Docx =
                                        abstract maxConvertedImages: option<float> with get, set
                                        abstract convert: option<bool> with get, set
                                        abstract descriptionLanguage: option<Docx.DescriptionLanguage> with get, set
                                        abstract images: option<EmbeddedImageConversionOptions> with get, set

                                    type Html =
                                        abstract convertOGImage: option<bool> with get, set
                                        abstract maxConvertedImages: option<float> with get, set
                                        abstract convert: option<bool> with get, set
                                        abstract descriptionLanguage: option<Html.DescriptionLanguage> with get, set
                                        abstract cssSelector: option<D1SessionBookmark> with get, set
                                        abstract hostname: option<D1SessionBookmark> with get, set
                                        abstract images: option<Html.Images> with get, set

                    module rec Gateway =
                        module rec Transform =
                            module rec Options =
                                module rec Gateway =
                                    type Retries =
                                        abstract backoff: option<CloudflareWorkersModule.WorkflowBackoff> with get, set
                                        abstract retryDelayMs: option<float> with get, set
                                        abstract maxAttempts: option<Retries.MaxAttempts> with get, set

                        type Params =
                            abstract Item: key: D1SessionBookmark -> option<obj>

                    type Gateway =
                        abstract retries: option<GatewayRetries> with get, set
                        abstract requestTimeoutMs: option<float> with get, set
                        abstract eventId: option<D1SessionBookmark> with get, set
                        abstract collectLog: option<bool> with get, set
                        abstract metadata: option<WebAssembly.ModuleImports> with get, set
                        abstract skipCache: option<bool> with get, set
                        abstract cacheTtl: option<float> with get, set
                        abstract cacheKey: option<D1SessionBookmark> with get, set
                        abstract id: D1SessionBookmark with get, set

                    type ConversionOptions =
                        abstract pdf: option<ConversionOptions.Pdf> with get, set
                        abstract image: option<ImageConversionOptions> with get, set
                        abstract docx: option<ConversionOptions.Docx> with get, set
                        abstract html: option<ConversionOptions.Html> with get, set

        module rec Crypto =
            type DigestStream =
                abstract prototype: DigestStream with get, set
                abstract Create: algorithm: U2<SubtleCryptoHashAlgorithm, string> -> DigestStream

        module rec D1DatabaseSession =
            type Timings =
                [<EmitProperty("sql_duration_ms")>]
                abstract sqlDurationMs: float with get, set

        module rec D1Meta =
            type Timings =
                [<EmitProperty("sql_duration_ms")>]
                abstract sqlDurationMs: float with get, set

        module rec D1PreparedStatement =
            module rec Raw =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Options = | [<CompiledValue(false)>] False

            type Timings =
                [<EmitProperty("sql_duration_ms")>]
                abstract sqlDurationMs: float with get, set

        module rec D1Response =
            type Timings =
                [<EmitProperty("sql_duration_ms")>]
                abstract sqlDurationMs: float with get, set

        module rec D1Result =
            type Timings =
                [<EmitProperty("sql_duration_ms")>]
                abstract sqlDurationMs: float with get, set

        module rec DispatchNamespace =
            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

            type Get =
                abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

                abstract fetch:
                    input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                        Promise<Typescript.Response>

        module rec DurableObjectStorage =
            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec DynamicDispatchOptions =
            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec EventContext =
            module rec ASSETS =
                module rec ASSETS =
                    type Fetch =
                        abstract Invoke:
                            input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                                Promise<Typescript.Response>

                        abstract Invoke:
                            input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                                Promise<Typescript.Response>

            type ASSETS =
                abstract fetch: ASSETS.Fetch with get, set

        module rec EventPluginContext =
            module rec ASSETS =
                module rec ASSETS =
                    type Fetch =
                        abstract Invoke:
                            input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                                Promise<Typescript.Response>

                        abstract Invoke:
                            input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                                Promise<Typescript.Response>

            type ASSETS =
                abstract fetch: ASSETS.Fetch with get, set

        module rec EventSourceEventSourceInit =
            type Get =
                abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

                abstract fetch:
                    input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                        Promise<Typescript.Response>

        module rec EventTarget =
            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec ExportedHandler =
            type Email =
                abstract Invoke:
                    message: ForwardableEmailMessage * env: 'Env * ctx: ExecutionContext<'Props> ->
                        option<Promise<unit>>

            type Queue =
                abstract Invoke:
                    batch: MessageBatch<'Message> * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

            type Test =
                abstract Invoke:
                    controller: TestController * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

            type TailStream =
                abstract attributes: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                [<EmitProperty("return")>]
                abstract ``return``: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                abstract log: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                [<EmitProperty("exception")>]
                abstract ``exception``: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                abstract diagnosticChannel: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract spanClose: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract spanOpen: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set
                abstract outcome: option<TailStream.TailEvent<'Event> -> option<Promise<unit>>> with get, set

                abstract Invoke:
                    event: TailStream.TailEvent<TailStream.Onset> * env: 'Env * ctx: ExecutionContext<'Props> ->
                        U3<
                            TailStream.TailEvent<'Event> -> option<Promise<unit>>,
                            TailStream.Invoke,
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

            type Fetch =
                abstract Invoke:
                    request: Typescript.Request * env: 'Env * ctx: ExecutionContext<'Props> ->
                        U2<Typescript.Response, Promise<Typescript.Response>>

            type Scheduled =
                abstract Invoke:
                    controller: ScheduledController * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        module rec Fetch =
            module rec ASSETS =
                type Fetch =
                    abstract Invoke:
                        input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                            Promise<Typescript.Response>

                    abstract Invoke:
                        input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                            Promise<Typescript.Response>

        module rec Flagship =
            module rec Get =
                type Context =
                    abstract Item: key: D1SessionBookmark -> option<obj>

        module rec FlagshipEvaluationContext =
            module rec Get =
                type Context =
                    abstract Item: key: D1SessionBookmark -> option<obj>

        module rec FormData =
            module rec ForEach =
                type Callback =
                    abstract Invoke:
                        this: 'This * value: D1SessionBookmark * key: D1SessionBookmark * parent: FormData -> unit

        module rec GatewayOptions =
            module rec Transform =
                module rec Options =
                    module rec Gateway =
                        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                        type Retries =
                            | [<CompiledName("constant")>] Constant
                            | [<CompiledName("linear")>] Linear
                            | [<CompiledName("exponential")>] Exponential

        module rec Headers =
            module rec ForEach =
                type Callback =
                    abstract Invoke:
                        this: 'This * value: D1SessionBookmark * key: D1SessionBookmark * parent: Headers -> unit

            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec HeadersInit =
            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec HelloWorldBinding =
            type Get =
                abstract ms: option<float> with get, set
                abstract value: D1SessionBookmark with get, set

        module rec ImageTransformationResult =
            module rec Image =
                type Options =
                    abstract encoding: option<Options.Encoding> with get, set

        module rec ImageTransformer =
            module rec Draw =
                type Options =
                    abstract right: option<float> with get, set
                    abstract bottom: option<float> with get, set
                    abstract left: option<float> with get, set
                    abstract top: option<float> with get, set
                    abstract repeat: option<U2<bool, string>> with get, set
                    abstract opacity: option<float> with get, set

            module rec Output =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Options =
                    | [<CompiledName("image/jpeg")>] ImageJpeg
                    | [<CompiledName("image/png")>] ImagePng
                    | [<CompiledName("image/gif")>] ImageGif
                    | [<CompiledName("image/webp")>] ImageWebp
                    | [<CompiledName("image/avif")>] ImageAvif
                    | [<CompiledName("rgb")>] Rgb
                    | [<CompiledName("rgba")>] Rgba

            module rec Transform =
                module rec Transform =
                    module rec Transform =
                        module rec Transform =
                            module rec Trim =
                                module rec Transform =
                                    module rec Transform =
                                        module rec Trim =
                                            type Border =
                                                abstract keep: option<float> with get, set
                                                abstract tolerance: option<float> with get, set
                                                abstract color: option<D1SessionBookmark> with get, set

                            type Gravity =
                                abstract mode: Gravity.Mode with get, set
                                abstract y: option<float> with get, set
                                abstract x: option<float> with get, set

                            type Trim =
                                abstract border: option<U2<Trim.Border, bool>> with get, set
                                abstract height: option<float> with get, set
                                abstract width: option<float> with get, set
                                abstract right: option<float> with get, set
                                abstract left: option<float> with get, set
                                abstract bottom: option<float> with get, set
                                abstract top: option<float> with get, set

                            type Border =
                                abstract width: option<float> with get, set
                                abstract color: option<D1SessionBookmark> with get, set
                                abstract right: option<float> with get, set
                                abstract left: option<float> with get, set
                                abstract bottom: option<float> with get, set
                                abstract top: option<float> with get, set

                type Transform =
                    | ``0`` = 0
                    | ``90`` = 90
                    | ``180`` = 180
                    | ``270`` = 270

        module rec ImagesBinding =
            module rec Info =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Options = | [<CompiledName("base64")>] Base64

            type Info =
                abstract format: Info.Format with get, set
                abstract height: float with get, set
                abstract width: float with get, set
                abstract fileSize: float with get, set
                abstract format: D1SessionBookmark with get, set

        module rec IncomingRequestCfPropertiesBase =
            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec InstanceStatus =
            module rec Status =
                type Error =
                    abstract message: D1SessionBookmark with get, set
                    abstract name: D1SessionBookmark with get, set

        module rec KVNamespace =
            module rec Get =
                type Options =
                    abstract cacheTtl: option<float> with get, set

                    [<EmitProperty("type")>]
                    abstract ``type``: option<unit> with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type List =
                | [<CompiledValue(true)>] True
                | [<CompiledValue(false)>] False

        module rec KVNamespaceListResult =
            type List =
                abstract cacheStatus: option<string> with get, set
                abstract cursor: D1SessionBookmark with get, set
                abstract keys: Array<KVNamespaceListKey<'Metadata, 'Key>> with get, set

                [<EmitProperty("list_complete")>]
                abstract listComplete: List.ListComplete with get, set

        module rec LoopbackDurableObjectClass =
            module rec Invoke =
                type Opts =
                    abstract props: option<obj> with get, set
                    abstract props: option<'Props> with get, set

        module rec LoopbackForExport =
            module rec Invoke =
                type Opts =
                    abstract props: option<obj> with get, set
                    abstract props: option<'Props> with get, set

            type T =
                abstract Create: [<ParamArray>] args: Array<option<obj>> -> Rpc.EntrypointBranded

            type Get =
                abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

                abstract fetch:
                    input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                        Promise<Typescript.Response>

        module rec LoopbackServiceStub =
            module rec Invoke =
                type Opts =
                    abstract props: option<obj> with get, set
                    abstract props: option<'Props> with get, set

        module rec MediaTransformationGenerator =
            module rec Output =
                type Output =
                    abstract format: option<Output.Format> with get, set
                    abstract imageCount: option<float> with get, set
                    abstract duration: option<D1SessionBookmark> with get, set
                    abstract time: option<D1SessionBookmark> with get, set
                    abstract audio: option<bool> with get, set
                    abstract mode: option<Output.Mode> with get, set

        module rec MediaTransformer =
            module rec Output =
                type Output =
                    abstract format: option<Output.Format> with get, set
                    abstract imageCount: option<float> with get, set
                    abstract duration: option<D1SessionBookmark> with get, set
                    abstract time: option<D1SessionBookmark> with get, set
                    abstract audio: option<bool> with get, set
                    abstract mode: option<Output.Mode> with get, set

            module rec Transform =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Transform =
                    | [<CompiledName("contain")>] Contain
                    | [<CompiledName("cover")>] Cover
                    | [<CompiledName("scale-down")>] ScaleDown

        module rec OnRequest =
            module rec ASSETS =
                module rec ASSETS =
                    type Fetch =
                        abstract Invoke:
                            input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                                Promise<Typescript.Response>

                        abstract Invoke:
                            input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                                Promise<Typescript.Response>

            type ASSETS =
                abstract fetch: ASSETS.Fetch with get, set

            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec PagesFunction =
            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec PagesPluginFunction =
            module rec Invoke =
                module rec Context =
                    module rec ASSETS =
                        module rec ASSETS =
                            type Fetch =
                                abstract Invoke:
                                    input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                                        Promise<Typescript.Response>

                                abstract Invoke:
                                    input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                                        Promise<Typescript.Response>

                    type ASSETS =
                        abstract fetch: ASSETS.Fetch with get, set

                type Context =
                    abstract ASSETS: Context.ASSETS with get, set
                    abstract pluginArgs: 'PluginArgs with get, set
                    abstract data: 'Data with get, set
                    abstract params: WebAssembly.ModuleImports with get, set
                    abstract env: Context.Env with get, set
                    abstract functionPath: D1SessionBookmark with get, set
                    abstract request: Typescript.Request with get, set
                    abstract next: ?input: RequestInfo * ?init: Typescript.RequestInit -> Promise<Typescript.Response>
                    abstract passThroughOnException: unit -> unit
                    abstract waitUntil: promise: Promise<option<obj>> -> unit

        module rec R2GetOptions =
            type Range =
                abstract suffix: float with get, set
                abstract length: float with get, set
                abstract offset: option<float> with get, set
                abstract length: option<float> with get, set
                abstract offset: float with get, set

        module rec R2Object =
            type Range =
                abstract length: float with get, set
                abstract offset: option<float> with get, set
                abstract suffix: float with get, set
                abstract length: option<float> with get, set
                abstract offset: float with get, set

        module rec RequestInitCfProperties =
            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec RequestInitCfPropertiesImage =
            type Border =
                abstract width: float with get, set
                abstract color: D1SessionBookmark with get, set
                abstract left: float with get, set
                abstract bottom: float with get, set
                abstract right: float with get, set
                abstract top: float with get, set

        module rec ResponseContent =
            module rec Instructions =
                module rec Content =
                    module rec Instructions =
                        module rec Content =
                            module rec Logprobs =
                                module rec Instructions =
                                    module rec Content =
                                        module rec Logprobs =
                                            type TopLogprobs =
                                                abstract logprob: option<float> with get, set
                                                abstract token: option<D1SessionBookmark> with get, set

                            type Logprobs =
                                [<EmitProperty("top_logprobs")>]
                                abstract topLogprobs: option<Array<TopLogprob>> with get, set

                                abstract logprob: float with get, set
                                abstract token: D1SessionBookmark with get, set

                type Content =
                    [<EmitProperty("type")>]
                    abstract ``type``: Content.Type with get, set

                    abstract refusal: D1SessionBookmark with get, set
                    abstract logprobs: option<Array<Logprob>> with get, set
                    abstract text: D1SessionBookmark with get, set

            module rec Prompt =
                module rec Variables =
                    type Item =
                        [<EmitProperty("type")>]
                        abstract ``type``: Item.Type with get, set

                        abstract text: D1SessionBookmark with get, set

                        [<EmitProperty("image_url")>]
                        abstract imageUrl: option<string> with get, set

                        abstract detail: Item.Detail with get, set

        module rec ResponseFormatJSONSchema =
            module rec ResponseFormat =
                type JsonSchema =
                    abstract strict: option<bool> with get, set
                    abstract schema: option<WebAssembly.ModuleImports> with get, set
                    abstract description: option<D1SessionBookmark> with get, set
                    abstract name: D1SessionBookmark with get, set

        module rec ResponseFormatTextJSONSchemaConfig =
            module rec Text =
                module rec Format =
                    type Schema =
                        abstract Item: key: D1SessionBookmark -> option<obj>

        module rec ResponseFunctionToolCallItem =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Instructions =
                | [<CompiledName("function_call")>] FunctionCall
                | [<CompiledName("in_progress")>] InProgress
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("incomplete")>] Incomplete

        module rec ResponseFunctionToolCallOutputItem =
            module rec Prompt =
                module rec Variables =
                    type Item =
                        [<EmitProperty("type")>]
                        abstract ``type``: Item.Type with get, set

                        abstract text: D1SessionBookmark with get, set

                        [<EmitProperty("image_url")>]
                        abstract imageUrl: option<string> with get, set

                        abstract detail: Item.Detail with get, set

        module rec ResponseInputItem =
            module rec Instructions =
                module rec Instructions =
                    module rec Content =
                        module rec Instructions =
                            module rec Content =
                                module rec Logprobs =
                                    module rec Instructions =
                                        module rec Content =
                                            module rec Logprobs =
                                                type TopLogprobs =
                                                    abstract logprob: option<float> with get, set
                                                    abstract token: option<D1SessionBookmark> with get, set

                                type Logprobs =
                                    [<EmitProperty("top_logprobs")>]
                                    abstract topLogprobs: option<Array<TopLogprob>> with get, set

                                    abstract logprob: float with get, set
                                    abstract token: D1SessionBookmark with get, set

                    type Content =
                        [<EmitProperty("type")>]
                        abstract ``type``: Content.Type with get, set

                        abstract refusal: D1SessionBookmark with get, set
                        abstract logprobs: option<Array<Logprob>> with get, set
                        abstract text: D1SessionBookmark with get, set

                    type Summary =
                        [<EmitProperty("type")>]
                        abstract ``type``: Summary.Type with get, set

                        abstract text: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Instructions =
                | [<CompiledName("user")>] User
                | [<CompiledName("system")>] System
                | [<CompiledName("developer")>] Developer
                | [<CompiledName("function_call_output")>] FunctionCallOutput
                | [<CompiledName("in_progress")>] InProgress
                | [<CompiledName("completed")>] Completed
                | [<CompiledName("incomplete")>] Incomplete
                | [<CompiledName("assistant")>] Assistant
                | [<CompiledName("function_call")>] FunctionCall
                | [<CompiledName("reasoning")>] Reasoning
                | [<CompiledName("message")>] Message

        module rec ResponseItem =
            module rec Instructions =
                module rec Instructions =
                    module rec Content =
                        module rec Instructions =
                            module rec Content =
                                module rec Logprobs =
                                    module rec Instructions =
                                        module rec Content =
                                            module rec Logprobs =
                                                type TopLogprobs =
                                                    abstract logprob: option<float> with get, set
                                                    abstract token: option<D1SessionBookmark> with get, set

                                type Logprobs =
                                    [<EmitProperty("top_logprobs")>]
                                    abstract topLogprobs: option<Array<TopLogprob>> with get, set

                                    abstract logprob: float with get, set
                                    abstract token: D1SessionBookmark with get, set

                    type Content =
                        abstract logprobs: option<Array<Logprob>> with get, set

                        [<EmitProperty("type")>]
                        abstract ``type``: Content.Type with get, set

                        abstract text: D1SessionBookmark with get, set
                        abstract refusal: D1SessionBookmark with get, set

            type Instructions =
                [<EmitProperty("type")>]
                abstract ``type``: Instructions.Type with get, set

                abstract status: Instructions.Status with get, set
                abstract role: Instructions.Role with get, set
                abstract content: Array<U2<Instructions.Content, Instructions.Content>> with get, set
                abstract id: D1SessionBookmark with get, set

        module rec ResponsesInput =
            module rec Text =
                module rec Text =
                    module rec Format =
                        module rec Text =
                            module rec Format =
                                type Schema =
                                    abstract Item: key: D1SessionBookmark -> option<obj>

                    type Format =
                        [<EmitProperty("type")>]
                        abstract ``type``: Format.Type with get, set

                        abstract strict: option<bool> with get, set
                        abstract description: option<D1SessionBookmark> with get, set
                        abstract schema: Format.Schema with get, set
                        abstract name: D1SessionBookmark with get, set

            type Text =
                abstract verbosity: option<Text.Verbosity> with get, set
                abstract format: option<ResponseFormatTextConfig> with get, set

        module rec ResponsesOutput =
            module rec Text =
                module rec Text =
                    module rec Format =
                        module rec Text =
                            module rec Format =
                                type Schema =
                                    abstract Item: key: D1SessionBookmark -> option<obj>

                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                    type Format =
                        | [<CompiledName("text")>] Text
                        | [<CompiledName("json_schema")>] JsonSchema
                        | [<CompiledName("json_object")>] JsonObject

            type Text =
                abstract verbosity: option<Text.Verbosity> with get, set
                abstract format: option<ResponseFormatTextConfig> with get, set

            type Usage =
                [<EmitProperty("total_tokens")>]
                abstract totalTokens: float with get, set

                [<EmitProperty("output_tokens")>]
                abstract outputTokens: float with get, set

                [<EmitProperty("input_tokens")>]
                abstract inputTokens: float with get, set

        module rec Rpc =
            module rec Serializable =
                type Params =
                    abstract Item: key: D1SessionBookmark -> option<obj>

                type T =
                    abstract Invoke: [<ParamArray>] args: Array<option<obj>> -> option<obj>

            module rec StubBase =
                type T =
                    abstract Invoke: [<ParamArray>] args: Array<option<obj>> -> option<obj>

            module rec Stubify =
                type Params =
                    abstract Item: key: D1SessionBookmark -> option<obj>

            module rec Unstubify =
                type Params =
                    abstract Item: key: D1SessionBookmark -> option<obj>

            module rec UnstubifyAll =
                module rec Invoke =
                    module rec Args =
                        module rec Every =
                            type Predicate =
                                abstract Invoke: value: 'T * index: float * array: Array -> bool

                        module rec Find =
                            type Predicate =
                                abstract Invoke: value: 'T * index: float * obj: Array -> bool

                        module rec FindIndex =
                            type Predicate =
                                abstract Invoke: value: 'T * index: float * obj: Array -> option<obj>

                        module rec FlatMap =
                            type Callback =
                                abstract Invoke:
                                    this: 'This * value: 'T * index: float * array: Array -> U2<'U, ReadonlyArray<'U>>

                        module rec ForEach =
                            type Callbackfn =
                                abstract Invoke: value: 'T * index: float * array: Array -> unit

                        module rec Map =
                            type Callbackfn =
                                abstract Invoke: value: 'T * index: float * array: Array -> 'U

                        module rec Reduce =
                            type Callbackfn =
                                abstract Invoke:
                                    previousValue: 'T * currentValue: 'T * currentIndex: float * array: Array -> 'T

                        module rec Some =
                            type Predicate =
                                abstract Invoke: value: 'T * index: float * array: Array -> option<obj>

                        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                        type SymbolUnscopables =
                            | [<CompiledValue(false)>] False
                            | [<CompiledValue(true)>] True

            [<Import("@cloudflare/workers-types.Rpc", "RpcTargetBranded")>]
            type RpcTargetBranded =
                [<EmitProperty("[__RPC_TARGET_BRAND]")>]
                abstract __RPC_TARGET_BRAND: unit with get, set

            type Serializable<'T> = option<obj>

            [<Import("@cloudflare/workers-types.Rpc", "WorkflowEntrypointBranded")>]
            type WorkflowEntrypointBranded =
                [<EmitProperty("[__WORKFLOW_ENTRYPOINT_BRAND]")>]
                abstract __WORKFLOW_ENTRYPOINT_BRAND: unit with get, set

            type Stubable = obj

            type Result =
                abstract Item: key: D1SessionBookmark -> option<obj>
                abstract Invoke: [<ParamArray>] args: Result.Invoke.Args -> U2<Result.Invoke, U2<Result.Invoke, unit>>

                abstract catch:
                    ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

                abstract ``then``:
                    ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                    ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                        Promise<U2<'TResult1, 'TResult2>>

            type Stubify<'T> = obj
            type EntrypointBranded = obj

            [<Import("@cloudflare/workers-types.Rpc", "StubBase")>]
            type StubBase<'T when 'T :> Stubable> =
                inherit Typescript.Disposable

                [<EmitProperty("[__RPC_STUB_BRAND]")>]
                abstract __RPC_STUB_BRAND: 'T with get, set

                abstract dup: unit -> 'StubBase

            [<Import("@cloudflare/workers-types.Rpc", "WorkerEntrypointBranded")>]
            type WorkerEntrypointBranded =
                [<EmitProperty("[__WORKER_ENTRYPOINT_BRAND]")>]
                abstract __WORKER_ENTRYPOINT_BRAND: unit with get, set

            type MaybeDisposable<'T> = U2<Typescript.Disposable, option<obj>>
            type BaseType = option<obj>

            [<Import("@cloudflare/workers-types.Rpc", "UnstubifyAll")>]
            type UnstubifyAll<'A when 'A :> Array<option<obj>>> =
                [<EmitProperty("[Symbol.unscopables]")>]
                abstract symbolUnscopables: UnstubifyAll.SymbolUnscopables with get

                abstract length: float with get, set
                abstract symbolIterator: unit -> ArrayIterator<'T>
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

            type MethodOrProperty =
                abstract Invoke:
                    [<ParamArray>] args: MethodOrProperty.Invoke.Args ->
                        U2<MethodOrProperty.Invoke, U2<MethodOrProperty.Invoke, unit>>

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
                    [<ParamArray>] args: Provider.Invoke.Args -> U2<Provider.Invoke, U2<Provider.Invoke, unit>>

            type MaybeProvider<'T> = U2<MaybeProvider, option<obj>>

            [<Import("@cloudflare/workers-types.Rpc", "Stub")>]
            type Stub<'T when 'T :> Stubable> =
                [<EmitProperty("[__RPC_STUB_BRAND]")>]
                abstract __RPC_STUB_BRAND: 'T with get, set

                abstract symbolDispose: unit -> unit
                abstract dup: unit -> 'StubBase
                abstract Item: key: D1SessionBookmark -> option<obj>

                abstract catch:
                    ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

                abstract ``then``:
                    ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                    ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                        Promise<U2<'TResult1, 'TResult2>>

                abstract Invoke: [<ParamArray>] args: Stub.Invoke.Args -> U2<Stub.Invoke, U2<Stub.Invoke, unit>>

            [<Import("@cloudflare/workers-types.Rpc", "DurableObjectBranded")>]
            type DurableObjectBranded =
                [<EmitProperty("[__DURABLE_OBJECT_BRAND]")>]
                abstract __DURABLE_OBJECT_BRAND: unit with get, set

            type MaybeCallableProvider<'T> = obj

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
                                                                            U2<'T, U2<WebAssembly.ModuleImports, 'T>>
                                                                         >
                                                                     >
                                                                 >
                                                             >
                                                         >
                                                     >,
                                                    U2<
                                                        Array<U2<'V, option<obj>>>,
                                                        U2<
                                                            ReadonlyArray<U2<'V, option<obj>>>,
                                                            U2<'T, U2<WebAssembly.ModuleImports, 'T>>
                                                         >
                                                     >
                                                 >
                                             >
                                         >,
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
                                                            U2<'T, U2<WebAssembly.ModuleImports, 'T>>
                                                         >
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
                                                                U2<'T, U2<WebAssembly.ModuleImports, 'T>>
                                                             >
                                                         >
                                                     >
                                                 >
                                             >
                                         >,
                                        U2<
                                            Array<U2<'V, option<obj>>>,
                                            U2<
                                                ReadonlyArray<U2<'V, option<obj>>>,
                                                U2<'T, U2<WebAssembly.ModuleImports, 'T>>
                                             >
                                         >
                                     >
                                 >
                             >,
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
                                                U2<'T, U2<WebAssembly.ModuleImports, 'T>>
                                             >
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
                                                    U2<'T, U2<WebAssembly.ModuleImports, 'T>>
                                                 >
                                             >
                                         >
                                     >
                                 >
                             >,
                            U2<
                                Array<U2<'V, option<obj>>>,
                                U2<ReadonlyArray<U2<'V, option<obj>>>, U2<'T, U2<WebAssembly.ModuleImports, 'T>>>
                             >
                         >
                     >
                 >

        module rec RpcStub =
            module rec Invoke =
                module rec Args =
                    module rec Invoke =
                        module rec Args =
                            module rec Every =
                                type Predicate =
                                    abstract Invoke: value: 'T * index: float * array: Array -> bool

                            module rec Find =
                                type Predicate =
                                    abstract Invoke: value: 'T * index: float * obj: Array -> bool

                            module rec FindIndex =
                                type Predicate =
                                    abstract Invoke: value: 'T * index: float * obj: Array -> option<obj>

                            module rec FlatMap =
                                type Callback =
                                    abstract Invoke:
                                        this: 'This * value: 'T * index: float * array: Array ->
                                            U2<'U, ReadonlyArray<'U>>

                            module rec ForEach =
                                type Callbackfn =
                                    abstract Invoke: value: 'T * index: float * array: Array -> unit

                            module rec Map =
                                type Callbackfn =
                                    abstract Invoke: value: 'T * index: float * array: Array -> 'U

                            module rec Reduce =
                                type Callbackfn =
                                    abstract Invoke:
                                        previousValue: 'T * currentValue: 'T * currentIndex: float * array: Array -> 'T

                            module rec Some =
                                type Predicate =
                                    abstract Invoke: value: 'T * index: float * array: Array -> option<obj>

                            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                            type SymbolUnscopables =
                                | [<CompiledValue(false)>] False
                                | [<CompiledValue(true)>] True

                            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                            type Flat =
                                | [<CompiledName("recur")>] Recur
                                | [<CompiledName("done")>] Done

                type Args =
                    [<EmitProperty("[Symbol.unscopables]")>]
                    abstract symbolUnscopables: Args.SymbolUnscopables with get

                    abstract length: float with get, set
                    abstract symbolIterator: unit -> ArrayIterator<'T>
                    abstract ``with``: index: float * value: 'T -> Array
                    abstract toSpliced: start: float * deleteCount: float * [<ParamArray>] items: Array -> Array
                    abstract toSorted: ?compareFn: 'T -> 'T -> float -> Array
                    abstract toReversed: unit -> Array
                    abstract findLastIndex: predicate: Args.FindLastIndex.Predicate * ?thisArg: obj -> float
                    abstract findLast: predicate: Args.FindLast.Predicate * ?thisArg: obj -> option<'S>
                    abstract at: index: float -> option<'T>
                    abstract flat: this: 'A * ?depth: 'D -> Array<proptypekey<Args.Flat, U2<Args.Flat, Args.Flat>>>
                    abstract flatMap: callback: Args.FlatMap.Callback * ?thisArg: 'This -> Array<'U>
                    abstract includes: searchElement: 'T * ?fromIndex: float -> bool
                    abstract values: unit -> ArrayIterator<'T>
                    abstract keys: unit -> ArrayIterator<float>
                    abstract entries: unit -> ArrayIterator<float * 'T>
                    abstract copyWithin: target: float * start: float * ?``end``: float -> 'Array
                    abstract fill: value: 'T * ?start: float * ?``end``: float -> 'Array
                    abstract findIndex: predicate: Args.FindIndex.Predicate * ?thisArg: obj -> float
                    abstract find: predicate: Args.Find.Predicate * ?thisArg: obj -> option<'S>
                    abstract reduceRight: callbackfn: Args.ReduceRight.Callbackfn -> 'T
                    abstract reduce: callbackfn: Args.Reduce.Callbackfn -> 'T
                    abstract filter: predicate: Args.Filter.Predicate * ?thisArg: obj -> Array<'S>
                    abstract map: callbackfn: Args.Map.Callbackfn * ?thisArg: obj -> Array<'U>
                    abstract forEach: callbackfn: Args.ForEach.Callbackfn * ?thisArg: obj -> unit
                    abstract some: predicate: Args.Some.Predicate * ?thisArg: obj -> bool
                    abstract every: predicate: Args.Every.Predicate * ?thisArg: obj -> bool
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

        module rec SendEmail =
            module rec Send =
                module rec Builder =
                    module rec Send =
                        module rec Builder =
                            type Attachments =
                                abstract content: U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, string> with get, set

                                [<EmitProperty("type")>]
                                abstract ``type``: D1SessionBookmark with get, set

                                abstract filename: D1SessionBookmark with get, set
                                abstract contentId: D1SessionBookmark with get, set
                                abstract disposition: Attachments.Disposition with get, set
                                abstract contentId: option<unit> with get, set

                type Builder =
                    abstract attachments: option<Array<EmailAttachment>> with get, set
                    abstract html: option<D1SessionBookmark> with get, set
                    abstract text: option<D1SessionBookmark> with get, set
                    abstract headers: option<WebAssembly.ModuleImports> with get, set
                    abstract bcc: option<U2<Array<D1SessionBookmark>, string>> with get, set
                    abstract cc: option<U2<Array<D1SessionBookmark>, string>> with get, set
                    abstract replyTo: option<U2<EmailAddress, string>> with get, set
                    abstract subject: D1SessionBookmark with get, set

                    [<EmitProperty("to")>]
                    abstract ``to``: U2<Array<D1SessionBookmark>, string> with get, set

                    abstract from: U2<EmailAddress, string> with get, set

        module rec Service =
            type Get =
                abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

                abstract fetch:
                    input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                        Promise<Typescript.Response>

            type T =
                abstract Create: [<ParamArray>] args: Array<option<obj>> -> Rpc.WorkerEntrypointBranded

        module rec ServiceWorkerGlobalScope =
            module rec ReadableStream =
                module rec ReadableStream =
                    module rec Create =
                        type Strategy =
                            abstract highWaterMark: option<float> with get, set

            module rec SetTimeout =
                type Callback =
                    abstract Invoke: [<ParamArray>] args: 'Args -> unit
                    abstract Invoke: [<ParamArray>] args: Array<option<obj>> -> unit

            module rec URLSearchParams =
                type Params =
                    abstract Item: key: D1SessionBookmark -> option<obj>

            module rec WebSocketPair =
                module rec WebSocketPair =
                    type Create =
                        [<EmitProperty("1")>]
                        abstract ``1``: Typescript.WebSocket with get, set

                        [<EmitProperty("0")>]
                        abstract ``0``: Typescript.WebSocket with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type CompressionStream =
                | [<CompiledName("deflate")>] Deflate
                | [<CompiledName("deflate-raw")>] DeflateRaw
                | [<CompiledName("gzip")>] Gzip

            type EventSource =
                abstract CLOSED: EventSource.CLOSED with get
                abstract OPEN: EventSource.OPEN with get
                abstract CONNECTING: EventSource.CONNECTING with get
                abstract prototype: EventSource with get, set
                abstract Create: url: U2<URL, string> * ?eventSourceInitDict: EventSourceInit -> EventSource

            type ErrorEvent =
                abstract prototype: ErrorEvent with get, set
                abstract Create: ``type``: D1SessionBookmark * ?eventInitDict: ErrorEventInit -> ErrorEvent

            type TextDecoderStream =
                abstract prototype: TextDecoderStream with get, set
                abstract Create: ?label: D1SessionBookmark * ?options: TextDecoderOptions -> TextDecoderStream

            type Headers =
                abstract prototype: Headers with get, set
                abstract Create: ?init: HeadersInit -> Headers

            type Body =
                abstract prototype: Typescript.Body with get, set
                abstract Create: unit -> Typescript.Body

            type Request =
                abstract prototype: Typescript.Request with get, set

                abstract Create:
                    input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit -> Typescript.Request

            type CloseEvent =
                abstract prototype: CloseEvent with get, set
                abstract Create: ``type``: D1SessionBookmark * ?eventInitDict: Typescript.CloseEventInit -> CloseEvent

            type ReadableStreamDefaultReader =
                abstract prototype: ReadableStreamDefaultReader<option<obj>> with get, set
                abstract Create: stream: ReadableStream<'R> -> ReadableStreamDefaultReader<'R>

            type Response =
                abstract prototype: Typescript.Response with get, set
                abstract redirect: url: U2<URL, string> * ?status: float -> Typescript.Response
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
                            string
                         > *
                    ?init: Typescript.ResponseInit ->
                        Typescript.Response

            type WebSocket =
                abstract CLOSED: WebSocket.CLOSED with get
                abstract CLOSING: WebSocket.CLOSING with get
                abstract OPEN: WebSocket.OPEN with get
                abstract CONNECTING: WebSocket.CONNECTING with get
                abstract prototype: Typescript.WebSocket with get, set

                abstract Create:
                    url: U2<URL, string> * ?protocols: U2<Array<D1SessionBookmark>, string> -> Typescript.WebSocket

            type ByteLengthQueuingStrategy =
                abstract prototype: ByteLengthQueuingStrategy with get, set
                abstract Create: init: Typescript.QueuingStrategyInit -> ByteLengthQueuingStrategy

            type TransformStream =
                abstract prototype: TransformStream<option<obj>, option<obj>> with get, set

                abstract Create:
                    ?transformer: Typescript.Transformer<'I, 'O> *
                    ?writableStrategy: Typescript.QueuingStrategy<'I> *
                    ?readableStrategy: Typescript.QueuingStrategy<'O> ->
                        TransformStream<'I, 'O>

            type WritableStreamDefaultWriter =
                abstract prototype: WritableStreamDefaultWriter<option<obj>> with get, set
                abstract Create: stream: WritableStream<'W> -> WritableStreamDefaultWriter<'W>

            type WritableStream =
                abstract prototype: WritableStream<option<obj>> with get, set

                abstract Create:
                    ?underlyingSink: Typescript.UnderlyingSink<'W> * ?strategy: Typescript.QueuingStrategy<'W> ->
                        WritableStream<'W>

            type ReadableStream =
                abstract prototype: AiTextToImageOutput with get, set

                abstract Create:
                    ?underlyingSource: Typescript.UnderlyingSource<'R> * ?strategy: Typescript.QueuingStrategy<'R> ->
                        ReadableStream<'R>

                abstract Create:
                    underlyingSource: UnderlyingDefaultSource<'R> * ?strategy: Typescript.QueuingStrategy<'R> ->
                        ReadableStream<'R>

                abstract Create:
                    underlyingSource: Typescript.UnderlyingByteSource * ?strategy: ReadableStream.Create.Strategy ->
                        ReadableStream<Uint8Array<ArrayBuffer>>

            type WebSocketPair =
                abstract Create: unit -> WebSocketPair.Create

            type ReadableStreamBYOBReader =
                abstract prototype: ReadableStreamBYOBReader with get, set
                abstract Create: stream: ReadableStream<Uint8Array<ArrayBuffer>> -> ReadableStreamBYOBReader

            type TextEncoderStream =
                abstract prototype: TextEncoderStream with get, set
                abstract Create: unit -> TextEncoderStream

            type CountQueuingStrategy =
                abstract prototype: CountQueuingStrategy with get, set
                abstract Create: init: Typescript.QueuingStrategyInit -> CountQueuingStrategy

            type DecompressionStream =
                abstract prototype: DecompressionStream with get, set
                abstract Create: format: CompressionFormat -> DecompressionStream

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Event = | [<CompiledValue(0)>] ``0``

            type ScheduledEvent =
                abstract BUBBLING_PHASE: ScheduledEvent.BUBBLING_PHASE with get
                abstract AT_TARGET: ScheduledEvent.AT_TARGET with get
                abstract CAPTURING_PHASE: ScheduledEvent.CAPTURING_PHASE with get
                abstract NONE: ScheduledEvent.NONE with get
                abstract prototype: ScheduledEvent with get, set
                abstract Create: ``type``: D1SessionBookmark * ?eventInitDict: Typescript.EventInit -> ScheduledEvent

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type DOMException =
                | [<CompiledValue(14)>] ``14``
                | [<CompiledValue(13)>] ``13``
                | [<CompiledValue(12)>] ``12``
                | [<CompiledValue(11)>] ``11``
                | [<CompiledValue(9)>] ``9``
                | [<CompiledValue(8)>] ``8``
                | [<CompiledValue(15)>] ``15``
                | [<CompiledValue(7)>] ``7``
                | [<CompiledValue(5)>] ``5``
                | [<CompiledValue(4)>] ``4``
                | [<CompiledValue(3)>] ``3``
                | [<CompiledValue(2)>] ``2``
                | [<CompiledValue(1)>] ``1``
                | [<CompiledValue(6)>] ``6``
                | [<CompiledValue(16)>] ``16``
                | [<CompiledValue(17)>] ``17``
                | [<CompiledValue(18)>] ``18``
                | [<CompiledValue(25)>] ``25``
                | [<CompiledValue(24)>] ``24``
                | [<CompiledValue(23)>] ``23``
                | [<CompiledValue(22)>] ``22``
                | [<CompiledValue(21)>] ``21``
                | [<CompiledValue(20)>] ``20``
                | [<CompiledValue(19)>] ``19``
                | [<CompiledValue(10)>] ``10``

            type TailEvent =
                abstract BUBBLING_PHASE: TailEvent.BUBBLING_PHASE with get
                abstract AT_TARGET: TailEvent.AT_TARGET with get
                abstract CAPTURING_PHASE: TailEvent.CAPTURING_PHASE with get
                abstract NONE: TailEvent.NONE with get
                abstract prototype: TailEvent with get, set
                abstract Create: ``type``: D1SessionBookmark * ?eventInitDict: Typescript.EventInit -> TailEvent

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

            type CustomEvent =
                abstract prototype: CustomEvent<option<obj>> with get, set
                abstract Create: ``type``: D1SessionBookmark * ?eventInitDict: CustomEventInit<'T> -> CustomEvent<'T>

            type ExtendableEvent =
                abstract BUBBLING_PHASE: ExtendableEvent.BUBBLING_PHASE with get
                abstract AT_TARGET: ExtendableEvent.AT_TARGET with get
                abstract CAPTURING_PHASE: ExtendableEvent.CAPTURING_PHASE with get
                abstract NONE: ExtendableEvent.NONE with get
                abstract prototype: ExtendableEvent with get, set
                abstract Create: ``type``: D1SessionBookmark * ?eventInitDict: Typescript.EventInit -> ExtendableEvent

            type WebSocketRequestResponsePair =
                abstract prototype: WebSocketRequestResponsePair with get, set

                abstract Create:
                    request: D1SessionBookmark * response: D1SessionBookmark -> WebSocketRequestResponsePair

            type WorkerGlobalScope =
                abstract prototype: WorkerGlobalScope with get, set

            type MessageEvent =
                abstract prototype: MessageEvent<option<obj>> with get, set

                abstract Create:
                    ``type``: D1SessionBookmark * ?eventInitDict: Typescript.MessageEventInit<'T> -> MessageEvent<'T>

            type AbortController =
                abstract prototype: AbortController with get, set
                abstract Create: unit -> AbortController

            type TextDecoder =
                abstract prototype: TextDecoder with get, set
                abstract Create: ?label: D1SessionBookmark * ?options: TextDecoderOptions -> TextDecoder

            type AbortSignal =
                abstract prototype: AbortSignal with get, set
                abstract timeout: milliseconds: float -> AbortSignal
                abstract any: signals: Array<AbortSignal> -> AbortSignal
                abstract abort: ?reason: obj -> AbortSignal
                abstract Create: unit -> AbortSignal

            type HTMLRewriter =
                abstract prototype: HTMLRewriter with get, set
                abstract Create: unit -> HTMLRewriter

            type FixedLengthStream =
                abstract prototype: FixedLengthStream with get, set

                abstract Create:
                    expectedLength: float * ?queuingStrategy: IdentityTransformStreamQueuingStrategy ->
                        FixedLengthStream

            type Cache =
                abstract prototype: Cache with get, set
                abstract Create: unit -> Cache

            type CacheStorage =
                abstract prototype: CacheStorage with get, set
                abstract Create: unit -> CacheStorage

            type CryptoKey =
                abstract prototype: CryptoKey with get, set
                abstract Create: unit -> CryptoKey

            type SubtleCrypto =
                abstract prototype: SubtleCrypto with get, set
                abstract Create: unit -> SubtleCrypto

            type Crypto =
                abstract prototype: Crypto with get, set
                abstract Create: unit -> Crypto

            type FormData =
                abstract prototype: FormData with get, set
                abstract Create: ?form: HTMLFormElement * ?submitter: HTMLElement -> FormData

            type IdentityTransformStream =
                abstract prototype: IdentityTransformStream with get, set
                abstract Create: ?queuingStrategy: IdentityTransformStreamQueuingStrategy -> IdentityTransformStream

            type File =
                abstract prototype: File with get, set

                abstract Create:
                    fileBits: Array<BlobPart> * fileName: D1SessionBookmark * ?options: FilePropertyBag -> File

            type Blob =
                abstract prototype: Blob with get, set
                abstract Create: ?blobParts: Array<BlobPart> * ?options: BlobPropertyBag -> Blob

            type URLPattern =
                abstract prototype: URLPattern with get, set

                abstract Create:
                    ?input: U2<URLPatternInit, string> *
                    ?baseURL: U2<URLPatternOptions, string> *
                    ?patternOptions: URLPatternOptions ->
                        URLPattern

            type TextEncoder =
                abstract prototype: TextEncoder with get, set
                abstract Create: unit -> TextEncoder

            type URLSearchParams =
                abstract prototype: URLSearchParams with get, set

                abstract Create:
                    ?init: U4<Array<Array<D1SessionBookmark>>, URLSearchParams.Create.Init, URLSearchParams, string> ->
                        URLSearchParams

            type URL =
                abstract prototype: URL with get, set
                abstract revokeObjectURL: url: D1SessionBookmark -> unit
                abstract parse: url: U2<URL, string> * ?``base``: U2<URL, string> -> option<URL>
                abstract createObjectURL: obj: U2<Blob, MediaSource> -> D1SessionBookmark
                abstract canParse: url: U2<URL, string> * ?``base``: U2<URL, string> -> bool
                abstract Create: url: U2<URL, string> * ?``base``: U2<URL, string> -> URL

        module rec SetInterval =
            module rec SetTimeout =
                type Callback =
                    abstract Invoke: [<ParamArray>] args: 'Args -> unit
                    abstract Invoke: [<ParamArray>] args: Array<option<obj>> -> unit

        module rec SetTimeout =
            module rec SetTimeout =
                type Callback =
                    abstract Invoke: [<ParamArray>] args: 'Args -> unit
                    abstract Invoke: [<ParamArray>] args: Array<option<obj>> -> unit

        module rec SqlStorage =
            type Cursor =
                abstract prototype: SqlStorageCursor<option<obj>> with get, set
                abstract Create: unit -> SqlStorageCursor

            type Statement =
                abstract prototype: SqlStorageStatement with get, set
                abstract Create: unit -> SqlStorageStatement

        module rec SqlStorageCursor =
            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

            type Next =
                abstract value: 'T with get, set

                [<EmitProperty("done")>]
                abstract ``done``: option<Next.Done> with get, set

                abstract value: option<unit> with get, set

                [<EmitProperty("done")>]
                abstract ``done``: Next.Done with get, set

        module rec StreamBinding =
            module rec CreateDirectUpload =
                module rec Params =
                    type Watermark =
                        abstract id: D1SessionBookmark with get, set

                type Params =
                    abstract watermark: option<StreamDirectUploadWatermark> with get, set
                    abstract scheduledDeletion: option<string> with get, set
                    abstract thumbnailTimestampPct: option<float> with get, set
                    abstract requireSignedURLs: option<bool> with get, set
                    abstract allowedOrigins: option<Array<D1SessionBookmark>> with get, set
                    abstract meta: option<WebAssembly.ModuleImports> with get, set
                    abstract creator: option<D1SessionBookmark> with get, set
                    abstract expiry: option<D1SessionBookmark> with get, set
                    abstract maxDurationSeconds: float with get, set

            module rec Upload =
                type Params =
                    abstract watermarkId: option<D1SessionBookmark> with get, set
                    abstract thumbnailTimestampPct: option<float> with get, set
                    abstract scheduledDeletion: option<string> with get, set
                    abstract requireSignedURLs: option<bool> with get, set
                    abstract meta: option<WebAssembly.ModuleImports> with get, set
                    abstract creator: option<D1SessionBookmark> with get, set
                    abstract allowedOrigins: option<Array<D1SessionBookmark>> with get, set

            type CreateDirectUpload =
                abstract scheduledDeletion: option<string> with get, set
                abstract watermark: option<CreateDirectUpload.Watermark> with get, set
                abstract id: D1SessionBookmark with get, set
                abstract uploadURL: D1SessionBookmark with get, set

        module rec StreamDirectUploadCreateParams =
            type Watermark =
                abstract id: D1SessionBookmark with get, set

        module rec StreamDownloadGetResponse =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Audio =
                | [<CompiledName("error")>] Error
                | [<CompiledName("ready")>] Ready
                | [<CompiledName("inprogress")>] Inprogress

        module rec StreamScopedCaptions =
            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Upload =
                | [<CompiledName("ready")>] Ready
                | [<CompiledName("inprogress")>] Inprogress
                | [<CompiledName("error")>] Error

        module rec StreamScopedDownloads =
            module rec Generate =
                type Audio =
                    abstract url: option<D1SessionBookmark> with get, set
                    abstract status: StreamDownloadStatus with get, set
                    abstract percentComplete: float with get, set

            type Generate =
                [<EmitProperty("default")>]
                abstract ``default``: option<StreamDownload> with get, set

                abstract audio: option<StreamDownload> with get, set

        module rec StreamUpdateVideoParams =
            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec StreamVideo =
            type Input =
                abstract height: float with get, set
                abstract width: float with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Generate =
                | [<CompiledName("upperRight")>] UpperRight
                | [<CompiledName("upperLeft")>] UpperLeft
                | [<CompiledName("lowerLeft")>] LowerLeft
                | [<CompiledName("lowerRight")>] LowerRight
                | [<CompiledName("center")>] Center

            type Status =
                abstract errorReasonText: D1SessionBookmark with get, set
                abstract errorReasonCode: D1SessionBookmark with get, set
                abstract pctComplete: option<D1SessionBookmark> with get, set
                abstract step: option<D1SessionBookmark> with get, set
                abstract state: D1SessionBookmark with get, set

            type PublicDetails =
                abstract logo: option<string> with get, set

                [<EmitProperty("channel_link")>]
                abstract channelLink: option<string> with get, set

                [<EmitProperty("share_link")>]
                abstract shareLink: option<string> with get, set

                abstract title: option<string> with get, set

        module rec StreamVideoHandle =
            module rec Update =
                type Params =
                    abstract thumbnailTimestampPct: option<float> with get, set
                    abstract scheduledDeletion: option<string> with get, set
                    abstract requireSignedURLs: option<bool> with get, set
                    abstract meta: option<WebAssembly.ModuleImports> with get, set
                    abstract maxDurationSeconds: option<float> with get, set
                    abstract creator: option<D1SessionBookmark> with get, set
                    abstract allowedOrigins: option<Array<D1SessionBookmark>> with get, set

        module rec StreamVideos =
            module rec List =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Params =
                    | [<CompiledName("eq")>] Eq
                    | [<CompiledName("gt")>] Gt
                    | [<CompiledName("gte")>] Gte
                    | [<CompiledName("lt")>] Lt
                    | [<CompiledName("lte")>] Lte

        module rec StreamWatermarks =
            module rec Generate =
                [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                type Params =
                    | [<CompiledName("upperRight")>] UpperRight
                    | [<CompiledName("upperLeft")>] UpperLeft
                    | [<CompiledName("lowerLeft")>] LowerLeft
                    | [<CompiledName("lowerRight")>] LowerRight
                    | [<CompiledName("center")>] Center

            type Generate =
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

        module rec TailStream =
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

                [<EmitProperty("type")>]
                abstract ``type``: Onset.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "QueueEventInfo")>]
            type QueueEventInfo =
                abstract batchSize: float with get
                abstract queueName: D1SessionBookmark with get

                [<EmitProperty("type")>]
                abstract ``type``: QueueEventInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "SpanOpen")>]
            type SpanOpen =
                abstract info: option<U3<FetchEventInfo, JsRpcEventInfo, Attributes>> with get
                abstract spanId: D1SessionBookmark with get
                abstract name: D1SessionBookmark with get

                [<EmitProperty("type")>]
                abstract ``type``: SpanOpen.Type with get

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Return = | [<CompiledName("return")>] Return

            [<Import("@cloudflare/workers-types.TailStream", "DroppedEventsDiagnostic")>]
            type DroppedEventsDiagnostic =
                abstract count: float with get
                abstract diagnosticsType: DroppedEventsDiagnostic.DiagnosticsType with get

            [<Import("@cloudflare/workers-types.TailStream", "SpanContext")>]
            type SpanContext =
                abstract spanId: option<D1SessionBookmark> with get
                abstract traceId: D1SessionBookmark with get

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type FetchEventInfo = | [<CompiledName("fetch")>] Fetch

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type HibernatableWebSocketEventInfo = | [<CompiledName("hibernatableWebSocket")>] HibernatableWebSocket

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
                | [<CompiledName("outcome")>] Outcome

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type JsRpcEventInfo = | [<CompiledName("jsrpc")>] Jsrpc

            [<Import("@cloudflare/workers-types.TailStream", "Exception")>]
            type Exception =
                abstract stack: option<D1SessionBookmark> with get
                abstract message: D1SessionBookmark with get
                abstract name: D1SessionBookmark with get

                [<EmitProperty("type")>]
                abstract ``type``: Exception.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "ScriptVersion")>]
            type ScriptVersion =
                abstract message: option<D1SessionBookmark> with get
                abstract tag: option<D1SessionBookmark> with get
                abstract id: D1SessionBookmark with get

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type StreamDiagnostic = | [<CompiledName("streamDiagnostic")>] StreamDiagnostic

            [<Import("@cloudflare/workers-types.TailStream", "Header")>]
            type Header =
                abstract value: D1SessionBookmark with get
                abstract name: D1SessionBookmark with get

            [<Import("@cloudflare/workers-types.TailStream", "FetchResponseInfo")>]
            type FetchResponseInfo =
                abstract statusCode: float with get

                [<EmitProperty("type")>]
                abstract ``type``: FetchResponseInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "EmailEventInfo")>]
            type EmailEventInfo =
                abstract rawSize: float with get
                abstract rcptTo: D1SessionBookmark with get
                abstract mailFrom: D1SessionBookmark with get

                [<EmitProperty("type")>]
                abstract ``type``: EmailEventInfo.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "HibernatableWebSocketEventInfoClose")>]
            type HibernatableWebSocketEventInfoClose =
                abstract wasClean: bool with get
                abstract code: float with get

                [<EmitProperty("type")>]
                abstract ``type``: HibernatableWebSocketEventInfoClose.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "TracePreviewInfo")>]
            type TracePreviewInfo =
                abstract name: D1SessionBookmark with get
                abstract slug: D1SessionBookmark with get
                abstract id: D1SessionBookmark with get

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

            [<Import("@cloudflare/workers-types.TailStream", "Attributes")>]
            type Attributes =
                abstract info: Array<Attribute> with get

                [<EmitProperty("type")>]
                abstract ``type``: Attributes.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "HibernatableWebSocketEventInfoMessage")>]
            type HibernatableWebSocketEventInfoMessage =
                [<EmitProperty("type")>]
                abstract ``type``: HibernatableWebSocketEventInfoMessage.Type with get

            type TailEventHandlerType = obj

            [<Import("@cloudflare/workers-types.TailStream", "DiagnosticChannelEvent")>]
            type DiagnosticChannelEvent =
                abstract message: option<obj> with get
                abstract channel: D1SessionBookmark with get

                [<EmitProperty("type")>]
                abstract ``type``: DiagnosticChannelEvent.Type with get

            type EventType = obj

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type HibernatableWebSocketEventInfoError = | [<CompiledName("error")>] Error

            [<Import("@cloudflare/workers-types.TailStream", "TailEvent")>]
            type TailEvent<'Event when 'Event :> EventType> =
                abstract event: 'Event with get
                abstract sequence: float with get
                abstract timestamp: Date with get
                abstract spanContext: SpanContext with get
                abstract invocationId: D1SessionBookmark with get

            [<Import("@cloudflare/workers-types.TailStream", "Attribute")>]
            type Attribute =
                abstract value: U6<Array<D1SessionBookmark>, Array<bool>, Array<float>, string, bool, float> with get
                abstract name: D1SessionBookmark with get

            [<Import("@cloudflare/workers-types.TailStream", "Log")>]
            type Log =
                abstract message: obj with get
                abstract level: Log.Level with get

                [<EmitProperty("type")>]
                abstract ``type``: Log.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "ScheduledEventInfo")>]
            type ScheduledEventInfo =
                abstract cron: D1SessionBookmark with get
                abstract scheduledTime: Date with get

                [<EmitProperty("type")>]
                abstract ``type``: ScheduledEventInfo.Type with get

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

            [<Import("@cloudflare/workers-types.TailStream", "SpanClose")>]
            type SpanClose =
                abstract outcome: EventOutcome with get

                [<EmitProperty("type")>]
                abstract ``type``: SpanClose.Type with get

            [<Import("@cloudflare/workers-types.TailStream", "ConnectEventInfo")>]
            type ConnectEventInfo =
                [<EmitProperty("type")>]
                abstract ``type``: ConnectEventInfo.Type with get

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type TraceEventInfo = | [<CompiledName("trace")>] Trace

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type AlarmEventInfo = | [<CompiledName("alarm")>] Alarm

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type CustomEventInfo = | [<CompiledName("custom")>] Custom

            [<Import("@cloudflare/workers-types.TailStream", "TailEventHandler")>]
            type TailEventHandler<'Event when 'Event :> EventType> =
                abstract Invoke: event: TailEvent<'Event> -> option<Promise<unit>>

        module rec ToMarkdownService =
            module rec Transform =
                module rec Options =
                    module rec Transform =
                        module rec Options =
                            module rec ConversionOptions =
                                module rec Transform =
                                    module rec Options =
                                        module rec ConversionOptions =
                                            type Docx =
                                                abstract maxConvertedImages: option<float> with get, set
                                                abstract convert: option<bool> with get, set
                                                abstract descriptionLanguage: option<Docx.DescriptionLanguage> with get, set
                                                abstract images: option<EmbeddedImageConversionOptions> with get, set

                                            type Html =
                                                abstract cssSelector: option<D1SessionBookmark> with get, set
                                                abstract hostname: option<D1SessionBookmark> with get, set
                                                abstract images: option<Html.Images> with get, set
                                                abstract convertOGImage: option<bool> with get, set
                                                abstract maxConvertedImages: option<float> with get, set
                                                abstract convert: option<bool> with get, set
                                                abstract descriptionLanguage: option<Html.DescriptionLanguage> with get, set

                                            type Image =
                                                abstract descriptionLanguage: option<Image.DescriptionLanguage> with get, set

                                            type Pdf =
                                                abstract metadata: option<bool> with get, set
                                                abstract images: option<EmbeddedImageConversionOptions> with get, set

                            module rec Gateway =
                                module rec Transform =
                                    module rec Options =
                                        module rec Gateway =
                                            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                                            type Retries =
                                                | [<CompiledName("constant")>] Constant
                                                | [<CompiledName("linear")>] Linear
                                                | [<CompiledName("exponential")>] Exponential

                                type Params =
                                    abstract Item: key: D1SessionBookmark -> option<obj>

                            type Gateway =
                                abstract retries: option<GatewayRetries> with get, set
                                abstract requestTimeoutMs: option<float> with get, set
                                abstract eventId: option<D1SessionBookmark> with get, set
                                abstract collectLog: option<bool> with get, set
                                abstract metadata: option<WebAssembly.ModuleImports> with get, set
                                abstract skipCache: option<bool> with get, set
                                abstract cacheTtl: option<float> with get, set
                                abstract cacheKey: option<D1SessionBookmark> with get, set
                                abstract id: D1SessionBookmark with get, set

                            type ConversionOptions =
                                abstract pdf: option<ConversionOptions.Pdf> with get, set
                                abstract image: option<ImageConversionOptions> with get, set
                                abstract docx: option<ConversionOptions.Docx> with get, set
                                abstract html: option<ConversionOptions.Html> with get, set

                type Options =
                    abstract conversionOptions: option<ConversionOptions> with get, set
                    abstract extraHeaders: option<obj> with get, set
                    abstract gateway: option<GatewayOptions> with get, set

                type Files =
                    abstract blob: Blob with get, set
                    abstract name: D1SessionBookmark with get, set

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type Transform =
                | [<CompiledName("error")>] Error
                | [<CompiledName("markdown")>] Markdown

            type Supported =
                abstract extension: D1SessionBookmark with get, set
                abstract mimeType: D1SessionBookmark with get, set

        module rec TraceItem =
            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec Tracing =
            module rec EnterSpan =
                type Callback =
                    abstract Invoke: span: Span * [<ParamArray>] args: 'A -> 'T

            type Span =
                abstract prototype: Span with get, set
                abstract Create: unit -> Span

        module rec URLSearchParams =
            module rec ForEach =
                type Callback =
                    abstract Invoke:
                        this: 'This * value: D1SessionBookmark * key: D1SessionBookmark * parent: URLSearchParams ->
                            unit

            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec UniversalGatewayOptions =
            module rec Transform =
                module rec Options =
                    module rec Gateway =
                        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                        type Retries =
                            | [<CompiledName("constant")>] Constant
                            | [<CompiledName("linear")>] Linear
                            | [<CompiledName("exponential")>] Exponential

        module rec UserMessageContentPart =
            module rec Messages =
                module rec Content =
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

                        [<EmitProperty("file_id")>]
                        abstract fileId: option<D1SessionBookmark> with get, set

                        [<EmitProperty("file_data")>]
                        abstract fileData: option<D1SessionBookmark> with get, set

        module rec VectorizeIndexDetails =
            type Config =
                abstract metric: VectorizeDistanceMetric with get, set
                abstract dimensions: float with get, set
                abstract preset: D1SessionBookmark with get, set

        module rec VectorizeMatches =
            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec VectorizeQueryOptions =
            module rec Filter =
                module rec Filter =
                    [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
                    type Item =
                        | [<CompiledValue(false)>] False
                        | [<CompiledValue(true)>] True

            type Filter =
                abstract Item:
                    key: D1SessionBookmark -> option<U5<Filter.Item, Filter.Item, Filter.Item, string, float>>

        module rec VectorizeVector =
            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec VectorizeVectorMetadata =
            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec WebAssembly =
            module rec Instance =
                type Imports =
                    abstract Item: key: D1SessionBookmark -> option<obj>

                type Exports =
                    abstract Item: key: D1SessionBookmark -> option<obj>

            module rec Instantiate =
                type Imports =
                    abstract Item: key: D1SessionBookmark -> option<obj>

            module rec ModuleImports =
                type Params =
                    abstract Item: key: D1SessionBookmark -> option<obj>

            [<Import("@cloudflare/workers-types.WebAssembly", "Memory"); AbstractClass; AllowNullLiteral>]
            type Memory private () =
                [<EmitConstructor>]
                abstract Create: descriptor: Typescript.WebAssembly.MemoryDescriptor -> Memory

                abstract buffer: ArrayBuffer with get
                abstract grow: delta: float -> float

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type TableKind =
                | [<CompiledName("anyfunc")>] Anyfunc
                | [<CompiledName("externref")>] Externref

            [<Import("@cloudflare/workers-types.WebAssembly", "Global"); AbstractClass; AllowNullLiteral>]
            type Global private () =
                [<EmitConstructor>]
                abstract Create: descriptor: Typescript.WebAssembly.GlobalDescriptor<ValueType> * ?value: obj -> Global

                abstract value: option<obj> with get, set
                abstract valueOf: unit -> option<obj>

            type Exports = Exports

            type Validate =
                abstract Invoke: bytes: BufferSource -> bool
                abstract Invoke: bytes: BufferSource -> bool

            type Instantiate =
                abstract Invoke:
                    ``module``: WebAssembly.Module * ?imports: WebAssembly.Imports -> Promise<WebAssembly.Instance>

                abstract Invoke:
                    moduleObject: WebAssembly.Module * ?importObject: WebAssembly.Imports ->
                        Promise<WebAssembly.Instance>

                abstract Invoke:
                    bytes: BufferSource * ?importObject: WebAssembly.Imports ->
                        Promise<WebAssembly.WebAssemblyInstantiatedSource>

            type ImportValue = U5<Function, WebAssembly.Table, WebAssembly.Memory, WebAssembly.Global<ValueType>, float>

            [<Import("@cloudflare/workers-types.WebAssembly", "RuntimeError"); AbstractClass; AllowNullLiteral>]
            type RuntimeError private () =
                inherit exn()

                [<EmitConstructor>]
                abstract Create: ?message: D1SessionBookmark -> RuntimeError

            [<Import("@cloudflare/workers-types.WebAssembly", "CompileError"); AbstractClass; AllowNullLiteral>]
            type CompileError private () =
                inherit exn()

                [<EmitConstructor>]
                abstract Create: ?message: D1SessionBookmark -> CompileError

            type ModuleImports = obj
            type ExportValue = U4<Function, WebAssembly.Global<ValueType>, WebAssembly.Memory, WebAssembly.Table>

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ValueType =
                | [<CompiledName("anyfunc")>] Anyfunc
                | [<CompiledName("externref")>] Externref
                | [<CompiledName("f32")>] F32
                | [<CompiledName("f64")>] F64
                | [<CompiledName("i32")>] I32
                | [<CompiledName("i64")>] I64
                | [<CompiledName("v128")>] V128

            type Imports = Imports

            [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
            type ImportExportKind =
                | [<CompiledName("function")>] Function
                | [<CompiledName("global")>] Global
                | [<CompiledName("memory")>] Memory
                | [<CompiledName("table")>] Table

            [<Import("@cloudflare/workers-types.WebAssembly", "Table"); AbstractClass; AllowNullLiteral>]
            type Table private () =
                [<EmitConstructor>]
                abstract Create: descriptor: Typescript.WebAssembly.TableDescriptor * ?value: obj -> Table

                abstract length: float with get
                abstract set: index: float * ?value: obj -> unit
                abstract grow: delta: float * ?value: obj -> float
                abstract get: index: float -> option<obj>

            [<Import("@cloudflare/workers-types.WebAssembly", "Instance"); AbstractClass; AllowNullLiteral>]
            type Instance private () =
                [<EmitConstructor>]
                abstract Create: ``module``: WebAssembly.Module * ?imports: WebAssembly.Imports -> Instance

                abstract exports: WebAssembly.Exports with get

            [<Import("@cloudflare/workers-types.WebAssembly", "Module"); AbstractClass; AllowNullLiteral>]
            type Module private () =
                abstract imports: ``module``: WebAssembly.Module -> Array<Typescript.WebAssembly.ModuleImportDescriptor>
                abstract exports: ``module``: WebAssembly.Module -> Array<Typescript.WebAssembly.ModuleExportDescriptor>

                abstract customSections:
                    ``module``: WebAssembly.Module * sectionName: D1SessionBookmark -> Array<ArrayBuffer>

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

        module rec WebSearchOptions =
            module rec WebSearchOptions =
                module rec UserLocation =
                    module rec WebSearchOptions =
                        module rec UserLocation =
                            type Approximate =
                                abstract timezone: option<D1SessionBookmark> with get, set
                                abstract region: option<D1SessionBookmark> with get, set
                                abstract country: option<D1SessionBookmark> with get, set
                                abstract city: option<D1SessionBookmark> with get, set

                type UserLocation =
                    abstract approximate: UserLocation.Approximate with get, set

                    [<EmitProperty("type")>]
                    abstract ``type``: UserLocation.Type with get, set

        module rec WebSearchUserLocation =
            module rec WebSearchOptions =
                module rec UserLocation =
                    type Approximate =
                        abstract timezone: option<D1SessionBookmark> with get, set
                        abstract region: option<D1SessionBookmark> with get, set
                        abstract country: option<D1SessionBookmark> with get, set
                        abstract city: option<D1SessionBookmark> with get, set

        module rec WorkerGlobalScope =
            type EventTarget =
                abstract prototype: EventTarget with get, set
                abstract Create: unit -> EventTarget

        module rec WorkerLoaderWorkerCode =
            type Get =
                abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

                abstract fetch:
                    input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                        Promise<Typescript.Response>

            type Params =
                abstract Item: key: D1SessionBookmark -> option<obj>

        module rec WorkflowInstance =
            module rec SendEvent =
                type Typepayload =
                    abstract payload: option<obj> with get, set

                    [<EmitProperty("type")>]
                    abstract ``type``: D1SessionBookmark with get, set

            module rec Status =
                module rec Status =
                    type Error =
                        abstract message: D1SessionBookmark with get, set
                        abstract name: D1SessionBookmark with get, set

            type Status =
                abstract output: option<obj> with get, set
                abstract error: option<Status.Error> with get, set
                abstract status: CloudflareWorkersModule.WorkflowInstanceStatus with get, set

        module rec WorkflowInstanceCreateOptions =
            type TemplateLiteral =
                abstract Value: string
                abstract Create: v0: float -> TemplateLiteral

            type Retention =
                abstract errorRetention: option<WorkflowRetentionDuration> with get, set
                abstract successRetention: option<WorkflowRetentionDuration> with get, set

        module rec ``Cloudflare:node`` =
            module rec HttpServerHandler =
                module rec Invoke =
                    type Options =
                        abstract port: float with get, set

            module rec NodeStyleServer =
                type Address =
                    abstract port: option<float> with get, set

            [<Import("@cloudflare/workers-types.cloudflare:node", "NodeStyleServer")>]
            type NodeStyleServer =
                abstract address: unit -> NodeStyleServer.Address
                abstract listen: [<ParamArray>] args: Array<option<obj>> -> 'NodeStyleServer

            type HttpServerHandler =
                abstract Invoke:
                    server: NodeStyleServer -> ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>>

                abstract Invoke:
                    options: HttpServerHandler.Invoke.Options ->
                        ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>>

                abstract Invoke: port: float -> ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>>

            type ``Cloudflare:node`` =
                [<Import("@cloudflare/workers-types.cloudflare:node", "httpServerHandler")>]
                static member httpServerHandler
                    (port: float)
                    : ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>> =
                    JS.undefined

                [<Import("@cloudflare/workers-types.cloudflare:node", "httpServerHandler")>]
                static member httpServerHandler
                    (options: HttpServerHandler.Options)
                    : ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>> =
                    JS.undefined

                [<Import("@cloudflare/workers-types.cloudflare:node", "httpServerHandler")>]
                static member httpServerHandler
                    (server: NodeStyleServer)
                    : ExportedHandler<option<obj>, option<obj>, option<obj>, option<obj>> =
                    JS.undefined

        module rec ``Cloudflare:pipelines`` =
            module rec Pipeline =
                type I =
                    abstract Item: key: D1SessionBookmark -> option<obj>

            module rec PipelineRecord =
                type I =
                    abstract Item: key: D1SessionBookmark -> option<obj>

            module rec PipelineTransformationEntrypoint =
                module rec Run =
                    type Metadata =
                        abstract pipelineName: D1SessionBookmark with get, set
                        abstract pipelineId: D1SessionBookmark with get, set

                type I =
                    abstract Item: key: D1SessionBookmark -> option<obj>

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
                abstract run: records: Array<'I> * metadata: PipelineBatchMetadata -> Promise<Array<'O>>

            [<Import("@cloudflare/workers-types.cloudflare:pipelines", "PipelineBatchMetadata")>]
            type PipelineBatchMetadata =
                abstract pipelineName: D1SessionBookmark with get, set
                abstract pipelineId: D1SessionBookmark with get, set

            [<Import("@cloudflare/workers-types.cloudflare:pipelines", "Pipeline")>]
            type Pipeline<'T when 'T :> PipelineRecord> =
                abstract send: records: Array<'T> -> Promise<unit>

        module rec ``Cloudflare:workflows`` =
            [<Import("@cloudflare/workers-types.cloudflare:workflows", "NonRetryableError");
              AbstractClass;
              AllowNullLiteral>]
            type NonRetryableError private () =
                inherit exn()

                [<EmitConstructor>]
                abstract Create: message: D1SessionBookmark * ?name: D1SessionBookmark -> NonRetryableError

        [<Import("@cloudflare/workers-types", "TraceItemHibernatableWebSocketEventInfoClose")>]
        type TraceItemHibernatableWebSocketEventInfoClose =
            abstract wasClean: bool with get
            abstract code: float with get
            abstract webSocketEventType: D1SessionBookmark with get

        type SqlStorageValue = option<U3<ArrayBuffer, string, float>>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfMetaLlama3211BVisionInstruct private () =
            abstract postProcessedOutputs: AiCfMetaLlama3211BVisionInstructOutput with get, set
            abstract inputs: AiCfMetaLlama3211BVisionInstructInput with get, set

        type ResponseStreamEvent =
            U15<
                ResponseStreamEvent,
                ResponseStreamEvent,
                ResponseStreamEvent,
                ResponseStreamEvent,
                ResponseStreamEvent,
                ResponseStreamEvent,
                ResponseStreamEvent,
                ResponseStreamEvent,
                ResponseStreamEvent,
                ResponseStreamEvent,
                ResponseStreamEvent,
                ResponseStreamEvent,
                ResponseStreamEvent,
                ResponseStreamEvent,
                ResponseStreamEvent
             >

        [<Import("@cloudflare/workers-types", "AiSearchMultiSearchOptions")>]
        type AiSearchMultiSearchOptions =
            [<EmitProperty("instance_ids")>]
            abstract instanceIds: Array<D1SessionBookmark> with get, set

            abstract cache: option<AiSearchMultiSearchOptions.Cache> with get, set
            abstract reranking: option<AiSearchMultiSearchOptions.Reranking> with get, set

            [<EmitProperty("query_rewrite")>]
            abstract queryRewrite: option<AiSearchMultiSearchOptions.QueryRewrite> with get, set

            abstract retrieval: option<AiSearchMultiSearchOptions.Retrieval> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "BaseAiTextToSpeech"); AbstractClass; AllowNullLiteral>]
        type BaseAiTextToSpeech private () =
            abstract postProcessedOutputs: AiTextToSpeechOutput with get, set
            abstract inputs: AiTextToSpeechInput with get, set

        [<Import("@cloudflare/workers-types", "AiGatewayInternalError"); AbstractClass; AllowNullLiteral>]
        type AiGatewayInternalError private () =
            inherit exn()

        type EventPluginContext =
            abstract ASSETS: EventPluginContext.ASSETS with get, set

        type AiCfBaaiBgeM3Output = obj

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionResponseMessage = | [<CompiledName("assistant")>] Assistant

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

            abstract tools:
                option<Array<U2<AiCfQwenQwen330BA3BFp8Messages1.Tools, AiCfQwenQwen330BA3BFp8Messages1.Tools>>> with get, set

            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: Array<AiCfQwenQwen330BA3BFp8Messages1.Messages> with get, set

        [<Import("@cloudflare/workers-types", "ImageMetadata")>]
        type ImageMetadata =
            abstract creator: option<D1SessionBookmark> with get, set
            abstract draft: option<bool> with get, set
            abstract variants: Array<D1SessionBookmark> with get, set
            abstract meta: option<WebAssembly.ModuleImports> with get, set
            abstract requireSignedURLs: bool with get, set
            abstract uploaded: option<D1SessionBookmark> with get, set
            abstract filename: option<D1SessionBookmark> with get, set
            abstract id: D1SessionBookmark with get, set

        type DurableObjectNamespace =
            abstract name: option<D1SessionBookmark> with get
            abstract id: DurableObjectId with get
            abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

            abstract fetch:
                input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                    Promise<Typescript.Response>

            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke:
                [<ParamArray>] args: DurableObjectNamespace.Invoke.Args ->
                    U2<DurableObjectNamespace.Invoke, U2<DurableObjectNamespace.Invoke, unit>>

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

        [<Import("@cloudflare/workers-types", "Ai_Cf_Pfnet_Plamo_Embedding_1B_Output")>]
        type AiCfPfnetPlamoEmbedding1BOutput =
            abstract shape: float * float with get, set
            abstract data: Array<AiSentenceSimilarityOutput> with get, set

        [<Import("@cloudflare/workers-types", "VectorizeMatch")>]
        type VectorizeMatch =
            abstract score: float with get, set
            abstract metadata: option<VectorizeMatch.Metadata> with get, set

            [<EmitProperty("namespace")>]
            abstract ``namespace``: option<string> with get, set

            abstract id: D1SessionBookmark with get, set
            abstract values: option<U3<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>, Array<float>>> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseFunctionToolCall =
            | [<CompiledName("in_progress")>] InProgress
            | [<CompiledName("completed")>] Completed
            | [<CompiledName("incomplete")>] Incomplete
            | [<CompiledName("function_call")>] FunctionCall

        [<Import("@cloudflare/workers-types", "WebSocketAcceptOptions")>]
        type WebSocketAcceptOptions =
            abstract allowHalfOpen: option<bool> with get, set

        type AiCfBaaiBgeLargeEnV15Input = obj

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type RequestInitCfPropertiesImage =
            | [<CompiledName("h")>] H
            | [<CompiledName("v")>] V
            | [<CompiledName("hv")>] Hv
            | [<CompiledName("share-publicly")>] SharePublicly
            | [<CompiledName("keep")>] Keep
            | [<CompiledName("copyright")>] Copyright
            | [<CompiledName("none")>] None
            | [<CompiledName("avif")>] Avif
            | [<CompiledName("webp")>] Webp
            | [<CompiledName("json")>] Json
            | [<CompiledName("jpeg")>] Jpeg
            | [<CompiledName("png")>] Png
            | [<CompiledName("baseline-jpeg")>] BaselineJpeg
            | [<CompiledName("png-force")>] PngForce
            | [<CompiledName("svg")>] Svg
            | [<CompiledName("low")>] Low
            | [<CompiledName("medium-low")>] MediumLow
            | [<CompiledName("medium-high")>] MediumHigh
            | [<CompiledName("high")>] High
            | [<CompiledName("fast")>] Fast

        [<Import("@cloudflare/workers-types", "FetcherPutOptions")>]
        type FetcherPutOptions =
            abstract expirationTtl: option<float> with get, set
            abstract expiration: option<float> with get, set

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

        [<Import("@cloudflare/workers-types", "AiAutomaticSpeechRecognitionInput")>]
        type AiAutomaticSpeechRecognitionInput =
            abstract audio: AiSentenceSimilarityOutput with get, set

        [<Import("@cloudflare/workers-types", "Vectorize"); AbstractClass; AllowNullLiteral>]
        type Vectorize private () =
            abstract getByIds: ids: Array<D1SessionBookmark> -> Promise<Array<VectorizeVector>>
            abstract deleteByIds: ids: Array<D1SessionBookmark> -> Promise<VectorizeAsyncMutation>
            abstract upsert: vectors: Array<VectorizeVector> -> Promise<VectorizeAsyncMutation>
            abstract insert: vectors: Array<VectorizeVector> -> Promise<VectorizeAsyncMutation>

            abstract queryById:
                vectorId: D1SessionBookmark * ?options: VectorizeQueryOptions -> Promise<VectorizeMatches>

            abstract query:
                vector: U3<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>, Array<float>> *
                ?options: VectorizeQueryOptions ->
                    Promise<VectorizeMatches>

            abstract describe: unit -> Promise<VectorizeIndexInfo>

        [<Import("@cloudflare/workers-types", "Event"); AbstractClass; AllowNullLiteral>]
        type Event private () =
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

            [<EmitProperty("type")>]
            abstract ``type``: D1SessionBookmark with get

            abstract composedPath: unit -> Array<EventTarget>
            abstract stopPropagation: unit -> unit
            abstract preventDefault: unit -> unit
            abstract stopImmediatePropagation: unit -> unit

        [<Import("@cloudflare/workers-types", "TailEvent"); AbstractClass; AllowNullLiteral>]
        type TailEvent private () =
            inherit ExtendableEvent()
            abstract traces: Array<TraceItem> with get
            abstract events: Array<TraceItem> with get

        type AiTextClassificationOutput = obj

        [<Import("@cloudflare/workers-types", "SubtleCryptoHashAlgorithm")>]
        type SubtleCryptoHashAlgorithm =
            abstract name: D1SessionBookmark with get, set

        type AiCfGoogleGemma312BItInput = obj

        [<Import("@cloudflare/workers-types", "SocketOptions")>]
        type SocketOptions =
            abstract highWaterMark: option<float> with get, set
            abstract allowHalfOpen: bool with get, set
            abstract secureTransport: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "StreamUrlUploadParams")>]
        type StreamUrlUploadParams =
            abstract watermarkId: option<D1SessionBookmark> with get, set
            abstract thumbnailTimestampPct: option<float> with get, set
            abstract scheduledDeletion: option<string> with get, set
            abstract requireSignedURLs: option<bool> with get, set
            abstract meta: option<WebAssembly.ModuleImports> with get, set
            abstract creator: option<D1SessionBookmark> with get, set
            abstract allowedOrigins: option<Array<D1SessionBookmark>> with get, set

        [<Import("@cloudflare/workers-types", "EmailExportedHandler")>]
        type EmailExportedHandler<'Props, 'Env> =
            abstract Invoke:
                message: ForwardableEmailMessage * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "TraceItemAlarmEventInfo")>]
        type TraceItemAlarmEventInfo =
            abstract scheduledTime: Date with get

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionContentPart =
            | [<CompiledName("file")>] File
            | [<CompiledName("input_audio")>] InputAudio
            | [<CompiledName("image_url")>] ImageUrl

        [<Import("@cloudflare/workers-types", "Ai_Cf_Openai_Whisper_Output")>]
        type AiCfOpenaiWhisperOutput =
            abstract vtt: option<D1SessionBookmark> with get, set
            abstract words: option<Array<AiCfOpenaiWhisperOutput.Words>> with get, set

            [<EmitProperty("word_count")>]
            abstract wordCount: option<float> with get, set

            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfMistralaiMistralSmall3124BInstruct private () =
            abstract postProcessedOutputs: AiCfMistralaiMistralSmall3124BInstructOutput with get, set
            abstract inputs: AiCfMistralaiMistralSmall3124BInstructInput with get, set

        [<Import("@cloudflare/workers-types", "AiSearchJobLogsParams")>]
        type AiSearchJobLogsParams =
            [<EmitProperty("per_page")>]
            abstract perPage: option<float> with get, set

            abstract page: option<float> with get, set

        [<Import("@cloudflare/workers-types", "EventTargetEventListenerOptions")>]
        type EventTargetEventListenerOptions =
            abstract capture: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "DocumentEnd")>]
        type DocumentEnd =
            abstract append: content: D1SessionBookmark * ?options: ContentOptions -> DocumentEnd

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

            abstract reranking: option<AutoRagAiSearchRequest.Reranking> with get, set

            [<EmitProperty("ranking_options")>]
            abstract rankingOptions: option<AutoRagAiSearchRequest.RankingOptions> with get, set

            [<EmitProperty("max_num_results")>]
            abstract maxNumResults: option<float> with get, set

            abstract filters: option<U2<AutoRagAiSearchRequest.Filters, AutoRagAiSearchRequest.Filters>> with get, set
            abstract query: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Dev_Output")>]
        type AiCfBlackForestLabsFlux2DevOutput =
            abstract image: option<D1SessionBookmark> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type WebSearchUserLocation = | [<CompiledName("approximate")>] Approximate

        [<Import("@cloudflare/workers-types", "Ai_Cf_Pfnet_Plamo_Embedding_1B_Input")>]
        type AiCfPfnetPlamoEmbedding1BInput =
            abstract text: U2<Array<D1SessionBookmark>, string> with get, set

        [<Import("@cloudflare/workers-types", "AbortSignal"); AbstractClass; AllowNullLiteral>]
        type AbortSignal private () =
            inherit EventTarget()
            abstract onabort: option<obj> with set
            abstract onabort: option<obj> with get
            abstract reason: option<obj> with get
            abstract aborted: bool with get
            abstract throwIfAborted: unit -> unit
            abstract any: signals: Array<AbortSignal> -> AbortSignal
            abstract timeout: delay: float -> AbortSignal
            abstract abort: ?reason: obj -> AbortSignal

        [<Import("@cloudflare/workers-types", "BaseAiTextClassification"); AbstractClass; AllowNullLiteral>]
        type BaseAiTextClassification private () =
            abstract postProcessedOutputs: AiTextClassificationOutput with get, set
            abstract inputs: AiTextClassificationInput with get, set

        [<Import("@cloudflare/workers-types", "ImageDrawOptions")>]
        type ImageDrawOptions =
            abstract right: option<float> with get, set
            abstract bottom: option<float> with get, set
            abstract left: option<float> with get, set
            abstract top: option<float> with get, set
            abstract repeat: option<U2<bool, string>> with get, set
            abstract opacity: option<float> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type DurableObjectJurisdiction =
            | [<CompiledName("eu")>] Eu
            | [<CompiledName("fedramp")>] Fedramp
            | [<CompiledName("fedramp-high")>] FedrampHigh

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

        [<Import("@cloudflare/workers-types", "AiSearchMultiSearchError")>]
        type AiSearchMultiSearchError =
            abstract message: D1SessionBookmark with get, set

            [<EmitProperty("instance_id")>]
            abstract instanceId: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Output")>]
        type AiCfMetaLlama4Scout17B16EInstructOutput =
            [<EmitProperty("tool_calls")>]
            abstract toolCalls: option<Array<AiCfMetaLlama4Scout17B16EInstructOutput.ToolCalls>> with get, set

            abstract usage: option<AiCfMetaLlama4Scout17B16EInstructOutput.Usage> with get, set
            abstract response: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AudioParams =
            | [<CompiledName("wav")>] Wav
            | [<CompiledName("aac")>] Aac
            | [<CompiledName("mp3")>] Mp3
            | [<CompiledName("flac")>] Flac
            | [<CompiledName("opus")>] Opus
            | [<CompiledName("pcm16")>] Pcm16

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

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseFormatTextJSONSchemaConfig = | [<CompiledName("json_schema")>] JsonSchema

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfAisingaporeGemmaSeaLionV427BItJSONMode =
            | [<CompiledName("json_object")>] JsonObject
            | [<CompiledName("json_schema")>] JsonSchema

        [<Import("@cloudflare/workers-types", "AiIMultimodalEmbeddingsOutput")>]
        type AiIMultimodalEmbeddingsOutput =
            abstract shape: AiSentenceSimilarityOutput with get, set
            abstract data: Array<AiSentenceSimilarityOutput> with get, set

        [<Import("@cloudflare/workers-types", "InferenceUpstreamError"); AbstractClass; AllowNullLiteral>]
        type InferenceUpstreamError private () =
            inherit exn()

        [<Import("@cloudflare/workers-types", "ResponseOutputItemAddedEvent")>]
        type ResponseOutputItemAddedEvent =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseOutputItemAddedEvent.Type with get, set

            [<EmitProperty("sequence_number")>]
            abstract sequenceNumber: float with get, set

            [<EmitProperty("output_index")>]
            abstract outputIndex: float with get, set

            abstract item: ResponseOutputItem with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfDeepgramFluxInput =
            | [<CompiledName("true")>] True
            | [<CompiledName("false")>] False
            | [<CompiledName("linear16")>] Linear16

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseOutputMessage =
            | [<CompiledName("message")>] Message
            | [<CompiledName("in_progress")>] InProgress
            | [<CompiledName("completed")>] Completed
            | [<CompiledName("incomplete")>] Incomplete
            | [<CompiledName("assistant")>] Assistant

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
                keyUsages: Array<D1SessionBookmark> ->
                    Promise<CryptoKey>

            abstract wrapKey:
                format: D1SessionBookmark *
                key: CryptoKey *
                wrappingKey: CryptoKey *
                wrapAlgorithm: U2<SubtleCryptoEncryptAlgorithm, string> ->
                    Promise<ArrayBuffer>

            abstract exportKey:
                format: D1SessionBookmark * key: CryptoKey -> Promise<U2<ArrayBuffer, Typescript.JsonWebKey>>

            abstract importKey:
                format: D1SessionBookmark *
                keyData: U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, Typescript.JsonWebKey> *
                algorithm: U2<SubtleCryptoImportKeyAlgorithm, string> *
                extractable: bool *
                keyUsages: Array<D1SessionBookmark> ->
                    Promise<CryptoKey>

            abstract deriveBits:
                algorithm: U2<SubtleCryptoDeriveKeyAlgorithm, string> * baseKey: CryptoKey * ?length: float ->
                    Promise<ArrayBuffer>

            abstract deriveKey:
                algorithm: U2<SubtleCryptoDeriveKeyAlgorithm, string> *
                baseKey: CryptoKey *
                derivedKeyAlgorithm: U2<SubtleCryptoImportKeyAlgorithm, string> *
                extractable: bool *
                keyUsages: Array<D1SessionBookmark> ->
                    Promise<CryptoKey>

            abstract generateKey:
                algorithm: U2<SubtleCryptoGenerateKeyAlgorithm, string> *
                extractable: bool *
                keyUsages: Array<D1SessionBookmark> ->
                    Promise<U2<CryptoKey, Typescript.CryptoKeyPair>>

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

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfQwenQwen330BA3BFp8JSONMode1 =
            | [<CompiledName("json_object")>] JsonObject
            | [<CompiledName("json_schema")>] JsonSchema

        [<Import("@cloudflare/workers-types", "AiSummarizationOutput")>]
        type AiSummarizationOutput =
            abstract summary: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type D1Database =
            | [<CompiledName("first-primary")>] FirstPrimary
            | [<CompiledName("first-unconstrained")>] FirstUnconstrained

        [<Import("@cloudflare/workers-types", "ChatCompletionsPromptInput")>]
        type ChatCompletionsPromptInput =
            abstract functions: option<Array<FunctionDefinition>> with get, set

            [<EmitProperty("function_call")>]
            abstract functionCall:
                option<U2<ChatCompletionsPromptInput.FunctionCall, ChatCompletionsPromptInput.FunctionCall>> with get, set

            [<EmitProperty("web_search_options")>]
            abstract webSearchOptions: option<WebSearchOptions> with get, set

            abstract user: option<D1SessionBookmark> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract tools: option<Array<ChatCompletionTool>> with get, set

            [<EmitProperty("tool_choice")>]
            abstract toolChoice: option<ChatCompletionToolChoiceOption> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("stream_options")>]
            abstract streamOptions: option<ChatCompletionsStreamOptions> with get, set

            abstract stream: option<bool> with get, set
            abstract store: option<bool> with get, set
            abstract stop: option<U2<Array<D1SessionBookmark>, string>> with get, set

            [<EmitProperty("service_tier")>]
            abstract serviceTier: option<ChatCompletionsPromptInput.ServiceTier> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<ResponseFormat> with get, set

            [<EmitProperty("chat_template_kwargs")>]
            abstract chatTemplateKwargs: option<ChatTemplateKwargs> with get, set

            [<EmitProperty("reasoning_effort")>]
            abstract reasoningEffort: option<ChatCompletionsPromptInput.ReasoningEffort> with get, set

            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            abstract prediction: option<PredictionContent> with get, set

            [<EmitProperty("parallel_tool_calls")>]
            abstract parallelToolCalls: option<bool> with get, set

            abstract n: option<float> with get, set
            abstract modalities: option<Array<ChatCompletionsPromptInput.Modalities>> with get, set
            abstract metadata: option<ChatCompletionsPromptInput.Metadata> with get, set

            [<EmitProperty("max_completion_tokens")>]
            abstract maxCompletionTokens: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            [<EmitProperty("top_logprobs")>]
            abstract topLogprobs: option<float> with get, set

            abstract logprobs: option<bool> with get, set

            [<EmitProperty("logit_bias")>]
            abstract logitBias: option<ChatCompletionsPromptInput.LogitBias> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            abstract audio: option<AudioParams> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode_2")>]
        type AiCfMetaLlama3370BInstructFp8FastJSONMode2 =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiCfMetaLlama3370BInstructFp8FastJSONMode2.Type> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_Large_En_V1_5_AsyncResponse")>]
        type AiCfBaaiBgeLargeEnV15AsyncResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "WorkflowError")>]
        type WorkflowError =
            abstract message: D1SessionBookmark with get, set
            abstract code: option<float> with get, set

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

        type StructuredClone =
            abstract Invoke: value: 'T * ?options: Typescript.StructuredSerializeOptions -> 'T
            abstract Invoke: value: 'T * ?options: Typescript.StructuredSerializeOptions -> 'T

        [<Import("@cloudflare/workers-types", "QueueSendBatchMetadata")>]
        type QueueSendBatchMetadata =
            abstract metrics: QueueSendBatchMetrics with get, set

        type HeadersInit =
            U3<
                Headers,
                Iterable<Iterable<D1SessionBookmark, option<obj>, option<obj>>, option<obj>, option<obj>>,
                HeadersInit
             >

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type StreamWatermarkCreateParams =
            | [<CompiledName("upperRight")>] UpperRight
            | [<CompiledName("upperLeft")>] UpperLeft
            | [<CompiledName("lowerLeft")>] LowerLeft
            | [<CompiledName("lowerRight")>] LowerRight
            | [<CompiledName("center")>] Center

        type Ai =
            abstract stream: Ai.Stream with get, set
            abstract aiGatewayLogId: option<string> with get, set
            abstract queueRequest: Ai.QueueRequest with get, set
            abstract signal: option<AbortSignal> with get, set
            abstract extraHeaders: option<obj> with get, set
            abstract prefix: option<D1SessionBookmark> with get, set
            abstract returnRawResponse: option<bool> with get, set
            abstract gateway: option<GatewayOptions> with get, set
            abstract tags: option<Array<D1SessionBookmark>> with get, set
            abstract websocket: option<bool> with get, set
            abstract queueRequest: option<bool> with get, set
            abstract returnRawResponse: Ai.ReturnRawResponse with get, set
            abstract websocket: Ai.Websocket with get, set

            abstract toMarkdown:
                files: MarkdownDocument * ?options: ConversionRequestOptions -> Promise<ConversionResponse>

            abstract toMarkdown:
                files: Array<MarkdownDocument> * ?options: ConversionRequestOptions ->
                    Promise<Array<ConversionResponse>>

            abstract toMarkdown: unit -> ToMarkdownService
            abstract models: ?params: AiModelsSearchParams -> Promise<Array<AiModelsSearchObject>>

            abstract run:
                model: Ai.Run.Model * inputs: WebAssembly.ModuleImports * ?options: AiOptions ->
                    Promise<WebAssembly.ModuleImports>

            abstract run:
                model: 'Name *
                inputs: proptypekey<proptypekey<'AiModelList, 'Name>, Ai.Run.Inputs> *
                ?options: AiOptions ->
                    Promise<proptypekey<proptypekey<'AiModelList, 'Name>, Ai.Run>>

            abstract run: model: 'Name * inputs: Ai.Run.Inputs * ?options: AiOptions -> Promise<AiTextToImageOutput>

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

        [<Import("@cloudflare/workers-types", "MediaTransformationGenerator")>]
        type MediaTransformationGenerator =
            abstract output: ?output: MediaTransformationOutputOptions -> MediaTransformationResult

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_1_Schnell_Input")>]
        type AiCfBlackForestLabsFlux1SchnellInput =
            abstract steps: option<float> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "R2UploadedPart")>]
        type R2UploadedPart =
            abstract etag: D1SessionBookmark with get, set
            abstract partNumber: float with get, set

        type AiTextToSpeechOutput = obj

        [<Import("@cloudflare/workers-types", "ArtifactsRepoListResult")>]
        type ArtifactsRepoListResult =
            abstract cursor: option<D1SessionBookmark> with get, set
            abstract total: float with get, set
            abstract repos: Array<ArtifactsRepoListResult.Repos> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchListJobsParams")>]
        type AiSearchListJobsParams =
            [<EmitProperty("per_page")>]
            abstract perPage: option<float> with get, set

            abstract page: option<float> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type D1SessionConstraint =
            | [<CompiledName("first-primary")>] FirstPrimary
            | [<CompiledName("first-unconstrained")>] FirstUnconstrained

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiSearchListInstancesParams =
            | [<CompiledName("asc")>] Asc
            | [<CompiledName("desc")>] Desc
            | [<CompiledName("created_at")>] CreatedAt

        [<Import("@cloudflare/workers-types", "Fetcher")>]
        type Fetcher<'Reserved, 'T
            when 'Reserved :> D1SessionBookmark
            and 'T :> U3<Rpc.WorkerEntrypointBranded, Rpc.DurableObjectBranded, Rpc.WorkflowEntrypointBranded>> =
            abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

            abstract fetch:
                input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                    Promise<Typescript.Response>

            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke: [<ParamArray>] args: Fetcher.Invoke.Args -> U2<Fetcher.Invoke, U2<Fetcher.Invoke, unit>>

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

        [<Import("@cloudflare/workers-types", "DurableObjectClass")>]
        type DurableObjectClass<'_T when '_T :> Rpc.DurableObjectBranded> = interface end

        [<Import("@cloudflare/workers-types", "WorkflowInstanceCreateOptions")>]
        type WorkflowInstanceCreateOptions<'PARAMS> =
            abstract retention: option<WorkflowInstanceCreateOptions.Retention> with get, set
            abstract params: option<'PARAMS> with get, set
            abstract id: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_Reranker_Base_Input")>]
        type AiCfBaaiBgeRerankerBaseInput =
            abstract contexts: Array<AiCfBaaiBgeRerankerBaseInput.Contexts> with get, set

            [<EmitProperty("top_k")>]
            abstract topK: option<float> with get, set

        [<Import("@cloudflare/workers-types", "BaseAiSummarization"); AbstractClass; AllowNullLiteral>]
        type BaseAiSummarization private () =
            abstract postProcessedOutputs: AiSummarizationOutput with get, set
            abstract inputs: AiSummarizationInput with get, set

        [<Import("@cloudflare/workers-types", "QueueRetryOptions")>]
        type QueueRetryOptions =
            abstract delaySeconds: option<float> with get, set

        [<Import("@cloudflare/workers-types", "AiMultimodalEmbeddingsInput")>]
        type AiMultimodalEmbeddingsInput =
            abstract text: Array<D1SessionBookmark> with get, set
            abstract image: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "SchedulerWaitOptions")>]
        type SchedulerWaitOptions =
            abstract signal: option<AbortSignal> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type VectorizeQueryOptions =
            | [<CompiledName("all")>] All
            | [<CompiledName("indexed")>] Indexed
            | [<CompiledName("none")>] None

        [<Import("@cloudflare/workers-types", "TextEncoder"); AbstractClass; AllowNullLiteral>]
        type TextEncoder private () =
            [<EmitConstructor>]
            abstract Create: unit -> TextEncoder

            abstract encoding: D1SessionBookmark with get

            abstract encodeInto:
                input: D1SessionBookmark * buffer: Uint8Array<ArrayBufferLike> -> Typescript.TextEncoderEncodeIntoResult

            abstract encode: ?input: D1SessionBookmark -> Uint8Array<ArrayBufferLike>

        [<Import("@cloudflare/workers-types", "ReadableStreamValuesOptions")>]
        type ReadableStreamValuesOptions =
            abstract preventCancel: option<bool> with get, set

        type AiCfBaaiBgeSmallEnV15Output = obj

        [<Import("@cloudflare/workers-types", "ResponseRefusalDoneEvent")>]
        type ResponseRefusalDoneEvent =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseRefusalDoneEvent.Type with get, set

            [<EmitProperty("sequence_number")>]
            abstract sequenceNumber: float with get, set

            abstract refusal: D1SessionBookmark with get, set

            [<EmitProperty("output_index")>]
            abstract outputIndex: float with get, set

            [<EmitProperty("item_id")>]
            abstract itemId: D1SessionBookmark with get, set

            [<EmitProperty("content_index")>]
            abstract contentIndex: float with get, set

        [<Import("@cloudflare/workers-types", "ContainerStartupOptions")>]
        type ContainerStartupOptions =
            abstract containerSnapshot: option<ContainerSnapshot> with get, set
            abstract directorySnapshots: option<Array<ContainerDirectorySnapshotRestoreParams>> with get, set
            abstract labels: option<WebAssembly.ModuleImports> with get, set
            abstract env: option<WebAssembly.ModuleImports> with get, set
            abstract enableInternet: bool with get, set
            abstract entrypoint: option<Array<D1SessionBookmark>> with get, set

        [<Import("@cloudflare/workers-types", "ResponseError")>]
        type ResponseError =
            abstract message: D1SessionBookmark with get, set
            abstract code: ResponseError.Code with get, set

        [<Import("@cloudflare/workers-types", "AiImageToTextInput")>]
        type AiImageToTextInput =
            abstract messages: option<Array<RoleScopedChatInput>> with get, set
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

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type CfProperties =
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
            | [<CompiledName("1")>] ``1``
            | AN
            | EU
            | OC

        [<Import("@cloudflare/workers-types", "QueueSendMetadata")>]
        type QueueSendMetadata =
            abstract metrics: QueueSendMetrics with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionChoice")>]
        type ChatCompletionChoice =
            abstract logprobs: option<ChatCompletionChoice.Logprobs> with get, set

            [<EmitProperty("finish_reason")>]
            abstract finishReason: ChatCompletionChoice.FinishReason with get, set

            abstract message: ChatCompletionResponseMessage with get, set
            abstract index: float with get, set

        [<Import("@cloudflare/workers-types", "CachePurgeResult")>]
        type CachePurgeResult =
            abstract errors: Array<CachePurgeError> with get, set
            abstract success: bool with get, set

        [<Import("@cloudflare/workers-types", "AiSearchOptions")>]
        type AiSearchOptions =
            abstract cache: option<AiSearchOptions.Cache> with get, set
            abstract reranking: option<AiSearchOptions.Reranking> with get, set

            [<EmitProperty("query_rewrite")>]
            abstract queryRewrite: option<AiSearchOptions.QueryRewrite> with get, set

            abstract retrieval: option<AiSearchOptions.Retrieval> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "ImageListOptions")>]
        type ImageListOptions =
            abstract creator: option<D1SessionBookmark> with get, set
            abstract sortOrder: option<ImageListOptions.SortOrder> with get, set
            abstract cursor: option<D1SessionBookmark> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "ReadableStreamDefaultReader"); AbstractClass; AllowNullLiteral>]
        type ReadableStreamDefaultReader<'R> private () =
            [<EmitConstructor>]
            abstract Create: stream: AiTextToImageOutput -> ReadableStreamDefaultReader

            abstract closed: Promise<unit> with get
            abstract releaseLock: unit -> unit
            abstract read: unit -> Promise<U2<ReadableStreamReadValueResult<'R>, ReadableStreamReadDoneResult<'R>>>
            abstract cancel: ?reason: obj -> Promise<unit>

        [<Import("@cloudflare/workers-types", "ExecutionContext")>]
        type ExecutionContext<'Props> =
            abstract tracing: option<Tracing> with get, set
            abstract cache: option<CacheContext> with get, set
            abstract props: 'Props with get
            abstract passThroughOnException: unit -> unit
            abstract waitUntil: promise: Promise<option<obj>> -> unit

        [<Import("@cloudflare/workers-types", "AiTextGenerationToolLegacyInput")>]
        type AiTextGenerationToolLegacyInput =
            abstract parameters: option<AiTextGenerationToolLegacyInput.Parameters> with get, set
            abstract description: D1SessionBookmark with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_Embedding_0_6B_Output")>]
        type AiCfQwenQwen3Embedding06BOutput =
            abstract shape: option<AiSentenceSimilarityOutput> with get, set
            abstract data: option<Array<AiSentenceSimilarityOutput>> with get, set

        [<Import("@cloudflare/workers-types", "CryptoKeyHmacKeyAlgorithm")>]
        type CryptoKeyHmacKeyAlgorithm =
            abstract length: float with get, set
            abstract hash: CryptoKeyKeyAlgorithm with get, set
            abstract name: D1SessionBookmark with get, set

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

        type AiCfMistralaiMistralSmall3124BInstructInput = obj

        [<Import("@cloudflare/workers-types", "ErrorEventErrorEventInit")>]
        type ErrorEventErrorEventInit =
            abstract error: option<obj> with get, set
            abstract colno: option<float> with get, set
            abstract lineno: option<float> with get, set
            abstract filename: option<D1SessionBookmark> with get, set
            abstract message: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Black_Forest_Labs_Flux_2_Klein_4B");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfBlackForestLabsFlux2Klein4B private () =
            abstract postProcessedOutputs: AiCfBlackForestLabsFlux2Klein4BOutput with get, set
            abstract inputs: AiCfBlackForestLabsFlux2Klein4BInput with get, set

        [<Import("@cloudflare/workers-types", "MessageEvent"); AbstractClass; AllowNullLiteral>]
        type MessageEvent private () =
            inherit Event()

            [<EmitConstructor>]
            abstract Create:
                ``type``: D1SessionBookmark * initializer: Typescript.MessageEventInit<option<obj>> -> MessageEvent

            abstract ports: Array<MessagePort> with get
            abstract source: option<MessagePort> with get
            abstract lastEventId: D1SessionBookmark with get
            abstract origin: option<string> with get
            abstract data: option<obj> with get

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Qwen_Qwq_32B"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfQwenQwq32B private () =
            abstract postProcessedOutputs: AiCfQwenQwq32BOutput with get, set
            abstract inputs: AiCfQwenQwq32BInput with get, set

        [<Import("@cloudflare/workers-types", "MessageBatch")>]
        type MessageBatch<'Body> =
            abstract metadata: MessageBatchMetadata with get
            abstract queue: D1SessionBookmark with get
            abstract messages: ReadonlyArray<Message<'Body>> with get
            abstract ackAll: unit -> unit
            abstract retryAll: ?options: QueueRetryOptions -> unit

        [<Import("@cloudflare/workers-types", "R2ListOptions")>]
        type R2ListOptions =
            abstract startAfter: option<D1SessionBookmark> with get, set
            abstract delimiter: option<D1SessionBookmark> with get, set
            abstract cursor: option<D1SessionBookmark> with get, set
            abstract prefix: option<D1SessionBookmark> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectPutOptions")>]
        type DurableObjectPutOptions =
            abstract noCache: option<bool> with get, set
            abstract allowUnconfirmed: option<bool> with get, set
            abstract allowConcurrency: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionFunctionTool")>]
        type ChatCompletionFunctionTool =
            [<EmitProperty("function")>]
            abstract ``function``: FunctionDefinition with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ChatCompletionFunctionTool.Type with get, set

        [<Import("@cloudflare/workers-types", "ArtifactsTokenListResult")>]
        type ArtifactsTokenListResult =
            abstract total: float with get, set
            abstract tokens: Array<ArtifactsTokenInfo> with get, set

        [<Import("@cloudflare/workers-types", "D1ExecResult")>]
        type D1ExecResult =
            abstract duration: float with get, set
            abstract count: float with get, set

        [<Import("@cloudflare/workers-types", "MarkdownDocument")>]
        type MarkdownDocument =
            abstract blob: Blob with get, set
            abstract name: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ToolMessage = | [<CompiledName("tool")>] Tool

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type QueueSendOptions =
            | [<CompiledName("text")>] Text
            | [<CompiledName("json")>] Json
            | [<CompiledName("bytes")>] Bytes
            | [<CompiledName("v8")>] V8

        type MainModule = option<MainModule>

        [<Import("@cloudflare/workers-types", "ScheduledController")>]
        type ScheduledController =
            abstract cron: D1SessionBookmark with get
            abstract scheduledTime: float with get
            abstract noRetry: unit -> unit

        [<Import("@cloudflare/workers-types", "Message")>]
        type Message<'Body> =
            abstract attempts: float with get
            abstract body: 'Body with get
            abstract timestamp: Date with get
            abstract id: D1SessionBookmark with get
            abstract ack: unit -> unit
            abstract retry: ?options: QueueRetryOptions -> unit

        [<Import("@cloudflare/workers-types", "SocketAddress")>]
        type SocketAddress =
            abstract port: float with get, set
            abstract hostname: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type BadRequestError = | BadRequestError

        type AutoRAG =
            abstract response: D1SessionBookmark with get, set

            [<EmitProperty("next_page")>]
            abstract nextPage: option<string> with get, set

            [<EmitProperty("has_more")>]
            abstract hasMore: bool with get, set

            abstract data: Array<AutoRAG.Data> with get, set

            [<EmitProperty("search_query")>]
            abstract searchQuery: D1SessionBookmark with get, set

            abstract object: AutoRAG.Object with get, set

            [<EmitProperty("system_prompt")>]
            abstract systemPrompt: option<D1SessionBookmark> with get, set

            abstract stream: option<bool> with get, set

            [<EmitProperty("rewrite_query")>]
            abstract rewriteQuery: option<bool> with get, set

            abstract reranking: option<AutoRAG.Reranking> with get, set

            [<EmitProperty("ranking_options")>]
            abstract rankingOptions: option<AutoRAG.RankingOptions> with get, set

            [<EmitProperty("max_num_results")>]
            abstract maxNumResults: option<float> with get, set

            abstract filters: option<U2<AutoRAG.Filters, AutoRAG.Filters>> with get, set
            abstract query: D1SessionBookmark with get, set
            abstract stream: AutoRAG.Stream with get, set

            [<EmitProperty("system_prompt")>]
            abstract systemPrompt: option<string> with get, set

            [<EmitProperty("rewrite_query")>]
            abstract rewriteQuery: option<AutoRAG.RewriteQuery> with get, set

            abstract reranking: option<AutoRAG.Reranking> with get, set

            [<EmitProperty("ranking_options")>]
            abstract rankingOptions: option<AutoRAG.RankingOptions> with get, set

            [<EmitProperty("max_num_results")>]
            abstract maxNumResults: option<float> with get, set

            abstract filters: option<U2<AutoRAG.Filters, AutoRAG.Filters>> with get, set
            abstract aiSearch: params: AutoRagAiSearchRequest -> Promise<U2<Typescript.Response, AutoRAG.AiSearch>>
            abstract aiSearch: params: AutoRagAiSearchRequest -> Promise<AutoRagAiSearchResponse>
            abstract aiSearch: params: AutoRagAiSearchRequestStreaming -> Promise<Typescript.Response>
            abstract search: params: AutoRagSearchRequest -> Promise<AutoRagSearchResponse>
            abstract list: unit -> Promise<AutoRagListResponse>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiGateway =
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

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesCloudflareAccessOrApiShield")>]
        type IncomingRequestCfPropertiesCloudflareAccessOrApiShield =
            abstract tlsClientAuth:
                U2<IncomingRequestCfPropertiesTLSClientAuth, IncomingRequestCfPropertiesTLSClientAuthPlaceholder> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Dev_Input")>]
        type AiCfBlackForestLabsFlux2DevInput =
            abstract multipart: AiCfBlackForestLabsFlux2DevInput.Multipart with get, set

        [<Import("@cloudflare/workers-types", "StreamVideosListParams")>]
        type StreamVideosListParams =
            abstract afterComp: option<StreamPaginationComparison> with get, set
            abstract after: option<D1SessionBookmark> with get, set
            abstract beforeComp: option<StreamPaginationComparison> with get, set
            abstract before: option<D1SessionBookmark> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "VectorizeVector")>]
        type VectorizeVector =
            abstract metadata: option<WebAssembly.ModuleImports> with get, set

            [<EmitProperty("namespace")>]
            abstract ``namespace``: option<D1SessionBookmark> with get, set

            abstract values: U3<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>, Array<float>> with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "LoopbackColoLocalActorNamespace"); AbstractClass; AllowNullLiteral>]
        type LoopbackColoLocalActorNamespace private () =
            inherit ColoLocalActorNamespace()

        [<Import("@cloudflare/workers-types", "R2MultipartOptions")>]
        type R2MultipartOptions =
            abstract ssecKey: option<U2<ArrayBuffer, string>> with get, set
            abstract storageClass: option<D1SessionBookmark> with get, set
            abstract customMetadata: option<WebAssembly.ModuleImports> with get, set
            abstract httpMetadata: option<U2<R2HTTPMetadata, Headers>> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type NotFoundError = | NotFoundError

        [<Import("@cloudflare/workers-types", "TraceItemScheduledEventInfo")>]
        type TraceItemScheduledEventInfo =
            abstract cron: D1SessionBookmark with get
            abstract scheduledTime: float with get

        [<Import("@cloudflare/workers-types", "ChatCompletionToolChoiceCustom")>]
        type ChatCompletionToolChoiceCustom =
            abstract custom: ChatCompletionToolChoiceCustom.Custom with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ChatCompletionToolChoiceCustom.Type with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Async_Batch")>]
        type AiCfAisingaporeGemmaSeaLionV427BItAsyncBatch =
            abstract requests:
                Array<U2<AiCfAisingaporeGemmaSeaLionV427BItPrompt1, AiCfAisingaporeGemmaSeaLionV427BItMessages1>> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_M2M100_1_2B_AsyncResponse")>]
        type AiCfMetaM2M10012BAsyncResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ExportedHandlerTailHandler")>]
        type ExportedHandlerTailHandler<'Props, 'Env> =
            abstract Invoke:
                events: Array<TraceItem> * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "ToMarkdownService"); AbstractClass; AllowNullLiteral>]
        type ToMarkdownService private () =
            abstract supported: unit -> Promise<Array<SupportedFileFormat>>

            abstract transform:
                files: MarkdownDocument * ?options: ConversionRequestOptions -> Promise<ConversionResponse>

            abstract transform:
                files: Array<MarkdownDocument> * ?options: ConversionRequestOptions ->
                    Promise<Array<ConversionResponse>>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ReasoningEffort =
            | [<CompiledName("minimal")>] Minimal
            | [<CompiledName("low")>] Low
            | [<CompiledName("medium")>] Medium
            | [<CompiledName("high")>] High

        [<Import("@cloudflare/workers-types", "ChatCompletionTokenLogprob")>]
        type ChatCompletionTokenLogprob =
            [<EmitProperty("top_logprobs")>]
            abstract topLogprobs: Array<ChatCompletionTopLogprob> with get, set

            abstract bytes: option<Array<float>> with get, set
            abstract logprob: float with get, set
            abstract token: D1SessionBookmark with get, set

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

        [<Import("@cloudflare/workers-types", "CryptoKeyRsaKeyAlgorithm")>]
        type CryptoKeyRsaKeyAlgorithm =
            abstract hash: option<CryptoKeyKeyAlgorithm> with get, set
            abstract publicExponent: BufferSource with get, set
            abstract modulusLength: float with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_AsyncResponse")>]
        type AiCfMetaLlama3370BInstructFp8FastAsyncResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Meta_M2M100_1_2B"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfMetaM2M10012B private () =
            abstract postProcessedOutputs: AiCfMetaM2M10012BOutput with get, set
            abstract inputs: AiCfMetaM2M10012BInput with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type QueueContentType =
            | [<CompiledName("text")>] Text
            | [<CompiledName("bytes")>] Bytes
            | [<CompiledName("json")>] Json
            | [<CompiledName("v8")>] V8

        [<Import("@cloudflare/workers-types", "TextDecoderStreamTextDecoderStreamInit")>]
        type TextDecoderStreamTextDecoderStreamInit =
            abstract ignoreBOM: option<bool> with get, set
            abstract fatal: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "PagesFunction")>]
        type PagesFunction<'Data, 'Params, 'Env when 'Data :> WebAssembly.ModuleImports and 'Params :> D1SessionBookmark>
            =
            abstract Invoke:
                context: PagesFunction.Invoke.Context -> U2<Typescript.Response, Promise<Typescript.Response>>

        [<Import("@cloudflare/workers-types", "ImageHandle")>]
        type ImageHandle =
            abstract delete: unit -> Promise<bool>
            abstract update: options: ImageUpdateOptions -> Promise<ImageMetadata>
            abstract bytes: unit -> Promise<option<ReadableStream<Uint8Array<ArrayBufferLike>>>>
            abstract details: unit -> Promise<option<ImageMetadata>>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseReasoningSummaryItem = | [<CompiledName("summary_text")>] SummaryText

        type ResponseFormatTextConfig = obj

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfAisingaporeGemmaSeaLionV427BItJSONMode3 =
            | [<CompiledName("json_object")>] JsonObject
            | [<CompiledName("json_schema")>] JsonSchema

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionsOutput =
            | [<CompiledName("auto")>] Auto
            | [<CompiledName("default")>] Default
            | [<CompiledName("flex")>] Flex
            | [<CompiledName("scale")>] Scale
            | [<CompiledName("priority")>] Priority

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

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Google_Gemma_4_26B_A4B_IT"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfGoogleGemma426BA4BIT private () =
            abstract postProcessedOutputs: ChatCompletionsOutput with get, set
            abstract inputs: ChatCompletionsInput with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Deepgram_Flux"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfDeepgramFlux private () =
            abstract postProcessedOutputs: AiCfDeepgramFluxOutput with get, set
            abstract inputs: AiCfDeepgramFluxInput with get, set

        type AiCfBaaiBgeLargeEnV15Output = obj
        type AiCfPipecatAiSmartTurnV2Input = obj

        [<Import("@cloudflare/workers-types", "Span"); AbstractClass; AllowNullLiteral>]
        type Span private () =
            abstract isTraced: bool with get
            abstract setAttribute: key: D1SessionBookmark * ?value: U3<bool, float, string> -> unit

        [<Import("@cloudflare/workers-types", "R2MultipartUpload")>]
        type R2MultipartUpload =
            abstract uploadId: D1SessionBookmark with get
            abstract key: D1SessionBookmark with get
            abstract complete: uploadedParts: Array<R2UploadedPart> -> Promise<R2Object>
            abstract abort: unit -> Promise<unit>

            abstract uploadPart:
                partNumber: float *
                value: U5<ReadableStream<option<obj>>, ArrayBuffer, ArrayBufferView<ArrayBufferLike>, Blob, string> *
                ?options: R2UploadPartOptions ->
                    Promise<R2UploadedPart>

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

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Async_Batch")>]
        type AiCfMetaLlama4Scout17B16EInstructAsyncBatch =
            abstract requests:
                Array<U2<AiCfMetaLlama4Scout17B16EInstructPromptInner, AiCfMetaLlama4Scout17B16EInstructMessagesInner>> with get, set

        [<Import("@cloudflare/workers-types", "StreamError"); AbstractClass; AllowNullLiteral>]
        type StreamError private () =
            inherit exn()
            abstract stack: option<D1SessionBookmark> with get
            abstract message: D1SessionBookmark with get
            abstract statusCode: float with get
            abstract code: float with get

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Input_Embedding")>]
        type AiCfBaaiBgeM3InputEmbedding =
            [<EmitProperty("truncate_inputs")>]
            abstract truncateInputs: option<bool> with get, set

            abstract text: U2<Array<D1SessionBookmark>, string> with get, set

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

        [<Import("@cloudflare/workers-types", "R2Conditional")>]
        type R2Conditional =
            abstract secondsGranularity: option<bool> with get, set
            abstract uploadedAfter: option<Date> with get, set
            abstract uploadedBefore: option<Date> with get, set
            abstract etagDoesNotMatch: option<D1SessionBookmark> with get, set
            abstract etagMatches: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "D1DatabaseSession"); AbstractClass; AllowNullLiteral>]
        type D1DatabaseSession private () =
            abstract results: Array<'T> with get, set
            abstract error: option<unit> with get, set
            abstract meta: D1DatabaseSession.Meta with get, set
            abstract success: D1DatabaseSession.Success with get, set

            [<EmitProperty("total_attempts")>]
            abstract totalAttempts: option<float> with get, set

            abstract timings: option<D1DatabaseSession.Timings> with get, set

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
            abstract getBookmark: unit -> option<string>
            abstract batch: statements: Array<D1PreparedStatement> -> Promise<Array<D1DatabaseSession.Batch>>
            abstract prepare: query: D1SessionBookmark -> D1PreparedStatement
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "ServiceWorkerGlobalScope"); AbstractClass; AllowNullLiteral>]
        type ServiceWorkerGlobalScope private () =
            inherit WorkerGlobalScope()

            [<EmitProperty("HTMLRewriter")>]
            abstract hTMLRewriter: ServiceWorkerGlobalScope.HTMLRewriter with get, set

            [<EmitProperty("IdentityTransformStream")>]
            abstract identityTransformStream: ServiceWorkerGlobalScope.IdentityTransformStream with get, set

            [<EmitProperty("FixedLengthStream")>]
            abstract fixedLengthStream: ServiceWorkerGlobalScope.FixedLengthStream with get, set

            [<EmitProperty("Cache")>]
            abstract cache: ServiceWorkerGlobalScope.Cache with get, set

            [<EmitProperty("CacheStorage")>]
            abstract cacheStorage: ServiceWorkerGlobalScope.CacheStorage with get, set

            [<EmitProperty("CryptoKey")>]
            abstract cryptoKey: ServiceWorkerGlobalScope.CryptoKey with get, set

            [<EmitProperty("SubtleCrypto")>]
            abstract subtleCrypto: ServiceWorkerGlobalScope.SubtleCrypto with get, set

            [<EmitProperty("Crypto")>]
            abstract crypto: ServiceWorkerGlobalScope.Crypto with get, set

            [<EmitProperty("FormData")>]
            abstract formData: ServiceWorkerGlobalScope.FormData with get, set

            [<EmitProperty("File")>]
            abstract file: ServiceWorkerGlobalScope.File with get, set

            [<EmitProperty("Blob")>]
            abstract blob: ServiceWorkerGlobalScope.Blob with get, set

            [<EmitProperty("URLPattern")>]
            abstract uRLPattern: ServiceWorkerGlobalScope.URLPattern with get, set

            [<EmitProperty("URLSearchParams")>]
            abstract uRLSearchParams: ServiceWorkerGlobalScope.URLSearchParams with get, set

            abstract URL: ServiceWorkerGlobalScope.URL with get, set

            [<EmitProperty("TextEncoder")>]
            abstract textEncoder: ServiceWorkerGlobalScope.TextEncoder with get, set

            [<EmitProperty("TextDecoder")>]
            abstract textDecoder: ServiceWorkerGlobalScope.TextDecoder with get, set

            [<EmitProperty("AbortSignal")>]
            abstract abortSignal: ServiceWorkerGlobalScope.AbortSignal with get, set

            [<EmitProperty("AbortController")>]
            abstract abortController: ServiceWorkerGlobalScope.AbortController with get, set

            [<EmitProperty("WebSocketRequestResponsePair")>]
            abstract webSocketRequestResponsePair: ServiceWorkerGlobalScope.WebSocketRequestResponsePair with get, set

            [<EmitProperty("WebSocketPair")>]
            abstract webSocketPair: ServiceWorkerGlobalScope.WebSocketPair with get, set

            [<EmitProperty("WebSocket")>]
            abstract webSocket: ServiceWorkerGlobalScope.WebSocket with get, set

            [<EmitProperty("Response")>]
            abstract response: ServiceWorkerGlobalScope.Response with get, set

            [<EmitProperty("Request")>]
            abstract request: ServiceWorkerGlobalScope.Request with get, set

            [<EmitProperty("Body")>]
            abstract body: ServiceWorkerGlobalScope.Body with get, set

            [<EmitProperty("Headers")>]
            abstract headers: ServiceWorkerGlobalScope.Headers with get, set

            [<EmitProperty("TextDecoderStream")>]
            abstract textDecoderStream: ServiceWorkerGlobalScope.TextDecoderStream with get, set

            [<EmitProperty("TextEncoderStream")>]
            abstract textEncoderStream: ServiceWorkerGlobalScope.TextEncoderStream with get, set

            [<EmitProperty("DecompressionStream")>]
            abstract decompressionStream: ServiceWorkerGlobalScope.DecompressionStream with get, set

            [<EmitProperty("CompressionStream")>]
            abstract compressionStream: ServiceWorkerGlobalScope.CompressionStream with get, set

            [<EmitProperty("EventSource")>]
            abstract eventSource: ServiceWorkerGlobalScope.EventSource with get, set

            [<EmitProperty("ErrorEvent")>]
            abstract errorEvent: ServiceWorkerGlobalScope.ErrorEvent with get, set

            [<EmitProperty("CountQueuingStrategy")>]
            abstract countQueuingStrategy: ServiceWorkerGlobalScope.CountQueuingStrategy with get, set

            [<EmitProperty("ByteLengthQueuingStrategy")>]
            abstract byteLengthQueuingStrategy: ServiceWorkerGlobalScope.ByteLengthQueuingStrategy with get, set

            [<EmitProperty("TransformStream")>]
            abstract transformStream: ServiceWorkerGlobalScope.TransformStream with get, set

            [<EmitProperty("WritableStreamDefaultWriter")>]
            abstract writableStreamDefaultWriter: ServiceWorkerGlobalScope.WritableStreamDefaultWriter with get, set

            [<EmitProperty("WritableStream")>]
            abstract writableStream: ServiceWorkerGlobalScope.WritableStream with get, set

            [<EmitProperty("ReadableStream")>]
            abstract readableStream: ServiceWorkerGlobalScope.ReadableStream with get, set

            [<EmitProperty("ReadableStreamBYOBReader")>]
            abstract readableStreamBYOBReader: ServiceWorkerGlobalScope.ReadableStreamBYOBReader with get, set

            [<EmitProperty("ReadableStreamDefaultReader")>]
            abstract readableStreamDefaultReader: ServiceWorkerGlobalScope.ReadableStreamDefaultReader with get, set

            [<EmitProperty("CloseEvent")>]
            abstract closeEvent: ServiceWorkerGlobalScope.CloseEvent with get, set

            [<EmitProperty("MessageEvent")>]
            abstract messageEvent: ServiceWorkerGlobalScope.MessageEvent with get, set

            [<EmitProperty("ScheduledEvent")>]
            abstract scheduledEvent: ServiceWorkerGlobalScope.ScheduledEvent with get, set

            [<EmitProperty("TraceEvent")>]
            abstract traceEvent: ServiceWorkerGlobalScope.TraceEvent with get, set

            [<EmitProperty("TailEvent")>]
            abstract tailEvent: ServiceWorkerGlobalScope.TailEvent with get, set

            [<EmitProperty("FetchEvent")>]
            abstract fetchEvent: ServiceWorkerGlobalScope.FetchEvent with get, set

            [<EmitProperty("PromiseRejectionEvent")>]
            abstract promiseRejectionEvent: ServiceWorkerGlobalScope.PromiseRejectionEvent with get, set

            [<EmitProperty("CustomEvent")>]
            abstract customEvent: ServiceWorkerGlobalScope.CustomEvent with get, set

            [<EmitProperty("ExtendableEvent")>]
            abstract extendableEvent: ServiceWorkerGlobalScope.ExtendableEvent with get, set

            [<EmitProperty("Event")>]
            abstract event: ServiceWorkerGlobalScope.Event with get, set

            abstract origin: D1SessionBookmark with get

            [<EmitProperty("Cloudflare")>]
            abstract cloudflare: Cloudflare with get, set

            abstract performance: Performance with get, set
            abstract scheduler: Scheduler with get, set
            abstract caches: CacheStorage with get, set
            abstract crypto: Crypto with get, set
            abstract self: ServiceWorkerGlobalScope with get, set

            [<EmitProperty("WorkerGlobalScope")>]
            abstract workerGlobalScope: ServiceWorkerGlobalScope.WorkerGlobalScope with get, set

            [<EmitProperty("DOMException")>]
            abstract dOMException: ServiceWorkerGlobalScope.DOMException with get, set

            abstract fetch:
                input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
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

        [<Import("@cloudflare/workers-types", "TraceItemHibernatableWebSocketEventInfo")>]
        type TraceItemHibernatableWebSocketEventInfo =
            abstract getWebSocketEvent:
                U3<
                    TraceItemHibernatableWebSocketEventInfoMessage,
                    TraceItemHibernatableWebSocketEventInfoClose,
                    TraceItemHibernatableWebSocketEventInfoError
                 > with get

        [<Import("@cloudflare/workers-types", "TextDecoderConstructorOptions")>]
        type TextDecoderConstructorOptions =
            abstract ignoreBOM: bool with get, set
            abstract fatal: bool with get, set

        [<Import("@cloudflare/workers-types", "StreamDirectUploadWatermark")>]
        type StreamDirectUploadWatermark =
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "CryptoKeyEllipticKeyAlgorithm")>]
        type CryptoKeyEllipticKeyAlgorithm =
            abstract namedCurve: D1SessionBookmark with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "FlagshipEvaluationError"); AbstractClass; AllowNullLiteral>]
        type FlagshipEvaluationError private () =
            inherit exn()

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Deepgram_Aura_2_En"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfDeepgramAura2En private () =
            abstract postProcessedOutputs: D1SessionBookmark with get, set
            abstract inputs: AiCfDeepgramAura2EnInput with get, set

        type AiModelListType = obj

        [<Import("@cloudflare/workers-types", "ReadableStreamBYOBReaderReadableStreamBYOBReaderReadOptions")>]
        type ReadableStreamBYOBReaderReadableStreamBYOBReaderReadOptions =
            abstract min: option<float> with get, set

        [<Import("@cloudflare/workers-types", "TlsOptions")>]
        type TlsOptions =
            abstract expectedServerHostname: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ResponseOutputText")>]
        type ResponseOutputText =
            abstract logprobs: option<Array<Logprob>> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ResponseOutputText.Type with get, set

            abstract text: D1SessionBookmark with get, set

        type KVNamespaceListResult<'Key, 'Metadata when 'Key :> D1SessionBookmark> =
            U2<KVNamespaceListResult, KVNamespaceListResult>

        [<Import("@cloudflare/workers-types", "ArtifactsRepo")>]
        type ArtifactsRepo =
            inherit ArtifactsRepoInfo

            abstract fork:
                name: D1SessionBookmark * ?opts: ArtifactsRepo.Fork.Opts -> Promise<ArtifactsCreateRepoResult>

            abstract revokeToken: tokenOrId: D1SessionBookmark -> Promise<bool>
            abstract listTokens: unit -> Promise<ArtifactsTokenListResult>

            abstract createToken:
                ?scope: ArtifactsRepo.CreateToken.Scope * ?ttl: float -> Promise<ArtifactsCreateTokenResult>

        [<Import("@cloudflare/workers-types", "URLPatternComponentResult")>]
        type URLPatternComponentResult =
            abstract groups: WebAssembly.ModuleImports with get, set
            abstract input: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "StreamVideoInput")>]
        type StreamVideoInput =
            abstract height: float with get, set
            abstract width: float with get, set

        [<Import("@cloudflare/workers-types", "ImagesError"); AbstractClass; AllowNullLiteral>]
        type ImagesError private () =
            inherit exn()
            abstract stack: option<D1SessionBookmark> with get
            abstract message: D1SessionBookmark with get
            abstract code: float with get

        type AiCfBaaiBgeM3Input = obj

        [<Import("@cloudflare/workers-types", "CryptoKeyKeyAlgorithm")>]
        type CryptoKeyKeyAlgorithm =
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Blob"); AbstractClass; AllowNullLiteral>]
        type Blob private () =
            [<EmitConstructor>]
            abstract Create:
                ?``type``: Array<U4<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, Blob, string>> *
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

        type Atob =
            abstract Invoke: data: D1SessionBookmark -> D1SessionBookmark
            abstract Invoke: data: D1SessionBookmark -> D1SessionBookmark

        type ChatCompletionsInput =
            abstract functions: option<unit> with get, set

            [<EmitProperty("function_call")>]
            abstract functionCall: option<unit> with get, set

            [<EmitProperty("web_search_options")>]
            abstract webSearchOptions: option<unit> with get, set

            abstract user: option<unit> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<unit> with get, set

            abstract tools: option<unit> with get, set

            [<EmitProperty("tool_choice")>]
            abstract toolChoice: option<unit> with get, set

            abstract temperature: option<unit> with get, set

            [<EmitProperty("stream_options")>]
            abstract streamOptions: option<unit> with get, set

            abstract store: option<unit> with get, set

            [<EmitProperty("service_tier")>]
            abstract serviceTier: option<unit> with get, set

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

            [<EmitProperty("parallel_tool_calls")>]
            abstract parallelToolCalls: option<unit> with get, set

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
            abstract stream: option<unit> with get, set
            abstract prompt: option<unit> with get, set
            abstract stop: option<unit> with get, set
            abstract metadata: option<unit> with get, set
            abstract audio: option<unit> with get, set
            abstract requests: Array<ChatCompletionsBase> with get, set
            abstract requests: option<unit> with get, set
            abstract functions: option<Array<FunctionDefinition>> with get, set

            [<EmitProperty("function_call")>]
            abstract functionCall: option<U2<ChatCompletionsInput.FunctionCall, ChatCompletionsInput.FunctionCall>> with get, set

            [<EmitProperty("web_search_options")>]
            abstract webSearchOptions: option<WebSearchOptions> with get, set

            abstract user: option<D1SessionBookmark> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract tools: option<Array<ChatCompletionTool>> with get, set

            [<EmitProperty("tool_choice")>]
            abstract toolChoice: option<ChatCompletionToolChoiceOption> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("stream_options")>]
            abstract streamOptions: option<ChatCompletionsStreamOptions> with get, set

            abstract stream: option<bool> with get, set
            abstract store: option<bool> with get, set
            abstract stop: option<U2<Array<D1SessionBookmark>, string>> with get, set

            [<EmitProperty("service_tier")>]
            abstract serviceTier: option<ChatCompletionsInput.ServiceTier> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<ResponseFormat> with get, set

            [<EmitProperty("chat_template_kwargs")>]
            abstract chatTemplateKwargs: option<ChatTemplateKwargs> with get, set

            [<EmitProperty("reasoning_effort")>]
            abstract reasoningEffort: option<ChatCompletionsInput.ReasoningEffort> with get, set

            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            abstract prediction: option<PredictionContent> with get, set

            [<EmitProperty("parallel_tool_calls")>]
            abstract parallelToolCalls: option<bool> with get, set

            abstract n: option<float> with get, set
            abstract modalities: option<Array<ChatCompletionsInput.Modalities>> with get, set
            abstract metadata: option<ChatCompletionsInput.Metadata> with get, set

            [<EmitProperty("max_completion_tokens")>]
            abstract maxCompletionTokens: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            [<EmitProperty("top_logprobs")>]
            abstract topLogprobs: option<float> with get, set

            abstract logprobs: option<bool> with get, set

            [<EmitProperty("logit_bias")>]
            abstract logitBias: option<ChatCompletionsInput.LogitBias> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            abstract audio: option<AudioParams> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract messages: Array<ChatCompletionMessageParam> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_Reranker_Base_Output")>]
        type AiCfBaaiBgeRerankerBaseOutput =
            abstract response: option<Array<AiCfBaaiBgeRerankerBaseOutput.Response>> with get, set

        [<Import("@cloudflare/workers-types", "AiModelsSearchObject")>]
        type AiModelsSearchObject =
            abstract properties: Array<AiModelsSearchObject.Properties> with get, set
            abstract tags: Array<D1SessionBookmark> with get, set
            abstract task: AiModelsSearchObject.Task with get, set
            abstract description: D1SessionBookmark with get, set
            abstract name: D1SessionBookmark with get, set
            abstract source: float with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "DispatchNamespace")>]
        type DispatchNamespace =
            abstract get:
                name: D1SessionBookmark * ?args: WebAssembly.ModuleImports * ?options: DynamicDispatchOptions ->
                    DispatchNamespace.Get

        [<Import("@cloudflare/workers-types", "FixedLengthStream"); AbstractClass; AllowNullLiteral>]
        type FixedLengthStream private () =
            inherit IdentityTransformStream()

            [<EmitConstructor>]
            abstract Create:
                expectedLength: float * ?queuingStrategy: IdentityTransformStreamQueuingStrategy -> FixedLengthStream

        [<Import("@cloudflare/workers-types", "StreamDownloadGetResponse")>]
        type StreamDownloadGetResponse =
            [<EmitProperty("default")>]
            abstract ``default``: option<StreamDownload> with get, set

            abstract audio: option<StreamDownload> with get, set

        [<Import("@cloudflare/workers-types", "TraceItemCustomEventInfo")>]
        type TraceItemCustomEventInfo = interface end

        [<Import("@cloudflare/workers-types", "ResponseCompletedEvent")>]
        type ResponseCompletedEvent =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseCompletedEvent.Type with get, set

            [<EmitProperty("sequence_number")>]
            abstract sequenceNumber: float with get, set

            abstract response: Typescript.Response with get, set

        [<Import("@cloudflare/workers-types", "SyncKvStorage")>]
        type SyncKvStorage =
            abstract delete: key: D1SessionBookmark -> bool
            abstract put: key: D1SessionBookmark * value: 'T -> unit
            abstract list: ?options: SyncKvListOptions -> Iterable<D1SessionBookmark * 'T, option<obj>, option<obj>>
            abstract get: key: D1SessionBookmark -> option<'T>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Deepgram_Flux_Output")>]
        type AiCfDeepgramFluxOutput =
            [<EmitProperty("end_of_turn_confidence")>]
            abstract endOfTurnConfidence: option<float> with get, set

            abstract words: option<Array<AiCfDeepgramFluxOutput.Words>> with get, set
            abstract transcript: option<D1SessionBookmark> with get, set

            [<EmitProperty("audio_window_end")>]
            abstract audioWindowEnd: option<float> with get, set

            [<EmitProperty("audio_window_start")>]
            abstract audioWindowStart: option<float> with get, set

            [<EmitProperty("turn_index")>]
            abstract turnIndex: option<float> with get, set

            abstract event: option<AiCfDeepgramFluxOutput.Event> with get, set

            [<EmitProperty("sequence_id")>]
            abstract sequenceId: option<float> with get, set

            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Zai_Org_Glm_4_7_Flash"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfZaiOrgGlm47Flash private () =
            abstract postProcessedOutputs: ChatCompletionsOutput with get, set
            abstract inputs: ChatCompletionsInput with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseTextDeltaEvent = | [<CompiledName("response.output_text.delta")>] ResponseOutputTextDelta

        [<Import("@cloudflare/workers-types", "AiTextEmbeddingsOutput")>]
        type AiTextEmbeddingsOutput =
            abstract data: Array<AiSentenceSimilarityOutput> with get, set
            abstract shape: AiSentenceSimilarityOutput with get, set

        [<Import("@cloudflare/workers-types", "ImageTransformationResult")>]
        type ImageTransformationResult =
            abstract image: ?options: ImageTransformationOutputOptions -> ReadableStream<Uint8Array<ArrayBufferLike>>
            abstract contentType: unit -> D1SessionBookmark
            abstract response: unit -> Typescript.Response

        [<Import("@cloudflare/workers-types", "TransformStream"); AbstractClass; AllowNullLiteral>]
        type TransformStream<'O, 'I> private () =
            [<EmitConstructor>]
            abstract Create:
                ?transformer: Typescript.Transformer<'I, 'O> *
                ?writableStrategy: Typescript.QueuingStrategy<'I> *
                ?readableStrategy: Typescript.QueuingStrategy<'O> ->
                    TransformStream

            abstract writable: WritableStream<'I> with get
            abstract readable: ReadableStream<'O> with get

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Leonardo_Phoenix_1_0"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfLeonardoPhoenix10 private () =
            abstract postProcessedOutputs: D1SessionBookmark with get, set
            abstract inputs: AiCfLeonardoPhoenix10Input with get, set

        [<Import("@cloudflare/workers-types", "WorkerGlobalScope"); AbstractClass; AllowNullLiteral>]
        type WorkerGlobalScope private () =
            inherit Typescript.Body()

            [<EmitProperty("EventTarget")>]
            abstract eventTarget: WorkerGlobalScope.EventTarget with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type __RPC_STUB_BRAND = | __RPC_STUB_BRAND

        [<Import("@cloudflare/workers-types", "AiSearchJobLogsResponse")>]
        type AiSearchJobLogsResponse =
            [<EmitProperty("result_info")>]
            abstract resultInfo: option<AiSearchJobLogsResponse.ResultInfo> with get, set

            abstract result: Array<AiSearchJobLog> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchMultiChatCompletionsResponse")>]
        type AiSearchMultiChatCompletionsResponse =
            abstract errors: option<Array<AiSearchMultiSearchError>> with get, set
            abstract chunks: Array<AiSearchMultiSearchChunk> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Openai_Whisper"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfOpenaiWhisper private () =
            abstract postProcessedOutputs: AiCfOpenaiWhisperOutput with get, set
            abstract inputs: AiCfOpenaiWhisperInput with get, set

        [<Import("@cloudflare/workers-types", "UnsafeTraceMetrics")>]
        type UnsafeTraceMetrics =
            abstract fromTrace: item: TraceItem -> TraceMetrics

        type AiCfMetaM2M10012BOutput = obj

        [<Import("@cloudflare/workers-types", "AiSearchListJobsResponse")>]
        type AiSearchListJobsResponse =
            [<EmitProperty("result_info")>]
            abstract resultInfo: option<AiSearchListJobsResponse.ResultInfo> with get, set

            abstract result: Array<AiSearchJobInfo> with get, set

        [<Import("@cloudflare/workers-types", "QueueSendBatchOptions")>]
        type QueueSendBatchOptions =
            abstract delaySeconds: option<float> with get, set

        type FlagshipEvaluationContext = obj

        type RpcStub =
            [<EmitProperty("[__RPC_STUB_BRAND]")>]
            abstract __RPC_STUB_BRAND: 'T with get, set

            abstract symbolDispose: unit -> unit
            abstract dup: unit -> 'StubBase
            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke: [<ParamArray>] args: RpcStub.Invoke.Args -> U2<RpcStub.Invoke, U2<RpcStub.Invoke, unit>>
            abstract Create: value: 'T -> CloudflareWorkersModule.RpcStub

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRagAiSearchResponse")>]
        type AutoRagAiSearchResponse =
            abstract response: D1SessionBookmark with get, set

            [<EmitProperty("next_page")>]
            abstract nextPage: option<string> with get, set

            [<EmitProperty("has_more")>]
            abstract hasMore: bool with get, set

            abstract data: Array<AutoRagAiSearchResponse.Data> with get, set

            [<EmitProperty("search_query")>]
            abstract searchQuery: D1SessionBookmark with get, set

            abstract object: AutoRagAiSearchResponse.Object with get, set

        [<Import("@cloudflare/workers-types", "RateLimitOptions")>]
        type RateLimitOptions =
            abstract key: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Openai_Whisper_Tiny_En_Output")>]
        type AiCfOpenaiWhisperTinyEnOutput =
            abstract vtt: option<D1SessionBookmark> with get, set
            abstract words: option<Array<AiCfOpenaiWhisperTinyEnOutput.Words>> with get, set

            [<EmitProperty("word_count")>]
            abstract wordCount: option<float> with get, set

            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "TextDecoderDecodeOptions")>]
        type TextDecoderDecodeOptions =
            abstract stream: bool with get, set

        [<Import("@cloudflare/workers-types", "TraceLog")>]
        type TraceLog =
            abstract message: option<obj> with get
            abstract level: D1SessionBookmark with get
            abstract timestamp: float with get

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Klein_9B_Input")>]
        type AiCfBlackForestLabsFlux2Klein9BInput =
            abstract multipart: AiCfBlackForestLabsFlux2Klein9BInput.Multipart with get, set

        [<Import("@cloudflare/workers-types", "BaseAiImageTextToText"); AbstractClass; AllowNullLiteral>]
        type BaseAiImageTextToText private () =
            abstract postProcessedOutputs: AiImageTextToTextOutput with get, set
            abstract inputs: AiImageTextToTextInput with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type RemoveEventListener =
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
            | [<CompiledName("fetch")>] Fetch
            | [<CompiledName("queue")>] Queue
            | [<CompiledName("scheduled")>] Scheduled

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Openai_Whisper_Tiny_En"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfOpenaiWhisperTinyEn private () =
            abstract postProcessedOutputs: AiCfOpenaiWhisperTinyEnOutput with get, set
            abstract inputs: AiCfOpenaiWhisperTinyEnInput with get, set

        [<Import("@cloudflare/workers-types", "MediaTransformer")>]
        type MediaTransformer =
            abstract output: ?output: MediaTransformationOutputOptions -> MediaTransformationResult
            abstract transform: ?transform: MediaTransformationInputOptions -> MediaTransformationGenerator

        type EventContext =
            abstract ASSETS: EventContext.ASSETS with get, set

        [<Import("@cloudflare/workers-types", "ExportedHandlerConnectHandler")>]
        type ExportedHandlerConnectHandler<'Props, 'Env> =
            abstract Invoke: socket: Socket * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

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

        [<Import("@cloudflare/workers-types", "Logprob")>]
        type Logprob =
            [<EmitProperty("top_logprobs")>]
            abstract topLogprobs: option<Array<TopLogprob>> with get, set

            abstract logprob: float with get, set
            abstract token: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type __WORKFLOW_ENTRYPOINT_BRAND = | __WORKFLOW_ENTRYPOINT_BRAND

        [<Import("@cloudflare/workers-types", "BaseAiObjectDetection"); AbstractClass; AllowNullLiteral>]
        type BaseAiObjectDetection private () =
            abstract postProcessedOutputs: AiObjectDetectionOutput with get, set
            abstract inputs: AiObjectDetectionInput with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type IncomingRequestCfPropertiesGeographicInformation =
            | AF
            | AN
            | AS
            | EU
            | NA
            | OC
            | SA
            | [<CompiledName("1")>] ``1``
            | ES
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

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Baai_Bge_Small_En_V1_5"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfBaaiBgeSmallEnV15 private () =
            abstract postProcessedOutputs: AiCfBaaiBgeSmallEnV15Output with get, set
            abstract inputs: AiCfBaaiBgeSmallEnV15Input with get, set

        [<Import("@cloudflare/workers-types", "SubtleCryptoGenerateKeyAlgorithm")>]
        type SubtleCryptoGenerateKeyAlgorithm =
            abstract namedCurve: option<D1SessionBookmark> with get, set
            abstract length: option<float> with get, set
            abstract publicExponent: option<BufferSource> with get, set
            abstract modulusLength: option<float> with get, set
            abstract hash: option<U2<SubtleCryptoHashAlgorithm, string>> with get, set
            abstract name: D1SessionBookmark with get, set

        type ClearInterval =
            abstract Invoke: ?timeoutId: float -> unit
            abstract Invoke: ?id: float -> unit

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ToolChoiceOptions = | [<CompiledName("none")>] ToolChoiceOptions

        [<Import("@cloudflare/workers-types", "RoleScopedChatInput")>]
        type RoleScopedChatInput =
            abstract name: option<D1SessionBookmark> with get, set
            abstract content: D1SessionBookmark with get, set
            abstract role: U2<RoleScopedChatInput.Role, RoleScopedChatInput.Role> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type __RPC_TARGET_BRAND = | __RPC_TARGET_BRAND

        type AiSearchMultiSearchRequest = obj

        [<Import("@cloudflare/workers-types", "AiSummarizationInput")>]
        type AiSummarizationInput =
            [<EmitProperty("max_length")>]
            abstract maxLength: option<float> with get, set

            [<EmitProperty("input_text")>]
            abstract inputText: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ResponseFunctionToolCallOutputItem")>]
        type ResponseFunctionToolCallOutputItem =
            abstract status: option<ResponseFunctionToolCallOutputItem.Status> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ResponseFunctionToolCallOutputItem.Type with get, set

            abstract output: U2<Array<ResponseInputContent>, string> with get, set

            [<EmitProperty("call_id")>]
            abstract callId: D1SessionBookmark with get, set

            abstract id: D1SessionBookmark with get, set

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

            abstract tools:
                option<Array<U2<AiCfQwenQwen330BA3BFp8Messages.Tools, AiCfQwenQwen330BA3BFp8Messages.Tools>>> with get, set

            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: Array<AiCfQwenQwen330BA3BFp8Messages.Messages> with get, set

        [<Import("@cloudflare/workers-types", "InvalidURLError")>]
        type InvalidURLError =
            inherit StreamError
            abstract name: InvalidURLError.Name with get, set

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

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type WorkflowDurationLabel =
            | [<CompiledName("second")>] Second
            | [<CompiledName("minute")>] Minute
            | [<CompiledName("hour")>] Hour
            | [<CompiledName("day")>] Day
            | [<CompiledName("week")>] Week
            | [<CompiledName("month")>] Month
            | [<CompiledName("year")>] Year

        type AiCfOpenaiWhisperInput = obj

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type TooManyWatermarksError = | TooManyWatermarksError

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Baai_Bge_M3"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfBaaiBgeM3 private () =
            abstract postProcessedOutputs: AiCfBaaiBgeM3Output with get, set
            abstract inputs: AiCfBaaiBgeM3Input with get, set

        [<Import("@cloudflare/workers-types", "ImageTransformer")>]
        type ImageTransformer =
            abstract output: options: ImageOutputOptions -> Promise<ImageTransformationResult>

            abstract draw:
                image: U2<ReadableStream<Uint8Array<ArrayBufferLike>>, ImageTransformer> * ?options: ImageDrawOptions ->
                    ImageTransformer

            abstract transform: transform: ImageTransform -> ImageTransformer

        [<Import("@cloudflare/workers-types", "MessagePort"); AbstractClass; AllowNullLiteral>]
        type MessagePort private () =
            inherit EventTarget()
            abstract onmessage: option<obj> with set
            abstract onmessage: option<obj> with get
            abstract start: unit -> unit
            abstract close: unit -> unit
            abstract postMessage: ?data: obj * ?options: U2<Array<option<obj>>, MessagePortPostMessageOptions> -> unit

        [<Import("@cloudflare/workers-types", "StreamDownload")>]
        type StreamDownload =
            abstract url: option<D1SessionBookmark> with get, set
            abstract status: StreamDownloadStatus with get, set
            abstract percentComplete: float with get, set

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

        [<Import("@cloudflare/workers-types", "ImageUpdateOptions")>]
        type ImageUpdateOptions =
            abstract creator: option<D1SessionBookmark> with get, set
            abstract metadata: option<WebAssembly.ModuleImports> with get, set
            abstract requireSignedURLs: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "VectorizeIndexInfo")>]
        type VectorizeIndexInfo =
            abstract processedUpToMutation: float with get, set
            abstract processedUpToDatetime: float with get, set
            abstract dimensions: float with get, set
            abstract vectorCount: float with get, set

        [<Import("@cloudflare/workers-types", "RequestInitCfProperties")>]
        type RequestInitCfProperties =
            inherit WebAssembly.ModuleImports
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
            abstract cacheTtlByStatus: option<WebAssembly.ModuleImports> with get, set
            abstract cacheTtl: option<float> with get, set
            abstract cacheTags: option<Array<D1SessionBookmark>> with get, set
            abstract cacheKey: option<D1SessionBookmark> with get, set
            abstract cacheEverything: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItemChunk")>]
        type AiSearchItemChunk =
            abstract item: option<AiSearchItemChunk.Item> with get, set

            [<EmitProperty("end_byte")>]
            abstract endByte: float with get, set

            [<EmitProperty("start_byte")>]
            abstract startByte: float with get, set

            abstract text: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Text_Completion_Response")>]
        type AiCfAisingaporeGemmaSeaLionV427BItTextCompletionResponse =
            abstract usage: option<AiCfAisingaporeGemmaSeaLionV427BItTextCompletionResponse.Usage> with get, set
            abstract choices: option<Array<AiCfAisingaporeGemmaSeaLionV427BItTextCompletionResponse.Choices>> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract created: option<float> with get, set
            abstract object: option<AiCfAisingaporeGemmaSeaLionV427BItTextCompletionResponse.Object> with get, set
            abstract id: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_JSON_Mode")>]
        type AiCfQwenQwen25Coder32BInstructJSONMode =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiCfQwenQwen25Coder32BInstructJSONMode.Type> with get, set

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

        [<Import("@cloudflare/workers-types", "LoopbackServiceStub")>]
        type LoopbackServiceStub<'T when 'T :> Rpc.WorkerEntrypointBranded> =
            abstract Invoke: opts: LoopbackServiceStub.Invoke.Opts -> LoopbackServiceStub.Invoke
            abstract Invoke: opts: LoopbackServiceStub.Invoke.Opts -> LoopbackServiceStub.Invoke
            abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

            abstract fetch:
                input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                    Promise<Typescript.Response>

            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke:
                [<ParamArray>] args: LoopbackServiceStub.Invoke.Args ->
                    U2<LoopbackServiceStub.Invoke, U2<LoopbackServiceStub.Invoke, unit>>

        [<Import("@cloudflare/workers-types", "SubtleCryptoImportKeyAlgorithm")>]
        type SubtleCryptoImportKeyAlgorithm =
            abstract compressed: option<bool> with get, set
            abstract namedCurve: option<D1SessionBookmark> with get, set
            abstract length: option<float> with get, set
            abstract hash: option<U2<SubtleCryptoHashAlgorithm, string>> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "BaseAiMultimodalEmbeddings"); AbstractClass; AllowNullLiteral>]
        type BaseAiMultimodalEmbeddings private () =
            abstract postProcessedOutputs: AiImageTextToTextOutput with get, set
            abstract inputs: AiImageTextToTextInput with get, set

        type _EmailMessage =
            abstract prototype: EmailMessage with get, set

            abstract Create:
                from: D1SessionBookmark * ``to``: D1SessionBookmark * raw: U2<ReadableStream<option<obj>>, string> ->
                    EmailMessage

        type ChatCompletionsBase =
            abstract prompt: option<unit> with get, set
            abstract functions: option<Array<FunctionDefinition>> with get, set

            [<EmitProperty("function_call")>]
            abstract functionCall: option<U2<ChatCompletionsBase.FunctionCall, ChatCompletionsBase.FunctionCall>> with get, set

            [<EmitProperty("web_search_options")>]
            abstract webSearchOptions: option<WebSearchOptions> with get, set

            abstract user: option<D1SessionBookmark> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract tools: option<Array<ChatCompletionTool>> with get, set

            [<EmitProperty("tool_choice")>]
            abstract toolChoice: option<ChatCompletionToolChoiceOption> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("stream_options")>]
            abstract streamOptions: option<ChatCompletionsStreamOptions> with get, set

            abstract stream: option<bool> with get, set
            abstract store: option<bool> with get, set
            abstract stop: option<U2<Array<D1SessionBookmark>, string>> with get, set

            [<EmitProperty("service_tier")>]
            abstract serviceTier: option<ChatCompletionsBase.ServiceTier> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<ResponseFormat> with get, set

            [<EmitProperty("chat_template_kwargs")>]
            abstract chatTemplateKwargs: option<ChatTemplateKwargs> with get, set

            [<EmitProperty("reasoning_effort")>]
            abstract reasoningEffort: option<ChatCompletionsBase.ReasoningEffort> with get, set

            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            abstract prediction: option<PredictionContent> with get, set

            [<EmitProperty("parallel_tool_calls")>]
            abstract parallelToolCalls: option<bool> with get, set

            abstract n: option<float> with get, set
            abstract modalities: option<Array<ChatCompletionsBase.Modalities>> with get, set
            abstract metadata: option<ChatCompletionsBase.Metadata> with get, set

            [<EmitProperty("max_completion_tokens")>]
            abstract maxCompletionTokens: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            [<EmitProperty("top_logprobs")>]
            abstract topLogprobs: option<float> with get, set

            abstract logprobs: option<bool> with get, set

            [<EmitProperty("logit_bias")>]
            abstract logitBias: option<ChatCompletionsBase.LogitBias> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            abstract audio: option<AudioParams> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract messages: Array<ChatCompletionMessageParam> with get, set
            abstract messages: option<unit> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "TraceItemConnectEventInfo")>]
        type TraceItemConnectEventInfo = interface end

        type AiCfBaaiBgeBaseEnV15Input = obj

        [<Import("@cloudflare/workers-types", "KVNamespaceListOptions")>]
        type KVNamespaceListOptions =
            abstract cursor: option<string> with get, set
            abstract prefix: option<string> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "StreamBinding")>]
        type StreamBinding =
            abstract watermarks: StreamWatermarks with get, set
            abstract videos: StreamVideos with get, set
            abstract createDirectUpload: params: StreamDirectUploadCreateParams -> Promise<StreamDirectUpload>
            abstract upload: url: D1SessionBookmark * ?params: StreamUrlUploadParams -> Promise<StreamVideo>
            abstract video: id: D1SessionBookmark -> StreamVideoHandle

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

        [<Import("@cloudflare/workers-types", "AiSearchSearchResponse")>]
        type AiSearchSearchResponse =
            abstract chunks: Array<AiSearchSearchResponse.Chunks> with get, set

            [<EmitProperty("search_query")>]
            abstract searchQuery: D1SessionBookmark with get, set

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRAGInternalError"); AbstractClass; AllowNullLiteral>]
        type AutoRAGInternalError private () =
            inherit exn()

        [<Import("@cloudflare/workers-types", "MessageBatchMetadata")>]
        type MessageBatchMetadata =
            abstract metrics: MessageBatchMetrics with get, set

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

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type __DURABLE_OBJECT_BRAND = | __DURABLE_OBJECT_BRAND

        [<Import("@cloudflare/workers-types", "MediaTransformationOutputOptions")>]
        type MediaTransformationOutputOptions =
            abstract format: option<MediaTransformationOutputOptions.Format> with get, set
            abstract imageCount: option<float> with get, set
            abstract duration: option<D1SessionBookmark> with get, set
            abstract time: option<D1SessionBookmark> with get, set
            abstract audio: option<bool> with get, set
            abstract mode: option<MediaTransformationOutputOptions.Mode> with get, set

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRagSearchRequest")>]
        type AutoRagSearchRequest =
            [<EmitProperty("rewrite_query")>]
            abstract rewriteQuery: option<bool> with get, set

            abstract reranking: option<AutoRagSearchRequest.Reranking> with get, set

            [<EmitProperty("ranking_options")>]
            abstract rankingOptions: option<AutoRagSearchRequest.RankingOptions> with get, set

            [<EmitProperty("max_num_results")>]
            abstract maxNumResults: option<float> with get, set

            abstract filters: option<U2<AutoRagSearchRequest.Filters, AutoRagSearchRequest.Filters>> with get, set
            abstract query: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "EmailAddress")>]
        type EmailAddress =
            abstract email: D1SessionBookmark with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Black_Forest_Labs_Flux_2_Klein_9B");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfBlackForestLabsFlux2Klein9B private () =
            abstract postProcessedOutputs: AiCfBlackForestLabsFlux2Klein9BOutput with get, set
            abstract inputs: AiCfBlackForestLabsFlux2Klein9BInput with get, set

        [<Import("@cloudflare/workers-types", "AiSearchMessage")>]
        type AiSearchMessage =
            abstract content: option<string> with get, set
            abstract role: AiSearchMessage.Role with get, set

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesBotManagementEnterprise")>]
        type IncomingRequestCfPropertiesBotManagementEnterprise =
            inherit IncomingRequestCfPropertiesBotManagement
            abstract botManagement: IncomingRequestCfPropertiesBotManagementEnterprise.BotManagement with get, set

        [<Import("@cloudflare/workers-types", "AlarmInvocationInfo")>]
        type AlarmInvocationInfo =
            abstract scheduledTime: float with get
            abstract retryCount: float with get
            abstract isRetry: bool with get

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

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Output")>]
        type AiCfMetaLlama3211BVisionInstructOutput =
            [<EmitProperty("tool_calls")>]
            abstract toolCalls: option<Array<AiCfMetaLlama3211BVisionInstructOutput.ToolCalls>> with get, set

            abstract response: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "AiSentenceSimilarityInput")>]
        type AiSentenceSimilarityInput =
            abstract sentences: Array<D1SessionBookmark> with get, set
            abstract source: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseReasoningContentItem = | [<CompiledName("reasoning_text")>] ReasoningText

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Black_Forest_Labs_Flux_1_Schnell");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfBlackForestLabsFlux1Schnell private () =
            abstract postProcessedOutputs: AiCfBlackForestLabsFlux1SchnellOutput with get, set
            abstract inputs: AiCfBlackForestLabsFlux1SchnellInput with get, set

        [<Import("@cloudflare/workers-types", "VectorizeVectorMutation")>]
        type VectorizeVectorMutation =
            abstract count: float with get, set
            abstract ids: Array<D1SessionBookmark> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type DecompressionStream =
            | [<CompiledName("gzip")>] Gzip
            | [<CompiledName("deflate")>] Deflate
            | [<CompiledName("deflate-raw")>] DeflateRaw

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfMetaLlama3370BInstructFp8Fast private () =
            abstract postProcessedOutputs: AiCfMetaLlama3370BInstructFp8FastOutput with get, set
            abstract inputs: AiCfMetaLlama3370BInstructFp8FastInput with get, set

        [<Import("@cloudflare/workers-types", "TraceItemQueueEventInfo")>]
        type TraceItemQueueEventInfo =
            abstract batchSize: float with get
            abstract queue: D1SessionBookmark with get

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
            abstract inputs: Array<U2<URLPatternInit, string>> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Klein_4B_Input")>]
        type AiCfBlackForestLabsFlux2Klein4BInput =
            abstract multipart: AiCfBlackForestLabsFlux2Klein4BInput.Multipart with get, set

        [<Import("@cloudflare/workers-types", "DigestStream"); AbstractClass; AllowNullLiteral>]
        type DigestStream private () =
            inherit WritableStream<BufferSource>()

            [<EmitConstructor>]
            abstract Create: algorithm: U2<SubtleCryptoHashAlgorithm, string> -> DigestStream

            abstract bytesWritten: float with get
            abstract digest: Promise<ArrayBuffer> with get

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        type AutoRagListResponse = obj

        [<Import("@cloudflare/workers-types", "ChatCompletionToolChoiceFunction")>]
        type ChatCompletionToolChoiceFunction =
            [<EmitProperty("function")>]
            abstract ``function``: ChatCompletionToolChoiceFunction.Function with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ChatCompletionToolChoiceFunction.Type with get, set

        [<Import("@cloudflare/workers-types", "AiSearchInternalError"); AbstractClass; AllowNullLiteral>]
        type AiSearchInternalError private () =
            inherit exn()

        type ChatCompletionTool = obj

        [<Import("@cloudflare/workers-types", "AiTextGenerationOutput")>]
        type AiTextGenerationOutput =
            abstract usage: option<UsageTags> with get, set

            [<EmitProperty("tool_calls")>]
            abstract toolCalls: option<AiTextGenerationOutput.ToolCalls> with get, set

            abstract response: option<D1SessionBookmark> with get, set

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
            abstract image: option<U2<Array<float>, AiCfMetaLlama3211BVisionInstructPrompt.Image>> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type IncomingRequestCfPropertiesTLSClientAuth =
            | [<CompiledName("1")>] ``1``
            | [<CompiledName("0")>] ``0``
            | SUCCESS
            | [<CompiledName("FAILED:self signed certificate")>] ``FAILED:selfsignedcertificate``
            | [<CompiledName("FAILED:unable to verify the first certificate")>] ``FAILED:unabletoverifythefirstcertificate``
            | [<CompiledName("FAILED:certificate is not yet valid")>] ``FAILED:certificateisnotyetvalid``
            | [<CompiledName("FAILED:certificate has expired")>] ``FAILED:certificatehasexpired``
            | FAILED

        type Params<'P when 'P :> D1SessionBookmark> = Params

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

        [<Import("@cloudflare/workers-types", "AiTextClassificationInput")>]
        type AiTextClassificationInput =
            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Baai_Bge_Base_En_V1_5"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfBaaiBgeBaseEnV15 private () =
            abstract postProcessedOutputs: AiCfBaaiBgeBaseEnV15Output with get, set
            abstract inputs: AiCfBaaiBgeBaseEnV15Input with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type GatewayRetries =
            | [<CompiledName("constant")>] Constant
            | [<CompiledName("linear")>] Linear
            | [<CompiledName("exponential")>] Exponential

        type VectorizeMatches =
            abstract score: float with get, set
            abstract metadata: option<VectorizeMatches.Metadata> with get, set

            [<EmitProperty("namespace")>]
            abstract ``namespace``: option<string> with get, set

            abstract id: D1SessionBookmark with get, set
            abstract values: option<U3<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>, Array<float>>> with get, set
            abstract count: float with get, set
            abstract matches: Array<VectorizeMatch> with get, set

        [<Import("@cloudflare/workers-types", "MediaBinding")>]
        type MediaBinding =
            abstract input: media: ReadableStream<Uint8Array<ArrayBufferLike>> -> MediaTransformer

        [<Import("@cloudflare/workers-types", "CloseEvent"); AbstractClass; AllowNullLiteral>]
        type CloseEvent private () =
            inherit Event()

            [<EmitConstructor>]
            abstract Create: ``type``: D1SessionBookmark * ?initializer: Typescript.CloseEventInit -> CloseEvent

            abstract wasClean: bool with get
            abstract reason: D1SessionBookmark with get
            abstract code: float with get

        type SetTimeout =
            abstract Invoke:
                callback: SetTimeout.Invoke.Callback * ?msDelay: float * [<ParamArray>] args: 'Args -> float

            abstract Invoke: callback: SetTimeout.Invoke.Callback * ?msDelay: float -> float

            abstract Invoke:
                handler: TimerHandler * ?timeout: float * [<ParamArray>] arguments: Array<option<obj>> -> float

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseInputItemMessage =
            | [<CompiledName("message")>] Message
            | [<CompiledName("in_progress")>] InProgress
            | [<CompiledName("completed")>] Completed
            | [<CompiledName("incomplete")>] Incomplete
            | [<CompiledName("user")>] User
            | [<CompiledName("system")>] System
            | [<CompiledName("developer")>] Developer

        type ConversionResponse = obj

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRAGNotFoundError"); AbstractClass; AllowNullLiteral>]
        type AutoRAGNotFoundError private () =
            inherit exn()

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

        type AiSearchMultiChatCompletionsRequest =
            [<EmitProperty("instance_ids")>]
            abstract instanceIds: Array<D1SessionBookmark> with get, set

            abstract cache: option<AiSearchMultiChatCompletionsRequest.Cache> with get, set
            abstract reranking: option<AiSearchMultiChatCompletionsRequest.Reranking> with get, set

            [<EmitProperty("query_rewrite")>]
            abstract queryRewrite: option<AiSearchMultiChatCompletionsRequest.QueryRewrite> with get, set

            abstract retrieval: option<AiSearchMultiChatCompletionsRequest.Retrieval> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseRefusalDeltaEvent = | [<CompiledName("response.refusal.delta")>] ResponseRefusalDelta

        [<Import("@cloudflare/workers-types", "QueueEvent"); AbstractClass; AllowNullLiteral>]
        type QueueEvent<'Body> private () =
            inherit ExtendableEvent()
            abstract metadata: MessageBatchMetadata with get
            abstract queue: D1SessionBookmark with get
            abstract messages: ReadonlyArray<Message<'Body>> with get
            abstract ackAll: unit -> unit
            abstract retryAll: ?options: QueueRetryOptions -> unit

        [<Import("@cloudflare/workers-types", "SendEmail")>]
        type SendEmail =
            abstract send: builder: SendEmail.Send.Builder -> Promise<EmailSendResult>
            abstract send: message: EmailMessage -> Promise<EmailSendResult>

        type ResponseInput = obj

        type DispatchEvent =
            abstract Invoke:
                event: U4<PromiseRejectionEvent, QueueEvent<option<obj>>, ScheduledEvent, FetchEvent> -> bool

            abstract Invoke: event: Event -> bool

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseIncompleteEvent = | [<CompiledName("response.incomplete")>] ResponseIncomplete

        type AiCfMetaLlama3211BVisionInstructInput = obj

        [<Import("@cloudflare/workers-types", "ChatCompletionCustomToolTextFormat")>]
        type ChatCompletionCustomToolTextFormat =
            [<EmitProperty("type")>]
            abstract ``type``: ChatCompletionCustomToolTextFormat.Type with get, set

        [<Import("@cloudflare/workers-types", "HostedImagesBinding")>]
        type HostedImagesBinding =
            abstract list: ?options: ImageListOptions -> Promise<ImageList>

            abstract upload:
                image: U2<ReadableStream<Uint8Array<ArrayBufferLike>>, ArrayBuffer> * ?options: ImageUploadOptions ->
                    Promise<ImageMetadata>

            abstract image: imageId: D1SessionBookmark -> ImageHandle

        [<Import("@cloudflare/workers-types", "BaseAiTextEmbeddings"); AbstractClass; AllowNullLiteral>]
        type BaseAiTextEmbeddings private () =
            abstract postProcessedOutputs: AiTextEmbeddingsOutput with get, set
            abstract inputs: AiTextEmbeddingsInput with get, set

        [<Import("@cloudflare/workers-types", "TracePreviewInfo")>]
        type TracePreviewInfo =
            abstract name: D1SessionBookmark with get, set
            abstract slug: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ContainerSnapshot")>]
        type ContainerSnapshot =
            abstract name: option<D1SessionBookmark> with get, set
            abstract size: float with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiImageClassificationInput")>]
        type AiImageClassificationInput =
            abstract image: AiSentenceSimilarityOutput with get, set

        [<Import("@cloudflare/workers-types", "TopLogprob")>]
        type TopLogprob =
            abstract logprob: option<float> with get, set
            abstract token: option<D1SessionBookmark> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfBaaiBgeM3OutputEmbeddingForContexts =
            | [<CompiledName("mean")>] Mean
            | [<CompiledName("cls")>] Cls

        [<Import("@cloudflare/workers-types", "AiSearchItemContentResult")>]
        type AiSearchItemContentResult =
            abstract size: float with get, set
            abstract filename: D1SessionBookmark with get, set
            abstract contentType: D1SessionBookmark with get, set
            abstract body: AiTextToImageOutput with get, set

        [<Import("@cloudflare/workers-types", "EventSourceEventSourceInit")>]
        type EventSourceEventSourceInit =
            abstract fetcher: option<EventSourceEventSourceInit.Fetcher> with get, set
            abstract withCredentials: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchChatCompletionsResponse")>]
        type AiSearchChatCompletionsResponse =
            abstract chunks: Array<AiSearchChatCompletionsResponse.Chunks> with get, set
            abstract choices: Array<AiSearchChatCompletionsResponse.Choices> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract object: option<D1SessionBookmark> with get, set
            abstract id: option<D1SessionBookmark> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

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

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type StreamDownloadType =
            | [<CompiledName("default")>] Default
            | [<CompiledName("audio")>] Audio

        [<Import("@cloudflare/workers-types", "PromiseRejectionEvent"); AbstractClass; AllowNullLiteral>]
        type PromiseRejectionEvent private () =
            inherit Event()
            abstract reason: option<obj> with get
            abstract promise: Promise<option<obj>> with get

        [<Import("@cloudflare/workers-types", "AnalyticsEngineDataPoint")>]
        type AnalyticsEngineDataPoint =
            abstract blobs: option<Array<option<U2<ArrayBuffer, string>>>> with get, set
            abstract doubles: option<AiSentenceSimilarityOutput> with get, set
            abstract indexes: option<Array<option<U2<ArrayBuffer, string>>>> with get, set

        [<Import("@cloudflare/workers-types", "R2UploadPartOptions")>]
        type R2UploadPartOptions =
            abstract ssecKey: option<U2<ArrayBuffer, string>> with get, set

        type ChatCompletionCustomToolFormat = obj

        [<Import("@cloudflare/workers-types", "AiSearchStatsResponse")>]
        type AiSearchStatsResponse =
            abstract engine: option<AiSearchStatsResponse.Engine> with get, set

            [<EmitProperty("last_activity")>]
            abstract lastActivity: option<D1SessionBookmark> with get, set

            abstract outdated: option<float> with get, set
            abstract skipped: option<float> with get, set
            abstract error: option<float> with get, set
            abstract completed: option<float> with get, set
            abstract running: option<float> with get, set
            abstract queued: option<float> with get, set

        [<Import("@cloudflare/workers-types", "BaseAiTranslation"); AbstractClass; AllowNullLiteral>]
        type BaseAiTranslation private () =
            abstract postProcessedOutputs: AiTranslationOutput with get, set
            abstract inputs: AiTranslationInput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Text_Completion_Response")>]
        type AiCfQwenQwen330BA3BFp8TextCompletionResponse =
            abstract usage: option<AiCfQwenQwen330BA3BFp8TextCompletionResponse.Usage> with get, set
            abstract choices: option<Array<AiCfQwenQwen330BA3BFp8TextCompletionResponse.Choices>> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract created: option<float> with get, set
            abstract object: option<AiCfQwenQwen330BA3BFp8TextCompletionResponse.Object> with get, set
            abstract id: option<D1SessionBookmark> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type MaxFileSizeError = | MaxFileSizeError

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type CompoundFilter =
            | [<CompiledName("and")>] And
            | [<CompiledName("or")>] Or

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type DurableObjectNamespaceNewUniqueIdOptions =
            | [<CompiledName("eu")>] Eu
            | [<CompiledName("fedramp")>] Fedramp
            | [<CompiledName("fedramp-high")>] FedrampHigh

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseTextConfig =
            | [<CompiledName("low")>] Low
            | [<CompiledName("medium")>] Medium
            | [<CompiledName("high")>] High

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Baai_Bge_Reranker_Base"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfBaaiBgeRerankerBase private () =
            abstract postProcessedOutputs: AiCfBaaiBgeRerankerBaseOutput with get, set
            abstract inputs: AiCfBaaiBgeRerankerBaseInput with get, set

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

        [<Import("@cloudflare/workers-types", "Cache"); AbstractClass; AllowNullLiteral>]
        type Cache private () =
            abstract put: request: U3<Typescript.Request, URL, string> * response: Typescript.Response -> Promise<unit>

            abstract ``match``:
                request: U3<Typescript.Request, URL, string> * ?options: Typescript.CacheQueryOptions ->
                    Promise<option<Typescript.Response>>

            abstract delete:
                request: U3<Typescript.Request, URL, string> * ?options: Typescript.CacheQueryOptions -> Promise<bool>

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesBotManagement")>]
        type IncomingRequestCfPropertiesBotManagement =
            /// <deprecated />
            abstract clientTrustScore: float with get, set
            abstract botManagement: IncomingRequestCfPropertiesBotManagementBase with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Unum_Uform_Gen2_Qwen_500M_Output")>]
        type AiCfUnumUformGen2Qwen500MOutput =
            abstract description: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "D1PreparedStatement"); AbstractClass; AllowNullLiteral>]
        type D1PreparedStatement private () =
            abstract results: Array<'T> with get, set
            abstract error: option<unit> with get, set
            abstract meta: D1PreparedStatement.Meta with get, set
            abstract success: D1PreparedStatement.Success with get, set

            [<EmitProperty("total_attempts")>]
            abstract totalAttempts: option<float> with get, set

            abstract timings: option<D1PreparedStatement.Timings> with get, set

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
            abstract raw: ?options: D1PreparedStatement.Raw.Options -> Promise<Array<'T>>
            abstract raw: options: D1PreparedStatement.Raw.Options -> Promise<Array<D1SessionBookmark> * Array<'T>>
            abstract all: unit -> Promise<D1PreparedStatement.All>
            abstract run: unit -> Promise<D1PreparedStatement.Run>
            abstract first: unit -> Promise<option<'T>>
            abstract first: colName: D1SessionBookmark -> Promise<option<'T>>
            abstract bind: [<ParamArray>] values: Array<option<obj>> -> D1PreparedStatement
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "DurableObjectFacets")>]
        type DurableObjectFacets =
            abstract delete: name: D1SessionBookmark -> unit
            abstract abort: name: D1SessionBookmark * ?reason: obj -> unit

            abstract get:
                name: D1SessionBookmark *
                getStartupOptions: unit -> U2<FacetStartupOptions<'T>, Promise<FacetStartupOptions<'T>>> ->
                    DurableObjectFacets.Get

            abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

            abstract fetch:
                input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                    Promise<Typescript.Response>

            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke:
                [<ParamArray>] args: DurableObjectFacets.Invoke.Args ->
                    U2<DurableObjectFacets.Invoke, U2<DurableObjectFacets.Invoke, unit>>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfAisingaporeGemmaSeaLionV427BItChatCompletionResponse =
            | [<CompiledName("chat.completion")>] ChatCompletion

        [<Import("@cloudflare/workers-types", "Headers"); AbstractClass; AllowNullLiteral>]
        type Headers private () =
            [<EmitConstructor>]
            abstract Create: ?init: HeadersInit -> Headers

            abstract symbolIterator:
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
            abstract get: name: D1SessionBookmark -> option<string>

        [<Import("@cloudflare/workers-types", "AiSearchJobs"); AbstractClass; AllowNullLiteral>]
        type AiSearchJobs private () =
            abstract get: jobId: D1SessionBookmark -> AiSearchJob
            abstract create: ?params: AiSearchCreateJobParams -> Promise<AiSearchJobInfo>
            abstract list: ?params: AiSearchListJobsParams -> Promise<AiSearchListJobsResponse>

        type D1Response =
            [<EmitProperty("total_attempts")>]
            abstract totalAttempts: option<float> with get, set

            abstract timings: option<D1Response.Timings> with get, set

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
            abstract error: option<unit> with get, set
            abstract meta: D1Response.Meta with get, set
            abstract success: D1Response.Success with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_2")>]
        type AiCfQwenQwen330BA3BFp8JSONMode2 =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiCfQwenQwen330BA3BFp8JSONMode2.Type> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchListItemsResponse")>]
        type AiSearchListItemsResponse =
            [<EmitProperty("result_info")>]
            abstract resultInfo: option<AiSearchListItemsResponse.ResultInfo> with get, set

            abstract result: Array<AiSearchItemInfo> with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionAudio")>]
        type ChatCompletionAudio =
            abstract transcript: D1SessionBookmark with get, set

            [<EmitProperty("expires_at")>]
            abstract expiresAt: float with get, set

            abstract data: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_Guard_3_8B_Output")>]
        type AiCfMetaLlamaGuard38BOutput =
            abstract usage: option<AiCfMetaLlamaGuard38BOutput.Usage> with get, set
            abstract response: option<U2<AiCfMetaLlamaGuard38BOutput.Response, string>> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiSearchJobInfo =
            | [<CompiledName("user")>] User
            | [<CompiledName("schedule")>] Schedule

        [<Import("@cloudflare/workers-types", "Reasoning")>]
        type Reasoning =
            abstract summary: option<Reasoning.Summary> with get, set

            [<EmitProperty("generate_summary")>]
            abstract generateSummary: option<Reasoning.GenerateSummary> with get, set

            abstract effort: option<Reasoning.Effort> with get, set

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

        [<Import("@cloudflare/workers-types", "BaseAiTextToImage"); AbstractClass; AllowNullLiteral>]
        type BaseAiTextToImage private () =
            abstract postProcessedOutputs: AiTextToImageOutput with get, set
            abstract inputs: AiTextToImageInput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_Base_En_V1_5_AsyncResponse")>]
        type AiCfBaaiBgeBaseEnV15AsyncResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionsResponseFormatJSONObject")>]
        type ChatCompletionsResponseFormatJSONObject =
            [<EmitProperty("type")>]
            abstract ``type``: ChatCompletionsResponseFormatJSONObject.Type with get, set

        type ResponseInputItem =
            U6<
                ResponseInputItem,
                ResponseInputItem,
                ResponseInputItem,
                ResponseInputItem,
                ResponseInputItem,
                ResponseInputItem
             >

        [<Import("@cloudflare/workers-types", "R2GetOptions")>]
        type R2GetOptions =
            abstract ssecKey: option<U2<ArrayBuffer, string>> with get, set
            abstract range: option<U4<R2GetOptions.Range, R2GetOptions.Range, R2GetOptions.Range, Headers>> with get, set
            abstract onlyIf: option<U2<R2Conditional, Headers>> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Nvidia_Nemotron_3_120B_A12B"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfNvidiaNemotron3120BA12B private () =
            abstract postProcessedOutputs: ChatCompletionsOutput with get, set
            abstract inputs: ChatCompletionsInput with get, set

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

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type SystemMessage = | [<CompiledName("system")>] System

        type VectorizeVectorMetadataValue = U4<Array<D1SessionBookmark>, string, float, bool>

        [<Import("@cloudflare/workers-types", "ForwardableEmailMessage")>]
        type ForwardableEmailMessage =
            inherit EmailMessage
            abstract rawSize: float with get
            abstract headers: Headers with get
            abstract raw: ReadableStream<Uint8Array<ArrayBufferLike>> with get
            abstract reply: message: EmailMessage -> Promise<EmailSendResult>
            abstract forward: rcptTo: D1SessionBookmark * ?headers: Headers -> Promise<EmailSendResult>
            abstract setReject: reason: D1SessionBookmark -> unit

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode")>]
        type AiCfMetaLlama3370BInstructFp8FastJSONMode =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiCfMetaLlama3370BInstructFp8FastJSONMode.Type> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchListResponse")>]
        type AiSearchListResponse =
            [<EmitProperty("result_info")>]
            abstract resultInfo: option<AiSearchListResponse.ResultInfo> with get, set

            abstract result: Array<AiSearchInstanceInfo> with get, set

        [<Import("@cloudflare/workers-types", "StreamDirectUploadCreateParams")>]
        type StreamDirectUploadCreateParams =
            abstract watermark: option<StreamDirectUploadWatermark> with get, set
            abstract scheduledDeletion: option<string> with get, set
            abstract thumbnailTimestampPct: option<float> with get, set
            abstract requireSignedURLs: option<bool> with get, set
            abstract allowedOrigins: option<Array<D1SessionBookmark>> with get, set
            abstract meta: option<WebAssembly.ModuleImports> with get, set
            abstract creator: option<D1SessionBookmark> with get, set
            abstract expiry: option<D1SessionBookmark> with get, set
            abstract maxDurationSeconds: float with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AIGatewayHeaders =
            | [<CompiledValue(false)>] False
            | [<CompiledValue(true)>] True

        [<Import("@cloudflare/workers-types", "AiSearchNotFoundError"); AbstractClass; AllowNullLiteral>]
        type AiSearchNotFoundError private () =
            inherit exn()

        [<Import("@cloudflare/workers-types", "ReadableStream")>]
        type ReadableStream<'R> =
            abstract locked: bool with get

            abstract symbolAsyncIterator:
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

        [<Import("@cloudflare/workers-types", "ResponseInputText")>]
        type ResponseInputText =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseInputText.Type with get, set

            abstract text: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type VectorizeVectorMetadataFilterOp =
            | [<CompiledName("$eq")>] Eq
            | [<CompiledName("$ne")>] Ne
            | [<CompiledName("$lt")>] Lt
            | [<CompiledName("$lte")>] Lte
            | [<CompiledName("$gt")>] Gt
            | [<CompiledName("$gte")>] Gte

        [<Import("@cloudflare/workers-types", "workerdResourceLimits")>]
        type WorkerdResourceLimits =
            abstract subRequests: option<float> with get, set
            abstract cpuMs: option<float> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ImageInputOptions = | [<CompiledName("base64")>] Base64

        type AiSearchConfig =
            | ``3600`` = 3600
            | ``7200`` = 7200
            | ``14400`` = 14400
            | ``21600`` = 21600
            | ``43200`` = 43200
            | ``86400`` = 86400

        [<Import("@cloudflare/workers-types", "Scheduler")>]
        type Scheduler =
            abstract wait: delay: float * ?maybeOptions: SchedulerWaitOptions -> Promise<unit>

        [<Import("@cloudflare/workers-types", "SubtleCryptoEncryptAlgorithm")>]
        type SubtleCryptoEncryptAlgorithm =
            abstract label: option<BufferSource> with get, set
            abstract length: option<float> with get, set
            abstract counter: option<BufferSource> with get, set
            abstract tagLength: option<float> with get, set
            abstract additionalData: option<BufferSource> with get, set
            abstract iv: option<BufferSource> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "BlobOptions")>]
        type BlobOptions =
            [<EmitProperty("type")>]
            abstract ``type``: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfAi4BharatIndictrans2EnIndic1B private () =
            abstract postProcessedOutputs: AiCfAi4BharatIndictrans2EnIndic1BOutput with get, set
            abstract inputs: AiCfAi4BharatIndictrans2EnIndic1BInput with get, set

        [<Import("@cloudflare/workers-types", "WorkerStubEntrypointOptions")>]
        type WorkerStubEntrypointOptions =
            abstract limits: option<WorkerdResourceLimits> with get, set
            abstract props: option<obj> with get, set

        [<Import("@cloudflare/workers-types", "AiImageTextToTextInput")>]
        type AiImageTextToTextInput =
            abstract messages: option<Array<RoleScopedChatInput>> with get, set
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

        type AiCfQwenQwen330BA3BFp8Output =
            U4<
                AiCfQwenQwen330BA3BFp8ChatCompletionResponse,
                AiCfQwenQwen330BA3BFp8TextCompletionResponse,
                AiCfQwenQwen330BA3BFp8AsyncResponse,
                string
             >

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

        [<Import("@cloudflare/workers-types", "QueueSendResponse")>]
        type QueueSendResponse =
            abstract metadata: QueueSendMetadata with get, set

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

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfMetaLlama4Scout17B16EInstructJSONMode =
            | [<CompiledName("json_object")>] JsonObject
            | [<CompiledName("json_schema")>] JsonSchema

        [<Import("@cloudflare/workers-types", "ExportedHandlerTailStreamHandler")>]
        type ExportedHandlerTailStreamHandler<'Props, 'Env> =
            abstract Invoke:
                event: TailStream.TailEvent<TailStream.Onset> * env: 'Env * ctx: ExecutionContext<'Props> ->
                    U3<
                        TailStream.TailEvent<'Event> -> option<Promise<unit>>,
                        ExportedHandlerTailStreamHandler.Invoke,
                        Promise<TailStream.TailEventHandlerType>
                     >

        [<Import("@cloudflare/workers-types", "R2StringChecksums")>]
        type R2StringChecksums =
            abstract sha512: option<D1SessionBookmark> with get, set
            abstract sha384: option<D1SessionBookmark> with get, set
            abstract sha256: option<D1SessionBookmark> with get, set
            abstract sha1: option<D1SessionBookmark> with get, set
            abstract md5: option<D1SessionBookmark> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type BaseAiCfOpenaiGptOss20B =
            | [<CompiledName("message.input_image.image_url")>] MessageInputImageImageUrl
            | [<CompiledName("message.output_text.logprobs")>] MessageOutputTextLogprobs
            | [<CompiledName("auto")>] Auto
            | [<CompiledName("default")>] Default
            | [<CompiledName("flex")>] Flex
            | [<CompiledName("scale")>] Scale
            | [<CompiledName("priority")>] Priority
            | [<CompiledName("none")>] None
            | [<CompiledName("disabled")>] Disabled
            | [<CompiledName("response")>] Response
            | [<CompiledName("queued")>] Queued
            | [<CompiledName("failed")>] Failed
            | [<CompiledName("completed")>] Completed
            | [<CompiledName("in_progress")>] InProgress
            | [<CompiledName("cancelled")>] Cancelled
            | [<CompiledName("incomplete")>] Incomplete

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionContentPartFile = | [<CompiledName("file")>] File

        [<Import("@cloudflare/workers-types", "AiTextGenerationFunctionsInput")>]
        type AiTextGenerationFunctionsInput =
            abstract code: D1SessionBookmark with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "TraceItemTailEventInfoTailItem")>]
        type TraceItemTailEventInfoTailItem =
            abstract scriptName: option<string> with get

        [<Import("@cloudflare/workers-types", "KVNamespacePutOptions")>]
        type KVNamespacePutOptions =
            abstract metadata: option<obj> with get, set
            abstract expirationTtl: option<float> with get, set
            abstract expiration: option<float> with get, set

        [<Import("@cloudflare/workers-types", "VectorizeError")>]
        type VectorizeError =
            abstract error: D1SessionBookmark with get, set
            abstract code: option<float> with get, set

        [<Import("@cloudflare/workers-types", "ScriptVersion")>]
        type ScriptVersion =
            abstract message: option<D1SessionBookmark> with get, set
            abstract tag: option<D1SessionBookmark> with get, set
            abstract id: option<D1SessionBookmark> with get, set

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

        [<Import("@cloudflare/workers-types", "WorkerLoader")>]
        type WorkerLoader =
            abstract load: code: WorkerLoaderWorkerCode -> WorkerStub

            abstract get:
                ?name: string * getCode: unit -> U2<WorkerLoaderWorkerCode, Promise<WorkerLoaderWorkerCode>> ->
                    WorkerStub

        [<Import("@cloudflare/workers-types", "ImageConversionOptions")>]
        type ImageConversionOptions =
            abstract descriptionLanguage: option<ImageConversionOptions.DescriptionLanguage> with get, set

        [<Import("@cloudflare/workers-types", "CustomEventCustomEventInit")>]
        type CustomEventCustomEventInit =
            abstract detail: option<obj> with get, set
            abstract composed: option<bool> with get, set
            abstract cancelable: option<bool> with get, set
            abstract bubbles: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "ToolChoiceFunction")>]
        type ToolChoiceFunction =
            [<EmitProperty("type")>]
            abstract ``type``: ToolChoiceFunction.Type with get, set

            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionTopLogprob")>]
        type ChatCompletionTopLogprob =
            abstract bytes: option<Array<float>> with get, set
            abstract logprob: float with get, set
            abstract token: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Hyperdrive")>]
        type Hyperdrive =
            abstract database: D1SessionBookmark with get
            abstract password: D1SessionBookmark with get
            abstract user: D1SessionBookmark with get
            abstract port: float with get
            abstract host: D1SessionBookmark with get
            abstract connectionString: D1SessionBookmark with get
            abstract connect: unit -> Socket

        [<Import("@cloudflare/workers-types", "SecretsStoreSecret")>]
        type SecretsStoreSecret =
            abstract get: unit -> Promise<D1SessionBookmark>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type StreamScopedDownloads =
            | [<CompiledName("default")>] Default
            | [<CompiledName("audio")>] Audio

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseIncompleteDetails =
            | [<CompiledName("max_output_tokens")>] MaxOutputTokens
            | [<CompiledName("content_filter")>] ContentFilter

        [<Import("@cloudflare/workers-types", "WritableStream"); AbstractClass; AllowNullLiteral>]
        type WritableStream<'W> private () =
            [<EmitConstructor>]
            abstract Create:
                ?underlyingSink: Typescript.UnderlyingSink<option<obj>> *
                ?queuingStrategy: Typescript.QueuingStrategy<option<obj>> ->
                    WritableStream

            abstract locked: bool with get
            abstract getWriter: unit -> WritableStreamDefaultWriter<'W>
            abstract close: unit -> Promise<unit>
            abstract abort: ?reason: obj -> Promise<unit>

        [<Import("@cloudflare/workers-types", "DynamicDispatchOptions")>]
        type DynamicDispatchOptions =
            abstract outbound: option<WebAssembly.ModuleImports> with get, set
            abstract limits: option<DynamicDispatchLimits> with get, set

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRagSearchResponse")>]
        type AutoRagSearchResponse =
            [<EmitProperty("next_page")>]
            abstract nextPage: option<string> with get, set

            [<EmitProperty("has_more")>]
            abstract hasMore: bool with get, set

            abstract data: Array<AutoRagSearchResponse.Data> with get, set

            [<EmitProperty("search_query")>]
            abstract searchQuery: D1SessionBookmark with get, set

            abstract object: AutoRagSearchResponse.Object with get, set

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

        [<Import("@cloudflare/workers-types", "MessagePortPostMessageOptions")>]
        type MessagePortPostMessageOptions =
            abstract transfer: option<Array<option<obj>>> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type __WORKER_ENTRYPOINT_BRAND = | __WORKER_ENTRYPOINT_BRAND

        [<Import("@cloudflare/workers-types", "AiSearchItemLog")>]
        type AiSearchItemLog =
            abstract errorType: option<D1SessionBookmark> with get, set
            abstract processingTimeMs: option<float> with get, set
            abstract chunkCount: option<float> with get, set
            abstract fileKey: option<D1SessionBookmark> with get, set
            abstract message: D1SessionBookmark with get, set
            abstract action: D1SessionBookmark with get, set
            abstract timestamp: D1SessionBookmark with get, set

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

        type BufferSource = U2<ArrayBufferView<ArrayBufferLike>, ArrayBuffer>

        [<Import("@cloudflare/workers-types", "WebSearchOptions")>]
        type WebSearchOptions =
            [<EmitProperty("user_location")>]
            abstract userLocation: option<WebSearchUserLocation> with get, set

            [<EmitProperty("search_context_size")>]
            abstract searchContextSize: option<WebSearchOptions.SearchContextSize> with get, set

        [<Import("@cloudflare/workers-types", "DeveloperMessage")>]
        type DeveloperMessage =
            abstract name: option<D1SessionBookmark> with get, set
            abstract content: U2<Array<ChatCompletionContentPartText>, string> with get, set
            abstract role: DeveloperMessage.Role with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectGetOptions")>]
        type DurableObjectGetOptions =
            abstract noCache: option<bool> with get, set
            abstract allowConcurrency: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "TraceItemTailEventInfo")>]
        type TraceItemTailEventInfo =
            abstract consumedEvents: Array<TraceItemTailEventInfoTailItem> with get

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfMetaLlama4Scout17B16EInstruct private () =
            abstract postProcessedOutputs: AiCfMetaLlama4Scout17B16EInstructOutput with get, set
            abstract inputs: AiCfMetaLlama4Scout17B16EInstructInput with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Deepgram_Aura_2_Es"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfDeepgramAura2Es private () =
            abstract postProcessedOutputs: D1SessionBookmark with get, set
            abstract inputs: AiCfDeepgramAura2EsInput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_AsyncResponse")>]
        type AiCfBaaiBgeM3AsyncResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "EndTag")>]
        type EndTag =
            abstract name: D1SessionBookmark with get, set
            abstract remove: unit -> EndTag

            abstract after:
                content: U3<ReadableStream<option<obj>>, Typescript.Response, string> * ?options: ContentOptions ->
                    EndTag

            abstract before:
                content: U3<ReadableStream<option<obj>>, Typescript.Response, string> * ?options: ContentOptions ->
                    EndTag

        [<Import("@cloudflare/workers-types", "KVNamespaceListKey")>]
        type KVNamespaceListKey<'Key, 'Metadata when 'Key :> D1SessionBookmark> =
            abstract metadata: option<'Metadata> with get, set
            abstract expiration: option<float> with get, set
            abstract name: 'Key with get, set

        [<Import("@cloudflare/workers-types", "ByteLengthQueuingStrategy"); AbstractClass; AllowNullLiteral>]
        type ByteLengthQueuingStrategy private () =
            inherit Typescript.QueuingStrategy<ArrayBufferView<ArrayBufferLike>>()

            [<EmitConstructor>]
            abstract Create: init: Typescript.QueuingStrategyInit -> ByteLengthQueuingStrategy

            abstract highWaterMark: float with get
            abstract size: ?chunk: obj -> float

        [<Import("@cloudflare/workers-types", "Ai_Cf_Leonardo_Lucid_Origin_Output")>]
        type AiCfLeonardoLucidOriginOutput =
            abstract image: option<D1SessionBookmark> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type StreamWatermarkPosition =
            | [<CompiledName("upperRight")>] UpperRight
            | [<CompiledName("upperLeft")>] UpperLeft
            | [<CompiledName("lowerLeft")>] LowerLeft
            | [<CompiledName("lowerRight")>] LowerRight
            | [<CompiledName("center")>] Center

        [<Import("@cloudflare/workers-types", "File"); AbstractClass; AllowNullLiteral>]
        type File private () =
            inherit Blob()

            [<EmitConstructor>]
            abstract Create:
                ?bits: Array<U4<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, Blob, string>> *
                name: D1SessionBookmark *
                ?options: FileOptions ->
                    File

            abstract lastModified: float with get
            abstract name: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "TraceItemFetchEventInfo")>]
        type TraceItemFetchEventInfo =
            abstract request: TraceItemFetchEventInfoRequest with get
            abstract response: option<TraceItemFetchEventInfoResponse> with get

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type CertVerificationStatus =
            | SUCCESS
            | NONE
            | [<CompiledName("FAILED:self signed certificate")>] ``FAILED:selfsignedcertificate``
            | [<CompiledName("FAILED:unable to verify the first certificate")>] ``FAILED:unabletoverifythefirstcertificate``
            | [<CompiledName("FAILED:certificate is not yet valid")>] ``FAILED:certificateisnotyetvalid``
            | [<CompiledName("FAILED:certificate has expired")>] ``FAILED:certificatehasexpired``
            | FAILED

        [<Import("@cloudflare/workers-types", "BaseAiImageClassification"); AbstractClass; AllowNullLiteral>]
        type BaseAiImageClassification private () =
            abstract postProcessedOutputs: AiImageClassificationOutput with get, set
            abstract inputs: AiImageClassificationInput with get, set

        type AiCfQwenQwen25Coder32BInstructInput = obj

        [<Import("@cloudflare/workers-types", "VectorizeAsyncMutation")>]
        type VectorizeAsyncMutation =
            abstract mutationId: D1SessionBookmark with get, set

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

        [<Import("@cloudflare/workers-types", "Queue")>]
        type Queue<'Body> =
            abstract sendBatch:
                messages: Iterable<MessageSendRequest<'Body>, option<obj>, option<obj>> *
                ?options: QueueSendBatchOptions ->
                    Promise<QueueSendBatchResponse>

            abstract send: message: 'Body * ?options: QueueSendOptions -> Promise<QueueSendResponse>
            abstract metrics: unit -> Promise<QueueMetrics>

        [<Import("@cloudflare/workers-types", "BaseAiAutomaticSpeechRecognition"); AbstractClass; AllowNullLiteral>]
        type BaseAiAutomaticSpeechRecognition private () =
            abstract postProcessedOutputs: AiAutomaticSpeechRecognitionOutput with get, set
            abstract inputs: AiAutomaticSpeechRecognitionInput with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionUrlCitation = | [<CompiledName("url_citation")>] UrlCitation

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Meta_Llama_Guard_3_8B"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfMetaLlamaGuard38B private () =
            abstract postProcessedOutputs: AiCfMetaLlamaGuard38BOutput with get, set
            abstract inputs: AiCfMetaLlamaGuard38BInput with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItemLogsParams")>]
        type AiSearchItemLogsParams =
            abstract cursor: option<D1SessionBookmark> with get, set
            abstract limit: option<float> with get, set

        type AiCfMetaLlama3370BInstructFp8FastOutput =
            U3<AiCfMetaLlama3370BInstructFp8FastOutput, AiCfMetaLlama3370BInstructFp8FastAsyncResponse, string>

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

        type ResponseInputContent = obj

        [<Import("@cloudflare/workers-types", "R2HTTPMetadata")>]
        type R2HTTPMetadata =
            abstract cacheExpiry: option<Date> with get, set
            abstract cacheControl: option<D1SessionBookmark> with get, set
            abstract contentEncoding: option<D1SessionBookmark> with get, set
            abstract contentDisposition: option<D1SessionBookmark> with get, set
            abstract contentLanguage: option<D1SessionBookmark> with get, set
            abstract contentType: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "AIGatewayUniversalRequest")>]
        type AIGatewayUniversalRequest =
            abstract query: option<obj> with get, set
            abstract headers: AIGatewayUniversalRequest.Headers with get, set
            abstract endpoint: D1SessionBookmark with get, set
            abstract provider: U2<AIGatewayUniversalRequest.Provider, string> with get, set

        [<Import("@cloudflare/workers-types", "StreamVideos")>]
        type StreamVideos =
            abstract list: ?params: StreamVideosListParams -> Promise<Array<StreamVideo>>

        [<Import("@cloudflare/workers-types", "IdentityTransformStreamQueuingStrategy")>]
        type IdentityTransformStreamQueuingStrategy =
            abstract highWaterMark: option<float> with get, set

        type AiCfUnumUformGen2Qwen500MInput = U2<AiCfUnumUformGen2Qwen500MInput, string>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Async_Batch")>]
        type AiCfMetaLlama3370BInstructFp8FastAsyncBatch =
            abstract requests: option<Array<AiCfMetaLlama3370BInstructFp8FastAsyncBatch.Requests>> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type RequestInfo =
            | [<CompiledName("1")>] ``1``
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
            | AN
            | EU
            | OC

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

        [<Import("@cloudflare/workers-types", "IncomingRequestCfPropertiesCloudflareForSaaSEnterprise")>]
        type IncomingRequestCfPropertiesCloudflareForSaaSEnterprise<'HostMetadata> =
            abstract hostMetadata: option<'HostMetadata> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type EasyInputMessage =
            | [<CompiledName("message")>] Message
            | [<CompiledName("user")>] User
            | [<CompiledName("assistant")>] Assistant
            | [<CompiledName("system")>] System
            | [<CompiledName("developer")>] Developer

        [<Import("@cloudflare/workers-types", "DurableObjectId")>]
        type DurableObjectId =
            abstract jurisdiction: option<D1SessionBookmark> with get
            abstract name: option<D1SessionBookmark> with get
            abstract equals: other: DurableObjectId -> bool
            abstract toString: unit -> D1SessionBookmark

        [<Import("@cloudflare/workers-types", "AiSearchItems"); AbstractClass; AllowNullLiteral>]
        type AiSearchItems private () =
            abstract timeoutMs: option<float> with get, set
            abstract pollIntervalMs: option<float> with get, set
            abstract metadata: option<WebAssembly.ModuleImports> with get, set
            abstract delete: itemId: D1SessionBookmark -> Promise<unit>
            abstract get: itemId: D1SessionBookmark -> AiSearchItem

            abstract uploadAndPoll:
                name: D1SessionBookmark *
                content: U3<ReadableStream<option<obj>>, Blob, string> *
                ?options: AiSearchItems.UploadAndPoll.Options ->
                    Promise<AiSearchItemInfo>

            abstract upload:
                name: D1SessionBookmark *
                content: U3<ReadableStream<option<obj>>, Blob, string> *
                ?options: AiSearchUploadItemOptions ->
                    Promise<AiSearchItemInfo>

            abstract list: ?params: AiSearchListItemsParams -> Promise<AiSearchListItemsResponse>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseCustomToolCallOutput = | [<CompiledName("custom_tool_call_output")>] CustomToolCallOutput

        [<Import("@cloudflare/workers-types", "SqlStorage")>]
        type SqlStorage =
            [<EmitProperty("Statement")>]
            abstract statement: SqlStorage.Statement with get, set

            [<EmitProperty("Cursor")>]
            abstract cursor: SqlStorage.Cursor with get, set

            abstract databaseSize: float with get

            abstract exec:
                query: D1SessionBookmark * [<ParamArray>] bindings: Array<option<obj>> -> SqlStorageCursor<'T>

        [<Import("@cloudflare/workers-types", "ConversionOptions")>]
        type ConversionOptions =
            abstract pdf: option<ConversionOptions.Pdf> with get, set
            abstract image: option<ImageConversionOptions> with get, set
            abstract docx: option<ConversionOptions.Docx> with get, set
            abstract html: option<ConversionOptions.Html> with get, set

        [<Import("@cloudflare/workers-types", "CryptoKey"); AbstractClass; AllowNullLiteral>]
        type CryptoKey private () =
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

            [<EmitProperty("type")>]
            abstract ``type``: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "ChatCompletionLogprobs")>]
        type ChatCompletionLogprobs =
            abstract refusal: option<Array<ChatCompletionTokenLogprob>> with get, set
            abstract content: option<Array<ChatCompletionTokenLogprob>> with get, set

        [<Import("@cloudflare/workers-types", "PredictionContent")>]
        type PredictionContent =
            abstract content: U2<Array<ChatCompletionContentPartText>, string> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: PredictionContent.Type with get, set

        [<Import("@cloudflare/workers-types", "StreamScopedCaptions")>]
        type StreamScopedCaptions =
            abstract delete: language: D1SessionBookmark -> Promise<unit>
            abstract list: ?language: D1SessionBookmark -> Promise<Array<StreamCaption>>
            abstract generate: language: D1SessionBookmark -> Promise<StreamCaption>
            abstract upload: language: D1SessionBookmark * input: AiTextToImageOutput -> Promise<StreamCaption>

        [<Import("@cloudflare/workers-types", "AiTranslationOutput")>]
        type AiTranslationOutput =
            [<EmitProperty("translated_text")>]
            abstract translatedText: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ResponseFunctionCallArgumentsDeltaEvent")>]
        type ResponseFunctionCallArgumentsDeltaEvent =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseFunctionCallArgumentsDeltaEvent.Type with get, set

            [<EmitProperty("sequence_number")>]
            abstract sequenceNumber: float with get, set

            [<EmitProperty("output_index")>]
            abstract outputIndex: float with get, set

            [<EmitProperty("item_id")>]
            abstract itemId: D1SessionBookmark with get, set

            abstract delta: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseStatus =
            | [<CompiledName("completed")>] Completed
            | [<CompiledName("failed")>] Failed
            | [<CompiledName("in_progress")>] InProgress
            | [<CompiledName("cancelled")>] Cancelled
            | [<CompiledName("queued")>] Queued
            | [<CompiledName("incomplete")>] Incomplete

        [<Import("@cloudflare/workers-types", "WorkerLoaderModule")>]
        type WorkerLoaderModule =
            abstract wasm: option<ArrayBuffer> with get, set
            abstract py: option<D1SessionBookmark> with get, set
            abstract json: option<obj> with get, set
            abstract data: option<ArrayBuffer> with get, set
            abstract text: option<D1SessionBookmark> with get, set
            abstract cjs: option<D1SessionBookmark> with get, set
            abstract js: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "EventTargetHandlerObject")>]
        type EventTargetHandlerObject =
            abstract handleEvent: event: Event -> option<obj>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_Small_En_V1_5_AsyncResponse")>]
        type AiCfBaaiBgeSmallEnV15AsyncResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "SyncKvListOptions")>]
        type SyncKvListOptions =
            abstract limit: option<float> with get, set
            abstract reverse: option<bool> with get, set
            abstract prefix: option<D1SessionBookmark> with get, set

            [<EmitProperty("end")>]
            abstract ``end``: option<D1SessionBookmark> with get, set

            abstract startAfter: option<D1SessionBookmark> with get, set
            abstract start: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "EventListener")>]
        type EventListener<'EventType when 'EventType :> Event> =
            abstract Invoke: event: 'EventType -> unit

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Async_Batch")>]
        type AiCfQwenQwen330BA3BFp8AsyncBatch =
            abstract requests: Array<U2<AiCfQwenQwen330BA3BFp8Prompt1, AiCfQwenQwen330BA3BFp8Messages1>> with get, set

        [<Import("@cloudflare/workers-types", "CachePurgeOptions")>]
        type CachePurgeOptions =
            abstract purgeEverything: option<bool> with get, set
            abstract pathPrefixes: option<Array<D1SessionBookmark>> with get, set
            abstract tags: option<Array<D1SessionBookmark>> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type VectorizeDistanceMetric =
            | [<CompiledName("euclidean")>] Euclidean
            | [<CompiledName("cosine")>] Cosine
            | [<CompiledName("dot-product")>] DotProduct

        [<Import("@cloudflare/workers-types", "CacheStorage"); AbstractClass; AllowNullLiteral>]
        type CacheStorage private () =
            [<EmitProperty("default")>]
            abstract ``default``: Cache with get

            abstract ``open``: cacheName: D1SessionBookmark -> Promise<Cache>

        [<Import("@cloudflare/workers-types", "AiTextToSpeechInput")>]
        type AiTextToSpeechInput =
            abstract lang: option<D1SessionBookmark> with get, set
            abstract prompt: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "VectorizeIndexDetails")>]
        type VectorizeIndexDetails =
            abstract vectorsCount: float with get, set
            abstract config: VectorizeIndexConfig with get, set
            abstract description: option<D1SessionBookmark> with get, set
            abstract name: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "AiImageToTextOutput")>]
        type AiImageToTextOutput =
            abstract description: D1SessionBookmark with get, set

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

        [<Import("@cloudflare/workers-types", "EventTargetAddEventListenerOptions")>]
        type EventTargetAddEventListenerOptions =
            abstract signal: option<AbortSignal> with get, set
            abstract once: option<bool> with get, set
            abstract passive: option<bool> with get, set
            abstract capture: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "ImageOutputOptions")>]
        type ImageOutputOptions =
            abstract anim: option<bool> with get, set
            abstract background: option<D1SessionBookmark> with get, set
            abstract quality: option<float> with get, set
            abstract format: ImageOutputOptions.Format with get, set

        [<Import("@cloudflare/workers-types", "RequestInitCfPropertiesImageMinify")>]
        type RequestInitCfPropertiesImageMinify =
            abstract html: option<bool> with get, set
            abstract css: option<bool> with get, set
            abstract javascript: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "ArtifactsCreateRepoResult")>]
        type ArtifactsCreateRepoResult =
            abstract tokenExpiresAt: D1SessionBookmark with get, set
            abstract token: D1SessionBookmark with get, set
            abstract remote: D1SessionBookmark with get, set
            abstract defaultBranch: D1SessionBookmark with get, set
            abstract description: option<string> with get, set
            abstract name: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

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

        [<Import("@cloudflare/workers-types", "AiGatewayLogNotFound"); AbstractClass; AllowNullLiteral>]
        type AiGatewayLogNotFound private () =
            inherit exn()

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseFormatJSONObject = | [<CompiledName("json_object")>] JsonObject

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode_1")>]
        type AiCfMetaLlama3370BInstructFp8FastJSONMode1 =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiCfMetaLlama3370BInstructFp8FastJSONMode1.Type> with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionContentPartRefusal")>]
        type ChatCompletionContentPartRefusal =
            abstract refusal: D1SessionBookmark with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ChatCompletionContentPartRefusal.Type with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type DurableObjectRoutingMode = | [<CompiledName("primary-only")>] DurableObjectRoutingMode

        type AiCfBaaiBgeSmallEnV15Input = obj

        type Btoa =
            abstract Invoke: data: D1SessionBookmark -> D1SessionBookmark
            abstract Invoke: data: D1SessionBookmark -> D1SessionBookmark

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
            abstract audio: U2<AiCfOpenaiWhisperLargeV3TurboInput.Audio, string> with get, set

        [<Import("@cloudflare/workers-types", "WorkflowInstance"); AbstractClass; AllowNullLiteral>]
        type WorkflowInstance private () =
            abstract id: D1SessionBookmark with get, set
            abstract sendEvent: typepayload: WorkflowInstance.SendEvent.Typepayload -> Promise<unit>
            abstract status: unit -> Promise<InstanceStatus>
            abstract restart: unit -> Promise<unit>
            abstract terminate: unit -> Promise<unit>
            abstract resume: unit -> Promise<unit>
            abstract pause: unit -> Promise<unit>

        [<Import("@cloudflare/workers-types", "AiSearchItemLogsResponse")>]
        type AiSearchItemLogsResponse =
            [<EmitProperty("result_info")>]
            abstract resultInfo: AiSearchItemLogsResponse.ResultInfo with get, set

            abstract result: Array<AiSearchItemLog> with get, set

        [<Import("@cloudflare/workers-types", "ContainerSnapshotOptions")>]
        type ContainerSnapshotOptions =
            abstract name: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "AiTextGenerationToolLegacyOutput")>]
        type AiTextGenerationToolLegacyOutput =
            abstract arguments: option<obj> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "TraceItemHibernatableWebSocketEventInfoError")>]
        type TraceItemHibernatableWebSocketEventInfoError =
            abstract webSocketEventType: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "AiSearchListItemsParams")>]
        type AiSearchListItemsParams =
            [<EmitProperty("metadata_filter")>]
            abstract metadataFilter: option<D1SessionBookmark> with get, set

            abstract source: option<D1SessionBookmark> with get, set
            abstract status: option<AiSearchListItemsParams.Status> with get, set

            [<EmitProperty("sort_by")>]
            abstract sortBy: option<AiSearchListItemsParams.SortBy> with get, set

            abstract search: option<D1SessionBookmark> with get, set

            [<EmitProperty("per_page")>]
            abstract perPage: option<float> with get, set

            abstract page: option<float> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchJob"); AbstractClass; AllowNullLiteral>]
        type AiSearchJob private () =
            abstract cancel: unit -> Promise<AiSearchJobInfo>
            abstract logs: ?params: AiSearchJobLogsParams -> Promise<AiSearchJobLogsResponse>
            abstract info: unit -> Promise<AiSearchJobInfo>

        [<Import("@cloudflare/workers-types", "ScheduledEvent"); AbstractClass; AllowNullLiteral>]
        type ScheduledEvent private () =
            inherit ExtendableEvent()
            abstract cron: D1SessionBookmark with get
            abstract scheduledTime: float with get
            abstract noRetry: unit -> unit

        [<Import("@cloudflare/workers-types", "ImageList")>]
        type ImageList =
            abstract listComplete: bool with get, set
            abstract cursor: option<D1SessionBookmark> with get, set
            abstract images: Array<ImageMetadata> with get, set

        type AiCfBaaiBgeBaseEnV15Output = obj

        [<Import("@cloudflare/workers-types", "CachePurgeError")>]
        type CachePurgeError =
            abstract message: D1SessionBookmark with get, set
            abstract code: float with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Deepgram_Aura_1"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfDeepgramAura1 private () =
            abstract postProcessedOutputs: D1SessionBookmark with get, set
            abstract inputs: AiCfDeepgramAura1Input with get, set

        [<Import("@cloudflare/workers-types", "WorkerVersionMetadata")>]
        type WorkerVersionMetadata =
            abstract timestamp: D1SessionBookmark with get, set
            abstract tag: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "MediaTransformationResult")>]
        type MediaTransformationResult =
            abstract contentType: unit -> Promise<D1SessionBookmark>
            abstract response: unit -> Promise<Typescript.Response>
            abstract media: unit -> Promise<ReadableStream<Uint8Array<ArrayBufferLike>>>

        type ImageInfoResponse = obj

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponsesOutput =
            | [<CompiledName("queued")>] Queued
            | [<CompiledName("failed")>] Failed
            | [<CompiledName("completed")>] Completed
            | [<CompiledName("in_progress")>] InProgress
            | [<CompiledName("cancelled")>] Cancelled
            | [<CompiledName("incomplete")>] Incomplete
            | [<CompiledName("auto")>] Auto
            | [<CompiledName("disabled")>] Disabled
            | [<CompiledName("default")>] Default
            | [<CompiledName("flex")>] Flex
            | [<CompiledName("scale")>] Scale
            | [<CompiledName("priority")>] Priority
            | [<CompiledName("response")>] Response

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AutoRagAiSearchRequestStreaming =
            | [<CompiledValue(true)>] True
            | [<CompiledValue(false)>] False

        type AiSearchNamespace =
            abstract errors: option<Array<AiSearchMultiSearchError>> with get, set
            abstract chunks: Array<AiSearchMultiSearchChunk> with get, set

            [<EmitProperty("ai_search_options")>]
            abstract aiSearchOptions: AiSearchMultiSearchOptions with get, set

            abstract stream: AiSearchNamespace.Stream with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

            abstract chatCompletions:
                params: AiSearchMultiChatCompletionsRequest -> Promise<AiSearchMultiChatCompletionsResponse>

            abstract chatCompletions: params: AiSearchNamespace.ChatCompletions.Params -> Promise<AiTextToImageOutput>
            abstract search: params: AiSearchMultiSearchRequest -> Promise<AiSearchMultiSearchResponse>
            abstract delete: name: D1SessionBookmark -> Promise<unit>
            abstract create: config: AiSearchConfig -> Promise<AiSearchInstance>
            abstract list: ?params: AiSearchListInstancesParams -> Promise<AiSearchListResponse>
            abstract get: name: D1SessionBookmark -> AiSearchInstance

        type ResponseFormat = obj

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
            abstract image: option<U2<Array<float>, AiCfMetaLlama3211BVisionInstructMessages.Image>> with get, set
            abstract messages: Array<AiCfMetaLlama3211BVisionInstructMessages.Messages> with get, set

        [<Import("@cloudflare/workers-types", "ArtifactsCreateTokenResult")>]
        type ArtifactsCreateTokenResult =
            abstract expiresAt: D1SessionBookmark with get, set
            abstract scope: ArtifactsCreateTokenResult.Scope with get, set
            abstract plaintext: D1SessionBookmark with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "FacetStartupOptions")>]
        type FacetStartupOptions<'T when 'T :> Rpc.DurableObjectBranded> =
            [<EmitProperty("class")>]
            abstract ``class``: DurableObjectClass<'T> with get, set

            abstract id: option<U2<DurableObjectId, string>> with get, set

        type R2Objects = U2<R2Objects, R2Objects>

        [<Import("@cloudflare/workers-types", "R2Checksums")>]
        type R2Checksums =
            abstract sha512: option<ArrayBuffer> with get
            abstract sha384: option<ArrayBuffer> with get
            abstract sha256: option<ArrayBuffer> with get
            abstract sha1: option<ArrayBuffer> with get
            abstract md5: option<ArrayBuffer> with get
            abstract toJSON: unit -> R2StringChecksums

        [<Import("@cloudflare/workers-types", "BaseAiTextGeneration"); AbstractClass; AllowNullLiteral>]
        type BaseAiTextGeneration private () =
            abstract postProcessedOutputs: AiTextGenerationOutput with get, set
            abstract inputs: AiTextGenerationInput with get, set

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

            abstract tools:
                option<
                    Array<U2<AiCfQwenQwen25Coder32BInstructMessages.Tools, AiCfQwenQwen25Coder32BInstructMessages.Tools>>
                 > with get, set

            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: Array<AiCfQwenQwen25Coder32BInstructMessages.Messages> with get, set

        type AiGatewayPatchLog =
            | ``-1`` = -1
            | ``1`` = 1

        [<Import("@cloudflare/workers-types", "VectorizeIndex"); AbstractClass; AllowNullLiteral>]
        type VectorizeIndex private () =
            abstract getByIds: ids: Array<D1SessionBookmark> -> Promise<Array<VectorizeVector>>
            abstract deleteByIds: ids: Array<D1SessionBookmark> -> Promise<VectorizeVectorMutation>
            abstract upsert: vectors: Array<VectorizeVector> -> Promise<VectorizeVectorMutation>
            abstract insert: vectors: Array<VectorizeVector> -> Promise<VectorizeVectorMutation>

            abstract query:
                vector: U3<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>, Array<float>> *
                ?options: VectorizeQueryOptions ->
                    Promise<VectorizeMatches>

            abstract describe: unit -> Promise<VectorizeIndexDetails>

        [<Import("@cloudflare/workers-types", "AiSearchItemChunksResponse")>]
        type AiSearchItemChunksResponse =
            [<EmitProperty("result_info")>]
            abstract resultInfo: AiSearchItemChunksResponse.ResultInfo with get, set

            abstract result: Array<AiSearchItemChunk> with get, set

        [<Import("@cloudflare/workers-types", "TextEncoderStream"); AbstractClass; AllowNullLiteral>]
        type TextEncoderStream private () =
            inherit TransformStream<D1SessionBookmark, Uint8Array<ArrayBufferLike>>()

            [<EmitConstructor>]
            abstract Create: unit -> TextEncoderStream

            abstract encoding: D1SessionBookmark with get

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfDeepgramNova3Input =
            | [<CompiledName("general")>] General
            | [<CompiledName("medical")>] Medical
            | [<CompiledName("finance")>] Finance
            | [<CompiledName("linear16")>] Linear16
            | [<CompiledName("flac")>] Flac
            | [<CompiledName("mulaw")>] Mulaw
            | [<CompiledName("amr-nb")>] AmrNb
            | [<CompiledName("amr-wb")>] AmrWb
            | [<CompiledName("opus")>] Opus
            | [<CompiledName("speex")>] Speex
            | [<CompiledName("g729")>] G729
            | [<CompiledName("extended")>] Extended
            | [<CompiledName("strict")>] Strict

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

        type AiCfQwenQwen330BA3BFp8Input = obj

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AssistantMessageContentPart =
            | [<CompiledName("text")>] Text
            | [<CompiledName("refusal")>] Refusal

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionsResponseFormatText = | [<CompiledName("text")>] Text

        [<Import("@cloudflare/workers-types", "Ai_Cf_Pipecat_Ai_Smart_Turn_V2_Output")>]
        type AiCfPipecatAiSmartTurnV2Output =
            abstract probability: option<float> with get, set

            [<EmitProperty("is_complete")>]
            abstract isComplete: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "IdentityTransformStream"); AbstractClass; AllowNullLiteral>]
        type IdentityTransformStream private () =
            inherit TransformStream<BufferSource, Uint8Array<ArrayBufferLike>>()

            [<EmitConstructor>]
            abstract Create: ?queuingStrategy: IdentityTransformStreamQueuingStrategy -> IdentityTransformStream

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfQwenQwen330BA3BFp8JSONMode3 =
            | [<CompiledName("json_object")>] JsonObject
            | [<CompiledName("json_schema")>] JsonSchema

        type ResponseFunctionCallOutputItem =
            [<EmitProperty("image_url")>]
            abstract imageUrl: option<string> with get, set

            abstract detail: option<ResponseFunctionCallOutputItem.Detail> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ResponseFunctionCallOutputItem.Type with get, set

            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "StreamVideo")>]
        type StreamVideo =
            abstract publicDetails: option<StreamVideo.PublicDetails> with get, set
            abstract clippedFromId: option<string> with get, set
            abstract liveInputId: option<string> with get, set
            abstract watermark: option<StreamVideo.Watermark> with get, set
            abstract dashPlaybackUrl: D1SessionBookmark with get, set
            abstract hlsPlaybackUrl: D1SessionBookmark with get, set
            abstract input: StreamVideoInput with get, set
            abstract duration: float with get, set
            abstract maxDurationSeconds: option<float> with get, set
            abstract maxSizeBytes: option<float> with get, set
            abstract uploadExpiry: option<string> with get, set
            abstract uploaded: option<string> with get, set
            abstract requireSignedURLs: option<bool> with get, set
            abstract allowedOrigins: Array<D1SessionBookmark> with get, set
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

        type AiCfOpenaiWhisperTinyEnInput = U2<AiCfOpenaiWhisperTinyEnInput, string>

        [<Import("@cloudflare/workers-types", "HTMLRewriterDocumentContentHandlers")>]
        type HTMLRewriterDocumentContentHandlers =
            abstract ``end``: ``end``: DocumentEnd -> option<Promise<unit>>
            abstract text: text: Typescript.Text -> option<Promise<unit>>
            abstract comments: comment: Typescript.Comment -> option<Promise<unit>>
            abstract doctype: doctype: Doctype -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "CacheContext")>]
        type CacheContext =
            abstract purge: options: CachePurgeOptions -> Promise<CachePurgeResult>

        [<Import("@cloudflare/workers-types", "ExportedHandlerScheduledHandler")>]
        type ExportedHandlerScheduledHandler<'Props, 'Env> =
            abstract Invoke:
                controller: ScheduledController * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "ResponsePrompt")>]
        type ResponsePrompt =
            abstract version: option<string> with get, set
            abstract variables: option<ResponsePrompt.Variables> with get, set
            abstract id: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ForbiddenError = | ForbiddenError

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type EmbeddedImageConversionOptions =
            | [<CompiledName("en")>] En
            | [<CompiledName("es")>] Es
            | [<CompiledName("fr")>] Fr
            | [<CompiledName("it")>] It
            | [<CompiledName("pt")>] Pt
            | [<CompiledName("de")>] De

        [<Import("@cloudflare/workers-types", "SubtleCryptoDeriveKeyAlgorithm")>]
        type SubtleCryptoDeriveKeyAlgorithm =
            abstract info: option<BufferSource> with get, set

            [<EmitProperty("$public")>]
            abstract ``public``: option<CryptoKey> with get, set

            abstract hash: option<U2<SubtleCryptoHashAlgorithm, string>> with get, set
            abstract iterations: option<float> with get, set
            abstract salt: option<BufferSource> with get, set
            abstract name: D1SessionBookmark with get, set

        type AiCfMetaM2M10012BInput = obj

        [<Import("@cloudflare/workers-types", "FormData"); AbstractClass; AllowNullLiteral>]
        type FormData private () =
            [<EmitConstructor>]
            abstract Create: unit -> FormData

            abstract symbolIterator:
                unit -> IterableIterator<D1SessionBookmark * D1SessionBookmark, option<obj>, option<obj>>

            abstract forEach: callback: FormData.ForEach.Callback * ?thisArg: 'This -> unit
            abstract values: unit -> IterableIterator<U2<File, string>, option<obj>, option<obj>>
            abstract keys: unit -> IterableIterator<D1SessionBookmark, option<obj>, option<obj>>
            abstract entries: unit -> IterableIterator<D1SessionBookmark * D1SessionBookmark, option<obj>, option<obj>>
            abstract set: name: D1SessionBookmark * value: Blob * ?filename: D1SessionBookmark -> unit
            abstract set: name: D1SessionBookmark * value: D1SessionBookmark -> unit
            abstract set: name: D1SessionBookmark * value: U2<Blob, string> -> unit
            abstract has: name: D1SessionBookmark -> bool
            abstract getAll: name: D1SessionBookmark -> Array<D1SessionBookmark>
            abstract get: name: D1SessionBookmark -> option<string>
            abstract delete: name: D1SessionBookmark -> unit
            abstract append: name: D1SessionBookmark * value: Blob * ?filename: D1SessionBookmark -> unit
            abstract append: name: D1SessionBookmark * value: D1SessionBookmark -> unit
            abstract append: name: D1SessionBookmark * value: U2<Blob, string> -> unit

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
            abstract scriptTags: option<Array<D1SessionBookmark>> with get
            abstract dispatchNamespace: option<D1SessionBookmark> with get
            abstract scriptVersion: option<ScriptVersion> with get
            abstract entrypoint: option<D1SessionBookmark> with get
            abstract scriptName: option<string> with get
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

        [<Import("@cloudflare/workers-types", "AiTextGenerationResponseFormat")>]
        type AiTextGenerationResponseFormat =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: D1SessionBookmark with get, set

        type ResponseInputMessageContentList = obj

        [<Import("@cloudflare/workers-types", "SupportedFileFormat")>]
        type SupportedFileFormat =
            abstract extension: D1SessionBookmark with get, set
            abstract mimeType: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "FileOptions")>]
        type FileOptions =
            abstract lastModified: option<float> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<D1SessionBookmark> with get, set

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

        type AiObjectDetectionOutput = obj

        [<Import("@cloudflare/workers-types", "ResponseInputMessageItem")>]
        type ResponseInputMessageItem =
            [<EmitProperty("type")>]
            abstract ``type``: option<ResponseInputMessageItem.Type> with get, set

            abstract status: option<ResponseInputMessageItem.Status> with get, set
            abstract role: ResponseInputMessageItem.Role with get, set
            abstract content: ResponseInputMessageContentList with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectSetAlarmOptions")>]
        type DurableObjectSetAlarmOptions =
            abstract allowUnconfirmed: option<bool> with get, set
            abstract allowConcurrency: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "AiInternalError"); AbstractClass; AllowNullLiteral>]
        type AiInternalError private () =
            inherit exn()

        [<Import("@cloudflare/workers-types", "MediaTransformationInputOptions")>]
        type MediaTransformationInputOptions =
            abstract height: option<float> with get, set
            abstract width: option<float> with get, set
            abstract fit: option<MediaTransformationInputOptions.Fit> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type StreamDownloadStatus =
            | [<CompiledName("ready")>] Ready
            | [<CompiledName("inprogress")>] Inprogress
            | [<CompiledName("error")>] Error

        [<Import("@cloudflare/workers-types", "FlagshipEvaluationDetails")>]
        type FlagshipEvaluationDetails<'T> =
            abstract errorMessage: option<string> with get, set
            abstract errorCode: option<string> with get, set
            abstract reason: option<string> with get, set
            abstract variant: option<string> with get, set
            abstract value: 'T with get, set
            abstract flagKey: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Performance"); AbstractClass; AllowNullLiteral>]
        type Performance private () =
            abstract timeOrigin: float with get
            abstract toJSON: unit -> obj
            abstract now: unit -> float

        [<Import("@cloudflare/workers-types", "URLPatternOptions")>]
        type URLPatternOptions =
            abstract ignoreCase: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "AiAutomaticSpeechRecognitionOutput")>]
        type AiAutomaticSpeechRecognitionOutput =
            abstract vtt: option<D1SessionBookmark> with get, set
            abstract words: option<Array<AiAutomaticSpeechRecognitionOutput.Words>> with get, set
            abstract text: option<D1SessionBookmark> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseReasoningItem =
            | [<CompiledName("in_progress")>] InProgress
            | [<CompiledName("completed")>] Completed
            | [<CompiledName("incomplete")>] Incomplete
            | [<CompiledName("reasoning")>] Reasoning

        [<Import("@cloudflare/workers-types", "ContainerDirectorySnapshotRestoreParams")>]
        type ContainerDirectorySnapshotRestoreParams =
            abstract mountPoint: option<D1SessionBookmark> with get, set
            abstract snapshot: ContainerDirectorySnapshot with get, set

        [<Import("@cloudflare/workers-types", "ComparisonFilter")>]
        type ComparisonFilter =
            abstract value: U3<string, float, bool> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ComparisonFilter.Type with get, set

            abstract key: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "PagesPluginFunction")>]
        type PagesPluginFunction<'PluginArgs, 'Data, 'Params, 'Env
            when 'Data :> WebAssembly.ModuleImports and 'Params :> D1SessionBookmark> =
            abstract Invoke:
                context: PagesPluginFunction.Invoke.Context -> U2<Typescript.Response, Promise<Typescript.Response>>

        [<Import("@cloudflare/workers-types", "ResponseUsage")>]
        type ResponseUsage =
            [<EmitProperty("total_tokens")>]
            abstract totalTokens: float with get, set

            [<EmitProperty("output_tokens")>]
            abstract outputTokens: float with get, set

            [<EmitProperty("input_tokens")>]
            abstract inputTokens: float with get, set

        [<Import("@cloudflare/workers-types", "Without")>]
        type Without<'U, 'T> =
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Google_Gemma_3_12B_It"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfGoogleGemma312BIt private () =
            abstract postProcessedOutputs: AiCfGoogleGemma312BItOutput with get, set
            abstract inputs: AiCfGoogleGemma312BItInput with get, set

        [<Import("@cloudflare/workers-types", "AbortController"); AbstractClass; AllowNullLiteral>]
        type AbortController private () =
            [<EmitConstructor>]
            abstract Create: unit -> AbortController

            abstract signal: AbortSignal with get
            abstract abort: ?reason: obj -> unit

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseItem =
            | [<CompiledName("function_call_output")>] FunctionCallOutput
            | [<CompiledName("message")>] Message
            | [<CompiledName("user")>] User
            | [<CompiledName("system")>] System
            | [<CompiledName("developer")>] Developer
            | [<CompiledName("in_progress")>] InProgress
            | [<CompiledName("completed")>] Completed
            | [<CompiledName("incomplete")>] Incomplete

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

            abstract tools: option<Array<U2<AiCfQwenQwq32BMessages.Tools, AiCfQwenQwq32BMessages.Tools>>> with get, set
            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: Array<AiCfQwenQwq32BMessages.Messages> with get, set

        [<Import("@cloudflare/workers-types", "AiObjectDetectionInput")>]
        type AiObjectDetectionInput =
            abstract image: AiSentenceSimilarityOutput with get, set

        type VectorizeIndexConfig = obj

        [<Import("@cloudflare/workers-types", "URLSearchParams"); AbstractClass; AllowNullLiteral>]
        type URLSearchParams private () =
            [<EmitConstructor>]
            abstract Create:
                ?init: U4<URLSearchParams, URLSearchParams.Init, Array<D1SessionBookmark * D1SessionBookmark>, string> ->
                    URLSearchParams

            abstract size: float with get

            abstract symbolIterator:
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
            abstract get: name: D1SessionBookmark -> option<string>
            abstract delete: name: D1SessionBookmark -> unit
            abstract append: name: D1SessionBookmark * value: D1SessionBookmark -> unit

        [<Import("@cloudflare/workers-types", "JsonWebKeyWithKid")>]
        type JsonWebKeyWithKid =
            inherit Typescript.JsonWebKey
            abstract kid: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "AiTextEmbeddingsInput")>]
        type AiTextEmbeddingsInput =
            abstract text: U2<Array<D1SessionBookmark>, string> with get, set

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

        [<Import("@cloudflare/workers-types", "TraceItemFetchEventInfoRequest")>]
        type TraceItemFetchEventInfoRequest =
            abstract url: D1SessionBookmark with get
            abstract method: D1SessionBookmark with get
            abstract headers: WebAssembly.ModuleImports with get
            abstract cf: option<obj> with get
            abstract getUnredacted: unit -> TraceItemFetchEventInfoRequest

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type StreamWatermark =
            | [<CompiledName("upperRight")>] UpperRight
            | [<CompiledName("upperLeft")>] UpperLeft
            | [<CompiledName("lowerLeft")>] LowerLeft
            | [<CompiledName("lowerRight")>] LowerRight
            | [<CompiledName("center")>] Center

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfAi4BharatIndictrans2EnIndic1BInput =
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

        [<Import("@cloudflare/workers-types", "ConversionRequestOptions")>]
        type ConversionRequestOptions =
            abstract conversionOptions: option<ConversionOptions> with get, set
            abstract extraHeaders: option<obj> with get, set
            abstract gateway: option<GatewayOptions> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Input_QueryAnd_Contexts")>]
        type AiCfBaaiBgeM3InputQueryAndContexts =
            [<EmitProperty("truncate_inputs")>]
            abstract truncateInputs: option<bool> with get, set

            abstract contexts: Array<AiCfBaaiBgeM3InputQueryAndContexts.Contexts> with get, set
            abstract query: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "WorkerLoaderWorkerCode")>]
        type WorkerLoaderWorkerCode =
            abstract streamingTails: option<Array<WorkerLoaderWorkerCode.StreamingTails>> with get, set
            abstract tails: option<Array<WorkerLoaderWorkerCode.Tails>> with get, set
            abstract globalOutbound: option<WorkerLoaderWorkerCode.GlobalOutbound> with get, set
            abstract env: option<obj> with get, set
            abstract modules: WebAssembly.ModuleImports with get, set
            abstract mainModule: D1SessionBookmark with get, set
            abstract limits: option<WorkerdResourceLimits> with get, set
            abstract allowExperimental: option<bool> with get, set
            abstract compatibilityFlags: option<Array<D1SessionBookmark>> with get, set
            abstract compatibilityDate: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ExportedHandlerQueueHandler")>]
        type ExportedHandlerQueueHandler<'Props, 'Message, 'Env> =
            abstract Invoke:
                batch: MessageBatch<'Message> * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        type ClearTimeout =
            abstract Invoke: ?timeoutId: float -> unit
            abstract Invoke: ?id: float -> unit

        [<Import("@cloudflare/workers-types", "TraceDiagnosticChannelEvent")>]
        type TraceDiagnosticChannelEvent =
            abstract message: option<obj> with get
            abstract channel: D1SessionBookmark with get
            abstract timestamp: float with get

        [<Import("@cloudflare/workers-types", "HelloWorldBinding")>]
        type HelloWorldBinding =
            abstract set: value: D1SessionBookmark -> Promise<unit>
            abstract get: unit -> Promise<HelloWorldBinding.Get>

        [<Import("@cloudflare/workers-types", "R2Bucket")>]
        type R2Bucket =
            abstract onlyIf: U2<R2Conditional, Headers> with get, set
            abstract ssecKey: option<U2<ArrayBuffer, string>> with get, set
            abstract range: option<U4<R2Bucket.Range, R2Bucket.Range, R2Bucket.Range, Headers>> with get, set
            abstract onlyIf: option<U2<R2Conditional, Headers>> with get, set
            abstract storageClass: option<D1SessionBookmark> with get, set
            abstract sha512: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, string>> with get, set
            abstract sha384: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, string>> with get, set
            abstract sha256: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, string>> with get, set
            abstract sha1: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, string>> with get, set
            abstract md5: option<U3<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, string>> with get, set
            abstract customMetadata: option<WebAssembly.ModuleImports> with get, set
            abstract httpMetadata: option<U2<R2HTTPMetadata, Headers>> with get, set
            abstract list: ?options: R2ListOptions -> Promise<R2Objects>
            abstract delete: keys: U2<Array<D1SessionBookmark>, string> -> Promise<unit>
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
                ?options: R2Bucket.Put.Options ->
                    Promise<option<R2Object>>

            abstract get: key: D1SessionBookmark * ?options: R2GetOptions -> Promise<option<R2ObjectBody>>

            abstract get:
                key: D1SessionBookmark * options: R2Bucket.Get.Options -> Promise<option<U2<R2Object, R2ObjectBody>>>

            abstract head: key: D1SessionBookmark -> Promise<option<R2Object>>

        type ReportError =
            abstract Invoke: ?error: obj -> unit
            abstract Invoke: ?e: obj -> unit

        [<Import("@cloudflare/workers-types", "HTMLRewriter"); AbstractClass; AllowNullLiteral>]
        type HTMLRewriter private () =
            [<EmitConstructor>]
            abstract Create: unit -> HTMLRewriter

            abstract transform: response: Typescript.Response -> Typescript.Response
            abstract onDocument: handlers: HTMLRewriterDocumentContentHandlers -> HTMLRewriter
            abstract on: selector: D1SessionBookmark * handlers: HTMLRewriterElementContentHandlers -> HTMLRewriter

        [<Import("@cloudflare/workers-types", "StreamVideoStatus")>]
        type StreamVideoStatus =
            abstract errorReasonText: D1SessionBookmark with get, set
            abstract errorReasonCode: D1SessionBookmark with get, set
            abstract pctComplete: option<D1SessionBookmark> with get, set
            abstract step: option<D1SessionBookmark> with get, set
            abstract state: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiAsyncBatchResponse")>]
        type AiAsyncBatchResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ContentOptions")>]
        type ContentOptions =
            abstract html: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItem"); AbstractClass; AllowNullLiteral>]
        type AiSearchItem private () =
            abstract chunks: ?params: AiSearchItemChunksParams -> Promise<AiSearchItemChunksResponse>
            abstract logs: ?params: AiSearchItemLogsParams -> Promise<AiSearchItemLogsResponse>
            abstract sync: unit -> Promise<AiSearchItemInfo>
            abstract download: unit -> Promise<AiSearchItemContentResult>
            abstract info: unit -> Promise<AiSearchItemInfo>

        [<Import("@cloudflare/workers-types", "AiSearchMultiSearchChunk")>]
        type AiSearchMultiSearchChunk =
            [<EmitProperty("instance_id")>]
            abstract instanceId: D1SessionBookmark with get, set

            [<EmitProperty("scoring_details")>]
            abstract scoringDetails: option<AiSearchMultiSearchChunk.ScoringDetails> with get, set

            abstract item: AiSearchMultiSearchChunk.Item with get, set
            abstract text: D1SessionBookmark with get, set
            abstract score: float with get, set

            [<EmitProperty("type")>]
            abstract ``type``: D1SessionBookmark with get, set

            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "SocketInfo")>]
        type SocketInfo =
            abstract localAddress: option<D1SessionBookmark> with get, set
            abstract remoteAddress: option<D1SessionBookmark> with get, set

        type EmailMessage =
            abstract prototype: EmailMessage with get, set

            [<EmitProperty("to")>]
            abstract ``to``: D1SessionBookmark with get

            abstract from: D1SessionBookmark with get

            abstract Create:
                from: D1SessionBookmark * ``to``: D1SessionBookmark * raw: U2<ReadableStream<option<obj>>, string> ->
                    EmailMessage

        [<Import("@cloudflare/workers-types", "TraceException")>]
        type TraceException =
            abstract stack: option<D1SessionBookmark> with get
            abstract name: D1SessionBookmark with get
            abstract message: D1SessionBookmark with get
            abstract timestamp: float with get

        [<Import("@cloudflare/workers-types", "ResponseFailedEvent")>]
        type ResponseFailedEvent =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseFailedEvent.Type with get, set

            [<EmitProperty("sequence_number")>]
            abstract sequenceNumber: float with get, set

            abstract response: Typescript.Response with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionToolChoiceAllowedTools")>]
        type ChatCompletionToolChoiceAllowedTools =
            [<EmitProperty("allowed_tools")>]
            abstract allowedTools: ChatCompletionToolChoiceAllowedTools.AllowedTools with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ChatCompletionToolChoiceAllowedTools.Type with get, set

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

        type VectorizeVectorMetadata =
            U5<VectorizeVectorMetadata, Array<D1SessionBookmark>, VectorizeVectorMetadata, string, float>

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfQwenQwen25Coder32BInstruct private () =
            abstract postProcessedOutputs: AiCfQwenQwen25Coder32BInstructOutput with get, set
            abstract inputs: AiCfQwenQwen25Coder32BInstructInput with get, set

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

        type ReadableStreamReadResult<'R> = U2<ReadableStreamReadResult, ReadableStreamReadResult>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionCustomToolGrammarFormat = | [<CompiledName("grammar")>] Grammar

        type Service =
            abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

            abstract fetch:
                input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                    Promise<Typescript.Response>

            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke: [<ParamArray>] args: Service.Invoke.Args -> U2<Service.Invoke, U2<Service.Invoke, unit>>

        [<Import("@cloudflare/workers-types", "ChatCompletionsStreamOptions")>]
        type ChatCompletionsStreamOptions =
            [<EmitProperty("include_obfuscation")>]
            abstract includeObfuscation: option<bool> with get, set

            [<EmitProperty("include_usage")>]
            abstract includeUsage: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "ContainerDirectorySnapshot")>]
        type ContainerDirectorySnapshot =
            abstract name: option<D1SessionBookmark> with get, set
            abstract dir: D1SessionBookmark with get, set
            abstract size: float with get, set
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_Embedding_0_6B_Input")>]
        type AiCfQwenQwen3Embedding06BInput =
            abstract text: option<U2<Array<D1SessionBookmark>, string>> with get, set
            abstract documents: option<U2<Array<D1SessionBookmark>, string>> with get, set
            abstract instruction: option<D1SessionBookmark> with get, set
            abstract queries: option<U2<Array<D1SessionBookmark>, string>> with get, set

        type QueueMicrotask =
            abstract Invoke: task: Function -> unit
            abstract Invoke: callback: VoidFunction -> unit

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfAisingaporeGemmaSeaLionV427BItJSONMode2 =
            | [<CompiledName("json_object")>] JsonObject
            | [<CompiledName("json_schema")>] JsonSchema

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

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseInputImageContent =
            | [<CompiledName("low")>] Low
            | [<CompiledName("high")>] High
            | [<CompiledName("auto")>] Auto
            | [<CompiledName("input_image")>] InputImage

        [<Import("@cloudflare/workers-types", "QueueSendBatchMetrics")>]
        type QueueSendBatchMetrics =
            abstract oldestMessageTimestamp: option<Date> with get, set
            abstract backlogBytes: float with get, set
            abstract backlogCount: float with get, set

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

        type R2Range = obj

        [<Import("@cloudflare/workers-types", "DurableObjectStub")>]
        type DurableObjectStub<'T when 'T :> Rpc.DurableObjectBranded> =
            abstract name: option<D1SessionBookmark> with get
            abstract id: DurableObjectId with get
            abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

            abstract fetch:
                input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                    Promise<Typescript.Response>

            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke:
                [<ParamArray>] args: DurableObjectStub.Invoke.Args ->
                    U2<DurableObjectStub.Invoke, U2<DurableObjectStub.Invoke, unit>>

        [<Import("@cloudflare/workers-types", "ResponseConversationParam")>]
        type ResponseConversationParam =
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_AsyncResponse")>]
        type AiCfQwenQwen330BA3BFp8AsyncResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "VectorizeVectorMetadataFilter")>]
        type VectorizeVectorMetadataFilter =
            abstract Item:
                key: D1SessionBookmark ->
                    option<
                        U5<
                            VectorizeVectorMetadataFilter.Item,
                            VectorizeVectorMetadataFilter.Item,
                            VectorizeVectorMetadataFilter.Item,
                            string,
                            float
                         >
                     >

        [<Import("@cloudflare/workers-types", "BaseAiSentenceSimilarity"); AbstractClass; AllowNullLiteral>]
        type BaseAiSentenceSimilarity private () =
            abstract postProcessedOutputs: AiSentenceSimilarityOutput with get, set
            abstract inputs: AiSentenceSimilarityInput with get, set

        type IncomingRequestCfPropertiesEdgeRequestKeepAliveStatus =
            | ``0`` = 0
            | ``1`` = 1
            | ``2`` = 2
            | ``3`` = 3
            | ``4`` = 4
            | ``5`` = 5

        type ResponseFunctionCallOutputItemList = obj

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Input_Embedding_1")>]
        type AiCfBaaiBgeM3InputEmbedding1 =
            [<EmitProperty("truncate_inputs")>]
            abstract truncateInputs: option<bool> with get, set

            abstract text: U2<Array<D1SessionBookmark>, string> with get, set

        type LoopbackForExport =
            abstract Invoke: opts: LoopbackForExport.Invoke.Opts -> LoopbackForExport.Invoke
            abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

            abstract fetch:
                input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                    Promise<Typescript.Response>

            abstract Invoke: opts: LoopbackForExport.Invoke.Opts -> DurableObjectClass<'T>
            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke:
                [<ParamArray>] args: LoopbackForExport.Invoke.Args ->
                    U2<LoopbackForExport.Invoke, U2<LoopbackForExport.Invoke, unit>>

        [<Import("@cloudflare/workers-types", "StreamVideoHandle")>]
        type StreamVideoHandle =
            abstract captions: StreamScopedCaptions with get, set
            abstract downloads: StreamScopedDownloads with get, set
            abstract id: D1SessionBookmark with get, set
            abstract generateToken: unit -> Promise<D1SessionBookmark>
            abstract delete: unit -> Promise<unit>
            abstract update: params: StreamUpdateVideoParams -> Promise<StreamVideo>
            abstract details: unit -> Promise<StreamVideo>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseReasoningTextDeltaEvent =
            | [<CompiledName("response.reasoning_text.delta")>] ResponseReasoningTextDelta

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionMessageFunctionToolCall = | [<CompiledName("function")>] Function

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfQwenQwen25Coder32BInstructJSONMode1 =
            | [<CompiledName("json_object")>] JsonObject
            | [<CompiledName("json_schema")>] JsonSchema

        type ResponseOutputItem = obj

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseTextDoneEvent = | [<CompiledName("response.output_text.done")>] ResponseOutputTextDone

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Black_Forest_Labs_Flux_2_Dev");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfBlackForestLabsFlux2Dev private () =
            abstract postProcessedOutputs: AiCfBlackForestLabsFlux2DevOutput with get, set
            abstract inputs: AiCfBlackForestLabsFlux2DevInput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B_Output")>]
        type AiCfAi4BharatIndictrans2EnIndic1BOutput =
            abstract translations: Array<D1SessionBookmark> with get, set

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

        [<Import("@cloudflare/workers-types", "WebSocketEventMap")>]
        type WebSocketEventMap =
            abstract error: ErrorEvent with get, set

            [<EmitProperty("open")>]
            abstract ``open``: Event with get, set

            abstract message: MessageEvent<option<obj>> with get, set
            abstract close: CloseEvent with get, set

        [<Import("@cloudflare/workers-types", "AiTranslationInput")>]
        type AiTranslationInput =
            [<EmitProperty("source_lang")>]
            abstract sourceLang: option<D1SessionBookmark> with get, set

            [<EmitProperty("target_lang")>]
            abstract targetLang: D1SessionBookmark with get, set

            abstract text: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiSearchJobLog")>]
        type AiSearchJobLog =
            [<EmitProperty("created_at")>]
            abstract createdAt: float with get, set

            [<EmitProperty("message_type")>]
            abstract messageType: float with get, set

            abstract message: D1SessionBookmark with get, set
            abstract id: float with get, set

        type AiCfAisingaporeGemmaSeaLionV427BItInput = obj

        [<Import("@cloudflare/workers-types", "WorkerGlobalScopeEventMap")>]
        type WorkerGlobalScopeEventMap =
            abstract rejectionhandled: PromiseRejectionEvent with get, set
            abstract unhandledrejection: PromiseRejectionEvent with get, set
            abstract queue: QueueEvent<option<obj>> with get, set
            abstract scheduled: ScheduledEvent with get, set
            abstract fetch: FetchEvent with get, set

        [<Import("@cloudflare/workers-types", "EmailSendResult")>]
        type EmailSendResult =
            abstract messageId: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionsCommonOptions")>]
        type ChatCompletionsCommonOptions =
            abstract functions: option<Array<FunctionDefinition>> with get, set

            [<EmitProperty("function_call")>]
            abstract functionCall:
                option<U2<ChatCompletionsCommonOptions.FunctionCall, ChatCompletionsCommonOptions.FunctionCall>> with get, set

            [<EmitProperty("web_search_options")>]
            abstract webSearchOptions: option<WebSearchOptions> with get, set

            abstract user: option<D1SessionBookmark> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract tools: option<Array<ChatCompletionTool>> with get, set

            [<EmitProperty("tool_choice")>]
            abstract toolChoice: option<ChatCompletionToolChoiceOption> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("stream_options")>]
            abstract streamOptions: option<ChatCompletionsStreamOptions> with get, set

            abstract stream: option<bool> with get, set
            abstract store: option<bool> with get, set
            abstract stop: option<U2<Array<D1SessionBookmark>, string>> with get, set

            [<EmitProperty("service_tier")>]
            abstract serviceTier: option<ChatCompletionsCommonOptions.ServiceTier> with get, set

            abstract seed: option<float> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<ResponseFormat> with get, set

            [<EmitProperty("chat_template_kwargs")>]
            abstract chatTemplateKwargs: option<ChatTemplateKwargs> with get, set

            [<EmitProperty("reasoning_effort")>]
            abstract reasoningEffort: option<ChatCompletionsCommonOptions.ReasoningEffort> with get, set

            [<EmitProperty("presence_penalty")>]
            abstract presencePenalty: option<float> with get, set

            abstract prediction: option<PredictionContent> with get, set

            [<EmitProperty("parallel_tool_calls")>]
            abstract parallelToolCalls: option<bool> with get, set

            abstract n: option<float> with get, set
            abstract modalities: option<Array<ChatCompletionsCommonOptions.Modalities>> with get, set
            abstract metadata: option<ChatCompletionsCommonOptions.Metadata> with get, set

            [<EmitProperty("max_completion_tokens")>]
            abstract maxCompletionTokens: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            [<EmitProperty("top_logprobs")>]
            abstract topLogprobs: option<float> with get, set

            abstract logprobs: option<bool> with get, set

            [<EmitProperty("logit_bias")>]
            abstract logitBias: option<ChatCompletionsCommonOptions.LogitBias> with get, set

            [<EmitProperty("frequency_penalty")>]
            abstract frequencyPenalty: option<float> with get, set

            abstract audio: option<AudioParams> with get, set
            abstract model: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "RateLimit")>]
        type RateLimit =
            abstract limit: options: RateLimitOptions -> Promise<RateLimitOutcome>

        [<Import("@cloudflare/workers-types", "ResponseFormatJSONSchema")>]
        type ResponseFormatJSONSchema =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: ResponseFormatJSONSchema.JsonSchema with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ResponseFormatJSONSchema.Type with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfDeepgramAura2EnInput =
            | [<CompiledName("none")>] None
            | [<CompiledName("wav")>] Wav
            | [<CompiledName("ogg")>] Ogg
            | [<CompiledName("linear16")>] Linear16
            | [<CompiledName("flac")>] Flac
            | [<CompiledName("mulaw")>] Mulaw
            | [<CompiledName("alaw")>] Alaw
            | [<CompiledName("mp3")>] Mp3
            | [<CompiledName("opus")>] Opus
            | [<CompiledName("aac")>] Aac
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

        [<Import("@cloudflare/workers-types", "QueueSendBatchResponse")>]
        type QueueSendBatchResponse =
            abstract metadata: QueueSendBatchMetadata with get, set

        [<Import("@cloudflare/workers-types", "ChatCompletionContentPartImage")>]
        type ChatCompletionContentPartImage =
            [<EmitProperty("image_url")>]
            abstract imageUrl: ChatCompletionContentPartImage.ImageUrl with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ChatCompletionContentPartImage.Type with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Output_Query")>]
        type AiCfBaaiBgeM3OutputQuery =
            abstract response: option<Array<AiCfBaaiBgeM3OutputQuery.Response>> with get, set

        [<Import("@cloudflare/workers-types", "DynamicDispatchLimits")>]
        type DynamicDispatchLimits =
            abstract subRequests: option<float> with get, set
            abstract cpuMs: option<float> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfQwenQwen330BA3BFp8 private () =
            abstract postProcessedOutputs: AiCfQwenQwen330BA3BFp8Output with get, set
            abstract inputs: AiCfQwenQwen330BA3BFp8Input with get, set

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

        [<Import("@cloudflare/workers-types", "ExtendableEvent"); AbstractClass; AllowNullLiteral>]
        type ExtendableEvent private () =
            inherit Event()
            abstract waitUntil: promise: Promise<option<obj>> -> unit

        [<Import("@cloudflare/workers-types", "LoopbackDurableObjectClass")>]
        type LoopbackDurableObjectClass<'T when 'T :> Rpc.DurableObjectBranded> =
            abstract Invoke: opts: LoopbackDurableObjectClass.Invoke.Opts -> DurableObjectClass<'T>
            abstract Invoke: opts: LoopbackDurableObjectClass.Invoke.Opts -> DurableObjectClass<'T>

        type AiCfAisingaporeGemmaSeaLionV427BItOutput =
            U4<
                AiCfAisingaporeGemmaSeaLionV427BItChatCompletionResponse,
                AiCfAisingaporeGemmaSeaLionV427BItTextCompletionResponse,
                AiCfAisingaporeGemmaSeaLionV427BItAsyncResponse,
                string
             >

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseOutputRefusal = | [<CompiledName("refusal")>] Refusal

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseErrorEvent = | [<CompiledName("error")>] Error

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type FunctionMessage = | [<CompiledName("function")>] Function

        [<Import("@cloudflare/workers-types", "AiImageTextToTextOutput")>]
        type AiImageTextToTextOutput =
            abstract description: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiSearchUploadItemOptions")>]
        type AiSearchUploadItemOptions =
            abstract metadata: option<WebAssembly.ModuleImports> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseIncludable =
            | [<CompiledName("message.input_image.image_url")>] MessageInputImageImageUrl
            | [<CompiledName("message.output_text.logprobs")>] MessageOutputTextLogprobs

        [<Import("@cloudflare/workers-types", "ResponseReasoningTextDoneEvent")>]
        type ResponseReasoningTextDoneEvent =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseReasoningTextDoneEvent.Type with get, set

            abstract text: D1SessionBookmark with get, set

            [<EmitProperty("sequence_number")>]
            abstract sequenceNumber: float with get, set

            [<EmitProperty("output_index")>]
            abstract outputIndex: float with get, set

            [<EmitProperty("item_id")>]
            abstract itemId: D1SessionBookmark with get, set

            [<EmitProperty("content_index")>]
            abstract contentIndex: float with get, set

        type ChatCompletionMessageToolCall = obj

        [<Import("@cloudflare/workers-types", "StreamDirectUpload")>]
        type StreamDirectUpload =
            abstract scheduledDeletion: option<string> with get, set
            abstract watermark: option<StreamDirectUpload.Watermark> with get, set
            abstract id: D1SessionBookmark with get, set
            abstract uploadURL: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionContentPartText = | [<CompiledName("text")>] Text

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

        [<Import("@cloudflare/workers-types", "ResponsesFunctionTool")>]
        type Tool =
            abstract description: option<string> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: Tool.Type with get, set

            abstract strict: option<bool> with get, set
            abstract parameters: option<Tool.Parameters> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ResponseFormatText")>]
        type ResponseFormatText =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseFormatText.Type with get, set

        [<Import("@cloudflare/workers-types", "AlreadyUploadedError")>]
        type AlreadyUploadedError =
            inherit StreamError
            abstract name: AlreadyUploadedError.Name with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AssistantMessage = | [<CompiledName("assistant")>] Assistant

        type XOR =
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "FetchEvent"); AbstractClass; AllowNullLiteral>]
        type FetchEvent private () =
            inherit ExtendableEvent()
            abstract request: Typescript.Request with get
            abstract passThroughOnException: unit -> unit
            abstract respondWith: promise: U2<Typescript.Response, Promise<Typescript.Response>> -> unit

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type InstanceStatus =
            | [<CompiledName("queued")>] Queued
            | [<CompiledName("running")>] Running
            | [<CompiledName("paused")>] Paused
            | [<CompiledName("errored")>] Errored
            | [<CompiledName("terminated")>] Terminated
            | [<CompiledName("complete")>] Complete
            | [<CompiledName("waiting")>] Waiting
            | [<CompiledName("waitingForPause")>] WaitingForPause
            | [<CompiledName("unknown")>] Unknown

        [<Import("@cloudflare/workers-types", "ExportedHandlerFetchHandler")>]
        type ExportedHandlerFetchHandler<'Props, 'CfHostMetadata, 'Env> =
            abstract Invoke:
                request: Typescript.Request * env: 'Env * ctx: ExecutionContext<'Props> ->
                    U2<Typescript.Response, Promise<Typescript.Response>>

        [<Import("@cloudflare/workers-types", "BasicImageTransformationsGravityCoordinates")>]
        type BasicImageTransformationsGravityCoordinates =
            abstract mode: option<BasicImageTransformationsGravityCoordinates.Mode> with get, set
            abstract y: option<float> with get, set
            abstract x: option<float> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Meta_Llama_Guard_3_8B_Input")>]
        type AiCfMetaLlamaGuard38BInput =
            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiCfMetaLlamaGuard38BInput.ResponseFormat> with get, set

            abstract temperature: option<float> with get, set

            [<EmitProperty("max_tokens")>]
            abstract maxTokens: option<float> with get, set

            abstract messages: Array<AiCfMetaLlamaGuard38BInput.Messages> with get, set

        [<Import("@cloudflare/workers-types", "D1Result")>]
        type D1Result<'T> =
            abstract results: Array<'T> with get, set
            abstract error: option<unit> with get, set
            abstract meta: D1Result.Meta with get, set
            abstract success: D1Result.Success with get, set

        [<Import("@cloudflare/workers-types", "RateLimitOutcome")>]
        type RateLimitOutcome =
            abstract success: bool with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionToolChoiceOption =
            | [<CompiledName("none")>] None
            | [<CompiledName("auto")>] Auto
            | [<CompiledName("required")>] Required

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_1")>]
        type AiCfAisingaporeGemmaSeaLionV427BItJSONMode1 =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiCfAisingaporeGemmaSeaLionV427BItJSONMode1.Type> with get, set

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

        [<Import("@cloudflare/workers-types", "AnalyticsEngineDataset")>]
        type AnalyticsEngineDataset =
            abstract writeDataPoint: ?event: AnalyticsEngineDataPoint -> unit

        [<Import("@cloudflare/workers-types", "ResponseFunctionToolCallItem")>]
        type ResponseFunctionToolCallItem =
            inherit ResponseFunctionToolCall
            abstract id: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "CountQueuingStrategy"); AbstractClass; AllowNullLiteral>]
        type CountQueuingStrategy private () =
            inherit Typescript.QueuingStrategy<option<obj>>()

            [<EmitConstructor>]
            abstract Create: init: Typescript.QueuingStrategyInit -> CountQueuingStrategy

            abstract highWaterMark: float with get
            abstract size: ?chunk: obj -> float

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseInputItemFunctionCallOutput =
            | [<CompiledName("in_progress")>] InProgress
            | [<CompiledName("completed")>] Completed
            | [<CompiledName("incomplete")>] Incomplete
            | [<CompiledName("function_call_output")>] FunctionCallOutput

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

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Qwen_Qwen3_Embedding_0_6B"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfQwenQwen3Embedding06B private () =
            abstract postProcessedOutputs: AiCfQwenQwen3Embedding06BOutput with get, set
            abstract inputs: AiCfQwenQwen3Embedding06BInput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Baai_Bge_M3_Input_QueryAnd_Contexts_1")>]
        type AiCfBaaiBgeM3InputQueryAndContexts1 =
            [<EmitProperty("truncate_inputs")>]
            abstract truncateInputs: option<bool> with get, set

            abstract contexts: Array<AiCfBaaiBgeM3InputQueryAndContexts1.Contexts> with get, set
            abstract query: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "CryptoKeyAesKeyAlgorithm")>]
        type CryptoKeyAesKeyAlgorithm =
            abstract length: float with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "TraceMetrics")>]
        type TraceMetrics =
            abstract wallTime: float with get
            abstract cpuTime: float with get

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

        type WorkflowRetentionDuration = obj

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfBaaiBgeM3OutputEmbedding =
            | [<CompiledName("mean")>] Mean
            | [<CompiledName("cls")>] Cls

        [<Import("@cloudflare/workers-types", "TraceItemHibernatableWebSocketEventInfoMessage")>]
        type TraceItemHibernatableWebSocketEventInfoMessage =
            abstract webSocketEventType: D1SessionBookmark with get

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type VectorizeMetadataRetrievalLevel =
            | [<CompiledName("all")>] All
            | [<CompiledName("indexed")>] Indexed
            | [<CompiledName("none")>] None

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type Socket =
            | [<CompiledName("on")>] On
            | [<CompiledName("off")>] Off
            | [<CompiledName("starttls")>] Starttls

        [<Import("@cloudflare/workers-types", "DurableObjectGetAlarmOptions")>]
        type DurableObjectGetAlarmOptions =
            abstract allowConcurrency: option<bool> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfQwenQwen330BA3BFp8ChatCompletionResponse = | [<CompiledName("chat.completion")>] ChatCompletion

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type QuotaReachedError = | QuotaReachedError

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfAisingaporeGemmaSeaLionV427BIt private () =
            abstract postProcessedOutputs: AiCfAisingaporeGemmaSeaLionV427BItOutput with get, set
            abstract inputs: AiCfAisingaporeGemmaSeaLionV427BItInput with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Openai_Whisper_Large_V3_Turbo");
          AbstractClass;
          AllowNullLiteral>]
        type BaseAiCfOpenaiWhisperLargeV3Turbo private () =
            abstract postProcessedOutputs: AiCfOpenaiWhisperLargeV3TurboOutput with get, set
            abstract inputs: AiCfOpenaiWhisperLargeV3TurboInput with get, set

        [<Import("@cloudflare/workers-types", "TraceItemJsRpcEventInfo")>]
        type TraceItemJsRpcEventInfo =
            abstract rpcMethod: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "D1Meta")>]
        type D1Meta =
            [<EmitProperty("total_attempts")>]
            abstract totalAttempts: option<float> with get, set

            abstract timings: option<D1Meta.Timings> with get, set

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

        [<Import("@cloudflare/workers-types", "EventTarget"); AbstractClass; AllowNullLiteral>]
        type EventTarget<'EventMap when 'EventMap :> WebAssembly.ModuleImports> private () =
            [<EmitConstructor>]
            abstract Create: unit -> EventTarget

            abstract dispatchEvent: event: proptypekey<'EventMap, keyof<'EventMap>> -> bool

            abstract removeEventListener:
                ``type``: 'Type * handler: Typescript.Body * ?options: U2<EventTargetEventListenerOptions, bool> -> unit

            abstract addEventListener:
                ``type``: 'Type * handler: Typescript.Body * ?options: U2<EventTargetAddEventListenerOptions, bool> ->
                    unit

        [<Import("@cloudflare/workers-types", "AiSearchInstance"); AbstractClass; AllowNullLiteral>]
        type AiSearchInstance private () =
            abstract jobs: AiSearchJobs with get
            abstract items: AiSearchItems with get
            abstract stream: AiSearchInstance.Stream with get, set

            [<EmitProperty("ai_search_options")>]
            abstract aiSearchOptions: option<AiSearchOptions> with get, set

            abstract stream: option<bool> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract messages: Array<AiSearchMessage> with get, set
            abstract stats: unit -> Promise<AiSearchStatsResponse>
            abstract info: unit -> Promise<AiSearchInstanceInfo>
            abstract update: config: AiSearchInstance.Update.Config -> Promise<AiSearchInstanceInfo>
            abstract chatCompletions: params: AiSearchChatCompletionsRequest -> Promise<AiSearchChatCompletionsResponse>
            abstract chatCompletions: params: AiSearchInstance.ChatCompletions.Params -> Promise<AiTextToImageOutput>
            abstract search: params: AiSearchSearchRequest -> Promise<AiSearchSearchResponse>
            abstract Item: key: D1SessionBookmark -> option<obj>

        [<Import("@cloudflare/workers-types", "UserMessage")>]
        type UserMessage =
            abstract name: option<D1SessionBookmark> with get, set
            abstract content: U2<Array<UserMessageContentPart>, string> with get, set
            abstract role: UserMessage.Role with get, set

        [<Import("@cloudflare/workers-types", "KVNamespaceGetWithMetadataResult")>]
        type KVNamespaceGetWithMetadataResult<'Metadata, 'Value> =
            abstract cacheStatus: option<string> with get, set
            abstract metadata: option<'Metadata> with get, set
            abstract value: option<'Value> with get, set

        [<Import("@cloudflare/workers-types", "Workflow"); AbstractClass; AllowNullLiteral>]
        type Workflow<'PARAMS> private () =
            abstract createBatch:
                batch: Array<WorkflowInstanceCreateOptions<'PARAMS>> -> Promise<Array<WorkflowInstance>>

            abstract create: ?options: WorkflowInstanceCreateOptions<'PARAMS> -> Promise<WorkflowInstance>
            abstract get: id: D1SessionBookmark -> Promise<WorkflowInstance>

        type WorkerStub =
            abstract connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

            abstract fetch:
                input: U3<Typescript.Request, URL, string> * ?init: Typescript.RequestInit ->
                    Promise<Typescript.Response>

            abstract Item: key: D1SessionBookmark -> option<obj>
            abstract catch: ?onrejected: option<obj> -> U2<'TResult, PromiseLike<'TResult>> -> Promise<U2<'T, 'TResult>>

            abstract ``then``:
                ?onfulfilled: 'T -> U2<'TResult1, PromiseLike<'TResult1>> *
                ?onrejected: option<obj> -> U2<'TResult2, PromiseLike<'TResult2>> ->
                    Promise<U2<'TResult1, 'TResult2>>

            abstract Invoke:
                [<ParamArray>] args: WorkerStub.Invoke.Args -> U2<WorkerStub.Invoke, U2<WorkerStub.Invoke, unit>>

            abstract getDurableObjectClass:
                ?name: D1SessionBookmark * ?options: WorkerStubEntrypointOptions -> DurableObjectClass<'T>

            abstract getEntrypoint:
                ?name: D1SessionBookmark * ?options: WorkerStubEntrypointOptions -> WorkerStub.GetEntrypoint

        type ChatCompletionMessageParam = obj

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Unum_Uform_Gen2_Qwen_500M"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfUnumUformGen2Qwen500M private () =
            abstract postProcessedOutputs: AiCfUnumUformGen2Qwen500MOutput with get, set
            abstract inputs: AiCfUnumUformGen2Qwen500MInput with get, set

        [<Import("@cloudflare/workers-types", "LoopbackDurableObjectNamespace"); AbstractClass; AllowNullLiteral>]
        type LoopbackDurableObjectNamespace private () =
            inherit DurableObjectNamespace<unit>()

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseContent = | [<CompiledName("reasoning_text")>] ReasoningText

        [<Import("@cloudflare/workers-types", "TraceItemEmailEventInfo")>]
        type TraceItemEmailEventInfo =
            abstract rawSize: float with get
            abstract rcptTo: D1SessionBookmark with get
            abstract mailFrom: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "AiSearchChatCompletionsRequest")>]
        type AiSearchChatCompletionsRequest =
            [<EmitProperty("ai_search_options")>]
            abstract aiSearchOptions: option<AiSearchOptions> with get, set

            abstract stream: option<bool> with get, set
            abstract model: option<D1SessionBookmark> with get, set
            abstract messages: Array<AiSearchMessage> with get, set
            abstract Item: key: D1SessionBookmark -> option<obj>

        type SetInterval =
            abstract Invoke:
                callback: SetInterval.Invoke.Callback * ?msDelay: float * [<ParamArray>] args: 'Args -> float

            abstract Invoke: callback: SetInterval.Invoke.Callback * ?msDelay: float -> float

            abstract Invoke:
                handler: TimerHandler * ?timeout: float * [<ParamArray>] arguments: Array<option<obj>> -> float

        [<Import("@cloudflare/workers-types", "MessageBatchMetrics")>]
        type MessageBatchMetrics =
            abstract oldestMessageTimestamp: option<Date> with get, set
            abstract backlogBytes: float with get, set
            abstract backlogCount: float with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiTextGenerationToolOutput = | [<CompiledName("function")>] Function

        [<Import("@cloudflare/workers-types", "FunctionDefinition")>]
        type FunctionDefinition =
            abstract strict: option<bool> with get, set
            abstract parameters: option<WebAssembly.ModuleImports> with get, set
            abstract description: option<D1SessionBookmark> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Artifacts")>]
        type Artifacts =
            abstract delete: name: D1SessionBookmark -> Promise<bool>
            abstract list: ?opts: AiSearchItemLogsParams -> Promise<ArtifactsRepoListResult>
            abstract import: params: Artifacts.Import.Params -> Promise<ArtifactsCreateRepoResult>
            abstract get: name: D1SessionBookmark -> Promise<ArtifactsRepo>

            abstract create:
                name: D1SessionBookmark * ?opts: Artifacts.Create.Opts -> Promise<ArtifactsCreateRepoResult>

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

        [<Import("@cloudflare/workers-types", "Crypto"); AbstractClass; AllowNullLiteral>]
        type Crypto private () =
            [<EmitProperty("DigestStream")>]
            abstract digestStream: Crypto.DigestStream with get, set

            abstract subtle: SubtleCrypto with get
            abstract randomUUID: unit -> D1SessionBookmark
            abstract getRandomValues: buffer: 'T -> 'T

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
                    Promise<KVNamespaceGetWithMetadataResult<AiTextToImageOutput, 'Metadata>>

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
                    Promise<KVNamespaceGetWithMetadataResult<AiTextToImageOutput, 'Metadata>>

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
                value: U4<ArrayBuffer, ArrayBufferView<ArrayBufferLike>, ReadableStream<option<obj>>, string> *
                ?options: KVNamespacePutOptions ->
                    Promise<unit>

            abstract list: ?options: KVNamespaceListOptions -> Promise<U2<KVNamespace.List, KVNamespace.List>>

            abstract get:
                key: Array<'Key> * ?options: KVNamespaceGetOptions<KVNamespace.Get.Options> ->
                    Promise<Map<D1SessionBookmark, option<'ExpectedValue>>>

            abstract get:
                key: Array<'Key> * ?options: KVNamespaceGetOptions<KVNamespace.Get.Options> ->
                    Promise<Map<D1SessionBookmark, option<string>>>

            abstract get:
                key: Array<'Key> * ?options: KVNamespace.Get.Options -> Promise<Map<D1SessionBookmark, option<string>>>

            abstract get:
                key: Array<'Key> * ``type``: KVNamespace.Get.Type ->
                    Promise<Map<D1SessionBookmark, option<'ExpectedValue>>>

            abstract get:
                key: Array<'Key> * ``type``: KVNamespace.Get.Type -> Promise<Map<D1SessionBookmark, option<string>>>

            abstract get:
                key: 'Key * ?options: KVNamespaceGetOptions<KVNamespace.Get.Options> ->
                    Promise<option<ReadableStream<option<obj>>>>

            abstract get:
                key: 'Key * ?options: KVNamespaceGetOptions<KVNamespace.Get.Options> -> Promise<option<ArrayBuffer>>

            abstract get:
                key: 'Key * ?options: KVNamespaceGetOptions<KVNamespace.Get.Options> -> Promise<option<'ExpectedValue>>

            abstract get:
                key: 'Key * ?options: KVNamespaceGetOptions<KVNamespace.Get.Options> -> Promise<option<string>>

            abstract get: key: 'Key * ``type``: KVNamespace.Get.Type -> Promise<option<ReadableStream<option<obj>>>>
            abstract get: key: 'Key * ``type``: KVNamespace.Get.Type -> Promise<option<ArrayBuffer>>
            abstract get: key: 'Key * ``type``: KVNamespace.Get.Type -> Promise<option<'ExpectedValue>>
            abstract get: key: 'Key * ``type``: KVNamespace.Get.Type -> Promise<option<string>>
            abstract get: key: 'Key * ?options: KVNamespace.Get.Options -> Promise<option<string>>

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

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Output")>]
        type AiCfQwenQwen25Coder32BInstructOutput =
            [<EmitProperty("tool_calls")>]
            abstract toolCalls: option<Array<AiCfQwenQwen25Coder32BInstructOutput.ToolCalls>> with get, set

            abstract usage: option<AiCfQwenQwen25Coder32BInstructOutput.Usage> with get, set
            abstract response: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Deepgram_Nova_3_Output")>]
        type AiCfDeepgramNova3Output =
            abstract results: option<AiCfDeepgramNova3Output.Results> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiSearchItemInfo =
            | INDEX
            | DELETE
            | [<CompiledName("completed")>] Completed
            | [<CompiledName("error")>] Error
            | [<CompiledName("skipped")>] Skipped
            | [<CompiledName("queued")>] Queued
            | [<CompiledName("running")>] Running
            | [<CompiledName("outdated")>] Outdated

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type DurableObjectNamespaceGetDurableObjectOptions =
            | [<CompiledName("primary-only")>] PrimaryOnly
            | [<CompiledName("wnam")>] Wnam
            | [<CompiledName("enam")>] Enam
            | [<CompiledName("sam")>] Sam
            | [<CompiledName("weur")>] Weur
            | [<CompiledName("eeur")>] Eeur
            | [<CompiledName("apac")>] Apac
            | [<CompiledName("oc")>] Oc
            | [<CompiledName("afr")>] Afr
            | [<CompiledName("me")>] Me

        [<Import("@cloudflare/workers-types", "WebSocketRequestResponsePair"); AbstractClass; AllowNullLiteral>]
        type WebSocketRequestResponsePair private () =
            [<EmitConstructor>]
            abstract Create: request: D1SessionBookmark * response: D1SessionBookmark -> WebSocketRequestResponsePair

            abstract response: D1SessionBookmark with get
            abstract request: D1SessionBookmark with get

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

        [<Import("@cloudflare/workers-types", "ResponseInputImage")>]
        type ResponseInputImage =
            [<EmitProperty("image_url")>]
            abstract imageUrl: option<string> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ResponseInputImage.Type with get, set

            abstract detail: ResponseInputImage.Detail with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode")>]
        type AiCfQwenQwen330BA3BFp8JSONMode =
            [<EmitProperty("json_schema")>]
            abstract jsonSchema: option<obj> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: option<AiCfQwenQwen330BA3BFp8JSONMode.Type> with get, set

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
            abstract put: entries: WebAssembly.ModuleImports * ?options: DurableObjectPutOptions -> Promise<unit>
            abstract put: key: D1SessionBookmark * value: 'T * ?options: DurableObjectPutOptions -> Promise<unit>
            abstract list: ?options: DurableObjectListOptions -> Promise<Map<D1SessionBookmark, 'T>>

            abstract get:
                keys: Array<D1SessionBookmark> * ?options: DurableObjectGetOptions ->
                    Promise<Map<D1SessionBookmark, 'T>>

            abstract get: key: D1SessionBookmark * ?options: DurableObjectGetOptions -> Promise<option<'T>>

        [<Import("@cloudflare/workers-types", "QueueMetrics")>]
        type QueueMetrics =
            abstract oldestMessageTimestamp: option<Date> with get, set
            abstract backlogBytes: float with get, set
            abstract backlogCount: float with get, set

        [<Import("@cloudflare/workers-types", "ImagesBinding")>]
        type ImagesBinding =
            abstract hosted: HostedImagesBinding with get

            abstract input:
                stream: ReadableStream<Uint8Array<ArrayBufferLike>> * ?options: ImageInputOptions -> ImageTransformer

            abstract info:
                stream: ReadableStream<Uint8Array<ArrayBufferLike>> * ?options: ImageInputOptions ->
                    Promise<ImageInfoResponse>

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRAGUnauthorizedError"); AbstractClass; AllowNullLiteral>]
        type AutoRAGUnauthorizedError private () =
            inherit exn()

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

        [<Import("@cloudflare/workers-types", "ChatCompletionCustomTool")>]
        type ChatCompletionCustomTool =
            abstract custom: ChatCompletionCustomTool.Custom with get, set

            [<EmitProperty("type")>]
            abstract ``type``: ChatCompletionCustomTool.Type with get, set

        [<Import("@cloudflare/workers-types", "ResponsesInput")>]
        type ResponsesInput =
            abstract truncation: option<ResponsesInput.Truncation> with get, set

            [<EmitProperty("top_p")>]
            abstract topP: option<float> with get, set

            abstract tools: option<Array<Tool>> with get, set

            [<EmitProperty("tool_choice")>]
            abstract toolChoice: option<U2<ResponsesInput.ToolChoice, ResponsesInput.ToolChoice>> with get, set

            abstract text: option<ResponseTextConfig> with get, set
            abstract temperature: option<float> with get, set

            [<EmitProperty("stream_options")>]
            abstract streamOptions: option<ResponsesInput.StreamOptions> with get, set

            abstract stream: option<bool> with get, set

            [<EmitProperty("service_tier")>]
            abstract serviceTier: option<ResponsesInput.ServiceTier> with get, set

            [<EmitProperty("safety_identifier")>]
            abstract safetyIdentifier: option<D1SessionBookmark> with get, set

            abstract reasoning: option<ResponsesInput.Reasoning> with get, set

            [<EmitProperty("prompt_cache_key")>]
            abstract promptCacheKey: option<D1SessionBookmark> with get, set

            [<EmitProperty("previous_response_id")>]
            abstract previousResponseId: option<string> with get, set

            [<EmitProperty("parallel_tool_calls")>]
            abstract parallelToolCalls: option<bool> with get, set

            [<EmitProperty("max_output_tokens")>]
            abstract maxOutputTokens: option<float> with get, set

            abstract instructions: option<string> with get, set
            abstract input: option<U2<Array<'T>, string>> with get, set
            abstract include: option<Array<ResponseIncludable>> with get, set
            abstract conversation: option<U2<ResponsesInput.Conversation, string>> with get, set
            abstract background: option<bool> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ContinentCode =
            | AF
            | AN
            | AS
            | EU
            | NA
            | OC
            | SA

        [<Import("@cloudflare/workers-types", "UserMessageContentPart")>]
        type UserMessageContentPart =
            abstract file: option<UserMessageContentPart.File> with get, set

            [<EmitProperty("input_audio")>]
            abstract inputAudio: option<UserMessageContentPart.InputAudio> with get, set

            [<EmitProperty("image_url")>]
            abstract imageUrl: option<UserMessageContentPart.ImageUrl> with get, set

            abstract text: option<D1SessionBookmark> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: UserMessageContentPart.Type with get, set

        [<Import("@cloudflare/workers-types", "EmailEvent"); AbstractClass; AllowNullLiteral>]
        type EmailEvent private () =
            inherit ExtendableEvent()
            abstract message: ForwardableEmailMessage with get

        [<Import("@cloudflare/workers-types", "StreamUpdateVideoParams")>]
        type StreamUpdateVideoParams =
            abstract thumbnailTimestampPct: option<float> with get, set
            abstract scheduledDeletion: option<string> with get, set
            abstract requireSignedURLs: option<bool> with get, set
            abstract meta: option<WebAssembly.ModuleImports> with get, set
            abstract maxDurationSeconds: option<float> with get, set
            abstract creator: option<D1SessionBookmark> with get, set
            abstract allowedOrigins: option<Array<D1SessionBookmark>> with get, set

        [<Import("@cloudflare/workers-types", "SubtleCryptoSignAlgorithm")>]
        type SubtleCryptoSignAlgorithm =
            abstract saltLength: option<float> with get, set
            abstract dataLength: option<float> with get, set
            abstract hash: option<U2<SubtleCryptoHashAlgorithm, string>> with get, set
            abstract name: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiSearchCreateJobParams")>]
        type AiSearchCreateJobParams =
            abstract description: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "RequestInitCfPropertiesR2")>]
        type RequestInitCfPropertiesR2 =
            abstract bucketColoId: option<float> with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_1_Schnell_Output")>]
        type AiCfBlackForestLabsFlux1SchnellOutput =
            abstract image: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "CryptoKeyArbitraryKeyAlgorithm")>]
        type CryptoKeyArbitraryKeyAlgorithm =
            abstract length: option<float> with get, set
            abstract namedCurve: option<D1SessionBookmark> with get, set
            abstract hash: option<CryptoKeyKeyAlgorithm> with get, set
            abstract name: D1SessionBookmark with get, set

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

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ArtifactsTokenInfo =
            | [<CompiledName("read")>] Read
            | [<CompiledName("write")>] Write
            | [<CompiledName("active")>] Active
            | [<CompiledName("expired")>] Expired
            | [<CompiledName("revoked")>] Revoked

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Moonshotai_Kimi_K2_5"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfMoonshotaiKimiK25 private () =
            abstract postProcessedOutputs: ChatCompletionsOutput with get, set
            abstract inputs: ChatCompletionsInput with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Google_Gemma_3_12B_It_Output")>]
        type AiCfGoogleGemma312BItOutput =
            [<EmitProperty("tool_calls")>]
            abstract toolCalls: option<Array<AiCfGoogleGemma312BItOutput.ToolCalls>> with get, set

            abstract usage: option<AiCfGoogleGemma312BItOutput.Usage> with get, set
            abstract response: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "AiTextGenerationInput")>]
        type AiTextGenerationInput =
            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract tools: option<U3<Array<AiTextGenerationToolInput>, Array<AiTextGenerationToolLegacyInput>, obj>> with get, set

            [<EmitProperty("response_format")>]
            abstract responseFormat: option<AiTextGenerationResponseFormat> with get, set

            abstract messages: option<Array<RoleScopedChatInput>> with get, set

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

        [<Import("@cloudflare/workers-types", "R2Error"); AbstractClass; AllowNullLiteral>]
        type R2Error private () =
            inherit exn()
            abstract stack: option<obj> with get
            abstract action: D1SessionBookmark with get
            abstract message: D1SessionBookmark with get
            abstract code: float with get
            abstract name: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "TextDecoder"); AbstractClass; AllowNullLiteral>]
        type TextDecoder private () =
            [<EmitConstructor>]
            abstract Create: ?label: D1SessionBookmark * ?options: TextDecoderConstructorOptions -> TextDecoder

            abstract ignoreBOM: bool with get
            abstract fatal: bool with get
            abstract encoding: D1SessionBookmark with get
            abstract decode: ?input: BufferSource * ?options: TextDecoderDecodeOptions -> D1SessionBookmark

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Pipecat_Ai_Smart_Turn_V2"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfPipecatAiSmartTurnV2 private () =
            abstract postProcessedOutputs: AiCfPipecatAiSmartTurnV2Output with get, set
            abstract inputs: AiCfPipecatAiSmartTurnV2Input with get, set

        [<Import("@cloudflare/workers-types", "InternalError")>]
        type InternalError =
            inherit StreamError
            abstract name: InternalError.Name with get, set

        [<Import("@cloudflare/workers-types", "Ai_Cf_Qwen_Qwq_32B_Output")>]
        type AiCfQwenQwq32BOutput =
            [<EmitProperty("tool_calls")>]
            abstract toolCalls: option<Array<AiCfQwenQwq32BOutput.ToolCalls>> with get, set

            abstract usage: option<AiCfQwenQwq32BOutput.Usage> with get, set
            abstract response: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Baai_Bge_Large_En_V1_5"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfBaaiBgeLargeEnV15 private () =
            abstract postProcessedOutputs: AiCfBaaiBgeLargeEnV15Output with get, set
            abstract inputs: AiCfBaaiBgeLargeEnV15Input with get, set

        [<Import("@cloudflare/workers-types", "PromptTokensDetails")>]
        type PromptTokensDetails =
            [<EmitProperty("audio_tokens")>]
            abstract audioTokens: option<float> with get, set

            [<EmitProperty("cached_tokens")>]
            abstract cachedTokens: option<float> with get, set

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

        [<Import("@cloudflare/workers-types", "StreamWatermarks")>]
        type StreamWatermarks =
            abstract delete: watermarkId: D1SessionBookmark -> Promise<unit>
            abstract get: watermarkId: D1SessionBookmark -> Promise<StreamWatermark>
            abstract list: unit -> Promise<Array<StreamWatermark>>
            abstract generate: url: D1SessionBookmark * params: StreamWatermarkCreateParams -> Promise<StreamWatermark>

            abstract generate:
                input: AiTextToImageOutput * params: StreamWatermarkCreateParams -> Promise<StreamWatermark>

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type RateLimitedError = | RateLimitedError

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type VectorizeVectorMetadataFilterCollectionOp =
            | [<CompiledName("$in")>] In
            | [<CompiledName("$nin")>] Nin

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type MessageSendRequest =
            | [<CompiledName("text")>] Text
            | [<CompiledName("json")>] Json
            | [<CompiledName("bytes")>] Bytes
            | [<CompiledName("v8")>] V8

        [<Import("@cloudflare/workers-types", "TraceItemFetchEventInfoResponse")>]
        type TraceItemFetchEventInfoResponse =
            abstract status: float with get

        type EmailAttachment = obj

        [<Import("@cloudflare/workers-types", "HTMLRewriterElementContentHandlers")>]
        type HTMLRewriterElementContentHandlers =
            abstract text: element: Typescript.Text -> option<Promise<unit>>
            abstract comments: comment: Typescript.Comment -> option<Promise<unit>>
            abstract element: element: Typescript.Element -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "StreamPublicDetails")>]
        type StreamPublicDetails =
            abstract logo: option<string> with get, set

            [<EmitProperty("channel_link")>]
            abstract channelLink: option<string> with get, set

            [<EmitProperty("share_link")>]
            abstract shareLink: option<string> with get, set

            abstract title: option<string> with get, set

        type AiSearchInstanceInfo =
            | ``3600`` = 3600
            | ``7200`` = 7200
            | ``14400`` = 14400
            | ``21600`` = 21600
            | ``43200`` = 43200
            | ``86400`` = 86400

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type StreamPaginationComparison =
            | [<CompiledName("eq")>] Eq
            | [<CompiledName("gt")>] Gt
            | [<CompiledName("gte")>] Gte
            | [<CompiledName("lt")>] Lt
            | [<CompiledName("lte")>] Lte

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionsMessagesInput =
            | [<CompiledName("low")>] Low
            | [<CompiledName("medium")>] Medium
            | [<CompiledName("high")>] High
            | [<CompiledName("auto")>] Auto
            | [<CompiledName("default")>] Default
            | [<CompiledName("flex")>] Flex
            | [<CompiledName("scale")>] Scale
            | [<CompiledName("priority")>] Priority

        [<Import("@cloudflare/workers-types", "SqlStorageCursor"); AbstractClass; AllowNullLiteral>]
        type SqlStorageCursor<'T when 'T :> WebAssembly.ModuleImports> private () =
            abstract rowsWritten: float with get
            abstract rowsRead: float with get
            abstract columnNames: Array<D1SessionBookmark> with get, set
            abstract symbolIterator: unit -> IterableIterator<'T, option<obj>, option<obj>>
            abstract raw: unit -> IterableIterator<'U, option<obj>, option<obj>>
            abstract one: unit -> 'T
            abstract toArray: unit -> Array<'T>
            abstract next: unit -> U2<SqlStorageCursor.Next, SqlStorageCursor.Next>

        type OnRequest =
            abstract ASSETS: OnRequest.ASSETS with get, set
            abstract data: 'Data with get, set
            abstract params: WebAssembly.ModuleImports with get, set
            abstract env: OnRequest.Env with get, set
            abstract functionPath: D1SessionBookmark with get, set
            abstract request: Typescript.Request with get, set
            abstract next: ?input: RequestInfo * ?init: Typescript.RequestInit -> Promise<Typescript.Response>
            abstract passThroughOnException: unit -> unit
            abstract waitUntil: promise: Promise<option<obj>> -> unit

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Klein_4B_Output")>]
        type AiCfBlackForestLabsFlux2Klein4BOutput =
            abstract image: option<D1SessionBookmark> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfDeepgramAura2EsInput =
            | [<CompiledName("none")>] None
            | [<CompiledName("wav")>] Wav
            | [<CompiledName("ogg")>] Ogg
            | [<CompiledName("linear16")>] Linear16
            | [<CompiledName("flac")>] Flac
            | [<CompiledName("mulaw")>] Mulaw
            | [<CompiledName("alaw")>] Alaw
            | [<CompiledName("mp3")>] Mp3
            | [<CompiledName("opus")>] Opus
            | [<CompiledName("aac")>] Aac
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

        [<Import("@cloudflare/workers-types", "ColoLocalActorNamespace"); AbstractClass; AllowNullLiteral>]
        type ColoLocalActorNamespace private () =
            abstract get: actorId: D1SessionBookmark -> ColoLocalActorNamespace.Get

        type AiSearchSearchRequest = obj

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

            abstract tools: option<Array<U2<AiCfGoogleGemma312BItMessages.Tools, AiCfGoogleGemma312BItMessages.Tools>>> with get, set
            abstract functions: option<Array<AiTextGenerationFunctionsInput>> with get, set
            abstract messages: Array<AiCfGoogleGemma312BItMessages.Messages> with get, set

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Pfnet_Plamo_Embedding_1B"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfPfnetPlamoEmbedding1B private () =
            abstract postProcessedOutputs: AiCfPfnetPlamoEmbedding1BOutput with get, set
            abstract inputs: AiCfPfnetPlamoEmbedding1BInput with get, set

        [<Import("@cloudflare/workers-types", "TestController")>]
        type TestController = interface end

        type AiImageClassificationOutput = obj

        [<Import("@cloudflare/workers-types", "Doctype")>]
        type Doctype =
            abstract systemId: option<string> with get
            abstract publicId: option<string> with get
            abstract name: option<string> with get

        [<Import("@cloudflare/workers-types", "BasicImageTransformations")>]
        type BasicImageTransformations =
            abstract rotate: option<BasicImageTransformations.Rotate> with get, set
            abstract background: option<D1SessionBookmark> with get, set
            abstract gravity: option<U2<BasicImageTransformations.Gravity, BasicImageTransformationsGravityCoordinates>> with get, set
            abstract segment: option<BasicImageTransformations.Segment> with get, set
            abstract fit: option<BasicImageTransformations.Fit> with get, set
            abstract height: option<float> with get, set
            abstract width: option<float> with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionContentPartInputAudio = | [<CompiledName("input_audio")>] InputAudio

        [<Import("@cloudflare/workers-types", "Tracing")>]
        type Tracing =
            [<EmitProperty("Span")>]
            abstract span: Tracing.Span with get, set

            abstract enterSpan:
                name: D1SessionBookmark * callback: Tracing.EnterSpan.Callback * [<ParamArray>] args: 'A -> 'T

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

        type VectorFloatArray = U2<Float32Array<ArrayBufferLike>, Float64Array<ArrayBufferLike>>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_AsyncResponse")>]
        type AiCfAisingaporeGemmaSeaLionV427BItAsyncResponse =
            [<EmitProperty("request_id")>]
            abstract requestId: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "ImageTransformationOutputOptions")>]
        type ImageTransformationOutputOptions =
            abstract encoding: option<ImageTransformationOutputOptions.Encoding> with get, set

        [<Import("@cloudflare/workers-types", "ChatTemplateKwargs")>]
        type ChatTemplateKwargs =
            [<EmitProperty("clear_thinking")>]
            abstract clearThinking: option<bool> with get, set

            [<EmitProperty("enable_thinking")>]
            abstract enableThinking: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "CompressionStream"); AbstractClass; AllowNullLiteral>]
        type CompressionStream private () =
            inherit TransformStream<BufferSource, Uint8Array<ArrayBufferLike>>()

            [<EmitConstructor>]
            abstract Create: format: CompressionStream.Format -> CompressionStream

        type AiSentenceSimilarityOutput = obj

        [<Import("@cloudflare/workers-types", "SqlStorageStatement"); AbstractClass; AllowNullLiteral>]
        type SqlStorageStatement private () = class end

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

        [<Import("@cloudflare/workers-types", "UsageTags")>]
        type UsageTags =
            [<EmitProperty("total_tokens")>]
            abstract totalTokens: float with get, set

            [<EmitProperty("completion_tokens")>]
            abstract completionTokens: float with get, set

            [<EmitProperty("prompt_tokens")>]
            abstract promptTokens: float with get, set

        type AiCfMetaLlama4Scout17B16EInstructInput = obj

        [<Import("@cloudflare/workers-types", "Ai_Cf_Openai_Whisper_Large_V3_Turbo_Output")>]
        type AiCfOpenaiWhisperLargeV3TurboOutput =
            abstract vtt: option<D1SessionBookmark> with get, set
            abstract segments: option<Array<AiCfOpenaiWhisperLargeV3TurboOutput.Segments>> with get, set

            [<EmitProperty("word_count")>]
            abstract wordCount: option<float> with get, set

            abstract text: D1SessionBookmark with get, set

            [<EmitProperty("transcription_info")>]
            abstract transcriptionInfo: option<AiCfOpenaiWhisperLargeV3TurboOutput.TranscriptionInfo> with get, set

        [<Import("@cloudflare/workers-types", "StreamOptions")>]
        type StreamOptions =
            [<EmitProperty("include_obfuscation")>]
            abstract includeObfuscation: option<bool> with get, set

        [<Import("@cloudflare/workers-types", "ExportedHandlerTraceHandler")>]
        type ExportedHandlerTraceHandler<'Props, 'Env> =
            abstract Invoke:
                traces: Array<TraceItem> * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Output")>]
        type AiCfMistralaiMistralSmall3124BInstructOutput =
            [<EmitProperty("tool_calls")>]
            abstract toolCalls: option<Array<AiCfMistralaiMistralSmall3124BInstructOutput.ToolCalls>> with get, set

            abstract usage: option<AiCfMistralaiMistralSmall3124BInstructOutput.Usage> with get, set
            abstract response: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "BaseAiImageToText"); AbstractClass; AllowNullLiteral>]
        type BaseAiImageToText private () =
            abstract postProcessedOutputs: AiImageToTextOutput with get, set
            abstract inputs: AiImageToTextInput with get, set

        [<Import("@cloudflare/workers-types", "TextDecoderStream"); AbstractClass; AllowNullLiteral>]
        type TextDecoderStream private () =
            inherit TransformStream<BufferSource, D1SessionBookmark>()

            [<EmitConstructor>]
            abstract Create:
                ?label: D1SessionBookmark * ?options: TextDecoderStreamTextDecoderStreamInit -> TextDecoderStream

            abstract ignoreBOM: bool with get
            abstract fatal: bool with get
            abstract encoding: D1SessionBookmark with get

        [<Import("@cloudflare/workers-types", "Ai_Cf_Black_Forest_Labs_Flux_2_Klein_9B_Output")>]
        type AiCfBlackForestLabsFlux2Klein9BOutput =
            abstract image: option<D1SessionBookmark> with get, set

        [<Import("@cloudflare/workers-types", "DurableObjectTransaction")>]
        type DurableObjectTransaction =
            abstract deleteAlarm: ?options: DurableObjectSetAlarmOptions -> Promise<unit>
            abstract setAlarm: scheduledTime: U2<Date, float> * ?options: DurableObjectSetAlarmOptions -> Promise<unit>
            abstract getAlarm: ?options: DurableObjectGetAlarmOptions -> Promise<option<float>>
            abstract rollback: unit -> unit
            abstract delete: keys: Array<D1SessionBookmark> * ?options: DurableObjectPutOptions -> Promise<float>
            abstract delete: key: D1SessionBookmark * ?options: DurableObjectPutOptions -> Promise<bool>
            abstract put: entries: WebAssembly.ModuleImports * ?options: DurableObjectPutOptions -> Promise<unit>
            abstract put: key: D1SessionBookmark * value: 'T * ?options: DurableObjectPutOptions -> Promise<unit>
            abstract list: ?options: DurableObjectListOptions -> Promise<Map<D1SessionBookmark, 'T>>

            abstract get:
                keys: Array<D1SessionBookmark> * ?options: DurableObjectGetOptions ->
                    Promise<Map<D1SessionBookmark, 'T>>

            abstract get: key: D1SessionBookmark * ?options: DurableObjectGetOptions -> Promise<option<'T>>

        [<Import("@cloudflare/workers-types", "DurableObject")>]
        type DurableObject =
            abstract webSocketError: ws: Typescript.WebSocket * ?error: obj -> option<Promise<unit>>

            abstract webSocketClose:
                ws: Typescript.WebSocket * code: float * reason: D1SessionBookmark * wasClean: bool ->
                    option<Promise<unit>>

            abstract webSocketMessage:
                ws: Typescript.WebSocket * message: U2<ArrayBuffer, string> -> option<Promise<unit>>

            abstract alarm: ?alarmInfo: AlarmInvocationInfo -> option<Promise<unit>>
            abstract connect: socket: Socket -> option<Promise<unit>>
            abstract fetch: request: Typescript.Request -> U2<Typescript.Response, Promise<Typescript.Response>>

        [<Import("@cloudflare/workers-types", "ExportedHandlerTestHandler")>]
        type ExportedHandlerTestHandler<'Props, 'Env> =
            abstract Invoke:
                controller: TestController * env: 'Env * ctx: ExecutionContext<'Props> -> option<Promise<unit>>

        [<Import("@cloudflare/workers-types", "QueueSendMetrics")>]
        type QueueSendMetrics =
            abstract oldestMessageTimestamp: option<Date> with get, set
            abstract backlogBytes: float with get, set
            abstract backlogCount: float with get, set

        [<Import("@cloudflare/workers-types", "ResponseOutputItemDoneEvent")>]
        type ResponseOutputItemDoneEvent =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseOutputItemDoneEvent.Type with get, set

            [<EmitProperty("sequence_number")>]
            abstract sequenceNumber: float with get, set

            [<EmitProperty("output_index")>]
            abstract outputIndex: float with get, set

            abstract item: ResponseOutputItem with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type StreamCaption =
            | [<CompiledName("ready")>] Ready
            | [<CompiledName("inprogress")>] Inprogress
            | [<CompiledName("error")>] Error

        type AiCfQwenQwq32BInput = obj

        [<Import("@cloudflare/workers-types", "AiTextGenerationToolInput")>]
        type AiTextGenerationToolInput =
            [<EmitProperty("function")>]
            abstract ``function``: AiTextGenerationToolInput.Function with get, set

            [<EmitProperty("type")>]
            abstract ``type``: U2<AiTextGenerationToolInput.Type, AiTextGenerationToolInput.Type> with get, set

        [<Import("@cloudflare/workers-types", "AiSearchItemChunksParams")>]
        type AiSearchItemChunksParams =
            abstract offset: option<float> with get, set
            abstract limit: option<float> with get, set

        [<Import("@cloudflare/workers-types", "KVNamespaceGetOptions")>]
        type KVNamespaceGetOptions<'Type> =
            abstract cacheTtl: option<float> with get, set

            [<EmitProperty("type")>]
            abstract ``type``: 'Type with get, set

        type D1SessionBookmark = obj

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Leonardo_Lucid_Origin"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfLeonardoLucidOrigin private () =
            abstract postProcessedOutputs: AiCfLeonardoLucidOriginOutput with get, set
            abstract inputs: AiCfLeonardoLucidOriginInput with get, set

        /// <deprecated>
        /// Use the standalone AI Search Workers binding instead.<br/>
        /// See https://developers.cloudflare.com/ai-search/usage/workers-binding/
        /// </deprecated>
        [<Import("@cloudflare/workers-types", "AutoRAGNameNotSetError"); AbstractClass; AllowNullLiteral>]
        type AutoRAGNameNotSetError private () =
            inherit exn()

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type AiCfDeepgramAura1Input =
            | [<CompiledName("none")>] None
            | [<CompiledName("wav")>] Wav
            | [<CompiledName("ogg")>] Ogg
            | [<CompiledName("linear16")>] Linear16
            | [<CompiledName("flac")>] Flac
            | [<CompiledName("mulaw")>] Mulaw
            | [<CompiledName("alaw")>] Alaw
            | [<CompiledName("mp3")>] Mp3
            | [<CompiledName("opus")>] Opus
            | [<CompiledName("aac")>] Aac
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

        type AiCfMetaLlama3370BInstructFp8FastInput = obj

        [<Import("@cloudflare/workers-types", "Base_Ai_Cf_Deepgram_Nova_3"); AbstractClass; AllowNullLiteral>]
        type BaseAiCfDeepgramNova3 private () =
            abstract postProcessedOutputs: AiCfDeepgramNova3Output with get, set
            abstract inputs: AiCfDeepgramNova3Input with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ChatCompletionMessageCustomToolCall = | [<CompiledName("custom")>] Custom

        [<Import("@cloudflare/workers-types", "ContainerDirectorySnapshotOptions")>]
        type ContainerDirectorySnapshotOptions =
            abstract name: option<D1SessionBookmark> with get, set
            abstract dir: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ResponseInputTextContent")>]
        type ResponseInputTextContent =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseInputTextContent.Type with get, set

            abstract text: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ImageUploadOptions = | [<CompiledName("base64")>] Base64

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

        [<Import("@cloudflare/workers-types", "CustomEvent"); AbstractClass; AllowNullLiteral>]
        type CustomEvent<'T> private () =
            inherit Event()

            [<EmitConstructor>]
            abstract Create: ``type``: D1SessionBookmark * ?init: CustomEventCustomEventInit -> CustomEvent

            abstract detail: 'T with get

        [<Import("@cloudflare/workers-types", "AiSearchMultiSearchResponse")>]
        type AiSearchMultiSearchResponse =
            abstract errors: option<Array<AiSearchMultiSearchError>> with get, set
            abstract chunks: Array<AiSearchMultiSearchChunk> with get, set

            [<EmitProperty("search_query")>]
            abstract searchQuery: D1SessionBookmark with get, set

        [<Import("@cloudflare/workers-types", "ResponseContentReasoningText")>]
        type ResponseContentReasoningText =
            [<EmitProperty("type")>]
            abstract ``type``: ResponseContentReasoningText.Type with get, set

            abstract text: D1SessionBookmark with get, set

        [<RequireQualifiedAccess; StringEnum(CaseRules.None)>]
        type ResponseCreatedEvent = | [<CompiledName("response.created")>] ResponseCreated

        type AiTextToImageOutput = obj

        type IWorkersTypes =
            [<Import("@cloudflare/workers-types", "clearTimeout")>]
            static member clearTimeout(timeoutId: option<float>) : unit = JS.undefined

            [<Import("@cloudflare/workers-types", "clearTimeout")>]
            static member clearTimeout(id: option<float>) : unit = JS.undefined

            [<Erase>]
            member __RPC_TARGET_BRAND: __RPC_TARGET_BRAND = JS.undefined

            [<CompiledName("_EmailMessage")>]
            member _emailMessage: _EmailMessage = JS.undefined

            [<Import("@cloudflare/workers-types", "btoa")>]
            static member btoa(data: D1SessionBookmark) : D1SessionBookmark = JS.undefined

            [<Import("@cloudflare/workers-types", "btoa")>]
            static member btoa(data: D1SessionBookmark) : D1SessionBookmark = JS.undefined

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

            [<Erase>]
            member onRequest: OnRequest -> U2<Typescript.Response, Promise<Typescript.Response>> =
                JS.undefined

            [<CompiledName("EmailMessage")>]
            member emailMessage: EmailMessage = JS.undefined

            [<Erase>]
            member __DURABLE_OBJECT_BRAND: __DURABLE_OBJECT_BRAND = JS.undefined

            [<Erase>]
            member __WORKFLOW_ENTRYPOINT_BRAND: __WORKFLOW_ENTRYPOINT_BRAND = JS.undefined

            [<Erase>]
            member cache: CacheContext = JS.undefined

            [<Erase>]
            member __RPC_STUB_BRAND: __RPC_STUB_BRAND = JS.undefined

            [<Import("@cloudflare/workers-types", "connect")>]
            static member _connect(address: U2<SocketAddress, string>, ?options: SocketOptions) : Socket = JS.undefined

            [<Import("@cloudflare/workers-types", "reportError")>]
            static member reportError(error: option<obj>) : unit = JS.undefined

            [<Import("@cloudflare/workers-types", "reportError")>]
            static member reportError(e: option<obj>) : unit = JS.undefined

            [<Erase>]
            member __WORKER_ENTRYPOINT_BRAND: __WORKER_ENTRYPOINT_BRAND = JS.undefined

            [<Erase>]
            member tracing: Tracing = JS.undefined

            [<Import("@cloudflare/workers-types", "structuredClone")>]
            static member structuredClone(value: 'T, ?options: Typescript.StructuredSerializeOptions) : 'T =
                JS.undefined

            [<Import("@cloudflare/workers-types", "structuredClone")>]
            static member structuredClone(value: 'T, ?options: Typescript.StructuredSerializeOptions) : 'T =
                JS.undefined

            [<Import("@cloudflare/workers-types", "setInterval")>]
            static member setInterval
                (callback: SetInterval.Callback, ?msDelay: float, [<ParamArray>] args: 'Args)
                : float =
                JS.undefined

            [<Import("@cloudflare/workers-types", "setInterval")>]
            static member setInterval(callback: SetInterval.Callback, ?msDelay: float) : float = JS.undefined

            [<Import("@cloudflare/workers-types", "setInterval")>]
            static member setInterval
                (handler: TimerHandler, ?timeout: float, [<ParamArray>] arguments: Array<option<obj>>)
                : float =
                JS.undefined

            [<Import("@cloudflare/workers-types", "connect")>]
            static member connect(address: U2<SocketAddress, string>, ?options: SocketOptions) : Socket = JS.undefined

            [<Import("@cloudflare/workers-types", "queueMicrotask")>]
            static member queueMicrotask(task: Function) : unit = JS.undefined

            [<Import("@cloudflare/workers-types", "queueMicrotask")>]
            static member queueMicrotask(callback: VoidFunction) : unit = JS.undefined

            [<CompiledName("Cloudflare")>]
            member cloudflare: Cloudflare = JS.undefined

            [<CompiledName("RpcStub")>]
            member rpcStub: RpcStub = JS.undefined

            [<Import("@cloudflare/workers-types", "atob")>]
            static member atob(data: D1SessionBookmark) : D1SessionBookmark = JS.undefined

            [<Import("@cloudflare/workers-types", "atob")>]
            static member atob(data: D1SessionBookmark) : D1SessionBookmark = JS.undefined

            [<Import("@cloudflare/workers-types", "clearInterval")>]
            static member clearInterval(timeoutId: option<float>) : unit = JS.undefined

            [<Import("@cloudflare/workers-types", "clearInterval")>]
            static member clearInterval(id: option<float>) : unit = JS.undefined

            [<Import("@cloudflare/workers-types", "dispatchEvent")>]
            static member dispatchEvent
                (event: U4<PromiseRejectionEvent, QueueEvent<option<obj>>, ScheduledEvent, FetchEvent>)
                : bool =
                JS.undefined

            [<Import("@cloudflare/workers-types", "dispatchEvent")>]
            static member dispatchEvent(event: Event) : bool = JS.undefined

            [<Import("@cloudflare/workers-types", "setTimeout")>]
            static member setTimeout
                (callback: SetTimeout.Callback, ?msDelay: float, [<ParamArray>] args: 'Args)
                : float =
                JS.undefined

            [<Import("@cloudflare/workers-types", "setTimeout")>]
            static member setTimeout(callback: SetTimeout.Callback, ?msDelay: float) : float = JS.undefined

            [<Import("@cloudflare/workers-types", "setTimeout")>]
            static member setTimeout
                (handler: TimerHandler, ?timeout: float, [<ParamArray>] arguments: Array<option<obj>>)
                : float =
                JS.undefined

            [<Import("@cloudflare/workers-types", "fetch")>]
            static member fetch
                (input: U3<Typescript.Request, URL, string>, ?init: Typescript.RequestInit)
                : Promise<Typescript.Response> =
                JS.undefined

            [<Import("@cloudflare/workers-types", "fetch")>]
            static member fetch
                (input: U3<Typescript.Request, URL, string>, ?init: Typescript.RequestInit)
                : Promise<Typescript.Response> =
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
