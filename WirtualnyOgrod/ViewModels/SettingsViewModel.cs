namespace WirtualnyOgrod.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        private double _gardenScale = 1.0;

        public double GardenScale
        {
            get { return _gardenScale; }
            set
            {
                _gardenScale = value;
                OnPropertyChanged(nameof(GardenScale));
            }
        }
    }
}

