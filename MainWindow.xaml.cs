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

namespace PR8_0202
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string ApiKey = "83cb011eeb954d7b7dbbe847f49e51cb";
        private const string ApiUrl = "https://api.openweathermap.org/data/2.5/forecast?q={0}&appid={1}&units=metric&lang=ru";
        private void SearchCity(object sender, MouseButtonEventArgs e)
        {
            Weather.Visibility = Visibility.Hidden;
            Search.Visibility = Visibility.Hidden;
            CityTextbox.Visibility = Visibility.Visible;
        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}