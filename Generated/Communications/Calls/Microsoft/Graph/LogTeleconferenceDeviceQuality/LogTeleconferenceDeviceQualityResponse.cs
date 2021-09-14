using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Communications.Calls.Microsoft.Graph.LogTeleconferenceDeviceQuality {
    public class Microsoft.graph.logTeleconferenceDeviceQualityResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public TeleconferenceDeviceQuality Quality { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.logTeleconferenceDeviceQualityResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.logTeleconferenceDeviceQualityResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"quality", (o,n) => { (o as Microsoft.graph.logTeleconferenceDeviceQualityResponse).Quality = n.GetObjectValue<TeleconferenceDeviceQuality>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeleconferenceDeviceQuality>("quality", Quality);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
