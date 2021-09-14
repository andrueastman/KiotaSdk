using GraphServiceClient.DeviceAppManagement.AndroidManagedAppProtections;
using GraphServiceClient.DeviceAppManagement.DefaultManagedAppProtections;
using GraphServiceClient.DeviceAppManagement.IosManagedAppProtections;
using GraphServiceClient.DeviceAppManagement.ManagedAppPolicies;
using GraphServiceClient.DeviceAppManagement.ManagedAppRegistrations;
using GraphServiceClient.DeviceAppManagement.ManagedAppStatuses;
using GraphServiceClient.DeviceAppManagement.ManagedEBooks;
using GraphServiceClient.DeviceAppManagement.MdmWindowsInformationProtectionPolicies;
using GraphServiceClient.DeviceAppManagement.Microsoft.Graph.SyncMicrosoftStoreForBusinessApps;
using GraphServiceClient.DeviceAppManagement.MobileAppCategories;
using GraphServiceClient.DeviceAppManagement.MobileAppConfigurations;
using GraphServiceClient.DeviceAppManagement.MobileApps;
using GraphServiceClient.DeviceAppManagement.TargetedManagedAppConfigurations;
using GraphServiceClient.DeviceAppManagement.VppTokens;
using GraphServiceClient.DeviceAppManagement.WindowsInformationProtectionPolicies;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.DeviceAppManagement {
    /// <summary>Builds and executes requests for operations under \deviceAppManagement</summary>
    public class DeviceAppManagementRequestBuilder {
        public AndroidManagedAppProtectionsRequestBuilder AndroidManagedAppProtections { get =>
            new AndroidManagedAppProtectionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DefaultManagedAppProtectionsRequestBuilder DefaultManagedAppProtections { get =>
            new DefaultManagedAppProtectionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        public IosManagedAppProtectionsRequestBuilder IosManagedAppProtections { get =>
            new IosManagedAppProtectionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public ManagedAppPoliciesRequestBuilder ManagedAppPolicies { get =>
            new ManagedAppPoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ManagedAppRegistrationsRequestBuilder ManagedAppRegistrations { get =>
            new ManagedAppRegistrationsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ManagedAppStatusesRequestBuilder ManagedAppStatuses { get =>
            new ManagedAppStatusesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ManagedEBooksRequestBuilder ManagedEBooks { get =>
            new ManagedEBooksRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public MdmWindowsInformationProtectionPoliciesRequestBuilder MdmWindowsInformationProtectionPolicies { get =>
            new MdmWindowsInformationProtectionPoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.syncMicrosoftStoreForBusinessAppsRequestBuilder Microsoft.graph.syncMicrosoftStoreForBusinessApps { get =>
            new Microsoft.graph.syncMicrosoftStoreForBusinessAppsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public MobileAppCategoriesRequestBuilder MobileAppCategories { get =>
            new MobileAppCategoriesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public MobileAppConfigurationsRequestBuilder MobileAppConfigurations { get =>
            new MobileAppConfigurationsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public MobileAppsRequestBuilder MobileApps { get =>
            new MobileAppsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public TargetedManagedAppConfigurationsRequestBuilder TargetedManagedAppConfigurations { get =>
            new TargetedManagedAppConfigurationsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public VppTokensRequestBuilder VppTokens { get =>
            new VppTokensRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public WindowsInformationProtectionPoliciesRequestBuilder WindowsInformationProtectionPolicies { get =>
            new WindowsInformationProtectionPoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new DeviceAppManagementRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public DeviceAppManagementRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/deviceAppManagement";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Get deviceAppManagement
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
        /// Update deviceAppManagement
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(DeviceAppManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// Get deviceAppManagement
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<DeviceAppManagement> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<DeviceAppManagement>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Update deviceAppManagement
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(DeviceAppManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>Get deviceAppManagement</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
