namespace rec Fidelity.CloudEdge.Management.VulnScanner.Types

// Auto-generated stub types (missing from Hawaii output)
type results = string

///Identifies the role a request was made with. The credential set governs this role. `owner` is the resource owner, `attacker` attempts to access resources.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``vulnscannerbola-credential-role`` =
    | [<CompiledName "owner">] Owner
    | [<CompiledName "attacker">] Attacker
    member this.Format() =
        match this with
        | Owner -> "owner"
        | Attacker -> "attacker"

///HTTP method.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``vulnscannerbola-method`` =
    | [<CompiledName "GET">] GET
    | [<CompiledName "DELETE">] DELETE
    | [<CompiledName "PATCH">] PATCH
    | [<CompiledName "POST">] POST
    | [<CompiledName "PUT">] PUT
    member this.Format() =
        match this with
        | GET -> "GET"
        | DELETE -> "DELETE"
        | PATCH -> "PATCH"
        | POST -> "POST"
        | PUT -> "PUT"

///Outcome of an assertion. `ok` means the assertion passed, `fail` means the assertion failed, `inconclusive` means the scanner could not evaluate the assertion.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``vulnscannerbola-outcome`` =
    | [<CompiledName "ok">] Ok
    | [<CompiledName "fail">] Fail
    | [<CompiledName "inconclusive">] Inconclusive
    member this.Format() =
        match this with
        | Ok -> "ok"
        | Fail -> "fail"
        | Inconclusive -> "inconclusive"

///A verdict. `ok` means the scan passed, `warning` means the scan detected issues, `inconclusive` means errors prevented the scanner from reaching an accurate verdict.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``vulnscannerbola-verdict`` =
    | [<CompiledName "ok">] Ok
    | [<CompiledName "warning">] Warning
    | [<CompiledName "inconclusive">] Inconclusive
    member this.Format() =
        match this with
        | Ok -> "ok"
        | Warning -> "warning"
        | Inconclusive -> "inconclusive"

///Where the credential is attached in outgoing requests.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``vulnscannercredential-location`` =
    | [<CompiledName "header">] Header
    | [<CompiledName "cookie">] Cookie
    member this.Format() =
        match this with
        | Header -> "header"
        | Cookie -> "cookie"

///Identifier.
type vulnscanneridentifier = string

type Source =
    { pointer: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source = { pointer = None }

type vulnscannermessagesArrayItem =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<Source> }
    ///Creates an instance of vulnscannermessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): vulnscannermessagesArrayItem =
        { code = code
          documentation_url = None
          message = message
          source = None }

type vulnscannermessages = list<vulnscannermessagesArrayItem>

type ErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of ErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ErrorsSource = { pointer = None }

type Errors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<ErrorsSource> }
    ///Creates an instance of Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Errors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type MessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of MessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): MessagesSource = { pointer = None }

type Messages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<MessagesSource> }
    ///Creates an instance of Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Messages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type Resultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float>
      ///The number of total pages in the entire result set.
      total_pages: Option<float> }
    ///Creates an instance of Resultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Resultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None
          total_pages = None }

type ``vulnscannerapi-response-collection`` =
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<Resultinfo> }
    ///Creates an instance of vulnscannerapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vulnscannerapi-response-collection`` =
        { errors = None
          messages = None
          success = None
          result_info = None }

type ``vulnscannerapi-response-commonErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of vulnscannerapi-response-commonErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vulnscannerapi-response-commonErrorsSource`` = { pointer = None }

type ``vulnscannerapi-response-commonErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``vulnscannerapi-response-commonErrorsSource``> }
    ///Creates an instance of vulnscannerapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vulnscannerapi-response-commonErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``vulnscannerapi-response-commonMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of vulnscannerapi-response-commonMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vulnscannerapi-response-commonMessagesSource`` = { pointer = None }

type ``vulnscannerapi-response-commonMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``vulnscannerapi-response-commonMessagesSource``> }
    ///Creates an instance of vulnscannerapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vulnscannerapi-response-commonMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``vulnscannerapi-response-common`` =
    { errors: list<``vulnscannerapi-response-commonErrors``>
      messages: list<``vulnscannerapi-response-commonMessages``>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of vulnscannerapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vulnscannerapi-response-commonErrors``>,
                          messages: list<``vulnscannerapi-response-commonMessages``>,
                          success: bool): ``vulnscannerapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``vulnscannerapi-response-common-failure`` =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of vulnscannerapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): ``vulnscannerapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "http_status_within_range">] Http_status_within_range
    member this.Format() =
        match this with
        | Http_status_within_range -> "http_status_within_range"

///Assert that an HTTP status code is within a range, e.g. to assert success for the 2xx range, or expected failure for the 4xx/5xx range.
type ``vulnscannerbola-assertion-kind`` =
    { ///Range of HTTP status codes.
      parameters: ``vulnscannerbola-http-status-range``
      ``type``: Type }
    ///Creates an instance of vulnscannerbola-assertion-kind with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (parameters: ``vulnscannerbola-http-status-range``, ``type``: Type): ``vulnscannerbola-assertion-kind`` =
        { parameters = parameters
          ``type`` = ``type`` }

///Credential set references for a BOLA scan. The scanner uses the
///`owner` credentials for legitimate requests and the `attacker`
///credentials to attempt unauthorized access.
type ``vulnscannerbola-credential-sets`` =
    { ///Credential set ID for the attacker.
      attacker: System.Guid
      ///Credential set ID for the resource owner.
      owner: System.Guid }
    ///Creates an instance of vulnscannerbola-credential-sets with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (attacker: System.Guid, owner: System.Guid): ``vulnscannerbola-credential-sets`` =
        { attacker = attacker; owner = owner }

///Range of HTTP status codes.
type ``vulnscannerbola-http-status-range`` =
    { ///Maximum (inclusive) status code of the range.
      max: int
      ///Minimum (inclusive) status code of the range.
      min: int }
    ///Creates an instance of vulnscannerbola-http-status-range with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (max: int, min: int): ``vulnscannerbola-http-status-range`` = { max = max; min = min }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Reportschemaversion =
    | [<CompiledName "v1">] V1
    member this.Format() =
        match this with
        | V1 -> "v1"

///A BOLA vulnerability scan report, versioned for future evolution.
type ``vulnscannerbola-report`` =
    { report: Newtonsoft.Json.Linq.JToken
      ///Version of the report schema.
      report_schema_version: Reportschemaversion }
    ///Creates an instance of vulnscannerbola-report with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (report: Newtonsoft.Json.Linq.JToken, report_schema_version: Reportschemaversion): ``vulnscannerbola-report`` =
        { report = report
          report_schema_version = report_schema_version }

///Overall report summary.
type ``vulnscannerbola-report-summary`` =
    { ///Overall verdict of the vulnerability scan.
      verdict: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of vulnscannerbola-report-summary with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (verdict: Newtonsoft.Json.Linq.JToken): ``vulnscannerbola-report-summary`` =
        { verdict = verdict }

///Version 1 of the BOLA vulnerability scan report.
type ``vulnscannerbola-report-v1`` =
    { ///Summary of all steps and findings.
      summary: Newtonsoft.Json.Linq.JToken
      ///List of tests that were run.
      tests: list<``vulnscannerbola-test``> }
    ///Creates an instance of vulnscannerbola-report-v1 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (summary: Newtonsoft.Json.Linq.JToken, tests: list<``vulnscannerbola-test``>): ``vulnscannerbola-report-v1`` =
        { summary = summary; tests = tests }

///Result of a single test.
type ``vulnscannerbola-test`` =
    { ///Errors that prevented step execution.
      preflight_errors: Option<list<``vulnscannerbola-test-error``>>
      ///Steps that were executed.
      steps: list<``vulnscannerbola-test-step``>
      ///Verdict of this single test.
      verdict: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of vulnscannerbola-test with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (steps: list<``vulnscannerbola-test-step``>, verdict: Newtonsoft.Json.Linq.JToken): ``vulnscannerbola-test`` =
        { preflight_errors = None
          steps = steps
          verdict = verdict }

///Assertion that was made against the received response.
type ``vulnscannerbola-test-assertion`` =
    { ///Human-readable description of the assertion, explaining what was checked.
      description: string
      ///Kind of assertion.
      kind: Newtonsoft.Json.Linq.JToken
      ///Observed value on which the assertion was made.
      observed: int
      ///Outcome of the assertion.
      outcome: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of vulnscannerbola-test-assertion with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (description: string,
                          kind: Newtonsoft.Json.Linq.JToken,
                          observed: int,
                          outcome: Newtonsoft.Json.Linq.JToken): ``vulnscannerbola-test-assertion`` =
        { description = description
          kind = kind
          observed = observed
          outcome = outcome }

///Credential set that was used.
type ``vulnscannerbola-test-credential-set`` =
    { ///ID of the credential set.
      id: System.Guid
      ///Role of the credential set.
      role: Newtonsoft.Json.Linq.JToken }
    ///Creates an instance of vulnscannerbola-test-credential-set with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: System.Guid, role: Newtonsoft.Json.Linq.JToken): ``vulnscannerbola-test-credential-set`` =
        { id = id; role = role }

///Error that occurred during a test.
type ``vulnscannerbola-test-error`` =
    { ///Human-readable error description.
      description: string
      ///Numeric error code identifying the class of error, if available.
      error_code: Option<int> }
    ///Creates an instance of vulnscannerbola-test-error with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (description: string): ``vulnscannerbola-test-error`` =
        { description = description
          error_code = None }

///HTTP request that was made.
type ``vulnscannerbola-test-request`` =
    { ///Request body, if any.
      body: Option<Newtonsoft.Json.Linq.JObject>
      ///Credential set that was used.
      credential_set: Newtonsoft.Json.Linq.JToken
      ///Names of headers that were sent.
      header_names: list<string>
      ///HTTP method.
      method: Newtonsoft.Json.Linq.JToken
      ///Exact and full URL (including host, query parameters) that was requested.
      url: string
      ///Variable captures requested for this step.
      variable_captures: list<``vulnscannerbola-variable-capture``> }
    ///Creates an instance of vulnscannerbola-test-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (credential_set: Newtonsoft.Json.Linq.JToken,
                          header_names: list<string>,
                          method: Newtonsoft.Json.Linq.JToken,
                          url: string,
                          variable_captures: list<``vulnscannerbola-variable-capture``>): ``vulnscannerbola-test-request`` =
        { body = None
          credential_set = credential_set
          header_names = header_names
          method = method
          url = url
          variable_captures = variable_captures }

///HTTP response that was received.
type ``vulnscannerbola-test-response`` =
    { ///HTTP response body.
      body: Newtonsoft.Json.Linq.JToken
      ///Names of headers that were received.
      header_names: list<string>
      ///HTTP status code.
      status: int
      ///HTTP status text, if available for the status code.
      status_text: Option<string> }
    ///Creates an instance of vulnscannerbola-test-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (body: Newtonsoft.Json.Linq.JToken, header_names: list<string>, status: int): ``vulnscannerbola-test-response`` =
        { body = body
          header_names = header_names
          status = status
          status_text = None }

///HTTP request that was made, if any.
type Request =
    { ///Request body, if any.
      body: Option<Newtonsoft.Json.Linq.JObject>
      ///Credential set that was used.
      credential_set: Option<Newtonsoft.Json.Linq.JToken>
      ///Names of headers that were sent.
      header_names: Option<list<string>>
      ///HTTP method.
      method: Option<Newtonsoft.Json.Linq.JToken>
      ///Exact and full URL (including host, query parameters) that was requested.
      url: Option<string>
      ///Variable captures requested for this step.
      variable_captures: Option<list<``vulnscannerbola-variable-capture``>> }
    ///Creates an instance of Request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Request =
        { body = None
          credential_set = None
          header_names = None
          method = None
          url = None
          variable_captures = None }

///HTTP response that was received, if any.
type Response =
    { ///HTTP response body.
      body: Option<Newtonsoft.Json.Linq.JToken>
      ///Names of headers that were received.
      header_names: Option<list<string>>
      ///HTTP status code.
      status: Option<int>
      ///HTTP status text, if available for the status code.
      status_text: Option<string> }
    ///Creates an instance of Response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Response =
        { body = None
          header_names = None
          status = None
          status_text = None }

///A single step in a test.
type ``vulnscannerbola-test-step`` =
    { ///Assertions that were made against the received response.
      assertions: list<``vulnscannerbola-test-assertion``>
      ///Errors the step encountered that may explain absent or incomplete fields.
      errors: Option<list<``vulnscannerbola-test-error``>>
      ///HTTP request that was made, if any.
      request: Option<Request>
      ///HTTP response that was received, if any.
      response: Option<Response> }
    ///Creates an instance of vulnscannerbola-test-step with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (assertions: list<``vulnscannerbola-test-assertion``>): ``vulnscannerbola-test-step`` =
        { assertions = assertions
          errors = None
          request = None
          response = None }

///A variable to capture from the response body.
type ``vulnscannerbola-variable-capture`` =
    { ///JSONPath expression used for capture, e.g. `"$.id"`.
      json_path: string
      ///Variable name, e.g. `"resource_id"`.
      name: string }
    ///Creates an instance of vulnscannerbola-variable-capture with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (json_path: string, name: string): ``vulnscannerbola-variable-capture`` =
        { json_path = json_path; name = name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Scantype =
    | [<CompiledName "bola">] Bola
    member this.Format() =
        match this with
        | Bola -> "bola"

type ``vulnscannercreate-bola-scan-request`` =
    { ///Credential set references for a BOLA scan. The scanner uses the
      ///`owner` credentials for legitimate requests and the `attacker`
      ///credentials to attempt unauthorized access.
      credential_sets: ``vulnscannerbola-credential-sets``
      ///OpenAPI schema definition for the API under test. The scanner
      ///uses this to discover endpoints and construct requests.
      open_api: string
      scan_type: Scantype
      ///The target environment to scan.
      target_environment_id: System.Guid }
    ///Creates an instance of vulnscannercreate-bola-scan-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (credential_sets: ``vulnscannerbola-credential-sets``,
                          open_api: string,
                          scan_type: Scantype,
                          target_environment_id: System.Guid): ``vulnscannercreate-bola-scan-request`` =
        { credential_sets = credential_sets
          open_api = open_api
          scan_type = scan_type
          target_environment_id = target_environment_id }

type ``vulnscannercreate-credential-request`` =
    { ///Where the credential is attached in outgoing requests.
      location: ``vulnscannercredential-location``
      ///Name of the header or cookie where the credential is attached.
      location_name: string
      ///Human-readable name.
      name: string
      ///The credential value (e.g. API key, session token). Write-only.
      ///Never returned in responses.
      value: string }
    ///Creates an instance of vulnscannercreate-credential-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (location: ``vulnscannercredential-location``,
                          location_name: string,
                          name: string,
                          value: string): ``vulnscannercreate-credential-request`` =
        { location = location
          location_name = location_name
          name = name
          value = value }

type ``vulnscannercreate-credential-set-request`` =
    { ///Human-readable name.
      name: string }
    ///Creates an instance of vulnscannercreate-credential-set-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string): ``vulnscannercreate-credential-set-request`` = { name = name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``vulnscannercreate-scan-requestScantype`` =
    | [<CompiledName "bola">] Bola
    member this.Format() =
        match this with
        | Bola -> "bola"

type ``vulnscannercreate-scan-request`` =
    { ///Credential set references for a BOLA scan. The scanner uses the
      ///`owner` credentials for legitimate requests and the `attacker`
      ///credentials to attempt unauthorized access.
      credential_sets: ``vulnscannerbola-credential-sets``
      ///OpenAPI schema definition for the API under test. The scanner
      ///uses this to discover endpoints and construct requests.
      open_api: string
      scan_type: ``vulnscannercreate-scan-requestScantype``
      ///The target environment to scan.
      target_environment_id: System.Guid }
    ///Creates an instance of vulnscannercreate-scan-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (credential_sets: ``vulnscannerbola-credential-sets``,
                          open_api: string,
                          scan_type: ``vulnscannercreate-scan-requestScantype``,
                          target_environment_id: System.Guid): ``vulnscannercreate-scan-request`` =
        { credential_sets = credential_sets
          open_api = open_api
          scan_type = scan_type
          target_environment_id = target_environment_id }

type ``vulnscannercreate-target-environment-request`` =
    { ///Optional description.
      description: Option<string>
      ///Human-readable name.
      name: string
      target: ``vulnscannerzone-target`` }
    ///Creates an instance of vulnscannercreate-target-environment-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string, target: ``vulnscannerzone-target``): ``vulnscannercreate-target-environment-request`` =
        { description = None
          name = name
          target = target }

///A credential attached to API requests during scanning. The
///credential `value` is write-only and never returned in responses.
type vulnscannercredential =
    { ///Parent credential set identifier.
      credential_set_id: System.Guid
      ///Credential identifier.
      id: System.Guid
      ///Where the credential is attached in outgoing requests.
      location: ``vulnscannercredential-location``
      ///Name of the header or cookie where the credential is attached.
      location_name: string
      ///Human-readable name.
      name: string }
    ///Creates an instance of vulnscannercredential with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (credential_set_id: System.Guid,
                          id: System.Guid,
                          location: ``vulnscannercredential-location``,
                          location_name: string,
                          name: string): vulnscannercredential =
        { credential_set_id = credential_set_id
          id = id
          location = location
          location_name = location_name
          name = name }

type ``vulnscannercredential-set`` =
    { ///Credential set identifier.
      id: System.Guid
      ///Human-readable name.
      name: string }
    ///Creates an instance of vulnscannercredential-set with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: System.Guid, name: string): ``vulnscannercredential-set`` = { id = id; name = name }

type ``vulnscannerempty-responseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of vulnscannerempty-responseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vulnscannerempty-responseErrorsSource`` = { pointer = None }

type ``vulnscannerempty-responseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``vulnscannerempty-responseErrorsSource``> }
    ///Creates an instance of vulnscannerempty-responseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vulnscannerempty-responseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``vulnscannerempty-responseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of vulnscannerempty-responseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vulnscannerempty-responseMessagesSource`` = { pointer = None }

type ``vulnscannerempty-responseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``vulnscannerempty-responseMessagesSource``> }
    ///Creates an instance of vulnscannerempty-responseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``vulnscannerempty-responseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``vulnscannerempty-response`` =
    { errors: list<``vulnscannerempty-responseErrors``>
      messages: list<``vulnscannerempty-responseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<Newtonsoft.Json.Linq.JObject>
      result_info: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of vulnscannerempty-response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``vulnscannerempty-responseErrors``>,
                          messages: list<``vulnscannerempty-responseMessages``>,
                          success: bool): ``vulnscannerempty-response`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

///Applies a partial update. Only the provided fields change; omitted fields remain unchanged.
type ``vulnscannerpatch-credential-request`` =
    { ///Where the credential is attached in outgoing requests.
      location: Option<``vulnscannercredential-location``>
      ///Name of the header or cookie where the credential is attached.
      location_name: Option<string>
      ///Human-readable name.
      name: Option<string>
      ///The credential value. Write-only. Never returned in responses.
      value: Option<string> }
    ///Creates an instance of vulnscannerpatch-credential-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vulnscannerpatch-credential-request`` =
        { location = None
          location_name = None
          name = None
          value = None }

///Applies a partial update. Only the provided fields change; omitted fields remain unchanged.
type ``vulnscannerpatch-credential-set-request`` =
    { ///Human-readable name.
      name: Option<string> }
    ///Creates an instance of vulnscannerpatch-credential-set-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vulnscannerpatch-credential-set-request`` = { name = None }

///Applies a partial update. Only the provided fields change; omitted fields remain unchanged.
///The `description` field supports three states:
///- **omitted**: leave unchanged
///- **`null`**: clear the description
///- **`"value"`**: set to the given string
type ``vulnscannerpatch-target-environment-request`` =
    { ///Optional description. Omit to leave unchanged, set to `null`
      ///to clear, or provide a string to update.
      description: Option<string>
      ///Human-readable name.
      name: Option<string>
      target: Option<``vulnscannerzone-target``> }
    ///Creates an instance of vulnscannerpatch-target-environment-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``vulnscannerpatch-target-environment-request`` =
        { description = None
          name = None
          target = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ReportReportschemaversion =
    | [<CompiledName "v1">] V1
    member this.Format() =
        match this with
        | V1 -> "v1"

///Vulnerability report produced after the scan completes. The shape depends on the scan type. Present only for finished scans.
type Report =
    { report: Option<Newtonsoft.Json.Linq.JToken>
      ///Version of the report schema.
      report_schema_version: Option<ReportReportschemaversion> }
    ///Creates an instance of Report with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Report =
        { report = None
          report_schema_version = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type vulnscannerscanScantype =
    | [<CompiledName "bola">] Bola
    member this.Format() =
        match this with
        | Bola -> "bola"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Status =
    | [<CompiledName "created">] Created
    | [<CompiledName "scheduled">] Scheduled
    | [<CompiledName "planning">] Planning
    | [<CompiledName "running">] Running
    | [<CompiledName "finished">] Finished
    | [<CompiledName "failed">] Failed
    member this.Format() =
        match this with
        | Created -> "created"
        | Scheduled -> "scheduled"
        | Planning -> "planning"
        | Running -> "running"
        | Finished -> "finished"
        | Failed -> "failed"

type vulnscannerscan =
    { ///Scan identifier.
      id: System.Guid
      ///Vulnerability report produced after the scan completes. The shape depends on the scan type. Present only for finished scans.
      report: Option<Report>
      ///The type of vulnerability scan.
      scan_type: vulnscannerscanScantype
      ///Current lifecycle status of the scan.
      status: Status
      ///The target environment this scan runs against.
      target_environment_id: System.Guid }
    ///Creates an instance of vulnscannerscan with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: System.Guid,
                          scan_type: vulnscannerscanScantype,
                          status: Status,
                          target_environment_id: System.Guid): vulnscannerscan =
        { id = id
          report = None
          scan_type = scan_type
          status = status
          target_environment_id = target_environment_id }

type ``vulnscannertarget-environment`` =
    { ///Optional description providing additional context.
      description: Option<string>
      ///Target environment identifier.
      id: System.Guid
      ///Human-readable name.
      name: string
      target: ``vulnscannerzone-target`` }
    ///Creates an instance of vulnscannertarget-environment with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: System.Guid, name: string, target: ``vulnscannerzone-target``): ``vulnscannertarget-environment`` =
        { description = None
          id = id
          name = name
          target = target }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``vulnscannertarget-typeType`` =
    | [<CompiledName "zone">] Zone
    member this.Format() =
        match this with
        | Zone -> "zone"

type ``vulnscannertarget-type`` =
    { ``type``: ``vulnscannertarget-typeType``
      ///Cloudflare zone tag. The zone must belong to the account.
      zone_tag: string }
    ///Creates an instance of vulnscannertarget-type with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: ``vulnscannertarget-typeType``, zone_tag: string): ``vulnscannertarget-type`` =
        { ``type`` = ``type``
          zone_tag = zone_tag }

///Full replacement. Provide all fields.
type ``vulnscannerupdate-credential-request`` =
    { ///Where the credential is attached in outgoing requests.
      location: ``vulnscannercredential-location``
      ///Name of the header or cookie where the credential is attached.
      location_name: string
      ///Human-readable name.
      name: string
      ///The credential value. Write-only. Never returned in responses.
      value: string }
    ///Creates an instance of vulnscannerupdate-credential-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (location: ``vulnscannercredential-location``,
                          location_name: string,
                          name: string,
                          value: string): ``vulnscannerupdate-credential-request`` =
        { location = location
          location_name = location_name
          name = name
          value = value }

///Full replacement. Provide all fields.
type ``vulnscannerupdate-credential-set-request`` =
    { ///Human-readable name.
      name: string }
    ///Creates an instance of vulnscannerupdate-credential-set-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string): ``vulnscannerupdate-credential-set-request`` = { name = name }

///Full replacement.
type ``vulnscannerupdate-target-environment-request`` =
    { ///Optional description.
      description: Option<string>
      ///Human-readable name.
      name: string
      target: ``vulnscannerzone-target`` }
    ///Creates an instance of vulnscannerupdate-target-environment-request with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string, target: ``vulnscannerzone-target``): ``vulnscannerupdate-target-environment-request`` =
        { description = None
          name = name
          target = target }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``vulnscannerzone-targetType`` =
    | [<CompiledName "zone">] Zone
    member this.Format() =
        match this with
        | Zone -> "zone"

type ``vulnscannerzone-target`` =
    { ``type``: ``vulnscannerzone-targetType``
      ///Cloudflare zone tag. The zone must belong to the account.
      zone_tag: string }
    ///Creates an instance of vulnscannerzone-target with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: ``vulnscannerzone-targetType``, zone_tag: string): ``vulnscannerzone-target`` =
        { ``type`` = ``type``
          zone_tag = zone_tag }

type ``list-credential-setsresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of list-credential-setsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``list-credential-setsresponseErrorsSource`` = { pointer = None }

type ``list-credential-setsresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``list-credential-setsresponseErrorsSource``> }
    ///Creates an instance of list-credential-setsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``list-credential-setsresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``list-credential-setsresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of list-credential-setsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``list-credential-setsresponseMessagesSource`` = { pointer = None }

type ``list-credential-setsresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``list-credential-setsresponseMessagesSource``> }
    ///Creates an instance of list-credential-setsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``list-credential-setsresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``list-credential-setsresponseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float>
      ///The number of total pages in the entire result set.
      total_pages: Option<float> }
    ///Creates an instance of list-credential-setsresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``list-credential-setsresponseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None
          total_pages = None }

type ``list-credential-setsresponse`` =
    { errors: list<``list-credential-setsresponseErrors``>
      messages: list<``list-credential-setsresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``list-credential-setsresponseResultinfo``>
      result: Option<list<``vulnscannercredential-set``>> }
    ///Creates an instance of list-credential-setsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``list-credential-setsresponseErrors``>,
                          messages: list<``list-credential-setsresponseMessages``>,
                          success: bool): ``list-credential-setsresponse`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``create-credential-setresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of create-credential-setresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``create-credential-setresponseErrorsSource`` = { pointer = None }

type ``create-credential-setresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``create-credential-setresponseErrorsSource``> }
    ///Creates an instance of create-credential-setresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``create-credential-setresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``create-credential-setresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of create-credential-setresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``create-credential-setresponseMessagesSource`` = { pointer = None }

type ``create-credential-setresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``create-credential-setresponseMessagesSource``> }
    ///Creates an instance of create-credential-setresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``create-credential-setresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``create-credential-setresponse`` =
    { errors: list<``create-credential-setresponseErrors``>
      messages: list<``create-credential-setresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``vulnscannercredential-set``>
      result_info: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of create-credential-setresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``create-credential-setresponseErrors``>,
                          messages: list<``create-credential-setresponseMessages``>,
                          success: bool): ``create-credential-setresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

type ``get-credential-setresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of get-credential-setresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``get-credential-setresponseErrorsSource`` = { pointer = None }

type ``get-credential-setresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``get-credential-setresponseErrorsSource``> }
    ///Creates an instance of get-credential-setresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``get-credential-setresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``get-credential-setresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of get-credential-setresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``get-credential-setresponseMessagesSource`` = { pointer = None }

type ``get-credential-setresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``get-credential-setresponseMessagesSource``> }
    ///Creates an instance of get-credential-setresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``get-credential-setresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``get-credential-setresponse`` =
    { errors: list<``get-credential-setresponseErrors``>
      messages: list<``get-credential-setresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``vulnscannercredential-set``>
      result_info: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of get-credential-setresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``get-credential-setresponseErrors``>,
                          messages: list<``get-credential-setresponseMessages``>,
                          success: bool): ``get-credential-setresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

type ``edit-credential-setresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of edit-credential-setresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``edit-credential-setresponseErrorsSource`` = { pointer = None }

type ``edit-credential-setresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``edit-credential-setresponseErrorsSource``> }
    ///Creates an instance of edit-credential-setresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``edit-credential-setresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``edit-credential-setresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of edit-credential-setresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``edit-credential-setresponseMessagesSource`` = { pointer = None }

type ``edit-credential-setresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``edit-credential-setresponseMessagesSource``> }
    ///Creates an instance of edit-credential-setresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``edit-credential-setresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``edit-credential-setresponse`` =
    { errors: list<``edit-credential-setresponseErrors``>
      messages: list<``edit-credential-setresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``vulnscannercredential-set``>
      result_info: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of edit-credential-setresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``edit-credential-setresponseErrors``>,
                          messages: list<``edit-credential-setresponseMessages``>,
                          success: bool): ``edit-credential-setresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

type ``update-credential-setresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of update-credential-setresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``update-credential-setresponseErrorsSource`` = { pointer = None }

type ``update-credential-setresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``update-credential-setresponseErrorsSource``> }
    ///Creates an instance of update-credential-setresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``update-credential-setresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``update-credential-setresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of update-credential-setresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``update-credential-setresponseMessagesSource`` = { pointer = None }

type ``update-credential-setresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``update-credential-setresponseMessagesSource``> }
    ///Creates an instance of update-credential-setresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``update-credential-setresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``update-credential-setresponse`` =
    { errors: list<``update-credential-setresponseErrors``>
      messages: list<``update-credential-setresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``vulnscannercredential-set``>
      result_info: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of update-credential-setresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``update-credential-setresponseErrors``>,
                          messages: list<``update-credential-setresponseMessages``>,
                          success: bool): ``update-credential-setresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

type ``list-credentialsresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of list-credentialsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``list-credentialsresponseErrorsSource`` = { pointer = None }

type ``list-credentialsresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``list-credentialsresponseErrorsSource``> }
    ///Creates an instance of list-credentialsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``list-credentialsresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``list-credentialsresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of list-credentialsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``list-credentialsresponseMessagesSource`` = { pointer = None }

type ``list-credentialsresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``list-credentialsresponseMessagesSource``> }
    ///Creates an instance of list-credentialsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``list-credentialsresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``list-credentialsresponseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float>
      ///The number of total pages in the entire result set.
      total_pages: Option<float> }
    ///Creates an instance of list-credentialsresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``list-credentialsresponseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None
          total_pages = None }

type ``list-credentialsresponse`` =
    { errors: list<``list-credentialsresponseErrors``>
      messages: list<``list-credentialsresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``list-credentialsresponseResultinfo``>
      result: Option<list<vulnscannercredential>> }
    ///Creates an instance of list-credentialsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``list-credentialsresponseErrors``>,
                          messages: list<``list-credentialsresponseMessages``>,
                          success: bool): ``list-credentialsresponse`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``create-credentialresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of create-credentialresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``create-credentialresponseErrorsSource`` = { pointer = None }

type ``create-credentialresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``create-credentialresponseErrorsSource``> }
    ///Creates an instance of create-credentialresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``create-credentialresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``create-credentialresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of create-credentialresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``create-credentialresponseMessagesSource`` = { pointer = None }

type ``create-credentialresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``create-credentialresponseMessagesSource``> }
    ///Creates an instance of create-credentialresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``create-credentialresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``create-credentialresponse`` =
    { errors: list<``create-credentialresponseErrors``>
      messages: list<``create-credentialresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      ///A credential attached to API requests during scanning. The
      ///credential `value` is write-only and never returned in responses.
      result: Option<vulnscannercredential>
      result_info: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of create-credentialresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``create-credentialresponseErrors``>,
                          messages: list<``create-credentialresponseMessages``>,
                          success: bool): ``create-credentialresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

type ``get-credentialresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of get-credentialresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``get-credentialresponseErrorsSource`` = { pointer = None }

type ``get-credentialresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``get-credentialresponseErrorsSource``> }
    ///Creates an instance of get-credentialresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``get-credentialresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``get-credentialresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of get-credentialresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``get-credentialresponseMessagesSource`` = { pointer = None }

type ``get-credentialresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``get-credentialresponseMessagesSource``> }
    ///Creates an instance of get-credentialresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``get-credentialresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``get-credentialresponse`` =
    { errors: list<``get-credentialresponseErrors``>
      messages: list<``get-credentialresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      ///A credential attached to API requests during scanning. The
      ///credential `value` is write-only and never returned in responses.
      result: Option<vulnscannercredential>
      result_info: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of get-credentialresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``get-credentialresponseErrors``>,
                          messages: list<``get-credentialresponseMessages``>,
                          success: bool): ``get-credentialresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

type ``edit-credentialresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of edit-credentialresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``edit-credentialresponseErrorsSource`` = { pointer = None }

type ``edit-credentialresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``edit-credentialresponseErrorsSource``> }
    ///Creates an instance of edit-credentialresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``edit-credentialresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``edit-credentialresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of edit-credentialresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``edit-credentialresponseMessagesSource`` = { pointer = None }

type ``edit-credentialresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``edit-credentialresponseMessagesSource``> }
    ///Creates an instance of edit-credentialresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``edit-credentialresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``edit-credentialresponse`` =
    { errors: list<``edit-credentialresponseErrors``>
      messages: list<``edit-credentialresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      ///A credential attached to API requests during scanning. The
      ///credential `value` is write-only and never returned in responses.
      result: Option<vulnscannercredential>
      result_info: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of edit-credentialresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``edit-credentialresponseErrors``>,
                          messages: list<``edit-credentialresponseMessages``>,
                          success: bool): ``edit-credentialresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

type ``update-credentialresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of update-credentialresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``update-credentialresponseErrorsSource`` = { pointer = None }

type ``update-credentialresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``update-credentialresponseErrorsSource``> }
    ///Creates an instance of update-credentialresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``update-credentialresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``update-credentialresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of update-credentialresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``update-credentialresponseMessagesSource`` = { pointer = None }

type ``update-credentialresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``update-credentialresponseMessagesSource``> }
    ///Creates an instance of update-credentialresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``update-credentialresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``update-credentialresponse`` =
    { errors: list<``update-credentialresponseErrors``>
      messages: list<``update-credentialresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      ///A credential attached to API requests during scanning. The
      ///credential `value` is write-only and never returned in responses.
      result: Option<vulnscannercredential>
      result_info: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of update-credentialresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``update-credentialresponseErrors``>,
                          messages: list<``update-credentialresponseMessages``>,
                          success: bool): ``update-credentialresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

type ``list-scansresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of list-scansresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``list-scansresponseErrorsSource`` = { pointer = None }

type ``list-scansresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``list-scansresponseErrorsSource``> }
    ///Creates an instance of list-scansresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``list-scansresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``list-scansresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of list-scansresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``list-scansresponseMessagesSource`` = { pointer = None }

type ``list-scansresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``list-scansresponseMessagesSource``> }
    ///Creates an instance of list-scansresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``list-scansresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``list-scansresponseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float>
      ///The number of total pages in the entire result set.
      total_pages: Option<float> }
    ///Creates an instance of list-scansresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``list-scansresponseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None
          total_pages = None }

type ``list-scansresponse`` =
    { errors: list<``list-scansresponseErrors``>
      messages: list<``list-scansresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``list-scansresponseResultinfo``>
      result: Option<list<vulnscannerscan>> }
    ///Creates an instance of list-scansresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``list-scansresponseErrors``>,
                          messages: list<``list-scansresponseMessages``>,
                          success: bool): ``list-scansresponse`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``create-scanresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of create-scanresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``create-scanresponseErrorsSource`` = { pointer = None }

type ``create-scanresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``create-scanresponseErrorsSource``> }
    ///Creates an instance of create-scanresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``create-scanresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``create-scanresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of create-scanresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``create-scanresponseMessagesSource`` = { pointer = None }

type ``create-scanresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``create-scanresponseMessagesSource``> }
    ///Creates an instance of create-scanresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``create-scanresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``create-scanresponse`` =
    { errors: list<``create-scanresponseErrors``>
      messages: list<``create-scanresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<vulnscannerscan>
      result_info: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of create-scanresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``create-scanresponseErrors``>,
                          messages: list<``create-scanresponseMessages``>,
                          success: bool): ``create-scanresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

type ``get-scanresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of get-scanresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``get-scanresponseErrorsSource`` = { pointer = None }

type ``get-scanresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``get-scanresponseErrorsSource``> }
    ///Creates an instance of get-scanresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``get-scanresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``get-scanresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of get-scanresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``get-scanresponseMessagesSource`` = { pointer = None }

type ``get-scanresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``get-scanresponseMessagesSource``> }
    ///Creates an instance of get-scanresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``get-scanresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``get-scanresponse`` =
    { errors: list<``get-scanresponseErrors``>
      messages: list<``get-scanresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<vulnscannerscan>
      result_info: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of get-scanresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``get-scanresponseErrors``>,
                          messages: list<``get-scanresponseMessages``>,
                          success: bool): ``get-scanresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

type ``list-target-environmentsresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of list-target-environmentsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``list-target-environmentsresponseErrorsSource`` = { pointer = None }

type ``list-target-environmentsresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``list-target-environmentsresponseErrorsSource``> }
    ///Creates an instance of list-target-environmentsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``list-target-environmentsresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``list-target-environmentsresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of list-target-environmentsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``list-target-environmentsresponseMessagesSource`` = { pointer = None }

type ``list-target-environmentsresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``list-target-environmentsresponseMessagesSource``> }
    ///Creates an instance of list-target-environmentsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``list-target-environmentsresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``list-target-environmentsresponseResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float>
      ///The number of total pages in the entire result set.
      total_pages: Option<float> }
    ///Creates an instance of list-target-environmentsresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``list-target-environmentsresponseResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None
          total_pages = None }

type ``list-target-environmentsresponse`` =
    { errors: list<``list-target-environmentsresponseErrors``>
      messages: list<``list-target-environmentsresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``list-target-environmentsresponseResultinfo``>
      result: Option<list<``vulnscannertarget-environment``>> }
    ///Creates an instance of list-target-environmentsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``list-target-environmentsresponseErrors``>,
                          messages: list<``list-target-environmentsresponseMessages``>,
                          success: bool): ``list-target-environmentsresponse`` =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type ``create-target-environmentresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of create-target-environmentresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``create-target-environmentresponseErrorsSource`` = { pointer = None }

type ``create-target-environmentresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``create-target-environmentresponseErrorsSource``> }
    ///Creates an instance of create-target-environmentresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``create-target-environmentresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``create-target-environmentresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of create-target-environmentresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``create-target-environmentresponseMessagesSource`` = { pointer = None }

type ``create-target-environmentresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``create-target-environmentresponseMessagesSource``> }
    ///Creates an instance of create-target-environmentresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``create-target-environmentresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``create-target-environmentresponse`` =
    { errors: list<``create-target-environmentresponseErrors``>
      messages: list<``create-target-environmentresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``vulnscannertarget-environment``>
      result_info: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of create-target-environmentresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``create-target-environmentresponseErrors``>,
                          messages: list<``create-target-environmentresponseMessages``>,
                          success: bool): ``create-target-environmentresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

type ``get-target-environmentresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of get-target-environmentresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``get-target-environmentresponseErrorsSource`` = { pointer = None }

type ``get-target-environmentresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``get-target-environmentresponseErrorsSource``> }
    ///Creates an instance of get-target-environmentresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``get-target-environmentresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``get-target-environmentresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of get-target-environmentresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``get-target-environmentresponseMessagesSource`` = { pointer = None }

type ``get-target-environmentresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``get-target-environmentresponseMessagesSource``> }
    ///Creates an instance of get-target-environmentresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``get-target-environmentresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``get-target-environmentresponse`` =
    { errors: list<``get-target-environmentresponseErrors``>
      messages: list<``get-target-environmentresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``vulnscannertarget-environment``>
      result_info: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of get-target-environmentresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``get-target-environmentresponseErrors``>,
                          messages: list<``get-target-environmentresponseMessages``>,
                          success: bool): ``get-target-environmentresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

type ``edit-target-environmentresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of edit-target-environmentresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``edit-target-environmentresponseErrorsSource`` = { pointer = None }

type ``edit-target-environmentresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``edit-target-environmentresponseErrorsSource``> }
    ///Creates an instance of edit-target-environmentresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``edit-target-environmentresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``edit-target-environmentresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of edit-target-environmentresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``edit-target-environmentresponseMessagesSource`` = { pointer = None }

type ``edit-target-environmentresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``edit-target-environmentresponseMessagesSource``> }
    ///Creates an instance of edit-target-environmentresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``edit-target-environmentresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``edit-target-environmentresponse`` =
    { errors: list<``edit-target-environmentresponseErrors``>
      messages: list<``edit-target-environmentresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``vulnscannertarget-environment``>
      result_info: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of edit-target-environmentresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``edit-target-environmentresponseErrors``>,
                          messages: list<``edit-target-environmentresponseMessages``>,
                          success: bool): ``edit-target-environmentresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

type ``update-target-environmentresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of update-target-environmentresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``update-target-environmentresponseErrorsSource`` = { pointer = None }

type ``update-target-environmentresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``update-target-environmentresponseErrorsSource``> }
    ///Creates an instance of update-target-environmentresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``update-target-environmentresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``update-target-environmentresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of update-target-environmentresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``update-target-environmentresponseMessagesSource`` = { pointer = None }

type ``update-target-environmentresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``update-target-environmentresponseMessagesSource``> }
    ///Creates an instance of update-target-environmentresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``update-target-environmentresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``update-target-environmentresponse`` =
    { errors: list<``update-target-environmentresponseErrors``>
      messages: list<``update-target-environmentresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``vulnscannertarget-environment``>
      result_info: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of update-target-environmentresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``update-target-environmentresponseErrors``>,
                          messages: list<``update-target-environmentresponseMessages``>,
                          success: bool): ``update-target-environmentresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

[<RequireQualifiedAccess>]
type ListCredentialSets =
    ///Successful response.
    | OK of payload: ``list-credential-setsresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type CreateCredentialSet =
    ///Successful response.
    | OK of payload: ``create-credential-setresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type DeleteCredentialSet =
    ///Successful response.
    | OK of payload: ``vulnscannerempty-response``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type GetCredentialSet =
    ///Successful response.
    | OK of payload: ``get-credential-setresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EditCredentialSet =
    ///Successful response.
    | OK of payload: ``edit-credential-setresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type UpdateCredentialSet =
    ///Successful response.
    | OK of payload: ``update-credential-setresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type ListCredentials =
    ///Successful response.
    | OK of payload: ``list-credentialsresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type CreateCredential =
    ///Successful response.
    | OK of payload: ``create-credentialresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type DeleteCredential =
    ///Successful response.
    | OK of payload: ``vulnscannerempty-response``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type GetCredential =
    ///Successful response.
    | OK of payload: ``get-credentialresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EditCredential =
    ///Successful response.
    | OK of payload: ``edit-credentialresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type UpdateCredential =
    ///Successful response.
    | OK of payload: ``update-credentialresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type ListScans =
    ///Successful response.
    | OK of payload: ``list-scansresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type CreateScan =
    ///Successful response. Check the `messages` array for non-fatal
    ///warnings that arose during scan creation.
    | OK of payload: ``create-scanresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type GetScan =
    ///Successful response.
    | OK of payload: ``get-scanresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type ListTargetEnvironments =
    ///Successful response.
    | OK of payload: ``list-target-environmentsresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type CreateTargetEnvironment =
    ///Successful response.
    | OK of payload: ``create-target-environmentresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type DeleteTargetEnvironment =
    ///Successful response.
    | OK of payload: ``vulnscannerempty-response``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type GetTargetEnvironment =
    ///Successful response.
    | OK of payload: ``get-target-environmentresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type EditTargetEnvironment =
    ///Successful response.
    | OK of payload: ``edit-target-environmentresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken

[<RequireQualifiedAccess>]
type UpdateTargetEnvironment =
    ///Successful response.
    | OK of payload: ``update-target-environmentresponse``
    | BadRequest of payload: Newtonsoft.Json.Linq.JToken
