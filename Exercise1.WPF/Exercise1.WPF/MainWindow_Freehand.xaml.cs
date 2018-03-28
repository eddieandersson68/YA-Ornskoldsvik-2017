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
        private Point _currentPoint;
        private Point _endPoint;

        public int StrokeThickness { get; private set; }
        private bool _freehandDraw = false;
        private bool _lineDraw = false;
        private Shape _CurrShapeDrawn;
        private double MyCanvasGetPosX;
        private double MyCanvasGetPosY;
        private Point MyCanvasThis;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void MyCanvas_OnMouseMove(object sender, MouseEventArgs e)
        {
            //MyCanvasGetPosY = e.GetPosition(MyCanvas).X;
            //MyCanvasGetPosY = e.GetPosition(MyCanvas).Y;
            _endPoint = e.GetPosition(MyCanvas);

            if (e.LeftButton == MouseButtonState.Pressed && _freehandDraw)
            {
                Freehand();
            }

            if (e.LeftButton == MouseButtonState.Pressed && _lineDraw)
            {
                if (_CurrShapeDrawn == null)
                {
                    var _newline = new Line();
                    MyCanvas.Children.Add(_newline);
                    _CurrShapeDrawn = _newline;
                }


                var newline = _CurrShapeDrawn as Line;

                DrawLine(newline, _currentPoint, _endPoint);

            }
        }

        public void Freehand()
        {
            Line _freehandline = new Line();
            _freehandline.Stroke = Brushes.Blue;
            _freehandline.StrokeThickness = 4;
            _freehandline.X1 = _currentPoint.X;
            _freehandline.Y1 = _currentPoint.Y;
            _freehandline.X2 = _endPoint.X;
            _freehandline.Y2 = _endPoint.Y;
            _currentPoint = _endPoint;

            MyCanvas.Children.Add(_freehandline);
        }


        private void DrawLine(Line newline, Point _currentPoint, Point _endPoint)
        {
            newline.Stroke = Brushes.Blue;
            newline.StrokeThickness = 4;
            newline.X1 = _currentPoint.X;
            newline.Y1 = _currentPoint.Y;
            newline.X2 = _endPoint.X;
            newline.Y2 = _endPoint.Y;
        }

        private void BtnDraw_OnClick(object sender, RoutedEventArgs e)
        {
            _freehandDraw = true;
            // BtnDraw.Background = Brushes.Aquamarine;

        }

        private void BtnLine_OnClick(object sender, RoutedEventArgs e)
        {
            _lineDraw = true;
            // BtnLine.Background = Brushes.Aquamarine;
        }

        private void MyCanvas_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _currentPoint = e.GetPosition(MyCanvas);
        }

        private void MyCanvas_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _CurrShapeDrawn = null;
        }
    }
}
