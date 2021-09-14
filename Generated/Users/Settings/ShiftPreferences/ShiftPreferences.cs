using GraphServiceClient.Teamwork;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Users.Settings.ShiftPreferences {
    public class ShiftPreferences : ChangeTrackedEntity, IParsable {
        /// <summary>Availability of the user to be scheduled for work and its recurrence pattern.</summary>
        public List<ShiftAvailability> Availability { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"availability", (o,n) => { (o as ShiftPreferences).Availability = n.GetCollectionOfPrimitiveValues<ShiftAvailability>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<ShiftAvailability>("availability", Availability);
        }
    }
}
