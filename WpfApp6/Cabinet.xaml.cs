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
    /// Логика взаимодействия для Cabinet.xaml
    /// </summary>
    public partial class Cabinet : Page
    {
        public Cabinet()
        {
            InitializeComponent();
        }
        private void Tarifs_but(object sender, RoutedEventArgs e)
        {
            Helpers helpers = new Helpers();
            Cabinet cabinet = new Cabinet();
            MainWindow mainWindow = new MainWindow();
            Cabinet.Close();
            Tarifs.Show();
        }
        private void Helpers_but(object sender, RoutedEventArgs e)
        {
            CarMap carMap = new CarMap();
            Helpers helpers = new Helpers();
            MainWindow mainWindow = new MainWindow();
            Cabinet.Close();
            Helpers.Show();
        }
        private void CarMap_but(object sender, RoutedEventArgs e)
        {
            Cabinet cabinet = new Cabinet();
            CarMap carMap = new CarMap();
            MainWindow mainWindow = new MainWindow();
            Cabinet.Close();
            CarMap.Show();
        }
    }
}
