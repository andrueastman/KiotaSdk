using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Search.Microsoft.Graph.Query {
    public class Microsoft.graph.queryResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<SearchRequest> Requests { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.queryResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.queryResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"requests", (o,n) => { (o as Microsoft.graph.queryResponse).Requests = n.GetCollectionOfObjectValues<SearchRequest>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SearchRequest>("requests", Requests);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
