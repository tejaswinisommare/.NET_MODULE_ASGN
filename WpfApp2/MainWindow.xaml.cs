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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstListitems.Items.Add("sakshi");
            lstListitems.Items.Add("pooja");
            lstListitems.Items.Add("Teju");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(lstListitems.Items.Count.ToString());
            MessageBox.Show(lstListitems.SelectedItem.ToString());
            MessageBox.Show(lstListitems.SelectedIndex.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           // lstListitems.Items.Remove(lstListitems.SelectedItem);
            lstListitems.Items.RemoveAt(lstListitems.SelectedIndex);
        }
    }
}
