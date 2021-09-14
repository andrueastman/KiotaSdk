using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Midb {
    public class Microsoft.graph.midbResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json NumBytes { get; set; }
        public Json StartNum { get; set; }
        public Json Text { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.midbResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.midbResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"numBytes", (o,n) => { (o as Microsoft.graph.midbResponse).NumBytes = n.GetObjectValue<Json>(); } },
                {"startNum", (o,n) => { (o as Microsoft.graph.midbResponse).StartNum = n.GetObjectValue<Json>(); } },
                {"text", (o,n) => { (o as Microsoft.graph.midbResponse).Text = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("numBytes", NumBytes);
            writer.WriteObjectValue<Json>("startNum", StartNum);
            writer.WriteObjectValue<Json>("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
