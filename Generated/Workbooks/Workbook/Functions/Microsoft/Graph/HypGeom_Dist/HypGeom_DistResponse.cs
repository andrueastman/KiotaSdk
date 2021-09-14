using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.HypGeom_Dist {
    public class Microsoft.graph.hypGeom_DistResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Cumulative { get; set; }
        public Json NumberPop { get; set; }
        public Json NumberSample { get; set; }
        public Json PopulationS { get; set; }
        public Json SampleS { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.hypGeom_DistResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.hypGeom_DistResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cumulative", (o,n) => { (o as Microsoft.graph.hypGeom_DistResponse).Cumulative = n.GetObjectValue<Json>(); } },
                {"numberPop", (o,n) => { (o as Microsoft.graph.hypGeom_DistResponse).NumberPop = n.GetObjectValue<Json>(); } },
                {"numberSample", (o,n) => { (o as Microsoft.graph.hypGeom_DistResponse).NumberSample = n.GetObjectValue<Json>(); } },
                {"populationS", (o,n) => { (o as Microsoft.graph.hypGeom_DistResponse).PopulationS = n.GetObjectValue<Json>(); } },
                {"sampleS", (o,n) => { (o as Microsoft.graph.hypGeom_DistResponse).SampleS = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cumulative", Cumulative);
            writer.WriteObjectValue<Json>("numberPop", NumberPop);
            writer.WriteObjectValue<Json>("numberSample", NumberSample);
            writer.WriteObjectValue<Json>("populationS", PopulationS);
            writer.WriteObjectValue<Json>("sampleS", SampleS);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
