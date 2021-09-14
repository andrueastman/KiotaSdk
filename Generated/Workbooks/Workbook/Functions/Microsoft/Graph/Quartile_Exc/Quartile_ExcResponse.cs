using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Quartile_Exc {
    public class Microsoft.graph.quartile_ExcResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Array { get; set; }
        public Json Quart { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.quartile_ExcResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.quartile_ExcResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"array", (o,n) => { (o as Microsoft.graph.quartile_ExcResponse).Array = n.GetObjectValue<Json>(); } },
                {"quart", (o,n) => { (o as Microsoft.graph.quartile_ExcResponse).Quart = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("array", Array);
            writer.WriteObjectValue<Json>("quart", Quart);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
