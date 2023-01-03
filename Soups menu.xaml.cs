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
    /// Interaction logic for Soups_menu.xaml
    /// </summary>
    public partial class Soups_menu : Window
    {
        public List<Soup_menu> mySoups_Menu { get; set; }

        public Soups_menu()
        {
            InitializeComponent();

            mySoups_Menu = new List<Soup_menu>();

            Soup_menu soup1 = new Soup_menu();
            soup1.Item = "Chicken Noodle soup";
            soup1.Price = (int)4.19;

            Breakfast_menu breakfast2 = new Breakfast_menu();
            breakfast2.Item = "Tomato Basil Basique";
            breakfast2.Price = (int)7.05;
        }

        private void btnCalcbreakWin1_Click(object sender, RoutedEventArgs e)
        {
            double total = mySoups_Menu.Sum(item => item.Price);
            MessageBox.Show("Your total is $" + total);
        }

        private void btnClose_hoagies_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lstvSoup_menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItems = lstSoups_Receipt.SelectedItems;
            for (int i = 0; i < selectedItems.Count; i++)
            {
                lstSoups_Receipt.Items.Add(selectedItems[i]);
            }
        }
    }
}
