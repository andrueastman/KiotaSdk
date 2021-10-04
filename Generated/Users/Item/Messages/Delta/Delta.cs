using ApiSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Users.Item.Messages.Delta {
    public class Delta : OutlookItem, IParsable {
        /// <summary>The fileAttachment and itemAttachment attachments for the message.</summary>
        public List<Attachment> Attachments { get; set; }
        /// <summary>The Bcc: recipients for the message.</summary>
        public List<Recipient> BccRecipients { get; set; }
        /// <summary>The body of the message. It can be in HTML or text format. Find out about safe HTML in a message body.</summary>
        public ItemBody Body { get; set; }
        /// <summary>The first 255 characters of the message body. It is in text format. If the message contains instances of mention, this property would contain a concatenation of these mentions as well.</summary>
        public string BodyPreview { get; set; }
        /// <summary>The Cc: recipients for the message.</summary>
        public List<Recipient> CcRecipients { get; set; }
        /// <summary>The ID of the conversation the email belongs to.</summary>
        public string ConversationId { get; set; }
        /// <summary>Indicates the position of the message within the conversation.</summary>
        public byte[] ConversationIndex { get; set; }
        /// <summary>The collection of open extensions defined for the message. Nullable.</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>The flag value that indicates the status, start date, due date, or completion date for the message.</summary>
        public FollowupFlag Flag { get; set; }
        /// <summary>The owner of the mailbox from which the message is sent. In most cases, this value is the same as the sender property, except for sharing or delegation scenarios. The value must correspond to the actual mailbox used. Find out more about setting the from and sender properties of a message.</summary>
        public Recipient From { get; set; }
        /// <summary>Indicates whether the message has attachments. This property doesn't include inline attachments, so if a message contains only inline attachments, this property is false. To verify the existence of inline attachments, parse the body property to look for a src attribute, such as <IMG src='cid:image001.jpg@01D26CD8.6C05F070'>.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>The importance of the message. The possible values are: low, normal, and high.</summary>
        public Importance? Importance { get; set; }
        /// <summary>The classification of the message for the user, based on inferred relevance or importance, or on an explicit override. The possible values are: focused or other.</summary>
        public InferenceClassificationType? InferenceClassification { get; set; }
        /// <summary>A collection of message headers defined by RFC5322. The set includes message headers indicating the network path taken by a message from the sender to the recipient. It can also contain custom message headers that hold app data for the message.  Returned only on applying a $select query option. Read-only.</summary>
        public List<InternetMessageHeader> InternetMessageHeaders { get; set; }
        /// <summary>The message ID in the format specified by RFC2822.</summary>
        public string InternetMessageId { get; set; }
        /// <summary>Indicates whether a read receipt is requested for the message.</summary>
        public bool? IsDeliveryReceiptRequested { get; set; }
        /// <summary>Indicates whether the message is a draft. A message is a draft if it hasn't been sent yet.</summary>
        public bool? IsDraft { get; set; }
        /// <summary>Indicates whether the message has been read.</summary>
        public bool? IsRead { get; set; }
        /// <summary>Indicates whether a read receipt is requested for the message.</summary>
        public bool? IsReadReceiptRequested { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the message. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
        /// <summary>The unique identifier for the message's parent mailFolder.</summary>
        public string ParentFolderId { get; set; }
        /// <summary>The date and time the message was received.  The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ReceivedDateTime { get; set; }
        /// <summary>The email addresses to use when replying.</summary>
        public List<Recipient> ReplyTo { get; set; }
        /// <summary>The account that is actually used to generate the message. In most cases, this value is the same as the from property. You can set this property to a different value when sending a message from a shared mailbox, for a shared calendar, or as a delegate. In any case, the value must correspond to the actual mailbox used. Find out more about setting the from and sender properties of a message.</summary>
        public Recipient Sender { get; set; }
        /// <summary>The date and time the message was sent.  The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? SentDateTime { get; set; }
        /// <summary>The collection of single-value extended properties defined for the message. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
        /// <summary>The subject of the message.</summary>
        public string Subject { get; set; }
        /// <summary>The To: recipients for the message.</summary>
        public List<Recipient> ToRecipients { get; set; }
        /// <summary>The part of the body of the message that is unique to the current message. uniqueBody is not returned by default but can be retrieved for a given message by use of the ?$select=uniqueBody query. It can be in HTML or text format.</summary>
        public ItemBody UniqueBody { get; set; }
        /// <summary>The URL to open the message in Outlook on the web.You can append an ispopout argument to the end of the URL to change how the message is displayed. If ispopout is not present or if it is set to 1, then the message is shown in a popout window. If ispopout is set to 0, then the browser will show the message in the Outlook on the web review pane.The message will open in the browser if you are logged in to your mailbox via Outlook on the web. You will be prompted to login if you are not already logged in with the browser.This URL cannot be accessed from within an iFrame.</summary>
        public string WebLink { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"attachments", (o,n) => { (o as Delta).Attachments = n.GetCollectionOfObjectValues<Attachment>().ToList(); } },
                {"bccRecipients", (o,n) => { (o as Delta).BccRecipients = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"body", (o,n) => { (o as Delta).Body = n.GetObjectValue<ItemBody>(); } },
                {"bodyPreview", (o,n) => { (o as Delta).BodyPreview = n.GetStringValue(); } },
                {"ccRecipients", (o,n) => { (o as Delta).CcRecipients = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"conversationId", (o,n) => { (o as Delta).ConversationId = n.GetStringValue(); } },
                {"conversationIndex", (o,n) => { (o as Delta).ConversationIndex = n.GetByteArrayValue(); } },
                {"extensions", (o,n) => { (o as Delta).Extensions = n.GetCollectionOfObjectValues<Extension>().ToList(); } },
                {"flag", (o,n) => { (o as Delta).Flag = n.GetObjectValue<FollowupFlag>(); } },
                {"from", (o,n) => { (o as Delta).From = n.GetObjectValue<Recipient>(); } },
                {"hasAttachments", (o,n) => { (o as Delta).HasAttachments = n.GetBoolValue(); } },
                {"importance", (o,n) => { (o as Delta).Importance = n.GetEnumValue<Importance>(); } },
                {"inferenceClassification", (o,n) => { (o as Delta).InferenceClassification = n.GetEnumValue<InferenceClassificationType>(); } },
                {"internetMessageHeaders", (o,n) => { (o as Delta).InternetMessageHeaders = n.GetCollectionOfObjectValues<InternetMessageHeader>().ToList(); } },
                {"internetMessageId", (o,n) => { (o as Delta).InternetMessageId = n.GetStringValue(); } },
                {"isDeliveryReceiptRequested", (o,n) => { (o as Delta).IsDeliveryReceiptRequested = n.GetBoolValue(); } },
                {"isDraft", (o,n) => { (o as Delta).IsDraft = n.GetBoolValue(); } },
                {"isRead", (o,n) => { (o as Delta).IsRead = n.GetBoolValue(); } },
                {"isReadReceiptRequested", (o,n) => { (o as Delta).IsReadReceiptRequested = n.GetBoolValue(); } },
                {"multiValueExtendedProperties", (o,n) => { (o as Delta).MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>().ToList(); } },
                {"parentFolderId", (o,n) => { (o as Delta).ParentFolderId = n.GetStringValue(); } },
                {"receivedDateTime", (o,n) => { (o as Delta).ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"replyTo", (o,n) => { (o as Delta).ReplyTo = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"sender", (o,n) => { (o as Delta).Sender = n.GetObjectValue<Recipient>(); } },
                {"sentDateTime", (o,n) => { (o as Delta).SentDateTime = n.GetDateTimeOffsetValue(); } },
                {"singleValueExtendedProperties", (o,n) => { (o as Delta).SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>().ToList(); } },
                {"subject", (o,n) => { (o as Delta).Subject = n.GetStringValue(); } },
                {"toRecipients", (o,n) => { (o as Delta).ToRecipients = n.GetCollectionOfObjectValues<Recipient>().ToList(); } },
                {"uniqueBody", (o,n) => { (o as Delta).UniqueBody = n.GetObjectValue<ItemBody>(); } },
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
            writer.WriteCollectionOfObjectValues<Attachment>("attachments", Attachments);
            writer.WriteCollectionOfObjectValues<Recipient>("bccRecipients", BccRecipients);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteStringValue("bodyPreview", BodyPreview);
            writer.WriteCollectionOfObjectValues<Recipient>("ccRecipients", CcRecipients);
            writer.WriteStringValue("conversationId", ConversationId);
            writer.WriteByteArrayValue("conversationIndex", ConversationIndex);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteObjectValue<FollowupFlag>("flag", Flag);
            writer.WriteObjectValue<Recipient>("from", From);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteEnumValue<InferenceClassificationType>("inferenceClassification", InferenceClassification);
            writer.WriteCollectionOfObjectValues<InternetMessageHeader>("internetMessageHeaders", InternetMessageHeaders);
            writer.WriteStringValue("internetMessageId", InternetMessageId);
            writer.WriteBoolValue("isDeliveryReceiptRequested", IsDeliveryReceiptRequested);
            writer.WriteBoolValue("isDraft", IsDraft);
            writer.WriteBoolValue("isRead", IsRead);
            writer.WriteBoolValue("isReadReceiptRequested", IsReadReceiptRequested);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteCollectionOfObjectValues<Recipient>("replyTo", ReplyTo);
            writer.WriteObjectValue<Recipient>("sender", Sender);
            writer.WriteDateTimeOffsetValue("sentDateTime", SentDateTime);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteStringValue("subject", Subject);
            writer.WriteCollectionOfObjectValues<Recipient>("toRecipients", ToRecipients);
            writer.WriteObjectValue<ItemBody>("uniqueBody", UniqueBody);
            writer.WriteStringValue("webLink", WebLink);
        }
    }
}
