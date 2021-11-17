using System;
using System.Collections.Generic;
using System.ComponentModel;
using Vooguil.App.Models;
using Vooguil.App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vooguil.App.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}