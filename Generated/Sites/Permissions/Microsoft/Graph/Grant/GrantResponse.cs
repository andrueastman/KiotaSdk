using GraphServiceClient.Workbooks.Microsoft.Graph.Invite;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Sites.Permissions.Microsoft.Graph.Grant {
    public class Microsoft.graph.grantResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<DriveRecipient> Recipients { get; set; }
        public List<string> Roles { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.grantResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.grantResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"recipients", (o,n) => { (o as Microsoft.graph.grantResponse).Recipients = n.GetCollectionOfObjectValues<DriveRecipient>().ToList(); } },
                {"roles", (o,n) => { (o as Microsoft.graph.grantResponse).Roles = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DriveRecipient>("recipients", Recipients);
            writer.WriteCollectionOfPrimitiveValues<string>("roles", Roles);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
