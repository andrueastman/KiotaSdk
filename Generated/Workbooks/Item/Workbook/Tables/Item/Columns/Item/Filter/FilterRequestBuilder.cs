using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.Apply;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyBottomItemsFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyBottomPercentFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyCellColorFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyCustomFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyDynamicFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyFontColorFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyIconFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyTopItemsFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyTopPercentFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.ApplyValuesFilter;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter.Clear;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Workbooks.Item.Workbook.Tables.Item.Columns.Item.Filter {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\tables\{workbookTable-id}\columns\{workbookTableColumn-id}\filter</summary>
    public class FilterRequestBuilder {
        public ApplyRequestBuilder Apply { get =>
            new ApplyRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ApplyBottomItemsFilterRequestBuilder ApplyBottomItemsFilter { get =>
            new ApplyBottomItemsFilterRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ApplyBottomPercentFilterRequestBuilder ApplyBottomPercentFilter { get =>
            new ApplyBottomPercentFilterRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ApplyCellColorFilterRequestBuilder ApplyCellColorFilter { get =>
            new ApplyCellColorFilterRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ApplyCustomFilterRequestBuilder ApplyCustomFilter { get =>
            new ApplyCustomFilterRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ApplyDynamicFilterRequestBuilder ApplyDynamicFilter { get =>
            new ApplyDynamicFilterRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ApplyFontColorFilterRequestBuilder ApplyFontColorFilter { get =>
            new ApplyFontColorFilterRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ApplyIconFilterRequestBuilder ApplyIconFilter { get =>
            new ApplyIconFilterRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ApplyTopItemsFilterRequestBuilder ApplyTopItemsFilter { get =>
            new ApplyTopItemsFilterRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ApplyTopPercentFilterRequestBuilder ApplyTopPercentFilter { get =>
            new ApplyTopPercentFilterRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ApplyValuesFilterRequestBuilder ApplyValuesFilter { get =>
            new ApplyValuesFilterRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ClearRequestBuilder Clear { get =>
            new ClearRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>
        /// Instantiates a new FilterRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public FilterRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "/filter";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
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
        /// Retrieve the filter applied to the column. Read-only.
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
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(WorkbookFilter body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<WorkbookFilter> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<WorkbookFilter>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(WorkbookFilter body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>Retrieve the filter applied to the column. Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
