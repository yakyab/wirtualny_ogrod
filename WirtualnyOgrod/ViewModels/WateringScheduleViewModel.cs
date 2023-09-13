using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using WirtualnyOgrod.Models;

namespace WirtualnyOgrod.ViewModels
{
    public class WateringScheduleViewModel : BaseViewModel
    {
        public ObservableCollection<WateringSchedule> Schedules { get; set; }
        public ICommand AddScheduleCommand { get; set; }
        public ICommand RemoveScheduleCommand { get; set; }
        public ICommand WaterPlantCommand { get; set; }

        public WateringScheduleViewModel()
        {
            Schedules = new ObservableCollection<WateringSchedule>();
            AddScheduleCommand = new RelayCommand<WateringSchedule>(AddSchedule);
            RemoveScheduleCommand = new RelayCommand<WateringSchedule>(RemoveSchedule);
            WaterPlantCommand = new RelayCommand<WateringSchedule>(WaterPlant);
        }

        private void AddSchedule(WateringSchedule scheduleToAdd)
        {
            if (scheduleToAdd != null && !Schedules.Contains(scheduleToAdd))
            {
                Schedules.Add(scheduleToAdd);
            }
        }

        private void RemoveSchedule(WateringSchedule scheduleToRemove)
        {
            if (scheduleToRemove != null)
            {
                Schedules.Remove(scheduleToRemove);
            }
        }

        private void WaterPlant(WateringSchedule scheduleToWater)
        {
            if (scheduleToWater != null)
            {
                // Resetowanie timera podlewania do jego początkowej wartości.
                // Zakładając, że początkowa wartość timera jest przechowywana w modelu Plant.
                var plant = MyPlantsViewModel.Instance.MyPlants.FirstOrDefault(p => p.Id == scheduleToWater.PlantId);
                if (plant != null)
                {
                    scheduleToWater.WateringTimer = plant.WateringTimer;
                }
            }
        }
    }
}


