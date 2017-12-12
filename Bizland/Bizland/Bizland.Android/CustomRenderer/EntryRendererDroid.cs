using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Bizland.Droid.CustomRenderer;
using Xamarin.Forms.Platform.Android;
using Android.Content.Res;
using Bizland.CustomControl;

[assembly: ExportRenderer(typeof(CustomEntryRenderer), typeof(EntryRendererDroid))]
namespace Bizland.Droid.CustomRenderer
{
    public class EntryRendererDroid : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.Gray));
                Control.SetBackgroundDrawable(null);
            }
        }
    }
}