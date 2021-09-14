using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Z_Test {
    public class Microsoft.graph.z_TestResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Array { get; set; }
        public Json Sigma { get; set; }
        public Json X { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.z_TestResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.z_TestResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"array", (o,n) => { (o as Microsoft.graph.z_TestResponse).Array = n.GetObjectValue<Json>(); } },
                {"sigma", (o,n) => { (o as Microsoft.graph.z_TestResponse).Sigma = n.GetObjectValue<Json>(); } },
                {"x", (o,n) => { (o as Microsoft.graph.z_TestResponse).X = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("array", Array);
            writer.WriteObjectValue<Json>("sigma", Sigma);
            writer.WriteObjectValue<Json>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
