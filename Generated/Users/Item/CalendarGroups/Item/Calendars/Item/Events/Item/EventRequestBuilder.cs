using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item.Accept;
using ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item.Attachments;
using ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item.Calendar;
using ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item.Cancel;
using ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item.Decline;
using ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item.DismissReminder;
using ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item.Extensions;
using ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item.Forward;
using ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item.Instances;
using ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item.MultiValueExtendedProperties;
using ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item.SingleValueExtendedProperties;
using ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item.SnoozeReminder;
using ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item.TentativelyAccept;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\calendarGroups\{calendarGroup-id}\calendars\{calendar-id}\events\{event-id}</summary>
    public class EventRequestBuilder {
        public AcceptRequestBuilder Accept { get =>
            new AcceptRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public AttachmentsRequestBuilder Attachments { get =>
            new AttachmentsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CalendarRequestBuilder Calendar { get =>
            new CalendarRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CancelRequestBuilder Cancel { get =>
            new CancelRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DeclineRequestBuilder Decline { get =>
            new DeclineRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DismissReminderRequestBuilder DismissReminder { get =>
            new DismissReminderRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ExtensionsRequestBuilder Extensions { get =>
            new ExtensionsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ForwardRequestBuilder Forward { get =>
            new ForwardRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        public InstancesRequestBuilder Instances { get =>
            new InstancesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public MultiValueExtendedPropertiesRequestBuilder MultiValueExtendedProperties { get =>
            new MultiValueExtendedPropertiesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public SingleValueExtendedPropertiesRequestBuilder SingleValueExtendedProperties { get =>
            new SingleValueExtendedPropertiesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public SnoozeReminderRequestBuilder SnoozeReminder { get =>
            new SnoozeReminderRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public TentativelyAcceptRequestBuilder TentativelyAccept { get =>
            new TentativelyAcceptRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new EventRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public EventRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// The events in the calendar. Navigation property. Read-only.
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
        /// The events in the calendar. Navigation property. Read-only.
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
        /// The events in the calendar. Navigation property. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Event body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// The events in the calendar. Navigation property. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// The events in the calendar. Navigation property. Read-only.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Event> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<Event>(requestInfo, responseHandler);
        }
        /// <summary>
        /// The events in the calendar. Navigation property. Read-only.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Event body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>The events in the calendar. Navigation property. Read-only.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
