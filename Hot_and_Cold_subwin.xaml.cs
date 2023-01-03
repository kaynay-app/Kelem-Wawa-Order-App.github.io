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
using System.Windows.Shapes;

namespace WAWA_ORDER
{
    /// <summary>
    /// Interaction logic for Hot_and_Cold_subwin.xaml
    /// </summary>
    public partial class Hot_and_Cold_subwin : Window
    {
        public Hot_and_Cold_subwin()
        {
            InitializeComponent();
        }

        private void imgcoldMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Beverages_Window5 win5 = new Beverages_Window5();
            this.Visibility = Visibility.Hidden;
            win5.ShowDialog();
            this.Visibility = Visibility.Hidden;
        }

        private void imgHotMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Hotdrinks_Window4 win4 = new Hotdrinks_Window4();
            this.Visibility = Visibility.Hidden;
            win4.ShowDialog();
            this.Visibility = Visibility.Hidden;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
