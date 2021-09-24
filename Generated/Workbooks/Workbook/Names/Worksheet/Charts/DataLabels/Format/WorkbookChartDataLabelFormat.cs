using GraphServiceClient.Identity;
using GraphServiceClient.Workbooks.Workbook.Names.Worksheet.Charts.Axes.CategoryAxis.Format.Font;
using GraphServiceClient.Workbooks.Workbook.Names.Worksheet.Charts.Format.Fill;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Names.Worksheet.Charts.DataLabels.Format {
    public class WorkbookChartDataLabelFormat : Entity, IParsable {
        /// <summary>Represents the fill format of the current chart data label. Read-only.</summary>
        public WorkbookChartFill Fill { get; set; }
        /// <summary>Represents the font attributes (font name, font size, color, etc.) for a chart data label. Read-only.</summary>
        public WorkbookChartFont Font { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"fill", (o,n) => { (o as WorkbookChartDataLabelFormat).Fill = n.GetObjectValue<WorkbookChartFill>(); } },
                {"font", (o,n) => { (o as WorkbookChartDataLabelFormat).Font = n.GetObjectValue<WorkbookChartFont>(); } },
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
            writer.WriteObjectValue<WorkbookChartFont>("font", Font);
        }
    }
}
