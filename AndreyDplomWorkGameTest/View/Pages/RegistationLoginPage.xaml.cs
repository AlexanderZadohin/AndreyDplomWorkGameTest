using AndreyDplomWorkGameTest.Class;
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

namespace AndreyDplomWorkGameTest.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistationLoginPage.xaml
    /// </summary>
    public partial class RegistationLoginPage : Page
    {
        public RegistationLoginPage()
        {
            InitializeComponent();
        }


        private void PasswordPb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordPb.Password == "")
            {
                PasswordPb.Password = "0000";
            }

        }

        private void PasswordPb_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordPb.Password = "";
        }

        private void LoginTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (LoginTb.Text == "")
            {
                LoginTb.Text = "ExampleLogin";
            }
        }

        private void LoginTb_GotFocus(object sender, RoutedEventArgs e)
        {
            LoginTb.Text = string.Empty;
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.Navigate(new View.Pages.EnterLoginPage());
        }
    }
}
