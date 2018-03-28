using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exersice4.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Point _startPoint;
        private Point _endPoint;
        private Line _line;
        private Ellipse _ellipse;
        private Rectangle _rectangle;
        private Point _drawPoint;


        public int StrokeThickness { get; private set; }
        private SolidColorBrush _changeFillColour;
        private SolidColorBrush _changeStrokekColour;
        private SolidColorBrush _mixedFillColor;
        private SolidColorBrush _mixedStrokeColour;

        private bool _ellipseButtonPressed = false;
        private bool _rectButtonPressed = false;
        private bool _lineButtonPressed = false;
        private bool _freehandPressed = false;
        private bool _mixedColourSwatch = false;
        private Shape _currentShapeToDraw;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void BtnEllipse_OnClick(object sender, RoutedEventArgs e)
        {
            BtnEllipse.Background = Brushes.CadetBlue;
            BtnRect.Background = Brushes.LightGray;
            BtnLine.Background = Brushes.LightGray;
            BtnClear.Background = Brushes.LightGray;
            BtnDraw.Background = Brushes.LightGray;
            BtnErase.Background = Brushes.LightGray;
            BtnSelect.Background = Brushes.LightGray;
            BtnClear.Background = Brushes.LightGray;

            if (RectRedFill.IsEnabled)
            {

            }
            _ellipseButtonPressed = true;
            _lineButtonPressed = false;
            _rectButtonPressed = false;
            _freehandPressed = false;


        }

        public void BtnRect_OnClick(object sender, RoutedEventArgs e)
        {
            BtnRect.Background = Brushes.CadetBlue;
            BtnEllipse.Background = Brushes.LightGray;
            BtnLine.Background = Brushes.LightGray;
            BtnClear.Background = Brushes.LightGray;
            BtnDraw.Background = Brushes.LightGray;
            BtnErase.Background = Brushes.LightGray;
            BtnSelect.Background = Brushes.LightGray;
            BtnClear.Background = Brushes.LightGray;

            _rectButtonPressed = true;
            _lineButtonPressed = false;
            _ellipseButtonPressed = false;
            _freehandPressed = false;

        }

        private void BtnLine_OnClick(object sender, RoutedEventArgs e)
        {
            BtnLine.Background = Brushes.CadetBlue;
            BtnEllipse.Background = Brushes.LightGray;
            BtnRect.Background = Brushes.LightGray;
            BtnClear.Background = Brushes.LightGray;
            BtnDraw.Background = Brushes.LightGray;
            BtnErase.Background = Brushes.LightGray;
            BtnSelect.Background = Brushes.LightGray;
            BtnClear.Background = Brushes.LightGray;

            _lineButtonPressed = true;
            _rectButtonPressed = false;
            _ellipseButtonPressed = false;
            _freehandPressed = false;
        }

        private void BtnDraw_OnClick(object sender, RoutedEventArgs e)
        {

            BtnDraw.Background = Brushes.CadetBlue;
            BtnEllipse.Background = Brushes.LightGray;
            BtnRect.Background = Brushes.LightGray;
            BtnLine.Background = Brushes.LightGray;
            BtnClear.Background = Brushes.LightGray;
            BtnErase.Background = Brushes.LightGray;
            BtnSelect.Background = Brushes.LightGray;
            BtnClear.Background = Brushes.LightGray;



            _freehandPressed = true;
            _ellipseButtonPressed = false;
            _rectButtonPressed = false;
            _lineButtonPressed = false;

            // StartDraw();
        }

        public void BtnClear_OnClick(object sender, RoutedEventArgs e)
        {
            MyCanvas.Children.Clear();
        }



        private void MyCanvas_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _startPoint = e.GetPosition(MyCanvas);
            Debug.WriteLine("START: " + _startPoint.X + ":" + _startPoint.Y);

            //Line _freehandline = new Line();
            //_freehandline.Stroke = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            //_freehandline.StrokeThickness = 4;
            //_freehandline.X1 = _startPoint.X;
            //_freehandline.Y1 = _startPoint.Y;
            //_freehandline.X2 = _startPoint.X * 1.01;
            //_freehandline.Y2 = _startPoint.Y * 1.01;
            //_currentShapeToDraw = _freehandline;
            //MyCanvas.Children.Add(_currentShapeToDraw);
            //_currentShapeToDraw = null;
        }

        private void MyCanvas_OnMouseMove(object sender, MouseEventArgs e)
        {
            _endPoint = e.GetPosition(MyCanvas);
            Debug.WriteLine("END: " + _endPoint.X + ":" + _endPoint.Y);

            if (e.LeftButton == MouseButtonState.Pressed && _freehandPressed)
                DrawFreehand();

            if (e.LeftButton == MouseButtonState.Pressed && _lineButtonPressed)
            {
                if (_currentShapeToDraw == null)
                {
                    var _newline = new Line();
                    _newline.Stroke = _changeStrokekColour;
                    _newline.StrokeThickness = 4;
                    _currentShapeToDraw = _newline;
                    MyCanvas.Children.Add(_currentShapeToDraw);
                }
                DrawLine(_currentShapeToDraw as Line);
            }

            if (e.LeftButton == MouseButtonState.Pressed && _ellipseButtonPressed)
            {
                if (_currentShapeToDraw == null)
                {
                    var _newEllipse = new Ellipse();
                    _newEllipse.Stroke = _changeStrokekColour;
                    _newEllipse.StrokeThickness = 4;
                    _newEllipse.Fill = _changeFillColour;
                    _currentShapeToDraw = _newEllipse;
                    MyCanvas.Children.Add(_currentShapeToDraw);
                }
                DrawEllipse(_currentShapeToDraw as Ellipse);

                //if (_currentShapeToDraw != null)
                //{
                //    _currentShapeToDraw = MyCanvas.Children.OfType<Ellipse>().LastOrDefault();
                //}

            }

            if (e.LeftButton == MouseButtonState.Pressed && _rectButtonPressed)
            {
                if (_currentShapeToDraw == null)
                {
                    var _newRectangle = new Rectangle();
                    _newRectangle.Stroke = _changeStrokekColour;
                    _newRectangle.StrokeThickness = 4;
                    _newRectangle.Fill = _changeFillColour;
                    _currentShapeToDraw = _newRectangle;
                    MyCanvas.Children.Add(_currentShapeToDraw);
                }

                DrawRectangle(_currentShapeToDraw as Rectangle);

                if (_currentShapeToDraw != null)
                {
                    _currentShapeToDraw = MyCanvas.Children.OfType<Rectangle>().LastOrDefault();
                }
            }
        }


        private void DrawEllipse(Ellipse _newEllipse)
        {

            if (_endPoint.X >= _startPoint.X)
            {

                _newEllipse.SetValue(Canvas.LeftProperty, _startPoint.X);
                _newEllipse.Width = _endPoint.X - _startPoint.X;

                string str = "";
                Debug.WriteLine("Curr" + _startPoint);
                Debug.WriteLine("End" + _endPoint);
                str = Convert.ToString(_newEllipse.Width);
                Debug.WriteLine("Ellipse Width End - Curr" + str);
            }
            else
            {
                _newEllipse.SetValue(Canvas.LeftProperty, _endPoint.X);
                _newEllipse.Width = _startPoint.X - _endPoint.X;

                string str2 = "";
                str2 = Convert.ToString(_newEllipse.Width);
                Debug.WriteLine("Ellipse Width Curr - End" + str2);
            }

            if (_endPoint.Y >= _startPoint.Y)
            {
                _newEllipse.SetValue(Canvas.TopProperty, _startPoint.Y);
                _newEllipse.Height = _endPoint.Y - _startPoint.Y;
            }

            else
            {
                _newEllipse.SetValue(Canvas.TopProperty, _endPoint.Y);
                _newEllipse.Height = _startPoint.Y - _endPoint.Y;
            }
        }

        private void DrawRectangle(Rectangle _newRectangle)
        {
            _newRectangle.Stroke = _changeStrokekColour;
            _newRectangle.Fill = _changeFillColour;

            if (_endPoint.X >= _startPoint.X)
            {
                _newRectangle.SetValue(Canvas.LeftProperty, _startPoint.X);
                _newRectangle.Width = _endPoint.X - _startPoint.X;

                string str = "";
                Debug.WriteLine("Curr" + _startPoint);
                Debug.WriteLine("End" + _endPoint);
                str = Convert.ToString(_newRectangle.Width);
                Debug.WriteLine("Rect Width End - Curr" + str);
            }
            else
            {
                _newRectangle.SetValue(Canvas.LeftProperty, _endPoint.X);
                _newRectangle.Width = _startPoint.X - _endPoint.X;

                string str2 = "";
                str2 = Convert.ToString(_newRectangle.Width);
                Debug.WriteLine("Rect Width Curr - End" + str2);
            }

            if (_endPoint.Y >= _startPoint.Y)
            {
                _newRectangle.SetValue(Canvas.TopProperty, _startPoint.Y);
                _newRectangle.Height = _endPoint.Y - _startPoint.Y;
            }

            else
            {
                _newRectangle.SetValue(Canvas.TopProperty, _endPoint.Y);
                _newRectangle.Height = _startPoint.Y - _endPoint.Y;
            }
        }

        private void DrawLine(Line _newline)
        {
            _newline.X1 = _startPoint.X;
            _newline.Y1 = _startPoint.Y;
            _newline.X2 = _endPoint.X;
            _newline.Y2 = _endPoint.Y;
        }

        private void DrawFreehand()
        {
            Line _freehandline = new Line();

            _freehandline.Stroke = _changeStrokekColour;
            _freehandline.StrokeThickness = 4;
            _freehandline.X1 = _startPoint.X;
            _freehandline.Y1 = _startPoint.Y;
            _freehandline.X2 = _endPoint.X;
            _freehandline.Y2 = _endPoint.Y;
            _currentShapeToDraw = _freehandline;
            MyCanvas.Children.Add(_currentShapeToDraw);
            _startPoint = _endPoint;
        }

        private void BtnErase_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void Resize(object sender, DragEventArgs e)
        {


        }

        private void RectRedFill_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _changeFillColour = Brushes.Red;
            SelectedFill.Fill = _changeFillColour;
        }

        private void RectGreenFill_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _changeFillColour = Brushes.Green;
            SelectedFill.Fill = _changeFillColour;
        }

        private void RectBlueFill_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _changeFillColour = Brushes.Blue;
            SelectedFill.Fill = _changeFillColour;
        }

        private void MixedColourSwatch_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MixedFillColour.IsChecked == true)
            {
                _changeFillColour = _mixedFillColor;
            }

            if (MixedStrokeColour.IsChecked == true)
            {
                _changeStrokekColour = _mixedFillColor;
            }
        }

        private void RectRedStroke_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _changeStrokekColour = Brushes.Red;
            SelectedStroke.Fill = _changeStrokekColour;
        }

        private void RectGreenStroke_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _changeStrokekColour = Brushes.Green;
            SelectedStroke.Fill = _changeStrokekColour;
        }

        private void RectBlueStroke_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _changeStrokekColour = Brushes.Blue;
            SelectedStroke.Fill = _changeStrokekColour;
        }

        private void UserStroke_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            UserStroke.Fill = _changeStrokekColour;
        }


        private void UserFill_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            UserFill.Fill = _changeFillColour;
        }

        private SolidColorBrush _colorSwatch;

        private void UpdateColourswatchWithColors()
        {
            if (MixedFillColour.IsChecked == true && MixedStrokeColour.IsChecked == false)
            {
                Color clr = Color.FromArgb(255, Convert.ToByte(RedSlider.Value),
                    Convert.ToByte(GreenSlider.Value), Convert.ToByte(BlueSlider.Value));
                MixedFillColourSwatch.Fill = new SolidColorBrush(clr);
                _mixedFillColor = new SolidColorBrush(clr);
                _changeFillColour = _mixedFillColor;
            }

            if (MixedStrokeColour.IsChecked == true && MixedFillColour.IsChecked == false)
            {
                Color clr = Color.FromArgb(255, Convert.ToByte(RedSlider.Value),
                    Convert.ToByte(GreenSlider.Value), Convert.ToByte(BlueSlider.Value));
                MixedStrokeColourSwatch.Fill = new SolidColorBrush(clr);
                _mixedStrokeColour = new SolidColorBrush(clr);
                _changeStrokekColour = _mixedStrokeColour;
            }
        }

        private void RedSlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateColourswatchWithColors();
        }

        private void GreenSlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateColourswatchWithColors();
        }

        private void BlueSlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateColourswatchWithColors();
        }
        private void MyCanvas_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _currentShapeToDraw = null;
        }

        private void MixedFillColourSwatch_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            UserFill.Fill = _mixedFillColor;
            _changeFillColour = _mixedFillColor;
        }



        private void MixedStrokeColourSwatch_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            UserStroke.Fill = _mixedStrokeColour;
            _changeStrokekColour = _mixedStrokeColour;
        }


        void Handle(CheckBox checkBox)
        {
            // Use IsChecked.
            bool flag = checkBox.IsChecked.Value;

            // Assign Window Title.
            this.Title = "IsChecked = " + flag.ToString();
        }

        private void MixedFillColour_OnChecked(object sender, RoutedEventArgs e)
        {
            Handle(sender as CheckBox);
        }

        private void MixedFillColour_OnUnchecked(object sender, RoutedEventArgs e)
        {
            Handle(sender as CheckBox);
        }



        private void MixedStrokeColour_OnChecked(object sender, RoutedEventArgs e)
        {
            Handle(sender as CheckBox);
        }

        private void MixedStrokeColour_OnUnchecked(object sender, RoutedEventArgs e)
        {
            Handle(sender as CheckBox);
        }


    }

}