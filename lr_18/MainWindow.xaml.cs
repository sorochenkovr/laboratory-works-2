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

namespace lr_18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double Z = 0;
            double x = Convert.ToDouble(TextX.Text);
            double y = Convert.ToDouble(TextY.Text);
            double K = Convert.ToDouble(ComboK.Text);
            double N = Convert.ToDouble(ComboN.Text);
            
            for (int i = 1; i <= N; i++)
                for (int j = 1; j <= K; j++)
                {
                    Z += (Math.Sin(x) * Math.Pow(x, i) + Math.Cos(y) * Math.Pow(y, i)) / (i * j);
                }
            this.Title = Z.ToString();
        }
    }
}
