using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ResolutionGroupName("Effect")]
[assembly: ExportEffect(typeof(Effect.Droid.FocusEffect), nameof(Effect.Droid.FocusEffect))]
namespace Effect.Droid
{
    public class FocusEffect : PlatformEffect
    {
        //Tạo ra 2 màu theo nền tảng Android
        Android.Graphics.Color originalBackgroundColor = new Android.Graphics.Color(0, 0, 0, 0);
        Android.Graphics.Color backgroundColor;
        //Phương thức xảy ra khi đính kèm Effect
        protected override void OnAttached()
        {
            try
            {
                backgroundColor = Android.Graphics.Color.Red;
                Control.SetBackgroundColor(backgroundColor);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            try
            {
                //Set effect cho thuộc tính IsFocused của control
                if (args.PropertyName == "IsFocused")
                {
                    //Nếu control được Focused và Background hiện tại có màu giống với backgroundColor của Effect thì đổi về originalBackgroundColor
                    if (((Android.Graphics.Drawables.ColorDrawable)Control.Background).Color == backgroundColor)
                    {
                        Control.SetBackgroundColor(originalBackgroundColor);
                        
                    }
                    else
                    {
                        Control.SetBackgroundColor(backgroundColor);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }
    }
}
