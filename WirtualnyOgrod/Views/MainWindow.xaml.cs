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
            PlantsListView.Visibility = Visibility.Visible;
            SettingsPanel.Visibility = Visibility.Collapsed;
        }

        private void OnWateringPlanClick(object sender, RoutedEventArgs e)
        {
            PlantsListView.Visibility = Visibility.Collapsed;
            SettingsPanel.Visibility = Visibility.Collapsed;
        }

        private void OnPlantLibraryClick(object sender, RoutedEventArgs e)
        {
            PlantsListView.Visibility = Visibility.Collapsed;
            SettingsPanel.Visibility = Visibility.Collapsed;
        }

        private void OnSettingsClick(object sender, RoutedEventArgs e)
        {
            PlantsListView.Visibility = Visibility.Collapsed;
            SettingsPanel.Visibility = Visibility.Visible;
        }
    }
}

