namespace rec Fidelity.CloudEdge.Management.MoQ

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.MoQ.Types
open Fidelity.CloudEdge.Management.MoQ.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type MoQClient(httpClient: HttpClient) =
    ///<summary>
    ///Lists all MoQ relays for the account. Returns only metadata.
    ///Config, status, and tokens are omitted.
    ///</summary>
    ///<param name="accountId">Cloudflare account identifier.</param>
    ///<param name="cancellationToken"></param>
    member this.GetAccountsMoqRelays(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/moq/relays" requestParts cancellationToken

            match int status with
            | 200 -> return GetAccountsMoqRelays.OK(Serializer.deserialize content)
            | _ -> return GetAccountsMoqRelays.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Provisions a new MoQ relay instance. Auto-creates a publish+subscribe
    ///token and a subscribe-only token. Token values are included in the
    ///response (shown once). Config is set to defaults (lingering subscribe
    ///enabled, 30s ceiling, origin fallback off). Use PUT to modify.
    ///</summary>
    ///<param name="accountId">Cloudflare account identifier.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.PostAccountsMoqRelays
        (
            accountId: string,
            body: PostAccountsMoqRelaysPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/moq/relays" requestParts cancellationToken

            match int status with
            | 201 -> return PostAccountsMoqRelays.Created(Serializer.deserialize content)
            | 400 -> return PostAccountsMoqRelays.BadRequest(Serializer.deserialize content)
            | 409 -> return PostAccountsMoqRelays.Conflict(Serializer.deserialize content)
            | _ -> return PostAccountsMoqRelays.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Soft-deletes a MoQ relay.
    ///</summary>
    ///<param name="accountId">Cloudflare account identifier.</param>
    ///<param name="relayId">Relay unique identifier (32 hex characters).</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteAccountsMoqRelays(accountId: string, relayId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("relay_id", relayId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/moq/relays/{relay_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteAccountsMoqRelays.OK(Serializer.deserialize content)
            | 400 -> return DeleteAccountsMoqRelays.BadRequest(Serializer.deserialize content)
            | 404 -> return DeleteAccountsMoqRelays.NotFound(Serializer.deserialize content)
            | _ -> return DeleteAccountsMoqRelays.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves a single MoQ relay including config and status.
    ///Tokens are NOT included.
    ///</summary>
    ///<param name="accountId">Cloudflare account identifier.</param>
    ///<param name="relayId">Relay unique identifier (32 hex characters).</param>
    ///<param name="cancellationToken"></param>
    member this.GetAccountsMoqRelays(accountId: string, relayId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("relay_id", relayId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/moq/relays/{relay_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetGetAccountsMoqRelays.OK(Serializer.deserialize content)
            | 400 -> return GetGetAccountsMoqRelays.BadRequest(Serializer.deserialize content)
            | 404 -> return GetGetAccountsMoqRelays.NotFound(Serializer.deserialize content)
            | _ -> return GetGetAccountsMoqRelays.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a relay's name and/or configuration. Partial updates:
    ///omitted fields are preserved. Config sub-objects replace as
    ///whole objects when present. origin_fallback and lingering_subscribe
    ///are mutually exclusive.
    ///</summary>
    ///<param name="accountId">Cloudflare account identifier.</param>
    ///<param name="relayId">Relay unique identifier (32 hex characters).</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.PutAccountsMoqRelays
        (
            accountId: string,
            relayId: string,
            body: PutAccountsMoqRelaysPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("relay_id", relayId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/moq/relays/{relay_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PutAccountsMoqRelays.OK(Serializer.deserialize content)
            | 400 -> return PutAccountsMoqRelays.BadRequest(Serializer.deserialize content)
            | 404 -> return PutAccountsMoqRelays.NotFound(Serializer.deserialize content)
            | _ -> return PutAccountsMoqRelays.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Generates a new token for the specified type. The old token is
    ///immediately invalidated. Token value is shown once in the response.
    ///</summary>
    ///<param name="accountId">Cloudflare account identifier.</param>
    ///<param name="relayId">Relay unique identifier (32 hex characters).</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.PostAccountsMoqRelaysTokensRotate
        (
            accountId: string,
            relayId: string,
            body: PostAccountsMoqRelaysTokensRotatePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("relay_id", relayId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/moq/relays/{relay_id}/tokens/rotate"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PostAccountsMoqRelaysTokensRotate.OK(Serializer.deserialize content)
            | 400 -> return PostAccountsMoqRelaysTokensRotate.BadRequest(Serializer.deserialize content)
            | 404 -> return PostAccountsMoqRelaysTokensRotate.NotFound(Serializer.deserialize content)
            | _ -> return PostAccountsMoqRelaysTokensRotate.InternalServerError(Serializer.deserialize content)
        }
