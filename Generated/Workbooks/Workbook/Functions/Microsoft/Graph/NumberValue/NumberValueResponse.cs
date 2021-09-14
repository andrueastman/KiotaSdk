using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.NumberValue {
    public class Microsoft.graph.numberValueResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json DecimalSeparator { get; set; }
        public Json GroupSeparator { get; set; }
        public Json Text { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.numberValueResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.numberValueResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"decimalSeparator", (o,n) => { (o as Microsoft.graph.numberValueResponse).DecimalSeparator = n.GetObjectValue<Json>(); } },
                {"groupSeparator", (o,n) => { (o as Microsoft.graph.numberValueResponse).GroupSeparator = n.GetObjectValue<Json>(); } },
                {"text", (o,n) => { (o as Microsoft.graph.numberValueResponse).Text = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("decimalSeparator", DecimalSeparator);
            writer.WriteObjectValue<Json>("groupSeparator", GroupSeparator);
            writer.WriteObjectValue<Json>("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
