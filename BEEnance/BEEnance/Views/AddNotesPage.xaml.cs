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
    public partial class AddNotesPage : ContentPage
    {
        public AddNotesPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotesPage());
        }
        private async void Save_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNote.Text))
            {
                //double dValue = Convert.ToDouble(txtValue.Text);
                await App.BeenanceDB.SaveNote(new Models.Notes
                {
                    Date = txtDate.Text,
                    Note = txtNote.Text,
                });

                // чистимо всі рядки від старого тексту
                txtDate.Text = string.Empty;
                txtNote.Text = string.Empty;
            }
        }
    }
}