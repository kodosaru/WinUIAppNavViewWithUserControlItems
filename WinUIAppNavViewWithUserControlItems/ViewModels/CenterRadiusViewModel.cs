using CommunityToolkit.Mvvm.ComponentModel;

namespace WinUIAppNavViewWithUserControlItems.ViewModels
{
    public partial class CenterRadiusViewModel : ObservableObject
    {
        // Center Group: Integers 0-60
        [ObservableProperty] private int _centerX;
        [ObservableProperty] private int _centerY;
        [ObservableProperty] private int _centerZ;

        // Radius Group: Positive Integer > 0 (Default to 1)
        [ObservableProperty] private int _radius = 1;
    }
}