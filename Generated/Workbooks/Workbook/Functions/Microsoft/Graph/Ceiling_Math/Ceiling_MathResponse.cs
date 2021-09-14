using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Ceiling_Math {
    public class Microsoft.graph.ceiling_MathResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Mode { get; set; }
        public Json Number { get; set; }
        public Json Significance { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.ceiling_MathResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.ceiling_MathResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"mode", (o,n) => { (o as Microsoft.graph.ceiling_MathResponse).Mode = n.GetObjectValue<Json>(); } },
                {"number", (o,n) => { (o as Microsoft.graph.ceiling_MathResponse).Number = n.GetObjectValue<Json>(); } },
                {"significance", (o,n) => { (o as Microsoft.graph.ceiling_MathResponse).Significance = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("mode", Mode);
            writer.WriteObjectValue<Json>("number", Number);
            writer.WriteObjectValue<Json>("significance", Significance);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
