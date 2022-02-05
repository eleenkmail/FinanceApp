using FinanceApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FinanceApp.Views
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