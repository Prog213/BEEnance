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
                    id = 0, // айді користувача вимагається в API-запиті, але фактично він не перевіряється
                    username = txtUsername.Text,
                    password = txtPassword.Text,
                    email = "", // для входу потрібні тільки ім'я і пароль, тому відправляємо пустий рядок
                                // сам email не юзається фактично, але він потрібен в API-запиті, тому не видаляй
                };
                var newPostJson = JsonConvert.SerializeObject(signupPost);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result = сlient.PostAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;

                await DisplayAlert("Отакі-от справи", result, "Ok"); // оця фігня тільки для дебагу треба
                //якась умова для успішного входу
            }
            Navigation.PushModalAsync(new AnalPage());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new RegisterPage());
        }
    }
}
