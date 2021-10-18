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
            new ApplePushNotificationCertificateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ComplianceManagementPartnersRequestBuilder ComplianceManagementPartners { get =>
            new ComplianceManagementPartnersRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ConditionalAccessSettingsRequestBuilder ConditionalAccessSettings { get =>
            new ConditionalAccessSettingsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DetectedAppsRequestBuilder DetectedApps { get =>
            new DetectedAppsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DeviceCategoriesRequestBuilder DeviceCategories { get =>
            new DeviceCategoriesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DeviceCompliancePoliciesRequestBuilder DeviceCompliancePolicies { get =>
            new DeviceCompliancePoliciesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DeviceCompliancePolicyDeviceStateSummaryRequestBuilder DeviceCompliancePolicyDeviceStateSummary { get =>
            new DeviceCompliancePolicyDeviceStateSummaryRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DeviceCompliancePolicySettingStateSummariesRequestBuilder DeviceCompliancePolicySettingStateSummaries { get =>
            new DeviceCompliancePolicySettingStateSummariesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DeviceConfigurationDeviceStateSummariesRequestBuilder DeviceConfigurationDeviceStateSummaries { get =>
            new DeviceConfigurationDeviceStateSummariesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DeviceConfigurationsRequestBuilder DeviceConfigurations { get =>
            new DeviceConfigurationsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DeviceEnrollmentConfigurationsRequestBuilder DeviceEnrollmentConfigurations { get =>
            new DeviceEnrollmentConfigurationsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DeviceManagementPartnersRequestBuilder DeviceManagementPartners { get =>
            new DeviceManagementPartnersRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ExchangeConnectorsRequestBuilder ExchangeConnectors { get =>
            new ExchangeConnectorsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder ImportedWindowsAutopilotDeviceIdentities { get =>
            new ImportedWindowsAutopilotDeviceIdentitiesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public IosUpdateStatusesRequestBuilder IosUpdateStatuses { get =>
            new IosUpdateStatusesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public ManagedDeviceOverviewRequestBuilder ManagedDeviceOverview { get =>
            new ManagedDeviceOverviewRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ManagedDevicesRequestBuilder ManagedDevices { get =>
            new ManagedDevicesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MobileThreatDefenseConnectorsRequestBuilder MobileThreatDefenseConnectors { get =>
            new MobileThreatDefenseConnectorsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public NotificationMessageTemplatesRequestBuilder NotificationMessageTemplates { get =>
            new NotificationMessageTemplatesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public RemoteAssistancePartnersRequestBuilder RemoteAssistancePartners { get =>
            new RemoteAssistancePartnersRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public ResourceOperationsRequestBuilder ResourceOperations { get =>
            new ResourceOperationsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RoleAssignmentsRequestBuilder RoleAssignments { get =>
            new RoleAssignmentsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public RoleDefinitionsRequestBuilder RoleDefinitions { get =>
            new RoleDefinitionsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SoftwareUpdateStatusSummaryRequestBuilder SoftwareUpdateStatusSummary { get =>
            new SoftwareUpdateStatusSummaryRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TelecomExpenseManagementPartnersRequestBuilder TelecomExpenseManagementPartners { get =>
            new TelecomExpenseManagementPartnersRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TermsAndConditionsRequestBuilder TermsAndConditions { get =>
            new TermsAndConditionsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TroubleshootingEventsRequestBuilder TroubleshootingEvents { get =>
            new TroubleshootingEventsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WindowsAutopilotDeviceIdentitiesRequestBuilder WindowsAutopilotDeviceIdentities { get =>
            new WindowsAutopilotDeviceIdentitiesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WindowsInformationProtectionAppLearningSummariesRequestBuilder WindowsInformationProtectionAppLearningSummaries { get =>
            new WindowsInformationProtectionAppLearningSummariesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public WindowsInformationProtectionNetworkLearningSummariesRequestBuilder WindowsInformationProtectionNetworkLearningSummaries { get =>
            new WindowsInformationProtectionNetworkLearningSummariesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Instantiates a new DeviceManagementRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public DeviceManagementRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "/deviceManagement";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Get deviceManagement
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
        /// Update deviceManagement
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.DeviceManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Get deviceManagement
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApiSdk.Models.Microsoft.Graph.DeviceManagement> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ApiSdk.Models.Microsoft.Graph.DeviceManagement>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.getEffectivePermissions(scope='{scope}')
        /// <param name="scope">Usage: scope={scope}</param>
        /// </summary>
        public GetEffectivePermissionsWithScopeRequestBuilder GetEffectivePermissionsWithScope(string scope) {
            if(string.IsNullOrEmpty(scope)) throw new ArgumentNullException(nameof(scope));
            return new GetEffectivePermissionsWithScopeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, scope, false);
        }
        /// <summary>
        /// Update deviceManagement
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ApiSdk.Models.Microsoft.Graph.DeviceManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\microsoft.graph.verifyWindowsEnrollmentAutoDiscovery(domainName='{domainName}')
        /// <param name="domainName">Usage: domainName={domainName}</param>
        /// </summary>
        public VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder VerifyWindowsEnrollmentAutoDiscoveryWithDomainName(string domainName) {
            if(string.IsNullOrEmpty(domainName)) throw new ArgumentNullException(nameof(domainName));
            return new VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder(CurrentPath + PathSegment , RequestAdapter, domainName, false);
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
