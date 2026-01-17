using Microsoft.UI.Xaml.Controls;
using WinUIAppNavViewWithUserControlItems.ViewModels;

namespace WinUIAppNavViewWithUserControlItems.Views
{
    public sealed partial class CornerOppositePage : Page
    {
        public CornerOppositeViewModel ViewModel { get; }

        public CornerOppositePage()
        {
            this.InitializeComponent();
            ViewModel = new CornerOppositeViewModel();
        }
    }
}