using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MessagingCenters
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReceivePage : ContentPage
    {

        public ReceivePage()
        {
            InitializeComponent();
        }
        private void btnSendMessage_Clicked(Object sender, EventArgs e)
        {
            MessagingCenter.Send<Page, DateTime>(this, "tick", DateTime.Now);
        }
        private void btnBackPage_Clicked(Object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}