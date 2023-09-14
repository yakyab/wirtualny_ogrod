using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
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
            HelpPanel.Visibility = Visibility.Visible;
        }
        private bool isMuted = false;

        private void OnMuteClick(object sender, RoutedEventArgs e)
        {
            isMuted = !isMuted; // Zmienia stan wyciszenia

            // Aktualizuje ikonę w zależności od stanu wyciszenia
            if (isMuted)
            {
                MuteImage.Source = new BitmapImage(new Uri("pack://application:,,,/WirtualnyOgrod;component/Views/Images/speaker muted.jpg"));
            }
            else
            {
                MuteImage.Source = new BitmapImage(new Uri("pack://application:,,,/WirtualnyOgrod;component/Views/Images/speaker.jpg"));
            }
        }

        private void OnMyPlantsClick(object sender, RoutedEventArgs e)
        {
            HideAllPanels();
            MyPlantsListView.Visibility = Visibility.Visible;
            if (!isMuted)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Application.GetResourceStream(new Uri("pack://application:,,,/WirtualnyOgrod;component/Views/Sounds/birds.wav")).Stream;
                player.Play();
            }
        }

        private void OnWateringPlanClick(object sender, RoutedEventArgs e)
        {
            HideAllPanels();
            WateringScheduleListView.Visibility = Visibility.Visible;
            if (!isMuted)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Application.GetResourceStream(new Uri("pack://application:,,,/WirtualnyOgrod;component/Views/Sounds/water.wav")).Stream;
                player.Play();
            }
        }

        private void OnPlantLibraryClick(object sender, RoutedEventArgs e)
        {
            HideAllPanels();
            PlantLibraryListView.Visibility = Visibility.Visible;
            if (!isMuted)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Application.GetResourceStream(new Uri("pack://application:,,,/WirtualnyOgrod;component/Views/Sounds/spade.wav")).Stream;
                player.Play();
            }
        }

        private void OnHelpClick(object sender, RoutedEventArgs e)
        {
            HideAllPanels();
            HelpPanel.Visibility = Visibility.Visible;
            if (!isMuted)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Application.GetResourceStream(new Uri("pack://application:,,,/WirtualnyOgrod;component/Views/Sounds/menu.wav")).Stream;
                player.Play();
            }
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


