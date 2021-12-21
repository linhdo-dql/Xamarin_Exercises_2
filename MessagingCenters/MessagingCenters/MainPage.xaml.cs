using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MessagingCenters
{
    public partial class MainPage : ContentPage
    {
       
        public ObservableCollection<string> Messages { get; set; } = new ObservableCollection<string>();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void btnSendMessage_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Subscribe<Page, DateTime>(this, "tick", (p, datetime) =>
            {
                 Messages.Add("Sucrices at "+datetime.ToString("dd/MM/yyyy HH:mm:ss f"));
            });
        }
        private async void btnGoToPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ReceivePage());
        }
    }
}
