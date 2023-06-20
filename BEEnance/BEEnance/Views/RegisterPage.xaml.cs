using Acr.UserDialogs;
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
            UserDialogs.Instance.ShowLoading("Будь ласка, зачекайте...");
            await Task.Delay(1000);
            // ЦЕ SIGNUP, ОТУТ ПРЯМ ТОЧНО
            using (var сlient = new HttpClient())
            {
                var endpoint = new Uri("https://trutenfinance-expenses-api.azurewebsites.net/Authentication/signup");
                var signupPost = new Models.User()
                {
                    id = 0, // айді буде автоматично просвоєне базою даних, тому відправляємо 0 і не паримось
                    username = txtUsername.Text,
                    password = txtPassword.Text,
                    email = txtEmail.Text,
                };
                var newPostJson = JsonConvert.SerializeObject(signupPost);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result = сlient.PostAsync(endpoint, payload).Result;

                if (result.IsSuccessStatusCode == true)
                {
                    UserDialogs.Instance.HideLoading();
                    await DisplayAlert("Успіх!", "Ви успішно зареєструвались.", "Ок");
                    UserDialogs.Instance.ShowLoading("Будь ласка, зачекайте...");
                    await Task.Delay(1000);
                    await Navigation.PushAsync(new LoginPage(), false);
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
            await Navigation.PushAsync(new LoginPage(), false);

        }
    }
}
