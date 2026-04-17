namespace rec Fidelity.CloudEdge.Tenancy.Organizations.Types

// Auto-generated type aliases (Hawaii normalization fix)
type ``resource-sharing_v4error`` = ``resource-sharingv4error``

// Auto-generated stub types (missing from Hawaii output)
type batchCreate = string
type records = string
type results = string

///A unique identifier for the audit log entry.
type ``aaaschemas-identifier`` = string

type ``aaaschemas-messagesArrayItem`` =
    { message: string }
    ///Creates an instance of aaaschemas-messagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (message: string): ``aaaschemas-messagesArrayItem`` = { message = message }

type ``aaaschemas-messages`` = list<``aaaschemas-messagesArrayItem``>
///Identifier
type ``iamcommoncomponents-schemas-identifier`` = string

///Whether the user is a member of the organization or has an invitation pending.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``iamcomponents-schemas-status`` =
    | [<CompiledName "member">] Member
    | [<CompiledName "invited">] Invited
    member this.Format() =
        match this with
        | Member -> "member"
        | Invited -> "invited"

type Source =
    { pointer: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source = { pointer = None }

type ``iamschemas-messagesArrayItem`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<Source> }
    ///Creates an instance of iamschemas-messagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``iamschemas-messagesArrayItem`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``iamschemas-messages`` = list<``iamschemas-messagesArrayItem``>
///Organization name.
type ``iamschemas-name`` = string
///Access permissions for this User.
type ``iamschemas-permissions`` = list<string>
///Organization Member ID
type ``organizations-apiMemberID`` = string
type ``organizations-apiOrganizationID`` = string
///Account identifier.
type ``resource-sharingaccountid`` = string
///The display name of an account.
type ``resource-sharingaccountname`` = string
///When the share was created.
type ``resource-sharingcreated`` = System.DateTimeOffset
///When the share was modified.
type ``resource-sharingmodified`` = System.DateTimeOffset
///Organization identifier.
type ``resource-sharingorganizationid`` = string
///Share Resource identifier.
type ``resource-sharingresourceid`` = string
///Share Resource identifier.
type ``resource-sharingresourceresourceid`` = string

///Resource Status.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``resource-sharingresourcestatus`` =
    | [<CompiledName "active">] Active
    | [<CompiledName "deleting">] Deleting
    | [<CompiledName "deleted">] Deleted
    member this.Format() =
        match this with
        | Active -> "active"
        | Deleting -> "deleting"
        | Deleted -> "deleted"

///Resource Type.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``resource-sharingresourcetype`` =
    | [<CompiledName "custom-ruleset">] CustomRuleset
    | [<CompiledName "gateway-policy">] GatewayPolicy
    | [<CompiledName "gateway-destination-ip">] GatewayDestinationIp
    | [<CompiledName "gateway-block-page-settings">] GatewayBlockPageSettings
    | [<CompiledName "gateway-extended-email-matching">] GatewayExtendedEmailMatching
    member this.Format() =
        match this with
        | CustomRuleset -> "custom-ruleset"
        | GatewayPolicy -> "gateway-policy"
        | GatewayDestinationIp -> "gateway-destination-ip"
        | GatewayBlockPageSettings -> "gateway-block-page-settings"
        | GatewayExtendedEmailMatching -> "gateway-extended-email-matching"

type ``resource-sharingresourceversion`` = int
///Share identifier tag.
type ``resource-sharingshareid`` = string

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``resource-sharingsharekind`` =
    | [<CompiledName "sent">] Sent
    | [<CompiledName "received">] Received
    member this.Format() =
        match this with
        | Sent -> "sent"
        | Received -> "received"

///The name of the share.
type ``resource-sharingsharename`` = string

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``resource-sharingsharestatus`` =
    | [<CompiledName "active">] Active
    | [<CompiledName "deleting">] Deleting
    | [<CompiledName "deleted">] Deleted
    member this.Format() =
        match this with
        | Active -> "active"
        | Deleting -> "deleting"
        | Deleted -> "deleted"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``resource-sharingsharetargettype`` =
    | [<CompiledName "account">] Account
    | [<CompiledName "organization">] Organization
    member this.Format() =
        match this with
        | Account -> "account"
        | Organization -> "organization"

type ``resource-sharingv4errors`` = list<``resource-sharing_v4error``>

///Provides information about the action performed.
type ``aaaaudit-log-action`` =
    { ///A short description of the action performed.
      description: Option<string>
      ///The result of the action, indicating success or failure.
      result: Option<string>
      ///A timestamp indicating when the action was logged.
      time: Option<System.DateTimeOffset>
      ///A short string that describes the action that was performed.
      ``type``: Option<string> }
    ///Creates an instance of aaaaudit-log-action with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``aaaaudit-log-action`` =
        { description = None
          result = None
          time = None
          ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Context =
    | [<CompiledName "api_key">] Api_key
    | [<CompiledName "api_token">] Api_token
    | [<CompiledName "dash">] Dash
    | [<CompiledName "oauth">] Oauth
    | [<CompiledName "origin_ca_key">] Origin_ca_key
    member this.Format() =
        match this with
        | Api_key -> "api_key"
        | Api_token -> "api_token"
        | Dash -> "dash"
        | Oauth -> "oauth"
        | Origin_ca_key -> "origin_ca_key"

///Provides details about the actor who performed the action.
type ``aaaaudit-log-actor-base`` =
    { context: Option<Context>
      ///The email of the actor who performed the action.
      email: Option<string>
      ///The ID of the actor who performed the action. If a user performed the action, this will be their User ID.
      id: Option<string>
      ///The IP address of the request that performed the action.
      ip_address: Option<string>
      ///The API token ID when the actor context is an api_token or oauth.
      token_id: Option<string>
      ///The API token name when the actor context is an api_token or oauth.
      token_name: Option<string> }
    ///Creates an instance of aaaaudit-log-actor-base with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``aaaaudit-log-actor-base`` =
        { context = None
          email = None
          id = None
          ip_address = None
          token_id = None
          token_name = None }

///Provides raw information about the request and response.
type ``aaaaudit-log-raw`` =
    { ///The Cloudflare Ray ID for the request.
      cf_ray_id: Option<string>
      ///The HTTP method of the request.
      method: Option<string>
      ///The HTTP response status code returned by the API.
      status_code: Option<int>
      ///The URI of the request.
      uri: Option<string>
      ///The client's user agent string sent with the request.
      user_agent: Option<string> }
    ///Creates an instance of aaaaudit-log-raw with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``aaaaudit-log-raw`` =
        { cf_ray_id = None
          method = None
          status_code = None
          uri = None
          user_agent = None }

type Errors =
    { message: string }
    ///Creates an instance of Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (message: string): Errors = { message = message }

type ``aaaaudit-logs-response-collection`` =
    { errors: Option<list<Errors>>
      ///Provides information about the result of the request, including count and cursor.
      result_info: Option<aaaresultinfo>
      ///Indicates whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of aaaaudit-logs-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``aaaaudit-logs-response-collection`` =
        { errors = None
          result_info = None
          success = None }

///Contains organization related information.
type Organization =
    { ///A unique identifier for the organization.
      id: Option<string> }
    ///Creates an instance of Organization with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Organization = { id = None }

///Provides details about the affected resource.
type Resource =
    { ///The unique identifier for the affected resource.
      id: Option<string>
      ///The Cloudflare product associated with the resource.
      product: Option<string>
      request: Option<obj>
      response: Option<obj>
      ///The scope of the resource.
      scope: Option<obj>
      ///The type of the resource.
      ``type``: Option<string> }
    ///Creates an instance of Resource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Resource =
        { id = None
          product = None
          request = None
          response = None
          scope = None
          ``type`` = None }

type ``aaaaudit-logs-v2-org`` =
    { ///Provides information about the action performed.
      action: Option<``aaaaudit-log-action``>
      actor: Option<obj>
      ///A unique identifier for the audit log entry.
      id: Option<``aaaschemas-identifier``>
      ///Contains organization related information.
      organization: Option<Organization>
      ///Provides raw information about the request and response.
      raw: Option<``aaaaudit-log-raw``>
      ///Provides details about the affected resource.
      resource: Option<Resource> }
    ///Creates an instance of aaaaudit-logs-v2-org with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``aaaaudit-logs-v2-org`` =
        { action = None
          actor = None
          id = None
          organization = None
          raw = None
          resource = None }

type ``aaaaudit-logs-v2-org-response-collectionErrors`` =
    { message: string }
    ///Creates an instance of aaaaudit-logs-v2-org-response-collectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (message: string): ``aaaaudit-logs-v2-org-response-collectionErrors`` = { message = message }

type ``aaaaudit-logs-v2-org-response-collection`` =
    { errors: Option<list<``aaaaudit-logs-v2-org-response-collectionErrors``>>
      ///Provides information about the result of the request, including count and cursor.
      result_info: Option<aaaresultinfo>
      ///Indicates whether the API call was successful
      success: Option<bool>
      result: Option<list<``aaaaudit-logs-v2-org``>> }
    ///Creates an instance of aaaaudit-logs-v2-org-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``aaaaudit-logs-v2-org-response-collection`` =
        { errors = None
          result_info = None
          success = None
          result = None }

///Provides information about the result of the request, including count and cursor.
type aaaresultinfo =
    { ///The number of records returned in the response.
      count: Option<string>
      ///The cursor token used for pagination.
      cursor: Option<string> }
    ///Creates an instance of aaaresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): aaaresultinfo = { count = None; cursor = None }

type ``aaaschemas-api-response-common-failureErrors`` =
    { ///A text description of this message.
      message: string }
    ///Creates an instance of aaaschemas-api-response-common-failureErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (message: string): ``aaaschemas-api-response-common-failureErrors`` = { message = message }

type Messages =
    { message: Option<string> }
    ///Creates an instance of Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Messages = { message = None }

type ``aaaschemas-api-response-common-failure`` =
    { ///A list of error messages.
      errors: list<``aaaschemas-api-response-common-failureErrors``>
      messages: Option<list<Messages>>
      ///Indicates whether the API call was failed
      success: bool }
    ///Creates an instance of aaaschemas-api-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``aaaschemas-api-response-common-failureErrors``>, success: bool): ``aaaschemas-api-response-common-failure`` =
        { errors = errors
          messages = None
          success = success }

type ``iamapi-response-collectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of iamapi-response-collectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``iamapi-response-collectionErrorsSource`` = { pointer = None }

type ``iamapi-response-collectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``iamapi-response-collectionErrorsSource``> }
    ///Creates an instance of iamapi-response-collectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``iamapi-response-collectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``iamapi-response-collectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of iamapi-response-collectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``iamapi-response-collectionMessagesSource`` = { pointer = None }

type ``iamapi-response-collectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``iamapi-response-collectionMessagesSource``> }
    ///Creates an instance of iamapi-response-collectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``iamapi-response-collectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``iamapi-response-collection`` =
    { errors: Option<list<``iamapi-response-collectionErrors``>>
      messages: Option<list<``iamapi-response-collectionMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<iamresultinfo> }
    ///Creates an instance of iamapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``iamapi-response-collection`` =
        { errors = None
          messages = None
          success = None
          result_info = None }

type ``iamapi-response-commonErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of iamapi-response-commonErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``iamapi-response-commonErrorsSource`` = { pointer = None }

type ``iamapi-response-commonErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``iamapi-response-commonErrorsSource``> }
    ///Creates an instance of iamapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``iamapi-response-commonErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``iamapi-response-commonMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of iamapi-response-commonMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``iamapi-response-commonMessagesSource`` = { pointer = None }

type ``iamapi-response-commonMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``iamapi-response-commonMessagesSource``> }
    ///Creates an instance of iamapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``iamapi-response-commonMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``iamapi-response-common`` =
    { errors: list<``iamapi-response-commonErrors``>
      messages: list<``iamapi-response-commonMessages``>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of iamapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``iamapi-response-commonErrors``>,
                          messages: list<``iamapi-response-commonMessages``>,
                          success: bool): ``iamapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``iamapi-response-common-failure`` =
    { errors: obj
      messages: obj
      result: obj
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of iamapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: obj,
                          messages: obj,
                          result: obj,
                          success: bool): ``iamapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``iamapi-response-singleErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of iamapi-response-singleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``iamapi-response-singleErrorsSource`` = { pointer = None }

type ``iamapi-response-singleErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``iamapi-response-singleErrorsSource``> }
    ///Creates an instance of iamapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``iamapi-response-singleErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``iamapi-response-singleMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of iamapi-response-singleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``iamapi-response-singleMessagesSource`` = { pointer = None }

type ``iamapi-response-singleMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``iamapi-response-singleMessagesSource``> }
    ///Creates an instance of iamapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``iamapi-response-singleMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``iamapi-response-single`` =
    { errors: Option<list<``iamapi-response-singleErrors``>>
      messages: Option<list<``iamapi-response-singleMessages``>>
      ///Whether the API call was successful.
      success: Option<bool> }
    ///Creates an instance of iamapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``iamapi-response-single`` =
        { errors = None
          messages = None
          success = None }

type iamcollectionorganizationresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of iamcollectionorganizationresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): iamcollectionorganizationresponseErrorsSource = { pointer = None }

type iamcollectionorganizationresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<iamcollectionorganizationresponseErrorsSource> }
    ///Creates an instance of iamcollectionorganizationresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): iamcollectionorganizationresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type iamcollectionorganizationresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of iamcollectionorganizationresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): iamcollectionorganizationresponseMessagesSource = { pointer = None }

type iamcollectionorganizationresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<iamcollectionorganizationresponseMessagesSource> }
    ///Creates an instance of iamcollectionorganizationresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): iamcollectionorganizationresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type iamcollectionorganizationresponse =
    { errors: list<iamcollectionorganizationresponseErrors>
      messages: list<iamcollectionorganizationresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<iamresultinfo>
      result: Option<list<iamorganization>> }
    ///Creates an instance of iamcollectionorganizationresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<iamcollectionorganizationresponseErrors>,
                          messages: list<iamcollectionorganizationresponseMessages>,
                          success: bool): iamcollectionorganizationresponse =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type iamorganization =
    { ///Identifier
      id: Option<``iamcommoncomponents-schemas-identifier``>
      ///Organization name.
      name: Option<``iamschemas-name``>
      ///Access permissions for this User.
      permissions: Option<``iamschemas-permissions``>
      ///List of roles that a user has within an organization.
      roles: Option<list<string>>
      ///Whether the user is a member of the organization or has an invitation pending.
      status: Option<``iamcomponents-schemas-status``> }
    ///Creates an instance of iamorganization with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): iamorganization =
        { id = None
          name = None
          permissions = None
          roles = None
          status = None }

type iamresultinfo =
    { ///Total number of results for the requested service
      count: Option<float>
      ///Current page within paginated list of results
      page: Option<float>
      ///Number of results per page of results
      per_page: Option<float>
      ///Total results available without any search parameters
      total_count: Option<float> }
    ///Creates an instance of iamresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): iamresultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type iamsingleorganizationresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of iamsingleorganizationresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): iamsingleorganizationresponseErrorsSource = { pointer = None }

type iamsingleorganizationresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<iamsingleorganizationresponseErrorsSource> }
    ///Creates an instance of iamsingleorganizationresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): iamsingleorganizationresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type iamsingleorganizationresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of iamsingleorganizationresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): iamsingleorganizationresponseMessagesSource = { pointer = None }

type iamsingleorganizationresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<iamsingleorganizationresponseMessagesSource> }
    ///Creates an instance of iamsingleorganizationresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): iamsingleorganizationresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type iamsingleorganizationresponse =
    { errors: list<iamsingleorganizationresponseErrors>
      messages: list<iamsingleorganizationresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<obj> }
    ///Creates an instance of iamsingleorganizationresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<iamsingleorganizationresponseErrors>,
                          messages: list<iamsingleorganizationresponseMessages>,
                          success: bool): iamsingleorganizationresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type Settings =
    { abuse_contact_email: string
      access_approval_expiry: System.DateTimeOffset
      api_access_enabled: bool
      enforce_twofactor: bool }
    ///Creates an instance of Settings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (abuse_contact_email: string,
                          access_approval_expiry: System.DateTimeOffset,
                          api_access_enabled: bool,
                          enforce_twofactor: bool): Settings =
        { abuse_contact_email = abuse_contact_email
          access_approval_expiry = access_approval_expiry
          api_access_enabled = api_access_enabled
          enforce_twofactor = enforce_twofactor }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "standard">] Standard
    | [<CompiledName "enterprise">] Enterprise
    member this.Format() =
        match this with
        | Standard -> "standard"
        | Enterprise -> "enterprise"

type ``organizations-apiAccount`` =
    { created_on: System.DateTimeOffset
      id: string
      name: string
      settings: Settings
      ``type``: Type }
    ///Creates an instance of organizations-apiAccount with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (created_on: System.DateTimeOffset,
                          id: string,
                          name: string,
                          settings: Settings,
                          ``type``: Type): ``organizations-apiAccount`` =
        { created_on = created_on
          id = id
          name = name
          settings = settings
          ``type`` = ``type`` }

type ``organizations-apiBatchCreateMembersRequest`` =
    { members: list<``organizations-apiCreateSingleMember``> }
    ///Creates an instance of organizations-apiBatchCreateMembersRequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (members: list<``organizations-apiCreateSingleMember``>): ``organizations-apiBatchCreateMembersRequest`` =
        { members = members }

type ``organizations-apiCreateMemberRequest`` =
    { ``member``: ``organizations-apiCreateSingleMember`` }
    ///Creates an instance of organizations-apiCreateMemberRequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``member``: ``organizations-apiCreateSingleMember``): ``organizations-apiCreateMemberRequest`` =
        { ``member`` = ``member`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Status =
    | [<CompiledName "active">] Active
    | [<CompiledName "canceled">] Canceled
    member this.Format() =
        match this with
        | Active -> "active"
        | Canceled -> "canceled"

type User =
    { email: string }
    ///Creates an instance of User with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (email: string): User = { email = email }

type ``organizations-apiCreateSingleMember`` =
    { status: Option<Status>
      user: User }
    ///Creates an instance of organizations-apiCreateSingleMember with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (user: User): ``organizations-apiCreateSingleMember`` = { status = None; user = user }

type ``organizations-apiDeleteOrganizationResponse`` =
    { id: string }
    ///Creates an instance of organizations-apiDeleteOrganizationResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string): ``organizations-apiDeleteOrganizationResponse`` = { id = id }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``organizations-apiMemberStatus`` =
    | [<CompiledName "active">] Active
    | [<CompiledName "canceled">] Canceled
    member this.Format() =
        match this with
        | Active -> "active"
        | Canceled -> "canceled"

type ``organizations-apiMember`` =
    { create_time: System.DateTimeOffset
      ///Organization Member ID
      id: ``organizations-apiMemberID``
      meta: Map<string, string>
      status: ``organizations-apiMemberStatus``
      update_time: System.DateTimeOffset
      user: ``organizations-apiMemberSubjectUser`` }
    ///Creates an instance of organizations-apiMember with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (create_time: System.DateTimeOffset,
                          id: ``organizations-apiMemberID``,
                          meta: Map<string, string>,
                          status: ``organizations-apiMemberStatus``,
                          update_time: System.DateTimeOffset,
                          user: ``organizations-apiMemberSubjectUser``): ``organizations-apiMember`` =
        { create_time = create_time
          id = id
          meta = meta
          status = status
          update_time = update_time
          user = user }

type ``organizations-apiMemberSubjectUser`` =
    { email: string
      id: string
      name: string
      two_factor_authentication_enabled: bool }
    ///Creates an instance of organizations-apiMemberSubjectUser with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (email: string, id: string, name: string, two_factor_authentication_enabled: bool): ``organizations-apiMemberSubjectUser`` =
        { email = email
          id = id
          name = name
          two_factor_authentication_enabled = two_factor_authentication_enabled }

type Parent =
    { id: ``organizations-apiOrganizationID``
      name: string }
    ///Creates an instance of Parent with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``organizations-apiOrganizationID``, name: string): Parent = { id = id; name = name }

///References an Organization in the Cloudflare data model.
type ``organizations-apiOrganization`` =
    { create_time: System.DateTimeOffset
      id: obj
      meta: Map<string, string>
      name: string
      parent: Option<Parent>
      profile: Option<``organizations-apiProfile``> }
    ///Creates an instance of organizations-apiOrganization with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (create_time: System.DateTimeOffset,
                          id: obj,
                          meta: Map<string, string>,
                          name: string): ``organizations-apiOrganization`` =
        { create_time = create_time
          id = id
          meta = meta
          name = name
          parent = None
          profile = None }

///Enable features for Organizations.
type ``organizations-apiOrganizationFlags`` =
    { account_creation: string
      account_deletion: string
      account_migration: string
      account_mobility: string
      sub_org_creation: string }
    ///Creates an instance of organizations-apiOrganizationFlags with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (account_creation: string,
                          account_deletion: string,
                          account_migration: string,
                          account_mobility: string,
                          sub_org_creation: string): ``organizations-apiOrganizationFlags`` =
        { account_creation = account_creation
          account_deletion = account_deletion
          account_migration = account_migration
          account_mobility = account_mobility
          sub_org_creation = sub_org_creation }

type ``organizations-apiPageTokenResultInfo`` =
    { ///Use this opaque token in the next request to retrieve the
      ///next page.
      ///Parameters used to filter the retrieved list must remain in subsequent
      ///requests with a page token.
      next_page_token: Option<string>
      ///Counts the total amount of items in a list with the applied filters. The API omits next_page_token to indicate no more items in a particular list.
      total_size: Option<int> }
    ///Creates an instance of organizations-apiPageTokenResultInfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``organizations-apiPageTokenResultInfo`` =
        { next_page_token = None
          total_size = None }

type ``organizations-apiProfile`` =
    { business_address: string
      business_email: string
      business_name: string
      business_phone: string
      external_metadata: string }
    ///Creates an instance of organizations-apiProfile with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (business_address: string,
                          business_email: string,
                          business_name: string,
                          business_phone: string,
                          external_metadata: string): ``organizations-apiProfile`` =
        { business_address = business_address
          business_email = business_email
          business_name = business_name
          business_phone = business_phone
          external_metadata = external_metadata }

type ``organizations-apiProfileResponse`` =
    { errors: obj
      messages: list<``organizations-apiV4Message``>
      result: ``organizations-apiProfile``
      success: bool }
    ///Creates an instance of organizations-apiProfileResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: obj,
                          messages: list<``organizations-apiV4Message``>,
                          result: ``organizations-apiProfile``,
                          success: bool): ``organizations-apiProfileResponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``organizations-apiV4ErrorResponse`` =
    { errors: list<``organizations-apiV4Message``>
      messages: list<``organizations-apiV4Message``>
      result: Option<obj>
      success: bool }
    ///Creates an instance of organizations-apiV4ErrorResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``organizations-apiV4Message``>,
                          messages: list<``organizations-apiV4Message``>,
                          success: bool): ``organizations-apiV4ErrorResponse`` =
        { errors = errors
          messages = messages
          result = None
          success = success }

type ``organizations-apiV4Message`` =
    { code: int
      message: string }
    ///Creates an instance of organizations-apiV4Message with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``organizations-apiV4Message`` =
        { code = code; message = message }

type ``resource-sharingapi-response-collection`` =
    { errors: Option<``resource-sharingv4errors``>
      result: Option<obj>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``resource-sharingresultinfo``> }
    ///Creates an instance of resource-sharingapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``resource-sharingapi-response-collection`` =
        { errors = None
          result = None
          success = None
          result_info = None }

type ``resource-sharingapi-response-common`` =
    { errors: ``resource-sharingv4errors``
      result: Option<obj>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of resource-sharingapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: ``resource-sharingv4errors``, success: bool): ``resource-sharingapi-response-common`` =
        { errors = errors
          result = None
          success = success }

type ``resource-sharingapi-response-common-failure`` =
    { errors: obj
      result: obj
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of resource-sharingapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: obj, result: obj, success: bool): ``resource-sharingapi-response-common-failure`` =
        { errors = errors
          result = result
          success = success }

type ``resource-sharingresultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float>
      ///Total number of pages using the given per page.
      total_pages: Option<float> }
    ///Creates an instance of resource-sharingresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``resource-sharingresultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None
          total_pages = None }

type ``resource-sharingshareobject`` =
    { ///Account identifier.
      account_id: ``resource-sharingaccountid``
      ///The display name of an account.
      account_name: ``resource-sharingaccountname``
      ///The number of recipients in the 'associated' state. This field is only included when requested via the 'include_recipient_counts' parameter.
      associated_recipient_count: Option<int>
      ///The number of recipients in the 'associating' state. This field is only included when requested via the 'include_recipient_counts' parameter.
      associating_recipient_count: Option<int>
      ///When the share was created.
      created: ``resource-sharingcreated``
      ///The number of recipients in the 'disassociated' state. This field is only included when requested via the 'include_recipient_counts' parameter.
      disassociated_recipient_count: Option<int>
      ///The number of recipients in the 'disassociating' state. This field is only included when requested via the 'include_recipient_counts' parameter.
      disassociating_recipient_count: Option<int>
      ///Share identifier tag.
      id: ``resource-sharingshareid``
      kind: Option<``resource-sharingsharekind``>
      ///When the share was modified.
      modified: ``resource-sharingmodified``
      ///The name of the share.
      name: ``resource-sharingsharename``
      ///Organization identifier.
      organization_id: ``resource-sharingorganizationid``
      ///A list of resources that are part of the share. This field is only included when requested via the 'include_resources' parameter.
      resources: Option<list<``resource-sharingshareresourceobject``>>
      status: ``resource-sharingsharestatus``
      target_type: ``resource-sharingsharetargettype`` }
    ///Creates an instance of resource-sharingshareobject with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (account_id: ``resource-sharingaccountid``,
                          account_name: ``resource-sharingaccountname``,
                          created: ``resource-sharingcreated``,
                          id: ``resource-sharingshareid``,
                          modified: ``resource-sharingmodified``,
                          name: ``resource-sharingsharename``,
                          organization_id: ``resource-sharingorganizationid``,
                          status: ``resource-sharingsharestatus``,
                          target_type: ``resource-sharingsharetargettype``): ``resource-sharingshareobject`` =
        { account_id = account_id
          account_name = account_name
          associated_recipient_count = None
          associating_recipient_count = None
          created = created
          disassociated_recipient_count = None
          disassociating_recipient_count = None
          id = id
          kind = None
          modified = modified
          name = name
          organization_id = organization_id
          resources = None
          status = status
          target_type = target_type }

type ``resource-sharingshareresourceobject`` =
    { ///When the share was created.
      created: ``resource-sharingcreated``
      ///Share Resource identifier.
      id: ``resource-sharingresourceid``
      ///Resource Metadata.
      meta: obj
      ///When the share was modified.
      modified: ``resource-sharingmodified``
      ///Account identifier.
      resource_account_id: ``resource-sharingaccountid``
      ///Share Resource identifier.
      resource_id: ``resource-sharingresourceresourceid``
      ///Resource Type.
      resource_type: ``resource-sharingresourcetype``
      ///Resource Version.
      resource_version: ``resource-sharingresourceversion``
      ///Resource Status.
      status: ``resource-sharingresourcestatus`` }
    ///Creates an instance of resource-sharingshareresourceobject with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (created: ``resource-sharingcreated``,
                          id: ``resource-sharingresourceid``,
                          meta: obj,
                          modified: ``resource-sharingmodified``,
                          resource_account_id: ``resource-sharingaccountid``,
                          resource_id: ``resource-sharingresourceresourceid``,
                          resource_type: ``resource-sharingresourcetype``,
                          resource_version: ``resource-sharingresourceversion``,
                          status: ``resource-sharingresourcestatus``): ``resource-sharingshareresourceobject`` =
        { created = created
          id = id
          meta = meta
          modified = modified
          resource_account_id = resource_account_id
          resource_id = resource_id
          resource_type = resource_type
          resource_version = resource_version
          status = status }

type ``resource-sharingshareresponsecollection`` =
    { errors: ``resource-sharingv4errors``
      result: Option<list<``resource-sharingshareobject``>>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<``resource-sharingresultinfo``> }
    ///Creates an instance of resource-sharingshareresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: ``resource-sharingv4errors``, success: bool): ``resource-sharingshareresponsecollection`` =
        { errors = errors
          result = None
          success = success
          result_info = None }

type ``resource-sharingv4error`` =
    { code: int
      message: string }
    ///Creates an instance of resource-sharingv4error with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``resource-sharingv4error`` = { code = code; message = message }

type OrganizationListOrganizations_OK =
    { errors: obj
      messages: list<``organizations-apiV4Message``>
      result: list<``organizations-apiOrganization``>
      result_info: ``organizations-apiPageTokenResultInfo``
      success: bool }

[<RequireQualifiedAccess>]
type OrganizationListOrganizations =
    ///The request has succeeded.
    | OK of payload: OrganizationListOrganizations_OK
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

type OrganizationsCreateUserOrganization_OK =
    { errors: obj
      messages: list<``organizations-apiV4Message``>
      ///References an Organization in the Cloudflare data model.
      result: ``organizations-apiOrganization``
      success: bool }

[<RequireQualifiedAccess>]
type OrganizationsCreateUserOrganization =
    ///The request has succeeded.
    | OK of payload: OrganizationsCreateUserOrganization_OK
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

type OrganizationsDelete_OK =
    { errors: obj
      messages: list<``organizations-apiV4Message``>
      result: ``organizations-apiDeleteOrganizationResponse``
      success: bool }

[<RequireQualifiedAccess>]
type OrganizationsDelete =
    ///The request has succeeded.
    | OK of payload: OrganizationsDelete_OK
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

type OrganizationsRetrieve_OK =
    { errors: obj
      messages: list<``organizations-apiV4Message``>
      ///References an Organization in the Cloudflare data model.
      result: ``organizations-apiOrganization``
      success: bool }

[<RequireQualifiedAccess>]
type OrganizationsRetrieve =
    ///The request has succeeded.
    | OK of payload: OrganizationsRetrieve_OK
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

type OrganizationsModify_OK =
    { errors: obj
      messages: list<``organizations-apiV4Message``>
      ///References an Organization in the Cloudflare data model.
      result: ``organizations-apiOrganization``
      success: bool }

[<RequireQualifiedAccess>]
type OrganizationsModify =
    ///The request has succeeded.
    | OK of payload: OrganizationsModify_OK
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

type OrganizationsGetAccounts_OK =
    { errors: obj
      messages: list<``organizations-apiV4Message``>
      result: list<``organizations-apiAccount``>
      result_info: ``organizations-apiPageTokenResultInfo``
      success: bool }

[<RequireQualifiedAccess>]
type OrganizationsGetAccounts =
    ///The request has succeeded.
    | OK of payload: OrganizationsGetAccounts_OK
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

[<RequireQualifiedAccess>]
type AuditLogsV2GetOrganizationAuditLogs =
    ///Get organization audit logs successful response
    | OK of payload: ``aaaaudit-logs-v2-org-response-collection``
    ///Get organization audit logs failed response
    | BadRequest of payload: ``aaaschemas-api-response-common-failure``

type MembersList_OK =
    { errors: obj
      messages: list<``organizations-apiV4Message``>
      result: list<``organizations-apiMember``>
      result_info: ``organizations-apiPageTokenResultInfo``
      success: bool }

[<RequireQualifiedAccess>]
type MembersList =
    ///The request has succeeded.
    | OK of payload: MembersList_OK
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

type MembersCreate_OK =
    { errors: obj
      messages: list<``organizations-apiV4Message``>
      result: ``organizations-apiMember``
      success: bool }

[<RequireQualifiedAccess>]
type MembersCreate =
    ///The request has succeeded.
    | OK of payload: MembersCreate_OK
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

type MembersDeletePayload =
    { ///Organization Member ID
      member_id: ``organizations-apiMemberID`` }
    ///Creates an instance of MembersDeletePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (member_id: ``organizations-apiMemberID``): MembersDeletePayload = { member_id = member_id }

[<RequireQualifiedAccess>]
type MembersDelete =
    ///There is no content to send for this request, but the headers may be useful.
    | NoContent of payload: obj
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

type MembersRetrieve_OK =
    { errors: obj
      messages: list<``organizations-apiV4Message``>
      result: ``organizations-apiMember``
      success: bool }

[<RequireQualifiedAccess>]
type MembersRetrieve =
    ///The request has succeeded.
    | OK of payload: MembersRetrieve_OK
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

type MembersBatchCreate_OK =
    { errors: obj
      messages: list<``organizations-apiV4Message``>
      result: list<``organizations-apiMember``>
      success: bool }

[<RequireQualifiedAccess>]
type MembersBatchCreate =
    ///The request has succeeded.
    | OK of payload: MembersBatchCreate_OK
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

[<RequireQualifiedAccess>]
type OrganizationsGetProfile =
    ///The request has succeeded.
    | OK of payload: ``organizations-apiProfileResponse``
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

[<RequireQualifiedAccess>]
type OrganizationsModifyProfile =
    ///There is no content to send for this request, but the headers may be useful.
    | NoContent of payload: obj
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

[<RequireQualifiedAccess>]
type OrganizationSharesList =
    ///List organization shares response.
    | OK of payload: ``resource-sharingshareresponsecollection``
    ///List organization shares response failure.
    | BadRequest of payload: string
    ///List organization shares response failure.
    | InternalServerError of payload: string

[<RequireQualifiedAccess>]
type User'SOrganizationsListOrganizations =
    ///List Organizations response
    | OK of payload: iamcollectionorganizationresponse
    ///List Organizations response failure
    | BadRequest of payload: ``iamapi-response-common-failure``

type User'SOrganizationsLeaveOrganization_OK =
    { ///Identifier
      id: Option<``iamcommoncomponents-schemas-identifier``> }

[<RequireQualifiedAccess>]
type User'SOrganizationsLeaveOrganization =
    ///Leave Organization response
    | OK of payload: User'SOrganizationsLeaveOrganization_OK
    ///Leave Organization response failure
    | BadRequest of payload: ``iamapi-response-common-failure``

[<RequireQualifiedAccess>]
type User'SOrganizationsOrganizationDetails =
    ///Organization Details response
    | OK of payload: iamsingleorganizationresponse
    ///Organization Details response failure
    | BadRequest of payload: ``iamapi-response-common-failure``
