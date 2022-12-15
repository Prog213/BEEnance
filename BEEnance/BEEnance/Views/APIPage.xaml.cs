using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BEEnance.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class APIPage : ContentPage
    {
        string APIToken;
        public APIPage()
        {
            InitializeComponent();
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            APIToken = API.Text;
            await DisplayAlert("Успіх!", "Ваш токен успішно добавлений", "Ок");
            await Task.Delay(100);
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}