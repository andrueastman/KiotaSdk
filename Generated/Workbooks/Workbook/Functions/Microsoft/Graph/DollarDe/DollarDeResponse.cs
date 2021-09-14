using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.DollarDe {
    public class Microsoft.graph.dollarDeResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Fraction { get; set; }
        public Json FractionalDollar { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.dollarDeResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.dollarDeResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fraction", (o,n) => { (o as Microsoft.graph.dollarDeResponse).Fraction = n.GetObjectValue<Json>(); } },
                {"fractionalDollar", (o,n) => { (o as Microsoft.graph.dollarDeResponse).FractionalDollar = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("fraction", Fraction);
            writer.WriteObjectValue<Json>("fractionalDollar", FractionalDollar);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
