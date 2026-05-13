#!/bin/bash
# Wrap a Xantham-generated .fs file with the module-rec header the verify
# .fsproj projects expect. The wrappers prepend `module rec <Module>`
# plus standard opens so the raw generator output (which has no top-level
# module declaration) becomes compilable.
#
# Usage:
#   ./scripts/wrap-verify.sh <name> <output-fs-path> [<module-name>]
#
# Wrapped file is written to ./verify/<name>.wrapped.fs.
# When <module-name> is omitted, defaults to `Cloudflare<Name>` with the
# first char of <name> capitalized (e.g. "agents" -> CloudflareAgents,
# "workersTypes" -> CloudflareWorkersTypes). Provide an explicit module
# name for inputs whose name isn't a clean F# identifier
# (e.g. "dynamic-workflows" -> "CloudflareDynamicWorkflows").

set -euo pipefail

if [ $# -lt 2 ] || [ $# -gt 3 ]; then
    echo "Usage: $0 <name> <output-fs-path> [<module-name>]" >&2
    exit 1
fi

NAME="$1"
SRC="$2"
MODULE_NAME="${3:-Cloudflare${NAME^}}"

if [ ! -f "$SRC" ]; then
    echo "Source file not found: $SRC" >&2
    exit 1
fi

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
DST_DIR="$SCRIPT_DIR/../verify"
WRAPPER_NAME="${NAME}.wrapped.fs"

{
    echo "module rec ${MODULE_NAME}"
    echo ""
    echo "open System"
    echo "open Fable.Core"
    echo "open Fable.Core.JS"
    echo "open Fable.Core.JsInterop"
    echo ""
    cat "$SRC"
} > "$DST_DIR/$WRAPPER_NAME"

echo "Wrote $DST_DIR/$WRAPPER_NAME"
