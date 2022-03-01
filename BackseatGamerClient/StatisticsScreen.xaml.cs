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
    /// Interaction logic for StatisticsScreen.xaml
    /// </summary>
    public partial class StatisticsScreen : Page
    {
        public StatisticsScreen()
        {
            InitializeComponent();
            FillEmptyTable();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            HomeScreen homescreen = new HomeScreen();
            NavigationService.Navigate(homescreen);
        }

        private void FillEmptyTable()
        {
            for(int i = 0; i < 30; ++i)
            {
                FullStats_DataGrid.Items.Add(new RowDefinition());
            }
        }

        private void FillDataGrid(DataGrid data)
        {
            FullStats_DataGrid.ItemsSource = data.ItemsSource;
        }

        private void FillDataGrid(List<string> data)
        {
            FullStats_DataGrid.ItemsSource = data;
        }
    }
}
