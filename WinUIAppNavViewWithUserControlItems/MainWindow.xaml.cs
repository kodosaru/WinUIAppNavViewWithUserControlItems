using Microsoft.UI.Input;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using System;
using System.Diagnostics;
using System.Linq;
using WinUIAppNavViewWithUserControlItems.ViewModels;
using WinUIAppNavViewWithUserControlItems.Views;

namespace WinUIAppNavViewWithUserControlItems
{
    public sealed partial class MainWindow : Window
    {
        public MainWindowViewModel MainWindowViewModel { get; }

        public MainWindow()
        {
            this.InitializeComponent();
            this.Title = "WinUI 3 MVVM Example";
            MainWindowViewModel = new MainWindowViewModel();
            NavView.DataContext = MainWindowViewModel;
        }

        private void OnDrawingItemClicked(object sender, PointerRoutedEventArgs e)
        {
            if (e.Pointer.PointerDeviceType == (PointerDeviceType)Windows.Devices.Input.PointerDeviceType.Mouse)
            {
                var clickedItem = sender as NavigationViewItem;
                if (clickedItem == DrawingItem && DrawingOffItem.IsSelected == false)
                {
                    Debug.WriteLine($"Mouse clicked on: {clickedItem.Content}");
                }
            }
        }

        private NavigationViewItem DrawingItem
        {
            get
            {
                NavigationViewItem? drawingItem = null;
                var items = NavView.MenuItems;
                if (items.Count > 0)
                {
                    drawingItem = items.OfType<NavigationViewItem>().FirstOrDefault(item => (string)item.Tag == "SearchByDrawing");
                }
                return drawingItem;
            }
        }

        private NavigationViewItem DrawingOffItem
        {
            get
            {
                NavigationViewItem? drawingOffItem = null;
                var items = NavView.MenuItems;
                if (items.Count > 0)
                {
                    drawingOffItem = DrawingItem.MenuItems
                            .OfType<NavigationViewItem>().FirstOrDefault(item => (string)item.Tag == "DrawingOff");
                }
                return drawingOffItem;
            }
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
                string? pageTag = selectedItem.Tag.ToString();
                Type? pageType = null;

                switch (pageTag)
                {
                    case "MainPage":
                        pageType = typeof(MainPage);
                        break;
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