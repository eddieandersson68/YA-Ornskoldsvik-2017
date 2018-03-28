using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;


namespace Exersice4.WPF
{
    public partial class MainWindow
    {
        public class MyCircle : IDrawable
        {
            public Ellipse Circle { get; private set; }

            public MyCircle(Point location)
            {
                Circle = new Ellipse
                {
                    Stroke = Brushes.Black,
                    Fill = Brushes.DarkRed,
                    StrokeThickness = 3,
                    Margin = new Thickness(location.X, location.Y, 0, 0)
                };
            }

            public void Draw(Point location)
            {
                if(Circle != null)
                {
                    Circle.Width = location.X - Circle.Margin.Left;
                    Circle.Height = location.Y - Circle.Margin.Top;
                }
            }
        }


       
    }
}
