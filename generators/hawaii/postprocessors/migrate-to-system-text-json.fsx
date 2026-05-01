#!/usr/bin/env dotnet fsi

// Post-processor: migrate OpenApiHttp.fs from Newtonsoft.Json + Fable.Remoting.Json
// to System.Text.Json + FSharp.SystemTextJson.
//
// Hawaii's default code generation uses Newtonsoft.Json and Fable.Remoting.Json
// for serialization. The Fidelity.CloudEdge management projects standardized
// on System.Text.Json with FSharp.SystemTextJson for runtime-time efficiency,
// to drop the transitive Newtonsoft dependency, and for AOT-friendliness.
//
// The migration was originally applied as a manual patch in 0.2.0 (per
// 06_tool_status.md). This post-processor applies it programmatically on
// every regen so the System.Text.Json version is preserved.
//
// Transformation:
//   - Replace `open Fable.Remoting.Json` with System.Text.Json imports
//   - Replace the Serializer module (Newtonsoft-based) with the
//     System.Text.Json + JsonFSharpConverter equivalent
//
// Usage:
//   dotnet fsi migrate-to-system-text-json.fsx <OpenApiHttp.fs>
//
// Idempotent — safe to re-run on already-migrated files.

open System
open System.IO
open System.Text.RegularExpressions

let args = fsi.CommandLineArgs |> Array.tail

if args.Length = 0 then
    eprintfn "Usage: dotnet fsi migrate-to-system-text-json.fsx <OpenApiHttp.fs>"
    exit 1

let filePath = args.[0]

if not (File.Exists filePath) then
    eprintfn "Error: file not found: %s" filePath
    exit 1

let content = File.ReadAllText filePath

// Idempotency check — if the file already uses System.Text.Json, skip.
if content.Contains("System.Text.Json") && not (content.Contains("Fable.Remoting.Json")) then
    printfn "  ✓ %s: already on System.Text.Json (no-op)" (Path.GetFileName filePath)
    exit 0

let mutable updated = content
let mutable changed = false

// Replace the Fable.Remoting import with System.Text.Json imports.
let importPattern = @"open Fable\.Remoting\.Json"
let importReplacement = "open System.Text.Json\nopen System.Text.Json.Serialization"
if Regex.IsMatch(updated, importPattern) then
    updated <- Regex.Replace(updated, importPattern, importReplacement)
    changed <- true

// Replace the Serializer module body. The Newtonsoft version uses
// JsonConvert.SerializeObject / DeserializeObject with Fable's converter;
// the System.Text.Json version uses JsonSerializer with JsonFSharpConverter.
//
// Match the entire `module Serializer = ... let deserialize<'t> ...` block.
// The pattern is intentionally generous so it catches both fresh-generated
// and lightly-modified versions.
let serializerPattern =
    @"module Serializer =\s*\n" +
    @"\s*open Newtonsoft\.Json\s*\n" +
    @"\s*let converter = FableJsonConverter\(\) :> JsonConverter\s*\n" +
    @"\s*let settings = JsonSerializerSettings\(Converters=\[\| converter \|\]\)\s*\n" +
    @"\s*settings\.DateParseHandling <- DateParseHandling\.None\s*\n" +
    @"\s*settings\.NullValueHandling <- NullValueHandling\.Ignore\s*\n" +
    @"\s*let serialize<'t> \(value: 't\) = JsonConvert\.SerializeObject\(value, settings\)\s*\n" +
    @"\s*let deserialize<'t> \(content: string\) = JsonConvert\.DeserializeObject<'t>\(content, settings\)"

let serializerReplacement =
    "module Serializer =\n" +
    "    let options = System.Text.Json.JsonSerializerOptions()\n" +
    "    options.Converters.Add(JsonFSharpConverter())\n" +
    "    options.DefaultIgnoreCondition <- JsonIgnoreCondition.WhenWritingNull\n" +
    "    let serialize<'t> (value: 't) = System.Text.Json.JsonSerializer.Serialize(value, options)\n" +
    "    let deserialize<'t> (content: string) = System.Text.Json.JsonSerializer.Deserialize<'t>(content, options)"

if Regex.IsMatch(updated, serializerPattern) then
    updated <- Regex.Replace(updated, serializerPattern, serializerReplacement)
    changed <- true

if changed then
    File.WriteAllText(filePath, updated)
    printfn "  ✓ %s: migrated to System.Text.Json" (Path.GetFileName filePath)
else
    printfn "  ! %s: no Newtonsoft/Fable.Remoting patterns matched (may already be migrated, or shape unexpected)" (Path.GetFileName filePath)

exit 0
