using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Pv {
    public class Microsoft.graph.pvResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Fv { get; set; }
        public Json Nper { get; set; }
        public Json Pmt { get; set; }
        public Json Rate { get; set; }
        public Json Type { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.pvResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.pvResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fv", (o,n) => { (o as Microsoft.graph.pvResponse).Fv = n.GetObjectValue<Json>(); } },
                {"nper", (o,n) => { (o as Microsoft.graph.pvResponse).Nper = n.GetObjectValue<Json>(); } },
                {"pmt", (o,n) => { (o as Microsoft.graph.pvResponse).Pmt = n.GetObjectValue<Json>(); } },
                {"rate", (o,n) => { (o as Microsoft.graph.pvResponse).Rate = n.GetObjectValue<Json>(); } },
                {"type", (o,n) => { (o as Microsoft.graph.pvResponse).Type = n.GetObjectValue<Json>(); } },
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
            writer.WriteObjectValue<Json>("pmt", Pmt);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
