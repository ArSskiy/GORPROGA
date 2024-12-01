using GORPROGA.ClassPr;
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
    /// Логика взаимодействия для Pnevma.xaml
    /// </summary>
    public partial class Pnevma : Page
    {
        public Pnevma()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ClassConnect.FrameGun.Navigate(new Kalash());
        }
    }
}
