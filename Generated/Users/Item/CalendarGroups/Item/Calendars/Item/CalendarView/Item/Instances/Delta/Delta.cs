using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.CalendarGroups.Item.Calendars.Item.CalendarView.Item.Instances.Delta {
    public class Delta : OutlookItem, IParsable {
        /// <summary>True if the meeting organizer allows invitees to propose a new time when responding, false otherwise. Optional. Default is true.</summary>
        public bool? AllowNewTimeProposals { get; set; }
        /// <summary>The collection of FileAttachment, ItemAttachment, and referenceAttachment attachments for the event. Navigation property. Read-only. Nullable.</summary>
        public List<Attachment> Attachments { get; set; }
        /// <summary>The collection of attendees for the event.</summary>
        public List<Attendee> Attendees { get; set; }
        /// <summary>The body of the message associated with the event. It can be in HTML or text format.</summary>
        public ItemBody Body { get; set; }
        /// <summary>The preview of the message associated with the event. It is in text format.</summary>
        public string BodyPreview { get; set; }
        /// <summary>The calendar that contains the event. Navigation property. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Calendar Calendar { get; set; }
        /// <summary>The date, time, and time zone that the event ends. By default, the end time is in UTC.</summary>
        public DateTimeTimeZone End { get; set; }
        /// <summary>The collection of open extensions defined for the event. Nullable.</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>Set to true if the event has attachments.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>When set to true, each attendee only sees themselves in the meeting request and meeting Tracking list. Default is false.</summary>
        public bool? HideAttendees { get; set; }
        /// <summary>A unique identifier for an event across calendars. This ID is different for each occurrence in a recurring series. Read-only.</summary>
        public string ICalUId { get; set; }
        /// <summary>The importance of the event. The possible values are: low, normal, high.</summary>
        public Importance? Importance { get; set; }
        /// <summary>The occurrences of a recurring series, if the event is a series master. This property includes occurrences that are part of the recurrence pattern, and exceptions that have been modified, but does not include occurrences that have been cancelled from the series. Navigation property. Read-only. Nullable.</summary>
        public List<Event> Instances { get; set; }
        /// <summary>Set to true if the event lasts all day.</summary>
        public bool? IsAllDay { get; set; }
        /// <summary>Set to true if the event has been canceled.</summary>
        public bool? IsCancelled { get; set; }
        /// <summary>Set to true if the user has updated the meeting in Outlook but has not sent the updates to attendees. Set to false if all changes have been sent, or if the event is an appointment without any attendees.</summary>
        public bool? IsDraft { get; set; }
        /// <summary>True if this event has online meeting information, false otherwise. Default is false. Optional.</summary>
        public bool? IsOnlineMeeting { get; set; }
        /// <summary>Set to true if the calendar owner (specified by the owner property of the calendar) is the organizer of the event (specified by the organizer property of the event). This also applies if a delegate organized the event on behalf of the owner.</summary>
        public bool? IsOrganizer { get; set; }
        /// <summary>Set to true if an alert is set to remind the user of the event.</summary>
        public bool? IsReminderOn { get; set; }
        /// <summary>The location of the event.</summary>
        public Location Location { get; set; }
        /// <summary>The locations where the event is held or attended from. The location and locations properties always correspond with each other. If you update the location property, any prior locations in the locations collection would be removed and replaced by the new location value.</summary>
        public List<Location> Locations { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the event. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
        /// <summary>Details for an attendee to join the meeting online. Read-only.</summary>
        public OnlineMeetingInfo OnlineMeeting { get; set; }
        /// <summary>Represents the online meeting service provider. The possible values are teamsForBusiness, skypeForBusiness, and skypeForConsumer. Optional.</summary>
        public OnlineMeetingProviderType? OnlineMeetingProvider { get; set; }
        /// <summary>A URL for an online meeting. The property is set only when an organizer specifies an event as an online meeting such as a Skype meeting. Read-only.</summary>
        public string OnlineMeetingUrl { get; set; }
        /// <summary>The organizer of the event.</summary>
        public Recipient Organizer { get; set; }
        /// <summary>The end time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.</summary>
        public string OriginalEndTimeZone { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? OriginalStart { get; set; }
        /// <summary>The start time zone that was set when the event was created. A value of tzone://Microsoft/Custom indicates that a legacy custom time zone was set in desktop Outlook.</summary>
        public string OriginalStartTimeZone { get; set; }
        /// <summary>The recurrence pattern for the event.</summary>
        public PatternedRecurrence Recurrence { get; set; }
        /// <summary>The number of minutes before the event start time that the reminder alert occurs.</summary>
        public int? ReminderMinutesBeforeStart { get; set; }
        /// <summary>Default is true, which represents the organizer would like an invitee to send a response to the event.</summary>
        public bool? ResponseRequested { get; set; }
        /// <summary>Indicates the type of response sent in response to an event message.</summary>
        public ResponseStatus ResponseStatus { get; set; }
        /// <summary>The possible values are: normal, personal, private, confidential.</summary>
        public Sensitivity? Sensitivity { get; set; }
        /// <summary>The ID for the recurring series master item, if this event is part of a recurring series.</summary>
        public string SeriesMasterId { get; set; }
        /// <summary>The status to show. The possible values are: free, tentative, busy, oof, workingElsewhere, unknown.</summary>
        public FreeBusyStatus? ShowAs { get; set; }
        /// <summary>The collection of single-value extended properties defined for the event. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
        /// <summary>The date, time, and time zone that the event starts. By default, the start time is in UTC.</summary>
        public DateTimeTimeZone Start { get; set; }
        /// <summary>The text of the event's subject line.</summary>
        public string Subject { get; set; }
        /// <summary>A custom identifier specified by a client app for the server to avoid redundant POST operations in case of client retries to create the same event. This is useful when low network connectivity causes the client to time out before receiving a response from the server for the client's prior create-event request. After you set transactionId when creating an event, you cannot change transactionId in a subsequent update. This property is only returned in a response payload if an app has set it. Optional.</summary>
        public string TransactionId { get; set; }
        /// <summary>The event type. The possible values are: singleInstance, occurrence, exception, seriesMaster. Read-only.</summary>
        public EventType? Type { get; set; }
        /// <summary>The URL to open the event in Outlook on the web.Outlook on the web opens the event in the browser if you are signed in to your mailbox. Otherwise, Outlook on the web prompts you to sign in.This URL cannot be accessed from within an iFrame.</summary>
        public string WebLink { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allowNewTimeProposals", (o,n) => { (o as Delta).AllowNewTimeProposals = n.GetBoolValue(); } },
                {"attachments", (o,n) => { (o as Delta).Attachments = n.GetCollectionOfObjectValues<Attachment>().ToList(); } },
                {"attendees", (o,n) => { (o as Delta).Attendees = n.GetCollectionOfObjectValues<Attendee>().ToList(); } },
                {"body", (o,n) => { (o as Delta).Body = n.GetObjectValue<ItemBody>(); } },
                {"bodyPreview", (o,n) => { (o as Delta).BodyPreview = n.GetStringValue(); } },
                {"calendar", (o,n) => { (o as Delta).Calendar = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Calendar>(); } },
                {"end", (o,n) => { (o as Delta).End = n.GetObjectValue<DateTimeTimeZone>(); } },
                {"extensions", (o,n) => { (o as Delta).Extensions = n.GetCollectionOfObjectValues<Extension>().ToList(); } },
                {"hasAttachments", (o,n) => { (o as Delta).HasAttachments = n.GetBoolValue(); } },
                {"hideAttendees", (o,n) => { (o as Delta).HideAttendees = n.GetBoolValue(); } },
                {"iCalUId", (o,n) => { (o as Delta).ICalUId = n.GetStringValue(); } },
                {"importance", (o,n) => { (o as Delta).Importance = n.GetEnumValue<Importance>(); } },
                {"instances", (o,n) => { (o as Delta).Instances = n.GetCollectionOfObjectValues<Event>().ToList(); } },
                {"isAllDay", (o,n) => { (o as Delta).IsAllDay = n.GetBoolValue(); } },
                {"isCancelled", (o,n) => { (o as Delta).IsCancelled = n.GetBoolValue(); } },
                {"isDraft", (o,n) => { (o as Delta).IsDraft = n.GetBoolValue(); } },
                {"isOnlineMeeting", (o,n) => { (o as Delta).IsOnlineMeeting = n.GetBoolValue(); } },
                {"isOrganizer", (o,n) => { (o as Delta).IsOrganizer = n.GetBoolValue(); } },
                {"isReminderOn", (o,n) => { (o as Delta).IsReminderOn = n.GetBoolValue(); } },
                {"location", (o,n) => { (o as Delta).Location = n.GetObjectValue<Location>(); } },
                {"locations", (o,n) => { (o as Delta).Locations = n.GetCollectionOfObjectValues<Location>().ToList(); } },
                {"multiValueExtendedProperties", (o,n) => { (o as Delta).MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>().ToList(); } },
                {"onlineMeeting", (o,n) => { (o as Delta).OnlineMeeting = n.GetObjectValue<OnlineMeetingInfo>(); } },
                {"onlineMeetingProvider", (o,n) => { (o as Delta).OnlineMeetingProvider = n.GetEnumValue<OnlineMeetingProviderType>(); } },
                {"onlineMeetingUrl", (o,n) => { (o as Delta).OnlineMeetingUrl = n.GetStringValue(); } },
                {"organizer", (o,n) => { (o as Delta).Organizer = n.GetObjectValue<Recipient>(); } },
                {"originalEndTimeZone", (o,n) => { (o as Delta).OriginalEndTimeZone = n.GetStringValue(); } },
                {"originalStart", (o,n) => { (o as Delta).OriginalStart = n.GetDateTimeOffsetValue(); } },
                {"originalStartTimeZone", (o,n) => { (o as Delta).OriginalStartTimeZone = n.GetStringValue(); } },
                {"recurrence", (o,n) => { (o as Delta).Recurrence = n.GetObjectValue<PatternedRecurrence>(); } },
                {"reminderMinutesBeforeStart", (o,n) => { (o as Delta).ReminderMinutesBeforeStart = n.GetIntValue(); } },
                {"responseRequested", (o,n) => { (o as Delta).ResponseRequested = n.GetBoolValue(); } },
                {"responseStatus", (o,n) => { (o as Delta).ResponseStatus = n.GetObjectValue<ResponseStatus>(); } },
                {"sensitivity", (o,n) => { (o as Delta).Sensitivity = n.GetEnumValue<Sensitivity>(); } },
                {"seriesMasterId", (o,n) => { (o as Delta).SeriesMasterId = n.GetStringValue(); } },
                {"showAs", (o,n) => { (o as Delta).ShowAs = n.GetEnumValue<FreeBusyStatus>(); } },
                {"singleValueExtendedProperties", (o,n) => { (o as Delta).SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>().ToList(); } },
                {"start", (o,n) => { (o as Delta).Start = n.GetObjectValue<DateTimeTimeZone>(); } },
                {"subject", (o,n) => { (o as Delta).Subject = n.GetStringValue(); } },
                {"transactionId", (o,n) => { (o as Delta).TransactionId = n.GetStringValue(); } },
                {"type", (o,n) => { (o as Delta).Type = n.GetEnumValue<EventType>(); } },
                {"webLink", (o,n) => { (o as Delta).WebLink = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowNewTimeProposals", AllowNewTimeProposals);
            writer.WriteCollectionOfObjectValues<Attachment>("attachments", Attachments);
            writer.WriteCollectionOfObjectValues<Attendee>("attendees", Attendees);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteStringValue("bodyPreview", BodyPreview);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Calendar>("calendar", Calendar);
            writer.WriteObjectValue<DateTimeTimeZone>("end", End);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteBoolValue("hideAttendees", HideAttendees);
            writer.WriteStringValue("iCalUId", ICalUId);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteCollectionOfObjectValues<Event>("instances", Instances);
            writer.WriteBoolValue("isAllDay", IsAllDay);
            writer.WriteBoolValue("isCancelled", IsCancelled);
            writer.WriteBoolValue("isDraft", IsDraft);
            writer.WriteBoolValue("isOnlineMeeting", IsOnlineMeeting);
            writer.WriteBoolValue("isOrganizer", IsOrganizer);
            writer.WriteBoolValue("isReminderOn", IsReminderOn);
            writer.WriteObjectValue<Location>("location", Location);
            writer.WriteCollectionOfObjectValues<Location>("locations", Locations);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteObjectValue<OnlineMeetingInfo>("onlineMeeting", OnlineMeeting);
            writer.WriteEnumValue<OnlineMeetingProviderType>("onlineMeetingProvider", OnlineMeetingProvider);
            writer.WriteStringValue("onlineMeetingUrl", OnlineMeetingUrl);
            writer.WriteObjectValue<Recipient>("organizer", Organizer);
            writer.WriteStringValue("originalEndTimeZone", OriginalEndTimeZone);
            writer.WriteDateTimeOffsetValue("originalStart", OriginalStart);
            writer.WriteStringValue("originalStartTimeZone", OriginalStartTimeZone);
            writer.WriteObjectValue<PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteIntValue("reminderMinutesBeforeStart", ReminderMinutesBeforeStart);
            writer.WriteBoolValue("responseRequested", ResponseRequested);
            writer.WriteObjectValue<ResponseStatus>("responseStatus", ResponseStatus);
            writer.WriteEnumValue<Sensitivity>("sensitivity", Sensitivity);
            writer.WriteStringValue("seriesMasterId", SeriesMasterId);
            writer.WriteEnumValue<FreeBusyStatus>("showAs", ShowAs);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteObjectValue<DateTimeTimeZone>("start", Start);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("transactionId", TransactionId);
            writer.WriteEnumValue<EventType>("type", Type);
            writer.WriteStringValue("webLink", WebLink);
        }
    }
}
