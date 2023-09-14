using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WirtualnyOgrod.Models;
using System.Windows.Threading;

namespace WirtualnyOgrod.ViewModels
{
    /// <summary>
    /// Model widoku reprezentujący zarządzanie moimi roślinami.
    /// </summary>
    public class MyPlantsViewModel : BaseViewModel
    {
        private static MyPlantsViewModel _instance;

        /// <summary>
        /// Singleton instancji MyPlantsViewModel.
        /// </summary>
        public static MyPlantsViewModel Instance => _instance ??= new MyPlantsViewModel();

        private ObservableCollection<Plant> _myPlants = new ObservableCollection<Plant>();

        /// <summary>
        /// Kolekcja moich roślin.
        /// </summary>
        public ObservableCollection<Plant> MyPlants
        {
            get { return _myPlants; }
            set { _myPlants = value; OnPropertyChanged(nameof(MyPlants)); }
        }

        /// <summary>
        /// Polecenie do usuwania rośliny.
        /// </summary>
        public ICommand RemovePlantCommand { get; set; }

        /// <summary>
        /// Polecenie do dodawania rośliny.
        /// </summary>
        public ICommand AddPlantCommand { get; set; }

        /// <summary>
        /// Polecenie do podlewania rośliny.
        /// </summary>
        public ICommand WaterPlantCommand { get; set; }

        private DispatcherTimer _timer;

        private MyPlantsViewModel()
        {
            RemovePlantCommand = new RelayCommand<Plant>(RemovePlant);
            WaterPlantCommand = new RelayCommand<Plant>(WaterPlant);

            InitializeTimer();
        }

        /// <summary>
        /// Inicjalizuje timer do aktualizacji czasu nawadniania roślin.
        /// </summary>
        private void InitializeTimer()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += UpdateWateringTimers;
            _timer.Start();
        }

        /// <summary>
        /// Aktualizuje timery nawadniania dla wszystkich roślin.
        /// </summary>
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

        /// <summary>
        /// Usuwa wybraną roślinę.
        /// </summary>
        private void RemovePlant(Plant plantToRemove)
        {
            if (plantToRemove != null)
            {
                MyPlants.Remove(plantToRemove);
            }
        }

        /// <summary>
        /// Podlewa wybraną roślinę.
        /// </summary>
        private void WaterPlant(Plant plantToWater)
        {
            if (plantToWater != null)
            {
                plantToWater.WateringTimer = plantToWater.OriginalWateringTime;
            }
        }
    }
}






