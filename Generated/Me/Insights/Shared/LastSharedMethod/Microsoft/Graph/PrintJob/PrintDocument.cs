using GraphServiceClient.Identity;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Me.Insights.Shared.LastSharedMethod.Microsoft.Graph.PrintJob.Microsoft.Graph {
    public class PrintDocument : Entity, IParsable {
        /// <summary>The document's content (MIME) type. Read-only.</summary>
        public string ContentType { get; set; }
        /// <summary>The document's name. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The document's size in bytes. Read-only.</summary>
        public Int64 Size { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"contentType", (o,n) => { (o as PrintDocument).ContentType = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as PrintDocument).DisplayName = n.GetStringValue(); } },
                {"size", (o,n) => { (o as PrintDocument).Size = n.GetObjectValue<Int64>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<Int64>("size", Size);
        }
    }
}
