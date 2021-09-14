using GraphServiceClient.Identity;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.IdentityGovernance.AppConsent {
    public class Request : Entity, IParsable {
        public string ApprovalId { get; set; }
        public DateTimeOffset? CompletedDateTime { get; set; }
        public IdentitySet CreatedBy { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string CustomData { get; set; }
        public string Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"approvalId", (o,n) => { (o as Request).ApprovalId = n.GetStringValue(); } },
                {"completedDateTime", (o,n) => { (o as Request).CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdBy", (o,n) => { (o as Request).CreatedBy = n.GetObjectValue<IdentitySet>(); } },
                {"createdDateTime", (o,n) => { (o as Request).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customData", (o,n) => { (o as Request).CustomData = n.GetStringValue(); } },
                {"status", (o,n) => { (o as Request).Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("approvalId", ApprovalId);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("customData", CustomData);
            writer.WriteStringValue("status", Status);
        }
    }
}
