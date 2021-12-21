using CustomRenderer.CustomRendererClass;
using CustomRenderer.Models;
using MUAHO.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace CustomRenderer.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private string _entry;
        private bool _isEnableButton = false;
        private CustomMap _customMap = new CustomMap();
        public List<MyPin> Pins { get; set; }
        public MainPageViewModel(Page page)
        {
            MyPin pin = new MyPin
            {
                Type = PinType.Place,
                Position = new Position(37.79752, -122.40183),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Name = "Xamarin",
                Url = "http://xamarin.com/about/"
            };
            Pins = new List<MyPin>() { pin};
            page.FindByName<CustomMap>("MyMap").pins = new List<MyPin>() { pin };
            page.FindByName<CustomMap>("MyMap").Pins.Add(pin);
            page.FindByName<CustomMap>("MyMap").MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.79752, -122.40183), Distance.FromMiles(1)));
        }
        public string EntryText
        {
            get { return _entry; }
            set { 
                IsEnableButton = !string.IsNullOrWhiteSpace(value);
                SetProperty(ref _entry, value); 
            }
        }

        public bool IsEnableButton
        {
            get { return _isEnableButton; }
            set { SetProperty(ref _isEnableButton, value); }
        }
        
    }
}
