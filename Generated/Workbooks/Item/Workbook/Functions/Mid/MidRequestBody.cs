using GraphSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Workbooks.Item.Workbook.Functions.Mid {
    public class MidRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json NumChars { get; set; }
        public Json StartNum { get; set; }
        public Json Text { get; set; }
        /// <summary>
        /// Instantiates a new midRequestBody and sets the default values.
        /// </summary>
        public MidRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"numChars", (o,n) => { (o as MidRequestBody).NumChars = n.GetObjectValue<Json>(); } },
                {"startNum", (o,n) => { (o as MidRequestBody).StartNum = n.GetObjectValue<Json>(); } },
                {"text", (o,n) => { (o as MidRequestBody).Text = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("numChars", NumChars);
            writer.WriteObjectValue<Json>("startNum", StartNum);
            writer.WriteObjectValue<Json>("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
