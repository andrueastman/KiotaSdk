using GraphSdk.Models.Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Workbooks.Item.Workbook.Functions.Permutationa {
    public class PermutationaRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public Json Number { get; set; }
        public Json NumberChosen { get; set; }
        /// <summary>
        /// Instantiates a new permutationaRequestBody and sets the default values.
        /// </summary>
        public PermutationaRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"number", (o,n) => { (o as PermutationaRequestBody).Number = n.GetObjectValue<Json>(); } },
                {"numberChosen", (o,n) => { (o as PermutationaRequestBody).NumberChosen = n.GetObjectValue<Json>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("number", Number);
            writer.WriteObjectValue<Json>("numberChosen", NumberChosen);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
