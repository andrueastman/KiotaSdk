using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Rank_Avg {
    public class Microsoft.graph.rank_AvgResponse : IParsable {
        public Json @Ref { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Number { get; set; }
        public Json Order { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.rank_AvgResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.rank_AvgResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@Ref", (o,n) => { (o as Microsoft.graph.rank_AvgResponse).@Ref = n.GetObjectValue<Json>(); } },
                {"number", (o,n) => { (o as Microsoft.graph.rank_AvgResponse).Number = n.GetObjectValue<Json>(); } },
                {"order", (o,n) => { (o as Microsoft.graph.rank_AvgResponse).Order = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("@Ref", @Ref);
            writer.WriteObjectValue<Json>("number", Number);
            writer.WriteObjectValue<Json>("order", Order);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
