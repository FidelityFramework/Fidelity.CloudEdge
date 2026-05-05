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
                 Customisation.Interceptors.Paths.TypePaths = fun ctx typ s ->
                     match typ with
                     | Choice1Of4 { IsLibEs = true }
                     | Choice2Of4 { IsLibEs = true }
                     | Choice3Of4 { IsLibEs = true }
                     | Choice4Of4 { IsLibEs = true } ->
                         TypePath.pruneParent (_.Name >> Name.Case.valueOrModified >> (=) "Typescript") s
                     | _ -> s
                 Customisation.Interceptors.Paths.MemberPaths = fun ctx typ s ->
                     match typ with
                     | Choice1Of2 { IsLibEs = true }
                     | Choice2Of2 { IsLibEs = true } ->
                         MemberPath.pruneParent (_.Name >> Name.Case.valueOrModified >> (=) "Typescript") s
                     | _ -> s
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
