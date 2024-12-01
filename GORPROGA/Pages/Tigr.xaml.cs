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
    /// Логика взаимодействия для Tigr.xaml
    /// </summary>
    public partial class Tigr : Page
    {
        public Tigr()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Создаем новое окно (окно регистрации)
            OrderTigr orderTigr = new OrderTigr();

            // Открываем новое окно
            orderTigr.Show();
            
        }
    }
}
