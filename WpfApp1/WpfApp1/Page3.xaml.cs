using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        private MainWindow mainWindow;
        public Page3(MainWindow mainWindow)
        {
            InitializeComponent();
            mainWindow.NavigateToPage3WithDelay();
            this.mainWindow = mainWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Здесь открытие PDF-файла");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Здесь открытие PDF-файла");
        }
    }
}
