using GraphSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Workbooks.Item.Workbook.Functions.IntRate {
    public class IntRateRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Basis { get; set; }
        public Json Investment { get; set; }
        public Json Maturity { get; set; }
        public Json Redemption { get; set; }
        public Json Settlement { get; set; }
        /// <summary>
        /// Instantiates a new intRateRequestBody and sets the default values.
        /// </summary>
        public IntRateRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"basis", (o,n) => { (o as IntRateRequestBody).Basis = n.GetObjectValue<Json>(); } },
                {"investment", (o,n) => { (o as IntRateRequestBody).Investment = n.GetObjectValue<Json>(); } },
                {"maturity", (o,n) => { (o as IntRateRequestBody).Maturity = n.GetObjectValue<Json>(); } },
                {"redemption", (o,n) => { (o as IntRateRequestBody).Redemption = n.GetObjectValue<Json>(); } },
                {"settlement", (o,n) => { (o as IntRateRequestBody).Settlement = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("basis", Basis);
            writer.WriteObjectValue<Json>("investment", Investment);
            writer.WriteObjectValue<Json>("maturity", Maturity);
            writer.WriteObjectValue<Json>("redemption", Redemption);
            writer.WriteObjectValue<Json>("settlement", Settlement);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
