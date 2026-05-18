#!/bin/bash
# Rebuild Driver against current Xantham and regenerate all 12 Cloudflare
# runtime SDK outputs. Run after speakez-xantham source changes.
#
# Usage:
#   ./scripts/regen-all.sh            # build + regen all 12
#   ./scripts/regen-all.sh nobuild    # regen only (driver already built)
#
# The bare `cloudflare` package is the management REST client (handled
# separately via Hawaii + OpenAPI) and is NOT a Xantham target.

set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
DRIVER_DIR="$SCRIPT_DIR/.."
OUT_DIR="$DRIVER_DIR/output"
MODE="${1:-build}"

# The 12 runtime SDK targets.
SDKS=(
    agents
    ai-chat
    codemode
    containers
    dynamic-workflows
    puppeteer
    sandbox
    shell
    think
    voice
    worker-bundler
    workers-types
)

cd "$DRIVER_DIR"

if [ "$MODE" = "build" ]; then
    dotnet build Driver.fsproj --no-incremental 2>&1 | tail -3
fi

for sdk in "${SDKS[@]}"; do
    dotnet run --project Driver.fsproj --no-build -- \
        "$OUT_DIR/${sdk}.json" "$OUT_DIR/${sdk}.fs" 2>&1 | tail -1
done
