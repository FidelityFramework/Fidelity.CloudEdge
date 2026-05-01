namespace rec Fidelity.CloudEdge.Management.BrowserRendering

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.BrowserRendering.Types
open Fidelity.CloudEdge.Management.BrowserRendering.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type BrowserRenderingClient(httpClient: HttpClient) =
    ///<summary>
    ///Fetches rendered HTML content from provided URL or HTML. Check available options like `gotoOptions` and `waitFor*` to control page load behaviour.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostContent
        (
            accountId: string,
            body: string,
            ?cacheTTL: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/content"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostContent.OK(Serializer.deserialize content)
            | 400 -> return BrapiPostContent.BadRequest(Serializer.deserialize content)
            | 422 -> return BrapiPostContent.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return BrapiPostContent.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Starts a crawl job for the provided URL and its children. Check available options like `gotoOptions` and `waitFor*` to control page load behaviour.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostCrawl
        (
            accountId: string,
            body: string,
            ?cacheTTL: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/crawl"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostCrawl.OK(Serializer.deserialize content)
            | 400 -> return BrapiPostCrawl.BadRequest(Serializer.deserialize content)
            | _ -> return BrapiPostCrawl.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Cancels an ongoing crawl job by setting its status to cancelled and stopping all queued URLs.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="jobId">The ID of the crawl job to cancel.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiDeleteCancelCrawl(accountId: string, jobId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("job_id", jobId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/crawl/{job_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiDeleteCancelCrawl.OK(Serializer.deserialize content)
            | 400 -> return BrapiDeleteCancelCrawl.BadRequest(Serializer.deserialize content)
            | 404 -> return BrapiDeleteCancelCrawl.NotFound(Serializer.deserialize content)
            | _ -> return BrapiDeleteCancelCrawl.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the result of a crawl job.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="jobId">Crawl job ID.</param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="status">Filter by URL status.</param>
    ///<param name="cursor">Cursor for pagination.</param>
    ///<param name="limit">Limit for pagination.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiGetCrawlResult
        (
            accountId: string,
            jobId: string,
            ?cacheTTL: float,
            ?status: string,
            ?cursor: float,
            ?limit: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("job_id", jobId)
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value)
                  if cursor.IsSome then
                      RequestPart.query ("cursor", cursor.Value)
                  if limit.IsSome then
                      RequestPart.query ("limit", limit.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/crawl/{job_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiGetCrawlResult.OK(Serializer.deserialize content)
            | 400 -> return BrapiGetCrawlResult.BadRequest(Serializer.deserialize content)
            | _ -> return BrapiGetCrawlResult.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Acquires and establishes a WebSocket connection to a browser session.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="keepAlive">Keep-alive time in ms (only valid when acquiring new session).</param>
    ///<param name="lab">Use experimental browser.</param>
    ///<param name="recording"></param>
    ///<param name="cancellationToken"></param>
    member this.BrapiGetDevtoolsBrowserAcquire
        (
            accountId: string,
            ?keepAlive: float,
            ?lab: bool,
            ?recording: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if keepAlive.IsSome then
                      RequestPart.query ("keep_alive", keepAlive.Value)
                  if lab.IsSome then
                      RequestPart.query ("lab", lab.Value)
                  if recording.IsSome then
                      RequestPart.query ("recording", recording.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/devtools/browser"
                    requestParts
                    cancellationToken

            match int status with
            | 400 -> return BrapiGetDevtoolsBrowserAcquire.BadRequest(Serializer.deserialize content)
            | 500 -> return BrapiGetDevtoolsBrowserAcquire.InternalServerError(Serializer.deserialize content)
            | _ -> return BrapiGetDevtoolsBrowserAcquire.DefaultResponse
        }

    ///<summary>
    ///Get a browser session ID.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="keepAlive">Keep-alive time in milliseconds.</param>
    ///<param name="lab">Use experimental browser.</param>
    ///<param name="targets">Include browser targets in response.</param>
    ///<param name="recording"></param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostDevtoolsAcquire
        (
            accountId: string,
            ?keepAlive: float,
            ?lab: bool,
            ?targets: bool,
            ?recording: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if keepAlive.IsSome then
                      RequestPart.query ("keep_alive", keepAlive.Value)
                  if lab.IsSome then
                      RequestPart.query ("lab", lab.Value)
                  if targets.IsSome then
                      RequestPart.query ("targets", targets.Value)
                  if recording.IsSome then
                      RequestPart.query ("recording", recording.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/devtools/browser"
                    requestParts
                    cancellationToken

            return BrapiPostDevtoolsAcquire.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Closes an existing browser session.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="sessionId">Browser session ID to close.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiDeleteDevtoolsBrowserDelete
        (
            accountId: string,
            sessionId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("session_id", sessionId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/devtools/browser/{session_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiDeleteDevtoolsBrowserDelete.OK(Serializer.deserialize content)
            | _ -> return BrapiDeleteDevtoolsBrowserDelete.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Establishes a WebSocket connection to an existing browser session.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="sessionId">Browser session ID to connect to.</param>
    ///<param name="keepAlive">Keep-alive time in ms (only valid when acquiring new session).</param>
    ///<param name="lab">Use experimental browser.</param>
    ///<param name="recording"></param>
    ///<param name="cancellationToken"></param>
    member this.BrapiGetDevtoolsBrowser
        (
            accountId: string,
            sessionId: System.Guid,
            ?keepAlive: float,
            ?lab: bool,
            ?recording: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("session_id", sessionId)
                  if keepAlive.IsSome then
                      RequestPart.query ("keep_alive", keepAlive.Value)
                  if lab.IsSome then
                      RequestPart.query ("lab", lab.Value)
                  if recording.IsSome then
                      RequestPart.query ("recording", recording.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/devtools/browser/{session_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 400 -> return BrapiGetDevtoolsBrowser.BadRequest(Serializer.deserialize content)
            | 500 -> return BrapiGetDevtoolsBrowser.InternalServerError(Serializer.deserialize content)
            | _ -> return BrapiGetDevtoolsBrowser.DefaultResponse
        }

    ///<summary>
    ///Returns a list of all debuggable targets including tabs, pages, service workers, and other browser contexts.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="sessionId">Browser session ID.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiGetDevtoolsJson(accountId: string, sessionId: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("session_id", sessionId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/devtools/browser/{session_id}/json"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiGetDevtoolsJson.OK(Serializer.deserialize content)
            | 400 -> return BrapiGetDevtoolsJson.BadRequest(Serializer.deserialize content)
            | _ -> return BrapiGetDevtoolsJson.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Activates (brings to front) a specific browser target by its ID.
    ///</summary>
    ///<param name="sessionId">Browser session ID.</param>
    ///<param name="accountId">Account ID.</param>
    ///<param name="targetId">Target ID to activate.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiGetDevtoolsJsonActivate
        (
            sessionId: System.Guid,
            accountId: string,
            targetId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("session_id", sessionId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("target_id", targetId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/devtools/browser/{session_id}/json/activate/{target_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiGetDevtoolsJsonActivate.OK(Serializer.deserialize content)
            | 400 -> return BrapiGetDevtoolsJsonActivate.BadRequest(Serializer.deserialize content)
            | 404 -> return BrapiGetDevtoolsJsonActivate.NotFound(Serializer.deserialize content)
            | _ -> return BrapiGetDevtoolsJsonActivate.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Closes a specific browser target (tab, page, etc.) by its ID. Returns 'Target is closing' on success or an error if the target is not found.
    ///</summary>
    ///<param name="sessionId">Browser session ID.</param>
    ///<param name="accountId">Account ID.</param>
    ///<param name="targetId">Target ID to close.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiGetDevtoolsJsonClose
        (
            sessionId: System.Guid,
            accountId: string,
            targetId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("session_id", sessionId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("target_id", targetId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/devtools/browser/{session_id}/json/close/{target_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiGetDevtoolsJsonClose.OK(Serializer.deserialize content)
            | 400 -> return BrapiGetDevtoolsJsonClose.BadRequest(Serializer.deserialize content)
            | 404 -> return BrapiGetDevtoolsJsonClose.NotFound(Serializer.deserialize content)
            | _ -> return BrapiGetDevtoolsJsonClose.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a list of all debuggable targets including tabs, pages, service workers, and other browser contexts.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="sessionId">Browser session ID.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiGetDevtoolsJsonList
        (
            accountId: string,
            sessionId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("session_id", sessionId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/devtools/browser/{session_id}/json/list"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiGetDevtoolsJsonList.OK(Serializer.deserialize content)
            | 400 -> return BrapiGetDevtoolsJsonList.BadRequest(Serializer.deserialize content)
            | _ -> return BrapiGetDevtoolsJsonList.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the debuggable target with the given ID.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="sessionId">Browser session ID.</param>
    ///<param name="targetId">Target ID.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiGetDevtoolsJsonTarget
        (
            accountId: string,
            sessionId: System.Guid,
            targetId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("session_id", sessionId)
                  RequestPart.path ("target_id", targetId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/devtools/browser/{session_id}/json/list/{target_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiGetDevtoolsJsonTarget.OK(Serializer.deserialize content)
            | 400 -> return BrapiGetDevtoolsJsonTarget.BadRequest(Serializer.deserialize content)
            | 404 -> return BrapiGetDevtoolsJsonTarget.NotFound(Serializer.deserialize content)
            | _ -> return BrapiGetDevtoolsJsonTarget.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Opens a new tab in the browser. Optionally specify a URL to navigate to.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="sessionId">Browser session ID.</param>
    ///<param name="url"></param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPutDevtoolsJsonNew
        (
            accountId: string,
            sessionId: System.Guid,
            ?url: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("session_id", sessionId)
                  if url.IsSome then
                      RequestPart.query ("url", url.Value) ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/devtools/browser/{session_id}/json/new"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPutDevtoolsJsonNew.OK(Serializer.deserialize content)
            | 400 -> return BrapiPutDevtoolsJsonNew.BadRequest(Serializer.deserialize content)
            | _ -> return BrapiPutDevtoolsJsonNew.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the complete Chrome DevTools Protocol schema including all domains, commands, events, and types. This schema describes the entire CDP API surface.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="sessionId">Browser session ID.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiGetDevtoolsJsonProtocol
        (
            accountId: string,
            sessionId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("session_id", sessionId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/devtools/browser/{session_id}/json/protocol"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiGetDevtoolsJsonProtocol.OK(Serializer.deserialize content)
            | 400 -> return BrapiGetDevtoolsJsonProtocol.BadRequest(Serializer.deserialize content)
            | _ -> return BrapiGetDevtoolsJsonProtocol.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Get browser version metadata.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="sessionId">Browser session ID.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiGetDevtoolsJsonVersion
        (
            accountId: string,
            sessionId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("session_id", sessionId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/devtools/browser/{session_id}/json/version"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiGetDevtoolsJsonVersion.OK(Serializer.deserialize content)
            | 400 -> return BrapiGetDevtoolsJsonVersion.BadRequest(Serializer.deserialize content)
            | _ -> return BrapiGetDevtoolsJsonVersion.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Establishes a WebSocket connection to a specific Chrome DevTools target or page.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="sessionId">Browser session ID.</param>
    ///<param name="targetId">Target ID, e.g. page ID.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiGetDevtoolsPage
        (
            accountId: string,
            sessionId: System.Guid,
            targetId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("session_id", sessionId)
                  RequestPart.path ("target_id", targetId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/devtools/browser/{session_id}/page/{target_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 400 -> return BrapiGetDevtoolsPage.BadRequest(Serializer.deserialize content)
            | 500 -> return BrapiGetDevtoolsPage.InternalServerError(Serializer.deserialize content)
            | _ -> return BrapiGetDevtoolsPage.DefaultResponse
        }

    ///<summary>
    ///List active browser sessions.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="limit"></param>
    ///<param name="offset"></param>
    ///<param name="cancellationToken"></param>
    member this.BrapiGetDevtoolsSessionList
        (
            accountId: string,
            ?limit: float,
            ?offset: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if limit.IsSome then
                      RequestPart.query ("limit", limit.Value)
                  if offset.IsSome then
                      RequestPart.query ("offset", offset.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/devtools/session"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiGetDevtoolsSessionList.OK(Serializer.deserialize content)
            | _ -> return BrapiGetDevtoolsSessionList.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Get details for a specific browser session.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="sessionId">Session ID.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiGetDevtoolsSessionDetails
        (
            accountId: string,
            sessionId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("session_id", sessionId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/devtools/session/{session_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiGetDevtoolsSessionDetails.OK(Serializer.deserialize content)
            | _ -> return BrapiGetDevtoolsSessionDetails.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets json from a webpage from a provided URL or HTML. Pass `prompt` or `schema` in the body. Control page loading with `gotoOptions` and `waitFor*` options.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostJson
        (
            accountId: string,
            body: string,
            ?cacheTTL: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/json"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostJson.OK(Serializer.deserialize content)
            | 400 -> return BrapiPostJson.BadRequest(Serializer.deserialize content)
            | 422 -> return BrapiPostJson.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return BrapiPostJson.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Get links from a web page.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostLinks
        (
            accountId: string,
            body: string,
            ?cacheTTL: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/links"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostLinks.OK(Serializer.deserialize content)
            | 400 -> return BrapiPostLinks.BadRequest(Serializer.deserialize content)
            | 422 -> return BrapiPostLinks.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return BrapiPostLinks.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets markdown of a webpage from provided URL or HTML. Control page loading with `gotoOptions` and `waitFor*` options.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostMarkdown
        (
            accountId: string,
            body: string,
            ?cacheTTL: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/markdown"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostMarkdown.OK(Serializer.deserialize content)
            | 400 -> return BrapiPostMarkdown.BadRequest(Serializer.deserialize content)
            | 422 -> return BrapiPostMarkdown.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return BrapiPostMarkdown.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches rendered PDF from provided URL or HTML. Check available options like `gotoOptions` and `waitFor*` to control page load behaviour.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostPdf(accountId: string, body: string, ?cacheTTL: float, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/pdf"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostPdf.OK content
            | 400 -> return BrapiPostPdf.BadRequest(Serializer.deserialize content)
            | 422 -> return BrapiPostPdf.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return BrapiPostPdf.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Get meta attributes like height, width, text and others of selected elements.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostScrape
        (
            accountId: string,
            body: string,
            ?cacheTTL: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/scrape"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostScrape.OK(Serializer.deserialize content)
            | 400 -> return BrapiPostScrape.BadRequest(Serializer.deserialize content)
            | 422 -> return BrapiPostScrape.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return BrapiPostScrape.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Takes a screenshot of a webpage from provided URL or HTML. Control page loading with `gotoOptions` and `waitFor*` options. Customize screenshots with `viewport`, `fullPage`, `clip` and others.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostScreenshot
        (
            accountId: string,
            body: string,
            ?cacheTTL: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/screenshot"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostScreenshot.OK(Serializer.deserialize content)
            | 400 -> return BrapiPostScreenshot.BadRequest(Serializer.deserialize content)
            | 422 -> return BrapiPostScreenshot.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return BrapiPostScreenshot.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the page's HTML content and screenshot. Control page loading with `gotoOptions` and `waitFor*` options. Customize screenshots with `viewport`, `fullPage`, `clip` and others.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="body"></param>
    ///<param name="cacheTTL">Cache TTL default is 5s. Set to 0 to disable.</param>
    ///<param name="cancellationToken"></param>
    member this.BrapiPostSnapshot
        (
            accountId: string,
            body: string,
            ?cacheTTL: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cacheTTL.IsSome then
                      RequestPart.query ("cacheTTL", cacheTTL.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/browser-rendering/snapshot"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return BrapiPostSnapshot.OK(Serializer.deserialize content)
            | 400 -> return BrapiPostSnapshot.BadRequest(Serializer.deserialize content)
            | 422 -> return BrapiPostSnapshot.UnprocessableEntity(Serializer.deserialize content)
            | _ -> return BrapiPostSnapshot.InternalServerError(Serializer.deserialize content)
        }
