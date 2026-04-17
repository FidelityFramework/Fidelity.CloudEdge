namespace rec Fidelity.CloudEdge.Tenancy.Organizations

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Tenancy.Organizations.Types
open Fidelity.CloudEdge.Tenancy.Organizations.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type OrganizationsClient(httpClient: HttpClient) =
    ///<summary>
    ///Retrieve a list of organizations a particular user has access to. (Currently in Closed Beta - see https://developers.cloudflare.com/fundamentals/organizations/)
    ///</summary>
    member this.OrganizationListOrganizations(?cancellationToken: CancellationToken) =
        async {
            let requestParts = []
            let! (status, content) = OpenApiHttp.getAsync httpClient "/organizations" requestParts cancellationToken

            match int status with
            | 200 -> return OrganizationListOrganizations.OK(Serializer.deserialize content)
            | _ -> return OrganizationListOrganizations.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a new organization for a user. (Currently in Closed Beta - see https://developers.cloudflare.com/fundamentals/organizations/)
    ///</summary>
    ///<param name="body">References an Organization in the Cloudflare data model.</param>
    ///<param name="cancellationToken"></param>
    member this.OrganizationsCreateUserOrganization
        (
            body: ``organizations-apiOrganization``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts = [ RequestPart.jsonContent body ]
            let! (status, content) = OpenApiHttp.postAsync httpClient "/organizations" requestParts cancellationToken

            match int status with
            | 200 -> return OrganizationsCreateUserOrganization.OK(Serializer.deserialize content)
            | _ -> return OrganizationsCreateUserOrganization.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete an organization. The organization MUST be empty before deleting.
    ///It must not contain any sub-organizations, accounts, members or users. (Currently in Closed Beta - see https://developers.cloudflare.com/fundamentals/organizations/)
    ///</summary>
    ///<param name="organizationId">The ID of the organization to delete.</param>
    ///<param name="cancellationToken"></param>
    member this.OrganizationsDelete(organizationId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("organization_id", organizationId) ]

            let! (status, content) =
                OpenApiHttp.deleteAsync httpClient "/organizations/{organization_id}" requestParts cancellationToken

            match int status with
            | 200 -> return OrganizationsDelete.OK(Serializer.deserialize content)
            | _ -> return OrganizationsDelete.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieve the details of a certain organization. (Currently in Closed Beta - see https://developers.cloudflare.com/fundamentals/organizations/)
    ///</summary>
    ///<param name="organizationId">The ID of the organization to retrieve.</param>
    ///<param name="cancellationToken"></param>
    member this.OrganizationsRetrieve(organizationId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("organization_id", organizationId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/organizations/{organization_id}" requestParts cancellationToken

            match int status with
            | 200 -> return OrganizationsRetrieve.OK(Serializer.deserialize content)
            | _ -> return OrganizationsRetrieve.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Modify organization. (Currently in Closed Beta - see https://developers.cloudflare.com/fundamentals/organizations/)
    ///</summary>
    ///<param name="organizationId">The ID of the organization to modify.</param>
    ///<param name="body">References an Organization in the Cloudflare data model.</param>
    ///<param name="cancellationToken"></param>
    member this.OrganizationsModify
        (
            organizationId: string,
            body: ``organizations-apiOrganization``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("organization_id", organizationId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync httpClient "/organizations/{organization_id}" requestParts cancellationToken

            match int status with
            | 200 -> return OrganizationsModify.OK(Serializer.deserialize content)
            | _ -> return OrganizationsModify.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieve a list of accounts that belong to a specific organization. (Currently in Closed Beta - see https://developers.cloudflare.com/fundamentals/organizations/)
    ///</summary>
    ///<param name="organizationId">The ID of the organization to retrieve a list of accounts for.</param>
    ///<param name="name">
    ///(case-insensitive) Filter the list of accounts to where the name is equal to a
    ///particular string.
    ///</param>
    ///<param name="nameStartsWith">
    ///(case-insensitive) Filter the list of accounts to where the name starts with a
    ///particular string.
    ///</param>
    ///<param name="nameEndsWith">
    ///(case-insensitive) Filter the list of accounts to where the name ends with a particular
    ///string.
    ///</param>
    ///<param name="nameContains">
    ///(case-insensitive) Filter the list of accounts to where the name contains a particular
    ///string.
    ///</param>
    ///<param name="orderBy">
    ///Field to order results by. Currently supported values: `account_name`.
    ///When not specified, results are ordered by internal account ID.
    ///</param>
    ///<param name="direction">
    ///Sort direction for the order_by field. Valid values: `asc`, `desc`.
    ///Defaults to `asc` when order_by is specified.
    ///</param>
    ///<param name="cancellationToken"></param>
    member this.OrganizationsGetAccounts
        (
            organizationId: string,
            ?name: string,
            ?nameStartsWith: string,
            ?nameEndsWith: string,
            ?nameContains: string,
            ?orderBy: string,
            ?direction: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("organization_id", organizationId)
                  if name.IsSome then
                      RequestPart.query ("name", name.Value)
                  if nameStartsWith.IsSome then
                      RequestPart.query ("name.startsWith", nameStartsWith.Value)
                  if nameEndsWith.IsSome then
                      RequestPart.query ("name.endsWith", nameEndsWith.Value)
                  if nameContains.IsSome then
                      RequestPart.query ("name.contains", nameContains.Value)
                  if orderBy.IsSome then
                      RequestPart.query ("order_by", orderBy.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/organizations/{organization_id}/accounts"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return OrganizationsGetAccounts.OK(Serializer.deserialize content)
            | _ -> return OrganizationsGetAccounts.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Gets a list of audit logs for an organization.
    ///</summary>
    ///<param name="organizationId"></param>
    ///<param name="since">Limits the returned results to logs newer than the specified date. This can be a date string 2019-04-30 (interpreted in UTC) or an absolute timestamp that conforms to RFC3339.</param>
    ///<param name="before">Limits the returned results to logs older than the specified date. This can be a date string 2019-04-30 (interpreted in UTC) or an absolute timestamp that conforms to RFC3339.</param>
    ///<param name="actionResult"></param>
    ///<param name="actionType"></param>
    ///<param name="actorContext"></param>
    ///<param name="actorEmail"></param>
    ///<param name="actorId"></param>
    ///<param name="actorIpAddress"></param>
    ///<param name="actorTokenId"></param>
    ///<param name="actorTokenName"></param>
    ///<param name="actorType"></param>
    ///<param name="id"></param>
    ///<param name="rawCfRayId"></param>
    ///<param name="rawMethod"></param>
    ///<param name="rawStatusCode"></param>
    ///<param name="rawUri"></param>
    ///<param name="resourceId"></param>
    ///<param name="resourceProduct"></param>
    ///<param name="resourceType"></param>
    ///<param name="resourceScope"></param>
    ///<param name="actionResultNot"></param>
    ///<param name="actionTypeNot"></param>
    ///<param name="actorContextNot"></param>
    ///<param name="actorEmailNot"></param>
    ///<param name="actorIdNot"></param>
    ///<param name="actorIpAddressNot"></param>
    ///<param name="actorTokenIdNot"></param>
    ///<param name="actorTokenNameNot"></param>
    ///<param name="actorTypeNot"></param>
    ///<param name="idNot"></param>
    ///<param name="rawCfRayIdNot"></param>
    ///<param name="rawMethodNot"></param>
    ///<param name="rawStatusCodeNot"></param>
    ///<param name="rawUriNot"></param>
    ///<param name="resourceIdNot"></param>
    ///<param name="resourceProductNot"></param>
    ///<param name="resourceTypeNot"></param>
    ///<param name="resourceScopeNot"></param>
    ///<param name="direction"></param>
    ///<param name="limit"></param>
    ///<param name="cursor"></param>
    ///<param name="cancellationToken"></param>
    member this.AuditLogsV2GetOrganizationAuditLogs
        (
            organizationId: string,
            since: string,
            before: string,
            ?actionResult: list<string>,
            ?actionType: list<string>,
            ?actorContext: list<string>,
            ?actorEmail: list<string>,
            ?actorId: list<string>,
            ?actorIpAddress: list<string>,
            ?actorTokenId: list<string>,
            ?actorTokenName: list<string>,
            ?actorType: list<string>,
            ?id: list<string>,
            ?rawCfRayId: list<string>,
            ?rawMethod: list<string>,
            ?rawStatusCode: list<int>,
            ?rawUri: list<string>,
            ?resourceId: list<string>,
            ?resourceProduct: list<string>,
            ?resourceType: list<string>,
            ?resourceScope: list<string>,
            ?actionResultNot: list<string>,
            ?actionTypeNot: list<string>,
            ?actorContextNot: list<string>,
            ?actorEmailNot: list<string>,
            ?actorIdNot: list<string>,
            ?actorIpAddressNot: list<string>,
            ?actorTokenIdNot: list<string>,
            ?actorTokenNameNot: list<string>,
            ?actorTypeNot: list<string>,
            ?idNot: list<string>,
            ?rawCfRayIdNot: list<string>,
            ?rawMethodNot: list<string>,
            ?rawStatusCodeNot: list<int>,
            ?rawUriNot: list<string>,
            ?resourceIdNot: list<string>,
            ?resourceProductNot: list<string>,
            ?resourceTypeNot: list<string>,
            ?resourceScopeNot: list<string>,
            ?direction: string,
            ?limit: float,
            ?cursor: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("organization_id", organizationId)
                  RequestPart.query ("since", since)
                  RequestPart.query ("before", before)
                  if actionResult.IsSome then
                      RequestPart.query ("action_result", actionResult.Value)
                  if actionType.IsSome then
                      RequestPart.query ("action_type", actionType.Value)
                  if actorContext.IsSome then
                      RequestPart.query ("actor_context", actorContext.Value)
                  if actorEmail.IsSome then
                      RequestPart.query ("actor_email", actorEmail.Value)
                  if actorId.IsSome then
                      RequestPart.query ("actor_id", actorId.Value)
                  if actorIpAddress.IsSome then
                      RequestPart.query ("actor_ip_address", actorIpAddress.Value)
                  if actorTokenId.IsSome then
                      RequestPart.query ("actor_token_id", actorTokenId.Value)
                  if actorTokenName.IsSome then
                      RequestPart.query ("actor_token_name", actorTokenName.Value)
                  if actorType.IsSome then
                      RequestPart.query ("actor_type", actorType.Value)
                  if id.IsSome then
                      RequestPart.query ("id", id.Value)
                  if rawCfRayId.IsSome then
                      RequestPart.query ("raw_cf_ray_id", rawCfRayId.Value)
                  if rawMethod.IsSome then
                      RequestPart.query ("raw_method", rawMethod.Value)
                  if rawStatusCode.IsSome then
                      RequestPart.query ("raw_status_code", rawStatusCode.Value)
                  if rawUri.IsSome then
                      RequestPart.query ("raw_uri", rawUri.Value)
                  if resourceId.IsSome then
                      RequestPart.query ("resource_id", resourceId.Value)
                  if resourceProduct.IsSome then
                      RequestPart.query ("resource_product", resourceProduct.Value)
                  if resourceType.IsSome then
                      RequestPart.query ("resource_type", resourceType.Value)
                  if resourceScope.IsSome then
                      RequestPart.query ("resource_scope", resourceScope.Value)
                  if actionResultNot.IsSome then
                      RequestPart.query ("action_result.not", actionResultNot.Value)
                  if actionTypeNot.IsSome then
                      RequestPart.query ("action_type.not", actionTypeNot.Value)
                  if actorContextNot.IsSome then
                      RequestPart.query ("actor_context.not", actorContextNot.Value)
                  if actorEmailNot.IsSome then
                      RequestPart.query ("actor_email.not", actorEmailNot.Value)
                  if actorIdNot.IsSome then
                      RequestPart.query ("actor_id.not", actorIdNot.Value)
                  if actorIpAddressNot.IsSome then
                      RequestPart.query ("actor_ip_address.not", actorIpAddressNot.Value)
                  if actorTokenIdNot.IsSome then
                      RequestPart.query ("actor_token_id.not", actorTokenIdNot.Value)
                  if actorTokenNameNot.IsSome then
                      RequestPart.query ("actor_token_name.not", actorTokenNameNot.Value)
                  if actorTypeNot.IsSome then
                      RequestPart.query ("actor_type.not", actorTypeNot.Value)
                  if idNot.IsSome then
                      RequestPart.query ("id.not", idNot.Value)
                  if rawCfRayIdNot.IsSome then
                      RequestPart.query ("raw_cf_ray_id.not", rawCfRayIdNot.Value)
                  if rawMethodNot.IsSome then
                      RequestPart.query ("raw_method.not", rawMethodNot.Value)
                  if rawStatusCodeNot.IsSome then
                      RequestPart.query ("raw_status_code.not", rawStatusCodeNot.Value)
                  if rawUriNot.IsSome then
                      RequestPart.query ("raw_uri.not", rawUriNot.Value)
                  if resourceIdNot.IsSome then
                      RequestPart.query ("resource_id.not", resourceIdNot.Value)
                  if resourceProductNot.IsSome then
                      RequestPart.query ("resource_product.not", resourceProductNot.Value)
                  if resourceTypeNot.IsSome then
                      RequestPart.query ("resource_type.not", resourceTypeNot.Value)
                  if resourceScopeNot.IsSome then
                      RequestPart.query ("resource_scope.not", resourceScopeNot.Value)
                  if direction.IsSome then
                      RequestPart.query ("direction", direction.Value)
                  if limit.IsSome then
                      RequestPart.query ("limit", limit.Value)
                  if cursor.IsSome then
                      RequestPart.query ("cursor", cursor.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/organizations/{organization_id}/logs/audit"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return AuditLogsV2GetOrganizationAuditLogs.OK(Serializer.deserialize content)
            | _ -> return AuditLogsV2GetOrganizationAuditLogs.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List memberships for an Organization. (Currently in Closed Beta - see https://developers.cloudflare.com/fundamentals/organizations/)
    ///</summary>
    ///<param name="organizationId"></param>
    ///<param name="status">Filter the list of memberships by membership status.</param>
    ///<param name="userEmail">Filter the list of memberships for a specific email.</param>
    ///<param name="userEmailContains">Filter the list of memberships for a specific email that contains a substring.</param>
    ///<param name="userEmailStartsWith">Filter the list of memberships for a specific email that starts with a substring.</param>
    ///<param name="userEmailEndsWith">Filter the list of memberships for a specific email that ends with a substring.</param>
    ///<param name="cancellationToken"></param>
    member this.MembersList
        (
            organizationId: string,
            ?status: list<string>,
            ?userEmail: string,
            ?userEmailContains: string,
            ?userEmailStartsWith: string,
            ?userEmailEndsWith: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("organization_id", organizationId)
                  if status.IsSome then
                      RequestPart.query ("status", status.Value)
                  if userEmail.IsSome then
                      RequestPart.query ("user.email", userEmail.Value)
                  if userEmailContains.IsSome then
                      RequestPart.query ("user.email.contains", userEmailContains.Value)
                  if userEmailStartsWith.IsSome then
                      RequestPart.query ("user.email.startsWith", userEmailStartsWith.Value)
                  if userEmailEndsWith.IsSome then
                      RequestPart.query ("user.email.endsWith", userEmailEndsWith.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/organizations/{organization_id}/members"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MembersList.OK(Serializer.deserialize content)
            | _ -> return MembersList.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Create a membership that grants access to a specific Organization. (Currently in Closed Beta - see https://developers.cloudflare.com/fundamentals/organizations/)
    ///</summary>
    member this.MembersCreate
        (
            organizationId: string,
            body: ``organizations-apiCreateMemberRequest``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("organization_id", organizationId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/organizations/{organization_id}/members"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MembersCreate.OK(Serializer.deserialize content)
            | _ -> return MembersCreate.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Delete a membership to a particular Organization. (Currently in Closed Beta - see https://developers.cloudflare.com/fundamentals/organizations/)
    ///</summary>
    member this.MembersDelete
        (
            organizationId: string,
            memberId: string,
            body: MembersDeletePayload,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("organization_id", organizationId)
                  RequestPart.path ("member_id", memberId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.deleteAsync
                    httpClient
                    "/organizations/{organization_id}/members/{member_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 204 -> return MembersDelete.NoContent(Serializer.deserialize content)
            | _ -> return MembersDelete.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Retrieve a single membership from an Organization. (Currently in Closed Beta - see https://developers.cloudflare.com/fundamentals/organizations/)
    ///</summary>
    member this.MembersRetrieve(organizationId: string, memberId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("organization_id", organizationId)
                  RequestPart.path ("member_id", memberId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/organizations/{organization_id}/members/{member_id}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MembersRetrieve.OK(Serializer.deserialize content)
            | _ -> return MembersRetrieve.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Batch create multiple memberships that grant access to a specific Organization.
    ///</summary>
    member this.MembersBatchCreate
        (
            organizationId: string,
            body: ``organizations-apiBatchCreateMembersRequest``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("organization_id", organizationId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/organizations/{organization_id}/members:batchCreate"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return MembersBatchCreate.OK(Serializer.deserialize content)
            | _ -> return MembersBatchCreate.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Get an organizations profile if it exists. (Currently in Closed Beta - see https://developers.cloudflare.com/fundamentals/organizations/)
    ///</summary>
    ///<param name="organizationId">The ID of the organization to retrieve a profile for.</param>
    ///<param name="cancellationToken"></param>
    member this.OrganizationsGetProfile(organizationId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("organization_id", organizationId) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/organizations/{organization_id}/profile"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return OrganizationsGetProfile.OK(Serializer.deserialize content)
            | _ -> return OrganizationsGetProfile.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Modify organization profile. (Currently in Closed Beta - see https://developers.cloudflare.com/fundamentals/organizations/)
    ///</summary>
    member this.OrganizationsModifyProfile
        (
            organizationId: string,
            body: ``organizations-apiProfile``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("organization_id", organizationId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.putAsync
                    httpClient
                    "/organizations/{organization_id}/profile"
                    requestParts
                    cancellationToken

            match int status with
            | 204 -> return OrganizationsModifyProfile.NoContent(Serializer.deserialize content)
            | _ -> return OrganizationsModifyProfile.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Lists all organization shares.
    ///</summary>
    member this.OrganizationSharesList(organizationId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("organization_id", organizationId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/organizations/{organization_id}/shares" requestParts cancellationToken

            match int status with
            | 200 -> return OrganizationSharesList.OK(Serializer.deserialize content)
            | 400 -> return OrganizationSharesList.BadRequest(Serializer.deserialize content)
            | _ -> return OrganizationSharesList.InternalServerError(Serializer.deserialize content)
        }
