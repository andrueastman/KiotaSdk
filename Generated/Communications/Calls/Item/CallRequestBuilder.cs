using GraphServiceClient.Communications.Calls.Microsoft.Graph.Answer;
using GraphServiceClient.Communications.Calls.Microsoft.Graph.CancelMediaProcessing;
using GraphServiceClient.Communications.Calls.Microsoft.Graph.ChangeScreenSharingRole;
using GraphServiceClient.Communications.Calls.Microsoft.Graph.KeepAlive;
using GraphServiceClient.Communications.Calls.Microsoft.Graph.Mute;
using GraphServiceClient.Communications.Calls.Microsoft.Graph.PlayPrompt;
using GraphServiceClient.Communications.Calls.Microsoft.Graph.RecordResponse;
using GraphServiceClient.Communications.Calls.Microsoft.Graph.Redirect;
using GraphServiceClient.Communications.Calls.Microsoft.Graph.Reject;
using GraphServiceClient.Communications.Calls.Microsoft.Graph.SubscribeToTone;
using GraphServiceClient.Communications.Calls.Microsoft.Graph.Transfer;
using GraphServiceClient.Communications.Calls.Microsoft.Graph.Unmute;
using GraphServiceClient.Communications.Calls.Microsoft.Graph.UpdateRecordingStatus;
using GraphServiceClient.Communications.Calls.Operations;
using GraphServiceClient.Communications.Calls.Participants;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.Communications.Calls.Item {
    /// <summary>Builds and executes requests for operations under \communications\calls\{call-id}</summary>
    public class CallRequestBuilder {
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public Microsoft.graph.answerRequestBuilder Microsoft.graph.answer { get =>
            new Microsoft.graph.answerRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.cancelMediaProcessingRequestBuilder Microsoft.graph.cancelMediaProcessing { get =>
            new Microsoft.graph.cancelMediaProcessingRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.changeScreenSharingRoleRequestBuilder Microsoft.graph.changeScreenSharingRole { get =>
            new Microsoft.graph.changeScreenSharingRoleRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.keepAliveRequestBuilder Microsoft.graph.keepAlive { get =>
            new Microsoft.graph.keepAliveRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.muteRequestBuilder Microsoft.graph.mute { get =>
            new Microsoft.graph.muteRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.playPromptRequestBuilder Microsoft.graph.playPrompt { get =>
            new Microsoft.graph.playPromptRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.recordResponseRequestBuilder Microsoft.graph.recordResponse { get =>
            new Microsoft.graph.recordResponseRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.redirectRequestBuilder Microsoft.graph.redirect { get =>
            new Microsoft.graph.redirectRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.rejectRequestBuilder Microsoft.graph.reject { get =>
            new Microsoft.graph.rejectRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.subscribeToToneRequestBuilder Microsoft.graph.subscribeToTone { get =>
            new Microsoft.graph.subscribeToToneRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.transferRequestBuilder Microsoft.graph.transfer { get =>
            new Microsoft.graph.transferRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.unmuteRequestBuilder Microsoft.graph.unmute { get =>
            new Microsoft.graph.unmuteRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.updateRecordingStatusRequestBuilder Microsoft.graph.updateRecordingStatus { get =>
            new Microsoft.graph.updateRecordingStatusRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OperationsRequestBuilder Operations { get =>
            new OperationsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ParticipantsRequestBuilder Participants { get =>
            new ParticipantsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>
        /// Instantiates a new CallRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public CallRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Delete navigation property calls for communications
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
        /// Get calls from communications
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
        /// Update the navigation property calls in communications
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Call body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// Delete navigation property calls for communications
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// Get calls from communications
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Call> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<Call>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Update the navigation property calls in communications
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Call body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>Get calls from communications</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
