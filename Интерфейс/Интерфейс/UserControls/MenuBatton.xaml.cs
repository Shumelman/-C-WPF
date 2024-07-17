
using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.IconPacks;


namespace Интерфейс.UserControls
{
    /// <summary>
    /// Логика взаимодействия для MenuBatton.xaml
    /// </summary>
    public partial class MenuBatton : UserControl
    {
        public MenuBatton()
        {
            InitializeComponent();
        }

        public PackIconMaterialKind Icon
        {
            get { return (PackIconMaterialKind) GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(PackIconMaterialKind), typeof(MenuBatton));




        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }
        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register("IsActive", typeof(bool), typeof(MenuBatton));
    }




}
