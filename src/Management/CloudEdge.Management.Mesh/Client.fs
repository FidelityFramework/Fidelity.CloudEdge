namespace rec Fidelity.CloudEdge.Management.Mesh

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Mesh.Types
open Fidelity.CloudEdge.Management.Mesh.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type MeshClient(httpClient: HttpClient) =
    ///<summary>
    ///Lists and filters Warp Connector Tunnels in an account.
    ///</summary>
    member this.CloudflareTunnelListWarpConnectorTunnels
        (
            accountId: string,
            ?name: string,
            ?isDeleted: bool,
            ?existedAt: string,
            ?uuid: System.Guid,
            ?wasActiveAt: System.DateTimeOffset,
            ?wasInactiveAt: System.DateTimeOffset,
            ?includePrefix: string,
            ?excludePrefix: string,
            ?status: string,
            ?perPage: float,
            ?page: float,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if name.IsSome then
                      RequestPart.query ("name", name.Value)
                  if isDeleted.IsSome then
                      RequestPart.query ("is_deleted", isDeleted.Value)
                  if existedAt.IsSome then
                      RequestPart.query ("existed_at", existedAt.Value)
                  if uuid.IsSome then
                      RequestPart.query ("uuid", uuid.Value)
                  if wasActiveAt.IsSome then
                      RequestPart.query ("was_active_at", wasActiveAt.Value)
                  if wasInactiveAt.IsSome then
                      RequestPart.query ("was_inactive_at", wasInactiveAt.Value)
                  if includePrefix.IsSome then
                      RequestPart.query ("include_prefix", includePrefix.Value)
                  if excludePrefix.IsSome then
                      RequestPart.query ("exclude_prefix", excludePrefix.Value)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/warp_connector" requestParts cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelListWarpConnectorTunnels.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelListWarpConnectorTunnels.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new Warp Connector Tunnel in an account.
    ///</summary>
    member this.CloudflareTunnelCreateAWarpConnectorTunnel
        (
            accountId: string,
            body: CloudflareTunnelCreateAWarpConnectorTunnelPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/warp_connector" requestParts cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelCreateAWarpConnectorTunnel.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelCreateAWarpConnectorTunnel.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a Warp Connector Tunnel from an account.
    ///</summary>
    member this.CloudflareTunnelDeleteAWarpConnectorTunnel
        (
            accountId: string,
            tunnelId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tunnel_id", tunnelId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/warp_connector/{tunnel_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelDeleteAWarpConnectorTunnel.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelDeleteAWarpConnectorTunnel.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches a single Warp Connector Tunnel.
    ///</summary>
    member this.CloudflareTunnelGetAWarpConnectorTunnel
        (
            accountId: string,
            tunnelId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tunnel_id", tunnelId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/warp_connector/{tunnel_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelGetAWarpConnectorTunnel.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelGetAWarpConnectorTunnel.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an existing Warp Connector Tunnel.
    ///</summary>
    member this.CloudflareTunnelUpdateAWarpConnectorTunnel
        (
            accountId: string,
            tunnelId: System.Guid,
            body: CloudflareTunnelUpdateAWarpConnectorTunnelPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tunnel_id", tunnelId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/warp_connector/{tunnel_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelUpdateAWarpConnectorTunnel.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelUpdateAWarpConnectorTunnel.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches connection details for a WARP Connector Tunnel.
    ///</summary>
    member this.CloudflareTunnelListWarpConnectorTunnelConnections
        (
            accountId: string,
            tunnelId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tunnel_id", tunnelId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/warp_connector/{tunnel_id}/connections"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelListWarpConnectorTunnelConnections.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelListWarpConnectorTunnelConnections.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Fetches connector and connection details for a WARP Connector Tunnel.
    ///</summary>
    member this.CloudflareTunnelGetWarpConnectorTunnelConnector
        (
            accountId: string,
            tunnelId: System.Guid,
            connectorId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tunnel_id", tunnelId)
                  RequestPart.path ("connector_id", connectorId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/warp_connector/{tunnel_id}/connectors/{connector_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelGetWarpConnectorTunnelConnector.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelGetWarpConnectorTunnelConnector.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Triggers a manual failover for a specific WARP Connector Tunnel, setting the specified client as the active connector. The tunnel must be configured for high availability (HA) and the client must be linked to the tunnel.
    ///</summary>
    member this.CloudflareTunnelManualFailoverWarpConnectorTunnel
        (
            accountId: string,
            tunnelId: System.Guid,
            body: CloudflareTunnelManualFailoverWarpConnectorTunnelPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tunnel_id", tunnelId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/warp_connector/{tunnel_id}/failover"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelManualFailoverWarpConnectorTunnel.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelManualFailoverWarpConnectorTunnel.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets the token used to associate warp device with a specific Warp Connector tunnel.
    ///</summary>
    member this.CloudflareTunnelGetAWarpConnectorTunnelToken
        (
            accountId: string,
            tunnelId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("tunnel_id", tunnelId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/warp_connector/{tunnel_id}/token"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CloudflareTunnelGetAWarpConnectorTunnelToken.OK(Serializer.deserialize content)
            | _ -> return CloudflareTunnelGetAWarpConnectorTunnelToken.BadRequest(Serializer.deserialize content)
        }
