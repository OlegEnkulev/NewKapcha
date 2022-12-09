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

namespace NewKapcha.Pages
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginBTN_Click(object sender, RoutedEventArgs e)
        {
            if(LoginBox.Text.Count() <= 3 && PasswordBox.Password.Count() <= 3)
            {
                MessageBox.Show("Проверьте данные");
                return;
            }

            if (LoginBox.Text == "User" && PasswordBox.Password == "User")
            {
                Core.mainWindow.MainFrame.Navigate(new Pages.CapchaPage());
            }
            else
            {
                MessageBox.Show("Проверьте данные");
                return;
            }
        }
    }
}
