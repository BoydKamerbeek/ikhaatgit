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

namespace opdracht3._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnDraw.Click += BtnDraw_Click;
        }

        private void BtnDraw_Click(object sender, RoutedEventArgs e)
        {
            Line lineTop = new Line();
            lineTop.X1 = 200; lineTop.Y1 = 100;
            lineTop.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(lineTop);

            Line lineBottom = new Line();
            lineBottom.X1 = 200; lineBottom.Y1 = 100;
            lineBottom.X2 = 0; lineBottom.Y2 = 100;
            lineBottom.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(lineBottom);

            Line lineLeft = new Line();
            lineLeft.X1 = 0; lineLeft.Y1 = 100;
            lineLeft.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(lineLeft);
        }
    }
}
