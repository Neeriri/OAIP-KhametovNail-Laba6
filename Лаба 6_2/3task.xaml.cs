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
    /// Логика взаимодействия для _3task.xaml
    /// </summary>
    public partial class _3task : Window
    {
        public _3task()
        {
            InitializeComponent();
        }
        private void masresult(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Запуск");
            string mas2 = mas1.Text;
            if (string.IsNullOrWhiteSpace(mas2))
            {
                result.Text = "Ошибка: введите числа через пробел";
                return;
            }
            try
            {
                int[] num = mas2.Split(new char[] { ' ', ',', '\t' },
                                               StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                if (num.Length == 0)
                {
                    result.Text = "Ошибка введите числа";
                    return;
                }
                var mostel = num.GroupBy(x => x).OrderByDescending(g => g.Count()).First();//обединяем в группы сортируем и первое ,thtv
                result.Text = $"Элемент {mostel.Key}  встречается {mostel.Count()}";
            }

            catch (Exception ex)
            {
                result.Text = ex.Message;
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
