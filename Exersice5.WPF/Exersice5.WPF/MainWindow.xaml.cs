using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
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
        private Shape _currentShapeToDraw;
        private SolidColorBrush _changeFillColour;
        private SolidColorBrush _changeStrokekColour;
        private SolidColorBrush _mixedFillColor;
        private SolidColorBrush _mixedStrokeColour;
        private SolidColorBrush _userStrokeColour;
        public int StrokeThickness { get; private set; }

        private bool _ellipseButtonPressed = false;
        private bool _rectButtonPressed = false;
        private bool _lineButtonPressed = false;
        private bool _freehandPressed = false;
        private bool _resetMixedStrokeColours = false;
        private bool _resetMixedFillColours = false;


        public MainWindow()
        {
            InitializeComponent();
            DefaultSettings();
        }

#region Button handling        
        public void BtnEllipse_OnClick(object sender, RoutedEventArgs e)
        {
            BtnEllipse.Background = Brushes.CadetBlue;
            BtnRect.Background = Brushes.LightGray;
            BtnLine.Background = Brushes.LightGray;
            BtnDraw.Background = Brushes.LightGray;
            //BtnResetMixedStrokeColour.Background = Brushes.LightGray;
            //BtnResetMixedFillColour.Background = Brushes.LightGray;
            //BtnClear.Background = Brushes.LightGray;

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
            BtnDraw.Background = Brushes.LightGray;
           // BtnClear.Background = Brushes.LightGray;
            //BtnResetMixedStrokeColour.Background = Brushes.LightGray;
            //BtnResetMixedFillColour.Background = Brushes.LightGray;

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
            BtnDraw.Background = Brushes.LightGray;
            //BtnClear.Background = Brushes.LightGray;
            //BtnResetMixedStrokeColour.Background = Brushes.LightGray;
            //BtnResetMixedFillColour.Background = Brushes.LightGray;

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
           // BtnClear.Background = Brushes.LightGray;
            //BtnResetMixedFillColour.Background = Brushes.LightGray;
            //BtnResetMixedFillColour.Background = Brushes.LightGray;



            _freehandPressed = true;
            _ellipseButtonPressed = false;
            _rectButtonPressed = false;
            _lineButtonPressed = false;

            // StartDraw();
        }
#endregion

        private void DefaultSettings()
        {
            
            BtnDraw.Background = Brushes.LightGray;
            BtnEllipse.Background = Brushes.LightGray;
            BtnRect.Background = Brushes.LightGray;
            BtnLine.Background = Brushes.LightGray;

            _changeStrokekColour = Brushes.Red;
            SelectedStroke.Fill = _changeStrokekColour;
            _changeFillColour = Brushes.Blue;
            SelectedFill.Fill = _changeFillColour;
        }

 #region Shapes Methods
        public void BtnClear_OnClick(object sender, RoutedEventArgs e)
        {
                       
            if (MessageBox.Show("Delete all shapes on canvas", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                MyCanvas.Children.Clear();
            }
            
        }

        private void MyCanvas_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _startPoint = e.GetPosition(MyCanvas);
        }

        private void MyCanvas_OnMouseMove(object sender, MouseEventArgs e)
        {
            _endPoint = e.GetPosition(MyCanvas);

            if (e.LeftButton == MouseButtonState.Pressed && _freehandPressed)
                DrawFreehand();

            if (e.LeftButton == MouseButtonState.Pressed && _lineButtonPressed)
            {
                if (_currentShapeToDraw == null)
                {
                    var _newline2 = new Line();

                    MyCanvas.Children.Add(_newline2);
                    _currentShapeToDraw = _newline2;
                }
                var _newline = _currentShapeToDraw as Line;
                DrawLine(_newline, _startPoint, _endPoint);
            }

            if (e.LeftButton == MouseButtonState.Pressed && _ellipseButtonPressed)
            {
                if (_currentShapeToDraw == null)
                {
                    var _newEllipse2 = new Ellipse();

                    MyCanvas.Children.Add(_newEllipse2);
                    _currentShapeToDraw = _newEllipse2;
                }
                var _newEllipse = _currentShapeToDraw as Ellipse;

                DrawEllipse(_newEllipse, _startPoint, _endPoint);
            }

            if (e.LeftButton == MouseButtonState.Pressed && _rectButtonPressed)
            {
                if (_currentShapeToDraw == null)
                {
                    var _newRectangle2 = new Rectangle();

                    MyCanvas.Children.Add(_newRectangle2);
                    _currentShapeToDraw = _newRectangle2;
                }
                var _newRectangle = _currentShapeToDraw as Rectangle;

                DrawRectangle(_newRectangle, _startPoint, _endPoint);
            }
        }

        private void MyCanvas_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _currentShapeToDraw = null;
        }

        private void DrawEllipse(Ellipse _newEllipse, Point _startP, Point _endPoint)
        {

            _newEllipse.Stroke = _changeStrokekColour;
            _newEllipse.StrokeThickness = BrushSize.Value;
            _newEllipse.Fill = _changeFillColour;

            if (_endPoint.X >= _startPoint.X)
            {
                _newEllipse.SetValue(Canvas.LeftProperty, _startPoint.X);
                _newEllipse.Width = _endPoint.X - _startPoint.X;
            }
            else
            {
                _newEllipse.SetValue(Canvas.LeftProperty, _endPoint.X);
                _newEllipse.Width = _startPoint.X - _endPoint.X;
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

        private void DrawRectangle(Rectangle _newRectangle, Point _startPoint, Point _endPoint)
        {

            _newRectangle.Stroke = _changeStrokekColour;
            _newRectangle.StrokeThickness = BrushSize.Value;
            _newRectangle.Fill = _changeFillColour;

            if (_endPoint.X >= _startPoint.X)
            {
                _newRectangle.SetValue(Canvas.LeftProperty, _startPoint.X);
                _newRectangle.Width = _endPoint.X - _startPoint.X;
            }
            else
            {
                _newRectangle.SetValue(Canvas.LeftProperty, _endPoint.X);
                _newRectangle.Width = _startPoint.X - _endPoint.X;
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

        private void DrawLine(Line _newline, Point _startPoint, Point _endPoint)
        {
            _newline.Stroke = _changeStrokekColour;
            _newline.StrokeThickness = BrushSize.Value;
            _newline.X1 = _startPoint.X;
            _newline.Y1 = _startPoint.Y;
            _newline.X2 = _endPoint.X;
            _newline.Y2 = _endPoint.Y;
        }

        private void DrawFreehand()
        {
            Line _freehandline = new Line();
            
            _freehandline.Stroke = _changeStrokekColour;
            _freehandline.StrokeThickness = BrushSize.Value;
            _freehandline.X1 = _startPoint.X;
            _freehandline.Y1 = _startPoint.Y;
            _freehandline.X2 = _endPoint.X;
            _freehandline.Y2 = _endPoint.Y;
            _currentShapeToDraw = _freehandline;
            MyCanvas.Children.Add(_currentShapeToDraw);
            _startPoint = _endPoint;
        }
#endregion;
 
#region Fill types
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

        private void BtnResetMixedFillColour_OnClick(object sender, RoutedEventArgs e)
        {
            _resetMixedFillColours = true;
            Color clr = Color.FromArgb(255, Convert.ToByte(RedSlider.Value = 0),
                Convert.ToByte(GreenSlider.Value = 0), Convert.ToByte(BlueSlider.Value = 0));
            MixedFillColourSwatch.Fill = new SolidColorBrush(clr);
            _mixedFillColor = new SolidColorBrush(clr);
            _changeFillColour = _mixedFillColor;
        }

        private void RectBlueFill_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _changeFillColour = Brushes.Blue;
            SelectedFill.Fill = _changeFillColour;
        }

        private void UserFill_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateColourswatchWithColors();
            UserFill.Fill = _mixedFillColor;
        }       
#endregion

#region Stroke types
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
            UpdateColourswatchWithColors();
            UserStroke.Fill = _mixedStrokeColour;
        }

        private void BtnResetMixedStrokeColour_OnClick(object sender, RoutedEventArgs e)
        {
            _resetMixedStrokeColours = true;
            Color clr = Color.FromArgb(255, Convert.ToByte(RedSlider.Value = 0),
                Convert.ToByte(GreenSlider.Value = 0), Convert.ToByte(BlueSlider.Value = 0));
            MixedStrokeColourSwatch.Fill = new SolidColorBrush(clr);
            _mixedStrokeColour = new SolidColorBrush(clr);
            _changeStrokekColour = _mixedStrokeColour;        }
#endregion

#region sliders
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
        
        private void BrushSize_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            StrokeThickness = (int)BrushSize.Value;
            //Binding myBinding = new Binding("Value");
            //myBinding.Source = BrushSize;
            //StrokeThickness.SetBinding(Shape.StrokeThicknessProperty, myBinding);

        }   
#endregion

#region Colour handling    
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

        private void Handle(CheckBox checkBox)
        {
            // Use IsChecked.
            bool flag = checkBox.IsChecked.Value;

            // Assign Window Title.
            this.Title = "IsChecked = " + flag;
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
#endregion
    }    
}