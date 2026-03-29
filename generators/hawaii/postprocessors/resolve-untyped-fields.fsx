#!/usr/bin/env dotnet fsi

// Post-processor: Resolve untyped (obj) fields in generated Types.fs.
//
// Hawaii falls back to JObject/JToken/JArray (now replaced with obj) when it
// cannot resolve allOf compositions, polymorphic schemas, or freeform types.
// This postprocessor reads the OpenAPI spec alongside the generated Types.fs
// and replaces obj fields with proper F# types based on the schema.
//
// Rules implemented (from docs/type-resolution-rules.md):
//   A1: Failure envelope errors/messages → list<Errors> / list<Messages>
//   A4: BadRequest DU payloads → failure envelope type
//   B1: Timestamp fields → System.DateTimeOffset
//   B2: Identifier fields → string
//   B3: allOf-wrapped $ref (description overlay) → resolved $ref type
//   B4: Error/Message type aliases → {code: int; message: string}
//   C1: Model identifier fields → string (when schema is {"type": "string"})
//   C3: Metadata/config fields → Map<string, obj> (when additionalProperties)
//
// Usage:
//   dotnet fsi resolve-untyped-fields.fsx <Types.fs> <openapi-spec.json>

open System
open System.IO
open System.Text.Json
open System.Text.RegularExpressions

// ── Schema Reader ──────────────────────────────────────────────────
// Minimal JSON path reader for OpenAPI specs — no external dependencies.
// Reads schema definitions and resolves $ref chains.

module Schema =
    type SchemaInfo =
        | StringType
        | IntegerType
        | NumberType
        | BooleanType
        | DateTimeType
        | ArrayOfObjects
        | ArrayOfStrings
        | ArrayOfType of string
        | ObjectWithProperties of (string * SchemaInfo) list
        | ObjectNoProperties  // {"type": "object"} or {"type": "object", "additionalProperties": true}
        | RefTo of string
        | AllOfWrapper of SchemaInfo  // allOf with single meaningful $ref + description overlays
        | NullEnum  // {"enum": [null]}
        | UnknownSchema

    let private tryGetProp (el: JsonElement) (name: string) =
        match el.TryGetProperty(name) with
        | true, v -> Some v
        | _ -> None

    let private getStringProp (el: JsonElement) (name: string) =
        match tryGetProp el name with
        | Some v when v.ValueKind = JsonValueKind.String -> Some (v.GetString())
        | _ -> None

    /// Resolve a $ref path like "#/components/schemas/foo" to a schema element
    let resolveRef (root: JsonElement) (refPath: string) =
        let segments = refPath.TrimStart('#', '/').Split('/')
        let mutable current = root
        let mutable ok = true
        for seg in segments do
            if ok then
                match tryGetProp current seg with
                | Some v -> current <- v
                | None -> ok <- false
        if ok then Some current else None

    /// Classify a schema element into a SchemaInfo
    let rec classifySchema (root: JsonElement) (el: JsonElement) : SchemaInfo =
        // Check for $ref
        match getStringProp el "$ref" with
        | Some refPath ->
            // Extract the schema name from the ref path
            let name = refPath.Split('/') |> Array.last
            RefTo name
        | None ->

        // Check for allOf
        match tryGetProp el "allOf" with
        | Some allOf when allOf.ValueKind = JsonValueKind.Array ->
            // Find the $ref members vs description-only members
            let members = [for i in 0 .. allOf.GetArrayLength() - 1 -> allOf.[i]]
            let refs = members |> List.choose (fun m -> getStringProp m "$ref")
            let hasOnlyDescOverlays =
                members |> List.forall (fun m ->
                    (getStringProp m "$ref").IsSome ||
                    // Description-only overlay: has "description" but no "type" or "properties"
                    (getStringProp m "description").IsSome &&
                    (getStringProp m "type").IsNone &&
                    (tryGetProp m "properties").IsNone)
            match refs with
            | [singleRef] when hasOnlyDescOverlays ->
                // allOf wrapping a single $ref with description overlays → resolve the $ref
                let refName = singleRef.Split('/') |> Array.last
                match resolveRef root singleRef with
                | Some resolved -> AllOfWrapper (classifySchema root resolved)
                | None -> AllOfWrapper (RefTo refName)
            | _ ->
                // Complex allOf (multiple $refs, inline properties) — can't resolve simply
                UnknownSchema
        | _ ->

        // Check for enum: [null]
        match tryGetProp el "enum" with
        | Some enumArr when enumArr.ValueKind = JsonValueKind.Array &&
                            enumArr.GetArrayLength() > 0 &&
                            enumArr.[0].ValueKind = JsonValueKind.Null ->
            NullEnum
        | _ ->

        // Check for type
        match getStringProp el "type" with
        | Some "string" ->
            match getStringProp el "format" with
            | Some "date-time" -> DateTimeType
            | _ -> StringType
        | Some "integer" -> IntegerType
        | Some "number" -> NumberType
        | Some "boolean" -> BooleanType
        | Some "array" ->
            match tryGetProp el "items" with
            | Some items ->
                match getStringProp items "type" with
                | Some "object" -> ArrayOfObjects
                | Some "string" -> ArrayOfStrings
                | _ ->
                    match getStringProp items "$ref" with
                    | Some refPath -> ArrayOfType (refPath.Split('/') |> Array.last)
                    | None -> ArrayOfObjects
            | None -> ArrayOfObjects
        | Some "object" ->
            match tryGetProp el "properties" with
            | Some _ -> ObjectWithProperties []  // Has known properties
            | None -> ObjectNoProperties  // Freeform
        | _ -> UnknownSchema

    /// Load and parse an OpenAPI spec
    let loadSpec (path: string) =
        let json = File.ReadAllText path
        JsonDocument.Parse(json).RootElement

    /// Get the schema for a named component
    let getComponentSchema (root: JsonElement) (name: string) =
        match tryGetProp root "components" with
        | Some components ->
            match tryGetProp components "schemas" with
            | Some schemas -> tryGetProp schemas name
            | None -> None
        | None -> None

    /// Get all schema names
    let getSchemaNames (root: JsonElement) =
        match tryGetProp root "components" with
        | Some components ->
            match tryGetProp components "schemas" with
            | Some schemas when schemas.ValueKind = JsonValueKind.Object ->
                [for prop in schemas.EnumerateObject() -> prop.Name]
            | _ -> []
        | None -> []

    /// Resolve a property's schema within a named component schema
    let getPropertySchema (root: JsonElement) (schemaName: string) (propName: string) =
        match getComponentSchema root schemaName with
        | Some schema ->
            match tryGetProp schema "properties" with
            | Some props -> tryGetProp props propName
            | None -> None
        | None -> None

    /// Build operationId → response schema map from paths (for specs with inline schemas)
    let buildOperationResponseMap (root: JsonElement) : Map<string, JsonElement> =
        let mutable result = Map.empty
        match tryGetProp root "paths" with
        | Some paths when paths.ValueKind = JsonValueKind.Object ->
            for pathEntry in paths.EnumerateObject() do
                for methodEntry in pathEntry.Value.EnumerateObject() do
                    let method = methodEntry.Name
                    if method = "get" || method = "post" || method = "put" || method = "delete" || method = "patch" then
                        match getStringProp methodEntry.Value "operationId" with
                        | Some opId ->
                            // Get 200 response schema
                            match tryGetProp methodEntry.Value "responses" with
                            | Some responses ->
                                for statusEntry in responses.EnumerateObject() do
                                    if statusEntry.Name.StartsWith("2") then
                                        match tryGetProp statusEntry.Value "content" with
                                        | Some content ->
                                            for contentEntry in content.EnumerateObject() do
                                                if contentEntry.Name.Contains("json") then
                                                    match tryGetProp contentEntry.Value "schema" with
                                                    | Some schema -> result <- result |> Map.add opId schema
                                                    | None -> ()
                                        | None -> ()
                            | None -> ()
                        | None -> ()
        | _ -> ()
        result

    /// Resolve a property from an inline response schema (for specs without named schemas)
    let getPropertyFromResponseSchema (responseSchema: JsonElement) (propName: string) =
        // Response might be { properties: { result: ..., success: ... } }
        // or might be { type: "object" } (untyped)
        match tryGetProp responseSchema "properties" with
        | Some props -> tryGetProp props propName
        | None -> None

    /// Convert operationId to Hawaii PascalCase DU name
    /// "aig-config-list-evaluators" → "AigConfigListEvaluators"
    let operationIdToTypeName (opId: string) =
        opId.Split([|'-'; '_'|])
        |> Array.map (fun s ->
            if s.Length > 0 then
                (string (System.Char.ToUpper s.[0])) + s.[1..]
            else s)
        |> String.concat ""

    /// Backtick-quote a type name if it contains hyphens
    let quoteTypeName (name: string) =
        if name.Contains("-") then sprintf "``%s``" name else name

    /// Map a SchemaInfo to an F# type string
    let rec schemaToFSharpType (info: SchemaInfo) : string option =
        match info with
        | StringType -> Some "string"
        | IntegerType -> Some "int"
        | NumberType -> Some "float"
        | BooleanType -> Some "bool"
        | DateTimeType -> Some "System.DateTimeOffset"
        | ArrayOfObjects -> Some "list<obj>"
        | ArrayOfStrings -> Some "list<string>"
        | ArrayOfType name -> Some (sprintf "list<%s>" (name.Replace("_", "") |> quoteTypeName))
        | ObjectNoProperties -> Some "Map<string, obj>"
        | NullEnum -> Some "obj"  // null enum stays obj
        | AllOfWrapper inner -> schemaToFSharpType inner
        | RefTo _ -> None  // Don't resolve — Hawaii should have already handled named refs
        | ObjectWithProperties _ -> None  // Complex object — needs its own type
        | UnknownSchema -> None

// ── Types.fs Parser ────────────────────────────────────────────────
// Parses record definitions and their Create methods as paired units.

module TypesParser =
    /// A field in a record type
    type FieldInfo = {
        Name: string
        TypeStr: string
        Line: int
    }

    /// A record type with its Create method
    type RecordInfo = {
        TypeName: string
        Fields: FieldInfo list
        StartLine: int
        EndLine: int
    }

    /// Extract the F# type name corresponding to a schema name
    /// Schema: "d1_api-response-common-failure" → F# type: ``d1api-response-common-failure``
    let schemaToTypeName (schemaName: string) =
        // Hawaii strips the service prefix underscore and uses the rest
        // e.g., "d1_api-response-common-failure" → "d1api-response-common-failure"
        let cleaned = schemaName.Replace("_", "")
        // But actually Hawaii keeps hyphens, so we need backticks
        if cleaned.Contains("-") then sprintf "``%s``" cleaned
        else cleaned

    /// Check if a field type contains "obj" (needs resolution)
    let hasObjType (typeStr: string) =
        typeStr = "obj" ||
        typeStr = "Option<obj>" ||
        typeStr = "list<obj>" ||
        typeStr = "Option<list<obj>>" ||
        typeStr = "Map<string, obj>"

// ── Field Resolution Engine ────────────────────────────────────────
// Applies the type resolution rules from docs/type-resolution-rules.md.

module Resolver =
    open Schema

    /// Timestamp field name patterns
    let private timestampFields = set [
        "created_at"; "updated_at"; "last_seen_at"; "expires_at"
        "not_before"; "not_after"; "last_modified"; "modified_on"
        "created_on"; "updated_on"; "expires_on"; "activated_on"
        "revoked_at"; "last_used_at"; "deleted_at"
    ]

    /// ID field name patterns
    let private idFieldPatterns = [
        fun (s: string) -> s = "id"
        fun (s: string) -> s.EndsWith("_id")
        fun (s: string) -> s = "uuid"
        fun (s: string) -> s.EndsWith("_uuid")
    ]

    let private isIdField (name: string) =
        idFieldPatterns |> List.exists (fun p -> p name)

    /// Determine the correct F# type for a field
    let resolveFieldType
        (root: JsonElement)
        (schemaNames: string list)
        (typeName: string)
        (fieldName: string)
        (currentType: string)
        : string option =

        // ── Rule A1: Failure envelope errors/messages ──
        if typeName.Contains("failure") then
            if fieldName = "errors" then Some "list<Errors>"
            elif fieldName = "messages" then Some "list<Messages>"
            else None

        // ── Rule B1: Timestamp fields ──
        elif timestampFields.Contains fieldName then
            if currentType = "Option<obj>" then Some "Option<System.DateTimeOffset>"
            elif currentType = "obj" then Some "System.DateTimeOffset"
            else None

        // ── Rule B2: ID fields ──
        elif isIdField fieldName then
            if currentType = "Option<obj>" then Some "Option<string>"
            elif currentType = "obj" then Some "string"
            else None

        else
            // Try schema-based resolution
            let matchingSchema =
                schemaNames |> List.tryFind (fun sn ->
                    let cleaned = sn.Replace("_", "").Replace("-", "")
                    let typeCleaned = typeName.Replace("``", "").Replace("-", "")
                    cleaned = typeCleaned || sn.EndsWith(typeName.Replace("``", "")))

            /// Wrap raw type with Option<> if the original field was Option<obj>
            let wrapOpt (rawType: string) =
                if currentType.StartsWith("Option<") && not (rawType.StartsWith("Option<")) then
                    sprintf "Option<%s>" rawType
                else rawType

            /// Backtick-quote a type name if it contains hyphens
            let quoteIfNeeded (name: string) =
                if name.Contains("-") then sprintf "``%s``" name else name

            match matchingSchema with
            | Some schemaName ->
                match Schema.getPropertySchema root schemaName fieldName with
                | Some propEl ->
                    let info = classifySchema root propEl
                    match Schema.schemaToFSharpType info with
                    | Some rawType ->
                        let wrapped = wrapOpt rawType
                        if wrapped <> currentType then Some wrapped else None
                    | None ->
                        // Handle ArrayOfType with backtick quoting
                        match info with
                        | ArrayOfType name ->
                            let quoted = quoteIfNeeded name
                            let rawType = sprintf "list<%s>" quoted
                            let wrapped = wrapOpt rawType
                            if wrapped <> currentType then Some wrapped else None
                        | AllOfWrapper (RefTo name) ->
                            let quoted = quoteIfNeeded name
                            let wrapped = wrapOpt quoted
                            if wrapped <> currentType then Some wrapped else None
                        | NullEnum -> None
                        | _ -> None
                | None -> None
            | None -> None

// ── Line-Level Replacement Engine ──────────────────────────────────
// Replaces obj types in both field declarations and Create method parameters.

module Replacer =
    /// Replace a type in a field declaration line
    /// e.g., "      bookmark: Option<obj>" → "      bookmark: Option<string>"
    let replaceFieldType (line: string) (fieldName: string) (oldType: string) (newType: string) =
        line.Replace(sprintf "%s: %s" fieldName oldType, sprintf "%s: %s" fieldName newType)

    /// Replace a type in a Create method parameter line
    let replaceCreateParam (line: string) (fieldName: string) (oldType: string) (newType: string) =
        line.Replace(sprintf "%s: %s" fieldName oldType, sprintf "%s: %s" fieldName newType)

    /// Replace a type alias definition
    /// e.g., "type foo = Map<string, obj>" → "type foo = System.DateTimeOffset"
    let replaceTypeAlias (line: string) (_aliasName: string) (newType: string) =
        Regex.Replace(line, @"=\s*.*$", sprintf "= %s" newType)

// ── Rule A4: BadRequest DU Payload Resolution ──────────────────────

module BadRequestResolver =
    /// Find failure envelope type names in the file
    let findFailureTypes (lines: string[]) =
        lines
        |> Array.choose (fun line ->
            let m = Regex.Match(line, @"^type\s+(``[^`]+``|\S+)\s*=")
            if m.Success then
                let name = m.Groups.[1].Value
                if name.Contains("failure") then Some name else None
            else None)
        |> Array.toList

    /// Fix BadRequest DU cases with obj payloads
    let fixBadRequestPayloads (content: string) (failureTypes: string list) =
        match failureTypes with
        | [] -> content
        | failureType :: _ ->
            // Replace "| BadRequest of payload: obj" with the failure type
            Regex.Replace(content,
                @"\|\s+BadRequest\s+of\s+payload:\s+obj",
                sprintf "| BadRequest of payload: %s" failureType)

// ── Rule B4: Error/Message Type Alias Resolution ───────────────────

module TypeAliasResolver =
    /// Fix error/message type aliases that are Map<string, obj> or obj
    let fixErrorMessageAliases (content: string) =
        let mutable result = content
        let mutable count = 0

        // Pattern: type ErrorsFrom...BadRequest = Map<string, obj>
        result <- Regex.Replace(result,
            @"^(type\s+(?:``[^`]+``|\S*(?:Errors|errors)\S*)\s*=\s*)(?:Map<string, obj>|obj)\s*$",
            (fun m ->
                count <- count + 1
                sprintf "%s{code: int; message: string}" m.Groups.[1].Value),
            RegexOptions.Multiline)

        // Pattern: type MessagesFrom...BadRequest = Map<string, obj>
        result <- Regex.Replace(result,
            @"^(type\s+(?:``[^`]+``|\S*(?:Messages|messages)\S*)\s*=\s*)(?:Map<string, obj>|obj)\s*$",
            (fun m ->
                count <- count + 1
                sprintf "%s{code: int; message: string}" m.Groups.[1].Value),
            RegexOptions.Multiline)

        (count, result)

// ── Main ───────────────────────────────────────────────────────────

let args = fsi.CommandLineArgs |> Array.tail

if args.Length < 2 then
    eprintfn "Usage: dotnet fsi resolve-untyped-fields.fsx <Types.fs> <openapi-spec.json>"
    exit 1

let typesFile = args.[0]
let specFile = args.[1]

if not (File.Exists typesFile) then
    eprintfn "Error: Types.fs not found: %s" typesFile
    exit 1
if not (File.Exists specFile) then
    eprintfn "Error: OpenAPI spec not found: %s" specFile
    exit 1

printfn "Resolve untyped fields: %s" typesFile
printfn "  Using spec: %s" specFile

let root = Schema.loadSpec specFile
let schemaNames = Schema.getSchemaNames root

let mutable content = File.ReadAllText typesFile
let mutable totalChanges = 0

// ── Pass 1: Rule A1 — Failure envelope errors/messages ─────────
// (Already applied in current bindings, but postprocessor should be idempotent)

let failurePattern = @"(type\s+(?:``[^`]+``|\S+)\s*=\s*\{[^}]*?)(\berrors:\s+)obj(\b[^}]*?)(\bmessages:\s+)obj(\b[^}]*?\})"
content <- Regex.Replace(content, failurePattern,
    (fun m ->
        if m.Groups.[0].Value.Contains("failure") then
            totalChanges <- totalChanges + 2
            sprintf "%s%slist<Errors>%s%slist<Messages>%s"
                m.Groups.[1].Value m.Groups.[2].Value m.Groups.[3].Value
                m.Groups.[4].Value m.Groups.[5].Value
        else m.Value),
    RegexOptions.Singleline)

// Also fix Create method parameters for failure types
content <- Regex.Replace(content,
    @"(static member Create\s*\([^)]*?)(\berrors:\s+)obj(\b[^)]*?)(\bmessages:\s+)obj(\b[^)]*?\))",
    (fun m ->
        // Only fix if this is in a failure type context
        // Check if the preceding content contains "failure"
        let beforeMatch = content.[..m.Index]
        let lastType = Regex.Match(beforeMatch, @"type\s+(``[^`]+``|\S+)\s*=", RegexOptions.RightToLeft)
        if lastType.Success && lastType.Groups.[1].Value.Contains("failure") then
            totalChanges <- totalChanges + 2
            sprintf "%s%slist<Errors>%s%slist<Messages>%s"
                m.Groups.[1].Value m.Groups.[2].Value m.Groups.[3].Value
                m.Groups.[4].Value m.Groups.[5].Value
        else m.Value),
    RegexOptions.Singleline)

// ── Pass 2: Rule A4 — BadRequest DU payloads ──────────────────
let failureTypes = BadRequestResolver.findFailureTypes (content.Split('\n'))
let fixedContent = BadRequestResolver.fixBadRequestPayloads content failureTypes
if fixedContent <> content then
    let count = Regex.Matches(content, @"\|\s+BadRequest\s+of\s+payload:\s+obj").Count -
                Regex.Matches(fixedContent, @"\|\s+BadRequest\s+of\s+payload:\s+obj").Count
    totalChanges <- totalChanges + count
    printfn "  A4: Fixed %d BadRequest DU payload(s)" count
content <- fixedContent

// ── Pass 3: Rule B4 — Error/Message type aliases ──────────────
let (aliasCount, aliasFixed) = TypeAliasResolver.fixErrorMessageAliases content
if aliasCount > 0 then
    printfn "  B4: Fixed %d error/message type alias(es)" aliasCount
    totalChanges <- totalChanges + aliasCount
content <- aliasFixed

// ── Pass 4: Schema-driven field resolution ────────────────────
// Walk each line, find obj fields in record types, resolve via schema

let lines = content.Split('\n')
let mutable currentTypeName = ""
let mutable schemaChanges = 0
let resultLines = ResizeArray<string>()

for i in 0 .. lines.Length - 1 do
    let line = lines.[i]

    // Track current type name
    let typeMatch = Regex.Match(line, @"^type\s+(``[^`]+``|\S+)\s*=")
    if typeMatch.Success then
        currentTypeName <- typeMatch.Groups.[1].Value

    // Check for obj field declarations
    let fieldMatch = Regex.Match(line, @"^\s+(\w+):\s+((?:Option<)?(?:list<)?obj>?>?)")
    if fieldMatch.Success && currentTypeName <> "" then
        let fieldName = fieldMatch.Groups.[1].Value
        let currentFieldType = fieldMatch.Groups.[2].Value

        match Resolver.resolveFieldType root schemaNames currentTypeName fieldName currentFieldType with
        | Some newType when newType <> currentFieldType ->
            let newLine = Replacer.replaceFieldType line fieldName currentFieldType newType
            resultLines.Add(newLine)
            schemaChanges <- schemaChanges + 1
            printfn "  %s.%s: %s → %s" currentTypeName fieldName currentFieldType newType
        | _ ->
            resultLines.Add(line)

    // Check for Create method parameters with obj
    elif line.Contains("static member Create") || (line.TrimStart().StartsWith("(") && line.Contains(": obj")) then
        let paramMatch = Regex.Match(line, @"(\w+):\s+((?:Option<)?(?:list<)?obj>?>?)")
        if paramMatch.Success && currentTypeName <> "" then
            let fieldName = paramMatch.Groups.[1].Value
            let currentFieldType = paramMatch.Groups.[2].Value

            match Resolver.resolveFieldType root schemaNames currentTypeName fieldName currentFieldType with
            | Some newType when newType <> currentFieldType ->
                let newLine = Replacer.replaceCreateParam line fieldName currentFieldType newType
                resultLines.Add(newLine)
                schemaChanges <- schemaChanges + 1
            | _ ->
                resultLines.Add(line)
        else
            resultLines.Add(line)

    // Check for type aliases that are obj
    elif Regex.IsMatch(line, @"^type\s+\S+\s*=\s*(?:obj|Map<string, obj>)\s*$") then
        let aliasMatch = Regex.Match(line, @"^type\s+(``[^`]+``|\S+)\s*=")
        if aliasMatch.Success then
            let aliasName = aliasMatch.Groups.[1].Value
            let cleanName = aliasName.Replace("``", "")
            // Try to find a matching schema
            let matchingSchema = schemaNames |> List.tryFind (fun sn ->
                let cleaned = sn.Replace("_", "").Replace("-", "")
                cleaned = cleanName.Replace("-", "") || sn.EndsWith(cleanName))
            match matchingSchema with
            | Some schemaName ->
                match Schema.getComponentSchema root schemaName with
                | Some el ->
                    let info = Schema.classifySchema root el
                    match Schema.schemaToFSharpType info with
                    | Some newType when newType <> "obj" && newType <> "Map<string, obj>" ->
                        let newLine = Replacer.replaceTypeAlias line aliasName newType
                        resultLines.Add(newLine)
                        schemaChanges <- schemaChanges + 1
                        printfn "  type %s: → %s" aliasName newType
                    | _ -> resultLines.Add(line)
                | None -> resultLines.Add(line)
            | None -> resultLines.Add(line)
        else
            resultLines.Add(line)
    else
        resultLines.Add(line)

if schemaChanges > 0 then
    printfn "  Schema-resolved: %d field(s)" schemaChanges
    totalChanges <- totalChanges + schemaChanges
content <- String.concat "\n" resultLines

// ── Pass 4b: Path-based resolution for inline schemas ────────────
// For specs with no named schemas (AI, AIGateway, AISearch, AutoRAG,
// Workflows, etc.), resolve fields by matching type names to operationIds
// and looking up the inline response schema.

let opResponseMap = Schema.buildOperationResponseMap root
let mutable pathChanges = 0

/// Wrap a raw schema type with Option<> if the original field was Option<obj>
let wrapWithOption (currentFieldType: string) (rawType: string) =
    if currentFieldType.StartsWith("Option<") && not (rawType.StartsWith("Option<")) then
        sprintf "Option<%s>" rawType
    else rawType

/// Try to resolve a field from the response schema, returning the Option-aware type
let tryResolveFromSchema (responseSchema: JsonElement) (fieldName: string) (currentFieldType: string) =
    let propEl =
        match Schema.getPropertyFromResponseSchema responseSchema fieldName with
        | Some p -> Some p
        | None ->
            // Try inside result.properties (nested envelope)
            match Schema.getPropertyFromResponseSchema responseSchema "result" with
            | Some resultEl -> Schema.getPropertyFromResponseSchema resultEl fieldName
            | None -> None
    match propEl with
    | Some pe ->
        let info = Schema.classifySchema root pe
        match Schema.schemaToFSharpType info with
        | Some rawType ->
            let newType = wrapWithOption currentFieldType rawType
            if newType <> currentFieldType then Some newType else None
        | None -> None
    | None -> None

/// Try to match a type name to an operationId
let tryMatchOperation (typeName: string) =
    let cleanTypeName = typeName.Replace("``", "")
    opResponseMap |> Map.tryFindKey (fun opId _ ->
        let pascalOp = Schema.operationIdToTypeName opId
        cleanTypeName.StartsWith(pascalOp) ||
        cleanTypeName = pascalOp + "response" ||
        cleanTypeName = pascalOp)

if opResponseMap.Count > 0 then
    let lines2 = content.Split('\n')
    let mutable currentType2 = ""
    let resultLines2 = ResizeArray<string>()

    for i in 0 .. lines2.Length - 1 do
        let line = lines2.[i]
        let mutable handled = false

        // Track current type
        let typeMatch = Regex.Match(line, @"^type\s+(``[^`]+``|\S+)\s*=")
        if typeMatch.Success then
            currentType2 <- typeMatch.Groups.[1].Value

        // Check for obj fields in record types
        let fieldMatch = Regex.Match(line, @"^\s+(\w+):\s+((?:Option<)?(?:list<)?obj>?>?)")
        if fieldMatch.Success && currentType2 <> "" then
            let fieldName = fieldMatch.Groups.[1].Value
            let currentFieldType = fieldMatch.Groups.[2].Value

            match tryMatchOperation currentType2 with
            | Some opId ->
                let responseSchema = opResponseMap.[opId]
                match tryResolveFromSchema responseSchema fieldName currentFieldType with
                | Some newType ->
                    let newLine = Replacer.replaceFieldType line fieldName currentFieldType newType
                    resultLines2.Add(newLine)
                    pathChanges <- pathChanges + 1
                    printfn "  [path] %s.%s: %s → %s" currentType2 fieldName currentFieldType newType
                    handled <- true
                | None -> ()
            | None -> ()

        // Also handle Create method parameters
        elif not handled && (line.Contains(": obj") && (line.TrimStart().StartsWith("(") || line.Contains("static member Create"))) then
            let paramMatch = Regex.Match(line, @"(\w+):\s+((?:Option<)?(?:list<)?obj>?>?)")
            if paramMatch.Success && currentType2 <> "" then
                let fieldName = paramMatch.Groups.[1].Value
                let currentFieldType = paramMatch.Groups.[2].Value
                match tryMatchOperation currentType2 with
                | Some opId ->
                    let responseSchema = opResponseMap.[opId]
                    match tryResolveFromSchema responseSchema fieldName currentFieldType with
                    | Some newType ->
                        let newLine = Replacer.replaceCreateParam line fieldName currentFieldType newType
                        resultLines2.Add(newLine)
                        pathChanges <- pathChanges + 1
                        handled <- true
                    | None -> ()
                | None -> ()

        if not handled then
            resultLines2.Add(line)

    if pathChanges > 0 then
        printfn "  Path-resolved: %d field(s)" pathChanges
        totalChanges <- totalChanges + pathChanges
    content <- String.concat "\n" resultLines2

// ── Pass 5: Removed ──
// The global None→[] default fixer caused cross-record contamination.
// Instead, the postprocessor preserves Option wrappers (Option<obj> → Option<X>)
// which keeps Create defaults valid. Cases where Option is genuinely wrong
// (e.g., failure envelopes where errors: Option<list<obj>> should be errors: list<Errors>)
// are handled in Pass 1 (A1 rules) which also fixes the Create parameters.

// ── Write results ─────────────────────────────────────────────────

if totalChanges > 0 then
    File.WriteAllText(typesFile, content)
    printfn "Applied %d total fix(es) to %s" totalChanges typesFile
else
    printfn "  No fixes needed"
