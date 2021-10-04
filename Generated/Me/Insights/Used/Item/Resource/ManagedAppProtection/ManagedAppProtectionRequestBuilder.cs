using ApiSdk.Me.Insights.Used.Item.Resource.ManagedAppProtection.TargetApps;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Me.Insights.Used.Item.Resource.ManagedAppProtection {
    /// <summary>Builds and executes requests for operations under \me\insights\used\{usedInsight-id}\resource\microsoft.graph.managedAppProtection</summary>
    public class ManagedAppProtectionRequestBuilder {
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public TargetAppsRequestBuilder TargetApps { get =>
            new TargetAppsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new ManagedAppProtectionRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public ManagedAppProtectionRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/microsoft.graph.managedAppProtection";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
    }
}
