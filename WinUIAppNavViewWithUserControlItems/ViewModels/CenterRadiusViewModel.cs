using System.ComponentModel;
using System.Diagnostics;
using Serilog;

namespace WinUIAppNavViewWithUserControlItems.ViewModels
{
    public partial class CenterRadiusViewModel : INotifyPropertyChanged 
    {
        // Center Group: Integers 0-60
        private double _degrees;
        public double Degrees
        {
            get
            {
                string msg = $"Property CenterX with value {_degrees} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                return _degrees;
            }
            set
            {
                string msg = $"Property CenterX with value {_degrees} changed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _degrees = value;
                OnPropertyChanged(nameof(Degrees));
            }
        }

        private double _minutes;
        public double Minutes
        {
            get
            {
                string msg = $"Property Minutes with value {_minutes} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                return _minutes;
            }
            set
            {
                string msg = $"Property Minutes with value {_minutes} changed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _minutes = value;
                OnPropertyChanged(nameof(Minutes));
            }
        }

        private double _seconds;
        public double Seconds
        {
            get
            {
                string msg = $"Property Seconds with value {_seconds} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                return _seconds;
            }
            set
            {
                string msg = $"Property Seconds with value {_seconds} changed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _seconds = value;
                OnPropertyChanged(nameof(Seconds));
            }
        }

        // Radius Group: Positive Integer > 0 (Default to 1)
        private double _radius = 1;
        public double Radius
        {
            get
            {
                string msg = $"Property Radius with value {_radius} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                return _radius;
            }
            set
            {
                string msg = $"Property Radius with value {_radius} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _radius = value;
                OnPropertyChanged(nameof(Radius));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName) =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}