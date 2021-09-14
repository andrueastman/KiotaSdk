using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Worksheets.Tables.Columns.Filter.Microsoft.Graph.ApplyBottomItemsFilter {
    public class Microsoft.graph.applyBottomItemsFilterResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public int? Count { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.applyBottomItemsFilterResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.applyBottomItemsFilterResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"count", (o,n) => { (o as Microsoft.graph.applyBottomItemsFilterResponse).Count = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("count", Count);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
