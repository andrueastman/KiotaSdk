using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Yield {
    public class Microsoft.graph.yieldResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Basis { get; set; }
        public Json Frequency { get; set; }
        public Json Maturity { get; set; }
        public Json Pr { get; set; }
        public Json Rate { get; set; }
        public Json Redemption { get; set; }
        public Json Settlement { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.yieldResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.yieldResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"basis", (o,n) => { (o as Microsoft.graph.yieldResponse).Basis = n.GetObjectValue<Json>(); } },
                {"frequency", (o,n) => { (o as Microsoft.graph.yieldResponse).Frequency = n.GetObjectValue<Json>(); } },
                {"maturity", (o,n) => { (o as Microsoft.graph.yieldResponse).Maturity = n.GetObjectValue<Json>(); } },
                {"pr", (o,n) => { (o as Microsoft.graph.yieldResponse).Pr = n.GetObjectValue<Json>(); } },
                {"rate", (o,n) => { (o as Microsoft.graph.yieldResponse).Rate = n.GetObjectValue<Json>(); } },
                {"redemption", (o,n) => { (o as Microsoft.graph.yieldResponse).Redemption = n.GetObjectValue<Json>(); } },
                {"settlement", (o,n) => { (o as Microsoft.graph.yieldResponse).Settlement = n.GetObjectValue<Json>(); } },
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
            writer.WriteObjectValue<Json>("maturity", Maturity);
            writer.WriteObjectValue<Json>("pr", Pr);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("redemption", Redemption);
            writer.WriteObjectValue<Json>("settlement", Settlement);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
