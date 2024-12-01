using GORPROGA.ClassPr;
using GORPROGA.Pages;
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
    /// Логика взаимодействия для GunWindow.xaml
    /// </summary>
    public partial class GunWindow : Window
    {
        public GunWindow()
        {
            InitializeComponent();
            ClassConnect.FrameGun = GunFrame;
            GunFrame.Navigate(new PervoeRuzhie());
        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            GunFrame.Navigate(new PervoeRuzhie());
        }

        private void TextBlock_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            GunFrame.Navigate(new Pnevma());
        }

        private void TextBlock_MouseLeftButtonUp_2(object sender, MouseButtonEventArgs e)
        {
            GunFrame.Navigate(new Nareznoe());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
