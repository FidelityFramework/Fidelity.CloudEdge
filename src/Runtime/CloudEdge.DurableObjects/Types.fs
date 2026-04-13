namespace Fidelity.CloudEdge.DurableObjects

open Fable.Core
open Fable.Core.JsInterop
open Fidelity.CloudEdge.Worker.Context
open System

/// Service binding for fetch-capable Workers (egress proxies, service bindings).
/// Worker.Context.Fetcher<'T> carries an Rpc.EntrypointBranded constraint that
/// does not apply to egress proxy and container bindings. This type provides
/// the same fetch surface without the RPC brand constraint.
[<AllowNullLiteral>]
[<Interface>]
type ServiceBinding =
    /// Fetch with a Request object
    abstract member fetch: request: Request -> JS.Promise<Response>

    /// Fetch with a URL string
    abstract member fetch: url: string -> JS.Promise<Response>

/// Durable Object ID
[<AllowNullLiteral>]
[<Interface>]
type DurableObjectId =
    /// String representation of the ID
    abstract member toString: unit -> string

    /// Name if created from name
    abstract member name: string option with get

/// Options for creating unique IDs
[<AllowNullLiteral>]
type DurableObjectNamespaceNewUniqueIdOptions =
    abstract member jurisdiction: string option with get, set

/// Options for getting Durable Object stubs
[<AllowNullLiteral>]
type DurableObjectNamespaceGetDurableObjectOptions =
    abstract member locationHint: string option with get, set

/// Durable Object stub for making requests
[<AllowNullLiteral>]
[<Interface>]
type DurableObjectStub =
    /// The Durable Object's ID
    abstract member id: DurableObjectId with get

    /// Name of the Durable Object (optional)
    abstract member name: string option with get

    /// Send a fetch request to the Durable Object
    abstract member fetch: request: Request -> JS.Promise<Response>

    /// Send a fetch with string URL
    abstract member fetch: url: string * ?init: obj -> JS.Promise<Response>

/// Durable Object namespace for creating and accessing objects
[<AllowNullLiteral>]
[<Interface>]
type DurableObjectNamespace =
    /// Create a new unique ID
    abstract member newUniqueId: ?options: DurableObjectNamespaceNewUniqueIdOptions -> DurableObjectId

    /// Get ID from a name
    abstract member idFromName: name: string -> DurableObjectId

    /// Get ID from a string representation
    abstract member idFromString: id: string -> DurableObjectId

    /// Get a Durable Object stub
    abstract member get: id: DurableObjectId * ?options: DurableObjectNamespaceGetDurableObjectOptions -> DurableObjectStub

/// WebSocket for Durable Objects
[<AllowNullLiteral>]
[<Interface>]
type WebSocket =
    /// Accept the WebSocket connection
    abstract member accept: unit -> unit

    /// Send a message
    abstract member send: message: string -> unit

    /// Send binary data
    abstract member send: message: JS.ArrayBuffer -> unit

    /// Close the WebSocket
    abstract member close: ?code: int * ?reason: string -> unit

    /// Ready state
    abstract member readyState: int with get

    /// URL of the WebSocket
    abstract member url: string with get

    /// Protocol
    abstract member protocol: string with get

    /// Extensions
    abstract member extensions: string with get

/// Options for listing storage
[<AllowNullLiteral>]
[<Interface>]
type DurableObjectListOptions =
    abstract member start: string option with get, set
    abstract member startAfter: string option with get, set
    abstract member ``end``: string option with get, set
    abstract member prefix: string option with get, set
    abstract member reverse: bool option with get, set
    abstract member limit: int option with get, set
    abstract member allowConcurrency: bool option with get, set
    abstract member noCache: bool option with get, set

/// Options for get operations
[<AllowNullLiteral>]
[<Interface>]
type DurableObjectGetOptions =
    abstract member allowConcurrency: bool option with get, set
    abstract member noCache: bool option with get, set

/// Options for put operations
[<AllowNullLiteral>]
[<Interface>]
type DurableObjectPutOptions =
    abstract member allowConcurrency: bool option with get, set
    abstract member allowUnconfirmed: bool option with get, set
    abstract member noCache: bool option with get, set

/// Durable Object storage API
[<AllowNullLiteral>]
[<Interface>]
type DurableObjectStorage =
    /// Get a value from storage
    abstract member get<'T> : key: string -> JS.Promise<'T option>

    /// Get multiple values from storage
    abstract member get<'T> : keys: ResizeArray<string> -> JS.Promise<Map<string, 'T>>

    /// Put a value in storage
    abstract member put<'T> : key: string * value: 'T -> JS.Promise<unit>

    /// Put multiple values in storage
    abstract member put<'T> : entries: Map<string, 'T> -> JS.Promise<unit>

    /// Delete a value from storage
    abstract member delete: key: string -> JS.Promise<bool>

    /// Delete multiple values from storage
    abstract member delete: keys: ResizeArray<string> -> JS.Promise<float>

    /// Delete all values from storage
    abstract member deleteAll: unit -> JS.Promise<unit>

    /// List keys in storage
    abstract member list<'T> : ?options: DurableObjectListOptions -> JS.Promise<Map<string, 'T>>

    /// Get alarm time
    abstract member getAlarm: unit -> JS.Promise<float option>

    /// Set alarm time
    abstract member setAlarm: scheduledTime: float -> JS.Promise<unit>

    /// Delete alarm
    abstract member deleteAlarm: unit -> JS.Promise<unit>

    /// Synchronize changes to disk
    abstract member sync: unit -> JS.Promise<unit>

    /// Start a transaction
    abstract member transaction<'T> : closure: (DurableObjectTransaction -> JS.Promise<'T>) -> JS.Promise<'T>

/// Transaction for atomic operations
and [<AllowNullLiteral>] [<Interface>] DurableObjectTransaction =
    inherit DurableObjectStorage
    /// Rollback the transaction
    abstract member rollback: unit -> unit

/// Durable Object state
[<AllowNullLiteral>]
[<Interface>]
type DurableObjectState<'Props> =
    /// The Durable Object's ID
    abstract member id: DurableObjectId with get

    /// Storage API
    abstract member storage: DurableObjectStorage with get

    /// Block until all concurrent requests complete
    abstract member blockConcurrencyWhile: fn: (unit -> JS.Promise<unit>) -> JS.Promise<unit>

    /// Accept WebSocket connections
    abstract member acceptWebSocket: ws: WebSocket * ?tags: ResizeArray<string> -> unit

    /// Get WebSockets with specified tag
    abstract member getWebSockets: ?tag: string -> ResizeArray<WebSocket>

    /// Abort all Durable Object requests
    abstract member abort: ?reason: string -> unit

/// Base Durable Object interface
[<AllowNullLiteral>]
[<Interface>]
type DurableObject =
    /// Handle fetch requests
    abstract member fetch: request: Request -> U2<Response, JS.Promise<Response>>

    /// Handle alarm triggers (optional)
    abstract member alarm: unit -> JS.Promise<unit>

    /// Handle WebSocket messages (optional)
    abstract member webSocketMessage: ws: WebSocket * message: string -> JS.Promise<unit>

    /// Handle WebSocket close (optional)
    abstract member webSocketClose: ws: WebSocket * code: int * reason: string * wasClean: bool -> JS.Promise<unit>

    /// Handle WebSocket errors (optional)
    abstract member webSocketError: ws: WebSocket * error: obj -> JS.Promise<unit>

/// Options for starting a facet (dynamic Durable Object)
[<AllowNullLiteral>]
[<Interface>]
type FacetStartupOptions<'T> =
    /// Optional ID for the facet instance
    abstract member id: U2<DurableObjectId, string> option with get, set

    /// The Durable Object class to instantiate
    abstract member ``class``: obj with get, set

/// Durable Object Facets — dynamic DO instantiation from within a DO
[<AllowNullLiteral>]
[<Interface>]
type DurableObjectFacets =
    /// Create or retrieve a named facet with startup options
    abstract member get: name: string * getStartupOptions: (unit -> JS.Promise<FacetStartupOptions<'T>>) -> ServiceBinding

    /// Abort a running facet by name
    abstract member abort: name: string * reason: obj -> unit

    /// Delete a facet by name
    abstract member delete: name: string -> unit

/// Container directory snapshot
[<AllowNullLiteral>]
[<Interface>]
type ContainerDirectorySnapshot =
    /// Snapshot ID
    abstract member id: string with get

    /// Size in bytes
    abstract member size: float with get

    /// Directory that was snapshotted
    abstract member dir: string with get

    /// Optional name for the snapshot
    abstract member name: string option with get

/// Options for directory snapshots
[<AllowNullLiteral>]
[<Interface>]
type ContainerDirectorySnapshotOptions =
    /// Directory to snapshot
    abstract member dir: string with get, set

    /// Optional name for the snapshot
    abstract member name: string option with get, set

/// Restore parameters for directory snapshots
[<AllowNullLiteral>]
[<Interface>]
type ContainerDirectorySnapshotRestoreParams =
    /// The snapshot to restore
    abstract member snapshot: ContainerDirectorySnapshot with get, set

    /// Optional mount point (defaults to original directory)
    abstract member mountPoint: string option with get, set

/// Container snapshot (full container state)
[<AllowNullLiteral>]
[<Interface>]
type ContainerSnapshot =
    /// Snapshot ID
    abstract member id: string with get

    /// Size in bytes
    abstract member size: float with get

/// Options for container snapshots
[<AllowNullLiteral>]
[<Interface>]
type ContainerSnapshotOptions =
    /// Optional name for the snapshot
    abstract member name: string option with get, set

/// Container startup options with egress control
[<AllowNullLiteral>]
[<Interface>]
type ContainerStartupOptions =
    /// Entrypoint command override
    abstract member entrypoint: string[] option with get, set

    /// Whether the container can access the internet
    abstract member enableInternet: bool with get, set

    /// Environment variables
    abstract member env: obj option with get, set

    /// Labels for the container
    abstract member labels: obj option with get, set

    /// Directory snapshots to restore on startup
    abstract member directorySnapshots: ContainerDirectorySnapshotRestoreParams[] option with get, set

    /// Container snapshot to restore on startup
    abstract member containerSnapshot: ContainerSnapshot option with get, set

/// Container instance with egress interception
[<AllowNullLiteral>]
[<Interface>]
type Container =
    /// Start the container
    abstract member start: ?options: ContainerStartupOptions -> unit

    /// Get a TCP port binding
    abstract member getTcpPort: port: int -> ServiceBinding

    /// Set inactivity timeout in milliseconds
    abstract member setInactivityTimeout: durationMs: float -> JS.Promise<unit>

    /// Intercept outbound HTTP to a specific address via a proxy Worker
    abstract member interceptOutboundHttp: addr: string * binding: ServiceBinding -> JS.Promise<unit>

    /// Intercept all outbound HTTP via a proxy Worker
    abstract member interceptAllOutboundHttp: binding: ServiceBinding -> JS.Promise<unit>

    /// Intercept outbound HTTPS to a specific address via a proxy Worker
    abstract member interceptOutboundHttps: addr: string * binding: ServiceBinding -> JS.Promise<unit>

    /// Snapshot a directory within the container
    abstract member snapshotDirectory: options: ContainerDirectorySnapshotOptions -> JS.Promise<ContainerDirectorySnapshot>

    /// Snapshot the entire container state
    abstract member snapshotContainer: options: ContainerSnapshotOptions -> JS.Promise<ContainerSnapshot>

/// Environment with Durable Object bindings
[<AllowNullLiteral>]
type IDurableObjectEnvironment =
    /// Access a Durable Object namespace binding by name
    [<Emit("$0[$1]")>]
    abstract member getDurableObjectNamespace: name: string -> DurableObjectNamespace