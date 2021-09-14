using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Me.ContactFolders.Contacts.Microsoft.Graph.Delta() {
    public class Microsoft.graph.delta : OutlookItem, IParsable {
        /// <summary>The name of the contact's assistant.</summary>
        public string AssistantName { get; set; }
        /// <summary>The contact's birthday. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? Birthday { get; set; }
        /// <summary>The contact's business address.</summary>
        public PhysicalAddress BusinessAddress { get; set; }
        /// <summary>The business home page of the contact.</summary>
        public string BusinessHomePage { get; set; }
        /// <summary>The contact's business phone numbers.</summary>
        public List<string> BusinessPhones { get; set; }
        /// <summary>The names of the contact's children.</summary>
        public List<string> Children { get; set; }
        /// <summary>The name of the contact's company.</summary>
        public string CompanyName { get; set; }
        /// <summary>The contact's department.</summary>
        public string Department { get; set; }
        /// <summary>The contact's display name. You can specify the display name in a create or update operation. Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified. To preserve a pre-existing value, always include it as displayName in an update operation.</summary>
        public string DisplayName { get; set; }
        /// <summary>The contact's email addresses.</summary>
        public List<EmailAddress> EmailAddresses { get; set; }
        /// <summary>The collection of open extensions defined for the contact. Nullable.</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>The name the contact is filed under.</summary>
        public string FileAs { get; set; }
        /// <summary>The contact's generation.</summary>
        public string Generation { get; set; }
        /// <summary>The contact's given name.</summary>
        public string GivenName { get; set; }
        /// <summary>The contact's home address.</summary>
        public PhysicalAddress HomeAddress { get; set; }
        /// <summary>The contact's home phone numbers.</summary>
        public List<string> HomePhones { get; set; }
        /// <summary>The contact's instant messaging (IM) addresses.</summary>
        public List<string> ImAddresses { get; set; }
        /// <summary>The contact's initials.</summary>
        public string Initials { get; set; }
        /// <summary>The contact’s job title.</summary>
        public string JobTitle { get; set; }
        /// <summary>The name of the contact's manager.</summary>
        public string Manager { get; set; }
        /// <summary>The contact's middle name.</summary>
        public string MiddleName { get; set; }
        /// <summary>The contact's mobile phone number.</summary>
        public string MobilePhone { get; set; }
        /// <summary>The collection of multi-value extended properties defined for the contact. Read-only. Nullable.</summary>
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
        /// <summary>The contact's nickname.</summary>
        public string NickName { get; set; }
        /// <summary>The location of the contact's office.</summary>
        public string OfficeLocation { get; set; }
        /// <summary>Other addresses for the contact.</summary>
        public PhysicalAddress OtherAddress { get; set; }
        /// <summary>The ID of the contact's parent folder.</summary>
        public string ParentFolderId { get; set; }
        /// <summary>The user's notes about the contact.</summary>
        public string PersonalNotes { get; set; }
        /// <summary>Optional contact picture. You can get or set a photo for a contact.</summary>
        public ProfilePhoto Photo { get; set; }
        /// <summary>The contact's profession.</summary>
        public string Profession { get; set; }
        /// <summary>The collection of single-value extended properties defined for the contact. Read-only. Nullable.</summary>
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
        /// <summary>The name of the contact's spouse/partner.</summary>
        public string SpouseName { get; set; }
        /// <summary>The contact's surname.</summary>
        public string Surname { get; set; }
        /// <summary>The contact's title.</summary>
        public string Title { get; set; }
        /// <summary>The phonetic Japanese company name of the contact.</summary>
        public string YomiCompanyName { get; set; }
        /// <summary>The phonetic Japanese given name (first name) of the contact.</summary>
        public string YomiGivenName { get; set; }
        /// <summary>The phonetic Japanese surname (last name)  of the contact.</summary>
        public string YomiSurname { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assistantName", (o,n) => { (o as Microsoft.graph.delta).AssistantName = n.GetStringValue(); } },
                {"birthday", (o,n) => { (o as Microsoft.graph.delta).Birthday = n.GetDateTimeOffsetValue(); } },
                {"businessAddress", (o,n) => { (o as Microsoft.graph.delta).BusinessAddress = n.GetObjectValue<PhysicalAddress>(); } },
                {"businessHomePage", (o,n) => { (o as Microsoft.graph.delta).BusinessHomePage = n.GetStringValue(); } },
                {"businessPhones", (o,n) => { (o as Microsoft.graph.delta).BusinessPhones = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"children", (o,n) => { (o as Microsoft.graph.delta).Children = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"companyName", (o,n) => { (o as Microsoft.graph.delta).CompanyName = n.GetStringValue(); } },
                {"department", (o,n) => { (o as Microsoft.graph.delta).Department = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Microsoft.graph.delta).DisplayName = n.GetStringValue(); } },
                {"emailAddresses", (o,n) => { (o as Microsoft.graph.delta).EmailAddresses = n.GetCollectionOfPrimitiveValues<EmailAddress>().ToList(); } },
                {"extensions", (o,n) => { (o as Microsoft.graph.delta).Extensions = n.GetCollectionOfObjectValues<Extension>().ToList(); } },
                {"fileAs", (o,n) => { (o as Microsoft.graph.delta).FileAs = n.GetStringValue(); } },
                {"generation", (o,n) => { (o as Microsoft.graph.delta).Generation = n.GetStringValue(); } },
                {"givenName", (o,n) => { (o as Microsoft.graph.delta).GivenName = n.GetStringValue(); } },
                {"homeAddress", (o,n) => { (o as Microsoft.graph.delta).HomeAddress = n.GetObjectValue<PhysicalAddress>(); } },
                {"homePhones", (o,n) => { (o as Microsoft.graph.delta).HomePhones = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"imAddresses", (o,n) => { (o as Microsoft.graph.delta).ImAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"initials", (o,n) => { (o as Microsoft.graph.delta).Initials = n.GetStringValue(); } },
                {"jobTitle", (o,n) => { (o as Microsoft.graph.delta).JobTitle = n.GetStringValue(); } },
                {"manager", (o,n) => { (o as Microsoft.graph.delta).Manager = n.GetStringValue(); } },
                {"middleName", (o,n) => { (o as Microsoft.graph.delta).MiddleName = n.GetStringValue(); } },
                {"mobilePhone", (o,n) => { (o as Microsoft.graph.delta).MobilePhone = n.GetStringValue(); } },
                {"multiValueExtendedProperties", (o,n) => { (o as Microsoft.graph.delta).MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>().ToList(); } },
                {"nickName", (o,n) => { (o as Microsoft.graph.delta).NickName = n.GetStringValue(); } },
                {"officeLocation", (o,n) => { (o as Microsoft.graph.delta).OfficeLocation = n.GetStringValue(); } },
                {"otherAddress", (o,n) => { (o as Microsoft.graph.delta).OtherAddress = n.GetObjectValue<PhysicalAddress>(); } },
                {"parentFolderId", (o,n) => { (o as Microsoft.graph.delta).ParentFolderId = n.GetStringValue(); } },
                {"personalNotes", (o,n) => { (o as Microsoft.graph.delta).PersonalNotes = n.GetStringValue(); } },
                {"photo", (o,n) => { (o as Microsoft.graph.delta).Photo = n.GetObjectValue<ProfilePhoto>(); } },
                {"profession", (o,n) => { (o as Microsoft.graph.delta).Profession = n.GetStringValue(); } },
                {"singleValueExtendedProperties", (o,n) => { (o as Microsoft.graph.delta).SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>().ToList(); } },
                {"spouseName", (o,n) => { (o as Microsoft.graph.delta).SpouseName = n.GetStringValue(); } },
                {"surname", (o,n) => { (o as Microsoft.graph.delta).Surname = n.GetStringValue(); } },
                {"title", (o,n) => { (o as Microsoft.graph.delta).Title = n.GetStringValue(); } },
                {"yomiCompanyName", (o,n) => { (o as Microsoft.graph.delta).YomiCompanyName = n.GetStringValue(); } },
                {"yomiGivenName", (o,n) => { (o as Microsoft.graph.delta).YomiGivenName = n.GetStringValue(); } },
                {"yomiSurname", (o,n) => { (o as Microsoft.graph.delta).YomiSurname = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assistantName", AssistantName);
            writer.WriteDateTimeOffsetValue("birthday", Birthday);
            writer.WriteObjectValue<PhysicalAddress>("businessAddress", BusinessAddress);
            writer.WriteStringValue("businessHomePage", BusinessHomePage);
            writer.WriteCollectionOfPrimitiveValues<string>("businessPhones", BusinessPhones);
            writer.WriteCollectionOfPrimitiveValues<string>("children", Children);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("department", Department);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<EmailAddress>("emailAddresses", EmailAddresses);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteStringValue("fileAs", FileAs);
            writer.WriteStringValue("generation", Generation);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteObjectValue<PhysicalAddress>("homeAddress", HomeAddress);
            writer.WriteCollectionOfPrimitiveValues<string>("homePhones", HomePhones);
            writer.WriteCollectionOfPrimitiveValues<string>("imAddresses", ImAddresses);
            writer.WriteStringValue("initials", Initials);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("manager", Manager);
            writer.WriteStringValue("middleName", MiddleName);
            writer.WriteStringValue("mobilePhone", MobilePhone);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("nickName", NickName);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteObjectValue<PhysicalAddress>("otherAddress", OtherAddress);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteStringValue("personalNotes", PersonalNotes);
            writer.WriteObjectValue<ProfilePhoto>("photo", Photo);
            writer.WriteStringValue("profession", Profession);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteStringValue("spouseName", SpouseName);
            writer.WriteStringValue("surname", Surname);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("yomiCompanyName", YomiCompanyName);
            writer.WriteStringValue("yomiGivenName", YomiGivenName);
            writer.WriteStringValue("yomiSurname", YomiSurname);
        }
    }
}
