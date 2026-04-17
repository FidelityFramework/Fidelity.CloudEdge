namespace rec Fidelity.CloudEdge.Management.EventSubscriptions

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.EventSubscriptions.Types
open Fidelity.CloudEdge.Management.EventSubscriptions.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type EventSubscriptionsClient(httpClient: HttpClient) =
    ///<summary>
    ///Get a paginated list of event subscriptions with optional sorting and filtering
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="page">Page number for pagination</param>
    ///<param name="perPage">Number of items per page</param>
    ///<param name="order">Field to sort by</param>
    ///<param name="direction">Sort direction</param>
    ///<param name="cancellationToken"></param>
    member this.SubscriptionsList
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?order: string,
            ?direction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if order.IsSome then
                      RequestPart.query ("order", order.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/event_subscriptions/subscriptions"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return SubscriptionsList.OK(Serializer.deserialize content)
            | _ -> return SubscriptionsList.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new event subscription for a queue
    ///</summary>
    member this.SubscriptionsCreate
        (
            accountId: string,
            body: SubscriptionsCreatePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/event_subscriptions/subscriptions"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return SubscriptionsCreate.OK(Serializer.deserialize content)
            | 400 -> return SubscriptionsCreate.BadRequest(Serializer.deserialize content)
            | 404 -> return SubscriptionsCreate.NotFound(Serializer.deserialize content)
            | _ -> return SubscriptionsCreate.MethodNotAllowed(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete an existing event subscription
    ///</summary>
    member this.SubscriptionsDelete(accountId: string, subscriptionId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("subscription_id", subscriptionId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/event_subscriptions/subscriptions/{subscription_id}"
                    requestParts
                    cancellationToken

            return SubscriptionsDelete.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get details about an existing event subscription
    ///</summary>
    member this.SubscriptionsGet(accountId: string, subscriptionId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("subscription_id", subscriptionId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/event_subscriptions/subscriptions/{subscription_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return SubscriptionsGet.OK(Serializer.deserialize content)
            | _ -> return SubscriptionsGet.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Update an existing event subscription
    ///</summary>
    member this.SubscriptionsPatch
        (
            accountId: string,
            subscriptionId: string,
            body: SubscriptionsPatchPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("subscription_id", subscriptionId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/event_subscriptions/subscriptions/{subscription_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return SubscriptionsPatch.OK(Serializer.deserialize content)
            | 400 -> return SubscriptionsPatch.BadRequest(Serializer.deserialize content)
            | _ -> return SubscriptionsPatch.NotFound(Serializer.deserialize content)
        }
