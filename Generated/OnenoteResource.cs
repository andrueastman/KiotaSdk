using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient {
    public class OnenoteResource : OnenoteEntityBaseModel, IParsable {
        /// <summary>The content stream</summary>
        public byte[] Content { get; set; }
        /// <summary>The URL for downloading the content</summary>
        public string ContentUrl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"content", (o,n) => { (o as OnenoteResource).Content = n.GetObjectValue<Byte[]>(); } },
                {"contentUrl", (o,n) => { (o as OnenoteResource).ContentUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Byte[]>("content", Content);
            writer.WriteStringValue("contentUrl", ContentUrl);
        }
    }
}
