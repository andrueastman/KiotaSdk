using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Me.Microsoft.Graph.GetMailTips {
    public class Microsoft.graph.getMailTipsResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> EmailAddresses { get; set; }
        public MailTipsType MailTipsOptions { get; set; }
        /// <summary>
        /// Instantiates a new Microsoft.graph.getMailTipsResponse and sets the default values.
        /// </summary>
        public Microsoft.graph.getMailTipsResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"emailAddresses", (o,n) => { (o as Microsoft.graph.getMailTipsResponse).EmailAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"mailTipsOptions", (o,n) => { (o as Microsoft.graph.getMailTipsResponse).MailTipsOptions = n.GetObjectValue<MailTipsType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("emailAddresses", EmailAddresses);
            writer.WriteObjectValue<MailTipsType>("mailTipsOptions", MailTipsOptions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
