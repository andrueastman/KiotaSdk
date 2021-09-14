using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Standardize {
    public class Microsoft.graph.standardizeResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Mean { get; set; }
        public Json StandardDev { get; set; }
        public Json X { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.standardizeResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.standardizeResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"mean", (o,n) => { (o as Microsoft.graph.standardizeResponse).Mean = n.GetObjectValue<Json>(); } },
                {"standardDev", (o,n) => { (o as Microsoft.graph.standardizeResponse).StandardDev = n.GetObjectValue<Json>(); } },
                {"x", (o,n) => { (o as Microsoft.graph.standardizeResponse).X = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("mean", Mean);
            writer.WriteObjectValue<Json>("standardDev", StandardDev);
            writer.WriteObjectValue<Json>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
