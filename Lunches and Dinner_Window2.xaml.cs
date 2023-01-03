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
    /// Interaction logic for Lunches_and_Dinner_Window2.xaml
    /// </summary>
    public partial class Lunches_and_Dinner_Window2 : Window
    {
        public List<Lunches_and_Dinner_menu> myLunches_and_Dinner_Menu { get; set; }

        public Lunches_and_Dinner_Window2()
        {
            InitializeComponent();

            myLunches_and_Dinner_Menu = new List<Lunches_and_Dinner_menu>();


            Lunches_and_Dinner_menu lunch1 = new Lunches_and_Dinner_menu();
            lunch1.Item = "Roasted Chicken";
            lunch1.Price = "$6.59";
            lunch1.Hoagie_image = "";

            Lunches_and_Dinner_menu lunch2 = new Lunches_and_Dinner_menu();
            lunch2.Item = "Buffalo";
            lunch2.Price = "$5.99";
            lunch2.Hoagie_image = "";

            Lunches_and_Dinner_menu lunch3 = new Lunches_and_Dinner_menu();
            lunch3.Item = "Southern Honey hot";
            lunch3.Price = "$6.99";
            lunch3.Hoagie_image = "";

            myLunches_and_Dinner_Menu.Add(lunch1);
            myLunches_and_Dinner_Menu.Add(lunch2);
            myLunches_and_Dinner_Menu.Add(lunch3);

            DataContext = this;

        }

        

        private void lstvLunches_and_Dinner_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItems = lstvLunches_and_Dinner.SelectedItems;
            for (int i = 0; i < selectedItems.Count; i++)
            {
                lstLunches_and_Dinner_Receipt.Items.Add(selectedItems[i]);
            }
        }

        private void btnRemove_lunch_Click(object sender, RoutedEventArgs e)
        {
            lstLunches_and_Dinner_Receipt.Items.Remove(lstLunches_and_Dinner_Receipt.SelectedItems[0]);
        }

        private void btnClose_lunch_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}