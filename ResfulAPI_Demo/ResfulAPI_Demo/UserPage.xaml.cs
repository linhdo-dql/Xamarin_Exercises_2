using Newtonsoft.Json;
using ResfulApi.Models;
using ResfulAPI_Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResfulAPI_Demo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    { 
         
        public UserPage(int userId)
        {
            InitializeComponent();
            BindingContext = new UserPageViewModel(this, Navigation, userId);
           
        }                                                                                      
    }
}