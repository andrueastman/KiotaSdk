using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.ServicePrincipals.Item.AddKey;
using ApiSdk.ServicePrincipals.Item.AddPassword;
using ApiSdk.ServicePrincipals.Item.AppRoleAssignedTo;
using ApiSdk.ServicePrincipals.Item.AppRoleAssignments;
using ApiSdk.ServicePrincipals.Item.CheckMemberGroups;
using ApiSdk.ServicePrincipals.Item.CheckMemberObjects;
using ApiSdk.ServicePrincipals.Item.ClaimsMappingPolicies;
using ApiSdk.ServicePrincipals.Item.CreatedObjects;
using ApiSdk.ServicePrincipals.Item.DelegatedPermissionClassifications;
using ApiSdk.ServicePrincipals.Item.Endpoints;
using ApiSdk.ServicePrincipals.Item.GetMemberGroups;
using ApiSdk.ServicePrincipals.Item.GetMemberObjects;
using ApiSdk.ServicePrincipals.Item.HomeRealmDiscoveryPolicies;
using ApiSdk.ServicePrincipals.Item.MemberOf;
using ApiSdk.ServicePrincipals.Item.Oauth2PermissionGrants;
using ApiSdk.ServicePrincipals.Item.OwnedObjects;
using ApiSdk.ServicePrincipals.Item.Owners;
using ApiSdk.ServicePrincipals.Item.RemoveKey;
using ApiSdk.ServicePrincipals.Item.RemovePassword;
using ApiSdk.ServicePrincipals.Item.Restore;
using ApiSdk.ServicePrincipals.Item.TokenIssuancePolicies;
using ApiSdk.ServicePrincipals.Item.TokenLifetimePolicies;
using ApiSdk.ServicePrincipals.Item.TransitiveMemberOf;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.ServicePrincipals.Item {
    /// <summary>Builds and executes requests for operations under \servicePrincipals\{servicePrincipal-id}</summary>
    public class ServicePrincipalRequestBuilder {
        public AddKeyRequestBuilder AddKey { get =>
            new AddKeyRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public AddPasswordRequestBuilder AddPassword { get =>
            new AddPasswordRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public AppRoleAssignedToRequestBuilder AppRoleAssignedTo { get =>
            new AppRoleAssignedToRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CheckMemberGroupsRequestBuilder CheckMemberGroups { get =>
            new CheckMemberGroupsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CheckMemberObjectsRequestBuilder CheckMemberObjects { get =>
            new CheckMemberObjectsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ClaimsMappingPoliciesRequestBuilder ClaimsMappingPolicies { get =>
            new ClaimsMappingPoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CreatedObjectsRequestBuilder CreatedObjects { get =>
            new CreatedObjectsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DelegatedPermissionClassificationsRequestBuilder DelegatedPermissionClassifications { get =>
            new DelegatedPermissionClassificationsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public EndpointsRequestBuilder Endpoints { get =>
            new EndpointsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public GetMemberGroupsRequestBuilder GetMemberGroups { get =>
            new GetMemberGroupsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public GetMemberObjectsRequestBuilder GetMemberObjects { get =>
            new GetMemberObjectsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public HomeRealmDiscoveryPoliciesRequestBuilder HomeRealmDiscoveryPolicies { get =>
            new HomeRealmDiscoveryPoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public MemberOfRequestBuilder MemberOf { get =>
            new MemberOfRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants { get =>
            new Oauth2PermissionGrantsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OwnedObjectsRequestBuilder OwnedObjects { get =>
            new OwnedObjectsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OwnersRequestBuilder Owners { get =>
            new OwnersRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public RemoveKeyRequestBuilder RemoveKey { get =>
            new RemoveKeyRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public RemovePasswordRequestBuilder RemovePassword { get =>
            new RemovePasswordRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TokenIssuancePoliciesRequestBuilder TokenIssuancePolicies { get =>
            new TokenIssuancePoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TokenLifetimePoliciesRequestBuilder TokenLifetimePolicies { get =>
            new TokenLifetimePoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TransitiveMemberOfRequestBuilder TransitiveMemberOf { get =>
            new TransitiveMemberOfRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new ServicePrincipalRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public ServicePrincipalRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
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
        public RequestInformation CreatePatchRequestInformation(ServicePrincipal body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        public async Task<ServicePrincipal> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<ServicePrincipal>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ServicePrincipal body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
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
