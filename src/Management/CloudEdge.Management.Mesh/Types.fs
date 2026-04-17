namespace rec Fidelity.CloudEdge.Management.Mesh.Types

// Auto-generated type aliases (Hawaii normalization fix)
type ``tunnel_schemas-connection`` = ``tunnelschemas-connection``
type ``tunnel_schemas-warp-connector-connection`` = ``tunnelschemas-warp-connector-connection``

// Auto-generated stub types (missing from Hawaii output)
type results = string

///Cloudflare account ID
type tunnelaccountid = string
///The cloudflared OS architecture used to establish this connection.
type tunnelarch = string
///UUID of the Cloudflare Tunnel connector.
type tunnelclientid = System.Guid
///UUID of the Cloudflare Tunnel connector.
type tunnelclientidinput = System.Guid
///The Cloudflare data center used for this connection.
type tunnelcoloname = string
///UUID of the Cloudflare Tunnel connection.
type tunnelconnectionid = System.Guid
type tunnelconnectionsdeprecated = list<``tunnel_schemas-connection``>
///Timestamp of when the tunnel established at least one connection to Cloudflare's edge. If `null`, the tunnel is inactive.
type tunnelconnsactiveat = System.DateTimeOffset
///Timestamp of when the tunnel became inactive (no connections to Cloudflare's edge). If `null`, the tunnel is active.
type tunnelconnsinactiveat = System.DateTimeOffset
///Timestamp of when the resource was created.
type tunnelcreatedat = System.DateTimeOffset
///Timestamp of when the resource was deleted. If `null`, the resource has not been deleted.
type tunneldeletedat = System.DateTimeOffset
///If provided, include only resources that were created (and not deleted) before this time. URL encoded.
type tunnelexistedat = string
///Features enabled for the Cloudflare Tunnel.
type tunnelfeatures = list<string>

///The HA status of a WARP Connector client.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type tunnelhastatus =
    | [<CompiledName "offline">] Offline
    | [<CompiledName "passive">] Passive
    | [<CompiledName "active">] Active
    member this.Format() =
        match this with
        | Offline -> "offline"
        | Passive -> "passive"
        | Active -> "active"

type tunnelip = string
type tunnelispendingreconnect = bool

type tunnelmessagesArrayItem =
    { code: int
      message: string }
    ///Creates an instance of tunnelmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunnelmessagesArrayItem = { code = code; message = message }

type tunnelmessages = list<tunnelmessagesArrayItem>
type tunnelpagenumber = float
type tunnelperpage = float
///Timestamp of when the tunnel connection was started.
type tunnelrunat = System.DateTimeOffset

///The status of the tunnel. Valid values are `inactive` (tunnel has never been run), `degraded` (tunnel is active and able to serve traffic but in an unhealthy state), `healthy` (tunnel is active and able to serve traffic), or `down` (tunnel can not serve traffic as it has no connections to the Cloudflare Edge).
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type tunnelstatus =
    | [<CompiledName "inactive">] Inactive
    | [<CompiledName "degraded">] Degraded
    | [<CompiledName "healthy">] Healthy
    | [<CompiledName "down">] Down
    member this.Format() =
        match this with
        | Inactive -> "inactive"
        | Degraded -> "degraded"
        | Healthy -> "healthy"
        | Down -> "down"

///UUID of the tunnel.
type tunneltunnelid = System.Guid
///A user-friendly name for a tunnel.
type tunneltunnelname = string
///Sets the password required to run a locally-managed tunnel. Must be at least 32 bytes and encoded as a base64 string.
type tunneltunnelsecret = string
///The Tunnel Token is used as a mechanism to authenticate the operation of a tunnel.
type tunneltunneltoken = string

///The type of tunnel.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type tunneltunneltype =
    | [<CompiledName "cfd_tunnel">] Cfd_tunnel
    | [<CompiledName "warp_connector">] Warp_connector
    | [<CompiledName "warp">] Warp
    | [<CompiledName "magic">] Magic
    | [<CompiledName "ip_sec">] Ip_sec
    | [<CompiledName "gre">] Gre
    | [<CompiledName "cni">] Cni
    member this.Format() =
        match this with
        | Cfd_tunnel -> "cfd_tunnel"
        | Warp_connector -> "warp_connector"
        | Warp -> "warp"
        | Magic -> "magic"
        | Ip_sec -> "ip_sec"
        | Gre -> "gre"
        | Cni -> "cni"

///The cloudflared version used to establish this connection.
type tunnelversion = string
type tunnelwarpconnectorconnections = list<``tunnel_schemas-warp-connector-connection``>

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

type ``tunnelapi-response-collection`` =
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      result: Option<obj>
      ///Whether the API call was successful
      success: Option<bool>
      result_info: Option<tunnelresultinfo> }
    ///Creates an instance of tunnelapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``tunnelapi-response-collection`` =
        { errors = None
          messages = None
          result = None
          success = None
          result_info = None }

type ``tunnelapi-response-commonErrors`` =
    { code: int
      message: string }
    ///Creates an instance of tunnelapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelapi-response-commonErrors`` =
        { code = code; message = message }

type ``tunnelapi-response-commonMessages`` =
    { code: int
      message: string }
    ///Creates an instance of tunnelapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelapi-response-commonMessages`` =
        { code = code; message = message }

type ``tunnelapi-response-common`` =
    { errors: list<``tunnelapi-response-commonErrors``>
      messages: list<``tunnelapi-response-commonMessages``>
      result: obj
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of tunnelapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``tunnelapi-response-commonErrors``>,
                          messages: list<``tunnelapi-response-commonMessages``>,
                          result: obj,
                          success: bool): ``tunnelapi-response-common`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``tunnelapi-response-common-failure`` =
    { errors: obj
      messages: obj
      result: obj
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of tunnelapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: obj,
                          messages: obj,
                          result: obj,
                          success: bool): ``tunnelapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type tunnelemptyresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of tunnelemptyresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunnelemptyresponseErrors = { code = code; message = message }

type tunnelemptyresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of tunnelemptyresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunnelemptyresponseMessages = { code = code; message = message }

type tunnelemptyresponse =
    { errors: list<tunnelemptyresponseErrors>
      messages: list<tunnelemptyresponseMessages>
      result: obj
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of tunnelemptyresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<tunnelemptyresponseErrors>,
                          messages: list<tunnelemptyresponseMessages>,
                          result: obj,
                          success: bool): tunnelemptyresponse =
        { errors = errors
          messages = messages
          result = result
          success = success }

type tunnelresultinfo =
    { ///Total number of results for the requested service
      count: Option<float>
      ///Current page within paginated list of results
      page: Option<float>
      ///Number of results per page of results
      per_page: Option<float>
      ///Total results available without any search parameters
      total_count: Option<float> }
    ///Creates an instance of tunnelresultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): tunnelresultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``tunnelschemas-connection`` =
    { ///UUID of the Cloudflare Tunnel connector.
      client_id: Option<tunnelclientid>
      ///The cloudflared version used to establish this connection.
      client_version: Option<tunnelversion>
      ///The Cloudflare data center used for this connection.
      colo_name: Option<tunnelcoloname>
      ///UUID of the Cloudflare Tunnel connection.
      id: Option<tunnelconnectionid>
      ///Cloudflare continues to track connections for several minutes after they disconnect. This is an optimization to improve latency and reliability of reconnecting.  If `true`, the connection has disconnected but is still being tracked. If `false`, the connection is actively serving traffic.
      is_pending_reconnect: Option<tunnelispendingreconnect>
      ///Timestamp of when the connection was established.
      opened_at: Option<System.DateTimeOffset>
      ///The public IP address of the host running cloudflared.
      origin_ip: Option<obj>
      ///UUID of the Cloudflare Tunnel connection.
      uuid: Option<tunnelconnectionid> }
    ///Creates an instance of tunnelschemas-connection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``tunnelschemas-connection`` =
        { client_id = None
          client_version = None
          colo_name = None
          id = None
          is_pending_reconnect = None
          opened_at = None
          origin_ip = None
          uuid = None }

type ``tunnelschemas-warp-connector-connection`` =
    { ///UUID of the Cloudflare Tunnel connector.
      client_id: Option<tunnelclientid>
      ///The cloudflared version used to establish this connection.
      client_version: Option<tunnelversion>
      ///The Cloudflare data center used for this connection.
      colo_name: Option<tunnelcoloname>
      ///UUID of the Cloudflare Tunnel connection.
      id: Option<tunnelconnectionid>
      ///Timestamp of when the connection was established.
      opened_at: Option<System.DateTimeOffset>
      ///The public IP address of the host running WARP Connector.
      origin_ip: Option<obj> }
    ///Creates an instance of tunnelschemas-warp-connector-connection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``tunnelschemas-warp-connector-connection`` =
        { client_id = None
          client_version = None
          colo_name = None
          id = None
          opened_at = None
          origin_ip = None }

type tunneltunnelresponsetokenErrors =
    { code: int
      message: string }
    ///Creates an instance of tunneltunnelresponsetokenErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunneltunnelresponsetokenErrors =
        { code = code; message = message }

type tunneltunnelresponsetokenMessages =
    { code: int
      message: string }
    ///Creates an instance of tunneltunnelresponsetokenMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunneltunnelresponsetokenMessages =
        { code = code; message = message }

type tunneltunnelresponsetoken =
    { errors: list<tunneltunnelresponsetokenErrors>
      messages: list<tunneltunnelresponsetokenMessages>
      ///The Tunnel Token is used as a mechanism to authenticate the operation of a tunnel.
      result: tunneltunneltoken
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of tunneltunnelresponsetoken with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<tunneltunnelresponsetokenErrors>,
                          messages: list<tunneltunnelresponsetokenMessages>,
                          result: tunneltunneltoken,
                          success: bool): tunneltunnelresponsetoken =
        { errors = errors
          messages = messages
          result = result
          success = success }

///A WARP Connector client that maintains a connection to a Cloudflare data center.
type tunneltunnelwarpconnectorclient =
    { ///The cloudflared OS architecture used to establish this connection.
      arch: Option<tunnelarch>
      ///The WARP Connector Tunnel connections between your origin and Cloudflare's edge.
      conns: Option<tunnelwarpconnectorconnections>
      ///Features enabled for the Cloudflare Tunnel.
      features: Option<tunnelfeatures>
      ///The HA status of a WARP Connector client.
      ha_status: Option<tunnelhastatus>
      ///UUID of the Cloudflare Tunnel connector.
      id: Option<tunnelclientid>
      ///Timestamp of when the tunnel connection was started.
      run_at: Option<tunnelrunat>
      ///The cloudflared version used to establish this connection.
      version: Option<tunnelversion> }
    ///Creates an instance of tunneltunnelwarpconnectorclient with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): tunneltunnelwarpconnectorclient =
        { arch = None
          conns = None
          features = None
          ha_status = None
          id = None
          run_at = None
          version = None }

type tunneltunnelwarpconnectorclientresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of tunneltunnelwarpconnectorclientresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunneltunnelwarpconnectorclientresponseErrors =
        { code = code; message = message }

type tunneltunnelwarpconnectorclientresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of tunneltunnelwarpconnectorclientresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunneltunnelwarpconnectorclientresponseMessages =
        { code = code; message = message }

type tunneltunnelwarpconnectorclientresponse =
    { errors: list<tunneltunnelwarpconnectorclientresponseErrors>
      messages: list<tunneltunnelwarpconnectorclientresponseMessages>
      ///A WARP Connector client that maintains a connection to a Cloudflare data center.
      result: tunneltunnelwarpconnectorclient
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of tunneltunnelwarpconnectorclientresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<tunneltunnelwarpconnectorclientresponseErrors>,
                          messages: list<tunneltunnelwarpconnectorclientresponseMessages>,
                          result: tunneltunnelwarpconnectorclient,
                          success: bool): tunneltunnelwarpconnectorclientresponse =
        { errors = errors
          messages = messages
          result = result
          success = success }

type tunneltunnelwarpconnectorconnectionsresponseErrors =
    { code: int
      message: string }
    ///Creates an instance of tunneltunnelwarpconnectorconnectionsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunneltunnelwarpconnectorconnectionsresponseErrors =
        { code = code; message = message }

type tunneltunnelwarpconnectorconnectionsresponseMessages =
    { code: int
      message: string }
    ///Creates an instance of tunneltunnelwarpconnectorconnectionsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): tunneltunnelwarpconnectorconnectionsresponseMessages =
        { code = code; message = message }

type tunneltunnelwarpconnectorconnectionsresponse =
    { errors: list<tunneltunnelwarpconnectorconnectionsresponseErrors>
      messages: list<tunneltunnelwarpconnectorconnectionsresponseMessages>
      result: list<tunneltunnelwarpconnectorclient>
      ///Whether the API call was successful
      success: bool
      result_info: Option<tunnelresultinfo> }
    ///Creates an instance of tunneltunnelwarpconnectorconnectionsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<tunneltunnelwarpconnectorconnectionsresponseErrors>,
                          messages: list<tunneltunnelwarpconnectorconnectionsresponseMessages>,
                          result: list<tunneltunnelwarpconnectorclient>,
                          success: bool): tunneltunnelwarpconnectorconnectionsresponse =
        { errors = errors
          messages = messages
          result = result
          success = success
          result_info = None }

type ``tunnelwarp-connector-response-collectionErrors`` =
    { code: int
      message: string }
    ///Creates an instance of tunnelwarp-connector-response-collectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelwarp-connector-response-collectionErrors`` =
        { code = code; message = message }

type ``tunnelwarp-connector-response-collectionMessages`` =
    { code: int
      message: string }
    ///Creates an instance of tunnelwarp-connector-response-collectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelwarp-connector-response-collectionMessages`` =
        { code = code; message = message }

type ``tunnelwarp-connector-response-collection`` =
    { errors: list<``tunnelwarp-connector-response-collectionErrors``>
      messages: list<``tunnelwarp-connector-response-collectionMessages``>
      result: list<tunnelwarpconnectortunnel>
      ///Whether the API call was successful
      success: bool
      result_info: Option<tunnelresultinfo> }
    ///Creates an instance of tunnelwarp-connector-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``tunnelwarp-connector-response-collectionErrors``>,
                          messages: list<``tunnelwarp-connector-response-collectionMessages``>,
                          result: list<tunnelwarpconnectortunnel>,
                          success: bool): ``tunnelwarp-connector-response-collection`` =
        { errors = errors
          messages = messages
          result = result
          success = success
          result_info = None }

type ``tunnelwarp-connector-response-singleErrors`` =
    { code: int
      message: string }
    ///Creates an instance of tunnelwarp-connector-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelwarp-connector-response-singleErrors`` =
        { code = code; message = message }

type ``tunnelwarp-connector-response-singleMessages`` =
    { code: int
      message: string }
    ///Creates an instance of tunnelwarp-connector-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``tunnelwarp-connector-response-singleMessages`` =
        { code = code; message = message }

type ``tunnelwarp-connector-response-single`` =
    { errors: list<``tunnelwarp-connector-response-singleErrors``>
      messages: list<``tunnelwarp-connector-response-singleMessages``>
      ///A Warp Connector Tunnel that connects your origin to Cloudflare's edge.
      result: tunnelwarpconnectortunnel
      ///Whether the API call was successful
      success: bool }
    ///Creates an instance of tunnelwarp-connector-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``tunnelwarp-connector-response-singleErrors``>,
                          messages: list<``tunnelwarp-connector-response-singleMessages``>,
                          result: tunnelwarpconnectortunnel,
                          success: bool): ``tunnelwarp-connector-response-single`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

///A Warp Connector Tunnel that connects your origin to Cloudflare's edge.
type tunnelwarpconnectortunnel =
    { ///Cloudflare account ID
      account_tag: Option<tunnelaccountid>
      ///Timestamp of when the tunnel established at least one connection to Cloudflare's edge. If `null`, the tunnel is inactive.
      conns_active_at: Option<tunnelconnsactiveat>
      ///Timestamp of when the tunnel became inactive (no connections to Cloudflare's edge). If `null`, the tunnel is active.
      conns_inactive_at: Option<tunnelconnsinactiveat>
      ///Timestamp of when the resource was created.
      created_at: Option<tunnelcreatedat>
      ///Timestamp of when the resource was deleted. If `null`, the resource has not been deleted.
      deleted_at: Option<tunneldeletedat>
      ///UUID of the tunnel.
      id: Option<tunneltunnelid>
      ///Metadata associated with the tunnel.
      metadata: Option<obj>
      ///A user-friendly name for a tunnel.
      name: Option<tunneltunnelname>
      ///The status of the tunnel. Valid values are `inactive` (tunnel has never been run), `degraded` (tunnel is active and able to serve traffic but in an unhealthy state), `healthy` (tunnel is active and able to serve traffic), or `down` (tunnel can not serve traffic as it has no connections to the Cloudflare Edge).
      status: Option<tunnelstatus>
      ///The type of tunnel.
      tun_type: Option<tunneltunneltype> }
    ///Creates an instance of tunnelwarpconnectortunnel with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): tunnelwarpconnectortunnel =
        { account_tag = None
          conns_active_at = None
          conns_inactive_at = None
          created_at = None
          deleted_at = None
          id = None
          metadata = None
          name = None
          status = None
          tun_type = None }

[<RequireQualifiedAccess>]
type CloudflareTunnelListWarpConnectorTunnels =
    ///List Warp Connector Tunnels response
    | OK of payload: ``tunnelwarp-connector-response-collection``
    ///List Warp Connector Tunnels response failure
    | BadRequest of payload: string

type CloudflareTunnelCreateAWarpConnectorTunnelPayload =
    { ///Indicates that the tunnel will be created to be highly available. If omitted, defaults to false.
      ha: Option<bool>
      ///A user-friendly name for a tunnel.
      name: tunneltunnelname }
    ///Creates an instance of CloudflareTunnelCreateAWarpConnectorTunnelPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: tunneltunnelname): CloudflareTunnelCreateAWarpConnectorTunnelPayload =
        { ha = None; name = name }

[<RequireQualifiedAccess>]
type CloudflareTunnelCreateAWarpConnectorTunnel =
    ///Create a Warp Connector Tunnel response
    | OK of payload: ``tunnelwarp-connector-response-single``
    ///Create a Warp Connector Tunnel response failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type CloudflareTunnelDeleteAWarpConnectorTunnel =
    ///Delete a Warp Connector Tunnel response
    | OK of payload: ``tunnelwarp-connector-response-single``
    ///Delete a Warp Connector Tunnel response failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type CloudflareTunnelGetAWarpConnectorTunnel =
    ///Get a Warp Connector Tunnel response
    | OK of payload: ``tunnelwarp-connector-response-single``
    ///Get a Warp Connector Tunnel response failure
    | BadRequest of payload: string

type CloudflareTunnelUpdateAWarpConnectorTunnelPayload =
    { ///A user-friendly name for a tunnel.
      name: Option<tunneltunnelname>
      ///Sets the password required to run a locally-managed tunnel. Must be at least 32 bytes and encoded as a base64 string.
      tunnel_secret: Option<tunneltunnelsecret> }
    ///Creates an instance of CloudflareTunnelUpdateAWarpConnectorTunnelPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): CloudflareTunnelUpdateAWarpConnectorTunnelPayload = { name = None; tunnel_secret = None }

[<RequireQualifiedAccess>]
type CloudflareTunnelUpdateAWarpConnectorTunnel =
    ///Update a Warp Connector Tunnel response
    | OK of payload: ``tunnelwarp-connector-response-single``
    ///Update a Warp Connector Tunnel response failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type CloudflareTunnelListWarpConnectorTunnelConnections =
    ///List WARP Connector Tunnel connections response
    | OK of payload: tunneltunnelwarpconnectorconnectionsresponse
    ///List WARP Connector connections response failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type CloudflareTunnelGetWarpConnectorTunnelConnector =
    ///Get WARP Connector Tunnel connector response
    | OK of payload: tunneltunnelwarpconnectorclientresponse
    ///Get WARP Connector Tunnel connector response failure
    | BadRequest of payload: string

type CloudflareTunnelManualFailoverWarpConnectorTunnelPayload =
    { ///UUID of the Cloudflare Tunnel connector.
      client_id: tunnelclientidinput }
    ///Creates an instance of CloudflareTunnelManualFailoverWarpConnectorTunnelPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (client_id: tunnelclientidinput): CloudflareTunnelManualFailoverWarpConnectorTunnelPayload =
        { client_id = client_id }

[<RequireQualifiedAccess>]
type CloudflareTunnelManualFailoverWarpConnectorTunnel =
    ///Manual failover response
    | OK of payload: tunnelemptyresponse
    ///Manual failover response failure
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type CloudflareTunnelGetAWarpConnectorTunnelToken =
    ///Get a Warp Connector Tunnel token response
    | OK of payload: tunneltunnelresponsetoken
    ///Get a Warp Connector Tunnel token response failure
    | BadRequest of payload: string
