using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Communications.Calls.Microsoft.Graph.Transfer {
    public class Microsoft.graph.transferResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public InvitationParticipantInfo TransferTarget { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.transferResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.transferResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"transferTarget", (o,n) => { (o as Microsoft.graph.transferResponse).TransferTarget = n.GetObjectValue<InvitationParticipantInfo>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<InvitationParticipantInfo>("transferTarget", TransferTarget);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
