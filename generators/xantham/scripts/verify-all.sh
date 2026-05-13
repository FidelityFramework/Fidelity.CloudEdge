#!/bin/bash
# Build all three verify projects with uncapped errors. F# defaults to
# --maxerrors:200 which silently truncates real totals into 4 digits;
# passing /p:OtherFlags="--maxerrors:10000" gets honest counts.
#
# Usage:
#   ./scripts/verify-all.sh           # error counts only
#   ./scripts/verify-all.sh hist      # plus FS-code histogram per SDK
#   ./scripts/verify-all.sh fs0039    # plus 'name' bucket histogram for FS0039

set -uo pipefail
# Intentionally no `-e`: each verify project is expected to return
# non-zero (it has compile errors). We want to iterate all three and
# print each one's count regardless.

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
VERIFY_DIR="$SCRIPT_DIR/../verify"
MODE="${1:-counts}"

cd "$VERIFY_DIR"

for proj in Verify.DynamicWorkflows Verify.WorkersTypes Verify.Agents; do
    echo "=== $proj ==="
    case "$MODE" in
        counts)
            dotnet build "$proj.fsproj" --no-incremental \
                /p:OtherFlags="--maxerrors:10000" 2>&1 \
                | tail -3 | head -2
            ;;
        hist)
            dotnet build "$proj.fsproj" --no-incremental \
                /p:OtherFlags="--maxerrors:10000" 2>&1 \
                | grep "error FS" | grep -oE "FS[0-9]+" \
                | sort | uniq -c | sort -rn
            ;;
        fs0039)
            dotnet build "$proj.fsproj" --no-incremental \
                /p:OtherFlags="--maxerrors:10000" 2>&1 \
                | grep "error FS0039" | grep -oE "'[^']+'" \
                | sort | uniq -c | sort -rn | head -20
            ;;
        *)
            echo "Unknown mode: $MODE (use counts | hist | fs0039)" >&2
            exit 1
            ;;
    esac
    echo
done
