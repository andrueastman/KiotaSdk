using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Binom_Dist_Range {
    public class Microsoft.graph.binom_Dist_RangeResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json NumberS { get; set; }
        public Json NumberS2 { get; set; }
        public Json ProbabilityS { get; set; }
        public Json Trials { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.binom_Dist_RangeResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.binom_Dist_RangeResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"numberS", (o,n) => { (o as Microsoft.graph.binom_Dist_RangeResponse).NumberS = n.GetObjectValue<Json>(); } },
                {"numberS2", (o,n) => { (o as Microsoft.graph.binom_Dist_RangeResponse).NumberS2 = n.GetObjectValue<Json>(); } },
                {"probabilityS", (o,n) => { (o as Microsoft.graph.binom_Dist_RangeResponse).ProbabilityS = n.GetObjectValue<Json>(); } },
                {"trials", (o,n) => { (o as Microsoft.graph.binom_Dist_RangeResponse).Trials = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("numberS", NumberS);
            writer.WriteObjectValue<Json>("numberS2", NumberS2);
            writer.WriteObjectValue<Json>("probabilityS", ProbabilityS);
            writer.WriteObjectValue<Json>("trials", Trials);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
