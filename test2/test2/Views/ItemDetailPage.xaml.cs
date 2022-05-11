using System.ComponentModel;
using test2.ViewModels;
using Xamarin.Forms;

namespace test2.Views
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