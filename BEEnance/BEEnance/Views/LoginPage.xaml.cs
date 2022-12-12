using BEEnance.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Acr.UserDialogs;

namespace BEEnance.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
            Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading("Будь ласка, зачекайте...");
            await Task.Delay(1000);

            // SIGNIN ТУТ
            using (var сlient = new HttpClient())
            {
                var endpoint = new Uri("https://trutenfinance-expenses-api.azurewebsites.net/Authentication/signin");
                var signupPost = new Models.User()
                {
                    id = 0, // айді користувача вимагається в API-запиті, але фактично він не перевіряється
                    username = txtUsername.Text,
                    password = txtPassword.Text
                };
                var newPostJson = JsonConvert.SerializeObject(signupPost);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result = сlient.PostAsync(endpoint, payload).Result;

                if (result.IsSuccessStatusCode == true)
                {
                    UserDialogs.Instance.HideLoading();
                    await DisplayAlert("Успіх!", "Ви успішно авторизувались.", "Ок");
                    await Navigation.PopAsync(false);
                    UserDialogs.Instance.ShowLoading("Будь ласка, зачекайте...");
                    await Task.Delay(1000);
                    Application.Current.MainPage = new AppShell();
                    UserDialogs.Instance.HideLoading();
                }
                else
                {
                    UserDialogs.Instance.HideLoading();
                    await DisplayAlert("Отакі-от справи", result.Content.ReadAsStringAsync().Result, "Ок");
                }
            }
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync(false);
            await Task.Delay(100);
            await Navigation.PushAsync(new RegisterPage(), false);
        }
    }
}
