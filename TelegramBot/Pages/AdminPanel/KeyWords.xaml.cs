using System.Windows;
using System.Windows.Controls;
using TelegramBot.Classes;
using TelegramBot.Classes.Helper;

namespace TelegramBot.Pages.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для KeyWords.xaml
    /// </summary>
    public partial class KeyWords : Page
    {
        public KeyWords()
        {
            InitializeComponent();
        }
        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.GoBack();
        }

        private void BtnClickAdd(object sender, RoutedEventArgs e)
        {
            var textBox = (TextBox)TxbKeyPhrase.Template.FindName("TB", TxbKeyPhrase);
            var key = textBox.Text;

            textBox = (TextBox)TxbAnswer.Template.FindName("TB", TxbAnswer);
            var answer = textBox.Text;

            if(string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(answer))
            {
                MessageBox.Show("Одно из полей не заполнено");
                return;
            }
        }

        private void BtnClickDelete(object sender, RoutedEventArgs e)
        {
            var selected = (string)CmbBoxWords.SelectedValue;
            CompanyProfile.Data.SpecialWords.Remove(selected);
        }

        private void BtnClickChange(object sender, RoutedEventArgs e)
        {
            
        }

        private void CmbBoxChangedWords(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
