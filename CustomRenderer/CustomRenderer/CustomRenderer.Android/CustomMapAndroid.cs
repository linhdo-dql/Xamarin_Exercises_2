using Android.App;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomRenderer.CustomRendererClass;
using CustomRenderer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.Android;
using Xamarin.Forms.Platform.Android;

namespace CustomRenderer.Droid
{
    [Obsolete]
    public class CustomMapAndroid : MapRenderer, GoogleMap.IInfoWindowAdapter
    {
        List<MyPin> customPins;
        public CustomMapAndroid(Context context): base(context)
        {

        }
        protected override void OnElementChanged( ElementChangedEventArgs<Map> e )
        {
            base.OnElementChanged(e);
            if ( e.OldElement != null )
            {
                NativeMap.InfoWindowClick -= OnInfoWindowClick;
            }

            if ( e.NewElement != null )
            {
                var formsMap = (CustomMap) e.NewElement;
                customPins = formsMap.pins;
            }
        }

        private void OnInfoWindowClick( object sender, GoogleMap.InfoWindowClickEventArgs e )
        {
            throw new NotImplementedException();
        }

        protected override void OnMapReady( GoogleMap map )
        {
            base.OnMapReady(map);
            NativeMap.InfoWindowClick += OnInfoWindowClick;
            NativeMap.SetInfoWindowAdapter(this);
        }
        public View GetInfoContents( Marker marker )
        {
            throw new NotImplementedException();
        }

        public View GetInfoWindow( Marker marker )
        {
            throw new NotImplementedException();
        }
    }
}