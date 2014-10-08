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

namespace DemoCanvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Ellipse circle = GetCircle(100);
            Ellipse circle2 = GetCircle(220);
        }

        private Ellipse GetCircle(double top)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 100;
            ellipse.Height = 100;
            ellipse.Fill = Brushes.Gold;

            MyCanvas.Children.Add(ellipse);
            Canvas.SetTop(ellipse, top);
            Canvas.SetLeft(ellipse, 200);
            return ellipse;
        }
    }
}
