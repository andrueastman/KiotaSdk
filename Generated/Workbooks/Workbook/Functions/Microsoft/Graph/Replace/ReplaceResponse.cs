using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Replace {
    public class Microsoft.graph.replaceResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json NewText { get; set; }
        public Json NumChars { get; set; }
        public Json OldText { get; set; }
        public Json StartNum { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.replaceResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.replaceResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"newText", (o,n) => { (o as Microsoft.graph.replaceResponse).NewText = n.GetObjectValue<Json>(); } },
                {"numChars", (o,n) => { (o as Microsoft.graph.replaceResponse).NumChars = n.GetObjectValue<Json>(); } },
                {"oldText", (o,n) => { (o as Microsoft.graph.replaceResponse).OldText = n.GetObjectValue<Json>(); } },
                {"startNum", (o,n) => { (o as Microsoft.graph.replaceResponse).StartNum = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("newText", NewText);
            writer.WriteObjectValue<Json>("numChars", NumChars);
            writer.WriteObjectValue<Json>("oldText", OldText);
            writer.WriteObjectValue<Json>("startNum", StartNum);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
