namespace rec Fidelity.CloudEdge.Management.EventNotifications.Types

// Auto-generated stub types (missing from Hawaii output)
type rule = string
type rules = string

///Account ID.
type r2accountidentifier = string
///Name of the bucket.
type r2bucketname = string

type r2errorsArrayItem =
    { code: int
      message: string }
    ///Creates an instance of r2errorsArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): r2errorsArrayItem = { code = code; message = message }

type r2errors = list<r2errorsArrayItem>

///Jurisdiction where objects in this bucket are guaranteed to be stored.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type r2jurisdiction =
    | [<CompiledName "default">] Default
    | [<CompiledName "eu">] Eu
    | [<CompiledName "fedramp">] Fedramp
    member this.Format() =
        match this with
        | Default -> "default"
        | Eu -> "eu"
        | Fedramp -> "fedramp"

type r2messages = list<string>
///Queue ID.
type r2queueidentifier = string

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``r2r2-action`` =
    | [<CompiledName "PutObject">] PutObject
    | [<CompiledName "CopyObject">] CopyObject
    | [<CompiledName "DeleteObject">] DeleteObject
    | [<CompiledName "CompleteMultipartUpload">] CompleteMultipartUpload
    | [<CompiledName "LifecycleDeletion">] LifecycleDeletion
    member this.Format() =
        match this with
        | PutObject -> "PutObject"
        | CopyObject -> "CopyObject"
        | DeleteObject -> "DeleteObject"
        | CompleteMultipartUpload -> "CompleteMultipartUpload"
        | LifecycleDeletion -> "LifecycleDeletion"

type ``r2bucket-config`` =
    { ///Name of the bucket.
      bucketName: Option<string>
      ///List of queues associated with the bucket.
      queues: Option<list<``r2queues-config``>> }
    ///Creates an instance of r2bucket-config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2bucket-config`` = { bucketName = None; queues = None }

type ``r2queues-config`` =
    { ///Queue ID.
      queueId: Option<string>
      ///Name of the queue.
      queueName: Option<string>
      rules: Option<list<string>> }
    ///Creates an instance of r2queues-config with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``r2queues-config`` =
        { queueId = None
          queueName = None
          rules = None }

type r2rule =
    { ///Array of R2 object actions that will trigger notifications.
      actions: list<``r2r2-action``>
      ///A description that can be used to identify the event notification rule after creation.
      description: Option<string>
      ///Notifications will be sent only for objects with this prefix.
      prefix: Option<string>
      ///Notifications will be sent only for objects with this suffix.
      suffix: Option<string> }
    ///Creates an instance of r2rule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (actions: list<``r2r2-action``>): r2rule =
        { actions = actions
          description = None
          prefix = None
          suffix = None }

type Errors =
    { code: int
      message: string }
    ///Creates an instance of Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Errors = { code = code; message = message }

type r2v4response =
    { errors: list<Errors>
      messages: r2messages
      result: Map<string, obj>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of r2v4response with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<Errors>,
                          messages: r2messages,
                          result: Map<string, obj>,
                          success: bool): r2v4response =
        { errors = errors
          messages = messages
          result = result
          success = success }

type r2v4responsefailureErrors =
    { code: int
      message: string }
    ///Creates an instance of r2v4responsefailureErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): r2v4responsefailureErrors = { code = code; message = message }

type r2v4responsefailure =
    { errors: list<r2v4responsefailureErrors>
      messages: r2messages
      result: obj
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of r2v4responsefailure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<r2v4responsefailureErrors>,
                          messages: r2messages,
                          result: obj,
                          success: bool): r2v4responsefailure =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``r2-get-event-notification-configsresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of r2-get-event-notification-configsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-get-event-notification-configsresponseErrors`` =
        { code = code; message = message }

type ``r2-get-event-notification-configsresponse`` =
    { errors: list<``r2-get-event-notification-configsresponseErrors``>
      messages: r2messages
      result: ``r2bucket-config``
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of r2-get-event-notification-configsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``r2-get-event-notification-configsresponseErrors``>,
                          messages: r2messages,
                          result: ``r2bucket-config``,
                          success: bool): ``r2-get-event-notification-configsresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``r2-event-notification-delete-configresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of r2-event-notification-delete-configresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-event-notification-delete-configresponseErrors`` =
        { code = code; message = message }

type ``r2-event-notification-delete-configresponse`` =
    { errors: list<``r2-event-notification-delete-configresponseErrors``>
      messages: r2messages
      result: Map<string, obj>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of r2-event-notification-delete-configresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``r2-event-notification-delete-configresponseErrors``>,
                          messages: r2messages,
                          result: Map<string, obj>,
                          success: bool): ``r2-event-notification-delete-configresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``r2-get-event-notification-configresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of r2-get-event-notification-configresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-get-event-notification-configresponseErrors`` =
        { code = code; message = message }

type ``r2-get-event-notification-configresponse`` =
    { errors: list<``r2-get-event-notification-configresponseErrors``>
      messages: r2messages
      result: ``r2queues-config``
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of r2-get-event-notification-configresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``r2-get-event-notification-configresponseErrors``>,
                          messages: r2messages,
                          result: ``r2queues-config``,
                          success: bool): ``r2-get-event-notification-configresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``r2-put-event-notification-configresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of r2-put-event-notification-configresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``r2-put-event-notification-configresponseErrors`` =
        { code = code; message = message }

type ``r2-put-event-notification-configresponse`` =
    { errors: list<``r2-put-event-notification-configresponseErrors``>
      messages: r2messages
      result: Map<string, obj>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of r2-put-event-notification-configresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``r2-put-event-notification-configresponseErrors``>,
                          messages: r2messages,
                          result: Map<string, obj>,
                          success: bool): ``r2-put-event-notification-configresponse`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

[<RequireQualifiedAccess>]
type R2GetEventNotificationConfigs =
    ///Read Configuration response.
    | OK of payload: ``r2-get-event-notification-configsresponse``
    ///No Configuration Found response.
    | NotFound of payload: r2v4responsefailure
    ///Read Configuration failure.
    | BadRequest of payload: r2v4responsefailure

type R2EventNotificationDeleteConfigPayload =
    { ///Array of rule ids to delete.
      ruleIds: Option<list<string>> }
    ///Creates an instance of R2EventNotificationDeleteConfigPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): R2EventNotificationDeleteConfigPayload = { ruleIds = None }

[<RequireQualifiedAccess>]
type R2EventNotificationDeleteConfig =
    ///Delete Configuration response.
    | OK of payload: ``r2-event-notification-delete-configresponse``
    ///Delete Configuration failure.
    | BadRequest of payload: r2v4responsefailure

[<RequireQualifiedAccess>]
type R2GetEventNotificationConfig =
    ///Read Configuration response.
    | OK of payload: ``r2-get-event-notification-configresponse``
    ///No Configuration Found response.
    | NotFound of payload: r2v4responsefailure
    ///Read Configuration failure.
    | BadRequest of payload: r2v4responsefailure

type R2PutEventNotificationConfigPayload =
    { ///Array of rules to drive notifications.
      rules: list<r2rule> }
    ///Creates an instance of R2PutEventNotificationConfigPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (rules: list<r2rule>): R2PutEventNotificationConfigPayload = { rules = rules }

[<RequireQualifiedAccess>]
type R2PutEventNotificationConfig =
    ///Create Configuration response.
    | OK of payload: ``r2-put-event-notification-configresponse``
    ///Create Configuration failure.
    | BadRequest of payload: r2v4responsefailure
