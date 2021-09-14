using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Users.MailFolders.Messages.Microsoft.Graph.CreateReply {
    public class Microsoft.graph.createReplyResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Comment { get; set; }
        public Message Message { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.createReplyResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.createReplyResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"comment", (o,n) => { (o as Microsoft.graph.createReplyResponse).Comment = n.GetStringValue(); } },
                {"message", (o,n) => { (o as Microsoft.graph.createReplyResponse).Message = n.GetObjectValue<Message>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("comment", Comment);
            writer.WriteObjectValue<Message>("message", Message);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
