using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Communications.Calls.Microsoft.Graph.Redirect {
    public class Microsoft.graph.redirectResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string CallbackUri { get; set; }
        public List<InvitationParticipantInfo> Targets { get; set; }
        public int? Timeout { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.redirectResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.redirectResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"callbackUri", (o,n) => { (o as Microsoft.graph.redirectResponse).CallbackUri = n.GetStringValue(); } },
                {"targets", (o,n) => { (o as Microsoft.graph.redirectResponse).Targets = n.GetCollectionOfObjectValues<InvitationParticipantInfo>().ToList(); } },
                {"timeout", (o,n) => { (o as Microsoft.graph.redirectResponse).Timeout = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteCollectionOfObjectValues<InvitationParticipantInfo>("targets", Targets);
            writer.WriteIntValue("timeout", Timeout);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
