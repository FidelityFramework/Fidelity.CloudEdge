#!/bin/bash
# Build all 12 Cloudflare runtime SDK verify projects with uncapped
# errors and emit per-project error counts. F# defaults to
# --maxerrors:200 which silently truncates real totals; passing
# /p:OtherFlags="--maxerrors:100000" gets honest counts.
#
# Usage:
#   ./scripts/verify-all.sh           # error counts (raw / distinct) per SDK
#   ./scripts/verify-all.sh hist      # FS-code histogram per SDK
#   ./scripts/verify-all.sh fs0039    # 'name' bucket histogram for FS0039 per SDK
#
# About the counts:
#   raw      = unique `file(line,col): error FSnnnn: ...` lines.
#              MSBuild emits each error twice (compiler line + summary
#              line), so a naive `grep -c "error FS"` over-counts by 2×.
#              `sort -u` collapses that to one line per emission site.
#   distinct = file:line:col-stripped, then deduped. Counts unique error
#              MESSAGES regardless of where they fire. Useful for
#              measuring how many *kinds* of problem exist (vs. how many
#              sites trigger them).

set -uo pipefail
# Intentionally no `-e`: each verify project is expected to return
# non-zero (it has compile errors). We want to iterate all 12 and
# print each one's count regardless.

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
VERIFY_DIR="$SCRIPT_DIR/../verify"
MODE="${1:-counts}"

# The 12 runtime SDK verify projects.
PROJECTS=(
    Verify.Agents
    Verify.AiChat
    Verify.Codemode
    Verify.Containers
    Verify.DynamicWorkflows
    Verify.Puppeteer
    Verify.Sandbox
    Verify.Shell
    Verify.Think
    Verify.Voice
    Verify.WorkerBundler
    Verify.WorkersTypes
)

cd "$VERIFY_DIR"

# Track totals across the loop.
total_raw=0
total_distinct=0

for proj in "${PROJECTS[@]}"; do
    case "$MODE" in
        counts)
            output=$(dotnet build "$proj.fsproj" --no-incremental \
                /p:OtherFlags="--maxerrors:100000" 2>&1 | grep -E "error FS")
            raw=$(echo "$output" | sort -u | wc -l)
            distinct=$(echo "$output" | sed -E 's/^.*\(([0-9]+,[0-9]+)\): //' \
                | sort -u | wc -l)
            # `grep -E "error FS"` against empty stdin returns 0 lines but
            # `wc -l` on empty input returns 1 (the trailing newline from
            # the empty echo). Detect the no-error case explicitly.
            if [ -z "$output" ]; then raw=0; distinct=0; fi
            printf "%-30s %5d raw / %5d distinct\n" "$proj" "$raw" "$distinct"
            total_raw=$(( total_raw + raw ))
            total_distinct=$(( total_distinct + distinct ))
            ;;
        hist)
            echo "=== $proj ==="
            dotnet build "$proj.fsproj" --no-incremental \
                /p:OtherFlags="--maxerrors:100000" 2>&1 \
                | grep "error FS" | sort -u \
                | grep -oE "FS[0-9]+" \
                | sort | uniq -c | sort -rn
            echo
            ;;
        fs0039)
            echo "=== $proj ==="
            dotnet build "$proj.fsproj" --no-incremental \
                /p:OtherFlags="--maxerrors:100000" 2>&1 \
                | grep "error FS0039" | sort -u \
                | grep -oE "'[^']+'" \
                | sort | uniq -c | sort -rn | head -20
            echo
            ;;
        *)
            echo "Unknown mode: $MODE (use counts | hist | fs0039)" >&2
            exit 1
            ;;
    esac
done

if [ "$MODE" = "counts" ]; then
    printf -- "----------------------------------------------------\n"
    printf "%-30s %5d raw / %5d distinct\n" "TOTAL (12 SDKs)" "$total_raw" "$total_distinct"
fi
