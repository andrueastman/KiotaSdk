using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Tables.Worksheet.Charts.Microsoft.Graph.Add {
    public class Microsoft.graph.addResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string SeriesBy { get; set; }
        public Json SourceData { get; set; }
        public string Type { get; set; }
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
                {"seriesBy", (o,n) => { (o as Microsoft.graph.addResponse).SeriesBy = n.GetStringValue(); } },
                {"sourceData", (o,n) => { (o as Microsoft.graph.addResponse).SourceData = n.GetObjectValue<Json>(); } },
                {"type", (o,n) => { (o as Microsoft.graph.addResponse).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("seriesBy", SeriesBy);
            writer.WriteObjectValue<Json>("sourceData", SourceData);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
