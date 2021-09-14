using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Substitute {
    public class Microsoft.graph.substituteResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json InstanceNum { get; set; }
        public Json NewText { get; set; }
        public Json OldText { get; set; }
        public Json Text { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.substituteResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.substituteResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"instanceNum", (o,n) => { (o as Microsoft.graph.substituteResponse).InstanceNum = n.GetObjectValue<Json>(); } },
                {"newText", (o,n) => { (o as Microsoft.graph.substituteResponse).NewText = n.GetObjectValue<Json>(); } },
                {"oldText", (o,n) => { (o as Microsoft.graph.substituteResponse).OldText = n.GetObjectValue<Json>(); } },
                {"text", (o,n) => { (o as Microsoft.graph.substituteResponse).Text = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("instanceNum", InstanceNum);
            writer.WriteObjectValue<Json>("newText", NewText);
            writer.WriteObjectValue<Json>("oldText", OldText);
            writer.WriteObjectValue<Json>("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
