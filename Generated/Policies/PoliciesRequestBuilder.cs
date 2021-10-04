using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Policies.ActivityBasedTimeoutPolicies;
using ApiSdk.Policies.AdminConsentRequestPolicy;
using ApiSdk.Policies.AuthenticationFlowsPolicy;
using ApiSdk.Policies.AuthenticationMethodsPolicy;
using ApiSdk.Policies.AuthorizationPolicy;
using ApiSdk.Policies.ClaimsMappingPolicies;
using ApiSdk.Policies.ConditionalAccessPolicies;
using ApiSdk.Policies.FeatureRolloutPolicies;
using ApiSdk.Policies.HomeRealmDiscoveryPolicies;
using ApiSdk.Policies.IdentitySecurityDefaultsEnforcementPolicy;
using ApiSdk.Policies.PermissionGrantPolicies;
using ApiSdk.Policies.TokenIssuancePolicies;
using ApiSdk.Policies.TokenLifetimePolicies;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Policies {
    /// <summary>Builds and executes requests for operations under \policies</summary>
    public class PoliciesRequestBuilder {
        public ActivityBasedTimeoutPoliciesRequestBuilder ActivityBasedTimeoutPolicies { get =>
            new ActivityBasedTimeoutPoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public AdminConsentRequestPolicyRequestBuilder AdminConsentRequestPolicy { get =>
            new AdminConsentRequestPolicyRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public AuthenticationFlowsPolicyRequestBuilder AuthenticationFlowsPolicy { get =>
            new AuthenticationFlowsPolicyRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public AuthenticationMethodsPolicyRequestBuilder AuthenticationMethodsPolicy { get =>
            new AuthenticationMethodsPolicyRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public AuthorizationPolicyRequestBuilder AuthorizationPolicy { get =>
            new AuthorizationPolicyRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ClaimsMappingPoliciesRequestBuilder ClaimsMappingPolicies { get =>
            new ClaimsMappingPoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ConditionalAccessPoliciesRequestBuilder ConditionalAccessPolicies { get =>
            new ConditionalAccessPoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public FeatureRolloutPoliciesRequestBuilder FeatureRolloutPolicies { get =>
            new FeatureRolloutPoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public HomeRealmDiscoveryPoliciesRequestBuilder HomeRealmDiscoveryPolicies { get =>
            new HomeRealmDiscoveryPoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        public IdentitySecurityDefaultsEnforcementPolicyRequestBuilder IdentitySecurityDefaultsEnforcementPolicy { get =>
            new IdentitySecurityDefaultsEnforcementPolicyRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public PermissionGrantPoliciesRequestBuilder PermissionGrantPolicies { get =>
            new PermissionGrantPoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TokenIssuancePoliciesRequestBuilder TokenIssuancePolicies { get =>
            new TokenIssuancePoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TokenLifetimePoliciesRequestBuilder TokenLifetimePolicies { get =>
            new TokenLifetimePoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new PoliciesRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public PoliciesRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/policies";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Get policies
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
        /// Update policies
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(PolicyRoot body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// Get policies
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<PolicyRoot> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<PolicyRoot>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Update policies
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(PolicyRoot body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>Get policies</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
