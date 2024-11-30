﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp6;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private const string LoginText = "введите ваш логин";
        private const string PasswordText = "введите ваш пароль";
        private const string EmailText = "введите вашу электронную почту";
        private const string PhoneText = "введите ваш номер телефона";
        private void Login_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && textBox.Text == LoginText)
            {
                textBox.Text = string.Empty;
                textBox.Foreground = Brushes.Black;
            }
        }

        private void Login_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = LoginText;
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void Password_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && textBox.Text == PasswordText)
            {
                textBox.Text = string.Empty;
                textBox.Foreground = Brushes.Black;
            }
        }

        private void Password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = PasswordText;
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void Email_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && textBox.Text == EmailText)
            {
                textBox.Text = string.Empty;
                textBox.Foreground = Brushes.Black;
            }
        }

        private void Email_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = EmailText;
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void Phone_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && textBox.Text == PhoneText)
            {
                textBox.Text = string.Empty;
                textBox.Foreground = Brushes.Black;
            }
        }

        private void Phone_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = PhoneText;
                textBox.Foreground = Brushes.Gray;
            }
        }



        private void Reg_but(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            Window1 window1 = new Window1();
            mainWindow.Close();
            window1.Show();
        }

        private void Sign_but(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            Window1 window1 = new Window1();
            mainWindow.Close();
            window1.Show();
        }

    }
}