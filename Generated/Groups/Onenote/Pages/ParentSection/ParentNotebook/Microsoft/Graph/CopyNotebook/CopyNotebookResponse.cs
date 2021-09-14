using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Groups.Onenote.Pages.ParentSection.ParentNotebook.Microsoft.Graph.CopyNotebook {
    public class Microsoft.graph.copyNotebookResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string GroupId { get; set; }
        public string NotebookFolder { get; set; }
        public string RenameAs { get; set; }
        public string SiteCollectionId { get; set; }
        public string SiteId { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.copyNotebookResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.copyNotebookResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"groupId", (o,n) => { (o as Microsoft.graph.copyNotebookResponse).GroupId = n.GetStringValue(); } },
                {"notebookFolder", (o,n) => { (o as Microsoft.graph.copyNotebookResponse).NotebookFolder = n.GetStringValue(); } },
                {"renameAs", (o,n) => { (o as Microsoft.graph.copyNotebookResponse).RenameAs = n.GetStringValue(); } },
                {"siteCollectionId", (o,n) => { (o as Microsoft.graph.copyNotebookResponse).SiteCollectionId = n.GetStringValue(); } },
                {"siteId", (o,n) => { (o as Microsoft.graph.copyNotebookResponse).SiteId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteStringValue("notebookFolder", NotebookFolder);
            writer.WriteStringValue("renameAs", RenameAs);
            writer.WriteStringValue("siteCollectionId", SiteCollectionId);
            writer.WriteStringValue("siteId", SiteId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
