using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Me.Outlook.Microsoft.Graph.SupportedTimeZones() {
    public class Microsoft.graph.supportedTimeZones : IParsable {
        /// <summary>An identifier for the time zone.</summary>
        public string @Alias { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A display string that represents the time zone.</summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.supportedTimeZones and sets the default values.
        /// </summary>
        public Microsoft.graph.supportedTimeZones() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@Alias", (o,n) => { (o as Microsoft.graph.supportedTimeZones).@Alias = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Microsoft.graph.supportedTimeZones).DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@Alias", @Alias);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
