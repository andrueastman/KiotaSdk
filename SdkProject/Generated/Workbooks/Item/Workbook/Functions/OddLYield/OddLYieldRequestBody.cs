using GraphSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Workbooks.Item.Workbook.Functions.OddLYield {
    public class OddLYieldRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Basis { get; set; }
        public Json Frequency { get; set; }
        public Json LastInterest { get; set; }
        public Json Maturity { get; set; }
        public Json Pr { get; set; }
        public Json Rate { get; set; }
        public Json Redemption { get; set; }
        public Json Settlement { get; set; }
        /// <summary>
        /// Instantiates a new oddLYieldRequestBody and sets the default values.
        /// </summary>
        public OddLYieldRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"basis", (o,n) => { (o as OddLYieldRequestBody).Basis = n.GetObjectValue<Json>(); } },
                {"frequency", (o,n) => { (o as OddLYieldRequestBody).Frequency = n.GetObjectValue<Json>(); } },
                {"lastInterest", (o,n) => { (o as OddLYieldRequestBody).LastInterest = n.GetObjectValue<Json>(); } },
                {"maturity", (o,n) => { (o as OddLYieldRequestBody).Maturity = n.GetObjectValue<Json>(); } },
                {"pr", (o,n) => { (o as OddLYieldRequestBody).Pr = n.GetObjectValue<Json>(); } },
                {"rate", (o,n) => { (o as OddLYieldRequestBody).Rate = n.GetObjectValue<Json>(); } },
                {"redemption", (o,n) => { (o as OddLYieldRequestBody).Redemption = n.GetObjectValue<Json>(); } },
                {"settlement", (o,n) => { (o as OddLYieldRequestBody).Settlement = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("basis", Basis);
            writer.WriteObjectValue<Json>("frequency", Frequency);
            writer.WriteObjectValue<Json>("lastInterest", LastInterest);
            writer.WriteObjectValue<Json>("maturity", Maturity);
            writer.WriteObjectValue<Json>("pr", Pr);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("redemption", Redemption);
            writer.WriteObjectValue<Json>("settlement", Settlement);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
