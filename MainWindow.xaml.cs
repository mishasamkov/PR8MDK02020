using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using Newtonsoft.Json;
using PR8_0202.Classes;

using PR8_0202.Models;

namespace PR8_0202
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataResponse response;
        public MainWindow()
        {
            InitializeComponent();
            Iint();
        }

        public async void Iint()
        {
            response = await GetWeather.Get(58.01168f, 56.286672f);

            foreach (Forecast forecast in response.forecasts)
            {
                Days.Items.Add(forecast.date.ToString("dd.MM.yyyy"));
            }
            Create(0);
        }
        public void Create(int idForecast)
        {
            parent.Children.Clear();
            foreach (Hour hour in response.forecasts[idForecast].hours)
            {
                parent.Children.Add(new Item(hour));
            }
        }


        private void SelectDay(object sender, SelectionChangedEventArgs e)
        {
            Create(Days.SelectedIndex);
        }


        private void UpdateWeather(object sender, RoutedEventArgs e)
        {
            Iint();

        }
    }
}