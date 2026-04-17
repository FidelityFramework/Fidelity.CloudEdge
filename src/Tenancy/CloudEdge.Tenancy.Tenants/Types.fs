namespace rec Fidelity.CloudEdge.Tenancy.Tenants.Types

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

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``organizations-apiBoolAllocationType`` =
    | [<CompiledName "bool">] Bool
    member this.Format() =
        match this with
        | Bool -> "bool"

type ``organizations-apiBoolAllocation`` =
    { ``type``: ``organizations-apiBoolAllocationType``
      value: bool }
    ///Creates an instance of organizations-apiBoolAllocation with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: ``organizations-apiBoolAllocationType``, value: bool): ``organizations-apiBoolAllocation`` =
        { ``type`` = ``type``; value = value }

type ``organizations-apiEntitlement`` =
    { allocation: obj
      feature: ``organizations-apiFeature`` }
    ///Creates an instance of organizations-apiEntitlement with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (allocation: obj, feature: ``organizations-apiFeature``): ``organizations-apiEntitlement`` =
        { allocation = allocation
          feature = feature }

type ``organizations-apiFeature`` =
    { key: string }
    ///Creates an instance of organizations-apiFeature with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (key: string): ``organizations-apiFeature`` = { key = key }

type ``organizations-apiInnateEntitlements`` =
    { allow_add_subdomain: ``organizations-apiBoolAllocation``
      allow_auto_accept_invites: ``organizations-apiBoolAllocation``
      cname_setup_allowed: ``organizations-apiBoolAllocation``
      custom_entitlements: list<``organizations-apiEntitlement``>
      mhs_certificate_count: ``organizations-apiMaxCountAllocation``
      partial_setup_allowed: ``organizations-apiBoolAllocation`` }
    ///Creates an instance of organizations-apiInnateEntitlements with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (allow_add_subdomain: ``organizations-apiBoolAllocation``,
                          allow_auto_accept_invites: ``organizations-apiBoolAllocation``,
                          cname_setup_allowed: ``organizations-apiBoolAllocation``,
                          custom_entitlements: list<``organizations-apiEntitlement``>,
                          mhs_certificate_count: ``organizations-apiMaxCountAllocation``,
                          partial_setup_allowed: ``organizations-apiBoolAllocation``): ``organizations-apiInnateEntitlements`` =
        { allow_add_subdomain = allow_add_subdomain
          allow_auto_accept_invites = allow_auto_accept_invites
          cname_setup_allowed = cname_setup_allowed
          custom_entitlements = custom_entitlements
          mhs_certificate_count = mhs_certificate_count
          partial_setup_allowed = partial_setup_allowed }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``organizations-apiMaxCountAllocationType`` =
    | [<CompiledName "max_count">] Max_count
    member this.Format() =
        match this with
        | Max_count -> "max_count"

type ``organizations-apiMaxCountAllocation`` =
    { ``type``: ``organizations-apiMaxCountAllocationType``
      value: int }
    ///Creates an instance of organizations-apiMaxCountAllocation with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: ``organizations-apiMaxCountAllocationType``, value: int): ``organizations-apiMaxCountAllocation`` =
        { ``type`` = ``type``; value = value }

type ``organizations-apiNullAllocation`` =
    { value: Option<obj> }
    ///Creates an instance of organizations-apiNullAllocation with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``organizations-apiNullAllocation`` = { value = None }

type Tenantcontacts =
    { email: Option<string>
      website: Option<string> }
    ///Creates an instance of Tenantcontacts with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Tenantcontacts = { email = None; website = None }

type Nspool =
    { primary: Option<string>
      secondary: Option<string> }
    ///Creates an instance of Nspool with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Nspool = { primary = None; secondary = None }

type Dns =
    { ns_pool: Nspool }
    ///Creates an instance of Dns with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (ns_pool: Nspool): Dns = { ns_pool = ns_pool }

type Tenantmetadata =
    { dns: Option<Dns> }
    ///Creates an instance of Tenantmetadata with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Tenantmetadata = { dns = None }

type ``organizations-apiTenant`` =
    { cdate: System.DateTimeOffset
      customer_id: Option<string>
      edate: System.DateTimeOffset
      tenant_contacts: Tenantcontacts
      tenant_labels: list<string>
      tenant_metadata: Tenantmetadata
      tenant_name: string
      tenant_network: obj
      tenant_status: string
      tenant_tag: string
      tenant_type: string
      tenant_units: list<``organizations-apiTenantUnit``> }
    ///Creates an instance of organizations-apiTenant with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (cdate: System.DateTimeOffset,
                          edate: System.DateTimeOffset,
                          tenant_contacts: Tenantcontacts,
                          tenant_labels: list<string>,
                          tenant_metadata: Tenantmetadata,
                          tenant_name: string,
                          tenant_network: obj,
                          tenant_status: string,
                          tenant_tag: string,
                          tenant_type: string,
                          tenant_units: list<``organizations-apiTenantUnit``>): ``organizations-apiTenant`` =
        { cdate = cdate
          customer_id = None
          edate = edate
          tenant_contacts = tenant_contacts
          tenant_labels = tenant_labels
          tenant_metadata = tenant_metadata
          tenant_name = tenant_name
          tenant_network = tenant_network
          tenant_status = tenant_status
          tenant_tag = tenant_tag
          tenant_type = tenant_type
          tenant_units = tenant_units }

type ``organizations-apiTenantMembership`` =
    { user_email: string
      user_name: string
      user_tag: string }
    ///Creates an instance of organizations-apiTenantMembership with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (user_email: string, user_name: string, user_tag: string): ``organizations-apiTenantMembership`` =
        { user_email = user_email
          user_name = user_name
          user_tag = user_tag }

type ``organizations-apiTenantUnit`` =
    { unit_memberships: obj
      unit_metadata: obj
      unit_name: string
      unit_status: string
      unit_tag: string }
    ///Creates an instance of organizations-apiTenantUnit with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (unit_memberships: obj,
                          unit_metadata: obj,
                          unit_name: string,
                          unit_status: string,
                          unit_tag: string): ``organizations-apiTenantUnit`` =
        { unit_memberships = unit_memberships
          unit_metadata = unit_metadata
          unit_name = unit_name
          unit_status = unit_status
          unit_tag = unit_tag }

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

type TenantsRetrieveTenant_OK =
    { errors: obj
      messages: list<``organizations-apiV4Message``>
      result: ``organizations-apiTenant``
      success: bool }

[<RequireQualifiedAccess>]
type TenantsRetrieveTenant =
    ///The request has succeeded.
    | OK of payload: TenantsRetrieveTenant_OK
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

type TenantsValidAccountTypes_OK =
    { errors: obj
      messages: list<``organizations-apiV4Message``>
      result: list<string>
      success: bool }

[<RequireQualifiedAccess>]
type TenantsValidAccountTypes =
    ///The request has succeeded.
    | OK of payload: TenantsValidAccountTypes_OK
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

type TenantsListAccounts_OK =
    { errors: obj
      messages: list<``organizations-apiV4Message``>
      result: list<``organizations-apiAccount``>
      success: bool }

[<RequireQualifiedAccess>]
type TenantsListAccounts =
    ///The request has succeeded.
    | OK of payload: TenantsListAccounts_OK
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

type TenantsListEntitlements_OK =
    { errors: obj
      messages: list<``organizations-apiV4Message``>
      result: ``organizations-apiInnateEntitlements``
      success: bool }

[<RequireQualifiedAccess>]
type TenantsListEntitlements =
    ///The request has succeeded.
    | OK of payload: TenantsListEntitlements_OK
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``

type TenantsListMemberships_OK =
    { errors: obj
      messages: list<``organizations-apiV4Message``>
      result: list<``organizations-apiTenantMembership``>
      success: bool }

[<RequireQualifiedAccess>]
type TenantsListMemberships =
    ///The request has succeeded.
    | OK of payload: TenantsListMemberships_OK
    ///An unexpected error response.
    | BadRequest of payload: ``organizations-apiV4ErrorResponse``
