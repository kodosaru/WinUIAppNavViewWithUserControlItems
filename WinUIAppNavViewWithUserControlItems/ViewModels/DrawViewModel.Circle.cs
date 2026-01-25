using System.ComponentModel;
using System.Diagnostics;
using Serilog;

namespace WinUIAppNavViewWithUserControlItems.ViewModels
{
    public partial class DrawViewModel : INotifyPropertyChanged 
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
    }
}