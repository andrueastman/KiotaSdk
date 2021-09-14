using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Names.Worksheet.Tables.Columns.Filter.Microsoft.Graph.ApplyIconFilter {
    public class Microsoft.graph.applyIconFilterResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public WorkbookIcon Icon { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.applyIconFilterResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.applyIconFilterResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"icon", (o,n) => { (o as Microsoft.graph.applyIconFilterResponse).Icon = n.GetObjectValue<WorkbookIcon>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<WorkbookIcon>("icon", Icon);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
