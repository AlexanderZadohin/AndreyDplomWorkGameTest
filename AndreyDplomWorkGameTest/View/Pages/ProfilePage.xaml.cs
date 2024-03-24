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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AndreyDplomWorkGameTest.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage(UserApp user)
        {
            InitializeComponent();

            BibliaryGameLb.ItemsSource = App.context.UserGameBibliary.ToList();
            
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(user.PhotoProfile);
            bitmap.EndInit();

            ProfilePhoto.Source = bitmap;

            LoginTbl.Text = $"Логин: {user.Login}";
            DescriptionTbl.Text = $"Статус: {user.Description}";
        }
    }
}
