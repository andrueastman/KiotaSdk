using GraphSdk.Models.Microsoft.Graph;
using GraphSdk.Users.Item.Activities;
using GraphSdk.Users.Item.AgreementAcceptances;
using GraphSdk.Users.Item.AppRoleAssignments;
using GraphSdk.Users.Item.AssignLicense;
using GraphSdk.Users.Item.Authentication;
using GraphSdk.Users.Item.Calendar;
using GraphSdk.Users.Item.CalendarGroups;
using GraphSdk.Users.Item.Calendars;
using GraphSdk.Users.Item.CalendarView;
using GraphSdk.Users.Item.ChangePassword;
using GraphSdk.Users.Item.Chats;
using GraphSdk.Users.Item.CheckMemberGroups;
using GraphSdk.Users.Item.CheckMemberObjects;
using GraphSdk.Users.Item.ContactFolders;
using GraphSdk.Users.Item.Contacts;
using GraphSdk.Users.Item.CreatedObjects;
using GraphSdk.Users.Item.DeviceManagementTroubleshootingEvents;
using GraphSdk.Users.Item.DirectReports;
using GraphSdk.Users.Item.Drive;
using GraphSdk.Users.Item.Drives;
using GraphSdk.Users.Item.Events;
using GraphSdk.Users.Item.ExportPersonalData;
using GraphSdk.Users.Item.Extensions;
using GraphSdk.Users.Item.FindMeetingTimes;
using GraphSdk.Users.Item.FollowedSites;
using GraphSdk.Users.Item.GetMailTips;
using GraphSdk.Users.Item.GetManagedAppDiagnosticStatuses;
using GraphSdk.Users.Item.GetManagedAppPolicies;
using GraphSdk.Users.Item.GetMemberGroups;
using GraphSdk.Users.Item.GetMemberObjects;
using GraphSdk.Users.Item.InferenceClassification;
using GraphSdk.Users.Item.Insights;
using GraphSdk.Users.Item.JoinedTeams;
using GraphSdk.Users.Item.LicenseDetails;
using GraphSdk.Users.Item.MailFolders;
using GraphSdk.Users.Item.ManagedAppRegistrations;
using GraphSdk.Users.Item.ManagedDevices;
using GraphSdk.Users.Item.Manager;
using GraphSdk.Users.Item.MemberOf;
using GraphSdk.Users.Item.Messages;
using GraphSdk.Users.Item.Oauth2PermissionGrants;
using GraphSdk.Users.Item.Onenote;
using GraphSdk.Users.Item.OnlineMeetings;
using GraphSdk.Users.Item.Outlook;
using GraphSdk.Users.Item.OwnedDevices;
using GraphSdk.Users.Item.OwnedObjects;
using GraphSdk.Users.Item.People;
using GraphSdk.Users.Item.Photo;
using GraphSdk.Users.Item.Photos;
using GraphSdk.Users.Item.Planner;
using GraphSdk.Users.Item.Presence;
using GraphSdk.Users.Item.RegisteredDevices;
using GraphSdk.Users.Item.ReminderViewWithStartDateTimeWithEndDateTime;
using GraphSdk.Users.Item.RemoveAllDevicesFromManagement;
using GraphSdk.Users.Item.ReprocessLicenseAssignment;
using GraphSdk.Users.Item.Restore;
using GraphSdk.Users.Item.RevokeSignInSessions;
using GraphSdk.Users.Item.ScopedRoleMemberOf;
using GraphSdk.Users.Item.SendMail;
using GraphSdk.Users.Item.Settings;
using GraphSdk.Users.Item.Teamwork;
using GraphSdk.Users.Item.Todo;
using GraphSdk.Users.Item.TransitiveMemberOf;
using GraphSdk.Users.Item.TranslateExchangeIds;
using GraphSdk.Users.Item.WipeManagedAppRegistrationsByDeviceTag;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace GraphSdk.Users.Item {
    /// <summary>Builds and executes requests for operations under \users\{user-id}</summary>
    public class UserRequestBuilder {
        public ActivitiesRequestBuilder Activities { get =>
            new ActivitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        public AgreementAcceptancesRequestBuilder AgreementAcceptances { get =>
            new AgreementAcceptancesRequestBuilder(PathParameters, RequestAdapter);
        }
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AssignLicenseRequestBuilder AssignLicense { get =>
            new AssignLicenseRequestBuilder(PathParameters, RequestAdapter);
        }
        public AuthenticationRequestBuilder Authentication { get =>
            new AuthenticationRequestBuilder(PathParameters, RequestAdapter);
        }
        public CalendarRequestBuilder Calendar { get =>
            new CalendarRequestBuilder(PathParameters, RequestAdapter);
        }
        public CalendarGroupsRequestBuilder CalendarGroups { get =>
            new CalendarGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CalendarsRequestBuilder Calendars { get =>
            new CalendarsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CalendarViewRequestBuilder CalendarView { get =>
            new CalendarViewRequestBuilder(PathParameters, RequestAdapter);
        }
        public ChangePasswordRequestBuilder ChangePassword { get =>
            new ChangePasswordRequestBuilder(PathParameters, RequestAdapter);
        }
        public ChatsRequestBuilder Chats { get =>
            new ChatsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CheckMemberGroupsRequestBuilder CheckMemberGroups { get =>
            new CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CheckMemberObjectsRequestBuilder CheckMemberObjects { get =>
            new CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ContactFoldersRequestBuilder ContactFolders { get =>
            new ContactFoldersRequestBuilder(PathParameters, RequestAdapter);
        }
        public ContactsRequestBuilder Contacts { get =>
            new ContactsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CreatedObjectsRequestBuilder CreatedObjects { get =>
            new CreatedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceManagementTroubleshootingEventsRequestBuilder DeviceManagementTroubleshootingEvents { get =>
            new DeviceManagementTroubleshootingEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DirectReportsRequestBuilder DirectReports { get =>
            new DirectReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DriveRequestBuilder Drive { get =>
            new DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        public EventsRequestBuilder Events { get =>
            new EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExportPersonalDataRequestBuilder ExportPersonalData { get =>
            new ExportPersonalDataRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExtensionsRequestBuilder Extensions { get =>
            new ExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public FindMeetingTimesRequestBuilder FindMeetingTimes { get =>
            new FindMeetingTimesRequestBuilder(PathParameters, RequestAdapter);
        }
        public FollowedSitesRequestBuilder FollowedSites { get =>
            new FollowedSitesRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetMailTipsRequestBuilder GetMailTips { get =>
            new GetMailTipsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetMemberGroupsRequestBuilder GetMemberGroups { get =>
            new GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetMemberObjectsRequestBuilder GetMemberObjects { get =>
            new GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        public InferenceClassificationRequestBuilder InferenceClassification { get =>
            new InferenceClassificationRequestBuilder(PathParameters, RequestAdapter);
        }
        public InsightsRequestBuilder Insights { get =>
            new InsightsRequestBuilder(PathParameters, RequestAdapter);
        }
        public JoinedTeamsRequestBuilder JoinedTeams { get =>
            new JoinedTeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        public LicenseDetailsRequestBuilder LicenseDetails { get =>
            new LicenseDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        public MailFoldersRequestBuilder MailFolders { get =>
            new MailFoldersRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedAppRegistrationsRequestBuilder ManagedAppRegistrations { get =>
            new ManagedAppRegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedDevicesRequestBuilder ManagedDevices { get =>
            new ManagedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagerRequestBuilder Manager { get =>
            new ManagerRequestBuilder(PathParameters, RequestAdapter);
        }
        public MemberOfRequestBuilder MemberOf { get =>
            new MemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        public MessagesRequestBuilder Messages { get =>
            new MessagesRequestBuilder(PathParameters, RequestAdapter);
        }
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants { get =>
            new Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        public OnenoteRequestBuilder Onenote { get =>
            new OnenoteRequestBuilder(PathParameters, RequestAdapter);
        }
        public OnlineMeetingsRequestBuilder OnlineMeetings { get =>
            new OnlineMeetingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public OutlookRequestBuilder Outlook { get =>
            new OutlookRequestBuilder(PathParameters, RequestAdapter);
        }
        public OwnedDevicesRequestBuilder OwnedDevices { get =>
            new OwnedDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        public OwnedObjectsRequestBuilder OwnedObjects { get =>
            new OwnedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public PeopleRequestBuilder People { get =>
            new PeopleRequestBuilder(PathParameters, RequestAdapter);
        }
        public PhotoRequestBuilder Photo { get =>
            new PhotoRequestBuilder(PathParameters, RequestAdapter);
        }
        public PhotosRequestBuilder Photos { get =>
            new PhotosRequestBuilder(PathParameters, RequestAdapter);
        }
        public PlannerRequestBuilder Planner { get =>
            new PlannerRequestBuilder(PathParameters, RequestAdapter);
        }
        public PresenceRequestBuilder Presence { get =>
            new PresenceRequestBuilder(PathParameters, RequestAdapter);
        }
        public RegisteredDevicesRequestBuilder RegisteredDevices { get =>
            new RegisteredDevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        public RemoveAllDevicesFromManagementRequestBuilder RemoveAllDevicesFromManagement { get =>
            new RemoveAllDevicesFromManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        public ReprocessLicenseAssignmentRequestBuilder ReprocessLicenseAssignment { get =>
            new ReprocessLicenseAssignmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        public RevokeSignInSessionsRequestBuilder RevokeSignInSessions { get =>
            new RevokeSignInSessionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ScopedRoleMemberOfRequestBuilder ScopedRoleMemberOf { get =>
            new ScopedRoleMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        public SendMailRequestBuilder SendMail { get =>
            new SendMailRequestBuilder(PathParameters, RequestAdapter);
        }
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public TeamworkRequestBuilder Teamwork { get =>
            new TeamworkRequestBuilder(PathParameters, RequestAdapter);
        }
        public TodoRequestBuilder Todo { get =>
            new TodoRequestBuilder(PathParameters, RequestAdapter);
        }
        public TransitiveMemberOfRequestBuilder TransitiveMemberOf { get =>
            new TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        public TranslateExchangeIdsRequestBuilder TranslateExchangeIds { get =>
            new TranslateExchangeIdsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public WipeManagedAppRegistrationsByDeviceTagRequestBuilder WipeManagedAppRegistrationsByDeviceTag { get =>
            new WipeManagedAppRegistrationsByDeviceTagRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new UserRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public UserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new UserRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public UserRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete entity from users
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get entity from users by key
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
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
        /// Update entity in users
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(GraphSdk.Models.Microsoft.Graph.User body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Delete entity from users
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Get entity from users by key
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<GraphSdk.Models.Microsoft.Graph.User> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<GraphSdk.Models.Microsoft.Graph.User>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.getManagedAppDiagnosticStatuses()
        /// </summary>
        public GetManagedAppDiagnosticStatusesRequestBuilder GetManagedAppDiagnosticStatuses() {
            return new GetManagedAppDiagnosticStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.getManagedAppPolicies()
        /// </summary>
        public GetManagedAppPoliciesRequestBuilder GetManagedAppPolicies() {
            return new GetManagedAppPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Update entity in users
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(GraphSdk.Models.Microsoft.Graph.User body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\microsoft.graph.reminderView(StartDateTime='{StartDateTime}',EndDateTime='{EndDateTime}')
        /// <param name="EndDateTime">Usage: EndDateTime={EndDateTime}</param>
        /// <param name="StartDateTime">Usage: StartDateTime={StartDateTime}</param>
        /// </summary>
        public ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder ReminderViewWithStartDateTimeWithEndDateTime(string startDateTime, string endDateTime) {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, startDateTime, endDateTime);
        }
        /// <summary>Get entity from users by key</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
