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
    /// Логика взаимодействия для OrderMP155T.xaml
    /// </summary>
    public partial class OrderMP155T : Window
    {
        private int amount = 0;
        public OrderMP155T()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            amount -= 1;
            AmountGun.Text = Convert.ToString(amount);
            AmountTovar.Text = Convert.ToString(amount);
            Oplata.Text = Convert.ToString((amount) * 79900);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            amount += 1;
            AmountGun.Text = Convert.ToString(amount);
            AmountTovar.Text = Convert.ToString(amount);
            Oplata.Text = Convert.ToString((amount) * 79900);
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
