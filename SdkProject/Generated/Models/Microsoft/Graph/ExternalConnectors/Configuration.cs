using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Models.Microsoft.Graph.ExternalConnectors {
    public class Configuration : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A collection of application IDs for registered Azure Active Directory apps that are allowed to manage the externalConnection and to index content in the externalConnection.</summary>
        public List<string> AuthorizedAppIds { get; set; }
        /// <summary>
        /// Instantiates a new configuration and sets the default values.
        /// </summary>
        public Configuration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"authorizedAppIds", (o,n) => { (o as Configuration).AuthorizedAppIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("authorizedAppIds", AuthorizedAppIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
