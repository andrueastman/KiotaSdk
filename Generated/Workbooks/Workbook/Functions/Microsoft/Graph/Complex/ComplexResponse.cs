using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Complex {
    public class Microsoft.graph.complexResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json INum { get; set; }
        public Json RealNum { get; set; }
        public Json Suffix { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.complexResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.complexResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"iNum", (o,n) => { (o as Microsoft.graph.complexResponse).INum = n.GetObjectValue<Json>(); } },
                {"realNum", (o,n) => { (o as Microsoft.graph.complexResponse).RealNum = n.GetObjectValue<Json>(); } },
                {"suffix", (o,n) => { (o as Microsoft.graph.complexResponse).Suffix = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("iNum", INum);
            writer.WriteObjectValue<Json>("realNum", RealNum);
            writer.WriteObjectValue<Json>("suffix", Suffix);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
