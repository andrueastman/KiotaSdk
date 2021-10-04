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
            new DailyPrintUsageByPrinterRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public DailyPrintUsageByUserRequestBuilder DailyPrintUsageByUser { get =>
            new DailyPrintUsageByUserRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public MonthlyPrintUsageByPrinterRequestBuilder MonthlyPrintUsageByPrinter { get =>
            new MonthlyPrintUsageByPrinterRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        public MonthlyPrintUsageByUserRequestBuilder MonthlyPrintUsageByUser { get =>
            new MonthlyPrintUsageByUserRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// </summary>
        public ReportsRequestBuilder(string currentPath, IHttpCore httpCore, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "/reports";
            HttpCore = httpCore;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Get reports
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
        /// Update reports
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ReportRoot body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
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
        /// Builds and executes requests for operations under \reports\microsoft.graph.deviceConfigurationDeviceActivity()
        /// </summary>
        public DeviceConfigurationDeviceActivityRequestBuilder deviceConfigurationDeviceActivity() {
            return new DeviceConfigurationDeviceActivityRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.deviceConfigurationUserActivity()
        /// </summary>
        public DeviceConfigurationUserActivityRequestBuilder deviceConfigurationUserActivity() {
            return new DeviceConfigurationUserActivityRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Get reports
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ReportRoot> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await HttpCore.SendAsync<ReportRoot>(requestInfo, responseHandler);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailActivityCountsWithPeriodRequestBuilder getEmailActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailActivityUserCountsWithPeriodRequestBuilder getEmailActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetEmailActivityUserDetailWithDateRequestBuilder getEmailActivityUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetEmailActivityUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , HttpCore, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailActivityUserDetailWithPeriodRequestBuilder getEmailActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailAppUsageAppsUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailAppUsageAppsUserCountsWithPeriodRequestBuilder getEmailAppUsageAppsUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageAppsUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailAppUsageUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailAppUsageUserCountsWithPeriodRequestBuilder getEmailAppUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailAppUsageUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetEmailAppUsageUserDetailWithDateRequestBuilder getEmailAppUsageUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetEmailAppUsageUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , HttpCore, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailAppUsageUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailAppUsageUserDetailWithPeriodRequestBuilder getEmailAppUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailAppUsageVersionsUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailAppUsageVersionsUserCountsWithPeriodRequestBuilder getEmailAppUsageVersionsUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageVersionsUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getGroupArchivedPrintJobs(groupId='{groupId}',startDateTime={startDateTime},endDateTime={endDateTime})
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="groupId">Usage: groupId={groupId}</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        /// </summary>
        public GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder getGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime(string groupId, DateTimeOffset? startDateTime, DateTimeOffset? endDateTime) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(groupId)) throw new ArgumentNullException(nameof(groupId));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            return new GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder(CurrentPath + PathSegment , HttpCore, groupId, startDateTime, endDateTime, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getMailboxUsageDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetMailboxUsageDetailWithPeriodRequestBuilder getMailboxUsageDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getMailboxUsageMailboxCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetMailboxUsageMailboxCountsWithPeriodRequestBuilder getMailboxUsageMailboxCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageMailboxCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getMailboxUsageQuotaStatusMailboxCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetMailboxUsageQuotaStatusMailboxCountsWithPeriodRequestBuilder getMailboxUsageQuotaStatusMailboxCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageQuotaStatusMailboxCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getMailboxUsageStorage(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetMailboxUsageStorageWithPeriodRequestBuilder getMailboxUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageStorageWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActivationCounts()
        /// </summary>
        public GetOffice365ActivationCountsRequestBuilder getOffice365ActivationCounts() {
            return new GetOffice365ActivationCountsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActivationsUserCounts()
        /// </summary>
        public GetOffice365ActivationsUserCountsRequestBuilder getOffice365ActivationsUserCounts() {
            return new GetOffice365ActivationsUserCountsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActivationsUserDetail()
        /// </summary>
        public GetOffice365ActivationsUserDetailRequestBuilder getOffice365ActivationsUserDetail() {
            return new GetOffice365ActivationsUserDetailRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActiveUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365ActiveUserCountsWithPeriodRequestBuilder getOffice365ActiveUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ActiveUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActiveUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetOffice365ActiveUserDetailWithDateRequestBuilder getOffice365ActiveUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetOffice365ActiveUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , HttpCore, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActiveUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365ActiveUserDetailWithPeriodRequestBuilder getOffice365ActiveUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ActiveUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365GroupsActivityCountsWithPeriodRequestBuilder getOffice365GroupsActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetOffice365GroupsActivityDetailWithDateRequestBuilder getOffice365GroupsActivityDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetOffice365GroupsActivityDetailWithDateRequestBuilder(CurrentPath + PathSegment , HttpCore, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365GroupsActivityDetailWithPeriodRequestBuilder getOffice365GroupsActivityDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityFileCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365GroupsActivityFileCountsWithPeriodRequestBuilder getOffice365GroupsActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityFileCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityGroupCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365GroupsActivityGroupCountsWithPeriodRequestBuilder getOffice365GroupsActivityGroupCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityGroupCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityStorage(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365GroupsActivityStorageWithPeriodRequestBuilder getOffice365GroupsActivityStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityStorageWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ServicesUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365ServicesUserCountsWithPeriodRequestBuilder getOffice365ServicesUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ServicesUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveActivityFileCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveActivityFileCountsWithPeriodRequestBuilder getOneDriveActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityFileCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveActivityUserCountsWithPeriodRequestBuilder getOneDriveActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetOneDriveActivityUserDetailWithDateRequestBuilder getOneDriveActivityUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetOneDriveActivityUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , HttpCore, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveActivityUserDetailWithPeriodRequestBuilder getOneDriveActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveUsageAccountCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveUsageAccountCountsWithPeriodRequestBuilder getOneDriveUsageAccountCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageAccountCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveUsageAccountDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetOneDriveUsageAccountDetailWithDateRequestBuilder getOneDriveUsageAccountDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetOneDriveUsageAccountDetailWithDateRequestBuilder(CurrentPath + PathSegment , HttpCore, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveUsageAccountDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveUsageAccountDetailWithPeriodRequestBuilder getOneDriveUsageAccountDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageAccountDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveUsageFileCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveUsageFileCountsWithPeriodRequestBuilder getOneDriveUsageFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageFileCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveUsageStorage(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveUsageStorageWithPeriodRequestBuilder getOneDriveUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageStorageWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getPrinterArchivedPrintJobs(printerId='{printerId}',startDateTime={startDateTime},endDateTime={endDateTime})
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="printerId">Usage: printerId={printerId}</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        /// </summary>
        public GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeRequestBuilder getPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime(string printerId, DateTimeOffset? startDateTime, DateTimeOffset? endDateTime) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(printerId)) throw new ArgumentNullException(nameof(printerId));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            return new GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeRequestBuilder(CurrentPath + PathSegment , HttpCore, printerId, startDateTime, endDateTime, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointActivityFileCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointActivityFileCountsWithPeriodRequestBuilder getSharePointActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityFileCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointActivityPages(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointActivityPagesWithPeriodRequestBuilder getSharePointActivityPagesWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityPagesWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointActivityUserCountsWithPeriodRequestBuilder getSharePointActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetSharePointActivityUserDetailWithDateRequestBuilder getSharePointActivityUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetSharePointActivityUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , HttpCore, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointActivityUserDetailWithPeriodRequestBuilder getSharePointActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsageDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetSharePointSiteUsageDetailWithDateRequestBuilder getSharePointSiteUsageDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetSharePointSiteUsageDetailWithDateRequestBuilder(CurrentPath + PathSegment , HttpCore, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsageDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointSiteUsageDetailWithPeriodRequestBuilder getSharePointSiteUsageDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsageFileCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointSiteUsageFileCountsWithPeriodRequestBuilder getSharePointSiteUsageFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageFileCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsagePages(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointSiteUsagePagesWithPeriodRequestBuilder getSharePointSiteUsagePagesWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsagePagesWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsageSiteCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointSiteUsageSiteCountsWithPeriodRequestBuilder getSharePointSiteUsageSiteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageSiteCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsageStorage(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointSiteUsageStorageWithPeriodRequestBuilder getSharePointSiteUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageStorageWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessActivityCountsWithPeriodRequestBuilder getSkypeForBusinessActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessActivityUserCountsWithPeriodRequestBuilder getSkypeForBusinessActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetSkypeForBusinessActivityUserDetailWithDateRequestBuilder getSkypeForBusinessActivityUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetSkypeForBusinessActivityUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , HttpCore, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessActivityUserDetailWithPeriodRequestBuilder getSkypeForBusinessActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessDeviceUsageDistributionUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriodRequestBuilder getSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessDeviceUsageUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessDeviceUsageUserCountsWithPeriodRequestBuilder getSkypeForBusinessDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessDeviceUsageUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetSkypeForBusinessDeviceUsageUserDetailWithDateRequestBuilder getSkypeForBusinessDeviceUsageUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetSkypeForBusinessDeviceUsageUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , HttpCore, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessDeviceUsageUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessDeviceUsageUserDetailWithPeriodRequestBuilder getSkypeForBusinessDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessOrganizerActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessOrganizerActivityCountsWithPeriodRequestBuilder getSkypeForBusinessOrganizerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessOrganizerActivityMinuteCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriodRequestBuilder getSkypeForBusinessOrganizerActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessOrganizerActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessOrganizerActivityUserCountsWithPeriodRequestBuilder getSkypeForBusinessOrganizerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessParticipantActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessParticipantActivityCountsWithPeriodRequestBuilder getSkypeForBusinessParticipantActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessParticipantActivityMinuteCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriodRequestBuilder getSkypeForBusinessParticipantActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessParticipantActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessParticipantActivityUserCountsWithPeriodRequestBuilder getSkypeForBusinessParticipantActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessPeerToPeerActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessPeerToPeerActivityCountsWithPeriodRequestBuilder getSkypeForBusinessPeerToPeerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessPeerToPeerActivityMinuteCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriodRequestBuilder getSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessPeerToPeerActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriodRequestBuilder getSkypeForBusinessPeerToPeerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsDeviceUsageDistributionUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsDeviceUsageDistributionUserCountsWithPeriodRequestBuilder getTeamsDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsDeviceUsageUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsDeviceUsageUserCountsWithPeriodRequestBuilder getTeamsDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsDeviceUsageUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetTeamsDeviceUsageUserDetailWithDateRequestBuilder getTeamsDeviceUsageUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetTeamsDeviceUsageUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , HttpCore, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsDeviceUsageUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsDeviceUsageUserDetailWithPeriodRequestBuilder getTeamsDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsUserActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsUserActivityCountsWithPeriodRequestBuilder getTeamsUserActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsUserActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsUserActivityUserCountsWithPeriodRequestBuilder getTeamsUserActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsUserActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetTeamsUserActivityUserDetailWithDateRequestBuilder getTeamsUserActivityUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetTeamsUserActivityUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , HttpCore, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsUserActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsUserActivityUserDetailWithPeriodRequestBuilder getTeamsUserActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getUserArchivedPrintJobs(userId='{userId}',startDateTime={startDateTime},endDateTime={endDateTime})
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        /// <param name="userId">Usage: userId={userId}</param>
        /// </summary>
        public GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTimeRequestBuilder getUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTime(string userId, DateTimeOffset? startDateTime, DateTimeOffset? endDateTime) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            if(string.IsNullOrEmpty(userId)) throw new ArgumentNullException(nameof(userId));
            return new GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTimeRequestBuilder(CurrentPath + PathSegment , HttpCore, userId, startDateTime, endDateTime, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerActivityCountsWithPeriodRequestBuilder getYammerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerActivityUserCountsWithPeriodRequestBuilder getYammerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetYammerActivityUserDetailWithDateRequestBuilder getYammerActivityUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetYammerActivityUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , HttpCore, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerActivityUserDetailWithPeriodRequestBuilder getYammerActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerDeviceUsageDistributionUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerDeviceUsageDistributionUserCountsWithPeriodRequestBuilder getYammerDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerDeviceUsageUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerDeviceUsageUserCountsWithPeriodRequestBuilder getYammerDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageUserCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerDeviceUsageUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetYammerDeviceUsageUserDetailWithDateRequestBuilder getYammerDeviceUsageUserDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetYammerDeviceUsageUserDetailWithDateRequestBuilder(CurrentPath + PathSegment , HttpCore, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerDeviceUsageUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerDeviceUsageUserDetailWithPeriodRequestBuilder getYammerDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageUserDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerGroupsActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerGroupsActivityCountsWithPeriodRequestBuilder getYammerGroupsActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerGroupsActivityDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetYammerGroupsActivityDetailWithDateRequestBuilder getYammerGroupsActivityDetailWithDate(string date) {
            if(string.IsNullOrEmpty(date)) throw new ArgumentNullException(nameof(date));
            return new GetYammerGroupsActivityDetailWithDateRequestBuilder(CurrentPath + PathSegment , HttpCore, date, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerGroupsActivityDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerGroupsActivityDetailWithPeriodRequestBuilder getYammerGroupsActivityDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityDetailWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerGroupsActivityGroupCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerGroupsActivityGroupCountsWithPeriodRequestBuilder getYammerGroupsActivityGroupCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityGroupCountsWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.managedDeviceEnrollmentFailureDetails()
        /// </summary>
        public ManagedDeviceEnrollmentFailureDetailsRequestBuilder managedDeviceEnrollmentFailureDetails() {
            return new ManagedDeviceEnrollmentFailureDetailsRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.managedDeviceEnrollmentFailureDetails(skip={skip},top={top},filter='{filter}',skipToken='{skipToken}')
        /// <param name="filter">Usage: filter={filter}</param>
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="skipToken">Usage: skipToken={skipToken}</param>
        /// <param name="top">Usage: top={top}</param>
        /// </summary>
        public ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder managedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipToken(int? skip, int? top, string filter, string skipToken) {
            if(string.IsNullOrEmpty(filter)) throw new ArgumentNullException(nameof(filter));
            _ = skip ?? throw new ArgumentNullException(nameof(skip));
            if(string.IsNullOrEmpty(skipToken)) throw new ArgumentNullException(nameof(skipToken));
            _ = top ?? throw new ArgumentNullException(nameof(top));
            return new ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder(CurrentPath + PathSegment , HttpCore, skip, top, filter, skipToken, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.managedDeviceEnrollmentTopFailures()
        /// </summary>
        public ManagedDeviceEnrollmentTopFailuresRequestBuilder managedDeviceEnrollmentTopFailures() {
            return new ManagedDeviceEnrollmentTopFailuresRequestBuilder(CurrentPath + PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.managedDeviceEnrollmentTopFailures(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder managedDeviceEnrollmentTopFailuresWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder(CurrentPath + PathSegment , HttpCore, period, false);
        }
        /// <summary>
        /// Update reports
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options for HTTP middlewares</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ReportRoot body, Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
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
