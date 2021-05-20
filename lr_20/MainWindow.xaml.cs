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

namespace lr_20
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Binding bind = new Binding();
            bind.Source = sldr;
            bind.Path = new PropertyPath("Value");
            progressBar.SetBinding(ProgressBar.ValueProperty, bind);
        }

        private void PB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Brush b = Brushes.Blue;
            string stylename = "winter";
            if (sldr.Value <= 20)
            {
                b = Brushes.Blue;
                stylename = "winter";
            }
            if ((sldr.Value <= 40) & (sldr.Value > 20))
            {
                b = Brushes.Yellow;
                stylename = "fall";
            }
            if ((sldr.Value <= 80) & (sldr.Value > 60))
            {
                b = Brushes.Orange;
                stylename = "spring";
            }
            if ((sldr.Value <= 100) & (sldr.Value > 80))
            {
                b = Brushes.Red;
                stylename = "summer";
            }
            progressBar.Foreground = b;
            rect.Fill = (ImageBrush)this.FindResource(stylename);
        }
    }
}
