using GraphServiceClient.Users.Insights.Used.Resource.Microsoft.Graph.ScheduleChangeRequest.Microsoft.Graph.Approve;
using GraphServiceClient.Users.Insights.Used.Resource.Microsoft.Graph.ScheduleChangeRequest.Microsoft.Graph.Decline;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.Users.Insights.Used.Resource.Microsoft.Graph.ScheduleChangeRequest {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\used\{usedInsight-id}\resource\microsoft.graph.scheduleChangeRequest</summary>
    public class Microsoft.graph.scheduleChangeRequestRequestBuilder {
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public Microsoft.graph.approveRequestBuilder Microsoft.graph.approve { get =>
            new Microsoft.graph.approveRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.declineRequestBuilder Microsoft.graph.decline { get =>
            new Microsoft.graph.declineRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.scheduleChangeRequestRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public Microsoft.graph.scheduleChangeRequestRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/microsoft.graph.scheduleChangeRequest";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
    }
}
