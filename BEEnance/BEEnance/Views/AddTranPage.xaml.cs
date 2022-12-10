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
    public partial class AddTranPage : ContentPage
    {
        public AddTranPage()
        {
            InitializeComponent();
        }
        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtValue.Text))
            {
                //double dValue = Convert.ToDouble(txtValue.Text);
                await App.BeenanceDB.SaveExpense(new Models.Expenses
                {
                    Amount = txtValue.Text,
                    Date = txtDate.Text,
                    Notes = txtNote.Text,
                    //Category = 
                });
                
                txtValue.Text = string.Empty; // чистимо всі рядки від старого тексту
                txtDate.Text = string.Empty;
                txtNote.Text = string.Empty;
            }
        }
    }
}