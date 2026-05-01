namespace rec Fidelity.CloudEdge.Management.Email

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Email.Types
open Fidelity.CloudEdge.Management.Email.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type EmailClient(httpClient: HttpClient) =
    ///<summary>
    ///Returns information for each email that matches the search parameter(s).
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="start">The beginning of the search date range. Defaults to `now - 30 days`.</param>
    ///<param name="end">The end of the search date range. Defaults to `now`.</param>
    ///<param name="query">Space-delimited search term. Case-insensitive.</param>
    ///<param name="detectionsOnly">Whether to include only detections in search results.</param>
    ///<param name="actionLog">Whether to include the message action log in the response.</param>
    ///<param name="finalDisposition">Dispositions to filter by.</param>
    ///<param name="metric"></param>
    ///<param name="messageAction">Message actions to filter by.</param>
    ///<param name="recipient"></param>
    ///<param name="sender"></param>
    ///<param name="alertId"></param>
    ///<param name="domain">Sender domains to filter by.</param>
    ///<param name="messageId"></param>
    ///<param name="subject"></param>
    ///<param name="cursor"></param>
    ///<param name="perPage">The number of results per page. Maximum value is 1000.</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityInvestigate
        (
            accountId: string,
            ?start: System.DateTimeOffset,
            ?``end``: System.DateTimeOffset,
            ?query: string,
            ?detectionsOnly: bool,
            ?actionLog: bool,
            ?finalDisposition: string,
            ?metric: string,
            ?messageAction: string,
            ?recipient: string,
            ?sender: string,
            ?alertId: string,
            ?domain: string,
            ?messageId: string,
            ?subject: string,
            ?cursor: string,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if start.IsSome then
                      RequestPart.query ("start", start.Value)
                  if ``end``.IsSome then
                      RequestPart.query ("end", ``end``.Value)
                  if query.IsSome then
                      RequestPart.query ("query", query.Value)
                  if detectionsOnly.IsSome then
                      RequestPart.query ("detections_only", detectionsOnly.Value)
                  if actionLog.IsSome then
                      RequestPart.query ("action_log", actionLog.Value)
                  if finalDisposition.IsSome then
                      RequestPart.query ("final_disposition", finalDisposition.Value)
                  if metric.IsSome then
                      RequestPart.query ("metric", metric.Value)
                  if messageAction.IsSome then
                      RequestPart.query ("message_action", messageAction.Value)
                  if recipient.IsSome then
                      RequestPart.query ("recipient", recipient.Value)
                  if sender.IsSome then
                      RequestPart.query ("sender", sender.Value)
                  if alertId.IsSome then
                      RequestPart.query ("alert_id", alertId.Value)
                  if domain.IsSome then
                      RequestPart.query ("domain", domain.Value)
                  if messageId.IsSome then
                      RequestPart.query ("message_id", messageId.Value)
                  if subject.IsSome then
                      RequestPart.query ("subject", subject.Value)
                  if cursor.IsSome then
                      RequestPart.query ("cursor", cursor.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityInvestigate.OK(Serializer.deserialize content)
            | 202 -> return EmailSecurityInvestigate.Accepted(Serializer.deserialize content)
            | _ -> return EmailSecurityInvestigate.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Moves multiple messages to a specified mailbox folder (Inbox, JunkEmail, DeletedItems, RecoverableItemsDeletions, or RecoverableItemsPurges). Requires active integration.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityPostBulkMove
        (
            accountId: string,
            body: EmailSecurityPostBulkMovePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/move"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityPostBulkMove.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityPostBulkMove.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Generates a preview image for a message that was not flagged as a detection. Useful for investigating benign messages. Returns a base64-encoded PNG screenshot of the email body.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityPostPreview
        (
            accountId: string,
            body: EmailSecurityPostPreviewPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/preview"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityPostPreview.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityPostPreview.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Releases one or more quarantined messages, delivering them to the intended recipients. Use when a message was incorrectly quarantined. Returns delivery status for each recipient.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityPostRelease(accountId: string, body: list<string>, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/release"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityPostRelease.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityPostRelease.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves comprehensive details for a specific email message including headers, recipients, sender information, and current quarantine status. Use the investigate_id from search results to fetch detailed information.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="investigateId"></param>
    ///<param name="submission">
    ///When true, search the submissions datastore only. When false or omitted, search the
    ///regular datastore only.
    ///</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityGetMessage
        (
            accountId: string,
            investigateId: string,
            ?submission: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("investigate_id", investigateId)
                  if submission.IsSome then
                      RequestPart.query ("submission", submission.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/{investigate_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetMessage.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetMessage.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the list of post-delivery actions (moves, quarantine releases, previews, etc.) that have been applied to a specific email message.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="investigateId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityGetMessageActionLog
        (
            accountId: string,
            investigateId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("investigate_id", investigateId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/{investigate_id}/action_log"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetMessageActionLog.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetMessageActionLog.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns detection details such as threat categories and sender information for non-benign messages.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="investigateId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityGetMessageDetections
        (
            accountId: string,
            investigateId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("investigate_id", investigateId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/{investigate_id}/detections"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetMessageDetections.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetMessageDetections.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Moves a single message to a specified mailbox folder (Inbox, JunkEmail, DeletedItems, RecoverableItemsDeletions, or RecoverableItemsPurges). Requires active integration.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="investigateId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityPostMessageMove
        (
            accountId: string,
            investigateId: string,
            body: EmailSecurityPostMessageMovePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("investigate_id", investigateId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/{investigate_id}/move"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityPostMessageMove.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityPostMessageMove.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a preview of the message body as a base64 encoded PNG image for non-benign messages.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="investigateId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityGetMessagePreview
        (
            accountId: string,
            investigateId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("investigate_id", investigateId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/{investigate_id}/preview"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetMessagePreview.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetMessagePreview.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the raw eml of any non-benign message.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="investigateId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityGetMessageRaw
        (
            accountId: string,
            investigateId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("investigate_id", investigateId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/{investigate_id}/raw"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetMessageRaw.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetMessageRaw.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Submits a request to reclassify an email's disposition. Use for reporting false positives or false negatives. Optionally provide the raw EML content for reanalysis. The reclassification is processed asynchronously.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="investigateId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityPostReclassify
        (
            accountId: string,
            investigateId: string,
            body: ``email-securityReclassifyRequest``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("investigate_id", investigateId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/{investigate_id}/reclassify"
                    requestParts
                    cancellationToken

            match int status with
            | 202 -> return EmailSecurityPostReclassify.Accepted(Serializer.deserialize content)
            | _ -> return EmailSecurityPostReclassify.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves delivery and processing trace information for an email message. Shows the delivery path, retraction history, and move operations performed on the message. Useful for debugging delivery issues.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="investigateId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityGetMessageTrace
        (
            accountId: string,
            investigateId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("investigate_id", investigateId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/investigate/{investigate_id}/trace"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetMessageTrace.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetMessageTrace.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves PhishGuard security alert reports for a specified date range. Reports include detected threats, dispositions, and contextual information. Use for security monitoring and threat analysis.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="start">Start of the time range (RFC3339). Takes precedence over from_date.</param>
    ///<param name="end">End of the time range (RFC3339). Takes precedence over to_date.</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityGetPhishguardReports
        (
            accountId: string,
            ?start: System.DateTimeOffset,
            ?``end``: System.DateTimeOffset,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if start.IsSome then
                      RequestPart.query ("start", start.Value)
                  if ``end``.IsSome then
                      RequestPart.query ("end", ``end``.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/phishguard/reports"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetPhishguardReports.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetPhishguardReports.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a paginated list of email allow policies. These policies exempt matching emails from security detection, allowing them to bypass disposition actions. Supports filtering by pattern type and policy attributes.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="page">Current page within paginated list of results.</param>
    ///<param name="perPage">The number of results per page. Maximum value is 1000.</param>
    ///<param name="search">Search term for filtering records. Behavior may change.</param>
    ///<param name="order">Field to sort by.</param>
    ///<param name="direction">The sorting direction.</param>
    ///<param name="isExemptRecipient">Filter to show only policies where messages to the recipient bypass all detections.</param>
    ///<param name="isTrustedSender">Filter to show only policies where messages from the sender bypass all detections and link following.</param>
    ///<param name="isAcceptableSender">Filter to show only policies where messages from the sender are exempted from Spam, Spoof, and Bulk dispositions (not Malicious or Suspicious).</param>
    ///<param name="verifySender">Filter to show only policies that enforce DMARC, SPF, or DKIM authentication.</param>
    ///<param name="patternType"></param>
    ///<param name="pattern"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityListAllowPolicies
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
            ?order: string,
            ?direction: string,
            ?isExemptRecipient: bool,
            ?isTrustedSender: bool,
            ?isAcceptableSender: bool,
            ?verifySender: bool,
            ?patternType: string,
            ?pattern: string,
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
                  if order.IsSome then
                      RequestPart.query ("order", order.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if isExemptRecipient.IsSome then
                      RequestPart.query ("is_exempt_recipient", isExemptRecipient.Value)
                  if isTrustedSender.IsSome then
                      RequestPart.query ("is_trusted_sender", isTrustedSender.Value)
                  if isAcceptableSender.IsSome then
                      RequestPart.query ("is_acceptable_sender", isAcceptableSender.Value)
                  if verifySender.IsSome then
                      RequestPart.query ("verify_sender", verifySender.Value)
                  if patternType.IsSome then
                      RequestPart.query ("pattern_type", patternType.Value)
                  if pattern.IsSome then
                      RequestPart.query ("pattern", pattern.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/allow_policies"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityListAllowPolicies.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityListAllowPolicies.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new allow policy that exempts matching emails from security detections. Use with caution as this bypasses email security scanning. Policies can match on sender patterns and apply to specific detections or all detections.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="body">Create an allow policy</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityCreateAllowPolicy
        (
            accountId: string,
            body: ``email-securityCreateAllowPolicy``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/allow_policies"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return EmailSecurityCreateAllowPolicy.Created(Serializer.deserialize content)
            | _ -> return EmailSecurityCreateAllowPolicy.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Execute multiple operations atomically. All four operation arrays
    ///(deletes, patches, puts, posts) are required and executed in order.
    ///Send empty arrays for unused operations.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityBatchAllowPolicies
        (
            accountId: string,
            body: EmailSecurityBatchAllowPoliciesPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/allow_policies/batch"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityBatchAllowPolicies.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityBatchAllowPolicies.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Removes an allow policy. After deletion, emails matching this pattern will be subject to normal security scanning and disposition actions.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="policyId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityDeleteAllowPolicy
        (
            accountId: string,
            policyId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("policy_id", policyId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/allow_policies/{policy_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityDeleteAllowPolicy.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityDeleteAllowPolicy.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves details for a specific allow policy including its pattern, dispositions that are exempted, and whether it applies to all detections.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="policyId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityGetAllowPolicy
        (
            accountId: string,
            policyId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("policy_id", policyId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/allow_policies/{policy_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetAllowPolicy.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetAllowPolicy.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an existing allow policy. Only provided fields will be modified. Changes take effect for new emails matching the pattern.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="policyId"></param>
    ///<param name="body">Update an allow policy</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityUpdateAllowPolicy
        (
            accountId: string,
            policyId: System.Guid,
            body: ``email-securityUpdateAllowPolicy``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("policy_id", policyId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/allow_policies/{policy_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityUpdateAllowPolicy.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityUpdateAllowPolicy.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a paginated list of blocked email sender patterns. These patterns prevent emails from matching senders from being delivered. Supports filtering by pattern type and searching across patterns.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="page">Current page within paginated list of results.</param>
    ///<param name="perPage">The number of results per page. Maximum value is 1000.</param>
    ///<param name="search">Search term for filtering records. Behavior may change.</param>
    ///<param name="order">Field to sort by.</param>
    ///<param name="direction">The sorting direction.</param>
    ///<param name="patternType">Filter by pattern type.</param>
    ///<param name="pattern">Filter by pattern value.</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityListBlockedSenders
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
            ?order: string,
            ?direction: string,
            ?patternType: string,
            ?pattern: string,
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
                  if order.IsSome then
                      RequestPart.query ("order", order.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if patternType.IsSome then
                      RequestPart.query ("pattern_type", patternType.Value)
                  if pattern.IsSome then
                      RequestPart.query ("pattern", pattern.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/block_senders"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityListBlockedSenders.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityListBlockedSenders.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new blocked sender pattern. Emails matching this pattern will be blocked from delivery. Patterns can be email addresses, domains, or IP addresses, and support regular expressions.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="body">Create a blocked sender pattern</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityCreateBlockedSender
        (
            accountId: string,
            body: ``email-securityCreateBlockedSender``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/block_senders"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return EmailSecurityCreateBlockedSender.Created(Serializer.deserialize content)
            | _ -> return EmailSecurityCreateBlockedSender.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Execute multiple operations atomically. All four operation arrays
    ///(deletes, patches, puts, posts) are required and executed in order.
    ///Send empty arrays for unused operations.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityBatchBlockedSenders
        (
            accountId: string,
            body: EmailSecurityBatchBlockedSendersPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/block_senders/batch"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityBatchBlockedSenders.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityBatchBlockedSenders.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Removes a blocked sender pattern. After deletion, emails from this sender will no longer be automatically blocked based on this rule.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="patternId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityDeleteBlockedSender
        (
            accountId: string,
            patternId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("pattern_id", patternId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/block_senders/{pattern_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityDeleteBlockedSender.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityDeleteBlockedSender.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves details for a specific blocked sender pattern including its pattern type, value, and metadata.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="patternId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityGetBlockedSender
        (
            accountId: string,
            patternId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("pattern_id", patternId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/block_senders/{pattern_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetBlockedSender.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetBlockedSender.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an existing blocked sender pattern. Only provided fields will be modified. The pattern will continue blocking emails until deleted.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="patternId"></param>
    ///<param name="body">Update a blocked sender pattern</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityUpdateBlockedSender
        (
            accountId: string,
            patternId: System.Guid,
            body: ``email-securityUpdateBlockedSender``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("pattern_id", patternId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/block_senders/{pattern_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityUpdateBlockedSender.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityUpdateBlockedSender.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a paginated list of email domains protected by Email Security. Includes domain configuration, delivery modes, and authorization status. Supports filtering by delivery mode and integration ID.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="page">Current page within paginated list of results.</param>
    ///<param name="perPage">The number of results per page. Maximum value is 1000.</param>
    ///<param name="search">Search term for filtering records. Behavior may change.</param>
    ///<param name="order">Field to sort by.</param>
    ///<param name="direction">The sorting direction.</param>
    ///<param name="allowedDeliveryMode">Delivery mode to filter by.</param>
    ///<param name="domain">Domain names to filter by.</param>
    ///<param name="activeDeliveryMode">Currently active delivery mode to filter by.</param>
    ///<param name="integrationId">Integration ID to filter by.</param>
    ///<param name="status">Filters response to domains with the provided status.</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityListDomains
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
            ?order: string,
            ?direction: string,
            ?allowedDeliveryMode: string,
            ?domain: list<string>,
            ?activeDeliveryMode: string,
            ?integrationId: System.Guid,
            ?status: string,
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
                  if order.IsSome then
                      RequestPart.query ("order", order.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if allowedDeliveryMode.IsSome then
                      RequestPart.query ("allowed_delivery_mode", allowedDeliveryMode.Value)
                  if domain.IsSome then
                      RequestPart.query ("domain", domain.Value)
                  if activeDeliveryMode.IsSome then
                      RequestPart.query ("active_delivery_mode", activeDeliveryMode.Value)
                  if integrationId.IsSome then
                      RequestPart.query ("integration_id", integrationId.Value)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/domains"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityListDomains.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityListDomains.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Removes email security protection from a domain. After deletion, emails for this domain will no longer be processed by Email Security. This action cannot be undone.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="domainId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityDeleteDomain
        (
            accountId: string,
            domainId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("domain_id", domainId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/domains/{domain_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityDeleteDomain.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityDeleteDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves detailed information for a specific protected email domain including its delivery configuration, SPF/DMARC status, and authorization state.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="domainId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityGetDomain
        (
            accountId: string,
            domainId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("domain_id", domainId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/domains/{domain_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetDomain.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates configuration for a protected email domain. Only provided fields will be modified. Changes affect delivery mode, security settings, and regional processing.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="domainId"></param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityUpdateDomain
        (
            accountId: string,
            domainId: System.Guid,
            body: ``email-securityUpdateDomain``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("domain_id", domainId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/domains/{domain_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityUpdateDomain.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityUpdateDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a paginated list of protected identities in the impersonation registry. These entries define identities and email addresses to protect from impersonation attacks. Can be manually added or automatically synced from directory integrations.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="page">Current page within paginated list of results.</param>
    ///<param name="perPage">The number of results per page. Maximum value is 1000.</param>
    ///<param name="search">Search term for filtering records. Behavior may change.</param>
    ///<param name="order">Field to sort by.</param>
    ///<param name="direction">The sorting direction.</param>
    ///<param name="provenance"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityListImpersonationRegistry
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
            ?order: string,
            ?direction: string,
            ?provenance: string,
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
                  if order.IsSome then
                      RequestPart.query ("order", order.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if provenance.IsSome then
                      RequestPart.query ("provenance", provenance.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/impersonation_registry"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityListImpersonationRegistry.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityListImpersonationRegistry.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new entry in the impersonation registry to protect against impersonation. Emails attempting to impersonate this identity will be flagged. Supports regex patterns for flexible email matching.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="body">Create an impersonation registry entry</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityCreateImpersonationRegistry
        (
            accountId: string,
            body: ``email-securityCreateImpersonationRegistry``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/impersonation_registry"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return EmailSecurityCreateImpersonationRegistry.Created(Serializer.deserialize content)
            | _ -> return EmailSecurityCreateImpersonationRegistry.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Removes an entry from the impersonation registry. After deletion, this identity will no longer be protected from impersonation.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="impersonationRegistryId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityDeleteImpersonationRegistry
        (
            accountId: string,
            impersonationRegistryId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("impersonation_registry_id", impersonationRegistryId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/impersonation_registry/{impersonation_registry_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityDeleteImpersonationRegistry.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityDeleteImpersonationRegistry.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves details for a specific impersonation registry entry including the protected identity, email pattern, and synchronization source if directory-synced.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="impersonationRegistryId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityGetImpersonationRegistry
        (
            accountId: string,
            impersonationRegistryId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("impersonation_registry_id", impersonationRegistryId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/impersonation_registry/{impersonation_registry_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetImpersonationRegistry.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetImpersonationRegistry.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an existing impersonation registry entry. Only provided fields will be modified. Directory-synced entries can't be updated.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="impersonationRegistryId"></param>
    ///<param name="body">Update an impersonation registry entry</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityUpdateImpersonationRegistry
        (
            accountId: string,
            impersonationRegistryId: System.Guid,
            body: ``email-securityUpdateImpersonationRegistry``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("impersonation_registry_id", impersonationRegistryId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/impersonation_registry/{impersonation_registry_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityUpdateImpersonationRegistry.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityUpdateImpersonationRegistry.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a paginated list of sending domain restrictions. These restrictions enforce TLS requirements for emails from specific domains. Mail without TLS from restricted domains will be dropped unless the subdomain is in the exclude list. Supports sorting and searching.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="page">Current page within paginated list of results.</param>
    ///<param name="perPage">The number of results per page. Maximum value is 1000.</param>
    ///<param name="search">Search term for filtering records. Behavior may change.</param>
    ///<param name="order">Field to sort by.</param>
    ///<param name="direction">The sorting direction.</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityListSendingDomainRestrictions
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
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
                  if search.IsSome then
                      RequestPart.query ("search", search.Value)
                  if order.IsSome then
                      RequestPart.query ("order", order.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/sending_domain_restrictions"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityListSendingDomainRestrictions.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityListSendingDomainRestrictions.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new sending domain restriction to enforce TLS requirements for a domain. Emails without TLS from this domain will be dropped unless the subdomain is in the exclude list.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="body">Create a sending domain restriction.</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityCreateSendingDomainRestriction
        (
            accountId: string,
            body: ``email-securityCreateSendingDomainRestriction``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/sending_domain_restrictions"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return EmailSecurityCreateSendingDomainRestriction.Created(Serializer.deserialize content)
            | _ -> return EmailSecurityCreateSendingDomainRestriction.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Executes multiple delete operations on sending domain restrictions atomically. All operations succeed or fail together as a transaction. Currently only supports batch deletion. Removes TLS enforcement requirements for the specified domains.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityBatchSendingDomainRestrictions
        (
            accountId: string,
            body: EmailSecurityBatchSendingDomainRestrictionsPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/sending_domain_restrictions/batch"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityBatchSendingDomainRestrictions.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityBatchSendingDomainRestrictions.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Removes a sending domain restriction. After deletion, TLS will no longer be enforced for emails from this domain.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="sendingDomainRestrictionId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityDeleteSendingDomainRestriction
        (
            accountId: string,
            sendingDomainRestrictionId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("sending_domain_restriction_id", sendingDomainRestrictionId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/sending_domain_restrictions/{sending_domain_restriction_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityDeleteSendingDomainRestriction.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityDeleteSendingDomainRestriction.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves details for a specific sending domain restriction including the domain requiring TLS and any excluded subdomains exempt from the TLS requirement.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="sendingDomainRestrictionId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityGetSendingDomainRestriction
        (
            accountId: string,
            sendingDomainRestrictionId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("sending_domain_restriction_id", sendingDomainRestrictionId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/sending_domain_restrictions/{sending_domain_restriction_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetSendingDomainRestriction.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetSendingDomainRestriction.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an existing sending domain restriction. Only provided fields will be modified. Changes affect which domains require TLS and which subdomains are excluded.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="sendingDomainRestrictionId"></param>
    ///<param name="body">Update a sending domain restriction.</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityUpdateSendingDomainRestriction
        (
            accountId: string,
            sendingDomainRestrictionId: System.Guid,
            body: ``email-securityUpdateSendingDomainRestriction``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("sending_domain_restriction_id", sendingDomainRestrictionId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/sending_domain_restrictions/{sending_domain_restriction_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityUpdateSendingDomainRestriction.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityUpdateSendingDomainRestriction.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a paginated list of trusted domain patterns. Trusted domains prevent false positives for recently registered domains and lookalike domain detections. Patterns can use regular expressions for flexible matching.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="page">Current page within paginated list of results.</param>
    ///<param name="perPage">The number of results per page. Maximum value is 1000.</param>
    ///<param name="search">Search term for filtering records. Behavior may change.</param>
    ///<param name="order">Field to sort by.</param>
    ///<param name="direction">The sorting direction.</param>
    ///<param name="isRecent">Filter to show only recently registered domains that are trusted to prevent triggering Suspicious or Malicious dispositions.</param>
    ///<param name="isSimilarity">Filter to show only proximity domains (partner or approved domains with similar spelling to connected domains) that prevent Spoof dispositions.</param>
    ///<param name="pattern"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityListTrustedDomains
        (
            accountId: string,
            ?page: int,
            ?perPage: int,
            ?search: string,
            ?order: string,
            ?direction: string,
            ?isRecent: bool,
            ?isSimilarity: bool,
            ?pattern: string,
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
                  if order.IsSome then
                      RequestPart.query ("order", order.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if isRecent.IsSome then
                      RequestPart.query ("is_recent", isRecent.Value)
                  if isSimilarity.IsSome then
                      RequestPart.query ("is_similarity", isSimilarity.Value)
                  if pattern.IsSome then
                      RequestPart.query ("pattern", pattern.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/trusted_domains"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityListTrustedDomains.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityListTrustedDomains.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new trusted domain pattern. Use for partner domains or approved senders that should bypass recent domain registration and similarity checks. Configure whether it prevents recent domain or spoof dispositions.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="body">Create a trusted domain</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityCreateTrustedDomain
        (
            accountId: string,
            body: ``email-securityCreateTrustedDomain``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/trusted_domains"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return EmailSecurityCreateTrustedDomain.Created(Serializer.deserialize content)
            | _ -> return EmailSecurityCreateTrustedDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Execute multiple operations atomically. All four operation arrays
    ///(deletes, patches, puts, posts) are required and executed in order.
    ///Send empty arrays for unused operations.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityBatchTrustedDomains
        (
            accountId: string,
            body: EmailSecurityBatchTrustedDomainsPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/trusted_domains/batch"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityBatchTrustedDomains.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityBatchTrustedDomains.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Removes a trusted domain pattern. After deletion, emails from this domain will be subject to normal recent domain and similarity checks.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="trustedDomainId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityDeleteTrustedDomain
        (
            accountId: string,
            trustedDomainId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("trusted_domain_id", trustedDomainId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/trusted_domains/{trusted_domain_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityDeleteTrustedDomain.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityDeleteTrustedDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieves details for a specific trusted domain pattern including its pattern value, whether it uses regex matching, and which detection types it affects.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="trustedDomainId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityGetTrustedDomain
        (
            accountId: string,
            trustedDomainId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("trusted_domain_id", trustedDomainId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/trusted_domains/{trusted_domain_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityGetTrustedDomain.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityGetTrustedDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an existing trusted domain pattern. Only provided fields will be modified. Changes take effect for new emails matching the pattern.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="trustedDomainId"></param>
    ///<param name="body">Update a trusted domain</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityUpdateTrustedDomain
        (
            accountId: string,
            trustedDomainId: System.Guid,
            body: ``email-securityUpdateTrustedDomain``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("trusted_domain_id", trustedDomainId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/trusted_domains/{trusted_domain_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityUpdateTrustedDomain.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityUpdateTrustedDomain.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a paginated list of URL rewrite ignore patterns for the account. URLs matching these patterns will not be rewritten.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="page">Current page within paginated list of results.</param>
    ///<param name="perPage">The number of results per page. Maximum value is 1000.</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityListUrlIgnorePatterns
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
                    "/accounts/{account_id}/email-security/settings/url_ignore_patterns"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityListUrlIgnorePatterns.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityListUrlIgnorePatterns.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Creates a new URL rewrite ignore pattern. URLs matching this pattern will not be rewritten.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="body">Create a URL ignore pattern for URLs that should not be rewritten.</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityCreateUrlIgnorePattern
        (
            accountId: string,
            body: ``email-securityCreateUrlIgnorePattern``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/url_ignore_patterns"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return EmailSecurityCreateUrlIgnorePattern.Created(Serializer.deserialize content)
            | _ -> return EmailSecurityCreateUrlIgnorePattern.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Send a Batch of URL Ignore Patterns API calls to be executed together.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityBatchUrlIgnorePatterns
        (
            accountId: string,
            body: EmailSecurityBatchUrlIgnorePatternsPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/url_ignore_patterns/batch"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityBatchUrlIgnorePatterns.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityBatchUrlIgnorePatterns.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Removes a URL rewrite ignore pattern. After deletion, URLs matching this pattern will be rewritten again.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="patternId"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityDeleteUrlIgnorePattern
        (
            accountId: string,
            patternId: System.Guid,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("pattern_id", patternId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/url_ignore_patterns/{pattern_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityDeleteUrlIgnorePattern.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityDeleteUrlIgnorePattern.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an existing URL rewrite ignore pattern. Only provided fields will be modified.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="patternId"></param>
    ///<param name="body">Update a URL rewrite ignore pattern. Only provided fields will be modified.</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecurityUpdateUrlIgnorePattern
        (
            accountId: string,
            patternId: System.Guid,
            body: ``email-securityUpdateUrlIgnorePattern``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("pattern_id", patternId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/email-security/settings/url_ignore_patterns/{pattern_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecurityUpdateUrlIgnorePattern.OK(Serializer.deserialize content)
            | _ -> return EmailSecurityUpdateUrlIgnorePattern.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns information for submissions made to reclassify emails. Shows the status, outcome, and disposition changes for reclassification requests made by users or the security team. Useful for tracking false positive/negative reports.
    ///</summary>
    ///<param name="accountId">Account identifier tag.</param>
    ///<param name="start">The beginning of the search date range. Defaults to `now - 30 days`.</param>
    ///<param name="end">The end of the search date range. Defaults to `now`.</param>
    ///<param name="type"></param>
    ///<param name="submissionId"></param>
    ///<param name="originalDisposition"></param>
    ///<param name="requestedDisposition"></param>
    ///<param name="outcomeDisposition"></param>
    ///<param name="status"></param>
    ///<param name="query"></param>
    ///<param name="page">Current page within paginated list of results.</param>
    ///<param name="perPage">The number of results per page. Maximum value is 1000.</param>
    ///<param name="cancellationToken"></param>
    member this.EmailSecuritySubmissions
        (
            accountId: string,
            ?start: System.DateTimeOffset,
            ?``end``: System.DateTimeOffset,
            ?``type``: string,
            ?submissionId: string,
            ?originalDisposition: string,
            ?requestedDisposition: string,
            ?outcomeDisposition: string,
            ?status: string,
            ?query: string,
            ?page: int,
            ?perPage: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if start.IsSome then
                      RequestPart.query ("start", start.Value)
                  if ``end``.IsSome then
                      RequestPart.query ("end", ``end``.Value)
                  if ``type``.IsSome then
                      RequestPart.query ("type", ``type``.Value)
                  if submissionId.IsSome then
                      RequestPart.query ("submission_id", submissionId.Value)
                  if originalDisposition.IsSome then
                      RequestPart.query ("original_disposition", originalDisposition.Value)
                  if requestedDisposition.IsSome then
                      RequestPart.query ("requested_disposition", requestedDisposition.Value)
                  if outcomeDisposition.IsSome then
                      RequestPart.query ("outcome_disposition", outcomeDisposition.Value)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value)
                  if query.IsSome then
                      RequestPart.query ("query", query.Value)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email-security/submissions"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSecuritySubmissions.OK(Serializer.deserialize content)
            | _ -> return EmailSecuritySubmissions.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists existing destination addresses.
    ///</summary>
    member this.EmailRoutingDestinationAddressesListDestinationAddresses
        (
            accountId: string,
            ?page: float,
            ?perPage: float,
            ?direction: string,
            ?verified: bool,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if page.IsSome then
                      RequestPart.query ("page", page.Value)
                  if perPage.IsSome then
                      RequestPart.query ("per_page", perPage.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if verified.IsSome then
                      RequestPart.query ("verified", verified.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email/routing/addresses"
                    requestParts
                    cancellationToken

            return EmailRoutingDestinationAddressesListDestinationAddresses.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a destination address to forward your emails to. Destination addresses need to be verified before they can be used.
    ///</summary>
    member this.EmailRoutingDestinationAddressesCreateADestinationAddress
        (
            accountId: string,
            body: emailcreatedestinationaddressproperties,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email/routing/addresses"
                    requestParts
                    cancellationToken

            return EmailRoutingDestinationAddressesCreateADestinationAddress.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Deletes a specific destination address.
    ///</summary>
    member this.EmailRoutingDestinationAddressesDeleteDestinationAddress
        (
            destinationAddressIdentifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("destination_address_identifier", destinationAddressIdentifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email/routing/addresses/{destination_address_identifier}"
                    requestParts
                    cancellationToken

            return EmailRoutingDestinationAddressesDeleteDestinationAddress.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets information for a specific destination email already created.
    ///</summary>
    member this.EmailRoutingDestinationAddressesGetADestinationAddress
        (
            destinationAddressIdentifier: string,
            accountId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("destination_address_identifier", destinationAddressIdentifier)
                  RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email/routing/addresses/{destination_address_identifier}"
                    requestParts
                    cancellationToken

            return EmailRoutingDestinationAddressesGetADestinationAddress.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///List account email suppressions
    ///</summary>
    member this.GetPublicListSuppressionRouting
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
                    "/accounts/{account_id}/email/routing/suppression"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetPublicListSuppressionRouting.OK(Serializer.deserialize content)
            | _ -> return GetPublicListSuppressionRouting.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create account email suppression
    ///</summary>
    member this.PostPublicNewSuppressionRouting
        (
            accountId: string,
            body: PostPublicNewSuppressionRoutingPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email/routing/suppression"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PostPublicNewSuppressionRouting.OK(Serializer.deserialize content)
            | _ -> return PostPublicNewSuppressionRouting.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete account email suppression
    ///</summary>
    member this.DeletePublicDeleteSuppressionRouting
        (
            accountId: string,
            suppressionId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("suppression_id", suppressionId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email/routing/suppression/{suppression_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeletePublicDeleteSuppressionRouting.OK(Serializer.deserialize content)
            | _ -> return DeletePublicDeleteSuppressionRouting.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Get account email suppression
    ///</summary>
    member this.GetPublicGetSuppressionRouting
        (
            accountId: string,
            suppressionId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("suppression_id", suppressionId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email/routing/suppression/{suppression_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetPublicGetSuppressionRouting.OK(Serializer.deserialize content)
            | _ -> return GetPublicGetSuppressionRouting.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Get feedback emails statistics
    ///</summary>
    member this.GetPublicFeedbackStatus
        (
            accountId: string,
            ?startAt: System.DateTimeOffset,
            ?endAt: System.DateTimeOffset,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if startAt.IsSome then
                      RequestPart.query ("start_at", startAt.Value)
                  if endAt.IsSome then
                      RequestPart.query ("end_at", endAt.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email/sending/feedback"
                    requestParts
                    cancellationToken

            return GetPublicFeedbackStatus.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the current daily sending quota for the account. Null when the quota is not yet available.
    ///</summary>
    member this.EmailSendingGetSendingLimits(accountId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email/sending/limits"
                    requestParts
                    cancellationToken

            return EmailSendingGetSendingLimits.OK(Serializer.deserialize content)
        }

    ///<summary>
    ///Send an email
    ///</summary>
    ///<param name="accountId">Identifier of the account.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSendingAccountSendBuilder
        (
            accountId: string,
            body: ``email-sendingEmailBuilder``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email/sending/send"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSendingAccountSendBuilder.OK(Serializer.deserialize content)
            | 400 -> return EmailSendingAccountSendBuilder.BadRequest(Serializer.deserialize content)
            | 403 -> return EmailSendingAccountSendBuilder.Forbidden(Serializer.deserialize content)
            | _ -> return EmailSendingAccountSendBuilder.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///Send a raw MIME email
    ///</summary>
    ///<param name="accountId">Identifier of the account.</param>
    ///<param name="body"></param>
    ///<param name="cancellationToken"></param>
    member this.EmailSendingAccountSendRawMessage
        (
            accountId: string,
            body: ``email-sendingSendRawRequest``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email/sending/send_raw"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return EmailSendingAccountSendRawMessage.OK(Serializer.deserialize content)
            | 400 -> return EmailSendingAccountSendRawMessage.BadRequest(Serializer.deserialize content)
            | 403 -> return EmailSendingAccountSendRawMessage.Forbidden(Serializer.deserialize content)
            | _ -> return EmailSendingAccountSendRawMessage.InternalServerError(Serializer.deserialize content)
        }

    ///<summary>
    ///List account email suppressions
    ///</summary>
    member this.GetPublicListSuppressionSending
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
                    "/accounts/{account_id}/email/sending/suppression"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetPublicListSuppressionSending.OK(Serializer.deserialize content)
            | _ -> return GetPublicListSuppressionSending.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create account email suppression
    ///</summary>
    member this.PostPublicNewSuppressionSending
        (
            accountId: string,
            body: PostPublicNewSuppressionSendingPayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/email/sending/suppression"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return PostPublicNewSuppressionSending.OK(Serializer.deserialize content)
            | _ -> return PostPublicNewSuppressionSending.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete account email suppression
    ///</summary>
    member this.DeletePublicDeleteSuppressionSending
        (
            accountId: string,
            suppressionId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("suppression_id", suppressionId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/accounts/{account_id}/email/sending/suppression/{suppression_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return DeletePublicDeleteSuppressionSending.OK(Serializer.deserialize content)
            | _ -> return DeletePublicDeleteSuppressionSending.NotFound(Serializer.deserialize content)
        }

    ///<summary>
    ///Get account email suppression
    ///</summary>
    member this.GetPublicGetSuppressionSending
        (
            accountId: string,
            suppressionId: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("suppression_id", suppressionId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/email/sending/suppression/{suppression_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return GetPublicGetSuppressionSending.OK(Serializer.deserialize content)
            | _ -> return GetPublicGetSuppressionSending.NotFound(Serializer.deserialize content)
        }
