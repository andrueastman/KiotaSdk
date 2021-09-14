using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Xirr {
    public class Microsoft.graph.xirrResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Dates { get; set; }
        public Json Guess { get; set; }
        public Json Values { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.xirrResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.xirrResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"dates", (o,n) => { (o as Microsoft.graph.xirrResponse).Dates = n.GetObjectValue<Json>(); } },
                {"guess", (o,n) => { (o as Microsoft.graph.xirrResponse).Guess = n.GetObjectValue<Json>(); } },
                {"values", (o,n) => { (o as Microsoft.graph.xirrResponse).Values = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("dates", Dates);
            writer.WriteObjectValue<Json>("guess", Guess);
            writer.WriteObjectValue<Json>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
