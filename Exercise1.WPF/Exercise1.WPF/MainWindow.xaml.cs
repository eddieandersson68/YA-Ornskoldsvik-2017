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

namespace Exercise1.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Point start;
        private Point end;

        public int StrokeThickness { get; private set; }


        private Shape _CurrShapeDrawn;
        public Point currentPoint = new Point();

        public MainWindow()
        {
            InitializeComponent();
          
        }


        private void MyCanvas_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine(start);
            start = e.GetPosition();
        }

        private void MyCanvas_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Debug.WriteLine(currentPoint);
                Line freehandline = new Line();
                end = e.GetPosition(this);
                freehandline.Stroke = Brushes.Blue;
                freehandline.StrokeThickness = 4;
                freehandline.X1 = start.X;
                freehandline.Y1 = start.Y;
                freehandline.X2 = e.GetPosition(MyCanvas).X;
                freehandline.Y2 = e.GetPosition(MyCanvas).Y;
                start = end;
              //  end = e.GetPosition(MyCanvas);
               // currentPoint = e.GetPosition(MyCanvas);
                _CurrShapeDrawn = freehandline;
                MyCanvas.Children.Add(_CurrShapeDrawn);
            }
        }

        //private void DrawLine()
        //{
        //    Line newLine = new Line()
        //    {
        //        Stroke = Brushes.Blue,
        //        StrokeThickness = 4,
        //        X1 = start.X,
        //        Y1 = start.Y,
        //        X2 = end.X,
        //        Y2 = end.Y
        //    };

        //    _CurrShapeDrawn = newLine;
        //}

    }
}
