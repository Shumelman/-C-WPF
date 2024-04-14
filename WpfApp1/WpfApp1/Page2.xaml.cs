using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private MainWindow mainWindow;

        public Page2(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.NavigateToPage3();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Здесь открытие PDF-файла");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Здесь открытие PDF-файла");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            tb2.Focus();
        }

        private void tb2_TextChanged(object sender, TextChangedEventArgs e)
        {
            tb3.Focus();
        }

        private void tb3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(tb3.Text, out int result))
            {
                tb3.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
            }
        }
    }
}
