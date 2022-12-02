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
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute("SettingsPage", typeof(SettingsPage));
            Routing.RegisterRoute(nameof(AddTranPage), typeof(AddTranPage));
        }

    }
}
