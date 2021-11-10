using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Models.Microsoft.Graph.Ediscovery {
    public class RedundancyDetectionSettings : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether email threading and near duplicate detection are enabled.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>See Minimum/maximum number of words to learn more.</summary>
        public int? MaxWords { get; set; }
        /// <summary>See Minimum/maximum number of words to learn more.</summary>
        public int? MinWords { get; set; }
        /// <summary>See Document and email similarity threshold to learn more.</summary>
        public int? SimilarityThreshold { get; set; }
        /// <summary>
        /// Instantiates a new redundancyDetectionSettings and sets the default values.
        /// </summary>
        public RedundancyDetectionSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isEnabled", (o,n) => { (o as RedundancyDetectionSettings).IsEnabled = n.GetBoolValue(); } },
                {"maxWords", (o,n) => { (o as RedundancyDetectionSettings).MaxWords = n.GetIntValue(); } },
                {"minWords", (o,n) => { (o as RedundancyDetectionSettings).MinWords = n.GetIntValue(); } },
                {"similarityThreshold", (o,n) => { (o as RedundancyDetectionSettings).SimilarityThreshold = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteIntValue("maxWords", MaxWords);
            writer.WriteIntValue("minWords", MinWords);
            writer.WriteIntValue("similarityThreshold", SimilarityThreshold);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
