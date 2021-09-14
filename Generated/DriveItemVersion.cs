using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient {
    public class DriveItemVersion : BaseItemVersion, IParsable {
        public byte[] Content { get; set; }
        /// <summary>Indicates the size of the content stream for this version of the item.</summary>
        public Int64 Size { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"content", (o,n) => { (o as DriveItemVersion).Content = n.GetObjectValue<Byte[]>(); } },
                {"size", (o,n) => { (o as DriveItemVersion).Size = n.GetObjectValue<Int64>(); } },
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
            writer.WriteObjectValue<Int64>("size", Size);
        }
    }
}
