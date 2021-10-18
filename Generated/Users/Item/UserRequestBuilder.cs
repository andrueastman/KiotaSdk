using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Users.Item.Activities;
using ApiSdk.Users.Item.AgreementAcceptances;
using ApiSdk.Users.Item.AppRoleAssignments;
using ApiSdk.Users.Item.AssignLicense;
using ApiSdk.Users.Item.Authentication;
using ApiSdk.Users.Item.Calendar;
using ApiSdk.Users.Item.CalendarGroups;
using ApiSdk.Users.Item.Calendars;
using ApiSdk.Users.Item.CalendarView;
using ApiSdk.Users.Item.ChangePassword;
using ApiSdk.Users.Item.Chats;
using ApiSdk.Users.Item.CheckMemberGroups;
using ApiSdk.Users.Item.CheckMemberObjects;
using ApiSdk.Users.Item.ContactFolders;
using ApiSdk.Users.Item.Contacts;
using ApiSdk.Users.Item.CreatedObjects;
using ApiSdk.Users.Item.DeviceManagementTroubleshootingEvents;
using ApiSdk.Users.Item.DirectReports;
using ApiSdk.Users.Item.Drive;
using ApiSdk.Users.Item.Drives;
using ApiSdk.Users.Item.Events;
using ApiSdk.Users.Item.ExportPersonalData;
using ApiSdk.Users.Item.Extensions;
using ApiSdk.Users.Item.FindMeetingTimes;
using ApiSdk.Users.Item.FollowedSites;
using ApiSdk.Users.Item.GetMailTips;
using ApiSdk.Users.Item.GetManagedAppDiagnosticStatuses;
using ApiSdk.Users.Item.GetManagedAppPolicies;
using ApiSdk.Users.Item.GetMemberGroups;
using ApiSdk.Users.Item.GetMemberObjects;
using ApiSdk.Users.Item.InferenceClassification;
using ApiSdk.Users.Item.Insights;
using ApiSdk.Users.Item.JoinedTeams;
using ApiSdk.Users.Item.LicenseDetails;
using ApiSdk.Users.Item.MailFolders;
using ApiSdk.Users.Item.ManagedAppRegistrations;
using ApiSdk.Users.Item.ManagedDevices;
using ApiSdk.Users.Item.Manager;
using ApiSdk.Users.Item.MemberOf;
using ApiSdk.Users.Item.Messages;
using ApiSdk.Users.Item.Oauth2PermissionGrants;
using ApiSdk.Users.Item.Onenote;
using ApiSdk.Users.Item.OnlineMeetings;
using ApiSdk.Users.Item.Outlook;
using ApiSdk.Users.Item.OwnedDevices;
using ApiSdk.Users.Item.OwnedObjects;
using ApiSdk.Users.Item.People;
using ApiSdk.Users.Item.Photo;
using ApiSdk.Users.Item.Photos;
using ApiSdk.Users.Item.Planner;
using ApiSdk.Users.Item.Presence;
using ApiSdk.Users.Item.RegisteredDevices;
using ApiSdk.Users.Item.ReminderViewWithStartDateTimeWithEndDateTime;
using ApiSdk.Users.Item.RemoveAllDevicesFromManagement;
using ApiSdk.Users.Item.ReprocessLicenseAssignment;
using ApiSdk.Users.Item.Restore;
using ApiSdk.Users.Item.RevokeSignInSessions;
using ApiSdk.Users.Item.ScopedRoleMemberOf;
using ApiSdk.Users.Item.SendMail;
using ApiSdk.Users.Item.Settings;
using ApiSdk.Users.Item.Teamwork;
using ApiSdk.Users.Item.Todo;
using ApiSdk.Users.Item.TransitiveMemberOf;
using ApiSdk.Users.Item.TranslateExchangeIds;
using ApiSdk.Users.Item.WipeManagedAppRegistrationsByDeviceTag;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item {
    /// <summary>Builds and executes requests for operations under \users\{user-id}</summary>
    public class UserRequestBuilder {
        public ActivitiesRequestBuilder Activities { get =>
            new ActivitiesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AgreementAcceptancesRequestBuilder AgreementAcceptances { get =>
            new AgreementAcceptancesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AssignLicenseRequestBuilder AssignLicense { get =>
            new AssignLicenseRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AuthenticationRequestBuilder Authentication { get =>
            new AuthenticationRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CalendarRequestBuilder Calendar { get =>
            new CalendarRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CalendarGroupsRequestBuilder CalendarGroups { get =>
            new CalendarGroupsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CalendarsRequestBuilder Calendars { get =>
            new CalendarsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CalendarViewRequestBuilder CalendarView { get =>
            new CalendarViewRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ChangePasswordRequestBuilder ChangePassword { get =>
            new ChangePasswordRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ChatsRequestBuilder Chats { get =>
            new ChatsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CheckMemberGroupsRequestBuilder CheckMemberGroups { get =>
            new CheckMemberGroupsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CheckMemberObjectsRequestBuilder CheckMemberObjects { get =>
            new CheckMemberObjectsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ContactFoldersRequestBuilder ContactFolders { get =>
            new ContactFoldersRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ContactsRequestBuilder Contacts { get =>
            new ContactsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CreatedObjectsRequestBuilder CreatedObjects { get =>
            new CreatedObjectsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DeviceManagementTroubleshootingEventsRequestBuilder DeviceManagementTroubleshootingEvents { get =>
            new DeviceManagementTroubleshootingEventsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DirectReportsRequestBuilder DirectReports { get =>
            new DirectReportsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DriveRequestBuilder Drive { get =>
            new DriveRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public EventsRequestBuilder Events { get =>
            new EventsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ExportPersonalDataRequestBuilder ExportPersonalData { get =>
            new ExportPersonalDataRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ExtensionsRequestBuilder Extensions { get =>
            new ExtensionsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public FindMeetingTimesRequestBuilder FindMeetingTimes { get =>
            new FindMeetingTimesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public FollowedSitesRequestBuilder FollowedSites { get =>
            new FollowedSitesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public GetMailTipsRequestBuilder GetMailTips { get =>
            new GetMailTipsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public GetMemberGroupsRequestBuilder GetMemberGroups { get =>
            new GetMemberGroupsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public GetMemberObjectsRequestBuilder GetMemberObjects { get =>
            new GetMemberObjectsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public InferenceClassificationRequestBuilder InferenceClassification { get =>
            new InferenceClassificationRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public InsightsRequestBuilder Insights { get =>
            new InsightsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public JoinedTeamsRequestBuilder JoinedTeams { get =>
            new JoinedTeamsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public LicenseDetailsRequestBuilder LicenseDetails { get =>
            new LicenseDetailsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MailFoldersRequestBuilder MailFolders { get =>
            new MailFoldersRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ManagedAppRegistrationsRequestBuilder ManagedAppRegistrations { get =>
            new ManagedAppRegistrationsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ManagedDevicesRequestBuilder ManagedDevices { get =>
            new ManagedDevicesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ManagerRequestBuilder Manager { get =>
            new ManagerRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MemberOfRequestBuilder MemberOf { get =>
            new MemberOfRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MessagesRequestBuilder Messages { get =>
            new MessagesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants { get =>
            new Oauth2PermissionGrantsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public OnenoteRequestBuilder Onenote { get =>
            new OnenoteRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public OnlineMeetingsRequestBuilder OnlineMeetings { get =>
            new OnlineMeetingsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public OutlookRequestBuilder Outlook { get =>
            new OutlookRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public OwnedDevicesRequestBuilder OwnedDevices { get =>
            new OwnedDevicesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public OwnedObjectsRequestBuilder OwnedObjects { get =>
            new OwnedObjectsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public PeopleRequestBuilder People { get =>
            new PeopleRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PhotoRequestBuilder Photo { get =>
            new PhotoRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PhotosRequestBuilder Photos { get =>
            new PhotosRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PlannerRequestBuilder Planner { get =>
            new PlannerRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PresenceRequestBuilder Presence { get =>
            new PresenceRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RegisteredDevicesRequestBuilder RegisteredDevices { get =>
            new RegisteredDevicesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RemoveAllDevicesFromManagementRequestBuilder RemoveAllDevicesFromManagement { get =>
            new RemoveAllDevicesFromManagementRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ReprocessLicenseAssignmentRequestBuilder ReprocessLicenseAssignment { get =>
            new ReprocessLicenseAssignmentRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RevokeSignInSessionsRequestBuilder RevokeSignInSessions { get =>
            new RevokeSignInSessionsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ScopedRoleMemberOfRequestBuilder ScopedRoleMemberOf { get =>
            new ScopedRoleMemberOfRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SendMailRequestBuilder SendMail { get =>
            new SendMailRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TeamworkRequestBuilder Teamwork { get =>
            new TeamworkRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TodoRequestBuilder Todo { get =>
            new TodoRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TransitiveMemberOfRequestBuilder TransitiveMemberOf { get =>
            new TransitiveMemberOfRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TranslateExchangeIdsRequestBuilder TranslateExchangeIds { get =>
            new TranslateExchangeIdsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WipeManagedAppRegistrationsByDeviceTagRequestBuilder WipeManagedAppRegistrationsByDeviceTag { get =>
            new WipeManagedAppRegistrationsByDeviceTagRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Instantiates a new UserRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public UserRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Represents an Azure Active Directory user object.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.DELETE,
            };
            requestInfo.SetURI(CurrentPath, PathSegment, IsRawUrl);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Represents an Azure Active Directory user object.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
            };
            requestInfo.SetURI(CurrentPath, PathSegment, IsRawUrl);
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Represents an Azure Active Directory user object.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.User body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.PATCH,
            };
            requestInfo.SetURI(CurrentPath, PathSegment, IsRawUrl);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Represents an Azure Active Directory user object.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Represents an Azure Active Directory user object.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApiSdk.Models.Microsoft.Graph.User> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ApiSdk.Models.Microsoft.Graph.User>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.getManagedAppDiagnosticStatuses()
        /// </summary>
        public GetManagedAppDiagnosticStatusesRequestBuilder getManagedAppDiagnosticStatuses() {
            return new GetManagedAppDiagnosticStatusesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.getManagedAppPolicies()
        /// </summary>
        public GetManagedAppPoliciesRequestBuilder getManagedAppPolicies() {
            return new GetManagedAppPoliciesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Represents an Azure Active Directory user object.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ApiSdk.Models.Microsoft.Graph.User body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.reminderView(StartDateTime='{StartDateTime}',EndDateTime='{EndDateTime}')
        /// <param name="EndDateTime">Usage: EndDateTime={EndDateTime}</param>
        /// <param name="StartDateTime">Usage: StartDateTime={StartDateTime}</param>
        /// </summary>
        public ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder reminderViewWithStartDateTimeWithEndDateTime(string StartDateTime, string EndDateTime) {
            if(string.IsNullOrEmpty(EndDateTime)) throw new ArgumentNullException(nameof(EndDateTime));
            if(string.IsNullOrEmpty(StartDateTime)) throw new ArgumentNullException(nameof(StartDateTime));
            return new ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, StartDateTime, EndDateTime, false);
        }
        /// <summary>Represents an Azure Active Directory user object.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
