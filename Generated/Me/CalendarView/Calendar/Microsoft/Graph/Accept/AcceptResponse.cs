using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Me.CalendarView.Calendar.CalendarView.Microsoft.Graph.Accept {
    public class Microsoft.graph.acceptResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Comment { get; set; }
        public bool? SendResponse { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.acceptResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.acceptResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"comment", (o,n) => { (o as Microsoft.graph.acceptResponse).Comment = n.GetStringValue(); } },
                {"sendResponse", (o,n) => { (o as Microsoft.graph.acceptResponse).SendResponse = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("comment", Comment);
            writer.WriteBoolValue("sendResponse", SendResponse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
