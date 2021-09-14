using GraphServiceClient.Me.Messages.Attachments;
using GraphServiceClient.Me.Messages.Content;
using GraphServiceClient.Me.Messages.Extensions;
using GraphServiceClient.Me.Messages.Microsoft.Graph.CalendarSharingMessage;
using GraphServiceClient.Me.Messages.Microsoft.Graph.Copy;
using GraphServiceClient.Me.Messages.Microsoft.Graph.CreateForward;
using GraphServiceClient.Me.Messages.Microsoft.Graph.CreateReply;
using GraphServiceClient.Me.Messages.Microsoft.Graph.CreateReplyAll;
using GraphServiceClient.Me.Messages.Microsoft.Graph.Forward;
using GraphServiceClient.Me.Messages.Microsoft.Graph.Move;
using GraphServiceClient.Me.Messages.Microsoft.Graph.Reply;
using GraphServiceClient.Me.Messages.Microsoft.Graph.ReplyAll;
using GraphServiceClient.Me.Messages.Microsoft.Graph.Send;
using GraphServiceClient.Me.Messages.MultiValueExtendedProperties;
using GraphServiceClient.Me.Messages.SingleValueExtendedProperties;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.Me.Messages.Item {
    /// <summary>Builds and executes requests for operations under \me\messages\{message-id}</summary>
    public class MessageRequestBuilder {
        public AttachmentsRequestBuilder Attachments { get =>
            new AttachmentsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ContentRequestBuilder Content { get =>
            new ContentRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public ExtensionsRequestBuilder Extensions { get =>
            new ExtensionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public Microsoft.graph.calendarSharingMessageRequestBuilder Microsoft.graph.calendarSharingMessage { get =>
            new Microsoft.graph.calendarSharingMessageRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.copyRequestBuilder Microsoft.graph.copy { get =>
            new Microsoft.graph.copyRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.createForwardRequestBuilder Microsoft.graph.createForward { get =>
            new Microsoft.graph.createForwardRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.createReplyRequestBuilder Microsoft.graph.createReply { get =>
            new Microsoft.graph.createReplyRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.createReplyAllRequestBuilder Microsoft.graph.createReplyAll { get =>
            new Microsoft.graph.createReplyAllRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.forwardRequestBuilder Microsoft.graph.forward { get =>
            new Microsoft.graph.forwardRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.moveRequestBuilder Microsoft.graph.move { get =>
            new Microsoft.graph.moveRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.replyRequestBuilder Microsoft.graph.reply { get =>
            new Microsoft.graph.replyRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.replyAllRequestBuilder Microsoft.graph.replyAll { get =>
            new Microsoft.graph.replyAllRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.sendRequestBuilder Microsoft.graph.send { get =>
            new Microsoft.graph.sendRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public MultiValueExtendedPropertiesRequestBuilder MultiValueExtendedProperties { get =>
            new MultiValueExtendedPropertiesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public SingleValueExtendedPropertiesRequestBuilder SingleValueExtendedProperties { get =>
            new SingleValueExtendedPropertiesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new MessageRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public MessageRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
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
        /// The messages in a mailbox or folder. Read-only. Nullable.
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
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Message body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Message> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<Message>(requestInfo, responseHandler);
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Message body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>The messages in a mailbox or folder. Read-only. Nullable.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
