using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Fvschedule {
    public class Microsoft.graph.fvscheduleResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Principal { get; set; }
        public Json Schedule { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.fvscheduleResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.fvscheduleResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"principal", (o,n) => { (o as Microsoft.graph.fvscheduleResponse).Principal = n.GetObjectValue<Json>(); } },
                {"schedule", (o,n) => { (o as Microsoft.graph.fvscheduleResponse).Schedule = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("principal", Principal);
            writer.WriteObjectValue<Json>("schedule", Schedule);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
