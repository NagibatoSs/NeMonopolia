using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeMonopolia3
{
    public partial class App : Application
    {
        private static DataBase dataBase;
        public static DataBase DataBase
        {
            get
            {
                if (dataBase == null)
                {
                    dataBase = new DataBase(Path.Combine(Environment.
                        GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyTest.db"));
                }
                return dataBase;
            }
        }
        public App()
        {
            InitializeComponent();
           // MainPage = new NavigationPage(new ActionView());
             MainPage = new Bag();
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
