using GraphServiceClient.Me.Insights.Trending.Resource.Microsoft.Graph.WorkbookRange.Microsoft.Graph.Clear;
using GraphServiceClient.Me.Insights.Trending.Resource.Microsoft.Graph.WorkbookRange.Microsoft.Graph.Delete;
using GraphServiceClient.Me.Insights.Trending.Resource.Microsoft.Graph.WorkbookRange.Microsoft.Graph.Insert;
using GraphServiceClient.Me.Insights.Trending.Resource.Microsoft.Graph.WorkbookRange.Microsoft.Graph.Merge;
using GraphServiceClient.Me.Insights.Trending.Resource.Microsoft.Graph.WorkbookRange.Microsoft.Graph.Unmerge;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.Me.Insights.Trending.Resource.Microsoft.Graph.WorkbookRange {
    /// <summary>Builds and executes requests for operations under \me\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange</summary>
    public class Microsoft.graph.workbookRangeRequestBuilder {
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public Microsoft.graph.clearRequestBuilder Microsoft.graph.clear { get =>
            new Microsoft.graph.clearRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.deleteRequestBuilder Microsoft.graph.delete { get =>
            new Microsoft.graph.deleteRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.insertRequestBuilder Microsoft.graph.insert { get =>
            new Microsoft.graph.insertRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.mergeRequestBuilder Microsoft.graph.merge { get =>
            new Microsoft.graph.mergeRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.unmergeRequestBuilder Microsoft.graph.unmerge { get =>
            new Microsoft.graph.unmergeRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.workbookRangeRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public Microsoft.graph.workbookRangeRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/microsoft.graph.workbookRange";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
    }
}
