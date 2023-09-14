using System.ComponentModel;

namespace WirtualnyOgrod.Models
{
    /// <summary>
    /// Reprezentuje model rośliny w aplikacji.
    /// </summary>
    public class Plant : INotifyPropertyChanged
    {
        private int _wateringTimer;

        /// <summary>
        /// Unikalne ID rośliny.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nazwa rośliny.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Opis rośliny.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Oryginalny czas nawadniania rośliny.
        /// </summary>
        public int OriginalWateringTime { get; set; }

        /// <summary>
        /// Aktualny czas nawadniania rośliny.
        /// </summary>
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

        /// <summary>
        /// Zdarzenie wywoływane, gdy właściwość rośliny ulega zmianie.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Metoda wywoływana, gdy właściwość rośliny ulega zmianie.
        /// </summary>
        /// <param name="propertyName">Nazwa zmienionej właściwości.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}



