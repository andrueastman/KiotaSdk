using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.GroupSettingTemplates.Microsoft.Graph.ValidateProperties {
    public class Microsoft.graph.validatePropertiesResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string DisplayName { get; set; }
        public string EntityType { get; set; }
        public string MailNickname { get; set; }
        public string OnBehalfOfUserId { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.validatePropertiesResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.validatePropertiesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as Microsoft.graph.validatePropertiesResponse).DisplayName = n.GetStringValue(); } },
                {"entityType", (o,n) => { (o as Microsoft.graph.validatePropertiesResponse).EntityType = n.GetStringValue(); } },
                {"mailNickname", (o,n) => { (o as Microsoft.graph.validatePropertiesResponse).MailNickname = n.GetStringValue(); } },
                {"onBehalfOfUserId", (o,n) => { (o as Microsoft.graph.validatePropertiesResponse).OnBehalfOfUserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("entityType", EntityType);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteStringValue("onBehalfOfUserId", OnBehalfOfUserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
