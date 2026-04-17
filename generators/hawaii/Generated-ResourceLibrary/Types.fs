namespace rec Fidelity.CloudEdge.Management.ResourceLibrary.Types

// Auto-generated type aliases (Hawaii normalization fix)
type alexandria_application = alexandriaapplication
type alexandria_category = alexandriacategory

// Auto-generated stub types (missing from Hawaii output)
type results = string

type alexandriaapplicationconfidencescore = float32
///Returns the application creation time.
type alexandriaapplicationcreatedat = string
type alexandriaapplicationgenaiscore = float32
///Returns the list of hostnames for the application.
type alexandriaapplicationhostnames = list<string>
///Returns the human readable ID.
type alexandriaapplicationhumanid = string
///Returns the application ID.
type alexandriaapplicationid = string
type alexandriaapplicationintelid = int64
///Returns the list of IP subnets for the application.
type alexandriaapplicationipsubnets = list<string>
///Returns the application name.
type alexandriaapplicationname = string
///Returns the list of port protocols for the application.
type alexandriaapplicationportprotocols = list<string>
///Returns the application source.
type alexandriaapplicationsource = string
///Returns the list of support domains for the application.
type alexandriaapplicationsupportdomains = list<string>
///Returns the application type.
type alexandriaapplicationtype = string
///Returns the application type description.
type alexandriaapplicationtypedescription = string
///Returns the application update time.
type alexandriaapplicationupdatedat = string
///Returns the application version.
type alexandriaapplicationversion = string
type alexandriaapplications = list<alexandria_application>
type alexandriacategories = list<alexandria_category>
///Returns the category creation time.
type alexandriacategorycreatedat = string
///Returns the category description.
type alexandriacategorydescription = string
///Returns the category ID.
type alexandriacategoryid = string
///Returns the category name.
type alexandriacategoryname = string

type Source =
    { pointer: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source = { pointer = None }

type alexandriamessagesArrayItem =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<Source> }
    ///Creates an instance of alexandriamessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): alexandriamessagesArrayItem =
        { code = code
          documentation_url = None
          message = message
          source = None }

type alexandriamessages = list<alexandriamessagesArrayItem>

type ErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of ErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ErrorsSource = { pointer = None }

type Errors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<ErrorsSource> }
    ///Creates an instance of Errors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Errors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type MessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of MessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): MessagesSource = { pointer = None }

type Messages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<MessagesSource> }
    ///Creates an instance of Messages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): Messages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type Resultinfo =
    { ///Returns the total number of results for the requested service.
      count: Option<float>
      ///Returns the current page within paginated list of results.
      page: Option<float>
      ///Returns the number of results per page of results.
      per_page: Option<float>
      ///Returns the total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of Resultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Resultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``alexandriaapi-response-collection`` =
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      ///Indicates whether the API call was successful.
      success: Option<bool>
      result_info: Option<Resultinfo> }
    ///Creates an instance of alexandriaapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``alexandriaapi-response-collection`` =
        { errors = None
          messages = None
          success = None
          result_info = None }

type ``alexandriaapi-response-commonErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of alexandriaapi-response-commonErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``alexandriaapi-response-commonErrorsSource`` = { pointer = None }

type ``alexandriaapi-response-commonErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``alexandriaapi-response-commonErrorsSource``> }
    ///Creates an instance of alexandriaapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``alexandriaapi-response-commonErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``alexandriaapi-response-commonMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of alexandriaapi-response-commonMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``alexandriaapi-response-commonMessagesSource`` = { pointer = None }

type ``alexandriaapi-response-commonMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``alexandriaapi-response-commonMessagesSource``> }
    ///Creates an instance of alexandriaapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``alexandriaapi-response-commonMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``alexandriaapi-response-common`` =
    { errors: list<``alexandriaapi-response-commonErrors``>
      messages: list<``alexandriaapi-response-commonMessages``>
      ///Indicates whether the API call was successful.
      success: bool }
    ///Creates an instance of alexandriaapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``alexandriaapi-response-commonErrors``>,
                          messages: list<``alexandriaapi-response-commonMessages``>,
                          success: bool): ``alexandriaapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type alexandriaapiresponsecommonfailure =
    { errors: Newtonsoft.Json.Linq.JToken
      messages: Newtonsoft.Json.Linq.JToken
      result: Newtonsoft.Json.Linq.JObject
      ///Indicates whether the API call was successful.
      success: bool }
    ///Creates an instance of alexandriaapiresponsecommonfailure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: Newtonsoft.Json.Linq.JToken,
                          messages: Newtonsoft.Json.Linq.JToken,
                          result: Newtonsoft.Json.Linq.JObject,
                          success: bool): alexandriaapiresponsecommonfailure =
        { errors = errors
          messages = messages
          result = result
          success = success }

type alexandriaapplication =
    { ///Confidence score for the application. Returns -1 when no score is available.
      application_confidence_score: alexandriaapplicationconfidencescore
      ///Returns the score composition breakdown for the application.
      application_score_composition: Option<Newtonsoft.Json.Linq.JObject>
      ///Returns the application source.
      application_source: alexandriaapplicationsource
      ///Returns the application type.
      application_type: alexandriaapplicationtype
      ///Returns the application type description.
      application_type_description: alexandriaapplicationtypedescription
      ///Returns the application creation time.
      created_at: alexandriaapplicationcreatedat
      ///GenAI score for the application. Returns -1 when no score is available.
      gen_ai_score: alexandriaapplicationgenaiscore
      ///Returns the list of hostnames for the application.
      hostnames: alexandriaapplicationhostnames
      ///Returns the human readable ID.
      human_id: alexandriaapplicationhumanid
      ///Returns the application ID.
      id: alexandriaapplicationid
      ///Returns the Intel API ID for the application.
      intel_id: Option<alexandriaapplicationintelid>
      ///Returns the list of IP subnets for the application.
      ip_subnets: alexandriaapplicationipsubnets
      ///Returns the application name.
      name: alexandriaapplicationname
      ///Returns the list of port protocols for the application.
      port_protocols: alexandriaapplicationportprotocols
      ///Returns the list of support domains for the application.
      support_domains: alexandriaapplicationsupportdomains
      ///Returns the application update time.
      updated_at: alexandriaapplicationupdatedat
      ///Returns the application version.
      version: alexandriaapplicationversion }
    ///Creates an instance of alexandriaapplication with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (application_confidence_score: alexandriaapplicationconfidencescore,
                          application_source: alexandriaapplicationsource,
                          application_type: alexandriaapplicationtype,
                          application_type_description: alexandriaapplicationtypedescription,
                          created_at: alexandriaapplicationcreatedat,
                          gen_ai_score: alexandriaapplicationgenaiscore,
                          hostnames: alexandriaapplicationhostnames,
                          human_id: alexandriaapplicationhumanid,
                          id: alexandriaapplicationid,
                          ip_subnets: alexandriaapplicationipsubnets,
                          name: alexandriaapplicationname,
                          port_protocols: alexandriaapplicationportprotocols,
                          support_domains: alexandriaapplicationsupportdomains,
                          updated_at: alexandriaapplicationupdatedat,
                          version: alexandriaapplicationversion): alexandriaapplication =
        { application_confidence_score = application_confidence_score
          application_score_composition = None
          application_source = application_source
          application_type = application_type
          application_type_description = application_type_description
          created_at = created_at
          gen_ai_score = gen_ai_score
          hostnames = hostnames
          human_id = human_id
          id = id
          intel_id = None
          ip_subnets = ip_subnets
          name = name
          port_protocols = port_protocols
          support_domains = support_domains
          updated_at = updated_at
          version = version }

type alexandriacategory =
    { ///Returns the category creation time.
      created_at: alexandriacategorycreatedat
      ///Returns the category description.
      description: alexandriacategorydescription
      ///Returns the category ID.
      id: alexandriacategoryid
      ///Returns the category name.
      name: alexandriacategoryname }
    ///Creates an instance of alexandriacategory with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (created_at: alexandriacategorycreatedat,
                          description: alexandriacategorydescription,
                          id: alexandriacategoryid,
                          name: alexandriacategoryname): alexandriacategory =
        { created_at = created_at
          description = description
          id = id
          name = name }

type alexandriagetapplicationresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of alexandriagetapplicationresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): alexandriagetapplicationresponseErrorsSource = { pointer = None }

type alexandriagetapplicationresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<alexandriagetapplicationresponseErrorsSource> }
    ///Creates an instance of alexandriagetapplicationresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): alexandriagetapplicationresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type alexandriagetapplicationresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of alexandriagetapplicationresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): alexandriagetapplicationresponseMessagesSource = { pointer = None }

type alexandriagetapplicationresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<alexandriagetapplicationresponseMessagesSource> }
    ///Creates an instance of alexandriagetapplicationresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): alexandriagetapplicationresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type alexandriagetapplicationresponse =
    { errors: list<alexandriagetapplicationresponseErrors>
      messages: list<alexandriagetapplicationresponseMessages>
      ///Indicates whether the API call was successful.
      success: bool
      result: Option<alexandriaapplication> }
    ///Creates an instance of alexandriagetapplicationresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<alexandriagetapplicationresponseErrors>,
                          messages: list<alexandriagetapplicationresponseMessages>,
                          success: bool): alexandriagetapplicationresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type alexandriagetapplicationsresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of alexandriagetapplicationsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): alexandriagetapplicationsresponseErrorsSource = { pointer = None }

type alexandriagetapplicationsresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<alexandriagetapplicationsresponseErrorsSource> }
    ///Creates an instance of alexandriagetapplicationsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): alexandriagetapplicationsresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type alexandriagetapplicationsresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of alexandriagetapplicationsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): alexandriagetapplicationsresponseMessagesSource = { pointer = None }

type alexandriagetapplicationsresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<alexandriagetapplicationsresponseMessagesSource> }
    ///Creates an instance of alexandriagetapplicationsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): alexandriagetapplicationsresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type alexandriagetapplicationsresponseResultinfo =
    { ///Returns the total number of results for the requested service.
      count: Option<float>
      ///Returns the current page within paginated list of results.
      page: Option<float>
      ///Returns the number of results per page of results.
      per_page: Option<float>
      ///Returns the total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of alexandriagetapplicationsresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): alexandriagetapplicationsresponseResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type alexandriagetapplicationsresponse =
    { errors: list<alexandriagetapplicationsresponseErrors>
      messages: list<alexandriagetapplicationsresponseMessages>
      ///Indicates whether the API call was successful.
      success: bool
      result_info: Option<alexandriagetapplicationsresponseResultinfo>
      ///Returns the list of applications.
      result: Option<alexandriaapplications> }
    ///Creates an instance of alexandriagetapplicationsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<alexandriagetapplicationsresponseErrors>,
                          messages: list<alexandriagetapplicationsresponseMessages>,
                          success: bool): alexandriagetapplicationsresponse =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type alexandriagetcategoriesresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of alexandriagetcategoriesresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): alexandriagetcategoriesresponseErrorsSource = { pointer = None }

type alexandriagetcategoriesresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<alexandriagetcategoriesresponseErrorsSource> }
    ///Creates an instance of alexandriagetcategoriesresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): alexandriagetcategoriesresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type alexandriagetcategoriesresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of alexandriagetcategoriesresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): alexandriagetcategoriesresponseMessagesSource = { pointer = None }

type alexandriagetcategoriesresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<alexandriagetcategoriesresponseMessagesSource> }
    ///Creates an instance of alexandriagetcategoriesresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): alexandriagetcategoriesresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type alexandriagetcategoriesresponse =
    { errors: list<alexandriagetcategoriesresponseErrors>
      messages: list<alexandriagetcategoriesresponseMessages>
      ///Indicates whether the API call was successful.
      success: bool
      ///Returns the list of categories.
      result: Option<alexandriacategories> }
    ///Creates an instance of alexandriagetcategoriesresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<alexandriagetcategoriesresponseErrors>,
                          messages: list<alexandriagetcategoriesresponseMessages>,
                          success: bool): alexandriagetcategoriesresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type alexandriagetcategoryresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of alexandriagetcategoryresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): alexandriagetcategoryresponseErrorsSource = { pointer = None }

type alexandriagetcategoryresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<alexandriagetcategoryresponseErrorsSource> }
    ///Creates an instance of alexandriagetcategoryresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): alexandriagetcategoryresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type alexandriagetcategoryresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of alexandriagetcategoryresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): alexandriagetcategoryresponseMessagesSource = { pointer = None }

type alexandriagetcategoryresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<alexandriagetcategoryresponseMessagesSource> }
    ///Creates an instance of alexandriagetcategoryresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): alexandriagetcategoryresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type alexandriagetcategoryresponse =
    { errors: list<alexandriagetcategoryresponseErrors>
      messages: list<alexandriagetcategoryresponseMessages>
      ///Indicates whether the API call was successful.
      success: bool
      result: Option<alexandriacategory> }
    ///Creates an instance of alexandriagetcategoryresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<alexandriagetcategoryresponseErrors>,
                          messages: list<alexandriagetcategoryresponseMessages>,
                          success: bool): alexandriagetcategoryresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

[<RequireQualifiedAccess>]
type GetApplications =
    ///Get the application response.
    | OK of payload: alexandriagetapplicationsresponse
    ///Get application response failure.
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type GetApplicationById =
    ///Get the application response.
    | OK of payload: alexandriagetapplicationresponse
    ///Get application by id response failure.
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type GetCategories =
    ///Get all application categories response.
    | OK of payload: alexandriagetcategoriesresponse
    ///Get application categories response failure.
    | BadRequest of payload: string

[<RequireQualifiedAccess>]
type GetCategoryById =
    ///Get application category by id response.
    | OK of payload: alexandriagetcategoryresponse
    ///Get application category by id response failure.
    | BadRequest of payload: string
