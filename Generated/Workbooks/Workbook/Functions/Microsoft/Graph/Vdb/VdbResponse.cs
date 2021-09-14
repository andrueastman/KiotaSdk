using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Vdb {
    public class Microsoft.graph.vdbResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Cost { get; set; }
        public Json EndPeriod { get; set; }
        public Json Factor { get; set; }
        public Json Life { get; set; }
        public Json NoSwitch { get; set; }
        public Json Salvage { get; set; }
        public Json StartPeriod { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.vdbResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.vdbResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cost", (o,n) => { (o as Microsoft.graph.vdbResponse).Cost = n.GetObjectValue<Json>(); } },
                {"endPeriod", (o,n) => { (o as Microsoft.graph.vdbResponse).EndPeriod = n.GetObjectValue<Json>(); } },
                {"factor", (o,n) => { (o as Microsoft.graph.vdbResponse).Factor = n.GetObjectValue<Json>(); } },
                {"life", (o,n) => { (o as Microsoft.graph.vdbResponse).Life = n.GetObjectValue<Json>(); } },
                {"noSwitch", (o,n) => { (o as Microsoft.graph.vdbResponse).NoSwitch = n.GetObjectValue<Json>(); } },
                {"salvage", (o,n) => { (o as Microsoft.graph.vdbResponse).Salvage = n.GetObjectValue<Json>(); } },
                {"startPeriod", (o,n) => { (o as Microsoft.graph.vdbResponse).StartPeriod = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cost", Cost);
            writer.WriteObjectValue<Json>("endPeriod", EndPeriod);
            writer.WriteObjectValue<Json>("factor", Factor);
            writer.WriteObjectValue<Json>("life", Life);
            writer.WriteObjectValue<Json>("noSwitch", NoSwitch);
            writer.WriteObjectValue<Json>("salvage", Salvage);
            writer.WriteObjectValue<Json>("startPeriod", StartPeriod);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
