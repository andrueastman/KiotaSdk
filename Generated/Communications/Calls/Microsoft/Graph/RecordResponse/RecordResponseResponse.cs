using GraphServiceClient.Communications.Calls.Microsoft.Graph.PlayPrompt;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Communications.Calls.Microsoft.Graph.RecordResponse {
    public class Microsoft.graph.recordResponseResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public bool? BargeInAllowed { get; set; }
        public string ClientContext { get; set; }
        public int? InitialSilenceTimeoutInSeconds { get; set; }
        public int? MaxRecordDurationInSeconds { get; set; }
        public int? MaxSilenceTimeoutInSeconds { get; set; }
        public bool? PlayBeep { get; set; }
        public List<Prompt> Prompts { get; set; }
        public List<string> StopTones { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.recordResponseResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.recordResponseResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"bargeInAllowed", (o,n) => { (o as Microsoft.graph.recordResponseResponse).BargeInAllowed = n.GetBoolValue(); } },
                {"clientContext", (o,n) => { (o as Microsoft.graph.recordResponseResponse).ClientContext = n.GetStringValue(); } },
                {"initialSilenceTimeoutInSeconds", (o,n) => { (o as Microsoft.graph.recordResponseResponse).InitialSilenceTimeoutInSeconds = n.GetIntValue(); } },
                {"maxRecordDurationInSeconds", (o,n) => { (o as Microsoft.graph.recordResponseResponse).MaxRecordDurationInSeconds = n.GetIntValue(); } },
                {"maxSilenceTimeoutInSeconds", (o,n) => { (o as Microsoft.graph.recordResponseResponse).MaxSilenceTimeoutInSeconds = n.GetIntValue(); } },
                {"playBeep", (o,n) => { (o as Microsoft.graph.recordResponseResponse).PlayBeep = n.GetBoolValue(); } },
                {"prompts", (o,n) => { (o as Microsoft.graph.recordResponseResponse).Prompts = n.GetCollectionOfObjectValues<Prompt>().ToList(); } },
                {"stopTones", (o,n) => { (o as Microsoft.graph.recordResponseResponse).StopTones = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("bargeInAllowed", BargeInAllowed);
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteIntValue("initialSilenceTimeoutInSeconds", InitialSilenceTimeoutInSeconds);
            writer.WriteIntValue("maxRecordDurationInSeconds", MaxRecordDurationInSeconds);
            writer.WriteIntValue("maxSilenceTimeoutInSeconds", MaxSilenceTimeoutInSeconds);
            writer.WriteBoolValue("playBeep", PlayBeep);
            writer.WriteCollectionOfObjectValues<Prompt>("prompts", Prompts);
            writer.WriteCollectionOfPrimitiveValues<string>("stopTones", StopTones);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
