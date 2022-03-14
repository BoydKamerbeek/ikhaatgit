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

namespace Opdracht3._5
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
            Ellipse innerCircle = new Ellipse();
            innerCircle.Width = 200;
            innerCircle.Height = 200;
            innerCircle.Stroke = new SolidColorBrush(Colors.Black);
            innerCircle.Fill = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(innerCircle); 

            Ellipse innerCircle2 = new Ellipse();
            innerCircle2.Margin = new Thickness(25, 25, 0, 0);
            innerCircle2.Width = 150;
            innerCircle2.Height = 150;
            innerCircle2.Stroke = new SolidColorBrush(Colors.Black);
            innerCircle2.Fill = new SolidColorBrush(Colors.Red);
            paperCanvas.Children.Add(innerCircle2);

            Ellipse innerCircle3 = new Ellipse();
            innerCircle3.Margin = new Thickness(50, 50, 0, 0);
            innerCircle3.Width = 100;
            innerCircle3.Height = 100;
            innerCircle3.Stroke = new SolidColorBrush(Colors.Black);
            innerCircle3.Fill = new SolidColorBrush(Colors.Green);
            paperCanvas.Children.Add(innerCircle3);

            Ellipse innerCircle4 = new Ellipse();
            innerCircle4.Margin = new Thickness(75, 75, 0, 0);
            innerCircle4.Width = 50;
            innerCircle4.Height = 50;
            innerCircle4.Stroke = new SolidColorBrush(Colors.Black);
            innerCircle4.Fill = new SolidColorBrush(Colors.Red);
            paperCanvas.Children.Add(innerCircle4);
        }
    }
}
