using BEEnance.ViewModels;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
            // SIGNIN ТУТ
            using (var сlient = new HttpClient())
            {
                var endpoint = new Uri("https://trutenfinance-expenses-api.azurewebsites.net/Authentication/signin");
                var signupPost = new APIs.User()
                {
                    username = txtUsername.Text,
                    password = txtPassword.Text,
                };
                var newPostJson = JsonConvert.SerializeObject(signupPost);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                //var result = сlient.PostAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;
                var result = сlient.PostAsync(endpoint, payload).Result;

                if (result.IsSuccessStatusCode == true)
                {
                    await DisplayAlert("Успіх!", "Ви успішно авторизувались.", "Ок");
                    await Navigation.PopAsync(false);
                    Application.Current.MainPage = new AppShell();
                }
                else
                {
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
