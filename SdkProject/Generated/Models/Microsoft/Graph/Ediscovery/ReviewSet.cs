using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Models.Microsoft.Graph.Ediscovery {
    public class ReviewSet : Entity, IParsable {
        /// <summary>The user who created the review set. Read-only.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>The datetime when the review set was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The review set name. The name is unique with a maximum limit of 64 characters.</summary>
        public string DisplayName { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<ReviewSetQuery> Queries { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdBy", (o,n) => { (o as ReviewSet).CreatedBy = n.GetObjectValue<IdentitySet>(); } },
                {"createdDateTime", (o,n) => { (o as ReviewSet).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as ReviewSet).DisplayName = n.GetStringValue(); } },
                {"queries", (o,n) => { (o as ReviewSet).Queries = n.GetCollectionOfObjectValues<ReviewSetQuery>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<ReviewSetQuery>("queries", Queries);
        }
    }
}
