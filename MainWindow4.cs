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

namespace Задание4
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



        private void mas(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            const int a = 50;
            const int c = 4; 
            for (int i = 0; i < 1000; i++)
            {
                string f= i.ToString().PadRight(c);
                sb.Append(f);

                if ((i + 1) % a == 0)
                {
                    sb.AppendLine();
                }
            }

            masres.Text = sb.ToString();
          
        }
        private void Two_digitnum(object sender, RoutedEventArgs e)
        {
         
            int[,] mas1 = new int[100, 10];

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mas1[i, j] = i * 10 + j; 
                }
            }
            foreach (int i in mas1) {
                if (i > 9 && i < 100) { 
                    two_digit.Text = i.ToString();
                }
            }
        }

    }
}
