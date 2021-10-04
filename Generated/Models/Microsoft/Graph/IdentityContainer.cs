using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class IdentityContainer : Entity, IParsable {
        public List<IdentityApiConnector> ApiConnectors { get; set; }
        public List<B2xIdentityUserFlow> B2xUserFlows { get; set; }
        public ConditionalAccessRoot ConditionalAccess { get; set; }
        public List<IdentityProviderBase> IdentityProviders { get; set; }
        public List<IdentityUserFlowAttribute> UserFlowAttributes { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"apiConnectors", (o,n) => { (o as IdentityContainer).ApiConnectors = n.GetCollectionOfObjectValues<IdentityApiConnector>().ToList(); } },
                {"b2xUserFlows", (o,n) => { (o as IdentityContainer).B2xUserFlows = n.GetCollectionOfObjectValues<B2xIdentityUserFlow>().ToList(); } },
                {"conditionalAccess", (o,n) => { (o as IdentityContainer).ConditionalAccess = n.GetObjectValue<ConditionalAccessRoot>(); } },
                {"identityProviders", (o,n) => { (o as IdentityContainer).IdentityProviders = n.GetCollectionOfObjectValues<IdentityProviderBase>().ToList(); } },
                {"userFlowAttributes", (o,n) => { (o as IdentityContainer).UserFlowAttributes = n.GetCollectionOfObjectValues<IdentityUserFlowAttribute>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<IdentityApiConnector>("apiConnectors", ApiConnectors);
            writer.WriteCollectionOfObjectValues<B2xIdentityUserFlow>("b2xUserFlows", B2xUserFlows);
            writer.WriteObjectValue<ConditionalAccessRoot>("conditionalAccess", ConditionalAccess);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("identityProviders", IdentityProviders);
            writer.WriteCollectionOfObjectValues<IdentityUserFlowAttribute>("userFlowAttributes", UserFlowAttributes);
        }
    }
}
