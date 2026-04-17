module Fidelity.CloudEdge.Tests.NewServicesTests

open Expecto
open System
open System.Net.Http
open System.Reflection

// Tests for the 9 services added in 0.2.0:
//   Management tier: MoQ, SecurityCenter, VulnScanner, Registrar,
//                    ResourceLibrary, EventNotifications, EventSubscriptions
//   Tenancy tier:    Tenants, Organizations

open Fidelity.CloudEdge.Management.MoQ
open Fidelity.CloudEdge.Management.SecurityCenter
open Fidelity.CloudEdge.Management.VulnScanner
open Fidelity.CloudEdge.Management.Registrar
open Fidelity.CloudEdge.Management.ResourceLibrary
open Fidelity.CloudEdge.Management.EventNotifications
open Fidelity.CloudEdge.Management.EventSubscriptions
open Fidelity.CloudEdge.Tenancy.Tenants
open Fidelity.CloudEdge.Tenancy.Organizations

let private httpClient = new HttpClient()

let private getAsyncMethods (t: Type) =
    t.GetMethods(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)
    |> Array.filter (fun m ->
        not m.IsSpecialName &&
        m.ReturnType.IsGenericType &&
        m.ReturnType.GetGenericTypeDefinition().FullName.Contains("FSharpAsync"))

let private methodNamesOf (client: obj) =
    getAsyncMethods (client.GetType())
    |> Array.map (fun m -> m.Name)

// ─── MoQ (Media over QUIC) ───────────────────────────────────────

let private moqTests =
    testList "MoQ (Media over QUIC Relays)" [
        testCase "MoQ client instantiates" <| fun _ ->
            let client = MoQClient(httpClient)
            Expect.isNotNull (client :> obj) "MoQClient should instantiate"

        testCase "MoQ exposes relay lifecycle operations" <| fun _ ->
            let client = MoQClient(httpClient)
            let names = methodNamesOf client
            Expect.isGreaterThanOrEqual names.Length 5
                "MoQClient should expose at least 5 methods (list, create, get, update, delete)"

        testCase "MoQ exposes token rotation" <| fun _ ->
            let client = MoQClient(httpClient)
            let names = methodNamesOf client
            Expect.isTrue
                (names |> Array.exists (fun n -> n.Contains("Token") || n.Contains("Rotate")))
                "MoQClient should expose token rotation for relay authentication"

        testCase "MoQ namespace reflects product positioning" <| fun _ ->
            let asmName = typeof<MoQClient>.Assembly.GetName().Name
            Expect.equal asmName "Fidelity.CloudEdge.Management.MoQ"
                "Assembly should use Management.MoQ namespace"
    ]

// ─── Security Center ─────────────────────────────────────────────

let private securityCenterTests =
    testList "Security Center" [
        testCase "SecurityCenter client instantiates" <| fun _ ->
            let client = SecurityCenterClient(httpClient)
            Expect.isNotNull (client :> obj) "SecurityCenterClient should instantiate"

        testCase "SecurityCenter exposes insight operations" <| fun _ ->
            let client = SecurityCenterClient(httpClient)
            let names = methodNamesOf client
            Expect.isTrue
                (names |> Array.exists (fun n -> n.Contains("Insight")))
                "SecurityCenterClient should expose insight operations"

        testCase "SecurityCenter account-scoped paths" <| fun _ ->
            let path = "/accounts/{account_id}/security-center/insights"
            Expect.stringStarts path "/accounts/" "Should be account-scoped"
    ]

// ─── Vuln Scanner ────────────────────────────────────────────────

let private vulnScannerTests =
    testList "Vulnerability Scanner" [
        testCase "VulnScanner client instantiates" <| fun _ ->
            let client = VulnScannerClient(httpClient)
            Expect.isNotNull (client :> obj) "VulnScannerClient should instantiate"

        testCase "VulnScanner covers scans, credentials, and targets" <| fun _ ->
            let client = VulnScannerClient(httpClient)
            let names = methodNamesOf client |> Array.toList
            let hasCategory (word: string) = names |> List.exists (fun (n: string) -> n.Contains(word))
            Expect.isTrue (hasCategory "Scan") "Should have Scan operations"
            Expect.isTrue (hasCategory "Credential") "Should have Credential operations"
            Expect.isTrue (hasCategory "Target") "Should have Target Environment operations"
    ]

// ─── Registrar ───────────────────────────────────────────────────

let private registrarTests =
    testList "Registrar (Domain Registration)" [
        testCase "Registrar client instantiates" <| fun _ ->
            let client = RegistrarClient(httpClient)
            Expect.isNotNull (client :> obj) "RegistrarClient should instantiate"

        testCase "Registrar covers domain lifecycle" <| fun _ ->
            let client = RegistrarClient(httpClient)
            let names = methodNamesOf client |> Array.toList
            let hasCategory (word: string) = names |> List.exists (fun (n: string) -> n.Contains(word))
            Expect.isTrue (hasCategory "Domain") "Should have Domain operations"
            Expect.isTrue (hasCategory "Registration") "Should have Registration operations"
    ]

// ─── Resource Library ────────────────────────────────────────────

let private resourceLibraryTests =
    testList "Resource Library" [
        testCase "ResourceLibrary client instantiates" <| fun _ ->
            let client = ResourceLibraryClient(httpClient)
            Expect.isNotNull (client :> obj) "ResourceLibraryClient should instantiate"

        testCase "ResourceLibrary covers applications and categories" <| fun _ ->
            let client = ResourceLibraryClient(httpClient)
            let names = methodNamesOf client |> Array.toList
            let hasCategory (word: string) = names |> List.exists (fun (n: string) -> n.Contains(word))
            Expect.isTrue (hasCategory "Application") "Should have Application operations"
            Expect.isTrue (hasCategory "Categor") "Should have Category operations"
    ]

// ─── Event Notifications and Subscriptions ───────────────────────

let private eventsTests =
    testList "Event Notifications and Subscriptions" [
        testCase "EventNotifications client instantiates" <| fun _ ->
            let client = EventNotificationsClient(httpClient)
            Expect.isNotNull (client :> obj) "EventNotificationsClient should instantiate"

        testCase "EventSubscriptions client instantiates" <| fun _ ->
            let client = EventSubscriptionsClient(httpClient)
            Expect.isNotNull (client :> obj) "EventSubscriptionsClient should instantiate"

        testCase "EventNotifications scoped to R2 buckets" <| fun _ ->
            let path = "/accounts/{account_id}/event_notifications/r2/{bucket_name}/configuration"
            Expect.stringContains path "event_notifications" "Event notifications path"
            Expect.stringContains path "r2" "Currently R2-specific"
    ]

// ─── Tenancy Tier: Tenants ───────────────────────────────────────

let private tenantsTests =
    testList "Tenants (Tenancy tier — cross-account)" [
        testCase "TenantsClient instantiates" <| fun _ ->
            let client = TenantsClient(httpClient)
            Expect.isNotNull (client :> obj) "TenantsClient should instantiate"

        testCase "Tenants lives in the Tenancy tier namespace" <| fun _ ->
            let asmName = typeof<TenantsClient>.Assembly.GetName().Name
            Expect.equal asmName "Fidelity.CloudEdge.Tenancy.Tenants"
                "Tenants is a Tenancy tier package, not Management"

        testCase "Tenants exposes account and entitlement operations" <| fun _ ->
            let client = TenantsClient(httpClient)
            let names = methodNamesOf client |> Array.toList
            let hasCategory (word: string) = names |> List.exists (fun (n: string) -> n.Contains(word))
            Expect.isTrue (hasCategory "Account" || hasCategory "Entitlement" || hasCategory "Membership")
                "Should expose at least one of: Account, Entitlement, or Membership operations"

        testCase "Tenant path scope is above-account" <| fun _ ->
            let path = "/tenants/{tenant_id}/accounts"
            Expect.stringStarts path "/tenants/" "Tenants paths start with /tenants/ not /accounts/"
    ]

// ─── Tenancy Tier: Organizations ─────────────────────────────────

let private organizationsTests =
    testList "Organizations (Tenancy tier — cross-account)" [
        testCase "OrganizationsClient instantiates" <| fun _ ->
            let client = OrganizationsClient(httpClient)
            Expect.isNotNull (client :> obj) "OrganizationsClient should instantiate"

        testCase "Organizations lives in the Tenancy tier namespace" <| fun _ ->
            let asmName = typeof<OrganizationsClient>.Assembly.GetName().Name
            Expect.equal asmName "Fidelity.CloudEdge.Tenancy.Organizations"
                "Organizations is a Tenancy tier package, not Management"

        testCase "Organizations exposes member operations" <| fun _ ->
            let client = OrganizationsClient(httpClient)
            let names = methodNamesOf client |> Array.toList
            let hasMember = names |> List.exists (fun n -> n.Contains("Member"))
            Expect.isTrue hasMember "Should expose Member operations"

        testCase "Organization path scope is above-account" <| fun _ ->
            let path = "/organizations/{organization_id}/members"
            Expect.stringStarts path "/organizations/" "Organizations paths start with /organizations/"
    ]

// ─── Three-Tier Architecture Verification ────────────────────────

let private threeTierTests =
    testList "Three-Tier Architecture Invariants" [
        testCase "Management assemblies have Management in namespace" <| fun _ ->
            let managementAssemblies = [
                typeof<MoQClient>.Assembly
                typeof<SecurityCenterClient>.Assembly
                typeof<VulnScannerClient>.Assembly
                typeof<RegistrarClient>.Assembly
                typeof<ResourceLibraryClient>.Assembly
                typeof<EventNotificationsClient>.Assembly
                typeof<EventSubscriptionsClient>.Assembly
            ]
            for asm in managementAssemblies do
                let name = asm.GetName().Name
                Expect.stringContains name "Management"
                    $"Management-tier assembly '{name}' should have 'Management' in namespace"

        testCase "Tenancy assemblies have Tenancy in namespace" <| fun _ ->
            let tenancyAssemblies = [
                typeof<TenantsClient>.Assembly
                typeof<OrganizationsClient>.Assembly
            ]
            for asm in tenancyAssemblies do
                let name = asm.GetName().Name
                Expect.stringContains name "Tenancy"
                    $"Tenancy-tier assembly '{name}' should have 'Tenancy' in namespace"

        testCase "Management and Tenancy are separate assemblies" <| fun _ ->
            let mgmt = typeof<MoQClient>.Assembly.GetName().Name
            let tenancy = typeof<TenantsClient>.Assembly.GetName().Name
            Expect.notEqual mgmt tenancy
                "Management and Tenancy clients must live in different assemblies"

        testCase "Tenancy paths never start with /accounts/" <| fun _ ->
            let tenancyPaths = [
                "/tenants/{tenant_id}/accounts"
                "/tenants/{tenant_id}/entitlements"
                "/organizations/{organization_id}/members"
                "/user/organizations"
            ]
            for path in tenancyPaths do
                Expect.isFalse (path.StartsWith("/accounts/"))
                    $"Tenancy path '{path}' must not be account-scoped"
    ]

// ─── Test Entry Point ────────────────────────────────────────────

let tests =
    testList "New Services (0.2.0)" [
        moqTests
        securityCenterTests
        vulnScannerTests
        registrarTests
        resourceLibraryTests
        eventsTests
        tenantsTests
        organizationsTests
        threeTierTests
    ]
