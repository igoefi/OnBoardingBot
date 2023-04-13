using System.Linq;
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

            CmbBoxWords.ItemsSource = CompanyProfile.Data.SpecialWords.Keys.ToList();
        }
        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.GoBack();
        }

        private void BtnClickAdd(object sender, RoutedEventArgs e)
        {
            var textBox = (TextBox)TxbKeyPhrase.Template.FindName("TB", TxbKeyPhrase);
            var key = textBox.Text;

            var textBox2 = (TextBox)TxbAnswer.Template.FindName("TB", TxbAnswer);
            var answer = textBox2.Text;

            if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(answer))
            {
                MessageBox.Show("Одно из полей не заполнено");
                return;
            }

            if (CompanyProfile.Data.SpecialWords.TryGetValue(key, out string _))
            {
                MessageBox.Show("Эта ключ-фраза уже задана");
                return;
            }

            CompanyProfile.Data.SpecialWords.Add(key, answer);

            textBox.Text = null;
            textBox2.Text = null;

            CmbBoxWords.ItemsSource = CompanyProfile.Data.SpecialWords.Keys.ToList();
        }

        private void BtnClickDelete(object sender, RoutedEventArgs e)
        {
            var selected = (string)CmbBoxWords.SelectedValue;
            CompanyProfile.Data.SpecialWords.Remove(selected);

            CmbBoxWords.ItemsSource = CompanyProfile.Data.SpecialWords.Keys.ToList();
        }

        private void BtnClickChange(object sender, RoutedEventArgs e)
        {
            var textBox = (TextBox)TxbSelectedKeyPhrase.Template.FindName("TB", TxbSelectedKeyPhrase);
            var key = textBox.Text;

            textBox = (TextBox)TxbSelectedAnswer.Template.FindName("TB", TxbSelectedAnswer);
            var answer = textBox.Text;

            if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(answer))
            {
                MessageBox.Show("Одно из полей не заполнено");
                return;
            }

            var selected = (string)CmbBoxWords.SelectedValue;
            CompanyProfile.Data.SpecialWords.Remove(selected);
            CompanyProfile.Data.SpecialWords.Add(key, answer);

            TxbSelectedKeyPhrase.Text = null;
            TxbSelectedAnswer.Text = null;

            CmbBoxWords.SelectedIndex = -1;
            CmbBoxWords.ItemsSource = CompanyProfile.Data.SpecialWords.Keys.ToList();
        }

        private void CmbBoxChangedWords(object sender, SelectionChangedEventArgs e)
        {
            var selected = (string)CmbBoxWords.SelectedValue;

            if (selected == null) return;
            CompanyProfile.Data.SpecialWords.TryGetValue(selected, out var text);

            TxbSelectedKeyPhrase.Text = selected;
            TxbSelectedAnswer.Text = text;
        }
    }
}
