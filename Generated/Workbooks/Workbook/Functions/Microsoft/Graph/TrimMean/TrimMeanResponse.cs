using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.TrimMean {
    public class Microsoft.graph.trimMeanResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Array { get; set; }
        public Json Percent { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.trimMeanResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.trimMeanResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"array", (o,n) => { (o as Microsoft.graph.trimMeanResponse).Array = n.GetObjectValue<Json>(); } },
                {"percent", (o,n) => { (o as Microsoft.graph.trimMeanResponse).Percent = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("array", Array);
            writer.WriteObjectValue<Json>("percent", Percent);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
