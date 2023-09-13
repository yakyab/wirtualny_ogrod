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
            set { _availablePlants = value; OnPropertyChanged(nameof(AvailablePlants)); }
        }

        public ICommand AddPlantCommand { get; set; }
        public ICommand RemoveFromLibraryCommand { get; set; }  // Nowe polecenie

        public PlantLibraryViewModel()
        {
            AddPlantCommand = new RelayCommand<Plant>(AddPlant);
            RemoveFromLibraryCommand = new RelayCommand<Plant>(RemoveFromLibrary);  // Inicjalizacja nowego polecenia
        }

        private void AddPlant(Plant plantToAdd)
        {
            if (plantToAdd != null)
            {
                MyPlantsViewModel.Instance.MyPlants.Add(plantToAdd);
            }
        }

        private void RemoveFromLibrary(Plant plantToRemove)  // Nowa metoda
        {
            if (plantToRemove != null)
            {
                AvailablePlants.Remove(plantToRemove);
            }
        }
    }
}

