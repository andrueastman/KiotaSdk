using GraphServiceClient.Me.Insights.Shared.LastSharedMethod.Microsoft.Graph.PrintDocument.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Users.Insights.Used.Resource.Microsoft.Graph.PrintDocument.Microsoft.Graph.CreateUploadSession {
    public class Microsoft.graph.createUploadSessionResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public PrintDocumentUploadProperties Properties { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.createUploadSessionResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.createUploadSessionResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"properties", (o,n) => { (o as Microsoft.graph.createUploadSessionResponse).Properties = n.GetObjectValue<PrintDocumentUploadProperties>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PrintDocumentUploadProperties>("properties", Properties);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
