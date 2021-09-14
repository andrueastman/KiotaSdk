using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.DeviceAppManagement {
    public class KeyValuePair : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name for this key-value pair. Possible names are: AdditionalWSFedEndpointCheckResult,  AllowedAuthenticationClassReferencesCheckResult, AlwaysRequireAuthenticationCheckResult,   AutoUpdateEnabledCheckResult, ClaimsProviderNameCheckResult, EncryptClaimsCheckResult,  EncryptedNameIdRequiredCheckResult, MonitoringEnabledCheckResult,NotBeforeSkewCheckResult,  RequestMFAFromClaimsProvidersCheckResult, SignedSamlRequestsRequiredCheckResult, AdditionalAuthenticationRulesCheckResult, TokenLifetimeCheckResult,  DelegationAuthorizationRulesCheckResult, IssuanceAuthorizationRulesCheckResult, IssuanceTransformRulesCheckResult.</summary>
        public string Name { get; set; }
        /// <summary>Value for this key-value pair. Possible result values are 0 (when the validation check passed), 1 (when the validation check failed), or 2 (when the validation check is a warning).</summary>
        public string Value { get; set; }
        /// <summary>
        /// Instantiates a new keyValuePair and sets the default values.
        /// </summary>
        public KeyValuePair() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"name", (o,n) => { (o as KeyValuePair).Name = n.GetStringValue(); } },
                {"value", (o,n) => { (o as KeyValuePair).Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
