using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Teamwork {
    public class WorkforceIntegration : ChangeTrackedEntity, IParsable {
        /// <summary>API version for the call back URL. Start with 1.</summary>
        public int? ApiVersion { get; set; }
        /// <summary>Name of the workforce integration.</summary>
        public string DisplayName { get; set; }
        /// <summary>The workforce integration encryption resource.</summary>
        public WorkforceIntegrationEncryption Encryption { get; set; }
        /// <summary>Indicates whether this workforce integration is currently active and available.</summary>
        public bool? IsActive { get; set; }
        /// <summary>This property will replace supports in v1.0. We recommend that you use this property instead of supports. The supports property will still be supported in beta for the time being. Possible values are none, shift, swapRequest, openshift, openShiftRequest, userShiftPreferences, offerShiftRequest, timeCard, timeOffReason, timeOff, timeOffRequest and unknownFutureValue. If selecting more than one value, all values must start with the first letter in uppercase.</summary>
        public WorkforceIntegrationSupportedEntities SupportedEntities { get; set; }
        /// <summary>Workforce Integration URL for callbacks from the Shifts service.</summary>
        public string Url { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"apiVersion", (o,n) => { (o as WorkforceIntegration).ApiVersion = n.GetIntValue(); } },
                {"displayName", (o,n) => { (o as WorkforceIntegration).DisplayName = n.GetStringValue(); } },
                {"encryption", (o,n) => { (o as WorkforceIntegration).Encryption = n.GetObjectValue<WorkforceIntegrationEncryption>(); } },
                {"isActive", (o,n) => { (o as WorkforceIntegration).IsActive = n.GetBoolValue(); } },
                {"supportedEntities", (o,n) => { (o as WorkforceIntegration).SupportedEntities = n.GetObjectValue<WorkforceIntegrationSupportedEntities>(); } },
                {"url", (o,n) => { (o as WorkforceIntegration).Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("apiVersion", ApiVersion);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<WorkforceIntegrationEncryption>("encryption", Encryption);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteObjectValue<WorkforceIntegrationSupportedEntities>("supportedEntities", SupportedEntities);
            writer.WriteStringValue("url", Url);
        }
    }
}
