using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using WirtualnyOgrod.Models;

namespace WirtualnyOgrod.ViewModels
{
    public class PlantLibraryViewModel : BaseViewModel
    {
        private ObservableCollection<Plant> _availablePlants = new ObservableCollection<Plant>();
        private ObservableCollection<Plant> _originalPlantsList = new ObservableCollection<Plant>(); // Lista do przechowywania oryginalnych roślin

        public ObservableCollection<Plant> AvailablePlants
        {
            get { return _availablePlants; }
            set { _availablePlants = value; OnPropertyChanged(nameof(AvailablePlants)); }
        }

        public ICommand AddPlantCommand { get; set; }
        public ICommand RemoveFromLibraryCommand { get; set; }

        public PlantLibraryViewModel()
        {
            AddPlantCommand = new RelayCommand<Plant>(AddPlant);
            RemoveFromLibraryCommand = new RelayCommand<Plant>(RemoveFromLibrary);

            // Dodajemy przykładowe rośliny
            var rose = new Plant { Id = 1, Name = "Róża", Description = "Piękny kwiat ogrodowy", ImagePath = "pack://application:,,,/Resources/flower.png", GrowthRate = 1.2, WaterNeeds = 2.5 };
            var tulip = new Plant { Id = 2, Name = "Tulipan", Description = "Popularny kwiat wiosenny", ImagePath = "pack://application:,,,/Resources/flower.png", GrowthRate = 1.1, WaterNeeds = 2.0 };
            var orchid = new Plant { Id = 3, Name = "Storczyk", Description = "Kwiat doniczkowy", ImagePath = "pack://application:,,,/Resources/flower.png", GrowthRate = 0.8, WaterNeeds = 1.5 };

            AvailablePlants.Add(rose);
            AvailablePlants.Add(tulip);
            AvailablePlants.Add(orchid);

            _originalPlantsList.Add(rose);
            _originalPlantsList.Add(tulip);
            _originalPlantsList.Add(orchid);
        }

        private void AddPlant(Plant plantToAdd)
        {
            if (plantToAdd != null)
            {
                MyPlantsViewModel.Instance.MyPlants.Add(plantToAdd);
            }
        }

        private void RemoveFromLibrary(Plant plantToRemove)
        {
            if (plantToRemove != null)
            {
                AvailablePlants.Remove(plantToRemove);
                _originalPlantsList.Remove(plantToRemove);
            }
        }

        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                FilterPlants();
                OnPropertyChanged(nameof(SearchText));
            }
        }

        private void FilterPlants()
        {
            if (string.IsNullOrEmpty(_searchText))
            {
                AvailablePlants.Clear();
                foreach (var plant in _originalPlantsList)
                {
                    AvailablePlants.Add(plant);
                }
            }
            else
            {
                var filteredPlants = _originalPlantsList.Where(p => p.Name.Contains(_searchText)).ToList();
                AvailablePlants.Clear();
                foreach (var plant in filteredPlants)
                {
                    AvailablePlants.Add(plant);
                }
            }
        }
    }
}


