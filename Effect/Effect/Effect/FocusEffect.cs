using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Effect
{
    public class FocusEffect : RoutingEffect
    {
        public FocusEffect() : base($"Effect.{nameof(FocusEffect)}")
        {
        }
    }
}
