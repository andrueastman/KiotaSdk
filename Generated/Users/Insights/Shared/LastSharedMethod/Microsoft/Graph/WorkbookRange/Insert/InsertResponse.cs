using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Users.Insights.Shared.LastSharedMethod.Microsoft.Graph.WorkbookRange.Microsoft.Graph.Insert {
    public class Microsoft.graph.insertResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Shift { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.insertResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.insertResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"shift", (o,n) => { (o as Microsoft.graph.insertResponse).Shift = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("shift", Shift);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
