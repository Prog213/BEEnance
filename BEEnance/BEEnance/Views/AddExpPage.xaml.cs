using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BEEnance.ViewModels;
using BEEnance.Models;

namespace BEEnance.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddExpPage : ContentPage
    {
        public AddExpPage()
        {
            InitializeComponent();
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtValue.Text))
            {
                //double dValue = Convert.ToDouble(txtValue.Text);
                await App.BeenanceDB.SaveTransaction(new Models.Transactions
                {
                    Amount = txtValue.Text,
                    Date = txtDate.Text,
                    Notes = txtNote.Text,
                    Category = Content.ToString(),
                    Type = "Витрата"
                });

                txtValue.Text = string.Empty; // чистимо всі рядки від старого тексту
                txtDate.Text = string.Empty;
                txtNote.Text = string.Empty;
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddIncomePage());
        }
    }

}