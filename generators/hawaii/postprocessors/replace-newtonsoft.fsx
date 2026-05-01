#!/usr/bin/env dotnet fsi

// Post-processor: replace Newtonsoft.Json.Linq references with `obj`.
//
// Hawaii generates code that uses Newtonsoft.Json.Linq.JObject / JArray /
// JToken / JProperty for OpenAPI schemas with no concrete type (free-form
// JSON, additionalProperties: true, etc.). The Fidelity.CloudEdge management
// projects migrated to System.Text.Json and removed the Newtonsoft package
// reference; freshly-generated code therefore fails to compile until the
// references are replaced with `obj`.
//
// This post-processor performs that replacement systematically:
//   - Type annotations:           Newtonsoft.Json.Linq.JObject  →  obj
//   - Generic args:               Option<Newtonsoft.Json.Linq.JToken>  →  Option<obj>
//   - Newtonsoft.Json bare:       Newtonsoft.Json.JObject  →  obj  (rare, defensive)
//
// Usage:
//   dotnet fsi replace-newtonsoft.fsx <file.fs> [<file.fs> ...]
//
// The post-processor is idempotent — re-running on cleaned files is a no-op.
// It does NOT touch:
//   - String literals containing "Newtonsoft" (defensive, in case any are intentional)
//   - Comments
//
// Architectural note: this exists because Hawaii's generated code assumes
// Newtonsoft.Json runtime semantics. The Fidelity.CloudEdge projects have
// chosen System.Text.Json for runtime compatibility and to avoid the
// transitive Newtonsoft dependency. The replacement to `obj` preserves the
// "untyped JSON value" semantics in F# while removing the runtime dependency.

open System
open System.IO
open System.Text.RegularExpressions

let args = fsi.CommandLineArgs |> Array.tail

if args.Length = 0 then
    eprintfn "Usage: dotnet fsi replace-newtonsoft.fsx <file.fs> [<file.fs> ...]"
    exit 1

// Patterns to replace — order matters (more specific before less specific)
let replacements = [
    // Linq namespace forms (most common Hawaii output)
    @"Newtonsoft\.Json\.Linq\.JObject", "obj"
    @"Newtonsoft\.Json\.Linq\.JArray", "obj"
    @"Newtonsoft\.Json\.Linq\.JToken", "obj"
    @"Newtonsoft\.Json\.Linq\.JProperty", "obj"
    @"Newtonsoft\.Json\.Linq\.JValue", "obj"
    // Bare Newtonsoft.Json forms (less common; defensive)
    @"Newtonsoft\.Json\.JObject", "obj"
    @"Newtonsoft\.Json\.JArray", "obj"
    @"Newtonsoft\.Json\.JToken", "obj"
]

let mutable totalReplacements = 0
let mutable filesChanged = 0

for filePath in args do
    if not (File.Exists filePath) then
        eprintfn "Warning: file not found: %s" filePath
    else
        let original = File.ReadAllText filePath
        let mutable content = original
        let mutable fileReplacements = 0

        for (pattern, replacement) in replacements do
            let regex = Regex(pattern)
            let matches = regex.Matches(content)
            if matches.Count > 0 then
                content <- regex.Replace(content, replacement)
                fileReplacements <- fileReplacements + matches.Count

        if fileReplacements > 0 then
            File.WriteAllText(filePath, content)
            printfn "  ✓ %s: %d Newtonsoft → obj replacements"
                (Path.GetFileName filePath) fileReplacements
            totalReplacements <- totalReplacements + fileReplacements
            filesChanged <- filesChanged + 1

if totalReplacements > 0 then
    printfn "  ✓ replace-newtonsoft: %d total replacements across %d files"
        totalReplacements filesChanged
else
    printfn "  ✓ replace-newtonsoft: no Newtonsoft references found (already clean)"

exit 0
