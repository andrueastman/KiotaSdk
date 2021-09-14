using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Microsoft.Graph.Invite {
    public class DriveRecipient : IParsable {
        /// <summary>The alias of the domain object, for cases where an email address is unavailable (e.g. security groups).</summary>
        public string @Alias { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The email address for the recipient, if the recipient has an associated email address.</summary>
        public string Email { get; set; }
        /// <summary>The unique identifier for the recipient in the directory.</summary>
        public string ObjectId { get; set; }
        /// <summary>
        /// Instantiates a new driveRecipient and sets the default values.
        /// </summary>
        public DriveRecipient() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@Alias", (o,n) => { (o as DriveRecipient).@Alias = n.GetStringValue(); } },
                {"email", (o,n) => { (o as DriveRecipient).Email = n.GetStringValue(); } },
                {"objectId", (o,n) => { (o as DriveRecipient).ObjectId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@Alias", @Alias);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("objectId", ObjectId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
