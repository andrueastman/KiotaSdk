using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Effect {
    public class Microsoft.graph.effectResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json NominalRate { get; set; }
        public Json Npery { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.effectResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.effectResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"nominalRate", (o,n) => { (o as Microsoft.graph.effectResponse).NominalRate = n.GetObjectValue<Json>(); } },
                {"npery", (o,n) => { (o as Microsoft.graph.effectResponse).Npery = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("nominalRate", NominalRate);
            writer.WriteObjectValue<Json>("npery", Npery);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
