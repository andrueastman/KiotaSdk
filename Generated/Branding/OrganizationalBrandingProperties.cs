using GraphServiceClient.Identity;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GraphServiceClient.Branding {
    public class OrganizationalBrandingProperties : Entity, IParsable {
        /// <summary>Color that will appear in place of the background image in low-bandwidth connections. The primary color of your banner logo or your organization color is recommended to be used here. Specify this in hexadecimal (for example, white is #FFFFFF).</summary>
        public string BackgroundColor { get; set; }
        /// <summary>Image that appears as the background of the sign in page. .png or .jpg not larger than 1920x1080 and smaller than 300kb. A smaller image will reduce bandwidth requirements and make page loads more performant.</summary>
        public byte[] BackgroundImage { get; set; }
        /// <summary>A banner version of your company logo which appears appears on the sign-in page. .png or .jpg no larger than 36x245px. We recommend using a transparent image with no padding around the logo.</summary>
        public byte[] BannerLogo { get; set; }
        /// <summary>Text that appears at the bottom of the sign-in box. You can use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be Unicode and not exceed 1024 characters.</summary>
        public string SignInPageText { get; set; }
        /// <summary>Square version of your company logo. This appears in Windows 10 out-of-box (OOBE) experiences and when Windows Autopilot is enabled for deployment. .png or .jpg no larger than 240x240px and no more than 10kb in size. We recommend using a transparent image with no padding around the logo.</summary>
        public byte[] SquareLogo { get; set; }
        /// <summary>String that shows as the hint in the username textbox on the sign in screen. This text must be Unicode, without links or code, and can't exceed 64 characters.</summary>
        public string UsernameHintText { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"backgroundColor", (o,n) => { (o as OrganizationalBrandingProperties).BackgroundColor = n.GetStringValue(); } },
                {"backgroundImage", (o,n) => { (o as OrganizationalBrandingProperties).BackgroundImage = n.GetObjectValue<Byte[]>(); } },
                {"bannerLogo", (o,n) => { (o as OrganizationalBrandingProperties).BannerLogo = n.GetObjectValue<Byte[]>(); } },
                {"signInPageText", (o,n) => { (o as OrganizationalBrandingProperties).SignInPageText = n.GetStringValue(); } },
                {"squareLogo", (o,n) => { (o as OrganizationalBrandingProperties).SquareLogo = n.GetObjectValue<Byte[]>(); } },
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
            writer.WriteObjectValue<Byte[]>("backgroundImage", BackgroundImage);
            writer.WriteObjectValue<Byte[]>("bannerLogo", BannerLogo);
            writer.WriteStringValue("signInPageText", SignInPageText);
            writer.WriteObjectValue<Byte[]>("squareLogo", SquareLogo);
            writer.WriteStringValue("usernameHintText", UsernameHintText);
        }
    }
}
