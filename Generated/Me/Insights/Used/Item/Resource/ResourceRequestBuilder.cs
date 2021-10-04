using ApiSdk.Me.Insights.Used.Item.Resource.CalendarSharingMessage;
using ApiSdk.Me.Insights.Used.Item.Resource.ManagedAppProtection;
using ApiSdk.Me.Insights.Used.Item.Resource.MobileAppContentFile;
using ApiSdk.Me.Insights.Used.Item.Resource.PrintDocument;
using ApiSdk.Me.Insights.Used.Item.Resource.PrintJob;
using ApiSdk.Me.Insights.Used.Item.Resource.Ref;
using ApiSdk.Me.Insights.Used.Item.Resource.ScheduleChangeRequest;
using ApiSdk.Me.Insights.Used.Item.Resource.TargetedManagedAppProtection;
using ApiSdk.Me.Insights.Used.Item.Resource.WindowsInformationProtection;
using ApiSdk.Me.Insights.Used.Item.Resource.WorkbookRange;
using ApiSdk.Me.Insights.Used.Item.Resource.WorkbookRangeFill;
using ApiSdk.Me.Insights.Used.Item.Resource.WorkbookRangeFormat;
using ApiSdk.Me.Insights.Used.Item.Resource.WorkbookRangeSort;
using ApiSdk.Me.Insights.Used.Item.Resource.WorkbookRangeView;
using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Me.Insights.Used.Item.Resource {
    /// <summary>Builds and executes requests for operations under \me\insights\used\{usedInsight-id}\resource</summary>
    public class ResourceRequestBuilder {
        public CalendarSharingMessageRequestBuilder CalendarSharingMessage { get =>
            new CalendarSharingMessageRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public ManagedAppProtectionRequestBuilder ManagedAppProtection { get =>
            new ManagedAppProtectionRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public MobileAppContentFileRequestBuilder MobileAppContentFile { get =>
            new MobileAppContentFileRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public PrintDocumentRequestBuilder PrintDocument { get =>
            new PrintDocumentRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public PrintJobRequestBuilder PrintJob { get =>
            new PrintJobRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ScheduleChangeRequestRequestBuilder ScheduleChangeRequest { get =>
            new ScheduleChangeRequestRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TargetedManagedAppProtectionRequestBuilder TargetedManagedAppProtection { get =>
            new TargetedManagedAppProtectionRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public WindowsInformationProtectionRequestBuilder WindowsInformationProtection { get =>
            new WindowsInformationProtectionRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public WorkbookRangeRequestBuilder WorkbookRange { get =>
            new WorkbookRangeRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public WorkbookRangeFillRequestBuilder WorkbookRangeFill { get =>
            new WorkbookRangeFillRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public WorkbookRangeFormatRequestBuilder WorkbookRangeFormat { get =>
            new WorkbookRangeFormatRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public WorkbookRangeSortRequestBuilder WorkbookRangeSort { get =>
            new WorkbookRangeSortRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public WorkbookRangeViewRequestBuilder WorkbookRangeView { get =>
            new WorkbookRangeViewRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new ResourceRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public ResourceRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/resource";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Used for navigating to the item that was used. For file attachments, the type is fileAttachment. For linked attachments, the type is driveItem.
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
        /// Used for navigating to the item that was used. For file attachments, the type is fileAttachment. For linked attachments, the type is driveItem.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Entity> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<Entity>(requestInfo, responseHandler);
        }
        /// <summary>Used for navigating to the item that was used. For file attachments, the type is fileAttachment. For linked attachments, the type is driveItem.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
