using MUAHO.ViewModels;
using SQLiteStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace SQLiteStudents.ViewModels
{
    public class StudentPageViewModel: BaseViewModel
    {
        INavigation Navigation { get; set; }
        private string _name;
        private string _class;
        private DateTime _date = DateTime.Now;
        public StudentPageViewModel(Page page, INavigation navigation, int id)
        {
            if(id!=0)
            {
                BindingInfo(id);
            }
            InsertOrUpdate = new Command(() =>
            {
                Student student = new Student() {Id=id, Name = NameStudent, Class = ClassStudent, Date = DateOfBirthStudent };
                App.Database.InsertOrUpdateStudent(student);
                navigation.PushAsync(new MainPage());
            });
            
        }
        public string NameStudent
        {
            get { return _name; }  
            set { SetProperty(ref _name, value); }
        }
        public DateTime DateOfBirthStudent
        {
            get { return _date; }
            set { SetProperty(ref _date,value); }
        }
        public string ClassStudent
        {
            get { return _class; }
            set { SetProperty(ref _class, value); }
        }
        public Command InsertOrUpdate { get; }
        public void BindingInfo(int id)
        {
            Student student = App.Database.GetStudentById(id).Result;
            NameStudent = student.Name;
            ClassStudent = student.Class;
            DateOfBirthStudent = student.Date;
        }
    }
}
