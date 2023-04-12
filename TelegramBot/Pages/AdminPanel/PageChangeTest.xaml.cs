using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TelegramBot.Classes;
using TelegramBot.Classes.Helper;

namespace TelegramBot.Pages.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для PageChangeTest.xaml
    /// </summary>
    public partial class PageChangeTest : Page
    {
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
        }
        private void BtnClickGoBack(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.GoBack();
        }
        private void BtnClickSave(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.GoBack();
        }
    }
}
