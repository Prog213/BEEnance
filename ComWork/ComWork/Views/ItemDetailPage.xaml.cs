using ComWork.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ComWork.Views
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