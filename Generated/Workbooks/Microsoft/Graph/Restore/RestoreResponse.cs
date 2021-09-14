using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Microsoft.Graph.Restore {
    public class Microsoft.graph.restoreResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Name { get; set; }
        public ItemReference ParentReference { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.restoreResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.restoreResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"name", (o,n) => { (o as Microsoft.graph.restoreResponse).Name = n.GetStringValue(); } },
                {"parentReference", (o,n) => { (o as Microsoft.graph.restoreResponse).ParentReference = n.GetObjectValue<ItemReference>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ItemReference>("parentReference", ParentReference);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
