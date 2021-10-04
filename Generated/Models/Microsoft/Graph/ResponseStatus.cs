using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ResponseStatus : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The response type. Possible values are: None, Organizer, TentativelyAccepted, Accepted, Declined, NotResponded.</summary>
        public ResponseType? Response { get; set; }
        /// <summary>The date and time that the response was returned. It uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? Time { get; set; }
        /// <summary>
        /// Instantiates a new responseStatus and sets the default values.
        /// </summary>
        public ResponseStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"response", (o,n) => { (o as ResponseStatus).Response = n.GetEnumValue<ResponseType>(); } },
                {"time", (o,n) => { (o as ResponseStatus).Time = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ResponseType>("response", Response);
            writer.WriteDateTimeOffsetValue("time", Time);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
