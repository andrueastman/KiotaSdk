using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient {
    public class KeyCredential : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Custom key identifier</summary>
        public byte[] CustomKeyIdentifier { get; set; }
        /// <summary>Friendly name for the key. Optional.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date and time at which the credential expires.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>Value for the key credential. Should be a base 64 encoded value.</summary>
        public byte[] Key { get; set; }
        /// <summary>The unique identifier (GUID) for the key.</summary>
        public string KeyId { get; set; }
        /// <summary>The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The type of key credential; for example, 'Symmetric'.</summary>
        public string Type { get; set; }
        /// <summary>A string that describes the purpose for which the key can be used; for example, 'Verify'.</summary>
        public string Usage { get; set; }
        /// <summary>
        /// Instantiates a new keyCredential and sets the default values.
        /// </summary>
        public KeyCredential() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"customKeyIdentifier", (o,n) => { (o as KeyCredential).CustomKeyIdentifier = n.GetObjectValue<Byte[]>(); } },
                {"displayName", (o,n) => { (o as KeyCredential).DisplayName = n.GetStringValue(); } },
                {"endDateTime", (o,n) => { (o as KeyCredential).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"key", (o,n) => { (o as KeyCredential).Key = n.GetObjectValue<Byte[]>(); } },
                {"keyId", (o,n) => { (o as KeyCredential).KeyId = n.GetStringValue(); } },
                {"startDateTime", (o,n) => { (o as KeyCredential).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"type", (o,n) => { (o as KeyCredential).Type = n.GetStringValue(); } },
                {"usage", (o,n) => { (o as KeyCredential).Usage = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Byte[]>("customKeyIdentifier", CustomKeyIdentifier);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteObjectValue<Byte[]>("key", Key);
            writer.WriteStringValue("keyId", KeyId);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("usage", Usage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
