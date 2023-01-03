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
    /// Interaction logic for Soups_and_Sides_Window6.xaml
    /// </summary>
    public partial class Soups_and_Sides_Window6 : Window
    {
        public Soups_and_Sides_Window6()
        {
            InitializeComponent();
        }

        private void imgsidesmenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Sides_Wind_Menu win8 = new Sides_Wind_Menu();
            this.Visibility = Visibility.Hidden;
            win8.ShowDialog();
            this.Visibility = Visibility.Hidden;//visible
        }

        private void imgSoups_menu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Soups_menu win9 = new Soups_menu();
            this.Visibility = Visibility.Hidden;
            win9.ShowDialog();
            this.Visibility = Visibility.Hidden;
        }

        private void btnClose_Soups_and_Side_Wind_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
