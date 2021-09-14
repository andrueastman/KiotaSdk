using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.LogNorm_Inv {
    public class Microsoft.graph.logNorm_InvResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Mean { get; set; }
        public Json Probability { get; set; }
        public Json StandardDev { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.logNorm_InvResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.logNorm_InvResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"mean", (o,n) => { (o as Microsoft.graph.logNorm_InvResponse).Mean = n.GetObjectValue<Json>(); } },
                {"probability", (o,n) => { (o as Microsoft.graph.logNorm_InvResponse).Probability = n.GetObjectValue<Json>(); } },
                {"standardDev", (o,n) => { (o as Microsoft.graph.logNorm_InvResponse).StandardDev = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("mean", Mean);
            writer.WriteObjectValue<Json>("probability", Probability);
            writer.WriteObjectValue<Json>("standardDev", StandardDev);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
