using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Ispmt {
    public class Microsoft.graph.ispmtResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Nper { get; set; }
        public Json Per { get; set; }
        public Json Pv { get; set; }
        public Json Rate { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.ispmtResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.ispmtResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"nper", (o,n) => { (o as Microsoft.graph.ispmtResponse).Nper = n.GetObjectValue<Json>(); } },
                {"per", (o,n) => { (o as Microsoft.graph.ispmtResponse).Per = n.GetObjectValue<Json>(); } },
                {"pv", (o,n) => { (o as Microsoft.graph.ispmtResponse).Pv = n.GetObjectValue<Json>(); } },
                {"rate", (o,n) => { (o as Microsoft.graph.ispmtResponse).Rate = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("nper", Nper);
            writer.WriteObjectValue<Json>("per", Per);
            writer.WriteObjectValue<Json>("pv", Pv);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
