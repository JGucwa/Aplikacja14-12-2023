using System;
using Xamarin.Forms;
using Aplikacja.Views;
using Xamarin.Forms.Xaml;
using System.IO;

namespace Aplikacja
{
    public partial class App : Application
    {
        static Database database;

        public static Database Database
        {
            get
            {
                if(database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"wydatek.db");
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StronaGlowna());
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
