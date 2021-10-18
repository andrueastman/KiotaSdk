using ApiSdk.Models.Microsoft.Graph;
using ApiSdk.Reports.DailyPrintUsageByPrinter;
using ApiSdk.Reports.DailyPrintUsageByUser;
using ApiSdk.Reports.DeviceConfigurationDeviceActivity;
using ApiSdk.Reports.DeviceConfigurationUserActivity;
using ApiSdk.Reports.GetEmailActivityCountsWithPeriod;
using ApiSdk.Reports.GetEmailActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetEmailActivityUserDetailWithDate;
using ApiSdk.Reports.GetEmailActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetEmailAppUsageAppsUserCountsWithPeriod;
using ApiSdk.Reports.GetEmailAppUsageUserCountsWithPeriod;
using ApiSdk.Reports.GetEmailAppUsageUserDetailWithDate;
using ApiSdk.Reports.GetEmailAppUsageUserDetailWithPeriod;
using ApiSdk.Reports.GetEmailAppUsageVersionsUserCountsWithPeriod;
using ApiSdk.Reports.GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime;
using ApiSdk.Reports.GetMailboxUsageDetailWithPeriod;
using ApiSdk.Reports.GetMailboxUsageMailboxCountsWithPeriod;
using ApiSdk.Reports.GetMailboxUsageQuotaStatusMailboxCountsWithPeriod;
using ApiSdk.Reports.GetMailboxUsageStorageWithPeriod;
using ApiSdk.Reports.GetOffice365ActivationCounts;
using ApiSdk.Reports.GetOffice365ActivationsUserCounts;
using ApiSdk.Reports.GetOffice365ActivationsUserDetail;
using ApiSdk.Reports.GetOffice365ActiveUserCountsWithPeriod;
using ApiSdk.Reports.GetOffice365ActiveUserDetailWithDate;
using ApiSdk.Reports.GetOffice365ActiveUserDetailWithPeriod;
using ApiSdk.Reports.GetOffice365GroupsActivityCountsWithPeriod;
using ApiSdk.Reports.GetOffice365GroupsActivityDetailWithDate;
using ApiSdk.Reports.GetOffice365GroupsActivityDetailWithPeriod;
using ApiSdk.Reports.GetOffice365GroupsActivityFileCountsWithPeriod;
using ApiSdk.Reports.GetOffice365GroupsActivityGroupCountsWithPeriod;
using ApiSdk.Reports.GetOffice365GroupsActivityStorageWithPeriod;
using ApiSdk.Reports.GetOffice365ServicesUserCountsWithPeriod;
using ApiSdk.Reports.GetOneDriveActivityFileCountsWithPeriod;
using ApiSdk.Reports.GetOneDriveActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetOneDriveActivityUserDetailWithDate;
using ApiSdk.Reports.GetOneDriveActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetOneDriveUsageAccountCountsWithPeriod;
using ApiSdk.Reports.GetOneDriveUsageAccountDetailWithDate;
using ApiSdk.Reports.GetOneDriveUsageAccountDetailWithPeriod;
using ApiSdk.Reports.GetOneDriveUsageFileCountsWithPeriod;
using ApiSdk.Reports.GetOneDriveUsageStorageWithPeriod;
using ApiSdk.Reports.GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime;
using ApiSdk.Reports.GetSharePointActivityFileCountsWithPeriod;
using ApiSdk.Reports.GetSharePointActivityPagesWithPeriod;
using ApiSdk.Reports.GetSharePointActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetSharePointActivityUserDetailWithDate;
using ApiSdk.Reports.GetSharePointActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetSharePointSiteUsageDetailWithDate;
using ApiSdk.Reports.GetSharePointSiteUsageDetailWithPeriod;
using ApiSdk.Reports.GetSharePointSiteUsageFileCountsWithPeriod;
using ApiSdk.Reports.GetSharePointSiteUsagePagesWithPeriod;
using ApiSdk.Reports.GetSharePointSiteUsageSiteCountsWithPeriod;
using ApiSdk.Reports.GetSharePointSiteUsageStorageWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessActivityCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessActivityUserDetailWithDate;
using ApiSdk.Reports.GetSkypeForBusinessActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessDeviceUsageUserCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessDeviceUsageUserDetailWithDate;
using ApiSdk.Reports.GetSkypeForBusinessDeviceUsageUserDetailWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessOrganizerActivityCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessOrganizerActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessParticipantActivityCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessParticipantActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessPeerToPeerActivityCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetTeamsDeviceUsageDistributionUserCountsWithPeriod;
using ApiSdk.Reports.GetTeamsDeviceUsageUserCountsWithPeriod;
using ApiSdk.Reports.GetTeamsDeviceUsageUserDetailWithDate;
using ApiSdk.Reports.GetTeamsDeviceUsageUserDetailWithPeriod;
using ApiSdk.Reports.GetTeamsUserActivityCountsWithPeriod;
using ApiSdk.Reports.GetTeamsUserActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetTeamsUserActivityUserDetailWithDate;
using ApiSdk.Reports.GetTeamsUserActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTime;
using ApiSdk.Reports.GetYammerActivityCountsWithPeriod;
using ApiSdk.Reports.GetYammerActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetYammerActivityUserDetailWithDate;
using ApiSdk.Reports.GetYammerActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetYammerDeviceUsageDistributionUserCountsWithPeriod;
using ApiSdk.Reports.GetYammerDeviceUsageUserCountsWithPeriod;
using ApiSdk.Reports.GetYammerDeviceUsageUserDetailWithDate;
using ApiSdk.Reports.GetYammerDeviceUsageUserDetailWithPeriod;
using ApiSdk.Reports.GetYammerGroupsActivityCountsWithPeriod;
using ApiSdk.Reports.GetYammerGroupsActivityDetailWithDate;
using ApiSdk.Reports.GetYammerGroupsActivityDetailWithPeriod;
using ApiSdk.Reports.GetYammerGroupsActivityGroupCountsWithPeriod;
using ApiSdk.Reports.ManagedDeviceEnrollmentFailureDetails;
using ApiSdk.Reports.ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipToken;
using ApiSdk.Reports.ManagedDeviceEnrollmentTopFailures;
using ApiSdk.Reports.ManagedDeviceEnrollmentTopFailuresWithPeriod;
using ApiSdk.Reports.MonthlyPrintUsageByPrinter;
using ApiSdk.Reports.MonthlyPrintUsageByUser;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Reports {
    /// <summary>Builds and executes requests for operations under \reports</summary>
    public class ReportsRequestBuilder {
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DailyPrintUsageByPrinterRequestBuilder DailyPrintUsageByPrinter { get =>
            new DailyPrintUsageByPrinterRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public DailyPrintUsageByUserRequestBuilder DailyPrintUsageByUser { get =>
            new DailyPrintUsageByUserRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public MonthlyPrintUsageByPrinterRequestBuilder MonthlyPrintUsageByPrinter { get =>
            new MonthlyPrintUsageByPrinterRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public MonthlyPrintUsageByUserRequestBuilder MonthlyPrintUsageByUser { get =>
            new MonthlyPrintUsageByUserRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public ReportsRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "/reports";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Get reports
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update reports
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ReportRoot body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.PATCH,
            };
            requestInfo.SetURI(CurrentPath, PathSegment, IsRawUrl);
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.deviceConfigurationDeviceActivity()
        /// </summary>
        public DeviceConfigurationDeviceActivityRequestBuilder DeviceConfigurationDeviceActivity() {
            return new DeviceConfigurationDeviceActivityRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.deviceConfigurationUserActivity()
        /// </summary>
        public DeviceConfigurationUserActivityRequestBuilder DeviceConfigurationUserActivity() {
            return new DeviceConfigurationUserActivityRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Get reports
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ReportRoot> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ReportRoot>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailActivityCountsWithPeriodRequestBuilder GetEmailActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailActivityUserCountsWithPeriodRequestBuilder GetEmailActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetEmailActivityUserDetailWithDateRequestBuilder GetEmailActivityUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetEmailActivityUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailActivityUserDetailWithPeriodRequestBuilder GetEmailActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailAppUsageAppsUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailAppUsageAppsUserCountsWithPeriodRequestBuilder GetEmailAppUsageAppsUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageAppsUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailAppUsageUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailAppUsageUserCountsWithPeriodRequestBuilder GetEmailAppUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailAppUsageUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetEmailAppUsageUserDetailWithDateRequestBuilder GetEmailAppUsageUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetEmailAppUsageUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailAppUsageUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailAppUsageUserDetailWithPeriodRequestBuilder GetEmailAppUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailAppUsageVersionsUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailAppUsageVersionsUserCountsWithPeriodRequestBuilder GetEmailAppUsageVersionsUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageVersionsUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getGroupArchivedPrintJobs(groupId='{groupId}',startDateTime={startDateTime},endDateTime={endDateTime})
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="groupId">Usage: groupId={groupId}</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        /// </summary>
        public GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime(string groupId, DateTimeOffset? startDateTime, DateTimeOffset? endDateTime) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(groupId)) throw new ArgumentNullException(nameof(groupId));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            return new GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, groupId, startDateTime, endDateTime, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getMailboxUsageDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetMailboxUsageDetailWithPeriodRequestBuilder GetMailboxUsageDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getMailboxUsageMailboxCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetMailboxUsageMailboxCountsWithPeriodRequestBuilder GetMailboxUsageMailboxCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageMailboxCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getMailboxUsageQuotaStatusMailboxCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetMailboxUsageQuotaStatusMailboxCountsWithPeriodRequestBuilder GetMailboxUsageQuotaStatusMailboxCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageQuotaStatusMailboxCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getMailboxUsageStorage(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetMailboxUsageStorageWithPeriodRequestBuilder GetMailboxUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageStorageWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActivationCounts()
        /// </summary>
        public GetOffice365ActivationCountsRequestBuilder GetOffice365ActivationCounts() {
            return new GetOffice365ActivationCountsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActivationsUserCounts()
        /// </summary>
        public GetOffice365ActivationsUserCountsRequestBuilder GetOffice365ActivationsUserCounts() {
            return new GetOffice365ActivationsUserCountsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActivationsUserDetail()
        /// </summary>
        public GetOffice365ActivationsUserDetailRequestBuilder GetOffice365ActivationsUserDetail() {
            return new GetOffice365ActivationsUserDetailRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActiveUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365ActiveUserCountsWithPeriodRequestBuilder GetOffice365ActiveUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ActiveUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActiveUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetOffice365ActiveUserDetailWithDateRequestBuilder GetOffice365ActiveUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetOffice365ActiveUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActiveUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365ActiveUserDetailWithPeriodRequestBuilder GetOffice365ActiveUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ActiveUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365GroupsActivityCountsWithPeriodRequestBuilder GetOffice365GroupsActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetOffice365GroupsActivityDetailWithDateRequestBuilder GetOffice365GroupsActivityDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetOffice365GroupsActivityDetailWithDateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365GroupsActivityDetailWithPeriodRequestBuilder GetOffice365GroupsActivityDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityFileCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365GroupsActivityFileCountsWithPeriodRequestBuilder GetOffice365GroupsActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityFileCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityGroupCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365GroupsActivityGroupCountsWithPeriodRequestBuilder GetOffice365GroupsActivityGroupCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityGroupCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityStorage(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365GroupsActivityStorageWithPeriodRequestBuilder GetOffice365GroupsActivityStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityStorageWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ServicesUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365ServicesUserCountsWithPeriodRequestBuilder GetOffice365ServicesUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ServicesUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveActivityFileCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveActivityFileCountsWithPeriodRequestBuilder GetOneDriveActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityFileCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveActivityUserCountsWithPeriodRequestBuilder GetOneDriveActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetOneDriveActivityUserDetailWithDateRequestBuilder GetOneDriveActivityUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetOneDriveActivityUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveActivityUserDetailWithPeriodRequestBuilder GetOneDriveActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveUsageAccountCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveUsageAccountCountsWithPeriodRequestBuilder GetOneDriveUsageAccountCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageAccountCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveUsageAccountDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetOneDriveUsageAccountDetailWithDateRequestBuilder GetOneDriveUsageAccountDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetOneDriveUsageAccountDetailWithDateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveUsageAccountDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveUsageAccountDetailWithPeriodRequestBuilder GetOneDriveUsageAccountDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageAccountDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveUsageFileCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveUsageFileCountsWithPeriodRequestBuilder GetOneDriveUsageFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageFileCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveUsageStorage(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveUsageStorageWithPeriodRequestBuilder GetOneDriveUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageStorageWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getPrinterArchivedPrintJobs(printerId='{printerId}',startDateTime={startDateTime},endDateTime={endDateTime})
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="printerId">Usage: printerId={printerId}</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        /// </summary>
        public GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeRequestBuilder GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime(string printerId, DateTimeOffset? startDateTime, DateTimeOffset? endDateTime) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(printerId)) throw new ArgumentNullException(nameof(printerId));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            return new GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, printerId, startDateTime, endDateTime, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointActivityFileCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointActivityFileCountsWithPeriodRequestBuilder GetSharePointActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityFileCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointActivityPages(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointActivityPagesWithPeriodRequestBuilder GetSharePointActivityPagesWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityPagesWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointActivityUserCountsWithPeriodRequestBuilder GetSharePointActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetSharePointActivityUserDetailWithDateRequestBuilder GetSharePointActivityUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetSharePointActivityUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointActivityUserDetailWithPeriodRequestBuilder GetSharePointActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsageDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetSharePointSiteUsageDetailWithDateRequestBuilder GetSharePointSiteUsageDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetSharePointSiteUsageDetailWithDateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsageDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointSiteUsageDetailWithPeriodRequestBuilder GetSharePointSiteUsageDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsageFileCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointSiteUsageFileCountsWithPeriodRequestBuilder GetSharePointSiteUsageFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageFileCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsagePages(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointSiteUsagePagesWithPeriodRequestBuilder GetSharePointSiteUsagePagesWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsagePagesWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsageSiteCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointSiteUsageSiteCountsWithPeriodRequestBuilder GetSharePointSiteUsageSiteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageSiteCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsageStorage(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointSiteUsageStorageWithPeriodRequestBuilder GetSharePointSiteUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageStorageWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessActivityCountsWithPeriodRequestBuilder GetSkypeForBusinessActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessActivityUserCountsWithPeriodRequestBuilder GetSkypeForBusinessActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetSkypeForBusinessActivityUserDetailWithDateRequestBuilder GetSkypeForBusinessActivityUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetSkypeForBusinessActivityUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessActivityUserDetailWithPeriodRequestBuilder GetSkypeForBusinessActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessDeviceUsageDistributionUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriodRequestBuilder GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessDeviceUsageUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessDeviceUsageUserCountsWithPeriodRequestBuilder GetSkypeForBusinessDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessDeviceUsageUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetSkypeForBusinessDeviceUsageUserDetailWithDateRequestBuilder GetSkypeForBusinessDeviceUsageUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetSkypeForBusinessDeviceUsageUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessDeviceUsageUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessDeviceUsageUserDetailWithPeriodRequestBuilder GetSkypeForBusinessDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessOrganizerActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessOrganizerActivityCountsWithPeriodRequestBuilder GetSkypeForBusinessOrganizerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessOrganizerActivityMinuteCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriodRequestBuilder GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessOrganizerActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessOrganizerActivityUserCountsWithPeriodRequestBuilder GetSkypeForBusinessOrganizerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessParticipantActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessParticipantActivityCountsWithPeriodRequestBuilder GetSkypeForBusinessParticipantActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessParticipantActivityMinuteCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriodRequestBuilder GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessParticipantActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessParticipantActivityUserCountsWithPeriodRequestBuilder GetSkypeForBusinessParticipantActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessPeerToPeerActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessPeerToPeerActivityCountsWithPeriodRequestBuilder GetSkypeForBusinessPeerToPeerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessPeerToPeerActivityMinuteCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriodRequestBuilder GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessPeerToPeerActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriodRequestBuilder GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsDeviceUsageDistributionUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsDeviceUsageDistributionUserCountsWithPeriodRequestBuilder GetTeamsDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsDeviceUsageUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsDeviceUsageUserCountsWithPeriodRequestBuilder GetTeamsDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsDeviceUsageUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetTeamsDeviceUsageUserDetailWithDateRequestBuilder GetTeamsDeviceUsageUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetTeamsDeviceUsageUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsDeviceUsageUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsDeviceUsageUserDetailWithPeriodRequestBuilder GetTeamsDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsUserActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsUserActivityCountsWithPeriodRequestBuilder GetTeamsUserActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsUserActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsUserActivityUserCountsWithPeriodRequestBuilder GetTeamsUserActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsUserActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetTeamsUserActivityUserDetailWithDateRequestBuilder GetTeamsUserActivityUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetTeamsUserActivityUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsUserActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsUserActivityUserDetailWithPeriodRequestBuilder GetTeamsUserActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getUserArchivedPrintJobs(userId='{userId}',startDateTime={startDateTime},endDateTime={endDateTime})
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        /// <param name="userId">Usage: userId={userId}</param>
        /// </summary>
        public GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTimeRequestBuilder GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTime(string userId, DateTimeOffset? startDateTime, DateTimeOffset? endDateTime) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            if(string.IsNullOrEmpty(userId)) throw new ArgumentNullException(nameof(userId));
            return new GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTimeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, userId, startDateTime, endDateTime, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerActivityCountsWithPeriodRequestBuilder GetYammerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerActivityUserCountsWithPeriodRequestBuilder GetYammerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetYammerActivityUserDetailWithDateRequestBuilder GetYammerActivityUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetYammerActivityUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerActivityUserDetailWithPeriodRequestBuilder GetYammerActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerDeviceUsageDistributionUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerDeviceUsageDistributionUserCountsWithPeriodRequestBuilder GetYammerDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerDeviceUsageUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerDeviceUsageUserCountsWithPeriodRequestBuilder GetYammerDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerDeviceUsageUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetYammerDeviceUsageUserDetailWithDateRequestBuilder GetYammerDeviceUsageUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetYammerDeviceUsageUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerDeviceUsageUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerDeviceUsageUserDetailWithPeriodRequestBuilder GetYammerDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerGroupsActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerGroupsActivityCountsWithPeriodRequestBuilder GetYammerGroupsActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerGroupsActivityDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetYammerGroupsActivityDetailWithDateRequestBuilder GetYammerGroupsActivityDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetYammerGroupsActivityDetailWithDateRequestBuilder(CurrentPath + PathSegment , RequestAdapter, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerGroupsActivityDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerGroupsActivityDetailWithPeriodRequestBuilder GetYammerGroupsActivityDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerGroupsActivityGroupCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerGroupsActivityGroupCountsWithPeriodRequestBuilder GetYammerGroupsActivityGroupCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityGroupCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.managedDeviceEnrollmentFailureDetails()
        /// </summary>
        public ManagedDeviceEnrollmentFailureDetailsRequestBuilder ManagedDeviceEnrollmentFailureDetails() {
            return new ManagedDeviceEnrollmentFailureDetailsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.managedDeviceEnrollmentFailureDetails(skip={skip},top={top},filter='{filter}',skipToken='{skipToken}')
        /// <param name="filter">Usage: filter={filter}</param>
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="skipToken">Usage: skipToken={skipToken}</param>
        /// <param name="top">Usage: top={top}</param>
        /// </summary>
        public ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipToken(int? skip, int? top, string filter, string skipToken) {
            if(string.IsNullOrEmpty(filter)) throw new ArgumentNullException(nameof(filter));
            _ = skip ?? throw new ArgumentNullException(nameof(skip));
            if(string.IsNullOrEmpty(skipToken)) throw new ArgumentNullException(nameof(skipToken));
            _ = top ?? throw new ArgumentNullException(nameof(top));
            return new ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder(CurrentPath + PathSegment , RequestAdapter, skip, top, filter, skipToken, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.managedDeviceEnrollmentTopFailures()
        /// </summary>
        public ManagedDeviceEnrollmentTopFailuresRequestBuilder ManagedDeviceEnrollmentTopFailures() {
            return new ManagedDeviceEnrollmentTopFailuresRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.managedDeviceEnrollmentTopFailures(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder ManagedDeviceEnrollmentTopFailuresWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder(CurrentPath + PathSegment , RequestAdapter, period, false);
        }
        /// <summary>
        /// Update reports
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ReportRoot body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
        /// <summary>Get reports</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
