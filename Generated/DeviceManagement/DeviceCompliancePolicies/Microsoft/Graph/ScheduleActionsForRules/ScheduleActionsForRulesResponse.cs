using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.DeviceManagement.DeviceCompliancePolicies.Microsoft.Graph.ScheduleActionsForRules {
    public class Microsoft.graph.scheduleActionsForRulesResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<DeviceComplianceScheduledActionForRule> DeviceComplianceScheduledActionForRules { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.scheduleActionsForRulesResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.scheduleActionsForRulesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceComplianceScheduledActionForRules", (o,n) => { (o as Microsoft.graph.scheduleActionsForRulesResponse).DeviceComplianceScheduledActionForRules = n.GetCollectionOfObjectValues<DeviceComplianceScheduledActionForRule>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DeviceComplianceScheduledActionForRule>("deviceComplianceScheduledActionForRules", DeviceComplianceScheduledActionForRules);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
