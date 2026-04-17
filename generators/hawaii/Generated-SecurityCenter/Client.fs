namespace rec Fidelity.CloudEdge.Management.SecurityCenter

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.SecurityCenter.Types
open Fidelity.CloudEdge.Management.SecurityCenter.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type SecurityCenterClient(httpClient: HttpClient) =
    ///<summary>
    ///Lists all Security Center insights for the account, showing security findings and recommendations.
    ///</summary>
    member this.GetSecurityCenterInsights
        (
            accountId: string,
            ?dismissed: bool,
            ?issueClass: string,
            ?issueType: string,
            ?product: ``security-centerproducts``,
            ?severity: string,
            ?subject: string,
            ?``issueClass~neq``: ``security-centerissueClasses``,
            ?``issueType~neq``: ``security-centerissueTypes``,
            ?``product~neq``: ``security-centerproducts``,
            ?``severity~neq``: ``security-centerseverityQueryParam``,
            ?``subject~neq``: ``security-centersubjects``,
            ?page: string,
            ?perPage: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if dismissed.IsSome then
                      RequestPart.query ("dismissed", dismissed.Value)
                  if issueClass.IsSome then
                      RequestPart.query ("issue_class", issueClass.Value)
                  if issueType.IsSome then
                      RequestPart.query ("issue_type", issueType.Value)
                  if product.IsSome then
                      RequestPart.query ("product", product.Value)
                  if severity.IsSome then
                      RequestPart.query ("severity", severity.Value)
                  if subject.IsSome then
                      RequestPart.query ("subject", subject.Value)
                  if ``issueClass~neq``.IsSome then
                      RequestPart.query ("issue_class~neq", ``issueClass~neq``.Value)
                  if ``issueType~neq``.IsSome then
                      RequestPart.query ("issue_type~neq", ``issueType~neq``.Value)
                  if ``product~neq``.IsSome then
                      RequestPart.query ("product~neq", ``product~neq``.Value)
                  if ``severity~neq``.IsSome then
                      RequestPart.query ("severity~neq", ``severity~neq``.Value)
                  if ``subject~neq``.IsSome then
                      RequestPart.query ("subject~neq", ``subject~neq``.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/security-center/insights"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetSecurityCenterInsights.OK(Serializer.deserialize content)
            | _ -> return GetSecurityCenterInsights.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves Security Center insight counts aggregated by classification class.
    ///</summary>
    member this.GetSecurityCenterInsightCountsByClass
        (
            accountId: string,
            ?dismissed: bool,
            ?issueClass: string,
            ?issueType: string,
            ?product: ``security-centerproducts``,
            ?severity: string,
            ?subject: string,
            ?``issueClass~neq``: ``security-centerissueClasses``,
            ?``issueType~neq``: ``security-centerissueTypes``,
            ?``product~neq``: ``security-centerproducts``,
            ?``severity~neq``: ``security-centerseverityQueryParam``,
            ?``subject~neq``: ``security-centersubjects``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if dismissed.IsSome then
                      RequestPart.query ("dismissed", dismissed.Value)
                  if issueClass.IsSome then
                      RequestPart.query ("issue_class", issueClass.Value)
                  if issueType.IsSome then
                      RequestPart.query ("issue_type", issueType.Value)
                  if product.IsSome then
                      RequestPart.query ("product", product.Value)
                  if severity.IsSome then
                      RequestPart.query ("severity", severity.Value)
                  if subject.IsSome then
                      RequestPart.query ("subject", subject.Value)
                  if ``issueClass~neq``.IsSome then
                      RequestPart.query ("issue_class~neq", ``issueClass~neq``.Value)
                  if ``issueType~neq``.IsSome then
                      RequestPart.query ("issue_type~neq", ``issueType~neq``.Value)
                  if ``product~neq``.IsSome then
                      RequestPart.query ("product~neq", ``product~neq``.Value)
                  if ``severity~neq``.IsSome then
                      RequestPart.query ("severity~neq", ``severity~neq``.Value)
                  if ``subject~neq``.IsSome then
                      RequestPart.query ("subject~neq", ``subject~neq``.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/security-center/insights/class"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetSecurityCenterInsightCountsByClass.OK(Serializer.deserialize content)
            | _ -> return GetSecurityCenterInsightCountsByClass.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves Security Center insight counts aggregated by severity level (critical, high, medium, low).
    ///</summary>
    member this.GetSecurityCenterInsightCountsBySeverity
        (
            accountId: string,
            ?dismissed: bool,
            ?issueClass: string,
            ?issueType: string,
            ?product: ``security-centerproducts``,
            ?severity: string,
            ?subject: string,
            ?``issueClass~neq``: ``security-centerissueClasses``,
            ?``issueType~neq``: ``security-centerissueTypes``,
            ?``product~neq``: ``security-centerproducts``,
            ?``severity~neq``: ``security-centerseverityQueryParam``,
            ?``subject~neq``: ``security-centersubjects``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if dismissed.IsSome then
                      RequestPart.query ("dismissed", dismissed.Value)
                  if issueClass.IsSome then
                      RequestPart.query ("issue_class", issueClass.Value)
                  if issueType.IsSome then
                      RequestPart.query ("issue_type", issueType.Value)
                  if product.IsSome then
                      RequestPart.query ("product", product.Value)
                  if severity.IsSome then
                      RequestPart.query ("severity", severity.Value)
                  if subject.IsSome then
                      RequestPart.query ("subject", subject.Value)
                  if ``issueClass~neq``.IsSome then
                      RequestPart.query ("issue_class~neq", ``issueClass~neq``.Value)
                  if ``issueType~neq``.IsSome then
                      RequestPart.query ("issue_type~neq", ``issueType~neq``.Value)
                  if ``product~neq``.IsSome then
                      RequestPart.query ("product~neq", ``product~neq``.Value)
                  if ``severity~neq``.IsSome then
                      RequestPart.query ("severity~neq", ``severity~neq``.Value)
                  if ``subject~neq``.IsSome then
                      RequestPart.query ("subject~neq", ``subject~neq``.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/security-center/insights/severity"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetSecurityCenterInsightCountsBySeverity.OK(Serializer.deserialize content)
            | _ -> return GetSecurityCenterInsightCountsBySeverity.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves Security Center insight counts aggregated by insight type.
    ///</summary>
    member this.GetSecurityCenterInsightCountsByType
        (
            accountId: string,
            ?dismissed: bool,
            ?issueClass: string,
            ?issueType: string,
            ?product: ``security-centerproducts``,
            ?severity: string,
            ?subject: string,
            ?``issueClass~neq``: ``security-centerissueClasses``,
            ?``issueType~neq``: ``security-centerissueTypes``,
            ?``product~neq``: ``security-centerproducts``,
            ?``severity~neq``: ``security-centerseverityQueryParam``,
            ?``subject~neq``: ``security-centersubjects``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if dismissed.IsSome then
                      RequestPart.query ("dismissed", dismissed.Value)
                  if issueClass.IsSome then
                      RequestPart.query ("issue_class", issueClass.Value)
                  if issueType.IsSome then
                      RequestPart.query ("issue_type", issueType.Value)
                  if product.IsSome then
                      RequestPart.query ("product", product.Value)
                  if severity.IsSome then
                      RequestPart.query ("severity", severity.Value)
                  if subject.IsSome then
                      RequestPart.query ("subject", subject.Value)
                  if ``issueClass~neq``.IsSome then
                      RequestPart.query ("issue_class~neq", ``issueClass~neq``.Value)
                  if ``issueType~neq``.IsSome then
                      RequestPart.query ("issue_type~neq", ``issueType~neq``.Value)
                  if ``product~neq``.IsSome then
                      RequestPart.query ("product~neq", ``product~neq``.Value)
                  if ``severity~neq``.IsSome then
                      RequestPart.query ("severity~neq", ``severity~neq``.Value)
                  if ``subject~neq``.IsSome then
                      RequestPart.query ("subject~neq", ``subject~neq``.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/security-center/insights/type"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetSecurityCenterInsightCountsByType.OK(Serializer.deserialize content)
            | _ -> return GetSecurityCenterInsightCountsByType.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates the user classification for a Security Center insight. Valid values are 'false_positive' or 'accept_risk'. To reset, set classification to null. Cannot change directly between classification values - must reset to null first.
    ///</summary>
    member this.UpdateSecurityCenterInsightClassification
        (
            accountId: string,
            issueId: string,
            body: ``security-centeruserClassificationUpdate``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("issue_id", issueId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/security-center/insights/{issue_id}/classification"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return UpdateSecurityCenterInsightClassification.OK(Serializer.deserialize content)
            | _ -> return UpdateSecurityCenterInsightClassification.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the full context payload for an insight. This endpoint is used for insights with large payloads that are not included inline in the list response.
    ///</summary>
    member this.GetSecurityCenterInsightContext
        (
            accountId: string,
            issueId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("issue_id", issueId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/security-center/insights/{issue_id}/context"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetSecurityCenterInsightContext.OK(Serializer.deserialize content)
            | _ -> return GetSecurityCenterInsightContext.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Archives a Security Center insight for an account, removing it from the active insights list while preserving historical data.
    ///</summary>
    member this.ArchiveSecurityCenterInsight
        (
            accountId: string,
            issueId: string,
            body: ArchiveSecurityCenterInsightPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("issue_id", issueId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/accounts/{account_id}/security-center/insights/{issue_id}/dismiss"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return ArchiveSecurityCenterInsight.OK(Serializer.deserialize content)
            | _ -> return ArchiveSecurityCenterInsight.BadRequest(Serializer.deserialize content)
        }
