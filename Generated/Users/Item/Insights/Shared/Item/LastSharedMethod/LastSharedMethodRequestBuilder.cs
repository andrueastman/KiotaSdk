using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.CalendarSharingMessage;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.ManagedAppProtection;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.MobileAppContentFile;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.PrintDocument;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.PrintJob;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.Ref;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.ScheduleChangeRequest;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.TargetedManagedAppProtection;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WindowsInformationProtection;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WorkbookRange;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFill;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WorkbookRangeFormat;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WorkbookRangeSort;
using ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod.WorkbookRangeView;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.Insights.Shared.Item.LastSharedMethod {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\shared\{sharedInsight-id}\lastSharedMethod</summary>
    public class LastSharedMethodRequestBuilder {
        public CalendarSharingMessageRequestBuilder CalendarSharingMessage { get =>
            new CalendarSharingMessageRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public ManagedAppProtectionRequestBuilder ManagedAppProtection { get =>
            new ManagedAppProtectionRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MobileAppContentFileRequestBuilder MobileAppContentFile { get =>
            new MobileAppContentFileRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public PrintDocumentRequestBuilder PrintDocument { get =>
            new PrintDocumentRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public PrintJobRequestBuilder PrintJob { get =>
            new PrintJobRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public ScheduleChangeRequestRequestBuilder ScheduleChangeRequest { get =>
            new ScheduleChangeRequestRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TargetedManagedAppProtectionRequestBuilder TargetedManagedAppProtection { get =>
            new TargetedManagedAppProtectionRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WindowsInformationProtectionRequestBuilder WindowsInformationProtection { get =>
            new WindowsInformationProtectionRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WorkbookRangeRequestBuilder WorkbookRange { get =>
            new WorkbookRangeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WorkbookRangeFillRequestBuilder WorkbookRangeFill { get =>
            new WorkbookRangeFillRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WorkbookRangeFormatRequestBuilder WorkbookRangeFormat { get =>
            new WorkbookRangeFormatRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WorkbookRangeSortRequestBuilder WorkbookRangeSort { get =>
            new WorkbookRangeSortRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WorkbookRangeViewRequestBuilder WorkbookRangeView { get =>
            new WorkbookRangeViewRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Instantiates a new LastSharedMethodRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public LastSharedMethodRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "/lastSharedMethod";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Get lastSharedMethod from users
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
        /// Get lastSharedMethod from users
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Entity> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<Entity>(requestInfo, responseHandler);
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
