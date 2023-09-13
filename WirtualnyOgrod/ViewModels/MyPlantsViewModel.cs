﻿using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WirtualnyOgrod.Models;

namespace WirtualnyOgrod.ViewModels
{
    public class MyPlantsViewModel : BaseViewModel
    {
        private static MyPlantsViewModel _instance;
        private ObservableCollection<Plant> _myPlants = new ObservableCollection<Plant>();

        public static MyPlantsViewModel Instance
        {
            get
            {
                return _instance ??= new MyPlantsViewModel();
            }
        }

        public ObservableCollection<Plant> MyPlants
        {
            get { return _myPlants; }
            set
            {
                _myPlants = value;
                OnPropertyChanged(nameof(MyPlants));
            }
        }

        public ICommand RemovePlantCommand { get; set; }

        private MyPlantsViewModel()
        {
            RemovePlantCommand = new RelayCommand<Plant>(RemovePlant, CanRemovePlant);
        }

        private void RemovePlant(Plant plantToRemove)
        {
            if (plantToRemove != null)
            {
                MyPlants.Remove(plantToRemove);
            }
        }

        private bool CanRemovePlant(Plant plantToRemove)
        {
            return plantToRemove != null && MyPlants.Contains(plantToRemove);
        }
    }
}
