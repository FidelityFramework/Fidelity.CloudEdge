namespace rec Fidelity.CloudEdge.Management.Builds

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Builds.Types
open Fidelity.CloudEdge.Management.Builds.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type BuildsClient(httpClient: HttpClient) =
    ///<summary>
    ///Retrieve account limits and usage information
    ///</summary>
    member this.GetAccountLimits(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/builds/account/limits"
                    requestParts
                    cancellationToken

            return GetAccountLimits.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieve builds for specific version IDs
    ///</summary>
    member this.GetBuildsByVersionIds(accountId: string, versionIds: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.query ("version_ids", versionIds) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/builds/builds" requestParts cancellationToken

            return GetBuildsByVersionIds.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieve the most recent builds for multiple worker scripts
    ///</summary>
    member this.GetLatestBuildsByScripts
        (
            accountId: string,
            externalScriptIds: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.query ("external_script_ids", externalScriptIds) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/builds/builds/latest"
                    requestParts
                    cancellationToken

            return GetLatestBuildsByScripts.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieve detailed information about a specific build
    ///</summary>
    member this.GetBuildByUuid(accountId: string, buildUuid: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("build_uuid", buildUuid) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/builds/builds/{build_uuid}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetBuildByUuid.OK(Serializer.deserialize content)
            | _ -> return GetBuildByUuid.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Cancel a running or queued build
    ///</summary>
    member this.CancelBuildByUuid(accountId: string, buildUuid: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("build_uuid", buildUuid) ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/builds/builds/{build_uuid}/cancel"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CancelBuildByUuid.OK(Serializer.deserialize content)
            | _ -> return CancelBuildByUuid.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieve logs for a specific build with cursor-based pagination
    ///</summary>
    member this.GetBuildLogs
        (
            accountId: string,
            buildUuid: System.Guid,
            ?cursor: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("build_uuid", buildUuid)
                  if cursor.IsSome then
                      RequestPart.query ("cursor", cursor.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/builds/builds/{build_uuid}/logs"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetBuildLogs.OK(Serializer.deserialize content)
            | _ -> return GetBuildLogs.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Upsert a repository connection for CI/CD integration
    ///</summary>
    member this.UpsertRepoConnection
        (
            accountId: string,
            body: buildsUpsertRepoConnectionRequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/builds/repos/connections"
                    requestParts
                    cancellationToken

            return UpsertRepoConnection.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Remove a repository connection
    ///</summary>
    member this.DeleteRepoConnection
        (
            accountId: string,
            repoConnectionUuid: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("repo_connection_uuid", repoConnectionUuid) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/builds/repos/connections/{repo_connection_uuid}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteRepoConnection.OK(Serializer.deserialize content)
            | _ -> return DeleteRepoConnection.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Analyze repository for automatic configuration detection
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="providerType">SCM provider type</param>
    ///<param name="providerAccountId"></param>
    ///<param name="repoId"></param>
    ///<param name="branch"></param>
    ///<param name="rootDirectory"></param>
    ///<param name="cancellationToken"></param>
    member this.GetWorkerConfigAutofill
        (
            accountId: string,
            providerType: string,
            providerAccountId: string,
            repoId: string,
            branch: string,
            ?rootDirectory: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("provider_type", providerType)
                  RequestPart.path ("provider_account_id", providerAccountId)
                  RequestPart.path ("repo_id", repoId)
                  RequestPart.query ("branch", branch)
                  if rootDirectory.IsSome then
                      RequestPart.query ("root_directory", rootDirectory.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/builds/repos/{provider_type}/{provider_account_id}/{repo_id}/config_autofill"
                    requestParts
                    cancellationToken

            return GetWorkerConfigAutofill.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get all build tokens with pagination
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="page">Page number for pagination</param>
    ///<param name="perPage">Number of items per page</param>
    ///<param name="cancellationToken"></param>
    member this.ListBuildTokens(accountId: string, ?page: int, ?perPage: int, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/accounts/{account_id}/builds/tokens" requestParts cancellationToken

            return ListBuildTokens.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new build authentication token
    ///</summary>
    member this.CreateBuildToken
        (
            accountId: string,
            body: buildsCreateBuildTokenRequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/builds/tokens" requestParts cancellationToken

            return CreateBuildToken.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Remove a build authentication token
    ///</summary>
    member this.DeleteBuildToken
        (
            accountId: string,
            buildTokenUuid: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("build_token_uuid", buildTokenUuid) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/builds/tokens/{build_token_uuid}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteBuildToken.OK(Serializer.deserialize content)
            | _ -> return DeleteBuildToken.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new CI/CD trigger
    ///</summary>
    member this.CreateTrigger
        (
            accountId: string,
            body: buildsCreateTriggerRequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync httpClient "/accounts/{account_id}/builds/triggers" requestParts cancellationToken

            return CreateTrigger.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Remove a CI/CD trigger
    ///</summary>
    member this.DeleteTrigger(accountId: string, triggerUuid: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("trigger_uuid", triggerUuid) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/builds/triggers/{trigger_uuid}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteTrigger.OK(Serializer.deserialize content)
            | _ -> return DeleteTrigger.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Update an existing CI/CD trigger
    ///</summary>
    member this.UpdateTrigger
        (
            accountId: string,
            triggerUuid: System.Guid,
            body: buildsUpdateTriggerRequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("trigger_uuid", triggerUuid)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/builds/triggers/{trigger_uuid}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpdateTrigger.OK(Serializer.deserialize content)
            | _ -> return UpdateTrigger.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Trigger a manual build for a specific trigger
    ///</summary>
    member this.CreateManualBuild
        (
            accountId: string,
            triggerUuid: System.Guid,
            body: buildsCreateBuildRequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("trigger_uuid", triggerUuid)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/builds/triggers/{trigger_uuid}/builds"
                    requestParts
                    cancellationToken

            return CreateManualBuild.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get all environment variables for a trigger
    ///</summary>
    member this.ListEnvironmentVariables
        (
            accountId: string,
            triggerUuid: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("trigger_uuid", triggerUuid) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/builds/triggers/{trigger_uuid}/environment_variables"
                    requestParts
                    cancellationToken

            return ListEnvironmentVariables.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Create or update environment variables for a trigger
    ///</summary>
    member this.UpsertEnvironmentVariables
        (
            accountId: string,
            triggerUuid: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("trigger_uuid", triggerUuid) ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/builds/triggers/{trigger_uuid}/environment_variables"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpsertEnvironmentVariables.OK(Serializer.deserialize content)
            | _ -> return UpsertEnvironmentVariables.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Remove a specific environment variable from a trigger
    ///</summary>
    member this.DeleteEnvironmentVariable
        (
            accountId: string,
            triggerUuid: System.Guid,
            environmentVariableKey: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("trigger_uuid", triggerUuid)
                  RequestPart.path ("environment_variable_key", environmentVariableKey) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/builds/triggers/{trigger_uuid}/environment_variables/{environment_variable_key}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteEnvironmentVariable.OK(Serializer.deserialize content)
            | _ -> return DeleteEnvironmentVariable.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Clear the build cache for a specific trigger
    ///</summary>
    member this.PurgeBuildCache(accountId: string, triggerUuid: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("trigger_uuid", triggerUuid) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/builds/triggers/{trigger_uuid}/purge_build_cache"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PurgeBuildCache.OK(Serializer.deserialize content)
            | _ -> return PurgeBuildCache.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Get all builds for a specific worker script with pagination
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="externalScriptId"></param>
    ///<param name="page">Page number for pagination</param>
    ///<param name="perPage">Number of items per page</param>
    ///<param name="cancellationToken"></param>
    member this.ListBuildsByScript
        (
            accountId: string,
            externalScriptId: string,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("external_script_id", externalScriptId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/builds/workers/{external_script_id}/builds"
                    requestParts
                    cancellationToken

            return ListBuildsByScript.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get all triggers for a specific worker script
    ///</summary>
    member this.ListTriggersByScript
        (
            accountId: string,
            externalScriptId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("external_script_id", externalScriptId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/builds/workers/{external_script_id}/triggers"
                    requestParts
                    cancellationToken

            return ListTriggersByScript.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Get all deploy hooks for a specific worker script.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="scriptName">Human-readable name of the worker.</param>
    ///<param name="cancellationToken"></param>
    member this.ListDeployHooks(accountId: string, scriptName: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/builds/workers/{script_name}/deploy_hooks"
                    requestParts
                    cancellationToken

            return ListDeployHooks.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new deploy hook for a worker script.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="scriptName">Human-readable name of the worker.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.CreateDeployHook
        (
            accountId: string,
            scriptName: string,
            body: buildsCreateDeployHookRequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/builds/workers/{script_name}/deploy_hooks"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CreateDeployHook.OK(Serializer.deserialize content)
            | 400 -> return CreateDeployHook.BadRequest(Serializer.deserialize content)
            | 404 -> return CreateDeployHook.NotFound(Serializer.deserialize content)
            | _ -> return CreateDeployHook.Conflict(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a deploy hook.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="scriptName">Human-readable name of the worker.</param>
    ///<param name="deployHookUuid">Deploy hook UUID</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteDeployHook
        (
            accountId: string,
            scriptName: string,
            deployHookUuid: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName)
                  RequestPart.path ("deploy_hook_uuid", deployHookUuid) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/builds/workers/{script_name}/deploy_hooks/{deploy_hook_uuid}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteDeployHook.OK(Serializer.deserialize content)
            | _ -> return DeleteDeployHook.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Get details of a specific deploy hook.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="scriptName">Human-readable name of the worker.</param>
    ///<param name="deployHookUuid">Deploy hook UUID</param>
    ///<param name="cancellationToken"></param>
    member this.GetDeployHook
        (
            accountId: string,
            scriptName: string,
            deployHookUuid: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName)
                  RequestPart.path ("deploy_hook_uuid", deployHookUuid) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/builds/workers/{script_name}/deploy_hooks/{deploy_hook_uuid}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetDeployHook.OK(Serializer.deserialize content)
            | _ -> return GetDeployHook.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Update an existing deploy hook.
    ///</summary>
    ///<param name="accountId"></param>
    ///<param name="scriptName">Human-readable name of the worker.</param>
    ///<param name="deployHookUuid">Deploy hook UUID</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.UpdateDeployHook
        (
            accountId: string,
            scriptName: string,
            deployHookUuid: System.Guid,
            body: buildsCreateDeployHookRequest,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("script_name", scriptName)
                  RequestPart.path ("deploy_hook_uuid", deployHookUuid)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/builds/workers/{script_name}/deploy_hooks/{deploy_hook_uuid}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpdateDeployHook.OK(Serializer.deserialize content)
            | 400 -> return UpdateDeployHook.BadRequest(Serializer.deserialize content)
            | 404 -> return UpdateDeployHook.NotFound(Serializer.deserialize content)
            | _ -> return UpdateDeployHook.Conflict(Serializer.deserialize content)
        }
