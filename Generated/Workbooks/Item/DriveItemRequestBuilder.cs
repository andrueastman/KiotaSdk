using GraphServiceClient.Workbooks.Analytics;
using GraphServiceClient.Workbooks.Children;
using GraphServiceClient.Workbooks.Content;
using GraphServiceClient.Workbooks.ListItem;
using GraphServiceClient.Workbooks.Microsoft.Graph.Checkin;
using GraphServiceClient.Workbooks.Microsoft.Graph.Checkout;
using GraphServiceClient.Workbooks.Microsoft.Graph.Copy;
using GraphServiceClient.Workbooks.Microsoft.Graph.CreateLink;
using GraphServiceClient.Workbooks.Microsoft.Graph.CreateUploadSession;
using GraphServiceClient.Workbooks.Microsoft.Graph.Follow;
using GraphServiceClient.Workbooks.Microsoft.Graph.Invite;
using GraphServiceClient.Workbooks.Microsoft.Graph.Preview;
using GraphServiceClient.Workbooks.Microsoft.Graph.Restore;
using GraphServiceClient.Workbooks.Microsoft.Graph.Unfollow;
using GraphServiceClient.Workbooks.Microsoft.Graph.ValidatePermission;
using GraphServiceClient.Workbooks.Permissions;
using GraphServiceClient.Workbooks.Subscriptions;
using GraphServiceClient.Workbooks.Thumbnails;
using GraphServiceClient.Workbooks.Versions;
using GraphServiceClient.Workbooks.Workbook;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.Workbooks.Item {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}</summary>
    public class DriveItemRequestBuilder {
        public AnalyticsRequestBuilder Analytics { get =>
            new AnalyticsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ChildrenRequestBuilder Children { get =>
            new ChildrenRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ContentRequestBuilder Content { get =>
            new ContentRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public ListItemRequestBuilder ListItem { get =>
            new ListItemRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.checkinRequestBuilder Microsoft.graph.checkin { get =>
            new Microsoft.graph.checkinRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.checkoutRequestBuilder Microsoft.graph.checkout { get =>
            new Microsoft.graph.checkoutRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.copyRequestBuilder Microsoft.graph.copy { get =>
            new Microsoft.graph.copyRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.createLinkRequestBuilder Microsoft.graph.createLink { get =>
            new Microsoft.graph.createLinkRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.createUploadSessionRequestBuilder Microsoft.graph.createUploadSession { get =>
            new Microsoft.graph.createUploadSessionRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.followRequestBuilder Microsoft.graph.follow { get =>
            new Microsoft.graph.followRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.inviteRequestBuilder Microsoft.graph.invite { get =>
            new Microsoft.graph.inviteRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.previewRequestBuilder Microsoft.graph.preview { get =>
            new Microsoft.graph.previewRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.restoreRequestBuilder Microsoft.graph.restore { get =>
            new Microsoft.graph.restoreRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.unfollowRequestBuilder Microsoft.graph.unfollow { get =>
            new Microsoft.graph.unfollowRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.validatePermissionRequestBuilder Microsoft.graph.validatePermission { get =>
            new Microsoft.graph.validatePermissionRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public PermissionsRequestBuilder Permissions { get =>
            new PermissionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public SubscriptionsRequestBuilder Subscriptions { get =>
            new SubscriptionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ThumbnailsRequestBuilder Thumbnails { get =>
            new ThumbnailsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public VersionsRequestBuilder Versions { get =>
            new VersionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public WorkbookRequestBuilder Workbook { get =>
            new WorkbookRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new DriveItemRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public DriveItemRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Delete entity from workbooks
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
        /// Get entity from workbooks by key
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
        /// Update entity in workbooks
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(DriveItem body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// Delete entity from workbooks
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Get entity from workbooks by key
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<DriveItem> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<DriveItem>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Update entity in workbooks
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(DriveItem body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>Get entity from workbooks by key</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
