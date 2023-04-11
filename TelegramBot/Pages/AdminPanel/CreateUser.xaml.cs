using System;
using System.Windows;
using System.Windows.Controls;
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
        }

        private void BtnClickBack(object sender, RoutedEventArgs e) =>
            FrameNav.FrameNavigation.GoBack();
    }
}
