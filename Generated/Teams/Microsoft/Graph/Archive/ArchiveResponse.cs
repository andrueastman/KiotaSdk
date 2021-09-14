using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Teams.Microsoft.Graph.Archive {
    public class Microsoft.graph.archiveResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public bool? ShouldSetSpoSiteReadOnlyForMembers { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.archiveResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.archiveResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"shouldSetSpoSiteReadOnlyForMembers", (o,n) => { (o as Microsoft.graph.archiveResponse).ShouldSetSpoSiteReadOnlyForMembers = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("shouldSetSpoSiteReadOnlyForMembers", ShouldSetSpoSiteReadOnlyForMembers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
