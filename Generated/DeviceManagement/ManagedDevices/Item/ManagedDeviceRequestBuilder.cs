using ApiSdk.DeviceManagement.ManagedDevices.Item.BypassActivationLock;
using ApiSdk.DeviceManagement.ManagedDevices.Item.CleanWindowsDevice;
using ApiSdk.DeviceManagement.ManagedDevices.Item.DeleteUserFromSharedAppleDevice;
using ApiSdk.DeviceManagement.ManagedDevices.Item.DeviceCategory;
using ApiSdk.DeviceManagement.ManagedDevices.Item.DeviceCompliancePolicyStates;
using ApiSdk.DeviceManagement.ManagedDevices.Item.DeviceConfigurationStates;
using ApiSdk.DeviceManagement.ManagedDevices.Item.DisableLostMode;
using ApiSdk.DeviceManagement.ManagedDevices.Item.LocateDevice;
using ApiSdk.DeviceManagement.ManagedDevices.Item.LogoutSharedAppleDeviceActiveUser;
using ApiSdk.DeviceManagement.ManagedDevices.Item.RebootNow;
using ApiSdk.DeviceManagement.ManagedDevices.Item.RecoverPasscode;
using ApiSdk.DeviceManagement.ManagedDevices.Item.RemoteLock;
using ApiSdk.DeviceManagement.ManagedDevices.Item.RequestRemoteAssistance;
using ApiSdk.DeviceManagement.ManagedDevices.Item.ResetPasscode;
using ApiSdk.DeviceManagement.ManagedDevices.Item.Retire;
using ApiSdk.DeviceManagement.ManagedDevices.Item.ShutDown;
using ApiSdk.DeviceManagement.ManagedDevices.Item.SyncDevice;
using ApiSdk.DeviceManagement.ManagedDevices.Item.UpdateWindowsDeviceAccount;
using ApiSdk.DeviceManagement.ManagedDevices.Item.WindowsDefenderScan;
using ApiSdk.DeviceManagement.ManagedDevices.Item.WindowsDefenderUpdateSignatures;
using ApiSdk.DeviceManagement.ManagedDevices.Item.Wipe;
using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.DeviceManagement.ManagedDevices.Item {
    /// <summary>Builds and executes requests for operations under \deviceManagement\managedDevices\{managedDevice-id}</summary>
    public class ManagedDeviceRequestBuilder {
        public BypassActivationLockRequestBuilder BypassActivationLock { get =>
            new BypassActivationLockRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public CleanWindowsDeviceRequestBuilder CleanWindowsDevice { get =>
            new CleanWindowsDeviceRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DeleteUserFromSharedAppleDeviceRequestBuilder DeleteUserFromSharedAppleDevice { get =>
            new DeleteUserFromSharedAppleDeviceRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DeviceCategoryRequestBuilder DeviceCategory { get =>
            new DeviceCategoryRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DeviceCompliancePolicyStatesRequestBuilder DeviceCompliancePolicyStates { get =>
            new DeviceCompliancePolicyStatesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DeviceConfigurationStatesRequestBuilder DeviceConfigurationStates { get =>
            new DeviceConfigurationStatesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DisableLostModeRequestBuilder DisableLostMode { get =>
            new DisableLostModeRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public LocateDeviceRequestBuilder LocateDevice { get =>
            new LocateDeviceRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public LogoutSharedAppleDeviceActiveUserRequestBuilder LogoutSharedAppleDeviceActiveUser { get =>
            new LogoutSharedAppleDeviceActiveUserRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public RebootNowRequestBuilder RebootNow { get =>
            new RebootNowRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public RecoverPasscodeRequestBuilder RecoverPasscode { get =>
            new RecoverPasscodeRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public RemoteLockRequestBuilder RemoteLock { get =>
            new RemoteLockRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public RequestRemoteAssistanceRequestBuilder RequestRemoteAssistance { get =>
            new RequestRemoteAssistanceRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ResetPasscodeRequestBuilder ResetPasscode { get =>
            new ResetPasscodeRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public RetireRequestBuilder Retire { get =>
            new RetireRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public ShutDownRequestBuilder ShutDown { get =>
            new ShutDownRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public SyncDeviceRequestBuilder SyncDevice { get =>
            new SyncDeviceRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public UpdateWindowsDeviceAccountRequestBuilder UpdateWindowsDeviceAccount { get =>
            new UpdateWindowsDeviceAccountRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public WindowsDefenderScanRequestBuilder WindowsDefenderScan { get =>
            new WindowsDefenderScanRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public WindowsDefenderUpdateSignaturesRequestBuilder WindowsDefenderUpdateSignatures { get =>
            new WindowsDefenderUpdateSignaturesRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public WipeRequestBuilder Wipe { get =>
            new WipeRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
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
        /// The list of managed devices.
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
        /// The list of managed devices.
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
        /// The list of managed devices.
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
        /// The list of managed devices.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>
        /// The list of managed devices.
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
        /// The list of managed devices.
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
        /// <summary>The list of managed devices.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
