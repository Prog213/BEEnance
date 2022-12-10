using BEEnance.Data;
using BEEnance.Helpers;
using BEEnance.Services;
using BEEnance.Views;
using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BEEnance
{
    public partial class App : Application
    {
        private static BeenanceDB beenanceDB;

        public static BeenanceDB BeenanceDB // створюємо файл з БД, якщо він його ще не було
        {
            get
            {
                if (beenanceDB == null)
                {
                    beenanceDB = new BeenanceDB(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "BeenanceDB.db3"));
                }
                return beenanceDB;
            }
        }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            OnResume();
        }

        protected override void OnSleep()
        {
            TheTheme.SetTheme();
            RequestedThemeChanged -= App_RequestedThemeChanged;
        }

        protected override void OnResume()
        {
            TheTheme.SetTheme();
            RequestedThemeChanged += App_RequestedThemeChanged;
        }
        private void App_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                TheTheme.SetTheme();
            });
        }
    }
}
