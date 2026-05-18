#!/bin/bash
# Wrap all 12 Cloudflare runtime SDK outputs in a single call. Invoke
# after a Driver regen run that's updated output/*.fs.
#
# Usage:
#   ./scripts/wrap-all.sh
#
# Per-SDK module-name conventions (passed as the third arg to
# wrap-verify.sh) handle the cases where the SDK name doesn't pascal-case
# cleanly into a single F# identifier:
#   - hyphenated names (`dynamic-workflows`, `ai-chat`, `worker-bundler`)
#     get an explicit module name like `CloudflareDynamicWorkflows`
#   - `workers-types` is renamed to `workersTypes` for the wrap source
#     because the verify project file is `Verify.WorkersTypes.fsproj`
#   - everything else (`agents`, `codemode`, `containers`, `puppeteer`,
#     `sandbox`, `shell`, `think`, `voice`) takes the default module name
#     `Cloudflare<Name>` from `wrap-verify.sh` itself

set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
OUT_DIR="$SCRIPT_DIR/../output"

"$SCRIPT_DIR/wrap-verify.sh" agents            "$OUT_DIR/agents.fs"
"$SCRIPT_DIR/wrap-verify.sh" ai-chat           "$OUT_DIR/ai-chat.fs"           CloudflareAiChat
"$SCRIPT_DIR/wrap-verify.sh" codemode          "$OUT_DIR/codemode.fs"
"$SCRIPT_DIR/wrap-verify.sh" containers        "$OUT_DIR/containers.fs"
"$SCRIPT_DIR/wrap-verify.sh" dynamic-workflows "$OUT_DIR/dynamic-workflows.fs" CloudflareDynamicWorkflows
"$SCRIPT_DIR/wrap-verify.sh" puppeteer         "$OUT_DIR/puppeteer.fs"
"$SCRIPT_DIR/wrap-verify.sh" sandbox           "$OUT_DIR/sandbox.fs"
"$SCRIPT_DIR/wrap-verify.sh" shell             "$OUT_DIR/shell.fs"
"$SCRIPT_DIR/wrap-verify.sh" think             "$OUT_DIR/think.fs"
"$SCRIPT_DIR/wrap-verify.sh" voice             "$OUT_DIR/voice.fs"
"$SCRIPT_DIR/wrap-verify.sh" worker-bundler    "$OUT_DIR/worker-bundler.fs"    CloudflareWorkerBundler
"$SCRIPT_DIR/wrap-verify.sh" workersTypes      "$OUT_DIR/workers-types.fs"
