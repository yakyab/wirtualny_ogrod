using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WirtualnyOgrod.Models;

namespace WirtualnyOgrod.ViewModels
{
    /// <summary>
    /// Model widoku reprezentujący bibliotekę dostępnych roślin.
    /// </summary>
    public class PlantLibraryViewModel : BaseViewModel
    {
        private static PlantLibraryViewModel _instance;
        /// <summary>
        /// Singleton instancji PlantLibraryViewModel.
        /// </summary>
        public static PlantLibraryViewModel Instance => _instance ??= new PlantLibraryViewModel();

        private ObservableCollection<Plant> _availablePlants = new ObservableCollection<Plant>();

        /// <summary>
        /// Kolekcja dostępnych roślin.
        /// </summary>
        public ObservableCollection<Plant> AvailablePlants
        {
            get { return _availablePlants; }
            set
            {
                _availablePlants = value;
                OnPropertyChanged(nameof(AvailablePlants));
            }
        }

        /// <summary>
        /// Polecenie do dodawania rośliny do moich roślin.
        /// </summary>
        public ICommand AddPlantToMyPlantsCommand { get; set; }

        private PlantLibraryViewModel()
        {
            AddPlantToMyPlantsCommand = new RelayCommand<Plant>(AddPlantToMyPlants);

            InitializeAvailablePlants();
        }

        /// <summary>
        /// Inicjalizuje listę dostępnych roślin.
        /// </summary>
        private void InitializeAvailablePlants()
        {
            AvailablePlants.Add(new Plant { Id = 1, Name = "Róża", Description = "Kwiaty w różnych kolorach.", WateringTimer = 36, OriginalWateringTime = 36 });
            AvailablePlants.Add(new Plant { Id = 2, Name = "Tulipan", Description = "Kwiaty wiosenne.", WateringTimer = 30, OriginalWateringTime = 30 });
            AvailablePlants.Add(new Plant { Id = 3, Name = "Storczyk", Description = "Egzotyczny kwiat doniczkowy.", WateringTimer = 48, OriginalWateringTime = 48 });
            AvailablePlants.Add(new Plant { Id = 4, Name = "Kaktus", Description = "Roślina pustynna.", WateringTimer = 72, OriginalWateringTime = 72 });
            AvailablePlants.Add(new Plant { Id = 5, Name = "Fikus", Description = "Popularna roślina doniczkowa.", WateringTimer = 45, OriginalWateringTime = 45 });
            AvailablePlants.Add(new Plant { Id = 6, Name = "Bonsai", Description = "Małe drzewko w doniczce.", WateringTimer = 39, OriginalWateringTime = 39 });
            AvailablePlants.Add(new Plant { Id = 7, Name = "Lilia", Description = "Kwiaty o intensywnym zapachu.", WateringTimer = 33, OriginalWateringTime = 33 });
            AvailablePlants.Add(new Plant { Id = 8, Name = "Mięta", Description = "Roślina ziołowa.", WateringTimer = 28, OriginalWateringTime = 28 });
            AvailablePlants.Add(new Plant { Id = 9, Name = "Bazylia", Description = "Roślina kulinarna.", WateringTimer = 27, OriginalWateringTime = 27 });
            AvailablePlants.Add(new Plant { Id = 10, Name = "Lawenda", Description = "Kwiaty o relaksującym zapachu.", WateringTimer = 40, OriginalWateringTime = 40 });
            AvailablePlants.Add(new Plant { Id = 11, Name = "Aloes", Description = "Roślina lecznicza.", WateringTimer = 50, OriginalWateringTime = 50 });
            AvailablePlants.Add(new Plant { Id = 12, Name = "Eukaliptus", Description = "Drzewo o charakterystycznych liściach.", WateringTimer = 42, OriginalWateringTime = 42 });
            AvailablePlants.Add(new Plant { Id = 13, Name = "Gerbera", Description = "Kolorowe kwiaty doniczkowe.", WateringTimer = 31, OriginalWateringTime = 31 });
            AvailablePlants.Add(new Plant { Id = 14, Name = "Hortensja", Description = "Duże kwiatostany.", WateringTimer = 37, OriginalWateringTime = 37 });
            AvailablePlants.Add(new Plant { Id = 15, Name = "Jasnota", Description = "Kwiaty o bieliźnianej barwie.", WateringTimer = 35, OriginalWateringTime = 35 });
            AvailablePlants.Add(new Plant { Id = 16, Name = "Kamelia", Description = "Kwiaty przypominające róże.", WateringTimer = 38, OriginalWateringTime = 38 });
            AvailablePlants.Add(new Plant { Id = 17, Name = "Lewkonija", Description = "Kwiaty w kształcie dzwonków.", WateringTimer = 32, OriginalWateringTime = 32 });
            AvailablePlants.Add(new Plant { Id = 18, Name = "Magnolia", Description = "Drzewo o dużych kwiatach.", WateringTimer = 41, OriginalWateringTime = 41 });
            AvailablePlants.Add(new Plant { Id = 19, Name = "Narcyz", Description = "Wiosenne kwiaty cebulowe.", WateringTimer = 29, OriginalWateringTime = 29 });
            AvailablePlants.Add(new Plant { Id = 20, Name = "Orchidea", Description = "Egzotyczny kwiat doniczkowy.", WateringTimer = 46, OriginalWateringTime = 46 });
        }

        /// <summary>
        /// Dodaje wybraną roślinę do moich roślin i usuwa ją z dostępnych roślin.
        /// </summary>
        private void AddPlantToMyPlants(Plant plant)
        {
            if (plant != null)
            {
                AvailablePlants.Remove(plant);
                MainViewModel.Instance.MyPlantsViewModel.MyPlants.Add(plant);
            }
        }

    }
}



