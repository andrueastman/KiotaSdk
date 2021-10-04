using ApiSdk.Users.Item.Insights.Used.Item.Resource.MobileAppContentFile.Commit;
using ApiSdk.Users.Item.Insights.Used.Item.Resource.MobileAppContentFile.RenewUpload;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.Insights.Used.Item.Resource.MobileAppContentFile {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\used\{usedInsight-id}\resource\microsoft.graph.mobileAppContentFile</summary>
    public class MobileAppContentFileRequestBuilder {
        public CommitRequestBuilder Commit { get =>
            new CommitRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public RenewUploadRequestBuilder RenewUpload { get =>
            new RenewUploadRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new MobileAppContentFileRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public MobileAppContentFileRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/microsoft.graph.mobileAppContentFile";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
    }
}
