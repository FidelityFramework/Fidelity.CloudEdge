namespace rec Fidelity.CloudEdge.Management.VulnScanner

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.VulnScanner.Types
open Fidelity.CloudEdge.Management.VulnScanner.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type VulnScannerClient(httpClient: HttpClient) =
    ///<summary>
    ///Returns all credential sets for the account.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="page">Page number of paginated results.</param>
    ///<param name="perPage">Number of results per page.</param>
    ///<param name="cancellationToken"></param>
    member this.ListCredentialSets
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/credential_sets"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ListCredentialSets.OK(Serializer.deserialize content)
            | _ -> return ListCredentialSets.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new credential set.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.CreateCredentialSet
        (
            accountId: string,
            body: ``vulnscannercreate-credential-set-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/credential_sets"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CreateCredentialSet.OK(Serializer.deserialize content)
            | _ -> return CreateCredentialSet.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a credential set and all of its credentials.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="credentialSetId">Credential set identifier.</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteCredentialSet
        (
            accountId: string,
            credentialSetId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("credential_set_id", credentialSetId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/credential_sets/{credential_set_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteCredentialSet.OK(Serializer.deserialize content)
            | _ -> return DeleteCredentialSet.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a single credential set by ID.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="credentialSetId">Credential set identifier.</param>
    ///<param name="cancellationToken"></param>
    member this.GetCredentialSet
        (
            accountId: string,
            credentialSetId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("credential_set_id", credentialSetId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/credential_sets/{credential_set_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetCredentialSet.OK(Serializer.deserialize content)
            | _ -> return GetCredentialSet.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a credential set with only the provided fields; omitted fields remain unchanged.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="credentialSetId">Credential set identifier.</param>
    ///<param name="body">Applies a partial update. Only the provided fields change; omitted fields remain unchanged.</param>
    ///<param name="cancellationToken"></param>
    member this.EditCredentialSet
        (
            accountId: string,
            credentialSetId: System.Guid,
            body: ``vulnscannerpatch-credential-set-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("credential_set_id", credentialSetId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/credential_sets/{credential_set_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EditCredentialSet.OK(Serializer.deserialize content)
            | _ -> return EditCredentialSet.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Replaces a credential set. All fields must be provided.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="credentialSetId">Credential set identifier.</param>
    ///<param name="body">Full replacement. Provide all fields.</param>
    ///<param name="cancellationToken"></param>
    member this.UpdateCredentialSet
        (
            accountId: string,
            credentialSetId: System.Guid,
            body: ``vulnscannerupdate-credential-set-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("credential_set_id", credentialSetId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/credential_sets/{credential_set_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpdateCredentialSet.OK(Serializer.deserialize content)
            | _ -> return UpdateCredentialSet.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns all credentials within a credential set.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="credentialSetId">Credential set identifier.</param>
    ///<param name="page">Page number of paginated results.</param>
    ///<param name="perPage">Number of results per page.</param>
    ///<param name="cancellationToken"></param>
    member this.ListCredentials
        (
            accountId: string,
            credentialSetId: System.Guid,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("credential_set_id", credentialSetId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/credential_sets/{credential_set_id}/credentials"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ListCredentials.OK(Serializer.deserialize content)
            | _ -> return ListCredentials.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new credential within a credential set.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="credentialSetId">Credential set identifier.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.CreateCredential
        (
            accountId: string,
            credentialSetId: System.Guid,
            body: ``vulnscannercreate-credential-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("credential_set_id", credentialSetId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/credential_sets/{credential_set_id}/credentials"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CreateCredential.OK(Serializer.deserialize content)
            | _ -> return CreateCredential.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a credential.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="credentialSetId">Credential set identifier.</param>
    ///<param name="credentialId">Credential identifier.</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteCredential
        (
            accountId: string,
            credentialSetId: System.Guid,
            credentialId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("credential_set_id", credentialSetId)
                  RequestPart.path ("credential_id", credentialId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/credential_sets/{credential_set_id}/credentials/{credential_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteCredential.OK(Serializer.deserialize content)
            | _ -> return DeleteCredential.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a single credential by ID.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="credentialSetId">Credential set identifier.</param>
    ///<param name="credentialId">Credential identifier.</param>
    ///<param name="cancellationToken"></param>
    member this.GetCredential
        (
            accountId: string,
            credentialSetId: System.Guid,
            credentialId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("credential_set_id", credentialSetId)
                  RequestPart.path ("credential_id", credentialId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/credential_sets/{credential_set_id}/credentials/{credential_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetCredential.OK(Serializer.deserialize content)
            | _ -> return GetCredential.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a credential with only the provided fields; omitted fields remain unchanged.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="credentialSetId">Credential set identifier.</param>
    ///<param name="credentialId">Credential identifier.</param>
    ///<param name="body">Applies a partial update. Only the provided fields change; omitted fields remain unchanged.</param>
    ///<param name="cancellationToken"></param>
    member this.EditCredential
        (
            accountId: string,
            credentialSetId: System.Guid,
            credentialId: System.Guid,
            body: ``vulnscannerpatch-credential-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("credential_set_id", credentialSetId)
                  RequestPart.path ("credential_id", credentialId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/credential_sets/{credential_set_id}/credentials/{credential_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EditCredential.OK(Serializer.deserialize content)
            | _ -> return EditCredential.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Replaces a credential. All fields must be provided.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="credentialSetId">Credential set identifier.</param>
    ///<param name="credentialId">Credential identifier.</param>
    ///<param name="body">Full replacement. Provide all fields.</param>
    ///<param name="cancellationToken"></param>
    member this.UpdateCredential
        (
            accountId: string,
            credentialSetId: System.Guid,
            credentialId: System.Guid,
            body: ``vulnscannerupdate-credential-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("credential_set_id", credentialSetId)
                  RequestPart.path ("credential_id", credentialId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/credential_sets/{credential_set_id}/credentials/{credential_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpdateCredential.OK(Serializer.deserialize content)
            | _ -> return UpdateCredential.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns all scans for the account.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="page">Page number of paginated results.</param>
    ///<param name="perPage">Number of results per page.</param>
    ///<param name="cancellationToken"></param>
    member this.ListScans(accountId: string, ?page: int, ?perPage: int, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/scans"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ListScans.OK(Serializer.deserialize content)
            | _ -> return ListScans.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates and starts a new vulnerability scan. The response may include
    ///non-fatal warnings in the `messages` array.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="cancellationToken"></param>
    member this.CreateScan(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/scans"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CreateScan.OK(Serializer.deserialize content)
            | _ -> return CreateScan.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a single scan by ID.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="scanId">Scan identifier.</param>
    ///<param name="cancellationToken"></param>
    member this.GetScan(accountId: string, scanId: System.Guid, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("scan_id", scanId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/scans/{scan_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetScan.OK(Serializer.deserialize content)
            | _ -> return GetScan.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns all target environments for the account.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="page">Page number of paginated results.</param>
    ///<param name="perPage">Number of results per page.</param>
    ///<param name="cancellationToken"></param>
    member this.ListTargetEnvironments
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/target_environments"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ListTargetEnvironments.OK(Serializer.deserialize content)
            | _ -> return ListTargetEnvironments.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new target environment for the account.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.CreateTargetEnvironment
        (
            accountId: string,
            body: ``vulnscannercreate-target-environment-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/target_environments"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return CreateTargetEnvironment.OK(Serializer.deserialize content)
            | _ -> return CreateTargetEnvironment.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Removes a target environment.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="targetEnvironmentId">Target environment identifier.</param>
    ///<param name="cancellationToken"></param>
    member this.DeleteTargetEnvironment
        (
            accountId: string,
            targetEnvironmentId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("target_environment_id", targetEnvironmentId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/target_environments/{target_environment_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeleteTargetEnvironment.OK(Serializer.deserialize content)
            | _ -> return DeleteTargetEnvironment.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a single target environment by ID.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="targetEnvironmentId">Target environment identifier.</param>
    ///<param name="cancellationToken"></param>
    member this.GetTargetEnvironment
        (
            accountId: string,
            targetEnvironmentId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("target_environment_id", targetEnvironmentId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/target_environments/{target_environment_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetTargetEnvironment.OK(Serializer.deserialize content)
            | _ -> return GetTargetEnvironment.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates a target environment with only the provided fields; omitted fields remain unchanged.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="targetEnvironmentId">Target environment identifier.</param>
    ///<param name="body">
    ///Applies a partial update. Only the provided fields change; omitted fields remain unchanged.
    ///The `description` field supports three states:
    ///- **omitted**: leave unchanged
    ///- **`null`**: clear the description
    ///- **`"value"`**: set to the given string
    ///</param>
    ///<param name="cancellationToken"></param>
    member this.EditTargetEnvironment
        (
            accountId: string,
            targetEnvironmentId: System.Guid,
            body: ``vulnscannerpatch-target-environment-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("target_environment_id", targetEnvironmentId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/target_environments/{target_environment_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EditTargetEnvironment.OK(Serializer.deserialize content)
            | _ -> return EditTargetEnvironment.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Replaces a target environment. All fields must be provided.
    ///</summary>
    ///<param name="accountId">Account identifier.</param>
    ///<param name="targetEnvironmentId">Target environment identifier.</param>
    ///<param name="body">Full replacement.</param>
    ///<param name="cancellationToken"></param>
    member this.UpdateTargetEnvironment
        (
            accountId: string,
            targetEnvironmentId: System.Guid,
            body: ``vulnscannerupdate-target-environment-request``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("target_environment_id", targetEnvironmentId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/vuln_scanner/target_environments/{target_environment_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpdateTargetEnvironment.OK(Serializer.deserialize content)
            | _ -> return UpdateTargetEnvironment.BadRequest(Serializer.deserialize content)
        }
