using System.Windows;
using System.Windows.Controls;
using TelegramBot.Classes.Helper;

namespace TelegramBot.Pages.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для ListEmployee.xaml
    /// </summary>
    public partial class ListEmployee : Page
    {
        public ListEmployee()
        {
            InitializeComponent();
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.GoBack();
        }
    }
}
