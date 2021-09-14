using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Microsoft.Graph.CreateLink {
    public class Microsoft.graph.createLinkResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public DateTimeOffset? ExpirationDateTime { get; set; }
        public string Message { get; set; }
        public string Password { get; set; }
        public string Scope { get; set; }
        public string Type { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.createLinkResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.createLinkResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"expirationDateTime", (o,n) => { (o as Microsoft.graph.createLinkResponse).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"message", (o,n) => { (o as Microsoft.graph.createLinkResponse).Message = n.GetStringValue(); } },
                {"password", (o,n) => { (o as Microsoft.graph.createLinkResponse).Password = n.GetStringValue(); } },
                {"scope", (o,n) => { (o as Microsoft.graph.createLinkResponse).Scope = n.GetStringValue(); } },
                {"type", (o,n) => { (o as Microsoft.graph.createLinkResponse).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("password", Password);
            writer.WriteStringValue("scope", Scope);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
