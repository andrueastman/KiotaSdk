using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Education.Classes.Assignments.Resources {
    public class ResourcesResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<EducationAssignmentResource> Value { get; set; }
        /// <summary>
        /// Instantiates a new ResourcesResponse and sets the default values.
        /// </summary>
        public ResourcesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as ResourcesResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as ResourcesResponse).Value = n.GetCollectionOfObjectValues<EducationAssignmentResource>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<EducationAssignmentResource>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
