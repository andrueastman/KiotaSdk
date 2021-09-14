using GraphServiceClient.Groups.AcceptedSenders;
using GraphServiceClient.Groups.AppRoleAssignments;
using GraphServiceClient.Groups.Calendar;
using GraphServiceClient.Groups.CalendarView;
using GraphServiceClient.Groups.Conversations;
using GraphServiceClient.Groups.CreatedOnBehalfOf;
using GraphServiceClient.Groups.Drive;
using GraphServiceClient.Groups.Drives;
using GraphServiceClient.Groups.Events;
using GraphServiceClient.Groups.Extensions;
using GraphServiceClient.Groups.GroupLifecyclePolicies;
using GraphServiceClient.Groups.MemberOf;
using GraphServiceClient.Groups.Members;
using GraphServiceClient.Groups.MembersWithLicenseErrors;
using GraphServiceClient.Groups.Microsoft.Graph.AddFavorite;
using GraphServiceClient.Groups.Microsoft.Graph.AssignLicense;
using GraphServiceClient.Groups.Microsoft.Graph.CheckGrantedPermissionsForApp;
using GraphServiceClient.Groups.Microsoft.Graph.CheckMemberGroups;
using GraphServiceClient.Groups.Microsoft.Graph.CheckMemberObjects;
using GraphServiceClient.Groups.Microsoft.Graph.GetMemberGroups;
using GraphServiceClient.Groups.Microsoft.Graph.GetMemberObjects;
using GraphServiceClient.Groups.Microsoft.Graph.RemoveFavorite;
using GraphServiceClient.Groups.Microsoft.Graph.Renew;
using GraphServiceClient.Groups.Microsoft.Graph.ResetUnseenCount;
using GraphServiceClient.Groups.Microsoft.Graph.Restore;
using GraphServiceClient.Groups.Microsoft.Graph.SubscribeByMail;
using GraphServiceClient.Groups.Microsoft.Graph.UnsubscribeByMail;
using GraphServiceClient.Groups.Microsoft.Graph.ValidateProperties;
using GraphServiceClient.Groups.Onenote;
using GraphServiceClient.Groups.Owners;
using GraphServiceClient.Groups.PermissionGrants;
using GraphServiceClient.Groups.Photo;
using GraphServiceClient.Groups.Photos;
using GraphServiceClient.Groups.Planner;
using GraphServiceClient.Groups.RejectedSenders;
using GraphServiceClient.Groups.Settings;
using GraphServiceClient.Groups.Sites;
using GraphServiceClient.Groups.Team;
using GraphServiceClient.Groups.Threads;
using GraphServiceClient.Groups.TransitiveMemberOf;
using GraphServiceClient.Groups.TransitiveMembers;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.Groups.Item {
    /// <summary>Builds and executes requests for operations under \groups\{group-id}</summary>
    public class GroupRequestBuilder {
        public AcceptedSendersRequestBuilder AcceptedSenders { get =>
            new AcceptedSendersRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CalendarRequestBuilder Calendar { get =>
            new CalendarRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CalendarViewRequestBuilder CalendarView { get =>
            new CalendarViewRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ConversationsRequestBuilder Conversations { get =>
            new ConversationsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CreatedOnBehalfOfRequestBuilder CreatedOnBehalfOf { get =>
            new CreatedOnBehalfOfRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
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
        public GroupLifecyclePoliciesRequestBuilder GroupLifecyclePolicies { get =>
            new GroupLifecyclePoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public MemberOfRequestBuilder MemberOf { get =>
            new MemberOfRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public MembersRequestBuilder Members { get =>
            new MembersRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public MembersWithLicenseErrorsRequestBuilder MembersWithLicenseErrors { get =>
            new MembersWithLicenseErrorsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.addFavoriteRequestBuilder Microsoft.graph.addFavorite { get =>
            new Microsoft.graph.addFavoriteRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.assignLicenseRequestBuilder Microsoft.graph.assignLicense { get =>
            new Microsoft.graph.assignLicenseRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.checkGrantedPermissionsForAppRequestBuilder Microsoft.graph.checkGrantedPermissionsForApp { get =>
            new Microsoft.graph.checkGrantedPermissionsForAppRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.checkMemberGroupsRequestBuilder Microsoft.graph.checkMemberGroups { get =>
            new Microsoft.graph.checkMemberGroupsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.checkMemberObjectsRequestBuilder Microsoft.graph.checkMemberObjects { get =>
            new Microsoft.graph.checkMemberObjectsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.getMemberGroupsRequestBuilder Microsoft.graph.getMemberGroups { get =>
            new Microsoft.graph.getMemberGroupsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.getMemberObjectsRequestBuilder Microsoft.graph.getMemberObjects { get =>
            new Microsoft.graph.getMemberObjectsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.removeFavoriteRequestBuilder Microsoft.graph.removeFavorite { get =>
            new Microsoft.graph.removeFavoriteRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.renewRequestBuilder Microsoft.graph.renew { get =>
            new Microsoft.graph.renewRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.resetUnseenCountRequestBuilder Microsoft.graph.resetUnseenCount { get =>
            new Microsoft.graph.resetUnseenCountRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.restoreRequestBuilder Microsoft.graph.restore { get =>
            new Microsoft.graph.restoreRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.subscribeByMailRequestBuilder Microsoft.graph.subscribeByMail { get =>
            new Microsoft.graph.subscribeByMailRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.unsubscribeByMailRequestBuilder Microsoft.graph.unsubscribeByMail { get =>
            new Microsoft.graph.unsubscribeByMailRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.validatePropertiesRequestBuilder Microsoft.graph.validateProperties { get =>
            new Microsoft.graph.validatePropertiesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OnenoteRequestBuilder Onenote { get =>
            new OnenoteRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OwnersRequestBuilder Owners { get =>
            new OwnersRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public PermissionGrantsRequestBuilder PermissionGrants { get =>
            new PermissionGrantsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
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
        public RejectedSendersRequestBuilder RejectedSenders { get =>
            new RejectedSendersRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public SitesRequestBuilder Sites { get =>
            new SitesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TeamRequestBuilder Team { get =>
            new TeamRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ThreadsRequestBuilder Threads { get =>
            new ThreadsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TransitiveMemberOfRequestBuilder TransitiveMemberOf { get =>
            new TransitiveMemberOfRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TransitiveMembersRequestBuilder TransitiveMembers { get =>
            new TransitiveMembersRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new GroupRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public GroupRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.DELETE,
            };
            requestInfo.SetURI(CurrentPath, PathSegment, IsRawUrl);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddMiddlewareOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
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
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Group body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Group> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<Group>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Group body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
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
