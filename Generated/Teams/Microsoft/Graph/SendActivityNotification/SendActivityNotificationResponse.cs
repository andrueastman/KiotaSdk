using GraphServiceClient.Chats;
using GraphServiceClient.DeviceAppManagement;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Teams.Microsoft.Graph.SendActivityNotification {
    public class Microsoft.graph.sendActivityNotificationResponse : IParsable {
        public string ActivityType { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Int64 ChainId { get; set; }
        public ItemBody PreviewText { get; set; }
        public TeamworkNotificationRecipient Recipient { get; set; }
        public List<KeyValuePair> TemplateParameters { get; set; }
        public TeamworkActivityTopic Topic { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.sendActivityNotificationResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.sendActivityNotificationResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"activityType", (o,n) => { (o as Microsoft.graph.sendActivityNotificationResponse).ActivityType = n.GetStringValue(); } },
                {"chainId", (o,n) => { (o as Microsoft.graph.sendActivityNotificationResponse).ChainId = n.GetObjectValue<Int64>(); } },
                {"previewText", (o,n) => { (o as Microsoft.graph.sendActivityNotificationResponse).PreviewText = n.GetObjectValue<ItemBody>(); } },
                {"recipient", (o,n) => { (o as Microsoft.graph.sendActivityNotificationResponse).Recipient = n.GetObjectValue<TeamworkNotificationRecipient>(); } },
                {"templateParameters", (o,n) => { (o as Microsoft.graph.sendActivityNotificationResponse).TemplateParameters = n.GetCollectionOfObjectValues<KeyValuePair>().ToList(); } },
                {"topic", (o,n) => { (o as Microsoft.graph.sendActivityNotificationResponse).Topic = n.GetObjectValue<TeamworkActivityTopic>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activityType", ActivityType);
            writer.WriteObjectValue<Int64>("chainId", ChainId);
            writer.WriteObjectValue<ItemBody>("previewText", PreviewText);
            writer.WriteObjectValue<TeamworkNotificationRecipient>("recipient", Recipient);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("templateParameters", TemplateParameters);
            writer.WriteObjectValue<TeamworkActivityTopic>("topic", Topic);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
