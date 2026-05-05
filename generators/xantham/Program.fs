module Xantham.Driver.Program

open System
open Xantham
open Xantham.Generator
open Xantham.Generator.Generator
open Xantham.Generator.NamePath
open Fabulous.AST
open Xantham.Decoder.ArenaInterner
open Xantham.Decoder
open Xantham.Generator.Types

[<EntryPoint>]
let main argv =
    let inputFile, outputFile =
        match argv with
        | [| input; output |] -> input, output
        | _ ->
            eprintfn "Usage: dotnet run -- <input.json> <output.fs>"
            exit 1

    if not (IO.File.Exists inputFile) then
        eprintfn "Input file not found: %s" inputFile
        exit 1

    let tree = Decoder.Runtime.create inputFile
    let interner = tree.GetArenaInterner()

    // Map from TS lib.es type name to F# equivalent. Substitutes the
    // renderScope's TypeRef with an intrinsic ref so all reference sites
    // resolve through the cache. Generic-arity is preserved at the
    // application site (TypeReference branch wraps the substituted ref
    // in a Prefix molecule with the type args).
    let libEsSubstitutions =
        Map.ofList [
            // `Error` → `exn` (F# alias for System.Exception). `inherit exn()`
            // works for TS classes that extend Error.
            "Error", Intrinsic.exn
            // `Array<T>` → `ResizeArray<T>` (F# alias for List<T>; Fable maps
            // to JS Array). Same intrinsic the generator uses for `T[]` syntax.
            "Array", Intrinsic.array
            // `PromiseLike<T>` → `Promise<T>` (Fable.Core.JS.Promise satisfies
            // PromiseLike's structural interface).
            "PromiseLike", "Promise"
            // `Disposable` → `System.IDisposable` (direct semantic equivalent).
            "Disposable", "System.IDisposable"
            // `Iterable<T>` → `seq<T>` (F# alias for IEnumerable<T>).
            "Iterable", "seq"
            // `IterableIterator<T>` and `ArrayIterator<T>` → IEnumerator<T>.
            // Both are TS lib.es iterator forms; F# IEnumerator covers the
            // iteration semantics consumers actually use.
            "IterableIterator", "System.Collections.Generic.IEnumerator"
            "ArrayIterator", "System.Collections.Generic.IEnumerator"
            "AsyncIterableIterator", "System.Collections.Generic.IAsyncEnumerator"
            // `ReadonlyArray<T>` → `IReadOnlyList<T>` (read-only list with
            // index access; matches TS ReadonlyArray semantics).
            "ReadonlyArray", "System.Collections.Generic.IReadOnlyList"
        ]

    let intrinsicRef (name: string) =
        RenderScopeStore.TypeRefAtom.Unsafe.createIntrinsic name
        |> RenderScopeStore.TypeRef.Unsafe.createAtom
        |> RenderScopeStore.TypeRefRender.Unsafe.createFromKind false

    let generatorContext: GeneratorContext =
         GeneratorContext.EmptyWithCustomisation (fun customiser ->
         {
             customiser with
                 Customisation.Interceptors.ResolvedTypePrelude = fun _ -> function
                     // TS lib.es type substitutions — see libEsSubstitutions
                     // table above for the mappings and rationale.
                     | ResolvedType.Interface ({ IsLibEs = true } as iface)
                       when libEsSubstitutions.ContainsKey(Name.Case.valueOrSource iface.Name) ->
                         let target = libEsSubstitutions.[Name.Case.valueOrSource iface.Name]
                         fun renderScope ->
                             let ref = intrinsicRef target
                             { renderScope with TypeRef = ref; Render = Render.RefOnly ref }
                     | ResolvedType.Interface { IsLibEs = true }
                     | ResolvedType.Class { IsLibEs = true }
                     | ResolvedType.Enum { IsLibEs = true } -> fun renderScope ->
                         { renderScope with Render = Render.RefOnly renderScope.TypeRef }
                     | _ -> id
                 Customisation.Interceptors.IgnorePathRender.Source = function
                     | QualifiedNamePart.Normal(text)
                     | QualifiedNamePart.Abnormal(text,_) ->
                         text.Contains("babel", StringComparison.OrdinalIgnoreCase)
                         || text.Contains("typescript", StringComparison.OrdinalIgnoreCase)
                 // Prune `Typescript` parent unconditionally — there is no
                 // `Typescript` module emitted in the output so any
                 // `Typescript.X` reference is unresolvable. The IsLibEs
                 // gate left ~200 references unpruned because not every
                 // lib.es type in a `lib.*.d.ts` file is flagged IsLibEs
                 // by the encoder.
                 Customisation.Interceptors.Paths.TypePaths = fun ctx _ s ->
                     TypePath.pruneParent (_.Name >> Name.Case.valueOrModified >> (=) "Typescript") s
                 Customisation.Interceptors.Paths.MemberPaths = fun ctx _ s ->
                     MemberPath.pruneParent (_.Name >> Name.Case.valueOrModified >> (=) "Typescript") s
         })

    ArenaInterner.prerenderTypeAliases generatorContext interner
    ArenaInterner.processExports generatorContext interner

    let renders =
        RootModule.collectModules generatorContext
        |> renderRoot generatorContext

    let output =
        Ast.Oak() {
            Ast.AnonymousModule() {
                renders
            }
        }
        |> Gen.mkOak
        |> Gen.run

    IO.File.WriteAllText(outputFile, output)
    printfn "Wrote %d bytes to %s" output.Length outputFile
    0
