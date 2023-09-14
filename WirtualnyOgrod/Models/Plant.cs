using System;
using System.ComponentModel;

namespace WirtualnyOgrod.Models
{
    public class Plant : INotifyPropertyChanged
    {
        private int _wateringTimer;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int OriginalWateringTime { get; set; }

        public int WateringTimer
        {
            get { return _wateringTimer; }
            set
            {
                if (_wateringTimer != value)
                {
                    _wateringTimer = value;
                    OnPropertyChanged(nameof(WateringTimer));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}



