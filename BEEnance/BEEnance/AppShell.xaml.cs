using BEEnance.ViewModels;
using BEEnance.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BEEnance
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("SettingsPage", typeof(SettingsPage));
            Routing.RegisterRoute(nameof(MonoPage), typeof(MonoPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(APIPage), typeof(APIPage));
            Routing.RegisterRoute(nameof(AddExpPage), typeof(AddExpPage));
            Routing.RegisterRoute(nameof(AddIncomePage), typeof(AddIncomePage));
            Routing.RegisterRoute(nameof(AnalPage), typeof(AnalPage));
        }
    }
}
