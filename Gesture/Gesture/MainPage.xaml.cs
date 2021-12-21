using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Gesture
{
    public partial class MainPage : ContentPage
    {
        int oneTapCount = 0;
        int doubleTapCount = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        private void OneTap_Gesture(Object sender, EventArgs e)
        {
            oneTapCount++;
            lblOneTap.Text = "Tap: "+ oneTapCount;
        }

        private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
            var label = (sender as Element)?.Parent as Label;
            e.Data.Properties.Add("Text", label.Text);
        }

        private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
        {
            var data = e.Data.Properties["Text"];
            var frame = (sender as Element)?.Parent as Frame;
            frame.Content = new Label()
            {
                Text = data.ToString()

            };
            

        }
    }
}
