using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Beverages_Window5.xaml
    /// </summary>
    public partial class Beverages_Window5 : Window
    {
        public List<Beverage_menu> myBeverage_Menu { get; set; }
        //public System.Collections.IEnumerable Price { get; private set; }

        public Beverages_Window5()
        {
            InitializeComponent();

            myBeverage_Menu = new List<Beverage_menu>();

            Beverage_menu beverage1 = new Beverage_menu();
            beverage1.Item = "Pepsi 20oz";
            beverage1.Price = (int)1.89;
            beverage1.Colddrink_image = " ";

            Beverage_menu beverage2 = new Beverage_menu();
            beverage2.Item = "Deer Park Water";
            beverage2.Price = (int)2.19;
            beverage2.Colddrink_image = " ";

            Beverage_menu beverage3 = new Beverage_menu();
            beverage3.Item = "Gatorade Glacial Freeze 28oz";
            beverage3.Price = (int)2.89;
            beverage2.Colddrink_image = " ";

            myBeverage_Menu.Add(beverage1);
            myBeverage_Menu.Add(beverage2);
            myBeverage_Menu.Add(beverage3);

            DataContext = this;

        }

        private void lstvBeverage_menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItems = lstvBeverage_menu.SelectedItems;
            for (int i = 0; i < selectedItems.Count; i++)
            {
                lstBeverage_Receipt.Items.Add(selectedItems[i]);
            }
        }

        private void btnRemoveBeverage_Item_Click(object sender, RoutedEventArgs e)
        {

            lstBeverage_Receipt.Items.Remove(lstBeverage_Receipt.SelectedItems[0]);
        }

        private void btnClose_cold_bev_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

            MainWindow win0 = new MainWindow();
            this.Visibility = Visibility.Hidden;
            win0.ShowDialog();
            this.Visibility = Visibility.Hidden; //visible
        }

        private void btnCalcbreakWin1_Click(object sender, RoutedEventArgs e)
        {
            double total = myBeverage_Menu.Sum(item => item.Price);
            MessageBox.Show("Your total is $" + total);

            //MessageBox.Show(lstvBeverage_menu.Items.Count.ToString());

        }
    }
}
