# Verify pipeline scripts

Driver- and verify-pipeline helpers for the three-Cloudflare-SDK build.
All scripts assume execution from the `generators/xantham/` directory
(or via absolute path — they resolve their own location).

## Scripts

- `regen-all.sh` — rebuild Driver against current Xantham source and
  regenerate all three SDK outputs into `output/*.fs`. Pass `nobuild`
  to skip the rebuild step when the Driver is already up to date.

- `wrap-all.sh` — wrap all three regenerated `output/*.fs` files into
  `verify/*.wrapped.fs` with the `module rec` header and standard
  `Fable.Core` opens the verify .fsproj projects expect.

- `wrap-verify.sh <name> <output-fs-path> [<module-name>]` — wrap a
  single output file. `<module-name>` defaults to `Cloudflare<Name>`
  with the first character of `<name>` capitalized. Pass an explicit
  module name for non-identifier-clean names (e.g. `dynamic-workflows`
  needs `CloudflareDynamicWorkflows`).

- `verify-all.sh [counts|hist|fs0039]` — build all three verify
  projects with `--maxerrors:10000` and print:
  - `counts` (default): just `N Error(s)` per SDK
  - `hist`: FS-code histogram per SDK
  - `fs0039`: top 20 `'name'` buckets within FS0039 per SDK

## Typical workflow

After a speakez-xantham change:

```bash
cd generators/xantham
./scripts/regen-all.sh
./scripts/wrap-all.sh
./scripts/verify-all.sh           # quick counts
./scripts/verify-all.sh hist      # error-code breakdown
./scripts/verify-all.sh fs0039    # FS0039 'name' buckets
```

## Notes on the `--maxerrors:10000` flag

The F# compiler defaults to `--maxerrors:200` and silently truncates
beyond that. Cross-SDK error totals routinely run into the thousands
when peeling structural layers; without the flag, the histograms look
static while real progress is happening underneath. `verify-all.sh`
passes it; raw `dotnet build` invocations should too.
