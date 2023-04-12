﻿using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TelegramBot.Classes;
using TelegramBot.Classes.Helper;
using TelegramBot.Classes.JSON;

namespace TelegramBot.Pages.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для PageCreateTest.xaml
    /// </summary>
    public partial class PageCreateTest : Page
    {
        private readonly Dictionary<string, string> _questionsAnswers = new Dictionary<string, string>();
        public PageCreateTest()
        {
            InitializeComponent();

            var speciality = CompanyProfile.Data.EducationParts.Keys.ToList();
            if (speciality.Count == 0)
            {
                MessageBox.Show("У вас нет специальностей, чтобы делать тесты");
                return;
            }

            CmbBoxSpeciality.ItemsSource = speciality;
            CmbBoxSpeciality.SelectedIndex = 0;
        }
        private void BtnClickGoBack(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.GoBack();
        }
        private void BtnClickSave(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxbName.Text) || string.IsNullOrWhiteSpace(TxbName.Text) || string.IsNullOrWhiteSpace(TxbTheory.Text))
            {
                MessageBox.Show("Одно из полей не заполнено");
                return;
            }

            if (!int.TryParse(TxbCost.Text, out int cost))
            {
                MessageBox.Show("Введите корректное значение в стоимость");
                return;
            }

            var part = new Part(TxbName.Text, TxbTheory.Text, new VictorineData(_questionsAnswers, cost));

            FrameNav.FrameNavigation.GoBack();
            FrameNav.FrameNavigation.GoBack();
        }

        private void BtnClickSaveQuestion(object sender, RoutedEventArgs e)
        {
            var textBox = (TextBox)TxbQuestion.Template.FindName("TB", TxbQuestion);
            var question = textBox.Text;

            textBox = (TextBox)TxbAnswer.Template.FindName("TB", TxbAnswer);
            var answer = textBox.Text;

            if (string.IsNullOrWhiteSpace(question) || string.IsNullOrWhiteSpace(answer))
            {
                MessageBox.Show("Одно из полей пустое");
                return;
            }

            _questionsAnswers.TryGetValue(question, out string value);

            if (value != null)
            {
                MessageBox.Show("Этот вопрос уже задан");
                return;
            }

            _questionsAnswers.Add(question, answer);

            TxbQuestionsAnswers.Text = ConvertQuestionsToText();

            TxbAnswer.Text = null;
            TxbQuestion.Text = null;
        }

        private string ConvertQuestionsToText()
        {
            var str = string.Empty;

            var num = 0;
            foreach (var question in _questionsAnswers.Keys)
            {
                num++;
                str += num + " вопрос - " + question + "\n";
                str += "Ответ - " + _questionsAnswers[question] + "\n";
                str += "\n";
            }

            return str;
        }
    }
}
