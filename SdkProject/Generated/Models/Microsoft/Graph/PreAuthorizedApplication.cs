using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Models.Microsoft.Graph {
    public class PreAuthorizedApplication : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The unique identifier for the application.</summary>
        public string AppId { get; set; }
        public List<string> DelegatedPermissionIds { get; set; }
        /// <summary>
        /// Instantiates a new preAuthorizedApplication and sets the default values.
        /// </summary>
        public PreAuthorizedApplication() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"appId", (o,n) => { (o as PreAuthorizedApplication).AppId = n.GetStringValue(); } },
                {"delegatedPermissionIds", (o,n) => { (o as PreAuthorizedApplication).DelegatedPermissionIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appId", AppId);
            writer.WriteCollectionOfPrimitiveValues<string>("delegatedPermissionIds", DelegatedPermissionIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
