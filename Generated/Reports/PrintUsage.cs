using GraphServiceClient.Identity;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Reports {
    public class PrintUsage : Entity, IParsable {
        public Int64 CompletedBlackAndWhiteJobCount { get; set; }
        public Int64 CompletedColorJobCount { get; set; }
        public Int64 IncompleteJobCount { get; set; }
        public string UsageDate { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"completedBlackAndWhiteJobCount", (o,n) => { (o as PrintUsage).CompletedBlackAndWhiteJobCount = n.GetObjectValue<Int64>(); } },
                {"completedColorJobCount", (o,n) => { (o as PrintUsage).CompletedColorJobCount = n.GetObjectValue<Int64>(); } },
                {"incompleteJobCount", (o,n) => { (o as PrintUsage).IncompleteJobCount = n.GetObjectValue<Int64>(); } },
                {"usageDate", (o,n) => { (o as PrintUsage).UsageDate = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Int64>("completedBlackAndWhiteJobCount", CompletedBlackAndWhiteJobCount);
            writer.WriteObjectValue<Int64>("completedColorJobCount", CompletedColorJobCount);
            writer.WriteObjectValue<Int64>("incompleteJobCount", IncompleteJobCount);
            writer.WriteStringValue("usageDate", UsageDate);
        }
    }
}
