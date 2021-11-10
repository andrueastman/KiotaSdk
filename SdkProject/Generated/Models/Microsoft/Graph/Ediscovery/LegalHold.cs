using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Models.Microsoft.Graph.Ediscovery {
    public class LegalHold : Entity, IParsable {
        /// <summary>KQL query that specifies content to be held in the specified locations. To learn more, see Keyword queries and search conditions for Content Search and eDiscovery.  To hold all content in the specified locations, leave contentQuery blank.</summary>
        public string ContentQuery { get; set; }
        /// <summary>The user who created the legal hold.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>The date and time the legal hold was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The legal hold description.</summary>
        public string Description { get; set; }
        /// <summary>The display name of the legal hold.</summary>
        public string DisplayName { get; set; }
        /// <summary>Lists any errors that happened while placing the hold.</summary>
        public List<string> Errors { get; set; }
        /// <summary>Indicates whether the hold is enabled and actively holding content.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>the user who last modified the legal hold.</summary>
        public IdentitySet LastModifiedBy { get; set; }
        /// <summary>The date and time the legal hold was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Data source entity for SharePoint sites associated with the legal hold.</summary>
        public List<SiteSource> SiteSources { get; set; }
        /// <summary>The status of the legal hold. Possible values are: Pending, Error, Success, UnknownFutureValue.</summary>
        public LegalHoldStatus? Status { get; set; }
        /// <summary>Data source entity for a the legal hold. This is the container for a mailbox and OneDrive for Business site.</summary>
        public List<UserSource> UserSources { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"contentQuery", (o,n) => { (o as LegalHold).ContentQuery = n.GetStringValue(); } },
                {"createdBy", (o,n) => { (o as LegalHold).CreatedBy = n.GetObjectValue<IdentitySet>(); } },
                {"createdDateTime", (o,n) => { (o as LegalHold).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as LegalHold).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as LegalHold).DisplayName = n.GetStringValue(); } },
                {"errors", (o,n) => { (o as LegalHold).Errors = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isEnabled", (o,n) => { (o as LegalHold).IsEnabled = n.GetBoolValue(); } },
                {"lastModifiedBy", (o,n) => { (o as LegalHold).LastModifiedBy = n.GetObjectValue<IdentitySet>(); } },
                {"lastModifiedDateTime", (o,n) => { (o as LegalHold).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"siteSources", (o,n) => { (o as LegalHold).SiteSources = n.GetCollectionOfObjectValues<SiteSource>().ToList(); } },
                {"status", (o,n) => { (o as LegalHold).Status = n.GetEnumValue<LegalHoldStatus>(); } },
                {"userSources", (o,n) => { (o as LegalHold).UserSources = n.GetCollectionOfObjectValues<UserSource>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("contentQuery", ContentQuery);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("errors", Errors);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<SiteSource>("siteSources", SiteSources);
            writer.WriteEnumValue<LegalHoldStatus>("status", Status);
            writer.WriteCollectionOfObjectValues<UserSource>("userSources", UserSources);
        }
    }
}
