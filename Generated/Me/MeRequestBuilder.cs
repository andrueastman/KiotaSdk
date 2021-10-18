using ApiSdk.Me.Activities;
using ApiSdk.Me.AgreementAcceptances;
using ApiSdk.Me.AppRoleAssignments;
using ApiSdk.Me.AssignLicense;
using ApiSdk.Me.Authentication;
using ApiSdk.Me.Calendar;
using ApiSdk.Me.CalendarGroups;
using ApiSdk.Me.Calendars;
using ApiSdk.Me.CalendarView;
using ApiSdk.Me.ChangePassword;
using ApiSdk.Me.Chats;
using ApiSdk.Me.CheckMemberGroups;
using ApiSdk.Me.CheckMemberObjects;
using ApiSdk.Me.ContactFolders;
using ApiSdk.Me.Contacts;
using ApiSdk.Me.CreatedObjects;
using ApiSdk.Me.DeviceManagementTroubleshootingEvents;
using ApiSdk.Me.DirectReports;
using ApiSdk.Me.Drive;
using ApiSdk.Me.Drives;
using ApiSdk.Me.Events;
using ApiSdk.Me.ExportPersonalData;
using ApiSdk.Me.Extensions;
using ApiSdk.Me.FindMeetingTimes;
using ApiSdk.Me.FollowedSites;
using ApiSdk.Me.GetMailTips;
using ApiSdk.Me.GetManagedAppDiagnosticStatuses;
using ApiSdk.Me.GetManagedAppPolicies;
using ApiSdk.Me.GetMemberGroups;
using ApiSdk.Me.GetMemberObjects;
using ApiSdk.Me.InferenceClassification;
using ApiSdk.Me.Insights;
using ApiSdk.Me.JoinedTeams;
using ApiSdk.Me.LicenseDetails;
using ApiSdk.Me.MailFolders;
using ApiSdk.Me.ManagedAppRegistrations;
using ApiSdk.Me.ManagedDevices;
using ApiSdk.Me.Manager;
using ApiSdk.Me.MemberOf;
using ApiSdk.Me.Messages;
using ApiSdk.Me.Oauth2PermissionGrants;
using ApiSdk.Me.Onenote;
using ApiSdk.Me.OnlineMeetings;
using ApiSdk.Me.Outlook;
using ApiSdk.Me.OwnedDevices;
using ApiSdk.Me.OwnedObjects;
using ApiSdk.Me.People;
using ApiSdk.Me.Photo;
using ApiSdk.Me.Photos;
using ApiSdk.Me.Planner;
using ApiSdk.Me.Presence;
using ApiSdk.Me.RegisteredDevices;
using ApiSdk.Me.ReminderViewWithStartDateTimeWithEndDateTime;
using ApiSdk.Me.RemoveAllDevicesFromManagement;
using ApiSdk.Me.ReprocessLicenseAssignment;
using ApiSdk.Me.Restore;
using ApiSdk.Me.RevokeSignInSessions;
using ApiSdk.Me.ScopedRoleMemberOf;
using ApiSdk.Me.SendMail;
using ApiSdk.Me.Settings;
using ApiSdk.Me.Teamwork;
using ApiSdk.Me.Todo;
using ApiSdk.Me.TransitiveMemberOf;
using ApiSdk.Me.TranslateExchangeIds;
using ApiSdk.Me.WipeManagedAppRegistrationsByDeviceTag;
using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Me {
    /// <summary>Builds and executes requests for operations under \me</summary>
    public class MeRequestBuilder {
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
        /// Instantiates a new MeRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public MeRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "/me";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Get me
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
        /// Update me
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
        /// Get me
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
        /// Builds and executes requests for operations under \me\microsoft.graph.getManagedAppDiagnosticStatuses()
        /// </summary>
        public GetManagedAppDiagnosticStatusesRequestBuilder getManagedAppDiagnosticStatuses() {
            return new GetManagedAppDiagnosticStatusesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \me\microsoft.graph.getManagedAppPolicies()
        /// </summary>
        public GetManagedAppPoliciesRequestBuilder getManagedAppPolicies() {
            return new GetManagedAppPoliciesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Update me
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
        /// Builds and executes requests for operations under \me\microsoft.graph.reminderView(StartDateTime='{StartDateTime}',EndDateTime='{EndDateTime}')
        /// <param name="EndDateTime">Usage: EndDateTime={EndDateTime}</param>
        /// <param name="StartDateTime">Usage: StartDateTime={StartDateTime}</param>
        /// </summary>
        public ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder reminderViewWithStartDateTimeWithEndDateTime(string StartDateTime, string EndDateTime) {
            if(string.IsNullOrEmpty(EndDateTime)) throw new ArgumentNullException(nameof(EndDateTime));
            if(string.IsNullOrEmpty(StartDateTime)) throw new ArgumentNullException(nameof(StartDateTime));
            return new ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, StartDateTime, EndDateTime, false);
        }
        /// <summary>Get me</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
