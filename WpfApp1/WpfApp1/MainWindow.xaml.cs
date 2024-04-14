using System;
using System.Threading.Tasks;
using System.Windows;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigateToPage0();
        }
        public void NavigateToPage0()
        {
            MainFrame.Navigate(new Page4(this));
        }
        public void NavigateToPage1()
        {
            MainFrame.Navigate(new Page1(this));
        }

        public void NavigateToPage2()
        {
            MainFrame.Navigate(new Page2(this));
        }
        public void NavigateToPage3()
        {
            Page3 page3 = new Page3(this);
            MainFrame.Navigate(page3);
           // StartCloseTimer(page3);
        }


        public async void NavigateToPage3WithDelay()
        {
           
            await Task.Delay(20000); // Задержка 20 секунд
            NavigateToPage0();  // Переход на первую страницу после задержки
        }
      

       
    }
}
