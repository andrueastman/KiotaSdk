using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Tables.Columns.Filter.Microsoft.Graph.Apply {
    public class Microsoft.graph.applyResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public WorkbookFilterCriteria Criteria { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.applyResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.applyResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"criteria", (o,n) => { (o as Microsoft.graph.applyResponse).Criteria = n.GetObjectValue<WorkbookFilterCriteria>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<WorkbookFilterCriteria>("criteria", Criteria);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
