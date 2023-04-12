using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TelegramBot.Classes;
using TelegramBot.Classes.Helper;

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
    }
}
