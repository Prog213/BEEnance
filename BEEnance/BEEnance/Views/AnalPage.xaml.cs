using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microcharts;
using SkiaSharp;
using Entry = Microcharts.ChartEntry;
using System.Collections.Generic;
using BEEnance.ViewModels;
using BEEnance.Helpers;
using System.Xml;

namespace BEEnance.Views
{
    public partial class AnalPage : ContentPage
    {
        List<Entry> _entries = new List<Entry>()
        {
            new Entry(51)
            {
                Label = "Продукти", ValueLabel = "51%", Color = SKColor.Parse("#77d065"), ValueLabelColor = SKColor.Parse("#77d065")
            },
            new Entry(34)
            {
                Label = "Транспорт", ValueLabel = "34%", Color = SKColor.Parse("#c4c4c4"), ValueLabelColor = SKColor.Parse("#c4c4c4")
            },
            new Entry(10)
            {
                Label = "Мода і краса", ValueLabel = "10%", Color = SKColor.Parse("#b455b6"), ValueLabelColor = SKColor.Parse("#b455b6")
            },
            new Entry(5)
            {
                Label = "Ресторани та кафе", ValueLabel = "5%", Color = SKColor.Parse("#3498db"), ValueLabelColor = SKColor.Parse("#3498db")
            },
        };
        public AnalPage()
        {
            InitializeComponent();
            this.BindingContext = new AnalViewModel();

            ChartV.Chart = new DonutChart()
            {
                MinValue = 0,
                MaxValue = 100,
                LabelTextSize = 30,
                LabelMode = LabelMode.RightOnly,
                Margin = 30,
                HoleRadius = 0.5f,
                Entries = _entries,

            };
        }
    }
}