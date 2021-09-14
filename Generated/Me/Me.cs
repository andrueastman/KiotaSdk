using GraphServiceClient.Drive;
using GraphServiceClient.Groups.Calendar;
using GraphServiceClient.Me.Authentication;
using GraphServiceClient.Me.Planner;
using GraphServiceClient.Me.Teamwork;
using GraphServiceClient.Sites.Onenote;
using GraphServiceClient.Users.InferenceClassification;
using GraphServiceClient.Users.Insights;
using GraphServiceClient.Users.Outlook;
using GraphServiceClient.Users.Settings;
using GraphServiceClient.Users.Todo;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Me {
    public class Me : DirectoryObject, IParsable {
        /// <summary>A freeform text entry field for the user to describe themselves. Returned only on $select.</summary>
        public string AboutMe { get; set; }
        /// <summary>true if the account is enabled; otherwise, false. This property is required when a user is created. Supports $filter (eq, ne, NOT, and in).</summary>
        public bool? AccountEnabled { get; set; }
        /// <summary>The user's activities across devices. Read-only. Nullable.</summary>
        public List<UserActivity> Activities { get; set; }
        /// <summary>Sets the age group of the user. Allowed values: null, minor, notAdult and adult. Refer to the legal age group property definitions for further information. Supports $filter (eq, ne, NOT, and in).</summary>
        public string AgeGroup { get; set; }
        /// <summary>The user's terms of use acceptance statuses. Read-only. Nullable.</summary>
        public List<AgreementAcceptance> AgreementAcceptances { get; set; }
        /// <summary>Represents the app roles a user has been granted for an application. Supports $expand.</summary>
        public List<AppRoleAssignment> AppRoleAssignments { get; set; }
        /// <summary>The licenses that are assigned to the user, including inherited (group-based) licenses. Not nullable. Supports $filter (eq and NOT).</summary>
        public List<AssignedLicense> AssignedLicenses { get; set; }
        /// <summary>The plans that are assigned to the user. Read-only. Not nullable.Supports $filter (eq and NOT).</summary>
        public List<AssignedPlan> AssignedPlans { get; set; }
        public Authentication Authentication { get; set; }
        /// <summary>The birthday of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z Returned only on $select.</summary>
        public DateTimeOffset? Birthday { get; set; }
        /// <summary>The telephone numbers for the user. Only one number can be set for this property. Read-only for users synced from on-premises directory. Supports $filter (eq and NOT).</summary>
        public List<string> BusinessPhones { get; set; }
        /// <summary>The user's primary calendar. Read-only.</summary>
        public Calendar Calendar { get; set; }
        /// <summary>The user's calendar groups. Read-only. Nullable.</summary>
        public List<CalendarGroup> CalendarGroups { get; set; }
        /// <summary>The user's calendars. Read-only. Nullable.</summary>
        public List<Calendar> Calendars { get; set; }
        /// <summary>The calendar view for the calendar. Read-only. Nullable.</summary>
        public List<Event> CalendarView { get; set; }
        public List<Chat> Chats { get; set; }
        /// <summary>The city in which the user is located. Maximum length is 128 characters. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).</summary>
        public string City { get; set; }
        /// <summary>The company name which the user is associated. This property can be useful for describing the company that an external user comes from. The maximum length of the company name is 64 characters.Supports $filter (eq, ne, NOT, ge, le, in, startsWith).</summary>
        public string CompanyName { get; set; }
        /// <summary>Sets whether consent has been obtained for minors. Allowed values: null, granted, denied and notRequired. Refer to the legal age group property definitions for further information. Supports $filter (eq, ne, NOT, and in).</summary>
        public string ConsentProvidedForMinor { get; set; }
        /// <summary>The user's contacts folders. Read-only. Nullable.</summary>
        public List<ContactFolder> ContactFolders { get; set; }
        /// <summary>The user's contacts. Read-only. Nullable.</summary>
        public List<Contact> Contacts { get; set; }
        /// <summary>The country/region in which the user is located; for example, US or UK. Maximum length is 128 characters. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).</summary>
        public string Country { get; set; }
        /// <summary>The date and time the user was created. The value cannot be modified and is automatically populated when the entity is created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. Property is nullable. A null value indicates that an accurate creation time couldn't be determined for the user. Read-only. Supports $filter (eq, ne, NOT , ge, le, and in operators).</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Directory objects that were created by the user. Read-only. Nullable.</summary>
        public List<DirectoryObject> CreatedObjects { get; set; }
        /// <summary>Indicates whether the user account was created as a regular school or work account (null), an external account (Invitation), a local account for an Azure Active Directory B2C tenant (LocalAccount) or self-service sign-up using email verification (EmailVerified). Read-only. Supports $filter (eq, ne, NOT, and in).</summary>
        public string CreationType { get; set; }
        /// <summary>The name for the department in which the user works. Maximum length is 64 characters.Supports $filter (eq, ne, NOT , ge, le, and in operators).</summary>
        public string Department { get; set; }
        /// <summary>The limit on the maximum number of devices that the user is permitted to enroll. Allowed values are 5 or 1000.</summary>
        public int? DeviceEnrollmentLimit { get; set; }
        /// <summary>The list of troubleshooting events for this user.</summary>
        public List<DeviceManagementTroubleshootingEvent> DeviceManagementTroubleshootingEvents { get; set; }
        /// <summary>The users and contacts that report to the user. (The users and contacts that have their manager property set to this user.) Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> DirectReports { get; set; }
        /// <summary>The name displayed in the address book for the user. This value is usually the combination of the user's first name, middle initial, and last name. This property is required when a user is created and it cannot be cleared during updates. Maximum length is 256 characters. Supports $filter (eq, ne, NOT , ge, le, in, startsWith), $orderBy, and $search.</summary>
        public string DisplayName { get; set; }
        /// <summary>The user's OneDrive. Read-only.</summary>
        public Drive Drive { get; set; }
        /// <summary>A collection of drives available for this user. Read-only.</summary>
        public List<Drive> Drives { get; set; }
        /// <summary>The date and time when the user was hired or will start work in case of a future hire. Supports $filter (eq, ne, NOT , ge, le, in).</summary>
        public DateTimeOffset? EmployeeHireDate { get; set; }
        /// <summary>The employee identifier assigned to the user by the organization. Supports $filter (eq, ne, NOT , ge, le, in, startsWith).</summary>
        public string EmployeeId { get; set; }
        /// <summary>Represents organization data (e.g. division and costCenter) associated with a user. Supports $filter (eq, ne, NOT , ge, le, in).</summary>
        public EmployeeOrgData EmployeeOrgData { get; set; }
        /// <summary>Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor. Supports $filter (eq, ne, NOT , ge, le, in, startsWith).</summary>
        public string EmployeeType { get; set; }
        /// <summary>The user's events. Default is to show events under the Default Calendar. Read-only. Nullable.</summary>
        public List<Event> Events { get; set; }
        /// <summary>The collection of open extensions defined for the user. Nullable.</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>For an external user invited to the tenant using the invitation API, this property represents the invited user's invitation status. For invited users, the state can be PendingAcceptance or Accepted, or null for all other users. Supports $filter (eq, ne, NOT , in).</summary>
        public string ExternalUserState { get; set; }
        /// <summary>Shows the timestamp for the latest change to the externalUserState property. Supports $filter (eq, ne, NOT , in).</summary>
        public DateTimeOffset? ExternalUserStateChangeDateTime { get; set; }
        /// <summary>The fax number of the user. Supports $filter (eq, ne, NOT , ge, le, in, startsWith).</summary>
        public string FaxNumber { get; set; }
        public List<Site> FollowedSites { get; set; }
        /// <summary>The given name (first name) of the user. Maximum length is 64 characters. Supports $filter (eq, ne, NOT , ge, le, in, startsWith).</summary>
        public string GivenName { get; set; }
        /// <summary>The hire date of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.  Returned only on $select.  Note: This property is specific to SharePoint Online. We recommend using the native employeeHireDate property to set and update hire date values using Microsoft Graph APIs.</summary>
        public DateTimeOffset? HireDate { get; set; }
        /// <summary>Represents the identities that can be used to sign in to this user account. An identity can be provided by Microsoft (also known as a local account), by organizations, or by social identity providers such as Facebook, Google, and Microsoft, and tied to a user account. May contain multiple items with the same signInType value. Supports $filter (eq) only where the signInType is not userPrincipalName.</summary>
        public List<ObjectIdentity> Identities { get; set; }
        /// <summary>The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user. Read-only. Supports $filter (eq, NOT, ge, le, startsWith).</summary>
        public List<string> ImAddresses { get; set; }
        /// <summary>Relevance classification of the user's messages based on explicit designations which override inferred relevance or importance.</summary>
        public InferenceClassification InferenceClassification { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public OfficeGraphInsights Insights { get; set; }
        /// <summary>A list for the user to describe their interests. Returned only on $select.</summary>
        public List<string> Interests { get; set; }
        /// <summary>Do not use – reserved for future use.</summary>
        public bool? IsResourceAccount { get; set; }
        /// <summary>The user's job title. Maximum length is 128 characters. Supports $filter (eq, ne, NOT , ge, le, in, startsWith).</summary>
        public string JobTitle { get; set; }
        /// <summary>The Microsoft Teams teams that the user is a member of. Read-only. Nullable.</summary>
        public List<Team> JoinedTeams { get; set; }
        /// <summary>The time when this Azure AD user last changed their password. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Returned only on $select.</summary>
        public DateTimeOffset? LastPasswordChangeDateTime { get; set; }
        /// <summary>Used by enterprise applications to determine the legal age group of the user. This property is read-only and calculated based on ageGroup and consentProvidedForMinor properties. Allowed values: null, minorWithOutParentalConsent, minorWithParentalConsent, minorNoParentalConsentRequired, notAdult and adult. Refer to the legal age group property definitions for further information. Returned only on $select.</summary>
        public string LegalAgeGroupClassification { get; set; }
        /// <summary>State of license assignments for this user. Read-only. Returned only on $select.</summary>
        public List<LicenseAssignmentState> LicenseAssignmentStates { get; set; }
        /// <summary>A collection of this user's license details. Read-only.</summary>
        public List<LicenseDetails> LicenseDetails { get; set; }
        /// <summary>The SMTP address for the user, for example, admin@contoso.com. Changes to this property will also update the user's proxyAddresses collection to include the value as an SMTP address. While this property can contain accent characters, using them can cause access issues with other Microsoft applications for the user. Supports $filter (eq, ne, NOT, ge, le, in, startsWith, endsWith).</summary>
        public string Mail { get; set; }
        /// <summary>Settings for the primary mailbox of the signed-in user. You can get or update settings for sending automatic replies to incoming messages, locale, and time zone. Returned only on $select.</summary>
        public MailboxSettings MailboxSettings { get; set; }
        /// <summary>The user's mail folders. Read-only. Nullable.</summary>
        public List<MailFolder> MailFolders { get; set; }
        /// <summary>The mail alias for the user. This property must be specified when a user is created. Maximum length is 64 characters. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).</summary>
        public string MailNickname { get; set; }
        /// <summary>Zero or more managed app registrations that belong to the user.</summary>
        public List<ManagedAppRegistration> ManagedAppRegistrations { get; set; }
        /// <summary>The managed devices associated with the user.</summary>
        public List<ManagedDevice> ManagedDevices { get; set; }
        /// <summary>The user or contact that is this user's manager. Read-only. (HTTP Methods: GET, PUT, DELETE.). Supports $expand.</summary>
        public DirectoryObject Manager { get; set; }
        /// <summary>The groups, directory roles and administrative units that the user is a member of. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> MemberOf { get; set; }
        /// <summary>The messages in a mailbox or folder. Read-only. Nullable.</summary>
        public List<Message> Messages { get; set; }
        /// <summary>The primary cellular telephone number for the user. Read-only for users synced from on-premises directory.  Supports $filter (eq, ne, NOT, ge, le, in, startsWith).</summary>
        public string MobilePhone { get; set; }
        /// <summary>The URL for the user's personal site. Returned only on $select.</summary>
        public string MySite { get; set; }
        public List<OAuth2PermissionGrant> Oauth2PermissionGrants { get; set; }
        /// <summary>The office location in the user's place of business. Maximum length is 128 characters. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).</summary>
        public string OfficeLocation { get; set; }
        /// <summary>Read-only.</summary>
        public Onenote Onenote { get; set; }
        public List<OnlineMeeting> OnlineMeetings { get; set; }
        /// <summary>Contains the on-premises Active Directory distinguished name or DN. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only.</summary>
        public string OnPremisesDistinguishedName { get; set; }
        /// <summary>Contains the on-premises domainFQDN, also called dnsDomainName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only.</summary>
        public string OnPremisesDomainName { get; set; }
        /// <summary>Contains extensionAttributes 1-15 for the user. Note that the individual extension attributes are neither selectable nor filterable. For an onPremisesSyncEnabled user, the source of authority for this set of properties is the on-premises and is read-only and is read-only. For a cloud-only user (where onPremisesSyncEnabled is false), these properties may be set during creation or update. These extension attributes are also known as Exchange custom attributes 1-15. Supports $filter (eq, NOT, ge, le, in).</summary>
        public OnPremisesExtensionAttributes OnPremisesExtensionAttributes { get; set; }
        /// <summary>This property is used to associate an on-premises Active Directory user account to their Azure AD user object. This property must be specified when creating a new user account in the Graph if you are using a federated domain for the user's userPrincipalName (UPN) property. Note: The $ and _ characters cannot be used when specifying this property. Supports $filter (eq, ne, NOT, ge, le, in).</summary>
        public string OnPremisesImmutableId { get; set; }
        /// <summary>Indicates the last time at which the object was synced with the on-premises directory; for example: '2013-02-16T03:04:54Z'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Supports $filter (eq, ne, NOT, ge, le, in).</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
        /// <summary>Errors when using Microsoft synchronization product during provisioning.  Supports $filter (eq, NOT, ge, le).</summary>
        public List<OnPremisesProvisioningError> OnPremisesProvisioningErrors { get; set; }
        /// <summary>Contains the on-premises sAMAccountName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).</summary>
        public string OnPremisesSamAccountName { get; set; }
        /// <summary>Contains the on-premises security identifier (SID) for the user that was synchronized from on-premises to the cloud. Read-only.</summary>
        public string OnPremisesSecurityIdentifier { get; set; }
        /// <summary>true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only. Supports $filter (eq, ne, NOT, in).</summary>
        public bool? OnPremisesSyncEnabled { get; set; }
        /// <summary>Contains the on-premises userPrincipalName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).</summary>
        public string OnPremisesUserPrincipalName { get; set; }
        /// <summary>A list of additional email addresses for the user; for example: ['bob@contoso.com', 'Robert@fabrikam.com'].NOTE: While this property can contain accent characters, they can cause access issues to first-party applications for the user.Supports $filter (eq, NOT, ge, le, in, startsWith).</summary>
        public List<string> OtherMails { get; set; }
        /// <summary>Selective Outlook services available to the user. Read-only. Nullable.</summary>
        public OutlookUser Outlook { get; set; }
        /// <summary>Devices that are owned by the user. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> OwnedDevices { get; set; }
        /// <summary>Directory objects that are owned by the user. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> OwnedObjects { get; set; }
        /// <summary>Specifies password policies for the user. This value is an enumeration with one possible value being DisableStrongPassword, which allows weaker passwords than the default policy to be specified. DisablePasswordExpiration can also be specified. The two may be specified together; for example: DisablePasswordExpiration, DisableStrongPassword.Supports $filter (ne, NOT).</summary>
        public string PasswordPolicies { get; set; }
        /// <summary>Specifies the password profile for the user. The profile contains the user's password. This property is required when a user is created. The password in the profile must satisfy minimum requirements as specified by the passwordPolicies property. By default, a strong password is required. NOTE: For Azure B2C tenants, the forceChangePasswordNextSignIn property should be set to false and instead use custom policies and user flows to force password reset at first logon. See Force password reset at first logon. Supports $filter (eq, ne, NOT, in).</summary>
        public PasswordProfile PasswordProfile { get; set; }
        /// <summary>A list for the user to enumerate their past projects. Returned only on $select.</summary>
        public List<string> PastProjects { get; set; }
        /// <summary>Read-only. The most relevant people to the user. The collection is ordered by their relevance to the user, which is determined by the user's communication, collaboration and business relationships. A person is an aggregation of information from across mail, contacts and social networks.</summary>
        public List<Person> People { get; set; }
        /// <summary>The user's profile photo. Read-only.</summary>
        public ProfilePhoto Photo { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<ProfilePhoto> Photos { get; set; }
        /// <summary>Selective Planner services available to the user. Read-only. Nullable.</summary>
        public PlannerUser Planner { get; set; }
        /// <summary>The postal code for the user's postal address. The postal code is specific to the user's country/region. In the United States of America, this attribute contains the ZIP code. Maximum length is 40 characters. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).</summary>
        public string PostalCode { get; set; }
        /// <summary>The preferred language for the user. Should follow ISO 639-1 Code; for example en-US. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).</summary>
        public string PreferredLanguage { get; set; }
        /// <summary>The preferred name for the user. Returned only on $select.</summary>
        public string PreferredName { get; set; }
        public Presence Presence { get; set; }
        /// <summary>The plans that are provisioned for the user. Read-only. Not nullable. Supports $filter (eq, NOT, ge, le).</summary>
        public List<ProvisionedPlan> ProvisionedPlans { get; set; }
        /// <summary>For example: ['SMTP: bob@contoso.com', 'smtp: bob@sales.contoso.com']. Read-only, Not nullable. Supports $filter (eq, NOT, ge, le, startsWith).</summary>
        public List<string> ProxyAddresses { get; set; }
        /// <summary>Devices that are registered for the user. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> RegisteredDevices { get; set; }
        /// <summary>A list for the user to enumerate their responsibilities. Returned only on $select.</summary>
        public List<string> Responsibilities { get; set; }
        /// <summary>A list for the user to enumerate the schools they have attended. Returned only on $select.</summary>
        public List<string> Schools { get; set; }
        /// <summary>The scoped-role administrative unit memberships for this user. Read-only. Nullable.</summary>
        public List<ScopedRoleMembership> ScopedRoleMemberOf { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public UserSettings Settings { get; set; }
        /// <summary>true if the Outlook global address list should contain this user, otherwise false. If not set, this will be treated as true. For users invited through the invitation manager, this property will be set to false. Supports $filter (eq, ne, NOT, in).</summary>
        public bool? ShowInAddressList { get; set; }
        /// <summary>Any refresh tokens or sessions tokens (session cookies) issued before this time are invalid, and applications will get an error when using an invalid refresh or sessions token to acquire a delegated access token (to access APIs such as Microsoft Graph).  If this happens, the application will need to acquire a new refresh token by making a request to the authorize endpoint. Read-only. Use revokeSignInSessions to reset.</summary>
        public DateTimeOffset? SignInSessionsValidFromDateTime { get; set; }
        /// <summary>A list for the user to enumerate their skills. Returned only on $select.</summary>
        public List<string> Skills { get; set; }
        /// <summary>The state or province in the user's address. Maximum length is 128 characters. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).</summary>
        public string State { get; set; }
        /// <summary>The street address of the user's place of business. Maximum length is 1024 characters. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).</summary>
        public string StreetAddress { get; set; }
        /// <summary>The user's surname (family name or last name). Maximum length is 64 characters. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).</summary>
        public string Surname { get; set; }
        /// <summary>A container for Microsoft Teams features available for the user. Read-only. Nullable.</summary>
        public UserTeamwork Teamwork { get; set; }
        /// <summary>Represents the To Do services available to a user.</summary>
        public Todo Todo { get; set; }
        public List<DirectoryObject> TransitiveMemberOf { get; set; }
        /// <summary>A two letter country code (ISO standard 3166). Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries.  Examples include: US, JP, and GB. Not nullable. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).</summary>
        public string UsageLocation { get; set; }
        /// <summary>The user principal name (UPN) of the user. The UPN is an Internet-style login name for the user based on the Internet standard RFC 822. By convention, this should map to the user's email name. The general format is alias@domain, where domain must be present in the tenant's collection of verified domains. This property is required when a user is created. The verified domains for the tenant can be accessed from the verifiedDomains property of organization.NOTE: While this property can contain accent characters, they can cause access issues to first-party applications for the user. Supports $filter (eq, ne, NOT, ge, le, in, startsWith, endsWith) and $orderBy.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>A string value that can be used to classify user types in your directory, such as Member and Guest. Supports $filter (eq, ne, NOT, in,).</summary>
        public string UserType { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"aboutMe", (o,n) => { (o as Me).AboutMe = n.GetStringValue(); } },
                {"accountEnabled", (o,n) => { (o as Me).AccountEnabled = n.GetBoolValue(); } },
                {"activities", (o,n) => { (o as Me).Activities = n.GetCollectionOfObjectValues<UserActivity>().ToList(); } },
                {"ageGroup", (o,n) => { (o as Me).AgeGroup = n.GetStringValue(); } },
                {"agreementAcceptances", (o,n) => { (o as Me).AgreementAcceptances = n.GetCollectionOfObjectValues<AgreementAcceptance>().ToList(); } },
                {"appRoleAssignments", (o,n) => { (o as Me).AppRoleAssignments = n.GetCollectionOfObjectValues<AppRoleAssignment>().ToList(); } },
                {"assignedLicenses", (o,n) => { (o as Me).AssignedLicenses = n.GetCollectionOfObjectValues<AssignedLicense>().ToList(); } },
                {"assignedPlans", (o,n) => { (o as Me).AssignedPlans = n.GetCollectionOfObjectValues<AssignedPlan>().ToList(); } },
                {"authentication", (o,n) => { (o as Me).Authentication = n.GetObjectValue<Authentication>(); } },
                {"birthday", (o,n) => { (o as Me).Birthday = n.GetDateTimeOffsetValue(); } },
                {"businessPhones", (o,n) => { (o as Me).BusinessPhones = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"calendar", (o,n) => { (o as Me).Calendar = n.GetObjectValue<Calendar>(); } },
                {"calendarGroups", (o,n) => { (o as Me).CalendarGroups = n.GetCollectionOfObjectValues<CalendarGroup>().ToList(); } },
                {"calendars", (o,n) => { (o as Me).Calendars = n.GetCollectionOfObjectValues<Calendar>().ToList(); } },
                {"calendarView", (o,n) => { (o as Me).CalendarView = n.GetCollectionOfObjectValues<Event>().ToList(); } },
                {"chats", (o,n) => { (o as Me).Chats = n.GetCollectionOfObjectValues<Chat>().ToList(); } },
                {"city", (o,n) => { (o as Me).City = n.GetStringValue(); } },
                {"companyName", (o,n) => { (o as Me).CompanyName = n.GetStringValue(); } },
                {"consentProvidedForMinor", (o,n) => { (o as Me).ConsentProvidedForMinor = n.GetStringValue(); } },
                {"contactFolders", (o,n) => { (o as Me).ContactFolders = n.GetCollectionOfObjectValues<ContactFolder>().ToList(); } },
                {"contacts", (o,n) => { (o as Me).Contacts = n.GetCollectionOfObjectValues<Contact>().ToList(); } },
                {"country", (o,n) => { (o as Me).Country = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as Me).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdObjects", (o,n) => { (o as Me).CreatedObjects = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"creationType", (o,n) => { (o as Me).CreationType = n.GetStringValue(); } },
                {"department", (o,n) => { (o as Me).Department = n.GetStringValue(); } },
                {"deviceEnrollmentLimit", (o,n) => { (o as Me).DeviceEnrollmentLimit = n.GetIntValue(); } },
                {"deviceManagementTroubleshootingEvents", (o,n) => { (o as Me).DeviceManagementTroubleshootingEvents = n.GetCollectionOfObjectValues<DeviceManagementTroubleshootingEvent>().ToList(); } },
                {"directReports", (o,n) => { (o as Me).DirectReports = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"displayName", (o,n) => { (o as Me).DisplayName = n.GetStringValue(); } },
                {"drive", (o,n) => { (o as Me).Drive = n.GetObjectValue<Drive>(); } },
                {"drives", (o,n) => { (o as Me).Drives = n.GetCollectionOfObjectValues<Drive>().ToList(); } },
                {"employeeHireDate", (o,n) => { (o as Me).EmployeeHireDate = n.GetDateTimeOffsetValue(); } },
                {"employeeId", (o,n) => { (o as Me).EmployeeId = n.GetStringValue(); } },
                {"employeeOrgData", (o,n) => { (o as Me).EmployeeOrgData = n.GetObjectValue<EmployeeOrgData>(); } },
                {"employeeType", (o,n) => { (o as Me).EmployeeType = n.GetStringValue(); } },
                {"events", (o,n) => { (o as Me).Events = n.GetCollectionOfObjectValues<Event>().ToList(); } },
                {"extensions", (o,n) => { (o as Me).Extensions = n.GetCollectionOfObjectValues<Extension>().ToList(); } },
                {"externalUserState", (o,n) => { (o as Me).ExternalUserState = n.GetStringValue(); } },
                {"externalUserStateChangeDateTime", (o,n) => { (o as Me).ExternalUserStateChangeDateTime = n.GetDateTimeOffsetValue(); } },
                {"faxNumber", (o,n) => { (o as Me).FaxNumber = n.GetStringValue(); } },
                {"followedSites", (o,n) => { (o as Me).FollowedSites = n.GetCollectionOfObjectValues<Site>().ToList(); } },
                {"givenName", (o,n) => { (o as Me).GivenName = n.GetStringValue(); } },
                {"hireDate", (o,n) => { (o as Me).HireDate = n.GetDateTimeOffsetValue(); } },
                {"identities", (o,n) => { (o as Me).Identities = n.GetCollectionOfPrimitiveValues<ObjectIdentity>().ToList(); } },
                {"imAddresses", (o,n) => { (o as Me).ImAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"inferenceClassification", (o,n) => { (o as Me).InferenceClassification = n.GetObjectValue<InferenceClassification>(); } },
                {"insights", (o,n) => { (o as Me).Insights = n.GetObjectValue<OfficeGraphInsights>(); } },
                {"interests", (o,n) => { (o as Me).Interests = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isResourceAccount", (o,n) => { (o as Me).IsResourceAccount = n.GetBoolValue(); } },
                {"jobTitle", (o,n) => { (o as Me).JobTitle = n.GetStringValue(); } },
                {"joinedTeams", (o,n) => { (o as Me).JoinedTeams = n.GetCollectionOfObjectValues<Team>().ToList(); } },
                {"lastPasswordChangeDateTime", (o,n) => { (o as Me).LastPasswordChangeDateTime = n.GetDateTimeOffsetValue(); } },
                {"legalAgeGroupClassification", (o,n) => { (o as Me).LegalAgeGroupClassification = n.GetStringValue(); } },
                {"licenseAssignmentStates", (o,n) => { (o as Me).LicenseAssignmentStates = n.GetCollectionOfPrimitiveValues<LicenseAssignmentState>().ToList(); } },
                {"licenseDetails", (o,n) => { (o as Me).LicenseDetails = n.GetCollectionOfObjectValues<LicenseDetails>().ToList(); } },
                {"mail", (o,n) => { (o as Me).Mail = n.GetStringValue(); } },
                {"mailboxSettings", (o,n) => { (o as Me).MailboxSettings = n.GetObjectValue<MailboxSettings>(); } },
                {"mailFolders", (o,n) => { (o as Me).MailFolders = n.GetCollectionOfObjectValues<MailFolder>().ToList(); } },
                {"mailNickname", (o,n) => { (o as Me).MailNickname = n.GetStringValue(); } },
                {"managedAppRegistrations", (o,n) => { (o as Me).ManagedAppRegistrations = n.GetCollectionOfObjectValues<ManagedAppRegistration>().ToList(); } },
                {"managedDevices", (o,n) => { (o as Me).ManagedDevices = n.GetCollectionOfObjectValues<ManagedDevice>().ToList(); } },
                {"manager", (o,n) => { (o as Me).Manager = n.GetObjectValue<DirectoryObject>(); } },
                {"memberOf", (o,n) => { (o as Me).MemberOf = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"messages", (o,n) => { (o as Me).Messages = n.GetCollectionOfObjectValues<Message>().ToList(); } },
                {"mobilePhone", (o,n) => { (o as Me).MobilePhone = n.GetStringValue(); } },
                {"mySite", (o,n) => { (o as Me).MySite = n.GetStringValue(); } },
                {"oauth2PermissionGrants", (o,n) => { (o as Me).Oauth2PermissionGrants = n.GetCollectionOfObjectValues<OAuth2PermissionGrant>().ToList(); } },
                {"officeLocation", (o,n) => { (o as Me).OfficeLocation = n.GetStringValue(); } },
                {"onenote", (o,n) => { (o as Me).Onenote = n.GetObjectValue<Onenote>(); } },
                {"onlineMeetings", (o,n) => { (o as Me).OnlineMeetings = n.GetCollectionOfObjectValues<OnlineMeeting>().ToList(); } },
                {"onPremisesDistinguishedName", (o,n) => { (o as Me).OnPremisesDistinguishedName = n.GetStringValue(); } },
                {"onPremisesDomainName", (o,n) => { (o as Me).OnPremisesDomainName = n.GetStringValue(); } },
                {"onPremisesExtensionAttributes", (o,n) => { (o as Me).OnPremisesExtensionAttributes = n.GetObjectValue<OnPremisesExtensionAttributes>(); } },
                {"onPremisesImmutableId", (o,n) => { (o as Me).OnPremisesImmutableId = n.GetStringValue(); } },
                {"onPremisesLastSyncDateTime", (o,n) => { (o as Me).OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"onPremisesProvisioningErrors", (o,n) => { (o as Me).OnPremisesProvisioningErrors = n.GetCollectionOfPrimitiveValues<OnPremisesProvisioningError>().ToList(); } },
                {"onPremisesSamAccountName", (o,n) => { (o as Me).OnPremisesSamAccountName = n.GetStringValue(); } },
                {"onPremisesSecurityIdentifier", (o,n) => { (o as Me).OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                {"onPremisesSyncEnabled", (o,n) => { (o as Me).OnPremisesSyncEnabled = n.GetBoolValue(); } },
                {"onPremisesUserPrincipalName", (o,n) => { (o as Me).OnPremisesUserPrincipalName = n.GetStringValue(); } },
                {"otherMails", (o,n) => { (o as Me).OtherMails = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"outlook", (o,n) => { (o as Me).Outlook = n.GetObjectValue<OutlookUser>(); } },
                {"ownedDevices", (o,n) => { (o as Me).OwnedDevices = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"ownedObjects", (o,n) => { (o as Me).OwnedObjects = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"passwordPolicies", (o,n) => { (o as Me).PasswordPolicies = n.GetStringValue(); } },
                {"passwordProfile", (o,n) => { (o as Me).PasswordProfile = n.GetObjectValue<PasswordProfile>(); } },
                {"pastProjects", (o,n) => { (o as Me).PastProjects = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"people", (o,n) => { (o as Me).People = n.GetCollectionOfObjectValues<Person>().ToList(); } },
                {"photo", (o,n) => { (o as Me).Photo = n.GetObjectValue<ProfilePhoto>(); } },
                {"photos", (o,n) => { (o as Me).Photos = n.GetCollectionOfObjectValues<ProfilePhoto>().ToList(); } },
                {"planner", (o,n) => { (o as Me).Planner = n.GetObjectValue<PlannerUser>(); } },
                {"postalCode", (o,n) => { (o as Me).PostalCode = n.GetStringValue(); } },
                {"preferredLanguage", (o,n) => { (o as Me).PreferredLanguage = n.GetStringValue(); } },
                {"preferredName", (o,n) => { (o as Me).PreferredName = n.GetStringValue(); } },
                {"presence", (o,n) => { (o as Me).Presence = n.GetObjectValue<Presence>(); } },
                {"provisionedPlans", (o,n) => { (o as Me).ProvisionedPlans = n.GetCollectionOfObjectValues<ProvisionedPlan>().ToList(); } },
                {"proxyAddresses", (o,n) => { (o as Me).ProxyAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"registeredDevices", (o,n) => { (o as Me).RegisteredDevices = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"responsibilities", (o,n) => { (o as Me).Responsibilities = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"schools", (o,n) => { (o as Me).Schools = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"scopedRoleMemberOf", (o,n) => { (o as Me).ScopedRoleMemberOf = n.GetCollectionOfObjectValues<ScopedRoleMembership>().ToList(); } },
                {"settings", (o,n) => { (o as Me).Settings = n.GetObjectValue<UserSettings>(); } },
                {"showInAddressList", (o,n) => { (o as Me).ShowInAddressList = n.GetBoolValue(); } },
                {"signInSessionsValidFromDateTime", (o,n) => { (o as Me).SignInSessionsValidFromDateTime = n.GetDateTimeOffsetValue(); } },
                {"skills", (o,n) => { (o as Me).Skills = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"state", (o,n) => { (o as Me).State = n.GetStringValue(); } },
                {"streetAddress", (o,n) => { (o as Me).StreetAddress = n.GetStringValue(); } },
                {"surname", (o,n) => { (o as Me).Surname = n.GetStringValue(); } },
                {"teamwork", (o,n) => { (o as Me).Teamwork = n.GetObjectValue<UserTeamwork>(); } },
                {"todo", (o,n) => { (o as Me).Todo = n.GetObjectValue<Todo>(); } },
                {"transitiveMemberOf", (o,n) => { (o as Me).TransitiveMemberOf = n.GetCollectionOfObjectValues<DirectoryObject>().ToList(); } },
                {"usageLocation", (o,n) => { (o as Me).UsageLocation = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as Me).UserPrincipalName = n.GetStringValue(); } },
                {"userType", (o,n) => { (o as Me).UserType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("aboutMe", AboutMe);
            writer.WriteBoolValue("accountEnabled", AccountEnabled);
            writer.WriteCollectionOfObjectValues<UserActivity>("activities", Activities);
            writer.WriteStringValue("ageGroup", AgeGroup);
            writer.WriteCollectionOfObjectValues<AgreementAcceptance>("agreementAcceptances", AgreementAcceptances);
            writer.WriteCollectionOfObjectValues<AppRoleAssignment>("appRoleAssignments", AppRoleAssignments);
            writer.WriteCollectionOfObjectValues<AssignedLicense>("assignedLicenses", AssignedLicenses);
            writer.WriteCollectionOfObjectValues<AssignedPlan>("assignedPlans", AssignedPlans);
            writer.WriteObjectValue<Authentication>("authentication", Authentication);
            writer.WriteDateTimeOffsetValue("birthday", Birthday);
            writer.WriteCollectionOfPrimitiveValues<string>("businessPhones", BusinessPhones);
            writer.WriteObjectValue<Calendar>("calendar", Calendar);
            writer.WriteCollectionOfObjectValues<CalendarGroup>("calendarGroups", CalendarGroups);
            writer.WriteCollectionOfObjectValues<Calendar>("calendars", Calendars);
            writer.WriteCollectionOfObjectValues<Event>("calendarView", CalendarView);
            writer.WriteCollectionOfObjectValues<Chat>("chats", Chats);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("consentProvidedForMinor", ConsentProvidedForMinor);
            writer.WriteCollectionOfObjectValues<ContactFolder>("contactFolders", ContactFolders);
            writer.WriteCollectionOfObjectValues<Contact>("contacts", Contacts);
            writer.WriteStringValue("country", Country);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("createdObjects", CreatedObjects);
            writer.WriteStringValue("creationType", CreationType);
            writer.WriteStringValue("department", Department);
            writer.WriteIntValue("deviceEnrollmentLimit", DeviceEnrollmentLimit);
            writer.WriteCollectionOfObjectValues<DeviceManagementTroubleshootingEvent>("deviceManagementTroubleshootingEvents", DeviceManagementTroubleshootingEvents);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("directReports", DirectReports);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<Drive>("drives", Drives);
            writer.WriteDateTimeOffsetValue("employeeHireDate", EmployeeHireDate);
            writer.WriteStringValue("employeeId", EmployeeId);
            writer.WriteObjectValue<EmployeeOrgData>("employeeOrgData", EmployeeOrgData);
            writer.WriteStringValue("employeeType", EmployeeType);
            writer.WriteCollectionOfObjectValues<Event>("events", Events);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteStringValue("externalUserState", ExternalUserState);
            writer.WriteDateTimeOffsetValue("externalUserStateChangeDateTime", ExternalUserStateChangeDateTime);
            writer.WriteStringValue("faxNumber", FaxNumber);
            writer.WriteCollectionOfObjectValues<Site>("followedSites", FollowedSites);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteDateTimeOffsetValue("hireDate", HireDate);
            writer.WriteCollectionOfPrimitiveValues<ObjectIdentity>("identities", Identities);
            writer.WriteCollectionOfPrimitiveValues<string>("imAddresses", ImAddresses);
            writer.WriteObjectValue<InferenceClassification>("inferenceClassification", InferenceClassification);
            writer.WriteObjectValue<OfficeGraphInsights>("insights", Insights);
            writer.WriteCollectionOfPrimitiveValues<string>("interests", Interests);
            writer.WriteBoolValue("isResourceAccount", IsResourceAccount);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteCollectionOfObjectValues<Team>("joinedTeams", JoinedTeams);
            writer.WriteDateTimeOffsetValue("lastPasswordChangeDateTime", LastPasswordChangeDateTime);
            writer.WriteStringValue("legalAgeGroupClassification", LegalAgeGroupClassification);
            writer.WriteCollectionOfPrimitiveValues<LicenseAssignmentState>("licenseAssignmentStates", LicenseAssignmentStates);
            writer.WriteCollectionOfObjectValues<LicenseDetails>("licenseDetails", LicenseDetails);
            writer.WriteStringValue("mail", Mail);
            writer.WriteObjectValue<MailboxSettings>("mailboxSettings", MailboxSettings);
            writer.WriteCollectionOfObjectValues<MailFolder>("mailFolders", MailFolders);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteCollectionOfObjectValues<ManagedAppRegistration>("managedAppRegistrations", ManagedAppRegistrations);
            writer.WriteCollectionOfObjectValues<ManagedDevice>("managedDevices", ManagedDevices);
            writer.WriteObjectValue<DirectoryObject>("manager", Manager);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("memberOf", MemberOf);
            writer.WriteCollectionOfObjectValues<Message>("messages", Messages);
            writer.WriteStringValue("mobilePhone", MobilePhone);
            writer.WriteStringValue("mySite", MySite);
            writer.WriteCollectionOfObjectValues<OAuth2PermissionGrant>("oauth2PermissionGrants", Oauth2PermissionGrants);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteObjectValue<Onenote>("onenote", Onenote);
            writer.WriteCollectionOfObjectValues<OnlineMeeting>("onlineMeetings", OnlineMeetings);
            writer.WriteStringValue("onPremisesDistinguishedName", OnPremisesDistinguishedName);
            writer.WriteStringValue("onPremisesDomainName", OnPremisesDomainName);
            writer.WriteObjectValue<OnPremisesExtensionAttributes>("onPremisesExtensionAttributes", OnPremisesExtensionAttributes);
            writer.WriteStringValue("onPremisesImmutableId", OnPremisesImmutableId);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteCollectionOfPrimitiveValues<OnPremisesProvisioningError>("onPremisesProvisioningErrors", OnPremisesProvisioningErrors);
            writer.WriteStringValue("onPremisesSamAccountName", OnPremisesSamAccountName);
            writer.WriteStringValue("onPremisesSecurityIdentifier", OnPremisesSecurityIdentifier);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteStringValue("onPremisesUserPrincipalName", OnPremisesUserPrincipalName);
            writer.WriteCollectionOfPrimitiveValues<string>("otherMails", OtherMails);
            writer.WriteObjectValue<OutlookUser>("outlook", Outlook);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("ownedDevices", OwnedDevices);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("ownedObjects", OwnedObjects);
            writer.WriteStringValue("passwordPolicies", PasswordPolicies);
            writer.WriteObjectValue<PasswordProfile>("passwordProfile", PasswordProfile);
            writer.WriteCollectionOfPrimitiveValues<string>("pastProjects", PastProjects);
            writer.WriteCollectionOfObjectValues<Person>("people", People);
            writer.WriteObjectValue<ProfilePhoto>("photo", Photo);
            writer.WriteCollectionOfObjectValues<ProfilePhoto>("photos", Photos);
            writer.WriteObjectValue<PlannerUser>("planner", Planner);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("preferredLanguage", PreferredLanguage);
            writer.WriteStringValue("preferredName", PreferredName);
            writer.WriteObjectValue<Presence>("presence", Presence);
            writer.WriteCollectionOfObjectValues<ProvisionedPlan>("provisionedPlans", ProvisionedPlans);
            writer.WriteCollectionOfPrimitiveValues<string>("proxyAddresses", ProxyAddresses);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("registeredDevices", RegisteredDevices);
            writer.WriteCollectionOfPrimitiveValues<string>("responsibilities", Responsibilities);
            writer.WriteCollectionOfPrimitiveValues<string>("schools", Schools);
            writer.WriteCollectionOfObjectValues<ScopedRoleMembership>("scopedRoleMemberOf", ScopedRoleMemberOf);
            writer.WriteObjectValue<UserSettings>("settings", Settings);
            writer.WriteBoolValue("showInAddressList", ShowInAddressList);
            writer.WriteDateTimeOffsetValue("signInSessionsValidFromDateTime", SignInSessionsValidFromDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("skills", Skills);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("streetAddress", StreetAddress);
            writer.WriteStringValue("surname", Surname);
            writer.WriteObjectValue<UserTeamwork>("teamwork", Teamwork);
            writer.WriteObjectValue<Todo>("todo", Todo);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveMemberOf", TransitiveMemberOf);
            writer.WriteStringValue("usageLocation", UsageLocation);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteStringValue("userType", UserType);
        }
    }
}
