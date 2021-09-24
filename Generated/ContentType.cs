using GraphServiceClient.Identity;
using GraphServiceClient.Sites;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient {
    public class ContentType : Entity, IParsable {
        /// <summary>If true, the content type cannot be modified unless this value is first set to false.</summary>
        public bool? @ReadOnly { get; set; }
        /// <summary>If true, the content type cannot be modified by users or through push-down operations. Only site collection administrators can seal or unseal content types.</summary>
        public bool? @Sealed { get; set; }
        /// <summary>The collection of columns that are required by this content type</summary>
        public List<ColumnLink> ColumnLinks { get; set; }
        /// <summary>The descriptive text for the item.</summary>
        public string Description { get; set; }
        /// <summary>The name of the group this content type belongs to. Helps organize related content types.</summary>
        public string Group { get; set; }
        /// <summary>Indicates whether the content type is hidden in the list's 'New' menu.</summary>
        public bool? Hidden { get; set; }
        /// <summary>If this content type is inherited from another scope (like a site), provides a reference to the item where the content type is defined.</summary>
        public ItemReference InheritedFrom { get; set; }
        /// <summary>The name of the content type.</summary>
        public string Name { get; set; }
        /// <summary>Specifies the order in which the content type appears in the selection UI.</summary>
        public ContentTypeOrder Order { get; set; }
        /// <summary>The unique identifier of the content type.</summary>
        public string ParentId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"@ReadOnly", (o,n) => { (o as ContentType).@ReadOnly = n.GetBoolValue(); } },
                {"@Sealed", (o,n) => { (o as ContentType).@Sealed = n.GetBoolValue(); } },
                {"columnLinks", (o,n) => { (o as ContentType).ColumnLinks = n.GetCollectionOfObjectValues<ColumnLink>().ToList(); } },
                {"description", (o,n) => { (o as ContentType).Description = n.GetStringValue(); } },
                {"group", (o,n) => { (o as ContentType).Group = n.GetStringValue(); } },
                {"hidden", (o,n) => { (o as ContentType).Hidden = n.GetBoolValue(); } },
                {"inheritedFrom", (o,n) => { (o as ContentType).InheritedFrom = n.GetObjectValue<ItemReference>(); } },
                {"name", (o,n) => { (o as ContentType).Name = n.GetStringValue(); } },
                {"order", (o,n) => { (o as ContentType).Order = n.GetObjectValue<ContentTypeOrder>(); } },
                {"parentId", (o,n) => { (o as ContentType).ParentId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("@ReadOnly", @ReadOnly);
            writer.WriteBoolValue("@Sealed", @Sealed);
            writer.WriteCollectionOfObjectValues<ColumnLink>("columnLinks", ColumnLinks);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("group", Group);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteObjectValue<ItemReference>("inheritedFrom", InheritedFrom);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ContentTypeOrder>("order", Order);
            writer.WriteStringValue("parentId", ParentId);
        }
    }
}
