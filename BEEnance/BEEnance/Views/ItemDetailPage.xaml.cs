using BEEnance.Models;
using BEEnance.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace BEEnance.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            //BindingContext = new ItemDetailViewModel();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.BeenanceDB.GetExpenses();
        }
    }
}