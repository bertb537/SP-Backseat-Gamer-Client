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
    /// Interaction logic for TrackingScreenInProgress.xaml
    /// </summary>
    public partial class TrackingScreenInProgress : Page
    {
        public TrackingScreenInProgress()
        {
            InitializeComponent();
        }

        private void StopTracking_Click(object sender, RoutedEventArgs e)
        {
            HomeScreen homescreen = new HomeScreen();
            NavigationService.Navigate(homescreen);
        }
    }
}
