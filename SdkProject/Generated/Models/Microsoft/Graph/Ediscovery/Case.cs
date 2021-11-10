using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Models.Microsoft.Graph.Ediscovery {
    public class Case : Entity, IParsable {
        /// <summary>The user who closed the case.</summary>
        public IdentitySet ClosedBy { get; set; }
        /// <summary>The date and time when the case was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ClosedDateTime { get; set; }
        /// <summary>The date and time when the entity was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Returns a list of case custodian objects for this case.  Nullable.</summary>
        public List<Custodian> Custodians { get; set; }
        /// <summary>The case description.</summary>
        public string Description { get; set; }
        /// <summary>The case name.</summary>
        public string DisplayName { get; set; }
        /// <summary>The external case number for customer reference.</summary>
        public string ExternalId { get; set; }
        /// <summary>The last user who modified the entity.</summary>
        public IdentitySet LastModifiedBy { get; set; }
        /// <summary>The latest date and time when the case was modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Returns a list of case legalHold objects for this case.  Nullable.</summary>
        public List<LegalHold> LegalHolds { get; set; }
        /// <summary>Returns a list of case noncustodialDataSource objects for this case.  Nullable.</summary>
        public List<NoncustodialDataSource> NoncustodialDataSources { get; set; }
        /// <summary>Returns a list of case operation objects for this case. Nullable.</summary>
        public List<CaseOperation> Operations { get; set; }
        /// <summary>Returns a list of reviewSet objects in the case. Read-only. Nullable.</summary>
        public List<ReviewSet> ReviewSets { get; set; }
        public CaseSettings Settings { get; set; }
        /// <summary>Returns a list of sourceCollection objects associated with this case.</summary>
        public List<SourceCollection> SourceCollections { get; set; }
        /// <summary>The case status. Possible values are unknown, active, pendingDelete, closing, closed, and closedWithError. For details, see the following table.</summary>
        public CaseStatus? Status { get; set; }
        /// <summary>Returns a list of tag objects associated to this case.</summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"closedBy", (o,n) => { (o as Case).ClosedBy = n.GetObjectValue<IdentitySet>(); } },
                {"closedDateTime", (o,n) => { (o as Case).ClosedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", (o,n) => { (o as Case).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"custodians", (o,n) => { (o as Case).Custodians = n.GetCollectionOfObjectValues<Custodian>().ToList(); } },
                {"description", (o,n) => { (o as Case).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Case).DisplayName = n.GetStringValue(); } },
                {"externalId", (o,n) => { (o as Case).ExternalId = n.GetStringValue(); } },
                {"lastModifiedBy", (o,n) => { (o as Case).LastModifiedBy = n.GetObjectValue<IdentitySet>(); } },
                {"lastModifiedDateTime", (o,n) => { (o as Case).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"legalHolds", (o,n) => { (o as Case).LegalHolds = n.GetCollectionOfObjectValues<LegalHold>().ToList(); } },
                {"noncustodialDataSources", (o,n) => { (o as Case).NoncustodialDataSources = n.GetCollectionOfObjectValues<NoncustodialDataSource>().ToList(); } },
                {"operations", (o,n) => { (o as Case).Operations = n.GetCollectionOfObjectValues<CaseOperation>().ToList(); } },
                {"reviewSets", (o,n) => { (o as Case).ReviewSets = n.GetCollectionOfObjectValues<ReviewSet>().ToList(); } },
                {"settings", (o,n) => { (o as Case).Settings = n.GetObjectValue<CaseSettings>(); } },
                {"sourceCollections", (o,n) => { (o as Case).SourceCollections = n.GetCollectionOfObjectValues<SourceCollection>().ToList(); } },
                {"status", (o,n) => { (o as Case).Status = n.GetEnumValue<CaseStatus>(); } },
                {"tags", (o,n) => { (o as Case).Tags = n.GetCollectionOfObjectValues<Tag>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IdentitySet>("closedBy", ClosedBy);
            writer.WriteDateTimeOffsetValue("closedDateTime", ClosedDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<Custodian>("custodians", Custodians);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<LegalHold>("legalHolds", LegalHolds);
            writer.WriteCollectionOfObjectValues<NoncustodialDataSource>("noncustodialDataSources", NoncustodialDataSources);
            writer.WriteCollectionOfObjectValues<CaseOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<ReviewSet>("reviewSets", ReviewSets);
            writer.WriteObjectValue<CaseSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<SourceCollection>("sourceCollections", SourceCollections);
            writer.WriteEnumValue<CaseStatus>("status", Status);
            writer.WriteCollectionOfObjectValues<Tag>("tags", Tags);
        }
    }
}
