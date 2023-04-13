using System.Windows;
using System.Windows.Controls;
using TelegramBot.Classes;
using TelegramBot.Classes.Helper;
using TelegramBot.Pages.AdminPanel;

namespace TelegramBot.Pages
{
    /// <summary>
    /// Логика взаимодействия для StartPanel.xaml
    /// </summary>
    public partial class StartPanel : Page
    {
        public StartPanel()
        {
            InitializeComponent();
        }

        private void BtnClickNextPage(object sender, RoutedEventArgs e)
        {
            var textBox = (TextBox)TxbCompanyName.Template.FindName("TB", TxbCompanyName);
            var name = textBox.Text;

            textBox = (TextBox)TxbAboutCompany.Template.FindName("TB", TxbAboutCompany);
            var about = textBox.Text;

            textBox = (TextBox)TxbToken.Template.FindName("TB", TxbToken);
            var token = textBox.Text;

            textBox = (TextBox)TxbAnswer.Template.FindName("TB", TxbAnswer);
            var answer = textBox.Text;

            if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(about) || string.IsNullOrWhiteSpace(token) || string.IsNullOrWhiteSpace(answer))
            {
                MessageBox.Show("Одно или несколько полей не заполнено");
                return;
            }

            CompanyProfile.FirstStart(name, about, token, answer);

            FrameNav.FrameNavigation.Navigate(new PageMainAdminPanel());
        }
    }
}
