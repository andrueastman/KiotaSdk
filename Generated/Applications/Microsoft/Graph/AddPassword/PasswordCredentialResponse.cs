using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Applications.Microsoft.Graph.AddPassword {
    public class PasswordCredentialResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public PasswordCredential PasswordCredential { get; set; }
        /// <summary>
        /// Instantiates a new PasswordCredentialResponse and sets the default values.
        /// </summary>
        public PasswordCredentialResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"passwordCredential", (o,n) => { (o as PasswordCredentialResponse).PasswordCredential = n.GetObjectValue<PasswordCredential>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PasswordCredential>("passwordCredential", PasswordCredential);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
