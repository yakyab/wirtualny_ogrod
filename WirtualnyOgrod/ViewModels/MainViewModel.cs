using System.ComponentModel;

namespace WirtualnyOgrod.ViewModels
{
    /// <summary>
    /// Bazowy model widoku zapewniający obsługę powiadamiania o zmianach właściwości.
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Zdarzenie wywoływane, gdy właściwość modelu widoku ulega zmianie.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Metoda wywoływana, gdy właściwość modelu widoku ulega zmianie.
        /// </summary>
        /// <param name="propertyName">Nazwa zmienionej właściwości.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    /// <summary>
    /// Główny model widoku aplikacji, który agreguje inne modele widoku.
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        private static MainViewModel _instance;

        /// <summary>
        /// Singleton instancji MainViewModel.
        /// </summary>
        public static MainViewModel Instance => _instance ??= new MainViewModel();

        /// <summary>
        /// Model widoku biblioteki roślin.
        /// </summary>
        public PlantLibraryViewModel PlantLibraryViewModel { get; set; }

        /// <summary>
        /// Model widoku moich roślin.
        /// </summary>
        public MyPlantsViewModel MyPlantsViewModel { get; set; }

        /// <summary>
        /// Inicjalizuje nową instancję klasy <see cref="MainViewModel"/> i inicjuje modele widoku.
        /// </summary>
        public MainViewModel()
        {
            PlantLibraryViewModel = PlantLibraryViewModel.Instance;
            MyPlantsViewModel = MyPlantsViewModel.Instance;
        }
    }
}

