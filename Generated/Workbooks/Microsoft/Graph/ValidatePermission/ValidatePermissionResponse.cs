using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Microsoft.Graph.ValidatePermission {
    public class Microsoft.graph.validatePermissionResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string ChallengeToken { get; set; }
        public string Password { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.validatePermissionResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.validatePermissionResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"challengeToken", (o,n) => { (o as Microsoft.graph.validatePermissionResponse).ChallengeToken = n.GetStringValue(); } },
                {"password", (o,n) => { (o as Microsoft.graph.validatePermissionResponse).Password = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("challengeToken", ChallengeToken);
            writer.WriteStringValue("password", Password);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
