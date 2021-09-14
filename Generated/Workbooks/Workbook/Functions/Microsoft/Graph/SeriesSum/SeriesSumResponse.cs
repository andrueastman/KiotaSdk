using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.SeriesSum {
    public class Microsoft.graph.seriesSumResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Coefficients { get; set; }
        public Json M { get; set; }
        public Json N { get; set; }
        public Json X { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.seriesSumResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.seriesSumResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"coefficients", (o,n) => { (o as Microsoft.graph.seriesSumResponse).Coefficients = n.GetObjectValue<Json>(); } },
                {"m", (o,n) => { (o as Microsoft.graph.seriesSumResponse).M = n.GetObjectValue<Json>(); } },
                {"n", (o,n) => { (o as Microsoft.graph.seriesSumResponse).N = n.GetObjectValue<Json>(); } },
                {"x", (o,n) => { (o as Microsoft.graph.seriesSumResponse).X = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("coefficients", Coefficients);
            writer.WriteObjectValue<Json>("m", M);
            writer.WriteObjectValue<Json>("n", N);
            writer.WriteObjectValue<Json>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
