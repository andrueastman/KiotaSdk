using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Models.Microsoft.Graph {
    public class WorkbookOperationError : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The error code.</summary>
        public string Code { get; set; }
        public WorkbookOperationError InnerError { get; set; }
        /// <summary>The error message.</summary>
        public string Message { get; set; }
        /// <summary>
        /// Instantiates a new workbookOperationError and sets the default values.
        /// </summary>
        public WorkbookOperationError() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"code", (o,n) => { (o as WorkbookOperationError).Code = n.GetStringValue(); } },
                {"innerError", (o,n) => { (o as WorkbookOperationError).InnerError = n.GetObjectValue<WorkbookOperationError>(); } },
                {"message", (o,n) => { (o as WorkbookOperationError).Message = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("code", Code);
            writer.WriteObjectValue<WorkbookOperationError>("innerError", InnerError);
            writer.WriteStringValue("message", Message);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
