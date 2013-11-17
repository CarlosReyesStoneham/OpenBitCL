using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using OpenCLoin.Resources;

namespace OpenCLoin
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Sell_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Sell.xaml", UriKind.Relative));
            MessageBox.Show("Sell");
        }


        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Buy");
        }


        private void Account_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Account");
        }


        private void Pay_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Pay");
        }


        private void Analyze_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Analyze");
        }


        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Settings");
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}