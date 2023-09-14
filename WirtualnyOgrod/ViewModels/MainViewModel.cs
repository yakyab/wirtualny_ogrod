using System.ComponentModel;

namespace WirtualnyOgrod.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class MainViewModel : BaseViewModel
    {
        private static MainViewModel _instance;
        public static MainViewModel Instance => _instance ??= new MainViewModel();

        public PlantLibraryViewModel PlantLibraryViewModel { get; set; }
        public MyPlantsViewModel MyPlantsViewModel { get; set; }
        public HelpViewModel HelpViewModel { get; set; }

        public MainViewModel()
        {
            PlantLibraryViewModel = PlantLibraryViewModel.Instance;
            MyPlantsViewModel = MyPlantsViewModel.Instance;
            HelpViewModel = new HelpViewModel();
        }
    }
}
