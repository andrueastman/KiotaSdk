using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Identity.ConditionalAccess {
    public class ConditionalAccessRoot : Entity, IParsable {
        public List<NamedLocation> NamedLocations { get; set; }
        public List<ConditionalAccessPolicy> Policies { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"namedLocations", (o,n) => { (o as ConditionalAccessRoot).NamedLocations = n.GetCollectionOfObjectValues<NamedLocation>().ToList(); } },
                {"policies", (o,n) => { (o as ConditionalAccessRoot).Policies = n.GetCollectionOfObjectValues<ConditionalAccessPolicy>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<NamedLocation>("namedLocations", NamedLocations);
            writer.WriteCollectionOfObjectValues<ConditionalAccessPolicy>("policies", Policies);
        }
    }
}
