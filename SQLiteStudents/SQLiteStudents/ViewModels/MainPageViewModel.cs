using MUAHO.ViewModels;
using SQliteDemo.Views;
using SQLiteStudents.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace SQLiteStudents.ViewModels
{
    
    public class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<Student> Students { get; set; }
        public MainPageViewModel(Page page, INavigation navigation)
        {
            Students = new ObservableCollection<Student>(App.Database.GetAllStudent().Result.ToList());
            Delete = new Command((x) =>
            {
                Student s = x as Student;
                Students.Remove(s);
                App.Database.DeleteStudent(s);
                
            });
            Add = new Command(() =>
            {
                navigation.PushAsync(new StudentPage(0));
            });
            Update = new Command((x) =>
            {
                Student s = x as Student;
                navigation.PushAsync(new StudentPage(s.Id));
            });
        }
        public Command Delete { get; }
        public Command Update { get; }
        public Command Add { get; }
    }
}
