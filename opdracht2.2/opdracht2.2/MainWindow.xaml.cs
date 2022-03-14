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

namespace opdracht2._2
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

        private void label_invisible(object sender, RoutedEventArgs e)
        {
            label.Visibility = Visibility.Collapsed;
        }
        private void label_visible(object sender, RoutedEventArgs e)
        {
            label.Visibility = Visibility.Visible;
        }
    }
}
