using GraphServiceClient.Me.Activities;
using GraphServiceClient.Me.AgreementAcceptances;
using GraphServiceClient.Me.AppRoleAssignments;
using GraphServiceClient.Me.Authentication;
using GraphServiceClient.Me.Calendar;
using GraphServiceClient.Me.CalendarGroups;
using GraphServiceClient.Me.Calendars;
using GraphServiceClient.Me.CalendarView;
using GraphServiceClient.Me.Chats;
using GraphServiceClient.Me.ContactFolders;
using GraphServiceClient.Me.Contacts;
using GraphServiceClient.Me.CreatedObjects;
using GraphServiceClient.Me.DeviceManagementTroubleshootingEvents;
using GraphServiceClient.Me.DirectReports;
using GraphServiceClient.Me.Drive;
using GraphServiceClient.Me.Drives;
using GraphServiceClient.Me.Events;
using GraphServiceClient.Me.Extensions;
using GraphServiceClient.Me.FollowedSites;
using GraphServiceClient.Me.InferenceClassification;
using GraphServiceClient.Me.Insights;
using GraphServiceClient.Me.JoinedTeams;
using GraphServiceClient.Me.LicenseDetails;
using GraphServiceClient.Me.MailFolders;
using GraphServiceClient.Me.ManagedAppRegistrations;
using GraphServiceClient.Me.ManagedDevices;
using GraphServiceClient.Me.Manager;
using GraphServiceClient.Me.MemberOf;
using GraphServiceClient.Me.Messages;
using GraphServiceClient.Me.Microsoft.Graph.AssignLicense;
using GraphServiceClient.Me.Microsoft.Graph.ChangePassword;
using GraphServiceClient.Me.Microsoft.Graph.CheckMemberGroups;
using GraphServiceClient.Me.Microsoft.Graph.CheckMemberObjects;
using GraphServiceClient.Me.Microsoft.Graph.ExportPersonalData;
using GraphServiceClient.Me.Microsoft.Graph.FindMeetingTimes;
using GraphServiceClient.Me.Microsoft.Graph.GetMailTips;
using GraphServiceClient.Me.Microsoft.Graph.GetMemberGroups;
using GraphServiceClient.Me.Microsoft.Graph.GetMemberObjects;
using GraphServiceClient.Me.Microsoft.Graph.RemoveAllDevicesFromManagement;
using GraphServiceClient.Me.Microsoft.Graph.ReprocessLicenseAssignment;
using GraphServiceClient.Me.Microsoft.Graph.Restore;
using GraphServiceClient.Me.Microsoft.Graph.RevokeSignInSessions;
using GraphServiceClient.Me.Microsoft.Graph.SendMail;
using GraphServiceClient.Me.Microsoft.Graph.TranslateExchangeIds;
using GraphServiceClient.Me.Microsoft.Graph.WipeManagedAppRegistrationsByDeviceTag;
using GraphServiceClient.Me.Oauth2PermissionGrants;
using GraphServiceClient.Me.Onenote;
using GraphServiceClient.Me.OnlineMeetings;
using GraphServiceClient.Me.Outlook;
using GraphServiceClient.Me.OwnedDevices;
using GraphServiceClient.Me.OwnedObjects;
using GraphServiceClient.Me.People;
using GraphServiceClient.Me.Photo;
using GraphServiceClient.Me.Photos;
using GraphServiceClient.Me.Planner;
using GraphServiceClient.Me.Presence;
using GraphServiceClient.Me.RegisteredDevices;
using GraphServiceClient.Me.ScopedRoleMemberOf;
using GraphServiceClient.Me.Settings;
using GraphServiceClient.Me.Teamwork;
using GraphServiceClient.Me.Todo;
using GraphServiceClient.Me.TransitiveMemberOf;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.Me {
    /// <summary>Builds and executes requests for operations under \me</summary>
    public class MeRequestBuilder {
        public ActivitiesRequestBuilder Activities { get =>
            new ActivitiesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public AgreementAcceptancesRequestBuilder AgreementAcceptances { get =>
            new AgreementAcceptancesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public AuthenticationRequestBuilder Authentication { get =>
            new AuthenticationRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CalendarRequestBuilder Calendar { get =>
            new CalendarRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CalendarGroupsRequestBuilder CalendarGroups { get =>
            new CalendarGroupsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CalendarsRequestBuilder Calendars { get =>
            new CalendarsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CalendarViewRequestBuilder CalendarView { get =>
            new CalendarViewRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ChatsRequestBuilder Chats { get =>
            new ChatsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ContactFoldersRequestBuilder ContactFolders { get =>
            new ContactFoldersRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ContactsRequestBuilder Contacts { get =>
            new ContactsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CreatedObjectsRequestBuilder CreatedObjects { get =>
            new CreatedObjectsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DeviceManagementTroubleshootingEventsRequestBuilder DeviceManagementTroubleshootingEvents { get =>
            new DeviceManagementTroubleshootingEventsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DirectReportsRequestBuilder DirectReports { get =>
            new DirectReportsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DriveRequestBuilder Drive { get =>
            new DriveRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public EventsRequestBuilder Events { get =>
            new EventsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ExtensionsRequestBuilder Extensions { get =>
            new ExtensionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public FollowedSitesRequestBuilder FollowedSites { get =>
            new FollowedSitesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        public InferenceClassificationRequestBuilder InferenceClassification { get =>
            new InferenceClassificationRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public InsightsRequestBuilder Insights { get =>
            new InsightsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public JoinedTeamsRequestBuilder JoinedTeams { get =>
            new JoinedTeamsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public LicenseDetailsRequestBuilder LicenseDetails { get =>
            new LicenseDetailsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public MailFoldersRequestBuilder MailFolders { get =>
            new MailFoldersRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ManagedAppRegistrationsRequestBuilder ManagedAppRegistrations { get =>
            new ManagedAppRegistrationsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ManagedDevicesRequestBuilder ManagedDevices { get =>
            new ManagedDevicesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ManagerRequestBuilder Manager { get =>
            new ManagerRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public MemberOfRequestBuilder MemberOf { get =>
            new MemberOfRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public MessagesRequestBuilder Messages { get =>
            new MessagesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.assignLicenseRequestBuilder Microsoft.graph.assignLicense { get =>
            new Microsoft.graph.assignLicenseRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.changePasswordRequestBuilder Microsoft.graph.changePassword { get =>
            new Microsoft.graph.changePasswordRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.checkMemberGroupsRequestBuilder Microsoft.graph.checkMemberGroups { get =>
            new Microsoft.graph.checkMemberGroupsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.checkMemberObjectsRequestBuilder Microsoft.graph.checkMemberObjects { get =>
            new Microsoft.graph.checkMemberObjectsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.exportPersonalDataRequestBuilder Microsoft.graph.exportPersonalData { get =>
            new Microsoft.graph.exportPersonalDataRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.findMeetingTimesRequestBuilder Microsoft.graph.findMeetingTimes { get =>
            new Microsoft.graph.findMeetingTimesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.getMailTipsRequestBuilder Microsoft.graph.getMailTips { get =>
            new Microsoft.graph.getMailTipsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.getMemberGroupsRequestBuilder Microsoft.graph.getMemberGroups { get =>
            new Microsoft.graph.getMemberGroupsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.getMemberObjectsRequestBuilder Microsoft.graph.getMemberObjects { get =>
            new Microsoft.graph.getMemberObjectsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.removeAllDevicesFromManagementRequestBuilder Microsoft.graph.removeAllDevicesFromManagement { get =>
            new Microsoft.graph.removeAllDevicesFromManagementRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.reprocessLicenseAssignmentRequestBuilder Microsoft.graph.reprocessLicenseAssignment { get =>
            new Microsoft.graph.reprocessLicenseAssignmentRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.restoreRequestBuilder Microsoft.graph.restore { get =>
            new Microsoft.graph.restoreRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.revokeSignInSessionsRequestBuilder Microsoft.graph.revokeSignInSessions { get =>
            new Microsoft.graph.revokeSignInSessionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.sendMailRequestBuilder Microsoft.graph.sendMail { get =>
            new Microsoft.graph.sendMailRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.translateExchangeIdsRequestBuilder Microsoft.graph.translateExchangeIds { get =>
            new Microsoft.graph.translateExchangeIdsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.wipeManagedAppRegistrationsByDeviceTagRequestBuilder Microsoft.graph.wipeManagedAppRegistrationsByDeviceTag { get =>
            new Microsoft.graph.wipeManagedAppRegistrationsByDeviceTagRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants { get =>
            new Oauth2PermissionGrantsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OnenoteRequestBuilder Onenote { get =>
            new OnenoteRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OnlineMeetingsRequestBuilder OnlineMeetings { get =>
            new OnlineMeetingsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OutlookRequestBuilder Outlook { get =>
            new OutlookRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OwnedDevicesRequestBuilder OwnedDevices { get =>
            new OwnedDevicesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OwnedObjectsRequestBuilder OwnedObjects { get =>
            new OwnedObjectsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public PeopleRequestBuilder People { get =>
            new PeopleRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public PhotoRequestBuilder Photo { get =>
            new PhotoRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public PhotosRequestBuilder Photos { get =>
            new PhotosRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public PlannerRequestBuilder Planner { get =>
            new PlannerRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public PresenceRequestBuilder Presence { get =>
            new PresenceRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public RegisteredDevicesRequestBuilder RegisteredDevices { get =>
            new RegisteredDevicesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ScopedRoleMemberOfRequestBuilder ScopedRoleMemberOf { get =>
            new ScopedRoleMemberOfRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TeamworkRequestBuilder Teamwork { get =>
            new TeamworkRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TodoRequestBuilder Todo { get =>
            new TodoRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TransitiveMemberOfRequestBuilder TransitiveMemberOf { get =>
            new TransitiveMemberOfRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new MeRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public MeRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/me";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Get me
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
            requestInfo.AddMiddlewareOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update me
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Me body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.PATCH,
            };
            requestInfo.SetURI(CurrentPath, PathSegment, IsRawUrl);
            requestInfo.SetContentFromParsable(HttpCore, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddMiddlewareOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get me
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<User> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<User>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Update me
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Me body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
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
