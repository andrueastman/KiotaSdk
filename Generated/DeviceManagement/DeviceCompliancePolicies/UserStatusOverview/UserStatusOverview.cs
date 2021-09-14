using GraphServiceClient.Identity;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.DeviceManagement.DeviceCompliancePolicies.UserStatusOverview {
    public class UserStatusOverview : Entity, IParsable {
        /// <summary>Version of the policy for that overview</summary>
        public int? ConfigurationVersion { get; set; }
        /// <summary>Number of error Users</summary>
        public int? ErrorCount { get; set; }
        /// <summary>Number of failed Users</summary>
        public int? FailedCount { get; set; }
        /// <summary>Last update time</summary>
        public DateTimeOffset? LastUpdateDateTime { get; set; }
        /// <summary>Number of not applicable users</summary>
        public int? NotApplicableCount { get; set; }
        /// <summary>Number of pending Users</summary>
        public int? PendingCount { get; set; }
        /// <summary>Number of succeeded Users</summary>
        public int? SuccessCount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"configurationVersion", (o,n) => { (o as UserStatusOverview).ConfigurationVersion = n.GetIntValue(); } },
                {"errorCount", (o,n) => { (o as UserStatusOverview).ErrorCount = n.GetIntValue(); } },
                {"failedCount", (o,n) => { (o as UserStatusOverview).FailedCount = n.GetIntValue(); } },
                {"lastUpdateDateTime", (o,n) => { (o as UserStatusOverview).LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"notApplicableCount", (o,n) => { (o as UserStatusOverview).NotApplicableCount = n.GetIntValue(); } },
                {"pendingCount", (o,n) => { (o as UserStatusOverview).PendingCount = n.GetIntValue(); } },
                {"successCount", (o,n) => { (o as UserStatusOverview).SuccessCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("configurationVersion", ConfigurationVersion);
            writer.WriteIntValue("errorCount", ErrorCount);
            writer.WriteIntValue("failedCount", FailedCount);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteIntValue("notApplicableCount", NotApplicableCount);
            writer.WriteIntValue("pendingCount", PendingCount);
            writer.WriteIntValue("successCount", SuccessCount);
        }
    }
}
