module Fidelity.CloudEdge.Tests.RuntimeTypesRefreshTests

open Expecto
open System
open System.Reflection

// Tests for the workers-types refresh in 0.3.0 (4.20260417.1 → 4.20260501.1).
// Covers:
//   - Workflows V2 runtime types (Workflow<'PARAMS>, WorkflowInstance, WorkflowInstanceCreateOptions, etc.)
//   - Durable Object Facets (DurableObjectFacets, FacetStartupOptions, ServiceBinding)
//   - Container API (Container, ContainerStartupOptions, snapshot/egress types)
//
// Pattern follows NewServicesTests.fs: instantiate types where possible, check
// member presence via reflection, validate namespace conventions.

open Fidelity.CloudEdge.Worker.Context
open Fidelity.CloudEdge.DurableObjects

let private hasMember (t: Type) (name: string) =
    t.GetMembers(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)
    |> Array.exists (fun m -> m.Name = name)

let private memberNames (t: Type) =
    t.GetMembers(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)
    |> Array.map (fun m -> m.Name)

let private getRuntimeType (typeName: string) (asm: Assembly) =
    asm.GetTypes() |> Array.tryFind (fun t -> t.Name.StartsWith(typeName))

// ─── Workflows V2 Runtime Surface ─────────────────────────────────

let private workflowsV2Tests =
    testList "Workflows V2 Runtime Types" [
        testCase "Workflow generic type is present" <| fun _ ->
            // Workflow<'PARAMS> should exist as a typed binding
            let asm = typeof<Headers>.Assembly  // any type from Worker.Context
            let workflowType =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name.StartsWith("Workflow") && t.IsGenericTypeDefinition)
            Expect.isSome workflowType "Workflow<'PARAMS> generic type should be in Worker.Context"

        testCase "WorkflowInstance type is present" <| fun _ ->
            let asm = typeof<Headers>.Assembly
            let instanceType =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name = "WorkflowInstance")
            Expect.isSome instanceType "WorkflowInstance type should exist in Worker.Context"

        testCase "WorkflowInstanceCreateOptions exists" <| fun _ ->
            let asm = typeof<Headers>.Assembly
            let createOptType =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name.StartsWith("WorkflowInstanceCreateOptions"))
            Expect.isSome createOptType "WorkflowInstanceCreateOptions type should exist"

        testCase "WorkflowError exists" <| fun _ ->
            let asm = typeof<Headers>.Assembly
            let errorType =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name = "WorkflowError")
            Expect.isSome errorType "WorkflowError type should exist (V2 surface)"

        testCase "WorkflowDurationLabel exists" <| fun _ ->
            let asm = typeof<Headers>.Assembly
            let durType =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name = "WorkflowDurationLabel")
            Expect.isSome durType "WorkflowDurationLabel type should exist (V2 step.sleep typing)"
    ]

// ─── Durable Object Facets ───────────────────────────────────────

let private facetsTests =
    testList "Durable Object Facets" [
        testCase "DurableObjectFacets interface is present" <| fun _ ->
            let asm = typeof<FacetStartupOptions<obj>>.Assembly
            let facetsType =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name = "DurableObjectFacets")
            Expect.isSome facetsType "DurableObjectFacets interface should exist in DurableObjects"

        testCase "DurableObjectFacets exposes get/abort/delete" <| fun _ ->
            let asm = typeof<FacetStartupOptions<obj>>.Assembly
            let facetsType =
                asm.GetTypes()
                |> Array.find (fun t -> t.Name = "DurableObjectFacets")
            let names = memberNames facetsType
            Expect.contains names "get" "Facets should expose get for child instantiation"
            Expect.contains names "abort" "Facets should expose abort for child termination"
            Expect.contains names "delete" "Facets should expose delete for child removal"

        testCase "FacetStartupOptions is generic" <| fun _ ->
            let t = typeof<FacetStartupOptions<obj>>.GetGenericTypeDefinition()
            Expect.isTrue t.IsGenericTypeDefinition "FacetStartupOptions should be a generic type"
            let args = t.GetGenericArguments()
            Expect.equal args.Length 1 "FacetStartupOptions should have one type parameter"

        testCase "FacetStartupOptions has id property" <| fun _ ->
            let t = typeof<FacetStartupOptions<obj>>
            Expect.isTrue (hasMember t "get_id" || hasMember t "id")
                "FacetStartupOptions should have id property"

        testCase "ServiceBinding interface present" <| fun _ ->
            // Used by DurableObjectFacets.get to return a child handle
            let asm = typeof<FacetStartupOptions<obj>>.Assembly
            let sbType =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name = "ServiceBinding")
            Expect.isSome sbType
                "ServiceBinding (returned from facets.get) should exist as a binding type"

        testCase "Facets namespace is DurableObjects" <| fun _ ->
            let ns = typeof<FacetStartupOptions<obj>>.Namespace
            Expect.stringStarts ns "Fidelity.CloudEdge.DurableObjects"
                "Facets types should live in the DurableObjects namespace"
    ]

// ─── Container API (egress / snapshots) ──────────────────────────

let private containerTests =
    testList "Container API (Agents Week)" [
        testCase "Container interface present in DurableObjects" <| fun _ ->
            // Container lives in the hand-curated DurableObjects/Types.fs
            // (Generated.fs in Worker.Context is reference material; not compiled)
            let asm = typeof<FacetStartupOptions<obj>>.Assembly
            let containerType =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name = "Container")
            Expect.isSome containerType
                "Container interface should exist in DurableObjects"

        testCase "ContainerStartupOptions present" <| fun _ ->
            let asm = typeof<FacetStartupOptions<obj>>.Assembly
            let optsType =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name = "ContainerStartupOptions")
            Expect.isSome optsType "ContainerStartupOptions should exist in DurableObjects"

        testCase "Container snapshot types in DurableObjects" <| fun _ ->
            // Hand-crafted in CloudEdge.DurableObjects/Types.fs per 0.2.0 work
            let asm = typeof<FacetStartupOptions<obj>>.Assembly
            let snapDir =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name = "ContainerDirectorySnapshot")
            Expect.isSome snapDir
                "ContainerDirectorySnapshot should exist (snapshotDirectory return type)"

            let snapContainer =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name = "ContainerSnapshot")
            Expect.isSome snapContainer
                "ContainerSnapshot should exist (snapshotContainer return type)"

        testCase "ContainerDirectorySnapshotOptions present" <| fun _ ->
            let asm = typeof<FacetStartupOptions<obj>>.Assembly
            let optType =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name = "ContainerDirectorySnapshotOptions")
            Expect.isSome optType
                "ContainerDirectorySnapshotOptions for snapshotDirectory should exist"
    ]

// ─── Workers-Types Pin Freshness ─────────────────────────────────

let private packageVersionTests =
    testList "Workers-Types Pin Freshness" [
        testCase "package.json pins workers-types to 4.20260501.1 or later" <| fun _ ->
            // Read the package.json from the repo root to verify the pin advanced
            let pkgPath =
                let cwd = System.IO.Directory.GetCurrentDirectory()
                let mutable dir = System.IO.DirectoryInfo(cwd)
                let mutable found = ""
                while not (isNull dir) && found = "" do
                    let candidate = System.IO.Path.Combine(dir.FullName, "package.json")
                    if System.IO.File.Exists(candidate) && (System.IO.File.ReadAllText(candidate)).Contains("fidelity-cloudedge") then
                        found <- candidate
                    dir <- dir.Parent
                found

            if pkgPath = "" then
                skiptest "package.json not found from test working directory; skipping freshness check"
            else
                let content = System.IO.File.ReadAllText(pkgPath)
                let lines = content.Split('\n')
                let pinLine =
                    lines |> Array.tryFind (fun l -> l.Contains("\"@cloudflare/workers-types\""))
                Expect.isSome pinLine "package.json should pin @cloudflare/workers-types"
                let pinValue = pinLine.Value
                // Match versions 4.20260501.1 or later
                Expect.isTrue
                    (pinValue.Contains("4.20260501") || pinValue.Contains("4.2026050") ||
                     pinValue.Contains("4.20260601") || pinValue.Contains("4.20260701") ||
                     pinValue.Contains("4.20260801"))
                    (sprintf "workers-types pin should be 4.20260501.1 or later, found: %s" pinValue)
    ]

// ─── G2: Workflows V2 Management Surface ─────────────────────────

let private workflowsV2ManagementTests =
    testList "Workflows V2 Management Surface (0.3.0 / G2)" [
        testCase "Workflows client instantiates" <| fun _ ->
            let asm =
                System.Reflection.Assembly.Load("Fidelity.CloudEdge.Management.Workflows")
            let clientType =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name = "WorkflowsClient")
            Expect.isSome clientType "WorkflowsClient should exist after V2 refresh"

        testCase "V2 batch operations present" <| fun _ ->
            let asm =
                System.Reflection.Assembly.Load("Fidelity.CloudEdge.Management.Workflows")
            let clientType =
                asm.GetTypes()
                |> Array.find (fun t -> t.Name = "WorkflowsClient")
            let methods =
                clientType.GetMethods(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)
                |> Array.map (fun m -> m.Name)
            // V2 introduces batch creation and termination
            Expect.contains methods "WorBatchCreateWorkflowInstance"
                "Workflows V2 should expose WorBatchCreateWorkflowInstance"
            Expect.contains methods "WorBatchTerminateWorkflowInstances"
                "Workflows V2 should expose WorBatchTerminateWorkflowInstances"

        testCase "V2 instance event dispatch present" <| fun _ ->
            let asm =
                System.Reflection.Assembly.Load("Fidelity.CloudEdge.Management.Workflows")
            let clientType =
                asm.GetTypes()
                |> Array.find (fun t -> t.Name = "WorkflowsClient")
            let methods =
                clientType.GetMethods(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)
                |> Array.map (fun m -> m.Name)
            Expect.contains methods "WorSendEventWorkflowInstance"
                "Workflows V2 should expose WorSendEventWorkflowInstance for event dispatch"
            Expect.contains methods "WorChangeStatusWorkflowInstance"
                "Workflows V2 should expose WorChangeStatusWorkflowInstance"

        testCase "V2 version inspection (DAG / Graph) present" <| fun _ ->
            let asm =
                System.Reflection.Assembly.Load("Fidelity.CloudEdge.Management.Workflows")
            let clientType =
                asm.GetTypes()
                |> Array.find (fun t -> t.Name = "WorkflowsClient")
            let methods =
                clientType.GetMethods(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)
                |> Array.map (fun m -> m.Name)
            Expect.contains methods "WorListWorkflowVersions"
                "Workflows V2 should expose WorListWorkflowVersions"
            Expect.contains methods "WorDescribeWorkflowVersionsDag"
                "Workflows V2 should expose WorDescribeWorkflowVersionsDag for DAG topology inspection"
            Expect.contains methods "WorDescribeWorkflowVersionsGraph"
                "Workflows V2 should expose WorDescribeWorkflowVersionsGraph for graph rendering"

        testCase "WorkflowsClient method count reflects V2 expansion" <| fun _ ->
            let asm =
                System.Reflection.Assembly.Load("Fidelity.CloudEdge.Management.Workflows")
            let clientType =
                asm.GetTypes()
                |> Array.find (fun t -> t.Name = "WorkflowsClient")
            let asyncMethodCount =
                clientType.GetMethods(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)
                |> Array.filter (fun m ->
                    not m.IsSpecialName &&
                    m.ReturnType.IsGenericType &&
                    m.ReturnType.GetGenericTypeDefinition().FullName.Contains("FSharpAsync"))
                |> Array.length
            // V1 had ~9 methods; V2 expanded to 16 (batch ops, version DAG/Graph, event dispatch)
            Expect.isGreaterThanOrEqual asyncMethodCount 14
                "WorkflowsClient should expose at least 14 async methods after V2 refresh"
    ]

// ─── G2: System.Text.Json Migration Verification ─────────────────

let private serializationMigrationTests =
    testList "System.Text.Json Migration (0.3.0 / G2)" [
        testCase "Workflows OpenApiHttp uses System.Text.Json" <| fun _ ->
            // Verify the migrate-to-system-text-json post-processor produced the
            // expected output: System.Text.Json imports and JsonFSharpConverter
            // (no Newtonsoft.Json or Fable.Remoting.Json references).
            let pkgRoot =
                let cwd = System.IO.Directory.GetCurrentDirectory()
                let mutable dir = System.IO.DirectoryInfo(cwd)
                let mutable found = ""
                while not (isNull dir) && found = "" do
                    let candidate = System.IO.Path.Combine(dir.FullName, "package.json")
                    if System.IO.File.Exists(candidate) && (System.IO.File.ReadAllText(candidate)).Contains("fidelity-cloudedge") then
                        found <- dir.FullName
                    dir <- dir.Parent
                found

            if pkgRoot = "" then
                skiptest "Repo root not found from test working directory; skipping migration check"
            else
                let openApiHttpPath =
                    System.IO.Path.Combine(pkgRoot, "src/Management/CloudEdge.Management.Workflows/OpenApiHttp.fs")
                if not (System.IO.File.Exists openApiHttpPath) then
                    skiptest "Workflows OpenApiHttp.fs not found"
                else
                    let content = System.IO.File.ReadAllText openApiHttpPath
                    Expect.isTrue (content.Contains "System.Text.Json")
                        "Workflows OpenApiHttp.fs should use System.Text.Json"
                    Expect.isFalse (content.Contains "Fable.Remoting.Json")
                        "Workflows OpenApiHttp.fs should not import Fable.Remoting.Json"
                    Expect.isFalse (content.Contains "JsonConvert.SerializeObject")
                        "Workflows OpenApiHttp.fs should not use Newtonsoft JsonConvert"
    ]

let tests =
    testList "Runtime Types Refresh (0.3.0 / G1+G2)" [
        workflowsV2Tests
        facetsTests
        containerTests
        packageVersionTests
        workflowsV2ManagementTests
        serializationMigrationTests
    ]
