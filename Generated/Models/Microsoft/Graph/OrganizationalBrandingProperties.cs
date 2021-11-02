using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GraphSdk.Models.Microsoft.Graph {
    public class OrganizationalBrandingProperties : Entity, IParsable {
        /// <summary>Color that will appear in place of the background image in low-bandwidth connections. We recommend that you use the primary color of your banner logo or your organization color. Specify this in hexadecimal format, for example, white is #FFFFFF.</summary>
        public string BackgroundColor { get; set; }
        /// <summary>Image that appears as the background of the sign-in page. The allowed types are PNG or JPEG not smaller than 300 KB and not larger than 1920 × 1080 pixels. A smaller image will reduce bandwidth requirements and make the page load faster.</summary>
        public byte[] BackgroundImage { get; set; }
        /// <summary>A banner version of your company logo that appears on the sign-in page. The allowed types are PNG or JPEG no larger than 36 × 245 pixels. We recommend using a transparent image with no padding around the logo.</summary>
        public byte[] BannerLogo { get; set; }
        /// <summary>Text that appears at the bottom of the sign-in box. You can use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be Unicode and not exceed 1024 characters.</summary>
        public string SignInPageText { get; set; }
        /// <summary>A square version of your company logo that appears in Windows 10 out-of-box experiences (OOBE) and when Windows Autopilot is enabled for deployment. Allowed types are PNG or JPEG no larger than 240 x 240 pixels and no more than 10 KB in size. We recommend using a transparent image with no padding around the logo.</summary>
        public byte[] SquareLogo { get; set; }
        /// <summary>String that shows as the hint in the username textbox on the sign-in screen. This text must be a Unicode, without links or code, and can't exceed 64 characters.</summary>
        public string UsernameHintText { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"backgroundColor", (o,n) => { (o as OrganizationalBrandingProperties).BackgroundColor = n.GetStringValue(); } },
                {"backgroundImage", (o,n) => { (o as OrganizationalBrandingProperties).BackgroundImage = n.GetByteArrayValue(); } },
                {"bannerLogo", (o,n) => { (o as OrganizationalBrandingProperties).BannerLogo = n.GetByteArrayValue(); } },
                {"signInPageText", (o,n) => { (o as OrganizationalBrandingProperties).SignInPageText = n.GetStringValue(); } },
                {"squareLogo", (o,n) => { (o as OrganizationalBrandingProperties).SquareLogo = n.GetByteArrayValue(); } },
                {"usernameHintText", (o,n) => { (o as OrganizationalBrandingProperties).UsernameHintText = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("backgroundColor", BackgroundColor);
            writer.WriteByteArrayValue("backgroundImage", BackgroundImage);
            writer.WriteByteArrayValue("bannerLogo", BannerLogo);
            writer.WriteStringValue("signInPageText", SignInPageText);
            writer.WriteByteArrayValue("squareLogo", SquareLogo);
            writer.WriteStringValue("usernameHintText", UsernameHintText);
        }
    }
}
