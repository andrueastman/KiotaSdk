using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Tables.Columns.Microsoft.Graph.Add {
    public class Microsoft.graph.addResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public int? Index { get; set; }
        public string Name { get; set; }
        public Json Values { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.addResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.addResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"index", (o,n) => { (o as Microsoft.graph.addResponse).Index = n.GetIntValue(); } },
                {"name", (o,n) => { (o as Microsoft.graph.addResponse).Name = n.GetStringValue(); } },
                {"values", (o,n) => { (o as Microsoft.graph.addResponse).Values = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("index", Index);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<Json>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
