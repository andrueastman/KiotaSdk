using ApiSdk.DirectoryRoles.Delta;
using ApiSdk.DirectoryRoles.GetAvailableExtensionProperties;
using ApiSdk.DirectoryRoles.GetByIds;
using ApiSdk.DirectoryRoles.Item;
using ApiSdk.DirectoryRoles.ValidateProperties;
using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.DirectoryRoles {
    /// <summary>Builds and executes requests for operations under \directoryRoles</summary>
    public class DirectoryRolesRequestBuilder {
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public GetAvailableExtensionPropertiesRequestBuilder GetAvailableExtensionProperties { get =>
            new GetAvailableExtensionPropertiesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public GetByIdsRequestBuilder GetByIds { get =>
            new GetByIdsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public ValidatePropertiesRequestBuilder ValidateProperties { get =>
            new ValidatePropertiesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Gets an item from the ApiSdk.directoryRoles.item collection</summary>
        public DirectoryRoleRequestBuilder this[string position] { get {
            return new DirectoryRoleRequestBuilder(CurrentPath + PathSegment  + "/" + position, HttpCore, false);
        } }
        /// <summary>
        /// Instantiates a new DirectoryRolesRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public DirectoryRolesRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/directoryRoles";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Get entities from directoryRoles
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
        /// Add new entity to directoryRoles
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePostRequestInformation(DirectoryRole body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.POST,
            };
            requestInfo.SetURI(CurrentPath, PathSegment, IsRawUrl);
            requestInfo.SetContentFromParsable(HttpCore, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddMiddlewareOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Builds and executes requests for operations under \directoryRoles\microsoft.graph.delta()
        /// </summary>
        public DeltaRequestBuilder delta() {
            return new DeltaRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Get entities from directoryRoles
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<DirectoryRolesResponse> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<DirectoryRolesResponse>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Add new entity to directoryRoles
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<DirectoryRole> PostAsync(DirectoryRole body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePostRequestInformation(body, h, o);
            return await HttpCore.SendAsync<DirectoryRole>(requestInfo, responseHandler);
        }
        /// <summary>Get entities from directoryRoles</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Include count of items</summary>
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Filter items by property values</summary>
            public string Filter { get; set; }
            /// <summary>Order items by property values</summary>
            public string[] Orderby { get; set; }
            /// <summary>Search items by search phrases</summary>
            public string Search { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
            /// <summary>Skip the first n items</summary>
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            public int? Top { get; set; }
        }
    }
}
