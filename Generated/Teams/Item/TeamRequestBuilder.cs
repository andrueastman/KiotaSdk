using GraphServiceClient.Teams.Channels;
using GraphServiceClient.Teams.Group;
using GraphServiceClient.Teams.InstalledApps;
using GraphServiceClient.Teams.Members;
using GraphServiceClient.Teams.Microsoft.Graph.Archive;
using GraphServiceClient.Teams.Microsoft.Graph.Clone;
using GraphServiceClient.Teams.Microsoft.Graph.CompleteMigration;
using GraphServiceClient.Teams.Microsoft.Graph.SendActivityNotification;
using GraphServiceClient.Teams.Microsoft.Graph.Unarchive;
using GraphServiceClient.Teams.Operations;
using GraphServiceClient.Teams.PrimaryChannel;
using GraphServiceClient.Teams.Schedule;
using GraphServiceClient.Teams.Template;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.Teams.Item {
    /// <summary>Builds and executes requests for operations under \teams\{team-id}</summary>
    public class TeamRequestBuilder {
        public ChannelsRequestBuilder Channels { get =>
            new ChannelsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public GroupRequestBuilder Group { get =>
            new GroupRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        public InstalledAppsRequestBuilder InstalledApps { get =>
            new InstalledAppsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public MembersRequestBuilder Members { get =>
            new MembersRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.archiveRequestBuilder Microsoft.graph.archive { get =>
            new Microsoft.graph.archiveRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.cloneRequestBuilder Microsoft.graph.clone { get =>
            new Microsoft.graph.cloneRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.completeMigrationRequestBuilder Microsoft.graph.completeMigration { get =>
            new Microsoft.graph.completeMigrationRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.sendActivityNotificationRequestBuilder Microsoft.graph.sendActivityNotification { get =>
            new Microsoft.graph.sendActivityNotificationRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.unarchiveRequestBuilder Microsoft.graph.unarchive { get =>
            new Microsoft.graph.unarchiveRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OperationsRequestBuilder Operations { get =>
            new OperationsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public PrimaryChannelRequestBuilder PrimaryChannel { get =>
            new PrimaryChannelRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ScheduleRequestBuilder Schedule { get =>
            new ScheduleRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TemplateRequestBuilder Template { get =>
            new TemplateRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new TeamRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public TeamRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Delete entity from teams
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
        /// Get entity from teams by key
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
        /// Update entity in teams
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Team body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// Delete entity from teams
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Get entity from teams by key
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Team> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<Team>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Update entity in teams
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Team body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
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
