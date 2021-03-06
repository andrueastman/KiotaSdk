using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Models.Microsoft.Graph {
    public class PasswordCredential : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Do not use.</summary>
        public byte[] CustomKeyIdentifier { get; set; }
        /// <summary>Friendly name for the password. Optional.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>Contains the first three characters of the password. Read-only.</summary>
        public string Hint { get; set; }
        /// <summary>The unique identifier for the password.</summary>
        public string KeyId { get; set; }
        /// <summary>Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.</summary>
        public string SecretText { get; set; }
        /// <summary>The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new passwordCredential and sets the default values.
        /// </summary>
        public PasswordCredential() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"customKeyIdentifier", (o,n) => { (o as PasswordCredential).CustomKeyIdentifier = n.GetByteArrayValue(); } },
                {"displayName", (o,n) => { (o as PasswordCredential).DisplayName = n.GetStringValue(); } },
                {"endDateTime", (o,n) => { (o as PasswordCredential).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"hint", (o,n) => { (o as PasswordCredential).Hint = n.GetStringValue(); } },
                {"keyId", (o,n) => { (o as PasswordCredential).KeyId = n.GetStringValue(); } },
                {"secretText", (o,n) => { (o as PasswordCredential).SecretText = n.GetStringValue(); } },
                {"startDateTime", (o,n) => { (o as PasswordCredential).StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("customKeyIdentifier", CustomKeyIdentifier);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("hint", Hint);
            writer.WriteStringValue("keyId", KeyId);
            writer.WriteStringValue("secretText", SecretText);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
