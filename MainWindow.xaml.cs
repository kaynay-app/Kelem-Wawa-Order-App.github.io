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

namespace WAWA_ORDER
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /* Name: Kelem Nyarko
     * Project: WPF .NET C#
     * App Name: WAWA ORDER TOUCHSCREEN
     * */

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void imgBreakfast_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Breakfast_Window1 win2 = new Breakfast_Window1();
            this.Visibility = Visibility.Hidden;
            win2.ShowDialog();
            this.Visibility = Visibility.Visible;
        }

        private void imgLunch_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Lunches_and_Dinner_Window2 win3 = new Lunches_and_Dinner_Window2();
            this.Visibility = Visibility.Hidden;
            win3.ShowDialog();
            this.Visibility = Visibility.Visible;
        }

        private void imgHot_Drinks_MouseDown(object sender, MouseButtonEventArgs e)
        {
            /*Hotdrinks_Window4 win4 = new Hotdrinks_Window4();
            this.Visibility = Visibility.Hidden;
            win4.ShowDialog();
            this.Visibility = Visibility.Visible;*/

            
            Hot_and_Cold_subwin win4 = new Hot_and_Cold_subwin();
            this.Visibility = Visibility.Hidden;
            win4.ShowDialog();
            this.Visibility = Visibility.Visible;

        }

        private void imgbeverages_MouseDown(object sender, MouseButtonEventArgs e)
        {
            /*Beverages_Window5 win5 = new Beverages_Window5();
            this.Visibility = Visibility.Hidden;
            win5.ShowDialog();
            this.Visibility = Visibility.Visible;*/
        }

        private void imgSoups_and_sides_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Soups_and_Sides_Window6 win6 = new Soups_and_Sides_Window6();
            this.Visibility = Visibility.Hidden;
            win6.ShowDialog();
            this.Visibility = Visibility.Visible;
        }

        private void btnExit_App_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
