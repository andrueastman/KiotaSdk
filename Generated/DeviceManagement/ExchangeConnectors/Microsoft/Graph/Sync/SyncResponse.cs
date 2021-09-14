using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.DeviceManagement.ExchangeConnectors.Microsoft.Graph.Sync {
    public class Microsoft.graph.syncResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public DeviceManagementExchangeConnectorSyncType SyncType { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.syncResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.syncResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"syncType", (o,n) => { (o as Microsoft.graph.syncResponse).SyncType = n.GetObjectValue<DeviceManagementExchangeConnectorSyncType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DeviceManagementExchangeConnectorSyncType>("syncType", SyncType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
