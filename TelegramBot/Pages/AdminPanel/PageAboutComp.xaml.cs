﻿using System;
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

namespace TelegramBot.Pages.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для PageAboutComp.xaml
    /// </summary>
    public partial class PageAboutComp : Page
    {
        public PageAboutComp()
        {
            InitializeComponent();
        }
        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.GoBack();
        }
        private void BtnClickSaveAboutComp(object sender, RoutedEventArgs e)
        {
            FrameNav.FrameNavigation.GoBack();
        }
    }
}