using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace BindToCodeBehind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MyClass Class1 { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Class1 = new MyClass();
            DataContext = Class1;
       
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (Class1 != null)
                Class1.MyText = "Changed";
        }
    }
}