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

    public partial class _2task: Window
    {
        public _2task()
        {
            InitializeComponent();
        }
        private void mathresult(object sender, RoutedEventArgs e)
        {
            const int a = 150;
            int c = 0;
            StringBuilder sb = new StringBuilder();
            MessageBox.Show("вычисления");
            for (int n = 1000; n <= 9999; n++)
            {
                int d1 = n / 1000;
                int d2 = (n / 100) % 10;
                int d3 = (n / 10) % 10;
                int d4 = n % 10;

                if (d1 != d2 && d1 != d3 && d1 != d4 &&
                    d2 != d3 && d2 != d4 &&
                    d3 != d4)
                {
                    if (c > 0)
                        sb.Append(" ");
                    sb.Append(n);
                    c++;
                }
                if (c >= a)
                {
                    sb.AppendLine();
                    c = 0;
                }


                result.Text = sb.ToString();

            }
        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {

            var mainMenu = new MainWindow();
            mainMenu.Show();
            this.Close();
        }
    }
}
