using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Teams.Schedule.Microsoft.Graph.Share {
    public class Microsoft.graph.shareResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public DateTimeOffset? EndDateTime { get; set; }
        public bool? NotifyTeam { get; set; }
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.shareResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.shareResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"endDateTime", (o,n) => { (o as Microsoft.graph.shareResponse).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"notifyTeam", (o,n) => { (o as Microsoft.graph.shareResponse).NotifyTeam = n.GetBoolValue(); } },
                {"startDateTime", (o,n) => { (o as Microsoft.graph.shareResponse).StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteBoolValue("notifyTeam", NotifyTeam);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
