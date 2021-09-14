using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Erf {
    public class Microsoft.graph.erfResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json LowerLimit { get; set; }
        public Json UpperLimit { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.erfResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.erfResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"lowerLimit", (o,n) => { (o as Microsoft.graph.erfResponse).LowerLimit = n.GetObjectValue<Json>(); } },
                {"upperLimit", (o,n) => { (o as Microsoft.graph.erfResponse).UpperLimit = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("lowerLimit", LowerLimit);
            writer.WriteObjectValue<Json>("upperLimit", UpperLimit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
