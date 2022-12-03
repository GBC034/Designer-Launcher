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
            Color colorR = (Color)ColorConverter.ConvertFromString("#fe5e56");
            Color colorY = (Color)ColorConverter.ConvertFromString("#febb2e");
            Color colorG = (Color)ColorConverter.ConvertFromString("#27c73f");
            CloseButton.Fill = new SolidColorBrush(colorR);
            MinimizeButton.Fill = new SolidColorBrush(colorY);
            MaximizeButton.Fill = new SolidColorBrush(colorG);
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
        
    }
}
