using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Exersice3.WPF
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

        public void Rect_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var clickedElement = e.OriginalSource;
            MessageBox.Show("Rectangel Clicked");
        }


        public void Circle_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var clickedElement = e.OriginalSource;
            MessageBox.Show("Circle Clicked");
        }
       
        public void BtnCircle_OnClick(object sender, RoutedEventArgs e)
        {
            var myCircle = new Ellipse()
            {
                Stroke = Brushes.Black,
                Fill = Brushes.Red,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                
                Height = 50,
                Width = 50
            };
            myCircle.MouseDown += Circle_PreviewMouseDown;
            Canvas.SetTop(myCircle,50 );
            Canvas.SetLeft(myCircle,155 );
            MyCanvas.Children.Add(myCircle);
        }

        public void BtnRect_OnClick(object sender, RoutedEventArgs e)
        {
            var myRectangle = new Rectangle
            {
                Stroke = Brushes.Black,
                Fill = Brushes.SkyBlue,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Center,
                Height = 50,
                Width = 70
            };

            myRectangle.MouseDown += Rect_PreviewMouseDown;
            Canvas.SetTop(myRectangle,50 );
            Canvas.SetLeft(myRectangle,50 );
            MyCanvas.Children.Add(myRectangle);


        }

        public void BtnClear_OnClick(object sender, RoutedEventArgs e)
        {
            MyCanvas.Children.Clear();
        }

    }
}
