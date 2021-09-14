using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Communications.Calls.Microsoft.Graph.Reject {
    public class Microsoft.graph.rejectResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string CallbackUri { get; set; }
        public RejectReason Reason { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.rejectResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.rejectResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"callbackUri", (o,n) => { (o as Microsoft.graph.rejectResponse).CallbackUri = n.GetStringValue(); } },
                {"reason", (o,n) => { (o as Microsoft.graph.rejectResponse).Reason = n.GetObjectValue<RejectReason>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteObjectValue<RejectReason>("reason", Reason);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
