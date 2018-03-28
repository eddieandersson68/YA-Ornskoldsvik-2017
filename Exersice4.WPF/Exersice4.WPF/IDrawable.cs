using System.Windows;

namespace Exersice4.WPF
{
    public partial class MainWindow
    {
        public interface IDrawable
        {
            void Draw(Point location);
        }
    }
}
