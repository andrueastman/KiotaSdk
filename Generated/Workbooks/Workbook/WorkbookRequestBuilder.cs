using GraphServiceClient.Workbooks.Workbook.Application;
using GraphServiceClient.Workbooks.Workbook.Comments;
using GraphServiceClient.Workbooks.Workbook.Functions;
using GraphServiceClient.Workbooks.Workbook.Microsoft.Graph.CloseSession;
using GraphServiceClient.Workbooks.Workbook.Microsoft.Graph.CreateSession;
using GraphServiceClient.Workbooks.Workbook.Microsoft.Graph.RefreshSession;
using GraphServiceClient.Workbooks.Workbook.Names;
using GraphServiceClient.Workbooks.Workbook.Operations;
using GraphServiceClient.Workbooks.Workbook.Tables;
using GraphServiceClient.Workbooks.Workbook.Worksheets;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.Workbooks.Workbook {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook</summary>
    public class WorkbookRequestBuilder {
        public ApplicationRequestBuilder Application { get =>
            new ApplicationRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CommentsRequestBuilder Comments { get =>
            new CommentsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public FunctionsRequestBuilder Functions { get =>
            new FunctionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public Microsoft.graph.closeSessionRequestBuilder Microsoft.graph.closeSession { get =>
            new Microsoft.graph.closeSessionRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.createSessionRequestBuilder Microsoft.graph.createSession { get =>
            new Microsoft.graph.createSessionRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.refreshSessionRequestBuilder Microsoft.graph.refreshSession { get =>
            new Microsoft.graph.refreshSessionRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public NamesRequestBuilder Names { get =>
            new NamesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OperationsRequestBuilder Operations { get =>
            new OperationsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public TablesRequestBuilder Tables { get =>
            new TablesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public WorksheetsRequestBuilder Worksheets { get =>
            new WorksheetsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new WorkbookRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public WorkbookRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/workbook";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
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
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
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
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Workbook body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Workbook> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<Workbook>(requestInfo, responseHandler);
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Workbook body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
        }
    }
}
