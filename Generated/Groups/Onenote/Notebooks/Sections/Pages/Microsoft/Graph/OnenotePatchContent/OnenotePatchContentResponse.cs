using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Groups.Onenote.Notebooks.Sections.Pages.Microsoft.Graph.OnenotePatchContent {
    public class Microsoft.graph.onenotePatchContentResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<OnenotePatchContentCommand> Commands { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.onenotePatchContentResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.onenotePatchContentResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"commands", (o,n) => { (o as Microsoft.graph.onenotePatchContentResponse).Commands = n.GetCollectionOfPrimitiveValues<OnenotePatchContentCommand>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<OnenotePatchContentCommand>("commands", Commands);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
