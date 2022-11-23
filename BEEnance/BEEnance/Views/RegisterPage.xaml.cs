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
                var signupPost = new APIs.User()
                {
                    id = 0, // айді буде автоматично просвоєне базою даних, тому відправляємо 0 і не паримось
                    username = txtUsername.Text,
                    password = txtPassword.Text,
                    email = txtEmail.Text,
                };
                var newPostJson = JsonConvert.SerializeObject(signupPost);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result = сlient.PostAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;

                await DisplayAlert("Отакі-от справи", result, "Ok"); // оця фігня тільки для дебагу треба
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LoginPage());
        }
    }
}
