using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.CellWithRowWithColumn;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Charts;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Names;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.PivotTables;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Protection;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Range;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.RangeWithAddress;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.Tables;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.UsedRange;
using ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet.UsedRangeWithValuesOnly;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Workbooks.Item.Workbook.Names.Item.Worksheet {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet</summary>
    public class WorksheetRequestBuilder {
        public ChartsRequestBuilder Charts { get =>
            new ChartsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public NamesRequestBuilder Names { get =>
            new NamesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public PivotTablesRequestBuilder PivotTables { get =>
            new PivotTablesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ProtectionRequestBuilder Protection { get =>
            new ProtectionRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TablesRequestBuilder Tables { get =>
            new TablesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\microsoft.graph.cell(row={row},column={column})
        /// <param name="column">Usage: column={column}</param>
        /// <param name="row">Usage: row={row}</param>
        /// </summary>
        public CellWithRowWithColumnRequestBuilder cellWithRowWithColumn(int? row, int? column) {
            _ = column ?? throw new ArgumentNullException(nameof(column));
            _ = row ?? throw new ArgumentNullException(nameof(row));
            return new CellWithRowWithColumnRequestBuilder(CurrentPath + PathSegment , HttpCore, row, column, false);
        }
        /// <summary>
        /// Instantiates a new WorksheetRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public WorksheetRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/worksheet";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Returns the worksheet on which the named item is scoped to. Available only if the item is scoped to the worksheet. Read-only.
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
        /// Returns the worksheet on which the named item is scoped to. Available only if the item is scoped to the worksheet. Read-only.
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
        /// Returns the worksheet on which the named item is scoped to. Available only if the item is scoped to the worksheet. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(WorkbookWorksheet body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// Returns the worksheet on which the named item is scoped to. Available only if the item is scoped to the worksheet. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Returns the worksheet on which the named item is scoped to. Available only if the item is scoped to the worksheet. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<WorkbookWorksheet> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<WorkbookWorksheet>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Returns the worksheet on which the named item is scoped to. Available only if the item is scoped to the worksheet. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(WorkbookWorksheet body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\microsoft.graph.range()
        /// </summary>
        public RangeRequestBuilder range() {
            return new RangeRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\microsoft.graph.range(address='{address}')
        /// <param name="address">Usage: address={address}</param>
        /// </summary>
        public RangeWithAddressRequestBuilder rangeWithAddress(string address) {
            if(string.IsNullOrEmpty(address)) throw new ArgumentNullException(nameof(address));
            return new RangeWithAddressRequestBuilder(CurrentPath + PathSegment , HttpCore, address, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\microsoft.graph.usedRange()
        /// </summary>
        public UsedRangeRequestBuilder usedRange() {
            return new UsedRangeRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\names\{workbookNamedItem-id}\worksheet\microsoft.graph.usedRange(valuesOnly={valuesOnly})
        /// <param name="valuesOnly">Usage: valuesOnly={valuesOnly}</param>
        /// </summary>
        public UsedRangeWithValuesOnlyRequestBuilder usedRangeWithValuesOnly(bool? valuesOnly) {
            _ = valuesOnly ?? throw new ArgumentNullException(nameof(valuesOnly));
            return new UsedRangeWithValuesOnlyRequestBuilder(CurrentPath + PathSegment , HttpCore, valuesOnly, false);
        }
        /// <summary>Returns the worksheet on which the named item is scoped to. Available only if the item is scoped to the worksheet. Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
