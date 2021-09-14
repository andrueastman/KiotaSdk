using GraphServiceClient.Connections.Schema;
using GraphServiceClient.Identity;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient {
    public class ExternalConnection : Entity, IParsable {
        public Configuration Configuration { get; set; }
        public string Description { get; set; }
        public List<ExternalItem> Items { get; set; }
        public string Name { get; set; }
        public List<ConnectionOperation> Operations { get; set; }
        public Schema Schema { get; set; }
        public ConnectionState State { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"configuration", (o,n) => { (o as ExternalConnection).Configuration = n.GetObjectValue<Configuration>(); } },
                {"description", (o,n) => { (o as ExternalConnection).Description = n.GetStringValue(); } },
                {"items", (o,n) => { (o as ExternalConnection).Items = n.GetCollectionOfObjectValues<ExternalItem>().ToList(); } },
                {"name", (o,n) => { (o as ExternalConnection).Name = n.GetStringValue(); } },
                {"operations", (o,n) => { (o as ExternalConnection).Operations = n.GetCollectionOfObjectValues<ConnectionOperation>().ToList(); } },
                {"schema", (o,n) => { (o as ExternalConnection).Schema = n.GetObjectValue<Schema>(); } },
                {"state", (o,n) => { (o as ExternalConnection).State = n.GetObjectValue<ConnectionState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Configuration>("configuration", Configuration);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<ExternalItem>("items", Items);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<ConnectionOperation>("operations", Operations);
            writer.WriteObjectValue<Schema>("schema", Schema);
            writer.WriteObjectValue<ConnectionState>("state", State);
        }
    }
}
