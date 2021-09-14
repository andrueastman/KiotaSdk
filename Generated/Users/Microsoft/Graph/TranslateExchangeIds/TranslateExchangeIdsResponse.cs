using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Users.Microsoft.Graph.TranslateExchangeIds {
    public class Microsoft.graph.translateExchangeIdsResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> InputIds { get; set; }
        public ExchangeIdFormat SourceIdType { get; set; }
        public ExchangeIdFormat TargetIdType { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.translateExchangeIdsResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.translateExchangeIdsResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"inputIds", (o,n) => { (o as Microsoft.graph.translateExchangeIdsResponse).InputIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sourceIdType", (o,n) => { (o as Microsoft.graph.translateExchangeIdsResponse).SourceIdType = n.GetObjectValue<ExchangeIdFormat>(); } },
                {"targetIdType", (o,n) => { (o as Microsoft.graph.translateExchangeIdsResponse).TargetIdType = n.GetObjectValue<ExchangeIdFormat>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("inputIds", InputIds);
            writer.WriteObjectValue<ExchangeIdFormat>("sourceIdType", SourceIdType);
            writer.WriteObjectValue<ExchangeIdFormat>("targetIdType", TargetIdType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
