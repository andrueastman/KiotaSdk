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
            new AgreementAcceptancesRequestBuilder(PathSegment , HttpCore, false);
        }
        public AgreementsRequestBuilder Agreements { get =>
            new (PathSegment , HttpCore, false);
        }
        public AppCatalogsRequestBuilder AppCatalogs { get =>
            new AppCatalogsRequestBuilder(PathSegment , HttpCore, false);
        }
        public ApplicationsRequestBuilder Applications { get =>
            new ApplicationsRequestBuilder(PathSegment , HttpCore, false);
        }
        public ApplicationTemplatesRequestBuilder ApplicationTemplates { get =>
            new ApplicationTemplatesRequestBuilder(PathSegment , HttpCore, false);
        }
        public AuditLogsRequestBuilder AuditLogs { get =>
            new AuditLogsRequestBuilder(PathSegment , HttpCore, false);
        }
        public AuthenticationMethodConfigurationsRequestBuilder AuthenticationMethodConfigurations { get =>
            new AuthenticationMethodConfigurationsRequestBuilder(PathSegment , HttpCore, false);
        }
        public AuthenticationMethodsPolicyRequestBuilder AuthenticationMethodsPolicy { get =>
            new AuthenticationMethodsPolicyRequestBuilder(PathSegment , HttpCore, false);
        }
        public BrandingRequestBuilder Branding { get =>
            new BrandingRequestBuilder(PathSegment , HttpCore, false);
        }
        public CertificateBasedAuthConfigurationRequestBuilder CertificateBasedAuthConfiguration { get =>
            new CertificateBasedAuthConfigurationRequestBuilder(PathSegment , HttpCore, false);
        }
        public ChatsRequestBuilder Chats { get =>
            new ChatsRequestBuilder(PathSegment , HttpCore, false);
        }
        public CommunicationsRequestBuilder Communications { get =>
            new CommunicationsRequestBuilder(PathSegment , HttpCore, false);
        }
        public ConnectionsRequestBuilder Connections { get =>
            new ConnectionsRequestBuilder(PathSegment , HttpCore, false);
        }
        public ContactsRequestBuilder Contacts { get =>
            new ContactsRequestBuilder(PathSegment , HttpCore, false);
        }
        public ContractsRequestBuilder Contracts { get =>
            new ContractsRequestBuilder(PathSegment , HttpCore, false);
        }
        public DataPolicyOperationsRequestBuilder DataPolicyOperations { get =>
            new DataPolicyOperationsRequestBuilder(PathSegment , HttpCore, false);
        }
        public DeviceAppManagementRequestBuilder DeviceAppManagement { get =>
            new DeviceAppManagementRequestBuilder(PathSegment , HttpCore, false);
        }
        public DeviceManagementRequestBuilder DeviceManagement { get =>
            new DeviceManagementRequestBuilder(PathSegment , HttpCore, false);
        }
        public DevicesRequestBuilder Devices { get =>
            new DevicesRequestBuilder(PathSegment , HttpCore, false);
        }
        public DirectoryRequestBuilder Directory { get =>
            new DirectoryRequestBuilder(PathSegment , HttpCore, false);
        }
        public DirectoryObjectsRequestBuilder DirectoryObjects { get =>
            new DirectoryObjectsRequestBuilder(PathSegment , HttpCore, false);
        }
        public DirectoryRolesRequestBuilder DirectoryRoles { get =>
            new DirectoryRolesRequestBuilder(PathSegment , HttpCore, false);
        }
        public DirectoryRoleTemplatesRequestBuilder DirectoryRoleTemplates { get =>
            new DirectoryRoleTemplatesRequestBuilder(PathSegment , HttpCore, false);
        }
        public DomainDnsRecordsRequestBuilder DomainDnsRecords { get =>
            new DomainDnsRecordsRequestBuilder(PathSegment , HttpCore, false);
        }
        public DomainsRequestBuilder Domains { get =>
            new DomainsRequestBuilder(PathSegment , HttpCore, false);
        }
        public DriveRequestBuilder Drive { get =>
            new DriveRequestBuilder(PathSegment , HttpCore, false);
        }
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(PathSegment , HttpCore, false);
        }
        public EducationRequestBuilder Education { get =>
            new EducationRequestBuilder(PathSegment , HttpCore, false);
        }
        public ExternalRequestBuilder External { get =>
            new ExternalRequestBuilder(PathSegment , HttpCore, false);
        }
        public GroupLifecyclePoliciesRequestBuilder GroupLifecyclePolicies { get =>
            new GroupLifecyclePoliciesRequestBuilder(PathSegment , HttpCore, false);
        }
        public GroupsRequestBuilder Groups { get =>
            new GroupsRequestBuilder(PathSegment , HttpCore, false);
        }
        public GroupSettingsRequestBuilder GroupSettings { get =>
            new GroupSettingsRequestBuilder(PathSegment , HttpCore, false);
        }
        public GroupSettingTemplatesRequestBuilder GroupSettingTemplates { get =>
            new GroupSettingTemplatesRequestBuilder(PathSegment , HttpCore, false);
        }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IHttpCore HttpCore { get; set; }
        public IdentityRequestBuilder Identity { get =>
            new IdentityRequestBuilder(PathSegment , HttpCore, false);
        }
        public IdentityGovernanceRequestBuilder IdentityGovernance { get =>
            new IdentityGovernanceRequestBuilder(PathSegment , HttpCore, false);
        }
        public IdentityProvidersRequestBuilder IdentityProviders { get =>
            new IdentityProvidersRequestBuilder(PathSegment , HttpCore, false);
        }
        public InformationProtectionRequestBuilder InformationProtection { get =>
            new InformationProtectionRequestBuilder(PathSegment , HttpCore, false);
        }
        public InvitationsRequestBuilder Invitations { get =>
            new InvitationsRequestBuilder(PathSegment , HttpCore, false);
        }
        public LocalizationsRequestBuilder Localizations { get =>
            new LocalizationsRequestBuilder(PathSegment , HttpCore, false);
        }
        public MeRequestBuilder Me { get =>
            new MeRequestBuilder(PathSegment , HttpCore, false);
        }
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants { get =>
            new Oauth2PermissionGrantsRequestBuilder(PathSegment , HttpCore, false);
        }
        public OrganizationRequestBuilder Organization { get =>
            new OrganizationRequestBuilder(PathSegment , HttpCore, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        public PermissionGrantsRequestBuilder PermissionGrants { get =>
            new PermissionGrantsRequestBuilder(PathSegment , HttpCore, false);
        }
        public PlacesRequestBuilder Places { get =>
            new PlacesRequestBuilder(PathSegment , HttpCore, false);
        }
        public PlannerRequestBuilder Planner { get =>
            new PlannerRequestBuilder(PathSegment , HttpCore, false);
        }
        public PoliciesRequestBuilder Policies { get =>
            new PoliciesRequestBuilder(PathSegment , HttpCore, false);
        }
        public PrintRequestBuilder Print { get =>
            new PrintRequestBuilder(PathSegment , HttpCore, false);
        }
        public ReportsRequestBuilder Reports { get =>
            new ReportsRequestBuilder(PathSegment , HttpCore, false);
        }
        public RoleManagementRequestBuilder RoleManagement { get =>
            new RoleManagementRequestBuilder(PathSegment , HttpCore, false);
        }
        public SchemaExtensionsRequestBuilder SchemaExtensions { get =>
            new SchemaExtensionsRequestBuilder(PathSegment , HttpCore, false);
        }
        public ScopedRoleMembershipsRequestBuilder ScopedRoleMemberships { get =>
            new ScopedRoleMembershipsRequestBuilder(PathSegment , HttpCore, false);
        }
        public SearchRequestBuilder Search { get =>
            new SearchRequestBuilder(PathSegment , HttpCore, false);
        }
        public SecurityRequestBuilder Security { get =>
            new SecurityRequestBuilder(PathSegment , HttpCore, false);
        }
        public ServicePrincipalsRequestBuilder ServicePrincipals { get =>
            new ServicePrincipalsRequestBuilder(PathSegment , HttpCore, false);
        }
        public SharesRequestBuilder Shares { get =>
            new SharesRequestBuilder(PathSegment , HttpCore, false);
        }
        public SitesRequestBuilder Sites { get =>
            new SitesRequestBuilder(PathSegment , HttpCore, false);
        }
        public SubscribedSkusRequestBuilder SubscribedSkus { get =>
            new SubscribedSkusRequestBuilder(PathSegment , HttpCore, false);
        }
        public SubscriptionsRequestBuilder Subscriptions { get =>
            new SubscriptionsRequestBuilder(PathSegment , HttpCore, false);
        }
        public TeamsRequestBuilder Teams { get =>
            new TeamsRequestBuilder(PathSegment , HttpCore, false);
        }
        public TeamsTemplatesRequestBuilder TeamsTemplates { get =>
            new TeamsTemplatesRequestBuilder(PathSegment , HttpCore, false);
        }
        public TeamworkRequestBuilder Teamwork { get =>
            new TeamworkRequestBuilder(PathSegment , HttpCore, false);
        }
        public UsersRequestBuilder Users { get =>
            new UsersRequestBuilder(PathSegment , HttpCore, false);
        }
        public WorkbooksRequestBuilder Workbooks { get =>
            new WorkbooksRequestBuilder(PathSegment , HttpCore, false);
        }
        /// <summary>
        /// Instantiates a new GraphClient and sets the default values.
        /// <param name="httpCore">The http core service to use to execute the requests.</param>
        /// </summary>
        public GraphClient(IHttpCore httpCore) {
            _ = httpCore ?? throw new ArgumentNullException(nameof(httpCore));
            PathSegment = "https://graph.microsoft.com/v1.0";
            HttpCore = httpCore;
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
        }
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = HttpMethod.GET,
            };
            requestInfo.SetURI(string.Empty, PathSegment, false);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddMiddlewareOptions(o?.ToArray());
            return requestInfo;
        }
        public async Task GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IMiddlewareOption> o = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            await HttpCore.SendNoContentAsync(requestInfo, responseHandler);
        }
    }
}
