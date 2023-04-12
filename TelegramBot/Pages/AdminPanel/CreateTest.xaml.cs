using System.Windows;
using System.Windows.Controls;
using TelegramBot.Classes.Helper;

namespace TelegramBot.Pages.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для CreateTest.xaml
    /// </summary>
    public partial class CreateTest : Page
    {
        public CreateTest()
        {
            InitializeComponent();
        }
        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.GoBack();
        }
        private void BtnClickCreateTest(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.Navigate(new PageCreateTest());
        }
        private void BtnClickChangeTest(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.Navigate(new PageChangeTest());
        }
    }
}
