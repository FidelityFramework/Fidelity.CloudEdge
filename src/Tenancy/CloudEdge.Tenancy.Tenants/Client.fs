namespace rec Fidelity.CloudEdge.Tenancy.Tenants

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Tenancy.Tenants.Types
open Fidelity.CloudEdge.Tenancy.Tenants.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type TenantsClient(httpClient: HttpClient) =
    ///<summary>
    ///Retrieves a Tenant by Tenant ID.
    ///</summary>
    member this.TenantsRetrieveTenant(tenantId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("tenant_id", tenantId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/tenants/{tenant_id}" requestParts cancellationToken

            match int status with
            | 200 -> return TenantsRetrieveTenant.OK(Serializer.deserialize content)
            | _ -> return TenantsRetrieveTenant.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List of account types available for the Tenant to provision accounts.
    ///</summary>
    member this.TenantsValidAccountTypes(tenantId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("tenant_id", tenantId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/tenants/{tenant_id}/account_types" requestParts cancellationToken

            match int status with
            | 200 -> return TenantsValidAccountTypes.OK(Serializer.deserialize content)
            | _ -> return TenantsValidAccountTypes.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List of accounts for the Tenant.
    ///</summary>
    member this.TenantsListAccounts(tenantId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("tenant_id", tenantId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/tenants/{tenant_id}/accounts" requestParts cancellationToken

            match int status with
            | 200 -> return TenantsListAccounts.OK(Serializer.deserialize content)
            | _ -> return TenantsListAccounts.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List of innate entitlements available for the Tenant.
    ///</summary>
    member this.TenantsListEntitlements(tenantId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("tenant_id", tenantId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/tenants/{tenant_id}/entitlements" requestParts cancellationToken

            match int status with
            | 200 -> return TenantsListEntitlements.OK(Serializer.deserialize content)
            | _ -> return TenantsListEntitlements.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///List of active members (Cloudflare users) for the Tenant.
    ///</summary>
    member this.TenantsListMemberships(tenantId: string, ?cancellationToken: CancellationToken) =
        async {
            let requestParts =
                [ RequestPart.path ("tenant_id", tenantId) ]

            let! (status, content) =
                OpenApiHttp.getAsync httpClient "/tenants/{tenant_id}/memberships" requestParts cancellationToken

            match int status with
            | 200 -> return TenantsListMemberships.OK(Serializer.deserialize content)
            | _ -> return TenantsListMemberships.BadRequest(Serializer.deserialize content)
        }
