using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Communications.Calls.Microsoft.Graph.PlayPrompt {
    public class Microsoft.graph.playPromptResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string ClientContext { get; set; }
        public List<Prompt> Prompts { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.playPromptResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.playPromptResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"clientContext", (o,n) => { (o as Microsoft.graph.playPromptResponse).ClientContext = n.GetStringValue(); } },
                {"prompts", (o,n) => { (o as Microsoft.graph.playPromptResponse).Prompts = n.GetCollectionOfObjectValues<Prompt>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteCollectionOfObjectValues<Prompt>("prompts", Prompts);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
