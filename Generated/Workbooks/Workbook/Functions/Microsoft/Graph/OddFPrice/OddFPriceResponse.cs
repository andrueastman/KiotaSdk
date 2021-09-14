using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.OddFPrice {
    public class Microsoft.graph.oddFPriceResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Basis { get; set; }
        public Json FirstCoupon { get; set; }
        public Json Frequency { get; set; }
        public Json Issue { get; set; }
        public Json Maturity { get; set; }
        public Json Rate { get; set; }
        public Json Redemption { get; set; }
        public Json Settlement { get; set; }
        public Json Yld { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.oddFPriceResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.oddFPriceResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"basis", (o,n) => { (o as Microsoft.graph.oddFPriceResponse).Basis = n.GetObjectValue<Json>(); } },
                {"firstCoupon", (o,n) => { (o as Microsoft.graph.oddFPriceResponse).FirstCoupon = n.GetObjectValue<Json>(); } },
                {"frequency", (o,n) => { (o as Microsoft.graph.oddFPriceResponse).Frequency = n.GetObjectValue<Json>(); } },
                {"issue", (o,n) => { (o as Microsoft.graph.oddFPriceResponse).Issue = n.GetObjectValue<Json>(); } },
                {"maturity", (o,n) => { (o as Microsoft.graph.oddFPriceResponse).Maturity = n.GetObjectValue<Json>(); } },
                {"rate", (o,n) => { (o as Microsoft.graph.oddFPriceResponse).Rate = n.GetObjectValue<Json>(); } },
                {"redemption", (o,n) => { (o as Microsoft.graph.oddFPriceResponse).Redemption = n.GetObjectValue<Json>(); } },
                {"settlement", (o,n) => { (o as Microsoft.graph.oddFPriceResponse).Settlement = n.GetObjectValue<Json>(); } },
                {"yld", (o,n) => { (o as Microsoft.graph.oddFPriceResponse).Yld = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("basis", Basis);
            writer.WriteObjectValue<Json>("firstCoupon", FirstCoupon);
            writer.WriteObjectValue<Json>("frequency", Frequency);
            writer.WriteObjectValue<Json>("issue", Issue);
            writer.WriteObjectValue<Json>("maturity", Maturity);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("redemption", Redemption);
            writer.WriteObjectValue<Json>("settlement", Settlement);
            writer.WriteObjectValue<Json>("yld", Yld);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
