# Type Resolution Rules — Cloudflare OpenAPI Binding Generation

## Purpose

This document defines the rules for resolving untyped JSON fields (`JObject`, `JToken`, `JArray` from Newtonsoft, or `obj` as placeholder) into proper F# types in generated Cloudflare API bindings.

These rules serve three purposes:
1. **Postprocessor guidance** — a new `resolve-untyped-fields.fsx` postprocessor can implement these rules against Hawaii output
2. **Farscape generator specification** — when the Farscape OpenAPI generator (doc 12) replaces Hawaii, these rules define how `FreeForm` schema nodes resolve to `ClefDecl` types
3. **Audit reference** — for verifying that generated bindings expose proper F# types, not leaked JSON library types

### Constraint: No External Type Dependencies in Public API

Generated `Types.fs` files must not reference types from external packages (`Newtonsoft.Json`, `System.Text.Json`, etc.) in their public surface. The only types allowed are:
- **FSharp.Core types**: `string`, `int`, `float`, `bool`, `list<_>`, `Option<_>`, `Map<_,_>`, `obj`
- **System primitives**: `System.DateTimeOffset`, `System.Guid`, `byte[]`
- **Generated record types**: defined within the same `Types.fs`
- **Generated DU types**: defined within the same `Types.fs`

The serialization library (`FSharp.SystemTextJson`) lives exclusively in `OpenApiHttp.fs`'s `Serializer` module — it is an implementation detail, not a public contract.

---

## Rule Categories

### Category A: Cloudflare Envelope Types (Spec-Derived, Invariant)

The Cloudflare API uses a standard response envelope across all endpoints. These rules derive directly from the OpenAPI specification and are invariant across services.

#### Rule A1: Failure Envelope `errors` and `messages`

**Pattern**: Fields named `errors` or `messages` in `*api-response-common-failure` types.

**OpenAPI schema**: Always `list<{code: int; message: string}>`. The Cloudflare spec constrains `code` to `minimum: 1000`.

**Resolution**: Replace `obj` with `list<Errors>` or `list<Messages>`, using the module's existing `Errors`/`Messages` record types (which Hawaii generates correctly for success envelopes).

**Postprocessor implementation**: For each type whose name ends in `api-response-common-failure`, replace `errors: obj` with `errors: list<Errors>` and `messages: obj` with `messages: list<Messages>` — in both the field declaration and the `Create` method signature.

**Status**: Applied in current bindings.

#### Rule A2: Failure Envelope `result`

**Pattern**: Field named `result` in `*api-response-common-failure` types.

**OpenAPI schema**: `{"enum": [null], "nullable": true}` — always null in failure responses.

**Resolution**: `obj` is acceptable (it will always deserialize as null). A future improvement could use `unit option` with `None` semantics, but `obj` is honest and doesn't mislead.

**Status**: `obj` in current bindings. Acceptable.

#### Rule A3: Generic Envelope `result` (Common Types)

**Pattern**: Field named `result` in `*api-response-common` types (the generic success envelope).

**OpenAPI schema**: `{"type": "object"}` — varies by endpoint.

**Resolution**: `obj` is correct for the *generic* envelope type. The typed result lives in per-endpoint response types (e.g., `d1-create-databaseresponse` has `result: d1database-details-response`). The generic envelope exists for endpoints where Hawaii couldn't resolve the allOf composition.

**Future Farscape generator**: Should eliminate generic envelopes entirely — every endpoint gets a typed response record with the correct `result` type resolved from the schema.

**Status**: `obj` in current bindings. Correct for generic envelopes.

#### Rule A4: Response DU `BadRequest` Payloads

**Pattern**: `| BadRequest of payload: obj` in response discriminated unions.

**OpenAPI schema**: Always references the service's `*api-response-common-failure` type.

**Resolution**: Replace `obj` with the module's failure envelope type (e.g., `callsapi-response-common-failure`).

**Postprocessor implementation**: For each DU case `| BadRequest of payload: obj`, find the module's `*api-response-common-failure` type and substitute.

**Status**: Applied for Calls and R2Catalog. Needs postprocessor for remaining modules.

---

### Category B: Schema-Derivable Types (Require OpenAPI Spec Lookup)

These rules require reading the OpenAPI spec to determine the correct type. A postprocessor would need access to the preprocessed `*-openapi.json` alongside the generated `Types.fs`.

#### Rule B1: Timestamp Fields

**Pattern**: Fields named `created_at`, `updated_at`, `last_seen_at`, `expires_at`, `not_before`, `not_after` typed as `obj` or `Option<obj>`.

**OpenAPI schema**: `{"type": "string", "format": "date-time"}` — ISO 8601 timestamps.

**Resolution**: `System.DateTimeOffset` or `Option<System.DateTimeOffset>`.

**Validation**: Check that the module has a timestamp type alias (e.g., `type accesstimestamp = System.DateTimeOffset`). If so, use it for consistency with the rest of the module's types.

**Postprocessor implementation**: Match field names against the timestamp pattern. Replace in both field declarations and `Create` method parameters.

**Status**: Applied for Access module. Needs postprocessor for systematic coverage.

#### Rule B2: Identifier Fields

**Pattern**: Fields named `id`, `uuid`, `namespace_id`, `account_id`, `zone_id`, `certificate_id` typed as `obj` or `Option<obj>`.

**OpenAPI schema**: `{"type": "string"}` — always string identifiers.

**Resolution**: `string` or `Option<string>`.

**Postprocessor implementation**: Match field names against the `*_id` / `id` / `uuid` pattern.

**Status**: Applied for Access `id` and Workers `namespace_id`. Needs postprocessor.

#### Rule B3: Type Aliases That Were JToken

**Pattern**: Top-level type aliases like `type accesscreatedat = obj` or `type accessapps = Map<string, obj>` that were originally `JToken` aliases.

**Resolution**: Requires schema lookup. Common resolutions:
- Timestamp aliases → `System.DateTimeOffset`
- ID aliases → `string`
- Collection aliases → `list<_>` with element type from schema
- Config/metadata aliases → `Map<string, obj>` (genuinely polymorphic)

**Postprocessor implementation**: Read the schema's `#/components/schemas/<alias-name>` definition to determine the correct type.

**Status**: Partially applied (Access timestamps). Needs schema-aware postprocessor.

#### Rule B4: Error/Message Type Aliases (Gateway Pattern)

**Pattern**: Per-endpoint error/message type aliases like `type ErrorsFromZeroTrustListBadRequest = obj`.

**OpenAPI schema**: Always `{code: int; message: string}` — same as the standard error item.

**Resolution**: These type aliases should resolve to `{code: int; message: string}` or reference the module's shared `Errors` type.

**Postprocessor implementation**: Any type alias whose name matches `Errors*BadRequest` or `Messages*BadRequest` gets the standard error record body.

**Status**: Applied for Gateway. Systematic coverage needed.

---

### Category C: Semantically-Typed Fields (Require Domain Knowledge + Schema)

These rules require both OpenAPI schema access and understanding of the Cloudflare API domain. A postprocessor can implement them, but the rules are more nuanced.

#### Rule C1: AI Model Identifiers

**Pattern**: Fields named `ai_search_model`, `embedding_model`, `reranking_model`, `rewrite_model`, `model` in AI/AISearch/AIGateway/AutoRAG modules.

**OpenAPI schema**: Varies — some are `{"type": "string"}` (model name like `@cf/meta/llama-3`), others are `{"type": "object"}` (model configuration with provider-specific fields).

**Resolution**:
- If schema is `{"type": "string"}` → `string`
- If schema is `{"type": "object"}` with known properties → generate a record type
- If schema is `{"type": "object"}` without properties → `Map<string, obj>`

**Complication**: The same field name appears in different types with different schemas. A postprocessor must resolve per-occurrence, not per-name.

**Postprocessor implementation**: For each `model: Option<obj>`, look up the containing type in the OpenAPI spec, find the property schema, and resolve.

#### Rule C2: Configuration Objects

**Pattern**: Fields named `config`, `settings`, `options` typed as `obj` or `Option<obj>`.

**OpenAPI schema**: Polymorphic — different depending on the parent type (e.g., Access identity provider config varies by provider type: Azure, Google, Okta each have different config shapes).

**Resolution**:
- If the schema has `properties` → generate a record type
- If the schema has `oneOf`/`anyOf` → generate a discriminated union
- If the schema is `{"type": "object"}` with no properties → `Map<string, obj>`

**Postprocessor implementation**: Schema-driven. The postprocessor reads the OpenAPI spec's property definition for the containing type, resolves `$ref` chains, and generates the appropriate F# type.

**Note for Farscape generator**: This is the key advantage of the Farscape approach — the generator walks the full schema graph during code generation, so polymorphic configs naturally produce DUs or records. Hawaii falls back to JObject because its type resolution gives up on complex allOf/oneOf compositions.

#### Rule C3: Metadata Fields

**Pattern**: Fields named `metadata` typed as `obj` or `Option<obj>`.

**OpenAPI schema**: Usually `{"type": "object", "additionalProperties": true}` — user-defined key-value metadata.

**Resolution**: `Map<string, obj>` — the F# type for a JSON object with arbitrary string keys.

**Complication**: Both the field declaration AND the `Create` method parameter must be updated. If the `Create` method initializes the field to `None`, the parameter type can stay as `Option<Map<string, obj>>`. But if it's a required field with a default value, the Create method needs adjustment.

**Postprocessor implementation**: Replace the field type, then find and update the matching `Create` method parameter. If the Create method has a default value expression that doesn't type-check (e.g., assigns `obj` to `Map<string, obj>`), adjust the default.

#### Rule C4: DLP, Health Check, and Other Structured Config

**Pattern**: Fields named `dlp`, `health_check`, `origin`, etc. typed as `obj`.

**Resolution**: Schema-dependent. These are structured objects that Hawaii couldn't resolve (typically due to allOf composition).

**Postprocessor implementation**: Same as Rule C2 — schema-driven resolution.

#### Rule C5: Payload Fields in Response DUs

**Pattern**: `| OK of payload: obj` in response discriminated unions.

**OpenAPI schema**: The `200` response schema for the corresponding endpoint.

**Resolution**: Generate a typed response record from the schema and use it as the payload type.

**Complication**: This is Hawaii's core limitation. When the response schema uses allOf to compose a base envelope with endpoint-specific properties, Hawaii falls back to `obj`. The `preprocess-openapi.sh` script already flattens some of these, but not all.

**Postprocessor implementation**: For each `| OK of payload: obj`, find the corresponding endpoint in the OpenAPI spec, resolve the response schema, and either:
1. Find an existing typed response record in the module
2. Generate a new one

**Note for Farscape generator**: This is where the Farscape approach wins decisively — the catamorphism walks every response schema and produces typed records. No fallback to `obj`.

---

### Category D: Irreducibly Dynamic (Acceptable as `obj`)

Some fields are genuinely unstructured. These are acceptable as `obj`.

#### Rule D1: Freeform Request/Response Bodies

**Pattern**: Fields named `body` in message/request types (e.g., Queues message body).

**OpenAPI schema**: `{"type": "object"}` or `{}` — intentionally schema-free.

**Resolution**: `obj` is correct. The body is opaque user data.

#### Rule D2: Generic Result in Common Envelopes

Covered by Rule A3 above. The generic envelope's `result` is polymorphic by design.

#### Rule D3: Truly Polymorphic Containers

**Pattern**: Fields like `accessapps`, `accessidentity-providers` that represent collections of different object types.

**Resolution**: `Map<string, obj>` is acceptable. A DU would be ideal but requires enumerating all possible shapes.

---

## Postprocessor Architecture

### New Postprocessor: `resolve-untyped-fields.fsx`

**Inputs**:
1. `Types.fs` — the generated types file
2. `*-openapi.json` — the preprocessed OpenAPI spec for the service
3. (Optional) `Client.fs` — to cross-reference endpoint→response type mappings

**Processing order** (rules applied in dependency order):
1. **A1**: Fix failure envelope errors/messages (no schema needed)
2. **A4**: Fix BadRequest DU payloads (no schema needed — just match failure type name)
3. **B1**: Fix timestamp fields (field name pattern match)
4. **B2**: Fix identifier fields (field name pattern match)
5. **B3**: Fix type aliases (schema lookup)
6. **B4**: Fix error/message type aliases (type name pattern match)
7. **C1-C5**: Schema-driven field resolution (requires OpenAPI spec)

**Output**: Modified `Types.fs` with all resolvable `obj` fields replaced with proper F# types.

**Critical constraint**: Every field replacement must also update the corresponding `Create` method parameter. The postprocessor must parse record definitions and their Create methods as paired units.

### Integration Point

In `generate-management.sh`, the new postprocessor runs after `auto-fix-types.fsx` and before `fix-list-separators.fsx`:

```bash
# After auto-fix-types.fsx
print_info "Post-processing: resolve untyped fields..."
dotnet fsi "$POSTPROCESSORS_DIR/resolve-untyped-fields.fsx" \
    "$GENERATED_DIR/Types.fs" \
    "$SPEC_FILE"
```

---

## Current Status (Post-Migration)

### Completed (Applied to All 32 Modules)

| Rule | Description | Occurrences Fixed |
|------|-------------|-------------------|
| — | Newtonsoft.Json dependency removed from all modules | 32 modules |
| — | Fable.Remoting.Json dependency removed from all modules | 32 modules |
| — | Serializer module migrated to FSharp.SystemTextJson | 32 modules |
| — | `JObject`/`JToken`/`JArray` removed from public surface | 1,313 occurrences |
| A1 | Failure envelope errors/messages | ~100 fields |
| A4 | BadRequest DU payloads (Calls, R2Catalog) | 3 DU cases |
| B1 | Access timestamp fields | ~28 fields |
| B2 | Access/Workers ID fields | 4 fields |
| B4 | Gateway error/message type aliases | 60 type aliases |

### Remaining (Requires Postprocessor)

| Rule | Description | Estimated Occurrences |
|------|-------------|----------------------|
| A4 | BadRequest DU payloads (other modules) | ~20 |
| B1 | Timestamp fields (non-Access modules) | ~10 |
| B2 | ID fields (non-Access modules) | ~5 |
| B3 | Type aliases from JToken | ~10 |
| C1 | AI model identifiers | ~56 |
| C2 | Config objects | ~37 |
| C3 | Metadata fields | ~13 |
| C4 | DLP/health check/structured config | ~20 |
| C5 | Payload fields in response DUs | ~193 |
| D1-D3 | Irreducibly dynamic (acceptable as `obj`) | ~50 |

**Total remaining `obj` fields**: ~1,000 (of which ~50 are acceptable as `obj`)

---

## Relationship to Farscape OpenAPI Generator (Doc 12)

The Farscape generator eliminates Categories A-C entirely by design:

| Category | Hawaii + Postprocessor | Farscape Generator |
|----------|----------------------|-------------------|
| A (Envelopes) | Postprocessor pattern-matches type names | Catamorphism recognizes envelope patterns during fold |
| B (Schema-derivable) | Postprocessor reads OpenAPI spec | Schema resolver handles during `classifySchema` |
| C (Semantic) | Postprocessor needs domain rules + schema | Active patterns classify during AST construction |
| D (Dynamic) | Stays as `obj` | `FreeForm` variant in `SchemaType`, renders as `obj` |

The key architectural difference: Hawaii generates `Types.fs` in one pass and postprocessors fix it afterward. Farscape's pipeline resolves types *during* generation — the catamorphism and active patterns classify schemas before `ClefDecl` nodes are produced, so no post-hoc fixup is needed.

---

## Test Strategy

Tests remain on Newtonsoft.Json during the migration. This provides cross-serializer validation:
- Tests serialize with `Newtonsoft.Json` + `FableJsonConverter`
- Bindings deserialize with `System.Text.Json` + `JsonFSharpConverter`
- If a test passes, the type change is wire-compatible

After all binding types are finalized, tests can optionally migrate to `System.Text.Json`. This is a separate decision — "the juice must be worth the squeeze."
