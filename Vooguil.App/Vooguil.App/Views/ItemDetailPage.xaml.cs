using System.ComponentModel;
using Vooguil.App.ViewModels;
using Xamarin.Forms;

namespace Vooguil.App.Views
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