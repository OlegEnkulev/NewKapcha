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

namespace NewKapcha.Pages
{
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void ExitBTN_Click(object sender, RoutedEventArgs e)
        {
            Core.mainWindow.MainFrame.Navigate(new Pages.LoginPage());
        }
    }
}
