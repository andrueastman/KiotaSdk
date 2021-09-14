using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.WorkDay_Intl {
    public class Microsoft.graph.workDay_IntlResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Days { get; set; }
        public Json Holidays { get; set; }
        public Json StartDate { get; set; }
        public Json Weekend { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.workDay_IntlResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.workDay_IntlResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"days", (o,n) => { (o as Microsoft.graph.workDay_IntlResponse).Days = n.GetObjectValue<Json>(); } },
                {"holidays", (o,n) => { (o as Microsoft.graph.workDay_IntlResponse).Holidays = n.GetObjectValue<Json>(); } },
                {"startDate", (o,n) => { (o as Microsoft.graph.workDay_IntlResponse).StartDate = n.GetObjectValue<Json>(); } },
                {"weekend", (o,n) => { (o as Microsoft.graph.workDay_IntlResponse).Weekend = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("days", Days);
            writer.WriteObjectValue<Json>("holidays", Holidays);
            writer.WriteObjectValue<Json>("startDate", StartDate);
            writer.WriteObjectValue<Json>("weekend", Weekend);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
