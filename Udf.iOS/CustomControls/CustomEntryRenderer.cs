using System;
using CoreGraphics;
using Udf.CustomControls;
using Udf.iOS.CustomControls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Udf.iOS.CustomControls
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control.Layer.CornerRadius = 15;
            Control.Layer.BorderWidth = 3f;
            Control.Layer.BorderColor = Color.FromHex("#36354A").ToCGColor();
            Control.Layer.BackgroundColor = Color.Transparent.ToCGColor();

            Control.LeftView = new UIView(new CGRect(15, 0, 15, 0));
            Control.LeftViewMode = UITextFieldViewMode.Always;
            Control.RightView = new UIView(new CGRect(15, 0, 15, 0));
            Control.RightViewMode = UITextFieldViewMode.Always;
        }
    }
}
