using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.AcceptRecommendations;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.ApplyDecisions;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.BatchRecordDecisions;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Decisions;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.ResetDecisions;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.SendReminder;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stop;
using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item {
    /// <summary>Builds and executes requests for operations under \identityGovernance\accessReviews\definitions\{accessReviewScheduleDefinition-id}\instances\{accessReviewInstance-id}</summary>
    public class AccessReviewInstanceRequestBuilder {
        public AcceptRecommendationsRequestBuilder AcceptRecommendations { get =>
            new AcceptRecommendationsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ApplyDecisionsRequestBuilder ApplyDecisions { get =>
            new ApplyDecisionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public BatchRecordDecisionsRequestBuilder BatchRecordDecisions { get =>
            new BatchRecordDecisionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DecisionsRequestBuilder Decisions { get =>
            new DecisionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public ResetDecisionsRequestBuilder ResetDecisions { get =>
            new ResetDecisionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public SendReminderRequestBuilder SendReminder { get =>
            new SendReminderRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public StopRequestBuilder Stop { get =>
            new StopRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new AccessReviewInstanceRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public AccessReviewInstanceRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
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
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
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
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(AccessReviewInstance body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<AccessReviewInstance> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<AccessReviewInstance>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(AccessReviewInstance body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
