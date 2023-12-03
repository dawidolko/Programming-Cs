using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.TASK4
{
    public class Liczba
    {
        private int[] cyfry;

        public Liczba(string liczba)
        {
            cyfry = liczba.Select(c => c - '0').Reverse().ToArray();
        }

        public void Wypisz()
        {
            for (int i = cyfry.Length - 1; i >= 0; i--)
            {
                Console.Write(cyfry[i]);
            }
            Console.WriteLine();
        }

        public void Pomnoz(int mnoznik)
        {
            int przesuniecie = 0;
            int[] wynik = new int[cyfry.Length + 10]; // Dodatkowe miejsce na przekroczenie zakresu

            for (int i = 0; i < cyfry.Length; i++)
            {
                int produkt = cyfry[i] * mnoznik + przesuniecie;
                wynik[i] = produkt % 10;
                przesuniecie = produkt / 10;
            }

            int pozycja = cyfry.Length;
            while (przesuniecie > 0)
            {
                wynik[pozycja++] = przesuniecie % 10;
                przesuniecie /= 10;
            }

            cyfry = wynik.Take(pozycja).ToArray();
        }

        public static Liczba Silnia(int n)
        {
            Liczba wynik = new Liczba("1");
            for (int i = 2; i <= n; i++)
            {
                wynik.Pomnoz(i);
            }
            return wynik;
        }
    }

}
