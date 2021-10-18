using ApiSdk.Users.Item.Insights.Trending.Item.Resource.PrintJob.Abort;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.PrintJob.Cancel;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.PrintJob.Redirect;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.PrintJob.Start;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.Insights.Trending.Item.Resource.PrintJob {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.printJob</summary>
    public class PrintJobRequestBuilder {
        public AbortRequestBuilder Abort { get =>
            new AbortRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public CancelRequestBuilder Cancel { get =>
            new CancelRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public RedirectRequestBuilder Redirect { get =>
            new RedirectRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public StartRequestBuilder Start { get =>
            new StartRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Instantiates a new PrintJobRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public PrintJobRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "/microsoft.graph.printJob";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
    }
}
