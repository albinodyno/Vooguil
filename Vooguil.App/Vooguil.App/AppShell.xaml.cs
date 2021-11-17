using System;
using System.Collections.Generic;
using Vooguil.App.ViewModels;
using Vooguil.App.Views;
using Xamarin.Forms;

namespace Vooguil.App
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
