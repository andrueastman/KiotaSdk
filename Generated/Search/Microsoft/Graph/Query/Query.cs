using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Search.Microsoft.Graph.Query {
    public class Microsoft.graph.query : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A collection of search results.</summary>
        public List<SearchHitsContainer> HitsContainers { get; set; }
        /// <summary>Contains the search terms sent in the initial search query.</summary>
        public List<string> SearchTerms { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.query and sets the default values.
        /// </summary>
        public Microsoft.graph.query() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"hitsContainers", (o,n) => { (o as Microsoft.graph.query).HitsContainers = n.GetCollectionOfPrimitiveValues<SearchHitsContainer>().ToList(); } },
                {"searchTerms", (o,n) => { (o as Microsoft.graph.query).SearchTerms = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<SearchHitsContainer>("hitsContainers", HitsContainers);
            writer.WriteCollectionOfPrimitiveValues<string>("searchTerms", SearchTerms);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
