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

        List<Entry> entries = new List<Entry>()
        {
            new Entry(51)
            {
                Label = "Відсотки", ValueLabel = "41%", Color = SKColor.Parse("#7B68EE"), ValueLabelColor = SKColor.Parse("#7B68EE")
            },
            new Entry(34)
            {
                Label = "Зарплата", ValueLabel = "39%", Color = SKColor.Parse("#FF8C00"), ValueLabelColor = SKColor.Parse("#FF8C00")
            },
            new Entry(10)
            {
                Label = "Стипендія", ValueLabel = "12%", Color = SKColor.Parse("#66CDAA"), ValueLabelColor = SKColor.Parse("#66CDAA")
            },
            new Entry(5)
            {
                Label = "Подарунок", ValueLabel = "8%", Color = SKColor.Parse("#F08080"), ValueLabelColor = SKColor.Parse("#F08080")
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
                HoleRadius = 0.6f,
                Entries = _entries,
                BackgroundColor = SKColors.Transparent
            };

            ChartD.Chart = new DonutChart()
            {
                MinValue = 0,
                MaxValue = 100,
                LabelTextSize = 30,
                LabelMode = LabelMode.RightOnly,
                Margin = 30,
                HoleRadius = 0.6f,
                Entries = entries,
                BackgroundColor = SKColors.Transparent
            };
        }
    }
}