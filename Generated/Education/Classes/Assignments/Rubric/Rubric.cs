using GraphServiceClient.Identity;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Education.Classes.Assignments.Rubric {
    public class Rubric : Entity, IParsable {
        /// <summary>The user who created this resource.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of this rubric.</summary>
        public EducationItemBody Description { get; set; }
        /// <summary>The name of this rubric.</summary>
        public string DisplayName { get; set; }
        /// <summary>The grading type of this rubric -- null for a no-points rubric, or educationAssignmentPointsGradeType for a points rubric.</summary>
        public EducationAssignmentGradeType Grading { get; set; }
        /// <summary>The last user to modify the resource.</summary>
        public IdentitySet LastModifiedBy { get; set; }
        /// <summary>Moment in time when the resource was last modified.  The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The collection of levels making up this rubric.</summary>
        public List<RubricLevel> Levels { get; set; }
        /// <summary>The collection of qualities making up this rubric.</summary>
        public List<RubricQuality> Qualities { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdBy", (o,n) => { (o as Rubric).CreatedBy = n.GetObjectValue<IdentitySet>(); } },
                {"createdDateTime", (o,n) => { (o as Rubric).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as Rubric).Description = n.GetObjectValue<EducationItemBody>(); } },
                {"displayName", (o,n) => { (o as Rubric).DisplayName = n.GetStringValue(); } },
                {"grading", (o,n) => { (o as Rubric).Grading = n.GetObjectValue<EducationAssignmentGradeType>(); } },
                {"lastModifiedBy", (o,n) => { (o as Rubric).LastModifiedBy = n.GetObjectValue<IdentitySet>(); } },
                {"lastModifiedDateTime", (o,n) => { (o as Rubric).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"levels", (o,n) => { (o as Rubric).Levels = n.GetCollectionOfPrimitiveValues<RubricLevel>().ToList(); } },
                {"qualities", (o,n) => { (o as Rubric).Qualities = n.GetCollectionOfPrimitiveValues<RubricQuality>().ToList(); } },
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
            writer.WriteObjectValue<EducationItemBody>("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<EducationAssignmentGradeType>("grading", Grading);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<RubricLevel>("levels", Levels);
            writer.WriteCollectionOfPrimitiveValues<RubricQuality>("qualities", Qualities);
        }
    }
}
