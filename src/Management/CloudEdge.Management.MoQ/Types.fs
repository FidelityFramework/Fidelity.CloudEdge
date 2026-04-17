namespace rec Fidelity.CloudEdge.Management.MoQ.Types

///Cloudflare account identifier.
type moqaccountidentifier = string

type Errors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Errors = { code = None; message = None }

type Messages =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Messages = { code = None; message = None }

type ``moqapi-response-common`` =
    { errors: list<Errors>
      messages: list<Messages>
      success: bool }
    ///Creates an instance of moqapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<Errors>, messages: list<Messages>, success: bool): ``moqapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``moqapi-response-errorErrors`` =
    { ///Error codes:
      ///- 21001: Request body too large (HTTP 413)
      ///- 21002: Request body too small / missing name (HTTP 400)
      ///- 21003: Relay ID should be 32 hex characters (HTTP 400)
      ///- 21004: Failed to decode body — invalid JSON (HTTP 400)
      ///- 21005: Failed to read body (HTTP 400)
      ///- 21006: Unexpected server error (HTTP 500)
      ///- 21007: Relay not found (HTTP 404)
      ///- 21008: Relay limit exceeded for this account (HTTP 409)
      ///- 21009: origin_fallback and lingering_subscribe are mutually exclusive (HTTP 400)
      ///- 21010: Invalid token type — must be "publish_subscribe" or "subscribe" (HTTP 400)
      ///- 21011: Invalid relay name — name must not be empty (HTTP 400)
      code: int
      message: string }
    ///Creates an instance of moqapi-response-errorErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``moqapi-response-errorErrors`` =
        { code = code; message = message }

type ``moqapi-response-error`` =
    { errors: list<``moqapi-response-errorErrors``>
      messages: obj
      result: Option<obj>
      success: bool }
    ///Creates an instance of moqapi-response-error with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``moqapi-response-errorErrors``>,
                          messages: obj,
                          success: bool): ``moqapi-response-error`` =
        { errors = errors
          messages = messages
          result = None
          success = success }

type moqlingeringsubscribeconfig =
    { enabled: Option<bool>
      ///Relay-level ceiling on lingering subscribe timeout (ms). Default 30000.
      max_timeout_ms: Option<int> }
    ///Creates an instance of moqlingeringsubscribeconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): moqlingeringsubscribeconfig =
        { enabled = None
          max_timeout_ms = None }

type moqoriginfallbackconfig =
    { enabled: Option<bool>
      ///Ordered list of upstream origin relay URLs.
      urls: Option<list<string>> }
    ///Creates an instance of moqoriginfallbackconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): moqoriginfallbackconfig = { enabled = None; urls = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Status =
    | [<CompiledName "connected">] Connected
    member this.Format() =
        match this with
        | Connected -> "connected"

///Full relay details (no tokens).
type moqrelay =
    { ///origin_fallback and lingering_subscribe are mutually exclusive.
      config: moqrelayconfig
      created: System.DateTimeOffset
      modified: System.DateTimeOffset
      name: string
      ///"connected" when active, omitted otherwise.
      status: Option<Status>
      uid: string }
    ///Creates an instance of moqrelay with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (config: moqrelayconfig,
                          created: System.DateTimeOffset,
                          modified: System.DateTimeOffset,
                          name: string,
                          uid: string): moqrelay =
        { config = config
          created = created
          modified = modified
          name = name
          status = None
          uid = uid }

///origin_fallback and lingering_subscribe are mutually exclusive.
type moqrelayconfig =
    { lingering_subscribe: Option<moqlingeringsubscribeconfig>
      origin_fallback: Option<moqoriginfallbackconfig> }
    ///Creates an instance of moqrelayconfig with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): moqrelayconfig =
        { lingering_subscribe = None
          origin_fallback = None }

///Relay with auto-generated tokens (shown once).
type moqrelaycreateresponse =
    { ///origin_fallback and lingering_subscribe are mutually exclusive.
      config: moqrelayconfig
      created: System.DateTimeOffset
      modified: System.DateTimeOffset
      name: string
      ///Full access token (publish + subscribe). Treat as sensitive.
      token_publish_subscribe: string
      ///Subscribe-only token. Treat as sensitive.
      token_subscribe: string
      ///Server-generated unique identifier (32 hex chars).
      uid: string }
    ///Creates an instance of moqrelaycreateresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (config: moqrelayconfig,
                          created: System.DateTimeOffset,
                          modified: System.DateTimeOffset,
                          name: string,
                          token_publish_subscribe: string,
                          token_subscribe: string,
                          uid: string): moqrelaycreateresponse =
        { config = config
          created = created
          modified = modified
          name = name
          token_publish_subscribe = token_publish_subscribe
          token_subscribe = token_subscribe
          uid = uid }

///Abbreviated relay for list responses.
type moqrelaylistitem =
    { created: System.DateTimeOffset
      modified: System.DateTimeOffset
      name: string
      uid: string }
    ///Creates an instance of moqrelaylistitem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (created: System.DateTimeOffset, modified: System.DateTimeOffset, name: string, uid: string): moqrelaylistitem =
        { created = created
          modified = modified
          name = name
          uid = uid }

type moqresultinfo =
    { count: Option<int>
      total: Option<int> }
    ///Creates an instance of moqresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): moqresultinfo = { count = None; total = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "publish_subscribe">] Publish_subscribe
    | [<CompiledName "subscribe">] Subscribe
    member this.Format() =
        match this with
        | Publish_subscribe -> "publish_subscribe"
        | Subscribe -> "subscribe"

type moqrotatetokenresponse =
    { ///New token value (shown once). Treat as sensitive.
      token: string
      ``type``: Type }
    ///Creates an instance of moqrotatetokenresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (token: string, ``type``: Type): moqrotatetokenresponse =
        { token = token; ``type`` = ``type`` }

type getaccountsaccountidmoqrelaysresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of getaccountsaccountidmoqrelaysresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): getaccountsaccountidmoqrelaysresponseErrors = { code = None; message = None }

type getaccountsaccountidmoqrelaysresponseMessages =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of getaccountsaccountidmoqrelaysresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): getaccountsaccountidmoqrelaysresponseMessages = { code = None; message = None }

type getaccountsaccountidmoqrelaysresponse =
    { errors: list<getaccountsaccountidmoqrelaysresponseErrors>
      messages: list<getaccountsaccountidmoqrelaysresponseMessages>
      success: bool
      result: Option<list<moqrelaylistitem>>
      result_info: Option<moqresultinfo> }
    ///Creates an instance of getaccountsaccountidmoqrelaysresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<getaccountsaccountidmoqrelaysresponseErrors>,
                          messages: list<getaccountsaccountidmoqrelaysresponseMessages>,
                          success: bool): getaccountsaccountidmoqrelaysresponse =
        { errors = errors
          messages = messages
          success = success
          result = None
          result_info = None }

type postaccountsaccountidmoqrelaysresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of postaccountsaccountidmoqrelaysresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): postaccountsaccountidmoqrelaysresponseErrors = { code = None; message = None }

type postaccountsaccountidmoqrelaysresponseMessages =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of postaccountsaccountidmoqrelaysresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): postaccountsaccountidmoqrelaysresponseMessages = { code = None; message = None }

type postaccountsaccountidmoqrelaysresponse =
    { errors: list<postaccountsaccountidmoqrelaysresponseErrors>
      messages: list<postaccountsaccountidmoqrelaysresponseMessages>
      success: bool
      ///Relay with auto-generated tokens (shown once).
      result: Option<moqrelaycreateresponse> }
    ///Creates an instance of postaccountsaccountidmoqrelaysresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<postaccountsaccountidmoqrelaysresponseErrors>,
                          messages: list<postaccountsaccountidmoqrelaysresponseMessages>,
                          success: bool): postaccountsaccountidmoqrelaysresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type deleteaccountsaccountidmoqrelaysrelayidresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of deleteaccountsaccountidmoqrelaysrelayidresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): deleteaccountsaccountidmoqrelaysrelayidresponseErrors = { code = None; message = None }

type deleteaccountsaccountidmoqrelaysrelayidresponseMessages =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of deleteaccountsaccountidmoqrelaysrelayidresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): deleteaccountsaccountidmoqrelaysrelayidresponseMessages = { code = None; message = None }

type deleteaccountsaccountidmoqrelaysrelayidresponse =
    { errors: list<deleteaccountsaccountidmoqrelaysrelayidresponseErrors>
      messages: list<deleteaccountsaccountidmoqrelaysrelayidresponseMessages>
      success: bool
      result: Option<obj> }
    ///Creates an instance of deleteaccountsaccountidmoqrelaysrelayidresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<deleteaccountsaccountidmoqrelaysrelayidresponseErrors>,
                          messages: list<deleteaccountsaccountidmoqrelaysrelayidresponseMessages>,
                          success: bool): deleteaccountsaccountidmoqrelaysrelayidresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type getaccountsaccountidmoqrelaysrelayidresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of getaccountsaccountidmoqrelaysrelayidresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): getaccountsaccountidmoqrelaysrelayidresponseErrors = { code = None; message = None }

type getaccountsaccountidmoqrelaysrelayidresponseMessages =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of getaccountsaccountidmoqrelaysrelayidresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): getaccountsaccountidmoqrelaysrelayidresponseMessages = { code = None; message = None }

type getaccountsaccountidmoqrelaysrelayidresponse =
    { errors: list<getaccountsaccountidmoqrelaysrelayidresponseErrors>
      messages: list<getaccountsaccountidmoqrelaysrelayidresponseMessages>
      success: bool
      ///Full relay details (no tokens).
      result: Option<moqrelay> }
    ///Creates an instance of getaccountsaccountidmoqrelaysrelayidresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<getaccountsaccountidmoqrelaysrelayidresponseErrors>,
                          messages: list<getaccountsaccountidmoqrelaysrelayidresponseMessages>,
                          success: bool): getaccountsaccountidmoqrelaysrelayidresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type putaccountsaccountidmoqrelaysrelayidresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of putaccountsaccountidmoqrelaysrelayidresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): putaccountsaccountidmoqrelaysrelayidresponseErrors = { code = None; message = None }

type putaccountsaccountidmoqrelaysrelayidresponseMessages =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of putaccountsaccountidmoqrelaysrelayidresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): putaccountsaccountidmoqrelaysrelayidresponseMessages = { code = None; message = None }

type putaccountsaccountidmoqrelaysrelayidresponse =
    { errors: list<putaccountsaccountidmoqrelaysrelayidresponseErrors>
      messages: list<putaccountsaccountidmoqrelaysrelayidresponseMessages>
      success: bool
      ///Full relay details (no tokens).
      result: Option<moqrelay> }
    ///Creates an instance of putaccountsaccountidmoqrelaysrelayidresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<putaccountsaccountidmoqrelaysrelayidresponseErrors>,
                          messages: list<putaccountsaccountidmoqrelaysrelayidresponseMessages>,
                          success: bool): putaccountsaccountidmoqrelaysrelayidresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type postaccountsaccountidmoqrelaysrelayidtokensrotateresponseErrors =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of postaccountsaccountidmoqrelaysrelayidtokensrotateresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): postaccountsaccountidmoqrelaysrelayidtokensrotateresponseErrors =
        { code = None; message = None }

type postaccountsaccountidmoqrelaysrelayidtokensrotateresponseMessages =
    { code: Option<int>
      message: Option<string> }
    ///Creates an instance of postaccountsaccountidmoqrelaysrelayidtokensrotateresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): postaccountsaccountidmoqrelaysrelayidtokensrotateresponseMessages =
        { code = None; message = None }

type postaccountsaccountidmoqrelaysrelayidtokensrotateresponse =
    { errors: list<postaccountsaccountidmoqrelaysrelayidtokensrotateresponseErrors>
      messages: list<postaccountsaccountidmoqrelaysrelayidtokensrotateresponseMessages>
      success: bool
      result: Option<moqrotatetokenresponse> }
    ///Creates an instance of postaccountsaccountidmoqrelaysrelayidtokensrotateresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<postaccountsaccountidmoqrelaysrelayidtokensrotateresponseErrors>,
                          messages: list<postaccountsaccountidmoqrelaysrelayidtokensrotateresponseMessages>,
                          success: bool): postaccountsaccountidmoqrelaysrelayidtokensrotateresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

[<RequireQualifiedAccess>]
type GetAccountsMoqRelays =
    ///Relay list retrieved successfully.
    | OK of payload: getaccountsaccountidmoqrelaysresponse
    ///Error 21006: Unexpected server error.
    | InternalServerError of payload: ``moqapi-response-error``

type PostAccountsMoqRelaysPayload =
    { ///Human-readable name for the relay.
      name: string }
    ///Creates an instance of PostAccountsMoqRelaysPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string): PostAccountsMoqRelaysPayload = { name = name }

[<RequireQualifiedAccess>]
type PostAccountsMoqRelays =
    ///Relay created successfully.
    | Created of payload: postaccountsaccountidmoqrelaysresponse
    ///Bad request. Possible errors:
    ///- 21002: Request body too small (empty or missing name)
    ///- 21004: Failed to decode body (invalid JSON)
    | BadRequest of payload: ``moqapi-response-error``
    ///Error 21008: Relay limit exceeded for this account.
    | Conflict of payload: ``moqapi-response-error``
    ///Error 21006: Unexpected server error.
    | InternalServerError of payload: ``moqapi-response-error``

[<RequireQualifiedAccess>]
type DeleteAccountsMoqRelay =
    ///Relay deleted successfully.
    | OK of payload: deleteaccountsaccountidmoqrelaysrelayidresponse
    ///Error 21003: Relay ID should be 32 hex characters.
    | BadRequest of payload: ``moqapi-response-error``
    ///Error 21007: Relay not found.
    | NotFound of payload: ``moqapi-response-error``
    ///Error 21006: Unexpected server error.
    | InternalServerError of payload: ``moqapi-response-error``

[<RequireQualifiedAccess>]
type GetAccountsMoqRelay =
    ///Relay retrieved successfully.
    | OK of payload: getaccountsaccountidmoqrelaysrelayidresponse
    ///Error 21003: Relay ID should be 32 hex characters.
    | BadRequest of payload: ``moqapi-response-error``
    ///Error 21007: Relay not found.
    | NotFound of payload: ``moqapi-response-error``
    ///Error 21006: Unexpected server error.
    | InternalServerError of payload: ``moqapi-response-error``

type PutAccountsMoqRelayPayload =
    { ///origin_fallback and lingering_subscribe are mutually exclusive.
      config: Option<moqrelayconfig>
      name: Option<string> }
    ///Creates an instance of PutAccountsMoqRelayPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): PutAccountsMoqRelayPayload = { config = None; name = None }

[<RequireQualifiedAccess>]
type PutAccountsMoqRelay =
    ///Relay updated successfully.
    | OK of payload: putaccountsaccountidmoqrelaysrelayidresponse
    ///Bad request. Possible errors: 21003 (relay ID should be 32 hex characters), 21004 (failed to decode body, invalid JSON), 21009 (origin_fallback and lingering_subscribe are mutually exclusive), 21011 (name must not be empty).
    | BadRequest of payload: ``moqapi-response-error``
    ///Error 21007: Relay not found.
    | NotFound of payload: ``moqapi-response-error``
    ///Error 21006: Unexpected server error.
    | InternalServerError of payload: ``moqapi-response-error``

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PostAccountsMoqRelaysTokensRotatePayloadType =
    | [<CompiledName "publish_subscribe">] Publish_subscribe
    | [<CompiledName "subscribe">] Subscribe
    member this.Format() =
        match this with
        | Publish_subscribe -> "publish_subscribe"
        | Subscribe -> "subscribe"

type PostAccountsMoqRelaysTokensRotatePayload =
    { ///Which token type to rotate.
      ``type``: PostAccountsMoqRelaysTokensRotatePayloadType }
    ///Creates an instance of PostAccountsMoqRelaysTokensRotatePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: PostAccountsMoqRelaysTokensRotatePayloadType): PostAccountsMoqRelaysTokensRotatePayload =
        { ``type`` = ``type`` }

[<RequireQualifiedAccess>]
type PostAccountsMoqRelaysTokensRotate =
    ///Token rotated successfully.
    | OK of payload: postaccountsaccountidmoqrelaysrelayidtokensrotateresponse
    ///Bad request. Possible errors: 21003 (relay ID should be 32 hex characters), 21004 (failed to decode body, invalid JSON), 21010 (invalid token type).
    | BadRequest of payload: ``moqapi-response-error``
    ///Error 21007: Relay not found.
    | NotFound of payload: ``moqapi-response-error``
    ///Error 21006: Unexpected server error.
    | InternalServerError of payload: ``moqapi-response-error``
