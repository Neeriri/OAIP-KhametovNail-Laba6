
using Лаба_6_2;

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



namespace Лаба_6_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OpenWindow1(object sender, RoutedEventArgs e)
        {
            var win2 = new _1_1task();
            win2.Show();
            this.Close();
        }
        private void OpenWindow2(object sender, RoutedEventArgs e)
        {
            var win2 = new _2task();
            win2.Show();
            this.Close();
        }

        private void OpenWindow3(object sender, RoutedEventArgs e)
        {
            var win3 = new _3task();
            win3.Show();
            this.Close();
        }

        private void OpenWindow4(object sender, RoutedEventArgs e)
        {
            var win4 = new _4task();
            win4.Show();
            this.Close();
        }

        private void OpenWindow5(object sender, RoutedEventArgs e)
        {
            var win5 = new _5task();
            win5.Show();
            this.Close();
        }

        private void OpenWindow6(object sender, RoutedEventArgs e)
        {
            var win6 = new _6task();
            win6.Show();
            this.Close();
        }
    }
}
