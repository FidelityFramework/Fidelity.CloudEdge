namespace rec Fidelity.CloudEdge.Management.EventSubscriptions.Types

// Auto-generated stub types (missing from Hawaii output)
type source = string

type ``mqapi-v4-errorArrayItem`` =
    { code: int
      message: string }
    ///Creates an instance of mqapi-v4-errorArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``mqapi-v4-errorArrayItem`` = { code = code; message = message }

type ``mqapi-v4-error`` = list<``mqapi-v4-errorArrayItem``>
type ``mqapi-v4-message`` = list<string>
///A Resource identifier.
type mqidentifier = string

type Errors =
    { code: int
      message: string }
    ///Creates an instance of Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Errors = { code = code; message = message }

type ``mqapi-v4-failure`` =
    { errors: Option<list<Errors>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool> }
    ///Creates an instance of mqapi-v4-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqapi-v4-failure`` =
        { errors = None
          messages = None
          success = None }

type ``mqapi-v4-successErrors`` =
    { code: int
      message: string }
    ///Creates an instance of mqapi-v4-successErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``mqapi-v4-successErrors`` = { code = code; message = message }

type ``mqapi-v4-success`` =
    { errors: Option<list<``mqapi-v4-successErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool> }
    ///Creates an instance of mqapi-v4-success with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqapi-v4-success`` =
        { errors = None
          messages = None
          success = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "queues.queue">] QueuesQueue
    member this.Format() =
        match this with
        | QueuesQueue -> "queues.queue"

type ``mqevent-destination`` =
    { ///ID of the target queue
      queue_id: string
      ///Type of destination
      ``type``: Type }
    ///Creates an instance of mqevent-destination with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (queue_id: string, ``type``: Type): ``mqevent-destination`` =
        { queue_id = queue_id
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``mqevent-destination-queueType`` =
    | [<CompiledName "queues.queue">] QueuesQueue
    member this.Format() =
        match this with
        | QueuesQueue -> "queues.queue"

type ``mqevent-destination-queue`` =
    { ///ID of the target queue
      queue_id: string
      ///Type of destination
      ``type``: ``mqevent-destination-queueType`` }
    ///Creates an instance of mqevent-destination-queue with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (queue_id: string, ``type``: ``mqevent-destination-queueType``): ``mqevent-destination-queue`` =
        { queue_id = queue_id
          ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``mqevent-source-imagesType`` =
    | [<CompiledName "images">] Images
    member this.Format() =
        match this with
        | Images -> "images"

type ``mqevent-source-images`` =
    { ///Type of source
      ``type``: Option<``mqevent-source-imagesType``> }
    ///Creates an instance of mqevent-source-images with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqevent-source-images`` = { ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``mqevent-source-kvType`` =
    | [<CompiledName "kv">] Kv
    member this.Format() =
        match this with
        | Kv -> "kv"

type ``mqevent-source-kv`` =
    { ///Type of source
      ``type``: Option<``mqevent-source-kvType``> }
    ///Creates an instance of mqevent-source-kv with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqevent-source-kv`` = { ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``mqevent-source-r2Type`` =
    | [<CompiledName "r2">] R2
    member this.Format() =
        match this with
        | R2 -> "r2"

type ``mqevent-source-r2`` =
    { ///Type of source
      ``type``: Option<``mqevent-source-r2Type``> }
    ///Creates an instance of mqevent-source-r2 with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqevent-source-r2`` = { ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``mqevent-source-super-slurperType`` =
    | [<CompiledName "superSlurper">] SuperSlurper
    member this.Format() =
        match this with
        | SuperSlurper -> "superSlurper"

type ``mqevent-source-super-slurper`` =
    { ///Type of source
      ``type``: Option<``mqevent-source-super-slurperType``> }
    ///Creates an instance of mqevent-source-super-slurper with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqevent-source-super-slurper`` = { ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``mqevent-source-vectorizeType`` =
    | [<CompiledName "vectorize">] Vectorize
    member this.Format() =
        match this with
        | Vectorize -> "vectorize"

type ``mqevent-source-vectorize`` =
    { ///Type of source
      ``type``: Option<``mqevent-source-vectorizeType``> }
    ///Creates an instance of mqevent-source-vectorize with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqevent-source-vectorize`` = { ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``mqevent-source-workers-ai-modelType`` =
    | [<CompiledName "workersAi.model">] WorkersAiModel
    member this.Format() =
        match this with
        | WorkersAiModel -> "workersAi.model"

type ``mqevent-source-workers-ai-model`` =
    { ///Name of the Workers AI model
      model_name: Option<string>
      ///Type of source
      ``type``: Option<``mqevent-source-workers-ai-modelType``> }
    ///Creates an instance of mqevent-source-workers-ai-model with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqevent-source-workers-ai-model`` = { model_name = None; ``type`` = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``mqevent-source-workers-builds-workerType`` =
    | [<CompiledName "workersBuilds.worker">] WorkersBuildsWorker
    member this.Format() =
        match this with
        | WorkersBuildsWorker -> "workersBuilds.worker"

type ``mqevent-source-workers-builds-worker`` =
    { ///Type of source
      ``type``: Option<``mqevent-source-workers-builds-workerType``>
      ///Name of the worker
      worker_name: Option<string> }
    ///Creates an instance of mqevent-source-workers-builds-worker with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqevent-source-workers-builds-worker`` = { ``type`` = None; worker_name = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``mqevent-source-workflows-workflowType`` =
    | [<CompiledName "workflows.workflow">] WorkflowsWorkflow
    member this.Format() =
        match this with
        | WorkflowsWorkflow -> "workflows.workflow"

type ``mqevent-source-workflows-workflow`` =
    { ///Type of source
      ``type``: Option<``mqevent-source-workflows-workflowType``>
      ///Name of the workflow
      workflow_name: Option<string> }
    ///Creates an instance of mqevent-source-workflows-workflow with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``mqevent-source-workflows-workflow`` =
        { ``type`` = None
          workflow_name = None }

type ``mqevent-subscription`` =
    { ///When the subscription was created
      created_at: System.DateTimeOffset
      destination: ``mqevent-destination-queue``
      ///Whether the subscription is active
      enabled: bool
      ///List of event types this subscription handles
      events: list<string>
      ///Unique identifier for the subscription
      id: string
      ///When the subscription was last modified
      modified_at: System.DateTimeOffset
      ///Name of the subscription
      name: string
      ///Source configuration for the subscription
      source: Newtonsoft.Json.Linq.JObject }
    ///Creates an instance of mqevent-subscription with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (created_at: System.DateTimeOffset,
                          destination: ``mqevent-destination-queue``,
                          enabled: bool,
                          events: list<string>,
                          id: string,
                          modified_at: System.DateTimeOffset,
                          name: string,
                          source: Newtonsoft.Json.Linq.JObject): ``mqevent-subscription`` =
        { created_at = created_at
          destination = destination
          enabled = enabled
          events = events
          id = id
          modified_at = modified_at
          name = name
          source = source }

type ``subscriptions-listresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of subscriptions-listresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``subscriptions-listresponseErrors`` =
        { code = code; message = message }

type Resultinfo =
    { ///Number of items in current page
      count: int
      ///Current page number
      page: int
      ///Items per page
      per_page: int
      ///Total number of items
      total_count: int
      ///Total number of pages
      total_pages: int }
    ///Creates an instance of Resultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: int, page: int, per_page: int, total_count: int, total_pages: int): Resultinfo =
        { count = count
          page = page
          per_page = per_page
          total_count = total_count
          total_pages = total_pages }

type ``subscriptions-listresponse`` =
    { errors: Option<list<``subscriptions-listresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      result: Option<list<``mqevent-subscription``>>
      result_info: Option<Resultinfo> }
    ///Creates an instance of subscriptions-listresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``subscriptions-listresponse`` =
        { errors = None
          messages = None
          success = None
          result = None
          result_info = None }

type ``subscriptions-createresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of subscriptions-createresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``subscriptions-createresponseErrors`` =
        { code = code; message = message }

type ``subscriptions-createresponse`` =
    { errors: Option<list<``subscriptions-createresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      result: Option<``mqevent-subscription``> }
    ///Creates an instance of subscriptions-createresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``subscriptions-createresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``subscriptions-deleteresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of subscriptions-deleteresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``subscriptions-deleteresponseErrors`` =
        { code = code; message = message }

type ``subscriptions-deleteresponse`` =
    { errors: Option<list<``subscriptions-deleteresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      result: Option<``mqevent-subscription``> }
    ///Creates an instance of subscriptions-deleteresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``subscriptions-deleteresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``subscriptions-getresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of subscriptions-getresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``subscriptions-getresponseErrors`` =
        { code = code; message = message }

type ``subscriptions-getresponse`` =
    { errors: Option<list<``subscriptions-getresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      result: Option<``mqevent-subscription``> }
    ///Creates an instance of subscriptions-getresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``subscriptions-getresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

type ``subscriptions-patchresponseErrors`` =
    { code: int
      message: string }
    ///Creates an instance of subscriptions-patchresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``subscriptions-patchresponseErrors`` =
        { code = code; message = message }

type ``subscriptions-patchresponse`` =
    { errors: Option<list<``subscriptions-patchresponseErrors``>>
      messages: Option<``mqapi-v4-message``>
      ///Indicates if the API call was successful or not.
      success: Option<bool>
      result: Option<``mqevent-subscription``> }
    ///Creates an instance of subscriptions-patchresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``subscriptions-patchresponse`` =
        { errors = None
          messages = None
          success = None
          result = None }

[<RequireQualifiedAccess>]
type SubscriptionsList =
    ///List of event subscriptions
    | OK of payload: ``subscriptions-listresponse``
    ///Failure response
    | BadRequest of payload: ``mqapi-v4-failure``

type SubscriptionsCreatePayload =
    { destination: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the subscription is active
      enabled: Option<bool>
      ///List of event types this subscription handles
      events: Option<list<string>>
      ///Name of the subscription
      name: Option<string>
      ///Source configuration for the subscription
      source: Option<Newtonsoft.Json.Linq.JObject> }
    ///Creates an instance of SubscriptionsCreatePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): SubscriptionsCreatePayload =
        { destination = None
          enabled = None
          events = None
          name = None
          source = None }

[<RequireQualifiedAccess>]
type SubscriptionsCreate =
    ///Successfully created event subscription
    | OK of payload: ``subscriptions-createresponse``
    ///Invalid request body or validation errors
    | BadRequest of payload: ``mqapi-v4-failure``
    ///Queue does not exist or resource not found on source
    | NotFound of payload: ``mqapi-v4-failure``
    ///Multiple subscriptions on same resource not supported
    | MethodNotAllowed of payload: ``mqapi-v4-failure``

[<RequireQualifiedAccess>]
type SubscriptionsDelete =
    ///Successfully created event subscription
    | OK of payload: ``subscriptions-deleteresponse``

[<RequireQualifiedAccess>]
type SubscriptionsGet =
    ///Details about an event subscription
    | OK of payload: ``subscriptions-getresponse``
    ///Event subscription does not exist
    | NotFound of payload: ``mqapi-v4-failure``

type SubscriptionsPatchPayload =
    { destination: Option<Newtonsoft.Json.Linq.JToken>
      ///Whether the subscription is active
      enabled: Option<bool>
      ///List of event types this subscription handles
      events: Option<list<string>>
      ///Name of the subscription
      name: Option<string> }
    ///Creates an instance of SubscriptionsPatchPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): SubscriptionsPatchPayload =
        { destination = None
          enabled = None
          events = None
          name = None }

[<RequireQualifiedAccess>]
type SubscriptionsPatch =
    ///Successfully created event subscription
    | OK of payload: ``subscriptions-patchresponse``
    ///Invalid request body or validation errors
    | BadRequest of payload: ``mqapi-v4-failure``
    ///Queue does not exist or resource not found on source
    | NotFound of payload: ``mqapi-v4-failure``
