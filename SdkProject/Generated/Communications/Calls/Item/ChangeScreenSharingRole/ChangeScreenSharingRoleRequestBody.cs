using GraphSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Communications.Calls.Item.ChangeScreenSharingRole {
    public class ChangeScreenSharingRoleRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public ScreenSharingRole? Role { get; set; }
        /// <summary>
        /// Instantiates a new changeScreenSharingRoleRequestBody and sets the default values.
        /// </summary>
        public ChangeScreenSharingRoleRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"role", (o,n) => { (o as ChangeScreenSharingRoleRequestBody).Role = n.GetEnumValue<ScreenSharingRole>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ScreenSharingRole>("role", Role);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
