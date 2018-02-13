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

namespace WpfApp1
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

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            int res, a, b;
            a = Convert.ToInt32(input_a.GetLineText(0));
            b = Convert.ToInt32(input_b.GetLineText(0));
            res = a + b;
            output.Content = Convert.ToString(res);            
        }

        private void Button_Click_Diff(object sender, RoutedEventArgs e)
        {
            int res, a, b;
            a = Convert.ToInt32(input_a.GetLineText(0));
            b = Convert.ToInt32(input_b.GetLineText(0));
            res = a - b;
            output.Content = Convert.ToString(res);
        }

        private void Button_Click_Div(object sender, RoutedEventArgs e)
        {
            int res, a, b;
            a = Convert.ToInt32(input_a.GetLineText(0));
            b = Convert.ToInt32(input_b.GetLineText(0));
            res = a / b;
            output.Content = Convert.ToString(res);
        }

        private void Button_Click_Multipl(object sender, RoutedEventArgs e)
        {
            int res, a, b;
            a = Convert.ToInt32(input_a.GetLineText(0));
            b = Convert.ToInt32(input_b.GetLineText(0));
            res = a * b;
            output.Content = Convert.ToString(res);
        }
    }
}
