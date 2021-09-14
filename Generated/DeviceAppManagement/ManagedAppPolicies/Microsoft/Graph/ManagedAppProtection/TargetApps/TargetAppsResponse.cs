using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.DeviceAppManagement.ManagedAppPolicies.Microsoft.Graph.ManagedAppProtection.Microsoft.Graph.TargetApps {
    public class Microsoft.graph.targetAppsResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<ManagedMobileApp> Apps { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.targetAppsResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.targetAppsResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"apps", (o,n) => { (o as Microsoft.graph.targetAppsResponse).Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
