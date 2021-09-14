using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.AverageIf {
    public class Microsoft.graph.averageIfResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json AverageRange { get; set; }
        public Json Criteria { get; set; }
        public Json Range { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.averageIfResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.averageIfResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"averageRange", (o,n) => { (o as Microsoft.graph.averageIfResponse).AverageRange = n.GetObjectValue<Json>(); } },
                {"criteria", (o,n) => { (o as Microsoft.graph.averageIfResponse).Criteria = n.GetObjectValue<Json>(); } },
                {"range", (o,n) => { (o as Microsoft.graph.averageIfResponse).Range = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("averageRange", AverageRange);
            writer.WriteObjectValue<Json>("criteria", Criteria);
            writer.WriteObjectValue<Json>("range", Range);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
