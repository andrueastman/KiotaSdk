using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Syd {
    public class Microsoft.graph.sydResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Cost { get; set; }
        public Json Life { get; set; }
        public Json Per { get; set; }
        public Json Salvage { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.sydResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.sydResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cost", (o,n) => { (o as Microsoft.graph.sydResponse).Cost = n.GetObjectValue<Json>(); } },
                {"life", (o,n) => { (o as Microsoft.graph.sydResponse).Life = n.GetObjectValue<Json>(); } },
                {"per", (o,n) => { (o as Microsoft.graph.sydResponse).Per = n.GetObjectValue<Json>(); } },
                {"salvage", (o,n) => { (o as Microsoft.graph.sydResponse).Salvage = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cost", Cost);
            writer.WriteObjectValue<Json>("life", Life);
            writer.WriteObjectValue<Json>("per", Per);
            writer.WriteObjectValue<Json>("salvage", Salvage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
