using GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.WorkbookRangeFormat.Microsoft.Graph.AutofitColumns;
using GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.WorkbookRangeFormat.Microsoft.Graph.AutofitRows;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.WorkbookRangeFormat {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\shared\{sharedInsight-id}\lastSharedMethod\microsoft.graph.workbookRangeFormat</summary>
    public class Microsoft.graph.workbookRangeFormatRequestBuilder {
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public Microsoft.graph.autofitColumnsRequestBuilder Microsoft.graph.autofitColumns { get =>
            new Microsoft.graph.autofitColumnsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.autofitRowsRequestBuilder Microsoft.graph.autofitRows { get =>
            new Microsoft.graph.autofitRowsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.workbookRangeFormatRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public Microsoft.graph.workbookRangeFormatRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/microsoft.graph.workbookRangeFormat";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
    }
}
