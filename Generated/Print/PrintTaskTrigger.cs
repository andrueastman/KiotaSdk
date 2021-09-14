using GraphServiceClient.Identity;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Print {
    public class PrintTaskTrigger : Entity, IParsable {
        /// <summary>The Universal Print event that will cause a new printTask to be triggered. Valid values are described in the following table.</summary>
        public PrintEvent @Event { get; set; }
        public PrintTaskDefinition Definition { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"@Event", (o,n) => { (o as PrintTaskTrigger).@Event = n.GetObjectValue<PrintEvent>(); } },
                {"definition", (o,n) => { (o as PrintTaskTrigger).Definition = n.GetObjectValue<PrintTaskDefinition>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PrintEvent>("@Event", @Event);
            writer.WriteObjectValue<PrintTaskDefinition>("definition", Definition);
        }
    }
}
