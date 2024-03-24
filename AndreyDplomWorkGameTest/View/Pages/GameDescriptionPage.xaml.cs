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
    /// Логика взаимодействия для GameDescriptionPage.xaml
    /// </summary>
    public partial class GameDescriptionPage : Page
    {
        public IndiGameCatalog indi;
        public GameDescriptionPage(IndiGameCatalog indiGame)
        {
            InitializeComponent();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(indiGame.CoverGame);
            bitmap.EndInit();

            CoverGameImg.ImageSource = bitmap;

            DescriptionTbl.Text = indiGame.Description;

            indi = indiGame;
        }

        private void DownloadBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(indi.LinkDownload);
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(indi.LinkLaunch);
        }

        private void TestGame_Click(object sender, RoutedEventArgs e)
        {
            //System.Diagnostics.Process.Start(indi.LinkDownload);
        }
    }
}
