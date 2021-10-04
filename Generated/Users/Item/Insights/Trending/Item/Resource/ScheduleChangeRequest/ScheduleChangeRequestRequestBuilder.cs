using ApiSdk.Users.Item.Insights.Trending.Item.Resource.ScheduleChangeRequest.Approve;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.ScheduleChangeRequest.Decline;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.Insights.Trending.Item.Resource.ScheduleChangeRequest {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.scheduleChangeRequest</summary>
    public class ScheduleChangeRequestRequestBuilder {
        public ApproveRequestBuilder Approve { get =>
            new ApproveRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DeclineRequestBuilder Decline { get =>
            new DeclineRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>
        /// Instantiates a new ScheduleChangeRequestRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public ScheduleChangeRequestRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/microsoft.graph.scheduleChangeRequest";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
    }
}
