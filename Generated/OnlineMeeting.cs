using GraphServiceClient.Chats;
using GraphServiceClient.Identity;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient {
    public class OnlineMeeting : Entity, IParsable {
        /// <summary>Indicates whether attendees can turn on their camera.</summary>
        public bool? AllowAttendeeToEnableCamera { get; set; }
        /// <summary>Indicates whether attendees can turn on their microphone.</summary>
        public bool? AllowAttendeeToEnableMic { get; set; }
        /// <summary>Specifies who can be a presenter in a meeting. Possible values are everyone, organization, roleIsPresenter, organizer, and unknownFutureValue.</summary>
        public OnlineMeetingPresenters AllowedPresenters { get; set; }
        /// <summary>Specifies the mode of meeting chat.</summary>
        public MeetingChatMode AllowMeetingChat { get; set; }
        /// <summary>Indicates if Teams reactions are enabled for the meeting.</summary>
        public bool? AllowTeamworkReactions { get; set; }
        /// <summary>The phone access (dial-in) information for an online meeting. Read-only.</summary>
        public AudioConferencing AudioConferencing { get; set; }
        /// <summary>The chat information associated with this online meeting.</summary>
        public ChatInfo ChatInfo { get; set; }
        /// <summary>The meeting creation time in UTC. Read-only.</summary>
        public DateTimeOffset? CreationDateTime { get; set; }
        /// <summary>The meeting end time in UTC.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The external ID. A custom ID. Optional.</summary>
        public string ExternalId { get; set; }
        /// <summary>Indicates whether to announce when callers join or leave.</summary>
        public bool? IsEntryExitAnnounced { get; set; }
        /// <summary>The join information in the language and locale variant specified in 'Accept-Language' request HTTP header. Read-only</summary>
        public ItemBody JoinInformation { get; set; }
        /// <summary>The join URL of the online meeting. Read-only.</summary>
        public string JoinWebUrl { get; set; }
        /// <summary>Specifies which participants can bypass the meeting lobby.</summary>
        public LobbyBypassSettings LobbyBypassSettings { get; set; }
        /// <summary>The participants associated with the online meeting. This includes the organizer and the attendees.</summary>
        public MeetingParticipants Participants { get; set; }
        /// <summary>The meeting start time in UTC.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The subject of the online meeting.</summary>
        public string Subject { get; set; }
        /// <summary>The video teleconferencing ID. Read-only.</summary>
        public string VideoTeleconferenceId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allowAttendeeToEnableCamera", (o,n) => { (o as OnlineMeeting).AllowAttendeeToEnableCamera = n.GetBoolValue(); } },
                {"allowAttendeeToEnableMic", (o,n) => { (o as OnlineMeeting).AllowAttendeeToEnableMic = n.GetBoolValue(); } },
                {"allowedPresenters", (o,n) => { (o as OnlineMeeting).AllowedPresenters = n.GetObjectValue<OnlineMeetingPresenters>(); } },
                {"allowMeetingChat", (o,n) => { (o as OnlineMeeting).AllowMeetingChat = n.GetObjectValue<MeetingChatMode>(); } },
                {"allowTeamworkReactions", (o,n) => { (o as OnlineMeeting).AllowTeamworkReactions = n.GetBoolValue(); } },
                {"audioConferencing", (o,n) => { (o as OnlineMeeting).AudioConferencing = n.GetObjectValue<AudioConferencing>(); } },
                {"chatInfo", (o,n) => { (o as OnlineMeeting).ChatInfo = n.GetObjectValue<ChatInfo>(); } },
                {"creationDateTime", (o,n) => { (o as OnlineMeeting).CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"endDateTime", (o,n) => { (o as OnlineMeeting).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"externalId", (o,n) => { (o as OnlineMeeting).ExternalId = n.GetStringValue(); } },
                {"isEntryExitAnnounced", (o,n) => { (o as OnlineMeeting).IsEntryExitAnnounced = n.GetBoolValue(); } },
                {"joinInformation", (o,n) => { (o as OnlineMeeting).JoinInformation = n.GetObjectValue<ItemBody>(); } },
                {"joinWebUrl", (o,n) => { (o as OnlineMeeting).JoinWebUrl = n.GetStringValue(); } },
                {"lobbyBypassSettings", (o,n) => { (o as OnlineMeeting).LobbyBypassSettings = n.GetObjectValue<LobbyBypassSettings>(); } },
                {"participants", (o,n) => { (o as OnlineMeeting).Participants = n.GetObjectValue<MeetingParticipants>(); } },
                {"startDateTime", (o,n) => { (o as OnlineMeeting).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"subject", (o,n) => { (o as OnlineMeeting).Subject = n.GetStringValue(); } },
                {"videoTeleconferenceId", (o,n) => { (o as OnlineMeeting).VideoTeleconferenceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowAttendeeToEnableCamera", AllowAttendeeToEnableCamera);
            writer.WriteBoolValue("allowAttendeeToEnableMic", AllowAttendeeToEnableMic);
            writer.WriteObjectValue<OnlineMeetingPresenters>("allowedPresenters", AllowedPresenters);
            writer.WriteObjectValue<MeetingChatMode>("allowMeetingChat", AllowMeetingChat);
            writer.WriteBoolValue("allowTeamworkReactions", AllowTeamworkReactions);
            writer.WriteObjectValue<AudioConferencing>("audioConferencing", AudioConferencing);
            writer.WriteObjectValue<ChatInfo>("chatInfo", ChatInfo);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteBoolValue("isEntryExitAnnounced", IsEntryExitAnnounced);
            writer.WriteObjectValue<ItemBody>("joinInformation", JoinInformation);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
            writer.WriteObjectValue<LobbyBypassSettings>("lobbyBypassSettings", LobbyBypassSettings);
            writer.WriteObjectValue<MeetingParticipants>("participants", Participants);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("videoTeleconferenceId", VideoTeleconferenceId);
        }
    }
}
