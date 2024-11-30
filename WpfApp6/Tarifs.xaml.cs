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
    /// Логика взаимодействия для Tarifs.xaml
    /// </summary>
    public partial class Tarifs : Page
    {
        public Tarifs()
        {
            InitializeComponent();
        }

        private void Helpers_but(object sender, RoutedEventArgs e)
        {
            Helpers helpers = new Helpers();
            Tarifs tarifs = new Tarifs();
            MainWindow mainWindow = new MainWindow();
            Tarifs.Close();
            Helpers.Show();
        }
        private void CarMap_but(object sender, RoutedEventArgs e)
        {
            CarMap carMap = new CarMap();
            Tarifs tarifs = new Tarifs();
            MainWindow mainWindow = new MainWindow();
            Tarifs.Close();
            CarMap.Show();
        }
        private void Cabinet_but(object sender, RoutedEventArgs e)
        {
            Cabinet cabinet = new Cabinet();
            Tarifs tarifs = new Tarifs();
            MainWindow mainWindow = new MainWindow();
            Tarifs.Close();
            Cabinet.Show();
        }
    }
}
