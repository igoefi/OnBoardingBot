using System.Windows;
using System.Windows.Controls;
using TelegramBot.Classes;
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
            var textBox = (TextBox)TxbName.Template.FindName("TB", TxbName);
            var name = textBox.Text;

            textBox = (TextBox)TxbAbout.Template.FindName("TB", TxbAbout);
            var about = textBox.Text;

            if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(about))
            {
                MessageBox.Show("Одно или несколько полей не заполнены");
                return;
            }

            CompanyProfile.Data.CompanyName = name;
            CompanyProfile.Data.CompanyInfo = about;

            FrameNav.FrameNavigation.GoBack();
        }
    }
}
