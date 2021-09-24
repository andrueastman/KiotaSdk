using GraphServiceClient.Identity;
using GraphServiceClient.IdentityGovernance.AccessReviews;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.IdentityGovernance {
    public class AccessReviewScheduleDefinition : Entity, IParsable {
        /// <summary>User who created this review. Read-only.</summary>
        public UserIdentity CreatedBy { get; set; }
        /// <summary>Timestamp when the access review series was created. Supports $select. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description provided by review creators to provide more context of the review to admins. Supports $select.</summary>
        public string DescriptionForAdmins { get; set; }
        /// <summary>Description provided  by review creators to provide more context of the review to reviewers. Reviewers will see this description in the email sent to them requesting their review. Supports $select.</summary>
        public string DescriptionForReviewers { get; set; }
        /// <summary>Name of the access review series. Supports $select and $orderBy. Required on create.</summary>
        public string DisplayName { get; set; }
        /// <summary>This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. See accessReviewReviewerScope. Replaces backupReviewers. Supports $select.</summary>
        public List<AccessReviewReviewerScope> FallbackReviewers { get; set; }
        /// <summary>This property is required when scoping a review to guest users' access across all Microsoft 365 groups and determines which Microsoft 365 groups are reviewed. Each group will become a unique accessReviewInstance of the access review series.  For supported scopes, see accessReviewScope. Supports $select. For examples of options for configuring instanceEnumerationScope, see Configure the scope of your access review definition using the Microsoft Graph API.</summary>
        public AccessReviewScope InstanceEnumerationScope { get; set; }
        /// <summary>Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there is an instance for each recurrence.</summary>
        public List<AccessReviewInstance> Instances { get; set; }
        /// <summary>Timestamp when the access review series was last modified. Supports $select. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>This collection of access review scopes is used to define who are the reviewers. The reviewers property is only updatable if individual users are assigned as reviewers. Required on create. Supports $select. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.</summary>
        public List<AccessReviewReviewerScope> Reviewers { get; set; }
        /// <summary>Defines scope of resources to review. For supported scopes, see accessReviewScope. Required on create. Supports $select and $filter (contains only). For examples of options for configuring scope, see Configure the scope of your access review definition using the Microsoft Graph API.</summary>
        public AccessReviewScope Scope { get; set; }
        /// <summary>The settings for an access review series, see type definition below. Supports $select. Required on create.</summary>
        public AccessReviewScheduleSettings Settings { get; set; }
        /// <summary>This read-only field specifies the status of an access review. The typical states include Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed.  Supports $select, $orderby, and $filter (eq only). Read-only.</summary>
        public string Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdBy", (o,n) => { (o as AccessReviewScheduleDefinition).CreatedBy = n.GetObjectValue<UserIdentity>(); } },
                {"createdDateTime", (o,n) => { (o as AccessReviewScheduleDefinition).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"descriptionForAdmins", (o,n) => { (o as AccessReviewScheduleDefinition).DescriptionForAdmins = n.GetStringValue(); } },
                {"descriptionForReviewers", (o,n) => { (o as AccessReviewScheduleDefinition).DescriptionForReviewers = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AccessReviewScheduleDefinition).DisplayName = n.GetStringValue(); } },
                {"fallbackReviewers", (o,n) => { (o as AccessReviewScheduleDefinition).FallbackReviewers = n.GetCollectionOfPrimitiveValues<AccessReviewReviewerScope>().ToList(); } },
                {"instanceEnumerationScope", (o,n) => { (o as AccessReviewScheduleDefinition).InstanceEnumerationScope = n.GetObjectValue<AccessReviewScope>(); } },
                {"instances", (o,n) => { (o as AccessReviewScheduleDefinition).Instances = n.GetCollectionOfObjectValues<AccessReviewInstance>().ToList(); } },
                {"lastModifiedDateTime", (o,n) => { (o as AccessReviewScheduleDefinition).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"reviewers", (o,n) => { (o as AccessReviewScheduleDefinition).Reviewers = n.GetCollectionOfPrimitiveValues<AccessReviewReviewerScope>().ToList(); } },
                {"scope", (o,n) => { (o as AccessReviewScheduleDefinition).Scope = n.GetObjectValue<AccessReviewScope>(); } },
                {"settings", (o,n) => { (o as AccessReviewScheduleDefinition).Settings = n.GetObjectValue<AccessReviewScheduleSettings>(); } },
                {"status", (o,n) => { (o as AccessReviewScheduleDefinition).Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UserIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("descriptionForAdmins", DescriptionForAdmins);
            writer.WriteStringValue("descriptionForReviewers", DescriptionForReviewers);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<AccessReviewReviewerScope>("fallbackReviewers", FallbackReviewers);
            writer.WriteObjectValue<AccessReviewScope>("instanceEnumerationScope", InstanceEnumerationScope);
            writer.WriteCollectionOfObjectValues<AccessReviewInstance>("instances", Instances);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<AccessReviewReviewerScope>("reviewers", Reviewers);
            writer.WriteObjectValue<AccessReviewScope>("scope", Scope);
            writer.WriteObjectValue<AccessReviewScheduleSettings>("settings", Settings);
            writer.WriteStringValue("status", Status);
        }
    }
}