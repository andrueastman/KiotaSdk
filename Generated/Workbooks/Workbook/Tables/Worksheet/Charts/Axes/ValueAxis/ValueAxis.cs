using GraphServiceClient.Identity;
using GraphServiceClient.Workbooks.Workbook.Names.Worksheet.Charts.Axes.CategoryAxis.MinorGridlines;
using GraphServiceClient.Workbooks.Workbook.Tables.Worksheet.Charts.Axes.CategoryAxis.Title;
using GraphServiceClient.Workbooks.Workbook.Worksheets.Charts.Axes.CategoryAxis.Format;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Tables.Worksheet.Charts.Axes.ValueAxis {
    public class ValueAxis : Entity, IParsable {
        /// <summary>Represents the formatting of a chart object, which includes line and font formatting. Read-only.</summary>
        public WorkbookChartAxisFormat Format { get; set; }
        /// <summary>Returns a gridlines object that represents the major gridlines for the specified axis. Read-only.</summary>
        public WorkbookChartGridlines MajorGridlines { get; set; }
        /// <summary>Represents the interval between two major tick marks. Can be set to a numeric value or an empty string.  The returned value is always a number.</summary>
        public Json MajorUnit { get; set; }
        /// <summary>Represents the maximum value on the value axis.  Can be set to a numeric value or an empty string (for automatic axis values).  The returned value is always a number.</summary>
        public Json Maximum { get; set; }
        /// <summary>Represents the minimum value on the value axis. Can be set to a numeric value or an empty string (for automatic axis values).  The returned value is always a number.</summary>
        public Json Minimum { get; set; }
        /// <summary>Returns a Gridlines object that represents the minor gridlines for the specified axis. Read-only.</summary>
        public WorkbookChartGridlines MinorGridlines { get; set; }
        /// <summary>Represents the interval between two minor tick marks. 'Can be set to a numeric value or an empty string (for automatic axis values). The returned value is always a number.</summary>
        public Json MinorUnit { get; set; }
        /// <summary>Represents the axis title. Read-only.</summary>
        public WorkbookChartAxisTitle Title { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"format", (o,n) => { (o as ValueAxis).Format = n.GetObjectValue<WorkbookChartAxisFormat>(); } },
                {"majorGridlines", (o,n) => { (o as ValueAxis).MajorGridlines = n.GetObjectValue<WorkbookChartGridlines>(); } },
                {"majorUnit", (o,n) => { (o as ValueAxis).MajorUnit = n.GetObjectValue<Json>(); } },
                {"maximum", (o,n) => { (o as ValueAxis).Maximum = n.GetObjectValue<Json>(); } },
                {"minimum", (o,n) => { (o as ValueAxis).Minimum = n.GetObjectValue<Json>(); } },
                {"minorGridlines", (o,n) => { (o as ValueAxis).MinorGridlines = n.GetObjectValue<WorkbookChartGridlines>(); } },
                {"minorUnit", (o,n) => { (o as ValueAxis).MinorUnit = n.GetObjectValue<Json>(); } },
                {"title", (o,n) => { (o as ValueAxis).Title = n.GetObjectValue<WorkbookChartAxisTitle>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartAxisFormat>("format", Format);
            writer.WriteObjectValue<WorkbookChartGridlines>("majorGridlines", MajorGridlines);
            writer.WriteObjectValue<Json>("majorUnit", MajorUnit);
            writer.WriteObjectValue<Json>("maximum", Maximum);
            writer.WriteObjectValue<Json>("minimum", Minimum);
            writer.WriteObjectValue<WorkbookChartGridlines>("minorGridlines", MinorGridlines);
            writer.WriteObjectValue<Json>("minorUnit", MinorUnit);
            writer.WriteObjectValue<WorkbookChartAxisTitle>("title", Title);
        }
    }
}
