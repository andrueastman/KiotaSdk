using GraphServiceClient.Me.Insights.Shared.LastSharedMethod.Microsoft.Graph.PrintJob.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Users.Insights.Trending.Resource.Microsoft.Graph.PrintJob.Microsoft.Graph.Redirect {
    public class Microsoft.graph.redirectResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public PrintJobConfiguration Configuration { get; set; }
        public string DestinationPrinterId { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.redirectResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.redirectResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"configuration", (o,n) => { (o as Microsoft.graph.redirectResponse).Configuration = n.GetObjectValue<PrintJobConfiguration>(); } },
                {"destinationPrinterId", (o,n) => { (o as Microsoft.graph.redirectResponse).DestinationPrinterId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PrintJobConfiguration>("configuration", Configuration);
            writer.WriteStringValue("destinationPrinterId", DestinationPrinterId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
