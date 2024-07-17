
using System.Windows;
using System.Windows.Input;


namespace Интерфейс
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown (object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

    
    }
}
