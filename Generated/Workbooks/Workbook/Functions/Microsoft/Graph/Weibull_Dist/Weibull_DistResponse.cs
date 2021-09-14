using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Weibull_Dist {
    public class Microsoft.graph.weibull_DistResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Alpha { get; set; }
        public Json Beta { get; set; }
        public Json Cumulative { get; set; }
        public Json X { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.weibull_DistResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.weibull_DistResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"alpha", (o,n) => { (o as Microsoft.graph.weibull_DistResponse).Alpha = n.GetObjectValue<Json>(); } },
                {"beta", (o,n) => { (o as Microsoft.graph.weibull_DistResponse).Beta = n.GetObjectValue<Json>(); } },
                {"cumulative", (o,n) => { (o as Microsoft.graph.weibull_DistResponse).Cumulative = n.GetObjectValue<Json>(); } },
                {"x", (o,n) => { (o as Microsoft.graph.weibull_DistResponse).X = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("alpha", Alpha);
            writer.WriteObjectValue<Json>("beta", Beta);
            writer.WriteObjectValue<Json>("cumulative", Cumulative);
            writer.WriteObjectValue<Json>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
