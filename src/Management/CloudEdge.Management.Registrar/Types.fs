namespace rec Fidelity.CloudEdge.Management.Registrar.Types

// Auto-generated stub types (missing from Hawaii output)
type authorization = string
type domain = string
type fully = string
type results = string

///Address.
type ``registrar-apiaddress`` = string
///Optional address line for unit, floor, suite, etc.
type ``registrar-apiaddress2`` = string
type ``registrar-apiautorenew`` = bool
type ``registrar-apiavailable`` = bool
type ``registrar-apicanregister`` = bool
///City.
type ``registrar-apicity`` = string
///Contact Identifier.
type ``registrar-apicontactidentifier`` = string
///The country in which the user lives.
type ``registrar-apicountry`` = string
///Shows time of creation.
type ``registrar-apicreatedat`` = System.DateTimeOffset
///Shows name of current registrar.
type ``registrar-apicurrentregistrar`` = string
///Domain identifier.
type ``registrar-apidomainidentifier`` = string

///Fully qualified domain name (FQDN) including the extension
///(e.g., `example.com`, `mybrand.app`). The domain name uniquely
///identifies a registration — the same domain cannot be registered
///twice, making it a natural idempotency key for registration requests.
type ``registrar-apidomainname`` = string

///The contact email address of the user.
type ``registrar-apiemail`` = string
///Shows when domain name registration expires.
type ``registrar-apiexpiresat`` = System.DateTimeOffset
///Contact fax number.
type ``registrar-apifax`` = string
///User's first name
type ``registrar-apifirstname`` = string
///Identifier
type ``registrar-apiidentifier`` = string
///User's last name
type ``registrar-apilastname`` = string
type ``registrar-apilocked`` = bool

type ``registrar-apimessagesArrayItem`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apimessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apimessagesArrayItem`` =
        { code = code; message = message }

type ``registrar-apimessages`` = list<``registrar-apimessagesArrayItem``>
///Name of organization.
type ``registrar-apiorganization`` = string
type ``registrar-apiprivacy`` = bool
///A comma-separated list of registry status codes. A full list of status codes can be found at [EPP Status Codes](https://www.icann.org/resources/pages/epp-status-codes-2014-06-16-en).
type ``registrar-apiregistrystatuses`` = string
///State.
type ``registrar-apistate`` = string
type ``registrar-apisupportedtld`` = bool
///User's telephone number
type ``registrar-apitelephone`` = string
///Last updated.
type ``registrar-apiupdatedat`` = System.DateTimeOffset
///The zipcode or postal code where the user lives.
type ``registrar-apizipcode`` = string

type Errors =
    { code: int
      message: string }
    ///Creates an instance of Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Errors = { code = code; message = message }

type Messages =
    { code: int
      message: string }
    ///Creates an instance of Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Messages = { code = code; message = message }

type ``registrar-apiapi-response-collection`` =
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      result: Option<obj>
      ///Whether the API call was successful
      success: Option<bool>
      result_info: Option<``registrar-apiresultinfo``> }
    ///Creates an instance of registrar-apiapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``registrar-apiapi-response-collection`` =
        { errors = None
          messages = None
          result = None
          success = None
          result_info = None }

type ``registrar-apiapi-response-commonErrors`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apiapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apiapi-response-commonErrors`` =
        { code = code; message = message }

type ``registrar-apiapi-response-commonMessages`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apiapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apiapi-response-commonMessages`` =
        { code = code; message = message }

type ``registrar-apiapi-response-common`` =
    { errors: list<``registrar-apiapi-response-commonErrors``>
      messages: list<``registrar-apiapi-response-commonMessages``>
      result: obj
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of registrar-apiapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``registrar-apiapi-response-commonErrors``>,
                          messages: list<``registrar-apiapi-response-commonMessages``>,
                          result: obj,
                          success: bool): ``registrar-apiapi-response-common`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``registrar-apiapi-response-common-failure`` =
    { errors: list<Errors>
      messages: list<Messages>
      result: obj
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of registrar-apiapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<Errors>,
                          messages: list<Messages>,
                          result: obj,
                          success: bool): ``registrar-apiapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``registrar-apiapi-response-singleErrors`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apiapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apiapi-response-singleErrors`` =
        { code = code; message = message }

type ``registrar-apiapi-response-singleMessages`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apiapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apiapi-response-singleMessages`` =
        { code = code; message = message }

type ``registrar-apiapi-response-single`` =
    { errors: Option<list<``registrar-apiapi-response-singleErrors``>>
      messages: Option<list<``registrar-apiapi-response-singleMessages``>>
      result: Option<obj>
      ///Whether the API call was successful
      success: Option<bool> }
    ///Creates an instance of registrar-apiapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``registrar-apiapi-response-single`` =
        { errors = None
          messages = None
          result = None
          success = None }

type ``registrar-apicontactproperties`` =
    { ///Address.
      address: ``registrar-apiaddress``
      ///Optional address line for unit, floor, suite, etc.
      address2: Option<``registrar-apiaddress2``>
      ///City.
      city: ``registrar-apicity``
      ///The country in which the user lives.
      country: ``registrar-apicountry``
      ///The contact email address of the user.
      email: Option<``registrar-apiemail``>
      ///Contact fax number.
      fax: Option<``registrar-apifax``>
      ///User's first name
      first_name: ``registrar-apifirstname``
      ///Contact Identifier.
      id: Option<``registrar-apicontactidentifier``>
      ///User's last name
      last_name: ``registrar-apilastname``
      ///Name of organization.
      organization: ``registrar-apiorganization``
      ///User's telephone number
      phone: ``registrar-apitelephone``
      ///State.
      state: ``registrar-apistate``
      ///The zipcode or postal code where the user lives.
      zip: ``registrar-apizipcode`` }
    ///Creates an instance of registrar-apicontactproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (address: ``registrar-apiaddress``,
                          city: ``registrar-apicity``,
                          country: ``registrar-apicountry``,
                          first_name: ``registrar-apifirstname``,
                          last_name: ``registrar-apilastname``,
                          organization: ``registrar-apiorganization``,
                          phone: ``registrar-apitelephone``,
                          state: ``registrar-apistate``,
                          zip: ``registrar-apizipcode``): ``registrar-apicontactproperties`` =
        { address = address
          address2 = None
          city = city
          country = country
          email = None
          fax = None
          first_name = first_name
          id = None
          last_name = last_name
          organization = organization
          phone = phone
          state = state
          zip = zip }

type ``registrar-apicontacts`` =
    { ///Address.
      address: Option<``registrar-apiaddress``>
      ///Optional address line for unit, floor, suite, etc.
      address2: Option<``registrar-apiaddress2``>
      ///City.
      city: Option<``registrar-apicity``>
      ///The country in which the user lives.
      country: Option<``registrar-apicountry``>
      ///The contact email address of the user.
      email: Option<``registrar-apiemail``>
      ///Contact fax number.
      fax: Option<``registrar-apifax``>
      ///User's first name
      first_name: Option<``registrar-apifirstname``>
      ///Contact Identifier.
      id: Option<``registrar-apicontactidentifier``>
      ///User's last name
      last_name: Option<``registrar-apilastname``>
      ///Name of organization.
      organization: Option<``registrar-apiorganization``>
      ///User's telephone number
      phone: Option<``registrar-apitelephone``>
      ///State.
      state: Option<``registrar-apistate``>
      ///The zipcode or postal code where the user lives.
      zip: Option<``registrar-apizipcode``> }
    ///Creates an instance of registrar-apicontacts with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``registrar-apicontacts`` =
        { address = None
          address2 = None
          city = None
          country = None
          email = None
          fax = None
          first_name = None
          id = None
          last_name = None
          organization = None
          phone = None
          state = None
          zip = None }

///Cursor-based pagination metadata. Used by list endpoints that support
///cursor pagination. Pass the `cursor` value as a query parameter in the
///next request to fetch the next page. An empty string indicates there
///are no more pages.
type ``registrar-apicursorresultinfo`` =
    { ///Number of items in the current result set.
      count: int
      ///Opaque cursor for fetching the next page. Pass this value as the
      ///`cursor` query parameter in a subsequent request. An empty string
      ///indicates there are no more pages.
      cursor: string
      ///Maximum number of items per page.
      per_page: int }
    ///Creates an instance of registrar-apicursorresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: int, cursor: string, per_page: int): ``registrar-apicursorresultinfo`` =
        { count = count
          cursor = cursor
          per_page = per_page }

///Request body for checking domain availability.
type ``registrar-apidomaincheckrequest`` =
    { ///List of fully qualified domain names (FQDNs) to check for availability. Each domain must include the extension.
      ///- Minimum: 1 domain
      ///- Maximum: 20 domains per request
      ///- Domains on unsupported extensions are returned with `registrable: false` and a `reason` field
      ///- Malformed domain names (e.g., missing extension) may be omitted from the response
      domains: list<string> }
    ///Creates an instance of registrar-apidomaincheckrequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (domains: list<string>): ``registrar-apidomaincheckrequest`` = { domains = domains }

type ``registrar-apidomaincheckresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apidomaincheckresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apidomaincheckresponseErrors`` =
        { code = code; message = message }

type ``registrar-apidomaincheckresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apidomaincheckresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apidomaincheckresponseMessages`` =
        { code = code; message = message }

///Contains the availability check results.
type Result =
    { ///Array of domain availability results. Domains on unsupported
      ///extensions are included with `registrable: false` and a `reason`
      ///field. Malformed domain names may be omitted.
      domains: list<``registrar-apidomaincheckresult``> }
    ///Creates an instance of Result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (domains: list<``registrar-apidomaincheckresult``>): Result = { domains = domains }

type ``registrar-apidomaincheckresponse`` =
    { errors: list<``registrar-apidomaincheckresponseErrors``>
      messages: list<``registrar-apidomaincheckresponseMessages``>
      ///Contains the availability check results.
      result: Result
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of registrar-apidomaincheckresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``registrar-apidomaincheckresponseErrors``>,
                          messages: list<``registrar-apidomaincheckresponseMessages``>,
                          result: Result,
                          success: bool): ``registrar-apidomaincheckresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Reason =
    | [<CompiledName "extension_not_supported_via_api">] Extension_not_supported_via_api
    | [<CompiledName "extension_not_supported">] Extension_not_supported
    | [<CompiledName "extension_disallows_registration">] Extension_disallows_registration
    | [<CompiledName "domain_premium">] Domain_premium
    | [<CompiledName "domain_unavailable">] Domain_unavailable
    member this.Format() =
        match this with
        | Extension_not_supported_via_api -> "extension_not_supported_via_api"
        | Extension_not_supported -> "extension_not_supported"
        | Extension_disallows_registration -> "extension_disallows_registration"
        | Domain_premium -> "domain_premium"
        | Domain_unavailable -> "domain_unavailable"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Tier =
    | [<CompiledName "standard">] Standard
    | [<CompiledName "premium">] Premium
    member this.Format() =
        match this with
        | Standard -> "standard"
        | Premium -> "premium"

///Represents a single authoritative domain availability result returned by the Check endpoint. Check results reflect current registry status and should be used immediately before registration.
type ``registrar-apidomaincheckresult`` =
    { ///The fully qualified domain name (FQDN) in punycode format for internationalized domain names (IDNs).
      name: string
      ///Annual pricing information for a registrable domain. This object is only
      ///present when `registrable` is `true`. All prices are per year and returned
      ///as strings to preserve decimal precision.
      ///`registration_cost` and `renewal_cost` are frequently the same value, but
      ///may differ — especially for premium domains where registries set different
      ///rates for initial registration vs. renewal. For a multi-year registration
      ///(e.g., 4 years), the first year is charged at `registration_cost` and each
      ///subsequent year at `renewal_cost`. Registry pricing may change over time;
      ///the values returned here reflect the current registry rate. Premium pricing
      ///may be surfaced by Search and Check, but premium registration is not currently
      ///supported by this API.
      pricing: Option<``registrar-apipricing``>
      ///Present only when `registrable` is `false`. Explains why the domain cannot be registered via this API.
      ///- `extension_not_supported_via_api`: Cloudflare Registrar supports this extension in the dashboard but it is not yet available for programmatic registration via this API. The user can register via `https://dash.cloudflare.com/{account_id}/domains/registrations`.
      ///- `extension_not_supported`: This extension is not supported by Cloudflare Registrar at all.
      ///- `extension_disallows_registration`: The extension's registry has temporarily or permanently frozen new registrations. No registrar can register domains on this extension at this time.
      ///- `domain_premium`: The domain is premium priced. Premium registration is not currently supported by this API.
      ///- `domain_unavailable`: The domain is already registered, reserved, or otherwise not available on a supported extension.
      reason: Option<Reason>
      ///Indicates whether this domain can be registered programmatically through this API based on a real-time registry check.
      ///- `true`: Domain is available for registration. The `pricing` object will be included.
      ///- `false`: Domain is not available. See the `reason` field for why. `tier` may still be present on some non-registrable results, such as premium domains.
      registrable: bool
      ///The pricing tier for this domain. Always present when `registrable` is `true`; defaults to `standard` for most domains. May be absent when `registrable` is `false`.
      ///- `standard`: Standard registry pricing
      ///- `premium`: Premium domain with higher pricing set by the registry
      tier: Option<Tier> }
    ///Creates an instance of registrar-apidomaincheckresult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string, registrable: bool): ``registrar-apidomaincheckresult`` =
        { name = name
          pricing = None
          reason = None
          registrable = registrable
          tier = None }

type ``registrar-apidomainproperties`` =
    { ///Shows if a domain is available for transferring into Cloudflare Registrar.
      available: Option<``registrar-apiavailable``>
      ///Indicates if the domain can be registered as a new domain.
      can_register: Option<``registrar-apicanregister``>
      ///Shows time of creation.
      created_at: Option<``registrar-apicreatedat``>
      ///Shows name of current registrar.
      current_registrar: Option<``registrar-apicurrentregistrar``>
      ///Shows when domain name registration expires.
      expires_at: Option<``registrar-apiexpiresat``>
      ///Domain identifier.
      id: Option<``registrar-apidomainidentifier``>
      ///Shows whether a registrar lock is in place for a domain.
      locked: Option<``registrar-apilocked``>
      ///Shows contact information for domain registrant.
      registrant_contact: Option<obj>
      ///A comma-separated list of registry status codes. A full list of status codes can be found at [EPP Status Codes](https://www.icann.org/resources/pages/epp-status-codes-2014-06-16-en).
      registry_statuses: Option<``registrar-apiregistrystatuses``>
      ///Whether a particular TLD is currently supported by Cloudflare Registrar. Refer to [TLD Policies](https://www.cloudflare.com/tld-policies/) for a list of supported TLDs.
      supported_tld: Option<``registrar-apisupportedtld``>
      ///Statuses for domain transfers into Cloudflare Registrar.
      transfer_in: Option<obj>
      ///Last updated.
      updated_at: Option<``registrar-apiupdatedat``> }
    ///Creates an instance of registrar-apidomainproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``registrar-apidomainproperties`` =
        { available = None
          can_register = None
          created_at = None
          current_registrar = None
          expires_at = None
          id = None
          locked = None
          registrant_contact = None
          registry_statuses = None
          supported_tld = None
          transfer_in = None
          updated_at = None }

type ``registrar-apidomainresponsecollectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apidomainresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apidomainresponsecollectionErrors`` =
        { code = code; message = message }

type ``registrar-apidomainresponsecollectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apidomainresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apidomainresponsecollectionMessages`` =
        { code = code; message = message }

type ``registrar-apidomainresponsecollection`` =
    { errors: list<``registrar-apidomainresponsecollectionErrors``>
      messages: list<``registrar-apidomainresponsecollectionMessages``>
      result: list<``registrar-apidomains``>
      ///Whether the API call was successful
      success: bool
      result_info: Option<``registrar-apiresultinfo``> }
    ///Creates an instance of registrar-apidomainresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``registrar-apidomainresponsecollectionErrors``>,
                          messages: list<``registrar-apidomainresponsecollectionMessages``>,
                          result: list<``registrar-apidomains``>,
                          success: bool): ``registrar-apidomainresponsecollection`` =
        { errors = errors
          messages = messages
          result = result
          success = success
          result_info = None }

type ``registrar-apidomainresponsesingleErrors`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apidomainresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apidomainresponsesingleErrors`` =
        { code = code; message = message }

type ``registrar-apidomainresponsesingleMessages`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apidomainresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apidomainresponsesingleMessages`` =
        { code = code; message = message }

type ``registrar-apidomainresponsesingle`` =
    { errors: list<``registrar-apidomainresponsesingleErrors``>
      messages: list<``registrar-apidomainresponsesingleMessages``>
      result: Map<string, obj>
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of registrar-apidomainresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``registrar-apidomainresponsesingleErrors``>,
                          messages: list<``registrar-apidomainresponsesingleMessages``>,
                          result: Map<string, obj>,
                          success: bool): ``registrar-apidomainresponsesingle`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``registrar-apidomainsearchresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apidomainsearchresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apidomainsearchresponseErrors`` =
        { code = code; message = message }

type ``registrar-apidomainsearchresponseMessages`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apidomainsearchresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apidomainsearchresponseMessages`` =
        { code = code; message = message }

///Contains the search results.
type ``registrar-apidomainsearchresponseResult`` =
    { ///Array of domain suggestions sorted by relevance. May be empty if no domains match the search criteria.
      domains: list<``registrar-apidomainsearchresult``> }
    ///Creates an instance of registrar-apidomainsearchresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (domains: list<``registrar-apidomainsearchresult``>): ``registrar-apidomainsearchresponseResult`` =
        { domains = domains }

type ``registrar-apidomainsearchresponse`` =
    { errors: list<``registrar-apidomainsearchresponseErrors``>
      messages: list<``registrar-apidomainsearchresponseMessages``>
      ///Contains the search results.
      result: ``registrar-apidomainsearchresponseResult``
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of registrar-apidomainsearchresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``registrar-apidomainsearchresponseErrors``>,
                          messages: list<``registrar-apidomainsearchresponseMessages``>,
                          result: ``registrar-apidomainsearchresponseResult``,
                          success: bool): ``registrar-apidomainsearchresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``registrar-apidomainsearchresultReason`` =
    | [<CompiledName "extension_not_supported_via_api">] Extension_not_supported_via_api
    | [<CompiledName "extension_not_supported">] Extension_not_supported
    | [<CompiledName "extension_disallows_registration">] Extension_disallows_registration
    | [<CompiledName "domain_premium">] Domain_premium
    | [<CompiledName "domain_unavailable">] Domain_unavailable
    member this.Format() =
        match this with
        | Extension_not_supported_via_api -> "extension_not_supported_via_api"
        | Extension_not_supported -> "extension_not_supported"
        | Extension_disallows_registration -> "extension_disallows_registration"
        | Domain_premium -> "domain_premium"
        | Domain_unavailable -> "domain_unavailable"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``registrar-apidomainsearchresultTier`` =
    | [<CompiledName "standard">] Standard
    | [<CompiledName "premium">] Premium
    member this.Format() =
        match this with
        | Standard -> "standard"
        | Premium -> "premium"

///Represents a single domain suggestion returned by the Search endpoint. Search results are non-authoritative and may be based on cached data. Use POST /domain-check to confirm real-time availability and pricing before registration.
type ``registrar-apidomainsearchresult`` =
    { ///The fully qualified domain name (FQDN) in punycode format for internationalized domain names (IDNs).
      name: string
      ///Annual pricing information for a registrable domain. This object is only
      ///present when `registrable` is `true`. All prices are per year and returned
      ///as strings to preserve decimal precision.
      ///`registration_cost` and `renewal_cost` are frequently the same value, but
      ///may differ — especially for premium domains where registries set different
      ///rates for initial registration vs. renewal. For a multi-year registration
      ///(e.g., 4 years), the first year is charged at `registration_cost` and each
      ///subsequent year at `renewal_cost`. Registry pricing may change over time;
      ///the values returned here reflect the current registry rate. Premium pricing
      ///may be surfaced by Search and Check, but premium registration is not currently
      ///supported by this API.
      pricing: Option<``registrar-apipricing``>
      ///Present only when `registrable` is `false` on search results. Explains why the domain does not appear registrable through this API. These values are advisory; use POST /domain-check for authoritative status.
      ///- `extension_not_supported_via_api`: Cloudflare Registrar supports this extension in the dashboard but it is not yet available for programmatic registration via this API.
      ///- `extension_not_supported`: This extension is not supported by Cloudflare Registrar at all.
      ///- `extension_disallows_registration`: The extension's registry has temporarily or permanently frozen new registrations.
      ///- `domain_premium`: The domain is premium priced. Premium registration is not currently supported by this API.
      ///- `domain_unavailable`: The domain appears unavailable.
      reason: Option<``registrar-apidomainsearchresultReason``>
      ///Indicates whether this domain appears available based on search data. Search results are non-authoritative and may be stale. - `true`: The domain appears available. Use POST /domain-check to confirm before registration.
      ///- `false`: The domain does not appear available in search results.
      registrable: bool
      ///The pricing tier for this domain. Always present when `registrable` is `true`;
      ///defaults to `standard` for most domains. May be absent when `registrable`
      ///is `false`.
      ///- `standard`: Standard registry pricing
      ///- `premium`: Premium domain with higher pricing set by the registry
      tier: Option<``registrar-apidomainsearchresultTier``> }
    ///Creates an instance of registrar-apidomainsearchresult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string, registrable: bool): ``registrar-apidomainsearchresult`` =
        { name = name
          pricing = None
          reason = None
          registrable = registrable
          tier = None }

type ``registrar-apidomainupdateproperties`` =
    { ///Auto-renew controls whether subscription is automatically renewed upon domain expiration.
      auto_renew: Option<``registrar-apiautorenew``>
      ///Shows whether a registrar lock is in place for a domain.
      locked: Option<``registrar-apilocked``>
      ///Privacy option controls redacting WHOIS information.
      privacy: Option<``registrar-apiprivacy``> }
    ///Creates an instance of registrar-apidomainupdateproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``registrar-apidomainupdateproperties`` =
        { auto_renew = None
          locked = None
          privacy = None }

type ``registrar-apidomains`` =
    { ///Shows if a domain is available for transferring into Cloudflare Registrar.
      available: Option<``registrar-apiavailable``>
      ///Indicates if the domain can be registered as a new domain.
      can_register: Option<``registrar-apicanregister``>
      ///Shows time of creation.
      created_at: Option<``registrar-apicreatedat``>
      ///Shows name of current registrar.
      current_registrar: Option<``registrar-apicurrentregistrar``>
      ///Shows when domain name registration expires.
      expires_at: Option<``registrar-apiexpiresat``>
      ///Domain identifier.
      id: Option<``registrar-apidomainidentifier``>
      ///Shows whether a registrar lock is in place for a domain.
      locked: Option<``registrar-apilocked``>
      ///Shows contact information for domain registrant.
      registrant_contact: Option<obj>
      ///A comma-separated list of registry status codes. A full list of status codes can be found at [EPP Status Codes](https://www.icann.org/resources/pages/epp-status-codes-2014-06-16-en).
      registry_statuses: Option<``registrar-apiregistrystatuses``>
      ///Whether a particular TLD is currently supported by Cloudflare Registrar. Refer to [TLD Policies](https://www.cloudflare.com/tld-policies/) for a list of supported TLDs.
      supported_tld: Option<``registrar-apisupportedtld``>
      ///Statuses for domain transfers into Cloudflare Registrar.
      transfer_in: Option<obj>
      ///Last updated.
      updated_at: Option<``registrar-apiupdatedat``> }
    ///Creates an instance of registrar-apidomains with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``registrar-apidomains`` =
        { available = None
          can_register = None
          created_at = None
          current_registrar = None
          expires_at = None
          id = None
          locked = None
          registrant_contact = None
          registry_statuses = None
          supported_tld = None
          transfer_in = None
          updated_at = None }

///Annual pricing information for a registrable domain. This object is only
///present when `registrable` is `true`. All prices are per year and returned
///as strings to preserve decimal precision.
///`registration_cost` and `renewal_cost` are frequently the same value, but
///may differ — especially for premium domains where registries set different
///rates for initial registration vs. renewal. For a multi-year registration
///(e.g., 4 years), the first year is charged at `registration_cost` and each
///subsequent year at `renewal_cost`. Registry pricing may change over time;
///the values returned here reflect the current registry rate. Premium pricing
///may be surfaced by Search and Check, but premium registration is not currently
///supported by this API.
type ``registrar-apipricing`` =
    { ///ISO-4217 currency code for the prices (e.g., "USD", "EUR", "GBP").
      currency: string
      ///The first-year cost to register this domain. For premium domains
      ///(`tier: premium`), this price is set by the registry and may be
      ///significantly higher than standard pricing. For multi-year
      ///registrations, this cost applies to the first year only; subsequent
      ///years are charged at `renewal_cost`.
      registration_cost: string
      ///Per-year renewal cost for this domain. Applied to each year beyond
      ///the first year of a multi-year registration, and to each annual
      ///auto-renewal thereafter. May differ from `registration_cost`,
      ///especially for premium domains where initial registration often
      ///costs more than renewals.
      renewal_cost: string }
    ///Creates an instance of registrar-apipricing with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (currency: string, registration_cost: string, renewal_cost: string): ``registrar-apipricing`` =
        { currency = currency
          registration_cost = registration_cost
          renewal_cost = renewal_cost }

///Shows contact information for domain registrant.
type ``registrar-apiregistrantcontact`` =
    { ///Address.
      address: Option<``registrar-apiaddress``>
      ///Optional address line for unit, floor, suite, etc.
      address2: Option<``registrar-apiaddress2``>
      ///City.
      city: Option<``registrar-apicity``>
      ///The country in which the user lives.
      country: Option<``registrar-apicountry``>
      ///The contact email address of the user.
      email: Option<``registrar-apiemail``>
      ///Contact fax number.
      fax: Option<``registrar-apifax``>
      ///User's first name
      first_name: Option<``registrar-apifirstname``>
      ///Contact Identifier.
      id: Option<``registrar-apicontactidentifier``>
      ///User's last name
      last_name: Option<``registrar-apilastname``>
      ///Name of organization.
      organization: Option<``registrar-apiorganization``>
      ///User's telephone number
      phone: Option<``registrar-apitelephone``>
      ///State.
      state: Option<``registrar-apistate``>
      ///The zipcode or postal code where the user lives.
      zip: Option<``registrar-apizipcode``> }
    ///Creates an instance of registrar-apiregistrantcontact with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``registrar-apiregistrantcontact`` =
        { address = None
          address2 = None
          city = None
          country = None
          email = None
          fax = None
          first_name = None
          id = None
          last_name = None
          organization = None
          phone = None
          state = None
          zip = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Privacymode =
    | [<CompiledName "false">] False
    | [<CompiledName "redaction">] Redaction
    member this.Format() =
        match this with
        | False -> "false"
        | Redaction -> "redaction"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Status =
    | [<CompiledName "active">] Active
    | [<CompiledName "registration_pending">] Registration_pending
    | [<CompiledName "expired">] Expired
    | [<CompiledName "suspended">] Suspended
    | [<CompiledName "redemption_period">] Redemption_period
    | [<CompiledName "pending_delete">] Pending_delete
    member this.Format() =
        match this with
        | Active -> "active"
        | Registration_pending -> "registration_pending"
        | Expired -> "expired"
        | Suspended -> "suspended"
        | Redemption_period -> "redemption_period"
        | Pending_delete -> "pending_delete"

///A domain registration resource representing the current state of a registered domain.
type ``registrar-apiregistration`` =
    { ///Whether the domain will be automatically renewed before expiration.
      auto_renew: bool
      ///When the domain was registered. Present when the registration resource exists.
      created_at: System.DateTimeOffset
      ///Fully qualified domain name (FQDN) including the extension
      ///(e.g., `example.com`, `mybrand.app`). The domain name uniquely
      ///identifies a registration — the same domain cannot be registered
      ///twice, making it a natural idempotency key for registration requests.
      domain_name: ``registrar-apidomainname``
      ///When the domain registration expires. Present when the registration is ready; may be null only while `status` is `registration_pending`.
      expires_at: System.DateTimeOffset
      ///Whether the domain is locked for transfer.
      locked: bool
      ///Current WHOIS privacy mode for the registration.
      privacy_mode: Privacymode
      ///Current registration status.
      ///- `active`: Domain is registered and operational
      ///- `registration_pending`: Registration is in progress
      ///- `expired`: Domain has expired
      ///- `suspended`: Domain is suspended by the registry
      ///- `redemption_period`: Domain is in the redemption grace period
      ///- `pending_delete`: Domain is pending deletion by the registry
      status: Status }
    ///Creates an instance of registrar-apiregistration with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (auto_renew: bool,
                          created_at: System.DateTimeOffset,
                          domain_name: ``registrar-apidomainname``,
                          expires_at: System.DateTimeOffset,
                          locked: bool,
                          privacy_mode: Privacymode,
                          status: Status): ``registrar-apiregistration`` =
        { auto_renew = auto_renew
          created_at = created_at
          domain_name = domain_name
          expires_at = expires_at
          locked = locked
          privacy_mode = privacy_mode
          status = status }

type ``registrar-apiregistration-response-collectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apiregistration-response-collectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apiregistration-response-collectionErrors`` =
        { code = code; message = message }

type ``registrar-apiregistration-response-collectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apiregistration-response-collectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apiregistration-response-collectionMessages`` =
        { code = code; message = message }

type ``registrar-apiregistration-response-collection`` =
    { errors: list<``registrar-apiregistration-response-collectionErrors``>
      messages: list<``registrar-apiregistration-response-collectionMessages``>
      result: list<``registrar-apiregistration``>
      ///Whether the API call was successful
      success: bool
      ///Cursor-based pagination metadata. Used by list endpoints that support
      ///cursor pagination. Pass the `cursor` value as a query parameter in the
      ///next request to fetch the next page. An empty string indicates there
      ///are no more pages.
      result_info: ``registrar-apicursorresultinfo`` }
    ///Creates an instance of registrar-apiregistration-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``registrar-apiregistration-response-collectionErrors``>,
                          messages: list<``registrar-apiregistration-response-collectionMessages``>,
                          result: list<``registrar-apiregistration``>,
                          success: bool,
                          result_info: ``registrar-apicursorresultinfo``): ``registrar-apiregistration-response-collection`` =
        { errors = errors
          messages = messages
          result = result
          success = success
          result_info = result_info }

type ``registrar-apiregistration-response-singleErrors`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apiregistration-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apiregistration-response-singleErrors`` =
        { code = code; message = message }

type ``registrar-apiregistration-response-singleMessages`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apiregistration-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apiregistration-response-singleMessages`` =
        { code = code; message = message }

type ``registrar-apiregistration-response-single`` =
    { errors: list<``registrar-apiregistration-response-singleErrors``>
      messages: list<``registrar-apiregistration-response-singleMessages``>
      ///A domain registration resource representing the current state of a registered domain.
      result: ``registrar-apiregistration``
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of registrar-apiregistration-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``registrar-apiregistration-response-singleErrors``>,
                          messages: list<``registrar-apiregistration-response-singleMessages``>,
                          result: ``registrar-apiregistration``,
                          success: bool): ``registrar-apiregistration-response-single`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

///Registrant contact data for the domain registration. This information
///is submitted to the domain registry and, depending on extension and
///privacy settings, may appear in public WHOIS records.
type ``registrar-apiregistrationcontact`` =
    { ///Email address for the registrant. Used for domain-related
      ///communications from the registry, including ownership verification
      ///and renewal notices.
      email: string
      ///Fax number in E.164 format (e.g., `+1.5555555555`). Optional.
      ///Most registrations do not require a fax number.
      fax: Option<string>
      ///Phone number in E.164 format: `+{country_code}.{number}` with no
      ///spaces or dashes. Examples: `+1.5555555555` (US), `+44.2071234567`
      ///(UK), `+81.312345678` (Japan).
      phone: string
      ///Postal/mailing information for the registrant contact.
      postal_info: ``registrar-apiregistrationcontactpostalinfo`` }
    ///Creates an instance of registrar-apiregistrationcontact with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (email: string, phone: string, postal_info: ``registrar-apiregistrationcontactpostalinfo``): ``registrar-apiregistrationcontact`` =
        { email = email
          fax = None
          phone = phone
          postal_info = postal_info }

///Physical mailing address for the registrant contact.
type ``registrar-apiregistrationcontactaddress`` =
    { ///City or locality name.
      city: string
      ///Two-letter country code per ISO 3166-1 alpha-2 (e.g., `US`, `GB`, `CA`, `DE`).
      country_code: string
      ///Postal or ZIP code.
      postal_code: string
      ///State, province, or region. Use the standard abbreviation where applicable (e.g., `TX` for Texas, `ON` for Ontario).
      state: string
      ///Street address including building/suite number.
      street: string }
    ///Creates an instance of registrar-apiregistrationcontactaddress with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (city: string, country_code: string, postal_code: string, state: string, street: string): ``registrar-apiregistrationcontactaddress`` =
        { city = city
          country_code = country_code
          postal_code = postal_code
          state = state
          street = street }

///Postal/mailing information for the registrant contact.
type ``registrar-apiregistrationcontactpostalinfo`` =
    { ///Physical mailing address for the registrant contact.
      address: ``registrar-apiregistrationcontactaddress``
      ///Full legal name of the registrant (individual or authorized representative).
      name: string
      ///Organization or company name. Optional for individual registrants.
      organization: Option<string> }
    ///Creates an instance of registrar-apiregistrationcontactpostalinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (address: ``registrar-apiregistrationcontactaddress``, name: string): ``registrar-apiregistrationcontactpostalinfo`` =
        { address = address
          name = name
          organization = None }

///Contact data for the registration request.
///If the `contacts` object is omitted entirely from the request, or if
///`contacts.registrant` is not provided, the system will use the account's
///default address book entry as the registrant contact. This default must be
///pre-configured by the account owner at
///`https://dash.cloudflare.com/{account_id}/domains/registrations`, where
///they can create or update the address book entry and accept the required
///agreement. No API exists for managing address book entries at this time.
///If no default address book entry exists and no registrant contact is
///provided, the registration request will fail with a validation error.
type ``registrar-apiregistrationcontacts`` =
    { ///Registrant contact data for the domain registration. This information
      ///is submitted to the domain registry and, depending on extension and
      ///privacy settings, may appear in public WHOIS records.
      registrant: Option<``registrar-apiregistrationcontact``> }
    ///Creates an instance of registrar-apiregistrationcontacts with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``registrar-apiregistrationcontacts`` = { registrant = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``registrar-apiregistrationcreaterequestPrivacymode`` =
    | [<CompiledName "false">] False
    | [<CompiledName "redaction">] Redaction
    member this.Format() =
        match this with
        | False -> "false"
        | Redaction -> "redaction"

type ``registrar-apiregistrationcreaterequest`` =
    { ///Enable or disable automatic renewal. Defaults to `false` if omitted.
      ///Setting this field to `true` is an explicit opt-in authorizing
      ///Cloudflare to charge the account's default payment method up to 30
      ///days before domain expiry to renew the domain automatically.
      ///Renewal pricing may change over time based on registry pricing.
      auto_renew: Option<bool>
      ///Contact data for the registration request.
      ///If the `contacts` object is omitted entirely from the request, or if
      ///`contacts.registrant` is not provided, the system will use the account's
      ///default address book entry as the registrant contact. This default must be
      ///pre-configured by the account owner at
      ///`https://dash.cloudflare.com/{account_id}/domains/registrations`, where
      ///they can create or update the address book entry and accept the required
      ///agreement. No API exists for managing address book entries at this time.
      ///If no default address book entry exists and no registrant contact is
      ///provided, the registration request will fail with a validation error.
      contacts: Option<``registrar-apiregistrationcontacts``>
      ///Fully qualified domain name (FQDN) including the extension
      ///(e.g., `example.com`, `mybrand.app`). The domain name uniquely
      ///identifies a registration — the same domain cannot be registered
      ///twice, making it a natural idempotency key for registration requests.
      domain_name: ``registrar-apidomainname``
      ///WHOIS privacy mode for the registration. Defaults to `redaction`.
      ///- `off`: Do not request WHOIS privacy.
      ///- `redaction`: Request WHOIS redaction where supported by the extension.
      ///  Some extensions do not support privacy/redaction.
      privacy_mode: Option<``registrar-apiregistrationcreaterequestPrivacymode``>
      ///Number of years to register (1–10). If omitted, defaults to the
      ///minimum registration period required by the registry for this
      ///extension. For most extensions this is 1 year, but some extensions
      ///require longer minimum terms (e.g., `.ai` requires a minimum of
      ///2 years).
      ///The registry for each extension may also enforce its own maximum
      ///registration term. If the requested value exceeds the registry's
      ///maximum, the registration will be rejected. When in doubt, use the
      ///default by omitting this field.
      years: Option<int> }
    ///Creates an instance of registrar-apiregistrationcreaterequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (domain_name: ``registrar-apidomainname``): ``registrar-apiregistrationcreaterequest`` =
        { auto_renew = None
          contacts = None
          domain_name = domain_name
          privacy_mode = None
          years = None }

///Request to update an existing domain registration.
///This endpoint currently supports updating `auto_renew` only.
type ``registrar-apiregistrationupdaterequest`` =
    { ///Enable or disable automatic renewal.
      ///Setting this field to `true` authorizes Cloudflare to charge the
      ///account's default payment method up to 30 days before domain expiry
      ///to renew the domain automatically. Renewal pricing may change over
      ///time based on registry pricing.
      auto_renew: Option<bool> }
    ///Creates an instance of registrar-apiregistrationupdaterequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``registrar-apiregistrationupdaterequest`` = { auto_renew = None }

type ``registrar-apiresultinfo`` =
    { ///Total number of results for the requested service
      count: Option<float>
      ///Current page within paginated list of results
      page: Option<float>
      ///Number of results per page of results
      per_page: Option<float>
      ///Total results available without any search parameters
      total_count: Option<float> }
    ///Creates an instance of registrar-apiresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``registrar-apiresultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Acceptfoa =
    | [<CompiledName "needed">] Needed
    | [<CompiledName "ok">] Ok
    member this.Format() =
        match this with
        | Needed -> "needed"
        | Ok -> "ok"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Approvetransfer =
    | [<CompiledName "needed">] Needed
    | [<CompiledName "ok">] Ok
    | [<CompiledName "pending">] Pending
    | [<CompiledName "trying">] Trying
    | [<CompiledName "rejected">] Rejected
    | [<CompiledName "unknown">] Unknown
    member this.Format() =
        match this with
        | Needed -> "needed"
        | Ok -> "ok"
        | Pending -> "pending"
        | Trying -> "trying"
        | Rejected -> "rejected"
        | Unknown -> "unknown"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Disableprivacy =
    | [<CompiledName "needed">] Needed
    | [<CompiledName "ok">] Ok
    | [<CompiledName "unknown">] Unknown
    member this.Format() =
        match this with
        | Needed -> "needed"
        | Ok -> "ok"
        | Unknown -> "unknown"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Enterauthcode =
    | [<CompiledName "needed">] Needed
    | [<CompiledName "ok">] Ok
    | [<CompiledName "pending">] Pending
    | [<CompiledName "trying">] Trying
    | [<CompiledName "rejected">] Rejected
    member this.Format() =
        match this with
        | Needed -> "needed"
        | Ok -> "ok"
        | Pending -> "pending"
        | Trying -> "trying"
        | Rejected -> "rejected"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Unlockdomain =
    | [<CompiledName "needed">] Needed
    | [<CompiledName "ok">] Ok
    | [<CompiledName "pending">] Pending
    | [<CompiledName "trying">] Trying
    | [<CompiledName "unknown">] Unknown
    member this.Format() =
        match this with
        | Needed -> "needed"
        | Ok -> "ok"
        | Pending -> "pending"
        | Trying -> "trying"
        | Unknown -> "unknown"

///Statuses for domain transfers into Cloudflare Registrar.
type ``registrar-apitransferin`` =
    { ///Form of authorization has been accepted by the registrant.
      accept_foa: Option<Acceptfoa>
      ///Shows transfer status with the registry.
      approve_transfer: Option<Approvetransfer>
      ///Indicates if cancellation is still possible.
      can_cancel_transfer: Option<bool>
      ///Privacy guards are disabled at the foreign registrar.
      disable_privacy: Option<Disableprivacy>
      ///Auth code has been entered and verified.
      enter_auth_code: Option<Enterauthcode>
      ///Domain is unlocked at the foreign registrar.
      unlock_domain: Option<Unlockdomain> }
    ///Creates an instance of registrar-apitransferin with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``registrar-apitransferin`` =
        { accept_foa = None
          approve_transfer = None
          can_cancel_transfer = None
          disable_privacy = None
          enter_auth_code = None
          unlock_domain = None }

type ``registrar-apiworkflow-status-response-singleErrors`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apiworkflow-status-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apiworkflow-status-response-singleErrors`` =
        { code = code; message = message }

type ``registrar-apiworkflow-status-response-singleMessages`` =
    { code: int
      message: string }
    ///Creates an instance of registrar-apiworkflow-status-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``registrar-apiworkflow-status-response-singleMessages`` =
        { code = code; message = message }

type ``registrar-apiworkflow-status-response-single`` =
    { errors: list<``registrar-apiworkflow-status-response-singleErrors``>
      messages: list<``registrar-apiworkflow-status-response-singleMessages``>
      ///Status of an async registration workflow.
      result: ``registrar-apiworkflowstatus``
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of registrar-apiworkflow-status-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``registrar-apiworkflow-status-response-singleErrors``>,
                          messages: list<``registrar-apiworkflow-status-response-singleMessages``>,
                          result: ``registrar-apiworkflowstatus``,
                          success: bool): ``registrar-apiworkflow-status-response-single`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

///Error details when a workflow reaches the `failed` state. The specific
///error codes and messages depend on the workflow type (registration,
///update, etc.) and the underlying registry response. These workflow
///error codes are separate from immediate HTTP error `errors[].code`
///values returned by non-2xx responses. Surface
///`error.message` to the user for context.
type ``registrar-apiworkflowerror`` =
    { ///Machine-readable error code identifying the failure reason.
      code: string
      ///Human-readable explanation of the failure. May include registry-specific details.
      message: string }
    ///Creates an instance of registrar-apiworkflowerror with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: string, message: string): ``registrar-apiworkflowerror`` =
        { code = code; message = message }

type ``registrar-apiworkflowlinks`` =
    { ///URL to the domain resource.
      resource: Option<string>
      ///URL to this status resource.
      self: string }
    ///Creates an instance of registrar-apiworkflowlinks with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (self: string): ``registrar-apiworkflowlinks`` = { resource = None; self = self }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type State =
    | [<CompiledName "pending">] Pending
    | [<CompiledName "in_progress">] In_progress
    | [<CompiledName "action_required">] Action_required
    | [<CompiledName "blocked">] Blocked
    | [<CompiledName "succeeded">] Succeeded
    | [<CompiledName "failed">] Failed
    member this.Format() =
        match this with
        | Pending -> "pending"
        | In_progress -> "in_progress"
        | Action_required -> "action_required"
        | Blocked -> "blocked"
        | Succeeded -> "succeeded"
        | Failed -> "failed"

///Status of an async registration workflow.
type ``registrar-apiworkflowstatus`` =
    { ///Whether the workflow has reached a terminal state. `true` when
      ///`state` is `succeeded` or `failed`. `false` for `pending`,
      ///`in_progress`, `action_required`, and `blocked`.
      completed: bool
      ///Workflow-specific data for this workflow.
      ///The workflow subject is identified by `context.domain_name` for
      ///domain-centric workflows.
      context: Option<Map<string, obj>>
      created_at: System.DateTimeOffset
      error: Option<obj>
      links: ``registrar-apiworkflowlinks``
      ///Workflow lifecycle state.
      ///- `pending`: Workflow has been created but not yet started processing.
      ///- `in_progress`: Actively processing. Continue polling `links.self`.
      ///  The workflow has an internal deadline and will not remain in this
      ///  state indefinitely.
      ///- `action_required`: Paused — requires action by the user (not the
      ///  system). See `context.action` for what is needed. An automated
      ///  polling loop must break on this state; it will not resolve on its
      ///  own without user intervention.
      ///- `blocked`: The workflow cannot make progress due to a third party
      ///  such as the domain extension's registry or a losing registrar.
      ///  No user action will help. Continue polling — the block may resolve
      ///  when the third party responds.
      ///- `succeeded`: Terminal. The operation completed successfully.
      ///  `completed` will be `true`. For registrations, `context.registration`
      ///  contains the resulting registration resource.
      ///- `failed`: Terminal. The operation failed. `completed` will be `true`.
      ///  See `error.code` and `error.message` for the reason. Do not
      ///  auto-retry without user review.
      state: State
      updated_at: System.DateTimeOffset }
    ///Creates an instance of registrar-apiworkflowstatus with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (completed: bool,
                          created_at: System.DateTimeOffset,
                          links: ``registrar-apiworkflowlinks``,
                          state: State,
                          updated_at: System.DateTimeOffset): ``registrar-apiworkflowstatus`` =
        { completed = completed
          context = None
          created_at = created_at
          error = None
          links = links
          state = state
          updated_at = updated_at }

[<RequireQualifiedAccess>]
type RegistrarDomainDiscoveryCheck =
    ///Successfully returned availability results. Each requested domain appears in the `domains` array with its current availability status and pricing (if available).
    | OK of payload: ``registrar-apidomaincheckresponse``
    ///Invalid request parameters. Common causes:
    ///- Empty `domains` array
    ///- Exceeds maximum of 20 domains per request
    ///- Malformed request body
    ///- None of the provided domains are valid
    | BadRequest of payload: ``registrar-apiapi-response-common-failure``

[<RequireQualifiedAccess>]
type RegistrarDomainDiscoverySearch =
    ///Successfully returned domain search results.
    | OK of payload: ``registrar-apidomainsearchresponse``
    ///Invalid request parameters. Common causes:
    ///- Missing required `q` parameter
    ///- Query exceeds 100 character limit
    ///- Invalid extension format
    | BadRequest of payload: ``registrar-apiapi-response-common-failure``

[<RequireQualifiedAccess>]
type RegistrarDomainsListDomains =
    ///List domains response
    | OK of payload: ``registrar-apidomainresponsecollection``
    ///List domains response failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type RegistrarDomainsGetDomain =
    ///Get domain response
    | OK of payload: ``registrar-apidomainresponsesingle``
    ///Get domain response failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type RegistrarDomainsUpdateDomain =
    ///Update domain response
    | OK of payload: ``registrar-apidomainresponsesingle``
    ///Update domain response failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type RegistrarDomainRegistrationList =
    ///List of registrations for the account.
    | OK of payload: ``registrar-apiregistration-response-collection``
    ///List registrations failure.
    | BadRequest of payload: ``registrar-apiapi-response-common-failure``

[<RequireQualifiedAccess>]
type RegistrarDomainRegistrationCreate =
    ///Registration completed successfully within the synchronous wait window.
    ///The workflow status will have `state: succeeded` and `completed: true`.
    | Created of payload: ``registrar-apiworkflow-status-response-single``
    ///Registration is still processing. This occurs when the operation did
    ///not complete within the synchronous wait window, or when `Prefer: respond-async`
    ///was sent. Poll the URL in `links.self` to track progress.
    | Accepted of payload: ``registrar-apiworkflow-status-response-single``
    ///Create registration failure.
    | BadRequest of payload: ``registrar-apiapi-response-common-failure``

[<RequireQualifiedAccess>]
type RegistrarDomainRegistrationGet =
    ///Registration details.
    | OK of payload: ``registrar-apiregistration-response-single``
    ///Get registration failure.
    | BadRequest of payload: ``registrar-apiapi-response-common-failure``

[<RequireQualifiedAccess>]
type RegistrarDomainRegistrationUpdate =
    ///Update completed successfully within the synchronous wait window.
    ///The workflow status will have `state: succeeded` and `completed: true`.
    | OK of payload: ``registrar-apiworkflow-status-response-single``
    ///Update is still processing. This occurs when the operation did not
    ///complete within the synchronous wait window, or when `Prefer: respond-async`
    ///was sent. Poll the URL in `links.self` to track progress.
    | Accepted of payload: ``registrar-apiworkflow-status-response-single``
    ///Update registration failure.
    | BadRequest of payload: ``registrar-apiapi-response-common-failure``

[<RequireQualifiedAccess>]
type RegistrarDomainRegistrationGetStatus =
    ///Registration workflow status.
    | OK of payload: ``registrar-apiworkflow-status-response-single``
    ///Get status failure.
    | BadRequest of payload: ``registrar-apiapi-response-common-failure``

[<RequireQualifiedAccess>]
type RegistrarDomainRegistrationGetUpdateStatus =
    ///Update workflow status.
    | OK of payload: ``registrar-apiworkflow-status-response-single``
    ///Get update status failure.
    | BadRequest of payload: ``registrar-apiapi-response-common-failure``
