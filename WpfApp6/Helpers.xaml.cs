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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Helpers.xaml
    /// </summary>
    public partial class Helpers : Page
    {
        public Helpers()
        {
            InitializeComponent();
        }
        private void Tarifs_but(object sender, RoutedEventArgs e)
        {
            Helpers helpers = new Helpers();
            Tarifs tarifs = new Tarifs();
            MainWindow mainWindow = new MainWindow();
            Helpers.Close();
            Tarifs.Show();
        }
        private void CarMap_but(object sender, RoutedEventArgs e)
        {
            CarMap carMap = new CarMap();
            Helpers helpers = new Helpers();
            MainWindow mainWindow = new MainWindow();
            Helpers.Close();
            CarMap.Show();
        }
        private void Cabinet_but(object sender, RoutedEventArgs e)
        {
            Cabinet cabinet = new Cabinet();
            Helpers tarifs = new Helpers();
            MainWindow mainWindow = new MainWindow();
            Helpers.Close();
            Cabinet.Show();
        }
    }
}
