using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.ServicePrincipals.Item.AddTokenSigningCertificate {
    public class SelfSignedCertificateRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string DisplayName { get; set; }
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>
        /// Instantiates a new SelfSignedCertificateRequestBody and sets the default values.
        /// </summary>
        public SelfSignedCertificateRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as SelfSignedCertificateRequestBody).DisplayName = n.GetStringValue(); } },
                {"endDateTime", (o,n) => { (o as SelfSignedCertificateRequestBody).EndDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
