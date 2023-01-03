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
    /// Interaction logic for Hotdrinks_Window4.xaml
    /// </summary>
    public partial class Hotdrinks_Window4 : Window
    {
        public List<Hotdrinks_menu> myHotdrinks_Menu { get; set; }

        public Hotdrinks_Window4()
        {
            InitializeComponent();

            myHotdrinks_Menu = new List<Hotdrinks_menu>();

            Hotdrinks_menu hotdrink1 = new Hotdrinks_menu();
            hotdrink1.Item = "Regular Coffee";
            hotdrink1.Price = (int)1.59;


            Hotdrinks_menu hotdrink2 = new Hotdrinks_menu();
            hotdrink2.Item = "Decaf";
            hotdrink2.Price = (int)1.40;

            Hotdrinks_menu hotdrink3 = new Hotdrinks_menu();
            hotdrink3.Item = "Cuban Roast";
            hotdrink3.Price = (int)1.85;

           

            myHotdrinks_Menu.Add(hotdrink1);
            myHotdrinks_Menu.Add(hotdrink2);
            myHotdrinks_Menu.Add(hotdrink3);

            DataContext = this;

        }

        private void lstvHotdrinks_menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItems = lstvHotdrinks_menu.SelectedItems;
            for (int i = 0; i < selectedItems.Count; i++)
            {
                lstHotdrinks_receipt.Items.Add(selectedItems[i]);
            }
        }

        private void btnRemove_Hotdrinks_Click(object sender, RoutedEventArgs e)
        {
            lstHotdrinks_receipt.Items.Remove(lstHotdrinks_receipt.SelectedItems[0]);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

            MainWindow win0 = new MainWindow();
            this.Visibility = Visibility.Hidden;
            win0.ShowDialog();
            this.Visibility = Visibility.Hidden;
        }

        private void btnCalcbreakWin1_Click(object sender, RoutedEventArgs e)
        {
            
            double total = myHotdrinks_Menu.Sum(item => item.Price);
            MessageBox.Show("Your total is $" + total);


        }
    }
}
