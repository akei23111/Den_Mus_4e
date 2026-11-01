namespace NotatkiKonsola
{
    /// <summary>
    /// Klasa: Notatka
    /// Opis: Przechowuje pojedynczą notatkę (tytuł i treść) oraz zlicza
    ///       wszystkie utworzone notatki za pomocą pola statycznego.
    /// Pola: licznik (private static int), id (private int),
    ///       tytul (protected string), tresc (protected string)
    /// Metody: Notatka(string, string) - konstruktor,
    ///         Wyswietl() - wypisuje tytuł i treść,
    ///         Diagnostyka() - wypisuje wszystkie pola oddzielone średnikami
    /// Autor: Denis_Muskyi 4E
    /// </summary>
    class Notatka
    {
        private static int licznik = 0;
        private int id;
        protected string tytul;
        protected string tresc;

        public Notatka(string tytul, string tresc)
        {
            licznik++;
            id = licznik;
            this.tytul = tytul;
            this.tresc = tresc;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Notatka: {tytul}");
            Console.WriteLine($"Treść:   {tresc}");
        }

        public void Diagnostyka()
        {
            Console.WriteLine($"{licznik};{id};{tytul};{tresc}");
        }
    }
}
