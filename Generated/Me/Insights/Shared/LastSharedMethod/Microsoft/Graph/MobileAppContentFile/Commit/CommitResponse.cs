using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Me.Insights.Shared.LastSharedMethod.Microsoft.Graph.MobileAppContentFile.Microsoft.Graph.Commit {
    public class Microsoft.graph.commitResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public FileEncryptionInfo FileEncryptionInfo { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.commitResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.commitResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fileEncryptionInfo", (o,n) => { (o as Microsoft.graph.commitResponse).FileEncryptionInfo = n.GetObjectValue<FileEncryptionInfo>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<FileEncryptionInfo>("fileEncryptionInfo", FileEncryptionInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
