using System.Windows;
using System.Windows.Controls;
using TelegramBot.Classes.Helper;

namespace TelegramBot.Pages.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для PageAboutComp.xaml
    /// </summary>
    public partial class PageAboutComp : Page
    {
        public PageAboutComp()
        {
            InitializeComponent();
        }
        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.GoBack();
        }
        private void BtnClickSaveAboutComp(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.GoBack();
        }
    }
}
