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

namespace SchoolBuss
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Holidays holidays = new Holidays();
            frm1.Content = holidays;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Cars cars = new Cars();
            frm1.Content=cars;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Drivers drivers = new Drivers();
            frm1.Content=drivers;
        }
    }
}
