using ApiSdk.Users.Item.Insights.Shared.Item.Resource.WorkbookRangeFormat.AutofitColumns;
using ApiSdk.Users.Item.Insights.Shared.Item.Resource.WorkbookRangeFormat.AutofitRows;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.Insights.Shared.Item.Resource.WorkbookRangeFormat {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\shared\{sharedInsight-id}\resource\microsoft.graph.workbookRangeFormat</summary>
    public class WorkbookRangeFormatRequestBuilder {
        public AutofitColumnsRequestBuilder AutofitColumns { get =>
            new AutofitColumnsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public AutofitRowsRequestBuilder AutofitRows { get =>
            new AutofitRowsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
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
        /// Instantiates a new WorkbookRangeFormatRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public WorkbookRangeFormatRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "/microsoft.graph.workbookRangeFormat";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
    }
}
