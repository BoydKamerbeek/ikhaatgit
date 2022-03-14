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

namespace Demo
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

        private void button_1_click(object sender, RoutedEventArgs e)
        {
            label_a.Content = "JA";
            label_b.Content = "JA";
            label_c.Content = "JA";
        }
        private void button_2_click(object sender, RoutedEventArgs e)
        {
            label_a.Content = "NEE";
            label_b.Content = "NEE";
            label_c.Content = "NEE";
        }

        private void button_3_click(object sender, RoutedEventArgs e)
        {
            label_a.Content = "A";
            label_b.Content = "B";
            label_c.Content = "C";
        }
    }
}
