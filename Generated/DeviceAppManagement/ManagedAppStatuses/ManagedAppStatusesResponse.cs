using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.DeviceAppManagement.ManagedAppStatuses {
    public class ManagedAppStatusesResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<ManagedAppStatus> Value { get; set; }
        /// <summary>
        /// Instantiates a new ManagedAppStatusesResponse and sets the default values.
        /// </summary>
        public ManagedAppStatusesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as ManagedAppStatusesResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as ManagedAppStatusesResponse).Value = n.GetCollectionOfObjectValues<ManagedAppStatus>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<ManagedAppStatus>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
