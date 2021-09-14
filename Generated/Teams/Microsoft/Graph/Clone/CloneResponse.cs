using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Teams.Microsoft.Graph.Clone {
    public class Microsoft.graph.cloneResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Classification { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string MailNickname { get; set; }
        public ClonableTeamParts PartsToClone { get; set; }
        public TeamVisibilityType Visibility { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.cloneResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.cloneResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"classification", (o,n) => { (o as Microsoft.graph.cloneResponse).Classification = n.GetStringValue(); } },
                {"description", (o,n) => { (o as Microsoft.graph.cloneResponse).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Microsoft.graph.cloneResponse).DisplayName = n.GetStringValue(); } },
                {"mailNickname", (o,n) => { (o as Microsoft.graph.cloneResponse).MailNickname = n.GetStringValue(); } },
                {"partsToClone", (o,n) => { (o as Microsoft.graph.cloneResponse).PartsToClone = n.GetObjectValue<ClonableTeamParts>(); } },
                {"visibility", (o,n) => { (o as Microsoft.graph.cloneResponse).Visibility = n.GetObjectValue<TeamVisibilityType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("classification", Classification);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteObjectValue<ClonableTeamParts>("partsToClone", PartsToClone);
            writer.WriteObjectValue<TeamVisibilityType>("visibility", Visibility);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
