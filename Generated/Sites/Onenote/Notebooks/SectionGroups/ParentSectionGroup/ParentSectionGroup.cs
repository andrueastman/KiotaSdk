using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Sites.Onenote.Notebooks.SectionGroups.ParentSectionGroup {
    public class ParentSectionGroup : OnenoteEntityHierarchyModel, IParsable {
        /// <summary>The notebook that contains the section group. Read-only.</summary>
        public Notebook ParentNotebook { get; set; }
        /// <summary>The section group that contains the section group. Read-only.</summary>
        public SectionGroup ParentSectionGroup_prop { get; set; }
        /// <summary>The section groups in the section. Read-only. Nullable.</summary>
        public List<SectionGroup> SectionGroups { get; set; }
        /// <summary>The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.</summary>
        public string SectionGroupsUrl { get; set; }
        /// <summary>The sections in the section group. Read-only. Nullable.</summary>
        public List<OnenoteSection> Sections { get; set; }
        /// <summary>The URL for the sections navigation property, which returns all the sections in the section group. Read-only.</summary>
        public string SectionsUrl { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"parentNotebook", (o,n) => { (o as ParentSectionGroup).ParentNotebook = n.GetObjectValue<Notebook>(); } },
                {"parentSectionGroup", (o,n) => { (o as ParentSectionGroup).ParentSectionGroup_prop = n.GetObjectValue<SectionGroup>(); } },
                {"sectionGroups", (o,n) => { (o as ParentSectionGroup).SectionGroups = n.GetCollectionOfObjectValues<SectionGroup>().ToList(); } },
                {"sectionGroupsUrl", (o,n) => { (o as ParentSectionGroup).SectionGroupsUrl = n.GetStringValue(); } },
                {"sections", (o,n) => { (o as ParentSectionGroup).Sections = n.GetCollectionOfObjectValues<OnenoteSection>().ToList(); } },
                {"sectionsUrl", (o,n) => { (o as ParentSectionGroup).SectionsUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Notebook>("parentNotebook", ParentNotebook);
            writer.WriteObjectValue<SectionGroup>("parentSectionGroup", ParentSectionGroup_prop);
            writer.WriteCollectionOfObjectValues<SectionGroup>("sectionGroups", SectionGroups);
            writer.WriteStringValue("sectionGroupsUrl", SectionGroupsUrl);
            writer.WriteCollectionOfObjectValues<OnenoteSection>("sections", Sections);
            writer.WriteStringValue("sectionsUrl", SectionsUrl);
        }
    }
}
