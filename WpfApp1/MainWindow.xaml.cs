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

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void monthseason(object sender, RoutedEventArgs e)
        {
            if(!int.TryParse(month.Text,out int m))
            {
                Console.WriteLine("Введите число");
            }
            else
            {
                string season = Seasonresult( m);
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
                case 3: case 4:case 5: return "Весна";
                case 6: case 7:case 8: return "Лето";
                case 9: case 10: case 11: return "Осень";
                default:
                    return "Некоректный месяц";
            }
        }
    }
}
