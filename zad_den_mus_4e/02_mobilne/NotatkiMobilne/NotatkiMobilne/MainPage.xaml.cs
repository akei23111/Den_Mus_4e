using System.Collections.ObjectModel;

namespace NotatkiMobilne
{
    public partial class MainPage : ContentPage
    {
        private readonly ObservableCollection<string> notatki = new ObservableCollection<string>
        {
            "Kupić prezent dla mamy",
            "Powtórzyć XAML przed egzaminem",
            "Spotkanie z zespołem w piątek"
        };

        public MainPage()
        {
            InitializeComponent();
            ListaNotatek.ItemsSource = notatki;
        }

        private void OnDodajClicked(object sender, EventArgs e)
        {
            string tekst = PoleNotatki.Text;

            if (string.IsNullOrWhiteSpace(tekst))
                return;

            notatki.Add(tekst.Trim());
            PoleNotatki.Text = string.Empty;
        }
    }
}
