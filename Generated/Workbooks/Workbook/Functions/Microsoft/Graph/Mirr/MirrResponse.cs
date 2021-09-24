using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Mirr {
    public class Microsoft.graph.mirrResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json FinanceRate { get; set; }
        public Json ReinvestRate { get; set; }
        public Json Values { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.mirrResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.mirrResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"financeRate", (o,n) => { (o as Microsoft.graph.mirrResponse).FinanceRate = n.GetObjectValue<Json>(); } },
                {"reinvestRate", (o,n) => { (o as Microsoft.graph.mirrResponse).ReinvestRate = n.GetObjectValue<Json>(); } },
                {"values", (o,n) => { (o as Microsoft.graph.mirrResponse).Values = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("financeRate", FinanceRate);
            writer.WriteObjectValue<Json>("reinvestRate", ReinvestRate);
            writer.WriteObjectValue<Json>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}