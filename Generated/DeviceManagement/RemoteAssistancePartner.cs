using GraphServiceClient.Identity;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.DeviceManagement {
    public class RemoteAssistancePartner : Entity, IParsable {
        /// <summary>Display name of the partner.</summary>
        public string DisplayName { get; set; }
        /// <summary>Timestamp of the last request sent to Intune by the TEM partner.</summary>
        public DateTimeOffset? LastConnectionDateTime { get; set; }
        /// <summary>A friendly description of the current TeamViewer connector status. Possible values are: notOnboarded, onboarding, onboarded.</summary>
        public RemoteAssistanceOnboardingStatus OnboardingStatus { get; set; }
        /// <summary>URL of the partner's onboarding portal, where an administrator can configure their Remote Assistance service.</summary>
        public string OnboardingUrl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as RemoteAssistancePartner).DisplayName = n.GetStringValue(); } },
                {"lastConnectionDateTime", (o,n) => { (o as RemoteAssistancePartner).LastConnectionDateTime = n.GetDateTimeOffsetValue(); } },
                {"onboardingStatus", (o,n) => { (o as RemoteAssistancePartner).OnboardingStatus = n.GetObjectValue<RemoteAssistanceOnboardingStatus>(); } },
                {"onboardingUrl", (o,n) => { (o as RemoteAssistancePartner).OnboardingUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastConnectionDateTime", LastConnectionDateTime);
            writer.WriteObjectValue<RemoteAssistanceOnboardingStatus>("onboardingStatus", OnboardingStatus);
            writer.WriteStringValue("onboardingUrl", OnboardingUrl);
        }
    }
}
