using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Me.Microsoft.Graph.ChangePassword {
    public class Microsoft.graph.changePasswordResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.changePasswordResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.changePasswordResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"currentPassword", (o,n) => { (o as Microsoft.graph.changePasswordResponse).CurrentPassword = n.GetStringValue(); } },
                {"newPassword", (o,n) => { (o as Microsoft.graph.changePasswordResponse).NewPassword = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("currentPassword", CurrentPassword);
            writer.WriteStringValue("newPassword", NewPassword);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
