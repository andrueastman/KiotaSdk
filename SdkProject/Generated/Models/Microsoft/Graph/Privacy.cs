using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Models.Microsoft.Graph {
    public class Privacy : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<SubjectRightsRequest> SubjectRightsRequests { get; set; }
        /// <summary>
        /// Instantiates a new Privacy and sets the default values.
        /// </summary>
        public Privacy() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"subjectRightsRequests", (o,n) => { (o as Privacy).SubjectRightsRequests = n.GetCollectionOfObjectValues<SubjectRightsRequest>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SubjectRightsRequest>("subjectRightsRequests", SubjectRightsRequests);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
