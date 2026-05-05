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

    let generatorContext: GeneratorContext =
         GeneratorContext.EmptyWithCustomisation (fun customiser ->
         {
             customiser with
                 Customisation.Interceptors.ResolvedTypePrelude = fun _ -> function
                     // TS lib.es `Error` class — substitute with F#'s `exn`
                     // (alias for System.Exception). The path-based ref to
                     // "Error" doesn't resolve in F#; `exn` does and supports
                     // `inherit exn()` for class bindings whose TS source
                     // extends Error.
                     | ResolvedType.Interface ({ IsLibEs = true } as iface) when Name.Case.valueOrSource iface.Name = "Error" ->
                         fun renderScope ->
                             let exnRef =
                                 RenderScopeStore.TypeRefAtom.Unsafe.createIntrinsic Intrinsic.exn
                                 |> RenderScopeStore.TypeRef.Unsafe.createAtom
                                 |> RenderScopeStore.TypeRefRender.Unsafe.createFromKind false
                             { renderScope with TypeRef = exnRef; Render = Render.RefOnly exnRef }
                     // TS lib.es `Array<T>` — substitute with F#'s `ResizeArray`
                     // (alias for Collections.Generic.List<T>). Bare `Array`
                     // resolves to System.Array which is non-generic (FS0033
                     // when applied with type args). Same intrinsic name as
                     // the generator uses for TS `T[]` syntax (Intrinsic.array)
                     // so both shapes converge on `ResizeArray<T>`.
                     | ResolvedType.Interface ({ IsLibEs = true } as iface) when Name.Case.valueOrSource iface.Name = "Array" ->
                         fun renderScope ->
                             let arrayRef =
                                 RenderScopeStore.TypeRefAtom.Unsafe.createIntrinsic Intrinsic.array
                                 |> RenderScopeStore.TypeRef.Unsafe.createAtom
                                 |> RenderScopeStore.TypeRefRender.Unsafe.createFromKind false
                             { renderScope with TypeRef = arrayRef; Render = Render.RefOnly arrayRef }
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
