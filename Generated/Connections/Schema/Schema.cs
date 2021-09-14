using GraphServiceClient.Identity;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Connections.Schema {
    public class Schema : Entity, IParsable {
        public string BaseType { get; set; }
        public List<Property> Properties { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"baseType", (o,n) => { (o as Schema).BaseType = n.GetStringValue(); } },
                {"properties", (o,n) => { (o as Schema).Properties = n.GetCollectionOfPrimitiveValues<Property>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("baseType", BaseType);
            writer.WriteCollectionOfPrimitiveValues<Property>("properties", Properties);
        }
    }
}
