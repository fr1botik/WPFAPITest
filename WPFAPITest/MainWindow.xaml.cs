using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WFPAPITest.Models;

namespace WPFAPITest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static HttpClient client = new HttpClient();
        List<Sales> sale = new List<Sales>();
        public MainWindow()
        {
            InitializeComponent();
            GetAllUsers("https://localhost:44358/api/Users");
            GetAllSales("https://localhost:44358/api/Sales");
        }

        public async Task<Users> GetAllUsers(string path)
        {
            Users users = null;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {

                var data = await response.Content.ReadAsAsync<List<Users>>();
                list.ItemsSource = data;
                
            }
            return users;
        }
        public async Task<Sales> GetAllSales(string path)
        {
            Sales sales = null;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<List<Sales>>();
                Sale.ItemsSource = data;
                

            }
            return sales;

        }
        public async Task<Users> GetUsersSales(string path)
        {
            Users users = null;

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsAsync<List<Users>>();
                list.ItemsSource= data;


            }
            return users;
        }
       

        private void Sale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            switch (Sale.SelectedIndex)
            {
                case 0:
                    GetUsersSales("https://localhost:44358/api/Users?sales=" + (Sale.SelectedIndex + 1));
                    break;
                case 1:
                    GetUsersSales("https://localhost:44358/api/Users?sales=" + (Sale.SelectedIndex + 1));
                    break;
                case 2:
                    GetUsersSales("https://localhost:44358/api/Users?sales=" + (Sale.SelectedIndex + 1));
                    break;
                case 3:
                    GetUsersSales("https://localhost:44358/api/Users?sales=" + (Sale.SelectedIndex + 1));
                    break;
                case 4:
                    GetUsersSales("https://localhost:44358/api/Users?sales=" + (Sale.SelectedIndex + 1));
                    break;
                case 5:
                    GetUsersSales("https://localhost:44358/api/Users?sales=" + (Sale.SelectedIndex + 1));
                    break;
                case 6:
                    GetUsersSales("https://localhost:44358/api/Users?sales=" + (Sale.SelectedIndex + 1));
                    break;
                case 7:
                    GetUsersSales("https://localhost:44358/api/Users?sales=" + (Sale.SelectedIndex + 1));
                    break;
                case 8:
                    GetUsersSales("https://localhost:44358/api/Users?sales=" + (Sale.SelectedIndex + 1));
                    break;
                case 9:
                    GetUsersSales("https://localhost:44358/api/Users?sales=" + (Sale.SelectedIndex + 1));
                    break;

            }
        }
    }
}
