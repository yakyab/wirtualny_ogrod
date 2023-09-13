using System.Windows;
using System.Windows.Media;
using MahApps.Metro.Controls;
using WirtualnyOgrod.ViewModels;

namespace WirtualnyOgrod
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            MyPlantsListView.DataContext = MyPlantsViewModel.Instance;
            PlantLibraryListView.DataContext = new PlantLibraryViewModel();
            WateringPlanPanel.DataContext = new WateringScheduleViewModel();
            SettingsPanel.DataContext = new SettingsViewModel();
            HelpPanel.DataContext = new HelpViewModel();
        }

        private void OnMyPlantsClick(object sender, RoutedEventArgs e)
        {
            HideAllPanels();
            MyPlantsListView.Visibility = Visibility.Visible;
        }

        private void OnWateringPlanClick(object sender, RoutedEventArgs e)
        {
            HideAllPanels();
            WateringPlanPanel.Visibility = Visibility.Visible;
        }

        private void OnPlantLibraryClick(object sender, RoutedEventArgs e)
        {
            HideAllPanels();
            PlantLibraryListView.Visibility = Visibility.Visible;
        }

        private void OnSettingsClick(object sender, RoutedEventArgs e)
        {
            HideAllPanels();
            SettingsPanel.Visibility = Visibility.Visible;
        }

        private void OnHelpClick(object sender, RoutedEventArgs e)
        {
            HideAllPanels();
            HelpPanel.Visibility = Visibility.Visible;
        }

        private void HideAllPanels()
        {
            MyPlantsListView.Visibility = Visibility.Collapsed;
            PlantLibraryListView.Visibility = Visibility.Collapsed;
            SettingsPanel.Visibility = Visibility.Collapsed;
            WateringPlanPanel.Visibility = Visibility.Collapsed;
            HelpPanel.Visibility = Visibility.Collapsed;
        }

    }
}


