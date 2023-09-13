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

        public ICommand AddPlantCommand { get; set; }

        public PlantLibraryViewModel()
        {
            AddPlantCommand = new RelayCommand<Plant>(AddPlant);
        }

        private void AddPlant(Plant plantToAdd)
        {
            if (plantToAdd != null)
            {
                MyPlantsViewModel.Instance.MyPlants.Add(plantToAdd);
            }
        }
    }
}

