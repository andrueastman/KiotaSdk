using GraphServiceClient.Groups.CalendarView.Attachments.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Users.Events.Attachments.Microsoft.Graph.CreateUploadSession {
    public class Microsoft.graph.createUploadSessionResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public AttachmentItem AttachmentItem { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.createUploadSessionResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.createUploadSessionResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"attachmentItem", (o,n) => { (o as Microsoft.graph.createUploadSessionResponse).AttachmentItem = n.GetObjectValue<AttachmentItem>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AttachmentItem>("attachmentItem", AttachmentItem);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
