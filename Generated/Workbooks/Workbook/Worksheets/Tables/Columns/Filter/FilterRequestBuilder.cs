using GraphServiceClient.Workbooks.Workbook.Tables.Columns.Filter;
using GraphServiceClient.Workbooks.Workbook.Worksheets.Tables.Columns.Filter.Microsoft.Graph.Apply;
using GraphServiceClient.Workbooks.Workbook.Worksheets.Tables.Columns.Filter.Microsoft.Graph.ApplyBottomItemsFilter;
using GraphServiceClient.Workbooks.Workbook.Worksheets.Tables.Columns.Filter.Microsoft.Graph.ApplyBottomPercentFilter;
using GraphServiceClient.Workbooks.Workbook.Worksheets.Tables.Columns.Filter.Microsoft.Graph.ApplyCellColorFilter;
using GraphServiceClient.Workbooks.Workbook.Worksheets.Tables.Columns.Filter.Microsoft.Graph.ApplyCustomFilter;
using GraphServiceClient.Workbooks.Workbook.Worksheets.Tables.Columns.Filter.Microsoft.Graph.ApplyDynamicFilter;
using GraphServiceClient.Workbooks.Workbook.Worksheets.Tables.Columns.Filter.Microsoft.Graph.ApplyFontColorFilter;
using GraphServiceClient.Workbooks.Workbook.Worksheets.Tables.Columns.Filter.Microsoft.Graph.ApplyIconFilter;
using GraphServiceClient.Workbooks.Workbook.Worksheets.Tables.Columns.Filter.Microsoft.Graph.ApplyTopItemsFilter;
using GraphServiceClient.Workbooks.Workbook.Worksheets.Tables.Columns.Filter.Microsoft.Graph.ApplyTopPercentFilter;
using GraphServiceClient.Workbooks.Workbook.Worksheets.Tables.Columns.Filter.Microsoft.Graph.ApplyValuesFilter;
using GraphServiceClient.Workbooks.Workbook.Worksheets.Tables.Columns.Filter.Microsoft.Graph.Clear;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.Workbooks.Workbook.Worksheets.Tables.Columns.Filter {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\worksheets\{workbookWorksheet-id}\tables\{workbookTable-id}\columns\{workbookTableColumn-id}\filter</summary>
    public class FilterRequestBuilder {
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public Microsoft.graph.applyRequestBuilder Microsoft.graph.apply { get =>
            new Microsoft.graph.applyRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.applyBottomItemsFilterRequestBuilder Microsoft.graph.applyBottomItemsFilter { get =>
            new Microsoft.graph.applyBottomItemsFilterRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.applyBottomPercentFilterRequestBuilder Microsoft.graph.applyBottomPercentFilter { get =>
            new Microsoft.graph.applyBottomPercentFilterRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.applyCellColorFilterRequestBuilder Microsoft.graph.applyCellColorFilter { get =>
            new Microsoft.graph.applyCellColorFilterRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.applyCustomFilterRequestBuilder Microsoft.graph.applyCustomFilter { get =>
            new Microsoft.graph.applyCustomFilterRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.applyDynamicFilterRequestBuilder Microsoft.graph.applyDynamicFilter { get =>
            new Microsoft.graph.applyDynamicFilterRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.applyFontColorFilterRequestBuilder Microsoft.graph.applyFontColorFilter { get =>
            new Microsoft.graph.applyFontColorFilterRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.applyIconFilterRequestBuilder Microsoft.graph.applyIconFilter { get =>
            new Microsoft.graph.applyIconFilterRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.applyTopItemsFilterRequestBuilder Microsoft.graph.applyTopItemsFilter { get =>
            new Microsoft.graph.applyTopItemsFilterRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.applyTopPercentFilterRequestBuilder Microsoft.graph.applyTopPercentFilter { get =>
            new Microsoft.graph.applyTopPercentFilterRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.applyValuesFilterRequestBuilder Microsoft.graph.applyValuesFilter { get =>
            new Microsoft.graph.applyValuesFilterRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.clearRequestBuilder Microsoft.graph.clear { get =>
            new Microsoft.graph.clearRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>
        /// Instantiates a new FilterRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public FilterRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/filter";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
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
        /// Retrieve the filter applied to the column. Read-only.
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
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Filter body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<WorkbookFilter> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<WorkbookFilter>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Retrieve the filter applied to the column. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Filter body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
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
