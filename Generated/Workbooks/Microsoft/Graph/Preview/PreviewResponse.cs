using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Microsoft.Graph.Preview {
    public class Microsoft.graph.previewResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Page { get; set; }
        public Double Zoom { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.previewResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.previewResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"page", (o,n) => { (o as Microsoft.graph.previewResponse).Page = n.GetStringValue(); } },
                {"zoom", (o,n) => { (o as Microsoft.graph.previewResponse).Zoom = n.GetObjectValue<Double>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("page", Page);
            writer.WriteObjectValue<Double>("zoom", Zoom);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
