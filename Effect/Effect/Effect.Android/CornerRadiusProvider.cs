using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Effect.Droid
{
    public class CornerRadiusProvider : ViewOutlineProvider
    {
        Element element;

        public CornerRadiusProvider(Element formsElement)
        {
            element = formsElement;
        }
        public override void GetOutline(Android.Views.View view, Outline outline)
        {
            float scale = view.Resources.DisplayMetrics.Density;
            double width = (double)element.GetValue(VisualElement.WidthRequestProperty) * scale;
            double height = (double)element.GetValue(VisualElement.WidthRequestProperty) * scale;
            float minDimension = 2*(float)Math.Min(height, width);
            float radius = minDimension / 2f;
            Android.Graphics.Rect rect = new Android.Graphics.Rect(0, 0, (int)width, (int)height);
            outline.SetRoundRect(rect, radius);
        }
    }
}