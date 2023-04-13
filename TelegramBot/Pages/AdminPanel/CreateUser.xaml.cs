using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TelegramBot.Classes;
using TelegramBot.Classes.Helper;
using TelegramBot.Classes.JSON;

namespace TelegramBot.Pages.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для CreateUser.xaml
    /// </summary>
    public partial class CreateUser : Page
    {
        public CreateUser()
        {
            InitializeComponent();
            var rand = new Random();
            TxbCode.Text = rand.Next(10000000).ToString();

            var speciality = CompanyProfile.Data.EducationParts.Keys.ToList();
            if (speciality.Count == 0)
            {
                MessageBox.Show("У вас нет специальностей, чтобы создавать пользователей");
                return;
            }

            CmbBoxSpeciality.ItemsSource = speciality;
            CmbBoxSpeciality.SelectedIndex = 0;
        }

        private void BtnClickBack(object sender, RoutedEventArgs e) =>
            FrameNav.FrameNavigation.GoBack();

        private void BtnClickCreate(object sender, RoutedEventArgs e)
        {
            var textBox = (TextBox)TxbName.Template.FindName("TB", TxbName);
            var name = textBox.Text;

            textBox = (TextBox)TxbSurname.Template.FindName("TB", TxbSurname);
            var surname = textBox.Text;

            textBox = (TextBox)TxbCode.Template.FindName("TB", TxbCode);
            var code = textBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Одно или несколько полей не заполнено");
                return;
            }

            var speciality = (string)CmbBoxSpeciality.SelectedItem;

            CompanyProfile.Data.Users.Add(new User(name, surname, code, speciality));

            FrameNav.FrameNavigation.GoBack();
        }
    }
}
