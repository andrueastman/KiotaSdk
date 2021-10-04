using ApiSdk.Communications.Calls.Item.Answer;
using ApiSdk.Communications.Calls.Item.CancelMediaProcessing;
using ApiSdk.Communications.Calls.Item.ChangeScreenSharingRole;
using ApiSdk.Communications.Calls.Item.KeepAlive;
using ApiSdk.Communications.Calls.Item.Mute;
using ApiSdk.Communications.Calls.Item.Operations;
using ApiSdk.Communications.Calls.Item.Participants;
using ApiSdk.Communications.Calls.Item.PlayPrompt;
using ApiSdk.Communications.Calls.Item.RecordResponse;
using ApiSdk.Communications.Calls.Item.Redirect;
using ApiSdk.Communications.Calls.Item.Reject;
using ApiSdk.Communications.Calls.Item.SubscribeToTone;
using ApiSdk.Communications.Calls.Item.Transfer;
using ApiSdk.Communications.Calls.Item.Unmute;
using ApiSdk.Communications.Calls.Item.UpdateRecordingStatus;
using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Communications.Calls.Item {
    /// <summary>Builds and executes requests for operations under \communications\calls\{call-id}</summary>
    public class CallRequestBuilder {
        public AnswerRequestBuilder Answer { get =>
            new AnswerRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CancelMediaProcessingRequestBuilder CancelMediaProcessing { get =>
            new CancelMediaProcessingRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ChangeScreenSharingRoleRequestBuilder ChangeScreenSharingRole { get =>
            new ChangeScreenSharingRoleRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public KeepAliveRequestBuilder KeepAlive { get =>
            new KeepAliveRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public MuteRequestBuilder Mute { get =>
            new MuteRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public OperationsRequestBuilder Operations { get =>
            new OperationsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ParticipantsRequestBuilder Participants { get =>
            new ParticipantsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public PlayPromptRequestBuilder PlayPrompt { get =>
            new PlayPromptRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public RecordResponseRequestBuilder RecordResponse { get =>
            new RecordResponseRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public RedirectRequestBuilder Redirect { get =>
            new RedirectRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public RejectRequestBuilder Reject { get =>
            new RejectRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public SubscribeToToneRequestBuilder SubscribeToTone { get =>
            new SubscribeToToneRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TransferRequestBuilder Transfer { get =>
            new TransferRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public UnmuteRequestBuilder Unmute { get =>
            new UnmuteRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public UpdateRecordingStatusRequestBuilder UpdateRecordingStatus { get =>
            new UpdateRecordingStatusRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
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
