using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Microsoft.Graph.Checkin {
    public class Microsoft.graph.checkinResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string CheckInAs { get; set; }
        public string Comment { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.checkinResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.checkinResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"checkInAs", (o,n) => { (o as Microsoft.graph.checkinResponse).CheckInAs = n.GetStringValue(); } },
                {"comment", (o,n) => { (o as Microsoft.graph.checkinResponse).Comment = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("checkInAs", CheckInAs);
            writer.WriteStringValue("comment", Comment);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
