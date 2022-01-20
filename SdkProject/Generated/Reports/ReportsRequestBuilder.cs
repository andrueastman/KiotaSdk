using GraphSdk.Models.Microsoft.Graph;
using GraphSdk.Reports.DailyPrintUsageByPrinter;
using GraphSdk.Reports.DailyPrintUsageByUser;
using GraphSdk.Reports.DeviceConfigurationDeviceActivity;
using GraphSdk.Reports.DeviceConfigurationUserActivity;
using GraphSdk.Reports.GetEmailActivityCountsWithPeriod;
using GraphSdk.Reports.GetEmailActivityUserCountsWithPeriod;
using GraphSdk.Reports.GetEmailActivityUserDetailWithDate;
using GraphSdk.Reports.GetEmailActivityUserDetailWithPeriod;
using GraphSdk.Reports.GetEmailAppUsageAppsUserCountsWithPeriod;
using GraphSdk.Reports.GetEmailAppUsageUserCountsWithPeriod;
using GraphSdk.Reports.GetEmailAppUsageUserDetailWithDate;
using GraphSdk.Reports.GetEmailAppUsageUserDetailWithPeriod;
using GraphSdk.Reports.GetEmailAppUsageVersionsUserCountsWithPeriod;
using GraphSdk.Reports.GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime;
using GraphSdk.Reports.GetMailboxUsageDetailWithPeriod;
using GraphSdk.Reports.GetMailboxUsageMailboxCountsWithPeriod;
using GraphSdk.Reports.GetMailboxUsageQuotaStatusMailboxCountsWithPeriod;
using GraphSdk.Reports.GetMailboxUsageStorageWithPeriod;
using GraphSdk.Reports.GetOffice365ActivationCounts;
using GraphSdk.Reports.GetOffice365ActivationsUserCounts;
using GraphSdk.Reports.GetOffice365ActivationsUserDetail;
using GraphSdk.Reports.GetOffice365ActiveUserCountsWithPeriod;
using GraphSdk.Reports.GetOffice365ActiveUserDetailWithDate;
using GraphSdk.Reports.GetOffice365ActiveUserDetailWithPeriod;
using GraphSdk.Reports.GetOffice365GroupsActivityCountsWithPeriod;
using GraphSdk.Reports.GetOffice365GroupsActivityDetailWithDate;
using GraphSdk.Reports.GetOffice365GroupsActivityDetailWithPeriod;
using GraphSdk.Reports.GetOffice365GroupsActivityFileCountsWithPeriod;
using GraphSdk.Reports.GetOffice365GroupsActivityGroupCountsWithPeriod;
using GraphSdk.Reports.GetOffice365GroupsActivityStorageWithPeriod;
using GraphSdk.Reports.GetOffice365ServicesUserCountsWithPeriod;
using GraphSdk.Reports.GetOneDriveActivityFileCountsWithPeriod;
using GraphSdk.Reports.GetOneDriveActivityUserCountsWithPeriod;
using GraphSdk.Reports.GetOneDriveActivityUserDetailWithDate;
using GraphSdk.Reports.GetOneDriveActivityUserDetailWithPeriod;
using GraphSdk.Reports.GetOneDriveUsageAccountCountsWithPeriod;
using GraphSdk.Reports.GetOneDriveUsageAccountDetailWithDate;
using GraphSdk.Reports.GetOneDriveUsageAccountDetailWithPeriod;
using GraphSdk.Reports.GetOneDriveUsageFileCountsWithPeriod;
using GraphSdk.Reports.GetOneDriveUsageStorageWithPeriod;
using GraphSdk.Reports.GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime;
using GraphSdk.Reports.GetSharePointActivityFileCountsWithPeriod;
using GraphSdk.Reports.GetSharePointActivityPagesWithPeriod;
using GraphSdk.Reports.GetSharePointActivityUserCountsWithPeriod;
using GraphSdk.Reports.GetSharePointActivityUserDetailWithDate;
using GraphSdk.Reports.GetSharePointActivityUserDetailWithPeriod;
using GraphSdk.Reports.GetSharePointSiteUsageDetailWithDate;
using GraphSdk.Reports.GetSharePointSiteUsageDetailWithPeriod;
using GraphSdk.Reports.GetSharePointSiteUsageFileCountsWithPeriod;
using GraphSdk.Reports.GetSharePointSiteUsagePagesWithPeriod;
using GraphSdk.Reports.GetSharePointSiteUsageSiteCountsWithPeriod;
using GraphSdk.Reports.GetSharePointSiteUsageStorageWithPeriod;
using GraphSdk.Reports.GetSkypeForBusinessActivityCountsWithPeriod;
using GraphSdk.Reports.GetSkypeForBusinessActivityUserCountsWithPeriod;
using GraphSdk.Reports.GetSkypeForBusinessActivityUserDetailWithDate;
using GraphSdk.Reports.GetSkypeForBusinessActivityUserDetailWithPeriod;
using GraphSdk.Reports.GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriod;
using GraphSdk.Reports.GetSkypeForBusinessDeviceUsageUserCountsWithPeriod;
using GraphSdk.Reports.GetSkypeForBusinessDeviceUsageUserDetailWithDate;
using GraphSdk.Reports.GetSkypeForBusinessDeviceUsageUserDetailWithPeriod;
using GraphSdk.Reports.GetSkypeForBusinessOrganizerActivityCountsWithPeriod;
using GraphSdk.Reports.GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriod;
using GraphSdk.Reports.GetSkypeForBusinessOrganizerActivityUserCountsWithPeriod;
using GraphSdk.Reports.GetSkypeForBusinessParticipantActivityCountsWithPeriod;
using GraphSdk.Reports.GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriod;
using GraphSdk.Reports.GetSkypeForBusinessParticipantActivityUserCountsWithPeriod;
using GraphSdk.Reports.GetSkypeForBusinessPeerToPeerActivityCountsWithPeriod;
using GraphSdk.Reports.GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriod;
using GraphSdk.Reports.GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriod;
using GraphSdk.Reports.GetTeamsDeviceUsageDistributionUserCountsWithPeriod;
using GraphSdk.Reports.GetTeamsDeviceUsageUserCountsWithPeriod;
using GraphSdk.Reports.GetTeamsDeviceUsageUserDetailWithDate;
using GraphSdk.Reports.GetTeamsDeviceUsageUserDetailWithPeriod;
using GraphSdk.Reports.GetTeamsUserActivityCountsWithPeriod;
using GraphSdk.Reports.GetTeamsUserActivityUserCountsWithPeriod;
using GraphSdk.Reports.GetTeamsUserActivityUserDetailWithDate;
using GraphSdk.Reports.GetTeamsUserActivityUserDetailWithPeriod;
using GraphSdk.Reports.GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTime;
using GraphSdk.Reports.GetYammerActivityCountsWithPeriod;
using GraphSdk.Reports.GetYammerActivityUserCountsWithPeriod;
using GraphSdk.Reports.GetYammerActivityUserDetailWithDate;
using GraphSdk.Reports.GetYammerActivityUserDetailWithPeriod;
using GraphSdk.Reports.GetYammerDeviceUsageDistributionUserCountsWithPeriod;
using GraphSdk.Reports.GetYammerDeviceUsageUserCountsWithPeriod;
using GraphSdk.Reports.GetYammerDeviceUsageUserDetailWithDate;
using GraphSdk.Reports.GetYammerDeviceUsageUserDetailWithPeriod;
using GraphSdk.Reports.GetYammerGroupsActivityCountsWithPeriod;
using GraphSdk.Reports.GetYammerGroupsActivityDetailWithDate;
using GraphSdk.Reports.GetYammerGroupsActivityDetailWithPeriod;
using GraphSdk.Reports.GetYammerGroupsActivityGroupCountsWithPeriod;
using GraphSdk.Reports.ManagedDeviceEnrollmentFailureDetails;
using GraphSdk.Reports.ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipToken;
using GraphSdk.Reports.ManagedDeviceEnrollmentTopFailures;
using GraphSdk.Reports.ManagedDeviceEnrollmentTopFailuresWithPeriod;
using GraphSdk.Reports.MonthlyPrintUsageByPrinter;
using GraphSdk.Reports.MonthlyPrintUsageByUser;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace GraphSdk.Reports {
    /// <summary>Builds and executes requests for operations under \reports</summary>
    public class ReportsRequestBuilder {
        public DailyPrintUsageByPrinterRequestBuilder DailyPrintUsageByPrinter { get =>
            new DailyPrintUsageByPrinterRequestBuilder(PathParameters, RequestAdapter);
        }
        public DailyPrintUsageByUserRequestBuilder DailyPrintUsageByUser { get =>
            new DailyPrintUsageByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        public MonthlyPrintUsageByPrinterRequestBuilder MonthlyPrintUsageByPrinter { get =>
            new MonthlyPrintUsageByPrinterRequestBuilder(PathParameters, RequestAdapter);
        }
        public MonthlyPrintUsageByUserRequestBuilder MonthlyPrintUsageByUser { get =>
            new MonthlyPrintUsageByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/reports{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ReportsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/reports{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get reports
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
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
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.deviceConfigurationDeviceActivity()
        /// </summary>
        public DeviceConfigurationDeviceActivityRequestBuilder DeviceConfigurationDeviceActivity() {
            return new DeviceConfigurationDeviceActivityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.deviceConfigurationUserActivity()
        /// </summary>
        public DeviceConfigurationUserActivityRequestBuilder DeviceConfigurationUserActivity() {
            return new DeviceConfigurationUserActivityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Get reports
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ReportRoot> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<ReportRoot>(requestInfo, responseHandler, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailActivityCountsWithPeriodRequestBuilder GetEmailActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailActivityUserCountsWithPeriodRequestBuilder GetEmailActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetEmailActivityUserDetailWithDateRequestBuilder GetEmailActivityUserDetailWithDate(Date date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetEmailActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailActivityUserDetailWithPeriodRequestBuilder GetEmailActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailAppUsageAppsUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailAppUsageAppsUserCountsWithPeriodRequestBuilder GetEmailAppUsageAppsUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageAppsUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailAppUsageUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailAppUsageUserCountsWithPeriodRequestBuilder GetEmailAppUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailAppUsageUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetEmailAppUsageUserDetailWithDateRequestBuilder GetEmailAppUsageUserDetailWithDate(Date date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetEmailAppUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailAppUsageUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailAppUsageUserDetailWithPeriodRequestBuilder GetEmailAppUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getEmailAppUsageVersionsUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetEmailAppUsageVersionsUserCountsWithPeriodRequestBuilder GetEmailAppUsageVersionsUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageVersionsUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
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
            return new GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, groupId, startDateTime, endDateTime);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getMailboxUsageDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetMailboxUsageDetailWithPeriodRequestBuilder GetMailboxUsageDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getMailboxUsageMailboxCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetMailboxUsageMailboxCountsWithPeriodRequestBuilder GetMailboxUsageMailboxCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageMailboxCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getMailboxUsageQuotaStatusMailboxCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetMailboxUsageQuotaStatusMailboxCountsWithPeriodRequestBuilder GetMailboxUsageQuotaStatusMailboxCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageQuotaStatusMailboxCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getMailboxUsageStorage(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetMailboxUsageStorageWithPeriodRequestBuilder GetMailboxUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActivationCounts()
        /// </summary>
        public GetOffice365ActivationCountsRequestBuilder GetOffice365ActivationCounts() {
            return new GetOffice365ActivationCountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActivationsUserCounts()
        /// </summary>
        public GetOffice365ActivationsUserCountsRequestBuilder GetOffice365ActivationsUserCounts() {
            return new GetOffice365ActivationsUserCountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActivationsUserDetail()
        /// </summary>
        public GetOffice365ActivationsUserDetailRequestBuilder GetOffice365ActivationsUserDetail() {
            return new GetOffice365ActivationsUserDetailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActiveUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365ActiveUserCountsWithPeriodRequestBuilder GetOffice365ActiveUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ActiveUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActiveUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetOffice365ActiveUserDetailWithDateRequestBuilder GetOffice365ActiveUserDetailWithDate(Date date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetOffice365ActiveUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ActiveUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365ActiveUserDetailWithPeriodRequestBuilder GetOffice365ActiveUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ActiveUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365GroupsActivityCountsWithPeriodRequestBuilder GetOffice365GroupsActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetOffice365GroupsActivityDetailWithDateRequestBuilder GetOffice365GroupsActivityDetailWithDate(Date date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetOffice365GroupsActivityDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365GroupsActivityDetailWithPeriodRequestBuilder GetOffice365GroupsActivityDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityFileCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365GroupsActivityFileCountsWithPeriodRequestBuilder GetOffice365GroupsActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityGroupCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365GroupsActivityGroupCountsWithPeriodRequestBuilder GetOffice365GroupsActivityGroupCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityGroupCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365GroupsActivityStorage(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365GroupsActivityStorageWithPeriodRequestBuilder GetOffice365GroupsActivityStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOffice365ServicesUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOffice365ServicesUserCountsWithPeriodRequestBuilder GetOffice365ServicesUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ServicesUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveActivityFileCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveActivityFileCountsWithPeriodRequestBuilder GetOneDriveActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveActivityUserCountsWithPeriodRequestBuilder GetOneDriveActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetOneDriveActivityUserDetailWithDateRequestBuilder GetOneDriveActivityUserDetailWithDate(Date date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetOneDriveActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveActivityUserDetailWithPeriodRequestBuilder GetOneDriveActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveUsageAccountCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveUsageAccountCountsWithPeriodRequestBuilder GetOneDriveUsageAccountCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageAccountCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveUsageAccountDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetOneDriveUsageAccountDetailWithDateRequestBuilder GetOneDriveUsageAccountDetailWithDate(Date date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetOneDriveUsageAccountDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveUsageAccountDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveUsageAccountDetailWithPeriodRequestBuilder GetOneDriveUsageAccountDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageAccountDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveUsageFileCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveUsageFileCountsWithPeriodRequestBuilder GetOneDriveUsageFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getOneDriveUsageStorage(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetOneDriveUsageStorageWithPeriodRequestBuilder GetOneDriveUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
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
            return new GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, printerId, startDateTime, endDateTime);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointActivityFileCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointActivityFileCountsWithPeriodRequestBuilder GetSharePointActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointActivityPages(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointActivityPagesWithPeriodRequestBuilder GetSharePointActivityPagesWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityPagesWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointActivityUserCountsWithPeriodRequestBuilder GetSharePointActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetSharePointActivityUserDetailWithDateRequestBuilder GetSharePointActivityUserDetailWithDate(Date date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetSharePointActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointActivityUserDetailWithPeriodRequestBuilder GetSharePointActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsageDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetSharePointSiteUsageDetailWithDateRequestBuilder GetSharePointSiteUsageDetailWithDate(Date date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetSharePointSiteUsageDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsageDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointSiteUsageDetailWithPeriodRequestBuilder GetSharePointSiteUsageDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsageFileCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointSiteUsageFileCountsWithPeriodRequestBuilder GetSharePointSiteUsageFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsagePages(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointSiteUsagePagesWithPeriodRequestBuilder GetSharePointSiteUsagePagesWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsagePagesWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsageSiteCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointSiteUsageSiteCountsWithPeriodRequestBuilder GetSharePointSiteUsageSiteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageSiteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSharePointSiteUsageStorage(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSharePointSiteUsageStorageWithPeriodRequestBuilder GetSharePointSiteUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessActivityCountsWithPeriodRequestBuilder GetSkypeForBusinessActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessActivityUserCountsWithPeriodRequestBuilder GetSkypeForBusinessActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetSkypeForBusinessActivityUserDetailWithDateRequestBuilder GetSkypeForBusinessActivityUserDetailWithDate(Date date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetSkypeForBusinessActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessActivityUserDetailWithPeriodRequestBuilder GetSkypeForBusinessActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessDeviceUsageDistributionUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriodRequestBuilder GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessDeviceUsageUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessDeviceUsageUserCountsWithPeriodRequestBuilder GetSkypeForBusinessDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessDeviceUsageUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetSkypeForBusinessDeviceUsageUserDetailWithDateRequestBuilder GetSkypeForBusinessDeviceUsageUserDetailWithDate(Date date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetSkypeForBusinessDeviceUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessDeviceUsageUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessDeviceUsageUserDetailWithPeriodRequestBuilder GetSkypeForBusinessDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessOrganizerActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessOrganizerActivityCountsWithPeriodRequestBuilder GetSkypeForBusinessOrganizerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessOrganizerActivityMinuteCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriodRequestBuilder GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessOrganizerActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessOrganizerActivityUserCountsWithPeriodRequestBuilder GetSkypeForBusinessOrganizerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessParticipantActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessParticipantActivityCountsWithPeriodRequestBuilder GetSkypeForBusinessParticipantActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessParticipantActivityMinuteCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriodRequestBuilder GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessParticipantActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessParticipantActivityUserCountsWithPeriodRequestBuilder GetSkypeForBusinessParticipantActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessPeerToPeerActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessPeerToPeerActivityCountsWithPeriodRequestBuilder GetSkypeForBusinessPeerToPeerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessPeerToPeerActivityMinuteCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriodRequestBuilder GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getSkypeForBusinessPeerToPeerActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriodRequestBuilder GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsDeviceUsageDistributionUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsDeviceUsageDistributionUserCountsWithPeriodRequestBuilder GetTeamsDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsDeviceUsageUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsDeviceUsageUserCountsWithPeriodRequestBuilder GetTeamsDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsDeviceUsageUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetTeamsDeviceUsageUserDetailWithDateRequestBuilder GetTeamsDeviceUsageUserDetailWithDate(Date date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetTeamsDeviceUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsDeviceUsageUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsDeviceUsageUserDetailWithPeriodRequestBuilder GetTeamsDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsUserActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsUserActivityCountsWithPeriodRequestBuilder GetTeamsUserActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsUserActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsUserActivityUserCountsWithPeriodRequestBuilder GetTeamsUserActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsUserActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetTeamsUserActivityUserDetailWithDateRequestBuilder GetTeamsUserActivityUserDetailWithDate(Date date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetTeamsUserActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getTeamsUserActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetTeamsUserActivityUserDetailWithPeriodRequestBuilder GetTeamsUserActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
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
            return new GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, userId, startDateTime, endDateTime);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerActivityCountsWithPeriodRequestBuilder GetYammerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerActivityUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerActivityUserCountsWithPeriodRequestBuilder GetYammerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerActivityUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetYammerActivityUserDetailWithDateRequestBuilder GetYammerActivityUserDetailWithDate(Date date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetYammerActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerActivityUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerActivityUserDetailWithPeriodRequestBuilder GetYammerActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerDeviceUsageDistributionUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerDeviceUsageDistributionUserCountsWithPeriodRequestBuilder GetYammerDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerDeviceUsageUserCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerDeviceUsageUserCountsWithPeriodRequestBuilder GetYammerDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerDeviceUsageUserDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetYammerDeviceUsageUserDetailWithDateRequestBuilder GetYammerDeviceUsageUserDetailWithDate(Date date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetYammerDeviceUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerDeviceUsageUserDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerDeviceUsageUserDetailWithPeriodRequestBuilder GetYammerDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerGroupsActivityCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerGroupsActivityCountsWithPeriodRequestBuilder GetYammerGroupsActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerGroupsActivityDetail(date={date})
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetYammerGroupsActivityDetailWithDateRequestBuilder GetYammerGroupsActivityDetailWithDate(Date date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetYammerGroupsActivityDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerGroupsActivityDetail(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerGroupsActivityDetailWithPeriodRequestBuilder GetYammerGroupsActivityDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.getYammerGroupsActivityGroupCounts(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public GetYammerGroupsActivityGroupCountsWithPeriodRequestBuilder GetYammerGroupsActivityGroupCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityGroupCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.managedDeviceEnrollmentFailureDetails()
        /// </summary>
        public ManagedDeviceEnrollmentFailureDetailsRequestBuilder ManagedDeviceEnrollmentFailureDetails() {
            return new ManagedDeviceEnrollmentFailureDetailsRequestBuilder(PathParameters, RequestAdapter);
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
            return new ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder(PathParameters, RequestAdapter, skip, top, filter, skipToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.managedDeviceEnrollmentTopFailures()
        /// </summary>
        public ManagedDeviceEnrollmentTopFailuresRequestBuilder ManagedDeviceEnrollmentTopFailures() {
            return new ManagedDeviceEnrollmentTopFailuresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \reports\microsoft.graph.managedDeviceEnrollmentTopFailures(period='{period}')
        /// <param name="period">Usage: period={period}</param>
        /// </summary>
        public ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder ManagedDeviceEnrollmentTopFailuresWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Update reports
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ReportRoot body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, cancellationToken);
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
