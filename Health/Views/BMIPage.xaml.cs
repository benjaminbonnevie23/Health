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
    public partial class BMIPage : ContentPage
    {
        public BMIPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string HeightTxt = HeightIn.Text;
            string WeightTxt = WeightIn.Text;

            double HeightNum = Int32.Parse(HeightTxt);
            double WeightNum = Int32.Parse(WeightTxt);

            Double BMI = Math.Round(((WeightNum/HeightNum)/HeightNum)*10000,2) ;

            BMIOut.Text = BMI.ToString();
        }

        private void HeightIn_TextChanged(object sender, TextChangedEventArgs e)
        {
            BMIOut.Text = "Your BMI will be displayed here";
        }

        private void WeightIn_TextChanged(object sender, TextChangedEventArgs e)
        {
            BMIOut.Text = "Your BMI will be displayed here";
        }
    }
}