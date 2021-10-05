using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Teams.Item.Schedule.OfferShiftRequests;
using ApiSdk.Teams.Item.Schedule.OpenShiftChangeRequests;
using ApiSdk.Teams.Item.Schedule.OpenShifts;
using ApiSdk.Teams.Item.Schedule.SchedulingGroups;
using ApiSdk.Teams.Item.Schedule.Share;
using ApiSdk.Teams.Item.Schedule.Shifts;
using ApiSdk.Teams.Item.Schedule.SwapShiftsChangeRequests;
using ApiSdk.Teams.Item.Schedule.TimeOffReasons;
using ApiSdk.Teams.Item.Schedule.TimeOffRequests;
using ApiSdk.Teams.Item.Schedule.TimesOff;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Teams.Item.Schedule {
    /// <summary>Builds and executes requests for operations under \teams\{team-id}\schedule</summary>
    public class ScheduleRequestBuilder {
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public OfferShiftRequestsRequestBuilder OfferShiftRequests { get =>
            new OfferShiftRequestsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OpenShiftChangeRequestsRequestBuilder OpenShiftChangeRequests { get =>
            new OpenShiftChangeRequestsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OpenShiftsRequestBuilder OpenShifts { get =>
            new OpenShiftsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public SchedulingGroupsRequestBuilder SchedulingGroups { get =>
            new SchedulingGroupsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ShareRequestBuilder Share { get =>
            new ShareRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ShiftsRequestBuilder Shifts { get =>
            new ShiftsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public SwapShiftsChangeRequestsRequestBuilder SwapShiftsChangeRequests { get =>
            new SwapShiftsChangeRequestsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TimeOffReasonsRequestBuilder TimeOffReasons { get =>
            new TimeOffReasonsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TimeOffRequestsRequestBuilder TimeOffRequests { get =>
            new TimeOffRequestsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TimesOffRequestBuilder TimesOff { get =>
            new TimesOffRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new ScheduleRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public ScheduleRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/schedule";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// The schedule of shifts for this team.
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
        /// The schedule of shifts for this team.
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
        /// The schedule of shifts for this team.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ApiSdk.Models.Microsoft.Graph.Schedule body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// The schedule of shifts for this team.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// The schedule of shifts for this team.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ApiSdk.Models.Microsoft.Graph.Schedule> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<ApiSdk.Models.Microsoft.Graph.Schedule>(requestInfo, responseHandler);
        }
        /// <summary>
        /// The schedule of shifts for this team.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ApiSdk.Models.Microsoft.Graph.Schedule body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>The schedule of shifts for this team.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}