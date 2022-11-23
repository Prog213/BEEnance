using BEEnance.Models;
using BEEnance.ViewModels;
using BEEnance.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BEEnance.Views
{
    public partial class ItemsPage : ContentPage
    {
        SettingsCode _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new SettingsCode();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}