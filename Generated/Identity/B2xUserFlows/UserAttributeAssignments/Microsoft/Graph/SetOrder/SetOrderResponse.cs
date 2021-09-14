using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Identity.B2xUserFlows.UserAttributeAssignments.Microsoft.Graph.SetOrder {
    public class Microsoft.graph.setOrderResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public AssignmentOrder NewAssignmentOrder { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.setOrderResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.setOrderResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"newAssignmentOrder", (o,n) => { (o as Microsoft.graph.setOrderResponse).NewAssignmentOrder = n.GetObjectValue<AssignmentOrder>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AssignmentOrder>("newAssignmentOrder", NewAssignmentOrder);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
