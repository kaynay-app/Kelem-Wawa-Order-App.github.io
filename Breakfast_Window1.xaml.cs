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
    /// Interaction logic for Breakfast_Window1.xaml
    /// </summary>
    public partial class Breakfast_Window1 : Window
    {
        public List<Breakfast_menu> myBreakfast_Menu { get; set; }

        public Breakfast_Window1()
        {
            InitializeComponent();

            myBreakfast_Menu = new List<Breakfast_menu>();

            Breakfast_menu breakfast1 = new Breakfast_menu();
            breakfast1.Item = "Chicken Biscuit Sandwich";
            breakfast1.Price = (int)5.19;

            Breakfast_menu breakfast2 = new Breakfast_menu();
            breakfast2.Item = "Plain Bagel";
            breakfast2.Price = (int)1.05;

            Breakfast_menu breakfast3 = new Breakfast_menu();
            breakfast3.Item = "Corn Bread";
            breakfast3.Price = (int)0.99;

            Breakfast_menu breakfast4 = new Breakfast_menu();
            breakfast4.Item = "Maple Waffles";
            breakfast4.Price = (int)1.05;

            Breakfast_menu breakfast5 = new Breakfast_menu();
            breakfast5.Item = "Veggie & Cream Cheese Bagel";
            breakfast5.Price = (int)3.49;

            myBreakfast_Menu.Add(breakfast1);
            myBreakfast_Menu.Add(breakfast2);
            myBreakfast_Menu.Add(breakfast3);
            myBreakfast_Menu.Add(breakfast4);
            myBreakfast_Menu.Add(breakfast5);

            DataContext = this;
        }

        private void lstvBreakfast_menu_SelectionChanged(object sender, SelectionChangedEventArgs e) //transferring to listbox(receipt), set displaymemberpath to 'item' not 'object type'
        {
            var selectedItems = lstvBreakfast_menu.SelectedItems;
            for (int i = 0; i < selectedItems.Count; i++)
            {
                lstBreakfast_Receipt.Items.Add(selectedItems[i]);
            }
        }

        private void btnRemove_Item_Click(object sender, RoutedEventArgs e) //removing items 
        {
            lstBreakfast_Receipt.Items.Remove(lstBreakfast_Receipt.SelectedItems[0]);
        }

        private void btnClose_hoagies_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCalcbreakWin1_Click(object sender, RoutedEventArgs e)
        {
            double total = myBreakfast_Menu.Sum(item => item.Price);
            MessageBox.Show("Your total is $" + total);
        }
    }
}
