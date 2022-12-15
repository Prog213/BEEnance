using BEEnance.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BEEnance.ViewModels
{
    public class AnalViewModel : BaseViewModel
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public Command Settings { get; }
        public AnalViewModel()
        {
            Settings = new Command(GoSettings);
        }
        private async void GoSettings(object obj)
        {
            await Shell.Current.GoToAsync(nameof(SettingsPage));
        }
    }
}