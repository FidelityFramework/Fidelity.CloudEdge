namespace rec Fidelity.CloudEdge.Management.ResourceLibrary

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.ResourceLibrary.Types
open Fidelity.CloudEdge.Management.ResourceLibrary.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type ResourceLibraryClient(httpClient: HttpClient) =
    ///<summary>
    ///List applications with different filters.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="filter">
    ///Filter applications using key:value format. Supported filter keys:
    ///- name: Filter by application name (e.g., name:HR)
    ///- id: Filter by application ID (e.g., id:0b63249c-95bf-4cc0-a7cc-d7faaaf1dac0)
    ///- human_id: Filter by human-readable ID (e.g., human_id:HR)
    ///- hostname: Filter by hostname or support domain (e.g., hostname:portal.example.com)
    ///- source: Filter by application source name (e.g., source:cloudflare)
    ///- ip_subnet: Filter by IP subnet using CIDR containment — returns applications where any stored subnet contains the search value (e.g., ip_subnet:10.0.1.5/32 matches apps with 10.0.0.0/16)
    ///- intel_id: Filter by Intel API ID (e.g., intel_id:498).
    ///.
    ///</param>
    ///<param name="limit">Limit of number of results to return (max 250).</param>
    ///<param name="offset">Offset of results to return.</param>
    ///<param name="orderBy">Order by result by field name and order (e.g., name:asc).</param>
    ///<param name="cancellationToken"></param>
    member this.GetApplications
        (
            accountId: string,
            ?filter: string,
            ?limit: int,
            ?offset: int,
            ?orderBy: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if filter.IsSome then
                      RequestPart.query ("filter", filter.Value)
                  if limit.IsSome then
                      RequestPart.query ("limit", limit.Value)
                  if offset.IsSome then
                      RequestPart.query ("offset", offset.Value)
                  if orderBy.IsSome then
                      RequestPart.query ("order_by", orderBy.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/resource-library/applications"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetApplications.OK(Serializer.deserialize content)
            | _ -> return GetApplications.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get application by ID.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="id">Application ID.</param>
    ///<param name="cancellationToken"></param>
    member this.GetApplicationById(accountId: string, id: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/resource-library/applications/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetApplicationById.OK(Serializer.deserialize content)
            | _ -> return GetApplicationById.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List application categories.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="limit">Limit of number of results to return.</param>
    ///<param name="offset">Offset of results to return.</param>
    ///<param name="cancellationToken"></param>
    member this.GetCategories(accountId: string, ?limit: int, ?offset: int, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if limit.IsSome then
                      RequestPart.query ("limit", limit.Value)
                  if offset.IsSome then
                      RequestPart.query ("offset", offset.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/resource-library/categories"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetCategories.OK(Serializer.deserialize content)
            | _ -> return GetCategories.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get application category by ID.
    ///</summary>
    ///<param name="accountId">Account ID.</param>
    ///<param name="id">Application category ID.</param>
    ///<param name="cancellationToken"></param>
    member this.GetCategoryById(accountId: string, id: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/resource-library/categories/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetCategoryById.OK(Serializer.deserialize content)
            | _ -> return GetCategoryById.BadRequest(Serializer.deserialize content)
        }
