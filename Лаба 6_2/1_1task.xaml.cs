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
    /// Логика взаимодействия для _1_1task.xaml
    /// </summary>
    public partial class _1_1task : Window
    {
        public _1_1task()
        {
            InitializeComponent();
        }
        private void monthseason(object sender, RoutedEventArgs e)
        {
            string i = month.Text.Trim();
            if (!int.TryParse(month.Text, out int m))
            {
                result.Text = ("Введите число");
            }
            if (string.IsNullOrEmpty(i))
            {
                result.Text = ("Поле ввода не может быть пустым.");
            }
            else
            {
                string season = Seasonresult(m);
                result.Text = season;
            }
        }
        public string Seasonresult(int m)
        {
            if (m < 1 || m > 12)
            {
                return "НекоректныЙ Ввод";
            }
            switch (m)
            {
                case 12:
                case 1:
                case 2:
                    return "Зима";
                case 3: case 4: case 5: return "Весна";
                case 6: case 7: case 8: return "Лето";
                case 9: case 10: case 11: return "Осень";
                default:
                    return "Некоректный месяц";
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
