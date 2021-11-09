using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Me.WipeManagedAppRegistrationsByDeviceTag {
    public class WipeManagedAppRegistrationsByDeviceTagRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string DeviceTag { get; set; }
        /// <summary>
        /// Instantiates a new wipeManagedAppRegistrationsByDeviceTagRequestBody and sets the default values.
        /// </summary>
        public WipeManagedAppRegistrationsByDeviceTagRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceTag", (o,n) => { (o as WipeManagedAppRegistrationsByDeviceTagRequestBody).DeviceTag = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("deviceTag", DeviceTag);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}