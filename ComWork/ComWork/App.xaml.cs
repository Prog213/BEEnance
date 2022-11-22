using ComWork.Services;
using ComWork.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("QB.ttf", Alias ="QB")]
[assembly: ExportFont("QL.ttf", Alias = "QL")]
[assembly: ExportFont("QM.ttf", Alias = "QM")]
[assembly: ExportFont("QR.ttf", Alias = "QR")]
[assembly: ExportFont("QS.ttf", Alias = "QS")]
namespace ComWork
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
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
