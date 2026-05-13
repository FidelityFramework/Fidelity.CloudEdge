#!/bin/bash
# Rebuild Driver against current Xantham and regenerate all three SDK
# outputs. Run after speakez-xantham source changes.
#
# Usage:
#   ./scripts/regen-all.sh            # build + regen all three
#   ./scripts/regen-all.sh nobuild    # regen only (driver already built)

set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
DRIVER_DIR="$SCRIPT_DIR/.."
OUT_DIR="$DRIVER_DIR/output"
MODE="${1:-build}"

cd "$DRIVER_DIR"

if [ "$MODE" = "build" ]; then
    dotnet build Driver.fsproj --no-incremental 2>&1 | tail -3
fi

dotnet run --project Driver.fsproj --no-build -- "$OUT_DIR/agents.json"             "$OUT_DIR/agents.fs"             2>&1 | tail -3
dotnet run --project Driver.fsproj --no-build -- "$OUT_DIR/workers-types.json"      "$OUT_DIR/workers-types.fs"      2>&1 | tail -3
dotnet run --project Driver.fsproj --no-build -- "$OUT_DIR/dynamic-workflows.json"  "$OUT_DIR/dynamic-workflows.fs"  2>&1 | tail -3
