using Lab2;
using Lab2.TASK2;
using Lab2.TASK3;
using Lab2.TASK4;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        // ZADANIE 1
        Console.WriteLine("\n\nZADANIE: 1\n\n");

        Licz liczba1 = new Licz(10);
        Licz liczba2 = new Licz(20);

        // Wykonanie operacji na obiektach
        liczba1.Dodaj(5); // Dodaje 5 do liczba1
        liczba2.Odejmij(10); // Odejmuje 10 od liczba2

        // Wypisanie stanu obiektów
        liczba1.WypiszStan(); // Powinno wyświetlić 15
        liczba2.WypiszStan(); // Powinno wyświetlić 10

        // Wykonanie dodatkowych operacji
        liczba1.Odejmij(3); // Odejmuje 3 od liczba1
        liczba2.Dodaj(7); // Dodaje 7 do liczba2

        // Ponowne wypisanie stanu obiektów
        liczba1.WypiszStan(); // Powinno wyświetlić 12
        liczba2.WypiszStan(); // Powinno wyświetlić 17

        // ZADANIE 2
        Console.WriteLine("\n\nZADANIE: 2\n\n");

        int[] liczby = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Sumator sumator = new Sumator(liczby);

        Console.WriteLine("Suma wszystkich liczb: " + sumator.Suma());
        Console.WriteLine("Suma liczb podzielnych przez 2: " + sumator.SumaPodziel2());
        Console.WriteLine("Ilość elementów w tablicy: " + sumator.IleElementów());

        Console.WriteLine("Wszystkie elementy tablicy:");
        sumator.WypiszWszystkieElementy();

        Console.WriteLine("Elementy tablicy od indeksu 3 do 7:");
        sumator.WypiszElementy(3, 7);

        Console.WriteLine("Próba wypisania elementów poza zakresem tablicy:");
        sumator.WypiszElementy(-5, 15); // Przykład z indeksami wykraczającymi poza zakres

        // ZADANIE 3
        Console.WriteLine("\n\nZADANIE: 3\n\n");

        Data data = new Data();
        Console.WriteLine("Aktualna data: " + data.OdczytajDate().ToShortDateString());

        data.PrzesunTydzienDoPrzodu();
        Console.WriteLine("Data po przesunięciu o tydzień do przodu: " + data.OdczytajDate().ToShortDateString());

        data.PrzesunTydzienDoTylu();
        Console.WriteLine("Data po przesunięciu o tydzień do tyłu: " + data.OdczytajDate().ToShortDateString());

        // ZADANIE 4
        Console.WriteLine("\n\nZADANIE: 4\n\n");

        Liczba liczba = new Liczba("123");
        Console.WriteLine("Początkowa liczba:");
        liczba.Wypisz();

        liczba.Pomnoz(2);
        Console.WriteLine("Po pomnożeniu przez 2:");
        liczba.Wypisz();

        Liczba silnia = Liczba.Silnia(5);
        Console.WriteLine("Silnia liczby 5:");
        silnia.Wypisz();
    }
}