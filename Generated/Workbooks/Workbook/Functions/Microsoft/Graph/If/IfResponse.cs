using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.If {
    public class Microsoft.graph.ifResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json LogicalTest { get; set; }
        public Json ValueIfFalse { get; set; }
        public Json ValueIfTrue { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.ifResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.ifResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"logicalTest", (o,n) => { (o as Microsoft.graph.ifResponse).LogicalTest = n.GetObjectValue<Json>(); } },
                {"valueIfFalse", (o,n) => { (o as Microsoft.graph.ifResponse).ValueIfFalse = n.GetObjectValue<Json>(); } },
                {"valueIfTrue", (o,n) => { (o as Microsoft.graph.ifResponse).ValueIfTrue = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("logicalTest", LogicalTest);
            writer.WriteObjectValue<Json>("valueIfFalse", ValueIfFalse);
            writer.WriteObjectValue<Json>("valueIfTrue", ValueIfTrue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
