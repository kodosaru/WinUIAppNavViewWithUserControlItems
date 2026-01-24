using System.ComponentModel;
using System.Diagnostics;
using Serilog;

namespace WinUIAppNavViewWithUserControlItems.ViewModels
{
    public partial class MainWindowViewModel : INotifyPropertyChanged 
    {
        // Center Group: Integers 0-60
        private double _cdegrees;
        public double Cdegrees
        {
            get
            {
                string msg = $"Property Cdegrees with value {_cdegrees} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                return _cdegrees;
            }
            set
            {
                string msg = $"Property Cdegrees with value {_cdegrees} changed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _cdegrees = value;
                OnPropertyChanged(nameof(Cdegrees));
            }
        }

        private double _cminutes;
        public double Cminutes
        {
            get
            {
                string msg = $"Property Cminutes with value {_cminutes} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                return _cminutes;
            }
            set
            {
                string msg = $"Property Cminutes with value {_cminutes} changed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _cminutes = value;
                OnPropertyChanged(nameof(Cminutes));
            }
        }

        private double _cseconds;
        public double Cseconds
        {
            get
            {
                string msg = $"Property Cseconds with value {_cseconds} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                return _cseconds;
            }
            set
            {
                string msg = $"Property Cseconds with value {_cseconds} changed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _cseconds = value;
                OnPropertyChanged(nameof(Cseconds));
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
                string msg = $"Property Radius with value {_radius} changed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _radius = value;
                OnPropertyChanged(nameof(Radius));
            }
        }

        double _degrees;
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

        double _minutes;
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

        double _oppositeDegrees;
        public double OppositeDegrees
        {
            get
            {
                string msg = $"Property OppositeDegrees with value {_oppositeDegrees} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                return _oppositeDegrees;
            }
            set
            {
                string msg = $"Property OppositeDegrees with value {_oppositeDegrees} changed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _oppositeDegrees = value;
                OnPropertyChanged(nameof(OppositeDegrees));
            }
        }

        private double _oppositeMinutes;
        public double OppositeMinutes
        {
            get
            {
                string msg = $"Property OppositeMinutes with value {_oppositeMinutes} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                return _oppositeMinutes;
            }
            set
            {
                string msg = $"Property OppositeMinutes with value {_oppositeMinutes} changed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _oppositeMinutes = value;
                OnPropertyChanged(nameof(OppositeMinutes));
            }
        }

        private double _oppositeSeconds;
        public double OppositeSeconds
        {
            get
            {
                string msg = $"Property OppositeSeconds with value {_oppositeSeconds} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                return _oppositeSeconds;
            }
            set
            {
                string msg = $"Property OppositeSeconds with value {_oppositeSeconds} changed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _oppositeSeconds = value;
                OnPropertyChanged(nameof(OppositeSeconds));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName) =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}