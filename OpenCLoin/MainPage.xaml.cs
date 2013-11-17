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

//using System.Net.WebResponse;
//using System.Net.HttpWebResponse;
using System.IO;

//JSON parse
//using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;



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

        string key;
        private async void Login_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/Sell.xaml", UriKind.Relative));
            var client = new HttpClient();
            //Textbox for user creds
            key = await client.GetStringAsync("http://lokil.egr.duke.edu:1423");
            MessageBox.Show("Successful Login");
        }


        private void Balance_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Balance: " + GetAnything("amount", "account/balance"));
            MessageBox.Show("Currency: " + GetAnything("currency", "account/balance"));
        }


        private void Account_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Address: " + GetBitcoinAddress());
            MessageBox.Show("Receive Address: "+ GetReceiveAddress());
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
            var client = new HttpClient();
            string returnString = await client.GetStringAsync("https://coinbase.com/api/v1/account/receive_address?api_key="+key);

            JObject o = JObject.Parse(returnString);
            string amount = o["address"].ToString();
            return amount;
        }

        public async Task<string> GetAnything(string jsonString, string place)
        {
            var client = new HttpClient();
            string returnString = await client.GetStringAsync("https://coinbase.com/api/v1/" + place + "?api_key=" + key);

            JObject o = JObject.Parse(returnString);
            string amount = o[jsonString].ToString();
            return amount;
        }

        //Get coin address
        //public async Task<string> GetBitcoinAddress()
        //{
          //  var client = new HttpClient();
            //string returnString = await client.GetStringAsync("https://coinbase.com/api/v1/account/addresses?api_key="+key);
            //JObject o = JObject.Parse(returnString);
            //string amount = o["address"].ToString();
            //return "asd";
        //}
        



    }
}