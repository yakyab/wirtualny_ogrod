using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WirtualnyOgrod.Models;

namespace WirtualnyOgrod.ViewModels
{
    public class PlantLibraryViewModel : BaseViewModel
    {
        private ObservableCollection<Plant> _availablePlants = new ObservableCollection<Plant>();

        public ObservableCollection<Plant> AvailablePlants
        {
            get { return _availablePlants; }
            set
            {
                _availablePlants = value;
                OnPropertyChanged(nameof(AvailablePlants));
            }
        }

        public ICommand AddPlantToMyPlantsCommand { get; set; }
        public ICommand RemoveFromLibraryCommand { get; set; }

        public PlantLibraryViewModel()
        {
            AddPlantToMyPlantsCommand = new RelayCommand<Plant>(AddPlantToMyPlants);
            RemoveFromLibraryCommand = new RelayCommand<Plant>(RemoveFromLibrary);

            InitializeAvailablePlants();
        }

        private void InitializeAvailablePlants()
        {
            AvailablePlants.Add(new Plant { Id = 1, Name = "Róża", Description = "Kwiaty w różnych kolorach.", WateringTimer = 360 });
            AvailablePlants.Add(new Plant { Id = 2, Name = "Tulipan", Description = "Kwiaty wiosenne.", WateringTimer = 300 });
            AvailablePlants.Add(new Plant { Id = 3, Name = "Storczyk", Description = "Egzotyczny kwiat doniczkowy.", WateringTimer = 480 });
            AvailablePlants.Add(new Plant { Id = 4, Name = "Kaktus", Description = "Roślina pustynna.", WateringTimer = 720 });
            AvailablePlants.Add(new Plant { Id = 5, Name = "Fikus", Description = "Popularna roślina doniczkowa.", WateringTimer = 450 });
            AvailablePlants.Add(new Plant { Id = 6, Name = "Bonsai", Description = "Małe drzewko w doniczce.", WateringTimer = 390 });
            AvailablePlants.Add(new Plant { Id = 7, Name = "Lilia", Description = "Kwiaty o intensywnym zapachu.", WateringTimer = 330 });
            AvailablePlants.Add(new Plant { Id = 8, Name = "Mięta", Description = "Roślina ziołowa.", WateringTimer = 280 });
            AvailablePlants.Add(new Plant { Id = 9, Name = "Bazylia", Description = "Roślina kulinarna.", WateringTimer = 270 });
            AvailablePlants.Add(new Plant { Id = 10, Name = "Lawenda", Description = "Kwiaty o relaksującym zapachu.", WateringTimer = 400 });
            AvailablePlants.Add(new Plant { Id = 11, Name = "Aloes", Description = "Roślina lecznicza.", WateringTimer = 500 });
            AvailablePlants.Add(new Plant { Id = 12, Name = "Eukaliptus", Description = "Drzewo o charakterystycznych liściach.", WateringTimer = 420 });
            AvailablePlants.Add(new Plant { Id = 13, Name = "Gerbera", Description = "Kolorowe kwiaty doniczkowe.", WateringTimer = 310 });
            AvailablePlants.Add(new Plant { Id = 14, Name = "Hortensja", Description = "Duże kwiatostany.", WateringTimer = 370 });
            AvailablePlants.Add(new Plant { Id = 15, Name = "Jasnota", Description = "Kwiaty o bieliźnianej barwie.", WateringTimer = 350 });
            AvailablePlants.Add(new Plant { Id = 16, Name = "Kamelia", Description = "Kwiaty przypominające róże.", WateringTimer = 380 });
            AvailablePlants.Add(new Plant { Id = 17, Name = "Lewkonija", Description = "Kwiaty w kształcie dzwonków.", WateringTimer = 320 });
            AvailablePlants.Add(new Plant { Id = 18, Name = "Magnolia", Description = "Drzewo o dużych kwiatach.", WateringTimer = 410 });
            AvailablePlants.Add(new Plant { Id = 19, Name = "Narcyz", Description = "Wiosenne kwiaty cebulowe.", WateringTimer = 290 });
            AvailablePlants.Add(new Plant { Id = 20, Name = "Orchidea", Description = "Egzotyczny kwiat doniczkowy.", WateringTimer = 460 });
        }

        private void AddPlantToMyPlants(Plant plant)
        {
            if (plant != null)
            {
                AvailablePlants.Remove(plant);
                MainViewModel.Instance.MyPlantsViewModel.MyPlants.Add(plant);
            }
        }

        private void RemoveFromLibrary(Plant plant)
        {
            if (plant != null && !AvailablePlants.Contains(plant))
            {
                AvailablePlants.Add(plant);
            }
        }
    }
}



