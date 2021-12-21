using SQliteDemo.Views;
using SQLiteStudents.Database;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteStudents
{
    public partial class App : Application
    {
        static StudentSQLite database;
        public static StudentSQLite Database
        {
            get 
            { 
                if(database == null)
                {
                    database = new StudentSQLite(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "StudentDB.db3"));
                }
                return database; 
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
