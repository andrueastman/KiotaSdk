using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Functions.Microsoft.Graph.Lookup {
    public class Microsoft.graph.lookupResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json LookupValue { get; set; }
        public Json LookupVector { get; set; }
        public Json ResultVector { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.lookupResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.lookupResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"lookupValue", (o,n) => { (o as Microsoft.graph.lookupResponse).LookupValue = n.GetObjectValue<Json>(); } },
                {"lookupVector", (o,n) => { (o as Microsoft.graph.lookupResponse).LookupVector = n.GetObjectValue<Json>(); } },
                {"resultVector", (o,n) => { (o as Microsoft.graph.lookupResponse).ResultVector = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("lookupValue", LookupValue);
            writer.WriteObjectValue<Json>("lookupVector", LookupVector);
            writer.WriteObjectValue<Json>("resultVector", ResultVector);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
