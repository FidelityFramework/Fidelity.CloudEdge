namespace rec Fidelity.CloudEdge.Management.SecurityCenter.Types

// Auto-generated type aliases (Hawaii normalization fix)
type ``security-center_issueClass`` = ``security-centerissueClass``
type ``security-center_issueType`` = ``security-centerissueType``
type ``security-center_subject`` = ``security-centersubject``

// Auto-generated stub types (missing from Hawaii output)
type results = string

type ``security-centercount`` = int
type ``security-centerdismissed`` = bool
///Identifier.
type ``security-centeridentifier`` = string
type ``security-centerissueClass`` = string
type ``security-centerissueClasses`` = list<``security-center_issueClass``>

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``security-centerissueType`` =
    | [<CompiledName "compliance_violation">] Compliance_violation
    | [<CompiledName "email_security">] Email_security
    | [<CompiledName "exposed_infrastructure">] Exposed_infrastructure
    | [<CompiledName "insecure_configuration">] Insecure_configuration
    | [<CompiledName "weak_authentication">] Weak_authentication
    | [<CompiledName "configuration_suggestion">] Configuration_suggestion
    member this.Format() =
        match this with
        | Compliance_violation -> "compliance_violation"
        | Email_security -> "email_security"
        | Exposed_infrastructure -> "exposed_infrastructure"
        | Insecure_configuration -> "insecure_configuration"
        | Weak_authentication -> "weak_authentication"
        | Configuration_suggestion -> "configuration_suggestion"

type ``security-centerissueTypes`` = list<``security-center_issueType``>

type Source =
    { pointer: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source = { pointer = None }

type ``security-centermessagesArrayItem`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<Source> }
    ///Creates an instance of security-centermessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``security-centermessagesArrayItem`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``security-centermessages`` = list<``security-centermessagesArrayItem``>
type ``security-centerpage`` = int
type ``security-centerperPage`` = int
type ``security-centerproducts`` = list<string>

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``EnumForsecurity-centerseverityQueryParam`` =
    | [<CompiledName "low">] Low
    | [<CompiledName "moderate">] Moderate
    | [<CompiledName "critical">] Critical
    member this.Format() =
        match this with
        | Low -> "low"
        | Moderate -> "moderate"
        | Critical -> "critical"

type ``security-centerseverityQueryParam`` = list<``EnumForsecurity-centerseverityQueryParam``>
type ``security-centersubject`` = string
type ``security-centersubjects`` = list<``security-center_subject``>

///User-defined classification for the insight. Can be 'false_positive', 'accept_risk', 'other', or null.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``security-centeruserClassification`` =
    | [<CompiledName "false_positive">] False_positive
    | [<CompiledName "accept_risk">] Accept_risk
    | [<CompiledName "other">] Other
    member this.Format() =
        match this with
        | False_positive -> "false_positive"
        | Accept_risk -> "accept_risk"
        | Other -> "other"

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

type ``security-centerapi-response-common`` =
    { errors: list<Errors>
      messages: list<Messages>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of security-centerapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<Errors>, messages: list<Messages>, success: bool): ``security-centerapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``security-centerapi-response-common-failure`` =
    { errors: list<Errors>
      messages: list<Messages>
      result: obj
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of security-centerapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<Errors>,
                          messages: list<Messages>,
                          result: obj,
                          success: bool): ``security-centerapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``security-centerapi-response-singleErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of security-centerapi-response-singleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``security-centerapi-response-singleErrorsSource`` = { pointer = None }

type ``security-centerapi-response-singleErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``security-centerapi-response-singleErrorsSource``> }
    ///Creates an instance of security-centerapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``security-centerapi-response-singleErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``security-centerapi-response-singleMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of security-centerapi-response-singleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``security-centerapi-response-singleMessagesSource`` = { pointer = None }

type ``security-centerapi-response-singleMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``security-centerapi-response-singleMessagesSource``> }
    ///Creates an instance of security-centerapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``security-centerapi-response-singleMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``security-centerapi-response-single`` =
    { errors: Option<list<``security-centerapi-response-singleErrors``>>
      messages: Option<list<``security-centerapi-response-singleMessages``>>
      ///Whether the API call was successful.
      success: Option<bool> }
    ///Creates an instance of security-centerapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``security-centerapi-response-single`` =
        { errors = None
          messages = None
          success = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Fieldchanged =
    | [<CompiledName "status">] Status
    | [<CompiledName "user_classification">] User_classification
    member this.Format() =
        match this with
        | Status -> "status"
        | User_classification -> "user_classification"

type ``security-centerauditLog`` =
    { ///The timestamp when the change occurred.
      changed_at: Option<System.DateTimeOffset>
      ///The actor that made the change. 'system' for automated changes, or a user identifier.
      changed_by: Option<string>
      ///The value of the field after the change. Null if the field was cleared.
      current_value: Option<string>
      ///The field that was changed.
      field_changed: Option<Fieldchanged>
      ///UUIDv7 identifier for the audit log entry, time-ordered.
      id: Option<System.Guid>
      ///The ID of the insight this audit log entry relates to.
      issue_id: Option<string>
      ///The value of the field before the change. Null if the field was not previously set.
      previous_value: Option<string>
      ///Optional rationale provided for the change.
      rationale: Option<string>
      ///The zone ID associated with the insight. Only present for zone-level insights.
      zone_id: Option<int64> }
    ///Creates an instance of security-centerauditLog with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``security-centerauditLog`` =
        { changed_at = None
          changed_by = None
          current_value = None
          field_changed = None
          id = None
          issue_id = None
          previous_value = None
          rationale = None
          zone_id = None }

type ``security-centerauditLogResponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of security-centerauditLogResponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``security-centerauditLogResponseErrorsSource`` = { pointer = None }

type ``security-centerauditLogResponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``security-centerauditLogResponseErrorsSource``> }
    ///Creates an instance of security-centerauditLogResponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``security-centerauditLogResponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``security-centerauditLogResponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of security-centerauditLogResponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``security-centerauditLogResponseMessagesSource`` = { pointer = None }

type ``security-centerauditLogResponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``security-centerauditLogResponseMessagesSource``> }
    ///Creates an instance of security-centerauditLogResponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``security-centerauditLogResponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type Resultinfo =
    { ///The number of items in the current result set.
      count: Option<int>
      ///Opaque cursor for the next page of results. Absent when there are no more results.
      cursor: Option<string>
      ///The requested number of items per page.
      per_page: Option<int> }
    ///Creates an instance of Resultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Resultinfo =
        { count = None
          cursor = None
          per_page = None }

type ``security-centerauditLogResponse`` =
    { errors: list<``security-centerauditLogResponseErrors``>
      messages: list<``security-centerauditLogResponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<list<``security-centerauditLog``>>
      result_info: Option<Resultinfo> }
    ///Creates an instance of security-centerauditLogResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``security-centerauditLogResponseErrors``>,
                          messages: list<``security-centerauditLogResponseMessages``>,
                          success: bool): ``security-centerauditLogResponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

type Payload =
    { ///Describes the method used to detect insight.
      detection_method: Option<string>
      zone_tag: Option<string> }
    ///Creates an instance of Payload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Payload =
        { detection_method = None
          zone_tag = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Severity =
    | [<CompiledName "Low">] Low
    | [<CompiledName "Moderate">] Moderate
    | [<CompiledName "Critical">] Critical
    member this.Format() =
        match this with
        | Low -> "Low"
        | Moderate -> "Moderate"
        | Critical -> "Critical"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Status =
    | [<CompiledName "active">] Active
    | [<CompiledName "resolved">] Resolved
    member this.Format() =
        match this with
        | Active -> "active"
        | Resolved -> "resolved"

type ``security-centerissue`` =
    { dismissed: Option<bool>
      ///Indicates whether the insight has a large payload that requires fetching via the context endpoint.
      has_extended_context: Option<bool>
      id: Option<string>
      issue_class: Option<``security-centerissueClass``>
      issue_type: Option<``security-centerissueType``>
      payload: Option<Payload>
      resolve_link: Option<string>
      resolve_text: Option<string>
      severity: Option<Severity>
      since: Option<System.DateTimeOffset>
      ///The current status of the insight.
      status: Option<Status>
      subject: Option<``security-centersubject``>
      timestamp: Option<System.DateTimeOffset>
      ///User-defined classification for the insight. Can be 'false_positive', 'accept_risk', 'other', or null.
      user_classification: Option<``security-centeruserClassification``> }
    ///Creates an instance of security-centerissue with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``security-centerissue`` =
        { dismissed = None
          has_extended_context = None
          id = None
          issue_class = None
          issue_type = None
          payload = None
          resolve_link = None
          resolve_text = None
          severity = None
          since = None
          status = None
          subject = None
          timestamp = None
          user_classification = None }

type ``security-centernewScanResponse`` =
    { ///An opaque identifier for the initiated scan.
      scan_id: Option<string> }
    ///Creates an instance of security-centernewScanResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``security-centernewScanResponse`` = { scan_id = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``security-centerscanStatusResponseStatus`` =
    | [<CompiledName "in_progress">] In_progress
    | [<CompiledName "completed">] Completed
    member this.Format() =
        match this with
        | In_progress -> "in_progress"
        | Completed -> "completed"

type ``security-centerscanStatusResponse`` =
    { ///An opaque identifier for the scan.
      scan_id: string
      ///The time at which the scan was started, in RFC 3339 format.
      started_at: System.DateTimeOffset
      ///The current status of the scan.
      status: ``security-centerscanStatusResponseStatus`` }
    ///Creates an instance of security-centerscanStatusResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (scan_id: string,
                          started_at: System.DateTimeOffset,
                          status: ``security-centerscanStatusResponseStatus``): ``security-centerscanStatusResponse`` =
        { scan_id = scan_id
          started_at = started_at
          status = status }

type ``security-centeruserClassificationUpdate`` =
    { ///User-defined classification for the insight. Can be 'false_positive', 'accept_risk', 'other', or null.
      classification: Option<``security-centeruserClassification``>
      ///Rationale for the classification change. Required when classification is 'accept_risk' or 'other'.
      rationale: Option<string> }
    ///Creates an instance of security-centeruserClassificationUpdate with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``security-centeruserClassificationUpdate`` =
        { classification = None
          rationale = None }

type ``security-centervalueCountsResponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of security-centervalueCountsResponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``security-centervalueCountsResponseErrorsSource`` = { pointer = None }

type ``security-centervalueCountsResponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``security-centervalueCountsResponseErrorsSource``> }
    ///Creates an instance of security-centervalueCountsResponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``security-centervalueCountsResponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``security-centervalueCountsResponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of security-centervalueCountsResponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``security-centervalueCountsResponseMessagesSource`` = { pointer = None }

type ``security-centervalueCountsResponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``security-centervalueCountsResponseMessagesSource``> }
    ///Creates an instance of security-centervalueCountsResponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``security-centervalueCountsResponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type Result =
    { count: Option<int>
      value: Option<string> }
    ///Creates an instance of Result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Result = { count = None; value = None }

type ``security-centervalueCountsResponse`` =
    { errors: list<``security-centervalueCountsResponseErrors``>
      messages: list<``security-centervalueCountsResponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<list<Result>> }
    ///Creates an instance of security-centervalueCountsResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``security-centervalueCountsResponseErrors``>,
                          messages: list<``security-centervalueCountsResponseMessages``>,
                          success: bool): ``security-centervalueCountsResponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``get-security-center-insightsresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of get-security-center-insightsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``get-security-center-insightsresponseErrorsSource`` = { pointer = None }

type ``get-security-center-insightsresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``get-security-center-insightsresponseErrorsSource``> }
    ///Creates an instance of get-security-center-insightsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``get-security-center-insightsresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``get-security-center-insightsresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of get-security-center-insightsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``get-security-center-insightsresponseMessagesSource`` = { pointer = None }

type ``get-security-center-insightsresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``get-security-center-insightsresponseMessagesSource``> }
    ///Creates an instance of get-security-center-insightsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``get-security-center-insightsresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``get-security-center-insightsresponseResult`` =
    { ///Indicates the total number of results.
      count: Option<``security-centercount``>
      issues: Option<list<``security-centerissue``>>
      ///Specifies the current page within paginated list of results.
      page: Option<``security-centerpage``>
      ///Sets the number of results per page of results.
      per_page: Option<``security-centerperPage``> }
    ///Creates an instance of get-security-center-insightsresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``get-security-center-insightsresponseResult`` =
        { count = None
          issues = None
          page = None
          per_page = None }

type ``get-security-center-insightsresponse`` =
    { errors: list<``get-security-center-insightsresponseErrors``>
      messages: list<``get-security-center-insightsresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``get-security-center-insightsresponseResult``> }
    ///Creates an instance of get-security-center-insightsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``get-security-center-insightsresponseErrors``>,
                          messages: list<``get-security-center-insightsresponseMessages``>,
                          success: bool): ``get-security-center-insightsresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``get-security-center-account-scansresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of get-security-center-account-scansresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``get-security-center-account-scansresponseErrorsSource`` = { pointer = None }

type ``get-security-center-account-scansresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``get-security-center-account-scansresponseErrorsSource``> }
    ///Creates an instance of get-security-center-account-scansresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``get-security-center-account-scansresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``get-security-center-account-scansresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of get-security-center-account-scansresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``get-security-center-account-scansresponseMessagesSource`` = { pointer = None }

type ``get-security-center-account-scansresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``get-security-center-account-scansresponseMessagesSource``> }
    ///Creates an instance of get-security-center-account-scansresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``get-security-center-account-scansresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``get-security-center-account-scansresponse`` =
    { errors: list<``get-security-center-account-scansresponseErrors``>
      messages: list<``get-security-center-account-scansresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<list<``security-centerscanStatusResponse``>> }
    ///Creates an instance of get-security-center-account-scansresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``get-security-center-account-scansresponseErrors``>,
                          messages: list<``get-security-center-account-scansresponseMessages``>,
                          success: bool): ``get-security-center-account-scansresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``start-security-center-account-scanresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of start-security-center-account-scanresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``start-security-center-account-scanresponseErrorsSource`` = { pointer = None }

type ``start-security-center-account-scanresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``start-security-center-account-scanresponseErrorsSource``> }
    ///Creates an instance of start-security-center-account-scanresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``start-security-center-account-scanresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``start-security-center-account-scanresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of start-security-center-account-scanresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``start-security-center-account-scanresponseMessagesSource`` = { pointer = None }

type ``start-security-center-account-scanresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``start-security-center-account-scanresponseMessagesSource``> }
    ///Creates an instance of start-security-center-account-scanresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``start-security-center-account-scanresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``start-security-center-account-scanresponse`` =
    { errors: list<``start-security-center-account-scanresponseErrors``>
      messages: list<``start-security-center-account-scanresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<``security-centernewScanResponse``> }
    ///Creates an instance of start-security-center-account-scanresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``start-security-center-account-scanresponseErrors``>,
                          messages: list<``start-security-center-account-scanresponseMessages``>,
                          success: bool): ``start-security-center-account-scanresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

type ``get-security-center-insight-contextresponseErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of get-security-center-insight-contextresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``get-security-center-insight-contextresponseErrorsSource`` = { pointer = None }

type ``get-security-center-insight-contextresponseErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``get-security-center-insight-contextresponseErrorsSource``> }
    ///Creates an instance of get-security-center-insight-contextresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``get-security-center-insight-contextresponseErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``get-security-center-insight-contextresponseMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of get-security-center-insight-contextresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``get-security-center-insight-contextresponseMessagesSource`` = { pointer = None }

type ``get-security-center-insight-contextresponseMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``get-security-center-insight-contextresponseMessagesSource``> }
    ///Creates an instance of get-security-center-insight-contextresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``get-security-center-insight-contextresponseMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``get-security-center-insight-contextresponse`` =
    { errors: list<``get-security-center-insight-contextresponseErrors``>
      messages: list<``get-security-center-insight-contextresponseMessages``>
      ///Whether the API call was successful.
      success: bool
      result: Option<Map<string, obj>> }
    ///Creates an instance of get-security-center-insight-contextresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``get-security-center-insight-contextresponseErrors``>,
                          messages: list<``get-security-center-insight-contextresponseMessages``>,
                          success: bool): ``get-security-center-insight-contextresponse`` =
        { errors = errors
          messages = messages
          success = success
          result = None }

[<RequireQualifiedAccess>]
type GetSecurityCenterInsights =
    ///The request was successful.
    | OK of payload: ``get-security-center-insightsresponse``
    ///A client error occurred.
    | BadRequest of payload: ``security-centerapi-response-common-failure``

[<RequireQualifiedAccess>]
type GetSecurityCenterAccountAuditLog =
    ///The request was successful.
    | OK of payload: ``security-centerauditLogResponse``
    ///A client error occurred.
    | BadRequest of payload: ``security-centerapi-response-common-failure``

[<RequireQualifiedAccess>]
type GetSecurityCenterInsightCountsByClass =
    ///The request was successful.
    | OK of payload: ``security-centervalueCountsResponse``
    ///A client error occurred.
    | BadRequest of payload: ``security-centerapi-response-common-failure``

[<RequireQualifiedAccess>]
type GetSecurityCenterAccountScans =
    ///The request was successful.
    | OK of payload: ``get-security-center-account-scansresponse``
    ///A client error occurred.
    | BadRequest of payload: ``security-centerapi-response-common-failure``

[<RequireQualifiedAccess>]
type StartSecurityCenterAccountScan =
    ///The request was successful.
    | OK of payload: ``start-security-center-account-scanresponse``
    ///A client error occurred.
    | BadRequest of payload: ``security-centerapi-response-common-failure``

[<RequireQualifiedAccess>]
type GetSecurityCenterInsightCountsBySeverity =
    ///The request was successful.
    | OK of payload: ``security-centervalueCountsResponse``
    ///A client error occurred.
    | BadRequest of payload: ``security-centerapi-response-common-failure``

[<RequireQualifiedAccess>]
type GetSecurityCenterInsightCountsByType =
    ///The request was successful.
    | OK of payload: ``security-centervalueCountsResponse``
    ///A client error occurred.
    | BadRequest of payload: ``security-centerapi-response-common-failure``

[<RequireQualifiedAccess>]
type GetSecurityCenterIssueAuditLog =
    ///The request was successful.
    | OK of payload: ``security-centerauditLogResponse``
    ///A client error occurred.
    | BadRequest of payload: ``security-centerapi-response-common-failure``

[<RequireQualifiedAccess>]
type UpdateSecurityCenterInsightClassification =
    ///The request was successful.
    | OK of payload: string
    ///A client error occurred.
    | BadRequest of payload: ``security-centerapi-response-common-failure``

[<RequireQualifiedAccess>]
type GetSecurityCenterInsightContext =
    ///The request was successful.
    | OK of payload: ``get-security-center-insight-contextresponse``
    ///A client error occurred.
    | BadRequest of payload: ``security-centerapi-response-common-failure``

type ArchiveSecurityCenterInsightPayload =
    { dismiss: Option<bool> }
    ///Creates an instance of ArchiveSecurityCenterInsightPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ArchiveSecurityCenterInsightPayload = { dismiss = None }

[<RequireQualifiedAccess>]
type ArchiveSecurityCenterInsight =
    ///The request was successful.
    | OK of payload: string
    ///A client error occurred.
    | BadRequest of payload: ``security-centerapi-response-common-failure``
