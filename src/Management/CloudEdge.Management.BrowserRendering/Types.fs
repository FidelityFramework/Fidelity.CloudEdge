namespace rec Fidelity.CloudEdge.Management.BrowserRendering.Types

// Auto-generated stub types (missing from Hawaii output)
type protocol = string

type Errors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type Meta =
    { status: Option<float>
      title: Option<string> }

type BrapiPostContent_OK =
    { errors: Option<list<Errors>>
      meta: Meta
      ///HTML content.
      result: Option<string>
      ///Response status.
      success: bool }

type BrapiPostContent_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostContent_BadRequest =
    { errors: Option<list<BrapiPostContent_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiPostContent_UnprocessableEntityErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostContent_UnprocessableEntity =
    { errors: Option<list<BrapiPostContent_UnprocessableEntityErrors>>
      ///Response status.
      success: bool }

type BrapiPostContent_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostContent_InternalServerError =
    { errors: Option<list<BrapiPostContent_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostContent =
    ///Returns the page's content.
    | OK of payload: BrapiPostContent_OK
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostContent_BadRequest
    ///Request failed due to site-related issues such as timeouts, SSL errors, or inaccessible content.
    | UnprocessableEntity of payload: BrapiPostContent_UnprocessableEntity
    ///Internal server error.
    | InternalServerError of payload: BrapiPostContent_InternalServerError

type BrapiPostCrawl_OKErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostCrawl_OK =
    { errors: Option<list<BrapiPostCrawl_OKErrors>>
      ///Crawl job ID.
      result: string
      ///Response status.
      success: bool }

type BrapiPostCrawl_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostCrawl_BadRequest =
    { errors: Option<list<BrapiPostCrawl_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiPostCrawl_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostCrawl_InternalServerError =
    { errors: Option<list<BrapiPostCrawl_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostCrawl =
    ///Returns the ID for the started crawl job.
    | OK of payload: BrapiPostCrawl_OK
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostCrawl_BadRequest
    ///Internal server error.
    | InternalServerError of payload: BrapiPostCrawl_InternalServerError

type BrapiDeleteCancelCrawl_OKErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type Result =
    { ///The ID of the cancelled job.
      job_id: string
      ///Cancellation confirmation message.
      message: string }

type BrapiDeleteCancelCrawl_OK =
    { errors: Option<list<BrapiDeleteCancelCrawl_OKErrors>>
      result: Result
      ///Response status.
      success: bool }

type BrapiDeleteCancelCrawl_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiDeleteCancelCrawl_BadRequest =
    { errors: Option<list<BrapiDeleteCancelCrawl_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiDeleteCancelCrawl_NotFoundErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiDeleteCancelCrawl_NotFound =
    { errors: Option<list<BrapiDeleteCancelCrawl_NotFoundErrors>>
      ///Response status.
      success: bool }

type BrapiDeleteCancelCrawl_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiDeleteCancelCrawl_InternalServerError =
    { errors: Option<list<BrapiDeleteCancelCrawl_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiDeleteCancelCrawl =
    ///Crawl job cancelled successfully.
    | OK of payload: BrapiDeleteCancelCrawl_OK
    ///Job is already in final status and cannot be cancelled.
    | BadRequest of payload: BrapiDeleteCancelCrawl_BadRequest
    ///Crawl job not found.
    | NotFound of payload: BrapiDeleteCancelCrawl_NotFound
    ///Internal server error.
    | InternalServerError of payload: BrapiDeleteCancelCrawl_InternalServerError

type BrapiGetCrawlResult_OKErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type Metadata =
    { ///HTTP status code of the crawled page.
      status: float
      ///Title of the crawled page.
      title: Option<string>
      ///Final URL of the crawled page.
      url: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Status =
    | [<CompiledName "queued">] Queued
    | [<CompiledName "errored">] Errored
    | [<CompiledName "completed">] Completed
    | [<CompiledName "disallowed">] Disallowed
    | [<CompiledName "skipped">] Skipped
    | [<CompiledName "cancelled">] Cancelled
    member this.Format() =
        match this with
        | Queued -> "queued"
        | Errored -> "errored"
        | Completed -> "completed"
        | Disallowed -> "disallowed"
        | Skipped -> "skipped"
        | Cancelled -> "cancelled"

type Records =
    { ///HTML content of the crawled URL.
      html: Option<string>
      ///JSON of the content of the crawled URL.
      json: Option<Map<string, Option<string>>>
      ///Markdown of the content of the crawled URL.
      markdown: Option<string>
      metadata: Metadata
      ///Current status of the crawled URL.
      status: Status
      ///Crawled URL.
      url: string }

type BrapiGetCrawlResult_OKResult =
    { ///Total seconds spent in browser so far.
      browserSecondsUsed: float
      ///Cursor for pagination.
      cursor: Option<string>
      ///Total number of URLs that have been crawled so far.
      finished: float
      ///Crawl job ID.
      id: string
      ///List of crawl job records.
      records: list<Records>
      ///Total number of URLs that were skipped due to include/exclude/subdomain filters. Skipped URLs are included in records but are not counted toward total/finished.
      skipped: float
      ///Current crawl job status.
      status: string
      ///Total current number of URLs in the crawl job.
      total: float }

type BrapiGetCrawlResult_OK =
    { errors: Option<list<BrapiGetCrawlResult_OKErrors>>
      result: BrapiGetCrawlResult_OKResult
      ///Response status.
      success: bool }

type BrapiGetCrawlResult_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetCrawlResult_BadRequest =
    { errors: Option<list<BrapiGetCrawlResult_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiGetCrawlResult_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetCrawlResult_InternalServerError =
    { errors: Option<list<BrapiGetCrawlResult_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiGetCrawlResult =
    ///Returns the result of a crawl job.
    | OK of payload: BrapiGetCrawlResult_OK
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiGetCrawlResult_BadRequest
    ///Internal server error.
    | InternalServerError of payload: BrapiGetCrawlResult_InternalServerError

type BrapiGetDevtoolsBrowserAcquire_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsBrowserAcquire_BadRequest =
    { errors: Option<list<BrapiGetDevtoolsBrowserAcquire_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiGetDevtoolsBrowserAcquire_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsBrowserAcquire_InternalServerError =
    { errors: Option<list<BrapiGetDevtoolsBrowserAcquire_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiGetDevtoolsBrowserAcquire =
    ///Bad request.
    | BadRequest of payload: BrapiGetDevtoolsBrowserAcquire_BadRequest
    ///Internal server error.
    | InternalServerError of payload: BrapiGetDevtoolsBrowserAcquire_InternalServerError
    | DefaultResponse

type BrapiPostDevtoolsAcquire_OK =
    { ///Browser session ID.
      sessionId: string
      ///WebSocket URL for the session.
      webSocketDebuggerUrl: Option<string> }

[<RequireQualifiedAccess>]
type BrapiPostDevtoolsAcquire =
    ///Returns a session ID ready to be connected to.
    | OK of payload: BrapiPostDevtoolsAcquire_OK

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type BrapiDeleteDevtoolsBrowserDelete_OKStatus =
    | [<CompiledName "closing">] Closing
    | [<CompiledName "closed">] Closed
    member this.Format() =
        match this with
        | Closing -> "closing"
        | Closed -> "closed"

type BrapiDeleteDevtoolsBrowserDelete_OK =
    { status: BrapiDeleteDevtoolsBrowserDelete_OKStatus }

[<RequireQualifiedAccess>]
type BrapiDeleteDevtoolsBrowserDelete =
    ///Browser session closing or already closed.
    | OK of payload: BrapiDeleteDevtoolsBrowserDelete_OK
    ///Browser session not found.
    | NotFound of payload: obj

type BrapiGetDevtoolsBrowser_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsBrowser_BadRequest =
    { errors: Option<list<BrapiGetDevtoolsBrowser_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiGetDevtoolsBrowser_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsBrowser_InternalServerError =
    { errors: Option<list<BrapiGetDevtoolsBrowser_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiGetDevtoolsBrowser =
    ///Bad request.
    | BadRequest of payload: BrapiGetDevtoolsBrowser_BadRequest
    ///Internal server error.
    | InternalServerError of payload: BrapiGetDevtoolsBrowser_InternalServerError
    | DefaultResponse

type BrapiGetDevtoolsJson_OK =
    { ///Target description.
      description: Option<string>
      ///DevTools frontend URL.
      devtoolsFrontendUrl: Option<string>
      ///Target ID.
      id: string
      ///Title of the target.
      title: Option<string>
      ///Target type (page, background_page, worker, etc.).
      ``type``: string
      ///URL of the target.
      url: string
      ///WebSocket URL for debugging this target.
      webSocketDebuggerUrl: Option<string> }

type BrapiGetDevtoolsJson_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJson_BadRequest =
    { errors: Option<list<BrapiGetDevtoolsJson_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiGetDevtoolsJson_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJson_InternalServerError =
    { errors: Option<list<BrapiGetDevtoolsJson_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiGetDevtoolsJson =
    ///List of targets.
    | OK of payload: list<BrapiGetDevtoolsJson_OK>
    ///Bad request.
    | BadRequest of payload: BrapiGetDevtoolsJson_BadRequest
    ///Internal server error.
    | InternalServerError of payload: BrapiGetDevtoolsJson_InternalServerError

type BrapiGetDevtoolsJsonActivate_OK =
    { ///Target activated.
      message: string }

type BrapiGetDevtoolsJsonActivate_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJsonActivate_BadRequest =
    { errors: Option<list<BrapiGetDevtoolsJsonActivate_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiGetDevtoolsJsonActivate_NotFoundErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJsonActivate_NotFound =
    { errors: Option<list<BrapiGetDevtoolsJsonActivate_NotFoundErrors>>
      ///Response status.
      success: bool }

type BrapiGetDevtoolsJsonActivate_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJsonActivate_InternalServerError =
    { errors: Option<list<BrapiGetDevtoolsJsonActivate_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiGetDevtoolsJsonActivate =
    ///Target activated successfully.
    | OK of payload: BrapiGetDevtoolsJsonActivate_OK
    ///Bad request.
    | BadRequest of payload: BrapiGetDevtoolsJsonActivate_BadRequest
    ///Target not found.
    | NotFound of payload: BrapiGetDevtoolsJsonActivate_NotFound
    ///Internal server error.
    | InternalServerError of payload: BrapiGetDevtoolsJsonActivate_InternalServerError

type BrapiGetDevtoolsJsonClose_OK =
    { ///Target is closing.
      message: string }

type BrapiGetDevtoolsJsonClose_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJsonClose_BadRequest =
    { errors: Option<list<BrapiGetDevtoolsJsonClose_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiGetDevtoolsJsonClose_NotFoundErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJsonClose_NotFound =
    { errors: Option<list<BrapiGetDevtoolsJsonClose_NotFoundErrors>>
      ///Response status.
      success: bool }

type BrapiGetDevtoolsJsonClose_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJsonClose_InternalServerError =
    { errors: Option<list<BrapiGetDevtoolsJsonClose_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiGetDevtoolsJsonClose =
    ///Target is closing.
    | OK of payload: BrapiGetDevtoolsJsonClose_OK
    ///Bad request.
    | BadRequest of payload: BrapiGetDevtoolsJsonClose_BadRequest
    ///Target not found.
    | NotFound of payload: BrapiGetDevtoolsJsonClose_NotFound
    ///Internal server error.
    | InternalServerError of payload: BrapiGetDevtoolsJsonClose_InternalServerError

type BrapiGetDevtoolsJsonList_OK =
    { ///Target description.
      description: Option<string>
      ///DevTools frontend URL.
      devtoolsFrontendUrl: Option<string>
      ///Target ID.
      id: string
      ///Title of the target.
      title: Option<string>
      ///Target type (page, background_page, worker, etc.).
      ``type``: string
      ///URL of the target.
      url: string
      ///WebSocket URL for debugging this target.
      webSocketDebuggerUrl: Option<string> }

type BrapiGetDevtoolsJsonList_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJsonList_BadRequest =
    { errors: Option<list<BrapiGetDevtoolsJsonList_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiGetDevtoolsJsonList_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJsonList_InternalServerError =
    { errors: Option<list<BrapiGetDevtoolsJsonList_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiGetDevtoolsJsonList =
    ///List of targets.
    | OK of payload: list<BrapiGetDevtoolsJsonList_OK>
    ///Bad request.
    | BadRequest of payload: BrapiGetDevtoolsJsonList_BadRequest
    ///Internal server error.
    | InternalServerError of payload: BrapiGetDevtoolsJsonList_InternalServerError

type BrapiGetDevtoolsJsonTarget_OK =
    { ///Target description.
      description: Option<string>
      ///DevTools frontend URL.
      devtoolsFrontendUrl: Option<string>
      ///Target ID.
      id: string
      ///Title of the target.
      title: Option<string>
      ///Target type (page, background_page, worker, etc.).
      ``type``: string
      ///URL of the target.
      url: string
      ///WebSocket URL for debugging this target.
      webSocketDebuggerUrl: Option<string> }

type BrapiGetDevtoolsJsonTarget_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJsonTarget_BadRequest =
    { errors: Option<list<BrapiGetDevtoolsJsonTarget_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiGetDevtoolsJsonTarget_NotFoundErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJsonTarget_NotFound =
    { errors: Option<list<BrapiGetDevtoolsJsonTarget_NotFoundErrors>>
      ///Response status.
      success: bool }

type BrapiGetDevtoolsJsonTarget_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJsonTarget_InternalServerError =
    { errors: Option<list<BrapiGetDevtoolsJsonTarget_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiGetDevtoolsJsonTarget =
    ///The target with the given ID.
    | OK of payload: BrapiGetDevtoolsJsonTarget_OK
    ///Bad request.
    | BadRequest of payload: BrapiGetDevtoolsJsonTarget_BadRequest
    ///Target not found.
    | NotFound of payload: BrapiGetDevtoolsJsonTarget_NotFound
    ///Internal server error.
    | InternalServerError of payload: BrapiGetDevtoolsJsonTarget_InternalServerError

type BrapiPutDevtoolsJsonNew_OK =
    { ///Target description.
      description: Option<string>
      ///DevTools frontend URL.
      devtoolsFrontendUrl: Option<string>
      ///Target ID.
      id: string
      ///Title of the target.
      title: Option<string>
      ///Target type (page, background_page, worker, etc.).
      ``type``: string
      ///URL of the target.
      url: string
      ///WebSocket URL for debugging this target.
      webSocketDebuggerUrl: Option<string> }

type BrapiPutDevtoolsJsonNew_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPutDevtoolsJsonNew_BadRequest =
    { errors: Option<list<BrapiPutDevtoolsJsonNew_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiPutDevtoolsJsonNew_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPutDevtoolsJsonNew_InternalServerError =
    { errors: Option<list<BrapiPutDevtoolsJsonNew_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPutDevtoolsJsonNew =
    ///Information about the newly created tab.
    | OK of payload: BrapiPutDevtoolsJsonNew_OK
    ///Bad request.
    | BadRequest of payload: BrapiPutDevtoolsJsonNew_BadRequest
    ///Internal server error.
    | InternalServerError of payload: BrapiPutDevtoolsJsonNew_InternalServerError

type Domains =
    { ///Available commands.
      commands: Option<obj>
      ///Domain dependencies.
      dependencies: Option<list<string>>
      ///Domain name.
      domain: string
      ///Available events.
      events: Option<obj>
      ///Whether this domain is experimental.
      experimental: Option<bool>
      ///Type definitions.
      types: Option<obj> }

///Protocol version.
type Version =
    { ///Major version.
      major: string
      ///Minor version.
      minor: string }

type BrapiGetDevtoolsJsonProtocol_OK =
    { ///List of protocol domains.
      domains: list<Domains>
      ///Protocol version.
      version: Option<Version> }

type BrapiGetDevtoolsJsonProtocol_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJsonProtocol_BadRequest =
    { errors: Option<list<BrapiGetDevtoolsJsonProtocol_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiGetDevtoolsJsonProtocol_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJsonProtocol_InternalServerError =
    { errors: Option<list<BrapiGetDevtoolsJsonProtocol_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiGetDevtoolsJsonProtocol =
    ///Chrome DevTools Protocol schema.
    | OK of payload: BrapiGetDevtoolsJsonProtocol_OK
    ///Bad request.
    | BadRequest of payload: BrapiGetDevtoolsJsonProtocol_BadRequest
    ///Internal server error.
    | InternalServerError of payload: BrapiGetDevtoolsJsonProtocol_InternalServerError

type BrapiGetDevtoolsJsonVersion_OK =
    { ///Browser name and version.
      Browser: string
      ///Chrome DevTools Protocol version.
      ``Protocol-Version``: string
      ///User agent string.
      ``User-Agent``: string
      ///V8 JavaScript engine version.
      ``V8-Version``: string
      ///WebKit version.
      ``WebKit-Version``: string
      ///WebSocket URL for debugging the browser.
      webSocketDebuggerUrl: string }

type BrapiGetDevtoolsJsonVersion_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJsonVersion_BadRequest =
    { errors: Option<list<BrapiGetDevtoolsJsonVersion_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiGetDevtoolsJsonVersion_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsJsonVersion_InternalServerError =
    { errors: Option<list<BrapiGetDevtoolsJsonVersion_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiGetDevtoolsJsonVersion =
    ///Browser version information.
    | OK of payload: BrapiGetDevtoolsJsonVersion_OK
    ///Bad request.
    | BadRequest of payload: BrapiGetDevtoolsJsonVersion_BadRequest
    ///Internal server error.
    | InternalServerError of payload: BrapiGetDevtoolsJsonVersion_InternalServerError

type BrapiGetDevtoolsPage_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsPage_BadRequest =
    { errors: Option<list<BrapiGetDevtoolsPage_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiGetDevtoolsPage_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiGetDevtoolsPage_InternalServerError =
    { errors: Option<list<BrapiGetDevtoolsPage_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiGetDevtoolsPage =
    ///Bad request.
    | BadRequest of payload: BrapiGetDevtoolsPage_BadRequest
    ///Internal server error.
    | InternalServerError of payload: BrapiGetDevtoolsPage_InternalServerError
    | DefaultResponse

type BrapiGetDevtoolsSessionList_OK =
    { ///Reason for session closure.
      closeReason: Option<string>
      ///Human-readable close reason.
      closeReasonText: Option<string>
      ///Connection end time.
      connectionEndTime: Option<float>
      ///Connection ID.
      connectionId: Option<string>
      ///Connection start time.
      connectionStartTime: Option<float>
      ///DevTools frontend URL.
      devtoolsFrontendUrl: Option<string>
      ///Session end time.
      endTime: Option<float>
      ///Last updated timestamp.
      lastUpdated: Option<float>
      ///Session ID.
      sessionId: System.Guid
      ///Session start time.
      startTime: Option<float>
      ///WebSocket URL for debugging this target.
      webSocketDebuggerUrl: Option<string> }

[<RequireQualifiedAccess>]
type BrapiGetDevtoolsSessionList =
    ///Returns the account's sessions.
    | OK of payload: list<BrapiGetDevtoolsSessionList_OK>
    ///Internal server error.
    | InternalServerError of payload: obj

type BrapiGetDevtoolsSessionDetails_OK =
    { ///Reason for session closure.
      closeReason: Option<string>
      ///Human-readable close reason.
      closeReasonText: Option<string>
      ///Connection end time.
      connectionEndTime: Option<float>
      ///Connection ID.
      connectionId: Option<string>
      ///Connection start time.
      connectionStartTime: Option<float>
      ///DevTools frontend URL.
      devtoolsFrontendUrl: Option<string>
      ///Session end time.
      endTime: Option<float>
      ///Last updated timestamp.
      lastUpdated: Option<float>
      ///Session ID.
      sessionId: System.Guid
      ///Session start time.
      startTime: Option<float>
      ///WebSocket URL for debugging this target.
      webSocketDebuggerUrl: Option<string> }

[<RequireQualifiedAccess>]
type BrapiGetDevtoolsSessionDetails =
    ///Returns the session details.
    | OK of payload: BrapiGetDevtoolsSessionDetails_OK
    ///Session not found.
    | NotFound of payload: obj

type BrapiPostJson_OKErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostJson_OK =
    { errors: Option<list<BrapiPostJson_OKErrors>>
      result: Map<string, Option<string>>
      ///Response status.
      success: bool }

type BrapiPostJson_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostJson_BadRequest =
    { errors: Option<list<BrapiPostJson_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiPostJson_UnprocessableEntityErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostJson_UnprocessableEntity =
    { errors: Option<list<BrapiPostJson_UnprocessableEntityErrors>>
      ///Raw AI response will be returned, if it couldn't be parsed into valid JSON.
      rawAiResponse: Option<string>
      ///Response status.
      success: bool }

type BrapiPostJson_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostJson_InternalServerError =
    { errors: Option<list<BrapiPostJson_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostJson =
    ///Returns the JSON based on a user prompt or JSON schema.
    | OK of payload: BrapiPostJson_OK
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostJson_BadRequest
    ///Request failed due to site-related issues such as timeouts, SSL errors, or inaccessible content.
    | UnprocessableEntity of payload: BrapiPostJson_UnprocessableEntity
    ///Internal server error.
    | InternalServerError of payload: BrapiPostJson_InternalServerError

type BrapiPostLinks_OKErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostLinks_OK =
    { errors: Option<list<BrapiPostLinks_OKErrors>>
      result: list<string>
      ///Response status.
      success: bool }

type BrapiPostLinks_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostLinks_BadRequest =
    { errors: Option<list<BrapiPostLinks_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiPostLinks_UnprocessableEntityErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostLinks_UnprocessableEntity =
    { errors: Option<list<BrapiPostLinks_UnprocessableEntityErrors>>
      ///Response status.
      success: bool }

type BrapiPostLinks_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostLinks_InternalServerError =
    { errors: Option<list<BrapiPostLinks_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostLinks =
    ///Returns the links.
    | OK of payload: BrapiPostLinks_OK
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostLinks_BadRequest
    ///Request failed due to site-related issues such as timeouts, SSL errors, or inaccessible content.
    | UnprocessableEntity of payload: BrapiPostLinks_UnprocessableEntity
    ///Internal server error.
    | InternalServerError of payload: BrapiPostLinks_InternalServerError

type BrapiPostMarkdown_OKErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostMarkdown_OK =
    { errors: Option<list<BrapiPostMarkdown_OKErrors>>
      ///Markdown content.
      result: Option<string>
      ///Response status.
      success: bool }

type BrapiPostMarkdown_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostMarkdown_BadRequest =
    { errors: Option<list<BrapiPostMarkdown_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiPostMarkdown_UnprocessableEntityErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostMarkdown_UnprocessableEntity =
    { errors: Option<list<BrapiPostMarkdown_UnprocessableEntityErrors>>
      ///Response status.
      success: bool }

type BrapiPostMarkdown_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostMarkdown_InternalServerError =
    { errors: Option<list<BrapiPostMarkdown_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostMarkdown =
    ///Returns the page markdown.
    | OK of payload: BrapiPostMarkdown_OK
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostMarkdown_BadRequest
    ///Request failed due to site-related issues such as timeouts, SSL errors, or inaccessible content.
    | UnprocessableEntity of payload: BrapiPostMarkdown_UnprocessableEntity
    ///Internal server error.
    | InternalServerError of payload: BrapiPostMarkdown_InternalServerError

type BrapiPostPdf_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostPdf_BadRequest =
    { errors: Option<list<BrapiPostPdf_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiPostPdf_UnprocessableEntityErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostPdf_UnprocessableEntity =
    { errors: Option<list<BrapiPostPdf_UnprocessableEntityErrors>>
      ///Response status.
      success: bool }

type BrapiPostPdf_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostPdf_InternalServerError =
    { errors: Option<list<BrapiPostPdf_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostPdf =
    ///Returns the PDF.
    | OK of payload: string
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostPdf_BadRequest
    ///Request failed due to site-related issues such as timeouts, SSL errors, or inaccessible content.
    | UnprocessableEntity of payload: BrapiPostPdf_UnprocessableEntity
    ///Internal server error.
    | InternalServerError of payload: BrapiPostPdf_InternalServerError

type BrapiPostScrape_OKErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type Attributes =
    { ///Attribute name.
      name: string
      ///Attribute value.
      value: string }

type Results =
    { attributes: list<Attributes>
      ///Element height.
      height: float
      ///HTML content.
      html: string
      ///Element left.
      left: float
      ///Text content.
      text: string
      ///Element top.
      top: float
      ///Element width.
      width: float }

type BrapiPostScrape_OKResult =
    { results: Results
      ///Selector.
      selector: string }

type BrapiPostScrape_OK =
    { errors: Option<list<BrapiPostScrape_OKErrors>>
      result: list<BrapiPostScrape_OKResult>
      ///Response status.
      success: bool }

type BrapiPostScrape_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostScrape_BadRequest =
    { errors: Option<list<BrapiPostScrape_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiPostScrape_UnprocessableEntityErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostScrape_UnprocessableEntity =
    { errors: Option<list<BrapiPostScrape_UnprocessableEntityErrors>>
      ///Response status.
      success: bool }

type BrapiPostScrape_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostScrape_InternalServerError =
    { errors: Option<list<BrapiPostScrape_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostScrape =
    ///Returns the scraped elements.
    | OK of payload: BrapiPostScrape_OK
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostScrape_BadRequest
    ///Request failed due to site-related issues such as timeouts, SSL errors, or inaccessible content.
    | UnprocessableEntity of payload: BrapiPostScrape_UnprocessableEntity
    ///Internal server error.
    | InternalServerError of payload: BrapiPostScrape_InternalServerError

type BrapiPostScreenshot_OKErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostScreenshot_OK =
    { errors: Option<list<BrapiPostScreenshot_OKErrors>>
      ///Response status.
      success: bool }

type BrapiPostScreenshot_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostScreenshot_BadRequest =
    { errors: Option<list<BrapiPostScreenshot_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiPostScreenshot_UnprocessableEntityErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostScreenshot_UnprocessableEntity =
    { errors: Option<list<BrapiPostScreenshot_UnprocessableEntityErrors>>
      ///Response status.
      success: bool }

type BrapiPostScreenshot_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostScreenshot_InternalServerError =
    { errors: Option<list<BrapiPostScreenshot_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostScreenshot =
    ///Returns the screenshot.
    | OK of payload: BrapiPostScreenshot_OK
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostScreenshot_BadRequest
    ///Request failed due to site-related issues such as timeouts, SSL errors, or inaccessible content.
    | UnprocessableEntity of payload: BrapiPostScreenshot_UnprocessableEntity
    ///Internal server error.
    | InternalServerError of payload: BrapiPostScreenshot_InternalServerError

type BrapiPostSnapshot_OKErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostSnapshot_OKMeta =
    { status: Option<float>
      title: Option<string> }

type BrapiPostSnapshot_OKResult =
    { ///HTML content.
      content: string
      ///Base64 encoded image.
      screenshot: string }

type BrapiPostSnapshot_OK =
    { errors: Option<list<BrapiPostSnapshot_OKErrors>>
      meta: BrapiPostSnapshot_OKMeta
      result: Option<BrapiPostSnapshot_OKResult>
      ///Response status.
      success: bool }

type BrapiPostSnapshot_BadRequestErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostSnapshot_BadRequest =
    { errors: Option<list<BrapiPostSnapshot_BadRequestErrors>>
      ///Response status.
      success: bool }

type BrapiPostSnapshot_UnprocessableEntityErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostSnapshot_UnprocessableEntity =
    { errors: Option<list<BrapiPostSnapshot_UnprocessableEntityErrors>>
      ///Response status.
      success: bool }

type BrapiPostSnapshot_InternalServerErrorErrors =
    { ///Error code.
      code: float
      ///Error message.
      message: string }

type BrapiPostSnapshot_InternalServerError =
    { errors: Option<list<BrapiPostSnapshot_InternalServerErrorErrors>>
      ///Response status.
      success: bool }

[<RequireQualifiedAccess>]
type BrapiPostSnapshot =
    ///Returns the screenshot.
    | OK of payload: BrapiPostSnapshot_OK
    ///The request contains errors or didn't properly encode content.
    | BadRequest of payload: BrapiPostSnapshot_BadRequest
    ///Request failed due to site-related issues such as timeouts, SSL errors, or inaccessible content.
    | UnprocessableEntity of payload: BrapiPostSnapshot_UnprocessableEntity
    ///Internal server error.
    | InternalServerError of payload: BrapiPostSnapshot_InternalServerError
