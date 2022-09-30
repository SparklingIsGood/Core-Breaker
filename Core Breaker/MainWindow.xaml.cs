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

namespace Core_Breaker
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        Brush oldColor = Brushes.Transparent;
        Border currentHighlighted = null;
        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            currentHighlighted = (Border)sender;
            oldColor = currentHighlighted.Background;
            currentHighlighted.Background = Brushes.WhiteSmoke;
        }

        private void button_MouseLeave(object sender, MouseEventArgs e)
        {
            currentHighlighted.Background = oldColor;
        }
    }
}
