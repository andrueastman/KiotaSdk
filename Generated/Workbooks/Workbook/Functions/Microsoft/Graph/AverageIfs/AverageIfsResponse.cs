using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.AverageIfs {
    public class Microsoft.graph.averageIfsResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json AverageRange { get; set; }
        public Json Values { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.averageIfsResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.averageIfsResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"averageRange", (o,n) => { (o as Microsoft.graph.averageIfsResponse).AverageRange = n.GetObjectValue<Json>(); } },
                {"values", (o,n) => { (o as Microsoft.graph.averageIfsResponse).Values = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("averageRange", AverageRange);
            writer.WriteObjectValue<Json>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
