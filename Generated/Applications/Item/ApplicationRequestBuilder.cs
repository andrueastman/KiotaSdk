using ApiSdk.Applications.Item.AddKey;
using ApiSdk.Applications.Item.AddPassword;
using ApiSdk.Applications.Item.CheckMemberGroups;
using ApiSdk.Applications.Item.CheckMemberObjects;
using ApiSdk.Applications.Item.CreatedOnBehalfOf;
using ApiSdk.Applications.Item.ExtensionProperties;
using ApiSdk.Applications.Item.GetMemberGroups;
using ApiSdk.Applications.Item.GetMemberObjects;
using ApiSdk.Applications.Item.HomeRealmDiscoveryPolicies;
using ApiSdk.Applications.Item.Logo;
using ApiSdk.Applications.Item.Owners;
using ApiSdk.Applications.Item.RemoveKey;
using ApiSdk.Applications.Item.RemovePassword;
using ApiSdk.Applications.Item.Restore;
using ApiSdk.Applications.Item.TokenIssuancePolicies;
using ApiSdk.Applications.Item.TokenLifetimePolicies;
using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Applications.Item {
    /// <summary>Builds and executes requests for operations under \applications\{application-id}</summary>
    public class ApplicationRequestBuilder {
        public AddKeyRequestBuilder AddKey { get =>
            new AddKeyRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AddPasswordRequestBuilder AddPassword { get =>
            new AddPasswordRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CheckMemberGroupsRequestBuilder CheckMemberGroups { get =>
            new CheckMemberGroupsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CheckMemberObjectsRequestBuilder CheckMemberObjects { get =>
            new CheckMemberObjectsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CreatedOnBehalfOfRequestBuilder CreatedOnBehalfOf { get =>
            new CreatedOnBehalfOfRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public ExtensionPropertiesRequestBuilder ExtensionProperties { get =>
            new ExtensionPropertiesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public GetMemberGroupsRequestBuilder GetMemberGroups { get =>
            new GetMemberGroupsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public GetMemberObjectsRequestBuilder GetMemberObjects { get =>
            new GetMemberObjectsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public HomeRealmDiscoveryPoliciesRequestBuilder HomeRealmDiscoveryPolicies { get =>
            new HomeRealmDiscoveryPoliciesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public LogoRequestBuilder Logo { get =>
            new LogoRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public OwnersRequestBuilder Owners { get =>
            new OwnersRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public RemoveKeyRequestBuilder RemoveKey { get =>
            new RemoveKeyRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RemovePasswordRequestBuilder RemovePassword { get =>
            new RemovePasswordRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TokenIssuancePoliciesRequestBuilder TokenIssuancePolicies { get =>
            new TokenIssuancePoliciesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TokenLifetimePoliciesRequestBuilder TokenLifetimePolicies { get =>
            new TokenLifetimePoliciesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Instantiates a new ApplicationRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public ApplicationRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
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
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
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
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.Application body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApiSdk.Models.Microsoft.Graph.Application> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ApiSdk.Models.Microsoft.Graph.Application>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ApiSdk.Models.Microsoft.Graph.Application body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
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
