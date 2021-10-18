using ApiSdk.AgreementAcceptances;
using ApiSdk.Agreements;
using ApiSdk.AppCatalogs;
using ApiSdk.Applications;
using ApiSdk.ApplicationTemplates;
using ApiSdk.AuditLogs;
using ApiSdk.AuthenticationMethodConfigurations;
using ApiSdk.AuthenticationMethodsPolicy;
using ApiSdk.Branding;
using ApiSdk.CertificateBasedAuthConfiguration;
using ApiSdk.Chats;
using ApiSdk.Communications;
using ApiSdk.Connections;
using ApiSdk.Contacts;
using ApiSdk.Contracts;
using ApiSdk.DataPolicyOperations;
using ApiSdk.DeviceAppManagement;
using ApiSdk.DeviceManagement;
using ApiSdk.Devices;
using ApiSdk.Directory;
using ApiSdk.DirectoryObjects;
using ApiSdk.DirectoryRoles;
using ApiSdk.DirectoryRoleTemplates;
using ApiSdk.DomainDnsRecords;
using ApiSdk.Domains;
using ApiSdk.Drive;
using ApiSdk.Drives;
using ApiSdk.Education;
using ApiSdk.External;
using ApiSdk.GroupLifecyclePolicies;
using ApiSdk.Groups;
using ApiSdk.GroupSettings;
using ApiSdk.GroupSettingTemplates;
using ApiSdk.Identity;
using ApiSdk.IdentityGovernance;
using ApiSdk.IdentityProviders;
using ApiSdk.InformationProtection;
using ApiSdk.Invitations;
using ApiSdk.Localizations;
using ApiSdk.Me;
using ApiSdk.Oauth2PermissionGrants;
using ApiSdk.Organization;
using ApiSdk.PermissionGrants;
using ApiSdk.Places;
using ApiSdk.Planner;
using ApiSdk.Policies;
using ApiSdk.Print;
using ApiSdk.Reports;
using ApiSdk.RoleManagement;
using ApiSdk.SchemaExtensions;
using ApiSdk.ScopedRoleMemberships;
using ApiSdk.Search;
using ApiSdk.Security;
using ApiSdk.ServicePrincipals;
using ApiSdk.Shares;
using ApiSdk.Sites;
using ApiSdk.SubscribedSkus;
using ApiSdk.Subscriptions;
using ApiSdk.Teams;
using ApiSdk.TeamsTemplates;
using ApiSdk.Teamwork;
using ApiSdk.Users;
using ApiSdk.Workbooks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk {
    /// <summary>The main entry point of the SDK, exposes the configuration and the fluent API.</summary>
    public class GraphClient {
        public AgreementAcceptancesRequestBuilder AgreementAcceptances { get =>
            new AgreementAcceptancesRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public AgreementsRequestBuilder Agreements { get =>
            new AgreementsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public AppCatalogsRequestBuilder AppCatalogs { get =>
            new AppCatalogsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public ApplicationsRequestBuilder Applications { get =>
            new ApplicationsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public ApplicationTemplatesRequestBuilder ApplicationTemplates { get =>
            new ApplicationTemplatesRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public AuditLogsRequestBuilder AuditLogs { get =>
            new AuditLogsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public AuthenticationMethodConfigurationsRequestBuilder AuthenticationMethodConfigurations { get =>
            new AuthenticationMethodConfigurationsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public AuthenticationMethodsPolicyRequestBuilder AuthenticationMethodsPolicy { get =>
            new AuthenticationMethodsPolicyRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public BrandingRequestBuilder Branding { get =>
            new BrandingRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public CertificateBasedAuthConfigurationRequestBuilder CertificateBasedAuthConfiguration { get =>
            new CertificateBasedAuthConfigurationRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public ChatsRequestBuilder Chats { get =>
            new ChatsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public CommunicationsRequestBuilder Communications { get =>
            new CommunicationsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public ConnectionsRequestBuilder Connections { get =>
            new ConnectionsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public ContactsRequestBuilder Contacts { get =>
            new ContactsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public ContractsRequestBuilder Contracts { get =>
            new ContractsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public DataPolicyOperationsRequestBuilder DataPolicyOperations { get =>
            new DataPolicyOperationsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public DeviceAppManagementRequestBuilder DeviceAppManagement { get =>
            new DeviceAppManagementRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public DeviceManagementRequestBuilder DeviceManagement { get =>
            new DeviceManagementRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public DevicesRequestBuilder Devices { get =>
            new DevicesRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public DirectoryRequestBuilder Directory { get =>
            new DirectoryRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public DirectoryObjectsRequestBuilder DirectoryObjects { get =>
            new DirectoryObjectsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public DirectoryRolesRequestBuilder DirectoryRoles { get =>
            new DirectoryRolesRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public DirectoryRoleTemplatesRequestBuilder DirectoryRoleTemplates { get =>
            new DirectoryRoleTemplatesRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public DomainDnsRecordsRequestBuilder DomainDnsRecords { get =>
            new DomainDnsRecordsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public DomainsRequestBuilder Domains { get =>
            new DomainsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public DriveRequestBuilder Drive { get =>
            new DriveRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public EducationRequestBuilder Education { get =>
            new EducationRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public ExternalRequestBuilder External { get =>
            new ExternalRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public GroupLifecyclePoliciesRequestBuilder GroupLifecyclePolicies { get =>
            new GroupLifecyclePoliciesRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public GroupsRequestBuilder Groups { get =>
            new GroupsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public GroupSettingsRequestBuilder GroupSettings { get =>
            new GroupSettingsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public GroupSettingTemplatesRequestBuilder GroupSettingTemplates { get =>
            new GroupSettingTemplatesRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public IdentityRequestBuilder Identity { get =>
            new IdentityRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public IdentityGovernanceRequestBuilder IdentityGovernance { get =>
            new IdentityGovernanceRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public IdentityProvidersRequestBuilder IdentityProviders { get =>
            new IdentityProvidersRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public InformationProtectionRequestBuilder InformationProtection { get =>
            new InformationProtectionRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public InvitationsRequestBuilder Invitations { get =>
            new InvitationsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public LocalizationsRequestBuilder Localizations { get =>
            new LocalizationsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public MeRequestBuilder Me { get =>
            new MeRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants { get =>
            new Oauth2PermissionGrantsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public OrganizationRequestBuilder Organization { get =>
            new OrganizationRequestBuilder(PathSegment , RequestAdapter, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public PermissionGrantsRequestBuilder PermissionGrants { get =>
            new PermissionGrantsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public PlacesRequestBuilder Places { get =>
            new PlacesRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public PlannerRequestBuilder Planner { get =>
            new PlannerRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public PoliciesRequestBuilder Policies { get =>
            new PoliciesRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public PrintRequestBuilder Print { get =>
            new PrintRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public ReportsRequestBuilder Reports { get =>
            new ReportsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public RoleManagementRequestBuilder RoleManagement { get =>
            new RoleManagementRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public SchemaExtensionsRequestBuilder SchemaExtensions { get =>
            new SchemaExtensionsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public ScopedRoleMembershipsRequestBuilder ScopedRoleMemberships { get =>
            new ScopedRoleMembershipsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public SearchRequestBuilder Search { get =>
            new SearchRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public SecurityRequestBuilder Security { get =>
            new SecurityRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public ServicePrincipalsRequestBuilder ServicePrincipals { get =>
            new ServicePrincipalsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public SharesRequestBuilder Shares { get =>
            new SharesRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public SitesRequestBuilder Sites { get =>
            new SitesRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public SubscribedSkusRequestBuilder SubscribedSkus { get =>
            new SubscribedSkusRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public SubscriptionsRequestBuilder Subscriptions { get =>
            new SubscriptionsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public TeamsRequestBuilder Teams { get =>
            new TeamsRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public TeamsTemplatesRequestBuilder TeamsTemplates { get =>
            new TeamsTemplatesRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public TeamworkRequestBuilder Teamwork { get =>
            new TeamworkRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public UsersRequestBuilder Users { get =>
            new UsersRequestBuilder(PathSegment , RequestAdapter, false);
        }
        public WorkbooksRequestBuilder Workbooks { get =>
            new WorkbooksRequestBuilder(PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Instantiates a new GraphClient and sets the default values.
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public GraphClient(IRequestAdapter requestAdapter) {
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "https://graph.microsoft.com/v1.0";
            RequestAdapter = requestAdapter;
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
        }
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
            };
            requestInfo.SetURI(string.Empty, PathSegment, false);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        public async Task GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler);
        }
    }
}
