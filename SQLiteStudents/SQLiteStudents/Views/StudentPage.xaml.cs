using SQLiteStudents;
using SQLiteStudents.Models;
using SQLiteStudents.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQliteDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentPage : ContentPage
    {
        public StudentPage(int id)
        {
            InitializeComponent();
            BindingContext = new StudentPageViewModel(this, Navigation, id);
        }

    }
}