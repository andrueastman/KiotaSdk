using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Communications.Calls.Microsoft.Graph.LogTeleconferenceDeviceQuality {
    public class TeleconferenceDeviceMediaQuality : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The average inbound stream network jitter.</summary>
        public string AverageInboundJitter { get; set; }
        /// <summary>The average inbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.</summary>
        public Double AverageInboundPacketLossRateInPercentage { get; set; }
        /// <summary>The average inbound stream network round trip delay.</summary>
        public string AverageInboundRoundTripDelay { get; set; }
        /// <summary>The average outbound stream network jitter.</summary>
        public string AverageOutboundJitter { get; set; }
        /// <summary>The average outbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.</summary>
        public Double AverageOutboundPacketLossRateInPercentage { get; set; }
        /// <summary>The average outbound stream network round trip delay.</summary>
        public string AverageOutboundRoundTripDelay { get; set; }
        /// <summary>The channel index of media. Indexing begins with 1.  If a media session contains 3 video modalities, channel indexes will be 1, 2, and 3.</summary>
        public int? ChannelIndex { get; set; }
        /// <summary>The total number of the inbound packets.</summary>
        public Int64 InboundPackets { get; set; }
        /// <summary>the local IP address for the media session.</summary>
        public string LocalIPAddress { get; set; }
        /// <summary>The local media port.</summary>
        public int? LocalPort { get; set; }
        /// <summary>The maximum inbound stream network jitter.</summary>
        public string MaximumInboundJitter { get; set; }
        /// <summary>The maximum inbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.</summary>
        public Double MaximumInboundPacketLossRateInPercentage { get; set; }
        /// <summary>The maximum inbound stream network round trip delay.</summary>
        public string MaximumInboundRoundTripDelay { get; set; }
        /// <summary>The maximum outbound stream network jitter.</summary>
        public string MaximumOutboundJitter { get; set; }
        /// <summary>The maximum outbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.</summary>
        public Double MaximumOutboundPacketLossRateInPercentage { get; set; }
        /// <summary>The maximum outbound stream network round trip delay.</summary>
        public string MaximumOutboundRoundTripDelay { get; set; }
        /// <summary>The total modality duration. If the media enabled and disabled multiple times, MediaDuration will the summation of all of the durations.</summary>
        public string MediaDuration { get; set; }
        /// <summary>The network link speed in bytes</summary>
        public Int64 NetworkLinkSpeedInBytes { get; set; }
        /// <summary>The total number of the outbound packets.</summary>
        public Int64 OutboundPackets { get; set; }
        /// <summary>The remote IP address for the media session.</summary>
        public string RemoteIPAddress { get; set; }
        /// <summary>The remote media port.</summary>
        public int? RemotePort { get; set; }
        /// <summary>
        /// Instantiates a new teleconferenceDeviceMediaQuality and sets the default values.
        /// </summary>
        public TeleconferenceDeviceMediaQuality() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"averageInboundJitter", (o,n) => { (o as TeleconferenceDeviceMediaQuality).AverageInboundJitter = n.GetStringValue(); } },
                {"averageInboundPacketLossRateInPercentage", (o,n) => { (o as TeleconferenceDeviceMediaQuality).AverageInboundPacketLossRateInPercentage = n.GetObjectValue<Double>(); } },
                {"averageInboundRoundTripDelay", (o,n) => { (o as TeleconferenceDeviceMediaQuality).AverageInboundRoundTripDelay = n.GetStringValue(); } },
                {"averageOutboundJitter", (o,n) => { (o as TeleconferenceDeviceMediaQuality).AverageOutboundJitter = n.GetStringValue(); } },
                {"averageOutboundPacketLossRateInPercentage", (o,n) => { (o as TeleconferenceDeviceMediaQuality).AverageOutboundPacketLossRateInPercentage = n.GetObjectValue<Double>(); } },
                {"averageOutboundRoundTripDelay", (o,n) => { (o as TeleconferenceDeviceMediaQuality).AverageOutboundRoundTripDelay = n.GetStringValue(); } },
                {"channelIndex", (o,n) => { (o as TeleconferenceDeviceMediaQuality).ChannelIndex = n.GetIntValue(); } },
                {"inboundPackets", (o,n) => { (o as TeleconferenceDeviceMediaQuality).InboundPackets = n.GetObjectValue<Int64>(); } },
                {"localIPAddress", (o,n) => { (o as TeleconferenceDeviceMediaQuality).LocalIPAddress = n.GetStringValue(); } },
                {"localPort", (o,n) => { (o as TeleconferenceDeviceMediaQuality).LocalPort = n.GetIntValue(); } },
                {"maximumInboundJitter", (o,n) => { (o as TeleconferenceDeviceMediaQuality).MaximumInboundJitter = n.GetStringValue(); } },
                {"maximumInboundPacketLossRateInPercentage", (o,n) => { (o as TeleconferenceDeviceMediaQuality).MaximumInboundPacketLossRateInPercentage = n.GetObjectValue<Double>(); } },
                {"maximumInboundRoundTripDelay", (o,n) => { (o as TeleconferenceDeviceMediaQuality).MaximumInboundRoundTripDelay = n.GetStringValue(); } },
                {"maximumOutboundJitter", (o,n) => { (o as TeleconferenceDeviceMediaQuality).MaximumOutboundJitter = n.GetStringValue(); } },
                {"maximumOutboundPacketLossRateInPercentage", (o,n) => { (o as TeleconferenceDeviceMediaQuality).MaximumOutboundPacketLossRateInPercentage = n.GetObjectValue<Double>(); } },
                {"maximumOutboundRoundTripDelay", (o,n) => { (o as TeleconferenceDeviceMediaQuality).MaximumOutboundRoundTripDelay = n.GetStringValue(); } },
                {"mediaDuration", (o,n) => { (o as TeleconferenceDeviceMediaQuality).MediaDuration = n.GetStringValue(); } },
                {"networkLinkSpeedInBytes", (o,n) => { (o as TeleconferenceDeviceMediaQuality).NetworkLinkSpeedInBytes = n.GetObjectValue<Int64>(); } },
                {"outboundPackets", (o,n) => { (o as TeleconferenceDeviceMediaQuality).OutboundPackets = n.GetObjectValue<Int64>(); } },
                {"remoteIPAddress", (o,n) => { (o as TeleconferenceDeviceMediaQuality).RemoteIPAddress = n.GetStringValue(); } },
                {"remotePort", (o,n) => { (o as TeleconferenceDeviceMediaQuality).RemotePort = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("averageInboundJitter", AverageInboundJitter);
            writer.WriteObjectValue<Double>("averageInboundPacketLossRateInPercentage", AverageInboundPacketLossRateInPercentage);
            writer.WriteStringValue("averageInboundRoundTripDelay", AverageInboundRoundTripDelay);
            writer.WriteStringValue("averageOutboundJitter", AverageOutboundJitter);
            writer.WriteObjectValue<Double>("averageOutboundPacketLossRateInPercentage", AverageOutboundPacketLossRateInPercentage);
            writer.WriteStringValue("averageOutboundRoundTripDelay", AverageOutboundRoundTripDelay);
            writer.WriteIntValue("channelIndex", ChannelIndex);
            writer.WriteObjectValue<Int64>("inboundPackets", InboundPackets);
            writer.WriteStringValue("localIPAddress", LocalIPAddress);
            writer.WriteIntValue("localPort", LocalPort);
            writer.WriteStringValue("maximumInboundJitter", MaximumInboundJitter);
            writer.WriteObjectValue<Double>("maximumInboundPacketLossRateInPercentage", MaximumInboundPacketLossRateInPercentage);
            writer.WriteStringValue("maximumInboundRoundTripDelay", MaximumInboundRoundTripDelay);
            writer.WriteStringValue("maximumOutboundJitter", MaximumOutboundJitter);
            writer.WriteObjectValue<Double>("maximumOutboundPacketLossRateInPercentage", MaximumOutboundPacketLossRateInPercentage);
            writer.WriteStringValue("maximumOutboundRoundTripDelay", MaximumOutboundRoundTripDelay);
            writer.WriteStringValue("mediaDuration", MediaDuration);
            writer.WriteObjectValue<Int64>("networkLinkSpeedInBytes", NetworkLinkSpeedInBytes);
            writer.WriteObjectValue<Int64>("outboundPackets", OutboundPackets);
            writer.WriteStringValue("remoteIPAddress", RemoteIPAddress);
            writer.WriteIntValue("remotePort", RemotePort);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
