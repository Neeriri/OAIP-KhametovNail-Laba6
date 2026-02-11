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

namespace Задание_6
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

        private void elementj(object sender, RoutedEventArgs e)
        {
            double a_0;
            double r;
            if (!double.TryParse(first.Text, out a_0))
            {
                MessageBox.Show("Введите вещественное число");
                return;

            }
            if (!double.TryParse(second.Text, out r))
            {
                MessageBox.Show("Введите вещественно число");
                return;
            }
            if (!int.TryParse(num.Text, out int j) || j < 0)
            {
                MessageBox.Show("Введите целое е нулевое число");
                return;

            }
            if (j > 1000)
            {
                MessageBox.Show("Номер элемента слишком большой нужно не более 1000.");
                return;
            }
            try
            {
                double a_j = a_0 * Math.Pow(r, j);
                if (double.IsInfinity(a_j) || double.IsNaN(a_j))
                {
                    MessageBox.Show("Число бескконечное введите меньшие значения");
                }
                else
                {
                    result.Text = a_j.ToString();
                }

            }
            catch ( Exception ex ) {
                    MessageBox.Show($"{ex.Message}");
                }

            }
        }
    } 
