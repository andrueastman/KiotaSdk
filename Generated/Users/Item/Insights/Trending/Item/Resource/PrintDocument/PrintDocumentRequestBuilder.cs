using ApiSdk.Users.Item.Insights.Trending.Item.Resource.PrintDocument.CreateUploadSession;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.Insights.Trending.Item.Resource.PrintDocument {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.printDocument</summary>
    public class PrintDocumentRequestBuilder {
        public CreateUploadSessionRequestBuilder CreateUploadSession { get =>
            new CreateUploadSessionRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>
        /// Instantiates a new PrintDocumentRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public PrintDocumentRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "/microsoft.graph.printDocument";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
    }
}
