using CustomRenderer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace CustomRenderer.CustomRendererClass
{
    public class CustomMap : Map
    {
        public List<MyPin> pins { get; set; }
    }
}
