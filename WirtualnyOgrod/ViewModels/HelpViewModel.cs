namespace WirtualnyOgrod.ViewModels
{
    public class HelpViewModel : BaseViewModel
    {
        private string _helpContent;

        // Zawartość informacji pomocniczych dla użytkownika.
        public string HelpContent
        {
            get { return _helpContent; }
            set
            {
                _helpContent = value;
                OnPropertyChanged(nameof(HelpContent));
            }
        }

        public HelpViewModel()
        {
            InitializeHelpContent();
        }

        // Przykładowa metoda inicjalizująca zawartość informacji pomocniczych. 
        private void InitializeHelpContent()
        {
            HelpContent = "Tu jest informacja pomocnicza dla użytkownika. Opisuje, jak korzystać z aplikacji, jakie są jej funkcje, itp. Możesz to dostosować zgodnie z wymaganiami aplikacji.";
        }
    }
}

