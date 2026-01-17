using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using WinUIAppNavViewWithUserControlItems.Views;

namespace WinUIAppNavViewWithUserControlItems
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.Title = "WinUI 3 MVVM Example";
        }

        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            // Select the first item by default
            NavView.SelectedItem = NavView.MenuItems[0];
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                // Handle settings navigation if needed
            }
            else if (args.SelectedItem is NavigationViewItem selectedItem)
            {
                string pageTag = selectedItem.Tag.ToString();
                Type pageType = null;

                switch (pageTag)
                {
                    case "CenterRadiusPage":
                        pageType = typeof(CenterRadiusPage);
                        break;
                    case "CornerOppositePage":
                        pageType = typeof(CornerOppositePage);
                        break;
                }

                if (pageType != null)
                {
                    ContentFrame.Navigate(pageType);
                }
            }
        }
    }
}