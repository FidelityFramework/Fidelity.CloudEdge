module Fidelity.CloudEdge.Tests.AgentsBindingTests

open Expecto
open System
open System.Reflection

// Tests for the agents-sdk and @cloudflare/dynamic-workflows bindings
// added in 0.3.0:
//   G3: Fidelity.CloudEdge.Agents — Agent class, lifecycle, [<Callable>], scheduling
//   G4: Fidelity.CloudEdge.DynamicWorkflows — multi-tenant workflow dispatch
//
// Pattern follows NewServicesTests.fs: validate type/method existence via
// reflection, namespace conventions, and structural correctness.

open Fidelity.CloudEdge.Agents
open Fidelity.CloudEdge.DynamicWorkflows

let private hasMember (t: Type) (name: string) =
    t.GetMembers(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)
    |> Array.exists (fun m -> m.Name = name)

let private hasAnyMember (t: Type) (names: string list) =
    let members =
        t.GetMembers(BindingFlags.Public ||| BindingFlags.Instance ||| BindingFlags.DeclaredOnly)
        |> Array.map (fun m -> m.Name)
    names |> List.exists (fun n -> Array.contains n members)

// ─── G3: Agents Binding ──────────────────────────────────────────

let private agentsRPCTypesTests =
    testList "Agents — RPC Wire Types" [
        testCase "RPCRequest type exists" <| fun _ ->
            let asm = typeof<RPCRequest>.Assembly
            Expect.isNotNull asm "RPCRequest assembly should resolve"

        testCase "RPCResponse is a discriminated union" <| fun _ ->
            let t = typeof<RPCResponse>
            // F# DUs compile to types with `IsUnion` true
            Expect.isTrue
                (Microsoft.FSharp.Reflection.FSharpType.IsUnion(t))
                "RPCResponse should be an F# discriminated union"

        testCase "RPCResponse has Success and Error cases" <| fun _ ->
            let cases =
                Microsoft.FSharp.Reflection.FSharpType.GetUnionCases(typeof<RPCResponse>)
                |> Array.map (fun c -> c.Name)
            Expect.contains cases "Success" "RPCResponse should have Success case"
            Expect.contains cases "Error" "RPCResponse should have Error case"

        testCase "StateUpdateMessage exists" <| fun _ ->
            let asm = typeof<RPCRequest>.Assembly
            let t =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name = "StateUpdateMessage")
            Expect.isSome t "StateUpdateMessage type should exist"
    ]

let private agentsCallableTests =
    testList "Agents — [<Callable>] Attribute" [
        testCase "CallableAttribute exists" <| fun _ ->
            let t = typeof<CallableAttribute>
            Expect.isNotNull (t :> obj) "CallableAttribute type should resolve"

        testCase "CallableAttribute targets methods" <| fun _ ->
            let attrs =
                typeof<CallableAttribute>
                    .GetCustomAttributes(typeof<AttributeUsageAttribute>, false)
            Expect.isGreaterThan attrs.Length 0 "CallableAttribute should declare AttributeUsage"
            let usage = attrs.[0] :?> AttributeUsageAttribute
            Expect.isTrue
                ((usage.ValidOn &&& AttributeTargets.Method) <> AttributeTargets.Class)
                "CallableAttribute.ValidOn should include Method target"

        testCase "CallableAttribute accepts description and streaming" <| fun _ ->
            let attr = CallableAttribute(description = "test description", streaming = true)
            Expect.equal attr.Description "test description" "Description property"
            Expect.isTrue attr.Streaming "Streaming property"

        testCase "CallableMetadata interface exists" <| fun _ ->
            let asm = typeof<CallableAttribute>.Assembly
            let t = asm.GetTypes() |> Array.tryFind (fun t -> t.Name = "CallableMetadata")
            Expect.isSome t "CallableMetadata interface should exist"
    ]

let private agentsScheduleTests =
    testList "Agents — Schedule Types" [
        testCase "ScheduleKind has scheduled/delayed/cron cases" <| fun _ ->
            // ScheduleKind is a StringEnum, so cases are union cases at the F# level
            let cases =
                Microsoft.FSharp.Reflection.FSharpType.GetUnionCases(typeof<ScheduleKind>)
                |> Array.map (fun c -> c.Name)
            Expect.contains cases "Scheduled" "ScheduleKind should have Scheduled"
            Expect.contains cases "Delayed" "ScheduleKind should have Delayed"
            Expect.contains cases "Cron" "ScheduleKind should have Cron"

        testCase "Schedule generic interface exists" <| fun _ ->
            let asm = typeof<ScheduleKind>.Assembly
            let t = asm.GetTypes() |> Array.tryFind (fun t -> t.Name.StartsWith "Schedule" && t.IsGenericTypeDefinition)
            Expect.isSome t "Schedule<'T> generic interface should exist"

        testCase "ScheduleCriteria exists" <| fun _ ->
            let asm = typeof<ScheduleKind>.Assembly
            let t = asm.GetTypes() |> Array.tryFind (fun t -> t.Name = "ScheduleCriteria")
            Expect.isSome t "ScheduleCriteria interface should exist"
    ]

let private agentsBaseClassTests =
    testList "Agents — Agent Base Class" [
        testCase "Agent generic interface exists" <| fun _ ->
            let asm = typeof<CallableAttribute>.Assembly
            let t = asm.GetTypes() |> Array.tryFind (fun t -> t.Name.StartsWith "Agent`")
            Expect.isSome t "Agent<'Env, 'State> generic interface should exist"

        testCase "Agent has lifecycle and state methods" <| fun _ ->
            let asm = typeof<CallableAttribute>.Assembly
            let agentType =
                asm.GetTypes() |> Array.find (fun t -> t.Name.StartsWith "Agent`")
            // Check for the key surface methods
            Expect.isTrue (hasMember agentType "setState") "setState method"
            Expect.isTrue (hasMember agentType "onStateUpdate") "onStateUpdate hook"
            Expect.isTrue (hasMember agentType "onEmail") "onEmail hook"
            Expect.isTrue (hasMember agentType "schedule") "schedule method"
            Expect.isTrue (hasMember agentType "alarm") "alarm method"
            Expect.isTrue (hasMember agentType "destroy") "destroy method"

        testCase "Agent uses two type parameters" <| fun _ ->
            let asm = typeof<CallableAttribute>.Assembly
            let agentType =
                asm.GetTypes() |> Array.find (fun t -> t.Name.StartsWith "Agent`")
            Expect.equal (agentType.GetGenericArguments().Length) 2
                "Agent should be generic in 'Env and 'State"
    ]

let private agentsRoutingTests =
    testList "Agents — Routing Module" [
        testCase "Routing module exists with helper functions" <| fun _ ->
            let asm = typeof<CallableAttribute>.Assembly
            let routingType =
                asm.GetTypes() |> Array.tryFind (fun t -> t.Name = "Routing")
            Expect.isSome routingType "Routing module should exist"
            // Module functions appear as static methods on a generated module type
            let methods =
                routingType.Value.GetMethods(BindingFlags.Public ||| BindingFlags.Static)
                |> Array.map (fun m -> m.Name)
            Expect.contains methods "routeAgentRequest" "routeAgentRequest helper"
            Expect.contains methods "routeAgentEmail" "routeAgentEmail helper"
            Expect.contains methods "getAgentByName" "getAgentByName helper"
    ]

let private agentsNamespaceTests =
    testList "Agents — Namespace and Imports" [
        testCase "Assembly name is Fidelity.CloudEdge.Agents" <| fun _ ->
            let asm = typeof<CallableAttribute>.Assembly
            Expect.equal (asm.GetName().Name) "Fidelity.CloudEdge.Agents"
                "Assembly should be named Fidelity.CloudEdge.Agents"

        testCase "Namespace is Fidelity.CloudEdge.Agents" <| fun _ ->
            Expect.equal typeof<CallableAttribute>.Namespace "Fidelity.CloudEdge.Agents"
                "Types should live in Fidelity.CloudEdge.Agents namespace"
    ]

// ─── G4: Dynamic Workflows Binding ─────────────────────────────

let private dwfTypesTests =
    testList "DynamicWorkflows — Type Surface" [
        testCase "WorkflowEventLike generic interface exists" <| fun _ ->
            let asm = typeof<WrapWorkflowBindingOptions>.Assembly
            let t =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name.StartsWith "WorkflowEventLike")
            Expect.isSome t "WorkflowEventLike<'T> should exist"

        testCase "WorkflowRunner generic interface exists" <| fun _ ->
            let asm = typeof<WrapWorkflowBindingOptions>.Assembly
            let t =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name.StartsWith "WorkflowRunner")
            Expect.isSome t "WorkflowRunner<'T,'R> should exist"

        testCase "LoadWorkflowRunnerContext exists" <| fun _ ->
            let asm = typeof<WrapWorkflowBindingOptions>.Assembly
            let t =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name.StartsWith "LoadWorkflowRunnerContext")
            Expect.isSome t "LoadWorkflowRunnerContext<'Env> should exist"

        testCase "DynamicWorkflowBinding interface exists" <| fun _ ->
            let asm = typeof<WrapWorkflowBindingOptions>.Assembly
            let t =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name = "DynamicWorkflowBinding")
            Expect.isSome t "DynamicWorkflowBinding interface should exist"

        testCase "DynamicWorkflowBinding has create/createBatch/get" <| fun _ ->
            let asm = typeof<WrapWorkflowBindingOptions>.Assembly
            let t =
                asm.GetTypes()
                |> Array.find (fun t -> t.Name = "DynamicWorkflowBinding")
            Expect.isTrue (hasMember t "create") "create method"
            Expect.isTrue (hasMember t "createBatch") "createBatch method"
            Expect.isTrue (hasMember t "get") "get method"

        testCase "MissingDispatcherMetadataError interface exists" <| fun _ ->
            let asm = typeof<WrapWorkflowBindingOptions>.Assembly
            let t =
                asm.GetTypes()
                |> Array.tryFind (fun t -> t.Name = "MissingDispatcherMetadataError")
            Expect.isSome t "MissingDispatcherMetadataError should exist"
    ]

let private dwfApiTests =
    testList "DynamicWorkflows — Api Module" [
        testCase "Api module exposes wrapWorkflowBinding" <| fun _ ->
            let asm = typeof<WrapWorkflowBindingOptions>.Assembly
            let apiType =
                asm.GetTypes() |> Array.tryFind (fun t -> t.Name = "Api")
            Expect.isSome apiType "Api module should exist"
            let methods =
                apiType.Value.GetMethods(BindingFlags.Public ||| BindingFlags.Static)
                |> Array.map (fun m -> m.Name)
            Expect.contains methods "wrapWorkflowBinding" "wrapWorkflowBinding"
            Expect.contains methods "dispatchWorkflow" "dispatchWorkflow"
            Expect.contains methods "createDynamicWorkflowEntrypoint" "createDynamicWorkflowEntrypoint"
    ]

let private dwfNamespaceTests =
    testList "DynamicWorkflows — Namespace" [
        testCase "Assembly name is Fidelity.CloudEdge.DynamicWorkflows" <| fun _ ->
            let asm = typeof<WrapWorkflowBindingOptions>.Assembly
            Expect.equal (asm.GetName().Name) "Fidelity.CloudEdge.DynamicWorkflows"
                "Assembly should be named Fidelity.CloudEdge.DynamicWorkflows"

        testCase "Namespace is Fidelity.CloudEdge.DynamicWorkflows" <| fun _ ->
            Expect.equal typeof<WrapWorkflowBindingOptions>.Namespace
                "Fidelity.CloudEdge.DynamicWorkflows"
                "Types should live in Fidelity.CloudEdge.DynamicWorkflows namespace"
    ]

let tests =
    testList "Agents and DynamicWorkflows Bindings (0.3.0 / G3+G4)" [
        agentsRPCTypesTests
        agentsCallableTests
        agentsScheduleTests
        agentsBaseClassTests
        agentsRoutingTests
        agentsNamespaceTests
        dwfTypesTests
        dwfApiTests
        dwfNamespaceTests
    ]
