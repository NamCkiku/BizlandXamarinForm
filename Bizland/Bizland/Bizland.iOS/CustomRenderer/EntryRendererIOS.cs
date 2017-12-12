using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Bizland.iOS.CustomRenderer;
using Bizland.CustomControl;
using Xamarin.Forms.Platform.iOS;
using CoreAnimation;

[assembly: ExportRenderer(typeof(CustomEntryRenderer), typeof(EntryRendererIOS))]
namespace Bizland.iOS.CustomRenderer
{
    public class EntryRendererIOS : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //Control.BackgroundColor = UIColor.FromRGB(119, 171, 233);
                Control.BorderStyle = UITextBorderStyle.None;
                //Control.Font = UIFont.FromName("HelveticaNeue-Thin", 20);
                //Control.SetValueForKeyPath(UIColor.White, new NSString("_placeholderLabel.textColor"));
                Control.Layer.SublayerTransform = CATransform3D.MakeTranslation(0, 0, 0);
                //Thêm chiều cao cho Entry iOS
                //Element.HeightRequest = 40;
            }
            if (e.OldElement != null || Element == null)
                return;

            Element.HeightRequest = 40;
        }
    }
}