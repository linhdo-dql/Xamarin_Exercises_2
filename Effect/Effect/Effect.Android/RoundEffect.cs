using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Effect.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportEffect(typeof(RoundEffect), nameof(RoundEffect))]
namespace Effect.Droid
{
    public class RoundEffect : PlatformEffect
    {
        ViewOutlineProvider originalProvider;
        Android.Views.View effectTarget;
        protected override void OnAttached()
        {
            try
            {
                //Kiểm tra nếu Control bằng rỗng thì gán View cho Container chứa nó, nếu không thì gán cho Control.
                effectTarget = Control ?? Container;
                originalProvider = effectTarget.OutlineProvider;
                effectTarget.OutlineProvider = new CornerRadiusProvider(Element);
                effectTarget.ClipToOutline = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to set corner radius: {ex.Message}");
            }
        }

        protected override void OnDetached()
        {
            if (effectTarget != null)
            {
                effectTarget.OutlineProvider = originalProvider;
                effectTarget.ClipToOutline = false;
            }
        }
    }
}