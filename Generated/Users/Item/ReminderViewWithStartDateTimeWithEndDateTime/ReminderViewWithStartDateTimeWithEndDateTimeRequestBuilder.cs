using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.ReminderViewWithStartDateTimeWithEndDateTime {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\microsoft.graph.reminderView(StartDateTime='{StartDateTime}',EndDateTime='{EndDateTime}')</summary>
    public class ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder {
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>
        /// Instantiates a new ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="EndDateTime">Usage: EndDateTime={EndDateTime}</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="StartDateTime">Usage: StartDateTime={StartDateTime}</param>
        /// </summary>
        public ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder(string currentPath, IHttpCore httpCore, string StartDateTime = default, string EndDateTime = default, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/microsoft.graph.reminderView(StartDateTime='{StartDateTime}',EndDateTime='{EndDateTime}')";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Invoke function reminderView
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
            };
            requestInfo.SetURI(CurrentPath, PathSegment, IsRawUrl);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddMiddlewareOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Invoke function reminderView
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<IEnumerable<ApiSdk.Users.Item.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTime>> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await HttpCore.SendCollectionAsync<ApiSdk.Users.Item.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTime>(requestInfo, responseHandler);
        }
    }
}
