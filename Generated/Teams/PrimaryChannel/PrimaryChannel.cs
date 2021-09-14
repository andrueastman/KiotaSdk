using GraphServiceClient.Identity;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Teams.PrimaryChannel {
    public class PrimaryChannel : Entity, IParsable {
        /// <summary>Read only. Timestamp at which the channel was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Optional textual description for the channel.</summary>
        public string Description { get; set; }
        /// <summary>Channel name as it will appear to the user in Microsoft Teams.</summary>
        public string DisplayName { get; set; }
        /// <summary>The email address for sending messages to the channel. Read-only.</summary>
        public string Email { get; set; }
        /// <summary>Metadata for the location where the channel's files are stored.</summary>
        public DriveItem FilesFolder { get; set; }
        /// <summary>Indicates whether the channel should automatically be marked 'favorite' for all members of the team. Can only be set programmatically with Create team. Default: false.</summary>
        public bool? IsFavoriteByDefault { get; set; }
        /// <summary>A collection of membership records associated with the channel.</summary>
        public List<ConversationMember> Members { get; set; }
        /// <summary>The type of the channel. Can be set during creation and can't be changed. Default: standard.</summary>
        public ChannelMembershipType MembershipType { get; set; }
        /// <summary>A collection of all the messages in the channel. A navigation property. Nullable.</summary>
        public List<ChatMessage> Messages { get; set; }
        /// <summary>A collection of all the tabs in the channel. A navigation property.</summary>
        public List<TeamsTab> Tabs { get; set; }
        /// <summary>A hyperlink that will go to the channel in Microsoft Teams. This is the URL that you get when you right-click a channel in Microsoft Teams and select Get link to channel. This URL should be treated as an opaque blob, and not parsed. Read-only.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as PrimaryChannel).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as PrimaryChannel).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as PrimaryChannel).DisplayName = n.GetStringValue(); } },
                {"email", (o,n) => { (o as PrimaryChannel).Email = n.GetStringValue(); } },
                {"filesFolder", (o,n) => { (o as PrimaryChannel).FilesFolder = n.GetObjectValue<DriveItem>(); } },
                {"isFavoriteByDefault", (o,n) => { (o as PrimaryChannel).IsFavoriteByDefault = n.GetBoolValue(); } },
                {"members", (o,n) => { (o as PrimaryChannel).Members = n.GetCollectionOfObjectValues<ConversationMember>().ToList(); } },
                {"membershipType", (o,n) => { (o as PrimaryChannel).MembershipType = n.GetObjectValue<ChannelMembershipType>(); } },
                {"messages", (o,n) => { (o as PrimaryChannel).Messages = n.GetCollectionOfObjectValues<ChatMessage>().ToList(); } },
                {"tabs", (o,n) => { (o as PrimaryChannel).Tabs = n.GetCollectionOfObjectValues<TeamsTab>().ToList(); } },
                {"webUrl", (o,n) => { (o as PrimaryChannel).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteObjectValue<DriveItem>("filesFolder", FilesFolder);
            writer.WriteBoolValue("isFavoriteByDefault", IsFavoriteByDefault);
            writer.WriteCollectionOfObjectValues<ConversationMember>("members", Members);
            writer.WriteObjectValue<ChannelMembershipType>("membershipType", MembershipType);
            writer.WriteCollectionOfObjectValues<ChatMessage>("messages", Messages);
            writer.WriteCollectionOfObjectValues<TeamsTab>("tabs", Tabs);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
