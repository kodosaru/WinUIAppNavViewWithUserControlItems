using CommunityToolkit.Mvvm.ComponentModel;

namespace WinUIAppNavViewWithUserControlItems.ViewModels
{
    public partial class CornerOppositeViewModel : ObservableObject
    {
        // Corner Group: Integers 0-60
        [ObservableProperty] private int _cornerX;
        [ObservableProperty] private int _cornerY;
        [ObservableProperty] private int _cornerZ;

        // Opposite Group: Integers 0-60
        [ObservableProperty] private int _oppositeX;
        [ObservableProperty] private int _oppositeY;
        [ObservableProperty] private int _oppositeZ;
    }
}