using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Models.Microsoft.Graph.Ediscovery {
    public class TopicModelingSettings : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>To learn more, see Adjust maximum number of themes dynamically.</summary>
        public bool? DynamicallyAdjustTopicCount { get; set; }
        /// <summary>To learn more, see Include numbers in themes.</summary>
        public bool? IgnoreNumbers { get; set; }
        /// <summary>Indicates whether themes is enabled for the case.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>To learn more, see Maximum number of themes.</summary>
        public int? TopicCount { get; set; }
        /// <summary>
        /// Instantiates a new topicModelingSettings and sets the default values.
        /// </summary>
        public TopicModelingSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"dynamicallyAdjustTopicCount", (o,n) => { (o as TopicModelingSettings).DynamicallyAdjustTopicCount = n.GetBoolValue(); } },
                {"ignoreNumbers", (o,n) => { (o as TopicModelingSettings).IgnoreNumbers = n.GetBoolValue(); } },
                {"isEnabled", (o,n) => { (o as TopicModelingSettings).IsEnabled = n.GetBoolValue(); } },
                {"topicCount", (o,n) => { (o as TopicModelingSettings).TopicCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("dynamicallyAdjustTopicCount", DynamicallyAdjustTopicCount);
            writer.WriteBoolValue("ignoreNumbers", IgnoreNumbers);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteIntValue("topicCount", TopicCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
