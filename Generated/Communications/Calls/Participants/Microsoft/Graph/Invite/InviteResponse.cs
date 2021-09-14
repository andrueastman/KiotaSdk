using GraphServiceClient.Communications.Calls.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Communications.Calls.Participants.Microsoft.Graph.Invite {
    public class Microsoft.graph.inviteResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string ClientContext { get; set; }
        public List<InvitationParticipantInfo> Participants { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.inviteResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.inviteResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"clientContext", (o,n) => { (o as Microsoft.graph.inviteResponse).ClientContext = n.GetStringValue(); } },
                {"participants", (o,n) => { (o as Microsoft.graph.inviteResponse).Participants = n.GetCollectionOfObjectValues<InvitationParticipantInfo>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteCollectionOfObjectValues<InvitationParticipantInfo>("participants", Participants);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
