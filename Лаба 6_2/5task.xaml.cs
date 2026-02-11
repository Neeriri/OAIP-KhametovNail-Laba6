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
using System.Windows.Shapes;

namespace Лаба_6_2
{
    /// <summary>
    /// Логика взаимодействия для _5task.xaml
    /// </summary>
    public partial class _5task : Window
    {
        public _5task()
        {
            InitializeComponent();
        }
        private void sum_two_mas(object sender, EventArgs e)
        {
            int rows;
            int colums;
            int maxsize = 35;

            Random a = new Random();

            if (!int.TryParse(row.Text, out rows) || rows <= 0)
            {
                MessageBox.Show("Введите целые не отрицательные числа!!! в первой строчке");
                return;
            }

            if (!int.TryParse(colm.Text, out colums) || colums <= 0)
            {
                MessageBox.Show("Введите целые не отрицательные числа!!! во второй строчке");
                return;
            }
            if (rows >= maxsize && colums >= maxsize)
            {
                MessageBox.Show($"Размер матрицы не  должен быть больше{maxsize * maxsize} ");
                return;
            }
            try
            {
                double[,] mas2 = new double[rows, colums];
                double[,] mas1 = new double[rows, colums];
                double[,] mas3 = new double[rows, colums];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {

                        mas1[i, j] = a.NextDouble() * 5 - 2.5;
                        mas2[i, j] = a.NextDouble() * 5 - 2.5;
                        mas3[i, j] = mas1[i, j] + mas2[i, j];
                    }

                }
                var sb = new StringBuilder();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        sb.Append(mas3[i, j].ToString("F2"));
                        if (j < colums - 1) sb.Append("  ");
                    }
                    sb.AppendLine();
                }

                masresult.Text = sb.ToString();
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Память то не бесконечная.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($" ошибка: {ex.Message}");
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
