using Health.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Health.Views
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