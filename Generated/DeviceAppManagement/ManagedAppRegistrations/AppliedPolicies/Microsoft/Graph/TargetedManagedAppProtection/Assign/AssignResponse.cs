using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.DeviceAppManagement.ManagedAppRegistrations.AppliedPolicies.Microsoft.Graph.TargetedManagedAppProtection.Microsoft.Graph.Assign {
    public class Microsoft.graph.assignResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<TargetedManagedAppPolicyAssignment> Assignments { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.assignResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.assignResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignments", (o,n) => { (o as Microsoft.graph.assignResponse).Assignments = n.GetCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>("assignments", Assignments);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
