using GraphServiceClient.Me.Insights.Used.Resource.Microsoft.Graph.MobileAppContentFile.Microsoft.Graph.Commit;
using GraphServiceClient.Me.Insights.Used.Resource.Microsoft.Graph.MobileAppContentFile.Microsoft.Graph.RenewUpload;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.Me.Insights.Used.Resource.Microsoft.Graph.MobileAppContentFile {
    /// <summary>Builds and executes requests for operations under \me\insights\used\{usedInsight-id}\resource\microsoft.graph.mobileAppContentFile</summary>
    public class Microsoft.graph.mobileAppContentFileRequestBuilder {
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public Microsoft.graph.commitRequestBuilder Microsoft.graph.commit { get =>
            new Microsoft.graph.commitRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.renewUploadRequestBuilder Microsoft.graph.renewUpload { get =>
            new Microsoft.graph.renewUploadRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.mobileAppContentFileRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public Microsoft.graph.mobileAppContentFileRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/microsoft.graph.mobileAppContentFile";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
    }
}
