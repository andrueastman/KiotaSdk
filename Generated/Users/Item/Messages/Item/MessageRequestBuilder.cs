using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Users.Item.Messages.Item.Attachments;
using ApiSdk.Users.Item.Messages.Item.CalendarSharingMessage;
using ApiSdk.Users.Item.Messages.Item.Copy;
using ApiSdk.Users.Item.Messages.Item.CreateForward;
using ApiSdk.Users.Item.Messages.Item.CreateReply;
using ApiSdk.Users.Item.Messages.Item.CreateReplyAll;
using ApiSdk.Users.Item.Messages.Item.Extensions;
using ApiSdk.Users.Item.Messages.Item.Forward;
using ApiSdk.Users.Item.Messages.Item.Move;
using ApiSdk.Users.Item.Messages.Item.MultiValueExtendedProperties;
using ApiSdk.Users.Item.Messages.Item.Reply;
using ApiSdk.Users.Item.Messages.Item.ReplyAll;
using ApiSdk.Users.Item.Messages.Item.Send;
using ApiSdk.Users.Item.Messages.Item.SingleValueExtendedProperties;
using ApiSdk.Users.Item.Messages.Item.Value;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.Messages.Item {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\messages\{message-id}</summary>
    public class MessageRequestBuilder {
        public AttachmentsRequestBuilder Attachments { get =>
            new AttachmentsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CalendarSharingMessageRequestBuilder CalendarSharingMessage { get =>
            new CalendarSharingMessageRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ContentRequestBuilder Content { get =>
            new ContentRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CopyRequestBuilder Copy { get =>
            new CopyRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CreateForwardRequestBuilder CreateForward { get =>
            new CreateForwardRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CreateReplyRequestBuilder CreateReply { get =>
            new CreateReplyRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CreateReplyAllRequestBuilder CreateReplyAll { get =>
            new CreateReplyAllRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public ExtensionsRequestBuilder Extensions { get =>
            new ExtensionsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ForwardRequestBuilder Forward { get =>
            new ForwardRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public MoveRequestBuilder Move { get =>
            new MoveRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MultiValueExtendedPropertiesRequestBuilder MultiValueExtendedProperties { get =>
            new MultiValueExtendedPropertiesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public ReplyRequestBuilder Reply { get =>
            new ReplyRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ReplyAllRequestBuilder ReplyAll { get =>
            new ReplyAllRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public SendRequestBuilder Send { get =>
            new SendRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SingleValueExtendedPropertiesRequestBuilder SingleValueExtendedProperties { get =>
            new SingleValueExtendedPropertiesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Instantiates a new MessageRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public MessageRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.DELETE,
            };
            requestInfo.SetURI(CurrentPath, PathSegment, IsRawUrl);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
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
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Message body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Message> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<Message>(requestInfo, responseHandler);
        }
        /// <summary>
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Message body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
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
