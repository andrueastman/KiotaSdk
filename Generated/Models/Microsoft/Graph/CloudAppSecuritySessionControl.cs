using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class CloudAppSecuritySessionControl : ConditionalAccessSessionControl, IParsable {
        /// <summary>Possible values are: mcasConfigured, monitorOnly, blockDownloads. Learn more about these values here: https://docs.microsoft.com/cloud-app-security/proxy-deployment-aad#step-1-create-an-azure-ad-conditional-access-test-policy-</summary>
        public CloudAppSecuritySessionControlType? CloudAppSecurityType { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"cloudAppSecurityType", (o,n) => { (o as CloudAppSecuritySessionControl).CloudAppSecurityType = n.GetEnumValue<CloudAppSecuritySessionControlType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<CloudAppSecuritySessionControlType>("cloudAppSecurityType", CloudAppSecurityType);
        }
    }
}
