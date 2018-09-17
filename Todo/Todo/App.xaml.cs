using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Todo.Views;
using Todo.Services;
using System.IO;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Todo
{
    public partial class App : Application
    {
        static MockDataStore database;

        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();
        }

        public static MockDataStore Database
        {
            get
            {
                if (database == null)
                {
                    database = new MockDataStore(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
