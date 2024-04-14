using System.Windows;
using System.Windows.Controls;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private MainWindow mainWindow;
        public Page1(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.NavigateToPage2();
        }
    }
}
