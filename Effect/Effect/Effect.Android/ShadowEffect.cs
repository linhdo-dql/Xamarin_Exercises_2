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


[assembly: ExportEffect(typeof(Effect.Droid.ShadowEffect), nameof(Effect.Droid.ShadowEffect))]
namespace Effect.Droid
{
    public class ShadowEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var label = Control as Android.Widget.TextView;
                //Lấy tất cả các Effect sử dụng cho element này và duyệt để lấy ShadowEffect
                var shadowEffect = (Effect.ShadowEffect)Element.Effects.FirstOrDefault(e => e is Effect.ShadowEffect);
                //Nếu ShadowEffect tồn tại thì set các giá trị cho Effect
                if(shadowEffect != null)
                {
                    float radius = shadowEffect.Radius;
                    Android.Graphics.Color color = shadowEffect.Color.ToAndroid();
                    float distanceX = shadowEffect.DistanceX;
                    float distanceY = shadowEffect.DistanceY;
                    //Gắn các thuộc tính của Effect vào đối tượng TextBox trong Native App
                    label.SetShadowLayer(radius, distanceX, distanceY, color);
                }
            }catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
            

        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}