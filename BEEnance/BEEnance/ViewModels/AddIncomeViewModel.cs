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
    public class AddIncomeViewModel : BaseViewModel
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
        public AddIncomeViewModel()
        {
            this.categories = new List<Category>()
        {
            new Category("Стипендія"),
            new Category("Зарплата"),
            new Category("Подарунок"),
            new Category("Відсотки"),
            new Category("Кишенькові"),
            new Category("Інше"),
        };
        }
    }
}