using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TelegramBot.Classes;
using TelegramBot.Classes.Helper;
using TelegramBot.Classes.JSON;

namespace TelegramBot.Pages.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для PageUserInfo.xaml
    /// </summary>
    public partial class PageUserInfo : Page
    {
        public PageUserInfo()
        {
            InitializeComponent();
            var users = CompanyProfile.Data.Users;

            var list = new List<string>();
            foreach (var user in users)
            {
                list.Add(user.FirstName + " " + user.LastName);
            }
            CmbBoxSpeciality.ItemsSource = list;
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.GoBack();
        }

        private void SElectChs(object sender, SelectionChangedEventArgs e)
        {
            var name = (string)CmbBoxSpeciality.SelectedItem;
            var users = CompanyProfile.Data.Users;

            User needUser = null;
            foreach (var user in users)
            {
                if (user.FirstName + " " + user.LastName == name)
                {
                    needUser = user;
                    break;
                }
            }
            RnC.Text = needUser.SocialCredits.ToString();
            RnChapt.Text = needUser.SelectedChapter.ToString();
            RnSpec.Text = needUser.Speciality;
        }
    }
}
