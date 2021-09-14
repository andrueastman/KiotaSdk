using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Me.Insights.Used.Resource.Microsoft.Graph.PrintJob.Microsoft.Graph.Abort {
    public class Microsoft.graph.abortResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Reason { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.abortResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.abortResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"reason", (o,n) => { (o as Microsoft.graph.abortResponse).Reason = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("reason", Reason);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
