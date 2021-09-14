using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Confidence_T {
    public class Microsoft.graph.confidence_TResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Alpha { get; set; }
        public Json Size { get; set; }
        public Json StandardDev { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.confidence_TResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.confidence_TResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"alpha", (o,n) => { (o as Microsoft.graph.confidence_TResponse).Alpha = n.GetObjectValue<Json>(); } },
                {"size", (o,n) => { (o as Microsoft.graph.confidence_TResponse).Size = n.GetObjectValue<Json>(); } },
                {"standardDev", (o,n) => { (o as Microsoft.graph.confidence_TResponse).StandardDev = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("alpha", Alpha);
            writer.WriteObjectValue<Json>("size", Size);
            writer.WriteObjectValue<Json>("standardDev", StandardDev);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
