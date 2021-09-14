using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Time {
    public class Microsoft.graph.timeResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Hour { get; set; }
        public Json Minute { get; set; }
        public Json Second { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.timeResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.timeResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"hour", (o,n) => { (o as Microsoft.graph.timeResponse).Hour = n.GetObjectValue<Json>(); } },
                {"minute", (o,n) => { (o as Microsoft.graph.timeResponse).Minute = n.GetObjectValue<Json>(); } },
                {"second", (o,n) => { (o as Microsoft.graph.timeResponse).Second = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("hour", Hour);
            writer.WriteObjectValue<Json>("minute", Minute);
            writer.WriteObjectValue<Json>("second", Second);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
