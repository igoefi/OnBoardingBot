using System.Windows;
using System.Windows.Controls;
using TelegramBot.Classes;
using TelegramBot.Classes.Helper;

namespace TelegramBot.Pages.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для PageBotSettings.xaml
    /// </summary>
    public partial class PageBotSettings : Page
    {
        public PageBotSettings()
        {
            InitializeComponent();
            TxbToken.Text = CompanyProfile.Token ?? string.Empty;
        }

        private void BtnClickSaveSettings(object sender, RoutedEventArgs e)
        {
            var textBox = (TextBox)TxbToken.Template.FindName("TB", TxbToken);
            var token = textBox.Text;
            if (string.IsNullOrWhiteSpace(token) || !BotLogic.IsTokenCorrect(token))
            {
                MessageBox.Show("Uncorrect token");
                return;
            }
            CompanyProfile.Token = token;
            FrameNav.FrameNavigation.GoBack();
        }
        private void BtnClickBack(object sender, RoutedEventArgs e) =>
            FrameNav.FrameNavigation.GoBack();
    }
}
