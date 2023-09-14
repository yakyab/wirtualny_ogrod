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
            this.DataContext = new MainViewModel();
            MyPlantsListView.DataContext = MyPlantsViewModel.Instance;
            PlantLibraryListView.DataContext = PlantLibraryViewModel.Instance;
            WateringScheduleListView.DataContext = MyPlantsViewModel.Instance;
            HelpPanel.DataContext = new HelpViewModel();
            HelpPanel.Visibility = Visibility.Visible;
        }

        private void OnMyPlantsClick(object sender, RoutedEventArgs e)
        {
            HideAllPanels();
            MyPlantsListView.Visibility = Visibility.Visible;
        }

        private void OnWateringPlanClick(object sender, RoutedEventArgs e)
        {
            HideAllPanels();
            WateringScheduleListView.Visibility = Visibility.Visible;
        }

        private void OnPlantLibraryClick(object sender, RoutedEventArgs e)
        {
            HideAllPanels();
            PlantLibraryListView.Visibility = Visibility.Visible;
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
            WateringScheduleListView.Visibility = Visibility.Collapsed;
            HelpPanel.Visibility = Visibility.Collapsed;
        }

    }
}


