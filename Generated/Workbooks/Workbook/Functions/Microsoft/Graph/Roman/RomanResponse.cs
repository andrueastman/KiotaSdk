using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Roman {
    public class Microsoft.graph.romanResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Form { get; set; }
        public Json Number { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.romanResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.romanResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"form", (o,n) => { (o as Microsoft.graph.romanResponse).Form = n.GetObjectValue<Json>(); } },
                {"number", (o,n) => { (o as Microsoft.graph.romanResponse).Number = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("form", Form);
            writer.WriteObjectValue<Json>("number", Number);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
