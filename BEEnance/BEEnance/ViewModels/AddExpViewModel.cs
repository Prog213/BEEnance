using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using BEEnance.Models;
using BEEnance.Services;
using System.Runtime.CompilerServices;
using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.DataControls.ListView;

namespace BEEnance.ViewModels
{
    public class AddExpViewModel : BaseViewModel
    {
        public class Category
        {
            public Category(string _category)
            {
                this._category = _category;
            }
            public string _category { get; }
        }
        public List<Category> categories { get; set; }
        public AddExpViewModel()
        {
            this.categories = new List<Category>()
        {
            new Category("Мода і краса"),
            new Category("Їжа та напої"),
            new Category("Медицина"),
            new Category("Подарунки"),
            new Category("Спорт"),
            new Category("Транспорт"),
            new Category("Комунальні платежі"),
            new Category("Ресторани та кафе"),
            new Category("Побутові речі"),
            new Category("Дозвілля"),
            new Category("Інше"),
        };
        }
    }
}