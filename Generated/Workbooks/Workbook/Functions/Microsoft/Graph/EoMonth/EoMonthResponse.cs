using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.EoMonth {
    public class Microsoft.graph.eoMonthResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Months { get; set; }
        public Json StartDate { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.eoMonthResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.eoMonthResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"months", (o,n) => { (o as Microsoft.graph.eoMonthResponse).Months = n.GetObjectValue<Json>(); } },
                {"startDate", (o,n) => { (o as Microsoft.graph.eoMonthResponse).StartDate = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("months", Months);
            writer.WriteObjectValue<Json>("startDate", StartDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
