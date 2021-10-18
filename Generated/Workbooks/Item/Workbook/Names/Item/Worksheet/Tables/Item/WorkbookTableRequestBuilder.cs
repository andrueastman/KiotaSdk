using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.ClearFilters;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Columns;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.ConvertToRange;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.DataBodyRange;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.HeaderRowRange;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Range;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.ReapplyFilters;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Rows;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Sort;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.TotalRowRange;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item.Worksheet;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables.Item {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\tables\{workbookTable-id}</summary>
    public class WorkbookTableRequestBuilder {
        public ClearFiltersRequestBuilder ClearFilters { get =>
            new ClearFiltersRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ColumnsRequestBuilder Columns { get =>
            new ColumnsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ConvertToRangeRequestBuilder ConvertToRange { get =>
            new ConvertToRangeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public ReapplyFiltersRequestBuilder ReapplyFilters { get =>
            new ReapplyFiltersRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public RowsRequestBuilder Rows { get =>
            new RowsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SortRequestBuilder Sort { get =>
            new SortRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WorksheetRequestBuilder Worksheet { get =>
            new WorksheetRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Instantiates a new WorkbookTableRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public WorkbookTableRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Collection of tables that are part of the worksheet. Read-only.
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
        /// Collection of tables that are part of the worksheet. Read-only.
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
        /// Collection of tables that are part of the worksheet. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(WorkbookTable body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\tables\{workbookTable-id}\microsoft.graph.dataBodyRange()
        /// </summary>
        public DataBodyRangeRequestBuilder dataBodyRange() {
            return new DataBodyRangeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Collection of tables that are part of the worksheet. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Collection of tables that are part of the worksheet. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<WorkbookTable> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<WorkbookTable>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\tables\{workbookTable-id}\microsoft.graph.headerRowRange()
        /// </summary>
        public HeaderRowRangeRequestBuilder headerRowRange() {
            return new HeaderRowRangeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Collection of tables that are part of the worksheet. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(WorkbookTable body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\tables\{workbookTable-id}\microsoft.graph.range()
        /// </summary>
        public RangeRequestBuilder range() {
            return new RangeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\tables\{workbookTable-id}\microsoft.graph.totalRowRange()
        /// </summary>
        public TotalRowRangeRequestBuilder totalRowRange() {
            return new TotalRowRangeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Collection of tables that are part of the worksheet. Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
