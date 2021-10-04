using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PolicyRoot : Entity, IParsable {
        public List<ActivityBasedTimeoutPolicy> ActivityBasedTimeoutPolicies { get; set; }
        public ApiSdk.Models.Microsoft.Graph.AdminConsentRequestPolicy AdminConsentRequestPolicy { get; set; }
        public ApiSdk.Models.Microsoft.Graph.AuthenticationFlowsPolicy AuthenticationFlowsPolicy { get; set; }
        public ApiSdk.Models.Microsoft.Graph.AuthenticationMethodsPolicy AuthenticationMethodsPolicy { get; set; }
        public ApiSdk.Models.Microsoft.Graph.AuthorizationPolicy AuthorizationPolicy { get; set; }
        public List<ClaimsMappingPolicy> ClaimsMappingPolicies { get; set; }
        public List<ConditionalAccessPolicy> ConditionalAccessPolicies { get; set; }
        public List<FeatureRolloutPolicy> FeatureRolloutPolicies { get; set; }
        public List<HomeRealmDiscoveryPolicy> HomeRealmDiscoveryPolicies { get; set; }
        public ApiSdk.Models.Microsoft.Graph.IdentitySecurityDefaultsEnforcementPolicy IdentitySecurityDefaultsEnforcementPolicy { get; set; }
        public List<PermissionGrantPolicy> PermissionGrantPolicies { get; set; }
        public List<TokenIssuancePolicy> TokenIssuancePolicies { get; set; }
        public List<TokenLifetimePolicy> TokenLifetimePolicies { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activityBasedTimeoutPolicies", (o,n) => { (o as PolicyRoot).ActivityBasedTimeoutPolicies = n.GetCollectionOfObjectValues<ActivityBasedTimeoutPolicy>().ToList(); } },
                {"adminConsentRequestPolicy", (o,n) => { (o as PolicyRoot).AdminConsentRequestPolicy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AdminConsentRequestPolicy>(); } },
                {"authenticationFlowsPolicy", (o,n) => { (o as PolicyRoot).AuthenticationFlowsPolicy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AuthenticationFlowsPolicy>(); } },
                {"authenticationMethodsPolicy", (o,n) => { (o as PolicyRoot).AuthenticationMethodsPolicy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AuthenticationMethodsPolicy>(); } },
                {"authorizationPolicy", (o,n) => { (o as PolicyRoot).AuthorizationPolicy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.AuthorizationPolicy>(); } },
                {"claimsMappingPolicies", (o,n) => { (o as PolicyRoot).ClaimsMappingPolicies = n.GetCollectionOfObjectValues<ClaimsMappingPolicy>().ToList(); } },
                {"conditionalAccessPolicies", (o,n) => { (o as PolicyRoot).ConditionalAccessPolicies = n.GetCollectionOfObjectValues<ConditionalAccessPolicy>().ToList(); } },
                {"featureRolloutPolicies", (o,n) => { (o as PolicyRoot).FeatureRolloutPolicies = n.GetCollectionOfObjectValues<FeatureRolloutPolicy>().ToList(); } },
                {"homeRealmDiscoveryPolicies", (o,n) => { (o as PolicyRoot).HomeRealmDiscoveryPolicies = n.GetCollectionOfObjectValues<HomeRealmDiscoveryPolicy>().ToList(); } },
                {"identitySecurityDefaultsEnforcementPolicy", (o,n) => { (o as PolicyRoot).IdentitySecurityDefaultsEnforcementPolicy = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySecurityDefaultsEnforcementPolicy>(); } },
                {"permissionGrantPolicies", (o,n) => { (o as PolicyRoot).PermissionGrantPolicies = n.GetCollectionOfObjectValues<PermissionGrantPolicy>().ToList(); } },
                {"tokenIssuancePolicies", (o,n) => { (o as PolicyRoot).TokenIssuancePolicies = n.GetCollectionOfObjectValues<TokenIssuancePolicy>().ToList(); } },
                {"tokenLifetimePolicies", (o,n) => { (o as PolicyRoot).TokenLifetimePolicies = n.GetCollectionOfObjectValues<TokenLifetimePolicy>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ActivityBasedTimeoutPolicy>("activityBasedTimeoutPolicies", ActivityBasedTimeoutPolicies);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AdminConsentRequestPolicy>("adminConsentRequestPolicy", AdminConsentRequestPolicy);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AuthenticationFlowsPolicy>("authenticationFlowsPolicy", AuthenticationFlowsPolicy);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AuthenticationMethodsPolicy>("authenticationMethodsPolicy", AuthenticationMethodsPolicy);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.AuthorizationPolicy>("authorizationPolicy", AuthorizationPolicy);
            writer.WriteCollectionOfObjectValues<ClaimsMappingPolicy>("claimsMappingPolicies", ClaimsMappingPolicies);
            writer.WriteCollectionOfObjectValues<ConditionalAccessPolicy>("conditionalAccessPolicies", ConditionalAccessPolicies);
            writer.WriteCollectionOfObjectValues<FeatureRolloutPolicy>("featureRolloutPolicies", FeatureRolloutPolicies);
            writer.WriteCollectionOfObjectValues<HomeRealmDiscoveryPolicy>("homeRealmDiscoveryPolicies", HomeRealmDiscoveryPolicies);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.IdentitySecurityDefaultsEnforcementPolicy>("identitySecurityDefaultsEnforcementPolicy", IdentitySecurityDefaultsEnforcementPolicy);
            writer.WriteCollectionOfObjectValues<PermissionGrantPolicy>("permissionGrantPolicies", PermissionGrantPolicies);
            writer.WriteCollectionOfObjectValues<TokenIssuancePolicy>("tokenIssuancePolicies", TokenIssuancePolicies);
            writer.WriteCollectionOfObjectValues<TokenLifetimePolicy>("tokenLifetimePolicies", TokenLifetimePolicies);
        }
    }
}
