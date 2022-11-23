using BEEnance.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BEEnance.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}