using GraphServiceClient.Users.ManagedDevices.DeviceCategory;
using GraphServiceClient.Users.ManagedDevices.DeviceCompliancePolicyStates;
using GraphServiceClient.Users.ManagedDevices.DeviceConfigurationStates;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.BypassActivationLock;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.CleanWindowsDevice;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.DeleteUserFromSharedAppleDevice;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.DisableLostMode;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.LocateDevice;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.LogoutSharedAppleDeviceActiveUser;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.RebootNow;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.RecoverPasscode;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.RemoteLock;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.RequestRemoteAssistance;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.ResetPasscode;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.Retire;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.ShutDown;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.SyncDevice;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.UpdateWindowsDeviceAccount;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.WindowsDefenderScan;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.WindowsDefenderUpdateSignatures;
using GraphServiceClient.Users.ManagedDevices.Microsoft.Graph.Wipe;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace GraphServiceClient.Users.ManagedDevices.Item {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\managedDevices\{managedDevice-id}</summary>
    public class ManagedDeviceRequestBuilder {
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DeviceCategoryRequestBuilder DeviceCategory { get =>
            new DeviceCategoryRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DeviceCompliancePolicyStatesRequestBuilder DeviceCompliancePolicyStates { get =>
            new DeviceCompliancePolicyStatesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DeviceConfigurationStatesRequestBuilder DeviceConfigurationStates { get =>
            new DeviceConfigurationStatesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public Microsoft.graph.bypassActivationLockRequestBuilder Microsoft.graph.bypassActivationLock { get =>
            new Microsoft.graph.bypassActivationLockRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.cleanWindowsDeviceRequestBuilder Microsoft.graph.cleanWindowsDevice { get =>
            new Microsoft.graph.cleanWindowsDeviceRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.deleteUserFromSharedAppleDeviceRequestBuilder Microsoft.graph.deleteUserFromSharedAppleDevice { get =>
            new Microsoft.graph.deleteUserFromSharedAppleDeviceRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.disableLostModeRequestBuilder Microsoft.graph.disableLostMode { get =>
            new Microsoft.graph.disableLostModeRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.locateDeviceRequestBuilder Microsoft.graph.locateDevice { get =>
            new Microsoft.graph.locateDeviceRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.logoutSharedAppleDeviceActiveUserRequestBuilder Microsoft.graph.logoutSharedAppleDeviceActiveUser { get =>
            new Microsoft.graph.logoutSharedAppleDeviceActiveUserRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.rebootNowRequestBuilder Microsoft.graph.rebootNow { get =>
            new Microsoft.graph.rebootNowRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.recoverPasscodeRequestBuilder Microsoft.graph.recoverPasscode { get =>
            new Microsoft.graph.recoverPasscodeRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.remoteLockRequestBuilder Microsoft.graph.remoteLock { get =>
            new Microsoft.graph.remoteLockRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.requestRemoteAssistanceRequestBuilder Microsoft.graph.requestRemoteAssistance { get =>
            new Microsoft.graph.requestRemoteAssistanceRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.resetPasscodeRequestBuilder Microsoft.graph.resetPasscode { get =>
            new Microsoft.graph.resetPasscodeRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.retireRequestBuilder Microsoft.graph.retire { get =>
            new Microsoft.graph.retireRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.shutDownRequestBuilder Microsoft.graph.shutDown { get =>
            new Microsoft.graph.shutDownRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.syncDeviceRequestBuilder Microsoft.graph.syncDevice { get =>
            new Microsoft.graph.syncDeviceRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.updateWindowsDeviceAccountRequestBuilder Microsoft.graph.updateWindowsDeviceAccount { get =>
            new Microsoft.graph.updateWindowsDeviceAccountRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.windowsDefenderScanRequestBuilder Microsoft.graph.windowsDefenderScan { get =>
            new Microsoft.graph.windowsDefenderScanRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.windowsDefenderUpdateSignaturesRequestBuilder Microsoft.graph.windowsDefenderUpdateSignatures { get =>
            new Microsoft.graph.windowsDefenderUpdateSignaturesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public Microsoft.graph.wipeRequestBuilder Microsoft.graph.wipe { get =>
            new Microsoft.graph.wipeRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>
        /// Instantiates a new ManagedDeviceRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public ManagedDeviceRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.DELETE,
            };
            requestInfo.SetURI(CurrentPath, PathSegment, IsRawUrl);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddMiddlewareOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
            };
            requestInfo.SetURI(CurrentPath, PathSegment, IsRawUrl);
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddMiddlewareOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ManagedDevice body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.PATCH,
            };
            requestInfo.SetURI(CurrentPath, PathSegment, IsRawUrl);
            requestInfo.SetContentFromParsable(HttpCore, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddMiddlewareOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ManagedDevice> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<ManagedDevice>(requestInfo, responseHandler);
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ManagedDevice body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>The managed devices associated with the user.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
