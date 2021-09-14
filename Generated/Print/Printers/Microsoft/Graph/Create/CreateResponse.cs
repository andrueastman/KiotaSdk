using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Print.Printers.Microsoft.Graph.Create {
    public class Microsoft.graph.createResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public PrintCertificateSigningRequest CertificateSigningRequest { get; set; }
        public string ConnectorId { get; set; }
        public string DisplayName { get; set; }
        public bool? HasPhysicalDevice { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string PhysicalDeviceId { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.createResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.createResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"certificateSigningRequest", (o,n) => { (o as Microsoft.graph.createResponse).CertificateSigningRequest = n.GetObjectValue<PrintCertificateSigningRequest>(); } },
                {"connectorId", (o,n) => { (o as Microsoft.graph.createResponse).ConnectorId = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Microsoft.graph.createResponse).DisplayName = n.GetStringValue(); } },
                {"hasPhysicalDevice", (o,n) => { (o as Microsoft.graph.createResponse).HasPhysicalDevice = n.GetBoolValue(); } },
                {"manufacturer", (o,n) => { (o as Microsoft.graph.createResponse).Manufacturer = n.GetStringValue(); } },
                {"model", (o,n) => { (o as Microsoft.graph.createResponse).Model = n.GetStringValue(); } },
                {"physicalDeviceId", (o,n) => { (o as Microsoft.graph.createResponse).PhysicalDeviceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PrintCertificateSigningRequest>("certificateSigningRequest", CertificateSigningRequest);
            writer.WriteStringValue("connectorId", ConnectorId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("hasPhysicalDevice", HasPhysicalDevice);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("physicalDeviceId", PhysicalDeviceId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
