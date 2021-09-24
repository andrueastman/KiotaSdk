using GraphServiceClient.Users.Insights.Shared.LastSharedMethod.$ref;
using GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.CalendarSharingMessage;
using GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.ManagedAppProtection;
using GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.MobileAppContentFile;
using GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.PrintDocument;
using GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.PrintJob;
using GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.ScheduleChangeRequest;
using GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.TargetedManagedAppProtection;
using GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.WindowsInformationProtection;
using GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.WorkbookRange;
using GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.WorkbookRangeFill;
using GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.WorkbookRangeFormat;
using GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.WorkbookRangeSort;
using GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.WorkbookRangeView;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.Users.Insights.Shared.LastSharedMethod {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\shared\{sharedInsight-id}\lastSharedMethod</summary>
    public class LastSharedMethodRequestBuilder {
        public $refRequestBuilder $ref { get =>
            new $refRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public Microsoft.graph.calendarSharingMessageRequestBuilder Microsoft.graph.calendarSharingMessage { get =>
            new Microsoft.graph.calendarSharingMessageRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.managedAppProtectionRequestBuilder Microsoft.graph.managedAppProtection { get =>
            new Microsoft.graph.managedAppProtectionRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.mobileAppContentFileRequestBuilder Microsoft.graph.mobileAppContentFile { get =>
            new Microsoft.graph.mobileAppContentFileRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.printDocumentRequestBuilder Microsoft.graph.printDocument { get =>
            new Microsoft.graph.printDocumentRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.printJobRequestBuilder Microsoft.graph.printJob { get =>
            new Microsoft.graph.printJobRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.scheduleChangeRequestRequestBuilder Microsoft.graph.scheduleChangeRequest { get =>
            new Microsoft.graph.scheduleChangeRequestRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.targetedManagedAppProtectionRequestBuilder Microsoft.graph.targetedManagedAppProtection { get =>
            new Microsoft.graph.targetedManagedAppProtectionRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.windowsInformationProtectionRequestBuilder Microsoft.graph.windowsInformationProtection { get =>
            new Microsoft.graph.windowsInformationProtectionRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.workbookRangeRequestBuilder Microsoft.graph.workbookRange { get =>
            new Microsoft.graph.workbookRangeRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.workbookRangeFillRequestBuilder Microsoft.graph.workbookRangeFill { get =>
            new Microsoft.graph.workbookRangeFillRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.workbookRangeFormatRequestBuilder Microsoft.graph.workbookRangeFormat { get =>
            new Microsoft.graph.workbookRangeFormatRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.workbookRangeSortRequestBuilder Microsoft.graph.workbookRangeSort { get =>
            new Microsoft.graph.workbookRangeSortRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.workbookRangeViewRequestBuilder Microsoft.graph.workbookRangeView { get =>
            new Microsoft.graph.workbookRangeViewRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>
        /// Instantiates a new LastSharedMethodRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public LastSharedMethodRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/lastSharedMethod";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Get lastSharedMethod from users
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
        /// Get lastSharedMethod from users
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Entity> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<Entity>(requestInfo, responseHandler);
        }
        /// <summary>Get lastSharedMethod from users</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}