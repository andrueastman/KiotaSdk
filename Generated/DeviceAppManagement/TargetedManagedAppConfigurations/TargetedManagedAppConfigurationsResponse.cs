using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.DeviceAppManagement.TargetedManagedAppConfigurations {
    public class TargetedManagedAppConfigurationsResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<TargetedManagedAppConfiguration> Value { get; set; }
        /// <summary>
        /// Instantiates a new TargetedManagedAppConfigurationsResponse and sets the default values.
        /// </summary>
        public TargetedManagedAppConfigurationsResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as TargetedManagedAppConfigurationsResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as TargetedManagedAppConfigurationsResponse).Value = n.GetCollectionOfObjectValues<TargetedManagedAppConfiguration>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<TargetedManagedAppConfiguration>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}