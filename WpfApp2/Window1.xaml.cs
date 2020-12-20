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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Add("Teju");
            lstNames.Items.Add("Pooja");
            lstNames.Items.Add("Yamini");
            lstNames.Items.Add("Poonam");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lstNames1.Items.Add(lstNames.SelectedItem.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach(var item in lstNames.SelectedItems)
            {
                lstNames1.Items.Add(item.ToString());
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Add(lstNames1.SelectedItem.ToString());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            foreach (var item in lstNames1.SelectedItems)
            {
                lstNames.Items.Add(item.ToString());
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            lstNames.Items.RemoveAt(lstNames.SelectedIndex);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            lstNames1.Items.RemoveAt(lstNames1.SelectedIndex);

        }
    }
}
