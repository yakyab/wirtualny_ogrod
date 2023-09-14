using System;
using System.Windows;
using System.Windows.Media.Imaging;
using MahApps.Metro.Controls;
using WirtualnyOgrod.ViewModels;

namespace WirtualnyOgrod
{
    public partial class MainWindow : MetroWindow
    {
        /// <summary>
        /// Główne okno aplikacji.
        /// </summary>
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

        /// <summary>
        /// Obsługuje kliknięcie przycisku wyciszenia.
        /// </summary>
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

        /// <summary>
        /// Obsługuje kliknięcie przycisku "Moje Rośliny".
        /// </summary>
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

        /// <summary>
        /// Obsługuje kliknięcie przycisku "Plan Nawadniania".
        /// </summary>
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

        /// <summary>
        /// Obsługuje kliknięcie przycisku "Biblioteka Roślin".
        /// </summary>
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

        /// <summary>
        /// Obsługuje kliknięcie przycisku "Pomoc".
        /// </summary>
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

        /// <summary>
        /// Ukrywa wszystkie panele.
        /// </summary>
        private void HideAllPanels()
        {
            MyPlantsListView.Visibility = Visibility.Collapsed;
            PlantLibraryListView.Visibility = Visibility.Collapsed;
            WateringScheduleListView.Visibility = Visibility.Collapsed;
            HelpPanel.Visibility = Visibility.Collapsed;
        }

    }
}


