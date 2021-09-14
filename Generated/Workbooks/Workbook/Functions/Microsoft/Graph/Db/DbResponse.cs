using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Db {
    public class Microsoft.graph.dbResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Cost { get; set; }
        public Json Life { get; set; }
        public Json Month { get; set; }
        public Json Period { get; set; }
        public Json Salvage { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.dbResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.dbResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cost", (o,n) => { (o as Microsoft.graph.dbResponse).Cost = n.GetObjectValue<Json>(); } },
                {"life", (o,n) => { (o as Microsoft.graph.dbResponse).Life = n.GetObjectValue<Json>(); } },
                {"month", (o,n) => { (o as Microsoft.graph.dbResponse).Month = n.GetObjectValue<Json>(); } },
                {"period", (o,n) => { (o as Microsoft.graph.dbResponse).Period = n.GetObjectValue<Json>(); } },
                {"salvage", (o,n) => { (o as Microsoft.graph.dbResponse).Salvage = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cost", Cost);
            writer.WriteObjectValue<Json>("life", Life);
            writer.WriteObjectValue<Json>("month", Month);
            writer.WriteObjectValue<Json>("period", Period);
            writer.WriteObjectValue<Json>("salvage", Salvage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
