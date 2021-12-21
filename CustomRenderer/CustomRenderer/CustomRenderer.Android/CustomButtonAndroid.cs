using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomRenderer.CustomRendererClass;
using CustomRenderer.Droid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(CustomButton),typeof(CustomButtonAndroid))]
namespace CustomRenderer.Droid
{
    [Obsolete]
    public class CustomButtonAndroid : ButtonRenderer
    {
        protected override void OnElementPropertyChanged( object sender, PropertyChangedEventArgs e )
        {
            base.OnElementPropertyChanged(sender, e);
            var button = (CustomButton) Element;
            GradientStrokeDrawable gradientStroke = new GradientStrokeDrawable();
            if (button.IsEnabled)
            {
                gradientStroke.SetColor(button.IsEnableColor.ToAndroid());
            }
            else
            {
                gradientStroke.SetColor(button.IsDisableColor.ToAndroid());
            }
            gradientStroke.SetCornerRadius(button.CornerRadius);
            Control.SetBackground(gradientStroke);
        }
    }
}