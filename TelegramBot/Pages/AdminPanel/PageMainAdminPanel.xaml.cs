using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using TelegramBot.Classes;
using TelegramBot.Classes.Helper;

namespace TelegramBot.Pages.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для PageMainAdminPanel.xaml
    /// </summary>
    public partial class PageMainAdminPanel : Page
    {
        BotLogic _bot;
        public PageMainAdminPanel()
        {
            InitializeComponent();
        }

        private void BtnClickLaunchBot(object sender, RoutedEventArgs e)
        {
            string token = CompanyProfile.Token;
            if (token == null)
            {
                MessageBox.Show("Set bot token in settings");
                return;
            }
            _bot = new BotLogic();
            _bot.StartBot(token);
            MessageBox.Show("Bot started");
        }

        private void BtnClickGoSettings(object sender, RoutedEventArgs e) =>
            FrameNav.FrameNavigation.Navigate(new PageBotSettings());
        private void BtnClickCreateUser(object sender, RoutedEventArgs e) =>
            FrameNav.FrameNavigation.Navigate(new CreateUser());
        private void BtnClickKeyWords(object sender, RoutedEventArgs e) =>
            FrameNav.FrameNavigation.Navigate(new KeyWords());
        private void BtnClickListEmployee(object sender, RoutedEventArgs e) =>
            FrameNav.FrameNavigation.Navigate(new ListEmployee());
        private void BtnClickCreateTest(object sender, RoutedEventArgs e) =>
            FrameNav.FrameNavigation.Navigate(new CreateTest());
    }
}
