namespace rec Fidelity.CloudEdge.Management.AI.Types

// Auto-generated stub types (missing from Hawaii output)
type provided = string
type strings = string
type tokens = string

type Result =
    { created_at: System.DateTimeOffset
      description: string
      enable: bool
      id: string
      mandatory: bool
      modified_at: System.DateTimeOffset
      name: string
      ``type``: string }

type Resultinfo =
    { count: float
      page: float
      per_page: float
      total_count: float }

type AigConfigListEvaluators_OK =
    { result: list<Result>
      result_info: Resultinfo
      success: bool }

type Errors = { message: string }

type AigConfigListEvaluators_BadRequest =
    { errors: list<Errors>
      result: list<obj>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListEvaluators =
    ///Returns a list of Evaluators
    | OK of payload: AigConfigListEvaluators_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListEvaluators_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Logmanagementstrategy =
    | [<CompiledName "STOP_INSERTING">] STOP_INSERTING
    | [<CompiledName "DELETE_OLDEST">] DELETE_OLDEST
    member this.Format() =
        match this with
        | STOP_INSERTING -> "STOP_INSERTING"
        | DELETE_OLDEST -> "DELETE_OLDEST"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Contenttype =
    | [<CompiledName "json">] Json
    | [<CompiledName "protobuf">] Protobuf
    member this.Format() =
        match this with
        | Json -> "json"
        | Protobuf -> "protobuf"

type Otel =
    { authorization: string
      content_type: Option<Contenttype>
      headers: Map<string, string>
      url: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Ratelimitingtechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Retrybackoff =
    | [<CompiledName "constant">] Constant
    | [<CompiledName "linear">] Linear
    | [<CompiledName "exponential">] Exponential
    member this.Format() =
        match this with
        | Constant -> "constant"
        | Linear -> "linear"
        | Exponential -> "exponential"

type Usageevents = { payload: string }

type Stripe =
    { authorization: string
      usage_events: list<Usageevents> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Workersaibillingmode =
    | [<CompiledName "postpaid">] Postpaid
    member this.Format() =
        match this with
        | Postpaid -> "postpaid"

type AigConfigListGateway_OKResult =
    { authentication: Option<bool>
      cache_invalidate_on_update: bool
      cache_ttl: int
      collect_logs: bool
      created_at: System.DateTimeOffset
      dlp: Option<obj>
      ///gateway id
      id: string
      is_default: Option<bool>
      log_management: Option<int>
      log_management_strategy: Option<Logmanagementstrategy>
      logpush: Option<bool>
      logpush_public_key: Option<string>
      modified_at: System.DateTimeOffset
      otel: Option<list<Otel>>
      rate_limiting_interval: int
      rate_limiting_limit: int
      rate_limiting_technique: Option<Ratelimitingtechnique>
      ///Backoff strategy for retry delays
      retry_backoff: Option<Retrybackoff>
      ///Delay between retry attempts in milliseconds (0-5000)
      retry_delay: Option<int>
      ///Maximum number of retry attempts for failed requests (1-5)
      retry_max_attempts: Option<int>
      store_id: Option<string>
      stripe: Option<Stripe>
      ///Controls how Workers AI inference calls routed through this gateway are billed. Only 'postpaid' is currently supported.
      workers_ai_billing_mode: Option<Workersaibillingmode>
      zdr: Option<bool> }

type AigConfigListGateway_OK =
    { result: list<AigConfigListGateway_OKResult>
      success: bool }

type AigConfigListGateway_BadRequestErrors = { message: string }

type AigConfigListGateway_BadRequest =
    { errors: list<AigConfigListGateway_BadRequestErrors>
      result: list<obj>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListGateway =
    ///List objects
    | OK of payload: AigConfigListGateway_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListGateway_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateGatewayPayloadLogmanagementstrategy =
    | [<CompiledName "STOP_INSERTING">] STOP_INSERTING
    | [<CompiledName "DELETE_OLDEST">] DELETE_OLDEST
    member this.Format() =
        match this with
        | STOP_INSERTING -> "STOP_INSERTING"
        | DELETE_OLDEST -> "DELETE_OLDEST"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateGatewayPayloadRatelimitingtechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateGatewayPayloadRetrybackoff =
    | [<CompiledName "constant">] Constant
    | [<CompiledName "linear">] Linear
    | [<CompiledName "exponential">] Exponential
    member this.Format() =
        match this with
        | Constant -> "constant"
        | Linear -> "linear"
        | Exponential -> "exponential"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateGatewayPayloadWorkersaibillingmode =
    | [<CompiledName "postpaid">] Postpaid
    member this.Format() =
        match this with
        | Postpaid -> "postpaid"

type AigConfigCreateGatewayPayload =
    { authentication: Option<bool>
      cache_invalidate_on_update: bool
      cache_ttl: int
      collect_logs: bool
      ///gateway id
      id: string
      log_management: Option<int>
      log_management_strategy: Option<AigConfigCreateGatewayPayloadLogmanagementstrategy>
      logpush: Option<bool>
      logpush_public_key: Option<string>
      rate_limiting_interval: int
      rate_limiting_limit: int
      rate_limiting_technique: Option<AigConfigCreateGatewayPayloadRatelimitingtechnique>
      ///Backoff strategy for retry delays
      retry_backoff: Option<AigConfigCreateGatewayPayloadRetrybackoff>
      ///Delay between retry attempts in milliseconds (0-5000)
      retry_delay: Option<int>
      ///Maximum number of retry attempts for failed requests (1-5)
      retry_max_attempts: Option<int>
      ///Controls how Workers AI inference calls routed through this gateway are billed. Only 'postpaid' is currently supported.
      workers_ai_billing_mode: Option<AigConfigCreateGatewayPayloadWorkersaibillingmode>
      zdr: Option<bool> }
    ///Creates an instance of AigConfigCreateGatewayPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cache_invalidate_on_update: bool,
                          cache_ttl: int,
                          collect_logs: bool,
                          id: string,
                          rate_limiting_interval: int,
                          rate_limiting_limit: int): AigConfigCreateGatewayPayload =
        { authentication = None
          cache_invalidate_on_update = cache_invalidate_on_update
          cache_ttl = cache_ttl
          collect_logs = collect_logs
          id = id
          log_management = None
          log_management_strategy = None
          logpush = None
          logpush_public_key = None
          rate_limiting_interval = rate_limiting_interval
          rate_limiting_limit = rate_limiting_limit
          rate_limiting_technique = None
          retry_backoff = None
          retry_delay = None
          retry_max_attempts = None
          workers_ai_billing_mode = None
          zdr = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateGateway_OKResultLogmanagementstrategy =
    | [<CompiledName "STOP_INSERTING">] STOP_INSERTING
    | [<CompiledName "DELETE_OLDEST">] DELETE_OLDEST
    member this.Format() =
        match this with
        | STOP_INSERTING -> "STOP_INSERTING"
        | DELETE_OLDEST -> "DELETE_OLDEST"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateGateway_OKResultOtelContenttype =
    | [<CompiledName "json">] Json
    | [<CompiledName "protobuf">] Protobuf
    member this.Format() =
        match this with
        | Json -> "json"
        | Protobuf -> "protobuf"

type AigConfigCreateGateway_OKResultOtel =
    { authorization: string
      content_type: Option<AigConfigCreateGateway_OKResultOtelContenttype>
      headers: Map<string, string>
      url: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateGateway_OKResultRatelimitingtechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateGateway_OKResultRetrybackoff =
    | [<CompiledName "constant">] Constant
    | [<CompiledName "linear">] Linear
    | [<CompiledName "exponential">] Exponential
    member this.Format() =
        match this with
        | Constant -> "constant"
        | Linear -> "linear"
        | Exponential -> "exponential"

type AigConfigCreateGateway_OKResultStripeUsageevents = { payload: string }

type AigConfigCreateGateway_OKResultStripe =
    { authorization: string
      usage_events: list<AigConfigCreateGateway_OKResultStripeUsageevents> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateGateway_OKResultWorkersaibillingmode =
    | [<CompiledName "postpaid">] Postpaid
    member this.Format() =
        match this with
        | Postpaid -> "postpaid"

type AigConfigCreateGateway_OKResult =
    { authentication: Option<bool>
      cache_invalidate_on_update: bool
      cache_ttl: int
      collect_logs: bool
      created_at: System.DateTimeOffset
      dlp: Option<obj>
      ///gateway id
      id: string
      is_default: Option<bool>
      log_management: Option<int>
      log_management_strategy: Option<AigConfigCreateGateway_OKResultLogmanagementstrategy>
      logpush: Option<bool>
      logpush_public_key: Option<string>
      modified_at: System.DateTimeOffset
      otel: Option<list<AigConfigCreateGateway_OKResultOtel>>
      rate_limiting_interval: int
      rate_limiting_limit: int
      rate_limiting_technique: Option<AigConfigCreateGateway_OKResultRatelimitingtechnique>
      ///Backoff strategy for retry delays
      retry_backoff: Option<AigConfigCreateGateway_OKResultRetrybackoff>
      ///Delay between retry attempts in milliseconds (0-5000)
      retry_delay: Option<int>
      ///Maximum number of retry attempts for failed requests (1-5)
      retry_max_attempts: Option<int>
      store_id: Option<string>
      stripe: Option<AigConfigCreateGateway_OKResultStripe>
      ///Controls how Workers AI inference calls routed through this gateway are billed. Only 'postpaid' is currently supported.
      workers_ai_billing_mode: Option<AigConfigCreateGateway_OKResultWorkersaibillingmode>
      zdr: Option<bool> }

type AigConfigCreateGateway_OK =
    { result: AigConfigCreateGateway_OKResult
      success: bool }

type AigConfigCreateGateway_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AigConfigCreateGateway_BadRequest =
    { errors: list<AigConfigCreateGateway_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigCreateGateway =
    ///Returns the created Object
    | OK of payload: AigConfigCreateGateway_OK
    ///Input Validation Error
    | BadRequest of payload: AigConfigCreateGateway_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Key =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Operator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type Filters =
    { key: Key
      operator: Operator
      value: list<string> }

type AigConfigListDataset_OKResult =
    { created_at: System.DateTimeOffset
      enable: bool
      filters: list<Filters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigListDataset_OK =
    { result: list<AigConfigListDataset_OKResult>
      success: bool }

type AigConfigListDataset_BadRequestErrors = { message: string }

type AigConfigListDataset_BadRequest =
    { errors: list<AigConfigListDataset_BadRequestErrors>
      result: list<obj>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListDataset =
    ///List objects
    | OK of payload: AigConfigListDataset_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListDataset_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateDatasetPayloadFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateDatasetPayloadFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigCreateDatasetPayloadFilters =
    { key: AigConfigCreateDatasetPayloadFiltersKey
      operator: AigConfigCreateDatasetPayloadFiltersOperator
      value: list<string> }
    ///Creates an instance of AigConfigCreateDatasetPayloadFilters with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (key: AigConfigCreateDatasetPayloadFiltersKey,
                          operator: AigConfigCreateDatasetPayloadFiltersOperator,
                          value: list<string>): AigConfigCreateDatasetPayloadFilters =
        { key = key
          operator = operator
          value = value }

type AigConfigCreateDatasetPayload =
    { enable: bool
      filters: list<AigConfigCreateDatasetPayloadFilters>
      name: string }
    ///Creates an instance of AigConfigCreateDatasetPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enable: bool, filters: list<AigConfigCreateDatasetPayloadFilters>, name: string): AigConfigCreateDatasetPayload =
        { enable = enable
          filters = filters
          name = name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateDataset_OKResultFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateDataset_OKResultFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigCreateDataset_OKResultFilters =
    { key: AigConfigCreateDataset_OKResultFiltersKey
      operator: AigConfigCreateDataset_OKResultFiltersOperator
      value: list<string> }

type AigConfigCreateDataset_OKResult =
    { created_at: System.DateTimeOffset
      enable: bool
      filters: list<AigConfigCreateDataset_OKResultFilters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigCreateDataset_OK =
    { result: AigConfigCreateDataset_OKResult
      success: bool }

type AigConfigCreateDataset_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AigConfigCreateDataset_BadRequest =
    { errors: list<AigConfigCreateDataset_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigCreateDataset =
    ///Returns the created Object
    | OK of payload: AigConfigCreateDataset_OK
    ///Input Validation Error
    | BadRequest of payload: AigConfigCreateDataset_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteDataset_OKResultFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteDataset_OKResultFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigDeleteDataset_OKResultFilters =
    { key: AigConfigDeleteDataset_OKResultFiltersKey
      operator: AigConfigDeleteDataset_OKResultFiltersOperator
      value: list<string> }

type AigConfigDeleteDataset_OKResult =
    { created_at: System.DateTimeOffset
      enable: bool
      filters: list<AigConfigDeleteDataset_OKResultFilters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigDeleteDataset_OK =
    { result: AigConfigDeleteDataset_OKResult
      success: bool }

type AigConfigDeleteDataset_NotFoundErrors = { code: float; message: string }

type AigConfigDeleteDataset_NotFound =
    { errors: list<AigConfigDeleteDataset_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigDeleteDataset =
    ///Returns the Object if it was successfully deleted
    | OK of payload: AigConfigDeleteDataset_OK
    ///Not Found
    | NotFound of payload: AigConfigDeleteDataset_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchDataset_OKResultFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchDataset_OKResultFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigFetchDataset_OKResultFilters =
    { key: AigConfigFetchDataset_OKResultFiltersKey
      operator: AigConfigFetchDataset_OKResultFiltersOperator
      value: list<string> }

type AigConfigFetchDataset_OKResult =
    { created_at: System.DateTimeOffset
      enable: bool
      filters: list<AigConfigFetchDataset_OKResultFilters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigFetchDataset_OK =
    { result: AigConfigFetchDataset_OKResult
      success: bool }

type AigConfigFetchDataset_NotFoundErrors = { code: float; message: string }

type AigConfigFetchDataset_NotFound =
    { errors: list<AigConfigFetchDataset_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigFetchDataset =
    ///Returns a single object if found
    | OK of payload: AigConfigFetchDataset_OK
    ///Not Found
    | NotFound of payload: AigConfigFetchDataset_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateDatasetPayloadFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateDatasetPayloadFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigUpdateDatasetPayloadFilters =
    { key: AigConfigUpdateDatasetPayloadFiltersKey
      operator: AigConfigUpdateDatasetPayloadFiltersOperator
      value: list<string> }
    ///Creates an instance of AigConfigUpdateDatasetPayloadFilters with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (key: AigConfigUpdateDatasetPayloadFiltersKey,
                          operator: AigConfigUpdateDatasetPayloadFiltersOperator,
                          value: list<string>): AigConfigUpdateDatasetPayloadFilters =
        { key = key
          operator = operator
          value = value }

type AigConfigUpdateDatasetPayload =
    { enable: bool
      filters: list<AigConfigUpdateDatasetPayloadFilters>
      name: string }
    ///Creates an instance of AigConfigUpdateDatasetPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enable: bool, filters: list<AigConfigUpdateDatasetPayloadFilters>, name: string): AigConfigUpdateDatasetPayload =
        { enable = enable
          filters = filters
          name = name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateDataset_OKResultFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateDataset_OKResultFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigUpdateDataset_OKResultFilters =
    { key: AigConfigUpdateDataset_OKResultFiltersKey
      operator: AigConfigUpdateDataset_OKResultFiltersOperator
      value: list<string> }

type AigConfigUpdateDataset_OKResult =
    { created_at: System.DateTimeOffset
      enable: bool
      filters: list<AigConfigUpdateDataset_OKResultFilters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigUpdateDataset_OK =
    { result: AigConfigUpdateDataset_OKResult
      success: bool }

type AigConfigUpdateDataset_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AigConfigUpdateDataset_BadRequest =
    { errors: list<AigConfigUpdateDataset_BadRequestErrors>
      success: bool }

type AigConfigUpdateDataset_NotFoundErrors = { code: float; message: string }

type AigConfigUpdateDataset_NotFound =
    { errors: list<AigConfigUpdateDataset_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigUpdateDataset =
    ///Returns the updated Object
    | OK of payload: AigConfigUpdateDataset_OK
    ///Input Validation Error
    | BadRequest of payload: AigConfigUpdateDataset_BadRequest
    ///Not Found
    | NotFound of payload: AigConfigUpdateDataset_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DatasetsFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DatasetsFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type DatasetsFilters =
    { key: DatasetsFiltersKey
      operator: DatasetsFiltersOperator
      value: list<string> }

type Datasets =
    { account_id: string
      account_tag: string
      created_at: System.DateTimeOffset
      enable: bool
      filters: list<DatasetsFilters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type Results =
    { created_at: System.DateTimeOffset
      evaluation_id: string
      evaluation_type_id: string
      id: string
      modified_at: System.DateTimeOffset
      result: string
      status: float
      status_description: string
      total_logs: float }

type AigConfigListEvaluations_OKResult =
    { created_at: System.DateTimeOffset
      datasets: list<Datasets>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      processed: bool
      results: list<Results>
      total_logs: float }

type AigConfigListEvaluations_OK =
    { result: list<AigConfigListEvaluations_OKResult>
      success: bool }

type AigConfigListEvaluations_BadRequestErrors = { message: string }

type AigConfigListEvaluations_BadRequest =
    { errors: list<AigConfigListEvaluations_BadRequestErrors>
      result: list<obj>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListEvaluations =
    ///List objects
    | OK of payload: AigConfigListEvaluations_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListEvaluations_BadRequest

type AigConfigCreateEvaluationsPayload =
    { dataset_ids: list<string>
      evaluation_type_ids: list<string>
      name: string }
    ///Creates an instance of AigConfigCreateEvaluationsPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (dataset_ids: list<string>, evaluation_type_ids: list<string>, name: string): AigConfigCreateEvaluationsPayload =
        { dataset_ids = dataset_ids
          evaluation_type_ids = evaluation_type_ids
          name = name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateEvaluations_OKResultDatasetsFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigCreateEvaluations_OKResultDatasetsFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigCreateEvaluations_OKResultDatasetsFilters =
    { key: AigConfigCreateEvaluations_OKResultDatasetsFiltersKey
      operator: AigConfigCreateEvaluations_OKResultDatasetsFiltersOperator
      value: list<string> }

type AigConfigCreateEvaluations_OKResultDatasets =
    { account_id: string
      account_tag: string
      created_at: System.DateTimeOffset
      enable: bool
      filters: list<AigConfigCreateEvaluations_OKResultDatasetsFilters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigCreateEvaluations_OKResultResults =
    { created_at: System.DateTimeOffset
      evaluation_id: string
      evaluation_type_id: string
      id: string
      modified_at: System.DateTimeOffset
      result: string
      status: float
      status_description: string
      total_logs: float }

type AigConfigCreateEvaluations_OKResult =
    { created_at: System.DateTimeOffset
      datasets: list<AigConfigCreateEvaluations_OKResultDatasets>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      processed: bool
      results: list<AigConfigCreateEvaluations_OKResultResults>
      total_logs: float }

type AigConfigCreateEvaluations_OK =
    { result: AigConfigCreateEvaluations_OKResult
      success: bool }

type AigConfigCreateEvaluations_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AigConfigCreateEvaluations_BadRequest =
    { errors: list<AigConfigCreateEvaluations_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigCreateEvaluations =
    ///Returns the created Object
    | OK of payload: AigConfigCreateEvaluations_OK
    ///Input Validation Error
    | BadRequest of payload: AigConfigCreateEvaluations_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteEvaluations_OKResultDatasetsFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteEvaluations_OKResultDatasetsFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigDeleteEvaluations_OKResultDatasetsFilters =
    { key: AigConfigDeleteEvaluations_OKResultDatasetsFiltersKey
      operator: AigConfigDeleteEvaluations_OKResultDatasetsFiltersOperator
      value: list<string> }

type AigConfigDeleteEvaluations_OKResultDatasets =
    { account_id: string
      account_tag: string
      created_at: System.DateTimeOffset
      enable: bool
      filters: list<AigConfigDeleteEvaluations_OKResultDatasetsFilters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigDeleteEvaluations_OKResultResults =
    { created_at: System.DateTimeOffset
      evaluation_id: string
      evaluation_type_id: string
      id: string
      modified_at: System.DateTimeOffset
      result: string
      status: float
      status_description: string
      total_logs: float }

type AigConfigDeleteEvaluations_OKResult =
    { created_at: System.DateTimeOffset
      datasets: list<AigConfigDeleteEvaluations_OKResultDatasets>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      processed: bool
      results: list<AigConfigDeleteEvaluations_OKResultResults>
      total_logs: float }

type AigConfigDeleteEvaluations_OK =
    { result: AigConfigDeleteEvaluations_OKResult
      success: bool }

type AigConfigDeleteEvaluations_NotFoundErrors = { code: float; message: string }

type AigConfigDeleteEvaluations_NotFound =
    { errors: list<AigConfigDeleteEvaluations_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigDeleteEvaluations =
    ///Returns the Object if it was successfully deleted
    | OK of payload: AigConfigDeleteEvaluations_OK
    ///Not Found
    | NotFound of payload: AigConfigDeleteEvaluations_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchEvaluations_OKResultDatasetsFiltersKey =
    | [<CompiledName "created_at">] Created_at
    | [<CompiledName "request_content_type">] Request_content_type
    | [<CompiledName "response_content_type">] Response_content_type
    | [<CompiledName "success">] Success
    | [<CompiledName "cached">] Cached
    | [<CompiledName "provider">] Provider
    | [<CompiledName "model">] Model
    | [<CompiledName "cost">] Cost
    | [<CompiledName "tokens">] Tokens
    | [<CompiledName "tokens_in">] Tokens_in
    | [<CompiledName "tokens_out">] Tokens_out
    | [<CompiledName "duration">] Duration
    | [<CompiledName "feedback">] Feedback
    member this.Format() =
        match this with
        | Created_at -> "created_at"
        | Request_content_type -> "request_content_type"
        | Response_content_type -> "response_content_type"
        | Success -> "success"
        | Cached -> "cached"
        | Provider -> "provider"
        | Model -> "model"
        | Cost -> "cost"
        | Tokens -> "tokens"
        | Tokens_in -> "tokens_in"
        | Tokens_out -> "tokens_out"
        | Duration -> "duration"
        | Feedback -> "feedback"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchEvaluations_OKResultDatasetsFiltersOperator =
    | [<CompiledName "eq">] Eq
    | [<CompiledName "contains">] Contains
    | [<CompiledName "lt">] Lt
    | [<CompiledName "gt">] Gt
    member this.Format() =
        match this with
        | Eq -> "eq"
        | Contains -> "contains"
        | Lt -> "lt"
        | Gt -> "gt"

type AigConfigFetchEvaluations_OKResultDatasetsFilters =
    { key: AigConfigFetchEvaluations_OKResultDatasetsFiltersKey
      operator: AigConfigFetchEvaluations_OKResultDatasetsFiltersOperator
      value: list<string> }

type AigConfigFetchEvaluations_OKResultDatasets =
    { account_id: string
      account_tag: string
      created_at: System.DateTimeOffset
      enable: bool
      filters: list<AigConfigFetchEvaluations_OKResultDatasetsFilters>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigFetchEvaluations_OKResultResults =
    { created_at: System.DateTimeOffset
      evaluation_id: string
      evaluation_type_id: string
      id: string
      modified_at: System.DateTimeOffset
      result: string
      status: float
      status_description: string
      total_logs: float }

type AigConfigFetchEvaluations_OKResult =
    { created_at: System.DateTimeOffset
      datasets: list<AigConfigFetchEvaluations_OKResultDatasets>
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      processed: bool
      results: list<AigConfigFetchEvaluations_OKResultResults>
      total_logs: float }

type AigConfigFetchEvaluations_OK =
    { result: AigConfigFetchEvaluations_OKResult
      success: bool }

type AigConfigFetchEvaluations_NotFoundErrors = { code: float; message: string }

type AigConfigFetchEvaluations_NotFound =
    { errors: list<AigConfigFetchEvaluations_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigFetchEvaluations =
    ///Returns a single object if found
    | OK of payload: AigConfigFetchEvaluations_OK
    ///Not Found
    | NotFound of payload: AigConfigFetchEvaluations_NotFound

type AigConfigDeleteGatewayLogs_OK = { success: bool }
type AigConfigDeleteGatewayLogs_BadRequestErrors = { message: string }

type AigConfigDeleteGatewayLogs_BadRequest =
    { errors: list<AigConfigDeleteGatewayLogs_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigDeleteGatewayLogs =
    ///Returns if the delete was successful
    | OK of payload: AigConfigDeleteGatewayLogs_OK
    ///Bad Request
    | BadRequest of payload: AigConfigDeleteGatewayLogs_BadRequest

type AigConfigListGatewayLogs_OKResult =
    { cached: bool
      cost: Option<float>
      created_at: System.DateTimeOffset
      custom_cost: Option<bool>
      duration: int
      id: string
      metadata: Option<string>
      model: string
      model_type: Option<string>
      path: string
      provider: string
      request_content_type: Option<string>
      request_type: Option<string>
      response_content_type: Option<string>
      status_code: Option<int>
      step: Option<int>
      success: bool
      tokens_in: int
      tokens_out: int }

type AigConfigListGatewayLogs_OKResultinfo =
    { count: Option<float>
      max_cost: Option<float>
      max_duration: Option<float>
      max_tokens_in: Option<float>
      max_tokens_out: Option<float>
      max_total_tokens: Option<float>
      min_cost: Option<float>
      min_duration: Option<float>
      min_tokens_in: Option<float>
      min_tokens_out: Option<float>
      min_total_tokens: Option<float>
      page: Option<float>
      per_page: Option<float>
      total_count: Option<float> }

type AigConfigListGatewayLogs_OK =
    { result: list<AigConfigListGatewayLogs_OKResult>
      result_info: AigConfigListGatewayLogs_OKResultinfo
      success: bool }

type AigConfigListGatewayLogs_BadRequestErrors = { message: string }

type AigConfigListGatewayLogs_BadRequest =
    { errors: list<AigConfigListGatewayLogs_BadRequestErrors>
      result: list<obj>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListGatewayLogs =
    ///Returns a list of Gateway Logs
    | OK of payload: AigConfigListGatewayLogs_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListGatewayLogs_BadRequest

type AigConfigGetGatewayLogDetail_OKResult =
    { cached: bool
      cost: Option<float>
      created_at: System.DateTimeOffset
      custom_cost: Option<bool>
      duration: int
      id: string
      metadata: Option<string>
      model: string
      model_type: Option<string>
      path: string
      provider: string
      request_content_type: Option<string>
      request_head: Option<string>
      request_head_complete: Option<bool>
      request_size: Option<int>
      request_type: Option<string>
      response_content_type: Option<string>
      response_head: Option<string>
      response_head_complete: Option<bool>
      response_size: Option<int>
      status_code: Option<int>
      step: Option<int>
      success: bool
      tokens_in: int
      tokens_out: int }

type AigConfigGetGatewayLogDetail_OK =
    { result: AigConfigGetGatewayLogDetail_OKResult
      success: bool }

type AigConfigGetGatewayLogDetail_NotFoundErrors = { code: float; message: string }

type AigConfigGetGatewayLogDetail_NotFound =
    { errors: list<AigConfigGetGatewayLogDetail_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigGetGatewayLogDetail =
    ///Returns the log details
    | OK of payload: AigConfigGetGatewayLogDetail_OK
    ///Not Found
    | NotFound of payload: AigConfigGetGatewayLogDetail_NotFound

type AigConfigPatchGatewayLogPayload =
    { feedback: Option<float>
      metadata: Option<Map<string, string>>
      score: Option<float> }
    ///Creates an instance of AigConfigPatchGatewayLogPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AigConfigPatchGatewayLogPayload =
        { feedback = None
          metadata = None
          score = None }

type AigConfigPatchGatewayLog_OK =
    { result: obj
      success: bool }

type AigConfigPatchGatewayLog_NotFoundErrors = { code: float; message: string }

type AigConfigPatchGatewayLog_NotFound =
    { errors: list<AigConfigPatchGatewayLog_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigPatchGatewayLog =
    ///Returns the log details
    | OK of payload: AigConfigPatchGatewayLog_OK
    ///Not Found
    | NotFound of payload: AigConfigPatchGatewayLog_NotFound

type AigConfigGetGatewayLogRequest_NotFoundErrors = { code: float; message: string }

type AigConfigGetGatewayLogRequest_NotFound =
    { errors: list<AigConfigGetGatewayLogRequest_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigGetGatewayLogRequest =
    ///Returns the request body from a specific log
    | OK of payload: obj
    ///Not Found
    | NotFound of payload: AigConfigGetGatewayLogRequest_NotFound

type AigConfigGetGatewayLogResponse_NotFoundErrors = { code: float; message: string }

type AigConfigGetGatewayLogResponse_NotFound =
    { errors: list<AigConfigGetGatewayLogResponse_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigGetGatewayLogResponse =
    ///Returns the response body from a specific log
    | OK of payload: obj
    ///Not Found
    | NotFound of payload: AigConfigGetGatewayLogResponse_NotFound

type AigConfigListProviders_OKResult =
    { alias: string
      default_config: bool
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      provider_slug: string
      rate_limit: Option<float>
      rate_limit_period: Option<float>
      secret_id: string
      secret_preview: string }

type AigConfigListProviders_OK =
    { result: list<AigConfigListProviders_OKResult>
      success: bool }

type AigConfigListProviders_BadRequestErrors = { message: string }

type AigConfigListProviders_BadRequest =
    { errors: list<AigConfigListProviders_BadRequestErrors>
      result: list<obj>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListProviders =
    ///List objects
    | OK of payload: AigConfigListProviders_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListProviders_BadRequest

type AigConfigCreateProvidersPayload =
    { alias: string
      default_config: bool
      provider_slug: string
      rate_limit: Option<float>
      rate_limit_period: Option<float>
      secret: string
      secret_id: string }
    ///Creates an instance of AigConfigCreateProvidersPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (alias: string, default_config: bool, provider_slug: string, secret: string, secret_id: string): AigConfigCreateProvidersPayload =
        { alias = alias
          default_config = default_config
          provider_slug = provider_slug
          rate_limit = None
          rate_limit_period = None
          secret = secret
          secret_id = secret_id }

type AigConfigCreateProviders_OKResult =
    { alias: string
      default_config: bool
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      provider_slug: string
      rate_limit: Option<float>
      rate_limit_period: Option<float>
      secret_id: string
      secret_preview: string }

type AigConfigCreateProviders_OK =
    { result: AigConfigCreateProviders_OKResult
      success: bool }

type AigConfigCreateProviders_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AigConfigCreateProviders_BadRequest =
    { errors: list<AigConfigCreateProviders_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigCreateProviders =
    ///Returns the created Object
    | OK of payload: AigConfigCreateProviders_OK
    ///Input Validation Error
    | BadRequest of payload: AigConfigCreateProviders_BadRequest

type AigConfigDeleteProviders_OKResult =
    { alias: string
      default_config: bool
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      provider_slug: string
      rate_limit: Option<float>
      rate_limit_period: Option<float>
      secret_id: string
      secret_preview: string }

type AigConfigDeleteProviders_OK =
    { result: AigConfigDeleteProviders_OKResult
      success: bool }

type AigConfigDeleteProviders_NotFoundErrors = { code: float; message: string }

type AigConfigDeleteProviders_NotFound =
    { errors: list<AigConfigDeleteProviders_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigDeleteProviders =
    ///Returns the Object if it was successfully deleted
    | OK of payload: AigConfigDeleteProviders_OK
    ///Not Found
    | NotFound of payload: AigConfigDeleteProviders_NotFound

type AigConfigUpdateProvidersPayload =
    { secret: string }
    ///Creates an instance of AigConfigUpdateProvidersPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (secret: string): AigConfigUpdateProvidersPayload = { secret = secret }

type AigConfigUpdateProviders_OKResult =
    { alias: string
      default_config: bool
      ///gateway id
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      provider_slug: string
      rate_limit: Option<float>
      rate_limit_period: Option<float>
      secret_id: string
      secret_preview: string }

type AigConfigUpdateProviders_OK =
    { result: AigConfigUpdateProviders_OKResult
      success: bool }

type AigConfigUpdateProviders_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AigConfigUpdateProviders_BadRequest =
    { errors: list<AigConfigUpdateProviders_BadRequestErrors>
      success: bool }

type AigConfigUpdateProviders_NotFoundErrors = { code: float; message: string }

type AigConfigUpdateProviders_NotFound =
    { errors: list<AigConfigUpdateProviders_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigUpdateProviders =
    ///Returns the updated Object
    | OK of payload: AigConfigUpdateProviders_OK
    ///Input Validation Error
    | BadRequest of payload: AigConfigUpdateProviders_BadRequest
    ///Not Found
    | NotFound of payload: AigConfigUpdateProviders_NotFound

type Deployment =
    { created_at: string
      deployment_id: string
      version_id: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Active =
    | [<CompiledName "true">] True
    | [<CompiledName "false">] False
    member this.Format() =
        match this with
        | True -> "true"
        | False -> "false"

type Version =
    { active: Active
      created_at: string
      data: string
      version_id: string }

type Routes =
    { account_tag: string
      created_at: System.DateTimeOffset
      deployment: Deployment
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      version: Version }

type Data =
    { order_by: string
      order_by_direction: string
      page: float
      per_page: float
      routes: list<Routes> }

type AigConfigListGatewayDynamicRoutes_OK = { data: Data; success: bool }
type AigConfigListGatewayDynamicRoutes_BadRequestErrors = { message: string }

type AigConfigListGatewayDynamicRoutes_BadRequest =
    { errors: list<AigConfigListGatewayDynamicRoutes_BadRequestErrors>
      result: list<obj>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListGatewayDynamicRoutes =
    ///Success
    | OK of payload: AigConfigListGatewayDynamicRoutes_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListGatewayDynamicRoutes_BadRequest

type AigConfigPostGatewayDynamicRoutePayload =
    { elements: list<string>
      name: string }
    ///Creates an instance of AigConfigPostGatewayDynamicRoutePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (elements: list<string>, name: string): AigConfigPostGatewayDynamicRoutePayload =
        { elements = elements; name = name }

type AigConfigPostGatewayDynamicRoute_OKResultDeployment =
    { created_at: string
      deployment_id: string
      version_id: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigPostGatewayDynamicRoute_OKResultVersionActive =
    | [<CompiledName "true">] True
    | [<CompiledName "false">] False
    member this.Format() =
        match this with
        | True -> "true"
        | False -> "false"

type AigConfigPostGatewayDynamicRoute_OKResultVersion =
    { active: AigConfigPostGatewayDynamicRoute_OKResultVersionActive
      created_at: string
      data: string
      version_id: string }

type AigConfigPostGatewayDynamicRoute_OKResult =
    { created_at: System.DateTimeOffset
      deployment: AigConfigPostGatewayDynamicRoute_OKResultDeployment
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      version: AigConfigPostGatewayDynamicRoute_OKResultVersion }

type AigConfigPostGatewayDynamicRoute_OK =
    { result: AigConfigPostGatewayDynamicRoute_OKResult
      success: bool }

type AigConfigPostGatewayDynamicRoute_BadRequestErrors = { message: string }

type AigConfigPostGatewayDynamicRoute_BadRequest =
    { errors: list<AigConfigPostGatewayDynamicRoute_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigPostGatewayDynamicRoute =
    ///Success
    | OK of payload: AigConfigPostGatewayDynamicRoute_OK
    ///Bad Request
    | BadRequest of payload: AigConfigPostGatewayDynamicRoute_BadRequest

type AigConfigDeleteGatewayDynamicRoute_OKResult =
    { created_at: System.DateTimeOffset
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigDeleteGatewayDynamicRoute_OK =
    { result: AigConfigDeleteGatewayDynamicRoute_OKResult
      success: bool }

type AigConfigDeleteGatewayDynamicRoute_BadRequestErrors = { message: string }

type AigConfigDeleteGatewayDynamicRoute_BadRequest =
    { errors: list<AigConfigDeleteGatewayDynamicRoute_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigDeleteGatewayDynamicRoute =
    ///Success
    | OK of payload: AigConfigDeleteGatewayDynamicRoute_OK
    ///Bad Request
    | BadRequest of payload: AigConfigDeleteGatewayDynamicRoute_BadRequest

type AigConfigGetGatewayDynamicRoute_OKResultDeployment =
    { created_at: string
      deployment_id: string
      version_id: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigGetGatewayDynamicRoute_OKResultVersionActive =
    | [<CompiledName "true">] True
    | [<CompiledName "false">] False
    member this.Format() =
        match this with
        | True -> "true"
        | False -> "false"

type AigConfigGetGatewayDynamicRoute_OKResultVersion =
    { active: AigConfigGetGatewayDynamicRoute_OKResultVersionActive
      created_at: string
      data: string
      version_id: string }

type AigConfigGetGatewayDynamicRoute_OKResult =
    { created_at: System.DateTimeOffset
      deployment: AigConfigGetGatewayDynamicRoute_OKResultDeployment
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      version: AigConfigGetGatewayDynamicRoute_OKResultVersion }

type AigConfigGetGatewayDynamicRoute_OK =
    { result: AigConfigGetGatewayDynamicRoute_OKResult
      success: bool }

type AigConfigGetGatewayDynamicRoute_BadRequestErrors = { message: string }

type AigConfigGetGatewayDynamicRoute_BadRequest =
    { errors: list<AigConfigGetGatewayDynamicRoute_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigGetGatewayDynamicRoute =
    ///Success
    | OK of payload: AigConfigGetGatewayDynamicRoute_OK
    ///Bad Request
    | BadRequest of payload: AigConfigGetGatewayDynamicRoute_BadRequest

type AigConfigUpdateGatewayDynamicRoutePayload =
    { name: string }
    ///Creates an instance of AigConfigUpdateGatewayDynamicRoutePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string): AigConfigUpdateGatewayDynamicRoutePayload = { name = name }

type RouteDeployment =
    { created_at: string
      deployment_id: string
      version_id: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RouteVersionActive =
    | [<CompiledName "true">] True
    | [<CompiledName "false">] False
    member this.Format() =
        match this with
        | True -> "true"
        | False -> "false"

type RouteVersion =
    { active: RouteVersionActive
      created_at: string
      data: string
      version_id: string }

type Route =
    { account_tag: string
      created_at: System.DateTimeOffset
      deployment: RouteDeployment
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      version: RouteVersion }

type AigConfigUpdateGatewayDynamicRoute_OK = { route: Route; success: bool }

type AigConfigUpdateGatewayDynamicRoute_BadRequestRoute =
    { account_tag: string
      created_at: System.DateTimeOffset
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigUpdateGatewayDynamicRoute_BadRequest =
    { route: AigConfigUpdateGatewayDynamicRoute_BadRequestRoute
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigUpdateGatewayDynamicRoute =
    ///Success
    | OK of payload: AigConfigUpdateGatewayDynamicRoute_OK
    ///Input Error
    | BadRequest of payload: AigConfigUpdateGatewayDynamicRoute_BadRequest

type Deployments =
    { created_at: string
      deployment_id: string
      version_id: string }

type AigConfigListGatewayDynamicRouteDeployments_OKData =
    { deployments: list<Deployments>
      order_by: string
      order_by_direction: string
      page: float
      per_page: float }

type AigConfigListGatewayDynamicRouteDeployments_OK =
    { data: AigConfigListGatewayDynamicRouteDeployments_OKData
      success: bool }

type AigConfigListGatewayDynamicRouteDeployments_BadRequestErrors = { message: string }

type AigConfigListGatewayDynamicRouteDeployments_BadRequest =
    { errors: list<AigConfigListGatewayDynamicRouteDeployments_BadRequestErrors>
      result: list<obj>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListGatewayDynamicRouteDeployments =
    ///Success
    | OK of payload: AigConfigListGatewayDynamicRouteDeployments_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListGatewayDynamicRouteDeployments_BadRequest

type AigConfigPostGatewayDynamicRouteDeploymentPayload =
    { version_id: string }
    ///Creates an instance of AigConfigPostGatewayDynamicRouteDeploymentPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (version_id: string): AigConfigPostGatewayDynamicRouteDeploymentPayload =
        { version_id = version_id }

type AigConfigPostGatewayDynamicRouteDeployment_OKResult =
    { created_at: System.DateTimeOffset
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigPostGatewayDynamicRouteDeployment_OK =
    { result: AigConfigPostGatewayDynamicRouteDeployment_OKResult
      success: bool }

type AigConfigPostGatewayDynamicRouteDeployment_BadRequestErrors = { message: string }

type AigConfigPostGatewayDynamicRouteDeployment_BadRequest =
    { errors: list<AigConfigPostGatewayDynamicRouteDeployment_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigPostGatewayDynamicRouteDeployment =
    ///Success
    | OK of payload: AigConfigPostGatewayDynamicRouteDeployment_OK
    ///Bad Request
    | BadRequest of payload: AigConfigPostGatewayDynamicRouteDeployment_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VersionsActive =
    | [<CompiledName "true">] True
    | [<CompiledName "false">] False
    member this.Format() =
        match this with
        | True -> "true"
        | False -> "false"

type Versions =
    { active: VersionsActive
      created_at: string
      data: string
      version_id: string }

type AigConfigListGatewayDynamicRouteVersions_OKData =
    { order_by: string
      order_by_direction: string
      page: float
      per_page: float
      versions: list<Versions> }

type AigConfigListGatewayDynamicRouteVersions_OK =
    { data: AigConfigListGatewayDynamicRouteVersions_OKData
      success: bool }

type AigConfigListGatewayDynamicRouteVersions_BadRequestErrors = { message: string }

type AigConfigListGatewayDynamicRouteVersions_BadRequest =
    { errors: list<AigConfigListGatewayDynamicRouteVersions_BadRequestErrors>
      result: list<obj>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigListGatewayDynamicRouteVersions =
    ///Success
    | OK of payload: AigConfigListGatewayDynamicRouteVersions_OK
    ///Bad Request
    | BadRequest of payload: AigConfigListGatewayDynamicRouteVersions_BadRequest

type AigConfigPostGatewayDynamicRouteVersionPayload =
    { elements: list<string> }
    ///Creates an instance of AigConfigPostGatewayDynamicRouteVersionPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (elements: list<string>): AigConfigPostGatewayDynamicRouteVersionPayload =
        { elements = elements }

type AigConfigPostGatewayDynamicRouteVersion_OKResult =
    { created_at: System.DateTimeOffset
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string }

type AigConfigPostGatewayDynamicRouteVersion_OK =
    { result: AigConfigPostGatewayDynamicRouteVersion_OKResult
      success: bool }

type AigConfigPostGatewayDynamicRouteVersion_BadRequestErrors = { message: string }

type AigConfigPostGatewayDynamicRouteVersion_BadRequest =
    { errors: list<AigConfigPostGatewayDynamicRouteVersion_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigPostGatewayDynamicRouteVersion =
    ///Success
    | OK of payload: AigConfigPostGatewayDynamicRouteVersion_OK
    ///Bad Request
    | BadRequest of payload: AigConfigPostGatewayDynamicRouteVersion_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigGetGatewayDynamicRouteVersion_OKResultActive =
    | [<CompiledName "true">] True
    | [<CompiledName "false">] False
    member this.Format() =
        match this with
        | True -> "true"
        | False -> "false"

type AigConfigGetGatewayDynamicRouteVersion_OKResult =
    { active: AigConfigGetGatewayDynamicRouteVersion_OKResultActive
      created_at: string
      data: string
      elements: list<string>
      gateway_id: string
      id: string
      modified_at: System.DateTimeOffset
      name: string
      version_id: string }

type AigConfigGetGatewayDynamicRouteVersion_OK =
    { result: AigConfigGetGatewayDynamicRouteVersion_OKResult
      success: bool }

type AigConfigGetGatewayDynamicRouteVersion_BadRequestErrors = { message: string }

type AigConfigGetGatewayDynamicRouteVersion_BadRequest =
    { errors: list<AigConfigGetGatewayDynamicRouteVersion_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigGetGatewayDynamicRouteVersion =
    ///Success
    | OK of payload: AigConfigGetGatewayDynamicRouteVersion_OK
    ///Bad Request
    | BadRequest of payload: AigConfigGetGatewayDynamicRouteVersion_BadRequest

type AigConfigGetGatewayUrl_OK = { result: string; success: bool }
type AigConfigGetGatewayUrl_BadRequestErrors = { message: string }

type AigConfigGetGatewayUrl_BadRequest =
    { errors: list<AigConfigGetGatewayUrl_BadRequestErrors>
      result: string
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigGetGatewayUrl =
    ///Returns the log details
    | OK of payload: AigConfigGetGatewayUrl_OK
    ///Bad Request
    | BadRequest of payload: AigConfigGetGatewayUrl_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteGateway_OKResultLogmanagementstrategy =
    | [<CompiledName "STOP_INSERTING">] STOP_INSERTING
    | [<CompiledName "DELETE_OLDEST">] DELETE_OLDEST
    member this.Format() =
        match this with
        | STOP_INSERTING -> "STOP_INSERTING"
        | DELETE_OLDEST -> "DELETE_OLDEST"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteGateway_OKResultOtelContenttype =
    | [<CompiledName "json">] Json
    | [<CompiledName "protobuf">] Protobuf
    member this.Format() =
        match this with
        | Json -> "json"
        | Protobuf -> "protobuf"

type AigConfigDeleteGateway_OKResultOtel =
    { authorization: string
      content_type: Option<AigConfigDeleteGateway_OKResultOtelContenttype>
      headers: Map<string, string>
      url: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteGateway_OKResultRatelimitingtechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteGateway_OKResultRetrybackoff =
    | [<CompiledName "constant">] Constant
    | [<CompiledName "linear">] Linear
    | [<CompiledName "exponential">] Exponential
    member this.Format() =
        match this with
        | Constant -> "constant"
        | Linear -> "linear"
        | Exponential -> "exponential"

type AigConfigDeleteGateway_OKResultStripeUsageevents = { payload: string }

type AigConfigDeleteGateway_OKResultStripe =
    { authorization: string
      usage_events: list<AigConfigDeleteGateway_OKResultStripeUsageevents> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigDeleteGateway_OKResultWorkersaibillingmode =
    | [<CompiledName "postpaid">] Postpaid
    member this.Format() =
        match this with
        | Postpaid -> "postpaid"

type AigConfigDeleteGateway_OKResult =
    { authentication: Option<bool>
      cache_invalidate_on_update: bool
      cache_ttl: int
      collect_logs: bool
      created_at: System.DateTimeOffset
      dlp: Option<obj>
      ///gateway id
      id: string
      is_default: Option<bool>
      log_management: Option<int>
      log_management_strategy: Option<AigConfigDeleteGateway_OKResultLogmanagementstrategy>
      logpush: Option<bool>
      logpush_public_key: Option<string>
      modified_at: System.DateTimeOffset
      otel: Option<list<AigConfigDeleteGateway_OKResultOtel>>
      rate_limiting_interval: int
      rate_limiting_limit: int
      rate_limiting_technique: Option<AigConfigDeleteGateway_OKResultRatelimitingtechnique>
      ///Backoff strategy for retry delays
      retry_backoff: Option<AigConfigDeleteGateway_OKResultRetrybackoff>
      ///Delay between retry attempts in milliseconds (0-5000)
      retry_delay: Option<int>
      ///Maximum number of retry attempts for failed requests (1-5)
      retry_max_attempts: Option<int>
      store_id: Option<string>
      stripe: Option<AigConfigDeleteGateway_OKResultStripe>
      ///Controls how Workers AI inference calls routed through this gateway are billed. Only 'postpaid' is currently supported.
      workers_ai_billing_mode: Option<AigConfigDeleteGateway_OKResultWorkersaibillingmode>
      zdr: Option<bool> }

type AigConfigDeleteGateway_OK =
    { result: AigConfigDeleteGateway_OKResult
      success: bool }

type AigConfigDeleteGateway_NotFoundErrors = { code: float; message: string }

type AigConfigDeleteGateway_NotFound =
    { errors: list<AigConfigDeleteGateway_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigDeleteGateway =
    ///Returns the Object if it was successfully deleted
    | OK of payload: AigConfigDeleteGateway_OK
    ///Not Found
    | NotFound of payload: AigConfigDeleteGateway_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchGateway_OKResultLogmanagementstrategy =
    | [<CompiledName "STOP_INSERTING">] STOP_INSERTING
    | [<CompiledName "DELETE_OLDEST">] DELETE_OLDEST
    member this.Format() =
        match this with
        | STOP_INSERTING -> "STOP_INSERTING"
        | DELETE_OLDEST -> "DELETE_OLDEST"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchGateway_OKResultOtelContenttype =
    | [<CompiledName "json">] Json
    | [<CompiledName "protobuf">] Protobuf
    member this.Format() =
        match this with
        | Json -> "json"
        | Protobuf -> "protobuf"

type AigConfigFetchGateway_OKResultOtel =
    { authorization: string
      content_type: Option<AigConfigFetchGateway_OKResultOtelContenttype>
      headers: Map<string, string>
      url: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchGateway_OKResultRatelimitingtechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchGateway_OKResultRetrybackoff =
    | [<CompiledName "constant">] Constant
    | [<CompiledName "linear">] Linear
    | [<CompiledName "exponential">] Exponential
    member this.Format() =
        match this with
        | Constant -> "constant"
        | Linear -> "linear"
        | Exponential -> "exponential"

type AigConfigFetchGateway_OKResultStripeUsageevents = { payload: string }

type AigConfigFetchGateway_OKResultStripe =
    { authorization: string
      usage_events: list<AigConfigFetchGateway_OKResultStripeUsageevents> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigFetchGateway_OKResultWorkersaibillingmode =
    | [<CompiledName "postpaid">] Postpaid
    member this.Format() =
        match this with
        | Postpaid -> "postpaid"

type AigConfigFetchGateway_OKResult =
    { authentication: Option<bool>
      cache_invalidate_on_update: bool
      cache_ttl: int
      collect_logs: bool
      created_at: System.DateTimeOffset
      dlp: Option<obj>
      ///gateway id
      id: string
      is_default: Option<bool>
      log_management: Option<int>
      log_management_strategy: Option<AigConfigFetchGateway_OKResultLogmanagementstrategy>
      logpush: Option<bool>
      logpush_public_key: Option<string>
      modified_at: System.DateTimeOffset
      otel: Option<list<AigConfigFetchGateway_OKResultOtel>>
      rate_limiting_interval: int
      rate_limiting_limit: int
      rate_limiting_technique: Option<AigConfigFetchGateway_OKResultRatelimitingtechnique>
      ///Backoff strategy for retry delays
      retry_backoff: Option<AigConfigFetchGateway_OKResultRetrybackoff>
      ///Delay between retry attempts in milliseconds (0-5000)
      retry_delay: Option<int>
      ///Maximum number of retry attempts for failed requests (1-5)
      retry_max_attempts: Option<int>
      store_id: Option<string>
      stripe: Option<AigConfigFetchGateway_OKResultStripe>
      ///Controls how Workers AI inference calls routed through this gateway are billed. Only 'postpaid' is currently supported.
      workers_ai_billing_mode: Option<AigConfigFetchGateway_OKResultWorkersaibillingmode>
      zdr: Option<bool> }

type AigConfigFetchGateway_OK =
    { result: AigConfigFetchGateway_OKResult
      success: bool }

type AigConfigFetchGateway_NotFoundErrors = { code: float; message: string }

type AigConfigFetchGateway_NotFound =
    { errors: list<AigConfigFetchGateway_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigFetchGateway =
    ///Returns a single object if found
    | OK of payload: AigConfigFetchGateway_OK
    ///Not Found
    | NotFound of payload: AigConfigFetchGateway_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGatewayPayloadLogmanagementstrategy =
    | [<CompiledName "STOP_INSERTING">] STOP_INSERTING
    | [<CompiledName "DELETE_OLDEST">] DELETE_OLDEST
    member this.Format() =
        match this with
        | STOP_INSERTING -> "STOP_INSERTING"
        | DELETE_OLDEST -> "DELETE_OLDEST"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGatewayPayloadOtelContenttype =
    | [<CompiledName "json">] Json
    | [<CompiledName "protobuf">] Protobuf
    member this.Format() =
        match this with
        | Json -> "json"
        | Protobuf -> "protobuf"

type AigConfigUpdateGatewayPayloadOtel =
    { authorization: string
      content_type: Option<AigConfigUpdateGatewayPayloadOtelContenttype>
      headers: Map<string, string>
      url: string }
    ///Creates an instance of AigConfigUpdateGatewayPayloadOtel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (authorization: string, headers: Map<string, string>, url: string): AigConfigUpdateGatewayPayloadOtel =
        { authorization = authorization
          content_type = None
          headers = headers
          url = url }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGatewayPayloadRatelimitingtechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGatewayPayloadRetrybackoff =
    | [<CompiledName "constant">] Constant
    | [<CompiledName "linear">] Linear
    | [<CompiledName "exponential">] Exponential
    member this.Format() =
        match this with
        | Constant -> "constant"
        | Linear -> "linear"
        | Exponential -> "exponential"

type AigConfigUpdateGatewayPayloadStripeUsageevents =
    { payload: string }
    ///Creates an instance of AigConfigUpdateGatewayPayloadStripeUsageevents with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (payload: string): AigConfigUpdateGatewayPayloadStripeUsageevents = { payload = payload }

type AigConfigUpdateGatewayPayloadStripe =
    { authorization: string
      usage_events: list<AigConfigUpdateGatewayPayloadStripeUsageevents> }
    ///Creates an instance of AigConfigUpdateGatewayPayloadStripe with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (authorization: string, usage_events: list<AigConfigUpdateGatewayPayloadStripeUsageevents>): AigConfigUpdateGatewayPayloadStripe =
        { authorization = authorization
          usage_events = usage_events }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGatewayPayloadWorkersaibillingmode =
    | [<CompiledName "postpaid">] Postpaid
    member this.Format() =
        match this with
        | Postpaid -> "postpaid"

type AigConfigUpdateGatewayPayload =
    { authentication: Option<bool>
      cache_invalidate_on_update: bool
      cache_ttl: int
      collect_logs: bool
      dlp: Option<obj>
      log_management: Option<int>
      log_management_strategy: Option<AigConfigUpdateGatewayPayloadLogmanagementstrategy>
      logpush: Option<bool>
      logpush_public_key: Option<string>
      otel: Option<list<AigConfigUpdateGatewayPayloadOtel>>
      rate_limiting_interval: int
      rate_limiting_limit: int
      rate_limiting_technique: Option<AigConfigUpdateGatewayPayloadRatelimitingtechnique>
      ///Backoff strategy for retry delays
      retry_backoff: Option<AigConfigUpdateGatewayPayloadRetrybackoff>
      ///Delay between retry attempts in milliseconds (0-5000)
      retry_delay: Option<int>
      ///Maximum number of retry attempts for failed requests (1-5)
      retry_max_attempts: Option<int>
      store_id: Option<string>
      stripe: Option<AigConfigUpdateGatewayPayloadStripe>
      ///Controls how Workers AI inference calls routed through this gateway are billed. Only 'postpaid' is currently supported.
      workers_ai_billing_mode: Option<AigConfigUpdateGatewayPayloadWorkersaibillingmode>
      zdr: Option<bool> }
    ///Creates an instance of AigConfigUpdateGatewayPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cache_invalidate_on_update: bool,
                          cache_ttl: int,
                          collect_logs: bool,
                          rate_limiting_interval: int,
                          rate_limiting_limit: int): AigConfigUpdateGatewayPayload =
        { authentication = None
          cache_invalidate_on_update = cache_invalidate_on_update
          cache_ttl = cache_ttl
          collect_logs = collect_logs
          dlp = None
          log_management = None
          log_management_strategy = None
          logpush = None
          logpush_public_key = None
          otel = None
          rate_limiting_interval = rate_limiting_interval
          rate_limiting_limit = rate_limiting_limit
          rate_limiting_technique = None
          retry_backoff = None
          retry_delay = None
          retry_max_attempts = None
          store_id = None
          stripe = None
          workers_ai_billing_mode = None
          zdr = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGateway_OKResultLogmanagementstrategy =
    | [<CompiledName "STOP_INSERTING">] STOP_INSERTING
    | [<CompiledName "DELETE_OLDEST">] DELETE_OLDEST
    member this.Format() =
        match this with
        | STOP_INSERTING -> "STOP_INSERTING"
        | DELETE_OLDEST -> "DELETE_OLDEST"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGateway_OKResultOtelContenttype =
    | [<CompiledName "json">] Json
    | [<CompiledName "protobuf">] Protobuf
    member this.Format() =
        match this with
        | Json -> "json"
        | Protobuf -> "protobuf"

type AigConfigUpdateGateway_OKResultOtel =
    { authorization: string
      content_type: Option<AigConfigUpdateGateway_OKResultOtelContenttype>
      headers: Map<string, string>
      url: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGateway_OKResultRatelimitingtechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGateway_OKResultRetrybackoff =
    | [<CompiledName "constant">] Constant
    | [<CompiledName "linear">] Linear
    | [<CompiledName "exponential">] Exponential
    member this.Format() =
        match this with
        | Constant -> "constant"
        | Linear -> "linear"
        | Exponential -> "exponential"

type AigConfigUpdateGateway_OKResultStripeUsageevents = { payload: string }

type AigConfigUpdateGateway_OKResultStripe =
    { authorization: string
      usage_events: list<AigConfigUpdateGateway_OKResultStripeUsageevents> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AigConfigUpdateGateway_OKResultWorkersaibillingmode =
    | [<CompiledName "postpaid">] Postpaid
    member this.Format() =
        match this with
        | Postpaid -> "postpaid"

type AigConfigUpdateGateway_OKResult =
    { authentication: Option<bool>
      cache_invalidate_on_update: bool
      cache_ttl: int
      collect_logs: bool
      created_at: System.DateTimeOffset
      dlp: Option<obj>
      ///gateway id
      id: string
      is_default: Option<bool>
      log_management: Option<int>
      log_management_strategy: Option<AigConfigUpdateGateway_OKResultLogmanagementstrategy>
      logpush: Option<bool>
      logpush_public_key: Option<string>
      modified_at: System.DateTimeOffset
      otel: Option<list<AigConfigUpdateGateway_OKResultOtel>>
      rate_limiting_interval: int
      rate_limiting_limit: int
      rate_limiting_technique: Option<AigConfigUpdateGateway_OKResultRatelimitingtechnique>
      ///Backoff strategy for retry delays
      retry_backoff: Option<AigConfigUpdateGateway_OKResultRetrybackoff>
      ///Delay between retry attempts in milliseconds (0-5000)
      retry_delay: Option<int>
      ///Maximum number of retry attempts for failed requests (1-5)
      retry_max_attempts: Option<int>
      store_id: Option<string>
      stripe: Option<AigConfigUpdateGateway_OKResultStripe>
      ///Controls how Workers AI inference calls routed through this gateway are billed. Only 'postpaid' is currently supported.
      workers_ai_billing_mode: Option<AigConfigUpdateGateway_OKResultWorkersaibillingmode>
      zdr: Option<bool> }

type AigConfigUpdateGateway_OK =
    { result: AigConfigUpdateGateway_OKResult
      success: bool }

type AigConfigUpdateGateway_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AigConfigUpdateGateway_BadRequest =
    { errors: list<AigConfigUpdateGateway_BadRequestErrors>
      success: bool }

type AigConfigUpdateGateway_NotFoundErrors = { code: float; message: string }

type AigConfigUpdateGateway_NotFound =
    { errors: list<AigConfigUpdateGateway_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AigConfigUpdateGateway =
    ///Returns the updated Object
    | OK of payload: AigConfigUpdateGateway_OK
    ///Input Validation Error
    | BadRequest of payload: AigConfigUpdateGateway_BadRequest
    ///Not Found
    | NotFound of payload: AigConfigUpdateGateway_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Aisearchmodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Cachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Datatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    | [<CompiledName "datetime">] Datetime
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"
        | Datetime -> "datetime"

type Custommetadata =
    { data_type: Datatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Embeddingmodel =
    | [<CompiledName "@cf/qwen/qwen3-embedding-0.6b">] ``@cfQwenQwen3EmbeddingNumeric_0B``
    | [<CompiledName "@cf/baai/bge-m3">] ``@cfBaaiBgeM3``
    | [<CompiledName "@cf/baai/bge-large-en-v1.5">] ``@cfBaaiBgeLargeEnV1Numeric_5``
    | [<CompiledName "@cf/google/embeddinggemma-300m">] ``@cfGoogleEmbeddinggemmaM``
    | [<CompiledName "google-ai-studio/gemini-embedding-001">] GoogleAiStudioGeminiEmbeddingNumeric_001
    | [<CompiledName "google-ai-studio/gemini-embedding-2-preview">] GoogleAiStudioGeminiEmbeddingNumeric_2Preview
    | [<CompiledName "openai/text-embedding-3-small">] OpenaiTextEmbeddingNumeric_3Small
    | [<CompiledName "openai/text-embedding-3-large">] OpenaiTextEmbeddingNumeric_3Large
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfQwenQwen3EmbeddingNumeric_0B`` -> "@cf/qwen/qwen3-embedding-0.6b"
        | ``@cfBaaiBgeM3`` -> "@cf/baai/bge-m3"
        | ``@cfBaaiBgeLargeEnV1Numeric_5`` -> "@cf/baai/bge-large-en-v1.5"
        | ``@cfGoogleEmbeddinggemmaM`` -> "@cf/google/embeddinggemma-300m"
        | GoogleAiStudioGeminiEmbeddingNumeric_001 -> "google-ai-studio/gemini-embedding-001"
        | GoogleAiStudioGeminiEmbeddingNumeric_2Preview -> "google-ai-studio/gemini-embedding-2-preview"
        | OpenaiTextEmbeddingNumeric_3Small -> "openai/text-embedding-3-small"
        | OpenaiTextEmbeddingNumeric_3Large -> "openai/text-embedding-3-large"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Fusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

///Controls which storage backends are used during indexing. Defaults to vector-only.
type Indexmethod =
    { ///Enable keyword (BM25) storage backend.
      keyword: bool
      ///Enable vector (embedding) storage backend.
      vector: bool }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Keywordtokenizer =
    | [<CompiledName "porter">] Porter
    | [<CompiledName "trigram">] Trigram
    member this.Format() =
        match this with
        | Porter -> "porter"
        | Trigram -> "trigram"

type Indexingoptions =
    { ///Tokenizer used for keyword search indexing. porter provides word-level tokenization with Porter stemming (good for natural language queries). trigram enables character-level substring matching (good for partial matches, code, identifiers). Changing this triggers a full re-index. Defaults to porter.
      keyword_tokenizer: Option<Keywordtokenizer> }

type Metadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type Chatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type Mcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Technique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type Ratelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<Technique> }

type Searchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type Publicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<Chatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<Mcp>
      rate_limit: Option<Ratelimit>
      search_endpoint: Option<Searchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Rerankingmodel =
    | [<CompiledName "@cf/baai/bge-reranker-base">] ``@cfBaaiBgeRerankerBase``
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfBaaiBgeRerankerBase`` -> "@cf/baai/bge-reranker-base"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Direction =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type Boostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<Direction>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Keywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

type Retrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<Boostby>>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<Keywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Rewritemodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Source =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type Crawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<Source> }

type Contentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type Parseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<Contentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Parsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Storagetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type Storeoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<Storagetype> }

type Webcrawler =
    { crawl_options: Option<Crawloptions>
      parse_options: Option<Parseoptions>
      parse_type: Option<Parsetype>
      store_options: Option<Storeoptions> }

type Sourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<Webcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchListInstances_OKResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<Aisearchmodel>
      cache: Option<bool>
      cache_threshold: Option<Cachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<Custommetadata>>
      embedding_model: Option<Embeddingmodel>
      enable: Option<bool>
      engine_version: Option<float>
      fusion_method: Option<Fusionmethod>
      ///AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.
      id: string
      ///Controls which storage backends are used during indexing. Defaults to vector-only.
      index_method: Option<Indexmethod>
      indexing_options: Option<Indexingoptions>
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<Metadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      ``namespace``: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<Publicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<Rerankingmodel>
      retrieval_options: Option<Retrievaloptions>
      rewrite_model: Option<Rewritemodel>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<Sourceparams>
      status: Option<string>
      ///Interval between automatic syncs, in seconds. Allowed values: 900 (15min), 1800 (30min), 3600 (1h), 7200 (2h), 14400 (4h), 21600 (6h), 43200 (12h), 86400 (24h).
      sync_interval: Option<obj>
      token_id: Option<System.Guid>
      ``type``: Option<Type> }

type AiSearchListInstances_OKResultinfo =
    { count: float
      page: float
      per_page: float
      total_count: float }

type AiSearchListInstances_OK =
    { result: list<AiSearchListInstances_OKResult>
      result_info: AiSearchListInstances_OKResultinfo
      success: bool }

type AiSearchListInstances_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchListInstances_BadRequest =
    { errors: list<AiSearchListInstances_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchListInstances =
    ///List of instances.
    | OK of payload: AiSearchListInstances_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchListInstances_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancePayloadAisearchmodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancePayloadCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancePayloadCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    | [<CompiledName "datetime">] Datetime
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"
        | Datetime -> "datetime"

type AiSearchCreateInstancePayloadCustommetadata =
    { data_type: AiSearchCreateInstancePayloadCustommetadataDatatype
      field_name: string }
    ///Creates an instance of AiSearchCreateInstancePayloadCustommetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (data_type: AiSearchCreateInstancePayloadCustommetadataDatatype, field_name: string): AiSearchCreateInstancePayloadCustommetadata =
        { data_type = data_type
          field_name = field_name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancePayloadEmbeddingmodel =
    | [<CompiledName "@cf/qwen/qwen3-embedding-0.6b">] ``@cfQwenQwen3EmbeddingNumeric_0B``
    | [<CompiledName "@cf/baai/bge-m3">] ``@cfBaaiBgeM3``
    | [<CompiledName "@cf/baai/bge-large-en-v1.5">] ``@cfBaaiBgeLargeEnV1Numeric_5``
    | [<CompiledName "@cf/google/embeddinggemma-300m">] ``@cfGoogleEmbeddinggemmaM``
    | [<CompiledName "google-ai-studio/gemini-embedding-001">] GoogleAiStudioGeminiEmbeddingNumeric_001
    | [<CompiledName "google-ai-studio/gemini-embedding-2-preview">] GoogleAiStudioGeminiEmbeddingNumeric_2Preview
    | [<CompiledName "openai/text-embedding-3-small">] OpenaiTextEmbeddingNumeric_3Small
    | [<CompiledName "openai/text-embedding-3-large">] OpenaiTextEmbeddingNumeric_3Large
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfQwenQwen3EmbeddingNumeric_0B`` -> "@cf/qwen/qwen3-embedding-0.6b"
        | ``@cfBaaiBgeM3`` -> "@cf/baai/bge-m3"
        | ``@cfBaaiBgeLargeEnV1Numeric_5`` -> "@cf/baai/bge-large-en-v1.5"
        | ``@cfGoogleEmbeddinggemmaM`` -> "@cf/google/embeddinggemma-300m"
        | GoogleAiStudioGeminiEmbeddingNumeric_001 -> "google-ai-studio/gemini-embedding-001"
        | GoogleAiStudioGeminiEmbeddingNumeric_2Preview -> "google-ai-studio/gemini-embedding-2-preview"
        | OpenaiTextEmbeddingNumeric_3Small -> "openai/text-embedding-3-small"
        | OpenaiTextEmbeddingNumeric_3Large -> "openai/text-embedding-3-large"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancePayloadFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

///Controls which storage backends are used during indexing. Defaults to vector-only.
type AiSearchCreateInstancePayloadIndexmethod =
    { ///Enable keyword (BM25) storage backend.
      keyword: bool
      ///Enable vector (embedding) storage backend.
      vector: bool }
    ///Creates an instance of AiSearchCreateInstancePayloadIndexmethod with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (keyword: bool, vector: bool): AiSearchCreateInstancePayloadIndexmethod =
        { keyword = keyword; vector = vector }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancePayloadIndexingoptionsKeywordtokenizer =
    | [<CompiledName "porter">] Porter
    | [<CompiledName "trigram">] Trigram
    member this.Format() =
        match this with
        | Porter -> "porter"
        | Trigram -> "trigram"

type AiSearchCreateInstancePayloadIndexingoptions =
    { ///Tokenizer used for keyword search indexing. porter provides word-level tokenization with Porter stemming (good for natural language queries). trigram enables character-level substring matching (good for partial matches, code, identifiers). Changing this triggers a full re-index. Defaults to porter.
      keyword_tokenizer: Option<AiSearchCreateInstancePayloadIndexingoptionsKeywordtokenizer> }
    ///Creates an instance of AiSearchCreateInstancePayloadIndexingoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancePayloadIndexingoptions = { keyword_tokenizer = None }

type AiSearchCreateInstancePayloadMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }
    ///Creates an instance of AiSearchCreateInstancePayloadMetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancePayloadMetadata =
        { created_from_aisearch_wizard = None
          worker_domain = None }

type AiSearchCreateInstancePayloadPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchCreateInstancePayloadPublicendpointparamsChatcompletionsendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancePayloadPublicendpointparamsChatcompletionsendpoint =
        { disabled = None }

type AiSearchCreateInstancePayloadPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchCreateInstancePayloadPublicendpointparamsMcp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancePayloadPublicendpointparamsMcp =
        { description = None; disabled = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancePayloadPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchCreateInstancePayloadPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchCreateInstancePayloadPublicendpointparamsRatelimitTechnique> }
    ///Creates an instance of AiSearchCreateInstancePayloadPublicendpointparamsRatelimit with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancePayloadPublicendpointparamsRatelimit =
        { period_ms = None
          requests = None
          technique = None }

type AiSearchCreateInstancePayloadPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchCreateInstancePayloadPublicendpointparamsSearchendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancePayloadPublicendpointparamsSearchendpoint = { disabled = None }

type AiSearchCreateInstancePayloadPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchCreateInstancePayloadPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchCreateInstancePayloadPublicendpointparamsMcp>
      rate_limit: Option<AiSearchCreateInstancePayloadPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchCreateInstancePayloadPublicendpointparamsSearchendpoint> }
    ///Creates an instance of AiSearchCreateInstancePayloadPublicendpointparams with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancePayloadPublicendpointparams =
        { authorized_hosts = None
          chat_completions_endpoint = None
          enabled = None
          mcp = None
          rate_limit = None
          search_endpoint = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancePayloadRerankingmodel =
    | [<CompiledName "@cf/baai/bge-reranker-base">] ``@cfBaaiBgeRerankerBase``
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfBaaiBgeRerankerBase`` -> "@cf/baai/bge-reranker-base"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancePayloadRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchCreateInstancePayloadRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchCreateInstancePayloadRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of AiSearchCreateInstancePayloadRetrievaloptionsBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): AiSearchCreateInstancePayloadRetrievaloptionsBoostby =
        { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancePayloadRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

type AiSearchCreateInstancePayloadRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchCreateInstancePayloadRetrievaloptionsBoostby>>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchCreateInstancePayloadRetrievaloptionsKeywordmatchmode> }
    ///Creates an instance of AiSearchCreateInstancePayloadRetrievaloptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancePayloadRetrievaloptions =
        { boost_by = None
          keyword_match_mode = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancePayloadRewritemodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancePayloadSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchCreateInstancePayloadSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchCreateInstancePayloadSourceparamsWebcrawlerCrawloptionsSource> }
    ///Creates an instance of AiSearchCreateInstancePayloadSourceparamsWebcrawlerCrawloptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancePayloadSourceparamsWebcrawlerCrawloptions =
        { depth = None
          include_external_links = None
          include_subdomains = None
          max_age = None
          source = None }

type AiSearchCreateInstancePayloadSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }
    ///Creates an instance of AiSearchCreateInstancePayloadSourceparamsWebcrawlerParseoptionsContentselector with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (path: string, selector: string): AiSearchCreateInstancePayloadSourceparamsWebcrawlerParseoptionsContentselector =
        { path = path; selector = selector }

type AiSearchCreateInstancePayloadSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchCreateInstancePayloadSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }
    ///Creates an instance of AiSearchCreateInstancePayloadSourceparamsWebcrawlerParseoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancePayloadSourceparamsWebcrawlerParseoptions =
        { content_selector = None
          include_headers = None
          include_images = None
          specific_sitemaps = None
          use_browser_rendering = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancePayloadSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancePayloadSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchCreateInstancePayloadSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchCreateInstancePayloadSourceparamsWebcrawlerStoreoptionsStoragetype> }
    ///Creates an instance of AiSearchCreateInstancePayloadSourceparamsWebcrawlerStoreoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (storage_id: string): AiSearchCreateInstancePayloadSourceparamsWebcrawlerStoreoptions =
        { r2_jurisdiction = None
          storage_id = storage_id
          storage_type = None }

type AiSearchCreateInstancePayloadSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchCreateInstancePayloadSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchCreateInstancePayloadSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchCreateInstancePayloadSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchCreateInstancePayloadSourceparamsWebcrawlerStoreoptions> }
    ///Creates an instance of AiSearchCreateInstancePayloadSourceparamsWebcrawler with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancePayloadSourceparamsWebcrawler =
        { crawl_options = None
          parse_options = None
          parse_type = None
          store_options = None }

type AiSearchCreateInstancePayloadSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchCreateInstancePayloadSourceparamsWebcrawler> }
    ///Creates an instance of AiSearchCreateInstancePayloadSourceparams with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchCreateInstancePayloadSourceparams =
        { exclude_items = None
          include_items = None
          prefix = None
          r2_jurisdiction = None
          web_crawler = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstancePayloadType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchCreateInstancePayload =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<AiSearchCreateInstancePayloadAisearchmodel>
      cache: Option<bool>
      cache_threshold: Option<AiSearchCreateInstancePayloadCachethreshold>
      chunk: Option<bool>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      custom_metadata: Option<list<AiSearchCreateInstancePayloadCustommetadata>>
      embedding_model: Option<AiSearchCreateInstancePayloadEmbeddingmodel>
      fusion_method: Option<AiSearchCreateInstancePayloadFusionmethod>
      ///AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.
      id: string
      ///Controls which storage backends are used during indexing. Defaults to vector-only.
      index_method: Option<AiSearchCreateInstancePayloadIndexmethod>
      indexing_options: Option<AiSearchCreateInstancePayloadIndexingoptions>
      max_num_results: Option<int>
      metadata: Option<AiSearchCreateInstancePayloadMetadata>
      public_endpoint_params: Option<AiSearchCreateInstancePayloadPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<AiSearchCreateInstancePayloadRerankingmodel>
      retrieval_options: Option<AiSearchCreateInstancePayloadRetrievaloptions>
      rewrite_model: Option<AiSearchCreateInstancePayloadRewritemodel>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchCreateInstancePayloadSourceparams>
      ///Interval between automatic syncs, in seconds. Allowed values: 900 (15min), 1800 (30min), 3600 (1h), 7200 (2h), 14400 (4h), 21600 (6h), 43200 (12h), 86400 (24h).
      sync_interval: Option<obj>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchCreateInstancePayloadType> }
    ///Creates an instance of AiSearchCreateInstancePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string): AiSearchCreateInstancePayload =
        { ai_gateway_id = None
          ai_search_model = None
          cache = None
          cache_threshold = None
          chunk = None
          chunk_overlap = None
          chunk_size = None
          custom_metadata = None
          embedding_model = None
          fusion_method = None
          id = id
          index_method = None
          indexing_options = None
          max_num_results = None
          metadata = None
          public_endpoint_params = None
          reranking = None
          reranking_model = None
          retrieval_options = None
          rewrite_model = None
          rewrite_query = None
          score_threshold = None
          source = None
          source_params = None
          sync_interval = None
          token_id = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstance_CreatedResultAisearchmodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstance_CreatedResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstance_CreatedResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    | [<CompiledName "datetime">] Datetime
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"
        | Datetime -> "datetime"

type AiSearchCreateInstance_CreatedResultCustommetadata =
    { data_type: AiSearchCreateInstance_CreatedResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstance_CreatedResultEmbeddingmodel =
    | [<CompiledName "@cf/qwen/qwen3-embedding-0.6b">] ``@cfQwenQwen3EmbeddingNumeric_0B``
    | [<CompiledName "@cf/baai/bge-m3">] ``@cfBaaiBgeM3``
    | [<CompiledName "@cf/baai/bge-large-en-v1.5">] ``@cfBaaiBgeLargeEnV1Numeric_5``
    | [<CompiledName "@cf/google/embeddinggemma-300m">] ``@cfGoogleEmbeddinggemmaM``
    | [<CompiledName "google-ai-studio/gemini-embedding-001">] GoogleAiStudioGeminiEmbeddingNumeric_001
    | [<CompiledName "google-ai-studio/gemini-embedding-2-preview">] GoogleAiStudioGeminiEmbeddingNumeric_2Preview
    | [<CompiledName "openai/text-embedding-3-small">] OpenaiTextEmbeddingNumeric_3Small
    | [<CompiledName "openai/text-embedding-3-large">] OpenaiTextEmbeddingNumeric_3Large
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfQwenQwen3EmbeddingNumeric_0B`` -> "@cf/qwen/qwen3-embedding-0.6b"
        | ``@cfBaaiBgeM3`` -> "@cf/baai/bge-m3"
        | ``@cfBaaiBgeLargeEnV1Numeric_5`` -> "@cf/baai/bge-large-en-v1.5"
        | ``@cfGoogleEmbeddinggemmaM`` -> "@cf/google/embeddinggemma-300m"
        | GoogleAiStudioGeminiEmbeddingNumeric_001 -> "google-ai-studio/gemini-embedding-001"
        | GoogleAiStudioGeminiEmbeddingNumeric_2Preview -> "google-ai-studio/gemini-embedding-2-preview"
        | OpenaiTextEmbeddingNumeric_3Small -> "openai/text-embedding-3-small"
        | OpenaiTextEmbeddingNumeric_3Large -> "openai/text-embedding-3-large"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstance_CreatedResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

///Controls which storage backends are used during indexing. Defaults to vector-only.
type AiSearchCreateInstance_CreatedResultIndexmethod =
    { ///Enable keyword (BM25) storage backend.
      keyword: bool
      ///Enable vector (embedding) storage backend.
      vector: bool }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstance_CreatedResultIndexingoptionsKeywordtokenizer =
    | [<CompiledName "porter">] Porter
    | [<CompiledName "trigram">] Trigram
    member this.Format() =
        match this with
        | Porter -> "porter"
        | Trigram -> "trigram"

type AiSearchCreateInstance_CreatedResultIndexingoptions =
    { ///Tokenizer used for keyword search indexing. porter provides word-level tokenization with Porter stemming (good for natural language queries). trigram enables character-level substring matching (good for partial matches, code, identifiers). Changing this triggers a full re-index. Defaults to porter.
      keyword_tokenizer: Option<AiSearchCreateInstance_CreatedResultIndexingoptionsKeywordtokenizer> }

type AiSearchCreateInstance_CreatedResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchCreateInstance_CreatedResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchCreateInstance_CreatedResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstance_CreatedResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchCreateInstance_CreatedResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchCreateInstance_CreatedResultPublicendpointparamsRatelimitTechnique> }

type AiSearchCreateInstance_CreatedResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchCreateInstance_CreatedResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchCreateInstance_CreatedResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchCreateInstance_CreatedResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchCreateInstance_CreatedResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchCreateInstance_CreatedResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstance_CreatedResultRerankingmodel =
    | [<CompiledName "@cf/baai/bge-reranker-base">] ``@cfBaaiBgeRerankerBase``
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfBaaiBgeRerankerBase`` -> "@cf/baai/bge-reranker-base"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstance_CreatedResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchCreateInstance_CreatedResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchCreateInstance_CreatedResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstance_CreatedResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

type AiSearchCreateInstance_CreatedResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchCreateInstance_CreatedResultRetrievaloptionsBoostby>>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchCreateInstance_CreatedResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstance_CreatedResultRewritemodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstance_CreatedResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchCreateInstance_CreatedResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchCreateInstance_CreatedResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchCreateInstance_CreatedResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchCreateInstance_CreatedResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchCreateInstance_CreatedResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstance_CreatedResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstance_CreatedResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchCreateInstance_CreatedResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchCreateInstance_CreatedResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchCreateInstance_CreatedResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchCreateInstance_CreatedResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchCreateInstance_CreatedResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchCreateInstance_CreatedResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchCreateInstance_CreatedResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchCreateInstance_CreatedResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchCreateInstance_CreatedResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchCreateInstance_CreatedResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchCreateInstance_CreatedResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<AiSearchCreateInstance_CreatedResultAisearchmodel>
      cache: Option<bool>
      cache_threshold: Option<AiSearchCreateInstance_CreatedResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchCreateInstance_CreatedResultCustommetadata>>
      embedding_model: Option<AiSearchCreateInstance_CreatedResultEmbeddingmodel>
      enable: Option<bool>
      engine_version: Option<float>
      fusion_method: Option<AiSearchCreateInstance_CreatedResultFusionmethod>
      ///AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.
      id: string
      ///Controls which storage backends are used during indexing. Defaults to vector-only.
      index_method: Option<AiSearchCreateInstance_CreatedResultIndexmethod>
      indexing_options: Option<AiSearchCreateInstance_CreatedResultIndexingoptions>
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchCreateInstance_CreatedResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      ``namespace``: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchCreateInstance_CreatedResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<AiSearchCreateInstance_CreatedResultRerankingmodel>
      retrieval_options: Option<AiSearchCreateInstance_CreatedResultRetrievaloptions>
      rewrite_model: Option<AiSearchCreateInstance_CreatedResultRewritemodel>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchCreateInstance_CreatedResultSourceparams>
      status: Option<string>
      ///Interval between automatic syncs, in seconds. Allowed values: 900 (15min), 1800 (30min), 3600 (1h), 7200 (2h), 14400 (4h), 21600 (6h), 43200 (12h), 86400 (24h).
      sync_interval: Option<obj>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchCreateInstance_CreatedResultType> }

type AiSearchCreateInstance_Created =
    { result: AiSearchCreateInstance_CreatedResult
      success: bool }

type AiSearchCreateInstance_BadRequestErrors = { code: float; message: string }

type AiSearchCreateInstance_BadRequest =
    { errors: list<AiSearchCreateInstance_BadRequestErrors>
      success: bool }

type AiSearchCreateInstance_ForbiddenErrors = { code: float; message: string }

type AiSearchCreateInstance_Forbidden =
    { errors: list<AiSearchCreateInstance_ForbiddenErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchCreateInstance =
    ///Returns the new instance.
    | Created of payload: AiSearchCreateInstance_Created
    ///Ai search instance invalid token.
    | BadRequest of payload: AiSearchCreateInstance_BadRequest
    ///Max instances reached.
    | Forbidden of payload: AiSearchCreateInstance_Forbidden

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstance_OKResultAisearchmodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstance_OKResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstance_OKResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    | [<CompiledName "datetime">] Datetime
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"
        | Datetime -> "datetime"

type AiSearchDeleteInstance_OKResultCustommetadata =
    { data_type: AiSearchDeleteInstance_OKResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstance_OKResultEmbeddingmodel =
    | [<CompiledName "@cf/qwen/qwen3-embedding-0.6b">] ``@cfQwenQwen3EmbeddingNumeric_0B``
    | [<CompiledName "@cf/baai/bge-m3">] ``@cfBaaiBgeM3``
    | [<CompiledName "@cf/baai/bge-large-en-v1.5">] ``@cfBaaiBgeLargeEnV1Numeric_5``
    | [<CompiledName "@cf/google/embeddinggemma-300m">] ``@cfGoogleEmbeddinggemmaM``
    | [<CompiledName "google-ai-studio/gemini-embedding-001">] GoogleAiStudioGeminiEmbeddingNumeric_001
    | [<CompiledName "google-ai-studio/gemini-embedding-2-preview">] GoogleAiStudioGeminiEmbeddingNumeric_2Preview
    | [<CompiledName "openai/text-embedding-3-small">] OpenaiTextEmbeddingNumeric_3Small
    | [<CompiledName "openai/text-embedding-3-large">] OpenaiTextEmbeddingNumeric_3Large
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfQwenQwen3EmbeddingNumeric_0B`` -> "@cf/qwen/qwen3-embedding-0.6b"
        | ``@cfBaaiBgeM3`` -> "@cf/baai/bge-m3"
        | ``@cfBaaiBgeLargeEnV1Numeric_5`` -> "@cf/baai/bge-large-en-v1.5"
        | ``@cfGoogleEmbeddinggemmaM`` -> "@cf/google/embeddinggemma-300m"
        | GoogleAiStudioGeminiEmbeddingNumeric_001 -> "google-ai-studio/gemini-embedding-001"
        | GoogleAiStudioGeminiEmbeddingNumeric_2Preview -> "google-ai-studio/gemini-embedding-2-preview"
        | OpenaiTextEmbeddingNumeric_3Small -> "openai/text-embedding-3-small"
        | OpenaiTextEmbeddingNumeric_3Large -> "openai/text-embedding-3-large"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstance_OKResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

///Controls which storage backends are used during indexing. Defaults to vector-only.
type AiSearchDeleteInstance_OKResultIndexmethod =
    { ///Enable keyword (BM25) storage backend.
      keyword: bool
      ///Enable vector (embedding) storage backend.
      vector: bool }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstance_OKResultIndexingoptionsKeywordtokenizer =
    | [<CompiledName "porter">] Porter
    | [<CompiledName "trigram">] Trigram
    member this.Format() =
        match this with
        | Porter -> "porter"
        | Trigram -> "trigram"

type AiSearchDeleteInstance_OKResultIndexingoptions =
    { ///Tokenizer used for keyword search indexing. porter provides word-level tokenization with Porter stemming (good for natural language queries). trigram enables character-level substring matching (good for partial matches, code, identifiers). Changing this triggers a full re-index. Defaults to porter.
      keyword_tokenizer: Option<AiSearchDeleteInstance_OKResultIndexingoptionsKeywordtokenizer> }

type AiSearchDeleteInstance_OKResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchDeleteInstance_OKResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchDeleteInstance_OKResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstance_OKResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchDeleteInstance_OKResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchDeleteInstance_OKResultPublicendpointparamsRatelimitTechnique> }

type AiSearchDeleteInstance_OKResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchDeleteInstance_OKResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchDeleteInstance_OKResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchDeleteInstance_OKResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchDeleteInstance_OKResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchDeleteInstance_OKResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstance_OKResultRerankingmodel =
    | [<CompiledName "@cf/baai/bge-reranker-base">] ``@cfBaaiBgeRerankerBase``
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfBaaiBgeRerankerBase`` -> "@cf/baai/bge-reranker-base"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstance_OKResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchDeleteInstance_OKResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchDeleteInstance_OKResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstance_OKResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

type AiSearchDeleteInstance_OKResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchDeleteInstance_OKResultRetrievaloptionsBoostby>>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchDeleteInstance_OKResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstance_OKResultRewritemodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstance_OKResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchDeleteInstance_OKResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchDeleteInstance_OKResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchDeleteInstance_OKResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchDeleteInstance_OKResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchDeleteInstance_OKResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstance_OKResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstance_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchDeleteInstance_OKResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchDeleteInstance_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchDeleteInstance_OKResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchDeleteInstance_OKResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchDeleteInstance_OKResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchDeleteInstance_OKResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchDeleteInstance_OKResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchDeleteInstance_OKResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchDeleteInstance_OKResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchDeleteInstance_OKResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchDeleteInstance_OKResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<AiSearchDeleteInstance_OKResultAisearchmodel>
      cache: Option<bool>
      cache_threshold: Option<AiSearchDeleteInstance_OKResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchDeleteInstance_OKResultCustommetadata>>
      embedding_model: Option<AiSearchDeleteInstance_OKResultEmbeddingmodel>
      enable: Option<bool>
      engine_version: Option<float>
      fusion_method: Option<AiSearchDeleteInstance_OKResultFusionmethod>
      ///AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.
      id: string
      ///Controls which storage backends are used during indexing. Defaults to vector-only.
      index_method: Option<AiSearchDeleteInstance_OKResultIndexmethod>
      indexing_options: Option<AiSearchDeleteInstance_OKResultIndexingoptions>
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchDeleteInstance_OKResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      ``namespace``: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchDeleteInstance_OKResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<AiSearchDeleteInstance_OKResultRerankingmodel>
      retrieval_options: Option<AiSearchDeleteInstance_OKResultRetrievaloptions>
      rewrite_model: Option<AiSearchDeleteInstance_OKResultRewritemodel>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchDeleteInstance_OKResultSourceparams>
      status: Option<string>
      ///Interval between automatic syncs, in seconds. Allowed values: 900 (15min), 1800 (30min), 3600 (1h), 7200 (2h), 14400 (4h), 21600 (6h), 43200 (12h), 86400 (24h).
      sync_interval: Option<obj>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchDeleteInstance_OKResultType> }

type AiSearchDeleteInstance_OK =
    { result: AiSearchDeleteInstance_OKResult
      success: bool }

type AiSearchDeleteInstance_NotFoundErrors = { code: float; message: string }

type AiSearchDeleteInstance_NotFound =
    { errors: list<AiSearchDeleteInstance_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchDeleteInstance =
    ///Returns the deleted instance.
    | OK of payload: AiSearchDeleteInstance_OK
    ///Ai search not found.
    | NotFound of payload: AiSearchDeleteInstance_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstance_OKResultAisearchmodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstance_OKResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstance_OKResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    | [<CompiledName "datetime">] Datetime
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"
        | Datetime -> "datetime"

type AiSearchFetchInstance_OKResultCustommetadata =
    { data_type: AiSearchFetchInstance_OKResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstance_OKResultEmbeddingmodel =
    | [<CompiledName "@cf/qwen/qwen3-embedding-0.6b">] ``@cfQwenQwen3EmbeddingNumeric_0B``
    | [<CompiledName "@cf/baai/bge-m3">] ``@cfBaaiBgeM3``
    | [<CompiledName "@cf/baai/bge-large-en-v1.5">] ``@cfBaaiBgeLargeEnV1Numeric_5``
    | [<CompiledName "@cf/google/embeddinggemma-300m">] ``@cfGoogleEmbeddinggemmaM``
    | [<CompiledName "google-ai-studio/gemini-embedding-001">] GoogleAiStudioGeminiEmbeddingNumeric_001
    | [<CompiledName "google-ai-studio/gemini-embedding-2-preview">] GoogleAiStudioGeminiEmbeddingNumeric_2Preview
    | [<CompiledName "openai/text-embedding-3-small">] OpenaiTextEmbeddingNumeric_3Small
    | [<CompiledName "openai/text-embedding-3-large">] OpenaiTextEmbeddingNumeric_3Large
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfQwenQwen3EmbeddingNumeric_0B`` -> "@cf/qwen/qwen3-embedding-0.6b"
        | ``@cfBaaiBgeM3`` -> "@cf/baai/bge-m3"
        | ``@cfBaaiBgeLargeEnV1Numeric_5`` -> "@cf/baai/bge-large-en-v1.5"
        | ``@cfGoogleEmbeddinggemmaM`` -> "@cf/google/embeddinggemma-300m"
        | GoogleAiStudioGeminiEmbeddingNumeric_001 -> "google-ai-studio/gemini-embedding-001"
        | GoogleAiStudioGeminiEmbeddingNumeric_2Preview -> "google-ai-studio/gemini-embedding-2-preview"
        | OpenaiTextEmbeddingNumeric_3Small -> "openai/text-embedding-3-small"
        | OpenaiTextEmbeddingNumeric_3Large -> "openai/text-embedding-3-large"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstance_OKResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

///Controls which storage backends are used during indexing. Defaults to vector-only.
type AiSearchFetchInstance_OKResultIndexmethod =
    { ///Enable keyword (BM25) storage backend.
      keyword: bool
      ///Enable vector (embedding) storage backend.
      vector: bool }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstance_OKResultIndexingoptionsKeywordtokenizer =
    | [<CompiledName "porter">] Porter
    | [<CompiledName "trigram">] Trigram
    member this.Format() =
        match this with
        | Porter -> "porter"
        | Trigram -> "trigram"

type AiSearchFetchInstance_OKResultIndexingoptions =
    { ///Tokenizer used for keyword search indexing. porter provides word-level tokenization with Porter stemming (good for natural language queries). trigram enables character-level substring matching (good for partial matches, code, identifiers). Changing this triggers a full re-index. Defaults to porter.
      keyword_tokenizer: Option<AiSearchFetchInstance_OKResultIndexingoptionsKeywordtokenizer> }

type AiSearchFetchInstance_OKResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchFetchInstance_OKResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchFetchInstance_OKResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstance_OKResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchFetchInstance_OKResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchFetchInstance_OKResultPublicendpointparamsRatelimitTechnique> }

type AiSearchFetchInstance_OKResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchFetchInstance_OKResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchFetchInstance_OKResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchFetchInstance_OKResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchFetchInstance_OKResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchFetchInstance_OKResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstance_OKResultRerankingmodel =
    | [<CompiledName "@cf/baai/bge-reranker-base">] ``@cfBaaiBgeRerankerBase``
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfBaaiBgeRerankerBase`` -> "@cf/baai/bge-reranker-base"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstance_OKResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchFetchInstance_OKResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchFetchInstance_OKResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstance_OKResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

type AiSearchFetchInstance_OKResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchFetchInstance_OKResultRetrievaloptionsBoostby>>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchFetchInstance_OKResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstance_OKResultRewritemodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstance_OKResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchFetchInstance_OKResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchFetchInstance_OKResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchFetchInstance_OKResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchFetchInstance_OKResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchFetchInstance_OKResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstance_OKResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstance_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchFetchInstance_OKResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchFetchInstance_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchFetchInstance_OKResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchFetchInstance_OKResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchFetchInstance_OKResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchFetchInstance_OKResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchFetchInstance_OKResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchFetchInstance_OKResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchFetchInstance_OKResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchFetchInstance_OKResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchFetchInstance_OKResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<AiSearchFetchInstance_OKResultAisearchmodel>
      cache: Option<bool>
      cache_threshold: Option<AiSearchFetchInstance_OKResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchFetchInstance_OKResultCustommetadata>>
      embedding_model: Option<AiSearchFetchInstance_OKResultEmbeddingmodel>
      enable: Option<bool>
      engine_version: Option<float>
      fusion_method: Option<AiSearchFetchInstance_OKResultFusionmethod>
      ///AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.
      id: string
      ///Controls which storage backends are used during indexing. Defaults to vector-only.
      index_method: Option<AiSearchFetchInstance_OKResultIndexmethod>
      indexing_options: Option<AiSearchFetchInstance_OKResultIndexingoptions>
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchFetchInstance_OKResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      ``namespace``: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchFetchInstance_OKResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<AiSearchFetchInstance_OKResultRerankingmodel>
      retrieval_options: Option<AiSearchFetchInstance_OKResultRetrievaloptions>
      rewrite_model: Option<AiSearchFetchInstance_OKResultRewritemodel>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchFetchInstance_OKResultSourceparams>
      status: Option<string>
      ///Interval between automatic syncs, in seconds. Allowed values: 900 (15min), 1800 (30min), 3600 (1h), 7200 (2h), 14400 (4h), 21600 (6h), 43200 (12h), 86400 (24h).
      sync_interval: Option<obj>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchFetchInstance_OKResultType> }

type AiSearchFetchInstance_OK =
    { result: AiSearchFetchInstance_OKResult
      success: bool }

type AiSearchFetchInstance_NotFoundErrors = { code: float; message: string }

type AiSearchFetchInstance_NotFound =
    { errors: list<AiSearchFetchInstance_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchFetchInstance =
    ///Returns the instance.
    | OK of payload: AiSearchFetchInstance_OK
    ///Ai search not found.
    | NotFound of payload: AiSearchFetchInstance_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancePayloadAisearchmodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancePayloadCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancePayloadCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    | [<CompiledName "datetime">] Datetime
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"
        | Datetime -> "datetime"

type AiSearchUpdateInstancePayloadCustommetadata =
    { data_type: AiSearchUpdateInstancePayloadCustommetadataDatatype
      field_name: string }
    ///Creates an instance of AiSearchUpdateInstancePayloadCustommetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (data_type: AiSearchUpdateInstancePayloadCustommetadataDatatype, field_name: string): AiSearchUpdateInstancePayloadCustommetadata =
        { data_type = data_type
          field_name = field_name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancePayloadEmbeddingmodel =
    | [<CompiledName "@cf/qwen/qwen3-embedding-0.6b">] ``@cfQwenQwen3EmbeddingNumeric_0B``
    | [<CompiledName "@cf/baai/bge-m3">] ``@cfBaaiBgeM3``
    | [<CompiledName "@cf/baai/bge-large-en-v1.5">] ``@cfBaaiBgeLargeEnV1Numeric_5``
    | [<CompiledName "@cf/google/embeddinggemma-300m">] ``@cfGoogleEmbeddinggemmaM``
    | [<CompiledName "google-ai-studio/gemini-embedding-001">] GoogleAiStudioGeminiEmbeddingNumeric_001
    | [<CompiledName "google-ai-studio/gemini-embedding-2-preview">] GoogleAiStudioGeminiEmbeddingNumeric_2Preview
    | [<CompiledName "openai/text-embedding-3-small">] OpenaiTextEmbeddingNumeric_3Small
    | [<CompiledName "openai/text-embedding-3-large">] OpenaiTextEmbeddingNumeric_3Large
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfQwenQwen3EmbeddingNumeric_0B`` -> "@cf/qwen/qwen3-embedding-0.6b"
        | ``@cfBaaiBgeM3`` -> "@cf/baai/bge-m3"
        | ``@cfBaaiBgeLargeEnV1Numeric_5`` -> "@cf/baai/bge-large-en-v1.5"
        | ``@cfGoogleEmbeddinggemmaM`` -> "@cf/google/embeddinggemma-300m"
        | GoogleAiStudioGeminiEmbeddingNumeric_001 -> "google-ai-studio/gemini-embedding-001"
        | GoogleAiStudioGeminiEmbeddingNumeric_2Preview -> "google-ai-studio/gemini-embedding-2-preview"
        | OpenaiTextEmbeddingNumeric_3Small -> "openai/text-embedding-3-small"
        | OpenaiTextEmbeddingNumeric_3Large -> "openai/text-embedding-3-large"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancePayloadFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

///Controls which storage backends are used during indexing. Defaults to vector-only.
type AiSearchUpdateInstancePayloadIndexmethod =
    { ///Enable keyword (BM25) storage backend.
      keyword: bool
      ///Enable vector (embedding) storage backend.
      vector: bool }
    ///Creates an instance of AiSearchUpdateInstancePayloadIndexmethod with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (keyword: bool, vector: bool): AiSearchUpdateInstancePayloadIndexmethod =
        { keyword = keyword; vector = vector }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancePayloadIndexingoptionsKeywordtokenizer =
    | [<CompiledName "porter">] Porter
    | [<CompiledName "trigram">] Trigram
    member this.Format() =
        match this with
        | Porter -> "porter"
        | Trigram -> "trigram"

type AiSearchUpdateInstancePayloadIndexingoptions =
    { ///Tokenizer used for keyword search indexing. porter provides word-level tokenization with Porter stemming (good for natural language queries). trigram enables character-level substring matching (good for partial matches, code, identifiers). Changing this triggers a full re-index. Defaults to porter.
      keyword_tokenizer: Option<AiSearchUpdateInstancePayloadIndexingoptionsKeywordtokenizer> }
    ///Creates an instance of AiSearchUpdateInstancePayloadIndexingoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancePayloadIndexingoptions = { keyword_tokenizer = None }

type AiSearchUpdateInstancePayloadMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }
    ///Creates an instance of AiSearchUpdateInstancePayloadMetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancePayloadMetadata =
        { created_from_aisearch_wizard = None
          worker_domain = None }

type AiSearchUpdateInstancePayloadPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchUpdateInstancePayloadPublicendpointparamsChatcompletionsendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancePayloadPublicendpointparamsChatcompletionsendpoint =
        { disabled = None }

type AiSearchUpdateInstancePayloadPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchUpdateInstancePayloadPublicendpointparamsMcp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancePayloadPublicendpointparamsMcp =
        { description = None; disabled = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancePayloadPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchUpdateInstancePayloadPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchUpdateInstancePayloadPublicendpointparamsRatelimitTechnique> }
    ///Creates an instance of AiSearchUpdateInstancePayloadPublicendpointparamsRatelimit with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancePayloadPublicendpointparamsRatelimit =
        { period_ms = None
          requests = None
          technique = None }

type AiSearchUpdateInstancePayloadPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchUpdateInstancePayloadPublicendpointparamsSearchendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancePayloadPublicendpointparamsSearchendpoint = { disabled = None }

type AiSearchUpdateInstancePayloadPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchUpdateInstancePayloadPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchUpdateInstancePayloadPublicendpointparamsMcp>
      rate_limit: Option<AiSearchUpdateInstancePayloadPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchUpdateInstancePayloadPublicendpointparamsSearchendpoint> }
    ///Creates an instance of AiSearchUpdateInstancePayloadPublicendpointparams with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancePayloadPublicendpointparams =
        { authorized_hosts = None
          chat_completions_endpoint = None
          enabled = None
          mcp = None
          rate_limit = None
          search_endpoint = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancePayloadRerankingmodel =
    | [<CompiledName "@cf/baai/bge-reranker-base">] ``@cfBaaiBgeRerankerBase``
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfBaaiBgeRerankerBase`` -> "@cf/baai/bge-reranker-base"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancePayloadRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchUpdateInstancePayloadRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchUpdateInstancePayloadRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of AiSearchUpdateInstancePayloadRetrievaloptionsBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): AiSearchUpdateInstancePayloadRetrievaloptionsBoostby =
        { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancePayloadRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

type AiSearchUpdateInstancePayloadRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchUpdateInstancePayloadRetrievaloptionsBoostby>>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchUpdateInstancePayloadRetrievaloptionsKeywordmatchmode> }
    ///Creates an instance of AiSearchUpdateInstancePayloadRetrievaloptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancePayloadRetrievaloptions =
        { boost_by = None
          keyword_match_mode = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancePayloadRewritemodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancePayloadSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchUpdateInstancePayloadSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchUpdateInstancePayloadSourceparamsWebcrawlerCrawloptionsSource> }
    ///Creates an instance of AiSearchUpdateInstancePayloadSourceparamsWebcrawlerCrawloptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancePayloadSourceparamsWebcrawlerCrawloptions =
        { depth = None
          include_external_links = None
          include_subdomains = None
          max_age = None
          source = None }

type AiSearchUpdateInstancePayloadSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }
    ///Creates an instance of AiSearchUpdateInstancePayloadSourceparamsWebcrawlerParseoptionsContentselector with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (path: string, selector: string): AiSearchUpdateInstancePayloadSourceparamsWebcrawlerParseoptionsContentselector =
        { path = path; selector = selector }

type AiSearchUpdateInstancePayloadSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchUpdateInstancePayloadSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }
    ///Creates an instance of AiSearchUpdateInstancePayloadSourceparamsWebcrawlerParseoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancePayloadSourceparamsWebcrawlerParseoptions =
        { content_selector = None
          include_headers = None
          include_images = None
          specific_sitemaps = None
          use_browser_rendering = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancePayloadSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstancePayloadSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchUpdateInstancePayloadSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchUpdateInstancePayloadSourceparamsWebcrawlerStoreoptionsStoragetype> }
    ///Creates an instance of AiSearchUpdateInstancePayloadSourceparamsWebcrawlerStoreoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (storage_id: string): AiSearchUpdateInstancePayloadSourceparamsWebcrawlerStoreoptions =
        { r2_jurisdiction = None
          storage_id = storage_id
          storage_type = None }

type AiSearchUpdateInstancePayloadSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchUpdateInstancePayloadSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchUpdateInstancePayloadSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchUpdateInstancePayloadSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchUpdateInstancePayloadSourceparamsWebcrawlerStoreoptions> }
    ///Creates an instance of AiSearchUpdateInstancePayloadSourceparamsWebcrawler with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancePayloadSourceparamsWebcrawler =
        { crawl_options = None
          parse_options = None
          parse_type = None
          store_options = None }

type AiSearchUpdateInstancePayloadSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchUpdateInstancePayloadSourceparamsWebcrawler> }
    ///Creates an instance of AiSearchUpdateInstancePayloadSourceparams with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancePayloadSourceparams =
        { exclude_items = None
          include_items = None
          prefix = None
          r2_jurisdiction = None
          web_crawler = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Summarizationmodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

type AiSearchUpdateInstancePayload =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<AiSearchUpdateInstancePayloadAisearchmodel>
      cache: Option<bool>
      cache_threshold: Option<AiSearchUpdateInstancePayloadCachethreshold>
      chunk: Option<bool>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      custom_metadata: Option<list<AiSearchUpdateInstancePayloadCustommetadata>>
      embedding_model: Option<AiSearchUpdateInstancePayloadEmbeddingmodel>
      fusion_method: Option<AiSearchUpdateInstancePayloadFusionmethod>
      ///Controls which storage backends are used during indexing. Defaults to vector-only.
      index_method: Option<AiSearchUpdateInstancePayloadIndexmethod>
      indexing_options: Option<AiSearchUpdateInstancePayloadIndexingoptions>
      max_num_results: Option<int>
      metadata: Option<AiSearchUpdateInstancePayloadMetadata>
      paused: Option<bool>
      public_endpoint_params: Option<AiSearchUpdateInstancePayloadPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<AiSearchUpdateInstancePayloadRerankingmodel>
      retrieval_options: Option<AiSearchUpdateInstancePayloadRetrievaloptions>
      rewrite_model: Option<AiSearchUpdateInstancePayloadRewritemodel>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source_params: Option<AiSearchUpdateInstancePayloadSourceparams>
      summarization: Option<bool>
      summarization_model: Option<Summarizationmodel>
      ///Interval between automatic syncs, in seconds. Allowed values: 900 (15min), 1800 (30min), 3600 (1h), 7200 (2h), 14400 (4h), 21600 (6h), 43200 (12h), 86400 (24h).
      sync_interval: Option<obj>
      system_prompt_ai_search: Option<string>
      system_prompt_index_summarization: Option<string>
      system_prompt_rewrite_query: Option<string>
      token_id: Option<System.Guid> }
    ///Creates an instance of AiSearchUpdateInstancePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateInstancePayload =
        { ai_gateway_id = None
          ai_search_model = None
          cache = None
          cache_threshold = None
          chunk = None
          chunk_overlap = None
          chunk_size = None
          custom_metadata = None
          embedding_model = None
          fusion_method = None
          index_method = None
          indexing_options = None
          max_num_results = None
          metadata = None
          paused = None
          public_endpoint_params = None
          reranking = None
          reranking_model = None
          retrieval_options = None
          rewrite_model = None
          rewrite_query = None
          score_threshold = None
          source_params = None
          summarization = None
          summarization_model = None
          sync_interval = None
          system_prompt_ai_search = None
          system_prompt_index_summarization = None
          system_prompt_rewrite_query = None
          token_id = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstance_OKResultAisearchmodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstance_OKResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstance_OKResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    | [<CompiledName "datetime">] Datetime
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"
        | Datetime -> "datetime"

type AiSearchUpdateInstance_OKResultCustommetadata =
    { data_type: AiSearchUpdateInstance_OKResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstance_OKResultEmbeddingmodel =
    | [<CompiledName "@cf/qwen/qwen3-embedding-0.6b">] ``@cfQwenQwen3EmbeddingNumeric_0B``
    | [<CompiledName "@cf/baai/bge-m3">] ``@cfBaaiBgeM3``
    | [<CompiledName "@cf/baai/bge-large-en-v1.5">] ``@cfBaaiBgeLargeEnV1Numeric_5``
    | [<CompiledName "@cf/google/embeddinggemma-300m">] ``@cfGoogleEmbeddinggemmaM``
    | [<CompiledName "google-ai-studio/gemini-embedding-001">] GoogleAiStudioGeminiEmbeddingNumeric_001
    | [<CompiledName "google-ai-studio/gemini-embedding-2-preview">] GoogleAiStudioGeminiEmbeddingNumeric_2Preview
    | [<CompiledName "openai/text-embedding-3-small">] OpenaiTextEmbeddingNumeric_3Small
    | [<CompiledName "openai/text-embedding-3-large">] OpenaiTextEmbeddingNumeric_3Large
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfQwenQwen3EmbeddingNumeric_0B`` -> "@cf/qwen/qwen3-embedding-0.6b"
        | ``@cfBaaiBgeM3`` -> "@cf/baai/bge-m3"
        | ``@cfBaaiBgeLargeEnV1Numeric_5`` -> "@cf/baai/bge-large-en-v1.5"
        | ``@cfGoogleEmbeddinggemmaM`` -> "@cf/google/embeddinggemma-300m"
        | GoogleAiStudioGeminiEmbeddingNumeric_001 -> "google-ai-studio/gemini-embedding-001"
        | GoogleAiStudioGeminiEmbeddingNumeric_2Preview -> "google-ai-studio/gemini-embedding-2-preview"
        | OpenaiTextEmbeddingNumeric_3Small -> "openai/text-embedding-3-small"
        | OpenaiTextEmbeddingNumeric_3Large -> "openai/text-embedding-3-large"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstance_OKResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

///Controls which storage backends are used during indexing. Defaults to vector-only.
type AiSearchUpdateInstance_OKResultIndexmethod =
    { ///Enable keyword (BM25) storage backend.
      keyword: bool
      ///Enable vector (embedding) storage backend.
      vector: bool }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstance_OKResultIndexingoptionsKeywordtokenizer =
    | [<CompiledName "porter">] Porter
    | [<CompiledName "trigram">] Trigram
    member this.Format() =
        match this with
        | Porter -> "porter"
        | Trigram -> "trigram"

type AiSearchUpdateInstance_OKResultIndexingoptions =
    { ///Tokenizer used for keyword search indexing. porter provides word-level tokenization with Porter stemming (good for natural language queries). trigram enables character-level substring matching (good for partial matches, code, identifiers). Changing this triggers a full re-index. Defaults to porter.
      keyword_tokenizer: Option<AiSearchUpdateInstance_OKResultIndexingoptionsKeywordtokenizer> }

type AiSearchUpdateInstance_OKResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchUpdateInstance_OKResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchUpdateInstance_OKResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstance_OKResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchUpdateInstance_OKResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchUpdateInstance_OKResultPublicendpointparamsRatelimitTechnique> }

type AiSearchUpdateInstance_OKResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchUpdateInstance_OKResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchUpdateInstance_OKResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchUpdateInstance_OKResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchUpdateInstance_OKResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchUpdateInstance_OKResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstance_OKResultRerankingmodel =
    | [<CompiledName "@cf/baai/bge-reranker-base">] ``@cfBaaiBgeRerankerBase``
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfBaaiBgeRerankerBase`` -> "@cf/baai/bge-reranker-base"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstance_OKResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchUpdateInstance_OKResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchUpdateInstance_OKResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstance_OKResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

type AiSearchUpdateInstance_OKResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchUpdateInstance_OKResultRetrievaloptionsBoostby>>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchUpdateInstance_OKResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstance_OKResultRewritemodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstance_OKResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchUpdateInstance_OKResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchUpdateInstance_OKResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchUpdateInstance_OKResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchUpdateInstance_OKResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchUpdateInstance_OKResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstance_OKResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstance_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchUpdateInstance_OKResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchUpdateInstance_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchUpdateInstance_OKResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchUpdateInstance_OKResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchUpdateInstance_OKResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchUpdateInstance_OKResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchUpdateInstance_OKResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchUpdateInstance_OKResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchUpdateInstance_OKResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchUpdateInstance_OKResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchUpdateInstance_OKResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<AiSearchUpdateInstance_OKResultAisearchmodel>
      cache: Option<bool>
      cache_threshold: Option<AiSearchUpdateInstance_OKResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchUpdateInstance_OKResultCustommetadata>>
      embedding_model: Option<AiSearchUpdateInstance_OKResultEmbeddingmodel>
      enable: Option<bool>
      engine_version: Option<float>
      fusion_method: Option<AiSearchUpdateInstance_OKResultFusionmethod>
      ///AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.
      id: string
      ///Controls which storage backends are used during indexing. Defaults to vector-only.
      index_method: Option<AiSearchUpdateInstance_OKResultIndexmethod>
      indexing_options: Option<AiSearchUpdateInstance_OKResultIndexingoptions>
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchUpdateInstance_OKResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      ``namespace``: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchUpdateInstance_OKResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<AiSearchUpdateInstance_OKResultRerankingmodel>
      retrieval_options: Option<AiSearchUpdateInstance_OKResultRetrievaloptions>
      rewrite_model: Option<AiSearchUpdateInstance_OKResultRewritemodel>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchUpdateInstance_OKResultSourceparams>
      status: Option<string>
      ///Interval between automatic syncs, in seconds. Allowed values: 900 (15min), 1800 (30min), 3600 (1h), 7200 (2h), 14400 (4h), 21600 (6h), 43200 (12h), 86400 (24h).
      sync_interval: Option<obj>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchUpdateInstance_OKResultType> }

type AiSearchUpdateInstance_OK =
    { result: AiSearchUpdateInstance_OKResult
      success: bool }

type AiSearchUpdateInstance_BadRequestErrors = { code: float; message: string }

type AiSearchUpdateInstance_BadRequest =
    { errors: list<AiSearchUpdateInstance_BadRequestErrors>
      success: bool }

type AiSearchUpdateInstance_NotFoundErrors = { code: float; message: string }

type AiSearchUpdateInstance_NotFound =
    { errors: list<AiSearchUpdateInstance_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchUpdateInstance =
    ///Returns the updated instance.
    | OK of payload: AiSearchUpdateInstance_OK
    ///Ai search instance invalid token.
    | BadRequest of payload: AiSearchUpdateInstance_BadRequest
    ///Ai search not found.
    | NotFound of payload: AiSearchUpdateInstance_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CacheCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

type Cache =
    { cache_threshold: Option<CacheCachethreshold>
      enabled: Option<bool> }
    ///Creates an instance of Cache with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Cache =
        { cache_threshold = None
          enabled = None }

type Queryrewrite =
    { enabled: Option<bool>
      model: Option<obj>
      rewrite_prompt: Option<string> }
    ///Creates an instance of Queryrewrite with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Queryrewrite =
        { enabled = None
          model = None
          rewrite_prompt = None }

type Reranking =
    { enabled: Option<bool>
      match_threshold: Option<float>
      model: Option<obj> }
    ///Creates an instance of Reranking with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Reranking =
        { enabled = None
          match_threshold = None
          model = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RetrievalBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type RetrievalBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<RetrievalBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of RetrievalBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): RetrievalBoostby = { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RetrievalFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RetrievalKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Retrievaltype =
    | [<CompiledName "vector">] Vector
    | [<CompiledName "keyword">] Keyword
    | [<CompiledName "hybrid">] Hybrid
    member this.Format() =
        match this with
        | Vector -> "vector"
        | Keyword -> "keyword"
        | Hybrid -> "hybrid"

type Retrieval =
    { ///Metadata fields to boost search results by. Overrides the instance-level boost_by config. Direction defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<RetrievalBoostby>>
      context_expansion: Option<int>
      filters: Option<obj>
      fusion_method: Option<RetrievalFusionmethod>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<RetrievalKeywordmatchmode>
      match_threshold: Option<float>
      max_num_results: Option<int>
      retrieval_type: Option<Retrievaltype>
      return_on_failure: Option<bool> }
    ///Creates an instance of Retrieval with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Retrieval =
        { boost_by = None
          context_expansion = None
          filters = None
          fusion_method = None
          keyword_match_mode = None
          match_threshold = None
          max_num_results = None
          retrieval_type = None
          return_on_failure = None }

type Aisearchoptions =
    { cache: Option<Cache>
      query_rewrite: Option<Queryrewrite>
      reranking: Option<Reranking>
      retrieval: Option<Retrieval> }
    ///Creates an instance of Aisearchoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Aisearchoptions =
        { cache = None
          query_rewrite = None
          reranking = None
          retrieval = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Role =
    | [<CompiledName "system">] System
    | [<CompiledName "developer">] Developer
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    | [<CompiledName "tool">] Tool
    member this.Format() =
        match this with
        | System -> "system"
        | Developer -> "developer"
        | User -> "user"
        | Assistant -> "assistant"
        | Tool -> "tool"

type Messages =
    { content: string
      role: Role }
    ///Creates an instance of Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string, role: Role): Messages = { content = content; role = role }

type AiSearchInstanceChatCompletionPayload =
    { ai_search_options: Option<Aisearchoptions>
      messages: list<Messages>
      model: Option<string>
      stream: Option<bool> }
    ///Creates an instance of AiSearchInstanceChatCompletionPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (messages: list<Messages>): AiSearchInstanceChatCompletionPayload =
        { ai_search_options = None
          messages = messages
          model = None
          stream = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MessageRole =
    | [<CompiledName "system">] System
    | [<CompiledName "developer">] Developer
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    | [<CompiledName "tool">] Tool
    member this.Format() =
        match this with
        | System -> "system"
        | Developer -> "developer"
        | User -> "user"
        | Assistant -> "assistant"
        | Tool -> "tool"

type Message = { content: string; role: MessageRole }

type Choices =
    { index: Option<int>
      message: Message }

type Item =
    { key: string
      metadata: Option<obj>
      timestamp: Option<float> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ScoringdetailsFusionmethod =
    | [<CompiledName "rrf">] Rrf
    | [<CompiledName "max">] Max
    member this.Format() =
        match this with
        | Rrf -> "rrf"
        | Max -> "max"

type Scoringdetails =
    { fusion_method: Option<ScoringdetailsFusionmethod>
      keyword_rank: Option<float>
      keyword_score: Option<float>
      reranking_score: Option<float>
      vector_rank: Option<float>
      vector_score: Option<float> }

type Chunks =
    { id: string
      item: Option<Item>
      score: float
      scoring_details: Option<Scoringdetails>
      text: string
      ``type``: string }

type AiSearchInstanceChatCompletion_OK =
    { choices: list<Choices>
      chunks: list<Chunks>
      id: Option<string>
      model: Option<string>
      object: Option<string> }

type AiSearchInstanceChatCompletion_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchInstanceChatCompletion_BadRequest =
    { errors: list<AiSearchInstanceChatCompletion_BadRequestErrors>
      success: bool }

type AiSearchInstanceChatCompletion_NotFoundErrors = { code: float; message: string }

type AiSearchInstanceChatCompletion_NotFound =
    { errors: list<AiSearchInstanceChatCompletion_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceChatCompletion =
    ///Returns the chat completions results with retrieved files.
    | OK of payload: AiSearchInstanceChatCompletion_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchInstanceChatCompletion_BadRequest
    ///Not Found
    | NotFound of payload: AiSearchInstanceChatCompletion_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceListJobs_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AiSearchInstanceListJobs_OKResult =
    { description: Option<string>
      end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AiSearchInstanceListJobs_OKResultSource
      started_at: Option<string> }

type AiSearchInstanceListJobs_OKResultinfo =
    { count: int
      page: int
      per_page: int
      total_count: int }

type AiSearchInstanceListJobs_OK =
    { result: list<AiSearchInstanceListJobs_OKResult>
      result_info: AiSearchInstanceListJobs_OKResultinfo
      success: bool }

type AiSearchInstanceListJobs_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchInstanceListJobs_BadRequest =
    { errors: list<AiSearchInstanceListJobs_BadRequestErrors>
      success: bool }

type AiSearchInstanceListJobs_NotFoundErrors = { code: float; message: string }

type AiSearchInstanceListJobs_NotFound =
    { errors: list<AiSearchInstanceListJobs_NotFoundErrors>
      success: bool }

type AiSearchInstanceListJobs_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchInstanceListJobs_ServiceUnavailable =
    { errors: list<AiSearchInstanceListJobs_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceListJobs =
    ///Returns a list of AI Search Jobs.
    | OK of payload: AiSearchInstanceListJobs_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchInstanceListJobs_BadRequest
    ///Ai search not found.
    | NotFound of payload: AiSearchInstanceListJobs_NotFound
    ///Unable to connect to ai search.
    | ServiceUnavailable of payload: AiSearchInstanceListJobs_ServiceUnavailable

type AiSearchInstanceCreateJobPayload =
    { description: Option<string> }
    ///Creates an instance of AiSearchInstanceCreateJobPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceCreateJobPayload = { description = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceCreateJob_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AiSearchInstanceCreateJob_OKResult =
    { description: Option<string>
      end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AiSearchInstanceCreateJob_OKResultSource
      started_at: Option<string> }

type AiSearchInstanceCreateJob_OK =
    { result: AiSearchInstanceCreateJob_OKResult
      success: bool }

type AiSearchInstanceCreateJob_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchInstanceCreateJob_BadRequest =
    { errors: list<AiSearchInstanceCreateJob_BadRequestErrors>
      success: bool }

type AiSearchInstanceCreateJob_NotFoundErrors = { code: float; message: string }

type AiSearchInstanceCreateJob_NotFound =
    { errors: list<AiSearchInstanceCreateJob_NotFoundErrors>
      success: bool }

type AiSearchInstanceCreateJob_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchInstanceCreateJob_ServiceUnavailable =
    { errors: list<AiSearchInstanceCreateJob_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceCreateJob =
    ///Returns the AI Search job id.
    | OK of payload: AiSearchInstanceCreateJob_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchInstanceCreateJob_BadRequest
    ///Ai search not found.
    | NotFound of payload: AiSearchInstanceCreateJob_NotFound
    ///Unable to connect to ai search.
    | ServiceUnavailable of payload: AiSearchInstanceCreateJob_ServiceUnavailable

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceGetJob_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AiSearchInstanceGetJob_OKResult =
    { description: Option<string>
      end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AiSearchInstanceGetJob_OKResultSource
      started_at: Option<string> }

type AiSearchInstanceGetJob_OK =
    { result: AiSearchInstanceGetJob_OKResult
      success: bool }

type AiSearchInstanceGetJob_NotFoundErrors = { code: float; message: string }

type AiSearchInstanceGetJob_NotFound =
    { errors: list<AiSearchInstanceGetJob_NotFoundErrors>
      success: bool }

type AiSearchInstanceGetJob_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchInstanceGetJob_ServiceUnavailable =
    { errors: list<AiSearchInstanceGetJob_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceGetJob =
    ///Returns a AI Search Job Details.
    | OK of payload: AiSearchInstanceGetJob_OK
    ///Job not found.
    | NotFound of payload: AiSearchInstanceGetJob_NotFound
    ///Unable to connect to ai search.
    | ServiceUnavailable of payload: AiSearchInstanceGetJob_ServiceUnavailable

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Action =
    | [<CompiledName "cancel">] Cancel
    member this.Format() =
        match this with
        | Cancel -> "cancel"

type AiSearchInstanceChangeJobStatusPayload =
    { action: Action }
    ///Creates an instance of AiSearchInstanceChangeJobStatusPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (action: Action): AiSearchInstanceChangeJobStatusPayload = { action = action }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceChangeJobStatus_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AiSearchInstanceChangeJobStatus_OKResult =
    { description: Option<string>
      end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AiSearchInstanceChangeJobStatus_OKResultSource
      started_at: Option<string> }

type AiSearchInstanceChangeJobStatus_OK =
    { result: AiSearchInstanceChangeJobStatus_OKResult
      success: bool }

type AiSearchInstanceChangeJobStatus_BadRequestErrors = { code: float; message: string }

type AiSearchInstanceChangeJobStatus_BadRequest =
    { errors: list<AiSearchInstanceChangeJobStatus_BadRequestErrors>
      success: bool }

type AiSearchInstanceChangeJobStatus_NotFoundErrors = { code: float; message: string }

type AiSearchInstanceChangeJobStatus_NotFound =
    { errors: list<AiSearchInstanceChangeJobStatus_NotFoundErrors>
      success: bool }

type AiSearchInstanceChangeJobStatus_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchInstanceChangeJobStatus_ServiceUnavailable =
    { errors: list<AiSearchInstanceChangeJobStatus_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceChangeJobStatus =
    ///Returns the updated AI Search Job.
    | OK of payload: AiSearchInstanceChangeJobStatus_OK
    ///Job cannot be cancelled.
    | BadRequest of payload: AiSearchInstanceChangeJobStatus_BadRequest
    ///Job not found.
    | NotFound of payload: AiSearchInstanceChangeJobStatus_NotFound
    ///Unable to connect to ai search.
    | ServiceUnavailable of payload: AiSearchInstanceChangeJobStatus_ServiceUnavailable

type AiSearchInstanceListJobLogs_OKResult =
    { created_at: float
      id: int
      message: string
      message_type: int }

type AiSearchInstanceListJobLogs_OKResultinfo =
    { count: int
      page: int
      per_page: int
      total_count: int }

type AiSearchInstanceListJobLogs_OK =
    { result: list<AiSearchInstanceListJobLogs_OKResult>
      result_info: AiSearchInstanceListJobLogs_OKResultinfo
      success: bool }

type AiSearchInstanceListJobLogs_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchInstanceListJobLogs_BadRequest =
    { errors: list<AiSearchInstanceListJobLogs_BadRequestErrors>
      success: bool }

type AiSearchInstanceListJobLogs_NotFoundErrors = { code: float; message: string }

type AiSearchInstanceListJobLogs_NotFound =
    { errors: list<AiSearchInstanceListJobLogs_NotFoundErrors>
      success: bool }

type AiSearchInstanceListJobLogs_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchInstanceListJobLogs_ServiceUnavailable =
    { errors: list<AiSearchInstanceListJobLogs_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceListJobLogs =
    ///Returns a list of AI Search Job Logs.
    | OK of payload: AiSearchInstanceListJobLogs_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchInstanceListJobLogs_BadRequest
    ///Ai search not found.
    | NotFound of payload: AiSearchInstanceListJobLogs_NotFound
    ///Unable to connect to ai search.
    | ServiceUnavailable of payload: AiSearchInstanceListJobLogs_ServiceUnavailable

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearchPayloadAisearchoptionsCacheCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

type AiSearchInstanceSearchPayloadAisearchoptionsCache =
    { cache_threshold: Option<AiSearchInstanceSearchPayloadAisearchoptionsCacheCachethreshold>
      enabled: Option<bool> }
    ///Creates an instance of AiSearchInstanceSearchPayloadAisearchoptionsCache with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceSearchPayloadAisearchoptionsCache =
        { cache_threshold = None
          enabled = None }

type AiSearchInstanceSearchPayloadAisearchoptionsQueryrewrite =
    { enabled: Option<bool>
      model: Option<obj>
      rewrite_prompt: Option<string> }
    ///Creates an instance of AiSearchInstanceSearchPayloadAisearchoptionsQueryrewrite with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceSearchPayloadAisearchoptionsQueryrewrite =
        { enabled = None
          model = None
          rewrite_prompt = None }

type AiSearchInstanceSearchPayloadAisearchoptionsReranking =
    { enabled: Option<bool>
      match_threshold: Option<float>
      model: Option<obj> }
    ///Creates an instance of AiSearchInstanceSearchPayloadAisearchoptionsReranking with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceSearchPayloadAisearchoptionsReranking =
        { enabled = None
          match_threshold = None
          model = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostby =
        { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearchPayloadAisearchoptionsRetrievalFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearchPayloadAisearchoptionsRetrievalKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearchPayloadAisearchoptionsRetrievalRetrievaltype =
    | [<CompiledName "vector">] Vector
    | [<CompiledName "keyword">] Keyword
    | [<CompiledName "hybrid">] Hybrid
    member this.Format() =
        match this with
        | Vector -> "vector"
        | Keyword -> "keyword"
        | Hybrid -> "hybrid"

type AiSearchInstanceSearchPayloadAisearchoptionsRetrieval =
    { ///Metadata fields to boost search results by. Overrides the instance-level boost_by config. Direction defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchInstanceSearchPayloadAisearchoptionsRetrievalBoostby>>
      context_expansion: Option<int>
      filters: Option<obj>
      fusion_method: Option<AiSearchInstanceSearchPayloadAisearchoptionsRetrievalFusionmethod>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchInstanceSearchPayloadAisearchoptionsRetrievalKeywordmatchmode>
      match_threshold: Option<float>
      max_num_results: Option<int>
      retrieval_type: Option<AiSearchInstanceSearchPayloadAisearchoptionsRetrievalRetrievaltype>
      return_on_failure: Option<bool> }
    ///Creates an instance of AiSearchInstanceSearchPayloadAisearchoptionsRetrieval with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceSearchPayloadAisearchoptionsRetrieval =
        { boost_by = None
          context_expansion = None
          filters = None
          fusion_method = None
          keyword_match_mode = None
          match_threshold = None
          max_num_results = None
          retrieval_type = None
          return_on_failure = None }

type AiSearchInstanceSearchPayloadAisearchoptions =
    { cache: Option<AiSearchInstanceSearchPayloadAisearchoptionsCache>
      query_rewrite: Option<AiSearchInstanceSearchPayloadAisearchoptionsQueryrewrite>
      reranking: Option<AiSearchInstanceSearchPayloadAisearchoptionsReranking>
      retrieval: Option<AiSearchInstanceSearchPayloadAisearchoptionsRetrieval> }
    ///Creates an instance of AiSearchInstanceSearchPayloadAisearchoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceSearchPayloadAisearchoptions =
        { cache = None
          query_rewrite = None
          reranking = None
          retrieval = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearchPayloadMessagesRole =
    | [<CompiledName "system">] System
    | [<CompiledName "developer">] Developer
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    | [<CompiledName "tool">] Tool
    member this.Format() =
        match this with
        | System -> "system"
        | Developer -> "developer"
        | User -> "user"
        | Assistant -> "assistant"
        | Tool -> "tool"

type AiSearchInstanceSearchPayloadMessages =
    { content: string
      role: AiSearchInstanceSearchPayloadMessagesRole }
    ///Creates an instance of AiSearchInstanceSearchPayloadMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string, role: AiSearchInstanceSearchPayloadMessagesRole): AiSearchInstanceSearchPayloadMessages =
        { content = content; role = role }

type AiSearchInstanceSearchPayload =
    { ai_search_options: Option<AiSearchInstanceSearchPayloadAisearchoptions>
      messages: Option<list<AiSearchInstanceSearchPayloadMessages>>
      ///A simple text query string. Alternative to 'messages' — provide either this or 'messages', not both.
      query: Option<string> }
    ///Creates an instance of AiSearchInstanceSearchPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchInstanceSearchPayload =
        { ai_search_options = None
          messages = None
          query = None }

type AiSearchInstanceSearch_OKResultChunksItem =
    { key: string
      metadata: Option<obj>
      timestamp: Option<float> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchInstanceSearch_OKResultChunksScoringdetailsFusionmethod =
    | [<CompiledName "rrf">] Rrf
    | [<CompiledName "max">] Max
    member this.Format() =
        match this with
        | Rrf -> "rrf"
        | Max -> "max"

type AiSearchInstanceSearch_OKResultChunksScoringdetails =
    { fusion_method: Option<AiSearchInstanceSearch_OKResultChunksScoringdetailsFusionmethod>
      keyword_rank: Option<float>
      keyword_score: Option<float>
      reranking_score: Option<float>
      vector_rank: Option<float>
      vector_score: Option<float> }

type AiSearchInstanceSearch_OKResultChunks =
    { id: string
      item: Option<AiSearchInstanceSearch_OKResultChunksItem>
      score: float
      scoring_details: Option<AiSearchInstanceSearch_OKResultChunksScoringdetails>
      text: string
      ``type``: string }

type AiSearchInstanceSearch_OKResult =
    { chunks: list<AiSearchInstanceSearch_OKResultChunks>
      search_query: string }

type AiSearchInstanceSearch_OK =
    { result: AiSearchInstanceSearch_OKResult
      success: bool }

type AiSearchInstanceSearch_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchInstanceSearch_BadRequest =
    { errors: list<AiSearchInstanceSearch_BadRequestErrors>
      success: bool }

type AiSearchInstanceSearch_NotFoundErrors = { code: float; message: string }

type AiSearchInstanceSearch_NotFound =
    { errors: list<AiSearchInstanceSearch_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchInstanceSearch =
    ///Returns the search results.
    | OK of payload: AiSearchInstanceSearch_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchInstanceSearch_BadRequest
    ///Not Found
    | NotFound of payload: AiSearchInstanceSearch_NotFound

///R2 bucket storage usage in bytes.
type R2 =
    { metadataSizeBytes: int
      objectCount: int
      payloadSizeBytes: int }

///Vectorize index metadata (dimensions, vector count).
type Vectorize = { dimensions: int; vectorsCount: int }

///Engine-specific metadata. Present only for managed (v3) instances.
type Engine =
    { ///R2 bucket storage usage in bytes.
      r2: Option<R2>
      ///Vectorize index metadata (dimensions, vector count).
      vectorize: Option<Vectorize> }

type AiSearchStats_OKResult =
    { completed: Option<int>
      ///Engine-specific metadata. Present only for managed (v3) instances.
      engine: Option<Engine>
      error: Option<int>
      file_embed_errors: Option<Map<string, obj>>
      index_source_errors: Option<Map<string, obj>>
      last_activity: Option<System.DateTimeOffset>
      outdated: Option<int>
      queued: Option<int>
      running: Option<int>
      skipped: Option<int> }

type AiSearchStats_OK =
    { result: AiSearchStats_OKResult
      success: bool }

type AiSearchStats_NotFoundErrors = { code: float; message: string }

type AiSearchStats_NotFound =
    { errors: list<AiSearchStats_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchStats =
    ///Returns the AI Search stats.
    | OK of payload: AiSearchStats_OK
    ///Not Found
    | NotFound of payload: AiSearchStats_NotFound

type AiSearchListNamespaces_OKResult =
    { created_at: System.DateTimeOffset
      ///Optional description for the namespace. Max 256 characters.
      description: Option<string>
      name: string }

type AiSearchListNamespaces_OKResultinfo =
    { count: float
      page: float
      per_page: float
      total_count: float }

type AiSearchListNamespaces_OK =
    { result: list<AiSearchListNamespaces_OKResult>
      result_info: AiSearchListNamespaces_OKResultinfo
      success: bool }

type AiSearchListNamespaces_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchListNamespaces_BadRequest =
    { errors: list<AiSearchListNamespaces_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchListNamespaces =
    ///List of namespaces.
    | OK of payload: AiSearchListNamespaces_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchListNamespaces_BadRequest

type AiSearchCreateNamespacePayload =
    { ///Optional description for the namespace. Max 256 characters.
      description: Option<string>
      name: string }
    ///Creates an instance of AiSearchCreateNamespacePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string): AiSearchCreateNamespacePayload = { description = None; name = name }

type AiSearchCreateNamespace_CreatedResult =
    { created_at: System.DateTimeOffset
      ///Optional description for the namespace. Max 256 characters.
      description: Option<string>
      name: string }

type AiSearchCreateNamespace_Created =
    { result: AiSearchCreateNamespace_CreatedResult
      success: bool }

type AiSearchCreateNamespace_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchCreateNamespace_BadRequest =
    { errors: list<AiSearchCreateNamespace_BadRequestErrors>
      success: bool }

type AiSearchCreateNamespace_ForbiddenErrors = { code: float; message: string }

type AiSearchCreateNamespace_Forbidden =
    { errors: list<AiSearchCreateNamespace_ForbiddenErrors>
      success: bool }

type AiSearchCreateNamespace_ConflictErrors = { code: float; message: string }

type AiSearchCreateNamespace_Conflict =
    { errors: list<AiSearchCreateNamespace_ConflictErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchCreateNamespace =
    ///Namespace created.
    | Created of payload: AiSearchCreateNamespace_Created
    ///Input Validation Error
    | BadRequest of payload: AiSearchCreateNamespace_BadRequest
    ///Max namespaces reached.
    | Forbidden of payload: AiSearchCreateNamespace_Forbidden
    ///Namespace already exists.
    | Conflict of payload: AiSearchCreateNamespace_Conflict

type AiSearchDeleteNamespace_OK =
    { result: obj
      success: bool }

type AiSearchDeleteNamespace_BadRequestErrors = { code: float; message: string }

type AiSearchDeleteNamespace_BadRequest =
    { errors: list<AiSearchDeleteNamespace_BadRequestErrors>
      success: bool }

type AiSearchDeleteNamespace_NotFoundErrors = { code: float; message: string }

type AiSearchDeleteNamespace_NotFound =
    { errors: list<AiSearchDeleteNamespace_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchDeleteNamespace =
    ///Namespace deleted.
    | OK of payload: AiSearchDeleteNamespace_OK
    ///Namespace not empty.
    | BadRequest of payload: AiSearchDeleteNamespace_BadRequest
    ///Namespace not found.
    | NotFound of payload: AiSearchDeleteNamespace_NotFound

type AiSearchFetchNamespace_OKResult =
    { created_at: System.DateTimeOffset
      ///Optional description for the namespace. Max 256 characters.
      description: Option<string>
      name: string }

type AiSearchFetchNamespace_OK =
    { result: AiSearchFetchNamespace_OKResult
      success: bool }

type AiSearchFetchNamespace_NotFoundErrors = { code: float; message: string }

type AiSearchFetchNamespace_NotFound =
    { errors: list<AiSearchFetchNamespace_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchFetchNamespace =
    ///Namespace details.
    | OK of payload: AiSearchFetchNamespace_OK
    ///Namespace not found.
    | NotFound of payload: AiSearchFetchNamespace_NotFound

type AiSearchUpdateNamespacePayload =
    { ///Optional description for the namespace. Max 256 characters.
      description: Option<string> }
    ///Creates an instance of AiSearchUpdateNamespacePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchUpdateNamespacePayload = { description = None }

type AiSearchUpdateNamespace_OKResult =
    { created_at: System.DateTimeOffset
      ///Optional description for the namespace. Max 256 characters.
      description: Option<string>
      name: string }

type AiSearchUpdateNamespace_OK =
    { result: AiSearchUpdateNamespace_OKResult
      success: bool }

type AiSearchUpdateNamespace_BadRequestErrors = { code: float; message: string }

type AiSearchUpdateNamespace_BadRequest =
    { errors: list<AiSearchUpdateNamespace_BadRequestErrors>
      success: bool }

type AiSearchUpdateNamespace_NotFoundErrors = { code: float; message: string }

type AiSearchUpdateNamespace_NotFound =
    { errors: list<AiSearchUpdateNamespace_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchUpdateNamespace =
    ///Returns the updated namespace.
    | OK of payload: AiSearchUpdateNamespace_OK
    ///Cannot modify default namespace.
    | BadRequest of payload: AiSearchUpdateNamespace_BadRequest
    ///Namespace not found.
    | NotFound of payload: AiSearchUpdateNamespace_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsCacheCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

type AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsCache =
    { cache_threshold: Option<AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsCacheCachethreshold>
      enabled: Option<bool> }
    ///Creates an instance of AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsCache with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsCache =
        { cache_threshold = None
          enabled = None }

type AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsQueryrewrite =
    { enabled: Option<bool>
      model: Option<string>
      rewrite_prompt: Option<string> }
    ///Creates an instance of AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsQueryrewrite with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsQueryrewrite =
        { enabled = None
          model = None
          rewrite_prompt = None }

type AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsReranking =
    { enabled: Option<bool>
      match_threshold: Option<float>
      model: Option<string> }
    ///Creates an instance of AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsReranking with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsReranking =
        { enabled = None
          match_threshold = None
          model = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsRetrievalBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsRetrievalBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsRetrievalBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsRetrievalBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsRetrievalBoostby =
        { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsRetrievalFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsRetrievalKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsRetrievalRetrievaltype =
    | [<CompiledName "vector">] Vector
    | [<CompiledName "keyword">] Keyword
    | [<CompiledName "hybrid">] Hybrid
    member this.Format() =
        match this with
        | Vector -> "vector"
        | Keyword -> "keyword"
        | Hybrid -> "hybrid"

type AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsRetrieval =
    { ///Metadata fields to boost search results by. Overrides the instance-level boost_by config. Direction defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsRetrievalBoostby>>
      context_expansion: Option<int>
      filters: Option<obj>
      fusion_method: Option<AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsRetrievalFusionmethod>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsRetrievalKeywordmatchmode>
      match_threshold: Option<float>
      max_num_results: Option<int>
      retrieval_type: Option<AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsRetrievalRetrievaltype>
      return_on_failure: Option<bool> }
    ///Creates an instance of AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsRetrieval with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsRetrieval =
        { boost_by = None
          context_expansion = None
          filters = None
          fusion_method = None
          keyword_match_mode = None
          match_threshold = None
          max_num_results = None
          retrieval_type = None
          return_on_failure = None }

type AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptions =
    { cache: Option<AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsCache>
      instance_ids: list<string>
      query_rewrite: Option<AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsQueryrewrite>
      reranking: Option<AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsReranking>
      retrieval: Option<AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptionsRetrieval> }
    ///Creates an instance of AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (instance_ids: list<string>): AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptions =
        { cache = None
          instance_ids = instance_ids
          query_rewrite = None
          reranking = None
          retrieval = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceChatCompletionPayloadMessagesRole =
    | [<CompiledName "system">] System
    | [<CompiledName "developer">] Developer
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    | [<CompiledName "tool">] Tool
    member this.Format() =
        match this with
        | System -> "system"
        | Developer -> "developer"
        | User -> "user"
        | Assistant -> "assistant"
        | Tool -> "tool"

type AiSearchNamespaceMultiInstanceChatCompletionPayloadMessages =
    { content: string
      role: AiSearchNamespaceMultiInstanceChatCompletionPayloadMessagesRole }
    ///Creates an instance of AiSearchNamespaceMultiInstanceChatCompletionPayloadMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string, role: AiSearchNamespaceMultiInstanceChatCompletionPayloadMessagesRole): AiSearchNamespaceMultiInstanceChatCompletionPayloadMessages =
        { content = content; role = role }

type AiSearchNamespaceMultiInstanceChatCompletionPayload =
    { ai_search_options: AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptions
      messages: list<AiSearchNamespaceMultiInstanceChatCompletionPayloadMessages>
      model: Option<string>
      stream: Option<bool> }
    ///Creates an instance of AiSearchNamespaceMultiInstanceChatCompletionPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (ai_search_options: AiSearchNamespaceMultiInstanceChatCompletionPayloadAisearchoptions,
                          messages: list<AiSearchNamespaceMultiInstanceChatCompletionPayloadMessages>): AiSearchNamespaceMultiInstanceChatCompletionPayload =
        { ai_search_options = ai_search_options
          messages = messages
          model = None
          stream = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceChatCompletion_OKChoicesMessageRole =
    | [<CompiledName "system">] System
    | [<CompiledName "developer">] Developer
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    | [<CompiledName "tool">] Tool
    member this.Format() =
        match this with
        | System -> "system"
        | Developer -> "developer"
        | User -> "user"
        | Assistant -> "assistant"
        | Tool -> "tool"

type AiSearchNamespaceMultiInstanceChatCompletion_OKChoicesMessage =
    { content: string
      role: AiSearchNamespaceMultiInstanceChatCompletion_OKChoicesMessageRole }

type AiSearchNamespaceMultiInstanceChatCompletion_OKChoices =
    { index: Option<int>
      message: AiSearchNamespaceMultiInstanceChatCompletion_OKChoicesMessage }

type AiSearchNamespaceMultiInstanceChatCompletion_OKChunksItem =
    { key: string
      metadata: Option<obj>
      timestamp: Option<float> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceChatCompletion_OKChunksScoringdetailsFusionmethod =
    | [<CompiledName "rrf">] Rrf
    | [<CompiledName "max">] Max
    member this.Format() =
        match this with
        | Rrf -> "rrf"
        | Max -> "max"

type AiSearchNamespaceMultiInstanceChatCompletion_OKChunksScoringdetails =
    { fusion_method: Option<AiSearchNamespaceMultiInstanceChatCompletion_OKChunksScoringdetailsFusionmethod>
      keyword_rank: Option<float>
      keyword_score: Option<float>
      reranking_score: Option<float>
      vector_rank: Option<float>
      vector_score: Option<float> }

type AiSearchNamespaceMultiInstanceChatCompletion_OKChunks =
    { id: string
      instance_id: string
      item: Option<AiSearchNamespaceMultiInstanceChatCompletion_OKChunksItem>
      score: float
      scoring_details: Option<AiSearchNamespaceMultiInstanceChatCompletion_OKChunksScoringdetails>
      text: string
      ``type``: string }

type AiSearchNamespaceMultiInstanceChatCompletion_OKErrors =
    { instance_id: string
      message: string }

type AiSearchNamespaceMultiInstanceChatCompletion_OK =
    { choices: list<AiSearchNamespaceMultiInstanceChatCompletion_OKChoices>
      chunks: list<AiSearchNamespaceMultiInstanceChatCompletion_OKChunks>
      errors: Option<list<AiSearchNamespaceMultiInstanceChatCompletion_OKErrors>>
      id: Option<string>
      model: Option<string>
      object: Option<string> }

type AiSearchNamespaceMultiInstanceChatCompletion_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchNamespaceMultiInstanceChatCompletion_BadRequest =
    { errors: list<AiSearchNamespaceMultiInstanceChatCompletion_BadRequestErrors>
      success: bool }

type AiSearchNamespaceMultiInstanceChatCompletion_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceMultiInstanceChatCompletion_NotFound =
    { errors: list<AiSearchNamespaceMultiInstanceChatCompletion_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceChatCompletion =
    ///Returns the chat completion result with merged chunks from all instances.
    | OK of payload: AiSearchNamespaceMultiInstanceChatCompletion_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchNamespaceMultiInstanceChatCompletion_BadRequest
    ///Not Found
    | NotFound of payload: AiSearchNamespaceMultiInstanceChatCompletion_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceListInstances_OKResultAisearchmodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceListInstances_OKResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceListInstances_OKResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    | [<CompiledName "datetime">] Datetime
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"
        | Datetime -> "datetime"

type AiSearchNamespaceListInstances_OKResultCustommetadata =
    { data_type: AiSearchNamespaceListInstances_OKResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceListInstances_OKResultEmbeddingmodel =
    | [<CompiledName "@cf/qwen/qwen3-embedding-0.6b">] ``@cfQwenQwen3EmbeddingNumeric_0B``
    | [<CompiledName "@cf/baai/bge-m3">] ``@cfBaaiBgeM3``
    | [<CompiledName "@cf/baai/bge-large-en-v1.5">] ``@cfBaaiBgeLargeEnV1Numeric_5``
    | [<CompiledName "@cf/google/embeddinggemma-300m">] ``@cfGoogleEmbeddinggemmaM``
    | [<CompiledName "google-ai-studio/gemini-embedding-001">] GoogleAiStudioGeminiEmbeddingNumeric_001
    | [<CompiledName "google-ai-studio/gemini-embedding-2-preview">] GoogleAiStudioGeminiEmbeddingNumeric_2Preview
    | [<CompiledName "openai/text-embedding-3-small">] OpenaiTextEmbeddingNumeric_3Small
    | [<CompiledName "openai/text-embedding-3-large">] OpenaiTextEmbeddingNumeric_3Large
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfQwenQwen3EmbeddingNumeric_0B`` -> "@cf/qwen/qwen3-embedding-0.6b"
        | ``@cfBaaiBgeM3`` -> "@cf/baai/bge-m3"
        | ``@cfBaaiBgeLargeEnV1Numeric_5`` -> "@cf/baai/bge-large-en-v1.5"
        | ``@cfGoogleEmbeddinggemmaM`` -> "@cf/google/embeddinggemma-300m"
        | GoogleAiStudioGeminiEmbeddingNumeric_001 -> "google-ai-studio/gemini-embedding-001"
        | GoogleAiStudioGeminiEmbeddingNumeric_2Preview -> "google-ai-studio/gemini-embedding-2-preview"
        | OpenaiTextEmbeddingNumeric_3Small -> "openai/text-embedding-3-small"
        | OpenaiTextEmbeddingNumeric_3Large -> "openai/text-embedding-3-large"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceListInstances_OKResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

///Controls which storage backends are used during indexing. Defaults to vector-only.
type AiSearchNamespaceListInstances_OKResultIndexmethod =
    { ///Enable keyword (BM25) storage backend.
      keyword: bool
      ///Enable vector (embedding) storage backend.
      vector: bool }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceListInstances_OKResultIndexingoptionsKeywordtokenizer =
    | [<CompiledName "porter">] Porter
    | [<CompiledName "trigram">] Trigram
    member this.Format() =
        match this with
        | Porter -> "porter"
        | Trigram -> "trigram"

type AiSearchNamespaceListInstances_OKResultIndexingoptions =
    { ///Tokenizer used for keyword search indexing. porter provides word-level tokenization with Porter stemming (good for natural language queries). trigram enables character-level substring matching (good for partial matches, code, identifiers). Changing this triggers a full re-index. Defaults to porter.
      keyword_tokenizer: Option<AiSearchNamespaceListInstances_OKResultIndexingoptionsKeywordtokenizer> }

type AiSearchNamespaceListInstances_OKResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchNamespaceListInstances_OKResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchNamespaceListInstances_OKResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceListInstances_OKResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchNamespaceListInstances_OKResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchNamespaceListInstances_OKResultPublicendpointparamsRatelimitTechnique> }

type AiSearchNamespaceListInstances_OKResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchNamespaceListInstances_OKResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchNamespaceListInstances_OKResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchNamespaceListInstances_OKResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchNamespaceListInstances_OKResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchNamespaceListInstances_OKResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceListInstances_OKResultRerankingmodel =
    | [<CompiledName "@cf/baai/bge-reranker-base">] ``@cfBaaiBgeRerankerBase``
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfBaaiBgeRerankerBase`` -> "@cf/baai/bge-reranker-base"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceListInstances_OKResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchNamespaceListInstances_OKResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchNamespaceListInstances_OKResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceListInstances_OKResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

type AiSearchNamespaceListInstances_OKResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchNamespaceListInstances_OKResultRetrievaloptionsBoostby>>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchNamespaceListInstances_OKResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceListInstances_OKResultRewritemodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceListInstances_OKResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchNamespaceListInstances_OKResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchNamespaceListInstances_OKResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchNamespaceListInstances_OKResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchNamespaceListInstances_OKResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchNamespaceListInstances_OKResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceListInstances_OKResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceListInstances_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchNamespaceListInstances_OKResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchNamespaceListInstances_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchNamespaceListInstances_OKResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchNamespaceListInstances_OKResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchNamespaceListInstances_OKResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchNamespaceListInstances_OKResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchNamespaceListInstances_OKResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchNamespaceListInstances_OKResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchNamespaceListInstances_OKResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceListInstances_OKResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchNamespaceListInstances_OKResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<AiSearchNamespaceListInstances_OKResultAisearchmodel>
      cache: Option<bool>
      cache_threshold: Option<AiSearchNamespaceListInstances_OKResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchNamespaceListInstances_OKResultCustommetadata>>
      embedding_model: Option<AiSearchNamespaceListInstances_OKResultEmbeddingmodel>
      enable: Option<bool>
      engine_version: Option<float>
      fusion_method: Option<AiSearchNamespaceListInstances_OKResultFusionmethod>
      ///AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.
      id: string
      ///Controls which storage backends are used during indexing. Defaults to vector-only.
      index_method: Option<AiSearchNamespaceListInstances_OKResultIndexmethod>
      indexing_options: Option<AiSearchNamespaceListInstances_OKResultIndexingoptions>
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchNamespaceListInstances_OKResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      ``namespace``: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchNamespaceListInstances_OKResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<AiSearchNamespaceListInstances_OKResultRerankingmodel>
      retrieval_options: Option<AiSearchNamespaceListInstances_OKResultRetrievaloptions>
      rewrite_model: Option<AiSearchNamespaceListInstances_OKResultRewritemodel>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchNamespaceListInstances_OKResultSourceparams>
      status: Option<string>
      ///Interval between automatic syncs, in seconds. Allowed values: 900 (15min), 1800 (30min), 3600 (1h), 7200 (2h), 14400 (4h), 21600 (6h), 43200 (12h), 86400 (24h).
      sync_interval: Option<obj>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchNamespaceListInstances_OKResultType> }

type AiSearchNamespaceListInstances_OKResultinfo =
    { count: float
      page: float
      per_page: float
      total_count: float }

type AiSearchNamespaceListInstances_OK =
    { result: list<AiSearchNamespaceListInstances_OKResult>
      result_info: AiSearchNamespaceListInstances_OKResultinfo
      success: bool }

type AiSearchNamespaceListInstances_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchNamespaceListInstances_BadRequest =
    { errors: list<AiSearchNamespaceListInstances_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceListInstances =
    ///List of instances.
    | OK of payload: AiSearchNamespaceListInstances_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchNamespaceListInstances_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstancePayloadAisearchmodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstancePayloadCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstancePayloadCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    | [<CompiledName "datetime">] Datetime
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"
        | Datetime -> "datetime"

type AiSearchNamespaceCreateInstancePayloadCustommetadata =
    { data_type: AiSearchNamespaceCreateInstancePayloadCustommetadataDatatype
      field_name: string }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadCustommetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (data_type: AiSearchNamespaceCreateInstancePayloadCustommetadataDatatype, field_name: string): AiSearchNamespaceCreateInstancePayloadCustommetadata =
        { data_type = data_type
          field_name = field_name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstancePayloadEmbeddingmodel =
    | [<CompiledName "@cf/qwen/qwen3-embedding-0.6b">] ``@cfQwenQwen3EmbeddingNumeric_0B``
    | [<CompiledName "@cf/baai/bge-m3">] ``@cfBaaiBgeM3``
    | [<CompiledName "@cf/baai/bge-large-en-v1.5">] ``@cfBaaiBgeLargeEnV1Numeric_5``
    | [<CompiledName "@cf/google/embeddinggemma-300m">] ``@cfGoogleEmbeddinggemmaM``
    | [<CompiledName "google-ai-studio/gemini-embedding-001">] GoogleAiStudioGeminiEmbeddingNumeric_001
    | [<CompiledName "google-ai-studio/gemini-embedding-2-preview">] GoogleAiStudioGeminiEmbeddingNumeric_2Preview
    | [<CompiledName "openai/text-embedding-3-small">] OpenaiTextEmbeddingNumeric_3Small
    | [<CompiledName "openai/text-embedding-3-large">] OpenaiTextEmbeddingNumeric_3Large
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfQwenQwen3EmbeddingNumeric_0B`` -> "@cf/qwen/qwen3-embedding-0.6b"
        | ``@cfBaaiBgeM3`` -> "@cf/baai/bge-m3"
        | ``@cfBaaiBgeLargeEnV1Numeric_5`` -> "@cf/baai/bge-large-en-v1.5"
        | ``@cfGoogleEmbeddinggemmaM`` -> "@cf/google/embeddinggemma-300m"
        | GoogleAiStudioGeminiEmbeddingNumeric_001 -> "google-ai-studio/gemini-embedding-001"
        | GoogleAiStudioGeminiEmbeddingNumeric_2Preview -> "google-ai-studio/gemini-embedding-2-preview"
        | OpenaiTextEmbeddingNumeric_3Small -> "openai/text-embedding-3-small"
        | OpenaiTextEmbeddingNumeric_3Large -> "openai/text-embedding-3-large"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstancePayloadFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

///Controls which storage backends are used during indexing. Defaults to vector-only.
type AiSearchNamespaceCreateInstancePayloadIndexmethod =
    { ///Enable keyword (BM25) storage backend.
      keyword: bool
      ///Enable vector (embedding) storage backend.
      vector: bool }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadIndexmethod with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (keyword: bool, vector: bool): AiSearchNamespaceCreateInstancePayloadIndexmethod =
        { keyword = keyword; vector = vector }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstancePayloadIndexingoptionsKeywordtokenizer =
    | [<CompiledName "porter">] Porter
    | [<CompiledName "trigram">] Trigram
    member this.Format() =
        match this with
        | Porter -> "porter"
        | Trigram -> "trigram"

type AiSearchNamespaceCreateInstancePayloadIndexingoptions =
    { ///Tokenizer used for keyword search indexing. porter provides word-level tokenization with Porter stemming (good for natural language queries). trigram enables character-level substring matching (good for partial matches, code, identifiers). Changing this triggers a full re-index. Defaults to porter.
      keyword_tokenizer: Option<AiSearchNamespaceCreateInstancePayloadIndexingoptionsKeywordtokenizer> }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadIndexingoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceCreateInstancePayloadIndexingoptions = { keyword_tokenizer = None }

type AiSearchNamespaceCreateInstancePayloadMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadMetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceCreateInstancePayloadMetadata =
        { created_from_aisearch_wizard = None
          worker_domain = None }

type AiSearchNamespaceCreateInstancePayloadPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadPublicendpointparamsChatcompletionsendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceCreateInstancePayloadPublicendpointparamsChatcompletionsendpoint =
        { disabled = None }

type AiSearchNamespaceCreateInstancePayloadPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadPublicendpointparamsMcp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceCreateInstancePayloadPublicendpointparamsMcp =
        { description = None; disabled = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstancePayloadPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchNamespaceCreateInstancePayloadPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchNamespaceCreateInstancePayloadPublicendpointparamsRatelimitTechnique> }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadPublicendpointparamsRatelimit with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceCreateInstancePayloadPublicendpointparamsRatelimit =
        { period_ms = None
          requests = None
          technique = None }

type AiSearchNamespaceCreateInstancePayloadPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadPublicendpointparamsSearchendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceCreateInstancePayloadPublicendpointparamsSearchendpoint =
        { disabled = None }

type AiSearchNamespaceCreateInstancePayloadPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchNamespaceCreateInstancePayloadPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchNamespaceCreateInstancePayloadPublicendpointparamsMcp>
      rate_limit: Option<AiSearchNamespaceCreateInstancePayloadPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchNamespaceCreateInstancePayloadPublicendpointparamsSearchendpoint> }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadPublicendpointparams with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceCreateInstancePayloadPublicendpointparams =
        { authorized_hosts = None
          chat_completions_endpoint = None
          enabled = None
          mcp = None
          rate_limit = None
          search_endpoint = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstancePayloadRerankingmodel =
    | [<CompiledName "@cf/baai/bge-reranker-base">] ``@cfBaaiBgeRerankerBase``
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfBaaiBgeRerankerBase`` -> "@cf/baai/bge-reranker-base"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstancePayloadRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchNamespaceCreateInstancePayloadRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchNamespaceCreateInstancePayloadRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadRetrievaloptionsBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): AiSearchNamespaceCreateInstancePayloadRetrievaloptionsBoostby =
        { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstancePayloadRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

type AiSearchNamespaceCreateInstancePayloadRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchNamespaceCreateInstancePayloadRetrievaloptionsBoostby>>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchNamespaceCreateInstancePayloadRetrievaloptionsKeywordmatchmode> }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadRetrievaloptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceCreateInstancePayloadRetrievaloptions =
        { boost_by = None
          keyword_match_mode = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstancePayloadRewritemodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerCrawloptionsSource> }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerCrawloptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerCrawloptions =
        { depth = None
          include_external_links = None
          include_subdomains = None
          max_age = None
          source = None }

type AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerParseoptionsContentselector with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (path: string, selector: string): AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerParseoptionsContentselector =
        { path = path; selector = selector }

type AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerParseoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerParseoptions =
        { content_selector = None
          include_headers = None
          include_images = None
          specific_sitemaps = None
          use_browser_rendering = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerStoreoptionsStoragetype> }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerStoreoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (storage_id: string): AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerStoreoptions =
        { r2_jurisdiction = None
          storage_id = storage_id
          storage_type = None }

type AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawlerStoreoptions> }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawler with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawler =
        { crawl_options = None
          parse_options = None
          parse_type = None
          store_options = None }

type AiSearchNamespaceCreateInstancePayloadSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchNamespaceCreateInstancePayloadSourceparamsWebcrawler> }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayloadSourceparams with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceCreateInstancePayloadSourceparams =
        { exclude_items = None
          include_items = None
          prefix = None
          r2_jurisdiction = None
          web_crawler = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstancePayloadType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchNamespaceCreateInstancePayload =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<AiSearchNamespaceCreateInstancePayloadAisearchmodel>
      cache: Option<bool>
      cache_threshold: Option<AiSearchNamespaceCreateInstancePayloadCachethreshold>
      chunk: Option<bool>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      custom_metadata: Option<list<AiSearchNamespaceCreateInstancePayloadCustommetadata>>
      embedding_model: Option<AiSearchNamespaceCreateInstancePayloadEmbeddingmodel>
      fusion_method: Option<AiSearchNamespaceCreateInstancePayloadFusionmethod>
      ///AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.
      id: string
      ///Controls which storage backends are used during indexing. Defaults to vector-only.
      index_method: Option<AiSearchNamespaceCreateInstancePayloadIndexmethod>
      indexing_options: Option<AiSearchNamespaceCreateInstancePayloadIndexingoptions>
      max_num_results: Option<int>
      metadata: Option<AiSearchNamespaceCreateInstancePayloadMetadata>
      public_endpoint_params: Option<AiSearchNamespaceCreateInstancePayloadPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<AiSearchNamespaceCreateInstancePayloadRerankingmodel>
      retrieval_options: Option<AiSearchNamespaceCreateInstancePayloadRetrievaloptions>
      rewrite_model: Option<AiSearchNamespaceCreateInstancePayloadRewritemodel>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchNamespaceCreateInstancePayloadSourceparams>
      ///Interval between automatic syncs, in seconds. Allowed values: 900 (15min), 1800 (30min), 3600 (1h), 7200 (2h), 14400 (4h), 21600 (6h), 43200 (12h), 86400 (24h).
      sync_interval: Option<obj>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchNamespaceCreateInstancePayloadType> }
    ///Creates an instance of AiSearchNamespaceCreateInstancePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string): AiSearchNamespaceCreateInstancePayload =
        { ai_gateway_id = None
          ai_search_model = None
          cache = None
          cache_threshold = None
          chunk = None
          chunk_overlap = None
          chunk_size = None
          custom_metadata = None
          embedding_model = None
          fusion_method = None
          id = id
          index_method = None
          indexing_options = None
          max_num_results = None
          metadata = None
          public_endpoint_params = None
          reranking = None
          reranking_model = None
          retrieval_options = None
          rewrite_model = None
          rewrite_query = None
          score_threshold = None
          source = None
          source_params = None
          sync_interval = None
          token_id = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstance_CreatedResultAisearchmodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstance_CreatedResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstance_CreatedResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    | [<CompiledName "datetime">] Datetime
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"
        | Datetime -> "datetime"

type AiSearchNamespaceCreateInstance_CreatedResultCustommetadata =
    { data_type: AiSearchNamespaceCreateInstance_CreatedResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstance_CreatedResultEmbeddingmodel =
    | [<CompiledName "@cf/qwen/qwen3-embedding-0.6b">] ``@cfQwenQwen3EmbeddingNumeric_0B``
    | [<CompiledName "@cf/baai/bge-m3">] ``@cfBaaiBgeM3``
    | [<CompiledName "@cf/baai/bge-large-en-v1.5">] ``@cfBaaiBgeLargeEnV1Numeric_5``
    | [<CompiledName "@cf/google/embeddinggemma-300m">] ``@cfGoogleEmbeddinggemmaM``
    | [<CompiledName "google-ai-studio/gemini-embedding-001">] GoogleAiStudioGeminiEmbeddingNumeric_001
    | [<CompiledName "google-ai-studio/gemini-embedding-2-preview">] GoogleAiStudioGeminiEmbeddingNumeric_2Preview
    | [<CompiledName "openai/text-embedding-3-small">] OpenaiTextEmbeddingNumeric_3Small
    | [<CompiledName "openai/text-embedding-3-large">] OpenaiTextEmbeddingNumeric_3Large
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfQwenQwen3EmbeddingNumeric_0B`` -> "@cf/qwen/qwen3-embedding-0.6b"
        | ``@cfBaaiBgeM3`` -> "@cf/baai/bge-m3"
        | ``@cfBaaiBgeLargeEnV1Numeric_5`` -> "@cf/baai/bge-large-en-v1.5"
        | ``@cfGoogleEmbeddinggemmaM`` -> "@cf/google/embeddinggemma-300m"
        | GoogleAiStudioGeminiEmbeddingNumeric_001 -> "google-ai-studio/gemini-embedding-001"
        | GoogleAiStudioGeminiEmbeddingNumeric_2Preview -> "google-ai-studio/gemini-embedding-2-preview"
        | OpenaiTextEmbeddingNumeric_3Small -> "openai/text-embedding-3-small"
        | OpenaiTextEmbeddingNumeric_3Large -> "openai/text-embedding-3-large"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstance_CreatedResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

///Controls which storage backends are used during indexing. Defaults to vector-only.
type AiSearchNamespaceCreateInstance_CreatedResultIndexmethod =
    { ///Enable keyword (BM25) storage backend.
      keyword: bool
      ///Enable vector (embedding) storage backend.
      vector: bool }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstance_CreatedResultIndexingoptionsKeywordtokenizer =
    | [<CompiledName "porter">] Porter
    | [<CompiledName "trigram">] Trigram
    member this.Format() =
        match this with
        | Porter -> "porter"
        | Trigram -> "trigram"

type AiSearchNamespaceCreateInstance_CreatedResultIndexingoptions =
    { ///Tokenizer used for keyword search indexing. porter provides word-level tokenization with Porter stemming (good for natural language queries). trigram enables character-level substring matching (good for partial matches, code, identifiers). Changing this triggers a full re-index. Defaults to porter.
      keyword_tokenizer: Option<AiSearchNamespaceCreateInstance_CreatedResultIndexingoptionsKeywordtokenizer> }

type AiSearchNamespaceCreateInstance_CreatedResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchNamespaceCreateInstance_CreatedResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchNamespaceCreateInstance_CreatedResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstance_CreatedResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchNamespaceCreateInstance_CreatedResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchNamespaceCreateInstance_CreatedResultPublicendpointparamsRatelimitTechnique> }

type AiSearchNamespaceCreateInstance_CreatedResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchNamespaceCreateInstance_CreatedResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchNamespaceCreateInstance_CreatedResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchNamespaceCreateInstance_CreatedResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchNamespaceCreateInstance_CreatedResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchNamespaceCreateInstance_CreatedResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstance_CreatedResultRerankingmodel =
    | [<CompiledName "@cf/baai/bge-reranker-base">] ``@cfBaaiBgeRerankerBase``
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfBaaiBgeRerankerBase`` -> "@cf/baai/bge-reranker-base"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstance_CreatedResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchNamespaceCreateInstance_CreatedResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchNamespaceCreateInstance_CreatedResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstance_CreatedResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

type AiSearchNamespaceCreateInstance_CreatedResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchNamespaceCreateInstance_CreatedResultRetrievaloptionsBoostby>>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchNamespaceCreateInstance_CreatedResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstance_CreatedResultRewritemodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstance_CreatedResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchNamespaceCreateInstance_CreatedResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchNamespaceCreateInstance_CreatedResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchNamespaceCreateInstance_CreatedResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchNamespaceCreateInstance_CreatedResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchNamespaceCreateInstance_CreatedResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstance_CreatedResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstance_CreatedResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchNamespaceCreateInstance_CreatedResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchNamespaceCreateInstance_CreatedResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchNamespaceCreateInstance_CreatedResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchNamespaceCreateInstance_CreatedResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchNamespaceCreateInstance_CreatedResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchNamespaceCreateInstance_CreatedResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchNamespaceCreateInstance_CreatedResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchNamespaceCreateInstance_CreatedResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchNamespaceCreateInstance_CreatedResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstance_CreatedResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchNamespaceCreateInstance_CreatedResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<AiSearchNamespaceCreateInstance_CreatedResultAisearchmodel>
      cache: Option<bool>
      cache_threshold: Option<AiSearchNamespaceCreateInstance_CreatedResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchNamespaceCreateInstance_CreatedResultCustommetadata>>
      embedding_model: Option<AiSearchNamespaceCreateInstance_CreatedResultEmbeddingmodel>
      enable: Option<bool>
      engine_version: Option<float>
      fusion_method: Option<AiSearchNamespaceCreateInstance_CreatedResultFusionmethod>
      ///AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.
      id: string
      ///Controls which storage backends are used during indexing. Defaults to vector-only.
      index_method: Option<AiSearchNamespaceCreateInstance_CreatedResultIndexmethod>
      indexing_options: Option<AiSearchNamespaceCreateInstance_CreatedResultIndexingoptions>
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchNamespaceCreateInstance_CreatedResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      ``namespace``: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchNamespaceCreateInstance_CreatedResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<AiSearchNamespaceCreateInstance_CreatedResultRerankingmodel>
      retrieval_options: Option<AiSearchNamespaceCreateInstance_CreatedResultRetrievaloptions>
      rewrite_model: Option<AiSearchNamespaceCreateInstance_CreatedResultRewritemodel>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchNamespaceCreateInstance_CreatedResultSourceparams>
      status: Option<string>
      ///Interval between automatic syncs, in seconds. Allowed values: 900 (15min), 1800 (30min), 3600 (1h), 7200 (2h), 14400 (4h), 21600 (6h), 43200 (12h), 86400 (24h).
      sync_interval: Option<obj>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchNamespaceCreateInstance_CreatedResultType> }

type AiSearchNamespaceCreateInstance_Created =
    { result: AiSearchNamespaceCreateInstance_CreatedResult
      success: bool }

type AiSearchNamespaceCreateInstance_BadRequestErrors = { code: float; message: string }

type AiSearchNamespaceCreateInstance_BadRequest =
    { errors: list<AiSearchNamespaceCreateInstance_BadRequestErrors>
      success: bool }

type AiSearchNamespaceCreateInstance_ForbiddenErrors = { code: float; message: string }

type AiSearchNamespaceCreateInstance_Forbidden =
    { errors: list<AiSearchNamespaceCreateInstance_ForbiddenErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceCreateInstance =
    ///Returns the new instance.
    | Created of payload: AiSearchNamespaceCreateInstance_Created
    ///Ai search instance invalid token.
    | BadRequest of payload: AiSearchNamespaceCreateInstance_BadRequest
    ///Max instances reached.
    | Forbidden of payload: AiSearchNamespaceCreateInstance_Forbidden

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceDeleteInstance_OKResultAisearchmodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceDeleteInstance_OKResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceDeleteInstance_OKResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    | [<CompiledName "datetime">] Datetime
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"
        | Datetime -> "datetime"

type AiSearchNamespaceDeleteInstance_OKResultCustommetadata =
    { data_type: AiSearchNamespaceDeleteInstance_OKResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceDeleteInstance_OKResultEmbeddingmodel =
    | [<CompiledName "@cf/qwen/qwen3-embedding-0.6b">] ``@cfQwenQwen3EmbeddingNumeric_0B``
    | [<CompiledName "@cf/baai/bge-m3">] ``@cfBaaiBgeM3``
    | [<CompiledName "@cf/baai/bge-large-en-v1.5">] ``@cfBaaiBgeLargeEnV1Numeric_5``
    | [<CompiledName "@cf/google/embeddinggemma-300m">] ``@cfGoogleEmbeddinggemmaM``
    | [<CompiledName "google-ai-studio/gemini-embedding-001">] GoogleAiStudioGeminiEmbeddingNumeric_001
    | [<CompiledName "google-ai-studio/gemini-embedding-2-preview">] GoogleAiStudioGeminiEmbeddingNumeric_2Preview
    | [<CompiledName "openai/text-embedding-3-small">] OpenaiTextEmbeddingNumeric_3Small
    | [<CompiledName "openai/text-embedding-3-large">] OpenaiTextEmbeddingNumeric_3Large
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfQwenQwen3EmbeddingNumeric_0B`` -> "@cf/qwen/qwen3-embedding-0.6b"
        | ``@cfBaaiBgeM3`` -> "@cf/baai/bge-m3"
        | ``@cfBaaiBgeLargeEnV1Numeric_5`` -> "@cf/baai/bge-large-en-v1.5"
        | ``@cfGoogleEmbeddinggemmaM`` -> "@cf/google/embeddinggemma-300m"
        | GoogleAiStudioGeminiEmbeddingNumeric_001 -> "google-ai-studio/gemini-embedding-001"
        | GoogleAiStudioGeminiEmbeddingNumeric_2Preview -> "google-ai-studio/gemini-embedding-2-preview"
        | OpenaiTextEmbeddingNumeric_3Small -> "openai/text-embedding-3-small"
        | OpenaiTextEmbeddingNumeric_3Large -> "openai/text-embedding-3-large"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceDeleteInstance_OKResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

///Controls which storage backends are used during indexing. Defaults to vector-only.
type AiSearchNamespaceDeleteInstance_OKResultIndexmethod =
    { ///Enable keyword (BM25) storage backend.
      keyword: bool
      ///Enable vector (embedding) storage backend.
      vector: bool }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceDeleteInstance_OKResultIndexingoptionsKeywordtokenizer =
    | [<CompiledName "porter">] Porter
    | [<CompiledName "trigram">] Trigram
    member this.Format() =
        match this with
        | Porter -> "porter"
        | Trigram -> "trigram"

type AiSearchNamespaceDeleteInstance_OKResultIndexingoptions =
    { ///Tokenizer used for keyword search indexing. porter provides word-level tokenization with Porter stemming (good for natural language queries). trigram enables character-level substring matching (good for partial matches, code, identifiers). Changing this triggers a full re-index. Defaults to porter.
      keyword_tokenizer: Option<AiSearchNamespaceDeleteInstance_OKResultIndexingoptionsKeywordtokenizer> }

type AiSearchNamespaceDeleteInstance_OKResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchNamespaceDeleteInstance_OKResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchNamespaceDeleteInstance_OKResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceDeleteInstance_OKResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchNamespaceDeleteInstance_OKResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchNamespaceDeleteInstance_OKResultPublicendpointparamsRatelimitTechnique> }

type AiSearchNamespaceDeleteInstance_OKResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchNamespaceDeleteInstance_OKResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchNamespaceDeleteInstance_OKResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchNamespaceDeleteInstance_OKResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchNamespaceDeleteInstance_OKResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchNamespaceDeleteInstance_OKResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceDeleteInstance_OKResultRerankingmodel =
    | [<CompiledName "@cf/baai/bge-reranker-base">] ``@cfBaaiBgeRerankerBase``
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfBaaiBgeRerankerBase`` -> "@cf/baai/bge-reranker-base"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceDeleteInstance_OKResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchNamespaceDeleteInstance_OKResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchNamespaceDeleteInstance_OKResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceDeleteInstance_OKResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

type AiSearchNamespaceDeleteInstance_OKResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchNamespaceDeleteInstance_OKResultRetrievaloptionsBoostby>>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchNamespaceDeleteInstance_OKResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceDeleteInstance_OKResultRewritemodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceDeleteInstance_OKResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchNamespaceDeleteInstance_OKResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchNamespaceDeleteInstance_OKResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchNamespaceDeleteInstance_OKResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchNamespaceDeleteInstance_OKResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchNamespaceDeleteInstance_OKResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceDeleteInstance_OKResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceDeleteInstance_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchNamespaceDeleteInstance_OKResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchNamespaceDeleteInstance_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchNamespaceDeleteInstance_OKResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchNamespaceDeleteInstance_OKResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchNamespaceDeleteInstance_OKResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchNamespaceDeleteInstance_OKResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchNamespaceDeleteInstance_OKResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchNamespaceDeleteInstance_OKResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchNamespaceDeleteInstance_OKResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceDeleteInstance_OKResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchNamespaceDeleteInstance_OKResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<AiSearchNamespaceDeleteInstance_OKResultAisearchmodel>
      cache: Option<bool>
      cache_threshold: Option<AiSearchNamespaceDeleteInstance_OKResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchNamespaceDeleteInstance_OKResultCustommetadata>>
      embedding_model: Option<AiSearchNamespaceDeleteInstance_OKResultEmbeddingmodel>
      enable: Option<bool>
      engine_version: Option<float>
      fusion_method: Option<AiSearchNamespaceDeleteInstance_OKResultFusionmethod>
      ///AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.
      id: string
      ///Controls which storage backends are used during indexing. Defaults to vector-only.
      index_method: Option<AiSearchNamespaceDeleteInstance_OKResultIndexmethod>
      indexing_options: Option<AiSearchNamespaceDeleteInstance_OKResultIndexingoptions>
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchNamespaceDeleteInstance_OKResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      ``namespace``: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchNamespaceDeleteInstance_OKResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<AiSearchNamespaceDeleteInstance_OKResultRerankingmodel>
      retrieval_options: Option<AiSearchNamespaceDeleteInstance_OKResultRetrievaloptions>
      rewrite_model: Option<AiSearchNamespaceDeleteInstance_OKResultRewritemodel>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchNamespaceDeleteInstance_OKResultSourceparams>
      status: Option<string>
      ///Interval between automatic syncs, in seconds. Allowed values: 900 (15min), 1800 (30min), 3600 (1h), 7200 (2h), 14400 (4h), 21600 (6h), 43200 (12h), 86400 (24h).
      sync_interval: Option<obj>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchNamespaceDeleteInstance_OKResultType> }

type AiSearchNamespaceDeleteInstance_OK =
    { result: AiSearchNamespaceDeleteInstance_OKResult
      success: bool }

type AiSearchNamespaceDeleteInstance_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceDeleteInstance_NotFound =
    { errors: list<AiSearchNamespaceDeleteInstance_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceDeleteInstance =
    ///Returns the deleted instance.
    | OK of payload: AiSearchNamespaceDeleteInstance_OK
    ///Ai search not found.
    | NotFound of payload: AiSearchNamespaceDeleteInstance_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceFetchInstance_OKResultAisearchmodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceFetchInstance_OKResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceFetchInstance_OKResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    | [<CompiledName "datetime">] Datetime
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"
        | Datetime -> "datetime"

type AiSearchNamespaceFetchInstance_OKResultCustommetadata =
    { data_type: AiSearchNamespaceFetchInstance_OKResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceFetchInstance_OKResultEmbeddingmodel =
    | [<CompiledName "@cf/qwen/qwen3-embedding-0.6b">] ``@cfQwenQwen3EmbeddingNumeric_0B``
    | [<CompiledName "@cf/baai/bge-m3">] ``@cfBaaiBgeM3``
    | [<CompiledName "@cf/baai/bge-large-en-v1.5">] ``@cfBaaiBgeLargeEnV1Numeric_5``
    | [<CompiledName "@cf/google/embeddinggemma-300m">] ``@cfGoogleEmbeddinggemmaM``
    | [<CompiledName "google-ai-studio/gemini-embedding-001">] GoogleAiStudioGeminiEmbeddingNumeric_001
    | [<CompiledName "google-ai-studio/gemini-embedding-2-preview">] GoogleAiStudioGeminiEmbeddingNumeric_2Preview
    | [<CompiledName "openai/text-embedding-3-small">] OpenaiTextEmbeddingNumeric_3Small
    | [<CompiledName "openai/text-embedding-3-large">] OpenaiTextEmbeddingNumeric_3Large
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfQwenQwen3EmbeddingNumeric_0B`` -> "@cf/qwen/qwen3-embedding-0.6b"
        | ``@cfBaaiBgeM3`` -> "@cf/baai/bge-m3"
        | ``@cfBaaiBgeLargeEnV1Numeric_5`` -> "@cf/baai/bge-large-en-v1.5"
        | ``@cfGoogleEmbeddinggemmaM`` -> "@cf/google/embeddinggemma-300m"
        | GoogleAiStudioGeminiEmbeddingNumeric_001 -> "google-ai-studio/gemini-embedding-001"
        | GoogleAiStudioGeminiEmbeddingNumeric_2Preview -> "google-ai-studio/gemini-embedding-2-preview"
        | OpenaiTextEmbeddingNumeric_3Small -> "openai/text-embedding-3-small"
        | OpenaiTextEmbeddingNumeric_3Large -> "openai/text-embedding-3-large"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceFetchInstance_OKResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

///Controls which storage backends are used during indexing. Defaults to vector-only.
type AiSearchNamespaceFetchInstance_OKResultIndexmethod =
    { ///Enable keyword (BM25) storage backend.
      keyword: bool
      ///Enable vector (embedding) storage backend.
      vector: bool }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceFetchInstance_OKResultIndexingoptionsKeywordtokenizer =
    | [<CompiledName "porter">] Porter
    | [<CompiledName "trigram">] Trigram
    member this.Format() =
        match this with
        | Porter -> "porter"
        | Trigram -> "trigram"

type AiSearchNamespaceFetchInstance_OKResultIndexingoptions =
    { ///Tokenizer used for keyword search indexing. porter provides word-level tokenization with Porter stemming (good for natural language queries). trigram enables character-level substring matching (good for partial matches, code, identifiers). Changing this triggers a full re-index. Defaults to porter.
      keyword_tokenizer: Option<AiSearchNamespaceFetchInstance_OKResultIndexingoptionsKeywordtokenizer> }

type AiSearchNamespaceFetchInstance_OKResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchNamespaceFetchInstance_OKResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchNamespaceFetchInstance_OKResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceFetchInstance_OKResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchNamespaceFetchInstance_OKResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchNamespaceFetchInstance_OKResultPublicendpointparamsRatelimitTechnique> }

type AiSearchNamespaceFetchInstance_OKResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchNamespaceFetchInstance_OKResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchNamespaceFetchInstance_OKResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchNamespaceFetchInstance_OKResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchNamespaceFetchInstance_OKResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchNamespaceFetchInstance_OKResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceFetchInstance_OKResultRerankingmodel =
    | [<CompiledName "@cf/baai/bge-reranker-base">] ``@cfBaaiBgeRerankerBase``
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfBaaiBgeRerankerBase`` -> "@cf/baai/bge-reranker-base"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceFetchInstance_OKResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchNamespaceFetchInstance_OKResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchNamespaceFetchInstance_OKResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceFetchInstance_OKResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

type AiSearchNamespaceFetchInstance_OKResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchNamespaceFetchInstance_OKResultRetrievaloptionsBoostby>>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchNamespaceFetchInstance_OKResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceFetchInstance_OKResultRewritemodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceFetchInstance_OKResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchNamespaceFetchInstance_OKResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchNamespaceFetchInstance_OKResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchNamespaceFetchInstance_OKResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchNamespaceFetchInstance_OKResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchNamespaceFetchInstance_OKResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceFetchInstance_OKResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceFetchInstance_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchNamespaceFetchInstance_OKResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchNamespaceFetchInstance_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchNamespaceFetchInstance_OKResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchNamespaceFetchInstance_OKResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchNamespaceFetchInstance_OKResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchNamespaceFetchInstance_OKResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchNamespaceFetchInstance_OKResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchNamespaceFetchInstance_OKResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchNamespaceFetchInstance_OKResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceFetchInstance_OKResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchNamespaceFetchInstance_OKResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<AiSearchNamespaceFetchInstance_OKResultAisearchmodel>
      cache: Option<bool>
      cache_threshold: Option<AiSearchNamespaceFetchInstance_OKResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchNamespaceFetchInstance_OKResultCustommetadata>>
      embedding_model: Option<AiSearchNamespaceFetchInstance_OKResultEmbeddingmodel>
      enable: Option<bool>
      engine_version: Option<float>
      fusion_method: Option<AiSearchNamespaceFetchInstance_OKResultFusionmethod>
      ///AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.
      id: string
      ///Controls which storage backends are used during indexing. Defaults to vector-only.
      index_method: Option<AiSearchNamespaceFetchInstance_OKResultIndexmethod>
      indexing_options: Option<AiSearchNamespaceFetchInstance_OKResultIndexingoptions>
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchNamespaceFetchInstance_OKResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      ``namespace``: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchNamespaceFetchInstance_OKResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<AiSearchNamespaceFetchInstance_OKResultRerankingmodel>
      retrieval_options: Option<AiSearchNamespaceFetchInstance_OKResultRetrievaloptions>
      rewrite_model: Option<AiSearchNamespaceFetchInstance_OKResultRewritemodel>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchNamespaceFetchInstance_OKResultSourceparams>
      status: Option<string>
      ///Interval between automatic syncs, in seconds. Allowed values: 900 (15min), 1800 (30min), 3600 (1h), 7200 (2h), 14400 (4h), 21600 (6h), 43200 (12h), 86400 (24h).
      sync_interval: Option<obj>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchNamespaceFetchInstance_OKResultType> }

type AiSearchNamespaceFetchInstance_OK =
    { result: AiSearchNamespaceFetchInstance_OKResult
      success: bool }

type AiSearchNamespaceFetchInstance_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceFetchInstance_NotFound =
    { errors: list<AiSearchNamespaceFetchInstance_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceFetchInstance =
    ///Returns the instance.
    | OK of payload: AiSearchNamespaceFetchInstance_OK
    ///Ai search not found.
    | NotFound of payload: AiSearchNamespaceFetchInstance_NotFound

type AiSearchMoveInstancePayload =
    { ///Target namespace to move the instance into.
      new_namespace: string }
    ///Creates an instance of AiSearchMoveInstancePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (new_namespace: string): AiSearchMoveInstancePayload = { new_namespace = new_namespace }

type AiSearchMoveInstance_OK =
    { result: obj
      success: bool }

type AiSearchMoveInstance_BadRequestErrors = { code: float; message: string }

type AiSearchMoveInstance_BadRequest =
    { errors: list<AiSearchMoveInstance_BadRequestErrors>
      success: bool }

type AiSearchMoveInstance_NotFoundErrors = { code: float; message: string }

type AiSearchMoveInstance_NotFound =
    { errors: list<AiSearchMoveInstance_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchMoveInstance =
    ///Instance moved.
    | OK of payload: AiSearchMoveInstance_OK
    ///Ai search with this name already exist.
    | BadRequest of payload: AiSearchMoveInstance_BadRequest
    ///Ai search not found.
    | NotFound of payload: AiSearchMoveInstance_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstancePayloadAisearchmodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstancePayloadCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstancePayloadCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    | [<CompiledName "datetime">] Datetime
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"
        | Datetime -> "datetime"

type AiSearchNamespaceUpdateInstancePayloadCustommetadata =
    { data_type: AiSearchNamespaceUpdateInstancePayloadCustommetadataDatatype
      field_name: string }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadCustommetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (data_type: AiSearchNamespaceUpdateInstancePayloadCustommetadataDatatype, field_name: string): AiSearchNamespaceUpdateInstancePayloadCustommetadata =
        { data_type = data_type
          field_name = field_name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstancePayloadEmbeddingmodel =
    | [<CompiledName "@cf/qwen/qwen3-embedding-0.6b">] ``@cfQwenQwen3EmbeddingNumeric_0B``
    | [<CompiledName "@cf/baai/bge-m3">] ``@cfBaaiBgeM3``
    | [<CompiledName "@cf/baai/bge-large-en-v1.5">] ``@cfBaaiBgeLargeEnV1Numeric_5``
    | [<CompiledName "@cf/google/embeddinggemma-300m">] ``@cfGoogleEmbeddinggemmaM``
    | [<CompiledName "google-ai-studio/gemini-embedding-001">] GoogleAiStudioGeminiEmbeddingNumeric_001
    | [<CompiledName "google-ai-studio/gemini-embedding-2-preview">] GoogleAiStudioGeminiEmbeddingNumeric_2Preview
    | [<CompiledName "openai/text-embedding-3-small">] OpenaiTextEmbeddingNumeric_3Small
    | [<CompiledName "openai/text-embedding-3-large">] OpenaiTextEmbeddingNumeric_3Large
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfQwenQwen3EmbeddingNumeric_0B`` -> "@cf/qwen/qwen3-embedding-0.6b"
        | ``@cfBaaiBgeM3`` -> "@cf/baai/bge-m3"
        | ``@cfBaaiBgeLargeEnV1Numeric_5`` -> "@cf/baai/bge-large-en-v1.5"
        | ``@cfGoogleEmbeddinggemmaM`` -> "@cf/google/embeddinggemma-300m"
        | GoogleAiStudioGeminiEmbeddingNumeric_001 -> "google-ai-studio/gemini-embedding-001"
        | GoogleAiStudioGeminiEmbeddingNumeric_2Preview -> "google-ai-studio/gemini-embedding-2-preview"
        | OpenaiTextEmbeddingNumeric_3Small -> "openai/text-embedding-3-small"
        | OpenaiTextEmbeddingNumeric_3Large -> "openai/text-embedding-3-large"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstancePayloadFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

///Controls which storage backends are used during indexing. Defaults to vector-only.
type AiSearchNamespaceUpdateInstancePayloadIndexmethod =
    { ///Enable keyword (BM25) storage backend.
      keyword: bool
      ///Enable vector (embedding) storage backend.
      vector: bool }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadIndexmethod with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (keyword: bool, vector: bool): AiSearchNamespaceUpdateInstancePayloadIndexmethod =
        { keyword = keyword; vector = vector }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstancePayloadIndexingoptionsKeywordtokenizer =
    | [<CompiledName "porter">] Porter
    | [<CompiledName "trigram">] Trigram
    member this.Format() =
        match this with
        | Porter -> "porter"
        | Trigram -> "trigram"

type AiSearchNamespaceUpdateInstancePayloadIndexingoptions =
    { ///Tokenizer used for keyword search indexing. porter provides word-level tokenization with Porter stemming (good for natural language queries). trigram enables character-level substring matching (good for partial matches, code, identifiers). Changing this triggers a full re-index. Defaults to porter.
      keyword_tokenizer: Option<AiSearchNamespaceUpdateInstancePayloadIndexingoptionsKeywordtokenizer> }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadIndexingoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceUpdateInstancePayloadIndexingoptions = { keyword_tokenizer = None }

type AiSearchNamespaceUpdateInstancePayloadMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadMetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceUpdateInstancePayloadMetadata =
        { created_from_aisearch_wizard = None
          worker_domain = None }

type AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsChatcompletionsendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsChatcompletionsendpoint =
        { disabled = None }

type AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsMcp with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsMcp =
        { description = None; disabled = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsRatelimitTechnique> }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsRatelimit with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsRatelimit =
        { period_ms = None
          requests = None
          technique = None }

type AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsSearchendpoint with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsSearchendpoint =
        { disabled = None }

type AiSearchNamespaceUpdateInstancePayloadPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsMcp>
      rate_limit: Option<AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchNamespaceUpdateInstancePayloadPublicendpointparamsSearchendpoint> }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadPublicendpointparams with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceUpdateInstancePayloadPublicendpointparams =
        { authorized_hosts = None
          chat_completions_endpoint = None
          enabled = None
          mcp = None
          rate_limit = None
          search_endpoint = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstancePayloadRerankingmodel =
    | [<CompiledName "@cf/baai/bge-reranker-base">] ``@cfBaaiBgeRerankerBase``
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfBaaiBgeRerankerBase`` -> "@cf/baai/bge-reranker-base"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstancePayloadRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchNamespaceUpdateInstancePayloadRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchNamespaceUpdateInstancePayloadRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadRetrievaloptionsBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): AiSearchNamespaceUpdateInstancePayloadRetrievaloptionsBoostby =
        { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstancePayloadRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

type AiSearchNamespaceUpdateInstancePayloadRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchNamespaceUpdateInstancePayloadRetrievaloptionsBoostby>>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchNamespaceUpdateInstancePayloadRetrievaloptionsKeywordmatchmode> }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadRetrievaloptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceUpdateInstancePayloadRetrievaloptions =
        { boost_by = None
          keyword_match_mode = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstancePayloadRewritemodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerCrawloptionsSource> }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerCrawloptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerCrawloptions =
        { depth = None
          include_external_links = None
          include_subdomains = None
          max_age = None
          source = None }

type AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerParseoptionsContentselector with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (path: string, selector: string): AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerParseoptionsContentselector =
        { path = path; selector = selector }

type AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerParseoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerParseoptions =
        { content_selector = None
          include_headers = None
          include_images = None
          specific_sitemaps = None
          use_browser_rendering = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerStoreoptionsStoragetype> }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerStoreoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (storage_id: string): AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerStoreoptions =
        { r2_jurisdiction = None
          storage_id = storage_id
          storage_type = None }

type AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawlerStoreoptions> }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawler with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawler =
        { crawl_options = None
          parse_options = None
          parse_type = None
          store_options = None }

type AiSearchNamespaceUpdateInstancePayloadSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchNamespaceUpdateInstancePayloadSourceparamsWebcrawler> }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayloadSourceparams with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceUpdateInstancePayloadSourceparams =
        { exclude_items = None
          include_items = None
          prefix = None
          r2_jurisdiction = None
          web_crawler = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstancePayloadSummarizationmodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

type AiSearchNamespaceUpdateInstancePayload =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<AiSearchNamespaceUpdateInstancePayloadAisearchmodel>
      cache: Option<bool>
      cache_threshold: Option<AiSearchNamespaceUpdateInstancePayloadCachethreshold>
      chunk: Option<bool>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      custom_metadata: Option<list<AiSearchNamespaceUpdateInstancePayloadCustommetadata>>
      embedding_model: Option<AiSearchNamespaceUpdateInstancePayloadEmbeddingmodel>
      fusion_method: Option<AiSearchNamespaceUpdateInstancePayloadFusionmethod>
      ///Controls which storage backends are used during indexing. Defaults to vector-only.
      index_method: Option<AiSearchNamespaceUpdateInstancePayloadIndexmethod>
      indexing_options: Option<AiSearchNamespaceUpdateInstancePayloadIndexingoptions>
      max_num_results: Option<int>
      metadata: Option<AiSearchNamespaceUpdateInstancePayloadMetadata>
      paused: Option<bool>
      public_endpoint_params: Option<AiSearchNamespaceUpdateInstancePayloadPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<AiSearchNamespaceUpdateInstancePayloadRerankingmodel>
      retrieval_options: Option<AiSearchNamespaceUpdateInstancePayloadRetrievaloptions>
      rewrite_model: Option<AiSearchNamespaceUpdateInstancePayloadRewritemodel>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source_params: Option<AiSearchNamespaceUpdateInstancePayloadSourceparams>
      summarization: Option<bool>
      summarization_model: Option<AiSearchNamespaceUpdateInstancePayloadSummarizationmodel>
      ///Interval between automatic syncs, in seconds. Allowed values: 900 (15min), 1800 (30min), 3600 (1h), 7200 (2h), 14400 (4h), 21600 (6h), 43200 (12h), 86400 (24h).
      sync_interval: Option<obj>
      system_prompt_ai_search: Option<string>
      system_prompt_index_summarization: Option<string>
      system_prompt_rewrite_query: Option<string>
      token_id: Option<System.Guid> }
    ///Creates an instance of AiSearchNamespaceUpdateInstancePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceUpdateInstancePayload =
        { ai_gateway_id = None
          ai_search_model = None
          cache = None
          cache_threshold = None
          chunk = None
          chunk_overlap = None
          chunk_size = None
          custom_metadata = None
          embedding_model = None
          fusion_method = None
          index_method = None
          indexing_options = None
          max_num_results = None
          metadata = None
          paused = None
          public_endpoint_params = None
          reranking = None
          reranking_model = None
          retrieval_options = None
          rewrite_model = None
          rewrite_query = None
          score_threshold = None
          source_params = None
          summarization = None
          summarization_model = None
          sync_interval = None
          system_prompt_ai_search = None
          system_prompt_index_summarization = None
          system_prompt_rewrite_query = None
          token_id = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstance_OKResultAisearchmodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstance_OKResultCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstance_OKResultCustommetadataDatatype =
    | [<CompiledName "text">] Text
    | [<CompiledName "number">] Number
    | [<CompiledName "boolean">] Boolean
    | [<CompiledName "datetime">] Datetime
    member this.Format() =
        match this with
        | Text -> "text"
        | Number -> "number"
        | Boolean -> "boolean"
        | Datetime -> "datetime"

type AiSearchNamespaceUpdateInstance_OKResultCustommetadata =
    { data_type: AiSearchNamespaceUpdateInstance_OKResultCustommetadataDatatype
      field_name: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstance_OKResultEmbeddingmodel =
    | [<CompiledName "@cf/qwen/qwen3-embedding-0.6b">] ``@cfQwenQwen3EmbeddingNumeric_0B``
    | [<CompiledName "@cf/baai/bge-m3">] ``@cfBaaiBgeM3``
    | [<CompiledName "@cf/baai/bge-large-en-v1.5">] ``@cfBaaiBgeLargeEnV1Numeric_5``
    | [<CompiledName "@cf/google/embeddinggemma-300m">] ``@cfGoogleEmbeddinggemmaM``
    | [<CompiledName "google-ai-studio/gemini-embedding-001">] GoogleAiStudioGeminiEmbeddingNumeric_001
    | [<CompiledName "google-ai-studio/gemini-embedding-2-preview">] GoogleAiStudioGeminiEmbeddingNumeric_2Preview
    | [<CompiledName "openai/text-embedding-3-small">] OpenaiTextEmbeddingNumeric_3Small
    | [<CompiledName "openai/text-embedding-3-large">] OpenaiTextEmbeddingNumeric_3Large
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfQwenQwen3EmbeddingNumeric_0B`` -> "@cf/qwen/qwen3-embedding-0.6b"
        | ``@cfBaaiBgeM3`` -> "@cf/baai/bge-m3"
        | ``@cfBaaiBgeLargeEnV1Numeric_5`` -> "@cf/baai/bge-large-en-v1.5"
        | ``@cfGoogleEmbeddinggemmaM`` -> "@cf/google/embeddinggemma-300m"
        | GoogleAiStudioGeminiEmbeddingNumeric_001 -> "google-ai-studio/gemini-embedding-001"
        | GoogleAiStudioGeminiEmbeddingNumeric_2Preview -> "google-ai-studio/gemini-embedding-2-preview"
        | OpenaiTextEmbeddingNumeric_3Small -> "openai/text-embedding-3-small"
        | OpenaiTextEmbeddingNumeric_3Large -> "openai/text-embedding-3-large"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstance_OKResultFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

///Controls which storage backends are used during indexing. Defaults to vector-only.
type AiSearchNamespaceUpdateInstance_OKResultIndexmethod =
    { ///Enable keyword (BM25) storage backend.
      keyword: bool
      ///Enable vector (embedding) storage backend.
      vector: bool }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstance_OKResultIndexingoptionsKeywordtokenizer =
    | [<CompiledName "porter">] Porter
    | [<CompiledName "trigram">] Trigram
    member this.Format() =
        match this with
        | Porter -> "porter"
        | Trigram -> "trigram"

type AiSearchNamespaceUpdateInstance_OKResultIndexingoptions =
    { ///Tokenizer used for keyword search indexing. porter provides word-level tokenization with Porter stemming (good for natural language queries). trigram enables character-level substring matching (good for partial matches, code, identifiers). Changing this triggers a full re-index. Defaults to porter.
      keyword_tokenizer: Option<AiSearchNamespaceUpdateInstance_OKResultIndexingoptionsKeywordtokenizer> }

type AiSearchNamespaceUpdateInstance_OKResultMetadata =
    { created_from_aisearch_wizard: Option<bool>
      worker_domain: Option<string> }

type AiSearchNamespaceUpdateInstance_OKResultPublicendpointparamsChatcompletionsendpoint =
    { ///Disable chat completions endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchNamespaceUpdateInstance_OKResultPublicendpointparamsMcp =
    { description: Option<string>
      ///Disable MCP endpoint for this public endpoint
      disabled: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstance_OKResultPublicendpointparamsRatelimitTechnique =
    | [<CompiledName "fixed">] Fixed
    | [<CompiledName "sliding">] Sliding
    member this.Format() =
        match this with
        | Fixed -> "fixed"
        | Sliding -> "sliding"

type AiSearchNamespaceUpdateInstance_OKResultPublicendpointparamsRatelimit =
    { period_ms: Option<int>
      requests: Option<int>
      technique: Option<AiSearchNamespaceUpdateInstance_OKResultPublicendpointparamsRatelimitTechnique> }

type AiSearchNamespaceUpdateInstance_OKResultPublicendpointparamsSearchendpoint =
    { ///Disable search endpoint for this public endpoint
      disabled: Option<bool> }

type AiSearchNamespaceUpdateInstance_OKResultPublicendpointparams =
    { authorized_hosts: Option<list<string>>
      chat_completions_endpoint: Option<AiSearchNamespaceUpdateInstance_OKResultPublicendpointparamsChatcompletionsendpoint>
      enabled: Option<bool>
      mcp: Option<AiSearchNamespaceUpdateInstance_OKResultPublicendpointparamsMcp>
      rate_limit: Option<AiSearchNamespaceUpdateInstance_OKResultPublicendpointparamsRatelimit>
      search_endpoint: Option<AiSearchNamespaceUpdateInstance_OKResultPublicendpointparamsSearchendpoint> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstance_OKResultRerankingmodel =
    | [<CompiledName "@cf/baai/bge-reranker-base">] ``@cfBaaiBgeRerankerBase``
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfBaaiBgeRerankerBase`` -> "@cf/baai/bge-reranker-base"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstance_OKResultRetrievaloptionsBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchNamespaceUpdateInstance_OKResultRetrievaloptionsBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchNamespaceUpdateInstance_OKResultRetrievaloptionsBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstance_OKResultRetrievaloptionsKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

type AiSearchNamespaceUpdateInstance_OKResultRetrievaloptions =
    { ///Metadata fields to boost search results by. Each entry specifies a metadata field and an optional direction. Direction defaults to 'asc' for numeric fields and 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchNamespaceUpdateInstance_OKResultRetrievaloptionsBoostby>>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchNamespaceUpdateInstance_OKResultRetrievaloptionsKeywordmatchmode> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstance_OKResultRewritemodel =
    | [<CompiledName "@cf/meta/llama-3.3-70b-instruct-fp8-fast">] ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast``
    | [<CompiledName "@cf/zai-org/glm-4.7-flash">] ``@cfZaiOrgGlmNumeric_4Numeric_7Flash``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fast">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast``
    | [<CompiledName "@cf/meta/llama-3.1-8b-instruct-fp8">] ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8``
    | [<CompiledName "@cf/meta/llama-4-scout-17b-16e-instruct">] ``@cfMetaLlamaNumeric_4ScoutBEInstruct``
    | [<CompiledName "@cf/qwen/qwen3-30b-a3b-fp8">] ``@cfQwenQwen3BA3bFp8``
    | [<CompiledName "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b">] ``@cfDeepseekAiDeepseekR1DistillQwenB``
    | [<CompiledName "@cf/moonshotai/kimi-k2-instruct">] ``@cfMoonshotaiKimiK2Instruct``
    | [<CompiledName "@cf/google/gemma-3-12b-it">] ``@cfGoogleGemmaNumeric_3BIt``
    | [<CompiledName "@cf/google/gemma-4-26b-a4b-it">] ``@cfGoogleGemmaNumeric_4BA4bIt``
    | [<CompiledName "@cf/moonshotai/kimi-k2.5">] ``@cfMoonshotaiKimiK2Numeric_5``
    | [<CompiledName "anthropic/claude-3-7-sonnet">] AnthropicClaudeNumeric_3Numeric_7Sonnet
    | [<CompiledName "anthropic/claude-sonnet-4">] AnthropicClaudeSonnetNumeric_4
    | [<CompiledName "anthropic/claude-opus-4">] AnthropicClaudeOpusNumeric_4
    | [<CompiledName "anthropic/claude-3-5-haiku">] AnthropicClaudeNumeric_3Numeric_5Haiku
    | [<CompiledName "cerebras/qwen-3-235b-a22b-instruct">] CerebrasQwenNumeric_3BA22bInstruct
    | [<CompiledName "cerebras/qwen-3-235b-a22b-thinking">] CerebrasQwenNumeric_3BA22bThinking
    | [<CompiledName "cerebras/llama-3.3-70b">] CerebrasLlamaNumeric_3Numeric_3B
    | [<CompiledName "cerebras/llama-4-maverick-17b-128e-instruct">] CerebrasLlamaNumeric_4MaverickBEInstruct
    | [<CompiledName "cerebras/llama-4-scout-17b-16e-instruct">] CerebrasLlamaNumeric_4ScoutBEInstruct
    | [<CompiledName "cerebras/gpt-oss-120b">] CerebrasGptOssB
    | [<CompiledName "google-ai-studio/gemini-2.5-flash">] GoogleAiStudioGeminiNumeric_2Numeric_5Flash
    | [<CompiledName "google-ai-studio/gemini-2.5-pro">] GoogleAiStudioGeminiNumeric_2Numeric_5Pro
    | [<CompiledName "grok/grok-4">] GrokGrokNumeric_4
    | [<CompiledName "groq/llama-3.3-70b-versatile">] GroqLlamaNumeric_3Numeric_3BVersatile
    | [<CompiledName "groq/llama-3.1-8b-instant">] GroqLlamaNumeric_3Numeric_1BInstant
    | [<CompiledName "openai/gpt-5">] OpenaiGptNumeric_5
    | [<CompiledName "openai/gpt-5-mini">] OpenaiGptNumeric_5Mini
    | [<CompiledName "openai/gpt-5-nano">] OpenaiGptNumeric_5Nano
    | [<CompiledName "">] EmptyString
    member this.Format() =
        match this with
        | ``@cfMetaLlamaNumeric_3Numeric_3BInstructFp8Fast`` -> "@cf/meta/llama-3.3-70b-instruct-fp8-fast"
        | ``@cfZaiOrgGlmNumeric_4Numeric_7Flash`` -> "@cf/zai-org/glm-4.7-flash"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFast`` -> "@cf/meta/llama-3.1-8b-instruct-fast"
        | ``@cfMetaLlamaNumeric_3Numeric_1BInstructFp8`` -> "@cf/meta/llama-3.1-8b-instruct-fp8"
        | ``@cfMetaLlamaNumeric_4ScoutBEInstruct`` -> "@cf/meta/llama-4-scout-17b-16e-instruct"
        | ``@cfQwenQwen3BA3bFp8`` -> "@cf/qwen/qwen3-30b-a3b-fp8"
        | ``@cfDeepseekAiDeepseekR1DistillQwenB`` -> "@cf/deepseek-ai/deepseek-r1-distill-qwen-32b"
        | ``@cfMoonshotaiKimiK2Instruct`` -> "@cf/moonshotai/kimi-k2-instruct"
        | ``@cfGoogleGemmaNumeric_3BIt`` -> "@cf/google/gemma-3-12b-it"
        | ``@cfGoogleGemmaNumeric_4BA4bIt`` -> "@cf/google/gemma-4-26b-a4b-it"
        | ``@cfMoonshotaiKimiK2Numeric_5`` -> "@cf/moonshotai/kimi-k2.5"
        | AnthropicClaudeNumeric_3Numeric_7Sonnet -> "anthropic/claude-3-7-sonnet"
        | AnthropicClaudeSonnetNumeric_4 -> "anthropic/claude-sonnet-4"
        | AnthropicClaudeOpusNumeric_4 -> "anthropic/claude-opus-4"
        | AnthropicClaudeNumeric_3Numeric_5Haiku -> "anthropic/claude-3-5-haiku"
        | CerebrasQwenNumeric_3BA22bInstruct -> "cerebras/qwen-3-235b-a22b-instruct"
        | CerebrasQwenNumeric_3BA22bThinking -> "cerebras/qwen-3-235b-a22b-thinking"
        | CerebrasLlamaNumeric_3Numeric_3B -> "cerebras/llama-3.3-70b"
        | CerebrasLlamaNumeric_4MaverickBEInstruct -> "cerebras/llama-4-maverick-17b-128e-instruct"
        | CerebrasLlamaNumeric_4ScoutBEInstruct -> "cerebras/llama-4-scout-17b-16e-instruct"
        | CerebrasGptOssB -> "cerebras/gpt-oss-120b"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Flash -> "google-ai-studio/gemini-2.5-flash"
        | GoogleAiStudioGeminiNumeric_2Numeric_5Pro -> "google-ai-studio/gemini-2.5-pro"
        | GrokGrokNumeric_4 -> "grok/grok-4"
        | GroqLlamaNumeric_3Numeric_3BVersatile -> "groq/llama-3.3-70b-versatile"
        | GroqLlamaNumeric_3Numeric_1BInstant -> "groq/llama-3.1-8b-instant"
        | OpenaiGptNumeric_5 -> "openai/gpt-5"
        | OpenaiGptNumeric_5Mini -> "openai/gpt-5-mini"
        | OpenaiGptNumeric_5Nano -> "openai/gpt-5-nano"
        | EmptyString -> ""

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstance_OKResultSourceparamsWebcrawlerCrawloptionsSource =
    | [<CompiledName "all">] All
    | [<CompiledName "sitemaps">] Sitemaps
    | [<CompiledName "links">] Links
    member this.Format() =
        match this with
        | All -> "all"
        | Sitemaps -> "sitemaps"
        | Links -> "links"

type AiSearchNamespaceUpdateInstance_OKResultSourceparamsWebcrawlerCrawloptions =
    { depth: Option<float>
      include_external_links: Option<bool>
      include_subdomains: Option<bool>
      max_age: Option<float>
      source: Option<AiSearchNamespaceUpdateInstance_OKResultSourceparamsWebcrawlerCrawloptionsSource> }

type AiSearchNamespaceUpdateInstance_OKResultSourceparamsWebcrawlerParseoptionsContentselector =
    { ///Glob pattern to match against the page URL path. Uses standard glob syntax: * matches within a segment, ** crosses directories.
      path: string
      ///CSS selector to extract content from pages matching the path pattern. Supports standard CSS selectors including class, ID, element, and attribute selectors.
      selector: string }

type AiSearchNamespaceUpdateInstance_OKResultSourceparamsWebcrawlerParseoptions =
    { ///List of path-to-selector mappings for extracting specific content from crawled pages. Each entry pairs a URL glob pattern with a CSS selector. The first matching path wins. Only the matched HTML fragment is stored and indexed.
      content_selector: Option<list<AiSearchNamespaceUpdateInstance_OKResultSourceparamsWebcrawlerParseoptionsContentselector>>
      include_headers: Option<Map<string, string>>
      include_images: Option<bool>
      ///List of specific sitemap URLs to use for crawling. Only valid when parse_type is 'sitemap'.
      specific_sitemaps: Option<list<string>>
      use_browser_rendering: Option<bool> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstance_OKResultSourceparamsWebcrawlerParsetype =
    | [<CompiledName "sitemap">] Sitemap
    | [<CompiledName "feed-rss">] FeedRss
    | [<CompiledName "crawl">] Crawl
    member this.Format() =
        match this with
        | Sitemap -> "sitemap"
        | FeedRss -> "feed-rss"
        | Crawl -> "crawl"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstance_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type AiSearchNamespaceUpdateInstance_OKResultSourceparamsWebcrawlerStoreoptions =
    { r2_jurisdiction: Option<string>
      storage_id: string
      storage_type: Option<AiSearchNamespaceUpdateInstance_OKResultSourceparamsWebcrawlerStoreoptionsStoragetype> }

type AiSearchNamespaceUpdateInstance_OKResultSourceparamsWebcrawler =
    { crawl_options: Option<AiSearchNamespaceUpdateInstance_OKResultSourceparamsWebcrawlerCrawloptions>
      parse_options: Option<AiSearchNamespaceUpdateInstance_OKResultSourceparamsWebcrawlerParseoptions>
      parse_type: Option<AiSearchNamespaceUpdateInstance_OKResultSourceparamsWebcrawlerParsetype>
      store_options: Option<AiSearchNamespaceUpdateInstance_OKResultSourceparamsWebcrawlerStoreoptions> }

type AiSearchNamespaceUpdateInstance_OKResultSourceparams =
    { ///List of path patterns to exclude. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /admin/** matches /admin/users and /admin/settings/advanced)
      exclude_items: Option<list<string>>
      ///List of path patterns to include. Uses micromatch glob syntax: * matches within a path segment, ** matches across path segments (e.g., /blog/** matches /blog/post and /blog/2024/post)
      include_items: Option<list<string>>
      prefix: Option<string>
      r2_jurisdiction: Option<string>
      web_crawler: Option<AiSearchNamespaceUpdateInstance_OKResultSourceparamsWebcrawler> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstance_OKResultType =
    | [<CompiledName "r2">] R2
    | [<CompiledName "web-crawler">] WebCrawler
    member this.Format() =
        match this with
        | R2 -> "r2"
        | WebCrawler -> "web-crawler"

type AiSearchNamespaceUpdateInstance_OKResult =
    { ai_gateway_id: Option<string>
      ai_search_model: Option<AiSearchNamespaceUpdateInstance_OKResultAisearchmodel>
      cache: Option<bool>
      cache_threshold: Option<AiSearchNamespaceUpdateInstance_OKResultCachethreshold>
      chunk_overlap: Option<int>
      chunk_size: Option<int>
      created_at: System.DateTimeOffset
      created_by: Option<string>
      custom_metadata: Option<list<AiSearchNamespaceUpdateInstance_OKResultCustommetadata>>
      embedding_model: Option<AiSearchNamespaceUpdateInstance_OKResultEmbeddingmodel>
      enable: Option<bool>
      engine_version: Option<float>
      fusion_method: Option<AiSearchNamespaceUpdateInstance_OKResultFusionmethod>
      ///AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.
      id: string
      ///Controls which storage backends are used during indexing. Defaults to vector-only.
      index_method: Option<AiSearchNamespaceUpdateInstance_OKResultIndexmethod>
      indexing_options: Option<AiSearchNamespaceUpdateInstance_OKResultIndexingoptions>
      last_activity: Option<System.DateTimeOffset>
      max_num_results: Option<int>
      metadata: Option<AiSearchNamespaceUpdateInstance_OKResultMetadata>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      ``namespace``: Option<string>
      paused: Option<bool>
      public_endpoint_id: Option<string>
      public_endpoint_params: Option<AiSearchNamespaceUpdateInstance_OKResultPublicendpointparams>
      reranking: Option<bool>
      reranking_model: Option<AiSearchNamespaceUpdateInstance_OKResultRerankingmodel>
      retrieval_options: Option<AiSearchNamespaceUpdateInstance_OKResultRetrievaloptions>
      rewrite_model: Option<AiSearchNamespaceUpdateInstance_OKResultRewritemodel>
      rewrite_query: Option<bool>
      score_threshold: Option<float>
      source: Option<string>
      source_params: Option<AiSearchNamespaceUpdateInstance_OKResultSourceparams>
      status: Option<string>
      ///Interval between automatic syncs, in seconds. Allowed values: 900 (15min), 1800 (30min), 3600 (1h), 7200 (2h), 14400 (4h), 21600 (6h), 43200 (12h), 86400 (24h).
      sync_interval: Option<obj>
      token_id: Option<System.Guid>
      ``type``: Option<AiSearchNamespaceUpdateInstance_OKResultType> }

type AiSearchNamespaceUpdateInstance_OK =
    { result: AiSearchNamespaceUpdateInstance_OKResult
      success: bool }

type AiSearchNamespaceUpdateInstance_BadRequestErrors = { code: float; message: string }

type AiSearchNamespaceUpdateInstance_BadRequest =
    { errors: list<AiSearchNamespaceUpdateInstance_BadRequestErrors>
      success: bool }

type AiSearchNamespaceUpdateInstance_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceUpdateInstance_NotFound =
    { errors: list<AiSearchNamespaceUpdateInstance_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceUpdateInstance =
    ///Returns the updated instance.
    | OK of payload: AiSearchNamespaceUpdateInstance_OK
    ///Ai search instance invalid token.
    | BadRequest of payload: AiSearchNamespaceUpdateInstance_BadRequest
    ///Ai search not found.
    | NotFound of payload: AiSearchNamespaceUpdateInstance_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsCacheCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

type AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsCache =
    { cache_threshold: Option<AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsCacheCachethreshold>
      enabled: Option<bool> }
    ///Creates an instance of AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsCache with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsCache =
        { cache_threshold = None
          enabled = None }

type AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsQueryrewrite =
    { enabled: Option<bool>
      model: Option<string>
      rewrite_prompt: Option<string> }
    ///Creates an instance of AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsQueryrewrite with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsQueryrewrite =
        { enabled = None
          model = None
          rewrite_prompt = None }

type AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsReranking =
    { enabled: Option<bool>
      match_threshold: Option<float>
      model: Option<string> }
    ///Creates an instance of AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsReranking with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsReranking =
        { enabled = None
          match_threshold = None
          model = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsRetrievalBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsRetrievalBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsRetrievalBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsRetrievalBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsRetrievalBoostby =
        { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsRetrievalFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsRetrievalKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsRetrievalRetrievaltype =
    | [<CompiledName "vector">] Vector
    | [<CompiledName "keyword">] Keyword
    | [<CompiledName "hybrid">] Hybrid
    member this.Format() =
        match this with
        | Vector -> "vector"
        | Keyword -> "keyword"
        | Hybrid -> "hybrid"

type AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsRetrieval =
    { ///Metadata fields to boost search results by. Overrides the instance-level boost_by config. Direction defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsRetrievalBoostby>>
      context_expansion: Option<int>
      filters: Option<obj>
      fusion_method: Option<AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsRetrievalFusionmethod>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsRetrievalKeywordmatchmode>
      match_threshold: Option<float>
      max_num_results: Option<int>
      retrieval_type: Option<AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsRetrievalRetrievaltype>
      return_on_failure: Option<bool> }
    ///Creates an instance of AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsRetrieval with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsRetrieval =
        { boost_by = None
          context_expansion = None
          filters = None
          fusion_method = None
          keyword_match_mode = None
          match_threshold = None
          max_num_results = None
          retrieval_type = None
          return_on_failure = None }

type AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptions =
    { cache: Option<AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsCache>
      query_rewrite: Option<AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsQueryrewrite>
      reranking: Option<AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsReranking>
      retrieval: Option<AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptionsRetrieval> }
    ///Creates an instance of AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptions =
        { cache = None
          query_rewrite = None
          reranking = None
          retrieval = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceChatCompletionPayloadMessagesRole =
    | [<CompiledName "system">] System
    | [<CompiledName "developer">] Developer
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    | [<CompiledName "tool">] Tool
    member this.Format() =
        match this with
        | System -> "system"
        | Developer -> "developer"
        | User -> "user"
        | Assistant -> "assistant"
        | Tool -> "tool"

type AiSearchNamespaceInstanceChatCompletionPayloadMessages =
    { content: string
      role: AiSearchNamespaceInstanceChatCompletionPayloadMessagesRole }
    ///Creates an instance of AiSearchNamespaceInstanceChatCompletionPayloadMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string, role: AiSearchNamespaceInstanceChatCompletionPayloadMessagesRole): AiSearchNamespaceInstanceChatCompletionPayloadMessages =
        { content = content; role = role }

type AiSearchNamespaceInstanceChatCompletionPayload =
    { ai_search_options: Option<AiSearchNamespaceInstanceChatCompletionPayloadAisearchoptions>
      messages: list<AiSearchNamespaceInstanceChatCompletionPayloadMessages>
      model: Option<string>
      stream: Option<bool> }
    ///Creates an instance of AiSearchNamespaceInstanceChatCompletionPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (messages: list<AiSearchNamespaceInstanceChatCompletionPayloadMessages>): AiSearchNamespaceInstanceChatCompletionPayload =
        { ai_search_options = None
          messages = messages
          model = None
          stream = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceChatCompletion_OKChoicesMessageRole =
    | [<CompiledName "system">] System
    | [<CompiledName "developer">] Developer
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    | [<CompiledName "tool">] Tool
    member this.Format() =
        match this with
        | System -> "system"
        | Developer -> "developer"
        | User -> "user"
        | Assistant -> "assistant"
        | Tool -> "tool"

type AiSearchNamespaceInstanceChatCompletion_OKChoicesMessage =
    { content: string
      role: AiSearchNamespaceInstanceChatCompletion_OKChoicesMessageRole }

type AiSearchNamespaceInstanceChatCompletion_OKChoices =
    { index: Option<int>
      message: AiSearchNamespaceInstanceChatCompletion_OKChoicesMessage }

type AiSearchNamespaceInstanceChatCompletion_OKChunksItem =
    { key: string
      metadata: Option<obj>
      timestamp: Option<float> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceChatCompletion_OKChunksScoringdetailsFusionmethod =
    | [<CompiledName "rrf">] Rrf
    | [<CompiledName "max">] Max
    member this.Format() =
        match this with
        | Rrf -> "rrf"
        | Max -> "max"

type AiSearchNamespaceInstanceChatCompletion_OKChunksScoringdetails =
    { fusion_method: Option<AiSearchNamespaceInstanceChatCompletion_OKChunksScoringdetailsFusionmethod>
      keyword_rank: Option<float>
      keyword_score: Option<float>
      reranking_score: Option<float>
      vector_rank: Option<float>
      vector_score: Option<float> }

type AiSearchNamespaceInstanceChatCompletion_OKChunks =
    { id: string
      item: Option<AiSearchNamespaceInstanceChatCompletion_OKChunksItem>
      score: float
      scoring_details: Option<AiSearchNamespaceInstanceChatCompletion_OKChunksScoringdetails>
      text: string
      ``type``: string }

type AiSearchNamespaceInstanceChatCompletion_OK =
    { choices: list<AiSearchNamespaceInstanceChatCompletion_OKChoices>
      chunks: list<AiSearchNamespaceInstanceChatCompletion_OKChunks>
      id: Option<string>
      model: Option<string>
      object: Option<string> }

type AiSearchNamespaceInstanceChatCompletion_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchNamespaceInstanceChatCompletion_BadRequest =
    { errors: list<AiSearchNamespaceInstanceChatCompletion_BadRequestErrors>
      success: bool }

type AiSearchNamespaceInstanceChatCompletion_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceInstanceChatCompletion_NotFound =
    { errors: list<AiSearchNamespaceInstanceChatCompletion_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceInstanceChatCompletion =
    ///Returns the chat completions results with retrieved files.
    | OK of payload: AiSearchNamespaceInstanceChatCompletion_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchNamespaceInstanceChatCompletion_BadRequest
    ///Not Found
    | NotFound of payload: AiSearchNamespaceInstanceChatCompletion_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Nextaction =
    | [<CompiledName "INDEX">] INDEX
    | [<CompiledName "DELETE">] DELETE
    member this.Format() =
        match this with
        | INDEX -> "INDEX"
        | DELETE -> "DELETE"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Status =
    | [<CompiledName "queued">] Queued
    | [<CompiledName "running">] Running
    | [<CompiledName "completed">] Completed
    | [<CompiledName "error">] Error
    | [<CompiledName "skipped">] Skipped
    | [<CompiledName "outdated">] Outdated
    member this.Format() =
        match this with
        | Queued -> "queued"
        | Running -> "running"
        | Completed -> "completed"
        | Error -> "error"
        | Skipped -> "skipped"
        | Outdated -> "outdated"

type AiSearchNamespaceInstanceListItems_OKResult =
    { checksum: string
      chunks_count: int
      created_at: System.DateTimeOffset
      error: Option<string>
      file_size: float
      id: string
      key: string
      last_seen_at: System.DateTimeOffset
      ``namespace``: string
      next_action: Nextaction
      ///Identifies which data source this item belongs to. "builtin" for uploaded files, "{type}:{source}" for external sources, null for legacy items.
      source_id: string
      status: Status }

type AiSearchNamespaceInstanceListItems_OKResultinfo =
    { count: int
      page: int
      per_page: Option<int>
      total_count: int }

type AiSearchNamespaceInstanceListItems_OK =
    { result: list<AiSearchNamespaceInstanceListItems_OKResult>
      result_info: AiSearchNamespaceInstanceListItems_OKResultinfo
      success: bool }

type AiSearchNamespaceInstanceListItems_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchNamespaceInstanceListItems_BadRequest =
    { errors: list<AiSearchNamespaceInstanceListItems_BadRequestErrors>
      success: bool }

type AiSearchNamespaceInstanceListItems_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceInstanceListItems_NotFound =
    { errors: list<AiSearchNamespaceInstanceListItems_NotFoundErrors>
      success: bool }

type AiSearchNamespaceInstanceListItems_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchNamespaceInstanceListItems_ServiceUnavailable =
    { errors: list<AiSearchNamespaceInstanceListItems_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceInstanceListItems =
    ///Returns the AI Search items.
    | OK of payload: AiSearchNamespaceInstanceListItems_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchNamespaceInstanceListItems_BadRequest
    ///Ai search not found.
    | NotFound of payload: AiSearchNamespaceInstanceListItems_NotFound
    ///Unable to connect to ai search.
    | ServiceUnavailable of payload: AiSearchNamespaceInstanceListItems_ServiceUnavailable

type AiSearchNamespaceInstanceUploadItemPayload =
    { ///The file to upload (max 4MB). Filename must not exceed 128 characters.
      file: string
      ///JSON string of custom metadata key-value pairs.
      metadata: Option<string>
      ///Wait for indexing to fully complete before responding. On RAGs with vector indexing enabled, this additionally waits for Vectorize ingestion confirmation (up to 40s) so the returned item reflects a queryable state. On timeout the item is returned in `running` state and the background alarm continues polling. Defaults to false.
      wait_for_completion: Option<bool> }
    ///Creates an instance of AiSearchNamespaceInstanceUploadItemPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (file: string): AiSearchNamespaceInstanceUploadItemPayload =
        { file = file
          metadata = None
          wait_for_completion = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceUploadItem_OKResultNextaction =
    | [<CompiledName "INDEX">] INDEX
    | [<CompiledName "DELETE">] DELETE
    member this.Format() =
        match this with
        | INDEX -> "INDEX"
        | DELETE -> "DELETE"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceUploadItem_OKResultStatus =
    | [<CompiledName "queued">] Queued
    | [<CompiledName "running">] Running
    | [<CompiledName "completed">] Completed
    | [<CompiledName "error">] Error
    | [<CompiledName "skipped">] Skipped
    | [<CompiledName "outdated">] Outdated
    member this.Format() =
        match this with
        | Queued -> "queued"
        | Running -> "running"
        | Completed -> "completed"
        | Error -> "error"
        | Skipped -> "skipped"
        | Outdated -> "outdated"

type AiSearchNamespaceInstanceUploadItem_OKResult =
    { checksum: string
      chunks_count: int
      created_at: System.DateTimeOffset
      error: Option<string>
      file_size: float
      id: string
      key: string
      last_seen_at: System.DateTimeOffset
      ``namespace``: string
      next_action: AiSearchNamespaceInstanceUploadItem_OKResultNextaction
      ///Identifies which data source this item belongs to. "builtin" for uploaded files, "{type}:{source}" for external sources, null for legacy items.
      source_id: string
      status: AiSearchNamespaceInstanceUploadItem_OKResultStatus }

type AiSearchNamespaceInstanceUploadItem_OK =
    { result: AiSearchNamespaceInstanceUploadItem_OKResult
      success: bool }

type AiSearchNamespaceInstanceUploadItem_BadRequestErrors = { code: float; message: string }

type AiSearchNamespaceInstanceUploadItem_BadRequest =
    { errors: list<AiSearchNamespaceInstanceUploadItem_BadRequestErrors>
      success: bool }

type AiSearchNamespaceInstanceUploadItem_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceInstanceUploadItem_NotFound =
    { errors: list<AiSearchNamespaceInstanceUploadItem_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceInstanceUploadItem =
    ///Item uploaded successfully.
    | OK of payload: AiSearchNamespaceInstanceUploadItem_OK
    ///Invalid metadata format.
    | BadRequest of payload: AiSearchNamespaceInstanceUploadItem_BadRequest
    ///Ai search not found.
    | NotFound of payload: AiSearchNamespaceInstanceUploadItem_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceCreateOrUpdateItemPayloadNextaction =
    | [<CompiledName "INDEX">] INDEX
    member this.Format() =
        match this with
        | INDEX -> "INDEX"

type AiSearchNamespaceInstanceCreateOrUpdateItemPayload =
    { ///Item key / filename. Must not exceed 128 characters.
      key: string
      next_action: AiSearchNamespaceInstanceCreateOrUpdateItemPayloadNextaction
      ///Wait for indexing to fully complete before responding. On RAGs with vector indexing enabled, this additionally waits for Vectorize ingestion confirmation (up to 40s) so the returned item reflects a queryable state. On timeout the item is returned in `running` state and the background alarm continues polling. Defaults to false.
      wait_for_completion: Option<bool> }
    ///Creates an instance of AiSearchNamespaceInstanceCreateOrUpdateItemPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (key: string, next_action: AiSearchNamespaceInstanceCreateOrUpdateItemPayloadNextaction): AiSearchNamespaceInstanceCreateOrUpdateItemPayload =
        { key = key
          next_action = next_action
          wait_for_completion = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceCreateOrUpdateItem_OKResultNextaction =
    | [<CompiledName "INDEX">] INDEX
    | [<CompiledName "DELETE">] DELETE
    member this.Format() =
        match this with
        | INDEX -> "INDEX"
        | DELETE -> "DELETE"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceCreateOrUpdateItem_OKResultStatus =
    | [<CompiledName "queued">] Queued
    | [<CompiledName "running">] Running
    | [<CompiledName "completed">] Completed
    | [<CompiledName "error">] Error
    | [<CompiledName "skipped">] Skipped
    | [<CompiledName "outdated">] Outdated
    member this.Format() =
        match this with
        | Queued -> "queued"
        | Running -> "running"
        | Completed -> "completed"
        | Error -> "error"
        | Skipped -> "skipped"
        | Outdated -> "outdated"

type AiSearchNamespaceInstanceCreateOrUpdateItem_OKResult =
    { checksum: string
      chunks_count: int
      created_at: System.DateTimeOffset
      error: Option<string>
      file_size: float
      id: string
      key: string
      last_seen_at: System.DateTimeOffset
      ``namespace``: string
      next_action: AiSearchNamespaceInstanceCreateOrUpdateItem_OKResultNextaction
      ///Identifies which data source this item belongs to. "builtin" for uploaded files, "{type}:{source}" for external sources, null for legacy items.
      source_id: string
      status: AiSearchNamespaceInstanceCreateOrUpdateItem_OKResultStatus }

type AiSearchNamespaceInstanceCreateOrUpdateItem_OK =
    { result: AiSearchNamespaceInstanceCreateOrUpdateItem_OKResult
      success: bool }

type AiSearchNamespaceInstanceCreateOrUpdateItem_BadRequestErrors = { code: float; message: string }

type AiSearchNamespaceInstanceCreateOrUpdateItem_BadRequest =
    { errors: list<AiSearchNamespaceInstanceCreateOrUpdateItem_BadRequestErrors>
      success: bool }

type AiSearchNamespaceInstanceCreateOrUpdateItem_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceInstanceCreateOrUpdateItem_NotFound =
    { errors: list<AiSearchNamespaceInstanceCreateOrUpdateItem_NotFoundErrors>
      success: bool }

type AiSearchNamespaceInstanceCreateOrUpdateItem_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchNamespaceInstanceCreateOrUpdateItem_ServiceUnavailable =
    { errors: list<AiSearchNamespaceInstanceCreateOrUpdateItem_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceInstanceCreateOrUpdateItem =
    ///Returns a AI Search Item detail.
    | OK of payload: AiSearchNamespaceInstanceCreateOrUpdateItem_OK
    ///Filename exceeds maximum length.
    | BadRequest of payload: AiSearchNamespaceInstanceCreateOrUpdateItem_BadRequest
    ///Ai search not found.
    | NotFound of payload: AiSearchNamespaceInstanceCreateOrUpdateItem_NotFound
    ///Unable to sync item.
    | ServiceUnavailable of payload: AiSearchNamespaceInstanceCreateOrUpdateItem_ServiceUnavailable

type AiSearchNamespaceInstanceDeleteItem_OKResult = { key: string }

type AiSearchNamespaceInstanceDeleteItem_OK =
    { result: AiSearchNamespaceInstanceDeleteItem_OKResult
      success: bool }

type AiSearchNamespaceInstanceDeleteItem_BadRequestErrors = { code: float; message: string }

type AiSearchNamespaceInstanceDeleteItem_BadRequest =
    { errors: list<AiSearchNamespaceInstanceDeleteItem_BadRequestErrors>
      success: bool }

type AiSearchNamespaceInstanceDeleteItem_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceInstanceDeleteItem_NotFound =
    { errors: list<AiSearchNamespaceInstanceDeleteItem_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceInstanceDeleteItem =
    ///Item deleted successfully.
    | OK of payload: AiSearchNamespaceInstanceDeleteItem_OK
    ///This operation requires a managed instance.
    | BadRequest of payload: AiSearchNamespaceInstanceDeleteItem_BadRequest
    ///Item not found.
    | NotFound of payload: AiSearchNamespaceInstanceDeleteItem_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceGetItem_OKResultNextaction =
    | [<CompiledName "INDEX">] INDEX
    | [<CompiledName "DELETE">] DELETE
    member this.Format() =
        match this with
        | INDEX -> "INDEX"
        | DELETE -> "DELETE"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceGetItem_OKResultStatus =
    | [<CompiledName "queued">] Queued
    | [<CompiledName "running">] Running
    | [<CompiledName "completed">] Completed
    | [<CompiledName "error">] Error
    | [<CompiledName "skipped">] Skipped
    | [<CompiledName "outdated">] Outdated
    member this.Format() =
        match this with
        | Queued -> "queued"
        | Running -> "running"
        | Completed -> "completed"
        | Error -> "error"
        | Skipped -> "skipped"
        | Outdated -> "outdated"

type AiSearchNamespaceInstanceGetItem_OKResult =
    { checksum: string
      chunks_count: int
      created_at: System.DateTimeOffset
      error: Option<string>
      file_size: float
      id: string
      key: string
      last_seen_at: System.DateTimeOffset
      ``namespace``: string
      next_action: AiSearchNamespaceInstanceGetItem_OKResultNextaction
      ///Identifies which data source this item belongs to. "builtin" for uploaded files, "{type}:{source}" for external sources, null for legacy items.
      source_id: string
      status: AiSearchNamespaceInstanceGetItem_OKResultStatus }

type AiSearchNamespaceInstanceGetItem_OK =
    { result: AiSearchNamespaceInstanceGetItem_OKResult
      success: bool }

type AiSearchNamespaceInstanceGetItem_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceInstanceGetItem_NotFound =
    { errors: list<AiSearchNamespaceInstanceGetItem_NotFoundErrors>
      success: bool }

type AiSearchNamespaceInstanceGetItem_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchNamespaceInstanceGetItem_ServiceUnavailable =
    { errors: list<AiSearchNamespaceInstanceGetItem_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceInstanceGetItem =
    ///Returns a AI Search Item detail.
    | OK of payload: AiSearchNamespaceInstanceGetItem_OK
    ///Job not found.
    | NotFound of payload: AiSearchNamespaceInstanceGetItem_NotFound
    ///Unable to connect to ai search.
    | ServiceUnavailable of payload: AiSearchNamespaceInstanceGetItem_ServiceUnavailable

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceSyncItemPayloadNextaction =
    | [<CompiledName "INDEX">] INDEX
    member this.Format() =
        match this with
        | INDEX -> "INDEX"

type AiSearchNamespaceInstanceSyncItemPayload =
    { next_action: AiSearchNamespaceInstanceSyncItemPayloadNextaction
      ///Wait for indexing to fully complete before responding. On RAGs with vector indexing enabled, this additionally waits for Vectorize ingestion confirmation (up to 40s) so the returned item reflects a queryable state. On timeout the item is returned in `running` state and the background alarm continues polling. Defaults to false.
      wait_for_completion: Option<bool> }
    ///Creates an instance of AiSearchNamespaceInstanceSyncItemPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (next_action: AiSearchNamespaceInstanceSyncItemPayloadNextaction): AiSearchNamespaceInstanceSyncItemPayload =
        { next_action = next_action
          wait_for_completion = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceSyncItem_OKResultNextaction =
    | [<CompiledName "INDEX">] INDEX
    | [<CompiledName "DELETE">] DELETE
    member this.Format() =
        match this with
        | INDEX -> "INDEX"
        | DELETE -> "DELETE"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceSyncItem_OKResultStatus =
    | [<CompiledName "queued">] Queued
    | [<CompiledName "running">] Running
    | [<CompiledName "completed">] Completed
    | [<CompiledName "error">] Error
    | [<CompiledName "skipped">] Skipped
    | [<CompiledName "outdated">] Outdated
    member this.Format() =
        match this with
        | Queued -> "queued"
        | Running -> "running"
        | Completed -> "completed"
        | Error -> "error"
        | Skipped -> "skipped"
        | Outdated -> "outdated"

type AiSearchNamespaceInstanceSyncItem_OKResult =
    { checksum: string
      chunks_count: int
      created_at: System.DateTimeOffset
      error: Option<string>
      file_size: float
      id: string
      key: string
      last_seen_at: System.DateTimeOffset
      ``namespace``: string
      next_action: AiSearchNamespaceInstanceSyncItem_OKResultNextaction
      ///Identifies which data source this item belongs to. "builtin" for uploaded files, "{type}:{source}" for external sources, null for legacy items.
      source_id: string
      status: AiSearchNamespaceInstanceSyncItem_OKResultStatus }

type AiSearchNamespaceInstanceSyncItem_OK =
    { result: AiSearchNamespaceInstanceSyncItem_OKResult
      success: bool }

type AiSearchNamespaceInstanceSyncItem_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchNamespaceInstanceSyncItem_BadRequest =
    { errors: list<AiSearchNamespaceInstanceSyncItem_BadRequestErrors>
      success: bool }

type AiSearchNamespaceInstanceSyncItem_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceInstanceSyncItem_NotFound =
    { errors: list<AiSearchNamespaceInstanceSyncItem_NotFoundErrors>
      success: bool }

type AiSearchNamespaceInstanceSyncItem_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchNamespaceInstanceSyncItem_ServiceUnavailable =
    { errors: list<AiSearchNamespaceInstanceSyncItem_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceInstanceSyncItem =
    ///Returns a AI Search Item detail.
    | OK of payload: AiSearchNamespaceInstanceSyncItem_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchNamespaceInstanceSyncItem_BadRequest
    ///Ai search not found.
    | NotFound of payload: AiSearchNamespaceInstanceSyncItem_NotFound
    ///Unable to sync item.
    | ServiceUnavailable of payload: AiSearchNamespaceInstanceSyncItem_ServiceUnavailable

type AiSearchNamespaceInstanceListItemChunks_OKResultItem =
    { key: string
      metadata: Option<obj>
      timestamp: Option<float> }

type AiSearchNamespaceInstanceListItemChunks_OKResult =
    { end_byte: Option<float>
      id: string
      item: AiSearchNamespaceInstanceListItemChunks_OKResultItem
      start_byte: Option<float>
      text: string }

type AiSearchNamespaceInstanceListItemChunks_OKResultinfo =
    { count: int
      limit: int
      offset: int
      total: int }

type AiSearchNamespaceInstanceListItemChunks_OK =
    { result: list<AiSearchNamespaceInstanceListItemChunks_OKResult>
      result_info: AiSearchNamespaceInstanceListItemChunks_OKResultinfo
      success: bool }

type AiSearchNamespaceInstanceListItemChunks_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchNamespaceInstanceListItemChunks_BadRequest =
    { errors: list<AiSearchNamespaceInstanceListItemChunks_BadRequestErrors>
      success: bool }

type AiSearchNamespaceInstanceListItemChunks_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceInstanceListItemChunks_NotFound =
    { errors: list<AiSearchNamespaceInstanceListItemChunks_NotFoundErrors>
      success: bool }

type AiSearchNamespaceInstanceListItemChunks_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchNamespaceInstanceListItemChunks_ServiceUnavailable =
    { errors: list<AiSearchNamespaceInstanceListItemChunks_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceInstanceListItemChunks =
    ///Returns the AI Search item chunks with text content.
    | OK of payload: AiSearchNamespaceInstanceListItemChunks_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchNamespaceInstanceListItemChunks_BadRequest
    ///Item not found.
    | NotFound of payload: AiSearchNamespaceInstanceListItemChunks_NotFound
    ///Unable to connect to ai search.
    | ServiceUnavailable of payload: AiSearchNamespaceInstanceListItemChunks_ServiceUnavailable

type AiSearchNamespaceInstanceGetItemContent_BadRequestErrors = { code: float; message: string }

type AiSearchNamespaceInstanceGetItemContent_BadRequest =
    { errors: list<AiSearchNamespaceInstanceGetItemContent_BadRequestErrors>
      success: bool }

type AiSearchNamespaceInstanceGetItemContent_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceInstanceGetItemContent_NotFound =
    { errors: list<AiSearchNamespaceInstanceGetItemContent_NotFoundErrors>
      success: bool }

type AiSearchNamespaceInstanceGetItemContent_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchNamespaceInstanceGetItemContent_ServiceUnavailable =
    { errors: list<AiSearchNamespaceInstanceGetItemContent_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceInstanceGetItemContent =
    ///Raw file content.
    | OK of payload: string
    ///Content download not available for external source items.
    | BadRequest of payload: AiSearchNamespaceInstanceGetItemContent_BadRequest
    ///Item not found.
    | NotFound of payload: AiSearchNamespaceInstanceGetItemContent_NotFound
    ///Unable to connect to ai search.
    | ServiceUnavailable of payload: AiSearchNamespaceInstanceGetItemContent_ServiceUnavailable

type AiSearchNamespaceInstanceLogsItem_OKResult =
    { action: string
      chunkCount: int
      errorType: string
      fileKey: string
      message: string
      processingTimeMs: int
      timestamp: System.DateTimeOffset }

type AiSearchNamespaceInstanceLogsItem_OKResultinfo =
    { count: int
      cursor: string
      per_page: int
      truncated: bool }

type AiSearchNamespaceInstanceLogsItem_OK =
    { result: list<AiSearchNamespaceInstanceLogsItem_OKResult>
      result_info: AiSearchNamespaceInstanceLogsItem_OKResultinfo
      success: bool }

type AiSearchNamespaceInstanceLogsItem_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchNamespaceInstanceLogsItem_BadRequest =
    { errors: list<AiSearchNamespaceInstanceLogsItem_BadRequestErrors>
      success: bool }

type AiSearchNamespaceInstanceLogsItem_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceInstanceLogsItem_NotFound =
    { errors: list<AiSearchNamespaceInstanceLogsItem_NotFoundErrors>
      success: bool }

type AiSearchNamespaceInstanceLogsItem_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchNamespaceInstanceLogsItem_ServiceUnavailable =
    { errors: list<AiSearchNamespaceInstanceLogsItem_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceInstanceLogsItem =
    ///Returns the AI Search item logs.
    | OK of payload: AiSearchNamespaceInstanceLogsItem_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchNamespaceInstanceLogsItem_BadRequest
    ///Item not found.
    | NotFound of payload: AiSearchNamespaceInstanceLogsItem_NotFound
    ///Unable to connect to ai search.
    | ServiceUnavailable of payload: AiSearchNamespaceInstanceLogsItem_ServiceUnavailable

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceListJobs_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AiSearchNamespaceInstanceListJobs_OKResult =
    { description: Option<string>
      end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AiSearchNamespaceInstanceListJobs_OKResultSource
      started_at: Option<string> }

type AiSearchNamespaceInstanceListJobs_OKResultinfo =
    { count: int
      page: int
      per_page: int
      total_count: int }

type AiSearchNamespaceInstanceListJobs_OK =
    { result: list<AiSearchNamespaceInstanceListJobs_OKResult>
      result_info: AiSearchNamespaceInstanceListJobs_OKResultinfo
      success: bool }

type AiSearchNamespaceInstanceListJobs_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchNamespaceInstanceListJobs_BadRequest =
    { errors: list<AiSearchNamespaceInstanceListJobs_BadRequestErrors>
      success: bool }

type AiSearchNamespaceInstanceListJobs_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceInstanceListJobs_NotFound =
    { errors: list<AiSearchNamespaceInstanceListJobs_NotFoundErrors>
      success: bool }

type AiSearchNamespaceInstanceListJobs_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchNamespaceInstanceListJobs_ServiceUnavailable =
    { errors: list<AiSearchNamespaceInstanceListJobs_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceInstanceListJobs =
    ///Returns a list of AI Search Jobs.
    | OK of payload: AiSearchNamespaceInstanceListJobs_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchNamespaceInstanceListJobs_BadRequest
    ///Ai search not found.
    | NotFound of payload: AiSearchNamespaceInstanceListJobs_NotFound
    ///Unable to connect to ai search.
    | ServiceUnavailable of payload: AiSearchNamespaceInstanceListJobs_ServiceUnavailable

type AiSearchNamespaceInstanceCreateJobPayload =
    { description: Option<string> }
    ///Creates an instance of AiSearchNamespaceInstanceCreateJobPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceInstanceCreateJobPayload = { description = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceCreateJob_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AiSearchNamespaceInstanceCreateJob_OKResult =
    { description: Option<string>
      end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AiSearchNamespaceInstanceCreateJob_OKResultSource
      started_at: Option<string> }

type AiSearchNamespaceInstanceCreateJob_OK =
    { result: AiSearchNamespaceInstanceCreateJob_OKResult
      success: bool }

type AiSearchNamespaceInstanceCreateJob_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchNamespaceInstanceCreateJob_BadRequest =
    { errors: list<AiSearchNamespaceInstanceCreateJob_BadRequestErrors>
      success: bool }

type AiSearchNamespaceInstanceCreateJob_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceInstanceCreateJob_NotFound =
    { errors: list<AiSearchNamespaceInstanceCreateJob_NotFoundErrors>
      success: bool }

type AiSearchNamespaceInstanceCreateJob_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchNamespaceInstanceCreateJob_ServiceUnavailable =
    { errors: list<AiSearchNamespaceInstanceCreateJob_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceInstanceCreateJob =
    ///Returns the AI Search job id.
    | OK of payload: AiSearchNamespaceInstanceCreateJob_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchNamespaceInstanceCreateJob_BadRequest
    ///Ai search not found.
    | NotFound of payload: AiSearchNamespaceInstanceCreateJob_NotFound
    ///Unable to connect to ai search.
    | ServiceUnavailable of payload: AiSearchNamespaceInstanceCreateJob_ServiceUnavailable

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceGetJob_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AiSearchNamespaceInstanceGetJob_OKResult =
    { description: Option<string>
      end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AiSearchNamespaceInstanceGetJob_OKResultSource
      started_at: Option<string> }

type AiSearchNamespaceInstanceGetJob_OK =
    { result: AiSearchNamespaceInstanceGetJob_OKResult
      success: bool }

type AiSearchNamespaceInstanceGetJob_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceInstanceGetJob_NotFound =
    { errors: list<AiSearchNamespaceInstanceGetJob_NotFoundErrors>
      success: bool }

type AiSearchNamespaceInstanceGetJob_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchNamespaceInstanceGetJob_ServiceUnavailable =
    { errors: list<AiSearchNamespaceInstanceGetJob_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceInstanceGetJob =
    ///Returns a AI Search Job Details.
    | OK of payload: AiSearchNamespaceInstanceGetJob_OK
    ///Job not found.
    | NotFound of payload: AiSearchNamespaceInstanceGetJob_NotFound
    ///Unable to connect to ai search.
    | ServiceUnavailable of payload: AiSearchNamespaceInstanceGetJob_ServiceUnavailable

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceChangeJobStatusPayloadAction =
    | [<CompiledName "cancel">] Cancel
    member this.Format() =
        match this with
        | Cancel -> "cancel"

type AiSearchNamespaceInstanceChangeJobStatusPayload =
    { action: AiSearchNamespaceInstanceChangeJobStatusPayloadAction }
    ///Creates an instance of AiSearchNamespaceInstanceChangeJobStatusPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (action: AiSearchNamespaceInstanceChangeJobStatusPayloadAction): AiSearchNamespaceInstanceChangeJobStatusPayload =
        { action = action }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceChangeJobStatus_OKResultSource =
    | [<CompiledName "user">] User
    | [<CompiledName "schedule">] Schedule
    member this.Format() =
        match this with
        | User -> "user"
        | Schedule -> "schedule"

type AiSearchNamespaceInstanceChangeJobStatus_OKResult =
    { description: Option<string>
      end_reason: Option<string>
      ended_at: Option<string>
      id: string
      last_seen_at: Option<string>
      source: AiSearchNamespaceInstanceChangeJobStatus_OKResultSource
      started_at: Option<string> }

type AiSearchNamespaceInstanceChangeJobStatus_OK =
    { result: AiSearchNamespaceInstanceChangeJobStatus_OKResult
      success: bool }

type AiSearchNamespaceInstanceChangeJobStatus_BadRequestErrors = { code: float; message: string }

type AiSearchNamespaceInstanceChangeJobStatus_BadRequest =
    { errors: list<AiSearchNamespaceInstanceChangeJobStatus_BadRequestErrors>
      success: bool }

type AiSearchNamespaceInstanceChangeJobStatus_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceInstanceChangeJobStatus_NotFound =
    { errors: list<AiSearchNamespaceInstanceChangeJobStatus_NotFoundErrors>
      success: bool }

type AiSearchNamespaceInstanceChangeJobStatus_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchNamespaceInstanceChangeJobStatus_ServiceUnavailable =
    { errors: list<AiSearchNamespaceInstanceChangeJobStatus_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceInstanceChangeJobStatus =
    ///Returns the updated AI Search Job.
    | OK of payload: AiSearchNamespaceInstanceChangeJobStatus_OK
    ///Job cannot be cancelled.
    | BadRequest of payload: AiSearchNamespaceInstanceChangeJobStatus_BadRequest
    ///Job not found.
    | NotFound of payload: AiSearchNamespaceInstanceChangeJobStatus_NotFound
    ///Unable to connect to ai search.
    | ServiceUnavailable of payload: AiSearchNamespaceInstanceChangeJobStatus_ServiceUnavailable

type AiSearchNamespaceInstanceListJobLogs_OKResult =
    { created_at: float
      id: int
      message: string
      message_type: int }

type AiSearchNamespaceInstanceListJobLogs_OKResultinfo =
    { count: int
      page: int
      per_page: int
      total_count: int }

type AiSearchNamespaceInstanceListJobLogs_OK =
    { result: list<AiSearchNamespaceInstanceListJobLogs_OKResult>
      result_info: AiSearchNamespaceInstanceListJobLogs_OKResultinfo
      success: bool }

type AiSearchNamespaceInstanceListJobLogs_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchNamespaceInstanceListJobLogs_BadRequest =
    { errors: list<AiSearchNamespaceInstanceListJobLogs_BadRequestErrors>
      success: bool }

type AiSearchNamespaceInstanceListJobLogs_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceInstanceListJobLogs_NotFound =
    { errors: list<AiSearchNamespaceInstanceListJobLogs_NotFoundErrors>
      success: bool }

type AiSearchNamespaceInstanceListJobLogs_ServiceUnavailableErrors = { code: float; message: string }

type AiSearchNamespaceInstanceListJobLogs_ServiceUnavailable =
    { errors: list<AiSearchNamespaceInstanceListJobLogs_ServiceUnavailableErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceInstanceListJobLogs =
    ///Returns a list of AI Search Job Logs.
    | OK of payload: AiSearchNamespaceInstanceListJobLogs_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchNamespaceInstanceListJobLogs_BadRequest
    ///Ai search not found.
    | NotFound of payload: AiSearchNamespaceInstanceListJobLogs_NotFound
    ///Unable to connect to ai search.
    | ServiceUnavailable of payload: AiSearchNamespaceInstanceListJobLogs_ServiceUnavailable

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceSearchPayloadAisearchoptionsCacheCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

type AiSearchNamespaceInstanceSearchPayloadAisearchoptionsCache =
    { cache_threshold: Option<AiSearchNamespaceInstanceSearchPayloadAisearchoptionsCacheCachethreshold>
      enabled: Option<bool> }
    ///Creates an instance of AiSearchNamespaceInstanceSearchPayloadAisearchoptionsCache with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceInstanceSearchPayloadAisearchoptionsCache =
        { cache_threshold = None
          enabled = None }

type AiSearchNamespaceInstanceSearchPayloadAisearchoptionsQueryrewrite =
    { enabled: Option<bool>
      model: Option<obj>
      rewrite_prompt: Option<string> }
    ///Creates an instance of AiSearchNamespaceInstanceSearchPayloadAisearchoptionsQueryrewrite with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceInstanceSearchPayloadAisearchoptionsQueryrewrite =
        { enabled = None
          model = None
          rewrite_prompt = None }

type AiSearchNamespaceInstanceSearchPayloadAisearchoptionsReranking =
    { enabled: Option<bool>
      match_threshold: Option<float>
      model: Option<obj> }
    ///Creates an instance of AiSearchNamespaceInstanceSearchPayloadAisearchoptionsReranking with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceInstanceSearchPayloadAisearchoptionsReranking =
        { enabled = None
          match_threshold = None
          model = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceSearchPayloadAisearchoptionsRetrievalBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchNamespaceInstanceSearchPayloadAisearchoptionsRetrievalBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchNamespaceInstanceSearchPayloadAisearchoptionsRetrievalBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of AiSearchNamespaceInstanceSearchPayloadAisearchoptionsRetrievalBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): AiSearchNamespaceInstanceSearchPayloadAisearchoptionsRetrievalBoostby =
        { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceSearchPayloadAisearchoptionsRetrievalFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceSearchPayloadAisearchoptionsRetrievalKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceSearchPayloadAisearchoptionsRetrievalRetrievaltype =
    | [<CompiledName "vector">] Vector
    | [<CompiledName "keyword">] Keyword
    | [<CompiledName "hybrid">] Hybrid
    member this.Format() =
        match this with
        | Vector -> "vector"
        | Keyword -> "keyword"
        | Hybrid -> "hybrid"

type AiSearchNamespaceInstanceSearchPayloadAisearchoptionsRetrieval =
    { ///Metadata fields to boost search results by. Overrides the instance-level boost_by config. Direction defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchNamespaceInstanceSearchPayloadAisearchoptionsRetrievalBoostby>>
      context_expansion: Option<int>
      filters: Option<obj>
      fusion_method: Option<AiSearchNamespaceInstanceSearchPayloadAisearchoptionsRetrievalFusionmethod>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchNamespaceInstanceSearchPayloadAisearchoptionsRetrievalKeywordmatchmode>
      match_threshold: Option<float>
      max_num_results: Option<int>
      retrieval_type: Option<AiSearchNamespaceInstanceSearchPayloadAisearchoptionsRetrievalRetrievaltype>
      return_on_failure: Option<bool> }
    ///Creates an instance of AiSearchNamespaceInstanceSearchPayloadAisearchoptionsRetrieval with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceInstanceSearchPayloadAisearchoptionsRetrieval =
        { boost_by = None
          context_expansion = None
          filters = None
          fusion_method = None
          keyword_match_mode = None
          match_threshold = None
          max_num_results = None
          retrieval_type = None
          return_on_failure = None }

type AiSearchNamespaceInstanceSearchPayloadAisearchoptions =
    { cache: Option<AiSearchNamespaceInstanceSearchPayloadAisearchoptionsCache>
      query_rewrite: Option<AiSearchNamespaceInstanceSearchPayloadAisearchoptionsQueryrewrite>
      reranking: Option<AiSearchNamespaceInstanceSearchPayloadAisearchoptionsReranking>
      retrieval: Option<AiSearchNamespaceInstanceSearchPayloadAisearchoptionsRetrieval> }
    ///Creates an instance of AiSearchNamespaceInstanceSearchPayloadAisearchoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceInstanceSearchPayloadAisearchoptions =
        { cache = None
          query_rewrite = None
          reranking = None
          retrieval = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceSearchPayloadMessagesRole =
    | [<CompiledName "system">] System
    | [<CompiledName "developer">] Developer
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    | [<CompiledName "tool">] Tool
    member this.Format() =
        match this with
        | System -> "system"
        | Developer -> "developer"
        | User -> "user"
        | Assistant -> "assistant"
        | Tool -> "tool"

type AiSearchNamespaceInstanceSearchPayloadMessages =
    { content: string
      role: AiSearchNamespaceInstanceSearchPayloadMessagesRole }
    ///Creates an instance of AiSearchNamespaceInstanceSearchPayloadMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string, role: AiSearchNamespaceInstanceSearchPayloadMessagesRole): AiSearchNamespaceInstanceSearchPayloadMessages =
        { content = content; role = role }

type AiSearchNamespaceInstanceSearchPayload =
    { ai_search_options: Option<AiSearchNamespaceInstanceSearchPayloadAisearchoptions>
      messages: Option<list<AiSearchNamespaceInstanceSearchPayloadMessages>>
      ///A simple text query string. Alternative to 'messages' — provide either this or 'messages', not both.
      query: Option<string> }
    ///Creates an instance of AiSearchNamespaceInstanceSearchPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceInstanceSearchPayload =
        { ai_search_options = None
          messages = None
          query = None }

type AiSearchNamespaceInstanceSearch_OKResultChunksItem =
    { key: string
      metadata: Option<obj>
      timestamp: Option<float> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceInstanceSearch_OKResultChunksScoringdetailsFusionmethod =
    | [<CompiledName "rrf">] Rrf
    | [<CompiledName "max">] Max
    member this.Format() =
        match this with
        | Rrf -> "rrf"
        | Max -> "max"

type AiSearchNamespaceInstanceSearch_OKResultChunksScoringdetails =
    { fusion_method: Option<AiSearchNamespaceInstanceSearch_OKResultChunksScoringdetailsFusionmethod>
      keyword_rank: Option<float>
      keyword_score: Option<float>
      reranking_score: Option<float>
      vector_rank: Option<float>
      vector_score: Option<float> }

type AiSearchNamespaceInstanceSearch_OKResultChunks =
    { id: string
      item: Option<AiSearchNamespaceInstanceSearch_OKResultChunksItem>
      score: float
      scoring_details: Option<AiSearchNamespaceInstanceSearch_OKResultChunksScoringdetails>
      text: string
      ``type``: string }

type AiSearchNamespaceInstanceSearch_OKResult =
    { chunks: list<AiSearchNamespaceInstanceSearch_OKResultChunks>
      search_query: string }

type AiSearchNamespaceInstanceSearch_OK =
    { result: AiSearchNamespaceInstanceSearch_OKResult
      success: bool }

type AiSearchNamespaceInstanceSearch_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchNamespaceInstanceSearch_BadRequest =
    { errors: list<AiSearchNamespaceInstanceSearch_BadRequestErrors>
      success: bool }

type AiSearchNamespaceInstanceSearch_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceInstanceSearch_NotFound =
    { errors: list<AiSearchNamespaceInstanceSearch_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceInstanceSearch =
    ///Returns the search results.
    | OK of payload: AiSearchNamespaceInstanceSearch_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchNamespaceInstanceSearch_BadRequest
    ///Not Found
    | NotFound of payload: AiSearchNamespaceInstanceSearch_NotFound

///R2 bucket storage usage in bytes.
type AiSearchNamespaceStats_OKResultEngineR2 =
    { metadataSizeBytes: int
      objectCount: int
      payloadSizeBytes: int }

///Vectorize index metadata (dimensions, vector count).
type AiSearchNamespaceStats_OKResultEngineVectorize = { dimensions: int; vectorsCount: int }

///Engine-specific metadata. Present only for managed (v3) instances.
type AiSearchNamespaceStats_OKResultEngine =
    { ///R2 bucket storage usage in bytes.
      r2: Option<AiSearchNamespaceStats_OKResultEngineR2>
      ///Vectorize index metadata (dimensions, vector count).
      vectorize: Option<AiSearchNamespaceStats_OKResultEngineVectorize> }

type AiSearchNamespaceStats_OKResult =
    { completed: Option<int>
      ///Engine-specific metadata. Present only for managed (v3) instances.
      engine: Option<AiSearchNamespaceStats_OKResultEngine>
      error: Option<int>
      file_embed_errors: Option<Map<string, obj>>
      index_source_errors: Option<Map<string, obj>>
      last_activity: Option<System.DateTimeOffset>
      outdated: Option<int>
      queued: Option<int>
      running: Option<int>
      skipped: Option<int> }

type AiSearchNamespaceStats_OK =
    { result: AiSearchNamespaceStats_OKResult
      success: bool }

type AiSearchNamespaceStats_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceStats_NotFound =
    { errors: list<AiSearchNamespaceStats_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceStats =
    ///Returns the AI Search stats.
    | OK of payload: AiSearchNamespaceStats_OK
    ///Not Found
    | NotFound of payload: AiSearchNamespaceStats_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsCacheCachethreshold =
    | [<CompiledName "super_strict_match">] Super_strict_match
    | [<CompiledName "close_enough">] Close_enough
    | [<CompiledName "flexible_friend">] Flexible_friend
    | [<CompiledName "anything_goes">] Anything_goes
    member this.Format() =
        match this with
        | Super_strict_match -> "super_strict_match"
        | Close_enough -> "close_enough"
        | Flexible_friend -> "flexible_friend"
        | Anything_goes -> "anything_goes"

type AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsCache =
    { cache_threshold: Option<AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsCacheCachethreshold>
      enabled: Option<bool> }
    ///Creates an instance of AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsCache with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsCache =
        { cache_threshold = None
          enabled = None }

type AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsQueryrewrite =
    { enabled: Option<bool>
      model: Option<obj>
      rewrite_prompt: Option<string> }
    ///Creates an instance of AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsQueryrewrite with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsQueryrewrite =
        { enabled = None
          model = None
          rewrite_prompt = None }

type AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsReranking =
    { enabled: Option<bool>
      match_threshold: Option<float>
      model: Option<obj> }
    ///Creates an instance of AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsReranking with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsReranking =
        { enabled = None
          match_threshold = None
          model = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsRetrievalBoostbyDirection =
    | [<CompiledName "asc">] Asc
    | [<CompiledName "desc">] Desc
    | [<CompiledName "exists">] Exists
    | [<CompiledName "not_exists">] Not_exists
    member this.Format() =
        match this with
        | Asc -> "asc"
        | Desc -> "desc"
        | Exists -> "exists"
        | Not_exists -> "not_exists"

type AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsRetrievalBoostby =
    { ///Boost direction. 'desc' = higher values rank higher (e.g. newer timestamps). 'asc' = lower values rank higher. 'exists' = boost chunks that have the field. 'not_exists' = boost chunks that lack the field. Optional ��� defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields.
      direction: Option<AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsRetrievalBoostbyDirection>
      ///Metadata field name to boost by. Use 'timestamp' for document freshness, or any custom_metadata field. Numeric and datetime fields support asc/desc directions; text/boolean fields support exists/not_exists.
      field: string }
    ///Creates an instance of AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsRetrievalBoostby with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (field: string): AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsRetrievalBoostby =
        { direction = None; field = field }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsRetrievalFusionmethod =
    | [<CompiledName "max">] Max
    | [<CompiledName "rrf">] Rrf
    member this.Format() =
        match this with
        | Max -> "max"
        | Rrf -> "rrf"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsRetrievalKeywordmatchmode =
    | [<CompiledName "and">] And
    | [<CompiledName "or">] Or
    member this.Format() =
        match this with
        | And -> "and"
        | Or -> "or"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsRetrievalRetrievaltype =
    | [<CompiledName "vector">] Vector
    | [<CompiledName "keyword">] Keyword
    | [<CompiledName "hybrid">] Hybrid
    member this.Format() =
        match this with
        | Vector -> "vector"
        | Keyword -> "keyword"
        | Hybrid -> "hybrid"

type AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsRetrieval =
    { ///Metadata fields to boost search results by. Overrides the instance-level boost_by config. Direction defaults to 'asc' for numeric/datetime fields, 'exists' for text/boolean fields. Fields must match 'timestamp' or a defined custom_metadata field.
      boost_by: Option<list<AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsRetrievalBoostby>>
      context_expansion: Option<int>
      filters: Option<obj>
      fusion_method: Option<AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsRetrievalFusionmethod>
      ///Controls which documents are candidates for BM25 scoring. 'and' restricts candidates to documents containing all query terms; 'or' includes any document containing at least one term, ranked by BM25 relevance. Defaults to 'and'.
      keyword_match_mode: Option<AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsRetrievalKeywordmatchmode>
      match_threshold: Option<float>
      max_num_results: Option<int>
      retrieval_type: Option<AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsRetrievalRetrievaltype>
      return_on_failure: Option<bool> }
    ///Creates an instance of AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsRetrieval with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsRetrieval =
        { boost_by = None
          context_expansion = None
          filters = None
          fusion_method = None
          keyword_match_mode = None
          match_threshold = None
          max_num_results = None
          retrieval_type = None
          return_on_failure = None }

type AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptions =
    { cache: Option<AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsCache>
      instance_ids: list<string>
      query_rewrite: Option<AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsQueryrewrite>
      reranking: Option<AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsReranking>
      retrieval: Option<AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptionsRetrieval> }
    ///Creates an instance of AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptions with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (instance_ids: list<string>): AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptions =
        { cache = None
          instance_ids = instance_ids
          query_rewrite = None
          reranking = None
          retrieval = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceSearchPayloadMessagesRole =
    | [<CompiledName "system">] System
    | [<CompiledName "developer">] Developer
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    | [<CompiledName "tool">] Tool
    member this.Format() =
        match this with
        | System -> "system"
        | Developer -> "developer"
        | User -> "user"
        | Assistant -> "assistant"
        | Tool -> "tool"

type AiSearchNamespaceMultiInstanceSearchPayloadMessages =
    { content: string
      role: AiSearchNamespaceMultiInstanceSearchPayloadMessagesRole }
    ///Creates an instance of AiSearchNamespaceMultiInstanceSearchPayloadMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string, role: AiSearchNamespaceMultiInstanceSearchPayloadMessagesRole): AiSearchNamespaceMultiInstanceSearchPayloadMessages =
        { content = content; role = role }

type AiSearchNamespaceMultiInstanceSearchPayload =
    { ai_search_options: AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptions
      messages: Option<list<AiSearchNamespaceMultiInstanceSearchPayloadMessages>>
      ///A simple text query string. Alternative to 'messages' — provide either this or 'messages', not both.
      query: Option<string> }
    ///Creates an instance of AiSearchNamespaceMultiInstanceSearchPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (ai_search_options: AiSearchNamespaceMultiInstanceSearchPayloadAisearchoptions): AiSearchNamespaceMultiInstanceSearchPayload =
        { ai_search_options = ai_search_options
          messages = None
          query = None }

type AiSearchNamespaceMultiInstanceSearch_OKResultChunksItem =
    { key: string
      metadata: Option<obj>
      timestamp: Option<float> }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceSearch_OKResultChunksScoringdetailsFusionmethod =
    | [<CompiledName "rrf">] Rrf
    | [<CompiledName "max">] Max
    member this.Format() =
        match this with
        | Rrf -> "rrf"
        | Max -> "max"

type AiSearchNamespaceMultiInstanceSearch_OKResultChunksScoringdetails =
    { fusion_method: Option<AiSearchNamespaceMultiInstanceSearch_OKResultChunksScoringdetailsFusionmethod>
      keyword_rank: Option<float>
      keyword_score: Option<float>
      reranking_score: Option<float>
      vector_rank: Option<float>
      vector_score: Option<float> }

type AiSearchNamespaceMultiInstanceSearch_OKResultChunks =
    { id: string
      instance_id: string
      item: Option<AiSearchNamespaceMultiInstanceSearch_OKResultChunksItem>
      score: float
      scoring_details: Option<AiSearchNamespaceMultiInstanceSearch_OKResultChunksScoringdetails>
      text: string
      ``type``: string }

type AiSearchNamespaceMultiInstanceSearch_OKResultErrors =
    { instance_id: string
      message: string }

type AiSearchNamespaceMultiInstanceSearch_OKResult =
    { chunks: list<AiSearchNamespaceMultiInstanceSearch_OKResultChunks>
      errors: Option<list<AiSearchNamespaceMultiInstanceSearch_OKResultErrors>>
      search_query: string }

type AiSearchNamespaceMultiInstanceSearch_OK =
    { result: AiSearchNamespaceMultiInstanceSearch_OKResult
      success: bool }

type AiSearchNamespaceMultiInstanceSearch_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchNamespaceMultiInstanceSearch_BadRequest =
    { errors: list<AiSearchNamespaceMultiInstanceSearch_BadRequestErrors>
      success: bool }

type AiSearchNamespaceMultiInstanceSearch_NotFoundErrors = { code: float; message: string }

type AiSearchNamespaceMultiInstanceSearch_NotFound =
    { errors: list<AiSearchNamespaceMultiInstanceSearch_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchNamespaceMultiInstanceSearch =
    ///Returns the merged search results from all instances.
    | OK of payload: AiSearchNamespaceMultiInstanceSearch_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchNamespaceMultiInstanceSearch_BadRequest
    ///Not Found
    | NotFound of payload: AiSearchNamespaceMultiInstanceSearch_NotFound

type AiSearchListTokens_OKResult =
    { cf_api_id: string
      created_at: System.DateTimeOffset
      created_by: Option<string>
      enabled: Option<bool>
      id: System.Guid
      legacy: Option<bool>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      name: string }

type AiSearchListTokens_OKResultinfo =
    { count: float
      page: float
      per_page: float
      total_count: float }

type AiSearchListTokens_OK =
    { result: list<AiSearchListTokens_OKResult>
      result_info: AiSearchListTokens_OKResultinfo
      success: bool }

type AiSearchListTokens_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchListTokens_BadRequest =
    { errors: list<AiSearchListTokens_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchListTokens =
    ///List of tokens.
    | OK of payload: AiSearchListTokens_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchListTokens_BadRequest

type AiSearchCreateTokensPayload =
    { cf_api_id: string
      cf_api_key: string
      legacy: Option<bool>
      name: string }
    ///Creates an instance of AiSearchCreateTokensPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cf_api_id: string, cf_api_key: string, name: string): AiSearchCreateTokensPayload =
        { cf_api_id = cf_api_id
          cf_api_key = cf_api_key
          legacy = None
          name = name }

type AiSearchCreateTokens_CreatedResult =
    { cf_api_id: string
      created_at: System.DateTimeOffset
      created_by: Option<string>
      enabled: Option<bool>
      id: System.Guid
      legacy: Option<bool>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      name: string }

type AiSearchCreateTokens_Created =
    { result: AiSearchCreateTokens_CreatedResult
      success: bool }

type AiSearchCreateTokens_BadRequestErrors = { code: float; message: string }

type AiSearchCreateTokens_BadRequest =
    { errors: list<AiSearchCreateTokens_BadRequestErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchCreateTokens =
    ///Token created.
    | Created of payload: AiSearchCreateTokens_Created
    ///Ai search instance invalid token.
    | BadRequest of payload: AiSearchCreateTokens_BadRequest

type AiSearchDeleteTokens_OK =
    { result: obj
      success: bool }

type AiSearchDeleteTokens_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchDeleteTokens_BadRequest =
    { errors: list<AiSearchDeleteTokens_BadRequestErrors>
      success: bool }

type AiSearchDeleteTokens_NotFoundErrors = { code: float; message: string }

type AiSearchDeleteTokens_NotFound =
    { errors: list<AiSearchDeleteTokens_NotFoundErrors>
      success: bool }

type AiSearchDeleteTokens_ConflictErrors = { code: float; message: string }

type AiSearchDeleteTokens_Conflict =
    { errors: list<AiSearchDeleteTokens_ConflictErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchDeleteTokens =
    ///Token deleted.
    | OK of payload: AiSearchDeleteTokens_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchDeleteTokens_BadRequest
    ///Token not found.
    | NotFound of payload: AiSearchDeleteTokens_NotFound
    ///Token in use by instances.
    | Conflict of payload: AiSearchDeleteTokens_Conflict

type AiSearchFetchTokens_OKResult =
    { cf_api_id: string
      created_at: System.DateTimeOffset
      created_by: Option<string>
      enabled: Option<bool>
      id: System.Guid
      legacy: Option<bool>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      name: string }

type AiSearchFetchTokens_OK =
    { result: AiSearchFetchTokens_OKResult
      success: bool }

type AiSearchFetchTokens_BadRequestErrors =
    { code: float
      message: string
      path: list<string> }

type AiSearchFetchTokens_BadRequest =
    { errors: list<AiSearchFetchTokens_BadRequestErrors>
      success: bool }

type AiSearchFetchTokens_NotFoundErrors = { code: float; message: string }

type AiSearchFetchTokens_NotFound =
    { errors: list<AiSearchFetchTokens_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchFetchTokens =
    ///Token details.
    | OK of payload: AiSearchFetchTokens_OK
    ///Input Validation Error
    | BadRequest of payload: AiSearchFetchTokens_BadRequest
    ///Token not found.
    | NotFound of payload: AiSearchFetchTokens_NotFound

type AiSearchUpdateTokensPayload =
    { cf_api_id: string
      cf_api_key: string
      legacy: Option<bool>
      name: string }
    ///Creates an instance of AiSearchUpdateTokensPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cf_api_id: string, cf_api_key: string, name: string): AiSearchUpdateTokensPayload =
        { cf_api_id = cf_api_id
          cf_api_key = cf_api_key
          legacy = None
          name = name }

type AiSearchUpdateTokens_OKResult =
    { cf_api_id: string
      created_at: System.DateTimeOffset
      created_by: Option<string>
      enabled: Option<bool>
      id: System.Guid
      legacy: Option<bool>
      modified_at: System.DateTimeOffset
      modified_by: Option<string>
      name: string }

type AiSearchUpdateTokens_OK =
    { result: AiSearchUpdateTokens_OKResult
      success: bool }

type AiSearchUpdateTokens_BadRequestErrors = { code: float; message: string }

type AiSearchUpdateTokens_BadRequest =
    { errors: list<AiSearchUpdateTokens_BadRequestErrors>
      success: bool }

type AiSearchUpdateTokens_NotFoundErrors = { code: float; message: string }

type AiSearchUpdateTokens_NotFound =
    { errors: list<AiSearchUpdateTokens_NotFoundErrors>
      success: bool }

[<RequireQualifiedAccess>]
type AiSearchUpdateTokens =
    ///Returns the updated token.
    | OK of payload: AiSearchUpdateTokens_OK
    ///Ai search instance invalid token.
    | BadRequest of payload: AiSearchUpdateTokens_BadRequest
    ///Token not found.
    | NotFound of payload: AiSearchUpdateTokens_NotFound

type WorkersAiSearchAuthor_OK =
    { errors: obj
      messages: list<string>
      result: list<obj>
      success: bool }

type WorkersAiSearchAuthor_BadRequestErrors = { message: string }

type WorkersAiSearchAuthor_BadRequest =
    { errors: list<WorkersAiSearchAuthor_BadRequestErrors>
      result: list<obj>
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiSearchAuthor =
    ///Returns a list of authors
    | OK of payload: WorkersAiSearchAuthor_OK
    ///Bad Request
    | BadRequest of payload: WorkersAiSearchAuthor_BadRequest

type WorkersAiListFinetunes_OKResult =
    { created_at: System.DateTimeOffset
      description: Option<string>
      id: System.Guid
      model: string
      modified_at: System.DateTimeOffset
      name: string }

type WorkersAiListFinetunes_OK =
    { result: WorkersAiListFinetunes_OKResult
      success: bool }

type WorkersAiListFinetunes_BadRequestErrors = { message: string }

type WorkersAiListFinetunes_BadRequest =
    { errors: list<WorkersAiListFinetunes_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiListFinetunes =
    ///Returns all finetunes
    | OK of payload: WorkersAiListFinetunes_OK
    ///Bad Request
    | BadRequest of payload: WorkersAiListFinetunes_BadRequest

type WorkersAiCreateFinetunePayload =
    { description: Option<string>
      model: string
      name: string
      ``public``: Option<bool> }
    ///Creates an instance of WorkersAiCreateFinetunePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (model: string, name: string): WorkersAiCreateFinetunePayload =
        { description = None
          model = model
          name = name
          ``public`` = None }

type WorkersAiCreateFinetune_OKResult =
    { created_at: System.DateTimeOffset
      description: Option<string>
      id: System.Guid
      model: string
      modified_at: System.DateTimeOffset
      name: string
      ``public``: bool }

type WorkersAiCreateFinetune_OK =
    { result: WorkersAiCreateFinetune_OKResult
      success: bool }

type WorkersAiCreateFinetune_BadRequest =
    { errors: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiCreateFinetune =
    ///Returns the created finetune
    | OK of payload: WorkersAiCreateFinetune_OK
    ///Finetune creation failed
    | BadRequest of payload: WorkersAiCreateFinetune_BadRequest

type WorkersAiListPublicFinetunes_OKResult =
    { created_at: System.DateTimeOffset
      description: Option<string>
      id: System.Guid
      model: string
      modified_at: System.DateTimeOffset
      name: string
      ``public``: bool }

type WorkersAiListPublicFinetunes_OK =
    { result: list<WorkersAiListPublicFinetunes_OKResult>
      success: bool }

type WorkersAiListPublicFinetunes_BadRequestErrors = { message: string }

type WorkersAiListPublicFinetunes_BadRequest =
    { errors: list<WorkersAiListPublicFinetunes_BadRequestErrors>
      result: list<obj>
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiListPublicFinetunes =
    ///Returns all public finetunes
    | OK of payload: WorkersAiListPublicFinetunes_OK
    ///Bad Request
    | BadRequest of payload: WorkersAiListPublicFinetunes_BadRequest

type WorkersAiUploadFinetuneAssetPayload =
    { ///File to upload
      file: string
      ///Name of the file (adapter_config.json or adapter_model.safetensors)
      file_name: string }
    ///Creates an instance of WorkersAiUploadFinetuneAssetPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (file: string, file_name: string): WorkersAiUploadFinetuneAssetPayload =
        { file = file; file_name = file_name }

type WorkersAiUploadFinetuneAsset_OK = { success: bool }

type WorkersAiUploadFinetuneAsset_BadRequest =
    { errors: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiUploadFinetuneAsset =
    ///Returns successfully if finetunes were uploaded
    | OK of payload: WorkersAiUploadFinetuneAsset_OK
    ///Finetune creation failed
    | BadRequest of payload: WorkersAiUploadFinetuneAsset_BadRequest

type Input =
    { additionalProperties: bool
      description: string
      ``type``: string }

type Output =
    { additionalProperties: bool
      description: string
      ``type``: string }

type WorkersAiGetModelSchema_OKResult = { input: Input; output: Output }

type WorkersAiGetModelSchema_OK =
    { result: WorkersAiGetModelSchema_OKResult
      success: bool }

type WorkersAiGetModelSchema_BadRequestErrors = { message: string }

type WorkersAiGetModelSchema_BadRequest =
    { errors: list<WorkersAiGetModelSchema_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiGetModelSchema =
    ///Model Schema
    | OK of payload: WorkersAiGetModelSchema_OK
    ///Bad Request
    | BadRequest of payload: WorkersAiGetModelSchema_BadRequest

type WorkersAiSearchModel_OK =
    { errors: obj
      messages: list<string>
      result: list<obj>
      success: bool }

type WorkersAiSearchModel_NotFound =
    { errors: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiSearchModel =
    ///Returns a list of models
    | OK of payload: WorkersAiSearchModel_OK
    ///Object not found
    | NotFound of payload: WorkersAiSearchModel_NotFound

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Targetlanguage =
    | [<CompiledName "asm_Beng">] Asm_Beng
    | [<CompiledName "awa_Deva">] Awa_Deva
    | [<CompiledName "ben_Beng">] Ben_Beng
    | [<CompiledName "bho_Deva">] Bho_Deva
    | [<CompiledName "brx_Deva">] Brx_Deva
    | [<CompiledName "doi_Deva">] Doi_Deva
    | [<CompiledName "eng_Latn">] Eng_Latn
    | [<CompiledName "gom_Deva">] Gom_Deva
    | [<CompiledName "gon_Deva">] Gon_Deva
    | [<CompiledName "guj_Gujr">] Guj_Gujr
    | [<CompiledName "hin_Deva">] Hin_Deva
    | [<CompiledName "hne_Deva">] Hne_Deva
    | [<CompiledName "kan_Knda">] Kan_Knda
    | [<CompiledName "kas_Arab">] Kas_Arab
    | [<CompiledName "kas_Deva">] Kas_Deva
    | [<CompiledName "kha_Latn">] Kha_Latn
    | [<CompiledName "lus_Latn">] Lus_Latn
    | [<CompiledName "mag_Deva">] Mag_Deva
    | [<CompiledName "mai_Deva">] Mai_Deva
    | [<CompiledName "mal_Mlym">] Mal_Mlym
    | [<CompiledName "mar_Deva">] Mar_Deva
    | [<CompiledName "mni_Beng">] Mni_Beng
    | [<CompiledName "mni_Mtei">] Mni_Mtei
    | [<CompiledName "npi_Deva">] Npi_Deva
    | [<CompiledName "ory_Orya">] Ory_Orya
    | [<CompiledName "pan_Guru">] Pan_Guru
    | [<CompiledName "san_Deva">] San_Deva
    | [<CompiledName "sat_Olck">] Sat_Olck
    | [<CompiledName "snd_Arab">] Snd_Arab
    | [<CompiledName "snd_Deva">] Snd_Deva
    | [<CompiledName "tam_Taml">] Tam_Taml
    | [<CompiledName "tel_Telu">] Tel_Telu
    | [<CompiledName "urd_Arab">] Urd_Arab
    | [<CompiledName "unr_Deva">] Unr_Deva
    member this.Format() =
        match this with
        | Asm_Beng -> "asm_Beng"
        | Awa_Deva -> "awa_Deva"
        | Ben_Beng -> "ben_Beng"
        | Bho_Deva -> "bho_Deva"
        | Brx_Deva -> "brx_Deva"
        | Doi_Deva -> "doi_Deva"
        | Eng_Latn -> "eng_Latn"
        | Gom_Deva -> "gom_Deva"
        | Gon_Deva -> "gon_Deva"
        | Guj_Gujr -> "guj_Gujr"
        | Hin_Deva -> "hin_Deva"
        | Hne_Deva -> "hne_Deva"
        | Kan_Knda -> "kan_Knda"
        | Kas_Arab -> "kas_Arab"
        | Kas_Deva -> "kas_Deva"
        | Kha_Latn -> "kha_Latn"
        | Lus_Latn -> "lus_Latn"
        | Mag_Deva -> "mag_Deva"
        | Mai_Deva -> "mai_Deva"
        | Mal_Mlym -> "mal_Mlym"
        | Mar_Deva -> "mar_Deva"
        | Mni_Beng -> "mni_Beng"
        | Mni_Mtei -> "mni_Mtei"
        | Npi_Deva -> "npi_Deva"
        | Ory_Orya -> "ory_Orya"
        | Pan_Guru -> "pan_Guru"
        | San_Deva -> "san_Deva"
        | Sat_Olck -> "sat_Olck"
        | Snd_Arab -> "snd_Arab"
        | Snd_Deva -> "snd_Deva"
        | Tam_Taml -> "tam_Taml"
        | Tel_Telu -> "tel_Telu"
        | Urd_Arab -> "urd_Arab"
        | Unr_Deva -> "unr_Deva"

type WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1BPayload =
    { ///Target langauge to translate to
      target_language: Targetlanguage
      ///Input text to translate. Can be a single string or a list of strings.
      text: obj }
    ///Creates an instance of WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1BPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (target_language: Targetlanguage, text: obj): WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1BPayload =
        { target_language = target_language
          text = text }

type WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1B_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1B_BadRequest =
    { errors: list<WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1B_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1B =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfAi4bharatIndictrans2EnIndic1B_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfAi4bharatNonomniIndictrans2EnIndic1bPayloadTargetlanguage =
    | [<CompiledName "asm_Beng">] Asm_Beng
    | [<CompiledName "awa_Deva">] Awa_Deva
    | [<CompiledName "ben_Beng">] Ben_Beng
    | [<CompiledName "bho_Deva">] Bho_Deva
    | [<CompiledName "brx_Deva">] Brx_Deva
    | [<CompiledName "doi_Deva">] Doi_Deva
    | [<CompiledName "eng_Latn">] Eng_Latn
    | [<CompiledName "gom_Deva">] Gom_Deva
    | [<CompiledName "gon_Deva">] Gon_Deva
    | [<CompiledName "guj_Gujr">] Guj_Gujr
    | [<CompiledName "hin_Deva">] Hin_Deva
    | [<CompiledName "hne_Deva">] Hne_Deva
    | [<CompiledName "kan_Knda">] Kan_Knda
    | [<CompiledName "kas_Arab">] Kas_Arab
    | [<CompiledName "kas_Deva">] Kas_Deva
    | [<CompiledName "kha_Latn">] Kha_Latn
    | [<CompiledName "lus_Latn">] Lus_Latn
    | [<CompiledName "mag_Deva">] Mag_Deva
    | [<CompiledName "mai_Deva">] Mai_Deva
    | [<CompiledName "mal_Mlym">] Mal_Mlym
    | [<CompiledName "mar_Deva">] Mar_Deva
    | [<CompiledName "mni_Beng">] Mni_Beng
    | [<CompiledName "mni_Mtei">] Mni_Mtei
    | [<CompiledName "npi_Deva">] Npi_Deva
    | [<CompiledName "ory_Orya">] Ory_Orya
    | [<CompiledName "pan_Guru">] Pan_Guru
    | [<CompiledName "san_Deva">] San_Deva
    | [<CompiledName "sat_Olck">] Sat_Olck
    | [<CompiledName "snd_Arab">] Snd_Arab
    | [<CompiledName "snd_Deva">] Snd_Deva
    | [<CompiledName "tam_Taml">] Tam_Taml
    | [<CompiledName "tel_Telu">] Tel_Telu
    | [<CompiledName "urd_Arab">] Urd_Arab
    | [<CompiledName "unr_Deva">] Unr_Deva
    member this.Format() =
        match this with
        | Asm_Beng -> "asm_Beng"
        | Awa_Deva -> "awa_Deva"
        | Ben_Beng -> "ben_Beng"
        | Bho_Deva -> "bho_Deva"
        | Brx_Deva -> "brx_Deva"
        | Doi_Deva -> "doi_Deva"
        | Eng_Latn -> "eng_Latn"
        | Gom_Deva -> "gom_Deva"
        | Gon_Deva -> "gon_Deva"
        | Guj_Gujr -> "guj_Gujr"
        | Hin_Deva -> "hin_Deva"
        | Hne_Deva -> "hne_Deva"
        | Kan_Knda -> "kan_Knda"
        | Kas_Arab -> "kas_Arab"
        | Kas_Deva -> "kas_Deva"
        | Kha_Latn -> "kha_Latn"
        | Lus_Latn -> "lus_Latn"
        | Mag_Deva -> "mag_Deva"
        | Mai_Deva -> "mai_Deva"
        | Mal_Mlym -> "mal_Mlym"
        | Mar_Deva -> "mar_Deva"
        | Mni_Beng -> "mni_Beng"
        | Mni_Mtei -> "mni_Mtei"
        | Npi_Deva -> "npi_Deva"
        | Ory_Orya -> "ory_Orya"
        | Pan_Guru -> "pan_Guru"
        | San_Deva -> "san_Deva"
        | Sat_Olck -> "sat_Olck"
        | Snd_Arab -> "snd_Arab"
        | Snd_Deva -> "snd_Deva"
        | Tam_Taml -> "tam_Taml"
        | Tel_Telu -> "tel_Telu"
        | Urd_Arab -> "urd_Arab"
        | Unr_Deva -> "unr_Deva"

type WorkersAiPostRunCfAi4bharatNonomniIndictrans2EnIndic1bPayload =
    { ///Target langauge to translate to
      target_language: WorkersAiPostRunCfAi4bharatNonomniIndictrans2EnIndic1bPayloadTargetlanguage
      ///Input text to translate. Can be a single string or a list of strings.
      text: obj }
    ///Creates an instance of WorkersAiPostRunCfAi4bharatNonomniIndictrans2EnIndic1bPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (target_language: WorkersAiPostRunCfAi4bharatNonomniIndictrans2EnIndic1bPayloadTargetlanguage,
                          text: obj): WorkersAiPostRunCfAi4bharatNonomniIndictrans2EnIndic1bPayload =
        { target_language = target_language
          text = text }

type WorkersAiPostRunCfAi4bharatNonomniIndictrans2EnIndic1b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfAi4bharatNonomniIndictrans2EnIndic1b_BadRequest =
    { errors: list<WorkersAiPostRunCfAi4bharatNonomniIndictrans2EnIndic1b_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfAi4bharatNonomniIndictrans2EnIndic1b =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfAi4bharatNonomniIndictrans2EnIndic1b_BadRequest

type WorkersAiPostRunCfAisingaporeGemmaSeaLionV427bIt_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfAisingaporeGemmaSeaLionV427bIt_BadRequest =
    { errors: list<WorkersAiPostRunCfAisingaporeGemmaSeaLionV427bIt_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfAisingaporeGemmaSeaLionV427bIt =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfAisingaporeGemmaSeaLionV427bIt_BadRequest

type WorkersAiPostRunCfBaaiBgeBaseEnV15_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiBgeBaseEnV15_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiBgeBaseEnV15_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiBgeBaseEnV15 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiBgeBaseEnV15_BadRequest

type WorkersAiPostRunCfBaaiBgeLargeEnV15_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiBgeLargeEnV15_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiBgeLargeEnV15_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiBgeLargeEnV15 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiBgeLargeEnV15_BadRequest

type WorkersAiPostRunCfBaaiBgeM3_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiBgeM3_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiBgeM3_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiBgeM3 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiBgeM3_BadRequest

type Contexts =
    { ///One of the provided context content
      text: Option<string> }
    ///Creates an instance of Contexts with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Contexts = { text = None }

type WorkersAiPostRunCfBaaiBgeRerankerBasePayload =
    { ///List of provided contexts. Note that the index in this array is important, as the response will refer to it.
      contexts: list<Contexts>
      ///A query you wish to perform against the provided contexts.
      query: string
      ///Number of returned results starting with the best score.
      top_k: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfBaaiBgeRerankerBasePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (contexts: list<Contexts>, query: string): WorkersAiPostRunCfBaaiBgeRerankerBasePayload =
        { contexts = contexts
          query = query
          top_k = None }

type WorkersAiPostRunCfBaaiBgeRerankerBase_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiBgeRerankerBase_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiBgeRerankerBase_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiBgeRerankerBase =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiBgeRerankerBase_BadRequest

type WorkersAiPostRunCfBaaiBgeSmallEnV15_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiBgeSmallEnV15_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiBgeSmallEnV15_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiBgeSmallEnV15 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiBgeSmallEnV15_BadRequest

type WorkersAiPostRunCfBaaiNonomniBgeBaseEnV15_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiNonomniBgeBaseEnV15_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiNonomniBgeBaseEnV15_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiNonomniBgeBaseEnV15 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiNonomniBgeBaseEnV15_BadRequest

type WorkersAiPostRunCfBaaiNonomniBgeLargeEnV15_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiNonomniBgeLargeEnV15_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiNonomniBgeLargeEnV15_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiNonomniBgeLargeEnV15 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiNonomniBgeLargeEnV15_BadRequest

type WorkersAiPostRunCfBaaiNonomniBgeM3_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiNonomniBgeM3_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiNonomniBgeM3_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiNonomniBgeM3 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiNonomniBgeM3_BadRequest

type WorkersAiPostRunCfBaaiNonomniBgeSmallEnV15_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBaaiNonomniBgeSmallEnV15_BadRequest =
    { errors: list<WorkersAiPostRunCfBaaiNonomniBgeSmallEnV15_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBaaiNonomniBgeSmallEnV15 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBaaiNonomniBgeSmallEnV15_BadRequest

type WorkersAiPostRunCfBlackForestLabsFlux1SchnellPayload =
    { ///A text description of the image you want to generate.
      prompt: string
      ///The number of diffusion steps; higher values can improve quality but take longer.
      steps: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfBlackForestLabsFlux1SchnellPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfBlackForestLabsFlux1SchnellPayload =
        { prompt = prompt; steps = None }

type WorkersAiPostRunCfBlackForestLabsFlux1Schnell_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBlackForestLabsFlux1Schnell_BadRequest =
    { errors: list<WorkersAiPostRunCfBlackForestLabsFlux1Schnell_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBlackForestLabsFlux1Schnell =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBlackForestLabsFlux1Schnell_BadRequest

type Multipart =
    { body: Option<obj>
      contentType: Option<string> }
    ///Creates an instance of Multipart with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Multipart = { body = None; contentType = None }

type WorkersAiPostRunCfBlackForestLabsFlux2DevPayload =
    { multipart: Multipart }
    ///Creates an instance of WorkersAiPostRunCfBlackForestLabsFlux2DevPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (multipart: Multipart): WorkersAiPostRunCfBlackForestLabsFlux2DevPayload =
        { multipart = multipart }

type WorkersAiPostRunCfBlackForestLabsFlux2Dev_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBlackForestLabsFlux2Dev_BadRequest =
    { errors: list<WorkersAiPostRunCfBlackForestLabsFlux2Dev_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBlackForestLabsFlux2Dev =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBlackForestLabsFlux2Dev_BadRequest

type WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayloadMultipart =
    { body: Option<obj>
      contentType: Option<string> }
    ///Creates an instance of WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayloadMultipart with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayloadMultipart =
        { body = None; contentType = None }

type WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayload =
    { multipart: WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayloadMultipart }
    ///Creates an instance of WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (multipart: WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayloadMultipart): WorkersAiPostRunCfBlackForestLabsFlux2Klein4bPayload =
        { multipart = multipart }

type WorkersAiPostRunCfBlackForestLabsFlux2Klein4b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBlackForestLabsFlux2Klein4b_BadRequest =
    { errors: list<WorkersAiPostRunCfBlackForestLabsFlux2Klein4b_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBlackForestLabsFlux2Klein4b =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBlackForestLabsFlux2Klein4b_BadRequest

type WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayloadMultipart =
    { body: Option<obj>
      contentType: Option<string> }
    ///Creates an instance of WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayloadMultipart with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayloadMultipart =
        { body = None; contentType = None }

type WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayload =
    { multipart: WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayloadMultipart }
    ///Creates an instance of WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (multipart: WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayloadMultipart): WorkersAiPostRunCfBlackForestLabsFlux2Klein9bPayload =
        { multipart = multipart }

type WorkersAiPostRunCfBlackForestLabsFlux2Klein9b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBlackForestLabsFlux2Klein9b_BadRequest =
    { errors: list<WorkersAiPostRunCfBlackForestLabsFlux2Klein9b_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBlackForestLabsFlux2Klein9b =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBlackForestLabsFlux2Klein9b_BadRequest

type WorkersAiPostRunCfBytedanceStableDiffusionXlLightningPayload =
    { ///Controls how closely the generated image should adhere to the prompt; higher values make the image more aligned with the prompt
      guidance: Option<float>
      ///The height of the generated image in pixels
      height: Option<int>
      ///For use with img2img tasks. An array of integers that represent the image data constrained to 8-bit unsigned integer values
      image: Option<list<float>>
      ///For use with img2img tasks. A base64-encoded string of the input image
      image_b64: Option<string>
      ///An array representing An array of integers that represent mask image data for inpainting constrained to 8-bit unsigned integer values
      mask: Option<list<float>>
      ///Text describing elements to avoid in the generated image
      negative_prompt: Option<string>
      ///The number of diffusion steps; higher values can improve quality but take longer
      num_steps: Option<int>
      ///A text description of the image you want to generate
      prompt: string
      ///Random seed for reproducibility of the image generation
      seed: Option<int>
      ///A value between 0 and 1 indicating how strongly to apply the transformation during img2img tasks; lower values make the output closer to the input image
      strength: Option<float>
      ///The width of the generated image in pixels
      width: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfBytedanceStableDiffusionXlLightningPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfBytedanceStableDiffusionXlLightningPayload =
        { guidance = None
          height = None
          image = None
          image_b64 = None
          mask = None
          negative_prompt = None
          num_steps = None
          prompt = prompt
          seed = None
          strength = None
          width = None }

type WorkersAiPostRunCfBytedanceStableDiffusionXlLightning_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfBytedanceStableDiffusionXlLightning_BadRequest =
    { errors: list<WorkersAiPostRunCfBytedanceStableDiffusionXlLightning_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfBytedanceStableDiffusionXlLightning =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfBytedanceStableDiffusionXlLightning_BadRequest

type WorkersAiPostWebsocketRunCfDeepgramAura_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramAura_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramAura_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramAura =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramAura_BadRequest
    | DefaultResponse

type WorkersAiPostWebsocketRunCfDeepgramAura1_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramAura1_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramAura1_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramAura1 =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramAura1_BadRequest
    | DefaultResponse

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Container =
    | [<CompiledName "none">] None
    | [<CompiledName "wav">] Wav
    | [<CompiledName "ogg">] Ogg
    member this.Format() =
        match this with
        | None -> "none"
        | Wav -> "wav"
        | Ogg -> "ogg"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Encoding =
    | [<CompiledName "linear16">] Linear16
    | [<CompiledName "flac">] Flac
    | [<CompiledName "mulaw">] Mulaw
    | [<CompiledName "alaw">] Alaw
    | [<CompiledName "mp3">] Mp3
    | [<CompiledName "opus">] Opus
    | [<CompiledName "aac">] Aac
    member this.Format() =
        match this with
        | Linear16 -> "linear16"
        | Flac -> "flac"
        | Mulaw -> "mulaw"
        | Alaw -> "alaw"
        | Mp3 -> "mp3"
        | Opus -> "opus"
        | Aac -> "aac"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Speaker =
    | [<CompiledName "angus">] Angus
    | [<CompiledName "asteria">] Asteria
    | [<CompiledName "arcas">] Arcas
    | [<CompiledName "orion">] Orion
    | [<CompiledName "orpheus">] Orpheus
    | [<CompiledName "athena">] Athena
    | [<CompiledName "luna">] Luna
    | [<CompiledName "zeus">] Zeus
    | [<CompiledName "perseus">] Perseus
    | [<CompiledName "helios">] Helios
    | [<CompiledName "hera">] Hera
    | [<CompiledName "stella">] Stella
    member this.Format() =
        match this with
        | Angus -> "angus"
        | Asteria -> "asteria"
        | Arcas -> "arcas"
        | Orion -> "orion"
        | Orpheus -> "orpheus"
        | Athena -> "athena"
        | Luna -> "luna"
        | Zeus -> "zeus"
        | Perseus -> "perseus"
        | Helios -> "helios"
        | Hera -> "hera"
        | Stella -> "stella"

type WorkersAiPostRunCfDeepgramAura1Payload =
    { ///The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type.
      bit_rate: Option<float>
      ///Container specifies the file format wrapper for the output audio. The available options depend on the encoding type..
      container: Option<Container>
      ///Encoding of the output audio.
      encoding: Option<Encoding>
      ///Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable
      sample_rate: Option<float>
      ///Speaker used to produce the audio.
      speaker: Option<Speaker>
      ///The text content to be converted to speech
      text: string }
    ///Creates an instance of WorkersAiPostRunCfDeepgramAura1Payload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (text: string): WorkersAiPostRunCfDeepgramAura1Payload =
        { bit_rate = None
          container = None
          encoding = None
          sample_rate = None
          speaker = None
          text = text }

type WorkersAiPostRunCfDeepgramAura1_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfDeepgramAura1_BadRequest =
    { errors: list<WorkersAiPostRunCfDeepgramAura1_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura1 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfDeepgramAura1_BadRequest

type WorkersAiPostWebsocketRunCfDeepgramAura1Internal_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramAura1Internal_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramAura1Internal_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramAura1Internal =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramAura1Internal_BadRequest
    | DefaultResponse

type WorkersAiPostWebsocketRunCfDeepgramAura2_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramAura2_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramAura2_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramAura2 =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramAura2_BadRequest
    | DefaultResponse

type WorkersAiPostWebsocketRunCfDeepgramAura2En_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramAura2En_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramAura2En_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramAura2En =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramAura2En_BadRequest
    | DefaultResponse

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura2EnPayloadContainer =
    | [<CompiledName "none">] None
    | [<CompiledName "wav">] Wav
    | [<CompiledName "ogg">] Ogg
    member this.Format() =
        match this with
        | None -> "none"
        | Wav -> "wav"
        | Ogg -> "ogg"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura2EnPayloadEncoding =
    | [<CompiledName "linear16">] Linear16
    | [<CompiledName "flac">] Flac
    | [<CompiledName "mulaw">] Mulaw
    | [<CompiledName "alaw">] Alaw
    | [<CompiledName "mp3">] Mp3
    | [<CompiledName "opus">] Opus
    | [<CompiledName "aac">] Aac
    member this.Format() =
        match this with
        | Linear16 -> "linear16"
        | Flac -> "flac"
        | Mulaw -> "mulaw"
        | Alaw -> "alaw"
        | Mp3 -> "mp3"
        | Opus -> "opus"
        | Aac -> "aac"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura2EnPayloadSpeaker =
    | [<CompiledName "amalthea">] Amalthea
    | [<CompiledName "andromeda">] Andromeda
    | [<CompiledName "apollo">] Apollo
    | [<CompiledName "arcas">] Arcas
    | [<CompiledName "aries">] Aries
    | [<CompiledName "asteria">] Asteria
    | [<CompiledName "athena">] Athena
    | [<CompiledName "atlas">] Atlas
    | [<CompiledName "aurora">] Aurora
    | [<CompiledName "callista">] Callista
    | [<CompiledName "cora">] Cora
    | [<CompiledName "cordelia">] Cordelia
    | [<CompiledName "delia">] Delia
    | [<CompiledName "draco">] Draco
    | [<CompiledName "electra">] Electra
    | [<CompiledName "harmonia">] Harmonia
    | [<CompiledName "helena">] Helena
    | [<CompiledName "hera">] Hera
    | [<CompiledName "hermes">] Hermes
    | [<CompiledName "hyperion">] Hyperion
    | [<CompiledName "iris">] Iris
    | [<CompiledName "janus">] Janus
    | [<CompiledName "juno">] Juno
    | [<CompiledName "jupiter">] Jupiter
    | [<CompiledName "luna">] Luna
    | [<CompiledName "mars">] Mars
    | [<CompiledName "minerva">] Minerva
    | [<CompiledName "neptune">] Neptune
    | [<CompiledName "odysseus">] Odysseus
    | [<CompiledName "ophelia">] Ophelia
    | [<CompiledName "orion">] Orion
    | [<CompiledName "orpheus">] Orpheus
    | [<CompiledName "pandora">] Pandora
    | [<CompiledName "phoebe">] Phoebe
    | [<CompiledName "pluto">] Pluto
    | [<CompiledName "saturn">] Saturn
    | [<CompiledName "thalia">] Thalia
    | [<CompiledName "theia">] Theia
    | [<CompiledName "vesta">] Vesta
    | [<CompiledName "zeus">] Zeus
    member this.Format() =
        match this with
        | Amalthea -> "amalthea"
        | Andromeda -> "andromeda"
        | Apollo -> "apollo"
        | Arcas -> "arcas"
        | Aries -> "aries"
        | Asteria -> "asteria"
        | Athena -> "athena"
        | Atlas -> "atlas"
        | Aurora -> "aurora"
        | Callista -> "callista"
        | Cora -> "cora"
        | Cordelia -> "cordelia"
        | Delia -> "delia"
        | Draco -> "draco"
        | Electra -> "electra"
        | Harmonia -> "harmonia"
        | Helena -> "helena"
        | Hera -> "hera"
        | Hermes -> "hermes"
        | Hyperion -> "hyperion"
        | Iris -> "iris"
        | Janus -> "janus"
        | Juno -> "juno"
        | Jupiter -> "jupiter"
        | Luna -> "luna"
        | Mars -> "mars"
        | Minerva -> "minerva"
        | Neptune -> "neptune"
        | Odysseus -> "odysseus"
        | Ophelia -> "ophelia"
        | Orion -> "orion"
        | Orpheus -> "orpheus"
        | Pandora -> "pandora"
        | Phoebe -> "phoebe"
        | Pluto -> "pluto"
        | Saturn -> "saturn"
        | Thalia -> "thalia"
        | Theia -> "theia"
        | Vesta -> "vesta"
        | Zeus -> "zeus"

type WorkersAiPostRunCfDeepgramAura2EnPayload =
    { ///The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type.
      bit_rate: Option<float>
      ///Container specifies the file format wrapper for the output audio. The available options depend on the encoding type..
      container: Option<WorkersAiPostRunCfDeepgramAura2EnPayloadContainer>
      ///Encoding of the output audio.
      encoding: Option<WorkersAiPostRunCfDeepgramAura2EnPayloadEncoding>
      ///Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable
      sample_rate: Option<float>
      ///Speaker used to produce the audio.
      speaker: Option<WorkersAiPostRunCfDeepgramAura2EnPayloadSpeaker>
      ///The text content to be converted to speech
      text: string }
    ///Creates an instance of WorkersAiPostRunCfDeepgramAura2EnPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (text: string): WorkersAiPostRunCfDeepgramAura2EnPayload =
        { bit_rate = None
          container = None
          encoding = None
          sample_rate = None
          speaker = None
          text = text }

type WorkersAiPostRunCfDeepgramAura2En_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfDeepgramAura2En_BadRequest =
    { errors: list<WorkersAiPostRunCfDeepgramAura2En_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura2En =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfDeepgramAura2En_BadRequest

type WorkersAiPostWebsocketRunCfDeepgramAura2EnWs_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramAura2EnWs_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramAura2EnWs_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramAura2EnWs =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramAura2EnWs_BadRequest
    | DefaultResponse

type WorkersAiPostWebsocketRunCfDeepgramAura2Es_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramAura2Es_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramAura2Es_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramAura2Es =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramAura2Es_BadRequest
    | DefaultResponse

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura2EsPayloadContainer =
    | [<CompiledName "none">] None
    | [<CompiledName "wav">] Wav
    | [<CompiledName "ogg">] Ogg
    member this.Format() =
        match this with
        | None -> "none"
        | Wav -> "wav"
        | Ogg -> "ogg"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura2EsPayloadEncoding =
    | [<CompiledName "linear16">] Linear16
    | [<CompiledName "flac">] Flac
    | [<CompiledName "mulaw">] Mulaw
    | [<CompiledName "alaw">] Alaw
    | [<CompiledName "mp3">] Mp3
    | [<CompiledName "opus">] Opus
    | [<CompiledName "aac">] Aac
    member this.Format() =
        match this with
        | Linear16 -> "linear16"
        | Flac -> "flac"
        | Mulaw -> "mulaw"
        | Alaw -> "alaw"
        | Mp3 -> "mp3"
        | Opus -> "opus"
        | Aac -> "aac"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura2EsPayloadSpeaker =
    | [<CompiledName "sirio">] Sirio
    | [<CompiledName "nestor">] Nestor
    | [<CompiledName "carina">] Carina
    | [<CompiledName "celeste">] Celeste
    | [<CompiledName "alvaro">] Alvaro
    | [<CompiledName "diana">] Diana
    | [<CompiledName "aquila">] Aquila
    | [<CompiledName "selena">] Selena
    | [<CompiledName "estrella">] Estrella
    | [<CompiledName "javier">] Javier
    member this.Format() =
        match this with
        | Sirio -> "sirio"
        | Nestor -> "nestor"
        | Carina -> "carina"
        | Celeste -> "celeste"
        | Alvaro -> "alvaro"
        | Diana -> "diana"
        | Aquila -> "aquila"
        | Selena -> "selena"
        | Estrella -> "estrella"
        | Javier -> "javier"

type WorkersAiPostRunCfDeepgramAura2EsPayload =
    { ///The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type.
      bit_rate: Option<float>
      ///Container specifies the file format wrapper for the output audio. The available options depend on the encoding type..
      container: Option<WorkersAiPostRunCfDeepgramAura2EsPayloadContainer>
      ///Encoding of the output audio.
      encoding: Option<WorkersAiPostRunCfDeepgramAura2EsPayloadEncoding>
      ///Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable
      sample_rate: Option<float>
      ///Speaker used to produce the audio.
      speaker: Option<WorkersAiPostRunCfDeepgramAura2EsPayloadSpeaker>
      ///The text content to be converted to speech
      text: string }
    ///Creates an instance of WorkersAiPostRunCfDeepgramAura2EsPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (text: string): WorkersAiPostRunCfDeepgramAura2EsPayload =
        { bit_rate = None
          container = None
          encoding = None
          sample_rate = None
          speaker = None
          text = text }

type WorkersAiPostRunCfDeepgramAura2Es_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfDeepgramAura2Es_BadRequest =
    { errors: list<WorkersAiPostRunCfDeepgramAura2Es_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramAura2Es =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfDeepgramAura2Es_BadRequest

type WorkersAiPostWebsocketRunCfDeepgramFlux_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramFlux_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramFlux_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramFlux =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramFlux_BadRequest
    | DefaultResponse

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramFluxPayloadEncoding =
    | [<CompiledName "linear16">] Linear16
    member this.Format() =
        match this with
        | Linear16 -> "linear16"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Mipoptout =
    | [<CompiledName "true">] True
    | [<CompiledName "false">] False
    member this.Format() =
        match this with
        | True -> "true"
        | False -> "false"

type WorkersAiPostRunCfDeepgramFluxPayload =
    { ///End-of-turn confidence required to fire an eager end-of-turn event. When set, enables EagerEndOfTurn and TurnResumed events. Valid Values 0.3 - 0.9.
      eager_eot_threshold: Option<string>
      ///Encoding of the audio stream. Currently only supports raw signed little-endian 16-bit PCM.
      encoding: WorkersAiPostRunCfDeepgramFluxPayloadEncoding
      ///End-of-turn confidence required to finish a turn. Valid Values 0.5 - 0.9.
      eot_threshold: Option<string>
      ///A turn will be finished when this much time has passed after speech, regardless of EOT confidence.
      eot_timeout_ms: Option<string>
      ///Keyterm prompting can improve recognition of specialized terminology. Pass multiple keyterm query parameters to boost multiple keyterms.
      keyterm: Option<string>
      ///Opts out requests from the Deepgram Model Improvement Program. Refer to Deepgram Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip
      mip_opt_out: Option<Mipoptout>
      ///Sample rate of the audio stream in Hz.
      sample_rate: string
      ///Label your requests for the purpose of identification during usage reporting
      tag: Option<string> }
    ///Creates an instance of WorkersAiPostRunCfDeepgramFluxPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (encoding: WorkersAiPostRunCfDeepgramFluxPayloadEncoding, sample_rate: string): WorkersAiPostRunCfDeepgramFluxPayload =
        { eager_eot_threshold = None
          encoding = encoding
          eot_threshold = None
          eot_timeout_ms = None
          keyterm = None
          mip_opt_out = None
          sample_rate = sample_rate
          tag = None }

type WorkersAiPostRunCfDeepgramFlux_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfDeepgramFlux_BadRequest =
    { errors: list<WorkersAiPostRunCfDeepgramFlux_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramFlux =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfDeepgramFlux_BadRequest

type WorkersAiPostWebsocketRunCfDeepgramNova3_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramNova3_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramNova3_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramNova3 =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramNova3_BadRequest
    | DefaultResponse

type Audio =
    { body: obj
      contentType: string }
    ///Creates an instance of Audio with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (body: obj, contentType: string): Audio =
        { body = body
          contentType = contentType }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Customintentmode =
    | [<CompiledName "extended">] Extended
    | [<CompiledName "strict">] Strict
    member this.Format() =
        match this with
        | Extended -> "extended"
        | Strict -> "strict"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Customtopicmode =
    | [<CompiledName "extended">] Extended
    | [<CompiledName "strict">] Strict
    member this.Format() =
        match this with
        | Extended -> "extended"
        | Strict -> "strict"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramNova3PayloadEncoding =
    | [<CompiledName "linear16">] Linear16
    | [<CompiledName "flac">] Flac
    | [<CompiledName "mulaw">] Mulaw
    | [<CompiledName "amr-nb">] AmrNb
    | [<CompiledName "amr-wb">] AmrWb
    | [<CompiledName "opus">] Opus
    | [<CompiledName "speex">] Speex
    | [<CompiledName "g729">] G729
    member this.Format() =
        match this with
        | Linear16 -> "linear16"
        | Flac -> "flac"
        | Mulaw -> "mulaw"
        | AmrNb -> "amr-nb"
        | AmrWb -> "amr-wb"
        | Opus -> "opus"
        | Speex -> "speex"
        | G729 -> "g729"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Mode =
    | [<CompiledName "general">] General
    | [<CompiledName "medical">] Medical
    | [<CompiledName "finance">] Finance
    member this.Format() =
        match this with
        | General -> "general"
        | Medical -> "medical"
        | Finance -> "finance"

type WorkersAiPostRunCfDeepgramNova3Payload =
    { audio: Audio
      ///The number of channels in the submitted audio
      channels: Option<float>
      ///Custom intents you want the model to detect within your input audio if present
      custom_intent: Option<string>
      ///Sets how the model will interpret intents submitted to the custom_intent param. When strict, the model will only return intents submitted using the custom_intent param. When extended, the model will return its own detected intents in addition those submitted using the custom_intents param
      custom_intent_mode: Option<Customintentmode>
      ///Custom topics you want the model to detect within your input audio or text if present Submit up to 100
      custom_topic: Option<string>
      ///Sets how the model will interpret strings submitted to the custom_topic param. When strict, the model will only return topics submitted using the custom_topic param. When extended, the model will return its own detected topics in addition to those submitted using the custom_topic param.
      custom_topic_mode: Option<Customtopicmode>
      ///Identifies and extracts key entities from content in submitted audio
      detect_entities: Option<bool>
      ///Identifies the dominant language spoken in submitted audio
      detect_language: Option<bool>
      ///Recognize speaker changes. Each word in the transcript will be assigned a speaker number starting at 0
      diarize: Option<bool>
      ///Identify and extract key entities from content in submitted audio
      dictation: Option<bool>
      ///Specify the expected encoding of your submitted audio
      encoding: Option<WorkersAiPostRunCfDeepgramNova3PayloadEncoding>
      ///Indicates how long model will wait to detect whether a speaker has finished speaking or pauses for a significant period of time. When set to a value, the streaming endpoint immediately finalizes the transcription for the processed time range and returns the transcript with a speech_final parameter set to true. Can also be set to false to disable endpointing
      endpointing: Option<string>
      ///Arbitrary key-value pairs that are attached to the API response for usage in downstream processing
      extra: Option<string>
      ///Filler Words can help transcribe interruptions in your audio, like 'uh' and 'um'
      filler_words: Option<bool>
      ///Specifies whether the streaming endpoint should provide ongoing transcription updates as more audio is received. When set to true, the endpoint sends continuous updates, meaning transcription results may evolve over time. Note: Supported only for webosockets.
      interim_results: Option<bool>
      ///Key term prompting can boost or suppress specialized terminology and brands.
      keyterm: Option<string>
      ///Keywords can boost or suppress specialized terminology and brands.
      keywords: Option<string>
      ///The BCP-47 language tag that hints at the primary spoken language. Depending on the Model and API endpoint you choose only certain languages are available.
      language: Option<string>
      ///Spoken measurements will be converted to their corresponding abbreviations.
      measurements: Option<bool>
      ///Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip.
      mip_opt_out: Option<bool>
      ///Mode of operation for the model representing broad area of topic that will be talked about in the supplied audio
      mode: Option<Mode>
      ///Transcribe each audio channel independently.
      multichannel: Option<bool>
      ///Numerals converts numbers from written format to numerical format.
      numerals: Option<bool>
      ///Splits audio into paragraphs to improve transcript readability.
      paragraphs: Option<bool>
      ///Profanity Filter looks for recognized profanity and converts it to the nearest recognized non-profane word or removes it from the transcript completely.
      profanity_filter: Option<bool>
      ///Add punctuation and capitalization to the transcript.
      punctuate: Option<bool>
      ///Redaction removes sensitive information from your transcripts.
      redact: Option<string>
      ///Search for terms or phrases in submitted audio and replaces them.
      replace: Option<string>
      ///Search for terms or phrases in submitted audio.
      search: Option<string>
      ///Recognizes the sentiment throughout a transcript or text.
      sentiment: Option<bool>
      ///Apply formatting to transcript output. When set to true, additional formatting will be applied to transcripts to improve readability.
      smart_format: Option<bool>
      ///Detect topics throughout a transcript or text.
      topics: Option<bool>
      ///Seconds to wait before detecting a pause between words in submitted audio.
      utt_split: Option<float>
      ///Indicates how long model will wait to send an UtteranceEnd message after a word has been transcribed. Use with interim_results. Note: Supported only for webosockets.
      utterance_end_ms: Option<bool>
      ///Segments speech into meaningful semantic units.
      utterances: Option<bool>
      ///Indicates that speech has started. You'll begin receiving Speech Started messages upon speech starting. Note: Supported only for webosockets.
      vad_events: Option<bool> }
    ///Creates an instance of WorkersAiPostRunCfDeepgramNova3Payload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (audio: Audio): WorkersAiPostRunCfDeepgramNova3Payload =
        { audio = audio
          channels = None
          custom_intent = None
          custom_intent_mode = None
          custom_topic = None
          custom_topic_mode = None
          detect_entities = None
          detect_language = None
          diarize = None
          dictation = None
          encoding = None
          endpointing = None
          extra = None
          filler_words = None
          interim_results = None
          keyterm = None
          keywords = None
          language = None
          measurements = None
          mip_opt_out = None
          mode = None
          multichannel = None
          numerals = None
          paragraphs = None
          profanity_filter = None
          punctuate = None
          redact = None
          replace = None
          search = None
          sentiment = None
          smart_format = None
          topics = None
          utt_split = None
          utterance_end_ms = None
          utterances = None
          vad_events = None }

type WorkersAiPostRunCfDeepgramNova3_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfDeepgramNova3_BadRequest =
    { errors: list<WorkersAiPostRunCfDeepgramNova3_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepgramNova3 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfDeepgramNova3_BadRequest

type WorkersAiPostWebsocketRunCfDeepgramNova3Internal_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramNova3Internal_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramNova3Internal_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramNova3Internal =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramNova3Internal_BadRequest
    | DefaultResponse

type WorkersAiPostWebsocketRunCfDeepgramNova3Ws_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfDeepgramNova3Ws_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfDeepgramNova3Ws_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfDeepgramNova3Ws =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfDeepgramNova3Ws_BadRequest
    | DefaultResponse

type WorkersAiPostRunCfDeepseekAiDeepseekMath7bInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfDeepseekAiDeepseekMath7bInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfDeepseekAiDeepseekMath7bInstruct_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepseekAiDeepseekMath7bInstruct =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfDeepseekAiDeepseekMath7bInstruct_BadRequest

type WorkersAiPostRunCfDeepseekAiDeepseekR1DistillQwen32b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfDeepseekAiDeepseekR1DistillQwen32b_BadRequest =
    { errors: list<WorkersAiPostRunCfDeepseekAiDeepseekR1DistillQwen32b_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfDeepseekAiDeepseekR1DistillQwen32b =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfDeepseekAiDeepseekR1DistillQwen32b_BadRequest

type WorkersAiPostRunCfDefogSqlcoder7b2_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfDefogSqlcoder7b2_BadRequest =
    { errors: list<WorkersAiPostRunCfDefogSqlcoder7b2_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfDefogSqlcoder7b2 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfDefogSqlcoder7b2_BadRequest

type WorkersAiPostRunCfFacebookBartLargeCnnPayload =
    { ///The text that you want the model to summarize
      input_text: string
      ///The maximum length of the generated summary in tokens
      max_length: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfFacebookBartLargeCnnPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (input_text: string): WorkersAiPostRunCfFacebookBartLargeCnnPayload =
        { input_text = input_text
          max_length = None }

type WorkersAiPostRunCfFacebookBartLargeCnn_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfFacebookBartLargeCnn_BadRequest =
    { errors: list<WorkersAiPostRunCfFacebookBartLargeCnn_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfFacebookBartLargeCnn =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfFacebookBartLargeCnn_BadRequest

type WorkersAiPostRunCfFacebookNonomniBartLargeCnnPayload =
    { ///The text that you want the model to summarize
      input_text: string
      ///The maximum length of the generated summary in tokens
      max_length: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfFacebookNonomniBartLargeCnnPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (input_text: string): WorkersAiPostRunCfFacebookNonomniBartLargeCnnPayload =
        { input_text = input_text
          max_length = None }

type WorkersAiPostRunCfFacebookNonomniBartLargeCnn_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfFacebookNonomniBartLargeCnn_BadRequest =
    { errors: list<WorkersAiPostRunCfFacebookNonomniBartLargeCnn_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfFacebookNonomniBartLargeCnn =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfFacebookNonomniBartLargeCnn_BadRequest

type WorkersAiPostRunCfFacebookNonomniDetrResnet50_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfFacebookNonomniDetrResnet50_BadRequest =
    { errors: list<WorkersAiPostRunCfFacebookNonomniDetrResnet50_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfFacebookNonomniDetrResnet50 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfFacebookNonomniDetrResnet50_BadRequest

type WorkersAiPostRunCfFblgitUnaCybertron7bV2Bf16_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfFblgitUnaCybertron7bV2Bf16_BadRequest =
    { errors: list<WorkersAiPostRunCfFblgitUnaCybertron7bV2Bf16_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfFblgitUnaCybertron7bV2Bf16 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfFblgitUnaCybertron7bV2Bf16_BadRequest

type WorkersAiPostRunCfGoogleEmbeddinggemma300mPayload =
    { text: obj }
    ///Creates an instance of WorkersAiPostRunCfGoogleEmbeddinggemma300mPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (text: obj): WorkersAiPostRunCfGoogleEmbeddinggemma300mPayload =
        { text = text }

type WorkersAiPostRunCfGoogleEmbeddinggemma300m_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfGoogleEmbeddinggemma300m_BadRequest =
    { errors: list<WorkersAiPostRunCfGoogleEmbeddinggemma300m_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfGoogleEmbeddinggemma300m =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfGoogleEmbeddinggemma300m_BadRequest

type WorkersAiPostRunCfGoogleGemma2bItLora_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfGoogleGemma2bItLora_BadRequest =
    { errors: list<WorkersAiPostRunCfGoogleGemma2bItLora_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfGoogleGemma2bItLora =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfGoogleGemma2bItLora_BadRequest

type WorkersAiPostRunCfGoogleGemma312bIt_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfGoogleGemma312bIt_BadRequest =
    { errors: list<WorkersAiPostRunCfGoogleGemma312bIt_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfGoogleGemma312bIt =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfGoogleGemma312bIt_BadRequest

type WorkersAiPostRunCfGoogleGemma426bA4bIt_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfGoogleGemma426bA4bIt_BadRequest =
    { errors: list<WorkersAiPostRunCfGoogleGemma426bA4bIt_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfGoogleGemma426bA4bIt =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfGoogleGemma426bA4bIt_BadRequest

type WorkersAiPostRunCfGoogleGemma7bItLora_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfGoogleGemma7bItLora_BadRequest =
    { errors: list<WorkersAiPostRunCfGoogleGemma7bItLora_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfGoogleGemma7bItLora =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfGoogleGemma7bItLora_BadRequest

type WorkersAiPostRunCfGoogleNonomniEmbeddinggemma300mPayload =
    { ///Input text to embed. Can be a single string or a list of strings.
      text: obj }
    ///Creates an instance of WorkersAiPostRunCfGoogleNonomniEmbeddinggemma300mPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (text: obj): WorkersAiPostRunCfGoogleNonomniEmbeddinggemma300mPayload =
        { text = text }

type WorkersAiPostRunCfGoogleNonomniEmbeddinggemma300m_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfGoogleNonomniEmbeddinggemma300m_BadRequest =
    { errors: list<WorkersAiPostRunCfGoogleNonomniEmbeddinggemma300m_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfGoogleNonomniEmbeddinggemma300m =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfGoogleNonomniEmbeddinggemma300m_BadRequest

type WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8Payload =
    { ///The text that you want to classify
      text: string }
    ///Creates an instance of WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8Payload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (text: string): WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8Payload = { text = text }

type WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8_BadRequest =
    { errors: list<WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfHuggingfaceDistilbertSst2Int8_BadRequest

type WorkersAiPostRunCfHuggingfaceNonomniDistilbertSst2Int8Payload =
    { ///The text that you want to classify
      text: string }
    ///Creates an instance of WorkersAiPostRunCfHuggingfaceNonomniDistilbertSst2Int8Payload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (text: string): WorkersAiPostRunCfHuggingfaceNonomniDistilbertSst2Int8Payload = { text = text }

type WorkersAiPostRunCfHuggingfaceNonomniDistilbertSst2Int8_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfHuggingfaceNonomniDistilbertSst2Int8_BadRequest =
    { errors: list<WorkersAiPostRunCfHuggingfaceNonomniDistilbertSst2Int8_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfHuggingfaceNonomniDistilbertSst2Int8 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfHuggingfaceNonomniDistilbertSst2Int8_BadRequest

type WorkersAiPostRunCfIbmGraniteGranite40HMicro_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfIbmGraniteGranite40HMicro_BadRequest =
    { errors: list<WorkersAiPostRunCfIbmGraniteGranite40HMicro_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfIbmGraniteGranite40HMicro =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfIbmGraniteGranite40HMicro_BadRequest

type WorkersAiPostRunCfLeonardoLucidOriginPayload =
    { ///Controls how closely the generated image should adhere to the prompt; higher values make the image more aligned with the prompt
      guidance: Option<float>
      ///The height of the generated image in pixels
      height: Option<int>
      ///The number of diffusion steps; higher values can improve quality but take longer
      num_steps: Option<int>
      ///A text description of the image you want to generate.
      prompt: string
      ///Random seed for reproducibility of the image generation
      seed: Option<int>
      ///The number of diffusion steps; higher values can improve quality but take longer
      steps: Option<int>
      ///The width of the generated image in pixels
      width: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfLeonardoLucidOriginPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfLeonardoLucidOriginPayload =
        { guidance = None
          height = None
          num_steps = None
          prompt = prompt
          seed = None
          steps = None
          width = None }

type WorkersAiPostRunCfLeonardoLucidOrigin_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfLeonardoLucidOrigin_BadRequest =
    { errors: list<WorkersAiPostRunCfLeonardoLucidOrigin_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfLeonardoLucidOrigin =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfLeonardoLucidOrigin_BadRequest

type WorkersAiPostRunCfLeonardoPhoenix10Payload =
    { ///Controls how closely the generated image should adhere to the prompt; higher values make the image more aligned with the prompt
      guidance: Option<float>
      ///The height of the generated image in pixels
      height: Option<int>
      ///Specify what to exclude from the generated images
      negative_prompt: Option<string>
      ///The number of diffusion steps; higher values can improve quality but take longer
      num_steps: Option<int>
      ///A text description of the image you want to generate.
      prompt: string
      ///Random seed for reproducibility of the image generation
      seed: Option<int>
      ///The width of the generated image in pixels
      width: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfLeonardoPhoenix10Payload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfLeonardoPhoenix10Payload =
        { guidance = None
          height = None
          negative_prompt = None
          num_steps = None
          prompt = prompt
          seed = None
          width = None }

type WorkersAiPostRunCfLeonardoPhoenix10_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfLeonardoPhoenix10_BadRequest =
    { errors: list<WorkersAiPostRunCfLeonardoPhoenix10_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfLeonardoPhoenix10 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfLeonardoPhoenix10_BadRequest

type WorkersAiPostRunCfLykonDreamshaper8LcmPayload =
    { ///Controls how closely the generated image should adhere to the prompt; higher values make the image more aligned with the prompt
      guidance: Option<float>
      ///The height of the generated image in pixels
      height: Option<int>
      ///For use with img2img tasks. An array of integers that represent the image data constrained to 8-bit unsigned integer values
      image: Option<list<float>>
      ///For use with img2img tasks. A base64-encoded string of the input image
      image_b64: Option<string>
      ///An array representing An array of integers that represent mask image data for inpainting constrained to 8-bit unsigned integer values
      mask: Option<list<float>>
      ///Text describing elements to avoid in the generated image
      negative_prompt: Option<string>
      ///The number of diffusion steps; higher values can improve quality but take longer
      num_steps: Option<int>
      ///A text description of the image you want to generate
      prompt: string
      ///Random seed for reproducibility of the image generation
      seed: Option<int>
      ///A value between 0 and 1 indicating how strongly to apply the transformation during img2img tasks; lower values make the output closer to the input image
      strength: Option<float>
      ///The width of the generated image in pixels
      width: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfLykonDreamshaper8LcmPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfLykonDreamshaper8LcmPayload =
        { guidance = None
          height = None
          image = None
          image_b64 = None
          mask = None
          negative_prompt = None
          num_steps = None
          prompt = prompt
          seed = None
          strength = None
          width = None }

type WorkersAiPostRunCfLykonDreamshaper8Lcm_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfLykonDreamshaper8Lcm_BadRequest =
    { errors: list<WorkersAiPostRunCfLykonDreamshaper8Lcm_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfLykonDreamshaper8Lcm =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfLykonDreamshaper8Lcm_BadRequest

type WorkersAiPostRunCfMetaLlamaLlama27bChatHfLora_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlamaLlama27bChatHfLora_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlamaLlama27bChatHfLora_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlamaLlama27bChatHfLora =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlamaLlama27bChatHfLora_BadRequest

type WorkersAiPostRunCfMetaLlama27bChatFp16_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama27bChatFp16_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama27bChatFp16_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama27bChatFp16 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama27bChatFp16_BadRequest

type WorkersAiPostRunCfMetaLlama27bChatInt8_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama27bChatInt8_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama27bChatInt8_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama27bChatInt8 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama27bChatInt8_BadRequest

type WorkersAiPostRunCfMetaLlama38bInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama38bInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama38bInstruct_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama38bInstruct =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama38bInstruct_BadRequest

type WorkersAiPostRunCfMetaLlama38bInstructAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama38bInstructAwq_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama38bInstructAwq_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama38bInstructAwq =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama38bInstructAwq_BadRequest

type WorkersAiPostRunCfMetaLlama3170bInstructFp8Fast_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama3170bInstructFp8Fast_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama3170bInstructFp8Fast_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama3170bInstructFp8Fast =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama3170bInstructFp8Fast_BadRequest

type WorkersAiPostRunCfMetaLlama318bInstructAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama318bInstructAwq_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama318bInstructAwq_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama318bInstructAwq =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama318bInstructAwq_BadRequest

type WorkersAiPostRunCfMetaLlama318bInstructFp8_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama318bInstructFp8_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama318bInstructFp8_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama318bInstructFp8 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama318bInstructFp8_BadRequest

type WorkersAiPostRunCfMetaLlama318bInstructFp8Fast_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama318bInstructFp8Fast_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama318bInstructFp8Fast_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama318bInstructFp8Fast =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama318bInstructFp8Fast_BadRequest

type WorkersAiPostRunCfMetaLlama3211bVisionInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama3211bVisionInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama3211bVisionInstruct_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama3211bVisionInstruct =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama3211bVisionInstruct_BadRequest

type WorkersAiPostRunCfMetaLlama321bInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama321bInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama321bInstruct_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama321bInstruct =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama321bInstruct_BadRequest

type WorkersAiPostRunCfMetaLlama323bInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama323bInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama323bInstruct_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama323bInstruct =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama323bInstruct_BadRequest

type WorkersAiPostRunCfMetaLlama3370bInstructFp8Fast_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama3370bInstructFp8Fast_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama3370bInstructFp8Fast_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama3370bInstructFp8Fast =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama3370bInstructFp8Fast_BadRequest

type WorkersAiPostRunCfMetaLlama4Scout17b16eInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlama4Scout17b16eInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlama4Scout17b16eInstruct_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlama4Scout17b16eInstruct =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlama4Scout17b16eInstruct_BadRequest

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlamaGuard38bPayloadMessagesRole =
    | [<CompiledName "user">] User
    | [<CompiledName "assistant">] Assistant
    member this.Format() =
        match this with
        | User -> "user"
        | Assistant -> "assistant"

type WorkersAiPostRunCfMetaLlamaGuard38bPayloadMessages =
    { ///The content of the message as a string.
      content: string
      ///The role of the message sender must alternate between 'user' and 'assistant'.
      role: WorkersAiPostRunCfMetaLlamaGuard38bPayloadMessagesRole }
    ///Creates an instance of WorkersAiPostRunCfMetaLlamaGuard38bPayloadMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string, role: WorkersAiPostRunCfMetaLlamaGuard38bPayloadMessagesRole): WorkersAiPostRunCfMetaLlamaGuard38bPayloadMessages =
        { content = content; role = role }

///Dictate the output format of the generated response.
type Responseformat =
    { ///Set to json_object to process and output generated text as JSON.
      ``type``: Option<string> }
    ///Creates an instance of Responseformat with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Responseformat = { ``type`` = None }

type WorkersAiPostRunCfMetaLlamaGuard38bPayload =
    { ///The maximum number of tokens to generate in the response.
      max_tokens: Option<int>
      ///An array of message objects representing the conversation history.
      messages: list<WorkersAiPostRunCfMetaLlamaGuard38bPayloadMessages>
      ///Dictate the output format of the generated response.
      response_format: Option<Responseformat>
      ///Controls the randomness of the output; higher values produce more random results.
      temperature: Option<float> }
    ///Creates an instance of WorkersAiPostRunCfMetaLlamaGuard38bPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (messages: list<WorkersAiPostRunCfMetaLlamaGuard38bPayloadMessages>): WorkersAiPostRunCfMetaLlamaGuard38bPayload =
        { max_tokens = None
          messages = messages
          response_format = None
          temperature = None }

type WorkersAiPostRunCfMetaLlamaGuard38b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaLlamaGuard38b_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaLlamaGuard38b_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaLlamaGuard38b =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaLlamaGuard38b_BadRequest

type WorkersAiPostRunCfMetaM2m10012b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMetaM2m10012b_BadRequest =
    { errors: list<WorkersAiPostRunCfMetaM2m10012b_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMetaM2m10012b =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMetaM2m10012b_BadRequest

type WorkersAiPostRunCfMicrosoftNonomniResnet50_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMicrosoftNonomniResnet50_BadRequest =
    { errors: list<WorkersAiPostRunCfMicrosoftNonomniResnet50_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMicrosoftNonomniResnet50 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMicrosoftNonomniResnet50_BadRequest

type WorkersAiPostRunCfMicrosoftPhi2_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMicrosoftPhi2_BadRequest =
    { errors: list<WorkersAiPostRunCfMicrosoftPhi2_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMicrosoftPhi2 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMicrosoftPhi2_BadRequest

type WorkersAiPostRunCfMicrosoftResnet50_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMicrosoftResnet50_BadRequest =
    { errors: list<WorkersAiPostRunCfMicrosoftResnet50_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMicrosoftResnet50 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMicrosoftResnet50_BadRequest

type WorkersAiPostRunCfMistralMistral7bInstructV01_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMistralMistral7bInstructV01_BadRequest =
    { errors: list<WorkersAiPostRunCfMistralMistral7bInstructV01_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMistralMistral7bInstructV01 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMistralMistral7bInstructV01_BadRequest

type WorkersAiPostRunCfMistralMistral7bInstructV02Lora_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMistralMistral7bInstructV02Lora_BadRequest =
    { errors: list<WorkersAiPostRunCfMistralMistral7bInstructV02Lora_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMistralMistral7bInstructV02Lora =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMistralMistral7bInstructV02Lora_BadRequest

type WorkersAiPostRunCfMistralaiMistralSmall3124bInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMistralaiMistralSmall3124bInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfMistralaiMistralSmall3124bInstruct_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMistralaiMistralSmall3124bInstruct =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMistralaiMistralSmall3124bInstruct_BadRequest

type WorkersAiPostRunCfMoonshotaiKimiK25_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMoonshotaiKimiK25_BadRequest =
    { errors: list<WorkersAiPostRunCfMoonshotaiKimiK25_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMoonshotaiKimiK25 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMoonshotaiKimiK25_BadRequest

type WorkersAiPostRunCfMoonshotaiKimiK26_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMoonshotaiKimiK26_BadRequest =
    { errors: list<WorkersAiPostRunCfMoonshotaiKimiK26_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMoonshotaiKimiK26 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMoonshotaiKimiK26_BadRequest

type WorkersAiPostRunCfMyshellAiMelottsPayload =
    { ///The speech language (e.g., 'en' for English, 'fr' for French). Defaults to 'en' if not specified
      lang: Option<string>
      ///A text description of the audio you want to generate
      prompt: string }
    ///Creates an instance of WorkersAiPostRunCfMyshellAiMelottsPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfMyshellAiMelottsPayload = { lang = None; prompt = prompt }

type WorkersAiPostRunCfMyshellAiMelotts_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfMyshellAiMelotts_BadRequest =
    { errors: list<WorkersAiPostRunCfMyshellAiMelotts_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfMyshellAiMelotts =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfMyshellAiMelotts_BadRequest

type WorkersAiPostRunCfNvidiaNemotron3120bA12b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfNvidiaNemotron3120bA12b_BadRequest =
    { errors: list<WorkersAiPostRunCfNvidiaNemotron3120bA12b_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfNvidiaNemotron3120bA12b =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfNvidiaNemotron3120bA12b_BadRequest

type WorkersAiPostRunCfOpenaiGptOss120b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfOpenaiGptOss120b_BadRequest =
    { errors: list<WorkersAiPostRunCfOpenaiGptOss120b_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfOpenaiGptOss120b =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfOpenaiGptOss120b_BadRequest

type WorkersAiPostRunCfOpenaiGptOss20b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfOpenaiGptOss20b_BadRequest =
    { errors: list<WorkersAiPostRunCfOpenaiGptOss20b_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfOpenaiGptOss20b =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfOpenaiGptOss20b_BadRequest

type WorkersAiPostRunCfOpenaiWhisper_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfOpenaiWhisper_BadRequest =
    { errors: list<WorkersAiPostRunCfOpenaiWhisper_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfOpenaiWhisper =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfOpenaiWhisper_BadRequest

type WorkersAiPostRunCfOpenaiWhisperLargeV3TurboPayload =
    { audio: obj
      ///The number of beams to use in beam search decoding. Higher values may improve accuracy at the cost of speed.
      beam_size: Option<int>
      ///Threshold for filtering out segments with high compression ratio, which often indicate repetitive or hallucinated text.
      compression_ratio_threshold: Option<float>
      ///Whether to condition on previous text during transcription. Setting to false may help prevent hallucination loops.
      condition_on_previous_text: Option<bool>
      ///Optional threshold (in seconds) to skip silent periods that may cause hallucinations.
      hallucination_silence_threshold: Option<float>
      ///A text prompt to help provide context to the model on the contents of the audio.
      initial_prompt: Option<string>
      ///The language of the audio being transcribed or translated.
      language: Option<string>
      ///Threshold for filtering out segments with low average log probability, indicating low confidence.
      log_prob_threshold: Option<float>
      ///Threshold for detecting no-speech segments. Segments with no-speech probability above this value are skipped.
      no_speech_threshold: Option<float>
      ///The prefix appended to the beginning of the output of the transcription and can guide the transcription result.
      prefix: Option<string>
      ///Supported tasks are 'translate' or 'transcribe'.
      task: Option<string>
      ///Preprocess the audio with a voice activity detection model.
      vad_filter: Option<bool> }
    ///Creates an instance of WorkersAiPostRunCfOpenaiWhisperLargeV3TurboPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (audio: obj): WorkersAiPostRunCfOpenaiWhisperLargeV3TurboPayload =
        { audio = audio
          beam_size = None
          compression_ratio_threshold = None
          condition_on_previous_text = None
          hallucination_silence_threshold = None
          initial_prompt = None
          language = None
          log_prob_threshold = None
          no_speech_threshold = None
          prefix = None
          task = None
          vad_filter = None }

type WorkersAiPostRunCfOpenaiWhisperLargeV3Turbo_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfOpenaiWhisperLargeV3Turbo_BadRequest =
    { errors: list<WorkersAiPostRunCfOpenaiWhisperLargeV3Turbo_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfOpenaiWhisperLargeV3Turbo =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfOpenaiWhisperLargeV3Turbo_BadRequest

type WorkersAiPostRunCfOpenaiWhisperTinyEn_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfOpenaiWhisperTinyEn_BadRequest =
    { errors: list<WorkersAiPostRunCfOpenaiWhisperTinyEn_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfOpenaiWhisperTinyEn =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfOpenaiWhisperTinyEn_BadRequest

type WorkersAiPostRunCfOpenchatOpenchat350106_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfOpenchatOpenchat350106_BadRequest =
    { errors: list<WorkersAiPostRunCfOpenchatOpenchat350106_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfOpenchatOpenchat350106 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfOpenchatOpenchat350106_BadRequest

type WorkersAiPostRunCfPfnetPlamoEmbedding1bPayload =
    { ///Input text to embed. Can be a single string or a list of strings.
      text: obj }
    ///Creates an instance of WorkersAiPostRunCfPfnetPlamoEmbedding1bPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (text: obj): WorkersAiPostRunCfPfnetPlamoEmbedding1bPayload =
        { text = text }

type WorkersAiPostRunCfPfnetPlamoEmbedding1b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfPfnetPlamoEmbedding1b_BadRequest =
    { errors: list<WorkersAiPostRunCfPfnetPlamoEmbedding1b_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfPfnetPlamoEmbedding1b =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfPfnetPlamoEmbedding1b_BadRequest

type WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV2_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV2_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV2_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV2 =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV2_BadRequest
    | DefaultResponse

type WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV3_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV3_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV3_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV3 =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfPipecatAiSmartTurnV3_BadRequest
    | DefaultResponse

type WorkersAiPostRunCfQwenQwen1505bChat_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfQwenQwen1505bChat_BadRequest =
    { errors: list<WorkersAiPostRunCfQwenQwen1505bChat_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfQwenQwen1505bChat =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfQwenQwen1505bChat_BadRequest

type WorkersAiPostRunCfQwenQwen1518bChat_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfQwenQwen1518bChat_BadRequest =
    { errors: list<WorkersAiPostRunCfQwenQwen1518bChat_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfQwenQwen1518bChat =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfQwenQwen1518bChat_BadRequest

type WorkersAiPostRunCfQwenQwen1514bChatAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfQwenQwen1514bChatAwq_BadRequest =
    { errors: list<WorkersAiPostRunCfQwenQwen1514bChatAwq_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfQwenQwen1514bChatAwq =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfQwenQwen1514bChatAwq_BadRequest

type WorkersAiPostRunCfQwenQwen157bChatAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfQwenQwen157bChatAwq_BadRequest =
    { errors: list<WorkersAiPostRunCfQwenQwen157bChatAwq_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfQwenQwen157bChatAwq =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfQwenQwen157bChatAwq_BadRequest

type WorkersAiPostRunCfQwenQwen25Coder32bInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfQwenQwen25Coder32bInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfQwenQwen25Coder32bInstruct_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfQwenQwen25Coder32bInstruct =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfQwenQwen25Coder32bInstruct_BadRequest

type WorkersAiPostRunCfQwenQwen330bA3bFp8_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfQwenQwen330bA3bFp8_BadRequest =
    { errors: list<WorkersAiPostRunCfQwenQwen330bA3bFp8_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfQwenQwen330bA3bFp8 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfQwenQwen330bA3bFp8_BadRequest

type WorkersAiPostRunCfQwenQwen3Embedding06bPayload =
    { documents: Option<obj>
      ///Optional instruction for the task
      instruction: Option<string>
      queries: Option<obj>
      text: Option<obj> }
    ///Creates an instance of WorkersAiPostRunCfQwenQwen3Embedding06bPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): WorkersAiPostRunCfQwenQwen3Embedding06bPayload =
        { documents = None
          instruction = None
          queries = None
          text = None }

type WorkersAiPostRunCfQwenQwen3Embedding06b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfQwenQwen3Embedding06b_BadRequest =
    { errors: list<WorkersAiPostRunCfQwenQwen3Embedding06b_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfQwenQwen3Embedding06b =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfQwenQwen3Embedding06b_BadRequest

type WorkersAiPostRunCfQwenQwq32b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfQwenQwq32b_BadRequest =
    { errors: list<WorkersAiPostRunCfQwenQwq32b_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfQwenQwq32b =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfQwenQwq32b_BadRequest

type WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2imgPayload =
    { ///Controls how closely the generated image should adhere to the prompt; higher values make the image more aligned with the prompt
      guidance: Option<float>
      ///The height of the generated image in pixels
      height: Option<int>
      ///For use with img2img tasks. An array of integers that represent the image data constrained to 8-bit unsigned integer values
      image: Option<list<float>>
      ///For use with img2img tasks. A base64-encoded string of the input image
      image_b64: Option<string>
      ///An array representing An array of integers that represent mask image data for inpainting constrained to 8-bit unsigned integer values
      mask: Option<list<float>>
      ///Text describing elements to avoid in the generated image
      negative_prompt: Option<string>
      ///The number of diffusion steps; higher values can improve quality but take longer
      num_steps: Option<int>
      ///A text description of the image you want to generate
      prompt: string
      ///Random seed for reproducibility of the image generation
      seed: Option<int>
      ///A value between 0 and 1 indicating how strongly to apply the transformation during img2img tasks; lower values make the output closer to the input image
      strength: Option<float>
      ///The width of the generated image in pixels
      width: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2imgPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2imgPayload =
        { guidance = None
          height = None
          image = None
          image_b64 = None
          mask = None
          negative_prompt = None
          num_steps = None
          prompt = prompt
          seed = None
          strength = None
          width = None }

type WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2img_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2img_BadRequest =
    { errors: list<WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2img_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2img =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfRunwaymlStableDiffusionV15Img2img_BadRequest

type WorkersAiPostRunCfRunwaymlStableDiffusionV15InpaintingPayload =
    { ///Controls how closely the generated image should adhere to the prompt; higher values make the image more aligned with the prompt
      guidance: Option<float>
      ///The height of the generated image in pixels
      height: Option<int>
      ///For use with img2img tasks. An array of integers that represent the image data constrained to 8-bit unsigned integer values
      image: Option<list<float>>
      ///For use with img2img tasks. A base64-encoded string of the input image
      image_b64: Option<string>
      ///An array representing An array of integers that represent mask image data for inpainting constrained to 8-bit unsigned integer values
      mask: Option<list<float>>
      ///Text describing elements to avoid in the generated image
      negative_prompt: Option<string>
      ///The number of diffusion steps; higher values can improve quality but take longer
      num_steps: Option<int>
      ///A text description of the image you want to generate
      prompt: string
      ///Random seed for reproducibility of the image generation
      seed: Option<int>
      ///A value between 0 and 1 indicating how strongly to apply the transformation during img2img tasks; lower values make the output closer to the input image
      strength: Option<float>
      ///The width of the generated image in pixels
      width: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfRunwaymlStableDiffusionV15InpaintingPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfRunwaymlStableDiffusionV15InpaintingPayload =
        { guidance = None
          height = None
          image = None
          image_b64 = None
          mask = None
          negative_prompt = None
          num_steps = None
          prompt = prompt
          seed = None
          strength = None
          width = None }

type WorkersAiPostRunCfRunwaymlStableDiffusionV15Inpainting_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfRunwaymlStableDiffusionV15Inpainting_BadRequest =
    { errors: list<WorkersAiPostRunCfRunwaymlStableDiffusionV15Inpainting_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfRunwaymlStableDiffusionV15Inpainting =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfRunwaymlStableDiffusionV15Inpainting_BadRequest

type WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10Payload =
    { ///Controls how closely the generated image should adhere to the prompt; higher values make the image more aligned with the prompt
      guidance: Option<float>
      ///The height of the generated image in pixels
      height: Option<int>
      ///For use with img2img tasks. An array of integers that represent the image data constrained to 8-bit unsigned integer values
      image: Option<list<float>>
      ///For use with img2img tasks. A base64-encoded string of the input image
      image_b64: Option<string>
      ///An array representing An array of integers that represent mask image data for inpainting constrained to 8-bit unsigned integer values
      mask: Option<list<float>>
      ///Text describing elements to avoid in the generated image
      negative_prompt: Option<string>
      ///The number of diffusion steps; higher values can improve quality but take longer
      num_steps: Option<int>
      ///A text description of the image you want to generate
      prompt: string
      ///Random seed for reproducibility of the image generation
      seed: Option<int>
      ///A value between 0 and 1 indicating how strongly to apply the transformation during img2img tasks; lower values make the output closer to the input image
      strength: Option<float>
      ///The width of the generated image in pixels
      width: Option<int> }
    ///Creates an instance of WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10Payload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (prompt: string): WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10Payload =
        { guidance = None
          height = None
          image = None
          image_b64 = None
          mask = None
          negative_prompt = None
          num_steps = None
          prompt = prompt
          seed = None
          strength = None
          width = None }

type WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10_BadRequest =
    { errors: list<WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfStabilityaiStableDiffusionXlBase10_BadRequest

type WorkersAiPostWebsocketRunCfSvenTestPipeHttp_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfSvenTestPipeHttp_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfSvenTestPipeHttp_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfSvenTestPipeHttp =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfSvenTestPipeHttp_BadRequest
    | DefaultResponse

type WorkersAiPostWebsocketRunCfTestHelloWorldCog_BadRequestErrors = { message: string }

type WorkersAiPostWebsocketRunCfTestHelloWorldCog_BadRequest =
    { errors: list<WorkersAiPostWebsocketRunCfTestHelloWorldCog_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostWebsocketRunCfTestHelloWorldCog =
    ///Bad Request
    | BadRequest of payload: WorkersAiPostWebsocketRunCfTestHelloWorldCog_BadRequest
    | DefaultResponse

type WorkersAiPostRunCfTheblokeDiscolmGerman7bV1Awq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfTheblokeDiscolmGerman7bV1Awq_BadRequest =
    { errors: list<WorkersAiPostRunCfTheblokeDiscolmGerman7bV1Awq_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfTheblokeDiscolmGerman7bV1Awq =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfTheblokeDiscolmGerman7bV1Awq_BadRequest

type WorkersAiPostRunCfTiiuaeFalcon7bInstruct_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfTiiuaeFalcon7bInstruct_BadRequest =
    { errors: list<WorkersAiPostRunCfTiiuaeFalcon7bInstruct_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfTiiuaeFalcon7bInstruct =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfTiiuaeFalcon7bInstruct_BadRequest

type WorkersAiPostRunCfTinyllamaTinyllama11bChatV10_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfTinyllamaTinyllama11bChatV10_BadRequest =
    { errors: list<WorkersAiPostRunCfTinyllamaTinyllama11bChatV10_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfTinyllamaTinyllama11bChatV10 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfTinyllamaTinyllama11bChatV10_BadRequest

type WorkersAiPostRunCfZaiOrgGlm47Flash_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunCfZaiOrgGlm47Flash_BadRequest =
    { errors: list<WorkersAiPostRunCfZaiOrgGlm47Flash_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunCfZaiOrgGlm47Flash =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunCfZaiOrgGlm47Flash_BadRequest

type WorkersAiPostRunHfGoogleGemma7bIt_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfGoogleGemma7bIt_BadRequest =
    { errors: list<WorkersAiPostRunHfGoogleGemma7bIt_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfGoogleGemma7bIt =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfGoogleGemma7bIt_BadRequest

type WorkersAiPostRunHfMistralMistral7bInstructV02_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfMistralMistral7bInstructV02_BadRequest =
    { errors: list<WorkersAiPostRunHfMistralMistral7bInstructV02_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfMistralMistral7bInstructV02 =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfMistralMistral7bInstructV02_BadRequest

type WorkersAiPostRunHfNexusflowStarlingLm7bBeta_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfNexusflowStarlingLm7bBeta_BadRequest =
    { errors: list<WorkersAiPostRunHfNexusflowStarlingLm7bBeta_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfNexusflowStarlingLm7bBeta =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfNexusflowStarlingLm7bBeta_BadRequest

type WorkersAiPostRunHfNousresearchHermes2ProMistral7b_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfNousresearchHermes2ProMistral7b_BadRequest =
    { errors: list<WorkersAiPostRunHfNousresearchHermes2ProMistral7b_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfNousresearchHermes2ProMistral7b =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfNousresearchHermes2ProMistral7b_BadRequest

type WorkersAiPostRunHfTheblokeDeepseekCoder67bBaseAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfTheblokeDeepseekCoder67bBaseAwq_BadRequest =
    { errors: list<WorkersAiPostRunHfTheblokeDeepseekCoder67bBaseAwq_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfTheblokeDeepseekCoder67bBaseAwq =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfTheblokeDeepseekCoder67bBaseAwq_BadRequest

type WorkersAiPostRunHfTheblokeDeepseekCoder67bInstructAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfTheblokeDeepseekCoder67bInstructAwq_BadRequest =
    { errors: list<WorkersAiPostRunHfTheblokeDeepseekCoder67bInstructAwq_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfTheblokeDeepseekCoder67bInstructAwq =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfTheblokeDeepseekCoder67bInstructAwq_BadRequest

type WorkersAiPostRunHfTheblokeLlama213bChatAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfTheblokeLlama213bChatAwq_BadRequest =
    { errors: list<WorkersAiPostRunHfTheblokeLlama213bChatAwq_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfTheblokeLlama213bChatAwq =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfTheblokeLlama213bChatAwq_BadRequest

type WorkersAiPostRunHfTheblokeMistral7bInstructV01Awq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfTheblokeMistral7bInstructV01Awq_BadRequest =
    { errors: list<WorkersAiPostRunHfTheblokeMistral7bInstructV01Awq_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfTheblokeMistral7bInstructV01Awq =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfTheblokeMistral7bInstructV01Awq_BadRequest

type WorkersAiPostRunHfTheblokeNeuralChat7bV31Awq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfTheblokeNeuralChat7bV31Awq_BadRequest =
    { errors: list<WorkersAiPostRunHfTheblokeNeuralChat7bV31Awq_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfTheblokeNeuralChat7bV31Awq =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfTheblokeNeuralChat7bV31Awq_BadRequest

type WorkersAiPostRunHfTheblokeOpenhermes25Mistral7bAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfTheblokeOpenhermes25Mistral7bAwq_BadRequest =
    { errors: list<WorkersAiPostRunHfTheblokeOpenhermes25Mistral7bAwq_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfTheblokeOpenhermes25Mistral7bAwq =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfTheblokeOpenhermes25Mistral7bAwq_BadRequest

type WorkersAiPostRunHfTheblokeZephyr7bBetaAwq_BadRequestErrors = { code: string; message: string }

type WorkersAiPostRunHfTheblokeZephyr7bBetaAwq_BadRequest =
    { errors: list<WorkersAiPostRunHfTheblokeZephyr7bBetaAwq_BadRequestErrors>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunHfTheblokeZephyr7bBetaAwq =
    ///Object with user data.
    | OK of payload: obj
    ///Bad request
    | BadRequest of payload: WorkersAiPostRunHfTheblokeZephyr7bBetaAwq_BadRequest

type WorkersAiPostRunModel_OK =
    { result: Option<obj> }

type WorkersAiPostRunModel_BadRequestErrors = { message: string }

type WorkersAiPostRunModel_BadRequest =
    { errors: list<WorkersAiPostRunModel_BadRequestErrors>
      result: Map<string, obj>
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostRunModel =
    ///Model response
    | OK of payload: WorkersAiPostRunModel_OK
    ///Bad Request
    | BadRequest of payload: WorkersAiPostRunModel_BadRequest

type WorkersAiSearchTask_OK =
    { errors: obj
      messages: list<string>
      result: list<obj>
      success: bool }

type WorkersAiSearchTask_NotFound =
    { errors: obj
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiSearchTask =
    ///Returns a list of tasks
    | OK of payload: WorkersAiSearchTask_OK
    ///Object not found
    | NotFound of payload: WorkersAiSearchTask_NotFound

type WorkersAiPostToMarkdownPayload =
    { files: list<string> }
    ///Creates an instance of WorkersAiPostToMarkdownPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (files: list<string>): WorkersAiPostToMarkdownPayload = { files = files }

type WorkersAiPostToMarkdown_OKResult =
    { data: string
      format: string
      mimeType: string
      name: string
      tokens: string }

type WorkersAiPostToMarkdown_OK =
    { result: list<WorkersAiPostToMarkdown_OKResult>
      success: bool }

type WorkersAiPostToMarkdown_BadRequestErrors = { message: string }

type WorkersAiPostToMarkdown_BadRequest =
    { errors: list<WorkersAiPostToMarkdown_BadRequestErrors>
      result: list<obj>
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiPostToMarkdown =
    ///Model Schema
    | OK of payload: WorkersAiPostToMarkdown_OK
    ///Bad Request
    | BadRequest of payload: WorkersAiPostToMarkdown_BadRequest

type WorkersAiGetToMarkdownSupported_OKResult = { extension: string; mimeType: string }

type WorkersAiGetToMarkdownSupported_OK =
    { result: list<WorkersAiGetToMarkdownSupported_OKResult>
      success: bool }

type WorkersAiGetToMarkdownSupported_BadRequestErrors = { message: string }

type WorkersAiGetToMarkdownSupported_BadRequest =
    { errors: list<WorkersAiGetToMarkdownSupported_BadRequestErrors>
      result: list<obj>
      success: bool }

[<RequireQualifiedAccess>]
type WorkersAiGetToMarkdownSupported =
    ///Successful response
    | OK of payload: WorkersAiGetToMarkdownSupported_OK
    ///Bad Request
    | BadRequest of payload: WorkersAiGetToMarkdownSupported_BadRequest
