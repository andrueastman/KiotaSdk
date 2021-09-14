using GraphServiceClient.Users.Insights.Shared.Resource.Microsoft.Graph.PrintJob.Microsoft.Graph.Abort;
using GraphServiceClient.Users.Insights.Shared.Resource.Microsoft.Graph.PrintJob.Microsoft.Graph.Cancel;
using GraphServiceClient.Users.Insights.Shared.Resource.Microsoft.Graph.PrintJob.Microsoft.Graph.Redirect;
using GraphServiceClient.Users.Insights.Shared.Resource.Microsoft.Graph.PrintJob.Microsoft.Graph.Start;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.Users.Insights.Shared.Resource.Microsoft.Graph.PrintJob {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\shared\{sharedInsight-id}\resource\microsoft.graph.printJob</summary>
    public class Microsoft.graph.printJobRequestBuilder {
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public Microsoft.graph.abortRequestBuilder Microsoft.graph.abort { get =>
            new Microsoft.graph.abortRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.cancelRequestBuilder Microsoft.graph.cancel { get =>
            new Microsoft.graph.cancelRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.redirectRequestBuilder Microsoft.graph.redirect { get =>
            new Microsoft.graph.redirectRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.startRequestBuilder Microsoft.graph.start { get =>
            new Microsoft.graph.startRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.printJobRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public Microsoft.graph.printJobRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/microsoft.graph.printJob";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
    }
}
