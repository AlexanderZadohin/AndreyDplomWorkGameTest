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
    /// Логика взаимодействия для GameBibliaryPage.xaml
    /// </summary>
    public partial class GameBibliaryPage : Page
    {
        public GameBibliaryPage()
        {
            InitializeComponent();

            BibliaryGameLb.ItemsSource = App.context.IndiGameCatalog.ToList();
        }

        private void BibliaryGameLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BibliaryGameLb.SelectedItem != null)
            {
                // Получаем выбранный элемент из списка
                var selectedItem = (IndiGameCatalog)BibliaryGameLb.SelectedItem;

                // Создаем новую страницу с передачей выбранного элемента в конструктор
                GameDescriptionPage gameDescriptionPage = new GameDescriptionPage(selectedItem);

                // Переходим на новую страницу
                NavigationService.Navigate(gameDescriptionPage);
            }
        }
    }
}
