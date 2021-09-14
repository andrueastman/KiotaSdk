using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Names.Microsoft.Graph.AddFormulaLocal {
    public class Microsoft.graph.addFormulaLocalResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Comment { get; set; }
        public string Formula { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.addFormulaLocalResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.addFormulaLocalResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"comment", (o,n) => { (o as Microsoft.graph.addFormulaLocalResponse).Comment = n.GetStringValue(); } },
                {"formula", (o,n) => { (o as Microsoft.graph.addFormulaLocalResponse).Formula = n.GetStringValue(); } },
                {"name", (o,n) => { (o as Microsoft.graph.addFormulaLocalResponse).Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("comment", Comment);
            writer.WriteStringValue("formula", Formula);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
