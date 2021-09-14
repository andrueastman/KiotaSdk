using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.DeviceManagement.WindowsAutopilotDeviceIdentities.Microsoft.Graph.UpdateDeviceProperties {
    public class Microsoft.graph.updateDevicePropertiesResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string AddressableUserName { get; set; }
        public string DisplayName { get; set; }
        public string GroupTag { get; set; }
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.updateDevicePropertiesResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.updateDevicePropertiesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"addressableUserName", (o,n) => { (o as Microsoft.graph.updateDevicePropertiesResponse).AddressableUserName = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Microsoft.graph.updateDevicePropertiesResponse).DisplayName = n.GetStringValue(); } },
                {"groupTag", (o,n) => { (o as Microsoft.graph.updateDevicePropertiesResponse).GroupTag = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as Microsoft.graph.updateDevicePropertiesResponse).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("addressableUserName", AddressableUserName);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("groupTag", GroupTag);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
