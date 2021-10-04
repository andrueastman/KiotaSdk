using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph.ExternalConnectors {
    public class Property : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> Aliases { get; set; }
        public bool? IsQueryable { get; set; }
        public bool? IsRefinable { get; set; }
        public bool? IsRetrievable { get; set; }
        public bool? IsSearchable { get; set; }
        public List<Label?> Labels { get; set; }
        public string Name { get; set; }
        public PropertyType? Type { get; set; }
        /// <summary>
        /// Instantiates a new property and sets the default values.
        /// </summary>
        public Property() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"aliases", (o,n) => { (o as Property).Aliases = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isQueryable", (o,n) => { (o as Property).IsQueryable = n.GetBoolValue(); } },
                {"isRefinable", (o,n) => { (o as Property).IsRefinable = n.GetBoolValue(); } },
                {"isRetrievable", (o,n) => { (o as Property).IsRetrievable = n.GetBoolValue(); } },
                {"isSearchable", (o,n) => { (o as Property).IsSearchable = n.GetBoolValue(); } },
                {"labels", (o,n) => { (o as Property).Labels = n.GetCollectionOfEnumValues<Label>().ToList(); } },
                {"name", (o,n) => { (o as Property).Name = n.GetStringValue(); } },
                {"type", (o,n) => { (o as Property).Type = n.GetEnumValue<PropertyType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("aliases", Aliases);
            writer.WriteBoolValue("isQueryable", IsQueryable);
            writer.WriteBoolValue("isRefinable", IsRefinable);
            writer.WriteBoolValue("isRetrievable", IsRetrievable);
            writer.WriteBoolValue("isSearchable", IsSearchable);
            writer.WriteCollectionOfEnumValues<Label>("labels", Labels);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<PropertyType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
