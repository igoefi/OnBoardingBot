using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using TelegramBot.Classes;
using TelegramBot.Classes.Helper;
using TelegramBot.Classes.JSON;

namespace TelegramBot.Pages.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для PageCreateDirection.xaml
    /// </summary>
    public partial class PageCreateDirection : Page
    {
        public PageCreateDirection()
        {
            InitializeComponent();
        }
        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.GoBack();
        }
        private void BtnClickSave(object sender, RoutedEventArgs e)
        {
            var textBox = (TextBox)TxbSpeciality.Template.FindName("TB", TxbSpeciality);
            var spec = textBox.Text;

            if (string.IsNullOrWhiteSpace(spec))
            {
                MessageBox.Show("Пустое поле названия направления");
                return;
            }

            CompanyProfile.Data.EducationParts.Add(spec, new List<Part>());
            CompanyProfile.Data.Eployees.Add(spec, new List<Employee>());

            FrameNav.FrameNavigation.GoBack();
        }
    }
}
