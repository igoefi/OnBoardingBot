using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using TelegramBot.Classes;
using TelegramBot.Classes.Helper;
using TelegramBot.Classes.JSON;
using static System.Net.Mime.MediaTypeNames;

namespace TelegramBot.Pages.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для PageChangeTest.xaml
    /// </summary>
    public partial class PageChangeTest : Page
    {
        private Part _selectedPart;
        public PageChangeTest()
        {
            InitializeComponent();

            var speciality = CompanyProfile.Data.EducationParts.Keys.ToList();
            if (speciality.Count == 0)
            {
                MessageBox.Show("У вас нет специальностей, чтобы редактировать тесты");
                return;
            }

            CmbBoxSpeciality.ItemsSource = speciality;
            CmbBoxSpeciality.SelectedIndex = 0;

            SetCmbBoxTestValues();

        }
        private void BtnClickGoBack(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.GoBack();
        }
        private void BtnClickSave(object sender, RoutedEventArgs e)
        {

            var textBox = (TextBox)TxbName.Template.FindName("TB", TxbName);
            var name = textBox.Text;

            textBox = (TextBox)TxbTheory.Template.FindName("TB", TxbTheory);
            var theory = textBox.Text;

            textBox = (TextBox)TxbBalls.Template.FindName("TB", TxbBalls);
            var cost = textBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(theory) || string.IsNullOrWhiteSpace(cost))
            {
                MessageBox.Show("Одно из полей не заполнено");
                return;
            }

            if (!int.TryParse(cost, out int needCost))
            {
                MessageBox.Show("Введите корректное значение в стоимость");
                return;
            }

            _selectedPart.Name = name;
            _selectedPart.Theory = theory;
            _selectedPart.Victorine.QuestionCost = needCost;

            FrameNav.FrameNavigation.GoBack();
        }

        private void SetCmbBoxTestValues()
        {
            var spec = (string)CmbBoxSpeciality.SelectedItem;

            var tests = CompanyProfile.Data.EducationParts[spec];
            var list = new List<string>();

            foreach ( var test in tests )
                list.Add(test.Name);

            CmbBoxTest.ItemsSource = list;
        }

        private void CmbBoxSpecialitySelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var spec = (string)CmbBoxSpeciality.SelectedItem;

            var parts = CompanyProfile.Data.EducationParts[spec];

            var list = new List<string>();
            foreach(var part in parts)
                list.Add(part.Name);
            
            CmbBoxTest.ItemsSource = list;
        }

        private void BtnClickDelete(object sender, RoutedEventArgs e)
        {
            var spec = (string)CmbBoxSpeciality.SelectedItem;
            CompanyProfile.Data.EducationParts[spec].Remove(_selectedPart);
            CmbBoxSpecialitySelectionChanged(null, null);
        }

        private void BtnClickSaveQuestion(object sender, RoutedEventArgs e)
        {
            var quest = (string)CmbBoxQuestions.SelectedItem;
            if (quest == null) return;

            var list = new List<TextBox>();

            var textBox = (TextBox)TxbAnswere.Template.FindName("TB", TxbAnswere);
            var answer = textBox.Text;
            list.Add(textBox);

            textBox = (TextBox)TxbQuestion.Template.FindName("TB", TxbQuestion);
            var question = textBox.Text;
            list.Add(textBox);

            if(string.IsNullOrWhiteSpace(answer) || string.IsNullOrWhiteSpace(question))
            {
                MessageBox.Show("Одно из полей неверно");
                return;
            }

            foreach (var box in list)
                box.Text = null;
            _selectedPart.Victorine.QuestionsAnswers.Remove(quest);
            _selectedPart.Victorine.QuestionsAnswers.Add(question, answer);
        }

        private void CmbBoxTestSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var spec = (string)CmbBoxSpeciality.SelectedItem;
            var tests = CompanyProfile.Data.EducationParts[spec];
            var name = (string)CmbBoxTest.SelectedItem;

            _selectedPart = null;
            foreach (var test in tests)
                if (test.Name == name)
                    _selectedPart = test;
            if (_selectedPart == null) return;

            CmbBoxQuestions.ItemsSource = _selectedPart.Victorine.QuestionsAnswers.Keys;

            TxbBalls.Text = _selectedPart.Victorine.QuestionCost.ToString();
            TxbName.Text = _selectedPart.Name;
            TxbTheory.Text = _selectedPart.Theory;
        }
    }
}
