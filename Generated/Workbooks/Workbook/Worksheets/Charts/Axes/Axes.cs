using GraphServiceClient.Identity;
using GraphServiceClient.Workbooks.Workbook.Worksheets.Charts.Axes.CategoryAxis;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Workbooks.Workbook.Worksheets.Charts.Axes {
    public class Axes : Entity, IParsable {
        /// <summary>Represents the category axis in a chart. Read-only.</summary>
        public WorkbookChartAxis CategoryAxis { get; set; }
        /// <summary>Represents the series axis of a 3-dimensional chart. Read-only.</summary>
        public WorkbookChartAxis SeriesAxis { get; set; }
        /// <summary>Represents the value axis in an axis. Read-only.</summary>
        public WorkbookChartAxis ValueAxis { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"categoryAxis", (o,n) => { (o as Axes).CategoryAxis = n.GetObjectValue<WorkbookChartAxis>(); } },
                {"seriesAxis", (o,n) => { (o as Axes).SeriesAxis = n.GetObjectValue<WorkbookChartAxis>(); } },
                {"valueAxis", (o,n) => { (o as Axes).ValueAxis = n.GetObjectValue<WorkbookChartAxis>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartAxis>("categoryAxis", CategoryAxis);
            writer.WriteObjectValue<WorkbookChartAxis>("seriesAxis", SeriesAxis);
            writer.WriteObjectValue<WorkbookChartAxis>("valueAxis", ValueAxis);
        }
    }
}
