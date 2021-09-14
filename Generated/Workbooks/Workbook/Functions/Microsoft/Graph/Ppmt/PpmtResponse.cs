using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Ppmt {
    public class Microsoft.graph.ppmtResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Fv { get; set; }
        public Json Nper { get; set; }
        public Json Per { get; set; }
        public Json Pv { get; set; }
        public Json Rate { get; set; }
        public Json Type { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.ppmtResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.ppmtResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fv", (o,n) => { (o as Microsoft.graph.ppmtResponse).Fv = n.GetObjectValue<Json>(); } },
                {"nper", (o,n) => { (o as Microsoft.graph.ppmtResponse).Nper = n.GetObjectValue<Json>(); } },
                {"per", (o,n) => { (o as Microsoft.graph.ppmtResponse).Per = n.GetObjectValue<Json>(); } },
                {"pv", (o,n) => { (o as Microsoft.graph.ppmtResponse).Pv = n.GetObjectValue<Json>(); } },
                {"rate", (o,n) => { (o as Microsoft.graph.ppmtResponse).Rate = n.GetObjectValue<Json>(); } },
                {"type", (o,n) => { (o as Microsoft.graph.ppmtResponse).Type = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("fv", Fv);
            writer.WriteObjectValue<Json>("nper", Nper);
            writer.WriteObjectValue<Json>("per", Per);
            writer.WriteObjectValue<Json>("pv", Pv);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
