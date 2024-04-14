using System.Windows;
using System.Windows.Controls;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        private MainWindow mainWindow;

        public Page4(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void btm_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.NavigateToPage1();
        }
    }
}
