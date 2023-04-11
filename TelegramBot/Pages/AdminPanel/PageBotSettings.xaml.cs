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
            TxbToken.Text = CompanyProfile.Data.Token ?? string.Empty;
        }

        private void BtnClickSaveSettings(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)TxbToken.Template.FindName("TB", TxbToken);
            string token = textBox.Text;
            if (string.IsNullOrWhiteSpace(token) || !BotLogic.IsTokenCorrect(token))
            {
                MessageBox.Show("Uncorrect token");
                return;
            }
            CompanyProfile.Data.Token = token;
            FrameNav.FrameNavigation.GoBack();
        }
    }
}
