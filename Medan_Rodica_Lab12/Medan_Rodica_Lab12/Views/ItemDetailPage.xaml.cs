using System.ComponentModel;
using Xamarin.Forms;
using Medan_Rodica_Lab12.ViewModels;

namespace Medan_Rodica_Lab12.Views
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