using NotatkiKonsola;

Notatka pierwsza = new Notatka("Zakupy", "Chleb, mleko, masło, jajka");
Notatka druga = new Notatka("Nauka", "Powtórzyć klasy i konstruktory przed egzaminem INF.04");

Console.WriteLine("=== Notatka 1 ===");
pierwsza.Wyswietl();
pierwsza.Diagnostyka();

Console.WriteLine();
Console.WriteLine("=== Notatka 2 ===");
druga.Wyswietl();
druga.Diagnostyka();

Console.WriteLine();
Console.WriteLine("Format diagnostyki: licznik;id;tytul;tresc");
Console.WriteLine("Oczekiwane: pierwsza -> id 1, druga -> id 2, licznik 2");
