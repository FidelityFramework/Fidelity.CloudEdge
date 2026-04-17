namespace rec Fidelity.CloudEdge.Management.EventNotifications

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.EventNotifications.Types
open Fidelity.CloudEdge.Management.EventNotifications.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type EventNotificationsClient(httpClient: HttpClient) =
    ///<summary>
    ///List all event notification rules for a bucket.
    ///</summary>
    member this.R2GetEventNotificationConfigs
        (
            bucketName: string,
            accountId: string,
            ?cfR2Jurisdiction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("bucket_name", bucketName)
                  RequestPart.path ("account_id", accountId)
                  if cfR2Jurisdiction.IsSome then
                      RequestPart.header ("cf-r2-jurisdiction", cfR2Jurisdiction.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/event_notifications/r2/{bucket_name}/configuration"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return R2GetEventNotificationConfigs.OK(Serializer.deserialize content)
            | 400 -> return R2GetEventNotificationConfigs.BadRequest(Serializer.deserialize content)
            | _ -> return R2GetEventNotificationConfigs.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete an event notification rule. **If no body is provided, all rules for specified queue will be deleted**.
    ///</summary>
    member this.R2EventNotificationDeleteConfig
        (
            queueId: string,
            bucketName: string,
            accountId: string,
            body: R2EventNotificationDeleteConfigPayload,
            ?cfR2Jurisdiction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("bucket_name", bucketName)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cfR2Jurisdiction.IsSome then
                      RequestPart.header ("cf-r2-jurisdiction", cfR2Jurisdiction.Value) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/event_notifications/r2/{bucket_name}/configuration/queues/{queue_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return R2EventNotificationDeleteConfig.OK(Serializer.deserialize content)
            | _ -> return R2EventNotificationDeleteConfig.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get a single event notification rule.
    ///</summary>
    member this.R2GetEventNotificationConfig
        (
            queueId: string,
            bucketName: string,
            accountId: string,
            ?cfR2Jurisdiction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("bucket_name", bucketName)
                  RequestPart.path ("account_id", accountId)
                  if cfR2Jurisdiction.IsSome then
                      RequestPart.header ("cf-r2-jurisdiction", cfR2Jurisdiction.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/event_notifications/r2/{bucket_name}/configuration/queues/{queue_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return R2GetEventNotificationConfig.OK(Serializer.deserialize content)
            | 400 -> return R2GetEventNotificationConfig.BadRequest(Serializer.deserialize content)
            | _ -> return R2GetEventNotificationConfig.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Create event notification rule.
    ///</summary>
    member this.R2PutEventNotificationConfig
        (
            queueId: string,
            bucketName: string,
            accountId: string,
            body: R2PutEventNotificationConfigPayload,
            ?cfR2Jurisdiction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("queue_id", queueId)
                  RequestPart.path ("bucket_name", bucketName)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if cfR2Jurisdiction.IsSome then
                      RequestPart.header ("cf-r2-jurisdiction", cfR2Jurisdiction.Value) ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/event_notifications/r2/{bucket_name}/configuration/queues/{queue_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return R2PutEventNotificationConfig.OK(Serializer.deserialize content)
            | _ -> return R2PutEventNotificationConfig.BadRequest(Serializer.deserialize content)
        }
