using GraphServiceClient.AuthenticationMethodsPolicy;
using GraphServiceClient.Identity;
using GraphServiceClient.Policies.AdminConsentRequestPolicy;
using GraphServiceClient.Policies.AuthenticationFlowsPolicy;
using GraphServiceClient.Policies.AuthorizationPolicy;
using GraphServiceClient.Policies.IdentitySecurityDefaultsEnforcementPolicy;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Policies.PermissionGrantPolicies {
    public class Policies : Entity, IParsable {
        public List<ActivityBasedTimeoutPolicy> ActivityBasedTimeoutPolicies { get; set; }
        public AdminConsentRequestPolicy AdminConsentRequestPolicy { get; set; }
        public AuthenticationFlowsPolicy AuthenticationFlowsPolicy { get; set; }
        public AuthenticationMethodsPolicy AuthenticationMethodsPolicy { get; set; }
        public AuthorizationPolicy AuthorizationPolicy { get; set; }
        public List<ClaimsMappingPolicy> ClaimsMappingPolicies { get; set; }
        public List<ConditionalAccessPolicy> ConditionalAccessPolicies { get; set; }
        public List<FeatureRolloutPolicy> FeatureRolloutPolicies { get; set; }
        public List<HomeRealmDiscoveryPolicy> HomeRealmDiscoveryPolicies { get; set; }
        public IdentitySecurityDefaultsEnforcementPolicy IdentitySecurityDefaultsEnforcementPolicy { get; set; }
        public List<PermissionGrantPolicy> PermissionGrantPolicies { get; set; }
        public List<TokenIssuancePolicy> TokenIssuancePolicies { get; set; }
        public List<TokenLifetimePolicy> TokenLifetimePolicies { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activityBasedTimeoutPolicies", (o,n) => { (o as Policies).ActivityBasedTimeoutPolicies = n.GetCollectionOfObjectValues<ActivityBasedTimeoutPolicy>().ToList(); } },
                {"adminConsentRequestPolicy", (o,n) => { (o as Policies).AdminConsentRequestPolicy = n.GetObjectValue<AdminConsentRequestPolicy>(); } },
                {"authenticationFlowsPolicy", (o,n) => { (o as Policies).AuthenticationFlowsPolicy = n.GetObjectValue<AuthenticationFlowsPolicy>(); } },
                {"authenticationMethodsPolicy", (o,n) => { (o as Policies).AuthenticationMethodsPolicy = n.GetObjectValue<AuthenticationMethodsPolicy>(); } },
                {"authorizationPolicy", (o,n) => { (o as Policies).AuthorizationPolicy = n.GetObjectValue<AuthorizationPolicy>(); } },
                {"claimsMappingPolicies", (o,n) => { (o as Policies).ClaimsMappingPolicies = n.GetCollectionOfObjectValues<ClaimsMappingPolicy>().ToList(); } },
                {"conditionalAccessPolicies", (o,n) => { (o as Policies).ConditionalAccessPolicies = n.GetCollectionOfObjectValues<ConditionalAccessPolicy>().ToList(); } },
                {"featureRolloutPolicies", (o,n) => { (o as Policies).FeatureRolloutPolicies = n.GetCollectionOfObjectValues<FeatureRolloutPolicy>().ToList(); } },
                {"homeRealmDiscoveryPolicies", (o,n) => { (o as Policies).HomeRealmDiscoveryPolicies = n.GetCollectionOfObjectValues<HomeRealmDiscoveryPolicy>().ToList(); } },
                {"identitySecurityDefaultsEnforcementPolicy", (o,n) => { (o as Policies).IdentitySecurityDefaultsEnforcementPolicy = n.GetObjectValue<IdentitySecurityDefaultsEnforcementPolicy>(); } },
                {"permissionGrantPolicies", (o,n) => { (o as Policies).PermissionGrantPolicies = n.GetCollectionOfObjectValues<PermissionGrantPolicy>().ToList(); } },
                {"tokenIssuancePolicies", (o,n) => { (o as Policies).TokenIssuancePolicies = n.GetCollectionOfObjectValues<TokenIssuancePolicy>().ToList(); } },
                {"tokenLifetimePolicies", (o,n) => { (o as Policies).TokenLifetimePolicies = n.GetCollectionOfObjectValues<TokenLifetimePolicy>().ToList(); } },
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
            writer.WriteObjectValue<AdminConsentRequestPolicy>("adminConsentRequestPolicy", AdminConsentRequestPolicy);
            writer.WriteObjectValue<AuthenticationFlowsPolicy>("authenticationFlowsPolicy", AuthenticationFlowsPolicy);
            writer.WriteObjectValue<AuthenticationMethodsPolicy>("authenticationMethodsPolicy", AuthenticationMethodsPolicy);
            writer.WriteObjectValue<AuthorizationPolicy>("authorizationPolicy", AuthorizationPolicy);
            writer.WriteCollectionOfObjectValues<ClaimsMappingPolicy>("claimsMappingPolicies", ClaimsMappingPolicies);
            writer.WriteCollectionOfObjectValues<ConditionalAccessPolicy>("conditionalAccessPolicies", ConditionalAccessPolicies);
            writer.WriteCollectionOfObjectValues<FeatureRolloutPolicy>("featureRolloutPolicies", FeatureRolloutPolicies);
            writer.WriteCollectionOfObjectValues<HomeRealmDiscoveryPolicy>("homeRealmDiscoveryPolicies", HomeRealmDiscoveryPolicies);
            writer.WriteObjectValue<IdentitySecurityDefaultsEnforcementPolicy>("identitySecurityDefaultsEnforcementPolicy", IdentitySecurityDefaultsEnforcementPolicy);
            writer.WriteCollectionOfObjectValues<PermissionGrantPolicy>("permissionGrantPolicies", PermissionGrantPolicies);
            writer.WriteCollectionOfObjectValues<TokenIssuancePolicy>("tokenIssuancePolicies", TokenIssuancePolicies);
            writer.WriteCollectionOfObjectValues<TokenLifetimePolicy>("tokenLifetimePolicies", TokenLifetimePolicies);
        }
    }
}
