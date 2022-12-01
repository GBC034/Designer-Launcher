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

namespace Designer_Launcher
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Color color = (Color)ColorConverter.ConvertFromString("#38373d");
            Opt_Area.Background = new SolidColorBrush(color);
        }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void WinClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void WinMin(object sender, RoutedEventArgs e) 
        {
            this.WindowState = WindowState.Minimized; 
        }
        private void Bg_RGB(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Color.FromArgb(255, 56, 55, 61));
        }
    }
}
