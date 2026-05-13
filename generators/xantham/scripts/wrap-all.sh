#!/bin/bash
# Wrap all three Cloudflare SDK outputs in a single call. Invoke after a
# Driver regen run that's updated output/*.fs.
#
# Usage:
#   ./scripts/wrap-all.sh

set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
OUT_DIR="$SCRIPT_DIR/../output"

"$SCRIPT_DIR/wrap-verify.sh" agents       "$OUT_DIR/agents.fs"
"$SCRIPT_DIR/wrap-verify.sh" workersTypes  "$OUT_DIR/workers-types.fs"
"$SCRIPT_DIR/wrap-verify.sh" dynamic-workflows "$OUT_DIR/dynamic-workflows.fs" CloudflareDynamicWorkflows
