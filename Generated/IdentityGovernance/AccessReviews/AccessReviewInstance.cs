using GraphServiceClient.Identity;
using GraphServiceClient.IdentityGovernance.AccessReviews.Definitions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.IdentityGovernance.AccessReviews {
    public class AccessReviewInstance : Entity, IParsable {
        /// <summary>Each user reviewed in an accessReviewInstance has a decision item representing if they were approved, denied, or not yet reviewed.</summary>
        public List<AccessReviewInstanceDecisionItem> Decisions { get; set; }
        /// <summary>DateTime when review instance is scheduled to end.The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        public List<AccessReviewReviewerScope> FallbackReviewers { get; set; }
        public List<AccessReviewReviewerScope> Reviewers { get; set; }
        /// <summary>Created based on scope and instanceEnumerationScope at the accessReviewScheduleDefinition level. Defines the scope of users reviewed in a group. Supports $select and $filter (contains only). Read-only.</summary>
        public AccessReviewScope Scope { get; set; }
        /// <summary>DateTime when review instance is scheduled to start. May be in the future. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>Specifies the status of an accessReview. Possible values: Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed. Supports $select, $orderby, and $filter (eq only). Read-only.</summary>
        public string Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"decisions", (o,n) => { (o as AccessReviewInstance).Decisions = n.GetCollectionOfObjectValues<AccessReviewInstanceDecisionItem>().ToList(); } },
                {"endDateTime", (o,n) => { (o as AccessReviewInstance).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"fallbackReviewers", (o,n) => { (o as AccessReviewInstance).FallbackReviewers = n.GetCollectionOfPrimitiveValues<AccessReviewReviewerScope>().ToList(); } },
                {"reviewers", (o,n) => { (o as AccessReviewInstance).Reviewers = n.GetCollectionOfPrimitiveValues<AccessReviewReviewerScope>().ToList(); } },
                {"scope", (o,n) => { (o as AccessReviewInstance).Scope = n.GetObjectValue<AccessReviewScope>(); } },
                {"startDateTime", (o,n) => { (o as AccessReviewInstance).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as AccessReviewInstance).Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AccessReviewInstanceDecisionItem>("decisions", Decisions);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteCollectionOfPrimitiveValues<AccessReviewReviewerScope>("fallbackReviewers", FallbackReviewers);
            writer.WriteCollectionOfPrimitiveValues<AccessReviewReviewerScope>("reviewers", Reviewers);
            writer.WriteObjectValue<AccessReviewScope>("scope", Scope);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("status", Status);
        }
    }
}
