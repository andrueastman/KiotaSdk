using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.DollarFr {
    public class Microsoft.graph.dollarFrResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json DecimalDollar { get; set; }
        public Json Fraction { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.dollarFrResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.dollarFrResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"decimalDollar", (o,n) => { (o as Microsoft.graph.dollarFrResponse).DecimalDollar = n.GetObjectValue<Json>(); } },
                {"fraction", (o,n) => { (o as Microsoft.graph.dollarFrResponse).Fraction = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("decimalDollar", DecimalDollar);
            writer.WriteObjectValue<Json>("fraction", Fraction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
