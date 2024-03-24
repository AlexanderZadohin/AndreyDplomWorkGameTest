using AndreyDplomWorkGameTest.Class;
using AndreyDplomWorkGameTest.Model;
using AndreyDplomWorkGameTest.View.Windows;
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
    /// Логика взаимодействия для EnterLoginPage.xaml
    /// </summary>
    public partial class EnterLoginPage : Page
    {
        public EnterLoginPage()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (LoginTb.Text == "Login")
                mes += "Введите Email\n";
            if (PasswordPb.Password == "0000")
                mes += "Введите пароль\n";
            if (!string.IsNullOrEmpty(mes))
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            else
            {
                UserApp userApp = App.context.UserApp.FirstOrDefault(u =>
                    u.Password == PasswordPb.Password && u.Login == LoginTb.Text);
                if (userApp != null)
                {
                    MainScreenApp mainScreenWindow = new MainScreenApp(userApp);
                    mainScreenWindow.Show();

                    Window mainWindow = Window.GetWindow(this);
                    mainWindow.Close();
                }
                else
                {
                    MessageBox.Show("Данные для входа неверны");
                }
            }
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
            ClassFrame.FrameMenu.Navigate(new View.Pages.RegistationLoginPage());
        }
    }
}
