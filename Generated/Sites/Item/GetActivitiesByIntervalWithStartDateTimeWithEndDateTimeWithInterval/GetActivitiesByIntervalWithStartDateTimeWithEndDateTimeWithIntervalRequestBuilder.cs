using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Sites.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval {
    /// <summary>Builds and executes requests for operations under \sites\{site-id}\microsoft.graph.getActivitiesByInterval(startDateTime='{startDateTime}',endDateTime='{endDateTime}',interval='{interval}')</summary>
    public class GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder {
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>
        /// Instantiates a new GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="interval">Usage: interval={interval}</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        /// </summary>
        public GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(string currentPath, IRequestAdapter requestAdapter, string startDateTime = default, string endDateTime = default, string interval = default, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "/microsoft.graph.getActivitiesByInterval(startDateTime='{startDateTime}',endDateTime='{endDateTime}',interval='{interval}')";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Invoke function getActivitiesByInterval
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
            };
            requestInfo.SetURI(CurrentPath, PathSegment, IsRawUrl);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Invoke function getActivitiesByInterval
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<IEnumerable<ApiSdk.Sites.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval>> GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            return await RequestAdapter.SendCollectionAsync<ApiSdk.Sites.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval>(requestInfo, responseHandler);
        }
    }
}
