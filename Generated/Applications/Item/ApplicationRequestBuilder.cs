using GraphServiceClient.Applications.CreatedOnBehalfOf;
using GraphServiceClient.Applications.ExtensionProperties;
using GraphServiceClient.Applications.HomeRealmDiscoveryPolicies;
using GraphServiceClient.Applications.Logo;
using GraphServiceClient.Applications.Microsoft.Graph.AddKey;
using GraphServiceClient.Applications.Microsoft.Graph.AddPassword;
using GraphServiceClient.Applications.Microsoft.Graph.CheckMemberGroups;
using GraphServiceClient.Applications.Microsoft.Graph.CheckMemberObjects;
using GraphServiceClient.Applications.Microsoft.Graph.GetMemberGroups;
using GraphServiceClient.Applications.Microsoft.Graph.GetMemberObjects;
using GraphServiceClient.Applications.Microsoft.Graph.RemoveKey;
using GraphServiceClient.Applications.Microsoft.Graph.RemovePassword;
using GraphServiceClient.Applications.Microsoft.Graph.Restore;
using GraphServiceClient.Applications.Owners;
using GraphServiceClient.Applications.TokenIssuancePolicies;
using GraphServiceClient.Applications.TokenLifetimePolicies;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.Applications.Item {
    /// <summary>Builds and executes requests for operations under \applications\{application-id}</summary>
    public class ApplicationRequestBuilder {
        public CreatedOnBehalfOfRequestBuilder CreatedOnBehalfOf { get =>
            new CreatedOnBehalfOfRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public ExtensionPropertiesRequestBuilder ExtensionProperties { get =>
            new ExtensionPropertiesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public HomeRealmDiscoveryPoliciesRequestBuilder HomeRealmDiscoveryPolicies { get =>
            new HomeRealmDiscoveryPoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public LogoRequestBuilder Logo { get =>
            new LogoRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.addKeyRequestBuilder Microsoft.graph.addKey { get =>
            new Microsoft.graph.addKeyRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.addPasswordRequestBuilder Microsoft.graph.addPassword { get =>
            new Microsoft.graph.addPasswordRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.checkMemberGroupsRequestBuilder Microsoft.graph.checkMemberGroups { get =>
            new Microsoft.graph.checkMemberGroupsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.checkMemberObjectsRequestBuilder Microsoft.graph.checkMemberObjects { get =>
            new Microsoft.graph.checkMemberObjectsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.getMemberGroupsRequestBuilder Microsoft.graph.getMemberGroups { get =>
            new Microsoft.graph.getMemberGroupsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.getMemberObjectsRequestBuilder Microsoft.graph.getMemberObjects { get =>
            new Microsoft.graph.getMemberObjectsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.removeKeyRequestBuilder Microsoft.graph.removeKey { get =>
            new Microsoft.graph.removeKeyRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.removePasswordRequestBuilder Microsoft.graph.removePassword { get =>
            new Microsoft.graph.removePasswordRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.restoreRequestBuilder Microsoft.graph.restore { get =>
            new Microsoft.graph.restoreRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OwnersRequestBuilder Owners { get =>
            new OwnersRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public TokenIssuancePoliciesRequestBuilder TokenIssuancePolicies { get =>
            new TokenIssuancePoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TokenLifetimePoliciesRequestBuilder TokenLifetimePolicies { get =>
            new TokenLifetimePoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new ApplicationRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public ApplicationRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
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
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
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
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Application body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Application> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<Application>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Application body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
