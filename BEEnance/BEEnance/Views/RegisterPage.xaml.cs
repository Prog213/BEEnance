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

namespace BEEnance.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked1(object sender, EventArgs e)
        {
            // ЦЕ SIGNUP, ОТУТ ПРЯМ ТОЧНО
            using (var сlient = new HttpClient())
            {
                var endpoint = new Uri("https://trutenfinance-expenses-api.azurewebsites.net/Authentication/signup");
                var signupPost = new Models.User()
                {
                    Id = 0, // айді буде автоматично просвоєне базою даних, тому відправляємо 0 і не паримось
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                };
                var newPostJson = JsonConvert.SerializeObject(signupPost);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result = сlient.PostAsync(endpoint, payload).Result;

                if (result.IsSuccessStatusCode == true)
                {
                    await DisplayAlert("Успіх!", "Ви успішно авторизувались.", "Ок");
                    await Navigation.PopAsync(false);
                    await Task.Delay(100);
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
            await Navigation.PushAsync(new LoginPage(), false);

        }
    }
}
