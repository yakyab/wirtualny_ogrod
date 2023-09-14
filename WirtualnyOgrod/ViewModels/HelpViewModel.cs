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

        private void InitializeHelpContent()
        {
            HelpContent = @"
            Wirtualny Ogród - Twoje miejsce do zarządzania roślinami!

            Moje rośliny:
            - Wyświetla listę Twoich roślin.
            - Możesz usunąć roślinę z listy.

            Biblioteka roślin:
            - Przeglądaj dostępne rośliny.
            - Dodaj rośliny do swojej kolekcji.

            Plan nawodnienia:
            - Monitoruj, kiedy Twoje rośliny potrzebują wody.
            - Podlewaj rośliny bezpośrednio z aplikacji.

            Skorzystaj z panelu bocznego, aby nawigować między różnymi sekcjami aplikacji.
            ";
        }

    }
}

