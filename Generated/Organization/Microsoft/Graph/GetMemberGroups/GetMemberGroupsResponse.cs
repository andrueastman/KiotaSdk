using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Organization.Microsoft.Graph.GetMemberGroups {
    public class Microsoft.graph.getMemberGroupsResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public bool? SecurityEnabledOnly { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.getMemberGroupsResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.getMemberGroupsResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"securityEnabledOnly", (o,n) => { (o as Microsoft.graph.getMemberGroupsResponse).SecurityEnabledOnly = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("securityEnabledOnly", SecurityEnabledOnly);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
