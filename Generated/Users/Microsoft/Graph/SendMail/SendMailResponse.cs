using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Users.Microsoft.Graph.SendMail {
    public class Microsoft.graph.sendMailResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Message Message { get; set; }
        public bool? SaveToSentItems { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.sendMailResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.sendMailResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"message", (o,n) => { (o as Microsoft.graph.sendMailResponse).Message = n.GetObjectValue<Message>(); } },
                {"saveToSentItems", (o,n) => { (o as Microsoft.graph.sendMailResponse).SaveToSentItems = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Message>("message", Message);
            writer.WriteBoolValue("saveToSentItems", SaveToSentItems);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
