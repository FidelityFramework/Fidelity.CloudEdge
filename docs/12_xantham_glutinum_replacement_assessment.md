# Xantham as a Glutinum Replacement for Fidelity.CloudEdge

**Assessment Date**: March 2026

> **Status update (May 2026):** This assessment is the foundational analysis behind [00 Decision 7](00_architecture_decisions.md), which formally standardizes Fidelity.CloudEdge's TypeScript→F# binding generation on Xantham. The "8-12 days of focused development" estimate in §8.3 has been substantially overtaken by upstream Xantham activity since this was written; verification runs in May 2026 confirm the generator produces 18,573 lines of F# from `@cloudflare/workers-types` (post a `collectAllRecursively` stack-overflow fix that Fidelity.CloudEdge contributed) and 507 lines from `agents-sdk` where Glutinum crashed. The current set of tracked Xantham issues lives in [06_tool_status.md §"Xantham: Capabilities, Architecture, and Tracked Issues"](06_tool_status.md); the migration sequence lives in [03_gap_analysis.md G6](03_gap_analysis.md). This document is preserved as the analytical foundation for those operational artifacts.

## 1. Executive Summary

Xantham is a hard fork of Glutinum that decomposes the TypeScript-to-F# binding pipeline into schema-driven phases: extraction (Fable), encoding/decoding (JSON boundary), and generation (.NET). This architecture directly addresses the structural limitations that force Fidelity.CloudEdge to maintain a multi-stage pre/post-processing pipeline around Glutinum's monolithic CLI.

The replacement is viable, and closer to ready than a surface-level reading of the codebase suggests. The extraction and decaoding phases are functional. The generator's type resolution layer (TypeResolver) already handles every TypeScript construct present in the Cloudflare SDK. What remains is completing the final AST emission layer (`typeBuilder`), where 7 of 12 `TypeRender` cases currently emit placeholder output. Critically, the rendering infrastructure for most of these cases already exists in their respective render modules; the gap is dispatch wiring, not algorithmic work.

Estimated effort to reach replacement readiness: **8-12 days of focused development**, concentrated in a single function (`typeBuilder`) and one supporting fixup (`TypeAliasRender`).

## 2. The Current Glutinum Pipeline Cost

Fidelity.CloudEdge processes the Cloudflare TypeScript SDK (`@cloudflare/workers-types`, ~12,662 lines, ~727 types) through a pipeline with three distinct stages of compensatory logic.

### 2.1 Pre-processing (preprocess-typescript.js, 212 lines)

This Node.js script addresses three Glutinum failure modes that occur before Glutinum even runs:

1. **Cyclic interface references** cause Glutinum to stack overflow. The preprocessor builds a full reference graph of all 600+ declared types, runs DFS cycle detection, and replaces back-references with `any /* cycle: TypeName */`. In the current workers-types, 6 cyclic interfaces are detected and 12 replacements applied.

2. **Complex intersection types** with more than 3 constituents cause Glutinum to generate malformed output. The preprocessor truncates these to 2-part intersections with a documenting comment.

3. **AI model type bloat** produces hundreds of near-identical `Ai_Cf_*` interfaces that inflate output without adding useful type coverage.

This preprocessor operates on raw TypeScript text with regex-based reference scanning, not on a parsed AST. It is effective but fragile. A change in Cloudflare's declaration formatting could silently break the cycle detection heuristics.

### 2.2 Post-processing (postprocess-runtime.sh, 69 lines)

Six categories of fixups applied to Glutinum's output:

| Fix | Root Cause |
|:----|:-----------|
| Module name placeholder replacement | Glutinum emits `REPLACE_ME_WITH_MODULE_NAME` instead of the actual namespace |
| Namespace injection | Glutinum sometimes omits namespace declarations |
| Backtick module name sanitization | Glutinum preserves npm scope syntax (`cloudflare:workers`) verbatim |
| Duplicate `open` deduplication | Redundant import statements |
| Fable.Core import injection | Missing interop imports |
| Object expression syntax fix (FS3168) | `member val` inside object expressions; invalid F# |

### 2.3 Manual Overrides and Patches

- `Types.fs` (2,044 bytes) and `Helpers.fs` (2,671 bytes) provide hand-written type definitions that complement or override Glutinum output for core APIs.
- A proposed patch (`patches/glutinum-fix-recursion.patch`, 48 lines) adds `VisitedInterfaces` tracking to Glutinum's `TransformContext`. Not upstreamed.
- Reserved keyword handling (`namespace`, `type`, `end` as property names) remains unresolved. Glutinum emits backtick-escaped identifiers where `[<CompiledName>]` attributes would be more appropriate.

### 2.4 Quantified Overhead

| Metric | Value |
|:-------|:------|
| Pre-processing code | 212 lines JavaScript |
| Post-processing code | 69 lines bash |
| Manual overrides | ~4,700 bytes F# |
| Proposed Glutinum patches | 48 lines |
| Documented unresolved issues | 2 (reserved keywords, record generation) |
| CI/CD maintenance | Weekly regeneration workflow with validation |
| Total compensatory infrastructure | ~330 lines across 3 languages |

Each Cloudflare SDK update can break the regex-based preprocessor. The post-processor is stable but tightly coupled to Glutinum's current output patterns.

## 3. How Xantham's Architecture Addresses These Problems

### 3.1 Cyclic References

Glutinum's monolithic pipeline processes types in a single pass, which causes stack overflow on cycles. Xantham handles this at three levels:

- **Extraction**: The Reader (`Xantham.Fable/Reader.fs`) marks visited nodes with `_PARTAS_VISITED`, preventing infinite recursion during AST crawling.
- **Schema**: The TypeKey indirection system (integer references into a `TypeMap`) means cyclic structures are representable without physical nesting. A type referencing itself contains a TypeKey that points back to its own entry.
- **Generation**: The TypeResolver caches each type's ShortCircuit reference *before* evaluating its Full render. When a cycle is encountered, the ShortCircuit is already available. The CircuitBreaker module provides additional fallback rendering for recursive inline type references.

The `preprocess-typescript.js` cycle detection and `any`-replacement logic would be eliminated entirely.

### 3.2 Intersection Type Handling

Glutinum's intersection handling degrades beyond 3 constituents. Xantham models intersections as `TsTypeIntersection of TypeKey list`, preserving the full constituent list. The TypeResolver (line 427-432) already handles intersections by delegating to `InterfaceRender.prerenderFromIntersection`, which flattens members from all constituents into a combined interface. This is complete in the resolution layer.

### 3.3 Namespace and Module Naming

Glutinum operates in Fable's JavaScript runtime with limited F# namespace control. Xantham's generation phase runs in .NET using `Fabulous.AST` and `Fantomas.SyntaxOak`, with direct access to F# AST construction. Module names, namespace declarations, and import statements are first-class generator responsibilities. The `renderModuleTree` and `foldBuilder` functions (TypeResolver.fs, lines 518-594) construct a hierarchical module tree from the type graph, producing correct F# module nesting.

All 5 sed-based fixups in `postprocess-runtime.sh` become unnecessary.

### 3.4 Reserved Keyword Handling

Xantham's generator has full access to property metadata (name, type, modifiers) via the `TsProperty` schema and the `PropertyRender.fs` module. Implementing `[<CompiledName("namespace")>]` attribute emission with PascalCase member names is a straightforward addition to the property rendering pipeline.

### 3.5 Type Ordering

Xantham's `renderModuleTree` constructs a dependency-aware module tree from the full type graph, and the Finalizers module handles output ordering. F#'s top-down requirement is addressed structurally, not through post-hoc reordering.

## 4. Generator Maturity: Corrected Assessment

The initial reading of the generator status was misleadingly pessimistic. The generator has a **three-level rendering architecture**, and the `obj` fallbacks at each level have different causes and severities.

### 4.1 The Three Levels

**Level 1 - TypeResolver (`resolvePattern`, 456 lines)**: Resolves every TypeScript construct to a `Render` struct containing a ShortCircuit (type reference) and an optional Full (type definition). This level is **essentially complete**. Every `MasterKey.KeyType` case has a handler that produces a valid `Render`.

**Level 2 - `typeBuilder` (lines 529-563)**: Dispatches `TypeRender` cases to Fabulous.AST type definitions. **This is where the real gap lives.** Seven of twelve `TypeRender` cases fall through to a placeholder:

```fsharp
| TypeLiteral _ | Variable _ | TypeParameter _
| Function _ | TypeAlias _ | TypeReference _
| Tuple _ -> Ast.InterfaceEnd("None") {}
```

The five working cases (Interface, Class, LiteralUnion, Enum, ErasedUnion) produce correct output.

**Level 3 - CircuitBreaker (`renderPathType`)**: Renders inline type references during cyclic resolution. Falls back to `obj` for 8 PathType cases. This is **intentionally minimal** for cycle-breaking; the real rendering happens in TypeResolver. CircuitBreaker `obj` fallbacks are acceptable and low-priority.

### 4.2 Corrected Status Table

| Component | Status | Detail |
|:----------|:------:|:-------|
| Schema (`Xantham.Common`) | Stable | 640 lines; `TsType` has 22 cases, `TsAstNode` has 32. Comprehensive. |
| Reader (`Xantham.Fable`) | Functional | 2,551+ lines. Recursion-safe extraction with `_PARTAS_VISITED`. |
| Decoder (`Xantham.Decoder`) | Functional | Thoth-based deserialization. `XanthamTree` with frozen dictionaries. Path system in refinement. |
| TypeResolver (Level 1) | **Complete** | All `MasterKey.KeyType` cases handled. ShortCircuit and Full renders for every construct. |
| `typeBuilder` (Level 2) | **5/12 cases complete** | Interface, Class, LiteralUnion, Enum, ErasedUnion working. 7 cases emit placeholder. |
| CircuitBreaker (Level 3) | Acceptable | Intentionally minimal. 8 `obj` fallbacks are by design for cycle-breaking. |
| Render Modules | **Infrastructure complete** | TypeLiteralRender, TupleRender, TypeAliasRender, FunctionRender, VariableRender all have prerender functions. |

### 4.3 Generator Completeness Against Cloudflare Workers-Types

Revised with the corrected understanding of which level each construct is handled at:

| Construct | Frequency | TypeResolver (L1) | typeBuilder (L2) | Net Status |
|:----------|:----------|:------------------:|:----------------:|:-----------|
| Interfaces | Very high (~500+) | Complete | Complete | **Done** |
| Classes | Moderate (~50+) | Complete | Complete | **Done** |
| Enums | Low (~20) | Complete | Complete | **Done** |
| Erased unions | High | Complete | Complete | **Done** |
| Literal unions | Moderate | Complete | Complete | **Done** |
| Type aliases | High (~100+) | Complete | **Placeholder** | Wiring needed |
| Type literals | Moderate | Complete | **Placeholder** | Wiring needed |
| Tuples | Low | Complete | **Placeholder** | One-line fix |
| Functions (top-level) | Moderate | Complete | **Placeholder** | Wiring needed |
| Variables | Low | Complete | **Placeholder** | Wiring needed |
| Type references | Moderate | Complete | **Placeholder** | Wiring needed |
| Type parameters | N/A (inline) | Complete | **Placeholder** | Guard/skip; not standalone |
| Intersections | Moderate | Complete | Complete (via Interface) | **Done** |
| Conditionals | Low | Complete | Complete (via ErasedUnion) | **Done** |
| Index types | Low | Complete | Complete | **Done** |
| Indexed access | Low | Complete | Complete | **Done** |

The "Placeholder" items in the typeBuilder column are the entire remaining gap.

## 5. Specific Gap Analysis

### 5.1 Tuple (Trivial)

`TupleRender.fs` already contains `toTypeDefnAbbrev` (line 110), a complete function that produces `Ast.Abbrev` with correct tuple element types, option wrapping for optional elements, and name extraction from the path. It is written but never called from `typeBuilder`.

Additionally, `TypeAliasRender.fs:365` contains a `failwith "todo - tuple for type alias"` that blocks tuple types appearing as the underlying type of a type alias. The code immediately following the failwith (lines 366-382) is already written and functional.

**Fix**: One line in `typeBuilder` + remove one `failwith`.

### 5.2 TypeParameter (Trivial)

TypeParameters should not appear as standalone type definitions. They are consumed by their parent types (interfaces, classes, functions, type aliases) via `TypeParameterRender.prerender`. If instances reach `typeBuilder`, it indicates an edge case in module tree construction.

**Fix**: Replace the placeholder with a no-op or diagnostic skip.

### 5.3 TypeLiteral (Small)

TypeScript anonymous object types (`{ foo: string; bar: number }`) become F# interfaces. `TypeLiteralRender.fs` has `collectMembersAsAbstracts` (line 20) and `collectMembersAndOverloads` (line 24), both functional. The rendering pattern is identical to `InterfaceRender.renderInterfaceTypeDefn`.

**Fix**: Add a case to `typeBuilder` that mirrors the InterfaceRender dispatch, using `TypeLiteralRender.collectMembersAsAbstracts` and synthesizing a name from the path.

### 5.4 TypeAlias (Moderate)

`TypeAliasRender.createRender` (lines 79-438) is the most substantial piece of code in the generator. It handles every underlying type variant: TypeLiteral, Interface, Class, Union (with full literal/erased/mixed decomposition across 130+ lines), Intersection, TypeReference, Enum, TypeParameter, Tuple, Conditional, Literal, EnumCase. The resolution and prerendering are complete.

The `TypeAliasUnderlyingType` DU has 6 cases. Each maps to a different F# output form (interface type definition, type abbreviation, string enum, delegate), and each delegates to an existing render module.

**Fix**: Add a case to `typeBuilder` that dispatches on `TypeAliasUnderlyingType`, calling existing render functions for each variant.

### 5.5 TypeReference (Small)

A standalone `TypeRender.TypeReference` reaching `typeBuilder` means a type alias resolved to a reference with arguments (e.g., `type MyArray = Array<string>`). The `TypeReferenceRender` struct contains the target type and type arguments, both already resolved.

**Fix**: Emit a type abbreviation via `Ast.Abbrev`, applying type arguments with `Ast.AppPrefix`.

### 5.6 Variable (Small)

TypeScript `declare var` / `declare const` become F# `let` bindings with Fable `[<Import>]` attributes. The `VariableRender` struct contains the resolved type reference. Rendering requires emitting the correct import attributes and `jsNative` initializer.

**Fix**: Implement `VariableRender.toLetBinding` following the Fable import pattern.

### 5.7 Function (Moderate)

Top-level `declare function` becomes either a `let` binding (simple signatures) or a `delegate` type definition (complex signatures). `FunctionRender.prerender` exists and produces complete parameter/return type information. The TypeResolver's ShortCircuit (lines 323-361) already renders correct function signatures with the curried-vs-delegate decision.

**Fix**: Implement `FunctionRender.toTypeDefnOrBinding`, reusing the ShortCircuit signature logic for the type annotation and adding Fable import attributes.

## 6. Prioritized Work Plan

### Phase 1: Quick Wins (1-2 days)

| Item | Action | Lines of Code |
|:-----|:-------|:-------------|
| Tuple in `typeBuilder` | Call existing `TupleRender.toTypeDefnAbbrev` | ~1 line |
| Tuple in `TypeAliasRender` | Remove `failwith` at line 365 | Delete 1 line |
| TypeParameter in `typeBuilder` | Replace placeholder with no-op skip | ~1 line |

### Phase 2: High-Impact Completions (3-5 days)

| Item | Action | Lines of Code |
|:-----|:-------|:-------------|
| TypeLiteral in `typeBuilder` | Mirror InterfaceRender pattern with `collectMembersAsAbstracts` | ~15 lines |
| TypeAlias in `typeBuilder` | Dispatch on 6 `TypeAliasUnderlyingType` cases | ~40 lines |
| TypeReference in `typeBuilder` | Type abbreviation with `Ast.Abbrev` | ~12 lines |

### Phase 3: Remaining Constructs (2-3 days)

| Item | Action | Lines of Code |
|:-----|:-------|:-------------|
| Variable in `typeBuilder` | `let` binding with `[<Import>]` attribute | ~20 lines |
| Function in `typeBuilder` | Delegate or `let` binding with signature | ~30 lines |

### Phase 4: CircuitBreaker Polish (1-2 days)

| Item | Action | Impact |
|:-----|:-------|:-------|
| TypeParameter in CircuitBreaker | Render as `'T` from path name | Improved generic member signatures |
| Tuple in CircuitBreaker | Inline tuple type from element types | Improved tuple member signatures |
| TypeLiteral in CircuitBreaker | Render path name instead of `obj` | Improved anonymous object references |

**Total estimated new code**: ~120 lines in `typeBuilder` + ~50 lines in supporting render functions. The infrastructure carrying the weight (~5,000+ lines of existing render modules, TypeResolver, and path system) is already built.

## 7. Validation Strategy

After each phase, measure progress with:

1. **Run the extractor** against `@cloudflare/workers-types` and pipe the JSON to the SimpleGenerator.

2. **Count `InterfaceEnd("None")` placeholders** in the output. This is the direct measure of `typeBuilder` fallbacks. Target: zero.

3. **Attempt `dotnet build`** on the generated output within a test Fable project. Compilation errors reveal type ordering, attribute, or name resolution gaps.

4. **Diff against Glutinum output** from Fidelity.CloudEdge's `Generated.fs` (714KB). Compare type names and member counts for coverage parity.

5. **Run `dotnet fable`** to verify the generated F# compiles to functional JavaScript.

## 8. Recommendation

### 8.1 Is Xantham a viable Glutinum replacement?

Yes. The schema-driven, multi-phase architecture eliminates every category of pre/post-processing currently maintained in Fidelity.CloudEdge. Cyclic references, intersection handling, namespace management, reserved keyword attributes, and type ordering are all handled structurally.

### 8.2 Is it ready today?

No, but it is closer than initial inspection suggested. The type resolution layer is complete. The remaining work is concentrated in a single function (`typeBuilder`, TypeResolver.fs lines 529-563) and amounts to ~120 lines of dispatch logic that calls into already-written render infrastructure.

### 8.3 Estimated Effort to Replacement Readiness

**8-12 days of focused development.** This breaks down as:

- 1-2 days for trivial fixes (Tuple, TypeParameter)
- 3-5 days for high-impact completions (TypeLiteral, TypeAlias, TypeReference)
- 2-3 days for remaining constructs (Variable, Function)
- 1-2 days for CircuitBreaker polish

### 8.4 Migration Strategy

1. **Parallel run**: Generate bindings from both Glutinum and Xantham. Diff outputs. Quantify coverage gap.
2. **Close gaps**: Complete `typeBuilder` cases targeting Cloudflare-specific constructs first.
3. **Cut over**: Replace `generate-runtime.sh` to use Xantham. Retire `preprocess-typescript.js`, `postprocess-runtime.sh`, and manual patches.
4. **Clean up**: Remove Glutinum npm dependency and proposed patch file.

### 8.5 Strategic Benefits

1. **TypeScript GO resilience**: If the TypeScript ecosystem migrates to the GO-based compiler, only Xantham.Fable's encoder needs updating. The decoder, generators, and all downstream tooling remain unchanged.

2. **Generator customization**: A Fidelity-specific generator could emit bindings tailored to the CloudEdge actor model: Fable-optimized patterns, BAREWire-compatible serialization attributes, or other framework-specific concerns, without modifying the extraction pipeline.

3. **Elimination of compensatory infrastructure**: ~330 lines of pre/post-processing code across 3 languages, a weekly CI regeneration workflow, and 2 documented unresolved issues are all retired.
