using GraphSdk.Models.Microsoft.Graph.TermStore;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Sites.Item.TermStores.Item.Sets.Item.Terms.Item.Children {
    public class ChildrenResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<Term> Value { get; set; }
        /// <summary>
        /// Instantiates a new childrenResponse and sets the default values.
        /// </summary>
        public ChildrenResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as ChildrenResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as ChildrenResponse).Value = n.GetCollectionOfObjectValues<Term>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<Term>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
