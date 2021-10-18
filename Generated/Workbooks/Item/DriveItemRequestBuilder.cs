using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Analytics;
using ApiSdk.Workbooks.Item.Checkin;
using ApiSdk.Workbooks.Item.Checkout;
using ApiSdk.Workbooks.Item.Children;
using ApiSdk.Workbooks.Item.Content;
using ApiSdk.Workbooks.Item.Copy;
using ApiSdk.Workbooks.Item.CreateLink;
using ApiSdk.Workbooks.Item.CreateUploadSession;
using ApiSdk.Workbooks.Item.Delta;
using ApiSdk.Workbooks.Item.DeltaWithToken;
using ApiSdk.Workbooks.Item.Follow;
using ApiSdk.Workbooks.Item.GetActivitiesByInterval;
using ApiSdk.Workbooks.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval;
using ApiSdk.Workbooks.Item.Invite;
using ApiSdk.Workbooks.Item.ListItem;
using ApiSdk.Workbooks.Item.Permissions;
using ApiSdk.Workbooks.Item.Preview;
using ApiSdk.Workbooks.Item.Restore;
using ApiSdk.Workbooks.Item.SearchWithQ;
using ApiSdk.Workbooks.Item.Subscriptions;
using ApiSdk.Workbooks.Item.Thumbnails;
using ApiSdk.Workbooks.Item.Unfollow;
using ApiSdk.Workbooks.Item.ValidatePermission;
using ApiSdk.Workbooks.Item.Versions;
using ApiSdk.Workbooks.Item.Workbook;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Workbooks.Item {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}</summary>
    public class DriveItemRequestBuilder {
        public AnalyticsRequestBuilder Analytics { get =>
            new AnalyticsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CheckinRequestBuilder Checkin { get =>
            new CheckinRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CheckoutRequestBuilder Checkout { get =>
            new CheckoutRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ChildrenRequestBuilder Children { get =>
            new ChildrenRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ContentRequestBuilder Content { get =>
            new ContentRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CopyRequestBuilder Copy { get =>
            new CopyRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CreateLinkRequestBuilder CreateLink { get =>
            new CreateLinkRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CreateUploadSessionRequestBuilder CreateUploadSession { get =>
            new CreateUploadSessionRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public FollowRequestBuilder Follow { get =>
            new FollowRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public InviteRequestBuilder Invite { get =>
            new InviteRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public ListItemRequestBuilder ListItem { get =>
            new ListItemRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public PermissionsRequestBuilder Permissions { get =>
            new PermissionsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PreviewRequestBuilder Preview { get =>
            new PreviewRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SubscriptionsRequestBuilder Subscriptions { get =>
            new SubscriptionsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ThumbnailsRequestBuilder Thumbnails { get =>
            new ThumbnailsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public UnfollowRequestBuilder Unfollow { get =>
            new UnfollowRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ValidatePermissionRequestBuilder ValidatePermission { get =>
            new ValidatePermissionRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public VersionsRequestBuilder Versions { get =>
            new VersionsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WorkbookRequestBuilder Workbook { get =>
            new WorkbookRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Instantiates a new DriveItemRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public DriveItemRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Delete entity from workbooks
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
        /// Get entity from workbooks by key
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
        /// Update entity in workbooks
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.DriveItem body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Delete entity from workbooks
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\microsoft.graph.delta()
        /// </summary>
        public DeltaRequestBuilder Delta() {
            return new DeltaRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\microsoft.graph.delta(token='{token}')
        /// <param name="token">Usage: token={token}</param>
        /// </summary>
        public DeltaWithTokenRequestBuilder DeltaWithToken(string token) {
            if(string.IsNullOrEmpty(token)) throw new ArgumentNullException(nameof(token));
            return new DeltaWithTokenRequestBuilder(CurrentPath + PathSegment , RequestAdapter, token, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\microsoft.graph.getActivitiesByInterval()
        /// </summary>
        public GetActivitiesByIntervalRequestBuilder GetActivitiesByInterval() {
            return new GetActivitiesByIntervalRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\microsoft.graph.getActivitiesByInterval(startDateTime='{startDateTime}',endDateTime='{endDateTime}',interval='{interval}')
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="interval">Usage: interval={interval}</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        /// </summary>
        public GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval(string startDateTime, string endDateTime, string interval) {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(interval)) throw new ArgumentNullException(nameof(interval));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(CurrentPath + PathSegment , RequestAdapter, startDateTime, endDateTime, interval, false);
        }
        /// <summary>
        /// Get entity from workbooks by key
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApiSdk.Models.Microsoft.Graph.DriveItem> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ApiSdk.Models.Microsoft.Graph.DriveItem>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Update entity in workbooks
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ApiSdk.Models.Microsoft.Graph.DriveItem body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\microsoft.graph.search(q='{q}')
        /// <param name="q">Usage: q={q}</param>
        /// </summary>
        public SearchWithQRequestBuilder SearchWithQ(string q) {
            if(string.IsNullOrEmpty(q)) throw new ArgumentNullException(nameof(q));
            return new SearchWithQRequestBuilder(CurrentPath + PathSegment , RequestAdapter, q, false);
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
