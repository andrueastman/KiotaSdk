using GraphServiceClient.Identity;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient {
    public class ColumnDefinition : Entity, IParsable {
        /// <summary>This column stores boolean values.</summary>
        public BooleanColumn Boolean { get; set; }
        /// <summary>This column's data is calculated based on other columns.</summary>
        public CalculatedColumn Calculated { get; set; }
        /// <summary>This column stores data from a list of choices.</summary>
        public ChoiceColumn Choice { get; set; }
        /// <summary>For site columns, the name of the group this column belongs to. Helps organize related columns.</summary>
        public string ColumnGroup { get; set; }
        /// <summary>This column stores currency values.</summary>
        public CurrencyColumn Currency { get; set; }
        /// <summary>This column stores DateTime values.</summary>
        public DateTimeColumn DateTime { get; set; }
        /// <summary>The default value for this column.</summary>
        public DefaultColumnValue DefaultValue { get; set; }
        /// <summary>The user-facing description of the column.</summary>
        public string Description { get; set; }
        /// <summary>The user-facing name of the column.</summary>
        public string DisplayName { get; set; }
        /// <summary>If true, no two list items may have the same value for this column.</summary>
        public bool? EnforceUniqueValues { get; set; }
        /// <summary>This column stores a geolocation.</summary>
        public GeolocationColumn Geolocation { get; set; }
        /// <summary>Specifies whether the column is displayed in the user interface.</summary>
        public bool? Hidden { get; set; }
        /// <summary>Specifies whether the column values can used for sorting and searching.</summary>
        public bool? Indexed { get; set; }
        /// <summary>This column's data is looked up from another source in the site.</summary>
        public LookupColumn Lookup { get; set; }
        /// <summary>The API-facing name of the column as it appears in the [fields][] on a [listItem][]. For the user-facing name, see displayName.</summary>
        public string Name { get; set; }
        /// <summary>This column stores number values.</summary>
        public NumberColumn Number { get; set; }
        /// <summary>This column stores Person or Group values.</summary>
        public PersonOrGroupColumn PersonOrGroup { get; set; }
        /// <summary>Specifies whether the column values can be modified.</summary>
        public bool? ReadOnly { get; set; }
        /// <summary>Specifies whether the column value is not optional.</summary>
        public bool? Required { get; set; }
        /// <summary>This column stores text values.</summary>
        public TextColumn Text { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"boolean", (o,n) => { (o as ColumnDefinition).Boolean = n.GetObjectValue<BooleanColumn>(); } },
                {"calculated", (o,n) => { (o as ColumnDefinition).Calculated = n.GetObjectValue<CalculatedColumn>(); } },
                {"choice", (o,n) => { (o as ColumnDefinition).Choice = n.GetObjectValue<ChoiceColumn>(); } },
                {"columnGroup", (o,n) => { (o as ColumnDefinition).ColumnGroup = n.GetStringValue(); } },
                {"currency", (o,n) => { (o as ColumnDefinition).Currency = n.GetObjectValue<CurrencyColumn>(); } },
                {"dateTime", (o,n) => { (o as ColumnDefinition).DateTime = n.GetObjectValue<DateTimeColumn>(); } },
                {"defaultValue", (o,n) => { (o as ColumnDefinition).DefaultValue = n.GetObjectValue<DefaultColumnValue>(); } },
                {"description", (o,n) => { (o as ColumnDefinition).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ColumnDefinition).DisplayName = n.GetStringValue(); } },
                {"enforceUniqueValues", (o,n) => { (o as ColumnDefinition).EnforceUniqueValues = n.GetBoolValue(); } },
                {"geolocation", (o,n) => { (o as ColumnDefinition).Geolocation = n.GetObjectValue<GeolocationColumn>(); } },
                {"hidden", (o,n) => { (o as ColumnDefinition).Hidden = n.GetBoolValue(); } },
                {"indexed", (o,n) => { (o as ColumnDefinition).Indexed = n.GetBoolValue(); } },
                {"lookup", (o,n) => { (o as ColumnDefinition).Lookup = n.GetObjectValue<LookupColumn>(); } },
                {"name", (o,n) => { (o as ColumnDefinition).Name = n.GetStringValue(); } },
                {"number", (o,n) => { (o as ColumnDefinition).Number = n.GetObjectValue<NumberColumn>(); } },
                {"personOrGroup", (o,n) => { (o as ColumnDefinition).PersonOrGroup = n.GetObjectValue<PersonOrGroupColumn>(); } },
                {"readOnly", (o,n) => { (o as ColumnDefinition).ReadOnly = n.GetBoolValue(); } },
                {"required", (o,n) => { (o as ColumnDefinition).Required = n.GetBoolValue(); } },
                {"text", (o,n) => { (o as ColumnDefinition).Text = n.GetObjectValue<TextColumn>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<BooleanColumn>("boolean", Boolean);
            writer.WriteObjectValue<CalculatedColumn>("calculated", Calculated);
            writer.WriteObjectValue<ChoiceColumn>("choice", Choice);
            writer.WriteStringValue("columnGroup", ColumnGroup);
            writer.WriteObjectValue<CurrencyColumn>("currency", Currency);
            writer.WriteObjectValue<DateTimeColumn>("dateTime", DateTime);
            writer.WriteObjectValue<DefaultColumnValue>("defaultValue", DefaultValue);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enforceUniqueValues", EnforceUniqueValues);
            writer.WriteObjectValue<GeolocationColumn>("geolocation", Geolocation);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteBoolValue("indexed", Indexed);
            writer.WriteObjectValue<LookupColumn>("lookup", Lookup);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<NumberColumn>("number", Number);
            writer.WriteObjectValue<PersonOrGroupColumn>("personOrGroup", PersonOrGroup);
            writer.WriteBoolValue("readOnly", ReadOnly);
            writer.WriteBoolValue("required", Required);
            writer.WriteObjectValue<TextColumn>("text", Text);
        }
    }
}
