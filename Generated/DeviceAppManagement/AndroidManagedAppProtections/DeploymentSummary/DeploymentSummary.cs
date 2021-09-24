using GraphServiceClient.Identity;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.DeviceAppManagement.AndroidManagedAppProtections.DeploymentSummary {
    public class DeploymentSummary : Entity, IParsable {
        /// <summary>Not yet documented</summary>
        public int? ConfigurationDeployedUserCount { get; set; }
        /// <summary>Not yet documented</summary>
        public List<ManagedAppPolicyDeploymentSummaryPerApp> ConfigurationDeploymentSummaryPerApp { get; set; }
        /// <summary>Not yet documented</summary>
        public string DisplayName { get; set; }
        /// <summary>Not yet documented</summary>
        public DateTimeOffset? LastRefreshTime { get; set; }
        /// <summary>Version of the entity.</summary>
        public string Version { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"configurationDeployedUserCount", (o,n) => { (o as DeploymentSummary).ConfigurationDeployedUserCount = n.GetIntValue(); } },
                {"configurationDeploymentSummaryPerApp", (o,n) => { (o as DeploymentSummary).ConfigurationDeploymentSummaryPerApp = n.GetCollectionOfPrimitiveValues<ManagedAppPolicyDeploymentSummaryPerApp>().ToList(); } },
                {"displayName", (o,n) => { (o as DeploymentSummary).DisplayName = n.GetStringValue(); } },
                {"lastRefreshTime", (o,n) => { (o as DeploymentSummary).LastRefreshTime = n.GetDateTimeOffsetValue(); } },
                {"version", (o,n) => { (o as DeploymentSummary).Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("configurationDeployedUserCount", ConfigurationDeployedUserCount);
            writer.WriteCollectionOfPrimitiveValues<ManagedAppPolicyDeploymentSummaryPerApp>("configurationDeploymentSummaryPerApp", ConfigurationDeploymentSummaryPerApp);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastRefreshTime", LastRefreshTime);
            writer.WriteStringValue("version", Version);
        }
    }
}