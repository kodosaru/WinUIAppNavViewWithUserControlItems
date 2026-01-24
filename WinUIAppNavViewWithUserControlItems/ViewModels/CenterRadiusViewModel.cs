using System.ComponentModel;
using System.Diagnostics;
using Serilog;

namespace WinUIAppNavViewWithUserControlItems.ViewModels
{
    public partial class CenterRadiusViewModel : INotifyPropertyChanged 
    {
        private double _cdegrees;
        public double Degrees
        {
            get
            {
                string msg = $"Property CenterX with value {_cdegrees} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                return _cdegrees;
            }
            set
            {
                string msg = $"Property CenterX with value {_cdegrees} changed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _cdegrees = value;
                OnPropertyChanged(nameof(Degrees));
            }
        }

        private double _cminutes;
        public double Minutes
        {
            get
            {
                string msg = $"Property Minutes with value {_cminutes} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                return _cminutes;
            }
            set
            {
                string msg = $"Property Minutes with value {_cminutes} changed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _cminutes = value;
                OnPropertyChanged(nameof(Minutes));
            }
        }

        private double _cseconds;
        public double Seconds
        {
            get
            {
                string msg = $"Property Seconds with value {_cseconds} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                return _cseconds;
            }
            set
            {
                string msg = $"Property Seconds with value {_cseconds} changed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _cseconds = value;
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


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName) =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}