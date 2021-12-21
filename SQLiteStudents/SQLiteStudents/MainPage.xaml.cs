using SQLiteStudents.Models;
using SQLiteStudents.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLiteStudents
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(this, Navigation);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new MainPageViewModel(this, Navigation);
        }
    }
}
