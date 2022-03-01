using System;
using System.Collections.Generic;
using System.Linq;
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

namespace BackseatGamerClient
{
    /// <summary>
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    public partial class HomeScreen : Page
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void StatisticsScreenNav_Button_Click(object sender, RoutedEventArgs e)
        {
            StatisticsScreen statisticsScreen = new StatisticsScreen();
            NavigationService.Navigate(statisticsScreen);
        }

        private void TrackingScreenNav_Button_Click(object sender, RoutedEventArgs e)
        {
            TrackingScreenInProgress trackingScreen = new TrackingScreenInProgress();
            NavigationService.Navigate(trackingScreen);
        }
    }
}