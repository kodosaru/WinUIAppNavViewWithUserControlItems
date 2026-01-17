using Microsoft.UI.Xaml.Controls;
using WinUIAppNavViewWithUserControlItems.ViewModels;

namespace WinUIAppNavViewWithUserControlItems.Views
{
    public sealed partial class CenterRadiusPage : Page
    {
        public CenterRadiusViewModel ViewModel { get; }

        public CenterRadiusPage()
        {
            this.InitializeComponent();
            ViewModel = new CenterRadiusViewModel();
        }
    }
}