﻿using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WirtualnyOgrod.Models;

namespace WirtualnyOgrod.ViewModels
{
    public class WateringScheduleViewModel : BaseViewModel
    {
        public ObservableCollection<WateringSchedule> Schedules { get; set; }

        public ICommand AddScheduleCommand { get; set; }
        public ICommand RemoveScheduleCommand { get; set; }

        public WateringScheduleViewModel()
        {
            Schedules = new ObservableCollection<WateringSchedule>();
            AddScheduleCommand = new RelayCommand<WateringSchedule>(AddSchedule);
            RemoveScheduleCommand = new RelayCommand<WateringSchedule>(RemoveSchedule);
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

        public void CreateWateringSchedule(Plant plant)
        {
            if (plant != null)
            {
                var schedule = new WateringSchedule
                {
                    PlantId = plant.Id,
                    LastWatered = DateTime.Now,
                    WateringFrequency = TimeSpan.FromDays(plant.WaterNeeds) // Przykład, dostosuj według potrzeb
                };
                Schedules.Add(schedule);
            }
        }
    }
}


