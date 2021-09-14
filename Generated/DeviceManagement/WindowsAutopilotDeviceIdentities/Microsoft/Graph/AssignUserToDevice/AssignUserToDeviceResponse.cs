using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.DeviceManagement.WindowsAutopilotDeviceIdentities.Microsoft.Graph.AssignUserToDevice {
    public class Microsoft.graph.assignUserToDeviceResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string AddressableUserName { get; set; }
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.assignUserToDeviceResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.assignUserToDeviceResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"addressableUserName", (o,n) => { (o as Microsoft.graph.assignUserToDeviceResponse).AddressableUserName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as Microsoft.graph.assignUserToDeviceResponse).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("addressableUserName", AddressableUserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
