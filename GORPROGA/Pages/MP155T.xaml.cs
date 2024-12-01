using GORPROGA.Windows;
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

namespace GORPROGA.Pages
{
    /// <summary>
    /// Логика взаимодействия для MP155T.xaml
    /// </summary>
    public partial class MP155T : Page
    {
        public MP155T()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Создаем новое окно (окно регистрации)
            OrderMP155T orderMP155T = new OrderMP155T();

            // Открываем новое окно
            orderMP155T.Show();
        }
    }
}
