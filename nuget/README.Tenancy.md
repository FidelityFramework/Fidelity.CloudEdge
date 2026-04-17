# Fidelity.CloudEdge.Tenancy

**F# clients for Cloudflare's cross-account Tenant and Organization APIs**

> **Cross-account administration** — Use this package to operate across multiple Cloudflare accounts from a single control plane. For managing resources within a single account, see [Fidelity.CloudEdge.Management](https://www.nuget.org/packages/Fidelity.CloudEdge.Management). For writing Cloudflare Workers in F#, see [Fidelity.CloudEdge.Runtime](https://www.nuget.org/packages/Fidelity.CloudEdge.Runtime).

## What is this?

Fidelity.CloudEdge.Tenancy provides F# client libraries for Cloudflare's APIs that operate above the account boundary — Tenants, Organizations, cross-account members, and organization-level audit logs. This package targets **Managed Service Providers (MSPs)**, enterprise platform teams, and any tooling that needs to administer multiple Cloudflare accounts from a single control plane.

If you operate a single Cloudflare account, you do not need this package — `Fidelity.CloudEdge.Management` covers everything within account boundaries.

## The Three-Tier Model

Fidelity.CloudEdge mirrors the three structural scopes in Cloudflare's API. Each tier is an independent NuGet package:

| Tier | Path scope | Audience |
|------|-----------|----------|
| **Runtime** | In-Worker (no path) | Worker developers |
| **Management** | `/accounts/{account_id}/*` | Individual developers, teams |
| **Tenancy** | `/tenants/{tenant_id}/*`, `/organizations/*` | MSPs, platform teams |

This package covers the Tenancy tier.

## Supported Services

| Service | Namespace | Description |
|---------|-----------|-------------|
| **Tenants** | `Fidelity.CloudEdge.Tenancy.Tenants` | List accounts within a tenant, tenant entitlements, tenant-level memberships (`/tenants/{tenant_id}/*`) |
| **Organizations** | `Fidelity.CloudEdge.Tenancy.Organizations` | Organization profile, organization accounts, members (including batch create), shares, organization-level audit logs (`/organizations/*`, `/user/organizations`) |

Both clients are generated from the official [Cloudflare OpenAPI specification](https://github.com/cloudflare/api-schemas) using [Hawaii](https://github.com/Zaid-Ajaj/Hawaii).

## Installation

```bash
dotnet add package Fidelity.CloudEdge.Tenancy
```

## Quick Example — MSP dialing into a customer tenant

```fsharp
open System.Net.Http
open Fidelity.CloudEdge.Tenancy.Tenants
open Fidelity.CloudEdge.Tenancy.Organizations
open Fidelity.CloudEdge.Management.D1

let httpClient = new HttpClient()
httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {mspApiToken}")

// 1. Discover the customer accounts in this tenant
let tenantsClient = TenantsClient(httpClient)
let! accounts = tenantsClient.ListTenantAccounts(tenantId)

// 2. For each customer account, use Management APIs with their account_id
for account in accounts do
    // Switch the API token to one scoped to this account (via Access API or token rotation),
    // or use a tenant-scoped token that can act on member accounts
    let d1Client = D1Client(httpClient)
    let! databases = d1Client.ListDatabases(account.Id)
    printfn $"Customer {account.Name}: {List.length databases} D1 databases"
```

## Authentication

Tenancy APIs require tokens with **tenant-level** or **organization-level** scope. These are distinct from account-scoped API tokens:

- **Tenant API token**: issued by a tenant owner, grants cross-account visibility within that tenant
- **Organization API token**: issued for an organization, grants org-level administrative capabilities
- **Service token**: machine-to-machine authentication for automated MSP tooling

Tokens are managed through the Cloudflare dashboard at the tenant or organization level. The API surface for token issuance is separate from this package — see `Fidelity.CloudEdge.Management.Access` for token lifecycle management.

## Typical Use Cases

- **MSP control planes**: centralized dashboard for a service provider managing N customer accounts
- **Enterprise platform teams**: provisioning and auditing across organizational boundaries
- **Compliance tooling**: cross-account audit log aggregation via `/organizations/{organization_id}/logs/audit`
- **Customer onboarding**: batch member provisioning via `/organizations/{organization_id}/members:batchCreate`
- **Account portfolio management**: listing, filtering, and reporting on accounts within a tenant

## Requirements

- .NET Standard 2.0 compatible runtime (.NET 6+, .NET Framework 4.6.1+)
- `System.Net.Http` for HTTP requests
- `FSharp.SystemTextJson` (included as a transitive dependency)

## Related Packages

- **[Fidelity.CloudEdge.Management](https://www.nuget.org/packages/Fidelity.CloudEdge.Management)** — account-scoped REST API clients (39+ services: D1, R2, KV, Workers, Mesh, MoQ, and more)
- **[Fidelity.CloudEdge.Runtime](https://www.nuget.org/packages/Fidelity.CloudEdge.Runtime)** — F# and Fable bindings for writing Cloudflare Workers

## Design Rationale

Why is Tenancy a separate package rather than a namespace under Management?

An individual developer shipping a Worker has no reason to install tenant management code — they operate within a single account. An MSP managing 50 customer accounts has tenant management as their primary surface. Keeping these concerns in separate NuGet packages makes the dependency graph reflect the actual usage pattern, and keeps the Management package's install footprint unchanged for the common case.

This split also prevents confusion about API semantics. "List my databases" and "list the accounts in this tenant" look superficially similar but operate at fundamentally different scopes with different authentication requirements and different consequences. Package boundaries reinforce the conceptual distinction.

## Links

- [GitHub Repository](https://github.com/FidelityFramework/Fidelity.CloudEdge)
- [Cloudflare API Documentation](https://developers.cloudflare.com/api/)
- [Cloudflare Tenant Provisioning](https://developers.cloudflare.com/tenant/)

## License

MIT OR Apache-2.0
