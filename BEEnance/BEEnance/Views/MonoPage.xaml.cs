using System.Threading.Tasks;
using System;
using System.Windows.Input;
using Xamarin.CommunityToolkit.PlatformConfiguration.WindowsSpecific;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BEEnance.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class MonoPage : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public MonoPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Task.Delay(100);
            await Navigation.PushAsync(new APIPage(), false);
        }
    }
}