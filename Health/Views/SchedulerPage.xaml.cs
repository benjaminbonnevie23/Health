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
    public partial class SchedulerPage : ContentPage
    {
        public List<string> ScheduleOutput = new List<string>();

        public SchedulerPage()
        {
            InitializeComponent();
        }

        private void InputField_TextChanged(object sender, TextChangedEventArgs args)
        {
            Console.WriteLine(args.NewTextValue);
        }
        private void Add_Clicked(object sender, EventArgs e)
        {            
            string date = DatePicker.DateProperty.ToString();
            string time = TimePicker.TimeProperty.ToString();
            string Description = InputField.Text;
            string ListItem = Description + "\n" + "Date: "+ date + " | " + "Time: " + time;
            ScheduleOutput.Add(Description);
            Console.WriteLine(ListItem);
        }

    }
}