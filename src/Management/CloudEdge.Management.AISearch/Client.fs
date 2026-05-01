namespace rec Fidelity.CloudEdge.Management.AISearch

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.AISearch.Types
open Fidelity.CloudEdge.Management.AISearch.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type AISearchClient(httpClient: HttpClient) =
    ///<summary>
    ///List instances.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="page">Page number (1-indexed).</param>
    ///<param name="perPage">Number of results per page.</param>
    ///<param name="search">Filter instances whose id contains this string (case-insensitive).</param>
    ///<param name="namespace">Filter by namespace.</param>
    ///<param name="orderBy">Field to order results by.</param>
    ///<param name="orderByDirection">Order direction.</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchListInstances
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
            ?``namespace``: string,
            ?orderBy: string,
            ?orderByDirection: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value)
                  if ``namespace``.IsSome then
                      RequestPart.query ("namespace", ``namespace``.Value)
                  if orderBy.IsSome then
                      RequestPart.query ("order_by", orderBy.Value)
                  if orderByDirection.IsSome then
                      RequestPart.query ("order_by_direction", orderByDirection.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchListInstances.OK(Serializer.deserialize content)
            | _ -> return AiSearchListInstances.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new instance.
    ///</summary>
    member this.AiSearchCreateInstance
        (
            accountId: string,
            body: AiSearchCreateInstancePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return AiSearchCreateInstance.Created(Serializer.deserialize content)
            | 400 -> return AiSearchCreateInstance.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchCreateInstance.Forbidden(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete instance.
    ///</summary>
    member this.AiSearchDeleteInstance(accountId: string, id: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchDeleteInstance.OK(Serializer.deserialize content)
            | _ -> return AiSearchDeleteInstance.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Read instance.
    ///</summary>
    member this.AiSearchFetchInstance(accountId: string, id: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchFetchInstance.OK(Serializer.deserialize content)
            | _ -> return AiSearchFetchInstance.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Update instance.
    ///</summary>
    member this.AiSearchUpdateInstance
        (
            accountId: string,
            id: string,
            body: AiSearchUpdateInstancePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchUpdateInstance.OK(Serializer.deserialize content)
            | 400 -> return AiSearchUpdateInstance.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchUpdateInstance.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Performs a chat completion request against an AI Search instance, using indexed content as context for generating responses.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceChatCompletion
        (
            id: string,
            accountId: string,
            body: AiSearchInstanceChatCompletionPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/chat/completions"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceChatCompletion.OK(Serializer.deserialize content)
            | 400 -> return AiSearchInstanceChatCompletion.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchInstanceChatCompletion.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists indexing jobs for an AI Search instance.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="accountId"></param>
    ///<param name="page"></param>
    ///<param name="perPage"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceListJobs
        (
            id: string,
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/jobs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceListJobs.OK(Serializer.deserialize content)
            | 400 -> return AiSearchInstanceListJobs.BadRequest(Serializer.deserialize content)
            | 404 -> return AiSearchInstanceListJobs.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchInstanceListJobs.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new indexing job for an AI Search instance.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceCreateJob
        (
            id: string,
            accountId: string,
            body: AiSearchInstanceCreateJobPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/jobs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceCreateJob.OK(Serializer.deserialize content)
            | 400 -> return AiSearchInstanceCreateJob.BadRequest(Serializer.deserialize content)
            | 404 -> return AiSearchInstanceCreateJob.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchInstanceCreateJob.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves details for a specific AI Search indexing job.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="jobId"></param>
    ///<param name="accountId"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceGetJob
        (
            id: string,
            jobId: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("job_id", jobId)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/jobs/{job_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceGetJob.OK(Serializer.deserialize content)
            | 404 -> return AiSearchInstanceGetJob.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchInstanceGetJob.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates the status of an AI Search indexing job.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="jobId"></param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceChangeJobStatus
        (
            id: string,
            jobId: string,
            accountId: string,
            body: AiSearchInstanceChangeJobStatusPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("job_id", jobId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/jobs/{job_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceChangeJobStatus.OK(Serializer.deserialize content)
            | 400 -> return AiSearchInstanceChangeJobStatus.BadRequest(Serializer.deserialize content)
            | 404 -> return AiSearchInstanceChangeJobStatus.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchInstanceChangeJobStatus.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists log entries for an AI Search indexing job.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="jobId"></param>
    ///<param name="accountId"></param>
    ///<param name="page"></param>
    ///<param name="perPage"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceListJobLogs
        (
            id: string,
            jobId: string,
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("job_id", jobId)
                  RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/jobs/{job_id}/logs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceListJobLogs.OK(Serializer.deserialize content)
            | 400 -> return AiSearchInstanceListJobLogs.BadRequest(Serializer.deserialize content)
            | 404 -> return AiSearchInstanceListJobLogs.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchInstanceListJobLogs.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Executes a semantic search query against an AI Search instance to find relevant indexed content.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="accountId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchInstanceSearch
        (
            id: string,
            accountId: string,
            body: AiSearchInstanceSearchPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/search"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchInstanceSearch.OK(Serializer.deserialize content)
            | 400 -> return AiSearchInstanceSearch.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchInstanceSearch.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves usage statistics for AI Search instances.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="accountId"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchStats(id: string, accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/instances/{id}/stats"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchStats.OK(Serializer.deserialize content)
            | _ -> return AiSearchStats.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///List namespaces.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="page">Page number (1-indexed).</param>
    ///<param name="perPage">Number of results per page.</param>
    ///<param name="search">Filter namespaces whose name or description contains this string (case-insensitive).</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchListNamespaces
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchListNamespaces.OK(Serializer.deserialize content)
            | _ -> return AiSearchListNamespaces.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new namespace.
    ///</summary>
    member this.AiSearchCreateNamespace
        (
            accountId: string,
            body: AiSearchCreateNamespacePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return AiSearchCreateNamespace.Created(Serializer.deserialize content)
            | 400 -> return AiSearchCreateNamespace.BadRequest(Serializer.deserialize content)
            | 403 -> return AiSearchCreateNamespace.Forbidden(Serializer.deserialize content)
            | _ -> return AiSearchCreateNamespace.Conflict(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete namespace.
    ///</summary>
    member this.AiSearchDeleteNamespace(accountId: string, name: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchDeleteNamespace.OK(Serializer.deserialize content)
            | 400 -> return AiSearchDeleteNamespace.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchDeleteNamespace.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Read namespace.
    ///</summary>
    member this.AiSearchFetchNamespace(accountId: string, name: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchFetchNamespace.OK(Serializer.deserialize content)
            | _ -> return AiSearchFetchNamespace.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Update namespace.
    ///</summary>
    member this.AiSearchUpdateNamespace
        (
            accountId: string,
            name: string,
            body: AiSearchUpdateNamespacePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchUpdateNamespace.OK(Serializer.deserialize content)
            | 400 -> return AiSearchUpdateNamespace.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchUpdateNamespace.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Performs a chat completion request against multiple AI Search instances in parallel, merging retrieved content as context for generating a response.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceMultiInstanceChatCompletion
        (
            accountId: string,
            name: string,
            body: AiSearchNamespaceMultiInstanceChatCompletionPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/chat/completions"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceMultiInstanceChatCompletion.OK(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceMultiInstanceChatCompletion.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceMultiInstanceChatCompletion.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///List instances.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="page">Page number (1-indexed).</param>
    ///<param name="perPage">Number of results per page.</param>
    ///<param name="search">Filter instances whose id contains this string (case-insensitive).</param>
    ///<param name="namespace">Filter by namespace.</param>
    ///<param name="orderBy">Field to order results by.</param>
    ///<param name="orderByDirection">Order direction.</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceListInstances
        (
            accountId: string,
            name: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
            ?``namespace``: string,
            ?orderBy: string,
            ?orderByDirection: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value)
                  if ``namespace``.IsSome then
                      RequestPart.query ("namespace", ``namespace``.Value)
                  if orderBy.IsSome then
                      RequestPart.query ("order_by", orderBy.Value)
                  if orderByDirection.IsSome then
                      RequestPart.query ("order_by_direction", orderByDirection.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceListInstances.OK(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceListInstances.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new instance.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceCreateInstance
        (
            accountId: string,
            name: string,
            body: AiSearchNamespaceCreateInstancePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return AiSearchNamespaceCreateInstance.Created(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceCreateInstance.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceCreateInstance.Forbidden(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete instance.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="id"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceDeleteInstance
        (
            accountId: string,
            id: string,
            name: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id)
                  RequestPart.path ("name", name) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceDeleteInstance.OK(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceDeleteInstance.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Read instance.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="id"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceFetchInstance
        (
            accountId: string,
            id: string,
            name: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id)
                  RequestPart.path ("name", name) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceFetchInstance.OK(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceFetchInstance.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Moves an instance from its current namespace to the specified target namespace. Use 'default' as new_namespace to move the instance back to the default namespace. Fails with 400 if the target namespace already has an instance with the same id (ids must be unique within a namespace — the same id can exist in different namespaces).
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="name">Current namespace of the instance.</param>
    ///<param name="id">Instance id.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchMoveInstance
        (
            accountId: string,
            name: string,
            id: string,
            body: AiSearchMoveInstancePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  RequestPart.path ("id", id)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchMoveInstance.OK(Serializer.deserialize content)
            | 400 -> return AiSearchMoveInstance.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchMoveInstance.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Update instance.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="id"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceUpdateInstance
        (
            accountId: string,
            id: string,
            name: string,
            body: AiSearchNamespaceUpdateInstancePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id)
                  RequestPart.path ("name", name)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceUpdateInstance.OK(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceUpdateInstance.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceUpdateInstance.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Performs a chat completion request against an AI Search instance, using indexed content as context for generating responses.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceInstanceChatCompletion
        (
            id: string,
            accountId: string,
            name: string,
            body: AiSearchNamespaceInstanceChatCompletionPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/chat/completions"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceInstanceChatCompletion.OK(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceInstanceChatCompletion.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceInstanceChatCompletion.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists indexed items in an AI Search instance.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="page"></param>
    ///<param name="perPage"></param>
    ///<param name="search"></param>
    ///<param name="sortBy">Sort order for items. "status" (default) sorts by status priority then last_seen_at. "modified_at" sorts by file modification time (most recent first), falling back to created_at.</param>
    ///<param name="status"></param>
    ///<param name="source">Filter items by source_id. Use "builtin" for uploaded files, or a source identifier like "web-crawler:https://example.com".</param>
    ///<param name="metadataFilter">JSON-encoded metadata filter using Vectorize filter syntax. Examples: {"folder":"reports/"}, {"timestamp":{"$gte":1700000000000}}, {"folder":{"$in":["docs/","reports/"]}}</param>
    ///<param name="itemId">Filter items by their unique ID. Returns at most one item.</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceInstanceListItems
        (
            id: string,
            accountId: string,
            name: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
            ?sortBy: string,
            ?status: string,
            ?source: string,
            ?metadataFilter: string,
            ?itemId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value)
                  if sortBy.IsSome then
                      RequestPart.query ("sort_by", sortBy.Value)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value)
                  if source.IsSome then
                      RequestPart.query ("source", source.Value)
                  if metadataFilter.IsSome then
                      RequestPart.query ("metadata_filter", metadataFilter.Value)
                  if itemId.IsSome then
                      RequestPart.query ("item_id", itemId.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/items"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceInstanceListItems.OK(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceInstanceListItems.BadRequest(Serializer.deserialize content)
            | 404 -> return AiSearchNamespaceInstanceListItems.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceInstanceListItems.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Uploads a file to a managed AI Search instance via multipart/form-data (max 4MB).
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceInstanceUploadItem
        (
            id: string,
            accountId: string,
            name: string,
            body: AiSearchNamespaceInstanceUploadItemPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/items"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceInstanceUploadItem.OK(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceInstanceUploadItem.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceInstanceUploadItem.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates or updates an indexed item in an AI Search instance.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceInstanceCreateOrUpdateItem
        (
            id: string,
            accountId: string,
            name: string,
            body: AiSearchNamespaceInstanceCreateOrUpdateItemPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/items"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceInstanceCreateOrUpdateItem.OK(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceInstanceCreateOrUpdateItem.BadRequest(Serializer.deserialize content)
            | 404 -> return AiSearchNamespaceInstanceCreateOrUpdateItem.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceInstanceCreateOrUpdateItem.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a file from a managed AI Search instance and triggers a reindex.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="itemId"></param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceInstanceDeleteItem
        (
            id: string,
            itemId: string,
            accountId: string,
            name: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("item_id", itemId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/items/{item_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceInstanceDeleteItem.OK(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceInstanceDeleteItem.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceInstanceDeleteItem.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves a specific indexed item from an AI Search instance.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="itemId"></param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceInstanceGetItem
        (
            id: string,
            itemId: string,
            accountId: string,
            name: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("item_id", itemId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/items/{item_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceInstanceGetItem.OK(Serializer.deserialize content)
            | 404 -> return AiSearchNamespaceInstanceGetItem.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceInstanceGetItem.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Syncs an item to an AI Search instance index.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="itemId"></param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceInstanceSyncItem
        (
            id: string,
            itemId: string,
            accountId: string,
            name: string,
            body: AiSearchNamespaceInstanceSyncItemPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("item_id", itemId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/items/{item_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceInstanceSyncItem.OK(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceInstanceSyncItem.BadRequest(Serializer.deserialize content)
            | 404 -> return AiSearchNamespaceInstanceSyncItem.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceInstanceSyncItem.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists chunks for a specific item in an AI Search instance, including their text content.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="itemId"></param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="limit"></param>
    ///<param name="offset"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceInstanceListItemChunks
        (
            id: string,
            itemId: string,
            accountId: string,
            name: string,
            ?limit: int,
            ?offset: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("item_id", itemId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  if limit.IsSome then
                      RequestPart.query ("limit", limit.Value)
                  if offset.IsSome then
                      RequestPart.query ("offset", offset.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/items/{item_id}/chunks"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceInstanceListItemChunks.OK(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceInstanceListItemChunks.BadRequest(Serializer.deserialize content)
            | 404 -> return AiSearchNamespaceInstanceListItemChunks.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceInstanceListItemChunks.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Downloads the raw file content for a specific item from the managed AI Search instance storage.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="itemId"></param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceInstanceGetItemContent
        (
            id: string,
            itemId: string,
            accountId: string,
            name: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("item_id", itemId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/items/{item_id}/download"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceInstanceGetItemContent.OK content
            | 400 -> return AiSearchNamespaceInstanceGetItemContent.BadRequest(Serializer.deserialize content)
            | 404 -> return AiSearchNamespaceInstanceGetItemContent.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceInstanceGetItemContent.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists processing logs for a specific item in an AI Search instance.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="itemId"></param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="limit"></param>
    ///<param name="cursor"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceInstanceLogsItem
        (
            id: string,
            itemId: string,
            accountId: string,
            name: string,
            ?limit: int,
            ?cursor: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("item_id", itemId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  if limit.IsSome then
                      RequestPart.query ("limit", limit.Value)
                  if cursor.IsSome then
                      RequestPart.query ("cursor", cursor.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/items/{item_id}/logs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceInstanceLogsItem.OK(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceInstanceLogsItem.BadRequest(Serializer.deserialize content)
            | 404 -> return AiSearchNamespaceInstanceLogsItem.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceInstanceLogsItem.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists indexing jobs for an AI Search instance.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="page"></param>
    ///<param name="perPage"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceInstanceListJobs
        (
            id: string,
            accountId: string,
            name: string,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/jobs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceInstanceListJobs.OK(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceInstanceListJobs.BadRequest(Serializer.deserialize content)
            | 404 -> return AiSearchNamespaceInstanceListJobs.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceInstanceListJobs.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new indexing job for an AI Search instance.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceInstanceCreateJob
        (
            id: string,
            accountId: string,
            name: string,
            body: AiSearchNamespaceInstanceCreateJobPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/jobs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceInstanceCreateJob.OK(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceInstanceCreateJob.BadRequest(Serializer.deserialize content)
            | 404 -> return AiSearchNamespaceInstanceCreateJob.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceInstanceCreateJob.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves details for a specific AI Search indexing job.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="jobId"></param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceInstanceGetJob
        (
            id: string,
            jobId: string,
            accountId: string,
            name: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("job_id", jobId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/jobs/{job_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceInstanceGetJob.OK(Serializer.deserialize content)
            | 404 -> return AiSearchNamespaceInstanceGetJob.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceInstanceGetJob.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates the status of an AI Search indexing job.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="jobId"></param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceInstanceChangeJobStatus
        (
            id: string,
            jobId: string,
            accountId: string,
            name: string,
            body: AiSearchNamespaceInstanceChangeJobStatusPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("job_id", jobId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/jobs/{job_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceInstanceChangeJobStatus.OK(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceInstanceChangeJobStatus.BadRequest(Serializer.deserialize content)
            | 404 -> return AiSearchNamespaceInstanceChangeJobStatus.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceInstanceChangeJobStatus.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists log entries for an AI Search indexing job.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="jobId"></param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="page"></param>
    ///<param name="perPage"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceInstanceListJobLogs
        (
            id: string,
            jobId: string,
            accountId: string,
            name: string,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("job_id", jobId)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/jobs/{job_id}/logs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceInstanceListJobLogs.OK(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceInstanceListJobLogs.BadRequest(Serializer.deserialize content)
            | 404 -> return AiSearchNamespaceInstanceListJobLogs.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceInstanceListJobLogs.ServiceUnavailable(Serializer.deserialize content)
        }

    ///<summary>
    ///Executes a semantic search query against an AI Search instance to find relevant indexed content.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceInstanceSearch
        (
            id: string,
            accountId: string,
            name: string,
            body: AiSearchNamespaceInstanceSearchPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/search"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceInstanceSearch.OK(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceInstanceSearch.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceInstanceSearch.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves usage statistics for AI Search instances.
    ///</summary>
    ///<param name="id">AI Search instance ID. Lowercase alphanumeric, hyphens, and underscores.</param>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceStats
        (
            id: string,
            accountId: string,
            name: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("id", id)
                  RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/instances/{id}/stats"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceStats.OK(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceStats.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Multi-Instance Search
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="name">Namespace name</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchNamespaceMultiInstanceSearch
        (
            accountId: string,
            name: string,
            body: AiSearchNamespaceMultiInstanceSearchPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("name", name)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/namespaces/{name}/search"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchNamespaceMultiInstanceSearch.OK(Serializer.deserialize content)
            | 400 -> return AiSearchNamespaceMultiInstanceSearch.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchNamespaceMultiInstanceSearch.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///List tokens.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="page">Page number (1-indexed).</param>
    ///<param name="perPage">Number of results per page.</param>
    ///<param name="search">Filter tokens whose name contains this string (case-insensitive).</param>
    ///<param name="cancellationToken"></param>
    member this.AiSearchListTokens
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if search.IsSome then
                      RequestPart.query ("search", search.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/ai-search/tokens" requestParts cancellationToken

            match int status with
            | 200 -> return AiSearchListTokens.OK(Serializer.deserialize content)
            | _ -> return AiSearchListTokens.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new token.
    ///</summary>
    member this.AiSearchCreateTokens
        (
            accountId: string,
            body: AiSearchCreateTokensPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/tokens"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return AiSearchCreateTokens.Created(Serializer.deserialize content)
            | _ -> return AiSearchCreateTokens.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete token.
    ///</summary>
    member this.AiSearchDeleteTokens(accountId: string, id: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/tokens/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchDeleteTokens.OK(Serializer.deserialize content)
            | 400 -> return AiSearchDeleteTokens.BadRequest(Serializer.deserialize content)
            | 404 -> return AiSearchDeleteTokens.NotFound(Serializer.deserialize content)
            | _ -> return AiSearchDeleteTokens.Conflict(Serializer.deserialize content)
        }

    ///<summary>
    ///Read token.
    ///</summary>
    member this.AiSearchFetchTokens(accountId: string, id: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/tokens/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchFetchTokens.OK(Serializer.deserialize content)
            | 400 -> return AiSearchFetchTokens.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchFetchTokens.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Update token.
    ///</summary>
    member this.AiSearchUpdateTokens
        (
            accountId: string,
            id: System.Guid,
            body: AiSearchUpdateTokensPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("id", id)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/ai-search/tokens/{id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AiSearchUpdateTokens.OK(Serializer.deserialize content)
            | 400 -> return AiSearchUpdateTokens.BadRequest(Serializer.deserialize content)
            | _ -> return AiSearchUpdateTokens.NotFound(Serializer.deserialize content)
        }
