using BEEnance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BEEnance.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(false);
            await Task.Delay(100);
            await Navigation.PushAsync(new MonoPage(), false);
        }
        private async void LogOutClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
        public ProfilePage()
        {
            InitializeComponent();
            this.BindingContext = new AnalViewModel();
        }
    }
}