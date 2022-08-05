using System;
using Android.Graphics.Drawables;
using Udf.CustomControls;
using Udf.Droid.CustomControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

#pragma warning disable CS0612 // Type or member is obsolete
[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
#pragma warning restore CS0612 // Type or member is obsolete

namespace Udf.Droid.CustomControls
{
    [Obsolete]
    public class CustomEntryRenderer : EntryRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {

                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(25);
                gradientDrawable.SetStroke(3, Android.Graphics.Color.ParseColor("#36354A"));
                gradientDrawable.SetColor(Android.Graphics.Color.Transparent);
                Control.SetPadding(50, 0, 15,0 );
                Control.SetBackground(gradientDrawable);


            }

        }

    }
}
