using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Identity.ApiConnectors.Microsoft.Graph.UploadClientCertificate {
    public class Microsoft.graph.uploadClientCertificateResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Password { get; set; }
        public string Pkcs12Value { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.uploadClientCertificateResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.uploadClientCertificateResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"password", (o,n) => { (o as Microsoft.graph.uploadClientCertificateResponse).Password = n.GetStringValue(); } },
                {"pkcs12Value", (o,n) => { (o as Microsoft.graph.uploadClientCertificateResponse).Pkcs12Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("password", Password);
            writer.WriteStringValue("pkcs12Value", Pkcs12Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
