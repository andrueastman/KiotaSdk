using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Convert {
    public class Microsoft.graph.convertResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json FromUnit { get; set; }
        public Json Number { get; set; }
        public Json ToUnit { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.convertResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.convertResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fromUnit", (o,n) => { (o as Microsoft.graph.convertResponse).FromUnit = n.GetObjectValue<Json>(); } },
                {"number", (o,n) => { (o as Microsoft.graph.convertResponse).Number = n.GetObjectValue<Json>(); } },
                {"toUnit", (o,n) => { (o as Microsoft.graph.convertResponse).ToUnit = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("fromUnit", FromUnit);
            writer.WriteObjectValue<Json>("number", Number);
            writer.WriteObjectValue<Json>("toUnit", ToUnit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
