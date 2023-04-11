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
using TelegramBot.Classes.Helper;
using TelegramBot.Pages.AdminPanel;

namespace TelegramBot.Pages
{
    /// <summary>
    /// Логика взаимодействия для StartPanel.xaml
    /// </summary>
    public partial class StartPanel : Page
    {
        public StartPanel()
        {
            InitializeComponent();
        }

        private void BtnClickNextPage(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.Navigate(new PageMainAdminPanel());
        }
    }
}
