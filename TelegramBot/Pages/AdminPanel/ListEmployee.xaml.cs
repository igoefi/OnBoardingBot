using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TelegramBot.Classes;
using TelegramBot.Classes.Helper;
using TelegramBot.Classes.JSON;

namespace TelegramBot.Pages.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для ListEmployee.xaml
    /// </summary>
    public partial class ListEmployee : Page
    {
        public ListEmployee()
        {
            InitializeComponent();
            SetEmployees();
            CmbBoxSpecialization.ItemsSource = CompanyProfile.Data.Eployees.Keys.ToList();
            CmbBoxSpecialization.SelectedIndex= 0;
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.GoBack();
        }

        private void BtnClickAddEmployee(object sender, RoutedEventArgs e)
        {
            var list = new List<TextBox>();

            var textBox = (TextBox)TxbName.Template.FindName("TB", TxbName);
            var name = textBox.Text;
            list.Add(textBox);

            textBox = (TextBox)TxbAbout.Template.FindName("TB", TxbAbout);
            var about = textBox.Text;
            list.Add(textBox);

            textBox = (TextBox)TxbEmail.Template.FindName("TB", TxbEmail);
            var email = textBox.Text;
            list.Add(textBox);

            var specialization = (string)CmbBoxSpecialization.SelectedItem;
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(about) || 
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(specialization))
            {
                MessageBox.Show("Одно или несколько полей пусто");
                return;
            }
            foreach (var box in list)
                box.Text = null;

            CompanyProfile.Data.Eployees[specialization].Add(new Employee(name, about, email));
            SetEmployees();
        }

        private void BtnClickDeleteEmployee(object sender, RoutedEventArgs e)
        {
            var employeeName = (string)CmbBoxEmployee.SelectedItem;
            if (employeeName == null) return;

            CompanyProfile.DeleteEmployee(employeeName);
            SetEmployees();
        }
         
        private void SetEmployees()
        {
            var employees = CompanyProfile.Data.Eployees.Values;
            var names = new List<string>();

            foreach (var employeesList in employees)
                foreach(var employee in employeesList)
                 names.Add(employee.FullName);

            CmbBoxEmployee.ItemsSource = names;
        }
    }
}
