using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Base {
    public class Microsoft.graph.baseResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json MinLength { get; set; }
        public Json Number { get; set; }
        public Json Radix { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.baseResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.baseResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"minLength", (o,n) => { (o as Microsoft.graph.baseResponse).MinLength = n.GetObjectValue<Json>(); } },
                {"number", (o,n) => { (o as Microsoft.graph.baseResponse).Number = n.GetObjectValue<Json>(); } },
                {"radix", (o,n) => { (o as Microsoft.graph.baseResponse).Radix = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("minLength", MinLength);
            writer.WriteObjectValue<Json>("number", Number);
            writer.WriteObjectValue<Json>("radix", Radix);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
