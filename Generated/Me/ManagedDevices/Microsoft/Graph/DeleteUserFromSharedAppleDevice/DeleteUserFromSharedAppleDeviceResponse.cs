using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Me.ManagedDevices.Microsoft.Graph.DeleteUserFromSharedAppleDevice {
    public class Microsoft.graph.deleteUserFromSharedAppleDeviceResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.deleteUserFromSharedAppleDeviceResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.deleteUserFromSharedAppleDeviceResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"userPrincipalName", (o,n) => { (o as Microsoft.graph.deleteUserFromSharedAppleDeviceResponse).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
