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

namespace GORPROGA.Windows
{
    /// <summary>
    /// Логика взаимодействия для OrderKalash.xaml
    /// </summary>
    public partial class OrderKalash : Window
    {
        private int amount = 0;
        public OrderKalash()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            amount -= 1;
            AmountGun.Text = Convert.ToString(amount);
            AmountTovar.Text = Convert.ToString(amount);
            Oplata.Text = Convert.ToString((amount) * 12990);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            amount += 1;
            AmountGun.Text = Convert.ToString(amount);
            AmountTovar.Text = Convert.ToString(amount);
            Oplata.Text = Convert.ToString((amount) * 12990);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Создаем новое окно (окно регистрации)
            GunWindow gunWindow = new GunWindow();

            // Открываем новое окно
            gunWindow.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заказ успешно оформлен!");
        }
    }
}
