using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.DeviceManagement.DeviceEnrollmentConfigurations.Microsoft.Graph.Assign {
    public class Microsoft.graph.assignResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<EnrollmentConfigurationAssignment> EnrollmentConfigurationAssignments { get; set; }
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
                {"enrollmentConfigurationAssignments", (o,n) => { (o as Microsoft.graph.assignResponse).EnrollmentConfigurationAssignments = n.GetCollectionOfObjectValues<EnrollmentConfigurationAssignment>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<EnrollmentConfigurationAssignment>("enrollmentConfigurationAssignments", EnrollmentConfigurationAssignments);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
