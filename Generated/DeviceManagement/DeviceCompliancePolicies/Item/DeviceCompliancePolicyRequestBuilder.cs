using GraphServiceClient.DeviceManagement.DeviceCompliancePolicies.Assignments;
using GraphServiceClient.DeviceManagement.DeviceCompliancePolicies.DeviceSettingStateSummaries;
using GraphServiceClient.DeviceManagement.DeviceCompliancePolicies.DeviceStatuses;
using GraphServiceClient.DeviceManagement.DeviceCompliancePolicies.DeviceStatusOverview;
using GraphServiceClient.DeviceManagement.DeviceCompliancePolicies.Microsoft.Graph.Assign;
using GraphServiceClient.DeviceManagement.DeviceCompliancePolicies.Microsoft.Graph.ScheduleActionsForRules;
using GraphServiceClient.DeviceManagement.DeviceCompliancePolicies.ScheduledActionsForRule;
using GraphServiceClient.DeviceManagement.DeviceCompliancePolicies.UserStatuses;
using GraphServiceClient.DeviceManagement.DeviceCompliancePolicies.UserStatusOverview;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.DeviceManagement.DeviceCompliancePolicies.Item {
    /// <summary>Builds and executes requests for operations under \deviceManagement\deviceCompliancePolicies\{deviceCompliancePolicy-id}</summary>
    public class DeviceCompliancePolicyRequestBuilder {
        public AssignmentsRequestBuilder Assignments { get =>
            new AssignmentsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DeviceSettingStateSummariesRequestBuilder DeviceSettingStateSummaries { get =>
            new DeviceSettingStateSummariesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DeviceStatusesRequestBuilder DeviceStatuses { get =>
            new DeviceStatusesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DeviceStatusOverviewRequestBuilder DeviceStatusOverview { get =>
            new DeviceStatusOverviewRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public Microsoft.graph.assignRequestBuilder Microsoft.graph.assign { get =>
            new Microsoft.graph.assignRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.scheduleActionsForRulesRequestBuilder Microsoft.graph.scheduleActionsForRules { get =>
            new Microsoft.graph.scheduleActionsForRulesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public ScheduledActionsForRuleRequestBuilder ScheduledActionsForRule { get =>
            new ScheduledActionsForRuleRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public UserStatusesRequestBuilder UserStatuses { get =>
            new UserStatusesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public UserStatusOverviewRequestBuilder UserStatusOverview { get =>
            new UserStatusOverviewRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new DeviceCompliancePolicyRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public DeviceCompliancePolicyRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// The device compliance policies.
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
        /// The device compliance policies.
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
        /// The device compliance policies.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(DeviceCompliancePolicy body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// The device compliance policies.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// The device compliance policies.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<DeviceCompliancePolicy> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<DeviceCompliancePolicy>(requestInfo, responseHandler);
        }
        /// <summary>
        /// The device compliance policies.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(DeviceCompliancePolicy body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>The device compliance policies.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
