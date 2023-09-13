using System;
using System.Collections.Generic;
using System.Text;
using WirtualnyOgrod.Models;

namespace WirtualnyOgrod.ViewModels
{
    public class GardenViewModel : BaseViewModel
    {
        private Garden _currentGarden;
        public Garden CurrentGarden
        {
            get { return _currentGarden; }
            set
            {
                _currentGarden = value;
                OnPropertyChanged();
            }
        }

        public GardenViewModel()
        {
            CurrentGarden = new Garden();
        }
    }

}
