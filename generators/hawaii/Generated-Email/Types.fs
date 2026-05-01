namespace rec Fidelity.CloudEdge.Management.Email.Types

// Auto-generated type aliases (Hawaii normalization fix)
type ``email-security_AllowPolicy`` = ``email-securityAllowPolicy``
type ``email-security_BlockedSender`` = ``email-securityBlockedSender``
type ``email-security_Domain`` = ``email-securityDomain``
type ``email-security_ImpersonationRegistry`` = ``email-securityImpersonationRegistry``
type ``email-security_SendingDomainRestriction`` = ``email-securitySendingDomainRestriction``
type ``email-security_TrustedDomain`` = ``email-securityTrustedDomain``
type email_email_routing_get_response_dns_error = emailemailroutinggetresponsednserror
type email_rule_action = emailruleaction
type ``email_rule_catchall-action`` = ``emailrulecatchall-action``
type ``email_rule_catchall-matcher`` = ``emailrulecatchall-matcher``
type email_rule_matcher = emailrulematcher

// Auto-generated stub types (missing from Hawaii output)
type action = string
type issue = string
type matcher = string
type results = string
type supported = string
type your = string

///Allow policy identifier
type ``email-securityAllowPolicyId`` = System.Guid
type ``email-securityAllowPolicyList`` = list<``email-security_AllowPolicy``>
///Blocked sender pattern identifier
type ``email-securityBlockedSenderId`` = System.Guid
type ``email-securityBlockedSenderList`` = list<``email-security_BlockedSender``>

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityCustomerStatus`` =
    | [<CompiledName "escalated">] Escalated
    | [<CompiledName "reviewed">] Reviewed
    | [<CompiledName "unreviewed">] Unreviewed
    member this.Format() =
        match this with
        | Escalated -> "escalated"
        | Reviewed -> "reviewed"
        | Unreviewed -> "unreviewed"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityDeliveryMode`` =
    | [<CompiledName "DIRECT">] DIRECT
    | [<CompiledName "BCC">] BCC
    | [<CompiledName "JOURNAL">] JOURNAL
    | [<CompiledName "API">] API
    | [<CompiledName "RETRO_SCAN">] RETRO_SCAN
    member this.Format() =
        match this with
        | DIRECT -> "DIRECT"
        | BCC -> "BCC"
        | JOURNAL -> "JOURNAL"
        | API -> "API"
        | RETRO_SCAN -> "RETRO_SCAN"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityDispositionLabel`` =
    | [<CompiledName "MALICIOUS">] MALICIOUS
    | [<CompiledName "MALICIOUS-BEC">] MALICIOUSBEC
    | [<CompiledName "SUSPICIOUS">] SUSPICIOUS
    | [<CompiledName "SPOOF">] SPOOF
    | [<CompiledName "SPAM">] SPAM
    | [<CompiledName "BULK">] BULK
    | [<CompiledName "ENCRYPTED">] ENCRYPTED
    | [<CompiledName "EXTERNAL">] EXTERNAL
    | [<CompiledName "UNKNOWN">] UNKNOWN
    | [<CompiledName "NONE">] NONE
    member this.Format() =
        match this with
        | MALICIOUS -> "MALICIOUS"
        | MALICIOUSBEC -> "MALICIOUS-BEC"
        | SUSPICIOUS -> "SUSPICIOUS"
        | SPOOF -> "SPOOF"
        | SPAM -> "SPAM"
        | BULK -> "BULK"
        | ENCRYPTED -> "ENCRYPTED"
        | EXTERNAL -> "EXTERNAL"
        | UNKNOWN -> "UNKNOWN"
        | NONE -> "NONE"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityDmarcStatus`` =
    | [<CompiledName "none">] None
    | [<CompiledName "good">] Good
    | [<CompiledName "invalid">] Invalid
    member this.Format() =
        match this with
        | None -> "none"
        | Good -> "good"
        | Invalid -> "invalid"

///Domain identifier
type ``email-securityDomainId`` = System.Guid
type ``email-securityDomainList`` = list<``email-security_Domain``>

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityDomainStatus`` =
    | [<CompiledName "pending">] Pending
    | [<CompiledName "active">] Active
    | [<CompiledName "failed">] Failed
    | [<CompiledName "timeout">] Timeout
    member this.Format() =
        match this with
        | Pending -> "pending"
        | Active -> "active"
        | Failed -> "failed"
        | Timeout -> "timeout"

///Impersonation registry entry identifier
type ``email-securityImpersonationRegistryId`` = System.Guid
type ``email-securityImpersonationRegistryList`` = list<``email-security_ImpersonationRegistry``>
///Unique identifier for a message retrieved from investigation
type ``email-securityInvestigateId`` = string

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityMailboxDestination`` =
    | [<CompiledName "Inbox">] Inbox
    | [<CompiledName "JunkEmail">] JunkEmail
    | [<CompiledName "DeletedItems">] DeletedItems
    | [<CompiledName "RecoverableItemsDeletions">] RecoverableItemsDeletions
    | [<CompiledName "RecoverableItemsPurges">] RecoverableItemsPurges
    member this.Format() =
        match this with
        | Inbox -> "Inbox"
        | JunkEmail -> "JunkEmail"
        | DeletedItems -> "DeletedItems"
        | RecoverableItemsDeletions -> "RecoverableItemsDeletions"
        | RecoverableItemsPurges -> "RecoverableItemsPurges"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityMessageDeliveryMode`` =
    | [<CompiledName "DIRECT">] DIRECT
    | [<CompiledName "BCC">] BCC
    | [<CompiledName "JOURNAL">] JOURNAL
    | [<CompiledName "REVIEW_SUBMISSION">] REVIEW_SUBMISSION
    | [<CompiledName "DMARC_UNVERIFIED">] DMARC_UNVERIFIED
    | [<CompiledName "DMARC_FAILURE_REPORT">] DMARC_FAILURE_REPORT
    | [<CompiledName "DMARC_AGGREGATE_REPORT">] DMARC_AGGREGATE_REPORT
    | [<CompiledName "THREAT_INTEL_SUBMISSION">] THREAT_INTEL_SUBMISSION
    | [<CompiledName "SIMULATION_SUBMISSION">] SIMULATION_SUBMISSION
    | [<CompiledName "API">] API
    | [<CompiledName "RETRO_SCAN">] RETRO_SCAN
    member this.Format() =
        match this with
        | DIRECT -> "DIRECT"
        | BCC -> "BCC"
        | JOURNAL -> "JOURNAL"
        | REVIEW_SUBMISSION -> "REVIEW_SUBMISSION"
        | DMARC_UNVERIFIED -> "DMARC_UNVERIFIED"
        | DMARC_FAILURE_REPORT -> "DMARC_FAILURE_REPORT"
        | DMARC_AGGREGATE_REPORT -> "DMARC_AGGREGATE_REPORT"
        | THREAT_INTEL_SUBMISSION -> "THREAT_INTEL_SUBMISSION"
        | SIMULATION_SUBMISSION -> "SIMULATION_SUBMISSION"
        | API -> "API"
        | RETRO_SCAN -> "RETRO_SCAN"

///Delivery status of the message.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityMessageDeliveryStatus`` =
    | [<CompiledName "delivered">] Delivered
    | [<CompiledName "moved">] Moved
    | [<CompiledName "quarantined">] Quarantined
    | [<CompiledName "rejected">] Rejected
    | [<CompiledName "deferred">] Deferred
    | [<CompiledName "bounced">] Bounced
    | [<CompiledName "queued">] Queued
    member this.Format() =
        match this with
        | Delivered -> "delivered"
        | Moved -> "moved"
        | Quarantined -> "quarantined"
        | Rejected -> "rejected"
        | Deferred -> "deferred"
        | Bounced -> "bounced"
        | Queued -> "queued"

type ``email-securityOptionalSubmissionDisposition`` = string

///Type of pattern matching.
///Note: UNKNOWN is deprecated and cannot be used when creating or updating policies, but may be returned for existing entries.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityPatternType`` =
    | [<CompiledName "EMAIL">] EMAIL
    | [<CompiledName "DOMAIN">] DOMAIN
    | [<CompiledName "IP">] IP
    | [<CompiledName "UNKNOWN">] UNKNOWN
    member this.Format() =
        match this with
        | EMAIL -> "EMAIL"
        | DOMAIN -> "DOMAIN"
        | IP -> "IP"
        | UNKNOWN -> "UNKNOWN"

///The identifier of the message
type ``email-securityPostfixId`` = string

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityProvenance`` =
    | [<CompiledName "A1S_INTERNAL">] A1S_INTERNAL
    | [<CompiledName "SNOOPY-CASB_OFFICE_365">] SNOOPYCASB_OFFICE_365
    | [<CompiledName "SNOOPY-OFFICE_365">] SNOOPYOFFICE_365
    | [<CompiledName "SNOOPY-GOOGLE_DIRECTORY">] SNOOPYGOOGLE_DIRECTORY
    member this.Format() =
        match this with
        | A1S_INTERNAL -> "A1S_INTERNAL"
        | SNOOPYCASB_OFFICE_365 -> "SNOOPY-CASB_OFFICE_365"
        | SNOOPYOFFICE_365 -> "SNOOPY-OFFICE_365"
        | SNOOPYGOOGLE_DIRECTORY -> "SNOOPY-GOOGLE_DIRECTORY"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityRegion`` =
    | [<CompiledName "GLOBAL">] GLOBAL
    | [<CompiledName "AU">] AU
    | [<CompiledName "DE">] DE
    | [<CompiledName "IN">] IN
    | [<CompiledName "US">] US
    member this.Format() =
        match this with
        | GLOBAL -> "GLOBAL"
        | AU -> "AU"
        | DE -> "DE"
        | IN -> "IN"
        | US -> "US"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityScannableFolder`` =
    | [<CompiledName "AllItems">] AllItems
    | [<CompiledName "Inbox">] Inbox
    member this.Format() =
        match this with
        | AllItems -> "AllItems"
        | Inbox -> "Inbox"

///Sending domain restriction identifier.
type ``email-securitySendingDomainRestrictionId`` = System.Guid
type ``email-securitySendingDomainRestrictionList`` = list<``email-security_SendingDomainRestriction``>

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securitySpfStatus`` =
    | [<CompiledName "none">] None
    | [<CompiledName "good">] Good
    | [<CompiledName "neutral">] Neutral
    | [<CompiledName "open">] Open
    | [<CompiledName "invalid">] Invalid
    member this.Format() =
        match this with
        | None -> "none"
        | Good -> "good"
        | Neutral -> "neutral"
        | Open -> "open"
        | Invalid -> "invalid"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securitySubmissionDisposition`` =
    | [<CompiledName "MALICIOUS">] MALICIOUS
    | [<CompiledName "SUSPICIOUS">] SUSPICIOUS
    | [<CompiledName "SPOOF">] SPOOF
    | [<CompiledName "SPAM">] SPAM
    | [<CompiledName "BULK">] BULK
    | [<CompiledName "NONE">] NONE
    member this.Format() =
        match this with
        | MALICIOUS -> "MALICIOUS"
        | SUSPICIOUS -> "SUSPICIOUS"
        | SPOOF -> "SPOOF"
        | SPAM -> "SPAM"
        | BULK -> "BULK"
        | NONE -> "NONE"

///Trusted domain identifier
type ``email-securityTrustedDomainId`` = System.Guid
type ``email-securityTrustedDomainList`` = list<``email-security_TrustedDomain``>
///URL ignore pattern identifier
type ``email-securityUrlIgnorePatternId`` = System.Guid

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityValidationStatus`` =
    | [<CompiledName "pass">] Pass
    | [<CompiledName "neutral">] Neutral
    | [<CompiledName "fail">] Fail
    | [<CompiledName "error">] Error
    | [<CompiledName "none">] None
    member this.Format() =
        match this with
        | Pass -> "pass"
        | Neutral -> "neutral"
        | Fail -> "fail"
        | Error -> "error"
        | None -> "none"

///Identifier.
type ``email-securityidentifier`` = string

type Source =
    { pointer: Option<string> }
    ///Creates an instance of Source with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Source = { pointer = None }

type ``email-securitymessagesArrayItem`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<Source> }
    ///Creates an instance of email-securitymessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``email-securitymessagesArrayItem`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``email-securitymessages`` = list<``email-securitymessagesArrayItem``>
type ``email-securitytimestamp`` = System.DateTimeOffset
///A list of email address strings.
type ``email-sendingEmailAddressList`` = list<string>
///An email address as a plain string.
type ``email-sendingEmailAddressString`` = string
///Identifier.
type emailaccountid = string
///The date and time the destination address has been created.
type emailcreated = System.DateTimeOffset
///Destination address identifier.
type emaildestinationaddressidentifier = string
///Destination address tag. (Deprecated, replaced by destination address identifier)
type emaildestinationaddresstag = string
///The contact email address of the user.
type emailemail = string
type emailemailroutinggetresponsednserrors = list<email_email_routing_get_response_dns_error>
///The date and time the settings have been created.
type emailemailsettingcreated = System.DateTimeOffset
type emailemailsettingenabled = bool
///Email Routing settings identifier.
type emailemailsettingidentifier = string
///The date and time the settings have been modified.
type emailemailsettingmodified = System.DateTimeOffset
///Domain of your zone.
type emailemailsettingname = string
type ``emailemailsettingskip-wizard`` = bool

///Show the state of your account, and the type or configuration error.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type emailemailsettingstatus =
    | [<CompiledName "ready">] Ready
    | [<CompiledName "unconfigured">] Unconfigured
    | [<CompiledName "misconfigured">] Misconfigured
    | [<CompiledName "misconfigured/locked">] MisconfiguredLocked
    | [<CompiledName "unlocked">] Unlocked
    member this.Format() =
        match this with
        | Ready -> "ready"
        | Unconfigured -> "unconfigured"
        | Misconfigured -> "misconfigured"
        | MisconfiguredLocked -> "misconfigured/locked"
        | Unlocked -> "unlocked"

///Email Routing settings tag. (Deprecated, replaced by Email Routing settings identifier)
type emailemailsettingtag = string
///Identifier.
type emailidentifier = string

type emailmessagesArrayItemSource =
    { pointer: Option<string> }
    ///Creates an instance of emailmessagesArrayItemSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailmessagesArrayItemSource = { pointer = None }

type emailmessagesArrayItem =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailmessagesArrayItemSource> }
    ///Creates an instance of emailmessagesArrayItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailmessagesArrayItem =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailmessages = list<emailmessagesArrayItem>
///The date and time the destination address was last modified.
type emailmodified = System.DateTimeOffset
type emailruleactions = list<email_rule_action>
type ``emailrulecatchall-actions`` = list<``email_rule_catchall-action``>
type ``emailrulecatchall-matchers`` = list<``email_rule_catchall-matcher``>
type emailruleenabled = bool
///Routing rule identifier.
type emailruleidentifier = string
type emailrulematchers = list<email_rule_matcher>
///Routing rule name.
type emailrulename = string
type emailrulepriority = float
///Routing rule tag. (Deprecated, replaced by routing rule identifier)
type emailruletag = string
///Sending subdomain identifier.
type emailsendingsubdomainidentifier = string
///The date and time the destination address has been verified. Null means not verified yet.
type emailverified = System.DateTimeOffset
///Identifier.
type emailzoneid = string

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Operation =
    | [<CompiledName "PREVIEW">] PREVIEW
    | [<CompiledName "QUARANTINE_RELEASE">] QUARANTINE_RELEASE
    | [<CompiledName "SUBMISSION">] SUBMISSION
    | [<CompiledName "MOVE">] MOVE
    member this.Format() =
        match this with
        | PREVIEW -> "PREVIEW"
        | QUARANTINE_RELEASE -> "QUARANTINE_RELEASE"
        | SUBMISSION -> "SUBMISSION"
        | MOVE -> "MOVE"

type Properties =
    { folder: Option<string>
      requested_by: Option<string>
      requested_disposition: Option<string>
      service: Option<string>
      submission_id: Option<string>
      submission_type: Option<string> }
    ///Creates an instance of Properties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Properties =
        { folder = None
          requested_by = None
          requested_disposition = None
          service = None
          submission_id = None
          submission_type = None }

type ``email-securityActionEntry`` =
    { ///Timestamp when the action completed
      completed_at: Option<System.DateTimeOffset>
      operation: Operation
      properties: Option<Properties>
      ///Timestamp when the action was initiated
      started_at: Option<System.DateTimeOffset>
      status: Option<string>
      success: Option<bool> }
    ///Creates an instance of email-securityActionEntry with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (operation: Operation): ``email-securityActionEntry`` =
        { completed_at = None
          operation = operation
          properties = None
          started_at = None
          status = None
          success = None }

type ``email-securityActionEntryProperties`` =
    { folder: Option<string>
      requested_by: Option<string>
      requested_disposition: Option<string>
      service: Option<string>
      submission_id: Option<string>
      submission_type: Option<string> }
    ///Creates an instance of email-securityActionEntryProperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityActionEntryProperties`` =
        { folder = None
          requested_by = None
          requested_disposition = None
          service = None
          submission_id = None
          submission_type = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-securityActionLogEntryOperation`` =
    | [<CompiledName "MOVE">] MOVE
    | [<CompiledName "RELEASE">] RELEASE
    | [<CompiledName "RECLASSIFY">] RECLASSIFY
    | [<CompiledName "SUBMISSION">] SUBMISSION
    | [<CompiledName "QUARANTINE_RELEASE">] QUARANTINE_RELEASE
    | [<CompiledName "PREVIEW">] PREVIEW
    member this.Format() =
        match this with
        | MOVE -> "MOVE"
        | RELEASE -> "RELEASE"
        | RECLASSIFY -> "RECLASSIFY"
        | SUBMISSION -> "SUBMISSION"
        | QUARANTINE_RELEASE -> "QUARANTINE_RELEASE"
        | PREVIEW -> "PREVIEW"

///Additional properties for the action
type ``email-securityActionLogEntryProperties`` =
    { ///Target folder for move operations
      folder: Option<string>
      ///User who requested the action
      requested_by: Option<string> }
    ///Creates an instance of email-securityActionLogEntryProperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityActionLogEntryProperties`` = { folder = None; requested_by = None }

type ``email-securityActionLogEntry`` =
    { ///Timestamp when action completed
      completed_at: System.DateTimeOffset
      ///Type of action performed
      operation: ``email-securityActionLogEntryOperation``
      ///Additional properties for the action
      properties: Option<``email-securityActionLogEntryProperties``>
      ///Status of the action
      status: Option<string> }
    ///Creates an instance of email-securityActionLogEntry with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (completed_at: System.DateTimeOffset, operation: ``email-securityActionLogEntryOperation``): ``email-securityActionLogEntry`` =
        { completed_at = completed_at
          operation = operation
          properties = None
          status = None }

///An email allow policy
type ``email-securityAllowPolicy`` =
    { comments: Option<string>
      created_at: System.DateTimeOffset
      id: string
      ///Messages from this sender will be exempted from Spam, Spoof and Bulk dispositions. Note - This will not exempt messages with Malicious or Suspicious dispositions.
      is_acceptable_sender: Option<bool>
      ///Messages to this recipient will bypass all detections
      is_exempt_recipient: Option<bool>
      is_regex: Option<bool>
      ///Messages from this sender will bypass all detections and link following
      is_trusted_sender: Option<bool>
      modified_at: Option<System.DateTimeOffset>
      pattern: Option<string>
      ///Type of pattern matching.
      ///Note: UNKNOWN is deprecated and cannot be used when creating or updating policies, but may be returned for existing entries.
      pattern_type: Option<``email-securityPatternType``>
      ///Enforce DMARC, SPF or DKIM authentication. When on, Email Security only honors policies that pass authentication.
      verify_sender: Option<bool> }
    ///Creates an instance of email-securityAllowPolicy with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (created_at: System.DateTimeOffset, id: obj): ``email-securityAllowPolicy`` =
        { comments = None
          created_at = created_at
          id = id
          is_acceptable_sender = None
          is_exempt_recipient = None
          is_regex = None
          is_trusted_sender = None
          modified_at = None
          pattern = None
          pattern_type = None
          verify_sender = None }

type ``email-securityAttachment`` =
    { ///MIME type of the attachment
      content_type: Option<string>
      ///Detection result for this attachment
      detection: Option<string>
      ///Whether the attachment is encrypted
      encrypted: Option<bool>
      ///Name of the attached file
      filename: Option<string>
      ///MD5 hash of the attachment
      md5: Option<string>
      ///Attachment name (alternative to filename)
      name: Option<string>
      ///SHA1 hash of the attachment
      sha1: Option<string>
      ///SHA256 hash of the attachment
      sha256: Option<string>
      ///Size of the attachment in bytes
      size: int }
    ///Creates an instance of email-securityAttachment with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (size: int): ``email-securityAttachment`` =
        { content_type = None
          detection = None
          encrypted = None
          filename = None
          md5 = None
          name = None
          sha1 = None
          sha256 = None
          size = size }

///A blocked sender pattern
type ``email-securityBlockedSender`` =
    { comments: Option<string>
      created_at: Option<System.DateTimeOffset>
      id: Option<string>
      is_regex: Option<bool>
      modified_at: Option<System.DateTimeOffset>
      pattern: Option<string>
      ///Type of pattern matching.
      ///Note: UNKNOWN is deprecated and cannot be used when creating or updating policies, but may be returned for existing entries.
      pattern_type: Option<``email-securityPatternType``> }
    ///Creates an instance of email-securityBlockedSender with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityBlockedSender`` =
        { comments = None
          created_at = None
          id = None
          is_regex = None
          modified_at = None
          pattern = None
          pattern_type = None }

///Create an allow policy
type ``email-securityCreateAllowPolicy`` =
    { comments: Option<string>
      created_at: Option<System.DateTimeOffset>
      id: Option<string>
      ///Messages from this sender will be exempted from Spam, Spoof and Bulk dispositions. Note - This will not exempt messages with Malicious or Suspicious dispositions.
      is_acceptable_sender: bool
      ///Messages to this recipient will bypass all detections
      is_exempt_recipient: bool
      is_regex: bool
      ///Messages from this sender will bypass all detections and link following
      is_trusted_sender: bool
      modified_at: Option<obj>
      pattern: string
      ///Type of pattern matching.
      ///Note: UNKNOWN is deprecated and cannot be used when creating or updating policies, but may be returned for existing entries.
      pattern_type: ``email-securityPatternType``
      ///Enforce DMARC, SPF or DKIM authentication. When on, Email Security only honors policies that pass authentication.
      verify_sender: bool }
    ///Creates an instance of email-securityCreateAllowPolicy with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (is_acceptable_sender: bool,
                          is_exempt_recipient: bool,
                          is_regex: bool,
                          is_trusted_sender: bool,
                          pattern: string,
                          pattern_type: ``email-securityPatternType``,
                          verify_sender: bool): ``email-securityCreateAllowPolicy`` =
        { comments = None
          created_at = None
          id = None
          is_acceptable_sender = is_acceptable_sender
          is_exempt_recipient = is_exempt_recipient
          is_regex = is_regex
          is_trusted_sender = is_trusted_sender
          modified_at = None
          pattern = pattern
          pattern_type = pattern_type
          verify_sender = verify_sender }

///Create a blocked sender pattern
type ``email-securityCreateBlockedSender`` =
    { comments: Option<string>
      created_at: Option<System.DateTimeOffset>
      id: Option<string>
      is_regex: bool
      modified_at: Option<obj>
      pattern: string
      ///Type of pattern matching.
      ///Note: UNKNOWN is deprecated and cannot be used when creating or updating policies, but may be returned for existing entries.
      pattern_type: ``email-securityPatternType`` }
    ///Creates an instance of email-securityCreateBlockedSender with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (is_regex: bool, pattern: string, pattern_type: ``email-securityPatternType``): ``email-securityCreateBlockedSender`` =
        { comments = None
          created_at = None
          id = None
          is_regex = is_regex
          modified_at = None
          pattern = pattern
          pattern_type = pattern_type }

///Create an impersonation registry entry
type ``email-securityCreateImpersonationRegistry`` =
    { comments: Option<string>
      created_at: Option<System.DateTimeOffset>
      directory_id: Option<int>
      directory_node_id: Option<int>
      email: string
      id: Option<string>
      is_email_regex: bool
      modified_at: Option<obj>
      name: string
      provenance: Option<``email-securityProvenance``> }
    ///Creates an instance of email-securityCreateImpersonationRegistry with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (email: string, is_email_regex: bool, name: string): ``email-securityCreateImpersonationRegistry`` =
        { comments = None
          created_at = None
          directory_id = None
          directory_node_id = None
          email = email
          id = None
          is_email_regex = is_email_regex
          modified_at = None
          name = name
          provenance = None }

///Create a sending domain restriction.
type ``email-securityCreateSendingDomainRestriction`` =
    { comments: Option<string>
      created_at: Option<System.DateTimeOffset>
      ///Domain that requires TLS enforcement.
      domain: string
      ///Excluded subdomains that are exempt from TLS requirements.
      exclude: list<string>
      id: Option<string>
      modified_at: Option<obj> }
    ///Creates an instance of email-securityCreateSendingDomainRestriction with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (domain: string, exclude: list<string>): ``email-securityCreateSendingDomainRestriction`` =
        { comments = None
          created_at = None
          domain = domain
          exclude = exclude
          id = None
          modified_at = None }

///Create a trusted domain
type ``email-securityCreateTrustedDomain`` =
    { comments: Option<string>
      created_at: Option<System.DateTimeOffset>
      id: Option<string>
      ///Select to prevent recently registered domains from triggering a Suspicious or Malicious disposition.
      is_recent: bool
      is_regex: bool
      ///Select for partner or other approved domains that have similar spelling to your connected domains. Prevents listed domains from triggering a Spoof disposition.
      is_similarity: bool
      modified_at: Option<obj>
      pattern: string }
    ///Creates an instance of email-securityCreateTrustedDomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (is_recent: bool, is_regex: bool, is_similarity: bool, pattern: string): ``email-securityCreateTrustedDomain`` =
        { comments = None
          created_at = None
          id = None
          is_recent = is_recent
          is_regex = is_regex
          is_similarity = is_similarity
          modified_at = None
          pattern = pattern }

///Create a URL ignore pattern for URLs that should not be rewritten.
type ``email-securityCreateUrlIgnorePattern`` =
    { ///Optional note describing the reason for the ignore pattern.
      comments: Option<string>
      ///Regular expression matching URLs that should not be rewritten.
      pattern: string }
    ///Creates an instance of email-securityCreateUrlIgnorePattern with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (pattern: string): ``email-securityCreateUrlIgnorePattern`` =
        { comments = None; pattern = pattern }

type ``email-securityCursorResultInfo`` =
    { ///Number of items in current page
      count: int
      ///Cursor for next page
      next: Option<string>
      ///Number of items per page
      per_page: int
      ///Cursor for previous page
      previous: Option<string> }
    ///Creates an instance of email-securityCursorResultInfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (count: int, per_page: int): ``email-securityCursorResultInfo`` =
        { count = count
          next = None
          per_page = per_page
          previous = None }

type ``email-securityDeletedAllowPolicy`` =
    { ///Allow policy identifier
      id: ``email-securityAllowPolicyId`` }
    ///Creates an instance of email-securityDeletedAllowPolicy with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``email-securityAllowPolicyId``): ``email-securityDeletedAllowPolicy`` = { id = id }

type ``email-securityDeletedBlockedSender`` =
    { ///Blocked sender pattern identifier
      id: ``email-securityBlockedSenderId`` }
    ///Creates an instance of email-securityDeletedBlockedSender with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``email-securityBlockedSenderId``): ``email-securityDeletedBlockedSender`` = { id = id }

type ``email-securityDeletedDomain`` =
    { ///Domain identifier
      id: ``email-securityDomainId`` }
    ///Creates an instance of email-securityDeletedDomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``email-securityDomainId``): ``email-securityDeletedDomain`` = { id = id }

type ``email-securityDeletedImpersonationRegistry`` =
    { ///Impersonation registry entry identifier
      id: ``email-securityImpersonationRegistryId`` }
    ///Creates an instance of email-securityDeletedImpersonationRegistry with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``email-securityImpersonationRegistryId``): ``email-securityDeletedImpersonationRegistry`` =
        { id = id }

type ``email-securityDeletedSendingDomainRestriction`` =
    { ///Sending domain restriction identifier.
      id: ``email-securitySendingDomainRestrictionId`` }
    ///Creates an instance of email-securityDeletedSendingDomainRestriction with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``email-securitySendingDomainRestrictionId``): ``email-securityDeletedSendingDomainRestriction`` =
        { id = id }

type ``email-securityDeletedTrustedDomain`` =
    { ///Trusted domain identifier
      id: ``email-securityTrustedDomainId`` }
    ///Creates an instance of email-securityDeletedTrustedDomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``email-securityTrustedDomainId``): ``email-securityDeletedTrustedDomain`` = { id = id }

type ``email-securityDeletedUrlIgnorePattern`` =
    { ///URL ignore pattern identifier
      id: ``email-securityUrlIgnorePatternId`` }
    ///Creates an instance of email-securityDeletedUrlIgnorePattern with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``email-securityUrlIgnorePatternId``): ``email-securityDeletedUrlIgnorePattern`` =
        { id = id }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Inboxprovider =
    | [<CompiledName "Microsoft">] Microsoft
    | [<CompiledName "Google">] Google
    member this.Format() =
        match this with
        | Microsoft -> "Microsoft"
        | Google -> "Google"

type ``email-securityDomain`` =
    { allowed_delivery_modes: Option<list<``email-securityDeliveryMode``>>
      authorization: Option<``email-securityDomainAuthorization``>
      created_at: Option<System.DateTimeOffset>
      dmarc_status: Option<``email-securityDmarcStatus``>
      domain: Option<string>
      drop_dispositions: Option<list<``email-securityDispositionLabel``>>
      emails_processed: Option<``email-securityEmailsProcessed``>
      folder: Option<``email-securityScannableFolder``>
      ///Domain identifier
      id: Option<``email-securityDomainId``>
      inbox_provider: Option<Inboxprovider>
      integration_id: Option<System.Guid>
      ip_restrictions: Option<list<string>>
      lookback_hops: Option<int>
      modified_at: Option<System.DateTimeOffset>
      o365_tenant_id: Option<string>
      regions: Option<list<``email-securityRegion``>>
      require_tls_inbound: Option<bool>
      require_tls_outbound: Option<bool>
      spf_status: Option<``email-securitySpfStatus``>
      status: Option<``email-securityDomainStatus``>
      transport: Option<string> }
    ///Creates an instance of email-securityDomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityDomain`` =
        { allowed_delivery_modes = None
          authorization = None
          created_at = None
          dmarc_status = None
          domain = None
          drop_dispositions = None
          emails_processed = None
          folder = None
          id = None
          inbox_provider = None
          integration_id = None
          ip_restrictions = None
          lookback_hops = None
          modified_at = None
          o365_tenant_id = None
          regions = None
          require_tls_inbound = None
          require_tls_outbound = None
          spf_status = None
          status = None
          transport = None }

type ``email-securityDomainAuthorization`` =
    { authorized: bool
      status_message: Option<string>
      timestamp: System.DateTimeOffset }
    ///Creates an instance of email-securityDomainAuthorization with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (authorized: bool, timestamp: System.DateTimeOffset): ``email-securityDomainAuthorization`` =
        { authorized = authorized
          status_message = None
          timestamp = timestamp }

type ``email-securityEmailsProcessed`` =
    { timestamp: System.DateTimeOffset
      total_emails_processed: int
      total_emails_processed_previous: int }
    ///Creates an instance of email-securityEmailsProcessed with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (timestamp: System.DateTimeOffset,
                          total_emails_processed: int,
                          total_emails_processed_previous: int): ``email-securityEmailsProcessed`` =
        { timestamp = timestamp
          total_emails_processed = total_emails_processed
          total_emails_processed_previous = total_emails_processed_previous }

///An impersonation registry entry
type ``email-securityImpersonationRegistry`` =
    { comments: Option<string>
      created_at: Option<System.DateTimeOffset>
      directory_id: Option<int>
      directory_node_id: Option<int>
      email: Option<string>
      id: Option<string>
      is_email_regex: Option<bool>
      modified_at: Option<System.DateTimeOffset>
      name: Option<string>
      provenance: Option<``email-securityProvenance``> }
    ///Creates an instance of email-securityImpersonationRegistry with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityImpersonationRegistry`` =
        { comments = None
          created_at = None
          directory_id = None
          directory_node_id = None
          email = None
          id = None
          is_email_regex = None
          modified_at = None
          name = None
          provenance = None }

type ``email-securityLink`` =
    { href: string
      text: Option<string> }
    ///Creates an instance of email-securityLink with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (href: string): ``email-securityLink`` = { href = href; text = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Post_delivery_operations =
    | [<CompiledName "PREVIEW">] PREVIEW
    | [<CompiledName "QUARANTINE_RELEASE">] QUARANTINE_RELEASE
    | [<CompiledName "SUBMISSION">] SUBMISSION
    | [<CompiledName "MOVE">] MOVE
    member this.Format() =
        match this with
        | PREVIEW -> "PREVIEW"
        | QUARANTINE_RELEASE -> "QUARANTINE_RELEASE"
        | SUBMISSION -> "SUBMISSION"
        | MOVE -> "MOVE"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Allowlistedpatterntype =
    | [<CompiledName "quarantine_release">] Quarantine_release
    | [<CompiledName "acceptable_sender">] Acceptable_sender
    | [<CompiledName "allowed_sender">] Allowed_sender
    | [<CompiledName "allowed_recipient">] Allowed_recipient
    | [<CompiledName "domain_similarity">] Domain_similarity
    | [<CompiledName "domain_recency">] Domain_recency
    | [<CompiledName "managed_acceptable_sender">] Managed_acceptable_sender
    | [<CompiledName "outbound_ndr">] Outbound_ndr
    member this.Format() =
        match this with
        | Quarantine_release -> "quarantine_release"
        | Acceptable_sender -> "acceptable_sender"
        | Allowed_sender -> "allowed_sender"
        | Allowed_recipient -> "allowed_recipient"
        | Domain_similarity -> "domain_similarity"
        | Domain_recency -> "domain_recency"
        | Managed_acceptable_sender -> "managed_acceptable_sender"
        | Outbound_ndr -> "outbound_ndr"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Whitelistedpatterntype =
    | [<CompiledName "quarantine_release">] Quarantine_release
    | [<CompiledName "acceptable_sender">] Acceptable_sender
    | [<CompiledName "allowed_sender">] Allowed_sender
    | [<CompiledName "allowed_recipient">] Allowed_recipient
    | [<CompiledName "domain_similarity">] Domain_similarity
    | [<CompiledName "domain_recency">] Domain_recency
    | [<CompiledName "managed_acceptable_sender">] Managed_acceptable_sender
    | [<CompiledName "outbound_ndr">] Outbound_ndr
    member this.Format() =
        match this with
        | Quarantine_release -> "quarantine_release"
        | Acceptable_sender -> "acceptable_sender"
        | Allowed_sender -> "allowed_sender"
        | Allowed_recipient -> "allowed_recipient"
        | Domain_similarity -> "domain_similarity"
        | Domain_recency -> "domain_recency"
        | Managed_acceptable_sender -> "managed_acceptable_sender"
        | Outbound_ndr -> "outbound_ndr"

///Message processing properties
type ``email-securityMessageDetailsProperties`` =
    { ///Pattern that allowlisted this message
      allowlisted_pattern: Option<string>
      ///Type of allowlist pattern
      allowlisted_pattern_type: Option<Allowlistedpatterntype>
      ///Whether message was blocklisted
      blocklisted_message: Option<bool>
      ///Pattern that blocklisted this message
      blocklisted_pattern: Option<string>
      ///Legacy field for allowlist pattern type
      whitelisted_pattern_type: Option<Whitelistedpatterntype> }
    ///Creates an instance of email-securityMessageDetailsProperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityMessageDetailsProperties`` =
        { allowlisted_pattern = None
          allowlisted_pattern_type = None
          blocklisted_message = None
          blocklisted_pattern = None
          whitelisted_pattern_type = None }

type ``email-securityMessageDetails`` =
    { alert_id: Option<string>
      client_recipients: list<string>
      delivery_mode: Option<``email-securityMessageDeliveryMode``>
      delivery_status: Option<list<``email-securityMessageDeliveryStatus``>>
      detection_reasons: list<string>
      edf_hash: Option<string>
      envelope_from: Option<string>
      envelope_to: Option<list<string>>
      final_disposition: Option<``email-securityDispositionLabel``>
      from: Option<string>
      from_name: Option<string>
      htmltext_structure_hash: Option<string>
      id: string
      is_phish_submission: bool
      is_quarantined: bool
      message_id: Option<string>
      ///Post-delivery operations performed on this message
      post_delivery_operations: Option<list<Post_delivery_operations>>
      ///The identifier of the message
      postfix_id: ``email-securityPostfixId``
      postfix_id_outbound: Option<string>
      ///Message processing properties
      properties: ``email-securityMessageDetailsProperties``
      replyto: Option<string>
      ///When the message was scanned (UTC)
      scanned_at: Option<System.DateTimeOffset>
      ///When the message was sent (UTC)
      sent_at: Option<System.DateTimeOffset>
      sent_date: Option<string>
      subject: Option<string>
      threat_categories: Option<list<string>>
      ``to``: Option<list<string>>
      to_name: Option<list<string>>
      validation: Option<``email-securityValidation``> }
    ///Creates an instance of email-securityMessageDetails with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (client_recipients: list<string>,
                          detection_reasons: list<string>,
                          id: string,
                          is_phish_submission: bool,
                          is_quarantined: bool,
                          postfix_id: ``email-securityPostfixId``,
                          properties: ``email-securityMessageDetailsProperties``): ``email-securityMessageDetails`` =
        { alert_id = None
          client_recipients = client_recipients
          delivery_mode = None
          delivery_status = None
          detection_reasons = detection_reasons
          edf_hash = None
          envelope_from = None
          envelope_to = None
          final_disposition = None
          from = None
          from_name = None
          htmltext_structure_hash = None
          id = id
          is_phish_submission = is_phish_submission
          is_quarantined = is_quarantined
          message_id = None
          post_delivery_operations = None
          postfix_id = postfix_id
          postfix_id_outbound = None
          properties = properties
          replyto = None
          scanned_at = None
          sent_at = None
          sent_date = None
          subject = None
          threat_categories = None
          ``to`` = None
          to_name = None
          validation = None }

type Findings =
    { attachment: Option<string>
      detail: Option<string>
      detection: Option<``email-securityDispositionLabel``>
      field: Option<string>
      name: Option<string>
      portion: Option<string>
      reason: Option<string>
      score: Option<float>
      value: Option<string> }
    ///Creates an instance of Findings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Findings =
        { attachment = None
          detail = None
          detection = None
          field = None
          name = None
          portion = None
          reason = None
          score = None
          value = None }

type Senderinfo =
    { ///The name of the autonomous system.
      as_name: Option<string>
      ///The number of the autonomous system.
      as_number: Option<int>
      geo: Option<string>
      ip: Option<string>
      pld: Option<string> }
    ///Creates an instance of Senderinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Senderinfo =
        { as_name = None
          as_number = None
          geo = None
          ip = None
          pld = None }

type ``email-securityMessageDetectionDetails`` =
    { action: string
      attachments: list<``email-securityAttachment``>
      final_disposition: Option<``email-securityDispositionLabel``>
      findings: list<Findings>
      headers: list<``email-securityMessageHeader``>
      links: list<``email-securityLink``>
      sender_info: Senderinfo
      threat_categories: list<``email-securityThreatCategory``>
      validation: ``email-securityValidation`` }
    ///Creates an instance of email-securityMessageDetectionDetails with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (action: string,
                          attachments: list<``email-securityAttachment``>,
                          findings: list<Findings>,
                          headers: list<``email-securityMessageHeader``>,
                          links: list<``email-securityLink``>,
                          sender_info: Senderinfo,
                          threat_categories: list<``email-securityThreatCategory``>,
                          validation: ``email-securityValidation``): ``email-securityMessageDetectionDetails`` =
        { action = action
          attachments = attachments
          final_disposition = None
          findings = findings
          headers = headers
          links = links
          sender_info = sender_info
          threat_categories = threat_categories
          validation = validation }

type ``email-securityMessageHeader`` =
    { name: string
      value: string }
    ///Creates an instance of email-securityMessageHeader with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string, value: string): ``email-securityMessageHeader`` = { name = name; value = value }

type ``email-securityMessagePreview`` =
    { ///A base64 encoded PNG image of the email.
      screenshot: string }
    ///Creates an instance of email-securityMessagePreview with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (screenshot: string): ``email-securityMessagePreview`` = { screenshot = screenshot }

type ``email-securityMessageRaw`` =
    { ///A UTF-8 encoded eml file of the email.
      raw: string }
    ///Creates an instance of email-securityMessageRaw with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (raw: string): ``email-securityMessageRaw`` = { raw = raw }

type Inbound =
    { lines: Option<list<``email-securityTraceLine``>>
      pending: Option<bool> }
    ///Creates an instance of Inbound with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Inbound = { lines = None; pending = None }

type Outbound =
    { lines: Option<list<``email-securityTraceLine``>>
      pending: Option<bool> }
    ///Creates an instance of Outbound with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Outbound = { lines = None; pending = None }

type ``email-securityMessageTrace`` =
    { inbound: Inbound
      outbound: Outbound }
    ///Creates an instance of email-securityMessageTrace with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (inbound: Inbound, outbound: Outbound): ``email-securityMessageTrace`` =
        { inbound = inbound
          outbound = outbound }

type ``email-securityMoveResponseItem`` =
    { ///When the move operation completed (UTC)
      completed_at: Option<System.DateTimeOffset>
      ///Destination folder for the message
      destination: Option<string>
      ///Message identifier
      message_id: Option<string>
      ///Type of operation performed
      operation: Option<string>
      ///Recipient email address
      recipient: Option<string>
      ///Operation status
      status: Option<string>
      ///Whether the operation succeeded
      success: bool }
    ///Creates an instance of email-securityMoveResponseItem with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (success: bool): ``email-securityMoveResponseItem`` =
        { completed_at = None
          destination = None
          message_id = None
          operation = None
          recipient = None
          status = None
          success = success }

type Fields =
    { from: Option<string>
      occurred_at: Option<System.DateTimeOffset>
      postfix_id: Option<string>
      ``to``: list<string> }
    ///Creates an instance of Fields with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``to``: list<string>): Fields =
        { from = None
          occurred_at = None
          postfix_id = None
          ``to`` = ``to`` }

type ``email-securityPhishGuardReport`` =
    { content: string
      created_at: Option<System.DateTimeOffset>
      disposition: ``email-securityDispositionLabel``
      fields: Fields
      id: int
      priority: string
      tags: Option<list<``email-securityPhishGuardReportTag``>>
      title: string
      updated_at: Option<System.DateTimeOffset> }
    ///Creates an instance of email-securityPhishGuardReport with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string,
                          disposition: ``email-securityDispositionLabel``,
                          fields: Fields,
                          id: int,
                          priority: string,
                          title: string): ``email-securityPhishGuardReport`` =
        { content = content
          created_at = None
          disposition = disposition
          fields = fields
          id = id
          priority = priority
          tags = None
          title = title
          updated_at = None }

type ``email-securityPhishGuardReportTag`` =
    { category: string
      value: string }
    ///Creates an instance of email-securityPhishGuardReportTag with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (category: string, value: string): ``email-securityPhishGuardReportTag`` =
        { category = category; value = value }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Expecteddisposition =
    | [<CompiledName "NONE">] NONE
    | [<CompiledName "BULK">] BULK
    | [<CompiledName "MALICIOUS">] MALICIOUS
    | [<CompiledName "SPAM">] SPAM
    | [<CompiledName "SPOOF">] SPOOF
    | [<CompiledName "SUSPICIOUS">] SUSPICIOUS
    member this.Format() =
        match this with
        | NONE -> "NONE"
        | BULK -> "BULK"
        | MALICIOUS -> "MALICIOUS"
        | SPAM -> "SPAM"
        | SPOOF -> "SPOOF"
        | SUSPICIOUS -> "SUSPICIOUS"

type ``email-securityReclassifyRequest`` =
    { ///Base64 encoded content of the EML file.
      eml_content: Option<string>
      escalated_submission_id: Option<string>
      expected_disposition: Expecteddisposition }
    ///Creates an instance of email-securityReclassifyRequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (expected_disposition: Expecteddisposition): ``email-securityReclassifyRequest`` =
        { eml_content = None
          escalated_submission_id = None
          expected_disposition = expected_disposition }

type ``email-securityReleaseResponse`` =
    { delivered: Option<list<string>>
      failed: Option<list<string>>
      id: string
      undelivered: Option<list<string>> }
    ///Creates an instance of email-securityReleaseResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: string): ``email-securityReleaseResponse`` =
        { delivered = None
          failed = None
          id = id
          undelivered = None }

///A sending domain restriction that enforces TLS (Transport Layer Security) requirements for emails from specific domains. If TLS is required, mail without TLS from the specified domain will be dropped.
type ``email-securitySendingDomainRestriction`` =
    { comments: Option<string>
      created_at: Option<System.DateTimeOffset>
      ///Domain that requires TLS enforcement.
      domain: Option<string>
      ///Excluded subdomains that are exempt from TLS requirements.
      exclude: Option<list<string>>
      id: Option<string>
      modified_at: Option<System.DateTimeOffset> }
    ///Creates an instance of email-securitySendingDomainRestriction with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securitySendingDomainRestriction`` =
        { comments = None
          created_at = None
          domain = None
          exclude = None
          id = None
          modified_at = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Type =
    | [<CompiledName "Team">] Team
    | [<CompiledName "User">] User
    member this.Format() =
        match this with
        | Team -> "Team"
        | User -> "User"

type ``email-securitySubmission`` =
    { customer_status: Option<``email-securityCustomerStatus``>
      escalated_as: Option<``email-securityOptionalSubmissionDisposition``>
      escalated_at: Option<System.DateTimeOffset>
      escalated_by: Option<string>
      escalated_submission_id: Option<string>
      original_disposition: Option<``email-securityOptionalSubmissionDisposition``>
      original_edf_hash: Option<string>
      ///The postfix ID of the original message that was submitted
      original_postfix_id: Option<string>
      outcome: Option<string>
      outcome_disposition: Option<``email-securityOptionalSubmissionDisposition``>
      ///When the submission was requested (UTC).
      requested_at: System.DateTimeOffset
      requested_by: Option<string>
      requested_disposition: Option<``email-securityOptionalSubmissionDisposition``>
      status: Option<string>
      subject: Option<string>
      submission_id: string
      ///Whether the submission was created by a team member or an end user.
      ``type``: Option<Type> }
    ///Creates an instance of email-securitySubmission with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (requested_at: System.DateTimeOffset, submission_id: string): ``email-securitySubmission`` =
        { customer_status = None
          escalated_as = None
          escalated_at = None
          escalated_by = None
          escalated_submission_id = None
          original_disposition = None
          original_edf_hash = None
          original_postfix_id = None
          outcome = None
          outcome_disposition = None
          requested_at = requested_at
          requested_by = None
          requested_disposition = None
          status = None
          subject = None
          submission_id = submission_id
          ``type`` = None }

type ``email-securityThreatCategory`` =
    { description: Option<string>
      id: Option<int>
      name: Option<string> }
    ///Creates an instance of email-securityThreatCategory with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityThreatCategory`` =
        { description = None
          id = None
          name = None }

type ``email-securityTraceLine`` =
    { ///Line number in the trace log
      lineno: Option<int>
      logged_at: Option<System.DateTimeOffset>
      message: Option<string> }
    ///Creates an instance of email-securityTraceLine with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityTraceLine`` =
        { lineno = None
          logged_at = None
          message = None }

///A trusted email domain
type ``email-securityTrustedDomain`` =
    { comments: Option<string>
      created_at: Option<System.DateTimeOffset>
      id: Option<string>
      ///Select to prevent recently registered domains from triggering a Suspicious or Malicious disposition.
      is_recent: Option<bool>
      is_regex: Option<bool>
      ///Select for partner or other approved domains that have similar spelling to your connected domains. Prevents listed domains from triggering a Spoof disposition.
      is_similarity: Option<bool>
      modified_at: Option<System.DateTimeOffset>
      pattern: Option<string> }
    ///Creates an instance of email-securityTrustedDomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityTrustedDomain`` =
        { comments = None
          created_at = None
          id = None
          is_recent = None
          is_regex = None
          is_similarity = None
          modified_at = None
          pattern = None }

///Update an allow policy
type ``email-securityUpdateAllowPolicy`` =
    { comments: Option<string>
      created_at: Option<System.DateTimeOffset>
      id: Option<string>
      ///Messages from this sender will be exempted from Spam, Spoof and Bulk dispositions. Note - This will not exempt messages with Malicious or Suspicious dispositions.
      is_acceptable_sender: Option<bool>
      ///Messages to this recipient will bypass all detections
      is_exempt_recipient: Option<bool>
      is_regex: Option<bool>
      ///Messages from this sender will bypass all detections and link following
      is_trusted_sender: Option<bool>
      modified_at: Option<obj>
      pattern: Option<string>
      ///Type of pattern matching.
      ///Note: UNKNOWN is deprecated and cannot be used when creating or updating policies, but may be returned for existing entries.
      pattern_type: Option<``email-securityPatternType``>
      ///Enforce DMARC, SPF or DKIM authentication. When on, Email Security only honors policies that pass authentication.
      verify_sender: Option<bool> }
    ///Creates an instance of email-securityUpdateAllowPolicy with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityUpdateAllowPolicy`` =
        { comments = None
          created_at = None
          id = None
          is_acceptable_sender = None
          is_exempt_recipient = None
          is_regex = None
          is_trusted_sender = None
          modified_at = None
          pattern = None
          pattern_type = None
          verify_sender = None }

///Update a blocked sender pattern
type ``email-securityUpdateBlockedSender`` =
    { comments: Option<string>
      created_at: Option<System.DateTimeOffset>
      id: Option<string>
      is_regex: Option<bool>
      modified_at: Option<obj>
      pattern: Option<string>
      ///Type of pattern matching.
      ///Note: UNKNOWN is deprecated and cannot be used when creating or updating policies, but may be returned for existing entries.
      pattern_type: Option<``email-securityPatternType``> }
    ///Creates an instance of email-securityUpdateBlockedSender with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityUpdateBlockedSender`` =
        { comments = None
          created_at = None
          id = None
          is_regex = None
          modified_at = None
          pattern = None
          pattern_type = None }

type ``email-securityUpdateDomain`` =
    { allowed_delivery_modes: Option<list<``email-securityDeliveryMode``>>
      domain: Option<string>
      drop_dispositions: Option<list<``email-securityDispositionLabel``>>
      folder: Option<``email-securityScannableFolder``>
      integration_id: Option<System.Guid>
      ip_restrictions: Option<list<string>>
      lookback_hops: Option<int>
      regions: Option<list<``email-securityRegion``>>
      require_tls_inbound: Option<bool>
      require_tls_outbound: Option<bool>
      transport: Option<string> }
    ///Creates an instance of email-securityUpdateDomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityUpdateDomain`` =
        { allowed_delivery_modes = None
          domain = None
          drop_dispositions = None
          folder = None
          integration_id = None
          ip_restrictions = None
          lookback_hops = None
          regions = None
          require_tls_inbound = None
          require_tls_outbound = None
          transport = None }

///Update an impersonation registry entry
type ``email-securityUpdateImpersonationRegistry`` =
    { comments: Option<string>
      created_at: Option<System.DateTimeOffset>
      directory_id: Option<int>
      directory_node_id: Option<int>
      email: Option<string>
      id: Option<string>
      is_email_regex: Option<bool>
      modified_at: Option<obj>
      name: Option<string>
      provenance: Option<``email-securityProvenance``> }
    ///Creates an instance of email-securityUpdateImpersonationRegistry with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityUpdateImpersonationRegistry`` =
        { comments = None
          created_at = None
          directory_id = None
          directory_node_id = None
          email = None
          id = None
          is_email_regex = None
          modified_at = None
          name = None
          provenance = None }

///Update a sending domain restriction.
type ``email-securityUpdateSendingDomainRestriction`` =
    { comments: Option<string>
      created_at: Option<System.DateTimeOffset>
      ///Domain that requires TLS enforcement.
      domain: Option<string>
      ///Excluded subdomains that are exempt from TLS requirements.
      exclude: Option<list<string>>
      id: Option<string>
      modified_at: Option<obj> }
    ///Creates an instance of email-securityUpdateSendingDomainRestriction with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityUpdateSendingDomainRestriction`` =
        { comments = None
          created_at = None
          domain = None
          exclude = None
          id = None
          modified_at = None }

///Update a trusted domain
type ``email-securityUpdateTrustedDomain`` =
    { comments: Option<string>
      created_at: Option<System.DateTimeOffset>
      id: Option<string>
      ///Select to prevent recently registered domains from triggering a Suspicious or Malicious disposition.
      is_recent: Option<bool>
      is_regex: Option<bool>
      ///Select for partner or other approved domains that have similar spelling to your connected domains. Prevents listed domains from triggering a Spoof disposition.
      is_similarity: Option<bool>
      modified_at: Option<obj>
      pattern: Option<string> }
    ///Creates an instance of email-securityUpdateTrustedDomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityUpdateTrustedDomain`` =
        { comments = None
          created_at = None
          id = None
          is_recent = None
          is_regex = None
          is_similarity = None
          modified_at = None
          pattern = None }

///Update a URL rewrite ignore pattern. Only provided fields will be modified.
type ``email-securityUpdateUrlIgnorePattern`` =
    { ///Optional note describing the reason for the ignore pattern.
      comments: Option<string>
      ///Regular expression matching URLs that should not be rewritten.
      pattern: Option<string> }
    ///Creates an instance of email-securityUpdateUrlIgnorePattern with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityUpdateUrlIgnorePattern`` = { comments = None; pattern = None }

///A URL ignore pattern that exempts matching URLs from being rewritten by Email Security.
type ``email-securityUrlIgnorePattern`` =
    { ///Optional note describing the reason for the ignore pattern.
      comments: Option<string>
      created_at: System.DateTimeOffset
      id: string
      modified_at: Option<System.DateTimeOffset>
      ///Regular expression matching URLs that should not be rewritten.
      pattern: string }
    ///Creates an instance of email-securityUrlIgnorePattern with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (created_at: System.DateTimeOffset, id: string, pattern: string): ``email-securityUrlIgnorePattern`` =
        { comments = None
          created_at = created_at
          id = id
          modified_at = None
          pattern = pattern }

type ``email-securityValidation`` =
    { comment: Option<string>
      dkim: Option<``email-securityValidationStatus``>
      dmarc: Option<``email-securityValidationStatus``>
      spf: Option<``email-securityValidationStatus``> }
    ///Creates an instance of email-securityValidation with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityValidation`` =
        { comment = None
          dkim = None
          dmarc = None
          spf = None }

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
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of Resultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Resultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type ``email-securityapi-response-collection`` =
    { errors: Option<list<Errors>>
      messages: Option<list<Messages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<Resultinfo> }
    ///Creates an instance of email-securityapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityapi-response-collection`` =
        { errors = None
          messages = None
          success = None
          result_info = None }

type ``email-securityapi-response-commonErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of email-securityapi-response-commonErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityapi-response-commonErrorsSource`` = { pointer = None }

type ``email-securityapi-response-commonErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``email-securityapi-response-commonErrorsSource``> }
    ///Creates an instance of email-securityapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``email-securityapi-response-commonErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``email-securityapi-response-commonMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of email-securityapi-response-commonMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityapi-response-commonMessagesSource`` = { pointer = None }

type ``email-securityapi-response-commonMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``email-securityapi-response-commonMessagesSource``> }
    ///Creates an instance of email-securityapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``email-securityapi-response-commonMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``email-securityapi-response-common`` =
    { errors: list<``email-securityapi-response-commonErrors``>
      messages: list<``email-securityapi-response-commonMessages``>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of email-securityapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``email-securityapi-response-commonErrors``>,
                          messages: list<``email-securityapi-response-commonMessages``>,
                          success: bool): ``email-securityapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``email-securityapi-response-common-failure`` =
    { errors: list<Errors>
      messages: list<Messages>
      result: obj
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of email-securityapi-response-common-failure with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<Errors>,
                          messages: list<Messages>,
                          result: obj,
                          success: bool): ``email-securityapi-response-common-failure`` =
        { errors = errors
          messages = messages
          result = result
          success = success }

type ``email-securityapi-response-singleErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of email-securityapi-response-singleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityapi-response-singleErrorsSource`` = { pointer = None }

type ``email-securityapi-response-singleErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``email-securityapi-response-singleErrorsSource``> }
    ///Creates an instance of email-securityapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``email-securityapi-response-singleErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``email-securityapi-response-singleMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of email-securityapi-response-singleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityapi-response-singleMessagesSource`` = { pointer = None }

type ``email-securityapi-response-singleMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``email-securityapi-response-singleMessagesSource``> }
    ///Creates an instance of email-securityapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``email-securityapi-response-singleMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``email-securityapi-response-single`` =
    { errors: Option<list<``email-securityapi-response-singleErrors``>>
      messages: Option<list<``email-securityapi-response-singleMessages``>>
      ///Whether the API call was successful.
      success: Option<bool> }
    ///Creates an instance of email-securityapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``email-securityapi-response-single`` =
        { errors = None
          messages = None
          success = None }

type ``email-sendingEmailAddressObject`` =
    { ///Email address (e.g., 'user@example.com').
      address: string
      ///Display name for the email address (e.g., 'John Doe').
      name: string }
    ///Creates an instance of email-sendingEmailAddressObject with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (address: string, name: string): ``email-sendingEmailAddressObject`` =
        { address = address; name = name }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Disposition =
    | [<CompiledName "attachment">] Attachment
    member this.Format() =
        match this with
        | Attachment -> "attachment"

type ``email-sendingEmailAttachment`` =
    { ///Base64-encoded content of the attachment.
      content: string
      ///Must be 'attachment'. Indicates a standard file attachment.
      disposition: Disposition
      ///Filename for the attachment.
      filename: string
      ///MIME type of the attachment (e.g., 'application/pdf', 'text/plain').
      ``type``: string }
    ///Creates an instance of email-sendingEmailAttachment with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string, disposition: Disposition, filename: string, ``type``: string): ``email-sendingEmailAttachment`` =
        { content = content
          disposition = disposition
          filename = filename
          ``type`` = ``type`` }

type ``email-sendingEmailBuilder`` =
    { ///File attachments and inline images.
      attachments: Option<list<string>>
      ///BCC recipient(s). A single email string or an array of email strings.
      bcc: Option<obj>
      ///CC recipient(s). A single email string or an array of email strings.
      cc: Option<obj>
      ///Sender email address. Either a plain string or an object with address and name.
      from: obj
      ///Custom email headers as key-value pairs.
      headers: Option<Map<string, string>>
      ///HTML body of the email. At least one of text or html must be provided.
      html: Option<string>
      ///Reply-to address. Either a plain string or an object with address and name.
      reply_to: Option<obj>
      ///Email subject line.
      subject: string
      ///Plain text body of the email. At least one of text or html must be provided.
      text: Option<string>
      ///Recipient(s). A single email string or an array of email strings.
      ``to``: obj }
    ///Creates an instance of email-sendingEmailBuilder with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (from: obj, subject: string, ``to``: obj): ``email-sendingEmailBuilder`` =
        { attachments = None
          bcc = None
          cc = None
          from = from
          headers = None
          html = None
          reply_to = None
          subject = subject
          text = None
          ``to`` = ``to`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``email-sendingEmailInlineAttachmentDisposition`` =
    | [<CompiledName "inline">] Inline
    member this.Format() =
        match this with
        | Inline -> "inline"

type ``email-sendingEmailInlineAttachment`` =
    { ///Base64-encoded content of the attachment.
      content: string
      ///Content ID used to reference this attachment in HTML via cid: URI (e.g., &amp;lt;img src="cid:logo"&amp;gt;).
      content_id: string
      ///Must be 'inline'. Indicates the attachment is embedded in the email body.
      disposition: ``email-sendingEmailInlineAttachmentDisposition``
      ///Filename for the attachment.
      filename: string
      ///MIME type of the attachment (e.g., 'image/png', 'text/plain').
      ``type``: string }
    ///Creates an instance of email-sendingEmailInlineAttachment with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (content: string,
                          content_id: string,
                          disposition: ``email-sendingEmailInlineAttachmentDisposition``,
                          filename: string,
                          ``type``: string): ``email-sendingEmailInlineAttachment`` =
        { content = content
          content_id = content_id
          disposition = disposition
          filename = filename
          ``type`` = ``type`` }

type ``email-sendingEmailSendResponse`` =
    { ///Email addresses to which the message was delivered immediately.
      delivered: list<string>
      ///Email addresses that permanently bounced.
      permanent_bounces: list<string>
      ///Email addresses for which delivery was queued for later.
      queued: list<string> }
    ///Creates an instance of email-sendingEmailSendResponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (delivered: list<string>, permanent_bounces: list<string>, queued: list<string>): ``email-sendingEmailSendResponse`` =
        { delivered = delivered
          permanent_bounces = permanent_bounces
          queued = queued }

type ``email-sendingSendRawRequest`` =
    { ///Sender email address.
      from: string
      ///The full MIME-encoded email message. Should include standard RFC 5322 headers such as From, To, Subject, and Content-Type. The from and recipients fields in the request body control SMTP envelope routing; the From and To headers in the MIME message control what the recipient's email client displays.
      mime_message: string
      ///List of recipient email addresses.
      recipients: list<string> }
    ///Creates an instance of email-sendingSendRawRequest with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (from: string, mime_message: string, recipients: list<string>): ``email-sendingSendRawRequest`` =
        { from = from
          mime_message = mime_message
          recipients = recipients }

type emailaddresses =
    { ///The date and time the destination address has been created.
      created: Option<emailcreated>
      ///The contact email address of the user.
      email: Option<emailemail>
      ///Destination address identifier.
      id: Option<emaildestinationaddressidentifier>
      ///The date and time the destination address was last modified.
      modified: Option<emailmodified>
      ///The date and time the destination address has been verified. Null means not verified yet.
      verified: Option<emailverified> }
    ///Creates an instance of emailaddresses with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailaddresses =
        { created = None
          email = None
          id = None
          modified = None
          verified = None }

type ``emailapi-response-collectionErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of emailapi-response-collectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``emailapi-response-collectionErrorsSource`` = { pointer = None }

type ``emailapi-response-collectionErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``emailapi-response-collectionErrorsSource``> }
    ///Creates an instance of emailapi-response-collectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``emailapi-response-collectionErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``emailapi-response-collectionMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of emailapi-response-collectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``emailapi-response-collectionMessagesSource`` = { pointer = None }

type ``emailapi-response-collectionMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``emailapi-response-collectionMessagesSource``> }
    ///Creates an instance of emailapi-response-collectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``emailapi-response-collectionMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``emailapi-response-collectionResultinfo`` =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float>
      ///The number of total pages in the entire result set.
      total_pages: Option<float> }
    ///Creates an instance of emailapi-response-collectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``emailapi-response-collectionResultinfo`` =
        { count = None
          page = None
          per_page = None
          total_count = None
          total_pages = None }

type ``emailapi-response-collection`` =
    { errors: Option<list<``emailapi-response-collectionErrors``>>
      messages: Option<list<``emailapi-response-collectionMessages``>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<``emailapi-response-collectionResultinfo``> }
    ///Creates an instance of emailapi-response-collection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``emailapi-response-collection`` =
        { errors = None
          messages = None
          success = None
          result_info = None }

type ``emailapi-response-commonErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of emailapi-response-commonErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``emailapi-response-commonErrorsSource`` = { pointer = None }

type ``emailapi-response-commonErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``emailapi-response-commonErrorsSource``> }
    ///Creates an instance of emailapi-response-commonErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``emailapi-response-commonErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``emailapi-response-commonMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of emailapi-response-commonMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``emailapi-response-commonMessagesSource`` = { pointer = None }

type ``emailapi-response-commonMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``emailapi-response-commonMessagesSource``> }
    ///Creates an instance of emailapi-response-commonMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``emailapi-response-commonMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``emailapi-response-common`` =
    { errors: list<``emailapi-response-commonErrors``>
      messages: list<``emailapi-response-commonMessages``>
      ///Whether the API call was successful.
      success: bool }
    ///Creates an instance of emailapi-response-common with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<``emailapi-response-commonErrors``>,
                          messages: list<``emailapi-response-commonMessages``>,
                          success: bool): ``emailapi-response-common`` =
        { errors = errors
          messages = messages
          success = success }

type ``emailapi-response-singleErrorsSource`` =
    { pointer: Option<string> }
    ///Creates an instance of emailapi-response-singleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``emailapi-response-singleErrorsSource`` = { pointer = None }

type ``emailapi-response-singleErrors`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``emailapi-response-singleErrorsSource``> }
    ///Creates an instance of emailapi-response-singleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``emailapi-response-singleErrors`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``emailapi-response-singleMessagesSource`` =
    { pointer: Option<string> }
    ///Creates an instance of emailapi-response-singleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``emailapi-response-singleMessagesSource`` = { pointer = None }

type ``emailapi-response-singleMessages`` =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<``emailapi-response-singleMessagesSource``> }
    ///Creates an instance of emailapi-response-singleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): ``emailapi-response-singleMessages`` =
        { code = code
          documentation_url = None
          message = message
          source = None }

type ``emailapi-response-single`` =
    { errors: Option<list<``emailapi-response-singleErrors``>>
      messages: Option<list<``emailapi-response-singleMessages``>>
      ///Whether the API call was successful.
      success: Option<bool> }
    ///Creates an instance of emailapi-response-single with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ``emailapi-response-single`` =
        { errors = None
          messages = None
          success = None }

type emailcatchallrule =
    { ///List actions for the catch-all routing rule.
      actions: Option<``emailrulecatchall-actions``>
      ///Routing rule status.
      enabled: Option<emailruleenabled>
      ///Routing rule identifier.
      id: Option<emailruleidentifier>
      ///List of matchers for the catch-all routing rule.
      matchers: Option<``emailrulecatchall-matchers``>
      ///Routing rule name.
      name: Option<emailrulename> }
    ///Creates an instance of emailcatchallrule with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailcatchallrule =
        { actions = None
          enabled = None
          id = None
          matchers = None
          name = None }

type emailcatchallruleresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailcatchallruleresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailcatchallruleresponsesingleErrorsSource = { pointer = None }

type emailcatchallruleresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailcatchallruleresponsesingleErrorsSource> }
    ///Creates an instance of emailcatchallruleresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailcatchallruleresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailcatchallruleresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailcatchallruleresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailcatchallruleresponsesingleMessagesSource = { pointer = None }

type emailcatchallruleresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailcatchallruleresponsesingleMessagesSource> }
    ///Creates an instance of emailcatchallruleresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailcatchallruleresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailcatchallruleresponsesingle =
    { errors: Option<list<emailcatchallruleresponsesingleErrors>>
      messages: Option<list<emailcatchallruleresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<emailcatchallrule> }
    ///Creates an instance of emailcatchallruleresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailcatchallruleresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

type emailcreatedestinationaddressproperties =
    { ///The contact email address of the user.
      email: emailemail }
    ///Creates an instance of emailcreatedestinationaddressproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (email: emailemail): emailcreatedestinationaddressproperties = { email = email }

type emailcreateruleproperties =
    { ///List actions patterns.
      actions: emailruleactions
      ///Routing rule status.
      enabled: Option<emailruleenabled>
      ///Matching patterns to forward to your actions.
      matchers: emailrulematchers
      ///Routing rule name.
      name: Option<emailrulename>
      ///Priority of the routing rule.
      priority: Option<emailrulepriority> }
    ///Creates an instance of emailcreateruleproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (actions: emailruleactions, matchers: emailrulematchers): emailcreateruleproperties =
        { actions = actions
          enabled = None
          matchers = matchers
          name = None
          priority = None }

type emailcreatesendingsubdomainproperties =
    { ///The subdomain name. Must be within the zone.
      name: string }
    ///Creates an instance of emailcreatesendingsubdomainproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (name: string): emailcreatesendingsubdomainproperties = { name = name }

type emaildestinationaddressproperties =
    { ///The date and time the destination address has been created.
      created: Option<emailcreated>
      ///The contact email address of the user.
      email: Option<emailemail>
      ///Destination address identifier.
      id: Option<emaildestinationaddressidentifier>
      ///The date and time the destination address was last modified.
      modified: Option<emailmodified>
      ///The date and time the destination address has been verified. Null means not verified yet.
      verified: Option<emailverified> }
    ///Creates an instance of emaildestinationaddressproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildestinationaddressproperties =
        { created = None
          email = None
          id = None
          modified = None
          verified = None }

type emaildestinationaddressresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emaildestinationaddressresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildestinationaddressresponsesingleErrorsSource = { pointer = None }

type emaildestinationaddressresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emaildestinationaddressresponsesingleErrorsSource> }
    ///Creates an instance of emaildestinationaddressresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emaildestinationaddressresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emaildestinationaddressresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emaildestinationaddressresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildestinationaddressresponsesingleMessagesSource = { pointer = None }

type emaildestinationaddressresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emaildestinationaddressresponsesingleMessagesSource> }
    ///Creates an instance of emaildestinationaddressresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emaildestinationaddressresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emaildestinationaddressresponsesingle =
    { errors: list<emaildestinationaddressresponsesingleErrors>
      messages: list<emaildestinationaddressresponsesingleMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<emailaddresses> }
    ///Creates an instance of emaildestinationaddressresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emaildestinationaddressresponsesingleErrors>,
                          messages: list<emaildestinationaddressresponsesingleMessages>,
                          success: bool): emaildestinationaddressresponsesingle =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emaildestinationaddressesresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emaildestinationaddressesresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildestinationaddressesresponsecollectionErrorsSource = { pointer = None }

type emaildestinationaddressesresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emaildestinationaddressesresponsecollectionErrorsSource> }
    ///Creates an instance of emaildestinationaddressesresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emaildestinationaddressesresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emaildestinationaddressesresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emaildestinationaddressesresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildestinationaddressesresponsecollectionMessagesSource = { pointer = None }

type emaildestinationaddressesresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emaildestinationaddressesresponsecollectionMessagesSource> }
    ///Creates an instance of emaildestinationaddressesresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emaildestinationaddressesresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emaildestinationaddressesresponsecollectionResultinfo =
    { count: Option<obj>
      page: Option<obj>
      per_page: Option<obj>
      total_count: Option<obj> }
    ///Creates an instance of emaildestinationaddressesresponsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildestinationaddressesresponsecollectionResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type emaildestinationaddressesresponsecollection =
    { errors: list<emaildestinationaddressesresponsecollectionErrors>
      messages: list<emaildestinationaddressesresponsecollectionMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<emaildestinationaddressesresponsecollectionResultinfo>
      result: Option<list<emailaddresses>> }
    ///Creates an instance of emaildestinationaddressesresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emaildestinationaddressesresponsecollectionErrors>,
                          messages: list<emaildestinationaddressesresponsecollectionMessages>,
                          success: bool): emaildestinationaddressesresponsecollection =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type emaildnsrecordType =
    | [<CompiledName "A">] A
    | [<CompiledName "AAAA">] AAAA
    | [<CompiledName "CNAME">] CNAME
    | [<CompiledName "HTTPS">] HTTPS
    | [<CompiledName "TXT">] TXT
    | [<CompiledName "SRV">] SRV
    | [<CompiledName "LOC">] LOC
    | [<CompiledName "MX">] MX
    | [<CompiledName "NS">] NS
    | [<CompiledName "CERT">] CERT
    | [<CompiledName "DNSKEY">] DNSKEY
    | [<CompiledName "DS">] DS
    | [<CompiledName "NAPTR">] NAPTR
    | [<CompiledName "SMIMEA">] SMIMEA
    | [<CompiledName "SSHFP">] SSHFP
    | [<CompiledName "SVCB">] SVCB
    | [<CompiledName "TLSA">] TLSA
    | [<CompiledName "URI">] URI
    member this.Format() =
        match this with
        | A -> "A"
        | AAAA -> "AAAA"
        | CNAME -> "CNAME"
        | HTTPS -> "HTTPS"
        | TXT -> "TXT"
        | SRV -> "SRV"
        | LOC -> "LOC"
        | MX -> "MX"
        | NS -> "NS"
        | CERT -> "CERT"
        | DNSKEY -> "DNSKEY"
        | DS -> "DS"
        | NAPTR -> "NAPTR"
        | SMIMEA -> "SMIMEA"
        | SSHFP -> "SSHFP"
        | SVCB -> "SVCB"
        | TLSA -> "TLSA"
        | URI -> "URI"

///List of records needed to enable an Email Routing zone.
type emaildnsrecord =
    { ///DNS record content.
      content: Option<string>
      ///DNS record name (or @ for the zone apex).
      name: Option<string>
      ///Required for MX, SRV and URI records. Unused by other record types. Records with lower priorities are preferred.
      priority: Option<float>
      ///Time to live, in seconds, of the DNS record. Must be between 60 and 86400, or 1 for 'automatic'.
      ttl: Option<float>
      ///DNS record type.
      ``type``: Option<emaildnsrecordType> }
    ///Creates an instance of emaildnsrecord with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildnsrecord =
        { content = None
          name = None
          priority = None
          ttl = None
          ``type`` = None }

type emaildnssettingsresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emaildnssettingsresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildnssettingsresponsecollectionErrorsSource = { pointer = None }

type emaildnssettingsresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emaildnssettingsresponsecollectionErrorsSource> }
    ///Creates an instance of emaildnssettingsresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emaildnssettingsresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emaildnssettingsresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emaildnssettingsresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildnssettingsresponsecollectionMessagesSource = { pointer = None }

type emaildnssettingsresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emaildnssettingsresponsecollectionMessagesSource> }
    ///Creates an instance of emaildnssettingsresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emaildnssettingsresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emaildnssettingsresponsecollectionResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float>
      ///The number of total pages in the entire result set.
      total_pages: Option<float> }
    ///Creates an instance of emaildnssettingsresponsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildnssettingsresponsecollectionResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None
          total_pages = None }

type emaildnssettingsresponsecollection =
    { errors: Option<list<emaildnssettingsresponsecollectionErrors>>
      messages: Option<list<emaildnssettingsresponsecollectionMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<emaildnssettingsresponsecollectionResultinfo>
      result: Option<list<emaildnsrecord>> }
    ///Creates an instance of emaildnssettingsresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emaildnssettingsresponsecollection =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type emailemailroutingdnsqueryresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailemailroutingdnsqueryresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailroutingdnsqueryresponseErrorsSource = { pointer = None }

type emailemailroutingdnsqueryresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailemailroutingdnsqueryresponseErrorsSource> }
    ///Creates an instance of emailemailroutingdnsqueryresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailemailroutingdnsqueryresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailemailroutingdnsqueryresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailemailroutingdnsqueryresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailroutingdnsqueryresponseMessagesSource = { pointer = None }

type emailemailroutingdnsqueryresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailemailroutingdnsqueryresponseMessagesSource> }
    ///Creates an instance of emailemailroutingdnsqueryresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailemailroutingdnsqueryresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailemailroutingdnsqueryresponseResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float>
      ///The number of total pages in the entire result set.
      total_pages: Option<float> }
    ///Creates an instance of emailemailroutingdnsqueryresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailroutingdnsqueryresponseResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None
          total_pages = None }

type Result =
    { errors: Option<emailemailroutinggetresponsednserrors>
      record: Option<list<emaildnsrecord>> }
    ///Creates an instance of Result with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Result = { errors = None; record = None }

type emailemailroutingdnsqueryresponse =
    { errors: Option<list<emailemailroutingdnsqueryresponseErrors>>
      messages: Option<list<emailemailroutingdnsqueryresponseMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<emailemailroutingdnsqueryresponseResultinfo>
      result: Option<Result> }
    ///Creates an instance of emailemailroutingdnsqueryresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailroutingdnsqueryresponse =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type emailemailroutinggetresponsednserror =
    { code: Option<string>
      ///List of records needed to enable an Email Routing zone.
      missing: Option<emaildnsrecord> }
    ///Creates an instance of emailemailroutinggetresponsednserror with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailroutinggetresponsednserror = { code = None; missing = None }

type emailemailsettingdnsrequestbody =
    { ///Domain of your zone.
      name: Option<emailemailsettingname> }
    ///Creates an instance of emailemailsettingdnsrequestbody with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailsettingdnsrequestbody = { name = None }

type emailemailsettingsproperties =
    { ///The date and time the settings have been created.
      created: Option<emailemailsettingcreated>
      ///State of the zone settings for Email Routing.
      enabled: emailemailsettingenabled
      ///Email Routing settings identifier.
      id: emailemailsettingidentifier
      ///The date and time the settings have been modified.
      modified: Option<emailemailsettingmodified>
      ///Domain of your zone.
      name: emailemailsettingname
      ///Flag to check if the user skipped the configuration wizard.
      skip_wizard: Option<``emailemailsettingskip-wizard``>
      ///Show the state of your account, and the type or configuration error.
      status: Option<emailemailsettingstatus> }
    ///Creates an instance of emailemailsettingsproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enabled: emailemailsettingenabled,
                          id: emailemailsettingidentifier,
                          name: emailemailsettingname): emailemailsettingsproperties =
        { created = None
          enabled = enabled
          id = id
          modified = None
          name = name
          skip_wizard = None
          status = None }

type emailemailsettingsresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailemailsettingsresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailsettingsresponsesingleErrorsSource = { pointer = None }

type emailemailsettingsresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailemailsettingsresponsesingleErrorsSource> }
    ///Creates an instance of emailemailsettingsresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailemailsettingsresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailemailsettingsresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailemailsettingsresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailsettingsresponsesingleMessagesSource = { pointer = None }

type emailemailsettingsresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailemailsettingsresponsesingleMessagesSource> }
    ///Creates an instance of emailemailsettingsresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailemailsettingsresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailemailsettingsresponsesingle =
    { errors: Option<list<emailemailsettingsresponsesingleErrors>>
      messages: Option<list<emailemailsettingsresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<emailsettings> }
    ///Creates an instance of emailemailsettingsresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailemailsettingsresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type emailruleactionType =
    | [<CompiledName "drop">] Drop
    | [<CompiledName "forward">] Forward
    | [<CompiledName "worker">] Worker
    member this.Format() =
        match this with
        | Drop -> "drop"
        | Forward -> "forward"
        | Worker -> "worker"

///Actions pattern.
type emailruleaction =
    { ///Type of supported action.
      ``type``: emailruleactionType
      value: Option<list<string>> }
    ///Creates an instance of emailruleaction with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: emailruleactionType): emailruleaction = { ``type`` = ``type``; value = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``emailrulecatchall-actionType`` =
    | [<CompiledName "drop">] Drop
    | [<CompiledName "forward">] Forward
    | [<CompiledName "worker">] Worker
    member this.Format() =
        match this with
        | Drop -> "drop"
        | Forward -> "forward"
        | Worker -> "worker"

///Action for the catch-all routing rule.
type ``emailrulecatchall-action`` =
    { ///Type of action for catch-all rule.
      ``type``: ``emailrulecatchall-actionType``
      value: Option<list<string>> }
    ///Creates an instance of emailrulecatchall-action with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: ``emailrulecatchall-actionType``): ``emailrulecatchall-action`` =
        { ``type`` = ``type``; value = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ``emailrulecatchall-matcherType`` =
    | [<CompiledName "all">] All
    member this.Format() =
        match this with
        | All -> "all"

///Matcher for catch-all routing rule.
type ``emailrulecatchall-matcher`` =
    { ///Type of matcher. Default is 'all'.
      ``type``: ``emailrulecatchall-matcherType`` }
    ///Creates an instance of emailrulecatchall-matcher with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: ``emailrulecatchall-matcherType``): ``emailrulecatchall-matcher`` =
        { ``type`` = ``type`` }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Field =
    | [<CompiledName "to">] To
    member this.Format() =
        match this with
        | To -> "to"

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type emailrulematcherType =
    | [<CompiledName "all">] All
    | [<CompiledName "literal">] Literal
    member this.Format() =
        match this with
        | All -> "all"
        | Literal -> "literal"

///Matching pattern to forward your actions.
type emailrulematcher =
    { ///Field for type matcher.
      field: Option<Field>
      ///Type of matcher.
      ``type``: emailrulematcherType
      ///Value for matcher.
      value: Option<string> }
    ///Creates an instance of emailrulematcher with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (``type``: emailrulematcherType): emailrulematcher =
        { field = None
          ``type`` = ``type``
          value = None }

type emailruleproperties =
    { ///List actions patterns.
      actions: Option<emailruleactions>
      ///Routing rule status.
      enabled: Option<emailruleenabled>
      ///Routing rule identifier.
      id: Option<emailruleidentifier>
      ///Matching patterns to forward to your actions.
      matchers: Option<emailrulematchers>
      ///Routing rule name.
      name: Option<emailrulename>
      ///Priority of the routing rule.
      priority: Option<emailrulepriority> }
    ///Creates an instance of emailruleproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailruleproperties =
        { actions = None
          enabled = None
          id = None
          matchers = None
          name = None
          priority = None }

type emailruleresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailruleresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailruleresponsesingleErrorsSource = { pointer = None }

type emailruleresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailruleresponsesingleErrorsSource> }
    ///Creates an instance of emailruleresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailruleresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailruleresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailruleresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailruleresponsesingleMessagesSource = { pointer = None }

type emailruleresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailruleresponsesingleMessagesSource> }
    ///Creates an instance of emailruleresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailruleresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailruleresponsesingle =
    { errors: Option<list<emailruleresponsesingleErrors>>
      messages: Option<list<emailruleresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<emailrules> }
    ///Creates an instance of emailruleresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailruleresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

type emailrules =
    { ///List actions patterns.
      actions: Option<emailruleactions>
      ///Routing rule status.
      enabled: Option<emailruleenabled>
      ///Routing rule identifier.
      id: Option<emailruleidentifier>
      ///Matching patterns to forward to your actions.
      matchers: Option<emailrulematchers>
      ///Routing rule name.
      name: Option<emailrulename>
      ///Priority of the routing rule.
      priority: Option<emailrulepriority> }
    ///Creates an instance of emailrules with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailrules =
        { actions = None
          enabled = None
          id = None
          matchers = None
          name = None
          priority = None }

type emailrulesresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailrulesresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailrulesresponsecollectionErrorsSource = { pointer = None }

type emailrulesresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailrulesresponsecollectionErrorsSource> }
    ///Creates an instance of emailrulesresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailrulesresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailrulesresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailrulesresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailrulesresponsecollectionMessagesSource = { pointer = None }

type emailrulesresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailrulesresponsecollectionMessagesSource> }
    ///Creates an instance of emailrulesresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailrulesresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailrulesresponsecollectionResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float>
      ///The number of total pages in the entire result set.
      total_pages: Option<float> }
    ///Creates an instance of emailrulesresponsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailrulesresponsecollectionResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None
          total_pages = None }

type ResultinfoFromemailrulesresponsecollection =
    { count: Option<obj>
      page: Option<obj>
      per_page: Option<obj>
      total_count: Option<obj> }
    ///Creates an instance of ResultinfoFromemailrulesresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): ResultinfoFromemailrulesresponsecollection =
        { count = None
          page = None
          per_page = None
          total_count = None }

type emailrulesresponsecollection =
    { errors: Option<list<emailrulesresponsecollectionErrors>>
      messages: Option<list<emailrulesresponsecollectionMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<emailrulesresponsecollectionResultinfo>
      result: Option<list<emailrules>> }
    ///Creates an instance of emailrulesresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailrulesresponsecollection =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Unit =
    | [<CompiledName "day">] Day
    | [<CompiledName "hour">] Hour
    member this.Format() =
        match this with
        | Day -> "day"
        | Hour -> "hour"

///The resolved daily sending quota for the account. Null when the quota is not yet available.
type Quota =
    { ///The time period for the quota.
      unit: Option<Unit>
      ///The quota limit.
      value: Option<int> }
    ///Creates an instance of Quota with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): Quota = { unit = None; value = None }

type emailsendinglimitsproperties =
    { ///The resolved daily sending quota for the account. Null when the quota is not yet available.
      quota: Option<Quota> }
    ///Creates an instance of emailsendinglimitsproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendinglimitsproperties = { quota = None }

type emailsendinglimitsresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsendinglimitsresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendinglimitsresponsesingleErrorsSource = { pointer = None }

type emailsendinglimitsresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsendinglimitsresponsesingleErrorsSource> }
    ///Creates an instance of emailsendinglimitsresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsendinglimitsresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsendinglimitsresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsendinglimitsresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendinglimitsresponsesingleMessagesSource = { pointer = None }

type emailsendinglimitsresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsendinglimitsresponsesingleMessagesSource> }
    ///Creates an instance of emailsendinglimitsresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsendinglimitsresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsendinglimitsresponsesingle =
    { errors: list<emailsendinglimitsresponsesingleErrors>
      messages: list<emailsendinglimitsresponsesingleMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<emailsendinglimitsproperties> }
    ///Creates an instance of emailsendinglimitsresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsendinglimitsresponsesingleErrors>,
                          messages: list<emailsendinglimitsresponsesingleMessages>,
                          success: bool): emailsendinglimitsresponsesingle =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsendingsubdomain =
    { ///The date and time the destination address has been created.
      created: Option<emailcreated>
      ///The DKIM selector used for email signing.
      dkim_selector: Option<string>
      ///Whether Email Sending is enabled on this subdomain.
      enabled: Option<bool>
      ///The date and time the destination address was last modified.
      modified: Option<emailmodified>
      ///The subdomain domain name.
      name: Option<string>
      ///The return-path domain used for bounce handling.
      return_path_domain: Option<string>
      ///Sending subdomain identifier.
      tag: Option<emailsendingsubdomainidentifier> }
    ///Creates an instance of emailsendingsubdomain with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomain =
        { created = None
          dkim_selector = None
          enabled = None
          modified = None
          name = None
          return_path_domain = None
          tag = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Code =
    | [<CompiledName "mx.missing">] MxMissing
    | [<CompiledName "mx.foreign">] MxForeign
    | [<CompiledName "spf.missing">] SpfMissing
    | [<CompiledName "spf.foreign">] SpfForeign
    | [<CompiledName "spf.multiple">] SpfMultiple
    | [<CompiledName "dkim.missing">] DkimMissing
    | [<CompiledName "dkim.conflict">] DkimConflict
    | [<CompiledName "dmarc.missing">] DmarcMissing
    | [<CompiledName "dmarc.multiple">] DmarcMultiple
    member this.Format() =
        match this with
        | MxMissing -> "mx.missing"
        | MxForeign -> "mx.foreign"
        | SpfMissing -> "spf.missing"
        | SpfForeign -> "spf.foreign"
        | SpfMultiple -> "spf.multiple"
        | DkimMissing -> "dkim.missing"
        | DkimConflict -> "dkim.conflict"
        | DmarcMissing -> "dmarc.missing"
        | DmarcMultiple -> "dmarc.multiple"

///A DNS record status detected during preview, status, or fix.
type emailsendingsubdomainconfigerror =
    { ///Error code identifying the type of issue. `dkim.conflict` is
      ///reported whenever 2+ TXT records exist at the DKIM selector,
      ///even if one matches the canonical Cloudflare content — multi-record
      ///DKIM can permerror at recipient verification regardless of which
      ///entry is correct.
      code: Code
      ///List of records needed to enable an Email Routing zone.
      existing: Option<emaildnsrecord>
      ///List of records needed to enable an Email Routing zone.
      missing: Option<emaildnsrecord>
      multiple: Option<list<emaildnsrecord>> }
    ///Creates an instance of emailsendingsubdomainconfigerror with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: Code): emailsendingsubdomainconfigerror =
        { code = code
          existing = None
          missing = None
          multiple = None }

type emailsendingsubdomaindnsstatusresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsendingsubdomaindnsstatusresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomaindnsstatusresponseErrorsSource = { pointer = None }

type emailsendingsubdomaindnsstatusresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsendingsubdomaindnsstatusresponseErrorsSource> }
    ///Creates an instance of emailsendingsubdomaindnsstatusresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsendingsubdomaindnsstatusresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsendingsubdomaindnsstatusresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsendingsubdomaindnsstatusresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomaindnsstatusresponseMessagesSource = { pointer = None }

type emailsendingsubdomaindnsstatusresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsendingsubdomaindnsstatusresponseMessagesSource> }
    ///Creates an instance of emailsendingsubdomaindnsstatusresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsendingsubdomaindnsstatusresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Status =
    | [<CompiledName "ready">] Ready
    | [<CompiledName "unconfigured">] Unconfigured
    | [<CompiledName "unlocked">] Unlocked
    | [<CompiledName "misconfigured">] Misconfigured
    member this.Format() =
        match this with
        | Ready -> "ready"
        | Unconfigured -> "unconfigured"
        | Unlocked -> "unlocked"
        | Misconfigured -> "misconfigured"

type emailsendingsubdomaindnsstatusresponseResult =
    { ///DNS issues detected against the current zone state.
      errors: Option<list<emailsendingsubdomainconfigerror>>
      ///Desired DNS records for the subdomain.
      records: Option<list<emaildnsrecord>>
      ///Aggregated DNS state for the subdomain. `unlocked` means desired records exist with correct content but at least one has had its email_routing/read_only lock cleared.
      status: Option<Status> }
    ///Creates an instance of emailsendingsubdomaindnsstatusresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomaindnsstatusresponseResult =
        { errors = None
          records = None
          status = None }

type emailsendingsubdomaindnsstatusresponse =
    { errors: Option<list<emailsendingsubdomaindnsstatusresponseErrors>>
      messages: Option<list<emailsendingsubdomaindnsstatusresponseMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<emailsendingsubdomaindnsstatusresponseResult> }
    ///Creates an instance of emailsendingsubdomaindnsstatusresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomaindnsstatusresponse =
        { errors = None
          messages = None
          success = None
          result = None }

type emailsendingsubdomainpreviewresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsendingsubdomainpreviewresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainpreviewresponseErrorsSource = { pointer = None }

type emailsendingsubdomainpreviewresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsendingsubdomainpreviewresponseErrorsSource> }
    ///Creates an instance of emailsendingsubdomainpreviewresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsendingsubdomainpreviewresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsendingsubdomainpreviewresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsendingsubdomainpreviewresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainpreviewresponseMessagesSource = { pointer = None }

type emailsendingsubdomainpreviewresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsendingsubdomainpreviewresponseMessagesSource> }
    ///Creates an instance of emailsendingsubdomainpreviewresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsendingsubdomainpreviewresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsendingsubdomainpreviewresponseResult =
    { ///DNS issues detected — missing records that will be created and conflicts with existing records.
      errors: Option<list<emailsendingsubdomainconfigerror>>
      ///DNS records that would be created for the subdomain.
      records: Option<list<emaildnsrecord>> }
    ///Creates an instance of emailsendingsubdomainpreviewresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainpreviewresponseResult = { errors = None; records = None }

type emailsendingsubdomainpreviewresponse =
    { errors: Option<list<emailsendingsubdomainpreviewresponseErrors>>
      messages: Option<list<emailsendingsubdomainpreviewresponseMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<emailsendingsubdomainpreviewresponseResult> }
    ///Creates an instance of emailsendingsubdomainpreviewresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainpreviewresponse =
        { errors = None
          messages = None
          success = None
          result = None }

type emailsendingsubdomainproperties =
    { ///The date and time the destination address has been created.
      created: Option<emailcreated>
      ///The DKIM selector used for email signing.
      dkim_selector: Option<string>
      ///Whether Email Sending is enabled on this subdomain.
      enabled: bool
      ///The date and time the destination address was last modified.
      modified: Option<emailmodified>
      ///The subdomain domain name.
      name: string
      ///The return-path domain used for bounce handling.
      return_path_domain: Option<string>
      ///Sending subdomain identifier.
      tag: emailsendingsubdomainidentifier }
    ///Creates an instance of emailsendingsubdomainproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (enabled: bool, name: string, tag: emailsendingsubdomainidentifier): emailsendingsubdomainproperties =
        { created = None
          dkim_selector = None
          enabled = enabled
          modified = None
          name = name
          return_path_domain = None
          tag = tag }

type emailsendingsubdomainresponsesingleErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsendingsubdomainresponsesingleErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainresponsesingleErrorsSource = { pointer = None }

type emailsendingsubdomainresponsesingleErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsendingsubdomainresponsesingleErrorsSource> }
    ///Creates an instance of emailsendingsubdomainresponsesingleErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsendingsubdomainresponsesingleErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsendingsubdomainresponsesingleMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsendingsubdomainresponsesingleMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainresponsesingleMessagesSource = { pointer = None }

type emailsendingsubdomainresponsesingleMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsendingsubdomainresponsesingleMessagesSource> }
    ///Creates an instance of emailsendingsubdomainresponsesingleMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsendingsubdomainresponsesingleMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsendingsubdomainresponsesingle =
    { errors: Option<list<emailsendingsubdomainresponsesingleErrors>>
      messages: Option<list<emailsendingsubdomainresponsesingleMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result: Option<obj> }
    ///Creates an instance of emailsendingsubdomainresponsesingle with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainresponsesingle =
        { errors = None
          messages = None
          success = None
          result = None }

type emailsendingsubdomainsresponsecollectionErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsendingsubdomainsresponsecollectionErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainsresponsecollectionErrorsSource = { pointer = None }

type emailsendingsubdomainsresponsecollectionErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsendingsubdomainsresponsecollectionErrorsSource> }
    ///Creates an instance of emailsendingsubdomainsresponsecollectionErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsendingsubdomainsresponsecollectionErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsendingsubdomainsresponsecollectionMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsendingsubdomainsresponsecollectionMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainsresponsecollectionMessagesSource = { pointer = None }

type emailsendingsubdomainsresponsecollectionMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsendingsubdomainsresponsecollectionMessagesSource> }
    ///Creates an instance of emailsendingsubdomainsresponsecollectionMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsendingsubdomainsresponsecollectionMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsendingsubdomainsresponsecollectionResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float>
      ///The number of total pages in the entire result set.
      total_pages: Option<float> }
    ///Creates an instance of emailsendingsubdomainsresponsecollectionResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainsresponsecollectionResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None
          total_pages = None }

type emailsendingsubdomainsresponsecollection =
    { errors: Option<list<emailsendingsubdomainsresponsecollectionErrors>>
      messages: Option<list<emailsendingsubdomainsresponsecollectionMessages>>
      ///Whether the API call was successful.
      success: Option<bool>
      result_info: Option<emailsendingsubdomainsresponsecollectionResultinfo>
      result: Option<list<emailsendingsubdomain>> }
    ///Creates an instance of emailsendingsubdomainsresponsecollection with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsendingsubdomainsresponsecollection =
        { errors = None
          messages = None
          success = None
          result_info = None
          result = None }

type emailsettings =
    { ///The date and time the settings have been created.
      created: Option<emailemailsettingcreated>
      ///State of the zone settings for Email Routing.
      enabled: Option<emailemailsettingenabled>
      ///Email Routing settings identifier.
      id: Option<emailemailsettingidentifier>
      ///The date and time the settings have been modified.
      modified: Option<emailemailsettingmodified>
      ///Domain of your zone.
      name: Option<emailemailsettingname>
      ///Flag to check if the user skipped the configuration wizard.
      skip_wizard: Option<``emailemailsettingskip-wizard``>
      ///Show the state of your account, and the type or configuration error.
      status: Option<emailemailsettingstatus> }
    ///Creates an instance of emailsettings with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsettings =
        { created = None
          enabled = None
          id = None
          modified = None
          name = None
          skip_wizard = None
          status = None }

type emailupdatecatchallruleproperties =
    { ///List actions for the catch-all routing rule.
      actions: ``emailrulecatchall-actions``
      ///Routing rule status.
      enabled: Option<emailruleenabled>
      ///List of matchers for the catch-all routing rule.
      matchers: ``emailrulecatchall-matchers``
      ///Routing rule name.
      name: Option<emailrulename> }
    ///Creates an instance of emailupdatecatchallruleproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (actions: ``emailrulecatchall-actions``, matchers: ``emailrulecatchall-matchers``): emailupdatecatchallruleproperties =
        { actions = actions
          enabled = None
          matchers = matchers
          name = None }

type emailupdateruleproperties =
    { ///List actions patterns.
      actions: emailruleactions
      ///Routing rule status.
      enabled: Option<emailruleenabled>
      ///Matching patterns to forward to your actions.
      matchers: emailrulematchers
      ///Routing rule name.
      name: Option<emailrulename>
      ///Priority of the routing rule.
      priority: Option<emailrulepriority> }
    ///Creates an instance of emailupdateruleproperties with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (actions: emailruleactions, matchers: emailrulematchers): emailupdateruleproperties =
        { actions = actions
          enabled = None
          matchers = matchers
          name = None
          priority = None }

type emailsecurityinvestigateresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecurityinvestigateresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecurityinvestigateresponseErrorsSource = { pointer = None }

type emailsecurityinvestigateresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecurityinvestigateresponseErrorsSource> }
    ///Creates an instance of emailsecurityinvestigateresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecurityinvestigateresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecurityinvestigateresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecurityinvestigateresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecurityinvestigateresponseMessagesSource = { pointer = None }

type emailsecurityinvestigateresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecurityinvestigateresponseMessagesSource> }
    ///Creates an instance of emailsecurityinvestigateresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecurityinvestigateresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecurityinvestigateresponse =
    { errors: list<emailsecurityinvestigateresponseErrors>
      messages: list<emailsecurityinvestigateresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///Always empty on 202; follow the Location header to retrieve results.
      result: list<string>
      result_info: ``email-securityCursorResultInfo`` }
    ///Creates an instance of emailsecurityinvestigateresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecurityinvestigateresponseErrors>,
                          messages: list<emailsecurityinvestigateresponseMessages>,
                          success: bool,
                          result: list<string>,
                          result_info: ``email-securityCursorResultInfo``): emailsecurityinvestigateresponse =
        { errors = errors
          messages = messages
          success = success
          result = result
          result_info = result_info }

type emailsecuritypostbulkmoveresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritypostbulkmoveresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritypostbulkmoveresponseErrorsSource = { pointer = None }

type emailsecuritypostbulkmoveresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritypostbulkmoveresponseErrorsSource> }
    ///Creates an instance of emailsecuritypostbulkmoveresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritypostbulkmoveresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritypostbulkmoveresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritypostbulkmoveresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritypostbulkmoveresponseMessagesSource = { pointer = None }

type emailsecuritypostbulkmoveresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritypostbulkmoveresponseMessagesSource> }
    ///Creates an instance of emailsecuritypostbulkmoveresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritypostbulkmoveresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritypostbulkmoveresponse =
    { errors: list<emailsecuritypostbulkmoveresponseErrors>
      messages: list<emailsecuritypostbulkmoveresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: list<``email-securityMoveResponseItem``> }
    ///Creates an instance of emailsecuritypostbulkmoveresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritypostbulkmoveresponseErrors>,
                          messages: list<emailsecuritypostbulkmoveresponseMessages>,
                          success: bool,
                          result: list<``email-securityMoveResponseItem``>): emailsecuritypostbulkmoveresponse =
        { errors = errors
          messages = messages
          success = success
          result = result }

type emailsecuritypostpreviewresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritypostpreviewresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritypostpreviewresponseErrorsSource = { pointer = None }

type emailsecuritypostpreviewresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritypostpreviewresponseErrorsSource> }
    ///Creates an instance of emailsecuritypostpreviewresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritypostpreviewresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritypostpreviewresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritypostpreviewresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritypostpreviewresponseMessagesSource = { pointer = None }

type emailsecuritypostpreviewresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritypostpreviewresponseMessagesSource> }
    ///Creates an instance of emailsecuritypostpreviewresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritypostpreviewresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritypostpreviewresponse =
    { errors: list<emailsecuritypostpreviewresponseErrors>
      messages: list<emailsecuritypostpreviewresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: ``email-securityMessagePreview`` }
    ///Creates an instance of emailsecuritypostpreviewresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritypostpreviewresponseErrors>,
                          messages: list<emailsecuritypostpreviewresponseMessages>,
                          success: bool,
                          result: ``email-securityMessagePreview``): emailsecuritypostpreviewresponse =
        { errors = errors
          messages = messages
          success = success
          result = result }

type emailsecuritypostreleaseresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritypostreleaseresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritypostreleaseresponseErrorsSource = { pointer = None }

type emailsecuritypostreleaseresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritypostreleaseresponseErrorsSource> }
    ///Creates an instance of emailsecuritypostreleaseresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritypostreleaseresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritypostreleaseresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritypostreleaseresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritypostreleaseresponseMessagesSource = { pointer = None }

type emailsecuritypostreleaseresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritypostreleaseresponseMessagesSource> }
    ///Creates an instance of emailsecuritypostreleaseresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritypostreleaseresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritypostreleaseresponse =
    { errors: list<emailsecuritypostreleaseresponseErrors>
      messages: list<emailsecuritypostreleaseresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: list<``email-securityReleaseResponse``> }
    ///Creates an instance of emailsecuritypostreleaseresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritypostreleaseresponseErrors>,
                          messages: list<emailsecuritypostreleaseresponseMessages>,
                          success: bool,
                          result: list<``email-securityReleaseResponse``>): emailsecuritypostreleaseresponse =
        { errors = errors
          messages = messages
          success = success
          result = result }

type emailsecuritygetmessageresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetmessageresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetmessageresponseErrorsSource = { pointer = None }

type emailsecuritygetmessageresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetmessageresponseErrorsSource> }
    ///Creates an instance of emailsecuritygetmessageresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetmessageresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetmessageresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetmessageresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetmessageresponseMessagesSource = { pointer = None }

type emailsecuritygetmessageresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetmessageresponseMessagesSource> }
    ///Creates an instance of emailsecuritygetmessageresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetmessageresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetmessageresponse =
    { errors: list<emailsecuritygetmessageresponseErrors>
      messages: list<emailsecuritygetmessageresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: ``email-securityMessageDetails`` }
    ///Creates an instance of emailsecuritygetmessageresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritygetmessageresponseErrors>,
                          messages: list<emailsecuritygetmessageresponseMessages>,
                          success: bool,
                          result: ``email-securityMessageDetails``): emailsecuritygetmessageresponse =
        { errors = errors
          messages = messages
          success = success
          result = result }

type emailsecuritygetmessageactionlogresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetmessageactionlogresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetmessageactionlogresponseErrorsSource = { pointer = None }

type emailsecuritygetmessageactionlogresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetmessageactionlogresponseErrorsSource> }
    ///Creates an instance of emailsecuritygetmessageactionlogresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetmessageactionlogresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetmessageactionlogresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetmessageactionlogresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetmessageactionlogresponseMessagesSource = { pointer = None }

type emailsecuritygetmessageactionlogresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetmessageactionlogresponseMessagesSource> }
    ///Creates an instance of emailsecuritygetmessageactionlogresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetmessageactionlogresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetmessageactionlogresponse =
    { errors: list<emailsecuritygetmessageactionlogresponseErrors>
      messages: list<emailsecuritygetmessageactionlogresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: list<``email-securityActionEntry``> }
    ///Creates an instance of emailsecuritygetmessageactionlogresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritygetmessageactionlogresponseErrors>,
                          messages: list<emailsecuritygetmessageactionlogresponseMessages>,
                          success: bool,
                          result: list<``email-securityActionEntry``>): emailsecuritygetmessageactionlogresponse =
        { errors = errors
          messages = messages
          success = success
          result = result }

type emailsecuritygetmessagedetectionsresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetmessagedetectionsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetmessagedetectionsresponseErrorsSource = { pointer = None }

type emailsecuritygetmessagedetectionsresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetmessagedetectionsresponseErrorsSource> }
    ///Creates an instance of emailsecuritygetmessagedetectionsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetmessagedetectionsresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetmessagedetectionsresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetmessagedetectionsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetmessagedetectionsresponseMessagesSource = { pointer = None }

type emailsecuritygetmessagedetectionsresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetmessagedetectionsresponseMessagesSource> }
    ///Creates an instance of emailsecuritygetmessagedetectionsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetmessagedetectionsresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetmessagedetectionsresponse =
    { errors: list<emailsecuritygetmessagedetectionsresponseErrors>
      messages: list<emailsecuritygetmessagedetectionsresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: ``email-securityMessageDetectionDetails`` }
    ///Creates an instance of emailsecuritygetmessagedetectionsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritygetmessagedetectionsresponseErrors>,
                          messages: list<emailsecuritygetmessagedetectionsresponseMessages>,
                          success: bool,
                          result: ``email-securityMessageDetectionDetails``): emailsecuritygetmessagedetectionsresponse =
        { errors = errors
          messages = messages
          success = success
          result = result }

type emailsecuritypostmessagemoveresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritypostmessagemoveresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritypostmessagemoveresponseErrorsSource = { pointer = None }

type emailsecuritypostmessagemoveresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritypostmessagemoveresponseErrorsSource> }
    ///Creates an instance of emailsecuritypostmessagemoveresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritypostmessagemoveresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritypostmessagemoveresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritypostmessagemoveresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritypostmessagemoveresponseMessagesSource = { pointer = None }

type emailsecuritypostmessagemoveresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritypostmessagemoveresponseMessagesSource> }
    ///Creates an instance of emailsecuritypostmessagemoveresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritypostmessagemoveresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritypostmessagemoveresponse =
    { errors: list<emailsecuritypostmessagemoveresponseErrors>
      messages: list<emailsecuritypostmessagemoveresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: list<``email-securityMoveResponseItem``> }
    ///Creates an instance of emailsecuritypostmessagemoveresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritypostmessagemoveresponseErrors>,
                          messages: list<emailsecuritypostmessagemoveresponseMessages>,
                          success: bool,
                          result: list<``email-securityMoveResponseItem``>): emailsecuritypostmessagemoveresponse =
        { errors = errors
          messages = messages
          success = success
          result = result }

type emailsecuritygetmessagepreviewresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetmessagepreviewresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetmessagepreviewresponseErrorsSource = { pointer = None }

type emailsecuritygetmessagepreviewresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetmessagepreviewresponseErrorsSource> }
    ///Creates an instance of emailsecuritygetmessagepreviewresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetmessagepreviewresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetmessagepreviewresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetmessagepreviewresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetmessagepreviewresponseMessagesSource = { pointer = None }

type emailsecuritygetmessagepreviewresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetmessagepreviewresponseMessagesSource> }
    ///Creates an instance of emailsecuritygetmessagepreviewresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetmessagepreviewresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetmessagepreviewresponse =
    { errors: list<emailsecuritygetmessagepreviewresponseErrors>
      messages: list<emailsecuritygetmessagepreviewresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: ``email-securityMessagePreview`` }
    ///Creates an instance of emailsecuritygetmessagepreviewresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritygetmessagepreviewresponseErrors>,
                          messages: list<emailsecuritygetmessagepreviewresponseMessages>,
                          success: bool,
                          result: ``email-securityMessagePreview``): emailsecuritygetmessagepreviewresponse =
        { errors = errors
          messages = messages
          success = success
          result = result }

type emailsecuritygetmessagerawresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetmessagerawresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetmessagerawresponseErrorsSource = { pointer = None }

type emailsecuritygetmessagerawresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetmessagerawresponseErrorsSource> }
    ///Creates an instance of emailsecuritygetmessagerawresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetmessagerawresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetmessagerawresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetmessagerawresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetmessagerawresponseMessagesSource = { pointer = None }

type emailsecuritygetmessagerawresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetmessagerawresponseMessagesSource> }
    ///Creates an instance of emailsecuritygetmessagerawresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetmessagerawresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetmessagerawresponse =
    { errors: list<emailsecuritygetmessagerawresponseErrors>
      messages: list<emailsecuritygetmessagerawresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: ``email-securityMessageRaw`` }
    ///Creates an instance of emailsecuritygetmessagerawresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritygetmessagerawresponseErrors>,
                          messages: list<emailsecuritygetmessagerawresponseMessages>,
                          success: bool,
                          result: ``email-securityMessageRaw``): emailsecuritygetmessagerawresponse =
        { errors = errors
          messages = messages
          success = success
          result = result }

type emailsecuritypostreclassifyresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritypostreclassifyresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritypostreclassifyresponseErrorsSource = { pointer = None }

type emailsecuritypostreclassifyresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritypostreclassifyresponseErrorsSource> }
    ///Creates an instance of emailsecuritypostreclassifyresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritypostreclassifyresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritypostreclassifyresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritypostreclassifyresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritypostreclassifyresponseMessagesSource = { pointer = None }

type emailsecuritypostreclassifyresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritypostreclassifyresponseMessagesSource> }
    ///Creates an instance of emailsecuritypostreclassifyresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritypostreclassifyresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritypostreclassifyresponse =
    { errors: list<emailsecuritypostreclassifyresponseErrors>
      messages: list<emailsecuritypostreclassifyresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Map<string, obj> }
    ///Creates an instance of emailsecuritypostreclassifyresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritypostreclassifyresponseErrors>,
                          messages: list<emailsecuritypostreclassifyresponseMessages>,
                          success: bool,
                          result: Map<string, obj>): emailsecuritypostreclassifyresponse =
        { errors = errors
          messages = messages
          success = success
          result = result }

type emailsecuritygetmessagetraceresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetmessagetraceresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetmessagetraceresponseErrorsSource = { pointer = None }

type emailsecuritygetmessagetraceresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetmessagetraceresponseErrorsSource> }
    ///Creates an instance of emailsecuritygetmessagetraceresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetmessagetraceresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetmessagetraceresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetmessagetraceresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetmessagetraceresponseMessagesSource = { pointer = None }

type emailsecuritygetmessagetraceresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetmessagetraceresponseMessagesSource> }
    ///Creates an instance of emailsecuritygetmessagetraceresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetmessagetraceresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetmessagetraceresponse =
    { errors: list<emailsecuritygetmessagetraceresponseErrors>
      messages: list<emailsecuritygetmessagetraceresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: ``email-securityMessageTrace`` }
    ///Creates an instance of emailsecuritygetmessagetraceresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritygetmessagetraceresponseErrors>,
                          messages: list<emailsecuritygetmessagetraceresponseMessages>,
                          success: bool,
                          result: ``email-securityMessageTrace``): emailsecuritygetmessagetraceresponse =
        { errors = errors
          messages = messages
          success = success
          result = result }

type emailsecuritygetphishguardreportsresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetphishguardreportsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetphishguardreportsresponseErrorsSource = { pointer = None }

type emailsecuritygetphishguardreportsresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetphishguardreportsresponseErrorsSource> }
    ///Creates an instance of emailsecuritygetphishguardreportsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetphishguardreportsresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetphishguardreportsresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetphishguardreportsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetphishguardreportsresponseMessagesSource = { pointer = None }

type emailsecuritygetphishguardreportsresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetphishguardreportsresponseMessagesSource> }
    ///Creates an instance of emailsecuritygetphishguardreportsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetphishguardreportsresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetphishguardreportsresponse =
    { errors: list<emailsecuritygetphishguardreportsresponseErrors>
      messages: list<emailsecuritygetphishguardreportsresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: list<``email-securityPhishGuardReport``> }
    ///Creates an instance of emailsecuritygetphishguardreportsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritygetphishguardreportsresponseErrors>,
                          messages: list<emailsecuritygetphishguardreportsresponseMessages>,
                          success: bool,
                          result: list<``email-securityPhishGuardReport``>): emailsecuritygetphishguardreportsresponse =
        { errors = errors
          messages = messages
          success = success
          result = result }

type emailsecuritylistallowpoliciesresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritylistallowpoliciesresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylistallowpoliciesresponseErrorsSource = { pointer = None }

type emailsecuritylistallowpoliciesresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritylistallowpoliciesresponseErrorsSource> }
    ///Creates an instance of emailsecuritylistallowpoliciesresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritylistallowpoliciesresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritylistallowpoliciesresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritylistallowpoliciesresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylistallowpoliciesresponseMessagesSource = { pointer = None }

type emailsecuritylistallowpoliciesresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritylistallowpoliciesresponseMessagesSource> }
    ///Creates an instance of emailsecuritylistallowpoliciesresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritylistallowpoliciesresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritylistallowpoliciesresponseResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of emailsecuritylistallowpoliciesresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylistallowpoliciesresponseResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type emailsecuritylistallowpoliciesresponse =
    { errors: list<emailsecuritylistallowpoliciesresponseErrors>
      messages: list<emailsecuritylistallowpoliciesresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<emailsecuritylistallowpoliciesresponseResultinfo>
      result: Option<``email-securityAllowPolicyList``> }
    ///Creates an instance of emailsecuritylistallowpoliciesresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritylistallowpoliciesresponseErrors>,
                          messages: list<emailsecuritylistallowpoliciesresponseMessages>,
                          success: bool): emailsecuritylistallowpoliciesresponse =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type emailsecuritycreateallowpolicyresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritycreateallowpolicyresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritycreateallowpolicyresponseErrorsSource = { pointer = None }

type emailsecuritycreateallowpolicyresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritycreateallowpolicyresponseErrorsSource> }
    ///Creates an instance of emailsecuritycreateallowpolicyresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritycreateallowpolicyresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritycreateallowpolicyresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritycreateallowpolicyresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritycreateallowpolicyresponseMessagesSource = { pointer = None }

type emailsecuritycreateallowpolicyresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritycreateallowpolicyresponseMessagesSource> }
    ///Creates an instance of emailsecuritycreateallowpolicyresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritycreateallowpolicyresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritycreateallowpolicyresponse =
    { errors: list<emailsecuritycreateallowpolicyresponseErrors>
      messages: list<emailsecuritycreateallowpolicyresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///An email allow policy
      result: Option<``email-securityAllowPolicy``> }
    ///Creates an instance of emailsecuritycreateallowpolicyresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritycreateallowpolicyresponseErrors>,
                          messages: list<emailsecuritycreateallowpolicyresponseMessages>,
                          success: bool): emailsecuritycreateallowpolicyresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritybatchallowpoliciesresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritybatchallowpoliciesresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritybatchallowpoliciesresponseErrorsSource = { pointer = None }

type emailsecuritybatchallowpoliciesresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritybatchallowpoliciesresponseErrorsSource> }
    ///Creates an instance of emailsecuritybatchallowpoliciesresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritybatchallowpoliciesresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritybatchallowpoliciesresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritybatchallowpoliciesresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritybatchallowpoliciesresponseMessagesSource = { pointer = None }

type emailsecuritybatchallowpoliciesresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritybatchallowpoliciesresponseMessagesSource> }
    ///Creates an instance of emailsecuritybatchallowpoliciesresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritybatchallowpoliciesresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritybatchallowpoliciesresponseResult =
    { deletes: Option<list<``email-securityDeletedAllowPolicy``>>
      patches: Option<``email-securityAllowPolicyList``>
      posts: Option<``email-securityAllowPolicyList``>
      puts: Option<``email-securityAllowPolicyList``> }
    ///Creates an instance of emailsecuritybatchallowpoliciesresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritybatchallowpoliciesresponseResult =
        { deletes = None
          patches = None
          posts = None
          puts = None }

type emailsecuritybatchallowpoliciesresponse =
    { errors: list<emailsecuritybatchallowpoliciesresponseErrors>
      messages: list<emailsecuritybatchallowpoliciesresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<emailsecuritybatchallowpoliciesresponseResult> }
    ///Creates an instance of emailsecuritybatchallowpoliciesresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritybatchallowpoliciesresponseErrors>,
                          messages: list<emailsecuritybatchallowpoliciesresponseMessages>,
                          success: bool): emailsecuritybatchallowpoliciesresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritydeleteallowpolicyresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritydeleteallowpolicyresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritydeleteallowpolicyresponseErrorsSource = { pointer = None }

type emailsecuritydeleteallowpolicyresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritydeleteallowpolicyresponseErrorsSource> }
    ///Creates an instance of emailsecuritydeleteallowpolicyresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritydeleteallowpolicyresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritydeleteallowpolicyresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritydeleteallowpolicyresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritydeleteallowpolicyresponseMessagesSource = { pointer = None }

type emailsecuritydeleteallowpolicyresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritydeleteallowpolicyresponseMessagesSource> }
    ///Creates an instance of emailsecuritydeleteallowpolicyresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritydeleteallowpolicyresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritydeleteallowpolicyresponse =
    { errors: list<emailsecuritydeleteallowpolicyresponseErrors>
      messages: list<emailsecuritydeleteallowpolicyresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<``email-securityDeletedAllowPolicy``> }
    ///Creates an instance of emailsecuritydeleteallowpolicyresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritydeleteallowpolicyresponseErrors>,
                          messages: list<emailsecuritydeleteallowpolicyresponseMessages>,
                          success: bool): emailsecuritydeleteallowpolicyresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritygetallowpolicyresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetallowpolicyresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetallowpolicyresponseErrorsSource = { pointer = None }

type emailsecuritygetallowpolicyresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetallowpolicyresponseErrorsSource> }
    ///Creates an instance of emailsecuritygetallowpolicyresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetallowpolicyresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetallowpolicyresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetallowpolicyresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetallowpolicyresponseMessagesSource = { pointer = None }

type emailsecuritygetallowpolicyresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetallowpolicyresponseMessagesSource> }
    ///Creates an instance of emailsecuritygetallowpolicyresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetallowpolicyresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetallowpolicyresponse =
    { errors: list<emailsecuritygetallowpolicyresponseErrors>
      messages: list<emailsecuritygetallowpolicyresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///An email allow policy
      result: Option<``email-securityAllowPolicy``> }
    ///Creates an instance of emailsecuritygetallowpolicyresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritygetallowpolicyresponseErrors>,
                          messages: list<emailsecuritygetallowpolicyresponseMessages>,
                          success: bool): emailsecuritygetallowpolicyresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecurityupdateallowpolicyresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecurityupdateallowpolicyresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecurityupdateallowpolicyresponseErrorsSource = { pointer = None }

type emailsecurityupdateallowpolicyresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecurityupdateallowpolicyresponseErrorsSource> }
    ///Creates an instance of emailsecurityupdateallowpolicyresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecurityupdateallowpolicyresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecurityupdateallowpolicyresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecurityupdateallowpolicyresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecurityupdateallowpolicyresponseMessagesSource = { pointer = None }

type emailsecurityupdateallowpolicyresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecurityupdateallowpolicyresponseMessagesSource> }
    ///Creates an instance of emailsecurityupdateallowpolicyresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecurityupdateallowpolicyresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecurityupdateallowpolicyresponse =
    { errors: list<emailsecurityupdateallowpolicyresponseErrors>
      messages: list<emailsecurityupdateallowpolicyresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///An email allow policy
      result: Option<``email-securityAllowPolicy``> }
    ///Creates an instance of emailsecurityupdateallowpolicyresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecurityupdateallowpolicyresponseErrors>,
                          messages: list<emailsecurityupdateallowpolicyresponseMessages>,
                          success: bool): emailsecurityupdateallowpolicyresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritylistblockedsendersresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritylistblockedsendersresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylistblockedsendersresponseErrorsSource = { pointer = None }

type emailsecuritylistblockedsendersresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritylistblockedsendersresponseErrorsSource> }
    ///Creates an instance of emailsecuritylistblockedsendersresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritylistblockedsendersresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritylistblockedsendersresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritylistblockedsendersresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylistblockedsendersresponseMessagesSource = { pointer = None }

type emailsecuritylistblockedsendersresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritylistblockedsendersresponseMessagesSource> }
    ///Creates an instance of emailsecuritylistblockedsendersresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritylistblockedsendersresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritylistblockedsendersresponseResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of emailsecuritylistblockedsendersresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylistblockedsendersresponseResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type emailsecuritylistblockedsendersresponse =
    { errors: list<emailsecuritylistblockedsendersresponseErrors>
      messages: list<emailsecuritylistblockedsendersresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<emailsecuritylistblockedsendersresponseResultinfo>
      result: Option<``email-securityBlockedSenderList``> }
    ///Creates an instance of emailsecuritylistblockedsendersresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritylistblockedsendersresponseErrors>,
                          messages: list<emailsecuritylistblockedsendersresponseMessages>,
                          success: bool): emailsecuritylistblockedsendersresponse =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type emailsecuritycreateblockedsenderresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritycreateblockedsenderresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritycreateblockedsenderresponseErrorsSource = { pointer = None }

type emailsecuritycreateblockedsenderresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritycreateblockedsenderresponseErrorsSource> }
    ///Creates an instance of emailsecuritycreateblockedsenderresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritycreateblockedsenderresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritycreateblockedsenderresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritycreateblockedsenderresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritycreateblockedsenderresponseMessagesSource = { pointer = None }

type emailsecuritycreateblockedsenderresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritycreateblockedsenderresponseMessagesSource> }
    ///Creates an instance of emailsecuritycreateblockedsenderresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritycreateblockedsenderresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritycreateblockedsenderresponse =
    { errors: list<emailsecuritycreateblockedsenderresponseErrors>
      messages: list<emailsecuritycreateblockedsenderresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///A blocked sender pattern
      result: Option<``email-securityBlockedSender``> }
    ///Creates an instance of emailsecuritycreateblockedsenderresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritycreateblockedsenderresponseErrors>,
                          messages: list<emailsecuritycreateblockedsenderresponseMessages>,
                          success: bool): emailsecuritycreateblockedsenderresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritybatchblockedsendersresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritybatchblockedsendersresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritybatchblockedsendersresponseErrorsSource = { pointer = None }

type emailsecuritybatchblockedsendersresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritybatchblockedsendersresponseErrorsSource> }
    ///Creates an instance of emailsecuritybatchblockedsendersresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritybatchblockedsendersresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritybatchblockedsendersresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritybatchblockedsendersresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritybatchblockedsendersresponseMessagesSource = { pointer = None }

type emailsecuritybatchblockedsendersresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritybatchblockedsendersresponseMessagesSource> }
    ///Creates an instance of emailsecuritybatchblockedsendersresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritybatchblockedsendersresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritybatchblockedsendersresponseResult =
    { deletes: Option<list<``email-securityDeletedBlockedSender``>>
      patches: Option<``email-securityBlockedSenderList``>
      posts: Option<``email-securityBlockedSenderList``>
      puts: Option<``email-securityBlockedSenderList``> }
    ///Creates an instance of emailsecuritybatchblockedsendersresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritybatchblockedsendersresponseResult =
        { deletes = None
          patches = None
          posts = None
          puts = None }

type emailsecuritybatchblockedsendersresponse =
    { errors: list<emailsecuritybatchblockedsendersresponseErrors>
      messages: list<emailsecuritybatchblockedsendersresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<emailsecuritybatchblockedsendersresponseResult> }
    ///Creates an instance of emailsecuritybatchblockedsendersresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritybatchblockedsendersresponseErrors>,
                          messages: list<emailsecuritybatchblockedsendersresponseMessages>,
                          success: bool): emailsecuritybatchblockedsendersresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritydeleteblockedsenderresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritydeleteblockedsenderresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritydeleteblockedsenderresponseErrorsSource = { pointer = None }

type emailsecuritydeleteblockedsenderresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritydeleteblockedsenderresponseErrorsSource> }
    ///Creates an instance of emailsecuritydeleteblockedsenderresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritydeleteblockedsenderresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritydeleteblockedsenderresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritydeleteblockedsenderresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritydeleteblockedsenderresponseMessagesSource = { pointer = None }

type emailsecuritydeleteblockedsenderresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritydeleteblockedsenderresponseMessagesSource> }
    ///Creates an instance of emailsecuritydeleteblockedsenderresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritydeleteblockedsenderresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritydeleteblockedsenderresponse =
    { errors: list<emailsecuritydeleteblockedsenderresponseErrors>
      messages: list<emailsecuritydeleteblockedsenderresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<``email-securityDeletedBlockedSender``> }
    ///Creates an instance of emailsecuritydeleteblockedsenderresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritydeleteblockedsenderresponseErrors>,
                          messages: list<emailsecuritydeleteblockedsenderresponseMessages>,
                          success: bool): emailsecuritydeleteblockedsenderresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritygetblockedsenderresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetblockedsenderresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetblockedsenderresponseErrorsSource = { pointer = None }

type emailsecuritygetblockedsenderresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetblockedsenderresponseErrorsSource> }
    ///Creates an instance of emailsecuritygetblockedsenderresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetblockedsenderresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetblockedsenderresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetblockedsenderresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetblockedsenderresponseMessagesSource = { pointer = None }

type emailsecuritygetblockedsenderresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetblockedsenderresponseMessagesSource> }
    ///Creates an instance of emailsecuritygetblockedsenderresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetblockedsenderresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetblockedsenderresponse =
    { errors: list<emailsecuritygetblockedsenderresponseErrors>
      messages: list<emailsecuritygetblockedsenderresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///A blocked sender pattern
      result: Option<``email-securityBlockedSender``> }
    ///Creates an instance of emailsecuritygetblockedsenderresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritygetblockedsenderresponseErrors>,
                          messages: list<emailsecuritygetblockedsenderresponseMessages>,
                          success: bool): emailsecuritygetblockedsenderresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecurityupdateblockedsenderresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecurityupdateblockedsenderresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecurityupdateblockedsenderresponseErrorsSource = { pointer = None }

type emailsecurityupdateblockedsenderresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecurityupdateblockedsenderresponseErrorsSource> }
    ///Creates an instance of emailsecurityupdateblockedsenderresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecurityupdateblockedsenderresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecurityupdateblockedsenderresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecurityupdateblockedsenderresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecurityupdateblockedsenderresponseMessagesSource = { pointer = None }

type emailsecurityupdateblockedsenderresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecurityupdateblockedsenderresponseMessagesSource> }
    ///Creates an instance of emailsecurityupdateblockedsenderresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecurityupdateblockedsenderresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecurityupdateblockedsenderresponse =
    { errors: list<emailsecurityupdateblockedsenderresponseErrors>
      messages: list<emailsecurityupdateblockedsenderresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///A blocked sender pattern
      result: Option<``email-securityBlockedSender``> }
    ///Creates an instance of emailsecurityupdateblockedsenderresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecurityupdateblockedsenderresponseErrors>,
                          messages: list<emailsecurityupdateblockedsenderresponseMessages>,
                          success: bool): emailsecurityupdateblockedsenderresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritylistdomainsresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritylistdomainsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylistdomainsresponseErrorsSource = { pointer = None }

type emailsecuritylistdomainsresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritylistdomainsresponseErrorsSource> }
    ///Creates an instance of emailsecuritylistdomainsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritylistdomainsresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritylistdomainsresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritylistdomainsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylistdomainsresponseMessagesSource = { pointer = None }

type emailsecuritylistdomainsresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritylistdomainsresponseMessagesSource> }
    ///Creates an instance of emailsecuritylistdomainsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritylistdomainsresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritylistdomainsresponseResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of emailsecuritylistdomainsresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylistdomainsresponseResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type emailsecuritylistdomainsresponse =
    { errors: list<emailsecuritylistdomainsresponseErrors>
      messages: list<emailsecuritylistdomainsresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<emailsecuritylistdomainsresponseResultinfo>
      result: Option<``email-securityDomainList``> }
    ///Creates an instance of emailsecuritylistdomainsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritylistdomainsresponseErrors>,
                          messages: list<emailsecuritylistdomainsresponseMessages>,
                          success: bool): emailsecuritylistdomainsresponse =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type emailsecuritydeletedomainresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritydeletedomainresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritydeletedomainresponseErrorsSource = { pointer = None }

type emailsecuritydeletedomainresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritydeletedomainresponseErrorsSource> }
    ///Creates an instance of emailsecuritydeletedomainresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritydeletedomainresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritydeletedomainresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritydeletedomainresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritydeletedomainresponseMessagesSource = { pointer = None }

type emailsecuritydeletedomainresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritydeletedomainresponseMessagesSource> }
    ///Creates an instance of emailsecuritydeletedomainresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritydeletedomainresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritydeletedomainresponse =
    { errors: list<emailsecuritydeletedomainresponseErrors>
      messages: list<emailsecuritydeletedomainresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<``email-securityDeletedDomain``> }
    ///Creates an instance of emailsecuritydeletedomainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritydeletedomainresponseErrors>,
                          messages: list<emailsecuritydeletedomainresponseMessages>,
                          success: bool): emailsecuritydeletedomainresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritygetdomainresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetdomainresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetdomainresponseErrorsSource = { pointer = None }

type emailsecuritygetdomainresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetdomainresponseErrorsSource> }
    ///Creates an instance of emailsecuritygetdomainresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetdomainresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetdomainresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetdomainresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetdomainresponseMessagesSource = { pointer = None }

type emailsecuritygetdomainresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetdomainresponseMessagesSource> }
    ///Creates an instance of emailsecuritygetdomainresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetdomainresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetdomainresponse =
    { errors: list<emailsecuritygetdomainresponseErrors>
      messages: list<emailsecuritygetdomainresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<``email-securityDomain``> }
    ///Creates an instance of emailsecuritygetdomainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritygetdomainresponseErrors>,
                          messages: list<emailsecuritygetdomainresponseMessages>,
                          success: bool): emailsecuritygetdomainresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecurityupdatedomainresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecurityupdatedomainresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecurityupdatedomainresponseErrorsSource = { pointer = None }

type emailsecurityupdatedomainresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecurityupdatedomainresponseErrorsSource> }
    ///Creates an instance of emailsecurityupdatedomainresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecurityupdatedomainresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecurityupdatedomainresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecurityupdatedomainresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecurityupdatedomainresponseMessagesSource = { pointer = None }

type emailsecurityupdatedomainresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecurityupdatedomainresponseMessagesSource> }
    ///Creates an instance of emailsecurityupdatedomainresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecurityupdatedomainresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecurityupdatedomainresponse =
    { errors: list<emailsecurityupdatedomainresponseErrors>
      messages: list<emailsecurityupdatedomainresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<``email-securityDomain``> }
    ///Creates an instance of emailsecurityupdatedomainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecurityupdatedomainresponseErrors>,
                          messages: list<emailsecurityupdatedomainresponseMessages>,
                          success: bool): emailsecurityupdatedomainresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritylistimpersonationregistryresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritylistimpersonationregistryresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylistimpersonationregistryresponseErrorsSource = { pointer = None }

type emailsecuritylistimpersonationregistryresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritylistimpersonationregistryresponseErrorsSource> }
    ///Creates an instance of emailsecuritylistimpersonationregistryresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritylistimpersonationregistryresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritylistimpersonationregistryresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritylistimpersonationregistryresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylistimpersonationregistryresponseMessagesSource = { pointer = None }

type emailsecuritylistimpersonationregistryresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritylistimpersonationregistryresponseMessagesSource> }
    ///Creates an instance of emailsecuritylistimpersonationregistryresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritylistimpersonationregistryresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritylistimpersonationregistryresponseResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of emailsecuritylistimpersonationregistryresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylistimpersonationregistryresponseResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type emailsecuritylistimpersonationregistryresponse =
    { errors: list<emailsecuritylistimpersonationregistryresponseErrors>
      messages: list<emailsecuritylistimpersonationregistryresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<emailsecuritylistimpersonationregistryresponseResultinfo>
      result: Option<``email-securityImpersonationRegistryList``> }
    ///Creates an instance of emailsecuritylistimpersonationregistryresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritylistimpersonationregistryresponseErrors>,
                          messages: list<emailsecuritylistimpersonationregistryresponseMessages>,
                          success: bool): emailsecuritylistimpersonationregistryresponse =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type emailsecuritycreateimpersonationregistryresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritycreateimpersonationregistryresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritycreateimpersonationregistryresponseErrorsSource = { pointer = None }

type emailsecuritycreateimpersonationregistryresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritycreateimpersonationregistryresponseErrorsSource> }
    ///Creates an instance of emailsecuritycreateimpersonationregistryresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritycreateimpersonationregistryresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritycreateimpersonationregistryresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritycreateimpersonationregistryresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritycreateimpersonationregistryresponseMessagesSource = { pointer = None }

type emailsecuritycreateimpersonationregistryresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritycreateimpersonationregistryresponseMessagesSource> }
    ///Creates an instance of emailsecuritycreateimpersonationregistryresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritycreateimpersonationregistryresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritycreateimpersonationregistryresponse =
    { errors: list<emailsecuritycreateimpersonationregistryresponseErrors>
      messages: list<emailsecuritycreateimpersonationregistryresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///An impersonation registry entry
      result: Option<``email-securityImpersonationRegistry``> }
    ///Creates an instance of emailsecuritycreateimpersonationregistryresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritycreateimpersonationregistryresponseErrors>,
                          messages: list<emailsecuritycreateimpersonationregistryresponseMessages>,
                          success: bool): emailsecuritycreateimpersonationregistryresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritydeleteimpersonationregistryresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritydeleteimpersonationregistryresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritydeleteimpersonationregistryresponseErrorsSource = { pointer = None }

type emailsecuritydeleteimpersonationregistryresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritydeleteimpersonationregistryresponseErrorsSource> }
    ///Creates an instance of emailsecuritydeleteimpersonationregistryresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritydeleteimpersonationregistryresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritydeleteimpersonationregistryresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritydeleteimpersonationregistryresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritydeleteimpersonationregistryresponseMessagesSource = { pointer = None }

type emailsecuritydeleteimpersonationregistryresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritydeleteimpersonationregistryresponseMessagesSource> }
    ///Creates an instance of emailsecuritydeleteimpersonationregistryresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritydeleteimpersonationregistryresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritydeleteimpersonationregistryresponse =
    { errors: list<emailsecuritydeleteimpersonationregistryresponseErrors>
      messages: list<emailsecuritydeleteimpersonationregistryresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<``email-securityDeletedImpersonationRegistry``> }
    ///Creates an instance of emailsecuritydeleteimpersonationregistryresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritydeleteimpersonationregistryresponseErrors>,
                          messages: list<emailsecuritydeleteimpersonationregistryresponseMessages>,
                          success: bool): emailsecuritydeleteimpersonationregistryresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritygetimpersonationregistryresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetimpersonationregistryresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetimpersonationregistryresponseErrorsSource = { pointer = None }

type emailsecuritygetimpersonationregistryresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetimpersonationregistryresponseErrorsSource> }
    ///Creates an instance of emailsecuritygetimpersonationregistryresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetimpersonationregistryresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetimpersonationregistryresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetimpersonationregistryresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetimpersonationregistryresponseMessagesSource = { pointer = None }

type emailsecuritygetimpersonationregistryresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetimpersonationregistryresponseMessagesSource> }
    ///Creates an instance of emailsecuritygetimpersonationregistryresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetimpersonationregistryresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetimpersonationregistryresponse =
    { errors: list<emailsecuritygetimpersonationregistryresponseErrors>
      messages: list<emailsecuritygetimpersonationregistryresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///An impersonation registry entry
      result: Option<``email-securityImpersonationRegistry``> }
    ///Creates an instance of emailsecuritygetimpersonationregistryresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritygetimpersonationregistryresponseErrors>,
                          messages: list<emailsecuritygetimpersonationregistryresponseMessages>,
                          success: bool): emailsecuritygetimpersonationregistryresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecurityupdateimpersonationregistryresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecurityupdateimpersonationregistryresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecurityupdateimpersonationregistryresponseErrorsSource = { pointer = None }

type emailsecurityupdateimpersonationregistryresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecurityupdateimpersonationregistryresponseErrorsSource> }
    ///Creates an instance of emailsecurityupdateimpersonationregistryresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecurityupdateimpersonationregistryresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecurityupdateimpersonationregistryresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecurityupdateimpersonationregistryresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecurityupdateimpersonationregistryresponseMessagesSource = { pointer = None }

type emailsecurityupdateimpersonationregistryresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecurityupdateimpersonationregistryresponseMessagesSource> }
    ///Creates an instance of emailsecurityupdateimpersonationregistryresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecurityupdateimpersonationregistryresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecurityupdateimpersonationregistryresponse =
    { errors: list<emailsecurityupdateimpersonationregistryresponseErrors>
      messages: list<emailsecurityupdateimpersonationregistryresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///An impersonation registry entry
      result: Option<``email-securityImpersonationRegistry``> }
    ///Creates an instance of emailsecurityupdateimpersonationregistryresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecurityupdateimpersonationregistryresponseErrors>,
                          messages: list<emailsecurityupdateimpersonationregistryresponseMessages>,
                          success: bool): emailsecurityupdateimpersonationregistryresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritylistsendingdomainrestrictionsresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritylistsendingdomainrestrictionsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylistsendingdomainrestrictionsresponseErrorsSource = { pointer = None }

type emailsecuritylistsendingdomainrestrictionsresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritylistsendingdomainrestrictionsresponseErrorsSource> }
    ///Creates an instance of emailsecuritylistsendingdomainrestrictionsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritylistsendingdomainrestrictionsresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritylistsendingdomainrestrictionsresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritylistsendingdomainrestrictionsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylistsendingdomainrestrictionsresponseMessagesSource = { pointer = None }

type emailsecuritylistsendingdomainrestrictionsresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritylistsendingdomainrestrictionsresponseMessagesSource> }
    ///Creates an instance of emailsecuritylistsendingdomainrestrictionsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritylistsendingdomainrestrictionsresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritylistsendingdomainrestrictionsresponseResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of emailsecuritylistsendingdomainrestrictionsresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylistsendingdomainrestrictionsresponseResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type emailsecuritylistsendingdomainrestrictionsresponse =
    { errors: list<emailsecuritylistsendingdomainrestrictionsresponseErrors>
      messages: list<emailsecuritylistsendingdomainrestrictionsresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<emailsecuritylistsendingdomainrestrictionsresponseResultinfo>
      result: Option<``email-securitySendingDomainRestrictionList``> }
    ///Creates an instance of emailsecuritylistsendingdomainrestrictionsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritylistsendingdomainrestrictionsresponseErrors>,
                          messages: list<emailsecuritylistsendingdomainrestrictionsresponseMessages>,
                          success: bool): emailsecuritylistsendingdomainrestrictionsresponse =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type emailsecuritycreatesendingdomainrestrictionresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritycreatesendingdomainrestrictionresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritycreatesendingdomainrestrictionresponseErrorsSource = { pointer = None }

type emailsecuritycreatesendingdomainrestrictionresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritycreatesendingdomainrestrictionresponseErrorsSource> }
    ///Creates an instance of emailsecuritycreatesendingdomainrestrictionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritycreatesendingdomainrestrictionresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritycreatesendingdomainrestrictionresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritycreatesendingdomainrestrictionresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritycreatesendingdomainrestrictionresponseMessagesSource = { pointer = None }

type emailsecuritycreatesendingdomainrestrictionresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritycreatesendingdomainrestrictionresponseMessagesSource> }
    ///Creates an instance of emailsecuritycreatesendingdomainrestrictionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritycreatesendingdomainrestrictionresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritycreatesendingdomainrestrictionresponse =
    { errors: list<emailsecuritycreatesendingdomainrestrictionresponseErrors>
      messages: list<emailsecuritycreatesendingdomainrestrictionresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///A sending domain restriction that enforces TLS (Transport Layer Security) requirements for emails from specific domains. If TLS is required, mail without TLS from the specified domain will be dropped.
      result: Option<``email-securitySendingDomainRestriction``> }
    ///Creates an instance of emailsecuritycreatesendingdomainrestrictionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritycreatesendingdomainrestrictionresponseErrors>,
                          messages: list<emailsecuritycreatesendingdomainrestrictionresponseMessages>,
                          success: bool): emailsecuritycreatesendingdomainrestrictionresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritybatchsendingdomainrestrictionsresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritybatchsendingdomainrestrictionsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritybatchsendingdomainrestrictionsresponseErrorsSource = { pointer = None }

type emailsecuritybatchsendingdomainrestrictionsresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritybatchsendingdomainrestrictionsresponseErrorsSource> }
    ///Creates an instance of emailsecuritybatchsendingdomainrestrictionsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritybatchsendingdomainrestrictionsresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritybatchsendingdomainrestrictionsresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritybatchsendingdomainrestrictionsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritybatchsendingdomainrestrictionsresponseMessagesSource = { pointer = None }

type emailsecuritybatchsendingdomainrestrictionsresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritybatchsendingdomainrestrictionsresponseMessagesSource> }
    ///Creates an instance of emailsecuritybatchsendingdomainrestrictionsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritybatchsendingdomainrestrictionsresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type Deletes =
    { ///Sending domain restriction identifier.
      id: ``email-securitySendingDomainRestrictionId`` }
    ///Creates an instance of Deletes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``email-securitySendingDomainRestrictionId``): Deletes = { id = id }

type emailsecuritybatchsendingdomainrestrictionsresponseResult =
    { deletes: list<Deletes> }
    ///Creates an instance of emailsecuritybatchsendingdomainrestrictionsresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (deletes: list<Deletes>): emailsecuritybatchsendingdomainrestrictionsresponseResult =
        { deletes = deletes }

type emailsecuritybatchsendingdomainrestrictionsresponse =
    { errors: list<emailsecuritybatchsendingdomainrestrictionsresponseErrors>
      messages: list<emailsecuritybatchsendingdomainrestrictionsresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<emailsecuritybatchsendingdomainrestrictionsresponseResult> }
    ///Creates an instance of emailsecuritybatchsendingdomainrestrictionsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritybatchsendingdomainrestrictionsresponseErrors>,
                          messages: list<emailsecuritybatchsendingdomainrestrictionsresponseMessages>,
                          success: bool): emailsecuritybatchsendingdomainrestrictionsresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritydeletesendingdomainrestrictionresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritydeletesendingdomainrestrictionresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritydeletesendingdomainrestrictionresponseErrorsSource = { pointer = None }

type emailsecuritydeletesendingdomainrestrictionresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritydeletesendingdomainrestrictionresponseErrorsSource> }
    ///Creates an instance of emailsecuritydeletesendingdomainrestrictionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritydeletesendingdomainrestrictionresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritydeletesendingdomainrestrictionresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritydeletesendingdomainrestrictionresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritydeletesendingdomainrestrictionresponseMessagesSource = { pointer = None }

type emailsecuritydeletesendingdomainrestrictionresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritydeletesendingdomainrestrictionresponseMessagesSource> }
    ///Creates an instance of emailsecuritydeletesendingdomainrestrictionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritydeletesendingdomainrestrictionresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritydeletesendingdomainrestrictionresponse =
    { errors: list<emailsecuritydeletesendingdomainrestrictionresponseErrors>
      messages: list<emailsecuritydeletesendingdomainrestrictionresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<``email-securityDeletedSendingDomainRestriction``> }
    ///Creates an instance of emailsecuritydeletesendingdomainrestrictionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritydeletesendingdomainrestrictionresponseErrors>,
                          messages: list<emailsecuritydeletesendingdomainrestrictionresponseMessages>,
                          success: bool): emailsecuritydeletesendingdomainrestrictionresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritygetsendingdomainrestrictionresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetsendingdomainrestrictionresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetsendingdomainrestrictionresponseErrorsSource = { pointer = None }

type emailsecuritygetsendingdomainrestrictionresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetsendingdomainrestrictionresponseErrorsSource> }
    ///Creates an instance of emailsecuritygetsendingdomainrestrictionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetsendingdomainrestrictionresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetsendingdomainrestrictionresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygetsendingdomainrestrictionresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygetsendingdomainrestrictionresponseMessagesSource = { pointer = None }

type emailsecuritygetsendingdomainrestrictionresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygetsendingdomainrestrictionresponseMessagesSource> }
    ///Creates an instance of emailsecuritygetsendingdomainrestrictionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygetsendingdomainrestrictionresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygetsendingdomainrestrictionresponse =
    { errors: list<emailsecuritygetsendingdomainrestrictionresponseErrors>
      messages: list<emailsecuritygetsendingdomainrestrictionresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///A sending domain restriction that enforces TLS (Transport Layer Security) requirements for emails from specific domains. If TLS is required, mail without TLS from the specified domain will be dropped.
      result: Option<``email-securitySendingDomainRestriction``> }
    ///Creates an instance of emailsecuritygetsendingdomainrestrictionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritygetsendingdomainrestrictionresponseErrors>,
                          messages: list<emailsecuritygetsendingdomainrestrictionresponseMessages>,
                          success: bool): emailsecuritygetsendingdomainrestrictionresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecurityupdatesendingdomainrestrictionresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecurityupdatesendingdomainrestrictionresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecurityupdatesendingdomainrestrictionresponseErrorsSource = { pointer = None }

type emailsecurityupdatesendingdomainrestrictionresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecurityupdatesendingdomainrestrictionresponseErrorsSource> }
    ///Creates an instance of emailsecurityupdatesendingdomainrestrictionresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecurityupdatesendingdomainrestrictionresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecurityupdatesendingdomainrestrictionresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecurityupdatesendingdomainrestrictionresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecurityupdatesendingdomainrestrictionresponseMessagesSource = { pointer = None }

type emailsecurityupdatesendingdomainrestrictionresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecurityupdatesendingdomainrestrictionresponseMessagesSource> }
    ///Creates an instance of emailsecurityupdatesendingdomainrestrictionresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecurityupdatesendingdomainrestrictionresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecurityupdatesendingdomainrestrictionresponse =
    { errors: list<emailsecurityupdatesendingdomainrestrictionresponseErrors>
      messages: list<emailsecurityupdatesendingdomainrestrictionresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///A sending domain restriction that enforces TLS (Transport Layer Security) requirements for emails from specific domains. If TLS is required, mail without TLS from the specified domain will be dropped.
      result: Option<``email-securitySendingDomainRestriction``> }
    ///Creates an instance of emailsecurityupdatesendingdomainrestrictionresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecurityupdatesendingdomainrestrictionresponseErrors>,
                          messages: list<emailsecurityupdatesendingdomainrestrictionresponseMessages>,
                          success: bool): emailsecurityupdatesendingdomainrestrictionresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritylisttrusteddomainsresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritylisttrusteddomainsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylisttrusteddomainsresponseErrorsSource = { pointer = None }

type emailsecuritylisttrusteddomainsresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritylisttrusteddomainsresponseErrorsSource> }
    ///Creates an instance of emailsecuritylisttrusteddomainsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritylisttrusteddomainsresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritylisttrusteddomainsresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritylisttrusteddomainsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylisttrusteddomainsresponseMessagesSource = { pointer = None }

type emailsecuritylisttrusteddomainsresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritylisttrusteddomainsresponseMessagesSource> }
    ///Creates an instance of emailsecuritylisttrusteddomainsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritylisttrusteddomainsresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritylisttrusteddomainsresponseResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of emailsecuritylisttrusteddomainsresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylisttrusteddomainsresponseResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type emailsecuritylisttrusteddomainsresponse =
    { errors: list<emailsecuritylisttrusteddomainsresponseErrors>
      messages: list<emailsecuritylisttrusteddomainsresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<emailsecuritylisttrusteddomainsresponseResultinfo>
      result: Option<``email-securityTrustedDomainList``> }
    ///Creates an instance of emailsecuritylisttrusteddomainsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritylisttrusteddomainsresponseErrors>,
                          messages: list<emailsecuritylisttrusteddomainsresponseMessages>,
                          success: bool): emailsecuritylisttrusteddomainsresponse =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type emailsecuritycreatetrusteddomainresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritycreatetrusteddomainresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritycreatetrusteddomainresponseErrorsSource = { pointer = None }

type emailsecuritycreatetrusteddomainresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritycreatetrusteddomainresponseErrorsSource> }
    ///Creates an instance of emailsecuritycreatetrusteddomainresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritycreatetrusteddomainresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritycreatetrusteddomainresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritycreatetrusteddomainresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritycreatetrusteddomainresponseMessagesSource = { pointer = None }

type emailsecuritycreatetrusteddomainresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritycreatetrusteddomainresponseMessagesSource> }
    ///Creates an instance of emailsecuritycreatetrusteddomainresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritycreatetrusteddomainresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritycreatetrusteddomainresponse =
    { errors: list<emailsecuritycreatetrusteddomainresponseErrors>
      messages: list<emailsecuritycreatetrusteddomainresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///A trusted email domain
      result: Option<``email-securityTrustedDomain``> }
    ///Creates an instance of emailsecuritycreatetrusteddomainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritycreatetrusteddomainresponseErrors>,
                          messages: list<emailsecuritycreatetrusteddomainresponseMessages>,
                          success: bool): emailsecuritycreatetrusteddomainresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritybatchtrusteddomainsresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritybatchtrusteddomainsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritybatchtrusteddomainsresponseErrorsSource = { pointer = None }

type emailsecuritybatchtrusteddomainsresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritybatchtrusteddomainsresponseErrorsSource> }
    ///Creates an instance of emailsecuritybatchtrusteddomainsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritybatchtrusteddomainsresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritybatchtrusteddomainsresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritybatchtrusteddomainsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritybatchtrusteddomainsresponseMessagesSource = { pointer = None }

type emailsecuritybatchtrusteddomainsresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritybatchtrusteddomainsresponseMessagesSource> }
    ///Creates an instance of emailsecuritybatchtrusteddomainsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritybatchtrusteddomainsresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritybatchtrusteddomainsresponseResult =
    { deletes: Option<list<``email-securityDeletedTrustedDomain``>>
      patches: Option<``email-securityTrustedDomainList``>
      posts: Option<``email-securityTrustedDomainList``>
      puts: Option<``email-securityTrustedDomainList``> }
    ///Creates an instance of emailsecuritybatchtrusteddomainsresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritybatchtrusteddomainsresponseResult =
        { deletes = None
          patches = None
          posts = None
          puts = None }

type emailsecuritybatchtrusteddomainsresponse =
    { errors: list<emailsecuritybatchtrusteddomainsresponseErrors>
      messages: list<emailsecuritybatchtrusteddomainsresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<emailsecuritybatchtrusteddomainsresponseResult> }
    ///Creates an instance of emailsecuritybatchtrusteddomainsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritybatchtrusteddomainsresponseErrors>,
                          messages: list<emailsecuritybatchtrusteddomainsresponseMessages>,
                          success: bool): emailsecuritybatchtrusteddomainsresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritydeletetrusteddomainresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritydeletetrusteddomainresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritydeletetrusteddomainresponseErrorsSource = { pointer = None }

type emailsecuritydeletetrusteddomainresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritydeletetrusteddomainresponseErrorsSource> }
    ///Creates an instance of emailsecuritydeletetrusteddomainresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritydeletetrusteddomainresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritydeletetrusteddomainresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritydeletetrusteddomainresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritydeletetrusteddomainresponseMessagesSource = { pointer = None }

type emailsecuritydeletetrusteddomainresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritydeletetrusteddomainresponseMessagesSource> }
    ///Creates an instance of emailsecuritydeletetrusteddomainresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritydeletetrusteddomainresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritydeletetrusteddomainresponse =
    { errors: list<emailsecuritydeletetrusteddomainresponseErrors>
      messages: list<emailsecuritydeletetrusteddomainresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<``email-securityDeletedTrustedDomain``> }
    ///Creates an instance of emailsecuritydeletetrusteddomainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritydeletetrusteddomainresponseErrors>,
                          messages: list<emailsecuritydeletetrusteddomainresponseMessages>,
                          success: bool): emailsecuritydeletetrusteddomainresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritygettrusteddomainresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygettrusteddomainresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygettrusteddomainresponseErrorsSource = { pointer = None }

type emailsecuritygettrusteddomainresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygettrusteddomainresponseErrorsSource> }
    ///Creates an instance of emailsecuritygettrusteddomainresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygettrusteddomainresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygettrusteddomainresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritygettrusteddomainresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritygettrusteddomainresponseMessagesSource = { pointer = None }

type emailsecuritygettrusteddomainresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritygettrusteddomainresponseMessagesSource> }
    ///Creates an instance of emailsecuritygettrusteddomainresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritygettrusteddomainresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritygettrusteddomainresponse =
    { errors: list<emailsecuritygettrusteddomainresponseErrors>
      messages: list<emailsecuritygettrusteddomainresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///A trusted email domain
      result: Option<``email-securityTrustedDomain``> }
    ///Creates an instance of emailsecuritygettrusteddomainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritygettrusteddomainresponseErrors>,
                          messages: list<emailsecuritygettrusteddomainresponseMessages>,
                          success: bool): emailsecuritygettrusteddomainresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecurityupdatetrusteddomainresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecurityupdatetrusteddomainresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecurityupdatetrusteddomainresponseErrorsSource = { pointer = None }

type emailsecurityupdatetrusteddomainresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecurityupdatetrusteddomainresponseErrorsSource> }
    ///Creates an instance of emailsecurityupdatetrusteddomainresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecurityupdatetrusteddomainresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecurityupdatetrusteddomainresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecurityupdatetrusteddomainresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecurityupdatetrusteddomainresponseMessagesSource = { pointer = None }

type emailsecurityupdatetrusteddomainresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecurityupdatetrusteddomainresponseMessagesSource> }
    ///Creates an instance of emailsecurityupdatetrusteddomainresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecurityupdatetrusteddomainresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecurityupdatetrusteddomainresponse =
    { errors: list<emailsecurityupdatetrusteddomainresponseErrors>
      messages: list<emailsecurityupdatetrusteddomainresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///A trusted email domain
      result: Option<``email-securityTrustedDomain``> }
    ///Creates an instance of emailsecurityupdatetrusteddomainresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecurityupdatetrusteddomainresponseErrors>,
                          messages: list<emailsecurityupdatetrusteddomainresponseMessages>,
                          success: bool): emailsecurityupdatetrusteddomainresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritylisturlignorepatternsresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritylisturlignorepatternsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylisturlignorepatternsresponseErrorsSource = { pointer = None }

type emailsecuritylisturlignorepatternsresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritylisturlignorepatternsresponseErrorsSource> }
    ///Creates an instance of emailsecuritylisturlignorepatternsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritylisturlignorepatternsresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritylisturlignorepatternsresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritylisturlignorepatternsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylisturlignorepatternsresponseMessagesSource = { pointer = None }

type emailsecuritylisturlignorepatternsresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritylisturlignorepatternsresponseMessagesSource> }
    ///Creates an instance of emailsecuritylisturlignorepatternsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritylisturlignorepatternsresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritylisturlignorepatternsresponseResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of emailsecuritylisturlignorepatternsresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritylisturlignorepatternsresponseResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type emailsecuritylisturlignorepatternsresponse =
    { errors: list<emailsecuritylisturlignorepatternsresponseErrors>
      messages: list<emailsecuritylisturlignorepatternsresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<emailsecuritylisturlignorepatternsresponseResultinfo>
      result: Option<list<``email-securityUrlIgnorePattern``>> }
    ///Creates an instance of emailsecuritylisturlignorepatternsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritylisturlignorepatternsresponseErrors>,
                          messages: list<emailsecuritylisturlignorepatternsresponseMessages>,
                          success: bool): emailsecuritylisturlignorepatternsresponse =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

type emailsecuritycreateurlignorepatternresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritycreateurlignorepatternresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritycreateurlignorepatternresponseErrorsSource = { pointer = None }

type emailsecuritycreateurlignorepatternresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritycreateurlignorepatternresponseErrorsSource> }
    ///Creates an instance of emailsecuritycreateurlignorepatternresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritycreateurlignorepatternresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritycreateurlignorepatternresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritycreateurlignorepatternresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritycreateurlignorepatternresponseMessagesSource = { pointer = None }

type emailsecuritycreateurlignorepatternresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritycreateurlignorepatternresponseMessagesSource> }
    ///Creates an instance of emailsecuritycreateurlignorepatternresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritycreateurlignorepatternresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritycreateurlignorepatternresponse =
    { errors: list<emailsecuritycreateurlignorepatternresponseErrors>
      messages: list<emailsecuritycreateurlignorepatternresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///A URL ignore pattern that exempts matching URLs from being rewritten by Email Security.
      result: Option<``email-securityUrlIgnorePattern``> }
    ///Creates an instance of emailsecuritycreateurlignorepatternresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritycreateurlignorepatternresponseErrors>,
                          messages: list<emailsecuritycreateurlignorepatternresponseMessages>,
                          success: bool): emailsecuritycreateurlignorepatternresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritybatchurlignorepatternsresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritybatchurlignorepatternsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritybatchurlignorepatternsresponseErrorsSource = { pointer = None }

type emailsecuritybatchurlignorepatternsresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritybatchurlignorepatternsresponseErrorsSource> }
    ///Creates an instance of emailsecuritybatchurlignorepatternsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritybatchurlignorepatternsresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritybatchurlignorepatternsresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritybatchurlignorepatternsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritybatchurlignorepatternsresponseMessagesSource = { pointer = None }

type emailsecuritybatchurlignorepatternsresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritybatchurlignorepatternsresponseMessagesSource> }
    ///Creates an instance of emailsecuritybatchurlignorepatternsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritybatchurlignorepatternsresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritybatchurlignorepatternsresponseResult =
    { deletes: list<``email-securityDeletedUrlIgnorePattern``>
      patches: list<``email-securityUrlIgnorePattern``>
      posts: list<``email-securityUrlIgnorePattern``>
      puts: list<``email-securityUrlIgnorePattern``> }
    ///Creates an instance of emailsecuritybatchurlignorepatternsresponseResult with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (deletes: list<``email-securityDeletedUrlIgnorePattern``>,
                          patches: list<``email-securityUrlIgnorePattern``>,
                          posts: list<``email-securityUrlIgnorePattern``>,
                          puts: list<``email-securityUrlIgnorePattern``>): emailsecuritybatchurlignorepatternsresponseResult =
        { deletes = deletes
          patches = patches
          posts = posts
          puts = puts }

type emailsecuritybatchurlignorepatternsresponse =
    { errors: list<emailsecuritybatchurlignorepatternsresponseErrors>
      messages: list<emailsecuritybatchurlignorepatternsresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: emailsecuritybatchurlignorepatternsresponseResult }
    ///Creates an instance of emailsecuritybatchurlignorepatternsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritybatchurlignorepatternsresponseErrors>,
                          messages: list<emailsecuritybatchurlignorepatternsresponseMessages>,
                          success: bool,
                          result: emailsecuritybatchurlignorepatternsresponseResult): emailsecuritybatchurlignorepatternsresponse =
        { errors = errors
          messages = messages
          success = success
          result = result }

type emailsecuritydeleteurlignorepatternresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritydeleteurlignorepatternresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritydeleteurlignorepatternresponseErrorsSource = { pointer = None }

type emailsecuritydeleteurlignorepatternresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritydeleteurlignorepatternresponseErrorsSource> }
    ///Creates an instance of emailsecuritydeleteurlignorepatternresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritydeleteurlignorepatternresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritydeleteurlignorepatternresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritydeleteurlignorepatternresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritydeleteurlignorepatternresponseMessagesSource = { pointer = None }

type emailsecuritydeleteurlignorepatternresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritydeleteurlignorepatternresponseMessagesSource> }
    ///Creates an instance of emailsecuritydeleteurlignorepatternresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritydeleteurlignorepatternresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritydeleteurlignorepatternresponse =
    { errors: list<emailsecuritydeleteurlignorepatternresponseErrors>
      messages: list<emailsecuritydeleteurlignorepatternresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result: Option<``email-securityDeletedUrlIgnorePattern``> }
    ///Creates an instance of emailsecuritydeleteurlignorepatternresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritydeleteurlignorepatternresponseErrors>,
                          messages: list<emailsecuritydeleteurlignorepatternresponseMessages>,
                          success: bool): emailsecuritydeleteurlignorepatternresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecurityupdateurlignorepatternresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecurityupdateurlignorepatternresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecurityupdateurlignorepatternresponseErrorsSource = { pointer = None }

type emailsecurityupdateurlignorepatternresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecurityupdateurlignorepatternresponseErrorsSource> }
    ///Creates an instance of emailsecurityupdateurlignorepatternresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecurityupdateurlignorepatternresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecurityupdateurlignorepatternresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecurityupdateurlignorepatternresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecurityupdateurlignorepatternresponseMessagesSource = { pointer = None }

type emailsecurityupdateurlignorepatternresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecurityupdateurlignorepatternresponseMessagesSource> }
    ///Creates an instance of emailsecurityupdateurlignorepatternresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecurityupdateurlignorepatternresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecurityupdateurlignorepatternresponse =
    { errors: list<emailsecurityupdateurlignorepatternresponseErrors>
      messages: list<emailsecurityupdateurlignorepatternresponseMessages>
      ///Whether the API call was successful.
      success: bool
      ///A URL ignore pattern that exempts matching URLs from being rewritten by Email Security.
      result: Option<``email-securityUrlIgnorePattern``> }
    ///Creates an instance of emailsecurityupdateurlignorepatternresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecurityupdateurlignorepatternresponseErrors>,
                          messages: list<emailsecurityupdateurlignorepatternresponseMessages>,
                          success: bool): emailsecurityupdateurlignorepatternresponse =
        { errors = errors
          messages = messages
          success = success
          result = None }

type emailsecuritysubmissionsresponseErrorsSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritysubmissionsresponseErrorsSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritysubmissionsresponseErrorsSource = { pointer = None }

type emailsecuritysubmissionsresponseErrors =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritysubmissionsresponseErrorsSource> }
    ///Creates an instance of emailsecuritysubmissionsresponseErrors with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritysubmissionsresponseErrors =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritysubmissionsresponseMessagesSource =
    { pointer: Option<string> }
    ///Creates an instance of emailsecuritysubmissionsresponseMessagesSource with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritysubmissionsresponseMessagesSource = { pointer = None }

type emailsecuritysubmissionsresponseMessages =
    { code: int
      documentation_url: Option<string>
      message: string
      source: Option<emailsecuritysubmissionsresponseMessagesSource> }
    ///Creates an instance of emailsecuritysubmissionsresponseMessages with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (code: int, message: string): emailsecuritysubmissionsresponseMessages =
        { code = code
          documentation_url = None
          message = message
          source = None }

type emailsecuritysubmissionsresponseResultinfo =
    { ///Total number of results for the requested service.
      count: Option<float>
      ///Current page within paginated list of results.
      page: Option<float>
      ///Number of results per page of results.
      per_page: Option<float>
      ///Total results available without any search parameters.
      total_count: Option<float> }
    ///Creates an instance of emailsecuritysubmissionsresponseResultinfo with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (): emailsecuritysubmissionsresponseResultinfo =
        { count = None
          page = None
          per_page = None
          total_count = None }

type emailsecuritysubmissionsresponse =
    { errors: list<emailsecuritysubmissionsresponseErrors>
      messages: list<emailsecuritysubmissionsresponseMessages>
      ///Whether the API call was successful.
      success: bool
      result_info: Option<emailsecuritysubmissionsresponseResultinfo>
      result: Option<list<``email-securitySubmission``>> }
    ///Creates an instance of emailsecuritysubmissionsresponse with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (errors: list<emailsecuritysubmissionsresponseErrors>,
                          messages: list<emailsecuritysubmissionsresponseMessages>,
                          success: bool): emailsecuritysubmissionsresponse =
        { errors = errors
          messages = messages
          success = success
          result_info = None
          result = None }

[<RequireQualifiedAccess>]
type EmailSecurityInvestigate =
    ///Search results for the provided query.
    | OK of payload: emailsecurityinvestigateresponse
    ///The search is taking longer than expected. Use the Location header to poll for results.
    | Accepted of payload: emailsecurityinvestigateresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

type EmailSecurityPostBulkMovePayload =
    { destination: ``email-securityMailboxDestination``
      ///List of message IDs to move
      ids: Option<list<``email-securityInvestigateId``>> }
    ///Creates an instance of EmailSecurityPostBulkMovePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (destination: ``email-securityMailboxDestination``): EmailSecurityPostBulkMovePayload =
        { destination = destination
          ids = None }

[<RequireQualifiedAccess>]
type EmailSecurityPostBulkMove =
    ///Bulk move operation results
    | OK of payload: emailsecuritypostbulkmoveresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

type EmailSecurityPostPreviewPayload =
    { ///The identifier of the message
      postfix_id: ``email-securityPostfixId`` }
    ///Creates an instance of EmailSecurityPostPreviewPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (postfix_id: ``email-securityPostfixId``): EmailSecurityPostPreviewPayload =
        { postfix_id = postfix_id }

[<RequireQualifiedAccess>]
type EmailSecurityPostPreview =
    ///Email preview.
    | OK of payload: emailsecuritypostpreviewresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityPostRelease =
    ///Release operation results.
    | OK of payload: emailsecuritypostreleaseresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityGetMessage =
    ///Email message details.
    | OK of payload: emailsecuritygetmessageresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityGetMessageActionLog =
    ///Action log for the email
    | OK of payload: emailsecuritygetmessageactionlogresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityGetMessageDetections =
    ///Email message detection details.
    | OK of payload: emailsecuritygetmessagedetectionsresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

type EmailSecurityPostMessageMovePayload =
    { destination: ``email-securityMailboxDestination`` }
    ///Creates an instance of EmailSecurityPostMessageMovePayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (destination: ``email-securityMailboxDestination``): EmailSecurityPostMessageMovePayload =
        { destination = destination }

[<RequireQualifiedAccess>]
type EmailSecurityPostMessageMove =
    ///Move operation results
    | OK of payload: emailsecuritypostmessagemoveresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityGetMessagePreview =
    ///Email preview
    | OK of payload: emailsecuritygetmessagepreviewresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityGetMessageRaw =
    ///Raw email content.
    | OK of payload: emailsecuritygetmessagerawresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityPostReclassify =
    ///Reclassification request accepted.
    | Accepted of payload: emailsecuritypostreclassifyresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityGetMessageTrace =
    ///Email trace.
    | OK of payload: emailsecuritygetmessagetraceresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityGetPhishguardReports =
    ///List of PhishGuard reports
    | OK of payload: emailsecuritygetphishguardreportsresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityListAllowPolicies =
    ///List of allow policies
    | OK of payload: emailsecuritylistallowpoliciesresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityCreateAllowPolicy =
    ///Created allow policy
    | Created of payload: emailsecuritycreateallowpolicyresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

type EmailSecurityBatchAllowPoliciesPayloadDeletes =
    { ///Allow policy identifier
      id: ``email-securityAllowPolicyId`` }
    ///Creates an instance of EmailSecurityBatchAllowPoliciesPayloadDeletes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``email-securityAllowPolicyId``): EmailSecurityBatchAllowPoliciesPayloadDeletes =
        { id = id }

type EmailSecurityBatchAllowPoliciesPayload =
    { deletes: list<EmailSecurityBatchAllowPoliciesPayloadDeletes>
      patches: list<string>
      posts: list<``email-securityCreateAllowPolicy``>
      puts: list<string> }
    ///Creates an instance of EmailSecurityBatchAllowPoliciesPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (deletes: list<EmailSecurityBatchAllowPoliciesPayloadDeletes>,
                          patches: list<string>,
                          posts: list<``email-securityCreateAllowPolicy``>,
                          puts: list<string>): EmailSecurityBatchAllowPoliciesPayload =
        { deletes = deletes
          patches = patches
          posts = posts
          puts = puts }

[<RequireQualifiedAccess>]
type EmailSecurityBatchAllowPolicies =
    ///Batch operation results
    | OK of payload: emailsecuritybatchallowpoliciesresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityDeleteAllowPolicy =
    ///Deleted allow policy
    | OK of payload: emailsecuritydeleteallowpolicyresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityGetAllowPolicy =
    ///Allow policy details
    | OK of payload: emailsecuritygetallowpolicyresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityUpdateAllowPolicy =
    ///Updated allow policy
    | OK of payload: emailsecurityupdateallowpolicyresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityListBlockedSenders =
    ///List of blocked senders
    | OK of payload: emailsecuritylistblockedsendersresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityCreateBlockedSender =
    ///Created blocked sender
    | Created of payload: emailsecuritycreateblockedsenderresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

type EmailSecurityBatchBlockedSendersPayloadDeletes =
    { ///Blocked sender pattern identifier
      id: ``email-securityBlockedSenderId`` }
    ///Creates an instance of EmailSecurityBatchBlockedSendersPayloadDeletes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``email-securityBlockedSenderId``): EmailSecurityBatchBlockedSendersPayloadDeletes =
        { id = id }

type EmailSecurityBatchBlockedSendersPayload =
    { deletes: list<EmailSecurityBatchBlockedSendersPayloadDeletes>
      patches: list<string>
      posts: list<``email-securityCreateBlockedSender``>
      puts: list<string> }
    ///Creates an instance of EmailSecurityBatchBlockedSendersPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (deletes: list<EmailSecurityBatchBlockedSendersPayloadDeletes>,
                          patches: list<string>,
                          posts: list<``email-securityCreateBlockedSender``>,
                          puts: list<string>): EmailSecurityBatchBlockedSendersPayload =
        { deletes = deletes
          patches = patches
          posts = posts
          puts = puts }

[<RequireQualifiedAccess>]
type EmailSecurityBatchBlockedSenders =
    ///Batch operation results
    | OK of payload: emailsecuritybatchblockedsendersresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityDeleteBlockedSender =
    ///Deleted blocked sender
    | OK of payload: emailsecuritydeleteblockedsenderresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityGetBlockedSender =
    ///Blocked sender details
    | OK of payload: emailsecuritygetblockedsenderresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityUpdateBlockedSender =
    ///Updated blocked sender
    | OK of payload: emailsecurityupdateblockedsenderresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityListDomains =
    ///List of domains
    | OK of payload: emailsecuritylistdomainsresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityDeleteDomain =
    ///Deleted domain
    | OK of payload: emailsecuritydeletedomainresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityGetDomain =
    ///Domain details
    | OK of payload: emailsecuritygetdomainresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityUpdateDomain =
    ///Updated domain
    | OK of payload: emailsecurityupdatedomainresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityListImpersonationRegistry =
    ///List of impersonation registry entries
    | OK of payload: emailsecuritylistimpersonationregistryresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityCreateImpersonationRegistry =
    ///Created impersonation registry entry
    | Created of payload: emailsecuritycreateimpersonationregistryresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityDeleteImpersonationRegistry =
    ///Deleted impersonation registry entry
    | OK of payload: emailsecuritydeleteimpersonationregistryresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityGetImpersonationRegistry =
    ///Impersonation registry entry details
    | OK of payload: emailsecuritygetimpersonationregistryresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityUpdateImpersonationRegistry =
    ///Updated impersonation registry entry
    | OK of payload: emailsecurityupdateimpersonationregistryresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityListSendingDomainRestrictions =
    ///List of sending domain restrictions
    | OK of payload: emailsecuritylistsendingdomainrestrictionsresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityCreateSendingDomainRestriction =
    ///Created sending domain restriction
    | Created of payload: emailsecuritycreatesendingdomainrestrictionresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

type EmailSecurityBatchSendingDomainRestrictionsPayloadDeletes =
    { ///Sending domain restriction identifier.
      id: ``email-securitySendingDomainRestrictionId`` }
    ///Creates an instance of EmailSecurityBatchSendingDomainRestrictionsPayloadDeletes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``email-securitySendingDomainRestrictionId``): EmailSecurityBatchSendingDomainRestrictionsPayloadDeletes =
        { id = id }

type EmailSecurityBatchSendingDomainRestrictionsPayload =
    { deletes: list<EmailSecurityBatchSendingDomainRestrictionsPayloadDeletes> }
    ///Creates an instance of EmailSecurityBatchSendingDomainRestrictionsPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (deletes: list<EmailSecurityBatchSendingDomainRestrictionsPayloadDeletes>): EmailSecurityBatchSendingDomainRestrictionsPayload =
        { deletes = deletes }

[<RequireQualifiedAccess>]
type EmailSecurityBatchSendingDomainRestrictions =
    ///Batch operation results
    | OK of payload: emailsecuritybatchsendingdomainrestrictionsresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityDeleteSendingDomainRestriction =
    ///Deleted sending domain restriction
    | OK of payload: emailsecuritydeletesendingdomainrestrictionresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityGetSendingDomainRestriction =
    ///Sending domain restriction details
    | OK of payload: emailsecuritygetsendingdomainrestrictionresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityUpdateSendingDomainRestriction =
    ///Updated sending domain restriction
    | OK of payload: emailsecurityupdatesendingdomainrestrictionresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityListTrustedDomains =
    ///List of trusted domains
    | OK of payload: emailsecuritylisttrusteddomainsresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityCreateTrustedDomain =
    ///Created trusted domain
    | Created of payload: emailsecuritycreatetrusteddomainresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

type EmailSecurityBatchTrustedDomainsPayloadDeletes =
    { ///Trusted domain identifier
      id: ``email-securityTrustedDomainId`` }
    ///Creates an instance of EmailSecurityBatchTrustedDomainsPayloadDeletes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``email-securityTrustedDomainId``): EmailSecurityBatchTrustedDomainsPayloadDeletes =
        { id = id }

type EmailSecurityBatchTrustedDomainsPayload =
    { deletes: list<EmailSecurityBatchTrustedDomainsPayloadDeletes>
      patches: list<string>
      posts: list<``email-securityCreateTrustedDomain``>
      puts: list<string> }
    ///Creates an instance of EmailSecurityBatchTrustedDomainsPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (deletes: list<EmailSecurityBatchTrustedDomainsPayloadDeletes>,
                          patches: list<string>,
                          posts: list<``email-securityCreateTrustedDomain``>,
                          puts: list<string>): EmailSecurityBatchTrustedDomainsPayload =
        { deletes = deletes
          patches = patches
          posts = posts
          puts = puts }

[<RequireQualifiedAccess>]
type EmailSecurityBatchTrustedDomains =
    ///Batch operation results
    | OK of payload: emailsecuritybatchtrusteddomainsresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityDeleteTrustedDomain =
    ///Deleted trusted domain
    | OK of payload: emailsecuritydeletetrusteddomainresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityGetTrustedDomain =
    ///Trusted domain details
    | OK of payload: emailsecuritygettrusteddomainresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityUpdateTrustedDomain =
    ///Updated trusted domain
    | OK of payload: emailsecurityupdatetrusteddomainresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityListUrlIgnorePatterns =
    ///List of URL ignore patterns for the provided account
    | OK of payload: emailsecuritylisturlignorepatternsresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityCreateUrlIgnorePattern =
    ///Created URL ignore pattern
    | Created of payload: emailsecuritycreateurlignorepatternresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

type EmailSecurityBatchUrlIgnorePatternsPayloadDeletes =
    { ///URL ignore pattern identifier
      id: ``email-securityUrlIgnorePatternId`` }
    ///Creates an instance of EmailSecurityBatchUrlIgnorePatternsPayloadDeletes with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (id: ``email-securityUrlIgnorePatternId``): EmailSecurityBatchUrlIgnorePatternsPayloadDeletes =
        { id = id }

type EmailSecurityBatchUrlIgnorePatternsPayload =
    { deletes: list<EmailSecurityBatchUrlIgnorePatternsPayloadDeletes>
      patches: list<string>
      posts: list<``email-securityCreateUrlIgnorePattern``>
      puts: list<string> }
    ///Creates an instance of EmailSecurityBatchUrlIgnorePatternsPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (deletes: list<EmailSecurityBatchUrlIgnorePatternsPayloadDeletes>,
                          patches: list<string>,
                          posts: list<``email-securityCreateUrlIgnorePattern``>,
                          puts: list<string>): EmailSecurityBatchUrlIgnorePatternsPayload =
        { deletes = deletes
          patches = patches
          posts = posts
          puts = puts }

[<RequireQualifiedAccess>]
type EmailSecurityBatchUrlIgnorePatterns =
    ///Batch operation results
    | OK of payload: emailsecuritybatchurlignorepatternsresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityDeleteUrlIgnorePattern =
    ///Deleted URL ignore pattern
    | OK of payload: emailsecuritydeleteurlignorepatternresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecurityUpdateUrlIgnorePattern =
    ///Updated URL ignore pattern
    | OK of payload: emailsecurityupdateurlignorepatternresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailSecuritySubmissions =
    ///List of submissions
    | OK of payload: emailsecuritysubmissionsresponse
    | BadRequest of payload: ``email-securityapi-response-common-failure``

[<RequireQualifiedAccess>]
type EmailRoutingDestinationAddressesListDestinationAddresses =
    ///List destination addresses response
    | OK of payload: emaildestinationaddressesresponsecollection

[<RequireQualifiedAccess>]
type EmailRoutingDestinationAddressesCreateADestinationAddress =
    ///Create a destination address response
    | OK of payload: emaildestinationaddressresponsesingle

[<RequireQualifiedAccess>]
type EmailRoutingDestinationAddressesDeleteDestinationAddress =
    ///Delete destination address response
    | OK of payload: emaildestinationaddressresponsesingle

[<RequireQualifiedAccess>]
type EmailRoutingDestinationAddressesGetADestinationAddress =
    ///Get a destination address response
    | OK of payload: emaildestinationaddressresponsesingle

type GetPublicListSuppressionRouting_OKResult =
    { created_at: System.DateTimeOffset
      email: string
      expires_at: System.DateTimeOffset
      id: System.Guid
      reason: string
      zones: Option<list<string>> }

type GetPublicListSuppressionRouting_OK =
    { page: int
      per_page: int
      result: list<GetPublicListSuppressionRouting_OKResult>
      total: int }

type GetPublicListSuppressionRouting_BadRequest = { errors: list<string>; success: bool }

[<RequireQualifiedAccess>]
type GetPublicListSuppressionRouting =
    ///Returns suppressed emails.
    | OK of payload: GetPublicListSuppressionRouting_OK
    ///Bad request.
    | BadRequest of payload: GetPublicListSuppressionRouting_BadRequest

type PostPublicNewSuppressionRoutingPayload =
    { email: string
      expires_at: Option<System.DateTimeOffset> }
    ///Creates an instance of PostPublicNewSuppressionRoutingPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (email: string): PostPublicNewSuppressionRoutingPayload = { email = email; expires_at = None }

type PostPublicNewSuppressionRouting_OKResult = { id: System.Guid }

type PostPublicNewSuppressionRouting_OK =
    { result: PostPublicNewSuppressionRouting_OKResult }

type PostPublicNewSuppressionRouting_BadRequest = { errors: list<string>; success: bool }

[<RequireQualifiedAccess>]
type PostPublicNewSuppressionRouting =
    ///Returns suppression.
    | OK of payload: PostPublicNewSuppressionRouting_OK
    ///Bad request.
    | BadRequest of payload: PostPublicNewSuppressionRouting_BadRequest

type DeletePublicDeleteSuppressionRouting_OK = { success: bool }
type DeletePublicDeleteSuppressionRouting_NotFound = { error: string; success: bool }

[<RequireQualifiedAccess>]
type DeletePublicDeleteSuppressionRouting =
    ///Deletes suppression.
    | OK of payload: DeletePublicDeleteSuppressionRouting_OK
    ///Suppression not found.
    | NotFound of payload: DeletePublicDeleteSuppressionRouting_NotFound

type GetPublicGetSuppressionRouting_OKResult =
    { created_at: System.DateTimeOffset
      email: string
      expires_at: System.DateTimeOffset
      id: System.Guid
      reason: string
      zones: Option<list<string>> }

type GetPublicGetSuppressionRouting_OK =
    { result: GetPublicGetSuppressionRouting_OKResult }

type GetPublicGetSuppressionRouting_NotFound = { error: string; success: bool }

[<RequireQualifiedAccess>]
type GetPublicGetSuppressionRouting =
    ///Returns suppression.
    | OK of payload: GetPublicGetSuppressionRouting_OK
    ///Suppression not found.
    | NotFound of payload: GetPublicGetSuppressionRouting_NotFound

type GetPublicFeedbackStatus_OKResult =
    { count: float
      end_at: System.DateTimeOffset
      start_at: System.DateTimeOffset }

type GetPublicFeedbackStatus_OK =
    { result: GetPublicFeedbackStatus_OKResult }

[<RequireQualifiedAccess>]
type GetPublicFeedbackStatus =
    ///Returns feedback statistics.
    | OK of payload: GetPublicFeedbackStatus_OK

[<RequireQualifiedAccess>]
type EmailSendingGetSendingLimits =
    ///Get sending limits response
    | OK of payload: emailsendinglimitsresponsesingle

type EmailSendingAccountSendBuilder_OKErrors = { code: float; message: string }
type EmailSendingAccountSendBuilder_OKMessages = { code: float; message: string }

type EmailSendingAccountSendBuilder_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type EmailSendingAccountSendBuilder_OK =
    { errors: list<EmailSendingAccountSendBuilder_OKErrors>
      messages: list<EmailSendingAccountSendBuilder_OKMessages>
      result: ``email-sendingEmailSendResponse``
      result_info: Option<EmailSendingAccountSendBuilder_OKResultinfo>
      success: bool }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Message =
    | [<CompiledName "email.sending.error.invalid_request_schema">] EmailSendingErrorInvalid_request_schema
    | [<CompiledName "email.sending.error.email.invalid">] EmailSendingErrorEmailInvalid
    | [<CompiledName "email.sending.error.email.no_content_length">] EmailSendingErrorEmailNo_content_length
    | [<CompiledName "email.sending.error.email.too_big">] EmailSendingErrorEmailToo_big
    member this.Format() =
        match this with
        | EmailSendingErrorInvalid_request_schema -> "email.sending.error.invalid_request_schema"
        | EmailSendingErrorEmailInvalid -> "email.sending.error.email.invalid"
        | EmailSendingErrorEmailNo_content_length -> "email.sending.error.email.no_content_length"
        | EmailSendingErrorEmailToo_big -> "email.sending.error.email.too_big"

type EmailSendingAccountSendBuilder_BadRequestErrors = { message: Message }

type EmailSendingAccountSendBuilder_BadRequest =
    { errors: list<EmailSendingAccountSendBuilder_BadRequestErrors>
      messages: list<string>
      result: obj
      success: bool }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EmailSendingAccountSendBuilder_ForbiddenErrorsMessage =
    | [<CompiledName "email.sending.error.email.sending_disabled">] EmailSendingErrorEmailSending_disabled
    member this.Format() =
        match this with
        | EmailSendingErrorEmailSending_disabled -> "email.sending.error.email.sending_disabled"

type EmailSendingAccountSendBuilder_ForbiddenErrors =
    { code: float
      message: EmailSendingAccountSendBuilder_ForbiddenErrorsMessage }

type EmailSendingAccountSendBuilder_Forbidden =
    { errors: list<EmailSendingAccountSendBuilder_ForbiddenErrors>
      messages: list<string>
      result: obj
      success: bool }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EmailSendingAccountSendBuilder_InternalServerErrorErrorsMessage =
    | [<CompiledName "email.sending.error.internal_server">] EmailSendingErrorInternal_server
    member this.Format() =
        match this with
        | EmailSendingErrorInternal_server -> "email.sending.error.internal_server"

type EmailSendingAccountSendBuilder_InternalServerErrorErrors =
    { code: float
      message: EmailSendingAccountSendBuilder_InternalServerErrorErrorsMessage }

type EmailSendingAccountSendBuilder_InternalServerError =
    { errors: list<EmailSendingAccountSendBuilder_InternalServerErrorErrors>
      messages: list<string>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type EmailSendingAccountSendBuilder =
    ///Email sending results.
    | OK of payload: EmailSendingAccountSendBuilder_OK
    ///Invalid request, generally because of the format/content of the email send request. No email will be sent when this happens.
    | BadRequest of payload: EmailSendingAccountSendBuilder_BadRequest
    ///Email sending is disabled for this zone/account.
    | Forbidden of payload: EmailSendingAccountSendBuilder_Forbidden
    ///An unexpected error while processing the email send request. No email will be sent when this happens.
    | InternalServerError of payload: EmailSendingAccountSendBuilder_InternalServerError

type EmailSendingAccountSendRawMessage_OKErrors = { code: float; message: string }
type EmailSendingAccountSendRawMessage_OKMessages = { code: float; message: string }

type EmailSendingAccountSendRawMessage_OKResultinfo =
    { count: float
      cursor: Option<string>
      page: Option<float>
      per_page: float
      total_count: float }

type EmailSendingAccountSendRawMessage_OK =
    { errors: list<EmailSendingAccountSendRawMessage_OKErrors>
      messages: list<EmailSendingAccountSendRawMessage_OKMessages>
      result: ``email-sendingEmailSendResponse``
      result_info: Option<EmailSendingAccountSendRawMessage_OKResultinfo>
      success: bool }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EmailSendingAccountSendRawMessage_BadRequestErrorsMessage =
    | [<CompiledName "email.sending.error.invalid_request_schema">] EmailSendingErrorInvalid_request_schema
    | [<CompiledName "email.sending.error.email.invalid">] EmailSendingErrorEmailInvalid
    | [<CompiledName "email.sending.error.email.no_content_length">] EmailSendingErrorEmailNo_content_length
    | [<CompiledName "email.sending.error.email.too_big">] EmailSendingErrorEmailToo_big
    member this.Format() =
        match this with
        | EmailSendingErrorInvalid_request_schema -> "email.sending.error.invalid_request_schema"
        | EmailSendingErrorEmailInvalid -> "email.sending.error.email.invalid"
        | EmailSendingErrorEmailNo_content_length -> "email.sending.error.email.no_content_length"
        | EmailSendingErrorEmailToo_big -> "email.sending.error.email.too_big"

type EmailSendingAccountSendRawMessage_BadRequestErrors =
    { message: EmailSendingAccountSendRawMessage_BadRequestErrorsMessage }

type EmailSendingAccountSendRawMessage_BadRequest =
    { errors: list<EmailSendingAccountSendRawMessage_BadRequestErrors>
      messages: list<string>
      result: obj
      success: bool }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EmailSendingAccountSendRawMessage_ForbiddenErrorsMessage =
    | [<CompiledName "email.sending.error.email.sending_disabled">] EmailSendingErrorEmailSending_disabled
    member this.Format() =
        match this with
        | EmailSendingErrorEmailSending_disabled -> "email.sending.error.email.sending_disabled"

type EmailSendingAccountSendRawMessage_ForbiddenErrors =
    { code: float
      message: EmailSendingAccountSendRawMessage_ForbiddenErrorsMessage }

type EmailSendingAccountSendRawMessage_Forbidden =
    { errors: list<EmailSendingAccountSendRawMessage_ForbiddenErrors>
      messages: list<string>
      result: obj
      success: bool }

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EmailSendingAccountSendRawMessage_InternalServerErrorErrorsMessage =
    | [<CompiledName "email.sending.error.internal_server">] EmailSendingErrorInternal_server
    member this.Format() =
        match this with
        | EmailSendingErrorInternal_server -> "email.sending.error.internal_server"

type EmailSendingAccountSendRawMessage_InternalServerErrorErrors =
    { code: float
      message: EmailSendingAccountSendRawMessage_InternalServerErrorErrorsMessage }

type EmailSendingAccountSendRawMessage_InternalServerError =
    { errors: list<EmailSendingAccountSendRawMessage_InternalServerErrorErrors>
      messages: list<string>
      result: obj
      success: bool }

[<RequireQualifiedAccess>]
type EmailSendingAccountSendRawMessage =
    ///Email sending results.
    | OK of payload: EmailSendingAccountSendRawMessage_OK
    ///Invalid request, generally because of the format/content of the email send request. No email will be sent when this happens.
    | BadRequest of payload: EmailSendingAccountSendRawMessage_BadRequest
    ///Email sending is disabled for this zone/account.
    | Forbidden of payload: EmailSendingAccountSendRawMessage_Forbidden
    ///An unexpected error while processing the email send request. No email will be sent when this happens.
    | InternalServerError of payload: EmailSendingAccountSendRawMessage_InternalServerError

type GetPublicListSuppressionSending_OKResult =
    { created_at: System.DateTimeOffset
      email: string
      expires_at: System.DateTimeOffset
      id: System.Guid
      reason: string
      zones: Option<list<string>> }

type GetPublicListSuppressionSending_OK =
    { page: int
      per_page: int
      result: list<GetPublicListSuppressionSending_OKResult>
      total: int }

type GetPublicListSuppressionSending_BadRequest = { errors: list<string>; success: bool }

[<RequireQualifiedAccess>]
type GetPublicListSuppressionSending =
    ///Returns suppressed emails.
    | OK of payload: GetPublicListSuppressionSending_OK
    ///Bad request.
    | BadRequest of payload: GetPublicListSuppressionSending_BadRequest

type PostPublicNewSuppressionSendingPayload =
    { email: string
      expires_at: Option<System.DateTimeOffset> }
    ///Creates an instance of PostPublicNewSuppressionSendingPayload with all optional fields initialized to None. The required fields are parameters of this function
    static member Create (email: string): PostPublicNewSuppressionSendingPayload = { email = email; expires_at = None }

type PostPublicNewSuppressionSending_OKResult = { id: System.Guid }

type PostPublicNewSuppressionSending_OK =
    { result: PostPublicNewSuppressionSending_OKResult }

type PostPublicNewSuppressionSending_BadRequest = { errors: list<string>; success: bool }

[<RequireQualifiedAccess>]
type PostPublicNewSuppressionSending =
    ///Returns suppression.
    | OK of payload: PostPublicNewSuppressionSending_OK
    ///Bad request.
    | BadRequest of payload: PostPublicNewSuppressionSending_BadRequest

type DeletePublicDeleteSuppressionSending_OK = { success: bool }
type DeletePublicDeleteSuppressionSending_NotFound = { error: string; success: bool }

[<RequireQualifiedAccess>]
type DeletePublicDeleteSuppressionSending =
    ///Deletes suppression.
    | OK of payload: DeletePublicDeleteSuppressionSending_OK
    ///Suppression not found.
    | NotFound of payload: DeletePublicDeleteSuppressionSending_NotFound

type GetPublicGetSuppressionSending_OKResult =
    { created_at: System.DateTimeOffset
      email: string
      expires_at: System.DateTimeOffset
      id: System.Guid
      reason: string
      zones: Option<list<string>> }

type GetPublicGetSuppressionSending_OK =
    { result: GetPublicGetSuppressionSending_OKResult }

type GetPublicGetSuppressionSending_NotFound = { error: string; success: bool }

[<RequireQualifiedAccess>]
type GetPublicGetSuppressionSending =
    ///Returns suppression.
    | OK of payload: GetPublicGetSuppressionSending_OK
    ///Suppression not found.
    | NotFound of payload: GetPublicGetSuppressionSending_NotFound
