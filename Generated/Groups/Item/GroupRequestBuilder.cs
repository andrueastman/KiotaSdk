using ApiSdk.Groups.Item.AcceptedSenders;
using ApiSdk.Groups.Item.AddFavorite;
using ApiSdk.Groups.Item.AppRoleAssignments;
using ApiSdk.Groups.Item.AssignLicense;
using ApiSdk.Groups.Item.Calendar;
using ApiSdk.Groups.Item.CalendarView;
using ApiSdk.Groups.Item.CheckGrantedPermissionsForApp;
using ApiSdk.Groups.Item.CheckMemberGroups;
using ApiSdk.Groups.Item.CheckMemberObjects;
using ApiSdk.Groups.Item.Conversations;
using ApiSdk.Groups.Item.CreatedOnBehalfOf;
using ApiSdk.Groups.Item.Drive;
using ApiSdk.Groups.Item.Drives;
using ApiSdk.Groups.Item.Events;
using ApiSdk.Groups.Item.Extensions;
using ApiSdk.Groups.Item.GetMemberGroups;
using ApiSdk.Groups.Item.GetMemberObjects;
using ApiSdk.Groups.Item.GroupLifecyclePolicies;
using ApiSdk.Groups.Item.MemberOf;
using ApiSdk.Groups.Item.Members;
using ApiSdk.Groups.Item.MembersWithLicenseErrors;
using ApiSdk.Groups.Item.Onenote;
using ApiSdk.Groups.Item.Owners;
using ApiSdk.Groups.Item.PermissionGrants;
using ApiSdk.Groups.Item.Photo;
using ApiSdk.Groups.Item.Photos;
using ApiSdk.Groups.Item.Planner;
using ApiSdk.Groups.Item.RejectedSenders;
using ApiSdk.Groups.Item.RemoveFavorite;
using ApiSdk.Groups.Item.Renew;
using ApiSdk.Groups.Item.ResetUnseenCount;
using ApiSdk.Groups.Item.Restore;
using ApiSdk.Groups.Item.Settings;
using ApiSdk.Groups.Item.Sites;
using ApiSdk.Groups.Item.SubscribeByMail;
using ApiSdk.Groups.Item.Team;
using ApiSdk.Groups.Item.Threads;
using ApiSdk.Groups.Item.TransitiveMemberOf;
using ApiSdk.Groups.Item.TransitiveMembers;
using ApiSdk.Groups.Item.UnsubscribeByMail;
using ApiSdk.Groups.Item.ValidateProperties;
using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Groups.Item {
    /// <summary>Builds and executes requests for operations under \groups\{group-id}</summary>
    public class GroupRequestBuilder {
        public AcceptedSendersRequestBuilder AcceptedSenders { get =>
            new AcceptedSendersRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AddFavoriteRequestBuilder AddFavorite { get =>
            new AddFavoriteRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AssignLicenseRequestBuilder AssignLicense { get =>
            new AssignLicenseRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CalendarRequestBuilder Calendar { get =>
            new CalendarRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CalendarViewRequestBuilder CalendarView { get =>
            new CalendarViewRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CheckGrantedPermissionsForAppRequestBuilder CheckGrantedPermissionsForApp { get =>
            new CheckGrantedPermissionsForAppRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CheckMemberGroupsRequestBuilder CheckMemberGroups { get =>
            new CheckMemberGroupsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CheckMemberObjectsRequestBuilder CheckMemberObjects { get =>
            new CheckMemberObjectsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ConversationsRequestBuilder Conversations { get =>
            new ConversationsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CreatedOnBehalfOfRequestBuilder CreatedOnBehalfOf { get =>
            new CreatedOnBehalfOfRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DriveRequestBuilder Drive { get =>
            new DriveRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public EventsRequestBuilder Events { get =>
            new EventsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ExtensionsRequestBuilder Extensions { get =>
            new ExtensionsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public GetMemberGroupsRequestBuilder GetMemberGroups { get =>
            new GetMemberGroupsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public GetMemberObjectsRequestBuilder GetMemberObjects { get =>
            new GetMemberObjectsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public GroupLifecyclePoliciesRequestBuilder GroupLifecyclePolicies { get =>
            new GroupLifecyclePoliciesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public MemberOfRequestBuilder MemberOf { get =>
            new MemberOfRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MembersRequestBuilder Members { get =>
            new MembersRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MembersWithLicenseErrorsRequestBuilder MembersWithLicenseErrors { get =>
            new MembersWithLicenseErrorsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public OnenoteRequestBuilder Onenote { get =>
            new OnenoteRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public OwnersRequestBuilder Owners { get =>
            new OwnersRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public PermissionGrantsRequestBuilder PermissionGrants { get =>
            new PermissionGrantsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
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
        public RejectedSendersRequestBuilder RejectedSenders { get =>
            new RejectedSendersRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RemoveFavoriteRequestBuilder RemoveFavorite { get =>
            new RemoveFavoriteRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RenewRequestBuilder Renew { get =>
            new RenewRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public ResetUnseenCountRequestBuilder ResetUnseenCount { get =>
            new ResetUnseenCountRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SitesRequestBuilder Sites { get =>
            new SitesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SubscribeByMailRequestBuilder SubscribeByMail { get =>
            new SubscribeByMailRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TeamRequestBuilder Team { get =>
            new TeamRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ThreadsRequestBuilder Threads { get =>
            new ThreadsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TransitiveMemberOfRequestBuilder TransitiveMemberOf { get =>
            new TransitiveMemberOfRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TransitiveMembersRequestBuilder TransitiveMembers { get =>
            new TransitiveMembersRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public UnsubscribeByMailRequestBuilder UnsubscribeByMail { get =>
            new UnsubscribeByMailRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ValidatePropertiesRequestBuilder ValidateProperties { get =>
            new ValidatePropertiesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Instantiates a new GroupRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public GroupRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
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
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
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
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.Group body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApiSdk.Models.Microsoft.Graph.Group> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ApiSdk.Models.Microsoft.Graph.Group>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ApiSdk.Models.Microsoft.Graph.Group body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
