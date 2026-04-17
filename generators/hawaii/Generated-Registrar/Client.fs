namespace rec Fidelity.CloudEdge.Management.Registrar

open System.Net
open System.Net.Http
open System.Text
open System.Threading
open Fidelity.CloudEdge.Management.Registrar.Types
open Fidelity.CloudEdge.Management.Registrar.Http

///Welcome to Cloudflare's API documentation site. We are experimenting with an updated version of our API documentation - check out [developers.cloudflare.com/api-next/](https://developers.cloudflare.com/api-next/) to test out the new experience.
///To get started using Cloudflare's products and services via the API, refer to [how to interact with Cloudflare](https://developers.cloudflare.com/fundamentals/basic-tasks/interact-with-cloudflare/), which covers using tools like [Terraform](https://developers.cloudflare.com/terraform/#cloudflare-terraform) and the [official SDKs](https://developers.cloudflare.com/fundamentals/api/reference/sdks/) to maintain your Cloudflare resources.
///Using the Cloudflare API requires authentication so that Cloudflare knows who is making requests and what permissions you have. Create an API token to grant access to the API to perform actions. You can also authenticate with [API keys](https://developers.cloudflare.com/fundamentals/api/get-started/keys/), but these keys have [several limitations](https://developers.cloudflare.com/fundamentals/api/get-started/keys/#limitations) that make them less secure than API tokens. Whenever possible, use API tokens to interact with the Cloudflare API.
///To create an API token, from the Cloudflare dashboard, go to My Profile &amp;gt; API Tokens and select Create Token. For more information on how to create and troubleshoot API tokens, refer to
///our [API fundamentals](https://developers.cloudflare.com/fundamentals/api/).
///For information regarding rate limits, refer to our [API Rate Limits](https://developers.cloudflare.com/cloudflare-for-platforms/workers-for-platforms/platform/limits/#api-rate-limits).
///Totally new to Cloudflare? [Start here](https://developers.cloudflare.com/fundamentals/get-started/).
type RegistrarClient(httpClient: HttpClient) =
    ///<summary>
    ///Performs real-time, authoritative availability checks directly against domain
    ///registries. Use this endpoint to verify a domain is available before attempting
    ///registration via `POST /registrations`.
    ///**Important:** Unlike the Search endpoint, these results are authoritative and
    ///reflect current registry status. Always check availability immediately before
    ///registration as domain status can change rapidly.
    ///**Note:** This endpoint uses POST to accept a list of domains in the request
    ///body. It is a read-only operation — it does not create, modify, or reserve
    ///any domains.
    ///### Extension support
    ///Only domains on extensions supported for programmatic registration by this API
    ///can be registered. If you check a domain on an unsupported extension, the response
    ///will include `registrable: false` with a `reason` field explaining why:
    ///- `extension_not_supported_via_api` — Cloudflare Registrar supports this extension
    ///  in the dashboard, but it is not yet available for programmatic registration via
    ///  this API. Register via `https://dash.cloudflare.com/{account_id}/domains/registrations` instead.
    ///- `extension_not_supported` — This extension is not supported by Cloudflare
    ///  Registrar.
    ///- `extension_disallows_registration` — The extension's registry has temporarily
    ///  or permanently frozen new registrations. No registrar can register domains on
    ///  this extension at this time.
    ///- `domain_premium` — The domain is premium priced. Premium registration is not
    ///  currently supported by this API.
    ///- `domain_unavailable` — The domain is already registered, reserved, or otherwise
    ///  not available for registration on a supported extension.
    ///The `reason` field is only present when `registrable` is `false`.
    ///### Behavior
    ///- Maximum 20 domains per request
    ///- Pricing is only returned for domains where `registrable: true`
    ///- Results are not cached; each request queries the registry
    ///### Workflow
    ///1. Call this endpoint with domains the user wants to register.
    ///2. For each domain where `registrable: true`, present pricing to the user.
    ///3. If `tier: premium`, note that premium registration is not currently
    ///   supported by this API and do not proceed to `POST /registrations`.
    ///4. Proceed to `POST /registrations` only for supported non-premium domains.
    ///</summary>
    ///<param name="accountId">Cloudflare account ID. Required for all Registrar API operations.</param>
    ///<param name="body">Request body for checking domain availability.</param>
    ///<param name="cancellationToken"></param>
    member this.RegistrarDomainDiscoveryCheck
        (
            accountId: string,
            body: ``registrar-apidomaincheckrequest``,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/registrar/domain-check"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return RegistrarDomainDiscoveryCheck.OK(Serializer.deserialize content)
            | _ -> return RegistrarDomainDiscoveryCheck.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Searches for domain name suggestions based on a keyword, phrase, or partial domain name.
    ///Returns a list of potentially available domains with pricing information.
    ///**Important:** Results are non-authoritative and based on cached data. Always use the
    ///`/domain-check` endpoint to verify real-time availability before attempting registration.
    ///Suggestions are scoped to extensions supported for programmatic registration
    ///via this API (`POST /registrations`). Domains on unsupported extensions will
    ///not appear in results, even if they are available at the registry level.
    ///### Use cases
    ///- Brand name discovery (e.g., "acme corp" → acmecorp.com, acmecorp.dev)
    ///- Keyword-based suggestions (e.g., "coffee shop" → coffeeshop.com, mycoffeeshop.net)
    ///- Alternative extension discovery (e.g., "example.com" → example.com, example.app, example.xyz)
    ///### Workflow
    ///1. Call this endpoint with a keyword or domain name.
    ///2. Present suggestions to the user.
    ///3. Call `/domain-check` with the user's chosen domains to confirm real-time availability and pricing.
    ///4. Proceed to `POST /registrations` only for supported non-premium domains
    ///   where the Check response returns `registrable: true`.
    ///**Note:** Searching with just a domain extension (e.g., "com" or ".app") is not supported. Provide a keyword or domain name.
    ///</summary>
    ///<param name="accountId">Cloudflare account ID. Required for all Registrar API operations.</param>
    ///<param name="q">
    ///The search term to find domain suggestions. Accepts keywords, phrases, or full domain names.
    ///- Phrases: "coffee shop" returns coffeeshop.com, mycoffeeshop.net, etc.
    ///- Domain names: "example.com" returns example.com and variations across extensions
    ///</param>
    ///<param name="extensions">
    ///Limits results to specific domain extensions from the supported set. If not specified,
    ///returns results across all supported extensions. Extensions not in the supported
    ///set are silently ignored.
    ///</param>
    ///<param name="limit">Maximum number of domain suggestions to return. Defaults to 20 if not specified.</param>
    ///<param name="cancellationToken"></param>
    member this.RegistrarDomainDiscoverySearch
        (
            accountId: string,
            q: string,
            ?extensions: list<string>,
            ?limit: int,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.query ("q", q)
                  if extensions.IsSome then
                      RequestPart.query ("extensions", extensions.Value)
                  if limit.IsSome then
                      RequestPart.query ("limit", limit.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/registrar/domain-search"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return RegistrarDomainDiscoverySearch.OK(Serializer.deserialize content)
            | _ -> return RegistrarDomainDiscoverySearch.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns a paginated list of domain registrations owned by the account.
    ///This endpoint uses cursor-based pagination. Results are ordered by registration
    ///date by default. To fetch the next page, pass the `cursor` value from the
    ///`result_info` object in the response as the `cursor` query parameter in
    ///your next request. An empty `cursor` string indicates there are no more
    ///pages.
    ///</summary>
    ///<param name="accountId">Cloudflare account ID.</param>
    ///<param name="sortBy">
    ///Column to sort results by. Defaults to registration date
    ///(`registry_created_at`) when omitted.
    ///</param>
    ///<param name="cancellationToken"></param>
    member this.RegistrarDomainRegistrationList
        (
            accountId: string,
            ?sortBy: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  if sortBy.IsSome then
                      RequestPart.query ("sort_by", sortBy.Value) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/registrar/registrations"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return RegistrarDomainRegistrationList.OK(Serializer.deserialize content)
            | _ -> return RegistrarDomainRegistrationList.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Starts a domain registration workflow. This is a billable operation — successful
    ///registration charges the account's default payment method. All successful
    ///domain registrations are non-refundable — once the workflow completes with
    ///`state: succeeded`, the charge cannot be reversed.
    ///### Prerequisites
    ///- The account must have a billing profile with a valid default payment method.
    ///  Set this up at `https://dash.cloudflare.com/{account_id}/billing/payment-info`.
    ///- The account must not already be at the maximum supported domain limit.
    ///  A single account may own up to 100 domains in total across registrations
    ///  created through either the dashboard or this API.
    ///- The domain must be on a supported extension for programmatic registration.
    ///- Use `POST /domain-check` immediately before calling this endpoint to confirm
    ///  real-time availability and pricing.
    ///### Supported extensions
    ///In this API, "extension" means the full registrable suffix after the domain
    ///label. For example, in `example.co.uk`, the extension is `co.uk`.
    ///Programmatic registration is currently supported for:
    ///`com`, `org`, `net`, `app`, `dev`, `cc`, `xyz`, `info`, `cloud`, `studio`,
    ///`live`, `link`, `pro`, `tech`, `fyi`, `shop`, `online`, `tools`, `run`,
    ///`games`, `build`, `systems`, `world`, `news`, `site`, `network`, `chat`,
    ///`space`, `family`, `page`, `life`, `group`, `email`, `solutions`, `day`,
    ///`blog`, `ing`, `icu`, `academy`, `today`
    ///Cloudflare Registrar supports 400+ extensions in the dashboard. Extensions
    ///not listed above can still be registered at
    ///`https://dash.cloudflare.com/{account_id}/domains/registrations`.
    ///### Express mode
    ///The only required field is `domain_name`. If `contacts` is omitted, the system
    ///uses the account's default address book entry as the registrant. If no default
    ///exists and no contact is provided, the request fails. Set up a default address
    ///book entry and accept the required agreement at
    ///`https://dash.cloudflare.com/{account_id}/domains/registrations`.
    ///### Defaults
    ///- `years`: defaults to the extension's minimum registration period (1 year for
    ///  most extensions, but varies — for example, `.ai` (if supported) requires a minimum of 2 years).
    ///- `auto_renew`: defaults to `false`. Setting it to `true` is an explicit
    ///  opt-in authorizing Cloudflare to charge the account's default payment
    ///  method up to 30 days before domain expiry to renew the registration.
    ///  Renewal pricing may change over time based on registry pricing.
    ///- `privacy_mode`: defaults to `redaction`.
    ///### Premium domains
    ///Premium domain registration is not currently supported by this API.
    ///If `POST /domain-check` returns `tier: premium`, do not call this
    ///endpoint for that domain.
    ///### Response behavior
    ///By default, the server holds the connection for a bounded, server-defined
    ///amount of time while the registration completes. Most registrations finish
    ///within this window and return `201 Created` with a completed workflow status.
    ///If the registration is still processing after this synchronous wait window,
    ///the server returns `202 Accepted`. Poll the URL in `links.self` to track progress.
    ///To skip the wait and receive an immediate `202`, send `Prefer: respond-async`.
    ///</summary>
    ///<param name="accountId">Cloudflare account ID. Required for all Registrar API operations.</param>
    ///<param name="body"></param>
    ///<param name="prefer">
    ///Set to `respond-async` to receive an immediate `202 Accepted` without
    ///waiting for the operation to complete (RFC 7240).
    ///The header may be combined with other preferences using standard
    ///comma-separated syntax.
    ///</param>
    ///<param name="cancellationToken"></param>
    member this.RegistrarDomainRegistrationCreate
        (
            accountId: string,
            body: ``registrar-apiregistrationcreaterequest``,
            ?prefer: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.jsonContent body
                  if prefer.IsSome then
                      RequestPart.header ("Prefer", prefer.Value) ]

            let! (status, content) =
                OpenApiHttp.postAsync
                    httpClient
                    "/accounts/{account_id}/registrar/registrations"
                    requestParts
                    cancellationToken

            match int status with
            | 201 -> return RegistrarDomainRegistrationCreate.Created(Serializer.deserialize content)
            | 202 -> return RegistrarDomainRegistrationCreate.Accepted(Serializer.deserialize content)
            | _ -> return RegistrarDomainRegistrationCreate.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the current state of a domain registration.
    ///This is the canonical read endpoint for a domain you own. It returns
    ///the full registration resource including current settings and expiration.
    ///When the registration resource is ready, both `created_at` and `expires_at`
    ///are present in the response.
    ///</summary>
    ///<param name="accountId">Cloudflare account ID.</param>
    ///<param name="domainName">Domain name to retrieve.</param>
    ///<param name="cancellationToken"></param>
    member this.RegistrarDomainRegistrationGet
        (
            accountId: string,
            domainName: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("domain_name", domainName) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/registrar/registrations/{domain_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return RegistrarDomainRegistrationGet.OK(Serializer.deserialize content)
            | _ -> return RegistrarDomainRegistrationGet.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Updates an existing domain registration.
    ///By default, the server holds the connection for a bounded, server-defined
    ///amount of time while the update completes. Most updates finish within this
    ///window and return `200 OK` with a completed workflow status.
    ///If the update is still processing after this synchronous wait window, the
    ///server returns `202 Accepted`. Poll the URL in `links.self` to track progress.
    ///To skip the wait and receive an immediate `202`, send `Prefer: respond-async`.
    ///This endpoint currently supports updating `auto_renew` only.
    ///</summary>
    ///<param name="accountId">Cloudflare account ID.</param>
    ///<param name="domainName">Domain name to update.</param>
    ///<param name="body">
    ///Request to update an existing domain registration.
    ///This endpoint currently supports updating `auto_renew` only.
    ///</param>
    ///<param name="prefer">
    ///Set to `respond-async` to receive an immediate `202 Accepted` without
    ///waiting for the operation to complete (RFC 7240).
    ///</param>
    ///<param name="cancellationToken"></param>
    member this.RegistrarDomainRegistrationUpdate
        (
            accountId: string,
            domainName: string,
            body: ``registrar-apiregistrationupdaterequest``,
            ?prefer: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("domain_name", domainName)
                  RequestPart.jsonContent body
                  if prefer.IsSome then
                      RequestPart.header ("Prefer", prefer.Value) ]

            let! (status, content) =
                OpenApiHttp.patchAsync
                    httpClient
                    "/accounts/{account_id}/registrar/registrations/{domain_name}"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return RegistrarDomainRegistrationUpdate.OK(Serializer.deserialize content)
            | 202 -> return RegistrarDomainRegistrationUpdate.Accepted(Serializer.deserialize content)
            | _ -> return RegistrarDomainRegistrationUpdate.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the current status of a domain registration workflow.
    ///Use this endpoint to poll for completion when the POST response
    ///returned `202 Accepted`. The URL is provided in the `links.self`
    ///field of the workflow status response.
    ///Poll this endpoint until the workflow reaches a terminal state or a
    ///state that requires user attention.
    ///**Terminal states:** `succeeded` and `failed` are terminal and always
    ///have `completed: true`.
    ///**Non-terminal states:**
    ///- `action_required` has `completed: false` and will not resolve on its
    ///  own. The workflow is paused pending user intervention.
    ///- `blocked` has `completed: false` and indicates the workflow is waiting
    ///  on a third party such as the extension registry or losing registrar.
    ///  Continue polling while informing the user of the delay.
    ///Use increasing backoff between polls. When `state: blocked`, use a
    ///longer polling interval and do not poll indefinitely.
    ///A naive polling loop that only checks `completed` can run indefinitely
    ///when `state: action_required`. Break explicitly on `action_required`:
    ///```js
    ///let status;
    ///do {
    ///  await new Promise(r =&amp;gt; setTimeout(r, 2000));
    ///  status = await cloudflare.request({
    ///    method: 'GET',
    ///    path: reg.result.links.self,
    ///  });
    ///} while (
    ///  !status.result.completed &amp;&amp;
    ///  status.result.state !== 'action_required'
    ///);
    ///if (status.result.state === 'action_required') {
    ///  // Surface context.action and context.confirmation_sent_to to the user.
    ///  // Do not re-submit the registration request.
    ///}
    ///```
    ///</summary>
    ///<param name="accountId">Cloudflare account ID. Required for all Registrar API operations.</param>
    ///<param name="domainName"></param>
    ///<param name="cancellationToken"></param>
    member this.RegistrarDomainRegistrationGetStatus
        (
            accountId: string,
            domainName: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("domain_name", domainName) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/registrar/registrations/{domain_name}/registration-status"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return RegistrarDomainRegistrationGetStatus.OK(Serializer.deserialize content)
            | _ -> return RegistrarDomainRegistrationGetStatus.BadRequest(Serializer.deserialize content)
        }

    ///<summary>
    ///Returns the current status of a domain update workflow.
    ///Use this endpoint to poll for completion when the PATCH response
    ///returned `202 Accepted`. The URL is provided in the `links.self`
    ///field of the workflow status response.
    ///Poll this endpoint until the workflow reaches a terminal state or a
    ///state that requires user attention.
    ///Use increasing backoff between polls. When the workflow remains blocked
    ///on a third party, use a longer polling interval and do not poll indefinitely.
    ///</summary>
    ///<param name="accountId">Cloudflare account ID.</param>
    ///<param name="domainName"></param>
    ///<param name="cancellationToken"></param>
    member this.RegistrarDomainRegistrationGetUpdateStatus
        (
            accountId: string,
            domainName: string,
            ?cancellationToken: CancellationToken
        ) =
        async {
            let requestParts =
                [ RequestPart.path ("account_id", accountId)
                  RequestPart.path ("domain_name", domainName) ]

            let! (status, content) =
                OpenApiHttp.getAsync
                    httpClient
                    "/accounts/{account_id}/registrar/registrations/{domain_name}/update-status"
                    requestParts
                    cancellationToken

            match int status with
            | 200 -> return RegistrarDomainRegistrationGetUpdateStatus.OK(Serializer.deserialize content)
            | _ -> return RegistrarDomainRegistrationGetUpdateStatus.BadRequest(Serializer.deserialize content)
        }
