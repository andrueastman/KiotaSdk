using GraphSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Workbooks.Item.Workbook.Functions.FindB {
    public class FindBRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json FindText { get; set; }
        public Json StartNum { get; set; }
        public Json WithinText { get; set; }
        /// <summary>
        /// Instantiates a new findBRequestBody and sets the default values.
        /// </summary>
        public FindBRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"findText", (o,n) => { (o as FindBRequestBody).FindText = n.GetObjectValue<Json>(); } },
                {"startNum", (o,n) => { (o as FindBRequestBody).StartNum = n.GetObjectValue<Json>(); } },
                {"withinText", (o,n) => { (o as FindBRequestBody).WithinText = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("findText", FindText);
            writer.WriteObjectValue<Json>("startNum", StartNum);
            writer.WriteObjectValue<Json>("withinText", WithinText);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
