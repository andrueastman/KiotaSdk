using GraphSdk.Models.Microsoft.Graph;
using GraphSdk.Workbooks.Item.Analytics;
using GraphSdk.Workbooks.Item.Checkin;
using GraphSdk.Workbooks.Item.Checkout;
using GraphSdk.Workbooks.Item.Children;
using GraphSdk.Workbooks.Item.Content;
using GraphSdk.Workbooks.Item.Copy;
using GraphSdk.Workbooks.Item.CreateLink;
using GraphSdk.Workbooks.Item.CreateUploadSession;
using GraphSdk.Workbooks.Item.Delta;
using GraphSdk.Workbooks.Item.DeltaWithToken;
using GraphSdk.Workbooks.Item.Follow;
using GraphSdk.Workbooks.Item.GetActivitiesByInterval;
using GraphSdk.Workbooks.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval;
using GraphSdk.Workbooks.Item.Invite;
using GraphSdk.Workbooks.Item.ListItem;
using GraphSdk.Workbooks.Item.Permissions;
using GraphSdk.Workbooks.Item.Preview;
using GraphSdk.Workbooks.Item.Restore;
using GraphSdk.Workbooks.Item.SearchWithQ;
using GraphSdk.Workbooks.Item.Subscriptions;
using GraphSdk.Workbooks.Item.Thumbnails;
using GraphSdk.Workbooks.Item.Unfollow;
using GraphSdk.Workbooks.Item.ValidatePermission;
using GraphSdk.Workbooks.Item.Versions;
using GraphSdk.Workbooks.Item.Workbook;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphSdk.Workbooks.Item {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}</summary>
    public class DriveItemRequestBuilder {
        public AnalyticsRequestBuilder Analytics { get =>
            new AnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CheckinRequestBuilder Checkin { get =>
            new CheckinRequestBuilder(PathParameters, RequestAdapter);
        }
        public CheckoutRequestBuilder Checkout { get =>
            new CheckoutRequestBuilder(PathParameters, RequestAdapter);
        }
        public ChildrenRequestBuilder Children { get =>
            new ChildrenRequestBuilder(PathParameters, RequestAdapter);
        }
        public ContentRequestBuilder Content { get =>
            new ContentRequestBuilder(PathParameters, RequestAdapter);
        }
        public CopyRequestBuilder Copy { get =>
            new CopyRequestBuilder(PathParameters, RequestAdapter);
        }
        public CreateLinkRequestBuilder CreateLink { get =>
            new CreateLinkRequestBuilder(PathParameters, RequestAdapter);
        }
        public CreateUploadSessionRequestBuilder CreateUploadSession { get =>
            new CreateUploadSessionRequestBuilder(PathParameters, RequestAdapter);
        }
        public FollowRequestBuilder Follow { get =>
            new FollowRequestBuilder(PathParameters, RequestAdapter);
        }
        public InviteRequestBuilder Invite { get =>
            new InviteRequestBuilder(PathParameters, RequestAdapter);
        }
        public ListItemRequestBuilder ListItem { get =>
            new ListItemRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public PermissionsRequestBuilder Permissions { get =>
            new PermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public PreviewRequestBuilder Preview { get =>
            new PreviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        public SubscriptionsRequestBuilder Subscriptions { get =>
            new SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ThumbnailsRequestBuilder Thumbnails { get =>
            new ThumbnailsRequestBuilder(PathParameters, RequestAdapter);
        }
        public UnfollowRequestBuilder Unfollow { get =>
            new UnfollowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public ValidatePermissionRequestBuilder ValidatePermission { get =>
            new ValidatePermissionRequestBuilder(PathParameters, RequestAdapter);
        }
        public VersionsRequestBuilder Versions { get =>
            new VersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public WorkbookRequestBuilder Workbook { get =>
            new WorkbookRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DriveItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DriveItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "https://graph.microsoft.com/v1.0/workbooks/{driveItem_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DriveItemRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DriveItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "https://graph.microsoft.com/v1.0/workbooks/{driveItem_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete entity from workbooks
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
        /// Get entity from workbooks by key
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
        /// Update entity in workbooks
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(GraphSdk.Models.Microsoft.Graph.DriveItem body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
            return new DeltaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\microsoft.graph.delta(token='{token}')
        /// <param name="token">Usage: token={token}</param>
        /// </summary>
        public DeltaWithTokenRequestBuilder DeltaWithToken(string token) {
            if(string.IsNullOrEmpty(token)) throw new ArgumentNullException(nameof(token));
            return new DeltaWithTokenRequestBuilder(PathParameters, RequestAdapter, token);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\microsoft.graph.getActivitiesByInterval()
        /// </summary>
        public GetActivitiesByIntervalRequestBuilder GetActivitiesByInterval() {
            return new GetActivitiesByIntervalRequestBuilder(PathParameters, RequestAdapter);
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
            return new GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(PathParameters, RequestAdapter, startDateTime, endDateTime, interval);
        }
        /// <summary>
        /// Get entity from workbooks by key
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<GraphSdk.Models.Microsoft.Graph.DriveItem> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<GraphSdk.Models.Microsoft.Graph.DriveItem>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Update entity in workbooks
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(GraphSdk.Models.Microsoft.Graph.DriveItem body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
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
            return new SearchWithQRequestBuilder(PathParameters, RequestAdapter, q);
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
