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
    /// Interaction logic for Sides_Wind_Menu.xaml
    /// </summary>
    public partial class Sides_Wind_Menu : Window
    {
        public List<Sides_menu> mySides_Menu { get; set; }
        private static string sidesReceipt;

        public Sides_Wind_Menu()
        {
            
            InitializeComponent();

            mySides_Menu = new List<Sides_menu>();

            Sides_menu side1 = new Sides_menu();
            side1.Item = "French fries";
            side1.Price = (int)1.89;
            side1.SideImage = " ";

            Sides_menu side2 = new Sides_menu();
            side2.Item = "Mac n Cheese";
            side2.Price = (int)1.89;
            side2.SideImage = " ";

            

            mySides_Menu.Add(side1);
            mySides_Menu.Add(side2);

            DataContext = this;
        }

        private void lstvBreakfast_menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItems = lstvSide_menu.SelectedItems;
            for (int i = 0; i < selectedItems.Count; i++)
            {
                lstSide_Receipt.Items.Add(selectedItems[i]);
            }
        }

        private void btnRemove_Item_Click(object sender, RoutedEventArgs e)
        {
            lstSide_Receipt.Items.Remove(lstSide_Receipt.SelectedItems[0]);
        }

        private void btnClose_side_Click(object sender, RoutedEventArgs e)
        {
            sidesReceipt = lstSide_Receipt.Items.ToString();
            this.Close();
        }

        private void btnCalcSideWin1_Click(object sender, RoutedEventArgs e)
        {
            double total = mySides_Menu.Sum(item => item.Price);
            MessageBox.Show("Your total is $" + total);
        }
    }
}
