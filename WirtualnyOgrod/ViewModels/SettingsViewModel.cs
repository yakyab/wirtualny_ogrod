using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace WirtualnyOgrod.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        private bool _isDarkMode;

        public bool IsDarkMode
        {
            get { return _isDarkMode; }
            set
            {
                _isDarkMode = value;
                OnPropertyChanged(nameof(IsDarkMode));
            }
        }

        public ICommand ToggleDarkModeCommand { get; set; }

        public SettingsViewModel()
        {
            ToggleDarkModeCommand = new RelayCommand(ToggleDarkMode);
        }

        private void ToggleDarkMode()
        {
            IsDarkMode = !IsDarkMode;
        }
    }
}
