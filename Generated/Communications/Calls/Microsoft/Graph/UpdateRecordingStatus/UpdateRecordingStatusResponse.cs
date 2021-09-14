using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Communications.Calls.Microsoft.Graph.UpdateRecordingStatus {
    public class Microsoft.graph.updateRecordingStatusResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string ClientContext { get; set; }
        public RecordingStatus Status { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.updateRecordingStatusResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.updateRecordingStatusResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"clientContext", (o,n) => { (o as Microsoft.graph.updateRecordingStatusResponse).ClientContext = n.GetStringValue(); } },
                {"status", (o,n) => { (o as Microsoft.graph.updateRecordingStatusResponse).Status = n.GetObjectValue<RecordingStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteObjectValue<RecordingStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
