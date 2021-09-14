using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Me.Insights.Shared.LastSharedMethod.Microsoft.Graph.PrintJob.Microsoft.Graph {
    public class PrintJobConfiguration : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether the printer should collate pages wehen printing multiple copies of a multi-page document.</summary>
        public bool? Collate { get; set; }
        /// <summary>The color mode the printer should use to print the job. Valid values are described in the table below. Read-only.</summary>
        public PrintColorMode ColorMode { get; set; }
        /// <summary>The number of copies that should be printed. Read-only.</summary>
        public int? Copies { get; set; }
        /// <summary>The resolution to use when printing the job, expressed in dots per inch (DPI). Read-only.</summary>
        public int? Dpi { get; set; }
        /// <summary>The duplex mode the printer should use when printing the job. Valid values are described in the table below. Read-only.</summary>
        public PrintDuplexMode DuplexMode { get; set; }
        /// <summary>The orientation to use when feeding media into the printer. Valid values are described in the following table. Read-only.</summary>
        public PrinterFeedOrientation FeedOrientation { get; set; }
        /// <summary>Finishing processes to use when printing.</summary>
        public List<PrintFinishing> Finishings { get; set; }
        public bool? FitPdfToPage { get; set; }
        /// <summary>The input bin (tray) to use when printing. See the printer's capabilities for a list of supported input bins.</summary>
        public string InputBin { get; set; }
        /// <summary>The margin settings to use when printing.</summary>
        public PrintMargin Margin { get; set; }
        /// <summary>The media sizeto use when printing. Supports standard size names for ISO and ANSI media sizes. Valid values are listed in the printerCapabilities topic.</summary>
        public string MediaSize { get; set; }
        /// <summary>The default media (such as paper) type to print the document on.</summary>
        public string MediaType { get; set; }
        /// <summary>The direction to lay out pages when multiple pages are being printed per sheet. Valid values are described in the following table.</summary>
        public PrintMultipageLayout MultipageLayout { get; set; }
        /// <summary>The orientation setting the printer should use when printing the job. Valid values are described in the following table.</summary>
        public PrintOrientation Orientation { get; set; }
        /// <summary>The output bin to place completed prints into. See the printer's capabilities for a list of supported output bins.</summary>
        public string OutputBin { get; set; }
        /// <summary>The page ranges to print. Read-only.</summary>
        public List<IntegerRange> PageRanges { get; set; }
        /// <summary>The number of document pages to print on each sheet.</summary>
        public int? PagesPerSheet { get; set; }
        /// <summary>The print quality to use when printing the job. Valid values are described in the table below. Read-only.</summary>
        public PrintQuality Quality { get; set; }
        /// <summary>Specifies how the printer should scale the document data to fit the requested media. Valid values are described in the following table.</summary>
        public PrintScaling Scaling { get; set; }
        /// <summary>
        /// Instantiates a new printJobConfiguration and sets the default values.
        /// </summary>
        public PrintJobConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"collate", (o,n) => { (o as PrintJobConfiguration).Collate = n.GetBoolValue(); } },
                {"colorMode", (o,n) => { (o as PrintJobConfiguration).ColorMode = n.GetObjectValue<PrintColorMode>(); } },
                {"copies", (o,n) => { (o as PrintJobConfiguration).Copies = n.GetIntValue(); } },
                {"dpi", (o,n) => { (o as PrintJobConfiguration).Dpi = n.GetIntValue(); } },
                {"duplexMode", (o,n) => { (o as PrintJobConfiguration).DuplexMode = n.GetObjectValue<PrintDuplexMode>(); } },
                {"feedOrientation", (o,n) => { (o as PrintJobConfiguration).FeedOrientation = n.GetObjectValue<PrinterFeedOrientation>(); } },
                {"finishings", (o,n) => { (o as PrintJobConfiguration).Finishings = n.GetCollectionOfPrimitiveValues<PrintFinishing>().ToList(); } },
                {"fitPdfToPage", (o,n) => { (o as PrintJobConfiguration).FitPdfToPage = n.GetBoolValue(); } },
                {"inputBin", (o,n) => { (o as PrintJobConfiguration).InputBin = n.GetStringValue(); } },
                {"margin", (o,n) => { (o as PrintJobConfiguration).Margin = n.GetObjectValue<PrintMargin>(); } },
                {"mediaSize", (o,n) => { (o as PrintJobConfiguration).MediaSize = n.GetStringValue(); } },
                {"mediaType", (o,n) => { (o as PrintJobConfiguration).MediaType = n.GetStringValue(); } },
                {"multipageLayout", (o,n) => { (o as PrintJobConfiguration).MultipageLayout = n.GetObjectValue<PrintMultipageLayout>(); } },
                {"orientation", (o,n) => { (o as PrintJobConfiguration).Orientation = n.GetObjectValue<PrintOrientation>(); } },
                {"outputBin", (o,n) => { (o as PrintJobConfiguration).OutputBin = n.GetStringValue(); } },
                {"pageRanges", (o,n) => { (o as PrintJobConfiguration).PageRanges = n.GetCollectionOfPrimitiveValues<IntegerRange>().ToList(); } },
                {"pagesPerSheet", (o,n) => { (o as PrintJobConfiguration).PagesPerSheet = n.GetIntValue(); } },
                {"quality", (o,n) => { (o as PrintJobConfiguration).Quality = n.GetObjectValue<PrintQuality>(); } },
                {"scaling", (o,n) => { (o as PrintJobConfiguration).Scaling = n.GetObjectValue<PrintScaling>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("collate", Collate);
            writer.WriteObjectValue<PrintColorMode>("colorMode", ColorMode);
            writer.WriteIntValue("copies", Copies);
            writer.WriteIntValue("dpi", Dpi);
            writer.WriteObjectValue<PrintDuplexMode>("duplexMode", DuplexMode);
            writer.WriteObjectValue<PrinterFeedOrientation>("feedOrientation", FeedOrientation);
            writer.WriteCollectionOfPrimitiveValues<PrintFinishing>("finishings", Finishings);
            writer.WriteBoolValue("fitPdfToPage", FitPdfToPage);
            writer.WriteStringValue("inputBin", InputBin);
            writer.WriteObjectValue<PrintMargin>("margin", Margin);
            writer.WriteStringValue("mediaSize", MediaSize);
            writer.WriteStringValue("mediaType", MediaType);
            writer.WriteObjectValue<PrintMultipageLayout>("multipageLayout", MultipageLayout);
            writer.WriteObjectValue<PrintOrientation>("orientation", Orientation);
            writer.WriteStringValue("outputBin", OutputBin);
            writer.WriteCollectionOfPrimitiveValues<IntegerRange>("pageRanges", PageRanges);
            writer.WriteIntValue("pagesPerSheet", PagesPerSheet);
            writer.WriteObjectValue<PrintQuality>("quality", Quality);
            writer.WriteObjectValue<PrintScaling>("scaling", Scaling);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
