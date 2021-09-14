using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.WeekNum {
    public class Microsoft.graph.weekNumResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json ReturnType { get; set; }
        public Json SerialNumber { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.weekNumResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.weekNumResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"returnType", (o,n) => { (o as Microsoft.graph.weekNumResponse).ReturnType = n.GetObjectValue<Json>(); } },
                {"serialNumber", (o,n) => { (o as Microsoft.graph.weekNumResponse).SerialNumber = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("returnType", ReturnType);
            writer.WriteObjectValue<Json>("serialNumber", SerialNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
