using GraphServiceClient.Identity;
using GraphServiceClient.Workbooks.Workbook.Worksheets.Charts.Axes.CategoryAxis.MinorGridlines.Format;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Tables.Worksheet.Charts.Axes.SeriesAxis.MinorGridlines {
    public class MinorGridlines : Entity, IParsable {
        /// <summary>Represents the formatting of chart gridlines. Read-only.</summary>
        public WorkbookChartGridlinesFormat Format { get; set; }
        /// <summary>Boolean value representing if the axis gridlines are visible or not.</summary>
        public bool? Visible { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"format", (o,n) => { (o as MinorGridlines).Format = n.GetObjectValue<WorkbookChartGridlinesFormat>(); } },
                {"visible", (o,n) => { (o as MinorGridlines).Visible = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartGridlinesFormat>("format", Format);
            writer.WriteBoolValue("visible", Visible);
        }
    }
}
