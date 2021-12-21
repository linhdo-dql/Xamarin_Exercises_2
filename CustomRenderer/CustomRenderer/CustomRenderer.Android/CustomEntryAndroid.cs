using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using CustomRenderer.CustomRendererClass;
using CustomRenderer.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(CustomEntry),typeof(CustomEntryAndroid))]
namespace CustomRenderer.Droid
{
    [Obsolete]
    public class CustomEntryAndroid : EntryRenderer
    {
        protected override void OnElementChanged( ElementChangedEventArgs<Entry> e )
        {
            base.OnElementChanged(e);
            if(e.NewElement != null)
            {
                var entry = (CustomEntry) Element;
                //.....//........//.......//.........//
                entry.TextTransform = TextTransform.None;
                //Custom background cho Entry
                var gradientBackground = new GradientDrawable();
                //Hình chữ nhật (Default)
                gradientBackground.SetShape(ShapeType.Rectangle);
                //Màu nền
                gradientBackground.SetColor(entry.BackgroundColor.ToAndroid());
                //Độ dày và màu của viền dựa trên CustomEntry
                gradientBackground.SetStroke(entry.BorderWidth, entry.BorderColor.ToAndroid());
                //Bo tròn trên CustomEntry
                gradientBackground.SetCornerRadius(DpToPixels(this.Context, entry.CornerRadius));
                ///Padding cho Entry
                gradientBackground.SetPadding((int) DpToPixels(this.Context,Convert.ToSingle(20)),
                                              (int) DpToPixels(this.Context, Convert.ToSingle(10)),
                                              Control.PaddingLeft,
                                              Control.PaddingTop);
                //.........//.......//...........//.......//..........//.........//............//......//
                Control.SetBackground(gradientBackground);
            } 
            
        }
        public static float DpToPixels( Context context, float valueInDp )
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
    }
}