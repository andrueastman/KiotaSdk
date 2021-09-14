using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Quotient {
    public class Microsoft.graph.quotientResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Denominator { get; set; }
        public Json Numerator { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.quotientResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.quotientResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"denominator", (o,n) => { (o as Microsoft.graph.quotientResponse).Denominator = n.GetObjectValue<Json>(); } },
                {"numerator", (o,n) => { (o as Microsoft.graph.quotientResponse).Numerator = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("denominator", Denominator);
            writer.WriteObjectValue<Json>("numerator", Numerator);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
