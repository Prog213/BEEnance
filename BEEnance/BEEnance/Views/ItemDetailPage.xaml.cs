using BEEnance.Models;
using BEEnance.ViewModels;
using System;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;

namespace BEEnance.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.BeenanceDB.GetExpenses();
        }
        //private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (e.CurrentSelection != null)
        //    {
        //        // сюди треба якусь перевірку на інкам/експенс
        //        Expenses expenses = (Expenses)e.CurrentSelection.FirstOrDefault();
        //        await Shell.Current.GoToAsync(
        //            $"{nameof(TransactionInfoPage)}?{nameof(TransactioAddingPage.ItemId)}={Expenses.Id.ToString()}");
        //    }
        //}
    }
}