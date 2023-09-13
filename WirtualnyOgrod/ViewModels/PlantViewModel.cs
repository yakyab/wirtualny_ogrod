using System;
using System.Collections.Generic;
using System.Text;
using WirtualnyOgrod.Models;

namespace WirtualnyOgrod.ViewModels
{
    public class PlantViewModel : BaseViewModel
    {
        private Plant _currentPlant;
        public Plant CurrentPlant
        {
            get { return _currentPlant; }
            set
            {
                _currentPlant = value;
                OnPropertyChanged();
            }
        }

        public PlantViewModel()
        {
            CurrentPlant = new Plant();
        }
    }
}
