using ApiSdk.DeviceManagement.ApplePushNotificationCertificate;
using ApiSdk.DeviceManagement.ComplianceManagementPartners;
using ApiSdk.DeviceManagement.ConditionalAccessSettings;
using ApiSdk.DeviceManagement.DetectedApps;
using ApiSdk.DeviceManagement.DeviceCategories;
using ApiSdk.DeviceManagement.DeviceCompliancePolicies;
using ApiSdk.DeviceManagement.DeviceCompliancePolicyDeviceStateSummary;
using ApiSdk.DeviceManagement.DeviceCompliancePolicySettingStateSummaries;
using ApiSdk.DeviceManagement.DeviceConfigurationDeviceStateSummaries;
using ApiSdk.DeviceManagement.DeviceConfigurations;
using ApiSdk.DeviceManagement.DeviceEnrollmentConfigurations;
using ApiSdk.DeviceManagement.DeviceManagementPartners;
using ApiSdk.DeviceManagement.ExchangeConnectors;
using ApiSdk.DeviceManagement.GetEffectivePermissionsWithScope;
using ApiSdk.DeviceManagement.ImportedWindowsAutopilotDeviceIdentities;
using ApiSdk.DeviceManagement.IosUpdateStatuses;
using ApiSdk.DeviceManagement.ManagedDeviceOverview;
using ApiSdk.DeviceManagement.ManagedDevices;
using ApiSdk.DeviceManagement.MobileThreatDefenseConnectors;
using ApiSdk.DeviceManagement.NotificationMessageTemplates;
using ApiSdk.DeviceManagement.RemoteAssistancePartners;
using ApiSdk.DeviceManagement.ResourceOperations;
using ApiSdk.DeviceManagement.RoleAssignments;
using ApiSdk.DeviceManagement.RoleDefinitions;
using ApiSdk.DeviceManagement.SoftwareUpdateStatusSummary;
using ApiSdk.DeviceManagement.TelecomExpenseManagementPartners;
using ApiSdk.DeviceManagement.TermsAndConditions;
using ApiSdk.DeviceManagement.TroubleshootingEvents;
using ApiSdk.DeviceManagement.VerifyWindowsEnrollmentAutoDiscoveryWithDomainName;
using ApiSdk.DeviceManagement.WindowsAutopilotDeviceIdentities;
using ApiSdk.DeviceManagement.WindowsInformationProtectionAppLearningSummaries;
using ApiSdk.DeviceManagement.WindowsInformationProtectionNetworkLearningSummaries;
using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.DeviceManagement {
    /// <summary>Builds and executes requests for operations under \deviceManagement</summary>
    public class DeviceManagementRequestBuilder {
        public ApplePushNotificationCertificateRequestBuilder ApplePushNotificationCertificate { get =>
            new ApplePushNotificationCertificateRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ComplianceManagementPartnersRequestBuilder ComplianceManagementPartners { get =>
            new ComplianceManagementPartnersRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ConditionalAccessSettingsRequestBuilder ConditionalAccessSettings { get =>
            new ConditionalAccessSettingsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DetectedAppsRequestBuilder DetectedApps { get =>
            new DetectedAppsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DeviceCategoriesRequestBuilder DeviceCategories { get =>
            new DeviceCategoriesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DeviceCompliancePoliciesRequestBuilder DeviceCompliancePolicies { get =>
            new DeviceCompliancePoliciesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DeviceCompliancePolicyDeviceStateSummaryRequestBuilder DeviceCompliancePolicyDeviceStateSummary { get =>
            new DeviceCompliancePolicyDeviceStateSummaryRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DeviceCompliancePolicySettingStateSummariesRequestBuilder DeviceCompliancePolicySettingStateSummaries { get =>
            new DeviceCompliancePolicySettingStateSummariesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DeviceConfigurationDeviceStateSummariesRequestBuilder DeviceConfigurationDeviceStateSummaries { get =>
            new DeviceConfigurationDeviceStateSummariesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DeviceConfigurationsRequestBuilder DeviceConfigurations { get =>
            new DeviceConfigurationsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DeviceEnrollmentConfigurationsRequestBuilder DeviceEnrollmentConfigurations { get =>
            new DeviceEnrollmentConfigurationsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DeviceManagementPartnersRequestBuilder DeviceManagementPartners { get =>
            new DeviceManagementPartnersRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ExchangeConnectorsRequestBuilder ExchangeConnectors { get =>
            new ExchangeConnectorsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        public ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder ImportedWindowsAutopilotDeviceIdentities { get =>
            new ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public IosUpdateStatusesRequestBuilder IosUpdateStatuses { get =>
            new IosUpdateStatusesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public ManagedDeviceOverviewRequestBuilder ManagedDeviceOverview { get =>
            new ManagedDeviceOverviewRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ManagedDevicesRequestBuilder ManagedDevices { get =>
            new ManagedDevicesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public MobileThreatDefenseConnectorsRequestBuilder MobileThreatDefenseConnectors { get =>
            new MobileThreatDefenseConnectorsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public NotificationMessageTemplatesRequestBuilder NotificationMessageTemplates { get =>
            new NotificationMessageTemplatesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public RemoteAssistancePartnersRequestBuilder RemoteAssistancePartners { get =>
            new RemoteAssistancePartnersRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ResourceOperationsRequestBuilder ResourceOperations { get =>
            new ResourceOperationsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public RoleAssignmentsRequestBuilder RoleAssignments { get =>
            new RoleAssignmentsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public RoleDefinitionsRequestBuilder RoleDefinitions { get =>
            new RoleDefinitionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public SoftwareUpdateStatusSummaryRequestBuilder SoftwareUpdateStatusSummary { get =>
            new SoftwareUpdateStatusSummaryRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TelecomExpenseManagementPartnersRequestBuilder TelecomExpenseManagementPartners { get =>
            new TelecomExpenseManagementPartnersRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TermsAndConditionsRequestBuilder TermsAndConditions { get =>
            new TermsAndConditionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TroubleshootingEventsRequestBuilder TroubleshootingEvents { get =>
            new TroubleshootingEventsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public WindowsAutopilotDeviceIdentitiesRequestBuilder WindowsAutopilotDeviceIdentities { get =>
            new WindowsAutopilotDeviceIdentitiesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public WindowsInformationProtectionAppLearningSummariesRequestBuilder WindowsInformationProtectionAppLearningSummaries { get =>
            new WindowsInformationProtectionAppLearningSummariesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public WindowsInformationProtectionNetworkLearningSummariesRequestBuilder WindowsInformationProtectionNetworkLearningSummaries { get =>
            new WindowsInformationProtectionNetworkLearningSummariesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new DeviceManagementRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public DeviceManagementRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/deviceManagement";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Get deviceManagement
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
        /// Update deviceManagement
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.DeviceManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// Get deviceManagement
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApiSdk.Models.Microsoft.Graph.DeviceManagement> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<ApiSdk.Models.Microsoft.Graph.DeviceManagement>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.getEffectivePermissions(scope='{scope}')
        /// <param name="scope">Usage: scope={scope}</param>
        /// </summary>
        public GetEffectivePermissionsWithScopeRequestBuilder getEffectivePermissionsWithScope(string scope) {
            if(string.IsNullOrEmpty(scope)) throw new ArgumentNullException(nameof(scope));
            return new GetEffectivePermissionsWithScopeRequestBuilder(CurrentPath + PathSegment , HttpCore, scope, false);
        }
        /// <summary>
        /// Update deviceManagement
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ApiSdk.Models.Microsoft.Graph.DeviceManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.verifyWindowsEnrollmentAutoDiscovery(domainName='{domainName}')
        /// <param name="domainName">Usage: domainName={domainName}</param>
        /// </summary>
        public VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder verifyWindowsEnrollmentAutoDiscoveryWithDomainName(string domainName) {
            if(string.IsNullOrEmpty(domainName)) throw new ArgumentNullException(nameof(domainName));
            return new VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder(CurrentPath + PathSegment , HttpCore, domainName, false);
        }
        /// <summary>Get deviceManagement</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
