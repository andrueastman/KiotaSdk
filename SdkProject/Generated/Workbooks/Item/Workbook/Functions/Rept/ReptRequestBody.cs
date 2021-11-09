using GraphSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Workbooks.Item.Workbook.Functions.Rept {
    public class ReptRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json NumberTimes { get; set; }
        public Json Text { get; set; }
        /// <summary>
        /// Instantiates a new reptRequestBody and sets the default values.
        /// </summary>
        public ReptRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"numberTimes", (o,n) => { (o as ReptRequestBody).NumberTimes = n.GetObjectValue<Json>(); } },
                {"text", (o,n) => { (o as ReptRequestBody).Text = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("numberTimes", NumberTimes);
            writer.WriteObjectValue<Json>("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}