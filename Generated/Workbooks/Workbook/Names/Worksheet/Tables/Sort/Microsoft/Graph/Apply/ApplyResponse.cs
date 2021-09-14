using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Names.Worksheet.Tables.Sort.Microsoft.Graph.Apply {
    public class Microsoft.graph.applyResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<WorkbookSortField> Fields { get; set; }
        public bool? MatchCase { get; set; }
        public string Method { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.applyResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.applyResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fields", (o,n) => { (o as Microsoft.graph.applyResponse).Fields = n.GetCollectionOfPrimitiveValues<WorkbookSortField>().ToList(); } },
                {"matchCase", (o,n) => { (o as Microsoft.graph.applyResponse).MatchCase = n.GetBoolValue(); } },
                {"method", (o,n) => { (o as Microsoft.graph.applyResponse).Method = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<WorkbookSortField>("fields", Fields);
            writer.WriteBoolValue("matchCase", MatchCase);
            writer.WriteStringValue("method", Method);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
