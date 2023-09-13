using System.Windows;
using MahApps.Metro.Controls;

namespace WirtualnyOgrod
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnMyPlantsClick(object sender, RoutedEventArgs e)
        {
            MyPlantsListView.Visibility = Visibility.Visible;
            PlantLibraryListView.Visibility = Visibility.Collapsed;
            SettingsPanel.Visibility = Visibility.Collapsed;
            // Dodajemy obsługę dla innych kontrolek, gdy zostaną dodane
        }

        private void OnWateringPlanClick(object sender, RoutedEventArgs e)
        {
            MyPlantsListView.Visibility = Visibility.Collapsed;
            PlantLibraryListView.Visibility = Visibility.Collapsed;
            SettingsPanel.Visibility = Visibility.Collapsed;
            // Dodajemy obsługę dla kontrolek związanych z Planem nawodnienia, gdy zostaną dodane
        }

        private void OnPlantLibraryClick(object sender, RoutedEventArgs e)
        {
            MyPlantsListView.Visibility = Visibility.Collapsed;
            PlantLibraryListView.Visibility = Visibility.Visible;
            SettingsPanel.Visibility = Visibility.Collapsed;
            // Dodajemy obsługę dla innych kontrolek, gdy zostaną dodane
        }

        private void OnSettingsClick(object sender, RoutedEventArgs e)
        {
            MyPlantsListView.Visibility = Visibility.Collapsed;
            PlantLibraryListView.Visibility = Visibility.Collapsed;
            SettingsPanel.Visibility = Visibility.Visible;
            // Dodajemy obsługę dla innych kontrolek, gdy zostaną dodane
        }

        private void OnHelpClick(object sender, RoutedEventArgs e)
        {
            MyPlantsListView.Visibility = Visibility.Collapsed;
            PlantLibraryListView.Visibility = Visibility.Collapsed;
            SettingsPanel.Visibility = Visibility.Collapsed;
            // Dodajemy obsługę dla kontrolek związanych z Pomocą, gdy zostaną dodane
        }
        private void SearchBar_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchBarWatermark.Opacity = 0;
        }

        private void SearchBar_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBar.Text))
            {
                SearchBarWatermark.Opacity = 1;
            }
        }

    }
}


