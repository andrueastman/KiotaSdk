using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Teams.Item.Archive;
using ApiSdk.Teams.Item.Channels;
using ApiSdk.Teams.Item.Clone;
using ApiSdk.Teams.Item.CompleteMigration;
using ApiSdk.Teams.Item.Group;
using ApiSdk.Teams.Item.InstalledApps;
using ApiSdk.Teams.Item.Members;
using ApiSdk.Teams.Item.Operations;
using ApiSdk.Teams.Item.PrimaryChannel;
using ApiSdk.Teams.Item.Schedule;
using ApiSdk.Teams.Item.SendActivityNotification;
using ApiSdk.Teams.Item.Template;
using ApiSdk.Teams.Item.Unarchive;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Teams.Item {
    /// <summary>Builds and executes requests for operations under \teams\{team-id}</summary>
    public class TeamRequestBuilder {
        public ArchiveRequestBuilder Archive { get =>
            new ArchiveRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ChannelsRequestBuilder Channels { get =>
            new ChannelsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CloneRequestBuilder Clone { get =>
            new CloneRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CompleteMigrationRequestBuilder CompleteMigration { get =>
            new CompleteMigrationRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public GroupRequestBuilder Group { get =>
            new GroupRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public InstalledAppsRequestBuilder InstalledApps { get =>
            new InstalledAppsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public MembersRequestBuilder Members { get =>
            new MembersRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public OperationsRequestBuilder Operations { get =>
            new OperationsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public PrimaryChannelRequestBuilder PrimaryChannel { get =>
            new PrimaryChannelRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public ScheduleRequestBuilder Schedule { get =>
            new ScheduleRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SendActivityNotificationRequestBuilder SendActivityNotification { get =>
            new SendActivityNotificationRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TemplateRequestBuilder Template { get =>
            new TemplateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public UnarchiveRequestBuilder Unarchive { get =>
            new UnarchiveRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Instantiates a new TeamRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public TeamRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Delete entity from teams
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
        /// Get entity from teams by key
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
        /// Update entity in teams
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.Team body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Delete entity from teams
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Get entity from teams by key
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApiSdk.Models.Microsoft.Graph.Team> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ApiSdk.Models.Microsoft.Graph.Team>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Update entity in teams
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ApiSdk.Models.Microsoft.Graph.Team body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>Get entity from teams by key</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
