using GraphServiceClient.Identity;
using GraphServiceClient.Workbooks.Workbook.Names.Worksheet.Charts.Format.Fill;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Names.Worksheet.Charts.Series.Points.Format {
    public class WorkbookChartPointFormat : Entity, IParsable {
        /// <summary>Represents the fill format of a chart, which includes background formating information. Read-only.</summary>
        public WorkbookChartFill Fill { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"fill", (o,n) => { (o as WorkbookChartPointFormat).Fill = n.GetObjectValue<WorkbookChartFill>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartFill>("fill", Fill);
        }
    }
}
