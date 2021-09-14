using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Rate {
    public class Microsoft.graph.rateResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Fv { get; set; }
        public Json Guess { get; set; }
        public Json Nper { get; set; }
        public Json Pmt { get; set; }
        public Json Pv { get; set; }
        public Json Type { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.rateResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.rateResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fv", (o,n) => { (o as Microsoft.graph.rateResponse).Fv = n.GetObjectValue<Json>(); } },
                {"guess", (o,n) => { (o as Microsoft.graph.rateResponse).Guess = n.GetObjectValue<Json>(); } },
                {"nper", (o,n) => { (o as Microsoft.graph.rateResponse).Nper = n.GetObjectValue<Json>(); } },
                {"pmt", (o,n) => { (o as Microsoft.graph.rateResponse).Pmt = n.GetObjectValue<Json>(); } },
                {"pv", (o,n) => { (o as Microsoft.graph.rateResponse).Pv = n.GetObjectValue<Json>(); } },
                {"type", (o,n) => { (o as Microsoft.graph.rateResponse).Type = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("fv", Fv);
            writer.WriteObjectValue<Json>("guess", Guess);
            writer.WriteObjectValue<Json>("nper", Nper);
            writer.WriteObjectValue<Json>("pmt", Pmt);
            writer.WriteObjectValue<Json>("pv", Pv);
            writer.WriteObjectValue<Json>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
