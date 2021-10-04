using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Charts.Item.Axes;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Charts.Item.DataLabels;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Charts.Item.Format;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Charts.Item.Image;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Charts.Item.ImageWithWidth;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Charts.Item.ImageWithWidthWithHeight;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Charts.Item.ImageWithWidthWithHeightWithFittingMode;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Charts.Item.Legend;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Charts.Item.Series;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Charts.Item.SetData;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Charts.Item.SetPosition;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Charts.Item.Title;
using ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Charts.Item.Worksheet;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Workbooks.Item.Workbook.Tables.Item.Worksheet.Charts.Item {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\tables\{workbookTable-id}\worksheet\charts\{workbookChart-id}</summary>
    public class WorkbookChartRequestBuilder {
        public AxesRequestBuilder Axes { get =>
            new AxesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DataLabelsRequestBuilder DataLabels { get =>
            new DataLabelsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public FormatRequestBuilder Format { get =>
            new FormatRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public LegendRequestBuilder Legend { get =>
            new LegendRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public SeriesRequestBuilder Series { get =>
            new SeriesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public SetDataRequestBuilder SetData { get =>
            new SetDataRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public SetPositionRequestBuilder SetPosition { get =>
            new SetPositionRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TitleRequestBuilder Title { get =>
            new TitleRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public WorksheetRequestBuilder Worksheet { get =>
            new WorksheetRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new WorkbookChartRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public WorkbookChartRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Returns collection of charts that are part of the worksheet. Read-only.
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
        /// Returns collection of charts that are part of the worksheet. Read-only.
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
        /// Returns collection of charts that are part of the worksheet. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(WorkbookChart body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// Returns collection of charts that are part of the worksheet. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Returns collection of charts that are part of the worksheet. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<WorkbookChart> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<WorkbookChart>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\tables\{workbookTable-id}\worksheet\charts\{workbookChart-id}\microsoft.graph.image()
        /// </summary>
        public ImageRequestBuilder image() {
            return new ImageRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\tables\{workbookTable-id}\worksheet\charts\{workbookChart-id}\microsoft.graph.image(width={width})
        /// <param name="width">Usage: width={width}</param>
        /// </summary>
        public ImageWithWidthRequestBuilder imageWithWidth(int? width) {
            _ = width ?? throw new ArgumentNullException(nameof(width));
            return new ImageWithWidthRequestBuilder(CurrentPath + PathSegment , HttpCore, width, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\tables\{workbookTable-id}\worksheet\charts\{workbookChart-id}\microsoft.graph.image(width={width},height={height})
        /// <param name="height">Usage: height={height}</param>
        /// <param name="width">Usage: width={width}</param>
        /// </summary>
        public ImageWithWidthWithHeightRequestBuilder imageWithWidthWithHeight(int? width, int? height) {
            _ = height ?? throw new ArgumentNullException(nameof(height));
            _ = width ?? throw new ArgumentNullException(nameof(width));
            return new ImageWithWidthWithHeightRequestBuilder(CurrentPath + PathSegment , HttpCore, width, height, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\tables\{workbookTable-id}\worksheet\charts\{workbookChart-id}\microsoft.graph.image(width={width},height={height},fittingMode='{fittingMode}')
        /// <param name="fittingMode">Usage: fittingMode={fittingMode}</param>
        /// <param name="height">Usage: height={height}</param>
        /// <param name="width">Usage: width={width}</param>
        /// </summary>
        public ImageWithWidthWithHeightWithFittingModeRequestBuilder imageWithWidthWithHeightWithFittingMode(int? width, int? height, string fittingMode) {
            if(string.IsNullOrEmpty(fittingMode)) throw new ArgumentNullException(nameof(fittingMode));
            _ = height ?? throw new ArgumentNullException(nameof(height));
            _ = width ?? throw new ArgumentNullException(nameof(width));
            return new ImageWithWidthWithHeightWithFittingModeRequestBuilder(CurrentPath + PathSegment , HttpCore, width, height, fittingMode, false);
        }
        /// <summary>
        /// Returns collection of charts that are part of the worksheet. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(WorkbookChart body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>Returns collection of charts that are part of the worksheet. Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
