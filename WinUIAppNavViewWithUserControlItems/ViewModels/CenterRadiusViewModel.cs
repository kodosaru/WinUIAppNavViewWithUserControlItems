using System.ComponentModel;
using System.Diagnostics;
using Serilog;

namespace WinUIAppNavViewWithUserControlItems.ViewModels
{
    public partial class CenterRadiusViewModel : INotifyPropertyChanged 
    {
        // Center Group: Integers 0-60
        private double _centerX;
        public double CenterX
        {
            get
            {
                string msg = $"Property CenterX with value {_centerX} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                return _centerX;
            }
            set
            {
                string msg = $"Property CenterX with value {_centerX} changed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _centerX = value;
                OnPropertyChanged(nameof(CenterX));
            }
        }

        private double _centerY;
        public double CenterY
        {
            get
            {
                string msg = $"Property CenterY with value {_centerY} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                return _centerY;
            }
            set
            {
                string msg = $"Property CenterY with value {_centerY} changed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _centerY = value;
                OnPropertyChanged(nameof(CenterY));
            }
        }

        private double _centerZ;
        public double CenterZ
        {
            get
            {
                string msg = $"Property CenterZ with value {_centerZ} accessed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                return _centerZ;
            }
            set
            {
                string msg = $"Property CenterZ with value {_centerZ} changed";
                Log.Information(msg);
                Debug.WriteLine(msg);
                _centerZ = value;
                OnPropertyChanged(nameof(CenterZ));
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