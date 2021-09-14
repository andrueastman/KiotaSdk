using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.YearFrac {
    public class Microsoft.graph.yearFracResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Basis { get; set; }
        public Json EndDate { get; set; }
        public Json StartDate { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.yearFracResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.yearFracResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"basis", (o,n) => { (o as Microsoft.graph.yearFracResponse).Basis = n.GetObjectValue<Json>(); } },
                {"endDate", (o,n) => { (o as Microsoft.graph.yearFracResponse).EndDate = n.GetObjectValue<Json>(); } },
                {"startDate", (o,n) => { (o as Microsoft.graph.yearFracResponse).StartDate = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("basis", Basis);
            writer.WriteObjectValue<Json>("endDate", EndDate);
            writer.WriteObjectValue<Json>("startDate", StartDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
