using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Workbooks.Item.Workbook.Application;
using ApiSdk.Workbooks.Item.Workbook.CloseSession;
using ApiSdk.Workbooks.Item.Workbook.Comments;
using ApiSdk.Workbooks.Item.Workbook.CreateSession;
using ApiSdk.Workbooks.Item.Workbook.Functions;
using ApiSdk.Workbooks.Item.Workbook.Names;
using ApiSdk.Workbooks.Item.Workbook.Operations;
using ApiSdk.Workbooks.Item.Workbook.RefreshSession;
using ApiSdk.Workbooks.Item.Workbook.SessionInfoResourceWithKey;
using ApiSdk.Workbooks.Item.Workbook.Tables;
using ApiSdk.Workbooks.Item.Workbook.Worksheets;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Workbooks.Item.Workbook {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook</summary>
    public class WorkbookRequestBuilder {
        public ApplicationRequestBuilder Application { get =>
            new ApplicationRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CloseSessionRequestBuilder CloseSession { get =>
            new CloseSessionRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CommentsRequestBuilder Comments { get =>
            new CommentsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CreateSessionRequestBuilder CreateSession { get =>
            new CreateSessionRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
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
        public NamesRequestBuilder Names { get =>
            new NamesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OperationsRequestBuilder Operations { get =>
            new OperationsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public RefreshSessionRequestBuilder RefreshSession { get =>
            new RefreshSessionRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
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
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.Workbook body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        public async Task<ApiSdk.Models.Microsoft.Graph.Workbook> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<ApiSdk.Models.Microsoft.Graph.Workbook>(requestInfo, responseHandler);
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ApiSdk.Models.Microsoft.Graph.Workbook body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\microsoft.graph.sessionInfoResource(key='{key}')
        /// <param name="key">Usage: key={key}</param>
        /// </summary>
        public SessionInfoResourceWithKeyRequestBuilder sessionInfoResourceWithKey(string key) {
            if(string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));
            return new SessionInfoResourceWithKeyRequestBuilder(CurrentPath + PathSegment , HttpCore, key, false);
        }
        /// <summary>For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
        }
    }
}
