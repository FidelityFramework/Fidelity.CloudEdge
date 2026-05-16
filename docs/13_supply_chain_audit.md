# Supply-chain audit policy for TypeScript SDK pins

**Date:** 2026-05-16
**Scope:** The three Cloudflare TypeScript SDKs ingested by the xantham
generator — `@cloudflare/workers-types`, `@cloudflare/dynamic-workflows`,
`agents` — and every transitive `npm` dependency that lands in the
generator host's `node_modules/` during a regen.

## Operating posture (relaxed default with sentinel triggers)

This document specifies the full audit framework. In practice it is
operated **leanly**: routine SDK bumps and `npm install` runs proceed
without ceremony, and the strict ceremony below is reserved for
specific risk triggers.

**Default posture:** Proceed with normal `npm install` against the
working environment. Do not require sandboxed installs, `npm ci
--ignore-scripts`, or `npm audit signatures` on every bump.

**Sentinel triggers — when the strict policy applies:**

1. **Hot transitive in the embargo window.** After install, a quick
   scan shows any resolved transitive (anywhere in the tree) was
   published to npm within the last 72 hours. Surface the package and
   its publish timestamp to the user; they decide whether to wait or
   proceed.
2. **Active campaign disclosure.** A shai-hulud-class disclosure
   (Wiz, StepSecurity, Socket, CISA, etc.) names packages in the
   resolved tree within the last 14 days. Treat the named package as
   embargoed regardless of its own publish age.
3. **Direct user flag.** The user explicitly asks "is X affected by
   Y" or names a specific concern about a package or campaign.

Outside these triggers, the per-publisher lift table below establishes
trust at the *publisher* level (provenance + OIDC + repo-org binding)
and the install proceeds normally. The strict checklist in this
document is the path of escalation, not the default ceremony.

## Why this policy exists

The xantham IR pipeline takes `.d.ts` files from installed npm packages
and emits F# bindings. The F# side is heavily verified
(`generators/xantham/verify/*.fsproj`), but the **acquisition step is
plain `npm install`**, which runs `postinstall` hooks under the user's
shell with access to `~/.npmrc`, `~/.aws/`, `~/.config/gh/`, and any
build tokens in the environment.

Throughout 2026 the npm registry has been under sustained, coordinated
supply-chain attack:

- **Axios compromise** (2026-03-31) — `axios@1.14.1` and `axios@0.30.4`
  shipped a malicious `plain-crypto-js@4.2.1` that fetched a multi-stage
  remote-access trojan.
- **Mini Shai-Hulud / TeamPCP** (disclosed 2026-05-12) — a
  self-propagating worm hit TanStack, Mistral AI, UiPath, and 160+
  other packages. It steals npm tokens, exfiltrates `~/.npmrc` and
  cloud-credential files, and on some variants wipes the developer's
  home directory.
- **node-ipc** (2026-05-14) — three malicious versions (`9.1.6`,
  `9.2.3`, `12.0.1`) carried an 80 KB credential stealer.

None of these names appears in our resolved tree by name, but the wave
is active and the worm specifically chains through transitive deps. A
fresh `npm install` performed without first auditing the lock can pick
up a poisoned version of a maintainer who was compromised hours ago.

The cost of an audit is low; the cost of a single regen on a poisoned
tree is total developer-account compromise.

## When the policy applies

Run the audit before **any** of:

- bumping a pinned version in
  [generators/xantham/output/*.json](../generators/xantham/output) and
  re-running `regen-all.sh`
- updating a `^`-range or `~`-range entry in
  [package.json](../package.json) or
  `../speakez-xantham/package.json` and reinstalling
- adding a new TypeScript SDK to the ingestion set
- regenerating after pulling new speakez-xantham source that itself
  changed an npm dependency

It does **not** apply to F#-only changes that don't touch
`node_modules/`.

## Audit checklist

Each numbered step is mandatory; the per-step commands are the
reference invocation, not a suggestion.

### 1. Refresh the candidate version list

For each pinned dep, look up the current `dist-tags.latest` and the
release timestamp on the npm registry:

```bash
npm view @cloudflare/workers-types dist-tags.latest time
npm view @cloudflare/dynamic-workflows dist-tags.latest time
npm view agents dist-tags.latest time
```

Record the publish date. **Anything published in the last 72 hours is
treated as quarantined** — the average detection-to-takedown window
for the 2026 wave has been 36–60 hours. Either pick the
previous-stable version or wait.

The 72-hour embargo is a worst-case default. It can be lifted on a
per-publisher basis when there is durable evidence the publisher runs
a hardened release pipeline (see [Lifting the embargo](#lifting-the-embargo)
below). The embargo never lifts wholesale — it lifts for the direct
package whose publisher we've verified, while transitives stay under
the default.

### 2. Cross-check against active advisories

Before pulling, check the package and its top-level transitives against
all of:

- [npm advisories](https://www.npmjs.com/advisories) for the pinned
  name and version
- [GitHub Security Advisories](https://github.com/advisories) for the
  same
- [Socket.dev](https://socket.dev) — paste the package name, look for
  `Install scripts`, `Network`, `Filesystem`, `Shell` capability flags
  on the version under consideration
- the latest [Wiz](https://www.wiz.io/blog) and
  [StepSecurity](https://www.stepsecurity.io/blog) blog posts for
  campaign-level disclosures the CVE feeds haven't caught up with yet

If any tool flags the candidate version, fall back one minor and recheck.

### 2a. Re-verify the per-publisher lift (if any)

For each pinned direct dep that appears in the "Current per-publisher
policy" table as **Lifted**, re-check the provenance fields against
the live registry. The lift is conditional on these matching what
was recorded at verification time:

```bash
npm view @cloudflare/workers-types@<version> --json \
  | jq '.dist.attestations, .dist.signatures'
curl -s 'https://registry.npmjs.org/-/npm/v1/attestations/@cloudflare%2fworkers-types@<version>' \
  | jq '.attestations[0].bundle.dsseEnvelope.payload' \
  | base64 -d \
  | jq '.predicate.buildDefinition.externalParameters, .predicate.buildDefinition.internalParameters'
```

Confirm:

- `dist.attestations.provenance.predicateType` is `https://slsa.dev/provenance/v1`
- `buildDefinition.externalParameters.workflow.repository` matches the
  table entry exactly
- `internalParameters.github.repository_owner_id` is `314135` for any
  Cloudflare-org dep
- `runDetails.builder.id` is `https://github.com/actions/runner/github-hosted`
  (not a self-hosted runner)

If any of these has changed, treat the lift as expired for this audit
cycle, apply the default 72-hour embargo to that package, and flag the
change in the audit record so the table can be reset.

### 3. Audit the existing lockfile

Before reinstalling, audit what's already on disk:

```bash
cd ../speakez-xantham
npm audit --audit-level=high --omit=dev
npm audit signatures
```

`npm audit signatures` is the load-bearing check — it verifies that the
tarballs cached locally match what the registry currently serves. A
mismatch means a published version was silently re-signed, which is the
fingerprint of a maintainer-account takeover.

### 4. Sandbox the install

Never run `npm install` for an SDK bump against your real `$HOME`. Use a
throwaway environment:

```bash
# Option A: container
podman run --rm -it -v "$PWD:/work:Z" -w /work \
  --env-file /dev/null node:lts bash -c 'npm ci --ignore-scripts && npm rebuild'

# Option B: bubblewrap, no creds in env
bwrap --ro-bind /usr /usr --ro-bind /etc /etc --tmpfs /tmp \
  --bind "$PWD" /work --chdir /work --setenv HOME /tmp \
  --unshare-user --unshare-ipc --unshare-pid --unshare-uts \
  npm ci --ignore-scripts
```

`--ignore-scripts` is non-negotiable on the first install. Inspect what
landed in `node_modules/` — particularly any `postinstall`, `preinstall`,
or `install` script in each top-level package's `package.json` — before
running `npm rebuild` to execute the legitimate ones.

**Use `npm ci`, never `npm install`.** `npm install` re-resolves
semver ranges in transitive `package.json` files against whatever the
registry currently serves, which is precisely the attack surface a
publisher lift does **not** cover — the resolved transitive tarball
could be a freshly-poisoned patch of a healthy package. `npm ci`
installs exactly what `package-lock.json` says, with integrity hashes
verified against the lockfile entries. If the lockfile is out of date,
update it deliberately in a separate audit cycle, never as a side
effect of an install.

### 5. Integrity-verify the resolved tree

Diff the new `package-lock.json` against the previous one and review
every `integrity:` change. A version-bump that *also* changes the
integrity of an unbumped dependency is the strongest signal of a
hostile rewrite.

```bash
git diff -- package-lock.json | grep -E '^\+\s+"(version|integrity|resolved)"'
```

### 6. Generate, then verify

Only after the above is clean:

```bash
cd generators/xantham
./scripts/regen-all.sh
./scripts/wrap-all.sh
./scripts/verify-all.sh hist
```

If the F# verify output changes shape unexpectedly (new FS-codes, large
swings in bucket counts, new files appearing in
[generators/xantham/output/](../generators/xantham/output)),
treat that as a signal to re-examine the install, not as benign
generator drift.

### 7. Record the decision

Update [generators/xantham/output/observations.md](../generators/xantham/output/observations.md)
with:

- the new pinned version triple
- the audit date and which tools were consulted
- any version that was passed over and why

This is the audit trail. If a compromise is disclosed retroactively,
this record is how we know whether our build host saw the bad version.

## Quarantine and rollback

If at any step a pulled package fails an integrity check, has an
unexpected `postinstall` script, or beacons during `--ignore-scripts`
inspection:

1. Do **not** run `npm rebuild`.
2. Destroy the sandbox/container.
3. Revoke any npm/GitHub/cloud tokens that were ever exposed to the
   real `$HOME` since the last clean audit.
4. Roll back to the prior-good pin in
   [generators/xantham/output/*.json](../generators/xantham/output) and
   regenerate from that.
5. Report the finding upstream (npm Security, the maintainer, and
   relevant CERTs) and add the bad version to a denylist in the project
   `overrides` block.

## Lifting the embargo

The 72-hour quarantine applies by default to every pin. It can be
relaxed for a specific direct dependency when **all** of the following
are demonstrably true of that package's publisher:

1. **npm provenance attestations** are present on the releases under
   consideration. Verify with:
   ```bash
   npm view <pkg>@<version> --json | jq '.dist."npm-signature", .dist.attestations'
   ```
   A valid Sigstore-backed `attestations.provenance` block proves the
   tarball was built by a specific public GitHub Actions workflow with
   OIDC — not by a long-lived token on a maintainer's laptop.
2. **The build workflow is public and reproducible.** The provenance
   block names a workflow file at a commit SHA; that file must use
   `id-token: write` with OIDC, must not reference long-lived secrets
   for publishing, and the repo must be one we already trust by
   organization (e.g. `cloudflare/`).
3. **A documented SDLC / release security posture** exists from the
   publisher — a signed SECURITY.md, SLSA level claim, or equivalent
   public statement that we can reference in this doc. **A verifiable
   provenance attestation (criterion 1) satisfies this criterion in
   lieu of a written statement**, because machine-checkable evidence
   is strictly stronger than a marketing page that could be quietly
   removed.
4. **No active campaign** is currently targeting the publisher's
   org. Check Wiz, StepSecurity, and npm advisories within the last
   14 days before lifting.

When all four hold, record the lift in the table below with a date and
the verification evidence. The lift applies **only** to packages whose
publisher matches the verified org — transitives published by other
maintainers stay under the default embargo.

A lift expires automatically the first time any of the four conditions
no longer holds (provenance dropped, workflow changed in a way we
haven't re-verified, active campaign disclosed, posture statement
withdrawn). Re-verification is the cost of keeping the lift.

### Why transitives never qualify

A lift on a direct dependency does **not** transfer to its transitive
graph, and this is not a conservatism — it's a structural problem with
how npm resolves versions.

The `package.json` of every direct dependency declares its own deps as
semver ranges (`^1.2.3`, `~4.5.0`, etc.), not as exact pins. When `npm
install` runs, it re-resolves those ranges against whatever the
registry currently serves. So even though `@cloudflare/agents@0.12.4`
itself ships with a verifiable provenance attestation, the resolved
tree under it picks up `ai@<whatever-satisfies-^6.0.0-today>`,
`partyserver@<whatever-satisfies-^0.5.0-today>`,
`zod@<whatever-satisfies-^4.0.0-today>`, and so on. Those tarballs
were published by Vercel, the partyserver maintainer, Colin McDonnell,
and dozens of others — none of whom we have verified, and most of
whom do not publish with trusted publishing today.

The shai-hulud worm specifically exploits this: it does not need to
compromise Cloudflare's pipeline to poison a Cloudflare-rooted install.
It only needs to compromise *one* maintainer somewhere in the
transitive graph, publish a patch-version bump that satisfies the
range a Cloudflare package declares, and wait for the next `npm
install`.

Therefore:

- **Transitives are always under the 72-hour default embargo**, even
  when their parent direct dep has a lift.
- A lifted direct package only protects you against poisoning of *that
  exact tarball*. Everything underneath is still subject to the full
  audit checklist below.
- `npm ci` (lockfile-strict) is mandatory when installing — never
  `npm install`, which would re-resolve transitive ranges. The lock
  is the only place where transitive versions are pinned exactly.

### Current per-publisher policy

All lifted rows below share the same GitHub org ID `314135`
(Cloudflare) and the same `github-hosted` runner — the differentiator
between rows is the source repository and workflow file, which is
what the per-package provenance attestation binds to.

| Direct package | Embargo | Source repo (`repository_id`) | Workflow / ref | Verified on | Attestation |
|---|---|---|---|---|---|
| `@cloudflare/workers-types` | **Lifted** | [cloudflare/workerd](https://github.com/cloudflare/workerd) (`537085161`) | `.github/workflows/release.yml` @ `refs/heads/main` | 2026-05-16 | [link](https://registry.npmjs.org/-/npm/v1/attestations/@cloudflare%2fworkers-types@4.20260516.1) |
| `@cloudflare/dynamic-workflows` | **Lifted** | [cloudflare/dynamic-workflows](https://github.com/cloudflare/dynamic-workflows) | (sibling lift via cloudflare org) | 2026-05-16 | [link](https://registry.npmjs.org/-/npm/v1/attestations/@cloudflare%2fdynamic-workflows@0.1.1) |
| `agents` | **Lifted** | [cloudflare/agents](https://github.com/cloudflare/agents) (`924394244`) | `.github/workflows/release.yml` @ `refs/heads/main` | 2026-05-16 | [link](https://registry.npmjs.org/-/npm/v1/attestations/agents@0.12.4) |
| `@cloudflare/ai-chat` | **Lifted** (sibling of `agents`) | same as `agents` | same | 2026-05-16 | [link](https://registry.npmjs.org/-/npm/v1/attestations/@cloudflare%2fai-chat@0.7.0) |
| `@cloudflare/voice` | **Lifted** (sibling of `agents`) | same as `agents` | same | 2026-05-16 | [link](https://registry.npmjs.org/-/npm/v1/attestations/@cloudflare%2fvoice@0.2.0) |
| `@cloudflare/think` | **Lifted** (sibling of `agents`) | same as `agents` | same | 2026-05-16 | [link](https://registry.npmjs.org/-/npm/v1/attestations/@cloudflare%2fthink@0.6.1) |
| `@cloudflare/codemode` | **Lifted** (sibling of `agents`) | same as `agents` | same | 2026-05-16 | [link](https://registry.npmjs.org/-/npm/v1/attestations/@cloudflare%2fcodemode@0.3.6) |
| `@cloudflare/shell` | **Lifted** (sibling of `agents`) | same as `agents` | same | 2026-05-16 | [link](https://registry.npmjs.org/-/npm/v1/attestations/@cloudflare%2fshell@0.3.7) |
| `@cloudflare/worker-bundler` | **Lifted** (sibling of `agents`) | same as `agents` | same | 2026-05-16 | [link](https://registry.npmjs.org/-/npm/v1/attestations/@cloudflare%2fworker-bundler@0.1.3) |
| `@cloudflare/containers` | **Lifted** | [cloudflare/containers](https://github.com/cloudflare/containers) (`972331185`) | `.github/workflows/changesets.yml` @ `refs/heads/main` | 2026-05-16 | [link](https://registry.npmjs.org/-/npm/v1/attestations/@cloudflare%2fcontainers@0.3.4) |
| `@cloudflare/sandbox` | **Lifted** | [cloudflare/sandbox-sdk](https://github.com/cloudflare/sandbox-sdk) (`100660808`) | `.github/workflows/release.yml` @ `refs/heads/main` | 2026-05-16 | [link](https://registry.npmjs.org/-/npm/v1/attestations/@cloudflare%2fsandbox@0.10.1) |
| `@cloudflare/puppeteer` | **72 h (default)** | [cloudflare/puppeteer](https://github.com/cloudflare/puppeteer) | **No provenance attestation found** | 2026-05-16 | n/a — attestation endpoint returns 404. Audit-only treatment; scope unchanged — puppeteer is the Workers Browser-Rendering surface and is load-bearing for agentic info-gathering on the open web |
| `cloudflare` (unscoped) | Excluded from ingestion | — | — | — | Excluded because the same REST endpoints are already covered by the Hawaii-generated Management tier (`Fidelity.CloudEdge.Management.*`). Carrying a parallel xantham binding would double maintenance for zero new capability |
| `hono-agents` | Excluded from ingestion | — | — | — | Excluded because Fidelity has its own F#-native web framework occupying the same conceptual slot as Hono; the Hono integration layer carries no value into the F# surface |
| All transitive publishers | **72 h (default)** | n/a | n/a | n/a | Transitives are never lifted — see "Why transitives never qualify" above |

All lifts are contingent on the per-row provenance fields remaining
true at re-verification. If a future release of any lifted package
omits `attestations.provenance`, names a different
`repository_owner_id`, points to a self-hosted runner, or moves to an
unexpected ref, the embargo snaps back to the default for that row and
must be reset to "Not yet verified" pending fresh evidence.

`@cloudflare/puppeteer` is **deliberately not lifted**. The package is
Cloudflare-published and the source repo is `cloudflare/puppeteer`, so
on a name basis it would qualify, but the npm registry attestation
endpoint returns 404 for current releases — meaning the publisher
hasn't enabled npm trusted-publishing yet. It must be audited under the
full default policy on every bump until that changes. This is an audit
treatment, **not** a scoping decision — puppeteer is the
Workers Browser-Rendering surface, the same capability class
Cloudflare uses in their own site-crawler topology, and a load-bearing
primitive for agentic information-gathering on the open web. Its
substantive role in the intelligent-edge surface is on par with the
other agents-stack SDKs.

## Ingestion scope

The xantham generator targets the following Cloudflare SDKs, intended
as the full surface the F# bindings cover. Packages in the **Ingest**
column have a corresponding `output/<name>.json` and `output/<name>.fs`
artifact pair in [generators/xantham/output/](../generators/xantham/output).

| SDK | Latest | Lift status | Ingest |
|---|---|---|---|
| `@cloudflare/workers-types` | 4.20260516.1 | Lifted | ✅ Existing |
| `@cloudflare/dynamic-workflows` | 0.1.1 | Lifted | ✅ Existing |
| `agents` | 0.12.4 | Lifted | ✅ Existing |
| `@cloudflare/ai-chat` | 0.7.0 | Lifted | 🆕 Pending first regen |
| `@cloudflare/voice` | 0.2.0 | Lifted | 🆕 Pending first regen |
| `@cloudflare/think` | 0.6.1 | Lifted | 🆕 Pending first regen |
| `@cloudflare/codemode` | 0.3.6 | Lifted | 🆕 Pending first regen |
| `@cloudflare/shell` | 0.3.7 | Lifted | 🆕 Pending first regen |
| `@cloudflare/worker-bundler` | 0.1.3 | Lifted | 🆕 Pending first regen |
| `@cloudflare/containers` | 0.3.4 | Lifted | 🆕 Pending first regen |
| `@cloudflare/sandbox` | 0.10.1 | Lifted | 🆕 Pending first regen |
| `@cloudflare/puppeteer` | 1.1.0 | **72 h default** | 🆕 Pending first regen — full audit required, no shortcut |
| `cloudflare` (unscoped) | 6.2.0 | — | ✗ Out of scope — same REST endpoints already covered by Hawaii Management tier |
| `hono-agents` | 3.0.11 | — | ✗ Out of scope — Fidelity provides an in-tree F#-native Hono peer |

**React is out of scope for this project's binding surface.** Both
`@cloudflare/ai-chat` and `@cloudflare/voice` declare `react@^19` and
`@ai-sdk/react@^3` as peer dependencies, but this project targets
signals-based / SolidJS-style fine-grained reactivity, not React's
hooks + vDOM model. The two npm packages each ship both
framework-agnostic exports (`VoiceClient`, server mixins like
`withVoice`/`withVoiceInput`, core chat functions) and React-specific
exports (hooks like `useVoiceAgent`, React component wrappers). The
generator should filter the React-namespaced type graph at the
`IgnorePathRender` layer (see
[Driver.fsproj's GeneratorContext wiring](../generators/xantham/Program.fs))
so the F# output exposes only the framework-agnostic core.

This is an architectural decision, not a size optimization: surfacing
React types in F# would bake in a reactivity model the project has
deliberately rejected, and would mislead downstream F# consumers about
the recommended composition path.

## Reference: known-clean baseline (as of 2026-05-16)

Transitive table is incomplete until first regen of the expanded
ingestion set — the new packages bring transitives we have not
previously audited (notable additions: `acorn`, `isomorphic-git`,
`esbuild-wasm`, `sucrase`, `@typescript/vfs`, `typescript@^6`,
`@ai-sdk/react`, `react@^19`, `partysocket`, `chromium-bidi`,
`devtools-protocol`, `@puppeteer/browsers`, `ws`). Each must pass the
audit checklist before the first lockfile is committed.

| Package | Pinned | Latest | Audit status |
|---|---|---|---|
| `@cloudflare/workers-types` | 4.20260505.1 | 4.20260516.1 | Clean — daily date-stamped releases, no advisory hits |
| `@cloudflare/dynamic-workflows` | 0.1.1 | 0.1.1 | Clean |
| `agents` | 0.12.3 | 0.12.4 | Clean; `0.12.4` published 2026-05-13 (past quarantine window as of audit date) |
| `ai` (transitive) | 6.0.175 | 6.0.184 | Clean |
| `@ai-sdk/gateway` (transitive) | 3.0.110 | 3.0.115 | Clean |
| `partyserver` (transitive) | 0.5.5 | 0.5.6 | Clean |
| `zod` (transitive) | 4.4.3 | 4.4.3 | Clean |
| `@modelcontextprotocol/sdk` (transitive) | 1.29.0 | 1.29.0 | Clean |

This table is a point-in-time snapshot. Re-derive it each audit — do
not trust it past the date in the header.
