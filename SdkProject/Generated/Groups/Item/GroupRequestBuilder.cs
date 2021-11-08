using GraphSdk.Groups.Item.AcceptedSenders;
using GraphSdk.Groups.Item.AddFavorite;
using GraphSdk.Groups.Item.AppRoleAssignments;
using GraphSdk.Groups.Item.AssignLicense;
using GraphSdk.Groups.Item.Calendar;
using GraphSdk.Groups.Item.CalendarView;
using GraphSdk.Groups.Item.CheckGrantedPermissionsForApp;
using GraphSdk.Groups.Item.CheckMemberGroups;
using GraphSdk.Groups.Item.CheckMemberObjects;
using GraphSdk.Groups.Item.Conversations;
using GraphSdk.Groups.Item.CreatedOnBehalfOf;
using GraphSdk.Groups.Item.Drive;
using GraphSdk.Groups.Item.Drives;
using GraphSdk.Groups.Item.Events;
using GraphSdk.Groups.Item.Extensions;
using GraphSdk.Groups.Item.GetMemberGroups;
using GraphSdk.Groups.Item.GetMemberObjects;
using GraphSdk.Groups.Item.GroupLifecyclePolicies;
using GraphSdk.Groups.Item.MemberOf;
using GraphSdk.Groups.Item.Members;
using GraphSdk.Groups.Item.MembersWithLicenseErrors;
using GraphSdk.Groups.Item.Onenote;
using GraphSdk.Groups.Item.Owners;
using GraphSdk.Groups.Item.PermissionGrants;
using GraphSdk.Groups.Item.Photo;
using GraphSdk.Groups.Item.Photos;
using GraphSdk.Groups.Item.Planner;
using GraphSdk.Groups.Item.RejectedSenders;
using GraphSdk.Groups.Item.RemoveFavorite;
using GraphSdk.Groups.Item.Renew;
using GraphSdk.Groups.Item.ResetUnseenCount;
using GraphSdk.Groups.Item.Restore;
using GraphSdk.Groups.Item.Settings;
using GraphSdk.Groups.Item.Sites;
using GraphSdk.Groups.Item.SubscribeByMail;
using GraphSdk.Groups.Item.Team;
using GraphSdk.Groups.Item.Threads;
using GraphSdk.Groups.Item.TransitiveMemberOf;
using GraphSdk.Groups.Item.TransitiveMembers;
using GraphSdk.Groups.Item.UnsubscribeByMail;
using GraphSdk.Groups.Item.ValidateProperties;
using GraphSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphSdk.Groups.Item {
    /// <summary>Builds and executes requests for operations under \groups\{group-id}</summary>
    public class GroupRequestBuilder {
        public AcceptedSendersRequestBuilder AcceptedSenders { get =>
            new AcceptedSendersRequestBuilder(PathParameters, RequestAdapter);
        }
        public AddFavoriteRequestBuilder AddFavorite { get =>
            new AddFavoriteRequestBuilder(PathParameters, RequestAdapter);
        }
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AssignLicenseRequestBuilder AssignLicense { get =>
            new AssignLicenseRequestBuilder(PathParameters, RequestAdapter);
        }
        public CalendarRequestBuilder Calendar { get =>
            new CalendarRequestBuilder(PathParameters, RequestAdapter);
        }
        public CalendarViewRequestBuilder CalendarView { get =>
            new CalendarViewRequestBuilder(PathParameters, RequestAdapter);
        }
        public CheckGrantedPermissionsForAppRequestBuilder CheckGrantedPermissionsForApp { get =>
            new CheckGrantedPermissionsForAppRequestBuilder(PathParameters, RequestAdapter);
        }
        public CheckMemberGroupsRequestBuilder CheckMemberGroups { get =>
            new CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CheckMemberObjectsRequestBuilder CheckMemberObjects { get =>
            new CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ConversationsRequestBuilder Conversations { get =>
            new ConversationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CreatedOnBehalfOfRequestBuilder CreatedOnBehalfOf { get =>
            new CreatedOnBehalfOfRequestBuilder(PathParameters, RequestAdapter);
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
        public ExtensionsRequestBuilder Extensions { get =>
            new ExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetMemberGroupsRequestBuilder GetMemberGroups { get =>
            new GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GetMemberObjectsRequestBuilder GetMemberObjects { get =>
            new GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GroupLifecyclePoliciesRequestBuilder GroupLifecyclePolicies { get =>
            new GroupLifecyclePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public MemberOfRequestBuilder MemberOf { get =>
            new MemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        public MembersRequestBuilder Members { get =>
            new MembersRequestBuilder(PathParameters, RequestAdapter);
        }
        public MembersWithLicenseErrorsRequestBuilder MembersWithLicenseErrors { get =>
            new MembersWithLicenseErrorsRequestBuilder(PathParameters, RequestAdapter);
        }
        public OnenoteRequestBuilder Onenote { get =>
            new OnenoteRequestBuilder(PathParameters, RequestAdapter);
        }
        public OwnersRequestBuilder Owners { get =>
            new OwnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public PermissionGrantsRequestBuilder PermissionGrants { get =>
            new PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
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
        public RejectedSendersRequestBuilder RejectedSenders { get =>
            new RejectedSendersRequestBuilder(PathParameters, RequestAdapter);
        }
        public RemoveFavoriteRequestBuilder RemoveFavorite { get =>
            new RemoveFavoriteRequestBuilder(PathParameters, RequestAdapter);
        }
        public RenewRequestBuilder Renew { get =>
            new RenewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public ResetUnseenCountRequestBuilder ResetUnseenCount { get =>
            new ResetUnseenCountRequestBuilder(PathParameters, RequestAdapter);
        }
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public SitesRequestBuilder Sites { get =>
            new SitesRequestBuilder(PathParameters, RequestAdapter);
        }
        public SubscribeByMailRequestBuilder SubscribeByMail { get =>
            new SubscribeByMailRequestBuilder(PathParameters, RequestAdapter);
        }
        public TeamRequestBuilder Team { get =>
            new TeamRequestBuilder(PathParameters, RequestAdapter);
        }
        public ThreadsRequestBuilder Threads { get =>
            new ThreadsRequestBuilder(PathParameters, RequestAdapter);
        }
        public TransitiveMemberOfRequestBuilder TransitiveMemberOf { get =>
            new TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        public TransitiveMembersRequestBuilder TransitiveMembers { get =>
            new TransitiveMembersRequestBuilder(PathParameters, RequestAdapter);
        }
        public UnsubscribeByMailRequestBuilder UnsubscribeByMail { get =>
            new UnsubscribeByMailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public ValidatePropertiesRequestBuilder ValidateProperties { get =>
            new ValidatePropertiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new GroupRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GroupRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/groups/{group_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new GroupRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GroupRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/groups/{group_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete entity from groups
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get entity from groups by key
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
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
        /// Update entity in groups
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(GraphSdk.Models.Microsoft.Graph.Group body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Delete entity from groups
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Get entity from groups by key
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<GraphSdk.Models.Microsoft.Graph.Group> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<GraphSdk.Models.Microsoft.Graph.Group>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Update entity in groups
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(GraphSdk.Models.Microsoft.Graph.Group body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>Get entity from groups by key</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
