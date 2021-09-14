using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Identity {
    public class IdentityUserFlow : Entity, IParsable {
        public UserFlowType UserFlowType { get; set; }
        public Float UserFlowTypeVersion { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"userFlowType", (o,n) => { (o as IdentityUserFlow).UserFlowType = n.GetObjectValue<UserFlowType>(); } },
                {"userFlowTypeVersion", (o,n) => { (o as IdentityUserFlow).UserFlowTypeVersion = n.GetObjectValue<Float>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UserFlowType>("userFlowType", UserFlowType);
            writer.WriteObjectValue<Float>("userFlowTypeVersion", UserFlowTypeVersion);
        }
    }
}
