using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Me.Onenote.Sections.ParentNotebook.Sections.Microsoft.Graph.CopyToSectionGroup {
    public class Microsoft.graph.copyToSectionGroupResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string GroupId { get; set; }
        public string Id { get; set; }
        public string RenameAs { get; set; }
        public string SiteCollectionId { get; set; }
        public string SiteId { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.copyToSectionGroupResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.copyToSectionGroupResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"groupId", (o,n) => { (o as Microsoft.graph.copyToSectionGroupResponse).GroupId = n.GetStringValue(); } },
                {"id", (o,n) => { (o as Microsoft.graph.copyToSectionGroupResponse).Id = n.GetStringValue(); } },
                {"renameAs", (o,n) => { (o as Microsoft.graph.copyToSectionGroupResponse).RenameAs = n.GetStringValue(); } },
                {"siteCollectionId", (o,n) => { (o as Microsoft.graph.copyToSectionGroupResponse).SiteCollectionId = n.GetStringValue(); } },
                {"siteId", (o,n) => { (o as Microsoft.graph.copyToSectionGroupResponse).SiteId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("renameAs", RenameAs);
            writer.WriteStringValue("siteCollectionId", SiteCollectionId);
            writer.WriteStringValue("siteId", SiteId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
