using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Health.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstViewPage : ContentPage
    {
        public FirstViewPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
    }
}
