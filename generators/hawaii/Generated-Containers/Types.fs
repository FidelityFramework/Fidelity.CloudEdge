namespace rec Fidelity.CloudEdge.Management.Containers.Types

// Auto-generated stub types (missing from Hawaii output)
type minutes = string

///Specifies what permissions the credentials will have.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ccImageRegistryPermissions =
    | [<CompiledName "pull">] Pull
    | [<CompiledName "push">] Push
    | [<CompiledName "library_push">] Library_push
    member this.Format() =
        match this with
        | Pull -> "pull"
        | Push -> "push"
        | Library_push -> "library_push"

///Specifies the configuration for the image registry credential to create.
type ccImageRegistryCredentialsConfiguration =
    { ///The number of minutes the credentials will be valid for.
      expiration_minutes: int
      permissions: list<ccImageRegistryPermissions> }
    ///Creates an instance of ccImageRegistryCredentialsConfiguration with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (expiration_minutes: int, permissions: list<ccImageRegistryPermissions>): ccImageRegistryCredentialsConfiguration =
        { expiration_minutes = expiration_minutes
          permissions = permissions }

[<RequireQualifiedAccess>]
type PublicListApplications =
    | OK of payload: obj
    | Unauthorized of payload: obj
    | InternalServerError of payload: obj

[<RequireQualifiedAccess>]
type GenerateImageRegistryCredentials =
    | Created of payload: obj
    | BadRequest of payload: obj
    | Forbidden of payload: obj
    | NotFound of payload: obj
    | Conflict of payload: obj
    | InternalServerError of payload: obj
