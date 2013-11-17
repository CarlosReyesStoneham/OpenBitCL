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

using System.Net.WebResponse;
using System.Net.HttpWebResponse;
using System.IO;

//JSON parse
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;



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


        //Gets Receive Address
        public async Task<string> GetReceiveAddress()
        {
            WebClient c = new WebClient();
            string jsonBalance = HttpGet2("https://coinbase.com/api/v1/account/receive_address?api_key=YOUR_API_KEY");
            JObject o = JObject.Parse(jsonBalance);
            string amount = o["address"];
            return "asd";
        }

        //Get coin address
        public async Task<string> GetBitcoinAddress()
        {
            WebClient c = new WebClient();
            string jsonBalance = HttpGet2("https://coinbase.com/api/v1/addresses?api_key=YOUR_API_KEY");
            JObject o = JObject.Parse(jsonBalance);
            string amount = o["address"];
            return "asd";
        }

        string urlText;

        public async void HttpGet2(string url)
        {
            var client = new HttpClient();
            var data = await client.GetStringAsync(url);
            urlText = data;
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
