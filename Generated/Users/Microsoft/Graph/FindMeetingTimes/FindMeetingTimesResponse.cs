using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Users.Microsoft.Graph.FindMeetingTimes {
    public class Microsoft.graph.findMeetingTimesResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<AttendeeBase> Attendees { get; set; }
        public bool? IsOrganizerOptional { get; set; }
        public LocationConstraint LocationConstraint { get; set; }
        public int? MaxCandidates { get; set; }
        public string MeetingDuration { get; set; }
        public Double MinimumAttendeePercentage { get; set; }
        public bool? ReturnSuggestionReasons { get; set; }
        public TimeConstraint TimeConstraint { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.findMeetingTimesResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.findMeetingTimesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"attendees", (o,n) => { (o as Microsoft.graph.findMeetingTimesResponse).Attendees = n.GetCollectionOfPrimitiveValues<AttendeeBase>().ToList(); } },
                {"isOrganizerOptional", (o,n) => { (o as Microsoft.graph.findMeetingTimesResponse).IsOrganizerOptional = n.GetBoolValue(); } },
                {"locationConstraint", (o,n) => { (o as Microsoft.graph.findMeetingTimesResponse).LocationConstraint = n.GetObjectValue<LocationConstraint>(); } },
                {"maxCandidates", (o,n) => { (o as Microsoft.graph.findMeetingTimesResponse).MaxCandidates = n.GetIntValue(); } },
                {"meetingDuration", (o,n) => { (o as Microsoft.graph.findMeetingTimesResponse).MeetingDuration = n.GetStringValue(); } },
                {"minimumAttendeePercentage", (o,n) => { (o as Microsoft.graph.findMeetingTimesResponse).MinimumAttendeePercentage = n.GetObjectValue<Double>(); } },
                {"returnSuggestionReasons", (o,n) => { (o as Microsoft.graph.findMeetingTimesResponse).ReturnSuggestionReasons = n.GetBoolValue(); } },
                {"timeConstraint", (o,n) => { (o as Microsoft.graph.findMeetingTimesResponse).TimeConstraint = n.GetObjectValue<TimeConstraint>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<AttendeeBase>("attendees", Attendees);
            writer.WriteBoolValue("isOrganizerOptional", IsOrganizerOptional);
            writer.WriteObjectValue<LocationConstraint>("locationConstraint", LocationConstraint);
            writer.WriteIntValue("maxCandidates", MaxCandidates);
            writer.WriteStringValue("meetingDuration", MeetingDuration);
            writer.WriteObjectValue<Double>("minimumAttendeePercentage", MinimumAttendeePercentage);
            writer.WriteBoolValue("returnSuggestionReasons", ReturnSuggestionReasons);
            writer.WriteObjectValue<TimeConstraint>("timeConstraint", TimeConstraint);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
