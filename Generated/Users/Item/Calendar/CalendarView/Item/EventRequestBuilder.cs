using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Users.Item.Calendar.CalendarView.Item.Accept;
using ApiSdk.Users.Item.Calendar.CalendarView.Item.Attachments;
using ApiSdk.Users.Item.Calendar.CalendarView.Item.Calendar;
using ApiSdk.Users.Item.Calendar.CalendarView.Item.Cancel;
using ApiSdk.Users.Item.Calendar.CalendarView.Item.Decline;
using ApiSdk.Users.Item.Calendar.CalendarView.Item.DismissReminder;
using ApiSdk.Users.Item.Calendar.CalendarView.Item.Extensions;
using ApiSdk.Users.Item.Calendar.CalendarView.Item.Forward;
using ApiSdk.Users.Item.Calendar.CalendarView.Item.Instances;
using ApiSdk.Users.Item.Calendar.CalendarView.Item.MultiValueExtendedProperties;
using ApiSdk.Users.Item.Calendar.CalendarView.Item.SingleValueExtendedProperties;
using ApiSdk.Users.Item.Calendar.CalendarView.Item.SnoozeReminder;
using ApiSdk.Users.Item.Calendar.CalendarView.Item.TentativelyAccept;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.Calendar.CalendarView.Item {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\calendar\calendarView\{event-id}</summary>
    public class EventRequestBuilder {
        public AcceptRequestBuilder Accept { get =>
            new AcceptRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AttachmentsRequestBuilder Attachments { get =>
            new AttachmentsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CalendarRequestBuilder Calendar { get =>
            new CalendarRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CancelRequestBuilder Cancel { get =>
            new CancelRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DeclineRequestBuilder Decline { get =>
            new DeclineRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DismissReminderRequestBuilder DismissReminder { get =>
            new DismissReminderRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ExtensionsRequestBuilder Extensions { get =>
            new ExtensionsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public ForwardRequestBuilder Forward { get =>
            new ForwardRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public InstancesRequestBuilder Instances { get =>
            new InstancesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public MultiValueExtendedPropertiesRequestBuilder MultiValueExtendedProperties { get =>
            new MultiValueExtendedPropertiesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public SingleValueExtendedPropertiesRequestBuilder SingleValueExtendedProperties { get =>
            new SingleValueExtendedPropertiesRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public SnoozeReminderRequestBuilder SnoozeReminder { get =>
            new SnoozeReminderRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public TentativelyAcceptRequestBuilder TentativelyAccept { get =>
            new TentativelyAcceptRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Instantiates a new EventRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public EventRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// The calendar view for the calendar. Navigation property. Read-only.
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
        /// The calendar view for the calendar. Navigation property. Read-only.
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
        /// The calendar view for the calendar. Navigation property. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Event body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// The calendar view for the calendar. Navigation property. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// The calendar view for the calendar. Navigation property. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Event> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<Event>(requestInfo, responseHandler);
        }
        /// <summary>
        /// The calendar view for the calendar. Navigation property. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Event body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>The calendar view for the calendar. Navigation property. Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>The end date and time of the time range, represented in ISO 8601 format. For example, 2019-11-08T20:00:00-08:00</summary>
            public string EndDateTime { get; set; }
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
            /// <summary>The start date and time of the time range, represented in ISO 8601 format. For example, 2019-11-08T19:00:00-08:00</summary>
            public string StartDateTime { get; set; }
        }
    }
}
