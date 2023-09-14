using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WirtualnyOgrod.Models;
using System.Windows.Threading;
using System.Linq;

namespace WirtualnyOgrod.ViewModels
{
    public class MyPlantsViewModel : BaseViewModel
    {
        private static MyPlantsViewModel _instance;
        public static MyPlantsViewModel Instance => _instance ??= new MyPlantsViewModel();

        private ObservableCollection<Plant> _myPlants = new ObservableCollection<Plant>();
        public ObservableCollection<Plant> MyPlants
        {
            get { return _myPlants; }
            set { _myPlants = value; OnPropertyChanged(nameof(MyPlants)); }
        }

        public ICommand RemovePlantCommand { get; set; }
        public ICommand AddPlantCommand { get; set; }
        public ICommand WaterPlantCommand { get; set; }

        private DispatcherTimer _timer;

        private MyPlantsViewModel()
        {
            RemovePlantCommand = new RelayCommand<Plant>(RemovePlant);
            WaterPlantCommand = new RelayCommand<Plant>(WaterPlant);

            InitializeTimer();
        }

        private void InitializeTimer()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += UpdateWateringTimers;
            _timer.Start();
        }

        private void UpdateWateringTimers(object sender, EventArgs e)
        {
            for (int i = MyPlants.Count - 1; i >= 0; i--)
            {
                var plant = MyPlants[i];
                plant.WateringTimer--;

                if (plant.WateringTimer <= 0)
                {
                    MyPlants.RemoveAt(i);
                }
            }
        }

        private void RemovePlant(Plant plantToRemove)
        {
            if (plantToRemove != null)
            {
                MyPlants.Remove(plantToRemove);
            }
        }

        private void WaterPlant(Plant plantToWater)
        {
            if (plantToWater != null)
            {
                plantToWater.WateringTimer = plantToWater.OriginalWateringTime;
            }
        }


    }
}






