using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Models.Microsoft.Graph {
    public class UsedInsight : Entity, IParsable {
        /// <summary>Information about when the item was last viewed or modified by the user. Read only.</summary>
        public UsageDetails LastUsed { get; set; }
        /// <summary>Used for navigating to the item that was used. For file attachments, the type is fileAttachment. For linked attachments, the type is driveItem.</summary>
        public Entity Resource { get; set; }
        /// <summary>Reference properties of the used document, such as the url and type of the document. Read-only</summary>
        public ResourceReference ResourceReference { get; set; }
        /// <summary>Properties that you can use to visualize the document in your experience. Read-only</summary>
        public ResourceVisualization ResourceVisualization { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"lastUsed", (o,n) => { (o as UsedInsight).LastUsed = n.GetObjectValue<UsageDetails>(); } },
                {"resource", (o,n) => { (o as UsedInsight).Resource = n.GetObjectValue<Entity>(); } },
                {"resourceReference", (o,n) => { (o as UsedInsight).ResourceReference = n.GetObjectValue<ResourceReference>(); } },
                {"resourceVisualization", (o,n) => { (o as UsedInsight).ResourceVisualization = n.GetObjectValue<ResourceVisualization>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UsageDetails>("lastUsed", LastUsed);
            writer.WriteObjectValue<Entity>("resource", Resource);
            writer.WriteObjectValue<ResourceReference>("resourceReference", ResourceReference);
            writer.WriteObjectValue<ResourceVisualization>("resourceVisualization", ResourceVisualization);
        }
    }
}
