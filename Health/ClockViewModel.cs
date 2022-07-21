using System;
using System.Collections.Generic;
using System.Text;

namespace Health
{
    class ClockViewModel:System.ComponentModel.INotifyPropertyChanged
    {
        DateTime _dt;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public ClockViewModel()
        {
            Xamarin.Forms.Device.StartTimer(TimeSpan.FromSeconds(1),
                () =>
                {
                    DT = DateTime.Now;
                    return true;
                }
                );
        }

        public DateTime DT
        {
            get { return _dt; }
            set
            {
                if (_dt!=value)
                {
                    _dt = value;
                    PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("DT"));
                }
            }
        }
    }
}
