using ApiSdk.DeviceAppManagement.AndroidManagedAppProtections;
using ApiSdk.DeviceAppManagement.DefaultManagedAppProtections;
using ApiSdk.DeviceAppManagement.IosManagedAppProtections;
using ApiSdk.DeviceAppManagement.ManagedAppPolicies;
using ApiSdk.DeviceAppManagement.ManagedAppRegistrations;
using ApiSdk.DeviceAppManagement.ManagedAppStatuses;
using ApiSdk.DeviceAppManagement.ManagedEBooks;
using ApiSdk.DeviceAppManagement.MdmWindowsInformationProtectionPolicies;
using ApiSdk.DeviceAppManagement.MobileAppCategories;
using ApiSdk.DeviceAppManagement.MobileAppConfigurations;
using ApiSdk.DeviceAppManagement.MobileApps;
using ApiSdk.DeviceAppManagement.SyncMicrosoftStoreForBusinessApps;
using ApiSdk.DeviceAppManagement.TargetedManagedAppConfigurations;
using ApiSdk.DeviceAppManagement.VppTokens;
using ApiSdk.DeviceAppManagement.WindowsInformationProtectionPolicies;
using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.DeviceAppManagement {
    /// <summary>Builds and executes requests for operations under \deviceAppManagement</summary>
    public class DeviceAppManagementRequestBuilder {
        public AndroidManagedAppProtectionsRequestBuilder AndroidManagedAppProtections { get =>
            new AndroidManagedAppProtectionsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DefaultManagedAppProtectionsRequestBuilder DefaultManagedAppProtections { get =>
            new DefaultManagedAppProtectionsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IosManagedAppProtectionsRequestBuilder IosManagedAppProtections { get =>
            new IosManagedAppProtectionsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public ManagedAppPoliciesRequestBuilder ManagedAppPolicies { get =>
            new ManagedAppPoliciesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ManagedAppRegistrationsRequestBuilder ManagedAppRegistrations { get =>
            new ManagedAppRegistrationsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ManagedAppStatusesRequestBuilder ManagedAppStatuses { get =>
            new ManagedAppStatusesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ManagedEBooksRequestBuilder ManagedEBooks { get =>
            new ManagedEBooksRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MdmWindowsInformationProtectionPoliciesRequestBuilder MdmWindowsInformationProtectionPolicies { get =>
            new MdmWindowsInformationProtectionPoliciesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MobileAppCategoriesRequestBuilder MobileAppCategories { get =>
            new MobileAppCategoriesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MobileAppConfigurationsRequestBuilder MobileAppConfigurations { get =>
            new MobileAppConfigurationsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MobileAppsRequestBuilder MobileApps { get =>
            new MobileAppsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public SyncMicrosoftStoreForBusinessAppsRequestBuilder SyncMicrosoftStoreForBusinessApps { get =>
            new SyncMicrosoftStoreForBusinessAppsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TargetedManagedAppConfigurationsRequestBuilder TargetedManagedAppConfigurations { get =>
            new TargetedManagedAppConfigurationsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public VppTokensRequestBuilder VppTokens { get =>
            new VppTokensRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WindowsInformationProtectionPoliciesRequestBuilder WindowsInformationProtectionPolicies { get =>
            new WindowsInformationProtectionPoliciesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Instantiates a new DeviceAppManagementRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public DeviceAppManagementRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "/deviceAppManagement";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Get deviceAppManagement
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
        /// Update deviceAppManagement
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.DeviceAppManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Get deviceAppManagement
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApiSdk.Models.Microsoft.Graph.DeviceAppManagement> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ApiSdk.Models.Microsoft.Graph.DeviceAppManagement>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Update deviceAppManagement
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ApiSdk.Models.Microsoft.Graph.DeviceAppManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
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
