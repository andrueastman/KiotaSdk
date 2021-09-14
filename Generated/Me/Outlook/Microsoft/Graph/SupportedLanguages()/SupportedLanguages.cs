using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Me.Outlook.Microsoft.Graph.SupportedLanguages() {
    public class Microsoft.graph.supportedLanguages : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A name representing the user's locale in natural language, for example, 'English (United States)'.</summary>
        public string DisplayName { get; set; }
        /// <summary>A locale representation for the user, which includes the user's preferred language and country/region. For example, 'en-us'. The language component follows 2-letter codes as defined in ISO 639-1, and the country component follows 2-letter codes as defined in ISO 3166-1 alpha-2.</summary>
        public string Locale { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.supportedLanguages and sets the default values.
        /// </summary>
        public Microsoft.graph.supportedLanguages() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as Microsoft.graph.supportedLanguages).DisplayName = n.GetStringValue(); } },
                {"locale", (o,n) => { (o as Microsoft.graph.supportedLanguages).Locale = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("locale", Locale);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
