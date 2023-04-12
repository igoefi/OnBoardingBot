using System.IO;
using System.Windows;
using System.Windows.Input;
using TelegramBot.Classes;
using TelegramBot.Classes.Helper;
using TelegramBot.Pages;
using TelegramBot.Pages.AdminPanel;

namespace TelegramBot
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            FrameNav.FrameNavigation = FrmMain;

            var filePath = PathFile.PathFileStr;

            if (!File.Exists(filePath))
            {
                FrmMain.Navigate(new StartPanel());
                return;
            }

            var data = JSONSerializeController.DeserializeObject<CompanyData>(filePath);
            if (data == null)
            {
                FrmMain.Navigate(new StartPanel());
                return;
            }

            CompanyProfile.ReadData(data);
            FrmMain.Navigate(new PageMainAdminPanel());
        }

        private void BtnClickExit(object sender, RoutedEventArgs e) =>
            Application.Current.Shutdown();

        private void BtnClickHide(object sender, RoutedEventArgs e) =>
            Application.Current.MainWindow.WindowState = WindowState.Minimized;

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e) =>
            DragMove();

        private void BtnClickFullOpen(object sender, RoutedEventArgs e) =>
            Application.Current.MainWindow.WindowState = Application.Current.MainWindow.WindowState == WindowState.Normal
            ? WindowState.Maximized : WindowState.Normal;
    }
}
