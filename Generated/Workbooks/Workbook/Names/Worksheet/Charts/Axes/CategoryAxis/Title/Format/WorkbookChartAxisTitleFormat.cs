using GraphServiceClient.Identity;
using GraphServiceClient.Workbooks.Workbook.Worksheets.Charts.Axes.CategoryAxis.Format.Font;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Names.Worksheet.Charts.Axes.CategoryAxis.Title.Format {
    public class WorkbookChartAxisTitleFormat : Entity, IParsable {
        /// <summary>Represents the font attributes, such as font name, font size, color, etc. of chart axis title object. Read-only.</summary>
        public WorkbookChartFont Font { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"font", (o,n) => { (o as WorkbookChartAxisTitleFormat).Font = n.GetObjectValue<WorkbookChartFont>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartFont>("font", Font);
        }
    }
}
