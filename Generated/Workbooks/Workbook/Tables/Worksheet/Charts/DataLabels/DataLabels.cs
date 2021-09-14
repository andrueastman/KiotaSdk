using GraphServiceClient.Identity;
using GraphServiceClient.Workbooks.Workbook.Tables.Worksheet.Charts.DataLabels.Format;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Tables.Worksheet.Charts.DataLabels {
    public class DataLabels : Entity, IParsable {
        /// <summary>Represents the format of chart data labels, which includes fill and font formatting. Read-only.</summary>
        public WorkbookChartDataLabelFormat Format { get; set; }
        /// <summary>DataLabelPosition value that represents the position of the data label. The possible values are: None, Center, InsideEnd, InsideBase, OutsideEnd, Left, Right, Top, Bottom, BestFit, Callout.</summary>
        public string Position { get; set; }
        /// <summary>String representing the separator used for the data labels on a chart.</summary>
        public string Separator { get; set; }
        /// <summary>Boolean value representing if the data label bubble size is visible or not.</summary>
        public bool? ShowBubbleSize { get; set; }
        /// <summary>Boolean value representing if the data label category name is visible or not.</summary>
        public bool? ShowCategoryName { get; set; }
        /// <summary>Boolean value representing if the data label legend key is visible or not.</summary>
        public bool? ShowLegendKey { get; set; }
        /// <summary>Boolean value representing if the data label percentage is visible or not.</summary>
        public bool? ShowPercentage { get; set; }
        /// <summary>Boolean value representing if the data label series name is visible or not.</summary>
        public bool? ShowSeriesName { get; set; }
        /// <summary>Boolean value representing if the data label value is visible or not.</summary>
        public bool? ShowValue { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"format", (o,n) => { (o as DataLabels).Format = n.GetObjectValue<WorkbookChartDataLabelFormat>(); } },
                {"position", (o,n) => { (o as DataLabels).Position = n.GetStringValue(); } },
                {"separator", (o,n) => { (o as DataLabels).Separator = n.GetStringValue(); } },
                {"showBubbleSize", (o,n) => { (o as DataLabels).ShowBubbleSize = n.GetBoolValue(); } },
                {"showCategoryName", (o,n) => { (o as DataLabels).ShowCategoryName = n.GetBoolValue(); } },
                {"showLegendKey", (o,n) => { (o as DataLabels).ShowLegendKey = n.GetBoolValue(); } },
                {"showPercentage", (o,n) => { (o as DataLabels).ShowPercentage = n.GetBoolValue(); } },
                {"showSeriesName", (o,n) => { (o as DataLabels).ShowSeriesName = n.GetBoolValue(); } },
                {"showValue", (o,n) => { (o as DataLabels).ShowValue = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartDataLabelFormat>("format", Format);
            writer.WriteStringValue("position", Position);
            writer.WriteStringValue("separator", Separator);
            writer.WriteBoolValue("showBubbleSize", ShowBubbleSize);
            writer.WriteBoolValue("showCategoryName", ShowCategoryName);
            writer.WriteBoolValue("showLegendKey", ShowLegendKey);
            writer.WriteBoolValue("showPercentage", ShowPercentage);
            writer.WriteBoolValue("showSeriesName", ShowSeriesName);
            writer.WriteBoolValue("showValue", ShowValue);
        }
    }
}
