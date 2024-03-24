using AndreyDplomWorkGameTest.Class;
using AndreyDplomWorkGameTest.Model;
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
using System.Windows.Shapes;

namespace AndreyDplomWorkGameTest.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainScreenApp.xaml
    /// </summary>
    public partial class MainScreenApp : Window
    {
        public UserApp currentUser;
        public MainScreenApp()
        {
            InitializeComponent();

            ClassFrame.FrameMenu = BodyFrm;
            BodyFrm.Navigate(new View.Pages.GameBibliaryPage());

            GameBibliaryBtn.Foreground = (SolidColorBrush)FindResource("ActiveEllement");
        }

        public MainScreenApp(UserApp user)
        {
            InitializeComponent();

            currentUser = user;
            ClassFrame.FrameMenu = BodyFrm;
            BodyFrm.Navigate(new View.Pages.GameBibliaryPage());

            GameBibliaryBtn.Foreground = (SolidColorBrush)FindResource("ActiveEllement");
        }


        private void GameBibliaryBtn_Click(object sender, RoutedEventArgs e)
        {
            BodyFrm.Navigate(new View.Pages.GameBibliaryPage());
            GameBibliaryBtn.Foreground = (SolidColorBrush)FindResource("ActiveEllement");
            ChatBtn.Foreground = Brushes.White;
            ProfileBtn.Foreground = Brushes.White;
            TestsGameBtn.Foreground = Brushes.White;
        }

        private void TestsGameBtn_Click(object sender, RoutedEventArgs e)
        {

            BodyFrm.Navigate(new View.Pages.TestCommentListPage());
            TestsGameBtn.Foreground = (SolidColorBrush)FindResource("ActiveEllement");
            ChatBtn.Foreground = Brushes.White;
            ProfileBtn.Foreground = Brushes.White;
            GameBibliaryBtn.Foreground = Brushes.White;
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {

            BodyFrm.Navigate(new View.Pages.ProfilePage(currentUser));
            ProfileBtn.Foreground = (SolidColorBrush)FindResource("ActiveEllement");
            ChatBtn.Foreground = Brushes.White;
            GameBibliaryBtn.Foreground = Brushes.White;
            TestsGameBtn.Foreground = Brushes.White;
        }

        private void ChatBtn_Click(object sender, RoutedEventArgs e)
        {

            BodyFrm.Navigate(new View.Pages.ChatPage());
            ChatBtn.Foreground = (SolidColorBrush)FindResource("ActiveEllement");
            GameBibliaryBtn.Foreground = Brushes.White;
            ProfileBtn.Foreground = Brushes.White;
            TestsGameBtn.Foreground = Brushes.White;
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            //BodyFrm.Navigate(new View.Pages.GameBibliaryPage());
            GameBibliaryBtn.Foreground = (SolidColorBrush)FindResource("ActiveEllement");
        }
    }
}
