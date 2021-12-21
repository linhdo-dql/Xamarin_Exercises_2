using ResfulApi.Models;
using ResfulAPI_Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResfulAPI_Demo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostDetailPage : ContentPage
    {
        public PostDetailPage(Post post)
        {
            InitializeComponent();
            DisplayAlert("x", "ax: "+post.Id, "ok");
            BindingContext = new PostDetailPageViewModel(this, Navigation, post);
        }
    }
}